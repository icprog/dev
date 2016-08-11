﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Xpo;
using NAS.DAL;
using NAS.DAL.CMS.ObjectDocument;
using NAS.DAL.Nomenclature.Organization;
using DevExpress.Web.ASPxEditors;
using DevExpress.Data.Filtering;
using WebModule.ERPSystem.CustomField.GUI.Control.Data;

namespace WebModule.ERPSystem.CustomField.GUI.Control.NASCustomFieldTypeBuiltInSingleSelectionListControl.Strategy
{
    public class NASCustomFieldTypeOrganizationBuiltInSingleSelectionListStrategy : NASCustomFieldTypeBuiltInSingleSelectionListStrategy
    {
        public override NASCustomFieldPredefinitionData GetPredefinitionDataOfObject(Guid objectCustomFieldId)
        {
            NASCustomFieldPredefinitionData ret = null;
            Session session = null;
            try
            {
                session = XpoHelper.GetNewSession();
                ObjectCustomFieldData objectCustomFieldData =
                    session.GetObjectByKey<ObjectCustomField>(objectCustomFieldId).ObjectCustomFieldDatas.FirstOrDefault();
                if (objectCustomFieldData != null)
                {
                    PredefinitionData predefinitionData =
                        (PredefinitionData)objectCustomFieldData.CustomFieldDataId;

                    Organization organization =
                                session.GetObjectByKey<Organization>(predefinitionData.RefId);

                    if (organization != null)
                    {
                        ret = new NASCustomFieldPredefinitionData()
                        {
                            Code = organization.Code,
                            Description = organization.Description,
                            Name = organization.Name,
                            PredefinitionType = Enum.GetName(typeof(SingleSelectionBuiltInTypeEnum),
                                SingleSelectionBuiltInTypeEnum.SINGLE_CHOICE_LIST_ORGANIZATION),
                            RefId = organization.OrganizationId
                        };
                    }
                }
                return ret;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (session != null) session.Dispose();
            }
        }

        public override NASCustomFieldPredefinitionData GetSelectedPredefinitionDataFromList(object source)
        {
            NASCustomFieldPredefinitionData ret = null;
            Session session = null;
            try
            {
                ASPxComboBox combo = source as ASPxComboBox;
                session = XpoHelper.GetNewSession();

                if (combo.Value == null)
                {
                    return null;
                }

                Guid supplierId = (Guid)combo.Value;

                Organization organization =
                            session.GetObjectByKey<Organization>(supplierId);

                if (organization != null)
                {
                    ret = new NASCustomFieldPredefinitionData()
                    {
                        Code = organization.Code,
                        Description = organization.Description,
                        Name = organization.Name,
                        PredefinitionType = Enum.GetName(typeof(SingleSelectionBuiltInTypeEnum),
                            SingleSelectionBuiltInTypeEnum.SINGLE_CHOICE_LIST_ORGANIZATION),
                        RefId = organization.OrganizationId
                    };
                }

                return ret;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (session != null) session.Dispose();
            }
        }

        public override void ItemRequestedByValue(DevExpress.Xpo.Session session, object source, DevExpress.Web.ASPxEditors.ListEditItemRequestedByValueEventArgs e)
        {
            ASPxComboBox combo = source as ASPxComboBox;
            Organization obj = session.GetObjectByKey<Organization>(e.Value);
            if (obj != null)
            {
                combo.DataSource = new Organization[] { obj };
                combo.DataBindItems();
            }
        }

        public override void ItemsRequestedByFilterCondition(DevExpress.Xpo.Session session, object source, DevExpress.Web.ASPxEditors.ListEditItemsRequestedByFilterConditionEventArgs e)
        {
            ASPxComboBox combo = source as ASPxComboBox;
            XPCollection<Organization> collection = new XPCollection<Organization>(session);
            collection.SkipReturnedObjects = e.BeginIndex;
            collection.TopReturnedObjects = e.EndIndex - e.BeginIndex + 1;

            OrganizationType subOrgOrganizationType =
                Util.getXPCollection<OrganizationType>(session, "Name",
                    OrganizationTypeConstant.NAAN_CUSTOMER_SUB_ORGANIZATION.Value).FirstOrDefault();

            CriteriaOperator criteria = CriteriaOperator.And(
                CriteriaOperator.Or(
                    new BinaryOperator("OrganizationId", Utility.CurrentSession.Instance.AccessingOrganizationId),
                //CriteriaOperator.And(
                //new BinaryOperator("ParentOrganizationId!Key", Utility.CurrentSession.Instance.AccessingOrganizationId),
                        new BinaryOperator("OrganizationTypeId", subOrgOrganizationType)
                //)
                ),
                //row status is active
                new BinaryOperator("RowStatus", Utility.Constant.ROWSTATUS_ACTIVE),
                CriteriaOperator.Or(
                //find code contains the filter
                    new BinaryOperator("Code", String.Format("%{0}%", e.Filter), BinaryOperatorType.Like),
                //find name contains the filter
                    new BinaryOperator("Name", String.Format("%{0}%", e.Filter), BinaryOperatorType.Like)
                )
            );

            collection.Criteria = criteria;
            collection.Sorting.Add(new SortProperty("Code", DevExpress.Xpo.DB.SortingDirection.Ascending));

            combo.DataSource = collection;
            combo.DataBindItems();
        }

        public override void Init(object source)
        {
            ASPxComboBox combo = source as ASPxComboBox;
            combo.TextField = "Name";
            combo.TextFormatString = "{0} - {1}";
            combo.ValueField = "OrganizationId";
            combo.ValueType = typeof(System.Guid);
            combo.Columns.Clear();
            combo.Columns.Add("Code", "Mã tổ chức");
            combo.Columns.Add("Name", "Tên tổ chức");
            combo.Columns.Add("ParentOrganizationId.Name", "Trực thuộc tổ chức");
        }
    }
}
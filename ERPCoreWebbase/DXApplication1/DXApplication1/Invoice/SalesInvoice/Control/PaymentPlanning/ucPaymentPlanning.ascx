﻿<%@ Control Language="C#" ClientIDMode="AutoID" AutoEventWireup="true" CodeBehind="ucPaymentPlanning.ascx.cs"
    Inherits="WebModule.Invoice.SalesInvoice.Control.PaymentPlanning.ucPaymentPlanning" %>
<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="100%">
    <Items>
        <dx:LayoutGroup Caption="Kế hoạch">
            <Items>
                <dx:LayoutItem ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxGridView ID="GridPlanning" runat="server" AutoGenerateColumns="False" KeyFieldName="TransactionId"
                                OnRowDeleting="GridPlanning_RowDeleting" OnRowInserting="GridPlanning_RowInserting"
                                OnRowUpdating="GridPlanning_RowUpdating" Width="100%" 
                                OnRowValidating="GridPlanning_RowValidating">
                                <Columns>
                                    <dx:GridViewDataDateColumn Caption="Ngày Thanh Toán (*)" FieldName="IssueDate" ShowInCustomizationForm="True"
                                        VisibleIndex="0" Width="100px">
                                        <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy">
                                        </PropertiesDateEdit>
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn Caption="Tên Đợt Thanh Toán" FieldName="Code" ShowInCustomizationForm="True"
                                        VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataSpinEditColumn Caption="Số Tiền (*)" FieldName="Amount" ShowInCustomizationForm="True"
                                        VisibleIndex="2" Width="110px">
                                        <PropertiesSpinEdit DisplayFormatString="g">
                                        </PropertiesSpinEdit>
                                    </dx:GridViewDataSpinEditColumn>
                                    <dx:GridViewDataTextColumn Caption="Ghi Chú" FieldName="Description" ShowInCustomizationForm="True"
                                        VisibleIndex="3">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewCommandColumn Caption="Thao tác" VisibleIndex="4" Width="100px" ButtonType="Image">
                                        <EditButton Visible="True">
                                            <Image>
                                                <SpriteProperties CssClass="Sprite_Edit" />
                                                <SpriteProperties CssClass="Sprite_Edit"></SpriteProperties>
                                            </Image>
                                        </EditButton>
                                        <NewButton Visible="True">
                                            <Image>
                                                <SpriteProperties CssClass="Sprite_New" />
                                                <SpriteProperties CssClass="Sprite_New"></SpriteProperties>
                                            </Image>
                                        </NewButton>
                                        <DeleteButton Visible="True">
                                            <Image>
                                                <SpriteProperties CssClass="Sprite_Delete" />
                                                <SpriteProperties CssClass="Sprite_Delete"></SpriteProperties>
                                            </Image>
                                        </DeleteButton>
                                        <CancelButton Visible="True">
                                            <Image>
                                                <SpriteProperties CssClass="Sprite_Cancel" />
                                                <SpriteProperties CssClass="Sprite_Cancel"></SpriteProperties>
                                            </Image>
                                        </CancelButton>
                                        <UpdateButton Visible="True">
                                            <Image>
                                                <SpriteProperties CssClass="Sprite_Apply" />
                                                <SpriteProperties CssClass="Sprite_Apply"></SpriteProperties>
                                            </Image>
                                        </UpdateButton>
                                    </dx:GridViewCommandColumn>
                                </Columns>
                                <SettingsEditing Mode="Inline" />
                                <Styles>
                                    <Header HorizontalAlign="Center">
                                    </Header>
                                </Styles>
                            </dx:ASPxGridView>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
        <dx:LayoutGroup Caption="Thực thu">
            <Items>
                <dx:LayoutItem ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxGridView ID="GridActual" runat="server" AutoGenerateColumns="False" Width="100%">
                                <Columns>
                                    <dx:GridViewDataDateColumn Caption="Ngày" FieldName="TransactionId.<ReceiptVouchesTransaction>pIssueDate" 
                                        ShowInCustomizationForm="True" VisibleIndex="0" Width="100px">
                                        <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy">
                                        </PropertiesDateEdit>
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn Caption="Số Tiền" ShowInCustomizationForm="True" 
                                        VisibleIndex="1" Width="110px" FieldName = "Debit">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Chứng Từ Gốc" ShowInCustomizationForm="True"
                                        VisibleIndex="2" FieldName = "TransactionId" Visible = "false">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Ghi Chú" ShowInCustomizationForm="True" VisibleIndex="3" FieldName = "Description">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <Styles>
                                    <Header HorizontalAlign="Center">
                                    </Header>
                                </Styles>
                            </dx:ASPxGridView>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>
<dx:ASPxCallback ID="cbPaymentPlanning" runat="server" ClientInstanceName="cbPaymentPlanning">
</dx:ASPxCallback>

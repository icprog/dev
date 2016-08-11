﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebModule.Accounting.AllocationConfigure.Controls
{
    public class AccountActorDepartmentComboBoxStrategyCreator : AccountActorComboBoxStrategyCreator
    {
        public override AccountActorComboBoxStrategy Create()
        {
            return new AccountActorDepartmentComboBoxStrategy();
        }
    }
}
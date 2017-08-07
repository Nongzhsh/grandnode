﻿using System;
using System.ComponentModel.DataAnnotations;

using Grand.Framework;
using Grand.Framework.Mvc;
using Grand.Framework.Mvc.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using Grand.Framework.Mvc.ModelBinding;
namespace Grand.Web.Areas.Admin.Models.Affiliates
{
    public partial class AffiliateListModel : BaseGrandModel
    {
        [GrandResourceDisplayName("Admin.Affiliates.List.SearchFirstName")]
        
        public string SearchFirstName { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.List.SearchLastName")]
        
        public string SearchLastName { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.List.SearchFriendlyUrlName")]
        
        public string SearchFriendlyUrlName { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.List.LoadOnlyWithOrders")]
        public bool LoadOnlyWithOrders { get; set; }
        [GrandResourceDisplayName("Admin.Affiliates.List.OrdersCreatedFromUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedFromUtc { get; set; }
        [GrandResourceDisplayName("Admin.Affiliates.List.OrdersCreatedToUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedToUtc { get; set; }
    }
}
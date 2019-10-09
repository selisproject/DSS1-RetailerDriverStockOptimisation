// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using zAppDev.DotNet.Framework.Mvc;
using AppCode;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
namespace DSS1_RetailerDriverStockOptimisation.Web.Code.WebApi
{


    [RoutePrefix("api/exportOFDetails")]
    [WebApiThrottle.EnableThrottling()]
    public class exportOFDetailsController : BasicApiCtrl
    {

        /// <summary>
        ///
        /// </summary>
        /// <returns>Collection</returns>
        [CustomWebApiActionFilter(LogEnabled = true, AllowPartialResponse = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("Export")]
        [HttpGet]
        public System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.Services.exportOFDetails.DataContracts.OrderForecastDetailsDTO> ExportOFDetails()
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS1_RetailerDriverStockOptimisation.Services.exportOFDetailsService()).ExportOFDetails(_RequestSourceIp, _UserName);
            return result;
        }
    }
}

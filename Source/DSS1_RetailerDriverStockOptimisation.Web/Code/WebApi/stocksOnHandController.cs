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


    [RoutePrefix("api/stocksOnHand")]
    [WebApiThrottle.EnableThrottling()]
    public class stocksOnHandController : BasicApiCtrl
    {

        /// <summary>
        /// Import Stock on Hand
        /// </summary>
        /// <returns>Response</returns>
        [CustomWebApiActionFilter(LogEnabled = true)]
        [CustomWebApiAuthorize(LogEnabled = true)]

        [Route("import")]
        [HttpPost]
        public DSS1_RetailerDriverStockOptimisation.Services.stocksOnHand.DataContracts.ResponseDTO Import([FromBody]System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.Services.stocksOnHand.DataContracts.StockOnHandDTO> stocks)
        {
            var request = ((HttpContextBase)Request.Properties["MS_HttpContext"]).Request;
            var _RequestSourceIp = request.UserHostAddress;
            var _UserName = Identity.IdentityHelper.GetCurrentUserName();
            var result =  (new DSS1_RetailerDriverStockOptimisation.Services.stocksOnHandService()).Import(stocks,_RequestSourceIp, _UserName);
            return result;
        }
    }
}

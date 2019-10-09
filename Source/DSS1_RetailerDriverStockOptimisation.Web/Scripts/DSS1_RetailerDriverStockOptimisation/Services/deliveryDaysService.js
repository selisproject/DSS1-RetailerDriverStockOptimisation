// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'deliveryDays' Service
         */
        var deliveryDaysServiceClient = /** @class */ (function () {
            function deliveryDaysServiceClient() {
            }
            /**
            * Import Delivery Days and Lead Time
            */
            deliveryDaysServiceClient.Import = function (deliverySchedules) {
                var _data = deliverySchedules;
                return axios.post(window._context.siteRoot + deliveryDaysServiceClient.baseUrl + "import", _data);
            };
            /**
             * Base url for 'deliveryDays' Service
             */
            deliveryDaysServiceClient.baseUrl = "/api/deliveryDays/";
            return deliveryDaysServiceClient;
        }());
        Services.deliveryDaysServiceClient = deliveryDaysServiceClient;
    })(Services = DSS1_RetailerDriverStockOptimisation.Services || (DSS1_RetailerDriverStockOptimisation.Services = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.deliveryDays = DSS1_RetailerDriverStockOptimisation.Services.deliveryDaysServiceClient;

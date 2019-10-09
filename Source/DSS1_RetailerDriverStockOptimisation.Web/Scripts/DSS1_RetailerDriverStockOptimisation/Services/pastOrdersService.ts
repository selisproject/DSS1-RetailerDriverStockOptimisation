// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.Services {
/**
 * Client for 'pastOrders' Service
 */
export class pastOrdersServiceClient {

    /**
     * Base url for 'pastOrders' Service
     */
    static baseUrl = "/api/pastOrders/";

    /**
    * Import Past Orders
    */
    public static Import(pOrders?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = pOrders;
                return axios.post(window._context.siteRoot + pastOrdersServiceClient.baseUrl + "import",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.pastOrders = DSS1_RetailerDriverStockOptimisation.Services.pastOrdersServiceClient;

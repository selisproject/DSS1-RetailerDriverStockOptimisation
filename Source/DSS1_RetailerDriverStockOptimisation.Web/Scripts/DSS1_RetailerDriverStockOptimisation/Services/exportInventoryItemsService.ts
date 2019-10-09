// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.Services {
/**
 * Client for 'exportInventoryItems' Service
 */
export class exportInventoryItemsServiceClient {

    /**
     * Base url for 'exportInventoryItems' Service
     */
    static baseUrl = "/api/exportInventoryItems/";

    /**
    *
    */
    public static Export(): Axios.IPromise<Axios.AxiosXHR<any>> {
        const _data = { params: {  } };
        return axios.get(window._context.siteRoot + exportInventoryItemsServiceClient.baseUrl + "Export",_data);
    }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.exportInventoryItems = DSS1_RetailerDriverStockOptimisation.Services.exportInventoryItemsServiceClient;

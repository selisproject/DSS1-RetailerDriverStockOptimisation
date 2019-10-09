// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSS1_RetailerDriverStockOptimisation.Services.exportInventoryItems.DataContracts;

namespace DSS1_RetailerDriverStockOptimisation.Services
{
    [XmlSerializerFormat]
    [ServiceContract]
    public interface IexportInventoryItemsService
    {
        [OperationContract]
        System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.Services.exportInventoryItems.DataContracts.InventoryItemDTO> Export(string _RequestSourceIp, string _UserName);


    }
}
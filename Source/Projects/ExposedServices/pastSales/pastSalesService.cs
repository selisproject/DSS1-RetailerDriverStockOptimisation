// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;
using System.Security.Permissions;
using System.Security.Principal;
using NHibernate;
using System.ServiceModel.Activation;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using DSS1_RetailerDriverStockOptimisation.Services.pastSales.DataContracts;
using DSS1_RetailerDriverStockOptimisation.BO;
using AutoMapper;

namespace DSS1_RetailerDriverStockOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class pastSalesService : IpastSalesService
    {
        public ResponseDTO Import(System.Collections.Generic.List<PastSalesDTO> _pastSales, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputpastSales = Mapper.Map<System.Collections.Generic.List<PastSalesDTO>, System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.PastSales>>(_pastSales);
                var _exposedOperation = ImportImplementation(inputpastSales);
                var result = Mapper.Map<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>(_exposedOperation);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("pastSales Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<ItemDTO, DSS1_RetailerDriverStockOptimisation.BO.Item>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Item, ItemDTO>();
            Mapper.CreateMap<ResponseDTO, DSS1_RetailerDriverStockOptimisation.BO.Response>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>();
            Mapper.CreateMap<SalesDTO, DSS1_RetailerDriverStockOptimisation.BO.Sales>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Sales, SalesDTO>()
            .Include<DSS1_RetailerDriverStockOptimisation.BO.PastSales, PastSalesDTO>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.PastSales, PastSalesDTO>();
            Mapper.CreateMap<PastSalesDTO, DSS1_RetailerDriverStockOptimisation.BO.PastSales>();
            Mapper.CreateMap<WarehouseDTO, DSS1_RetailerDriverStockOptimisation.BO.Warehouse>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Warehouse, WarehouseDTO>();
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.Response ImportImplementation(System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.PastSales> pastSales)
        {
            string message = "";
            foreach (var pastSale in pastSales ?? Enumerable.Empty<DSS1_RetailerDriverStockOptimisation.BO.PastSales>())
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Warehouse: " + (pastSale?.Warehouse?.Code ?? ""));
                if ((pastSale?.Item == null || pastSale?.Warehouse == null))
                {
                    message = message + (pastSale?.Id ?? 0) + " ,";
                    continue;
                }
                var _var0 = pastSale?.Item?.SKU;
                DSS1_RetailerDriverStockOptimisation.BO.Item existingItem = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Item>((s) => s.SKU == _var0)?.FirstOrDefault();
                var _var1 = pastSale?.Warehouse?.Code;
                DSS1_RetailerDriverStockOptimisation.BO.Warehouse existingWarehouse = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>((a) => a.Code == _var1)?.FirstOrDefault();
                if ((existingItem == null || existingWarehouse == null))
                {
                    message = message + (pastSale?.Id ?? 0) + " ,";
                    continue;
                }
                DSS1_RetailerDriverStockOptimisation.BO.PastSales newSalesForecast = new DSS1_RetailerDriverStockOptimisation.BO.PastSales();
                newSalesForecast.Warehouse = existingWarehouse;
                newSalesForecast.Item = existingItem;
                newSalesForecast.ForecastDate = (pastSale?.ForecastDate ?? System.Data.SqlTypes.SqlDateTime.MinValue.Value);
                newSalesForecast.Units = (pastSale?.Units ?? 0);
                new DSS1_RetailerDriverStockOptimisation.DAL.Repository().Save<DSS1_RetailerDriverStockOptimisation.BO.PastSales>(newSalesForecast);
            }
            if (((((message == null || message == "")) == false)))
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Error message: " + message);
                return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Failed", "Failed to import the entries with Ids " + message, "", "-1");
            }
            return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Succeed", "All entries imported successfully.", "", "1");
        }


    }
}
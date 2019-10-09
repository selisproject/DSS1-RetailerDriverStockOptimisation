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
using DSS1_RetailerDriverStockOptimisation.Services.deliveryDays.DataContracts;
using DSS1_RetailerDriverStockOptimisation.BO;
using AutoMapper;

namespace DSS1_RetailerDriverStockOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class deliveryDaysService : IdeliveryDaysService
    {
        public ResponseDTO Import(System.Collections.Generic.List<DeliveryScheduleDTO> _deliverySchedules, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputdeliverySchedules = Mapper.Map<System.Collections.Generic.List<DeliveryScheduleDTO>, System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule>>(_deliverySchedules);
                var _import = ImportImplementation(inputdeliverySchedules);
                var result = Mapper.Map<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>(_import);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("deliveryDays Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<DeliveryScheduleDTO, DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule, DeliveryScheduleDTO>();
            Mapper.CreateMap<SupplierDTO, DSS1_RetailerDriverStockOptimisation.BO.Supplier>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Supplier, SupplierDTO>();
            Mapper.CreateMap<ItemDTO, DSS1_RetailerDriverStockOptimisation.BO.Item>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Item, ItemDTO>();
            Mapper.CreateMap<WarehouseDTO, DSS1_RetailerDriverStockOptimisation.BO.Warehouse>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Warehouse, WarehouseDTO>();
            Mapper.CreateMap<ResponseDTO, DSS1_RetailerDriverStockOptimisation.BO.Response>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>();
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.Response ImportImplementation(System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule> deliverySchedules)
        {
            string message = "";
            foreach (var delSchedule in deliverySchedules ?? Enumerable.Empty<DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule>())
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Warehouse: " + (delSchedule?.Warehouse?.Code ?? ""));
                if ((delSchedule?.Supplier == null || delSchedule?.Warehouse == null))
                {
                    message = message + (delSchedule?.Id ?? 0) + " ,";
                    continue;
                }
                var _var0 = delSchedule?.Supplier?.Code;
                DSS1_RetailerDriverStockOptimisation.BO.Supplier existingSupplier = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Supplier>((w) => w.Code == _var0)?.FirstOrDefault();
                var _var1 = delSchedule?.Warehouse?.Code;
                DSS1_RetailerDriverStockOptimisation.BO.Warehouse existingWarehouse = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>((a) => a.Code == _var1)?.FirstOrDefault();
                if ((existingSupplier == null || existingWarehouse == null))
                {
                    message = message + (delSchedule?.Id ?? 0) + " ,";
                    continue;
                }
                DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule newDelSchedule = new DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule();
                newDelSchedule.Supplier = existingSupplier;
                newDelSchedule.Warehouse = existingWarehouse;
                newDelSchedule.LeadTime = (delSchedule?.LeadTime ?? 0);
                newDelSchedule.Weekday = (delSchedule?.Weekday ?? 0);
                new DSS1_RetailerDriverStockOptimisation.DAL.Repository().Save<DSS1_RetailerDriverStockOptimisation.BO.DeliverySchedule>(newDelSchedule);
            }
            if (((((message == null || message == "")) == false)))
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Error message: " + message);
                return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Failed", "Failed to import entries with Ids: " + message, "", "-1");
            }
            return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Succeed", "All entries imported successfully.", "", "1");
        }


    }
}
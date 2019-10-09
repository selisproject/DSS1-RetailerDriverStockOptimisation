// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.OrderForecast;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast
{
    public class OrderForecastViewModel : MasterPageViewModel
    {
        public List<SelectedItemInfo<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>> ListSelectedItems;


        public OrderForecastViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel))]
    public class OrderForecastViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel>
    {

        [JsonConstructor]
        public OrderForecastViewModelDTO() { }
        public OrderForecastViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ListSelectedItemKeys = original.ListSelectedItems == null
                                   ? null
                                   : original.ListSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel).FullName;
        public List<SelectedItemInfo<int?>> ListSelectedItemKeys;

        public new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel();
        }
        new  public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.OrderForecast.OrderForecastViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ListSelectedItems = ListSelectedItemKeys == null
                                         ? new List<SelectedItemInfo<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>>()
                                         : ListSelectedItemKeys.Select(x => new SelectedItemInfo<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>(x.SelectedItems.Select(y => ViewModels.OrderForecast.OrderProposalDataSet_OrderForecastDetailsDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails))]
    [DataSetDTO]
    public class OrderProposalDataSet_OrderForecastDetailsDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>
    {
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails).FullName;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public OrderProposalDataSet_OrderForecastDTO OrderForecast;
        public OrderProposalDataSet_ItemDTO Item;
        public OrderProposalDataSet_WarehouseDTO Warehouse;
        public decimal? Quantity;
        public DateTime? RecommendedOrderDate;
        public DateTime? SalesForecastDate;


        [JsonConstructor]
        public OrderProposalDataSet_OrderForecastDetailsDTO() : base() {}
        public  static OrderProposalDataSet_OrderForecastDetailsDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrderForecastController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderProposalDataSet_OrderForecastDetailsDTO(foundEntry);
            }
            return null;
        }
        public OrderProposalDataSet_OrderForecastDetailsDTO(DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderProposalDataSet_OrderForecastDetailsDTO(DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            OrderForecast = original.OrderForecast == null
                            ? null
                            : DTOHelper.GetDTOFromModel<OrderProposalDataSet_OrderForecastDTO>(original.OrderForecast as DSS1_RetailerDriverStockOptimisation.BO.OrderForecast);
            Item = original.Item == null
                   ? null
                   : DTOHelper.GetDTOFromModel<OrderProposalDataSet_ItemDTO>(original.Item as DSS1_RetailerDriverStockOptimisation.BO.Item);
            Warehouse = original.Warehouse == null
                        ? null
                        : DTOHelper.GetDTOFromModel<OrderProposalDataSet_WarehouseDTO>(original.Warehouse as DSS1_RetailerDriverStockOptimisation.BO.Warehouse);
            Quantity = original.Quantity;
            RecommendedOrderDate = original.RecommendedOrderDate;
            SalesForecastDate = original.SalesForecastDate;
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>(parsedKey, false);
        }
        public DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails Convert()
        {
            var model = new DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.OrderForecast = OrderForecast == null
                                  ? null
                                  : DTOHelper.GetModelFromDTO<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(OrderForecast);
            model.Item = Item == null
                         ? null
                         : DTOHelper.GetModelFromDTO<DSS1_RetailerDriverStockOptimisation.BO.Item>(Item);
            model.Warehouse = Warehouse == null
                              ? null
                              : DTOHelper.GetModelFromDTO<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>(Warehouse);
            model.Quantity = Quantity;
            model.RecommendedOrderDate = RecommendedOrderDate;
            model.SalesForecastDate = SalesForecastDate;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.BO.OrderForecast))]
    [DataSetDTO]
    public class OrderProposalDataSet_OrderForecastDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>
    {
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.BO.OrderForecast).FullName;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Status;
        public string CreatedBy;
        public DateTime? CreatedOn;
        public DateTime? StartDate;
        public DateTime? EndDate;


        [JsonConstructor]
        public OrderProposalDataSet_OrderForecastDTO() : base() {}
        public  static OrderProposalDataSet_OrderForecastDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrderForecastController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderProposalDataSet_OrderForecastDTO(foundEntry);
            }
            return null;
        }
        public OrderProposalDataSet_OrderForecastDTO(DSS1_RetailerDriverStockOptimisation.BO.OrderForecast original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderProposalDataSet_OrderForecastDTO(DSS1_RetailerDriverStockOptimisation.BO.OrderForecast original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Status = original.Status;
            CreatedBy = original.CreatedBy;
            CreatedOn = original.CreatedOn;
            StartDate = original.StartDate;
            EndDate = original.EndDate;
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.OrderForecast GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(parsedKey, false);
        }
        public DSS1_RetailerDriverStockOptimisation.BO.OrderForecast Convert()
        {
            var model = new DSS1_RetailerDriverStockOptimisation.BO.OrderForecast();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Status = Status;
            model.CreatedBy = CreatedBy;
            model.CreatedOn = CreatedOn;
            model.StartDate = StartDate;
            model.EndDate = EndDate;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.BO.Item))]
    [DataSetDTO]
    public class OrderProposalDataSet_ItemDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.BO.Item>
    {
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.BO.Item).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public string SKU;
        public new object _key
        {
            get;
            set;
        }
        public string Description;


        [JsonConstructor]
        public OrderProposalDataSet_ItemDTO() : base() {}
        public  static OrderProposalDataSet_ItemDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Item>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrderForecastController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS1_RetailerDriverStockOptimisation.BO.Item>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderProposalDataSet_ItemDTO(foundEntry);
            }
            return null;
        }
        public OrderProposalDataSet_ItemDTO(DSS1_RetailerDriverStockOptimisation.BO.Item original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, SKU);
        }
        public OrderProposalDataSet_ItemDTO(DSS1_RetailerDriverStockOptimisation.BO.Item original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.SKU == "") ? original._GetUniqueIdentifier() as object : original.SKU as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            SKU = original.SKU;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Description = original.Description;
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.Item GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Item>(parsedKey, false);
        }
        public DSS1_RetailerDriverStockOptimisation.BO.Item Convert()
        {
            var model = new DSS1_RetailerDriverStockOptimisation.BO.Item();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Item>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.SKU = SKU ?? "";
            model.Description = Description;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.BO.Warehouse))]
    [DataSetDTO]
    public class OrderProposalDataSet_WarehouseDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>
    {
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.BO.Warehouse).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Description;


        [JsonConstructor]
        public OrderProposalDataSet_WarehouseDTO() : base() {}
        public  static OrderProposalDataSet_WarehouseDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrderForecastController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderProposalDataSet_WarehouseDTO(foundEntry);
            }
            return null;
        }
        public OrderProposalDataSet_WarehouseDTO(DSS1_RetailerDriverStockOptimisation.BO.Warehouse original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderProposalDataSet_WarehouseDTO(DSS1_RetailerDriverStockOptimisation.BO.Warehouse original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Description = original.Description;
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.Warehouse GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>(parsedKey, false);
        }
        public DSS1_RetailerDriverStockOptimisation.BO.Warehouse Convert()
        {
            var model = new DSS1_RetailerDriverStockOptimisation.BO.Warehouse();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Warehouse>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Description = Description;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    #endregion

}

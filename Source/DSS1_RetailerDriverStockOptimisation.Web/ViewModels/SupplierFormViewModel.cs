// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.SupplierForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm
{
    public class SupplierFormViewModel : MasterPageViewModel
    {
        public DSS1_RetailerDriverStockOptimisation.BO.Supplier Supplier;


        public SupplierFormViewModel()
        {
            Supplier = new DSS1_RetailerDriverStockOptimisation.BO.Supplier();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(Supplier))
            {
                manager.Session.Evict(Supplier);
            }
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel))]
    public class SupplierFormViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel>
    {

        [JsonConstructor]
        public SupplierFormViewModelDTO() { }
        public SupplierFormViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            Supplier = original.Supplier == null ? null : new Supplier_SupplierDTO(original.Supplier);
        }
        public Supplier_SupplierDTO Supplier;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel).FullName;

        public new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel();
        }
        new  public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm.SupplierFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.Supplier = Supplier == null
                                ? null
                                : Supplier.Convert();
        }
    }

    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.BO.Supplier))]
    public class Supplier_SupplierDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.BO.Supplier>
    {

        [JsonConstructor]
        public Supplier_SupplierDTO() { }
        public Supplier_SupplierDTO(DSS1_RetailerDriverStockOptimisation.BO.Supplier original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Code = original.Code;
            Id = original.Id;
            Name = original.Name;
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string Code;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Name;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.BO.Supplier).FullName;
        public override List<string> _baseClasses => new List<string> {typeof(DSS1_RetailerDriverStockOptimisation.BO.Company).FullName};
        public DSS1_RetailerDriverStockOptimisation.BO.Supplier GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.BO.Supplier>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS1_RetailerDriverStockOptimisation.BO.Supplier();
            }
            return new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Supplier>(parsedKey, false);
        }
        public DSS1_RetailerDriverStockOptimisation.BO.Supplier Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.BO.Supplier();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.BO.Supplier original)
        {
            if (original == null) return;
            original.Code = Code;
            original.Id = Id ?? 0;
            original.Name = Name;
        }
        public static Supplier_SupplierDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Supplier>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Supplier_SupplierDTO(foundEntry);
            }
            return null;
        }
    }



}

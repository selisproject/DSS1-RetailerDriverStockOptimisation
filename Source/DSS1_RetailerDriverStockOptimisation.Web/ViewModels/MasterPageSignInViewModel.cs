// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPageSignIn;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn
{
    public class MasterPageSignInViewModel
    {


        public MasterPageSignInViewModel()
        {
        }


        public virtual void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel))]
    public class MasterPageSignInViewModelDTO : ViewModelDTOBase, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel>
    {

        [JsonConstructor]
        public MasterPageSignInViewModelDTO() { }
        public MasterPageSignInViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel).FullName;

        public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel();
        }
        public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPageSignIn.MasterPageSignInViewModel original)
        {
            if (original == null) return;
        }
    }



}

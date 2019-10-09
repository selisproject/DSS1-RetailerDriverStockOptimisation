// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.UserPreferences;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences
{
    public class UserPreferencesViewModel : MasterPageViewModel
    {
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser ApplicationUser;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>> LanguageBoxSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>> LocaleBoxSelectedItems;


        public UserPreferencesViewModel()
        {
            ApplicationUser = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(ApplicationUser))
            {
                manager.Session.Evict(ApplicationUser);
            }
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel))]
    public class UserPreferencesViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel>
    {

        [JsonConstructor]
        public UserPreferencesViewModelDTO() { }
        public UserPreferencesViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ApplicationUser = original.ApplicationUser == null ? null : new ApplicationUser_ApplicationUserDTO(original.ApplicationUser);
            LanguageBoxSelectedItemKeys = original.LanguageBoxSelectedItems == null
                                          ? null
                                          : original.LanguageBoxSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            LocaleBoxSelectedItemKeys = original.LocaleBoxSelectedItems == null
                                        ? null
                                        : original.LocaleBoxSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public ApplicationUser_ApplicationUserDTO ApplicationUser;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel).FullName;
        public List<SelectedItemInfo<int?>> LanguageBoxSelectedItemKeys;
        public List<SelectedItemInfo<ViewModels.UserPreferences.LanguageBoxDataSet_ApplicationLanguageDTO>> LanguageBox__InitialSelection;
        public List<SelectedItemInfo<int?>> LocaleBoxSelectedItemKeys;
        public List<SelectedItemInfo<ViewModels.UserPreferences.LocaleBoxDataSet_ApplicationLanguageDTO>> LocaleBox__InitialSelection;

        public new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel();
        }
        new  public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.UserPreferences.UserPreferencesViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ApplicationUser = ApplicationUser == null
                                       ? null
                                       : ApplicationUser.Convert();
            original.LanguageBoxSelectedItems = LanguageBoxSelectedItemKeys == null
                                                ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>>()
                                                : LanguageBoxSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(x.SelectedItems.Select(y => ViewModels.UserPreferences.LanguageBoxDataSet_ApplicationLanguageDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.LocaleBoxSelectedItems = LocaleBoxSelectedItemKeys == null
                                              ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>>()
                                              : LocaleBoxSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(x.SelectedItems.Select(y => ViewModels.UserPreferences.LocaleBoxDataSet_ApplicationLanguageDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public void FillDropDownsInitialValues(UserPreferencesViewModel original, UserPreferencesController _controller)
        {
            LanguageBox__InitialSelection = new List<SelectedItemInfo<ViewModels.UserPreferences.LanguageBoxDataSet_ApplicationLanguageDTO>>();
            LocaleBox__InitialSelection = new List<SelectedItemInfo<ViewModels.UserPreferences.LocaleBoxDataSet_ApplicationLanguageDTO>>();
            if (original == null) return;
            var LanguageBoxInitiallySelectedItem = original?.ApplicationUser?.Profile == null
                                                   ? null
                                                   : zAppDev.DotNet.Framework.Identity.ProfileHelper.GetAllAvailableLanguages().Where(c => c.Id == original.ApplicationUser.Profile.LanguageLCID).FirstOrDefault();
            if (LanguageBoxInitiallySelectedItem != null)
            {
                LanguageBox__InitialSelection.Add
                (
                    new SelectedItemInfo<ViewModels.UserPreferences.LanguageBoxDataSet_ApplicationLanguageDTO>(new List<ViewModels.UserPreferences.LanguageBoxDataSet_ApplicationLanguageDTO>
                {
                    new LanguageBoxDataSet_ApplicationLanguageDTO(LanguageBoxInitiallySelectedItem)
                }, "_", false)
                );
            }
            var LocaleBoxInitiallySelectedItem = original?.ApplicationUser?.Profile == null
                                                 ? null
                                                 : zAppDev.DotNet.Framework.Identity.ProfileHelper.GetAllAvailableLanguages().Where(c => c.Id == original.ApplicationUser.Profile.LocaleLCID).FirstOrDefault();
            if (LocaleBoxInitiallySelectedItem != null)
            {
                LocaleBox__InitialSelection.Add
                (
                    new SelectedItemInfo<ViewModels.UserPreferences.LocaleBoxDataSet_ApplicationLanguageDTO>(new List<ViewModels.UserPreferences.LocaleBoxDataSet_ApplicationLanguageDTO>
                {
                    new LocaleBoxDataSet_ApplicationLanguageDTO(LocaleBoxInitiallySelectedItem)
                }, "_", false)
                );
            }
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    public class ApplicationUser_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
    {

        [JsonConstructor]
        public ApplicationUser_ApplicationUserDTO() { }
        public ApplicationUser_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.UserName as object;
            UserName = original.UserName;
            Profile = original.Profile == null ? null : new ApplicationUser_ApplicationUser_Profile_ProfileDTO(original.Profile);
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public string UserName;
        public new object _key
        {
            get;
            set;
        }
        public ApplicationUser_ApplicationUser_Profile_ProfileDTO Profile;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            if (parsedKey == default(string) || Equals(parsedKey, default(string)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
        {
            if (original == null) return;
            original.UserName = UserName ?? "";
            original.Profile = Profile == null
                               ? null
                               : Profile.Convert();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ApplicationUser_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ApplicationUser_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.Profile))]
    public class ApplicationUser_ApplicationUser_Profile_ProfileDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.Profile>
    {

        [JsonConstructor]
        public ApplicationUser_ApplicationUser_Profile_ProfileDTO() { }
        public ApplicationUser_ApplicationUser_Profile_ProfileDTO(zAppDev.DotNet.Framework.Identity.Model.Profile original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            LanguageLCID = original.LanguageLCID;
            LocaleLCID = original.LocaleLCID;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public int? LanguageLCID;
        public int? LocaleLCID;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.Profile).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.Profile GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.Profile>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.Profile();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.Profile>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.Profile Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.Profile();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.Profile original)
        {
            if (original == null) return;
            original.Id = Id ?? 0;
            original.LanguageLCID = LanguageLCID;
            original.LocaleLCID = LocaleLCID;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ApplicationUser_ApplicationUser_Profile_ProfileDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.Profile>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ApplicationUser_ApplicationUser_Profile_ProfileDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage))]
    [DataSetDTO]
    public class LanguageBoxDataSet_ApplicationLanguageDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Name;


        [JsonConstructor]
        public LanguageBoxDataSet_ApplicationLanguageDTO() : base() {}
        public  static LanguageBoxDataSet_ApplicationLanguageDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new UserPreferencesController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new LanguageBoxDataSet_ApplicationLanguageDTO(foundEntry);
            }
            return null;
        }
        public LanguageBoxDataSet_ApplicationLanguageDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public LanguageBoxDataSet_ApplicationLanguageDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage original)
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
            Name = original.Name;
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Name = Name;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage))]
    [DataSetDTO]
    public class LocaleBoxDataSet_ApplicationLanguageDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Name;


        [JsonConstructor]
        public LocaleBoxDataSet_ApplicationLanguageDTO() : base() {}
        public  static LocaleBoxDataSet_ApplicationLanguageDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new UserPreferencesController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new LocaleBoxDataSet_ApplicationLanguageDTO(foundEntry);
            }
            return null;
        }
        public LocaleBoxDataSet_ApplicationLanguageDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public LocaleBoxDataSet_ApplicationLanguageDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage original)
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
            Name = original.Name;
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Name = Name;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}

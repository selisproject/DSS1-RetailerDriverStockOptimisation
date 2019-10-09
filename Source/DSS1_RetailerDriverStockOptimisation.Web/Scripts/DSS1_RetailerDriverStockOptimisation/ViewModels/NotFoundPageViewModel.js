var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var ViewModels;
    (function (ViewModels) {
        var NotFoundPage;
        (function (NotFoundPage) {
            var NotFoundPageViewModel = /** @class */ (function (_super) {
                __extends(NotFoundPageViewModel, _super);
                function NotFoundPageViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {};
                    }
                    else {
                    }
                    return _this;
                }
                NotFoundPageViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                NotFoundPageViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new NotFoundPageViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateNotFoundPageViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                NotFoundPageViewModel.prototype._hydrateNotFoundPageViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = NotFoundPageViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        NotFoundPageViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                NotFoundPageViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = NotFoundPageViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    NotFoundPageViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                NotFoundPageViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                NotFoundPageViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return NotFoundPageViewModel;
            }(DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            NotFoundPage.NotFoundPageViewModel = NotFoundPageViewModel;
        })(NotFoundPage = ViewModels.NotFoundPage || (ViewModels.NotFoundPage = {}));
    })(ViewModels = DSS1_RetailerDriverStockOptimisation.ViewModels || (DSS1_RetailerDriverStockOptimisation.ViewModels = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));

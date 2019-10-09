var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = function (e) {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg; // Gecko, Trident, Chrome 34+
        return msg;
    }
};
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Controllers;
    (function (Controllers) {
        var SupplierOrderForecastConditionalFormattings = [];
        var SupplierOrderForecastDataValidations = [];
        var SupplierOrderForecastCalculatedExpressions = [];
        // Datasets Column Info
        var OrderProposalList_ColumnInfo = [
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Item.SKU",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Item.SKU", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 100,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Item.Description",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Item.Description", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 100,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Warehouse.Description",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Warehouse.Description", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 100,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "decimal",
                dataTypeIsEnum: false,
                name: "Quantity",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Quantity", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "DateTime",
                dataTypeIsEnum: false,
                name: "RecommendedOrderDate",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "RecommendedOrderDate", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy', 'excelFormat': 'dd/MM/yyyy' },
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "DateTime",
                dataTypeIsEnum: false,
                name: "SalesForecastDate",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SalesForecastDate", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy', 'excelFormat': 'dd/MM/yyyy' },
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "bool",
                dataTypeIsEnum: false,
                name: "SupplierCanDeliver",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SupplierCanDeliver", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: true,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.CHECKBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "decimal",
                dataTypeIsEnum: false,
                name: "SupplierMaxQuantity",
                caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SupplierMaxQuantity", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: true,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            })
        ];
        window["OrderProposalList_ColumnInfo"] = OrderProposalList_ColumnInfo;
        // Datasets Projection Shemas
        window["OrderProposalList_ProjectionScema"] = {};
        var SupplierOrderForecastController = /** @class */ (function () {
            function SupplierOrderForecastController($scope, $timeout) {
                this.$scope = $scope;
                this.controllerActionFinished = function (resetDirty) {
                    //window.scope_SupplierOrderForecast.model = window.scope_SupplierOrderForecast.dehydrate();
                    //window.scope_MasterPage.model = window.scope_SupplierOrderForecast.model;
                    DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._lightCast(window.scope_SupplierOrderForecast.model);
                    // Joove.Common.applyScope(window.scope_SupplierOrderForecast);
                    if (resetDirty) {
                        window._context.isDirty = false;
                    }
                    window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
                };
                window.scope_SupplierOrderForecast = $scope;
                $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
                    Joove.Core.onChange(event.target, newValue, dontMakeDirty);
                };
                $scope.dehydrate = function (context) {
                    if (context === void 0) { context = null; }
                    return DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._initializeFrom($scope.model, context);
                };
                $scope._validationsMaster = window.scope_MasterPage._validations;
                $scope._validations = { summary: [],
                };
                this.init($scope, $timeout);
                $timeout(function () {
                    window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, function () {
                        $("body").fadeIn(200);
                    });
                });
            }
            SupplierOrderForecastController.prototype.init = function ($scope, $timeout) {
                var _this = this;
                $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._initializeFrom(window.viewDTO.Model);
                window.scope_MasterPage.model = $scope.model;
                new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
                $scope.trackObject = function (obj) { return Joove.Common.trackObject(obj); };
                //}
                $.connection['eventsHub'].on('__connectedEvent');
                $.connection['eventsHub'].on('forcePageReload', function () {
                    window.onbeforeunload = null;
                    setTimeout(function () {
                        window.location.reload();
                    }, 3000);
                });
                $.connection.hub.start(function () {
                    Joove.Common.getScope().connectedToSignals();
                    Joove.Common.getMasterScope().connectedToSignals();
                });
                $scope.connectedToSignals = function () {
                };
                // Event Listeners
                $scope.events = {};
                $scope.expressions = {};
                // Dataset Handler
                $scope.datasets = {};
                // Controller actions
                $scope.actions = {
                    Retrieve: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("SupplierOrderForecast", "Retrieve", "GET", [], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                };
                // Events
                $scope.eventCallbacks = {};
                // Rules
                window._ruleEngine.addDataValidations(SupplierOrderForecastDataValidations);
                window._ruleEngine.addConditionalFormattings(SupplierOrderForecastConditionalFormattings);
                window._ruleEngine.addCalculatedExpressions(SupplierOrderForecastCalculatedExpressions);
                window._commander.executeCommands(window.viewDTO.ClientCommands);
                window.viewDTO.ClientCommands = [];
                Joove.Common.setNumberLocalizationSettings();
                Joove.DeveloperApi.init($scope, window.scope_MasterPage);
                window.$formExtend && window.$formExtend();
                window.$onFormLoaded && window.$onFormLoaded();
            };
            return SupplierOrderForecastController;
        }());
        angular.module("Application").controller("SupplierOrderForecastController", ["$scope", "$timeout", SupplierOrderForecastController]);
    })(Controllers = DSS1_RetailerDriverStockOptimisation.Controllers || (DSS1_RetailerDriverStockOptimisation.Controllers = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));

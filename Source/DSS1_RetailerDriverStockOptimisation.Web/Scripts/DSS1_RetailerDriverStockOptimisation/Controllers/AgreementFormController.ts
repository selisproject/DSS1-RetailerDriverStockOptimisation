// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_AgreementForm: DSS1_RetailerDriverStockOptimisation.Controllers.IAgreementFormScope; }
namespace DSS1_RetailerDriverStockOptimisation.Controllers {
const AgreementFormConditionalFormattings = [
        ];
const AgreementFormDataValidations = [
                                     ];
const AgreementFormCalculatedExpressions = [
        ];
// Manual Data for txtStatus
window["dataFortxtStatus"] = [ {
_key: "A",
_text: window._resourcesManager.getComboBoxManualValueDisplay('FullTruckDS', '0', false , null),
_default: false
}, {
_key: "INACTIVE",
_text: window._resourcesManager.getComboBoxManualValueDisplay('FullTruckDS', '1', false , null),
_default: false
} ]

// Datasets Column Info
export var FullTruckDS_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["FullTruckDS_ColumnInfo"] = FullTruckDS_ColumnInfo;

// Datasets Projection Shemas

window["FileAttachment_ProjectionScema"] = {Agreement:
                                            {Id: ''
                                                    , AgreementDocument:
                                                    {}
                                            }
                                           };


export interface IAgreementFormScope extends Joove.IWebPageScope {
model:
    DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class AgreementFormController {
private timeoutDelayLockButtonClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_AgreementForm.model = window.scope_AgreementForm.dehydrate();
        //window.scope_MasterPage.model = window.scope_AgreementForm.model;
        DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._lightCast(window.scope_AgreementForm.model);
        // Joove.Common.applyScope(window.scope_AgreementForm);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IAgreementFormScope, $timeout: ng.ITimeoutService) {
        window.scope_AgreementForm = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IAgreementFormScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
AddAgreement:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("AgreementForm", "AddAgreement", "GET", [], {}, _modalOptions);
            },
EditAgreement:
            async (id, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("AgreementForm", "EditAgreement", "GET", [id], {}, _modalOptions);
            },
SaveAgreement:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'AgreementForm', action: 'SaveAgreement',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
DeleteAgreement:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'AgreementForm', action: 'DeleteAgreement',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.SaveAgreement(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(AgreementFormDataValidations);
        window._ruleEngine.addConditionalFormattings(AgreementFormConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(AgreementFormCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("AgreementFormController", ["$scope", "$timeout", AgreementFormController] as Array<string>);
}

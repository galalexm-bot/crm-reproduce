/**
 * @version 4.1.0.47200 R.local
 * @author ELMA
 * @copyright Copyright © 2006-2022 ELMA
 * @compiler Bridge.NET 17.8.0
 */
Bridge.assembly("EleWise.ELMA.Core.React", function ($asm, globals) {
    "use strict";

    (function (root, factory) {
        if (typeof define === 'function' && define.amd) {
            define("EleWise_ELMA_Core_React", ["EleWise_ELMA_Core", "EleWise_ELMA_Core_UI", "EleWise_ELMA_IoC", "EleWise_ELMA_Core_Abstractions_Metadata", "Reactive"], factory);
        } else if (typeof module === 'object' && module.exports) {
            module.exports = factory(require("EleWise_ELMA_Core"), require("EleWise_ELMA_Core_UI"), require("EleWise_ELMA_IoC"), require("EleWise_ELMA_Core_Abstractions_Metadata"), require("Reactive"));
        } else {
            root["EleWise_ELMA_Core_React"] = factory(root["EleWise_ELMA_Core"], root["EleWise_ELMA_Core_UI"], root["EleWise_ELMA_IoC"], root["EleWise_ELMA_Core_Abstractions_Metadata"], root["Reactive"]);
        }
    }(this, function (EleWise_ELMA_Core, EleWise_ELMA_Core_UI, EleWise_ELMA_IoC, EleWise_ELMA_Core_Abstractions_Metadata, Reactive) {
        var EleWise_ELMA_Core_React = { };
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IViewModelContextHandler", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.ctor], m: [{
                                ab: true, a: 2, n: "Check", t: 8, pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IViewModelContextHandler$Check", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ab: true, a: 2, n: "CreateContext", t: 8, pi: [{
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IViewModelContextHandler$CreateContext", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Model.ViewModel.BaseInputs$2", EleWise_ELMA_Core_React, function(TM, TChildren)
{
    return {
            inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.InputsWithChildren$1(TChildren), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseInputs], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 2, n: "Attributes", t: 16, rt: Function, g: {
                                                a: 2, n: "get_Attributes", t: 8, rt: Function, fg: "Attributes"
                                            }, s: {
                                                a: 2, n: "set_Attributes", t: 8, p: [Function], rt: System.Void, fs: "Attributes"
                                            }, fn: "Attributes"
                                    }, {
                                        a: 2, n: "DataTestId", t: 16, rt: Function, g: {
                                                a: 2, n: "get_DataTestId", t: 8, rt: Function, fg: "DataTestId"
                                            }, s: {
                                                a: 2, n: "set_DataTestId", t: 8, p: [Function], rt: System.Void, fs: "DataTestId"
                                            }, fn: "DataTestId"
                                    }, {
                                        a: 2, n: "FocusableType", t: 16, rt: Function, g: {
                                                a: 2, n: "get_FocusableType", t: 8, rt: Function, fg: "FocusableType"
                                            }, s: {
                                                a: 2, n: "set_FocusableType", t: 8, p: [Function], rt: System.Void, fs: "FocusableType"
                                            }, fn: "FocusableType"
                                    }, {
                                        a: 2, n: "GetFunc", t: 16, rt: Function, g: {
                                                a: 2, n: "get_GetFunc", t: 8, rt: Function, fg: "GetFunc"
                                            }, s: {
                                                a: 2, n: "set_GetFunc", t: 8, p: [Function], rt: System.Void, fs: "GetFunc"
                                            }, fn: "GetFunc"
                                    }, {
                                        a: 2, n: "Model", t: 16, rt: TM, g: {
                                                a: 2, n: "get_Model", t: 8, rt: TM, fg: "Model"
                                            }, s: {
                                                a: 2, n: "set_Model", t: 8, p: [TM], rt: System.Void, fs: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 2, n: "OnBlur", t: 16, rt: Function, g: {
                                                a: 2, n: "get_OnBlur", t: 8, rt: Function, fg: "OnBlur"
                                            }, s: {
                                                a: 2, n: "set_OnBlur", t: 8, p: [Function], rt: System.Void, fs: "OnBlur"
                                            }, fn: "OnBlur"
                                    }, {
                                        a: 2, n: "OnFocus", t: 16, rt: Function, g: {
                                                a: 2, n: "get_OnFocus", t: 8, rt: Function, fg: "OnFocus"
                                            }, s: {
                                                a: 2, n: "set_OnFocus", t: 8, p: [Function], rt: System.Void, fs: "OnFocus"
                                            }, fn: "OnFocus"
                                    }, {
                                        a: 2, n: "OnKeyPress", t: 16, rt: Function, g: {
                                                a: 2, n: "get_OnKeyPress", t: 8, rt: Function, fg: "OnKeyPress"
                                            }, s: {
                                                a: 2, n: "set_OnKeyPress", t: 8, p: [Function], rt: System.Void, fs: "OnKeyPress"
                                            }, fn: "OnKeyPress"
                                    }, {
                                        a: 2, n: "PropertyMetadata", t: 16, rt: Function, g: {
                                                a: 2, n: "get_PropertyMetadata", t: 8, rt: Function, fg: "PropertyMetadata"
                                            }, s: {
                                                a: 2, n: "set_PropertyMetadata", t: 8, p: [Function], rt: System.Void, fs: "PropertyMetadata"
                                            }, fn: "PropertyMetadata"
                                    }, {
                                        a: 2, n: "PropertyOwner", t: 16, rt: Function, g: {
                                                a: 2, n: "get_PropertyOwner", t: 8, rt: Function, fg: "PropertyOwner"
                                            }, s: {
                                                a: 2, n: "set_PropertyOwner", t: 8, p: [Function], rt: System.Void, fs: "PropertyOwner"
                                            }, fn: "PropertyOwner"
                                    }, {
                                        a: 2, n: "SetFunc", t: 16, rt: Function, g: {
                                                a: 2, n: "get_SetFunc", t: 8, rt: Function, fg: "SetFunc"
                                            }, s: {
                                                a: 2, n: "set_SetFunc", t: 8, p: [Function], rt: System.Void, fs: "SetFunc"
                                            }, fn: "SetFunc"
                                    }, {
                                        a: 1, backing: true, n: "<Attributes>k__BackingField", t: 4, rt: Function, sn: "Attributes"
                                    }, {
                                        a: 1, backing: true, n: "<DataTestId>k__BackingField", t: 4, rt: Function, sn: "DataTestId"
                                    }, {
                                        a: 1, backing: true, n: "<FocusableType>k__BackingField", t: 4, rt: Function, sn: "FocusableType"
                                    }, {
                                        a: 1, backing: true, n: "<GetFunc>k__BackingField", t: 4, rt: Function, sn: "GetFunc"
                                    }, {
                                        a: 1, backing: true, n: "<OnBlur>k__BackingField", t: 4, rt: Function, sn: "OnBlur"
                                    }, {
                                        a: 1, backing: true, n: "<OnFocus>k__BackingField", t: 4, rt: Function, sn: "OnFocus"
                                    }, {
                                        a: 1, backing: true, n: "<OnKeyPress>k__BackingField", t: 4, rt: Function, sn: "OnKeyPress"
                                    }, {
                                        a: 1, backing: true, n: "<PropertyMetadata>k__BackingField", t: 4, rt: Function, sn: "PropertyMetadata"
                                    }, {
                                        a: 1, backing: true, n: "<PropertyOwner>k__BackingField", t: 4, rt: Function, sn: "PropertyOwner"
                                    }, {
                                        a: 1, backing: true, n: "<SetFunc>k__BackingField", t: 4, rt: Function, sn: "SetFunc"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    GetFunc: null, SetFunc: null, Attributes: null, PropertyMetadata: null, DataTestId: null, PropertyOwner: null, FocusableType: null, OnKeyPress: null, OnBlur: null, OnFocus: null
                }, props: {
                    EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Model: {
                        get: function()
                        {
                            
                            return this.Model
                        }, set: function(value)
                            {
                                
                                this.Model = Bridge.cast(Bridge.unbox(value, TM), TM)
                            }
                    }, Model: {
                            get: function()
                            {
                                
                                return this.GetFunc()
                            }, set: function(value)
                                {
                                    
                                    this.SetFunc(value)
                                }
                        }, EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc: {
                            get: function()
                            {
                                
                                return Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Model.ViewModel.BaseInputs$2.f1))
                            }, set: function(value)
                                {
                                    
                                    this.GetFunc = function()
                                    {
                                        return Bridge.unbox(value())
                                    }
                                }
                        }, EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$SetFunc: {
                            get: function()
                            {
                                
                                return Bridge.fn.bind(this, function(v)
                                    {
                                        
                                        this.SetFunc(Bridge.cast(Bridge.unbox(v, TM), TM))
                                    })
                            }, set: function(value)
                                {
                                    
                                    this.SetFunc = function(v)
                                    {
                                        
                                        value(v)
                                    }
                                }
                        }
                }, alias: ["Attributes", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Attributes", "PropertyMetadata", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyMetadata", "DataTestId", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$DataTestId", "PropertyOwner", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyOwner", "FocusableType", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$FocusableType", "OnKeyPress", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnKeyPress", "OnBlur", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnBlur", "OnFocus", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnFocus"]
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Model.ViewModel.BaseInputs$2", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Model.ViewModel.BaseInputs$2, {f1: function()
    {
        return this.GetFunc()
    }});
Bridge.define("EleWise.ELMA.Core.React.Components.IInputComponent", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.IBaseInputController", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent", {
    inherits: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.$ctor1(false)], m: [{
                                ab: true, a: 2, n: "ReactElement", t: 16, rt: Object, g: {
                                        ab: true, a: 2, n: "get_ReactElement", t: 8, rt: Object, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement"
                            }, {
                                a: 1, backing: true, n: "<ReactElement>k__BackingField", t: 4, rt: Object, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IDataExtension", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "DataStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        ab: true, a: 2, n: "get_DataStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack"
                                    }, s: {
                                        ab: true, a: 2, n: "set_DataStack", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack"
                            }, {
                                a: 1, backing: true, n: "<DataStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactProps$1", EleWise_ELMA_Core_React, function(TModel)
{
    return {
            $metadata: function()
            {
                return {
                        att: 1048577, a: 2, m: [{
                                    a: 2, n: ".ctor", t: 1, sn: "ctor"
                                }, {
                                    a: 2, n: "Model", t: 16, rt: TModel, g: {
                                            a: 2, n: "get_Model", t: 8, rt: TModel, fg: "Model"
                                        }, s: {
                                            a: 2, n: "set_Model", t: 8, p: [TModel], rt: System.Void, fs: "Model"
                                        }, fn: "Model"
                                }, {
                                    a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: TModel, sn: "Model"
                                }]
                    }
            }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {Model: Bridge.getDefaultValue(TModel)}, ctors: {ctor: function()
                    {
                        this.$initialize();
                        Bridge.copyProperties(this, System.Object.ctor.call(this));
                        
                        this.key = System.Guid.Empty.toString()
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.IReactRenderer", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.ctor], m: [{
                                ab: true, a: 2, n: "CanRender", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender", rt: System.Boolean, p: [System.Type], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ab: true, a: 2, n: "Render", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.Inputs", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.InputsWithChildren$1(System.Array.type(Object))], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.IScopedComponent", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.ViewItemRenderer", {
    inherits: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {Order: 2147483647})], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                            n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "BaseInitViewModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 1
                                        }, {
                                            n: "owner", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 3
                                        }], sn: "BaseInitViewModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                v: true, a: 2, n: "CanRender", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }], sn: "CanRender", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 3, n: "CreateComponent", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "inputModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel, ps: 1
                                        }], sn: "CreateComponent", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel]
                            }, {
                                v: true, a: 3, n: "CreateInputModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 1
                                        }], sn: "CreateInputModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem]
                            }, {
                                a: 1, n: "CreateInputs", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }], sn: "CreateInputs", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem]
                            }, {
                                v: true, a: 3, n: "GetElementKey", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }], sn: "GetElementKey", rt: System.String, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem]
                            }, {
                                v: true, a: 3, n: "GetInputsTypeComponent", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "GetInputsTypeComponent", rt: System.Type, p: [System.Type]
                            }, {
                                v: true, a: 3, n: "GetTypeComponent", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }], sn: "GetTypeComponent", rt: System.Type, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem]
                            }, {
                                v: true, a: 2, n: "Render", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "Render", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                v: true, a: 3, n: "RenderChilds", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "RenderChilds", rt: System.Array.type(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent), p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 1, n: "ComponentManager", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, g: {
                                        a: 1, n: "get_ComponentManager", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, fg: "ComponentManager"
                                    }, fn: "ComponentManager"
                            }, {
                                a: 3, n: "ReactComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, g: {
                                        a: 3, n: "get_ReactComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, fg: "ReactComponentCreatorService"
                                    }, fn: "ReactComponentCreatorService"
                            }, {
                                a: 3, n: "ViewItemComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, g: {
                                        a: 3, n: "get_ViewItemComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, fg: "ViewItemComponentCreatorService"
                                    }, fn: "ViewItemComponentCreatorService"
                            }, {
                                a: 1, n: "WrapComponents", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), g: {
                                        a: 1, n: "get_WrapComponents", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), fg: "WrapComponents"
                                    }, fn: "WrapComponents"
                            }, {
                                a: 1, n: "componentManager", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, sn: "componentManager"
                            }, {
                                a: 1, n: "currentScope", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "currentScope", ro: true
                            }, {
                                a: 1, n: "reactComponentCreatorService", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, sn: "reactComponentCreatorService"
                            }, {
                                a: 1, n: "viewItemComponentCreatorService", t: 4, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, sn: "viewItemComponentCreatorService"
                            }, {
                                a: 1, n: "wrapComponents", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), sn: "wrapComponents"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            currentScope: null, wrapComponents: null, componentManager: null, viewItemComponentCreatorService: null, reactComponentCreatorService: null
        }, props: {
            WrapComponents: {get: function()
                {
                    
                    return this.wrapComponents || ((this.wrapComponents = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent))))
                }}, ComponentManager: {get: function()
                    {
                        
                        return this.componentManager || ((this.componentManager = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager)))
                    }}, ViewItemComponentCreatorService: {get: function()
                    {
                        
                        return this.viewItemComponentCreatorService || ((this.viewItemComponentCreatorService = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService)))
                    }}, ReactComponentCreatorService: {get: function()
                    {
                        
                        return this.reactComponentCreatorService || ((this.reactComponentCreatorService = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService)))
                    }}
        }, alias: ["CanRender", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Renderers$IViewItemRenderer$CanRender", "Render", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Renderers$IViewItemRenderer$Render"], ctors: {ctor: function(currentScope)
            {
                this.$initialize();
                
                this.currentScope = currentScope
            }}, methods: {
            CanRender: function(viewItem)
            {
                
                return true
            }, Render: function(viewItem, owner, inputs)
                {
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var typeComponent = this.GetTypeComponent(viewItem);
                    
                    if (typeComponent == null)
                    {
                        
                        return null
                    }
                    
                    if (inputs == null)
                    {
                        
                        inputs = this.CreateInputs(viewItem)
                    }
                    
                    do
                    {
                        
                        if (Bridge.is(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs))
                        {
                            
                            var inputsWithChildrenArray = Bridge.cast(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs);
                            {
                                
                                inputsWithChildrenArray.Children = Bridge.is(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.RootViewItem) ? EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToArrayReactElement(this.RenderChilds(viewItem, owner)) : null;
                                
                                break
                            }
                        }
                        
                        if (Bridge.is(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildrenFunc))
                        {
                            
                            var inputsWithChildrenFunc = Bridge.cast(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildrenFunc);
                            {
                                
                                inputsWithChildrenFunc.Children = Bridge.fn.bind(this, function(data)
                                {
                                    
                                    var stackItem = new EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem(data);
                                    
                                    owner != null ? owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$SetDynamicData(stackItem) : null;
                                    
                                    var element = Bridge.is(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.RootViewItem) ? EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToArrayReactElement(this.RenderChilds(viewItem, owner)) : null;
                                    
                                    owner != null ? owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RestoreDynamicData(stackItem) : null;
                                    
                                    return element
                                });
                                
                                break
                            }
                        }
                        
                        if (Bridge.is(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildren))
                        {
                            
                            var inputsWithChildren = Bridge.cast(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildren);
                            {
                                
                                inputsWithChildren.Children = Bridge.is(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.RootViewItem) ? EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToArrayReactElement(this.RenderChilds(viewItem, owner)) : null;
                                
                                break
                            }
                        }
                    } while (false);
                    
                    var inputModel = this.BaseInitViewModel(typeComponent, viewItem, owner, inputs);
                    
                    return this.CreateComponent(typeComponent, inputModel)
                }, RenderChilds: function(viewItem, owner)
                {
                    
                    var rootViewItem;
                    
                    if (((rootViewItem = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.RootViewItem))) != null)
                    {
                        
                        return System.Linq.Enumerable.from(rootViewItem.Items, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem).select(Bridge.fn.bind(this, function(item)
                            {
                                return this.ViewItemComponentCreatorService.EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Services$IViewItemComponentCreatorService$Create(item, owner, void 0)
                            })).ToArray(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent)
                    }
                    
                    return System.Array.init(0, null, EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent)
                }, CreateComponent: function(typeComponent, inputModel)
                {
                    var $t;
                    
                    var component = Bridge.cast(Bridge.createInstance(typeComponent, [inputModel]), EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent);
                    
                    $t = Bridge.getEnumerator(this.WrapComponents, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var wrapComponent = $t.Current;
                            
                            component = wrapComponent.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IWrapComponent$Wrap(component)
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    return component
                }, BaseInitViewModel: function(typeComponent, viewItem, owner, inputs)
                {
                    var $t;
                    if (owner === void 0)
                    {
                        owner = null
                    }
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var inputModel = this.CreateInputModel(typeComponent, viewItem);
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key = this.GetElementKey(viewItem);
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs = inputs;
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Owner = owner;
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemInputModel$ViewItem = viewItem;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope = this.currentScope;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack = owner != null && ($t = owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$GetDynamicData()) != null ? $t.EleWise_ELMA_Core$EleWise$ELMA$Model$IDataStack$clone() : null;
                    
                    return inputModel
                }, CreateInputModel: function(typeComponent, viewItem)
                {
                    
                    var typeInputs = this.GetInputsTypeComponent(typeComponent);
                    
                    var genericType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemInputModel$2.apply(null, System.Array.init([Bridge.getType(viewItem), typeInputs], System.Type));
                    
                    return Bridge.cast(Bridge.createInstance(genericType), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel)
                }, GetInputsTypeComponent: function(typeComponent)
                {
                    
                    var args = Bridge.Reflection.getGenericArguments(Bridge.Reflection.getBaseType(typeComponent));
                    
                    return args.length <= 2 ? EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs : args[System.Array.index(1, args)]
                }, GetTypeComponent: function(viewItem)
                {
                    
                    var typeVi = Bridge.getType(viewItem);
                    
                    var typesReactComponent = this.ComponentManager.EleWise_ELMA_Core$EleWise$ELMA$Core$ComponentModel$IComponentManager$GetTypes(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent);
                    
                    return System.Linq.Enumerable.from(typesReactComponent, System.Type).firstOrDefault(function(el)
                        {
                            
                            var types = Bridge.Reflection.getGenericArguments(Bridge.Reflection.getBaseType(el));
                            
                            var viType = types[System.Array.index(0, types)];
                            
                            return viType != null && Bridge.referenceEquals(viType, typeVi)
                        }, null)
                }, GetElementKey: function(viewItem)
                {
                    
                    return viewItem.Uid.toString()
                }, CreateInputs: function(viewItem)
                {
                    
                    var typeComponent = this.GetTypeComponent(viewItem);
                    
                    var typeInputs = this.GetInputsTypeComponent(typeComponent);
                    
                    var inputs = Bridge.cast(Bridge.createInstance(typeInputs), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs);
                    
                    return inputs
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.ctor], m: [{
                                ab: true, a: 2, n: "CanWrap", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "wrapperType", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType, ps: 2
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$CanWrap", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ab: true, a: 2, n: "Type", t: 16, rt: System.Type, g: {
                                        ab: true, a: 2, n: "get_Type", t: 8, rt: System.Type, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$Type"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$Type"
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: System.Type, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$Type"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IErrorComponent", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.$ctor1(false)]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IRef", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Ref", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_Ref", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IRef$Ref"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Ref", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IRef$Ref"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IRef$Ref"
                            }, {
                                a: 1, backing: true, n: "<Ref>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IRef$Ref"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.ctor], m: [{
                                ab: true, a: 2, n: "Wrap", t: 8, pi: [{
                                            n: "renderContent", pt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IWrapComponent$Wrap", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper", {
    $metadata: function()
    {
        return {
                att: 1048961, a: 2, s: true, m: [{
                            a: 2, n: "GetChildrenArray", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], sn: "GetChildrenArray", rt: System.Array.type(Object), p: [Object]
                        }, {
                            a: 2, n: "GetChildrenFunc", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], sn: "GetChildrenFunc", rt: Function, p: [Object]
                        }, {
                            a: 2, n: "GetKey", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], sn: "GetKey", rt: System.String, p: [Object]
                        }, {
                            a: 2, n: "GetViewItem", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], sn: "GetViewItem$1", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, p: [Object]
                        }, {
                            a: 2, n: "GetViewItem", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], tpc: 1, tprm: ["T"], sn: "GetViewItem", rt: System.Object, p: [Object]
                        }, {
                            a: 2, n: "GetWrapModel", is: true, t: 8, pi: [{
                                        n: "reactElement", pt: Object, ps: 0
                                    }], sn: "GetWrapModel", rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.IWrapModel, p: [Object]
                        }, {
                            a: 2, n: "ToArrayReactElement", is: true, t: 8, pi: [{
                                        n: "content", pt: System.Array.type(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent), ps: 0
                                    }], sn: "ToArrayReactElement", rt: System.Array.type(Object), p: [System.Array.type(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent)]
                        }, {
                            a: 2, n: "ToEnumerableReactElement", is: true, t: 8, pi: [{
                                        n: "content", pt: System.Array.type(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent), ps: 0
                                    }], sn: "ToEnumerableReactElement", rt: System.Collections.Generic.IEnumerable$1(Object), p: [System.Array.type(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent)]
                        }, {
                            a: 2, n: "ToEnumerableReactElement", is: true, t: 8, pi: [{
                                        n: "content", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent), ps: 0
                                    }], sn: "ToEnumerableReactElement$1", rt: System.Collections.Generic.IEnumerable$1(Object), p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent)]
                        }, {
                            a: 2, n: "ToReactElement", is: true, t: 8, pi: [{
                                        n: "content", pt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, ps: 0
                                    }], sn: "ToReactElement", rt: Object, p: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent]
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {methods: {
                ToReactElement: function(content)
                {
                    
                    if (content == null)
                    {
                        
                        return null
                    }
                    
                    var reactComponent = Bridge.as(content, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent);
                    
                    return (reactComponent != null ? reactComponent.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement : null) || Bridge.cast(content._reactElement, Object)
                }, ToEnumerableReactElement$1: function(content)
                    {
                        return new(Bridge.GeneratorEnumerable$1(Object))(Bridge.fn.bind(this, function(content)
                            {
                                var $step = 0,
                                    $jumpFromFinally,
                                    $returnValue,
                                    $t,
                                    el,
                                    $async_e;
                                var $enumerator = new(Bridge.GeneratorEnumerator$1(Object))(Bridge.fn.bind(this, function()
                                    {
                                        try
                                        {
                                            for (; ; )
                                            {
                                                switch ($step)
                                                {
                                                    case 0:
                                                        {
                                                            
                                                            if (content != null)
                                                            {
                                                                $step = 1;
                                                                continue
                                                            }
                                                            $step = 6;
                                                            continue
                                                        }
                                                    case 1:
                                                        {
                                                            
                                                            $t = Bridge.getEnumerator(content, EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent);
                                                            $step = 2;
                                                            continue
                                                        }
                                                    case 2:
                                                        {
                                                            if ($t.moveNext())
                                                            {
                                                                el = $t.Current;
                                                                $step = 3;
                                                                continue
                                                            }
                                                            $step = 5;
                                                            continue
                                                        }
                                                    case 3:
                                                        {
                                                            
                                                            $enumerator.current = Bridge.cast(el, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement;
                                                            $step = 4;
                                                            return true
                                                        }
                                                    case 4:
                                                        {
                                                            $step = 2;
                                                            continue
                                                        }
                                                    case 5:
                                                        {
                                                            $step = 6;
                                                            continue
                                                        }
                                                    case 6:
                                                        {}
                                                    default:
                                                        {
                                                            return false
                                                        }
                                                }
                                            }
                                        }
                                        catch($async_e1)
                                        {
                                            $async_e = System.Exception.create($async_e1);
                                            throw $async_e;
                                        }
                                    }));
                                return $enumerator
                            }, arguments))
                    }, ToEnumerableReactElement: function(content)
                    {
                        return new(Bridge.GeneratorEnumerable$1(Object))(Bridge.fn.bind(this, function(content)
                            {
                                var $step = 0,
                                    $jumpFromFinally,
                                    $returnValue,
                                    $t,
                                    el,
                                    $async_e;
                                var $enumerator = new(Bridge.GeneratorEnumerator$1(Object))(Bridge.fn.bind(this, function()
                                    {
                                        try
                                        {
                                            for (; ; )
                                            {
                                                switch ($step)
                                                {
                                                    case 0:
                                                        {
                                                            
                                                            if (content == null)
                                                            {
                                                                $step = 1;
                                                                continue
                                                            }
                                                            $step = 2;
                                                            continue
                                                        }
                                                    case 1:
                                                        {
                                                            
                                                            return false
                                                        }
                                                    case 2:
                                                        {
                                                            
                                                            if (content.length > 0)
                                                            {
                                                                $step = 3;
                                                                continue
                                                            }
                                                            $step = 8;
                                                            continue
                                                        }
                                                    case 3:
                                                        {
                                                            
                                                            $t = Bridge.getEnumerator(content);
                                                            $step = 4;
                                                            continue
                                                        }
                                                    case 4:
                                                        {
                                                            if ($t.moveNext())
                                                            {
                                                                el = $t.Current;
                                                                $step = 5;
                                                                continue
                                                            }
                                                            $step = 7;
                                                            continue
                                                        }
                                                    case 5:
                                                        {
                                                            
                                                            $enumerator.current = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(el);
                                                            $step = 6;
                                                            return true
                                                        }
                                                    case 6:
                                                        {
                                                            $step = 4;
                                                            continue
                                                        }
                                                    case 7:
                                                        {
                                                            $step = 8;
                                                            continue
                                                        }
                                                    case 8:
                                                        {}
                                                    default:
                                                        {
                                                            return false
                                                        }
                                                }
                                            }
                                        }
                                        catch($async_e1)
                                        {
                                            $async_e = System.Exception.create($async_e1);
                                            throw $async_e;
                                        }
                                    }));
                                return $enumerator
                            }, arguments))
                    }, ToArrayReactElement: function(content)
                    {
                        var $t;
                        
                        return ($t = Object, System.Linq.Enumerable.from(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToEnumerableReactElement(content), $t).ToArray($t))
                    }, GetKey: function(reactElement)
                    {
                        
                        return Bridge.cast(reactElement.key, System.String)
                    }, GetChildrenArray: function(reactElement)
                    {
                        
                        var children = reactElement.props.children;
                        
                        if (children == null)
                        {
                            
                            return System.Array.init([], Object)
                        }
                        
                        var arr = Bridge.as(children, Array);
                        
                        if (arr != null)
                        {
                            
                            return System.Linq.Enumerable.from(arr).select(function(x)
                                {
                                    return Bridge.cast(x, Object)
                                }).ToArray(Object)
                        }
                        
                        return System.Array.init([Bridge.cast(children, Object)], Object)
                    }, GetChildrenFunc: function(reactElement)
                    {
                        
                        var f = reactElement.props.children;
                        
                        if (Bridge.is(f, Function))
                        {
                            
                            return f
                        }
                        
                        throw new System.Exception(SR.T("\u0414\u043e\u0447\u0435\u0440\u043d\u0438\u0435 \u044d\u043b\u0435\u043c\u0435\u043d\u0442\u044b \u043d\u0435 \u044f\u0432\u043b\u044f\u044e\u0442\u0441\u044f \u0444\u0443\u043d\u043a\u0446\u0438\u0435\u0439"));
                    }, GetViewItem$1: function(reactElement)
                    {
                        
                        var model = Bridge.as(reactElement.props.value.Model, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemInputModel);
                        
                        return model != null ? model.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemInputModel$ViewItem : null
                    }, GetViewItem: function(T, reactElement)
                    {
                        
                        return Bridge.cast(Bridge.unbox(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.GetViewItem$1(reactElement), T), T)
                    }, GetWrapModel: function(reactElement)
                    {
                        
                        var model = Bridge.as(reactElement.props.value.Model, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.WrapperInputs));
                        
                        return model != null ? model.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$WrapperInputs$Inputs$1.WrapModel() : null
                    }
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Helpers.ScopedComponentConstants", {
    $metadata: function()
    {
        return {
                att: 1048577, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "CurrentScope", is: true, t: 4, rt: System.String, sn: "CurrentScope"
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
            fields: {CurrentScope: null}, ctors: {init: function()
                    {
                        this.CurrentScope = "$currentScope"
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ICustomView", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Render", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$ICustomView$Render", rt: Object
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IErrorInputs", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Message", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_Message", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Message", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message"
                            }, {
                                ab: true, a: 2, n: "StackShow", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_StackShow", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow"
                                    }, s: {
                                        ab: true, a: 2, n: "set_StackShow", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow"
                            }, {
                                a: 1, backing: true, n: "<Message>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message"
                            }, {
                                a: 1, backing: true, n: "<StackShow>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IReactService", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "ReactComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, g: {
                                        ab: true, a: 2, n: "get_ReactComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService"
                                    }, s: {
                                        ab: true, a: 2, n: "set_ReactComponentCreatorService", t: 8, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService"
                            }, {
                                ab: true, a: 2, n: "ViewItemComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, g: {
                                        ab: true, a: 2, n: "get_ViewItemComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewItemComponentCreatorService"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewItemComponentCreatorService"
                            }, {
                                ab: true, a: 2, n: "ViewModelCreatorService", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, g: {
                                        ab: true, a: 2, n: "get_ViewModelCreatorService", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewModelCreatorService"
                                    }, s: {
                                        ab: true, a: 2, n: "set_ViewModelCreatorService", t: 8, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewModelCreatorService"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewModelCreatorService"
                            }, {
                                a: 1, backing: true, n: "<ReactComponentCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService"
                            }, {
                                a: 1, backing: true, n: "<ViewItemComponentCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewItemComponentCreatorService"
                            }, {
                                a: 1, backing: true, n: "<ViewModelCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewModelCreatorService"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IBaseRangeContext", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseContext], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "PropertyFrom", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), g: {
                                        ab: true, a: 2, n: "get_PropertyFrom", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyFrom"
                                    }, s: {
                                        ab: true, a: 2, n: "set_PropertyFrom", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53")], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyFrom"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyFrom"
                            }, {
                                ab: true, a: 2, n: "PropertyTo", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), g: {
                                        ab: true, a: 2, n: "get_PropertyTo", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyTo"
                                    }, s: {
                                        ab: true, a: 2, n: "set_PropertyTo", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53")], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyTo"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyTo"
                            }, {
                                a: 1, backing: true, n: "<PropertyFrom>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyFrom"
                            }, {
                                a: 1, backing: true, n: "<PropertyTo>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyTo"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.ComponentContainer", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                v: true, a: 2, n: "Dispatcher", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher, g: {
                                        v: true, a: 2, n: "get_Dispatcher", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher, fg: "Dispatcher"
                                    }, fn: "Dispatcher"
                            }, {
                                v: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        v: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                v: true, a: 2, n: "ReadOnly", t: 16, rt: System.Boolean, g: {
                                        v: true, a: 2, n: "get_ReadOnly", t: 8, rt: System.Boolean, fg: "ReadOnly", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "ReadOnly"
                            }, {
                                a: 3, n: "RenderOwner", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, g: {
                                        a: 3, n: "get_RenderOwner", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, fg: "RenderOwner"
                                    }, fn: "RenderOwner"
                            }, {
                                v: true, a: 2, n: "Validation", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.IValidationModel, g: {
                                        v: true, a: 2, n: "get_Validation", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.IValidationModel, fg: "Validation"
                                    }, fn: "Validation"
                            }, {
                                a: 3, n: "ViewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "ViewModel", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {ViewModel: null}, props: {
            ReadOnly: {get: function()
                {
                    
                    return this.RenderOwner != null && this.RenderOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$ReadOnly
                }}, Validation: {get: function()
                    {
                        
                        var validationViewModel;
                        
                        return ((validationViewModel = Bridge.as(this.ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IValidationViewModel))) != null ? validationViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IValidationViewModel$ValidationModel : null
                    }}, Name: {get: function()
                    {
                        
                        return this.ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key
                    }}, Dispatcher: {get: function()
                    {
                        
                        return this.ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher
                    }}, RenderOwner: {get: function()
                    {
                        
                        return this.ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner
                    }}
        }, alias: ["ReadOnly", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$ReadOnly", "Validation", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Validation", "Name", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name", "Dispatcher", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Dispatcher"], ctors: {ctor: function(viewModel)
            {
                this.$initialize();
                
                EleWise_ELMA_Core.EleWise.ELMA.Core.Diagnostics.Contract.ArgumentNotNull(viewModel, "viewModel");
                
                this.ViewModel = viewModel
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Models.IContextCreationParameters", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "InnerStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        ab: true, a: 2, n: "get_InnerStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$InnerStack"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$InnerStack"
                            }, {
                                ab: true, a: 2, n: "Metadata", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), g: {
                                        ab: true, a: 2, n: "get_Metadata", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$Metadata"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$Metadata"
                            }, {
                                ab: true, a: 2, n: "MetadataModuleUid", t: 16, rt: System.Guid, g: {
                                        ab: true, a: 2, n: "get_MetadataModuleUid", t: 8, rt: System.Guid, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid"
                            }, {
                                ab: true, a: 2, n: "MetadataTypeUid", t: 16, rt: System.Guid, g: {
                                        ab: true, a: 2, n: "get_MetadataTypeUid", t: 8, rt: System.Guid, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid"
                            }, {
                                ab: true, a: 2, n: "MetadataUid", t: 16, rt: System.Guid, g: {
                                        ab: true, a: 2, n: "get_MetadataUid", t: 8, rt: System.Guid, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid"
                            }, {
                                ab: true, a: 2, n: "OuterStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        ab: true, a: 2, n: "get_OuterStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack"
                            }, {
                                ab: true, a: 2, n: "ViewModel", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, g: {
                                        ab: true, a: 2, n: "get_ViewModel", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel"
                            }, {
                                a: 1, backing: true, n: "<InnerStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$InnerStack"
                            }, {
                                a: 1, backing: true, n: "<Metadata>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$Metadata"
                            }, {
                                a: 1, backing: true, n: "<MetadataModuleUid>k__BackingField", t: 4, rt: System.Guid, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid"
                            }, {
                                a: 1, backing: true, n: "<MetadataTypeUid>k__BackingField", t: 4, rt: System.Guid, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid"
                            }, {
                                a: 1, backing: true, n: "<MetadataUid>k__BackingField", t: 4, rt: System.Guid, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid"
                            }, {
                                a: 1, backing: true, n: "<OuterStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack"
                            }, {
                                a: 1, backing: true, n: "<ViewModel>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "AddIsHidden", t: 8, pi: [{
                                            n: "isHidden", pt: Function, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$AddIsHidden", rt: System.Void, p: [Function]
                            }, {
                                ab: true, a: 2, n: "RemoveIsHidden", t: 8, pi: [{
                                            n: "isHidden", pt: Function, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$RemoveIsHidden", rt: System.Void, p: [Function]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IHideEmptyModel", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Destroy", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Destroy", rt: System.Void
                            }, {
                                ab: true, a: 2, n: "Init", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Init", rt: System.Void
                            }, {
                                ab: true, a: 2, n: "IsEmpty", t: 16, rt: System.Boolean, g: {
                                        ab: true, a: 2, n: "get_IsEmpty", t: 8, rt: System.Boolean, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty"
                            }, {
                                a: 1, backing: true, n: "<IsEmpty>k__BackingField", t: 4, rt: System.Boolean, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "AddHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "hideEmptyModel", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$AddHideEmpty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel]
                            }, {
                                ab: true, a: 2, n: "Destroy", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$Destroy", rt: System.Void
                            }, {
                                ab: true, a: 2, n: "FindHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindHideEmpty", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                ab: true, a: 2, n: "FindOwner", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindOwner", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                ab: true, a: 2, n: "IsHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$IsHideEmpty", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ab: true, a: 2, n: "RemoveHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$RemoveHideEmpty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainer", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "HideEmptyViewItemContainer", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, g: {
                                        ab: true, a: 2, n: "get_HideEmptyViewItemContainer", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer"
                            }, {
                                a: 1, backing: true, n: "<HideEmptyViewItemContainer>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IInputComponentContainer", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "OnBlur", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnBlur", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnBlur"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnBlur"
                            }, {
                                ab: true, a: 2, n: "OnFocus", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnFocus", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnFocus"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnFocus"
                            }, {
                                ab: true, a: 2, n: "OnKeyPress", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnKeyPress", t: 8, rt: Function, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress"
                            }, {
                                a: 1, backing: true, n: "<OnBlur>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnBlur"
                            }, {
                                a: 1, backing: true, n: "<OnFocus>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnFocus"
                            }, {
                                a: 1, backing: true, n: "<OnKeyPress>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.InputsChildren", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.InputsWithChildren$1(System.Object)], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.InputsChildrenFunc", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.InputsWithChildren$1(Function)], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IRootComponent", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "GetSlotContent", t: 8, pi: [{
                                            n: "uid", dv: null, o: true, pt: System.Guid, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IRootComponent$GetSlotContent", rt: Object, p: [System.Guid]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.IViewModelValidationModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.IValidationModel], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "AddValidator", t: 8, pi: [{
                                            n: "validateFunc", pt: Function, ps: 0
                                        }, {
                                            n: "name", dv: "", o: true, pt: System.String, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$AddValidator", rt: System.Void, p: [Function, System.String]
                            }, {
                                ab: true, a: 2, n: "Destroy", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$Destroy", rt: System.Void
                            }, {
                                ab: true, a: 2, n: "RemoveValidator", t: 8, pi: [{
                                            n: "validateFunc", pt: Function, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$RemoveValidator", rt: System.Void, p: [Function]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.ModelType", {
    $kind: "enum", $metadata: function()
        {
            return {
                    att: 257, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Original", is: true, t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, sn: "Original", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                    }
                            }, {
                                a: 2, n: "Serialized", is: true, t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, sn: "Serialized", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {fields: {
                Serialized: 0, Original: 1
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Services.IReactComponentCreatorService", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "Create", t: 8, pi: [{
                                            n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create$1", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "Create", t: 8, pi: [{
                                            n: "typeVic", pt: System.Type, ps: 0
                                        }, {
                                            n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 1
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "Error", t: 8, pi: [{
                                            n: "inputs", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Error", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Services.IViewModelCreatorService", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "ControllerCreator", t: 8, pi: [{
                                            n: "controllerType", pt: System.Type, ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 1
                                        }, {
                                            n: "viewModel", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }, {
                                            n: "viewItem", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 3
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ControllerCreator", rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                ab: true, a: 2, n: "CreateModel", t: 8, tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$CreateModel", rt: System.Object
                            }, {
                                ab: true, a: 2, n: "CreateModel", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$CreateModel$1", rt: System.Object, p: [System.Type]
                            }, {
                                ab: true, a: 2, n: "ExecuteEql", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "defaultOnLoadScriptName", pt: System.String, ps: 1
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 3
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel), ps: 4
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteEql", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel)]
                            }, {
                                ab: true, a: 2, n: "ExecuteOnInit", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnInit", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "ExecuteOnLoad", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnLoad", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "ExecuteOnLoadAsync", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnLoadAsync", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "ExecuteServerOnLoad", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "controllerFullName", pt: System.String, ps: 1
                                        }, {
                                            n: "onLoadScriptName", pt: System.String, ps: 2
                                        }, {
                                            n: "currentViewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 3
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteServerOnLoad", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                ab: true, a: 2, n: "GetServerControllerFullName", t: 8, pi: [{
                                            n: "serverControllerInterfaceType", pt: System.Type, ps: 0
                                        }, {
                                            n: "assemblyName", pt: System.String, ps: 1
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$GetServerControllerFullName", rt: System.String, p: [System.Type, System.String]
                            }, {
                                ab: true, a: 2, n: "GetServerControllerType", t: 8, pi: [{
                                            n: "namespace", pt: System.Type, ps: 0
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$GetServerControllerType", rt: System.Type, p: [System.Type]
                            }, {
                                ab: true, a: 2, n: "InitClientController", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "controllerFullName", pt: System.String, ps: 1
                                        }, {
                                            n: "onLoadScriptName", pt: System.String, ps: 2
                                        }, {
                                            n: "dataStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 3
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 4
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 5
                                        }, {
                                            n: "defaultOnLoadScriptName", pt: System.String, ps: 6
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel), ps: 7
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$InitClientController", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.String, System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel)]
                            }, {
                                ab: true, a: 2, n: "InitServerControllerProxy", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "namespace", pt: System.Type, ps: 1
                                        }, {
                                            n: "assemblyName", pt: System.String, ps: 2
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 3
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 4
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam), ps: 5
                                        }], sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$InitServerControllerProxy", rt: System.String, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.Type, System.String, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam)]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Services.ReactRenderService", {
    inherits: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IRenderService], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Render", t: 8, pi: [{
                                            n: "element", pt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, ps: 0
                                        }, {
                                            n: "container", pt: Element, ps: 1
                                        }], sn: "Render", rt: System.Void, p: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, Element]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["Render", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Services$IRenderService$Render"], methods: {Render: function(element, container)
            {
                
                ReactDOM.render(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(element), container)
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Services.SerializedModelParam", {
    $metadata: function()
    {
        return {
                att: 1048833, a: 2, m: [{
                            a: 2, n: ".ctor", t: 1, p: [System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel], pi: [{
                                        n: "methodName", pt: System.String, ps: 0
                                    }, {
                                        n: "model", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel, ps: 1
                                    }], sn: "ctor"
                        }, {
                            a: 2, n: "MethodName", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_MethodName", t: 8, rt: System.String, fg: "MethodName"
                                }, s: {
                                    a: 2, n: "set_MethodName", t: 8, p: [System.String], rt: System.Void, fs: "MethodName"
                                }, fn: "MethodName"
                        }, {
                            a: 2, n: "Model", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel, g: {
                                    a: 2, n: "get_Model", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel, fg: "Model"
                                }, s: {
                                    a: 2, n: "set_Model", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel], rt: System.Void, fs: "Model"
                                }, fn: "Model"
                        }, {
                            a: 2, n: "AllMethodName", is: true, t: 4, rt: System.String, sn: "AllMethodName"
                        }, {
                            a: 1, backing: true, n: "<MethodName>k__BackingField", t: 4, rt: System.String, sn: "MethodName"
                        }, {
                            a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel, sn: "Model"
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
            fields: {AllMethodName: null}, ctors: {init: function()
                    {
                        this.AllMethodName = "$AllMethodName"
                    }}
        }, fields: {
            MethodName: null, Model: null
        }, ctors: {ctor: function(methodName, model)
            {
                this.$initialize();
                
                this.MethodName = methodName;
                
                this.Model = model
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Services.ViewItemComponentCreatorService", {
    inherits: [EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer), EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory], pi: [{
                                            n: "renderers", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer), ps: 0
                                        }, {
                                            n: "reactiveModelFactory", pt: EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory, ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Create", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "Create", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                a: 2, n: "Create", t: 8, pi: [{
                                            n: "uid", pt: System.Guid, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "Create$1", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                a: 1, n: "reactiveModelFactory", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory, sn: "reactiveModelFactory", ro: true
                            }, {
                                a: 1, n: "renderers", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer), sn: "renderers", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            renderers: null, reactiveModelFactory: null
        }, alias: ["Create", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Services$IViewItemComponentCreatorService$Create", "Create$1", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Services$IViewItemComponentCreatorService$Create$1"], ctors: {ctor: function(renderers, reactiveModelFactory)
            {
                this.$initialize();
                
                this.renderers = renderers;
                
                this.reactiveModelFactory = reactiveModelFactory
            }}, methods: {
            Create: function(viewItem, owner, inputs)
            {
                if (inputs === void 0)
                {
                    inputs = null
                }
                
                EleWise_ELMA_Core.EleWise.ELMA.Core.Diagnostics.Contract.ArgumentNotNull(viewItem, "viewItem");
                
                var renderer = System.Linq.Enumerable.from(this.renderers, EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer).firstOrDefault(function(r)
                    {
                        return r.EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Renderers$IViewItemRenderer$CanRender(viewItem)
                    }, null);
                
                if (renderer == null)
                {
                    
                    throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d\u0430 \u0442\u043e\u0447\u043a\u0430 \u0440\u0430\u0441\u0448\u0438\u0440\u0435\u043d\u0438\u044f \u0434\u043b\u044f \u043e\u0442\u0440\u0438\u0441\u043e\u0432\u043a\u0438 \u044d\u043b\u0435\u043c\u0435\u043d\u0442\u0430 \u043f\u0440\u0435\u0434\u0441\u0442\u0430\u0432\u043b\u0435\u043d\u0438\u044f \u0444\u043e\u0440\u043c\u044b {0}", viewItem));
                }
                
                return renderer.EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Renderers$IViewItemRenderer$Render(viewItem, owner, inputs)
            }, Create$1: function(uid, owner, inputs)
                {
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var viewItem = this.reactiveModelFactory.EleWise_ELMA_Core$EleWise$ELMA$Services$IReactiveModelFactory$CreateModel(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComponentViewItem);
                    
                    viewItem.Uid = uid;
                    
                    viewItem.HeaderUid = uid;
                    
                    return this.Create(viewItem, owner, inputs)
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IViewModelContextHandler], $metadata: function()
        {
            return {
                    att: 1048705, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute], m: [{
                                a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IMetadataServiceContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, EleWise_ELMA_Core.EleWise.ELMA.Services.IConvertService, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionFacade, EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IDescriptorService, EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.DTO.Managers.ModuleMetadataItemManager, EleWise_ELMA_Core.EleWise.ELMA.DTO.IExtendEntityService, EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService], pi: [{
                                            n: "metadataServiceContext", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IMetadataServiceContext, ps: 0
                                        }, {
                                            n: "currentPageService", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, ps: 1
                                        }, {
                                            n: "convertService", pt: EleWise_ELMA_Core.EleWise.ELMA.Services.IConvertService, ps: 2
                                        }, {
                                            n: "actionExecutionFacade", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionFacade, ps: 3
                                        }, {
                                            n: "descriptorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IDescriptorService, ps: 4
                                        }, {
                                            n: "moduleMetadataItemManager", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.DTO.Managers.ModuleMetadataItemManager, ps: 5
                                        }, {
                                            n: "extendEntityService", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.IExtendEntityService, ps: 6
                                        }, {
                                            n: "proxyGeneratorService", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService, ps: 7
                                        }], sn: "ctor"
                            }, {
                                ab: true, a: 2, n: "Check", t: 8, pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "Check", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "CreateClosureForAction", t: 8, pi: [{
                                            n: "actionInputComputedValue", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ActionInputComputedValue, ps: 0
                                        }, {
                                            n: "actionExecutionContext", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionContext, ps: 1
                                        }], sn: "CreateClosureForAction$1", rt: System.Object, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ActionInputComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionContext]
                            }, {
                                a: 1, n: "CreateClosureForAction", t: 8, pi: [{
                                            n: "returnTypeSignature", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Signatures.TypeSignature, ps: 0
                                        }, {
                                            n: "parameterTypeSignature", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Signatures.TypeSignature, ps: 1
                                        }, {
                                            n: "actionExecutionContext", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionContext, ps: 2
                                        }], sn: "CreateClosureForAction", rt: System.Object, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Signatures.TypeSignature, EleWise_ELMA_Core.EleWise.ELMA.Model.Signatures.TypeSignature, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionContext]
                            }, {
                                ab: true, a: 2, n: "CreateContext", t: 8, pi: [{
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 1
                                        }], sn: "CreateContext", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 1, n: "DefineInputs", t: 8, pi: [{
                                            n: "renderOwner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 1
                                        }, {
                                            n: "typeUid", pt: System.Guid, ps: 2
                                        }, {
                                            n: "expression", pt: System.Object, ps: 3
                                        }, {
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 4
                                        }, {
                                            n: "stack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 5
                                        }], sn: "DefineInputs", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack]
                            }, {
                                a: 1, n: "DefineSetterCallback", t: 8, pi: [{
                                            n: "renderOwner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 1
                                        }, {
                                            n: "typeUid", pt: System.Guid, ps: 2
                                        }, {
                                            n: "expression", pt: System.Object, ps: 3
                                        }, {
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 4
                                        }, {
                                            n: "stack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 5
                                        }], sn: "DefineSetterCallback", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack]
                            }, {
                                a: 1, n: "DefineSetterProperty", t: 8, pi: [{
                                            n: "renderOwner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 1
                                        }, {
                                            n: "typeUid", pt: System.Guid, ps: 2
                                        }, {
                                            n: "expression", pt: System.Object, ps: 3
                                        }, {
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 4
                                        }, {
                                            n: "stack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 5
                                        }], sn: "DefineSetterProperty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack]
                            }, {
                                a: 1, n: "ExecuteMethod", is: true, t: 8, pi: [{
                                            n: "renderOwner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "methodName", pt: System.String, ps: 1
                                        }, {
                                            n: "stack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 2
                                        }], sn: "ExecuteMethod", rt: System.Object, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack]
                            }, {
                                a: 1, n: "GetActionExecutionContext", t: 8, pi: [{
                                            n: "propertyMetadata", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), ps: 0
                                        }, {
                                            n: "actionValue", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ActionValue, ps: 1
                                        }, {
                                            n: "settings", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("a9a4667f-c187-47b4-8e08-e9af6be3bf42"), ps: 2
                                        }, {
                                            n: "metadataUid", pt: System.Guid, ps: 3
                                        }, {
                                            n: "metadataTypeUid", pt: System.Guid, ps: 4
                                        }, {
                                            n: "metadataModuleUid", pt: System.Guid, ps: 5
                                        }, {
                                            n: "outerStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 6
                                        }, {
                                            n: "controllerFunc", pt: Function, ps: 7
                                        }], sn: "GetActionExecutionContext", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionContext, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), EleWise_ELMA_Core.EleWise.ELMA.Model.ActionValue, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("a9a4667f-c187-47b4-8e08-e9af6be3bf42"), System.Guid, System.Guid, System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, Function]
                            }, {
                                a: 1, n: "GetActionForInput", t: 8, pi: [{
                                            n: "property", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), ps: 0
                                        }, {
                                            n: "computedValue", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 1
                                        }, {
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 2
                                        }], sn: "GetActionForInput", rt: System.Object, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters]
                            }, {
                                a: 1, n: "GetActionForProperty", t: 8, pi: [{
                                            n: "property", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), ps: 0
                                        }, {
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 1
                                        }], sn: "GetActionForProperty", rt: System.Object, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters]
                            }, {
                                a: 1, n: "GetPropertyValue", t: 8, pi: [{
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 0
                                        }, {
                                            n: "context", pt: System.Object, ps: 1
                                        }, {
                                            n: "propertyName", pt: System.String, ps: 2
                                        }], sn: "GetPropertyValue", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String]
                            }, {
                                a: 1, n: "GetTestIdValue", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "propertyName", pt: System.String, ps: 1
                                        }, {
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 2
                                        }], sn: "GetTestIdValue", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, System.String, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters]
                            }, {
                                a: 1, n: "GetValueFunc", t: 8, pi: [{
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 0
                                        }, {
                                            n: "viewModel", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "GetValueFunc", rt: Function, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 3, n: "InitDynamicProperties", t: 8, pi: [{
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 1
                                        }], sn: "InitDynamicProperties", rt: System.Void, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 3, n: "InitProperty", t: 8, pi: [{
                                            n: "property", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.ReactiveProxy, ps: 1
                                        }, {
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 2
                                        }], sn: "InitProperty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), EleWise_ELMA_Core.EleWise.ELMA.DTO.ReactiveProxy, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters]
                            }, {
                                a: 3, n: "InitPropertySettings", t: 8, pi: [{
                                            n: "property", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), ps: 0
                                        }, {
                                            n: "parameters", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, ps: 1
                                        }], sn: "InitPropertySettings", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("69d96dc9-2bc3-4c45-b4c7-80247c58addd"), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters]
                            }, {
                                a: 1, n: "InputIsNullOrEmpty", is: true, t: 8, pi: [{
                                            n: "computedValue", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 0
                                        }], sn: "InputIsNullOrEmpty", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "WriteComputedGetter", t: 8, pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 1
                                        }, {
                                            n: "context", pt: System.Object, ps: 2
                                        }, {
                                            n: "expression", pt: System.Object, ps: 3
                                        }], sn: "WriteComputedGetter", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.Object]
                            }, {
                                a: 1, n: "WriteGetter", t: 8, pi: [{
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 0
                                        }, {
                                            n: "context", pt: System.Object, ps: 1
                                        }, {
                                            n: "propertyName", pt: System.String, ps: 2
                                        }], sn: "WriteGetter", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String]
                            }, {
                                a: 1, n: "WriteGetterConfigurable", t: 8, pi: [{
                                            n: "inp", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, ps: 0
                                        }, {
                                            n: "context", pt: System.Object, ps: 1
                                        }, {
                                            n: "propertyName", pt: System.String, ps: 2
                                        }], sn: "WriteGetterConfigurable", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String]
                            }, {
                                a: 1, n: "TestPropertyName", is: true, t: 4, rt: System.String, sn: "TestPropertyName", ro: true
                            }, {
                                a: 1, n: "actionExecutionFacade", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IActionExecutionFacade, sn: "actionExecutionFacade", ro: true
                            }, {
                                a: 1, n: "convertContext", t: 4, rt: System.Object, sn: "convertContext", ro: true
                            }, {
                                a: 1, n: "convertService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IConvertService, sn: "convertService", ro: true
                            }, {
                                a: 1, n: "currentPageService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, sn: "currentPageService", ro: true
                            }, {
                                a: 1, n: "descriptorService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IDescriptorService, sn: "descriptorService", ro: true
                            }, {
                                a: 1, n: "entitySettingsComputedEqlPropertyMetadataUid", is: true, t: 4, rt: System.Guid, sn: "entitySettingsComputedEqlPropertyMetadataUid"
                            }, {
                                a: 3, n: "metadataServiceContext", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.IMetadataServiceContext, sn: "metadataServiceContext", ro: true
                            }, {
                                a: 1, n: "moduleMetadataItemManager", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.DTO.Managers.ModuleMetadataItemManager, sn: "moduleMetadataItemManager", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
            fields: {
                TestPropertyName: null, entitySettingsComputedEqlPropertyMetadataUid: null
            }, ctors: {init: function()
                    {
                        var $t,
                            $t1,
                            $t2;
                        this.entitySettingsComputedEqlPropertyMetadataUid = new System.Guid;
                        this.TestPropertyName = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem).GetExpression(System.String, ($t = {
                            ntype: 38, t: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, n: "q"
                        }, ($t2 = ($t1 = {
                            at: [new EleWise_ELMA_Core.EleWise.ELMA.Model.Attributes.DynamicPropertyAttribute(false), new Newtonsoft.Json.JsonIgnoreAttribute], td: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, a: 2, n: "TestId", t: 16, rt: System.String, g: {
                                    td: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, a: 2, n: "get_TestId", t: 8, rt: System.String, fg: "TestId"
                                }, s: {
                                    td: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, a: 2, n: "set_TestId", t: 8, p: [System.String], rt: System.Void, fs: "TestId"
                                }, fn: "TestId"
                        }, {
                            ntype: 23, t: $t1.rt, expression: $t, member: $t1
                        }), {
                            ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t])
                        })));
                        this.entitySettingsComputedEqlPropertyMetadataUid = new System.Guid.$ctor4("78522a13-1039-6bc2-309f-0af0ac917810")
                    }}, methods: {
                    InputIsNullOrEmpty: function(computedValue)
                    {
                        var $t;
                        
                        if (computedValue == null)
                        {
                            
                            return true
                        }
                        
                        do
                        {
                            
                            ($t = computedValue.ComputedValueType);
                            
                            if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input)
                            {
                                
                                if (computedValue.Value == null)
                                {
                                    {
                                        
                                        return true
                                    }
                                }
                            }
                            
                            if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function)
                            {
                                
                                if (System.String.isNullOrEmpty(computedValue.MethodName))
                                {
                                    {
                                        
                                        return true
                                    }
                                }
                            }
                            
                            if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript)
                            {
                                
                                if (System.String.isNullOrEmpty(computedValue.CalculateScript))
                                {
                                    {
                                        
                                        return true
                                    }
                                }
                            }
                            {
                                {
                                    
                                    break
                                }
                            }
                        } while (false);
                        
                        return false
                    }, ExecuteMethod: function(renderOwner, methodName, stack)
                        {
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(renderOwner);
                            
                            try
                            {
                                
                                var formViewModel;
                                
                                if (((formViewModel = Bridge.as(renderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                                {
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod$1(formViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IFormViewModel$Controllers, methodName, stack)
                                }
                                else
                                {
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(renderOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller, methodName, stack)
                                }
                            }
                            finally
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(renderOwner)
                            }
                        }
                }
        }, fields: {
            metadataServiceContext: null, currentPageService: null, convertService: null, actionExecutionFacade: null, descriptorService: null, moduleMetadataItemManager: null, convertContext: null
        }, ctors: {ctor: function(metadataServiceContext, currentPageService, convertService, actionExecutionFacade, descriptorService, moduleMetadataItemManager, extendEntityService, proxyGeneratorService)
            {
                this.$initialize();
                
                this.metadataServiceContext = metadataServiceContext;
                
                this.currentPageService = currentPageService;
                
                this.convertService = convertService;
                
                this.actionExecutionFacade = actionExecutionFacade;
                
                this.descriptorService = descriptorService;
                
                this.moduleMetadataItemManager = moduleMetadataItemManager;
                
                this.convertContext = {
                    $extendEntityService: extendEntityService, $proxyGenerator: proxyGeneratorService
                }
            }}, methods: {
            InitProperty: function(property, context, parameters)
            {
                
                var viewModel = parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel;
                
                var viewItem = null;
                
                var viewItemViewModel;
                
                if (((viewItemViewModel = Bridge.as(viewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel))) != null)
                {
                    
                    viewItem = viewItemViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem
                }
                
                if (viewItem == null)
                {
                    
                    return
                }
                
                var renderOwner = viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner;
                
                var propertyExpression = this.metadataServiceContext.EleWise_ELMA_Core$EleWise$ELMA$Core$Services$IMetadataServiceContext$GetPropertyExpression(property, context.$$proxyMetadata);
                
                var objectExpression = propertyExpression.name;
                
                if (renderOwner != null && viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$DynamicProperties != null)
                {
                    
                    var prefix = EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.MetadataConstants.InputPrefix;
                    
                    var propertyMetadata = Bridge.as(property, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("c781b82e-8029-4ba6-b485-04ec94db549f"));
                    
                    if (propertyMetadata != null && propertyMetadata.Output$c781b82e80294ba6b48504ec94db549f)
                    {
                        
                        prefix = EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.MetadataConstants.OutputPrefix
                    }
                    
                    var inputName = (prefix || "") + (objectExpression || "");
                    
                    var inp = System.Linq.Enumerable.from(viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$DynamicProperties, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue).firstOrDefault(function(i)
                        {
                            return Bridge.referenceEquals(i.Name, inputName)
                        }, null) || System.Linq.Enumerable.from(viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$DynamicProperties, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue).firstOrDefault(function(i)
                        {
                            return Bridge.referenceEquals(i.Name, objectExpression)
                        }, null);
                    
                    if (!EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.InputIsNullOrEmpty(inp))
                    {
                        
                        if (System.Guid.op_Equality(property.TypeUid$7314171f42964f23a04631594a2d6e53, EleWise_ELMA_Core.EleWise.ELMA.Model.Types.ActionDescriptor.UID))
                        {
                            
                            var action = this.GetActionForInput(property, inp, parameters);
                            
                            if (action == null)
                            {
                                
                                return
                            }
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(System.Object, System.Object, System.Object, context, function(target, expression, value)
                            {
                                return Reactive.convertHelper.RedefineProp(target, expression, value)
                            }, [context, propertyExpression, action]);
                            
                            return
                        }
                        
                        if (propertyMetadata != null && propertyMetadata.Output$c781b82e80294ba6b48504ec94db549f)
                        {
                            
                            if (inp.ComputedValueType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Property)
                            {
                                
                                var relationType = EleWise_ELMA_Core.EleWise.ELMA.Helpers.SettingsHelper.GetRelationTypeOrNull(propertyMetadata.Settings$7314171f42964f23a04631594a2d6e53);
                                
                                if (relationType != null && System.Nullable.eq(relationType, EleWise_ELMA_Core.EleWise.ELMA.Model.Types.Settings.RelationType.ManyToMany))
                                {
                                    
                                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$6(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, this, Bridge.fn.cacheBind(this, this.DefineInputs), [renderOwner, context, property.TypeUid$7314171f42964f23a04631594a2d6e53, propertyExpression, inp, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack])
                                }
                                else
                                {
                                    
                                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$6(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, this, Bridge.fn.cacheBind(this, this.DefineSetterProperty), [renderOwner, context, property.TypeUid$7314171f42964f23a04631594a2d6e53, propertyExpression, inp, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack])
                                }
                            }
                            else
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$6(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, this, Bridge.fn.cacheBind(this, this.DefineSetterCallback), [renderOwner, context, property.TypeUid$7314171f42964f23a04631594a2d6e53, propertyExpression, inp, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack])
                            }
                        }
                        else
                        {
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$6(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Guid, System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, this, Bridge.fn.cacheBind(this, this.DefineInputs), [renderOwner, context, property.TypeUid$7314171f42964f23a04631594a2d6e53, propertyExpression, inp, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack])
                        }
                        
                        return
                    }
                }
                
                if (System.Guid.op_Equality(property.TypeUid$7314171f42964f23a04631594a2d6e53, EleWise_ELMA_Core.EleWise.ELMA.Model.Types.ActionDescriptor.UID))
                {
                    
                    var action1 = this.GetActionForProperty(property, parameters);
                    
                    if (action1 == null)
                    {
                        
                        return
                    }
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(System.Object, System.Object, System.Object, context, function(target, expression, value)
                    {
                        return Reactive.convertHelper.RedefineProp(target, expression, value)
                    }, [context, propertyExpression, action1]);
                    
                    return
                }
                
                var propertyMd = Bridge.as(property, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("c781b82e-8029-4ba6-b485-04ec94db549f"));
                
                if (propertyMd == null)
                {
                    
                    return
                }
                
                var settings;
                
                if (((settings = Bridge.as(propertyMd.Settings$7314171f42964f23a04631594a2d6e53, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("e4e35b31-f236-4db3-ae5c-6d3034e572fb")))) != null && settings.IsComputedEqlValue$e4e35b31f2364db3ae5c6d3034e572fb)
                {
                    
                    var dispatcher = viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher;
                    
                    var computedEqlProperty = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ViewModelPropertyMetadataExtensions.GetComputedEqlProperty(propertyMd);
                    
                    if (computedEqlProperty != null && computedEqlProperty.ComputedValueType !== EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input)
                    {
                        
                        var getFilterQuery = function()
                            {
                                
                                if (viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller == null)
                                {
                                    
                                    return null
                                }
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(viewModel);
                                
                                try
                                {
                                    
                                    return settings.ComputedEqlQuery$e4e35b31f2364db3ae5c6d3034e572fb
                                }
                                finally
                                {
                                    
                                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(viewModel)
                                }
                            };
                        
                        var proxySettings = settings;
                        
                        var settingsMetadata = proxySettings.$$proxyMetadata;
                        
                        if (settingsMetadata == null)
                        {
                            
                            var settingsType = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(System.String, proxySettings, "$t");
                            
                            settingsMetadata = Bridge.as(this.metadataServiceContext.EleWise_ELMA_Core$EleWise$ELMA$Core$Services$IMetadataServiceContext$GetMetadataByHash(settingsType), EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"))
                        }
                        
                        var entitySettingsMetadata = {};
                        
                        var eqlProperty = {};
                        
                        Bridge.Deconstruct(this.metadataServiceContext.EleWise_ELMA_Core$EleWise$ELMA$Core$Services$IMetadataServiceContext$GetPropertyWithOwner(settingsMetadata, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.entitySettingsComputedEqlPropertyMetadataUid).$clone(), entitySettingsMetadata, eqlProperty);
                        
                        var expression = this.metadataServiceContext.EleWise_ELMA_Core$EleWise$ELMA$Core$Services$IMetadataServiceContext$GetPropertyExpression(eqlProperty.v, entitySettingsMetadata.v);
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String, this, Bridge.fn.cacheBind(this, this.WriteGetterConfigurable), [computedEqlProperty, settings, expression.name]);
                        const reaction = mobx.reaction(getFilterQuery, function(computedEqlQuery)
                            {
                                viewModel.UpdateEqlComputedValue(context, property, computedEqlQuery, dispatcher)
                            });
                        if (!viewModel.eqlReactions)
                        {
                            viewModel.eqlReactions = []
                        }
                        viewModel.eqlReactions.push(reaction)
                    }
                }
                else if (!propertyMd.Input$c781b82e80294ba6b48504ec94db549f && propertyMd.ClientOnly$c781b82e80294ba6b48504ec94db549f && propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f != null && propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f.ComputedValueType$ceb86c18c8be4a8fb41120449f1b9d42 !== EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input && ((propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f.ComputedValueType$ceb86c18c8be4a8fb41120449f1b9d42 === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function && !System.String.isNullOrWhiteSpace(propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f.MethodName$ceb86c18c8be4a8fb41120449f1b9d42)) || (propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f.ComputedValueType$ceb86c18c8be4a8fb41120449f1b9d42 === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript && !System.String.isNullOrWhiteSpace(propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f.CalculateScript$ceb86c18c8be4a8fb41120449f1b9d42))))
                {
                    
                    var computed = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.ComputedValueMapToObject(propertyMd.ComputedValue$c781b82e80294ba6b48504ec94db549f);
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$4(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.Object, this, Bridge.fn.cacheBind(this, this.WriteComputedGetter), [viewModel, computed, context, propertyExpression])
                }
            }, InitPropertySettings: function(property, parameters)
                {
                    var $t;
                    
                    var viewModelProperty;
                    
                    if (!(((viewModelProperty = Bridge.as(property, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("c781b82e-8029-4ba6-b485-04ec94db549f")))) != null))
                    {
                        
                        return
                    }
                    
                    var viewModelWithDynamicPropertySettings;
                    
                    if (!(((viewModelWithDynamicPropertySettings = Bridge.as(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModelWithDynamicPropertySettings))) != null))
                    {
                        
                        return
                    }
                    
                    var propertySettings = EleWise_ELMA_Core.EleWise.ELMA.DataClassHelper.Clone(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("b4b6d6ec-d534-49b5-a962-9afe59fd33f7"), viewModelProperty.Settings$7314171f42964f23a04631594a2d6e53);
                    
                    $t = Bridge.getEnumerator(viewModelProperty.ComputedValues$c781b82e80294ba6b48504ec94db549f, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("ceb86c18-c8be-4a8f-b411-20449f1b9d42"));
                    try
                    {
                        while ($t.moveNext())
                        {
                            var computedValue = $t.Current;
                            
                            var actionInputComputedValue;
                            
                            if (((actionInputComputedValue = Bridge.as(computedValue, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("f46b8142-cca8-4e2d-955f-c4f4b937b043")))) != null && System.Guid.op_Equality(actionInputComputedValue.TypeUid$fc74fd85634743b592693b114208d359, EleWise_ELMA_Core.EleWise.ELMA.Model.Types.ActionDescriptor.UID))
                            {
                                
                                var actionInputComputedVal = Bridge.as(EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.ComputedValueMapToObject(actionInputComputedValue), EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ActionInputComputedValue);
                                
                                var actionValue = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ActionComputedValueHelper.CreateActionValue(actionInputComputedVal, null);
                                
                                var context = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.EmptyActionExecutionContext.$ctor1(property, function()
                                    {
                                        return parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller
                                    });
                                
                                if (!System.String.isNullOrWhiteSpace(actionValue.MethodName))
                                {
                                    
                                    context = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ClientFunctionExecutionContext.$ctor1(actionValue.MethodName, function()
                                    {
                                        return parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller
                                    }, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack)
                                }
                                
                                var returnType = actionInputComputedVal.ReturnType;
                                
                                var parameterType = actionInputComputedVal.ParameterType;
                                
                                var action = this.CreateClosureForAction(returnType, parameterType, context);
                                
                                if (action == null)
                                {
                                    
                                    continue
                                }
                                
                                var actionPropInfo = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.GetDynamicPropertyInfo(viewModelProperty, computedValue.Name$ceb86c18c8be4a8fb41120449f1b9d42);
                                
                                var info = {
                                        name: actionPropInfo.Item2, serializedName: actionPropInfo.Item2
                                    };
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(System.Object, System.Object, System.Object, propertySettings, function(target, expression, value)
                                {
                                    return Reactive.convertHelper.RedefineProp(target, expression, value)
                                }, [propertySettings, info, action]);
                                
                                continue
                            }
                            
                            if (computedValue.ComputedValueType$ceb86c18c8be4a8fb41120449f1b9d42 === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input)
                            {
                                
                                continue
                            }
                            
                            var propInfo = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.GetDynamicPropertyInfo(viewModelProperty, computedValue.Name$ceb86c18c8be4a8fb41120449f1b9d42);
                            
                            var target = propInfo.Item1;
                            
                            if (target == null)
                            {
                                
                                continue
                            }
                            
                            var targetPropertyName = propInfo.Item2;
                            
                            if (!EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.HasProperty(target, targetPropertyName))
                            {
                                
                                continue
                            }
                            
                            var computedVal = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.ComputedValueMapToObject(computedValue);
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String, this, Bridge.fn.cacheBind(this, this.WriteGetter), [computedVal, target, targetPropertyName])
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    viewModelWithDynamicPropertySettings.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModelWithDynamicPropertySettings$DynamicSettings.setItem(viewModelProperty, propertySettings)
                }, InitDynamicProperties: function(parameters, viewItem)
                {
                    var $t,
                        $t1,
                        $t2;
                    
                    var over = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(System.Boolean, viewItem, "over");
                    
                    if (over)
                    {
                        
                        return
                    }
                    
                    if (viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Hide)
                    {
                        
                        return
                    }
                    
                    var form;
                    
                    if (((form = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.FormViewItem))) != null && form.Toolbar != null)
                    {
                        
                        this.InitDynamicProperties(parameters, form.Toolbar)
                    }
                    
                    var rootViewItem;
                    
                    if (((rootViewItem = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.RootViewItem))) != null)
                    {
                        
                        $t = Bridge.getEnumerator(rootViewItem.Items);
                        try
                        {
                            while ($t.moveNext())
                            {
                                var item = $t.Current;
                                
                                this.InitDynamicProperties(parameters, item)
                            }
                        }
                        finally
                        {
                            if (Bridge.is($t, System.IDisposable))
                            {
                                $t.System$IDisposable$Dispose()
                            }
                        }
                    }
                    
                    var needSimpleTestValue = true;
                    
                    $t1 = Bridge.getEnumerator(viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$DynamicProperties, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue);
                    try
                    {
                        while ($t1.moveNext())
                        {
                            var dynamicProperty = $t1.Current;
                            
                            if (System.String.contains(dynamicProperty.Name, "Attributes.TypeSettings."))
                            {
                                
                                continue
                            }
                            
                            var propInfo = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.GetDynamicPropertyInfo(viewItem, dynamicProperty.Name);
                            
                            var target = propInfo.Item1;
                            
                            if (target == null)
                            {
                                
                                continue
                            }
                            
                            var propertyName = propInfo.Item2;
                            
                            if (Bridge.referenceEquals(propertyName, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.TestPropertyName) && dynamicProperty.ComputedValueType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function)
                            {
                                
                                needSimpleTestValue = false
                            }
                            
                            if (!EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.HasProperty(target, propertyName))
                            {
                                
                                continue
                            }
                            
                            if (dynamicProperty.ComputedValueType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input)
                            {
                                
                                var isAction = {};
                                
                                var actionValue = {};
                                
                                Bridge.Deconstruct(EleWise_ELMA_Core.EleWise.ELMA.Helpers.ActionComputedValueHelper.IsAction(dynamicProperty).$clone(), isAction, actionValue);
                                
                                if (isAction.v)
                                {
                                    
                                    var info = Bridge.Reflection.getMembers(Bridge.getType(target), 16, 284, propertyName);
                                    
                                    if (info == null)
                                    {
                                        
                                        continue
                                    }
                                    
                                    var executionContext = null;
                                    
                                    var actionType = null;
                                    
                                    var parameterType = null;
                                    
                                    var returnType = null;
                                    
                                    if (Bridge.referenceEquals(info.rt, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction))
                                    {
                                        
                                        actionType = EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction
                                    }
                                    else if (Bridge.Reflection.isGenericType(info.rt))
                                    {
                                        
                                        var genericArguments = Bridge.Reflection.getGenericArguments(info.rt);
                                        
                                        var genericTypeDefinition = Bridge.Reflection.getGenericTypeDefinition(info.rt);
                                        
                                        if (Bridge.referenceEquals(genericTypeDefinition, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParam$1))
                                        {
                                            
                                            actionType = EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParam$1.apply(null, genericArguments);
                                            
                                            parameterType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToSignature(System.Linq.Enumerable.from(genericArguments, System.Type).firstOrDefault(null, null))
                                        }
                                        else if (Bridge.referenceEquals(genericTypeDefinition, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithResult$1))
                                        {
                                            
                                            actionType = EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithResult$1.apply(null, genericArguments);
                                            
                                            returnType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToSignature(System.Linq.Enumerable.from(genericArguments, System.Type).firstOrDefault(null, null))
                                        }
                                        else if (Bridge.referenceEquals(genericTypeDefinition, EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParamResult$2))
                                        {
                                            
                                            actionType = EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParamResult$2.apply(null, genericArguments);
                                            
                                            parameterType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToSignature(System.Linq.Enumerable.from(genericArguments, System.Type).firstOrDefault(null, null));
                                            
                                            returnType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToSignature(System.Linq.Enumerable.from(genericArguments, System.Type).lastOrDefault(null, null))
                                        }
                                    }
                                    
                                    if (actionValue.v == null)
                                    {
                                        
                                        executionContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.EmptyActionExecutionContext.ctor
                                    }
                                    
                                    switch (actionValue.v.CodeType)
                                    {
                                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Client:
                                            {
                                                
                                                if (System.String.isNullOrWhiteSpace(actionValue.v.MethodName))
                                                {
                                                    
                                                    break
                                                }
                                                
                                                executionContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ClientFunctionExecutionContext.ctor(actionValue.v.MethodName);
                                                
                                                break
                                            }
                                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Server:
                                            {
                                                
                                                if (System.String.isNullOrWhiteSpace(actionValue.v.MethodName))
                                                {
                                                    
                                                    break
                                                }
                                                
                                                var metadataUid = parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid;
                                                
                                                var metadataTypeUid = parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid;
                                                
                                                if (System.Guid.op_Equality(metadataUid, System.Guid.Empty) || System.Guid.op_Equality(metadataTypeUid, System.Guid.Empty))
                                                {
                                                    
                                                    break
                                                }
                                                
                                                executionContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ServerFunctionExecutionContext(actionValue.v.MethodName, metadataTypeUid, metadataUid, {
                                                    Nullable: returnType.Nullable, RelationType: returnType.RelationType, TypeUid: returnType.TypeUid, SubTypeUid: returnType.SubTypeUid
                                                }, {
                                                    Nullable: parameterType.Nullable, RelationType: parameterType.RelationType, TypeUid: parameterType.TypeUid, SubTypeUid: parameterType.SubTypeUid
                                                });
                                                
                                                break
                                            }
                                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Test:
                                            {
                                                
                                                break
                                            }
                                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.GlobalFunction:
                                            {
                                                
                                                var metadataUid1 = parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid;
                                                
                                                if (System.Guid.op_Equality(metadataUid1, System.Guid.Empty))
                                                {
                                                    
                                                    break
                                                }
                                                
                                                var functionItemUid = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$GetFunctionItemUid(metadataUid1, actionValue.v.FunctionHeaderUid);
                                                
                                                if (System.Guid.op_Equality(functionItemUid, System.Guid.Empty))
                                                {
                                                    
                                                    functionItemUid = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$GetFunctionItemUid(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid, actionValue.v.FunctionHeaderUid)
                                                }
                                                
                                                executionContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.GlobalFunctionExecutionContext(functionItemUid, {
                                                    Nullable: returnType.Nullable, RelationType: returnType.RelationType, TypeUid: returnType.TypeUid, SubTypeUid: returnType.SubTypeUid
                                                }, {
                                                    Nullable: parameterType.Nullable, RelationType: parameterType.RelationType, TypeUid: parameterType.TypeUid, SubTypeUid: parameterType.SubTypeUid
                                                });
                                                
                                                break
                                            }
                                        default:
                                            {
                                                
                                                break
                                            }
                                    }
                                    
                                    if (actionType != null && executionContext != null)
                                    {
                                        
                                        var action = Bridge.cast(Bridge.createInstance(actionType, [executionContext, this.actionExecutionFacade]), EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IAction);
                                        
                                        var propExprInfo = {
                                                name: propertyName, serializedName: propertyName
                                            };
                                        
                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(System.Object, System.Object, System.Object, target, function(target, expression, value)
                                        {
                                            return Reactive.convertHelper.RedefineProp(target, expression, value)
                                        }, [target, propExprInfo, action])
                                    }
                                }
                                
                                continue
                            }
                            else
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String, this, Bridge.fn.cacheBind(this, this.GetPropertyValue), [dynamicProperty, target, propertyName]);
                                
                                var interfaces = System.Linq.Enumerable.from(Bridge.Reflection.getInterfaces(Bridge.getType(target)), System.Type).where(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.f1)).toList(System.Type);
                                
                                if (interfaces.Count <= 0)
                                {
                                    
                                    continue
                                }
                                
                                $t2 = Bridge.getEnumerator(interfaces);
                                try
                                {
                                    while ($t2.moveNext())
                                    {
                                        var i = $t2.Current;
                                        
                                        var property = Bridge.Reflection.getMembers(i, 16, 284, propertyName);
                                        
                                        if (property == null)
                                        {
                                            
                                            continue
                                        }
                                        
                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValue, System.Object, System.String, this, Bridge.fn.cacheBind(this, this.GetPropertyValue), [dynamicProperty, target, property.fn])
                                    }
                                }
                                finally
                                {
                                    if (Bridge.is($t2, System.IDisposable))
                                    {
                                        $t2.System$IDisposable$Dispose()
                                    }
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t1, System.IDisposable))
                        {
                            $t1.System$IDisposable$Dispose()
                        }
                    }
                    
                    if (needSimpleTestValue)
                    {
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.Closure$3(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, System.String, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters, this, Bridge.fn.cacheBind(this, this.GetTestIdValue), [viewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.TestPropertyName, parameters])
                    }
                    
                    viewItem.over = Bridge.box(true, System.Boolean, System.Boolean.toString)
                }, GetPropertyValue: function(inp, context, propertyName)
                {
                    
                    var valueF = null;
                    
                    switch (inp.ComputedValueType)
                    {
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Property:
                            {
                                
                                valueF = Bridge.fn.bind(this, function()
                                {
                                    var $t;
                                    
                                    var scope = EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.GetScope();
                                    
                                    if (scope == null)
                                    {
                                        
                                        throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0441\u043a\u043e\u0443\u043f \u0434\u043b\u044f \u0441\u0432\u043e\u0439\u0441\u0442\u0432\u0430 {0}, \u0432\u044b\u0447\u0438\u0441\u043b\u044f\u0435\u043c\u043e\u0433\u043e \u0441 \u043f\u043e\u043c\u043e\u0449\u044c\u044e \u043c\u0435\u0442\u043e\u0434\u0430 {1}", propertyName, inp.MethodName));
                                    }
                                    
                                    var metadataViewModel;
                                    
                                    if (!(((metadataViewModel = Bridge.as(scope, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null))
                                    {
                                        
                                        return null
                                    }
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.MetadataViewModelHelper.GetPropertyContext(System.Object, metadataViewModel, this.metadataServiceContext, inp.PropertyUid, ($t = System.Guid, System.Linq.Enumerable.from(inp.PropertyParents, $t).ToArray($t)))()
                                });
                                
                                break
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function:
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript:
                            {
                                
                                valueF = function()
                                {
                                    
                                    var scope = EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.GetScope();
                                    
                                    if (scope == null)
                                    {
                                        
                                        throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0441\u043a\u043e\u0443\u043f \u0434\u043b\u044f \u0441\u0432\u043e\u0439\u0441\u0442\u0432\u0430 {0}, \u0432\u044b\u0447\u0438\u0441\u043b\u044f\u0435\u043c\u043e\u0433\u043e \u0441 \u043f\u043e\u043c\u043e\u0449\u044c\u044e \u043c\u0435\u0442\u043e\u0434\u0430 {1}", propertyName, inp.MethodName));
                                    }
                                    
                                    var methodName = inp.MethodName;
                                    
                                    var stack = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, scope, "Stack");
                                    
                                    var formViewModel;
                                    
                                    if (((formViewModel = Bridge.as(scope, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                                    {
                                        
                                        return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod$1(formViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IFormViewModel$Controllers, methodName, stack)
                                    }
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(scope.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller, methodName, stack)
                                };
                                
                                break
                            }
                    }
                    Object.defineProperty(context, propertyName, {
                        configurable: true, get: function()
                            {
                                return valueF()
                            }
                    })
                }, GetTestIdValue: function(viewItem, propertyName, parameters)
                {
                    
                    var moduleName = this.moduleMetadataItemManager.GetHeaderName(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid);
                    
                    var namedMetadata;
                    
                    var componentName = ((namedMetadata = Bridge.as(Bridge.cast(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel).EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$UIViewModel.Metadata$da8d5f8975c14c7c9656a09ef6718832, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("16615caf-9eeb-4494-a5dc-8600a399a3e9")))) != null ? namedMetadata.Name$6eec8103a7b64f87b992ddd03d2e3f4e : "";
                    
                    var viewItemName = viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Name;
                    
                    var testId = System.String.format("{0}-{1}-{2}", moduleName, componentName, viewItemName);
                    
                    var valueF = function()
                        {
                            return testId
                        };
                    Object.defineProperty(viewItem, propertyName, {
                        configurable: true, get: function()
                            {
                                return valueF()
                            }
                    })
                }, GetActionForInput: function(property, computedValue, parameters)
                {
                    var $t,
                        $t1,
                        $t2,
                        $t3,
                        $t4;
                    
                    var owner = parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner;
                    
                    if (owner == null)
                    {
                        
                        return null
                    }
                    
                    var settings;
                    
                    do
                    {
                        
                        ($t = computedValue.ComputedValueType);
                        
                        if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input)
                        {
                            
                            if (((settings = Bridge.as(property.Settings$7314171f42964f23a04631594a2d6e53, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("a9a4667f-c187-47b4-8e08-e9af6be3bf42")))) != null)
                            {
                                {
                                    
                                    var metadataViewModel = Bridge.as(owner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel);
                                    
                                    var actionValue = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ActionComputedValueHelper.CreateActionValue(computedValue, null);
                                    
                                    var getControllerFunc = function()
                                        {
                                            return parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller
                                        };
                                    
                                    var formViewModel = {};
                                    
                                    if (((formViewModel.v = Bridge.as(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                                    {
                                        
                                        var methodName = {v: EleWise_ELMA_Core.EleWise.ELMA.Helpers.ScriptMethodInfoHelper.Deserialize(actionValue.MethodName).Name};
                                        
                                        if (!System.String.isNullOrWhiteSpace(methodName.v))
                                        {
                                            
                                            getControllerFunc = (function($me, formViewModel, methodName)
                                            {
                                                return function()
                                                    {
                                                        return System.Linq.Enumerable.from(formViewModel.v.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IFormViewModel$Controllers, System.Collections.Generic.KeyValuePair$2(System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)).firstOrDefault(function(c)
                                                            {
                                                                return c.value[methodName.v] != null
                                                            }, new(System.Collections.Generic.KeyValuePair$2(System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController))).value
                                                    }
                                            })(this, formViewModel, methodName)
                                        }
                                    }
                                    
                                    var executionContext = this.GetActionExecutionContext(property, actionValue, settings, ($t1 = (metadataViewModel != null ? metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$UIViewModel.Uid$da8d5f8975c14c7c9656a09ef6718832 : null), $t1 != null ? $t1 : System.Guid.Empty), ($t2 = (metadataViewModel != null ? metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$UIViewModel.TypeUid$da8d5f8975c14c7c9656a09ef6718832 : null), $t2 != null ? $t2 : System.Guid.Empty), ($t3 = (metadataViewModel != null ? metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$UIViewModel.Metadata$da8d5f8975c14c7c9656a09ef6718832.ModuleUid$9e705bcb534845a0a6d4073fd09a09f5 : null), $t3 != null ? $t3 : System.Guid.Empty), parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack, getControllerFunc);
                                    
                                    var returnType = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.TypeSignatureMapToObject(settings.ReturnType$a9a4667fc18747b48e08e9af6be3bf42);
                                    
                                    var parameterType = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.TypeSignatureMapToObject(settings.ParameterType$a9a4667fc18747b48e08e9af6be3bf42);
                                    
                                    return this.CreateClosureForAction(returnType, parameterType, executionContext)
                                }
                            }
                        }
                        
                        if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Property)
                        {
                            {
                                
                                return EleWise_ELMA_Core.EleWise.ELMA.Helpers.MetadataViewModelHelper.GetPropertyContext(System.Object, Bridge.cast(owner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel), this.metadataServiceContext, computedValue.PropertyUid, ($t4 = System.Guid, System.Linq.Enumerable.from(computedValue.PropertyParents, $t4).ToArray($t4)))()
                            }
                        }
                        
                        if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function)
                        {
                            {
                                
                                break
                            }
                        }
                        
                        if ($t === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript)
                        {
                            {
                                
                                return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller, computedValue.MethodName, null)
                            }
                        }
                        {
                            {
                                
                                break
                            }
                        }
                    } while (false);
                    
                    return null
                }, WriteComputedGetter: function(viewModel, inp, context, expression)
                {
                    
                    var valueF = this.GetValueFunc(inp, viewModel);
                    
                    Reactive.convertHelper.RedefinePropFunc(Bridge.unbox(context), expression, valueF)
                }, WriteGetter: function(inp, context, propertyName)
                {
                    
                    var valueF = this.GetValueFunc(inp);
                    Object.defineProperty(context, propertyName, {get: function()
                        {
                            return valueF()
                        }})
                }, WriteGetterConfigurable: function(inp, context, propertyName)
                {
                    
                    var valueF = this.GetValueFunc(inp);
                    Object.defineProperty(context, propertyName, {
                        configurable: true, get: function()
                            {
                                return valueF()
                            }
                    })
                }, GetValueFunc: function(inp, viewModel)
                {
                    if (viewModel === void 0)
                    {
                        viewModel = null
                    }
                    
                    var valueF = null;
                    
                    var scope = viewModel;
                    
                    switch (inp.ComputedValueType)
                    {
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Property:
                            {
                                
                                valueF = Bridge.fn.bind(this, function()
                                {
                                    var $t;
                                    
                                    if (scope == null)
                                    {
                                        
                                        scope = EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.GetScope();
                                        
                                        if (scope == null)
                                        {
                                            
                                            throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0441\u043a\u043e\u0443\u043f \u0434\u043b\u044f \u043c\u0435\u0442\u043e\u0434\u0430 {0}", inp.MethodName));
                                        }
                                    }
                                    
                                    var metadataViewModel;
                                    
                                    if (!(((metadataViewModel = Bridge.as(scope, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null))
                                    {
                                        
                                        return null
                                    }
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.MetadataViewModelHelper.GetPropertyContext(System.Object, metadataViewModel, this.metadataServiceContext, inp.PropertyUid, ($t = System.Guid, System.Linq.Enumerable.from(inp.PropertyParents, $t).ToArray($t)))()
                                });
                                
                                break
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function:
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript:
                            {
                                
                                valueF = function()
                                {
                                    
                                    if (scope == null)
                                    {
                                        
                                        scope = EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.GetScope();
                                        
                                        if (scope == null)
                                        {
                                            
                                            throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0441\u043a\u043e\u0443\u043f \u0434\u043b\u044f \u043c\u0435\u0442\u043e\u0434\u0430 {0}", inp.MethodName));
                                        }
                                    }
                                    
                                    var methodName = inp.MethodName;
                                    
                                    var stack = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, scope, "Stack");
                                    
                                    var formViewModel;
                                    
                                    if (((formViewModel = Bridge.as(scope, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                                    {
                                        
                                        return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod$1(formViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IFormViewModel$Controllers, methodName, stack)
                                    }
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(scope.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller, methodName, stack)
                                };
                                
                                break
                            }
                    }
                    
                    return valueF
                }, DefineInputs: function(renderOwner, context, typeUid, expression, inp, stack)
                {
                    var $t;
                    
                    Reactive.convertHelper.DefineInput(context, expression);
                    
                    var value;
                    
                    switch (inp.ComputedValueType)
                    {
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Input:
                            {
                                
                                value = Bridge.fn.bind(this, function()
                                {
                                    
                                    var inputComputedValue;
                                    
                                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ComputedValueHelper.GetValue(this.descriptorService, typeUid, inp.Value, this.convertContext, ((inputComputedValue = Bridge.as(inp, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.InputComputedValue))) != null ? inputComputedValue.Nullable : null)
                                });
                                
                                break
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Property:
                            {
                                
                                value = EleWise_ELMA_Core.EleWise.ELMA.Helpers.MetadataViewModelHelper.GetPropertyContext(System.Object, Bridge.cast(renderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel), this.metadataServiceContext, inp.PropertyUid, ($t = System.Guid, System.Linq.Enumerable.from(inp.PropertyParents, $t).ToArray($t)));
                                
                                break
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function:
                        case EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.CalculateScript:
                            {
                                
                                value = function()
                                {
                                    return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.ExecuteMethod(renderOwner, inp.MethodName, stack)
                                };
                                
                                break
                            }
                        default:
                            {
                                
                                throw new System.ArgumentOutOfRangeException.ctor;
                            }
                    }
                    
                    Reactive.convertHelper.RedefinePropFunc(context, expression, value)
                }, DefineSetterCallback: function(renderOwner, context, typeUid, expression, inp, stack)
                {
                    
                    var actionInputComputedValue;
                    
                    if (((actionInputComputedValue = Bridge.as(inp, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ActionInputComputedValue))) != null)
                    {
                        
                        var executeContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.EmptyActionExecutionContext.ctor;
                        
                        if (!System.String.isNullOrWhiteSpace(actionInputComputedValue.MethodName))
                        {
                            
                            executeContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ClientFunctionExecutionContext.$ctor1(actionInputComputedValue.MethodName, null, null)
                        }
                        else
                        {
                            
                            var isAction = {};
                            
                            var actionValue = {};
                            
                            Bridge.Deconstruct(EleWise_ELMA_Core.EleWise.ELMA.Helpers.ActionComputedValueHelper.IsAction(actionInputComputedValue).$clone(), isAction, actionValue);
                            
                            if (isAction.v)
                            {
                                
                                executeContext = new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ClientFunctionExecutionContext.$ctor1(actionValue.v.MethodName, null, null)
                            }
                        }
                        
                        var action = this.CreateClosureForAction$1(actionInputComputedValue, executeContext);
                        
                        if (action == null)
                        {
                            
                            return
                        }
                        
                        Reactive.convertHelper.DefinePropSetterCallback(context, expression, Bridge.unbox(action));
                        
                        return
                    }
                    
                    if (inp.ComputedValueType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComputedValueType.Function && Bridge.is(inp, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.InputComputedValue))
                    {
                        
                        var action1 = function()
                            {
                                return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler.ExecuteMethod(renderOwner, inp.MethodName, stack)
                            };
                        
                        Reactive.convertHelper.DefinePropSetterCallback(context, expression, action1);
                        
                        return
                    }
                }, DefineSetterProperty: function(renderOwner, context, typeUid, expression, inp, stack)
                {
                    var $t;
                    
                    var metadataViewModel;
                    
                    if (!(((metadataViewModel = Bridge.as(renderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null))
                    {
                        
                        return
                    }
                    
                    var ownerContext = {};
                    
                    var setterPropertyExpression = {};
                    
                    Bridge.Deconstruct(EleWise_ELMA_Core.EleWise.ELMA.Helpers.MetadataViewModelHelper.GetPropertyContext$1(metadataViewModel, this.metadataServiceContext, inp.PropertyUid, ($t = System.Guid, System.Linq.Enumerable.from(inp.PropertyParents, $t).ToArray($t))).$clone(), ownerContext, setterPropertyExpression);
                    
                    Reactive.convertHelper.DefinePropSetters(context, expression, Bridge.unbox(ownerContext.v), setterPropertyExpression.v)
                }, CreateClosureForAction$1: function(actionInputComputedValue, actionExecutionContext)
                {
                    
                    var action;
                    
                    var actionType;
                    
                    var returnType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToType(actionInputComputedValue.ReturnType);
                    
                    var parameterType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToType(actionInputComputedValue.ParameterType);
                    
                    if (parameterType == null)
                    {
                        
                        actionType = returnType == null ? EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction : EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithResult$1.apply(null, System.Array.init([returnType], System.Type));
                        
                        action = Bridge.cast(Bridge.createInstance(actionType, [actionExecutionContext, this.actionExecutionFacade]), EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IAction);
                        
                        return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.CreateForActionWithParam(action)
                    }
                    
                    actionType = returnType == null ? EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParam$1.apply(null, System.Array.init([parameterType], System.Type)) : EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParamResult$2.apply(null, System.Array.init([parameterType, returnType], System.Type));
                    
                    action = Bridge.cast(Bridge.createInstance(actionType, [actionExecutionContext, this.actionExecutionFacade]), EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IAction);
                    
                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.CreateForActionWithParam(action)
                }, CreateClosureForAction: function(returnTypeSignature, parameterTypeSignature, actionExecutionContext)
                {
                    
                    var action;
                    
                    var actionType;
                    
                    var returnType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToType(returnTypeSignature);
                    
                    var parameterType = this.convertService.EleWise_ELMA_Core$EleWise$ELMA$Services$IConvertService$ToType(parameterTypeSignature);
                    
                    if (parameterType == null)
                    {
                        
                        actionType = returnType == null ? EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction : EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithResult$1.apply(null, System.Array.init([returnType], System.Type));
                        
                        action = Bridge.cast(Bridge.createInstance(actionType, [actionExecutionContext, this.actionExecutionFacade]), EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IAction);
                        
                        return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.CreateForActionWithParam(action)
                    }
                    
                    actionType = returnType == null ? EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParam$1.apply(null, System.Array.init([parameterType], System.Type)) : EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ActionWithParamResult$2.apply(null, System.Array.init([parameterType, returnType], System.Type));
                    
                    action = Bridge.cast(Bridge.createInstance(actionType, [actionExecutionContext, this.actionExecutionFacade]), EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.IAction);
                    
                    return EleWise_ELMA_Core.EleWise.ELMA.Helpers.ClosureHelper.CreateForActionWithParam(action)
                }, GetActionForProperty: function(property, parameters)
                {
                    var $t,
                        $t1;
                    
                    var settings = Bridge.as(property.Settings$7314171f42964f23a04631594a2d6e53, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("a9a4667f-c187-47b4-8e08-e9af6be3bf42"));
                    
                    if (settings == null)
                    {
                        
                        return null
                    }
                    
                    var getControllerFunc = function()
                        {
                            return parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller
                        };
                    
                    var formViewModel;
                    
                    if (((formViewModel = Bridge.as(parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                    {
                        
                        var methodName = ($t = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ScriptMethodInfoHelper.Deserialize(settings.DefaultValue$a9a4667fc18747b48e08e9af6be3bf42.MethodName$81e07c69a2d040f1a81153d7f4e9efb2)) != null ? $t.Name : null;
                        
                        if (!System.String.isNullOrWhiteSpace(methodName))
                        {
                            
                            getControllerFunc = function()
                            {
                                return System.Linq.Enumerable.from(formViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IFormViewModel$Controllers, System.Collections.Generic.KeyValuePair$2(System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)).firstOrDefault(function(c)
                                    {
                                        return c.value[methodName] != null
                                    }, new(System.Collections.Generic.KeyValuePair$2(System.Guid, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController))).value
                            }
                        }
                    }
                    
                    var actionDefaultValue = null;
                    
                    var actionSettingsDefaultValue = settings.DefaultValue$a9a4667fc18747b48e08e9af6be3bf42;
                    
                    if (actionSettingsDefaultValue != null)
                    {
                        
                        actionDefaultValue = ($t1 = new EleWise_ELMA_Core.EleWise.ELMA.Model.ActionValue, $t1.CodeType = actionSettingsDefaultValue.CodeType$81e07c69a2d040f1a81153d7f4e9efb2, $t1.MethodName = actionSettingsDefaultValue.MethodName$81e07c69a2d040f1a81153d7f4e9efb2, $t1.FunctionHeaderUid = actionSettingsDefaultValue.FunctionHeaderUid$81e07c69a2d040f1a81153d7f4e9efb2, $t1)
                    }
                    
                    var executionContext = this.GetActionExecutionContext(property, actionDefaultValue, settings, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid, parameters.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack, getControllerFunc);
                    
                    var returnType = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.TypeSignatureMapToObject(settings.ReturnType$a9a4667fc18747b48e08e9af6be3bf42);
                    
                    var parameterType = EleWise_ELMA_Core.EleWise.ELMA.Helpers.DynamicPropertyHelper.TypeSignatureMapToObject(settings.ParameterType$a9a4667fc18747b48e08e9af6be3bf42);
                    
                    return this.CreateClosureForAction(returnType, parameterType, executionContext)
                }, GetActionExecutionContext: function(propertyMetadata, actionValue, settings, metadataUid, metadataTypeUid, metadataModuleUid, outerStack, controllerFunc)
                {
                    
                    if (actionValue == null)
                    {
                        
                        return new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.EmptyActionExecutionContext.$ctor1(propertyMetadata, controllerFunc)
                    }
                    
                    switch (actionValue.CodeType)
                    {
                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Client:
                            {
                                
                                if (System.String.isNullOrWhiteSpace(actionValue.MethodName))
                                {
                                    
                                    break
                                }
                                
                                return new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ClientFunctionExecutionContext.$ctor1(actionValue.MethodName, controllerFunc, outerStack)
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Server:
                            {
                                
                                if (System.String.isNullOrWhiteSpace(actionValue.MethodName))
                                {
                                    
                                    break
                                }
                                
                                if (System.Guid.op_Equality(metadataUid, System.Guid.Empty) || System.Guid.op_Equality(metadataTypeUid, System.Guid.Empty))
                                {
                                    
                                    break
                                }
                                
                                var settingsReturnType = settings.ReturnType$a9a4667fc18747b48e08e9af6be3bf42;
                                
                                var returnType = {
                                        Nullable: settingsReturnType.Nullable$06a8d3dadb2244799862c6e42734547a, RelationType: settingsReturnType.RelationType$06a8d3dadb2244799862c6e42734547a, TypeUid: settingsReturnType.TypeUid$06a8d3dadb2244799862c6e42734547a, SubTypeUid: settingsReturnType.SubTypeUid$06a8d3dadb2244799862c6e42734547a
                                    };
                                
                                var settingsParameterType = settings.ParameterType$a9a4667fc18747b48e08e9af6be3bf42;
                                
                                var parameterType = {
                                        Nullable: settingsParameterType.Nullable$06a8d3dadb2244799862c6e42734547a, RelationType: settingsParameterType.RelationType$06a8d3dadb2244799862c6e42734547a, TypeUid: settingsParameterType.TypeUid$06a8d3dadb2244799862c6e42734547a, SubTypeUid: settingsParameterType.SubTypeUid$06a8d3dadb2244799862c6e42734547a
                                    };
                                
                                return new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.ServerFunctionExecutionContext(actionValue.MethodName, metadataTypeUid, metadataUid, returnType, parameterType)
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.Test:
                            {
                                
                                break
                            }
                        case EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.CodeType.GlobalFunction:
                            {
                                
                                if (System.Guid.op_Equality(metadataUid, System.Guid.Empty))
                                {
                                    
                                    break
                                }
                                
                                var functionHeaderUid = actionValue.FunctionHeaderUid;
                                
                                var functionItemUid = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$GetFunctionItemUid(metadataUid, functionHeaderUid);
                                
                                if (System.Guid.op_Equality(functionItemUid, System.Guid.Empty))
                                {
                                    
                                    functionItemUid = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$GetFunctionItemUid(metadataModuleUid, functionHeaderUid)
                                }
                                
                                var settingsReturnType1 = settings.ReturnType$a9a4667fc18747b48e08e9af6be3bf42;
                                
                                var returnType1 = {
                                        Nullable: settingsReturnType1.Nullable$06a8d3dadb2244799862c6e42734547a, RelationType: settingsReturnType1.RelationType$06a8d3dadb2244799862c6e42734547a, TypeUid: settingsReturnType1.TypeUid$06a8d3dadb2244799862c6e42734547a, SubTypeUid: settingsReturnType1.SubTypeUid$06a8d3dadb2244799862c6e42734547a
                                    };
                                
                                var settingsParameterType1 = settings.ParameterType$a9a4667fc18747b48e08e9af6be3bf42;
                                
                                var parameterType1 = {
                                        Nullable: settingsParameterType1.Nullable$06a8d3dadb2244799862c6e42734547a, RelationType: settingsParameterType1.RelationType$06a8d3dadb2244799862c6e42734547a, TypeUid: settingsParameterType1.TypeUid$06a8d3dadb2244799862c6e42734547a, SubTypeUid: settingsParameterType1.SubTypeUid$06a8d3dadb2244799862c6e42734547a
                                    };
                                
                                return new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.GlobalFunctionExecutionContext(functionItemUid, returnType1, parameterType1)
                            }
                        default:
                            {
                                
                                break
                            }
                    }
                    
                    return new EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.EmptyActionExecutionContext.ctor
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.AbstractViewModelContextHandler, {f1: function(q)
    {
        return EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Attributes.DynamicPropertyContainerAttribute).GetAttribute$2(q, true) != null
    }});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputs$1", EleWise_ELMA_Core_React, function(TM)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Model.ViewModel.BaseInputs$2(TM, System.Array.type(Object))], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputController$2", EleWise_ELMA_Core_React, function(TM, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.Controller$1(TContext), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IBaseInputController, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IRequireOwnerController], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        v: true, a: 2, n: "GetName", t: 8, pi: [{
                                                    n: "newName", dv: "", o: true, pt: System.String, ps: 0
                                                }], sn: "GetName", rt: System.String, p: [System.String]
                                    }, {
                                        a: 2, n: "OnBlur", t: 8, pi: [{
                                                    n: "value", pt: TM, ps: 0
                                                }, {
                                                    n: "ev", dv: null, o: true, pt: System.Object, ps: 1
                                                }], sn: "OnBlur", rt: System.Void, p: [TM, System.Object]
                                    }, {
                                        a: 2, n: "OnChange", t: 8, pi: [{
                                                    n: "value", pt: TM, ps: 0
                                                }, {
                                                    n: "ev", pt: System.Object, ps: 1
                                                }], sn: "OnChange", rt: System.Void, p: [TM, System.Object]
                                    }, {
                                        a: 2, n: "OnFocus", t: 8, pi: [{
                                                    n: "ev", dv: null, o: true, pt: System.Object, ps: 0
                                                }], sn: "OnFocus", rt: System.Void, p: [System.Object]
                                    }, {
                                        a: 2, n: "OnKeyPress", t: 8, pi: [{
                                                    n: "newEv", pt: System.Object, ps: 0
                                                }], sn: "OnKeyPress", rt: System.Void, p: [System.Object]
                                    }, {
                                        a: 2, n: "SetOwner", t: 8, pi: [{
                                                    n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                                }], sn: "SetOwner", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                                    }, {
                                        a: 3, n: "RenderOwner", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "RenderOwner"
                                    }, {
                                        a: 1, n: "caretPosition", t: 4, rt: System.Int64, sn: "caretPosition"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    caretPosition: System.Int64(0), RenderOwner: null
                }, alias: ["SetOwner", "EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IRequireOwnerController$SetOwner", "Component", "EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IController$Component"], ctors: {init: function()
                    {
                        this.caretPosition = System.Int64(0)
                    }}, methods: {
                    SetOwner: function(owner)
                    {
                        
                        this.RenderOwner = owner
                    }, GetName: function(newName)
                        {
                            var $t,
                                $t1,
                                $t2;
                            if (newName === void 0)
                            {
                                newName = ""
                            }
                            
                            var name = newName;
                            
                            if (System.String.isNullOrWhiteSpace(name))
                            {
                                
                                if (Bridge.staticEquals(this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyMetadata, null))
                                {
                                    
                                    return ""
                                }
                                
                                var property = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyMetadata();
                                
                                if (property == null)
                                {
                                    
                                    return ""
                                }
                                
                                name = property.Name$6eec8103a7b64f87b992ddd03d2e3f4e
                            }
                            
                            if (!System.String.isNullOrWhiteSpace(name))
                            {
                                
                                var stack;
                                
                                if (this.RenderOwner != null && ((stack = Bridge.as(this.RenderOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$GetDynamicData(), EleWise_ELMA_Core.EleWise.ELMA.Model.DataStack))) != null && stack.Count > 0 && (($t = System.Linq.Enumerable.from(stack, EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem).lastOrDefault(null, null)) != null ? $t.Data : null) != null)
                                {
                                    
                                    return ""
                                }
                                
                                var propertyOwner = !Bridge.staticEquals(($t1 = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyOwner), null) ? $t1() : null;
                                
                                var owner = Bridge.as(this.RenderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel);
                                
                                var ownerMetadata = owner != null && ($t2 = owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$ModelMetadata) != null ? $t2.Metadata : null;
                                
                                var metadata = propertyOwner != null ? EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.ModelMetadata, propertyOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context, "ModelMetadata") : null;
                                
                                if (metadata == null)
                                {
                                    
                                    return name
                                }
                                
                                var firstPrefix = "";
                                
                                if (Bridge.is(ownerMetadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("75c3e5c8-7786-48d1-94dc-bc3075933be0")) || Bridge.is(ownerMetadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e")))
                                {
                                    
                                    firstPrefix = "Entity"
                                }
                                else if (Bridge.is(ownerMetadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("44feaaa8-36a8-4a56-8c12-4d9ac24cfca8")))
                                {
                                    
                                    firstPrefix = "Context"
                                }
                                
                                var prefixArr = metadata.Prefix;
                                
                                if (prefixArr != null && prefixArr.length > 0)
                                {
                                    
                                    var prefix = prefixArr.join(".");
                                    
                                    if (System.String.startsWith(prefix, EleWise_ELMA_Core.EleWise.ELMA.Constants.RKKFormConstants.RKKFormPrefix))
                                    {
                                        
                                        prefix = System.String.replaceAll(System.String.replaceAll(prefix, "{30C24112-052F-426C-AC26-6735A2B99C13}.", ""), EleWise_ELMA_Core.EleWise.ELMA.Constants.RKKFormConstants.RKKFormPrefix, "");
                                        
                                        if (Bridge.referenceEquals(prefix, "RegistrationCard") || System.String.startsWith(prefix, "RegistrationCard."))
                                        {
                                            
                                            return System.String.format("{0}.{1}", prefix, name)
                                        }
                                    }
                                    
                                    if (System.String.startsWith(prefix, EleWise_ELMA_Core.EleWise.ELMA.Constants.RKKFormConstants.DocumentFormPrefix))
                                    {
                                        
                                        prefix = System.String.replaceAll(System.String.replaceAll(prefix, "{BB1D12A0-7814-48DC-BD8A-9C666BF9BEA8}.", ""), EleWise_ELMA_Core.EleWise.ELMA.Constants.RKKFormConstants.DocumentFormPrefix, "");
                                        
                                        if (Bridge.referenceEquals(prefix, "RegistrationCard"))
                                        {
                                            
                                            prefix = System.String.format("{0}[0]", [prefix])
                                        }
                                        else if (System.String.startsWith(prefix, "RegistrationCard."))
                                        {
                                            
                                            var parts = System.String.split(prefix, System.Array.init([46], System.Char).map(function(i)
                                                {
                                                    {
                                                        return String.fromCharCode(i)
                                                    }
                                                }), null, 1);
                                            
                                            parts[System.Array.index(0, parts)] = System.String.format("{0}[0]", [parts[System.Array.index(0, parts)]]);
                                            
                                            prefix = parts.join(".")
                                        }
                                    }
                                    
                                    return System.String.isNullOrWhiteSpace(prefix) ? System.String.format("{0}.{1}", firstPrefix, name) : System.String.format("{0}.{1}.{2}", firstPrefix, prefix, name)
                                }
                                
                                return System.String.format("{0}.{1}", firstPrefix, name)
                            }
                            
                            return ""
                        }, OnChange: function(value, ev)
                        {
                            var $t;
                            
                            if (ev != null)
                            {
                                
                                this.caretPosition = System.Int64(ev.currentTarget.selectionStart)
                            }
                            
                            var newEv = {
                                    CaretPosition: this.caretPosition, Value: value
                                };
                            
                            !Bridge.staticEquals(($t = Bridge.cast(this.Component, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IInputComponentContainer).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress), null) ? $t(newEv) : null
                        }, OnKeyPress: function(newEv)
                        {
                            
                            this.caretPosition = System.Int64(newEv.currentTarget.selectionStart);
                            
                            var onKeyPressEvent = Bridge.cast(this.Component, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IInputComponentContainer).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress;
                            
                            if (Bridge.staticEquals(onKeyPressEvent, null))
                            {
                                
                                return
                            }
                            
                            onKeyPressEvent({
                                Value: Bridge.unbox(this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Model), CaretPosition: this.caretPosition
                            })
                        }, OnFocus: function(ev)
                        {
                            if (ev === void 0)
                            {
                                ev = null
                            }
                            
                            if (ev != null)
                            {
                                
                                this.caretPosition = System.Int64(ev.currentTarget.selectionStart)
                            }
                            
                            var onFocusEvent = Bridge.cast(this.Component, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IInputComponentContainer).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnFocus;
                            
                            if (!Bridge.staticEquals(onFocusEvent, null))
                            {
                                
                                onFocusEvent({
                                    CaretPosition: this.caretPosition, Value: Bridge.unbox(this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Model)
                                })
                            }
                        }, OnBlur: function(value, ev)
                        {
                            var $t;
                            if (ev === void 0)
                            {
                                ev = null
                            }
                            
                            if (ev != null)
                            {
                                
                                this.caretPosition = System.Int64(ev.currentTarget.selectionStart)
                            }
                            
                            var newEv = {
                                    CaretPosition: this.caretPosition, Value: value
                                };
                            
                            !Bridge.staticEquals(($t = Bridge.cast(this.Component, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IInputComponentContainer).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnBlur), null) ? $t(newEv) : null
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.IReactInputModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IDataExtension], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "RootScope", t: 16, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, g: {
                                        ab: true, a: 2, n: "get_RootScope", t: 8, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope"
                                    }, s: {
                                        ab: true, a: 2, n: "set_RootScope", t: 8, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], rt: System.Void, fs: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope"
                            }, {
                                a: 1, backing: true, n: "<RootScope>k__BackingField", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactRenderer", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {Order: 2147483647})], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                            n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                        }], sn: "ctor"
                            }, {
                                v: true, a: 2, n: "BaseInitViewModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "BaseInitViewModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                v: true, a: 2, n: "CanRender", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "CanRender", rt: System.Boolean, p: [System.Type], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 3, n: "CreateComponent", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "inputModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel, ps: 1
                                        }], sn: "CreateComponent", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel]
                            }, {
                                v: true, a: 3, n: "CreateInputModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "CreateInputModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel, p: [System.Type]
                            }, {
                                a: 3, n: "GetInputsType", is: true, t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "GetInputsType", rt: System.Type, p: [System.Type]
                            }, {
                                a: 1, n: "GetInputsTypes", is: true, t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "GetInputsTypes", rt: System.Array.type(System.Type), p: [System.Type]
                            }, {
                                v: true, a: 2, n: "Render", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "Render", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                a: 1, n: "WrapComponents", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), g: {
                                        a: 1, n: "get_WrapComponents", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), fg: "WrapComponents"
                                    }, fn: "WrapComponents"
                            }, {
                                a: 1, n: "currentScope", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "currentScope", ro: true
                            }, {
                                a: 1, n: "wrapComponents", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent), sn: "wrapComponents"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {methods: {
                GetInputsType: function(typeComponent)
                {
                    
                    var typeInputs = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.GetInputsTypes(typeComponent);
                    
                    return typeInputs.length === 1 ? EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs : typeInputs[System.Array.index(0, typeInputs)]
                }, GetInputsTypes: function(typeComponent)
                    {
                        
                        return Bridge.Reflection.isGenericType(Bridge.Reflection.getBaseType(typeComponent)) ? Bridge.Reflection.getGenericArguments(Bridge.Reflection.getBaseType(typeComponent)) : EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.GetInputsTypes(Bridge.Reflection.getBaseType(typeComponent))
                    }
            }}, fields: {
            wrapComponents: null, currentScope: null
        }, props: {WrapComponents: {get: function()
                {
                    
                    return this.wrapComponents || ((this.wrapComponents = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent))))
                }}}, alias: ["Render", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render", "CanRender", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender"], ctors: {ctor: function(currentScope)
            {
                this.$initialize();
                
                this.currentScope = currentScope
            }}, methods: {
            Render: function(typeComponent, owner, inputs)
            {
                if (inputs === void 0)
                {
                    inputs = null
                }
                
                var model = this.BaseInitViewModel(typeComponent, owner, inputs);
                
                return this.CreateComponent(typeComponent, model)
            }, CanRender: function(typeComponent)
                {
                    
                    return Bridge.Reflection.isAssignableFrom(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent, typeComponent)
                }, CreateComponent: function(typeComponent, inputModel)
                {
                    var $t;
                    
                    var component = Bridge.cast(Bridge.createInstance(typeComponent, [inputModel]), EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent);
                    
                    $t = Bridge.getEnumerator(this.WrapComponents, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var wrapComponent = $t.Current;
                            
                            component = wrapComponent.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IWrapComponent$Wrap(component)
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    return component
                }, BaseInitViewModel: function(typeComponent, owner, inputs)
                {
                    var $t,
                        $t1;
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var inputModel = this.CreateInputModel(typeComponent);
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key = ($t = (inputs != null ? inputs.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputs$Key : null), $t != null ? $t : Bridge.Reflection.getTypeName(typeComponent));
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs = inputs;
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Owner = owner;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope = this.currentScope;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack = owner != null && ($t1 = owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$GetDynamicData()) != null ? $t1.EleWise_ELMA_Core$EleWise$ELMA$Model$IDataStack$clone() : null;
                    
                    return inputModel
                }, CreateInputModel: function(typeComponent)
                {
                    
                    var inputType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.GetInputsType(typeComponent);
                    
                    var genericType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel$1.apply(null, System.Array.init([inputType], System.Type));
                    
                    return Bridge.cast(Bridge.createInstance(genericType), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel)
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseCustomView$1", EleWise_ELMA_Core_React, function(TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ICustomView], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel], pi: [{
                                                    n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Dispatch", t: 8, pi: [{
                                                    n: "arg", pt: Function, ps: 0
                                                }], sn: "Dispatch", rt: System.Void, p: [Function]
                                    }, {
                                        a: 2, n: "DispatchAsync", t: 8, pi: [{
                                                    n: "arg", pt: Function, ps: 0
                                                }], sn: "DispatchAsync", rt: System.Threading.Tasks.Task, p: [Function]
                                    }, {
                                        a: 3, n: "GetSlotContent", t: 8, pi: [{
                                                    n: "uid", dv: null, o: true, pt: System.Guid, ps: 0
                                                }], sn: "GetSlotContent", rt: Object, p: [System.Guid]
                                    }, {
                                        ab: true, a: 2, n: "Render", t: 8, sn: "Render", rt: Object
                                    }, {
                                        a: 3, n: "Context", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, g: {
                                                a: 3, n: "get_Context", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, fg: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 3, n: "Controller", t: 16, rt: TController, g: {
                                                a: 3, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 1, n: "viewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, sn: "viewModel"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    viewModel: null, Context: null, Controller: Bridge.getDefaultValue(TController)
                }, ctors: {ctor: function(viewModel)
                    {
                        this.$initialize();
                        this.viewModel = viewModel;
                        this.Context = viewModel.Context;
                        this.Controller = viewModel.Controller
                    }}, methods: {
                    Dispatch: function(arg)
                    {
                        this.viewModel.ComponentDispatcher.Dispatch$2(arg);
                        
                        return
                    }, DispatchAsync: function(arg)
                        {
                            return this.viewModel.ComponentDispatcher.Dispatch$3(arg);
                            
                            return null
                        }, GetSlotContent: function(uid)
                        {
                            if (uid === void 0)
                            {
                                uid = new System.Guid
                            }
                            
                            return Bridge.cast(this.viewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IRootComponent).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IRootComponent$GetSlotContent(uid)
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseCustomView$2", EleWise_ELMA_Core_React, function(TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ICustomView], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel], pi: [{
                                                    n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        a: 3, n: "GetSlotContent", t: 8, pi: [{
                                                    n: "uid", dv: null, o: true, pt: System.Guid, ps: 0
                                                }], sn: "GetSlotContent", rt: Object, p: [System.Guid]
                                    }, {
                                        ab: true, a: 2, n: "Render", t: 8, sn: "Render", rt: Object
                                    }, {
                                        a: 3, n: "Context", t: 16, rt: TContext, g: {
                                                a: 3, n: "get_Context", t: 8, rt: TContext, fg: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 3, n: "Controller", t: 16, rt: TController, g: {
                                                a: 3, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 3, n: "Dispatch", t: 16, rt: Function, g: {
                                                a: 3, n: "get_Dispatch", t: 8, rt: Function, fg: "Dispatch"
                                            }, fn: "Dispatch"
                                    }, {
                                        a: 3, n: "DispatchAsync", t: 16, rt: Function, g: {
                                                a: 3, n: "get_DispatchAsync", t: 8, rt: Function, fg: "DispatchAsync"
                                            }, fn: "DispatchAsync"
                                    }, {
                                        a: 1, n: "viewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, sn: "viewModel"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }, {
                                        a: 1, backing: true, n: "<Dispatch>k__BackingField", t: 4, rt: Function, sn: "Dispatch"
                                    }, {
                                        a: 1, backing: true, n: "<DispatchAsync>k__BackingField", t: 4, rt: Function, sn: "DispatchAsync"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    viewModel: null, Dispatch: null, DispatchAsync: null, Context: Bridge.getDefaultValue(TContext), Controller: Bridge.getDefaultValue(TController)
                }, ctors: {ctor: function(viewModel)
                    {
                        this.$initialize()
                    }}, methods: {GetSlotContent: function(uid)
                    {
                        if (uid === void 0)
                        {
                            uid = new System.Guid
                        }
                        
                        return null
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseErrorInputs", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Message", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Message", t: 8, rt: Function, fg: "Message"
                                    }, s: {
                                        a: 2, n: "set_Message", t: 8, p: [Function], rt: System.Void, fs: "Message"
                                    }, fn: "Message"
                            }, {
                                a: 2, n: "StackShow", t: 16, rt: Function, g: {
                                        a: 2, n: "get_StackShow", t: 8, rt: Function, fg: "StackShow"
                                    }, s: {
                                        a: 2, n: "set_StackShow", t: 8, p: [Function], rt: System.Void, fs: "StackShow"
                                    }, fn: "StackShow"
                            }, {
                                a: 1, n: "__Property__Initializer__StackShow", t: 4, rt: Function, sn: "__Property__Initializer__StackShow"
                            }, {
                                a: 1, backing: true, n: "<Message>k__BackingField", t: 4, rt: Function, sn: "Message"
                            }, {
                                a: 1, backing: true, n: "<StackShow>k__BackingField", t: 4, rt: Function, sn: "StackShow"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            Message: null, StackShow: null
        }, alias: ["Message", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message", "StackShow", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow"], ctors: {init: function()
            {
                this.StackShow = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseErrorInputs.f1)
            }}
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseErrorInputs", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseErrorInputs, {f1: function()
    {
        return false
    }});
Bridge.define("EleWise.ELMA.Core.React.Models.IReactViewModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactService], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.ContextCreationParameters", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), System.Guid, System.Guid, System.Guid], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "innerStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 1
                                        }, {
                                            n: "outerStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 2
                                        }, {
                                            n: "metadata", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), ps: 3
                                        }, {
                                            n: "metadataUid", pt: System.Guid, ps: 4
                                        }, {
                                            n: "metadataTypeUid", pt: System.Guid, ps: 5
                                        }, {
                                            n: "metadataModuleUid", pt: System.Guid, ps: 6
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "InnerStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        a: 2, n: "get_InnerStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "InnerStack"
                                    }, fn: "InnerStack"
                            }, {
                                a: 2, n: "Metadata", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), g: {
                                        a: 2, n: "get_Metadata", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), fg: "Metadata"
                                    }, fn: "Metadata"
                            }, {
                                a: 2, n: "MetadataModuleUid", t: 16, rt: System.Guid, g: {
                                        a: 2, n: "get_MetadataModuleUid", t: 8, rt: System.Guid, fg: "MetadataModuleUid"
                                    }, fn: "MetadataModuleUid"
                            }, {
                                a: 2, n: "MetadataTypeUid", t: 16, rt: System.Guid, g: {
                                        a: 2, n: "get_MetadataTypeUid", t: 8, rt: System.Guid, fg: "MetadataTypeUid"
                                    }, fn: "MetadataTypeUid"
                            }, {
                                a: 2, n: "MetadataUid", t: 16, rt: System.Guid, g: {
                                        a: 2, n: "get_MetadataUid", t: 8, rt: System.Guid, fg: "MetadataUid"
                                    }, fn: "MetadataUid"
                            }, {
                                a: 2, n: "OuterStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        a: 2, n: "get_OuterStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "OuterStack"
                                    }, fn: "OuterStack"
                            }, {
                                a: 2, n: "ViewModel", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, g: {
                                        a: 2, n: "get_ViewModel", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, fg: "ViewModel"
                                    }, fn: "ViewModel"
                            }, {
                                a: 1, backing: true, n: "<InnerStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "InnerStack"
                            }, {
                                a: 1, backing: true, n: "<Metadata>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), sn: "Metadata"
                            }, {
                                a: 1, backing: true, n: "<MetadataModuleUid>k__BackingField", t: 4, rt: System.Guid, sn: "MetadataModuleUid"
                            }, {
                                a: 1, backing: true, n: "<MetadataTypeUid>k__BackingField", t: 4, rt: System.Guid, sn: "MetadataTypeUid"
                            }, {
                                a: 1, backing: true, n: "<MetadataUid>k__BackingField", t: 4, rt: System.Guid, sn: "MetadataUid"
                            }, {
                                a: 1, backing: true, n: "<OuterStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "OuterStack"
                            }, {
                                a: 1, backing: true, n: "<ViewModel>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "ViewModel"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            ViewModel: null, InnerStack: null, OuterStack: null, Metadata: null, MetadataUid: null, MetadataTypeUid: null, MetadataModuleUid: null
        }, alias: ["ViewModel", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$ViewModel", "InnerStack", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$InnerStack", "OuterStack", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$OuterStack", "Metadata", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$Metadata", "MetadataUid", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataUid", "MetadataTypeUid", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataTypeUid", "MetadataModuleUid", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationParameters$MetadataModuleUid"], ctors: {
            init: function()
            {
                this.MetadataUid = new System.Guid;
                this.MetadataTypeUid = new System.Guid;
                this.MetadataModuleUid = new System.Guid
            }, ctor: function(viewModel, innerStack, outerStack, metadata, metadataUid, metadataTypeUid, metadataModuleUid)
                {
                    this.$initialize();
                    
                    this.ViewModel = viewModel;
                    
                    this.InnerStack = innerStack;
                    
                    this.OuterStack = outerStack;
                    
                    this.Metadata = metadata;
                    
                    this.MetadataUid = metadataUid;
                    
                    this.MetadataTypeUid = metadataTypeUid;
                    
                    this.MetadataModuleUid = metadataModuleUid
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.IContextCreationWithModelParameters", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationParameters], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "AdditionalViewModelPropertyInfo", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), g: {
                                        ab: true, a: 2, n: "get_AdditionalViewModelPropertyInfo", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$AdditionalViewModelPropertyInfo"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$AdditionalViewModelPropertyInfo"
                            }, {
                                ab: true, a: 2, n: "Model", t: 16, rt: System.Object, g: {
                                        ab: true, a: 2, n: "get_Model", t: 8, rt: System.Object, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$Model"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$Model"
                            }, {
                                ab: true, a: 2, n: "ModelType", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, g: {
                                        ab: true, a: 2, n: "get_ModelType", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ModelType", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                            }
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ModelType"
                            }, {
                                ab: true, a: 2, n: "ViewModelMetadata", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), g: {
                                        ab: true, a: 2, n: "get_ViewModelMetadata", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ViewModelMetadata"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ViewModelMetadata"
                            }, {
                                a: 1, backing: true, n: "<AdditionalViewModelPropertyInfo>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$AdditionalViewModelPropertyInfo"
                            }, {
                                a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: System.Object, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$Model"
                            }, {
                                a: 1, backing: true, n: "<ModelType>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ModelType", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                    }
                            }, {
                                a: 1, backing: true, n: "<ViewModelMetadata>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ViewModelMetadata"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.HideEmptyModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel], $metadata: function()
        {
            return {
                    att: 1048704, a: 4, m: [{
                                a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel], pi: [{
                                            n: "owner", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                v: true, a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Void
                            }, {
                                ab: true, a: 3, n: "GetHiddenValue", t: 8, sn: "GetHiddenValue", rt: System.Boolean, box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                v: true, a: 2, n: "Init", t: 8, sn: "Init", rt: System.Void
                            }, {
                                a: 2, n: "IsEmpty", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_IsEmpty", t: 8, rt: System.Boolean, fg: "IsEmpty", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "IsEmpty"
                            }, {
                                a: 1, n: "currentHideEmpty", t: 4, rt: System.Boolean, sn: "currentHideEmpty", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "isHidden", t: 4, rt: Function, sn: "isHidden", ro: true
                            }, {
                                a: 1, n: "owner", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, sn: "owner", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            owner: null, isHidden: null, currentHideEmpty: false
        }, props: {IsEmpty: {get: function()
                {
                    
                    return this.currentHideEmpty
                }}}, alias: ["IsEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty", "Init", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Init", "Destroy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Destroy"], ctors: {ctor: function(owner)
            {
                this.$initialize();
                
                this.owner = owner;
                
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(this, {
                    name: "currentHideEmpty", serializedName: "currentHideEmpty"
                });
                
                this.isHidden = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.f1))
            }}, methods: {
            Init: function()
            {
                
                this.currentHideEmpty = this.GetHiddenValue();
                
                var getHiddenVal = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.f2));
                const reaction = mobx.reaction(getHiddenVal, isHidden => 
                        {
                            this.currentHideEmpty = isHidden
                        });
                
                if (this.owner != null)
                {
                    
                    this.owner.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$AddIsHidden(this.isHidden)
                }
            }, Destroy: function()
                {
                    
                    if (this.owner != null)
                    {
                        
                        this.owner.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$RemoveIsHidden(this.isHidden)
                    }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel, {
    f1: function()
    {
        return this.currentHideEmpty
    }, f2: function()
        {
            
            return this.GetHiddenValue()
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.HideEmptyViewItemContainerModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, Function], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, ps: 0
                                        }, {
                                            n: "getViewItemFunc", pt: Function, ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "AddHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "hideEmptyModel", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 1
                                        }], sn: "AddHideEmpty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel]
                            }, {
                                a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Void
                            }, {
                                a: 2, n: "FindHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "FindHideEmpty", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 2, n: "FindOwner", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "FindOwner", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 2, n: "IsHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "IsHideEmpty", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 2, n: "RemoveHideEmpty", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }], sn: "RemoveHideEmpty", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 1, n: "getViewItemFunc", t: 4, rt: Function, sn: "getViewItemFunc", ro: true
                            }, {
                                a: 1, n: "hideEmptyModels", t: 4, rt: System.Collections.Generic.IDictionary$2(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel), sn: "hideEmptyModels"
                            }, {
                                a: 1, n: "model", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, sn: "model", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            model: null, getViewItemFunc: null, hideEmptyModels: null
        }, alias: ["AddHideEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$AddHideEmpty", "RemoveHideEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$RemoveHideEmpty", "FindOwner", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindOwner", "Destroy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$Destroy", "IsHideEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$IsHideEmpty", "FindHideEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindHideEmpty"], ctors: {ctor: function(viewModel, getViewItemFunc)
            {
                this.$initialize();
                
                this.hideEmptyModels = new(System.Collections.Generic.Dictionary$2(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel)).ctor;
                
                this.model = viewModel;
                
                this.getViewItemFunc = getViewItemFunc
            }}, methods: {
            AddHideEmpty: function(viewItem, hideEmptyModel)
            {
                
                if (this.hideEmptyModels != null)
                {
                    
                    this.hideEmptyModels.System$Collections$Generic$IDictionary$2$EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$add(viewItem, hideEmptyModel)
                }
            }, RemoveHideEmpty: function(viewItem)
                {
                    
                    if (this.hideEmptyModels != null)
                    {
                        
                        this.hideEmptyModels.System$Collections$Generic$IDictionary$2$EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$remove(viewItem)
                    }
                }, FindOwner: function(viewItem)
                {
                    
                    var item;
                    
                    if (((item = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem))) != null && item.Parent != null)
                    {
                        
                        var model = {};
                        
                        if (this.hideEmptyModels != null && this.hideEmptyModels.System$Collections$Generic$IDictionary$2$EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$tryGetValue(item.Parent, model))
                        {
                            
                            return model.v
                        }
                    }
                    else
                    {
                        
                        var hideEmptyViewItemContainer;
                        
                        if (((hideEmptyViewItemContainer = Bridge.as(this.model.RenderOwner, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainer))) != null)
                        {
                            
                            var currentViewItem = this.getViewItemFunc();
                            
                            return hideEmptyViewItemContainer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindHideEmpty(currentViewItem)
                        }
                    }
                    
                    return null
                }, Destroy: function()
                {
                    
                    this.hideEmptyModels = null
                }, IsHideEmpty: function(viewItem)
                {
                    
                    var hideEmptyViewItem;
                    
                    if (((hideEmptyViewItem = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IHideEmptyViewItem))) != null)
                    {
                        
                        if (hideEmptyViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IHideEmptyViewItem$HideEmpty === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.HideEmptyEnum.HideEmpty)
                        {
                            
                            return true
                        }
                        else
                        {
                            
                            var item;
                            
                            if (hideEmptyViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IHideEmptyViewItem$HideEmpty === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.HideEmptyEnum.Inherit && ((item = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem))) != null)
                            {
                                
                                if (item.Parent != null)
                                {
                                    
                                    return this.IsHideEmpty(item.Parent)
                                }
                                else
                                {
                                    
                                    var hideEmptyViewItemContainer;
                                    
                                    if (((hideEmptyViewItemContainer = Bridge.as(this.model.RenderOwner, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainer))) != null)
                                    {
                                        
                                        var owner = hideEmptyViewItemContainer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer;
                                        
                                        var parent = this.getViewItemFunc();
                                        
                                        if (parent != null)
                                        {
                                            
                                            return owner.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$IsHideEmpty(parent)
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    return false
                }, FindHideEmpty: function(viewItem)
                {
                    
                    var model = {};
                    
                    if (this.hideEmptyModels.System$Collections$Generic$IDictionary$2$EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$tryGetValue(viewItem, model))
                    {
                        
                        return model.v
                    }
                    
                    return this.FindOwner(viewItem)
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.InputComponentContainer", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ComponentContainer, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IInputComponentContainer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "OnBlur", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnBlur", t: 8, rt: Function, fg: "OnBlur"
                                    }, fn: "OnBlur"
                            }, {
                                a: 2, n: "OnFocus", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnFocus", t: 8, rt: Function, fg: "OnFocus"
                                    }, fn: "OnFocus"
                            }, {
                                a: 2, n: "OnKeyPress", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnKeyPress", t: 8, rt: Function, fg: "OnKeyPress"
                                    }, fn: "OnKeyPress"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", props: {
            OnKeyPress: {get: function()
                {
                    
                    return Bridge.cast(this.ViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel).OnKeyPress
                }}, OnFocus: {get: function()
                    {
                        
                        return Bridge.cast(this.ViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel).OnFocus
                    }}, OnBlur: {get: function()
                    {
                        
                        return Bridge.cast(this.ViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel).OnBlur
                    }}
        }, alias: ["OnKeyPress", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnKeyPress", "OnFocus", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnFocus", "OnBlur", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IInputComponentContainer$OnBlur"], ctors: {ctor: function(viewModel)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ComponentContainer.ctor.call(this, viewModel)
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Models.ShowEmptyModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel], pi: [{
                                            n: "owner", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Void
                            }, {
                                a: 2, n: "Init", t: 8, sn: "Init", rt: System.Void
                            }, {
                                a: 2, n: "IsEmpty", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_IsEmpty", t: 8, rt: System.Boolean, fg: "IsEmpty", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "IsEmpty"
                            }, {
                                a: 1, n: "isHidden", t: 4, rt: Function, sn: "isHidden", ro: true
                            }, {
                                a: 1, n: "owner", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, sn: "owner", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            owner: null, isHidden: null
        }, props: {IsEmpty: {get: function()
                {
                    
                    return false
                }}}, alias: ["IsEmpty", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty", "Init", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Init", "Destroy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Destroy"], ctors: {ctor: function(owner)
            {
                this.$initialize();
                
                this.isHidden = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ShowEmptyModel.f1);
                
                this.owner = owner
            }}, methods: {
            Init: function()
            {
                
                if (this.owner != null)
                {
                    
                    this.owner.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$AddIsHidden(this.isHidden)
                }
            }, Destroy: function()
                {
                    
                    if (this.owner != null)
                    {
                        
                        this.owner.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$RemoveIsHidden(this.isHidden)
                    }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ShowEmptyModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ShowEmptyModel, {f1: function()
    {
        return false
    }});
Bridge.define("EleWise.ELMA.Core.React.Models.ValidationModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IViewModelValidationModel], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "AddValidator", t: 8, pi: [{
                                            n: "validateFunc", pt: Function, ps: 0
                                        }, {
                                            n: "name", dv: "", o: true, pt: System.String, ps: 1
                                        }], sn: "AddValidator", rt: System.Void, p: [Function, System.String]
                            }, {
                                a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Void
                            }, {
                                a: 2, n: "GetSummaryResult", t: 8, sn: "GetSummaryResult", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult
                            }, {
                                a: 2, n: "RemoveValidator", t: 8, pi: [{
                                            n: "validateFunc", pt: Function, ps: 0
                                        }], sn: "RemoveValidator", rt: System.Void, p: [Function]
                            }, {
                                a: 2, n: "Errors", t: 16, rt: System.Collections.Generic.IReadOnlyCollection$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ModelError), g: {
                                        a: 2, n: "get_Errors", t: 8, rt: System.Collections.Generic.IReadOnlyCollection$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ModelError), fg: "Errors"
                                    }, fn: "Errors"
                            }, {
                                a: 2, n: "IsValid", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_IsValid", t: 8, rt: System.Boolean, fg: "IsValid", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "IsValid"
                            }, {
                                a: 1, n: "isValid", t: 4, rt: System.Boolean, sn: "isValid", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "list", t: 4, rt: Reactive.EleWise.ELMA.Collections.IReactiveDictionary$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult), sn: "list"
                            }, {
                                a: 1, n: "viewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "viewModel", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            viewModel: null, isValid: false, list: null
        }, props: {
            IsValid: {get: function()
                {
                    
                    var inAction = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReactiveHelper.InAction();
                    
                    if (inAction)
                    {
                        
                        for (var i = 0; i < System.Array.getCount(this.list, System.Collections.Generic.KeyValuePair$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult)); i = (i + 1) | 0)
                        {
                            
                            var vl = System.Linq.Enumerable.from(this.list, System.Collections.Generic.KeyValuePair$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult)).elementAt(i).key;
                            
                            var value = {};
                            
                            if (this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$tryGetValue(vl, value))
                            {
                                
                                this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$setItem(vl, vl())
                            }
                        }
                        
                        this.isValid = System.Linq.Enumerable.from(this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$Values, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult).all(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f1));
                        
                        return this.isValid
                    }
                    
                    return this.isValid
                }}, Errors: {get: function()
                    {
                        
                        var errors = System.Linq.Enumerable.from(this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$Values, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult).where(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f2)).ToArray(EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult);
                        
                        if (errors.length === 0)
                        {
                            
                            return System.Array.init([], EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ModelError)
                        }
                        
                        return System.Linq.Enumerable.from(errors, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult).where(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f3)).select(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f4)).concat(System.Linq.Enumerable.from(errors, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult).selectMany(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f5))).ToArray(EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ModelError)
                    }}
        }, alias: ["IsValid", "EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$IValidationModel$IsValid", "Errors", "EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$IValidationModel$Errors", "GetSummaryResult", "EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$IValidationModel$GetSummaryResult", "AddValidator", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$AddValidator", "RemoveValidator", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$RemoveValidator", "Destroy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$Destroy"], ctors: {ctor: function(viewModel)
            {
                this.$initialize();
                
                this.viewModel = viewModel;
                
                this.list = new(Reactive.EleWise.ELMA.Collections.ReactiveDictionary$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult));
                
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(this, {
                    name: "isValid", serializedName: "isValid"
                });
                
                var getErrorValidation = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f6));
                
                var setErrorValidation = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f7));
                const reaction = mobx.reaction(getErrorValidation, setErrorValidation);
                if (!this.reactions)
                {
                    this.reactions = []
                }
                this.reactions["isValidReaction"] = reaction
            }}, methods: {
            GetSummaryResult: function()
            {
                var $t;
                
                if (this.IsValid)
                {
                    
                    return EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult.Ok()
                }
                
                var errors = this.Errors;
                
                if (System.Array.getCount(errors, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ModelError) === 0)
                {
                    
                    return EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult.InProgress()
                }
                
                if (System.Array.getCount(this.list, System.Collections.Generic.KeyValuePair$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult)) === 0)
                {
                    
                    return EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult.Ok()
                }
                
                return ($t = new EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult, $t.IsValid = EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValueResult.Error, $t.InnerErrors = errors, $t)
            }, AddValidator: function(validateFunc, name)
                {
                    if (name === void 0)
                    {
                        name = ""
                    }
                    
                    var res = EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult.InProgress();
                    
                    this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$add(validateFunc, res);
                    
                    var setVal = Bridge.fn.bind(this, function(newResult)
                        {
                            
                            var oldResult = {};
                            
                            if (this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$tryGetValue(validateFunc, oldResult) && !newResult.equals(oldResult.v))
                            {
                                
                                this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$setItem(validateFunc, newResult)
                            }
                        });
                    const reaction = mobx.reaction(validateFunc, setVal, {name: name});
                    if (!this.reactions)
                    {
                        this.reactions = []
                    }
                    this.reactions[validateFunc.$$hashCode] = reaction
                }, RemoveValidator: function(validateFunc)
                {
                    
                    var value = {};
                    
                    if (this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$tryGetValue(validateFunc, value))
                    {
                        
                        this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$remove(validateFunc);
                        var reaction = this.reactions[validateFunc.$$hashCode];
                        if (reaction)
                        {
                            reaction()
                        }
                    }
                }, Destroy: function()
                {
                    
                    System.Array.clear(this.list, System.Collections.Generic.KeyValuePair$2(Function, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult));
                    for (var i in this.reactions)
                    {
                        this.reactions[i]()
                    }
                    this.reactions = null
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel, {
    f1: function(v)
    {
        return v.IsValid !== EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValueResult.Error
    }, f2: function(v)
        {
            return v.IsValid === EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValueResult.Error
        }, f3: function(e)
        {
            return e.ErrorMessage != null
        }, f4: function(r)
        {
            return r.ErrorMessage
        }, f5: function(e)
        {
            return e.InnerErrors
        }, f6: function()
        {
            
            return System.Linq.Enumerable.from(this.list.System$Collections$Generic$IDictionary$2$Function$EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$ValidationResult$Values, EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult).all(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel.f1))
        }, f7: function(result)
        {
            
            this.isValid = result
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemComponentContainer", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ComponentContainer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ov: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                ov: true, a: 2, n: "ReadOnly", t: 16, rt: System.Boolean, g: {
                                        ov: true, a: 2, n: "get_ReadOnly", t: 8, rt: System.Boolean, fg: "ReadOnly", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "ReadOnly"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", props: {
            ReadOnly: {get: function()
                {
                    
                    var viewItemViewModel = Bridge.as(this.ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel);
                    
                    if (viewItemViewModel == null)
                    {
                        
                        return Bridge.ensureBaseProperty(this, "ReadOnly").$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$ComponentContainer$ReadOnly
                    }
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(viewItemViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner);
                    
                    try
                    {
                        
                        var viewItem = Bridge.as(viewItemViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem);
                        
                        var ownReadOnly = viewItem != null ? EleWise_ELMA_Core.EleWise.ELMA.Model.Views.Extensions.ViewItemExtensions.IsReadOnly(viewItem) : null;
                        
                        return System.Nullable.hasValue(ownReadOnly) ? System.Nullable.getValue(ownReadOnly) : Bridge.ensureBaseProperty(this, "ReadOnly").$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$ComponentContainer$ReadOnly
                    }
                    finally
                    {
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(viewItemViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner)
                    }
                }}, Name: {get: function()
                    {
                        
                        var viewItemViewModel;
                        
                        if (((viewItemViewModel = Bridge.as(this.ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel))) != null)
                        {
                            
                            return viewItemViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Name
                        }
                        
                        return Bridge.ensureBaseProperty(this, "Name").$EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$ComponentContainer$Name
                    }}
        }, alias: ["ReadOnly", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$ReadOnly", "Name", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name"], ctors: {ctor: function(viewModel)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ComponentContainer.ctor.call(this, viewModel)
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Models.WrapperInputs", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "WrapModel", t: 16, rt: Function, g: {
                                        a: 2, n: "get_WrapModel", t: 8, rt: Function, fg: "WrapModel"
                                    }, s: {
                                        a: 2, n: "set_WrapModel", t: 8, p: [Function], rt: System.Void, fs: "WrapModel"
                                    }, fn: "WrapModel"
                            }, {
                                a: 1, backing: true, n: "<WrapModel>k__BackingField", t: 4, rt: Function, sn: "WrapModel"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {WrapModel: null}
});
Bridge.define("EleWise.ELMA.Core.React.Services.ReactComponentCreatorService", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer)], pi: [{
                                            n: "renderers", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer), ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Create", t: 8, pi: [{
                                            n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], tpc: 1, tprm: ["T"], sn: "Create$1", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "Create", t: 8, pi: [{
                                            n: "typeVic", pt: System.Type, ps: 0
                                        }, {
                                            n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 1
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }], sn: "Create", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "Error", t: 8, pi: [{
                                            n: "inputs", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "Error", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 1, n: "renderers", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer), sn: "renderers", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {renderers: null}, alias: ["Create", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create", "Create$1", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create$1", "Error", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Error"], ctors: {ctor: function(renderers)
            {
                this.$initialize();
                
                this.renderers = renderers
            }}, methods: {
            Create: function(typeVic, inputs, owner)
            {
                
                var renderer = System.Linq.Enumerable.from(this.renderers, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer).firstOrDefault(function(r)
                    {
                        return r.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender(typeVic)
                    }, null);
                
                if (renderer != null)
                {
                    
                    return renderer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render(typeVic, owner, inputs)
                }
                
                throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0440\u0435\u043d\u0434\u0435\u0440\u0435\u0440 \u0434\u043b\u044f \u043a\u043e\u043c\u043f\u043e\u043d\u0435\u043d\u0442\u0430 {0}", Bridge.Reflection.getTypeName(typeVic)));
            }, Create$1: function(T, inputs, owner)
                {
                    
                    return this.Create(T, inputs, owner)
                }, Error: function(inputs, owner)
                {
                    
                    var renderer = System.Linq.Enumerable.from(this.renderers, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IReactRenderer).firstOrDefault(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ReactComponentCreatorService.f1), null);
                    
                    if (renderer != null)
                    {
                        
                        return renderer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IErrorComponent, owner, inputs)
                    }
                    
                    throw new System.Exception(SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d \u0440\u0435\u043d\u0434\u0435\u0440\u0435\u0440 \u0434\u043b\u044f \u043a\u043e\u043c\u043f\u043e\u043d\u0435\u043d\u0442\u0430 \u043e\u0442\u043e\u0431\u0440\u0430\u0436\u0435\u043d\u0438\u044f \u043e\u0448\u0438\u0431\u043a\u0438"));
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ReactComponentCreatorService", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ReactComponentCreatorService, {f1: function(r)
    {
        return Bridge.referenceEquals(Bridge.getType(r), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ErrorRenderer)
    }});
Bridge.define("EleWise.ELMA.Core.React.Services.ViewModelCreatorService", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                            n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "ControllerCreator", t: 8, pi: [{
                                            n: "controllerType", pt: System.Type, ps: 0
                                        }, {
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 1
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }, {
                                            n: "viewItem", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 3
                                        }], sn: "ControllerCreator", rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem]
                            }, {
                                a: 2, n: "CreateModel", t: 8, tpc: 1, tprm: ["T"], sn: "CreateModel", rt: System.Object
                            }, {
                                a: 2, n: "CreateModel", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }], sn: "CreateModel$1", rt: System.Object, p: [System.Type]
                            }, {
                                a: 1, n: "CreateProxyServerController", t: 8, pi: [{
                                            n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 0
                                        }, {
                                            n: "namespace", pt: System.Type, ps: 1
                                        }, {
                                            n: "moduleName", pt: System.String, ps: 2
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 3
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 4
                                        }, {
                                            n: "serverControllerFullName", out: true, pt: System.String, ps: 5
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam), ps: 6
                                        }], sn: "CreateProxyServerController", rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IServerController, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, System.Type, System.String, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.String, System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam)]
                            }, {
                                a: 2, n: "ExecuteEql", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "defaultOnLoadScriptName", pt: System.String, ps: 1
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 2
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 3
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel), ps: 4
                                        }], sn: "ExecuteEql", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel)]
                            }, {
                                a: 2, n: "ExecuteOnInit", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "ExecuteOnInit", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "ExecuteOnLoad", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "ExecuteOnLoad", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "ExecuteOnLoadAsync", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }], sn: "ExecuteOnLoadAsync", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "ExecuteServerOnLoad", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "controllerFullName", pt: System.String, ps: 1
                                        }, {
                                            n: "onLoadScriptName", pt: System.String, ps: 2
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 3
                                        }], sn: "ExecuteServerOnLoad", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 2, n: "GetServerControllerFullName", t: 8, pi: [{
                                            n: "serverControllerInterfaceType", pt: System.Type, ps: 0
                                        }, {
                                            n: "assemblyName", pt: System.String, ps: 1
                                        }], sn: "GetServerControllerFullName", rt: System.String, p: [System.Type, System.String]
                            }, {
                                a: 2, n: "GetServerControllerType", t: 8, pi: [{
                                            n: "namespace", pt: System.Type, ps: 0
                                        }], sn: "GetServerControllerType", rt: System.Type, p: [System.Type]
                            }, {
                                a: 2, n: "InitClientController", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "controllerFullName", pt: System.String, ps: 1
                                        }, {
                                            n: "onLoadScriptName", pt: System.String, ps: 2
                                        }, {
                                            n: "dataStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 3
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 4
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 5
                                        }, {
                                            n: "defaultOnLoadScriptName", pt: System.String, ps: 6
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel), ps: 7
                                        }], sn: "InitClientController", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.String, System.String, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.String, System.Array.type(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel)]
                            }, {
                                a: 2, n: "InitServerControllerProxy", t: 8, pi: [{
                                            n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 0
                                        }, {
                                            n: "namespace", pt: System.Type, ps: 1
                                        }, {
                                            n: "assemblyName", pt: System.String, ps: 2
                                        }, {
                                            n: "modelInfo", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), ps: 3
                                        }, {
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 4
                                        }, {
                                            n: "additionalModels", ip: true, pt: System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam), ps: 5
                                        }], sn: "InitServerControllerProxy", rt: System.String, p: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, System.Type, System.String, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("47042eb7-276a-4066-ba1b-4fa7e96284c2"), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, System.Array.type(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam)]
                            }, {
                                a: 1, n: "Lambda", is: true, t: 8, pi: [{
                                            n: "x", pt: Function, ps: 0
                                        }], tpc: 1, def: function(T, x)
                                    {
                                        return x
                                    }, rt: Function, p: [Function]
                            }, {
                                a: 1, n: "ControllerFactory", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IControllerFactory, g: {
                                        a: 1, n: "get_ControllerFactory", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IControllerFactory, fg: "ControllerFactory"
                                    }, fn: "ControllerFactory"
                            }, {
                                a: 1, n: "ProxyGeneratorService", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService, g: {
                                        a: 1, n: "get_ProxyGeneratorService", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService, fg: "ProxyGeneratorService"
                                    }, fn: "ProxyGeneratorService"
                            }, {
                                a: 1, n: "ReactiveModelFactory", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory, g: {
                                        a: 1, n: "get_ReactiveModelFactory", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory, fg: "ReactiveModelFactory"
                                    }, fn: "ReactiveModelFactory"
                            }, {
                                a: 1, n: "ScriptService", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptService, g: {
                                        a: 1, n: "get_ScriptService", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptService, fg: "ScriptService"
                                    }, fn: "ScriptService"
                            }, {
                                a: 1, n: "ServerKey", is: true, t: 4, rt: System.String, sn: "ServerKey"
                            }, {
                                a: 1, n: "controllerFactory", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IControllerFactory, sn: "controllerFactory"
                            }, {
                                a: 1, n: "currentScope", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "currentScope", ro: true
                            }, {
                                a: 1, n: "proxyGeneratorService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService, sn: "proxyGeneratorService"
                            }, {
                                a: 1, n: "reactiveModelFactory", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory, sn: "reactiveModelFactory"
                            }, {
                                a: 1, n: "scriptService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptService, sn: "scriptService"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
            fields: {ServerKey: null}, ctors: {init: function()
                    {
                        this.ServerKey = "IServer"
                    }}
        }, fields: {
            currentScope: null, scriptService: null, reactiveModelFactory: null, controllerFactory: null, proxyGeneratorService: null
        }, props: {
            ScriptService: {get: function()
                {
                    
                    return this.scriptService || ((this.scriptService = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptService)))
                }}, ReactiveModelFactory: {get: function()
                    {
                        
                        return this.reactiveModelFactory || ((this.reactiveModelFactory = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.Services.IReactiveModelFactory)))
                    }}, ControllerFactory: {get: function()
                    {
                        
                        return this.controllerFactory || ((this.controllerFactory = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.Services.IControllerFactory)))
                    }}, ProxyGeneratorService: {get: function()
                    {
                        
                        return this.proxyGeneratorService || ((this.proxyGeneratorService = this.currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.DTO.IProxyGeneratorService)))
                    }}
        }, alias: ["ControllerCreator", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ControllerCreator", "CreateModel", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$CreateModel", "CreateModel$1", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$CreateModel$1", "InitServerControllerProxy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$InitServerControllerProxy", "InitClientController", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$InitClientController", "ExecuteOnInit", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnInit", "ExecuteServerOnLoad", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteServerOnLoad", "ExecuteEql", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteEql", "ExecuteOnLoad", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnLoad", "ExecuteOnLoadAsync", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ExecuteOnLoadAsync", "GetServerControllerType", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$GetServerControllerType", "GetServerControllerFullName", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$GetServerControllerFullName"], ctors: {ctor: function(currentScope)
            {
                this.$initialize();
                
                this.currentScope = currentScope
            }}, methods: {
            ControllerCreator: function(controllerType, context, viewModel, viewItem)
            {
                var $t;
                if (viewItem === void 0)
                {
                    viewItem = null
                }
                
                var controller;
                
                $t = new EleWise_ELMA_Core.EleWise.ELMA.DTO.ProxyGeneratorServiceContext(this.proxyGeneratorService);
                try
                {
                    
                    controller = Bridge.cast(this.ControllerFactory.EleWise_ELMA_Core$EleWise$ELMA$Services$IControllerFactory$CreateController(controllerType), EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)
                }
                finally
                {
                    if (Bridge.hasValue($t))
                    {
                        $t.System$IDisposable$Dispose()
                    }
                }
                
                EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.SetAndCreatePlainPropertyValue(controller, "Context", context);
                
                EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.SetAndCreatePlainPropertyValue(controller, "Component", viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component);
                
                EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.SetAndCreatePlainPropertyValue(controller, EleWise_ELMA_Core.EleWise.ELMA.DTO.dtoConstants.proxyGenerator, this.ProxyGeneratorService);
                
                var viewItemController;
                
                if (((viewItemController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IRequireViewItemController))) != null)
                {
                    
                    viewItemController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IRequireViewItemController$SetViewItem(viewItem)
                }
                
                var ownerController;
                
                if (((ownerController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IRequireOwnerController))) != null)
                {
                    
                    ownerController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IRequireOwnerController$SetOwner(viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner)
                }
                
                return controller
            }, CreateModel: function(T)
                {
                    
                    return Bridge.cast(Bridge.unbox(this.CreateModel$1(T), T), T)
                }, CreateModel$1: function(type)
                {
                    
                    var model = Bridge.cast(this.ReactiveModelFactory.EleWise_ELMA_Core$EleWise$ELMA$Services$IReactiveModelFactory$CreateModel$1(type), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel);
                    
                    model[EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ScopedComponentConstants.CurrentScope] = this.currentScope;
                    
                    return model
                }, InitServerControllerProxy: function(controller, $namespace, assemblyName, modelInfo, viewModel, additionalModels)
                {
                    if (additionalModels === void 0)
                    {
                        additionalModels = []
                    }
                    
                    var controllerFullName = {v: ""};
                    
                    var clientController;
                    
                    if (((clientController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IClientController))) != null)
                    {
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.SetAndCreatePlainPropertyValue(clientController, "Server", this.CreateProxyServerController(clientController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IController$Context, $namespace, assemblyName, modelInfo, viewModel, controllerFullName, additionalModels))
                    }
                    
                    return controllerFullName.v
                }, InitClientController: function(controller, controllerFullName, onLoadScriptName, dataStack, modelInfo, viewModel, defaultOnLoadScriptName, additionalModels)
                {
                    var $step = 0,
                        $task1,
                        $task2,
                        $task3,
                        $jumpFromFinally,
                        $tcs = new System.Threading.Tasks.TaskCompletionSource,
                        $returnValue,
                        $async_e,
                        $asyncBody = Bridge.fn.bind(this, function()
                        {
                            try
                            {
                                for (; ; )
                                {
                                    $step = System.Array.min([0, 1, 2, 3, 4, 5, 7, 8], $step);
                                    switch ($step)
                                    {
                                        case 0:
                                            {
                                                if (additionalModels === void 0)
                                                {
                                                    additionalModels = []
                                                }
                                                
                                                this.ExecuteOnInit(controller, viewModel);
                                                
                                                if (!System.String.isNullOrEmpty(controllerFullName) && !System.String.isNullOrEmpty(onLoadScriptName))
                                                {
                                                    $step = 1;
                                                    continue
                                                }
                                                else
                                                {
                                                    $step = 3;
                                                    continue
                                                }
                                            }
                                        case 1:
                                            {
                                                
                                                $task1 = this.ExecuteServerOnLoad(controller, controllerFullName, onLoadScriptName, viewModel);
                                                $step = 2;
                                                if ($task1.isCompleted())
                                                    continue;
                                                $task1.continue($asyncBody);
                                                return
                                            }
                                        case 2:
                                            {
                                                $task1.getAwaitedResult();
                                                $step = 7;
                                                continue
                                            }
                                        case 3:
                                            {
                                                
                                                if (defaultOnLoadScriptName != null)
                                                {
                                                    $step = 4;
                                                    continue
                                                }
                                                $step = 6;
                                                continue
                                            }
                                        case 4:
                                            {
                                                
                                                $task2 = this.ExecuteEql(controller, defaultOnLoadScriptName, viewModel, modelInfo, additionalModels);
                                                $step = 5;
                                                if ($task2.isCompleted())
                                                    continue;
                                                $task2.continue($asyncBody);
                                                return
                                            }
                                        case 5:
                                            {
                                                $task2.getAwaitedResult();
                                                $step = 6;
                                                continue
                                            }
                                        case 7:
                                            {
                                                
                                                this.ExecuteOnLoad(controller, viewModel);
                                                
                                                $task3 = this.ExecuteOnLoadAsync(controller, viewModel);
                                                $step = 8;
                                                if ($task3.isCompleted())
                                                    continue;
                                                $task3.continue($asyncBody);
                                                return
                                            }
                                        case 8:
                                            {
                                                $task3.getAwaitedResult();
                                                $tcs.setResult(null);
                                                return
                                            }
                                        default:
                                            {
                                                $tcs.setResult(null);
                                                return
                                            }
                                    }
                                }
                            }
                            catch($async_e1)
                            {
                                $async_e = System.Exception.create($async_e1);
                                $tcs.setException($async_e)
                            }
                        }, arguments);
                    if (mobx._getGlobalState().allowStateChanges)
                    {
                        $asyncBody = mobx.action($asyncBody)
                    }
                    $asyncBody();
                    return $tcs.task
                }, ExecuteOnInit: function(controller, viewModel)
                {
                    
                    var onInitController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit);
                    
                    if (onInitController == null)
                    {
                        
                        return
                    }
                    
                    viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$Dispatch$1(function()
                    {
                        
                        onInitController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnInit$OnInit()
                    })
                }, ExecuteServerOnLoad: function(controller, controllerFullName, onLoadScriptName, viewModel)
                {
                    
                    var clientController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IClientController);
                    
                    if (clientController == null)
                    {
                        
                        return System.Threading.Tasks.Task.CompletedTask
                    }
                    
                    if (System.String.isNullOrEmpty(controllerFullName) || System.String.isNullOrEmpty(onLoadScriptName))
                    {
                        
                        return System.Threading.Tasks.Task.CompletedTask
                    }
                    
                    var braceIndex = System.String.indexOf(onLoadScriptName, "(", 0, null, 4);
                    
                    if (braceIndex !== -1)
                    {
                        
                        onLoadScriptName = onLoadScriptName.substr(0, braceIndex)
                    }
                    
                    var onLoadMethodName = System.String.format("{0}${1}", controllerFullName, onLoadScriptName);
                    
                    var onLoad = EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.GetPlainPropertyValue$1(Function, clientController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IClientController$Server, onLoadMethodName);
                    
                    if (!Bridge.staticEquals(onLoad, null))
                    {
                        
                        return onLoad(viewModel)
                    }
                    
                    var formViewModel;
                    
                    if (((formViewModel = Bridge.as(viewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IFormViewModel))) != null)
                    {
                        
                        var modelInfo = formViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$ModelMetadata.ModelInfo;
                        
                        return this.ScriptService.EleWise_ELMA_Core$EleWise$ELMA$Scripts$IScriptService$ExecuteScript(new EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.ScriptExecutionParams.$ctor1(clientController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IController$Context, modelInfo, viewModel, onLoadScriptName))
                    }
                    
                    return System.Threading.Tasks.Task.CompletedTask
                }, ExecuteEql: function(controller, defaultOnLoadScriptName, viewModel, modelInfo, additionalModels)
                {
                    if (additionalModels === void 0)
                    {
                        additionalModels = []
                    }
                    
                    var clientController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IClientController);
                    
                    if (clientController == null || defaultOnLoadScriptName == null)
                    {
                        
                        return System.Threading.Tasks.Task.CompletedTask
                    }
                    
                    return this.ScriptService.EleWise_ELMA_Core$EleWise$ELMA$Scripts$IScriptService$ExecuteScript(new EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.ScriptExecutionParams.$ctor1(clientController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IController$Context, modelInfo, viewModel, defaultOnLoadScriptName, additionalModels))
                }, ExecuteOnLoad: function(controller, viewModel)
                {
                    
                    var onLoadController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad);
                    
                    if (onLoadController == null)
                    {
                        
                        return
                    }
                    
                    viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$Dispatch$1(function()
                    {
                        
                        onLoadController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnLoad$OnLoad()
                    })
                }, ExecuteOnLoadAsync: function(controller, viewModel)
                {
                    
                    var onLoadAsyncController = Bridge.as(controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync);
                    
                    if (onLoadAsyncController == null)
                    {
                        
                        return System.Threading.Tasks.Task.CompletedTask
                    }
                    
                    return viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$Dispatch(function()
                        {
                            return onLoadAsyncController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnLoadAsync$OnLoadAsync()
                        })
                }, GetServerControllerType: function($namespace)
                {
                    
                    var serverControllerInterfaceType = $namespace[EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ViewModelCreatorService.ServerKey];
                    
                    if (serverControllerInterfaceType == null)
                    {
                        
                        return null
                    }
                    
                    return serverControllerInterfaceType
                }, GetServerControllerFullName: function(serverControllerInterfaceType, assemblyName)
                {
                    
                    var modulePrefix = System.String.replaceAll(assemblyName, String.fromCharCode(46), String.fromCharCode(95));
                    
                    return System.String.format("{0}${1}", modulePrefix, System.String.replaceAll(System.String.replaceAll(Bridge.Reflection.getTypeFullName(serverControllerInterfaceType), String.fromCharCode(46), String.fromCharCode(36)), String.fromCharCode(43), String.fromCharCode(36)))
                }, CreateProxyServerController: function(context, $namespace, moduleName, modelInfo, viewModel, serverControllerFullName, additionalModels)
                {
                    var $t;
                    if (additionalModels === void 0)
                    {
                        additionalModels = []
                    }
                    
                    serverControllerFullName.v = "";
                    
                    var serverControllerInterfaceType = this.GetServerControllerType($namespace);
                    
                    serverControllerFullName.v = this.GetServerControllerFullName(serverControllerInterfaceType, moduleName);
                    
                    var serverController = new EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.ServerComponentControllerProxy(serverControllerInterfaceType);
                    
                    var methods = Bridge.Reflection.getMembers(serverControllerInterfaceType, 8, 28);
                    
                    if (methods.length === 0)
                    {
                        
                        return serverController
                    }
                    
                    var updateModel = true;
                    
                    var model = null;
                    
                    var item = null;
                    
                    var metadataViewModel;
                    
                    if (((metadataViewModel = Bridge.as(viewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null)
                    {
                        
                        var modelMetadata = metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$ModelMetadata;
                        
                        if (Bridge.is(modelMetadata.Metadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("8a5c0ba8-9b97-440a-9c07-07eac9f61aa2")))
                        {
                            
                            var root = EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.ModelMetadata.prototype.Root.call(modelMetadata);
                            
                            if (root != null)
                            {
                                
                                model = Bridge.as(root.Model, EleWise_ELMA_Core.EleWise.ELMA.DTO.ReactiveProxy);
                                
                                item = Bridge.unbox(modelMetadata.GetModelFunc());
                                
                                updateModel = false
                            }
                        }
                    }
                    
                    if (model == null)
                    {
                        
                        model = context
                    }
                    
                    $t = Bridge.getEnumerator(methods);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var method = {v: $t.Current};
                            
                            var methodName = {v: method.v.n};
                            
                            if (!EleWise_ELMA_Core.EleWise.ELMA.Core.Api.ApiProvider.IsTask(method.v.rt))
                            {
                                
                                throw new System.ArgumentException.$ctor1(SR.T("\u041c\u0435\u0442\u043e\u0434 \"{0}\" \u0434\u043e\u043b\u0436\u0435\u043d \u0438\u043c\u0435\u0442\u044c \u0442\u0438\u043f \u0432\u043e\u0437\u0432\u0440\u0430\u0449\u0430\u0435\u043c\u043e\u0433\u043e \u0437\u043d\u0430\u0447\u0435\u043d\u0438\u044f {1}", methodName.v, Bridge.Reflection.getTypeFullName(System.Threading.Tasks.Task$1)));
                            }
                            
                            var modelsForMethod = {v: System.Linq.Enumerable.from(additionalModels, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam).where((function($me, method)
                                    {
                                        return function(p)
                                            {
                                                return Bridge.referenceEquals(p.MethodName, method.v.n) || Bridge.referenceEquals(p.MethodName, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.SerializedModelParam.AllMethodName)
                                            }
                                    })(this, method)).select(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ViewModelCreatorService.f1)).ToArray(EleWise_ELMA_Core.EleWise.ELMA.Model.AdditionalModel)};
                            
                            var executeServerFunc = (function($me, methodName, modelsForMethod)
                                {
                                    return Bridge.fn.bind($me, function(currentViewModel)
                                        {
                                            
                                            var currentMetadataViewModel;
                                            
                                            if (((currentMetadataViewModel = Bridge.as(currentViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null)
                                            {
                                                
                                                var currentModelMetadata = currentMetadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$ModelMetadata;
                                                
                                                if (Bridge.is(currentModelMetadata.Metadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("8a5c0ba8-9b97-440a-9c07-07eac9f61aa2")))
                                                {
                                                    
                                                    var root1 = EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.ModelMetadata.prototype.Root.call(currentModelMetadata);
                                                    
                                                    if (root1 != null)
                                                    {
                                                        
                                                        model = Bridge.as(root1.Model, EleWise_ELMA_Core.EleWise.ELMA.DTO.ReactiveProxy);
                                                        
                                                        item = Bridge.unbox(currentModelMetadata.GetModelFunc());
                                                        
                                                        updateModel = false;
                                                        
                                                        viewModel = currentViewModel
                                                    }
                                                }
                                            }
                                            
                                            return this.ScriptService.EleWise_ELMA_Core$EleWise$ELMA$Scripts$IScriptService$ExecuteScript(new EleWise_ELMA_Core.EleWise.ELMA.Scripts.Models.ScriptExecutionParams.ctor(model, modelInfo, viewModel, methodName.v, item, updateModel, modelsForMethod.v))
                                        })
                                })(this, methodName, modelsForMethod);
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.SetAndCreatePlainPropertyValue(serverController, System.String.format("{0}${1}", serverControllerFullName.v, methodName.v), executeServerFunc)
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    return serverController
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ViewModelCreatorService", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.ViewModelCreatorService, {f1: function(p)
    {
        return p.Model
    }});
Bridge.define("EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs], $kind: "nested class", $metadata: function()
        {
            return {
                    td: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent, att: 1048578, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Caption", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Caption", t: 8, rt: Function, fg: "Caption"
                                    }, s: {
                                        a: 2, n: "set_Caption", t: 8, p: [Function], rt: System.Void, fs: "Caption"
                                    }, fn: "Caption"
                            }, {
                                a: 2, n: "Content", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Content", t: 8, rt: Function, fg: "Content"
                                    }, s: {
                                        a: 2, n: "set_Content", t: 8, p: [Function], rt: System.Void, fs: "Content"
                                    }, fn: "Content"
                            }, {
                                a: 2, n: "SlotName", t: 16, rt: Function, g: {
                                        a: 2, n: "get_SlotName", t: 8, rt: Function, fg: "SlotName"
                                    }, s: {
                                        a: 2, n: "set_SlotName", t: 8, p: [Function], rt: System.Void, fs: "SlotName"
                                    }, fn: "SlotName"
                            }, {
                                a: 2, n: "ViewItem", t: 16, rt: Function, g: {
                                        a: 2, n: "get_ViewItem", t: 8, rt: Function, fg: "ViewItem"
                                    }, s: {
                                        a: 2, n: "set_ViewItem", t: 8, p: [Function], rt: System.Void, fs: "ViewItem"
                                    }, fn: "ViewItem"
                            }, {
                                a: 1, n: "__Property__Initializer__Content", t: 4, rt: Function, sn: "__Property__Initializer__Content"
                            }, {
                                a: 1, backing: true, n: "<Caption>k__BackingField", t: 4, rt: Function, sn: "Caption"
                            }, {
                                a: 1, backing: true, n: "<Content>k__BackingField", t: 4, rt: Function, sn: "Content"
                            }, {
                                a: 1, backing: true, n: "<SlotName>k__BackingField", t: 4, rt: Function, sn: "SlotName"
                            }, {
                                a: 1, backing: true, n: "<ViewItem>k__BackingField", t: 4, rt: Function, sn: "ViewItem"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            ViewItem: null, Content: null, SlotName: null, Caption: null
        }, ctors: {init: function()
            {
                this.Content = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs.f1)
            }}
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, {f1: function()
    {
        return null
    }});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseContext$1", EleWise_ELMA_Core_React, function(TM)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseContext], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Model", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Model", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$SetFunc", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$SetFunc", "Attributes", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Attributes", "PropertyMetadata", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyMetadata", "PropertyOwner", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyOwner", "DataTestId", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$DataTestId", "FocusableType", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$FocusableType", "OnKeyPress", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnKeyPress", "OnBlur", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnBlur", "OnFocus", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnFocus"]
        }
});
Bridge.definei("EleWise.ELMA.Core.React.Models.IReactInputModel$1", EleWise_ELMA_Core_React, function(TInputs)
{
    return {
            inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel$1(TInputs), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel], $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputRenderer", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {Order: 2147483646})], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                            n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 2, n: "CanRender", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "CanRender", rt: System.Boolean, p: [System.Type], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ov: true, a: 3, n: "CreateInputModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "CreateInputModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel, p: [System.Type]
                            }, {
                                a: 1, n: "GetInputsTypeComponent", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "GetInputsTypeComponent", rt: System.Array.type(System.Type), p: [System.Type]
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["CanRender", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender"], ctors: {ctor: function(currentScope)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.ctor.call(this, currentScope)
            }}, methods: {
            CanRender: function(typeComponent)
            {
                
                return Bridge.Reflection.isAssignableFrom(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IInputComponent, typeComponent)
            }, CreateInputModel: function(typeComponent)
                {
                    
                    var typeInputs = null;
                    
                    var args = this.GetInputsTypeComponent(typeComponent);
                    
                    if (args.length > 0)
                    {
                        
                        var simpleType = args[System.Array.index(0, args)];
                        
                        var baseInputsType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1;
                        
                        if (!Bridge.Reflection.isAssignableFrom(baseInputsType, simpleType))
                        {
                            
                            typeInputs = baseInputsType.apply(null, System.Array.init([simpleType], System.Type))
                        }
                    }
                    
                    var genericType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel$1.apply(null, System.Array.init([typeInputs], System.Type));
                    
                    return Bridge.cast(Bridge.createInstance(genericType), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel)
                }, GetInputsTypeComponent: function(typeComponent)
                {
                    
                    return Bridge.Reflection.isGenericType(Bridge.Reflection.getBaseType(typeComponent)) ? Bridge.Reflection.getGenericArguments(Bridge.Reflection.getBaseType(typeComponent)) : this.GetInputsTypeComponent(Bridge.Reflection.getBaseType(typeComponent))
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.ErrorRenderer", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {Order: 10})], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                            n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 2, n: "BaseInitViewModel", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "BaseInitViewModel", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                ov: true, a: 2, n: "CanRender", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }], sn: "CanRender", rt: System.Boolean, p: [System.Type], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ov: true, a: 2, n: "Render", t: 8, pi: [{
                                            n: "typeComponent", pt: System.Type, ps: 0
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                        }, {
                                            n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                        }], sn: "Render", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                            }, {
                                a: 1, n: "ComponentManager", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, g: {
                                        a: 1, n: "get_ComponentManager", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, fg: "ComponentManager"
                                    }, fn: "ComponentManager"
                            }, {
                                a: 1, n: "componentManager", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager, sn: "componentManager"
                            }, {
                                a: 1, n: "currentScope", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "currentScope$1", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            currentScope$1: null, componentManager: null
        }, props: {ComponentManager: {get: function()
                {
                    
                    return this.componentManager || ((this.componentManager = this.currentScope$1.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.IComponentManager)))
                }}}, alias: ["CanRender", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender", "Render", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render"], ctors: {ctor: function(currentScope)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.ctor.call(this, currentScope);
                
                this.currentScope$1 = currentScope
            }}, methods: {
            CanRender: function(typeComponent)
            {
                
                return Bridge.referenceEquals(typeComponent, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IErrorComponent)
            }, Render: function(typeComponent, owner, inputs)
                {
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var typesReactComponent = this.ComponentManager.EleWise_ELMA_Core$EleWise$ELMA$Core$ComponentModel$IComponentManager$GetTypes(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IErrorComponent);
                    
                    var errorTypeComponent = System.Linq.Enumerable.from(typesReactComponent, System.Type).firstOrDefault(null, null);
                    
                    var model = this.BaseInitViewModel(errorTypeComponent, owner, inputs);
                    
                    return this.CreateComponent(errorTypeComponent, model)
                }, BaseInitViewModel: function(typeComponent, owner, inputs)
                {
                    var $t,
                        $t1;
                    if (inputs === void 0)
                    {
                        inputs = null
                    }
                    
                    var inputModel = this.CreateInputModel(typeComponent);
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key = ($t = (inputs != null ? inputs.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputs$Key : null), $t != null ? $t : Bridge.Reflection.getTypeName(typeComponent));
                    
                    var inputType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.GetInputsType(typeComponent);
                    
                    var newInputs = Bridge.cast(Bridge.createInstance(inputType), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs);
                    
                    var oldInputs;
                    
                    if (((oldInputs = Bridge.as(inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IErrorInputs))) != null)
                    {
                        
                        newInputs.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputs$Key = oldInputs.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputs$Key;
                        
                        newInputs.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message = oldInputs.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$Message;
                        
                        newInputs.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow = oldInputs.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IErrorInputs$StackShow;
                        
                        
                        Bridge.cast(newInputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs).Children = Bridge.cast(oldInputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs).Children
                    }
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs = newInputs;
                    
                    inputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Owner = owner;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope = this.currentScope$1;
                    
                    inputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack = owner != null && ($t1 = owner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$GetDynamicData()) != null ? $t1.EleWise_ELMA_Core$EleWise$ELMA$Model$IDataStack$clone() : null;
                    
                    return inputModel
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.Reactive, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IValidationViewModel], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher], pi: [{
                                            n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                        }, {
                                            n: "lazyViewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                        }, {
                                            n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                        }, {
                                            n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                        }], sn: "ctor"
                            }, {
                                a: 3, n: "CreateDispatcher", t: 8, pi: [{
                                            n: "typeController", pt: System.Type, ps: 0
                                        }], sn: "CreateDispatcher", rt: System.Void, p: [System.Type]
                            }, {
                                a: 3, n: "CreateValidation", t: 8, sn: "CreateValidation", rt: System.Void
                            }, {
                                a: 5, n: "DefineProperty", is: true, t: 8, pi: [{
                                            n: "target", pt: System.Object, ps: 0
                                        }, {
                                            n: "expression", pt: System.Object, ps: 1
                                        }], sn: "DefineProperty", rt: System.Void, p: [System.Object, System.Object]
                            }, {
                                v: true, a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Threading.Tasks.Task
                            }, {
                                a: 2, n: "DestroyValidation", t: 8, sn: "DestroyValidation", rt: System.Void
                            }, {
                                v: true, a: 2, n: "FillViewModel", t: 8, pi: [{
                                            n: "inputModel", pt: Function, ps: 0
                                        }, {
                                            n: "typeContext", pt: System.Type, ps: 1
                                        }, {
                                            n: "typeController", pt: System.Type, ps: 2
                                        }, {
                                            n: "component", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent, ps: 3
                                        }], sn: "FillViewModel", rt: System.Void, p: [Function, System.Type, System.Type, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent]
                            }, {
                                v: true, a: 3, n: "GenerateContext", t: 8, pi: [{
                                            n: "typeContext", pt: System.Type, ps: 0
                                        }], sn: "GenerateContext", rt: System.Void, p: [System.Type]
                            }, {
                                v: true, a: 3, n: "GenerateController", t: 8, pi: [{
                                            n: "typeController", pt: System.Type, ps: 0
                                        }], sn: "GenerateController", rt: System.Void, p: [System.Type]
                            }, {
                                a: 3, n: "GetData", t: 8, sn: "GetData", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack
                            }, {
                                a: 2, n: "GetDynamicData", t: 8, sn: "GetDynamicData", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack
                            }, {
                                a: 3, n: "GetInput", t: 8, pi: [{
                                            n: "propertyName", pt: System.String, ps: 0
                                        }], sn: "GetInput", rt: System.Object, p: [System.String]
                            }, {
                                a: 1, n: "OwnerValidator", t: 8, sn: "OwnerValidator", rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.ValidationResult
                            }, {
                                a: 2, n: "RestoreDynamicData", t: 8, pi: [{
                                            n: "dataItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem, ps: 0
                                        }], sn: "RestoreDynamicData", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem]
                            }, {
                                a: 2, n: "SetDynamicData", t: 8, pi: [{
                                            n: "dataItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem, ps: 0
                                        }], sn: "SetDynamicData", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.DataStackItem]
                            }, {
                                v: true, a: 2, n: "Component", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, g: {
                                        v: true, a: 2, n: "get_Component", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, fg: "Component"
                                    }, fn: "Component"
                            }, {
                                a: 2, n: "ComponentDispatcher", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher, g: {
                                        a: 2, n: "get_ComponentDispatcher", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher, fg: "ComponentDispatcher"
                                    }, s: {
                                        a: 1, n: "set_ComponentDispatcher", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher], rt: System.Void, fs: "ComponentDispatcher"
                                    }, fn: "ComponentDispatcher"
                            }, {
                                a: 2, n: "Context", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, g: {
                                        a: 2, n: "get_Context", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, fg: "Context"
                                    }, s: {
                                        a: 2, n: "set_Context", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext], rt: System.Void, fs: "Context"
                                    }, fn: "Context"
                            }, {
                                v: true, a: 2, n: "Controller", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, g: {
                                        v: true, a: 2, n: "get_Controller", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, fg: "Controller"
                                    }, fn: "Controller"
                            }, {
                                a: 2, n: "Error", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_Error", t: 8, rt: System.Boolean, fg: "Error", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, s: {
                                        a: 2, n: "set_Error", t: 8, p: [System.Boolean], rt: System.Void, fs: "Error"
                                    }, fn: "Error"
                            }, {
                                a: 2, n: "ErrorInfo", t: 16, rt: System.Object, g: {
                                        a: 2, n: "get_ErrorInfo", t: 8, rt: System.Object, fg: "ErrorInfo"
                                    }, s: {
                                        a: 2, n: "set_ErrorInfo", t: 8, p: [System.Object], rt: System.Void, fs: "ErrorInfo"
                                    }, fn: "ErrorInfo"
                            }, {
                                a: 2, n: "ErrorMessage", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_ErrorMessage", t: 8, rt: System.String, fg: "ErrorMessage"
                                    }, s: {
                                        a: 2, n: "set_ErrorMessage", t: 8, p: [System.String], rt: System.Void, fs: "ErrorMessage"
                                    }, fn: "ErrorMessage"
                            }, {
                                a: 2, n: "InputModel", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel, g: {
                                        a: 2, n: "get_InputModel", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputModel, fg: "InputModel"
                                    }, fn: "InputModel"
                            }, {
                                a: 2, n: "ReactComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, g: {
                                        a: 2, n: "get_ReactComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, fg: "ReactComponentCreatorService"
                                    }, s: {
                                        a: 2, n: "set_ReactComponentCreatorService", t: 8, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService], rt: System.Void, fs: "ReactComponentCreatorService"
                                    }, fn: "ReactComponentCreatorService"
                            }, {
                                v: true, a: 2, n: "Ready", t: 16, rt: System.Boolean, g: {
                                        v: true, a: 2, n: "get_Ready", t: 8, rt: System.Boolean, fg: "Ready", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "Ready"
                            }, {
                                a: 2, n: "RenderOwner", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, g: {
                                        a: 2, n: "get_RenderOwner", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, fg: "RenderOwner"
                                    }, fn: "RenderOwner"
                            }, {
                                a: 2, n: "ValidationModel", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.IValidationModel, g: {
                                        a: 2, n: "get_ValidationModel", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Validation.IValidationModel, fg: "ValidationModel"
                                    }, fn: "ValidationModel"
                            }, {
                                a: 1, n: "ValidationModelInternal", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IViewModelValidationModel, g: {
                                        a: 1, n: "get_ValidationModelInternal", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IViewModelValidationModel, fg: "ValidationModelInternal"
                                    }, fn: "ValidationModelInternal"
                            }, {
                                a: 2, n: "ViewItemComponentCreatorService", t: 16, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, g: {
                                        a: 2, n: "get_ViewItemComponentCreatorService", t: 8, rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService, fg: "ViewItemComponentCreatorService"
                                    }, fn: "ViewItemComponentCreatorService"
                            }, {
                                a: 2, n: "ViewModelCreatorService", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, g: {
                                        a: 2, n: "get_ViewModelCreatorService", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, fg: "ViewModelCreatorService"
                                    }, s: {
                                        a: 2, n: "set_ViewModelCreatorService", t: 8, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService], rt: System.Void, fs: "ViewModelCreatorService"
                                    }, fn: "ViewModelCreatorService"
                            }, {
                                a: 3, n: "Stack", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.DataStack, sn: "Stack"
                            }, {
                                a: 1, n: "__Property__Initializer__ErrorInfo", t: 4, rt: System.Object, sn: "__Property__Initializer__ErrorInfo"
                            }, {
                                a: 1, n: "componentSettings", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, sn: "componentSettings"
                            }, {
                                a: 3, n: "controller", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, sn: "controller"
                            }, {
                                a: 1, n: "dispatcher", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, sn: "dispatcher", ro: true
                            }, {
                                a: 1, n: "inputModelFunc", t: 4, rt: Function, sn: "inputModelFunc"
                            }, {
                                a: 1, n: "lazyViewItemComponentCreatorService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), sn: "lazyViewItemComponentCreatorService", ro: true
                            }, {
                                a: 1, n: "validationModel", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IViewModelValidationModel, sn: "validationModel"
                            }, {
                                a: 1, backing: true, n: "<ComponentDispatcher>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher, sn: "ComponentDispatcher"
                            }, {
                                a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, sn: "Context"
                            }, {
                                a: 1, backing: true, n: "<Error>k__BackingField", t: 4, rt: System.Boolean, sn: "Error", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, backing: true, n: "<ErrorInfo>k__BackingField", t: 4, rt: System.Object, sn: "ErrorInfo"
                            }, {
                                a: 1, backing: true, n: "<ErrorMessage>k__BackingField", t: 4, rt: System.String, sn: "ErrorMessage"
                            }, {
                                a: 1, backing: true, n: "<ReactComponentCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, sn: "ReactComponentCreatorService"
                            }, {
                                a: 1, backing: true, n: "<ViewModelCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, sn: "ViewModelCreatorService"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {methods: {DefineProperty: function(target, expression)
                {
                    
                    var name = expression.name;
                    Object.defineProperty(target, name, {
                        configurable: true, get: function()
                            {
                                return Reactive.convertHelper.GetObject(Bridge.unbox(target), expression, false, void 0)
                            }, set: function(v)
                            {
                                Reactive.convertHelper.SetObject(Bridge.unbox(target), expression, Bridge.unbox(v), false, void 0)
                            }
                    })
                }}}, fields: {
            lazyViewItemComponentCreatorService: null, dispatcher: null, Stack: null, inputModelFunc: null, componentSettings: null, validationModel: null, ViewModelCreatorService: null, ReactComponentCreatorService: null, Error: false, ErrorMessage: null, ErrorInfo: null, Context: null, ComponentDispatcher: null, controller: null
        }, props: {
            ViewItemComponentCreatorService: {get: function()
                {
                    
                    return this.lazyViewItemComponentCreatorService[Bridge.geti(this.lazyViewItemComponentCreatorService, "EleWise_ELMA_Core$EleWise$ELMA$Ioc$ILazy$1$EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Services$IViewItemComponentCreatorService$Value", "EleWise_ELMA_Core$EleWise$ELMA$Ioc$ILazy$1$Value")]()
                }}, InputModel: {get: function()
                    {
                        
                        return !Bridge.staticEquals(this.inputModelFunc, null) ? this.inputModelFunc() : null
                    }}, Ready: {get: function()
                    {
                        
                        return this.Context != null && this.controller != null && !this.Error
                    }}, Component: {get: function()
                    {
                        
                        if (this.componentSettings == null)
                        {
                            
                            this.componentSettings = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ComponentContainer(this)
                        }
                        
                        return this.componentSettings
                    }}, RenderOwner: {get: function()
                    {
                        var $t;
                        
                        return ($t = this.InputModel) != null ? $t.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Owner : null
                    }}, Controller: {get: function()
                    {
                        
                        return this.controller
                    }}, ValidationModel: {get: function()
                    {
                        
                        if (this.validationModel == null)
                        {
                            
                            this.validationModel = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ValidationModel(this)
                        }
                        
                        return this.validationModel
                    }}, ValidationModelInternal: {get: function()
                    {
                        
                        return Bridge.cast(this.ValidationModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IViewModelValidationModel)
                    }}
        }, alias: ["ViewModelCreatorService", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewModelCreatorService", "ViewItemComponentCreatorService", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ViewItemComponentCreatorService", "ReactComponentCreatorService", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService", "InputModel", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$InputModel", "Ready", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Ready", "Context", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context", "Component", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component", "RenderOwner", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner", "Controller", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller", "ComponentDispatcher", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$ComponentDispatcher", "SetDynamicData", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$SetDynamicData", "RestoreDynamicData", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RestoreDynamicData", "GetDynamicData", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$GetDynamicData", "ValidationModel", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IValidationViewModel$ValidationModel"], ctors: {
            init: function()
            {
                this.Stack = new EleWise_ELMA_Core.EleWise.ELMA.Model.DataStack;
                this.ErrorInfo = {}
            }, ctor: function(viewModelCreatorService, lazyViewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
                {
                    this.$initialize();
                    EleWise_ELMA_Core.EleWise.ELMA.Model.Reactive.ctor.call(this);
                    
                    this.lazyViewItemComponentCreatorService = lazyViewItemComponentCreatorService;
                    
                    this.ViewModelCreatorService = viewModelCreatorService;
                    
                    this.ReactComponentCreatorService = reactComponentCreatorService;
                    
                    this.dispatcher = dispatcher;
                    
                    EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(this, {
                        name: "controller", serializedName: "controller"
                    });
                    
                    EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(this, {
                        name: "Error", serializedName: "Error"
                    })
                }
        }, methods: {
            FillViewModel: function(inputModel, typeContext, typeController, component)
            {
                
                this.inputModelFunc = inputModel;
                
                if (typeContext != null)
                {
                    
                    this.GenerateContext(typeContext)
                }
                
                if (typeController != null)
                {
                    
                    this.GenerateController(typeController)
                }
            }, Destroy: function()
                {
                    
                    return System.Threading.Tasks.Task.CompletedTask
                }, SetDynamicData: function(dataItem)
                {
                    
                    this.Stack.add(dataItem)
                }, RestoreDynamicData: function(dataItem)
                {
                    
                    this.Stack.remove(dataItem)
                }, GetDynamicData: function()
                {
                    
                    return this.Stack
                }, DestroyValidation: function()
                {
                    
                    this.ValidationModelInternal.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$Destroy();
                    
                    var viewModel;
                    
                    if (((viewModel = Bridge.as(this.RenderOwner, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel))) != null)
                    {
                        
                        viewModel.ValidationModelInternal.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$RemoveValidator(Bridge.fn.cacheBind(this, this.OwnerValidator))
                    }
                }, CreateValidation: function()
                {
                    
                    var validationController;
                    
                    if (((validationController = Bridge.as(this.controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnValidate))) != null)
                    {
                        
                        var onBefore = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.f1);
                        
                        var onAfter = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.f1);
                        
                        var handleValidateAction;
                        
                        if (((handleValidateAction = Bridge.as(this.controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IHandleValidateAction))) != null)
                        {
                            
                            onBefore = Bridge.fn.cacheBind(handleValidateAction, handleValidateAction.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IHandleValidateAction$OnBeforeValidateAction);
                            
                            onAfter = Bridge.fn.cacheBind(handleValidateAction, handleValidateAction.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IHandleValidateAction$OnAfterValidateAction)
                        }
                        
                        this.ValidationModelInternal.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$AddValidator(Bridge.fn.bind(this, function()
                        {
                            
                            var result = null;
                            
                            var inAction = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReactiveHelper.InAction();
                            
                            if (inAction)
                            {
                                
                                onBefore();
                                
                                this.Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Dispatcher.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$Dispatch$1(function()
                                {
                                    
                                    result = validationController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnValidate$OnValidate()
                                })
                            }
                            else
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(this.RenderOwner);
                                
                                try
                                {
                                    
                                    result = validationController.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnValidate$OnValidate()
                                }
                                finally
                                {
                                    
                                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(this.RenderOwner)
                                }
                            }
                            
                            if (result.ErrorMessage != null && System.String.isNullOrWhiteSpace(result.ErrorMessage.ComponentName))
                            {
                                
                                result.ErrorMessage.ComponentName = this.Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name
                            }
                            
                            if (inAction)
                            {
                                
                                onAfter()
                            }
                            
                            return result
                        }), (this.Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name || "") + "Validator")
                    }
                    
                    var viewModel;
                    
                    if (((viewModel = Bridge.as(this.RenderOwner, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel))) != null)
                    {
                        
                        viewModel.ValidationModelInternal.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IViewModelValidationModel$AddValidator(Bridge.fn.cacheBind(this, this.OwnerValidator), (this.Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name || "") + "$OwnerValidator$" + (this.RenderOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IComponentContainer$Name || ""))
                    }
                }, OwnerValidator: function()
                {
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(this.RenderOwner);
                    
                    try
                    {
                        
                        return this.ValidationModel.EleWise_ELMA_Core$EleWise$ELMA$Model$Validation$IValidationModel$GetSummaryResult()
                    }
                    finally
                    {
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(this.RenderOwner)
                    }
                }, GenerateContext: function(typeContext)
                {
                    var $t;
                    
                    if (typeContext == null)
                    {
                        
                        return
                    }
                    
                    var context = Bridge.cast(Bridge.createInstance(typeContext), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext);
                    
                    var properties = Bridge.Reflection.getMembers(typeContext, 16, 28);
                    
                    var baseType = Bridge.Reflection.getBaseType(typeContext);
                    
                    $t = Bridge.getEnumerator(properties);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var property = $t.Current;
                            
                            var propertyName = {v: property.n};
                            
                            if (Bridge.Reflection.getMembers(baseType, 16, 284, propertyName.v) != null)
                            {
                                
                                var info = {
                                        name: propertyName.v, serializedName: propertyName.v
                                    };
                                
                                Reactive.convertHelper.RedefinePropFunc(context, info, (function($me, propertyName)
                                {
                                    return Bridge.fn.bind($me, function()
                                        {
                                            return this.GetInput(propertyName.v)
                                        })
                                })(this, propertyName))
                            }
                            else
                            {
                                
                                var value = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.GetPropertyValue(context, propertyName.v, EleWise_ELMA_Core.EleWise.ELMA.Model.Helpers.DefaultValueHelper.GetTypeDefaultValue(property.rt));
                                
                                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(context, {
                                    name: propertyName.v, serializedName: propertyName.v
                                });
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.SetPropertyValue(context, propertyName.v, value)
                            }
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    this.Context = context
                }, GenerateController: function(typeController)
                {
                    
                    if (typeController == null || Bridge.Reflection.isInterface(typeController))
                    {
                        
                        return
                    }
                    
                    this.controller = this.ViewModelCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ControllerCreator(typeController, this.Context, this, void 0);
                    
                    this.CreateDispatcher(typeController);
                    
                    this.dispatcher.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IDispatcher$Dispatch(new EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.ActionCommand(EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.ControllerAsyncConstants.CommandName, "", [this.controller, Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.f2))]))
                }, CreateDispatcher: function(typeController)
                {
                    
                    var genericType = EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.ComponentDispatcher$1.apply(null, System.Array.init([typeController], System.Type));
                    
                    this.ComponentDispatcher = Bridge.cast(Bridge.createInstance(genericType, [this.dispatcher, this]), EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher)
                }, GetInput: function(propertyName)
                {
                    
                    if (this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs == null)
                    {
                        
                        return null
                    }
                    
                    var inputPropertyInfo = Bridge.Reflection.getMembers(Bridge.getType(this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs), 16, 284, propertyName);
                    
                    if (inputPropertyInfo != null)
                    {
                        
                        return Bridge.Reflection.midel(inputPropertyInfo.g, this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs)()
                    }
                    
                    return this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs[propertyName]
                }, GetData: function()
                {
                    
                    var reactInputModel;
                    
                    return ((reactInputModel = Bridge.as(this.InputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel))) != null ? reactInputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack : null
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, {
    f1: function(){}, f2: function()
        {
            
            this.CreateValidation();
            
            return System.Threading.Tasks.Task.CompletedTask
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseRangeController$2", EleWise_ELMA_Core_React, function(T, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputController$2(T, TContext), EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 2, n: "OnInit", t: 8, sn: "OnInit", rt: System.Void
                                    }, {
                                        ab: true, a: 3, n: "TypeUid", t: 16, rt: System.Guid, g: {
                                                ab: true, a: 3, n: "get_TypeUid", t: 8, rt: System.Guid, fg: "TypeUid"
                                            }, fn: "TypeUid"
                                    }, {
                                        a: 1, backing: true, n: "<TypeUid>k__BackingField", t: 4, rt: System.Guid, sn: "TypeUid"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["OnInit", "EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnInit$OnInit"], methods: {OnInit: function()
                    {
                        
                        var name = this.GetName();
                        
                        var attributes = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$Attributes();
                        
                        var metadata = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$PropertyMetadata();
                        
                        var propFrom = EleWise_ELMA_Core.EleWise.ELMA.DataClassHelper.Clone(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), metadata);
                        
                        propFrom.TypeUid$7314171f42964f23a04631594a2d6e53 = this.TypeUid;
                        
                        propFrom.Name$6eec8103a7b64f87b992ddd03d2e3f4e = System.String.format("{0}_From", [name]);
                        
                        propFrom.Settings$7314171f42964f23a04631594a2d6e53 = attributes.TypeSettings;
                        
                        this.Context.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyFrom = propFrom;
                        
                        var propTo = EleWise_ELMA_Core.EleWise.ELMA.DataClassHelper.Clone(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("7314171f-4296-4f23-a046-31594a2d6e53"), metadata);
                        
                        propTo.TypeUid$7314171f42964f23a04631594a2d6e53 = this.TypeUid;
                        
                        propTo.Name$6eec8103a7b64f87b992ddd03d2e3f4e = System.String.format("{0}_To", [name]);
                        
                        propTo.Settings$7314171f42964f23a04631594a2d6e53 = attributes.TypeSettings;
                        
                        this.Context.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IBaseRangeContext$PropertyTo = propTo
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseRangeInputs$1", EleWise_ELMA_Core_React, function(T)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(T)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ContextCreationWithModelParameters", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ContextCreationParameters, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IContextCreationWithModelParameters], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), System.Guid, System.Guid, System.Guid, System.Object, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928"))], pi: [{
                                            n: "viewModel", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "innerStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 1
                                        }, {
                                            n: "outerStack", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, ps: 2
                                        }, {
                                            n: "metadata", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("50d16f5f-86a4-4bff-916a-51099dadb450"), ps: 3
                                        }, {
                                            n: "metadataUid", pt: System.Guid, ps: 4
                                        }, {
                                            n: "metadataTypeUid", pt: System.Guid, ps: 5
                                        }, {
                                            n: "metadataModuleUid", pt: System.Guid, ps: 6
                                        }, {
                                            n: "model", pt: System.Object, ps: 7
                                        }, {
                                            n: "modelType", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, ps: 8
                                        }, {
                                            n: "viewModelMetadata", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), ps: 9
                                        }, {
                                            n: "additionalViewModelPropertyInfo", dv: null, o: true, pt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), ps: 10
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "AdditionalViewModelPropertyInfo", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), g: {
                                        a: 2, n: "get_AdditionalViewModelPropertyInfo", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), fg: "AdditionalViewModelPropertyInfo"
                                    }, fn: "AdditionalViewModelPropertyInfo"
                            }, {
                                a: 2, n: "Model", t: 16, rt: System.Object, g: {
                                        a: 2, n: "get_Model", t: 8, rt: System.Object, fg: "Model"
                                    }, fn: "Model"
                            }, {
                                a: 2, n: "ModelType", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, g: {
                                        a: 2, n: "get_ModelType", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, fg: "ModelType", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                            }
                                    }, fn: "ModelType"
                            }, {
                                a: 2, n: "ViewModelMetadata", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), g: {
                                        a: 2, n: "get_ViewModelMetadata", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), fg: "ViewModelMetadata"
                                    }, fn: "ViewModelMetadata"
                            }, {
                                a: 1, backing: true, n: "<AdditionalViewModelPropertyInfo>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928")), sn: "AdditionalViewModelPropertyInfo"
                            }, {
                                a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: System.Object, sn: "Model"
                            }, {
                                a: 1, backing: true, n: "<ModelType>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, sn: "ModelType", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType, System.Enum.toStringFn(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ModelType))
                                    }
                            }, {
                                a: 1, backing: true, n: "<ViewModelMetadata>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("2d4545a6-4460-4791-8738-fe00f2b9564e"), sn: "ViewModelMetadata"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            Model: null, ModelType: 0, ViewModelMetadata: null, AdditionalViewModelPropertyInfo: null
        }, alias: ["Model", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$Model", "ModelType", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ModelType", "ViewModelMetadata", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$ViewModelMetadata", "AdditionalViewModelPropertyInfo", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IContextCreationWithModelParameters$AdditionalViewModelPropertyInfo"], ctors: {ctor: function(viewModel, innerStack, outerStack, metadata, metadataUid, metadataTypeUid, metadataModuleUid, model, modelType, viewModelMetadata, additionalViewModelPropertyInfo)
            {
                if (additionalViewModelPropertyInfo === void 0)
                {
                    additionalViewModelPropertyInfo = null
                }
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ContextCreationParameters.ctor.call(this, viewModel, innerStack, outerStack, metadata, metadataUid, metadataTypeUid, metadataModuleUid);
                
                EleWise_ELMA_Core.EleWise.ELMA.Core.Diagnostics.Contract.ArgumentNotNull(model, "model");
                
                this.Model = model;
                
                this.ModelType = modelType;
                
                this.ViewModelMetadata = viewModelMetadata;
                
                this.AdditionalViewModelPropertyInfo = additionalViewModelPropertyInfo || new(System.Collections.Generic.List$1(EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("379b5780-d1d0-43ce-9c09-cd1a0dc66928"))).ctor
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Models.HideEmptyContainerModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel], pi: [{
                                            n: "containerModel", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, ps: 0
                                        }, {
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 1
                                        }, {
                                            n: "owner", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 2
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "AddIsHidden", t: 8, pi: [{
                                            n: "isHidden", pt: Function, ps: 0
                                        }], sn: "AddIsHidden", rt: System.Void, p: [Function]
                            }, {
                                ov: true, a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Void
                            }, {
                                ov: true, a: 3, n: "GetHiddenValue", t: 8, sn: "GetHiddenValue", rt: System.Boolean, box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ov: true, a: 2, n: "Init", t: 8, sn: "Init", rt: System.Void
                            }, {
                                a: 2, n: "RemoveIsHidden", t: 8, pi: [{
                                            n: "isHidden", pt: Function, ps: 0
                                        }], sn: "RemoveIsHidden", rt: System.Void, p: [Function]
                            }, {
                                a: 1, n: "storage", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainerModel, sn: "storage", ro: true
                            }, {
                                a: 1, n: "subscriberList", t: 4, rt: System.Collections.Generic.ICollection$1(Function), sn: "subscriberList"
                            }, {
                                a: 1, n: "viewItem", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, sn: "viewItem", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            storage: null, viewItem: null, subscriberList: null
        }, alias: ["Init", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Init", "Destroy", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Destroy", "AddIsHidden", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$AddIsHidden", "RemoveIsHidden", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyContainerModel$RemoveIsHidden"], ctors: {ctor: function(containerModel, viewItem, owner)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.ctor.call(this, owner);
                
                this.subscriberList = new(Reactive.EleWise.ELMA.Collections.ReactiveCollection$1(Function));
                
                this.storage = containerModel;
                
                this.viewItem = viewItem
            }}, methods: {
            Init: function()
            {
                
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.prototype.Init.call(this);
                
                this.storage.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$AddHideEmpty(this.viewItem, this)
            }, Destroy: function()
                {
                    
                    EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.prototype.Destroy.call(this);
                    
                    this.storage.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$RemoveHideEmpty(this.viewItem);
                    
                    this.subscriberList = null
                }, AddIsHidden: function(isHidden)
                {
                    
                    if (this.subscriberList != null)
                    {
                        
                        System.Array.add(this.subscriberList, isHidden, Function)
                    }
                }, RemoveIsHidden: function(isHidden)
                {
                    
                    if (this.subscriberList != null)
                    {
                        
                        System.Array.remove(this.subscriberList, isHidden, Function)
                    }
                }, GetHiddenValue: function()
                {
                    
                    return System.Linq.Enumerable.from(this.subscriberList, Function).all(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyContainerModel.f1))
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyContainerModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyContainerModel, {f1: function(i)
    {
        return i()
    }});
Bridge.define("EleWise.ELMA.Core.React.Models.IReactViewItemViewModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewModel], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "TestIdEnabled", t: 8, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactViewItemViewModel$TestIdEnabled", rt: System.Boolean, box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.InputModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.Reactive, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "DataStack", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, g: {
                                        a: 2, n: "get_DataStack", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, fg: "DataStack"
                                    }, s: {
                                        a: 2, n: "set_DataStack", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack], rt: System.Void, fs: "DataStack"
                                    }, fn: "DataStack"
                            }, {
                                a: 2, n: "Inputs", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, g: {
                                        a: 2, n: "get_Inputs", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, fg: "Inputs"
                                    }, s: {
                                        a: 2, n: "set_Inputs", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs], rt: System.Void, fs: "Inputs"
                                    }, fn: "Inputs"
                            }, {
                                a: 2, n: "Key", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Key", t: 8, rt: System.String, fg: "Key"
                                    }, s: {
                                        a: 2, n: "set_Key", t: 8, p: [System.String], rt: System.Void, fs: "Key"
                                    }, fn: "Key"
                            }, {
                                a: 2, n: "Owner", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, g: {
                                        a: 2, n: "get_Owner", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, fg: "Owner"
                                    }, s: {
                                        a: 2, n: "set_Owner", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel], rt: System.Void, fs: "Owner"
                                    }, fn: "Owner"
                            }, {
                                a: 2, n: "RootScope", t: 16, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, g: {
                                        a: 2, n: "get_RootScope", t: 8, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, fg: "RootScope"
                                    }, s: {
                                        a: 2, n: "set_RootScope", t: 8, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], rt: System.Void, fs: "RootScope"
                                    }, fn: "RootScope"
                            }, {
                                a: 1, backing: true, n: "<DataStack>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IDataStack, sn: "DataStack"
                            }, {
                                a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, sn: "Inputs"
                            }, {
                                a: 1, backing: true, n: "<Key>k__BackingField", t: 4, rt: System.String, sn: "Key"
                            }, {
                                a: 1, backing: true, n: "<Owner>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "Owner"
                            }, {
                                a: 1, backing: true, n: "<RootScope>k__BackingField", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, sn: "RootScope"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            Key: null, Owner: null, Inputs: null, RootScope: null, DataStack: null
        }, alias: ["Key", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key", "Owner", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Owner", "Inputs", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs", "RootScope", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope", "DataStack", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IDataExtension$DataStack"]
});
Bridge.define("EleWise.ELMA.Core.React.Models.IReactViewItemInputModel", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemInputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemHideEmptyModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IHideable, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel], pi: [{
                                            n: "renderOwner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }, {
                                            n: "hideable", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IHideable, ps: 1
                                        }, {
                                            n: "hideEmptyModel", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyContainerModel, ps: 2
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 3, n: "GetHiddenValue", t: 8, sn: "GetHiddenValue", rt: System.Boolean, box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "hideable", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IHideable, sn: "hideable", ro: true
                            }, {
                                a: 1, n: "renderOwner", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "renderOwner", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            hideable: null, renderOwner: null
        }, ctors: {ctor: function(renderOwner, hideable, hideEmptyModel)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyModel.ctor.call(this, hideEmptyModel);
                
                this.hideable = hideable;
                
                this.renderOwner = renderOwner
            }}, methods: {GetHiddenValue: function()
            {
                
                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(this.renderOwner);
                
                try
                {
                    
                    return this.hideable.EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IHideable$IsHidden()
                }
                finally
                {
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(this.renderOwner)
                }
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactComponent$3", EleWise_ELMA_Core_React, function(TInputs, TContext, TController)
{
    return {
            inherits: [Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs), ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        ov: true, a: 3, n: "ComponentDidCatch", t: 8, pi: [{
                                                    n: "error", pt: System.Exception, ps: 0
                                                }, {
                                                    n: "info", pt: System.Object, ps: 1
                                                }], sn: "componentDidCatch", rt: System.Void, p: [System.Exception, System.Object]
                                    }, {
                                        ov: true, a: 3, n: "ComponentDidMount", t: 8, sn: "componentDidMount", rt: System.Threading.Tasks.Task
                                    }, {
                                        ov: true, a: 3, n: "ComponentDidUpdate", t: 8, pi: [{
                                                    n: "previousProps", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs)), ps: 0
                                                }], sn: "componentDidUpdateWrapped", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))]
                                    }, {
                                        v: true, a: 3, n: "ComponentNotReadyView", t: 8, sn: "ComponentNotReadyView", rt: Object
                                    }, {
                                        ov: true, a: 3, n: "ComponentWillReact", t: 8, sn: "componentWillReact", rt: System.Void
                                    }, {
                                        ov: true, a: 3, n: "ComponentWillUnmount", t: 8, sn: "componentWillUnmount", rt: System.Threading.Tasks.Task
                                    }, {
                                        ov: true, a: 3, sl: true, n: "InitializeViewModel", t: 8, sn: "constructorStateInitialiser", rt: System.Void
                                    }, {
                                        ov: true, a: 2, sl: true, n: "Render", t: 8, sn: "render", rt: Object
                                    }, {
                                        v: true, a: 4, n: "RenderInternal", t: 8, sn: "RenderInternal", rt: Object
                                    }, {
                                        ab: true, a: 2, n: "View", t: 8, sn: "View", rt: Object
                                    }, {
                                        v: true, a: 3, n: "Component", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, g: {
                                                v: true, a: 3, n: "get_Component", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, fg: "Component"
                                            }, fn: "Component"
                                    }, {
                                        v: true, a: 3, n: "Context", t: 16, rt: TContext, g: {
                                                v: true, a: 3, n: "get_Context", t: 8, rt: TContext, fg: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 3, n: "Controller", t: 16, rt: TController, g: {
                                                a: 3, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        v: true, a: 3, n: "Dispatcher", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher$1(TController), g: {
                                                v: true, a: 3, n: "get_Dispatcher", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher$1(TController), fg: "Dispatcher"
                                            }, fn: "Dispatcher"
                                    }, {
                                        a: 3, n: "InputModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs), g: {
                                                a: 3, n: "get_InputModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs), fg: "InputModel"
                                            }, fn: "InputModel"
                                    }, {
                                        a: 2, n: "ReactElement", t: 16, rt: Object, g: {
                                                a: 2, n: "get_ReactElement", t: 8, rt: Object, fg: "ReactElement"
                                            }, fn: "ReactElement"
                                    }, {
                                        v: true, a: 3, n: "TypeViewModel", t: 16, rt: System.Type, g: {
                                                v: true, a: 3, n: "get_TypeViewModel", t: 8, rt: System.Type, fg: "TypeViewModel"
                                            }, fn: "TypeViewModel"
                                    }, {
                                        a: 2, n: "ViewModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, g: {
                                                a: 2, n: "get_ViewModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, fg: "ViewModel"
                                            }, fn: "ViewModel"
                                    }, {
                                        a: 5, n: "Model", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, sn: "Model"
                                    }, {
                                        a: 1, n: "scopedComponentType", is: true, t: 4, rt: System.Type, sn: "scopedComponentType"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
                    fields: {scopedComponentType: null}, ctors: {init: function()
                            {
                                this.scopedComponentType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IScopedComponent
                            }}
                }, fields: {Model: null}, props: {
                    ReactElement: {get: function()
                        {
                            
                            return Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).op_Implicit(this)
                        }}, ViewModel: {get: function()
                            {
                                
                                return this.Model
                            }}, Controller: {get: function()
                            {
                                
                                var controller = this.ViewModel.Controller;
                                
                                if (controller == null)
                                {
                                    
                                    return Bridge.getDefaultValue(TController)
                                }
                                
                                return Bridge.cast(Bridge.unbox(controller, TController), TController)
                            }}, TypeViewModel: {get: function()
                            {
                                
                                return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel
                            }}, Context: {get: function()
                            {
                                
                                return this.ViewModel.Context != null ? Bridge.cast(Bridge.unbox(this.ViewModel.Context, TContext), TContext) : Bridge.getDefaultValue(TContext)
                            }}, Component: {get: function()
                            {
                                
                                return this.ViewModel.Component
                            }}, InputModel: {get: function()
                            {
                                
                                return this.unwrappedProps.Model
                            }}, Dispatcher: {get: function()
                            {
                                
                                return Bridge.cast(this.ViewModel.ComponentDispatcher, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IComponentDispatcher$1(TController))
                            }}
                }, alias: ["ReactElement", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IReactComponent$ReactElement"], ctors: {ctor: function(model)
                    {
                        var $t,
                            $t1;
                        this.$initialize();
                        Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).ctor.call(this, ($t = new(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))), $t.Model = model, $t.key = model.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key, $t.children = ($t1 = model["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"]) != null ? $t1.Children : null, $t.ref = System.Linq.Enumerable.from(Bridge.Reflection.getInterfaces(TInputs), System.Type).any(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f1)) ? Bridge.cast(model["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"], EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IRef).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IRef$Ref : undefined, $t))
                    }}, methods: {
                    constructorStateInitialiser: function()
                    {
                        
                        var currentScope = this.InputModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactInputModel$RootScope;
                        
                        if (Bridge.Reflection.isAssignableFrom(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).scopedComponentType, Bridge.getType(this)))
                        {
                            
                            currentScope = currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$ILifetimeScope$BeginLifetimeScope$1(Bridge.Reflection.getTypeName(Bridge.getType(this)))
                        }
                        
                        this.Model = Bridge.cast(currentScope.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService).EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$CreateModel$1(this.TypeViewModel), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel);
                        
                        this.ViewModel.FillViewModel(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f2)), TContext, TController, this);
                        
                        if (Bridge.is(this.Controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit))
                        {
                            
                            this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f3))
                        }
                    }, componentDidMount: function()
                        {
                            var $step = 0,
                                $task1,
                                $task2,
                                $jumpFromFinally,
                                $tcs = new System.Threading.Tasks.TaskCompletionSource,
                                $returnValue,
                                $async_e,
                                $asyncBody = Bridge.fn.bind(this, function()
                                {
                                    try
                                    {
                                        for (; ; )
                                        {
                                            $step = System.Array.min([0, 1, 2, 3, 4], $step);
                                            switch ($step)
                                            {
                                                case 0:
                                                    {
                                                        
                                                        $task1 = Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).prototype.componentDidMount.call(this);
                                                        $step = 1;
                                                        if ($task1.isCompleted())
                                                            continue;
                                                        $task1.continue($asyncBody);
                                                        return
                                                    }
                                                case 1:
                                                    {
                                                        $task1.getAwaitedResult();
                                                        
                                                        if (Bridge.is(this.Controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad))
                                                        {
                                                            
                                                            this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f4))
                                                        }
                                                        
                                                        if (Bridge.is(this.Controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync))
                                                        {
                                                            $step = 2;
                                                            continue
                                                        }
                                                        $step = 4;
                                                        continue
                                                    }
                                                case 2:
                                                    {
                                                        
                                                        $task2 = this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$2"](Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f5));
                                                        $step = 3;
                                                        if ($task2.isCompleted())
                                                            continue;
                                                        $task2.continue($asyncBody);
                                                        return
                                                    }
                                                case 3:
                                                    {
                                                        $task2.getAwaitedResult();
                                                        $step = 4;
                                                        continue
                                                    }
                                                case 4:
                                                    {
                                                        $tcs.setResult(null);
                                                        return
                                                    }
                                                default:
                                                    {
                                                        $tcs.setResult(null);
                                                        return
                                                    }
                                            }
                                        }
                                    }
                                    catch($async_e1)
                                    {
                                        $async_e = System.Exception.create($async_e1);
                                        $tcs.setException($async_e)
                                    }
                                }, arguments);
                            if (mobx._getGlobalState().allowStateChanges)
                            {
                                $asyncBody = mobx.action($asyncBody)
                            }
                            $asyncBody();
                            return $tcs.task
                        }, componentDidUpdateWrapped: function(previousProps)
                        {
                            
                            return Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).prototype.componentDidUpdateWrapped.call(this, previousProps)
                        }, componentWillReact: function()
                        {
                            
                            Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).prototype.componentWillReact.call(this)
                        }, componentDidCatch: function(error, info)
                        {
                            
                            this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, function(c)
                            {
                                
                                this.ViewModel.Error = true;
                                
                                this.ViewModel.ErrorMessage = Bridge.toString(error);
                                
                                this.ViewModel.ErrorInfo = info
                            }))
                        }, componentWillUnmount: function()
                        {
                            
                            if (Bridge.is(this.Controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnDestroy))
                            {
                                
                                this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f6))
                            }
                            
                            if (Bridge.is(this.Controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnDestroyAsync))
                            {
                                
                                this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$2"](Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f7))
                            }
                            
                            this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f8)));
                            
                            if (Bridge.Reflection.isAssignableFrom(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).scopedComponentType, Bridge.getType(this)) && EleWise_ELMA_Core.EleWise.ELMA.Extensions.ObjectExtensions.HasProperty(this.ViewModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ScopedComponentConstants.CurrentScope))
                            {
                                
                                
                                Bridge.unbox(this.ViewModel[EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ScopedComponentConstants.CurrentScope]).System$IDisposable$Dispose()
                            }
                            
                            this.Model.Destroy();
                            
                            return Bridge.React.PureComponent$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs))).prototype.componentWillUnmount.call(this)
                        }, render: function()
                        {
                            var $t,
                                $t1;
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(($t = this.ViewModel) != null ? $t.RenderOwner : null);
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.SetData(this.ViewModel);
                            
                            var result;
                            
                            try
                            {
                                
                                result = !this.ViewModel.Ready ? this.ComponentNotReadyView() : this.RenderInternal()
                            }
                            finally
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.RestoreData(this.ViewModel);
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(($t1 = this.ViewModel) != null ? $t1.RenderOwner : null)
                            }
                            
                            var viewModelHandler;
                            
                            if (((viewModelHandler = Bridge.as(this.Model, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModelHandler))) != null)
                            {
                                
                                viewModelHandler.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModelHandler$AfterView()
                            }
                            
                            return result
                        }, RenderInternal: function()
                        {
                            
                            return this.View()
                        }, ComponentNotReadyView: function()
                        {
                            var $t;
                            
                            if (this.ViewModel.Error)
                            {
                                
                                var i = 0;
                                
                                return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(this.ViewModel.ReactComponentCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Error(($t = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseErrorInputs, $t.Message = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3.f9)), $t.Children = System.Linq.Enumerable.from(System.String.split(this.ViewModel.ErrorInfo.componentStack, [10].map(function(i)
                                        {
                                            {
                                                return String.fromCharCode(i)
                                            }
                                        })), System.String).select(function(e)
                                        {
                                            return React.createElement('div', Bridge.React.fixAttr({key: "error_" + Bridge.identity(i, ((i = (i + 1) | 0)))}), e)
                                        }).ToArray(Object), $t), this.ViewModel))
                            }
                            
                            return null
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3, {
    f1: function(i)
    {
        return Bridge.referenceEquals(i, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IRef)
    }, f2: function()
        {
            return this.InputModel
        }, f3: function(c)
        {
            
            
            Bridge.cast(c, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit).EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnInit$OnInit()
        }, f4: function(c)
        {
            
            
            Bridge.cast(c, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad).EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnLoad$OnLoad()
        }, f5: function(c)
        {
            return Bridge.cast(c, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync).EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnLoadAsync$OnLoadAsync()
        }, f6: function(c)
        {
            
            
            Bridge.cast(c, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnDestroy).EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnDestroy$OnDestroy()
        }, f7: function(c)
        {
            return Bridge.cast(c, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnDestroyAsync).EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IOnDestroyAsync$OnDestroyAsync()
        }, f8: function(c)
        {
            
            this.ViewModel.DestroyValidation()
        }, f9: function()
        {
            return this.ViewModel.ErrorMessage
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputController$1", EleWise_ELMA_Core_React, function(TM)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputController$2(TM, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseContext$1(TM))], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.BaseInputViewModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModelHandler], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher], pi: [{
                                            n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                        }, {
                                            n: "viewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                        }, {
                                            n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                        }, {
                                            n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "AfterAction", t: 8, sn: "AfterAction", rt: System.Void
                            }, {
                                a: 2, n: "AfterView", t: 8, sn: "AfterView", rt: System.Void
                            }, {
                                a: 1, n: "ClearCacheValue", t: 8, sn: "ClearCacheValue", rt: System.Void
                            }, {
                                ov: true, a: 3, n: "GenerateContext", t: 8, pi: [{
                                            n: "typeContext", pt: System.Type, ps: 0
                                        }], sn: "GenerateContext", rt: System.Void, p: [System.Type]
                            }, {
                                ov: true, a: 2, n: "Component", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, g: {
                                        ov: true, a: 2, n: "get_Component", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, fg: "Component"
                                    }, fn: "Component"
                            }, {
                                a: 2, n: "OnBlur", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnBlur", t: 8, rt: Function, fg: "OnBlur"
                                    }, fn: "OnBlur"
                            }, {
                                a: 2, n: "OnFocus", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnFocus", t: 8, rt: Function, fg: "OnFocus"
                                    }, fn: "OnFocus"
                            }, {
                                a: 2, n: "OnKeyPress", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OnKeyPress", t: 8, rt: Function, fg: "OnKeyPress"
                                    }, fn: "OnKeyPress"
                            }, {
                                a: 1, n: "componentSettings", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, sn: "componentSettings$1"
                            }, {
                                a: 1, n: "hasValueModel", t: 4, rt: System.Boolean, sn: "hasValueModel", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "value", t: 4, rt: System.Object, sn: "value"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            componentSettings$1: null, value: null, hasValueModel: false
        }, props: {
            Component: {get: function()
                {
                    
                    if (this.componentSettings$1 == null)
                    {
                        
                        this.componentSettings$1 = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputComponentContainer(this)
                    }
                    
                    return this.componentSettings$1
                }}, OnKeyPress: {get: function()
                    {
                        
                        return Bridge.cast(this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseInputs).EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnKeyPress
                    }}, OnFocus: {get: function()
                    {
                        
                        return Bridge.cast(this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseInputs).EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnFocus
                    }}, OnBlur: {get: function()
                    {
                        
                        return Bridge.cast(this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseInputs).EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$OnBlur
                    }}
        }, alias: ["Component", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component", "AfterView", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModelHandler$AfterView", "AfterAction", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModelHandler$AfterAction"], ctors: {ctor: function(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.ctor.call(this, viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
            }}, methods: {
            AfterView: function()
            {
                
                this.ClearCacheValue()
            }, AfterAction: function()
                {
                    
                    this.ClearCacheValue()
                }, ClearCacheValue: function()
                {
                    
                    this.value = null;
                    
                    this.hasValueModel = false
                }, GenerateContext: function(typeContext)
                {
                    var $t;
                    
                    if (typeContext == null)
                    {
                        
                        return
                    }
                    
                    var context = Bridge.cast(Bridge.createInstance(typeContext), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseContext);
                    
                    var contextType = Bridge.getType(context);
                    
                    var properties = Bridge.Reflection.getMembers(contextType, 16, 28);
                    
                    var baseType = Bridge.Reflection.getBaseType(contextType);
                    
                    $t = Bridge.getEnumerator(properties);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var property = $t.Current;
                            
                            var propertyName = {v: property.n};
                            
                            if (Bridge.referenceEquals(propertyName.v, "Model"))
                            {
                                
                                var baseGetFunc = context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc;
                                
                                context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel.f1));
                                
                                continue
                            }
                            
                            if (Bridge.referenceEquals(propertyName.v, "GetFunc") || Bridge.referenceEquals(propertyName.v, "SetFunc"))
                            {
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.SetPropertyValue(context, propertyName.v, this.GetInput(propertyName.v));
                                
                                continue
                            }
                            
                            if (Bridge.Reflection.getMembers(baseType, 16, 284, propertyName.v) != null)
                            {
                                
                                var info = {
                                        name: propertyName.v, serializedName: propertyName.v
                                    };
                                
                                Reactive.convertHelper.RedefinePropFunc(context, info, (function($me, propertyName)
                                {
                                    return Bridge.fn.bind($me, function()
                                        {
                                            return this.GetInput(propertyName.v)
                                        })
                                })(this, propertyName))
                            }
                            else
                            {
                                
                                var value = EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.GetPropertyValue(context, propertyName.v, EleWise_ELMA_Core.EleWise.ELMA.Model.Helpers.DefaultValueHelper.GetTypeDefaultValue(property.rt));
                                
                                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.DefineProperty(context, {
                                    name: propertyName.v, serializedName: propertyName.v
                                });
                                
                                EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.SetPropertyValue(context, propertyName.v, value)
                            }
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    this.Context = context
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel, {f1: function()
    {
        
        if (this.hasValueModel)
        {
            
            return this.value
        }
        
        this.value = Bridge.cast(this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseInputs).EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$GetFunc();
        
        this.hasValueModel = true;
        
        return this.value
    }});
Bridge.define("EleWise.ELMA.Core.React.Models.IHideEmptyViewItemViewModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemViewModel], $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "HideEmptyModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, g: {
                                        ab: true, a: 2, n: "get_HideEmptyModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, fg: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel"
                                    }, fn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel"
                            }, {
                                a: 1, backing: true, n: "<HideEmptyModel>k__BackingField", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, sn: "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.InputModel$1", EleWise_ELMA_Core_React, function(TInputs)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs)], $metadata: function()
                {
                    return {
                            att: 1048576, a: 4, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 2, n: "Inputs", t: 16, rt: TInputs, g: {
                                                a: 2, n: "get_Inputs", t: 8, rt: TInputs, fg: "Inputs$1"
                                            }, s: {
                                                a: 2, n: "set_Inputs", t: 8, p: [TInputs], rt: System.Void, fs: "Inputs$1"
                                            }, fn: "Inputs$1"
                                    }, {
                                        a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: TInputs, sn: "Inputs$1"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {Inputs$1: Bridge.getDefaultValue(TInputs)}, props: {EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs: {
                        get: function()
                        {
                            
                            return this.Inputs$1
                        }, set: function(value)
                            {
                                
                                this.Inputs$1 = Bridge.cast(Bridge.unbox(value, TInputs), TInputs)
                            }
                    }}, alias: ["Inputs$1", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"]
        }
});
Bridge.definei("EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2", EleWise_ELMA_Core_React, function(TViewItem, TInputs)
{
    return {
            inherits: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemInputModel$2(TViewItem, TInputs), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel], $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewModel$2", EleWise_ELMA_Core_React, function(TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel$2(TContext, TController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher], pi: [{
                                                    n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                                }, {
                                                    n: "lazyViewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                                }, {
                                                    n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                                }, {
                                                    n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                a: 2, n: "get_Context", t: 8, rt: TContext, fg: "Context$1"
                                            }, s: {
                                                a: 2, n: "set_Context", t: 8, p: [TContext], rt: System.Void, fs: "Context$1"
                                            }, fn: "Context$1"
                                    }, {
                                        a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                a: 2, n: "get_Controller", t: 8, rt: TController, fg: "Controller$1"
                                            }, fn: "Controller$1"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", props: {
                    Context$1: {
                        get: function()
                        {
                            
                            if (this.Context != null)
                            {
                                
                                return Bridge.cast(Bridge.unbox(this.Context, TContext), TContext)
                            }
                            
                            return Bridge.getDefaultValue(TContext)
                        }, set: function(value)
                            {
                                
                                this.Context = value
                            }
                    }, Controller$1: {get: function()
                            {
                                
                                if (this.controller != null)
                                {
                                    
                                    return Bridge.cast(Bridge.unbox(this.controller, TController), TController)
                                }
                                
                                return Bridge.getDefaultValue(TController)
                            }}
                }, alias: ["Context$1", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context$1", "Controller$1", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller$1"], ctors: {ctor: function(viewModelCreatorService, lazyViewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel.ctor.call(this, viewModelCreatorService, lazyViewItemComponentCreatorService, reactComponentCreatorService, dispatcher)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputComponent$3", EleWise_ELMA_Core_React, function(TM, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), TContext, TController), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.IInputComponent], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM))], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM)), ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        ov: true, a: 3, n: "ComponentDidMount", t: 8, sn: "componentDidMount", rt: System.Threading.Tasks.Task
                                    }, {
                                        ov: true, a: 3, n: "ComponentDidUpdate", t: 8, pi: [{
                                                    n: "previousProps", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM))), ps: 0
                                                }], sn: "componentDidUpdateWrapped", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactProps$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM)))]
                                    }, {
                                        a: 1, n: "FocusingInput", t: 8, pi: [{
                                                    n: "firstShow", pt: System.Boolean, ps: 0
                                                }], sn: "FocusingInput", rt: System.Void, p: [System.Boolean]
                                    }, {
                                        ov: true, a: 4, sl: true, n: "RenderInternal", t: 8, sn: "RenderInternal", rt: Object
                                    }, {
                                        a: 3, n: "SetInputRef", t: 8, pi: [{
                                                    n: "element", pt: HTMLElement, ps: 0
                                                }], sn: "SetInputRef", rt: System.Void, p: [HTMLElement]
                                    }, {
                                        ov: true, a: 3, n: "TypeViewModel", t: 16, rt: System.Type, g: {
                                                ov: true, a: 3, n: "get_TypeViewModel", t: 8, rt: System.Type, fg: "TypeViewModel"
                                            }, fn: "TypeViewModel"
                                    }, {
                                        a: 3, n: "InputElement", t: 4, rt: HTMLElement, sn: "InputElement"
                                    }, {
                                        a: 1, n: "isFocused", t: 4, rt: System.Boolean, sn: "isFocused", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    isFocused: false, InputElement: null
                }, props: {TypeViewModel: {get: function()
                        {
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.BaseInputViewModel
                        }}}, ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), TContext, TController).ctor.call(this, model)
                    }}, methods: {
                    componentDidMount: function()
                    {
                        var $step = 0,
                            $task1,
                            $jumpFromFinally,
                            $tcs = new System.Threading.Tasks.TaskCompletionSource,
                            $returnValue,
                            $async_e,
                            $asyncBody = Bridge.fn.bind(this, function()
                            {
                                try
                                {
                                    for (; ; )
                                    {
                                        $step = System.Array.min([0, 1], $step);
                                        switch ($step)
                                        {
                                            case 0:
                                                {
                                                    
                                                    $task1 = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), TContext, TController).prototype.componentDidMount.call(this);
                                                    $step = 1;
                                                    if ($task1.isCompleted())
                                                        continue;
                                                    $task1.continue($asyncBody);
                                                    return
                                                }
                                            case 1:
                                                {
                                                    $task1.getAwaitedResult();
                                                    
                                                    this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3.f1)));
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                            default:
                                                {
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                        }
                                    }
                                }
                                catch($async_e1)
                                {
                                    $async_e = System.Exception.create($async_e1);
                                    $tcs.setException($async_e)
                                }
                            }, arguments);
                        if (mobx._getGlobalState().allowStateChanges)
                        {
                            $asyncBody = mobx.action($asyncBody)
                        }
                        $asyncBody();
                        return $tcs.task
                    }, componentDidUpdateWrapped: function(previousProps)
                        {
                            var $step = 0,
                                $task1,
                                $jumpFromFinally,
                                $tcs = new System.Threading.Tasks.TaskCompletionSource,
                                $returnValue,
                                $async_e,
                                $asyncBody = Bridge.fn.bind(this, function()
                                {
                                    try
                                    {
                                        for (; ; )
                                        {
                                            $step = System.Array.min([0, 1], $step);
                                            switch ($step)
                                            {
                                                case 0:
                                                    {
                                                        
                                                        $task1 = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), TContext, TController).prototype.componentDidUpdateWrapped.call(this, previousProps);
                                                        $step = 1;
                                                        if ($task1.isCompleted())
                                                            continue;
                                                        $task1.continue($asyncBody);
                                                        return
                                                    }
                                                case 1:
                                                    {
                                                        $task1.getAwaitedResult();
                                                        
                                                        this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3.f2)));
                                                        $tcs.setResult(null);
                                                        return
                                                    }
                                                default:
                                                    {
                                                        $tcs.setResult(null);
                                                        return
                                                    }
                                            }
                                        }
                                    }
                                    catch($async_e1)
                                    {
                                        $async_e = System.Exception.create($async_e1);
                                        $tcs.setException($async_e)
                                    }
                                }, arguments);
                            if (mobx._getGlobalState().allowStateChanges)
                            {
                                $asyncBody = mobx.action($asyncBody)
                            }
                            $asyncBody();
                            return $tcs.task
                        }, FocusingInput: function(firstShow)
                        {
                            
                            if (this.InputElement == null || Bridge.staticEquals(this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$FocusableType, null))
                            {
                                
                                return
                            }
                            
                            var focusableType = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$FocusableType(firstShow);
                            
                            if (focusableType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.FocusableType.None)
                            {
                                
                                return
                            }
                            else if (focusableType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.FocusableType.Default)
                            {
                                
                                if (!this.isFocused)
                                {
                                    
                                    this.isFocused = true;
                                    
                                    window.setTimeout(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3.f3)), 100)
                                }
                            }
                            else
                            {
                                
                                window.setTimeout(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3.f3)), 100)
                            }
                        }, RenderInternal: function()
                        {
                            
                            var focusable = this.Context.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IBaseInputs$FocusableType(false);
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM), TContext, TController).prototype.RenderInternal.call(this)
                        }, SetInputRef: function(element)
                        {
                            
                            this.InputElement = element
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3, {
    f1: function(c)
    {
        
        this.FocusingInput(true)
    }, f2: function(c)
        {
            
            this.FocusingInput(false)
        }, f3: function()
        {
            
            this.InputElement != null ? this.InputElement.focus() : null
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputController", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputController$2(System.Object, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IBaseContext)], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Models.Context", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {CreateInstancePerResolve: true})], m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4", EleWise_ELMA_Core_React, function(TViewItem, TInputs, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute], m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs), ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        ov: true, a: 3, n: "ComponentWillReact", t: 8, sn: "componentWillReact", rt: System.Void
                                    }, {
                                        ov: true, a: 3, n: "ComponentWillUnmount", t: 8, sn: "componentWillUnmount", rt: System.Threading.Tasks.Task
                                    }, {
                                        v: true, a: 3, n: "DesignTimeView", t: 8, sn: "DesignTimeView", rt: Object
                                    }, {
                                        a: 1, n: "GetChildren", t: 8, pi: [{
                                                    n: "condition", dv: null, o: true, pt: Function, ps: 0
                                                }], sn: "GetChildren", rt: System.Array.type(Object), p: [Function]
                                    }, {
                                        v: true, a: 3, n: "GetOnKeyDown", t: 8, sn: "GetOnKeyDown", rt: Function
                                    }, {
                                        a: 3, n: "GetOnMouseEnter", t: 8, sn: "GetOnMouseEnter", rt: Function
                                    }, {
                                        a: 3, n: "GetOnMouseLeave", t: 8, sn: "GetOnMouseLeave", rt: Function
                                    }, {
                                        a: 3, n: "InitDebounce", t: 8, pi: [{
                                                    n: "action", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction, ps: 0
                                                }, {
                                                    n: "timeout", dv: 300, o: true, pt: System.Int32, ps: 1
                                                }], sn: "InitDebounce", rt: Function, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction, System.Int32]
                                    }, {
                                        a: 1, n: "OnMouseEvent", t: 8, pi: [{
                                                    n: "action", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction, ps: 0
                                                }], sn: "OnMouseEvent", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Actions.DefaultAction]
                                    }, {
                                        a: 1, n: "PrepareChildren", t: 8, pi: [{
                                                    n: "children", pt: System.Array.type(Object), ps: 0
                                                }, {
                                                    n: "condition", pt: Function, ps: 1
                                                }], sn: "PrepareChildren", rt: System.Array.type(Object), p: [System.Array.type(Object), Function]
                                    }, {
                                        a: 3, n: "RenderChildren", t: 8, pi: [{
                                                    n: "condition", dv: null, o: true, pt: Function, ps: 0
                                                }], sn: "RenderChildren", rt: System.Array.type(Object), p: [Function]
                                    }, {
                                        ov: true, a: 4, sl: true, n: "RenderInternal", t: 8, sn: "RenderInternal", rt: Object
                                    }, {
                                        a: 3, n: "RenderWrappedChildren", t: 8, pi: [{
                                                    n: "condition", dv: null, o: true, pt: Function, ps: 0
                                                }, {
                                                    n: "caption", dv: "", o: true, pt: System.String, ps: 1
                                                }], sn: "RenderWrappedChildren", rt: Object, p: [Function, System.String]
                                    }, {
                                        a: 1, n: "SetRef", t: 8, pi: [{
                                                    n: "el", pt: HTMLElement, ps: 0
                                                }], sn: "SetRef", rt: System.Void, p: [HTMLElement]
                                    }, {
                                        ov: true, a: 3, n: "TypeViewModel", t: 16, rt: System.Type, g: {
                                                ov: true, a: 3, n: "get_TypeViewModel", t: 8, rt: System.Type, fg: "TypeViewModel"
                                            }, fn: "TypeViewModel"
                                    }, {
                                        v: true, a: 3, n: "UseCustomContainer", t: 16, rt: System.Boolean, g: {
                                                v: true, a: 3, n: "get_UseCustomContainer", t: 8, rt: System.Boolean, fg: "UseCustomContainer", box: function($v)
                                                    {
                                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                                    }
                                            }, fn: "UseCustomContainer"
                                    }, {
                                        a: 2, n: "ViewItem", t: 16, rt: TViewItem, g: {
                                                a: 2, n: "get_ViewItem", t: 8, rt: TViewItem, fg: "ViewItem"
                                            }, fn: "ViewItem"
                                    }, {
                                        a: 3, n: "ViewItemInputModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs), g: {
                                                a: 3, n: "get_ViewItemInputModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs), fg: "ViewItemInputModel"
                                            }, fn: "ViewItemInputModel"
                                    }, {
                                        a: 3, n: "ViewModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemViewModel, g: {
                                                a: 3, n: "get_ViewModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemViewModel, fg: "ViewModel$1"
                                            }, fn: "ViewModel$1"
                                    }, {
                                        a: 3, n: "ContentElement", t: 4, rt: HTMLElement, sn: "ContentElement"
                                    }, {
                                        a: 1, n: "isActivated", t: 4, rt: System.Boolean, sn: "isActivated", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        a: 1, n: "timeoutId", t: 4, rt: System.Int32, sn: "timeoutId", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, {
                                        a: 1, n: "viewItemName", is: true, t: 4, rt: System.String, sn: "viewItemName"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", statics: {
                    fields: {viewItemName: null}, ctors: {init: function()
                            {
                                this.viewItemName = Bridge.Reflection.getTypeName(TViewItem)
                            }}
                }, fields: {
                    ContentElement: null, isActivated: false, timeoutId: 0
                }, props: {
                    ViewItem: {get: function()
                        {
                            
                            return Bridge.cast(Bridge.unbox(this.ViewModel$1.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem, TViewItem), TViewItem)
                        }}, TypeViewModel: {get: function()
                            {
                                
                                return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel
                            }}, ViewModel$1: {get: function()
                            {
                                
                                return Bridge.cast(this.Model, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemViewModel)
                            }}, ViewItemInputModel: {get: function()
                            {
                                
                                return Bridge.cast(this.unwrappedProps.Model, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs))
                            }}, UseCustomContainer: {get: function()
                            {
                                
                                return false
                            }}
                }, ctors: {
                    init: function()
                    {
                        this.isActivated = false
                    }, ctor: function(model)
                        {
                            this.$initialize();
                            EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).ctor.call(this, model)
                        }
                }, methods: {
                    componentWillReact: function()
                    {
                        
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).prototype.componentWillReact.call(this)
                    }, componentWillUnmount: function()
                        {
                            
                            if (this.timeoutId !== 0)
                            {
                                
                                window.clearTimeout(this.timeoutId);
                                
                                this.timeoutId = 0
                            }
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).prototype.componentWillUnmount.call(this)
                        }, RenderInternal: function()
                        {
                            
                            if (this.UseCustomContainer)
                            {
                                
                                return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).prototype.RenderInternal.call(this)
                            }
                            
                            var className = "viewitem-content";
                            
                            var metadataViewModel;
                            
                            var designMode = ((metadataViewModel = Bridge.as(this.ViewModel$1.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null && metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$IsDesignMode;
                            
                            var hideEmpty = false;
                            
                            var hideEmptyViewItemViewModel;
                            
                            if (((hideEmptyViewItemViewModel = Bridge.as(this.ViewModel$1, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemViewModel))) != null && hideEmptyViewItemViewModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel != null)
                            {
                                
                                hideEmpty = hideEmptyViewItemViewModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$IsEmpty
                            }
                            
                            if ((this.ViewItem != null && this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Hide) || hideEmpty)
                            {
                                
                                className = (className || "") + "--hide";
                                
                                if (!designMode)
                                {
                                    
                                    var item;
                                    
                                    if (((item = Bridge.as(this.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItemLoading))) != null && (item.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItemLoading$LoadingType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItemLoadingType.SyncLoading || item.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItemLoading$LoadingType === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItemLoadingType.LazyLoading) || hideEmpty)
                                    {
                                        
                                        this.isActivated = true
                                    }
                                }
                            }
                            else
                            {
                                
                                this.isActivated = true
                            }
                            
                            var content = null;
                            
                            if (this.isActivated)
                            {
                                
                                content = designMode ? this.DesignTimeView() : EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).prototype.RenderInternal.call(this)
                            }
                            
                            var attributes = {
                                    key: "viewitem-content", className: (className || "") + (System.String.format(" form-element-wrap--{0}", [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4(TViewItem, TInputs, TContext, TController).viewItemName]) || ""), ref: Bridge.fn.cacheBind(this, this.SetRef)
                                };
                            
                            if (this.ViewModel$1.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactViewItemViewModel$TestIdEnabled())
                            {
                                
                                attributes.data = {testid: this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$TestId}
                            }
                            
                            if (this.ViewItem != null && ((this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseEnter != null && !this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseEnter.IsEmpty) || (this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseLeave != null && !this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseLeave.IsEmpty)))
                            {
                                
                                attributes.onMouseEnter = this.GetOnMouseEnter();
                                
                                attributes.onMouseLeave = this.GetOnMouseLeave()
                            }
                            
                            var onKeyDown = this.GetOnKeyDown();
                            
                            if (!Bridge.staticEquals(onKeyDown, null))
                            {
                                
                                attributes.tabIndex = -1;
                                
                                attributes.onKeyDown = onKeyDown
                            }
                            
                            return React.createElement('div', Bridge.React.fixAttr(attributes), content)
                        }, GetOnMouseEnter: function()
                        {
                            
                            return Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4.f1))
                        }, GetOnMouseLeave: function()
                        {
                            
                            return Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4.f2))
                        }, GetOnKeyDown: function()
                        {
                            
                            var hasOnEscape = this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEscape != null && !this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEscape.IsEmpty;
                            
                            var hasOnEnter = this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEnter != null && !this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEnter.IsEmpty;
                            
                            if (hasOnEscape || hasOnEnter)
                            {
                                
                                return Bridge.fn.bind(this, function(e)
                                    {
                                        
                                        this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$2"](Bridge.fn.bind(this, function(c)
                                        {
                                            var $step = 0,
                                                $task1,
                                                $task2,
                                                $jumpFromFinally,
                                                $tcs = new System.Threading.Tasks.TaskCompletionSource,
                                                $returnValue,
                                                $async_e,
                                                $asyncBody = Bridge.fn.bind(this, function()
                                                {
                                                    try
                                                    {
                                                        for (; ; )
                                                        {
                                                            $step = System.Array.min([0, 1, 2, 3, 4, 5, 6], $step);
                                                            switch ($step)
                                                            {
                                                                case 0:
                                                                    {
                                                                        
                                                                        if (Bridge.referenceEquals(e.key, Bridge.React.KeyboardEvent.NamedKeys.escape) && hasOnEscape)
                                                                        {
                                                                            $step = 1;
                                                                            continue
                                                                        }
                                                                        $step = 3;
                                                                        continue
                                                                    }
                                                                case 1:
                                                                    {
                                                                        
                                                                        $task1 = this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEscape.Call();
                                                                        $step = 2;
                                                                        if ($task1.isCompleted())
                                                                            continue;
                                                                        $task1.continue($asyncBody);
                                                                        return
                                                                    }
                                                                case 2:
                                                                    {
                                                                        $task1.getAwaitedResult();
                                                                        
                                                                        e.stopPropagation();
                                                                        $step = 3;
                                                                        continue
                                                                    }
                                                                case 3:
                                                                    {
                                                                        
                                                                        if (Bridge.referenceEquals(e.key, Bridge.React.KeyboardEvent.NamedKeys.enter) && hasOnEnter)
                                                                        {
                                                                            $step = 4;
                                                                            continue
                                                                        }
                                                                        $step = 6;
                                                                        continue
                                                                    }
                                                                case 4:
                                                                    {
                                                                        
                                                                        $task2 = this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnEnter.Call();
                                                                        $step = 5;
                                                                        if ($task2.isCompleted())
                                                                            continue;
                                                                        $task2.continue($asyncBody);
                                                                        return
                                                                    }
                                                                case 5:
                                                                    {
                                                                        $task2.getAwaitedResult();
                                                                        
                                                                        e.stopPropagation();
                                                                        $step = 6;
                                                                        continue
                                                                    }
                                                                case 6:
                                                                    {
                                                                        $tcs.setResult(null);
                                                                        return
                                                                    }
                                                                default:
                                                                    {
                                                                        $tcs.setResult(null);
                                                                        return
                                                                    }
                                                            }
                                                        }
                                                    }
                                                    catch($async_e1)
                                                    {
                                                        $async_e = System.Exception.create($async_e1);
                                                        $tcs.setException($async_e)
                                                    }
                                                }, arguments);
                                            if (mobx._getGlobalState().allowStateChanges)
                                            {
                                                $asyncBody = mobx.action($asyncBody)
                                            }
                                            $asyncBody();
                                            return $tcs.task
                                        }))
                                    })
                            }
                            
                            return null
                        }, DesignTimeView: function()
                        {
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, TController).prototype.RenderInternal.call(this)
                        }, RenderWrappedChildren: function(condition, caption)
                        {
                            var $t;
                            if (condition === void 0)
                            {
                                condition = null
                            }
                            if (caption === void 0)
                            {
                                caption = ""
                            }
                            
                            var metadataViewModel;
                            
                            var designMode = ((metadataViewModel = Bridge.as(this.ViewModel$1.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null && metadataViewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$IsDesignMode;
                            
                            if (!designMode)
                            {
                                
                                return React.createElement(React.Fragment, null, System.Linq.Enumerable.from(this.GetChildren(condition)).ToArray())
                            }
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(this.ViewModel$1.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactService$ReactComponentCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent, ($t = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, $t.ViewItem = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4.f3)), $t.Caption = function()
                                    {
                                        return caption
                                    }, $t.Content = Bridge.fn.bind(this, function()
                                    {
                                        return this.GetChildren(condition)
                                    }), $t), this.ViewModel$1.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$RenderOwner))
                        }, RenderChildren: function(condition)
                        {
                            if (condition === void 0)
                            {
                                condition = null
                            }
                            
                            return this.GetChildren(condition)
                        }, InitDebounce: function(action, timeout)
                        {
                            if (timeout === void 0)
                            {
                                timeout = 300
                            }
                            
                            if (action == null)
                            {
                                
                                return Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4.f4)
                            }
                            
                            return Bridge.fn.bind(this, function(value)
                                {
                                    
                                    if (this.timeoutId !== 0)
                                    {
                                        
                                        window.clearTimeout(this.timeoutId);
                                        
                                        this.timeoutId = 0
                                    }
                                    else
                                    {
                                        
                                        this.timeoutId = window.setTimeout(Bridge.fn.bind(this, function()
                                        {
                                            
                                            this.timeoutId = 0;
                                            
                                            this.Dispatcher["EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IComponentDispatcher$1$" + Bridge.getTypeAlias(TController) + "$Dispatch$3"](Bridge.fn.bind(this, function(c)
                                            {
                                                
                                                this.OnMouseEvent(action)
                                            }))
                                        }), timeout)
                                    }
                                })
                        }, OnMouseEvent: function(action)
                        {
                            
                            if (action != null && !action.IsEmpty)
                            {
                                
                                action.Call()
                            }
                        }, GetChildren: function(condition)
                        {
                            if (condition === void 0)
                            {
                                condition = null
                            }
                            
                            var input = Bridge.as(this.InputModel["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"], EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs);
                            
                            if (input != null)
                            {
                                
                                return this.PrepareChildren(input.Children, condition)
                            }
                            
                            var inputFunc = Bridge.as(this.InputModel["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"], EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildrenFunc);
                            
                            if (inputFunc != null)
                            {
                                
                                return this.PrepareChildren(inputFunc.Children(null), condition)
                            }
                            
                            var inputChildren = Bridge.as(this.InputModel["EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"], EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputsChildren);
                            
                            if (inputChildren != null)
                            {
                                
                                return this.PrepareChildren(inputChildren.Children, condition)
                            }
                            
                            return System.Array.init(0, null, Object)
                        }, PrepareChildren: function(children, condition)
                        {
                            var $t;
                            
                            if (Bridge.staticEquals(condition, null))
                            {
                                
                                return children
                            }
                            
                            var result = System.Array.init(0, null, Object);
                            
                            $t = Bridge.getEnumerator(children);
                            try
                            {
                                while ($t.moveNext())
                                {
                                    var child = $t.Current;
                                    
                                    if (!condition(child))
                                    {
                                        
                                        continue
                                    }
                                    
                                    
                                    result.push(child)
                                }
                            }
                            finally
                            {
                                if (Bridge.is($t, System.IDisposable))
                                {
                                    $t.System$IDisposable$Dispose()
                                }
                            }
                            
                            return result
                        }, SetRef: function(el)
                        {
                            
                            this.ContentElement = el
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4, {
    f1: function(e)
    {
        
        this.InitDebounce(this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseEnter)(e)
    }, f2: function(e)
        {
            
            this.InitDebounce(this.ViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$OnMouseLeave)(e)
        }, f3: function()
        {
            return this.ViewItem
        }, f4: function(ev){}
});
Bridge.definei("EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$1", EleWise_ELMA_Core_React, function(TViewItem)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel], $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemInputModel$2", EleWise_ELMA_Core_React, function(TViewItem, TInputs)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel$1(TInputs), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs)], $metadata: function()
                {
                    return {
                            att: 1048832, a: 4, m: [{
                                        a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 2, n: "ViewItem", t: 16, rt: TViewItem, g: {
                                                a: 2, n: "get_ViewItem", t: 8, rt: TViewItem, fg: "ViewItem"
                                            }, s: {
                                                a: 2, n: "set_ViewItem", t: 8, p: [TViewItem], rt: System.Void, fs: "ViewItem"
                                            }, fn: "ViewItem"
                                    }, {
                                        a: 1, backing: true, n: "<ViewItem>k__BackingField", t: 4, rt: TViewItem, sn: "ViewItem"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {ViewItem: Bridge.getDefaultValue(TViewItem)}, props: {EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemInputModel$ViewItem: {
                        get: function()
                        {
                            
                            return this.ViewItem
                        }, set: function(value)
                            {
                                
                                this.ViewItem = Bridge.cast(Bridge.unbox(value, TViewItem), TViewItem)
                            }
                    }}, alias: ["ViewItem", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemInputModel$2$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$ViewItem$1", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs", "Inputs$1", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$1$" + Bridge.getTypeAlias(TInputs) + "$Inputs$1"]
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemViewModel$3", EleWise_ELMA_Core_React, function(TViewItem, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel$2(TContext, TController), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemViewModel], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData], pi: [{
                                                    n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                                }, {
                                                    n: "viewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                                }, {
                                                    n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                                }, {
                                                    n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                                }, {
                                                    n: "applicationData", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData, ps: 4
                                                }], sn: "ctor"
                                    }, {
                                        a: 3, n: "CreateHideableModel", t: 8, sn: "CreateHideableModel", rt: System.Void
                                    }, {
                                        ov: true, a: 2, n: "Destroy", t: 8, sn: "Destroy", rt: System.Threading.Tasks.Task
                                    }, {
                                        ov: true, a: 3, n: "GenerateController", t: 8, pi: [{
                                                    n: "typeController", pt: System.Type, ps: 0
                                                }], sn: "GenerateController", rt: System.Void, p: [System.Type]
                                    }, {
                                        a: 1, n: "IsViewItemDesignModeDeep", t: 8, pi: [{
                                                    n: "viewItemCheck", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                                }], sn: "IsViewItemDesignModeDeep", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem], box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        a: 2, n: "TestIdEnabled", t: 8, sn: "TestIdEnabled", rt: System.Boolean, box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        ov: true, a: 2, n: "Component", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, g: {
                                                ov: true, a: 2, n: "get_Component", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, fg: "Component"
                                            }, fn: "Component"
                                    }, {
                                        a: 2, n: "HideEmptyModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, g: {
                                                a: 2, n: "get_HideEmptyModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, fg: "HideEmptyModel"
                                            }, fn: "HideEmptyModel"
                                    }, {
                                        v: true, a: 2, n: "IsDesignModeDeep", t: 16, rt: System.Boolean, g: {
                                                v: true, a: 2, n: "get_IsDesignModeDeep", t: 8, rt: System.Boolean, fg: "IsDesignModeDeep", box: function($v)
                                                    {
                                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                                    }
                                            }, fn: "IsDesignModeDeep"
                                    }, {
                                        ov: true, a: 2, n: "Ready", t: 16, rt: System.Boolean, g: {
                                                ov: true, a: 2, n: "get_Ready", t: 8, rt: System.Boolean, fg: "Ready", box: function($v)
                                                    {
                                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                                    }
                                            }, fn: "Ready"
                                    }, {
                                        a: 2, n: "ViewItem", t: 16, rt: TViewItem, g: {
                                                a: 2, n: "get_ViewItem", t: 8, rt: TViewItem, fg: "ViewItem"
                                            }, fn: "ViewItem"
                                    }, {
                                        a: 3, n: "ViewItemInputModel", t: 16, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel, g: {
                                                a: 3, n: "get_ViewItemInputModel", t: 8, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel, fg: "ViewItemInputModel"
                                            }, fn: "ViewItemInputModel"
                                    }, {
                                        a: 1, n: "applicationData", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData, sn: "applicationData", ro: true
                                    }, {
                                        a: 1, n: "componentSettings", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentContainer, sn: "componentSettings$1"
                                    }, {
                                        a: 1, n: "dispatcher", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, sn: "dispatcher$1", ro: true
                                    }, {
                                        a: 1, n: "hideEmptyModel", t: 4, rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyModel, sn: "hideEmptyModel"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
                    componentSettings$1: null, dispatcher$1: null, applicationData: null, hideEmptyModel: null
                }, props: {
                    ViewItemInputModel: {get: function()
                        {
                            
                            return Bridge.cast(this.InputModel, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel)
                        }}, Ready: {get: function()
                            {
                                
                                return true
                            }}, ViewItem: {get: function()
                            {
                                
                                if (this.ViewItemInputModel == null)
                                {
                                    
                                    return Bridge.getDefaultValue(TViewItem)
                                }
                                
                                return Bridge.cast(Bridge.unbox(this.ViewItemInputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemInputModel$ViewItem, TViewItem), TViewItem)
                            }}, Component: {get: function()
                            {
                                
                                if (this.componentSettings$1 == null)
                                {
                                    
                                    this.componentSettings$1 = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemComponentContainer(this)
                                }
                                
                                return this.componentSettings$1
                            }}, IsDesignModeDeep: {get: function()
                            {
                                
                                return this.IsViewItemDesignModeDeep(this.ViewItem)
                            }}, EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem: {get: function()
                            {
                                
                                return this.ViewItem
                            }}, HideEmptyModel: {get: function()
                            {
                                
                                return this.hideEmptyModel
                            }}
                }, alias: ["Ready", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Ready", "Component", "EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Component", "TestIdEnabled", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IReactViewItemViewModel$TestIdEnabled", "HideEmptyModel", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemViewModel$HideEmptyModel"], ctors: {ctor: function(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel$2(TContext, TController).ctor.call(this, viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher);
                        
                        this.dispatcher$1 = dispatcher;
                        
                        this.applicationData = applicationData
                    }}, methods: {
                    TestIdEnabled: function()
                    {
                        
                        var developApplicationData;
                        
                        return ((developApplicationData = Bridge.as(this.applicationData, EleWise_ELMA_Core.EleWise.ELMA.Model.IDevelopApplicationData))) != null && developApplicationData.EleWise_ELMA_Core$EleWise$ELMA$Model$IDevelopApplicationData$TestMode === EleWise_ELMA_Core.EleWise.ELMA.Model.TestMode.AutoTest
                    }, GenerateController: function(typeController)
                        {
                            
                            if (typeController == null || Bridge.Reflection.isInterface(typeController))
                            {
                                
                                return
                            }
                            
                            this.controller = this.ViewModelCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IViewModelCreatorService$ControllerCreator(typeController, this.Context$1, this, this.ViewItem);
                            
                            this.CreateDispatcher(typeController);
                            
                            if (this.IsDesignModeDeep)
                            {
                                
                                return
                            }
                            
                            this.dispatcher$1.EleWise_ELMA_Core$EleWise$ELMA$Dispatcher$IDispatcher$Dispatch(new EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.ActionCommand(EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.ControllerAsyncConstants.CommandName, "", [this.controller, Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$3.f1))]))
                        }, Destroy: function()
                        {
                            
                            if (this.HideEmptyModel != null)
                            {
                                
                                this.HideEmptyModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Destroy()
                            }
                            
                            return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewModel$2(TContext, TController).prototype.Destroy.call(this)
                        }, CreateHideableModel: function()
                        {
                            
                            var containerStorage;
                            
                            var hideEmptyViewItem;
                            
                            if (((containerStorage = Bridge.as(this.RenderOwner, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IHideEmptyViewItemContainer))) != null && ((hideEmptyViewItem = Bridge.as(this.ViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IHideEmptyViewItem))) != null)
                            {
                                
                                var owner = containerStorage.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$FindOwner(this.ViewItem);
                                
                                if (containerStorage.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainerModel$IsHideEmpty(this.ViewItem))
                                {
                                    
                                    var hideable;
                                    
                                    if (hideEmptyViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IHideEmptyViewItem$IsHideable && ((hideable = Bridge.as(this.controller, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IHideable))) != null)
                                    {
                                        
                                        this.hideEmptyModel = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemHideEmptyModel(this.RenderOwner, hideable, owner)
                                    }
                                    else if (!hideEmptyViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IHideEmptyViewItem$IsHideable)
                                    {
                                        
                                        this.hideEmptyModel = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.HideEmptyContainerModel(containerStorage.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyViewItemContainer$HideEmptyViewItemContainer, this.ViewItem, owner)
                                    }
                                }
                                else if (hideEmptyViewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IHideEmptyViewItem$HideEmpty === EleWise_ELMA_Core.EleWise.ELMA.Model.Views.HideEmptyEnum.ShowEmpty)
                                {
                                    
                                    this.hideEmptyModel = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ShowEmptyModel(owner)
                                }
                                
                                if (this.hideEmptyModel != null)
                                {
                                    
                                    this.hideEmptyModel.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Models$IHideEmptyModel$Init()
                                }
                            }
                        }, IsViewItemDesignModeDeep: function(viewItemCheck)
                        {
                            
                            var componentViewItem;
                            
                            if (((componentViewItem = Bridge.as(viewItemCheck, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ComponentViewItem))) != null && componentViewItem.ViewMode === EleWise_ELMA_Core.EleWise.ELMA.Model.InterfaceBuilderViewMode.Design)
                            {
                                
                                return true
                            }
                            
                            var componentOwner;
                            
                            return ((componentOwner = Bridge.as(this.RenderOwner, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IMetadataViewModel))) != null && (componentOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$IsDesignMode || componentOwner.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IMetadataViewModel$IsDesignModeDeep)
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$3", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$3, {f1: function()
    {
        
        this.CreateValidation();
        
        this.CreateHideableModel();
        
        return System.Threading.Tasks.Task.CompletedTask
    }});
Bridge.define("EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext], $kind: "nested class", $metadata: function()
        {
            return {
                    td: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent, att: 1048578, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputComponent$1", EleWise_ELMA_Core_React, function(TM)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3(TM, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseContext$1(TM), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM))], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM)), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3(TM, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseContext$1(TM), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseInputComponent$2", EleWise_ELMA_Core_React, function(TM, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3(TM, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseContext$1(TM), TController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM))], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputs$1(TM)), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseInputComponent$3(TM, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseContext$1(TM), TController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactController", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.Controller$1(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext)], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React"
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactComponent$1", EleWise_ELMA_Core_React, function(TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, TController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, TController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseViewItemComponent$2", EleWise_ELMA_Core_React, function(TViewItem, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, TController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, TController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.ViewItemRenderer$5", EleWise_ELMA_Core_React, function(TViewItem, TComponent, TInputs, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute], m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                                    n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        ov: true, a: 2, sl: true, n: "CanRender", t: 8, pi: [{
                                                    n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                                }], sn: "CanRender", rt: System.Boolean, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem], box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        v: true, a: 2, n: "CanRender", t: 8, pi: [{
                                                    n: "viewItem", pt: TViewItem, ps: 0
                                                }], sn: "CanRender$1", rt: System.Boolean, p: [TViewItem], box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        ov: true, a: 3, n: "GetInputsTypeComponent", t: 8, pi: [{
                                                    n: "typeComponent", pt: System.Type, ps: 0
                                                }], sn: "GetInputsTypeComponent", rt: System.Type, p: [System.Type]
                                    }, {
                                        ov: true, a: 3, n: "GetTypeComponent", t: 8, pi: [{
                                                    n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem, ps: 0
                                                }], sn: "GetTypeComponent", rt: System.Type, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.ViewItem]
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["CanRender", "EleWise_ELMA_Core_UI$EleWise$ELMA$Core$UI$Renderers$IViewItemRenderer$CanRender"], ctors: {ctor: function(currentScope)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer.ctor.call(this, currentScope)
                    }}, methods: {
                    CanRender$1: function(viewItem)
                    {
                        
                        return Bridge.referenceEquals(Bridge.getType(viewItem, TViewItem), TViewItem)
                    }, CanRender: function(viewItem)
                        {
                            
                            var item;
                            
                            return ((item = Bridge.as(viewItem, TViewItem))) != null && this.CanRender$1(item)
                        }, GetTypeComponent: function(viewItem)
                        {
                            
                            return TComponent
                        }, GetInputsTypeComponent: function(typeComponent)
                        {
                            
                            return TInputs
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemViewModel$1", EleWise_ELMA_Core_React, function(TViewItem)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$3(TViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData], pi: [{
                                                    n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                                }, {
                                                    n: "viewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                                }, {
                                                    n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                                }, {
                                                    n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                                }, {
                                                    n: "applicationData", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData, ps: 4
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$3(TViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController).ctor.call(this, viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperController", {
    inherits: [EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.Controller$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext), EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IRequireOwnerController], $kind: "nested class", $metadata: function()
        {
            return {
                    td: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent, att: 1048578, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper)], pi: [{
                                            n: "elementWrappers", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper), ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 4, n: "CreateModel", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "slotName", pt: System.String, ps: 1
                                        }, {
                                            n: "caption", dv: null, o: true, pt: System.String, ps: 2
                                        }], sn: "CreateModel", rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.IWrapModel, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, System.String, System.String]
                            }, {
                                a: 2, n: "GetElementWrapper", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "wrapperType", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType, ps: 1
                                        }], sn: "GetElementWrapper", rt: System.Type, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType]
                            }, {
                                a: 2, n: "SetOwner", t: 8, pi: [{
                                            n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                        }], sn: "SetOwner", rt: System.Void, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel]
                            }, {
                                a: 1, n: "currentViewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "currentViewModel"
                            }, {
                                a: 1, n: "elementWrappers", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper), sn: "elementWrappers", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", fields: {
            elementWrappers: null, currentViewModel: null
        }, alias: ["SetOwner", "EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IRequireOwnerController$SetOwner"], ctors: {ctor: function(elementWrappers)
            {
                this.$initialize();
                EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.Controller$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext).ctor.call(this);
                
                this.elementWrappers = elementWrappers
            }}, methods: {
            SetOwner: function(owner)
            {
                
                this.currentViewModel = owner
            }, GetElementWrapper: function(viewItem, wrapperType)
                {
                    
                    var wrapper = System.Linq.Enumerable.from(this.elementWrappers, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper).firstOrDefault(Bridge.fn.bind(this, function(r)
                        {
                            return r.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$CanWrap(viewItem, this.currentViewModel, wrapperType)
                        }), null);
                    
                    return wrapper != null ? wrapper.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$ExtensionPoints$IElementWrapper$Type : null
                }, CreateModel: function(viewItem, slotName, caption)
                {
                    if (caption === void 0)
                    {
                        caption = null
                    }
                    
                    var model = caption == null ? new EleWise_ELMA_Core.EleWise.ELMA.Core.Model.WrapModel.$ctor2(viewItem, slotName) : new EleWise_ELMA_Core.EleWise.ELMA.Core.Model.WrapModel.$ctor3(viewItem, slotName, caption);
                    
                    var unknownTypeViewItem;
                    
                    if (System.String.isNullOrWhiteSpace(caption) && ((unknownTypeViewItem = Bridge.as(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.Views.UnknownTypeViewItem))) != null)
                    {
                        
                        model.Caption = unknownTypeViewItem.GetTypeName()
                    }
                    
                    return model
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactComponent$2", EleWise_ELMA_Core_React, function(TInputs, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(TInputs, TContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseViewItemComponent$3", EleWise_ELMA_Core_React, function(TViewItem, TInputs, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4(TViewItem, TInputs, TContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, TInputs), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$4(TViewItem, TInputs, TContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactController).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.ViewItemRenderer$2", EleWise_ELMA_Core_React, function(TViewItem, TComponent)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer$5(TViewItem, TComponent, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                                    n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(currentScope)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer$5(TViewItem, TComponent, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController).ctor.call(this, currentScope)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.ViewItemRenderer$4", EleWise_ELMA_Core_React, function(TViewItem, TComponent, TInputs, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer$5(TViewItem, TComponent, TInputs, TContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                                    n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(currentScope)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.ViewItemRenderer$5(TViewItem, TComponent, TInputs, TContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController).ctor.call(this, currentScope)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Models.ViewItemViewModel", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem)], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData], pi: [{
                                            n: "viewModelCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IViewModelCreatorService, ps: 0
                                        }, {
                                            n: "viewItemComponentCreatorService", pt: EleWise_ELMA_Core.EleWise.ELMA.Ioc.ILazy$1(EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService), ps: 1
                                        }, {
                                            n: "reactComponentCreatorService", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Services.IReactComponentCreatorService, ps: 2
                                        }, {
                                            n: "dispatcher", pt: EleWise_ELMA_Core.EleWise.ELMA.Dispatcher.IDispatcher, ps: 3
                                        }, {
                                            n: "applicationData", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.IApplicationData, ps: 4
                                        }], sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.ViewItemViewModel$1(EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem).ctor.call(this, viewModelCreatorService, viewItemComponentCreatorService, reactComponentCreatorService, dispatcher, applicationData)
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Views.WrapperComponent", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperController)], $metadata: function()
        {
            return {
                    nested: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperController], att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs)], pi: [{
                                            n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs), ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 3, n: "InnerWrap", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "slotName", pt: System.String, ps: 1
                                        }, {
                                            n: "caption", pt: System.String, ps: 2
                                        }, {
                                            n: "elements", ip: true, pt: System.Array.type(Object), ps: 3
                                        }], sn: "InnerWrap", rt: Object, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, System.String, System.String, System.Array.type(Object)]
                            }, {
                                a: 3, n: "OuterWrap", t: 8, pi: [{
                                            n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                        }, {
                                            n: "slotName", pt: System.String, ps: 1
                                        }, {
                                            n: "elements", ip: true, pt: System.Array.type(Object), ps: 2
                                        }], sn: "OuterWrap", rt: Object, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, System.String, System.Array.type(Object)]
                            }, {
                                ov: true, a: 2, n: "View", t: 8, sn: "View", rt: Object
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$3(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentContext, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperController).ctor.call(this, model)
            }}, methods: {
            View: function()
            {
                var $t,
                    $t1;
                
                var slotName = !Bridge.staticEquals(($t = this.Context.SlotName), null) ? $t() : null;
                
                var caption = !Bridge.staticEquals(($t1 = this.Context.Caption), null) ? $t1() : null;
                
                var elements = System.Linq.Enumerable.from(this.Context.Content(), Object).select(Bridge.fn.bind(this, function(child)
                    {
                        return this.OuterWrap(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.GetViewItem$1(child), slotName, [child])
                    })).ToArray(Object);
                
                return this.InnerWrap(this.Context.ViewItem(), slotName, caption, elements)
            }, OuterWrap: function(viewItem, slotName, elements)
                {
                    var $t;
                    if (elements === void 0)
                    {
                        elements = []
                    }
                    
                    if (viewItem == null)
                    {
                        
                        return React.createElement(React.Fragment, {key: "WrapperComponent_OuterWrap"}, System.Linq.Enumerable.from(elements).ToArray())
                    }
                    
                    var wrapper = this.Controller.GetElementWrapper(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType.Outer);
                    
                    if (wrapper == null)
                    {
                        
                        return React.createElement(React.Fragment, {key: "WrapperComponent_OuterWrap" + (this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key || "") + (viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Uid.toString() || "")}, System.Linq.Enumerable.from(elements).ToArray())
                    }
                    
                    return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(this.ViewModel.ReactComponentCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create(wrapper, ($t = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.WrapperInputs, $t.Key = "WrapperComponent_OuterWrap" + (this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key || "") + (viewItem.EleWise_ELMA_Core$EleWise$ELMA$Model$Views$IViewItem$Uid.toString() || ""), $t.WrapModel = Bridge.fn.bind(this, function()
                            {
                                return this.Controller.CreateModel(viewItem, slotName)
                            }), $t.Children = elements, $t), this.ViewModel.RenderOwner))
                }, InnerWrap: function(viewItem, slotName, caption, elements)
                {
                    var $t;
                    if (elements === void 0)
                    {
                        elements = []
                    }
                    
                    var wrapper = this.Controller.GetElementWrapper(viewItem, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.ElementWrapperType.Inner);
                    
                    if (wrapper == null)
                    {
                        
                        return React.createElement(React.Fragment, {key: "WrapperComponent_InnerWrap" + (this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key || "")}, System.Linq.Enumerable.from(elements).ToArray())
                    }
                    
                    return EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Helpers.ConvertReactElementHelper.ToReactElement(this.ViewModel.ReactComponentCreatorService.EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Services$IReactComponentCreatorService$Create(wrapper, ($t = new EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.WrapperInputs, $t.Key = "WrapperComponent_InnerWrap" + (this.InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Key || ""), $t.WrapModel = Bridge.fn.bind(this, function()
                            {
                                return this.Controller.CreateModel(viewItem, slotName, caption)
                            }), $t.Children = elements, $t), this.ViewModel.RenderOwner))
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactComponent", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$2(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context)], $metadata: function()
        {
            return {
                    att: 1048705, a: 2, m: [{
                                a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs)], pi: [{
                                            n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs), ps: 0
                                        }], sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactComponent$2(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context).ctor.call(this, model)
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseReactRenderer$3", EleWise_ELMA_Core_React, function(TComponent, TInputs, TContext)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope], pi: [{
                                                    n: "currentScope", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.ILifetimeScope, ps: 0
                                                }], sn: "ctor"
                                    }, {
                                        ov: true, a: 2, n: "CanRender", t: 8, pi: [{
                                                    n: "typeComponent", pt: System.Type, ps: 0
                                                }], sn: "CanRender", rt: System.Boolean, p: [System.Type], box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, {
                                        a: 3, n: "CreateInputModel", t: 8, sn: "CreateInputModel$1", rt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(TInputs)
                                    }, {
                                        v: true, a: 3, n: "InitViewModel", t: 8, pi: [{
                                                    n: "inputs", pt: TInputs, ps: 0
                                                }], sn: "InitViewModel", rt: TInputs, p: [TInputs]
                                    }, {
                                        v: true, a: 2, n: "Render", t: 8, pi: [{
                                                    n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 0
                                                }, {
                                                    n: "inputs", pt: TInputs, ps: 1
                                                }], sn: "Render$1", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, TInputs]
                                    }, {
                                        ov: true, a: 2, n: "Render", t: 8, pi: [{
                                                    n: "typeComponent", pt: System.Type, ps: 0
                                                }, {
                                                    n: "owner", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, ps: 1
                                                }, {
                                                    n: "inputs", dv: null, o: true, pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                                }], sn: "Render", rt: EleWise_ELMA_Core_UI.EleWise.ELMA.Core.UI.Model.IRenderContent, p: [System.Type, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs]
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", alias: ["CanRender", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$CanRender", "Render", "EleWise_ELMA_Core_React$EleWise$ELMA$Core$React$Components$IReactRenderer$Render"], ctors: {ctor: function(currentScope)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseReactRenderer.ctor.call(this, currentScope)
                    }}, methods: {
                    CanRender: function(typeComponent)
                    {
                        
                        return Bridge.referenceEquals(typeComponent, TComponent)
                    }, Render: function(typeComponent, owner, inputs)
                        {
                            if (inputs === void 0)
                            {
                                inputs = null
                            }
                            
                            return this.Render$1(owner, Bridge.cast(Bridge.unbox(inputs, TInputs), TInputs))
                        }, Render$1: function(owner, inputs)
                        {
                            
                            var typeComponent = TComponent;
                            
                            var newInputs = this.InitViewModel(inputs);
                            
                            var model = this.BaseInitViewModel(typeComponent, owner, newInputs);
                            
                            return this.CreateComponent(typeComponent, model)
                        }, CreateInputModel$1: function()
                        {
                            
                            var genericType = EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel$1.apply(null, System.Array.init([TInputs], System.Type));
                            
                            return Bridge.cast(Bridge.createInstance(genericType), EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.InputModel$1(TInputs))
                        }, InitViewModel: function(inputs)
                        {
                            
                            return inputs
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.Components.BaseViewItemComponent$1", EleWise_ELMA_Core_React, function(TViewItem)
{
    return {
            inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$3(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context)], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs)], pi: [{
                                                    n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactViewItemInputModel$2(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs), ps: 0
                                                }], sn: "ctor"
                                    }]
                        }
                }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
                    {
                        this.$initialize();
                        EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Components.BaseViewItemComponent$3(TViewItem, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Inputs, EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.Context).ctor.call(this, model)
                    }}
        }
});
Bridge.define("EleWise.ELMA.Core.React.Views.InnerWrapperComponent", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs)], pi: [{
                                            n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs), ps: 0
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 2, n: "View", t: 8, sn: "View", rt: Object
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.ctor.call(this, model)
            }}, methods: {View: function()
            {
                var $t;
                
                return this.InnerWrap(this.Context.ViewItem(), !Bridge.staticEquals(($t = this.Context.SlotName), null) ? $t() : null, "", this.Context.Content())
            }}
});
Bridge.define("EleWise.ELMA.Core.React.Views.OuterWrapperComponent", {
    inherits: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs)], pi: [{
                                            n: "model", pt: EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Models.IReactInputModel$1(EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.WrapperComponentInputs), ps: 0
                                        }], sn: "ctor"
                            }, {
                                ov: true, a: 2, n: "View", t: 8, sn: "View", rt: Object
                            }]
                }
        }, $scope: EleWise_ELMA_Core_React, $module: "EleWise_ELMA_Core_React", ctors: {ctor: function(model)
            {
                this.$initialize();
                EleWise_ELMA_Core_React.EleWise.ELMA.Core.React.Views.WrapperComponent.ctor.call(this, model)
            }}, methods: {View: function()
            {
                var $t;
                
                return this.OuterWrap(this.Context.ViewItem(), !Bridge.staticEquals(($t = this.Context.SlotName), null) ? $t() : null, this.Context.Content())
            }}
});
$asm.attr = [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAssemblyAttribute];
$asm.$$typesToRegister = [{
        TypeName: "EleWise.ELMA.Core.React.ExtensionPoints.IViewModelContextHandler", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.ExtensionPoints.IReactComponent", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.IReactRenderer", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.ViewItemRenderer", Constructor: {Arguments: ["EleWise.ELMA.Ioc.Abstract.ILifetimeScope"]}, RegistrationType: 1, Order: 2147483647, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer", Constructor: null, RegistrationType: 3, Order: 2147483647, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.ExtensionPoints.IErrorComponent", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.ExtensionPoints.IWrapComponent", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.Core.React.Services.ReactRenderService", Constructor: {Arguments: []}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.UI.Services.IRenderService", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Services.ViewItemComponentCreatorService", Constructor: {Arguments: ["System.Collections.Generic.IEnumerable$1<EleWise.ELMA.Core.UI.Renderers.IViewItemRenderer>", "EleWise.ELMA.Services.IReactiveModelFactory"]}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.BaseReactRenderer", Constructor: {Arguments: ["EleWise.ELMA.Ioc.Abstract.ILifetimeScope"]}, RegistrationType: 1, Order: 2147483647, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.React.Components.IReactRenderer", Constructor: null, RegistrationType: 3, Order: 2147483647, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Services.ReactComponentCreatorService", Constructor: {Arguments: ["System.Collections.Generic.IEnumerable$1<EleWise.ELMA.Core.React.Components.IReactRenderer>"]}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.React.Services.IReactComponentCreatorService", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Services.ViewModelCreatorService", Constructor: {Arguments: ["EleWise.ELMA.Ioc.Abstract.ILifetimeScope"]}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.React.Services.IViewModelCreatorService", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.BaseInputRenderer", Constructor: {Arguments: ["EleWise.ELMA.Ioc.Abstract.ILifetimeScope"]}, RegistrationType: 1, Order: 2147483646, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.React.Components.IReactRenderer", Constructor: null, RegistrationType: 3, Order: 2147483646, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.ErrorRenderer", Constructor: {Arguments: ["EleWise.ELMA.Ioc.Abstract.ILifetimeScope"]}, RegistrationType: 1, Order: 10, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.React.Components.IReactRenderer", Constructor: null, RegistrationType: 3, Order: 10, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Models.ViewModel", Constructor: {Arguments: ["EleWise.ELMA.Core.React.Services.IViewModelCreatorService", "EleWise.ELMA.Ioc.ILazy$1<EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService>", "EleWise.ELMA.Core.React.Services.IReactComponentCreatorService", "EleWise.ELMA.Dispatcher.IDispatcher"]}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Model.IReactive", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Models.InputModel", Constructor: {Arguments: []}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Model.IReactive", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Models.BaseInputViewModel", Constructor: {Arguments: ["EleWise.ELMA.Core.React.Services.IViewModelCreatorService", "EleWise.ELMA.Ioc.ILazy$1<EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService>", "EleWise.ELMA.Core.React.Services.IReactComponentCreatorService", "EleWise.ELMA.Dispatcher.IDispatcher"]}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Model.IReactive", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.BaseInputController", Constructor: {Arguments: []}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.Controllers.IController", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Components.BaseReactController", Constructor: {Arguments: []}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.Controllers.IController", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Views.WrapperComponent+WrapperController", Constructor: {Arguments: ["System.Collections.Generic.IEnumerable$1<EleWise.ELMA.Core.React.ExtensionPoints.IElementWrapper>"]}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Core.Controllers.IController", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.Core.React.Models.ViewItemViewModel", Constructor: {Arguments: ["EleWise.ELMA.Core.React.Services.IViewModelCreatorService", "EleWise.ELMA.Ioc.ILazy$1<EleWise.ELMA.Core.UI.Services.IViewItemComponentCreatorService>", "EleWise.ELMA.Core.React.Services.IReactComponentCreatorService", "EleWise.ELMA.Dispatcher.IDispatcher", "EleWise.ELMA.Model.IApplicationData"]}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.Model.IReactive", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }]
        Bridge.init();
        return EleWise_ELMA_Core_React;
    }));

});

//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAiZmlsZSI6ICJFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5qcyIsCiAgInNvdXJjZVJvb3QiOiAiIiwKICAic291cmNlcyI6IFsiTW9kZWxzL0Jhc2VJbnB1dHMuY3MiLCJDb21wb25lbnRzL0Jhc2VSZWFjdENvbXBvbmVudC5jcyIsIkNvbXBvbmVudHMvVmlld0l0ZW1SZW5kZXJlci5jcyIsIkhlbHBlcnMvQ29udmVydFJlYWN0RWxlbWVudEhlbHBlci5jcyIsIk1vZGVscy9Db21wb25lbnRDb250YWluZXIuY3MiLCJTZXJ2aWNlcy9SZWFjdFJlbmRlclNlcnZpY2UuY3MiLCJTZXJ2aWNlcy9WaWV3TW9kZWxDcmVhdG9yU2VydmljZS5jcyIsIlNlcnZpY2VzL1ZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2UuY3MiLCJDb21wb25lbnRzL0Fic3RyYWN0Vmlld01vZGVsQ29udGV4dEhhbmRsZXIuY3MiLCJDb21wb25lbnRzL0Jhc2VJbnB1dENvbXBvbmVudC5jcyIsIkNvbXBvbmVudHMvQmFzZVJlYWN0UmVuZGVyZXIuY3MiLCJNb2RlbHMvQmFzZUN1c3RvbVZpZXcuY3MiLCJNb2RlbHMvQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycy5jcyIsIk1vZGVscy9IaWRlRW1wdHlNb2RlbC5jcyIsIk1vZGVscy9IaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lck1vZGVsLmNzIiwiTW9kZWxzL0lucHV0Q29tcG9uZW50Q29udGFpbmVyLmNzIiwiTW9kZWxzL1Nob3dFbXB0eU1vZGVsLmNzIiwiTW9kZWxzL1ZhbGlkYXRpb25Nb2RlbC5jcyIsIk1vZGVscy9WaWV3SXRlbUNvbXBvbmVudENvbnRhaW5lci5jcyIsIlNlcnZpY2VzL1JlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UuY3MiLCJDb21wb25lbnRzL0Jhc2VJbnB1dFJlbmRlcmVyLmNzIiwiQ29tcG9uZW50cy9FcnJvclJlbmRlcmVyLmNzIiwiTW9kZWxzL1ZpZXdNb2RlbC5jcyIsIk1vZGVscy9CYXNlUmFuZ2VJbnB1dHMuY3MiLCJNb2RlbHMvQ29udGV4dENyZWF0aW9uV2l0aE1vZGVsUGFyYW1ldGVycy5jcyIsIk1vZGVscy9IaWRlRW1wdHlDb250YWluZXJNb2RlbC5jcyIsIk1vZGVscy9WaWV3SXRlbUhpZGVFbXB0eU1vZGVsLmNzIiwiTW9kZWxzL0Jhc2VJbnB1dFZpZXdNb2RlbC5jcyIsIk1vZGVscy9JbnB1dE1vZGVsLmNzIiwiQ29tcG9uZW50cy9CYXNlVmlld0l0ZW1Db21wb25lbnQuY3MiLCJNb2RlbHMvVmlld0l0ZW1JbnB1dE1vZGVsLmNzIiwiTW9kZWxzL1ZpZXdJdGVtVmlld01vZGVsLmNzIiwiVmlld3MvV3JhcHBlckNvbXBvbmVudC5jcyIsIlZpZXdzL0lubmVyV3JhcHBlckNvbXBvbmVudC5jcyIsIlZpZXdzL091dGVyV3JhcHBlckNvbXBvbmVudC5jcyJdLAogICJuYW1lcyI6IFsiIl0sCiAgIm1hcHBpbmdzIjogIjs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkFZa0JBOzs7O2dDQUNBQTs7Ozs7O2dDQVVGQTs7OztvQ0FJQUE7Ozs7OztnQ0FXaUNBOzs7O29DQUFnQ0E7Ozs7Ozs7OztnQ0FHOUJBOzs7d0NBQWNBOzs7OztvQ0FBd0JBOzs7d0NBQWlCQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQ3dTOUZBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkMxUEpBOzs7O3dCQU1BQTs7Ozt3QkFNQUE7Ozs7d0JBTUFBOzs7Ozs7Z0JBU0lBOzs7OztnQkFNQUE7Ozs7Ozs7O29CQU1BQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7d0JBRUlBOzs7b0JBRWhCQTs7O3dCQUVJQTs7OzRCQUVJQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7O3dCQUlSQTs7OzRCQUVJQTs7O2dDQUVJQTs7O29DQUVJQTs7b0NBQ0FBOztvQ0FDQUE7O29DQUNBQTs7b0NBQ0FBOzs7Z0NBSUpBOzs7O3dCQUlSQTs7OzRCQUVJQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7OztvQkFLQUE7O29CQUNBQTs7OztvQkFLWkE7O29CQUFzQ0E7Ozt3QkFFdEJBOzs7Ozs7b0JBSUpBOzs7OztvQkFLQUE7O29CQUNBQTs7Ozs7Ozs0QkFFSUE7Ozs7Ozs7Ozs7O29CQUVKQTs7Ozs7Ozs7Ozs7OztvQkFLQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUVBQTs7OztvQkFLQUE7O29CQUNBQTs7b0JBQ0FBOzs7O29CQUtBQTs7b0JBQ0FBOzs7O29CQUtBQTs7b0JBQ0FBOztvQkFDQUE7Ozs0QkFFSUE7OzRCQUNBQTs7NEJBQ0FBOzs7OztvQkFNSkE7Ozs7b0JBS0FBOztvQkFFQUE7O29CQUNBQTs7b0JBRUFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQ2pPQUE7Ozt3QkFFSUE7OztvQkFHSkE7O29CQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0REFLQUE7Ozs7Ozs7Ozs7OzREQUVJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7OzREQUNJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0REFXUkE7Ozs7Ozs7Ozs7OzREQUVJQTs7Ozs7NERBR0pBOzs7Ozs7Ozs7Ozs0REFFSUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0REFFSUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQVFSQTs7Ozt3QkFVQUE7Ozs7d0JBVUFBOzt3QkFDQUE7Ozs0QkFFSUE7Ozt3QkFHSkE7O3dCQUNBQTs7OzRCQUVJQTs7Ozs7O3dCQUdKQTs7Ozt3QkFVQUE7O3dCQUNBQTs7OzRCQUVJQTs7O3dCQUdKQTs7Ozt3QkFVQUE7O3dCQUNBQTs7Ozt3QkFXQUE7Ozs7d0JBVUFBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDekhKQTs7Ozt3QkFxQlJBOzt3QkFBeURBOzs7O3dCQVFqREE7Ozs7d0JBT0FBOzs7O3dCQWNBQTs7Ozs7O2dCQTFESUE7O2dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQ0RBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDMlZBQTs7Z0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkN6VkFBOztnQkFDQUE7Ozs7Ozs7OztnQkFLQUE7O2dCQUVBQTs7Ozs7Z0JBQ0FBOzs7b0JBRUlBOzs7Z0JBR0pBOzs7Ozs7OztvQkFLQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFFQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QkM2bUJBQTs7OzRCQUVJQTs7O3dCQUVoQkE7Ozs0QkFFSUE7OzRCQUNBQTs7O2dDQUVJQTs7Ozt3Q0FHUUE7Ozs7OzRCQUtaQTs7O2dDQUVJQTs7Ozt3Q0FHUUE7Ozs7OzRCQUtaQTs7O2dDQUVJQTs7Ozt3Q0FHUUE7Ozs7Ozs7b0NBT0pBOzs7Ozt3QkFLQUE7Ozs7NEJBcVJBQTs7NEJBRUFBOzs7Z0NBRVpBOztnQ0FBNkNBOzs7b0NBRXpCQTs7Ozs7b0NBT0FBOzs7Ozs7Z0NBUUpBOzs7Ozs7Ozs7O2dCQTE2QkpBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ0FBOzs7Ozs7O2dCQXFCQUE7O2dCQUNBQTs7Z0JBQ1pBOztnQkFBaURBOzs7b0JBRWpDQTs7O2dCQUdKQTs7O29CQUVJQTs7O2dCQUdKQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7O29CQUVJQTs7b0JBQ0FBOztvQkFDQUE7Ozt3QkFFSUE7OztvQkFHSkE7O29CQUdBQTs7Ozs7Ozs7b0JBRUFBOzs7d0JBRUlBOzs7NEJBRUlBOzs0QkFDQUE7OztnQ0FFSUE7Ozs0QkFFSkE7Ozs7OzRCQUNBQTs7O3dCQUdKQTs7OzRCQUVJQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7b0NBRUlBOzs7OztvQ0FJQUE7Ozs7OztnQ0FLSkE7Ozs7Ozs0QkFLSkE7Ozt3QkFFSkE7Ozs7Z0JBSVJBOzs7b0JBRUlBOztvQkFDQUE7Ozt3QkFFSUE7OztvQkFFSkE7Ozs7O29CQUNBQTs7O2dCQUdKQTs7Z0JBQ0FBOzs7b0JBRUlBOzs7Z0JBRWhCQTs7Z0JBQ1lBOzs7b0JBRUlBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVJQTs7O2dDQUVJQTs7O29DQUVJQTs7O2dDQUdKQTs7Z0NBQ0FBOzs7b0NBRUlBOzs7OztvQ0FJQUE7Ozs7d0JBSVJBOzt3QkFDQUE7O3dCQUNBQTs7OzRCQUVJQTs7NEJBQ0FBOzs7d0JBRXhCQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNvQkE7O3dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7O29CQTJCSkE7O29CQUNBQTs7Ozs7O29CQVdoQkE7O29CQUF3REE7Ozt3QkFFeENBOzs7b0JBRWhCQTs7b0JBQ1lBOzs7d0JBRUlBOzs7b0JBR0pBOztvQkFDQUE7Ozs7Ozs7NEJBRVpBOzs0QkFBcUdBOzs7Z0NBRWpGQTs7Z0NBQ0FBOztnQ0FDQUE7Ozs7O2dDQUNBQTs7O29DQUVJQTs7Ozs7O2dDQUdKQTs7Z0NBQ0FBOztnQ0FDQUE7O2dDQUNBQTs7O29DQUVJQTs7O2dDQUdKQTs7Z0NBQ0FBOzs7O2dDQU1BQTs7Ozs7Z0NBQ0FBOzs7NEJBR0pBOzs7Z0NBRUlBOzs7NEJBR0pBOzs0QkFDQUE7OzRCQUNBQTs7O2dDQUVJQTs7OzRCQUdKQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7NEJBR0pBOzs0QkFFQUE7Ozs7Ozs7Ozs7O29CQUdKQTs7Ozs7OztvQkFXQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7O3dCQUVJQTs7O29CQUVoQkE7O29CQUNZQTs7O3dCQUVJQTs7O29CQUVoQkE7O29CQUNZQTs7O3dCQUVJQTs7Ozs7OztnQ0FFSUE7Ozs7Ozs7Ozs7OztvQkFJUkE7O29CQUNBQTs7Ozs7Ozs0QkFFSUE7OztnQ0FFSUE7Ozs0QkFHSkE7OzRCQUNBQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7NEJBRUpBOzs0QkFFQUE7OztnQ0FFSUE7Ozs0QkFHSkE7OztnQ0FFSUE7Ozs0QkFHSkE7OztnQ0FFaEJBOztnQ0FDQUE7O2dDQUNBQTs7Z0NBQ29CQTs7O29DQUVJQTs7b0NBQ0FBOzs7d0NBRUlBOzs7b0NBR0pBOztvQ0FDQUE7O29DQUNBQTs7b0NBQ0FBOztvQ0FFQUE7Ozt3Q0FFSUE7Ozs7O3dDQUlBQTs7d0NBQ0FBOzt3Q0FDQUE7Ozs0Q0FFSUE7OzRDQUNBQTs7Ozs7NENBSUFBOzs0Q0FDQUE7Ozs7OzRDQUlBQTs7NENBQ0FBOzs0Q0FDQUE7Ozs7b0NBSVJBOzs7d0NBRUlBOzs7b0NBR0pBOzs7OztnREFJUUE7OztvREFFSUE7OztnREFHSkE7O2dEQUNBQTs7Ozs7Z0RBSUFBOzs7b0RBRUlBOzs7Z0RBR0pBOztnREFDQUE7O2dEQUNBQTs7O29EQUVJQTs7O2dEQUdKQTs7Ozs7O2dEQW1CQUE7Ozs7O2dEQUlBQTs7Ozs7Z0RBSUFBOztnREFDQUE7OztvREFFSUE7OztnREFHSkE7O2dEQUNBQTs7O29EQUVJQTs7O2dEQUdKQTs7Ozs7O2dEQWlCQUE7Ozs7O2dEQUlBQTs7OztvQ0FJUkE7Ozt3Q0FFSUE7O3dDQUNBQTs7Ozt3Q0FLQUE7Ozs7Ozs7Z0NBS1JBOzs7OztnQ0FJQUE7O2dDQU9BQTs7Z0NBQ0FBOzs7b0NBRUlBOzs7Z0NBR0pBOzs7Ozs7O3dDQUVJQTs7d0NBQ0FBOzs7NENBRUlBOzs7d0NBRUpBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JBVVpBOzs7d0JBRUlBOzs7b0JBU0pBOzs7O29CQUtBQTs7b0JBQ0FBOzs7OztnQ0FJUUE7Ozs7b0NBRUlBOztvQ0FDQUE7Ozt3Q0FFSUE7OztvQ0FFNUJBOztvQ0FDd0JBOzs7d0NBRUlBOzs7b0NBR0pBOzs7Z0NBRUpBOzs7Ozs7Z0NBS0FBOzs7b0NBRUlBOztvQ0FDQUE7Ozt3Q0FFSUE7OztvQ0FHSkE7O29DQUNBQTs7b0NBQ3hCQTs7b0NBQXFEQTs7O3dDQUV6QkE7OztvQ0FNSkE7OztnQ0FLSkE7Ozs7Ozs7Ozs7OztvQkFlUkE7O29CQUNaQTs7b0JBQXdDQTs7b0JBQzVCQTs7b0JBRUFBOztvQkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkE4REFBOztvQkFDQUE7Ozt3QkFFSUE7OztvQkFFaEJBOztvQkFBd0JBOzs7d0JBRXBCQTs7d0JBQ0FBOzs7NEJBRUlBOzs7O29DQUdRQTs7b0NBQ0FBOztvQ0FDQUE7Ozs7O29DQUNBQTs7b0NBQ0FBOzs7d0NBRUlBOzt3Q0FDQUE7Ozs0Q0FFSUE7Ozs7Ozs7Ozs7Ozs7b0NBSVJBOztvQ0FDQUE7O29DQUNBQTs7b0NBQ0FBOzs7Ozt3QkFLWkE7Ozs7Z0NBR1FBOzs7O3dCQUlSQTs7OztnQ0FHUUE7Ozs7d0JBSVJBOzs7O2dDQUdRQTs7Ozs7O2dDQU1BQTs7Ozs7b0JBS0FBOzs7O29CQUtBQTs7b0JBRUFBOzs7O29CQUtBQTs7Ozs7Ozs7b0JBYUFBOzs7Ozs7Ozs7Ozs7OztvQkFjQUE7O29CQUNBQTs7b0JBQ0FBOzs7OztnQ0FJUUE7Ozs7b0NBRUlBOzs7d0NBRUlBOzt3Q0FDQUE7Ozs0Q0FFSUE7Ozs7b0NBR2hDQTs7b0NBQ3dCQTs7O3dDQUVJQTs7O29DQUdKQTs7O2dDQUVKQTs7Ozs7O2dDQUtBQTs7O29DQUVJQTs7O3dDQUVJQTs7d0NBQ0FBOzs7NENBRUlBOzs7O29DQUlSQTs7b0NBQ0FBOztvQ0FDeEJBOztvQ0FBcURBOzs7d0NBRXpCQTs7O29DQU1KQTs7O2dDQUtKQTs7OztvQkFHUkE7Ozs7O29CQUtBQTs7b0JBRUFBOztvQkFDQUE7Ozs7O2dDQUlRQTs7O29DQUVoQkE7O29DQUNBQTs7O2dDQUVnQkE7Ozs7O2dDQUlBQTs7Z0NBQ0FBOzs7Ozs7Z0NBS0FBOzs7OztnQ0FDQUE7Ozs7O2dDQUlBQTs7OztvQkFJUkE7Ozs7b0JBS1pBOztvQkFBOERBOzs7d0JBRTlDQTs7d0JBQ0FBOzs7NEJBRUlBOzs7Ozs0QkFJcEJBOzs0QkFDQUE7OzRCQUNBQTs7NEJBQ29CQTs7O2dDQUVJQTs7Ozt3QkFJUkE7O3dCQUNBQTs7OzRCQUVJQTs7O3dCQUdKQTs7d0JBQ0FBOzs7b0JBR0pBOzs7d0JBRUlBOzs7Ozt3QkFDQUE7O3dCQUNBQTs7Ozs7O29CQU1oQkE7O29CQUFpREE7Ozt3QkFFakNBOzs7b0JBRWhCQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNZQTs7OztvQkFLQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVJQTs7d0JBR0FBOzt3QkFDQUE7OztvQkFHSkE7O29CQUdBQTs7b0JBQ0FBOzs7O29CQW1MQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVJQTs7d0JBR0FBOzt3QkFDQUE7OztvQkFHSkE7O29CQUdBQTs7b0JBQ0FBOzs7Ozs7b0JBcEtBQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBRUpBOzs7OztvQkFDWkE7O29CQUF5Q0E7Ozt3QkFFekJBOzt3QkFDQUE7Ozs0QkFFSUE7Ozs7Ozs7Ozs7b0JBSVJBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQVFKQTs7b0JBV0FBOztvQkFDQUE7O29CQUNBQTs7OztvQkFjQUE7Ozt3QkFFSUE7OztvQkFHSkE7Ozs7O2dDQUlRQTs7O29DQUVJQTs7O2dDQUdKQTs7Ozs7Z0NBSUFBOzs7b0NBRUlBOzs7Z0NBR0pBOzs7b0NBRUlBOzs7Z0NBR0pBOztnQ0FDQUE7Ozs7Z0NBT0FBOztnQ0FDQUE7Ozs7Z0NBT0FBOzs7OztnQ0FJQUE7Ozs7O2dDQUlBQTs7O29DQUVJQTs7O2dDQUdKQTs7Z0NBQ0FBOztnQ0FDQUE7OztvQ0FFSUE7OztnQ0FHSkE7O2dDQUNBQTs7OztnQ0FPQUE7O2dDQUNBQTs7OztnQ0FPQUE7Ozs7O2dDQUlBQTs7OztvQkFJUkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0JDcDlCQUE7Ozs7Ozs7Ozs7OzRCQVVBQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7b0NBRUlBOzs7Z0NBR0pBOztnQ0FDQUE7OztvQ0FFSUE7OztnQ0FHSkE7Ozs0QkFHSkE7OztnQ0FFWkE7O2dDQUFnQ0E7OztvQ0FJWkE7OztnQ0FHSkE7O2dDQUNBQTs7Z0NBQ0FBOztnQ0FDQUE7O2dDQUNBQTs7O29DQUVJQTs7O2dDQUdKQTs7Z0NBQ0FBOzs7b0NBRUlBOzs7OztvQ0FJQUE7OztnQ0FFSkE7O2dDQUNBQTs7O29DQUVJQTs7b0NBS0FBOzs7d0NBR0lBOzt3Q0FJQUE7Ozs0Q0FHSUE7Ozs7b0NBS1JBOzs7d0NBR0lBOzt3Q0FLQUE7Ozs0Q0FFSUE7Ozs7OzRDQUlBQTs7Ozs7Ozs0Q0FDQUE7OzRDQUNBQTs7OztvQ0FNUkE7OztnQ0FHSkE7Ozs0QkFFSkE7Ozs7OzRCQVVBQTs7O2dDQUVJQTs7OzRCQUdKQTs7Ozs0QkFNQUE7Ozs7NEJBU0FBOzs0QkFFQUE7OzRCQUNBQTs7O2dDQUVJQTs7OzRCQUdKQTs7Ozs7Ozs7Ozs0QkFhQUE7OztnQ0FFSUE7Ozs0QkFHSkE7OzRCQUNBQTs7O2dDQUVJQTs7Ozs7Ozs7Ozs7OzRCQWVKQTs7O2dDQUVJQTs7OzRCQUdKQTs7Ozs0QkFNQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkN6UUFBOztvQkFHQUE7Ozs7d0JBTUFBOzs7Ozs7O29CQW5FSkE7Ozs7O2dCQVdJQTs7Ozs7Ozs7O2dCQU1BQTs7Z0JBQ0FBOzs7O29CQU1BQTs7Ozs7b0JBS0FBOztvQkFDQUE7Ozs7Ozs7NEJBRUlBOzs7Ozs7Ozs7OztvQkFFSkE7Ozs7Ozs7Ozs7b0JBS0FBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7b0JBRUFBOzs7O29CQUtBQTs7b0JBQ0FBOztvQkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QkNOQUE7Ozs7OzRCQWFBQTs7Ozs7Ozs7NEJBVUFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQXRFQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkNaQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDSUpBOzs7OztnQkFwQklBOztnQkFFQUE7Ozs7Z0JBS0FBOzs7OztnQkFtQkFBOztnQkFFQUE7Ozs7OztnQkFhQUE7OztvQkFFSUE7Ozs7O29CQU9KQTs7O3dCQUVJQTs7Ozs7Ozs7Ozs7OztZQXRCQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkNoQ0pBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Z0JBTUFBOzs7b0JBRUlBOzs7OztvQkFPSkE7Ozt3QkFFSUE7Ozs7O29CQU9oQkE7O29CQUEwQkE7Ozt3QkFFMUJBOzt3QkFDZ0JBOzs7NEJBRUlBOzs7Ozs7d0JBSWhCQTs7d0JBQ0FBOzs7NEJBRUlBOzs0QkFDQUE7Ozs7b0JBR0lBOzs7O29CQU1BQTs7OztvQkFNWkE7O29CQUFpREE7Ozt3QkFFakNBOzs7NEJBRUlBOzs7Ozs0QkFHaEJBOzs0QkFDQUE7OztnQ0FFSUE7OztvQ0FFSUE7Ozs7O29DQUlBQTs7b0NBQ0FBOzs7d0NBRUlBOzt3Q0FDQUE7O3dDQUNBQTs7OzRDQUVJQTs7Ozs7Ozs7b0JBT1JBOzs7O29CQU1aQTs7b0JBQ1lBOzs7d0JBRUlBOzs7b0JBR0pBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDMUZKQTs7Ozt3QkFPQUE7Ozs7d0JBT0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkNaQUE7Ozs7O2dCQVJJQTs7Z0JBQ0FBOzs7OztnQkFhQUE7OztvQkFFSUE7Ozs7O29CQU9KQTs7O3dCQUVJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQ2tCQUE7O29CQUNBQTs7O3dCQUVJQTs7OzRCQUVJQTs7NEJBQ3hCQTs7NEJBQ3dCQTs7O2dDQUVJQTs7Ozt3QkFJUkE7O3dCQUNBQTs7O29CQUdKQTs7Ozt3QkFTQUE7O3dCQUNBQTs7OzRCQUVJQTs7O3dCQUdKQTs7Ozs7O2dCQW5FSkE7O2dCQUVBQTs7Z0JBRUFBOzs7O2dCQUtBQTs7Z0JBSUFBOzs7Ozs7Ozs7Ozs7Z0JBNkRBQTs7O29CQUVJQTs7O2dCQUVKQTs7Z0JBQ0FBOzs7b0JBRUlBOzs7Z0JBR0pBOzs7b0JBRUlBOzs7Z0JBR0pBOzs7Ozs7OztvQkFVQUE7O29CQUNBQTs7b0JBQ0FBOzs7NEJBRVpBOzs0QkFDZ0JBOzs7Z0NBRUlBOzs7Ozs7Ozs7Ozs7b0JBb0JwQkE7O29CQUNZQTs7O3dCQUVJQTs7Ozs7Ozs7OztvQkFhSkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O1lBbklJQTs7OztZQUlBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkNkQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7b0JBRUFBOzs7d0JBRUlBOzt3QkFDQUE7O3dCQUNBQTs7Ozs7d0JBSUFBOzs7Ozt3QkFtQ3BCQTs7d0JBQXFEQTs7OzRCQUVqQ0E7Ozt3QkFHSkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQzVESkE7Ozs7O2dCQU1BQTs7Ozs7Z0JBQ0FBOzs7b0JBRUlBOzs7Z0JBR0pBOzs7O29CQU1BQTs7OztvQkFNQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JiakJKQTs7Ozt3QkFNQUE7Ozs7d0JBTUFBOzs7O3dCQU1BQTs7Ozs7O2dCQVVJQTs7Ozs7Ozs7OztnQkFNQUE7O2dCQUNBQTs7OztvQkFFSUE7Ozs7Ozs7Ozs7Z0JBRUpBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ1pBOztnQkFDWUE7OztvQkFFSUE7OztnQkFFaEJBOztnQkFDWUE7OztvQkFFSUE7OztnQkFHSkE7Ozs7b0JBTUFBOzs7O29CQU1BQTs7b0JBQ0FBOztvQkFDQUE7Ozs7Ozs7O29CQU1BQTs7b0JBQ1pBOztvQkFBK0NBOzs7d0JBRS9CQTs7O29CQU1KQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dEQU1BQTs7Z0RBQ0FBOzs7Ozs7Ozs7Ozs7OztnREFFSUE7Ozs7Ozs7Ozs7Ozs7Ozs7Z0RBRUNBOzs7Ozs7Ozs7OztnREFFREE7Ozs7Ozs7Ozs7Ozs7Ozs7Z0RBRUpBOztnREFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkFNQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7O3dCQUFzREE7Ozs7O29CQU10REE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7O3dCQUVJQTs7O29CQUdKQTs7b0JBQ0FBOzs7d0JBUUlBOzs7b0JBR0pBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVHQTs7O29CQUVmQTs7b0JBQ1lBOzs7d0JBRUlBOzt3QkFDQUE7OztvQkFVSkE7Ozs7Ozs7O29CQU1BQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7O29CQWNBQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7d0JBQXNEQTs7Ozs7b0JBTXREQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7Ozs7O29CQU9BQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7O29CQU1BQTs7b0JBQ0FBOzs7Ozs7Ozs7b0JBS0FBOztvQkFFQUE7O29CQUVBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7O3dCQUVJQTs7O29CQUdKQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNaQTs7b0JBQWlEQTs7O3dCQUVqQ0E7O3dCQUNBQTs7OzRCQUVJQTs7NEJBQ0FBOzs7Z0NBRUlBOztnQ0FDQUE7O2dDQUNBQTs7Ozs7b0JBS1pBOzs7d0JBRUlBOzs7b0JBR0pBOzs7Ozs7OzRCQUVJQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7NEJBR0pBOzs7Ozs7Ozs0QkFFQUE7Ozs7OzRDQUVoQkE7OzRDQUFnRUE7OztnREFFeENBOztnREFDQUE7OztvREFFSUE7O29EQUNBQTs7O3dEQUVJQTs7d0RBQ0FBOzt3REFDQUE7O3dEQUNBQTs7Ozs7NENBS1pBOzs7OzRCQWFKQTs7Ozs7Ozs7Ozs7b0JBRUpBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JjcFVBQTs7OztvQkFPQUE7O29CQUNBQTs7b0JBQ0FBOzs7d0JBRUlBOzt3QkFDQUE7O3dCQUNBQTs7OzRCQUVJQTs7OztvQkFJUkE7O29CQUNBQTs7OztvQkFLQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQ3BCSkE7Ozs7OztnQkFNSUE7Ozs7O2dCQU1BQTs7Ozs7Ozs7b0JBTUFBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOzs7Ozs7Ozs7O29CQU1BQTs7b0JBQ0FBOztvQkFFQUE7O29CQUVBQTs7b0JBQ1pBOztvQkFBbUNBOzs7d0JBRW5CQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTt3QkFBQ0E7OztvQkFHTEE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUVBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDZ1RBQTs7Ozs7Ozs7Ozs7Ozs7OztvQkFqUkpBOzs7O3dCQXlCQUE7Ozs7d0JBU0FBOzs7O3dCQWVRQTs7OzRCQUVJQTs7O3dCQUVKQTs7Ozs7d0JBT1JBOzs7O3dCQU1BQTs7Ozt3QkF5RFFBOzs7NEJBRUlBOzs7d0JBRUpBOzs7O3dCQVVSQTs7Ozs7Ozs7Ozs7O29CQS9KSUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUVBQTs7OztvQkFJQUE7Ozs7Ozs7O2dCQXVGQUE7O2dCQUVBQTs7O29CQUVJQTs7O2dCQUdKQTs7O29CQUVJQTs7Ozs7b0JBU0pBOzs7O29CQU9BQTs7OztvQkFLQUE7Ozs7b0JBS0FBOzs7O29CQW9DQUE7O29CQUNaQTs7b0JBQ1lBOzs7d0JBRUlBOzs7OztvQkFTaEJBOztvQkFBNkNBOzs7d0JBRTdCQTs7d0JBQ0FBOzt3QkFDaEJBOzt3QkFBMkRBOzs7NEJBRXZDQTs7NEJBQ0FBOzs7d0JBR0pBOzs7NEJBRUlBOzs0QkFDQUE7OzRCQUNBQTs7O2dDQUVJQTs7Z0NBRUFBOzs7b0NBRUlBOzs7Ozs7Z0NBS0pBOztnQ0FFQUE7OztvQ0FFSUE7Ozs7O29DQUlBQTs7Ozs0QkFJUkE7OztnQ0FHSUE7Ozs0QkFHSkE7OztnQ0FFSUE7Ozs0QkFFSkE7Ozs7b0JBSXBCQTs7b0JBQ1lBOzs7d0JBRUlBOzs7OztvQkFNSkE7O29CQUVBQTs7O3dCQUVJQTs7Ozs7d0JBSUFBOzs7Ozs7b0JBUUpBOzs7d0JBRUlBOzs7b0JBR0pBOztvQkFFQUE7O29CQUNBQTs7b0JBQ0FBOzs7Ozs7OzRCQUdJQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7O2dDQUtBQTs7Ozs7Ozs7Ozs7Z0NBSUFBOztnQ0FDQUE7Ozs7Z0NBS0FBOzs7Ozs7Ozs7Ozs7b0JBSVJBOzs7O29CQXFCQUE7Ozt3QkFFSUE7OztvQkFFSkE7O29CQUNBQTs7b0JBRUFBOzs7O29CQVNBQTs7b0JBQ0FBOzs7O29CQU9BQTs7O3dCQUVJQTs7O29CQUdKQTs7b0JBQ0FBOzs7d0JBRUlBOzs7b0JBR0pBOzs7O29CQVFaQTs7b0JBQTZDQTs7Ozs7Ozs7O1lBbEM3QkE7O1lBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0JDdldKQTs7d0JBQ0FBOzt3QkFFQUE7O3dCQUNBQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTs7d0JBQ0FBOzt3QkFFQUE7O3dCQUNBQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkNiQUE7O2dCQUVBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDeEJBQTs7Z0JBQ0FBOztnQkFDQUE7Ozs7O2dCQU1BQTs7Z0JBQ0FBOzs7O29CQU1BQTs7b0JBQ0FBOztvQkFDQUE7Ozs7b0JBTUFBOzs7d0JBRUlBOzs7OztvQkFPSkE7Ozt3QkFFSUE7Ozs7O29CQU9KQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkN6Q0FBOztnQkFDQUE7Ozs7Z0JBTUFBOztnQkFDQUE7OztvQkFFSUE7Ozs7O29CQUlBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCekJFUkE7Ozs7Z0NBcUxBQTs7OztnQ0FVUUE7O2dDQUNBQTs7O29DQUVJQTs7O2dDQUdKQTs7OztnQ0FVUkE7Ozs7Z0NBY0FBOzs7O2dDQVNBQTs7OztnQ0FTQUE7Ozs7Z0NBU0FBOzs7Ozs7Ozs7Ozs7d0JBcE9JQTs7d0JBQ0FBOzs7NEJBRUlBOzs7d0JBSUpBOzt3QkFDQUE7O3dCQUVBQTs7OzRCQUVJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0RBVUpBOzs7Ozs7Ozs7Ozt3REFFQUE7Ozs0REFFSUE7Ozt3REFFSkE7Ozs7Ozs7Ozs7O3dEQUVJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7NEJBV0pBOzs7OzRCQVVBQTs7Ozs0QkFPQUE7OztnQ0FFSUE7O2dDQUNBQTs7Z0NBQ0FBOzs7Ozs0QkFVSkE7OztnQ0FFSUE7Ozs0QkFFSkE7OztnQ0FFSUE7Ozs0QkFHSkE7OzRCQUNBQTs7O2dDQUVJQTtnQ0FBQUE7Ozs0QkFHSkE7OzRCQUVBQTs7Ozs7OzRCQVNBQTs7NEJBQ0FBOzs0QkFFQUE7OzRCQUNBQTs7O2dDQUVJQTs7Ozs7Z0NBTUFBOztnQ0FDQUE7Ozs0QkFFaEJBOzs0QkFDWUE7OztnQ0FFSUE7Ozs0QkFHSkE7Ozs7NEJBU0FBOzs7Ozs0QkFlQUE7OztnQ0FFSUE7O2dDQUNBQTs7Ozs7Ozs7Ozs7NEJBTUpBOzs7Ozs7Ozs7Ozs7Ozs7O1lBNUltREE7WUFBQ0E7Ozs7WUFjREE7WUFBQ0E7Ozs7Ozs7WUFnRERBO1lBQUNBOzs7Ozs7O1lBT0xBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CMEJ4RzNDQTs7O3dCQUVJQTs7O29CQUVKQTs7Ozt3QkFVUkE7Ozs7d0JBU0FBOzs7O3dCQVNBQTs7Ozs7Ozs7OztnQkFRSUE7Ozs7b0JBTUFBOzs7O29CQVFBQTs7b0JBQ0FBOzs7OztvQkFPQUE7Ozt3QkFFSUE7OztvQkFHSkE7O29CQUVBQTs7b0JBQ0FBOztvQkFDQUE7O29CQUNBQTs7Ozs7Ozs0QkFHSUE7OzRCQUNBQTs7O2dDQUVJQTs7Z0NBQ0FBOztnQ0FXQUE7Ozs0QkFFSkE7OztnQ0FFSUE7O2dDQUNBQTs7OzRCQUVKQTs7O2dDQUVJQTs7OztnQ0FLQUE7Ozs7Ozs7Ozs7O2dDQUlBQTs7Z0NBQ0FBOzs7O2dDQUtBQTs7Ozs7Ozs7Ozs7O29CQUlSQTs7Ozs7Ozs7UUFyQ1lBOzs7WUFFSUE7OztRQUVKQTs7UUFDQUE7O1FBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkNqRk5BOzs7O2dDQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0Qk5ORkE7OztnQ0FFSUE7Ozs0QkFHSkE7Ozs7Z0NBSUFBOzs7OztnQ0FRQUE7OztvQ0FFSUE7OztnQ0FHSkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCYjZCUkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29EQWxESUE7Ozs7Ozs7Ozs7O29EQUVBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0RBTUFBOzs7Ozs7Ozs7Ozt3REFFQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkFLQUE7OztnQ0FFSUE7Ozs0QkFHSkE7OzRCQUNBQTs7O2dDQUVJQTs7Ozs7Z0NBSUFBOzs7b0NBRUlBOztvQ0FDQUE7Ozs7OztnQ0FLSkE7Ozs7OzRCQU9KQTs7NEJBQ0FBOzs7OzRCQXFCQUE7Ozs7Ozs7Ozs7UUE5RCtDQTs7OztZQVFBQTs7OztZQW9CTkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCb0J4QjdDQTs7OztnQ0FpQ0FBOzs7O2dDQVNBQTs7OztnQ0FTQUE7Ozs7Z0NBU0FBOzs7Ozs7Ozs7Ozs7Ozs7d0JBdERJQTs7Ozs0QkFZQUE7OztnQ0FFSUE7O2dDQUNBQTs7OzRCQUdKQTs7Ozs0QkFtREFBOzs7Z0NBRUlBOzs7NEJBR0pBOzs0QkFDWkE7OzRCQUFpREE7OzRCQUdyQ0E7OzRCQUNaQTs7NEJBQW1FQTs7O2dDQUVuREE7Ozs0QkFHSkE7OztnQ0FHSUE7O2dDQUVBQTs7O29DQUVoQkE7O29DQUEwQ0E7Ozt3Q0FFbEJBOzs7Ozs7O2dDQU1SQTs7OzRCQUdKQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7NEJBR0pBOzs7OzRCQU9BQTs7O2dDQUVJQTs7OzRCQUdKQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7NEJBR0pBOzs0QkFDQUE7OztnQ0FFSUE7O2dDQUNBQTs7OzRCQUdKQTs7Ozs0QkFTQUE7Ozs7NEJBU0FBOzs7OzRCQVNBQTs7NEJBQ0FBOzs0QkFFQUE7OztnQ0FFSUE7Ozt3Q0FBWUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3RUFFUkE7Ozs7Ozs7Ozs7O3dFQUVJQTs7Ozs7Ozs7Ozs7d0VBQ0FBOzs7Ozs7O3dFQUVKQTs7Ozs7Ozs7Ozs7d0VBRUlBOzs7Ozs7Ozs7Ozt3RUFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkFJWkE7Ozs7NEJBU0FBOzs7Ozs7Ozs7Ozs7OzRCQVNaQTs7NEJBQWlEQTs7NEJBQ3JDQTs7O2dDQUVJQTs7OzRCQUdKQTs7Ozs7Ozs7Ozs7Ozs7NEJBaUJBQTs7Ozs7Ozs7NEJBV0FBOzs7Z0NBRUlBOzs7NEJBR0pBOzs7b0NBQ0lBOzs7d0NBR0lBOzt3Q0FDQUE7Ozs7O3dDQUlBQTs7OzRDQUdRQTs7NENBQ0FBOzs7Z0RBQStDQTs7Ozs7Ozs7NEJBUy9EQTs7O2dDQUVJQTs7Ozs7Ozs7OzRCQU1KQTs7NEJBQ0FBOzs7Z0NBRUlBOzs7NEJBRUpBOzs0QkFDQUE7OztnQ0FFSUE7Ozs0QkFFSkE7OzRCQUNBQTs7O2dDQUVJQTs7OzRCQUVKQTs7Ozs7NEJBS0FBOzs7Z0NBRUlBOzs7NEJBRUpBOzs0QkFDQUE7Ozs7Ozs7b0NBRUlBOzs7d0NBRUlBOzs7b0NBRXBCQTtvQ0FBMERBOzs7Ozs7Ozs7Ozs0QkFFOUNBOzs7OzRCQUtBQTs7Ozs7Ozs7OztRQWxLWUE7Ozs7WUFTQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkN6TE5BOzs7O2dDQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7NEJDOENWQTs7OztnQ0FtQkFBOzs7O2dDQU9RQTs7O29DQUVJQTs7O2dDQUdKQTs7OztnQ0FTQUE7OztvQ0FFSUE7OztnQ0FFSkE7Ozs7Z0NBVVJBOzs7O2dDQVlBQTs7OztnQ0FPQUE7Ozs7Ozs7d0JBN0RJQTs7d0JBQ0FBOzs7Ozt3QkErQ1pBOzt3QkFBMkRBOzs7OzRCQWtCL0NBOzs7Z0NBRUlBOzs7NEJBR0pBOzs0QkFDQUE7OzRCQUVBQTs7O2dDQUVJQTs7OzRCQUVKQTs7Ozs0QkFXQUE7OztnQ0FFSUE7Ozs0QkFHSkE7Ozs7NEJBUVpBOzs0QkFBNkNBOzs0QkFBaURBOzs7Z0NBRTlFQTs7Z0NBQ0FBOzs7b0NBRWhCQTs7b0NBQXVDQTs7O3dDQUVmQTs7Ozs7d0NBSUFBOzs7Ozs7b0NBS0pBOzs7Z0NBR0pBOzs7b0NBRUlBOzs7Ozs7NEJBT3BCQTs7NEJBQWdEQTs7O2dDQUVoQ0E7Ozs0QkFFaEJBOzs0QkFDWUE7Ozs7Ozs7OztRQXZESUE7O1FBQ0FBOztRQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0I3QjFISkE7Ozs7NEJBS1pBOzs0QkFBMkJBOzs7OzRCQUtmQTs7Ozs0QkFLQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCOEJvR0lBOzs7OztnQkFTQUE7Ozs7b0JBV0FBOzs7OztvQkFDQUE7Ozs7Ozs7O29CQVlBQTs7b0JBQ2hCQTs7b0JBQXdEQTs7O3dCQUVwQ0E7OztvQkFHSkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkEvSEpBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Z0JBQ0FBOzs7Ozs7Ozs7b0JBWUFBOzs7d0JBRUlBOzs7b0JBUUpBOztvQkFDQUE7Ozt3QkFFSUE7OztvQkFLSkE7Ozs7Ozs7Ozs7OztvQkFzQkFBOztvQkFDQUE7Ozt3QkFFSUE7OztvQkFLSkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0J0QkVBQTs7Ozs7Ozs7NEJBTUFBOzs7OzRCQUtBQTs7NEJBQ0FBOzs0QkFDQUE7OzRCQUNBQTs7Ozs0QkFLQUE7OzRCQUNBQTs7Ozs0QkFLQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCdUJ2SUFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkNBQUEiLAogICJzb3VyY2VzQ29udGVudCI6IFsidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5BYnN0cmFjdGlvbnMuTWV0YWRhdGEuTW9kZWxzLk1ldGFkYXRhO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld3M7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbFxyXG57XHJcbiAgICBwdWJsaWMgY2xhc3MgQmFzZUlucHV0czxUTSwgVENoaWxkcmVuPiA6IElucHV0c1dpdGhDaGlsZHJlbjxUQ2hpbGRyZW4+LCBJQmFzZUlucHV0c1xyXG4gICAge1xyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIG9iamVjdCBJQmFzZUlucHV0cy5Nb2RlbFxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0IHsgcmV0dXJuIE1vZGVsOyB9XHJcbiAgICAgICAgICAgIHNldCB7IE1vZGVsID0gKFRNKXZhbHVlOyB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LjQv9C40LfQuNGA0L7QstCw0L3QvdCw0Y8g0LzQvtC00LXQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgVE0gTW9kZWxcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gR2V0RnVuYygpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHNldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBTZXRGdW5jKHZhbHVlKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEZ1bmM8VE0+IEdldEZ1bmMgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgQWN0aW9uPFRNPiBTZXRGdW5jIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgRnVuYzxvYmplY3Q+IElCYXNlSW5wdXRzLkdldEZ1bmMgeyBnZXQgeyByZXR1cm4gKCkgPT4gR2V0RnVuYygpOyB9IHNldCB7IEdldEZ1bmMgPSAoKSA9PiB2YWx1ZSgpLkFzPFRNPigpOyB9IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgQWN0aW9uPG9iamVjdD4gSUJhc2VJbnB1dHMuU2V0RnVuYyB7IGdldCB7IHJldHVybiAodikgPT4gU2V0RnVuYygoVE0pdik7IH0gc2V0IHsgU2V0RnVuYyA9ICh2KSA9PiB2YWx1ZSh2KTsgfSB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBGdW5jPFZpZXdBdHRyaWJ1dGVzPiBBdHRyaWJ1dGVzIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEZ1bmM8SVByb3BlcnR5TWV0YWRhdGE+IFByb3BlcnR5TWV0YWRhdGEgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgRnVuYzxzdHJpbmc+IERhdGFUZXN0SWQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgRnVuYzxJVmlld01vZGVsPiBQcm9wZXJ0eU93bmVyIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEZ1bmM8Ym9vbCwgRm9jdXNhYmxlVHlwZT4gRm9jdXNhYmxlVHlwZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBGdW5jPElLZXlib2FyZEV2ZW50LCBUYXNrPiBPbktleVByZXNzIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEZ1bmM8SUNoYW5nZUV2ZW50LCBUYXNrPiBPbkJsdXIgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgRnVuYzxJRm9jdXNFdmVudCwgVGFzaz4gT25Gb2N1cyB7IGdldDsgc2V0OyB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgQnJpZGdlLkh0bWw1O1xyXG51c2luZyBCcmlkZ2UuUmVhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5FeHRlbnNpb25Qb2ludHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuU2VydmljZXM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5EaXNwYXRjaGVyO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuRXh0ZW5zaW9ucztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Jb2MuQWJzdHJhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuQ29tcG9uZW50c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JHQsNC30L7QstGL0Lkg0LrQvtC80L/QvtC90LXQvdGCXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRJbnB1dHNcIj7QotC40L8g0LLRhdC+0LTQvdGL0YUg0LjQvdC/0YPRgtC+0LI8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udGV4dFwiPtCi0LjQvyDQutC+0L3RgtC10LrRgdGC0LA8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udHJvbGxlclwiPtCi0LjQvyDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVJlYWN0Q29tcG9uZW50PFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj4gOiBQdXJlQ29tcG9uZW50PEJhc2VSZWFjdFByb3BzPElSZWFjdElucHV0TW9kZWw8VElucHV0cz4+PiwgSVJlYWN0Q29tcG9uZW50XHJcbiAgICAgICAgd2hlcmUgVElucHV0cyA6IElJbnB1dHNcclxuICAgICAgICB3aGVyZSBUQ29udGV4dCA6IElDb250ZXh0XHJcbiAgICAgICAgd2hlcmUgVENvbnRyb2xsZXIgOiBJQ29udHJvbGxlclxyXG4gICAge1xyXG4jcmVnaW9uIElSZWFjdENvbXBvbmVudFxyXG4vLy8gPHN1bW1hcnk+XHJcbi8vLyDQodGB0YvQu9C60LAg0L3QsCDRgNC10LDQutGCLdGN0LvQtdC80LXQvdGCXHJcbi8vLyDQodC70YPQttC10LHQvdC+0LUg0L/QvtC70LUsINC90LXQvtCx0YXQvtC00LjQvNC+INC00LvRjyDRgNCw0LHQvtGC0YsgQnJpZGdlLlJlYWN0XHJcbi8vLyA8L3N1bW1hcnk+XHJcbnB1YmxpYyBSZWFjdEVsZW1lbnQgUmVhY3RFbGVtZW50XHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiB0aGlzO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICBwcml2YXRlIHN0YXRpYyBUeXBlIHNjb3BlZENvbXBvbmVudFR5cGUgPSB0eXBlb2YoSVNjb3BlZENvbXBvbmVudCk7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gY3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibW9kZWxcIj7QktGF0L7QtNC90LDRjyDQvNC+0LTQtdC70Yw8L3BhcmFtPlxyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlUmVhY3RDb21wb25lbnQoSVJlYWN0SW5wdXRNb2RlbDxUSW5wdXRzPiBtb2RlbCkgOiBiYXNlKG5ldyBCYXNlUmVhY3RQcm9wczxJUmVhY3RJbnB1dE1vZGVsPFRJbnB1dHM+PnsgTW9kZWwgPSBtb2RlbCwgS2V5ID0gbW9kZWwuS2V5LCBDaGlsZHJlbiA9IGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsbW9kZWwuSW5wdXRzKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8VElucHV0cz4oXCJrZXkxXCIpW1wiQ2hpbGRyZW5cIl06KG9iamVjdCludWxsLCBSZWYgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLkFueTxUeXBlPih0eXBlb2YoVElucHV0cykuR2V0SW50ZXJmYWNlcygpLChGdW5jPFR5cGUsYm9vbD4pKGkgPT4gaSA9PSB0eXBlb2YoSVJlZikpKSA/ICgoSVJlZiltb2RlbC5JbnB1dHMpLlJlZiA6IChBY3Rpb248SFRNTEVsZW1lbnQ+KUJyaWRnZS5TY3JpcHQuVW5kZWZpbmVkIH0pXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmNC90LjRhtC40LDQu9C40LfQsNGG0LjRjyDQsdCw0LfQvtCy0L7Qs9C+INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgc2VhbGVkIG92ZXJyaWRlIHZvaWQgSW5pdGlhbGl6ZVZpZXdNb2RlbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgY3VycmVudFNjb3BlID0gSW5wdXRNb2RlbC5Sb290U2NvcGU7XHJcbiAgICAgICAgICAgIGlmIChzY29wZWRDb21wb25lbnRUeXBlLklzQXNzaWduYWJsZUZyb20oR2V0VHlwZSgpKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY3VycmVudFNjb3BlID0gY3VycmVudFNjb3BlLkJlZ2luTGlmZXRpbWVTY29wZShHZXRUeXBlKCkuTmFtZSk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIC8v0KHQvtC30LTQsNC10YLRgdGPINC/0YPRgdGC0L7QuSBWaWV3TW9kZWxcclxuICAgICAgICAgICAgTW9kZWwgPSAoVmlld01vZGVsKWN1cnJlbnRTY29wZS5SZXNvbHZlPElWaWV3TW9kZWxDcmVhdG9yU2VydmljZT4oKS5DcmVhdGVNb2RlbChUeXBlVmlld01vZGVsKTtcclxuICAgICAgICAgICAgVmlld01vZGVsLkZpbGxWaWV3TW9kZWwoKEZ1bmM8SUlucHV0TW9kZWw+KSgoKSA9PiBJbnB1dE1vZGVsKSwgdHlwZW9mKFRDb250ZXh0KSwgdHlwZW9mKFRDb250cm9sbGVyKSwgdGhpcyk7XHJcblxyXG4gICAgICAgICAgICBpZiAoQ29udHJvbGxlciBpcyBJT25Jbml0KVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBEaXNwYXRjaGVyLkRpc3BhdGNoKChBY3Rpb248VENvbnRyb2xsZXI+KShjID0+ICgoSU9uSW5pdCljKS5PbkluaXQoKSkpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCS0YvQt9GL0LLQsNC10YLRgdGPINGB0YDQsNC30YMg0L/QvtGB0LvQtSDQv9C10YDQstC+0Lkg0L7RgtGA0LjRgdC+0LLQutC4INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHJldHVybnM+VGFzazwvcmV0dXJucz5cclxuICAgICAgICBwcm90ZWN0ZWQgb3ZlcnJpZGUgYXN5bmMgVGFzayBDb21wb25lbnREaWRNb3VudCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBhd2FpdCBiYXNlLkNvbXBvbmVudERpZE1vdW50KCk7XHJcblxyXG4gICAgICAgICAgICBpZiAoQ29udHJvbGxlciBpcyBJT25Mb2FkKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBEaXNwYXRjaGVyLkRpc3BhdGNoKChBY3Rpb248VENvbnRyb2xsZXI+KShjID0+ICgoSU9uTG9hZCljKS5PbkxvYWQoKSkpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGlmIChDb250cm9sbGVyIGlzIElPbkxvYWRBc3luYylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgYXdhaXQgRGlzcGF0Y2hlci5EaXNwYXRjaCgoRnVuYzxUQ29udHJvbGxlcixUYXNrPikoYyA9PiAoKElPbkxvYWRBc3luYyljKS5PbkxvYWRBc3luYygpKSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C30YvQstCw0LXRgtGB0Y8g0YHRgNCw0LfRgyDQv9C+0YHQu9C1INC+0LHQvdC+0LLQu9C10L3QuNGPINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJwcmV2aW91c1Byb3BzXCI+0YHRgtCw0YDRi9C1INC30L3QsNGH0LXQvdC40Y8g0L/RgNC+0L/RgdC+0LI8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz5UYXNrPC9yZXR1cm5zPlxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSBUYXNrIENvbXBvbmVudERpZFVwZGF0ZShCYXNlUmVhY3RQcm9wczxJUmVhY3RJbnB1dE1vZGVsPFRJbnB1dHM+PiBwcmV2aW91c1Byb3BzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIGJhc2UuQ29tcG9uZW50RGlkVXBkYXRlKHByZXZpb3VzUHJvcHMpO1xyXG5cclxuICAgICAgICAgICAgLy9WaWV3TW9kZWwuTG9nZ2VyLkRlYnVnKFNSLlQoXCJDb21wb25lbnREaWRVcGRhdGU6ezB9LCBrZXk6IHsxfVwiLCB0aGlzW1wiX19wcm90b19fXCJdW1wiJCRmdWxsbmFtZVwiXSwgcHJvcHMuTW9kZWwuSW5wdXRzLktleSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0LfRi9Cy0LDQtdGC0YHRjyDQv9C10YDQtdC0INC+0LHQvdC+0LLQu9C10L3QuNC10Lwg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSB2b2lkIENvbXBvbmVudFdpbGxSZWFjdCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBiYXNlLkNvbXBvbmVudFdpbGxSZWFjdCgpO1xyXG5cclxuICAgICAgICAgICAgLy9Db25zb2xlLldyaXRlTGluZShTUi5UKFwiQ29tcG9uZW50V2lsbFJlYWN0OnswfSwga2V5OiB7MX1cIiwgdGhpc1tcIl9fcHJvdG9fX1wiXVtcIiQkZnVsbG5hbWVcIl0sIHByb3BzLk1vZGVsLklucHV0cy5LZXkpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSB2b2lkIENvbXBvbmVudERpZENhdGNoKEV4Y2VwdGlvbiBlcnJvciwgRXJyb3JTdGFja01vZGVsIGluZm8pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBEaXNwYXRjaGVyLkRpc3BhdGNoKChBY3Rpb248VENvbnRyb2xsZXI+KShjID0+IFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBWaWV3TW9kZWwuRXJyb3IgPSB0cnVlO1xyXG4gICAgICAgICAgICAgICAgVmlld01vZGVsLkVycm9yTWVzc2FnZSA9IGVycm9yLlRvU3RyaW5nKCk7XHJcbiAgICAgICAgICAgICAgICBWaWV3TW9kZWwuRXJyb3JJbmZvID0gaW5mbztcclxuICAgICAgICAgICAgfSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQstGL0LfRi9Cy0LDQtdGC0YHRjyDQv9C10YDQtdC0INGD0LTQsNC70LXQvdC40LXQvCDQutC+0LzQv9C+0L3QtdC90YLQsCDQuNC3IERPTVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPlRhc2s8L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIG92ZXJyaWRlIFRhc2sgQ29tcG9uZW50V2lsbFVubW91bnQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKENvbnRyb2xsZXIgaXMgSU9uRGVzdHJveSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgRGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uPFRDb250cm9sbGVyPikoYyA9PiAoKElPbkRlc3Ryb3kpYykuT25EZXN0cm95KCkpKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBpZiAoQ29udHJvbGxlciBpcyBJT25EZXN0cm95QXN5bmMpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIERpc3BhdGNoZXIuRGlzcGF0Y2goKEZ1bmM8VENvbnRyb2xsZXIsVGFzaz4pKGMgPT4gKChJT25EZXN0cm95QXN5bmMpYykuT25EZXN0cm95QXN5bmMoKSkpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBEaXNwYXRjaGVyLkRpc3BhdGNoKChBY3Rpb248VENvbnRyb2xsZXI+KShjID0+IFZpZXdNb2RlbC5EZXN0cm95VmFsaWRhdGlvbigpKSk7XHJcbiAgICAgICAgICAgIGlmIChzY29wZWRDb21wb25lbnRUeXBlLklzQXNzaWduYWJsZUZyb20oR2V0VHlwZSgpKSAmJiBWaWV3TW9kZWwuSGFzUHJvcGVydHkoU2NvcGVkQ29tcG9uZW50Q29uc3RhbnRzLkN1cnJlbnRTY29wZSkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIFZpZXdNb2RlbFtTY29wZWRDb21wb25lbnRDb25zdGFudHMuQ3VycmVudFNjb3BlXS5BczxJTGlmZXRpbWVTY29wZT4oKS5EaXNwb3NlKCk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIE1vZGVsLkRlc3Ryb3koKTtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBiYXNlLkNvbXBvbmVudFdpbGxVbm1vdW50KCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCR0LDQt9C+0LLRi9C5INC80LXRgtC+0LQg0L7RgtGA0LjRgdC+0LLQutC4IFJlYWN0INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0JTQtdGA0LXQstC+INGA0LXQsNC60YIg0Y3Qu9C10LzQtdC90YLQvtCyPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBzZWFsZWQgb3ZlcnJpZGUgUmVhY3RFbGVtZW50IFJlbmRlcigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5QdXNoKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkyXCIsVmlld01vZGVsKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8Vmlld01vZGVsPihcImtleTJcIikuUmVuZGVyT3duZXI6KElWaWV3TW9kZWwpbnVsbCk7XHJcbiAgICAgICAgICAgIFZpZXdNb2RlbEhlbHBlci5TZXREYXRhKFZpZXdNb2RlbCk7XHJcblxyXG4gICAgICAgICAgICBSZWFjdEVsZW1lbnQgcmVzdWx0O1xyXG4gICAgICAgICAgICB0cnlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmVzdWx0ID0gIVZpZXdNb2RlbC5SZWFkeVxyXG4gICAgICAgICAgICAgICAgICAgID8gQ29tcG9uZW50Tm90UmVhZHlWaWV3KClcclxuICAgICAgICAgICAgICAgICAgICA6IFJlbmRlckludGVybmFsKCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgZmluYWxseVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBWaWV3TW9kZWxIZWxwZXIuUmVzdG9yZURhdGEoVmlld01vZGVsKTtcclxuICAgICAgICAgICAgICAgIEdsb2JhbFNjb3BlSGVscGVyLlBvcChnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5M1wiLFZpZXdNb2RlbCkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFZpZXdNb2RlbD4oXCJrZXkzXCIpLlJlbmRlck93bmVyOihJVmlld01vZGVsKW51bGwpO1xyXG4gICAgICAgICAgICB9XHJcbklWaWV3TW9kZWxIYW5kbGVyIHZpZXdNb2RlbEhhbmRsZXI7XHJcbiAgICAgICAgICAgIGlmICgodmlld01vZGVsSGFuZGxlciA9IE1vZGVsIGFzIElWaWV3TW9kZWxIYW5kbGVyKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2aWV3TW9kZWxIYW5kbGVyLkFmdGVyVmlldygpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gcmVzdWx0O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQvNC10YLQvtC0INC+0YLRgNC40YHQvtCy0LrQuCDRgdC40YHRgtC10LzQvdC+0LPQviDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBpbnRlcm5hbCB2aXJ0dWFsIFJlYWN0RWxlbWVudCBSZW5kZXJJbnRlcm5hbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gVmlldygpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC10YLQvtC0INGA0LXQvdC00LXRgNCwINC60L7QvNC/0L7QvdC10L3RgtC+0LJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QlNC10YDQtdCy0L4g0YDQtdCw0LrRgiDRjdC70LXQvNC10L3RgtC+0LI8L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIGFic3RyYWN0IFJlYWN0RWxlbWVudCBWaWV3KCk7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JzQtdGC0L7QtCwg0LLQvtC30LLRgNCw0YnQsNGO0YnQuNC5INC00LXRgNC10LLQviDRgNC10LDQutGCINGN0LvQtdC80LXQvdGC0L7Qsiwg0LXRgdC70Lgg0LrQvtC80L/QvtC90LXQvdGCINC10YnRkSDQvdC1INCz0L7RgtC+0LIg0LTQu9GPINC+0YLRgNC40YHQvtCy0LrQuFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCU0LXRgNC10LLQviDRgNC10LDQutGCINGN0LvQtdC80LXQvdGC0L7QsjwvcmV0dXJucz5cclxuICAgICAgICBwcm90ZWN0ZWQgdmlydHVhbCBSZWFjdEVsZW1lbnQgQ29tcG9uZW50Tm90UmVhZHlWaWV3KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChWaWV3TW9kZWwuRXJyb3IpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBpID0gMDtcclxuICAgICAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWwuUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZS5FcnJvcihuZXcgQmFzZUVycm9ySW5wdXRzXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgTWVzc2FnZSA9ICgpID0+IFZpZXdNb2RlbC5FcnJvck1lc3NhZ2UsXHJcbiAgICAgICAgICAgICAgICAgICAgQ2hpbGRyZW4gPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlNlbGVjdDxzdHJpbmcsUmVhY3RFbGVtZW50PihWaWV3TW9kZWwuRXJyb3JJbmZvLlN0YWNrLlNwbGl0KCdcXG4nKSwoRnVuYzxzdHJpbmcsUmVhY3RFbGVtZW50PikoZSA9PiBET00uRGl2KG5ldyBBdHRyaWJ1dGVzIHsgS2V5ID0gXCJlcnJvcl9cIiArIGkrKyB9LCBlKSkpLlRvQXJyYXkoKVxyXG4gICAgICAgICAgICAgICAgfSwgVmlld01vZGVsKS5Ub1JlYWN0RWxlbWVudCgpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiBudWxsO1xyXG4gICAgICAgIH1cclxuLy8vIDxzdW1tYXJ5PlxyXG4vLy8gVmlld01vZGVsINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbi8vLyA8L3N1bW1hcnk+XHJcbnB1YmxpYyBWaWV3TW9kZWwgVmlld01vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBNb2RlbDtcclxuICAgIH1cclxufVxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YLRgNC+0LvQu9C10YAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBUQ29udHJvbGxlciBDb250cm9sbGVyXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBnZXRcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIGNvbnRyb2xsZXIgPSBWaWV3TW9kZWwuQ29udHJvbGxlcjtcclxuICAgICAgICAgICAgICAgIGlmIChjb250cm9sbGVyID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIGRlZmF1bHQoVENvbnRyb2xsZXIpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHJldHVybiAoVENvbnRyb2xsZXIpY29udHJvbGxlcjtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuLy8vIDxzdW1tYXJ5PlxyXG4vLy8g0KLQuNC/IFZpZXdNb2RlbFxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgdmlydHVhbCBUeXBlIFR5cGVWaWV3TW9kZWxcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIHR5cGVvZihWaWV3TW9kZWwpO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktC90YPRgtGA0LXQvdC10LUg0L/QvtC70LUg0LTQu9GPINGF0YDQsNC90LXQvdC40Y8g0LzQvtC00LXQu9C4LCDQvdC1INC40YHQv9C+0LvRjNC30L7QstCw0YLRjCDQsiDQutC+0LzQv9C+0L3QtdC90YLQsNGFXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgaW50ZXJuYWwgVmlld01vZGVsIE1vZGVsO1xyXG4vLy8gPHN1bW1hcnk+XHJcbi8vLyDQmtC+0L3RgtC10LrRgdGCINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbi8vLyA8L3N1bW1hcnk+XHJcbnByb3RlY3RlZCB2aXJ0dWFsIFRDb250ZXh0IENvbnRleHRcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIFZpZXdNb2RlbC5Db250ZXh0ICE9IG51bGwgPyAoVENvbnRleHQpVmlld01vZGVsLkNvbnRleHQgOiBkZWZhdWx0KFRDb250ZXh0KTtcclxuICAgIH1cclxufS8vLyA8c3VtbWFyeT5cclxuLy8vINCd0LDRgdGC0YDQvtC50LrQuCDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgdmlydHVhbCBJQ29tcG9uZW50Q29udGFpbmVyIENvbXBvbmVudFxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gVmlld01vZGVsLkNvbXBvbmVudDtcclxuICAgIH1cclxufS8vLyA8c3VtbWFyeT5cclxuLy8vINCS0YXQvtC00L3QsNGPINC80L7QtNC10LvRjCDQuNC90L/Rg9GC0L7QslxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgSVJlYWN0SW5wdXRNb2RlbDxUSW5wdXRzPiBJbnB1dE1vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBwcm9wcy5Nb2RlbDtcclxuICAgIH1cclxufS8vLyA8c3VtbWFyeT5cclxuLy8vINCi0LjQv9C40LfQuNGA0L7QstCw0L3QvdGL0Lkg0LTQuNGB0L/QsNGC0YfQtdGAINC00LvRjyDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgdmlydHVhbCBJQ29tcG9uZW50RGlzcGF0Y2hlcjxUQ29udHJvbGxlcj4gRGlzcGF0Y2hlclxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gKElDb21wb25lbnREaXNwYXRjaGVyPFRDb250cm9sbGVyPilWaWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlcjtcclxuICAgIH1cclxufSAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0YDQtdCw0LrRgiDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUSW5wdXRzXCI+0KLQuNC/INC40L3Qv9GD0YLQvtCyPC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVENvbnRleHRcIj7QotC40L8g0LrQvtC90YLQtdC60YHRgtCwPC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVJlYWN0Q29tcG9uZW50PFRJbnB1dHMsIFRDb250ZXh0PiA6IEJhc2VSZWFjdENvbXBvbmVudDxUSW5wdXRzLCBUQ29udGV4dCwgQmFzZVJlYWN0Q29udHJvbGxlcj5cclxuICAgICAgICB3aGVyZSBUSW5wdXRzIDogSUlucHV0c1xyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgIHtcclxuICAgICAgICBwcm90ZWN0ZWQgQmFzZVJlYWN0Q29tcG9uZW50KElSZWFjdElucHV0TW9kZWw8VElucHV0cz4gbW9kZWwpIDogYmFzZShtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQutC70LDRgdGBINGA0LXQsNC60YIg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVJlYWN0Q29tcG9uZW50PFRDb250cm9sbGVyPiA6IEJhc2VSZWFjdENvbXBvbmVudDxJbnB1dHMsIENvbnRleHQsIFRDb250cm9sbGVyPlxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICBwcm90ZWN0ZWQgQmFzZVJlYWN0Q29tcG9uZW50KElSZWFjdElucHV0TW9kZWw8SW5wdXRzPiBtb2RlbCkgOiBiYXNlKG1vZGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0YDQtdCw0LrRgiDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlUmVhY3RDb21wb25lbnQgOiBCYXNlUmVhY3RDb21wb25lbnQ8SW5wdXRzLCBDb250ZXh0PlxyXG4gICAge1xyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlUmVhY3RDb21wb25lbnQoSVJlYWN0SW5wdXRNb2RlbDxJbnB1dHM+IG1vZGVsKSA6IGJhc2UobW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBwdWJsaWMgc2VhbGVkIGNsYXNzIEJhc2VSZWFjdENvbnRyb2xsZXIgOiBDb250cm9sbGVyPElDb250ZXh0PlxyXG4gICAge1xyXG4gICAgfVxyXG5cclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQtSDQv9GA0L7Qv9GB0Ysg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVE1vZGVsXCI+PC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgY2xhc3MgQmFzZVJlYWN0UHJvcHM8VE1vZGVsPiA6IEJhc2VQcm9wc1dpdGhDaGlsZHJlblxyXG4gICAge1xyXG4gICAgICAgIHB1YmxpYyBCYXNlUmVhY3RQcm9wcygpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBLZXkgPSBHdWlkLkVtcHR5LlRvU3RyaW5nKCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgVE1vZGVsIE1vZGVsIHsgZ2V0OyBzZXQ7IH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5FeHRlbnNpb25Qb2ludHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuU2VydmljZXM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlVJLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5SZW5kZXJlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlVJLlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuSW9jLkFic3RyYWN0O1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzXHJcbntcclxuICAgIFtDb21wb25lbnRdXHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgVmlld0l0ZW1SZW5kZXJlcjxUVmlld0l0ZW0sIFRDb21wb25lbnQsIFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj4gOiBWaWV3SXRlbVJlbmRlcmVyXHJcbiAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogVmlld0l0ZW1cclxuICAgICAgICB3aGVyZSBUQ29tcG9uZW50IDogQmFzZVZpZXdJdGVtQ29tcG9uZW50PFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQsIFRDb250cm9sbGVyPlxyXG4gICAgICAgIHdoZXJlIFRJbnB1dHMgOiBJSW5wdXRzXHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgVmlld0l0ZW1SZW5kZXJlcihJTGlmZXRpbWVTY29wZSBjdXJyZW50U2NvcGUpIDogYmFzZShjdXJyZW50U2NvcGUpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgYm9vbCBDYW5SZW5kZXIoVFZpZXdJdGVtIHZpZXdJdGVtKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHZpZXdJdGVtLkdldFR5cGUoKSA9PSB0eXBlb2YoVFZpZXdJdGVtKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHB1YmxpYyBzZWFsZWQgb3ZlcnJpZGUgYm9vbCBDYW5SZW5kZXIoVmlld0l0ZW0gdmlld0l0ZW0pXHJcbiAgICAgICAge1xyXG5UVmlld0l0ZW0gaXRlbTsgICAgICAgICAgICByZXR1cm4gKGl0ZW0gPSB2aWV3SXRlbSBhcyBUVmlld0l0ZW0pICE9IG51bGwmJiBDYW5SZW5kZXIoaXRlbSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgb3ZlcnJpZGUgVHlwZSBHZXRUeXBlQ29tcG9uZW50KFZpZXdJdGVtIHZpZXdJdGVtKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHR5cGVvZihUQ29tcG9uZW50KTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSBUeXBlIEdldElucHV0c1R5cGVDb21wb25lbnQoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHR5cGVvZihUSW5wdXRzKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIFZpZXdJdGVtUmVuZGVyZXI8VFZpZXdJdGVtLCBUQ29tcG9uZW50LCBUSW5wdXRzLCBUQ29udGV4dD4gOiBWaWV3SXRlbVJlbmRlcmVyPFRWaWV3SXRlbSwgVENvbXBvbmVudCwgVElucHV0cywgVENvbnRleHQsIElDb250cm9sbGVyPlxyXG4gICAgICAgIHdoZXJlIFRWaWV3SXRlbSA6IFZpZXdJdGVtXHJcbiAgICAgICAgd2hlcmUgVENvbXBvbmVudCA6IEJhc2VWaWV3SXRlbUNvbXBvbmVudDxUVmlld0l0ZW0sIFRJbnB1dHMsIFRDb250ZXh0LCBJQ29udHJvbGxlcj5cclxuICAgICAgICB3aGVyZSBUSW5wdXRzIDogSUlucHV0c1xyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgVmlld0l0ZW1SZW5kZXJlcihJTGlmZXRpbWVTY29wZSBjdXJyZW50U2NvcGUpIDogYmFzZShjdXJyZW50U2NvcGUpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgVmlld0l0ZW1SZW5kZXJlcjxUVmlld0l0ZW0sIFRDb21wb25lbnQ+IDogVmlld0l0ZW1SZW5kZXJlcjxUVmlld0l0ZW0sIFRDb21wb25lbnQsIElucHV0cywgQ29udGV4dCwgSUNvbnRyb2xsZXI+XHJcbiAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogVmlld0l0ZW1cclxuICAgICAgICB3aGVyZSBUQ29tcG9uZW50IDogQmFzZVZpZXdJdGVtQ29tcG9uZW50PFRWaWV3SXRlbSwgSW5wdXRzLCBDb250ZXh0LCBJQ29udHJvbGxlcj5cclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgVmlld0l0ZW1SZW5kZXJlcihJTGlmZXRpbWVTY29wZSBjdXJyZW50U2NvcGUpIDogYmFzZShjdXJyZW50U2NvcGUpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBbQ29tcG9uZW50KE9yZGVyID0gaW50Lk1heFZhbHVlKV1cclxuICAgIHB1YmxpYyBjbGFzcyBWaWV3SXRlbVJlbmRlcmVyIDogSVZpZXdJdGVtUmVuZGVyZXJcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElMaWZldGltZVNjb3BlIGN1cnJlbnRTY29wZTtcclxuICAgICAgICBwcml2YXRlIElFbnVtZXJhYmxlPElXcmFwQ29tcG9uZW50PiB3cmFwQ29tcG9uZW50cztcclxuICAgICAgICBwcml2YXRlIElDb21wb25lbnRNYW5hZ2VyIGNvbXBvbmVudE1hbmFnZXI7XHJcbiAgICAgICAgcHJpdmF0ZSBJVmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSB2aWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlO1xyXG4gICAgICAgIHByaXZhdGUgSVJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UgcmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZTtcclxucHJpdmF0ZSBJRW51bWVyYWJsZTxJV3JhcENvbXBvbmVudD4gV3JhcENvbXBvbmVudHNcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIHdyYXBDb21wb25lbnRzID8/ICh3cmFwQ29tcG9uZW50cyA9IGN1cnJlbnRTY29wZS5SZXNvbHZlPElFbnVtZXJhYmxlPElXcmFwQ29tcG9uZW50Pj4oKSk7XHJcbiAgICB9XHJcbn1wcml2YXRlIElDb21wb25lbnRNYW5hZ2VyIENvbXBvbmVudE1hbmFnZXJcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGNvbXBvbmVudE1hbmFnZXIgPz8gKGNvbXBvbmVudE1hbmFnZXIgPSBjdXJyZW50U2NvcGUuUmVzb2x2ZTxJQ29tcG9uZW50TWFuYWdlcj4oKSk7XHJcbiAgICB9XHJcbn1wcm90ZWN0ZWQgSVZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2UgVmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZVxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gdmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSA/PyAodmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSA9IGN1cnJlbnRTY29wZS5SZXNvbHZlPElWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlPigpKTtcclxuICAgIH1cclxufXByb3RlY3RlZCBJUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSBSZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlID8/IChyZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlID0gY3VycmVudFNjb3BlLlJlc29sdmU8SVJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2U+KCkpO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjdXJyZW50U2NvcGVcIj7QotC10LrRg9GJ0LjQuSBzY29wZTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFZpZXdJdGVtUmVuZGVyZXIoSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5jdXJyZW50U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBib29sIENhblJlbmRlcihWaWV3SXRlbSB2aWV3SXRlbSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiB0cnVlO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgSVJlbmRlckNvbnRlbnQgUmVuZGVyKFZpZXdJdGVtIHZpZXdJdGVtLCBJVmlld01vZGVsIG93bmVyLCBJSW5wdXRzIGlucHV0cyA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdHlwZUNvbXBvbmVudCA9IEdldFR5cGVDb21wb25lbnQodmlld0l0ZW0pO1xyXG4gICAgICAgICAgICBpZiAodHlwZUNvbXBvbmVudCA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKGlucHV0cyA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpbnB1dHMgPSBDcmVhdGVJbnB1dHModmlld0l0ZW0pO1xyXG4gICAgICAgICAgICB9XHJcbmRvXHJcbntcclxuICAgIGlmIChpbnB1dHMgaXMgSW5wdXRzKVxyXG4gICAge1xyXG4gICAgICAgIHZhciBpbnB1dHNXaXRoQ2hpbGRyZW5BcnJheSA9IChJbnB1dHMpaW5wdXRzO1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaW5wdXRzV2l0aENoaWxkcmVuQXJyYXkuQ2hpbGRyZW4gPSB2aWV3SXRlbSBpcyBSb290Vmlld0l0ZW0gPyBSZW5kZXJDaGlsZHModmlld0l0ZW0sIG93bmVyKS5Ub0FycmF5UmVhY3RFbGVtZW50KCkgOiBudWxsO1xyXG4gICAgICAgICAgICBicmVhaztcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgaWYgKGlucHV0cyBpcyBJbnB1dHNDaGlsZHJlbkZ1bmMpXHJcbiAgICB7XHJcbiAgICAgICAgdmFyIGlucHV0c1dpdGhDaGlsZHJlbkZ1bmMgPSAoSW5wdXRzQ2hpbGRyZW5GdW5jKWlucHV0cztcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlucHV0c1dpdGhDaGlsZHJlbkZ1bmMuQ2hpbGRyZW4gPSBkYXRhID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBzdGFja0l0ZW0gPSBuZXcgRGF0YVN0YWNrSXRlbShkYXRhKTtcclxuICAgICAgICAgICAgICAgIG93bmVyICE9IG51bGwgPyBnbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbUxhbWJkYSgoKSA9PiBvd25lci5TZXREeW5hbWljRGF0YShzdGFja0l0ZW0pKSA6IG51bGw7XHJcbiAgICAgICAgICAgICAgICB2YXIgZWxlbWVudCA9IHZpZXdJdGVtIGlzIFJvb3RWaWV3SXRlbSA/IFJlbmRlckNoaWxkcyh2aWV3SXRlbSwgb3duZXIpLlRvQXJyYXlSZWFjdEVsZW1lbnQoKSA6IG51bGw7XHJcbiAgICAgICAgICAgICAgICBvd25lciAhPSBudWxsID8gZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21MYW1iZGEoKCkgPT4gb3duZXIuUmVzdG9yZUR5bmFtaWNEYXRhKHN0YWNrSXRlbSkpIDogbnVsbDtcclxuICAgICAgICAgICAgICAgIHJldHVybiBlbGVtZW50O1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICA7XHJcbiAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBpZiAoaW5wdXRzIGlzIElucHV0c0NoaWxkcmVuKVxyXG4gICAge1xyXG4gICAgICAgIHZhciBpbnB1dHNXaXRoQ2hpbGRyZW4gPSAoSW5wdXRzQ2hpbGRyZW4paW5wdXRzO1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaW5wdXRzV2l0aENoaWxkcmVuLkNoaWxkcmVuID0gdmlld0l0ZW0gaXMgUm9vdFZpZXdJdGVtID8gUmVuZGVyQ2hpbGRzKHZpZXdJdGVtLCBvd25lcikuVG9BcnJheVJlYWN0RWxlbWVudCgpIDogbnVsbDtcclxuICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbndoaWxlIChmYWxzZSk7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dE1vZGVsID0gQmFzZUluaXRWaWV3TW9kZWwodHlwZUNvbXBvbmVudCwgdmlld0l0ZW0sIG93bmVyLCBpbnB1dHMpO1xyXG4gICAgICAgICAgICByZXR1cm4gQ3JlYXRlQ29tcG9uZW50KHR5cGVDb21wb25lbnQsIGlucHV0TW9kZWwpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHZpcnR1YWwgSVJlbmRlckNvbnRlbnRbXSBSZW5kZXJDaGlsZHMoVmlld0l0ZW0gdmlld0l0ZW0sIElWaWV3TW9kZWwgb3duZXIpXHJcbiAgICAgICAge1xyXG5Sb290Vmlld0l0ZW0gcm9vdFZpZXdJdGVtOyAgICAgICAgICAgIGlmICgocm9vdFZpZXdJdGVtID0gdmlld0l0ZW0gYXMgUm9vdFZpZXdJdGVtKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5TZWxlY3Q8Vmlld0l0ZW0sSVJlbmRlckNvbnRlbnQ+KHJvb3RWaWV3SXRlbS5JdGVtc1xyXG4sKEZ1bmM8Vmlld0l0ZW0sSVJlbmRlckNvbnRlbnQ+KShpdGVtID0+IFZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2UuQ3JlYXRlKGl0ZW0sIG93bmVyKSkpLlRvQXJyYXkoKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBJUmVuZGVyQ29udGVudFswXTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBJUmVuZGVyQ29udGVudCBDcmVhdGVDb21wb25lbnQoVHlwZSB0eXBlQ29tcG9uZW50LCBJSW5wdXRNb2RlbCBpbnB1dE1vZGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGNvbXBvbmVudCA9IChJUmVuZGVyQ29udGVudCkgQWN0aXZhdG9yLkNyZWF0ZUluc3RhbmNlKHR5cGVDb21wb25lbnQsIGlucHV0TW9kZWwpO1xyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgd3JhcENvbXBvbmVudCBpbiBXcmFwQ29tcG9uZW50cylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY29tcG9uZW50ID0gd3JhcENvbXBvbmVudC5XcmFwKGNvbXBvbmVudCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgcmV0dXJuIGNvbXBvbmVudDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHB1YmxpYyBJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWwgQmFzZUluaXRWaWV3TW9kZWwoVHlwZSB0eXBlQ29tcG9uZW50LCBWaWV3SXRlbSB2aWV3SXRlbSwgSVZpZXdNb2RlbCBvd25lciA9IG51bGwsIElJbnB1dHMgaW5wdXRzID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dE1vZGVsID0gQ3JlYXRlSW5wdXRNb2RlbCh0eXBlQ29tcG9uZW50LCB2aWV3SXRlbSk7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuS2V5ID0gR2V0RWxlbWVudEtleSh2aWV3SXRlbSk7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuSW5wdXRzID0gaW5wdXRzO1xyXG4gICAgICAgICAgICBpbnB1dE1vZGVsLk93bmVyID0gb3duZXI7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuVmlld0l0ZW0gPSB2aWV3SXRlbTtcclxuICAgICAgICAgICAgaW5wdXRNb2RlbC5Sb290U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuRGF0YVN0YWNrID0gb3duZXIhPW51bGwmJmdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsb3duZXIuR2V0RHluYW1pY0RhdGEoKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPElEYXRhU3RhY2s+KFwia2V5MVwiKS5DbG9uZSgpOihJRGF0YVN0YWNrKW51bGw7XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gaW5wdXRNb2RlbDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCB2aXJ0dWFsIElSZWFjdFZpZXdJdGVtSW5wdXRNb2RlbCBDcmVhdGVJbnB1dE1vZGVsKFR5cGUgdHlwZUNvbXBvbmVudCwgVmlld0l0ZW0gdmlld0l0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdHlwZUlucHV0cyA9IEdldElucHV0c1R5cGVDb21wb25lbnQodHlwZUNvbXBvbmVudCk7XHJcbiAgICAgICAgICAgIHZhciBnZW5lcmljVHlwZSA9IHR5cGVvZihWaWV3SXRlbUlucHV0TW9kZWw8LD4pLk1ha2VHZW5lcmljVHlwZShuZXdbXSB7dmlld0l0ZW0uR2V0VHlwZSgpLCB0eXBlSW5wdXRzfSk7XHJcbiAgICAgICAgICAgIHJldHVybiAoSVJlYWN0Vmlld0l0ZW1JbnB1dE1vZGVsKUFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZShnZW5lcmljVHlwZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgdmlydHVhbCBUeXBlIEdldElucHV0c1R5cGVDb21wb25lbnQoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGFyZ3MgPSB0eXBlQ29tcG9uZW50LkJhc2VUeXBlLkdldEdlbmVyaWNBcmd1bWVudHMoKTtcclxuICAgICAgICAgICAgcmV0dXJuIGFyZ3MuTGVuZ3RoIDw9IDIgPyB0eXBlb2YoSW5wdXRzKSA6IGFyZ3NbMV07XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgdmlydHVhbCBUeXBlIEdldFR5cGVDb21wb25lbnQoVmlld0l0ZW0gdmlld0l0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdHlwZVZpID0gdmlld0l0ZW0uR2V0VHlwZSgpO1xyXG4gICAgICAgICAgICB2YXIgdHlwZXNSZWFjdENvbXBvbmVudCA9IENvbXBvbmVudE1hbmFnZXIuR2V0VHlwZXModHlwZW9mKElSZWFjdENvbXBvbmVudCkpO1xyXG4gICAgICAgICAgICByZXR1cm4gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxUeXBlPih0eXBlc1JlYWN0Q29tcG9uZW50LChGdW5jPFR5cGUsYm9vbD4pKGVsID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciB0eXBlcyA9IGVsLkJhc2VUeXBlLkdldEdlbmVyaWNBcmd1bWVudHMoKTtcclxuICAgICAgICAgICAgICAgIHZhciB2aVR5cGUgPSB0eXBlc1swXTtcclxuICAgICAgICAgICAgICAgIHJldHVybiB2aVR5cGUgIT0gbnVsbCAmJiB2aVR5cGUgPT0gdHlwZVZpO1xyXG4gICAgICAgICAgICB9KSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgdmlydHVhbCBzdHJpbmcgR2V0RWxlbWVudEtleShWaWV3SXRlbSB2aWV3SXRlbSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiB2aWV3SXRlbS5VaWQuVG9TdHJpbmcoKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgSUlucHV0cyBDcmVhdGVJbnB1dHMoVmlld0l0ZW0gdmlld0l0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdHlwZUNvbXBvbmVudCA9IEdldFR5cGVDb21wb25lbnQodmlld0l0ZW0pO1xyXG5cclxuICAgICAgICAgICAgdmFyIHR5cGVJbnB1dHMgPSBHZXRJbnB1dHNUeXBlQ29tcG9uZW50KHR5cGVDb21wb25lbnQpO1xyXG4gICAgICAgICAgICB2YXIgaW5wdXRzID0gKElJbnB1dHMpQWN0aXZhdG9yLkNyZWF0ZUluc3RhbmNlKHR5cGVJbnB1dHMpO1xyXG5cclxuICAgICAgICAgICAgcmV0dXJuIGlucHV0cztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIEJyaWRnZS5SZWFjdDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkV4dGVuc2lvblBvaW50cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkhlbHBlcnNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCl0Y3Qu9C/0LXRgCDQtNC70Y8g0LrQvtC90LLQtdGA0YLQsNGG0LjQuCDQutC+0LzQv9C+0L3QtdC90YLQvtCyXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIHN0YXRpYyBjbGFzcyBDb252ZXJ0UmVhY3RFbGVtZW50SGVscGVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0L3QstC10YDRgtCw0YbQuNGPINC60L7QvNC/0L7QvdC10L3RgtCwIElEb21Db250ZW50INCyIFJlYWN0RWxlbWVudFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY29udGVudFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIFJlYWN0RWxlbWVudCBUb1JlYWN0RWxlbWVudCh0aGlzIElSZW5kZXJDb250ZW50IGNvbnRlbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoY29udGVudCA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIHJlYWN0Q29tcG9uZW50ID0gY29udGVudCBhcyBJUmVhY3RDb21wb25lbnQ7XHJcbiAgICAgICAgICAgIHJldHVybiAocmVhY3RDb21wb25lbnQhPW51bGw/cmVhY3RDb21wb25lbnQuUmVhY3RFbGVtZW50OihSZWFjdEVsZW1lbnQpbnVsbCkgPz8gKFJlYWN0RWxlbWVudCkgY29udGVudFtcIl9yZWFjdEVsZW1lbnRcIl07XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIElFbnVtZXJhYmxlPFJlYWN0RWxlbWVudD4gVG9FbnVtZXJhYmxlUmVhY3RFbGVtZW50KHRoaXMgSUVudW1lcmFibGU8SVJlbmRlckNvbnRlbnQ+IGNvbnRlbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoY29udGVudCAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBmb3JlYWNoICh2YXIgZWwgaW4gY29udGVudClcclxuICAgICAgICAgICAgICAgICAgICB5aWVsZCByZXR1cm4gZWwuQ2FzdDxJUmVhY3RDb21wb25lbnQ+KCkuUmVhY3RFbGVtZW50O1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCa0L7QvdCy0LXRgNGC0LDRhtC40Y8g0L7QtNC90L7Qs9C+INC60L7QvNC/0L7QvdC10L3RgtCwIFJlYWN0RWxlbWVudCDQsiBVbmlvbiBSZWFjdEVsZW1lbnRcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImNvbnRlbnRcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyBJRW51bWVyYWJsZTxSZWFjdEVsZW1lbnQ+IFRvRW51bWVyYWJsZVJlYWN0RWxlbWVudCh0aGlzIElSZW5kZXJDb250ZW50W10gY29udGVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChjb250ZW50ID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHlpZWxkIGJyZWFrO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBpZiAoY29udGVudC5MZW5ndGggPiAwKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBmb3JlYWNoICh2YXIgZWwgaW4gY29udGVudClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB5aWVsZCByZXR1cm4gZWwuVG9SZWFjdEVsZW1lbnQoKTtcclxuXHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgUmVhY3RFbGVtZW50W10gVG9BcnJheVJlYWN0RWxlbWVudCh0aGlzIElSZW5kZXJDb250ZW50W10gY29udGVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlRvQXJyYXk8UmVhY3RFbGVtZW50PihUb0VudW1lcmFibGVSZWFjdEVsZW1lbnQoY29udGVudCkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvRg9GH0LjRgtGMINC60LvRjtGHINGA0LXQsNC60YIg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlYWN0RWxlbWVudFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIHN0cmluZyBHZXRLZXkodGhpcyBSZWFjdEVsZW1lbnQgcmVhY3RFbGVtZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIChzdHJpbmcpcmVhY3RFbGVtZW50W1wia2V5XCJdO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvRg9GH0LjRgtGMINC80LDRgdGB0LjQsiDQtNC+0YfQtdGA0L3QuNGFINGN0LvQtdC80LXQvdGC0L7QsiDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicmVhY3RFbGVtZW50XCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgUmVhY3RFbGVtZW50W10gR2V0Q2hpbGRyZW5BcnJheSh0aGlzIFJlYWN0RWxlbWVudCByZWFjdEVsZW1lbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgY2hpbGRyZW4gPSByZWFjdEVsZW1lbnRbXCJwcm9wc1wiXVtcImNoaWxkcmVuXCJdO1xyXG4gICAgICAgICAgICBpZiAoY2hpbGRyZW4gPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG5ldyBSZWFjdEVsZW1lbnRbXSB7IH07XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBhcnIgPSBjaGlsZHJlbiBhcyBBcnJheTtcclxuICAgICAgICAgICAgaWYgKGFyciAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gYXJyLkNhc3Q8UmVhY3RFbGVtZW50PigpLlRvQXJyYXkoKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIG5ld1tdIHsgKFJlYWN0RWxlbWVudCljaGlsZHJlbiB9O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvRg9GH0LjRgtGMINC00L7Rh9C10YDQvdC40LUg0Y3Qu9C10LzQtdC90YLRiyDQutCw0Log0YTRg9C90LrRhtC40Y5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlYWN0RWxlbWVudFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIEZ1bmM8SURhdGEsIFJlYWN0RWxlbWVudFtdPiBHZXRDaGlsZHJlbkZ1bmModGhpcyBSZWFjdEVsZW1lbnQgcmVhY3RFbGVtZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGYgPSByZWFjdEVsZW1lbnRbXCJwcm9wc1wiXVtcImNoaWxkcmVuXCJdO1xyXG4gICAgICAgICAgICBpZiAoZiBpcyBBY3Rpb24pXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiAoRnVuYzxJRGF0YSwgUmVhY3RFbGVtZW50W10+KWY7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24oU1IuVChcItCU0L7Rh9C10YDQvdC40LUg0Y3Qu9C10LzQtdC90YLRiyDQvdC1INGP0LLQu9GP0Y7RgtGB0Y8g0YTRg9C90LrRhtC40LXQuVwiKSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0YwgVmlld0l0ZW0g0LjQtyBwcm9wc1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicmVhY3RFbGVtZW50XCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgSVZpZXdJdGVtIEdldFZpZXdJdGVtKHRoaXMgUmVhY3RFbGVtZW50IHJlYWN0RWxlbWVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBtb2RlbCA9IHJlYWN0RWxlbWVudFtcInByb3BzXCJdW1widmFsdWVcIl1bXCJNb2RlbFwiXSBhcyBJVmlld0l0ZW1JbnB1dE1vZGVsO1xyXG4gICAgICAgICAgICByZXR1cm4gbW9kZWwhPW51bGw/bW9kZWwuVmlld0l0ZW06KElWaWV3SXRlbSludWxsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvRg9GH0LjRgtGMIFZpZXdJdGVtINC40LcgcHJvcHNcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlYWN0RWxlbWVudFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRcIj7QotC40L8g0Y3Qu9C10LzQtdC90YLQsCDQvtGC0L7QsdGA0LDQttC10L3QuNGPPC90eXBlcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCt0LvQtdC80LXQvdGCINC+0YLQvtCx0YDQsNC20LXQvdC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyBUIEdldFZpZXdJdGVtPFQ+KHRoaXMgUmVhY3RFbGVtZW50IHJlYWN0RWxlbWVudCkgd2hlcmUgVCA6IElWaWV3SXRlbVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIChUKUdldFZpZXdJdGVtKHJlYWN0RWxlbWVudCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0YwgV3JhcE1vZGVsINC40LcgcHJvcHNcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlYWN0RWxlbWVudFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIElXcmFwTW9kZWwgR2V0V3JhcE1vZGVsKHRoaXMgUmVhY3RFbGVtZW50IHJlYWN0RWxlbWVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBtb2RlbCA9IHJlYWN0RWxlbWVudFtcInByb3BzXCJdW1widmFsdWVcIl1bXCJNb2RlbFwiXSBhcyBJUmVhY3RJbnB1dE1vZGVsPFdyYXBwZXJJbnB1dHM+O1xyXG4gICAgICAgICAgICByZXR1cm4gbW9kZWwhPW51bGw/bW9kZWwuSW5wdXRzLldyYXBNb2RlbCgpOihJV3JhcE1vZGVsKW51bGw7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkRpYWdub3N0aWNzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuRGlzcGF0Y2hlcjtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZhbGlkYXRpb247XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCd0LDRgdGC0YDQvtC50LrQuCDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBjbGFzcyBDb21wb25lbnRDb250YWluZXIgOiBJQ29tcG9uZW50Q29udGFpbmVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3TW9kZWxcIj7QnNC+0LTQtdC70Yw8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBDb21wb25lbnRDb250YWluZXIoSVZpZXdNb2RlbCB2aWV3TW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250cmFjdC5Bcmd1bWVudE5vdE51bGwodmlld01vZGVsLCBcInZpZXdNb2RlbFwiKTtcclxuICAgICAgICAgICAgVmlld01vZGVsID0gdmlld01vZGVsO1xyXG4gICAgICAgIH1cclxuLy8vIDxpbmhlcml0ZG9jIC8+XHJcbnB1YmxpYyB2aXJ0dWFsIGJvb2wgUmVhZE9ubHlcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIFJlbmRlck93bmVyICE9IG51bGwgJiYgUmVuZGVyT3duZXIuQ29tcG9uZW50LlJlYWRPbmx5O1xyXG4gICAgfVxyXG59I2lmIERFQlVHXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgVmlld0l0ZW1UaGVtZSBUaGVtZVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChSZW5kZXJPd25lciA9PSBudWxsIHx8IFJlbmRlck93bmVyLkNvbXBvbmVudCA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBWaWV3SXRlbVRoZW1lLkluaGVyaXQ7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gUmVuZGVyT3duZXIuQ29tcG9uZW50LlRoZW1lO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG4jZW5kaWZcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBJVmFsaWRhdGlvbk1vZGVsIFZhbGlkYXRpb25cclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbklWYWxpZGF0aW9uVmlld01vZGVsIHZhbGlkYXRpb25WaWV3TW9kZWw7ICAgICAgICAgICAgICAgIHJldHVybiAodmFsaWRhdGlvblZpZXdNb2RlbCA9IFZpZXdNb2RlbCBhcyBJVmFsaWRhdGlvblZpZXdNb2RlbCkgIT0gbnVsbD8gdmFsaWRhdGlvblZpZXdNb2RlbC5WYWxpZGF0aW9uTW9kZWwgOiBudWxsO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG4vLy8gPGluaGVyaXRkb2MgLz5cclxucHVibGljIHZpcnR1YWwgc3RyaW5nIE5hbWVcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIFZpZXdNb2RlbC5JbnB1dE1vZGVsLktleTtcclxuICAgIH1cclxufS8vLyA8aW5oZXJpdGRvYyAvPlxyXG5wdWJsaWMgdmlydHVhbCBJQ29tcG9uZW50RGlzcGF0Y2hlciBEaXNwYXRjaGVyXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBWaWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlcjtcclxuICAgIH1cclxufVxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JzQvtC00LXQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgcmVhZG9ubHkgSVZpZXdNb2RlbCBWaWV3TW9kZWw7XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCg0L7QtNC40YLQtdC70YzRgdC60LDRjyDQvNC+0LTQtdC70YxcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIElWaWV3TW9kZWwgUmVuZGVyT3duZXJcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIFZpZXdNb2RlbC5SZW5kZXJPd25lcjtcclxuICAgIH1cclxufSAgICB9XHJcbn1cclxuIiwidXNpbmcgQnJpZGdlLkh0bWw1O1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db21wb25lbnRNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuVUkuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlVJLlNlcnZpY2VzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlNlcnZpY2VzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQodC10YDQstC40YEg0LTQu9GPINGA0LXQvdC00LXRgNCwINGB0YLRgNCw0L3QuNGG0YtcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbU2VydmljZV1cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBSZWFjdFJlbmRlclNlcnZpY2UgOiBJUmVuZGVyU2VydmljZVxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGA0LXQvdC00LXRgFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUmVuZGVyKElSZW5kZXJDb250ZW50IGVsZW1lbnQsIEVsZW1lbnQgY29udGFpbmVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQnJpZGdlLlJlYWN0LlJlYWN0LlJlbmRlcihlbGVtZW50LlRvUmVhY3RFbGVtZW50KCksIGNvbnRhaW5lcik7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcbnVzaW5nIEJyaWRnZTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQXBpO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db21wb25lbnRNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5EVE87XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5FeHRlbnNpb25zO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuSW9jLkFic3RyYWN0O1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNjcmlwdHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5TY3JpcHRzLk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNlcnZpY2VzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlNlcnZpY2VzXHJcbntcclxuICAgIFtTZXJ2aWNlXVxyXG4gICAgaW50ZXJuYWwgc2VhbGVkIGNsYXNzIFZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlIDogSVZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlXHJcbiAgICB7XHJcbiAgICAgICAgI3JlZ2lvbiBQcml2YXRlIERlZmluaXRpb25zXHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJTGlmZXRpbWVTY29wZSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgcHJpdmF0ZSBjb25zdCBzdHJpbmcgU2VydmVyS2V5ID0gXCJJU2VydmVyXCI7XHJcbiAgICAgICAgcHJpdmF0ZSBJU2NyaXB0U2VydmljZSBzY3JpcHRTZXJ2aWNlO1xyXG4gICAgICAgIHByaXZhdGUgSVJlYWN0aXZlTW9kZWxGYWN0b3J5IHJlYWN0aXZlTW9kZWxGYWN0b3J5O1xyXG4gICAgICAgIHByaXZhdGUgSUNvbnRyb2xsZXJGYWN0b3J5IGNvbnRyb2xsZXJGYWN0b3J5O1xyXG4gICAgICAgIHByaXZhdGUgSVByb3h5R2VuZXJhdG9yU2VydmljZSBwcm94eUdlbmVyYXRvclNlcnZpY2U7XHJcbnByaXZhdGUgSVNjcmlwdFNlcnZpY2UgU2NyaXB0U2VydmljZVxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gc2NyaXB0U2VydmljZSA/PyAoc2NyaXB0U2VydmljZSA9IGN1cnJlbnRTY29wZS5SZXNvbHZlPElTY3JpcHRTZXJ2aWNlPigpKTtcclxuICAgIH1cclxufXByaXZhdGUgSVJlYWN0aXZlTW9kZWxGYWN0b3J5IFJlYWN0aXZlTW9kZWxGYWN0b3J5XHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiByZWFjdGl2ZU1vZGVsRmFjdG9yeSA/PyAocmVhY3RpdmVNb2RlbEZhY3RvcnkgPSBjdXJyZW50U2NvcGUuUmVzb2x2ZTxJUmVhY3RpdmVNb2RlbEZhY3Rvcnk+KCkpO1xyXG4gICAgfVxyXG59cHJpdmF0ZSBJQ29udHJvbGxlckZhY3RvcnkgQ29udHJvbGxlckZhY3Rvcnlcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGNvbnRyb2xsZXJGYWN0b3J5ID8/IChjb250cm9sbGVyRmFjdG9yeSA9IGN1cnJlbnRTY29wZS5SZXNvbHZlPElDb250cm9sbGVyRmFjdG9yeT4oKSk7XHJcbiAgICB9XHJcbn1wcml2YXRlIElQcm94eUdlbmVyYXRvclNlcnZpY2UgUHJveHlHZW5lcmF0b3JTZXJ2aWNlXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBwcm94eUdlbmVyYXRvclNlcnZpY2UgPz8gKHByb3h5R2VuZXJhdG9yU2VydmljZSA9IGN1cnJlbnRTY29wZS5SZXNvbHZlPElQcm94eUdlbmVyYXRvclNlcnZpY2U+KCkpO1xyXG4gICAgfVxyXG59ICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY3VycmVudFNjb3BlXCI+PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgVmlld01vZGVsQ3JlYXRvclNlcnZpY2UoSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5jdXJyZW50U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgSUNvbnRyb2xsZXIgQ29udHJvbGxlckNyZWF0b3IoVHlwZSBjb250cm9sbGVyVHlwZSwgSUNvbnRleHQgY29udGV4dCwgSVZpZXdNb2RlbCB2aWV3TW9kZWwsIElWaWV3SXRlbSB2aWV3SXRlbSA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBJQ29udHJvbGxlciBjb250cm9sbGVyO1xyXG4gICAgICAgICAgICB1c2luZyAobmV3IFByb3h5R2VuZXJhdG9yU2VydmljZUNvbnRleHQocHJveHlHZW5lcmF0b3JTZXJ2aWNlKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY29udHJvbGxlciA9IChJQ29udHJvbGxlcilDb250cm9sbGVyRmFjdG9yeS5DcmVhdGVDb250cm9sbGVyKGNvbnRyb2xsZXJUeXBlKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBjb250cm9sbGVyLlNldEFuZENyZWF0ZVBsYWluUHJvcGVydHlWYWx1ZShcIkNvbnRleHRcIiwgY29udGV4dCk7XHJcbiAgICAgICAgICAgIGNvbnRyb2xsZXIuU2V0QW5kQ3JlYXRlUGxhaW5Qcm9wZXJ0eVZhbHVlKFwiQ29tcG9uZW50XCIsIHZpZXdNb2RlbC5Db21wb25lbnQpO1xyXG4gICAgICAgICAgICBjb250cm9sbGVyLlNldEFuZENyZWF0ZVBsYWluUHJvcGVydHlWYWx1ZShEdG9Db25zdGFudHMuUHJveHlHZW5lcmF0b3IsIFByb3h5R2VuZXJhdG9yU2VydmljZSk7XHJcbklSZXF1aXJlVmlld0l0ZW1Db250cm9sbGVyIHZpZXdJdGVtQ29udHJvbGxlcjtcclxuICAgICAgICAgICAgaWYgKCh2aWV3SXRlbUNvbnRyb2xsZXIgPSBjb250cm9sbGVyIGFzIElSZXF1aXJlVmlld0l0ZW1Db250cm9sbGVyKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2aWV3SXRlbUNvbnRyb2xsZXIuU2V0Vmlld0l0ZW0odmlld0l0ZW0pO1xyXG4gICAgICAgICAgICB9XHJcbklSZXF1aXJlT3duZXJDb250cm9sbGVyIG93bmVyQ29udHJvbGxlcjtcclxuICAgICAgICAgICAgaWYgKChvd25lckNvbnRyb2xsZXIgPSBjb250cm9sbGVyIGFzIElSZXF1aXJlT3duZXJDb250cm9sbGVyKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBvd25lckNvbnRyb2xsZXIuU2V0T3duZXIodmlld01vZGVsLlJlbmRlck93bmVyKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIGNvbnRyb2xsZXI7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVCBDcmVhdGVNb2RlbDxUPigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gKFQpQ3JlYXRlTW9kZWwodHlwZW9mKFQpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBvYmplY3QgQ3JlYXRlTW9kZWwoVHlwZSB0eXBlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIG1vZGVsID0gKElWaWV3TW9kZWwpUmVhY3RpdmVNb2RlbEZhY3RvcnkuQ3JlYXRlTW9kZWwodHlwZSk7XHJcbiAgICAgICAgICAgIG1vZGVsW1Njb3BlZENvbXBvbmVudENvbnN0YW50cy5DdXJyZW50U2NvcGVdID0gY3VycmVudFNjb3BlO1xyXG4gICAgICAgICAgICByZXR1cm4gbW9kZWw7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIEluaXRTZXJ2ZXJDb250cm9sbGVyUHJveHkoSUNvbnRyb2xsZXIgY29udHJvbGxlciwgVHlwZSBAbmFtZXNwYWNlLCBzdHJpbmcgYXNzZW1ibHlOYW1lLCBNb2RlbEluZm8gbW9kZWxJbmZvLCBJVmlld01vZGVsIHZpZXdNb2RlbCwgcGFyYW1zIFNlcmlhbGl6ZWRNb2RlbFBhcmFtW10gYWRkaXRpb25hbE1vZGVscylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjb250cm9sbGVyRnVsbE5hbWUgPSBcIlwiO1xyXG5JQ2xpZW50Q29udHJvbGxlciBjbGllbnRDb250cm9sbGVyOyAgICAgICAgICAgIGlmICgoY2xpZW50Q29udHJvbGxlciA9IGNvbnRyb2xsZXIgYXMgSUNsaWVudENvbnRyb2xsZXIpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNsaWVudENvbnRyb2xsZXIuU2V0QW5kQ3JlYXRlUGxhaW5Qcm9wZXJ0eVZhbHVlKFxyXG4gICAgICAgICAgICAgICAgICAgIFwiU2VydmVyXCIsXHJcbiAgICAgICAgICAgICAgICAgICAgQ3JlYXRlUHJveHlTZXJ2ZXJDb250cm9sbGVyKGNsaWVudENvbnRyb2xsZXIuQ29udGV4dCwgQG5hbWVzcGFjZSwgYXNzZW1ibHlOYW1lLCBtb2RlbEluZm8sIHZpZXdNb2RlbCwgb3V0IGNvbnRyb2xsZXJGdWxsTmFtZSwgYWRkaXRpb25hbE1vZGVscylcclxuICAgICAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBjb250cm9sbGVyRnVsbE5hbWU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgYXN5bmMgVGFzayBJbml0Q2xpZW50Q29udHJvbGxlcihJQ29udHJvbGxlciBjb250cm9sbGVyLCBzdHJpbmcgY29udHJvbGxlckZ1bGxOYW1lLCBzdHJpbmcgb25Mb2FkU2NyaXB0TmFtZSwgSURhdGFTdGFjayBkYXRhU3RhY2ssIE1vZGVsSW5mbyBtb2RlbEluZm8sIElWaWV3TW9kZWwgdmlld01vZGVsLCBzdHJpbmcgZGVmYXVsdE9uTG9hZFNjcmlwdE5hbWUsIHBhcmFtcyBBZGRpdGlvbmFsTW9kZWxbXSBhZGRpdGlvbmFsTW9kZWxzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgRXhlY3V0ZU9uSW5pdChjb250cm9sbGVyLCB2aWV3TW9kZWwpO1xyXG4gICAgICAgICAgICBpZiAoIXN0cmluZy5Jc051bGxPckVtcHR5KGNvbnRyb2xsZXJGdWxsTmFtZSkgJiYgIXN0cmluZy5Jc051bGxPckVtcHR5KG9uTG9hZFNjcmlwdE5hbWUpKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBhd2FpdCBFeGVjdXRlU2VydmVyT25Mb2FkKGNvbnRyb2xsZXIsIGNvbnRyb2xsZXJGdWxsTmFtZSwgb25Mb2FkU2NyaXB0TmFtZSwgdmlld01vZGVsKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBlbHNlIGlmIChkZWZhdWx0T25Mb2FkU2NyaXB0TmFtZSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBhd2FpdCBFeGVjdXRlRXFsKGNvbnRyb2xsZXIsIGRlZmF1bHRPbkxvYWRTY3JpcHROYW1lLCB2aWV3TW9kZWwsIG1vZGVsSW5mbywgYWRkaXRpb25hbE1vZGVscyk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgRXhlY3V0ZU9uTG9hZChjb250cm9sbGVyLCB2aWV3TW9kZWwpO1xyXG4gICAgICAgICAgICBhd2FpdCBFeGVjdXRlT25Mb2FkQXN5bmMoY29udHJvbGxlciwgdmlld01vZGVsKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEV4ZWN1dGVPbkluaXQoSUNvbnRyb2xsZXIgY29udHJvbGxlciwgSVZpZXdNb2RlbCB2aWV3TW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgb25Jbml0Q29udHJvbGxlciA9IGNvbnRyb2xsZXIgYXMgSU9uSW5pdDtcclxuICAgICAgICAgICAgaWYgKG9uSW5pdENvbnRyb2xsZXIgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2aWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uKSgoKSA9PiBvbkluaXRDb250cm9sbGVyLk9uSW5pdCgpKSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVGFzayBFeGVjdXRlU2VydmVyT25Mb2FkKElDb250cm9sbGVyIGNvbnRyb2xsZXIsIHN0cmluZyBjb250cm9sbGVyRnVsbE5hbWUsIHN0cmluZyBvbkxvYWRTY3JpcHROYW1lLCBJVmlld01vZGVsIHZpZXdNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjbGllbnRDb250cm9sbGVyID0gY29udHJvbGxlciBhcyBJQ2xpZW50Q29udHJvbGxlcjtcclxuICAgICAgICAgICAgaWYgKGNsaWVudENvbnRyb2xsZXIgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPckVtcHR5KGNvbnRyb2xsZXJGdWxsTmFtZSkgfHwgc3RyaW5nLklzTnVsbE9yRW1wdHkob25Mb2FkU2NyaXB0TmFtZSkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBUYXNrLkNvbXBsZXRlZFRhc2s7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBicmFjZUluZGV4ID0gb25Mb2FkU2NyaXB0TmFtZS5JbmRleE9mKFwiKFwiLCBTdHJpbmdDb21wYXJpc29uLk9yZGluYWwpO1xyXG4gICAgICAgICAgICBpZiAoYnJhY2VJbmRleCAhPSAtMSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgLypcclxuICAgICAgICAgICAgICAgICAqINC90LAg0LLRi9C/0L7Qu9C90LXQvdC40LUg0L/RgNC40YjRkdC7INGB0YLQsNGA0YvQuSDRgdC10YDQstC10YDQvdGL0Lkg0YHQutGA0LjQv9GCINCyINGE0L7RgNC80LDRgtC1XHJcbiAgICAgICAgICAgICAgICAgKiBGb3JtT25Mb2FkRm9ybShFbGVXaXNlLkVMTUEuQ29uZmlndXJhdGlvbk1vZGVsLklPYmplY3RUaHJlZSwgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzLkZvcm1WaWV3QnVpbGRlcmAxW1tFbGVXaXNlLkVMTUEuQ29uZmlndXJhdGlvbk1vZGVsLklPYmplY3RUaHJlZV1dKSAtIEZvcm1PbkxvYWRGb3JtKElPYmplY3RUaHJlZSBlbnRpdHksIEZvcm1WaWV3QnVpbGRlcjxJT2JqZWN0VGhyZWU+IGZvcm0pXHJcbiAgICAgICAgICAgICAgICAgKlxyXG4gICAgICAgICAgICAgICAgICog0LLRi9GA0LXQt9Cw0LXQvCDQstGB0ZEsINC60YDQvtC80LUg0LjQvNC10L3QuCDQvNC10YLQvtC00LBcclxuICAgICAgICAgICAgICAgICAqL1xyXG4gICAgICAgICAgICAgICAgb25Mb2FkU2NyaXB0TmFtZSA9IG9uTG9hZFNjcmlwdE5hbWUuU3Vic3RyaW5nKDAsIGJyYWNlSW5kZXgpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgb25Mb2FkTWV0aG9kTmFtZSA9IHN0cmluZy5Gb3JtYXQoXCJ7MH0kezF9XCIsY29udHJvbGxlckZ1bGxOYW1lLG9uTG9hZFNjcmlwdE5hbWUpO1xyXG4gICAgICAgICAgICB2YXIgb25Mb2FkID0gY2xpZW50Q29udHJvbGxlci5TZXJ2ZXIuR2V0UGxhaW5Qcm9wZXJ0eVZhbHVlPEZ1bmM8SVZpZXdNb2RlbCwgVGFzaz4+KG9uTG9hZE1ldGhvZE5hbWUpO1xyXG4gICAgICAgICAgICBpZiAob25Mb2FkICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgcmV0dXJuIG9uTG9hZCh2aWV3TW9kZWwpO1xyXG4gICAgICAgICAgICB9XHJcbklGb3JtVmlld01vZGVsIGZvcm1WaWV3TW9kZWw7XHJcbiAgICAgICAgICAgIGlmICgoZm9ybVZpZXdNb2RlbCA9IHZpZXdNb2RlbCBhcyBJRm9ybVZpZXdNb2RlbCkgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIG1vZGVsSW5mbyA9IGZvcm1WaWV3TW9kZWwuTW9kZWxNZXRhZGF0YS5Nb2RlbEluZm87XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gU2NyaXB0U2VydmljZS5FeGVjdXRlU2NyaXB0KFxyXG4gICAgICAgICAgICAgICAgICAgIG5ldyBTY3JpcHRFeGVjdXRpb25QYXJhbXMoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGNsaWVudENvbnRyb2xsZXIuQ29udGV4dC5BczxSZWFjdGl2ZVByb3h5PigpLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBtb2RlbEluZm8sXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZpZXdNb2RlbCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgb25Mb2FkU2NyaXB0TmFtZVxyXG4gICAgICAgICAgICAgICAgICAgIClcclxuICAgICAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBUYXNrLkNvbXBsZXRlZFRhc2s7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVGFzayBFeGVjdXRlRXFsKElDb250cm9sbGVyIGNvbnRyb2xsZXIsIHN0cmluZyBkZWZhdWx0T25Mb2FkU2NyaXB0TmFtZSwgSVZpZXdNb2RlbCB2aWV3TW9kZWwsIE1vZGVsSW5mbyBtb2RlbEluZm8sIHBhcmFtcyBBZGRpdGlvbmFsTW9kZWxbXSBhZGRpdGlvbmFsTW9kZWxzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGNsaWVudENvbnRyb2xsZXIgPSBjb250cm9sbGVyIGFzIElDbGllbnRDb250cm9sbGVyO1xyXG4gICAgICAgICAgICBpZiAoY2xpZW50Q29udHJvbGxlciA9PSBudWxsIHx8IGRlZmF1bHRPbkxvYWRTY3JpcHROYW1lID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBUYXNrLkNvbXBsZXRlZFRhc2s7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBTY3JpcHRTZXJ2aWNlLkV4ZWN1dGVTY3JpcHQoXHJcbiAgICAgICAgICAgICAgICBuZXcgIFNjcmlwdEV4ZWN1dGlvblBhcmFtcyhcclxuICAgICAgICAgICAgICAgICAgICBjbGllbnRDb250cm9sbGVyLkNvbnRleHQuQXM8UmVhY3RpdmVQcm94eT4oKSxcclxuICAgICAgICAgICAgICAgICAgICBtb2RlbEluZm8sXHJcbiAgICAgICAgICAgICAgICAgICAgdmlld01vZGVsLFxyXG4gICAgICAgICAgICAgICAgICAgIGRlZmF1bHRPbkxvYWRTY3JpcHROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgIGFkZGl0aW9uYWxNb2RlbHNcclxuICAgICAgICAgICAgICAgIClcclxuICAgICAgICAgICAgKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEV4ZWN1dGVPbkxvYWQoSUNvbnRyb2xsZXIgY29udHJvbGxlciwgSVZpZXdNb2RlbCB2aWV3TW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgb25Mb2FkQ29udHJvbGxlciA9IGNvbnRyb2xsZXIgYXMgSU9uTG9hZDtcclxuICAgICAgICAgICAgaWYgKG9uTG9hZENvbnRyb2xsZXIgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2aWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uKSgoKSA9PiBvbkxvYWRDb250cm9sbGVyLk9uTG9hZCgpKSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVGFzayBFeGVjdXRlT25Mb2FkQXN5bmMoSUNvbnRyb2xsZXIgY29udHJvbGxlciwgSVZpZXdNb2RlbCB2aWV3TW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgb25Mb2FkQXN5bmNDb250cm9sbGVyID0gY29udHJvbGxlciBhcyBJT25Mb2FkQXN5bmM7XHJcbiAgICAgICAgICAgIGlmIChvbkxvYWRBc3luY0NvbnRyb2xsZXIgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIHZpZXdNb2RlbC5Db21wb25lbnREaXNwYXRjaGVyLkRpc3BhdGNoKChGdW5jPFRhc2s+KSgoKSA9PiBvbkxvYWRBc3luY0NvbnRyb2xsZXIuT25Mb2FkQXN5bmMoKSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIFR5cGUgR2V0U2VydmVyQ29udHJvbGxlclR5cGUoVHlwZSBAbmFtZXNwYWNlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgLy8g0JPQtdC90LXRgNCw0YbQuNGPINC/0YDQvtC60YHQuCDQtNC70Y8g0LjQvdGC0LXRgNGE0LXQudGB0LAg0YHQtdGA0LLQtdGA0L3QvtCz0L4g0LrQvtC90YLRgNC+0LvQu9C10YDQsFxyXG4gICAgICAgICAgICB2YXIgc2VydmVyQ29udHJvbGxlckludGVyZmFjZVR5cGUgPSBTY3JpcHQuV3JpdGU8VHlwZT4oXCIkbmFtZXNwYWNlW3swfV1cIiwgU2VydmVyS2V5KTtcclxuICAgICAgICAgICAgaWYgKHNlcnZlckNvbnRyb2xsZXJJbnRlcmZhY2VUeXBlID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBudWxsO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gc2VydmVyQ29udHJvbGxlckludGVyZmFjZVR5cGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIEdldFNlcnZlckNvbnRyb2xsZXJGdWxsTmFtZShUeXBlIHNlcnZlckNvbnRyb2xsZXJJbnRlcmZhY2VUeXBlLCBzdHJpbmcgYXNzZW1ibHlOYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIG1vZHVsZVByZWZpeCA9IGFzc2VtYmx5TmFtZS5SZXBsYWNlKCcuJywgJ18nKTtcclxuICAgICAgICAgICAgcmV0dXJuIHN0cmluZy5Gb3JtYXQoXCJ7MH0kezF9XCIsbW9kdWxlUHJlZml4LHNlcnZlckNvbnRyb2xsZXJJbnRlcmZhY2VUeXBlLkZ1bGxOYW1lLlJlcGxhY2UoJy4nLCAnJCcpLlJlcGxhY2UoJysnLCAnJCcpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgSVNlcnZlckNvbnRyb2xsZXIgQ3JlYXRlUHJveHlTZXJ2ZXJDb250cm9sbGVyKElDb250ZXh0IGNvbnRleHQsIFR5cGUgQG5hbWVzcGFjZSwgc3RyaW5nIG1vZHVsZU5hbWUsIE1vZGVsSW5mbyBtb2RlbEluZm8sIElWaWV3TW9kZWwgdmlld01vZGVsLCBvdXQgc3RyaW5nIHNlcnZlckNvbnRyb2xsZXJGdWxsTmFtZSwgcGFyYW1zIFNlcmlhbGl6ZWRNb2RlbFBhcmFtW10gYWRkaXRpb25hbE1vZGVscylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHNlcnZlckNvbnRyb2xsZXJGdWxsTmFtZSA9IFwiXCI7XHJcblxyXG4gICAgICAgICAgICB2YXIgc2VydmVyQ29udHJvbGxlckludGVyZmFjZVR5cGUgPSBHZXRTZXJ2ZXJDb250cm9sbGVyVHlwZShAbmFtZXNwYWNlKTtcclxuXHJcbiAgICAgICAgICAgIHNlcnZlckNvbnRyb2xsZXJGdWxsTmFtZSA9IEdldFNlcnZlckNvbnRyb2xsZXJGdWxsTmFtZShzZXJ2ZXJDb250cm9sbGVySW50ZXJmYWNlVHlwZSwgbW9kdWxlTmFtZSk7XHJcbiAgICAgICAgICAgIHZhciBzZXJ2ZXJDb250cm9sbGVyID0gbmV3IFNlcnZlckNvbXBvbmVudENvbnRyb2xsZXJQcm94eShzZXJ2ZXJDb250cm9sbGVySW50ZXJmYWNlVHlwZSk7XHJcbiAgICAgICAgICAgIHZhciBtZXRob2RzID0gc2VydmVyQ29udHJvbGxlckludGVyZmFjZVR5cGUuR2V0TWV0aG9kcygpO1xyXG4gICAgICAgICAgICBpZiAobWV0aG9kcy5MZW5ndGggPT0gMClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHNlcnZlckNvbnRyb2xsZXI7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciB1cGRhdGVNb2RlbCA9IHRydWU7XHJcbiAgICAgICAgICAgIFJlYWN0aXZlUHJveHkgbW9kZWwgPSBudWxsO1xyXG4gICAgICAgICAgICBSZWFjdGl2ZVByb3h5IGl0ZW0gPSBudWxsO1xyXG5JTWV0YWRhdGFWaWV3TW9kZWwgbWV0YWRhdGFWaWV3TW9kZWw7ICAgICAgICAgICAgaWYgKChtZXRhZGF0YVZpZXdNb2RlbCA9IHZpZXdNb2RlbCBhcyBJTWV0YWRhdGFWaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtb2RlbE1ldGFkYXRhID0gbWV0YWRhdGFWaWV3TW9kZWwuTW9kZWxNZXRhZGF0YTtcclxuICAgICAgICAgICAgICAgIGlmIChtb2RlbE1ldGFkYXRhLk1ldGFkYXRhIGlzIFRhYmxlUGFydE1ldGFkYXRhKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciByb290ID0gbW9kZWxNZXRhZGF0YS5Sb290KCk7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHJvb3QgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIG1vZGVsID0gcm9vdC5Nb2RlbCBhcyBSZWFjdGl2ZVByb3h5O1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpdGVtID0gbW9kZWxNZXRhZGF0YS5HZXRNb2RlbEZ1bmMoKS5BczxSZWFjdGl2ZVByb3h5PigpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB1cGRhdGVNb2RlbCA9IGZhbHNlO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKG1vZGVsID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIG1vZGVsID0gY29udGV4dC5BczxSZWFjdGl2ZVByb3h5PigpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgbWV0aG9kIGluIG1ldGhvZHMpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtZXRob2ROYW1lID0gbWV0aG9kLk5hbWU7XHJcbiAgICAgICAgICAgICAgICBpZiAoIUFwaVByb3ZpZGVyLklzVGFzayhtZXRob2QuUmV0dXJuVHlwZSkpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdGhyb3cgbmV3IEFyZ3VtZW50RXhjZXB0aW9uKFNSLlQoXCLQnNC10YLQvtC0IFxcXCJ7MH1cXFwiINC00L7Qu9C20LXQvSDQuNC80LXRgtGMINGC0LjQvyDQstC+0LfQstGA0LDRidCw0LXQvNC+0LPQviDQt9C90LDRh9C10L3QuNGPIHsxfVwiLCBtZXRob2ROYW1lLCB0eXBlb2YoVGFzazw+KS5GdWxsTmFtZSkpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBtb2RlbHNGb3JNZXRob2QgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLldoZXJlPFNlcmlhbGl6ZWRNb2RlbFBhcmFtPihhZGRpdGlvbmFsTW9kZWxzLChGdW5jPFNlcmlhbGl6ZWRNb2RlbFBhcmFtLGJvb2w+KShwID0+IHAuTWV0aG9kTmFtZSA9PSBtZXRob2QuTmFtZSB8fCBwLk1ldGhvZE5hbWUgPT0gU2VyaWFsaXplZE1vZGVsUGFyYW0uQWxsTWV0aG9kTmFtZSkpLlNlbGVjdDxBZGRpdGlvbmFsTW9kZWw+KChGdW5jPFNlcmlhbGl6ZWRNb2RlbFBhcmFtLEFkZGl0aW9uYWxNb2RlbD4pKHAgPT4gcC5Nb2RlbCkpLlRvQXJyYXkoKTtcclxuXHJcbiAgICAgICAgICAgICAgICBGdW5jPElWaWV3TW9kZWwsIFRhc2s+IGV4ZWN1dGVTZXJ2ZXJGdW5jID0gY3VycmVudFZpZXdNb2RlbCA9PlxyXG4gICAgICAgICAgICAgICAge1xyXG5JTWV0YWRhdGFWaWV3TW9kZWwgY3VycmVudE1ldGFkYXRhVmlld01vZGVsOyAgICAgICAgICAgICAgICAgICAgaWYgKChjdXJyZW50TWV0YWRhdGFWaWV3TW9kZWwgPSBjdXJyZW50Vmlld01vZGVsIGFzIElNZXRhZGF0YVZpZXdNb2RlbCkgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBjdXJyZW50TW9kZWxNZXRhZGF0YSA9IGN1cnJlbnRNZXRhZGF0YVZpZXdNb2RlbC5Nb2RlbE1ldGFkYXRhO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAoY3VycmVudE1vZGVsTWV0YWRhdGEuTWV0YWRhdGEgaXMgVGFibGVQYXJ0TWV0YWRhdGEpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciByb290ID0gY3VycmVudE1vZGVsTWV0YWRhdGEuUm9vdCgpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHJvb3QgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBtb2RlbCA9IHJvb3QuTW9kZWwgYXMgUmVhY3RpdmVQcm94eTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBpdGVtID0gY3VycmVudE1vZGVsTWV0YWRhdGEuR2V0TW9kZWxGdW5jKCkuQXM8UmVhY3RpdmVQcm94eT4oKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB1cGRhdGVNb2RlbCA9IGZhbHNlO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZpZXdNb2RlbCA9IGN1cnJlbnRWaWV3TW9kZWw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBTY3JpcHRTZXJ2aWNlLkV4ZWN1dGVTY3JpcHQoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIG5ldyBTY3JpcHRFeGVjdXRpb25QYXJhbXMoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBtb2RlbCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIG1vZGVsSW5mbyxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZpZXdNb2RlbCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIG1ldGhvZE5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBpdGVtLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgdXBkYXRlTW9kZWwsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBtb2RlbHNGb3JNZXRob2RcclxuICAgICAgICAgICAgICAgICAgICAgICAgKVxyXG4gICAgICAgICAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgICAgICB9O1xyXG5cclxuICAgICAgICAgICAgICAgIHNlcnZlckNvbnRyb2xsZXIuU2V0QW5kQ3JlYXRlUGxhaW5Qcm9wZXJ0eVZhbHVlKHN0cmluZy5Gb3JtYXQoXCJ7MH0kezF9XCIsc2VydmVyQ29udHJvbGxlckZ1bGxOYW1lLG1ldGhvZE5hbWUpLCBleGVjdXRlU2VydmVyRnVuYyk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgcmV0dXJuIHNlcnZlckNvbnRyb2xsZXI7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBbVGVtcGxhdGUoXCJ7MH1cIildXHJcbiAgICAgICAgc3RhdGljIGV4dGVybiBGdW5jPFQ+IExhbWJkYTxUPihGdW5jPFQ+IHgpO1xyXG4gICAgfVxyXG5cclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQn9Cw0YDQsNC80LXRgtGAINC00L7Qv9C+0LvQvdC40YLQtdC70YzQvdC+0Lkg0LzQvtC00LXQu9C4INC00LvRjyDQutC+0L3QutGA0LXRgtC90L7Qs9C+INC80LXRgtC+0LTQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBzZWFsZWQgY2xhc3MgU2VyaWFsaXplZE1vZGVsUGFyYW1cclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0LzRjyDQvNC10YLQvtC00LAg0L/RgNC4INC60L7RgtC+0YDQvtC8INC80L7QtNC10LvRjCDQsdGD0LTRg9GCINC/0LXRgNC10LTQsNCy0LDRgtGM0YHRjyDQtNC70Y8g0LLRgdC10YUg0LzQtdGC0L7QtNC+0LIg0LrQvtC90YLRgNC+0LvQu9C10YDQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIGNvbnN0IHN0cmluZyBBbGxNZXRob2ROYW1lID0gXCIkQWxsTWV0aG9kTmFtZVwiO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGhvZE5hbWVcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1vZGVsXCI+PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgU2VyaWFsaXplZE1vZGVsUGFyYW0oc3RyaW5nIG1ldGhvZE5hbWUsIEFkZGl0aW9uYWxNb2RlbCBtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIE1ldGhvZE5hbWUgPSBtZXRob2ROYW1lO1xyXG4gICAgICAgICAgICBNb2RlbCA9IG1vZGVsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmNC80Y8g0LzQtdGC0L7QtNCwINC60L7QvdGC0YDQvtC70LvQtdGA0LAg0LTQu9GPINC60L7RgtC+0YDQvtCz0L4g0L3Rg9C20L3QviDQv9C10YDQtdC00LLQsNGC0Ywg0L/QsNGA0LDQvNC10YLRgFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBNZXRob2ROYW1lIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC+0LTQtdC70YxcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBBZGRpdGlvbmFsTW9kZWwgTW9kZWwgeyBnZXQ7IHNldDsgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIFN5c3RlbS5MaW5xO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db21wb25lbnRNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuRGlhZ25vc3RpY3M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlVJLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5SZW5kZXJlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlVJLlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld3M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5TZXJ2aWNlcztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5TZXJ2aWNlc1xyXG57XHJcbiAgICBbU2VydmljZV1cclxuICAgIHB1YmxpYyBjbGFzcyBWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlIDogSVZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2VcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElFbnVtZXJhYmxlPElWaWV3SXRlbVJlbmRlcmVyPiByZW5kZXJlcnM7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJUmVhY3RpdmVNb2RlbEZhY3RvcnkgcmVhY3RpdmVNb2RlbEZhY3Rvcnk7XHJcblxyXG4gICAgICAgIHB1YmxpYyBWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlKElFbnVtZXJhYmxlPElWaWV3SXRlbVJlbmRlcmVyPiByZW5kZXJlcnMsIElSZWFjdGl2ZU1vZGVsRmFjdG9yeSByZWFjdGl2ZU1vZGVsRmFjdG9yeSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMucmVuZGVyZXJzID0gcmVuZGVyZXJzO1xyXG4gICAgICAgICAgICB0aGlzLnJlYWN0aXZlTW9kZWxGYWN0b3J5ID0gcmVhY3RpdmVNb2RlbEZhY3Rvcnk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgSVJlbmRlckNvbnRlbnQgQ3JlYXRlKFZpZXdJdGVtIHZpZXdJdGVtLCBJVmlld01vZGVsIG93bmVyLCBJSW5wdXRzIGlucHV0cyA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250cmFjdC5Bcmd1bWVudE5vdE51bGwodmlld0l0ZW0sIFwidmlld0l0ZW1cIik7XHJcblxyXG4gICAgICAgICAgICB2YXIgcmVuZGVyZXIgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLkZpcnN0T3JEZWZhdWx0PElWaWV3SXRlbVJlbmRlcmVyPihyZW5kZXJlcnMsKEZ1bmM8SVZpZXdJdGVtUmVuZGVyZXIsYm9vbD4pKHIgPT4gci5DYW5SZW5kZXIodmlld0l0ZW0pKSk7XHJcbiAgICAgICAgICAgIGlmIChyZW5kZXJlciA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB0aHJvdyBuZXcgRXhjZXB0aW9uKFNSLlQoXCLQndC1INC90LDQudC00LXQvdCwINGC0L7Rh9C60LAg0YDQsNGB0YjQuNGA0LXQvdC40Y8g0LTQu9GPINC+0YLRgNC40YHQvtCy0LrQuCDRjdC70LXQvNC10L3RgtCwINC/0YDQtdC00YHRgtCw0LLQu9C10L3QuNGPINGE0L7RgNC80YsgezB9XCIsIHZpZXdJdGVtKSk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiByZW5kZXJlci5SZW5kZXIodmlld0l0ZW0sIG93bmVyLCBpbnB1dHMpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIElSZW5kZXJDb250ZW50IENyZWF0ZShHdWlkIHVpZCwgSVZpZXdNb2RlbCBvd25lciwgSUlucHV0cyBpbnB1dHMgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHZpZXdJdGVtID0gcmVhY3RpdmVNb2RlbEZhY3RvcnkuQ3JlYXRlTW9kZWw8Q29tcG9uZW50Vmlld0l0ZW0+KCk7XHJcbiAgICAgICAgICAgIHZpZXdJdGVtLlVpZCA9IHVpZDtcclxuICAgICAgICAgICAgdmlld0l0ZW0uSGVhZGVyVWlkID0gdWlkO1xyXG5cclxuICAgICAgICAgICAgcmV0dXJuIENyZWF0ZSh2aWV3SXRlbSwgb3duZXIsIGlucHV0cyk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59IiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5UeXBlcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5VSS5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Nb2RlbC5NYW5hZ2VycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuRXh0ZW5zaW9uUG9pbnRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuRFRPO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuRXh0ZW5zaW9ucztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLkFjdGlvbnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5BdHRyaWJ1dGVzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuTWV0YWRhdGE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5NZXRhZGF0YS5EVE8uTWFuYWdlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5TY3JpcHRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuU2lnbmF0dXJlcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlR5cGVzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVHlwZXMuU2V0dGluZ3M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNjcmlwdHMuTW9kZWxzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuU2VyaWFsaXphdGlvbjtcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNlcnZpY2VzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkNvbXBvbmVudHNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCQ0LHRgdGC0YDQsNC60YLQvdGL0Lkg0L7QsdGA0LDQsdC+0YLRh9C40Log0YHQvtC30LTQsNC90LjRjyDQutC+0L3RgtC10LrRgdGC0LAgVmlld01vZGVsXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgW0NvbXBvbmVudF1cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBBYnN0cmFjdFZpZXdNb2RlbENvbnRleHRIYW5kbGVyIDogSVZpZXdNb2RlbENvbnRleHRIYW5kbGVyXHJcbiAgICB7XHJcbiAgICAgICAgcHJvdGVjdGVkIHJlYWRvbmx5IElNZXRhZGF0YVNlcnZpY2VDb250ZXh0IG1ldGFkYXRhU2VydmljZUNvbnRleHQ7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJQ3VycmVudFBhZ2VTZXJ2aWNlIGN1cnJlbnRQYWdlU2VydmljZTtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElDb252ZXJ0U2VydmljZSBjb252ZXJ0U2VydmljZTtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElBY3Rpb25FeGVjdXRpb25GYWNhZGUgYWN0aW9uRXhlY3V0aW9uRmFjYWRlO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSURlc2NyaXB0b3JTZXJ2aWNlIGRlc2NyaXB0b3JTZXJ2aWNlO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgTW9kdWxlTWV0YWRhdGFJdGVtTWFuYWdlciBtb2R1bGVNZXRhZGF0YUl0ZW1NYW5hZ2VyO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgQ29udmVydENvbnRleHQgY29udmVydENvbnRleHQ7XHJcblxyXG4gICAgICAgIHByaXZhdGUgc3RhdGljIHJlYWRvbmx5IHN0cmluZyBUZXN0UHJvcGVydHlOYW1lID0gRHluYW1pY1Byb3BlcnR5SGVscGVyPFZpZXdJdGVtPi5HZXRFeHByZXNzaW9uPHN0cmluZz4ocSA9PiBxLlRlc3RJZCk7XHJcblxyXG4gICAgICAgIHByaXZhdGUgc3RhdGljIEd1aWQgZW50aXR5U2V0dGluZ3NDb21wdXRlZEVxbFByb3BlcnR5TWV0YWRhdGFVaWQgPSBuZXcgR3VpZChcIjc4NTIyYTEzLTEwMzktNmJjMi0zMDlmLTBhZjBhYzkxNzgxMFwiKTtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXRhZGF0YVNlcnZpY2VDb250ZXh0XCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjdXJyZW50UGFnZVNlcnZpY2VcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImNvbnZlcnRTZXJ2aWNlXCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhY3Rpb25FeGVjdXRpb25GYWNhZGVcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImRlc2NyaXB0b3JTZXJ2aWNlXCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHRlbmRFbnRpdHlTZXJ2aWNlXCI+0KHQtdGA0LLQuNGBINC00LvRjyDRgNCw0YHRiNC40YDQtdC90LjRjyBEVE8g0L3QsCDQvtGB0L3QvtCy0LUg0YHRg9GJ0L3QvtGB0YLQuDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicHJveHlHZW5lcmF0b3JTZXJ2aWNlXCI+0KHQtdGA0LLQuNGBINCz0LXQvdC10YDQsNGG0LjQuCBQcm94eTwvcGFyYW0+XHJcbiAgICAgICAgcHJvdGVjdGVkIEFic3RyYWN0Vmlld01vZGVsQ29udGV4dEhhbmRsZXIoXHJcbiAgICAgICAgICAgIElNZXRhZGF0YVNlcnZpY2VDb250ZXh0IG1ldGFkYXRhU2VydmljZUNvbnRleHQsXHJcbiAgICAgICAgICAgIElDdXJyZW50UGFnZVNlcnZpY2UgY3VycmVudFBhZ2VTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJQ29udmVydFNlcnZpY2UgY29udmVydFNlcnZpY2UsXHJcbiAgICAgICAgICAgIElBY3Rpb25FeGVjdXRpb25GYWNhZGUgYWN0aW9uRXhlY3V0aW9uRmFjYWRlLFxyXG4gICAgICAgICAgICBJRGVzY3JpcHRvclNlcnZpY2UgZGVzY3JpcHRvclNlcnZpY2UsXHJcbiAgICAgICAgICAgIE1vZHVsZU1ldGFkYXRhSXRlbU1hbmFnZXIgbW9kdWxlTWV0YWRhdGFJdGVtTWFuYWdlcixcclxuICAgICAgICAgICAgSUV4dGVuZEVudGl0eVNlcnZpY2UgZXh0ZW5kRW50aXR5U2VydmljZSxcclxuICAgICAgICAgICAgSVByb3h5R2VuZXJhdG9yU2VydmljZSBwcm94eUdlbmVyYXRvclNlcnZpY2VcclxuICAgICAgICApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGlzLm1ldGFkYXRhU2VydmljZUNvbnRleHQgPSBtZXRhZGF0YVNlcnZpY2VDb250ZXh0O1xyXG4gICAgICAgICAgICB0aGlzLmN1cnJlbnRQYWdlU2VydmljZSA9IGN1cnJlbnRQYWdlU2VydmljZTtcclxuICAgICAgICAgICAgdGhpcy5jb252ZXJ0U2VydmljZSA9IGNvbnZlcnRTZXJ2aWNlO1xyXG4gICAgICAgICAgICB0aGlzLmFjdGlvbkV4ZWN1dGlvbkZhY2FkZSA9IGFjdGlvbkV4ZWN1dGlvbkZhY2FkZTtcclxuICAgICAgICAgICAgdGhpcy5kZXNjcmlwdG9yU2VydmljZSA9IGRlc2NyaXB0b3JTZXJ2aWNlO1xyXG4gICAgICAgICAgICB0aGlzLm1vZHVsZU1ldGFkYXRhSXRlbU1hbmFnZXIgPSBtb2R1bGVNZXRhZGF0YUl0ZW1NYW5hZ2VyO1xyXG4gICAgICAgICAgICBjb252ZXJ0Q29udGV4dCA9IG5ldyBDb252ZXJ0Q29udGV4dFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBFeHRlbmRFbnRpdHlTZXJ2aWNlID0gZXh0ZW5kRW50aXR5U2VydmljZSxcclxuICAgICAgICAgICAgICAgIFByb3h5R2VuZXJhdG9yU2VydmljZSA9IHByb3h5R2VuZXJhdG9yU2VydmljZVxyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIGFic3RyYWN0IGJvb2wgQ2hlY2soSVZpZXdNb2RlbCB2aWV3TW9kZWwpO1xyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgYWJzdHJhY3QgSUNvbnRleHQgQ3JlYXRlQ29udGV4dChJQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycyBwYXJhbWV0ZXJzLCBJVmlld0l0ZW0gdmlld0l0ZW0pO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0L3QuNGG0LjQsNC70LjQt9C40YDQvtCy0LDRgtGMINGB0LLQvtC50YHRgtCy0L5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInByb3BlcnR5XCI+0KHQstC+0LnRgdGC0LLQvjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY29udGV4dFwiPtCa0L7QvdGC0LXQutGB0YI8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInBhcmFtZXRlcnNcIj7Qn9Cw0YDQsNC80LXRgtGA0Ysg0YHQvtC30LTQsNC90LjRjyDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIHByb3RlY3RlZCB2b2lkIEluaXRQcm9wZXJ0eShQcm9wZXJ0eU1ldGFkYXRhIHByb3BlcnR5LCBSZWFjdGl2ZVByb3h5IGNvbnRleHQsIElDb250ZXh0Q3JlYXRpb25QYXJhbWV0ZXJzIHBhcmFtZXRlcnMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdmlld01vZGVsID0gcGFyYW1ldGVycy5WaWV3TW9kZWw7XHJcbiAgICAgICAgICAgIElWaWV3SXRlbSB2aWV3SXRlbSA9IG51bGw7XHJcbklWaWV3SXRlbVZpZXdNb2RlbCB2aWV3SXRlbVZpZXdNb2RlbDsgICAgICAgICAgICBpZiAoKHZpZXdJdGVtVmlld01vZGVsID0gdmlld01vZGVsIGFzIElWaWV3SXRlbVZpZXdNb2RlbCkgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmlld0l0ZW0gPSB2aWV3SXRlbVZpZXdNb2RlbC5WaWV3SXRlbTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKHZpZXdJdGVtID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIHJlbmRlck93bmVyID0gdmlld01vZGVsLlJlbmRlck93bmVyO1xyXG4gICAgICAgICAgICB2YXIgcHJvcGVydHlFeHByZXNzaW9uID0gbWV0YWRhdGFTZXJ2aWNlQ29udGV4dC5HZXRQcm9wZXJ0eUV4cHJlc3Npb24ocHJvcGVydHksIGNvbnRleHQuTWV0YWRhdGEpO1xyXG4gICAgICAgICAgICB2YXIgb2JqZWN0RXhwcmVzc2lvbiA9IHByb3BlcnR5RXhwcmVzc2lvbi5PYmplY3RFeHByZXNzaW9uO1xyXG4gICAgICAgICAgICBpZiAocmVuZGVyT3duZXIgIT0gbnVsbCAmJiB2aWV3SXRlbS5EeW5hbWljUHJvcGVydGllcyAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgcHJlZml4ID0gTWV0YWRhdGFDb25zdGFudHMuSW5wdXRQcmVmaXg7XHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlNZXRhZGF0YSA9IHByb3BlcnR5IGFzIFZpZXdNb2RlbFByb3BlcnR5TWV0YWRhdGE7XHJcbiAgICAgICAgICAgICAgICBpZiAocHJvcGVydHlNZXRhZGF0YSAhPSBudWxsICYmIHByb3BlcnR5TWV0YWRhdGEuT3V0cHV0KVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHByZWZpeCA9IE1ldGFkYXRhQ29uc3RhbnRzLk91dHB1dFByZWZpeDtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICB2YXIgaW5wdXROYW1lID0gcHJlZml4ICsgb2JqZWN0RXhwcmVzc2lvbjtcclxuICAgICAgICAgICAgICAgIC8vIHRvZG8g0L/QtdGA0LXQtNC10LvQsNGC0YwsINC60L7Qs9C00LAgQnJpZGdlINC40YHQv9GA0LDQstC40YIg0YDQtdGE0LvQtdC60YHQuNGOINC/0YDQuCDQv9C+0LjRgdC60LUg0LDRgtGA0LjQsdGD0YLQvtCyXHJcbiAgICAgICAgICAgICAgICAvLyDRgtGD0YIg0JLQkNCW0J3QniDQuNC80LXQvdC90L4g0LTQstCw0LbQtNGLINC/0YDQvtCx0LXQttCw0YLRjNGB0Y8g0L/QviDRgdC/0LjRgdC60YMg0LTQuNC90LDQvNC40YfQtdGB0LrQuNGFINGB0LLQvtC50YHRgtCyXHJcbiAgICAgICAgICAgICAgICB2YXIgaW5wID0gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxDb21wdXRlZFZhbHVlPih2aWV3SXRlbS5EeW5hbWljUHJvcGVydGllcywoRnVuYzxDb21wdXRlZFZhbHVlLGJvb2w+KShpID0+IGkuTmFtZSA9PSBpbnB1dE5hbWUpKVxyXG4gICAgICAgICAgICAgICAgICAgICAgID8/IFN5c3RlbS5MaW5xLkVudW1lcmFibGUuRmlyc3RPckRlZmF1bHQ8Q29tcHV0ZWRWYWx1ZT4odmlld0l0ZW0uRHluYW1pY1Byb3BlcnRpZXMsKEZ1bmM8Q29tcHV0ZWRWYWx1ZSxib29sPikoaSA9PiBpLk5hbWUgPT0gb2JqZWN0RXhwcmVzc2lvbikpO1xyXG4gICAgICAgICAgICAgICAgaWYgKCFJbnB1dElzTnVsbE9yRW1wdHkoaW5wKSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBpZiAocHJvcGVydHkuVHlwZVVpZCA9PSBBY3Rpb25EZXNjcmlwdG9yLlVJRClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBhY3Rpb24gPSBHZXRBY3Rpb25Gb3JJbnB1dChwcm9wZXJ0eSwgaW5wLCBwYXJhbWV0ZXJzKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGFjdGlvbiA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPG9iamVjdCwgUHJvcGVydHlJbmZvRXhwcmVzc2lvbiwgb2JqZWN0Pihjb250ZXh0LCAoQWN0aW9uPG9iamVjdCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLG9iamVjdD4pQ29udmVydEhlbHBlci5SZWRlZmluZVByb3AsIGNvbnRleHQsIHByb3BlcnR5RXhwcmVzc2lvbiwgYWN0aW9uKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHByb3BlcnR5TWV0YWRhdGEgIT0gbnVsbCAmJiBwcm9wZXJ0eU1ldGFkYXRhLk91dHB1dClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmICgoQ29tcHV0ZWRWYWx1ZVR5cGUpaW5wLkNvbXB1dGVkVmFsdWVUeXBlID09IENvbXB1dGVkVmFsdWVUeXBlLlByb3BlcnR5KVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB2YXIgcmVsYXRpb25UeXBlID0gcHJvcGVydHlNZXRhZGF0YS5TZXR0aW5ncy5HZXRSZWxhdGlvblR5cGVPck51bGwoKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChyZWxhdGlvblR5cGUgIT0gbnVsbCAmJiByZWxhdGlvblR5cGUgPT0gUmVsYXRpb25UeXBlLk1hbnlUb01hbnkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPElWaWV3TW9kZWwsIElDb250ZXh0LCBHdWlkLCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uLCBDb21wdXRlZFZhbHVlLCBJRGF0YVN0YWNrPih0aGlzLCAoQWN0aW9uPElWaWV3TW9kZWwsSUNvbnRleHQsR3VpZCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLENvbXB1dGVkVmFsdWUsSURhdGFTdGFjaz4pRGVmaW5lSW5wdXRzLCByZW5kZXJPd25lciwgY29udGV4dCwgcHJvcGVydHkuVHlwZVVpZCwgcHJvcGVydHlFeHByZXNzaW9uLCBpbnAsIHBhcmFtZXRlcnMuT3V0ZXJTdGFjayk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPElWaWV3TW9kZWwsIElDb250ZXh0LCBHdWlkLCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uLCBDb21wdXRlZFZhbHVlLCBJRGF0YVN0YWNrPih0aGlzLCAoQWN0aW9uPElWaWV3TW9kZWwsSUNvbnRleHQsR3VpZCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLENvbXB1dGVkVmFsdWUsSURhdGFTdGFjaz4pRGVmaW5lU2V0dGVyUHJvcGVydHksIHJlbmRlck93bmVyLCBjb250ZXh0LCBwcm9wZXJ0eS5UeXBlVWlkLCBwcm9wZXJ0eUV4cHJlc3Npb24sIGlucCwgcGFyYW1ldGVycy5PdXRlclN0YWNrKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIENsb3N1cmVIZWxwZXIuQ2xvc3VyZTxJVmlld01vZGVsLCBJQ29udGV4dCwgR3VpZCwgUHJvcGVydHlJbmZvRXhwcmVzc2lvbiwgQ29tcHV0ZWRWYWx1ZSwgSURhdGFTdGFjaz4odGhpcywgKEFjdGlvbjxJVmlld01vZGVsLElDb250ZXh0LEd1aWQsUHJvcGVydHlJbmZvRXhwcmVzc2lvbixDb21wdXRlZFZhbHVlLElEYXRhU3RhY2s+KURlZmluZVNldHRlckNhbGxiYWNrLCByZW5kZXJPd25lciwgY29udGV4dCwgcHJvcGVydHkuVHlwZVVpZCwgcHJvcGVydHlFeHByZXNzaW9uLCBpbnAsIHBhcmFtZXRlcnMuT3V0ZXJTdGFjayk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPElWaWV3TW9kZWwsIElDb250ZXh0LCBHdWlkLCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uLCBDb21wdXRlZFZhbHVlLCBJRGF0YVN0YWNrPih0aGlzLCAoQWN0aW9uPElWaWV3TW9kZWwsSUNvbnRleHQsR3VpZCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLENvbXB1dGVkVmFsdWUsSURhdGFTdGFjaz4pRGVmaW5lSW5wdXRzLCByZW5kZXJPd25lciwgY29udGV4dCwgcHJvcGVydHkuVHlwZVVpZCwgcHJvcGVydHlFeHByZXNzaW9uLCBpbnAsIHBhcmFtZXRlcnMuT3V0ZXJTdGFjayk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKHByb3BlcnR5LlR5cGVVaWQgPT0gQWN0aW9uRGVzY3JpcHRvci5VSUQpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBhY3Rpb24gPSBHZXRBY3Rpb25Gb3JQcm9wZXJ0eShwcm9wZXJ0eSwgcGFyYW1ldGVycyk7XHJcbiAgICAgICAgICAgICAgICBpZiAoYWN0aW9uID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPG9iamVjdCwgUHJvcGVydHlJbmZvRXhwcmVzc2lvbiwgb2JqZWN0Pihjb250ZXh0LCAoQWN0aW9uPG9iamVjdCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLG9iamVjdD4pQ29udmVydEhlbHBlci5SZWRlZmluZVByb3AsIGNvbnRleHQsIHByb3BlcnR5RXhwcmVzc2lvbiwgYWN0aW9uKTtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIHByb3BlcnR5TWQgPSBwcm9wZXJ0eSBhcyBWaWV3TW9kZWxQcm9wZXJ0eU1ldGFkYXRhO1xyXG4gICAgICAgICAgICBpZiAocHJvcGVydHlNZCA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuRW50aXR5U2V0dGluZ3Mgc2V0dGluZ3M7XHJcbiAgICAgICAgICAgIGlmICgoc2V0dGluZ3MgPSBwcm9wZXJ0eU1kLlNldHRpbmdzIGFzIEVudGl0eVNldHRpbmdzKSAhPSBudWxsJiYgc2V0dGluZ3MuSXNDb21wdXRlZEVxbFZhbHVlKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgZGlzcGF0Y2hlciA9IHZpZXdNb2RlbC5Db21wb25lbnREaXNwYXRjaGVyO1xyXG4gICAgICAgICAgICAgICAgdmFyIGNvbXB1dGVkRXFsUHJvcGVydHkgPSBwcm9wZXJ0eU1kLkdldENvbXB1dGVkRXFsUHJvcGVydHkoKTtcclxuICAgICAgICAgICAgICAgIGlmIChjb21wdXRlZEVxbFByb3BlcnR5ICE9IG51bGwgJiYgY29tcHV0ZWRFcWxQcm9wZXJ0eS5Db21wdXRlZFZhbHVlVHlwZSAhPSAoaW50KUNvbXB1dGVkVmFsdWVUeXBlLklucHV0KVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIEZ1bmM8c3RyaW5nPiBnZXRGaWx0ZXJRdWVyeSA9ICgpID0+XHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAodmlld01vZGVsLkNvbnRyb2xsZXIgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIEdsb2JhbFNjb3BlSGVscGVyLlB1c2godmlld01vZGVsKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdHJ5XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBzZXR0aW5ncy5Db21wdXRlZEVxbFF1ZXJ5O1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgR2xvYmFsU2NvcGVIZWxwZXIuUG9wKHZpZXdNb2RlbCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG5cclxuICAgICAgICAgICAgICAgICAgICB2YXIgcHJveHlTZXR0aW5ncyA9IHNldHRpbmdzLkFzPFJlYWN0aXZlUHJveHk+KCk7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHNldHRpbmdzTWV0YWRhdGEgPSBwcm94eVNldHRpbmdzLk1ldGFkYXRhO1xyXG4gICAgICAgICAgICAgICAgICAgIGlmIChzZXR0aW5nc01ldGFkYXRhID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB2YXIgc2V0dGluZ3NUeXBlID0gcHJveHlTZXR0aW5ncy5HZXRQbGFpblByb3BlcnR5VmFsdWU8c3RyaW5nPihcIiR0XCIpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBzZXR0aW5nc01ldGFkYXRhID0gbWV0YWRhdGFTZXJ2aWNlQ29udGV4dC5HZXRNZXRhZGF0YUJ5SGFzaChzZXR0aW5nc1R5cGUpIGFzIENsYXNzTWV0YWRhdGE7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5DbGFzc01ldGFkYXRhIGVudGl0eVNldHRpbmdzTWV0YWRhdGE7XG5JUHJvcGVydHlNZXRhZGF0YSBlcWxQcm9wZXJ0eTtcbkJyaWRnZS5TY3JpcHQuRGVjb25zdHJ1Y3QobWV0YWRhdGFTZXJ2aWNlQ29udGV4dC5HZXRQcm9wZXJ0eVdpdGhPd25lcihzZXR0aW5nc01ldGFkYXRhLCBlbnRpdHlTZXR0aW5nc0NvbXB1dGVkRXFsUHJvcGVydHlNZXRhZGF0YVVpZCksIG91dCBlbnRpdHlTZXR0aW5nc01ldGFkYXRhLCBvdXQgZXFsUHJvcGVydHkpO1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBleHByZXNzaW9uID0gbWV0YWRhdGFTZXJ2aWNlQ29udGV4dC5HZXRQcm9wZXJ0eUV4cHJlc3Npb24oZXFsUHJvcGVydHksIGVudGl0eVNldHRpbmdzTWV0YWRhdGEpO1xyXG4gICAgICAgICAgICAgICAgICAgIENsb3N1cmVIZWxwZXIuQ2xvc3VyZTxDb21wdXRlZFZhbHVlLCBvYmplY3QsIHN0cmluZz4odGhpcywgKEFjdGlvbjxDb21wdXRlZFZhbHVlLG9iamVjdCxzdHJpbmc+KVdyaXRlR2V0dGVyQ29uZmlndXJhYmxlLCBjb21wdXRlZEVxbFByb3BlcnR5LCBzZXR0aW5ncywgZXhwcmVzc2lvbi5PYmplY3RFeHByZXNzaW9uKTtcclxuXHJcblxyXG4gICAgICAgICAgICAgICAgICAgIC8vICBUT0RPIEVMTUE0LTU3Nzcg0J/QtdGA0LXRgNCw0LHQvtGC0LDRgtGMIGpzLdCy0YHRgtCw0LLQutC4XHJcbiAgICAgICAgICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgICAgICAgICAgY29uc3QgcmVhY3Rpb24gPSBtb2J4LnJlYWN0aW9uKFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBnZXRGaWx0ZXJRdWVyeSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgZnVuY3Rpb24oY29tcHV0ZWRFcWxRdWVyeSkge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgdmlld01vZGVsLlVwZGF0ZUVxbENvbXB1dGVkVmFsdWUoY29udGV4dCwgcHJvcGVydHksIGNvbXB1dGVkRXFsUXVlcnksIGRpc3BhdGNoZXIpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgICAgICAgICAgIGlmKCF2aWV3TW9kZWwuZXFsUmVhY3Rpb25zKXtcclxuICAgICAgICAgICAgICAgICAgICAgICAgIHZpZXdNb2RlbC5lcWxSZWFjdGlvbnMgPSBbXTtcclxuICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgICB2aWV3TW9kZWwuZXFsUmVhY3Rpb25zLnB1c2gocmVhY3Rpb24pO1xyXG4gICAgICAgICAgICAgICAgICAgICAqL1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGVsc2UgaWYgKCFwcm9wZXJ0eU1kLklucHV0XHJcbiAgICAgICAgICAgICAgICAgICAgICYmIHByb3BlcnR5TWQuQ2xpZW50T25seVxyXG4gICAgICAgICAgICAgICAgICAgICAmJiBwcm9wZXJ0eU1kLkNvbXB1dGVkVmFsdWUgIT0gbnVsbFxyXG4gICAgICAgICAgICAgICAgICAgICAmJiBwcm9wZXJ0eU1kLkNvbXB1dGVkVmFsdWUuQ29tcHV0ZWRWYWx1ZVR5cGUgIT0gKGludClDb21wdXRlZFZhbHVlVHlwZS5JbnB1dFxyXG4gICAgICAgICAgICAgICAgICAgICAmJiAoKHByb3BlcnR5TWQuQ29tcHV0ZWRWYWx1ZS5Db21wdXRlZFZhbHVlVHlwZSA9PSAoaW50KUNvbXB1dGVkVmFsdWVUeXBlLkZ1bmN0aW9uICYmICFzdHJpbmcuSXNOdWxsT3JXaGl0ZVNwYWNlKHByb3BlcnR5TWQuQ29tcHV0ZWRWYWx1ZS5NZXRob2ROYW1lKSlcclxuICAgICAgICAgICAgICAgICAgICAgICAgfHwgKHByb3BlcnR5TWQuQ29tcHV0ZWRWYWx1ZS5Db21wdXRlZFZhbHVlVHlwZSA9PSAoaW50KUNvbXB1dGVkVmFsdWVUeXBlLkNhbGN1bGF0ZVNjcmlwdCAmJiAhc3RyaW5nLklzTnVsbE9yV2hpdGVTcGFjZShwcm9wZXJ0eU1kLkNvbXB1dGVkVmFsdWUuQ2FsY3VsYXRlU2NyaXB0KSkpXHJcbiAgICAgICAgICAgICAgICAgICAgIClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgLy8g0JjRgdC/0L7Qu9GM0LfRg9C10YLRgdGPINC00LvRjyDRgdCy0L7QudGB0YLQsiwg0YLQvtC70YzQutC+INC00LvRjyDQstC10LEg0YfQsNGB0YLQuChDbGllbnRPbmx5KSDQuCDRgyDQutC+0YLQvtGA0YvRhSDQt9C90LDRh9C10L3QuNC1INC/0L4g0YPQvNC+0LvRh9Cw0L3QuNGOINCy0YvRh9C40YHQu9GP0LXQvNC+0LVcclxuICAgICAgICAgICAgICAgIHZhciBjb21wdXRlZCA9IER5bmFtaWNQcm9wZXJ0eUhlbHBlci5Db21wdXRlZFZhbHVlTWFwVG9PYmplY3QocHJvcGVydHlNZC5Db21wdXRlZFZhbHVlKTtcclxuICAgICAgICAgICAgICAgIENsb3N1cmVIZWxwZXIuQ2xvc3VyZTxJVmlld01vZGVsLCBDb21wdXRlZFZhbHVlLCBvYmplY3QsIFByb3BlcnR5SW5mb0V4cHJlc3Npb24+KHRoaXMsIChBY3Rpb248SVZpZXdNb2RlbCxDb21wdXRlZFZhbHVlLG9iamVjdCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uPilXcml0ZUNvbXB1dGVkR2V0dGVyLCB2aWV3TW9kZWwsIGNvbXB1dGVkLCBjb250ZXh0LCBwcm9wZXJ0eUV4cHJlc3Npb24pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0L3QuNGG0LjQsNC70LjQt9C40YDQvtCy0LDRgtGMINC00LjQvdCw0LzQuNGH0LXRgdC60LjQtSDQvdCw0YHRgtGA0L7QudC60Lgg0YHQstC+0LnRgdGC0LJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInByb3BlcnR5XCI+0KHQstC+0LnRgdGC0LLQvjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicGFyYW1ldGVyc1wiPtCf0LDRgNCw0LzQtdGC0YDRiyDRgdC+0LfQtNCw0L3QuNGPINC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgcHJvdGVjdGVkIHZvaWQgSW5pdFByb3BlcnR5U2V0dGluZ3MoUHJvcGVydHlNZXRhZGF0YSBwcm9wZXJ0eSwgSUNvbnRleHRDcmVhdGlvblBhcmFtZXRlcnMgcGFyYW1ldGVycylcclxuICAgICAgICB7XHJcblZpZXdNb2RlbFByb3BlcnR5TWV0YWRhdGEgdmlld01vZGVsUHJvcGVydHk7ICAgICAgICAgICAgaWYgKCEoKHZpZXdNb2RlbFByb3BlcnR5ID0gcHJvcGVydHkgYXMgVmlld01vZGVsUHJvcGVydHlNZXRhZGF0YSkgIT0gbnVsbCkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5JVmlld01vZGVsV2l0aER5bmFtaWNQcm9wZXJ0eVNldHRpbmdzIHZpZXdNb2RlbFdpdGhEeW5hbWljUHJvcGVydHlTZXR0aW5ncztcclxuICAgICAgICAgICAgaWYgKCEoKHZpZXdNb2RlbFdpdGhEeW5hbWljUHJvcGVydHlTZXR0aW5ncyA9IHBhcmFtZXRlcnMuVmlld01vZGVsIGFzIElWaWV3TW9kZWxXaXRoRHluYW1pY1Byb3BlcnR5U2V0dGluZ3MpICE9IG51bGwpKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBwcm9wZXJ0eVNldHRpbmdzID0gRWxlV2lzZS5FTE1BLkRhdGFDbGFzc0hlbHBlci5DbG9uZTxUeXBlU2V0dGluZ3M+KHZpZXdNb2RlbFByb3BlcnR5LlNldHRpbmdzKTtcclxuICAgICAgICAgICAgZm9yZWFjaCAodmFyIGNvbXB1dGVkVmFsdWUgaW4gdmlld01vZGVsUHJvcGVydHkuQ29tcHV0ZWRWYWx1ZXMpXHJcbiAgICAgICAgICAgIHtcclxuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5WaWV3cy5BY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUgYWN0aW9uSW5wdXRDb21wdXRlZFZhbHVlOyAgICAgICAgICAgICAgICBpZiAoKGFjdGlvbklucHV0Q29tcHV0ZWRWYWx1ZSA9IGNvbXB1dGVkVmFsdWUgYXMgQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5WaWV3cy5BY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUpICE9IG51bGwmJiBhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUuVHlwZVVpZCA9PSBBY3Rpb25EZXNjcmlwdG9yLlVJRClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgYWN0aW9uSW5wdXRDb21wdXRlZFZhbCA9IER5bmFtaWNQcm9wZXJ0eUhlbHBlci5Db21wdXRlZFZhbHVlTWFwVG9PYmplY3QoYWN0aW9uSW5wdXRDb21wdXRlZFZhbHVlKSBhcyBBY3Rpb25JbnB1dENvbXB1dGVkVmFsdWU7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGFjdGlvblZhbHVlID0gQWN0aW9uQ29tcHV0ZWRWYWx1ZUhlbHBlci5DcmVhdGVBY3Rpb25WYWx1ZShhY3Rpb25JbnB1dENvbXB1dGVkVmFsLCBudWxsKTtcclxuICAgICAgICAgICAgICAgICAgICBJQWN0aW9uRXhlY3V0aW9uQ29udGV4dCBjb250ZXh0ID0gbmV3IEVtcHR5QWN0aW9uRXhlY3V0aW9uQ29udGV4dChwcm9wZXJ0eSwgKCkgPT4gcGFyYW1ldGVycy5WaWV3TW9kZWwuQ29udHJvbGxlcik7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKCFzdHJpbmcuSXNOdWxsT3JXaGl0ZVNwYWNlKGFjdGlvblZhbHVlLk1ldGhvZE5hbWUpKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgY29udGV4dCA9IG5ldyBDbGllbnRGdW5jdGlvbkV4ZWN1dGlvbkNvbnRleHQoYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSwgKCkgPT4gcGFyYW1ldGVycy5WaWV3TW9kZWwuQ29udHJvbGxlciwgcGFyYW1ldGVycy5PdXRlclN0YWNrKTtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIHZhciByZXR1cm5UeXBlID0gYWN0aW9uSW5wdXRDb21wdXRlZFZhbC5SZXR1cm5UeXBlO1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBwYXJhbWV0ZXJUeXBlID0gYWN0aW9uSW5wdXRDb21wdXRlZFZhbC5QYXJhbWV0ZXJUeXBlO1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBhY3Rpb24gPSBDcmVhdGVDbG9zdXJlRm9yQWN0aW9uKHJldHVyblR5cGUsIHBhcmFtZXRlclR5cGUsIGNvbnRleHQpO1xyXG4gICAgICAgICAgICAgICAgICAgIGlmIChhY3Rpb24gPT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGFjdGlvblByb3BJbmZvID0gRHluYW1pY1Byb3BlcnR5SGVscGVyLkdldER5bmFtaWNQcm9wZXJ0eUluZm8odmlld01vZGVsUHJvcGVydHksIGNvbXB1dGVkVmFsdWUuTmFtZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGluZm8gPSBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgT2JqZWN0RXhwcmVzc2lvbiA9IGFjdGlvblByb3BJbmZvLkl0ZW0yLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBFeHByZXNzaW9uRm9yU2VyaWFsaXplID0gYWN0aW9uUHJvcEluZm8uSXRlbTJcclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG5cclxuICAgICAgICAgICAgICAgICAgICBDbG9zdXJlSGVscGVyLkNsb3N1cmU8b2JqZWN0LCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uLCBvYmplY3Q+KHByb3BlcnR5U2V0dGluZ3MsIChBY3Rpb248b2JqZWN0LFByb3BlcnR5SW5mb0V4cHJlc3Npb24sb2JqZWN0PilDb252ZXJ0SGVscGVyLlJlZGVmaW5lUHJvcCwgcHJvcGVydHlTZXR0aW5ncywgaW5mbywgYWN0aW9uKTtcclxuICAgICAgICAgICAgICAgICAgICBjb250aW51ZTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoY29tcHV0ZWRWYWx1ZS5Db21wdXRlZFZhbHVlVHlwZSA9PSAoaW50KUNvbXB1dGVkVmFsdWVUeXBlLklucHV0KVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBwcm9wSW5mbyA9IER5bmFtaWNQcm9wZXJ0eUhlbHBlci5HZXREeW5hbWljUHJvcGVydHlJbmZvKHZpZXdNb2RlbFByb3BlcnR5LCBjb21wdXRlZFZhbHVlLk5hbWUpO1xyXG4gICAgICAgICAgICAgICAgdmFyIHRhcmdldCA9IHByb3BJbmZvLkl0ZW0xO1xyXG4gICAgICAgICAgICAgICAgaWYgKHRhcmdldCA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciB0YXJnZXRQcm9wZXJ0eU5hbWUgPSBwcm9wSW5mby5JdGVtMjtcclxuICAgICAgICAgICAgICAgIGlmICghdGFyZ2V0Lkhhc1Byb3BlcnR5KHRhcmdldFByb3BlcnR5TmFtZSkpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgdmFyIGNvbXB1dGVkVmFsID0gRHluYW1pY1Byb3BlcnR5SGVscGVyLkNvbXB1dGVkVmFsdWVNYXBUb09iamVjdChjb21wdXRlZFZhbHVlKTtcclxuICAgICAgICAgICAgICAgIC8vINCY0YHQv9C+0LvRjNC30YPQtdGC0YHRjyDQtNC70Y8g0YHQstC+0LnRgdGC0LIsINGDINC60L7RgtC+0YDRi9GFINC10YHRgtGMINCy0YvRh9C40YHQu9GP0LXQvNGL0LUg0L3QsNGB0YLRgNC+0LnQutC4XHJcbiAgICAgICAgICAgICAgICBDbG9zdXJlSGVscGVyLkNsb3N1cmU8Q29tcHV0ZWRWYWx1ZSwgb2JqZWN0LCBzdHJpbmc+KHRoaXMsIChBY3Rpb248Q29tcHV0ZWRWYWx1ZSxvYmplY3Qsc3RyaW5nPilXcml0ZUdldHRlciwgY29tcHV0ZWRWYWwsIHRhcmdldCwgdGFyZ2V0UHJvcGVydHlOYW1lKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmlld01vZGVsV2l0aER5bmFtaWNQcm9wZXJ0eVNldHRpbmdzLkR5bmFtaWNTZXR0aW5nc1t2aWV3TW9kZWxQcm9wZXJ0eV0gPSBwcm9wZXJ0eVNldHRpbmdzO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmNC90LjRhtC40LDQu9C40LfQsNGG0LjRjyDQtNC40L3QsNC80LjQutC4INGN0LvQtdC80LXQvdGC0L7QsiDRhNC+0YDQvNGLXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJwYXJhbWV0ZXJzXCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3SXRlbVwiPjwvcGFyYW0+XHJcbiAgICAgICAgcHJvdGVjdGVkIHZvaWQgSW5pdER5bmFtaWNQcm9wZXJ0aWVzKElDb250ZXh0Q3JlYXRpb25QYXJhbWV0ZXJzIHBhcmFtZXRlcnMsIElWaWV3SXRlbSB2aWV3SXRlbSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8vINC10YHQu9C4INC00LjQvdCw0LzQuNGH0LXRgdC60LjQtSDRgdCy0L7QudGB0YLQstCwINGD0LbQtSDQv9C10YDQtdC+0L/RgNC10LTQtdC70LXQvdGLINCy0YvRhdC+0LTQuNC8XHJcbiAgICAgICAgICAgIHZhciBvdmVyID0gdmlld0l0ZW0uR2V0UGxhaW5Qcm9wZXJ0eVZhbHVlPGJvb2w+KFwib3ZlclwiKTtcclxuICAgICAgICAgICAgaWYgKG92ZXIpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKHZpZXdJdGVtLkhpZGUpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5Gb3JtVmlld0l0ZW0gZm9ybTtcclxuICAgICAgICAgICAgaWYgKChmb3JtID0gdmlld0l0ZW0gYXMgRm9ybVZpZXdJdGVtKSAhPSBudWxsJiYgZm9ybS5Ub29sYmFyICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIEluaXREeW5hbWljUHJvcGVydGllcyhwYXJhbWV0ZXJzLCBmb3JtLlRvb2xiYXIpO1xyXG4gICAgICAgICAgICB9XHJcblJvb3RWaWV3SXRlbSByb290Vmlld0l0ZW07XHJcbiAgICAgICAgICAgIGlmICgocm9vdFZpZXdJdGVtID0gdmlld0l0ZW0gYXMgUm9vdFZpZXdJdGVtKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBmb3JlYWNoICh2YXIgaXRlbSBpbiByb290Vmlld0l0ZW0uSXRlbXMpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgSW5pdER5bmFtaWNQcm9wZXJ0aWVzKHBhcmFtZXRlcnMsIGl0ZW0pO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgbmVlZFNpbXBsZVRlc3RWYWx1ZSA9IHRydWU7XHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciBkeW5hbWljUHJvcGVydHkgaW4gdmlld0l0ZW0uRHluYW1pY1Byb3BlcnRpZXMpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChkeW5hbWljUHJvcGVydHkuTmFtZS5Db250YWlucyhcIkF0dHJpYnV0ZXMuVHlwZVNldHRpbmdzLlwiKSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBjb250aW51ZTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcEluZm8gPSBEeW5hbWljUHJvcGVydHlIZWxwZXIuR2V0RHluYW1pY1Byb3BlcnR5SW5mbyh2aWV3SXRlbSwgZHluYW1pY1Byb3BlcnR5Lk5hbWUpO1xyXG4gICAgICAgICAgICAgICAgdmFyIHRhcmdldCA9IHByb3BJbmZvLkl0ZW0xO1xyXG4gICAgICAgICAgICAgICAgaWYgKHRhcmdldCA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IHByb3BJbmZvLkl0ZW0yO1xyXG5cclxuICAgICAgICAgICAgICAgIGlmIChwcm9wZXJ0eU5hbWUgPT0gVGVzdFByb3BlcnR5TmFtZSAmJiAoQ29tcHV0ZWRWYWx1ZVR5cGUpZHluYW1pY1Byb3BlcnR5LkNvbXB1dGVkVmFsdWVUeXBlID09IENvbXB1dGVkVmFsdWVUeXBlLkZ1bmN0aW9uKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIG5lZWRTaW1wbGVUZXN0VmFsdWUgPSBmYWxzZTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoIXRhcmdldC5IYXNQcm9wZXJ0eShwcm9wZXJ0eU5hbWUpKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIGlmICgoQ29tcHV0ZWRWYWx1ZVR5cGUpZHluYW1pY1Byb3BlcnR5LkNvbXB1dGVkVmFsdWVUeXBlID09IENvbXB1dGVkVmFsdWVUeXBlLklucHV0KVxyXG4gICAgICAgICAgICAgICAge1xyXG5ib29sIGlzQWN0aW9uO1xuQWN0aW9uVmFsdWUgYWN0aW9uVmFsdWU7XG5CcmlkZ2UuU2NyaXB0LkRlY29uc3RydWN0KEFjdGlvbkNvbXB1dGVkVmFsdWVIZWxwZXIuSXNBY3Rpb24oZHluYW1pY1Byb3BlcnR5KSwgb3V0IGlzQWN0aW9uLCBvdXQgYWN0aW9uVmFsdWUpO1xyXG4gICAgICAgICAgICAgICAgICAgIGlmIChpc0FjdGlvbilcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBpbmZvID0gdGFyZ2V0LkdldFR5cGUoKS5HZXRQcm9wZXJ0eShwcm9wZXJ0eU5hbWUpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAoaW5mbyA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb250aW51ZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgSUFjdGlvbkV4ZWN1dGlvbkNvbnRleHQgZXhlY3V0aW9uQ29udGV4dCA9IG51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFR5cGUgYWN0aW9uVHlwZSA9IG51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFR5cGVTaWduYXR1cmUgcGFyYW1ldGVyVHlwZSA9IG51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFR5cGVTaWduYXR1cmUgcmV0dXJuVHlwZSA9IG51bGw7XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAoaW5mby5Qcm9wZXJ0eVR5cGUgPT0gdHlwZW9mKERlZmF1bHRBY3Rpb24pKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBhY3Rpb25UeXBlID0gdHlwZW9mKERlZmF1bHRBY3Rpb24pO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGVsc2UgaWYgKGluZm8uUHJvcGVydHlUeXBlLklzR2VuZXJpY1R5cGUpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciBnZW5lcmljQXJndW1lbnRzID0gaW5mby5Qcm9wZXJ0eVR5cGUuR2V0R2VuZXJpY0FyZ3VtZW50cygpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgdmFyIGdlbmVyaWNUeXBlRGVmaW5pdGlvbiA9IGluZm8uUHJvcGVydHlUeXBlLkdldEdlbmVyaWNUeXBlRGVmaW5pdGlvbigpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGdlbmVyaWNUeXBlRGVmaW5pdGlvbiA9PSB0eXBlb2YoQWN0aW9uV2l0aFBhcmFtPD4pKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGFjdGlvblR5cGUgPSB0eXBlb2YoQWN0aW9uV2l0aFBhcmFtPD4pLk1ha2VHZW5lcmljVHlwZShnZW5lcmljQXJndW1lbnRzKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBwYXJhbWV0ZXJUeXBlID0gY29udmVydFNlcnZpY2UuVG9TaWduYXR1cmUoU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxUeXBlPihnZW5lcmljQXJndW1lbnRzKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBlbHNlIGlmIChnZW5lcmljVHlwZURlZmluaXRpb24gPT0gdHlwZW9mKEFjdGlvbldpdGhSZXN1bHQ8PikpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYWN0aW9uVHlwZSA9IHR5cGVvZihBY3Rpb25XaXRoUmVzdWx0PD4pLk1ha2VHZW5lcmljVHlwZShnZW5lcmljQXJndW1lbnRzKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICByZXR1cm5UeXBlID0gY29udmVydFNlcnZpY2UuVG9TaWduYXR1cmUoU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxUeXBlPihnZW5lcmljQXJndW1lbnRzKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBlbHNlIGlmIChnZW5lcmljVHlwZURlZmluaXRpb24gPT0gdHlwZW9mKEFjdGlvbldpdGhQYXJhbVJlc3VsdDwsPikpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYWN0aW9uVHlwZSA9IHR5cGVvZihBY3Rpb25XaXRoUGFyYW1SZXN1bHQ8LD4pLk1ha2VHZW5lcmljVHlwZShnZW5lcmljQXJndW1lbnRzKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBwYXJhbWV0ZXJUeXBlID0gY29udmVydFNlcnZpY2UuVG9TaWduYXR1cmUoU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxUeXBlPihnZW5lcmljQXJndW1lbnRzKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuVHlwZSA9IGNvbnZlcnRTZXJ2aWNlLlRvU2lnbmF0dXJlKFN5c3RlbS5MaW5xLkVudW1lcmFibGUuTGFzdE9yRGVmYXVsdDxUeXBlPihnZW5lcmljQXJndW1lbnRzKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmIChhY3Rpb25WYWx1ZSA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBleGVjdXRpb25Db250ZXh0ID0gbmV3IEVtcHR5QWN0aW9uRXhlY3V0aW9uQ29udGV4dCgpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICBzd2l0Y2ggKChDb2RlVHlwZSlhY3Rpb25WYWx1ZS5Db2RlVHlwZSlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgY2FzZSBDb2RlVHlwZS5DbGllbnQ6XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UoYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGV4ZWN1dGlvbkNvbnRleHQgPSBuZXcgQ2xpZW50RnVuY3Rpb25FeGVjdXRpb25Db250ZXh0KGFjdGlvblZhbHVlLk1ldGhvZE5hbWUpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgY2FzZSBDb2RlVHlwZS5TZXJ2ZXI6XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UoYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciBtZXRhZGF0YVVpZCA9IHBhcmFtZXRlcnMuTWV0YWRhdGFVaWQ7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgdmFyIG1ldGFkYXRhVHlwZVVpZCA9IHBhcmFtZXRlcnMuTWV0YWRhdGFUeXBlVWlkO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChtZXRhZGF0YVVpZCA9PSBHdWlkLkVtcHR5IHx8IG1ldGFkYXRhVHlwZVVpZCA9PSBHdWlkLkVtcHR5KVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBleGVjdXRpb25Db250ZXh0ID0gbmV3IFNlcnZlckZ1bmN0aW9uRXhlY3V0aW9uQ29udGV4dChcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgbWV0YWRhdGFUeXBlVWlkLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBtZXRhZGF0YVVpZCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgbmV3IFNpZ25hdHVyZVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBOdWxsYWJsZSA9IHJldHVyblR5cGUuTnVsbGFibGUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBSZWxhdGlvblR5cGUgPSByZXR1cm5UeXBlLlJlbGF0aW9uVHlwZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFR5cGVVaWQgPSByZXR1cm5UeXBlLlR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdWJUeXBlVWlkID0gcmV0dXJuVHlwZS5TdWJUeXBlVWlkXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIH0sIFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBuZXcgU2lnbmF0dXJlXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIE51bGxhYmxlID0gcGFyYW1ldGVyVHlwZS5OdWxsYWJsZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFJlbGF0aW9uVHlwZSA9IHBhcmFtZXRlclR5cGUuUmVsYXRpb25UeXBlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgVHlwZVVpZCA9IHBhcmFtZXRlclR5cGUuVHlwZVVpZCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFN1YlR5cGVVaWQgPSBwYXJhbWV0ZXJUeXBlLlN1YlR5cGVVaWRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjYXNlIENvZGVUeXBlLlRlc3Q6XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjYXNlIENvZGVUeXBlLkdsb2JhbEZ1bmN0aW9uOlxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciBtZXRhZGF0YVVpZCA9IHBhcmFtZXRlcnMuTWV0YWRhdGFVaWQ7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKG1ldGFkYXRhVWlkID09IEd1aWQuRW1wdHkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgdmFyIGZ1bmN0aW9uSXRlbVVpZCA9IGN1cnJlbnRQYWdlU2VydmljZS5HZXRGdW5jdGlvbkl0ZW1VaWQobWV0YWRhdGFVaWQsIGFjdGlvblZhbHVlLkZ1bmN0aW9uSGVhZGVyVWlkKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBpZiAoZnVuY3Rpb25JdGVtVWlkID09IEd1aWQuRW1wdHkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmdW5jdGlvbkl0ZW1VaWQgPSBjdXJyZW50UGFnZVNlcnZpY2UuR2V0RnVuY3Rpb25JdGVtVWlkKHBhcmFtZXRlcnMuTWV0YWRhdGFNb2R1bGVVaWQsIGFjdGlvblZhbHVlLkZ1bmN0aW9uSGVhZGVyVWlkKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZXhlY3V0aW9uQ29udGV4dCA9IG5ldyBHbG9iYWxGdW5jdGlvbkV4ZWN1dGlvbkNvbnRleHQoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZ1bmN0aW9uSXRlbVVpZCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgbmV3IFNpZ25hdHVyZVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBOdWxsYWJsZSA9IHJldHVyblR5cGUuTnVsbGFibGUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBSZWxhdGlvblR5cGUgPSByZXR1cm5UeXBlLlJlbGF0aW9uVHlwZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFR5cGVVaWQgPSByZXR1cm5UeXBlLlR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdWJUeXBlVWlkID0gcmV0dXJuVHlwZS5TdWJUeXBlVWlkXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIH0sXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIG5ldyBTaWduYXR1cmVcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgTnVsbGFibGUgPSBwYXJhbWV0ZXJUeXBlLk51bGxhYmxlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgUmVsYXRpb25UeXBlID0gcGFyYW1ldGVyVHlwZS5SZWxhdGlvblR5cGUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBUeXBlVWlkID0gcGFyYW1ldGVyVHlwZS5UeXBlVWlkLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgU3ViVHlwZVVpZCA9IHBhcmFtZXRlclR5cGUuU3ViVHlwZVVpZFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGRlZmF1bHQ6XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICBcclxuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGFjdGlvblR5cGUgIT0gbnVsbCAmJiBleGVjdXRpb25Db250ZXh0ICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciBhY3Rpb24gPSAoSUFjdGlvbilBY3RpdmF0b3IuQ3JlYXRlSW5zdGFuY2UoYWN0aW9uVHlwZSwgZXhlY3V0aW9uQ29udGV4dCwgYWN0aW9uRXhlY3V0aW9uRmFjYWRlKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHZhciBwcm9wRXhwckluZm8gPSBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIE9iamVjdEV4cHJlc3Npb24gPSBwcm9wZXJ0eU5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgRXhwcmVzc2lvbkZvclNlcmlhbGl6ZSA9IHByb3BlcnR5TmFtZVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIENsb3N1cmVIZWxwZXIuQ2xvc3VyZTxvYmplY3QsIFByb3BlcnR5SW5mb0V4cHJlc3Npb24sIG9iamVjdD4odGFyZ2V0LCAoQWN0aW9uPG9iamVjdCxQcm9wZXJ0eUluZm9FeHByZXNzaW9uLG9iamVjdD4pQ29udmVydEhlbHBlci5SZWRlZmluZVByb3AsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgdGFyZ2V0LCBwcm9wRXhwckluZm8sIGFjdGlvbik7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIENsb3N1cmVIZWxwZXIuQ2xvc3VyZTxDb21wdXRlZFZhbHVlLCBvYmplY3QsIHN0cmluZz4oXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHRoaXMsXHJcbihBY3Rpb248Q29tcHV0ZWRWYWx1ZSxvYmplY3Qsc3RyaW5nPikgICAgICAgICAgICAgICAgICAgICAgICBHZXRQcm9wZXJ0eVZhbHVlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBkeW5hbWljUHJvcGVydHksXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHRhcmdldCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgcHJvcGVydHlOYW1lKTtcclxuXHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGludGVyZmFjZXMgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLldoZXJlPFR5cGU+KHRhcmdldC5HZXRUeXBlKCkuR2V0SW50ZXJmYWNlcygpLChGdW5jPFR5cGUsYm9vbD4pKHEgPT4gQXR0cmlidXRlSGVscGVyPER5bmFtaWNQcm9wZXJ0eUNvbnRhaW5lckF0dHJpYnV0ZT4uR2V0QXR0cmlidXRlKHEsIHRydWUpICE9IG51bGwpKS5Ub0xpc3QoKTtcclxuICAgICAgICAgICAgICAgICAgICBpZiAoaW50ZXJmYWNlcy5Db3VudCA8PSAwKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICBmb3JlYWNoICh2YXIgaSBpbiBpbnRlcmZhY2VzKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5ID0gaS5HZXRQcm9wZXJ0eShwcm9wZXJ0eU5hbWUpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAocHJvcGVydHkgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPENvbXB1dGVkVmFsdWUsIG9iamVjdCwgc3RyaW5nPihcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRoaXMsXHJcbihBY3Rpb248Q29tcHV0ZWRWYWx1ZSxvYmplY3Qsc3RyaW5nPikgICAgICAgICAgICAgICAgICAgICAgICAgICAgR2V0UHJvcGVydHlWYWx1ZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGR5bmFtaWNQcm9wZXJ0eSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRhcmdldCxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHByb3BlcnR5LlNjcmlwdEZpZWxkTmFtZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBpZiAobmVlZFNpbXBsZVRlc3RWYWx1ZSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgQ2xvc3VyZUhlbHBlci5DbG9zdXJlPElWaWV3SXRlbSwgc3RyaW5nLCBJQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycz4oXHJcbiAgICAgICAgICAgICAgICAgICAgdGhpcyxcclxuKEFjdGlvbjxJVmlld0l0ZW0sc3RyaW5nLElDb250ZXh0Q3JlYXRpb25QYXJhbWV0ZXJzPikgICAgICAgICAgICAgICAgICAgIEdldFRlc3RJZFZhbHVlLFxyXG4gICAgICAgICAgICAgICAgICAgIHZpZXdJdGVtLFxyXG4gICAgICAgICAgICAgICAgICAgIFRlc3RQcm9wZXJ0eU5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgcGFyYW1ldGVyc1xyXG4gICAgICAgICAgICAgICAgKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmlld0l0ZW1bXCJvdmVyXCJdID0gdHJ1ZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBHZXRQcm9wZXJ0eVZhbHVlKENvbXB1dGVkVmFsdWUgaW5wLCBvYmplY3QgY29udGV4dCwgc3RyaW5nIHByb3BlcnR5TmFtZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEZ1bmM8b2JqZWN0PiB2YWx1ZUYgPSBudWxsO1xyXG4gICAgICAgICAgICBzd2l0Y2ggKChDb21wdXRlZFZhbHVlVHlwZSlpbnAuQ29tcHV0ZWRWYWx1ZVR5cGUpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNhc2UgQ29tcHV0ZWRWYWx1ZVR5cGUuUHJvcGVydHk6XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFsdWVGID0gKCkgPT5cclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBzY29wZSA9IEdsb2JhbFNjb3BlSGVscGVyLkdldFNjb3BlKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmIChzY29wZSA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB0aHJvdyBuZXcgRXhjZXB0aW9uKFNSLlQoXCLQndC1INC90LDQudC00LXQvSDRgdC60L7Rg9C/INC00LvRjyDRgdCy0L7QudGB0YLQstCwIHswfSwg0LLRi9GH0LjRgdC70Y/QtdC80L7Qs9C+INGBINC/0L7QvNC+0YnRjNGOINC80LXRgtC+0LTQsCB7MX1cIiwgcHJvcGVydHlOYW1lLCBpbnAuTWV0aG9kTmFtZSkpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbklNZXRhZGF0YVZpZXdNb2RlbCBtZXRhZGF0YVZpZXdNb2RlbDtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKCEoKG1ldGFkYXRhVmlld01vZGVsID0gc2NvcGUgYXMgSU1ldGFkYXRhVmlld01vZGVsKSAhPSBudWxsKSlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBtZXRhZGF0YVZpZXdNb2RlbC5HZXRQcm9wZXJ0eUNvbnRleHQ8b2JqZWN0PihtZXRhZGF0YVNlcnZpY2VDb250ZXh0LCBpbnAuUHJvcGVydHlVaWQsIFN5c3RlbS5MaW5xLkVudW1lcmFibGUuVG9BcnJheTxHdWlkPihpbnAuUHJvcGVydHlQYXJlbnRzKSkoKTtcclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgY2FzZSBDb21wdXRlZFZhbHVlVHlwZS5GdW5jdGlvbjpcclxuICAgICAgICAgICAgICAgIGNhc2UgQ29tcHV0ZWRWYWx1ZVR5cGUuQ2FsY3VsYXRlU2NyaXB0OlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhbHVlRiA9ICgpID0+XHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB2YXIgc2NvcGUgPSBHbG9iYWxTY29wZUhlbHBlci5HZXRTY29wZSgpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAoc2NvcGUgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgdGhyb3cgbmV3IEV4Y2VwdGlvbihTUi5UKFwi0J3QtSDQvdCw0LnQtNC10L0g0YHQutC+0YPQvyDQtNC70Y8g0YHQstC+0LnRgdGC0LLQsCB7MH0sINCy0YvRh9C40YHQu9GP0LXQvNC+0LPQviDRgSDQv9C+0LzQvtGJ0YzRjiDQvNC10YLQvtC00LAgezF9XCIsIHByb3BlcnR5TmFtZSwgaW5wLk1ldGhvZE5hbWUpKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIG1ldGhvZE5hbWUgPSBpbnAuTWV0aG9kTmFtZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIHN0YWNrID0gc2NvcGUuR2V0UGxhaW5Qcm9wZXJ0eVZhbHVlPElEYXRhU3RhY2s+KFwiU3RhY2tcIik7XHJcbklGb3JtVmlld01vZGVsIGZvcm1WaWV3TW9kZWw7ICAgICAgICAgICAgICAgICAgICAgICAgaWYgKChmb3JtVmlld01vZGVsID0gc2NvcGUgYXMgSUZvcm1WaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2QoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9ybVZpZXdNb2RlbC5Db250cm9sbGVycyxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBtZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHN0YWNrKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIFZpZXdNb2RlbEhlbHBlci5DYWxsQ29udHJvbGxlck1ldGhvZChcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHNjb3BlLkNvbnRyb2xsZXIsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBtZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgc3RhY2spO1xyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIE9iamVjdC5kZWZpbmVQcm9wZXJ0eShjb250ZXh0LCBwcm9wZXJ0eU5hbWUsIHtcclxuICAgICAgICAgICAgICAgIGNvbmZpZ3VyYWJsZTogdHJ1ZSxcclxuICAgICAgICAgICAgICAgIGdldDogZnVuY3Rpb24oKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHZhbHVlRigpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9KTtcclxuICAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgR2V0VGVzdElkVmFsdWUoSVZpZXdJdGVtIHZpZXdJdGVtLCBzdHJpbmcgcHJvcGVydHlOYW1lLCBJQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycyBwYXJhbWV0ZXJzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIG1vZHVsZU5hbWUgPSBtb2R1bGVNZXRhZGF0YUl0ZW1NYW5hZ2VyLkdldEhlYWRlck5hbWUocGFyYW1ldGVycy5NZXRhZGF0YU1vZHVsZVVpZCk7XHJcbk5hbWVkTWV0YWRhdGEgbmFtZWRNZXRhZGF0YTsgICAgICAgICAgICB2YXIgY29tcG9uZW50TmFtZSA9IChuYW1lZE1ldGFkYXRhID0gKChJTWV0YWRhdGFWaWV3TW9kZWwpcGFyYW1ldGVycy5WaWV3TW9kZWwpLlVJVmlld01vZGVsLk1ldGFkYXRhIGFzIE5hbWVkTWV0YWRhdGEpICE9IG51bGw/IG5hbWVkTWV0YWRhdGEuTmFtZSA6IHN0cmluZy5FbXB0eTtcclxuICAgICAgICAgICAgdmFyIHZpZXdJdGVtTmFtZSA9IHZpZXdJdGVtLk5hbWU7XHJcblxyXG4gICAgICAgICAgICB2YXIgdGVzdElkID0gc3RyaW5nLkZvcm1hdChcInswfS17MX0tezJ9XCIsbW9kdWxlTmFtZSxjb21wb25lbnROYW1lLHZpZXdJdGVtTmFtZSk7XHJcbiAgICAgICAgICAgIEZ1bmM8b2JqZWN0PiB2YWx1ZUYgPSAoKSA9PiB0ZXN0SWQ7XHJcbiAgICAgICAgICAgIC8qQFxyXG4gICAgICAgICAgICBPYmplY3QuZGVmaW5lUHJvcGVydHkodmlld0l0ZW0sIHByb3BlcnR5TmFtZSwge1xyXG4gICAgICAgICAgICAgICAgY29uZmlndXJhYmxlOiB0cnVlLFxyXG4gICAgICAgICAgICAgICAgZ2V0OiBmdW5jdGlvbigpIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gdmFsdWVGKCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICAgKi9cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgc3RhdGljIGJvb2wgSW5wdXRJc051bGxPckVtcHR5KENvbXB1dGVkVmFsdWUgY29tcHV0ZWRWYWx1ZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChjb21wdXRlZFZhbHVlID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiB0cnVlO1xyXG4gICAgICAgICAgICB9XHJcbmRvXHJcbntcclxuICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJjYXNlX3BhdHRlcm4wXCIsIChDb21wdXRlZFZhbHVlVHlwZSljb21wdXRlZFZhbHVlLkNvbXB1dGVkVmFsdWVUeXBlKTtcclxuICAgIGlmIChnbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8Q29tcHV0ZWRWYWx1ZVR5cGU+KFwiY2FzZV9wYXR0ZXJuMFwiKSA9PSBDb21wdXRlZFZhbHVlVHlwZS5JbnB1dClcclxuICAgIHtcclxuICAgICAgICBpZiAoY29tcHV0ZWRWYWx1ZS5WYWx1ZSA9PSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgaWYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxDb21wdXRlZFZhbHVlVHlwZT4oXCJjYXNlX3BhdHRlcm4wXCIpID09IENvbXB1dGVkVmFsdWVUeXBlLkZ1bmN0aW9uKVxyXG4gICAge1xyXG4gICAgICAgIGlmIChzdHJpbmcuSXNOdWxsT3JFbXB0eShjb21wdXRlZFZhbHVlLk1ldGhvZE5hbWUpKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgaWYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxDb21wdXRlZFZhbHVlVHlwZT4oXCJjYXNlX3BhdHRlcm4wXCIpID09IENvbXB1dGVkVmFsdWVUeXBlLkNhbGN1bGF0ZVNjcmlwdClcclxuICAgIHtcclxuICAgICAgICBpZiAoc3RyaW5nLklzTnVsbE9yRW1wdHkoY29tcHV0ZWRWYWx1ZS5DYWxjdWxhdGVTY3JpcHQpKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAge1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbndoaWxlIChmYWxzZSk7XHJcbiAgICAgICAgICAgIHJldHVybiBmYWxzZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgb2JqZWN0IEdldEFjdGlvbkZvcklucHV0KFByb3BlcnR5TWV0YWRhdGEgcHJvcGVydHksIENvbXB1dGVkVmFsdWUgY29tcHV0ZWRWYWx1ZSwgSUNvbnRleHRDcmVhdGlvblBhcmFtZXRlcnMgcGFyYW1ldGVycylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBvd25lciA9IHBhcmFtZXRlcnMuVmlld01vZGVsLlJlbmRlck93bmVyO1xyXG4gICAgICAgICAgICBpZiAob3duZXIgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgIH1cclxuQWN0aW9uU2V0dGluZ3Mgc2V0dGluZ3M7ZG9cclxue1xyXG4gICAgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImNhc2VfcGF0dGVybjFcIiwgKENvbXB1dGVkVmFsdWVUeXBlKWNvbXB1dGVkVmFsdWUuQ29tcHV0ZWRWYWx1ZVR5cGUpO1xyXG4gICAgaWYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxDb21wdXRlZFZhbHVlVHlwZT4oXCJjYXNlX3BhdHRlcm4xXCIpID09IENvbXB1dGVkVmFsdWVUeXBlLklucHV0KVxyXG4gICAge1xyXG4gICAgICAgIGlmICgoc2V0dGluZ3MgPSBwcm9wZXJ0eS5TZXR0aW5ncyBhcyBBY3Rpb25TZXR0aW5ncykgIT0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtZXRhZGF0YVZpZXdNb2RlbCA9IG93bmVyIGFzIElNZXRhZGF0YVZpZXdNb2RlbDtcclxuICAgICAgICAgICAgICAgIHZhciBhY3Rpb25WYWx1ZSA9IEFjdGlvbkNvbXB1dGVkVmFsdWVIZWxwZXIuQ3JlYXRlQWN0aW9uVmFsdWUoY29tcHV0ZWRWYWx1ZSwgbnVsbCk7XHJcbiAgICAgICAgICAgICAgICB2YXIgZ2V0Q29udHJvbGxlckZ1bmMgPSBuZXcgRnVuYzxJQ29udHJvbGxlcj4oKCkgPT4gcGFyYW1ldGVycy5WaWV3TW9kZWwuUmVuZGVyT3duZXIuQ29udHJvbGxlcik7XHJcbiAgICAgICAgICAgICAgICBJRm9ybVZpZXdNb2RlbCBmb3JtVmlld01vZGVsO1xyXG4gICAgICAgICAgICAgICAgaWYgKChmb3JtVmlld01vZGVsID0gcGFyYW1ldGVycy5WaWV3TW9kZWwuUmVuZGVyT3duZXIgYXMgSUZvcm1WaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIG1ldGhvZE5hbWUgPSBTY3JpcHRNZXRob2RJbmZvSGVscGVyLkRlc2VyaWFsaXplKGFjdGlvblZhbHVlLk1ldGhvZE5hbWUpLk5hbWU7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKCFzdHJpbmcuSXNOdWxsT3JXaGl0ZVNwYWNlKG1ldGhvZE5hbWUpKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgZ2V0Q29udHJvbGxlckZ1bmMgPSBuZXcgRnVuYzxJQ29udHJvbGxlcj4oKCkgPT4gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYy5LZXlWYWx1ZVBhaXI8R3VpZCwgSUNvbnRyb2xsZXI+Pihmb3JtVmlld01vZGVsLkNvbnRyb2xsZXJzLCAoRnVuYzxTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYy5LZXlWYWx1ZVBhaXI8R3VpZCwgSUNvbnRyb2xsZXI+LCBib29sPikoYyA9PiBjLlZhbHVlW21ldGhvZE5hbWVdICE9IG51bGwpKS5WYWx1ZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBleGVjdXRpb25Db250ZXh0ID0gR2V0QWN0aW9uRXhlY3V0aW9uQ29udGV4dChwcm9wZXJ0eSwgYWN0aW9uVmFsdWUsIHNldHRpbmdzLCAobWV0YWRhdGFWaWV3TW9kZWwgIT0gbnVsbCA/IG1ldGFkYXRhVmlld01vZGVsLlVJVmlld01vZGVsLlVpZCA6IChHdWlkPyApbnVsbCkgPz8gR3VpZC5FbXB0eSwgKG1ldGFkYXRhVmlld01vZGVsICE9IG51bGwgPyBtZXRhZGF0YVZpZXdNb2RlbC5VSVZpZXdNb2RlbC5UeXBlVWlkIDogKEd1aWQ/ICludWxsKSA/PyBHdWlkLkVtcHR5LCAobWV0YWRhdGFWaWV3TW9kZWwgIT0gbnVsbCA/IG1ldGFkYXRhVmlld01vZGVsLlVJVmlld01vZGVsLk1ldGFkYXRhLk1vZHVsZVVpZCA6IChHdWlkPyApbnVsbCkgPz8gR3VpZC5FbXB0eSwgcGFyYW1ldGVycy5PdXRlclN0YWNrLCAoRnVuYzxJQ29udHJvbGxlcj4pZ2V0Q29udHJvbGxlckZ1bmMpO1xyXG4gICAgICAgICAgICAgICAgdmFyIHJldHVyblR5cGUgPSBEeW5hbWljUHJvcGVydHlIZWxwZXIuVHlwZVNpZ25hdHVyZU1hcFRvT2JqZWN0KHNldHRpbmdzLlJldHVyblR5cGUpO1xyXG4gICAgICAgICAgICAgICAgdmFyIHBhcmFtZXRlclR5cGUgPSBEeW5hbWljUHJvcGVydHlIZWxwZXIuVHlwZVNpZ25hdHVyZU1hcFRvT2JqZWN0KHNldHRpbmdzLlBhcmFtZXRlclR5cGUpO1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIENyZWF0ZUNsb3N1cmVGb3JBY3Rpb24ocmV0dXJuVHlwZSwgcGFyYW1ldGVyVHlwZSwgZXhlY3V0aW9uQ29udGV4dCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgaWYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxDb21wdXRlZFZhbHVlVHlwZT4oXCJjYXNlX3BhdHRlcm4xXCIpID09IENvbXB1dGVkVmFsdWVUeXBlLlByb3BlcnR5KVxyXG4gICAge1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuICgoSU1ldGFkYXRhVmlld01vZGVsKW93bmVyKS5HZXRQcm9wZXJ0eUNvbnRleHQ8b2JqZWN0PihtZXRhZGF0YVNlcnZpY2VDb250ZXh0LCBjb21wdXRlZFZhbHVlLlByb3BlcnR5VWlkLCBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlRvQXJyYXk8R3VpZD4oY29tcHV0ZWRWYWx1ZS5Qcm9wZXJ0eVBhcmVudHMpKSgpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBpZiAoZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPENvbXB1dGVkVmFsdWVUeXBlPihcImNhc2VfcGF0dGVybjFcIikgPT0gQ29tcHV0ZWRWYWx1ZVR5cGUuRnVuY3Rpb24pXHJcbiAgICB7XHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBicmVhaztcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgaWYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxDb21wdXRlZFZhbHVlVHlwZT4oXCJjYXNlX3BhdHRlcm4xXCIpID09IENvbXB1dGVkVmFsdWVUeXBlLkNhbGN1bGF0ZVNjcmlwdClcclxuICAgIHtcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2Qob3duZXIuQ29udHJvbGxlciwgY29tcHV0ZWRWYWx1ZS5NZXRob2ROYW1lLCBudWxsKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAge1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbndoaWxlIChmYWxzZSk7XHJcbiAgICAgICAgICAgIHJldHVybiBudWxsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSB2b2lkIFdyaXRlQ29tcHV0ZWRHZXR0ZXIoSVZpZXdNb2RlbCB2aWV3TW9kZWwsIENvbXB1dGVkVmFsdWUgaW5wLCBvYmplY3QgY29udGV4dCwgUHJvcGVydHlJbmZvRXhwcmVzc2lvbiBleHByZXNzaW9uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHZhbHVlRiA9IEdldFZhbHVlRnVuYyhpbnAsIHZpZXdNb2RlbCk7XHJcblxyXG4gICAgICAgICAgICBDb252ZXJ0SGVscGVyLlJlZGVmaW5lUHJvcChjb250ZXh0LCBleHByZXNzaW9uLCAoRnVuYzxvYmplY3Q+KXZhbHVlRik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgV3JpdGVHZXR0ZXIoQ29tcHV0ZWRWYWx1ZSBpbnAsIG9iamVjdCBjb250ZXh0LCBzdHJpbmcgcHJvcGVydHlOYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHZhbHVlRiA9IEdldFZhbHVlRnVuYyhpbnApO1xyXG5cclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIE9iamVjdC5kZWZpbmVQcm9wZXJ0eShjb250ZXh0LCBwcm9wZXJ0eU5hbWUsIHtcclxuICAgICAgICAgICAgICAgIGdldDogZnVuY3Rpb24oKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHZhbHVlRigpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9KTtcclxuICAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgV3JpdGVHZXR0ZXJDb25maWd1cmFibGUoQ29tcHV0ZWRWYWx1ZSBpbnAsIG9iamVjdCBjb250ZXh0LCBzdHJpbmcgcHJvcGVydHlOYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHZhbHVlRiA9IEdldFZhbHVlRnVuYyhpbnApO1xyXG5cclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIE9iamVjdC5kZWZpbmVQcm9wZXJ0eShjb250ZXh0LCBwcm9wZXJ0eU5hbWUsIHtcclxuICAgICAgICAgICAgICAgIGNvbmZpZ3VyYWJsZTogdHJ1ZSxcclxuICAgICAgICAgICAgICAgIGdldDogZnVuY3Rpb24oKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHZhbHVlRigpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9KTtcclxuICAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIEZ1bmM8b2JqZWN0PiBHZXRWYWx1ZUZ1bmMoQ29tcHV0ZWRWYWx1ZSBpbnAsIElWaWV3TW9kZWwgdmlld01vZGVsID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEZ1bmM8b2JqZWN0PiB2YWx1ZUYgPSBudWxsO1xyXG4gICAgICAgICAgICB2YXIgc2NvcGUgPSB2aWV3TW9kZWw7XHJcbiAgICAgICAgICAgIHN3aXRjaCAoKENvbXB1dGVkVmFsdWVUeXBlKWlucC5Db21wdXRlZFZhbHVlVHlwZSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY2FzZSBDb21wdXRlZFZhbHVlVHlwZS5Qcm9wZXJ0eTpcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YWx1ZUYgPSAoKSA9PlxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHNjb3BlID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHNjb3BlID0gR2xvYmFsU2NvcGVIZWxwZXIuR2V0U2NvcGUoKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChzY29wZSA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24oU1IuVChcItCd0LUg0L3QsNC50LTQtdC9INGB0LrQvtGD0L8g0LTQu9GPINC80LXRgtC+0LTQsCB7MH1cIiwgaW5wLk1ldGhvZE5hbWUpKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5JTWV0YWRhdGFWaWV3TW9kZWwgbWV0YWRhdGFWaWV3TW9kZWw7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmICghKChtZXRhZGF0YVZpZXdNb2RlbCA9IHNjb3BlIGFzIElNZXRhZGF0YVZpZXdNb2RlbCkgIT0gbnVsbCkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBudWxsO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICByZXR1cm4gbWV0YWRhdGFWaWV3TW9kZWwuR2V0UHJvcGVydHlDb250ZXh0PG9iamVjdD4obWV0YWRhdGFTZXJ2aWNlQ29udGV4dCwgaW5wLlByb3BlcnR5VWlkLCBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlRvQXJyYXk8R3VpZD4oaW5wLlByb3BlcnR5UGFyZW50cykpKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIGNhc2UgQ29tcHV0ZWRWYWx1ZVR5cGUuRnVuY3Rpb246XHJcbiAgICAgICAgICAgICAgICBjYXNlIENvbXB1dGVkVmFsdWVUeXBlLkNhbGN1bGF0ZVNjcmlwdDpcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YWx1ZUYgPSAoKSA9PlxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHNjb3BlID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHNjb3BlID0gR2xvYmFsU2NvcGVIZWxwZXIuR2V0U2NvcGUoKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChzY29wZSA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24oU1IuVChcItCd0LUg0L3QsNC50LTQtdC9INGB0LrQvtGD0L8g0LTQu9GPINC80LXRgtC+0LTQsCB7MH1cIiwgaW5wLk1ldGhvZE5hbWUpKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIG1ldGhvZE5hbWUgPSBpbnAuTWV0aG9kTmFtZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIHN0YWNrID0gc2NvcGUuR2V0UGxhaW5Qcm9wZXJ0eVZhbHVlPElEYXRhU3RhY2s+KFwiU3RhY2tcIik7XHJcbklGb3JtVmlld01vZGVsIGZvcm1WaWV3TW9kZWw7ICAgICAgICAgICAgICAgICAgICAgICAgaWYgKChmb3JtVmlld01vZGVsID0gc2NvcGUgYXMgSUZvcm1WaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2QoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9ybVZpZXdNb2RlbC5Db250cm9sbGVycyxcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBtZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHN0YWNrKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIFZpZXdNb2RlbEhlbHBlci5DYWxsQ29udHJvbGxlck1ldGhvZChcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHNjb3BlLkNvbnRyb2xsZXIsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBtZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgc3RhY2spO1xyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgcmV0dXJuIHZhbHVlRjtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBEZWZpbmVJbnB1dHMoSVZpZXdNb2RlbCByZW5kZXJPd25lciwgSUNvbnRleHQgY29udGV4dCwgR3VpZCB0eXBlVWlkLCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uIGV4cHJlc3Npb24sIENvbXB1dGVkVmFsdWUgaW5wLCBJRGF0YVN0YWNrIHN0YWNrKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQ29udmVydEhlbHBlci5EZWZpbmVJbnB1dChjb250ZXh0LCBleHByZXNzaW9uKTtcclxuXHJcbiAgICAgICAgICAgIEZ1bmM8b2JqZWN0PiB2YWx1ZTtcclxuICAgICAgICAgICAgc3dpdGNoICgoQ29tcHV0ZWRWYWx1ZVR5cGUpaW5wLkNvbXB1dGVkVmFsdWVUeXBlKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBjYXNlIENvbXB1dGVkVmFsdWVUeXBlLklucHV0OlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhbHVlID0gKCkgPT5cclxue1xyXG4gICAgSW5wdXRDb21wdXRlZFZhbHVlIGlucHV0Q29tcHV0ZWRWYWx1ZTtcclxuICAgIHJldHVybiBDb21wdXRlZFZhbHVlSGVscGVyLkdldFZhbHVlKGRlc2NyaXB0b3JTZXJ2aWNlLCB0eXBlVWlkLCBpbnAuVmFsdWUsIGNvbnZlcnRDb250ZXh0LCAoaW5wdXRDb21wdXRlZFZhbHVlID0gaW5wIGFzIElucHV0Q29tcHV0ZWRWYWx1ZSkgIT0gbnVsbD8gaW5wdXRDb21wdXRlZFZhbHVlLk51bGxhYmxlIDogKGJvb2w/ICludWxsKTtcclxufTtcclxuICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIGNhc2UgQ29tcHV0ZWRWYWx1ZVR5cGUuUHJvcGVydHk6XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFsdWUgPSAoKElNZXRhZGF0YVZpZXdNb2RlbClyZW5kZXJPd25lcikuR2V0UHJvcGVydHlDb250ZXh0PG9iamVjdD4obWV0YWRhdGFTZXJ2aWNlQ29udGV4dCwgaW5wLlByb3BlcnR5VWlkLCBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlRvQXJyYXk8R3VpZD4oaW5wLlByb3BlcnR5UGFyZW50cykpO1xyXG4gICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgY2FzZSBDb21wdXRlZFZhbHVlVHlwZS5GdW5jdGlvbjpcclxuICAgICAgICAgICAgICAgIGNhc2UgQ29tcHV0ZWRWYWx1ZVR5cGUuQ2FsY3VsYXRlU2NyaXB0OlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhbHVlID0gKCkgPT4gRXhlY3V0ZU1ldGhvZChyZW5kZXJPd25lciwgaW5wLk1ldGhvZE5hbWUsIHN0YWNrKTtcclxuICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIGRlZmF1bHQ6XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdGhyb3cgbmV3IEFyZ3VtZW50T3V0T2ZSYW5nZUV4Y2VwdGlvbigpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBDb252ZXJ0SGVscGVyLlJlZGVmaW5lUHJvcChjb250ZXh0LCBleHByZXNzaW9uLCAoRnVuYzxvYmplY3Q+KXZhbHVlKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBEZWZpbmVTZXR0ZXJDYWxsYmFjayhJVmlld01vZGVsIHJlbmRlck93bmVyLCBJQ29udGV4dCBjb250ZXh0LCBHdWlkIHR5cGVVaWQsIFByb3BlcnR5SW5mb0V4cHJlc3Npb24gZXhwcmVzc2lvbiwgQ29tcHV0ZWRWYWx1ZSBpbnAsIElEYXRhU3RhY2sgc3RhY2spXHJcbiAgICAgICAge1xyXG5BY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUgYWN0aW9uSW5wdXRDb21wdXRlZFZhbHVlOyAgICAgICAgICAgIGlmICgoYWN0aW9uSW5wdXRDb21wdXRlZFZhbHVlID0gaW5wIGFzIEFjdGlvbklucHV0Q29tcHV0ZWRWYWx1ZSkgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgSUFjdGlvbkV4ZWN1dGlvbkNvbnRleHQgZXhlY3V0ZUNvbnRleHQgPSBuZXcgRW1wdHlBY3Rpb25FeGVjdXRpb25Db250ZXh0KCk7XHJcbiAgICAgICAgICAgICAgICBpZiAoIXN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UoYWN0aW9uSW5wdXRDb21wdXRlZFZhbHVlLk1ldGhvZE5hbWUpKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGV4ZWN1dGVDb250ZXh0ID0gbmV3IENsaWVudEZ1bmN0aW9uRXhlY3V0aW9uQ29udGV4dChhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUuTWV0aG9kTmFtZSwgbnVsbCwgbnVsbCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICB7XHJcbmJvb2wgaXNBY3Rpb247XG5BY3Rpb25WYWx1ZSBhY3Rpb25WYWx1ZTtcbkJyaWRnZS5TY3JpcHQuRGVjb25zdHJ1Y3QoQWN0aW9uQ29tcHV0ZWRWYWx1ZUhlbHBlci5Jc0FjdGlvbihhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUpLCBvdXQgaXNBY3Rpb24sIG91dCBhY3Rpb25WYWx1ZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKGlzQWN0aW9uKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgZXhlY3V0ZUNvbnRleHQgPSBuZXcgQ2xpZW50RnVuY3Rpb25FeGVjdXRpb25Db250ZXh0KGFjdGlvblZhbHVlLk1ldGhvZE5hbWUsIG51bGwsIG51bGwpO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICB2YXIgYWN0aW9uID0gQ3JlYXRlQ2xvc3VyZUZvckFjdGlvbihhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUsIGV4ZWN1dGVDb250ZXh0KTtcclxuICAgICAgICAgICAgICAgIGlmIChhY3Rpb24gPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgQ29udmVydEhlbHBlci5EZWZpbmVQcm9wU2V0dGVyQ2FsbGJhY2soY29udGV4dCwgZXhwcmVzc2lvbiwgYWN0aW9uKTtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKChDb21wdXRlZFZhbHVlVHlwZSlpbnAuQ29tcHV0ZWRWYWx1ZVR5cGUgPT0gQ29tcHV0ZWRWYWx1ZVR5cGUuRnVuY3Rpb24gJiYgaW5wIGlzIElucHV0Q29tcHV0ZWRWYWx1ZSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgRnVuYzxvYmplY3Q+IGFjdGlvbiA9ICgpID0+IEV4ZWN1dGVNZXRob2QocmVuZGVyT3duZXIsIGlucC5NZXRob2ROYW1lLCBzdGFjayk7XHJcbiAgICAgICAgICAgICAgICBDb252ZXJ0SGVscGVyLkRlZmluZVByb3BTZXR0ZXJDYWxsYmFjayhjb250ZXh0LCBleHByZXNzaW9uLCBhY3Rpb24pO1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgRGVmaW5lU2V0dGVyUHJvcGVydHkoSVZpZXdNb2RlbCByZW5kZXJPd25lciwgSUNvbnRleHQgY29udGV4dCwgR3VpZCB0eXBlVWlkLCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uIGV4cHJlc3Npb24sIENvbXB1dGVkVmFsdWUgaW5wLCBJRGF0YVN0YWNrIHN0YWNrKVxyXG4gICAgICAgIHtcclxuSU1ldGFkYXRhVmlld01vZGVsIG1ldGFkYXRhVmlld01vZGVsOyAgICAgICAgICAgIGlmICghKChtZXRhZGF0YVZpZXdNb2RlbCA9IHJlbmRlck93bmVyIGFzIElNZXRhZGF0YVZpZXdNb2RlbCkgIT0gbnVsbCkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5vYmplY3Qgb3duZXJDb250ZXh0O1xuUHJvcGVydHlJbmZvRXhwcmVzc2lvbiBzZXR0ZXJQcm9wZXJ0eUV4cHJlc3Npb247XG5CcmlkZ2UuU2NyaXB0LkRlY29uc3RydWN0KG1ldGFkYXRhVmlld01vZGVsLkdldFByb3BlcnR5Q29udGV4dChtZXRhZGF0YVNlcnZpY2VDb250ZXh0LCBpbnAuUHJvcGVydHlVaWQsIFN5c3RlbS5MaW5xLkVudW1lcmFibGUuVG9BcnJheTxHdWlkPihpbnAuUHJvcGVydHlQYXJlbnRzKSksIG91dCBvd25lckNvbnRleHQsIG91dCBzZXR0ZXJQcm9wZXJ0eUV4cHJlc3Npb24pOyBcclxuICAgICAgICAgICAgQ29udmVydEhlbHBlci5EZWZpbmVQcm9wU2V0dGVycyhjb250ZXh0LCBleHByZXNzaW9uLCBvd25lckNvbnRleHQsIHNldHRlclByb3BlcnR5RXhwcmVzc2lvbik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIG9iamVjdCBDcmVhdGVDbG9zdXJlRm9yQWN0aW9uKEFjdGlvbklucHV0Q29tcHV0ZWRWYWx1ZSBhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUsIElBY3Rpb25FeGVjdXRpb25Db250ZXh0IGFjdGlvbkV4ZWN1dGlvbkNvbnRleHQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBJQWN0aW9uIGFjdGlvbjtcclxuICAgICAgICAgICAgVHlwZSBhY3Rpb25UeXBlO1xyXG4gICAgICAgICAgICB2YXIgcmV0dXJuVHlwZSA9IGNvbnZlcnRTZXJ2aWNlLlRvVHlwZShhY3Rpb25JbnB1dENvbXB1dGVkVmFsdWUuUmV0dXJuVHlwZSk7XHJcbiAgICAgICAgICAgIHZhciBwYXJhbWV0ZXJUeXBlID0gY29udmVydFNlcnZpY2UuVG9UeXBlKGFjdGlvbklucHV0Q29tcHV0ZWRWYWx1ZS5QYXJhbWV0ZXJUeXBlKTtcclxuICAgICAgICAgICAgaWYgKHBhcmFtZXRlclR5cGUgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgYWN0aW9uVHlwZSA9IHJldHVyblR5cGUgPT0gbnVsbFxyXG4gICAgICAgICAgICAgICAgICAgID8gdHlwZW9mKERlZmF1bHRBY3Rpb24pXHJcbiAgICAgICAgICAgICAgICAgICAgOiB0eXBlb2YoQWN0aW9uV2l0aFJlc3VsdDw+KS5NYWtlR2VuZXJpY1R5cGUobmV3W10geyByZXR1cm5UeXBlIH0pO1xyXG4gICAgICAgICAgICAgICAgYWN0aW9uID0gKElBY3Rpb24pQWN0aXZhdG9yLkNyZWF0ZUluc3RhbmNlKGFjdGlvblR5cGUsIGFjdGlvbkV4ZWN1dGlvbkNvbnRleHQsIGFjdGlvbkV4ZWN1dGlvbkZhY2FkZSk7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gQ2xvc3VyZUhlbHBlci5DcmVhdGVGb3JBY3Rpb25XaXRoUGFyYW0oYWN0aW9uKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgYWN0aW9uVHlwZSA9IHJldHVyblR5cGUgPT0gbnVsbFxyXG4gICAgICAgICAgICAgICAgPyB0eXBlb2YoQWN0aW9uV2l0aFBhcmFtPD4pLk1ha2VHZW5lcmljVHlwZShuZXdbXSB7IHBhcmFtZXRlclR5cGUgfSlcclxuICAgICAgICAgICAgICAgIDogdHlwZW9mKEFjdGlvbldpdGhQYXJhbVJlc3VsdDwsPikuTWFrZUdlbmVyaWNUeXBlKG5ld1tdIHsgcGFyYW1ldGVyVHlwZSwgcmV0dXJuVHlwZSB9KTtcclxuICAgICAgICAgICAgYWN0aW9uID0gKElBY3Rpb24pQWN0aXZhdG9yLkNyZWF0ZUluc3RhbmNlKGFjdGlvblR5cGUsIGFjdGlvbkV4ZWN1dGlvbkNvbnRleHQsIGFjdGlvbkV4ZWN1dGlvbkZhY2FkZSk7XHJcbiAgICAgICAgICAgIHJldHVybiBDbG9zdXJlSGVscGVyLkNyZWF0ZUZvckFjdGlvbldpdGhQYXJhbShhY3Rpb24pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBzdGF0aWMgb2JqZWN0IEV4ZWN1dGVNZXRob2QoSVZpZXdNb2RlbCByZW5kZXJPd25lciwgc3RyaW5nIG1ldGhvZE5hbWUsIElEYXRhU3RhY2sgc3RhY2spXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5QdXNoKHJlbmRlck93bmVyKTtcclxuXHJcbiAgICAgICAgICAgIHRyeVxyXG4gICAgICAgICAgICB7XHJcbklGb3JtVmlld01vZGVsIGZvcm1WaWV3TW9kZWw7ICAgICAgICAgICAgICAgIGlmICgoZm9ybVZpZXdNb2RlbCA9IHJlbmRlck93bmVyIGFzIElGb3JtVmlld01vZGVsKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2QoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGZvcm1WaWV3TW9kZWwuQ29udHJvbGxlcnMsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIG1ldGhvZE5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHN0YWNrKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIGVsc2VcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gVmlld01vZGVsSGVscGVyLkNhbGxDb250cm9sbGVyTWV0aG9kKFxyXG4gICAgICAgICAgICAgICAgICAgICAgICByZW5kZXJPd25lci5Db250cm9sbGVyLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBtZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBzdGFjayk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgZmluYWxseVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5Qb3AocmVuZGVyT3duZXIpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIG9iamVjdCBHZXRBY3Rpb25Gb3JQcm9wZXJ0eShQcm9wZXJ0eU1ldGFkYXRhIHByb3BlcnR5LCBJQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycyBwYXJhbWV0ZXJzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHNldHRpbmdzID0gcHJvcGVydHkuU2V0dGluZ3MgYXMgQWN0aW9uU2V0dGluZ3M7XHJcbiAgICAgICAgICAgIGlmIChzZXR0aW5ncyA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB2YXIgZ2V0Q29udHJvbGxlckZ1bmMgPSBuZXcgRnVuYzxJQ29udHJvbGxlcj4oKCkgPT4gcGFyYW1ldGVycy5WaWV3TW9kZWwuQ29udHJvbGxlcik7XHJcbklGb3JtVmlld01vZGVsIGZvcm1WaWV3TW9kZWw7ICAgICAgICAgICAgaWYgKChmb3JtVmlld01vZGVsID0gcGFyYW1ldGVycy5WaWV3TW9kZWwgYXMgSUZvcm1WaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtZXRob2ROYW1lID0gZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTFcIixTY3JpcHRNZXRob2RJbmZvSGVscGVyLkRlc2VyaWFsaXplKHNldHRpbmdzLkRlZmF1bHRWYWx1ZS5NZXRob2ROYW1lKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFNjcmlwdE1ldGhvZEluZm8+KFwia2V5MVwiKS5OYW1lOihzdHJpbmcpbnVsbDtcclxuICAgICAgICAgICAgICAgIGlmICghc3RyaW5nLklzTnVsbE9yV2hpdGVTcGFjZShtZXRob2ROYW1lKSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBnZXRDb250cm9sbGVyRnVuYyA9IG5ldyBGdW5jPElDb250cm9sbGVyPigoKSA9PiBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLkZpcnN0T3JEZWZhdWx0PFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljLktleVZhbHVlUGFpcjxHdWlkLElDb250cm9sbGVyPj4oZm9ybVZpZXdNb2RlbC5Db250cm9sbGVycywoRnVuYzxTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYy5LZXlWYWx1ZVBhaXI8R3VpZCxJQ29udHJvbGxlcj4sYm9vbD4pKGMgPT4gYy5WYWx1ZVttZXRob2ROYW1lXSAhPSBudWxsKSkuVmFsdWUpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBBY3Rpb25WYWx1ZSBhY3Rpb25EZWZhdWx0VmFsdWUgPSBudWxsO1xyXG4gICAgICAgICAgICB2YXIgYWN0aW9uU2V0dGluZ3NEZWZhdWx0VmFsdWUgPSBzZXR0aW5ncy5EZWZhdWx0VmFsdWU7XHJcbiAgICAgICAgICAgIGlmIChhY3Rpb25TZXR0aW5nc0RlZmF1bHRWYWx1ZSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBhY3Rpb25EZWZhdWx0VmFsdWUgPSBuZXcgQWN0aW9uVmFsdWVcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBDb2RlVHlwZSA9IGFjdGlvblNldHRpbmdzRGVmYXVsdFZhbHVlLkNvZGVUeXBlLFxyXG4gICAgICAgICAgICAgICAgICAgIE1ldGhvZE5hbWUgPSBhY3Rpb25TZXR0aW5nc0RlZmF1bHRWYWx1ZS5NZXRob2ROYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgIEZ1bmN0aW9uSGVhZGVyVWlkID0gYWN0aW9uU2V0dGluZ3NEZWZhdWx0VmFsdWUuRnVuY3Rpb25IZWFkZXJVaWRcclxuICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBleGVjdXRpb25Db250ZXh0ID0gR2V0QWN0aW9uRXhlY3V0aW9uQ29udGV4dChcclxuICAgICAgICAgICAgICAgIHByb3BlcnR5LFxyXG4gICAgICAgICAgICAgICAgYWN0aW9uRGVmYXVsdFZhbHVlLFxyXG4gICAgICAgICAgICAgICAgc2V0dGluZ3MsXHJcbiAgICAgICAgICAgICAgICBwYXJhbWV0ZXJzLk1ldGFkYXRhVWlkLFxyXG4gICAgICAgICAgICAgICAgcGFyYW1ldGVycy5NZXRhZGF0YVR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICBwYXJhbWV0ZXJzLk1ldGFkYXRhTW9kdWxlVWlkLFxyXG4gICAgICAgICAgICAgICAgcGFyYW1ldGVycy5PdXRlclN0YWNrLFxyXG4oRnVuYzxJQ29udHJvbGxlcj4pICAgICAgICAgICAgICAgIGdldENvbnRyb2xsZXJGdW5jXHJcbiAgICAgICAgICAgICk7XHJcblxyXG4gICAgICAgICAgICB2YXIgcmV0dXJuVHlwZSA9IER5bmFtaWNQcm9wZXJ0eUhlbHBlci5UeXBlU2lnbmF0dXJlTWFwVG9PYmplY3Qoc2V0dGluZ3MuUmV0dXJuVHlwZSk7XHJcbiAgICAgICAgICAgIHZhciBwYXJhbWV0ZXJUeXBlID0gRHluYW1pY1Byb3BlcnR5SGVscGVyLlR5cGVTaWduYXR1cmVNYXBUb09iamVjdChzZXR0aW5ncy5QYXJhbWV0ZXJUeXBlKTtcclxuICAgICAgICAgICAgcmV0dXJuIENyZWF0ZUNsb3N1cmVGb3JBY3Rpb24ocmV0dXJuVHlwZSwgcGFyYW1ldGVyVHlwZSwgZXhlY3V0aW9uQ29udGV4dCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIElBY3Rpb25FeGVjdXRpb25Db250ZXh0IEdldEFjdGlvbkV4ZWN1dGlvbkNvbnRleHQoXHJcbiAgICAgICAgICAgIFByb3BlcnR5TWV0YWRhdGEgcHJvcGVydHlNZXRhZGF0YSxcclxuICAgICAgICAgICAgQWN0aW9uVmFsdWUgYWN0aW9uVmFsdWUsXHJcbiAgICAgICAgICAgIEFjdGlvblNldHRpbmdzIHNldHRpbmdzLFxyXG4gICAgICAgICAgICBHdWlkIG1ldGFkYXRhVWlkLFxyXG4gICAgICAgICAgICBHdWlkIG1ldGFkYXRhVHlwZVVpZCxcclxuICAgICAgICAgICAgR3VpZCBtZXRhZGF0YU1vZHVsZVVpZCxcclxuICAgICAgICAgICAgSURhdGFTdGFjayBvdXRlclN0YWNrLFxyXG4gICAgICAgICAgICBGdW5jPElDb250cm9sbGVyPiBjb250cm9sbGVyRnVuY1xyXG4gICAgICAgIClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChhY3Rpb25WYWx1ZSA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbmV3IEVtcHR5QWN0aW9uRXhlY3V0aW9uQ29udGV4dChwcm9wZXJ0eU1ldGFkYXRhLCBjb250cm9sbGVyRnVuYyk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHN3aXRjaCAoKENvZGVUeXBlKWFjdGlvblZhbHVlLkNvZGVUeXBlKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBjYXNlIENvZGVUeXBlLkNsaWVudDpcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBpZiAoc3RyaW5nLklzTnVsbE9yV2hpdGVTcGFjZShhY3Rpb25WYWx1ZS5NZXRob2ROYW1lKSlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIG5ldyBDbGllbnRGdW5jdGlvbkV4ZWN1dGlvbkNvbnRleHQoYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSwgY29udHJvbGxlckZ1bmMsIG91dGVyU3RhY2spO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgY2FzZSBDb2RlVHlwZS5TZXJ2ZXI6XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UoYWN0aW9uVmFsdWUuTWV0aG9kTmFtZSkpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBicmVhaztcclxuICAgICAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIGlmIChtZXRhZGF0YVVpZCA9PSBHdWlkLkVtcHR5IHx8IG1ldGFkYXRhVHlwZVVpZCA9PSBHdWlkLkVtcHR5KVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWs7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICB2YXIgc2V0dGluZ3NSZXR1cm5UeXBlID0gc2V0dGluZ3MuUmV0dXJuVHlwZTtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgcmV0dXJuVHlwZSA9IG5ldyBTaWduYXR1cmVcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIE51bGxhYmxlID0gc2V0dGluZ3NSZXR1cm5UeXBlLk51bGxhYmxlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBSZWxhdGlvblR5cGUgPSBzZXR0aW5nc1JldHVyblR5cGUuUmVsYXRpb25UeXBlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBUeXBlVWlkID0gc2V0dGluZ3NSZXR1cm5UeXBlLlR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFN1YlR5cGVVaWQgPSBzZXR0aW5nc1JldHVyblR5cGUuU3ViVHlwZVVpZFxyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHNldHRpbmdzUGFyYW1ldGVyVHlwZSA9IHNldHRpbmdzLlBhcmFtZXRlclR5cGU7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHBhcmFtZXRlclR5cGUgPSBuZXcgU2lnbmF0dXJlXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBOdWxsYWJsZSA9IHNldHRpbmdzUGFyYW1ldGVyVHlwZS5OdWxsYWJsZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgUmVsYXRpb25UeXBlID0gc2V0dGluZ3NQYXJhbWV0ZXJUeXBlLlJlbGF0aW9uVHlwZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgVHlwZVVpZCA9IHNldHRpbmdzUGFyYW1ldGVyVHlwZS5UeXBlVWlkLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBTdWJUeXBlVWlkID0gc2V0dGluZ3NQYXJhbWV0ZXJUeXBlLlN1YlR5cGVVaWRcclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBuZXcgU2VydmVyRnVuY3Rpb25FeGVjdXRpb25Db250ZXh0KGFjdGlvblZhbHVlLk1ldGhvZE5hbWUsIG1ldGFkYXRhVHlwZVVpZCwgbWV0YWRhdGFVaWQsIHJldHVyblR5cGUsIHBhcmFtZXRlclR5cGUpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgY2FzZSBDb2RlVHlwZS5UZXN0OlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgY2FzZSBDb2RlVHlwZS5HbG9iYWxGdW5jdGlvbjpcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBpZiAobWV0YWRhdGFVaWQgPT0gR3VpZC5FbXB0eSlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGZ1bmN0aW9uSGVhZGVyVWlkID0gYWN0aW9uVmFsdWUuRnVuY3Rpb25IZWFkZXJVaWQ7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGZ1bmN0aW9uSXRlbVVpZCA9IGN1cnJlbnRQYWdlU2VydmljZS5HZXRGdW5jdGlvbkl0ZW1VaWQobWV0YWRhdGFVaWQsIGZ1bmN0aW9uSGVhZGVyVWlkKTtcclxuICAgICAgICAgICAgICAgICAgICBpZiAoZnVuY3Rpb25JdGVtVWlkID09IEd1aWQuRW1wdHkpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBmdW5jdGlvbkl0ZW1VaWQgPSBjdXJyZW50UGFnZVNlcnZpY2UuR2V0RnVuY3Rpb25JdGVtVWlkKG1ldGFkYXRhTW9kdWxlVWlkLCBmdW5jdGlvbkhlYWRlclVpZCk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICB2YXIgc2V0dGluZ3NSZXR1cm5UeXBlID0gc2V0dGluZ3MuUmV0dXJuVHlwZTtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgcmV0dXJuVHlwZSA9IG5ldyBTaWduYXR1cmVcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIE51bGxhYmxlID0gc2V0dGluZ3NSZXR1cm5UeXBlLk51bGxhYmxlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBSZWxhdGlvblR5cGUgPSBzZXR0aW5nc1JldHVyblR5cGUuUmVsYXRpb25UeXBlLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBUeXBlVWlkID0gc2V0dGluZ3NSZXR1cm5UeXBlLlR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFN1YlR5cGVVaWQgPSBzZXR0aW5nc1JldHVyblR5cGUuU3ViVHlwZVVpZFxyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHNldHRpbmdzUGFyYW1ldGVyVHlwZSA9IHNldHRpbmdzLlBhcmFtZXRlclR5cGU7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHBhcmFtZXRlclR5cGUgPSBuZXcgU2lnbmF0dXJlXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBOdWxsYWJsZSA9IHNldHRpbmdzUGFyYW1ldGVyVHlwZS5OdWxsYWJsZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgUmVsYXRpb25UeXBlID0gc2V0dGluZ3NQYXJhbWV0ZXJUeXBlLlJlbGF0aW9uVHlwZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgVHlwZVVpZCA9IHNldHRpbmdzUGFyYW1ldGVyVHlwZS5UeXBlVWlkLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBTdWJUeXBlVWlkID0gc2V0dGluZ3NQYXJhbWV0ZXJUeXBlLlN1YlR5cGVVaWRcclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBuZXcgR2xvYmFsRnVuY3Rpb25FeGVjdXRpb25Db250ZXh0KGZ1bmN0aW9uSXRlbVVpZCwgcmV0dXJuVHlwZSwgcGFyYW1ldGVyVHlwZSk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBkZWZhdWx0OlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGJyZWFrO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gbmV3IEVtcHR5QWN0aW9uRXhlY3V0aW9uQ29udGV4dCgpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBvYmplY3QgQ3JlYXRlQ2xvc3VyZUZvckFjdGlvbihUeXBlU2lnbmF0dXJlIHJldHVyblR5cGVTaWduYXR1cmUsIFR5cGVTaWduYXR1cmUgcGFyYW1ldGVyVHlwZVNpZ25hdHVyZSwgSUFjdGlvbkV4ZWN1dGlvbkNvbnRleHQgYWN0aW9uRXhlY3V0aW9uQ29udGV4dClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIElBY3Rpb24gYWN0aW9uO1xyXG4gICAgICAgICAgICBUeXBlIGFjdGlvblR5cGU7XHJcbiAgICAgICAgICAgIHZhciByZXR1cm5UeXBlID0gY29udmVydFNlcnZpY2UuVG9UeXBlKHJldHVyblR5cGVTaWduYXR1cmUpO1xyXG4gICAgICAgICAgICB2YXIgcGFyYW1ldGVyVHlwZSA9IGNvbnZlcnRTZXJ2aWNlLlRvVHlwZShwYXJhbWV0ZXJUeXBlU2lnbmF0dXJlKTtcclxuICAgICAgICAgICAgaWYgKHBhcmFtZXRlclR5cGUgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgYWN0aW9uVHlwZSA9IHJldHVyblR5cGUgPT0gbnVsbFxyXG4gICAgICAgICAgICAgICAgICAgID8gdHlwZW9mKERlZmF1bHRBY3Rpb24pXHJcbiAgICAgICAgICAgICAgICAgICAgOiB0eXBlb2YoQWN0aW9uV2l0aFJlc3VsdDw+KS5NYWtlR2VuZXJpY1R5cGUobmV3W10geyByZXR1cm5UeXBlIH0pO1xyXG4gICAgICAgICAgICAgICAgYWN0aW9uID0gKElBY3Rpb24pIEFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZShhY3Rpb25UeXBlLCBhY3Rpb25FeGVjdXRpb25Db250ZXh0LCBhY3Rpb25FeGVjdXRpb25GYWNhZGUpO1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIENsb3N1cmVIZWxwZXIuQ3JlYXRlRm9yQWN0aW9uV2l0aFBhcmFtKGFjdGlvbik7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIGFjdGlvblR5cGUgPSByZXR1cm5UeXBlID09IG51bGxcclxuICAgICAgICAgICAgICAgID8gdHlwZW9mKEFjdGlvbldpdGhQYXJhbTw+KS5NYWtlR2VuZXJpY1R5cGUobmV3W10geyBwYXJhbWV0ZXJUeXBlIH0pXHJcbiAgICAgICAgICAgICAgICA6IHR5cGVvZihBY3Rpb25XaXRoUGFyYW1SZXN1bHQ8LD4pLk1ha2VHZW5lcmljVHlwZShuZXdbXSB7IHBhcmFtZXRlclR5cGUsIHJldHVyblR5cGUgfSk7XHJcbiAgICAgICAgICAgIGFjdGlvbiA9IChJQWN0aW9uKSBBY3RpdmF0b3IuQ3JlYXRlSW5zdGFuY2UoYWN0aW9uVHlwZSwgYWN0aW9uRXhlY3V0aW9uQ29udGV4dCwgYWN0aW9uRXhlY3V0aW9uRmFjYWRlKTtcclxuICAgICAgICAgICAgcmV0dXJuIENsb3N1cmVIZWxwZXIuQ3JlYXRlRm9yQWN0aW9uV2l0aFBhcmFtKGFjdGlvbik7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59IiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgQnJpZGdlLkh0bWw1O1xyXG51c2luZyBCcmlkZ2UuUmVhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db25zdGFudHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkFic3RyYWN0aW9ucy5NZXRhZGF0YS5Nb2RlbHMuTWV0YWRhdGE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkFic3RyYWN0aW9ucy5NZXRhZGF0YS5Nb2RlbHMuVUkuTWV0YWRhdGE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5FeHRlbnNpb25zO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQutC+0LzQv9C+0L3QtdC90YIg0L7RgtC+0LHRgNCw0LbQtdC90LjRjyDRgtC40L/QsCDQtNCw0L3QvdGL0YVcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVE1cIj48L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUSW5wdXRzXCI+PC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVENvbnRleHRcIj48L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udHJvbGxlclwiPjwvdHlwZXBhcmFtPlxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIEJhc2VJbnB1dENvbXBvbmVudDxUTSwgVENvbnRleHQsIFRDb250cm9sbGVyPiA6IEJhc2VSZWFjdENvbXBvbmVudDxCYXNlSW5wdXRzPFRNPiwgVENvbnRleHQsIFRDb250cm9sbGVyPiwgSUlucHV0Q29tcG9uZW50XHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQmFzZUlucHV0cywgSUJhc2VDb250ZXh0XHJcbiAgICAgICAgd2hlcmUgVENvbnRyb2xsZXIgOiBJQmFzZUlucHV0Q29udHJvbGxlclxyXG4gICAge1xyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlSW5wdXRDb21wb25lbnQoSVJlYWN0SW5wdXRNb2RlbDxCYXNlSW5wdXRzPFRNPj4gbW9kZWwpIDogYmFzZShtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIGJvb2wgaXNGb2N1c2VkO1xyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgb3ZlcnJpZGUgYXN5bmMgVGFzayBDb21wb25lbnREaWRNb3VudCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBhd2FpdCBiYXNlLkNvbXBvbmVudERpZE1vdW50KCk7XHJcblxyXG4gICAgICAgICAgICBEaXNwYXRjaGVyLkRpc3BhdGNoKChBY3Rpb248VENvbnRyb2xsZXI+KShjID0+IEZvY3VzaW5nSW5wdXQodHJ1ZSkpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSBhc3luYyBUYXNrIENvbXBvbmVudERpZFVwZGF0ZShCYXNlUmVhY3RQcm9wczxJUmVhY3RJbnB1dE1vZGVsPEJhc2VJbnB1dHM8VE0+Pj4gcHJldmlvdXNQcm9wcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGF3YWl0IGJhc2UuQ29tcG9uZW50RGlkVXBkYXRlKHByZXZpb3VzUHJvcHMpO1xyXG5cclxuICAgICAgICAgICAgRGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uPFRDb250cm9sbGVyPikoYyA9PiBGb2N1c2luZ0lucHV0KGZhbHNlKSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSB2b2lkIEZvY3VzaW5nSW5wdXQoYm9vbCBmaXJzdFNob3cpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoSW5wdXRFbGVtZW50ID09IG51bGwgfHwgQ29udGV4dC5Gb2N1c2FibGVUeXBlID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGZvY3VzYWJsZVR5cGUgPSBDb250ZXh0LkZvY3VzYWJsZVR5cGUoZmlyc3RTaG93KTtcclxuICAgICAgICAgICAgaWYgKGZvY3VzYWJsZVR5cGUgPT0gRm9jdXNhYmxlVHlwZS5Ob25lKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgZWxzZSBpZiAoZm9jdXNhYmxlVHlwZSA9PSBGb2N1c2FibGVUeXBlLkRlZmF1bHQpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmICghaXNGb2N1c2VkKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGlzRm9jdXNlZCA9IHRydWU7XHJcbiAgICAgICAgICAgICAgICAgICAgV2luZG93LlNldFRpbWVvdXQoKEFjdGlvbikoKCkgPT4gSW5wdXRFbGVtZW50IT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tTGFtYmRhKCgpPT5JbnB1dEVsZW1lbnQuRm9jdXMoKSk6bnVsbCksIDEwMCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBXaW5kb3cuU2V0VGltZW91dCgoQWN0aW9uKSgoKSA9PiBJbnB1dEVsZW1lbnQhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21MYW1iZGEoKCk9PklucHV0RWxlbWVudC5Gb2N1cygpKTpudWxsKSwgMTAwKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgaW50ZXJuYWwgc2VhbGVkIG92ZXJyaWRlIFJlYWN0RWxlbWVudCBSZW5kZXJJbnRlcm5hbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgZm9jdXNhYmxlID0gQ29udGV4dC5Gb2N1c2FibGVUeXBlKGZhbHNlKTtcclxuICAgICAgICAgICAgcmV0dXJuIGJhc2UuUmVuZGVySW50ZXJuYWwoKTtcclxuICAgICAgICB9XHJcbi8vLyA8aW5oZXJpdGRvYyAvPlxyXG5wcm90ZWN0ZWQgb3ZlcnJpZGUgVHlwZSBUeXBlVmlld01vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiB0eXBlb2YoQmFzZUlucHV0Vmlld01vZGVsKTtcclxuICAgIH1cclxufVxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gSHRtbC3RjdC70LXQvNC10L3RgiDQutC+0L3RgtC10LnQvdC10YDQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHJvdGVjdGVkIEhUTUxFbGVtZW50IElucHV0RWxlbWVudDtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC10YLQvtC0INGD0YHRgtCw0L3QvtCy0LrQuCDRgtC10LrRg9GJ0LXQs9C+INCw0LrRgtC40LLQvdC+0LPQviDRjdC70LXQvNC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJlbGVtZW50XCI+0KLQtdC60YPRidC40Lkg0Y3Qu9C10LzQtdC90YI8L3BhcmFtPlxyXG4gICAgICAgIHByb3RlY3RlZCB2b2lkIFNldElucHV0UmVmKEhUTUxFbGVtZW50IGVsZW1lbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBJbnB1dEVsZW1lbnQgPSBlbGVtZW50O1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICAvLy8vLyA8c3VtbWFyeT5cclxuICAgIC8vLy8vINCR0LDQt9C+0LLRi9C5INC60L7QvNC/0L7QvdC10L3RgiDQvtGC0L7QsdGA0LDQttC10L3QuNGPINGC0LjQv9CwINC00LDQvdC90YvRhVxyXG4gICAgLy8vLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vLy8gPHJlbWFya3M+XHJcbiAgICAvLy8vLyDQldGB0LvQuCDQtNC70Y8g0LrQvtC90LXRh9C90L7Qs9C+INC60L7QvNC/0L7QvdC10L3RgtCwINC40YHQv9C+0LvRjNC30YPQtdGC0YHRjyDRgtC10LrRg9GJ0LjQuSDQsdCw0LfQvtCy0YvQuSDQvdC10LvRjNC30Y8g0LjRgdC/0L7Qu9GM0LfQvtCy0LDRgtGMINC80LXRgtC+0LTRiyDRgdC+0LHRi9GC0LjQuSDQsdCw0LfQvtCy0L7Qs9C+INC60L7QvdGC0YDQvtC70LvQtdGA0LBcclxuICAgIC8vLy8vINCSINGB0LvRg9GH0LDQtSwg0LXRgdC70Lgg0YHQvtCx0YvRgtC40Y8g0L3QtdC+0LHRhdC+0LTQuNC80L4g0LjRgdC/0L7Qu9GM0LfQvtCy0LDRgtGMINC90YPQttC90L4g0YDQtdCw0LvQuNC30L7QstCw0YLRjCDRgdCy0L7QuSDQutC+0L3RgtGA0L7Qu9C70LXRgFxyXG4gICAgLy8vLy8gPC9yZW1hcmtzPlxyXG4gICAgLy8vLy8gPHR5cGVwYXJhbSBuYW1lPVwiVE1cIj48L3R5cGVwYXJhbT5cclxuICAgIC8vLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRJbnB1dHNcIj48L3R5cGVwYXJhbT5cclxuICAgIC8vLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250ZXh0XCI+PC90eXBlcGFyYW0+XHJcbiAgICAvL3B1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlSW5wdXRDb21wb25lbnQ8VE0sIFRDb250ZXh0PiA6IEJhc2VJbnB1dENvbXBvbmVudDxUTSwgVENvbnRleHQsIEJhc2VJbnB1dENvbnRyb2xsZXI+XHJcbiAgICAvLyAgICB3aGVyZSBUQ29udGV4dCA6IElCYXNlSW5wdXRzLCBJQmFzZUNvbnRleHRcclxuICAgIC8ve1xyXG4gICAgLy8gICAgcHJvdGVjdGVkIEJhc2VJbnB1dENvbXBvbmVudChJUmVhY3RJbnB1dE1vZGVsPEJhc2VJbnB1dHM8VE0+PiBtb2RlbCkgOiBiYXNlKG1vZGVsKVxyXG4gICAgLy8gICAge1xyXG4gICAgLy8gICAgfVxyXG4gICAgLy99XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60L7QvNC/0L7QvdC10L3RgiDQvtGC0L7QsdGA0LDQttC10L3QuNGPINGC0LjQv9CwINC00LDQvdC90YvRhVxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUTVwiPjwvdHlwZXBhcmFtPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250cm9sbGVyXCI+PC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZUlucHV0Q29tcG9uZW50PFRNLCBUQ29udHJvbGxlcj4gOiBCYXNlSW5wdXRDb21wb25lbnQ8VE0sIEJhc2VDb250ZXh0PFRNPiwgVENvbnRyb2xsZXI+XHJcbiAgICAgICAgd2hlcmUgVENvbnRyb2xsZXIgOiBCYXNlSW5wdXRDb250cm9sbGVyPFRNPlxyXG4gICAge1xyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlSW5wdXRDb21wb25lbnQoSVJlYWN0SW5wdXRNb2RlbDxCYXNlSW5wdXRzPFRNPj4gbW9kZWwpIDogYmFzZShtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQutC+0LzQv9C+0L3QtdC90YIg0L7RgtC+0LHRgNCw0LbQtdC90LjRjyDRgtC40L/QsCDQtNCw0L3QvdGL0YVcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAvLy8gPHJlbWFya3M+XHJcbiAgICAvLy8g0JXRgdC70Lgg0LTQu9GPINC60L7QvdC10YfQvdC+0LPQviDQutC+0LzQv9C+0L3QtdC90YLQsCDQuNGB0L/QvtC70YzQt9GD0LXRgtGB0Y8g0YLQtdC60YPRidC40Lkg0LHQsNC30L7QstGL0Lkg0L3QtdC70YzQt9GPINC40YHQv9C+0LvRjNC30L7QstCw0YLRjCDQvNC10YLQvtC00Ysg0YHQvtCx0YvRgtC40Lkg0LHQsNC30L7QstC+0LPQviDQutC+0L3RgtGA0L7Qu9C70LXRgNCwXHJcbiAgICAvLy8g0JIg0YHQu9GD0YfQsNC1LCDQtdGB0LvQuCDRgdC+0LHRi9GC0LjRjyDQvdC10L7QsdGF0L7QtNC40LzQviDQuNGB0L/QvtC70YzQt9C+0LLQsNGC0Ywg0L3Rg9C20L3QviDRgNC10LDQu9C40LfQvtCy0LDRgtGMINGB0LLQvtC5INC60L7QvdGC0YDQvtC70LvQtdGAXHJcbiAgICAvLy8gPC9yZW1hcmtzPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRNXCI+PC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZUlucHV0Q29tcG9uZW50PFRNPiA6IEJhc2VJbnB1dENvbXBvbmVudDxUTSwgQmFzZUNvbnRleHQ8VE0+LCBCYXNlSW5wdXRDb250cm9sbGVyPlxyXG4gICAge1xyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlSW5wdXRDb21wb25lbnQoSVJlYWN0SW5wdXRNb2RlbDxCYXNlSW5wdXRzPFRNPj4gbW9kZWwpIDogYmFzZShtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlSW5wdXRzPFRNPiA6IEJhc2VJbnB1dHM8VE0sIFJlYWN0RWxlbWVudFtdPlxyXG4gICAge1xyXG4gICAgfVxyXG5cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlQ29udGV4dDxUTT4gOiBCYXNlSW5wdXRzPFRNPiwgSUJhc2VDb250ZXh0XHJcbiAgICB7XHJcbiAgICB9XHJcblxyXG4gICAgcHVibGljIGludGVyZmFjZSBJQmFzZUlucHV0Q29udHJvbGxlciA6IElDb250cm9sbGVyXHJcbiAgICB7XHJcbiAgICB9XHJcblxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIEJhc2VJbnB1dENvbnRyb2xsZXI8VE0sIFRDb250ZXh0PiA6IENvbnRyb2xsZXI8VENvbnRleHQ+LCBJQmFzZUlucHV0Q29udHJvbGxlciwgSVJlcXVpcmVPd25lckNvbnRyb2xsZXJcclxuICAgICAgICB3aGVyZSBUQ29udGV4dCA6IElCYXNlQ29udGV4dFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgbG9uZyBjYXJldFBvc2l0aW9uID0gMDtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC+0LTQtdC70Ywg0YDQvtC00LjRgtC10LvRjNGB0LrQvtCz0L4g0LrQvtC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgSVZpZXdNb2RlbCBSZW5kZXJPd25lcjtcclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIHZvaWQgU2V0T3duZXIoSVZpZXdNb2RlbCBvd25lcilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFJlbmRlck93bmVyID0gb3duZXI7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0Ywg0L/QvtC70L3QvtC1INC90LDQuNC80LXQvdC+0LLQsNC90LjQtVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCd0LDQuNC80LXQvdC+0LLQsNC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBzdHJpbmcgR2V0TmFtZShzdHJpbmcgbmV3TmFtZSA9IHN0cmluZy5FbXB0eSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBuYW1lID0gbmV3TmFtZTtcclxuICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UobmFtZSkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChDb250ZXh0LlByb3BlcnR5TWV0YWRhdGEgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gc3RyaW5nLkVtcHR5O1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBwcm9wZXJ0eSA9IENvbnRleHQuUHJvcGVydHlNZXRhZGF0YSgpO1xyXG4gICAgICAgICAgICAgICAgaWYgKHByb3BlcnR5ID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHN0cmluZy5FbXB0eTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBuYW1lID0gcHJvcGVydHkuTmFtZTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKCFzdHJpbmcuSXNOdWxsT3JXaGl0ZVNwYWNlKG5hbWUpKVxyXG4gICAgICAgICAgICB7XHJcbkRhdGFTdGFjayBzdGFjazsgICAgICAgICAgICAgICAgaWYgKFJlbmRlck93bmVyICE9IG51bGxcclxuICAgICAgICAgICAgICAgICAgICAmJiAoc3RhY2sgPSBSZW5kZXJPd25lci5HZXREeW5hbWljRGF0YSgpIGFzIERhdGFTdGFjaykgIT0gbnVsbCAgICAgICAgICAgICAgICAgICAgJiYgc3RhY2suQ291bnQgPiAwXHJcbiAgICAgICAgICAgICAgICAgICAgJiYgKGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsc3RhY2suTGFzdE9yRGVmYXVsdDxEYXRhU3RhY2tJdGVtPigpKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8RGF0YVN0YWNrSXRlbT4oXCJrZXkxXCIpLkRhdGE6KE1vZGVsLklEYXRhKW51bGwpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHN0cmluZy5FbXB0eTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlPd25lciA9IGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkyXCIsQ29udGV4dC5Qcm9wZXJ0eU93bmVyKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8RnVuYzxJVmlld01vZGVsPj4oXCJrZXkyXCIpLkludm9rZSgpOihJVmlld01vZGVsKW51bGw7XHJcbiAgICAgICAgICAgICAgICB2YXIgb3duZXIgPSBSZW5kZXJPd25lciBhcyBJTWV0YWRhdGFWaWV3TW9kZWw7XHJcbiAgICAgICAgICAgICAgICB2YXIgb3duZXJNZXRhZGF0YSA9IG93bmVyIT1udWxsJiZnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5M1wiLG93bmVyLk1vZGVsTWV0YWRhdGEpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxNb2RlbE1ldGFkYXRhPihcImtleTNcIikuTWV0YWRhdGE6KENsYXNzTWV0YWRhdGEpbnVsbDtcclxuICAgICAgICAgICAgICAgIHZhciBtZXRhZGF0YSA9IHByb3BlcnR5T3duZXIhPW51bGw/cHJvcGVydHlPd25lci5Db250ZXh0LkdldFBsYWluUHJvcGVydHlWYWx1ZTxNb2RlbE1ldGFkYXRhPihcIk1vZGVsTWV0YWRhdGFcIik6KE1vZGVsTWV0YWRhdGEpbnVsbDtcclxuICAgICAgICAgICAgICAgIGlmIChtZXRhZGF0YSA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBuYW1lO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBmaXJzdFByZWZpeCA9IHN0cmluZy5FbXB0eTtcclxuICAgICAgICAgICAgICAgIGlmIChvd25lck1ldGFkYXRhIGlzIEVudGl0eU1ldGFkYXRhIHx8IG93bmVyTWV0YWRhdGEgaXMgRGF0YUNsYXNzTWV0YWRhdGEpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgZmlyc3RQcmVmaXggPSBcIkVudGl0eVwiO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZWxzZSBpZiAob3duZXJNZXRhZGF0YSBpcyBDb21wb25lbnRDb250ZXh0TWV0YWRhdGEpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgZmlyc3RQcmVmaXggPSBcIkNvbnRleHRcIjtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIHZhciBwcmVmaXhBcnIgPSBtZXRhZGF0YS5QcmVmaXg7XHJcbiAgICAgICAgICAgICAgICBpZiAocHJlZml4QXJyICE9IG51bGwgJiYgcHJlZml4QXJyLkxlbmd0aCA+IDApXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHByZWZpeCA9IHN0cmluZy5Kb2luKFwiLlwiLCBwcmVmaXhBcnIpO1xyXG5cclxuICAgICAgICAgICAgICAgICAgICAjcmVnaW9uINCa0L7RgdGC0YvQu9GMINC00LvRjyDRhNC+0YDQvCDQtNC+0LrRg9C80LXQvdGC0L7QsiDQuCDQoNCa0JpcclxuXHJcbiAgICAgICAgICAgICAgICAgICAgLy8gdG9kbzogRUxNQTQtNjg2NiDQo9C00LDQu9C40YLRjCDQutC+0YHRgtGL0LvRjCDQtNC70Y8g0YDQtdC90LTQtdGA0LAg0YTQvtGA0Lwg0KDQmtCaXHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHByZWZpeC5TdGFydHNXaXRoKFJLS0Zvcm1Db25zdGFudHMuUktLRm9ybVByZWZpeCkpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAvLyDQvtCx0YDQsNCx0L7RgtC60LAg0LTQu9GPINGE0L7RgNC80Ysg0KDQmtCaXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHByZWZpeCA9IHByZWZpeFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgLlJlcGxhY2UoUktLRm9ybUNvbnN0YW50cy5SS0tGb3JtUHJlZml4ICsgXCIuXCIsIHN0cmluZy5FbXB0eSlcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIC5SZXBsYWNlKFJLS0Zvcm1Db25zdGFudHMuUktLRm9ybVByZWZpeCwgc3RyaW5nLkVtcHR5KTtcclxuXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmIChwcmVmaXggPT0gXCJSZWdpc3RyYXRpb25DYXJkXCIgfHwgcHJlZml4LlN0YXJ0c1dpdGgoXCJSZWdpc3RyYXRpb25DYXJkLlwiKSlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgLy8g0YHQstC+0LnRgdGC0LLQsCDQoNCa0JpcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBzdHJpbmcuRm9ybWF0KFwiezB9LnsxfVwiLHByZWZpeCxuYW1lKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgLy8g0YTQvtGA0LzQsCDQtNC+0LrRg9C80LXQvdGC0LBcclxuICAgICAgICAgICAgICAgICAgICBpZiAocHJlZml4LlN0YXJ0c1dpdGgoUktLRm9ybUNvbnN0YW50cy5Eb2N1bWVudEZvcm1QcmVmaXgpKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgLy8g0L7QsdGA0LDQsdC+0YLQutCwINC00LvRjyDRhNC+0YDQvNGLINC00L7QutGD0LzQtdC90YLQsFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBwcmVmaXggPSBwcmVmaXhcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIC5SZXBsYWNlKFJLS0Zvcm1Db25zdGFudHMuRG9jdW1lbnRGb3JtUHJlZml4ICsgXCIuXCIsIHN0cmluZy5FbXB0eSlcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIC5SZXBsYWNlKFJLS0Zvcm1Db25zdGFudHMuRG9jdW1lbnRGb3JtUHJlZml4LCBzdHJpbmcuRW1wdHkpO1xyXG5cclxuICAgICAgICAgICAgICAgICAgICAgICAgLy8g0L7QsdGA0LDQsdC+0YLQutCwINGB0LLQvtC50YHRgtCyINCg0JrQmlxyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAocHJlZml4ID09IFwiUmVnaXN0cmF0aW9uQ2FyZFwiKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBwcmVmaXggPSBzdHJpbmcuRm9ybWF0KFwiezB9WzBdXCIscHJlZml4KTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgICAgICBlbHNlIGlmIChwcmVmaXguU3RhcnRzV2l0aChcIlJlZ2lzdHJhdGlvbkNhcmQuXCIpKVxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB2YXIgcGFydHMgPSBwcmVmaXguU3BsaXQobmV3W10geyAnLicgfSwgU3RyaW5nU3BsaXRPcHRpb25zLlJlbW92ZUVtcHR5RW50cmllcyk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBwYXJ0c1swXSA9IHN0cmluZy5Gb3JtYXQoXCJ7MH1bMF1cIixwYXJ0c1swXSk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBwcmVmaXggPSBzdHJpbmcuSm9pbihcIi5cIiwgcGFydHMpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBzdHJpbmcuSXNOdWxsT3JXaGl0ZVNwYWNlKHByZWZpeClcclxuICAgICAgICAgICAgICAgICAgICAgICAgPyBzdHJpbmcuRm9ybWF0KFwiezB9LnsxfVwiLGZpcnN0UHJlZml4LG5hbWUpICAgICAgICAgICAgICAgICAgICAgICAgOiBzdHJpbmcuRm9ybWF0KFwiezB9LnsxfS57Mn1cIixmaXJzdFByZWZpeCxwcmVmaXgsbmFtZSk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gc3RyaW5nLkZvcm1hdChcInswfS57MX1cIixmaXJzdFByZWZpeCxuYW1lKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICByZXR1cm4gc3RyaW5nLkVtcHR5O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQlNC10LnRgdGC0LLQuNC1INC/0YDQuCDQstCy0L7QtNC1INC30L3QsNGH0LXQvdC40Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZhbHVlXCI+0JfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXZcIj7QodC+0LHRi9GC0LjQtSDQuNC30LzQtdC90LXQvdC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIE9uQ2hhbmdlKFRNIHZhbHVlLCBCcmlkZ2UuUmVhY3QuQ2hhbmdlRXZlbnQ8SFRNTElucHV0RWxlbWVudD4gZXYpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoZXYgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY2FyZXRQb3NpdGlvbiA9IGV2LkN1cnJlbnRUYXJnZXQuU2VsZWN0aW9uU3RhcnQ7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBuZXdFdiA9IG5ldyBFTE1BLk1vZGVsLlZpZXdNb2RlbC5LZXlib2FyZEV2ZW50PFRNPlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBDYXJldFBvc2l0aW9uID0gY2FyZXRQb3NpdGlvbixcclxuICAgICAgICAgICAgICAgIFZhbHVlID0gdmFsdWVcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXk0XCIsKChJSW5wdXRDb21wb25lbnRDb250YWluZXIpQ29tcG9uZW50KS5PbktleVByZXNzKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8RnVuYzxJS2V5Ym9hcmRFdmVudCwgVGFzaz4+KFwia2V5NFwiKS5JbnZva2UobmV3RXYpOihUYXNrKW51bGw7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCU0LXQudGB0YLQstC40LUg0L/RgNC4INCy0LLQvtC00LUg0LfQvdCw0YfQtdC90LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXZcIj7QodC+0LHRi9GC0LjQtSDQvdCw0LbQsNGC0LjRjyDQvdCwINC60LvQsNCy0LjRiNGDINC60LvQsNCy0LjQsNGC0YPRgNGLPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgdm9pZCBPbktleVByZXNzKEJyaWRnZS5SZWFjdC5LZXlib2FyZEV2ZW50PEhUTUxJbnB1dEVsZW1lbnQ+IG5ld0V2KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgY2FyZXRQb3NpdGlvbiA9IG5ld0V2LkN1cnJlbnRUYXJnZXQuU2VsZWN0aW9uU3RhcnQ7XHJcblxyXG4gICAgICAgICAgICB2YXIgb25LZXlQcmVzc0V2ZW50ID0gKChJSW5wdXRDb21wb25lbnRDb250YWluZXIpQ29tcG9uZW50KS5PbktleVByZXNzO1xyXG4gICAgICAgICAgICBpZiAob25LZXlQcmVzc0V2ZW50ID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgb25LZXlQcmVzc0V2ZW50Lkludm9rZShuZXcgRUxNQS5Nb2RlbC5WaWV3TW9kZWwuS2V5Ym9hcmRFdmVudDxUTT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgVmFsdWUgPSBDb250ZXh0Lk1vZGVsLkFzPFRNPigpLFxyXG4gICAgICAgICAgICAgICAgQ2FyZXRQb3NpdGlvbiA9IGNhcmV0UG9zaXRpb25cclxuICAgICAgICAgICAgfSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCU0LXQudGB0YLQstC40LUg0L/RgNC4INGE0L7QutGD0YHQtVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXZcIj7QodC+0LHRi9GC0LjQtSDRhNC+0LrRg9GB0LA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIE9uRm9jdXMoQnJpZGdlLlJlYWN0LkZvY3VzRXZlbnQ8SFRNTElucHV0RWxlbWVudD4gZXYgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKGV2ICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNhcmV0UG9zaXRpb24gPSBldi5DdXJyZW50VGFyZ2V0LlNlbGVjdGlvblN0YXJ0O1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgb25Gb2N1c0V2ZW50ID0gKChJSW5wdXRDb21wb25lbnRDb250YWluZXIpQ29tcG9uZW50KS5PbkZvY3VzO1xyXG4gICAgICAgICAgICBpZiAob25Gb2N1c0V2ZW50ICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIG9uRm9jdXNFdmVudC5JbnZva2UobmV3IEVMTUEuTW9kZWwuVmlld01vZGVsLkZvY3VzRXZlbnQ8VE0+XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgQ2FyZXRQb3NpdGlvbiA9IGNhcmV0UG9zaXRpb24sXHJcbiAgICAgICAgICAgICAgICAgICAgVmFsdWUgPSBDb250ZXh0Lk1vZGVsLkFzPFRNPigpXHJcbiAgICAgICAgICAgICAgICB9KTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQlNC10LnRgdGC0LLQuNC1INC/0YDQuCDQv9C+0YLQtdGA0LUg0YTQvtC60YPRgdCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2YWx1ZVwiPtCX0L3QsNGH0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV2XCI+0KHQvtCx0YvRgtC40LUg0YTQvtC60YPRgdCwPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgdm9pZCBPbkJsdXIoVE0gdmFsdWUsIEJyaWRnZS5SZWFjdC5Gb2N1c0V2ZW50PEhUTUxJbnB1dEVsZW1lbnQ+IGV2ID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChldiAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBjYXJldFBvc2l0aW9uID0gZXYuQ3VycmVudFRhcmdldC5TZWxlY3Rpb25TdGFydDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIG5ld0V2ID0gbmV3IEVMTUEuTW9kZWwuVmlld01vZGVsLkNoYW5nZUV2ZW50PFRNPlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBDYXJldFBvc2l0aW9uID0gY2FyZXRQb3NpdGlvbixcclxuICAgICAgICAgICAgICAgIFZhbHVlID0gdmFsdWVcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXk1XCIsKChJSW5wdXRDb21wb25lbnRDb250YWluZXIpQ29tcG9uZW50KS5PbkJsdXIpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxGdW5jPElDaGFuZ2VFdmVudCwgVGFzaz4+KFwia2V5NVwiKS5JbnZva2UobmV3RXYpOihUYXNrKW51bGw7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlSW5wdXRDb250cm9sbGVyPFRNPiA6IEJhc2VJbnB1dENvbnRyb2xsZXI8VE0sIEJhc2VDb250ZXh0PFRNPj5cclxuICAgIHtcclxuICAgIH1cclxuXHJcbiAgICBwdWJsaWMgY2xhc3MgQmFzZUlucHV0Q29udHJvbGxlciA6IEJhc2VJbnB1dENvbnRyb2xsZXI8b2JqZWN0LCBJQmFzZUNvbnRleHQ+XHJcbiAgICB7XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkV4dGVuc2lvblBvaW50cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLklvYy5BYnN0cmFjdDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQmNC90YLQtdGA0YTQtdC50YEg0YDQtdCw0LrRgi3RgNC10L3QtNC10YDQtdGA0LAg0LTQu9GPINC60L7QvNC/0L7QvdC10L3RgtC+0LJcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbRXh0ZW5zaW9uUG9pbnRdXHJcbiAgICBwdWJsaWMgaW50ZXJmYWNlIElSZWFjdFJlbmRlcmVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQntGC0YDQuNGB0L7QstCw0YLRjCDQutC+0LzQv9C+0L3QtdC90YJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInR5cGVDb21wb25lbnRcIj7QotC40L8g0LrQvtC80L/QvtC90LXQvdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm93bmVyXCI+Vmlld01vZGVsINGA0L7QtNC40YLQtdC70YzRgdC60L7Qs9C+INC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJpbnB1dHNcIj7QktGF0L7QtNC90YvQtSDQt9C90LDRh9C10L3QuNGPINC00LvRjyDQutC+0LzQv9C+0L3QtdC90YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBJUmVuZGVyQ29udGVudCBSZW5kZXIoVHlwZSB0eXBlQ29tcG9uZW50LCBJVmlld01vZGVsIG93bmVyLCBJSW5wdXRzIGlucHV0cyA9IG51bGwpO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCc0L7QttC90L4g0LvQuCDQuNGB0L/QvtC70YzQt9C+0LLQsNGC0Ywg0YDQtdC90LTQtdGAXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ0eXBlQ29tcG9uZW50XCI+0YLQuNC/INC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIGJvb2wgQ2FuUmVuZGVyKFR5cGUgdHlwZUNvbXBvbmVudCk7XHJcbiAgICB9XHJcblxyXG4gICAgW0NvbXBvbmVudChPcmRlciA9IGludC5NYXhWYWx1ZSldXHJcbiAgICBwdWJsaWMgY2xhc3MgQmFzZVJlYWN0UmVuZGVyZXIgOiBJUmVhY3RSZW5kZXJlclxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgSUVudW1lcmFibGU8SVdyYXBDb21wb25lbnQ+IHdyYXBDb21wb25lbnRzO1xyXG5wcml2YXRlIElFbnVtZXJhYmxlPElXcmFwQ29tcG9uZW50PiBXcmFwQ29tcG9uZW50c1xyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gd3JhcENvbXBvbmVudHMgPz8gKHdyYXBDb21wb25lbnRzID0gY3VycmVudFNjb3BlLlJlc29sdmU8SUVudW1lcmFibGU8SVdyYXBDb21wb25lbnQ+PigpKTtcclxuICAgIH1cclxufVxyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImN1cnJlbnRTY29wZVwiPtCi0LXQutGD0YnQuNC5IFNjb3BlPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgQmFzZVJlYWN0UmVuZGVyZXIoSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5jdXJyZW50U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBJUmVuZGVyQ29udGVudCBSZW5kZXIoVHlwZSB0eXBlQ29tcG9uZW50LCBJVmlld01vZGVsIG93bmVyLCBJSW5wdXRzIGlucHV0cyA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgbW9kZWwgPSBCYXNlSW5pdFZpZXdNb2RlbCh0eXBlQ29tcG9uZW50LCBvd25lciwgaW5wdXRzKTtcclxuICAgICAgICAgICAgcmV0dXJuIENyZWF0ZUNvbXBvbmVudCh0eXBlQ29tcG9uZW50LCBtb2RlbCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBib29sIENhblJlbmRlcihUeXBlIHR5cGVDb21wb25lbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gdHlwZW9mKElSZWFjdENvbXBvbmVudCkuSXNBc3NpZ25hYmxlRnJvbSh0eXBlQ29tcG9uZW50KTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBJUmVuZGVyQ29udGVudCBDcmVhdGVDb21wb25lbnQoVHlwZSB0eXBlQ29tcG9uZW50LCBJSW5wdXRNb2RlbCBpbnB1dE1vZGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGNvbXBvbmVudCA9IChJUmVuZGVyQ29udGVudClBY3RpdmF0b3IuQ3JlYXRlSW5zdGFuY2UodHlwZUNvbXBvbmVudCwgaW5wdXRNb2RlbCk7XHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciB3cmFwQ29tcG9uZW50IGluIFdyYXBDb21wb25lbnRzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBjb21wb25lbnQgPSB3cmFwQ29tcG9uZW50LldyYXAoY29tcG9uZW50KTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICByZXR1cm4gY29tcG9uZW50O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgSVJlYWN0SW5wdXRNb2RlbCBCYXNlSW5pdFZpZXdNb2RlbChUeXBlIHR5cGVDb21wb25lbnQsIElWaWV3TW9kZWwgb3duZXIsIElJbnB1dHMgaW5wdXRzID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dE1vZGVsID0gQ3JlYXRlSW5wdXRNb2RlbCh0eXBlQ29tcG9uZW50KTtcclxuICAgICAgICAgICAgaW5wdXRNb2RlbC5LZXkgPSAoaW5wdXRzIT1udWxsP2lucHV0cy5LZXk6KHN0cmluZyludWxsKSA/PyB0eXBlQ29tcG9uZW50Lk5hbWU7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuSW5wdXRzID0gaW5wdXRzO1xyXG4gICAgICAgICAgICBpbnB1dE1vZGVsLk93bmVyID0gb3duZXI7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuUm9vdFNjb3BlID0gY3VycmVudFNjb3BlO1xyXG4gICAgICAgICAgICBpbnB1dE1vZGVsLkRhdGFTdGFjayA9IG93bmVyIT1udWxsJiZnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5MVwiLG93bmVyLkdldER5bmFtaWNEYXRhKCkpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxFTE1BLk1vZGVsLklEYXRhU3RhY2s+KFwia2V5MVwiKS5DbG9uZSgpOihFTE1BLk1vZGVsLklEYXRhU3RhY2spbnVsbDtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBpbnB1dE1vZGVsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHZpcnR1YWwgSVJlYWN0SW5wdXRNb2RlbCBDcmVhdGVJbnB1dE1vZGVsKFR5cGUgdHlwZUNvbXBvbmVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dFR5cGUgPSBHZXRJbnB1dHNUeXBlKHR5cGVDb21wb25lbnQpO1xyXG4gICAgICAgICAgICB2YXIgZ2VuZXJpY1R5cGUgPSB0eXBlb2YoSW5wdXRNb2RlbDw+KS5NYWtlR2VuZXJpY1R5cGUobmV3W10geyBpbnB1dFR5cGUgfSk7XHJcbiAgICAgICAgICAgIHJldHVybiAoSVJlYWN0SW5wdXRNb2RlbClBY3RpdmF0b3IuQ3JlYXRlSW5zdGFuY2UoZ2VuZXJpY1R5cGUpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHN0YXRpYyBUeXBlIEdldElucHV0c1R5cGUoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHR5cGVJbnB1dHMgPSBHZXRJbnB1dHNUeXBlcyh0eXBlQ29tcG9uZW50KTtcclxuICAgICAgICAgICAgLy/QldGB0LvQuCDRgyDQutC+0LzQv9C+0L3QtdC90YLQsCAxINCw0YDQs9GD0LzQtdC90YIsINGC0L4g0Y3RgtC+INC60L7QvNC/0L7QvdC10L3RgiDRgSDQsdCw0LfQvtCy0YvQvCDQuNC90L/Rg9GC0L7QvFxyXG4gICAgICAgICAgICAvL9CV0YHQu9C4INGDINC60L7QvNC/0L7QvdC10L3RgtCwINCx0L7Qu9GM0YjQtSDQvtC00L3QvtCz0L4g0LDRgNCz0YPQvNC10L3RgtCwLCDRgtC+INC/0LXRgNCy0YvQuSDQsNGA0LPRg9C80LXQvdGCINGN0YLQviDRgtC40L8g0LjQvdC/0YPRgtCwXHJcbiAgICAgICAgICAgIHJldHVybiB0eXBlSW5wdXRzLkxlbmd0aCA9PSAxID8gdHlwZW9mKElucHV0cykgOiB0eXBlSW5wdXRzWzBdO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBzdGF0aWMgVHlwZVtdIEdldElucHV0c1R5cGVzKFR5cGUgdHlwZUNvbXBvbmVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8v0YDQtdC60YPRgNGB0LjQstC90YvQuSDQv9C+0LjRgdC6INGC0LjQv9CwINCy0YXQvtC00L3QvtCz0L4g0LfQvdCw0YfQtdC90LjRjyDQtNC70Y8gdHlwZUNvbXBvbmVudCwg0LTQvtC70LbQvdC+INCx0YvRgtGMINCy0YHQtdCz0LTQsCDRgi7Qui4g0LrQvtC80L/QvtC90LXQvdGCINC90LDRgdC70LXQtNGD0LXRgtGB0Y8g0L7RgiBQdXJlQ29tcG9uZW50PHByb3BzPlxyXG4gICAgICAgICAgICByZXR1cm4gdHlwZUNvbXBvbmVudC5CYXNlVHlwZS5Jc0dlbmVyaWNUeXBlID8gdHlwZUNvbXBvbmVudC5CYXNlVHlwZS5HZXRHZW5lcmljQXJndW1lbnRzKCkgOiBHZXRJbnB1dHNUeXBlcyh0eXBlQ29tcG9uZW50LkJhc2VUeXBlKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcbiAgICBcclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlUmVhY3RSZW5kZXJlcjxUQ29tcG9uZW50LCBUSW5wdXRzLCBUQ29udGV4dD4gOiBCYXNlUmVhY3RSZW5kZXJlclxyXG4gICAgICAgIHdoZXJlIFRDb21wb25lbnQgOiBCYXNlUmVhY3RDb21wb25lbnQ8VElucHV0cywgVENvbnRleHQ+XHJcbiAgICAgICAgd2hlcmUgVElucHV0cyA6IElJbnB1dHNcclxuICAgICAgICB3aGVyZSBUQ29udGV4dCA6IElDb250ZXh0XHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHJvdGVjdGVkIEJhc2VSZWFjdFJlbmRlcmVyKElMaWZldGltZVNjb3BlIGN1cnJlbnRTY29wZSkgOiBiYXNlKGN1cnJlbnRTY29wZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgYm9vbCBDYW5SZW5kZXIoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHR5cGVDb21wb25lbnQgPT0gdHlwZW9mKFRDb21wb25lbnQpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIElSZW5kZXJDb250ZW50IFJlbmRlcihUeXBlIHR5cGVDb21wb25lbnQsIElWaWV3TW9kZWwgb3duZXIsIElJbnB1dHMgaW5wdXRzID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBSZW5kZXIob3duZXIsIChUSW5wdXRzKWlucHV0cyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBJUmVuZGVyQ29udGVudCBSZW5kZXIoSVZpZXdNb2RlbCBvd25lciwgVElucHV0cyBpbnB1dHMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdHlwZUNvbXBvbmVudCA9IHR5cGVvZihUQ29tcG9uZW50KTtcclxuICAgICAgICAgICAgdmFyIG5ld0lucHV0cyA9IEluaXRWaWV3TW9kZWwoaW5wdXRzKTtcclxuICAgICAgICAgICAgdmFyIG1vZGVsID0gQmFzZUluaXRWaWV3TW9kZWwodHlwZUNvbXBvbmVudCwgb3duZXIsIG5ld0lucHV0cyk7XHJcbiAgICAgICAgICAgIHJldHVybiBDcmVhdGVDb21wb25lbnQodHlwZUNvbXBvbmVudCwgbW9kZWwpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIElSZWFjdElucHV0TW9kZWw8VElucHV0cz4gQ3JlYXRlSW5wdXRNb2RlbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgZ2VuZXJpY1R5cGUgPSB0eXBlb2YoSW5wdXRNb2RlbDw+KS5NYWtlR2VuZXJpY1R5cGUobmV3W10geyB0eXBlb2YoVElucHV0cykgfSk7XHJcbiAgICAgICAgICAgIHJldHVybiAoSW5wdXRNb2RlbDxUSW5wdXRzPilBY3RpdmF0b3IuQ3JlYXRlSW5zdGFuY2UoZ2VuZXJpY1R5cGUpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHZpcnR1YWwgVElucHV0cyBJbml0Vmlld01vZGVsKFRJbnB1dHMgaW5wdXRzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIGlucHV0cztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBCcmlkZ2UuUmVhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0L7QtSDQv9C+0LvRjNC30L7QstCw0YLQtdC70YzRgdC60L7QtSDQv9GA0LXQtNGB0YLQsNCy0LvQtdC90LjQtSwg0LjRgdC/0L7Qu9GM0LfRg9C10YLRgdGPINGC0L7Qu9GM0LrQviDQtNC70Y8g0LDQstGC0L7QutC+0LzQv9C70LjRgtCwINCyINC00LjQt9Cw0LnQvS3QvNC+0LTQtVxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udGV4dFwiPtCi0LjQvyDQutC+0L3RgtC10LrRgdGC0LA8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUU2VydmVyQ29udHJvbGxlclwiPtCi0LjQvyDRgdC10YDQstC10YDQvdC+0LPQviDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZUN1c3RvbVZpZXc8VENvbnRleHQsIFRDb250cm9sbGVyPiA6IElDdXN0b21WaWV3XHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgSUNvbXBvbmVudFZpZXdJdGVtVmlld01vZGVsIHZpZXdNb2RlbDtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3TW9kZWxcIj48L3BhcmFtPlxyXG4gICAgICAgIHByb3RlY3RlZCBCYXNlQ3VzdG9tVmlldyhJQ29tcG9uZW50Vmlld0l0ZW1WaWV3TW9kZWwgdmlld01vZGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C/0L7Qu9C90LjRgtGMINC80LXRgtC+0LQg0LrQvtC90YLRgNC+0LvQu9C10YDQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHJvdGVjdGVkIEFjdGlvbjxBY3Rpb248VENvbnRyb2xsZXI+PiBEaXNwYXRjaCB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0L/QvtC70L3QuNGC0Ywg0LDRgdC40L3RhdGA0L7QvdC90YvQuSDQvNC10YLQvtC0INC60L7QvdGC0YDQvtC70LvQtdGA0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBGdW5jPEZ1bmM8VENvbnRyb2xsZXIsIFRhc2s+LCBUYXNrPiBEaXNwYXRjaEFzeW5jIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCe0YLRgNC40YHQvtCy0LDRgtGMINGB0LvQvtGCXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ1aWRcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIFJlYWN0RWxlbWVudCBHZXRTbG90Q29udGVudChHdWlkIHVpZCA9IGRlZmF1bHQoR3VpZCkpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YLQtdC60YHRglxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHJvdGVjdGVkIFRDb250ZXh0IENvbnRleHQgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YLRgNC+0LvQu9C10YBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBUQ29udHJvbGxlciBDb250cm9sbGVyIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgYWJzdHJhY3QgUmVhY3RFbGVtZW50IFJlbmRlcigpO1xyXG4gICAgfVxyXG5cclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0L7QtSDQv9C+0LvRjNC30L7QstCw0YLQtdC70YzRgdC60L7QtSDQv9GA0LXQtNGB0YLQsNCy0LvQtdC90LjQtVxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udHJvbGxlclwiPjwvdHlwZXBhcmFtPlxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIEJhc2VDdXN0b21WaWV3PFRDb250cm9sbGVyPiA6IElDdXN0b21WaWV3XHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSBJQ29tcG9uZW50Vmlld0l0ZW1WaWV3TW9kZWwgdmlld01vZGVsO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZpZXdNb2RlbFwiPjwvcGFyYW0+XHJcbiAgICAgICAgcHJvdGVjdGVkIEJhc2VDdXN0b21WaWV3KElDb21wb25lbnRWaWV3SXRlbVZpZXdNb2RlbCB2aWV3TW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICAvKkBcclxuICAgICAgICAgICAgdGhpcy52aWV3TW9kZWwgPSB2aWV3TW9kZWw7XHJcbiAgICAgICAgICAgIHRoaXMuQ29udGV4dCA9IHZpZXdNb2RlbC5Db250ZXh0O1xyXG4gICAgICAgICAgICB0aGlzLkNvbnRyb2xsZXIgPSB2aWV3TW9kZWwuQ29udHJvbGxlcjtcclxuICAgICAgICAgICAgKi9cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C/0L7Qu9C90LjRgtGMINC80LXRgtC+0LQg0LrQvtC90YLRgNC+0LvQu9C10YDQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYXJnXCI+PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgdm9pZCBEaXNwYXRjaChBY3Rpb248VENvbnRyb2xsZXI+IGFyZylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8qQFxyXG4gICAgICAgICAgICAgdGhpcy52aWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlci5EaXNwYXRjaCQyKGFyZyk7XHJcbiAgICAgICAgICAgICAqL1xyXG4gICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCS0YvQv9C+0LvQvdC40YLRjCDQsNGB0LjQvdGF0YDQvtC90L3Ri9C5INC80LXRgtC+0LQg0LrQvtC90YLRgNC+0LvQu9C10YDQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYXJnXCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBUYXNrIERpc3BhdGNoQXN5bmMoRnVuYzxUQ29udHJvbGxlciwgVGFzaz4gYXJnKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgICByZXR1cm4gdGhpcy52aWV3TW9kZWwuQ29tcG9uZW50RGlzcGF0Y2hlci5EaXNwYXRjaCQzKGFyZyk7XHJcbiAgICAgICAgICAgICAqL1xyXG4gICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J7RgtGA0LjRgdC+0LLQsNGC0Ywg0YHQu9C+0YJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInVpZFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwcm90ZWN0ZWQgUmVhY3RFbGVtZW50IEdldFNsb3RDb250ZW50KEd1aWQgdWlkID0gZGVmYXVsdChHdWlkKSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiAoKElSb290Q29tcG9uZW50KXZpZXdNb2RlbCkuR2V0U2xvdENvbnRlbnQodWlkKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YLQtdC60YHRglxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHJvdGVjdGVkIElDb250ZXh0IENvbnRleHQgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YLRgNC+0LvQu9C10YBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBUQ29udHJvbGxlciBDb250cm9sbGVyIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgYWJzdHJhY3QgUmVhY3RFbGVtZW50IFJlbmRlcigpO1xyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgIHB1YmxpYyBjbGFzcyBDb250ZXh0Q3JlYXRpb25QYXJhbWV0ZXJzIDogSUNvbnRleHRDcmVhdGlvblBhcmFtZXRlcnNcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZpZXdNb2RlbFwiPtCc0L7QtNC10LvRjDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiaW5uZXJTdGFja1wiPtCS0L3Rg9GC0YDQtdC90L3QuNC5INGB0YLQtdC6INC00L7Qv9C+0LvQvdC40YLQtdC70YzQvdGL0YUg0LTQsNC90L3Ri9GFINC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJvdXRlclN0YWNrXCI+0JLQvdC10YjQvdC40Lkg0YHRgtC10Log0LTQvtC/0L7Qu9C90LjRgtC10LvRjNC90YvRhSDQtNCw0L3QvdGL0YUg0LrQvtC80L/QvtC90LXQvdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGFkYXRhXCI+0JzQtdGC0LDQtNCw0L3QvdGL0LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGFkYXRhVWlkXCI+0KPQvdC40LrQsNC70YzQvdGL0Lkg0LjQtNC10L3RgtGE0LjQutCw0YLQvtGAINC80LXRgtCw0LTQsNC90L3Ri9GFPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXRhZGF0YVR5cGVVaWRcIj7Qo9C90LjQutCw0LvRjNC90YvQuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRgtC40L/QsCDQvNC10YLQsNC00LDQvdC90YvRhTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWV0YWRhdGFNb2R1bGVVaWRcIj7Qo9C90LjQutCw0LvRjNC90YvQuSDQuNC00LXQvdGC0YTQuNC60LDRgtC+0YAg0LzQvtC00YPQu9GPPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycyhcclxuICAgICAgICAgICAgSVZpZXdNb2RlbCB2aWV3TW9kZWwsXHJcbiAgICAgICAgICAgIElEYXRhU3RhY2sgaW5uZXJTdGFjayxcclxuICAgICAgICAgICAgSURhdGFTdGFjayBvdXRlclN0YWNrLFxyXG4gICAgICAgICAgICBDbGFzc01ldGFkYXRhIG1ldGFkYXRhLFxyXG4gICAgICAgICAgICBHdWlkIG1ldGFkYXRhVWlkLFxyXG4gICAgICAgICAgICBHdWlkIG1ldGFkYXRhVHlwZVVpZCxcclxuICAgICAgICAgICAgR3VpZCBtZXRhZGF0YU1vZHVsZVVpZFxyXG4gICAgICAgIClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFZpZXdNb2RlbCA9IHZpZXdNb2RlbDtcclxuICAgICAgICAgICAgSW5uZXJTdGFjayA9IGlubmVyU3RhY2s7XHJcbiAgICAgICAgICAgIE91dGVyU3RhY2sgPSBvdXRlclN0YWNrO1xyXG4gICAgICAgICAgICBNZXRhZGF0YSA9IG1ldGFkYXRhO1xyXG4gICAgICAgICAgICBNZXRhZGF0YVVpZCA9IG1ldGFkYXRhVWlkO1xyXG4gICAgICAgICAgICBNZXRhZGF0YVR5cGVVaWQgPSBtZXRhZGF0YVR5cGVVaWQ7XHJcbiAgICAgICAgICAgIE1ldGFkYXRhTW9kdWxlVWlkID0gbWV0YWRhdGFNb2R1bGVVaWQ7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgSVZpZXdNb2RlbCBWaWV3TW9kZWwgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJRGF0YVN0YWNrIElubmVyU3RhY2sgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJRGF0YVN0YWNrIE91dGVyU3RhY2sgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBDbGFzc01ldGFkYXRhIE1ldGFkYXRhIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgR3VpZCBNZXRhZGF0YVVpZCB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEd1aWQgTWV0YWRhdGFUeXBlVWlkIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgR3VpZCBNZXRhZGF0YU1vZHVsZVVpZCB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuICAgIH1cclxufSIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLk1ldGFkYXRhO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JDQsdGB0YLRgNCw0LrRgtC90YvQuSDQutC70LDRgdGBINC00LvRjyDQvNC+0LTQtdC70Lgg0YEg0LjQvdGC0LXRgNGE0LXQudGB0L7QvCBJSGlkZUVtcHR5Vmlld0l0ZW1cclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBhYnN0cmFjdCBjbGFzcyBIaWRlRW1wdHlNb2RlbCA6IElIaWRlRW1wdHlNb2RlbFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsIG93bmVyO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgRnVuYzxib29sPiBpc0hpZGRlbjtcclxuICAgICAgICBwcml2YXRlIGJvb2wgY3VycmVudEhpZGVFbXB0eTtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBjdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJvd25lclwiPtCa0L7QvdGC0LXQudC90LXRgC3QstC70LDQtNC10LvQtdGGPC9wYXJhbT5cclxuICAgICAgICBwcm90ZWN0ZWQgSGlkZUVtcHR5TW9kZWwoSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsIG93bmVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5vd25lciA9IG93bmVyO1xyXG5cclxuICAgICAgICAgICAgVmlld01vZGVsLkRlZmluZVByb3BlcnR5KHRoaXMsIG5ldyBQcm9wZXJ0eUluZm9FeHByZXNzaW9uXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIE9iamVjdEV4cHJlc3Npb24gPSBcImN1cnJlbnRIaWRlRW1wdHlcIixcclxuICAgICAgICAgICAgICAgIEV4cHJlc3Npb25Gb3JTZXJpYWxpemUgPSBcImN1cnJlbnRIaWRlRW1wdHlcIiAgICAgICAgICAgIH0pO1xyXG5cclxuICAgICAgICAgICAgaXNIaWRkZW4gPSAoKSA9PiBjdXJyZW50SGlkZUVtcHR5O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvRg9GH0LjRgtGMINC30L3QsNGH0LXQvdC40LUg0YHQutGA0YvRgtC40Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC60YDRi9GC0LjQtSDQutC+0LzQv9C+0L3QtdC90YLQsDwvcmV0dXJucz5cclxuICAgICAgICBwcm90ZWN0ZWQgYWJzdHJhY3QgYm9vbCBHZXRIaWRkZW5WYWx1ZSgpO1xyXG4vLy8gPGluaGVyaXRkb2MvPlxyXG5wdWJsaWMgYm9vbCBJc0VtcHR5XHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBjdXJyZW50SGlkZUVtcHR5O1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCB2b2lkIEluaXQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgY3VycmVudEhpZGVFbXB0eSA9IEdldEhpZGRlblZhbHVlKCk7XHJcblxyXG4gICAgICAgICAgICBGdW5jPGJvb2w+IGdldEhpZGRlblZhbCA9ICgpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBHZXRIaWRkZW5WYWx1ZSgpO1xyXG4gICAgICAgICAgICB9O1xyXG5cclxuICAgICAgICAgICAgLy8gIFRPRE8gRUxNQTQtNTc3NyDQn9C10YDQtdGA0LDQsdC+0YLQsNGC0YwganMt0LLRgdGC0LDQstC60LhcclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIGNvbnN0IHJlYWN0aW9uID0gbW9ieC5yZWFjdGlvbihcclxuICAgICAgICAgICAgICAgIGdldEhpZGRlblZhbCxcclxuICAgICAgICAgICAgICAgIChpc0hpZGRlbikgPT4geyB0aGlzLmN1cnJlbnRIaWRlRW1wdHkgPSBpc0hpZGRlbjsgfVxyXG4gICAgICAgICAgICAgKTtcclxuICAgICAgICAgICAgKi9cclxuXHJcbiAgICAgICAgICAgIGlmIChvd25lciAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBvd25lci5BZGRJc0hpZGRlbigoRnVuYzxib29sPilpc0hpZGRlbik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgdm9pZCBEZXN0cm95KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChvd25lciAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBvd25lci5SZW1vdmVJc0hpZGRlbigoRnVuYzxib29sPilpc0hpZGRlbik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgcHVibGljIGNsYXNzIEhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyTW9kZWwgOiBJSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXJNb2RlbFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgVmlld01vZGVsIG1vZGVsO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgRnVuYzxJVmlld0l0ZW0+IGdldFZpZXdJdGVtRnVuYztcclxuICAgICAgICBwcml2YXRlIElEaWN0aW9uYXJ5PElWaWV3SXRlbSwgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsPiBoaWRlRW1wdHlNb2RlbHM7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gY3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIEhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyTW9kZWwoVmlld01vZGVsIHZpZXdNb2RlbCwgRnVuYzxJVmlld0l0ZW0+IGdldFZpZXdJdGVtRnVuYylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGhpZGVFbXB0eU1vZGVscyA9IG5ldyBEaWN0aW9uYXJ5PElWaWV3SXRlbSwgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsPigpO1xyXG4gICAgICAgICAgICBtb2RlbCA9IHZpZXdNb2RlbDtcclxuICAgICAgICAgICAgdGhpcy5nZXRWaWV3SXRlbUZ1bmMgPSBnZXRWaWV3SXRlbUZ1bmM7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEFkZEhpZGVFbXB0eShJVmlld0l0ZW0gdmlld0l0ZW0sIElIaWRlRW1wdHlDb250YWluZXJNb2RlbCBoaWRlRW1wdHlNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChoaWRlRW1wdHlNb2RlbHMgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgaGlkZUVtcHR5TW9kZWxzLkFkZCh2aWV3SXRlbSwgaGlkZUVtcHR5TW9kZWwpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJlbW92ZUhpZGVFbXB0eShJVmlld0l0ZW0gdmlld0l0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoaGlkZUVtcHR5TW9kZWxzICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGhpZGVFbXB0eU1vZGVscy5SZW1vdmUodmlld0l0ZW0pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBJSGlkZUVtcHR5Q29udGFpbmVyTW9kZWwgRmluZE93bmVyKElWaWV3SXRlbSB2aWV3SXRlbSlcclxuICAgICAgICB7XHJcblZpZXdJdGVtIGl0ZW07ICAgICAgICAgICAgaWYgKChpdGVtID0gdmlld0l0ZW0gYXMgVmlld0l0ZW0pICE9IG51bGwmJiBpdGVtLlBhcmVudCAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbklIaWRlRW1wdHlDb250YWluZXJNb2RlbCBtb2RlbDtcbiAgICAgICAgICAgICAgICBpZiAoaGlkZUVtcHR5TW9kZWxzICE9IG51bGwgJiYgaGlkZUVtcHR5TW9kZWxzLlRyeUdldFZhbHVlKGl0ZW0uUGFyZW50LCBvdXQgbW9kZWwpKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBtb2RlbDtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBlbHNlIHtcclxuICAgIElIaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lciBoaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lcjtcclxuICAgIGlmICgoaGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXIgPSBtb2RlbC5SZW5kZXJPd25lciBhcyBJSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXIpICE9IG51bGwpXHJcbiAgICB7XHJcbiAgICAgICAgdmFyIGN1cnJlbnRWaWV3SXRlbSA9IGdldFZpZXdJdGVtRnVuYygpO1xyXG4gICAgICAgIHJldHVybiBoaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lci5IaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lci5GaW5kSGlkZUVtcHR5KGN1cnJlbnRWaWV3SXRlbSk7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIERlc3Ryb3koKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaGlkZUVtcHR5TW9kZWxzID0gbnVsbDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIGJvb2wgSXNIaWRlRW1wdHkoSVZpZXdJdGVtIHZpZXdJdGVtKVxyXG4gICAgICAgIHtcclxuSUhpZGVFbXB0eVZpZXdJdGVtIGhpZGVFbXB0eVZpZXdJdGVtOyAgICAgICAgICAgIGlmICgoaGlkZUVtcHR5Vmlld0l0ZW0gPSB2aWV3SXRlbSBhcyBJSGlkZUVtcHR5Vmlld0l0ZW0pICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChoaWRlRW1wdHlWaWV3SXRlbS5IaWRlRW1wdHkgPT0gSGlkZUVtcHR5RW51bS5IaWRlRW1wdHkpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBlbHNlIHtcclxuICAgIFZpZXdJdGVtIGl0ZW07XHJcbiAgICBpZiAoaGlkZUVtcHR5Vmlld0l0ZW0uSGlkZUVtcHR5ID09IEhpZGVFbXB0eUVudW0uSW5oZXJpdCAmJiAoaXRlbSA9IHZpZXdJdGVtIGFzIFZpZXdJdGVtKSAhPSBudWxsKVxyXG4gICAge1xyXG4gICAgICAgIGlmIChpdGVtLlBhcmVudCAhPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIElzSGlkZUVtcHR5KGl0ZW0uUGFyZW50KTtcclxuICAgICAgICB9XHJcbiAgICAgICAgZWxzZVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgSUhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyIGhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyO1xyXG4gICAgICAgICAgICBpZiAoKGhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyID0gbW9kZWwuUmVuZGVyT3duZXIgYXMgSUhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgb3duZXIgPSBoaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lci5IaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lcjtcclxuICAgICAgICAgICAgICAgIHZhciBwYXJlbnQgPSBnZXRWaWV3SXRlbUZ1bmMoKTtcclxuICAgICAgICAgICAgICAgIGlmIChwYXJlbnQgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gb3duZXIuSXNIaWRlRW1wdHkocGFyZW50KTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuICAgIH1cclxufSAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBmYWxzZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIElIaWRlRW1wdHlDb250YWluZXJNb2RlbCBGaW5kSGlkZUVtcHR5KElWaWV3SXRlbSB2aWV3SXRlbSlcclxuICAgICAgICB7XHJcbklIaWRlRW1wdHlDb250YWluZXJNb2RlbCBtb2RlbDtcbiAgICAgICAgICAgIGlmIChoaWRlRW1wdHlNb2RlbHMuVHJ5R2V0VmFsdWUodmlld0l0ZW0sIG91dCBtb2RlbCkpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBtb2RlbDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIEZpbmRPd25lcih2aWV3SXRlbSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0J3QsNGB0YLRgNC+0LnQutC4INC60L7QvNC/0L7QvdC10L3RgtCwINC40L3Qv9GD0YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBjbGFzcyBJbnB1dENvbXBvbmVudENvbnRhaW5lciA6IENvbXBvbmVudENvbnRhaW5lciwgSUlucHV0Q29tcG9uZW50Q29udGFpbmVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3TW9kZWxcIj48L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBJbnB1dENvbXBvbmVudENvbnRhaW5lcihJVmlld01vZGVsIHZpZXdNb2RlbCkgOiBiYXNlKHZpZXdNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG4vLy8gPGluaGVyaXRkb2MgLz5cclxucHVibGljIEZ1bmM8SUtleWJvYXJkRXZlbnQsIFRhc2s+IE9uS2V5UHJlc3Ncclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuICgoQmFzZUlucHV0Vmlld01vZGVsKVZpZXdNb2RlbCkuT25LZXlQcmVzcztcclxuICAgIH1cclxufS8vLyA8aW5oZXJpdGRvYyAvPlxyXG5wdWJsaWMgRnVuYzxJRm9jdXNFdmVudCwgVGFzaz4gT25Gb2N1c1xyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gKChCYXNlSW5wdXRWaWV3TW9kZWwpVmlld01vZGVsKS5PbkZvY3VzO1xyXG4gICAgfVxyXG59Ly8vIDxpbmhlcml0ZG9jIC8+XHJcbnB1YmxpYyBGdW5jPElDaGFuZ2VFdmVudCwgVGFzaz4gT25CbHVyXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoKEJhc2VJbnB1dFZpZXdNb2RlbClWaWV3TW9kZWwpLk9uQmx1cjtcclxuICAgIH1cclxufSAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JzQvtC00LXQu9GMINC/0L7QutCw0LfQsCDQv9GD0YHRgtGL0YUg0LrQvtC80L/QvtC90LXQvdGC0L7QslxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBTaG93RW1wdHlNb2RlbCA6IElIaWRlRW1wdHlNb2RlbFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsIG93bmVyO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgRnVuYzxib29sPiBpc0hpZGRlbjtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBjdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJvd25lclwiPtCa0L7QvdGC0LXQudC90LXRgC3QstC70LDQtNC10LvQtdGGINC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgU2hvd0VtcHR5TW9kZWwoSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsIG93bmVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaXNIaWRkZW4gPSAoKSA9PiBmYWxzZTtcclxuICAgICAgICAgICAgdGhpcy5vd25lciA9IG93bmVyO1xyXG4gICAgICAgIH1cclxuLy8vIDxpbmhlcml0ZG9jLz5cclxucHVibGljIGJvb2wgSXNFbXB0eVxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gZmFsc2U7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEluaXQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKG93bmVyICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIG93bmVyLkFkZElzSGlkZGVuKChGdW5jPGJvb2w+KWlzSGlkZGVuKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBEZXN0cm95KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChvd25lciAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBvd25lci5SZW1vdmVJc0hpZGRlbigoRnVuYzxib29sPilpc0hpZGRlbik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db2xsZWN0aW9ucztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZhbGlkYXRpb247XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQnNC+0LTQtdC70Ywg0LLQsNC70LjQtNCw0YbQuNC4XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIGNsYXNzIFZhbGlkYXRpb25Nb2RlbCA6IElWaWV3TW9kZWxWYWxpZGF0aW9uTW9kZWxcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElWaWV3TW9kZWwgdmlld01vZGVsO1xyXG4gICAgICAgIHByaXZhdGUgYm9vbCBpc1ZhbGlkO1xyXG4gICAgICAgIHByaXZhdGUgSVJlYWN0aXZlRGljdGlvbmFyeTxGdW5jPFZhbGlkYXRpb25SZXN1bHQ+LCBWYWxpZGF0aW9uUmVzdWx0PiBsaXN0O1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIGN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZpZXdNb2RlbFwiPtCc0L7QtNC10LvRjCDQutC+0LzQv9C+0L3QtdC90YLQsDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFZhbGlkYXRpb25Nb2RlbChJVmlld01vZGVsIHZpZXdNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMudmlld01vZGVsID0gdmlld01vZGVsO1xyXG5cclxuICAgICAgICAgICAgbGlzdCA9IG5ldyBSZWFjdGl2ZURpY3Rpb25hcnk8RnVuYzxWYWxpZGF0aW9uUmVzdWx0PiwgVmFsaWRhdGlvblJlc3VsdD4oKTtcclxuXHJcbiAgICAgICAgICAgIFZpZXdNb2RlbC5EZWZpbmVQcm9wZXJ0eSh0aGlzLCBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBPYmplY3RFeHByZXNzaW9uID0gXCJpc1ZhbGlkXCIsXHJcbiAgICAgICAgICAgICAgICBFeHByZXNzaW9uRm9yU2VyaWFsaXplID0gXCJpc1ZhbGlkXCIgICAgICAgICAgICB9KTtcclxuXHJcbiAgICAgICAgICAgIEZ1bmM8Ym9vbD4gZ2V0RXJyb3JWYWxpZGF0aW9uID0gKCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFN5c3RlbS5MaW5xLkVudW1lcmFibGUuQWxsPFZhbGlkYXRpb25SZXN1bHQ+KGxpc3QuVmFsdWVzLChGdW5jPFZhbGlkYXRpb25SZXN1bHQsYm9vbD4pKHYgPT4gdi5Jc1ZhbGlkICE9IFZhbHVlUmVzdWx0LkVycm9yKSk7XHJcbiAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgIEFjdGlvbjxib29sPiBzZXRFcnJvclZhbGlkYXRpb24gPSAocmVzdWx0KSA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpc1ZhbGlkID0gcmVzdWx0O1xyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAvLyAgVE9ETyBFTE1BNC01Nzc3INCf0LXRgNC10YDQsNCx0L7RgtCw0YLRjCBqcy3QstGB0YLQsNCy0LrQuFxyXG4gICAgICAgICAgICAvKkBcclxuICAgICAgICAgICAgY29uc3QgcmVhY3Rpb24gPSBtb2J4LnJlYWN0aW9uKFxyXG4gICAgICAgICAgICAgICAgZ2V0RXJyb3JWYWxpZGF0aW9uLFxyXG4gICAgICAgICAgICAgICAgc2V0RXJyb3JWYWxpZGF0aW9uXHJcbiAgICAgICAgICAgICk7XHJcbiAgICAgICAgICAgIGlmICghdGhpcy5yZWFjdGlvbnMpIHtcclxuICAgICAgICAgICAgICAgIHRoaXMucmVhY3Rpb25zID0gW107XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgdGhpcy5yZWFjdGlvbnNbXCJpc1ZhbGlkUmVhY3Rpb25cIl0gPSByZWFjdGlvbjtcclxuICAgICAgICAgICAgKi9cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBib29sIElzVmFsaWRcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgaW5BY3Rpb24gPSBSZWFjdGl2ZUhlbHBlci5JbkFjdGlvbigpO1xyXG4gICAgICAgICAgICAgICAgaWYgKGluQWN0aW9uKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGZvciAodmFyIGkgPSAwOyBpIDwgbGlzdC5Db3VudDsgaSsrKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdmFyIHZsID0gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5FbGVtZW50QXQ8S2V5VmFsdWVQYWlyPEZ1bmM8VmFsaWRhdGlvblJlc3VsdD4sVmFsaWRhdGlvblJlc3VsdD4+KGxpc3QsaSkuS2V5O1xyXG5WYWxpZGF0aW9uUmVzdWx0IHZhbHVlO1xuICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGxpc3QuVHJ5R2V0VmFsdWUoKEZ1bmM8VmFsaWRhdGlvblJlc3VsdD4pdmwsIG91dCB2YWx1ZSkpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIGxpc3RbdmxdID0gdmwoKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgaXNWYWxpZCA9IFN5c3RlbS5MaW5xLkVudW1lcmFibGUuQWxsPFZhbGlkYXRpb25SZXN1bHQ+KGxpc3QuVmFsdWVzLChGdW5jPFZhbGlkYXRpb25SZXN1bHQsYm9vbD4pKHYgPT4gdi5Jc1ZhbGlkICE9IFZhbHVlUmVzdWx0LkVycm9yKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIGlzVmFsaWQ7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIGlzVmFsaWQ7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJUmVhZE9ubHlDb2xsZWN0aW9uPE1vZGVsRXJyb3I+IEVycm9yc1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBlcnJvcnMgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLldoZXJlPFZhbGlkYXRpb25SZXN1bHQ+KGxpc3QuVmFsdWVzLChGdW5jPFZhbGlkYXRpb25SZXN1bHQsYm9vbD4pKHYgPT4gdi5Jc1ZhbGlkID09IFZhbHVlUmVzdWx0LkVycm9yKSkuVG9BcnJheSgpO1xyXG4gICAgICAgICAgICAgICAgaWYgKGVycm9ycy5MZW5ndGggPT0gMClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gbmV3IE1vZGVsRXJyb3JbXSB7IH07XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFN5c3RlbS5MaW5xLkVudW1lcmFibGUuV2hlcmU8VmFsaWRhdGlvblJlc3VsdD4oZXJyb3JzLChGdW5jPFZhbGlkYXRpb25SZXN1bHQsYm9vbD4pKGUgPT4gZS5FcnJvck1lc3NhZ2UgIT0gbnVsbCkpLlNlbGVjdDxNb2RlbEVycm9yPigoRnVuYzxWYWxpZGF0aW9uUmVzdWx0LE1vZGVsRXJyb3I+KShyID0+IHIuRXJyb3JNZXNzYWdlKSkuQ29uY2F0KFN5c3RlbS5MaW5xLkVudW1lcmFibGUuU2VsZWN0TWFueTxWYWxpZGF0aW9uUmVzdWx0LE1vZGVsRXJyb3I+KGVycm9ycywoRnVuYzxWYWxpZGF0aW9uUmVzdWx0LElFbnVtZXJhYmxlPE1vZGVsRXJyb3I+PikoZSA9PiBlLklubmVyRXJyb3JzKSkpLlRvQXJyYXkoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIFZhbGlkYXRpb25SZXN1bHQgR2V0U3VtbWFyeVJlc3VsdCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoSXNWYWxpZClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFZhbGlkYXRpb25SZXN1bHQuT2soKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB2YXIgZXJyb3JzID0gRXJyb3JzO1xyXG4gICAgICAgICAgICBpZiAoZXJyb3JzLkNvdW50ID09IDApXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBWYWxpZGF0aW9uUmVzdWx0LkluUHJvZ3Jlc3MoKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKGxpc3QuQ291bnQgPT0gMClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFZhbGlkYXRpb25SZXN1bHQuT2soKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBWYWxpZGF0aW9uUmVzdWx0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIElzVmFsaWQgPSBWYWx1ZVJlc3VsdC5FcnJvcixcclxuICAgICAgICAgICAgICAgIElubmVyRXJyb3JzID0gZXJyb3JzXHJcbiAgICAgICAgICAgIH07XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBBZGRWYWxpZGF0b3IoRnVuYzxWYWxpZGF0aW9uUmVzdWx0PiB2YWxpZGF0ZUZ1bmMsIHN0cmluZyBuYW1lID0gc3RyaW5nLkVtcHR5KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHJlcyA9IFZhbGlkYXRpb25SZXN1bHQuSW5Qcm9ncmVzcygpO1xyXG4gICAgICAgICAgICBsaXN0LkFkZCgoRnVuYzxWYWxpZGF0aW9uUmVzdWx0Pil2YWxpZGF0ZUZ1bmMsIHJlcyk7XHJcbiAgICAgICAgICAgIEFjdGlvbjxWYWxpZGF0aW9uUmVzdWx0PiBzZXRWYWwgPSAobmV3UmVzdWx0KSA9PiBcclxuICAgICAgICAgICAge1xyXG5WYWxpZGF0aW9uUmVzdWx0IG9sZFJlc3VsdDtcbiAgICAgICAgICAgICAgICBpZiAobGlzdC5UcnlHZXRWYWx1ZSgoRnVuYzxWYWxpZGF0aW9uUmVzdWx0Pil2YWxpZGF0ZUZ1bmMsIG91dCBvbGRSZXN1bHQpICYmICFuZXdSZXN1bHQuRXF1YWxzKG9sZFJlc3VsdCkpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgbGlzdFt2YWxpZGF0ZUZ1bmNdID0gbmV3UmVzdWx0O1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAvLyAgVE9ETyBFTE1BNC01Nzc3INCf0LXRgNC10YDQsNCx0L7RgtCw0YLRjCBqcy3QstGB0YLQsNCy0LrQuFxyXG4gICAgICAgICAgICAvKkBcclxuICAgICAgICAgICAgY29uc3QgcmVhY3Rpb24gPSBtb2J4LnJlYWN0aW9uKFxyXG4gICAgICAgICAgICAgICAgdmFsaWRhdGVGdW5jLFxyXG4gICAgICAgICAgICAgICAgc2V0VmFsLFxyXG4gICAgICAgICAgICAgICAgeyBuYW1lOiBuYW1lfVxyXG4gICAgICAgICAgICApO1xyXG4gICAgICAgICAgICBpZiAoIXRoaXMucmVhY3Rpb25zKSB7XHJcbiAgICAgICAgICAgICAgICB0aGlzLnJlYWN0aW9ucyA9IFtdO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHRoaXMucmVhY3Rpb25zW3ZhbGlkYXRlRnVuYy4kJGhhc2hDb2RlXSA9IHJlYWN0aW9uO1xyXG4gICAgICAgICAgICAqL1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUmVtb3ZlVmFsaWRhdG9yKEZ1bmM8VmFsaWRhdGlvblJlc3VsdD4gdmFsaWRhdGVGdW5jKVxyXG4gICAgICAgIHtcclxuVmFsaWRhdGlvblJlc3VsdCB2YWx1ZTtcbiAgICAgICAgICAgIGlmIChsaXN0LlRyeUdldFZhbHVlKChGdW5jPFZhbGlkYXRpb25SZXN1bHQ+KXZhbGlkYXRlRnVuYywgb3V0IHZhbHVlKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgbGlzdC5SZW1vdmUoKEZ1bmM8VmFsaWRhdGlvblJlc3VsdD4pdmFsaWRhdGVGdW5jKTtcclxuICAgICAgICAgICAgICAgIC8qQFxyXG4gICAgICAgICAgICAgICAgdmFyIHJlYWN0aW9uID0gdGhpcy5yZWFjdGlvbnNbdmFsaWRhdGVGdW5jLiQkaGFzaENvZGVdO1xyXG4gICAgICAgICAgICAgICAgaWYgKHJlYWN0aW9uKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmVhY3Rpb24oKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICovXHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIERlc3Ryb3koKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgbGlzdC5DbGVhcigpO1xyXG4gICAgICAgICAgICAvKkBcclxuICAgICAgICAgICAgZm9yICh2YXIgaSBpbiB0aGlzLnJlYWN0aW9ucykge1xyXG4gICAgICAgICAgICAgICAgdGhpcy5yZWFjdGlvbnNbaV0oKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB0aGlzLnJlYWN0aW9ucyA9IG51bGw7XHJcbiAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIEVsZVdpc2UuRUxNQS5IZWxwZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld3M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cy5FeHRlbnNpb25zO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0J3QsNGB0YLRgNC+0LnQutC4IFZpZXdJdGVtINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIGNsYXNzIFZpZXdJdGVtQ29tcG9uZW50Q29udGFpbmVyIDogQ29tcG9uZW50Q29udGFpbmVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3TW9kZWxcIj7QnNC+0LTQtdC70Yw8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBWaWV3SXRlbUNvbXBvbmVudENvbnRhaW5lcihJVmlld01vZGVsIHZpZXdNb2RlbCkgOiBiYXNlKHZpZXdNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0L7Qu9GM0LrQviDQtNC70Y8g0YfRgtC10L3QuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgYm9vbCBSZWFkT25seVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciB2aWV3SXRlbVZpZXdNb2RlbCA9IFZpZXdNb2RlbCBhcyBJVmlld0l0ZW1WaWV3TW9kZWw7XHJcbiAgICAgICAgICAgICAgICBpZiAodmlld0l0ZW1WaWV3TW9kZWwgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gYmFzZS5SZWFkT25seTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5QdXNoKHZpZXdJdGVtVmlld01vZGVsLlJlbmRlck93bmVyKTtcclxuXHJcbiAgICAgICAgICAgICAgICB0cnlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgdmlld0l0ZW0gPSB2aWV3SXRlbVZpZXdNb2RlbC5WaWV3SXRlbSBhcyBWaWV3SXRlbTtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgb3duUmVhZE9ubHkgPSB2aWV3SXRlbSE9bnVsbD92aWV3SXRlbS5Jc1JlYWRPbmx5KCk6KGJvb2w/KW51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIG93blJlYWRPbmx5Lkhhc1ZhbHVlID8gb3duUmVhZE9ubHkuVmFsdWUgOiBiYXNlLlJlYWRPbmx5O1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZmluYWxseVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIEdsb2JhbFNjb3BlSGVscGVyLlBvcCh2aWV3SXRlbVZpZXdNb2RlbC5SZW5kZXJPd25lcik7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiNpZiBERUJVR1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQtdC80LAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBvdmVycmlkZSBWaWV3SXRlbVRoZW1lIFRoZW1lXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBnZXRcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHZpZXdJdGVtVmlld01vZGVsID0gVmlld01vZGVsIGFzIElWaWV3SXRlbVZpZXdNb2RlbDtcclxuICAgICAgICAgICAgICAgIGlmICh2aWV3SXRlbVZpZXdNb2RlbCAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciB0aGVtZUNvbnRhaW5lclZpZXdJdGVtID0gdmlld0l0ZW1WaWV3TW9kZWwuVmlld0l0ZW0gYXMgSVRoZW1lQ29udGFpbmVyVmlld0l0ZW07XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHRoZW1lQ29udGFpbmVyVmlld0l0ZW0gIT0gbnVsbClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBvd25UaGVtZSA9IHRoZW1lQ29udGFpbmVyVmlld0l0ZW0uVGhlbWU7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGlmIChvd25UaGVtZSAhPSBWaWV3SXRlbVRoZW1lLkluaGVyaXQpXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybiBvd25UaGVtZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICByZXR1cm4gYmFzZS5UaGVtZTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuI2VuZGlmXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIHN0cmluZyBOYW1lXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBnZXRcclxuICAgICAgICAgICAge1xyXG5JVmlld0l0ZW1WaWV3TW9kZWwgdmlld0l0ZW1WaWV3TW9kZWw7ICAgICAgICAgICAgICAgIGlmICgodmlld0l0ZW1WaWV3TW9kZWwgPSBWaWV3TW9kZWwgYXMgSVZpZXdJdGVtVmlld01vZGVsKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiB2aWV3SXRlbVZpZXdNb2RlbC5WaWV3SXRlbS5OYW1lO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHJldHVybiBiYXNlLk5hbWU7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbXBvbmVudE1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5FeHRlbnNpb25Qb2ludHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuVUkuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuU2VydmljZXNcclxue1xyXG4gICAgW1NlcnZpY2VdXHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSA6IElSZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJRW51bWVyYWJsZTxJUmVhY3RSZW5kZXJlcj4gcmVuZGVyZXJzO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlbmRlcmVyc1wiPtCg0LXQvdC00LXRgNC10YDRiyDQutC+0LzQv9C+0L3QtdC90YLQvtCyPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZShJRW51bWVyYWJsZTxJUmVhY3RSZW5kZXJlcj4gcmVuZGVyZXJzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5yZW5kZXJlcnMgPSByZW5kZXJlcnM7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgSVJlbmRlckNvbnRlbnQgQ3JlYXRlKFR5cGUgdHlwZVZpYywgSUlucHV0cyBpbnB1dHMsIElWaWV3TW9kZWwgb3duZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgcmVuZGVyZXIgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLkZpcnN0T3JEZWZhdWx0PElSZWFjdFJlbmRlcmVyPihyZW5kZXJlcnMsKEZ1bmM8SVJlYWN0UmVuZGVyZXIsYm9vbD4pKHIgPT4gci5DYW5SZW5kZXIodHlwZVZpYykpKTtcclxuICAgICAgICAgICAgaWYgKHJlbmRlcmVyICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiByZW5kZXJlci5SZW5kZXIodHlwZVZpYywgb3duZXIsIGlucHV0cyk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24oU1IuVChcItCd0LUg0L3QsNC50LTQtdC9INGA0LXQvdC00LXRgNC10YAg0LTQu9GPINC60L7QvNC/0L7QvdC10L3RgtCwIHswfVwiLCB0eXBlVmljLk5hbWUpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJUmVuZGVyQ29udGVudCBDcmVhdGU8VD4oSUlucHV0cyBpbnB1dHMsIElWaWV3TW9kZWwgb3duZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gQ3JlYXRlKHR5cGVvZihUKSwgaW5wdXRzLCBvd25lcik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgSVJlbmRlckNvbnRlbnQgRXJyb3IoSUVycm9ySW5wdXRzIGlucHV0cywgSVZpZXdNb2RlbCBvd25lcilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciByZW5kZXJlciA9IFN5c3RlbS5MaW5xLkVudW1lcmFibGUuRmlyc3RPckRlZmF1bHQ8SVJlYWN0UmVuZGVyZXI+KHJlbmRlcmVycywoRnVuYzxJUmVhY3RSZW5kZXJlcixib29sPikociA9PiByLkdldFR5cGUoKSA9PSB0eXBlb2YoRXJyb3JSZW5kZXJlcikpKTtcclxuICAgICAgICAgICAgaWYgKHJlbmRlcmVyICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiByZW5kZXJlci5SZW5kZXIodHlwZW9mKElFcnJvckNvbXBvbmVudCksIG93bmVyLCBpbnB1dHMpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB0aHJvdyBuZXcgRXhjZXB0aW9uKFNSLlQoXCLQndC1INC90LDQudC00LXQvSDRgNC10L3QtNC10YDQtdGAINC00LvRjyDQutC+0LzQv9C+0L3QtdC90YLQsCDQvtGC0L7QsdGA0LDQttC10L3QuNGPINC+0YjQuNCx0LrQuFwiKSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLklvYy5BYnN0cmFjdDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzXHJcbntcclxuICAgIFtDb21wb25lbnQoT3JkZXIgPSBpbnQuTWF4VmFsdWUgLSAxKV1cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlSW5wdXRSZW5kZXJlciA6IEJhc2VSZWFjdFJlbmRlcmVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEJhc2VJbnB1dFJlbmRlcmVyKElMaWZldGltZVNjb3BlIGN1cnJlbnRTY29wZSkgOiBiYXNlKGN1cnJlbnRTY29wZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgYm9vbCBDYW5SZW5kZXIoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHR5cGVvZihJSW5wdXRDb21wb25lbnQpLklzQXNzaWduYWJsZUZyb20odHlwZUNvbXBvbmVudCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgb3ZlcnJpZGUgSVJlYWN0SW5wdXRNb2RlbCBDcmVhdGVJbnB1dE1vZGVsKFR5cGUgdHlwZUNvbXBvbmVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8v0JXRgdC70Lgg0LrQvtC80L/QvtC90LXQvdGCINGB0L7QtNC10YDQttC40YIgMSDQsNGA0LPRg9C80LXQvdGCLCDQvdCw0L/RgNC40LzQtdGAOiBCYXNlSW5wdXRDb21wb25lbnQ8c3RyaW5nPiDRgdC+0LfQtNCw0LXQvCBCYXNlSW5wdXRzPHN0cmluZz5cclxuICAgICAgICAgICAgVHlwZSB0eXBlSW5wdXRzID0gbnVsbDtcclxuICAgICAgICAgICAgdmFyIGFyZ3MgPSBHZXRJbnB1dHNUeXBlQ29tcG9uZW50KHR5cGVDb21wb25lbnQpO1xyXG4gICAgICAgICAgICBpZiAoYXJncy5MZW5ndGggPiAwKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgc2ltcGxlVHlwZSA9IGFyZ3NbMF07XHJcbiAgICAgICAgICAgICAgICB2YXIgYmFzZUlucHV0c1R5cGUgPSB0eXBlb2YoQmFzZUlucHV0czw+KTtcclxuICAgICAgICAgICAgICAgIGlmICghYmFzZUlucHV0c1R5cGUuSXNBc3NpZ25hYmxlRnJvbShzaW1wbGVUeXBlKSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB0eXBlSW5wdXRzID0gYmFzZUlucHV0c1R5cGUuTWFrZUdlbmVyaWNUeXBlKG5ld1tdIHsgc2ltcGxlVHlwZSB9KTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBcclxuICAgICAgICAgICAgdmFyIGdlbmVyaWNUeXBlID0gdHlwZW9mKElucHV0TW9kZWw8PikuTWFrZUdlbmVyaWNUeXBlKG5ld1tdIHsgdHlwZUlucHV0cyB9KTtcclxuICAgICAgICAgICAgcmV0dXJuIChJUmVhY3RJbnB1dE1vZGVsKUFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZShnZW5lcmljVHlwZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIFR5cGVbXSBHZXRJbnB1dHNUeXBlQ29tcG9uZW50KFR5cGUgdHlwZUNvbXBvbmVudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiB0eXBlQ29tcG9uZW50LkJhc2VUeXBlLklzR2VuZXJpY1R5cGUgPyB0eXBlQ29tcG9uZW50LkJhc2VUeXBlLkdldEdlbmVyaWNBcmd1bWVudHMoKSA6IEdldElucHV0c1R5cGVDb21wb25lbnQodHlwZUNvbXBvbmVudC5CYXNlVHlwZSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbXBvbmVudE1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5FeHRlbnNpb25Qb2ludHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuVUkuTW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Jb2MuQWJzdHJhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuQ29tcG9uZW50c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQtdC90LTQtdGA0LXRgCDQutC+0LzQv9C+0L3QtdC90YLQsCDQvtGI0LjQsdC60LhcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbQ29tcG9uZW50KE9yZGVyID0gMTApXVxyXG4gICAgaW50ZXJuYWwgc2VhbGVkIGNsYXNzIEVycm9yUmVuZGVyZXIgOiBCYXNlUmVhY3RSZW5kZXJlclxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlO1xyXG4gICAgICAgIHByaXZhdGUgSUNvbXBvbmVudE1hbmFnZXIgY29tcG9uZW50TWFuYWdlcjtcclxucHJpdmF0ZSBJQ29tcG9uZW50TWFuYWdlciBDb21wb25lbnRNYW5hZ2VyXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBjb21wb25lbnRNYW5hZ2VyID8/IChjb21wb25lbnRNYW5hZ2VyID0gY3VycmVudFNjb3BlLlJlc29sdmU8SUNvbXBvbmVudE1hbmFnZXI+KCkpO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIEVycm9yUmVuZGVyZXIoSUxpZmV0aW1lU2NvcGUgY3VycmVudFNjb3BlKSA6IGJhc2UoY3VycmVudFNjb3BlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5jdXJyZW50U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgYm9vbCBDYW5SZW5kZXIoVHlwZSB0eXBlQ29tcG9uZW50KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIHR5cGVDb21wb25lbnQgPT0gdHlwZW9mKElFcnJvckNvbXBvbmVudCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgSVJlbmRlckNvbnRlbnQgUmVuZGVyKFR5cGUgdHlwZUNvbXBvbmVudCwgSVZpZXdNb2RlbCBvd25lciwgSUlucHV0cyBpbnB1dHMgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHR5cGVzUmVhY3RDb21wb25lbnQgPSBDb21wb25lbnRNYW5hZ2VyLkdldFR5cGVzKHR5cGVvZihJRXJyb3JDb21wb25lbnQpKTtcclxuICAgICAgICAgICAgdmFyIGVycm9yVHlwZUNvbXBvbmVudCA9IFN5c3RlbS5MaW5xLkVudW1lcmFibGUuRmlyc3RPckRlZmF1bHQ8VHlwZT4odHlwZXNSZWFjdENvbXBvbmVudCk7XHJcbiAgICAgICAgICAgIHZhciBtb2RlbCA9IEJhc2VJbml0Vmlld01vZGVsKGVycm9yVHlwZUNvbXBvbmVudCwgb3duZXIsIGlucHV0cyk7XHJcbiAgICAgICAgICAgIHJldHVybiBDcmVhdGVDb21wb25lbnQoZXJyb3JUeXBlQ29tcG9uZW50LCBtb2RlbCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgSVJlYWN0SW5wdXRNb2RlbCBCYXNlSW5pdFZpZXdNb2RlbChUeXBlIHR5cGVDb21wb25lbnQsIElWaWV3TW9kZWwgb3duZXIsIElJbnB1dHMgaW5wdXRzID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dE1vZGVsID0gQ3JlYXRlSW5wdXRNb2RlbCh0eXBlQ29tcG9uZW50KTtcclxuICAgICAgICAgICAgaW5wdXRNb2RlbC5LZXkgPSAoaW5wdXRzIT1udWxsP2lucHV0cy5LZXk6KHN0cmluZyludWxsKSA/PyB0eXBlQ29tcG9uZW50Lk5hbWU7XHJcblxyXG4gICAgICAgICAgICB2YXIgaW5wdXRUeXBlID0gR2V0SW5wdXRzVHlwZSh0eXBlQ29tcG9uZW50KTtcclxuXHJcbiAgICAgICAgICAgIHZhciBuZXdJbnB1dHMgPSAoSUVycm9ySW5wdXRzKUFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZShpbnB1dFR5cGUpO1xyXG5JRXJyb3JJbnB1dHMgb2xkSW5wdXRzOyAgICAgICAgICAgIGlmICgob2xkSW5wdXRzID0gaW5wdXRzIGFzIElFcnJvcklucHV0cykgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgbmV3SW5wdXRzLktleSA9IG9sZElucHV0cy5LZXk7XHJcbiAgICAgICAgICAgICAgICBuZXdJbnB1dHMuTWVzc2FnZSA9IG9sZElucHV0cy5NZXNzYWdlO1xyXG4gICAgICAgICAgICAgICAgbmV3SW5wdXRzLlN0YWNrU2hvdyA9IG9sZElucHV0cy5TdGFja1Nob3c7XHJcbiAgICAgICAgICAgICAgICAoKElucHV0cyluZXdJbnB1dHMpLkNoaWxkcmVuID0gKChJbnB1dHMpb2xkSW5wdXRzKS5DaGlsZHJlbjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaW5wdXRNb2RlbC5JbnB1dHMgPSBuZXdJbnB1dHM7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuT3duZXIgPSBvd25lcjtcclxuICAgICAgICAgICAgaW5wdXRNb2RlbC5Sb290U2NvcGUgPSBjdXJyZW50U2NvcGU7XHJcbiAgICAgICAgICAgIGlucHV0TW9kZWwuRGF0YVN0YWNrID0gb3duZXIhPW51bGwmJmdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsb3duZXIuR2V0RHluYW1pY0RhdGEoKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPEVMTUEuTW9kZWwuSURhdGFTdGFjaz4oXCJrZXkxXCIpLkNsb25lKCk6KEVMTUEuTW9kZWwuSURhdGFTdGFjayludWxsO1xyXG5cclxuICAgICAgICAgICAgcmV0dXJuIGlucHV0TW9kZWw7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgQnJpZGdlLlJlYWN0O1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db250cm9sbGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuRXh0ZW5zaW9uUG9pbnRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5TZXJ2aWNlcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuVUkuU2VydmljZXM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5EaXNwYXRjaGVyO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLklvYztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLk1ldGFkYXRhO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmFsaWRhdGlvbjtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNlcmlhbGl6YXRpb247XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzXHJcbntcclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBWaWV3TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPiA6IFZpZXdNb2RlbCwgSVZpZXdNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+XHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICBwdWJsaWMgVmlld01vZGVsKFxyXG4gICAgICAgICAgICBJVmlld01vZGVsQ3JlYXRvclNlcnZpY2Ugdmlld01vZGVsQ3JlYXRvclNlcnZpY2UsXHJcbiAgICAgICAgICAgIElMYXp5PElWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlPiBsYXp5Vmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSxcclxuICAgICAgICAgICAgSVJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UgcmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSxcclxuICAgICAgICAgICAgSURpc3BhdGNoZXIgZGlzcGF0Y2hlclxyXG4gICAgICAgICkgOiBiYXNlKHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlLCBsYXp5Vmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSwgcmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSwgZGlzcGF0Y2hlcilcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgbmV3IFRDb250ZXh0IENvbnRleHRcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAoYmFzZS5Db250ZXh0ICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIChUQ29udGV4dCliYXNlLkNvbnRleHQ7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIGRlZmF1bHQoVENvbnRleHQpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHNldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBiYXNlLkNvbnRleHQgPSB2YWx1ZTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIG5ldyBUQ29udHJvbGxlciBDb250cm9sbGVyXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBnZXRcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgaWYgKGNvbnRyb2xsZXIgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gKFRDb250cm9sbGVyKWNvbnRyb2xsZXI7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIGRlZmF1bHQoVENvbnRyb2xsZXIpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIHB1YmxpYyBjbGFzcyBWaWV3TW9kZWwgOiBSZWFjdGl2ZSwgSVJlYWN0Vmlld01vZGVsLCBJVmFsaWRhdGlvblZpZXdNb2RlbFxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUxhenk8SVZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2U+IGxhenlWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSURpc3BhdGNoZXIgZGlzcGF0Y2hlcjtcclxuICAgICAgICBwcm90ZWN0ZWQgRGF0YVN0YWNrIFN0YWNrID0gbmV3IERhdGFTdGFjaygpO1xyXG4gICAgICAgIHByaXZhdGUgRnVuYzxJSW5wdXRNb2RlbD4gaW5wdXRNb2RlbEZ1bmM7XHJcbiAgICAgICAgcHJpdmF0ZSBJQ29tcG9uZW50Q29udGFpbmVyIGNvbXBvbmVudFNldHRpbmdzO1xyXG4gICAgICAgIHByaXZhdGUgSVZpZXdNb2RlbFZhbGlkYXRpb25Nb2RlbCB2YWxpZGF0aW9uTW9kZWw7XHJcblxyXG4gICAgICAgIHB1YmxpYyBWaWV3TW9kZWwoXHJcbiAgICAgICAgICAgIElWaWV3TW9kZWxDcmVhdG9yU2VydmljZSB2aWV3TW9kZWxDcmVhdG9yU2VydmljZSxcclxuICAgICAgICAgICAgSUxhenk8SVZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2U+IGxhenlWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJRGlzcGF0Y2hlciBkaXNwYXRjaGVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5sYXp5Vmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSA9IGxhenlWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlO1xyXG4gICAgICAgICAgICBWaWV3TW9kZWxDcmVhdG9yU2VydmljZSA9IHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlO1xyXG4gICAgICAgICAgICBSZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlID0gcmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZTtcclxuICAgICAgICAgICAgdGhpcy5kaXNwYXRjaGVyID0gZGlzcGF0Y2hlcjtcclxuXHJcbiAgICAgICAgICAgIERlZmluZVByb3BlcnR5KHRoaXMsIG5ldyBQcm9wZXJ0eUluZm9FeHByZXNzaW9uXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIE9iamVjdEV4cHJlc3Npb24gPSBcImNvbnRyb2xsZXJcIixcclxuICAgICAgICAgICAgICAgIEV4cHJlc3Npb25Gb3JTZXJpYWxpemUgPSBcImNvbnRyb2xsZXJcIiAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICBEZWZpbmVQcm9wZXJ0eSh0aGlzLCBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBPYmplY3RFeHByZXNzaW9uID0gXCJFcnJvclwiLFxyXG4gICAgICAgICAgICAgICAgRXhwcmVzc2lvbkZvclNlcmlhbGl6ZSA9IFwiRXJyb3JcIiAgICAgICAgICAgIH0pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI3JlZ2lvbiBTZXJ2aWNlc1xyXG5cclxuICAgICAgICBwdWJsaWMgSVZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlIFZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlIHsgZ2V0OyBzZXQ7IH1cclxucHVibGljIElWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlIFZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2Vcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGxhenlWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlLlZhbHVlKCk7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICBwdWJsaWMgSVJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UgUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgICNlbmRyZWdpb25cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktC+0LfQvdC40LrQu9CwINC+0YjQuNCx0LrQsCDQv9GA0Lgg0LfQsNCz0YDRg9C30LrQtSDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIGJvb2wgRXJyb3IgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LXQutGB0YIg0L7RiNC40LHQutC4INC/0YDQuCDQt9Cw0LPRgNGD0LfQutC1INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIEVycm9yTWVzc2FnZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQtdC60YHRgiDQvtGI0LjQsdC60Lgg0L/RgNC4INC30LDQs9GA0YPQt9C60LUg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBFcnJvclN0YWNrTW9kZWwgRXJyb3JJbmZvIHsgZ2V0OyBzZXQ7IH1cclxucHVibGljIElJbnB1dE1vZGVsIElucHV0TW9kZWxcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGlucHV0TW9kZWxGdW5jIT1udWxsP2lucHV0TW9kZWxGdW5jLkludm9rZSgpOihJSW5wdXRNb2RlbCludWxsO1xyXG4gICAgfVxyXG59Ly8vIDxzdW1tYXJ5PlxyXG4vLy8g0KTQu9Cw0LMg0LPQvtGC0L7QstC90L7RgdGC0Lgg0LzQvtC00LXQu9C4XHJcbi8vLyA8L3N1bW1hcnk+XHJcbnB1YmxpYyB2aXJ0dWFsIGJvb2wgUmVhZHlcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIENvbnRleHQgIT0gbnVsbCAmJiBjb250cm9sbGVyICE9IG51bGwgJiYgIUVycm9yO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0L3RgtC10LrRgdGCXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSUNvbnRleHQgQ29udGV4dCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J3QsNGB0YLRgNC+0LnQutC4INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBJQ29tcG9uZW50Q29udGFpbmVyIENvbXBvbmVudFxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChjb21wb25lbnRTZXR0aW5ncyA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbXBvbmVudFNldHRpbmdzID0gbmV3IENvbXBvbmVudENvbnRhaW5lcih0aGlzKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIHJldHVybiBjb21wb25lbnRTZXR0aW5ncztcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxucHVibGljIElWaWV3TW9kZWwgUmVuZGVyT3duZXJcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsSW5wdXRNb2RlbCkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPElJbnB1dE1vZGVsPihcImtleTFcIikuT3duZXI6KElWaWV3TW9kZWwpbnVsbDtcclxuICAgIH1cclxufXB1YmxpYyB2aXJ0dWFsIElDb250cm9sbGVyIENvbnRyb2xsZXJcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGNvbnRyb2xsZXI7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgSUNvbXBvbmVudERpc3BhdGNoZXIgQ29tcG9uZW50RGlzcGF0Y2hlciB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgdm9pZCBGaWxsVmlld01vZGVsKEZ1bmM8SUlucHV0TW9kZWw+IGlucHV0TW9kZWwsIFR5cGUgdHlwZUNvbnRleHQsIFR5cGUgdHlwZUNvbnRyb2xsZXIsIElSZWFjdENvbXBvbmVudCBjb21wb25lbnQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpbnB1dE1vZGVsRnVuYyA9IGlucHV0TW9kZWw7XHJcblxyXG4gICAgICAgICAgICBpZiAodHlwZUNvbnRleHQgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgR2VuZXJhdGVDb250ZXh0KHR5cGVDb250ZXh0KTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBcclxuICAgICAgICAgICAgaWYgKHR5cGVDb250cm9sbGVyICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIEdlbmVyYXRlQ29udHJvbGxlcih0eXBlQ29udHJvbGxlcik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KPQvdC40YfRgtC+0LbQuNGC0Ywg0LzQvtC00LXQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBUYXNrIERlc3Ryb3koKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgICNyZWdpb24gRHluYW1pYyBEYXRhXHJcblxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFNldER5bmFtaWNEYXRhKERhdGFTdGFja0l0ZW0gZGF0YUl0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBTdGFjay5BZGQoZGF0YUl0ZW0pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIHZvaWQgUmVzdG9yZUR5bmFtaWNEYXRhKERhdGFTdGFja0l0ZW0gZGF0YUl0ZW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBTdGFjay5SZW1vdmUoZGF0YUl0ZW0pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIElEYXRhU3RhY2sgR2V0RHluYW1pY0RhdGEoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIFN0YWNrO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAjcmVnaW9uIFZhbGlkYXRpb25cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC+0LTQtdC70Ywg0LLQsNC70LjQtNCw0YbQuNC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSVZhbGlkYXRpb25Nb2RlbCBWYWxpZGF0aW9uTW9kZWxcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAodmFsaWRhdGlvbk1vZGVsID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFsaWRhdGlvbk1vZGVsID0gbmV3IFZhbGlkYXRpb25Nb2RlbCh0aGlzKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIHJldHVybiB2YWxpZGF0aW9uTW9kZWw7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCc0L7QtNC10LvRjCDQstCw0LvQuNC00LDRhtC40LhcclxuLy8vIDwvc3VtbWFyeT5cclxucHJpdmF0ZSBJVmlld01vZGVsVmFsaWRhdGlvbk1vZGVsIFZhbGlkYXRpb25Nb2RlbEludGVybmFsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoSVZpZXdNb2RlbFZhbGlkYXRpb25Nb2RlbClWYWxpZGF0aW9uTW9kZWw7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCe0YLQv9C40YHQutCwINC+0YIg0LLQsNC70LjQtNCw0YbQuNC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgdm9pZCBEZXN0cm95VmFsaWRhdGlvbigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBWYWxpZGF0aW9uTW9kZWxJbnRlcm5hbC5EZXN0cm95KCk7XHJcblZpZXdNb2RlbCB2aWV3TW9kZWw7XHJcbiAgICAgICAgICAgIGlmICgodmlld01vZGVsID0gUmVuZGVyT3duZXIgYXMgVmlld01vZGVsKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2aWV3TW9kZWwuVmFsaWRhdGlvbk1vZGVsSW50ZXJuYWwuUmVtb3ZlVmFsaWRhdG9yKChGdW5jPFZhbGlkYXRpb25SZXN1bHQ+KU93bmVyVmFsaWRhdG9yKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQodC+0LfQtNCw0L3QuNC1XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgdm9pZCBDcmVhdGVWYWxpZGF0aW9uKClcclxuICAgICAgICB7XHJcbklPblZhbGlkYXRlIHZhbGlkYXRpb25Db250cm9sbGVyOyAgICAgICAgICAgIGlmICgodmFsaWRhdGlvbkNvbnRyb2xsZXIgPSBjb250cm9sbGVyIGFzIElPblZhbGlkYXRlKSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgb25CZWZvcmUgPSBuZXcgQWN0aW9uKCgpID0+IHsgfSk7XHJcbiAgICAgICAgICAgICAgICB2YXIgb25BZnRlciA9IG5ldyBBY3Rpb24oKCkgPT4geyB9KTtcclxuSUhhbmRsZVZhbGlkYXRlQWN0aW9uIGhhbmRsZVZhbGlkYXRlQWN0aW9uOyAgICAgICAgICAgICAgICBpZiAoKGhhbmRsZVZhbGlkYXRlQWN0aW9uID0gY29udHJvbGxlciBhcyBJSGFuZGxlVmFsaWRhdGVBY3Rpb24pICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgb25CZWZvcmUgPSBoYW5kbGVWYWxpZGF0ZUFjdGlvbi5PbkJlZm9yZVZhbGlkYXRlQWN0aW9uO1xyXG4gICAgICAgICAgICAgICAgICAgIG9uQWZ0ZXIgPSBoYW5kbGVWYWxpZGF0ZUFjdGlvbi5PbkFmdGVyVmFsaWRhdGVBY3Rpb247XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgVmFsaWRhdGlvbk1vZGVsSW50ZXJuYWwuQWRkVmFsaWRhdG9yKChGdW5jPFZhbGlkYXRpb25SZXN1bHQ+KSgoKSA9PlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIFZhbGlkYXRpb25SZXN1bHQgcmVzdWx0ID0gbnVsbDtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgaW5BY3Rpb24gPSBSZWFjdGl2ZUhlbHBlci5JbkFjdGlvbigpO1xyXG4gICAgICAgICAgICAgICAgICAgIGlmIChpbkFjdGlvbilcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIG9uQmVmb3JlKCk7XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICBDb21wb25lbnQuRGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uKSgoKSA9PlxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICByZXN1bHQgPSB2YWxpZGF0aW9uQ29udHJvbGxlci5PblZhbGlkYXRlKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIH0pKTtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgR2xvYmFsU2NvcGVIZWxwZXIuUHVzaChSZW5kZXJPd25lcik7XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICB0cnlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgcmVzdWx0ID0gdmFsaWRhdGlvbkNvbnRyb2xsZXIuT25WYWxpZGF0ZSgpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgR2xvYmFsU2NvcGVIZWxwZXIuUG9wKFJlbmRlck93bmVyKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKHJlc3VsdC5FcnJvck1lc3NhZ2UgIT0gbnVsbCBcclxuICAgICAgICAgICAgICAgICAgICAgICAgJiYgc3RyaW5nLklzTnVsbE9yV2hpdGVTcGFjZShyZXN1bHQuRXJyb3JNZXNzYWdlLkNvbXBvbmVudE5hbWUpKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgcmVzdWx0LkVycm9yTWVzc2FnZS5Db21wb25lbnROYW1lID0gQ29tcG9uZW50Lk5hbWU7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgICAgICBpZiAoaW5BY3Rpb24pXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBvbkFmdGVyKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiByZXN1bHQ7XHJcbiAgICAgICAgICAgICAgICB9KSxcclxuICAgICAgICAgICAgICAgIENvbXBvbmVudC5OYW1lICsgXCJWYWxpZGF0b3JcIik7XHJcbiAgICAgICAgICAgIH1cclxuVmlld01vZGVsIHZpZXdNb2RlbDtcclxuICAgICAgICAgICAgaWYgKCh2aWV3TW9kZWwgPSBSZW5kZXJPd25lciBhcyBWaWV3TW9kZWwpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZpZXdNb2RlbC5WYWxpZGF0aW9uTW9kZWxJbnRlcm5hbC5BZGRWYWxpZGF0b3IoKEZ1bmM8VmFsaWRhdGlvblJlc3VsdD4pT3duZXJWYWxpZGF0b3IsIENvbXBvbmVudC5OYW1lICsgXCIkT3duZXJWYWxpZGF0b3IkXCIgKyBSZW5kZXJPd25lci5Db21wb25lbnQuTmFtZSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgVmFsaWRhdGlvblJlc3VsdCBPd25lclZhbGlkYXRvcigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5QdXNoKFJlbmRlck93bmVyKTtcclxuXHJcbiAgICAgICAgICAgIHRyeVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gVmFsaWRhdGlvbk1vZGVsLkdldFN1bW1hcnlSZXN1bHQoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBmaW5hbGx5XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIEdsb2JhbFNjb3BlSGVscGVyLlBvcChSZW5kZXJPd25lcik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgICNlbmRyZWdpb25cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHZpcnR1YWwgdm9pZCBHZW5lcmF0ZUNvbnRleHQoVHlwZSB0eXBlQ29udGV4dClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmICh0eXBlQ29udGV4dCA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBjb250ZXh0ID0gKElDb250ZXh0KUFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZSh0eXBlQ29udGV4dCk7XHJcblxyXG4gICAgICAgICAgICB2YXIgcHJvcGVydGllcyA9IHR5cGVDb250ZXh0LkdldFByb3BlcnRpZXMoKTtcclxuICAgICAgICAgICAgdmFyIGJhc2VUeXBlID0gdHlwZUNvbnRleHQuQmFzZVR5cGU7XHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciBwcm9wZXJ0eSBpbiBwcm9wZXJ0aWVzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAvL9GB0LTQtdC70LDRgtGMINCy0L7Qt9C80L7QttC90L7RgdGC0Ywg0YDQtdC30L7Qu9Cy0LAg0YLQuNC/0L7QsiDQv9C+INGD0LjQtNGDXHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlOYW1lID0gcHJvcGVydHkuTmFtZTtcclxuICAgICAgICAgICAgICAgIGlmIChiYXNlVHlwZS5HZXRQcm9wZXJ0eShwcm9wZXJ0eU5hbWUpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGluZm8gPSBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgT2JqZWN0RXhwcmVzc2lvbiA9IHByb3BlcnR5TmFtZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgRXhwcmVzc2lvbkZvclNlcmlhbGl6ZSA9IHByb3BlcnR5TmFtZVxyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgQ29udmVydEhlbHBlci5SZWRlZmluZVByb3AoY29udGV4dCwgaW5mbywgKEZ1bmM8b2JqZWN0PikoKCkgPT4gR2V0SW5wdXQocHJvcGVydHlOYW1lKSkpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciB2YWx1ZSA9IGNvbnRleHQuR2V0UHJvcGVydHlWYWx1ZShwcm9wZXJ0eU5hbWUsIERlZmF1bHRWYWx1ZUhlbHBlci5HZXRUeXBlRGVmYXVsdFZhbHVlKHByb3BlcnR5LlByb3BlcnR5VHlwZSkpO1xyXG4gICAgICAgICAgICAgICAgICAgIERlZmluZVByb3BlcnR5KGNvbnRleHQsIG5ldyBQcm9wZXJ0eUluZm9FeHByZXNzaW9uXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBPYmplY3RFeHByZXNzaW9uID0gcHJvcGVydHlOYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBFeHByZXNzaW9uRm9yU2VyaWFsaXplID0gcHJvcGVydHlOYW1lXHJcbiAgICAgICAgICAgICAgICAgICAgfSk7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGV4dC5TZXRQcm9wZXJ0eVZhbHVlKHByb3BlcnR5TmFtZSwgdmFsdWUpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBDb250ZXh0ID0gY29udGV4dDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBpbnRlcm5hbCBzdGF0aWMgdm9pZCBEZWZpbmVQcm9wZXJ0eShvYmplY3QgdGFyZ2V0LCBQcm9wZXJ0eUluZm9FeHByZXNzaW9uIGV4cHJlc3Npb24pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgbmFtZSA9IGV4cHJlc3Npb24uT2JqZWN0RXhwcmVzc2lvbjtcclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIE9iamVjdC5kZWZpbmVQcm9wZXJ0eSh0YXJnZXQsIG5hbWUsIHtcclxuICAgICAgICAgICAgICAgIGNvbmZpZ3VyYWJsZTogdHJ1ZSxcclxuICAgICAgICAgICAgICAgIGdldDogZnVuY3Rpb24oKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIFJlYWN0aXZlLmNvbnZlcnRIZWxwZXIuR2V0T2JqZWN0KEJyaWRnZS51bmJveCh0YXJnZXQpLCBleHByZXNzaW9uLCBmYWxzZSwgdm9pZCAwKTtcclxuICAgICAgICAgICAgICAgIH0sXHJcbiAgICAgICAgICAgICAgICBzZXQ6IGZ1bmN0aW9uKHYpIHtcclxuICAgICAgICAgICAgICAgICAgICBSZWFjdGl2ZS5jb252ZXJ0SGVscGVyLlNldE9iamVjdChCcmlkZ2UudW5ib3godGFyZ2V0KSwgZXhwcmVzc2lvbiwgQnJpZGdlLnVuYm94KHYpLCBmYWxzZSwgdm9pZCAwKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfSk7XHJcbiAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgdmlydHVhbCB2b2lkIEdlbmVyYXRlQ29udHJvbGxlcihUeXBlIHR5cGVDb250cm9sbGVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKHR5cGVDb250cm9sbGVyID09IG51bGwgfHwgdHlwZUNvbnRyb2xsZXIuSXNJbnRlcmZhY2UpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBjb250cm9sbGVyID0gVmlld01vZGVsQ3JlYXRvclNlcnZpY2UuQ29udHJvbGxlckNyZWF0b3IodHlwZUNvbnRyb2xsZXIsIENvbnRleHQsIHRoaXMpO1xyXG4gICAgICAgICAgICBDcmVhdGVEaXNwYXRjaGVyKHR5cGVDb250cm9sbGVyKTtcclxuXHJcbiAgICAgICAgICAgIGRpc3BhdGNoZXIuRGlzcGF0Y2gobmV3IEFjdGlvbkNvbW1hbmQoQ29udHJvbGxlckFzeW5jQ29uc3RhbnRzLkNvbW1hbmROYW1lLCBcIlwiLCBjb250cm9sbGVyLCBuZXcgRnVuYzxUYXNrPigoKSA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBDcmVhdGVWYWxpZGF0aW9uKCk7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gVGFzay5Db21wbGV0ZWRUYXNrO1xyXG4gICAgICAgICAgICB9KSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJvdGVjdGVkIHZvaWQgQ3JlYXRlRGlzcGF0Y2hlcihUeXBlIHR5cGVDb250cm9sbGVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGdlbmVyaWNUeXBlID0gdHlwZW9mKENvbXBvbmVudERpc3BhdGNoZXI8PikuTWFrZUdlbmVyaWNUeXBlKG5ld1tdIHsgdHlwZUNvbnRyb2xsZXIgfSk7XHJcbiAgICAgICAgICAgIENvbXBvbmVudERpc3BhdGNoZXIgPSAoSUNvbXBvbmVudERpc3BhdGNoZXIpQWN0aXZhdG9yLkNyZWF0ZUluc3RhbmNlKGdlbmVyaWNUeXBlLCBkaXNwYXRjaGVyLCB0aGlzKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBJQ29udHJvbGxlciBjb250cm9sbGVyO1xyXG5cclxuICAgICAgICBwcm90ZWN0ZWQgb2JqZWN0IEdldElucHV0KHN0cmluZyBwcm9wZXJ0eU5hbWUpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoSW5wdXRNb2RlbC5JbnB1dHMgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBpbnB1dFByb3BlcnR5SW5mbyA9IElucHV0TW9kZWwuSW5wdXRzLkdldFR5cGUoKS5HZXRQcm9wZXJ0eShwcm9wZXJ0eU5hbWUpO1xyXG4gICAgICAgICAgICBpZiAoaW5wdXRQcm9wZXJ0eUluZm8gIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIGlucHV0UHJvcGVydHlJbmZvLkdldFZhbHVlKElucHV0TW9kZWwuSW5wdXRzKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIElucHV0TW9kZWwuSW5wdXRzW3Byb3BlcnR5TmFtZV07XHJcbiAgICAgICAgfVxyXG4vLy8gPHN1bW1hcnk+XHJcbi8vLyDQn9C+0LvRg9GH0LjRgtGMINC00LDQvdC90YvQtSDRgdGC0LXQutCwXHJcbi8vLyA8L3N1bW1hcnk+XHJcbi8vLyA8cmV0dXJucz7QlNCw0L3QvdGL0LUg0YHRgtC10LrQsDwvcmV0dXJucz5cclxucHJvdGVjdGVkIElEYXRhU3RhY2sgR2V0RGF0YSgpXHJcbntcclxuSVJlYWN0Vmlld0l0ZW1JbnB1dE1vZGVsIHJlYWN0SW5wdXRNb2RlbDsgICAgcmV0dXJuIChyZWFjdElucHV0TW9kZWwgPSBJbnB1dE1vZGVsIGFzIElSZWFjdFZpZXdJdGVtSW5wdXRNb2RlbCkgIT0gbnVsbD8gcmVhY3RJbnB1dE1vZGVsLkRhdGFTdGFjayA6IG51bGw7XHJcbn1cbiAgICBcbnByaXZhdGUgRXJyb3JTdGFja01vZGVsIF9fUHJvcGVydHlfX0luaXRpYWxpemVyX19FcnJvckluZm89bmV3IEVycm9yU3RhY2tNb2RlbCgpO31cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkFic3RyYWN0aW9ucy5NZXRhZGF0YS5Nb2RlbHMuTWV0YWRhdGE7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlUmFuZ2VJbnB1dHM8VD4gOiBCYXNlSW5wdXRzPFQ+XHJcbiAgICB7XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCa0L7QvdGC0LXQutGB0YIg0LTQuNCw0L/QsNC30L7QvdCwXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIGludGVyZmFjZSBJQmFzZVJhbmdlQ29udGV4dCA6IElCYXNlQ29udGV4dFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JzQtdGC0LDQtNCw0L3QvdGL0LUg0YHQstC+0LnRgdGC0LLQsCBcItCe0YJcIlxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgSVByb3BlcnR5TWV0YWRhdGEgUHJvcGVydHlGcm9tIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQnNC10YLQsNC00LDQvdC90YvQtSDRgdCy0L7QudGB0YLQstCwIFwi0JTQvlwiXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBJUHJvcGVydHlNZXRhZGF0YSBQcm9wZXJ0eVRvIHsgZ2V0OyBzZXQ7IH1cclxuICAgIH1cclxuXHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JHQsNC30L7QstGL0Lkg0LrQvtC90YLRgNC+0LvQu9C10YAg0LTQu9GPINC00LjQsNC/0LDQt9C+0L3QvtCyXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRcIj7QotC40L8g0LTQsNC90L3Ri9GFPC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVENvbnRleHRcIj7QotC40L8g0LrQvtC90YLQtdC60YHRgtCwPC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVJhbmdlQ29udHJvbGxlcjxULCBUQ29udGV4dD4gOiBCYXNlSW5wdXRDb250cm9sbGVyPFQsIFRDb250ZXh0PiwgSU9uSW5pdFxyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUJhc2VSYW5nZUNvbnRleHRcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBPbkluaXQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIG5hbWUgPSBHZXROYW1lKCk7XHJcbiAgICAgICAgICAgIHZhciBhdHRyaWJ1dGVzID0gQ29udGV4dC5BdHRyaWJ1dGVzKCk7XHJcblxyXG4gICAgICAgICAgICB2YXIgbWV0YWRhdGEgPSBDb250ZXh0LlByb3BlcnR5TWV0YWRhdGEoKTtcclxuICAgICAgICAgICAgdmFyIHByb3BGcm9tID0gRWxlV2lzZS5FTE1BLkRhdGFDbGFzc0hlbHBlci5DbG9uZTxJUHJvcGVydHlNZXRhZGF0YT4obWV0YWRhdGEpO1xyXG4gICAgICAgICAgICBwcm9wRnJvbS5UeXBlVWlkID0gVHlwZVVpZDtcclxuICAgICAgICAgICAgcHJvcEZyb20uTmFtZSA9IHN0cmluZy5Gb3JtYXQoXCJ7MH1fRnJvbVwiLG5hbWUpO1xyXG4gICAgICAgICAgICBwcm9wRnJvbS5TZXR0aW5ncyA9IGF0dHJpYnV0ZXMuVHlwZVNldHRpbmdzO1xyXG4gICAgICAgICAgICBDb250ZXh0LlByb3BlcnR5RnJvbSA9IHByb3BGcm9tO1xyXG5cclxuICAgICAgICAgICAgdmFyIHByb3BUbyA9IEVsZVdpc2UuRUxNQS5EYXRhQ2xhc3NIZWxwZXIuQ2xvbmU8SVByb3BlcnR5TWV0YWRhdGE+KG1ldGFkYXRhKTtcclxuICAgICAgICAgICAgcHJvcFRvLlR5cGVVaWQgPSBUeXBlVWlkO1xyXG4gICAgICAgICAgICBwcm9wVG8uTmFtZSA9IHN0cmluZy5Gb3JtYXQoXCJ7MH1fVG9cIixuYW1lKTtcclxuICAgICAgICAgICAgcHJvcFRvLlNldHRpbmdzID0gYXR0cmlidXRlcy5UeXBlU2V0dGluZ3M7XHJcbiAgICAgICAgICAgIENvbnRleHQuUHJvcGVydHlUbyA9IHByb3BUbztcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0YLQuNC/0LAg0Y3Qu9C10LzQtdC90YLQsCDQtNC40LDQv9Cw0LfQvtC90LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHByb3RlY3RlZCBhYnN0cmFjdCBHdWlkIFR5cGVVaWQgeyBnZXQ7IH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5BYnN0cmFjdGlvbnMuTWV0YWRhdGEuTW9kZWxzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5BYnN0cmFjdGlvbnMuTWV0YWRhdGEuTW9kZWxzLk1ldGFkYXRhO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5EaWFnbm9zdGljcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICAvLy8gPGluaGVyaXRkb2MgY3JlZj1cIklDb250ZXh0Q3JlYXRpb25XaXRoTW9kZWxQYXJhbWV0ZXJzXCIvPlxyXG4gICAgcHVibGljIHNlYWxlZCBjbGFzcyBDb250ZXh0Q3JlYXRpb25XaXRoTW9kZWxQYXJhbWV0ZXJzIDogQ29udGV4dENyZWF0aW9uUGFyYW1ldGVycywgSUNvbnRleHRDcmVhdGlvbldpdGhNb2RlbFBhcmFtZXRlcnNcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZpZXdNb2RlbFwiPtCc0L7QtNC10LvRjDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiaW5uZXJTdGFja1wiPtCS0L3Rg9GC0YDQtdC90L3QuNC5INGB0YLQtdC6INC00L7Qv9C+0LvQvdC40YLQtdC70YzQvdGL0YUg0LTQsNC90L3Ri9GFINC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJvdXRlclN0YWNrXCI+0JLQvdC10YjQvdC40Lkg0YHRgtC10Log0LTQvtC/0L7Qu9C90LjRgtC10LvRjNC90YvRhSDQtNCw0L3QvdGL0YUg0LrQvtC80L/QvtC90LXQvdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGFkYXRhXCI+0JzQtdGC0LDQtNCw0L3QvdGL0LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGFkYXRhVWlkXCI+0KPQvdC40LrQsNC70YzQvdGL0Lkg0LjQtNC10L3RgtGE0LjQutCw0YLQvtGAINC80LXRgtCw0LTQsNC90L3Ri9GFPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXRhZGF0YVR5cGVVaWRcIj7Qo9C90LjQutCw0LvRjNC90YvQuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRgtC40L/QsCDQvNC10YLQsNC00LDQvdC90YvRhTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWV0YWRhdGFNb2R1bGVVaWRcIj7Qo9C90LjQutCw0LvRjNC90YvQuSDQuNC00LXQvdGC0YTQuNC60LDRgtC+0YAg0LzQvtC00YPQu9GPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2RlbFwiPtCc0L7QtNC10LvRjDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibW9kZWxUeXBlXCI+0KLQuNC/INC80L7QtNC10LvQuDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmlld01vZGVsTWV0YWRhdGFcIj7QnNC10YLQsNC00LDQvdC90YvQtSDQvNC+0LTQtdC70Lgg0L7RgtC+0LHRgNCw0LbQtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYWRkaXRpb25hbFZpZXdNb2RlbFByb3BlcnR5SW5mb1wiPtCU0L7Qv9C+0LvQvdC40YLQtdC70YzQvdCw0Y8g0LjQvdGE0L7RgNC80LDRhtC40Y8g0L/QviDRgdCy0L7QudGB0YLQstCw0Lwg0LzQvtC00LXQu9C4INC+0YLQvtCx0YDQsNC20LXQvdC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBDb250ZXh0Q3JlYXRpb25XaXRoTW9kZWxQYXJhbWV0ZXJzKFxyXG4gICAgICAgICAgICBJVmlld01vZGVsIHZpZXdNb2RlbCxcclxuICAgICAgICAgICAgSURhdGFTdGFjayBpbm5lclN0YWNrLFxyXG4gICAgICAgICAgICBJRGF0YVN0YWNrIG91dGVyU3RhY2ssXHJcbiAgICAgICAgICAgIENsYXNzTWV0YWRhdGEgbWV0YWRhdGEsXHJcbiAgICAgICAgICAgIEd1aWQgbWV0YWRhdGFVaWQsXHJcbiAgICAgICAgICAgIEd1aWQgbWV0YWRhdGFUeXBlVWlkLFxyXG4gICAgICAgICAgICBHdWlkIG1ldGFkYXRhTW9kdWxlVWlkLFxyXG4gICAgICAgICAgICBvYmplY3QgbW9kZWwsXHJcbiAgICAgICAgICAgIE1vZGVsVHlwZSBtb2RlbFR5cGUsXHJcbiAgICAgICAgICAgIERhdGFDbGFzc01ldGFkYXRhIHZpZXdNb2RlbE1ldGFkYXRhLFxyXG4gICAgICAgICAgICBJQ29sbGVjdGlvbjxWaWV3TW9kZWxQcm9wZXJ0eUluZm8+IGFkZGl0aW9uYWxWaWV3TW9kZWxQcm9wZXJ0eUluZm8gPSBudWxsXHJcbiAgICAgICAgKSA6IGJhc2Uodmlld01vZGVsLCBpbm5lclN0YWNrLCBvdXRlclN0YWNrLCBtZXRhZGF0YSwgbWV0YWRhdGFVaWQsIG1ldGFkYXRhVHlwZVVpZCwgbWV0YWRhdGFNb2R1bGVVaWQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250cmFjdC5Bcmd1bWVudE5vdE51bGwobW9kZWwsIFwibW9kZWxcIik7XHJcblxyXG4gICAgICAgICAgICBNb2RlbCA9IG1vZGVsO1xyXG4gICAgICAgICAgICBNb2RlbFR5cGUgPSBtb2RlbFR5cGU7XHJcbiAgICAgICAgICAgIFZpZXdNb2RlbE1ldGFkYXRhID0gdmlld01vZGVsTWV0YWRhdGE7XHJcbiAgICAgICAgICAgIEFkZGl0aW9uYWxWaWV3TW9kZWxQcm9wZXJ0eUluZm8gPSBhZGRpdGlvbmFsVmlld01vZGVsUHJvcGVydHlJbmZvID8/IG5ldyBMaXN0PFZpZXdNb2RlbFByb3BlcnR5SW5mbz4oKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBvYmplY3QgTW9kZWwgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBNb2RlbFR5cGUgTW9kZWxUeXBlIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgRGF0YUNsYXNzTWV0YWRhdGEgVmlld01vZGVsTWV0YWRhdGEgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJQ29sbGVjdGlvbjxWaWV3TW9kZWxQcm9wZXJ0eUluZm8+IEFkZGl0aW9uYWxWaWV3TW9kZWxQcm9wZXJ0eUluZm8geyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcbiAgICB9XHJcbn0iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvbGxlY3Rpb25zO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld3M7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLkNvcmUuUmVhY3QuTW9kZWxzXHJcbntcclxuICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgSGlkZUVtcHR5Q29udGFpbmVyTW9kZWwgOiBIaWRlRW1wdHlNb2RlbCwgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXJNb2RlbCBzdG9yYWdlO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSVZpZXdJdGVtIHZpZXdJdGVtO1xyXG4gICAgICAgIHByaXZhdGUgSUNvbGxlY3Rpb248RnVuYzxib29sPj4gc3Vic2NyaWJlckxpc3Q7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gY3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY29udGFpbmVyTW9kZWxcIj7QmtC+0L3RgtC10LnQvdC10YAgVmlld0l0ZW0t0L7QsiDRgSDQvdCw0YHRgtGA0L7QudC60L7QuSBIaWRlRW1wdHk8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInZpZXdJdGVtXCI+0JzQvtC00LXQu9GMINC/0YDQtdC00YHRgtCw0LLQu9C10L3QuNGPPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgSGlkZUVtcHR5Q29udGFpbmVyTW9kZWwoSUhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyTW9kZWwgY29udGFpbmVyTW9kZWwsIElWaWV3SXRlbSB2aWV3SXRlbSwgSUhpZGVFbXB0eUNvbnRhaW5lck1vZGVsIG93bmVyKSA6IGJhc2Uob3duZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBzdWJzY3JpYmVyTGlzdCA9IG5ldyBSZWFjdGl2ZUNvbGxlY3Rpb248RnVuYzxib29sPj4oKTtcclxuICAgICAgICAgICAgc3RvcmFnZSA9IGNvbnRhaW5lck1vZGVsO1xyXG4gICAgICAgICAgICB0aGlzLnZpZXdJdGVtID0gdmlld0l0ZW07XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBvdmVycmlkZSB2b2lkIEluaXQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYmFzZS5Jbml0KCk7XHJcbiAgICAgICAgICAgIHN0b3JhZ2UuQWRkSGlkZUVtcHR5KHZpZXdJdGVtLCB0aGlzKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIHZvaWQgRGVzdHJveSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBiYXNlLkRlc3Ryb3koKTtcclxuICAgICAgICAgICAgc3RvcmFnZS5SZW1vdmVIaWRlRW1wdHkodmlld0l0ZW0pO1xyXG4gICAgICAgICAgICBzdWJzY3JpYmVyTGlzdCA9IG51bGw7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEFkZElzSGlkZGVuKEZ1bmM8Ym9vbD4gaXNIaWRkZW4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoc3Vic2NyaWJlckxpc3QgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgc3Vic2NyaWJlckxpc3QuQWRkKChGdW5jPGJvb2w+KWlzSGlkZGVuKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBSZW1vdmVJc0hpZGRlbihGdW5jPGJvb2w+IGlzSGlkZGVuKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKHN1YnNjcmliZXJMaXN0ICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHN1YnNjcmliZXJMaXN0LlJlbW92ZSgoRnVuYzxib29sPilpc0hpZGRlbik7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHJvdGVjdGVkIG92ZXJyaWRlIGJvb2wgR2V0SGlkZGVuVmFsdWUoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIFN5c3RlbS5MaW5xLkVudW1lcmFibGUuQWxsPEZ1bmM8Ym9vbD4+KHN1YnNjcmliZXJMaXN0LChGdW5jPEZ1bmM8Ym9vbD4sYm9vbD4pKGkgPT4gaSgpKSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCc0L7QtNC10LvRjCDQtNC70Y8gVmlld01vZGVsLCDRgyDQutC+0YLQvtGA0YvRhSDQsiDQutC+0L3RgtGA0L7Qu9C70LXRgNC1INGA0LXQsNC70LjQt9C+0LLQsNC9INC40L3RgtC10YDRhNC10LnRgSBJSGlkZWFibGVcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgVmlld0l0ZW1IaWRlRW1wdHlNb2RlbCA6IEhpZGVFbXB0eU1vZGVsXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJSGlkZWFibGUgaGlkZWFibGU7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJVmlld01vZGVsIHJlbmRlck93bmVyO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIGN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInJlbmRlck93bmVyXCI+0JrQvtC80L/QvtC90LXQvdGCLCDQsiDQutC+0YLQvtGA0L7QvCDRgNC10L3QtNC10YDQuNGC0YHRjyDRgtC10LrRg9GJ0LDRjyDQvNC+0LTQtdC70Yw8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImhpZGVhYmxlXCI+0JrQvtC90YLRgNC+0LvQu9C10YAg0YEg0LzQtdGC0L7QtNC+0Lwg0YHQutGA0YvRgtC40Y8g0LrQvtC80L/QvtC90LXQvdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImhpZGVFbXB0eU1vZGVsXCI+0JzQvtC00LXQu9GMINGBINC90LDRgdGC0YDQvtC50LrQvtC5IEhpZGVFbXB0eTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFZpZXdJdGVtSGlkZUVtcHR5TW9kZWwoSVZpZXdNb2RlbCByZW5kZXJPd25lciwgSUhpZGVhYmxlIGhpZGVhYmxlLCBJSGlkZUVtcHR5Q29udGFpbmVyTW9kZWwgaGlkZUVtcHR5TW9kZWwpIDogYmFzZShoaWRlRW1wdHlNb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMuaGlkZWFibGUgPSBoaWRlYWJsZTtcclxuICAgICAgICAgICAgdGhpcy5yZW5kZXJPd25lciA9IHJlbmRlck93bmVyO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwcm90ZWN0ZWQgb3ZlcnJpZGUgYm9vbCBHZXRIaWRkZW5WYWx1ZSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBHbG9iYWxTY29wZUhlbHBlci5QdXNoKHJlbmRlck93bmVyKTtcclxuICAgICAgICAgICAgdHJ5XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBoaWRlYWJsZS5Jc0hpZGRlbigpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgR2xvYmFsU2NvcGVIZWxwZXIuUG9wKHJlbmRlck93bmVyKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5TZXJ2aWNlcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkRpc3BhdGNoZXI7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5IZWxwZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuSW9jO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLk1ldGFkYXRhO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuU2VyaWFsaXphdGlvbjtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vIFZpZXdNb2RlbCDQtNC70Y8g0LrQvtC80L/QvtC90LXQvdGC0L7QsiDRgNC10LDQu9C40LfRg9GO0YnQuNGFINC+0YLQvtCx0YDQsNC20LXQvdC40LUg0LHQsNC30L7QstGL0YUg0YLQuNC/0L7QsiDQtNCw0L3QvdGL0YVcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBwdWJsaWMgY2xhc3MgQmFzZUlucHV0Vmlld01vZGVsIDogVmlld01vZGVsLCBJVmlld01vZGVsSGFuZGxlclxyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgSUNvbXBvbmVudENvbnRhaW5lciBjb21wb25lbnRTZXR0aW5ncztcclxuXHJcbiAgICAgICAgcHVibGljIEJhc2VJbnB1dFZpZXdNb2RlbChcclxuICAgICAgICAgICAgSVZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlIHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJTGF6eTxJVmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZT4gdmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSwgXHJcbiAgICAgICAgICAgIElSZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlIHJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UsXHJcbiAgICAgICAgICAgIElEaXNwYXRjaGVyIGRpc3BhdGNoZXJcclxuICAgICAgICApIDogYmFzZSh2aWV3TW9kZWxDcmVhdG9yU2VydmljZSwgdmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSwgcmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSwgZGlzcGF0Y2hlcilcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgSUNvbXBvbmVudENvbnRhaW5lciBDb21wb25lbnRcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAoY29tcG9uZW50U2V0dGluZ3MgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRTZXR0aW5ncyA9IG5ldyBJbnB1dENvbXBvbmVudENvbnRhaW5lcih0aGlzKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIHJldHVybiBjb21wb25lbnRTZXR0aW5ncztcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuLy8vIDxzdW1tYXJ5PlxyXG4vLy8g0KHQvtCx0YvRgtC40LUg0L3QsCDQstCy0L7QtCDQt9C90LDRh9C10L3QuNGPINCyINC40L3Qv9GD0YLQtVxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wdWJsaWMgRnVuYzxJS2V5Ym9hcmRFdmVudCwgVGFzaz4gT25LZXlQcmVzc1xyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gKChJQmFzZUlucHV0cylJbnB1dE1vZGVsLklucHV0cykuT25LZXlQcmVzcztcclxuICAgIH1cclxufS8vLyA8c3VtbWFyeT5cclxuLy8vINCh0L7QsdGL0YLQuNC1INC/0YDQuCDQv9C+0YLQtdGA0LUg0YTQvtC60YPRgdC1XHJcbi8vLyA8L3N1bW1hcnk+XHJcbnB1YmxpYyBGdW5jPElGb2N1c0V2ZW50LCBUYXNrPiBPbkZvY3VzXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoKElCYXNlSW5wdXRzKUlucHV0TW9kZWwuSW5wdXRzKS5PbkZvY3VzO1xyXG4gICAgfVxyXG59Ly8vIDxzdW1tYXJ5PlxyXG4vLy8g0KHQvtCx0YvRgtC40LUg0L/RgNC4INC/0L7RgtC10YDQtSDRhNC+0LrRg9GB0LAg0LIg0LjQvdC/0YPRgtC1XHJcbi8vLyA8L3N1bW1hcnk+XHJcbnB1YmxpYyBGdW5jPElDaGFuZ2VFdmVudCwgVGFzaz4gT25CbHVyXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoKElCYXNlSW5wdXRzKUlucHV0TW9kZWwuSW5wdXRzKS5PbkJsdXI7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAjcmVnaW9uIElWaWV3TW9kZWxIYW5kbGVyXHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEFmdGVyVmlldygpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDbGVhckNhY2hlVmFsdWUoKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEFmdGVyQWN0aW9uKClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIENsZWFyQ2FjaGVWYWx1ZSgpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBvYmplY3QgdmFsdWU7XHJcbiAgICAgICAgcHJpdmF0ZSBib29sIGhhc1ZhbHVlTW9kZWw7XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBDbGVhckNhY2hlVmFsdWUoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFsdWUgPSBudWxsO1xyXG4gICAgICAgICAgICBoYXNWYWx1ZU1vZGVsID0gZmFsc2U7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIHByb3RlY3RlZCBvdmVycmlkZSB2b2lkIEdlbmVyYXRlQ29udGV4dChUeXBlIHR5cGVDb250ZXh0KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKHR5cGVDb250ZXh0ID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGNvbnRleHQgPSAoSUJhc2VDb250ZXh0KUFjdGl2YXRvci5DcmVhdGVJbnN0YW5jZSh0eXBlQ29udGV4dCk7XHJcblxyXG4gICAgICAgICAgICB2YXIgY29udGV4dFR5cGUgPSBjb250ZXh0LkdldFR5cGUoKTtcclxuICAgICAgICAgICAgdmFyIHByb3BlcnRpZXMgPSBjb250ZXh0VHlwZS5HZXRQcm9wZXJ0aWVzKCk7XHJcbiAgICAgICAgICAgIHZhciBiYXNlVHlwZSA9IGNvbnRleHRUeXBlLkJhc2VUeXBlO1xyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgcHJvcGVydHkgaW4gcHJvcGVydGllcylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgLy/RgdC00LXQu9Cw0YLRjCDQstC+0LfQvNC+0LbQvdC+0YHRgtGMINGA0LXQt9C+0LvQstCwINGC0LjQv9C+0LIg0L/QviDRg9C40LTRg1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IHByb3BlcnR5Lk5hbWU7XHJcbiAgICAgICAgICAgICAgICBpZiAocHJvcGVydHlOYW1lID09IFwiTW9kZWxcIilcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgYmFzZUdldEZ1bmMgPSBjb250ZXh0LkdldEZ1bmM7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGV4dC5HZXRGdW5jID0gKCkgPT4gXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBpZiAoaGFzVmFsdWVNb2RlbClcclxuICAgICAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHZhbHVlO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhbHVlID0gKChJQmFzZUlucHV0cylJbnB1dE1vZGVsLklucHV0cykuR2V0RnVuYygpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBoYXNWYWx1ZU1vZGVsID0gdHJ1ZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuIHZhbHVlO1xyXG4gICAgICAgICAgICAgICAgICAgIH07XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRpbnVlO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgaWYgKHByb3BlcnR5TmFtZSA9PSBcIkdldEZ1bmNcIiB8fCBwcm9wZXJ0eU5hbWUgPT0gXCJTZXRGdW5jXCIpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGV4dC5TZXRQcm9wZXJ0eVZhbHVlKHByb3BlcnR5TmFtZSwgR2V0SW5wdXQocHJvcGVydHlOYW1lKSk7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBpZiAoYmFzZVR5cGUuR2V0UHJvcGVydHkocHJvcGVydHlOYW1lKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBpbmZvID0gbmV3IFByb3BlcnR5SW5mb0V4cHJlc3Npb25cclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIE9iamVjdEV4cHJlc3Npb24gPSBwcm9wZXJ0eU5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIEV4cHJlc3Npb25Gb3JTZXJpYWxpemUgPSBwcm9wZXJ0eU5hbWVcclxuICAgICAgICAgICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICAgICAgICAgIENvbnZlcnRIZWxwZXIuUmVkZWZpbmVQcm9wKGNvbnRleHQsIGluZm8sIChGdW5jPG9iamVjdD4pKCgpID0+IEdldElucHV0KHByb3BlcnR5TmFtZSkpKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIGVsc2VcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgdmFsdWUgPSBjb250ZXh0LkdldFByb3BlcnR5VmFsdWUocHJvcGVydHlOYW1lLCBEZWZhdWx0VmFsdWVIZWxwZXIuR2V0VHlwZURlZmF1bHRWYWx1ZShwcm9wZXJ0eS5Qcm9wZXJ0eVR5cGUpKTtcclxuICAgICAgICAgICAgICAgICAgICBEZWZpbmVQcm9wZXJ0eShjb250ZXh0LCBuZXcgUHJvcGVydHlJbmZvRXhwcmVzc2lvblxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgT2JqZWN0RXhwcmVzc2lvbiA9IHByb3BlcnR5TmFtZSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgRXhwcmVzc2lvbkZvclNlcmlhbGl6ZSA9IHByb3BlcnR5TmFtZVxyXG4gICAgICAgICAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbnRleHQuU2V0UHJvcGVydHlWYWx1ZShwcm9wZXJ0eU5hbWUsIHZhbHVlKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgQ29udGV4dCA9IGNvbnRleHQ7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIEVsZVdpc2UuRUxNQS5Jb2MuQWJzdHJhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHNcclxue1xyXG4gICAgaW50ZXJuYWwgY2xhc3MgSW5wdXRNb2RlbCA6IFJlYWN0aXZlLCBJUmVhY3RJbnB1dE1vZGVsXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC70Y7Rh1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBLZXkgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIFZpZXdNb2RlbCDRgNC+0LTQuNGC0LXQu9GPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSVZpZXdNb2RlbCBPd25lciB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQvdC/0YPRgtGLXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSUlucHV0cyBJbnB1dHMgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LXQutGD0YnQuNC5IFNjb3BlXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSUxpZmV0aW1lU2NvcGUgUm9vdFNjb3BlIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQlNCw0L3QvdGL0LUg0LIg0YHRgtC10LrQtVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIElEYXRhU3RhY2sgRGF0YVN0YWNrIHsgZ2V0OyBzZXQ7IH1cclxuICAgIH1cclxuICAgIFxyXG4gICAgaW50ZXJuYWwgY2xhc3MgSW5wdXRNb2RlbDxUSW5wdXRzPiA6IElucHV0TW9kZWwsIElSZWFjdElucHV0TW9kZWw8VElucHV0cz5cclxuICAgICAgICB3aGVyZSBUSW5wdXRzIDogSUlucHV0c1xyXG4gICAge1xyXG4gICAgICAgIHB1YmxpYyBuZXcgVElucHV0cyBJbnB1dHMgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICBJSW5wdXRzIElJbnB1dE1vZGVsLklucHV0c1xyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0IHsgcmV0dXJuIElucHV0czsgfVxyXG4gICAgICAgICAgICBzZXQgeyBJbnB1dHMgPSAoVElucHV0cyl2YWx1ZTsgfVxyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5MaW5xO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBCcmlkZ2UuSHRtbDU7XHJcbnVzaW5nIEJyaWRnZS5SZWFjdDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbnRyb2xsZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5IZWxwZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Nb2RlbHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlZpZXdzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuQWN0aW9ucztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxudXNpbmcgSFRNTEVsZW1lbnRNb3VzZUV2ZW50ID0gQnJpZGdlLlJlYWN0Lk1vdXNlRXZlbnQ8QnJpZGdlLkh0bWw1LkhUTUxFbGVtZW50PjtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQutC+0LzQv9C+0L3QtdC90YIg0LTQu9GPINC+0YLRgNC40YHQvtCy0LrQuCBWaWV3SXRlbVxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUVmlld0l0ZW1cIj7QotC40L8g0L/RgNC10LTRgdGC0LDQstC70LXQvdC40Y88L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUSW5wdXRzXCI+0KLQuNC/INC40L3Qv9GD0YLQvtCyPC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVENvbnRleHRcIj7QotC40L8g0LrQvtC90YLQtdC60YHRgtCwPC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVENvbnRyb2xsZXJcIj7QotC40L8g0LrQvtC90YLRgNC+0LvQu9C10YDQsDwvdHlwZXBhcmFtPlxyXG4gICAgW0NvbXBvbmVudF1cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlVmlld0l0ZW1Db21wb25lbnQ8VFZpZXdJdGVtLCBUSW5wdXRzLCBUQ29udGV4dCwgVENvbnRyb2xsZXI+IDogQmFzZVJlYWN0Q29tcG9uZW50PFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj5cclxuICAgICAgICB3aGVyZSBUVmlld0l0ZW0gOiBJVmlld0l0ZW1cclxuICAgICAgICB3aGVyZSBUSW5wdXRzIDogSUlucHV0c1xyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgICAgICB3aGVyZSBUQ29udHJvbGxlciA6IElDb250cm9sbGVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBjdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2RlbFwiPtCS0YXQvtC00L3QsNGPINC80L7QtNC10LvRjDwvcGFyYW0+XHJcbiAgICAgICAgcHJvdGVjdGVkIEJhc2VWaWV3SXRlbUNvbXBvbmVudChJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWw8VFZpZXdJdGVtLCBUSW5wdXRzPiBtb2RlbCkgOiBiYXNlKG1vZGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICB9XHJcbnB1YmxpYyBUVmlld0l0ZW0gVmlld0l0ZW1cclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIChUVmlld0l0ZW0pVmlld01vZGVsLlZpZXdJdGVtO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHJvdGVjdGVkIG92ZXJyaWRlIHZvaWQgQ29tcG9uZW50V2lsbFJlYWN0KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGJhc2UuQ29tcG9uZW50V2lsbFJlYWN0KCk7XHJcblxyXG4gICAgICAgICAgICAvL0NvbnNvbGUuV3JpdGVMaW5lKFNSLlQoXCJDb21wb25lbnRXaWxsUmVhY3Q6ezB9LCBrZXk6IHsxfSwgbmFtZTogezJ9LCB1aWQ6IHszfVwiLCBcclxuICAgICAgICAgICAgLy8gICAgdGhpc1tcIl9fcHJvdG9fX1wiXVtcIiQkZnVsbG5hbWVcIl0sIFxyXG4gICAgICAgICAgICAvLyAgICBwcm9wcy5Nb2RlbC5LZXksIFxyXG4gICAgICAgICAgICAvLyAgICBwcm9wcy5Nb2RlbFtcIlZpZXdJdGVtXCJdW1wiTmFtZVwiXSwgXHJcbiAgICAgICAgICAgIC8vICAgIHByb3BzLk1vZGVsW1wiVmlld0l0ZW1cIl1bXCJVaWRcIl0uVG9TdHJpbmcoKSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHJvdGVjdGVkIG92ZXJyaWRlIFRhc2sgQ29tcG9uZW50V2lsbFVubW91bnQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKHRpbWVvdXRJZCAhPSAwKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBXaW5kb3cuQ2xlYXJUaW1lb3V0KHRpbWVvdXRJZCk7XHJcbiAgICAgICAgICAgICAgICB0aW1lb3V0SWQgPSAwO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gYmFzZS5Db21wb25lbnRXaWxsVW5tb3VudCgpO1xyXG4gICAgICAgIH1cclxuLy8vIDxzdW1tYXJ5PlxyXG4vLy8g0KLQuNC/IFZpZXdNb2RlbFxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgb3ZlcnJpZGUgVHlwZSBUeXBlVmlld01vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiB0eXBlb2YoVmlld0l0ZW1WaWV3TW9kZWwpO1xyXG4gICAgfVxyXG59Ly8vIDxzdW1tYXJ5PlxyXG4vLy8gVmlld01vZGVsINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbi8vLyA8L3N1bW1hcnk+XHJcbnByb3RlY3RlZCBuZXcgSVJlYWN0Vmlld0l0ZW1WaWV3TW9kZWwgVmlld01vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoSVJlYWN0Vmlld0l0ZW1WaWV3TW9kZWwpTW9kZWw7XHJcbiAgICB9XHJcbn0vLy8gPHN1bW1hcnk+XHJcbi8vLyDQktGF0L7QtNC90LDRjyDQvNC+0LTQtdC70YxcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIElSZWFjdFZpZXdJdGVtSW5wdXRNb2RlbDxUVmlld0l0ZW0sIFRJbnB1dHM+IFZpZXdJdGVtSW5wdXRNb2RlbFxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gKElSZWFjdFZpZXdJdGVtSW5wdXRNb2RlbDxUVmlld0l0ZW0sIFRJbnB1dHM+KXByb3BzLk1vZGVsO1xyXG4gICAgfVxyXG59Ly8vIDxzdW1tYXJ5PlxyXG4vLy8g0KTQu9Cw0LMg0L7RgtGA0LjRgdC+0LLQutC4INCx0LDQt9C+0LLQvtCz0L4g0LrQvtC90YLQtdC50L3QtdGA0LBcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIHZpcnR1YWwgYm9vbCBVc2VDdXN0b21Db250YWluZXJcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGZhbHNlO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBIdG1sLdGN0LvQtdC80LXQvdGCINC60L7QvdGC0LXQudC90LXRgNCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgSFRNTEVsZW1lbnQgQ29udGVudEVsZW1lbnQ7XHJcblxyXG4gICAgICAgIHByaXZhdGUgYm9vbCBpc0FjdGl2YXRlZCA9IGZhbHNlO1xyXG4gICAgICAgIHByaXZhdGUgaW50IHRpbWVvdXRJZDtcclxuICAgICAgICBwcml2YXRlIHN0YXRpYyBzdHJpbmcgdmlld0l0ZW1OYW1lID0gdHlwZW9mKFRWaWV3SXRlbSkuTmFtZTtcclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgaW50ZXJuYWwgc2VhbGVkIG92ZXJyaWRlIFJlYWN0RWxlbWVudCBSZW5kZXJJbnRlcm5hbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoVXNlQ3VzdG9tQ29udGFpbmVyKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gYmFzZS5SZW5kZXJJbnRlcm5hbCgpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgY2xhc3NOYW1lID0gXCJ2aWV3aXRlbS1jb250ZW50XCI7XHJcbklNZXRhZGF0YVZpZXdNb2RlbCBtZXRhZGF0YVZpZXdNb2RlbDsgICAgICAgICAgICB2YXIgZGVzaWduTW9kZSA9IChtZXRhZGF0YVZpZXdNb2RlbCA9IFZpZXdNb2RlbC5SZW5kZXJPd25lciBhcyBJTWV0YWRhdGFWaWV3TW9kZWwpICE9IG51bGwmJlxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgIG1ldGFkYXRhVmlld01vZGVsLklzRGVzaWduTW9kZTtcclxuXHJcbiAgICAgICAgICAgIHZhciBoaWRlRW1wdHkgPSBmYWxzZTtcclxuSUhpZGVFbXB0eVZpZXdJdGVtVmlld01vZGVsIGhpZGVFbXB0eVZpZXdJdGVtVmlld01vZGVsOyAgICAgICAgICAgIGlmICgoaGlkZUVtcHR5Vmlld0l0ZW1WaWV3TW9kZWwgPSBWaWV3TW9kZWwgYXMgSUhpZGVFbXB0eVZpZXdJdGVtVmlld01vZGVsKSAhPSBudWxsJiYgaGlkZUVtcHR5Vmlld0l0ZW1WaWV3TW9kZWwuSGlkZUVtcHR5TW9kZWwgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgaGlkZUVtcHR5ID0gaGlkZUVtcHR5Vmlld0l0ZW1WaWV3TW9kZWwuSGlkZUVtcHR5TW9kZWwuSXNFbXB0eTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKChWaWV3SXRlbSAhPSBudWxsICYmIFZpZXdJdGVtLkhpZGUpIHx8IGhpZGVFbXB0eSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgLy/QodC60YDRi9Cy0LDQtdC8INC60L7QvdGC0LXQvdGCINC/0L4g0L/QsNGA0LDQvNC10YLRgNGDXHJcbiAgICAgICAgICAgICAgICBjbGFzc05hbWUgKz0gXCItLWhpZGVcIjtcclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoIWRlc2lnbk1vZGUpXHJcbiAgICAgICAgICAgICAgICB7XHJcbklWaWV3SXRlbUxvYWRpbmcgaXRlbTsgICAgICAgICAgICAgICAgICAgIGlmICgoaXRlbSA9IFZpZXdJdGVtIGFzIElWaWV3SXRlbUxvYWRpbmcpICE9IG51bGwmJiAoaXRlbS5Mb2FkaW5nVHlwZSA9PSBWaWV3SXRlbUxvYWRpbmdUeXBlLlN5bmNMb2FkaW5nIHx8IGl0ZW0uTG9hZGluZ1R5cGUgPT0gVmlld0l0ZW1Mb2FkaW5nVHlwZS5MYXp5TG9hZGluZykgfHwgaGlkZUVtcHR5KVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaXNBY3RpdmF0ZWQgPSB0cnVlO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlzQWN0aXZhdGVkID0gdHJ1ZTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgUmVhY3RFbGVtZW50IGNvbnRlbnQgPSBudWxsO1xyXG4gICAgICAgICAgICBpZiAoaXNBY3RpdmF0ZWQpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNvbnRlbnQgPSBkZXNpZ25Nb2RlID8gRGVzaWduVGltZVZpZXcoKSA6IGJhc2UuUmVuZGVySW50ZXJuYWwoKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGF0dHJpYnV0ZXMgPSBuZXcgQXR0cmlidXRlc1xyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBLZXkgPSBcInZpZXdpdGVtLWNvbnRlbnRcIixcclxuICAgICAgICAgICAgICAgIENsYXNzTmFtZSA9IGNsYXNzTmFtZSArIHN0cmluZy5Gb3JtYXQoXCIgZm9ybS1lbGVtZW50LXdyYXAtLXswfVwiLHZpZXdJdGVtTmFtZSksXHJcbiAgICAgICAgICAgICAgICBSZWYgPSBTZXRSZWZcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIGlmIChWaWV3TW9kZWwuVGVzdElkRW5hYmxlZCgpKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBhdHRyaWJ1dGVzLkRhdGEgPSBuZXcgeyB0ZXN0aWQgPSBWaWV3SXRlbS5UZXN0SWQgfTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKFZpZXdJdGVtICE9IG51bGwgJiYgKChWaWV3SXRlbS5Pbk1vdXNlRW50ZXIgIT0gbnVsbCAmJiAhVmlld0l0ZW0uT25Nb3VzZUVudGVyLklzRW1wdHkpIHx8IChWaWV3SXRlbS5Pbk1vdXNlTGVhdmUgIT0gbnVsbCAmJiAhVmlld0l0ZW0uT25Nb3VzZUxlYXZlLklzRW1wdHkpKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgYXR0cmlidXRlcy5Pbk1vdXNlRW50ZXIgPSBHZXRPbk1vdXNlRW50ZXIoKTtcclxuICAgICAgICAgICAgICAgIGF0dHJpYnV0ZXMuT25Nb3VzZUxlYXZlID0gR2V0T25Nb3VzZUxlYXZlKCk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBvbktleURvd24gPSBHZXRPbktleURvd24oKTtcclxuICAgICAgICAgICAgaWYgKG9uS2V5RG93biAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBhdHRyaWJ1dGVzLlRhYkluZGV4ID0gLTE7XHJcbiAgICAgICAgICAgICAgICBhdHRyaWJ1dGVzLk9uS2V5RG93biA9IG9uS2V5RG93bjtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIERPTS5EaXYoYXR0cmlidXRlcywgY29udGVudCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0Ywg0LTQtdC50YHRgtCy0LjQtSDQv9GA0Lgg0L3QsNCy0LXQtNC10L3QuNC4INC90LAg0Y3Qu9C10LzQtdC90YJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIEFjdGlvbjxCcmlkZ2UuUmVhY3QuTW91c2VFdmVudDxIVE1MRWxlbWVudD4+IEdldE9uTW91c2VFbnRlcigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gZSA9PiBJbml0RGVib3VuY2UoVmlld0l0ZW0uT25Nb3VzZUVudGVyKS5JbnZva2UoZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0Ywg0LTQtdC50YHRgtCy0LjQtSDQv9GA0Lgg0L/QtdGA0LXQvNC10YnQtdC90LjQuCDQutGD0YDRgdC+0YDQsCDQt9CwINCz0YDQsNC90LjRhtGLINGN0LvQtdC80LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIEFjdGlvbjxCcmlkZ2UuUmVhY3QuTW91c2VFdmVudDxIVE1MRWxlbWVudD4+IEdldE9uTW91c2VMZWF2ZSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gZSA9PiBJbml0RGVib3VuY2UoVmlld0l0ZW0uT25Nb3VzZUxlYXZlKS5JbnZva2UoZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0Ywg0L/RgNC4INC90LDQttCw0YLQuNC4INC60LvQsNCy0LjRiNC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIHByb3RlY3RlZCB2aXJ0dWFsIEFjdGlvbjxCcmlkZ2UuUmVhY3QuS2V5Ym9hcmRFdmVudDxIVE1MRWxlbWVudD4+IEdldE9uS2V5RG93bigpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgaGFzT25Fc2NhcGUgPSBWaWV3SXRlbS5PbkVzY2FwZSAhPSBudWxsICYmICFWaWV3SXRlbS5PbkVzY2FwZS5Jc0VtcHR5O1xyXG4gICAgICAgICAgICB2YXIgaGFzT25FbnRlciA9IFZpZXdJdGVtLk9uRW50ZXIgIT0gbnVsbCAmJiAhVmlld0l0ZW0uT25FbnRlci5Jc0VtcHR5O1xyXG5cclxuICAgICAgICAgICAgaWYgKGhhc09uRXNjYXBlIHx8IGhhc09uRW50ZXIpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBlID0+IERpc3BhdGNoZXIuRGlzcGF0Y2goKEZ1bmM8VENvbnRyb2xsZXIsVGFzaz4pKGFzeW5jIGMgPT5cclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBpZiAoZS5LZXkgPT0gQnJpZGdlLlJlYWN0LktleWJvYXJkRXZlbnQuTmFtZWRLZXlzLkVzY2FwZSAmJiBoYXNPbkVzY2FwZSlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGF3YWl0IFZpZXdJdGVtLk9uRXNjYXBlLkNhbGwoKTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgZS5TdG9wUHJvcGFnYXRpb24oKTtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKGUuS2V5ID09IEJyaWRnZS5SZWFjdC5LZXlib2FyZEV2ZW50Lk5hbWVkS2V5cy5FbnRlciAmJiBoYXNPbkVudGVyKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgYXdhaXQgVmlld0l0ZW0uT25FbnRlci5DYWxsKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGUuU3RvcFByb3BhZ2F0aW9uKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfSkpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiBudWxsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQntGC0L7QsdGA0LDQttCw0LXQvNGL0Lkg0LrQvtC90YLQtdC90YIg0LIg0YDQtdC20LjQvNC1INC60L7QvdGB0YLRgNGD0LjRgNC+0LLQsNC90LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCe0YLQvtCx0YDQsNC20LDQtdC80YvQuSDQutC+0L3RgtC10L3RgiDQsiDRgNC10LbQuNC80LUg0LrQvtC90YHRgtGA0YPQuNGA0L7QstCw0L3QuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHByb3RlY3RlZCB2aXJ0dWFsIFJlYWN0RWxlbWVudCBEZXNpZ25UaW1lVmlldygpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gYmFzZS5SZW5kZXJJbnRlcm5hbCgpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQoNC10L3QtNC10YAg0LTQvtGH0LXRgNC90LjRhSDRjdC70LXQvNC10L3RgtC+0LIg0YEg0L7QsdC10YDRgtC60LDQvNC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIHByb3RlY3RlZCBSZWFjdEVsZW1lbnQgUmVuZGVyV3JhcHBlZENoaWxkcmVuKEZ1bmM8UmVhY3RFbGVtZW50LCBib29sPiBjb25kaXRpb24gPSBudWxsLCBzdHJpbmcgY2FwdGlvbiA9IFwiXCIpXHJcbiAgICAgICAge1xyXG5JTWV0YWRhdGFWaWV3TW9kZWwgbWV0YWRhdGFWaWV3TW9kZWw7ICAgICAgICAgICAgdmFyIGRlc2lnbk1vZGUgPSAobWV0YWRhdGFWaWV3TW9kZWwgPSBWaWV3TW9kZWwuUmVuZGVyT3duZXIgYXMgSU1ldGFkYXRhVmlld01vZGVsKSAhPSBudWxsJiYgbWV0YWRhdGFWaWV3TW9kZWwuSXNEZXNpZ25Nb2RlO1xyXG4gICAgICAgICAgICBpZiAoIWRlc2lnbk1vZGUpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBuZXcgRnJhZ21lbnQoR2V0Q2hpbGRyZW4oKEZ1bmM8UmVhY3RFbGVtZW50LGJvb2w+KWNvbmRpdGlvbikpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gVmlld01vZGVsLlJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UuQ3JlYXRlPFdyYXBwZXJDb21wb25lbnQ+KFxyXG4gICAgICAgICAgICAgICAgbmV3IFdyYXBwZXJDb21wb25lbnQuV3JhcHBlckNvbXBvbmVudElucHV0c1xyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIFZpZXdJdGVtID0gKCkgPT4gVmlld0l0ZW0sXHJcbiAgICAgICAgICAgICAgICAgICAgQ2FwdGlvbiA9ICgpID0+IGNhcHRpb24sXHJcbiAgICAgICAgICAgICAgICAgICAgQ29udGVudCA9ICgpID0+IEdldENoaWxkcmVuKChGdW5jPFJlYWN0RWxlbWVudCxib29sPiljb25kaXRpb24pXHJcbiAgICAgICAgICAgICAgICB9LFxyXG4gICAgICAgICAgICAgICAgVmlld01vZGVsLlJlbmRlck93bmVyXHJcbiAgICAgICAgICAgICkuVG9SZWFjdEVsZW1lbnQoKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KDQtdC90LTQtdGAINC00L7Rh9C10YDQvdC40YUg0Y3Qu9C10LzQtdC90YLQvtCyINCx0LXQtyDQvtCx0LXRgNGC0L7QulxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwcm90ZWN0ZWQgUmVhY3RFbGVtZW50W10gUmVuZGVyQ2hpbGRyZW4oRnVuYzxSZWFjdEVsZW1lbnQsIGJvb2w+IGNvbmRpdGlvbiA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gR2V0Q2hpbGRyZW4oKEZ1bmM8UmVhY3RFbGVtZW50LGJvb2w+KWNvbmRpdGlvbik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0L3QuNGG0LjQsNC70LjQt9Cw0YbQuNGPINC30LDQtNC10YDQttC60Lgg0LLRi9C30L7QstCwINGB0L7QsdGL0YLQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhY3Rpb25cIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInRpbWVvdXRcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIEFjdGlvbjxIVE1MRWxlbWVudE1vdXNlRXZlbnQ+IEluaXREZWJvdW5jZShEZWZhdWx0QWN0aW9uIGFjdGlvbiwgaW50IHRpbWVvdXQgPSAzMDApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoYWN0aW9uID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBldiA9PiB7IH07XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiB2YWx1ZSA9PiB7XHJcbiAgICAgICAgICAgICAgICBpZiAodGltZW91dElkICE9IDApXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgLy8g0JfQvdCw0YfQuNGCINGC0LDQudC80LDRg9GCINCx0YvQuyDQutC10Lwt0YLQviDQt9Cw0L/Rg9GJ0LXQvSwg0L/RgNC+0YHRgtC+INGH0LjRgdGC0LjQvCDQtdCz0L4uINCU0LXQudGB0YLQstC40LUg0L3QtSDQvdGD0LbQvdC+XHJcbiAgICAgICAgICAgICAgICAgICAgV2luZG93LkNsZWFyVGltZW91dCh0aW1lb3V0SWQpO1xyXG4gICAgICAgICAgICAgICAgICAgIHRpbWVvdXRJZCA9IDA7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdGltZW91dElkID0gV2luZG93LlNldFRpbWVvdXQoXHJcbihBY3Rpb24pICAgICAgICAgICAgICAgICAgICAgICAgbmV3IEFjdGlvbigoKSA9PlxyXG4gICAgICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICB0aW1lb3V0SWQgPSAwO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgRGlzcGF0Y2hlci5EaXNwYXRjaCgoQWN0aW9uPFRDb250cm9sbGVyPikoYyA9PiBPbk1vdXNlRXZlbnQoYWN0aW9uKSkpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB9KSxcclxuICAgICAgICAgICAgICAgICAgICAgICAgdGltZW91dCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH07XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgT25Nb3VzZUV2ZW50KERlZmF1bHRBY3Rpb24gYWN0aW9uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKGFjdGlvbiAhPSBudWxsICYmICFhY3Rpb24uSXNFbXB0eSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgYWN0aW9uLkNhbGwoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBSZWFjdEVsZW1lbnRbXSBHZXRDaGlsZHJlbihGdW5jPFJlYWN0RWxlbWVudCwgYm9vbD4gY29uZGl0aW9uID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBpbnB1dCA9IElucHV0TW9kZWwuSW5wdXRzIGFzIElucHV0cztcclxuICAgICAgICAgICAgaWYgKGlucHV0ICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBQcmVwYXJlQ2hpbGRyZW4oaW5wdXQuQ2hpbGRyZW4sIChGdW5jPFJlYWN0RWxlbWVudCxib29sPiljb25kaXRpb24pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHZhciBpbnB1dEZ1bmMgPSBJbnB1dE1vZGVsLklucHV0cyBhcyBJbnB1dHNDaGlsZHJlbkZ1bmM7XHJcbiAgICAgICAgICAgIGlmIChpbnB1dEZ1bmMgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIFByZXBhcmVDaGlsZHJlbihpbnB1dEZ1bmMuQ2hpbGRyZW4obnVsbCksIChGdW5jPFJlYWN0RWxlbWVudCxib29sPiljb25kaXRpb24pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHZhciBpbnB1dENoaWxkcmVuID0gSW5wdXRNb2RlbC5JbnB1dHMgYXMgSW5wdXRzQ2hpbGRyZW47XHJcbiAgICAgICAgICAgIGlmIChpbnB1dENoaWxkcmVuICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBQcmVwYXJlQ2hpbGRyZW4oKFJlYWN0RWxlbWVudFtdKWlucHV0Q2hpbGRyZW4uQ2hpbGRyZW4sIChGdW5jPFJlYWN0RWxlbWVudCxib29sPiljb25kaXRpb24pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgUmVhY3RFbGVtZW50WzBdO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBSZWFjdEVsZW1lbnRbXSBQcmVwYXJlQ2hpbGRyZW4oUmVhY3RFbGVtZW50W10gY2hpbGRyZW4sIEZ1bmM8UmVhY3RFbGVtZW50LCBib29sPiBjb25kaXRpb24pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoY29uZGl0aW9uID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBjaGlsZHJlbjtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB2YXIgcmVzdWx0ID0gbmV3IFJlYWN0RWxlbWVudFswXTtcclxuICAgICAgICAgICAgZm9yZWFjaCAodmFyIGNoaWxkIGluIGNoaWxkcmVuKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAoIWNvbmRpdGlvbihjaGlsZCkpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICB9XHJcblN5c3RlbS5BcnJheUV4dGVuc2lvbnMuUHVzaDxSZWFjdEVsZW1lbnQ+KCAgICAgICAgICAgICAgICByZXN1bHQsY2hpbGQpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiByZXN1bHQ7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgU2V0UmVmKEhUTUxFbGVtZW50IGVsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQ29udGVudEVsZW1lbnQgPSBlbDtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVZpZXdJdGVtQ29tcG9uZW50PFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQ+IDogQmFzZVZpZXdJdGVtQ29tcG9uZW50PFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQsIEJhc2VSZWFjdENvbnRyb2xsZXI+XHJcbiAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogSVZpZXdJdGVtXHJcbiAgICAgICAgd2hlcmUgVElucHV0cyA6IElJbnB1dHNcclxuICAgICAgICB3aGVyZSBUQ29udGV4dCA6IElDb250ZXh0XHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHJvdGVjdGVkIEJhc2VWaWV3SXRlbUNvbXBvbmVudChJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWw8VFZpZXdJdGVtLCBUSW5wdXRzPiBtb2RlbCkgOiBiYXNlKG1vZGVsKSB7IH1cclxuICAgIH1cclxuXHJcbiAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlVmlld0l0ZW1Db21wb25lbnQ8VFZpZXdJdGVtLCBUQ29udHJvbGxlcj4gOiBCYXNlVmlld0l0ZW1Db21wb25lbnQ8VFZpZXdJdGVtLCBJbnB1dHMsIENvbnRleHQsIFRDb250cm9sbGVyPlxyXG4gICAgICAgIHdoZXJlIFRWaWV3SXRlbSA6IElWaWV3SXRlbVxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwcm90ZWN0ZWQgQmFzZVZpZXdJdGVtQ29tcG9uZW50KElSZWFjdFZpZXdJdGVtSW5wdXRNb2RlbDxUVmlld0l0ZW0sIElucHV0cz4gbW9kZWwpIDogYmFzZShtb2RlbCkgeyB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVZpZXdJdGVtQ29tcG9uZW50PFRWaWV3SXRlbT4gOiBCYXNlVmlld0l0ZW1Db21wb25lbnQ8VFZpZXdJdGVtLCBJbnB1dHMsIENvbnRleHQ+XHJcbiAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogSVZpZXdJdGVtXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHJvdGVjdGVkIEJhc2VWaWV3SXRlbUNvbXBvbmVudChJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWw8VFZpZXdJdGVtLCBJbnB1dHM+IG1vZGVsKSA6IGJhc2UobW9kZWwpIHsgfVxyXG4gICAgfVxyXG59IiwidXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgVmlld0l0ZW1JbnB1dE1vZGVsPFRWaWV3SXRlbSwgVElucHV0cz4gOiBJbnB1dE1vZGVsPFRJbnB1dHM+LCBJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWw8VFZpZXdJdGVtLCBUSW5wdXRzPlxyXG4gICAgICAgIHdoZXJlIFRWaWV3SXRlbSA6IElWaWV3SXRlbVxyXG4gICAgICAgIHdoZXJlIFRJbnB1dHMgOiBJSW5wdXRzXHJcbiAgICB7XHJcbiAgICAgICAgcHVibGljIFRWaWV3SXRlbSBWaWV3SXRlbSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgICNyZWdpb24gSVZpZXdJdGVtSW5wdXRNb2RlbFxyXG5cclxuICAgICAgICBJVmlld0l0ZW0gSVZpZXdJdGVtSW5wdXRNb2RlbC5WaWV3SXRlbVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0IHsgcmV0dXJuIFZpZXdJdGVtOyB9XHJcbiAgICAgICAgICAgIHNldCB7IFZpZXdJdGVtID0gKFRWaWV3SXRlbSl2YWx1ZTsgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5VSS5TZXJ2aWNlcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkRpc3BhdGNoZXI7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Jb2M7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVsc1xyXG57XHJcbiAgICBwdWJsaWMgaW50ZXJmYWNlIElSZWFjdFZpZXdJdGVtVmlld01vZGVsIDogSVZpZXdJdGVtVmlld01vZGVsLCBJUmVhY3RWaWV3TW9kZWxcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCS0LrQu9GO0YfQtdC9INC70Lgg0YDQtdC20LjQvCDQtNC+0LHQsNCy0LvQtdC90LjRjyDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgNC+0LIg0LTQu9GPINGC0LXRgdGC0LjRgNC+0LLQsNC90LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBib29sIFRlc3RJZEVuYWJsZWQoKTtcclxuICAgIH1cclxuXHJcbiAgICBwdWJsaWMgY2xhc3MgVmlld0l0ZW1WaWV3TW9kZWwgOiBWaWV3SXRlbVZpZXdNb2RlbDxJVmlld0l0ZW0+XHJcbiAgICB7XHJcbiAgICAgICAgcHVibGljIFZpZXdJdGVtVmlld01vZGVsKFxyXG4gICAgICAgICAgICBJVmlld01vZGVsQ3JlYXRvclNlcnZpY2Ugdmlld01vZGVsQ3JlYXRvclNlcnZpY2UsXHJcbiAgICAgICAgICAgIElMYXp5PElWaWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlPiB2aWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJRGlzcGF0Y2hlciBkaXNwYXRjaGVyLFxyXG4gICAgICAgICAgICBJQXBwbGljYXRpb25EYXRhIGFwcGxpY2F0aW9uRGF0YVxyXG4gICAgICAgICkgOiBiYXNlKHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlLCB2aWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlLCByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlLCBkaXNwYXRjaGVyLCBhcHBsaWNhdGlvbkRhdGEpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuXHJcbiAgICBwdWJsaWMgY2xhc3MgVmlld0l0ZW1WaWV3TW9kZWw8VFZpZXdJdGVtPiA6IFZpZXdJdGVtVmlld01vZGVsPFRWaWV3SXRlbSwgSUNvbnRleHQsIElDb250cm9sbGVyPlxyXG4gICAgICAgIHdoZXJlIFRWaWV3SXRlbSA6IElWaWV3SXRlbVxyXG4gICAge1xyXG4gICAgICAgIHB1YmxpYyBWaWV3SXRlbVZpZXdNb2RlbChcclxuICAgICAgICAgICAgSVZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlIHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJTGF6eTxJVmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZT4gdmlld0l0ZW1Db21wb25lbnRDcmVhdG9yU2VydmljZSwgXHJcbiAgICAgICAgICAgIElSZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlIHJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UsXHJcbiAgICAgICAgICAgIElEaXNwYXRjaGVyIGRpc3BhdGNoZXIsXHJcbiAgICAgICAgICAgIElBcHBsaWNhdGlvbkRhdGEgYXBwbGljYXRpb25EYXRhXHJcbiAgICAgICAgKSA6IGJhc2Uodmlld01vZGVsQ3JlYXRvclNlcnZpY2UsIHZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2UsIHJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UsIGRpc3BhdGNoZXIsIGFwcGxpY2F0aW9uRGF0YSlcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG5cclxuICAgIHB1YmxpYyBjbGFzcyBWaWV3SXRlbVZpZXdNb2RlbDxUVmlld0l0ZW0sIFRDb250ZXh0LCBUQ29udHJvbGxlcj4gOiBWaWV3TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPiwgSUhpZGVFbXB0eVZpZXdJdGVtVmlld01vZGVsXHJcbiAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogSVZpZXdJdGVtXHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIElDb21wb25lbnRDb250YWluZXIgY29tcG9uZW50U2V0dGluZ3M7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJRGlzcGF0Y2hlciBkaXNwYXRjaGVyO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUFwcGxpY2F0aW9uRGF0YSBhcHBsaWNhdGlvbkRhdGE7XHJcbiAgICAgICAgcHJpdmF0ZSBJSGlkZUVtcHR5TW9kZWwgaGlkZUVtcHR5TW9kZWw7XHJcbnByb3RlY3RlZCBJUmVhY3RWaWV3SXRlbUlucHV0TW9kZWwgVmlld0l0ZW1JbnB1dE1vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoSVJlYWN0Vmlld0l0ZW1JbnB1dE1vZGVsKUlucHV0TW9kZWw7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVmlld0l0ZW1WaWV3TW9kZWwoXHJcbiAgICAgICAgICAgIElWaWV3TW9kZWxDcmVhdG9yU2VydmljZSB2aWV3TW9kZWxDcmVhdG9yU2VydmljZSxcclxuICAgICAgICAgICAgSUxhenk8SVZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2U+IHZpZXdJdGVtQ29tcG9uZW50Q3JlYXRvclNlcnZpY2UsIFxyXG4gICAgICAgICAgICBJUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZSByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJRGlzcGF0Y2hlciBkaXNwYXRjaGVyLFxyXG4gICAgICAgICAgICBJQXBwbGljYXRpb25EYXRhIGFwcGxpY2F0aW9uRGF0YVxyXG4gICAgICAgICkgOiBiYXNlKHZpZXdNb2RlbENyZWF0b3JTZXJ2aWNlLCB2aWV3SXRlbUNvbXBvbmVudENyZWF0b3JTZXJ2aWNlLCByZWFjdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlLCBkaXNwYXRjaGVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5kaXNwYXRjaGVyID0gZGlzcGF0Y2hlcjtcclxuICAgICAgICAgICAgdGhpcy5hcHBsaWNhdGlvbkRhdGEgPSBhcHBsaWNhdGlvbkRhdGE7XHJcbiAgICAgICAgfVxyXG5wdWJsaWMgb3ZlcnJpZGUgYm9vbCBSZWFkeVxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gdHJ1ZTtcclxuICAgIH1cclxufVxyXG4gICAgICAgIHB1YmxpYyBUVmlld0l0ZW0gVmlld0l0ZW1cclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGdldFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAoVmlld0l0ZW1JbnB1dE1vZGVsID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIGRlZmF1bHQoVFZpZXdJdGVtKTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICByZXR1cm4gKFRWaWV3SXRlbSlWaWV3SXRlbUlucHV0TW9kZWwuVmlld0l0ZW07XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBvdmVycmlkZSBJQ29tcG9uZW50Q29udGFpbmVyIENvbXBvbmVudFxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChjb21wb25lbnRTZXR0aW5ncyA9PSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGNvbXBvbmVudFNldHRpbmdzID0gbmV3IFZpZXdJdGVtQ29tcG9uZW50Q29udGFpbmVyKHRoaXMpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIGNvbXBvbmVudFNldHRpbmdzO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG4vLy8gPHN1bW1hcnk+XHJcbi8vLyDQr9Cy0LvRj9C10YLRgdGPINC70Lgg0Y3Qu9C10LzQtdC90YIg0L/RgNC10LTRgdGC0LDQstC70LXQvdC40Y8g0LIg0YDQtdC20LjQvNC1INGA0LXQtNCw0LrRgtC40YDQvtCy0LDQvdC40Y9cclxuLy8vIDwvc3VtbWFyeT5cclxucHVibGljIHZpcnR1YWwgYm9vbCBJc0Rlc2lnbk1vZGVEZWVwXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBJc1ZpZXdJdGVtRGVzaWduTW9kZURlZXAoVmlld0l0ZW0pO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIGJvb2wgVGVzdElkRW5hYmxlZCgpXHJcbiAgICAgICAge1xyXG5JRGV2ZWxvcEFwcGxpY2F0aW9uRGF0YSBkZXZlbG9wQXBwbGljYXRpb25EYXRhOyAgICAgICAgICAgIHJldHVybiAoZGV2ZWxvcEFwcGxpY2F0aW9uRGF0YSA9IGFwcGxpY2F0aW9uRGF0YSBhcyBJRGV2ZWxvcEFwcGxpY2F0aW9uRGF0YSkgIT0gbnVsbCYmIGRldmVsb3BBcHBsaWNhdGlvbkRhdGEuVGVzdE1vZGUgPT0gVGVzdE1vZGUuQXV0b1Rlc3Q7XHJcbiAgICAgICAgfVxyXG5JVmlld0l0ZW0gSVZpZXdJdGVtVmlld01vZGVsLlZpZXdJdGVtXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBWaWV3SXRlbTtcclxuICAgIH1cclxufS8vLyA8aW5oZXJpdGRvYy8+XHJcbnB1YmxpYyBJSGlkZUVtcHR5TW9kZWwgSGlkZUVtcHR5TW9kZWxcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGhpZGVFbXB0eU1vZGVsO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgcHJvdGVjdGVkIG92ZXJyaWRlIHZvaWQgR2VuZXJhdGVDb250cm9sbGVyKFR5cGUgdHlwZUNvbnRyb2xsZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAodHlwZUNvbnRyb2xsZXIgPT0gbnVsbCB8fCB0eXBlQ29udHJvbGxlci5Jc0ludGVyZmFjZSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBjb250cm9sbGVyID0gVmlld01vZGVsQ3JlYXRvclNlcnZpY2UuQ29udHJvbGxlckNyZWF0b3IodHlwZUNvbnRyb2xsZXIsIENvbnRleHQsIHRoaXMsIFZpZXdJdGVtKTtcclxuICAgICAgICAgICAgQ3JlYXRlRGlzcGF0Y2hlcih0eXBlQ29udHJvbGxlcik7XHJcblxyXG4gICAgICAgICAgICBpZiAoSXNEZXNpZ25Nb2RlRGVlcClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGRpc3BhdGNoZXIuRGlzcGF0Y2gobmV3IEFjdGlvbkNvbW1hbmQoQ29udHJvbGxlckFzeW5jQ29uc3RhbnRzLkNvbW1hbmROYW1lLCBcIlwiLCBjb250cm9sbGVyLCBuZXcgRnVuYzxUYXNrPigoKSA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBDcmVhdGVWYWxpZGF0aW9uKCk7XHJcbiAgICAgICAgICAgICAgICBDcmVhdGVIaWRlYWJsZU1vZGVsKCk7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gVGFzay5Db21wbGV0ZWRUYXNrO1xyXG4gICAgICAgICAgICB9KSkpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgVGFzayBEZXN0cm95KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChIaWRlRW1wdHlNb2RlbCAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBIaWRlRW1wdHlNb2RlbC5EZXN0cm95KCk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBiYXNlLkRlc3Ryb3koKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KHQvtC30LTQsNGC0Ywg0YHQutGA0YvQstCw0LXQvNGD0Y4g0LzQvtC00LXQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgdm9pZCBDcmVhdGVIaWRlYWJsZU1vZGVsKClcclxuICAgICAgICB7XHJcbklIaWRlRW1wdHlWaWV3SXRlbUNvbnRhaW5lciBjb250YWluZXJTdG9yYWdlO0lIaWRlRW1wdHlWaWV3SXRlbSBoaWRlRW1wdHlWaWV3SXRlbTsgICAgICAgICAgICBpZiAoKGNvbnRhaW5lclN0b3JhZ2UgPSBSZW5kZXJPd25lciBhcyBJSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXIpICE9IG51bGwmJiAoaGlkZUVtcHR5Vmlld0l0ZW0gPSBWaWV3SXRlbSBhcyBJSGlkZUVtcHR5Vmlld0l0ZW0pICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBvd25lciA9IGNvbnRhaW5lclN0b3JhZ2UuSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXIuRmluZE93bmVyKFZpZXdJdGVtKTtcclxuICAgICAgICAgICAgICAgIGlmIChjb250YWluZXJTdG9yYWdlLkhpZGVFbXB0eVZpZXdJdGVtQ29udGFpbmVyLklzSGlkZUVtcHR5KFZpZXdJdGVtKSlcclxuICAgICAgICAgICAgICAgIHtcclxuSUhpZGVhYmxlIGhpZGVhYmxlOyAgICAgICAgICAgICAgICAgICAgaWYgKGhpZGVFbXB0eVZpZXdJdGVtLklzSGlkZWFibGUgJiYgKGhpZGVhYmxlID0gY29udHJvbGxlciBhcyBJSGlkZWFibGUpICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBoaWRlRW1wdHlNb2RlbCA9IG5ldyBWaWV3SXRlbUhpZGVFbXB0eU1vZGVsKFJlbmRlck93bmVyLCBoaWRlYWJsZSwgb3duZXIpO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICBlbHNlIGlmICghaGlkZUVtcHR5Vmlld0l0ZW0uSXNIaWRlYWJsZSlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIGhpZGVFbXB0eU1vZGVsID0gbmV3IEhpZGVFbXB0eUNvbnRhaW5lck1vZGVsKGNvbnRhaW5lclN0b3JhZ2UuSGlkZUVtcHR5Vmlld0l0ZW1Db250YWluZXIsIFZpZXdJdGVtLCBvd25lcik7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZWxzZSBpZiAoaGlkZUVtcHR5Vmlld0l0ZW0uSGlkZUVtcHR5ID09IEhpZGVFbXB0eUVudW0uU2hvd0VtcHR5KVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGhpZGVFbXB0eU1vZGVsID0gbmV3IFNob3dFbXB0eU1vZGVsKG93bmVyKTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoaGlkZUVtcHR5TW9kZWwgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBoaWRlRW1wdHlNb2RlbC5Jbml0KCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICAgICAgXHJcbiAgICAgICAgcHJpdmF0ZSBib29sIElzVmlld0l0ZW1EZXNpZ25Nb2RlRGVlcChJVmlld0l0ZW0gdmlld0l0ZW1DaGVjaylcclxuICAgICAgICB7XHJcbkNvbXBvbmVudFZpZXdJdGVtIGNvbXBvbmVudFZpZXdJdGVtOyAgICAgICAgICAgIGlmICgoY29tcG9uZW50Vmlld0l0ZW0gPSB2aWV3SXRlbUNoZWNrIGFzIENvbXBvbmVudFZpZXdJdGVtKSAhPSBudWxsJiYgY29tcG9uZW50Vmlld0l0ZW0uVmlld01vZGUgPT0gSW50ZXJmYWNlQnVpbGRlclZpZXdNb2RlLkRlc2lnbilcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICAgICAgICAgIH1cclxuSU1ldGFkYXRhVmlld01vZGVsIGNvbXBvbmVudE93bmVyO1xyXG4gICAgICAgICAgICByZXR1cm4gKGNvbXBvbmVudE93bmVyID0gUmVuZGVyT3duZXIgYXMgSU1ldGFkYXRhVmlld01vZGVsKSAhPSBudWxsJiYgKGNvbXBvbmVudE93bmVyLklzRGVzaWduTW9kZSB8fCBjb21wb25lbnRPd25lci5Jc0Rlc2lnbk1vZGVEZWVwKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIEJyaWRnZS5SZWFjdDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLk1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5Db21wb25lbnRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5FeHRlbnNpb25Qb2ludHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlZpZXdzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQmtC+0LzQv9C+0L3QtdC90YIsINC+0LHQvtGA0LDRh9C40LLQsNGO0YnQuNC5IFZpZXdJdGVtXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIGNsYXNzIFdyYXBwZXJDb21wb25lbnQgOiBCYXNlUmVhY3RDb21wb25lbnQ8V3JhcHBlckNvbXBvbmVudC5XcmFwcGVyQ29tcG9uZW50SW5wdXRzLFxyXG4gICAgICAgIFdyYXBwZXJDb21wb25lbnQuV3JhcHBlckNvbXBvbmVudENvbnRleHQsXHJcbiAgICAgICAgV3JhcHBlckNvbXBvbmVudC5XcmFwcGVyQ29udHJvbGxlcj5cclxuICAgIHtcclxuICAgICAgICAjcmVnaW9uIElucHV0cyAmIENvbnRleHRcclxuXHJcbiAgICAgICAgcHVibGljIGNsYXNzIFdyYXBwZXJDb21wb25lbnRJbnB1dHMgOiBJbnB1dHNcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAgICAgLy8vIFZpZXdJdGVtLCDQutC+0YLQvtGA0YvQuSDQvdGD0LbQvdC+INC+0LHQtdGA0L3Rg9GC0YxcclxuICAgICAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAgICAgcHVibGljIEZ1bmM8SVZpZXdJdGVtPiBWaWV3SXRlbSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyDQmtC+0L3RgtC10L3RglxyXG4gICAgICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgICAgICBwdWJsaWMgRnVuYzxSZWFjdEVsZW1lbnRbXT4gQ29udGVudCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyDQndCw0LjQvNC10L3QvtCy0LDQvdC40LUg0YHQu9C+0YLQsFxyXG4gICAgICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgICAgICBwdWJsaWMgRnVuYzxzdHJpbmc+IFNsb3ROYW1lIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAgICAgLy8vINCe0YLQvtCx0YDQsNC20LDQtdC80L7QtSDQuNC80Y9cclxuICAgICAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAgICAgcHVibGljIEZ1bmM8c3RyaW5nPiBDYXB0aW9uIHsgZ2V0OyBzZXQ7IH1cclxuXG4gICAgICAgIFxucHJpdmF0ZSBGdW5jPFJlYWN0RWxlbWVudFtdPiBfX1Byb3BlcnR5X19Jbml0aWFsaXplcl9fQ29udGVudD0oKSA9PiBudWxsO31cclxuXHJcbiAgICAgICAgcHVibGljIGNsYXNzIFdyYXBwZXJDb21wb25lbnRDb250ZXh0IDogV3JhcHBlckNvbXBvbmVudElucHV0cywgSUNvbnRleHRcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIHB1YmxpYyBXcmFwcGVyQ29tcG9uZW50KElSZWFjdElucHV0TW9kZWw8V3JhcHBlckNvbXBvbmVudElucHV0cz4gbW9kZWwpIDogYmFzZShtb2RlbClcclxuICAgICAgICB7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwdWJsaWMgb3ZlcnJpZGUgUmVhY3RFbGVtZW50IFZpZXcoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHNsb3ROYW1lID0gZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTFcIixDb250ZXh0LlNsb3ROYW1lKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8RnVuYzxzdHJpbmc+PihcImtleTFcIikuSW52b2tlKCk6KHN0cmluZyludWxsO1xyXG4gICAgICAgICAgICB2YXIgY2FwdGlvbiA9IGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkyXCIsQ29udGV4dC5DYXB0aW9uKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8RnVuYzxzdHJpbmc+PihcImtleTJcIikuSW52b2tlKCk6KHN0cmluZyludWxsO1xyXG4gICAgICAgICAgICB2YXIgZWxlbWVudHMgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLlNlbGVjdDxSZWFjdEVsZW1lbnQsUmVhY3RFbGVtZW50PihDb250ZXh0LkNvbnRlbnQoKSwoRnVuYzxSZWFjdEVsZW1lbnQsUmVhY3RFbGVtZW50PikoY2hpbGQgPT4gT3V0ZXJXcmFwKGNoaWxkLkdldFZpZXdJdGVtKCksIHNsb3ROYW1lLCBjaGlsZCkpKS5Ub0FycmF5KCk7XHJcbiAgICAgICAgICAgIHJldHVybiBJbm5lcldyYXAoQ29udGV4dC5WaWV3SXRlbSgpLCBzbG90TmFtZSwgY2FwdGlvbiwgZWxlbWVudHMpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQntCx0LXRgNC90YPRgtGMINGN0LvQtdC80LXQvdGC0Ysg0LLQvdC10YjQvdC1XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3SXRlbVwiPtCt0LvQtdC80LXQvdGCINC/0YDQtdC00YHRgtCw0LLQu9C10L3QuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzbG90TmFtZVwiPtCY0LzRjyDRgdC70L7RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJlbGVtZW50c1wiPtCU0L7Rh9C10YDQvdC40LUg0LrQvtC80L/QvtC90LXQvdGC0Ys8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIFJlYWN0RWxlbWVudCBPdXRlcldyYXAoSVZpZXdJdGVtIHZpZXdJdGVtLCBzdHJpbmcgc2xvdE5hbWUsIHBhcmFtcyBSZWFjdEVsZW1lbnRbXSBlbGVtZW50cylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmICh2aWV3SXRlbSA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbmV3IEZyYWdtZW50KFxyXG4gICAgICAgICAgICAgICAgICAgIG5ldyBGcmFnbWVudC5Qcm9wc1xyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgS2V5ID0gXCJXcmFwcGVyQ29tcG9uZW50X091dGVyV3JhcFwiXHJcbiAgICAgICAgICAgICAgICAgICAgfSwgXHJcbiAgICAgICAgICAgICAgICAgICAgZWxlbWVudHMpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgd3JhcHBlciA9IENvbnRyb2xsZXIuR2V0RWxlbWVudFdyYXBwZXIodmlld0l0ZW0sIEVsZW1lbnRXcmFwcGVyVHlwZS5PdXRlcik7XHJcbiAgICAgICAgICAgIGlmICh3cmFwcGVyID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBuZXcgRnJhZ21lbnQobmV3IEZyYWdtZW50LlByb3BzXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgS2V5ID0gXCJXcmFwcGVyQ29tcG9uZW50X091dGVyV3JhcFwiICsgSW5wdXRNb2RlbC5LZXkgKyB2aWV3SXRlbS5VaWQuVG9TdHJpbmcoKVxyXG4gICAgICAgICAgICAgICAgfSwgZWxlbWVudHMpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiBWaWV3TW9kZWwuUmVhY3RDb21wb25lbnRDcmVhdG9yU2VydmljZS5DcmVhdGUoXHJcbiAgICAgICAgICAgICAgICB3cmFwcGVyLFxyXG4gICAgICAgICAgICAgICAgbmV3IFdyYXBwZXJJbnB1dHNcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBLZXkgPSBcIldyYXBwZXJDb21wb25lbnRfT3V0ZXJXcmFwXCIgKyBJbnB1dE1vZGVsLktleSArIHZpZXdJdGVtLlVpZC5Ub1N0cmluZygpLFxyXG4gICAgICAgICAgICAgICAgICAgIFdyYXBNb2RlbCA9ICgpID0+IENvbnRyb2xsZXIuQ3JlYXRlTW9kZWwodmlld0l0ZW0sIHNsb3ROYW1lKSxcclxuICAgICAgICAgICAgICAgICAgICBDaGlsZHJlbiA9IGVsZW1lbnRzXHJcbiAgICAgICAgICAgICAgICB9LFxyXG4gICAgICAgICAgICAgICAgVmlld01vZGVsLlJlbmRlck93bmVyXHJcbiAgICAgICAgICAgICkuVG9SZWFjdEVsZW1lbnQoKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J7QsdC10YDQvdGD0YLRjCDRjdC70LXQvNC10L3RgtGLINCy0L3Rg9GC0YDQuFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmlld0l0ZW1cIj7QrdC70LXQvNC10L3RgiDQv9GA0LXQtNGB0YLQsNCy0LvQtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwic2xvdE5hbWVcIj7QmNC80Y8g0YHQu9C+0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY2FwdGlvblwiPtCe0YLQvtCx0YDQsNC20LDQtdC80L7QtSDQuNC80Y8g0LzQvtC00LXQu9C4PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJlbGVtZW50c1wiPtCU0L7Rh9C10YDQvdC40LUg0LrQvtC80L/QvtC90LXQvdGC0Ys8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz48L3JldHVybnM+XHJcbiAgICAgICAgcHJvdGVjdGVkIFJlYWN0RWxlbWVudCBJbm5lcldyYXAoSVZpZXdJdGVtIHZpZXdJdGVtLCBzdHJpbmcgc2xvdE5hbWUsIHN0cmluZyBjYXB0aW9uLCBwYXJhbXMgUmVhY3RFbGVtZW50W10gZWxlbWVudHMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgd3JhcHBlciA9IENvbnRyb2xsZXIuR2V0RWxlbWVudFdyYXBwZXIodmlld0l0ZW0sIEVsZW1lbnRXcmFwcGVyVHlwZS5Jbm5lcik7XHJcbiAgICAgICAgICAgIGlmICh3cmFwcGVyID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBuZXcgRnJhZ21lbnQobmV3IEZyYWdtZW50LlByb3BzXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgS2V5ID0gXCJXcmFwcGVyQ29tcG9uZW50X0lubmVyV3JhcFwiICsgSW5wdXRNb2RlbC5LZXlcclxuICAgICAgICAgICAgICAgIH0sIGVsZW1lbnRzKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICByZXR1cm4gVmlld01vZGVsLlJlYWN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UuQ3JlYXRlKFxyXG4gICAgICAgICAgICAgICAgd3JhcHBlcixcclxuICAgICAgICAgICAgICAgIG5ldyBXcmFwcGVySW5wdXRzXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgS2V5ID0gXCJXcmFwcGVyQ29tcG9uZW50X0lubmVyV3JhcFwiICsgSW5wdXRNb2RlbC5LZXksXHJcbiAgICAgICAgICAgICAgICAgICAgV3JhcE1vZGVsID0gKCkgPT4gQ29udHJvbGxlci5DcmVhdGVNb2RlbCh2aWV3SXRlbSwgc2xvdE5hbWUsIGNhcHRpb24pLFxyXG4gICAgICAgICAgICAgICAgICAgIENoaWxkcmVuID0gZWxlbWVudHNcclxuICAgICAgICAgICAgICAgIH0sXHJcbiAgICAgICAgICAgICAgICBWaWV3TW9kZWwuUmVuZGVyT3duZXJcclxuICAgICAgICAgICAgKS5Ub1JlYWN0RWxlbWVudCgpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI3JlZ2lvbiBDb250cm9sbGVyXHJcblxyXG4gICAgICAgIHB1YmxpYyBjbGFzcyBXcmFwcGVyQ29udHJvbGxlciA6IENvbnRyb2xsZXI8V3JhcHBlckNvbXBvbmVudENvbnRleHQ+LCBJUmVxdWlyZU93bmVyQ29udHJvbGxlclxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJRW51bWVyYWJsZTxJRWxlbWVudFdyYXBwZXI+IGVsZW1lbnRXcmFwcGVycztcclxuICAgICAgICAgICAgcHJpdmF0ZSBJVmlld01vZGVsIGN1cnJlbnRWaWV3TW9kZWw7XHJcblxyXG4gICAgICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImVsZW1lbnRXcmFwcGVyc1wiPtCa0L7QvNC/0L7QvdC10L3RgtGLLCDQutC+0YLQvtGA0YvQtSDQvtCx0L7RgNCw0YfQuNCy0LDRjtGCINGN0LvQtdC80LXQvdGC0Ysg0LrQsNC6INCy0L3Rg9GC0YDQuCwg0YLQsNC6INC4INGB0L3QsNGA0YPQttC4PC9wYXJhbT5cclxuICAgICAgICAgICAgcHVibGljIFdyYXBwZXJDb250cm9sbGVyKElFbnVtZXJhYmxlPElFbGVtZW50V3JhcHBlcj4gZWxlbWVudFdyYXBwZXJzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB0aGlzLmVsZW1lbnRXcmFwcGVycyA9IGVsZW1lbnRXcmFwcGVycztcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgICAgICAvLy8g0JjQvdC40YbQuNCw0LvQuNC30LDRhtC40Y8gVmlld01vZGVsXHJcbiAgICAgICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm93bmVyXCI+PC9wYXJhbT5cclxuICAgICAgICAgICAgcHVibGljIHZvaWQgU2V0T3duZXIoSVZpZXdNb2RlbCBvd25lcilcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgY3VycmVudFZpZXdNb2RlbCA9IG93bmVyO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyDQndCw0LnRgtC4INC90YPQttC90YvQuSDQstGA0LDQv9C/0LXRgFxyXG4gICAgICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2aWV3SXRlbVwiPjwvcGFyYW0+XHJcbiAgICAgICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIndyYXBwZXJUeXBlXCI+PC9wYXJhbT5cclxuICAgICAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICAgICAgcHVibGljIFR5cGUgR2V0RWxlbWVudFdyYXBwZXIoSVZpZXdJdGVtIHZpZXdJdGVtLCBFbGVtZW50V3JhcHBlclR5cGUgd3JhcHBlclR5cGUpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciB3cmFwcGVyID0gU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5GaXJzdE9yRGVmYXVsdDxJRWxlbWVudFdyYXBwZXI+KGVsZW1lbnRXcmFwcGVycywoRnVuYzxJRWxlbWVudFdyYXBwZXIsYm9vbD4pKHIgPT4gci5DYW5XcmFwKHZpZXdJdGVtLCBjdXJyZW50Vmlld01vZGVsLCB3cmFwcGVyVHlwZSkpKTtcclxuICAgICAgICAgICAgICAgIHJldHVybiB3cmFwcGVyIT1udWxsP3dyYXBwZXIuVHlwZTooVHlwZSludWxsO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgICAgIC8vLyDQodC+0LfQtNCw0YLRjCDQvNC+0LTQtdC70YxcclxuICAgICAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmlld0l0ZW1cIj7QrdC70LXQvNC10L3RgiDQv9GA0LXQtNGB0YLQsNCy0LvQtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInNsb3ROYW1lXCI+0JjQvNGPINGB0LvQvtGC0LA8L3BhcmFtPlxyXG4gICAgICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjYXB0aW9uXCI+0JfQsNCz0L7Qu9C+0LLQvtC6PC9wYXJhbT5cclxuICAgICAgICAgICAgLy8vIDxyZXR1cm5zPtCc0L7QtNC10LvRjC3QvtCx0LXRgNGC0LrQsDwvcmV0dXJucz5cclxuICAgICAgICAgICAgaW50ZXJuYWwgSVdyYXBNb2RlbCBDcmVhdGVNb2RlbChJVmlld0l0ZW0gdmlld0l0ZW0sIHN0cmluZyBzbG90TmFtZSwgc3RyaW5nIGNhcHRpb24gPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgbW9kZWwgPSBjYXB0aW9uID09IG51bGwgPyBuZXcgV3JhcE1vZGVsKHZpZXdJdGVtLCBzbG90TmFtZSkgOiBuZXcgV3JhcE1vZGVsKHZpZXdJdGVtLCBzbG90TmFtZSwgY2FwdGlvbik7XHJcblVua25vd25UeXBlVmlld0l0ZW0gdW5rbm93blR5cGVWaWV3SXRlbTsgICAgICAgICAgICAgICAgaWYgKHN0cmluZy5Jc051bGxPcldoaXRlU3BhY2UoY2FwdGlvbikgJiYgKHVua25vd25UeXBlVmlld0l0ZW0gPSB2aWV3SXRlbSBhcyBVbmtub3duVHlwZVZpZXdJdGVtKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIG1vZGVsLkNhcHRpb24gPSB1bmtub3duVHlwZVZpZXdJdGVtLkdldFR5cGVOYW1lKCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG1vZGVsO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAjZW5kcmVnaW9uXHJcbiAgICB9XHJcbn0iLCJ1c2luZyBCcmlkZ2UuUmVhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5WaWV3c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JrQvtC80L/QvtC90LXQvdGCLCDQvtCx0L7RgNCw0YfQuNCy0LDRjtGJ0LjQuSBWaWV3SXRlbSDRgtC+0LvRjNC60L4g0LLQvdGD0YLRgNC4XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIHNlYWxlZCBjbGFzcyBJbm5lcldyYXBwZXJDb21wb25lbnQgOiBXcmFwcGVyQ29tcG9uZW50XHJcbiAgICB7XHJcbiAgICAgICAgcHVibGljIElubmVyV3JhcHBlckNvbXBvbmVudChJUmVhY3RJbnB1dE1vZGVsPFdyYXBwZXJDb21wb25lbnRJbnB1dHM+IG1vZGVsKSA6IGJhc2UobW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIFJlYWN0RWxlbWVudCBWaWV3KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBJbm5lcldyYXAoQ29udGV4dC5WaWV3SXRlbSgpLCBnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5MVwiLENvbnRleHQuU2xvdE5hbWUpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxTeXN0ZW0uRnVuYzxzdHJpbmc+PihcImtleTFcIikuSW52b2tlKCk6KHN0cmluZyludWxsLCBzdHJpbmcuRW1wdHksIENvbnRleHQuQ29udGVudCgpKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn0iLCJ1c2luZyBCcmlkZ2UuUmVhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0Lk1vZGVscztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5WaWV3c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JrQvtC80L/QvtC90LXQvdGCLCDQvtCx0L7RgNCw0YfQuNCy0LDRjtGJ0LjQuSBWaWV3SXRlbSDRgtC+0LvRjNC60L4g0LLQvdC10YjQvdC1XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIHNlYWxlZCBjbGFzcyBPdXRlcldyYXBwZXJDb21wb25lbnQgOiBXcmFwcGVyQ29tcG9uZW50XHJcbiAgICB7XHJcbiAgICAgICAgcHVibGljIE91dGVyV3JhcHBlckNvbXBvbmVudChJUmVhY3RJbnB1dE1vZGVsPFdyYXBwZXJDb21wb25lbnRJbnB1dHM+IG1vZGVsKSA6IGJhc2UobW9kZWwpXHJcbiAgICAgICAge1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIFJlYWN0RWxlbWVudCBWaWV3KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBPdXRlcldyYXAoQ29udGV4dC5WaWV3SXRlbSgpLCBnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5MVwiLENvbnRleHQuU2xvdE5hbWUpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxTeXN0ZW0uRnVuYzxzdHJpbmc+PihcImtleTFcIikuSW52b2tlKCk6KHN0cmluZyludWxsLCBDb250ZXh0LkNvbnRlbnQoKSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59Il0KfQo=

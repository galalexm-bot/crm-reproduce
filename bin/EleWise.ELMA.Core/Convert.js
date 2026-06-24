/**
 * @version 4.1.0.47200 R.local
 * @author ELMA
 * @copyright Copyright © 2006-2022 ELMA
 * @compiler Bridge.NET 17.6.0
 */
if (typeof elma !== 'undefined' && elma && elma.timeZone) {
    var newRuntimeTZContainer = {
        userOffsetLastValue: undefined,
        serverOffsetLastValue: undefined,
        userOffset: function () {
            var value = elma.timeZone.getUserOffset();
            if (value !== undefined) {
                this.userOffsetLastValue = value;
            }

            return this.userOffsetLastValue;
        },
        browserOffset: function () {
            return elma.timeZone.getBrowserOffset();
        },
        serverOffset: function () {
            var value = elma.timeZone.getServerOffset();
            if (value !== undefined) {
                this.serverOffsetLastValue = value;
            }

            return this.serverOffsetLastValue;
        },
    };

    System.DateTime.getNow = function () {
        var d = new Date();
        var userOffset = newRuntimeTZContainer.userOffset();
        if (userOffset !== undefined){
            d.addMinutes(userOffset - newRuntimeTZContainer.browserOffset());
        }
        d.kind = 2;

        return d;
    };
}
else {
    var newRuntimeTZContainer = {
        userOffset: function () {
            return undefined;
        },
        browserOffset: function (date) {
            return -(date == null ? new Date() : date).getTimezoneOffset();
        },
        serverOffset: function () {
            return undefined;
        },
    }
}

System.Enum.toStringFn = function (type) {
    if (type === require("EleWise_ELMA_Core").EleWise.ELMA.Common.Models.EnumWrapper) {
        return function (value) {
            return Bridge.toString(value);
        };
    }

    return function (value) {
        return System.Enum.toString(type, value);
    };
};

var oldEnumToStringFunc = System.Enum.toString;

System.Enum.toString = function (enumType, value, forceFlags) {
    if (arguments.length === 0) {
        return "System.Enum";
    }

    if (value && value.$boxed && enumType === System.Enum) {
        enumType = value.type;
    }

    value = Bridge.unbox(value, true);

    if (enumType === Number || enumType === System.String || enumType.$number || enumType == require("EleWise_ELMA_Core").EleWise.ELMA.Common.Models.EnumWrapper) {
        return value.toString();
    }

    return oldEnumToStringFunc(enumType, value, forceFlags);
};
Bridge.assembly("Convert", function ($asm, globals) {
    "use strict";

// TODO: Сделать шаблон и вынести в {SolutionDir}/.auxiliary/
(function (root, factory) {
    if (typeof define === 'function' && define.amd) {
        define("Convert", ["Reactive", "EleWise_ELMA_Core"], factory);
    } else if (typeof module === 'object' && module.exports) {
        module.exports = factory(require("Reactive"), require("EleWise_ELMA_Core"));
    } else {
        root.Convert = factory(root.Reactive, root.EleWise_ELMA_Core);
    }
}(this, function (Reactive, EleWise_ELMA_Core) {

    var Convert = {};
    Bridge.define("convert", {
        $scope: Convert,
        statics: {
            methods: {
                /* To Converters */
                ToString: function (property) {
                    var v = property.$stored;
                    if (v === undefined) {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        return null;
                    }
                    return v;
                },

                ToHtmlString: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null) {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = new EleWise_ELMA_Core.System.Web.HtmlString(null);
                        }
                    } else {
                        val = new EleWise_ELMA_Core.System.Web.HtmlString(v);
                    }
                    return val;
                },

                ToUri: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null) {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = new System.Uri("");
                        }
                    } else {
                        val = new System.Uri(v);
                    }
                    return val;
                },

                ToInt32: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.Int32.getDefaultValue();
                        }
                    } else {
                        val = parseInt(v, 10);
                    }
                    return val;
                },

                ToInt64: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.Int64.getDefaultValue();
                        }
                    } else {
                        val = new System.Int64(v);
                    }
                    return val;
                },

                ToBoolean: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = false;
                        }
                    } else {
                        val = this.ToBooleanValue(v);
                    }
                    return val;
                },

                ToBooleanValue: function (value) {
                    if (value === "True" || value === "true" || value === "1") {
                        return true;
                    }

                    if (value === "False" || value === "false" || value === "0") {
                        return false;
                    }

                    return System.Boolean.parse(value)
                },

                ToDouble: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.Double.getDefaultValue();
                        }
                    } else {
                        val = System.Double.parse(v, System.Globalization.CultureInfo.invariantCulture);
                    }
                    return val;
                },

                ToByteArray: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        val = null;
                    } else {
                        var iCount = (((Bridge.Int.div(v.length, 2)) | 0));
                        val = System.Array.init(iCount, 0, System.Byte);
                        for (var i = 0; i < iCount; i = (i + 1) | 0) {
                            val[System.Array.index(i, val)] = System.Convert.toNumberInBase(v.substr(Bridge.Int.mul(i, 2), 2), 16, 6);
                        }
                    }
                    return val;
                },

                ToDateTime: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.DateTime.getDefaultValue();
                        }
                    } else {
                        val = this.ToDateTimeValue(v);
                    }
                    return val;
                },

                ToDateTimeValue: function (value) {
                    return System.DateTime.parse(value, System.Globalization.CultureInfo.invariantCulture);
                },

                ToTimeSpan: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.TimeSpan.getDefaultValue();
                        }
                    } else {
                        val = System.TimeSpan.parse(v, System.Globalization.CultureInfo.invariantCulture);
                    }
                    return val;
                },

                ToDateTimeRange: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = new EleWise_ELMA_Core.EleWise.ELMA.Model.Ranges.DateTimeRange();
                        }
                    } else {
                        val = this.ToDateTimeRangeValue(v);
                    }
                    return val;
                },

                ToDateTimeRangeValue: function (value) {
                    var from = null;
                    var to = null;
                    if (value.From) {
                        from = this.ToDateTimeValue(value.From);
                    }
                    if (value.To) {
                        to = this.ToDateTimeValue(value.To);
                    }
                    return new EleWise_ELMA_Core.EleWise.ELMA.Model.Ranges.DateTimeRange.$ctor1(from, to);
                },

                ToRangeType: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = declaredType.getDefaultValue();
                        }
                    } else {
                        var rangePropertyType = property.$rangePropertyType;
                        var parseFunc = rangePropertyType.parse$1;
                        if (!parseFunc) {
                            parseFunc = rangePropertyType.parse;
                            if (!parseFunc) {
                                throw new System.MissingMethodException.$ctor1(SR.T("Не удалось найти метод \"{0}\" у типа \"{1}\"", "parse", rangePropertyType.$$fullname));
                            }
                        }
                        var from = null;
                        var to = null;
                        if (v.From) {
                            from = parseFunc(v.From, System.Globalization.CultureInfo.invariantCulture);
                        }
                        if (v.To) {
                            to = parseFunc(v.To, System.Globalization.CultureInfo.invariantCulture);
                        }
                        val = new declaredType.$ctor1(from, to);
                    }
                    return val;
                },

                ToRelativeDateTime: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = new EleWise_ELMA_Core.EleWise.ELMA.Model.Ranges.RelativeDateTime();
                        }
                    } else {
                        if (this.ToBooleanValue(v.IsRelative) === true) {
                            val = new EleWise_ELMA_Core.EleWise.ELMA.Model.Ranges.RelativeDateTime.$ctor2(v.RelativeFrom, v.RelativeTo);
                        } else  {
                            if (v.DateTimeRange) {
                                val = this.ToDateTimeRangeValue(v.DateTimeRange);
                            } else {
                                val = new EleWise_ELMA_Core.EleWise.ELMA.Model.Ranges.RelativeDateTime();
                            }
                        }
                    }
                    return val;
                },

                ToExceptionData: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            init.$inited = true;
                            return init.getValueAndClear();
                        }
                        val = null;
                    } else {
                        if (v.OriginalException) {
                            var exception = new System.Exception.ctor(v.OriginalException.Message);
                            exception.errorStack.stack = v.OriginalException.StackTrace;
                            val = new EleWise_ELMA_Core.EleWise.ELMA.Common.Models.ExceptionData.$ctor2(parseInt(v.ExceptionCode, 10), v.Message, exception);
                        } else {
                            val = new EleWise_ELMA_Core.EleWise.ELMA.Common.Models.ExceptionData.$ctor1(parseInt(v.ExceptionCode, 10), v.Message);
                        }
                    }
                    return val;
                },

                ToGuid: function (property) {
                    var val,
                        v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = System.Guid.Empty;
                        }
                    } else {
                        if (v === "00000000-0000-0000-0000-000000000000") {
                            val = System.Guid.Empty;
                        } else {
                            val = System.Guid.parseAsLazy(v);
                        }
                    }
                    return val;
                },

                ToContract: function (property) {
                    var v = property.$stored;

                    if (property.$bridge === undefined) {
                        property.$bridge = {};
                    }

                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        var typeRef = v.$t;
                        if (typeRef) {
                            var context = property.$context;
                            if (context === undefined || context === null) {
                                context = property.$context = {}
                            }
                            var proxyGenerator = context.$proxyGenerator;
                            if (proxyGenerator === undefined || proxyGenerator === null) {
                                proxyGenerator = property.$context.$proxyGenerator = Reactive.modules.getCore().EleWise.ELMA.DTO.ProxyGeneratorServiceContext.ProxyGenerator
                            }

                            var extendEntityService = context.$extendEntityService;
                            if (extendEntityService === undefined || extendEntityService === null) {
                                extendEntityService = property.$context.$extendEntityService = Reactive.modules.getCore().EleWise.ELMA.DTO.ExtendEntityServiceContext.ExtendEntityService
                            }

                            var result = proxyGenerator.GenerateProxyOrNull$1(typeRef);
                            if (result !== null) {
                                result.$jsonObj = v;
                                if (property.$bridge.$cache !== undefined
                                    && property.$bridge.$cache !== null
                                    && property.$bridge.$cache.$$actions !== null
                                    && property.$bridge.$cache.$$actions !== undefined) {
                                    result.$$actions = new (System.Collections.Generic.Dictionary$2(System.String, System.Object)).$ctor1(property.$bridge.$cache.$$actions);
                                }
                                if (property.$target !== undefined) {
                                    result.$shouldObserve = property.$target.$shouldObserve;
                                }
                            }

                            return result;
                        }
                        else {
                            console.error("Нет ссылки на тип в структуре обмена данными");
                        }
                    }
                },

                ToCollection: function (property) {
                    property.$isCollection = true;
                    var declaredType = property.$declaredType;
                    if (!property.$stored) {
                        property.$stored = [];
                    }
                    var val = new (Reactive.EleWise.ELMA.Collections.ReactiveCollection$1(declaredType)).$ctor1(property);
                    if (property.$bridge === undefined) {
                        property.$bridge = {};
                    }

                    property.$bridge.$cache = val;
                    property.$bridge.$status = 3;

                    return property.$bridge.$cache;
                },

                ToSetCollection: function (property) {
                    property.$isCollection = true;
                    var declaredType = property.$declaredType;
                    if (!property.$stored) {
                        property.$stored = [];
                    }
                    var init = property.$init,
                        aliasName;
                    if (init !== undefined && init.$initValue !== undefined) {
                        aliasName = init.$initValue().realTypeAlias;
                    }
                    var val = new (Reactive.EleWise.ELMA.Collections.ReactiveSet$1(declaredType)).$ctor1(property, aliasName);
                    if (property.$bridge === undefined) {
                        property.$bridge = {};
                    }

                    property.$bridge.$cache = val;
                    property.$bridge.$status = 3;

                    return property.$bridge.$cache;
                },

                ToEntityHeader: function (property) {
                    var v = property.$stored;

                    if (property.$bridge === undefined) {
                        property.$bridge = {};
                    }

                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        var context = property.$context;
                        if (context === undefined || context === null) {
                            context = property.$context = {}
                        }
                        var proxyGenerator = context.$proxyGenerator;
                        if (proxyGenerator === undefined || proxyGenerator === null) {
                            proxyGenerator = property.$context.$proxyGenerator = Reactive.modules.getCore().EleWise.ELMA.DTO.ProxyGeneratorServiceContext.ProxyGenerator
                        }

                        var extendEntityService = context.$extendEntityService;
                        if (extendEntityService === undefined || extendEntityService === null) {
                            extendEntityService = property.$context.$extendEntityService = Reactive.modules.getCore().EleWise.ELMA.DTO.ExtendEntityServiceContext.ExtendEntityService
                        }

                        var result = null;
                        var uid = v.TypeUid;
                        if (uid !== null && uid !== undefined) {
                            result = proxyGenerator.GenerateProxyByStringUidOrNull(uid);
                            if (result !== null) {
                                result.$jsonObj = v;
                                if (property.$bridge.$cache !== undefined
                                    && property.$bridge.$cache !== null
                                    && property.$bridge.$cache.$$actions !== null
                                    && property.$bridge.$cache.$$actions !== undefined) {
                                    result.$$actions = new (System.Collections.Generic.Dictionary$2(System.String, System.Object)).$ctor1(property.$bridge.$cache.$$actions);
                                }
                                if (property.$target !== undefined) {
                                    result.$shouldObserve = property.$target.$shouldObserve;
                                }
                            } else {
                                // Исключительный случай
                                var coreModule = Reactive.modules.getCore();
                                var entity = new coreModule.EleWise.ELMA.Model.Entities.Entity;
                                entity.TypeUid = System.Guid.parseAsLazy(v.TypeUid);
                                if (v.Id){
                                    entity.Id = new System.Int64(v.Id);
                                }
                                entity.Uid = System.Guid.parseAsLazy(v.Uid);
                                entity.Name = v.Name;
                                entity.$toString = v.$toString;
                                entity.$jsonObj = v;
                                return entity;
                            }

                            result = proxyGenerator.EntityStorage.TryAddInternal(result, extendEntityService);
                            if (result !== undefined && result !== null) {
                                property.$stored = result.$jsonObj;
                            }
                        }
                        else {
                            if ("$ref" in v) {
                                var cntx = globals.reconcileContext;
                                if (cntx !== undefined || cntx !== null) {
                                    var refId = v.$ref;
                                    var ref = cntx.getReference(refId);
                                    if (ref.hasValue === false) {
                                        cntx.fillUnbinded(refId, property.$target, property.$name, property.$serializedName);
                                        result = null;
                                    } else {
                                        result = ref.value;
                                    }
                                }
                            }
                            else {
                                console.warn("Уникальный идентификатор типа сущности == null");
                            }
                        }

                        return result;
                    }
                },

                ToBook1C: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        val = new declaredType();
                        val.Id = v.Id;
                        val.$toString = v.$toString;
                        var uid = { v : new System.Guid() };
                        System.Guid.TryParse(v.TypeUid, uid);
                        val.TypeUid = uid.v;
                    }
                    return val;
                },

                ToEnum: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        if (property.nullable === true) {
                            val = null;
                        } else {
                            val = declaredType.getDefaultValue();
                        }
                    } else {
                        var context = property.$context;
                        if (context === undefined || context === null) {
                            context = property.$context = {}
                        }

                        var uid = { v : new System.Guid() };
                        if (System.Guid.TryParse(v, uid)) {
                            val = EleWise_ELMA_Core.EleWise.ELMA.Common.Models.EnumWrapper.CreateBase(uid.v, context.$metadata);
                        } else {
                            val = EleWise_ELMA_Core.EleWise.ELMA.Common.Models.EnumWrapper.CreateBase$2(parseInt(v, 10), context.$metadata);
                        }
                    }
                    return val;
                },

                ToDropDownItem: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        var init = property.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            return init.getValueAndClear();
                        }
                        val = null;
                    } else {
                        val = new declaredType.ctor(v);
                    }
                    return val;
                },

                ToReferenceOnType: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        val = null;
                    } else {
                        if (v.SubTypeUid == null) {
                            val = new declaredType.ctor(System.Guid.parseAsLazy(v.TypeUid));
                        }
                        else {
                            val = new declaredType.$ctor1(System.Guid.parseAsLazy(v.TypeUid), System.Guid.parseAsLazy(v.SubTypeUid));
                        }
                    }
                    return val;
                },

                ToReferenceOnEntityType: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        val = null;
                    } else {
                        val = new declaredType.ctor(System.Guid.parseAsLazy(v));
                    }
                    return val;
                },

                ToReferenceOnEntity: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        val = new declaredType.$ctor1(v);
                    }
                    return val;
                },

                ToBinaryFile: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        val = null;
                    } else {
                        if (v.Name === "" && v.Uid === "" && v.FileSize === "") {
                            val = null;
                        } else {
                            val = new declaredType.$ctor1(v.Name, System.Guid.parseAsLazy(v.Uid));
                        }
                    }
                    return val;
                },

                ToPassword: function (property) {
                    var val,
                        v = property.$stored,
                        declaredType = property.$declaredType;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        if (v.Hash === "" && v.Salt === "") {
                            val = null;
                        } else {
                            val = new declaredType.ctor(v.Hash, v.Salt);
                        }
                    }
                    return val;
                },

                ToFormViewItem: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        return this.SimpleDeserialize(v, property);
                    }
                },

                ToEntityInfo: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    }

                    return this.SimpleDeserialize(v, property);
                },

                ToActionValue: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    }

                    return this.SimpleDeserialize(v, property);
                },

                ToEntityListInfo: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    }

                    var result = new property.$declaredType();
                    v = Newtonsoft.Json.JsonConvert.parse(v);
                    for (var i = 0; i < v.length; i++) {
                        var item = this.SimpleDeserialize(v[i], {
                            $declaredType: EleWise_ELMA_Core.EleWise.ELMA.Model.Entities.EntityInfo
                        });
                        result.Items.add(item)
                    }
                    return result;
                },

                ToEnumInfo: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    }

                    return this.SimpleDeserialize(v, property);
                },

                ToObject: function (property) {
                    var v = property.$stored;
                    if (v === undefined || v === null || v === "") {
                        return null;
                    } else {
                        if (typeof v === 'string' || v instanceof String) {
                            return v;
                        }

                        return this.SimpleDeserialize(v, property);
                    }
                },

                SimpleDeserialize: function(v, property) {
                    var $t,
                        declaredType = property.$declaredType;
                    var settings = ($t = new Newtonsoft.Json.JsonSerializerSettings(), $t.SerializationBinder = new EleWise_ELMA_Core.EleWise.ELMA.Serialization.KnownTypesBinder(), $t.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, $t.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Objects, $t);

                    if (Array.isArray(v)) {
                        var val = [];
                        for (var i = 0; i < v.length; i++) {
                            try {
                                val[i] = Newtonsoft.Json.JsonConvert.DeserializeObject(v[i], declaredType, settings);
                            }
                            catch(e) {
                                val[i] = v[i];
                            }
                        }
                        return val;
                    }

                    if (typeof v === 'string' || v instanceof String) {
                        v = Newtonsoft.Json.JsonConvert.parse(v);
                    }

                    if ("$t" in v) {
                        return this.ToContract(property);
                    }

                    return Newtonsoft.Json.JsonConvert.DeserializeObject(v, declaredType, settings);
                },

                /* From Converters */
                FromObjectToDeclaredType: function (str, declaredType, context) {
                    if (str === undefined || str === null) {
                        if (!Bridge.Reflection.isValueType(declaredType)) {
                            return null;
                        }
                    }

                    var prop = {
                        $stored: str,
                        $declaredType: declaredType,
                        $context: context,
                        nullable: false
                    };

                    var typeName = declaredType.$$name;
                    if (typeName === "System.String") {
                        return str;
                    }

                    if (typeName.startsWith("System.Nullable")) {
                        prop.nullable = true;
                    }

                    if (prop.nullable) {
                        typeName = declaredType.$typeArguments[0].$$name;
                    }

                    if (typeName === "System.Int16" || typeName === "System.Int32") {
                        return this.ToInt32(prop);
                    }

                    if (typeName === "System.Int64") {
                        return this.ToInt64(prop);
                    }

                    if (typeName === "System.TimeSpan") {
                        return this.ToTimeSpan(prop);
                    }

                    if (typeName === "System.Boolean") {
                        return this.ToBoolean(prop);
                    }

                    if (typeName === "System.Guid") {
                        return this.ToGuid(prop);
                    }

                    if (typeName === "System.Byte[]") {
                        return this.ToByteArray(prop);
                    }

                    if (typeName === "System.DateTime") {
                        return this.ToDateTime(prop);
                    }

                    if (typeName === "System.Double") {
                        return this.ToDouble(prop);
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.Money") {
                        return new declaredType.$ctor1(this.ToDouble(prop));
                    }

                    if (typeName === "EleWise.ELMA.Files.BinaryFile") {
                        return this.ToBinaryFile(prop);
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.PasswordInfo") {
                        return this.ToPassword(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Common.DropDownItem") {
                        return this.ToDropDownItem(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Views.FormViewItem") {
                        return this.ToFormViewItem(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityInfo") {
                        return this.ToEntityInfo(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityListInfo") {
                        return this.ToEntityListInfo(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EnumInfo") {
                        return this.ToEnumInfo(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Types.References.ReferenceOnType") {
                        return this.ToReferenceOnType(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType") {
                        return this.ToReferenceOnEntityType(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntity") {
                        return this.ToReferenceOnEntity(prop);
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.ExceptionData") {
                        return this.ToExceptionData(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.Entity") {
                        return this.ToEntityHeader(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.ActionValue") {
                        return this.ToActionValue(prop);
                    }

                    if (typeName === "EleWise.ELMA.Model.Ranges.Int16Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int32Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int64Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.DoubleRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.DateTimeRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.MoneyRange") {
                        return this.ToRangeType(prop);
                    }

                    if (typeName.endsWith("[]")) {
                        prop.$declaredType = declaredType.$elementType;
                        return this.ToCollection(prop);
                    }

                    if (typeName.startsWith("System.Collections")) {
                        var args = Bridge.Reflection.getGenericArguments(declaredType);
                        if (args.length > 0) {
                            prop.$declaredType = args[System.Array.index(0, args)];
                        }
                        prop.$isCollection = true;
                        var stored = prop.$stored;
                        if (stored === undefined || stored === null) {
                            stored = prop.$stored = [];
                        }
                        if (Array.isArray(stored) === false) {
                            prop.$stored = Object.values(stored);
                        }
                        if (typeName.startsWith("System.Collections.Generic.ISet")) {
                            return this.ToSetCollection(prop);
                        }
                        return this.ToCollection(prop);
                    }

                    return this.ToContract(prop);
                },

                FromAny: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }
                    return ref.v.toString();
                },

                FromByteArray: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }
                    return System.String.replaceAll(System.BitConverter.toString(ref.v), "-", "");
                },

                FromDateTime: function (ref, p) {
                    return this.FromDateTimeValue(ref.v);
                },

                FromDateTimeValue: function (value) {
                    if (value === undefined || value === null) {
                        return null;
                    }
                    return System.DateTime.format(value, null, System.Globalization.CultureInfo.invariantCulture);
                },

                FromTimeSpan: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }
                    return ref.v.toString(null, System.Globalization.CultureInfo.invariantCulture);
                },

                FromDateTimeRange: function (ref, p) {
                    return this.FromDateTimeRangeValue(ref.v);
                },

                FromDateTimeRangeValue: function (value) {
                    if (value === undefined || value === null) {
                        return null;
                    }
                    var fromString = this.FromDateTimeValue(value.From);
                    var toString = this.FromDateTimeValue(value.To);
                    return {
                        "From": fromString,
                        "To": toString
                    };
                },

                FromRangeType: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }
                    var fromString = this.FromFormattableValue(ref.v.From);
                    var toString = this.FromFormattableValue(ref.v.To);
                    return {
                        "From": fromString,
                        "To": toString
                    };
                },

                FromRelativeDateTime: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }

                    var dateTimeRange = this.FromDateTimeRangeValue(ref.v.DateTimeRange);
                    return {
                        "DateTimeRange": dateTimeRange,
                        "IsRelative": ref.v.IsRelative,
                        "RelativeFrom": ref.v.RelativeFrom,
                        "RelativeTo": ref.v.RelativeTo
                    };
                },

                FromFormattable: function (ref, p) {
                    return this.FromFormattableValue(ref.v);
                },

                FromFormattableValue: function (value) {
                    if (value === undefined || value === null) {
                        return null;
                    }
                    return Bridge.format(value, null, System.Globalization.CultureInfo.invariantCulture);
                },

                FromContract: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }

                    return ref.v.$jsonObj;
                },

                FromEntityInfo: function (ref) {
                    if (ref.v == undefined) {
                        return null;
                    }

                    var $t;
                    var settings = ($t = new Newtonsoft.Json.JsonSerializerSettings(), $t.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, $t);
                    return Newtonsoft.Json.JsonConvert.SerializeObject(ref.v, settings);
                },

                FromActionValue: function (ref) {
                    if (ref.v == undefined) {
                        return null;
                    }

                    var $t;
                    var settings = ($t = new Newtonsoft.Json.JsonSerializerSettings(), $t.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, $t);
                    return Newtonsoft.Json.JsonConvert.SerializeObject(ref.v, settings);
                },

                FromEntityListInfo: function (ref) {
                    if (ref.v == undefined) {
                        return "[]";
                    }

                    var result = [];
                    var $t;
                    $t = Bridge.getEnumerator(ref.v.Items);
                    try {
                        while ($t.moveNext()) {
                            var item = $t.Current;
                            result.push(JSON.parse(this.FromEntityInfo({ v : item })));
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    }
                    return JSON.stringify(result);
                },

                FromEnumInfo: function (ref) {
                    if (ref.v == undefined) {
                        return null;
                    }

                    var $t;
                    var settings = ($t = new Newtonsoft.Json.JsonSerializerSettings(), $t.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, $t);
                    return Newtonsoft.Json.JsonConvert.SerializeObject(ref.v, settings);
                },

                FromCollection: function (ref, p) {
                    p.$isCollection = true;

                    if (ref.v === undefined || ref.v === null) {
                        var init = p.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            p.val = init.getValueAndClear();
                        }
                        else {
                            p.val = new (Reactive.EleWise.ELMA.Collections.ReactiveCollection$1(p.$declaredType)).$ctor1(p);
                        }
                        ref.v = p.val;
                        return p.val.json;
                    }

                    // Если пришла реактивная коллекция просто переприсваиваем
                    if (ref.v.$$name && ref.v.$$name.startsWith("EleWise.ELMA.Collections.ReactiveCollection$1")) {
                        return ref.v.json;
                    }

                    if (p.$declaredType === System.Object || p.$declaredType === undefined) {
                        // Пытаемся определить реальный тип коллекции
                        var type = Bridge.getType(ref.v);
                        if (Bridge.Reflection.isGenericType(type)) {
                            var $t;
                            p.$declaredType = ($t = Bridge.Reflection.getGenericArguments(Bridge.getType(ref.v)))[System.Array.index(0, $t)];
                        } else if (Bridge.Reflection.isArray(type)) {
                            p.$declaredType = type.$elementType;
                        } else {
                            p.$declaredType = System.Object;
                        }
                    }

                    p.val = new (Reactive.EleWise.ELMA.Collections.ReactiveCollection$1(p.$declaredType)).$ctor1(p);
                    p.val.clear();
                    p.val.addRange(ref.v);
                    ref.v = p.val;
                    return p.val.json;
                },

                FromSetCollection: function (ref, p) {
                    p.$isCollection = true;

                    if (ref.v === undefined || ref.v === null) {
                        var init = p.$init;
                        if (init !== undefined && init.$inited === false && init.$hasValue === true) {
                            p.val = init.getValueAndClear();
                        }
                        else {
                            p.val = new (Reactive.EleWise.ELMA.Collections.ReactiveSet$1(p.$declaredType)).$ctor1(p);
                        }
                        ref.v = p.val;
                        return p.val.json;
                    }

                    // Если пришла реактивная коллекция просто переприсваиваем
                    if (ref.v.$$name && ref.v.$$name.startsWith("EleWise.ELMA.Collections.ReactiveSet$1")) {
                        return ref.v.json;
                    }

                    if (p.$declaredType === System.Object || p.$declaredType === undefined) {
                        // Пытаемся определить реальный тип коллекции
                        var type = Bridge.getType(ref.v);
                        if (Bridge.Reflection.isGenericType(type)) {
                            var $t;
                            p.$declaredType = ($t = Bridge.Reflection.getGenericArguments(Bridge.getType(ref.v)))[System.Array.index(0, $t)];
                        } else if (Bridge.Reflection.isArray(type)) {
                            p.$declaredType = type.$elementType;
                        } else {
                            p.$declaredType = System.Object;
                        }
                    }

                    p.val = new (Reactive.EleWise.ELMA.Collections.ReactiveSet$1(p.$declaredType)).$ctor1(p);
                    p.val.clear();
                    var $t;
                    $t = Bridge.getEnumerator(ref.v);
                    try {
                        while ($t.moveNext()) {
                            var item = $t.Current;
                            p.val.add(item);
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    }
                    ref.v = p.val;
                    return p.val.json;
                },

                FromEntityHeader: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }

                    var context = p.$context;
                    if (context === undefined || context === null) {
                        context = p.$context = {}
                    }

                    var proxyGenerator = context.$proxyGenerator;
                    if (proxyGenerator === undefined || proxyGenerator === null) {
                        proxyGenerator = p.$context.$proxyGenerator = Reactive.modules.getCore().EleWise.ELMA.DTO.ProxyGeneratorServiceContext.ProxyGenerator
                    }

                    var extendEntityService = context.$extendEntityService;
                    if (extendEntityService === undefined || extendEntityService === null) {
                        extendEntityService = p.$context.$extendEntityService = Reactive.modules.getCore().EleWise.ELMA.DTO.ExtendEntityServiceContext.ExtendEntityService
                    }

                    ref.v = proxyGenerator.EntityStorage.TryAddInternal(ref.v, extendEntityService);
                    return ref.v.$jsonObj;
                },

                FromBook1C: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }

                    return {
                        "Id": ref.v.Id,
                        "$toString": ref.v.$toString,
                        "TypeUid": ref.v.TypeUid.ToString()
                    };
                },

                FromEnum: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }
                    return ref.v.toString();
                },

                FromDropDownItem: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }
                    return ref.v.toString();
                },

                FromReferenceOnType: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }
                    return {
                        "TypeUid": this.FromFormattableValue(ref.v.TypeUid),
                        "SubTypeUid": this.FromFormattableValue(ref.v.SubTypeUid)
                    };
                },

                FromReferenceOnEntityType: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }

                    return ref.v.toString();
                },

                FromReferenceOnEntity: function (ref, p) {
                    if ((ref.v === undefined || ref.v === null) && p.nullable === true) {
                        return null;
                    }

                    return ref.v.toString();
                },

                FromBinaryFile: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }
                    return {
                        "Name": ref.v.Name,
                        "Uid": this.FromFormattableValue(ref.v.Uid)
                    };
                },

                FromPassword: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }
                    return {
                        "Hash": ref.v.Hash,
                        "Salt": ref.v.Salt
                    };
                },

                FromExceptionData: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }

                    var result = {
                        "ExceptionCode": this.FromFormattable(ref.v.ExceptionCode),
                        "Message": ref.v.Message
                    };

                    var originalException = ref.v.OriginalException;
                    if (originalException !== null && originalException !== undefined) {
                        result["OriginalException"] = {
                            "Message": originalException.Message,
                            "StackTrace": originalException.StackTrace
                        }
                    }

                    return result;
                },

                FromObject: function (ref, p) {
                    if (ref.v === undefined || ref.v === null) {
                        return null;
                    }

                    if (typeof ref.v === 'string' || ref.v instanceof String) {
                        return ref.v;
                    }

                    if (ref.v.$jsonObj) {
                        return ref.v.$jsonObj;
                    }

                    var typeName = ref.v.$$name;
                    if (typeName === "System.Boolean"
                        || typeName === "System.Guid"
                        || typeName === "System.String") {
                        return this.FromAny(ref, p);
                    }

                    if (typeName === "System.Int16"
                        || typeName === "System.Int32"
                        || typeName === "System.Int64"
                        || typeName === "System.Double"
                        || typeName === "EleWise.ELMA.Common.Models.Money") {
                        return this.FromFormattable(ref, p);
                    }

                    if (typeName === "System.TimeSpan") {
                        return this.FromTimeSpan(ref, p);
                    }

                    if (typeName === "System.DateTime") {
                        return this.FromDateTime(ref, p);
                    }

                    if (typeName === "System.Byte[]") {
                        return this.FromByteArray(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Files.BinaryFile") {
                        return this.FromBinaryFile(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.PasswordInfo") {
                        return this.FromPassword(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Common.DropDownItem") {
                        return this.FromDropDownItem(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityInfo") {
                        return this.FromEntityInfo(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityListInfo") {
                        return this.FromEntityListInfo(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EnumInfo") {
                        return this.FromEnumInfo(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Types.References.ReferenceOnType") {
                        return this.FromReferenceOnType(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType") {
                        return this.FromReferenceOnEntityType(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntity") {
                        return this.FromReferenceOnEntity(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.ExceptionData") {
                        return this.FromExceptionData(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.Entity") {
                        return this.FromEntityHeader(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.ActionValue") {
                        return this.FromActionValue(ref, p);
                    }

                    if (typeName === "EleWise.ELMA.Model.Ranges.Int16Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int32Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int64Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.DoubleRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.DateTimeRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.MoneyRange") {
                        return this.FromRangeType(ref, p);
                    }

                    var type = Bridge.getType(ref.v);
                    var iSetType = System.Linq.Enumerable.from(Bridge.Reflection.getInterfaces(type), System.Type).firstOrDefault(function (a) {
                        return Bridge.Reflection.isGenericType(a) && Bridge.referenceEquals(Bridge.getTypeName(a), Bridge.getTypeName(System.Collections.Generic.ISet$1));
                    }, null);
                    if (iSetType !== null) {
                        p.$isCollection = true;
                        return this.FromSetCollection(ref, p);
                    }

                    if (Bridge.is(ref.v, System.Collections.ICollection)) {
                        p.$isCollection = true;
                        return this.FromCollection(ref, p);
                    }

                    var $t;
                    var settings = ($t = new Newtonsoft.Json.JsonSerializerSettings(), $t.SerializationBinder = new EleWise_ELMA_Core.EleWise.ELMA.Serialization.KnownTypesBinder(), $t.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, $t.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Objects, $t);
                    return Newtonsoft.Json.JsonConvert.SerializeObject(ref.v, settings);
                },

                getFromConverter: function (type) {
                    if (type === undefined || type === null) {
                        throw new System.NullReferenceException.$ctor1("Тип не может быть null");
                    }

                    type = EleWise_ELMA_Core.EleWise.ELMA.Extensions.TypeExtensions.GetNonNullableType(type);

                    var typeName = type.$$name;
                    if (typeName === "System.String"
                        || typeName === "System.Boolean") {
                        return this.FromAny;
                    }

                    if (typeName === "System.Int16"
                        || typeName === "System.Int32"
                        || typeName === "System.Int64"
                        || typeName === "System.Guid"
                        || typeName === "System.Double"
                        || typeName === "EleWise.ELMA.Common.Models.Money") {
                        return this.FromFormattable;
                    }

                    if (typeName === "System.TimeSpan") {
                        return this.FromTimeSpan;
                    }

                    if (typeName === "System.DateTime") {
                        return this.FromDateTime;
                    }

                    if (typeName === "System.Byte[]") {
                        return this.FromByteArray;
                    }

                    if (typeName === "EleWise.ELMA.Files.BinaryFile") {
                        return this.FromBinaryFile;
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.PasswordInfo") {
                        return this.FromPassword;
                    }

                    if (typeName === "EleWise.ELMA.Model.Common.DropDownItem") {
                        return this.FromDropDownItem;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityInfo") {
                        return this.FromEntityInfo;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityListInfo") {
                        return this.FromEntityListInfo;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EnumInfo") {
                        return this.FromEnumInfo;
                    }

                    if (typeName === "EleWise.ELMA.Model.Types.References.ReferenceOnType") {
                        return this.FromReferenceOnType;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType") {
                        return this.FromReferenceOnEntityType;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntity") {
                        return this.FromReferenceOnEntity;
                    }

                    if (typeName === "EleWise.ELMA.Common.Models.ExceptionData") {
                        return this.FromExceptionData;
                    }

                    if (typeName === "EleWise.ELMA.Model.Entities.Entity") {
                        return this.FromEntityHeader;
                    }

                    if (typeName === "EleWise.ELMA.Model.ActionValue") {
                        return this.FromActionValue;
                    }

                    if (typeName === "EleWise.ELMA.Model.Ranges.Int16Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int32Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.Int64Range"
                        || typeName === "EleWise.ELMA.Model.Ranges.DoubleRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.DateTimeRange"
                        || typeName === "EleWise.ELMA.Model.Ranges.MoneyRange") {
                        return this.FromRangeType;
                    }

                    var iSetType = System.Linq.Enumerable.from(Bridge.Reflection.getInterfaces(type), System.Type).firstOrDefault(function (a) {
                        return Bridge.Reflection.isGenericType(a) && Bridge.referenceEquals(Bridge.getTypeName(a), Bridge.getTypeName(System.Collections.Generic.ISet$1));
                    }, null);
                    if (iSetType !== null) {
                        return this.FromSetCollection;
                    }

                    var enumerableType = System.Linq.Enumerable.from(Bridge.Reflection.getInterfaces(type), System.Type).firstOrDefault(function (a) {
                        return Bridge.Reflection.isGenericType(a) && Bridge.referenceEquals(Bridge.getTypeName(a), Bridge.getTypeName(System.Collections.Generic.IEnumerable$1));
                    }, null);
                    if (enumerableType !== null) {
                        return this.FromCollection;
                    }

                    return this.FromObject;
                }
            }
        }
    });

// TODO: ELMA4-6705 выпилить
(function(){
    if (window.jQuery) {
        $(document).ready(function() {
            var forms = $('form');
            for (var i = 0; i < forms.length; i++) {
                var form = forms[i];
                var validator = $.data(form, "validator");
                if (validator) {
                    var formatAndAddFunc = function( element, rule ) {};
                    for (var n in $.validator.methods) {
                        var originalValidatorFunc = $.validator.methods[n];
                        $.validator.methods[n] = (function (originalFunc, validatorInstance, formatAndAddFunction) {
                            return function (value, element, param) {
                                if (element) {
                                    var formInputSelector = $(element).closest(".form-value");
                                    if (formInputSelector.length > 0) {
                                        var inputDiv = formInputSelector[0];
                                        if ("$validationFunction" in inputDiv) {
                                            // Во втором рантайме переписываем функцию добавления ошибки на инпуты
                                            if (validatorInstance.formatAndAdd !== formatAndAddFunction) {
                                                validatorInstance.formatAndAdd = formatAndAddFunction;
                                            }
                                            return inputDiv.$validationFunction();
                                        }
                                    }
                                }
                                // Значит форма первого рантайма - вызываем оригинальную функцию валидации
                                var f = originalFunc.bind(validatorInstance);
                                return f(value, element, param);
                            };
                        })(originalValidatorFunc, validator, formatAndAddFunc);
                    }
                    for (var n in validator.settings) {
                        var originalDefaultsFunc = validator.settings[n];
                        // Заменяем все функции, начинающиеся с on... в настройках валидаторов на пустые
                        // onsubmit, onfocusin, onfocusout, onkeyup, onclick
                        if (n.startsWith("on") && typeof originalDefaultsFunc === "function") {
                            validator.settings[n] = function (element, event) {
                                return;
                            };
                        }
                    }
                }
            }
        });
    }
})()
// TODO: Сделать шаблон и вынести в {SolutionDir}/.auxiliary/
    return Convert;    }));
});
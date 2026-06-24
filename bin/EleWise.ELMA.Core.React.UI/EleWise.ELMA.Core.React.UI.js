/**
 * @version 4.1.0.47200 R.local
 * @author ELMA
 * @copyright Copyright © 2006-2022 ELMA
 * @compiler Bridge.NET 17.8.0
 */
Bridge.assembly("EleWise.ELMA.Core.React.UI", function ($asm, globals) {
    "use strict";

    (function (root, factory) {
        if (typeof define === 'function' && define.amd) {
            define("EleWise_ELMA_Core_React_UI", factory);
        } else if (typeof module === 'object' && module.exports) {
            module.exports = factory();
        } else {
            root["EleWise_ELMA_Core_React_UI"] = factory();
        }
    }(this, function () {
        var EleWise_ELMA_Core_React_UI = { };
Bridge.define("EleWise.ELMA.Core.React.UI.Helpers.HashHelper", {
    $metadata: function()
    {
        return {
                att: 1048961, a: 2, s: true, m: [{
                            a: 2, n: "GenNewGuid", is: true, t: 8, pi: [{
                                        n: "uid", pt: System.Guid, ps: 0
                                    }, {
                                        n: "secret", dv: "", o: true, pt: System.String, ps: 1
                                    }], sn: "GenNewGuid", rt: System.Guid, p: [System.Guid, System.String]
                        }, {
                            a: 2, n: "GetHash", is: true, t: 8, pi: [{
                                        n: "s", pt: System.String, ps: 0
                                    }], tpc: 0, def: function(s)
                                {
                                    return elmaComponents.MD5.getHash(s)
                                }, rt: System.String, p: [System.String]
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI", statics: {methods: {GenNewGuid: function(uid, secret)
                {
                    if (secret === void 0)
                    {
                        secret = ""
                    }
                    
                    var newUid = {v: new System.Guid};
                    
                    System.Guid.TryParse(elmaComponents.MD5.getHash(System.String.format("{0}-{1}", uid.toString(), secret)), newUid);
                    
                    return newUid.v
                }}}
});
Bridge.define("EleWise.ELMA.Core.React.UI.Models.IHasDataTestId", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "DataTestId", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_DataTestId", t: 8, rt: System.String, fg: "DataTestId"
                                    }, s: {
                                        ab: true, a: 2, n: "set_DataTestId", t: 8, p: [System.String], rt: System.Void, fs: "DataTestId"
                                    }, fn: "DataTestId"
                            }, {
                                a: 1, backing: true, n: "<DataTestId>k__BackingField", t: 4, rt: System.String, sn: "DataTestId"
                            }]
                }
        }, $literal: true, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI"
});
Bridge.define("EleWise.ELMA.Core.React.UI.Models.IHasTooltip", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Tooltip", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Tooltip", t: 8, rt: System.String, fg: "Tooltip"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Tooltip", t: 8, p: [System.String], rt: System.Void, fs: "Tooltip"
                                    }, fn: "Tooltip"
                            }, {
                                a: 1, backing: true, n: "<Tooltip>k__BackingField", t: 4, rt: System.String, sn: "Tooltip"
                            }]
                }
        }, $literal: true, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI"
});
Bridge.define("EleWise.ELMA.Core.React.UI.Models.UploadResponse", {
    $metadata: function()
    {
        return {
                att: 1048833, a: 2, m: [{
                            a: 2, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "FileHref", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_FileHref", t: 8, rt: System.String, fg: "fileHref"
                                }, s: {
                                    a: 2, n: "set_FileHref", t: 8, p: [System.String], rt: System.Void, fs: "fileHref"
                                }, fn: "fileHref"
                        }, {
                            a: 2, n: "FileName", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_FileName", t: 8, rt: System.String, fg: "fileName"
                                }, s: {
                                    a: 2, n: "set_FileName", t: 8, p: [System.String], rt: System.Void, fs: "fileName"
                                }, fn: "fileName"
                        }, {
                            a: 2, n: "FileSize", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_FileSize", t: 8, rt: System.Int32, fg: "fileSize", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_FileSize", t: 8, p: [System.Int32], rt: System.Void, fs: "fileSize"
                                }, fn: "fileSize"
                        }, {
                            a: 2, n: "MaxFileSizeMb", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_MaxFileSizeMb", t: 8, rt: System.Int32, fg: "maxFileSizeMb", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_MaxFileSizeMb", t: 8, p: [System.Int32], rt: System.Void, fs: "maxFileSizeMb"
                                }, fn: "maxFileSizeMb"
                        }, {
                            a: 2, n: "Success", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_Success", t: 8, rt: System.Boolean, fg: "success", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_Success", t: 8, p: [System.Boolean], rt: System.Void, fs: "success"
                                }, fn: "success"
                        }, {
                            a: 2, n: "Uid", t: 16, rt: System.Guid, g: {
                                    a: 2, n: "get_Uid", t: 8, rt: System.Guid, fg: "uid"
                                }, s: {
                                    a: 2, n: "set_Uid", t: 8, p: [System.Guid], rt: System.Void, fs: "uid"
                                }, fn: "uid"
                        }, {
                            a: 2, n: "ValidMaxSize", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_ValidMaxSize", t: 8, rt: System.Boolean, fg: "validMaxSize", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_ValidMaxSize", t: 8, p: [System.Boolean], rt: System.Void, fs: "validMaxSize"
                                }, fn: "validMaxSize"
                        }, {
                            a: 2, n: "ValidSizeZero", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_ValidSizeZero", t: 8, rt: System.Boolean, fg: "validSizeZero", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_ValidSizeZero", t: 8, p: [System.Boolean], rt: System.Void, fs: "validSizeZero"
                                }, fn: "validSizeZero"
                        }, {
                            a: 1, backing: true, n: "<FileHref>k__BackingField", t: 4, rt: System.String, sn: "fileHref"
                        }, {
                            a: 1, backing: true, n: "<FileName>k__BackingField", t: 4, rt: System.String, sn: "fileName"
                        }, {
                            a: 1, backing: true, n: "<FileSize>k__BackingField", t: 4, rt: System.Int32, sn: "fileSize", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<MaxFileSizeMb>k__BackingField", t: 4, rt: System.Int32, sn: "maxFileSizeMb", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<Success>k__BackingField", t: 4, rt: System.Boolean, sn: "success", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<Uid>k__BackingField", t: 4, rt: System.Guid, sn: "uid"
                        }, {
                            a: 1, backing: true, n: "<ValidMaxSize>k__BackingField", t: 4, rt: System.Boolean, sn: "validMaxSize", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<ValidSizeZero>k__BackingField", t: 4, rt: System.Boolean, sn: "validSizeZero", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI", fields: {
            success: false, uid: null, fileName: null, fileHref: null, fileSize: 0, validMaxSize: false, validSizeZero: false, maxFileSizeMb: 0
        }, ctors: {
            init: function()
            {
                this.uid = new System.Guid
            }, ctor: function()
                {
                    this.$initialize();
                    
                    this.validMaxSize = true;
                    
                    this.validSizeZero = true
                }
        }
});
Bridge.define("EleWise.ELMA.Core.React.UI.Views.CheckboxChangeEvent", {
    $metadata: function()
    {
        return {
                att: 1048577, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Target", t: 16, rt: System.Object, g: {
                                    a: 2, n: "get_Target", t: 8, rt: System.Object, fg: "target"
                                }, s: {
                                    a: 2, n: "set_Target", t: 8, p: [System.Object], rt: System.Void, fs: "target"
                                }, fn: "target"
                        }, {
                            a: 1, backing: true, n: "<Target>k__BackingField", t: 4, rt: System.Object, sn: "target"
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI", fields: {target: null}
});
Bridge.define("EleWise.ELMA.Core.React.UI.Views.Notification", {
    $metadata: function()
    {
        return {
                nested: [System.Object, System.Object], att: 1048833, a: 2, m: [{
                            a: 2, n: ".ctor", t: 1, p: [System.Object], pi: [{
                                        n: "options", pt: System.Object, ps: 0
                                    }], def: function(options)
                                {
                                    return new elmaComponents.Notification(options)
                                }
                        }, {
                            a: 2, n: "Destroy", t: 8, sn: "destroy", rt: System.Void
                        }, {
                            a: 2, n: "Error", t: 8, pi: [{
                                        n: "title", pt: System.String, ps: 0
                                    }, {
                                        n: "message", pt: System.Object, ps: 1
                                    }], sn: "error", rt: System.Void, p: [System.String, System.Object]
                        }, {
                            a: 2, n: "Info", t: 8, pi: [{
                                        n: "title", pt: System.String, ps: 0
                                    }, {
                                        n: "message", pt: System.Object, ps: 1
                                    }], sn: "info", rt: System.Void, p: [System.String, System.Object]
                        }, {
                            a: 2, n: "Success", t: 8, pi: [{
                                        n: "title", pt: System.String, ps: 0
                                    }, {
                                        n: "message", pt: System.Object, ps: 1
                                    }], sn: "success", rt: System.Void, p: [System.String, System.Object]
                        }, {
                            a: 2, n: "Warning", t: 8, pi: [{
                                        n: "title", pt: System.String, ps: 0
                                    }, {
                                        n: "message", pt: System.Object, ps: 1
                                    }], sn: "warning", rt: System.Void, p: [System.String, System.Object]
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI"
});
Bridge.define("EleWise.ELMA.Core.React.UI.Views.RadioChangeEvent", {
    $metadata: function()
    {
        return {
                att: 1048577, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Target", t: 16, rt: System.Object, g: {
                                    a: 2, n: "get_Target", t: 8, rt: System.Object, fg: "target"
                                }, s: {
                                    a: 2, n: "set_Target", t: 8, p: [System.Object], rt: System.Void, fs: "target"
                                }, fn: "target"
                        }, {
                            a: 1, backing: true, n: "<Target>k__BackingField", t: 4, rt: System.Object, sn: "target"
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI", fields: {target: null}
});
Bridge.define("EleWise.ELMA.Core.React.UI.Views.RowNode", {
    $metadata: function()
    {
        return {
                att: 1048833, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Key", t: 16, rt: System.Object, g: {
                                    a: 2, n: "get_Key", t: 8, rt: System.Object, fg: "key"
                                }, s: {
                                    a: 2, n: "set_Key", t: 8, p: [System.Object], rt: System.Void, fs: "key"
                                }, fn: "key"
                        }, {
                            a: 2, n: "Selected", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_Selected", t: 8, rt: System.Boolean, fg: "selected", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_Selected", t: 8, p: [System.Boolean], rt: System.Void, fs: "selected"
                                }, fn: "selected"
                        }, {
                            a: 1, backing: true, n: "<Key>k__BackingField", t: 4, rt: System.Object, sn: "key"
                        }, {
                            a: 1, backing: true, n: "<Selected>k__BackingField", t: 4, rt: System.Boolean, sn: "selected", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_Core_React_UI, $module: "EleWise_ELMA_Core_React_UI", fields: {
            key: null, selected: false
        }
})
        Bridge.init();
        return EleWise_ELMA_Core_React_UI;
    }));

});

//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAiZmlsZSI6ICJFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5VSS5qcyIsCiAgInNvdXJjZVJvb3QiOiAiIiwKICAic291cmNlcyI6IFsiSGVscGVycy9IYXNoSGVscGVyLmNzIiwiTW9kZWxzL1VwbG9hZFJlc3BvbnNlLmNzIl0sCiAgIm5hbWVzIjogWyIiXSwKICAibWFwcGluZ3MiOiAiOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkEwQllBOztvQkFDQUE7O29CQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQ2JBQTs7b0JBQ0FBIiwKICAic291cmNlc0NvbnRlbnQiOiBbInVzaW5nIFN5c3RlbTtcclxudXNpbmcgQnJpZGdlO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5Db3JlLlJlYWN0LlVJLkhlbHBlcnNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCS0YHQv9C+0LzQvtCz0LDRgtC10LvRjNC90YvQuSDQutC70LDRgdGBINC00LvRjyDRgNCw0LHQvtGC0Ysg0YEg0YXRjdGI0LXQvFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBzdGF0aWMgY2xhc3MgSGFzaEhlbHBlclxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/QvtC70YPRh9C40YLRjCBNRDUg0YXRjdGIINC+0YIg0YHRgtGA0L7QutC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzXCI+PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+PC9yZXR1cm5zPlxyXG4gICAgICAgIFtUZW1wbGF0ZShcImVsbWFDb21wb25lbnRzLk1ENS5nZXRIYXNoKHtzfSlcIildXHJcbiAgICAgICAgcHVibGljIHN0YXRpYyBleHRlcm4gc3RyaW5nIEdldEhhc2goc3RyaW5nIHMpO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qu9GD0YfQuNGC0Ywg0L3QvtCy0YvQuSBHdWlkINC90LAg0L7RgdC90L7QstC1INGB0YLQsNGA0L7Qs9C+XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ1aWRcIj48L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInNlY3JldFwiPjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPjwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIEd1aWQgR2VuTmV3R3VpZCh0aGlzIEd1aWQgdWlkLCBzdHJpbmcgc2VjcmV0ID0gc3RyaW5nLkVtcHR5KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgR3VpZCBuZXdVaWQ7XHJcbiAgICAgICAgICAgIEd1aWQuVHJ5UGFyc2UoR2V0SGFzaChzdHJpbmcuRm9ybWF0KFwiezB9LXsxfVwiLHVpZC5Ub1N0cmluZygpLHNlY3JldCkpLCBvdXQgbmV3VWlkKTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ld1VpZDtcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn0iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIEJyaWRnZTtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuQ29yZS5SZWFjdC5VSS5Nb2RlbHNcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCe0YLQstC10YIg0YHQtdGA0LLQtdGA0LAg0L/RgNC4INC30LDQs9GA0YPQt9C60LUg0YTQsNC50LvQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBzZWFsZWQgY2xhc3MgVXBsb2FkUmVzcG9uc2VcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBVcGxvYWRSZXNwb25zZSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBWYWxpZE1heFNpemUgPSB0cnVlO1xyXG4gICAgICAgICAgICBWYWxpZFNpemVaZXJvID0gdHJ1ZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KPRgdC/0LXRiNC90L4g0LvQuCDQt9Cw0LLQtdGA0YjQuNC70YHRjyDQt9Cw0L/RgNC+0YFcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIFtOYW1lKFwic3VjY2Vzc1wiKV1cclxuICAgICAgICBwdWJsaWMgYm9vbCBTdWNjZXNzIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQo9C90LjQutCw0LvRjNC90YvQuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRhNCw0LnQu9CwINC90LAg0YHQtdGA0LLQtdGA0LVcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIFtOYW1lKFwidWlkXCIpXVxyXG4gICAgICAgIHB1YmxpYyBHdWlkIFVpZCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQvNGPINGE0LDQudC70LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIFtOYW1lKFwiZmlsZU5hbWVcIildXHJcbiAgICAgICAgcHVibGljIHN0cmluZyBGaWxlTmFtZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KHRgdGL0LvQutCwINC00LvRjyDRgdC60LDRh9C40LLQsNC90LjRjyDRhNCw0LnQu9CwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBbTmFtZShcImZpbGVIcmVmXCIpXVxyXG4gICAgICAgIHB1YmxpYyBzdHJpbmcgRmlsZUhyZWYgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCg0LDQt9C80LXRgCDRhNCw0LnQu9CwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBbTmFtZShcImZpbGVTaXplXCIpXVxyXG4gICAgICAgIHB1YmxpYyBpbnQgRmlsZVNpemUgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCU0L7Qv9GD0YHRgtC40Lwg0LvQuCDRgNCw0LfQvNC10YAg0YTQsNC50LvQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgW05hbWUoXCJ2YWxpZE1heFNpemVcIildXHJcbiAgICAgICAgcHVibGljIGJvb2wgVmFsaWRNYXhTaXplIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQpNCw0LnQuyDQvdC1INC/0YPRgdGC0L7QuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgW05hbWUoXCJ2YWxpZFNpemVaZXJvXCIpXVxyXG4gICAgICAgIHB1YmxpYyBib29sIFZhbGlkU2l6ZVplcm8geyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCc0LDQutGB0LjQvNCw0LvRjNC90YvQuSDRgNCw0LfQvNC10YAg0YTQsNC50LvQsCAo0JzQsSlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIFtOYW1lKFwibWF4RmlsZVNpemVNYlwiKV1cclxuICAgICAgICBwdWJsaWMgaW50IE1heEZpbGVTaXplTWIgeyBnZXQ7IHNldDsgfVxyXG4gICAgfVxyXG59XHJcbiJdCn0K

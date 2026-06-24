// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.PublicAppPropertyScriptError
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Результат возможности отображения свойств со сценариями во внешних приложениях (ошибка или предупреждение)
  /// </summary>
  public class PublicAppPropertyScriptError : IPublicApplicationCompatibilityError
  {
    private string _scriptTypeCode;
    private string _messageFormat;
    private List<string> _propertyNames;
    internal static PublicAppPropertyScriptError Ju5xopbivDGWDjPLEGrO;

    public PublicAppPropertyScriptError(
      string scriptTypeCode,
      string messageFormat,
      params string[] propertyNames)
    {
      PublicAppPropertyScriptError.rQ9kT0biuORYkUZfsj5J();
      this._propertyNames = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._scriptTypeCode = scriptTypeCode;
            num = 3;
            continue;
          case 2:
            if (propertyNames == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 3:
            this._messageFormat = messageFormat;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
          case 4:
            this._propertyNames.AddRange((IEnumerable<string>) propertyNames);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_8;
          default:
            this.IsError = true;
            num = 6;
            continue;
        }
      }
label_8:;
    }

    /// <summary>Если True, то это ошибка. Иначе предупреждение.</summary>
    public bool IsError
    {
      get => this.\u003CIsError\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsError\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Сообщение об ошибке</summary>
    public string Message
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PublicAppPropertyScriptError.ePl6BebiI2rRZ0sJKo82((object) this._messageFormat))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_2;
          }
        }
label_2:
        string format = EleWise.ELMA.SR.T((string) PublicAppPropertyScriptError.FbGfZnbiVru2CGJCmIpA(979449278 ^ 979602166));
        goto label_6;
label_5:
        format = this._messageFormat;
label_6:
        object obj1 = PublicAppPropertyScriptError.FbGfZnbiVru2CGJCmIpA(-1487388570 ^ -1487385500);
        List<string> propertyNames = this._propertyNames;
        Func<string, string> func = PublicAppPropertyScriptError.\u003C\u003Ec.\u003C\u003E9__6_0;
        Func<string, string> selector;
        if (func == null)
          PublicAppPropertyScriptError.\u003C\u003Ec.\u003C\u003E9__6_0 = selector = (Func<string, string>) (p => (string) PublicAppPropertyScriptError.\u003C\u003Ec.zFFaaQC1IdNS1yloWi1a(PublicAppPropertyScriptError.\u003C\u003Ec.ishulYC1uatucbfpViWg(-1317790512 ^ -1317797490), (object) p, PublicAppPropertyScriptError.\u003C\u003Ec.ishulYC1uatucbfpViWg(1654249598 >> 2 ^ 413559617)));
        else
          goto label_7;
label_9:
        string[] array = propertyNames.Select<string, string>(selector).ToArray<string>();
        object obj2 = PublicAppPropertyScriptError.EYd0jfbiS9T29eYrDm0o(obj1, (object) array);
        return string.Format(format, obj2);
label_7:
        selector = func;
        goto label_9;
      }
    }

    /// <summary>Код типа скрипта</summary>
    public string ScriptTypeCode => this._scriptTypeCode;

    /// <summary>Имена свойств</summary>
    public List<string> PropertyNames => this._propertyNames;

    internal static void rQ9kT0biuORYkUZfsj5J() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OuDyrTbi8DZrWnKnVDjp() => PublicAppPropertyScriptError.Ju5xopbivDGWDjPLEGrO == null;

    internal static PublicAppPropertyScriptError z4K59lbiZpVoLGdiEVYA() => PublicAppPropertyScriptError.Ju5xopbivDGWDjPLEGrO;

    internal static bool ePl6BebiI2rRZ0sJKo82([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object FbGfZnbiVru2CGJCmIpA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EYd0jfbiS9T29eYrDm0o([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);
  }
}

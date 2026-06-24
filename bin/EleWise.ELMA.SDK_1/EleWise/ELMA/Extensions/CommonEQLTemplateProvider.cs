// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.CommonEQLTemplateProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Провайдер EQL шаблона для общего случая</summary>
  [Component(Order = 2147483647)]
  internal sealed class CommonEQLTemplateProvider : IEQLTemplateProvider
  {
    private readonly IEnumerable<IObjectFormProvider> objectFormProviders;
    internal static CommonEQLTemplateProvider NDkswlG30i2HoNbP5ZYI;

    /// <summary>Ctor</summary>
    /// <param name="objectFormProviders">Провайдеры форм</param>
    public CommonEQLTemplateProvider(
      IEnumerable<IObjectFormProvider> objectFormProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.objectFormProviders = objectFormProviders;
    }

    /// <inheritdoc />
    public bool Check(Guid typeUid, Guid subTypeUid)
    {
      int num = 3;
      IObjectFormProvider objectFormProvider;
      Guid typeUid1;
      Guid subTypeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (provider => provider.Check(typeUid1, subTypeUid1)));
            if (objectFormProvider == null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 2:
            typeUid1 = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 3:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_7;
          default:
            subTypeUid1 = subTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
        }
      }
label_7:
      return false;
label_8:
      return CommonEQLTemplateProvider.Pel8ulG3MYAbiD0A55MF((object) objectFormProvider, typeUid1, subTypeUid1);
    }

    /// <inheritdoc />
    public object GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
    {
      int num1 = 6;
      IObjectFormProvider objectFormProvider;
      Guid typeUid1;
      Guid subTypeUid1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (provider => CommonEQLTemplateProvider.\u003C\u003Ec__DisplayClass3_0.BpP09N8FxttCxNO8Wt44((object) provider, typeUid1, subTypeUid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 3;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_4;
            case 4:
              goto label_9;
            case 5:
              typeUid1 = typeUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 6:
              num2 = 5;
              continue;
            default:
              subTypeUid1 = subTypeUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
          }
        }
label_4:
        if (objectFormProvider != null)
          num1 = 4;
        else
          break;
      }
label_8:
      return (object) null;
label_9:
      return objectFormProvider.GetObjectInfo(typeUid1, subTypeUid1, model).Item1;
    }

    internal static bool Pel8ulG3MYAbiD0A55MF([In] object obj0, Guid typeUid, Guid subTypeUid) => ((IObjectFormProvider) obj0).Check(typeUid, subTypeUid);

    internal static bool XeV0X8G3mSqNJASCB8PM() => CommonEQLTemplateProvider.NDkswlG30i2HoNbP5ZYI == null;

    internal static CommonEQLTemplateProvider Qvt3DjG3yU3WBvfDOg1v() => CommonEQLTemplateProvider.NDkswlG30i2HoNbP5ZYI;
  }
}

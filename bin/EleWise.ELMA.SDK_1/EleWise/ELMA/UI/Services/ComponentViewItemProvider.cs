// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.ComponentViewItemProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>
  /// Провайдер для получения формы компонента 2-го рантайма
  /// </summary>
  [Component]
  internal sealed class ComponentViewItemProvider : IObjectViewItemProvider
  {
    private readonly IEnumerable<IObjectFormProvider> objectFormProviders;
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    internal static ComponentViewItemProvider B2SNxYUwEeSgbVxb8AQ;

    /// <summary>Ctor</summary>
    /// <param name="objectFormProviders">Провайдеры форм</param>
    public ComponentViewItemProvider(
      IEnumerable<IObjectFormProvider> objectFormProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.objectFormProviders = objectFormProviders;
    }

    /// <inheritdoc />
    public Guid ProviderUid => ComponentViewItemProvider.UID;

    /// <inheritdoc />
    public ViewItem GetViewItem(string viewItemId)
    {
      int num = 2;
      IObjectFormProvider objectFormProvider;
      string[] strArray;
      Guid typeUid;
      Guid itemUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            strArray = viewItemId.Split(new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479510888)
            }, StringSplitOptions.None);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            if (objectFormProvider == null)
            {
              num = 6;
              continue;
            }
            goto label_3;
          case 5:
            itemUid = new Guid(strArray[1]);
            num = 7;
            continue;
          case 6:
            goto label_2;
          case 7:
            // ISSUE: reference to a compiler-generated method
            objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (p => ComponentViewItemProvider.\u003C\u003Ec__DisplayClass5_0.KLQvy2fUmfsbRo1U3qKb((object) p, typeUid, itemUid)));
            num = 4;
            continue;
          case 8:
            typeUid = new Guid(strArray[0]);
            num = 5;
            continue;
          default:
            if (strArray.Length >= 2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 8;
              continue;
            }
            goto label_5;
        }
      }
label_2:
      return (ViewItem) null;
label_3:
      return (ViewItem) ComponentViewItemProvider.mPjyl8UHG4q8gdVZmx2((object) objectFormProvider, (object) null, itemUid);
label_5:
      return (ViewItem) null;
    }

    static ComponentViewItemProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentViewItemProvider.UID = new Guid((string) ComponentViewItemProvider.GjhCmaUA7RleyGcmly0(132912447 ^ 132956497));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object mPjyl8UHG4q8gdVZmx2([In] object obj0, [In] object obj1, Guid formUid) => (object) ((IObjectFormProvider) obj0).GetFormByUid(obj1, formUid);

    internal static bool X8tlexU4FJar5fdHOnh() => ComponentViewItemProvider.B2SNxYUwEeSgbVxb8AQ == null;

    internal static ComponentViewItemProvider jDW3JEU6ATIajSoYj3i() => ComponentViewItemProvider.B2SNxYUwEeSgbVxb8AQ;

    internal static object GjhCmaUA7RleyGcmly0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.PropTypes.CustomValuesEntityXmlItems
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.ExtensionPoints.PropTypes
{
  /// <summary>Дополнительно сериализуемые свойства</summary>
  public class CustomValuesEntityXmlItems
  {
    private static CustomValuesEntityXmlItems nxIVNbEg2271BKVG0sky;

    /// <summary>Конструктор</summary>
    public CustomValuesEntityXmlItems()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Values = (IDictionary<string, object>) new Dictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Описание типа</summary>
    public ITypeDescriptor TypeDescriptor
    {
      get => this.\u003CTypeDescriptor\u003Ek__BackingField;
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
              this.\u003CTypeDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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

    /// <summary>Свойства</summary>
    public IDictionary<string, object> Values { get; set; }

    internal static bool iJYIEhEgeH1IdxOxPeUR() => CustomValuesEntityXmlItems.nxIVNbEg2271BKVG0sky == null;

    internal static CustomValuesEntityXmlItems xS158eEgPuVLCgEjZ5dI() => CustomValuesEntityXmlItems.nxIVNbEg2271BKVG0sky;
  }
}

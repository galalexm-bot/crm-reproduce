// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ValidationElementType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model
{
  /// <summary>Типы элементов валидации</summary>
  public static class ValidationElementType
  {
    /// <summary>Элемент представления компонента</summary>
    public static Guid ComponentViewItem;
    /// <summary>Элемент представления формы объекта</summary>
    public static Guid ObjectFormViewItem;
    /// <summary>Свойство</summary>
    public static Guid Property;
    /// <summary>Элемент представления</summary>
    public static Guid ViewItem;
    private static ValidationElementType iT1R2GWg1HadbPpb04wS;

    static ValidationElementType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ValidationElementType.TZK9o6Wgp17QUjrpWgv6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            ValidationElementType.Property = new Guid((string) ValidationElementType.RGnk5MWga2nmQTp7v3iq(~289714581 ^ -289836256));
            num = 3;
            continue;
          case 3:
            ValidationElementType.ViewItem = new Guid((string) ValidationElementType.RGnk5MWga2nmQTp7v3iq(272623989 ^ 272487663));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 5;
            continue;
          case 4:
            ValidationElementType.ObjectFormViewItem = new Guid((string) ValidationElementType.RGnk5MWga2nmQTp7v3iq(-2099751081 ^ -2099614803));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 2;
            continue;
          case 5:
            goto label_2;
          default:
            ValidationElementType.ComponentViewItem = new Guid((string) ValidationElementType.RGnk5MWga2nmQTp7v3iq(1642859704 ^ 1642999826));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 4 : 4;
            continue;
        }
      }
label_2:;
    }

    internal static void TZK9o6Wgp17QUjrpWgv6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object RGnk5MWga2nmQTp7v3iq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qoJae2WgNZRy0hNfG4Xs() => ValidationElementType.iT1R2GWg1HadbPpb04wS == null;

    internal static ValidationElementType RXjVBcWg3li86ZLipv21() => ValidationElementType.iT1R2GWg1HadbPpb04wS;
  }
}

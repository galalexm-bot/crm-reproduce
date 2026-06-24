// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.Components.LicenseActivationComponent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ComponentModel.Components
{
  [Component]
  internal class LicenseActivationComponent : IInitHandler
  {
    internal static LicenseActivationComponent XO1jHOfutSrStsvH6R5u;

    /// <summary>
    /// Начало инициализации (могут использоваться свойства ComponentManager.Current и ComponentManager.Builder)
    /// </summary>
    public void Init()
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_52;
          case 1:
            goto label_3;
          case 2:
            memoryStream = MemoryHelper.GetMemoryStream((byte[]) LicenseActivationComponent.ndfpVYfu6mmJOnFm1P83(), false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
          default:
            goto label_47;
        }
      }
label_52:
      return;
label_47:
      return;
label_3:
      try
      {
        memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
        int num2 = 34;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          num2 = 9;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 11 : 14;
              continue;
            case 2:
              new Aspose.PSD.License().SetLicense((Stream) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 30;
              continue;
            case 3:
              LicenseActivationComponent.cfdK6kfudgTv7rb5iIHY((object) new Aspose.Html.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 25 : 18;
              continue;
            case 4:
              LicenseActivationComponent.HENABKfuMRY8q7FbI7Yo((object) new Aspose.CAD.License(), (object) memoryStream);
              num2 = 36;
              continue;
            case 5:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 19;
              continue;
            case 6:
              new Aspose.Pub.License().SetLicense((Stream) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 12 : 4;
              continue;
            case 7:
              LicenseActivationComponent.i7Iv8ZfugbQo3juK7fmo((object) new Aspose.Svg.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 25 : 29;
              continue;
            case 8:
              LicenseActivationComponent.SgDF3IfuxAT8LgYc5BRf((object) new Aspose.Diagram.License(), (object) memoryStream);
              num2 = 37;
              continue;
            case 9:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 7 : 13;
              continue;
            case 10:
              LicenseActivationComponent.kSblPEfuyfrrxLNt8IrE((object) new Aspose.Pdf.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 9 : 6;
              continue;
            case 11:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 4;
              continue;
            case 12:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 6 : 7;
              continue;
            case 13:
              new Aspose.ThreeD.License().SetLicense((Stream) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 5;
              continue;
            case 14:
              new Aspose.OMR.License().SetLicense((Stream) memoryStream);
              num3 = 38;
              break;
            case 15:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 6 : 28;
              continue;
            case 16:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 8;
              continue;
            case 17:
              LicenseActivationComponent.Yr2I02fu9yhYY7BVdQ88((object) new Aspose.Font.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 33 : 5;
              continue;
            case 18:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = 10;
              continue;
            case 19:
              new Aspose.BarCode.License().SetLicense((Stream) memoryStream);
              num3 = 11;
              break;
            case 20:
              LicenseActivationComponent.SJ3XpdfuJpMJDOugdQte((object) new Aspose.Finance.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 32 : 11;
              continue;
            case 21:
              LicenseActivationComponent.EgouyyfulNur8M3ubiER((object) new Aspose.Imaging.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
            case 22:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 27;
              continue;
            case 23:
              LicenseActivationComponent.g4EeEsfu0TPh0AZ3ut2J((object) new Aspose.Slides.License(), (object) memoryStream);
              num2 = 15;
              continue;
            case 24:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 22 : 26;
              continue;
            case 25:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = 21;
              continue;
            case 26:
              new Aspose.Words.License().SetLicense((Stream) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 17 : 22;
              continue;
            case 27:
              LicenseActivationComponent.IevMNXfu7ODbBrG2QWoK((object) new Aspose.Email.License(), (object) memoryStream);
              num2 = 16;
              continue;
            case 28:
              LicenseActivationComponent.mGnfCEfumXad78aHRRhI((object) new Aspose.Note.License(), (object) memoryStream);
              num2 = 18;
              continue;
            case 29:
              goto label_7;
            case 30:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 6 : 6;
              continue;
            case 31:
              LicenseActivationComponent.h8CnAmfurx5SdkhgtXVR((object) new Aspose.Page.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            case 32:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 17;
              continue;
            case 33:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 3;
              continue;
            case 34:
              new Aspose.Tasks.License().SetLicense((Stream) memoryStream);
              num2 = 35;
              continue;
            case 35:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = 39;
              continue;
            case 36:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = 20;
              continue;
            case 37:
              memoryStream.Seek(0L, System.IO.SeekOrigin.Begin);
              num2 = 23;
              continue;
            case 38:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num3 = 31;
              break;
            case 39:
              LicenseActivationComponent.YhWwnlfuHCTCqlYw83yi((object) new Aspose.Cells.License(), (object) memoryStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 21 : 24;
              continue;
            default:
              LicenseActivationComponent.zDJMFLfuAHq42tIfiMsE((object) memoryStream, 0L, System.IO.SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
              continue;
          }
          num2 = num3;
        }
label_7:;
      }
      finally
      {
        if (memoryStream != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                LicenseActivationComponent.YGHmGFfu5Jedyoa8XKLj((object) memoryStream);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              default:
                goto label_54;
            }
          }
        }
label_54:;
      }
    }

    /// <summary>Завершение инициализации (доступен Locator)</summary>
    public void InitComplete()
    {
    }

    public LicenseActivationComponent()
    {
      LicenseActivationComponent.HwGEK6fuj04YWetGf9Wh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ndfpVYfu6mmJOnFm1P83() => (object) EleWise.ELMA.Properties.Resources.Aspose_Total;

    internal static void YhWwnlfuHCTCqlYw83yi([In] object obj0, [In] object obj1) => ((Aspose.Cells.License) obj0).SetLicense((Stream) obj1);

    internal static long zDJMFLfuAHq42tIfiMsE([In] object obj0, [In] long obj1, [In] System.IO.SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void IevMNXfu7ODbBrG2QWoK([In] object obj0, [In] object obj1) => ((Aspose.Email.License) obj0).SetLicense((Stream) obj1);

    internal static void SgDF3IfuxAT8LgYc5BRf([In] object obj0, [In] object obj1) => ((Aspose.Diagram.License) obj0).SetLicense((Stream) obj1);

    internal static void g4EeEsfu0TPh0AZ3ut2J([In] object obj0, [In] object obj1) => __nonvirtual (((Aspose.Slides.License) obj0).SetLicense((Stream) obj1));

    internal static void mGnfCEfumXad78aHRRhI([In] object obj0, [In] object obj1) => ((Aspose.Note.License) obj0).SetLicense((Stream) obj1);

    internal static void kSblPEfuyfrrxLNt8IrE([In] object obj0, [In] object obj1) => ((Aspose.Pdf.License) obj0).SetLicense((Stream) obj1);

    internal static void HENABKfuMRY8q7FbI7Yo([In] object obj0, [In] object obj1) => ((Aspose.CAD.License) obj0).SetLicense((Stream) obj1);

    internal static void SJ3XpdfuJpMJDOugdQte([In] object obj0, [In] object obj1) => ((Aspose.Finance.License) obj0).SetLicense((Stream) obj1);

    internal static void Yr2I02fu9yhYY7BVdQ88([In] object obj0, [In] object obj1) => ((Aspose.Font.License) obj0).SetLicense((Stream) obj1);

    internal static void cfdK6kfudgTv7rb5iIHY([In] object obj0, [In] object obj1) => ((Aspose.Html.License) obj0).SetLicense((Stream) obj1);

    internal static void EgouyyfulNur8M3ubiER([In] object obj0, [In] object obj1) => ((Aspose.Imaging.License) obj0).SetLicense((Stream) obj1);

    internal static void h8CnAmfurx5SdkhgtXVR([In] object obj0, [In] object obj1) => ((Aspose.Page.License) obj0).SetLicense((Stream) obj1);

    internal static void i7Iv8ZfugbQo3juK7fmo([In] object obj0, [In] object obj1) => ((Aspose.Svg.License) obj0).SetLicense((Stream) obj1);

    internal static void YGHmGFfu5Jedyoa8XKLj([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool GAwBaJfuwHsHkuydFXif() => LicenseActivationComponent.XO1jHOfutSrStsvH6R5u == null;

    internal static LicenseActivationComponent jhcZPifu4AK1rwxUDyMX() => LicenseActivationComponent.XO1jHOfutSrStsvH6R5u;

    internal static void HwGEK6fuj04YWetGf9Wh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

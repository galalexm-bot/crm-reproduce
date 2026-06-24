// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.HtmlStringTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class HtmlStringTypeEncrypter : BaseTypeEncrypter
  {
    internal static HtmlStringTypeEncrypter KViGTNoLWQFTha3fit7p;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num1 = 1;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyMetadata1 = propertyMetadata as PropertyMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_6:
        if (propertyMetadata1 == null)
          num1 = 3;
        else
          break;
      }
label_3:
      return HtmlStringTypeEncrypter.y5hi0woLG7biL7GPAGOV(HtmlStringTypeEncrypter.G7Tt4roLhTgRF7DHJi9B((object) propertyMetadata1), HtmlStringDescriptor.UID);
label_4:
      return false;
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) new HtmlString(obj);
    }

    public override object EncryptStub(object obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) new HtmlString((string) HtmlStringTypeEncrypter.XsHQ6uoLEqJxdDrMU8Ji((object) this, obj, (object) propertyMetadata));
    }

    public HtmlStringTypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid G7Tt4roLhTgRF7DHJi9B([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool y5hi0woLG7biL7GPAGOV([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool jkLZNkoLoUDFquWEFUlq() => HtmlStringTypeEncrypter.KViGTNoLWQFTha3fit7p == null;

    internal static HtmlStringTypeEncrypter MseEGdoLbIRtViXbgkhE() => HtmlStringTypeEncrypter.KViGTNoLWQFTha3fit7p;

    internal static object XsHQ6uoLEqJxdDrMU8Ji([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((BaseTypeEncrypter) obj0).GetMaskedVal(obj1, (IMetadata) obj2);
  }
}

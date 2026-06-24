// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.BoolTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class BoolTypeEncrypter : BaseTypeEncrypter
  {
    internal static BoolTypeEncrypter HgaT7YoYocd5fejBvvak;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata1 == null)
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return BoolTypeEncrypter.bwNSK5oYEb9XdVhsQvCW(BoolTypeEncrypter.Mj6YF9oYGwwVFX19S2fD((object) propertyMetadata1), BoolDescriptor.UID);
label_5:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            if (BoolTypeEncrypter.nvVuBEoYfWRFQEgfjlHU((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
              continue;
            }
            goto label_8;
          default:
            goto label_7;
        }
      }
label_6:
      return string.Empty;
label_7:
      return base.ObjectToString((object) BoolTypeEncrypter.FPUT68oYQslsDpV2VmQC(obj), propertyMetadata);
label_8:
      return base.ObjectToString(obj, propertyMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((PropertyMetadata) propertyMetadata).Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          default:
            if (!BoolTypeEncrypter.MIyUxDoYCDDq5VnfHAwW((object) obj))
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return (object) null;
label_7:
      return (object) BoolTypeEncrypter.bAjA1roYvdYTIrSI9JOE((object) obj);
    }

    public BoolTypeEncrypter()
    {
      BoolTypeEncrypter.oetLlpoY8jycmxcjoYli();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid Mj6YF9oYGwwVFX19S2fD([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool bwNSK5oYEb9XdVhsQvCW([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool K2AbTkoYbpSXeiaA1306() => BoolTypeEncrypter.HgaT7YoYocd5fejBvvak == null;

    internal static BoolTypeEncrypter K19ffEoYhg5uIm4yCM2N() => BoolTypeEncrypter.HgaT7YoYocd5fejBvvak;

    internal static bool nvVuBEoYfWRFQEgfjlHU([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool FPUT68oYQslsDpV2VmQC([In] object obj0) => Convert.ToBoolean(obj0);

    internal static bool MIyUxDoYCDDq5VnfHAwW([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool bAjA1roYvdYTIrSI9JOE([In] object obj0) => Convert.ToBoolean((string) obj0);

    internal static void oetLlpoY8jycmxcjoYli() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

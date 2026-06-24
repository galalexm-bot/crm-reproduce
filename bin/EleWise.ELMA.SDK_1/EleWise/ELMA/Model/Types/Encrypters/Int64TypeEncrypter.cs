// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.Int64TypeEncrypter
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
  public class Int64TypeEncrypter : BaseTypeEncrypter
  {
    internal static Int64TypeEncrypter RLP64DoLfSgcvEj5ixWR;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 3;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (propertyMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return Int64TypeEncrypter.qweyeSoL8tqhY7fOnWTn(Int64TypeEncrypter.n7mVtqoLvpUCsYnbYoWs((object) propertyMetadata1), Int64Descriptor.UID);
label_3:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!Int64TypeEncrypter.suHqB2oLZ8lsmdsAm4Vu((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return string.Empty;
label_7:
      return base.ObjectToString((object) Convert.ToInt64(obj), propertyMetadata);
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
            if (Int64TypeEncrypter.suHqB2oLZ8lsmdsAm4Vu((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          default:
            if (Int64TypeEncrypter.ecgeGNoLuQvDVlyCp52A((object) obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) Int64TypeEncrypter.zSTfcuoLICu90iyG87De((object) obj);
    }

    public Int64TypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid n7mVtqoLvpUCsYnbYoWs([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool qweyeSoL8tqhY7fOnWTn([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool FLeFvYoLQPDMb8GdHYkl() => Int64TypeEncrypter.RLP64DoLfSgcvEj5ixWR == null;

    internal static Int64TypeEncrypter L7chEsoLCBrRbXPOEcQJ() => Int64TypeEncrypter.RLP64DoLfSgcvEj5ixWR;

    internal static bool suHqB2oLZ8lsmdsAm4Vu([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool ecgeGNoLuQvDVlyCp52A([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static long zSTfcuoLICu90iyG87De([In] object obj0) => Convert.ToInt64((string) obj0);
  }
}

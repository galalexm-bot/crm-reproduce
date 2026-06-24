// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.DateTimeTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class DateTimeTypeEncrypter : BaseTypeEncrypter
  {
    internal static DateTimeTypeEncrypter yOlqQeoYZtfOfX0NuseU;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return DateTimeTypeEncrypter.lImEumoYVeGfYlXGEHro(propertyMetadata1.TypeUid, DateTimeDescriptor.UID);
label_6:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata) => ClassSerializationHelper.SerializeObjectByXml((object) new DateTimeWrapper((DateTime?) obj));

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 9;
      PropertyMetadata propertyMetadata1;
      DateTime? objectFromString;
      while (true)
      {
        switch (num)
        {
          case 1:
            objectFromString = ClassSerializationHelper.DeserializeObjectByXml<DateTimeWrapper>(obj).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 4 : 7;
            continue;
          case 2:
            if (!string.IsNullOrEmpty(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
              continue;
            }
            goto label_11;
          case 3:
            goto label_4;
          case 4:
            goto label_5;
          case 5:
            goto label_11;
          case 6:
            goto label_13;
          case 7:
            if (!DateTimeTypeEncrypter.tNGLKvoYSmI2ko3PnEtN((object) propertyMetadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 8:
            if (propertyMetadata1.Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
              continue;
            }
            goto case 1;
          case 9:
            propertyMetadata1 = (PropertyMetadata) propertyMetadata;
            num = 8;
            continue;
          default:
            if (objectFromString.HasValue)
            {
              num = 4;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (object) DateTime.MinValue;
label_5:
      return (object) objectFromString.Value;
label_11:
      return (object) null;
label_13:
      return (object) objectFromString;
    }

    public DateTimeTypeEncrypter()
    {
      DateTimeTypeEncrypter.s0PraeoYiUK2w5K7uAnE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lImEumoYVeGfYlXGEHro([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool FPGUGGoYux0HWDTGlvPx() => DateTimeTypeEncrypter.yOlqQeoYZtfOfX0NuseU == null;

    internal static DateTimeTypeEncrypter nYtSbVoYIsgDfjib4jTM() => DateTimeTypeEncrypter.yOlqQeoYZtfOfX0NuseU;

    internal static bool tNGLKvoYSmI2ko3PnEtN([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void s0PraeoYiUK2w5K7uAnE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

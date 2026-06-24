// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.TimeSpanTypeEncrypter
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
  public class TimeSpanTypeEncrypter : BaseTypeEncrypter
  {
    internal static TimeSpanTypeEncrypter pkgcp7oLJP1OhRDEMZik;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return TimeSpanTypeEncrypter.YTVZeuoLr28VwPrYGwsC(TimeSpanTypeEncrypter.phoDjGoLl33i33n2iSJm((object) propertyMetadata1), TimeSpanDescriptor.UID);
label_4:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata) => ClassSerializationHelper.SerializeObjectByXml((object) new TimeSpanWrapper((TimeSpan?) obj));

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 1;
      TimeSpan? objectFromString;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyMetadata1 = (PropertyMetadata) propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            if (TimeSpanTypeEncrypter.DFxrhToLgEyGJijWIMhE((object) propertyMetadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 5;
              continue;
            }
            if (!objectFromString.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 0;
              continue;
            }
            goto label_3;
          case 3:
            goto label_9;
          case 4:
            objectFromString = ClassSerializationHelper.DeserializeObjectByXml<TimeSpanWrapper>(obj).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_13;
          case 7:
            if (TimeSpanTypeEncrypter.Hj7NlaoL5B8CgFYJVDl4((object) obj))
            {
              num = 3;
              continue;
            }
            goto case 4;
          default:
            if (!TimeSpanTypeEncrypter.DFxrhToLgEyGJijWIMhE((object) propertyMetadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 0;
              continue;
            }
            goto case 7;
        }
      }
label_2:
      return (object) new TimeSpan(0, 0, 0, 0);
label_3:
      return (object) objectFromString.Value;
label_9:
      return (object) null;
label_13:
      return (object) objectFromString;
    }

    public TimeSpanTypeEncrypter()
    {
      TimeSpanTypeEncrypter.IdN7NMoLjOesc9bs6O9U();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid phoDjGoLl33i33n2iSJm([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool YTVZeuoLr28VwPrYGwsC([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool iecE1LoL9K1jYrTn6wdg() => TimeSpanTypeEncrypter.pkgcp7oLJP1OhRDEMZik == null;

    internal static TimeSpanTypeEncrypter AJPjAgoLdCxF5MpWnTP9() => TimeSpanTypeEncrypter.pkgcp7oLJP1OhRDEMZik;

    internal static bool DFxrhToLgEyGJijWIMhE([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool Hj7NlaoL5B8CgFYJVDl4([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void IdN7NMoLjOesc9bs6O9U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

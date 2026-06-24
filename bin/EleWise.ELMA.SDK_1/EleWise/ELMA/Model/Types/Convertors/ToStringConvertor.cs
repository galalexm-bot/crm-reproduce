// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToStringConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToStringConvertor : TypeConvertor
  {
    internal static ToStringConvertor Oy2mvZojPO51hG4Xew4E;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      Int16Descriptor.UID,
      Int32Descriptor.UID,
      Int64Descriptor.UID,
      GuidDescriptor.UID,
      BoolDescriptor.UID,
      EnumDescriptor.UID,
      DateTimeDescriptor.UID,
      DoubleDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID,
      StringDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      StringDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num = 2;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj is DateTime)
            {
              num = 4;
              continue;
            }
            goto label_9;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_8;
          case 4:
            dateTime = (DateTime) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) string.Empty;
label_8:
      return (object) dateTime.ToString((string) ToStringConvertor.dAsL5ioj3JZDfmnLnFpd(--1333735954 ^ 1333773714));
label_9:
      return (object) obj.ToString();
    }

    public ToStringConvertor()
    {
      ToStringConvertor.fgKxhIojpcMeDN3U7DA3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object dAsL5ioj3JZDfmnLnFpd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool NwP50xoj1hftL8H5XamC() => ToStringConvertor.Oy2mvZojPO51hG4Xew4E == null;

    internal static ToStringConvertor bbGc4nojNFPxmCMQsKve() => ToStringConvertor.Oy2mvZojPO51hG4Xew4E;

    internal static void fgKxhIojpcMeDN3U7DA3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

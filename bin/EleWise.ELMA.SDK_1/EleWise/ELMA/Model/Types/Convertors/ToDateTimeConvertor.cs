// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToDateTimeConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToDateTimeConvertor : TypeConvertor
  {
    private static ToDateTimeConvertor QdfsROo5Uh126OhEUuDQ;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      DateTimeDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID,
      StringDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      DateTimeDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 1;
      DateTime? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = new DateTime?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          default:
            if (obj != null)
            {
              num1 = 3;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (object) nullable;
label_4:
      try
      {
        nullable = (DateTime?) ToDateTimeConvertor.HejwOIo5zSYo0R8ngGpp(obj, TypeCode.DateTime);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_3;
        }
      }
    }

    public ToDateTimeConvertor()
    {
      ToDateTimeConvertor.l2m5bjojFgQjHIAKp3r2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object HejwOIo5zSYo0R8ngGpp([In] object obj0, [In] TypeCode obj1) => Convert.ChangeType(obj0, obj1);

    internal static bool HTutxbo5sHobEoAMN4xA() => ToDateTimeConvertor.QdfsROo5Uh126OhEUuDQ == null;

    internal static ToDateTimeConvertor o1rRlEo5cAd2nb1QMgjb() => ToDateTimeConvertor.QdfsROo5Uh126OhEUuDQ;

    internal static void l2m5bjojFgQjHIAKp3r2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToDoubleConvertor
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
  public class ToDoubleConvertor : TypeConvertor
  {
    internal static ToDoubleConvertor lFAQLtojQTIk7S6Egole;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      Int16Descriptor.UID,
      Int32Descriptor.UID,
      Int64Descriptor.UID,
      BoolDescriptor.UID,
      EnumDescriptor.UID,
      DoubleDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID,
      StringDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      DoubleDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 2;
      double? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 3;
              continue;
            }
            goto label_9;
          case 2:
            nullable = new double?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_3:
      try
      {
        nullable = (double?) ToDoubleConvertor.xQaUdooj8fnoSa3Ar587(obj, TypeCode.Double);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
label_9:
      return (object) nullable;
    }

    public ToDoubleConvertor()
    {
      ToDoubleConvertor.J1kDXQojZYs8ZsAETf3v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object xQaUdooj8fnoSa3Ar587([In] object obj0, [In] TypeCode obj1) => Convert.ChangeType(obj0, obj1);

    internal static bool i9Qp0kojCxvlyMGnxf68() => ToDoubleConvertor.lFAQLtojQTIk7S6Egole == null;

    internal static ToDoubleConvertor HbT0gPojvE25am1YV78w() => ToDoubleConvertor.lFAQLtojQTIk7S6Egole;

    internal static void J1kDXQojZYs8ZsAETf3v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

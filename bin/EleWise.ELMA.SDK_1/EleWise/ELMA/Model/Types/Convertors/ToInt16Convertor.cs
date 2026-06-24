// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToInt16Convertor
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
  public class ToInt16Convertor : TypeConvertor
  {
    internal static ToInt16Convertor upDgABojKj6cfM7gjBI4;

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
      Int16Descriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 2;
      short? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            nullable = new short?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (object) nullable;
label_3:
      try
      {
        nullable = (short?) ToInt16Convertor.kug88OojkhJrDgoPgJ51(obj, TypeCode.Int16);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
    }

    public ToInt16Convertor()
    {
      ToInt16Convertor.G5JYwSojnhehCRsVrJ7p();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object kug88OojkhJrDgoPgJ51([In] object obj0, [In] TypeCode obj1) => Convert.ChangeType(obj0, obj1);

    internal static bool lcwdsyojXV3c77IRggtx() => ToInt16Convertor.upDgABojKj6cfM7gjBI4 == null;

    internal static ToInt16Convertor DogpQFojT37mv4C8xxtC() => ToInt16Convertor.upDgABojKj6cfM7gjBI4;

    internal static void G5JYwSojnhehCRsVrJ7p() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

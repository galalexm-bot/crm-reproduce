// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToInt64Convertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToInt64Convertor : TypeConvertor
  {
    internal static ToInt64Convertor ywoTesoju66IZKJh18AL;

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
      Int64Descriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 1;
      long? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = new long?(0L);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          case 3:
            goto label_4;
          default:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 2;
              continue;
            }
            goto label_11;
        }
      }
label_4:
      try
      {
        nullable = (long?) Convert.ChangeType(obj, TypeCode.Int64);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
label_11:
      return (object) nullable;
    }

    public ToInt64Convertor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SxxAIiojI7g8uXYjDVnd() => ToInt64Convertor.ywoTesoju66IZKJh18AL == null;

    internal static ToInt64Convertor QS9uIHojVTZ0Ve2X2l5S() => ToInt64Convertor.ywoTesoju66IZKJh18AL;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToInt32Convertor
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
  public class ToInt32Convertor : TypeConvertor
  {
    internal static ToInt32Convertor cP6AqBojS1sr89uw5LXs;

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
      Int32Descriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 3;
      int? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            nullable = new int?(0);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return (object) nullable;
label_4:
      try
      {
        nullable = (int?) Convert.ChangeType(obj, TypeCode.Int32);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
    }

    public ToInt32Convertor()
    {
      ToInt32Convertor.SUNWDYojq1kg1kpJwGDe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool u1juFJojiSY759ND6ObU() => ToInt32Convertor.cP6AqBojS1sr89uw5LXs == null;

    internal static ToInt32Convertor NCE3etojRyluFPP4W70N() => ToInt32Convertor.cP6AqBojS1sr89uw5LXs;

    internal static void SUNWDYojq1kg1kpJwGDe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

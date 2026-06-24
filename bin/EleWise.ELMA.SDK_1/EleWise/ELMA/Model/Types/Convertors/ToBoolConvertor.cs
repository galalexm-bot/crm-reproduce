// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToBoolConvertor
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
  public class ToBoolConvertor : TypeConvertor
  {
    internal static ToBoolConvertor ndZFvvojBwocxhlL3Bka;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      BoolDescriptor.UID,
      Int16Descriptor.UID,
      Int32Descriptor.UID,
      Int64Descriptor.UID,
      DoubleDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID,
      StringDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      BoolDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 2;
      bool? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 3;
              continue;
            }
            goto label_2;
          case 2:
            nullable = new bool?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) nullable;
label_3:
      try
      {
        nullable = (bool?) ToBoolConvertor.HF9M8NojboITpZL9yHWW(obj, TypeCode.Boolean);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
    }

    public ToBoolConvertor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object HF9M8NojboITpZL9yHWW([In] object obj0, [In] TypeCode obj1) => Convert.ChangeType(obj0, obj1);

    internal static bool Deq9JGojWmY2v1QHjG6T() => ToBoolConvertor.ndZFvvojBwocxhlL3Bka == null;

    internal static ToBoolConvertor VWtmXCojoNqravriyBKt() => ToBoolConvertor.ndZFvvojBwocxhlL3Bka;
  }
}

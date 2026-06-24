// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EntityPropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут свойства сущности</summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class EntityPropertyAttribute : Attribute
  {
    internal static EntityPropertyAttribute ScXktHoIzyv2mWvGs152;

    /// <summary>
    /// Указывает номер таблицы сущности (для больших сущностей)
    /// </summary>
    public int TableNumber
    {
      get => this.\u003CTableNumber\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTableNumber\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public EntityPropertyAttribute()
    {
      EntityPropertyAttribute.Oyh21foVWUbi6RojuuVy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mfeDHtoVFwW9YsAmdZKk() => EntityPropertyAttribute.ScXktHoIzyv2mWvGs152 == null;

    internal static EntityPropertyAttribute LdmfN7oVBE6tkIFsD8eK() => EntityPropertyAttribute.ScXktHoIzyv2mWvGs152;

    internal static void Oyh21foVWUbi6RojuuVy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

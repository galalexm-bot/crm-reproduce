// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.OverrideExtensibleClassPropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Переопределенный атрибут системной расширяемой сущности
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class OverrideExtensibleClassPropertyAttribute : Attribute
  {
    private string propertyValue;
    private static OverrideExtensibleClassPropertyAttribute Vx9lWpoQBvMt2DMWGan2;

    public OverrideExtensibleClassPropertyAttribute(string value)
    {
      OverrideExtensibleClassPropertyAttribute.jCxNG6oQbSD2TjcuP1lL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.propertyValue = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string PropertyValue => this.propertyValue;

    internal static void jCxNG6oQbSD2TjcuP1lL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool T1YH25oQW3hyZm817rma() => OverrideExtensibleClassPropertyAttribute.Vx9lWpoQBvMt2DMWGan2 == null;

    internal static OverrideExtensibleClassPropertyAttribute HfiAeLoQoGOrOASsLqpt() => OverrideExtensibleClassPropertyAttribute.Vx9lWpoQBvMt2DMWGan2;
  }
}

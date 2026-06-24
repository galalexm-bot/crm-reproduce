// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ComponentOrderAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Атрибут позволяет указать порядок компонентов при получении через ComponentManager
  /// </summary>
  /// <remarks>
  /// Применяется в том случае, когда на класс нельзя навесить атрибут ComponentAttribute
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
  public class ComponentOrderAttribute : Attribute
  {
    private int order;
    private static ComponentOrderAttribute hTIMKRfZDumDDWwyWIT7;

    /// <summary>Ctor</summary>
    /// <param name="order">Порядок</param>
    public ComponentOrderAttribute(int order)
    {
      ComponentOrderAttribute.aTf0SMfZ4Jc13CYWugEk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.order = order;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Порядок</summary>
    public int Order => this.order;

    internal static void aTf0SMfZ4Jc13CYWugEk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool W35Y0TfZtVwW9tvgra82() => ComponentOrderAttribute.hTIMKRfZDumDDWwyWIT7 == null;

    internal static ComponentOrderAttribute dwmSwWfZwhMH6wlkci2H() => ComponentOrderAttribute.hTIMKRfZDumDDWwyWIT7;
  }
}

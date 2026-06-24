// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DataClassFormAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут для указания формы для датакласса</summary>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public sealed class DataClassFormAttribute : Attribute
  {
    internal static DataClassFormAttribute qckkJ9of8HOT1go3kTrp;

    /// <summary>Ctor</summary>
    /// <param name="viewType">Тип формы</param>
    /// <param name="componentHeaderUid">Уникальный идентификатор заголовка компонента</param>
    public DataClassFormAttribute(string viewType, string componentHeaderUid)
    {
      DataClassFormAttribute.yKWseKofI4WTa3tWwHoe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ComponentHeaderUid = componentHeaderUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
          default:
            this.ViewType = viewType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип формы</summary>
    internal string ViewType { get; }

    /// <summary>Уникальный идентификатор формы</summary>
    internal string ComponentHeaderUid { get; }

    internal static void yKWseKofI4WTa3tWwHoe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lFiyvTofZEJKNKdw0GuU() => DataClassFormAttribute.qckkJ9of8HOT1go3kTrp == null;

    internal static DataClassFormAttribute i1nbiNofuZajRnurtmnk() => DataClassFormAttribute.qckkJ9of8HOT1go3kTrp;
  }
}

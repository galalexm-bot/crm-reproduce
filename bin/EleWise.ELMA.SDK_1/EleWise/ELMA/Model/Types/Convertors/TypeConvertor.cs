// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.TypeConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>Базовый класс преобразователя типов</summary>
  [Component]
  public abstract class TypeConvertor : ITypeConvertor
  {
    private static TypeConvertor AlasnSojaja2YravE9vF;

    /// <summary>Uid исходного типа</summary>
    public abstract List<Guid> SourceTypeUids { get; }

    /// <summary>Uid конечного типа</summary>
    public abstract List<Guid> TargetTypeUids { get; }

    public abstract object DoConvert(object obj);

    protected TypeConvertor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool HBthm9ojDARH8Gsw3t9l() => TypeConvertor.AlasnSojaja2YravE9vF == null;

    internal static TypeConvertor mR1mBcojtUUcFrFL1Mal() => TypeConvertor.AlasnSojaja2YravE9vF;
  }
}

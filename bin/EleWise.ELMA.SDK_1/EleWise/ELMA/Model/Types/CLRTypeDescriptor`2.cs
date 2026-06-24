// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.CLRTypeDescriptor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Абстрактный класс описания типа данных CLR</summary>
  /// <typeparam name="T">Тип CLR</typeparam>
  /// <typeparam name="SettingsT">Тип настроек</typeparam>
  public abstract class CLRTypeDescriptor<T, SettingsT> : CLRTypeDescriptor<T>
  {
    internal static object EsndKSoJ4nmSckbecBTt;

    /// <summary>Тип настроек</summary>
    public override Type SettingsType => typeof (SettingsT);

    protected CLRTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pqb9HfoJ6cVSOfcSpe7g() => CLRTypeDescriptor<T, SettingsT>.EsndKSoJ4nmSckbecBTt == null;

    internal static object aKJsheoJHshJHpyeQuhb() => CLRTypeDescriptor<T, SettingsT>.EsndKSoJ4nmSckbecBTt;
  }
}

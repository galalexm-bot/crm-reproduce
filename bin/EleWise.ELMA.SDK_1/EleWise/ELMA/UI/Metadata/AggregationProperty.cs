// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.AggregationProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.UserDefinedList;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Реализация агрегации свойства</summary>
  [Serializable]
  public sealed class AggregationProperty : UserDefinedListPropertyBase
  {
    private static AggregationProperty PyxrnbBbNQKCqbpoMKht;

    /// <summary>Тип агрегации</summary>
    public AggregationType AggregationType
    {
      get => this.\u003CAggregationType\u003Ek__BackingField;
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
              this.\u003CAggregationType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    public AggregationProperty()
    {
      AggregationProperty.joNw5GBbarZe9tqu6gfF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool n5TcrHBb31Rssa6VHEPE() => AggregationProperty.PyxrnbBbNQKCqbpoMKht == null;

    internal static AggregationProperty cPow3SBbpUEQ0opcpwX5() => AggregationProperty.PyxrnbBbNQKCqbpoMKht;

    internal static void joNw5GBbarZe9tqu6gfF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

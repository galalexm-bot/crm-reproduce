// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Attributes.AggregatorAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Diagnostics.Attributes
{
  /// <summary>Атрибут, устанавливающий агрегатор для метрики</summary>
  [AttributeUsage(AttributeTargets.Class)]
  public class AggregatorAttribute : Attribute
  {
    internal static AggregatorAttribute cu4UR9En6Xa8EiynVs6P;

    /// <summary>Ctor</summary>
    /// <param name="aggregatorType"></param>
    public AggregatorAttribute(Type aggregatorType)
    {
      AggregatorAttribute.KadgEQEn7uUZiGQecSO5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Type = aggregatorType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип агрегатора метрики</summary>
    public Type Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    internal static void KadgEQEn7uUZiGQecSO5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Bkt1pmEnHEwM82XR4HNF() => AggregatorAttribute.cu4UR9En6Xa8EiynVs6P == null;

    internal static AggregatorAttribute RGcEQ4EnA3yFSQau9aht() => AggregatorAttribute.cu4UR9En6Xa8EiynVs6P;
  }
}

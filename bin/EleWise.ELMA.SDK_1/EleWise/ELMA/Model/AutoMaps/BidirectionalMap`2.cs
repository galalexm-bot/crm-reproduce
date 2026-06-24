// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.BidirectionalMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps
{
  public class BidirectionalMap<TSource, TDestination> : SimpleMap<TSource, TDestination>
  {
    private static object gCM1yuh7ApFx4whI1qov;

    protected override sealed void InitMap(IMapperConfigurationExpression configuration)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        IMappingExpression<TDestination, TSource> map;
        while (true)
        {
          switch (num2)
          {
            case 1:
              map = configuration.CreateMap<TDestination, TSource>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 2:
              base.InitMap(configuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_4:
        this.InitReverseMap(map);
        num1 = 3;
      }
label_3:;
    }

    protected virtual void InitReverseMap(IMappingExpression<TDestination, TSource> map)
    {
    }

    public BidirectionalMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Wtr3TFh778aZYlrBf0O4() => BidirectionalMap<TSource, TDestination>.gCM1yuh7ApFx4whI1qov == null;

    internal static object B7ttKyh7x5xaJuiY826B() => BidirectionalMap<TSource, TDestination>.gCM1yuh7ApFx4whI1qov;
  }
}

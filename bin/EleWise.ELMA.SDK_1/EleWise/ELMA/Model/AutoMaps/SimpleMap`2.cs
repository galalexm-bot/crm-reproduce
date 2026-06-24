// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.SimpleMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps
{
  [Component]
  public class SimpleMap<TSource, TDestination> : IAutoMapConfigurator
  {
    internal static object LOF7wch7MfBZWi1sljZb;

    protected virtual void InitMap(IMapperConfigurationExpression configuration)
    {
      int num = 1;
      IMappingExpression<TSource, TDestination> map;
      while (true)
      {
        switch (num)
        {
          case 1:
            map = configuration.CreateMap<TSource, TDestination>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.InitMap(map);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    protected virtual void InitMap(IMappingExpression<TSource, TDestination> map)
    {
    }

    public void Configure(IMapperConfigurationExpression configuration)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.InitMap(configuration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public SimpleMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool s0YCrJh7JkFOwWrCeWi3() => SimpleMap<TSource, TDestination>.LOF7wch7MfBZWi1sljZb == null;

    internal static object FyqeFCh79s5lV2fuPSfN() => SimpleMap<TSource, TDestination>.LOF7wch7MfBZWi1sljZb;
  }
}

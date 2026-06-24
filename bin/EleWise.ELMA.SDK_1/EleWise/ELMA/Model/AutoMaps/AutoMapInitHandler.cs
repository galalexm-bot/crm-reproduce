// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.AutoMapInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.AutoMaps
{
  [Component]
  internal class AutoMapInitHandler : IInitHandler
  {
    private readonly IEnumerable<IAutoMapConfigurator> configs;
    private static AutoMapInitHandler jbZi1Lh73of4a36MxfNP;

    public AutoMapInitHandler(IEnumerable<IAutoMapConfigurator> configs)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.configs = configs;
    }

    public void Init()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            Mapper.Initialize((Action<IMapperConfigurationExpression>) (cfg =>
            {
              int num3 = 3;
              IMapperConfigurationExpression cfg1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.configs.ForEach<IAutoMapConfigurator>((Action<IAutoMapConfigurator>) (c =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            c.Configure(cfg1);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    cfg1 = cfg;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                    continue;
                  case 3:
                    num3 = 2;
                    continue;
                  default:
                    goto label_6;
                }
              }
label_2:
              return;
label_6:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void InitComplete()
    {
    }

    internal static bool nyXKohh7pfkN6yTfwf1Y() => AutoMapInitHandler.jbZi1Lh73of4a36MxfNP == null;

    internal static AutoMapInitHandler k68CPSh7ajij0muZnfoi() => AutoMapInitHandler.jbZi1Lh73of4a36MxfNP;
  }
}

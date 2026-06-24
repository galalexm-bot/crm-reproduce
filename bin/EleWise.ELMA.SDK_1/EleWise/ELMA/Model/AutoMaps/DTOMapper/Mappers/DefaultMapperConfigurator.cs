// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers.DefaultMapperConfigurator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers
{
  /// <summary>Базовый класс конфигуратора</summary>
  internal abstract class DefaultMapperConfigurator : IInternalMapperConfigurator
  {
    /// <summary>Тип маппера по умолчанию</summary>
    protected static readonly Type DefaultMapperTypeInternal;
    private static DefaultMapperConfigurator cJcNHHhxEoSyiZLQgEmG;

    /// <inheritdoc />
    public abstract IEnumerable<IInternalMapperConfiguration> Init();

    protected DefaultMapperConfigurator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DefaultMapperConfigurator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            DefaultMapperConfigurator.DefaultMapperTypeInternal = DefaultMapperConfigurator.XQOaOrhxC4yWZ7WbtejT(__typeref (DefaultDataClassBidirectionalMap<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool T9GJD3hxfd1UyNYgVrKs() => DefaultMapperConfigurator.cJcNHHhxEoSyiZLQgEmG == null;

    internal static DefaultMapperConfigurator RyohNyhxQMb2xEFsDcBk() => DefaultMapperConfigurator.cJcNHHhxEoSyiZLQgEmG;

    internal static Type XQOaOrhxC4yWZ7WbtejT([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}

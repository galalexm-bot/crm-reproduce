// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.AbstractMetadataMap`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Mappings
{
  public abstract class AbstractMetadataMap<T> : AbstractEntityMap<T, long> where T : AbstractMetadata
  {
    internal static object eNoI5Zhby6gb9bN4MC0K;

    public AbstractMetadataMap(string tableName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(tableName);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Property<Guid>((Expression<Func<T, Guid>>) (obj => obj.Uid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool SUHc3dhbMPRx6tbwE0tN() => AbstractMetadataMap<T>.eNoI5Zhby6gb9bN4MC0K == null;

    internal static object CMmyMvhbJY2J9ueMoJA6() => AbstractMetadataMap<T>.eNoI5Zhby6gb9bN4MC0K;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModifedEntityPair
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Класс-контейнер пары старой и новой версии метаданных</summary>
  internal class ModifedEntityPair
  {
    internal static ModifedEntityPair BCNGbkbpgbjtYKkchbNm;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="oldMetadata">Метаданные до изменений</param>
    /// <param name="newMetadata">Метаданные после изменений</param>
    public ModifedEntityPair(EntityMetadata oldMetadata, EntityMetadata newMetadata)
    {
      ModifedEntityPair.S80y0ubpY5gZHpk1p6bu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.OldMetadata = oldMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.NewMetadata = newMetadata;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Метаданные до изменений</summary>
    public EntityMetadata OldMetadata { get; }

    /// <summary>Метаданные после изменений</summary>
    public EntityMetadata NewMetadata { get; }

    internal static void S80y0ubpY5gZHpk1p6bu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CuGhjTbp56uILLccsGf4() => ModifedEntityPair.BCNGbkbpgbjtYKkchbNm == null;

    internal static ModifedEntityPair uOfHBUbpjp5ymmos3tUn() => ModifedEntityPair.BCNGbkbpgbjtYKkchbNm;
  }
}

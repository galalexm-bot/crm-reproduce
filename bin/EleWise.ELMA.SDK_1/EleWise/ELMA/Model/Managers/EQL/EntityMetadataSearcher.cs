// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EQL.EntityMetadataSearcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Managers.EQL
{
  /// <summary>Поиск метаданных справочников</summary>
  [Component(Order = 2)]
  public class EntityMetadataSearcher : IEntityMetadataSearcher
  {
    internal static EntityMetadataSearcher WxhSochvaPt3CBQ6yB8A;

    /// <inheritdoc />
    public EntityMetadata FindEntityMetadata(Guid uid) => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(uid) as EntityMetadata;

    /// <inheritdoc />
    public EntityMetadata FindEntityMetadata(string className)
    {
      int num = 1;
      string className1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            className1 = className;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => (string) EntityMetadataSearcher.\u003C\u003Ec__DisplayClass1_0.YRwH9pCLbuLwVxFAApT8((object) m) == className1));
    }

    /// <inheritdoc />
    public IEnumerable<EntityMetadata> GetEntityMetadataList() => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>();

    /// <inheritdoc />
    public string DisplayName => EleWise.ELMA.SR.T((string) EntityMetadataSearcher.epTKlvhvwhG1IjkYDXkP(-680446928 - -370807692 ^ -309823400));

    public EntityMetadataSearcher()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xppKVYhvDnIvtn3EQQbw() => EntityMetadataSearcher.WxhSochvaPt3CBQ6yB8A == null;

    internal static EntityMetadataSearcher asHr45hvtO3y2XmFLWmv() => EntityMetadataSearcher.WxhSochvaPt3CBQ6yB8A;

    internal static object epTKlvhvwhG1IjkYDXkP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

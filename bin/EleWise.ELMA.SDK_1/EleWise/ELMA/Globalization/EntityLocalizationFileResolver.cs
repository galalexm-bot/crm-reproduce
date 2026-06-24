// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.EntityLocalizationFileResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Globalization
{
  [Component]
  public class EntityLocalizationFileResolver : BaseLocalizationFileResolver
  {
    public static string File;
    internal static EntityLocalizationFileResolver gDxZnoGoj3uNRYGf3M1m;

    public override string FileName => EntityLocalizationFileResolver.File;

    public override IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings)
    {
      List<PoLineDescriptor> res = new List<PoLineDescriptor>();
      if (settings.CustomSettings[EntityLocalizationLoadCustomSettings.ExtensionUid] is EntityGlobalizationSettings customSetting && customSetting.EntityUids != null)
      {
        foreach (Guid entityUid in customSetting.EntityUids)
        {
          EntityMetadata metadata = this.LoadOrNullMetadata(entityUid);
          if (metadata != null)
            this.GetFromMetadata(metadata, res);
        }
        foreach (Guid enumUid in customSetting.EnumUids)
        {
          EnumMetadata metadata = this.LoadOrNullEnumMetadata(enumUid);
          if (metadata != null)
            this.GetFromEnum(metadata, res);
        }
      }
      return (IEnumerable<PoLineDescriptor>) res;
    }

    public EntityLocalizationFileResolver()
    {
      EntityLocalizationFileResolver.fiIjyOGoUDekZTSwkh0c();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityLocalizationFileResolver()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityLocalizationFileResolver.File = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917106426);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void fiIjyOGoUDekZTSwkh0c() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool AJ43I1GoYe552Hsa02UP() => EntityLocalizationFileResolver.gDxZnoGoj3uNRYGf3M1m == null;

    internal static EntityLocalizationFileResolver ArGybdGoLNyCBysRSmnR() => EntityLocalizationFileResolver.gDxZnoGoj3uNRYGf3M1m;
  }
}

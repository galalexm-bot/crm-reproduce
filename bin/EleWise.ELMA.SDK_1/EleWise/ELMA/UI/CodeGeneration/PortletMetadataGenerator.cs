// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletMetadataGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.CodeGeneration
{
  public class PortletMetadataGenerator : FormMetadataGenerator<PortletMetadata>
  {
    internal static PortletMetadataGenerator RTNyT0BV6i5NFDnMiWNi;

    protected override IEnumerable<ISyntaxNode> GenerateMainFileContent()
    {
      Contract.NotNull((object) this.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420789788));
      Contract.NotNull((object) this.Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405771539));
      Contract.NotNull((object) this.Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978415497));
      FormContextGenerator contextGenerator = new FormContextGenerator();
      ((ICodeGenerator) contextGenerator).Metadata = (IMetadata) this.Metadata.Content.Context;
      ((ICodeGenerator) contextGenerator).GenerationParams = new GenerationParams();
      PortletPersonalizationGenerator personalizationGenerator = new PortletPersonalizationGenerator();
      ((ICodeGenerator) personalizationGenerator).Metadata = (IMetadata) this.Metadata.PersonalizationContext;
      ((ICodeGenerator) personalizationGenerator).GenerationParams = new GenerationParams();
      PortletSettingsGenerator settingsGenerator = new PortletSettingsGenerator();
      ((ICodeGenerator) settingsGenerator).Metadata = (IMetadata) this.Metadata.Settings.Context;
      ((ICodeGenerator) settingsGenerator).GenerationParams = new GenerationParams();
      return contextGenerator.Generate().Concat<ISyntaxNode>(personalizationGenerator.Generate()).Concat<ISyntaxNode>(settingsGenerator.Generate());
    }

    public PortletMetadataGenerator()
    {
      PortletMetadataGenerator.iIbmgEBV7LUaX7UhnHNH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void iIbmgEBV7LUaX7UhnHNH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ajKSrnBVHOQBwrORcfut() => PortletMetadataGenerator.RTNyT0BV6i5NFDnMiWNi == null;

    internal static PortletMetadataGenerator mkwQmKBVANGRhQsumfcS() => PortletMetadataGenerator.RTNyT0BV6i5NFDnMiWNi;
  }
}

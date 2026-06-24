// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PageMetadataGenerator
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

namespace EleWise.ELMA.UI.CodeGeneration
{
  public class PageMetadataGenerator : FormMetadataGenerator<PageMetadata>
  {
    internal static PageMetadataGenerator I5kURGBVD7ci90lUqiIZ;

    protected override IEnumerable<ISyntaxNode> GenerateMainFileContent() => this.GenerateFileContent(new FormContextGenerator());

    private IEnumerable<ISyntaxNode> GenerateFileContent(FormContextGenerator generator)
    {
      Contract.NotNull((object) this.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012108861));
      Contract.NotNull((object) this.Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113926491));
      Contract.NotNull((object) this.Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939444752));
      ((ICodeGenerator) generator).Metadata = (IMetadata) this.Metadata.Content.Context;
      ((ICodeGenerator) generator).GenerationParams = new GenerationParams();
      return generator.Generate();
    }

    public PageMetadataGenerator()
    {
      PageMetadataGenerator.GJvRIRBV4uMDh6vqD9l0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void GJvRIRBV4uMDh6vqD9l0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pO0ILyBVtufNtM0FU6XF() => PageMetadataGenerator.I5kURGBVD7ci90lUqiIZ == null;

    internal static PageMetadataGenerator O8gcw6BVwbTqTfpeEknA() => PageMetadataGenerator.I5kURGBVD7ci90lUqiIZ;
  }
}

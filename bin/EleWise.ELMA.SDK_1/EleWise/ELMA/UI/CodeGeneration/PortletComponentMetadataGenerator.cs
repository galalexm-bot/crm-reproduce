// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletComponentMetadataGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор метаданных портлета</summary>
  internal sealed class PortletComponentMetadataGenerator : ComponentMetadataGenerator
  {
    internal static PortletComponentMetadataGenerator KsHnUiBuxoiDrR81cZuc;

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFileContent() => base.GenerateMainFileContent().Concat<ISyntaxNode>(this.GeneratePortletSettings(new PortletComponentPersonalizationGenerator()));

    /// <inheritdoc />
    protected override ISyntaxNode GenerateViewModel()
    {
      PortletViewModelGenerator viewModelGenerator = new PortletViewModelGenerator();
      PortletComponentMetadataGenerator.utU6nnBuyRvZXWbyCtpO((object) viewModelGenerator, (object) this.Metadata);
      return (ISyntaxNode) PortletComponentMetadataGenerator.DYyqi1BuMKBq7EnGYgJV((object) viewModelGenerator);
    }

    private IEnumerable<ISyntaxNode> GeneratePortletSettings(
      PortletComponentPersonalizationGenerator generator)
    {
      PortletPersonalizationMetadata personalizationContext = ((PortletComponentMetadata) this.Metadata).PersonalizationContext;
      EntityMetadata entityMetadata1 = new EntityMetadata();
      entityMetadata1.Properties = personalizationContext.Properties;
      entityMetadata1.Namespace = this.Metadata.Namespace;
      entityMetadata1.Name = personalizationContext.Name;
      entityMetadata1.DisplayName = personalizationContext.DisplayName;
      entityMetadata1.Uid = personalizationContext.Uid;
      entityMetadata1.Type = EntityMetadataType.Entity;
      EntityMetadata entityMetadata2 = entityMetadata1;
      ((ICodeGenerator) generator).Metadata = (IMetadata) entityMetadata2;
      ((ICodeGenerator) generator).GenerationParams.Mode = this.generationParams.Mode;
      return generator.Generate();
    }

    public PortletComponentMetadataGenerator()
    {
      PortletComponentMetadataGenerator.P1v5jSBuJbG1QQBdN0VA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void utU6nnBuyRvZXWbyCtpO([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object DYyqi1BuMKBq7EnGYgJV([In] object obj0) => (object) ((ComponentViewModelGenerator) obj0).Generate();

    internal static bool q6UoG3Bu06BHeo5Khi7L() => PortletComponentMetadataGenerator.KsHnUiBuxoiDrR81cZuc == null;

    internal static PortletComponentMetadataGenerator qMGUkeBummPmqaDwKvOL() => PortletComponentMetadataGenerator.KsHnUiBuxoiDrR81cZuc;

    internal static void P1v5jSBuJbG1QQBdN0VA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

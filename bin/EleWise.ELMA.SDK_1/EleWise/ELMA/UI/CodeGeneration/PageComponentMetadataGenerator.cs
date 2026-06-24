// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PageComponentMetadataGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор метаданных страницы</summary>
  internal sealed class PageComponentMetadataGenerator : ComponentMetadataGenerator
  {
    internal static PageComponentMetadataGenerator JJAtkkBI9E1nvZDeS2me;

    /// <inheritdoc />
    protected override ISyntaxNode GenerateViewModel()
    {
      PageViewModelGenerator viewModelGenerator = new PageViewModelGenerator();
      PageComponentMetadataGenerator.S7ef7UBIr2Y58WOf2Kny((object) viewModelGenerator, (object) this.Metadata);
      return (ISyntaxNode) PageComponentMetadataGenerator.nF1Li7BIga4FsB6IdxWw((object) viewModelGenerator);
    }

    public PageComponentMetadataGenerator()
    {
      PageComponentMetadataGenerator.TYdDDHBI5RcaQf9WG9jW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void S7ef7UBIr2Y58WOf2Kny([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object nF1Li7BIga4FsB6IdxWw([In] object obj0) => (object) ((ComponentViewModelGenerator) obj0).Generate();

    internal static bool OuwmuvBIdBbdkuCi65mp() => PageComponentMetadataGenerator.JJAtkkBI9E1nvZDeS2me == null;

    internal static PageComponentMetadataGenerator fdVdolBIl3lbcyal9DcJ() => PageComponentMetadataGenerator.JJAtkkBI9E1nvZDeS2me;

    internal static void TYdDDHBI5RcaQf9WG9jW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.FunctionsChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>
  /// Расширение формирования раздела метаданных функций BPM App
  /// </summary>
  [Component(Order = 1050)]
  internal sealed class FunctionsChapterBuilder : BPMAppChapterBuilder
  {
    private readonly IFunctionMetadataItemHeaderManager funcManager;
    private static FunctionsChapterBuilder VPrQdeEcfv6Yb6oXM4J4;

    /// <summary>Ctor</summary>
    /// <param name="funcManager">Менеджер заголовков метаданных функций</param>
    public FunctionsChapterBuilder(IFunctionMetadataItemHeaderManager funcManager)
    {
      FunctionsChapterBuilder.JtOCmFEcv7POcMTd07g1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.funcManager = funcManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(FunctionExportConsts.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88056939)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289686636))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812054968));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node = this.CreateNode(FunctionExportConsts.ExportExtensionUid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272425405)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360394211));
      if (!(manifest.GetChapter(FunctionExportConsts.ExportExtensionUid) is FunctionBAChapter chapter) || chapter.Functions == null || chapter.Functions.Count == 0)
      {
        if (parameters.WithEmptyChapters)
          chapterNodes.Add(node);
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      ICollection<DeployTreeNode> nodes = this.GetNodes((IEnumerable<BPMAppManifestItem>) chapter.Functions);
      if (parameters.WithEmptyChapters || nodes.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) nodes.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) FunctionsChapterBuilder.\u003C\u003Ec.fKx9sd8yEMpLTcMP51oX((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node.Count = node.Children.Count;
        chapterNodes.Add(node);
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    private ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items)
    {
      List<DeployTreeNode> nodes = new List<DeployTreeNode>();
      foreach (BPMAppManifestItem bpmAppManifestItem in items)
      {
        try
        {
          FunctionMetadataItemHeader metadataItemHeader = this.funcManager.LoadOrNull(bpmAppManifestItem.Uid);
          if (metadataItemHeader != null)
            nodes.Add(this.CreateNode(bpmAppManifestItem.Uid.ToString(), metadataItemHeader.DisplayName, ""));
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939702926) + (object) bpmAppManifestItem.Uid), ex);
        }
      }
      return (ICollection<DeployTreeNode>) nodes;
    }

    internal static void JtOCmFEcv7POcMTd07g1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gUDXfnEcQHEwrEPZYvJZ() => FunctionsChapterBuilder.VPrQdeEcfv6Yb6oXM4J4 == null;

    internal static FunctionsChapterBuilder oK8QvyEcCxNcOQy6ncbI() => FunctionsChapterBuilder.VPrQdeEcfv6Yb6oXM4J4;
  }
}

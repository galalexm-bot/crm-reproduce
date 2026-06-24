// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.TranslatesChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Расширение формирования раздела переводов</summary>
  [Component(Order = 2700)]
  internal sealed class TranslatesChapterBuilder : BPMAppChapterBuilder
  {
    internal static TranslatesChapterBuilder fvK1YSEcwZLgLDc62wJF;

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(TranslateExportConst.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -233974658)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501667515))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574252118));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      if (!(manifest.GetChapter(TranslateExportConst.ExportExtensionUid) is TranslatesBAChapter chapter) || chapter.Translates == null || chapter.Translates.Count == 0)
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      // ISSUE: reference to a compiler-generated method
      List<DeployTreeNode> list = chapter.Translates.Select<TranslateBAItem, DeployTreeNode>((Func<TranslateBAItem, DeployTreeNode>) (item => this.CreateNode(TranslatesChapterBuilder.tI9LXiEcHkO9UPfY2ZKD((object) item).ToString(), item.Name, ""))).OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) TranslatesChapterBuilder.\u003C\u003Ec.f0WNnt8ym7HYe6tnLdWu((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase).ToList<DeployTreeNode>();
      DeployTreeNode deployTreeNode = new DeployTreeNode(chapter.Uid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106319802)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841581186), (ICollection<DeployTreeNode>) list);
      deployTreeNode.Count = deployTreeNode.Children.Count;
      chapterNodes.Add(deployTreeNode);
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    public TranslatesChapterBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dycHabEc4OoD3Ucc6M8E() => TranslatesChapterBuilder.fvK1YSEcwZLgLDc62wJF == null;

    internal static TranslatesChapterBuilder GxkEpEEc6fk44anuKIom() => TranslatesChapterBuilder.fvK1YSEcwZLgLDc62wJF;

    internal static Guid tI9LXiEcHkO9UPfY2ZKD([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;
  }
}

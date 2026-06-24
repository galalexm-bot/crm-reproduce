// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.BpmAppsChapterBuilder
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
  /// <summary>Расширение формирования раздела документов BPM App</summary>
  [Component(Order = 200)]
  internal sealed class BpmAppsChapterBuilder : BPMAppChapterBuilder
  {
    internal static BpmAppsChapterBuilder XIlaOuEsz9gEx9iTlh3d;

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(BpmAppsExportConsts.ExportBpmAppsUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638727891)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978681787))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710567732));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      if (!(manifest.GetChapter(BpmAppsExportConsts.ExportBpmAppsUid) is BpmAppsBAChapter chapter))
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      List<DeployTreeNode> list = chapter.Components.Select<BpmAppBAItem, DeployTreeNode>((Func<BpmAppBAItem, DeployTreeNode>) (item => this.CreateNode(BpmAppsChapterBuilder.dE7OOXEcotSMVjstJQ11((object) item).ToString(), (string) BpmAppsChapterBuilder.D53EYAEcbiJfqcU0VRuV((object) item), ""))).ToList<DeployTreeNode>();
      if (list.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        DeployTreeNode deployTreeNode = new DeployTreeNode(chapter.Uid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669013671)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957494502), (ICollection<DeployTreeNode>) list.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) BpmAppsChapterBuilder.\u003C\u003Ec.G4SsXq8ms5JstyEw2uw1((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase).ToList<DeployTreeNode>());
        deployTreeNode.Count = deployTreeNode.Children.Count;
        chapterNodes.Add(deployTreeNode);
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    public BpmAppsChapterBuilder()
    {
      BpmAppsChapterBuilder.OGOLwVEcWvn5KGKtnkoD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void OGOLwVEcWvn5KGKtnkoD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool e8Ont8EcF7MJF5y7PHV6() => BpmAppsChapterBuilder.XIlaOuEsz9gEx9iTlh3d == null;

    internal static BpmAppsChapterBuilder mhEJc6EcBpBjIEmAq1gP() => BpmAppsChapterBuilder.XIlaOuEsz9gEx9iTlh3d;

    internal static Guid dE7OOXEcotSMVjstJQ11([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;

    internal static object D53EYAEcbiJfqcU0VRuV([In] object obj0) => (object) ((BpmAppBAItem) obj0).BpmAppTitle;
  }
}

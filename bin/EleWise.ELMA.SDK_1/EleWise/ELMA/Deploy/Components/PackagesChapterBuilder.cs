// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.PackagesChapterBuilder
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
  /// <summary>Расширение формирования раздела пакетов BPM App</summary>
  [Component(Order = 2500)]
  internal sealed class PackagesChapterBuilder : BPMAppChapterBuilder
  {
    internal static PackagesChapterBuilder KivsxrEcVfAYNtrsxmcb;

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(PackageExportConsts.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012281923)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439389854))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333742612));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode deployTreeNode = new DeployTreeNode(PackageExportConsts.ExportExtensionUid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16427941)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536709314));
      if (!(manifest.GetChapter(PackageExportConsts.ExportExtensionUid) is PackagesBAChapter chapter) || chapter.Packages == null || chapter.Packages.Count == 0)
      {
        if (parameters.WithEmptyChapters)
          chapterNodes.Add(deployTreeNode);
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      deployTreeNode.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) chapter.Packages.Select<PackageBAItem, DeployTreeNode>((Func<PackageBAItem, DeployTreeNode>) (pkg => this.CreateNode(pkg.PackageId, PackagesChapterBuilder.VekeOFEcKA0CPomb3RA5(PackagesChapterBuilder.QPiMBxEcqo47YQhKbSIc((object) pkg)) ? pkg.PackageId : pkg.PackageTitle, ""))).OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => n.Text), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
      deployTreeNode.Count = deployTreeNode.Children.Count;
      chapterNodes.Add(deployTreeNode);
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    public PackagesChapterBuilder()
    {
      PackagesChapterBuilder.fEBoakEcReysia9JLhpq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void fEBoakEcReysia9JLhpq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool U35OOoEcSOna5OYsVb0A() => PackagesChapterBuilder.KivsxrEcVfAYNtrsxmcb == null;

    internal static PackagesChapterBuilder GwGmpSEciIYK6KrRHaRW() => PackagesChapterBuilder.KivsxrEcVfAYNtrsxmcb;

    internal static object QPiMBxEcqo47YQhKbSIc([In] object obj0) => (object) ((PackageBAItem) obj0).PackageTitle;

    internal static bool VekeOFEcKA0CPomb3RA5([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.ScriptModulesChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.BPMApps;
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Расширение формирования раздела скриптов BPM App</summary>
  [Component(Order = 800)]
  internal sealed class ScriptModulesChapterBuilder : BPMAppChapterBuilder
  {
    private readonly GlobalScriptModuleHeaderManager globalModuleManager;
    private static ScriptModulesChapterBuilder EETTCQEcpsRZWWUB9gZk;

    /// <summary>Ctor</summary>
    /// <param name="globalModuleManager">Менеджер заголовков глобальных модулей</param>
    public ScriptModulesChapterBuilder(
      GlobalScriptModuleHeaderManager globalModuleManager)
    {
      ScriptModulesChapterBuilder.IoSfCeEctyTL6bGFOT9y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.globalModuleManager = globalModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(ScriptModuleExportConsts.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633188067)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137495706))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541741681));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node = this.CreateNode(ScriptModuleExportConsts.ExportExtensionUid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304934917)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312904303));
      if (!(manifest.GetChapter(ScriptModuleExportConsts.ExportExtensionUid) is ScriptModulesBAChapter chapter) || chapter.Modules == null || chapter.Modules.Count == 0)
      {
        if (parameters.WithEmptyChapters)
          chapterNodes.Add(node);
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      List<DeployTreeNode> source = new List<DeployTreeNode>();
      foreach (ScriptModuleBAItem module in chapter.Modules)
      {
        IGlobalScriptModuleHeader scriptModuleHeader = this.globalModuleManager.LoadOrNull(module.Uid);
        if (scriptModuleHeader != null)
          source.Add(this.CreateNode(module.Uid.ToString(), scriptModuleHeader.Name, ""));
      }
      if (parameters.WithEmptyChapters || source.Count > 0)
      {
        node.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) source.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => n.Text), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node.Count = node.Children.Count;
        chapterNodes.Add(node);
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    internal static void IoSfCeEctyTL6bGFOT9y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool c9xGbAEcaN4C3mYFQEVZ() => ScriptModulesChapterBuilder.EETTCQEcpsRZWWUB9gZk == null;

    internal static ScriptModulesChapterBuilder xZX60fEcDVH4EYWWGWyk() => ScriptModulesChapterBuilder.EETTCQEcpsRZWWUB9gZk;
  }
}

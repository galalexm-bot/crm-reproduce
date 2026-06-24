// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.DeployTreeBuilderService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис построения дерева объектов экспорта-импорта</summary>
  [Service]
  internal sealed class DeployTreeBuilderService : IDeployTreeBuilderService
  {
    /// <summary>Точки расширения отображения дерева</summary>
    private IEnumerable<IBPMAppChapterBuilder> bpmAppChapterRenderer;
    private static DeployTreeBuilderService tj3Ta0EH8v8SiocJWOE1;

    /// <summary>Ctor</summary>
    /// <param name="bpmAppChapterRenderer">Точки расширения отображения дерева</param>
    public DeployTreeBuilderService(
      IEnumerable<IBPMAppChapterBuilder> bpmAppChapterRenderer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.bpmAppChapterRenderer = bpmAppChapterRenderer;
    }

    /// <inheritdoc />
    public DeployTreeModel BuildTree(BPMAppFakeManifest manifest, string id, string title)
    {
      int num = 3;
      DeployTreeNode deployTreeNode;
      BPMAppFakeManifest manifest1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            manifest1 = manifest;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 3:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
            continue;
          default:
            deployTreeNode = new DeployTreeNode(id, title, (string) DeployTreeBuilderService.HRyY5BEHIZQKAvGH2Xvi(1012087039 ^ 1012381433), (ICollection<DeployTreeNode>) this.bpmAppChapterRenderer.SelectMany<IBPMAppChapterBuilder, DeployTreeNode>((Func<IBPMAppChapterBuilder, IEnumerable<DeployTreeNode>>) (point => point.GetChapterNodes(manifest1))).ToList<DeployTreeNode>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return new DeployTreeModel(id, (IEnumerable<DeployTreeNode>) new DeployTreeNode[1]
      {
        deployTreeNode
      });
    }

    /// <inheritdoc />
    public DeployTreeModel BuildTree(
      BPMAppManifest manifest,
      string id,
      IChapterParameters parameters)
    {
      int num = 3;
      List<DeployTreeNode> list;
      BPMAppManifest manifest1;
      IChapterParameters parameters1;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameters1 = parameters;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            manifest1 = manifest;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
          case 3:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_3;
          default:
            list = this.bpmAppChapterRenderer.SelectMany<IBPMAppChapterBuilder, DeployTreeNode>((Func<IBPMAppChapterBuilder, IEnumerable<DeployTreeNode>>) (point => point.GetChapterNodes(manifest1, parameters1))).ToList<DeployTreeNode>();
            num = 4;
            continue;
        }
      }
label_3:
      return new DeployTreeModel(id, (IEnumerable<DeployTreeNode>) list);
    }

    internal static object HRyY5BEHIZQKAvGH2Xvi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool hPTt27EHZF1jPO3LvM0G() => DeployTreeBuilderService.tj3Ta0EH8v8SiocJWOE1 == null;

    internal static DeployTreeBuilderService FUaRqTEHuKjmTLER9KgX() => DeployTreeBuilderService.tj3Ta0EH8v8SiocJWOE1;
  }
}

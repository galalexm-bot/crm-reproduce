// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.ComponentsAndUIFormsChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.BPMApps;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>
  /// Расширение формирования раздела метаданных компонентов, страниц и портлетов BPM App
  /// </summary>
  [Component(Order = 550)]
  internal sealed class ComponentsAndUIFormsChapterBuilder : BPMAppChapterBuilder
  {
    private readonly IEntityManager<ComponentMetadataItemHeader, long> componentManager;
    private readonly FormMetadataItemHeaderManager formMetadataManager;

    /// <summary>Ctor</summary>
    /// <param name="componentManager">Менеджер заголовков метаданных компонентов</param>
    /// <param name="formMetadataManager">Менеджер заголовков форм метаданных</param>
    public ComponentsAndUIFormsChapterBuilder(
      IEntityManager<ComponentMetadataItemHeader, long> componentManager,
      FormMetadataItemHeaderManager formMetadataManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.componentManager = componentManager;
      this.formMetadataManager = formMetadataManager;
    }

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(ComponentExportConsts.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396936638)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889512002)),
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(UIFormExportConsts.ExportExtensionUidPage, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132922245)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882179850)),
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(UIFormExportConsts.ExportExtensionUidPortlet, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516643444)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87850295))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710567732));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node1 = this.CreateNode(ComponentExportConsts.ExportExtensionUid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951320448)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146311503));
      DeployTreeNode node2 = this.CreateNode(UIFormExportConsts.ExportExtensionUidPage.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088297630)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765806914));
      DeployTreeNode node3 = this.CreateNode(UIFormExportConsts.ExportExtensionUidPortlet.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647714484)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138914196));
      ComponentBAChapter chapter1 = manifest.GetChapter(ComponentExportConsts.ExportExtensionUid) as ComponentBAChapter;
      UIFormsBAChapter chapter2 = manifest.GetChapter(UIFormExportConsts.ExportExtensionUid) as UIFormsBAChapter;
      if ((chapter1 == null || chapter1.Components == null || chapter1.Components.Count == 0) && (chapter2 == null || chapter2.Forms == null || chapter2.Forms.Count == 0))
      {
        if (parameters.WithEmptyChapters)
        {
          chapterNodes.Add(node1);
          chapterNodes.Add(node2);
          chapterNodes.Add(node3);
        }
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      List<DeployTreeNode> deployTreeNodeList1 = new List<DeployTreeNode>();
      List<DeployTreeNode> deployTreeNodeList2 = new List<DeployTreeNode>();
      List<DeployTreeNode> deployTreeNodeList3 = new List<DeployTreeNode>();
      this.GetNodesUIForm(chapter2, deployTreeNodeList1, deployTreeNodeList2);
      this.GetNodes(chapter1, deployTreeNodeList1, deployTreeNodeList2, deployTreeNodeList3);
      if (parameters.WithEmptyChapters || deployTreeNodeList1.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node2.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) deployTreeNodeList1.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) ComponentsAndUIFormsChapterBuilder.\u003C\u003Ec.B2gb3e8yW3EXhZL2Nj8P((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node2.Count = node2.Children.Count;
        chapterNodes.Add(node2);
      }
      if (parameters.WithEmptyChapters || deployTreeNodeList2.Count > 0)
      {
        node3.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) deployTreeNodeList2.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => n.Text), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node3.Count = node3.Children.Count;
        chapterNodes.Add(node3);
      }
      if (parameters.WithEmptyChapters || deployTreeNodeList3.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node1.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) deployTreeNodeList3.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) ComponentsAndUIFormsChapterBuilder.\u003C\u003Ec.B2gb3e8yW3EXhZL2Nj8P((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node1.Count = node1.Children.Count;
        chapterNodes.Add(node1);
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    private void GetNodesUIForm(
      UIFormsBAChapter formsChapter,
      List<DeployTreeNode> pageNodes,
      List<DeployTreeNode> portletNodes)
    {
      if (formsChapter?.Forms == null)
        return;
      foreach (UIFormBAItem form in formsChapter.Forms)
      {
        IFormMetadataItemHeader metadataItemHeader = this.formMetadataManager.LoadOrNull(form.Uid);
        if (metadataItemHeader != null)
        {
          if (metadataItemHeader.MetadataType == PageMetadata.TypeUid)
            pageNodes.Add(this.CreateNode(form.Uid.ToString(), metadataItemHeader.DisplayName, ""));
          else if (metadataItemHeader.MetadataType == PortletMetadata.TypeUid)
            portletNodes.Add(this.CreateNode(form.Uid.ToString(), metadataItemHeader.DisplayName, ""));
        }
      }
    }

    private void GetNodes(
      ComponentBAChapter componentsChapter,
      List<DeployTreeNode> pageNodes,
      List<DeployTreeNode> portletNodes,
      List<DeployTreeNode> componentNodes)
    {
      if (componentsChapter?.Components == null)
        return;
      foreach (ComponentBAItem component in componentsChapter.Components)
      {
        try
        {
          ComponentMetadataItemHeader metadataItemHeader = this.componentManager.LoadOrNull(component.Uid);
          if (metadataItemHeader != null)
          {
            if (metadataItemHeader.MetadataTypeUid == PageComponentMetadata.TypeUid)
              pageNodes.Add(this.CreateNode(component.Uid.ToString(), metadataItemHeader.DisplayName, ""));
            else if (metadataItemHeader.MetadataTypeUid == PortletComponentMetadata.TypeUid)
              portletNodes.Add(this.CreateNode(component.Uid.ToString(), metadataItemHeader.DisplayName, ""));
            else
              componentNodes.Add(this.CreateNode(component.Uid.ToString(), metadataItemHeader.DisplayName, ""));
          }
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487058484) + (object) component.Uid), ex);
        }
      }
    }
  }
}

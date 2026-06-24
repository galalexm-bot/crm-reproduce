// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.ObjectsChapterBuilder
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
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Расширение формирования раздела объектов BPM App</summary>
  [Component(Order = 200)]
  internal sealed class ObjectsChapterBuilder : MetadataHeaderChapterBuilder
  {
    private readonly DataClassMetadataItemHeaderManager dataClassService;
    private readonly ISecurityService securityService;
    private static ObjectsChapterBuilder QNvvooEc8tZbApU1bLTr;

    /// <summary>Ctor</summary>
    /// <param name="metadataService">Cервис управления метаданными в режиме Runtime</param>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    /// <param name="dataClassService">Менеджер заголовков метаданных датакласса</param>
    /// <param name="securityService">Сервис проверки привелегий</param>
    public ObjectsChapterBuilder(
      IMetadataRuntimeService metadataService,
      MetadataItemHeaderManager metadataItemHeaderManager,
      DataClassMetadataItemHeaderManager dataClassService,
      ISecurityService securityService)
    {
      ObjectsChapterBuilder.QK1Z6gEcIBcNHouQJAJD();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadataService, metadataItemHeaderManager);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.dataClassService = dataClassService;
            num = 2;
            continue;
          case 2:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidEntity, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521524360)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993239385)),
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidEnum, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710735478)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406028827)),
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidDataClass, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317642102)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751506512))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334975991));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node1 = this.CreateNode(ObjectsExportConsts.ExportExtensionUidEntity.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406103923)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902122539));
      DeployTreeNode node2 = this.CreateNode(ObjectsExportConsts.ExportExtensionUidEnum.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088207720)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104870478));
      DeployTreeNode node3 = this.CreateNode(ObjectsExportConsts.ExportExtensionUidDataClass.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61319605)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138629720));
      if (!(manifest.GetChapter(ObjectsExportConsts.ExportExtensionUid) is ObjectsBAChapter chapter) || (chapter.Catalogs == null || chapter.Catalogs.Count == 0) && (chapter.SysCatalogs == null || chapter.SysCatalogs.Count == 0) && (chapter.Enums == null || chapter.Enums.Count == 0) && (chapter.DataClasses == null || chapter.DataClasses.Count == 0))
      {
        if (parameters.WithEmptyChapters)
        {
          chapterNodes.Add(node1);
          chapterNodes.Add(node2);
          chapterNodes.Add(node3);
        }
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      List<DeployTreeNode> source1 = new List<DeployTreeNode>();
      if (chapter.Catalogs != null)
        source1.AddRange((IEnumerable<DeployTreeNode>) this.GetNodes((IEnumerable<BPMAppManifestItem>) chapter.Catalogs, (Func<BPMAppManifestItem, string, string>) ((bpmAppManifestItem, displayName) => this.GetNodeName(bpmAppManifestItem, displayName, true))));
      if (chapter.SysCatalogs != null)
        source1.AddRange((IEnumerable<DeployTreeNode>) this.GetNodes((IEnumerable<BPMAppManifestItem>) chapter.SysCatalogs, true, (Func<BPMAppManifestItem, string, string>) ((bpmAppManifestItem, displayName) => this.GetNodeName(bpmAppManifestItem, displayName, false))));
      if (parameters.WithEmptyChapters || source1.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node1.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) source1.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) ObjectsChapterBuilder.\u003C\u003Ec.YZyEGn8y8tFIRQfJUoQO((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node1.Count = node1.Children.Count;
        chapterNodes.Add(node1);
      }
      List<DeployTreeNode> source2 = new List<DeployTreeNode>();
      if (chapter.Enums != null)
        source2.AddRange((IEnumerable<DeployTreeNode>) this.GetNodes((IEnumerable<BPMAppManifestItem>) chapter.Enums));
      if (parameters.WithEmptyChapters || source2.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node2.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) source2.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) ObjectsChapterBuilder.\u003C\u003Ec.YZyEGn8y8tFIRQfJUoQO((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node2.Count = node2.Children.Count;
        chapterNodes.Add(node2);
      }
      List<DeployTreeNode> source3 = new List<DeployTreeNode>();
      if (chapter.DataClasses != null)
        source3.AddRange((IEnumerable<DeployTreeNode>) this.GetDataClassNodes((IEnumerable<DataClassBAItem>) chapter.DataClasses));
      if (parameters.WithEmptyChapters || source3.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        node3.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) source3.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => (string) ObjectsChapterBuilder.\u003C\u003Ec.YZyEGn8y8tFIRQfJUoQO((object) n)), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
        node3.Count = node3.Children.Count;
        chapterNodes.Add(node3);
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    private string GetNodeName(BPMAppManifestItem item, string displayName, bool withData)
    {
      int num = 6;
      EntityBAItem entityBaItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            if (withData)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 3:
            goto label_11;
          case 4:
            goto label_9;
          case 5:
            if (entityBaItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 6:
            entityBaItem = item as EntityBAItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 0;
            continue;
          default:
            if (!entityBaItem.ExportData)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 3;
              continue;
            }
            goto case 2;
        }
      }
label_9:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710339100), (object) displayName);
label_10:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642657716), (object) displayName);
label_11:
      return displayName;
    }

    private ICollection<DeployTreeNode> GetDataClassNodes(IEnumerable<DataClassBAItem> items)
    {
      List<DeployTreeNode> dataClassNodes = new List<DeployTreeNode>();
      foreach (DataClassBAItem dataClassBaItem in items)
      {
        DataClassBAItem item = dataClassBaItem;
        try
        {
          DataClassMetadataItemHeader header = (DataClassMetadataItemHeader) null;
          this.securityService.RunWithElevatedPrivilegies((System.Action) (() =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  header = this.dataClassService.LoadOrNull(ObjectsChapterBuilder.\u003C\u003Ec__DisplayClass7_1.mLGZtX8yKFhGL1b2CxRP((object) item));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (header != null)
            dataClassNodes.Add(this.CreateNode(item.Uid.ToString(), header.DisplayName, "", header.IsDirtyItem, header.Published != null));
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675703849) + (object) item.Uid), ex);
        }
      }
      return (ICollection<DeployTreeNode>) dataClassNodes;
    }

    internal static void QK1Z6gEcIBcNHouQJAJD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bFtB5lEcZKEQ3rtTpOia() => ObjectsChapterBuilder.QNvvooEc8tZbApU1bLTr == null;

    internal static ObjectsChapterBuilder h4EZBiEcumCtsGnMaFlv() => ObjectsChapterBuilder.QNvvooEc8tZbApU1bLTr;
  }
}

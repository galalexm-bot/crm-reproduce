// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.MetadataHeaderChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>
  /// Класс для создания расширений формирования разделов BPM App, которые хранят данные в таблицах MetadataHeader
  /// </summary>
  public abstract class MetadataHeaderChapterBuilder : BPMAppChapterBuilder
  {
    /// <summary>Cервис управления метаданными в режиме Runtime</summary>
    protected readonly IMetadataRuntimeService MetadataService;
    /// <summary>Менеджер заголовков метаданных</summary>
    protected readonly MetadataItemHeaderManager MetadataItemHeaderManager;
    internal static MetadataHeaderChapterBuilder bCdb4nEs0h34KTbqcQ74;

    /// <summary>Ctor</summary>
    /// <param name="metadataService">Cервис управления метаданными в режиме Runtime</param>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    public MetadataHeaderChapterBuilder(
      IMetadataRuntimeService metadataService,
      MetadataItemHeaderManager metadataItemHeaderManager)
    {
      MetadataHeaderChapterBuilder.IMRgiCEsMaJPMYWjw1Gv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.MetadataItemHeaderManager = metadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
          default:
            this.MetadataService = metadataService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Получить список узлов дерева (DeployTreeNode) по списку элементов из манифеста BPM App
    /// </summary>
    /// <param name="items">Список элементов из манифеста BPM App</param>
    /// <returns>Список узлов дерева объектов экспорта-импорта</returns>
    protected ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items) => this.GetNodes(items, false, (Func<BPMAppManifestItem, string, string>) null);

    /// <summary>
    /// Получить список узлов дерева (DeployTreeNode) по списку элементов из манифеста BPM App
    /// </summary>
    /// <param name="items">Список элементов из манифеста BPM App</param>
    /// <param name="isSystemObject">Содержит ли список только системные объекты</param>
    /// <returns>Список узлов дерева объектов экспорта-импорта</returns>
    protected ICollection<DeployTreeNode> GetNodes(
      IEnumerable<BPMAppManifestItem> items,
      bool isSystemObject)
    {
      return this.GetNodes(items, isSystemObject, (Func<BPMAppManifestItem, string, string>) null);
    }

    /// <summary>
    /// Получить список узлов дерева (DeployTreeNode) по списку элементов из манифеста BPM App
    /// </summary>
    /// <param name="items">Список элементов из манифеста BPM App</param>
    /// <param name="getNodeName">Функция задания специального имени узлу дерева</param>
    /// <returns>Список узлов дерева объектов экспорта-импорта</returns>
    protected ICollection<DeployTreeNode> GetNodes(
      IEnumerable<BPMAppManifestItem> items,
      Func<BPMAppManifestItem, string, string> getNodeName)
    {
      return this.GetNodes(items, false, getNodeName);
    }

    /// <summary>
    /// Получить список узлов дерева (DeployTreeNode) по списку элементов из манифеста BPM App
    /// </summary>
    /// <param name="items">Список элементов из манифеста BPM App</param>
    /// <param name="isSystemObject">Содержит ли список только системные объекты</param>
    /// <param name="getNodeName">Функция задания специального имени узлу дерева</param>
    /// <returns>Список узлов дерева объектов экспорта-импорта</returns>
    protected ICollection<DeployTreeNode> GetNodes(
      IEnumerable<BPMAppManifestItem> items,
      bool isSystemObject,
      Func<BPMAppManifestItem, string, string> getNodeName)
    {
      List<DeployTreeNode> nodes = new List<DeployTreeNode>();
      foreach (BPMAppManifestItem bpmAppManifestItem in items)
      {
        DeployTreeNode node = (DeployTreeNode) null;
        if (!isSystemObject)
          node = this.GetNodeByLoadMetadataHeader(bpmAppManifestItem.Uid);
        if (node == null)
          node = this.GetNodeWithMetadataService(bpmAppManifestItem.Uid);
        if (node != null)
        {
          this.UpdateNodeNameIfNeed(getNodeName, bpmAppManifestItem, node);
          nodes.Add(node);
        }
      }
      return (ICollection<DeployTreeNode>) nodes;
    }

    /// <summary>Создание узла дерева с загрузкой данных из БД</summary>
    /// <param name="itemUid">Guid объекта</param>
    /// <returns>Узел дерева</returns>
    protected DeployTreeNode GetNodeByLoadMetadataHeader(Guid itemUid)
    {
      int num = 1;
      IMetadataItemHeader metadataItemHeader;
      string title;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataItemHeader = this.LoadHeaderData(itemUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            title = (string) MetadataHeaderChapterBuilder.No9CidEsJKGYreRHfalZ((object) metadataItemHeader);
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            if (metadataItemHeader != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return this.CreateNode(itemUid.ToString(), title, "", MetadataHeaderChapterBuilder.oqOGEbEs9nDJYQBRokDp((object) metadataItemHeader), MetadataHeaderChapterBuilder.LK7r4fEsd9ywRnsKHpXH((object) metadataItemHeader) != null);
label_6:
      return (DeployTreeNode) null;
    }

    /// <summary>
    /// Создание узла дерева с использованием сервиса управления метаданными
    /// </summary>
    /// <param name="itemUid">Guid объекта</param>
    /// <returns>Узел дерева</returns>
    protected DeployTreeNode GetNodeWithMetadataService(Guid itemUid)
    {
      switch (1)
      {
        case 1:
          DeployTreeNode node;
          try
          {
            NamedMetadata metadata = this.MetadataService.GetMetadata(itemUid) as NamedMetadata;
            int num = 3;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_10;
                case 2:
                  node = this.CreateNode(itemUid.ToString(), (string) MetadataHeaderChapterBuilder.T2jCqBEslw30DuFkgXJl((object) metadata), "");
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                  continue;
                case 3:
                  if (metadata != null)
                  {
                    num = 2;
                    continue;
                  }
                  goto label_10;
                default:
                  goto label_11;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_10;
                default:
                  MetadataHeaderChapterBuilder.Kx6txuEsjiVdMr72RaTx(MetadataHeaderChapterBuilder.uYJesmEsrE2qL1GDODpO(), MetadataHeaderChapterBuilder.o4BFc4Es5CST55iWYDie(MetadataHeaderChapterBuilder.uHgJyTEsgOvmGhc2mAQU(-105199646 ^ -104870114), (object) itemUid), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_11:
          return node;
      }
label_10:
      return (DeployTreeNode) null;
    }

    /// <summary>Обновление имени узла дерева, если задана функция</summary>
    private void UpdateNodeNameIfNeed(
      Func<BPMAppManifestItem, string, string> getNodeName,
      BPMAppManifestItem item,
      DeployTreeNode node)
    {
      if (getNodeName == null)
        return;
      node.Text = getNodeName(item, node.Text);
    }

    /// <summary>Загрузка данных о заголовке из БД</summary>
    private IMetadataItemHeader LoadHeaderData(Guid uid) => this.MetadataItemHeaderManager.LoadOrNull(uid);

    internal static void IMRgiCEsMaJPMYWjw1Gv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cMQRX8EsmCaMwvTL4d1D() => MetadataHeaderChapterBuilder.bCdb4nEs0h34KTbqcQ74 == null;

    internal static MetadataHeaderChapterBuilder i2oIbmEsyVa0YZrRO6KC() => MetadataHeaderChapterBuilder.bCdb4nEs0h34KTbqcQ74;

    internal static object No9CidEsJKGYreRHfalZ([In] object obj0) => (object) ((IMetadataItemHeader) obj0).DisplayName;

    internal static bool oqOGEbEs9nDJYQBRokDp([In] object obj0) => ((IMetadataItemHeader) obj0).IsDirtyItem;

    internal static object LK7r4fEsd9ywRnsKHpXH([In] object obj0) => (object) ((IMetadataItemHeader) obj0).Published;

    internal static object T2jCqBEslw30DuFkgXJl([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object uYJesmEsrE2qL1GDODpO() => (object) Logger.Log;

    internal static object uHgJyTEsgOvmGhc2mAQU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object o4BFc4Es5CST55iWYDie([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void Kx6txuEsjiVdMr72RaTx([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}

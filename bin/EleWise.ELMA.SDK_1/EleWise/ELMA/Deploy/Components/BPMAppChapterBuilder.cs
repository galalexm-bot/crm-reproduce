// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.BPMAppChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>
  /// Базовый класс расширения формирования элементов BPM App
  /// </summary>
  public abstract class BPMAppChapterBuilder : IBPMAppChapterBuilder
  {
    internal static BPMAppChapterBuilder z9bxTVEsYB1ALKHIOdBH;

    /// <inheritdoc />
    public IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppFakeManifest manifest)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439582768));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      if (this.BuilderTemplate == null)
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      foreach (BPMAppChapterBuilder.BPMAppChapterBuilderTemplate chapterBuilderTemplate in this.BuilderTemplate)
      {
        if (chapterBuilderTemplate != null)
        {
          BPMAppChapterBuilder.BPMAppChapterBuilderTemplate template1 = chapterBuilderTemplate;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          foreach (BPMAppManifestFakeChapter manifestFakeChapter in manifest.Chapters.Where<BPMAppManifestFakeChapter>((Func<BPMAppManifestFakeChapter, bool>) (c => BPMAppChapterBuilder.\u003C\u003Ec__DisplayClass1_0.bmtV148m9h4xSciYQfGc((object) BPMAppChapterBuilder.\u003C\u003Ec__DisplayClass1_0.q9IAvy8mM43ioUB2GZ1A((object) c), (object) BPMAppChapterBuilder.\u003C\u003Ec__DisplayClass1_0.phbdbe8mJTPQuHfCoPBk((object) template1)))))
          {
            DeployTreeNode node = this.CreateNode(chapterBuilderTemplate.ChapterUid.ToString(), string.IsNullOrWhiteSpace(manifestFakeChapter.Title) ? chapterBuilderTemplate.Title : manifestFakeChapter.Title, chapterBuilderTemplate.Image);
            this.GetFakeItemNodes(node, manifestFakeChapter.Items, node.Children);
            chapterNodes.Add(node);
          }
        }
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    /// <inheritdoc />
    public abstract IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters);

    /// <summary>Шаблоны формирования раздела дерева</summary>
    protected abstract IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate { get; }

    /// <summary>Получить список узлов</summary>
    /// <param name="parentNode">Родительский узел</param>
    /// <param name="parentItems">Список элементов</param>
    /// <param name="parentNodes">Список родительских узлов</param>
    protected virtual void GetFakeItemNodes(
      DeployTreeNode parentNode,
      List<BPMAppManifestFakeItem> parentItems,
      ICollection<DeployTreeNode> parentNodes)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (BPMAppManifestFakeItem manifestFakeItem in (IEnumerable<BPMAppManifestFakeItem>) parentItems.OrderBy<BPMAppManifestFakeItem, string>((Func<BPMAppManifestFakeItem, string>) (i => (string) BPMAppChapterBuilder.\u003C\u003Ec.Au0cr38m5InFhfIuEpp9((object) i))))
      {
        DeployTreeNode node = this.CreateNode(string.IsNullOrWhiteSpace(manifestFakeItem.UidProxy) ? manifestFakeItem.Uid.ToString() : manifestFakeItem.UidProxy, string.IsNullOrWhiteSpace(manifestFakeItem.TitleAdditional) ? manifestFakeItem.Title : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647995802), (object) manifestFakeItem.Title, (object) manifestFakeItem.TitleAdditional), "");
        parentNodes.Add(node);
        this.GetFakeItemNodes(node, manifestFakeItem.Items, node.Children);
      }
      parentNode.Count = parentNode.Children.Count;
    }

    /// <summary>Создание узла дерева</summary>
    /// <param name="uid">Идентификатор</param>
    /// <param name="title">Заголовок</param>
    /// <param name="icon">Иконка</param>
    protected DeployTreeNode CreateNode(string uid, string title, string icon) => new DeployTreeNode((string) BPMAppChapterBuilder.G0Yd5HEssmEeLfddL2Kg((object) uid), title, icon);

    /// <summary>Создание узла дерева</summary>
    /// <param name="uid">Идентификатор</param>
    /// <param name="title">Заголовок</param>
    /// <param name="icon">Иконка</param>
    /// <param name="isDirtyItem">Есть неопубликованные изменения</param>
    /// <param name="isPublished">У объекта есть опубликованная версия</param>
    protected DeployTreeNode CreateNode(
      string uid,
      string title,
      string icon,
      bool isDirtyItem,
      bool isPublished)
    {
      return new DeployTreeNode((string) BPMAppChapterBuilder.G0Yd5HEssmEeLfddL2Kg((object) uid), title, icon, isDirtyItem, isPublished);
    }

    protected BPMAppChapterBuilder()
    {
      BPMAppChapterBuilder.nJEHNUEscQ30PYOkJoAj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object G0Yd5HEssmEeLfddL2Kg([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool zkhau7EsLCuaYviOqwoe() => BPMAppChapterBuilder.z9bxTVEsYB1ALKHIOdBH == null;

    internal static BPMAppChapterBuilder tc0boCEsUq5u0opPcTdC() => BPMAppChapterBuilder.z9bxTVEsYB1ALKHIOdBH;

    internal static void nJEHNUEscQ30PYOkJoAj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Класс шаблона формирования раздела дерева</summary>
    protected class BPMAppChapterBuilderTemplate
    {
      private static BPMAppChapterBuilder.BPMAppChapterBuilderTemplate MoUr7q8mHxUQ4pe3D4EO;

      /// <summary>Ctor</summary>
      /// <param name="chapterUid">Идентификатор раздела</param>
      /// <param name="title">Заголовок</param>
      /// <param name="image">Картинка</param>
      public BPMAppChapterBuilderTemplate(Guid chapterUid, string title, string image)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Title = title;
              num = 3;
              continue;
            case 2:
              this.ChapterUid = chapterUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
              continue;
            case 3:
              this.Image = image;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }

      /// <summary>Идентификатор раздела</summary>
      public Guid ChapterUid
      {
        get => this.\u003CChapterUid\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CChapterUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Заголовок</summary>
      public string Title
      {
        get => this.\u003CTitle\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CTitle\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Картинка</summary>
      public string Image
      {
        get => this.\u003CImage\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CImage\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      internal static bool wbLK328mAiPVbK1tqOv6() => BPMAppChapterBuilder.BPMAppChapterBuilderTemplate.MoUr7q8mHxUQ4pe3D4EO == null;

      internal static BPMAppChapterBuilder.BPMAppChapterBuilderTemplate lC1tcW8m7oYQrBnTqFb7() => BPMAppChapterBuilder.BPMAppChapterBuilderTemplate.MoUr7q8mHxUQ4pe3D4EO;
    }
  }
}

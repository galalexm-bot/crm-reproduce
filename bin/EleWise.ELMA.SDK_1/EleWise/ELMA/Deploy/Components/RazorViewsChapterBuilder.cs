// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.RazorViewsChapterBuilder
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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Расширение формирования раздела документов BPM App</summary>
  [Component(Order = 570)]
  internal sealed class RazorViewsChapterBuilder : BPMAppChapterBuilder
  {
    internal static RazorViewsChapterBuilder BUHuu4EcXS3uGS0RBJvT;

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(RazorViewsExportConsts.ExportExtensionUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082204102)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461430417))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1596982960));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node = this.CreateNode(RazorViewsExportConsts.ExportExtensionUid.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470114176)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978681341));
      if (!(manifest.GetChapter(RazorViewsExportConsts.ExportExtensionUid) is RazorViewsBAChapter chapter) || chapter.ViewVirtualPaths == null || chapter.ViewVirtualPaths.Count == 0)
      {
        if (parameters.WithEmptyChapters)
          chapterNodes.Add(node);
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      foreach (RazorViewBAItem viewVirtualPath in chapter.ViewVirtualPaths)
        this.FillTree(viewVirtualPath.ViewVirtualPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487395792), node);
      this.FillCounter(node);
      chapterNodes.Add(node);
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    private void FillTree(string path, string parentPath, DeployTreeNode parent)
    {
      int num1 = 5;
      int startIndex;
      int num2;
      string text1;
      string text2;
      DeployTreeNode parent1;
      string currentPath;
      while (true)
      {
        switch (num1)
        {
          case 1:
            text1 = (string) RazorViewsChapterBuilder.gfGR9mEcO8fLsDsj1vxT((object) path, startIndex);
            num1 = 10;
            continue;
          case 2:
            if (num2 >= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_11;
          case 4:
            num2 = path.IndexOf('/', startIndex);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
            continue;
          case 5:
            startIndex = RazorViewsChapterBuilder.O7HpaVEcnZOnowQS7dKh((object) parentPath);
            num1 = 4;
            continue;
          case 6:
            DeployTreeNode deployTreeNode = parent;
            RazorViewsChapterBuilder.vAdhB7Eceyj2UDgVUuAE((object) deployTreeNode, RazorViewsChapterBuilder.oAMIVlEc25cNwW7TGt9S((object) deployTreeNode) + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 14 : 0;
            continue;
          case 7:
            text2 = (string) RazorViewsChapterBuilder.aH0jMuEcPlqJHNus2uvZ((object) path, startIndex, num2 - startIndex);
            num1 = 12;
            continue;
          case 8:
            parent.Children.Add(new DeployTreeNode(currentPath, text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841678774)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated method
            if (parent.Children.Any<DeployTreeNode>((Func<DeployTreeNode, bool>) (item => (string) RazorViewsChapterBuilder.\u003C\u003Ec__DisplayClass3_0.KUnoRu8y1euv2Yq2lrlB((object) item) == currentPath)))
            {
              num1 = 13;
              continue;
            }
            goto case 8;
          case 10:
            parent.Children.Add(new DeployTreeNode(path, text1, ""));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 6;
            continue;
          case 11:
            this.FillTree(path, currentPath, parent1);
            num1 = 3;
            continue;
          case 12:
            currentPath = (string) RazorViewsChapterBuilder.q4ivGMEcN8WHebJODPNR((object) parentPath, (object) text2, RazorViewsChapterBuilder.sF76PrEc11EfOOUynFRZ(--1333735954 ^ 1333745218));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 9 : 9;
            continue;
          case 14:
            goto label_8;
          default:
            // ISSUE: reference to a compiler-generated method
            parent1 = parent.Children.First<DeployTreeNode>((Func<DeployTreeNode, bool>) (item => RazorViewsChapterBuilder.\u003C\u003Ec__DisplayClass3_0.dfmY0K8yNxy0gxFisKWT((object) item.Id, (object) currentPath)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 11 : 2;
            continue;
        }
      }
label_11:
      return;
label_8:;
    }

    private void FillCounter(DeployTreeNode node)
    {
      int num1 = 3;
      IEnumerator<DeployTreeNode> enumerator;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
            enumerator = node.Children.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 3:
            num2 = RazorViewsChapterBuilder.oAMIVlEc25cNwW7TGt9S((object) node);
            num1 = 2;
            continue;
          case 4:
label_4:
            RazorViewsChapterBuilder.vAdhB7Eceyj2UDgVUuAE((object) node, num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
            continue;
          default:
            try
            {
label_12:
              if (RazorViewsChapterBuilder.eeUl92Ec3ZOW6h7ijS8L((object) enumerator))
                goto label_9;
              else
                goto label_13;
label_7:
              DeployTreeNode current;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_12;
                  case 2:
                    goto label_9;
                  case 3:
                    num2 += RazorViewsChapterBuilder.oAMIVlEc25cNwW7TGt9S((object) current);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
                    continue;
                  case 4:
                    goto label_4;
                  default:
                    this.FillCounter(current);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 3;
                    continue;
                }
              }
label_9:
              current = enumerator.Current;
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
              {
                num3 = 0;
                goto label_7;
              }
              else
                goto label_7;
label_13:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 4 : 3;
              goto label_7;
            }
            finally
            {
              if (enumerator != null)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      enumerator.Dispose();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_20;
                  }
                }
              }
label_20:;
            }
        }
      }
label_18:;
    }

    /// <inheritdoc />
    protected override void GetFakeItemNodes(
      DeployTreeNode parentNode,
      List<BPMAppManifestFakeItem> parentItems,
      ICollection<DeployTreeNode> parentNodes)
    {
      int num = 0;
      // ISSUE: reference to a compiler-generated method
      foreach (BPMAppManifestFakeItem manifestFakeItem in (IEnumerable<BPMAppManifestFakeItem>) parentItems.OrderBy<BPMAppManifestFakeItem, string>((Func<BPMAppManifestFakeItem, string>) (i => (string) RazorViewsChapterBuilder.\u003C\u003Ec.NYhOlq8yttg5AqkGufPT((object) i))))
      {
        DeployTreeNode node = this.CreateNode(string.IsNullOrWhiteSpace(manifestFakeItem.UidProxy) ? manifestFakeItem.Uid.ToString() : manifestFakeItem.UidProxy, string.IsNullOrWhiteSpace(manifestFakeItem.TitleAdditional) ? manifestFakeItem.Title : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146594445), (object) manifestFakeItem.Title, (object) manifestFakeItem.TitleAdditional), string.Equals(Path.GetExtension(manifestFakeItem.Title), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633187979), StringComparison.CurrentCultureIgnoreCase) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883153154) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319226938));
        if (string.Equals(Path.GetExtension(node.Text), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146311165), StringComparison.CurrentCultureIgnoreCase))
          ++num;
        parentNodes.Add(node);
        this.GetFakeItemNodes(node, manifestFakeItem.Items, node.Children);
        num += node.Count;
      }
      parentNode.Count = num;
    }

    public RazorViewsChapterBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int O7HpaVEcnZOnowQS7dKh([In] object obj0) => ((string) obj0).Length;

    internal static object gfGR9mEcO8fLsDsj1vxT([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static int oAMIVlEc25cNwW7TGt9S([In] object obj0) => ((DeployTreeNode) obj0).Count;

    internal static void vAdhB7Eceyj2UDgVUuAE([In] object obj0, int value) => ((DeployTreeNode) obj0).Count = value;

    internal static object aH0jMuEcPlqJHNus2uvZ([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object sF76PrEc11EfOOUynFRZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object q4ivGMEcN8WHebJODPNR([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool OqjqYYEcTXOLKoxvlaQs() => RazorViewsChapterBuilder.BUHuu4EcXS3uGS0RBJvT == null;

    internal static RazorViewsChapterBuilder dw8WqqEck0M1xM7uoAJR() => RazorViewsChapterBuilder.BUHuu4EcXS3uGS0RBJvT;

    internal static bool eeUl92Ec3ZOW6h7ijS8L([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}

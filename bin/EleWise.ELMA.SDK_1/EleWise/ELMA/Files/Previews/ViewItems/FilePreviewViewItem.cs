// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ViewItems.FilePreviewViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews.ViewItems
{
  /// <summary>Элемент представления "Предпросмотр"</summary>
  [DisplayName(typeof (__Resources_FilePreviewViewItem), "DisplayName")]
  [Serializable]
  public class FilePreviewViewItem : ViewItem
  {
    private static FilePreviewViewItem jSJtGRG3Ooodbm7iMqVY;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return FilePreviewViewItem.uQyAE8G3P9Rw7PihhUcT((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => false;

    public FilePreviewViewItem()
    {
      FilePreviewViewItem.QM7AVrG31SO1hS631rbY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool uQyAE8G3P9Rw7PihhUcT([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static bool YqBGEyG32mPfWHgaXTm7() => FilePreviewViewItem.jSJtGRG3Ooodbm7iMqVY == null;

    internal static FilePreviewViewItem tIsmZPG3eATTtJ6Dha3B() => FilePreviewViewItem.jSJtGRG3Ooodbm7iMqVY;

    internal static void QM7AVrG31SO1hS631rbY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component(Order = 100)]
    private class ToolboxItem : AdditionalViewItemToolboxItem<FilePreviewViewItem>
    {
      /// <summary>Точки расширения для определения доступности элемента</summary>
      private IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable;
      internal static object FWq2O28FuQvaDBCdrT1k;

      public ToolboxItem(
        IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.filePreviewViewItemAvailable = filePreviewViewItemAvailable;
      }

      /// <inheritdoc />
      public override bool IsAvailable(IMetadata metadata)
      {
        int num1 = 2;
        IEnumerator<IFilePreviewViewItemAvailable> enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_5;
            case 2:
              enumerator = this.filePreviewViewItemAvailable.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return false;
label_5:
        bool flag;
        try
        {
label_7:
          if (FilePreviewViewItem.ToolboxItem.AU6UyK8FiBgmRLogASil((object) enumerator))
            goto label_9;
          else
            goto label_8;
label_6:
          int num2;
          switch (num2)
          {
            case 1:
            case 4:
              goto label_7;
            case 2:
              goto label_3;
            case 3:
              goto label_4;
            case 5:
              goto label_9;
            default:
              goto label_11;
          }
label_8:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 0;
          goto label_6;
label_9:
          if (!FilePreviewViewItem.ToolboxItem.DNxlsd8FSl4ukAUW3LsN((object) enumerator.Current, (object) metadata))
          {
            num2 = 4;
            goto label_6;
          }
label_11:
          flag = true;
          num2 = 3;
          goto label_6;
        }
        finally
        {
          int num3;
          if (enumerator == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
          else
            goto label_15;
label_14:
          switch (num3)
          {
            case 2:
              break;
            default:
          }
label_15:
          FilePreviewViewItem.ToolboxItem.Gk3ltk8FRPyWjSt3MyIF((object) enumerator);
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          {
            num3 = 1;
            goto label_14;
          }
          else
            goto label_14;
        }
label_4:
        return flag;
      }

      /// <inheritdoc />
      public override string Name => (string) FilePreviewViewItem.ToolboxItem.WDPalx8FKXooLSuIKMfr(FilePreviewViewItem.ToolboxItem.yyrIi18FqJ0N6H23pd0H(-1290212282 ^ -644262414 ^ 1786924862));

      internal static bool DNxlsd8FSl4ukAUW3LsN([In] object obj0, [In] object obj1) => ((IFilePreviewViewItemAvailable) obj0).IsAvailable((IMetadata) obj1);

      internal static bool AU6UyK8FiBgmRLogASil([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void Gk3ltk8FRPyWjSt3MyIF([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static bool Diqso98FIcoQP79bdJIP() => FilePreviewViewItem.ToolboxItem.FWq2O28FuQvaDBCdrT1k == null;

      internal static FilePreviewViewItem.ToolboxItem geuLsd8FVSsmmKH8vBfJ() => (FilePreviewViewItem.ToolboxItem) FilePreviewViewItem.ToolboxItem.FWq2O28FuQvaDBCdrT1k;

      internal static object yyrIi18FqJ0N6H23pd0H(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object WDPalx8FKXooLSuIKMfr([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}

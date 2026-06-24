// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.ViewItemToolboxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>
  /// Элемент представления в панели инструментов на основе заданного типа элемента
  /// </summary>
  public abstract class ViewItemToolboxItem<TViewItem> : ViewItemToolboxItem where TViewItem : ViewItem
  {
    private IMetadataEditorService metadataEditorService;
    private static object i2BHBYoabCo1FYCASTfD;

    private IMetadataEditorService MetadataEditorService
    {
      get
      {
        int num = 1;
        IMetadataEditorService service;
        IMetadataEditorService metadataEditorService;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadataEditorService = this.metadataEditorService;
              if (metadataEditorService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.metadataEditorService = service = Locator.Initialized ? Locator.GetService<IMetadataEditorService>() : (IMetadataEditorService) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return metadataEditorService;
label_6:
        return service;
      }
    }

    public override string Name
    {
      get
      {
        int num = 1;
        ViewItemTypeInfo viewItemTypeInfo1;
        while (true)
        {
          ViewItemInfoService viewItemInfoService1;
          ViewItemInfoService viewItemInfoService2;
          ViewItemTypeInfo viewItemTypeInfo2;
          switch (num)
          {
            case 1:
              if (!Locator.Initialized)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                continue;
              }
              viewItemInfoService2 = Locator.GetService<ViewItemInfoService>();
              break;
            case 2:
              viewItemTypeInfo2 = (ViewItemTypeInfo) null;
              goto label_15;
            case 3:
              if (viewItemInfoService1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
                continue;
              }
              viewItemTypeInfo2 = viewItemInfoService1.GetInfo(typeof (TViewItem));
              goto label_15;
            case 4:
              if (viewItemTypeInfo1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 5 : 5;
                continue;
              }
              goto label_6;
            case 5:
              goto label_5;
            default:
              viewItemInfoService2 = (ViewItemInfoService) null;
              break;
          }
          viewItemInfoService1 = viewItemInfoService2;
          num = 3;
          continue;
label_15:
          viewItemTypeInfo1 = viewItemTypeInfo2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 4 : 1;
        }
label_5:
        return string.Empty;
label_6:
        return viewItemTypeInfo1.Name;
      }
    }

    public override ViewItem CreateViewItem()
    {
      TViewItem instance = Activator.CreateInstance<TViewItem>();
      instance.InitNew((ViewItem) null);
      return (ViewItem) instance;
    }

    public override bool IsAvailable(IMetadata metadata)
    {
      int num = 2;
      Guid[] uids;
      while (true)
      {
        Guid[] guidArray;
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            guidArray = new Guid[1]{ metadata.Uid };
            break;
          case 2:
            if (!(metadata is ClassMetadata metadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            }
            guidArray = this.GetBaseClassesList(metadata1, false).Union<ClassMetadata>((IEnumerable<ClassMetadata>) new ClassMetadata[1]
            {
              metadata1
            }).SelectMany<ClassMetadata, Guid>((Func<ClassMetadata, IEnumerable<Guid>>) (m => !(m is EntityMetadata entityMetadata) ? (IEnumerable<Guid>) new Guid[1]
            {
              m.Uid
            } : (IEnumerable<Guid>) new Guid[2]
            {
              entityMetadata.Uid,
              entityMetadata.ImplementationUid
            })).ToArray<Guid>();
            break;
          case 3:
            goto label_3;
          default:
            guidArray = (Guid[]) null;
            break;
        }
        uids = guidArray;
        num = 3;
      }
label_3:
      return ViewItemMetadataAttribute.IsAvailable(typeof (TViewItem), (ICollection<Guid>) uids);
    }

    private List<ClassMetadata> GetBaseClassesList(ClassMetadata metadata, bool loadImplementation = true)
    {
      List<ClassMetadata> res = new List<ClassMetadata>();
      this.GetBaseClass(metadata, res, loadImplementation);
      return res;
    }

    private void GetBaseClass(
      ClassMetadata metadata,
      List<ClassMetadata> res,
      bool loadImplementation = true)
    {
      if (metadata.BaseClassUid == Guid.Empty || !(this.MetadataEditorService.GetMetadata(metadata.BaseClassUid, loadImplementation) is ClassMetadata metadata2) && !(MetadataLoader.LoadMetadataOrNull(metadata.BaseClassUid, false, loadImplementation) is ClassMetadata metadata2))
        return;
      res.Add(metadata2);
      this.GetBaseClass(metadata2, res, loadImplementation);
    }

    protected ViewItemToolboxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Pi20pioahYZfEnV9QFVx() => ViewItemToolboxItem<TViewItem>.i2BHBYoabCo1FYCASTfD == null;

    internal static object mobE3aoaG6PmShMsuUC6() => ViewItemToolboxItem<TViewItem>.i2BHBYoabCo1FYCASTfD;
  }
}

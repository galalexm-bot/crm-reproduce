// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.UIFormDependencyExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  [Component(Order = 75)]
  internal class UIFormDependencyExtension : IFormDependencyExtension
  {
    internal static UIFormDependencyExtension zeUyQ8GwWZPWHjFHgL7d;

    public bool CheckType(Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!UIFormDependencyExtension.kvfE4xGwhLtTV8ybkA7U(uid, PageMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return UIFormDependencyExtension.kvfE4xGwhLtTV8ybkA7U(uid, PortletMetadata.TypeUid);
label_3:
      return true;
    }

    public bool ExistForm(Guid objectUid, Guid formUid)
    {
      int num = 2;
      IFormMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadataItemHeader != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            metadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(formUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return UIFormDependencyExtension.vpfUMkGwG1hJNOvHndoT((object) metadataItemHeader) != null;
label_3:
      return false;
    }

    public IEnumerable<Guid> GetFormUids(Guid uid) => (IEnumerable<Guid>) new List<Guid>()
    {
      uid
    };

    public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      IMetadata usesObjectMetadata,
      Guid usesObjectFormUid,
      FormDependencyDataType type)
    {
      return (IEnumerable<IFormDependencyData>) new List<IFormDependencyData>();
    }

    public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      Guid usesObjectUid,
      Guid usesObjectFormUid,
      FormDependencyDataType type)
    {
      return (IEnumerable<IFormDependencyData>) new List<IFormDependencyData>();
    }

    public void GenerateNewDependencies(IMetadata dependObjectMetadata)
    {
      int num = 14;
      Guid typeUid;
      PortletMetadata portletMetadata;
      FormViewItem form;
      List<IFormDependencyData> formDependencyDataList;
      FormMetadata formMetadata;
      PageMetadata pageMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (pageMetadata != null)
            {
              num = 18;
              continue;
            }
            goto case 16;
          case 2:
            portletMetadata = formMetadata as PortletMetadata;
            num = 3;
            continue;
          case 3:
            if (portletMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 6;
              continue;
            }
            goto case 5;
          case 4:
            pageMetadata = formMetadata as PageMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          case 5:
            form = (FormViewItem) UIFormDependencyExtension.oeTgXMGwfMHJjJQCyJih(UIFormDependencyExtension.XXQjZcGwQNFBLava8wcs((object) portletMetadata));
            num = 9;
            continue;
          case 7:
            goto label_19;
          case 8:
            goto label_21;
          case 10:
            formDependencyDataList.AddRange(FormDependencyHelper.GenerateFormDependencies(typeUid, form, new Guid?(UIFormDependencyExtension.AaM30nGwCYplEmBWS6uq((object) formMetadata))));
            num = 15;
            continue;
          case 11:
            formDependencyDataList = new List<IFormDependencyData>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 3 : 4;
            continue;
          case 12:
            form = (FormViewItem) UIFormDependencyExtension.oeTgXMGwfMHJjJQCyJih(UIFormDependencyExtension.VBhCZlGwEEAt7KcVTQBp((object) pageMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 13:
            if (formMetadata != null)
            {
              num = 17;
              continue;
            }
            goto label_5;
          case 14:
            formMetadata = dependObjectMetadata as FormMetadata;
            num = 13;
            continue;
          case 15:
            FormDependencyHelper.Update(typeUid, (IFormDependencyData[]) UIFormDependencyExtension.CLJbqZGwvmA2DG9cDQx8((object) formDependencyDataList));
            num = 8;
            continue;
          case 16:
            typeUid = PortletMetadata.TypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
            continue;
          case 17:
            form = (FormViewItem) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 11 : 11;
            continue;
          case 18:
            typeUid = PageMetadata.TypeUid;
            num = 12;
            continue;
          default:
            if (form != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 10 : 2;
              continue;
            }
            goto case 15;
        }
      }
label_19:
      return;
label_21:
      return;
label_5:;
    }

    public void GenerateNewDependencies(Guid dependObjectUid)
    {
      int num = 9;
      IFormMetadataItemHeader metadataItemHeader;
      FormMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_9;
          case 3:
            goto label_18;
          case 4:
            this.GenerateNewDependencies((IMetadata) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 6;
            continue;
          case 5:
            if (UIFormDependencyExtension.vpfUMkGwG1hJNOvHndoT((object) metadataItemHeader) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 6:
            goto label_15;
          case 7:
            if (metadata != null)
            {
              num = 4;
              continue;
            }
            goto label_14;
          case 8:
            if (metadataItemHeader == null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 9:
            metadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(dependObjectUid);
            num = 8;
            continue;
          default:
            if (((IFormMetadataItem) UIFormDependencyExtension.vpfUMkGwG1hJNOvHndoT((object) metadataItemHeader)).Metadata == null)
            {
              num = 2;
              continue;
            }
            metadata = ((IFormMetadataItem) UIFormDependencyExtension.vpfUMkGwG1hJNOvHndoT((object) metadataItemHeader)).Metadata as FormMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 6 : 7;
            continue;
        }
      }
label_5:
      return;
label_9:
      return;
label_18:
      return;
label_15:
      return;
label_2:
      return;
label_14:;
    }

    public UIFormDependencyExtension()
    {
      UIFormDependencyExtension.PdJmWDGw8IC8FT5iiNP0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kvfE4xGwhLtTV8ybkA7U([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool iEMYepGwogoZuGEaes5J() => UIFormDependencyExtension.zeUyQ8GwWZPWHjFHgL7d == null;

    internal static UIFormDependencyExtension TYU5fMGwbVwCdY8kjXyE() => UIFormDependencyExtension.zeUyQ8GwWZPWHjFHgL7d;

    internal static object vpfUMkGwG1hJNOvHndoT([In] object obj0) => (object) ((IFormMetadataItemHeader) obj0).Draft;

    internal static object VBhCZlGwEEAt7KcVTQBp([In] object obj0) => (object) ((PageMetadata) obj0).Content;

    internal static object oeTgXMGwfMHJjJQCyJih([In] object obj0) => (object) ((FormPartMetadata) obj0).View;

    internal static object XXQjZcGwQNFBLava8wcs([In] object obj0) => (object) ((PortletMetadata) obj0).Content;

    internal static Guid AaM30nGwCYplEmBWS6uq([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object CLJbqZGwvmA2DG9cDQx8([In] object obj0) => (object) ((List<IFormDependencyData>) obj0).ToArray();

    internal static void PdJmWDGw8IC8FT5iiNP0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

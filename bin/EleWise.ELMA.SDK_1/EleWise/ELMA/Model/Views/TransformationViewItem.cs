// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TransformationViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Struct;
using EleWise.ELMA.Model.Views.Toolbar;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class TransformationViewItem : Transformation<ViewItem, TransformationViewItem, Guid>
  {
    internal static TransformationViewItem DgJxLno1ub0GbqrS3sIn;

    protected internal override IList<ViewItem> GetSubItems(ViewItem item) => !(item is RootViewItem rootViewItem) ? (IList<ViewItem>) new ViewItem[0] : (IList<ViewItem>) rootViewItem.Items;

    protected internal override bool EqualsItems(ViewItem item, Guid? uid)
    {
      if (item == null && !uid.HasValue)
        return true;
      return item != null && uid.HasValue && item.IsUid(uid.Value);
    }

    protected internal override Guid GetUid(ViewItem item) => item.Uid;

    protected internal override bool IsHide(ViewItem item) => TransformationViewItem.qLw7R9o1SopCRY34H1c8((object) item);

    protected internal override void SetHide(ViewItem parentItem, ViewItem item, bool hide = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationViewItem.u034pjo1iq9E61na5FtA((object) item, hide);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected internal override ViewItem CreateCopy(ViewItem item) => (ViewItem) TransformationViewItem.ue42VFo1R1ReB3Fuj4tV((object) item, true);

    protected internal override ViewItem Clone(ViewItem item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (item != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (ViewItem) null;
label_5:
      return item.Clone();
    }

    public static FormViewItemTransformation CreateTransformation(
      ViewItem item,
      ViewItem originalItem)
    {
      return (FormViewItemTransformation) Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance.TransformationCreate(item, originalItem);
    }

    protected override BaseTransformation<ViewItem, Guid> TransformationCreate(
      ViewItem item,
      ViewItem originalItem)
    {
      FormViewItemTransformation res = new FormViewItemTransformation();
      res.Uid = originalItem.Uid;
      FormViewItem formViewItem1 = item as FormViewItem;
      FormViewItem formViewItem2 = originalItem as FormViewItem;
      if (formViewItem1 != null && formViewItem2 != null && (formViewItem1.Toolbar != null || formViewItem2.Toolbar != null))
        res.ToolbarTransformation = Transformation<ToolbarItem, ToolbarItemTransformation, Guid, Guid?>.CreateTransformation((ToolbarItem) (formViewItem1.Toolbar ?? new EleWise.ELMA.Model.Views.Toolbar.Toolbar()), (ToolbarItem) (formViewItem2.Toolbar ?? new EleWise.ELMA.Model.Views.Toolbar.Toolbar()));
      res.Items.AddRange(this.AddMoveTransformations(item, originalItem).Cast<ViewItemTransformation>());
      res.Items.AddRange(this.HideTransformations(item, originalItem).Cast<ViewItemTransformation>());
      res.Items.AddRange((IEnumerable<ViewItemTransformation>) this.ChangeTransformations(item, originalItem, originalItem.Root).Cast<ViewItemTransformationChange>().Where<ViewItemTransformationChange>((Func<ViewItemTransformationChange, bool>) (t =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.rEdmv3CCDEEHHioZbHjx((object) res, (object) (string) TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.Cl1EwbCCpmVRXsHltP4w((object) t));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 5 : 4;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.cXtFNtCC3AqrLWg8Zxdr(TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.KOKv7lCC1qkDo1CDcNtc((object) t), TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.IXoC43CCNjEPpuLkq1Px(-1867198571 ^ -1867203499)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 6;
                continue;
              }
              break;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (t.Uid == TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.dp0usvCCP43GbgT20idw((object) originalItem))
              {
                num = 2;
                continue;
              }
              goto label_10;
            case 4:
              goto label_6;
            case 5:
              goto label_9;
            case 6:
              if (t.PropertyName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654130669))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                continue;
              }
              goto label_10;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.QlCxsgCCawolq2s9ylUA((object) res, (object) (string) TransformationViewItem.\u003C\u003Ec__DisplayClass8_0.Cl1EwbCCpmVRXsHltP4w((object) t));
          num = 4;
        }
label_6:
        return false;
label_9:
        return false;
label_10:
        return true;
      })));
      return string.IsNullOrEmpty(res.NewFormName) && string.IsNullOrEmpty(res.NewFormDisplayName) && !res.Items.Any<ViewItemTransformation>() && res.ToolbarTransformation == null ? (BaseTransformation<ViewItem, Guid>) null : (BaseTransformation<ViewItem, Guid>) res;
    }

    /// <inheritdoc />
    protected override IEnumerable<BaseTransformation<ViewItem, Guid>> ChangeTransformations(
      ViewItem viewItem,
      ViewItem originalItem,
      ViewItem originalItemRoot)
    {
      IEnumerable<BaseTransformation<ViewItem, Guid>> source = base.ChangeTransformations(viewItem, originalItem, originalItemRoot);
      object obj = ViewItemTransformationChange.CheckDynamicProperties(viewItem, originalItem);
      if (obj != null)
        source = source.Append<BaseTransformation<ViewItem, Guid>>(this.TransformationChange(viewItem.Uid, viewItem.GetType(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306610038), obj, false));
      return source;
    }

    protected override BaseTransformation<ViewItem, Guid> TransformationAdd(
      Guid itemUid,
      ViewItem item,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      ViewItemTransformationAdd transformationAdd = new ViewItemTransformationAdd();
      transformationAdd.Uid = itemUid;
      transformationAdd.Item = this.CreateCopy(item);
      transformationAdd.AfterItem = afterItem;
      transformationAdd.BeforeItem = beforeItem;
      return (BaseTransformation<ViewItem, Guid>) transformationAdd;
    }

    protected override BaseTransformation<ViewItem, Guid> TransformationChange(
      Guid itemUid,
      Type type,
      string propertyName,
      object value,
      bool localizable = false)
    {
      ViewItemTransformationChange transformationChange = new ViewItemTransformationChange();
      transformationChange.Uid = itemUid;
      transformationChange.PropertyName = propertyName;
      transformationChange.Localizable = localizable;
      transformationChange.Value = value;
      transformationChange.TypeName = type.AssemblyQualifiedName;
      return (BaseTransformation<ViewItem, Guid>) transformationChange;
    }

    protected override BaseTransformation<ViewItem, Guid> TransformationHide(Guid itemUid)
    {
      ViewItemTransformationHide transformationHide = new ViewItemTransformationHide();
      transformationHide.Uid = itemUid;
      return (BaseTransformation<ViewItem, Guid>) transformationHide;
    }

    protected override BaseTransformation<ViewItem, Guid> TransformationMove(
      Guid itemUid,
      Guid moveItemUid,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      ViewItemTransformationMove transformationMove = new ViewItemTransformationMove();
      transformationMove.Uid = itemUid;
      transformationMove.MoveItemUid = moveItemUid;
      transformationMove.AfterItem = afterItem;
      transformationMove.BeforeItem = beforeItem;
      return (BaseTransformation<ViewItem, Guid>) transformationMove;
    }

    public TransformationViewItem()
    {
      TransformationViewItem.hRaQ7Yo1qQfbuJvoKmWh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qLw7R9o1SopCRY34H1c8([In] object obj0) => ((ViewItem) obj0).Hide;

    internal static void u034pjo1iq9E61na5FtA([In] object obj0, bool value) => ((ViewItem) obj0).Hide = value;

    internal static bool ri1pIKo1ISe1BeEOMM7e() => TransformationViewItem.DgJxLno1ub0GbqrS3sIn == null;

    internal static TransformationViewItem QuKBqpo1VnqKQiDidXmj() => TransformationViewItem.DgJxLno1ub0GbqrS3sIn;

    internal static object ue42VFo1R1ReB3Fuj4tV([In] object obj0, bool copyUid) => (object) ((ViewItem) obj0).CreateCopy(copyUid);

    internal static void hRaQ7Yo1qQfbuJvoKmWh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

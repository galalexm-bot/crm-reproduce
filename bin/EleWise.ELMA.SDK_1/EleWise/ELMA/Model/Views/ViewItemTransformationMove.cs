// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformationMove
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ViewItemTransformationMove : ViewItemTransformation
  {
    private static ViewItemTransformationMove suqrkooPrKSIkiaWDyOv;

    public Guid MoveItemUid
    {
      get => this.\u003CMoveItemUid\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMoveItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    public Guid? BeforeItem { get; set; }

    public Guid? AfterItem { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeBeforeItem()
    {
      int num = 1;
      Guid? beforeItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            beforeItem = this.BeforeItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return beforeItem.HasValue;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeAfterItem()
    {
      int num = 1;
      Guid? afterItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            afterItem = this.AfterItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return afterItem.HasValue;
    }

    public override void Apply(ViewItem formViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationMove<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, this.Uid, this.MoveItemUid, this.BeforeItem, this.AfterItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ViewItemTransformationMove()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool brkQjAoPgAi368x0IHmP() => ViewItemTransformationMove.suqrkooPrKSIkiaWDyOv == null;

    internal static ViewItemTransformationMove ku4cnYoP5CwlKthmNZ7m() => ViewItemTransformationMove.suqrkooPrKSIkiaWDyOv;
  }
}

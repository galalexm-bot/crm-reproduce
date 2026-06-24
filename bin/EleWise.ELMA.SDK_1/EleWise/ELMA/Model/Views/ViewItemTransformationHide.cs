// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformationHide
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ViewItemTransformationHide : ViewItemTransformation
  {
    internal static ViewItemTransformationHide Kt7sJ2oPJJEZsfZPqStN;

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
            TransformationHide<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, this.Uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ViewItemTransformationHide()
    {
      ViewItemTransformationHide.GCn7xcoPlYJHpHH9U8Rh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool x5mFEyoP9fau17xWcuLA() => ViewItemTransformationHide.Kt7sJ2oPJJEZsfZPqStN == null;

    internal static ViewItemTransformationHide uM0XfQoPd3AIjS2nxQpa() => ViewItemTransformationHide.Kt7sJ2oPJJEZsfZPqStN;

    internal static void GCn7xcoPlYJHpHH9U8Rh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

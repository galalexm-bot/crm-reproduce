// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Struct.Transformation`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations.Struct
{
  [Serializable]
  public abstract class Transformation<TItem, TTransformation, TUid> : 
    Transformation<TItem, TTransformation, TUid, TUid?>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid>, new()
    where TUid : struct
  {
    private static object aMSPnmWUpvFPSTw3QR37;

    protected override TUid? ConvertUid(TUid uid) => new TUid?(uid);

    protected override BaseTransformation<TItem, TUid> TransformationAdd(
      TUid itemUid,
      TItem item,
      TUid? afterItem = null,
      TUid? beforeItem = null)
    {
      EleWise.ELMA.Model.Transformations.Struct.TransformationAdd<TItem, TTransformation, TUid> transformationAdd = new EleWise.ELMA.Model.Transformations.Struct.TransformationAdd<TItem, TTransformation, TUid>();
      transformationAdd.Uid = itemUid;
      transformationAdd.AfterItem = afterItem;
      transformationAdd.BeforeItem = beforeItem;
      transformationAdd.SetItem(item);
      return (BaseTransformation<TItem, TUid>) transformationAdd;
    }

    protected override BaseTransformation<TItem, TUid> TransformationMove(
      TUid itemUid,
      TUid moveItemUid,
      TUid? afterItem = null,
      TUid? beforeItem = null)
    {
      EleWise.ELMA.Model.Transformations.Struct.TransformationMove<TItem, TTransformation, TUid> transformationMove = new EleWise.ELMA.Model.Transformations.Struct.TransformationMove<TItem, TTransformation, TUid>();
      transformationMove.Uid = itemUid;
      transformationMove.MoveItemUid = moveItemUid;
      transformationMove.AfterItem = afterItem;
      transformationMove.BeforeItem = beforeItem;
      return (BaseTransformation<TItem, TUid>) transformationMove;
    }

    protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
    {
      EleWise.ELMA.Model.Transformations.Struct.TransformationHide<TItem, TTransformation, TUid> transformationHide = new EleWise.ELMA.Model.Transformations.Struct.TransformationHide<TItem, TTransformation, TUid>();
      transformationHide.Uid = itemUid;
      return (BaseTransformation<TItem, TUid>) transformationHide;
    }

    protected override BaseTransformation<TItem, TUid> TransformationChange(
      TUid itemUid,
      string propertyName,
      object value,
      bool localizable = false)
    {
      EleWise.ELMA.Model.Transformations.Struct.TransformationChange<TItem, TTransformation, TUid> transformationChange = new EleWise.ELMA.Model.Transformations.Struct.TransformationChange<TItem, TTransformation, TUid>();
      transformationChange.Uid = itemUid;
      transformationChange.PropertyName = propertyName;
      transformationChange.Localizable = localizable;
      transformationChange.Value = value;
      return (BaseTransformation<TItem, TUid>) transformationChange;
    }

    protected Transformation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zlgygmWUa2ZE1iSk3p75() => Transformation<TItem, TTransformation, TUid>.aMSPnmWUpvFPSTw3QR37 == null;

    internal static object kMynBmWUD4JHbDIsQCog() => Transformation<TItem, TTransformation, TUid>.aMSPnmWUpvFPSTw3QR37;
  }
}

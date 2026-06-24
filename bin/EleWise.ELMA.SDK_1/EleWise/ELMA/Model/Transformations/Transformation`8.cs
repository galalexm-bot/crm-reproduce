// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Transformation`8
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations
{
  [Serializable]
  public abstract class Transformation<TItem, TTransformation, TUid, TNullUid, TAdd, TMove, THide, TChange> : 
    Transformation<TItem, TTransformation, TUid, TNullUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
    where TAdd : EleWise.ELMA.Model.Transformations.TransformationAdd<TItem, TTransformation, TUid, TNullUid>, new()
    where TMove : EleWise.ELMA.Model.Transformations.TransformationMove<TItem, TTransformation, TUid, TNullUid>, new()
    where THide : EleWise.ELMA.Model.Transformations.TransformationHide<TItem, TTransformation, TUid, TNullUid>, new()
    where TChange : EleWise.ELMA.Model.Transformations.TransformationChange<TItem, TTransformation, TUid, TNullUid>, new()
  {
    private static object yvmoTnWUvrutc5jl9YTT;

    protected override BaseTransformation<TItem, TUid> TransformationAdd(
      TUid itemUid,
      TItem item,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      TAdd add = new TAdd();
      add.Uid = itemUid;
      add.AfterItem = afterItem;
      add.BeforeItem = beforeItem;
      add.SetItem(item);
      return (BaseTransformation<TItem, TUid>) add;
    }

    protected override BaseTransformation<TItem, TUid> TransformationMove(
      TUid itemUid,
      TUid moveItemUid,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      TMove move = new TMove();
      move.Uid = itemUid;
      move.MoveItemUid = moveItemUid;
      move.AfterItem = afterItem;
      move.BeforeItem = beforeItem;
      return (BaseTransformation<TItem, TUid>) move;
    }

    protected override BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
    {
      THide hide = new THide();
      hide.Uid = itemUid;
      return (BaseTransformation<TItem, TUid>) hide;
    }

    protected override BaseTransformation<TItem, TUid> TransformationChange(
      TUid itemUid,
      string propertyName,
      object value,
      bool localizable = false)
    {
      TChange change = new TChange();
      change.Uid = itemUid;
      change.PropertyName = propertyName;
      change.Localizable = localizable;
      change.Value = value;
      return (BaseTransformation<TItem, TUid>) change;
    }

    protected Transformation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lwlh2YWU8AoQHvZmZEZN() => Transformation<TItem, TTransformation, TUid, TNullUid, TAdd, TMove, THide, TChange>.yvmoTnWUvrutc5jl9YTT == null;

    internal static object mKA8FSWUZQbFEGU7cPNR() => Transformation<TItem, TTransformation, TUid, TNullUid, TAdd, TMove, THide, TChange>.yvmoTnWUvrutc5jl9YTT;
  }
}

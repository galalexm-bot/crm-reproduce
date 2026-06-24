// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Class.Transformation`7
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations.Class
{
  [Serializable]
  public abstract class Transformation<TItem, TTransformation, TUid, TAdd, TMove, THide, TChange> : 
    Transformation<TItem, TTransformation, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid>, new()
    where TUid : class
    where TAdd : EleWise.ELMA.Model.Transformations.Class.TransformationAdd<TItem, TTransformation, TUid>, new()
    where TMove : EleWise.ELMA.Model.Transformations.Class.TransformationMove<TItem, TTransformation, TUid>, new()
    where THide : EleWise.ELMA.Model.Transformations.Class.TransformationHide<TItem, TTransformation, TUid>, new()
    where TChange : EleWise.ELMA.Model.Transformations.Class.TransformationChange<TItem, TTransformation, TUid>, new()
  {
    internal static object J1ZPL0WUcfjNu2M8U2xO;

    protected override BaseTransformation<TItem, TUid> TransformationAdd(
      TUid itemUid,
      TItem item,
      TUid afterItem = null,
      TUid beforeItem = null)
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
      TUid afterItem = null,
      TUid beforeItem = null)
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
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bmhXBqWUzMGnsVy3Y3Kk() => Transformation<TItem, TTransformation, TUid, TAdd, TMove, THide, TChange>.J1ZPL0WUcfjNu2M8U2xO == null;

    internal static object io8sYdWsFbxQeYK6j9VT() => Transformation<TItem, TTransformation, TUid, TAdd, TMove, THide, TChange>.J1ZPL0WUcfjNu2M8U2xO;
  }
}

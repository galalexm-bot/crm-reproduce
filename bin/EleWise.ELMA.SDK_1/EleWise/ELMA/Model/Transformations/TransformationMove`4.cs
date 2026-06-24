// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationMove`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EleWise.ELMA.Model.Transformations
{
  [DebuggerDisplay("NewContainerUid: {Uid}, MoveItemUid: {MoveItemUid}{AfterItem != null ? \", AfterItemUid : \" + AfterItem : \"\", nq}{BeforeItem != null ? \", BeforeItemUid : \" + BeforeItem : \"\", nq}", Type = "Move")]
  [DebuggerTypeProxy(typeof (TransformationMove<,,,>.DebugView))]
  [Serializable]
  public class TransformationMove<TItem, TTransformation, TUid, TNullUid> : 
    BaseTransformation<TItem, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    internal static object vfsrJOWU1j8ZctH1eE08;

    public TUid MoveItemUid { get; set; }

    public TNullUid BeforeItem { get; set; }

    public TNullUid AfterItem { get; set; }

    public override void Apply(TItem rootItem) => this.ApplyReturn(rootItem);

    public TItem ApplyReturn(TItem rootItem, TTransformation instance = null) => TransformationMove<TItem, TTransformation, TUid, TNullUid>.StaticApply(rootItem, this.Uid, this.MoveItemUid, this.BeforeItem, this.AfterItem, instance);

    public static TItem StaticApply(
      TItem rootItem,
      TUid Uid,
      TUid MoveItemUid,
      TNullUid BeforeItem,
      TNullUid AfterItem,
      TTransformation instance = null)
    {
      try
      {
        TTransformation t = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
        TItem obj1 = t.FindItem(rootItem, Uid);
        if ((object) obj1 == null)
          return default (TItem);
        TItem container;
        TItem subItem = t.FindItem(rootItem, MoveItemUid, out container);
        if ((object) subItem == null)
          return default (TItem);
        t.RemoveItem(container, subItem);
        if ((object) AfterItem != null)
        {
          TItem obj2 = ((IEnumerable<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).FirstOrDefault<TItem>((Func<TItem, bool>) (i => t.EqualsItems(i, AfterItem)));
          if ((object) obj2 != null)
          {
            int num = ((IList<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).IndexOf(obj2);
            t.InsertItem(obj1, num + 1, subItem);
            return subItem;
          }
        }
        if ((object) BeforeItem != null)
        {
          TItem obj3 = ((IEnumerable<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).FirstOrDefault<TItem>((Func<TItem, bool>) (i => t.EqualsItems(i, BeforeItem)));
          if ((object) obj3 != null)
          {
            int index = ((IList<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).IndexOf(obj3);
            t.InsertItem(obj1, index, subItem);
            return subItem;
          }
        }
        t.AddItem(obj1, subItem);
        return subItem;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex.Message, ex);
        return default (TItem);
      }
    }

    public TransformationMove()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ToYKSmWUN0FJQs8lHkEG() => TransformationMove<TItem, TTransformation, TUid, TNullUid>.vfsrJOWU1j8ZctH1eE08 == null;

    internal static object ooTXmDWU3L3YgPuLRqbo() => TransformationMove<TItem, TTransformation, TUid, TNullUid>.vfsrJOWU1j8ZctH1eE08;

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly TransformationMove<TItem, TTransformation, TUid, TNullUid> transformation;

      public DebugView(
        TransformationMove<TItem, TTransformation, TUid, TNullUid> transformation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.transformation = transformation;
      }

      public TUid NewContainerUid => this.transformation.Uid;

      public TUid MoveItemUid => this.transformation.MoveItemUid;

      public TNullUid BeforeItemUid => this.transformation.BeforeItem;

      public TNullUid AfterItemUid => this.transformation.AfterItem;
    }
  }
}

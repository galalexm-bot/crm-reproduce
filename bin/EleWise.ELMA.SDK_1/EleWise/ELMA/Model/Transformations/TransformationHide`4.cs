// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationHide`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Diagnostics;

namespace EleWise.ELMA.Model.Transformations
{
  [DebuggerTypeProxy(typeof (TransformationHide<,,,>.DebugView))]
  [DebuggerDisplay("ItemUid: {Uid}", Type = "Hide")]
  [Serializable]
  public class TransformationHide<TItem, TTransformation, TUid, TNullUid> : 
    BaseTransformation<TItem, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    internal static object Sb9bLsWU2K37rrTVHja3;

    public override void Apply(TItem rootItem) => this.ApplyReturn(rootItem);

    public TItem ApplyReturn(TItem rootItem, TTransformation instance = null) => TransformationHide<TItem, TTransformation, TUid, TNullUid>.StaticApply(rootItem, this.Uid, instance);

    public static TItem StaticApply(TItem rootItem, TUid Uid, TTransformation instance = null)
    {
      TTransformation transformation = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
      TItem container;
      TItem obj = transformation.FindItem(rootItem, Uid, out container);
      if ((object) obj != null)
        transformation.SetHide(container, obj, true);
      return obj;
    }

    public TransformationHide()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool wRAYVFWUerJRF0woSeKu() => TransformationHide<TItem, TTransformation, TUid, TNullUid>.Sb9bLsWU2K37rrTVHja3 == null;

    internal static object dZdXYVWUP23cOspytO9t() => TransformationHide<TItem, TTransformation, TUid, TNullUid>.Sb9bLsWU2K37rrTVHja3;

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly TransformationHide<TItem, TTransformation, TUid, TNullUid> transformation;

      public DebugView(
        TransformationHide<TItem, TTransformation, TUid, TNullUid> transformation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.transformation = transformation;
      }

      public TUid ItemUid => this.transformation.Uid;
    }
  }
}

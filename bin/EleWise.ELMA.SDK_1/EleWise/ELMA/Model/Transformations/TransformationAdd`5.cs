// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationAdd`5
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EleWise.ELMA.Model.Transformations
{
  /// <summary>Трансформация добавления</summary>
  /// <typeparam name="TItem">Тип трансформируемого бъекта</typeparam>
  /// <typeparam name="TTransformation"></typeparam>
  /// <typeparam name="TUid">Тип уникального идентификатора</typeparam>
  /// <typeparam name="TNullUid">Nullable тип уникального идентификатора (или тот же тип, если это класс)</typeparam>
  /// <typeparam name="TSaveItem">Тип сохраняемой модели (может совпадать с типом трансформируемого объекта)</typeparam>
  [DebuggerTypeProxy(typeof (TransformationAdd<,,,,>.DebugView))]
  [DebuggerDisplay("ContainerUid: {Uid}, Item: {Item}{AfterItem != null ? \", AfterItemUid : \" + AfterItem : \"\", nq}{BeforeItem != null ? \", BeforeItemUid : \" + BeforeItem : \"\", nq}", Type = "Add")]
  [Serializable]
  public abstract class TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> : 
    BaseTransformation<TItem, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    public TSaveItem Item;
    internal static object ghSo22WUueLqcSmHlHay;

    /// <summary>
    /// Возращается значение, сформированное из сохраняемого свойстыва (создается копия объекта, если типы одинаковые)
    /// </summary>
    protected internal abstract TItem GetItem();

    /// <summary>
    /// Устанавливает значение для сохраняемого свойства (создается копия объекта, если типы одинаковые)
    /// </summary>
    protected internal abstract void SetItem(TItem value);

    public TNullUid BeforeItem { get; set; }

    public TNullUid AfterItem { get; set; }

    public override void Apply(TItem rootItem) => this.ApplyReturn(rootItem);

    public TItem ApplyReturn(TItem rootItem, TTransformation instance = null) => TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem>.StaticApply(rootItem, this.Uid, this.GetItem(), this.BeforeItem, this.AfterItem, instance);

    /// <summary>Применяется непосредственно к Item (без клонирования)</summary>
    /// <param name="rootItem"></param>
    /// <param name="Uid"></param>
    /// <param name="Item"></param>
    /// <param name="BeforeItem"></param>
    /// <param name="AfterItem"></param>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static TItem StaticApply(
      TItem rootItem,
      TUid Uid,
      TItem Item,
      TNullUid BeforeItem,
      TNullUid AfterItem,
      TTransformation instance = null)
    {
      if ((object) Item == null)
        return default (TItem);
      TTransformation t = instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance;
      TItem obj1 = t.FindItem(rootItem, Uid);
      if ((object) obj1 == null)
        return default (TItem);
      TItem container;
      TItem subItem = t.FindItem(rootItem, Item, out container);
      if ((object) container != null && (object) subItem != null)
        t.DeleteItem(container, subItem);
      if ((object) AfterItem != null)
      {
        TItem obj2 = ((IEnumerable<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).FirstOrDefault<TItem>((Func<TItem, bool>) (i => t.EqualsItems(i, AfterItem)));
        if ((object) obj2 != null)
        {
          int num = ((IList<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).IndexOf(obj2);
          t.InsertItem(obj1, num + 1, Item);
          return Item;
        }
      }
      if ((object) BeforeItem != null)
      {
        TItem obj3 = ((IEnumerable<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).FirstOrDefault<TItem>((Func<TItem, bool>) (i => t.EqualsItems(i, BeforeItem)));
        if ((object) obj3 != null)
        {
          int index = ((IList<TItem>) ((object) t.GetSubItems(obj1) ?? (object) new TItem[0])).IndexOf(obj3);
          t.InsertItem(obj1, index, Item);
          return Item;
        }
      }
      t.AddItem(obj1, Item);
      return Item;
    }

    protected TransformationAdd()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RVSwSIWUIh81MXWxDRdT() => TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem>.ghSo22WUueLqcSmHlHay == null;

    internal static object UJh2dGWUVZdW4ZsjbdKb() => TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem>.ghSo22WUueLqcSmHlHay;

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> transformation;

      public DebugView(
        TransformationAdd<TItem, TTransformation, TUid, TNullUid, TSaveItem> transformation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.transformation = transformation;
      }

      public TUid ContainerUid => this.transformation.Uid;

      public TItem Item => this.transformation.GetItem();

      public TNullUid BeforeItemUid => this.transformation.BeforeItem;

      public TNullUid AfterItemUid => this.transformation.AfterItem;
    }
  }
}

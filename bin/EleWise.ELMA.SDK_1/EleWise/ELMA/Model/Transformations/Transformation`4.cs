// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Transformation`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.Transformations
{
  [DebuggerDisplay("Count = {Items.Count}")]
  [DebuggerTypeProxy(typeof (Transformation<,,,>.DebugView))]
  [Serializable]
  public abstract class Transformation<TItem, TTransformation, TUid, TNullUid> : 
    BaseTransformation<TItem, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    private static TTransformation _instance;
    private List<BaseTransformation<TItem, TUid>> items;
    internal static object d5rAgUWUfaQyEB3X0WWY;

    public static TTransformation Instance => Transformation<TItem, TTransformation, TUid, TNullUid>._instance ?? (Transformation<TItem, TTransformation, TUid, TNullUid>._instance = new TTransformation());

    public List<BaseTransformation<TItem, TUid>> Items => this.items ?? (this.items = new List<BaseTransformation<TItem, TUid>>());

    public override void Apply(TItem rootItem)
    {
      if (this.items == null)
        return;
      foreach (BaseTransformation<TItem, TUid> baseTransformation in this.items.Where<BaseTransformation<TItem, TUid>>((Func<BaseTransformation<TItem, TUid>, bool>) (transformation => transformation != null)))
        baseTransformation.Apply(rootItem);
    }

    public static TTransformation CreateTransformation(TItem item, TItem originalItem) => (TTransformation) Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationCreate(item, originalItem);

    public static BaseTransformation<TItem, TUid> Add(
      TUid itemUid,
      TItem item,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      return Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationAdd(itemUid, item, afterItem, beforeItem);
    }

    public static BaseTransformation<TItem, TUid> Move(
      TUid itemUid,
      TUid moveItemUid,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      return Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationMove(itemUid, moveItemUid, afterItem, beforeItem);
    }

    public static BaseTransformation<TItem, TUid> Hide(TUid itemUid) => Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationHide(itemUid);

    public static BaseTransformation<TItem, TUid> SetPropertyValue(
      TUid itemUid,
      string propertyName,
      object value)
    {
      return Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationChange(itemUid, propertyName, value, false);
    }

    public static BaseTransformation<TItem, TUid> SetPropertyValue<T>(
      TUid itemUid,
      Expression<Func<TItem, T>> property,
      T value)
    {
      return Transformation<TItem, TTransformation, TUid, TNullUid>.SetPropertyValue<TItem, T>(itemUid, property, value);
    }

    public static BaseTransformation<TItem, TUid> SetPropertyValue<TItem2, T>(
      TUid itemUid,
      Expression<Func<TItem2, T>> property,
      T value)
      where TItem2 : TItem
    {
      MemberExpression memberExpression = property != null ? LinqUtils.GetMemberExpression((LambdaExpression) property) : (MemberExpression) null;
      return Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.TransformationChange(itemUid, typeof (TItem2), LinqUtils.FullNameOf<TItem2, T>(property), memberExpression?.Member, (object) value);
    }

    protected internal abstract IList<TItem> GetSubItems(TItem item);

    protected internal abstract TUid GetUid(TItem item);

    /// <summary>
    /// Если по общей логике элементы можно скрывать, то метод должен возвращать "скрытость" элемента.<br />
    /// Если элементы можно только добавлять/удалять, то метод должен возвращать false.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    protected internal abstract bool IsHide(TItem item);

    /// <summary>
    /// В зависимости от общей логики - скрыть, либо удалить элемент из родительского.
    /// </summary>
    /// <param name="item"></param>
    /// <param name="hide"></param>
    protected internal abstract void SetHide(TItem parentItem, TItem item, bool hide = true);

    /// <summary>Создать копию элемента без дочерних элементов.</summary>
    /// <param name="item"></param>
    /// <returns></returns>
    protected internal abstract TItem CreateCopy(TItem item);

    /// <summary>Создать полную копию элемента</summary>
    /// <param name="item"></param>
    /// <returns></returns>
    protected internal abstract TItem Clone(TItem item);

    protected internal virtual void DeleteItem(TItem item, TItem subItem) => this.GetSubItems(item).Remove(subItem);

    protected internal virtual void RemoveItem(TItem item, TItem subItem) => this.GetSubItems(item).Remove(subItem);

    protected internal virtual void AddItem(TItem item, TItem subItem) => this.GetSubItems(item).Add(subItem);

    protected internal virtual void InsertItem(TItem item, int index, TItem subItem) => this.GetSubItems(item).Insert(index, subItem);

    protected virtual BaseTransformation<TItem, TUid> TransformationCreate(
      TItem item,
      TItem originalItem)
    {
      TTransformation transformation = new TTransformation();
      transformation.Uid = transformation.GetUid(originalItem);
      transformation.Items.AddRange(transformation.AddMoveTransformations(item, originalItem));
      transformation.Items.AddRange(transformation.HideTransformations(item, originalItem));
      transformation.Items.AddRange(transformation.ChangeTransformations(item, originalItem, originalItem));
      return (BaseTransformation<TItem, TUid>) (transformation.Items.Any<BaseTransformation<TItem, TUid>>() ? transformation : default (TTransformation));
    }

    protected virtual BaseTransformation<TItem, TUid> TransformationAdd(
      TUid itemUid,
      TItem item,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      EleWise.ELMA.Model.Transformations.TransformationAdd<TItem, TTransformation, TUid, TNullUid> transformationAdd = new EleWise.ELMA.Model.Transformations.TransformationAdd<TItem, TTransformation, TUid, TNullUid>();
      transformationAdd.Uid = itemUid;
      transformationAdd.AfterItem = afterItem;
      transformationAdd.BeforeItem = beforeItem;
      transformationAdd.SetItem(item);
      return (BaseTransformation<TItem, TUid>) transformationAdd;
    }

    protected virtual BaseTransformation<TItem, TUid> TransformationMove(
      TUid itemUid,
      TUid moveItemUid,
      TNullUid afterItem = null,
      TNullUid beforeItem = null)
    {
      EleWise.ELMA.Model.Transformations.TransformationMove<TItem, TTransformation, TUid, TNullUid> transformationMove = new EleWise.ELMA.Model.Transformations.TransformationMove<TItem, TTransformation, TUid, TNullUid>();
      transformationMove.Uid = itemUid;
      transformationMove.MoveItemUid = moveItemUid;
      transformationMove.AfterItem = afterItem;
      transformationMove.BeforeItem = beforeItem;
      return (BaseTransformation<TItem, TUid>) transformationMove;
    }

    protected virtual BaseTransformation<TItem, TUid> TransformationHide(TUid itemUid)
    {
      EleWise.ELMA.Model.Transformations.TransformationHide<TItem, TTransformation, TUid, TNullUid> transformationHide = new EleWise.ELMA.Model.Transformations.TransformationHide<TItem, TTransformation, TUid, TNullUid>();
      transformationHide.Uid = itemUid;
      return (BaseTransformation<TItem, TUid>) transformationHide;
    }

    protected virtual BaseTransformation<TItem, TUid> TransformationChange(
      TUid itemUid,
      string propertyName,
      object value,
      bool localizable = false)
    {
      EleWise.ELMA.Model.Transformations.TransformationChange<TItem, TTransformation, TUid, TNullUid> transformationChange = new EleWise.ELMA.Model.Transformations.TransformationChange<TItem, TTransformation, TUid, TNullUid>();
      transformationChange.Uid = itemUid;
      transformationChange.PropertyName = propertyName;
      transformationChange.Localizable = localizable;
      transformationChange.Value = value;
      return (BaseTransformation<TItem, TUid>) transformationChange;
    }

    protected virtual BaseTransformation<TItem, TUid> TransformationChange(
      TUid itemUid,
      Type type,
      string propertyName,
      object value,
      bool localizable = false)
    {
      return this.TransformationChange(itemUid, propertyName, value, localizable);
    }

    protected BaseTransformation<TItem, TUid> TransformationChange(
      TUid uid,
      string propName,
      MemberInfo member,
      object value)
    {
      return this.TransformationChange(uid, propName, value, member != (MemberInfo) null && member.IsDefined(typeof (LocalizableAttribute), true));
    }

    protected BaseTransformation<TItem, TUid> TransformationChange(
      TUid uid,
      Type type,
      string propName,
      MemberInfo member,
      object value)
    {
      return this.TransformationChange(uid, type, propName, value, member != (MemberInfo) null && member.IsDefined(typeof (LocalizableAttribute), true));
    }

    protected abstract TNullUid ConvertUid(TUid uid);

    protected internal virtual TItem FindItem(TItem viewItem, TItem item) => this.FindItem(viewItem, this.GetUid(item));

    protected internal virtual TItem FindItem(TItem viewItem, TItem item, out TItem container) => this.FindItem(viewItem, this.GetUid(item), out container);

    protected internal virtual TItem FindItem(TItem viewItem, TUid itemUid) => this.FindItem(viewItem, itemUid, out TItem _);

    protected internal virtual TItem FindItem(TItem viewItem, TUid itemUid, out TItem container)
    {
      container = default (TItem);
      if (this.EqualsItems(viewItem, this.ConvertUid(itemUid)))
        return viewItem;
      IList<TItem> subItems = this.GetSubItems(viewItem);
      if (subItems == null)
        return default (TItem);
      foreach (TItem viewItem1 in (IEnumerable<TItem>) subItems)
      {
        TItem obj = this.FindItem(viewItem1, itemUid, out container);
        if ((object) obj != null)
        {
          if ((object) container == null)
            container = viewItem;
          return obj;
        }
      }
      return default (TItem);
    }

    protected IEnumerable<BaseTransformation<TItem, TUid>> AddMoveTransformations(
      TItem viewItem,
      TItem originalItem)
    {
      if ((object) viewItem == null || (object) originalItem == null)
        return (IEnumerable<BaseTransformation<TItem, TUid>>) new TTransformation[0];
      IList<TItem> localItems = (IList<TItem>) ((object) this.GetSubItems(viewItem) ?? (object) new TItem[0]);
      Dictionary<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>> subItems = localItems.ToDictionary((Func<TItem, TItem>) (item => item), item =>
      {
        TItem container;
        TItem obj = this.FindItem(originalItem, item, out container);
        // ISSUE: object of a compiler-generated type is created
        return new \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>(obj, (object) obj == null || this.IsHide(obj), container);
      });
      Func<TItem, bool, TNullUid> previousItemUid = (Func<TItem, bool, TNullUid>) ((item, skipNewItems) =>
      {
        int num = localItems.IndexOf(item);
        while (num > 0 & skipNewItems && (object) subItems[localItems[num - 1]].item2 == null)
          --num;
        return num <= 0 ? default (TNullUid) : this.ConvertUid(this.GetUid(localItems[num - 1]));
      });
      Func<TItem, bool, TNullUid> nextItemUid = (Func<TItem, bool, TNullUid>) ((item, skipMovedItems) =>
      {
        int num = localItems.IndexOf(item);
        while (num != -1 && num < localItems.Count - 1 && ((object) subItems[localItems[num + 1]].item2 == null || skipMovedItems && (object) subItems[localItems[num + 1]].item2 != null && (!this.EqualsItems(viewItem, subItems[localItems[num + 1]].container) || !this.EqualsItems(localItems[num + 1], subItems[localItems[num + 1]].item2))))
          ++num;
        return num == -1 || num >= localItems.Count - 1 ? default (TNullUid) : this.ConvertUid(this.GetUid(localItems[num + 1]));
      });
      TItem obj1 = this.FindItem(originalItem, viewItem);
      IList<TItem> originalrootItems = (object) obj1 != null ? this.GetSubItems(obj1) : (IList<TItem>) null;
      originalrootItems = (IList<TItem>) ((object) originalrootItems ?? (object) new TItem[0]);
      TItem[] hideItems = (object) obj1 != null ? originalrootItems.Where<TItem>((Func<TItem, bool>) (item => localItems.All<TItem>((Func<TItem, bool>) (i => !this.EqualsItems(i, item))))).ToArray<TItem>() : new TItem[0];
      List<TItem> movedItems = new List<TItem>();
      List<TItem> movedOriginalItems = new List<TItem>();
      Func<TItem, TItem, bool> previousItemUidTest = (Func<TItem, TItem, bool>) ((item1, item2) =>
      {
        int num1 = localItems.IndexOf(item1);
        bool flag = false;
        while (num1 > 0 && movedItems.Contains(localItems[num1 - 1]))
        {
          --num1;
          flag = true;
        }
        TItem v1 = num1 > 0 ? localItems[num1 - 1] : default (TItem);
        if ((object) v1 == null & flag)
          return false;
        int num2 = originalrootItems.IndexOf(item2);
        while (num2 > 0 && (((IEnumerable<TItem>) hideItems).Contains<TItem>(originalrootItems[num2 - 1]) || movedOriginalItems.Contains(originalrootItems[num2 - 1])))
          --num2;
        TItem v2 = num2 > 0 ? originalrootItems[num2 - 1] : default (TItem);
        return !this.EqualsItems(v1, v2);
      });
      TUid viewItemUid = this.GetUid(viewItem);
      return (IEnumerable<BaseTransformation<TItem, TUid>>) subItems.Where<KeyValuePair<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>>>(t =>
      {
        if ((object) t.Value.item2 == null)
          return false;
        return !this.EqualsItems(viewItem, t.Value.container) || previousItemUidTest(t.Key, t.Value.item2);
      }).Select<KeyValuePair<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>>, BaseTransformation<TItem, TUid>>(t =>
      {
        movedItems.Add(t.Key);
        movedOriginalItems.Add(t.Value.item2);
        return this.TransformationMove(viewItemUid, this.GetUid(t.Key), previousItemUid(t.Key, true), nextItemUid(t.Key, true));
      }).Union<BaseTransformation<TItem, TUid>>(subItems.Where<KeyValuePair<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>>>(t => t.Value.isHide).Select<KeyValuePair<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>>, BaseTransformation<TItem, TUid>>(t =>
      {
        movedItems.Add(t.Key);
        return this.TransformationAdd(viewItemUid, t.Key, previousItemUid(t.Key, false), nextItemUid(t.Key, false));
      })).Union<BaseTransformation<TItem, TUid>>(subItems.SelectMany<KeyValuePair<TItem, \u003C\u003Ef__AnonymousType9<TItem, bool, TItem>>, BaseTransformation<TItem, TUid>>(t => this.AddMoveTransformations(t.Key, originalItem))).ToArray<BaseTransformation<TItem, TUid>>();
    }

    protected IEnumerable<BaseTransformation<TItem, TUid>> HideTransformations(
      TItem viewItem,
      TItem originalItem)
    {
      if ((object) viewItem == null || (object) originalItem == null)
        return (IEnumerable<BaseTransformation<TItem, TUid>>) new TTransformation[0];
      // ISSUE: object of a compiler-generated type is created
      \u003C\u003Ef__AnonymousType10<TItem, TItem>[] array = ((IEnumerable<TItem>) ((object) this.GetSubItems(originalItem) ?? (object) new TItem[0])).Where<TItem>((Func<TItem, bool>) (item => !this.IsHide(item))).Select(item => new \u003C\u003Ef__AnonymousType10<TItem, TItem>(item, this.FindItem(viewItem, item))).ToArray();
      return (IEnumerable<BaseTransformation<TItem, TUid>>) array.Where(t => (object) t.item2 == null || this.IsHide(t.item2)).Select(t => this.TransformationHide(this.GetUid(t.item))).Union<BaseTransformation<TItem, TUid>>(array.SelectMany(t => this.HideTransformations(viewItem, t.item))).ToArray<BaseTransformation<TItem, TUid>>();
    }

    private IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> GetPropertyGroupings(
      PropertyInfo prop)
    {
      object[] customAttributes = prop.GetCustomAttributes(typeof (ChangeablePropertyAttribute), true);
      return !((IEnumerable<object>) customAttributes).Any<object>() ? (IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>) null : (IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>) Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.Create(customAttributes.Cast<ChangeablePropertyAttribute>().SelectMany<ChangeablePropertyAttribute, string>((Func<ChangeablePropertyAttribute, IEnumerable<string>>) (a =>
      {
        string[] subProperties = a.SubProperties;
        if (subProperties != null)
          return (IEnumerable<string>) subProperties;
        return (IEnumerable<string>) new string[1]{ "" };
      })).ToList<string>().Select<string, string[]>((Func<string, string[]>) (p => p.Split('.'))).ToArray<string[]>());
    }

    protected virtual IEnumerable<BaseTransformation<TItem, TUid>> ChangeTransformations(
      TItem viewItem,
      TItem originalItem,
      TItem originalItemRoot)
    {
      IEnumerable<BaseTransformation<TItem, TUid>> first = (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[0];
      if ((object) originalItem != null)
      {
        Type type = viewItem.GetType();
        first = ((IEnumerable<PropertyInfo>) type.GetProperties()).SelectMany<PropertyInfo, BaseTransformation<TItem, TUid>>((Func<PropertyInfo, IEnumerable<BaseTransformation<TItem, TUid>>>) (prop =>
        {
          IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> propertyGroupings = this.GetPropertyGroupings(prop);
          if (propertyGroupings == null)
            return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[0];
          object obj = prop.GetValue((object) viewItem, (object[]) null);
          object originalObj = prop.GetValue((object) originalItem, (object[]) null);
          return this.PropertyChangeTransformations(this.GetUid(viewItem), type, prop.Name, (MemberInfo) prop, obj, originalObj, propertyGroupings);
        }));
      }
      return (IEnumerable<BaseTransformation<TItem, TUid>>) first.Union<BaseTransformation<TItem, TUid>>(((IEnumerable<TItem>) ((object) this.GetSubItems(viewItem) ?? (object) new TItem[0])).SelectMany<TItem, BaseTransformation<TItem, TUid>>((Func<TItem, IEnumerable<BaseTransformation<TItem, TUid>>>) (item => this.ChangeTransformations(item, this.FindItem(originalItemRoot, item), originalItemRoot)))).ToArray<BaseTransformation<TItem, TUid>>();
    }

    protected internal virtual bool EqualsItems(TItem v1, TNullUid v2) => (object) v1 != null ? this.EqualsItems(this.ConvertUid(this.GetUid(v1)), v2) : (object) v2 == null;

    protected internal virtual bool EqualsItems(TItem v1, TItem v2) => (object) v1 == null || (object) v2 == null ? (object) v1 == (object) v2 : this.EqualsItems(this.ConvertUid(this.GetUid(v1)), this.ConvertUid(this.GetUid(v2)));

    protected internal virtual bool EqualsItems(TNullUid v1, TNullUid v2) => Transformation<TItem, TTransformation, TUid, TNullUid>.Equals((object) v1, (object) v2);

    private new static bool Equals(object v1, object v2)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (v1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return v2 == null;
label_5:
      return v1.Equals(v2);
    }

    private IEnumerable<BaseTransformation<TItem, TUid>> PropertyChangeTransformations(
      TUid uid,
      Type type,
      string propName,
      MemberInfo member,
      object obj,
      object originalObj,
      IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> propertyGrouping)
    {
      if (obj == null && originalObj == null)
        return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[0];
      if (obj == null || originalObj == null)
        return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[1]
        {
          this.TransformationChange(uid, type, propName, member, obj)
        };
      IPropertiesContainer propertiesContainer = obj as IPropertiesContainer;
      if (propertiesContainer == null)
        return (IEnumerable<BaseTransformation<TItem, TUid>>) propertyGrouping.SelectMany<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping, BaseTransformation<TItem, TUid>>((Func<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping, IEnumerable<BaseTransformation<TItem, TUid>>>) (pg =>
        {
          if (string.IsNullOrEmpty(pg.Property))
          {
            if (Transformation<TItem, TTransformation, TUid, TNullUid>.Equals(obj, originalObj))
              return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[0];
            return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[1]
            {
              this.TransformationChange(uid, type, propName, member, obj)
            };
          }
          PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty(pg.Property);
          return !(reflectionProperty == (PropertyInfo) null) ? this.PropertyChangeTransformations(uid, type, propName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761) + pg.Property, (MemberInfo) reflectionProperty, reflectionProperty.GetValue(obj, (object[]) null), reflectionProperty.GetValue(originalObj, (object[]) null), (IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>) pg.SubProperties) : Enumerable.Empty<BaseTransformation<TItem, TUid>>();
        })).ToArray<BaseTransformation<TItem, TUid>>();
      IPropertiesContainer originalPropertiesContainer = (IPropertiesContainer) originalObj;
      return (IEnumerable<BaseTransformation<TItem, TUid>>) propertiesContainer.GetProperties().Union<string>(originalPropertiesContainer.GetProperties()).SelectMany<string, BaseTransformation<TItem, TUid>>((Func<string, IEnumerable<BaseTransformation<TItem, TUid>>>) (prop =>
      {
        object v1 = propertiesContainer.GetProperties().Contains<string>(prop) ? propertiesContainer.GetPropertyValue(prop, (object[]) null) : (object) TransformationChangeRemoveValue.Instance;
        object propertyValue = originalPropertiesContainer.GetPropertyValue(prop, (object[]) null);
        if (Transformation<TItem, TTransformation, TUid, TNullUid>.Equals(v1, propertyValue))
          return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[0];
        return (IEnumerable<BaseTransformation<TItem, TUid>>) new BaseTransformation<TItem, TUid>[1]
        {
          this.TransformationChange(uid, type, propName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345417984) + prop, (MemberInfo) null, v1)
        };
      })).ToArray<BaseTransformation<TItem, TUid>>();
    }

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public override IEnumerable<string> GetLocalizableStrings()
    {
      List<string> allStrings = new List<string>();
      IEnumerable<string> localizableStrings1 = base.GetLocalizableStrings();
      if (localizableStrings1 != null)
        allStrings.AddRange(localizableStrings1);
      foreach (BaseTransformation<TItem, TUid> baseTransformation in this.items)
      {
        IEnumerable<string> localizableStrings2 = baseTransformation.GetLocalizableStrings();
        if (localizableStrings2 != null)
        {
          foreach (string str in localizableStrings2.Where<string>((Func<string, bool>) (s => !allStrings.Contains(s))))
            allStrings.Add(str);
        }
      }
      return (IEnumerable<string>) allStrings;
    }

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public override void ApplyLocalization()
    {
      int num1 = 2;
      List<BaseTransformation<TItem, TUid>>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            enumerator = this.items.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            base.ApplyLocalization();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_13:
      return;
label_9:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_7;
          default:
            goto label_5;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
        goto label_3;
label_7:
        enumerator.Current.ApplyLocalization();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    protected Transformation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BeGPE9WUQUY6SytGAnml() => Transformation<TItem, TTransformation, TUid, TNullUid>.d5rAgUWUfaQyEB3X0WWY == null;

    internal static object KsP0xuWUCQr1ceqAyDv7() => Transformation<TItem, TTransformation, TUid, TNullUid>.d5rAgUWUfaQyEB3X0WWY;

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly Transformation<TItem, TTransformation, TUid, TNullUid> transformation;
      private static object f56G0dCBISF6bNHYUdTP;

      public DebugView(
        Transformation<TItem, TTransformation, TUid, TNullUid> transformation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.transformation = transformation;
      }

      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      public BaseTransformation<TItem, TUid>[] Items => this.transformation.Items.ToArray();

      internal static bool M0vs5LCBVGtNkgXbbqeT() => Transformation<TItem, TTransformation, TUid, TNullUid>.DebugView.f56G0dCBISF6bNHYUdTP == null;

      internal static object h727IaCBSQyUZB8tOjA5() => Transformation<TItem, TTransformation, TUid, TNullUid>.DebugView.f56G0dCBISF6bNHYUdTP;
    }

    private class PropertyGrouping
    {
      internal static object Ghn4ugCBiLfdhjYJXdJ4;

      public string Property
      {
        get => this.\u003CProperty\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CProperty\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

      public Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping[] SubProperties
      {
        get => this.\u003CSubProperties\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CSubProperties\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

      public static Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping[] Create(
        string[][] props)
      {
        string[][] source1 = props;
        // ISSUE: reference to a compiler-generated field
        Func<string[], bool> func1 = Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.\u003C\u003Ec.\u003C\u003E9__8_0;
        Func<string[], bool> predicate;
        if (func1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.\u003C\u003Ec.\u003C\u003E9__8_0 = predicate = (Func<string[], bool>) (p =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  if (p == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            return p.Length == 0;
label_3:
            return true;
          });
        }
        else
          goto label_6;
label_2:
        IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> first = ((IEnumerable<string[]>) source1).Where<string[]>(predicate).Select<string[], Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>((Func<string[], Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>) (p => new Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping()
        {
          Property = (string) null,
          SubProperties = (Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping[]) null
        }));
        IEnumerable<IGrouping<string, string[]>> source2 = ((IEnumerable<string[]>) props).Where<string[]>((Func<string[], bool>) (p =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                if (p == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          return p.Length != 0;
label_3:
          return false;
        })).GroupBy<string[], string, string[]>((Func<string[], string>) (p => ((IEnumerable<string>) p).FirstOrDefault<string>()), (Func<string[], string[]>) (p => ((IEnumerable<string>) p).Skip<string>(1).ToArray<string>()));
        // ISSUE: reference to a compiler-generated field
        Func<IGrouping<string, string[]>, Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> func2 = Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.\u003C\u003Ec.\u003C\u003E9__8_5;
        Func<IGrouping<string, string[]>, Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> selector;
        if (func2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.\u003C\u003Ec.\u003C\u003E9__8_5 = selector = (Func<IGrouping<string, string[]>, Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>) (g => new Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping()
          {
            Property = g.Key,
            SubProperties = Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.Create(g.ToArray<string[]>())
          });
        }
        else
          goto label_3;
label_5:
        IEnumerable<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping> second = source2.Select<IGrouping<string, string[]>, Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>(selector);
        return first.Union<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>(second).ToArray<Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping>();
label_3:
        selector = func2;
        goto label_5;
label_6:
        predicate = func1;
        goto label_2;
      }

      public PropertyGrouping()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool g3d9QnCBRUFWxmu23upT() => Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.Ghn4ugCBiLfdhjYJXdJ4 == null;

      internal static object jfq5DGCBqofa0nWf7dDn() => Transformation<TItem, TTransformation, TUid, TNullUid>.PropertyGrouping.Ghn4ugCBiLfdhjYJXdJ4;
    }
  }
}

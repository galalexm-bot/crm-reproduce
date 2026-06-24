// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.RootViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Корневой элемент представления</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_RootViewItem), "DisplayName")]
  [DebuggerTypeProxy(typeof (RootViewItem.DebugView))]
  [Serializable]
  public abstract class RootViewItem : ViewItem, IHideEmptyViewItem, IReadOnlyViewItem
  {
    private readonly ListViewItem items;
    /// <summary>Используется только для события items.ClearedItems</summary>
    private IEnumerable<ViewItem> oldItems;
    internal static RootViewItem bDQ0oio3Er7IpD2vgC1V;

    /// <summary>
    /// Уникальный идентификатор метаданных сущности, для которой строится представление
    /// </summary>
    public Guid? MetadataUid { get; set; }

    /// <summary>Проверка необходимости сериализации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMetadataUid()
    {
      int num = 1;
      Guid? metadataUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataUid = this.MetadataUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return metadataUid.HasValue;
    }

    /// <summary>Элементы представления</summary>
    [NotNull]
    [XmlArrayItem("ViewItem")]
    [XmlArrayItem("RootViewItem", typeof (RootViewItem))]
    public ListViewItem Items => this.items;

    /// <summary>Проверка необходимости сериализации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeItems() => RootViewItem.mUWqHDo3CoQoyNt5GQUZ((object) this.Items) > 0;

    /// <summary>
    /// Не показываеть элемент, если в нем нет ни одного видимого элемента
    /// </summary>
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [Obsolete("Use HideEmptySettings instead", true)]
    public bool HideEmpty
    {
      get => false;
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
              this.HideEmptySettings = value ? HideEmptyEnum.HideEmpty : HideEmptyEnum.ShowEmpty;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>
    /// Не показываеть элемент, если в нем нет ни одного видимого элемента
    /// </summary>
    [XmlElement("HideEmpty")]
    [DefaultValue(HideEmptyEnum.Inherit)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public HideEmptyEnum HideEmptySettings
    {
      get => this.\u003CHideEmptySettings\u003Ek__BackingField;
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
              this.\u003CHideEmptySettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    /// <summary>
    /// Указывает, что все внутренние элементы только для чтения
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public virtual bool? ReadOnly { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.RootViewItem.ReadOnly" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.RootViewItem.ReadOnly" /></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeReadOnly()
    {
      int num = 1;
      bool? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            nullable = this.ReadOnly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return nullable.HasValue;
    }

    /// <summary>
    /// Получение текущего значения для элемента, нужно ли скрывать пустой (рекурсивно из родительских элементов)
    /// </summary>
    /// <param name="parent"></param>
    /// <returns></returns>
    public virtual bool IsHideEmpty(RootViewItem parent = null)
    {
      int num1 = 2;
      RootViewItem rootViewItem1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          RootViewItem rootViewItem2;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (this.HideEmptySettings == HideEmptyEnum.Inherit)
              {
                rootViewItem2 = parent;
                if (rootViewItem2 == null)
                {
                  num2 = 4;
                  continue;
                }
                break;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_15;
            case 4:
              rootViewItem2 = this.Parent;
              break;
            case 5:
              goto label_13;
            default:
label_6:
              rootViewItem1 = parent;
              if (rootViewItem1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 5 : 5;
                continue;
              }
              goto label_14;
          }
          if (rootViewItem2 != null)
            goto label_6;
          else
            break;
        }
        num1 = 3;
      }
label_3:
      return this.HideEmptySettings == HideEmptyEnum.HideEmpty;
label_13:
      rootViewItem1 = this.Parent;
label_14:
      return rootViewItem1.IsHideEmpty((RootViewItem) null);
label_15:
      return false;
    }

    /// <summary>Создать преобразование</summary>
    /// <param name="originalItem"></param>
    /// <returns></returns>
    public FormViewItemTransformation CreateTransformation(RootViewItem originalItem) => (FormViewItemTransformation) RootViewItem.eQdp2Yo3vlFWBdlqYJBW((object) this, (object) originalItem);

    public ViewItem FindItem(Guid itemUid) => RootViewItem.FindItem((ViewItem) this, itemUid);

    public T FindItem<T>(Guid itemUid) where T : ViewItem => RootViewItem.FindItem((ViewItem) this, itemUid) as T;

    public ViewItem FindItem(Func<ViewItem, bool> condition) => RootViewItem.FindItem((ViewItem) this, condition);

    public T FindItem<T>(Func<T, bool> condition) where T : ViewItem => RootViewItem.FindItem((ViewItem) this, (Func<ViewItem, bool>) (item =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(item is T))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return condition((T) item);
label_3:
      return false;
    })) as T;

    public IEnumerable<ViewItem> GetAllItems(bool ignoreHide = true) => RootViewItem.FindItems((object) this, ignoreHide, (Func<ViewItem, bool>) null, (Func<ViewItem, bool>) null);

    public IEnumerable<ViewItem> FindItems(
      bool ignoreHide = true,
      Func<ViewItem, bool> itemCondition = null,
      Func<ViewItem, bool> deepCondition = null)
    {
      return RootViewItem.FindItems((object) this, ignoreHide, itemCondition, deepCondition);
    }

    public IEnumerable<PropertyViewItem> GetAllProperties(bool ignoreHide = true) => RootViewItem.GetAllProperties((object) this, ignoreHide);

    public void RemoveHiddenViewItems() => RootViewItem.LEGFrCo38iCbL9OYYxWe((object) this);

    /// <summary>
    /// Полностью скопировать из другого элемента представления (включая подчиненные элементы)
    /// </summary>
    /// <param name="viewItem"></param>
    public override void FullCopyFrom(ViewItem viewItem)
    {
      int num1 = 1;
      ViewItem viewItem1;
      List<ViewItem>.Enumerator enumerator;
      RootViewItem rootViewItem;
      while (true)
      {
        switch (num1)
        {
          case 1:
            viewItem1 = ClassSerializationHelper.CloneObjectByXml<ViewItem>(viewItem);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            rootViewItem = viewItem1 as RootViewItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 6;
            continue;
          case 3:
            enumerator = ((IEnumerable<ViewItem>) RootViewItem.t2tSmPo3Ze1WkfGitAo8((object) rootViewItem)).ToList<ViewItem>().GetEnumerator();
            num1 = 5;
            continue;
          case 4:
            this.items.Clear();
            num1 = 3;
            continue;
          case 5:
            goto label_4;
          case 6:
            if (rootViewItem != null)
            {
              num1 = 4;
              continue;
            }
            goto label_12;
          case 7:
            goto label_16;
          default:
            this.CopyFrom(viewItem1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
            continue;
        }
      }
label_16:
      return;
label_4:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_11;
label_5:
        ViewItem current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_10;
            case 2:
              this.items.Add(current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_2:
        return;
label_8:
        current = enumerator.Current;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        {
          num2 = 2;
          goto label_5;
        }
        else
          goto label_5;
label_11:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_12:;
    }

    /// <inheritdoc />
    protected internal override void SetReadOnly() => base.SetReadOnly();

    /// <inheritdoc />
    protected internal override void SetReadOnly(bool value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SetReadOnly(value, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            base.SetReadOnly(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Сделать элемент представления доступным "только для чтения"
    /// </summary>
    /// <param name="value">Значение доступности для редактирования</param>
    /// <param name="recursive">Рукурсивно изменить свойство "только для чтения" для дочерних элементов</param>
    protected internal virtual void SetReadOnly(bool value, bool recursive)
    {
      int num1 = 1;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (recursive)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_15;
          case 2:
            goto label_16;
          case 3:
            goto label_5;
          default:
            enumerator = this.Items.GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_16:
      return;
label_15:
      return;
label_5:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_6:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            break;
          default:
            goto label_9;
        }
label_7:
        enumerator.Current.SetReadOnly(value);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
        goto label_6;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
        else
          goto label_17;
label_14:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_17:
        enumerator.Dispose();
        num3 = 2;
        goto label_14;
      }
    }

    /// <summary>Проверка Исользуется ли элемент только для чтения.</summary>
    public virtual bool IsReadOnly()
    {
      int num = 1;
      RootViewItem parent;
      while (true)
      {
        switch (num)
        {
          case 1:
            parent = this.Parent;
            if (parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_5:
      return RootViewItem.cby3dbo3ucdy79maGJyZ((object) parent);
    }

    /// <inheritdoc />
    protected internal override void SetVisible(bool visible)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RootViewItem.iPUjMEo3IjZ789rMlw0O((object) this, visible, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            base.SetVisible(visible);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Сделать элемент представления "видимым"</summary>
    /// <param name="visible">Значение видимости</param>
    /// <param name="recursive">Рукурсивно изменить видимость для дочерних элементов</param>
    protected internal virtual void SetVisible(bool visible, bool recursive)
    {
      int num1 = 2;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            if (recursive)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            }
            goto label_13;
          case 3:
            goto label_18;
          default:
            goto label_5;
        }
      }
label_18:
      return;
label_13:
      return;
label_5:
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_12;
label_7:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_11;
        }
label_9:
        RootViewItem.aqXiJFo3VEdIVvA3NupI((object) enumerator.Current, visible);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        {
          num2 = 0;
          goto label_7;
        }
        else
          goto label_7;
label_12:
        num2 = 2;
        goto label_7;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    /// <summary>Отображать ли данный элемент</summary>
    public virtual bool IsVisible()
    {
      int num = 1;
      RootViewItem parent;
      while (true)
      {
        switch (num)
        {
          case 1:
            parent = this.Parent;
            if (parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return true;
label_5:
      return RootViewItem.Fr3tTeo3iYQpfdOP64RF((object) parent);
    }

    protected RootViewItem()
    {
      RootViewItem.QsHU4go3Rpi83UPaeaaE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ListViewItem listViewItem = new ListViewItem((ViewItem) this);
            listViewItem.ClearingItems = new EventHandler(this.ClearingItems);
            listViewItem.ClearedItems = new EventHandler(this.ClearedItems);
            listViewItem.AddingItem = new EventHandler<EventedListEventArgs<ViewItem>>(this.AddingItem);
            listViewItem.AddedItem = new EventHandler<EventedListEventArgs<ViewItem>>(this.AddedItem);
            listViewItem.RemovingItem = new EventHandler<EventedListEventArgs<ViewItem>>(this.RemovingItem);
            listViewItem.RemovedItem = new EventHandler<EventedListEventArgs<ViewItem>>(this.RemovedItem);
            this.items = listViewItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void ClearingItems(object sender, EventArgs eventArgs)
    {
      int num1 = 3;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
label_3:
            this.oldItems = (IEnumerable<ViewItem>) this.items.ToArray<ViewItem>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
label_7:
              if (RootViewItem.IJutxco3KsBAaQOipffv((object) enumerator))
                goto label_6;
              else
                goto label_8;
label_5:
              int num2;
              switch (num2)
              {
                case 1:
                  break;
                case 2:
                  goto label_7;
                default:
                  goto label_3;
              }
label_6:
              RootViewItem.PBIOyGo3qdbmoDRaeEdk((object) enumerator.Current, (object) this);
              num2 = 2;
              goto label_5;
label_8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              goto label_5;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              else
                goto label_14;
label_11:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_14:
              RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              {
                num3 = 1;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 3:
            enumerator = this.Items.GetEnumerator();
            num1 = 2;
            continue;
          default:
            goto label_12;
        }
      }
label_13:
      return;
label_12:;
    }

    private void ClearedItems(object sender, EventArgs eventArgs)
    {
      int num1 = 1;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.oldItems.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
label_5:
        if (RootViewItem.IJutxco3KsBAaQOipffv((object) enumerator))
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_5;
          case 2:
            return;
          default:
            goto label_7;
        }
label_6:
        num2 = 2;
        goto label_4;
label_7:
        RootViewItem.eJFsINo3XMAaR1Su1X3K((object) enumerator.Current, (object) this);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
        else
          goto label_14;
label_11:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    private void AddingItem(
      object sender,
      EventedListEventArgs<ViewItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnAdding(this);
    }

    private void AddedItem(
      object sender,
      EventedListEventArgs<ViewItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnAdded(this);
    }

    private void RemovingItem(
      object sender,
      EventedListEventArgs<ViewItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnRemoving(this);
    }

    private void RemovedItem(
      object sender,
      EventedListEventArgs<ViewItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnRemoved(this);
    }

    public override void OnAdding(RootViewItem parent)
    {
      int num1 = 3;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 3:
            base.OnAdding(parent);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_15:
      return;
label_3:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_9;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_8;
        }
label_6:
        RootViewItem.tOlAPSo3TdjmsuX8jVLE((object) enumerator.Current, (object) parent);
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        {
          num2 = 2;
          goto label_5;
        }
        else
          goto label_5;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    public override void OnAdded(RootViewItem parent)
    {
      int num1 = 2;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            enumerator = this.Items.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            base.OnAdded(parent);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_14:
      return;
label_9:
      return;
label_2:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_8;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            break;
          default:
            goto label_7;
        }
label_5:
        enumerator.Current.OnAdded(parent);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
        goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    public override void OnRemoving(RootViewItem parent)
    {
      int num1 = 2;
      while (true)
      {
        IEnumerator<ViewItem> enumerator;
        switch (num1)
        {
          case 1:
            try
            {
label_6:
              if (RootViewItem.IJutxco3KsBAaQOipffv((object) enumerator))
                goto label_8;
              else
                goto label_7;
label_5:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_8;
                case 2:
                  goto label_6;
                default:
                  goto label_3;
              }
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              goto label_5;
label_8:
              RootViewItem.PBIOyGo3qdbmoDRaeEdk((object) enumerator.Current, (object) parent);
              num2 = 2;
              goto label_5;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              else
                goto label_13;
label_11:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_13:
              RootViewItem.Rl9bFIo3SII2LovqKbJx((object) enumerator);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
              {
                num3 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 2:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_12;
        }
label_3:
        base.OnRemoving(parent);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 3;
      }
label_12:;
    }

    public override void OnRemoved(RootViewItem parent)
    {
      int num1 = 3;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
label_16:
            base.OnRemoved(parent);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
label_4:
              if (enumerator.MoveNext())
                goto label_6;
              else
                goto label_5;
label_3:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_6;
                case 2:
                  goto label_16;
                default:
                  goto label_4;
              }
label_5:
              num2 = 2;
              goto label_3;
label_6:
              RootViewItem.eJFsINo3XMAaR1Su1X3K((object) enumerator.Current, (object) parent);
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
              {
                num2 = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_15;
                    default:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_15:;
            }
          case 3:
            enumerator = this.Items.GetEnumerator();
            num1 = 2;
            continue;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:;
    }

    /// <summary>
    /// Получить список свойств, значения которых будут копироваться при вызове метода <see cref="M:EleWise.ELMA.Model.Views.ViewItem.CopyFrom(EleWise.ELMA.Model.Views.ViewItem)" />
    /// </summary>
    /// <returns></returns>
    protected override IEnumerable<PropertyInfo> GetPropertiesForCopy() => base.GetPropertiesForCopy().Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => RootViewItem.\u003C\u003Ec.L3TlO2C8iBokhZseMGvt(RootViewItem.\u003C\u003Ec.U1jxLvC8VayYnISXQg2T((object) p), RootViewItem.\u003C\u003Ec.gDxE6GC8ShrtvhnAT2T1(1052221104 - 768835541 ^ 283554617))));

    internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid) => RootViewItem.FindItem(viewItem, itemUid, out RootViewItem _);

    internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid, out RootViewItem container)
    {
      int num = 1;
      Guid itemUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            itemUid1 = itemUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return RootViewItem.FindItem(viewItem, (Func<ViewItem, bool>) (item => RootViewItem.\u003C\u003Ec__DisplayClass54_0.zKS2CXC8n2mdYwS2RAaQ(RootViewItem.\u003C\u003Ec__DisplayClass54_0.t5q0uiC8koQhRb4nKWOv((object) item), itemUid1)), out container);
    }

    internal static ViewItem FindItem(ViewItem viewItem, Func<ViewItem, bool> condition) => RootViewItem.FindItem(viewItem, condition, out RootViewItem _);

    internal static ViewItem FindItem(
      ViewItem viewItem,
      Func<ViewItem, bool> condition,
      out RootViewItem container)
    {
      container = (RootViewItem) null;
      if (condition == null)
        return (ViewItem) null;
      if (condition(viewItem))
        return viewItem;
      if (viewItem is RootViewItem rootViewItem && rootViewItem.Items != null)
      {
        foreach (ViewItem viewItem1 in (EventedList<ViewItem>) rootViewItem.Items)
        {
          ViewItem viewItem2 = RootViewItem.FindItem(viewItem1, condition, out container);
          if (viewItem2 != null)
          {
            if (container == null)
              container = rootViewItem;
            return viewItem2;
          }
        }
      }
      return (ViewItem) null;
    }

    private static IEnumerable<ViewItem> FindItems(
      object viewItem,
      bool ignoreHide,
      Func<ViewItem, bool> itemCondition,
      Func<ViewItem, bool> deepCondition)
    {
      return !(viewItem is RootViewItem rootViewItem) ? (IEnumerable<ViewItem>) new ViewItem[0] : rootViewItem.Items.Where<ViewItem>((Func<ViewItem, bool>) (i =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ignoreHide)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return !RootViewItem.\u003C\u003Ec__DisplayClass57_0.y6BljdC81N9KNMlUK5MV((object) i);
label_5:
        return true;
      })).SelectMany<ViewItem, ViewItem>((Func<ViewItem, IEnumerable<ViewItem>>) (i => Enumerable.Empty<ViewItem>().If<ViewItem>(itemCondition == null || itemCondition(i), (Func<IEnumerable<ViewItem>, IEnumerable<ViewItem>>) (enumerable => enumerable.Concat<ViewItem>((IEnumerable<ViewItem>) new ViewItem[1]
      {
        i
      }))).If<ViewItem>(deepCondition == null || deepCondition(i), (Func<IEnumerable<ViewItem>, IEnumerable<ViewItem>>) (enumerable => enumerable.Concat<ViewItem>(RootViewItem.FindItems((object) i, ignoreHide, itemCondition, deepCondition))))));
    }

    private static IEnumerable<PropertyViewItem> GetAllProperties(object viewItem, bool ignoreHide) => !(viewItem is RootViewItem rootViewItem) ? (IEnumerable<PropertyViewItem>) new PropertyViewItem[0] : rootViewItem.Items.Where<ViewItem>((Func<ViewItem, bool>) (i =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ignoreHide)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      return !RootViewItem.\u003C\u003Ec__DisplayClass58_0.WIt9RGC860SjXXdUeBwc((object) i);
label_3:
      return true;
    })).SelectMany<ViewItem, PropertyViewItem>((Func<ViewItem, IEnumerable<PropertyViewItem>>) (i =>
    {
      if (!(i is PropertyViewItem))
        return RootViewItem.GetAllProperties((object) i, ignoreHide);
      return (IEnumerable<PropertyViewItem>) new PropertyViewItem[1]
      {
        (PropertyViewItem) i
      };
    }));

    public static void RemoveHiddenViewItems(RootViewItem rootViewItem)
    {
      int num1 = 3;
      RootViewItem rootViewItem1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ListViewItem items = rootViewItem1.items;
            // ISSUE: reference to a compiler-generated field
            Func<ViewItem, bool> func = RootViewItem.\u003C\u003Ec.\u003C\u003E9__59_0;
            Func<ViewItem, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              RootViewItem.\u003C\u003Ec.\u003C\u003E9__59_0 = predicate = (Func<ViewItem, bool>) (i => RootViewItem.\u003C\u003Ec.CGBRJeC8RUjHGVhVkvlW((object) i));
            }
            else
              goto label_9;
label_8:
            items.Where<ViewItem>(predicate).ToList<ViewItem>().ForEach((Action<ViewItem>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    rootViewItem1.items.Remove(i);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
label_9:
            predicate = func;
            goto label_8;
          case 2:
            rootViewItem1 = rootViewItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_6;
          default:
            ((IEnumerable) RootViewItem.t2tSmPo3Ze1WkfGitAo8((object) rootViewItem1)).OfType<RootViewItem>().Each<RootViewItem>(new Action<RootViewItem>(RootViewItem.RemoveHiddenViewItems));
            num1 = 4;
            continue;
        }
      }
label_6:;
    }

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public override IEnumerable<string> GetLocalizableStrings()
    {
      List<string> localizableStrings1 = new List<string>();
      IEnumerable<string> localizableStrings2 = base.GetLocalizableStrings();
      if (localizableStrings2 != null)
        localizableStrings1.AddRange(localizableStrings2);
      if (this.items != null)
      {
        foreach (ViewItem viewItem in (EventedList<ViewItem>) this.items)
        {
          IEnumerable<string> localizableStrings3 = viewItem.GetLocalizableStrings();
          if (localizableStrings3 != null)
          {
            foreach (string str in localizableStrings3)
            {
              if (str != null && !localizableStrings1.Contains(str))
                localizableStrings1.Add(str);
            }
          }
        }
      }
      return (IEnumerable<string>) localizableStrings1;
    }

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public override void ApplyLocalization()
    {
      int num1 = 5;
      IEnumerator<ViewItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_17;
          case 3:
            goto label_15;
          case 4:
            if (this.items == null)
            {
              num1 = 3;
              continue;
            }
            break;
          case 5:
            base.ApplyLocalization();
            num1 = 4;
            continue;
        }
        enumerator = this.items.GetEnumerator();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
      }
label_17:
      return;
label_15:
      return;
label_6:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_10;
label_7:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_9;
        }
label_8:
        enumerator.Current.ApplyLocalization();
        num2 = 2;
        goto label_7;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
        goto label_7;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
        else
          goto label_16;
label_14:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_16:
        enumerator.Dispose();
        num3 = 2;
        goto label_14;
      }
    }

    internal static bool UDZZIho3fjQtqeI41Shi() => RootViewItem.bDQ0oio3Er7IpD2vgC1V == null;

    internal static RootViewItem up0kqEo3QhjXEW01EZeT() => RootViewItem.bDQ0oio3Er7IpD2vgC1V;

    internal static int mUWqHDo3CoQoyNt5GQUZ([In] object obj0) => ((EventedList<ViewItem>) obj0).Count;

    internal static object eQdp2Yo3vlFWBdlqYJBW([In] object obj0, [In] object obj1) => (object) TransformationViewItem.CreateTransformation((ViewItem) obj0, (ViewItem) obj1);

    internal static void LEGFrCo38iCbL9OYYxWe([In] object obj0) => RootViewItem.RemoveHiddenViewItems((RootViewItem) obj0);

    internal static object t2tSmPo3Ze1WkfGitAo8([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static bool cby3dbo3ucdy79maGJyZ([In] object obj0) => ((RootViewItem) obj0).IsReadOnly();

    internal static void iPUjMEo3IjZ789rMlw0O([In] object obj0, bool visible, bool recursive) => ((RootViewItem) obj0).SetVisible(visible, recursive);

    internal static void aqXiJFo3VEdIVvA3NupI([In] object obj0, bool visible) => ((ViewItem) obj0).SetVisible(visible);

    internal static void Rl9bFIo3SII2LovqKbJx([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool Fr3tTeo3iYQpfdOP64RF([In] object obj0) => ((RootViewItem) obj0).IsVisible();

    internal static void QsHU4go3Rpi83UPaeaaE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void PBIOyGo3qdbmoDRaeEdk([In] object obj0, [In] object obj1) => ((ViewItem) obj0).OnRemoving((RootViewItem) obj1);

    internal static bool IJutxco3KsBAaQOipffv([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void eJFsINo3XMAaR1Su1X3K([In] object obj0, [In] object obj1) => ((ViewItem) obj0).OnRemoved((RootViewItem) obj1);

    internal static void tOlAPSo3TdjmsuX8jVLE([In] object obj0, [In] object obj1) => ((ViewItem) obj0).OnAdding((RootViewItem) obj1);

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      public readonly RootViewItem viewItem;
      private static RootViewItem.DebugView Bnds3PC8bSujfrpjnLKT;

      public DebugView(RootViewItem viewItem)
      {
        RootViewItem.DebugView.h1ieynC8ERfTt0hk1ZlN();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.viewItemDebugView = new ViewItem.DebugView((ViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            default:
              this.viewItem = viewItem;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
              continue;
          }
        }
label_2:;
      }

      [DebuggerDisplay("{\"Count = \" + _Items.Count, nq}", Name = "Items")]
      public ListViewItem _Items => (ListViewItem) RootViewItem.DebugView.KDX8F6C8fZfxcj6sF1A5((object) this.viewItem);

      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      public ViewItem.DebugView viewItemDebugView
      {
        get => this.\u003CviewItemDebugView\u003Ek__BackingField;
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
                this.\u003CviewItemDebugView\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

      internal static void h1ieynC8ERfTt0hk1ZlN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool gTnD08C8h5fiObvr5XfE() => RootViewItem.DebugView.Bnds3PC8bSujfrpjnLKT == null;

      internal static RootViewItem.DebugView fxUoAUC8GtXXQUesVSq4() => RootViewItem.DebugView.Bnds3PC8bSujfrpjnLKT;

      internal static object KDX8F6C8fZfxcj6sF1A5([In] object obj0) => (object) ((RootViewItem) obj0).Items;
    }
  }
}

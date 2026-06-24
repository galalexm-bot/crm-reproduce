// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.XmlSerializers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Элемент представления</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_ViewItem), "DisplayName")]
  [Component]
  [DebuggerTypeProxy(typeof (ViewItem.DebugView))]
  [XmlUnknownTypesSupport]
  [Serializable]
  public abstract class ViewItem : IXsiType, IXsiRoot
  {
    internal Guid? uid;
    private static readonly ConcurrentDictionary<string, object> CompiledProperties;
    private static ViewItem QuoKito36f9JlPbwZX82;

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<string> GetLocalizableStrings() => LocalizableAttributeHelper.GetStrings((object) this);

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public virtual void ApplyLocalization() => ViewItem.icKIOTo37CgDZW2uN4SZ((object) this);

    /// <summary>Имя</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента представления</summary>
    [XmlElement("Uid")]
    public virtual Guid Uid
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.uid = new Guid?(ViewItem.OrOEawo3x2oZKss0EcDl());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 2:
              if (!this.uid.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_5:
        return this.uid.Value;
      }
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
              this.uid = new Guid?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUid() => this.uid.HasValue;

    /// <summary>Не показывать элемент представления</summary>
    [DefaultValue(false)]
    [XmlElement("Hide")]
    public virtual bool Hide
    {
      get => this.\u003CHide\u003Ek__BackingField;
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
              this.\u003CHide\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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
    /// Скрывать элемент представления в определённом режиме отображения
    /// </summary>
    [XmlElement("HideMode")]
    [DefaultValue(ViewItemHideMode.None)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ViewItemHideMode HideMode
    {
      get => this.\u003CHideMode\u003Ek__BackingField;
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
              this.\u003CHideMode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    /// <summary>Динамически вычисляемые свойства</summary>
    [EleWise.ELMA.Globalization.Localizable]
    public List<ComputedValue> DynamicProperties { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeDynamicProperties() => ViewItem.lM2d6Ko30qZQPefNdynq((object) this.DynamicProperties) > 0;

    [XmlIgnore]
    public RootViewItem Parent
    {
      get => this.\u003CParent\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public ILayoutViewItem ParentLayout => this.FindParent<ILayoutViewItem>((ViewItem) this.Parent);

    [XmlIgnore]
    public FormViewItem FormViewItem => this.FindParent<FormViewItem>(this);

    [XmlIgnore]
    public ViewItem Root
    {
      get
      {
        int num = 1;
        ViewItem root;
        while (true)
        {
          switch (num)
          {
            case 1:
              root = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 3:
            case 4:
              root = (ViewItem) root.Parent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
              continue;
            case 5:
              goto label_3;
            default:
              if (ViewItem.d9vNCto3mQ1X1H9etXu5((object) root) != null)
              {
                num = 4;
                continue;
              }
              goto label_3;
          }
        }
label_3:
        return root;
      }
    }

    [XmlIgnore]
    public ViewItem TransformatedViewItem
    {
      get => this.\u003CTransformatedViewItem\u003Ek__BackingField;
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
              this.\u003CTransformatedViewItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    public ViewItem Transformate(ViewItemTransformation transformation)
    {
      int num = 3;
      ViewItem rootItem;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            goto label_2;
          case 2:
            ViewItem.oGShuAo3ySXhYBx7jCd4((object) rootItem, (object) this);
            num = 4;
            continue;
          case 3:
            rootItem = ClassSerializationHelper.CloneObjectByXml<ViewItem>(this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          case 4:
            if (transformation == null)
            {
              num = 5;
              continue;
            }
            break;
        }
        transformation.Apply(rootItem);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
      }
label_2:
      return rootItem;
    }

    public bool IsUid(Guid uid)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              if (ViewItem.WQeVEWo3MHAsIgqU33DY((object) this) == uid)
              {
                num2 = 3;
                continue;
              }
              goto label_8;
            default:
              goto label_5;
          }
        }
label_8:
        if (this.TransformatedViewItem == null)
          num1 = 2;
        else
          break;
      }
label_5:
      return ViewItem.RUEtASo3JeFJ4CKYij0B((object) this.TransformatedViewItem, uid);
label_6:
      return false;
label_7:
      return true;
    }

    /// <summary>Валидация при вставке в родительский ViewItem</summary>
    /// <param name="viewType">Тип представления</param>
    /// <param name="parentViewItem">Родительский ViewItem</param>
    /// <returns></returns>
    public virtual bool IsValid(ViewType viewType, ViewItem parentViewItem) => false;

    /// <summary>Валидация при добавлении дочернего ViewItem</summary>
    /// <param name="childViewItem">Дочерний ViewItem</param>
    /// <returns></returns>
    public virtual bool IsChildValid(ViewItem childViewItem) => false;

    public virtual void OnAdding(RootViewItem parent)
    {
    }

    public virtual void OnAdded(RootViewItem parent)
    {
    }

    public virtual void OnRemoving(RootViewItem parent)
    {
    }

    public virtual void OnRemoved(RootViewItem parent)
    {
    }

    /// <summary>Сделать элемент представления "видимым"</summary>
    /// <param name="visible">Значение видимости</param>
    protected internal virtual void SetVisible(bool visible)
    {
    }

    /// <summary>
    /// Полностью скопировать из другого элемента представления (включая подчиненные элементы)
    /// </summary>
    /// <param name="viewItem"></param>
    public virtual void FullCopyFrom(ViewItem viewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ViewItem.N1F71Oo39q2potfMtJxU((object) this, (object) viewItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Скопировать значения свойств из другого элемента представления
    /// </summary>
    /// <param name="viewItem"></param>
    public virtual void CopyFrom(ViewItem viewItem)
    {
      int num1 = 1;
      List<PropertyInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            if (viewItem != null)
            {
              enumerator = this.GetPropertiesForCopy().ToList<PropertyInfo>().GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_4;
          default:
            goto label_21;
        }
      }
label_25:
      return;
label_2:
      return;
label_21:
      return;
label_4:
      try
      {
label_15:
        if (enumerator.MoveNext())
          goto label_13;
        else
          goto label_16;
label_5:
        PropertyInfo current;
        PropertyInfo property;
        object obj;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              current.SetValue((object) this, obj, (object[]) null);
              num2 = 7;
              continue;
            case 2:
              if (ViewItem.KIsopKo3r6KAk4rIfBUh((object) property))
              {
                num2 = 9;
                continue;
              }
              goto label_15;
            case 3:
            case 7:
            case 10:
              goto label_15;
            case 4:
              obj = ViewItem.DKK6q3o35GQPaIM8k2vh((object) property, (object) viewItem, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_10;
            case 6:
              goto label_13;
            case 8:
              property = viewItem.GetType().GetProperty((string) ViewItem.jBt1IRo3dXP1xVpd5FOf((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 9:
              if (ViewItem.gmXYQ5o3gEA74ujnMpgU((object) current).IsAssignableFrom(property.PropertyType))
              {
                num2 = 4;
                continue;
              }
              goto label_15;
            case 11:
              if (!ViewItem.P0ul1Qo3liItHl2UNg6m((object) current))
              {
                num2 = 10;
                continue;
              }
              goto case 2;
            default:
              if (!(property != (PropertyInfo) null))
              {
                num2 = 3;
                continue;
              }
              goto case 11;
          }
        }
label_10:
        return;
label_13:
        current = enumerator.Current;
        num2 = 8;
        goto label_5;
label_16:
        num2 = 5;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public virtual void ReplacePropertyUid(Dictionary<Guid, Guid> ReplaceContextVar)
    {
    }

    /// <summary>
    /// Клонировать элемент представления. Метод НЕ копирует список вложенных предсталвений
    /// </summary>
    /// <param name="copyUid">Копировать ли значение свойства Uid</param>
    /// <returns></returns>
    public ViewItem CreateCopy(bool copyUid)
    {
      int num = 4;
      ViewItem copy;
      while (true)
      {
        switch (num)
        {
          case 1:
            ViewItem.dsTJFJo3LoJ8p5USM89O((object) copy, ViewItem.WQeVEWo3MHAsIgqU33DY((object) this));
            num = 5;
            continue;
          case 2:
          case 5:
            goto label_7;
          case 3:
            ViewItem.N1F71Oo39q2potfMtJxU((object) copy, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 4:
            copy = (ViewItem) ViewItem.TsjjmVo3Y6GpruR5GPBE(ViewItem.DgGua4o3jb3bMQgEeMeH((object) this));
            num = 3;
            continue;
          default:
            if (!copyUid)
            {
              num = 2;
              continue;
            }
            goto case 1;
        }
      }
label_7:
      return copy;
    }

    /// <summary>Создать полную копию элемента представления</summary>
    /// <returns></returns>
    public ViewItem Clone() => ClassSerializationHelper.CloneObjectByXml<ViewItem>(this);

    /// <summary>
    /// Инициализировать новый элемент представления (инициализировать уникальный идентификатор и имя)
    /// </summary>
    /// <param name="parent">Родительский элемент. Если не задан, то имя генерироваться не будет</param>
    public virtual void InitNew(ViewItem parent)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        string str1;
        List<string> otherItemNames;
        int num3;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              num3 = 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 6 : 8;
              continue;
            case 2:
              this.Name = (string) ViewItem.gL2OLIopWRJWo1KxWasn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289855604), (object) ViewItem.WQeVEWo3MHAsIgqU33DY((object) this).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822942128)));
              num2 = 10;
              continue;
            case 3:
              ViewItem.dsTJFJo3LoJ8p5USM89O((object) this, ViewItem.OrOEawo3x2oZKss0EcDl());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 6 : 16;
              continue;
            case 4:
            case 7:
              str2 = (string) ViewItem.iG1CZmopFQ0GRflZnjum((object) str1, (object) num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 9 : 5;
              continue;
            case 5:
              otherItemNames = ViewItem.GetOtherItemNames((object) this, ViewItem.tdtXRdo3cL6IQKnYgBUj((object) parent));
              num2 = 15;
              continue;
            case 6:
            case 16:
              if (parent != null)
              {
                num2 = 11;
                continue;
              }
              goto label_8;
            case 8:
            case 14:
              if (num3 <= 1000000)
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 9:
              if (!otherItemNames.Contains((string) ViewItem.Do5mqxopBmN5IZre8cdW((object) str2)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 17 : 16;
                continue;
              }
              goto label_12;
            case 10:
              goto label_23;
            case 11:
              if (ViewItem.SZ3nRio3U6rFoGKF1JPE((object) this.Name))
              {
                num2 = 5;
                continue;
              }
              goto label_4;
            case 12:
              goto label_11;
            case 13:
              if (ViewItem.SZ3nRio3U6rFoGKF1JPE((object) this.Name))
              {
                if (!ViewItem.xMuU7vo3smW3NKg8jfvm(ViewItem.WQeVEWo3MHAsIgqU33DY((object) this), Guid.Empty))
                {
                  num2 = 6;
                  continue;
                }
                goto case 3;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 12 : 9;
                continue;
              }
            case 15:
              str1 = (string) ViewItem.OUb48To3zZBASyZnXZN4((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
              continue;
            case 17:
              this.Name = str2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_12:
        ++num3;
        num1 = 14;
      }
label_9:
      return;
label_23:
      return;
label_11:
      return;
label_3:
      return;
label_8:
      return;
label_4:;
    }

    /// <summary>
    /// Проверить, можно ли задать для данного элемента указанное имя
    /// </summary>
    /// <param name="name">Новое имя элемента</param>
    /// <param name="validationError">Ошибки, если имя неверно</param>
    public virtual bool IsNameValid(string name, out string validationError) => this.IsNameValid(name, (ViewItem) null, out validationError);

    /// <summary>
    /// Проверить, можно ли задать для данного элемента указанное имя
    /// </summary>
    /// <param name="name">Новое имя элемента</param>
    /// <param name="parent">Родительский элемент</param>
    /// <param name="validationError">Ошибки, если имя неверно</param>
    public virtual bool IsNameValid(string name, ViewItem parent, out string validationError)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            validationError = (string) ViewItem.Is6Xapopb9BUfiObmOiv(ViewItem.lIvLSCopoWtUB3AA1bpY(92412609 - 1050237057 ^ -957699148));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
          case 3:
            if (!ViewItem.GetOtherItemNames((object) this, parent != null ? ViewItem.tdtXRdo3cL6IQKnYgBUj((object) parent) : (object) this.Root).Contains((string) ViewItem.Do5mqxopBmN5IZre8cdW((object) name)))
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 4:
            goto label_8;
          case 5:
            if (!ViewItem.SZ3nRio3U6rFoGKF1JPE((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 0;
              continue;
            }
            goto case 2;
          case 6:
            validationError = string.Empty;
            num = 5;
            continue;
          case 7:
            validationError = (string) ViewItem.Is6Xapopb9BUfiObmOiv(ViewItem.lIvLSCopoWtUB3AA1bpY(1012087039 ^ 1011962581));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return false;
label_8:
      return true;
label_9:
      return false;
    }

    public override string ToString()
    {
      int num = 1;
      string name;
      while (true)
      {
        switch (num)
        {
          case 1:
            name = this.Name;
            if (name == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return name;
label_5:
      return string.Empty;
    }

    protected ViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.DynamicProperties = new List<ComputedValue>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Сделать элемент представления доступным "только для чтения"
    /// </summary>
    protected internal virtual void SetReadOnly()
    {
    }

    /// <summary>
    /// Сделать элемент представления доступным "только для чтения"
    /// </summary>
    /// <param name="value">Значение доступности для редактирования</param>
    protected internal virtual void SetReadOnly(bool value)
    {
    }

    protected virtual string GetDefaultName()
    {
      int num = 1;
      string defaultName;
      while (true)
      {
        switch (num)
        {
          case 1:
            defaultName = (string) ViewItem.jBt1IRo3dXP1xVpd5FOf((object) ViewItem.DgGua4o3jb3bMQgEeMeH((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            if (defaultName.EndsWith((string) ViewItem.lIvLSCopoWtUB3AA1bpY(-1290212282 ^ -644262414 ^ 1787004722)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 1;
              continue;
            }
            goto label_2;
          case 3:
          case 4:
            goto label_2;
          case 5:
            goto label_3;
          default:
            // ISSUE: type reference
            if (!ViewItem.lRo4h3opGCObA4SvRGVw(this.GetType(), ViewItem.DmRsN3ophsuiOovVNYp4(__typeref (ViewItem))))
            {
              num = 3;
              continue;
            }
            goto case 2;
        }
      }
label_2:
      return defaultName;
label_3:
      return (string) ViewItem.nvVtKMopfM1stwydrkbb((object) defaultName, 0, ViewItem.ErAu54opE17CxlBgaYRb((object) defaultName) - ((string) ViewItem.lIvLSCopoWtUB3AA1bpY(--1867379187 ^ 1867501429)).Length);
    }

    protected virtual IEnumerable<PropertyInfo> GetPropertiesForCopy() => ((IEnumerable<PropertyInfo>) this.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ViewItem.\u003C\u003Ec.vD8J08C8slcTVCAwh9vT(ViewItem.\u003C\u003Ec.wHMVfqC8Lev92xI11rTL((object) p), ViewItem.\u003C\u003Ec.zQujvoC8UEd4Vi0Ql4a6(-398663332 ^ -398684466));
label_5:
      return false;
    }));

    private static Func<T, object> Compile<T>(Expression<Func<T, object>> prop)
    {
      string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461504481), (object) typeof (T).AssemblyQualifiedName, (object) prop.ToString());
      object obj;
      if (ViewItem.CompiledProperties.TryGetValue(key, out obj))
        return (Func<T, object>) obj;
      Func<T, object> func = prop.Compile();
      ViewItem.CompiledProperties[key] = (object) func;
      return func;
    }

    private static List<string> GetOtherItemNames(object thisViewItem, object root)
    {
      ViewItem thisViewItem1 = (ViewItem) thisViewItem;
      return (root is RootViewItem rootViewItem ? (IEnumerable<ViewItem>) rootViewItem.GetAllItems(false).Where<ViewItem>((Func<ViewItem, bool>) (i => i != thisViewItem1)).ToArray<ViewItem>() : (IEnumerable<ViewItem>) new ViewItem[0]).Select<ViewItem, string>((Func<ViewItem, string>) (i =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (i.Name != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return string.Empty;
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (string) ViewItem.\u003C\u003Ec.Y3oJONC8zldfk0Rp5Ndv(ViewItem.\u003C\u003Ec.bQY2gJC8cfqa0qqNFAny((object) i));
      })).ToList<string>();
    }

    private T FindParent<T>(ViewItem startItem) where T : class
    {
      ViewItem parent = startItem;
      while (true)
      {
        switch (parent)
        {
          case null:
          case T _:
            goto label_3;
          default:
            parent = (ViewItem) parent.Parent;
            continue;
        }
      }
label_3:
      return parent as T;
    }

    static ViewItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ViewItem.WeXwpNopQm9iYgSZW3yc();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ViewItem.CompiledProperties = new ConcurrentDictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void icKIOTo37CgDZW2uN4SZ([In] object obj0) => LocalizableAttributeHelper.Localize(obj0);

    internal static bool TFDrXdo3HTlW4ugvMUtR() => ViewItem.QuoKito36f9JlPbwZX82 == null;

    internal static ViewItem uE3spLo3A5uQhtCOhicT() => ViewItem.QuoKito36f9JlPbwZX82;

    internal static Guid OrOEawo3x2oZKss0EcDl() => Guid.NewGuid();

    internal static int lM2d6Ko30qZQPefNdynq([In] object obj0) => ((List<ComputedValue>) obj0).Count;

    internal static object d9vNCto3mQ1X1H9etXu5([In] object obj0) => (object) ((ViewItem) obj0).Parent;

    internal static void oGShuAo3ySXhYBx7jCd4([In] object obj0, [In] object obj1) => ((ViewItem) obj0).TransformatedViewItem = (ViewItem) obj1;

    internal static Guid WQeVEWo3MHAsIgqU33DY([In] object obj0) => ((ViewItem) obj0).Uid;

    internal static bool RUEtASo3JeFJ4CKYij0B([In] object obj0, Guid uid) => ((ViewItem) obj0).IsUid(uid);

    internal static void N1F71Oo39q2potfMtJxU([In] object obj0, [In] object obj1) => ((ViewItem) obj0).CopyFrom((ViewItem) obj1);

    internal static object jBt1IRo3dXP1xVpd5FOf([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool P0ul1Qo3liItHl2UNg6m([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static bool KIsopKo3r6KAk4rIfBUh([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static Type gmXYQ5o3gEA74ujnMpgU([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object DKK6q3o35GQPaIM8k2vh([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static Type DgGua4o3jb3bMQgEeMeH([In] object obj0) => obj0.GetType();

    internal static object TsjjmVo3Y6GpruR5GPBE([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void dsTJFJo3LoJ8p5USM89O([In] object obj0, Guid value) => ((ViewItem) obj0).Uid = value;

    internal static bool SZ3nRio3U6rFoGKF1JPE([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool xMuU7vo3smW3NKg8jfvm([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object tdtXRdo3cL6IQKnYgBUj([In] object obj0) => (object) ((ViewItem) obj0).Root;

    internal static object OUb48To3zZBASyZnXZN4([In] object obj0) => (object) ((ViewItem) obj0).GetDefaultName();

    internal static object iG1CZmopFQ0GRflZnjum([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object Do5mqxopBmN5IZre8cdW([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object gL2OLIopWRJWo1KxWasn([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object lIvLSCopoWtUB3AA1bpY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Is6Xapopb9BUfiObmOiv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type DmRsN3ophsuiOovVNYp4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool lRo4h3opGCObA4SvRGVw([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static int ErAu54opE17CxlBgaYRb([In] object obj0) => ((string) obj0).Length;

    internal static object nvVtKMopfM1stwydrkbb([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static void WeXwpNopQm9iYgSZW3yc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly ViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private ClassMetadata metadata;
      internal static ViewItem.DebugView UmO4KqC80r22f8XnLb2C;

      public DebugView(ViewItem viewItem)
      {
        ViewItem.DebugView.zq6rNUC8MdZ8jwCUg5g0();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (viewItem == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              this.viewItem = viewItem;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:
        throw new ArgumentNullException((string) ViewItem.DebugView.n2XHt6C8J3g7dQcqCd9k(-1380439818 << 3 ^ 1841424104));
      }

      public Guid? Uid
      {
        get => this.viewItem.uid;
        set => this.viewItem.uid = value;
      }

      public string Name
      {
        get => this.viewItem.Name;
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
                ViewItem.DebugView.ThSmQmC89KV6hn9NuOpZ((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

      public bool Hide
      {
        get => ViewItem.DebugView.yQRebMC8d4L7BXWjQie8((object) this.viewItem);
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
                this.viewItem.Hide = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

      public RootViewItem Parent => (RootViewItem) ViewItem.DebugView.prKlQkC8lhNiFIIdlw2a((object) this.viewItem);

      public ClassMetadata Metadata
      {
        get
        {
          int num = 5;
          Guid? metadataUid;
          ClassMetadata metadata1;
          ClassMetadata metadata2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_10;
              case 2:
                metadata2 = this.metadata;
                if (metadata2 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              case 3:
                goto label_7;
              case 4:
                if (metadataUid.HasValue)
                {
                  num = 2;
                  continue;
                }
                goto label_7;
              case 5:
                metadataUid = ((RootViewItem) ViewItem.DebugView.CFNHTIC8rVaOrVJfIIrS((object) this.viewItem)).MetadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 4 : 4;
                continue;
              default:
                metadataUid = ((RootViewItem) ViewItem.DebugView.CFNHTIC8rVaOrVJfIIrS((object) this.viewItem)).MetadataUid;
                this.metadata = metadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(metadataUid.Value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                continue;
            }
          }
label_7:
          return (ClassMetadata) null;
label_3:
          return metadata2;
label_10:
          return metadata1;
        }
      }

      internal static void zq6rNUC8MdZ8jwCUg5g0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object n2XHt6C8J3g7dQcqCd9k(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool Hib3jwC8mgZMCZ5oeCLj() => ViewItem.DebugView.UmO4KqC80r22f8XnLb2C == null;

      internal static ViewItem.DebugView aqDqOSC8yv5Lw2lC3q9d() => ViewItem.DebugView.UmO4KqC80r22f8XnLb2C;

      internal static void ThSmQmC89KV6hn9NuOpZ([In] object obj0, [In] object obj1) => ((ViewItem) obj0).Name = (string) obj1;

      internal static bool yQRebMC8d4L7BXWjQie8([In] object obj0) => ((ViewItem) obj0).Hide;

      internal static object prKlQkC8lhNiFIIdlw2a([In] object obj0) => (object) ((ViewItem) obj0).Parent;

      internal static object CFNHTIC8rVaOrVJfIIrS([In] object obj0) => (object) ((ViewItem) obj0).FormViewItem;
    }
  }
}

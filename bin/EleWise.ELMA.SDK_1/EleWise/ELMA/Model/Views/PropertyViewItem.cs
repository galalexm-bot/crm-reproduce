// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
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
  /// <summary>
  /// Элемент отображения свойства. PropertyUid - уникальный идентификатор свойства
  /// </summary>
  [DebuggerTypeProxy(typeof (PropertyViewItem.DebugView))]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_PropertyViewItem), "DisplayName")]
  [Serializable]
  public class PropertyViewItem : 
    RootViewItem,
    IFocusable,
    IViewItemWithPropertyParents,
    ICustomViewNameViewItem
  {
    private Guid? propertyUid;
    internal static PropertyViewItem aybM4qoNgFmvTBSZEtk1;

    /// <summary>
    /// Является ли свойство только для чтения (проверяется вместе с подсвойствами)
    /// </summary>
    /// <param name="property">Свойство</param>
    /// <returns><c>true</c>, если свойство является только для чтения</returns>
    private bool IsReadOnlyProperty(PropertyViewItem property)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (PropertyViewItem.oS5NxroNYkl76P6SYMje((object) property))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return property.GetAllProperties(false).All<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!p.IsCustom)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            default:
              if (PropertyViewItem.t54Mwqo3BhZiBO0fg8HZ((object) p))
              {
                num2 = 3;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        return this.IsReadOnlyProperty(p);
label_3:
        return false;
      }));
label_3:
      return false;
    }

    /// <summary>Ctor</summary>
    public PropertyViewItem()
    {
      PropertyViewItem.HyKig9oNLfba1EIREhra();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.CustomViewName = "";
            num = 2;
            continue;
          case 2:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Attributes = new ViewAttributes();
            num = 4;
            continue;
          case 4:
            this.TypeSettings = new PropertiesContainer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    /// <summary>Уникальный идентификатор свойтсва</summary>
    [XmlElement("Property")]
    public virtual Guid PropertyUid
    {
      get
      {
        int num = 4;
        Guid? propertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
            case 3:
            case 7:
              propertyUid = this.propertyUid;
              num = 6;
              continue;
            case 4:
              if (this.propertyUid.HasValue)
              {
                num = 3;
                continue;
              }
              goto case 8;
            case 5:
              this.propertyUid = new Guid?(this.Uid);
              num = 2;
              continue;
            case 6:
              if (propertyUid.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                continue;
              }
              goto label_7;
            case 8:
              if (!this.uid.HasValue)
              {
                num = 7;
                continue;
              }
              goto case 5;
            default:
              goto label_7;
          }
        }
label_7:
        return Guid.Empty;
label_8:
        return propertyUid.GetValueOrDefault();
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
              this.propertyUid = new Guid?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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
    /// Является основным элементом формы для данного свойства
    /// </summary>
    public virtual bool IsMainPropertyViewItem()
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        PropertyViewItem[] propertiesFromForm;
        while (true)
        {
          FormViewItem formViewItem;
          PropertyViewItem propertyViewItem;
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              goto label_17;
            case 3:
              if (propertyViewItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 9;
                continue;
              }
              goto label_16;
            case 4:
              goto label_9;
            case 5:
              if (propertiesFromForm.Length == 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 10 : 8;
                continue;
              }
              break;
            case 6:
              goto label_14;
            case 7:
              if (formViewItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 8 : 4;
                continue;
              }
              goto label_17;
            case 8:
              propertiesFromForm = this.GetEqualPropertiesFromForm(formViewItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
              continue;
            case 9:
              if (propertyViewItem != this)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 10:
              if (propertiesFromForm[0] == this)
              {
                num2 = 4;
                continue;
              }
              break;
            case 11:
              goto label_13;
            case 12:
              goto label_3;
            case 13:
              if (!this.IsReadOnlyProperty(this))
              {
                formViewItem = this.FormViewItem;
                num2 = 7;
                continue;
              }
              num2 = 12;
              continue;
            default:
              if (!PropertyViewItem.oS5NxroNYkl76P6SYMje((object) propertyViewItem))
              {
                num2 = 6;
                continue;
              }
              goto label_13;
          }
          propertyViewItem = ((IEnumerable<PropertyViewItem>) propertiesFromForm).FirstOrDefault<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
          {
            int num3 = 4;
            while (true)
            {
              int num4 = num3;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_7;
                  case 2:
                    if (p is PropertyDescriptionViewItem)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_7;
                  case 4:
                    if (!(p is PropertyCaptionViewItem))
                      goto case 2;
                    else
                      goto label_6;
                  default:
                    goto label_8;
                }
              }
label_6:
              num3 = 3;
            }
label_7:
            return !this.IsReadOnlyProperty(p);
label_8:
            return false;
          }));
          num2 = 3;
        }
label_27:
        if (propertiesFromForm.Length != 0)
          num1 = 5;
        else
          goto label_9;
      }
label_3:
      return false;
label_9:
      return true;
label_13:
      return this.IsReadOnly();
label_14:
      return false;
label_15:
      return true;
label_16:
      return false;
label_17:
      return true;
    }

    private static string GetKeyString(IEnumerable<Guid> uids) => uids.Aggregate<Guid, string>("", (Func<string, Guid, string>) ((current, item) => current + item.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921206323))));

    /// <summary>
    /// Идентификаторы всех родительских свойств, для полной идентификации
    /// </summary>
    internal IEnumerable<Guid> FullProperyUid() => (IEnumerable<Guid>) new PropertyViewItem.\u003CFullProperyUid\u003Ed__9(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Получить все эквивалентные свойства на форме, например, выведено 2 одинаковых свойства на форме
    /// </summary>
    /// <param name="formViewItem">Форма</param>
    /// <returns>Массив эквивалентных свойтв</returns>
    internal PropertyViewItem[] GetEqualPropertiesFromForm(FormViewItem formViewItem)
    {
      int num1 = 2;
      PropertyViewItem[] propertiesFromForm;
      FormViewItem formViewItem1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            formViewItem1 = formViewItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 2;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
          case 3:
            if (ContextVars.GetOrAdd<Dictionary<string, PropertyViewItem[]>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633622765), (Func<Dictionary<string, PropertyViewItem[]>>) (() => formViewItem1.FindItems(false, (Func<ViewItem, bool>) (i => i is PropertyViewItem), (Func<ViewItem, bool>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (i is PropertyViewItem)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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
              return !i.Hide;
label_3:
              return true;
            })).Cast<PropertyViewItem>().Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (!p.IsCustom)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return !p.Hide;
label_3:
              return true;
            })).GroupBy<PropertyViewItem, string>((Func<PropertyViewItem, string>) (p => PropertyViewItem.GetKeyString(p.FullProperyUid()))).ToDictionary<IGrouping<string, PropertyViewItem>, string, PropertyViewItem[]>((Func<IGrouping<string, PropertyViewItem>, string>) (g => g.Key), (Func<IGrouping<string, PropertyViewItem>, PropertyViewItem[]>) (g => g.ToArray<PropertyViewItem>())))).TryGetValue(PropertyViewItem.GetKeyString(this.FullProperyUid()), out propertiesFromForm))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return propertiesFromForm;
label_3:
      return new PropertyViewItem[0];
    }

    /// <summary>Атрибуты отображения свойства</summary>
    [XmlElement("Attributes")]
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty(typeof (PropertyViewItem.AttributesChangeableProperties))]
    public ViewAttributes Attributes
    {
      get => this.\u003CAttributes\u003Ek__BackingField;
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
              this.\u003CAttributes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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
    /// Свойство добавлено автоматически при отрисовке разметки из представления
    /// </summary>
    [DefaultValue(false)]
    public bool IsCustom
    {
      get => this.\u003CIsCustom\u003Ek__BackingField;
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
              this.\u003CIsCustom\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    /// <summary>Представление</summary>
    /// <remarks>
    /// Представление должно находиться в папке EditorTemplates для режима редактирования и в папке DisplayTemplates для режима просмотра, чтобы могло использоваться в качестве шаблона для отображения свойства
    /// </remarks>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public string CustomViewName
    {
      get => this.\u003CCustomViewName\u003Ek__BackingField;
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
              this.\u003CCustomViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
    /// Возращает ближайший значимый контейнер для свойства: форма или родительское свойство
    /// </summary>
    [XmlIgnore]
    public RootViewItem ParentPropertyViewItem
    {
      get
      {
        int num = 1;
        RootViewItem propertyViewItem;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyViewItem = this.Parent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
            case 7:
            case 8:
              goto label_9;
            case 4:
            case 6:
              propertyViewItem = (RootViewItem) PropertyViewItem.mTVMiPoNUHgZtWb97kwG((object) propertyViewItem);
              num = 3;
              continue;
            case 5:
              if (!(propertyViewItem is FormViewItem))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 6 : 5;
                continue;
              }
              goto label_9;
            case 9:
              if (propertyViewItem is PropertyViewItem)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
                continue;
              }
              goto case 5;
            default:
              if (propertyViewItem == null)
              {
                num = 7;
                continue;
              }
              goto case 9;
          }
        }
label_9:
        return propertyViewItem;
      }
    }

    /// <summary>
    /// Отображение свойства на редактирование в блоке как "таблица"
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public bool EditableInTable
    {
      get => this.\u003CEditableInTable\u003Ek__BackingField;
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
              this.\u003CEditableInTable\u003Ek__BackingField = value;
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

    /// <summary>
    /// Если True, то глобальный признак "Только для чтения" из формы не учитывается
    /// </summary>
    [DefaultValue(false)]
    public bool OverrideEditableInTable
    {
      get => this.\u003COverrideEditableInTable\u003Ek__BackingField;
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
              this.\u003COverrideEditableInTable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public List<Guid> PropertyParents { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.PropertyViewItem.PropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertyParents != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.PropertyParents.Count > 0;
label_3:
      return false;
    }

    /// <inheritdoc />
    [DefaultValue(FocusableType.None)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public FocusableType FocusableType
    {
      get => this.\u003CFocusableType\u003Ek__BackingField;
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
              this.\u003CFocusableType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Только для чтения</summary>
    public override bool? ReadOnly
    {
      get
      {
        bool? nullable = (bool?) this.Attributes?.ReadOnly;
        if (nullable.HasValue)
          return nullable;
        return !(this.Parent is PropertyViewItem) ? new bool?() : new bool?(false);
      }
      set
      {
        if (this.Attributes == null)
          this.Attributes = new ViewAttributes();
        this.Attributes.ReadOnly = value;
      }
    }

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool ShouldSerializeReadOnly() => false;

    public override void CopyFrom(ViewItem viewItem)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        PropertyViewItem propertyViewItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propertyViewItem == null)
              {
                num2 = 2;
                continue;
              }
              goto label_8;
            case 2:
              goto label_10;
            case 3:
              goto label_6;
            case 4:
              propertyViewItem = viewItem as PropertyViewItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
              continue;
            case 5:
              base.CopyFrom(viewItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 4 : 3;
              continue;
            case 6:
              this.TypeSettings = propertyViewItem.TypeSettings == null ? (PropertiesContainer) null : ClassSerializationHelper.CloneObjectByXml<PropertiesContainer>((PropertiesContainer) PropertyViewItem.VDv4UBoNcGXt43Giyvqx((object) propertyViewItem));
              num2 = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        this.Attributes = propertyViewItem.Attributes != null ? ClassSerializationHelper.CloneObjectByXml<ViewAttributes>((ViewAttributes) PropertyViewItem.oiT7Y5oNsuVeOggjnnWK((object) propertyViewItem)) : (ViewAttributes) null;
        num1 = 6;
      }
label_10:
      return;
label_6:;
    }

    public override void ReplacePropertyUid(Dictionary<Guid, Guid> ReplaceContextVar)
    {
      base.ReplacePropertyUid(ReplaceContextVar);
      Guid empty = Guid.Empty;
      if (ReplaceContextVar.TryGetValue(this.PropertyUid, out empty))
        this.PropertyUid = empty;
      if (!(this.Parent is PropertyViewItem parent) || !ReplaceContextVar.TryGetValue(parent.PropertyUid, out empty))
        return;
      parent.PropertyUid = empty;
    }

    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [XmlElement("TypeSettings")]
    public PropertiesContainer TypeSettings
    {
      get => this.\u003CTypeSettings\u003Ek__BackingField;
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
              this.\u003CTypeSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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
    public bool ShouldSerializeTypeSettings()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.TypeSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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
      return this.TypeSettings.GetProperties().Any<string>();
label_5:
      return false;
    }

    public virtual void TypeSettingsAction(EleWise.ELMA.Model.Types.Settings.TypeSettings typeSettings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PropertyViewItem.u4a7vioNzHn1GJQfrfLj((object) typeSettings, (object) this.TypeSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (parentViewItem is ColumnViewItem)
            {
              num = 6;
              continue;
            }
            break;
          case 3:
          case 6:
            goto label_9;
          case 4:
            goto label_11;
          case 5:
            if (this.Hide)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 7:
            if (parentViewItem != null)
            {
              num = 8;
              continue;
            }
            goto label_11;
          case 8:
            if (!parentViewItem.IsChildValid((ViewItem) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 9 : 9;
              continue;
            }
            goto case 2;
          case 9:
            goto label_10;
        }
        if (parentViewItem is CellViewItem)
          num = 3;
        else
          break;
      }
label_8:
      return parentViewItem is PropertyViewItem;
label_9:
      return true;
label_10:
      return false;
label_11:
      return true;
    }

    /// <inheritdoc />
    protected internal override void SetReadOnly() => base.SetReadOnly();

    /// <inheritdoc />
    protected internal override void SetReadOnly(bool value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            base.SetReadOnly(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected internal override void SetReadOnly(bool value, bool recursive)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          bool? nullable;
          int num3;
          switch (num2)
          {
            case 1:
label_5:
              this.EditableInTable = false;
              num2 = 2;
              continue;
            case 2:
              goto label_17;
            case 3:
              this.Attributes.ReadOnly = new bool?(value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 5 : 1;
              continue;
            case 4:
              nullable = this.FormViewItem.ReadOnly;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            case 5:
              this.ReadOnly = new bool?(value);
              num2 = 10;
              continue;
            case 6:
              num3 = 0;
              break;
            case 7:
              goto label_3;
            case 8:
              if (this.Attributes != null)
              {
                num2 = 3;
                continue;
              }
              goto case 5;
            case 9:
              base.SetReadOnly(value, recursive);
              num2 = 8;
              continue;
            case 10:
              if (value)
              {
                num2 = 4;
                continue;
              }
              goto label_8;
            case 11:
              num3 = nullable.GetValueOrDefault() ? 1 : 0;
              break;
            default:
              if (nullable.HasValue)
              {
                num2 = 11;
                continue;
              }
              goto case 6;
          }
          if (num3 != 0)
            goto label_5;
          else
            break;
        }
        num1 = 7;
      }
label_17:
      return;
label_3:
      return;
label_8:;
    }

    /// <inheritdoc />
    public override bool IsReadOnly()
    {
      int num1 = 3;
      while (true)
      {
        bool? nullable1;
        bool? nullable2;
        bool? nullable3;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            nullable1 = new bool?();
            num1 = 5;
            continue;
          case 3:
            ViewAttributes attributes = this.Attributes;
            if (attributes == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
              continue;
            }
            nullable3 = attributes.ReadOnly;
            break;
          case 4:
            num2 = 0;
            goto label_14;
          case 5:
            nullable3 = nullable1;
            break;
          case 6:
            if (!nullable2.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 4;
              continue;
            }
            num2 = nullable2.GetValueOrDefault() ? 1 : 0;
            goto label_14;
          default:
            goto label_5;
        }
        nullable2 = nullable3;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 0;
        continue;
label_14:
        if (num2 != 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
        else
          break;
      }
label_4:
      return base.IsReadOnly();
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is PropertyViewItem;

    /// <inheritdoc />
    protected internal override void SetVisible(bool visible)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            base.SetVisible(visible);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected internal override void SetVisible(bool visible, bool recursive)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PropertyViewItem.XfSHGHo3FIiSL0u2b0vT((object) this.Attributes, visible);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            base.SetVisible(visible, recursive);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override bool IsVisible()
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            num2 = 1;
            break;
          case 2:
            ViewAttributes attributes = this.Attributes;
            if (attributes == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            }
            num2 = attributes.Visible ? 1 : 0;
            break;
          default:
            goto label_2;
        }
        if (num2 != 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
        else
          goto label_3;
      }
label_2:
      return base.IsVisible();
label_3:
      return false;
    }

    internal static bool oS5NxroNYkl76P6SYMje([In] object obj0) => ((RootViewItem) obj0).IsReadOnly();

    internal static bool C9SSFOoN5OAvok4RMXw1() => PropertyViewItem.aybM4qoNgFmvTBSZEtk1 == null;

    internal static PropertyViewItem D22TjAoNj4kVkDs8ivpw() => PropertyViewItem.aybM4qoNgFmvTBSZEtk1;

    internal static void HyKig9oNLfba1EIREhra() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object mTVMiPoNUHgZtWb97kwG([In] object obj0) => (object) ((ViewItem) obj0).Parent;

    internal static object oiT7Y5oNsuVeOggjnnWK([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static object VDv4UBoNcGXt43Giyvqx([In] object obj0) => (object) ((PropertyViewItem) obj0).TypeSettings;

    internal static void u4a7vioNzHn1GJQfrfLj([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Model.Types.Settings.TypeSettings) obj0).SetTypeSettings((PropertiesContainer) obj1);

    internal static void XfSHGHo3FIiSL0u2b0vT([In] object obj0, bool value) => ((ViewAttributes) obj0).Visible = value;

    internal static bool t54Mwqo3BhZiBO0fg8HZ([In] object obj0) => ((ViewItem) obj0).Hide;

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly PropertyViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private IPropertyMetadata property;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly RootViewItem.DebugView _rootViewItemDebugView;
      internal static PropertyViewItem.DebugView spa6u7CvTSUiEJ794R8P;

      public DebugView(PropertyViewItem viewItem)
      {
        PropertyViewItem.DebugView.Pa2e6qCvOTFa2fGdii4j();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.viewItem = viewItem;
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this._rootViewItemDebugView = new RootViewItem.DebugView((RootViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public IPropertyMetadata Property
      {
        get
        {
          int num1 = 8;
          while (true)
          {
            int num2 = num1;
            while (true)
            {
              Guid guid1;
              IMetadataService service;
              switch (num2)
              {
                case 1:
                  this.property = ((IEnumerable<ClassMetadata>) new ClassMetadata[1]
                  {
                    ((ViewItem.DebugView) PropertyViewItem.DebugView.VfpCXtCv3pkUmoWSxhle((object) this._rootViewItemDebugView)).Metadata
                  }).If<ClassMetadata>(service != null, (Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>>) (list => list.Concat<ClassMetadata>(service.GetMetadataList().OfType<ClassMetadata>()))).Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => m != null)).Select<ClassMetadata, IPropertyMetadata>((Func<ClassMetadata, IPropertyMetadata>) (m =>
                  {
                    int num3 = 3;
                    IPropertyMetadata property;
                    while (true)
                    {
                      int num4 = num3;
                      IEntityMetadata entityMetadata;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            property = (IPropertyMetadata) entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (tp => PropertyViewItem.DebugView.PBOn0vCvA7cUPMjbKT10(PropertyViewItem.DebugView.ywP0ENCvevAE91emb7Ht((object) tp), this.viewItem.PropertyUid)));
                            num4 = 5;
                            continue;
                          case 2:
                            if (property == null)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_6;
                          case 3:
                            goto label_3;
                          case 4:
                          case 5:
                            goto label_6;
                          case 6:
                            if (entityMetadata == null)
                            {
                              num4 = 4;
                              continue;
                            }
                            goto case 1;
                          default:
                            entityMetadata = m as IEntityMetadata;
                            num4 = 6;
                            continue;
                        }
                      }
label_3:
                      property = (IPropertyMetadata) m.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == this.viewItem.PropertyUid));
                      num3 = 2;
                    }
label_6:
                    return property;
                  })).FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => p != null));
                  num2 = 2;
                  continue;
                case 2:
                case 5:
                  goto label_5;
                case 3:
                  goto label_4;
                case 4:
                  guid1 = PropertyViewItem.DebugView.ywP0ENCvevAE91emb7Ht((object) (ITablePartMetadata) this.property);
                  break;
                case 6:
                  service = (IMetadataService) PropertyViewItem.DebugView.BUHgvZCvNnRpdGk7EArF();
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                  continue;
                case 7:
                  if (this.property is ITablePartMetadata)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 4;
                    continue;
                  }
                  goto default;
                case 8:
                  if (this.property != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 7;
                    continue;
                  }
                  goto label_4;
                default:
                  guid1 = PropertyViewItem.DebugView.m1piaRCv2m5OHvPD8nbP((object) this.property);
                  break;
              }
              Guid guid2 = PropertyViewItem.DebugView.WCJObVCvPmKsBh0u8YQA((object) this.viewItem);
              if (!PropertyViewItem.DebugView.oYxMkiCv1TSS3sC0WPVN(guid1, guid2))
                num2 = 5;
              else
                break;
            }
label_4:
            num1 = 6;
          }
label_5:
          return this.property;
        }
      }

      public bool? ReadOnly => this.viewItem.Attributes.ReadOnly;

      public bool FullReadOnly => PropertyViewItem.DebugView.ft6pUjCvaDilxEtKWMUA(PropertyViewItem.DebugView.BUh4fvCvp07PNMFHJgv9((object) this.viewItem));

      public bool Required => ((ViewAttributes) PropertyViewItem.DebugView.BUh4fvCvp07PNMFHJgv9((object) this.viewItem)).Required;

      public bool Visible => PropertyViewItem.DebugView.ywf57nCvDv9DQ1ahPWRo(PropertyViewItem.DebugView.BUh4fvCvp07PNMFHJgv9((object) this.viewItem));

      public ViewAttributes Attributes => (ViewAttributes) PropertyViewItem.DebugView.BUh4fvCvp07PNMFHJgv9((object) this.viewItem);

      public string CustomViewName
      {
        get => (string) PropertyViewItem.DebugView.S3FEoOCvtsEc6UDNeKOI((object) this.viewItem);
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
                PropertyViewItem.DebugView.oxg4oxCvwLobU27JCbOp((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

      public override string ToString() => (string) PropertyViewItem.DebugView.DdBmMhCvHcWm3k4kRgwy((object) this.viewItem, this.Property == null ? (object) null : PropertyViewItem.DebugView.hZYaipCv6fND2PR4CWmV(PropertyViewItem.DebugView.aqy744Cv4ukxXjGHT4Yg(--1418440330 ^ 1418447264), (object) this.Property, PropertyViewItem.DebugView.aqy744Cv4ukxXjGHT4Yg(864270449 << 6 ^ -521272324)));

      internal static void Pa2e6qCvOTFa2fGdii4j() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Js3RFICvkGoQmwsKOFj1() => PropertyViewItem.DebugView.spa6u7CvTSUiEJ794R8P == null;

      internal static PropertyViewItem.DebugView yTNb0MCvnUZvZCGJ7vae() => PropertyViewItem.DebugView.spa6u7CvTSUiEJ794R8P;

      internal static Guid m1piaRCv2m5OHvPD8nbP([In] object obj0) => ((IMetadata) obj0).Uid;

      internal static Guid ywP0ENCvevAE91emb7Ht([In] object obj0) => ((ITablePartMetadata) obj0).TablePartPropertyUid;

      internal static Guid WCJObVCvPmKsBh0u8YQA([In] object obj0) => ((PropertyViewItem) obj0).PropertyUid;

      internal static bool oYxMkiCv1TSS3sC0WPVN([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static object BUHgvZCvNnRpdGk7EArF() => (object) MetadataServiceContext.ServiceOrNull;

      internal static object VfpCXtCv3pkUmoWSxhle([In] object obj0) => (object) ((RootViewItem.DebugView) obj0).viewItemDebugView;

      internal static object BUh4fvCvp07PNMFHJgv9([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

      internal static bool ft6pUjCvaDilxEtKWMUA([In] object obj0) => ((ViewAttributes) obj0).FullReadOnly;

      internal static bool ywf57nCvDv9DQ1ahPWRo([In] object obj0) => ((ViewAttributes) obj0).Visible;

      internal static object S3FEoOCvtsEc6UDNeKOI([In] object obj0) => (object) ((PropertyViewItem) obj0).CustomViewName;

      internal static void oxg4oxCvwLobU27JCbOp([In] object obj0, [In] object obj1) => ((PropertyViewItem) obj0).CustomViewName = (string) obj1;

      internal static object aqy744Cv4ukxXjGHT4Yg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object hZYaipCv6fND2PR4CWmV([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

      internal static object DdBmMhCvHcWm3k4kRgwy([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

      internal static bool PBOn0vCvA7cUPMjbKT10([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
    }

    private class AttributesChangeableProperties : IAttributesChangeableProperties
    {
      internal static object fF1veSCv7FG7ne6j4JQ8;

      public string[] GetProperties()
      {
        string[] properties = new string[16];
        ParameterExpression parameterExpression1 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(typeof (ViewAttributes), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-398663332 ^ -398923310));
        // ISSUE: method reference
        // ISSUE: type reference
        properties[0] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_ReadOnly))), PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (object))), parameterExpression1));
        // ISSUE: type reference
        ParameterExpression parameterExpression2 = Expression.Parameter(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475597705));
        // ISSUE: method reference
        // ISSUE: type reference
        properties[1] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.AwkQZnCvdOPislPq5JJ8(PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression2, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Visible))), PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (object))), parameterExpression2));
        // ISSUE: type reference
        ParameterExpression parameterExpression3 = Expression.Parameter(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), (string) PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-53329496 >> 4 ^ -3593068));
        // ISSUE: method reference
        properties[2] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.AwkQZnCvdOPislPq5JJ8((object) Expression.Property((Expression) parameterExpression3, (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Required))), typeof (object)), parameterExpression3));
        // ISSUE: type reference
        ParameterExpression parameterExpression4 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-1638402543 ^ -1638662497));
        // ISSUE: method reference
        properties[3] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Name))), parameterExpression4));
        // ISSUE: type reference
        ParameterExpression parameterExpression5 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(1461625753 ^ 1461365527));
        // ISSUE: method reference
        properties[4] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression5, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Description))), parameterExpression5));
        ParameterExpression parameterExpression6 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(typeof (ViewAttributes), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(1461625753 ^ 1461365527));
        // ISSUE: method reference
        properties[5] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression6, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_OnChangeScriptName))), parameterExpression6));
        properties[6] = (string) PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-1598106783 - -968262081 ^ -630141328);
        // ISSUE: type reference
        ParameterExpression parameterExpression7 = Expression.Parameter(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), (string) PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(1033719030 - 2012070891 ^ -978615931));
        // ISSUE: method reference
        properties[7] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression7, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_OnViewLoadScriptName))), parameterExpression7));
        // ISSUE: type reference
        ParameterExpression parameterExpression8 = Expression.Parameter(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), (string) PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(277947046 - -1479185048 ^ 1757396400));
        // ISSUE: method reference
        // ISSUE: type reference
        properties[8] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) Expression.Convert((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression8, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_EntityFilterProvider))), PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (object))), parameterExpression8));
        ParameterExpression parameterExpression9;
        // ISSUE: method reference
        properties[9] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression9, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ViewAttributes.get_EntityFilterData))), parameterExpression9));
        // ISSUE: type reference
        ParameterExpression parameterExpression10 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-441065788 ^ -2092910478 ^ 1727098424));
        // ISSUE: method reference
        // ISSUE: type reference
        properties[10] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.AwkQZnCvdOPislPq5JJ8(PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression10, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ViewAttributes.get_ShowEmpty))), PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (object))), parameterExpression10));
        // ISSUE: type reference
        ParameterExpression parameterExpression11 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837926667));
        // ISSUE: method reference
        properties[11] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression11, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Placeholder))), parameterExpression11));
        // ISSUE: type reference
        ParameterExpression parameterExpression12 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(44884861 ^ 44624883));
        // ISSUE: method reference
        properties[12] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) Expression.Property((Expression) parameterExpression12, (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_Tooltip))), parameterExpression12));
        // ISSUE: type reference
        ParameterExpression parameterExpression13 = (ParameterExpression) PropertyViewItem.AttributesChangeableProperties.A9UpJrCvyvrd3Foigvp9(PropertyViewItem.AttributesChangeableProperties.ANgfdfCvJIUB5hfWbuO5(__typeref (ViewAttributes)), PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(-1638402543 ^ -1638662497));
        // ISSUE: method reference
        properties[13] = LinqUtils.NameOf<ViewAttributes>(Expression.Lambda<Func<ViewAttributes, object>>((Expression) PropertyViewItem.AttributesChangeableProperties.PCCCx2Cv9tKNk1GUSXff((object) parameterExpression13, (object) (MethodInfo) PropertyViewItem.AttributesChangeableProperties.u8JRQlCvMMlKDq4DxO49(__methodref (ViewAttributes.get_ValidationError))), parameterExpression13));
        properties[14] = (string) PropertyViewItem.AttributesChangeableProperties.MqChLOCvm1hT96IOGgUv(~-397266137 ^ 396908462);
        properties[15] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787089677);
        return properties;
      }

      public AttributesChangeableProperties()
      {
        PropertyViewItem.AttributesChangeableProperties.gVK6kmCvlmGa9TuMbA2i();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object MqChLOCvm1hT96IOGgUv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object A9UpJrCvyvrd3Foigvp9([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

      internal static object u8JRQlCvMMlKDq4DxO49([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

      internal static Type ANgfdfCvJIUB5hfWbuO5([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object PCCCx2Cv9tKNk1GUSXff([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

      internal static object AwkQZnCvdOPislPq5JJ8([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

      internal static bool XJ8x25Cvxd1upcSKPsoj() => PropertyViewItem.AttributesChangeableProperties.fF1veSCv7FG7ne6j4JQ8 == null;

      internal static PropertyViewItem.AttributesChangeableProperties uXtD1BCv0xQOjp6C3bB3() => (PropertyViewItem.AttributesChangeableProperties) PropertyViewItem.AttributesChangeableProperties.fF1veSCv7FG7ne6j4JQ8;

      internal static void gVK6kmCvlmGa9TuMbA2i() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

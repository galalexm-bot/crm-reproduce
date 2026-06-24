// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormView
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Представление в виде формы</summary>
  [Obsolete("Использовать FormViewItem")]
  [Serializable]
  public class FormView : RootViewItem
  {
    private static FormView B7TAr9oN4EY141DNrnPu;

    /// <summary>Ctor</summary>
    public FormView()
    {
      FormView.lvTM4coNA6JR7Bke6BXK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ViewType = ViewType.Custom;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.UseStandartView = true;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать представление по объекту метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="viewType">Тип представления</param>
    /// <param name="itemType">Тип элемента</param>
    public FormView(ClassMetadata metadata, ViewType viewType, ItemType itemType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 3;
              continue;
            }
            goto label_2;
          case 2:
            this.ViewType = viewType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
          case 3:
            this.CreateItems((RootViewItem) this, metadata, viewType, itemType);
            num = 4;
            continue;
          case 4:
            goto label_6;
          default:
            goto label_9;
        }
      }
label_5:
      return;
label_6:
      return;
label_9:
      return;
label_2:;
    }

    /// <summary>Стандартный тип представления</summary>
    [DefaultValue(ViewType.Custom)]
    public ViewType ViewType
    {
      get => this.\u003CViewType\u003Ek__BackingField;
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
              this.\u003CViewType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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
    /// Использовать ли для представления стандартное отображение
    /// </summary>
    [DefaultValue(false)]
    public bool CanUseCommonView
    {
      get => this.\u003CCanUseCommonView\u003Ek__BackingField;
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
              this.\u003CCanUseCommonView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Использовать ли для представления разметку Razor</summary>
    [DefaultValue(false)]
    public bool CanUseCommonRazorView
    {
      get => this.\u003CCanUseCommonRazorView\u003Ek__BackingField;
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
              this.\u003CCanUseCommonRazorView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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
    /// Использовать ли для представления стандартное отображение
    /// </summary>
    [DefaultValue(false)]
    public bool CanUseTabView
    {
      get => this.\u003CCanUseTabView\u003Ek__BackingField;
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
              this.\u003CCanUseTabView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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

    /// <summary>Использовать ли для представления разметку Razor</summary>
    [DefaultValue(false)]
    public bool CanUseTabRazorView
    {
      get => this.\u003CCanUseTabRazorView\u003Ek__BackingField;
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
              this.\u003CCanUseTabRazorView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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
    /// Использовать ли для представления стандартное отображение
    /// </summary>
    [DefaultValue(true)]
    public bool UseStandartView
    {
      get => this.\u003CUseStandartView\u003Ek__BackingField;
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
              this.\u003CUseStandartView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    /// <summary>Использовать ли для представления разметку Razor</summary>
    [DefaultValue(false)]
    public bool UseRazorView
    {
      get => this.\u003CUseRazorView\u003Ek__BackingField;
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
              this.\u003CUseRazorView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Отображать ли представление во вкладке</summary>
    [DefaultValue(false)]
    public bool ViewInTab
    {
      get => this.\u003CViewInTab\u003Ek__BackingField;
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
              this.\u003CViewInTab\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Отображать ли представление в общем списке</summary>
    [DefaultValue(false)]
    public bool ViewInCommon
    {
      get => this.\u003CViewInCommon\u003Ek__BackingField;
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
              this.\u003CViewInCommon\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Заголовок вкладки для отображения</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
    public string ViewInTabName
    {
      get => this.\u003CViewInTabName\u003Ek__BackingField;
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
              this.\u003CViewInTabName\u003Ek__BackingField = value;
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

    /// <summary>Путь до представления для отображения во вкладке</summary>
    [DefaultValue("")]
    public string RazorTabViewName
    {
      get => this.\u003CRazorTabViewName\u003Ek__BackingField;
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
              this.\u003CRazorTabViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Путь до представления для отображения в общем списке</summary>
    [DefaultValue("")]
    public string RazorCommonViewName
    {
      get => this.\u003CRazorCommonViewName\u003Ek__BackingField;
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
              this.\u003CRazorCommonViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Сценарий при загрузке формы</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string OnLoadScriptName
    {
      get => this.\u003COnLoadScriptName\u003Ek__BackingField;
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
              this.\u003COnLoadScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    /// <summary>Склонировать и устновить режим ReadOnly</summary>
    /// <returns></returns>
    public FormView CloneAsReadOnly()
    {
      FormView formView = ClassSerializationHelper.CloneObjectByXml<FormView>(this);
      FormView.LcCw79oN7TvyhG8W6hwb((object) formView, true);
      return formView;
    }

    /// <summary>
    /// Проверить доступность отображения формы во внешних приложениях
    /// </summary>
    /// <param name="properties">Список свойств</param>
    /// <param name="errors">Текущий список ошибок</param>
    public virtual void CheckPublicApplicationCompatibility(
      [NotNull] ClassMetadata metadata,
      [NotNull] IEnumerable<IPropertyMetadata> properties,
      [NotNull] List<IPublicApplicationCompatibilityError> errors)
    {
      if (properties == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272469527));
      if (errors == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16631395));
      if (!string.IsNullOrEmpty(this.OnLoadScriptName))
        errors.Add((IPublicApplicationCompatibilityError) new PublicApplicationCompatibilityError()
        {
          Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123753996))
        });
      FormView.CheckPublicApplicationCompatibility((object) this, (object) metadata, properties, (object) null, errors);
    }

    private void CreateItems(
      RootViewItem parent,
      ClassMetadata metadata,
      ViewType viewType,
      ItemType itemType)
    {
      int num1 = 1;
      IEnumerator<IPropertyMetadata> enumerator;
      while (true)
      {
        IEnumerable<IPropertyMetadata> list;
        IEnumerable<IPropertyMetadata> propertyMetadatas;
        switch (num1)
        {
          case 1:
            if (metadata is EntityMetadata)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            list = (IEnumerable<IPropertyMetadata>) metadata.Properties.Cast<IPropertyMetadata>().ToList<IPropertyMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 5;
            continue;
          case 4:
            goto label_30;
          case 5:
            propertyMetadatas = list;
            break;
          default:
            propertyMetadatas = ((EntityMetadata) metadata).GetPropertiesAndTableParts();
            break;
        }
        enumerator = propertyMetadatas.GetEnumerator();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 2;
      }
label_30:
      return;
label_2:
      try
      {
label_12:
        if (FormView.NYXknPoNrTNUICuxgU5j((object) enumerator))
          goto label_14;
        else
          goto label_13;
label_3:
        PropertyMetadata propertyMetadata;
        ViewAttribute viewAttribute;
        PropertyViewItem propertyViewItem1;
        IPropertyMetadata current;
        TablePartMetadata metadata1;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              ((ViewAttributes) FormView.JpDh6moNm9dPWLlGaRMX((object) propertyViewItem1)).ReadOnly = new bool?(viewType == ViewType.Display);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 17 : 0;
              continue;
            case 2:
              if (viewAttribute == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                continue;
              }
              goto case 10;
            case 4:
              goto label_12;
            case 5:
              if (metadata1 != null)
              {
                num2 = 12;
                continue;
              }
              goto label_12;
            case 6:
              metadata1 = current as TablePartMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 5;
              continue;
            case 7:
            case 13:
              ((ViewAttributes) FormView.JpDh6moNm9dPWLlGaRMX((object) propertyViewItem1)).ReadOnly = new bool?(viewType == ViewType.Display);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            case 8:
              PropertyViewItem propertyViewItem2 = new PropertyViewItem();
              FormView.AQ1rlBoN0FEPs41YIevN((object) propertyViewItem2, FormView.Vlm13loNxL2XHw0MkO2W((object) current));
              propertyViewItem1 = propertyViewItem2;
              num2 = 20;
              continue;
            case 10:
              FormView.nxHXikoN9BxeAbVu1G3v(FormView.JpDh6moNm9dPWLlGaRMX((object) propertyViewItem1), viewAttribute.Visible);
              num2 = 18;
              continue;
            case 11:
              goto label_14;
            case 12:
              this.CreateItems((RootViewItem) this, (ClassMetadata) metadata1, viewType, itemType);
              num2 = 4;
              continue;
            case 14:
              if (propertyMetadata == null)
              {
                num2 = 7;
                continue;
              }
              goto case 19;
            case 15:
              goto label_29;
            case 16:
              propertyMetadata = current as PropertyMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 14 : 4;
              continue;
            case 18:
              propertyViewItem1.Attributes.ReadOnly = new bool?(viewAttribute.ReadOnly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 9;
              continue;
            case 19:
              viewAttribute = (ViewAttribute) FormView.px7lBHoNJKXjGZe9gOP3((object) propertyMetadata.ViewSettings, viewType, itemType);
              num2 = 2;
              continue;
            case 20:
              FormView.CoIVtPoNMss6Aejya6Os(FormView.JpDh6moNm9dPWLlGaRMX((object) propertyViewItem1), FormView.jrp5NBoNyhyeCnM5G4r2((object) current));
              num2 = 16;
              continue;
            case 21:
              ((EventedList<ViewItem>) FormView.dGsjiboNlrAw4uh3N9Cj((object) parent)).Add((ViewItem) propertyViewItem1);
              num2 = 6;
              continue;
            default:
              if (FormView.JsGlh5oNdgs5eKL5HbDk(FormView.JpDh6moNm9dPWLlGaRMX((object) propertyViewItem1)))
              {
                num2 = 21;
                continue;
              }
              goto case 6;
          }
        }
label_29:
        return;
label_13:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 15;
        goto label_3;
label_14:
        current = enumerator.Current;
        num2 = 8;
        goto label_3;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
        else
          goto label_31;
label_28:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_31:
        enumerator.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        {
          num3 = 2;
          goto label_28;
        }
        else
          goto label_28;
      }
    }

    private static void CheckPublicApplicationCompatibility(
      object viewItem,
      object metadata,
      IEnumerable<IPropertyMetadata> properties,
      object parentPropertyName,
      List<IPublicApplicationCompatibilityError> errors)
    {
      if (viewItem == null)
        return;
      foreach (PropertyViewItem propertyViewItem in ((RootViewItem) viewItem).Items.OfType<PropertyViewItem>())
      {
        PropertyViewItem propViewItem = propertyViewItem;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        IPropertyMetadata propertyMetadata1 = properties.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => FormView.\u003C\u003Ec__DisplayClass57_0.aLEkWpCvh4CrEExcOcLP(FormView.\u003C\u003Ec__DisplayClass57_0.KwV8D5CvolKqKxPtKKnJ((object) p), FormView.\u003C\u003Ec__DisplayClass57_0.IaH9MWCvbJDcCnqCGeJq((object) propViewItem))));
        if (propertyMetadata1 != null)
        {
          string str = (!string.IsNullOrEmpty((string) parentPropertyName) ? (string) parentPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536797870) : "") + propertyMetadata1.DisplayName;
          PropertyMetadata propertyMetadata2 = propertyMetadata1 as PropertyMetadata;
          ITablePartMetadata tablePartMetadata = propertyMetadata1 as ITablePartMetadata;
          if (propertyMetadata2 != null)
          {
            ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata1.TypeUid, propertyMetadata1.SubTypeUid);
            if (typeDescriptor == null)
            {
              errors.Add((IPublicApplicationCompatibilityError) new PublicApplicationCompatibilityError()
              {
                Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841504344), (object) str)
              });
              continue;
            }
            if (!(typeDescriptor is IPublicApplicationTypeDescriptor applicationTypeDescriptor))
            {
              string typeCode = typeDescriptor.Uid.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401429) + (object) typeDescriptor.SubTypeUid;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              PublicAppTypeCompatibilityError compatibilityError1 = errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault<PublicAppTypeCompatibilityError>((Func<PublicAppTypeCompatibilityError, bool>) (e => FormView.\u003C\u003Ec__DisplayClass57_1.XBehjBCvCmkw39shm0yi(FormView.\u003C\u003Ec__DisplayClass57_1.NPyRJrCvQOTf8lktl7iR((object) e), (object) typeCode)));
              if (compatibilityError1 != null)
              {
                compatibilityError1.PropertyNames.Add(str);
              }
              else
              {
                IPropertyTypeInfo propertyTypeInfo = typeDescriptor as IPropertyTypeInfo;
                PublicAppTypeCompatibilityError compatibilityError2 = new PublicAppTypeCompatibilityError(typeCode, propertyTypeInfo != null ? propertyTypeInfo.GetPropertyTypeDisplayName(propertyMetadata2) : typeDescriptor.Name, new bool?(), new string[1]
                {
                  str
                });
                errors.Add((IPublicApplicationCompatibilityError) compatibilityError2);
              }
            }
            else
              applicationTypeDescriptor.CheckPublicApplicationCompatibility((ClassMetadata) metadata, propertyMetadata2, propViewItem, (string) parentPropertyName, errors);
          }
          else if (tablePartMetadata != null)
          {
            if (!propViewItem.IsReadOnly())
            {
              string typeCode = z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757011218);
              // ISSUE: reference to a compiler-generated method
              PublicAppTypeCompatibilityError compatibilityError3 = errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault<PublicAppTypeCompatibilityError>((Func<PublicAppTypeCompatibilityError, bool>) (e => FormView.\u003C\u003Ec__DisplayClass57_2.veqjjcCvIurGlPPVMoR8((object) e.TypeCode, (object) typeCode)));
              if (compatibilityError3 != null)
              {
                compatibilityError3.PropertyNames.Add(str);
              }
              else
              {
                PublicAppTypeCompatibilityError compatibilityError4 = new PublicAppTypeCompatibilityError(typeCode, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470581538)), new bool?(false), new string[1]
                {
                  str
                });
                errors.Add((IPublicApplicationCompatibilityError) compatibilityError4);
              }
            }
            ClassMetadata metadata1 = (ClassMetadata) tablePartMetadata;
            IEnumerable<IPropertyMetadata> properties1 = tablePartMetadata is IEntityMetadata entityMetadata ? entityMetadata.GetPropertiesAndTableParts() : (IEnumerable<IPropertyMetadata>) metadata1.Properties.Cast<IPropertyMetadata>().ToArray<IPropertyMetadata>();
            FormView.CheckPublicApplicationCompatibility((object) propViewItem, (object) metadata1, properties1, (object) (str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61198123)), errors);
          }
          if (!propViewItem.IsReadOnly() && !string.IsNullOrEmpty(propViewItem.Attributes.OnChangeScriptName))
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            PublicAppPropertyScriptError propertyScriptError1 = errors.OfType<PublicAppPropertyScriptError>().FirstOrDefault<PublicAppPropertyScriptError>((Func<PublicAppPropertyScriptError, bool>) (e => FormView.\u003C\u003Ec.Mr3Rs6CvXMuO2JPhs0ub(FormView.\u003C\u003Ec.Il2QvICvqc1sYXOx6ycW((object) e), FormView.\u003C\u003Ec.xy25fiCvKSgnogp4laQx(1574260816 ^ 1574385880))));
            if (propertyScriptError1 != null)
            {
              propertyScriptError1.PropertyNames.Add(str);
            }
            else
            {
              PublicAppPropertyScriptError propertyScriptError2 = new PublicAppPropertyScriptError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345299636), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901918411)), new string[1]
              {
                str
              });
              errors.Add((IPublicApplicationCompatibilityError) propertyScriptError2);
            }
          }
        }
      }
    }

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => parentViewItem == null;

    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void lvTM4coNA6JR7Bke6BXK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gjfOipoN6MAL8nOlfAHH() => FormView.B7TAr9oN4EY141DNrnPu == null;

    internal static FormView WjstUboNH1RS4dBX9O8Z() => FormView.B7TAr9oN4EY141DNrnPu;

    internal static void LcCw79oN7TvyhG8W6hwb([In] object obj0, bool value) => ((ViewItem) obj0).SetReadOnly(value);

    internal static Guid Vlm13loNxL2XHw0MkO2W([In] object obj0) => ((IPropertyMetadata) obj0).PropertyUid;

    internal static void AQ1rlBoN0FEPs41YIevN([In] object obj0, Guid value) => ((PropertyViewItem) obj0).PropertyUid = value;

    internal static object JpDh6moNm9dPWLlGaRMX([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static bool jrp5NBoNyhyeCnM5G4r2([In] object obj0) => ((IPropertyMetadata) obj0).Required;

    internal static void CoIVtPoNMss6Aejya6Os([In] object obj0, bool value) => ((ViewAttributes) obj0).Required = value;

    internal static object px7lBHoNJKXjGZe9gOP3([In] object obj0, ViewType viewType, ItemType itemType) => (object) ((PropertyViewSettings) obj0).GetForView(viewType, itemType);

    internal static void nxHXikoN9BxeAbVu1G3v([In] object obj0, bool value) => ((ViewAttributes) obj0).Visible = value;

    internal static bool JsGlh5oNdgs5eKL5HbDk([In] object obj0) => ((ViewAttributes) obj0).Visible;

    internal static object dGsjiboNlrAw4uh3N9Cj([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static bool NYXknPoNrTNUICuxgU5j([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}

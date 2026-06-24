// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormViewItemTransformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbar;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Преобразователь представления</summary>
  /// <remarks>Используется в динамических формах</remarks>
  [Serializable]
  public class FormViewItemTransformation : ViewItemTransformation
  {
    /// <summary>Список преобразований</summary>
    private readonly List<ViewItemTransformation> items;
    internal static FormViewItemTransformation tK6gEso1WwlRbaFkuXRu;

    /// <summary>Имя преобразуемой формы</summary>
    [XmlElement("FormName")]
    public string FormName
    {
      get => this.\u003CFormName\u003Ek__BackingField;
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
              this.\u003CFormName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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
    /// Новый уникальный идентификатор формы (если форма является дочерней)
    /// </summary>
    public Guid NewFormUid
    {
      get => this.\u003CNewFormUid\u003Ek__BackingField;
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
              this.\u003CNewFormUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeNewFormUid() => FormViewItemTransformation.Cn1qCYo1hWU7AvgYnOUQ(this.NewFormUid, Guid.Empty);

    /// <summary>Новое имя формы</summary>
    [DefaultValue(null)]
    public string NewFormName
    {
      get => this.\u003CNewFormName\u003Ek__BackingField;
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
              this.\u003CNewFormName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Новое отображаемое имя формы</summary>
    [DefaultValue(null)]
    public string NewFormDisplayName
    {
      get => this.\u003CNewFormDisplayName\u003Ek__BackingField;
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
              this.\u003CNewFormDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    public List<ViewItemTransformation> Items => this.items;

    [DefaultValue(null)]
    public ToolbarItemTransformation ToolbarTransformation
    {
      get => this.\u003CToolbarTransformation\u003Ek__BackingField;
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
              this.\u003CToolbarTransformation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    public FormViewItemTransformation()
    {
      FormViewItemTransformation.ufhadxo1GG51oLVg4BVP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.items = new List<ViewItemTransformation>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override void Apply(ViewItem formView)
    {
      int num1 = 3;
      while (true)
      {
        List<ViewItemTransformation>.Enumerator enumerator;
        FormViewItem formViewItem;
        EleWise.ELMA.Model.Views.Toolbar.Toolbar rootItem;
        EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar;
        switch (num1)
        {
          case 1:
label_28:
            if (!FormViewItemTransformation.lcgJVpo1CQruMm4cObeo((object) this.NewFormName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 5;
              continue;
            }
            goto case 9;
          case 2:
            if (this.NewFormUid != Guid.Empty)
            {
              num1 = 8;
              continue;
            }
            goto case 15;
          case 3:
            formViewItem = formView as FormViewItem;
            num1 = 2;
            continue;
          case 4:
          case 11:
          case 18:
            enumerator = this.items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 5:
            FormViewItemTransformation.hiTWado1vooGTfUqui8A((object) formView, (object) this.NewFormName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 3 : 9;
            continue;
          case 6:
            if (!((IEnumerable<ToolbarItem>) FormViewItemTransformation.r2HYuQo1fqaJsttgYH8O((object) rootItem)).Any<ToolbarItem>())
            {
              num1 = 12;
              continue;
            }
            goto case 16;
          case 7:
            FormViewItemTransformation.NclZUDo18nNFmFoCE3G6((object) (FormViewItem) formView, (object) this.NewFormDisplayName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 10;
            continue;
          case 8:
            FormViewItemTransformation.GhvL3xo1EwJLayV0bQWm((object) formView, this.NewFormUid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 15 : 9;
            continue;
          case 9:
            if (string.IsNullOrEmpty(this.NewFormDisplayName))
            {
              num1 = 14;
              continue;
            }
            goto case 7;
          case 10:
            goto label_38;
          case 12:
            rootItem = (EleWise.ELMA.Model.Views.Toolbar.Toolbar) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 6 : 16;
            continue;
          case 13:
            toolbar = new EleWise.ELMA.Model.Views.Toolbar.Toolbar();
            break;
          case 14:
            goto label_16;
          case 15:
            if (formViewItem == null)
            {
              num1 = 18;
              continue;
            }
            goto case 17;
          case 16:
            FormViewItemTransformation.SnfGIyo1Q0PCXvXG459h((object) formViewItem, (object) rootItem);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 3;
            continue;
          case 17:
            if (this.ToolbarTransformation == null)
            {
              num1 = 11;
              continue;
            }
            goto case 20;
          case 19:
            this.ToolbarTransformation.Apply((ToolbarItem) rootItem);
            num1 = 6;
            continue;
          case 20:
            toolbar = formViewItem.Toolbar;
            if (toolbar == null)
            {
              num1 = 13;
              continue;
            }
            break;
          default:
            try
            {
label_8:
              if (enumerator.MoveNext())
                goto label_5;
              else
                goto label_9;
label_4:
              ViewItemTransformation current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (current != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 4 : 3;
                      continue;
                    }
                    goto label_8;
                  case 2:
                    goto label_8;
                  case 3:
                    goto label_5;
                  case 4:
                    current.Apply(formView);
                    num2 = 2;
                    continue;
                  default:
                    goto label_28;
                }
              }
label_5:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
              {
                num2 = 0;
                goto label_4;
              }
              else
                goto label_4;
label_9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              goto label_4;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
        rootItem = toolbar;
        num1 = 19;
      }
label_38:
      return;
label_16:;
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
      foreach (BaseTransformation<ViewItem, Guid> baseTransformation in this.items)
      {
        IEnumerable<string> localizableStrings3 = baseTransformation.GetLocalizableStrings();
        if (localizableStrings3 != null)
        {
          foreach (string str in localizableStrings3)
          {
            if (!localizableStrings1.Contains(str))
              localizableStrings1.Add(str);
          }
        }
      }
      return (IEnumerable<string>) localizableStrings1;
    }

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public override void ApplyLocalization()
    {
      int num1 = 1;
      List<ViewItemTransformation>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            FormViewItemTransformation.D30Hcjo1ZL3OpsZuTmSU((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_13;
          default:
            enumerator = this.items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
            continue;
        }
      }
label_13:
      return;
label_4:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_7;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_6;
          default:
            goto label_8;
        }
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
        goto label_5;
label_8:
        enumerator.Current.ApplyLocalization();
        num2 = 2;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    internal static bool fR8Gayo1o5DgpNqpCs73() => FormViewItemTransformation.tK6gEso1WwlRbaFkuXRu == null;

    internal static FormViewItemTransformation Ql1qBto1bI1Y9a8SJ5Gr() => FormViewItemTransformation.tK6gEso1WwlRbaFkuXRu;

    internal static bool Cn1qCYo1hWU7AvgYnOUQ([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void ufhadxo1GG51oLVg4BVP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void GhvL3xo1EwJLayV0bQWm([In] object obj0, Guid value) => ((ViewItem) obj0).Uid = value;

    internal static object r2HYuQo1fqaJsttgYH8O([In] object obj0) => (object) ((RootToolbarItem) obj0).Items;

    internal static void SnfGIyo1Q0PCXvXG459h([In] object obj0, [In] object obj1) => ((FormViewItem) obj0).Toolbar = (EleWise.ELMA.Model.Views.Toolbar.Toolbar) obj1;

    internal static bool lcgJVpo1CQruMm4cObeo([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void hiTWado1vooGTfUqui8A([In] object obj0, [In] object obj1) => ((ViewItem) obj0).Name = (string) obj1;

    internal static void NclZUDo18nNFmFoCE3G6([In] object obj0, [In] object obj1) => ((FormViewItem) obj0).DisplayName = (string) obj1;

    internal static void D30Hcjo1ZL3OpsZuTmSU([In] object obj0) => __nonvirtual (((BaseTransformation<ViewItem, Guid>) obj0).ApplyLocalization());
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyViewItemBuilder`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  public class PropertyViewItemBuilder<TModel, TValue>
  {
    private ClassMetadata classMetadata;
    private IPropertyMetadata propertyMetadata;
    private PropertyViewItem[] viewItems;
    private PropertyViewInfoContainer propertyContainer;
    private static object Sl36GToPzDLwkLF0Qy6C;

    public PropertyViewItemBuilder(
      ClassMetadata classMetadata,
      IPropertyMetadata propertyMetadata,
      PropertyViewItem viewItem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(classMetadata, propertyMetadata, new PropertyViewItem[1]
      {
        viewItem
      });
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Validation = new ValidationPropertyViewItemBuilder<TModel, TValue>(classMetadata, propertyMetadata, new PropertyViewItem[1]
            {
              viewItem
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItems">Элементы отображения свойства</param>
    public PropertyViewItemBuilder(
      ClassMetadata classMetadata,
      IPropertyMetadata propertyMetadata,
      PropertyViewItem[] viewItems)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(classMetadata, propertyMetadata, viewItems, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItems">Элементы отображения свойства</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    /// <exception cref="T:System.ArgumentNullException"></exception>
    public PropertyViewItemBuilder(
      ClassMetadata classMetadata,
      IPropertyMetadata propertyMetadata,
      PropertyViewItem[] viewItems,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.viewItems = viewItems;
            num = 4;
            continue;
          case 2:
            this.propertyContainer = propertyContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 3:
            this.classMetadata = classMetadata;
            num = 5;
            continue;
          case 4:
            this.Validation = new ValidationPropertyViewItemBuilder<TModel, TValue>(classMetadata, propertyMetadata, viewItems, propertyContainer);
            num = 2;
            continue;
          case 5:
            this.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    public PropertyViewItemBuilder<TModel, TValue> ReadOnly(bool readOnly = true)
    {
      this.UpdatePropertyInfo((Action<PropertyViewInfo>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              info.ReadOnly = new bool?(readOnly);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      this.UpdateViewItems((Action<PropertyViewItem>) (i =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              i.Attributes.ReadOnly = new bool?(readOnly);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              i.SetReadOnly(readOnly);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }));
      return this;
    }

    public PropertyViewItemBuilder<TModel, TValue> Required(bool required = true)
    {
      this.UpdatePropertyInfo((Action<PropertyViewInfo>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              info.Required = new bool?(required);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      this.UpdateViewItems((Action<PropertyViewItem>) (i =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              i.Attributes.Required = required;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return this;
    }

    public PropertyViewItemBuilder<TModel, TValue> Visible(bool visible = true)
    {
      this.UpdatePropertyInfo((Action<PropertyViewInfo>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              info.Visible = new bool?(visible);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      this.UpdateViewItems((Action<PropertyViewItem>) (i =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              i.SetVisible(visible);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              i.Attributes.Visible = visible;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }));
      return this;
    }

    public ValidationPropertyViewItemBuilder<TModel, TValue> Validation { get; private set; }

    private void UpdatePropertyInfo(Action<PropertyViewInfo> action)
    {
      if (this.propertyContainer == null)
        return;
      if (this.propertyMetadata != null)
      {
        Update(this.propertyMetadata.Name);
      }
      else
      {
        if (this.classMetadata == null)
          return;
        foreach (NamedMetadata property in this.classMetadata.Properties)
          Update(property.Name);
      }

      void Update(string propertyName)
      {
        int num = 4;
        PropertyViewInfo propertyViewInfo;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              action(propertyViewInfo);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              if (propertyViewInfo != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            case 4:
              propertyViewInfo = this.propertyContainer.Get(propertyName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 3;
              continue;
            default:
              goto label_9;
          }
        }
label_5:
        return;
label_8:
        return;
label_9:
        return;
label_2:;
      }
    }

    private void UpdateViewItems(Action<PropertyViewItem> action)
    {
      if (this.viewItems == null)
        return;
      foreach (PropertyViewItem viewItem in this.viewItems)
      {
        if (viewItem != null)
          action(viewItem);
      }
    }

    internal static bool q3G3b8o1FbMmnpUl7LGq() => PropertyViewItemBuilder<TModel, TValue>.Sl36GToPzDLwkLF0Qy6C == null;

    internal static object eOfqFYo1BUc1lGPZWNFU() => PropertyViewItemBuilder<TModel, TValue>.Sl36GToPzDLwkLF0Qy6C;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ValidationPropertyViewItemBuilder`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Views
{
  public class ValidationPropertyViewItemBuilder<TModel, TValue>
  {
    private ClassMetadata classMetadata;
    private IPropertyMetadata propertyMetadata;
    private PropertyViewItem[] viewItems;
    private PropertyViewInfoContainer propertyContainer;
    private static object eTbHC1oTk3JbI3RlsIGO;

    public ValidationPropertyViewItemBuilder(
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
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItems">Элементы отображения свойства</param>
    public ValidationPropertyViewItemBuilder(
      ClassMetadata classMetadata,
      IPropertyMetadata propertyMetadata,
      PropertyViewItem[] viewItems)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(classMetadata, propertyMetadata, viewItems, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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
    public ValidationPropertyViewItemBuilder(
      ClassMetadata classMetadata,
      IPropertyMetadata propertyMetadata,
      PropertyViewItem[] viewItems,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.propertyContainer = propertyContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          case 2:
            this.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 1;
            continue;
          case 3:
            this.viewItems = viewItems;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          case 4:
            this.classMetadata = classMetadata;
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    public ValidationPropertyViewItemBuilder<TModel, TValue> Ok()
    {
      this.UpdatePropertyInfo((Action<PropertyViewInfo>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              info.IsValid = new bool?(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              info.ValidationMessage = "";
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
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
              i.Attributes.ValidationError = "";
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    public ValidationPropertyViewItemBuilder<TModel, TValue> Error(string message)
    {
      if (string.IsNullOrEmpty(message))
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487266688));
      this.UpdatePropertyInfo((Action<PropertyViewInfo>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              info.IsValid = new bool?(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              info.ValidationMessage = message;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
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
              i.Attributes.ValidationError = message;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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
        int num = 2;
        PropertyViewInfo propertyViewInfo;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              if (propertyViewInfo == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 3;
                continue;
              }
              action(propertyViewInfo);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 2:
              propertyViewInfo = this.propertyContainer.Get(propertyName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_5:
        return;
label_8:;
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

    internal static bool AC0QiCoTnFBZoL2kIUNw() => ValidationPropertyViewItemBuilder<TModel, TValue>.eTbHC1oTk3JbI3RlsIGO == null;

    internal static object GPLuUhoTODYteTVhvqUa() => ValidationPropertyViewItemBuilder<TModel, TValue>.eTbHC1oTk3JbI3RlsIGO;
  }
}

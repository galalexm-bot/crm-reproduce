// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormViewBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Построитель представления для модели</summary>
  /// <typeparam name="TModel">Тип модели</typeparam>
  public class FormViewBuilder<TModel>
  {
    private RootViewItem view;
    private ClassMetadata metadata;
    private IFormNotifier notifier;
    private PropertyViewInfoContainer propertyContainer;
    private static object FPQDKgoPjRxZF5YGg0GG;

    /// <summary>Ctor</summary>
    /// <param name="view">Представление</param>
    /// <param name="metadata">Метаданные</param>
    public FormViewBuilder(RootViewItem view, ClassMetadata metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(view, metadata, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="view">Представление</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public FormViewBuilder(
      RootViewItem view,
      ClassMetadata metadata,
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
          case 1:
            goto label_2;
          case 2:
            this.metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 3;
            continue;
          case 3:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            }
            this.view = view;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
            continue;
          case 4:
            this.propertyContainer = propertyContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333754668));
    }

    /// <summary>Вывести редактор свойства</summary>
    /// <typeparam name="TValue">Тип значения свойства</typeparam>
    /// <param name="expression">Выражение, описывающее свойство, название которого нужно отобразить</param>
    /// <returns>MvcHtmlString</returns>
    public PropertyViewItemBuilder<TModel, TValue> For<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.For<TValue>(expression, (string) null);
    }

    public PropertyViewItemBuilder<TModel, TValue> For<TValue>(
      Expression<Func<TModel, TValue>> expression,
      string name)
    {
      MemberExpression memberExpression = expression.Body as MemberExpression;
      if (memberExpression == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647773234), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633621787)));
      IPropertyMetadata propertyMetadata = (this.metadata is EntityMetadata ? ((EntityMetadata) this.metadata).GetPropertiesAndTableParts() : (IEnumerable<IPropertyMetadata>) this.metadata.Properties.Cast<IPropertyMetadata>().ToList<IPropertyMetadata>()).FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => p.Name == memberExpression.Member.Name));
      if (propertyMetadata == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146371591), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867076827), (object) memberExpression.Member.Name));
      if (this.view != null && string.IsNullOrWhiteSpace(name) && this.view.GetAllProperties(false).All<PropertyViewItem>((Func<PropertyViewItem, bool>) (p => p.PropertyUid != propertyMetadata.PropertyUid)))
      {
        DefaultContainerViewItem containerViewItem = this.view.GetAllItems(false).OfType<DefaultContainerViewItem>().OrderBy<DefaultContainerViewItem, int>((Func<DefaultContainerViewItem, int>) (i => i.CheckPropertyAddOrder)).FirstOrDefault<DefaultContainerViewItem>((Func<DefaultContainerViewItem, bool>) (i => i.CheckPropertyAdd(this.metadata)));
        if (containerViewItem != null)
        {
          PropertyViewItem propertyViewItem = containerViewItem.CreatePropertyViewItem();
          propertyViewItem.PropertyUid = propertyMetadata.PropertyUid;
          RootViewItem rootViewItem = containerViewItem.Parent;
          if (rootViewItem is ColumnsLayoutViewItem)
            rootViewItem = (RootViewItem) rootViewItem.Items.FirstOrDefault<ViewItem>((Func<ViewItem, bool>) (i => !i.Hide));
          (rootViewItem is ColumnViewItem ? rootViewItem : this.view).Items.Add((ViewItem) propertyViewItem);
        }
        else
        {
          PropertyViewItem propertyViewItem = new PropertyViewItem();
          propertyViewItem.PropertyUid = propertyMetadata.PropertyUid;
          propertyViewItem.Hide = true;
          this.view.Items.Add((ViewItem) propertyViewItem);
        }
      }
      IPropertyMetadata propertyMetadata1 = propertyMetadata;
      RootViewItem view = this.view;
      PropertyViewItem[] array = view != null ? view.GetAllProperties(false).Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
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
                goto label_3;
              case 2:
                if (string.IsNullOrWhiteSpace(name))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              case 3:
                goto label_5;
              case 4:
                if (p.PropertyUid == propertyMetadata.PropertyUid)
                  goto case 2;
                else
                  goto label_7;
              default:
                goto label_4;
            }
          }
label_7:
          num1 = 3;
        }
label_3:
        return p.Name == name;
label_4:
        return true;
label_5:
        return false;
      })).ToArray<PropertyViewItem>() : (PropertyViewItem[]) null;
      PropertyViewInfoContainer propertyContainer = this.propertyContainer;
      return new PropertyViewItemBuilder<TModel, TValue>((ClassMetadata) null, propertyMetadata1, array, propertyContainer);
    }

    public PropertyViewItemBuilder<TModel, object> ForAll()
    {
      ClassMetadata metadata = this.metadata;
      RootViewItem view = this.view;
      PropertyViewItem[] array = view != null ? view.GetAllProperties().ToArray<PropertyViewItem>() : (PropertyViewItem[]) null;
      PropertyViewInfoContainer propertyContainer = this.propertyContainer;
      return new PropertyViewItemBuilder<TModel, object>(metadata, (IPropertyMetadata) null, array, propertyContainer);
    }

    /// <summary>Сервис пользовательских оповещений на текущей форме</summary>
    public IFormNotifier Notifier
    {
      get
      {
        int num = 1;
        IFormNotifier contextFormNotifier;
        IFormNotifier notifier;
        while (true)
        {
          switch (num)
          {
            case 1:
              notifier = this.notifier;
              if (notifier == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.notifier = contextFormNotifier = DynamicFormHelper.GetContextFormNotifier();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return notifier;
label_6:
        return contextFormNotifier;
      }
    }

    public void ClosePopup() => DynamicFormHelper.ClosePopup = true;

    internal static bool irmY2yoPYVR0ZnZAC1rJ() => FormViewBuilder<TModel>.FPQDKgoPjRxZF5YGg0GG == null;

    internal static object lAi8pKoPLHGLPgRAHvNA() => FormViewBuilder<TModel>.FPQDKgoPjRxZF5YGg0GG;
  }
}

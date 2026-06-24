// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.FormViewModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель формы</summary>
  /// <typeparam name="TContext">Тип контекста</typeparam>
  public abstract class FormViewModel<TContext> : IFormViewModel where TContext : IEntity
  {
    internal IFormPartDescriptor _descriptor;
    private FormViewItem _view;
    internal static object M6AKpYBoD1WIgBZe5KYZ;

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор</param>
    public FormViewModel(IFormPartDescriptor descriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(descriptor, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public FormViewModel(
      IFormPartDescriptor descriptor,
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
            this._descriptor = descriptor;
            num = 5;
            continue;
          case 2:
            this.PropertyContainer = propertyContainer;
            num = 4;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107982124));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
            continue;
          case 4:
            this.View = ClassSerializationHelper.CloneObjectByXml<FormViewItem>(descriptor.Metadata.View);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 5:
            this.Header = descriptor.FormDescriptor.Metadata.DisplayName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 6;
            continue;
          case 6:
            this.Context = (TContext) Activator.CreateInstance(this._descriptor.ContextType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор</param>
    /// <param name="context">Контекст</param>
    /// <param name="view">Форма</param>
    public FormViewModel(IFormPartDescriptor descriptor, TContext context, FormViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(descriptor, context, view, (PropertyViewInfoContainer) null);
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор</param>
    /// <param name="context">Контекст</param>
    /// <param name="view">Форма</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public FormViewModel(
      IFormPartDescriptor descriptor,
      TContext context,
      FormViewItem view,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822911278));
      Contract.ArgumentNotNull((object) context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113880085));
      Contract.ArgumentNotNull((object) view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146531935));
      this._descriptor = descriptor;
      this.Header = descriptor.FormDescriptor.Metadata.DisplayName;
      this.Context = context;
      this.PropertyContainer = propertyContainer;
      this.View = view;
    }

    /// <summary>Заголовок формы</summary>
    public string Header
    {
      get => this.\u003CHeader\u003Ek__BackingField;
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
              this.\u003CHeader\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Контекст</summary>
    public TContext Context { get; private set; }

    /// <summary>Построитель представления</summary>
    public FormViewBuilder<TContext> Form { get; protected set; }

    IEntity IFormViewModel.Context
    {
      get => (IEntity) this.Context;
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
              this.Context = (TContext) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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

    FormViewItem IFormViewModel.View
    {
      get => this.View;
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
              this.View = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    IFormPartDescriptor IFormViewModel.Descriptor => this._descriptor;

    FormResult IFormViewModel.Result => this.Result;

    /// <summary>Представление</summary>
    protected virtual FormViewItem View
    {
      get => this._view;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._view = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.Form = value != null ? new FormViewBuilder<TContext>((RootViewItem) value, (ClassMetadata) this._descriptor.Metadata.Context, this.PropertyContainer) : (FormViewBuilder<TContext>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Результат выполнения</summary>
    protected FormResult Result
    {
      get => this.\u003CResult\u003Ek__BackingField;
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
              this.\u003CResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Дескриптор</summary>
    protected IFormPartDescriptor Descriptor => this._descriptor;

    /// <summary>Контейнер информации о свойствах на форме</summary>
    protected PropertyViewInfoContainer PropertyContainer { get; }

    internal static bool PpPdIYBotkVCamQG7QKB() => FormViewModel<TContext>.M6AKpYBoD1WIgBZe5KYZ == null;

    internal static object MDgOo2BowAw2oHGVt6b6() => FormViewModel<TContext>.M6AKpYBoD1WIgBZe5KYZ;
  }
}

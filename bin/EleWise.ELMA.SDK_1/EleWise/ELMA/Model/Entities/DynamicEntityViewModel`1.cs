// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.DynamicEntityViewModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;

namespace EleWise.ELMA.Model.Entities
{
  public class DynamicEntityViewModel<T> : EntityModel<T> where T : class, IEntity
  {
    protected string viewItemId;
    protected FormViewItem view;
    protected DynamicFormSettings dynamicFormSettings;
    internal static object f5Z2dkh85736elRHAbde;

    /// <summary>Конструктор</summary>
    /// <param name="model">Модель</param>
    /// <param name="viewType">Тип представления</param>
    public DynamicEntityViewModel(T model, ViewType viewType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(model);
      this.ViewType = viewType;
      if ((object) this.Entity != null)
        return;
      this.Entity = InterfaceActivator.Create<T>();
    }

    /// <summary>Конструктор</summary>
    public DynamicEntityViewModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Entity = InterfaceActivator.Create<T>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="entity"></param>
    public DynamicEntityViewModel(T entity)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Entity = entity;
    }

    /// <summary>Настройки динамической формы</summary>
    public virtual DynamicFormSettings DynamicFormSettings
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.dynamicFormSettings.FormId = this.FormId;
              num = 5;
              continue;
            case 2:
              this.dynamicFormSettings = new DynamicFormSettings()
              {
                DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
                DynamicFormsProviderData = EntityDynamicFormProvider.CreateData((IEntity) this.Entity, this.ViewType, this.ItemType),
                ViewProviderUid = EntityObjectViewItemProvider.UID,
                ViewItemId = this.ViewItemId
              };
              num = 6;
              continue;
            case 3:
              if (this.dynamicFormSettings == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 2;
                continue;
              }
              goto label_9;
            case 4:
              goto label_9;
            case 5:
              this.GetViewItem();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 6:
              if (!string.IsNullOrEmpty(this.FormId))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                continue;
              }
              goto case 5;
            default:
              goto label_6;
          }
        }
label_6:
        return this.dynamicFormSettings;
label_9:
        return this.dynamicFormSettings;
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
              this.dynamicFormSettings = value;
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

    /// <summary>Форма, используемая для представления модели.</summary>
    /// <remarks>
    /// Форма достаётся из метаданных, затем выполняется скрипт при загрузке формы.
    /// Полученная форма сохраняется и при следующих вызовах достаётся именно она.
    /// </remarks>
    public virtual FormViewItem View
    {
      get => this.GetViewItem();
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
              this.view = value;
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

    /// <summary>Идентификатор представления</summary>
    public virtual string ViewItemId
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!string.IsNullOrEmpty(this.viewItemId))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              }
              this.viewItemId = EntityObjectViewItemProvider.CreateViewItemId((IEntity) this.Entity, this.ViewType, this.ItemType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return this.viewItemId;
label_5:
        return this.viewItemId;
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
              this.viewItemId = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>UID формы</summary>
    public string FormId
    {
      get => this.\u003CFormId\u003Ek__BackingField;
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
              this.\u003CFormId\u003Ek__BackingField = value;
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

    /// <summary>Тип представления</summary>
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

    /// <summary>Тип элемента</summary>
    public virtual ItemType ItemType => ItemType.Default;

    /// <summary>Уникальный идентификатор формы</summary>
    public Guid? FormUid { get; set; }

    /// <summary>Форма только для чтения</summary>
    public bool FormReadOnly
    {
      get => this.\u003CFormReadOnly\u003Ek__BackingField;
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
              this.\u003CFormReadOnly\u003Ek__BackingField = value;
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

    private FormViewItem GetViewItem()
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        Guid? formUid;
        ClassMetadata metadata;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              formUid = this.FormUid;
              num2 = 15;
              continue;
            case 2:
              if (this.FormReadOnly)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 11 : 5;
                continue;
              }
              goto label_11;
            case 3:
            case 12:
            case 23:
              goto label_13;
            case 4:
              formUid = this.FormUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 1;
              continue;
            case 5:
              this.ViewType = ViewType.Display;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 18;
              continue;
            case 6:
              if (this.view.RuntimeVersion != RuntimeVersion.Version1)
              {
                num2 = 21;
                continue;
              }
              goto case 16;
            case 7:
              this.FormReadOnly = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 2;
              continue;
            case 8:
              goto label_17;
            case 9:
              if (this.view != null)
              {
                num2 = 8;
                continue;
              }
              type = EntityHelper.GetType((object) this.Entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 13 : 5;
              continue;
            case 10:
              if (!(formUid.Value != Guid.Empty))
              {
                num2 = 3;
                continue;
              }
              goto case 20;
            case 11:
              goto label_12;
            case 13:
              metadata = (ClassMetadata) MetadataLoader.LoadMetadata(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
            case 14:
            case 21:
            case 22:
              if (this.view == null)
              {
                num2 = 19;
                continue;
              }
              if (this.ViewType == ViewType.Display)
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 15:
              if (!formUid.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 23 : 3;
                continue;
              }
              goto case 4;
            case 16:
              this.view = DynamicFormHelper.FormWithExecutedLoadScripts(this.view, (IEntity) this.Entity, metadata, this.DynamicFormSettings);
              num2 = 22;
              continue;
            case 18:
              goto label_11;
            case 19:
              goto label_22;
            case 20:
              this.view = metadata.GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (q => q.Uid == this.FormUid.Value));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              if (this.view == null)
              {
                num2 = 14;
                continue;
              }
              goto case 6;
          }
        }
label_12:
        this.view = (FormViewItem) this.view.CloneAsReadOnly();
        num1 = 5;
        continue;
label_13:
        this.view = EntityObjectViewItemProvider.GetViewItem(type, this.ViewType, this.ItemType) as FormViewItem;
        num1 = 17;
      }
label_11:
      return this.view;
label_17:
      return this.view;
label_22:
      return (FormViewItem) null;
    }

    internal static bool CJ9N6sh8jg0uMOtHBUsb() => DynamicEntityViewModel<T>.f5Z2dkh85736elRHAbde == null;

    internal static object dG9p5Nh8YafUDCb0WMWB() => DynamicEntityViewModel<T>.f5Z2dkh85736elRHAbde;
  }
}

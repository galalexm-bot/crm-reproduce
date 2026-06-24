// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewAttributes
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Атрибуты представления модели</summary>
  [Serializable]
  public class ViewAttributes
  {
    private bool? readOnly;
    internal static ViewAttributes iyBqQio3PLKPRBUDrKsl;

    /// <summary>Ctor</summary>
    public ViewAttributes()
    {
      ViewAttributes.DyLVkeo338QtrDm1MxNl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 11;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.WrapByTableRow = true;
            num = 10;
            continue;
          case 2:
            this.OnChangeScriptName = "";
            num = 4;
            continue;
          case 3:
            this.Class = (string) ViewAttributes.xUM1JPo3pq13JssERmoL(1113862659 ^ 1114004425);
            num = 7;
            continue;
          case 4:
            this.OnChangeCodeType = CodeType.Server;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 13 : 4;
            continue;
          case 5:
            this.Placeholder = "";
            num = 12;
            continue;
          case 6:
            this.ViewStyle = ModelViewStyle.Default;
            num = 9;
            continue;
          case 7:
            this.ValidationMessage = true;
            num = 6;
            continue;
          case 8:
            goto label_2;
          case 9:
            this.Prefix = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
            continue;
          case 10:
            this.ValueCellColspan = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 2;
            continue;
          case 11:
            this.ShowDescription = false;
            num = 3;
            continue;
          case 12:
            this.Tooltip = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 14 : 4;
            continue;
          case 13:
            this.Visible = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 14:
            this.ValidationError = "";
            num = 8;
            continue;
          default:
            this.ShowEmpty = false;
            num = 5;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Название на форме</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
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
    }

    /// <summary>Локализованное название на форме</summary>
    public string LocalizableName => (string) ViewAttributes.w8S36no3apXpglZPiC2X((object) this.Name);

    /// <summary>Описание на форме</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Globalization.Localizable]
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Локализованное название на форме</summary>
    public string LocalizableDescription => (string) ViewAttributes.w8S36no3apXpglZPiC2X((object) this.Description);

    /// <summary>Путь свойства</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Globalization.Localizable]
    public string PropertyPath
    {
      get => this.\u003CPropertyPath\u003Ek__BackingField;
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
              this.\u003CPropertyPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    /// <summary>Локализованный путь свойства</summary>
    public string LocalizablePropertyPath => EleWise.ELMA.SR.T(this.PropertyPath);

    /// <summary>Только для чтения</summary>
    public bool? ReadOnly
    {
      get
      {
        if (this.OverrideReadOnly)
        {
          this.OverrideReadOnly = false;
          this.readOnly = new bool?(((int) this.readOnly ?? 0) != 0);
        }
        return this.readOnly;
      }
      set => this.readOnly = value;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ViewAttributes.ReadOnly" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ViewAttributes.ReadOnly" /></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReadOnly()
    {
      int num = 1;
      bool? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            nullable = this.ReadOnly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return nullable.HasValue;
    }

    /// <summary>
    /// Если True, то глобальный признак "Только для чтения" из формы не учитывается
    /// </summary>
    /// <remarks>
    /// Данное свойство больше не используется и будет удалено в одной из следующих версий. Используйте свойство ReadOnly.
    /// Атрибут <see cref="T:System.ObsoleteAttribute" /> использовать нельзя, так как это нарушает десериализацию legacy-форм на существующих конфигурациях
    /// </remarks>
    [DefaultValue(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool OverrideReadOnly
    {
      get => this.\u003COverrideReadOnly\u003Ek__BackingField;
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
              this.\u003COverrideReadOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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

    /// <summary>Только для чтения для блока и всех его полей</summary>
    [DefaultValue(false)]
    public bool FullReadOnly
    {
      get => this.\u003CFullReadOnly\u003Ek__BackingField;
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
              this.\u003CFullReadOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Обязательно для заполнения</summary>
    [DefaultValue(false)]
    public bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
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
              this.\u003CRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

    /// <summary>Видимость</summary>
    [DefaultValue(true)]
    public bool Visible
    {
      get => this.\u003CVisible\u003Ek__BackingField;
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
              this.\u003CVisible\u003Ek__BackingField = value;
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

    /// <summary>Поле ввода блокировано</summary>
    [DefaultValue(false)]
    public bool Disabled
    {
      get => this.\u003CDisabled\u003Ek__BackingField;
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
              this.\u003CDisabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    /// <summary>Выводить сообщение об ошибке</summary>
    [DefaultValue(true)]
    public bool ValidationMessage
    {
      get => this.\u003CValidationMessage\u003Ek__BackingField;
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
              this.\u003CValidationMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Само сообщение об ошибке</summary>
    [DefaultValue("")]
    public string ValidationError
    {
      get => this.\u003CValidationError\u003Ek__BackingField;
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
              this.\u003CValidationError\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Имя сценария для валидации</summary>
    [DefaultValue("")]
    public string ValidationScriptName
    {
      get => this.\u003CValidationScriptName\u003Ek__BackingField;
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
              this.\u003CValidationScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Скрыть текст валидации</summary>
    [DefaultValue(false)]
    public bool HideValidation
    {
      get => this.\u003CHideValidation\u003Ek__BackingField;
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
              this.\u003CHideValidation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Имя шаблона отображения</summary>
    [DefaultValue(null)]
    public string TemplateName
    {
      get => this.\u003CTemplateName\u003Ek__BackingField;
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
              this.\u003CTemplateName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Настройки типа данных</summary>
    [DefaultValue(null)]
    public TypeSettings TypeSettings
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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
    /// Делегат создания параметров <see cref="P:EleWise.ELMA.Model.Views.ViewAttributes.TypeSettings" />, вместо создания настроек из метаданных
    /// </summary>
    [XmlIgnore]
    public Func<TypeSettings> TypeSettingsCreator { get; set; }

    /// <summary>
    /// Делегат установки дополнительных параметров <see cref="P:EleWise.ELMA.Model.Views.ViewAttributes.TypeSettings" />, после создания настроек из метаданных
    /// </summary>
    [XmlIgnore]
    public Action<TypeSettings> TypeSettingsAction { get; set; }

    /// <summary>Показывать описание класса</summary>
    [DefaultValue(false)]
    public bool ShowDescription
    {
      get => this.\u003CShowDescription\u003Ek__BackingField;
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
              this.\u003CShowDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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
    /// Навешивается на TD для Html.Property и Html.EditableProperty
    /// </summary>
    [DefaultValue("dft_table_td")]
    public string Class
    {
      get => this.\u003CClass\u003Ek__BackingField;
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
              this.\u003CClass\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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
    /// Навешивается на TR для Html.Property и Html.EditableProperty
    /// </summary>
    [DefaultValue(null)]
    public string TrClass
    {
      get => this.\u003CTrClass\u003Ek__BackingField;
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
              this.\u003CTrClass\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>Стиль для метки</summary>
    [DefaultValue(null)]
    public string LabelStyle
    {
      get => this.\u003CLabelStyle\u003Ek__BackingField;
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
              this.\u003CLabelStyle\u003Ek__BackingField = value;
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

    /// <summary>Стиль для значения</summary>
    [DefaultValue(null)]
    public string ValueStyle
    {
      get => this.\u003CValueStyle\u003Ek__BackingField;
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
              this.\u003CValueStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Префикс для имени поля</summary>
    [DefaultValue("")]
    public string Prefix
    {
      get => this.\u003CPrefix\u003Ek__BackingField;
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
              this.\u003CPrefix\u003Ek__BackingField = value;
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

    /// <summary>Множественный выбор</summary>
    [DefaultValue(false)]
    public bool MultiSelect
    {
      get => this.\u003CMultiSelect\u003Ek__BackingField;
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
              this.\u003CMultiSelect\u003Ek__BackingField = value;
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

    /// <summary>Обновлять каждый раз окно поиска при его открытии.</summary>
    [DefaultValue(false)]
    public bool RefreshSelectPopup
    {
      get => this.\u003CRefreshSelectPopup\u003Ek__BackingField;
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
              this.\u003CRefreshSelectPopup\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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
    /// Уникальный идентификатор метаданных родительского объекта для блока
    /// </summary>
    [DefaultValue(null)]
    public Guid TablePartParentMetadataUid
    {
      get => this.\u003CTablePartParentMetadataUid\u003Ek__BackingField;
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
              this.\u003CTablePartParentMetadataUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Проверка необходимости сериализации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTablePartParentMetadataUid() => ViewAttributes.NfOTB7o3D4hkOiQpUc18(this.TablePartParentMetadataUid, Guid.Empty);

    /// <summary>Идентификатор родительского объекта для блока</summary>
    [DefaultValue(null)]
    public object TablePartParentId
    {
      get => this.\u003CTablePartParentId\u003Ek__BackingField;
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
              this.\u003CTablePartParentId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <summary>Режим отображения модели</summary>
    [DefaultValue(ModelViewStyle.Default)]
    public ModelViewStyle ViewStyle
    {
      get => this.\u003CViewStyle\u003Ek__BackingField;
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
              this.\u003CViewStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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
    /// Генерить hidden со значением поля сущности (даже в режиме отображения)
    /// </summary>
    [DefaultValue(null)]
    public string RenderFiled
    {
      get => this.\u003CRenderFiled\u003Ek__BackingField;
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
              this.\u003CRenderFiled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор веб-формы</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Uid провайдера представления</summary>
    public Guid ViewProviderUid
    {
      get => this.\u003CViewProviderUid\u003Ek__BackingField;
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
              this.\u003CViewProviderUid\u003Ek__BackingField = value;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeViewProviderUid() => ViewAttributes.NfOTB7o3D4hkOiQpUc18(this.ViewProviderUid, Guid.Empty);

    /// <summary>Id представления</summary>
    [DefaultValue(null)]
    public string ViewItemId
    {
      get => this.\u003CViewItemId\u003Ek__BackingField;
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
              this.\u003CViewItemId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор провайдера динамических форм</summary>
    public Guid DynamicFormsProviderUid
    {
      get => this.\u003CDynamicFormsProviderUid\u003Ek__BackingField;
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
              this.\u003CDynamicFormsProviderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    /// <summary>Проверка необходимости сериализации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDynamicFormsProviderUid() => ViewAttributes.NfOTB7o3D4hkOiQpUc18(this.DynamicFormsProviderUid, Guid.Empty);

    /// <summary>Данные для провайдера динамических форм</summary>
    [DefaultValue(null)]
    public string DynamicFormsProviderData
    {
      get => this.\u003CDynamicFormsProviderData\u003Ek__BackingField;
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
              this.\u003CDynamicFormsProviderData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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
    /// Нужно ли обрамлять тегами начала и конца строки таблицы
    /// </summary>
    [DefaultValue(true)]
    public bool WrapByTableRow
    {
      get => this.\u003CWrapByTableRow\u003Ek__BackingField;
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
              this.\u003CWrapByTableRow\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>COLSPAN для ячейки со значением свойства</summary>
    [DefaultValue(1)]
    public int ValueCellColspan
    {
      get => this.\u003CValueCellColspan\u003Ek__BackingField;
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
              this.\u003CValueCellColspan\u003Ek__BackingField = value;
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

    /// <summary>
    /// Uid провайдера для применения фильтрации при выборе сущностей EleWise.ELMA.Web.Mvc.ExtensionPointsIEntityFilterProvider
    /// </summary>
    public Guid EntityFilterProvider
    {
      get => this.\u003CEntityFilterProvider\u003Ek__BackingField;
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
              this.\u003CEntityFilterProvider\u003Ek__BackingField = value;
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

    /// <summary>Проверка необходимости сериализации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEntityFilterProvider() => ViewAttributes.NfOTB7o3D4hkOiQpUc18(this.EntityFilterProvider, Guid.Empty);

    /// <summary>Uid провайдера загрузки сущностей для биндинга модели</summary>
    public Guid EntityModelBinderProvider
    {
      get => this.\u003CEntityModelBinderProvider\u003Ek__BackingField;
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
              this.\u003CEntityModelBinderProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
    public bool ShouldSerializeEntityModelBinderProvider() => ViewAttributes.NfOTB7o3D4hkOiQpUc18(this.EntityModelBinderProvider, Guid.Empty);

    /// <summary>Данные для провайдера фильтрации</summary>
    [DefaultValue(null)]
    public string EntityFilterData
    {
      get => this.\u003CEntityFilterData\u003Ek__BackingField;
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
              this.\u003CEntityFilterData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    /// <summary>Отключить фильтрацию в эксплорере</summary>
    [DefaultValue(false)]
    public bool DisableEntityFilterProivderInExplorer
    {
      get => this.\u003CDisableEntityFilterProivderInExplorer\u003Ek__BackingField;
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
              this.\u003CDisableEntityFilterProivderInExplorer\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

    /// <summary>Имя сценария при изменении значения</summary>
    [DefaultValue("")]
    public string OnChangeScriptName
    {
      get => this.\u003COnChangeScriptName\u003Ek__BackingField;
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
              this.\u003COnChangeScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    /// <summary>Тип сценария при изменении значения</summary>
    [DefaultValue(CodeType.Server)]
    public CodeType OnChangeCodeType
    {
      get => this.\u003COnChangeCodeType\u003Ek__BackingField;
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
              this.\u003COnChangeCodeType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    /// <summary>Отключить динамические формы</summary>
    [DefaultValue(false)]
    public bool DisableDynamicForms
    {
      get => this.\u003CDisableDynamicForms\u003Ek__BackingField;
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
              this.\u003CDisableDynamicForms\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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
    /// Имя сценария при загрузке формы (например элемента блока)
    /// </summary>
    [DefaultValue("")]
    public string OnViewLoadScriptName
    {
      get => this.\u003COnViewLoadScriptName\u003Ek__BackingField;
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
              this.\u003COnViewLoadScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Ширина всплывающего окна</summary>
    [DefaultValue(0)]
    public int PopupWidth
    {
      get => this.\u003CPopupWidth\u003Ek__BackingField;
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
              this.\u003CPopupWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    /// <summary>Показывать, даже если пусто</summary>
    [DefaultValue(false)]
    public bool ShowEmpty
    {
      get => this.\u003CShowEmpty\u003Ek__BackingField;
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
              this.\u003CShowEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Заполнитель (только для типа Строка)</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
    public string Placeholder
    {
      get => this.\u003CPlaceholder\u003Ek__BackingField;
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
              this.\u003CPlaceholder\u003Ek__BackingField = value;
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

    /// <summary>Всплывающая подсказка</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
    public string Tooltip
    {
      get => this.\u003CTooltip\u003Ek__BackingField;
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
              this.\u003CTooltip\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    /// <summary>Является ирархических объектом-родителем</summary>
    [XmlIgnore]
    public bool IsHierarchicalParent => this.HierarchicalChilds != null;

    /// <summary>
    /// Является ирархических объектом-родителем верхнего уровня
    /// </summary>
    [XmlIgnore]
    public bool IsHierarchicalRootParent
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Deep <= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            default:
              if (this.Indent <= 0)
              {
                num = 3;
                continue;
              }
              goto label_6;
          }
        }
label_6:
        return this.HierarchicalParent == null;
label_7:
        return false;
      }
    }

    /// <summary>Список Name зависисмых объектов</summary>
    [XmlIgnore]
    [DefaultValue(null)]
    public List<HierarchicalChild> HierarchicalChilds { get; set; }

    /// <summary>Является зависимым иерархических объектом</summary>
    [XmlIgnore]
    public bool IsHierarchicalChild => this.HierarchicalParent != null;

    /// <summary>Name родительского объкта</summary>
    [DefaultValue(null)]
    public string HierarchicalParent
    {
      get => this.\u003CHierarchicalParent\u003Ek__BackingField;
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
              this.\u003CHierarchicalParent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
    [DefaultValue(0)]
    public int Deep
    {
      get => this.\u003CDeep\u003Ek__BackingField;
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
              this.\u003CDeep\u003Ek__BackingField = value;
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

    [DefaultValue(0)]
    [XmlIgnore]
    public int Indent
    {
      get => this.\u003CIndent\u003Ek__BackingField;
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
              this.\u003CIndent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
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

    internal static void DyLVkeo338QtrDm1MxNl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xUM1JPo3pq13JssERmoL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool IRyUiAo31QG7YvQ4844r() => ViewAttributes.iyBqQio3PLKPRBUDrKsl == null;

    internal static ViewAttributes uioPgfo3Nxud4BRtHSh6() => ViewAttributes.iyBqQio3PLKPRBUDrKsl;

    internal static object w8S36no3apXpglZPiC2X([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool NfOTB7o3D4hkOiQpUc18([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}

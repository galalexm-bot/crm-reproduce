// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyViewInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Информация о свойстве на форме</summary>
  public sealed class PropertyViewInfo
  {
    private static PropertyViewInfo OaysYioRfRRjo3A1kvkE;

    /// <summary>Уникальный идентификатор свойства</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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
    public bool? ReadOnly { get; set; }

    /// <summary>Видимость</summary>
    public bool? Visible { get; set; }

    /// <summary>Обязательно для заполнения</summary>
    public bool? Required { get; set; }

    /// <summary>Валидно ли свойство</summary>
    public bool? IsValid { get; set; }

    /// <summary>Сообщение валидации</summary>
    public string ValidationMessage
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    /// <summary>Настройки свойства</summary>
    public TypeSettings Settings
    {
      get => this.\u003CSettings\u003Ek__BackingField;
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
              this.\u003CSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    public PropertyViewInfo()
    {
      PropertyViewInfo.UDtKjRoRvldD9fEj2HVs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool R4bvvVoRQPSlpKE4hGW6() => PropertyViewInfo.OaysYioRfRRjo3A1kvkE == null;

    internal static PropertyViewInfo vt5wj7oRClIMEdHkxCG1() => PropertyViewInfo.OaysYioRfRRjo3A1kvkE;

    internal static void UDtKjRoRvldD9fEj2HVs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

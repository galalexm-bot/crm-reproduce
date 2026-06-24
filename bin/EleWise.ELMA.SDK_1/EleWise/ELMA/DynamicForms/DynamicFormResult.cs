// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DynamicForms.DynamicFormResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.DynamicForms
{
  /// <summary>Результат выполнения сценария на динамической форме</summary>
  public class DynamicFormResult
  {
    internal static DynamicFormResult AWQIhc2o1LKPcYZvGGp;

    public DynamicFormResult()
    {
      DynamicFormResult.UMhOGD2GBDw71LLZuYx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ResultData = new DynamicFormResultData();
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.ChangedPropertyNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имена измененных свойств</summary>
    public List<string> ChangedPropertyNames { get; set; }

    /// <summary>
    /// Uid-ы свойств, у которых поменялась валидация в скрипте (изменились атрибуты валидации)
    /// </summary>
    public List<Guid> ChangedValidationPropertyUids { get; set; }

    /// <summary>Измененное представления</summary>
    public RootViewItem ChangedView
    {
      get => this.\u003CChangedView\u003Ek__BackingField;
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
              this.\u003CChangedView\u003Ek__BackingField = value;
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

    /// <summary>Преобразование представления формы</summary>
    public ViewItemTransformation ViewTransformation
    {
      get => this.\u003CViewTransformation\u003Ek__BackingField;
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
              this.\u003CViewTransformation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    /// <summary>Состояние сущности</summary>
    public string ModelJsonState
    {
      get => this.\u003CModelJsonState\u003Ek__BackingField;
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
              this.\u003CModelJsonState\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <summary>Дополнительные данные для результата</summary>
    public DynamicFormResultData ResultData
    {
      get => this.\u003CResultData\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CResultData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    internal static void UMhOGD2GBDw71LLZuYx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QZIQFc2bCDA2aLEOqxc() => DynamicFormResult.AWQIhc2o1LKPcYZvGGp == null;

    internal static DynamicFormResult OfHAm02hxFUmkpu7RAW() => DynamicFormResult.AWQIhc2o1LKPcYZvGGp;
  }
}

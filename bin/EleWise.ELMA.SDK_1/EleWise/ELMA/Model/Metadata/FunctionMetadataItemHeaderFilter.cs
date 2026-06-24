// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FunctionMetadataItemHeaderFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Фильтр для объекта "Заголовок метаданных функции"</summary>
  [FilterFor(typeof (FunctionMetadataItemHeader))]
  public class FunctionMetadataItemHeaderFilter : Filter
  {
    private string _name;
    private DateTimeRange _creationDate;
    private string _displayName;
    private static FunctionMetadataItemHeaderFilter ASPtApbp69TZ9uhavkgM;

    public FunctionMetadataItemHeaderFilter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Фильтр для свойства "Наименование"</summary>
    public virtual string Name
    {
      get => this._name;
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
              this._name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Дата создания"</summary>
    public virtual DateTimeRange CreationDate
    {
      get => this._creationDate;
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
              this._creationDate = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Отображаемое имя"</summary>
    public virtual string DisplayName
    {
      get => this._displayName;
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
              this._displayName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    internal static bool Sdh7rXbpHORxLJjgSQKM() => FunctionMetadataItemHeaderFilter.ASPtApbp69TZ9uhavkgM == null;

    internal static FunctionMetadataItemHeaderFilter K2GruCbpAeT7y2BUUej7() => FunctionMetadataItemHeaderFilter.ASPtApbp69TZ9uhavkgM;
  }
}

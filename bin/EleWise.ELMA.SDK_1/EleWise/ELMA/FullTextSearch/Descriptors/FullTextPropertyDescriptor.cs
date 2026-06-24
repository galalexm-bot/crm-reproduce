// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.FullTextPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  /// <summary>
  /// Базовый абстрактный класс описывающий правила поиска и индексирования для индексируемых типов
  /// </summary>
  public abstract class FullTextPropertyDescriptor : 
    IFullTextPropertyMappingDescriptor,
    IFullTextPropertyDescriptor
  {
    /// <summary>Название поля для значения</summary>
    protected Func<IPropertyMetadata, string> ValueFieldName;
    /// <summary>Название поля для сортировки</summary>
    protected Func<IPropertyMetadata, string> SortFieldName;
    private static FullTextPropertyDescriptor qaqI7RGVoQHcm8SOA6WD;

    protected FullTextPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      Func<IPropertyMetadata, string> func1 = FullTextPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__0_0;
      Func<IPropertyMetadata, string> func2;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        FullTextPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__0_0 = func2 = (Func<IPropertyMetadata, string>) (propMd => (string) FullTextPropertyDescriptor.\u003C\u003Ec.aEC9vHvYTGD0XZxgSFM4(FullTextPropertyDescriptor.\u003C\u003Ec.OxQZwIvYKc76NaucHxDl(87862435 ^ 87944263), (object) FullTextPropertyDescriptor.\u003C\u003Ec.nljfwavYXjAnjaaoYFHF((object) propMd).ToString().ToLower(), FullTextPropertyDescriptor.\u003C\u003Ec.OxQZwIvYKc76NaucHxDl(-1380439818 << 3 ^ 1841368774)));
      }
      else
        goto label_11;
label_2:
      this.ValueFieldName = func2;
      // ISSUE: reference to a compiler-generated field
      Func<IPropertyMetadata, string> func3 = FullTextPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__0_1;
      Func<IPropertyMetadata, string> func4;
      if (func3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        FullTextPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__0_1 = func4 = (Func<IPropertyMetadata, string>) (propMd => (string) FullTextPropertyDescriptor.\u003C\u003Ec.aEC9vHvYTGD0XZxgSFM4(FullTextPropertyDescriptor.\u003C\u003Ec.OxQZwIvYKc76NaucHxDl(-1088304168 ^ -1088386244), (object) FullTextPropertyDescriptor.\u003C\u003Ec.nljfwavYXjAnjaaoYFHF((object) propMd).ToString(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104915070)));
      }
      else
        goto label_10;
label_5:
      this.SortFieldName = func4;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            this.TypeDescriptor = typeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_8:
      return;
label_3:
      return;
label_10:
      func4 = func3;
      goto label_5;
label_11:
      func2 = func1;
      goto label_2;
    }

    protected ISerializableTypeDescriptor TypeDescriptor
    {
      get => this.\u003CTypeDescriptor\u003Ek__BackingField;
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
              this.\u003CTypeDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    public virtual bool IsSupportedIndexing => true;

    public virtual bool IsSupportedSearchInIndex => true;

    public virtual bool IsSupportedFullTextSearchInIndex => false;

    public virtual FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex) => new FieldIndexList();

    public virtual FieldListItem GetSearchField(object value, IPropertyMetadata propMd) => new FieldListItem(this.ValueFieldName(propMd), string.Empty);

    public virtual FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      return (FilterListItem) null;
    }

    public virtual List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.ValueFieldName(propMd)
    };

    public virtual SortListItem GetSortField(IPropertyMetadata propMd) => (SortListItem) null;

    public virtual void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
    }

    public virtual void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
    }

    /// <summary>Получить настройки маппинга по метаданным свойства</summary>
    /// <param name="propMd">Метаданные свойства</param>
    public virtual FieldIndexList GetMappingField(IPropertyMetadata propMd) => new FieldIndexList();

    internal static bool pDakIMGVboaoqPLVBlRw() => FullTextPropertyDescriptor.qaqI7RGVoQHcm8SOA6WD == null;

    internal static FullTextPropertyDescriptor kTMB9nGVhgi245bdDZel() => FullTextPropertyDescriptor.qaqI7RGVoQHcm8SOA6WD;
  }
}

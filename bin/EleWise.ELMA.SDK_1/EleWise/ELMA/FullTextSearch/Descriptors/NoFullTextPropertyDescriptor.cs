// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.NoFullTextPropertyDescriptor
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  /// <summary>
  /// Класс описывающий правила поиска и индексирования для неиндексируемых типов
  /// </summary>
  public sealed class NoFullTextPropertyDescriptor : 
    IFullTextPropertyMappingDescriptor,
    IFullTextPropertyDescriptor
  {
    private static NoFullTextPropertyDescriptor zlEcvgG8iRWsGbH6rBfi;

    public ISerializableTypeDescriptor TypeDescriptor
    {
      get => this.\u003CTypeDescriptor\u003Ek__BackingField;
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
              this.\u003CTypeDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    public bool IsSupportedIndexing => false;

    public bool IsSupportedSearchInIndex => false;

    public bool IsSupportedFullTextSearchInIndex => false;

    public FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex) => new FieldIndexList();

    public FieldListItem GetSearchField(object value, IPropertyMetadata propMd) => new FieldListItem((string) NoFullTextPropertyDescriptor.MpKrVWG8TZuHII8Ljp31((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859097199), NoFullTextPropertyDescriptor.Jjb45yG8Xe53xn5T2vOP((object) NoFullTextPropertyDescriptor.I9b4SpG8KAO8J3OIqF4P((object) propMd).ToString())), string.Empty);

    public FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      return (FilterListItem) null;
    }

    public List<string> GetReturnField(IPropertyMetadata propMd) => (List<string>) null;

    public SortListItem GetSortField(IPropertyMetadata propMd) => (SortListItem) null;

    public void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
    }

    public void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
    }

    /// <inheritdoc />
    public FieldIndexList GetMappingField(IPropertyMetadata propMd) => new FieldIndexList();

    public NoFullTextPropertyDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YbBSB6G8RJ95OGrWnAVx() => NoFullTextPropertyDescriptor.zlEcvgG8iRWsGbH6rBfi == null;

    internal static NoFullTextPropertyDescriptor wLk9K4G8q5PM6y8qiqsh() => NoFullTextPropertyDescriptor.zlEcvgG8iRWsGbH6rBfi;

    internal static Guid I9b4SpG8KAO8J3OIqF4P([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object Jjb45yG8Xe53xn5T2vOP([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object MpKrVWG8TZuHII8Ljp31([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);
  }
}

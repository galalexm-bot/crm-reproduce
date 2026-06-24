// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.FetchOptionsBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  public class FetchOptionsBuilder
  {
    private static readonly Func<Guid, IEnumerable<string>, int> getColumnCountCached;
    private FetchOptions _options;
    private static FetchOptionsBuilder C3mmekhKWZI0E3igTJpr;

    private static int GetColumnCount(Guid metadataUid, IEnumerable<string> properties)
    {
      EntityMetadata metadata = (EntityMetadata) MetadataServiceContext.MetadataRuntimeService.GetMetadata(metadataUid);
      List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses((ClassMetadata) metadata);
      childClasses.Add((ClassMetadata) metadata);
      return childClasses.SelectMany<ClassMetadata, PropertyMetadata>((Func<ClassMetadata, IEnumerable<PropertyMetadata>>) (t => (IEnumerable<PropertyMetadata>) t.Properties)).Distinct<PropertyMetadata>((Func<PropertyMetadata, PropertyMetadata, bool>) ((l, r) => l.Uid == r.Uid)).Count<PropertyMetadata>() + properties.Select<string, int>((Func<string, int>) (p =>
      {
        int num = 1;
        ClassMetadata classMetadata;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              classMetadata = (ClassMetadata) FetchOptionsBuilder.\u003C\u003Ec__DisplayClass1_0.qOb2A5vbTKqQD3ltDTS4((object) metadata, (object) p);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              if (classMetadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 2;
                continue;
              }
              goto label_4;
          }
        }
label_3:
        return 0;
label_4:
        // ISSUE: reference to a compiler-generated method
        return FetchOptionsBuilder.\u003C\u003Ec__DisplayClass1_0.VL3IUmvbkUfYBLgR9k5E((object) classMetadata.Properties);
      })).Sum();
    }

    /// <summary>Новый билдер</summary>
    /// <returns></returns>
    public static FetchOptionsBuilder Create() => new FetchOptionsBuilder();

    /// <summary>Новый билдер</summary>
    /// <param name="f"></param>
    /// <returns></returns>
    public static FetchOptionsBuilder Create(FetchOptions f) => new FetchOptionsBuilder(f);

    /// <summary>Проверка на целесообразность оптимизации</summary>
    /// <param name="criteria"></param>
    /// <param name="properties"></param>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static bool IsCanOptimaze(
      ICriteria criteria,
      IEnumerable<string> properties,
      EntityMetadata metadata)
    {
      int setting = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671911795), 1000);
      return FetchOptionsBuilder.getColumnCountCached(metadata.Uid, properties) < setting;
    }

    /// <summary>Убрать ленивые загрузки для списка свойств</summary>
    /// <param name="criteria"></param>
    /// <param name="properties"></param>
    public static void ResolveFetchColumns(
      ICriteria criteria,
      IEnumerable<string> properties,
      bool isProjection,
      ref long aliasIndex,
      bool usingAlias = false)
    {
      FetchOptionsBuilder.ResolveFetchColumns(criteria, properties, SelectMode.Fetch, usingAlias);
    }

    /// <summary>Установить способ загрузки для списка свойств</summary>
    /// <param name="criteria">Критерия</param>
    /// <param name="properties">Список свойств</param>
    /// <param name="selectMode">Способ загрузки</param>
    /// <param name="usingAlias">Использовать псевдоним?</param>
    public static void ResolveFetchColumns(
      ICriteria criteria,
      IEnumerable<string> properties,
      SelectMode selectMode,
      bool usingAlias = false)
    {
      FetchOptionsBuilder.ResolveFetchColumns((object) criteria, properties, (Action<string>) (joinPath =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              criteria.Fetch(selectMode, joinPath);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), usingAlias);
    }

    private static void ResolveFetchColumns(
      object criteria,
      IEnumerable<string> properties,
      Action<string> action,
      bool usingAlias = false)
    {
      foreach (string property in properties)
      {
        string str1 = property;
        if (!usingAlias && property.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16759773)))
        {
          string[] strArray = property.Split(new string[1]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740339952)
          }, StringSplitOptions.RemoveEmptyEntries);
          string alias = "";
          for (int index = 0; index < strArray.Length - 1; ++index)
          {
            string str2 = strArray[index];
            string str3 = !string.IsNullOrEmpty(alias) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957841342), (object) alias, (object) str2) : str2;
            ICriteria criteriaByPath = ((ICriteria) criteria).GetCriteriaByPath(str3);
            if (criteriaByPath == null)
            {
              alias = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234353158), (object) alias, (object) strArray[index]);
              ((ICriteria) criteria).CreateAlias(str3, alias, JoinType.LeftOuterJoin);
            }
            else
              alias = criteriaByPath.Alias;
          }
          str1 = !string.IsNullOrEmpty(alias) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113878529), (object) alias, (object) strArray[strArray.Length - 1]) : property;
        }
        action(str1);
      }
    }

    /// <summary>Колонка - это сущность?</summary>
    /// <param name="metadata"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool IsRefTypeColumn(EntityMetadata metadata, string name)
    {
      int num1 = 7;
      EntitySettings entitySettings;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata;
        CacheEntityAttribute attribute;
        string name1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FetchOptionsBuilder.\u003C\u003Ec__DisplayClass8_0.TX0t4tvb4SZalgqed5xH(FetchOptionsBuilder.\u003C\u003Ec__DisplayClass8_0.MiDNssvbwGCugBPOxkIg((object) p), (object) name1)));
              num2 = 12;
              continue;
            case 3:
              if (entitySettings != null)
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            case 4:
              if (!FetchOptionsBuilder.Ie6jJkhKfZb4lSDry5m3((object) attribute))
              {
                num2 = 13;
                continue;
              }
              goto label_3;
            case 5:
              goto label_13;
            case 6:
              name1 = name;
              num2 = 2;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              if (FetchOptionsBuilder.DwEOjuhKhc0TftPTK8h4(propertyMetadata.SubTypeUid, Guid.Empty))
              {
                num2 = 11;
                continue;
              }
              entitySettings = FetchOptionsBuilder.eeFuB6hKG9kyTgSIVPjC((object) propertyMetadata) as EntitySettings;
              num2 = 3;
              continue;
            case 9:
              if (attribute != null)
              {
                num2 = 4;
                continue;
              }
              goto label_4;
            case 10:
              goto label_3;
            case 12:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 13:
              goto label_4;
            default:
              goto label_10;
          }
        }
label_13:
        attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(FetchOptionsBuilder.QyQ3CXhKERXEaCPRx0t5((object) propertyMetadata)), true);
        num1 = 9;
      }
label_3:
      return false;
label_4:
      return FetchOptionsBuilder.hcyHP9hKQMnqhTtOvZmc((object) entitySettings) == RelationType.OneToOne;
label_10:
      return false;
label_12:
      return false;
    }

    /// <summary>Колонка</summary>
    /// <param name="metadata"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static ClassMetadata RefTypeForColumn(EntityMetadata metadata, string name)
    {
      int num1 = 1;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        int num2 = num1;
        string name1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 2:
              if (propertyMetadata != null)
              {
                num2 = 4;
                continue;
              }
              goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FetchOptionsBuilder.\u003C\u003Ec__DisplayClass9_0.d0d78bvb0YtTTO43jQaV(FetchOptionsBuilder.\u003C\u003Ec__DisplayClass9_0.TZcuKavbxEHFffUHgKEp((object) p), (object) name1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
              continue;
            case 4:
              goto label_5;
            case 5:
              goto label_9;
            default:
              name1 = name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 3;
              continue;
          }
        }
label_5:
        if (FetchOptionsBuilder.QyQ3CXhKERXEaCPRx0t5((object) propertyMetadata) == Guid.Empty)
          num1 = 5;
        else
          goto label_10;
      }
label_9:
      return (ClassMetadata) null;
label_10:
      return (ClassMetadata) MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid);
    }

    /// <summary>Ctor</summary>
    public FetchOptionsBuilder()
    {
      FetchOptionsBuilder.pgOaN6hKCvSEu86XEGTX();
      // ISSUE: explicit constructor call
      this.\u002Ector(new FetchOptions());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="f"></param>
    public FetchOptionsBuilder(FetchOptions f)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._options = f;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="firstResult"></param>
    /// <param name="maxResults"></param>
    public FetchOptionsBuilder(int firstResult, int maxResults)
    {
      FetchOptionsBuilder.pgOaN6hKCvSEu86XEGTX();
      // ISSUE: explicit constructor call
      this.\u002Ector(new FetchOptions(firstResult, maxResults));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="firstResult"></param>
    /// <param name="maxResults"></param>
    /// <param name="sortDirection"></param>
    /// <param name="sortExpression"></param>
    public FetchOptionsBuilder(
      int firstResult,
      int maxResults,
      ListSortDirection sortDirection,
      string sortExpression)
    {
      FetchOptionsBuilder.pgOaN6hKCvSEu86XEGTX();
      // ISSUE: explicit constructor call
      this.\u002Ector(new FetchOptions(firstResult, maxResults, sortDirection, sortExpression));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Индекс первой записи</summary>
    /// <param name="firstResult"></param>
    /// <returns></returns>
    public FetchOptionsBuilder FirstResult(int firstResult)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FetchOptionsBuilder.KOifQ7hKvBL4foTfTTIF((object) this._options, firstResult);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Количество записей для выбора</summary>
    /// <param name="maxResults"></param>
    /// <returns></returns>
    public FetchOptionsBuilder MaxResults(int maxResults)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._options.MaxResults = maxResults;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Направление сортировки</summary>
    /// <param name="sortDirection"></param>
    /// <returns></returns>
    public FetchOptionsBuilder SortDirection(ListSortDirection sortDirection)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._options.SortDirection = sortDirection;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Колонка для сортировки</summary>
    /// <param name="sortExpression"></param>
    /// <returns></returns>
    public FetchOptionsBuilder SortExpression(string sortExpression)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FetchOptionsBuilder.GGsLQmhK8DnBBvuVgKaJ((object) this._options, (object) sortExpression);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Использовать проекцию</summary>
    /// <param name="useProjections"></param>
    /// <returns></returns>
    public FetchOptionsBuilder UseProjections(bool useProjections = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FetchOptionsBuilder.mV08eRhKZOFZtt76lo7J((object) this._options, useProjections);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>
    /// Использовать способ частичной выборки при построении проекции
    /// </summary>
    /// <param name="usePartialFetching"></param>
    /// <returns></returns>
    public FetchOptionsBuilder UsePartialFetching(bool usePartialFetching = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FetchOptionsBuilder.VFWjbvhKuP4ljuyAqAjS((object) this._options, usePartialFetching);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Уникальный ключ запроса</summary>
    /// <param name="queryKey"></param>
    /// <returns></returns>
    public FetchOptionsBuilder QueryKey(string queryKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FetchOptionsBuilder.LgOer8hKIxwwT3iwbF40((object) this._options, (object) queryKey);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Какие колонки выбирать в результате запроса</summary>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public FetchOptionsBuilder SelectColumns(string propertyName)
    {
      int num = 5;
      while (true)
      {
        string propertyName1;
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            if (!this._options.SelectColumns.All<string>((Func<string, bool>) (c => FetchOptionsBuilder.\u003C\u003Ec__DisplayClass21_0.ThmSesvb9L8lANslFtIr((object) c, (object) propertyName1))))
            {
              num = 2;
              continue;
            }
            break;
          case 2:
          case 7:
            goto label_2;
          case 3:
            if (this._options.SelectColumns == null)
            {
              num = 6;
              continue;
            }
            goto case 8;
          case 4:
            propertyName1 = propertyName;
            num = 3;
            continue;
          case 5:
            num = 4;
            continue;
          case 6:
            this._options.SelectColumns = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 0;
            continue;
          case 8:
            if (!FetchOptionsBuilder.bknyqjhKVkigXkQ8aYst((object) propertyName1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
        }
        this._options.SelectColumns.Add(propertyName1);
        num = 7;
      }
label_2:
      return this;
    }

    /// <summary>Какие колонки выбирать в результате запроса</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="listPropertySpecifier"></param>
    /// <returns></returns>
    public FetchOptionsBuilder SelectColumns<T>(
      params Expression<Func<T, object>>[] listPropertySpecifier)
    {
      foreach (Expression<Func<T, object>> f in listPropertySpecifier)
        this.SelectColumns(LinqUtils.FullNameOf<T>(f));
      return this;
    }

    /// <summary>
    /// Ссылки, коллекции (1-n, n-m) которые должны быть загружены SQL запросом через join
    /// используется для устранения проблемы "1+n select"
    /// </summary>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public FetchOptionsBuilder FetchRelations(string propertyName)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        string propertyName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_11;
            case 3:
              propertyName1 = propertyName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 7;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 3;
              continue;
            case 5:
              this._options.FetchRelations.Add(propertyName1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 6 : 5;
              continue;
            case 6:
              goto label_13;
            case 7:
              if (this._options.FetchRelations != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
                continue;
              }
              goto label_6;
            case 8:
              // ISSUE: reference to a compiler-generated method
              if (this._options.FetchRelations.All<string>((Func<string, bool>) (r => FetchOptionsBuilder.\u003C\u003Ec__DisplayClass23_0.fwI74lvb5iWFfdhGf7he((object) r, (object) propertyName1))))
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            default:
              goto label_6;
          }
        }
label_6:
        this._options.FetchRelations = new List<string>();
        num1 = 2;
        continue;
label_11:
        if (!FetchOptionsBuilder.bknyqjhKVkigXkQ8aYst((object) propertyName1))
          num1 = 8;
        else
          break;
      }
label_13:
      return this;
    }

    /// <summary>
    /// Ссылки, коллекции (1-n, n-m) которые должны быть загружены SQL запросом через join
    /// используется для устранения проблемы "1+n select"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="propertySpecifier"></param>
    /// <returns></returns>
    public FetchOptionsBuilder FetchRelations<T>(
      params Expression<Func<T, object>>[] propertySpecifier)
    {
      foreach (Expression<Func<T, object>> f in propertySpecifier)
        this.SelectColumns(LinqUtils.FullNameOf<T>(f));
      return this;
    }

    static FetchOptionsBuilder()
    {
      int num = 4;
      ParameterExpression parameterExpression1;
      ParameterExpression parameterExpression2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: method reference
            FetchOptionsBuilder.getColumnCountCached = MetadataLoader.UseCachingForFunc<Guid, IEnumerable<string>, int>(Expression.Lambda<Func<Guid, IEnumerable<string>, int>>((Expression) FetchOptionsBuilder.ahhw5uhKKHxI4aIaSXsE((object) null, (object) (MethodInfo) FetchOptionsBuilder.dQtecjhKqBkK18XhI7RL(__methodref (FetchOptionsBuilder.GetColumnCount)), (object) new Expression[2]
            {
              (Expression) parameterExpression1,
              (Expression) parameterExpression2
            }), parameterExpression1, parameterExpression2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 1;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: type reference
            parameterExpression1 = (ParameterExpression) FetchOptionsBuilder.oTlrvyhKRr8sAPgTpXlJ(FetchOptionsBuilder.YCpRs6hKSQiemv2WnM1x(__typeref (Guid)), FetchOptionsBuilder.b4GPVXhKiSec4oRkUkvM(87862435 ^ 87912309));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 4:
            FetchOptionsBuilder.pgOaN6hKCvSEu86XEGTX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 3;
            continue;
          default:
            // ISSUE: type reference
            parameterExpression2 = (ParameterExpression) FetchOptionsBuilder.oTlrvyhKRr8sAPgTpXlJ(FetchOptionsBuilder.YCpRs6hKSQiemv2WnM1x(__typeref (IEnumerable<string>)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487263996));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool DwEOjuhKhc0TftPTK8h4([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object eeFuB6hKG9kyTgSIVPjC([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static Guid QyQ3CXhKERXEaCPRx0t5([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool Ie6jJkhKfZb4lSDry5m3([In] object obj0) => ((CacheEntityAttribute) obj0).Enabled;

    internal static RelationType hcyHP9hKQMnqhTtOvZmc([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static bool mowEOKhKo0op7woWn3Pg() => FetchOptionsBuilder.C3mmekhKWZI0E3igTJpr == null;

    internal static FetchOptionsBuilder bTvyNXhKbbbBkmSAUZ2h() => FetchOptionsBuilder.C3mmekhKWZI0E3igTJpr;

    internal static void pgOaN6hKCvSEu86XEGTX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void KOifQ7hKvBL4foTfTTIF([In] object obj0, int value) => ((FetchOptions) obj0).FirstResult = value;

    internal static void GGsLQmhK8DnBBvuVgKaJ([In] object obj0, [In] object obj1) => ((FetchOptions) obj0).SortExpression = (string) obj1;

    internal static void mV08eRhKZOFZtt76lo7J([In] object obj0, bool value) => ((FetchOptions) obj0).UseProjections = value;

    internal static void VFWjbvhKuP4ljuyAqAjS([In] object obj0, bool value) => ((FetchOptions) obj0).UsePartialFetching = value;

    internal static void LgOer8hKIxwwT3iwbF40([In] object obj0, [In] object obj1) => ((FetchOptions) obj0).QueryKey = (string) obj1;

    internal static bool bknyqjhKVkigXkQ8aYst([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Type YCpRs6hKSQiemv2WnM1x([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object b4GPVXhKiSec4oRkUkvM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oTlrvyhKRr8sAPgTpXlJ([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object dQtecjhKqBkK18XhI7RL([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object ahhw5uhKKHxI4aIaSXsE([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);
  }
}

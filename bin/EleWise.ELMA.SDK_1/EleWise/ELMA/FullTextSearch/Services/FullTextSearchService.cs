// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.FullTextSearchService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Diagnostics.Statistics;
using EleWise.ELMA.FullTextSearch.Constants;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>Сервис полнотекстового поиска</summary>
  [Service]
  internal class FullTextSearchService : 
    IFullTextSearchServiceReIndexingTypeExtension,
    IFullTextSearchService
  {
    private static readonly ILogger IndexLog;
    private object objectIndex;
    private List<IFullTextSearchFieldsMappingsReIndexingExtension> points;
    internal static FullTextSearchService zoSitbGSyLMSR9ms7NtQ;

    /// <summary>
    /// <see cref="T:EleWise.ELMA.FullTextSearch.Services.IFullTextSearchDescriptorService" />
    /// </summary>
    public IFullTextSearchDescriptorService FullTextSearchDescriptorService
    {
      get => this.\u003CFullTextSearchDescriptorService\u003Ek__BackingField;
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
              this.\u003CFullTextSearchDescriptorService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    private IBLOBDataManager BlobManager => (IBLOBDataManager) FullTextSearchService.xT4UloGS9N7QXN3i8jM3();

    public IFullTextSearchProvider Provider
    {
      get
      {
        int num = 1;
        FullTextSearchSettingsModule serviceNotNull;
        Guid providerUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              if (serviceNotNull.Settings != null)
              {
                num = 3;
                continue;
              }
              goto label_2;
            case 3:
              providerUid = FullTextSearchService.IxAwiJGSdB9BFpCe7aDV((object) serviceNotNull.Settings);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 5 : 3;
              continue;
            case 4:
              serviceNotNull = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 1;
              continue;
            case 5:
              goto label_2;
            default:
              providerUid = new Guid();
              num = 4;
              continue;
          }
        }
label_2:
        return ((ComponentManager) FullTextSearchService.NOHLYUGSlP7MTR4Jk6gL()).GetExtensionPoints<IFullTextSearchProvider>().FirstOrDefault<IFullTextSearchProvider>((Func<IFullTextSearchProvider, bool>) (p => FullTextSearchService.\u003C\u003Ec__DisplayClass10_0.E7ayuJvUXqV56HYeE3Go(FullTextSearchService.\u003C\u003Ec__DisplayClass10_0.xGaCaNvUKeHE4knwiQbo((object) p), providerUid)));
      }
    }

    private List<IFullTextSearchFieldsMappingsReIndexingExtension> Points => this.points ?? (this.points = ComponentManager.Current.GetExtensionPoints<IFullTextSearchFieldsMappingsReIndexingExtension>().ToList<IFullTextSearchFieldsMappingsReIndexingExtension>());

    /// <summary>
    /// Проверка, работает ли индекс (проверяется доступен ли сервер индексации)
    /// </summary>
    private bool GetServerStatus()
    {
      bool serverStatus;
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (this.Provider == null)
              num1 = 2;
            else
              goto label_5;
label_4:
            int num2;
            switch (num1)
            {
              case 1:
                break;
              case 2:
                num2 = 0;
                goto label_7;
              default:
                goto label_1;
            }
label_5:
            num2 = FullTextSearchService.x66jIWGSroJxCobKf9Yi((object) this.Provider) ? 1 : 0;
label_7:
            serverStatus = num2 != 0;
            num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
            {
              num1 = 0;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  serverStatus = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return serverStatus;
    }

    /// <summary>
    /// Проверка, работает ли индекс (проверяется включена ли индексация и доступен ли сервер индексации)
    /// </summary>
    public bool IndexingIsWorking()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.GetIndexState() == FullTextSearchState.On)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetServerStatus();
label_3:
      return false;
    }

    /// <summary>Полнотекстовый поиск по строке (c фильтрацией)</summary>
    public virtual FullTextSearchResultModel Search(
      Type cardType,
      FullTextSearchResultModel resultModel,
      string searchString,
      int? pageIndex = null,
      int? pageSize = null)
    {
      if (this.Provider == null)
        return resultModel;
      using (DiagnosticsManager.StartCall<IndexCallInfo>((Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Search))))
      {
        List<string> listForHighlight = new List<string>();
        this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                listForHighlight.AddRange((IEnumerable<string>) p.GetHighlightFields(cardType));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        FilterList listForFilter = new FilterList();
        this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                listForFilter.AddRange((IEnumerable<FilterListItem>) p.GetFilterFields(cardType, resultModel));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        List<string> listForFields = new List<string>();
        this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                listForFields.AddRange((IEnumerable<string>) p.GetFields(cardType));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        List<string> listForSearch = new List<string>();
        this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                listForSearch.AddRange((IEnumerable<string>) p.GetSearchFields(cardType));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int? from = new int?();
        int? size = new int?();
        if (pageIndex.HasValue && pageSize.HasValue)
        {
          int? nullable1 = pageIndex;
          int num1 = 0;
          if (nullable1.GetValueOrDefault() > num1 & nullable1.HasValue)
          {
            nullable1 = pageSize;
            int num2 = 0;
            if (nullable1.GetValueOrDefault() > num2 & nullable1.HasValue)
            {
              int? nullable2 = pageIndex;
              nullable1 = nullable2.HasValue ? new int?(nullable2.GetValueOrDefault() - 1) : new int?();
              int? nullable3 = pageSize;
              from = nullable1.HasValue & nullable3.HasValue ? new int?(nullable1.GetValueOrDefault() * nullable3.GetValueOrDefault()) : new int?();
              size = pageSize;
            }
          }
        }
        try
        {
          resultModel = this.Provider.Search(cardType, searchString, listForHighlight, listForFilter, listForFields, listForSearch, from, size);
        }
        catch (WebException ex)
        {
          Logger.Log.Error((object) ex);
          resultModel.Error = new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638646845)), (Exception) ex);
        }
        catch (Exception ex)
        {
          throw ex;
        }
        if (resultModel != null && resultModel.Items != null)
          resultModel.Items.ForEach((Action<FullTextSearchResultItem>) (i =>
          {
            int num = 3;
            object target;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  FullTextSearchService.\u003C\u003Ec__DisplayClass16_0.NwdjjZvU2wvnrcl3NaZn((object) i, (object) (IFullTextSearchObject) target);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  ((WebData) FullTextSearchService.\u003C\u003Ec__DisplayClass16_0.VFQEZOvUOTIjr53ncE6m((object) i)).SaveToEntity(target, true);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                  continue;
                case 3:
                  target = InterfaceActivator.Create(cardType);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
                  continue;
                default:
                  goto label_6;
              }
            }
label_2:
            return;
label_6:;
          }));
        return resultModel;
      }
    }

    /// <summary>
    /// Полнотекстовый поиск по строке в типе объекта (без фильтрации)
    /// </summary>
    /// <param name="searchString"></param>
    /// <returns></returns>
    public virtual FullTextSearchResultModel Search(
      Type cardType,
      string searchString,
      int? pageIndex = null,
      int? pageSize = null)
    {
      return this.Search(cardType, (FullTextSearchResultModel) null, searchString, pageIndex, pageSize);
    }

    /// <summary>Индексирование большой группы объектов</summary>
    /// <param name="objects"></param>
    /// <returns></returns>
    private bool IndexMany(Type cardType, List<IFullTextSearchObjectContainer> objects)
    {
      if (!objects.Any<IFullTextSearchObjectContainer>())
        return true;
      lock (this.objectIndex)
      {
        try
        {
          while (objects.Count > 0)
          {
            if (!this.IsIndexingOn())
              throw new StopIndexingException();
            int count = 100 <= objects.Count ? 100 : objects.Count;
            List<IFullTextSearchObjectContainer> objects1 = new List<IFullTextSearchObjectContainer>();
            objects1.AddRange((IEnumerable<IFullTextSearchObjectContainer>) objects.GetRange(0, count));
            this.Index(cardType, objects1);
            objects.RemoveRange(0, count);
          }
        }
        catch (StopIndexingException ex)
        {
          FullTextSearchService.IndexLog.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538662110), (object) FullTextSearchConst.StopIndexTextLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108095944)));
          throw;
        }
        catch (Exception ex)
        {
          FullTextSearchService.IndexLog.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561159336) + ex.Message), ex);
          return false;
        }
      }
      return true;
    }

    /// <summary>Реиндексирование большой группы объектов</summary>
    private bool ReIndexMany(Type cardType, List<ToReindex> listToReindex)
    {
      using (IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>((Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.ReIndex))))
      {
        try
        {
          return !listToReindex.Any<ToReindex>() || this.Provider != null && this.Provider.ReIndex(cardType, listToReindex);
        }
        catch (Exception ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.Exception = ex;
          FullTextSearchService.IndexLog.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021490449) + ex.Message), ex);
          return false;
        }
      }
    }

    /// <summary>Индексирование группы объектов</summary>
    private bool Index(Type cardType, List<IFullTextSearchObjectContainer> objects)
    {
      using (IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>((Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Index))))
      {
        try
        {
          return this.Provider != null && objects.Any<IFullTextSearchObjectContainer>() && this.Provider.Index(cardType, (IEnumerable<IFullTextSearchObjectContainer>) objects);
        }
        catch (StopIndexingException ex)
        {
          throw;
        }
        catch (Exception ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.Exception = ex;
          FullTextSearchService.IndexLog.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479681316) + ex.Message), ex);
          return false;
        }
      }
    }

    /// <summary>Удаление типа и всех его объектов</summary>
    private bool DeleteAllFromType(Type cardType)
    {
      int num1 = 2;
      IndexCallInfo indexCallInfo;
      while (true)
      {
        int num2 = num1;
        Func<IndexCallInfo> callInfoCreator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.Provider != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 1;
                continue;
              }
              goto label_3;
            case 2:
              FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138972842));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              callInfoCreator = FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__21_0;
              if (callInfoCreator == null)
              {
                num2 = 6;
                continue;
              }
              goto label_20;
            case 4:
              goto label_6;
            case 5:
              goto label_7;
            case 6:
              goto label_19;
            default:
              goto label_3;
          }
        }
label_19:
        // ISSUE: reference to a compiler-generated field
        callInfoCreator = FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__21_0 = (Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Delete));
label_20:
        indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>(callInfoCreator);
        num1 = 5;
      }
label_3:
      return false;
label_6:
      return true;
label_7:
      try
      {
        this.Provider.DeleteAllFromType(cardType);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_6;
        }
      }
      finally
      {
        int num4;
        if (indexCallInfo == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
        else
          goto label_13;
label_12:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_13:
        indexCallInfo.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        {
          num4 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    private IFullTextSearchObjectContainer ObjectByEntity(Type cardType, IEntity entity)
    {
      int num1 = 3;
      Type cardType1;
      FullTextSearchObjectContainer wrapper;
      IEntity entity1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (entity1 != null)
            {
              num1 = 4;
              continue;
            }
            goto label_7;
          case 2:
            cardType1 = cardType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 2;
            continue;
          case 4:
            wrapper = new FullTextSearchObjectContainer()
            {
              SearchObject = FullTextSearchService.k7udifGS5LS4W4XHDujW(cardType1) as IFullTextSearchObject
            };
            num1 = 7;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_7;
          case 7:
            if (FullTextSearchService.anfqmHGSj9HNVWQ9uJmi((object) wrapper) != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 8;
              continue;
            }
            goto label_2;
          case 8:
            this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.FillObject(cardType1, (IFullTextSearchObjectContainer) wrapper, entity1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 5;
            continue;
          default:
            entity1 = entity;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return (IFullTextSearchObjectContainer) wrapper;
label_7:
      return (IFullTextSearchObjectContainer) null;
    }

    public bool IndexEntities(Type cardType, List<Guid> listUid)
    {
      List<IEntity> entities = new List<IEntity>();
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              entities.AddRange((IEnumerable<IEntity>) p.GetEntities(cardType, listUid));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return this.IndexEntities(cardType, (IEnumerable<IEntity>) entities);
    }

    public bool IndexEntities(Type cardType, List<long> listId)
    {
      List<IEntity> entities = new List<IEntity>();
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              entities.AddRange((IEnumerable<IEntity>) p.GetEntities(cardType, listId));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return this.IndexEntities(cardType, (IEnumerable<IEntity>) entities);
    }

    private bool IndexEntities(Type cardType, IEnumerable<IEntity> list)
    {
      List<IFullTextSearchObjectContainer> objects = new List<IFullTextSearchObjectContainer>();
      foreach (IEntity entity in list)
      {
        if (entity != null)
        {
          IFullTextSearchObjectContainer searchObjectContainer = this.ObjectByEntity(cardType, entity);
          if (searchObjectContainer?.SearchObject != null)
            objects.Add(searchObjectContainer);
        }
      }
      return this.IndexMany(cardType, objects);
    }

    private bool IsIndexingOn() => this.GetIndexState() == FullTextSearchState.On;

    public bool ReIndexAllEntities(
      IIndexQueue item,
      string dirtyValues,
      out bool breakBecauseIsIndexAll)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_55;
          case 2:
            breakBecauseIsIndexAll = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          case 3:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-2106517564 ^ -2106402544), (object) Array.Empty<object>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      bool flag;
      try
      {
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
          num2 = 1;
        ContinueInfo continueInfo;
        IEnumerator<Type> enumerator;
        List<KeyValuePair<Type, Guid>> typePairs;
        while (true)
        {
          switch (num2)
          {
            case 1:
              continueInfo = this.ParseContinueInfo(dirtyValues);
              num2 = 4;
              continue;
            case 2:
              List<Type> list = typePairs.Select<KeyValuePair<Type, Guid>, Type>((Func<KeyValuePair<Type, Guid>, Type>) (p => p.Key)).ToList<Type>();
              // ISSUE: reference to a compiler-generated field
              Func<Type, bool> func = FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__27_2;
              Func<Type, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__27_2 = predicate = (Func<Type, bool>) (t => t != (Type) null);
              }
              else
                goto label_57;
label_41:
              enumerator = list.Where<Type>(predicate).Distinct<Type>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
label_57:
              predicate = func;
              goto label_41;
            case 3:
              goto label_55;
            case 4:
              typePairs = new List<KeyValuePair<Type, Guid>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 5;
              continue;
            case 5:
              this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      typePairs.AddRange((IEnumerable<KeyValuePair<Type, Guid>>) p.GetSupportedCardTypes());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 2;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        try
        {
label_26:
          if (FullTextSearchService.PYbCwxGSsp1ZhpISAUCy((object) enumerator))
            goto label_20;
          else
            goto label_27;
label_12:
          Type current;
          int num4;
          while (true)
          {
            int num5;
            KeyValuePair<Type, Guid> keyValuePair;
            ContinueInfo.PageInfo pageInfo;
            Guid empty;
            Type typeF;
            switch (num4)
            {
              case 1:
                if (!typePairs.Any<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == typeF)))
                {
                  num5 = 3;
                  break;
                }
                goto default;
              case 2:
                goto label_29;
              case 3:
              case 7:
                if (!FullTextSearchService.sVMlM4GSUnxTQ9AY6k0g(empty, Guid.Empty))
                {
                  num5 = 5;
                  break;
                }
                goto case 13;
              case 4:
                empty = Guid.Empty;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
                continue;
              case 5:
              case 9:
              case 11:
                goto label_26;
              case 6:
                goto label_56;
              case 8:
                if (continueInfo.PagesInfo.TryGetValue(empty, out pageInfo))
                {
                  num4 = 17;
                  continue;
                }
                goto label_26;
              case 10:
                goto label_20;
              case 12:
                empty = keyValuePair.Value;
                num4 = 7;
                continue;
              case 13:
                if (continueInfo == null)
                {
                  num4 = 9;
                  continue;
                }
                goto case 8;
              case 14:
                goto label_55;
              case 15:
                if (this.IsIndexingOn())
                {
                  num4 = 18;
                  continue;
                }
                goto label_29;
              case 16:
                num5 = 15;
                break;
              case 17:
                flag = this.ReIndexAllEntitiesByType(current, out breakBecauseIsIndexAll, item, pageInfo: pageInfo, fromIndexAll: true);
                num4 = 6;
                continue;
              case 18:
                typeF = current;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 0;
                continue;
              default:
                keyValuePair = typePairs.First<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == typeF));
                num4 = 12;
                continue;
            }
            num4 = num5;
          }
label_29:
          throw new StopIndexingException();
label_20:
          current = enumerator.Current;
          num4 = 16;
          goto label_12;
label_27:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 14;
          goto label_12;
        }
        finally
        {
          if (enumerator != null)
          {
            int num6 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
              num6 = 0;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  goto label_38;
                default:
                  enumerator.Dispose();
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                  continue;
              }
            }
          }
label_38:;
        }
      }
      catch (StopIndexingException ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              breakBecauseIsIndexAll = false;
              num7 = 2;
              continue;
            case 2:
              goto label_47;
            default:
              FullTextSearchService.IndexLog.Warn((object) string.Format((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-606654180 ^ -606780888), (object) FullTextSearchConst.StopIndexTextLog, FullTextSearchService.fgHpoSGSY0ad2L8AABrV(~210725948 ^ -210543337)));
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
          }
        }
label_47:
        throw;
      }
      catch (Exception ex)
      {
        int num8 = 3;
        while (true)
        {
          switch (num8)
          {
            case 1:
              breakBecauseIsIndexAll = false;
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_56;
            case 3:
              FullTextSearchService.yWlb45GiF4OqXGSKdj5C((object) FullTextSearchService.IndexLog, FullTextSearchService.xlNxXoGSzg7OR7SnOT7b(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-542721635 ^ -542804127), FullTextSearchService.rqsk9HGSc47bwP4Fdy7P((object) ex)), (object) ex);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
              continue;
            default:
              flag = false;
              num8 = 2;
              continue;
          }
        }
      }
label_56:
      return flag;
label_55:
      return true;
    }

    /// <inheritdoc />
    public IndexResult ReIndexingByType(IIndexQueue item)
    {
      int num = 1;
      Guid? cardTypeUid;
      ContinueInfo continueInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (FullTextSearchService.jeMXU7GiWtpq7MWtlP8R(FullTextSearchService.IUihCiGiBexsLfEIaEHG((object) item)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 2:
            goto label_7;
          case 3:
            FullTextSearchService.WqHVPZGibtl6FoX1rRXQ((object) item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
            continue;
          case 4:
            item.QueueType = new IndexQueueType?(IndexQueueType.IndexAll);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 6 : 9;
            continue;
          case 5:
            Dictionary<Guid, ContinueInfo.PageInfo> pagesInfo = continueInfo.PagesInfo;
            cardTypeUid = item.CardTypeUid;
            Guid key = cardTypeUid.Value;
            ContinueInfo.PageInfo pageInfo = new ContinueInfo.PageInfo();
            pagesInfo.Add(key, pageInfo);
            num = 7;
            continue;
          case 6:
            goto label_12;
          case 7:
            item.DirtyValues = this.ConvertToContinueInfo(continueInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 3 : 3;
            continue;
          case 8:
            if (cardTypeUid.HasValue)
            {
              num = 4;
              continue;
            }
            goto label_12;
          case 9:
            continueInfo = new ContinueInfo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 5;
            continue;
          default:
            cardTypeUid = item.CardTypeUid;
            num = 8;
            continue;
        }
      }
label_7:
      return new IndexResult();
label_12:
      IndexResult indexResult = new IndexResult();
      FullTextSearchService.YCrOfoGioCkoucIh2GEA((object) indexResult, false);
      return indexResult;
    }

    public bool ReIndexAllEntitiesByType(Type cardType, Guid? typeUidFilter = null) => this.ReIndexAllEntitiesByType(cardType, out bool _, typeUidFilter: typeUidFilter);

    private bool ReIndexAllEntitiesByType(
      Type cardType,
      out bool breakBecauseIsIndexAll,
      IIndexQueue item = null,
      Guid? typeUidFilter = null,
      ContinueInfo.PageInfo pageInfo = null,
      bool fromIndexAll = false)
    {
      FullTextSearchService.IndexLog.Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372509463));
      breakBecauseIsIndexAll = false;
      long? lastId = new long?();
      int? pageIndex = new int?();
      int attempt = 0;
      List<KeyValuePair<Type, Guid>> typePairs = new List<KeyValuePair<Type, Guid>>();
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              typePairs.AddRange((IEnumerable<KeyValuePair<Type, Guid>>) p.GetSupportedCardTypes());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      Guid empty = Guid.Empty;
      if (typePairs.Any<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == cardType)))
        empty = typePairs.FirstOrDefault<KeyValuePair<Type, Guid>>((Func<KeyValuePair<Type, Guid>, bool>) (p => p.Key == cardType)).Value;
      int num1;
      try
      {
        int? page;
        if (pageInfo != null && (pageInfo.LastId.HasValue || pageInfo.Page.HasValue))
        {
          attempt = pageInfo.Attempt;
          if (pageInfo.LastId.HasValue)
          {
            lastId = pageInfo.LastId;
          }
          else
          {
            page = pageInfo.Page;
            pageIndex = page.HasValue ? new int?(page.GetValueOrDefault() + 1) : new int?();
          }
        }
        if (pageInfo != null)
        {
          if (!pageInfo.LastId.HasValue)
          {
            page = pageInfo.Page;
            if (page.HasValue)
              goto label_11;
          }
          else
            goto label_11;
        }
        this.DeleteAllFromType(cardType);
label_11:
        bool flag = true;
        while (flag)
        {
          List<Guid> typeListFilter = (List<Guid>) null;
          if (typeUidFilter.HasValue && MetadataLoader.LoadMetadata(typeUidFilter.Value) is ClassMetadata metadata)
          {
            // ISSUE: reference to a compiler-generated method
            typeListFilter = MetadataLoader.GetChildClasses(metadata).Select<ClassMetadata, Guid>((Func<ClassMetadata, Guid>) (m => FullTextSearchService.\u003C\u003Ec.i6r182vUDqeGg8a5r72e((object) m))).ToList<Guid>();
          }
          IEntity[] array = this.Points.SelectMany<IFullTextSearchFieldsMappingsReIndexingExtension, IEntity>((Func<IFullTextSearchFieldsMappingsReIndexingExtension, IEnumerable<IEntity>>) (p => !pageIndex.HasValue ? (IEnumerable<IEntity>) p.LoadEntities(cardType, lastId, typeListFilter) : (IEnumerable<IEntity>) p.LoadEntitiesByPage(cardType, pageIndex.Value, typeListFilter))).ToArray<IEntity>();
          IndexQueueType? queueType;
          if (array.Length != 0)
          {
            List<IFullTextSearchObjectContainer> list = ((IEnumerable<IEntity>) array).Select<IEntity, IFullTextSearchObjectContainer>((Func<IEntity, IFullTextSearchObjectContainer>) (e => this.ObjectByEntity(cardType, e))).Where<IFullTextSearchObjectContainer>((Func<IFullTextSearchObjectContainer, bool>) (o => o != null)).ToList<IFullTextSearchObjectContainer>();
            this.IndexMany(cardType, list);
            pageIndex = new int?();
            // ISSUE: reference to a compiler-generated method
            lastId = new long?(((IEnumerable<IEntity>) array).Max<IEntity>((Func<IEntity, long>) (e => (long) FullTextSearchService.\u003C\u003Ec.kl8R0UvUtTlH6g0PcnMj((object) e))));
            if (item != null)
            {
              queueType = item.QueueType;
              IndexQueueType indexQueueType = IndexQueueType.IndexAll;
              if (queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue)
                this.SaveDirtyInfoProgres(item, empty, lastId, attempt, cardType);
            }
          }
          else
          {
            flag = false;
            if (fromIndexAll && item != null)
            {
              queueType = item.QueueType;
              IndexQueueType indexQueueType = IndexQueueType.IndexAll;
              if (queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue && empty != Guid.Empty)
              {
                ContinueInfo continueInfo = this.ParseContinueInfo(item.DirtyValues);
                continueInfo.RemovePageInfo(empty);
                if (continueInfo.PagesInfo.Count > 0)
                {
                  breakBecauseIsIndexAll = true;
                  item.DirtyValues = this.ConvertToContinueInfo(continueInfo);
                  item.Save();
                }
              }
            }
          }
          if (fromIndexAll)
          {
            if (flag)
              breakBecauseIsIndexAll = true;
            flag = false;
          }
        }
        return true;
      }
      catch (StopIndexingException ex)
      {
        this.SaveDirtyInfoProgres(item, empty, lastId, num1 = attempt + 1, cardType);
        FullTextSearchService.IndexLog.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70142919), (object) FullTextSearchConst.StopIndexTextLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153935339)));
        throw;
      }
      catch (Exception ex)
      {
        this.SaveDirtyInfoProgres(item, empty, lastId, num1 = attempt + 1, cardType);
        FullTextSearchService.IndexLog.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561159658), (object) ex.Message), ex);
        return false;
      }
    }

    public bool ReIndexByPropertyList(
      Type cardType,
      List<IEnumerable<KeyValuePair<string, object>>> listProperty)
    {
      List<ToReindex> source1 = new List<ToReindex>();
      bool flag = true;
      foreach (IEnumerable<KeyValuePair<string, object>> source2 in listProperty)
      {
        WebData staticProperties = new WebData(source2.Where<KeyValuePair<string, object>>((Func<KeyValuePair<string, object>, bool>) (p => !(p.Value is FieldIndexListItem))));
        FieldIndexList dynamicProperties = new FieldIndexList();
        dynamicProperties.AddRange(source2.Select<KeyValuePair<string, object>, FieldIndexListItem>((Func<KeyValuePair<string, object>, FieldIndexListItem>) (p => p.Value as FieldIndexListItem)).Where<FieldIndexListItem>((Func<FieldIndexListItem, bool>) (p => p != null)));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (((IEnumerable<WebDataItem>) staticProperties.Items).Any<WebDataItem>((Func<WebDataItem, bool>) (d => FullTextSearchService.\u003C\u003Ec.vbvt37vU4gjTtEJeNjKw((object) ((string) FullTextSearchService.\u003C\u003Ec.nyQSMjvUwkScujl568C2((object) d)).ToLower(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876115499)))))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          source1.Add(new ToReindex(((IEnumerable<WebDataItem>) staticProperties.Items).First<WebDataItem>((Func<WebDataItem, bool>) (d => FullTextSearchService.\u003C\u003Ec.vbvt37vU4gjTtEJeNjKw((object) d.Name.ToLower(), FullTextSearchService.\u003C\u003Ec.qXF8E7vU6H5f9gr5Mho7(-1710575414 ^ -1710521424)))).Value, staticProperties, dynamicProperties));
        }
        else
          FullTextSearchService.IndexLog.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124656458), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29207919)));
      }
      if (source1.Any<ToReindex>())
      {
        while (source1.Count > 0)
        {
          List<ToReindex> toReindexList = new List<ToReindex>();
          int count = 100 <= source1.Count ? 100 : source1.Count;
          toReindexList.AddRange((IEnumerable<ToReindex>) source1.GetRange(0, count));
          if (toReindexList.Any<ToReindex>())
          {
            try
            {
              if (!this.ReIndexMany(cardType, toReindexList))
                flag = false;
            }
            catch (Exception ex)
            {
              return false;
            }
          }
          source1.RemoveRange(0, count);
        }
      }
      return flag;
    }

    private Guid BlobFullTextSearchStateUid => new Guid((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-1939377524 ^ -1939561828));

    private Guid BlobFullTextSearchStopedInfoUid => new Guid((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-398663332 ^ -398511872));

    public FullTextSearchState GetIndexState()
    {
      int num = 2;
      FullTextSearchState? blob;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!blob.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            blob = this.BlobManager.GetBLOB<FullTextSearchState?>(this.BlobFullTextSearchStateUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-688192331 - 435440695 ^ -1123718954));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return FullTextSearchState.Off;
label_3:
      return blob.Value;
    }

    public void SetOffIndexState()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740522712), (object) Array.Empty<object>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.BlobManager.SetBLOB<FullTextSearchState?>(this.BlobFullTextSearchStateUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-1487388570 ^ -1487171378), new FullTextSearchState?(FullTextSearchState.Off));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public void SetReadyIndexState()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.BlobManager.SetBLOB<FullTextSearchState?>(this.BlobFullTextSearchStateUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(964881585 - -1459193222 ^ -1870683489), new FullTextSearchState?(FullTextSearchState.Ready));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372512009), (object) Array.Empty<object>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public void SetOnIndexState()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.BlobManager.SetBLOB<FullTextSearchState?>(this.BlobFullTextSearchStateUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-1598106783 - -968262081 ^ -629766774), new FullTextSearchState?(FullTextSearchState.On));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 2:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(1819636893 << 3 ^ 1671984544), (object) Array.Empty<object>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Запуск индексирования</summary>
    public void StartIndexing()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.BlobManager.RemoveBLOB<string>(this.BlobFullTextSearchStopedInfoUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-2106517564 ^ -2106407346));
            num = 5;
            continue;
          case 2:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, (object) string.Format((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(92412609 - 1050237057 ^ -957672662)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          case 3:
            this.Provider.DeleteIndex();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_5;
          case 5:
            if (this.Provider == null)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 6:
            ((IndexQueueManager) FullTextSearchService.uZcdBBGihaiGwKchLmPA()).ClearQueue();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 3;
            continue;
          case 7:
            this.SetOnIndexState();
            num = 6;
            continue;
          case 8:
            goto label_2;
          default:
            IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
            indexQueue.QueueType = new IndexQueueType?(IndexQueueType.IndexAll);
            indexQueue.Save();
            num = 8;
            continue;
        }
      }
label_5:
      return;
label_2:;
    }

    /// <summary>Переиндексирование</summary>
    public void StartReIndexing()
    {
      int num = 9;
      while (true)
      {
        switch (num)
        {
          case 1:
            FullTextSearchService.Hgh1CtGiGIgc4Doh2UBG(FullTextSearchService.uZcdBBGihaiGwKchLmPA());
            num = 2;
            continue;
          case 2:
            this.SetOnIndexState();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 7 : 7;
            continue;
          case 3:
            this.SetOffIndexState();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
            continue;
          case 4:
            goto label_5;
          case 5:
            goto label_14;
          case 6:
            if (this.GetIndexState() == FullTextSearchState.On)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 2;
              continue;
            }
            goto label_2;
          case 7:
            IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
            indexQueue.QueueType = new IndexQueueType?(IndexQueueType.IndexAll);
            FullTextSearchService.WqHVPZGibtl6FoX1rRXQ((object) indexQueue);
            num = 5;
            continue;
          case 8:
            this.BlobManager.RemoveBLOB<string>(this.BlobFullTextSearchStopedInfoUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(1242972401 >> 4 ^ 77772165));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 9:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(874012245 ^ 874221501), (object) Array.Empty<object>()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 7 : 8;
            continue;
          default:
            if (this.Provider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 4;
              continue;
            }
            goto case 6;
        }
      }
label_5:
      return;
label_14:
      return;
label_2:;
    }

    public void StopIndexing()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.StopIndexing((string) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void StopIndexing(string info)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 11:
            FullTextSearchService.IndexLog.Warn((object) string.Format((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(~541731958 ^ -541720131)));
            num = 9;
            continue;
          case 2:
            if (FullTextSearchService.jeMXU7GiWtpq7MWtlP8R((object) info))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            FullTextSearchService.hdvqeLGSgMh54UjtNtoS((object) FullTextSearchService.IndexLog, FullTextSearchService.xlNxXoGSzg7OR7SnOT7b(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-882126494 ^ -882375826), (object) info));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 1;
            continue;
          case 4:
            this.BlobManager.SetBLOB<string>(this.BlobFullTextSearchStopedInfoUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(~289714581 ^ -289890336), info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 8;
            continue;
          case 5:
            if (this.Provider == null)
            {
              num = 7;
              continue;
            }
            break;
          case 6:
            goto label_12;
          case 7:
            goto label_10;
          case 8:
          case 9:
            this.SetOffIndexState();
            num = 10;
            continue;
          case 10:
            ((IndexQueueManager) FullTextSearchService.uZcdBBGihaiGwKchLmPA()).ClearQueue();
            num = 5;
            continue;
        }
        FullTextSearchService.edCG0IGiE5iyIX4YhmTN((object) this.Provider);
        num = 6;
      }
label_12:
      return;
label_10:;
    }

    public string GetStopIndexingInfo() => this.BlobManager.GetBLOB<string>(this.BlobFullTextSearchStopedInfoUid, (string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-606654180 ^ -606805866));

    /// <summary>Остановка индексирования типа</summary>
    public void StopIndexingType(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FullTextSearchService.IndexLog.Warn((object) string.Format((string) FullTextSearchService.fgHpoSGSY0ad2L8AABrV(-2112703338 ^ -2112788796), FullTextSearchService.xIKfLlGiffaEnnuG2fHR((object) type)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            this.DeleteAllFromType(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 0;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_10;
          case 5:
            if (this.GetIndexState() == FullTextSearchState.On)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          default:
            if (this.Provider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 4;
              continue;
            }
            goto case 5;
        }
      }
label_9:
      return;
label_10:
      return;
label_2:;
    }

    /// <summary>Поиск-фильтр в индексе</summary>
    public FullTextSearchResultModel Find(
      Type cardType,
      FullTextSearchResultModel resultModel,
      IEntityFilter filter,
      SerializableFilter filterFields,
      List<Guid> selectedColumns,
      int firstResult,
      int maxResult,
      string sortExpression,
      ListSortDirection sortDirection)
    {
      using (IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>((Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Find))))
      {
        try
        {
          if (this.Provider == null || filter == null || !this.IndexingIsWorking())
            return (FullTextSearchResultModel) null;
          FilterForAttribute filterForAttribute = (FilterForAttribute) ((IEnumerable<object>) filter.GetType().GetCustomAttributes(typeof (FilterForAttribute), true)).FirstOrDefault<object>();
          if (filterForAttribute == null)
            return (FullTextSearchResultModel) null;
          EntityMetadata metadata = (EntityMetadata) MetadataLoader.LoadMetadata(filterForAttribute.EntityType);
          if (metadata == null)
            return (FullTextSearchResultModel) null;
          List<KeyValuePair<PropertyMetadata, ClassMetadata>> allPropertiesAndClasses = MetadataLoader.GetChildProperties((ClassMetadata) metadata);
          List<EntityPropertyMetadata> list = allPropertiesAndClasses.Select<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>) (p => p.Key)).OfType<EntityPropertyMetadata>().ToList<EntityPropertyMetadata>();
          FieldList listSearchFields = new FieldList();
          FilterList listFilterField = new FilterList();
          FastSearchList listFastSearch;
          this.ProcessingFilter(cardType, resultModel, filter, filterFields, out listFastSearch, listSearchFields, listFilterField, (IEnumerable<EntityPropertyMetadata>) list);
          List<string> listReturnFields = new List<string>();
          this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  listReturnFields.AddRange((IEnumerable<string>) p.GetFields(cardType));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (selectedColumns != null)
          {
            foreach (Guid selectedColumn in selectedColumns)
            {
              Guid selectedColumnF = selectedColumn;
              // ISSUE: reference to a compiler-generated method
              EntityPropertyMetadata propertyMetadata = list.FirstOrDefault<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p => FullTextSearchService.\u003C\u003Ec__DisplayClass48_2.jXhenCvsigibUYYMnElx((object) p) == selectedColumnF));
              if (propertyMetadata != null)
              {
                IFullTextSearchDescriptorService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
                List<string> source = serviceNotNull.IsSupportedSearchInIndex((IPropertyMetadata) propertyMetadata) ? serviceNotNull.GetReturnField((IPropertyMetadata) propertyMetadata) : throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88047137), (object) propertyMetadata.TypeUid, (object) propertyMetadata.SubTypeUid, (object) propertyMetadata.Uid, (object) propertyMetadata.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082287384)));
                if (source != null)
                {
                  // ISSUE: reference to a compiler-generated method
                  listReturnFields.AddRange(source.Where<string>((Func<string, bool>) (f => !FullTextSearchService.\u003C\u003Ec.mWGLqrvUH1yeMVRW669N((object) f))));
                }
              }
            }
          }
          SortList sortFields = new SortList();
          List<EntityPropertyMetadata> propertyMetadataList = new List<EntityPropertyMetadata>();
          SortList defaultSortExpression = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetExtensionByFilter(filter).GetDefaultSortExpression();
          if (defaultSortExpression != null)
            sortFields.AddRange(defaultSortExpression.Where<SortListItem>((Func<SortListItem, bool>) (s => s != null)));
          string entityName;
          string sortPropName = CustomPropertyProjection.GetExpressionFromString(sortExpression, out entityName);
          if (sortPropName.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113860295)))
            throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372512629), (object) sortPropName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886404209)));
          EntityPropertyMetadata propertyMetadata1 = list.FirstOrDefault<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p =>
          {
            int num = 1;
            while (true)
            {
              KeyValuePair<PropertyMetadata, ClassMetadata> keyValuePair;
              EntityPropertyMetadata p1;
              switch (num)
              {
                case 1:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c((object) FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.zXNHo5vskeKNo6IR3P7U((object) p1).FullName, (object) entityName))
                  {
                    num = 5;
                    continue;
                  }
                  break;
                case 3:
                  if (keyValuePair.Value == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 9 : 9;
                    continue;
                  }
                  goto case 8;
                case 4:
                  // ISSUE: reference to a compiler-generated method
                  if (FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.zXNHo5vskeKNo6IR3P7U((object) p1) != (Type) null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 2;
                    continue;
                  }
                  break;
                case 5:
                  goto label_12;
                case 6:
                  goto label_6;
                case 7:
                  // ISSUE: reference to a compiler-generated method
                  if (!FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c((object) p1.Name, (object) sortPropName))
                  {
                    num = 10;
                    continue;
                  }
                  goto case 4;
                case 8:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.oF4ZVovsTbPtpUCJGN1c(FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.tKOFUsvsnkyD5DVHoQBM((object) keyValuePair.Value), (object) entityName))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 11 : 4;
                    continue;
                  }
                  goto case 9;
                case 9:
                  // ISSUE: reference to a compiler-generated method
                  if (FullTextSearchService.\u003C\u003Ec__DisplayClass48_3.vHoJaGvsOVYp56Z4BU87((object) entityName))
                  {
                    num = 6;
                    continue;
                  }
                  goto label_7;
                case 10:
                  goto label_7;
                case 11:
                  goto label_14;
                default:
                  p1 = p;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 2;
                  continue;
              }
              keyValuePair = allPropertiesAndClasses.FirstOrDefault<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (pc => pc.Key == p1));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 3;
            }
label_6:
            return true;
label_7:
            return false;
label_12:
            return true;
label_14:
            return true;
          }));
          if (propertyMetadata1 != null)
            propertyMetadataList.Add(propertyMetadata1);
          IFullTextSearchDescriptorService serviceNotNull1 = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
          foreach (EntityPropertyMetadata propertyMetadata2 in propertyMetadataList)
          {
            if (propertyMetadata2 != null)
            {
              SortListItem sortListItem = serviceNotNull1.IsSupportedSearchInIndex((IPropertyMetadata) propertyMetadata2) ? serviceNotNull1.GetSortField((IPropertyMetadata) propertyMetadata2) : throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756915644), (object) propertyMetadata2.TypeUid, (object) propertyMetadata2.SubTypeUid, (object) propertyMetadata2.Uid, (object) propertyMetadata2.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998357702)));
              if (sortListItem == null)
                throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306696062), (object) propertyMetadata2.TypeUid, (object) propertyMetadata2.SubTypeUid, (object) propertyMetadata2.Uid, (object) propertyMetadata2.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210542653)));
              sortListItem.Direction = sortDirection;
              sortFields.Add(sortListItem);
            }
          }
          resultModel = this.Provider.Find(cardType, listFastSearch, listSearchFields, listFilterField, listReturnFields, sortFields, new int?(firstResult), new int?(maxResult));
          if (resultModel != null)
          {
            resultModel.ListReturnFields = new List<string>();
            resultModel.ListReturnFields.AddRange((IEnumerable<string>) listReturnFields);
          }
          return resultModel;
        }
        catch (FullTextFilterException ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.IsCancel = true;
          FullTextSearchService.IndexLog.Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979398095), (Exception) ex);
          return (FullTextSearchResultModel) null;
        }
        catch (Exception ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.Exception = ex;
          Logger.Log.Error((object) ex);
          return (FullTextSearchResultModel) null;
        }
      }
    }

    /// <inheritdoc />
    /// <summary>Поиск-фильтр в индексе</summary>
    public FullTextSearchResultModel Find(
      Type cardType,
      List<string> listReturnFields,
      FilterList listFilterFields,
      SortList listSortFields,
      int firstResult,
      int maxResult)
    {
      using (IndexCallInfo indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>((Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Find))))
      {
        try
        {
          if (this.Provider == null || !this.IndexingIsWorking())
            return (FullTextSearchResultModel) null;
          FullTextSearchResultModel searchResultModel = this.Provider.Find(cardType, listReturnFields, listFilterFields, listSortFields, maxResult);
          if (searchResultModel != null)
          {
            searchResultModel.ListReturnFields = new List<string>();
            searchResultModel.ListReturnFields.AddRange((IEnumerable<string>) listReturnFields);
          }
          return searchResultModel;
        }
        catch (FullTextFilterException ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.IsCancel = true;
          FullTextSearchService.IndexLog.Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323267634), (Exception) ex);
          return (FullTextSearchResultModel) null;
        }
        catch (Exception ex)
        {
          if (indexCallInfo != null)
            indexCallInfo.Exception = ex;
          Logger.Log.Error((object) ex);
          return (FullTextSearchResultModel) null;
        }
      }
    }

    /// <summary>Поиск-фильтр в индексе (количество)</summary>
    public FullTextSearchResultModel Count(
      Type cardType,
      FullTextSearchResultModel resultModel,
      IEntityFilter filter,
      SerializableFilter filterFields)
    {
      int num1 = 2;
      IndexCallInfo indexCallInfo;
      while (true)
      {
        Func<IndexCallInfo> callInfoCreator;
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__50_0 = callInfoCreator = (Func<IndexCallInfo>) (() => new IndexCallInfo(IndexCallsType.Count));
            break;
          case 2:
            // ISSUE: reference to a compiler-generated field
            Func<IndexCallInfo> func = FullTextSearchService.\u003C\u003Ec.\u003C\u003E9__50_0;
            if (func == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            }
            callInfoCreator = func;
            break;
          case 3:
            goto label_49;
          default:
            goto label_2;
        }
        indexCallInfo = DiagnosticsManager.StartCall<IndexCallInfo>(callInfoCreator);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
      }
label_2:
      FullTextSearchResultModel searchResultModel;
      try
      {
        int num2;
        if (this.Provider != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 22 : 19;
        else
          goto label_10;
label_6:
        while (true)
        {
          int num3;
          FilterList listFilterField;
          FilterForAttribute filterForAttribute;
          EntityMetadata metadata;
          FieldList listSearchFields;
          FastSearchList listFastSearch;
          IEnumerable<EntityPropertyMetadata> allProperties;
          switch (num2)
          {
            case 1:
              resultModel = (FullTextSearchResultModel) FullTextSearchService.n3E0XCGi89O8Hx3rHcmt((object) this.Provider, cardType, (object) listFastSearch, (object) listSearchFields, (object) listFilterField);
              num2 = 18;
              continue;
            case 2:
            case 11:
            case 13:
            case 15:
            case 16:
              goto label_49;
            case 3:
            case 23:
              metadata = (EntityMetadata) MetadataLoader.LoadMetadata(FullTextSearchService.YONWoKGivAn5rAEsK5J2((object) filterForAttribute));
              num3 = 8;
              break;
            case 4:
              goto label_10;
            case 5:
              if (filterForAttribute != null)
              {
                num2 = 3;
                continue;
              }
              goto case 6;
            case 6:
              searchResultModel = (FullTextSearchResultModel) null;
              num2 = 2;
              continue;
            case 7:
              searchResultModel = (FullTextSearchResultModel) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 15 : 9;
              continue;
            case 8:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 19 : 16;
                continue;
              }
              goto case 14;
            case 9:
            case 19:
              allProperties = MetadataLoader.GetChildProperties((ClassMetadata) metadata).Select<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>) (p => p.Key)).OfType<EntityPropertyMetadata>();
              num2 = 21;
              continue;
            case 10:
            case 17:
              if (!this.IndexingIsWorking())
              {
                num2 = 7;
                continue;
              }
              goto default;
            case 12:
              this.ProcessingFilter(cardType, resultModel, filter, filterFields, out listFastSearch, listSearchFields, listFilterField, allProperties);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            case 14:
              searchResultModel = (FullTextSearchResultModel) null;
              num2 = 16;
              continue;
            case 18:
              searchResultModel = resultModel;
              num2 = 11;
              continue;
            case 20:
              listFilterField = new FilterList();
              num2 = 12;
              continue;
            case 21:
              listSearchFields = new FieldList();
              num3 = 20;
              break;
            case 22:
              if (filter != null)
              {
                num2 = 10;
                continue;
              }
              goto label_10;
            default:
              // ISSUE: type reference
              filterForAttribute = (FilterForAttribute) ((IEnumerable<object>) FullTextSearchService.nZdevOGiCjXQLHCGMG3P((object) filter.GetType(), FullTextSearchService.N0YHeUGiQUGa1dkfn9sT(__typeref (FilterForAttribute)), true)).FirstOrDefault<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 5;
              continue;
          }
          num2 = num3;
        }
label_10:
        searchResultModel = (FullTextSearchResultModel) null;
        num2 = 13;
        goto label_6;
      }
      catch (FullTextFilterException ex)
      {
        int num4 = 4;
        while (true)
        {
          switch (num4)
          {
            case 1:
            case 2:
              FullTextSearchService.re6dvsGiuu9xh5PL6xcT((object) FullTextSearchService.IndexLog, FullTextSearchService.fgHpoSGSY0ad2L8AABrV(333888594 ^ 1075625116 ^ 1408879822), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 3;
              continue;
            case 3:
              searchResultModel = (FullTextSearchResultModel) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            case 4:
              if (indexCallInfo == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
                continue;
              }
              goto case 5;
            case 5:
              FullTextSearchService.S0O4qnGiZ6KY5VOVXGxF((object) indexCallInfo, true);
              num4 = 2;
              continue;
            default:
              goto label_49;
          }
        }
      }
      catch (Exception ex)
      {
        int num5 = 4;
        while (true)
        {
          switch (num5)
          {
            case 1:
              ((ILogger) FullTextSearchService.CxCkcNGiIjAQqZOi40n0()).Error((object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_49;
            case 3:
              indexCallInfo.Exception = ex;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
              continue;
            case 4:
              if (indexCallInfo != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
                continue;
              }
              goto case 1;
            default:
              searchResultModel = (FullTextSearchResultModel) null;
              num5 = 2;
              continue;
          }
        }
      }
      finally
      {
        if (indexCallInfo != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_46;
              default:
                indexCallInfo.Dispose();
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_46:;
      }
label_49:
      return searchResultModel;
    }

    /// <summary>
    /// Разбор фильтра и формирование по нему данных для поиска в индексе
    /// </summary>
    private void ProcessingFilter(
      Type cardType,
      FullTextSearchResultModel resultModel,
      IEntityFilter filter,
      SerializableFilter filterFields,
      out FastSearchList listFastSearch,
      FieldList listSearchFields,
      FilterList listFilterField,
      IEnumerable<EntityPropertyMetadata> allProperties)
    {
      if (!string.IsNullOrWhiteSpace(filter.Query))
        throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87523133)));
      List<string> forListFastSearch = new List<string>();
      List<EntityPropertyMetadata> list = allProperties.Where<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (FullTextSearchService.\u003C\u003Ec.K9QumfvU7lsfml8AXi6p(p.TypeUid, StringDescriptor.UID))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (FullTextSearchService.\u003C\u003Ec.Eo91D2vUAlxtrwOBZn9D((object) p))
              {
                num = 2;
                continue;
              }
              goto label_4;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return FullTextSearchService.\u003C\u003Ec.K9QumfvU7lsfml8AXi6p(p.TypeUid, TextDescriptor.UID);
label_3:
        return true;
label_4:
        return false;
      })).ToList<EntityPropertyMetadata>();
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              forListFastSearch.AddRange((IEnumerable<string>) p.GetSearchFields(cardType, filter));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      forListFastSearch.AddRange(list.Select<EntityPropertyMetadata, string>((Func<EntityPropertyMetadata, string>) (fsProperty => (string) FullTextSearchService.\u003C\u003Ec.ijqoaPvU0sMDrbbCFYbg(FullTextSearchService.\u003C\u003Ec.qXF8E7vU6H5f9gr5Mho7(-1334993905 ^ -1334947777), FullTextSearchService.\u003C\u003Ec.VEgNW7vUxkN4Tewj8ChT((object) FullTextSearchService.\u003C\u003Ec.i6r182vUDqeGg8a5r72e((object) fsProperty).ToString())))));
      Dictionary<string, Weight> weights = new Dictionary<string, Weight>();
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              p.GetWeightSearchFields(cardType).ForEach<KeyValuePair<string, Weight>>((Action<KeyValuePair<string, Weight>>) (w =>
              {
                if (weights.ContainsKey(w.Key))
                  return;
                weights.Add(w.Key, w.Value);
              }));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      listFastSearch = new FastSearchList(string.IsNullOrWhiteSpace(filter.SearchString) ? "" : filter.SearchString, forListFastSearch, weights);
      if (filterFields != null && filterFields.Properties != null && filterFields.Properties.Any<FilterProperty>())
      {
        ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(filter.GetType());
        foreach (FilterProperty property in filterFields.Properties)
        {
          if (property.Value != null)
          {
            FilterProperty filterPropertyF = property;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            IPropertyMetadata filterPropertyMd = (IPropertyMetadata) classMetadata.Properties.ToList<PropertyMetadata>().FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FullTextSearchService.\u003C\u003Ec__DisplayClass51_2.LeGJ8RvsmcNlsEJLrQGR(FullTextSearchService.\u003C\u003Ec__DisplayClass51_2.tb84jgvsxH61OcqwfIpZ((object) p), FullTextSearchService.\u003C\u003Ec__DisplayClass51_2.Lqhxxovs0HwawgBlgm36((object) filterPropertyF))));
            if (filterPropertyMd != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntityPropertyMetadata propertyMetadata = allProperties.FirstOrDefault<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p => FullTextSearchService.\u003C\u003Ec__DisplayClass51_2.tb84jgvsxH61OcqwfIpZ((object) p) == FullTextSearchService.\u003C\u003Ec__DisplayClass51_2.wjj0DivsyrrUa0TjARYe((object) filterPropertyMd)));
              if (propertyMetadata != null)
              {
                if (!this.FullTextSearchDescriptorService.IsSupportedSearchInIndex((IPropertyMetadata) propertyMetadata))
                  throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312882879), (object) propertyMetadata.TypeUid, (object) propertyMetadata.SubTypeUid, (object) propertyMetadata.Uid, (object) propertyMetadata.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488665141)));
                if (this.FullTextSearchDescriptorService.IsSupportedFullTextSearchInIndex((IPropertyMetadata) propertyMetadata))
                {
                  listSearchFields.Add(this.FullTextSearchDescriptorService.GetSearchField(property.Value, (IPropertyMetadata) propertyMetadata));
                }
                else
                {
                  FilterList autoListFilterField = new FilterList();
                  bool hasProcessing = false;
                  this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
                  {
                    int num = 2;
                    FilterList collection;
                    while (true)
                    {
                      switch (num)
                      {
                        case 1:
                          if (collection != null)
                          {
                            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 4;
                            continue;
                          }
                          goto label_8;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          collection = (FilterList) FullTextSearchService.\u003C\u003Ec__DisplayClass51_3.TTnLn7vsl9MoULfJN5fH((object) p, cardType, (object) filterPropertyF, (object) resultModel);
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                          continue;
                        case 3:
                          goto label_2;
                        case 4:
                          autoListFilterField.AddRange((IEnumerable<FilterListItem>) collection);
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                          continue;
                        default:
                          hasProcessing = true;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 3;
                          continue;
                      }
                    }
label_2:
                    return;
label_8:;
                  }));
                  if (hasProcessing)
                  {
                    listFilterField.AddRange((IEnumerable<FilterListItem>) autoListFilterField);
                  }
                  else
                  {
                    FilterListItem filterField = this.FullTextSearchDescriptorService.GetFilterField(property.Value, (IPropertyMetadata) propertyMetadata, filter);
                    if (filterField != null)
                      listFilterField.Add(filterField);
                  }
                }
              }
              else
              {
                FilterList customListFilterField = new FilterList();
                FieldList customListSearchField = new FieldList();
                bool hasProcessing = false;
                this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
                {
                  int num1 = 2;
                  while (true)
                  {
                    int num2 = num1;
                    FilterList collection;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          goto label_6;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          collection = (FilterList) FullTextSearchService.\u003C\u003Ec__DisplayClass51_4.m0yuqxvsYuEP2HvPpEpY((object) p, cardType, (object) filterPropertyF, (object) resultModel);
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
                          continue;
                        case 3:
                          goto label_3;
                        case 4:
                          customListFilterField.AddRange((IEnumerable<FilterListItem>) collection);
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                          continue;
                        default:
                          hasProcessing = true;
                          num2 = 3;
                          continue;
                      }
                    }
label_6:
                    if (collection != null)
                      num1 = 4;
                    else
                      goto label_9;
                  }
label_3:
                  return;
label_9:;
                }));
                this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    int num4 = num3;
                    FieldList customSearchFields;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          customSearchFields = p.GetCustomSearchFields(cardType, filterPropertyF);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                          continue;
                        case 2:
                          hasProcessing = true;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 1;
                          continue;
                        case 3:
                          goto label_3;
                        case 4:
                          customListSearchField.AddRange((IEnumerable<FieldListItem>) customSearchFields);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 1;
                          continue;
                        default:
                          goto label_5;
                      }
                    }
label_5:
                    if (customSearchFields != null)
                      num3 = 4;
                    else
                      goto label_9;
                  }
label_3:
                  return;
label_9:;
                }));
                if (hasProcessing)
                {
                  listFilterField.AddRange((IEnumerable<FilterListItem>) customListFilterField);
                  listSearchFields.AddRange((IEnumerable<FieldListItem>) customListSearchField);
                }
                else
                  throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542806671), (object) filterPropertyF.Uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979564990)));
              }
            }
          }
        }
      }
      this.Points.ForEach((Action<IFullTextSearchFieldsMappingsReIndexingExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              listFilterField.AddRange((IEnumerable<FilterListItem>) p.GetFilterFields(cardType, resultModel));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    private void SaveDirtyInfoProgres(
      IIndexQueue item,
      Guid typeUid,
      long? lastId,
      int attempt,
      Type cardType)
    {
      if (typeUid != Guid.Empty)
      {
        ContinueInfo continueInfo = this.ParseContinueInfo(item.DirtyValues);
        if (attempt > 5)
        {
          continueInfo.RemovePageInfo(typeUid);
          // ISSUE: reference to a compiler-generated method
          IFullTextSearchFieldsMappingsReIndexingExtension indexingExtension = this.Points.FirstOrDefault<IFullTextSearchFieldsMappingsReIndexingExtension>((Func<IFullTextSearchFieldsMappingsReIndexingExtension, bool>) (a => FullTextSearchService.\u003C\u003Ec__DisplayClass52_0.ukcNFGvsz59AyYoAx1gv((object) a, typeUid) != (Type) null));
          if (indexingExtension != null && indexingExtension.SettingModule != null)
          {
            indexingExtension.DisableIndexing(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195756909)));
            FullTextSearchService.IndexLog.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561153268), (object) indexingExtension.SettingModule.ModuleName);
          }
          else
            FullTextSearchService.IndexLog.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825341936), (object) typeUid);
          this.DeleteAllFromType(cardType);
        }
        else
          continueInfo.AddIdInfo(typeUid, lastId ?? 0L, attempt);
        item.DirtyValues = this.ConvertToContinueInfo(continueInfo);
      }
      item.Save();
    }

    /// <summary>
    /// Преобразование строкового представления информации о продолжении индексации в объект
    /// </summary>
    private ContinueInfo ParseContinueInfo(string dirtyValues)
    {
      int num1 = 26;
      ContinueInfo continueInfo;
      while (true)
      {
        int num2 = num1;
        string[] strArray1;
        string[] strArray2;
        Guid result1;
        long result2;
        int result3;
        int result4;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!int.TryParse(strArray2[2], out result4))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 9 : 10;
                continue;
              }
              goto case 22;
            case 2:
            case 32:
              FullTextSearchService.dOVskbGiKhnJkuHVxf8s((object) continueInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 12 : 27;
              continue;
            case 3:
              if (strArray2.Length == 4)
              {
                num2 = 14;
                continue;
              }
              goto case 4;
            case 4:
            case 7:
            case 10:
            case 16:
            case 18:
            case 31:
              ++index;
              num2 = 21;
              continue;
            case 5:
              result3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 6:
              if (!FullTextSearchService.hFmFpnGiiW1Ad7W7VlK8(FullTextSearchService.s5V3fBGiSYLRKnU8VKGN((object) strArray2[1]), FullTextSearchService.fgHpoSGSY0ad2L8AABrV(~538519529 ^ -538563194)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 17;
                continue;
              }
              goto case 15;
            case 8:
            case 9:
              continueInfo.PagesInfo.Add(result1, new ContinueInfo.PageInfo());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 5 : 18;
              continue;
            case 11:
              if (strArray2.Length != 3)
              {
                num2 = 3;
                continue;
              }
              goto case 14;
            case 12:
            case 21:
              if (index >= strArray1.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 29;
                continue;
              }
              goto case 23;
            case 13:
              if (strArray2[2].Length <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 8 : 0;
                continue;
              }
              goto case 6;
            case 14:
              if (!Guid.TryParse(strArray2[0], out result1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 4;
                continue;
              }
              goto case 13;
            case 15:
              if (long.TryParse(strArray2[2], out result2))
              {
                num2 = 28;
                continue;
              }
              goto case 4;
            case 17:
            case 19:
              if (!FullTextSearchService.hFmFpnGiiW1Ad7W7VlK8(FullTextSearchService.s5V3fBGiSYLRKnU8VKGN((object) strArray2[1]), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70054443)))
              {
                num2 = 31;
                continue;
              }
              goto case 1;
            case 20:
              index = 0;
              num2 = 12;
              continue;
            case 22:
              FullTextSearchService.gNlvAMGiqQAKHs9o8U5j((object) continueInfo, result1, result4, result3);
              num2 = 7;
              continue;
            case 23:
              strArray2 = strArray1[index].Split('.');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 1;
              continue;
            case 24:
              strArray1 = (string[]) FullTextSearchService.jX9INFGiVDr65x5c7N5y((object) dirtyValues, (object) new char[1]
              {
                ';'
              });
              num2 = 20;
              continue;
            case 25:
              if (FullTextSearchService.jeMXU7GiWtpq7MWtlP8R((object) dirtyValues))
              {
                num2 = 32;
                continue;
              }
              goto case 24;
            case 26:
              continueInfo = new ContinueInfo();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 25;
              continue;
            case 27:
            case 29:
              goto label_6;
            case 28:
              FullTextSearchService.LkmWGSGiRyDCbwJjyuN2((object) continueInfo, result1, result2, result3);
              num2 = 16;
              continue;
            case 30:
              goto label_26;
            default:
              if (strArray2.Length == 4)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 6 : 30;
                continue;
              }
              goto case 11;
          }
        }
label_26:
        int.TryParse(strArray2[3], out result3);
        num1 = 11;
      }
label_6:
      return continueInfo;
    }

    /// <summary>
    /// Преобразование объекта содержащего информацию о продолжении индексации в строковое представление
    /// </summary>
    private string ConvertToContinueInfo(ContinueInfo continueInfo)
    {
      int num1 = 2;
      string continueInfo1;
      Dictionary<Guid, ContinueInfo.PageInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = continueInfo.PagesInfo.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            continueInfo1 = "";
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return continueInfo1;
label_5:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_17;
        else
          goto label_10;
label_7:
        KeyValuePair<Guid, ContinueInfo.PageInfo> current;
        int? page;
        long? lastId;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              continueInfo1 = (string) FullTextSearchService.QwupiPGiTQj97kQeaQZ6((object) continueInfo1, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874219977), (object) new object[4]
              {
                (object) current.Key,
                FullTextSearchService.fgHpoSGSY0ad2L8AABrV(874012245 ^ 874026125),
                (object) current.Value.Page,
                (object) FullTextSearchService.aYhI8wGiXG8whnGerYuf((object) current.Value)
              }));
              num2 = 12;
              continue;
            case 2:
              goto label_17;
            case 3:
              continueInfo1 += (string) FullTextSearchService.JLRHGAGSLN1tDB5iTsUG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536686582), (object) new object[4]
              {
                (object) current.Key,
                null,
                null,
                (object) 0
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 9;
              continue;
            case 4:
            case 9:
            case 11:
            case 12:
              goto label_9;
            case 5:
              lastId = current.Value.LastId;
              num2 = 6;
              continue;
            case 6:
              if (lastId.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 7:
              goto label_2;
            case 8:
              if (!FullTextSearchService.sVMlM4GSUnxTQ9AY6k0g(current.Key, Guid.Empty))
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 10:
              page = current.Value.Page;
              num2 = 13;
              continue;
            case 13:
              if (page.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            default:
              continueInfo1 = (string) FullTextSearchService.QwupiPGiTQj97kQeaQZ6((object) continueInfo1, FullTextSearchService.JLRHGAGSLN1tDB5iTsUG(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(647913418 ^ 647858262), (object) new object[4]
              {
                (object) current.Key,
                (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867236859),
                (object) current.Value.LastId,
                (object) FullTextSearchService.aYhI8wGiXG8whnGerYuf((object) current.Value)
              }));
              num2 = 11;
              continue;
          }
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 7 : 0;
        goto label_7;
label_17:
        current = enumerator.Current;
        num2 = 8;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        {
          num2 = 8;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public FullTextSearchService()
    {
      FullTextSearchService.F8wo4hGik136Sr72gTQm();
      this.objectIndex = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FullTextSearchService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FullTextSearchService.IndexLog = (ILogger) FullTextSearchService.HsQkADGinDAKG2q1Alo1(FullTextSearchService.fgHpoSGSY0ad2L8AABrV(1819636893 << 3 ^ 1671994488));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            FullTextSearchService.F8wo4hGik136Sr72gTQm();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool svHTnFGSMrfx9WGJbaKX() => FullTextSearchService.zoSitbGSyLMSR9ms7NtQ == null;

    internal static FullTextSearchService FMWAkgGSJw2n3A6yAH1s() => FullTextSearchService.zoSitbGSyLMSR9ms7NtQ;

    internal static object xT4UloGS9N7QXN3i8jM3() => (object) DataAccessManager.BLOBManager;

    internal static Guid IxAwiJGSdB9BFpCe7aDV([In] object obj0) => ((FullTextSearchSettings) obj0).ProviderUid;

    internal static object NOHLYUGSlP7MTR4Jk6gL() => (object) ComponentManager.Current;

    internal static bool x66jIWGSroJxCobKf9Yi([In] object obj0) => ((IFullTextSearchProvider) obj0).GetServerStatus();

    internal static void hdvqeLGSgMh54UjtNtoS([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static object k7udifGS5LS4W4XHDujW(Type t) => InterfaceActivator.Create(t);

    internal static object anfqmHGSj9HNVWQ9uJmi([In] object obj0) => (object) ((FullTextSearchObjectContainer) obj0).SearchObject;

    internal static object fgHpoSGSY0ad2L8AABrV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JLRHGAGSLN1tDB5iTsUG([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static bool sVMlM4GSUnxTQ9AY6k0g([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool PYbCwxGSsp1ZhpISAUCy([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object rqsk9HGSc47bwP4Fdy7P([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object xlNxXoGSzg7OR7SnOT7b([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void yWlb45GiF4OqXGSKdj5C([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object IUihCiGiBexsLfEIaEHG([In] object obj0) => (object) ((IIndexQueue) obj0).DirtyValues;

    internal static bool jeMXU7GiWtpq7MWtlP8R([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void YCrOfoGioCkoucIh2GEA([In] object obj0, bool value) => ((IndexResult) obj0).Result = value;

    internal static void WqHVPZGibtl6FoX1rRXQ([In] object obj0) => ((IEntity) obj0).Save();

    internal static object uZcdBBGihaiGwKchLmPA() => (object) IndexQueueManager.Instance;

    internal static void Hgh1CtGiGIgc4Doh2UBG([In] object obj0) => ((IndexQueueManager) obj0).ClearQueue();

    internal static bool edCG0IGiE5iyIX4YhmTN([In] object obj0) => ((IFullTextSearchProvider) obj0).DeleteIndex();

    internal static object xIKfLlGiffaEnnuG2fHR([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type N0YHeUGiQUGa1dkfn9sT([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object nZdevOGiCjXQLHCGMG3P([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static Type YONWoKGivAn5rAEsK5J2([In] object obj0) => ((FilterForAttribute) obj0).EntityType;

    internal static object n3E0XCGi89O8Hx3rHcmt(
      [In] object obj0,
      Type cardType,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IFullTextSearchProvider) obj0).Count(cardType, (FastSearchList) obj2, (FieldList) obj3, (FilterList) obj4);
    }

    internal static void S0O4qnGiZ6KY5VOVXGxF([In] object obj0, bool value) => ((IndexCallInfo) obj0).IsCancel = value;

    internal static void re6dvsGiuu9xh5PL6xcT([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object CxCkcNGiIjAQqZOi40n0() => (object) Logger.Log;

    internal static object jX9INFGiVDr65x5c7N5y([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object s5V3fBGiSYLRKnU8VKGN([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool hFmFpnGiiW1Ad7W7VlK8([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void LkmWGSGiRyDCbwJjyuN2([In] object obj0, Guid typeUid, long lastId, int attempt) => ((ContinueInfo) obj0).AddIdInfo(typeUid, lastId, attempt);

    internal static void gNlvAMGiqQAKHs9o8U5j(
      [In] object obj0,
      Guid typeUid,
      int pageIndex,
      int attempt)
    {
      ((ContinueInfo) obj0).AddPageInfo(typeUid, pageIndex, attempt);
    }

    internal static void dOVskbGiKhnJkuHVxf8s([In] object obj0) => ((ContinueInfo) obj0).PrepareEmptyPages();

    internal static int aYhI8wGiXG8whnGerYuf([In] object obj0) => ((ContinueInfo.PageInfo) obj0).Attempt;

    internal static object QwupiPGiTQj97kQeaQZ6([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void F8wo4hGik136Sr72gTQm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object HsQkADGinDAKG2q1Alo1([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}

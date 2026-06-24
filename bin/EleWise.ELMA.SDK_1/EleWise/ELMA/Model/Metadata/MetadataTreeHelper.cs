// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataTreeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Помощник для построения дерева метаданных</summary>
  public class MetadataTreeHelper
  {
    private IEnumerable<ICodeItemMetadata> metadataList;
    private readonly IMetadataService metadataService;
    private MetadataTreeHelper.GroupNode root;
    private bool showDisplayName;
    private bool showEmptyGroups;
    private bool generateForPublicApi;
    private Dictionary<long, MetadataTreeHelper.GroupNode> groupNodesById;
    internal const string CacheKey = "MetadataItemGroupDTO[Root]";
    private static MetadataTreeHelper lAPclcb6QU7uaVlojpFD;

    /// <summary>Построить дерево объектов</summary>
    /// <param name="metadataList">Список метаданных</param>
    /// <param name="showDisplayName">Показывать отображаемое имя</param>
    /// <param name="showEmptyGroups">Показывать ли пустые группы</param>
    /// <returns>Корневая группа</returns>
    public static MetadataTreeHelper.GroupNode BuildTree(
      IEnumerable<ICodeItemMetadata> metadataList,
      bool showDisplayName = true,
      bool showEmptyGroups = false,
      bool generateForPublicApi = false)
    {
      return MetadataTreeHelper.BuildTree(metadataList, (IMetadataService) null, showDisplayName, showEmptyGroups, generateForPublicApi);
    }

    /// <summary>Построить дерево объектов</summary>
    /// <param name="metadataList">Список метаданных</param>
    /// <param name="metadataService">Интерфейс службы управления метаданными</param>
    /// <param name="showDisplayName">Показывать отображаемое имя</param>
    /// <param name="showEmptyGroups">Показывать ли пустые группы</param>
    /// <param name="generateForPublicApi">Генерировать для PublicAPI</param>
    /// <returns>Корневая группа</returns>
    public static MetadataTreeHelper.GroupNode BuildTree(
      IEnumerable<ICodeItemMetadata> metadataList,
      IMetadataService metadataService,
      bool showDisplayName = true,
      bool showEmptyGroups = false,
      bool generateForPublicApi = false)
    {
      Contract.ArgumentNotNull((object) metadataList, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239453104));
      return new MetadataTreeHelper(metadataList, metadataService)
      {
        showDisplayName = showDisplayName,
        showEmptyGroups = showEmptyGroups,
        generateForPublicApi = generateForPublicApi
      }.BuildTreeImpl(metadataList);
    }

    public static MetadataTreeHelper.GroupNode GetGroupByName(
      MetadataTreeHelper.GroupNode rootGroupNode,
      string groupName)
    {
      int num1 = 1;
      List<MetadataTreeHelper.GroupNode>.Enumerator enumerator;
      MetadataTreeHelper.GroupNode groupByName;
      while (true)
      {
        switch (num1)
        {
          case 1:
            groupByName = (MetadataTreeHelper.GroupNode) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_25;
          default:
            enumerator = rootGroupNode.GroupNodes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      try
      {
label_4:
        if (enumerator.MoveNext())
          goto label_11;
        else
          goto label_5;
label_3:
        MetadataTreeHelper.GroupNode current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
            case 10:
              goto label_4;
            case 2:
              if (groupByName != null)
              {
                num2 = 10;
                continue;
              }
              goto case 5;
            case 3:
              groupByName = current;
              num2 = 2;
              continue;
            case 4:
              goto label_11;
            case 5:
              if (MetadataTreeHelper.HsWbDPb6IRarxbP3FhNp((object) current) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 6;
                continue;
              }
              goto case 11;
            case 7:
              if (MetadataTreeHelper.L2lcvlb6uETDBuW5IyCV(MetadataTreeHelper.Q7OPTIb68IuX29DjSTN9((object) current), (object) groupName))
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 8:
              if (!MetadataTreeHelper.t5iqiUb6ZvZH4yotnwoP(MetadataTreeHelper.Q7OPTIb68IuX29DjSTN9((object) current)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 7 : 7;
                continue;
              }
              goto case 2;
            case 9:
              groupByName = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
            case 11:
              if ((string) MetadataTreeHelper.fcqGknb6VYSe3wtqEGLK(MetadataTreeHelper.HsWbDPb6IRarxbP3FhNp((object) current)) == groupName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 7 : 9;
                continue;
              }
              goto label_4;
            default:
              goto label_25;
          }
        }
label_5:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
        goto label_3;
label_11:
        current = enumerator.Current;
        num2 = 8;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        {
          num2 = 1;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_25:
      return groupByName;
    }

    /// <summary>Ctor</summary>
    /// <param name="metadataList">Список метаданных</param>
    /// <param name="metadataService">Интерфейс службы управления метаданными</param>
    private MetadataTreeHelper(
      IEnumerable<ICodeItemMetadata> metadataList,
      IMetadataService metadataService = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.groupNodesById = new Dictionary<long, MetadataTreeHelper.GroupNode>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metadataList = metadataList;
      this.metadataService = metadataService;
    }

    /// <summary>Построить дерево объектов</summary>
    /// <param name="metadataList">Список метаданных</param>
    /// <returns>Корневая группа</returns>
    private MetadataTreeHelper.GroupNode BuildTreeImpl(IEnumerable<ICodeItemMetadata> metadataList)
    {
      this.root = new MetadataTreeHelper.GroupNode();
      this.groupNodesById.Clear();
      MetadataItemGroupDTO rootGroup = this.GetRootGroup();
      if (rootGroup != null)
      {
        foreach (MetadataItemGroupDTO subGroup in rootGroup.SubGroups)
          this.AddGroupNode(subGroup, this.root);
      }
      foreach (ICodeItemMetadata metadata in metadataList)
        this.AddNode(metadata);
      if (!this.showEmptyGroups)
        this.RemoveEmptyGroups(this.root);
      this.ResortNodes(this.root);
      return this.root;
    }

    private MetadataItemGroupDTO GetRootGroup()
    {
      int num1 = 11;
      Tuple<DateTime, MetadataItemGroupDTO> tuple;
      MetadataItemGroupDTO rootGroup;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IContextBoundVariableService service1;
          IMetadataItemGroupDTOManager service2;
          switch (num2)
          {
            case 2:
              if (MetadataTreeHelper.UMDIsab6qeRjxq7OmmcC(MetadataTreeHelper.QpMsfMb6RUA3PBwyYF2y() - tuple.Item1, TimeSpan.FromSeconds(15.0)))
              {
                num2 = 8;
                continue;
              }
              break;
            case 3:
            case 9:
              MetadataTreeHelper.gmshasb6X3Ao2ifslbZg(MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1505778440 - 1981636111 ^ -476050769), (object) tuple);
              num2 = 15;
              continue;
            case 4:
              if (service2 != null)
              {
                rootGroup = (MetadataItemGroupDTO) MetadataTreeHelper.uwUJB6b6KNdI8YvtMAQK((object) service2);
                num2 = 6;
                continue;
              }
              goto label_20;
            case 5:
            case 16:
              if (tuple != null)
              {
                num2 = 2;
                continue;
              }
              break;
            case 6:
              tuple = new Tuple<DateTime, MetadataItemGroupDTO>(MetadataTreeHelper.QpMsfMb6RUA3PBwyYF2y(), rootGroup);
              num2 = 12;
              continue;
            case 7:
              goto label_15;
            case 8:
              goto label_8;
            case 10:
              goto label_6;
            case 11:
              if (MetadataTreeHelper.hbhW8Kb6S8R6e4AUO1Dq())
              {
                service1 = Locator.GetService<IContextBoundVariableService>();
                num2 = 18;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 10 : 7;
              continue;
            case 12:
              if (service1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 8 : 9;
                continue;
              }
              goto case 17;
            case 13:
              service1.TryGetValue<Tuple<DateTime, MetadataItemGroupDTO>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921109611), out tuple);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 5 : 3;
              continue;
            case 14:
            case 15:
              goto label_5;
            case 17:
              service1.Set((string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(87862435 ^ 87972597), (object) tuple);
              num2 = 14;
              continue;
            case 18:
              if (service1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto case 13;
            default:
              tuple = (Tuple<DateTime, MetadataItemGroupDTO>) CallContext.GetData((string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(--1867379187 ^ 1867450277));
              num2 = 16;
              continue;
          }
          service2 = Locator.GetService<IMetadataItemGroupDTOManager>();
          num2 = 4;
        }
label_20:
        num1 = 7;
      }
label_5:
      return rootGroup;
label_6:
      return (MetadataItemGroupDTO) null;
label_8:
      return tuple.Item2;
label_15:
      return this.GenerateRootGroup();
    }

    private MetadataItemGroupDTO GenerateRootGroup()
    {
      int num1 = 1;
      MetadataItemGroupDTO rootGroup;
      while (true)
      {
        int num2 = num1;
        IRuntimeApplication service;
        ITransformationProvider transformationProvider;
        string sql;
        IDataReader dataReader;
        List<KeyValuePair<long, MetadataItemGroupDTO>>.Enumerator enumerator;
        Dictionary<long, MetadataItemGroupDTO> dictionary;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MetadataItemGroupDTO metadataItemGroupDto1 = new MetadataItemGroupDTO();
              MetadataTreeHelper.l3syMBb6kyOKURtgOKRg((object) metadataItemGroupDto1, MetadataTreeHelper.M41Fghb6Tw4d99r6ak3D(MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(-281842504 ^ -281939906)));
              MetadataTreeHelper.mNTK6Bb6ndZmhDyyc5U2((object) metadataItemGroupDto1, (object) EleWise.ELMA.SR.T((string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(272623989 ^ 272463347)));
              rootGroup = metadataItemGroupDto1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 2:
              dataReader = transformationProvider.ExecuteQuery(sql, (Dictionary<string, object>) null);
              num2 = 12;
              continue;
            case 3:
              if (service != null)
              {
                transformationProvider = (ITransformationProvider) MetadataTreeHelper.HHYKefb6O6DPsdAlFRW6((object) service);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 4 : 9;
                continue;
              }
              goto label_44;
            case 4:
              try
              {
label_12:
                if (enumerator.MoveNext())
                  goto label_14;
                else
                  goto label_13;
label_11:
                KeyValuePair<long, MetadataItemGroupDTO> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_14;
                    case 2:
                      goto label_12;
                    case 3:
                      dictionary[MetadataTreeHelper.kWpMlTb6AWtX7tS8nA4E((object) current.Value)].SubGroups.Add(current.Value);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 0;
                      continue;
                    default:
                      goto label_52;
                  }
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                goto label_11;
label_14:
                current = enumerator.Current;
                num3 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                {
                  num3 = 1;
                  goto label_11;
                }
                else
                  goto label_11;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 5:
label_52:
              List<MetadataItemGroupDTO> subGroups = rootGroup.SubGroups;
              Dictionary<long, MetadataItemGroupDTO>.ValueCollection values = dictionary.Values;
              // ISSUE: reference to a compiler-generated field
              System.Func<MetadataItemGroupDTO, bool> func1 = MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__17_0;
              System.Func<MetadataItemGroupDTO, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__17_0 = predicate1 = (System.Func<MetadataItemGroupDTO, bool>) (q => MetadataTreeHelper.\u003C\u003Ec.I14w3GCwIlcxq1BehkZy((object) q) == 0L);
              }
              else
                goto label_23;
label_54:
              IEnumerable<MetadataItemGroupDTO> collection = values.Where<MetadataItemGroupDTO>(predicate1);
              subGroups.AddRange(collection);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 10;
              continue;
label_23:
              predicate1 = func1;
              goto label_54;
            case 6:
              dictionary = new Dictionary<long, MetadataItemGroupDTO>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
              continue;
            case 7:
label_49:
              Dictionary<long, MetadataItemGroupDTO> source = dictionary;
              // ISSUE: reference to a compiler-generated field
              System.Func<KeyValuePair<long, MetadataItemGroupDTO>, bool> func2 = MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__17_1;
              System.Func<KeyValuePair<long, MetadataItemGroupDTO>, bool> predicate2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__17_1 = predicate2 = (System.Func<KeyValuePair<long, MetadataItemGroupDTO>, bool>) (q => q.Value.ParentId != 0L);
              }
              else
                goto label_55;
label_51:
              enumerator = source.Where<KeyValuePair<long, MetadataItemGroupDTO>>(predicate2).ToList<KeyValuePair<long, MetadataItemGroupDTO>>().GetEnumerator();
              num2 = 4;
              continue;
label_55:
              predicate2 = func2;
              goto label_51;
            case 8:
              goto label_7;
            case 9:
              if (transformationProvider.TableExists((string) MetadataTreeHelper.tb0r7bb6eTkvSx466xss(MetadataTreeHelper.TXlcVUb62GEYllXoTlrS((object) transformationProvider), MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(-1858887263 ^ -1859037393))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 13 : 6;
                continue;
              }
              goto label_5;
            case 10:
              goto label_47;
            case 11:
              goto label_5;
            case 12:
              try
              {
label_28:
                if (MetadataTreeHelper.ARY4kBb66B7r52TwRTNr((object) dataReader))
                  goto label_27;
                else
                  goto label_29;
label_22:
                MetadataItemGroupDTO metadataItemGroupDto2;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      MetadataTreeHelper.iicWcFb631kkH0vXckI8((object) metadataItemGroupDto2, !(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1142330761 ^ 1541959139 ^ 536849860)) is DBNull) ? (DateTime) MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538473032)) : DateTime.MinValue);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_49;
                    case 3:
                      goto label_27;
                    case 4:
                      metadataItemGroupDto2.Id = Convert.ToInt64(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1669371371 ^ 1669338293)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 5 : 11;
                      continue;
                    case 5:
                      dictionary.Add(metadataItemGroupDto2.Id, metadataItemGroupDto2);
                      num5 = 7;
                      continue;
                    case 6:
                      MetadataTreeHelper.l3syMBb6kyOKURtgOKRg((object) metadataItemGroupDto2, !(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1142330761 ^ 1541959139 ^ 536775594)) is DBNull) ? (object) (string) MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727337846)) : (object) string.Empty);
                      num5 = 12;
                      continue;
                    case 7:
                      goto label_28;
                    case 8:
                      MetadataTreeHelper.IDlKVbb64FrVlqP8yvEo((object) metadataItemGroupDto2, MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(647913418 ^ 647801128)) is DBNull ? 0L : MetadataTreeHelper.dluXylb6t9rG36TFP5w7(dataReader[(string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(132912447 ^ 133096413)]));
                      num5 = 5;
                      continue;
                    case 9:
                      MetadataTreeHelper.mNTK6Bb6ndZmhDyyc5U2((object) metadataItemGroupDto2, !(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1642859704 ^ 1643051532)) is DBNull) ? (object) (string) MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822814036)) : (object) string.Empty);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
                      continue;
                    case 10:
                      metadataItemGroupDto2.Uid = MetadataTreeHelper.yfWnnYb6DrAgBs0N7qI8(MetadataTreeHelper.TXlcVUb62GEYllXoTlrS((object) transformationProvider), MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(901793403 ^ 901786089)));
                      num5 = 4;
                      continue;
                    case 11:
                      MetadataTreeHelper.Uwsxutb6wElA3la1HoIM((object) metadataItemGroupDto2, MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(-441065788 ^ -2092910478 ^ 1727395456)) is DBNull ? 0L : MetadataTreeHelper.dluXylb6t9rG36TFP5w7(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77722681)]));
                      num5 = 8;
                      continue;
                    case 12:
                      MetadataTreeHelper.ansQqob6N8iZOodqMA0f((object) metadataItemGroupDto2, !(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978444098)) is DBNull) ? (object) (string) MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1012087039 ^ 1012055731)) : (object) string.Empty);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 9 : 6;
                      continue;
                    default:
                      MetadataTreeHelper.D7Uloab6a98m2WFtyUao((object) metadataItemGroupDto2, !(MetadataTreeHelper.eaFcfab61J9ujUHrXSqd((object) dataReader, MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(222162814 ^ 222239152)) is DBNull) && MetadataTreeHelper.R5LU1ub6pfYmChanuWI2(dataReader[(string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(-70007027 ^ -70176317)]));
                      num5 = 10;
                      continue;
                  }
                }
label_27:
                metadataItemGroupDto2 = new MetadataItemGroupDTO();
                num5 = 6;
                goto label_22;
label_29:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 2;
                goto label_22;
              }
              finally
              {
                int num6;
                if (dataReader == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                else
                  goto label_40;
label_39:
                switch (num6)
                {
                  case 2:
                    break;
                  default:
                }
label_40:
                MetadataTreeHelper.B1DFcrb6HpTjmDc8mU3R((object) dataReader);
                num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                {
                  num6 = 1;
                  goto label_39;
                }
                else
                  goto label_39;
              }
            case 13:
              sql = (string) MetadataTreeHelper.SxxMwGb6PIqRYO28uPbS(MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(87862435 ^ 87830149), MetadataTreeHelper.tb0r7bb6eTkvSx466xss(MetadataTreeHelper.TXlcVUb62GEYllXoTlrS((object) transformationProvider), MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(1642859704 ^ 1643051574)));
              num2 = 6;
              continue;
            default:
              service = Locator.GetService<IRuntimeApplication>();
              num2 = 3;
              continue;
          }
        }
label_44:
        num1 = 8;
      }
label_5:
      return (MetadataItemGroupDTO) null;
label_7:
      return (MetadataItemGroupDTO) null;
label_47:
      return rootGroup;
    }

    /// <summary>Добавить узел дерева для группы объектов</summary>
    /// <param name="group"></param>
    /// <param name="parentNode"></param>
    private void AddGroupNode(MetadataItemGroupDTO group, MetadataTreeHelper.GroupNode parentNode)
    {
      int num1 = 6;
      MetadataTreeHelper.GroupNode parentNode1;
      List<MetadataItemGroupDTO>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            parentNode.GroupNodes.Add(parentNode1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 2;
            continue;
          case 2:
            goto label_5;
          case 3:
            enumerator = group.SubGroups.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_16;
          case 5:
            goto label_20;
          case 6:
            if (group == null)
            {
              num1 = 5;
              continue;
            }
            MetadataTreeHelper.GroupNode groupNode = new MetadataTreeHelper.GroupNode();
            MetadataTreeHelper.vrcMn8b6x9VJGyEYwHZV((object) groupNode, this.showDisplayName ? MetadataTreeHelper.M41Fghb6Tw4d99r6ak3D(MetadataTreeHelper.FjarqBb674WCYOO4se7i((object) group)) : (object) group.Name);
            MetadataTreeHelper.tJlgrBb60uR3mXevWx9Z((object) groupNode, (object) group);
            parentNode1 = groupNode;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          default:
            this.groupNodesById[group.Id] = parentNode1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
        }
      }
label_16:
      return;
label_20:
      return;
label_5:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_9;
label_6:
        MetadataItemGroupDTO current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.AddGroupNode(current, parentNode1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 3;
              continue;
            case 2:
              goto label_12;
            case 3:
              goto label_8;
            default:
              goto label_10;
          }
        }
label_12:
        return;
label_9:
        num2 = 2;
        goto label_6;
label_10:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        {
          num2 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>
    /// Добавить узел дерева по информации из объекта метаданных
    /// </summary>
    /// <param name="metadata">Объект метаданных</param>
    private void AddNode(ICodeItemMetadata metadata)
    {
      int num = 13;
      IGroupedMetadata groupedMetadata;
      MetadataTreeHelper.GroupNode groupNode1;
      MetadataTreeHelper.MetadataNode metadataNode1;
      MetadataTreeHelper.GroupNode groupNode2;
      while (true)
      {
        switch (num)
        {
          case 1:
            groupNode1 = groupNode2;
            num = 10;
            continue;
          case 2:
          case 8:
            groupNode1 = this.GetGroupByNamespace(metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 3 : 9;
            continue;
          case 3:
            goto label_15;
          case 4:
            if (!this.groupNodesById.TryGetValue(MetadataTreeHelper.jCbDnPb6ypDDMAhIFam5((object) groupedMetadata), out groupNode2))
            {
              num = 11;
              continue;
            }
            goto case 1;
          case 5:
            groupedMetadata = metadata as IGroupedMetadata;
            num = 6;
            continue;
          case 6:
            if (groupedMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 7 : 7;
              continue;
            }
            goto case 2;
          case 7:
            if (MetadataTreeHelper.jCbDnPb6ypDDMAhIFam5((object) groupedMetadata) <= 0L)
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 9:
          case 10:
          case 11:
            MetadataTreeHelper.MetadataNode metadataNode2 = new MetadataTreeHelper.MetadataNode();
            metadataNode2.Name = !this.showDisplayName ? (string) MetadataTreeHelper.FrwbYtb6M2UyWIHW6TcZ((object) metadata) : (this.metadataService == null ? (string) MetadataTreeHelper.VxORYkb6JUAk9Xg5fQd9((object) metadata) : (string) MetadataTreeHelper.AkDvHcb69I01gsoOd9oP((object) this.metadataService, (object) metadata));
            metadataNode2.Metadata = metadata;
            metadataNode1 = metadataNode2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 12:
            groupNode1 = this.root;
            num = 5;
            continue;
          case 13:
            MetadataTreeHelper.Jyn93qb6miLc2J9s2jKp((object) metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521251458));
            num = 12;
            continue;
          default:
            groupNode1.MetadataNodes.Add(metadataNode1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 2;
            continue;
        }
      }
label_15:;
    }

    /// <summary>
    /// Получить или добавить группу по пространству имен объекта метаданных
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    private MetadataTreeHelper.GroupNode GetGroupByNamespace(ICodeItemMetadata metadata)
    {
      int num1 = 11;
      MetadataTreeHelper.GroupNode groupByNamespace;
      while (true)
      {
        int num2 = num1;
        MetadataTreeHelper.GroupNode groupNode1;
        while (true)
        {
          // ISSUE: variable of a compiler-generated type
          MetadataTreeHelper.\u003C\u003Ec__DisplayClass20_0 cDisplayClass200;
          string str1;
          string str2;
          // ISSUE: variable of a compiler-generated type
          MetadataTreeHelper.\u003C\u003Ec__DisplayClass20_1 cDisplayClass201;
          int i;
          string str3;
          string[] strArray;
          string ns;
          string str4;
          object obj;
          switch (num2)
          {
            case 1:
              str4 = ModelHelper.GetNamespaceDisplayName(ns);
              goto label_47;
            case 2:
            case 6:
              // ISSUE: reference to a compiler-generated method
              groupNode1 = groupByNamespace.GroupNodes.FirstOrDefault<MetadataTreeHelper.GroupNode>(new System.Func<MetadataTreeHelper.GroupNode, bool>(cDisplayClass201.\u003CGetGroupByNamespace\u003Eb__0));
              num2 = 26;
              continue;
            case 3:
              obj = MetadataTreeHelper.UbiZsVb6lNgxGP5PNZlI((object) metadata);
              break;
            case 4:
              str2 = "";
              num2 = 32;
              continue;
            case 5:
            case 12:
              groupByNamespace = groupNode1;
              num2 = 22;
              continue;
            case 7:
              str3 = (string) MetadataTreeHelper.Hu9789b6rsx9R7RmkCny((object) ns);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 5 : 21;
              continue;
            case 8:
              goto label_37;
            case 9:
            case 19:
              goto label_33;
            case 10:
              groupByNamespace = this.root;
              num2 = 13;
              continue;
            case 11:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass200 = new MetadataTreeHelper.\u003C\u003Ec__DisplayClass20_0();
              num2 = 10;
              continue;
            case 13:
              if (!MetadataTreeHelper.Bvjhj5b6dXUtPabkMIpM((object) metadata.NamespaceForDisplay))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 18 : 24;
                continue;
              }
              goto case 3;
            case 14:
              if (!MetadataTreeHelper.SiGbdXb6jgHoDIOxHSaQ((object) str2, (object) ""))
              {
                num2 = 15;
                continue;
              }
              goto case 35;
            case 15:
            case 28:
              // ISSUE: reference to a compiler-generated field
              str2 += strArray[cDisplayClass201.i];
              num2 = 36;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass201.i = i + 1;
              num2 = 29;
              continue;
            case 17:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass201.i = 0;
              num2 = 34;
              continue;
            case 18:
              obj = (object) metadata.NamespaceForDisplay;
              break;
            case 20:
              strArray = (string[]) MetadataTreeHelper.Ye6aCmb65pogp9c3MJBG((object) str3, MetadataTreeHelper.oOIf4sb6guUqIalolheN(MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(964881585 - -1459193222 ^ -1870894861)), StringSplitOptions.RemoveEmptyEntries);
              num2 = 4;
              continue;
            case 21:
              if (this.showDisplayName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                continue;
              }
              goto case 23;
            case 22:
              // ISSUE: reference to a compiler-generated field
              i = cDisplayClass201.i;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 3 : 16;
              continue;
            case 23:
              str4 = str3;
              goto label_47;
            case 24:
              if (this.generateForPublicApi)
              {
                num2 = 3;
                continue;
              }
              goto case 18;
            case 25:
              MetadataTreeHelper.GroupNode groupNode2 = new MetadataTreeHelper.GroupNode();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              MetadataTreeHelper.vrcMn8b6x9VJGyEYwHZV((object) groupNode2, (object) cDisplayClass201.CS\u0024\u003C\u003E8__locals1.namespaceBlocks[cDisplayClass201.i]);
              MetadataTreeHelper.TeErLbb6Y1mRIOhebn6B((object) groupNode2, (object) str2);
              groupNode1 = groupNode2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 26:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass201.i >= strArray.Length)
                goto case 36;
              else
                goto label_25;
            case 27:
              if (groupNode1.MetadataItemNamespaces.Contains((string) MetadataTreeHelper.UbiZsVb6lNgxGP5PNZlI((object) metadata)))
              {
                num2 = 12;
                continue;
              }
              goto label_37;
            case 29:
            case 34:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass201.i <= cDisplayClass201.CS\u0024\u003C\u003E8__locals1.namespaceBlocks.Length - 1)
              {
                num2 = 6;
                continue;
              }
              goto label_33;
            case 30:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass201.i == cDisplayClass201.CS\u0024\u003C\u003E8__locals1.namespaceBlocks.Length - 1)
              {
                num2 = 27;
                continue;
              }
              goto case 5;
            case 31:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass201 = new MetadataTreeHelper.\u003C\u003Ec__DisplayClass20_1();
              num2 = 37;
              continue;
            case 32:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass200.namespaceBlocks.Length == 0)
              {
                num2 = 9;
                continue;
              }
              goto case 31;
            case 33:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass200.namespaceBlocks = (string[]) MetadataTreeHelper.Ye6aCmb65pogp9c3MJBG((object) str1, MetadataTreeHelper.oOIf4sb6guUqIalolheN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710577138)), StringSplitOptions.RemoveEmptyEntries);
              num2 = 20;
              continue;
            case 35:
              str2 += (string) MetadataTreeHelper.T0LsQKb6iLjUuAqgVyvp(864270449 << 6 ^ -521271676);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 19 : 28;
              continue;
            case 36:
              if (groupNode1 == null)
              {
                num2 = 25;
                continue;
              }
              goto case 30;
            case 37:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass201.CS\u0024\u003C\u003E8__locals1 = cDisplayClass200;
              num2 = 17;
              continue;
            default:
              groupByNamespace.GroupNodes.Add(groupNode1);
              num2 = 30;
              continue;
          }
          ns = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 7 : 7;
          continue;
label_47:
          str1 = str4;
          num2 = 33;
        }
label_25:
        num1 = 14;
        continue;
label_37:
        groupNode1.MetadataItemNamespaces.Add((string) MetadataTreeHelper.UbiZsVb6lNgxGP5PNZlI((object) metadata));
        num1 = 5;
      }
label_33:
      return groupByNamespace;
    }

    private void RemoveEmptyGroups(MetadataTreeHelper.GroupNode parent)
    {
      int num1 = 3;
      List<MetadataTreeHelper.GroupNode>.Enumerator enumerator;
      List<MetadataTreeHelper.GroupNode> groupNodeList;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_32;
          case 1:
            goto label_2;
          case 2:
            enumerator = parent.GroupNodes.GetEnumerator();
            num1 = 4;
            continue;
          case 3:
            groupNodeList = new List<MetadataTreeHelper.GroupNode>();
            num1 = 2;
            continue;
          case 4:
            try
            {
label_17:
              if (enumerator.MoveNext())
                goto label_19;
              else
                goto label_18;
label_16:
              MetadataTreeHelper.GroupNode current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    goto label_19;
                  case 3:
                    if (current.GroupNodes.Count == 0)
                    {
                      num2 = 4;
                      continue;
                    }
                    goto label_17;
                  case 4:
                    if (MetadataTreeHelper.rowtIKb6LjP4uBrYWVF6((object) current.MetadataNodes) != 0)
                    {
                      num2 = 7;
                      continue;
                    }
                    goto case 5;
                  case 5:
                    groupNodeList.Add(current);
                    num2 = 6;
                    continue;
                  case 6:
                  case 7:
                    goto label_17;
                  default:
                    this.RemoveEmptyGroups(current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 3;
                    continue;
                }
              }
label_18:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
              goto label_16;
label_19:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
              {
                num2 = 0;
                goto label_16;
              }
              else
                goto label_16;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 5:
label_13:
            enumerator = groupNodeList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
          default:
            goto label_28;
        }
      }
label_32:
      return;
label_28:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_4;
        else
          goto label_6;
label_3:
        MetadataTreeHelper.GroupNode current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_23;
            case 3:
              parent.GroupNodes.Remove(current);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_23:
        return;
label_4:
        current = enumerator.Current;
        num4 = 3;
        goto label_3;
label_6:
        num4 = 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    private void ResortNodes(MetadataTreeHelper.GroupNode parent)
    {
      int num1 = 4;
      List<MetadataTreeHelper.GroupNode>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
label_21:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            parent.MetadataNodes = parent.MetadataNodes.Where<MetadataTreeHelper.MetadataNode>((System.Func<MetadataTreeHelper.MetadataNode, bool>) (g => !MetadataTreeHelper.\u003C\u003Ec.CfOTcOCwSdP0Fm99S9W7(MetadataTreeHelper.\u003C\u003Ec.YZ9LxICwVJcBIjLvYybI((object) g)))).OrderBy<MetadataTreeHelper.MetadataNode, string>((System.Func<MetadataTreeHelper.MetadataNode, string>) (g => (string) MetadataTreeHelper.\u003C\u003Ec.qbki92CwiTgjpjqGj2py(MetadataTreeHelper.\u003C\u003Ec.YZ9LxICwVJcBIjLvYybI((object) g)))).ToList<MetadataTreeHelper.MetadataNode>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
          case 3:
            enumerator = parent.GroupNodes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 4:
            MetadataTreeHelper.GroupNode groupNode = parent;
            List<MetadataTreeHelper.GroupNode> groupNodes = parent.GroupNodes;
            // ISSUE: reference to a compiler-generated field
            System.Func<MetadataTreeHelper.GroupNode, bool> func1 = MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__22_0;
            System.Func<MetadataTreeHelper.GroupNode, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__22_0 = predicate = (System.Func<MetadataTreeHelper.GroupNode, bool>) (g => !MetadataTreeHelper.\u003C\u003Ec.CfOTcOCwSdP0Fm99S9W7(MetadataTreeHelper.\u003C\u003Ec.YZ9LxICwVJcBIjLvYybI((object) g)));
            }
            else
              goto label_23;
label_17:
            IEnumerable<MetadataTreeHelper.GroupNode> source = groupNodes.Where<MetadataTreeHelper.GroupNode>(predicate);
            // ISSUE: reference to a compiler-generated field
            System.Func<MetadataTreeHelper.GroupNode, string> func2 = MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__22_1;
            System.Func<MetadataTreeHelper.GroupNode, string> keySelector;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              MetadataTreeHelper.\u003C\u003Ec.\u003C\u003E9__22_1 = keySelector = (System.Func<MetadataTreeHelper.GroupNode, string>) (g => (string) MetadataTreeHelper.\u003C\u003Ec.qbki92CwiTgjpjqGj2py(MetadataTreeHelper.\u003C\u003Ec.YZ9LxICwVJcBIjLvYybI((object) g)));
            }
            else
              goto label_22;
label_20:
            List<MetadataTreeHelper.GroupNode> list = source.OrderBy<MetadataTreeHelper.GroupNode, string>(keySelector).ToList<MetadataTreeHelper.GroupNode>();
            groupNode.GroupNodes = list;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 3;
            continue;
label_22:
            keySelector = func2;
            goto label_20;
label_23:
            predicate = func1;
            goto label_17;
          default:
            try
            {
label_6:
              if (enumerator.MoveNext())
                goto label_8;
              else
                goto label_7;
label_4:
              MetadataTreeHelper.GroupNode current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_8;
                  case 2:
                    goto label_6;
                  case 3:
                    this.ResortNodes(current);
                    num2 = 2;
                    continue;
                  default:
                    goto label_21;
                }
              }
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              goto label_4;
label_8:
              current = enumerator.Current;
              num2 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
              {
                num2 = 3;
                goto label_4;
              }
              else
                goto label_4;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_18:;
    }

    internal static object Q7OPTIb68IuX29DjSTN9([In] object obj0) => (object) ((MetadataTreeHelper.GroupNode) obj0).Namespace;

    internal static bool t5iqiUb6ZvZH4yotnwoP([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static bool L2lcvlb6uETDBuW5IyCV([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object HsWbDPb6IRarxbP3FhNp([In] object obj0) => (object) ((MetadataTreeHelper.GroupNode) obj0).Group;

    internal static object fcqGknb6VYSe3wtqEGLK([In] object obj0) => (object) ((MetadataItemGroupDTO) obj0).Name;

    internal static bool WbNrA3b6CuxIx7SyJ16Y() => MetadataTreeHelper.lAPclcb6QU7uaVlojpFD == null;

    internal static MetadataTreeHelper sNqUcpb6vySm7AkoE2lq() => MetadataTreeHelper.lAPclcb6QU7uaVlojpFD;

    internal static bool hbhW8Kb6S8R6e4AUO1Dq() => Locator.Initialized;

    internal static object T0LsQKb6iLjUuAqgVyvp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime QpMsfMb6RUA3PBwyYF2y() => DateTime.Now;

    internal static bool UMDIsab6qeRjxq7OmmcC([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 <= obj1;

    internal static object uwUJB6b6KNdI8YvtMAQK([In] object obj0) => (object) ((IMetadataItemGroupDTOManager) obj0).LoadRootGroup();

    internal static void gmshasb6X3Ao2ifslbZg([In] object obj0, [In] object obj1) => CallContext.SetData((string) obj0, obj1);

    internal static object M41Fghb6Tw4d99r6ak3D([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void l3syMBb6kyOKURtgOKRg([In] object obj0, [In] object obj1) => ((MetadataItemGroupDTO) obj0).Name = (string) obj1;

    internal static void mNTK6Bb6ndZmhDyyc5U2([In] object obj0, [In] object obj1) => ((MetadataItemGroupDTO) obj0).DisplayName = (string) obj1;

    internal static object HHYKefb6O6DPsdAlFRW6([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object TXlcVUb62GEYllXoTlrS([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object tb0r7bb6eTkvSx466xss([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object SxxMwGb6PIqRYO28uPbS([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object eaFcfab61J9ujUHrXSqd([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static void ansQqob6N8iZOodqMA0f([In] object obj0, [In] object obj1) => ((MetadataItemGroupDTO) obj0).Namespace = (string) obj1;

    internal static void iicWcFb631kkH0vXckI8([In] object obj0, DateTime value) => ((MetadataItemGroupDTO) obj0).CreationDate = value;

    internal static bool R5LU1ub6pfYmChanuWI2([In] object obj0) => Convert.ToBoolean(obj0);

    internal static void D7Uloab6a98m2WFtyUao([In] object obj0, bool value) => ((MetadataItemGroupDTO) obj0).IsSystem = value;

    internal static Guid yfWnnYb6DrAgBs0N7qI8([In] object obj0, [In] object obj1) => ((Dialect) obj0).GetGuid(obj1);

    internal static long dluXylb6t9rG36TFP5w7([In] object obj0) => Convert.ToInt64(obj0);

    internal static void Uwsxutb6wElA3la1HoIM([In] object obj0, long value) => ((MetadataItemGroupDTO) obj0).ParentId = value;

    internal static void IDlKVbb64FrVlqP8yvEo([In] object obj0, long value) => ((MetadataItemGroupDTO) obj0).CreationAuthorId = value;

    internal static bool ARY4kBb66B7r52TwRTNr([In] object obj0) => ((IDataReader) obj0).Read();

    internal static void B1DFcrb6HpTjmDc8mU3R([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static long kWpMlTb6AWtX7tS8nA4E([In] object obj0) => ((MetadataItemGroupDTO) obj0).ParentId;

    internal static object FjarqBb674WCYOO4se7i([In] object obj0) => (object) ((MetadataItemGroupDTO) obj0).DisplayName;

    internal static void vrcMn8b6x9VJGyEYwHZV([In] object obj0, [In] object obj1) => ((MetadataTreeHelper.Node) obj0).Name = (string) obj1;

    internal static void tJlgrBb60uR3mXevWx9Z([In] object obj0, [In] object obj1) => ((MetadataTreeHelper.GroupNode) obj0).Group = (MetadataItemGroupDTO) obj1;

    internal static void Jyn93qb6miLc2J9s2jKp([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static long jCbDnPb6ypDDMAhIFam5([In] object obj0) => ((IGroupedMetadata) obj0).GroupId;

    internal static object FrwbYtb6M2UyWIHW6TcZ([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Name;

    internal static object VxORYkb6JUAk9Xg5fQd9([In] object obj0) => (object) ((ICodeItemMetadata) obj0).GetDisplayName();

    internal static object AkDvHcb69I01gsoOd9oP([In] object obj0, [In] object obj1) => (object) ((IMetadataService) obj0).GetDisplayName((ICodeItemMetadata) obj1);

    internal static bool Bvjhj5b6dXUtPabkMIpM([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object UbiZsVb6lNgxGP5PNZlI([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Namespace;

    internal static object Hu9789b6rsx9R7RmkCny([In] object obj0) => (object) ModelHelper.GetNamespaceShortName((string) obj0);

    internal static object oOIf4sb6guUqIalolheN([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object Ye6aCmb65pogp9c3MJBG([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static bool SiGbdXb6jgHoDIOxHSaQ([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void TeErLbb6Y1mRIOhebn6B([In] object obj0, [In] object obj1) => ((MetadataTreeHelper.GroupNode) obj0).Namespace = (string) obj1;

    internal static int rowtIKb6LjP4uBrYWVF6([In] object obj0) => ((List<MetadataTreeHelper.MetadataNode>) obj0).Count;

    /// <summary>Базовый класс для узлов дерева</summary>
    public abstract class Node
    {
      private static MetadataTreeHelper.Node QgTOqPCwFE60CJodbsjm;

      /// <summary>Имя узла дерева</summary>
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

      protected Node()
      {
        MetadataTreeHelper.Node.SFhpWXCworjbKLAa8RFD();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool bBe56VCwBKQ2A5MICT4Y() => MetadataTreeHelper.Node.QgTOqPCwFE60CJodbsjm == null;

      internal static MetadataTreeHelper.Node qGAfBxCwWwPFVMOn0IAA() => MetadataTreeHelper.Node.QgTOqPCwFE60CJodbsjm;

      internal static void SFhpWXCworjbKLAa8RFD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Узел дерева для группы объектов метаданных</summary>
    public class GroupNode : MetadataTreeHelper.Node
    {
      internal static MetadataTreeHelper.GroupNode l21uV0CwbMRK9CZot0RJ;

      /// <summary>Ctor</summary>
      public GroupNode()
      {
        MetadataTreeHelper.GroupNode.LL8N1OCwETR9aSkYGTpy();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.MetadataNodes = new List<MetadataTreeHelper.MetadataNode>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 3:
              this.MetadataItemNamespaces = new List<string>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            default:
              this.GroupNodes = new List<MetadataTreeHelper.GroupNode>();
              num = 3;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Группа</summary>
      public MetadataItemGroupDTO Group
      {
        get => this.\u003CGroup\u003Ek__BackingField;
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
                this.\u003CGroup\u003Ek__BackingField = value;
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

      /// <summary>
      /// Сокращенное имя пространства имен (например, Documents.Tasks)
      /// </summary>
      public string Namespace
      {
        get => this.\u003CNamespace\u003Ek__BackingField;
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
                this.\u003CNamespace\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
      /// Список пространств имен объектов, находящихся в данной группе
      /// </summary>
      public List<string> MetadataItemNamespaces { get; set; }

      /// <summary>Подчиненные узлы</summary>
      public List<MetadataTreeHelper.MetadataNode> MetadataNodes { get; set; }

      /// <summary>Подчиненные узлы групп</summary>
      public List<MetadataTreeHelper.GroupNode> GroupNodes { get; set; }

      internal static void LL8N1OCwETR9aSkYGTpy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Lb7FscCwhZ7Xbm7lEqYV() => MetadataTreeHelper.GroupNode.l21uV0CwbMRK9CZot0RJ == null;

      internal static MetadataTreeHelper.GroupNode IBRd1bCwGkqSBYFAI34L() => MetadataTreeHelper.GroupNode.l21uV0CwbMRK9CZot0RJ;
    }

    /// <summary>Узел дерева для объекта метаданных</summary>
    public class MetadataNode : MetadataTreeHelper.Node
    {
      private static MetadataTreeHelper.MetadataNode eYiE2VCwf4IdNlgDbAQe;

      /// <summary>Объект метаданных</summary>
      public ICodeItemMetadata Metadata
      {
        get => this.\u003CMetadata\u003Ek__BackingField;
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
                this.\u003CMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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

      public MetadataNode()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool H6Dl95CwQiTkx97J487b() => MetadataTreeHelper.MetadataNode.eYiE2VCwf4IdNlgDbAQe == null;

      internal static MetadataTreeHelper.MetadataNode Ae9OdbCwCaNR3CS63Xrl() => MetadataTreeHelper.MetadataNode.eYiE2VCwf4IdNlgDbAQe;
    }
  }
}

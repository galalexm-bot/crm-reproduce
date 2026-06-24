// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.DataClassMetadataImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки датаклассов при импорте конфигурации
  /// </summary>
  [Component]
  internal sealed class DataClassMetadataImportExtension : 
    ClassMetadataImportExtension<DataClassMetadata>
  {
    private static readonly ILogger ImportLog;
    private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;
    private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;
    private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;
    private readonly IActorContextService actorContextService;
    private readonly IFeatureFlagService featureFlagService;
    private static DataClassMetadataImportExtension ra4BaVEd4xEgUXt6ERd4;

    /// <summary>Ctor</summary>
    /// <param name="dataClassMetadataItemManager">Менеджер метаданных датаклассов</param>
    /// <param name="dataClassMetadataItemHeaderManager">Интерфейс менеджера заголовков метаданных датаклассов</param>
    /// <param name="metadataItemGroupUIManager">Менеджер метаданных групп КИ</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public DataClassMetadataImportExtension(
      IDataClassMetadataItemManager dataClassMetadataItemManager,
      IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager,
      IMetadataItemGroupUIManager metadataItemGroupUIManager,
      IActorContextService actorContextService,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.metadataItemGroupUIManager = metadataItemGroupUIManager;
            num = 3;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.actorContextService = actorContextService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 4:
            this.dataClassMetadataItemManager = dataClassMetadataItemManager;
            num = 5;
            continue;
          case 5:
            this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
            continue;
          default:
            this.featureFlagService = featureFlagService;
            num = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Мерж метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="parameters">Параметры импорта</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    internal void CheckNewMetadata(
      DataClassMetadata mdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CheckNewMetadata(mdImported, isTestRead, parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Мерж метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="parameters">Параметры импорта</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    internal void MergeMetadata(
      DataClassMetadata mdImported,
      DataClassMetadata mdDraft,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
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

    /// <inheritdoc />
    protected override bool TestMetadata(
      DataClassMetadata mdMerged,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.SecondRuntimeEnabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_3;
          case 3:
            DataClassMetadataImportExtension.p7l9FsEdxdUqRdUuf6oF((object) parameters, (object) new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassMetadataImportExtension.YgrfKQEdALiALRcpi62N(1574260816 ^ 1574018446), DataClassMetadataImportExtension.i7p97VEd7UX8YnCnFkHa((object) mdMerged))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      return false;
label_4:
      return base.TestMetadata(mdMerged, parameters, isTestRead);
    }

    /// <inheritdoc />
    protected override bool CheckMetadata(
      DataClassMetadata mdImported,
      DataClassMetadata mdDraft,
      ReadMetadataParameters parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassMetadataImportExtension.YgrfKQEdALiALRcpi62N(1470998129 - 231418599 ^ 1239856272), DataClassMetadataImportExtension.i7p97VEd7UX8YnCnFkHa((object) mdImported))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!this.SecondRuntimeEnabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return false;
label_6:
      return base.CheckMetadata(mdImported, mdDraft, parameters);
    }

    /// <inheritdoc />
    protected override void CheckNewMetadata(
      DataClassMetadata mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num1 = 2;
      List<DataClassDependency>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!isTestRead)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 4 : 1;
              continue;
            }
            goto label_12;
          case 2:
            base.CheckNewMetadata(mdImported, isTestRead, parameters);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_16;
          case 4:
            enumerator = mdImported.IncludeList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_16:
      return;
label_3:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        DataClassDependency current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_6;
            case 1:
              DataClassMetadataImportExtension.s8UtuREdyilThtB5lHjq((object) current, ((MergeReplace) DataClassMetadataImportExtension.jdb8pREd0Wvu18GeTxWo((object) parameters)).GetUidReplaceMD(DataClassMetadataImportExtension.tBk7SuEdmKDqL3C6g8Dy((object) current)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_2:
        return;
label_7:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_12:;
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      DataClassMetadata mdImported,
      DataClassMetadata mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<DataClassDependency>.Enumerator enumerator;
          switch (num2)
          {
            case 1:
              try
              {
label_8:
                if (enumerator.MoveNext())
                  goto label_14;
                else
                  goto label_9;
label_7:
                int num3;
                DataClassDependency dependency;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      dependency.HeaderUid = DataClassMetadataImportExtension.JuxotnEdMQahuPKokN6F(DataClassMetadataImportExtension.jdb8pREd0Wvu18GeTxWo((object) parameters), DataClassMetadataImportExtension.tBk7SuEdmKDqL3C6g8Dy((object) dependency));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 4 : 4;
                      continue;
                    case 2:
                      goto label_8;
                    case 3:
                      goto label_5;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (mdDraft.IncludeList.All<DataClassDependency>((Func<DataClassDependency, bool>) (d => DataClassMetadataImportExtension.\u003C\u003Ec__DisplayClass12_0.l5aaoS8H5QCbb5gTuE4s(DataClassMetadataImportExtension.\u003C\u003Ec__DisplayClass12_0.AiGbZ18Hg29Y05BQKS9E((object) d), DataClassMetadataImportExtension.\u003C\u003Ec__DisplayClass12_0.AiGbZ18Hg29Y05BQKS9E((object) dependency)))))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 5 : 5;
                        continue;
                      }
                      goto label_8;
                    case 5:
                      mdDraft.IncludeList.Add(dependency);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
                      continue;
                    case 6:
                      dependency = enumerator.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_14;
                  }
                }
label_9:
                num3 = 3;
                goto label_7;
label_14:
                num3 = 6;
                goto label_7;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 2:
              enumerator = mdImported.IncludeList.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            case 3:
              if (!isTestRead)
              {
                num2 = 2;
                continue;
              }
              goto label_16;
            case 4:
              goto label_22;
            case 5:
              goto label_20;
          }
label_5:
          DataClassMetadataImportExtension.XXgXcZEd929ioGMsQIa8((object) mdImported, DataClassMetadataImportExtension.BsqgTlEdJ8FUw9nnlYTX((object) mdDraft));
          num2 = 5;
        }
label_22:
        base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
        num1 = 3;
      }
label_20:
      return;
label_16:;
    }

    /// <inheritdoc />
    protected override void SaveMetadata(
      DataClassMetadata mdMerged,
      ReadMetadataParameters parameters)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        DataClassMetadataItem classMetadataItem;
        string input;
        MetadataItemGroupUI metadataItemGroupUi;
        while (true)
        {
          Type type1;
          string key;
          Type type2;
          object obj;
          switch (num2)
          {
            case 1:
              DataClassMetadataImportExtension.l5CmguEdjRDOqBNv2lVf(DataClassMetadataImportExtension.CDtisxEdglv6lfFHS6ju((object) classMetadataItem), DataClassMetadataImportExtension.k1qLpOEd5IeZKB270key((object) mdMerged));
              num2 = 9;
              continue;
            case 2:
              if (!parameters.ServiceData.TryGetValue(key, out input))
              {
                num2 = 26;
                continue;
              }
              goto label_14;
            case 3:
              if (classMetadataItem != null)
              {
                num2 = 25;
                continue;
              }
              goto case 24;
            case 4:
            case 11:
            case 12:
            case 26:
              if (DataClassMetadataImportExtension.jcHleDEdcFGu03gaEmhC((object) DataClassMetadataImportExtension.ImportLog))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 17 : 16;
                continue;
              }
              goto case 16;
            case 5:
              DataClassMetadataImportExtension.ImportLog.InfoFormat((string) DataClassMetadataImportExtension.YgrfKQEdALiALRcpi62N(1461625753 ^ 1461350233), DataClassMetadataImportExtension.Dk8logEdzAbHRa7Ig8CY((object) type1), (object) DataClassMetadataImportExtension.NpKNi4ElFCcx83YJ5Qja((object) classMetadataItem));
              num2 = 10;
              continue;
            case 6:
              goto label_19;
            case 7:
              goto label_28;
            case 8:
              goto label_14;
            case 9:
              DataClassMetadataImportExtension.zxRKLEEdYW7YcBRD12yE((object) classMetadataItem.Header, DataClassMetadataImportExtension.QPvR8BEdd0oQQS0L9MNT((object) mdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 10:
              goto label_25;
            case 13:
              obj = (object) null;
              break;
            case 14:
              DataClassMetadataItemHeader metadataItemHeader = this.dataClassMetadataItemHeaderManager.LoadOrNull(DataClassMetadataImportExtension.QPvR8BEdd0oQQS0L9MNT((object) mdMerged));
              if (metadataItemHeader == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 13 : 1;
                continue;
              }
              obj = DataClassMetadataImportExtension.ES2TJkEdlMTnR3vZQaUi((object) metadataItemHeader);
              break;
            case 15:
              DataClassMetadataImportExtension.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138228491), DataClassMetadataImportExtension.Dk8logEdzAbHRa7Ig8CY((object) type1), (object) DataClassMetadataImportExtension.NpKNi4ElFCcx83YJ5Qja((object) classMetadataItem));
              num2 = 20;
              continue;
            case 16:
              type2 = (Type) null;
              goto label_34;
            case 17:
              type2 = mdMerged.GetType();
              goto label_34;
            case 18:
              DataClassMetadataImportExtension.GetImportHeaders((object) this.actorContextService).Add(DataClassMetadataImportExtension.DdjwH3ElW5WVouIcEnHc(DataClassMetadataImportExtension.CDtisxEdglv6lfFHS6ju((object) classMetadataItem)));
              num2 = 21;
              continue;
            case 19:
              if (metadataItemGroupUi == null)
              {
                num2 = 4;
                continue;
              }
              goto case 22;
            case 20:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487107650), (object) DataClassMetadataImportExtension.QPvR8BEdd0oQQS0L9MNT((object) mdMerged), DataClassMetadataImportExtension.i7p97VEd7UX8YnCnFkHa((object) mdMerged), DataClassMetadataImportExtension.k1qLpOEd5IeZKB270key((object) mdMerged)), false));
              num2 = 18;
              continue;
            case 21:
              goto label_16;
            case 22:
              DataClassMetadataImportExtension.twJ3ErEds3PHBoiLCjUX((object) classMetadataItem.Header, (object) metadataItemGroupUi);
              num2 = 11;
              continue;
            case 23:
              key = (string) DataClassMetadataImportExtension.MImc0lEdUIWDAJR8eq90(DataClassMetadataImportExtension.YgrfKQEdALiALRcpi62N(864270449 << 6 ^ -521482028), (object) DataClassMetadataImportExtension.QPvR8BEdd0oQQS0L9MNT((object) mdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 2;
              continue;
            case 24:
              classMetadataItem = this.dataClassMetadataItemManager.Create(DataClassMetadataImportExtension.tey8hmEdr4knoT8DqtNy((object) mdMerged), Guid.Empty, (string) DataClassMetadataImportExtension.i7p97VEd7UX8YnCnFkHa((object) mdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            default:
              DataClassMetadataImportExtension.hIol6rEdLRqjM86dfbqB((object) classMetadataItem, (object) mdMerged);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 23 : 23;
              continue;
          }
          classMetadataItem = (DataClassMetadataItem) obj;
          num2 = 3;
          continue;
label_34:
          type1 = type2;
          num2 = 5;
        }
label_14:
        Guid result;
        if (!Guid.TryParse(input, out result))
        {
          num1 = 12;
          continue;
        }
        goto label_19;
label_16:
        EntityMetadataDependencyService.GetPromisedMetadataDependencies(this.actorContextService).Add((IMetadata) mdMerged);
        num1 = 7;
        continue;
label_19:
        metadataItemGroupUi = this.metadataItemGroupUIManager.LoadOrNull(result);
        num1 = 19;
        continue;
label_25:
        DataClassMetadataImportExtension.OBf6BkElBNpRk5U3V0Da((object) classMetadataItem);
        num1 = 15;
      }
label_28:;
    }

    private static ICollection<Guid> GetImportHeaders(object actorContextService)
    {
      object importHeaders;
      if (!((IActorContextService) actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501681565), out importHeaders))
        ((IActorContextService) actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272316769), (object) (List<Guid>) (importHeaders = (object) new List<Guid>()));
      return (ICollection<Guid>) importHeaders;
    }

    /// <summary>Включен ли второй рантайм</summary>
    private bool SecondRuntimeEnabled => DataClassMetadataImportExtension.dNW02eElotqVaml2RpDJ((object) this.featureFlagService, DataClassMetadataImportExtension.YgrfKQEdALiALRcpi62N(901793403 ^ 901834865), false);

    static DataClassMetadataImportExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassMetadataImportExtension.kS1YwaElbOgDcsZO0lUR();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DataClassMetadataImportExtension.ImportLog = (ILogger) DataClassMetadataImportExtension.ejElsBElhaqSnQbpGpXb((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787116138));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool APg3QHEd6MhONclpl6CR() => DataClassMetadataImportExtension.ra4BaVEd4xEgUXt6ERd4 == null;

    internal static DataClassMetadataImportExtension g5sY62EdHlItTlHEskxD() => DataClassMetadataImportExtension.ra4BaVEd4xEgUXt6ERd4;

    internal static object YgrfKQEdALiALRcpi62N(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object i7p97VEd7UX8YnCnFkHa([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void p7l9FsEdxdUqRdUuf6oF([In] object obj0, [In] object obj1) => ((ReadMetadataParameters) obj0).TestMessagesAdd((TestImportMessages) obj1);

    internal static object jdb8pREd0Wvu18GeTxWo([In] object obj0) => (object) ((ReadMetadataParameters) obj0).MergeReplace;

    internal static Guid tBk7SuEdmKDqL3C6g8Dy([In] object obj0) => ((Dependency) obj0).HeaderUid;

    internal static void s8UtuREdyilThtB5lHjq([In] object obj0, Guid value) => ((Dependency) obj0).HeaderUid = value;

    internal static Guid JuxotnEdMQahuPKokN6F([In] object obj0, Guid uidFrom) => ((MergeReplace) obj0).GetUidReplaceMD(uidFrom);

    internal static object BsqgTlEdJ8FUw9nnlYTX([In] object obj0) => (object) ((DataClassMetadata) obj0).TypeToMap;

    internal static void XXgXcZEd929ioGMsQIa8([In] object obj0, [In] object obj1) => ((DataClassMetadata) obj0).TypeToMap = (TypeToMap) obj1;

    internal static Guid QPvR8BEdd0oQQS0L9MNT([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object ES2TJkEdlMTnR3vZQaUi([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Draft;

    internal static Guid tey8hmEdr4knoT8DqtNy([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static object CDtisxEdglv6lfFHS6ju([In] object obj0) => (object) ((DataClassMetadataItem) obj0).Header;

    internal static object k1qLpOEd5IeZKB270key([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void l5CmguEdjRDOqBNv2lVf([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Name = (string) obj1;

    internal static void zxRKLEEdYW7YcBRD12yE([In] object obj0, Guid value) => ((DataClassMetadataItemHeader) obj0).Uid = value;

    internal static void hIol6rEdLRqjM86dfbqB([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Metadata = obj1;

    internal static object MImc0lEdUIWDAJR8eq90([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void twJ3ErEds3PHBoiLCjUX([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static bool jcHleDEdcFGu03gaEmhC([In] object obj0) => ((ILogger) obj0).IsInfoEnabled();

    internal static object Dk8logEdzAbHRa7Ig8CY([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Guid NpKNi4ElFCcx83YJ5Qja([In] object obj0) => ((DataClassMetadataItem) obj0).Uid;

    internal static void OBf6BkElBNpRk5U3V0Da([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static Guid DdjwH3ElW5WVouIcEnHc([In] object obj0) => ((DataClassMetadataItemHeader) obj0).Uid;

    internal static bool dNW02eElotqVaml2RpDJ([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static void kS1YwaElbOgDcsZO0lUR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ejElsBElhaqSnQbpGpXb([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    /// <summary>
    /// Расширение обработки метаданных датаклассов после импорта
    /// </summary>
    [Component(Order = 2200)]
    private class DataClassConfigImportExtension : ConfigImportExtension
    {
      private readonly object dataClassMetadataItemManager;
      private readonly object actorContextService;
      private readonly object securityService;
      private static object g8vwQn8HanyLrF8kFbmA;

      public DataClassConfigImportExtension(
        IDataClassMetadataItemManager dataClassMetadataItemManager,
        IActorContextService actorContextService,
        ISecurityService securityService)
      {
        DataClassMetadataImportExtension.DataClassConfigImportExtension.dJ3gri8HwxTiH2YAeHkr();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.securityService = (object) securityService;
              num = 2;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.dataClassMetadataItemManager = (object) dataClassMetadataItemManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            default:
              this.actorContextService = (object) actorContextService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      /// <inheritdoc />
      public override void OnPostReadPackets(PostReadPacketsParameters parameters)
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          List<KeyValuePair<string, string>> list;
          ICollection<Guid> importHeaders;
          Guid[] array;
          PostReadPacketsParameters parameters1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                importHeaders = DataClassMetadataImportExtension.GetImportHeaders(this.actorContextService);
                num2 = 10;
                continue;
              case 2:
                goto label_25;
              case 3:
              case 13:
                if (DataClassMetadataImportExtension.DataClassConfigImportExtension.jCjqhH8H4eWMumw0r1RH((object) parameters1) == 2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 11 : 1;
                  continue;
                }
                goto label_21;
              case 4:
                this.Publish((IEnumerable<Guid>) array, (ICollection<DeployLogMessage>) parameters1.Messages, (string) DataClassMetadataImportExtension.DataClassConfigImportExtension.H7eYBC8H6MkgsNXS67jQ((object) parameters1));
                num2 = 14;
                continue;
              case 5:
                if (DataClassMetadataImportExtension.DataClassConfigImportExtension.jCjqhH8H4eWMumw0r1RH((object) parameters1) != 1)
                  goto case 3;
                else
                  goto label_18;
              case 6:
                parameters1 = parameters;
                num2 = 5;
                continue;
              case 7:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 6 : 5;
                continue;
              case 8:
                if (parameters1.HeaderIds.Count == 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
                  continue;
                }
                goto case 3;
              case 9:
                this.Publish((IEnumerable<Guid>) importHeaders, (ICollection<DeployLogMessage>) parameters1.Messages, parameters1.TreeUid);
                num2 = 3;
                continue;
              case 10:
                if (importHeaders.Count > 0)
                  goto case 9;
                else
                  goto label_12;
              case 11:
                goto label_20;
              case 12:
                List<KeyValuePair<string, string>> source = list;
                // ISSUE: reference to a compiler-generated field
                Func<KeyValuePair<string, string>, Guid> func1 = DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__4_1;
                Func<KeyValuePair<string, string>, Guid> selector;
                if (func1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__4_1 = selector = (Func<KeyValuePair<string, string>, Guid>) (record => new Guid(record.Value));
                }
                else
                  goto label_29;
label_27:
                array = source.Select<KeyValuePair<string, string>, Guid>(selector).ToArray<Guid>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
label_29:
                selector = func1;
                goto label_27;
              case 14:
                list.ForEach((Action<KeyValuePair<string, string>>) (r =>
                {
                  if (!parameters1.ServiceData.ContainsKey(r.Key))
                    return;
                  parameters1.ServiceData.Remove(r.Key);
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 2;
                continue;
              default:
                if (array.Length != 0)
                {
                  num2 = 4;
                  continue;
                }
                goto label_14;
            }
          }
label_12:
          num1 = 13;
          continue;
label_18:
          num1 = 8;
          continue;
label_20:
          Dictionary<string, string> serviceData = parameters1.ServiceData;
          // ISSUE: reference to a compiler-generated field
          Func<KeyValuePair<string, string>, bool> func2 = DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__4_0;
          Func<KeyValuePair<string, string>, bool> predicate;
          if (func2 == null)
          {
            // ISSUE: reference to a compiler-generated field
            DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__4_0 = predicate = (Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345015432)));
          }
          else
            goto label_28;
label_23:
          list = serviceData.Where<KeyValuePair<string, string>>(predicate).ToList<KeyValuePair<string, string>>();
          num1 = 12;
          continue;
label_28:
          predicate = func2;
          goto label_23;
        }
label_25:
        return;
label_21:
        return;
label_14:;
      }

      /// <inheritdoc />
      public override void OnPostPublish(PostPublishParameters parameters)
      {
        int num = 4;
        ICollection<DeployLogMessage> deployLogMessages;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_2;
            case 2:
              parameters.Messages.AddRange((IEnumerable<DeployLogMessage>) deployLogMessages);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 3:
              if (DataClassMetadataImportExtension.DataClassConfigImportExtension.bPjYMn8HHJ2toEtJPCwl((object) deployLogMessages) <= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                continue;
              }
              goto case 2;
            case 4:
              deployLogMessages = this.DeployLogMessages;
              num = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_5:
        return;
label_2:
        return;
label_8:;
      }

      public void Publish(
        IEnumerable<Guid> headerUids,
        ICollection<DeployLogMessage> messages = null,
        string treeUid = null)
      {
        messages = messages ?? this.DeployLogMessages;
        ((ISecurityService) this.securityService).RunWithElevatedPrivilegies((System.Action) (() =>
        {
          switch (1)
          {
            case 1:
              try
              {
                UIMetadataPublishResult metadataPublishResult = ((IDataClassMetadataItemManager) this.dataClassMetadataItemManager).Publish(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740732902), headerUids.ToArray<Guid>());
                int num1 = 6;
                string text;
                List<ValidationError>.Enumerator enumerator;
                string str;
                while (true)
                {
                  switch (num1)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.FcT3KXZP97klOJbvmUU4((object) DataClassMetadataImportExtension.ImportLog, (object) text);
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 4;
                      continue;
                    case 2:
                      goto label_28;
                    case 3:
                    case 8:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      str = (string) DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(-1380439818 << 3 ^ 1841787124));
                      num1 = 5;
                      continue;
                    case 4:
                      messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, false));
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 10 : 9;
                      continue;
                    case 5:
                      DataClassMetadataImportExtension.ImportLog.Info((object) str);
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 9;
                      continue;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      if (DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.yegcU5ZPy1NKDk9E5l4B((object) metadataPublishResult.Errors) == 0)
                      {
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 3;
                        continue;
                      }
                      goto case 7;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      text = (string) DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(323422137 << 2 ^ 1293559810));
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                      continue;
                    case 9:
                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, str, false));
                      num1 = 2;
                      continue;
                    case 10:
                      enumerator = metadataPublishResult.Errors.GetEnumerator();
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_10;
                  }
                }
label_28:
                break;
label_10:
                try
                {
label_18:
                  if (enumerator.MoveNext())
                    goto label_15;
                  else
                    goto label_19;
label_12:
                  ValidationError current;
                  int num2;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        goto label_18;
                      case 2:
                        goto label_15;
                      case 3:
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, current.Message, false));
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
                        continue;
                      case 4:
                        goto label_24;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.FcT3KXZP97klOJbvmUU4((object) DataClassMetadataImportExtension.ImportLog, (object) current);
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 3;
                        continue;
                    }
                  }
label_24:
                  break;
label_15:
                  current = enumerator.Current;
                  num2 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                  {
                    num2 = 0;
                    goto label_12;
                  }
                  else
                    goto label_12;
label_19:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 4 : 4;
                  goto label_12;
                }
                finally
                {
                  enumerator.Dispose();
                  int num3 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                    num3 = 0;
                  switch (num3)
                  {
                    default:
                  }
                }
              }
              catch (Exception ex)
              {
                int num = 2;
                string text;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, false));
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 5;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      text = (string) DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(-1876063057 ^ -1876182455));
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
                      continue;
                    case 3:
                      messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, ObjectsExportConsts.ExportExtensionUidDataClass, treeUid));
                      num = 4;
                      continue;
                    case 4:
                      goto label_20;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      DataClassMetadataImportExtension.DataClassConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.lDt7grZPdaoVUtwel9o3((object) DataClassMetadataImportExtension.ImportLog, (object) text, (object) ex);
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                      continue;
                    default:
                      if (!string.IsNullOrWhiteSpace(treeUid))
                      {
                        num = 3;
                        continue;
                      }
                      goto label_13;
                  }
                }
label_20:
                break;
label_13:
                break;
              }
          }
        }));
      }

      private ICollection<DeployLogMessage> DeployLogMessages
      {
        get
        {
          object deployLogMessages;
          if (!((IActorContextService) this.actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397134376), out deployLogMessages))
            ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858754735), (object) (List<DeployLogMessage>) (deployLogMessages = (object) new List<DeployLogMessage>()));
          return (ICollection<DeployLogMessage>) deployLogMessages;
        }
      }

      /// <inheritdoc />
      public override void OnPreStartTest(PreStartTestImportParameters parameters)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.SetPromisedDependenciesKey((IDictionary<string, string>) parameters.ServiceData);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override void OnPrePublish(PrePublishParameters parameters)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.SetPromisedDependenciesKey(parameters.ServiceData);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      private void SetPromisedDependenciesKey(IDictionary<string, string> serviceData)
      {
        foreach (KeyValuePair<string, string> keyValuePair in serviceData.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439732362)))).ToList<KeyValuePair<string, string>>())
        {
          Guid result;
          if (Guid.TryParse(keyValuePair.Value, out result))
          {
            ((IActorContextService) this.actorContextService).Set(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137465792), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106453838), (object) keyValuePair.Value), (object) result);
            ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477112546), (object) string.Empty);
            serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712453491)] = string.Empty;
          }
        }
      }

      internal static void dJ3gri8HwxTiH2YAeHkr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool vywxm28HDPmn3ButOX8f() => DataClassMetadataImportExtension.DataClassConfigImportExtension.g8vwQn8HanyLrF8kFbmA == null;

      internal static DataClassMetadataImportExtension.DataClassConfigImportExtension AKMhxE8HtI4gVxXX8bD2() => (DataClassMetadataImportExtension.DataClassConfigImportExtension) DataClassMetadataImportExtension.DataClassConfigImportExtension.g8vwQn8HanyLrF8kFbmA;

      internal static int jCjqhH8H4eWMumw0r1RH([In] object obj0) => ((ImportExtensionParameters) obj0).ImportStep;

      internal static object H7eYBC8H6MkgsNXS67jQ([In] object obj0) => (object) ((ImportExtensionParameters) obj0).TreeUid;

      internal static int bPjYMn8HHJ2toEtJPCwl([In] object obj0) => ((ICollection<DeployLogMessage>) obj0).Count;
    }

    [Component(Order = -90)]
    private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
    {
      private readonly object actorContextService;
      private readonly ILazy<DataClassMetadataImportExtension.DataClassConfigImportExtension> dataClassConfigImportExtension;

      public ModelAssemblyBuilderHandler(
        IActorContextService actorContextService,
        ILazy<DataClassMetadataImportExtension.DataClassConfigImportExtension> dataClassConfigImportExtension)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.actorContextService = (object) actorContextService;
        this.dataClassConfigImportExtension = dataClassConfigImportExtension;
      }

      public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
      {
        ICollection<Guid> importHeaders = DataClassMetadataImportExtension.GetImportHeaders(this.actorContextService);
        if (importHeaders.Count <= 0)
          return;
        this.dataClassConfigImportExtension.Value.Publish((IEnumerable<Guid>) importHeaders);
      }

      public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
      {
      }

      public void AfterAll(
        IEnumerable<AbstractMetadata> publishMetadataList,
        IEnumerable<ScriptModule> scriptModules,
        IEnumerable<ScriptModule> clientScriptModules)
      {
      }
    }

    /// <summary>
    /// Обработка метаданных структур обмена данными при импорте
    /// </summary>
    [Component]
    private sealed class DataClassMetadataImport : MetadataImport
    {
      private static object aweRS28H0PAtmy1QgFxV;

      /// <inheritdoc />
      public override void CreateFakeChapter(
        NamedMetadata namedMd,
        BPMAppFakeManifest fakeManifest,
        BPMAppManifest manifest)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              if (namedMd is DataClassMetadata dataClassMetadata)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 3 : 2;
                continue;
              }
              goto label_8;
            case 2:
              if (fakeManifest != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            case 3:
              fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidDataClass).GetOrCreateItemByUid(dataClassMetadata.Uid, (string) DataClassMetadataImportExtension.DataClassMetadataImport.sic9gd8HMrV6tKkOcUjD((object) dataClassMetadata));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_2:
        return;
label_10:
        return;
label_8:
        return;
label_9:;
      }

      public DataClassMetadataImport()
      {
        DataClassMetadataImportExtension.DataClassMetadataImport.UM29fF8HJaNXIiClDF7e();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object sic9gd8HMrV6tKkOcUjD([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

      internal static bool j4sdSI8HmheNcO45kQyR() => DataClassMetadataImportExtension.DataClassMetadataImport.aweRS28H0PAtmy1QgFxV == null;

      internal static DataClassMetadataImportExtension.DataClassMetadataImport rHGgUB8HyuRoUpOOIjVH() => (DataClassMetadataImportExtension.DataClassMetadataImport) DataClassMetadataImportExtension.DataClassMetadataImport.aweRS28H0PAtmy1QgFxV;

      internal static void UM29fF8HJaNXIiClDF7e() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

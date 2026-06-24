// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbPreUpdater
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Класс предназначен для создания необходимых структур в БД и работы с ними в момент регистрации менеджера моделей.
  /// Работает с опубликованными моделями.
  /// </summary>
  public class DbPreUpdater
  {
    /// <summary>Номер версии системы при первом запуске</summary>
    public const int NewVersionNumber = 0;
    internal const string Index_ConfigInfo_Id = "Idx_ConfigInfo_Id";
    private ITransformationProvider transform;
    private BackupManager backupManager;
    private bool structuresCreated;
    private Guid configurationUid;
    private bool needRecompileConfigurationModel;
    private bool updatingStarted;
    private bool forLicenseCheck;
    private bool isFirstServerInCluster;
    private readonly XmlObjectSerializableType xmlObjSerType;
    private bool isFirstStart;
    private static DbPreUpdater jGk8IWW8tPAq0EJH7CW6;

    /// <summary>Ctor</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="backupManager">Менеджер резервного копирования</param>
    /// <param name="forLicenseCheck">Только для проверки лицензирования</param>
    /// <param name="isFirstServerInCluster">Сервер является первым в кластере</param>
    public DbPreUpdater(
      ITransformationProvider transform,
      BackupManager backupManager,
      bool forLicenseCheck,
      bool isFirstServerInCluster)
    {
      DbPreUpdater.aevHXWW86ph861HmEOTP();
      this.xmlObjSerType = new XmlObjectSerializableType();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CheckStructuresCreated();
            num = 2;
            continue;
          case 2:
            this.ReadOrCreateConfigurationInfo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 5 : 5;
            continue;
          case 3:
            this.forLicenseCheck = forLicenseCheck;
            num = 4;
            continue;
          case 4:
            this.isFirstServerInCluster = isFirstServerInCluster;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
          case 5:
            goto label_3;
          case 6:
            this.transform = transform;
            num = 7;
            continue;
          case 7:
            this.backupManager = forLicenseCheck ? (BackupManager) null : backupManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 3 : 3;
            continue;
          default:
            DbPreUpdater.ImkeT9W8ASqT0oqM4uyb((object) transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1470998129 - 231418599 ^ 1239665564));
            num = 6;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Получить кэш запуска приложения</summary>
    /// <returns></returns>
    internal ApplicationStartCache GetApplicationStartCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CheckStructuresCreated();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ApplicationStartCache) DbPreUpdater.jrUOQhW87XvhKq8xiWcO((object) this.transform);
    }

    /// <summary>Уникальный идентификатор конфигурации (хранится в БД)</summary>
    public Guid ConfigurationUid => this.configurationUid;

    /// <summary>
    /// Было ли сделано резервное копирование при старте приложения
    /// </summary>
    public bool BackupCreated
    {
      get
      {
        int num = 1;
        BackupManager backupManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              backupManager = this.backupManager;
              if (backupManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        return backupManager.BackupCreated;
      }
    }

    /// <summary>
    /// Получить список с информацией об опубликованных сборках с моделями
    /// </summary>
    /// <param name="status">Статус</param>
    /// <returns>Список с информацией об опубликованных сборках с моделями</returns>
    public IEnumerable<AssemblyModelsMetadata> GetAssemblyModels(AssemblyModelsMetadataStatus status) => this.GetAssemblyModels(status, Array.Empty<string>());

    /// <summary>
    /// Получить список с информацией об опубликованных сборках с моделями
    /// </summary>
    /// <param name="status">Статус</param>
    /// <param name="assemblyNames">Имена сборок</param>
    /// <returns>Список с информацией об опубликованных сборках с моделями</returns>
    public IEnumerable<AssemblyModelsMetadata> GetAssemblyModels(
      AssemblyModelsMetadataStatus status,
      params string[] assemblyNames)
    {
      this.CheckStructuresCreated();
      List<AssemblyModelsMetadata> assemblyModels = new List<AssemblyModelsMetadata>();
      string str1 = ((int) status).ToString();
      if (status == AssemblyModelsMetadataStatus.Runned)
        str1 = str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439611956) + (object) 3;
      string str2 = "";
      if (assemblyNames != null && assemblyNames.Length != 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        str2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629873394), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333690946)), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124618366), ((IEnumerable<string>) assemblyNames).Select<string, string>((System.Func<string, string>) (x => (string) DbPreUpdater.\u003C\u003Ec.eoWJ0lQpJlcm5iXeWlqd((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477138812), (object) x, DbPreUpdater.\u003C\u003Ec.HngkJ9QpMAk3N4cANOIt(-1867198571 ^ -1867197749))))));
      }
      using (IDataReader reader = this.Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3369866), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765896720)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672160622)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173648671)), (object) str1, (object) str2), (Dictionary<string, object>) null))
      {
        while (reader.Read())
        {
          MemoryStream stream1 = reader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021364853));
          MemoryStream stream2 = reader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979271893));
          MemoryStream stream3 = reader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29348787));
          MemoryStream stream4 = reader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413581533));
          AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata()
          {
            Id = Convert.ToInt64(reader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583777878)]),
            Name = (string) reader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654211849)],
            Status = (AssemblyModelsMetadataStatus) Convert.ToInt32(reader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138127362)]),
            AssemblyRawStream = stream1,
            DocumentationRawStream = stream3,
            MetadataStream = stream4,
            DebugRawStream = stream2
          };
          if (status != AssemblyModelsMetadataStatus.Prepared || assemblyModelsMetadata.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909179141))
            assemblyModels.Add(assemblyModelsMetadata);
        }
      }
      return (IEnumerable<AssemblyModelsMetadata>) assemblyModels;
    }

    /// <summary>Получить список имен сборок с моделями</summary>
    /// <returns></returns>
    public IEnumerable<string> GetAssemblyModelNames()
    {
      this.CheckStructuresCreated();
      List<string> assemblyModelNames = new List<string>();
      using (IDataReader dataReader = this.Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360311119), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333690946)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317688310))), (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          assemblyModelNames.Add((string) dataReader[0]);
      }
      return (IEnumerable<string>) assemblyModelNames;
    }

    /// <summary>Требуется пересобрать конфигурацию</summary>
    public bool NeedRecompileConfigurationModel => this.needRecompileConfigurationModel;

    /// <summary>Опубликовать текущую модель метаданных конфигурации</summary>
    public void RecompileConfigurationModel(IMetadataRuntimeService runtimeService)
    {
      int num1 = 2;
      IStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_33;
          case 1:
            goto label_3;
          case 2:
            startInformation = (IStartInformation) DbPreUpdater.Ty81mOW805BRhFyFA4Ci(12.0, DbPreUpdater.suPfR4W8xUyaN4MydJQh(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1597012150 ^ 1597098296)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
            continue;
          default:
            goto label_26;
        }
      }
label_33:
      return;
label_26:
      return;
label_3:
      try
      {
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num2 = 2;
        IEnumerable<IMetadataItem> metadataItems;
        IEnumerable<AssemblyModelsMetadata> publishedAssemblyMetadata;
        while (true)
        {
          object assemblyRaw;
          switch (num2)
          {
            case 1:
              publishedAssemblyMetadata = this.GetAssemblyModels(AssemblyModelsMetadataStatus.Published);
              num2 = 4;
              continue;
            case 2:
              metadataItems = this.LoadMetadataItems();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 3 : 6;
              continue;
            case 3:
              assemblyRaw = (object) null;
              break;
            case 4:
              // ISSUE: reference to a compiler-generated method
              AssemblyModelsMetadata assemblyModelsMetadata = publishedAssemblyMetadata.FirstOrDefault<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (a => (string) DbPreUpdater.\u003C\u003Ec.qdvptIQp9XBUqrmmlujd((object) a) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488879697)));
              if (assemblyModelsMetadata == null)
              {
                num2 = 3;
                continue;
              }
              assemblyRaw = DbPreUpdater.g96rFSW8mhCWlGtakJ60((object) assemblyModelsMetadata);
              break;
            case 5:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 6:
              Locator.GetServiceNotNull<IMetadataUidChecker>().AddUidIfNeeded(metadataItems);
              num2 = 7;
              continue;
            case 7:
              metadataItems = (IEnumerable<IMetadataItem>) metadataItems.ToReadOnlyCollection<IMetadataItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
              continue;
            default:
              goto label_16;
          }
          ConfigurationModelAssemblyBuilder.InitVersion((MemoryStream) assemblyRaw);
          num2 = 5;
        }
label_16:
        try
        {
          ConfigurationModelAssemblyBuilder.Publish(metadataItems, (Func<string, AssemblyModelsMetadataStatus, AssemblyModelsMetadata>) ((assemblyName, status) =>
          {
            int num3 = 1;
            string assemblyName1;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_4;
                case 3:
                  if (status != AssemblyModelsMetadataStatus.Published)
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 2;
                    continue;
                  }
                  goto label_5;
                default:
                  assemblyName1 = assemblyName;
                  num3 = 3;
                  continue;
              }
            }
label_4:
            return (AssemblyModelsMetadata) null;
label_5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return publishedAssemblyMetadata.FirstOrDefault<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (a => DbPreUpdater.\u003C\u003Ec__DisplayClass12_1.Be3mmeQpstFmf7SftMbE(DbPreUpdater.\u003C\u003Ec__DisplayClass12_1.xxd7FrQpUQkyXI2CqZD6((object) a), (object) assemblyName1)));
          }), new Action<AssemblyModelsMetadata>(this.SaveAssemblyModelsMetadata), Locator.GetServiceNotNull<IMetadataRuntimeService>(), Locator.GetServiceNotNull<IModelAssemblyBuilderHandler>());
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                this.Transform.Update((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1470998129 - 231418599 ^ 1239565224), new string[1]
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939422364)
                }, new object[1]{ (object) (short) 0 }, (string) null);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_22;
              default:
                DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.Transform);
                num4 = 2;
                continue;
            }
          }
label_22:;
        }
        catch
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_28;
              default:
                DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.Transform);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                continue;
            }
          }
label_28:
          throw;
        }
      }
      finally
      {
        if (startInformation != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                DbPreUpdater.Si324IW899daRPSvoG8Z((object) startInformation);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
    }

    public IEnumerable<string> GetActivatedModules()
    {
      this.CheckStructuresCreated();
      List<string> activatedModules = new List<string>();
      using (IDataReader dataReader = this.Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106546538), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108674010)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70058994))), (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          activatedModules.Add((string) dataReader[0]);
      }
      return (IEnumerable<string>) activatedModules;
    }

    public IEnumerable<string> GetDeactivatingModules()
    {
      this.CheckStructuresCreated();
      List<string> deactivatingModules = new List<string>();
      using (IDataReader dataReader = this.Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536824120), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195650813)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335087529))), (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          deactivatingModules.Add((string) dataReader[0]);
      }
      return (IEnumerable<string>) deactivatingModules;
    }

    /// <summary>Установить признак начала преобразования БД</summary>
    public void StartUpdating()
    {
      int num1 = 2;
      DbPreUpdater dbPreUpdater;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            dbPreUpdater = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_27;
          default:
            goto label_2;
        }
      }
label_27:
      return;
label_2:
      try
      {
        Monitor.Enter((object) dbPreUpdater, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_22;
            case 1:
              if (!this.updatingStarted)
              {
                num2 = 2;
                continue;
              }
              goto label_18;
            case 2:
            case 3:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = 4;
              continue;
            case 4:
              try
              {
                this.Transform.Update((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(825385222 ^ 825383204), new string[1]
                {
                  (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1886646897 ^ -1886535929)
                }, new object[1]{ (object) (short) 1 }, (string) null);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.Transform);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_21;
                  }
                }
              }
              catch
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.Transform);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_20;
                  }
                }
label_20:
                throw;
              }
            case 5:
              goto label_14;
            case 6:
label_21:
              this.updatingStarted = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_22:
        return;
label_14:
        return;
label_12:
        return;
label_18:;
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_29;
              default:
                DbPreUpdater.noyWtOW8d6ojcnfZSGx2((object) dbPreUpdater);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_29:;
      }
    }

    /// <summary>Установить признак завершения преобразования БД</summary>
    public void EndUpdating()
    {
      int num1 = 1;
      DbPreUpdater dbPreUpdater;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            dbPreUpdater = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_25;
          case 3:
            goto label_2;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 2;
            continue;
        }
      }
label_25:
      return;
label_2:
      try
      {
        Monitor.Enter((object) dbPreUpdater, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
label_6:
              this.updatingStarted = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 4;
              continue;
            case 3:
            case 5:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 6 : 0;
              continue;
            case 4:
              goto label_14;
            case 6:
              try
              {
                this.Transform.Update((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1917998801 >> 2 ^ 479505814), new string[1]
                {
                  (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(323422137 << 2 ^ 1293790316)
                }, new object[1]{ (object) (short) 0 }, (string) null);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_6;
                    default:
                      this.Transform.CommitTransaction();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_16;
                    default:
                      DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.Transform);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                      continue;
                  }
                }
label_16:
                throw;
              }
            default:
              if (this.updatingStarted)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 5;
                continue;
              }
              goto label_19;
          }
        }
label_20:
        return;
label_14:
        return;
label_19:;
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                Monitor.Exit((object) dbPreUpdater);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
    }

    public bool IsFirstStart => this.isFirstStart;

    /// <summary>
    /// Версия, с которой запускались перед обновлением (если оно было)
    /// </summary>
    public int OldVersion
    {
      get => this.\u003COldVersion\u003Ek__BackingField;
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
              this.\u003COldVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Проверить метаданные</summary>
    /// <param name="metadata">Список метаданных</param>
    internal void CheckMetadataList(IEnumerable<AssemblyModelsMetadata> metadata)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      AssemblyModelsMetadata assemblyModelsMetadata = metadata.FirstOrDefault<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (a => DbPreUpdater.\u003C\u003Ec.GSAs0UQpd0xd9jvUR3Ho(DbPreUpdater.\u003C\u003Ec.qdvptIQp9XBUqrmmlujd((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3330434))));
      if (assemblyModelsMetadata == null)
        return;
      EleWise.ELMA.Model.Metadata.AbstractMetadata[] metadata1 = assemblyModelsMetadata.RestoreMetadata();
      if (!Locator.GetServiceNotNull<IMetadataUidChecker>().AddUidIfNeeded((IEnumerable<IMetadata>) metadata1))
        return;
      this.needRecompileConfigurationModel = true;
    }

    /// <summary>Провайдер преобразования БД</summary>
    protected internal ITransformationProvider Transform => this.transform;

    /// <summary>Создать структуры</summary>
    protected virtual void CreateStructures()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        IDataReader dataReader;
        int num3;
        Column column1;
        Column column2;
        IList<AssemblyModelsMetadataStatus> configurationStatuses;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_101;
            case 2:
              try
              {
                this.isFirstStart = true;
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num4 = 3;
                EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_95;
                    case 2:
                      DbPreUpdater.xZVBfWW85iZWwuMsmLIf((object) this.Transform, (object) table1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
                      DbPreUpdater.YmO9FYW8rrece5TlckWN((object) table2, false);
                      DbPreUpdater.yKIaKJW8g7mismHyIbLN((object) table2, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(2045296739 + 1688595713 ^ -561081018));
                      table2.Columns = new List<Column>()
                      {
                        new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1598106783 - -968262081 ^ -629872706), DbType.Int32),
                        column1,
                        column2
                      };
                      table1 = table2;
                      num4 = 2;
                      continue;
                    default:
                      DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.Transform);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_31;
                    default:
                      DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.Transform);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_31:
                throw;
              }
            case 3:
              goto label_98;
            case 4:
              num3 = 1;
              num2 = 35;
              continue;
            case 5:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 6:
              this.OldVersion = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 2;
              continue;
            case 7:
              try
              {
                DbPreUpdater.k9aU2nW8LZC6Kee0lLbp((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(381945751 ^ 1158627804 ^ 1405845097), (object) column2);
                int num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                  num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.Transform);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_97;
                  }
                }
              }
              catch
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.Transform);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_122;
                  }
                }
label_122:
                throw;
              }
            case 8:
              goto label_33;
            case 9:
              if (!DbPreUpdater.iuabpAW8YFXasruMAaOc((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-787452571 ^ -787458745), DbPreUpdater.lb7TleW8jbo2SYpnhIyM((object) column1)))
              {
                num2 = 25;
                continue;
              }
              goto case 11;
            case 10:
              try
              {
                DbPreUpdater.k9aU2nW8LZC6Kee0lLbp((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(2045296739 + 1688595713 ^ -561081018), (object) column1);
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_102;
                    default:
                      this.Transform.CommitTransaction();
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch
              {
                int num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      this.Transform.RollbackTransaction();
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_64;
                  }
                }
label_64:
                throw;
              }
            case 11:
label_102:
              if (DbPreUpdater.iuabpAW8YFXasruMAaOc((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1290212282 ^ -644262414 ^ 1786872214), DbPreUpdater.lb7TleW8jbo2SYpnhIyM((object) column2)))
              {
                num2 = 15;
                continue;
              }
              goto case 24;
            case 12:
              this.StartUpdating();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 4;
              continue;
            case 13:
label_95:
              if (num3 != 0)
              {
                num2 = 3;
                continue;
              }
              if (this.OldVersion <= 417)
              {
                if (this.OldVersion > 0)
                {
                  num2 = 34;
                  continue;
                }
                goto case 22;
              }
              else
                goto label_100;
            case 14:
              goto label_104;
            case 15:
            case 26:
label_97:
              dataReader = this.Transform.ExecuteQuery((string) DbPreUpdater.ELtx6oW8cdPO0PXgbxSY(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1242972401 >> 4 ^ 77649577), DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(236071375 ^ 236065261))), (Dictionary<string, object>) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 20 : 21;
              continue;
            case 16:
              DbPreUpdater.w4C35IWZbnjmbeoQ1j1r((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1819636893 << 3 ^ 1672191178), (object) new string[2]
              {
                (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1998538950 ^ -1998518874),
                (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(236071375 ^ 236165959)
              }, (object) new object[2]
              {
                (object) 417,
                (object) (short) 1
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
            case 17:
              goto label_120;
            case 18:
label_55:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 37 : 22;
              continue;
            case 19:
              if (this.OldVersion > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 12 : 10;
                continue;
              }
              goto case 16;
            case 20:
              if (!DbPreUpdater.zOG0gyW8lNYgfxgquTpm((object) this.Transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(901793403 ^ 901807705)))
              {
                num2 = 8;
                continue;
              }
              goto case 9;
            case 21:
              try
              {
                int num10;
                if (!DbPreUpdater.uIf3x6W8zmoPMZGFkXfa((object) dataReader))
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 2;
                else
                  goto label_10;
label_6:
                while (true)
                {
                  int num11;
                  switch (num10)
                  {
                    case 1:
                      if (DbPreUpdater.WSxfrUWZF64N0Xup0NWn((object) dataReader, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1917256330 ^ 1917235202)) is DBNull)
                      {
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 4;
                        continue;
                      }
                      num11 = (int) Convert.ToInt16(DbPreUpdater.WSxfrUWZF64N0Xup0NWn((object) dataReader, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(~1767720452 ^ -1767699597)));
                      break;
                    case 2:
                    case 3:
                      goto label_95;
                    case 4:
                      num11 = 0;
                      break;
                    case 5:
                      this.needRecompileConfigurationModel = !(DbPreUpdater.WSxfrUWZF64N0Xup0NWn((object) dataReader, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1242972401 >> 4 ^ 77649383)) is DBNull) && DbPreUpdater.QG244LWZB25dUs32Oscj(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488771037)]) != (short) 0;
                      num10 = 2;
                      continue;
                    default:
                      goto label_10;
                  }
                  num3 = num11;
                  num10 = 5;
                }
label_10:
                this.OldVersion = Convert.ToInt32(DbPreUpdater.WSxfrUWZF64N0Xup0NWn((object) dataReader, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1994213607 >> 4 ^ 124544530)));
                num10 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                {
                  num10 = 0;
                  goto label_6;
                }
                else
                  goto label_6;
              }
              finally
              {
                if (dataReader != null)
                {
                  int num12 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                    num12 = 1;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                        DbPreUpdater.Si324IW899daRPSvoG8Z((object) dataReader);
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_20;
                    }
                  }
                }
label_20:;
              }
            case 22:
              if (this.OldVersion != 417)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 17 : 23;
                continue;
              }
              goto case 27;
            case 23:
              if (this.OldVersion > 0)
              {
                num2 = 33;
                continue;
              }
              goto case 27;
            case 24:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = 7;
              continue;
            case 25:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = 10;
              continue;
            case 27:
              if (this.OldVersion != 417)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 19 : 8;
                continue;
              }
              goto case 29;
            case 28:
              goto label_107;
            case 29:
label_93:
              if (this.needRecompileConfigurationModel)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 32 : 4;
                continue;
              }
              goto case 39;
            case 30:
              try
              {
                this.CreateSysTableGenerators(this.transform, this.OldVersion);
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                  num13 = 0;
                while (true)
                {
                  switch (num13)
                  {
                    case 1:
                      goto label_55;
                    default:
                      this.Transform.CommitTransaction();
                      num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
              catch
              {
                int num14 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
                  num14 = 0;
                while (true)
                {
                  switch (num14)
                  {
                    case 1:
                      this.Transform.RollbackTransaction();
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_51;
                  }
                }
label_51:
                throw;
              }
            case 31:
              goto label_91;
            case 32:
              goto label_116;
            case 33:
              this.backupManager.DoBackup(DbPreUpdater.g1joUOWZoDIZZb5rOLkc(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516941350), (object) this.OldVersion, (object) 417));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 27 : 19;
              continue;
            case 34:
              if (this.OldVersion >= 17)
              {
                num2 = 22;
                continue;
              }
              goto label_107;
            case 35:
            case 38:
              DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.Transform);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 30 : 10;
              continue;
            case 36:
              this.needRecompileConfigurationModel = !configurationStatuses.Contains(AssemblyModelsMetadataStatus.Published) || this.isFirstServerInCluster && configurationStatuses.Contains(AssemblyModelsMetadataStatus.Prepared);
              num2 = 17;
              continue;
            case 37:
              try
              {
                DbPreUpdater.yyMLbsWZhKTGHhvIkGY9((object) this.transform, this.OldVersion);
                int num15 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                  num15 = 2;
                while (true)
                {
                  switch (num15)
                  {
                    case 1:
                      DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.Transform);
                      num15 = 10;
                      continue;
                    case 2:
                      this.needRecompileConfigurationModel = this.OldVersion > 0;
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 5 : 5;
                      continue;
                    case 3:
                      DbPreUpdater.v8QQACWZGmm2hsodlekT((object) this.transform, this.OldVersion);
                      num15 = 9;
                      continue;
                    case 4:
                      if (!this.needRecompileConfigurationModel)
                      {
                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
                        continue;
                      }
                      goto case 5;
                    case 5:
                      this.Transform.ExecuteNonQuery((string) DbPreUpdater.ELtx6oW8cdPO0PXgbxSY(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(~289714581 ^ -289742408), DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-218496594 ^ -218482292))));
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                      continue;
                    case 6:
                      DbPreUpdater.rsdanhWZfgB2SmlV3J2R((object) this.transform, this.OldVersion);
                      num15 = 7;
                      continue;
                    case 7:
                      this.CreateDbConfigurationInfo(this.OldVersion);
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 5 : 8;
                      continue;
                    case 8:
                      this.CreateDbActivatedModule(this.OldVersion);
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 11 : 4;
                      continue;
                    case 9:
                      DbPreUpdater.cc2AIDWZEXij4MUocEdn((object) this.backupManager, (object) this.transform, this.OldVersion);
                      num15 = 6;
                      continue;
                    case 10:
                      goto label_93;
                    case 11:
                      this.CreateDbDeactivatingModule(this.OldVersion);
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 1;
                      continue;
                    default:
                      this.Transform.Insert((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858889341), new string[3]
                      {
                        (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-2106517564 ^ -2106546856),
                        (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-812025778 ^ -812070202),
                        (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858990007)
                      }, new object[3]
                      {
                        (object) 417,
                        (object) (short) num3,
                        (object) (short) (!this.needRecompileConfigurationModel ? 0 : 1)
                      });
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch
              {
                int num16 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num16 = 0;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      goto label_89;
                    default:
                      this.Transform.RollbackTransaction();
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_89:
                throw;
              }
            case 39:
              configurationStatuses = this.GetModelConfigurationStatuses();
              num2 = 36;
              continue;
            default:
              goto label_92;
          }
        }
label_33:
        this.Transform.BeginTransaction();
        num1 = 2;
        continue;
label_91:
        column2 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35950533), DbType.Int16);
        num1 = 20;
        continue;
label_92:
        column1 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852948340), DbType.Int16);
        num1 = 31;
        continue;
label_100:
        num1 = 14;
        continue;
label_101:
        num3 = 0;
        num1 = 38;
      }
label_120:
      return;
label_116:
      return;
label_98:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-688192331 - 435440695 ^ -1123611976)));
label_104:
      throw new InvalidOperationException((string) DbPreUpdater.xXdaXXWZW9Tj0HapouU1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597098846)));
label_107:
      throw new InvalidOperationException((string) DbPreUpdater.xXdaXXWZW9Tj0HapouU1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239666656)));
    }

    /// <summary>Сохранить модель сборки</summary>
    /// <param name="asmModelsMetadata"></param>
    public void SaveAssemblyModelsMetadata(AssemblyModelsMetadata asmModelsMetadata)
    {
      int num = 1;
      object[] values;
      string[] columns;
      while (true)
      {
        switch (num)
        {
          case 1:
            columns = new string[6]
            {
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(381945751 ^ 1158627804 ^ 1405810203),
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1334993905 ^ -1335026295),
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-630932142 - 1120244082 ^ -1751213344),
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1642859704 ^ 1642970518),
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1917256330 ^ 1917301832),
              (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858989893)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            if (DbPreUpdater.UWL7EqWZZKeONMDQ1dbs((object) asmModelsMetadata) <= 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 2;
              continue;
            }
            this.Transform.Update((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1998538950 ^ -1998518304), columns, values, (string) DbPreUpdater.zTE5i8WZuEquVqesUmMQ((object) ((Dialect) DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333769036)), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-53329496 >> 4 ^ -3332080), (object) asmModelsMetadata.Id));
            num = 5;
            continue;
          case 3:
            goto label_5;
          case 4:
            this.Transform.Insert(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515047923), columns, values, true);
            num = 3;
            continue;
          case 5:
            goto label_2;
          default:
            values = new object[6]
            {
              DbPreUpdater.rhX1xaWZQXqD7lpfGYLU((object) asmModelsMetadata),
              (object) (int) DbPreUpdater.kUBdHNWZC5143WbtYD4a((object) asmModelsMetadata),
              (object) new ParameterValue(DbType.Binary, (object) asmModelsMetadata.AssemblyRawStream),
              (object) new ParameterValue(DbType.Binary, DbPreUpdater.TFWIF3WZvJsyHByalrUD((object) asmModelsMetadata)),
              (object) new ParameterValue(DbType.Binary, (object) asmModelsMetadata.MetadataStream),
              (object) new ParameterValue(DbType.Binary, DbPreUpdater.FI047GWZ8EMweiSiSZbV((object) asmModelsMetadata))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
            continue;
        }
      }
label_5:
      return;
label_2:;
    }

    /// <summary>
    /// Удаляем запись о том что есть метаданные, требующих перезагрузку
    /// </summary>
    public void DeletePreparedModelConfiguration()
    {
      int num = 2;
      string sql;
      Dictionary<string, object> paramValues;
      while (true)
      {
        switch (num)
        {
          case 1:
            paramValues = new Dictionary<string, object>()
            {
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345440876),
                (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939375896)
              },
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137985927),
                (object) 2
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            sql = (string) DbPreUpdater.e3GYhMWZVROXjnXmtF0G(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1051276242 - 990076387 ^ 61104195), (object) new object[4]
            {
              DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1021410165 ^ 1021365167)),
              DbPreUpdater.FoEeTYWZIjAGsxhSUhuV((object) this.Transform),
              DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107933618)),
              DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1819636893 << 3 ^ 1672160622))
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            this.Transform.ExecuteNonQuery(sql, paramValues);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 3;
            continue;
        }
      }
label_2:;
    }

    private void CheckStructuresCreated()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (!this.structuresCreated)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 6;
              continue;
            }
            goto label_13;
          case 2:
            if (!this.forLicenseCheck)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 3:
            goto label_10;
          case 4:
            DbPreUpdater.YM9A7lWZSys0QpCuZDKE((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 3;
            continue;
          case 5:
            goto label_6;
          case 6:
            this.structuresCreated = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 4;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_10:
      return;
label_6:
      return;
label_2:
      return;
label_9:
      return;
label_13:;
    }

    private void CreateSysTableGenerators(
      ITransformationProvider transformationProvider,
      int version)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (version != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        DbPreUpdater.XuEbntWZiWaPObecWaHU((object) transformationProvider);
        num = 3;
      }
label_3:
      return;
label_2:;
    }

    private void CreateDbConfigurationInfo(int version)
    {
      int num = 6;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_11;
          case 3:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            DbPreUpdater.yKIaKJW8g7mismHyIbLN((object) table2, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-882126494 ^ -882219196));
            table2.Columns = new List<Column>()
            {
              new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(~538519529 ^ -538551992), DbType.Int32),
              new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1669371371 ^ 1669397113), DbType.Guid),
              new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-649342099 - -1150814748 ^ 501378013), DbType.String)
            };
            table1 = table2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          case 4:
            ITransformationProvider transform = this.transform;
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
            DbPreUpdater.YUHSZBWZR5sl2SlTlhuY((object) index, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(333888594 ^ 1075625116 ^ 1409005288));
            DbPreUpdater.PcwPwJWZqqG5tcBrl3WI((object) index, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812069318));
            index.Columns.Add((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-649342099 - -1150814748 ^ 501439703));
            DbPreUpdater.s698xMWZKTkCnCqT9U1y((object) transform, (object) index);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          case 5:
            if (DbPreUpdater.zOG0gyW8lNYgfxgquTpm((object) this.transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-1638402543 ^ -1638514633)))
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 6:
            if (version == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 4;
              continue;
            }
            goto label_2;
          default:
            DbPreUpdater.xZVBfWW85iZWwuMsmLIf((object) this.transform, (object) table1);
            num = 4;
            continue;
        }
      }
label_4:
      return;
label_11:
      return;
label_2:;
    }

    private void CreateDbActivatedModule(int version)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!DbPreUpdater.zOG0gyW8lNYgfxgquTpm((object) this.transform, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-606654180 ^ -606698702)))
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 2:
              goto label_7;
            case 3:
              if (version != 0)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 4:
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              DbPreUpdater.yKIaKJW8g7mismHyIbLN((object) table2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113948205));
              table2.Columns = new List<Column>()
              {
                new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-35995181 ^ -35949627), new ColumnType(DbType.String, (int) byte.MaxValue))
              };
              table1 = table2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_11;
            default:
              goto label_4;
          }
        }
label_4:
        DbPreUpdater.xZVBfWW85iZWwuMsmLIf((object) this.transform, (object) table1);
        num1 = 5;
      }
label_7:
      return;
label_11:
      return;
label_3:;
    }

    private void CreateDbDeactivatingModule(int version)
    {
      int num = 2;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.transform.TableExists((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1470440286 ^ 1470402822)))
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 2:
            if (version == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            }
            goto label_9;
          case 3:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            DbPreUpdater.yKIaKJW8g7mismHyIbLN((object) table2, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-218496594 ^ -218385418));
            table2.Columns = new List<Column>()
            {
              new Column((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-2107978722 ^ -2107933176), new ColumnType(DbType.String, (int) byte.MaxValue))
            };
            table1 = table2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            DbPreUpdater.xZVBfWW85iZWwuMsmLIf((object) this.transform, (object) table1);
            num = 4;
            continue;
        }
      }
label_2:
      return;
label_9:
      return;
label_10:;
    }

    private void ReadOrCreateConfigurationInfo()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        string serverTimeZoneData;
        IDataReader dataReader;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_5:
              this.configurationUid = DbPreUpdater.ja1Lc8WZnaeLYpce1jo6();
              num2 = 6;
              continue;
            case 2:
label_3:
              TZ.InitializeServerTimeZone(serverTimeZoneData);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 4 : 7;
              continue;
            case 3:
              try
              {
                if (DbPreUpdater.uIf3x6W8zmoPMZGFkXfa((object) dataReader))
                {
                  int num3 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                    num3 = 2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_42;
                      case 2:
                        this.configurationUid = ((Dialect) DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.transform)).GetGuid(dataReader[(string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(236071375 ^ 236078685)]);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 5 : 8;
                        continue;
                      case 3:
                        serverTimeZoneData = TZ.GetServerTimeZoneForSystemConfig(this.transform);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 4;
                        continue;
                      case 4:
                        goto label_5;
                      case 5:
                        try
                        {
                          DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.transform);
                          int num4 = 5;
                          while (true)
                          {
                            switch (num4)
                            {
                              case 1:
                                goto label_26;
                              case 2:
                                DbPreUpdater.tUDIjeW8yN7x3pP8fhLo((object) this.transform);
                                num4 = 3;
                                continue;
                              case 3:
                                this.transform.Update((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1917998801 >> 2 ^ 479536018), new string[1]
                                {
                                  (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-281842504 ^ -281879828)
                                }, new object[1]
                                {
                                  (object) serverTimeZoneData
                                }, (string) DbPreUpdater.zkQpAUWZTdEjpSf5hKxs(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-281842504 ^ -281879968), DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408926096))));
                                num4 = 4;
                                continue;
                              case 4:
                                this.transform.CommitTransaction();
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                                continue;
                              case 5:
                                this.transform.AddColumn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236167145), new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304626969), DbType.String));
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                                continue;
                              default:
                                DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.transform);
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
                                continue;
                            }
                          }
                        }
                        catch (Exception ex)
                        {
                          int num5 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                            num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                                DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.transform);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_39;
                            }
                          }
label_39:
                          throw new InitializationException(EleWise.ELMA.SR.T((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(654297945 ^ 654212543)), ex);
                        }
                      case 6:
                      case 7:
label_26:
                        DbPreUpdater.QIVAl3WZkW2faECCmEoY((object) serverTimeZoneData);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                        continue;
                      case 8:
                        if (this.transform.ColumnExists((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1994213607 >> 4 ^ 124543656), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137413222)))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                          continue;
                        }
                        goto case 3;
                      default:
                        serverTimeZoneData = (string) DbPreUpdater.WSxfrUWZF64N0Xup0NWn((object) dataReader, DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1581325282 << 3 ^ -234264252));
                        num3 = 6;
                        continue;
                    }
                  }
label_42:
                  return;
                }
                goto case 1;
              }
              finally
              {
                if (dataReader != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        DbPreUpdater.Si324IW899daRPSvoG8Z((object) dataReader);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_49;
                    }
                  }
                }
label_49:;
              }
            case 4:
              goto label_47;
            case 5:
              if (this.forLicenseCheck)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 6:
              serverTimeZoneData = (string) DbPreUpdater.jUgqMGWZODJkOJFG2kSe((object) this.transform);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 7:
              goto label_6;
            case 8:
              try
              {
                this.transform.Insert((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(--1360331293 ^ 1360311355), new string[3]
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195581877),
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413538701),
                  (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(2008901894 << 3 ^ -1108672924)
                }, new object[3]
                {
                  (object) 1,
                  (object) this.configurationUid,
                  (object) serverTimeZoneData
                });
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_3;
                    default:
                      DbPreUpdater.Gx7IQPW8MddjeXObG6UK((object) this.transform);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch (Exception ex)
              {
                int num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                  num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      DbPreUpdater.SwVO9wW8JQNnmdbHuW7w((object) this.transform);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
label_16:
                throw new InitializationException((string) DbPreUpdater.xXdaXXWZW9Tj0HapouU1(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(--1418440330 ^ 1418336688)), ex);
              }
            default:
              goto label_4;
          }
        }
label_4:
        this.transform.BeginTransaction();
        num1 = 8;
        continue;
label_7:
        dataReader = this.transform.ExecuteQuery((string) DbPreUpdater.UQi4wIWZXEYxs9U4uOhm(DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1051276242 - 990076387 ^ 61105013), (object) ((Dialect) DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.transform)).QuoteIfNeeded((string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1581325282 << 3 ^ -234264266)), DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.transform), DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(-710283084 ^ -537863435 ^ 173648671))), (Dictionary<string, object>) null);
        num1 = 3;
      }
label_47:
      return;
label_6:;
    }

    /// <summary>Загрузить опубликованные элементы метаданных</summary>
    /// <returns>Элементы метаданных</returns>
    internal IEnumerable<IMetadataItem> LoadMetadataItems()
    {
      if (!this.Transform.TableExists(DbPreUpdater.EntityMetadataHelper<IMetadataItemHeader>.TableName))
        return Enumerable.Empty<IMetadataItem>();
      List<IMetadataItem> metadataItemList = new List<IMetadataItem>();
      bool flag = this.Transform.ColumnExists(this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.TableName), this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName<ScriptModule>((Expression<System.Func<IMetadataItem, ScriptModule>>) (metadataItem => metadataItem.ClientScriptModule))));
      string str1 = this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107933818));
      string str2 = str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281840004) + this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName<long>((Expression<System.Func<IMetadataItem, long>>) (metadataItem => metadataItem.Id)));
      string str3 = str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874005649) + this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName<object>((Expression<System.Func<IMetadataItem, object>>) (metadataItem => metadataItem.Metadata)));
      string str4 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<long>((Expression<System.Func<ScriptModule, long>>) (scriptModule => scriptModule.Id)));
      string str5 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<Guid>((Expression<System.Func<ScriptModule, Guid>>) (scriptModule => scriptModule.Uid)));
      string str6 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.AssemblyName)));
      string str7 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<byte[]>((Expression<System.Func<ScriptModule, byte[]>>) (scriptModule => scriptModule.AssemblyRaw)));
      string str8 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.ClassName)));
      string str9 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<RootCodeItemCollection>((Expression<System.Func<ScriptModule, RootCodeItemCollection>>) (scriptModule => scriptModule.CodeItems)));
      string str10 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.CompiledFileName)));
      string str11 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<byte[]>((Expression<System.Func<ScriptModule, byte[]>>) (scriptModule => scriptModule.DebugRaw)));
      string str12 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.ModuleName)));
      string str13 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<Guid>((Expression<System.Func<ScriptModule, Guid>>) (scriptModule => scriptModule.ModuleTypeUid)));
      string str14 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.Namespace)));
      string str15 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<Guid>((Expression<System.Func<ScriptModule, Guid>>) (scriptModule => scriptModule.ObjectUid)));
      string str16 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.References)));
      string str17 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.ElmaReferences)));
      string str18 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<AssemblyReference>>((Expression<System.Func<ScriptModule, List<AssemblyReference>>>) (scriptModule => scriptModule.LocalReferences)));
      string str19 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<AssemblyReference>>((Expression<System.Func<ScriptModule, List<AssemblyReference>>>) (scriptModule => scriptModule.GlobalScriptModules)));
      string str20 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<ScriptWebReference>>((Expression<System.Func<ScriptModule, List<ScriptWebReference>>>) (scriptModule => scriptModule.WebReferences)));
      string str21 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.ScriptMetodsList)));
      string str22 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<string>((Expression<System.Func<ScriptModule, string>>) (scriptModule => scriptModule.SourceCode)));
      string str23 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.TableName);
      string str24 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName<ScriptModule>((Expression<System.Func<IMetadataItem, ScriptModule>>) (metadataItem => metadataItem.ScriptModule)));
      string str25 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName<ScriptModule>((Expression<System.Func<IMetadataItem, ScriptModule>>) (metadataItem => metadataItem.ClientScriptModule)));
      string str26 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItemHeader>.TableName);
      string str27 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<IMetadataItemHeader>.GetPropertyFieldName<IMetadataItem>((Expression<System.Func<IMetadataItemHeader, IMetadataItem>>) (metadataItemHeader => metadataItemHeader.Published)));
      string str28 = this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210688905));
      string str29 = this.Transform.Dialect.QuoteIfNeeded(DbPreUpdater.EntityMetadataHelper<ScriptModule>.TableName);
      string str30 = this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178319072));
      string alias1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323109834);
      string str31 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979218577));
      string str32 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112693500));
      string str33 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98000890));
      string str34 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767700229));
      string str35 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583698186));
      string str36 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405812307));
      string str37 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669304757));
      string str38 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439504684));
      string str39 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398634166));
      string str40 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606697138));
      string str41 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281875724));
      string str42 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3367830));
      string str43 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 648013644));
      string str44 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740364982));
      string str45 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822859610));
      string str46 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44915613));
      string str47 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236163269));
      string str48 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541824345));
      string str49 = this.Transform.Dialect.QuoteIfNeeded(alias1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979406072));
      string str50 = this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137416022));
      string alias2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867155943);
      string str51 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012040039) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97969068) + str3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317689986) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411202199) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461643963) + str31 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178207038) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283378719) + str5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082384442) + str32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293685478) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77692619) + str6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772197) + str33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751177246) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35988713) + str7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322822) + str34 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283486069) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786880880) + str8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909163075) + str35 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470443356) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239572814) + str9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979467420) + str36 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312866501) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461631325) + str10 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869117) + str37 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97998344) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345417984) + str11 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542707521) + str38 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374450) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767726273) + str12 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239560872) + str39 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669372393) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993440205) + str13 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917275048) + str40 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825481384) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293681696) + str14 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541746517) + str41 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597011124) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951512286) + str15 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459576317) + str42 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44887935) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411202199) + str16 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108672238) + str43 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751215538) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712478067) + str17 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771131) + str44 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812026804) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993440205) + str18 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993452587) + str45 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021409143) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408899594) + str19 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771131) + str46 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459531121) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306447968) + str21 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3314376) + str47 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629843680) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372760301) + str22 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822904518) + str48 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672194282) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121154767) + str20 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576131450) + str49;
      if (flag)
      {
        string str52 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479466730));
        string str53 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306475830));
        string str54 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217420951));
        string str55 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195651563));
        string str56 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470405468));
        string str57 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113950747));
        string str58 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516942628));
        string str59 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133014565));
        string str60 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488771107));
        string str61 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218861848));
        string str62 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178306928));
        string str63 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397178024));
        string str64 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874112723));
        string str65 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909200383));
        string str66 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643751609));
        string str67 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77651183));
        string str68 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272519295));
        string str69 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978439204));
        string str70 = this.Transform.Dialect.QuoteIfNeeded(alias2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712388337));
        str51 = str51 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426178409) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822884644) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629859328) + str52 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426093253) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744) + str5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979467420) + str53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574263890) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629846042) + str6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536785224) + str54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138955782) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939380152) + str7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108672238) + str55 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405812709) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536797870) + str8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869117) + str56 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767721479) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786880880) + str9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322822) + str57 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413563421) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360337113) + str10 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124624300) + str58 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082429622) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669369647) + str11 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520808) + str59 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882123424) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074) + str12 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317775886) + str60 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539366989) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516835790) + str13 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236085485) + str61 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561048374) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173617285) + str14 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939391570) + str62 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574263890) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901799103) + str15 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712498837) + str63 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845574) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669215071) + str16 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491683) + str64 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392586) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757130746) + str17 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461643963) + str65 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70041054) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178211832) + str18 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099765643) + str66 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957821374) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + str19 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281860710) + str67 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021362907) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744) + str21 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309653858) + str68 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439611956) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121154767) + str22 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841368722) + str69 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021409143) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767726273) + str20 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647894760) + str70;
      }
      string sql = str51 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108676216) + str23 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813618931) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876150939) + str26 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751162174) + str28 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501376097) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521160484) + str28 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536797870) + str27 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319434696) + str29 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413548349) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77651431) + str30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672199724) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234259572) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16759773) + str24;
      if (flag)
        sql = sql + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951537646) + str29 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538537676) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413650935) + str50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283378719) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413651587) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979244811) + str25;
      using (IDataReader dataReader = this.Transform.ExecuteQuery(sql, (Dictionary<string, object>) null))
      {
        DbPreUpdater.ScriptModuleReader scriptModuleReader = new DbPreUpdater.ScriptModuleReader();
        while (dataReader.Read())
          metadataItemList.Add((IMetadataItem) new DbPreUpdater.MetadataItem()
          {
            Id = Convert.ToInt64(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541764905)]),
            Metadata = (object) (EleWise.ELMA.Model.Metadata.AbstractMetadata) this.xmlObjSerType.NullSafeGet((DbDataReader) dataReader, new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812003700)
            }, (ISessionImplementor) null, (object) null),
            ScriptModule = scriptModuleReader.Read(this, dataReader, alias1),
            ClientScriptModule = (flag ? scriptModuleReader.Read(this, dataReader, alias2) : (ScriptModule) null)
          });
      }
      return (IEnumerable<IMetadataItem>) metadataItemList;
    }

    private ScriptModule LoadScriptModule(Guid uid)
    {
      int num1 = 2;
      IDataReader reader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            ITransformationProvider transform = this.Transform;
            object obj1 = DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(1178210108 ^ 1178318124);
            string str = this.Transform.Dialect.QuoteIfNeeded((string) DbPreUpdater.kTEZDSWZ2bwmnxO02GtY());
            object obj2 = DbPreUpdater.aMPvkdW8Uc94lb5riaQU((object) this.Transform);
            // ISSUE: type reference
            ParameterExpression parameterExpression = Expression.Parameter(DbPreUpdater.fITe1pWZePWSDAED0soO(__typeref (ScriptModule)), (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(~1767720452 ^ -1767701603));
            // ISSUE: method reference
            string propertyFieldName = DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<Guid>(Expression.Lambda<System.Func<ScriptModule, Guid>>((Expression) DbPreUpdater.yLHMOMWZ12SJng4p64K4((object) parameterExpression, (object) (MethodInfo) DbPreUpdater.x52yJyWZPmfocl51QgDM(__methodref (ScriptModule.get_Uid))), parameterExpression));
            object obj3 = DbPreUpdater.QFlPFDW8sFBO8eZhF0Bo(obj2, (object) propertyFieldName);
            string parameterSeparator = this.Transform.ParameterSeparator;
            object sql = DbPreUpdater.pRMkoQWZNJAStYb6enLt(obj1, (object) str, obj3, (object) parameterSeparator);
            reader = transform.ExecuteQuery((string) sql, new Dictionary<string, object>()
            {
              {
                (string) DbPreUpdater.iwFuCyW8HqE3MaLgs2fW(993438473 ^ 993464677),
                (object) uid
              }
            });
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
            continue;
          default:
            goto label_13;
        }
      }
label_2:
      ScriptModule scriptModule;
      try
      {
        int num2;
        if (!DbPreUpdater.uIf3x6W8zmoPMZGFkXfa((object) reader))
          num2 = 2;
        else
          goto label_5;
label_4:
        switch (num2)
        {
          case 1:
            break;
          case 3:
            goto label_14;
          default:
            goto label_13;
        }
label_5:
        scriptModule = new DbPreUpdater.ScriptModuleReader().Read(this, reader, "");
        num2 = 3;
        goto label_4;
      }
      finally
      {
        if (reader != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_11;
              default:
                DbPreUpdater.Si324IW899daRPSvoG8Z((object) reader);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_11:;
      }
label_14:
      return scriptModule;
label_13:
      return (ScriptModule) null;
    }

    /// <summary>Имеется ли подготовленная модель конфигурации</summary>
    private IList<AssemblyModelsMetadataStatus> GetModelConfigurationStatuses()
    {
      string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281881032), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957779302)), (object) this.Transform.ParameterSeparator, (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281879320)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289681428)), (object) this.Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475890265)));
      Dictionary<string, object> paramValues = new Dictionary<string, object>()
      {
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542701107),
          (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088)
        }
      };
      List<AssemblyModelsMetadataStatus> configurationStatuses = new List<AssemblyModelsMetadataStatus>();
      using (IDataReader dataReader = this.Transform.ExecuteQuery(sql, paramValues))
      {
        while (dataReader.Read())
          configurationStatuses.Add((AssemblyModelsMetadataStatus) Convert.ToInt32(dataReader[0]));
      }
      return (IList<AssemblyModelsMetadataStatus>) configurationStatuses;
    }

    internal static void aevHXWW86ph861HmEOTP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object iwFuCyW8HqE3MaLgs2fW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ImkeT9W8ASqT0oqM4uyb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool JnpU1cW8wtQh2tAvPJCV() => DbPreUpdater.jGk8IWW8tPAq0EJH7CW6 == null;

    internal static DbPreUpdater qLierEW847pTg1T0m5LI() => DbPreUpdater.jGk8IWW8tPAq0EJH7CW6;

    internal static object jrUOQhW87XvhKq8xiWcO([In] object obj0) => (object) ApplicationStartCache.Load((ITransformationProvider) obj0);

    internal static object suPfR4W8xUyaN4MydJQh([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object Ty81mOW805BRhFyFA4Ci(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static object g96rFSW8mhCWlGtakJ60([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static void tUDIjeW8yN7x3pP8fhLo([In] object obj0) => ((ITransformationProvider) obj0).BeginTransaction();

    internal static void Gx7IQPW8MddjeXObG6UK([In] object obj0) => ((ITransformationProviderBase) obj0).CommitTransaction();

    internal static void SwVO9wW8JQNnmdbHuW7w([In] object obj0) => ((ITransformationProvider) obj0).RollbackTransaction();

    internal static void Si324IW899daRPSvoG8Z([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void noyWtOW8d6ojcnfZSGx2([In] object obj0) => Monitor.Exit(obj0);

    internal static bool zOG0gyW8lNYgfxgquTpm([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void YmO9FYW8rrece5TlckWN([In] object obj0, bool value) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Sequence = value;

    internal static void yKIaKJW8g7mismHyIbLN([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name = (string) obj1;

    internal static void xZVBfWW85iZWwuMsmLIf([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj1);

    internal static object lb7TleW8jbo2SYpnhIyM([In] object obj0) => (object) ((Column) obj0).Name;

    internal static bool iuabpAW8YFXasruMAaOc([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ColumnExists((string) obj1, (string) obj2);

    internal static void k9aU2nW8LZC6Kee0lLbp([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).AddColumn((string) obj1, (Column) obj2);

    internal static object aMPvkdW8Uc94lb5riaQU([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object QFlPFDW8sFBO8eZhF0Bo([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object ELtx6oW8cdPO0PXgbxSY([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool uIf3x6W8zmoPMZGFkXfa([In] object obj0) => ((IDataReader) obj0).Read();

    internal static object WSxfrUWZF64N0Xup0NWn([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static short QG244LWZB25dUs32Oscj([In] object obj0) => Convert.ToInt16(obj0);

    internal static object xXdaXXWZW9Tj0HapouU1([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static BackupParameters g1joUOWZoDIZZb5rOLkc() => BackupParameters.OnlyMainDatabase;

    internal static int w4C35IWZbnjmbeoQ1j1r([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3);

    internal static void yyMLbsWZhKTGHhvIkGY9([In] object obj0, int version) => DbMetadata.CreateStructures((ITransformationProvider) obj0, version);

    internal static void v8QQACWZGmm2hsodlekT([In] object obj0, int version) => ApplicationStartCache.CreateDbStructures((ITransformationProvider) obj0, version);

    internal static void cc2AIDWZEXij4MUocEdn([In] object obj0, [In] object obj1, int version) => ((BackupManager) obj0).CreateDbStructures((ITransformationProvider) obj1, version);

    internal static void rsdanhWZfgB2SmlV3J2R([In] object obj0, int version) => ModuleManager.CreateDbStructures((ITransformationProvider) obj0, version);

    internal static object rhX1xaWZQXqD7lpfGYLU([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static AssemblyModelsMetadataStatus kUBdHNWZC5143WbtYD4a([In] object obj0) => ((AssemblyModelsMetadata) obj0).Status;

    internal static object TFWIF3WZvJsyHByalrUD([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DocumentationRawStream;

    internal static object FI047GWZ8EMweiSiSZbV([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DebugRawStream;

    internal static long UWL7EqWZZKeONMDQ1dbs([In] object obj0) => ((AssemblyModelsMetadata) obj0).Id;

    internal static object zTE5i8WZuEquVqesUmMQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static object FoEeTYWZIjAGsxhSUhuV([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object e3GYhMWZVROXjnXmtF0G([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void YM9A7lWZSys0QpCuZDKE([In] object obj0) => ((DbPreUpdater) obj0).CreateStructures();

    internal static void XuEbntWZiWaPObecWaHU([In] object obj0) => ((ITransformationProvider) obj0).InitTableGenerators();

    internal static void YUHSZBWZR5sl2SlTlhuY([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static void PcwPwJWZqqG5tcBrl3WI([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static void s698xMWZKTkCnCqT9U1y([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddUniqueIndex((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj1);

    internal static object UQi4wIWZXEYxs9U4uOhm([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object zkQpAUWZTdEjpSf5hKxs([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void QIVAl3WZkW2faECCmEoY([In] object obj0) => TZ.InitializeServerTimeZone((string) obj0);

    internal static Guid ja1Lc8WZnaeLYpce1jo6() => Guid.NewGuid();

    internal static object jUgqMGWZODJkOJFG2kSe([In] object obj0) => (object) TZ.GetServerTimeZoneForSystemConfig((ITransformationProvider) obj0);

    internal static object kTEZDSWZ2bwmnxO02GtY() => (object) DbPreUpdater.EntityMetadataHelper<ScriptModule>.TableName;

    internal static Type fITe1pWZePWSDAED0soO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object x52yJyWZPmfocl51QgDM([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object yLHMOMWZ12SJng4p64K4([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object pRMkoQWZNJAStYb6enLt(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    private static class DbPreUpdate
    {
      public static class Fields
      {
        /// <summary>Версия</summary>
        public const string Version = "Ver";
        /// <summary>Признак начала преобразования БД</summary>
        public const string Updating = "Updating";
        /// <summary>
        /// Признак необходимости перекомпилировать ConfigurationModel
        /// </summary>
        public const string NeedRecompileCfgModel = "NeedRecompileCfgModel";
      }
    }

    private static class DbConfigurationInfo
    {
      public static class Fields
      {
        /// <summary>Id для обеспечения уникальности записи</summary>
        public const string Id = "Id";
        /// <summary>Версия</summary>
        public const string Uid = "Uid";
        /// <summary>Часовой пояс сервера</summary>
        public const string ServerTimeZone = "ServerTimeZone";
      }
    }

    private static class DbActivatedModule
    {
      public static class Fields
      {
        /// <summary>Имя модуля</summary>
        public const string ModuleName = "ModuleName";
      }
    }

    private static class DbDeactivatingModule
    {
      public static class Fields
      {
        /// <summary>Имя модуля</summary>
        public const string ModuleName = "ModuleName";
      }
    }

    private static class EntityMetadataHelper<T>
    {
      private static EntityMetadata metadata;
      private static Dictionary<string, PropertyMetadata> props;
      private static object g2kJ6qQpQB1v5DPCGvYs;

      static EntityMetadataHelper()
      {
        int num1 = 2;
        List<PropertyMetadata>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              DbPreUpdater.EntityMetadataHelper<T>.props = new Dictionary<string, PropertyMetadata>();
              num1 = 3;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              continue;
            case 3:
              DbPreUpdater.EntityMetadataHelper<T>.metadata = new EntityMetadata();
              num1 = 6;
              continue;
            case 4:
              enumerator = DbPreUpdater.EntityMetadataHelper<T>.metadata.Properties.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_18;
            case 6:
              DbPreUpdater.EntityMetadataHelper<T>.metadata.LoadFromType(typeof (T), true);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 2;
              continue;
            default:
              goto label_5;
          }
        }
label_18:
        return;
label_5:
        try
        {
label_11:
          if (enumerator.MoveNext())
            goto label_9;
          else
            goto label_12;
label_7:
          PropertyMetadata current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_14;
              case 1:
                goto label_9;
              case 2:
                DbPreUpdater.EntityMetadataHelper<T>.props[current.Name] = current;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 3;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_8;
            }
          }
label_14:
          return;
label_8:
          return;
label_9:
          current = enumerator.Current;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
          {
            num2 = 2;
            goto label_7;
          }
          else
            goto label_7;
label_12:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
          goto label_7;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }

      public static string TableName => DbPreUpdater.EntityMetadataHelper<T>.metadata.TableName;

      public static string GetPropertyFieldName<TResult>(Expression<System.Func<T, TResult>> propAccessor)
      {
        if (!(propAccessor.Body is MemberExpression body))
          throw new InvalidOperationException(propAccessor.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889284916));
        if (body.Member.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146542979))
          return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461592775);
        PropertyMetadata propertyMetadata;
        if (!DbPreUpdater.EntityMetadataHelper<T>.props.TryGetValue(body.Member.Name, out propertyMetadata))
          throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889284990), (object) body.Member.Name, (object) typeof (T).FullName));
        return ((SimpleTypeSettings) propertyMetadata.Settings).FieldName;
      }

      internal static bool I11KC1QpCgOifl2J2KZM() => DbPreUpdater.EntityMetadataHelper<T>.g2kJ6qQpQB1v5DPCGvYs == null;

      internal static object u3LfOLQpvRSHs3GoO8uv() => DbPreUpdater.EntityMetadataHelper<T>.g2kJ6qQpQB1v5DPCGvYs;
    }

    /// <summary>
    /// Stub для <see cref="T:EleWise.ELMA.Model.Metadata.IMetadataItem" />
    /// </summary>
    private sealed class MetadataItem : IMetadataItem, IEntity<long>, IEntity, IIdentified
    {
      internal static object rUrIBaQp8mDCEF54Bfrc;

      /// <inheritdoc />
      public object GetId() => throw new NotImplementedException();

      /// <inheritdoc />
      public void SetId(object id) => throw new NotImplementedException();

      /// <inheritdoc />
      public string ToString(string format) => throw new NotImplementedException();

      /// <inheritdoc />
      public object GetPropertyValue(Guid propertyUid) => throw new NotImplementedException();

      /// <inheritdoc />
      public T GetPropertyValue<T>(Guid propertyUid) => throw new NotImplementedException();

      /// <inheritdoc />
      public void SetPropertyValue(Guid propertyUid, object value) => throw new NotImplementedException();

      /// <inheritdoc />
      public TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings => throw new NotImplementedException();

      /// <inheritdoc />
      public TypeSettings GetPropertySettings(Guid propertyUid) => throw new NotImplementedException();

      /// <inheritdoc />
      public TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings) => throw new NotImplementedException();

      /// <inheritdoc />
      public TypeSettings LoadPropertyInstanceSettings(Guid propertyUid) => throw new NotImplementedException();

      /// <inheritdoc />
      public void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings) => throw new NotImplementedException();

      /// <inheritdoc />
      public ITypeSettingsInstanceStore LoadSettingsInstanceStore(
        bool createIfNotExists,
        bool loadIfNotLoaded)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public IEnumerable<IEntity> GetContainedEntities() => throw new NotImplementedException();

      /// <inheritdoc />
      public IEntity GetRootEntity() => throw new NotImplementedException();

      /// <inheritdoc />
      public void Save() => throw new NotImplementedException();

      /// <inheritdoc />
      public void Delete() => throw new NotImplementedException();

      /// <inheritdoc />
      public void Refresh() => throw new NotImplementedException();

      /// <inheritdoc />
      public bool IsNew() => throw new NotImplementedException();

      /// <inheritdoc />
      public bool IsDirty() => throw new NotImplementedException();

      /// <inheritdoc />
      public Guid[] GetDirtyPropertyUids() => throw new NotImplementedException();

      /// <inheritdoc />
      public long Id
      {
        get => this.\u003CId\u003Ek__BackingField;
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
                this.\u003CId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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

      /// <inheritdoc />
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

      /// <inheritdoc />
      public DateTime CreationDate
      {
        get => this.\u003CCreationDate\u003Ek__BackingField;
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
                this.\u003CCreationDate\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

      /// <inheritdoc />
      public object Metadata
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

      /// <inheritdoc />
      public IMetadataItemHeader Header
      {
        get => this.\u003CHeader\u003Ek__BackingField;
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
                this.\u003CHeader\u003Ek__BackingField = value;
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

      /// <inheritdoc />
      public string Comment
      {
        get => this.\u003CComment\u003Ek__BackingField;
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
                this.\u003CComment\u003Ek__BackingField = value;
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

      /// <inheritdoc />
      public long? CreationAuthorId { get; set; }

      /// <inheritdoc />
      public ScriptModule ScriptModule
      {
        get => this.\u003CScriptModule\u003Ek__BackingField;
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
                this.\u003CScriptModule\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

      /// <inheritdoc />
      public ScriptModule ClientScriptModule
      {
        get => this.\u003CClientScriptModule\u003Ek__BackingField;
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
                this.\u003CClientScriptModule\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

      /// <inheritdoc />
      public object Dependencies
      {
        get => this.\u003CDependencies\u003Ek__BackingField;
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
                this.\u003CDependencies\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

      public MetadataItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool kBosc6QpZQ4WCaMZ5Kat() => DbPreUpdater.MetadataItem.rUrIBaQp8mDCEF54Bfrc == null;

      internal static DbPreUpdater.MetadataItem WTwEH6Qput92inrB9HUN() => (DbPreUpdater.MetadataItem) DbPreUpdater.MetadataItem.rUrIBaQp8mDCEF54Bfrc;
    }

    private class ScriptModuleReader
    {
      private object u;
      private object reader;
      private object alias;
      private static object codeItemsType;
      private static object asmRefsType;
      private static object webRefsType;
      private static Dictionary<string, bool> checkedColumnsExisting;
      internal static object YysnPQQpIuDK8QN4tehp;

      /// <summary>Прочитать модуль сценариев</summary>
      /// <param name="u">Вспомогательный класс для работы с БД</param>
      /// <param name="reader">Читатель БД</param>
      /// <param name="alias">Псевдоним</param>
      /// <returns>Модуль сценаририев</returns>
      public ScriptModule Read(DbPreUpdater u, IDataReader reader, string alias)
      {
        int num1 = 2;
        ScriptModule scriptModule1;
        while (true)
        {
          int num2 = num1;
          long num3;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.reader = (object) reader;
                num2 = 5;
                continue;
              case 2:
                this.u = (object) u;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                continue;
              case 3:
                ScriptModule scriptModule2 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression1 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (string) DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1514961705 ^ 1515045199));
                // ISSUE: method reference
                Guid guid1 = this.ReadGuid<Guid>(Expression.Lambda<System.Func<ScriptModule, Guid>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression1, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_ObjectUid))), parameterExpression1));
                DbPreUpdater.ScriptModuleReader.y7UfyfQp3oCC2kvBSJxU((object) scriptModule2, guid1);
                num2 = 24;
                continue;
              case 4:
              case 6:
                ScriptModule scriptModule3 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression2 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(372753449 ^ 372670031));
                // ISSUE: method reference
                string str1 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression2, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_CompiledFileName))), parameterExpression2));
                DbPreUpdater.ScriptModuleReader.QMV1kvQpeSSqfkPclyeK((object) scriptModule3, (object) str1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 8;
                continue;
              case 5:
                this.alias = (object) alias;
                num2 = 10;
                continue;
              case 7:
                ScriptModule scriptModule4 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression3 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3367300));
                // ISSUE: method reference
                string str2 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_Namespace))), parameterExpression3));
                scriptModule4.Namespace = str2;
                num2 = 3;
                continue;
              case 8:
                ScriptModule scriptModule5 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression4 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1149433385 + 173655049 ^ 1323106388));
                // ISSUE: method reference
                byte[] numArray1 = (byte[]) this.SafeRead<byte[]>(Expression.Lambda<System.Func<ScriptModule, byte[]>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression4, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_DebugRaw))), parameterExpression4));
                DbPreUpdater.ScriptModuleReader.tL4hYYQpPSGLNgStE4BV((object) scriptModule5, (object) numArray1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 20 : 23;
                continue;
              case 9:
                // ISSUE: type reference
                ParameterExpression parameterExpression5 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(-1998538950 ^ -1998516900));
                // ISSUE: method reference
                if (!this.ColumnExists<RootCodeItemCollection>(Expression.Lambda<System.Func<ScriptModule, RootCodeItemCollection>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression5, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_CodeItems))), parameterExpression5)))
                {
                  num2 = 4;
                  continue;
                }
                goto label_7;
              case 10:
                // ISSUE: type reference
                ParameterExpression parameterExpression6 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1178210108 ^ 1178318170));
                // ISSUE: method reference
                // ISSUE: type reference
                num3 = this.ReadInt64<long>(Expression.Lambda<System.Func<ScriptModule, long>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity<long>.get_Id), __typeref (Entity<long>))), parameterExpression6));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 5 : 12;
                continue;
              case 11:
                ScriptModule scriptModule6 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression7 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099647183));
                // ISSUE: method reference
                Guid guid2 = this.ReadGuid<Guid>(Expression.Lambda<System.Func<ScriptModule, Guid>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression7, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_ModuleTypeUid))), parameterExpression7));
                DbPreUpdater.ScriptModuleReader.NL37DTQpN8Jk0rZpyFhZ((object) scriptModule6, guid2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 7;
                continue;
              case 12:
                if (num3 == 0L)
                {
                  num2 = 20;
                  continue;
                }
                goto label_4;
              case 13:
                goto label_7;
              case 14:
                ScriptModule scriptModule7 = scriptModule1;
                object webRefsType = DbPreUpdater.ScriptModuleReader.webRefsType;
                DbDataReader dbDataReader1 = (DbDataReader) reader;
                string[] strArray1 = new string[1];
                string str3 = alias;
                ParameterExpression parameterExpression8 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(typeof (ScriptModule), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1304605005 ^ 1304628011));
                // ISSUE: method reference
                string propertyFieldName1 = DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<ScriptWebReference>>(Expression.Lambda<System.Func<ScriptModule, List<ScriptWebReference>>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression8, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_WebReferences))), parameterExpression8));
                strArray1[0] = (string) DbPreUpdater.ScriptModuleReader.sUJhejQpDSO6HrmAwrPy((object) str3, (object) propertyFieldName1);
                List<ScriptWebReference> scriptWebReferenceList = (List<ScriptWebReference>) DbPreUpdater.ScriptModuleReader.UFZpbMQp6IBBJ1HxiOmC(webRefsType, (object) dbDataReader1, (object) strArray1, (object) null, (object) null);
                scriptModule7.WebReferences = scriptWebReferenceList;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              case 15:
                scriptModule1.Id = num3;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 20 : 26;
                continue;
              case 16:
                ScriptModule scriptModule8 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression9 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (string) DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(-2099751081 ^ -2099647183));
                // ISSUE: method reference
                string str4 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression9, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_ClassName))), parameterExpression9));
                DbPreUpdater.ScriptModuleReader.N7bqnAQpOhxqGpcEJYaP((object) scriptModule8, (object) str4);
                num2 = 9;
                continue;
              case 17:
                ScriptModule scriptModule9 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression10 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154052787));
                // ISSUE: method reference
                string str5 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_ElmaReferences))), parameterExpression10));
                DbPreUpdater.ScriptModuleReader.R0IcxGQpa1uv99UEPK0V((object) scriptModule9, (object) str5);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 27 : 15;
                continue;
              case 18:
                ScriptModule scriptModule10 = scriptModule1;
                object asmRefsType1 = DbPreUpdater.ScriptModuleReader.asmRefsType;
                DbDataReader dbDataReader2 = (DbDataReader) reader;
                string[] strArray2 = new string[1];
                string str6 = alias;
                // ISSUE: type reference
                ParameterExpression parameterExpression11 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (string) DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1199946765 ^ 1199834731));
                // ISSUE: method reference
                string propertyFieldName2 = DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<AssemblyReference>>(Expression.Lambda<System.Func<ScriptModule, List<AssemblyReference>>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression11, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_GlobalScriptModules))), parameterExpression11));
                strArray2[0] = (string) DbPreUpdater.ScriptModuleReader.sUJhejQpDSO6HrmAwrPy((object) str6, (object) propertyFieldName2);
                List<AssemblyReference> assemblyReferenceList1 = (List<AssemblyReference>) DbPreUpdater.ScriptModuleReader.WbP2lEQptXnyclPXFxYq(asmRefsType1, (object) dbDataReader2, (object) strArray2, (object) null, (object) null);
                scriptModule10.GlobalScriptModules = assemblyReferenceList1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 19 : 6;
                continue;
              case 19:
                ParameterExpression parameterExpression12;
                // ISSUE: method reference
                DbPreUpdater.ScriptModuleReader.XakdugQpwfjVV3gMFXoO((object) scriptModule1, (object) this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) Expression.Property((Expression) parameterExpression12, (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_ScriptMetodsList))), parameterExpression12)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 22 : 7;
                continue;
              case 20:
                goto label_3;
              case 21:
                ScriptModule scriptModule11 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression13 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(-1978478350 ^ -1978439020));
                // ISSUE: method reference
                string str7 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression13, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_AssemblyName))), parameterExpression13));
                DbPreUpdater.ScriptModuleReader.iBfNovQpkyMGSkjl85fk((object) scriptModule11, (object) str7);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 25 : 23;
                continue;
              case 22:
                ScriptModule scriptModule12 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression14 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29350139));
                // ISSUE: method reference
                string str8 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression14, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_SourceCode))), parameterExpression14));
                DbPreUpdater.ScriptModuleReader.qKKIYvQp4ksGuRLSehng((object) scriptModule12, (object) str8);
                num2 = 14;
                continue;
              case 23:
                ScriptModule scriptModule13 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression15 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (string) DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(-2092274397 << 4 ^ 883386454));
                // ISSUE: method reference
                string str9 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression15, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_ModuleName))), parameterExpression15));
                DbPreUpdater.ScriptModuleReader.ymbA4kQp1eRe9FdGZK2X((object) scriptModule13, (object) str9);
                num2 = 11;
                continue;
              case 24:
                ScriptModule scriptModule14 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression16 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1574260816 ^ 1574234678));
                // ISSUE: method reference
                string str10 = this.ReadString<string>(Expression.Lambda<System.Func<ScriptModule, string>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression16, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_References))), parameterExpression16));
                DbPreUpdater.ScriptModuleReader.iVUCECQppHHiSBIeFdlh((object) scriptModule14, (object) str10);
                num2 = 17;
                continue;
              case 25:
                ScriptModule scriptModule15 = scriptModule1;
                // ISSUE: type reference
                ParameterExpression parameterExpression17 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1218962250 ^ 1218861356));
                // ISSUE: method reference
                byte[] numArray2 = (byte[]) this.SafeRead<byte[]>(Expression.Lambda<System.Func<ScriptModule, byte[]>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression17, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_AssemblyRaw))), parameterExpression17));
                DbPreUpdater.ScriptModuleReader.gPdJDAQpnSQ0B3tVVWjb((object) scriptModule15, (object) numArray2);
                num2 = 16;
                continue;
              case 26:
                goto label_16;
              case 27:
                ScriptModule scriptModule16 = scriptModule1;
                object asmRefsType2 = DbPreUpdater.ScriptModuleReader.asmRefsType;
                DbDataReader dbDataReader3 = (DbDataReader) reader;
                string[] strArray3 = new string[1];
                string str11 = alias;
                // ISSUE: type reference
                ParameterExpression parameterExpression18 = Expression.Parameter(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (string) DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(-649342099 - -1150814748 ^ 501377007));
                // ISSUE: method reference
                string propertyFieldName3 = DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<List<AssemblyReference>>(Expression.Lambda<System.Func<ScriptModule, List<AssemblyReference>>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression18, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_LocalReferences))), parameterExpression18));
                strArray3[0] = (string) DbPreUpdater.ScriptModuleReader.sUJhejQpDSO6HrmAwrPy((object) str11, (object) propertyFieldName3);
                List<AssemblyReference> assemblyReferenceList2 = (List<AssemblyReference>) DbPreUpdater.ScriptModuleReader.WbP2lEQptXnyclPXFxYq(asmRefsType2, (object) dbDataReader3, (object) strArray3, (object) null, (object) null);
                scriptModule16.LocalReferences = assemblyReferenceList2;
                num2 = 18;
                continue;
              default:
                goto label_23;
            }
          }
label_4:
          scriptModule1 = new ScriptModule();
          num1 = 15;
          continue;
label_7:
          ScriptModule scriptModule17 = scriptModule1;
          object codeItemsType = DbPreUpdater.ScriptModuleReader.codeItemsType;
          DbDataReader rs = (DbDataReader) reader;
          string[] names = new string[1];
          string str12 = alias;
          ParameterExpression parameterExpression19 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(typeof (ScriptModule), DbPreUpdater.ScriptModuleReader.Fi2UWxQpRVKCN5NqCav8(1917256330 ^ 1917237484));
          // ISSUE: method reference
          string propertyFieldName4 = DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<RootCodeItemCollection>(Expression.Lambda<System.Func<ScriptModule, RootCodeItemCollection>>((Expression) DbPreUpdater.ScriptModuleReader.XFAnclQpTMgeLDdS5ADd((object) parameterExpression19, (object) (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_CodeItems))), parameterExpression19));
          names[0] = str12 + propertyFieldName4;
          RootCodeItemCollection codeItemCollection = (RootCodeItemCollection) ((XmlSerializableType<RootCodeItemCollection>) codeItemsType).NullSafeGet(rs, names, (ISessionImplementor) null, (object) null);
          DbPreUpdater.ScriptModuleReader.e6i7c3Qp2FoPXSRi7rZg((object) scriptModule17, (object) codeItemCollection);
          num1 = 6;
          continue;
label_16:
          ScriptModule scriptModule18 = scriptModule1;
          // ISSUE: type reference
          ParameterExpression parameterExpression20 = (ParameterExpression) DbPreUpdater.ScriptModuleReader.pX1m34QpqW6qg7vagVP1(DbPreUpdater.ScriptModuleReader.oudkoeQpiiMT4csjieYL(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218383416));
          // ISSUE: method reference
          Guid guid3 = this.ReadGuid<Guid>(Expression.Lambda<System.Func<ScriptModule, Guid>>((Expression) Expression.Property((Expression) parameterExpression20, (MethodInfo) DbPreUpdater.ScriptModuleReader.E4KpoUQpKp1A2TchFi5t(__methodref (ScriptModule.get_Uid))), parameterExpression20));
          DbPreUpdater.ScriptModuleReader.LZcBVTQpXGEKP3Bko2Z6((object) scriptModule18, guid3);
          num1 = 21;
        }
label_3:
        return (ScriptModule) null;
label_23:
        return scriptModule1;
      }

      public bool ColumnExists<TPropResult>(
        Expression<System.Func<ScriptModule, TPropResult>> propAccessor)
      {
        return this.ColumnExists(DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<TPropResult>(propAccessor));
      }

      public bool ColumnExists(string columnName)
      {
        int num = 5;
        bool flag;
        while (true)
        {
          int i;
          switch (num)
          {
            case 1:
              ++i;
              num = 10;
              continue;
            case 2:
              goto label_8;
            case 3:
            case 7:
              if (DbPreUpdater.ScriptModuleReader.bxibowQpHFRtXJCHKso2((object) ((IDataRecord) this.reader).GetName(i), (object) columnName, StringComparison.CurrentCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 0;
                continue;
              }
              goto case 1;
            case 4:
              goto label_2;
            case 5:
              if (!DbPreUpdater.ScriptModuleReader.checkedColumnsExisting.TryGetValue(columnName, out flag))
              {
                flag = false;
                num = 9;
                continue;
              }
              num = 4;
              continue;
            case 6:
            case 10:
              if (i < DbPreUpdater.ScriptModuleReader.lBOPLQQpATnR39iPiUXk(this.reader))
              {
                num = 3;
                continue;
              }
              break;
            case 8:
              flag = true;
              num = 11;
              continue;
            case 9:
              i = 0;
              num = 6;
              continue;
          }
          DbPreUpdater.ScriptModuleReader.checkedColumnsExisting[columnName] = flag;
          num = 2;
        }
label_2:
        return flag;
label_8:
        return flag;
      }

      private object SafeRead<TPropResult>(
        Expression<System.Func<ScriptModule, TPropResult>> propAccessor)
      {
        object obj = ((IDataRecord) this.reader)[(string) this.alias + DbPreUpdater.EntityMetadataHelper<ScriptModule>.GetPropertyFieldName<TPropResult>(propAccessor)];
        return obj is DBNull ? (object) null : obj;
      }

      private long ReadInt64<TPropResult>(
        Expression<System.Func<ScriptModule, TPropResult>> propAccessor)
      {
        return Convert.ToInt64(this.SafeRead<TPropResult>(propAccessor));
      }

      private Guid ReadGuid<TPropResult>(
        Expression<System.Func<ScriptModule, TPropResult>> propAccessor)
      {
        object obj = this.SafeRead<TPropResult>(propAccessor);
        return obj == null ? Guid.Empty : ((DbPreUpdater) this.u).Transform.Dialect.GetGuid(obj);
      }

      private string ReadString<TPropResult>(
        Expression<System.Func<ScriptModule, TPropResult>> propAccessor)
      {
        return (string) this.SafeRead<TPropResult>(propAccessor);
      }

      public ScriptModuleReader()
      {
        DbPreUpdater.ScriptModuleReader.wYgMTPQp7y14WI6OmoRE();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ScriptModuleReader()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              DbPreUpdater.ScriptModuleReader.wYgMTPQp7y14WI6OmoRE();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              DbPreUpdater.ScriptModuleReader.asmRefsType = (object) new AssemblyReferenceNHType();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 4;
              continue;
            case 4:
              DbPreUpdater.ScriptModuleReader.webRefsType = (object) new ScriptWebReferencesNHType();
              num = 5;
              continue;
            case 5:
              DbPreUpdater.ScriptModuleReader.checkedColumnsExisting = new Dictionary<string, bool>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
              continue;
            default:
              DbPreUpdater.ScriptModuleReader.codeItemsType = (object) new RootCodeItemCollectionNH();
              num = 3;
              continue;
          }
        }
label_2:;
      }

      internal static Type oudkoeQpiiMT4csjieYL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object Fi2UWxQpRVKCN5NqCav8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object pX1m34QpqW6qg7vagVP1([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

      internal static object E4KpoUQpKp1A2TchFi5t([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

      internal static void LZcBVTQpXGEKP3Bko2Z6([In] object obj0, Guid value) => ((ScriptModule) obj0).Uid = value;

      internal static object XFAnclQpTMgeLDdS5ADd([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

      internal static void iBfNovQpkyMGSkjl85fk([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyName = (string) obj1;

      internal static void gPdJDAQpnSQ0B3tVVWjb([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyRaw = (byte[]) obj1;

      internal static void N7bqnAQpOhxqGpcEJYaP([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ClassName = (string) obj1;

      internal static void e6i7c3Qp2FoPXSRi7rZg([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).CodeItems = (RootCodeItemCollection) obj1;

      internal static void QMV1kvQpeSSqfkPclyeK([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).CompiledFileName = (string) obj1;

      internal static void tL4hYYQpPSGLNgStE4BV([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).DebugRaw = (byte[]) obj1;

      internal static void ymbA4kQp1eRe9FdGZK2X([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ModuleName = (string) obj1;

      internal static void NL37DTQpN8Jk0rZpyFhZ([In] object obj0, Guid value) => ((ScriptModule) obj0).ModuleTypeUid = value;

      internal static void y7UfyfQp3oCC2kvBSJxU([In] object obj0, Guid value) => ((ScriptModule) obj0).ObjectUid = value;

      internal static void iVUCECQppHHiSBIeFdlh([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).References = (string) obj1;

      internal static void R0IcxGQpa1uv99UEPK0V([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ElmaReferences = (string) obj1;

      internal static object sUJhejQpDSO6HrmAwrPy([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

      internal static object WbP2lEQptXnyclPXFxYq(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3,
        [In] object obj4)
      {
        return ((XmlSerializableType<List<AssemblyReference>>) obj0).NullSafeGet((DbDataReader) obj1, (string[]) obj2, (ISessionImplementor) obj3, obj4);
      }

      internal static void XakdugQpwfjVV3gMFXoO([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ScriptMetodsList = (string) obj1;

      internal static void qKKIYvQp4ksGuRLSehng([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).SourceCode = (string) obj1;

      internal static object UFZpbMQp6IBBJ1HxiOmC(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3,
        [In] object obj4)
      {
        return ((XmlSerializableType<List<ScriptWebReference>>) obj0).NullSafeGet((DbDataReader) obj1, (string[]) obj2, (ISessionImplementor) obj3, obj4);
      }

      internal static bool NqJAOOQpVY2yhhj49Vxw() => DbPreUpdater.ScriptModuleReader.YysnPQQpIuDK8QN4tehp == null;

      internal static DbPreUpdater.ScriptModuleReader fhfm2oQpS9cmknjcwl5I() => (DbPreUpdater.ScriptModuleReader) DbPreUpdater.ScriptModuleReader.YysnPQQpIuDK8QN4tehp;

      internal static bool bxibowQpHFRtXJCHKso2([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

      internal static int lBOPLQQpATnR39iPiUXk([In] object obj0) => ((IDataRecord) obj0).FieldCount;

      internal static void wYgMTPQp7y14WI6OmoRE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

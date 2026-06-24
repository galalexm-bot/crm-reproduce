// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.BpmAppService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class BpmAppService : IBpmAppService
  {
    private readonly IModuleDTOManager moduleDtoManager;
    private readonly IEnumerable<IBPMAppItemsConverter> converters;
    private readonly BPMAppManager manager;
    private readonly ICacheFilesService cacheFilesService;
    /// <summary>
    /// Словарь из пар ключ (BpmAppId + хэш от файла) - значение (Guid файла в кэше)
    /// </summary>
    private Dictionary<string, Guid> filesKeys;
    private static BpmAppService JeSf9afOBSRyHuDrjRfX;

    /// <summary>Ctor</summary>
    /// <param name="moduleDtoManager">Работа с компонентами ElmaStore в дизайнере</param>
    /// <param name="converters">Конвертеры настроек экспорта</param>
    /// <param name="manager">Менеджер бпмапп</param>
    /// <param name="cacheFilesService">Сервис для работы с временными файлами</param>
    public BpmAppService(
      IModuleDTOManager moduleDtoManager,
      IEnumerable<IBPMAppItemsConverter> converters,
      BPMAppManager manager,
      ICacheFilesService cacheFilesService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.filesKeys = new Dictionary<string, Guid>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.moduleDtoManager = moduleDtoManager;
      this.converters = converters;
      this.manager = manager;
      this.cacheFilesService = cacheFilesService;
    }

    /// <inheritdoc />
    public IEnumerable<BPMAppDTO> LoadAll() => (IEnumerable<BPMAppDTO>) this.manager.FindAll().Select<IBPMApp, BPMAppDTO>((Func<IBPMApp, BPMAppDTO>) (e => Mapper.Map<IBPMApp, BPMAppDTO>(e))).ToList<BPMAppDTO>();

    /// <inheritdoc />
    public BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent)
    {
      int num1 = 1;
      IBPMApp source;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              BpmAppService.OtqV1EfOhKh5vGxOrWx0((object) bpmApp, BpmAppService.fAt5U5fObxLl58aH8Wfj(-2107978722 ^ -2107669464));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              BpmAppService.WpOQhQfOGyL52oND3jRJ((object) source, (object) additionalFilesContent, (object) helpFileContent);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 4;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
            default:
              source = Mapper.Map<BPMAppDTO, IBPMApp>(bpmApp);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 2;
              continue;
          }
        }
label_6:
        this.manager.Save(source);
        num1 = 3;
      }
label_5:
      return Mapper.Map<IBPMApp, BPMAppDTO>(source);
    }

    /// <inheritdoc />
    public BPMAppDTO Save(BPMAppDTO bpmApp)
    {
      int num = 1;
      byte[] helpFileContent;
      byte[] additionalFilesContent;
      while (true)
      {
        switch (num)
        {
          case 1:
            BpmAppService.OtqV1EfOhKh5vGxOrWx0((object) bpmApp, BpmAppService.fAt5U5fObxLl58aH8Wfj(1142330761 ^ 1541959139 ^ 536588380));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            this.LoadFiles(bpmApp.Id, out helpFileContent, out additionalFilesContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      return this.Save(bpmApp, helpFileContent, additionalFilesContent);
    }

    /// <inheritdoc />
    public void Delete(long id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            IBPMApp bpmApp = this.manager.Load(id);
            if (!BpmAppService.uE7xBafOEgC91QBjnaCD((object) bpmApp))
            {
              bpmApp.Delete();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:
      return;
label_5:
      throw new InvalidOperationException((string) BpmAppService.pcyskRfOfNvY7t2wnlMI(BpmAppService.fAt5U5fObxLl58aH8Wfj(-606654180 ^ -606963366)));
    }

    /// <inheritdoc />
    public void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent)
    {
      int num = 2;
      IBPMApp bpmApp;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            helpFileContent = (byte[]) BpmAppService.JCCOa0fOQYiaFROYBIkR((object) bpmApp);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 3;
            continue;
          case 2:
            bpmApp = this.manager.Load(id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
            continue;
          case 3:
            additionalFilesContent = (byte[]) BpmAppService.o02VYpfOCEcFplN0mKTT((object) bpmApp);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public ConfigExportSettings GetAppExportSettings(Guid uid, Guid settingsFilename)
    {
      int num1 = 20;
      ConfigExportSettings appExportSettings;
      while (true)
      {
        int num2 = num1;
        BPMAppDTO bpmAppDto;
        object obj;
        IEnumerator<IBPMAppItemsConverter> enumerator;
        ElmaStoreComponentManifest platform;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ConfigExportSettings configExportSettings = appExportSettings;
              ElmaStoreComponentManifest componentManifest = new ElmaStoreComponentManifest();
              BpmAppService.sMyuDlfOZiDR7Tj6iTfa((object) componentManifest, ManifestComponentType.ProcessPackage);
              BpmAppService.aFCpx9fO82eLHSDSqXnB((object) configExportSettings, (object) componentManifest);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 5;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!appExportSettings.Manifest.Dependencies.Any<ElmaStoreComponentDependency>((Func<ElmaStoreComponentDependency, bool>) (d => BpmAppService.\u003C\u003Ec__DisplayClass11_0.BxyZ3r8zOEcxA1fLgSbg(BpmAppService.\u003C\u003Ec__DisplayClass11_0.gJOa9m8zkcw2U6qOvMIN((object) d), BpmAppService.\u003C\u003Ec__DisplayClass11_0.XnqefP8znyBfYg3ZM6ED((object) platform)))))
              {
                num2 = 8;
                continue;
              }
              goto case 7;
            case 3:
              if (BpmAppService.lDjhDEfOvsHD0nPuPdpA((object) bpmAppDto) != null)
              {
                num2 = 15;
                continue;
              }
              goto case 1;
            case 4:
              if (!(obj is FilesExportSetting filesExportSetting))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 18 : 16;
                continue;
              }
              goto case 5;
            case 5:
              filesExportSetting.BpmAppId = bpmAppDto.Id;
              num2 = 13;
              continue;
            case 6:
label_19:
              ((ElmaStoreComponentManifest) BpmAppService.BN7hC2fOSk3C0kmpS946((object) appExportSettings)).BPMAppManifest = ClassSerializationHelper.SerializeObjectByXml((object) bpmAppDto.AppManifest);
              num2 = 11;
              continue;
            case 7:
              if (appExportSettings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out obj))
                goto case 4;
              else
                goto label_13;
            case 8:
              List<ElmaStoreComponentDependency> dependencies = appExportSettings.Manifest.Dependencies;
              ElmaStoreComponentDependency componentDependency = new ElmaStoreComponentDependency();
              BpmAppService.uS55m9fORj9PhLcTd1w8((object) componentDependency, BpmAppService.SVmqBCfOiypNkOBbC28q((object) platform));
              BpmAppService.UYwaQ6fOXHu5Sly19S13((object) componentDependency, BpmAppService.re4HWRfOKMcrEolDIlec(BpmAppService.zj38ebfOqgpiRtJPJLIV((object) platform)));
              dependencies.Add(componentDependency);
              num2 = 7;
              continue;
            case 9:
              if (platform != null)
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 10:
            case 12:
              if (BpmAppService.PseQFhfOuIgXIBqsrSG1((object) bpmAppDto) == null)
              {
                num2 = 21;
                continue;
              }
              goto case 17;
            case 11:
            case 21:
              goto label_37;
            case 13:
            case 16:
            case 18:
              goto label_21;
            case 14:
              bpmAppDto = Mapper.Map<IBPMApp, BPMAppDTO>(this.manager.Load(uid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 0;
              continue;
            case 15:
              BpmAppService.aFCpx9fO82eLHSDSqXnB((object) appExportSettings, BpmAppService.lDjhDEfOvsHD0nPuPdpA((object) bpmAppDto));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 12;
              continue;
            case 17:
              enumerator = this.converters.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            case 19:
              appExportSettings = new ConfigExportSettings(settingsFilename);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 5 : 14;
              continue;
            case 20:
              num2 = 19;
              continue;
            default:
              try
              {
label_26:
                if (BpmAppService.AmkxB4fOVXgUAo0ryR4i((object) enumerator))
                  goto label_25;
                else
                  goto label_27;
label_24:
                int num3;
                switch (num3)
                {
                  case 1:
                    break;
                  case 2:
                    goto label_26;
                  default:
                    goto label_19;
                }
label_25:
                BpmAppService.E1i5ysfOIBSVQbOZjicr((object) enumerator.Current, BpmAppService.PseQFhfOuIgXIBqsrSG1((object) bpmAppDto), (object) appExportSettings);
                num3 = 2;
                goto label_24;
label_27:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                goto label_24;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                else
                  goto label_31;
label_30:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_31:
                enumerator.Dispose();
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
                {
                  num4 = 0;
                  goto label_30;
                }
                else
                  goto label_30;
              }
          }
        }
label_13:
        num1 = 16;
        continue;
label_37:
        platform = this.moduleDtoManager.GetInstalledComponentManifests().FirstOrDefault<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (m => m.ProductType == ManifestComponentType.Platform));
        num1 = 9;
      }
label_21:
      return appExportSettings;
    }

    /// <inheritdoc />
    public FilesLoadToCacheResult PutBpmAppFilesToCache(FilesLoadToCacheInput input)
    {
      int num = 10;
      FilesLoadToCacheResult cache;
      byte[] additionalFilesContent;
      byte[] helpFileContent;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (additionalFilesContent.Length != 0)
            {
              num = 8;
              continue;
            }
            goto label_9;
          case 2:
          case 11:
            goto label_9;
          case 3:
            cache.HelpFileUid = this.LoadFileToCacheByUniqueKey(BpmAppService.Kjx2VAfOn0KfGcyrjB4G((object) input), (string) BpmAppService.q8dHUMfOTTTVT3m8uPCk((object) input), helpFileContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 5;
            continue;
          case 4:
            if (BpmAppService.scUTJUfOkBPs4b3uLaHM(BpmAppService.q8dHUMfOTTTVT3m8uPCk((object) input)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 6:
            if (helpFileContent != null)
            {
              num = 7;
              continue;
            }
            goto default;
          case 7:
            if (helpFileContent.Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 4;
              continue;
            }
            goto default;
          case 8:
            if (!BpmAppService.scUTJUfOkBPs4b3uLaHM((object) input.HelpFolderName))
            {
              num = 12;
              continue;
            }
            goto label_9;
          case 9:
            this.LoadFiles(input.BpmAppId, out helpFileContent, out additionalFilesContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 4 : 6;
            continue;
          case 10:
            cache = new FilesLoadToCacheResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 9 : 9;
            continue;
          case 12:
            BpmAppService.xFvBZwfO2SiE369KsxsW((object) cache, this.LoadFileToCacheByUniqueKey(input.BpmAppId, (string) BpmAppService.q7aXiffOOPqLFof8xObs((object) input), additionalFilesContent));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 11;
            continue;
          default:
            if (additionalFilesContent == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
        }
      }
label_9:
      return cache;
    }

    /// <summary>Загрузить файл в кэш, проверив его уникальность</summary>
    /// <param name="bpmAppId">Идентификатор приложения</param>
    /// <param name="fileName">Имя файла</param>
    /// <param name="fileContent">Содержимое файла</param>
    /// <returns>Ключ файла</returns>
    private Guid LoadFileToCacheByUniqueKey(long bpmAppId, string fileName, byte[] fileContent)
    {
      int num = 2;
      Guid fileCacheGuid;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!BpmAppService.scUTJUfOkBPs4b3uLaHM(BpmAppService.vbNWi4fOem1mJU958waw((object) this.cacheFilesService, fileCacheGuid)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            fileCacheGuid = this.GetFileCacheGuid(bpmAppId, fileContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
            continue;
          case 3:
            this.LoadFileToCache(fileName, fileContent, fileCacheGuid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return fileCacheGuid;
    }

    /// <summary>Получить ключ файла для кэш-а</summary>
    /// <param name="bpmAppId">Идентификатор приложения</param>
    /// <param name="fileContent">Содержимое файла</param>
    /// <returns>Guid файла</returns>
    private Guid GetFileCacheGuid(long bpmAppId, byte[] fileContent)
    {
      int num = 1;
      string fileHashKey;
      Guid fileCacheGuid1;
      Guid fileCacheGuid2;
      while (true)
      {
        switch (num)
        {
          case 1:
            fileHashKey = this.GetFileHashKey(bpmAppId, fileContent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            fileCacheGuid2 = BpmAppService.qnbOI9fOPyM1EKYmtKpL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 3 : 4;
            continue;
          case 4:
            this.filesKeys.Add(fileHashKey, fileCacheGuid2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 2;
            continue;
          case 5:
            goto label_5;
          default:
            if (!this.filesKeys.TryGetValue(fileHashKey, out fileCacheGuid1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return fileCacheGuid1;
label_8:
      return fileCacheGuid2;
    }

    /// <summary>
    /// Получить уникальное хэш значение по идентификатору BpmApp и по содержимому файла
    /// </summary>
    /// <param name="bpmAppId">Идентификатор BpmApp</param>
    /// <param name="fileContent">Содержимое файла</param>
    /// <returns>Hash значение ввиде base64</returns>
    private string GetFileHashKey(long bpmAppId, byte[] fileContent)
    {
      int num1 = 2;
      Crc32 crc32;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            crc32 = new Crc32();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      string fileHashKey;
      try
      {
        byte[] numArray = (byte[]) BpmAppService.kDeocyfO1VohbsnmiFgp((object) crc32, (object) fileContent);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            default:
              fileHashKey = (string) BpmAppService.rZjp91fOpK2dW02VbJxR(BpmAppService.chgbacfO37yvDoEcAKGR(BpmAppService.HBSQoEfONLfqrWCX4YKv(bpmAppId)), BpmAppService.chgbacfO37yvDoEcAKGR((object) numArray));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              continue;
          }
        }
      }
      finally
      {
        if (crc32 != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                crc32.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      return fileHashKey;
    }

    /// <summary>Загрузка файла в кэш</summary>
    /// <param name="fileName">Имя файла</param>
    /// <param name="fileContent">Содержимое файла</param>
    private void LoadFileToCache(string fileName, byte[] fileContent, Guid fileGuid)
    {
      int num1 = 2;
      MemoryStream inputStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            if (!BpmAppService.DoCPRifOaIVfiBBPv5EZ((object) this.cacheFilesService, fileGuid, (object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_9;
          case 4:
            goto label_5;
        }
        inputStream = (MemoryStream) BpmAppService.Vk8t5pfOD0YRpN5ckFCl((object) fileContent, false);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 4;
      }
label_14:
      return;
label_9:
      return;
label_5:
      try
      {
        this.cacheFilesService.IncrementCacheFile(fileGuid, (Stream) inputStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (inputStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                BpmAppService.ASaefCfOtDTSUDsmlJ8G((object) inputStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    internal static object fAt5U5fObxLl58aH8Wfj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void OtqV1EfOhKh5vGxOrWx0([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void WpOQhQfOGyL52oND3jRJ([In] object obj0, [In] object obj1, [In] object obj2) => ((IBPMApp) obj0).InputFilesContent((byte[]) obj1, (byte[]) obj2);

    internal static bool wbNFaKfOWwfmxy9ov8VN() => BpmAppService.JeSf9afOBSRyHuDrjRfX == null;

    internal static BpmAppService zZW7slfOoletkZikSvrk() => BpmAppService.JeSf9afOBSRyHuDrjRfX;

    internal static bool uE7xBafOEgC91QBjnaCD([In] object obj0) => ((IBPMApp) obj0).Installed;

    internal static object pcyskRfOfNvY7t2wnlMI([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object JCCOa0fOQYiaFROYBIkR([In] object obj0) => (object) ((IBPMApp) obj0).HelpFileContent;

    internal static object o02VYpfOCEcFplN0mKTT([In] object obj0) => (object) ((IBPMApp) obj0).AdditionalFilesContent;

    internal static object lDjhDEfOvsHD0nPuPdpA([In] object obj0) => (object) ((BPMAppDTO) obj0).ComponentManifest;

    internal static void aFCpx9fO82eLHSDSqXnB([In] object obj0, [In] object obj1) => ((ConfigExportSettings) obj0).Manifest = (ElmaStoreComponentManifest) obj1;

    internal static void sMyuDlfOZiDR7Tj6iTfa([In] object obj0, [In] ManifestComponentType obj1) => ((ElmaStoreComponentManifest) obj0).ProductType = obj1;

    internal static object PseQFhfOuIgXIBqsrSG1([In] object obj0) => (object) ((BPMAppDTO) obj0).AppManifest;

    internal static void E1i5ysfOIBSVQbOZjicr([In] object obj0, [In] object obj1, [In] object obj2) => ((IBPMAppItemsConverter) obj0).ToExportSettings((BPMAppManifest) obj1, (ConfigExportSettings) obj2);

    internal static bool AmkxB4fOVXgUAo0ryR4i([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object BN7hC2fOSk3C0kmpS946([In] object obj0) => (object) ((ConfigExportSettings) obj0).Manifest;

    internal static object SVmqBCfOiypNkOBbC28q([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static void uS55m9fORj9PhLcTd1w8([In] object obj0, [In] object obj1) => ((ElmaStoreComponentDependency) obj0).Id = (string) obj1;

    internal static object zj38ebfOqgpiRtJPJLIV([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).SemanticVersion;

    internal static object re4HWRfOKMcrEolDIlec([In] object obj0) => (object) ManifestValidationHelper.GetFromVersion((SemanticVersion) obj0);

    internal static void UYwaQ6fOXHu5Sly19S13([In] object obj0, [In] object obj1) => ((ElmaStoreComponentDependency) obj0).ManifestVersion = (IVersionSpec) obj1;

    internal static object q8dHUMfOTTTVT3m8uPCk([In] object obj0) => (object) ((FilesLoadToCacheInput) obj0).HelpFileName;

    internal static bool scUTJUfOkBPs4b3uLaHM([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static long Kjx2VAfOn0KfGcyrjB4G([In] object obj0) => ((FilesLoadToCacheInput) obj0).BpmAppId;

    internal static object q7aXiffOOPqLFof8xObs([In] object obj0) => (object) ((FilesLoadToCacheInput) obj0).HelpFolderName;

    internal static void xFvBZwfO2SiE369KsxsW([In] object obj0, Guid value) => ((FilesLoadToCacheResult) obj0).HelpFolderUid = value;

    internal static object vbNWi4fOem1mJU958waw([In] object obj0, Guid uid) => (object) ((ICacheFilesService) obj0).GetFileName(uid);

    internal static Guid qnbOI9fOPyM1EKYmtKpL() => Guid.NewGuid();

    internal static object kDeocyfO1VohbsnmiFgp([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object HBSQoEfONLfqrWCX4YKv([In] long obj0) => (object) BitConverter.GetBytes(obj0);

    internal static object chgbacfO37yvDoEcAKGR([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static object rZjp91fOpK2dW02VbJxR([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool DoCPRifOaIVfiBBPv5EZ([In] object obj0, Guid uid, [In] object obj2) => ((ICacheFilesService) obj0).CreateCacheFileByUid(uid, (string) obj2);

    internal static object Vk8t5pfOD0YRpN5ckFCl([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static void ASaefCfOtDTSUDsmlJ8G([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}

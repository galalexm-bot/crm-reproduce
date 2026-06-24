// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.CryptoFileService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>Сервис работы с запароленными файлами</summary>
  [Component]
  internal class CryptoFileService : ICryptoContextAuthServiceImpl
  {
    private static TimeSpan validTokenTime;
    private readonly IFileManager fileManager;
    private readonly IAuthenticationService authenticationService;
    private readonly ISessionBoundVariableService sessionService;
    private readonly ICacheService cacheService;
    private readonly IFilePreviewService previewService;
    private static CryptoFileService AJKwo1GKHkMb2LgQKdZk;

    /// <summary>Работа с шифрованными документами</summary>
    public ICryptoContextAuthService CryptoContextAuthService
    {
      get => this.\u003CCryptoContextAuthService\u003Ek__BackingField;
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
              this.\u003CCryptoContextAuthService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>ctor</summary>
    /// <param name="fileManager">Менеджер файлов</param>
    /// <param name="authenticationService">Служба аутентификации системы</param>
    /// <param name="sessionService">Сервис работы со значениями переменных в рамках сессии пользователя</param>
    /// <param name="cacheService">Работ с кэшем</param>
    /// <param name="previewService">Работа с превью</param>
    public CryptoFileService(
      IFileManager fileManager,
      IAuthenticationService authenticationService,
      ISessionBoundVariableService sessionService,
      ICacheService cacheService,
      IFilePreviewService previewService)
    {
      CryptoFileService.docDWZGKxJ0QtyaUTDq1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.cacheService = cacheService;
            num = 3;
            continue;
          case 2:
            this.authenticationService = authenticationService;
            num = 4;
            continue;
          case 3:
            this.previewService = previewService;
            num = 5;
            continue;
          case 4:
            this.sessionService = sessionService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
            continue;
          case 5:
            goto label_3;
          default:
            this.fileManager = fileManager;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public bool CheckType(IEntity entity) => entity is FileStoreProvider.BinaryFileWrapper;

    /// <inheritdoc />
    public IEntity DecryptFromContext(IEntity entity) => throw new NotImplementedException();

    /// <inheritdoc />
    public string GetPasswordFromContext(IEntity entity)
    {
      int num = 2;
      BinaryFile binaryFile;
      string name;
      CryptoFileService.EncryptFilePasswordToken filePasswordToken;
      IUser currentUser;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (this.IsSignForEntity(entity))
            {
              binaryFile = (BinaryFile) CryptoFileService.v4eXNZGK0ENGFxTMHv9j((object) (FileStoreProvider.BinaryFileWrapper) entity);
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          case 3:
            currentUser = this.authenticationService.GetCurrentUser<IUser>();
            num = 5;
            continue;
          case 4:
            if (filePasswordToken == null)
            {
              num = 8;
              continue;
            }
            goto label_13;
          case 5:
            name = (string) CryptoFileService.R7C4YjGKyamu7mq3FxUj((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870880547), CryptoFileService.FlpVxPGKmB1hSw4BhblJ(1232639661 >> 3 ^ 153931003), (object) binaryFile.Id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_13;
          case 7:
            goto label_8;
          case 8:
            key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979393417), CryptoFileService.FlpVxPGKmB1hSw4BhblJ(-342626196 - 1290888215 ^ -1633594757), CryptoFileService.MeyIN8GK9xiv581ZE2Ck((object) binaryFile), CryptoFileService.d7APtaGKdQyG4uZkMdhy((object) currentUser));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 9 : 9;
            continue;
          case 9:
            if (this.cacheService.TryGetValue<CryptoFileService.EncryptFilePasswordToken>(key, out filePasswordToken))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 10 : 2;
              continue;
            }
            goto label_9;
          case 10:
            CryptoFileService.eWWSRKGKldk3Rh2HpdTc((object) this.sessionService, (object) name, (object) filePasswordToken);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 7 : 6;
            continue;
          default:
            if (this.sessionService.TryGetValue<CryptoFileService.EncryptFilePasswordToken>(name, out filePasswordToken))
            {
              num = 4;
              continue;
            }
            goto case 8;
        }
      }
label_2:
      return (string) null;
label_8:
      return (string) CryptoFileService.Lgqy8LGKJ90m3jPhNLG6((object) filePasswordToken.PasswordHash);
label_9:
      return (string) null;
label_13:
      return (string) CryptoFileService.Lgqy8LGKJ90m3jPhNLG6(CryptoFileService.N6lKARGKMTHWs0lWrVxP((object) filePasswordToken));
    }

    /// <inheritdoc />
    public bool IsSignForEntity(IEntity entity)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        IUser currentUser;
        string str;
        CryptoFileService.EncryptFilePasswordToken filePasswordToken;
        BinaryFile file;
        DateTime dateTime;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dateTime = CryptoFileService.f1MBOxGKr7amCUVl96tK();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 3;
              continue;
            case 2:
              filePasswordToken.DateCreate = dateTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 16 : 14;
              continue;
            case 3:
              goto label_25;
            case 4:
              if (CryptoFileService.Dx7vvBGKg1mbI1brjcww(dateTime, filePasswordToken.DateCreate) > CryptoFileService.validTokenTime)
              {
                num2 = 6;
                continue;
              }
              if (this.CheckPassword(file, (string) CryptoFileService.Lgqy8LGKJ90m3jPhNLG6(CryptoFileService.N6lKARGKMTHWs0lWrVxP((object) filePasswordToken))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 7 : 7;
                continue;
              }
              goto label_19;
            case 5:
              goto label_6;
            case 6:
              this.sessionService.Remove(str);
              num2 = 3;
              continue;
            case 7:
              filePasswordToken.DateCreate = dateTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 8:
              if (!this.sessionService.TryGetValue<CryptoFileService.EncryptFilePasswordToken>(str, out filePasswordToken))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 11 : 2;
                continue;
              }
              goto case 18;
            case 9:
              CryptoFileService.HgjIoGGKY7uDOtRQMX4j((object) this.cacheService, (object) key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 5;
              continue;
            case 10:
              goto label_19;
            case 11:
              key = (string) CryptoFileService.p2CHDyGK5UPbf4tQlphL(CryptoFileService.FlpVxPGKmB1hSw4BhblJ(694673736 ^ -23604109 ^ -671880323), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939559262), (object) file.Id, CryptoFileService.d7APtaGKdQyG4uZkMdhy((object) currentUser));
              num2 = 19;
              continue;
            case 12:
              if (!CryptoFileService.jofgasGKjCgwJ0xx7TVf(CryptoFileService.Dx7vvBGKg1mbI1brjcww(dateTime, filePasswordToken.DateCreate), CryptoFileService.validTokenTime))
              {
                this.sessionService.Set(str, (object) filePasswordToken);
                num2 = 17;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 1;
              continue;
            case 13:
              currentUser = this.authenticationService.GetCurrentUser<IUser>();
              num2 = 15;
              continue;
            case 14:
              file = (BinaryFile) CryptoFileService.v4eXNZGK0ENGFxTMHv9j((object) (FileStoreProvider.BinaryFileWrapper) entity);
              num2 = 13;
              continue;
            case 15:
              str = (string) CryptoFileService.R7C4YjGKyamu7mq3FxUj(CryptoFileService.FlpVxPGKmB1hSw4BhblJ(1654249598 >> 2 ^ 413574389), CryptoFileService.FlpVxPGKmB1hSw4BhblJ(-1867198571 ^ -1867050565), (object) file.Id);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
            case 16:
              goto label_18;
            case 17:
              if (!this.CheckPassword(file, (string) CryptoFileService.Lgqy8LGKJ90m3jPhNLG6((object) filePasswordToken.PasswordHash)))
              {
                num2 = 10;
                continue;
              }
              goto case 2;
            case 18:
              if (filePasswordToken == null)
                goto case 11;
              else
                goto label_9;
            case 19:
              goto label_16;
            default:
              goto label_22;
          }
        }
label_9:
        num1 = 4;
        continue;
label_16:
        if (this.cacheService.TryGetValue<CryptoFileService.EncryptFilePasswordToken>(key, out filePasswordToken))
          num1 = 12;
        else
          goto label_19;
      }
label_6:
      return false;
label_18:
      return true;
label_19:
      return false;
label_22:
      return true;
label_25:
      return false;
    }

    /// <inheritdoc />
    public bool SignInForEntity(IEntity entity, string password)
    {
      int num = 10;
      string str;
      CryptoFileService.EncryptFilePasswordToken filePasswordToken1;
      BinaryFile file;
      string name;
      IUser currentUser;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            name = (string) CryptoFileService.R7C4YjGKyamu7mq3FxUj(CryptoFileService.FlpVxPGKmB1hSw4BhblJ(993438473 ^ 993425891), CryptoFileService.FlpVxPGKmB1hSw4BhblJ(1033719030 - 2012070891 ^ -978561243), (object) file.Id);
            num = 3;
            continue;
          case 2:
            CryptoFileService.EncryptFilePasswordToken filePasswordToken2 = new CryptoFileService.EncryptFilePasswordToken();
            CryptoFileService.DsXqb8GKUsIqYsh1KQq9((object) filePasswordToken2, (object) str);
            CryptoFileService.rBrK6CGKs5auuISWnLvO((object) filePasswordToken2, CryptoFileService.f1MBOxGKr7amCUVl96tK());
            filePasswordToken1 = filePasswordToken2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
            continue;
          case 3:
            this.sessionService.Set(name, (object) filePasswordToken1);
            num = 8;
            continue;
          case 4:
            this.cacheService.Insert<CryptoFileService.EncryptFilePasswordToken>(key, filePasswordToken1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 5:
            str = (string) CryptoFileService.EuNveyGKLQ8DJ4rwtJ0D((object) password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 6;
            continue;
          case 6:
            currentUser = AuthenticationService.GetCurrentUser<IUser>();
            num = 2;
            continue;
          case 7:
            goto label_4;
          case 8:
            key = (string) CryptoFileService.p2CHDyGK5UPbf4tQlphL(CryptoFileService.FlpVxPGKmB1hSw4BhblJ(654297945 ^ 654054687), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77773345), (object) file.Id, CryptoFileService.d7APtaGKdQyG4uZkMdhy((object) currentUser));
            num = 4;
            continue;
          case 9:
            if (this.CheckPassword(file, password))
            {
              num = 5;
              continue;
            }
            goto label_4;
          case 10:
            file = ((FileStoreProvider.BinaryFileWrapper) entity).File;
            num = 9;
            continue;
          default:
            goto label_7;
        }
      }
label_4:
      return false;
label_7:
      return true;
    }

    /// <inheritdoc />
    public void SignOutForEntity(IEntity entity)
    {
      int num = 3;
      IUser currentUser;
      string id;
      string key;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.cacheService.Remove(key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 1;
            continue;
          case 2:
            currentUser = AuthenticationService.GetCurrentUser<IUser>();
            num = 5;
            continue;
          case 3:
            id = (string) entity.GetId();
            num = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            str = (string) CryptoFileService.R7C4YjGKyamu7mq3FxUj(CryptoFileService.FlpVxPGKmB1hSw4BhblJ(1051802738 - -1831968059 ^ -1411249337), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124652192), (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 6:
            key = (string) CryptoFileService.p2CHDyGK5UPbf4tQlphL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825343808), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470561648), (object) id, CryptoFileService.d7APtaGKdQyG4uZkMdhy((object) currentUser));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
            continue;
          default:
            CryptoFileService.lnbOGxGKckLegGv6eclb((object) this.sessionService, (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 6 : 6;
            continue;
        }
      }
label_2:;
    }

    private bool CheckPassword(BinaryFile file, string password)
    {
      int num = 2;
      IEntity entity;
      string fileEncryptPassword;
      BinaryFile file1;
      while (true)
      {
        switch (num)
        {
          case 1:
            file1 = file;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 2;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<IEntity> source = ((ComponentManager) CryptoFileService.eKcIAXGXF33Ki6vLBJhD()).GetExtensionPoints<IBinaryFileParentEntity>().Select<IBinaryFileParentEntity, IEntity>((Func<IBinaryFileParentEntity, IEntity>) (p => (IEntity) CryptoFileService.\u003C\u003Ec__DisplayClass20_0.SC61eTvcwJ01tF8Nxq5a((object) p, (object) file1)));
            // ISSUE: reference to a compiler-generated field
            Func<IEntity, bool> func = CryptoFileService.\u003C\u003Ec.\u003C\u003E9__20_1;
            Func<IEntity, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              CryptoFileService.\u003C\u003Ec.\u003C\u003E9__20_1 = predicate = (Func<IEntity, bool>) (p => p != null);
            }
            else
              goto label_15;
label_14:
            entity = source.FirstOrDefault<IEntity>(predicate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 6;
            continue;
label_15:
            predicate = func;
            goto label_14;
          case 4:
            if (CryptoFileService.XqdoMwGKzmosqmf0GCsr((object) file1))
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            goto label_6;
          case 6:
            if (entity == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 5 : 4;
              continue;
            }
            fileEncryptPassword = (string) CryptoFileService.vqZXLRGXBs0va34s6NJP((object) this.CryptoContextAuthService, (object) entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_6:
      return false;
label_9:
      return this.previewService.CheckPassword(file1, fileEncryptPassword, password);
label_10:
      return CryptoFileService.Lkaf3jGXWo8rt9c8m26t((object) this.previewService, (object) file1, (object) password);
    }

    static CryptoFileService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CryptoFileService.docDWZGKxJ0QtyaUTDq1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CryptoFileService.validTokenTime = new TimeSpan(0, 0, 5, 0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool CiV3a4GKAnhbeKpAZRNj() => CryptoFileService.AJKwo1GKHkMb2LgQKdZk == null;

    internal static CryptoFileService EDMtwtGK7TpcN4bq6D5k() => CryptoFileService.AJKwo1GKHkMb2LgQKdZk;

    internal static void docDWZGKxJ0QtyaUTDq1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object v4eXNZGK0ENGFxTMHv9j([In] object obj0) => (object) ((FileStoreProvider.BinaryFileWrapper) obj0).File;

    internal static object FlpVxPGKmB1hSw4BhblJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object R7C4YjGKyamu7mq3FxUj([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object N6lKARGKMTHWs0lWrVxP([In] object obj0) => (object) ((CryptoFileService.EncryptFilePasswordToken) obj0).PasswordHash;

    internal static object Lgqy8LGKJ90m3jPhNLG6([In] object obj0) => (object) EncryptionHelper.DecryptPwd((string) obj0);

    internal static object MeyIN8GK9xiv581ZE2Ck([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static object d7APtaGKdQyG4uZkMdhy([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void eWWSRKGKldk3Rh2HpdTc([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static DateTime f1MBOxGKr7amCUVl96tK() => DateTime.Now;

    internal static TimeSpan Dx7vvBGKg1mbI1brjcww([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static object p2CHDyGK5UPbf4tQlphL(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool jofgasGKjCgwJ0xx7TVf([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static void HgjIoGGKY7uDOtRQMX4j([In] object obj0, [In] object obj1) => ((ICacheService) obj0).Remove((string) obj1);

    internal static object EuNveyGKLQ8DJ4rwtJ0D([In] object obj0) => (object) EncryptionHelper.EncryptPwd((string) obj0);

    internal static void DsXqb8GKUsIqYsh1KQq9([In] object obj0, [In] object obj1) => ((CryptoFileService.EncryptFilePasswordToken) obj0).PasswordHash = (string) obj1;

    internal static void rBrK6CGKs5auuISWnLvO([In] object obj0, DateTime value) => ((CryptoFileService.EncryptFilePasswordToken) obj0).DateCreate = value;

    internal static void lnbOGxGKckLegGv6eclb([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Remove((string) obj1);

    internal static bool XqdoMwGKzmosqmf0GCsr([In] object obj0) => ((BinaryFile) obj0).Encrypt;

    internal static object eKcIAXGXF33Ki6vLBJhD() => (object) ComponentManager.Current;

    internal static object vqZXLRGXBs0va34s6NJP([In] object obj0, [In] object obj1) => (object) ((ICryptoContextAuthService) obj0).GetPasswordFromContext((IEntity) obj1);

    internal static bool Lkaf3jGXWo8rt9c8m26t([In] object obj0, [In] object obj1, [In] object obj2) => ((IFilePreviewService) obj0).CheckPassword((BinaryFile) obj1, (string) obj2);

    /// <summary>Хранение хеша пароля в контексте</summary>
    [Serializable]
    private class EncryptFilePasswordToken
    {
      internal static object a4AfTjvcPfR5eorM2MUX;

      /// <summary>Хеш пароля</summary>
      public string PasswordHash
      {
        get => this.\u003CPasswordHash\u003Ek__BackingField;
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
                this.\u003CPasswordHash\u003Ek__BackingField = value;
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

      /// <summary>Дата последнего запроса хеша</summary>
      public DateTime DateCreate
      {
        get => this.\u003CDateCreate\u003Ek__BackingField;
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
                this.\u003CDateCreate\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

      public EncryptFilePasswordToken()
      {
        CryptoFileService.EncryptFilePasswordToken.lIYijpvc3LsVrr8DHWfr();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool l59sf7vc1QyZNJLhfK6e() => CryptoFileService.EncryptFilePasswordToken.a4AfTjvcPfR5eorM2MUX == null;

      internal static CryptoFileService.EncryptFilePasswordToken CNlKFMvcNE3L7Sxs0Uxm() => (CryptoFileService.EncryptFilePasswordToken) CryptoFileService.EncryptFilePasswordToken.a4AfTjvcPfR5eorM2MUX;

      internal static void lIYijpvc3LsVrr8DHWfr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

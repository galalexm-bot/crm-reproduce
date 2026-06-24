// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleFileDeployService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <inheritdoc />
  [Service]
  internal sealed class ModuleFileDeployService : 
    IModuleFileDeployService,
    IModuleFileDeployServiceExtended
  {
    private static readonly ILogger deployLog;
    private readonly IConfigurationUnpackService configurationUnpackService;
    private readonly IExportImportService exportImportService;
    private readonly IModuleManager moduleManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    internal static ModuleFileDeployService lE90MqEMtBeUECcTVxdS;

    /// <summary>Ctor</summary>
    /// <param name="configurationUnpackService">Сервис получения настроек импорта из BPMApp</param>
    /// <param name="exportImportService">Сервис экспорта/импорта</param>
    /// <param name="moduleManager">Менеджер управления модулями</param>
    /// <param name="moduleMetadataLoader">Сервис загрузки метаданных модуля</param>
    public ModuleFileDeployService(
      IConfigurationUnpackService configurationUnpackService,
      IExportImportService exportImportService,
      IModuleManager moduleManager,
      IModuleMetadataLoader moduleMetadataLoader)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.exportImportService = exportImportService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.configurationUnpackService = configurationUnpackService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
          case 4:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 2;
            continue;
          default:
            this.moduleManager = moduleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 4;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public bool IsModule(
      IReadOnlyCollection<IConfigImportSettings> importSettings)
    {
      ILogger deployLog = ModuleFileDeployService.deployLog;
      try
      {
        this.ValidateImportSettings(importSettings, deployLog);
      }
      catch (ModuleValidationException ex)
      {
        return false;
      }
      catch (Exception ex)
      {
        deployLog.Error(ex, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335287069)));
        throw;
      }
      return true;
    }

    /// <inheritdoc />
    public bool HasModules(
      IReadOnlyCollection<IConfigImportSettings> importSettings)
    {
      ILogger deployLog = ModuleFileDeployService.deployLog;
      bool flag = false;
      try
      {
        foreach (IConfigImportSettings importSetting in (IEnumerable<IConfigImportSettings>) importSettings)
        {
          ElmaStoreComponentManifest manifest = importSetting.Manifest;
          if ((manifest != null ? (manifest.ProductType == ManifestComponentType.Module ? 1 : 0) : 0) != 0)
          {
            Guid? moduleUid = importSetting.Manifest?.ModuleUid;
            Guid empty = Guid.Empty;
            if ((moduleUid.HasValue ? (moduleUid.HasValue ? (moduleUid.GetValueOrDefault() != empty ? 1 : 0) : 0) : 1) != 0)
            {
              this.ValidateImportSettings((IReadOnlyCollection<IConfigImportSettings>) new IConfigImportSettings[1]
              {
                importSetting
              }, deployLog);
              flag = true;
            }
          }
        }
        return flag;
      }
      catch (ModuleValidationException ex)
      {
        return false;
      }
      catch (Exception ex)
      {
        deployLog.Error(ex, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420525622)));
        throw;
      }
    }

    /// <inheritdoc />
    public Task Deploy(BinaryFile container, ILogger logger)
    {
      int num = 3;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      ModuleFileDeployService.\u003CDeploy\u003Ed__8 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            tBuilder.Start<ModuleFileDeployService.\u003CDeploy\u003Ed__8>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 2;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.container = container;
            num = 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ModuleFileDeployService.mrNkDgEM6ilh66ryuDST();
            num = 5;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
            continue;
          case 7:
            goto label_9;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
        }
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task<IEnumerable<Guid>> Test(
      IReadOnlyCollection<IConfigImportSettings> importSettings)
    {
      Contract.ArgumentNotNull((object) importSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021690955));
      return this.DoTest(importSettings, ModuleFileDeployService.deployLog);
    }

    /// <inheritdoc />
    public async Task Import(
      IReadOnlyCollection<IConfigImportSettings> importSettings)
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 0;
            continue;
          case 3:
            goto label_40;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 3;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              else
                goto label_7;
label_5:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    goto label_9;
                  case 3:
                    goto label_7;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    Contract.ArgumentNotNull((object) importSettings, (string) ModuleFileDeployService.\u003CImport\u003Ed__10.cUjUpn84G8k2qhFusuII(-16752921 ^ -16457255));
                    num3 = 3;
                    continue;
                }
              }
label_9:
              try
              {
                int num4;
                if (num2 != 0)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 3 : 0;
                  goto label_12;
                }
                else
                  goto label_21;
label_11:
                int num5;
                num4 = num5;
label_12:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ModuleFileDeployService.\u003CImport\u003Ed__10>(ref awaiter, this);
                      num4 = 11;
                      continue;
                    case 2:
                    case 10:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 9 : 5;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = ModuleFileDeployService.\u003CImport\u003Ed__10.IDJ5RK84Ef2p5vO94KCM((object) this.DoImport(importSettings, ModuleFileDeployService.deployLog));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 4;
                      continue;
                    case 4:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
                        continue;
                      }
                      goto case 7;
                    case 5:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 8;
                      continue;
                    case 6:
                      taskAwaiter = awaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
                      continue;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 6 : 2;
                      continue;
                    case 8:
                      goto label_18;
                    case 9:
                      goto label_2;
                    case 11:
                      goto label_37;
                    default:
                      goto label_21;
                  }
                }
label_37:
                return;
label_18:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num2 = -1;
                num5 = 10;
                goto label_11;
label_21:
                awaiter = taskAwaiter;
                num5 = 5;
                goto label_11;
              }
              catch (ModuleDeployException ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_27;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      ModuleFileDeployService.deployLog.Error((Exception) ex, EleWise.ELMA.SR.T((string) ModuleFileDeployService.\u003CImport\u003Ed__10.cUjUpn84G8k2qhFusuII(87862435 ^ 87643433)));
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                      continue;
                  }
                }
label_27:
                throw;
              }
              catch (Exception ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      ModuleFileDeployService.deployLog.Error(ex, (string) ModuleFileDeployService.\u003CImport\u003Ed__10.GjRwDQ84fsj4rMbFAfvq((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727044788)));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_32;
                  }
                }
label_32:
                throw;
              }
label_7:
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
              {
                num3 = 2;
                goto label_5;
              }
              else
                goto label_5;
            }
            catch (Exception ex)
            {
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                num8 = 0;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_33;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = 2;
                    continue;
                }
              }
label_33:
              return;
            }
          default:
            num1 = 5;
            continue;
        }
      }
label_40:;
    }

    /// <summary>Выполнить тестирование и импорт</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <param name="logger">Логер</param>
    private async Task DoDeploy(
      IReadOnlyCollection<IConfigImportSettings> importSettings,
      ILogger logger)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 2:
label_47:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = 5;
              continue;
            case 3:
              goto label_45;
            case 4:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 25 : 24;
                else
                  goto label_16;
label_7:
                Importer importer;
                TaskAwaiter<IReadOnlyCollection<ModuleImportSettings>> taskAwaiter1;
                TaskAwaiter taskAwaiter2;
                TaskAwaiter awaiter1;
                TaskAwaiter<IReadOnlyCollection<ModuleImportSettings>> awaiter2;
                IReadOnlyCollection<ModuleImportSettings> result;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      taskAwaiter1 = new TaskAwaiter<IReadOnlyCollection<ModuleImportSettings>>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = 6;
                      continue;
                    case 3:
                    case 27:
                      awaiter1.GetResult();
                      num4 = 4;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.ioDCm684ZnwOKVvlgPGM((object) logger, ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.zP0qrU84IFv0en49tkCm(ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.EbjFQE848roCZAPwNg1N(1113862659 ^ 1113704939)));
                      num4 = 15;
                      continue;
                    case 5:
                      awaiter1 = taskAwaiter2;
                      num4 = 19;
                      continue;
                    case 6:
                      result = awaiter2.GetResult();
                      num4 = 14;
                      continue;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      awaiter2 = importer.TestImport(ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.l1iZRx84ukKHY06PTVjq(), (IEnumerable<IConfigImportSettings>) importSettings, true).GetAwaiter();
                      num4 = 20;
                      continue;
                    case 8:
                      // ISSUE: reference to a compiler-generated method
                      awaiter1 = ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.pahlGd84VX92Gkv4md7a((object) importer.Import((IReadOnlyCollection<IConfigImportSettings>) result));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 23 : 24;
                      continue;
                    case 9:
                      importer = new Importer(this.exportImportService, this.moduleManager, this.moduleMetadataLoader, logger);
                      num4 = 21;
                      continue;
                    case 10:
                      taskAwaiter1 = awaiter2;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                      continue;
                    case 11:
                      taskAwaiter2 = awaiter1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 5 : 18;
                      continue;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 27 : 13;
                      continue;
                    case 13:
                      goto label_42;
                    case 14:
                      // ISSUE: reference to a compiler-generated method
                      logger.Info(ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.zP0qrU84IFv0en49tkCm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289491792)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 23;
                      continue;
                    case 15:
                      goto label_47;
                    case 16:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = 10;
                      continue;
                    case 17:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 1;
                      num4 = 11;
                      continue;
                    case 18:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ModuleFileDeployService.\u003CDoDeploy\u003Ed__11>(ref awaiter1, this);
                      num4 = 22;
                      continue;
                    case 19:
                      taskAwaiter2 = new TaskAwaiter();
                      num4 = 12;
                      continue;
                    case 20:
                      if (!awaiter2.IsCompleted)
                      {
                        num4 = 16;
                        continue;
                      }
                      goto case 6;
                    case 21:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.ioDCm684ZnwOKVvlgPGM((object) logger, (object) EleWise.ELMA.SR.T((string) ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.EbjFQE848roCZAPwNg1N(-882126494 ^ -881972438)));
                      num4 = 7;
                      continue;
                    case 22:
                      goto label_38;
                    case 23:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.ioDCm684ZnwOKVvlgPGM((object) logger, (object) EleWise.ELMA.SR.T((string) ModuleFileDeployService.\u003CDoDeploy\u003Ed__11.EbjFQE848roCZAPwNg1N(1051276242 - 990076387 ^ 60829289)));
                      num4 = 8;
                      continue;
                    case 24:
                      if (awaiter1.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
                        continue;
                      }
                      goto case 17;
                    case 25:
                      if (num3 != 1)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 9;
                        continue;
                      }
                      goto case 5;
                    case 26:
                      goto label_16;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IReadOnlyCollection<ModuleImportSettings>>, ModuleFileDeployService.\u003CDoDeploy\u003Ed__11>(ref awaiter2, this);
                      num4 = 13;
                      continue;
                  }
                }
label_42:
                return;
label_38:
                return;
label_16:
                awaiter2 = taskAwaiter1;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
                {
                  num4 = 0;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              catch (Exception ex)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_30;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = 2;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_25;
                  }
                }
label_30:
                return;
label_25:
                return;
              }
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult();
              num2 = 3;
              continue;
            default:
              goto label_46;
          }
        }
label_46:
        num1 = 4;
      }
label_45:;
    }

    /// <summary>Выполнить тестирование</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <param name="logger">Логер</param>
    private Task<IEnumerable<Guid>> DoTest(
      IReadOnlyCollection<IConfigImportSettings> importSettings,
      ILogger logger)
    {
      Importer importer = new Importer(this.exportImportService, this.moduleManager, this.moduleMetadataLoader, logger);
      Guid testUid = Guid.NewGuid();
      Task.Run<IReadOnlyCollection<ModuleImportSettings>>((Func<Task<IReadOnlyCollection<ModuleImportSettings>>>) (() =>
      {
        using (CallContextSessionOwner.Create())
          return importer.TestImport(testUid, (IEnumerable<IConfigImportSettings>) importSettings, false);
      }));
      return Task.FromResult<IEnumerable<Guid>>((IEnumerable<Guid>) new Guid[1]
      {
        testUid
      });
    }

    /// <summary>Выполнить импорт</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <param name="logger">Логер</param>
    private async Task DoImport(
      IReadOnlyCollection<IConfigImportSettings> importSettings,
      ILogger logger)
    {
      int num1 = 5;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_25:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 2;
              else
                goto label_16;
label_5:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 10:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 0;
                    continue;
                  case 2:
                    Importer importer = new Importer(this.exportImportService, this.moduleManager, this.moduleMetadataLoader, logger);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ModuleFileDeployService.\u003CDoImport\u003Ed__13.iGkAIP84Oh8VIu0iyTx0((object) logger, ModuleFileDeployService.\u003CDoImport\u003Ed__13.Huc9eF84nLgZPvmDILXM(ModuleFileDeployService.\u003CDoImport\u003Ed__13.Db2mMs84kRLD9AthFQMt(1917256330 ^ 1916991756)));
                    IReadOnlyCollection<IConfigImportSettings> configImportSettings = importSettings;
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ModuleFileDeployService.\u003CDoImport\u003Ed__13.LgGyfC842RUADfuJufwQ((object) importer.Import(configImportSettings));
                    num3 = 11;
                    continue;
                  case 3:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 7 : 7;
                    continue;
                  case 4:
                    goto label_16;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ModuleFileDeployService.\u003CDoImport\u003Ed__13.iGkAIP84Oh8VIu0iyTx0((object) logger, (object) EleWise.ELMA.SR.T((string) ModuleFileDeployService.\u003CDoImport\u003Ed__13.Db2mMs84kRLD9AthFQMt(993438473 ^ 993218785)));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ModuleFileDeployService.\u003CDoImport\u003Ed__13>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 9 : 1;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 8 : 10;
                    continue;
                  case 8:
                    taskAwaiter = awaiter;
                    num3 = 6;
                    continue;
                  case 9:
                    goto label_21;
                  case 11:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 12;
                  case 12:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 8 : 7;
                    continue;
                  default:
                    goto label_25;
                }
              }
label_21:
              return;
label_16:
              awaiter = taskAwaiter;
              num3 = 3;
              goto label_5;
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_17;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
                    continue;
                }
              }
label_17:
              return;
            }
          case 3:
            goto label_24;
          case 4:
            num1 = 2;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 4;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 3;
            continue;
        }
      }
label_24:;
    }

    /// <summary>Валидировать модули или приложение</summary>
    /// <param name="configImportSettings"></param>
    /// <returns></returns>
    private void ValidateImportSettings(
      IReadOnlyCollection<IConfigImportSettings> configImportSettings,
      ILogger logger)
    {
      logger.Info((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766096268)));
      new Validator(logger).Validate(configImportSettings);
      logger.Info((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87561031)));
    }

    static ModuleFileDeployService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleFileDeployService.zcQ9NBEMHKPAPOyxhDv9();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleFileDeployService.deployLog = Logger.GetLogger((string) ModuleFileDeployService.iNCdsREMA1QHmeKxBn0V(572119659 - -337058038 ^ 909409927));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool XYTob4EMwsA86neccIJq() => ModuleFileDeployService.lE90MqEMtBeUECcTVxdS == null;

    internal static ModuleFileDeployService UG3PPLEM4oCXMSMpWgXl() => ModuleFileDeployService.lE90MqEMtBeUECcTVxdS;

    internal static AsyncTaskMethodBuilder mrNkDgEM6ilh66ryuDST() => AsyncTaskMethodBuilder.Create();

    internal static void zcQ9NBEMHKPAPOyxhDv9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object iNCdsREMA1QHmeKxBn0V(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

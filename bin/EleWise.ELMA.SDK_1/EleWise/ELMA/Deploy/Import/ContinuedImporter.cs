// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ContinuedImporter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Выполнение импорта с автоматическим продолжением</summary>
  internal sealed class ContinuedImporter
  {
    private static readonly ILogger ImportLog;
    private readonly ContinuedImportState state;
    private readonly IRunImportParameters runImportParameters;
    private readonly IBLOBStore blobStore;
    private readonly IExportImportFileService fileService;
    private readonly IDeployManager deployManager;
    private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;
    private static ContinuedImporter uNIkL6E7PLH8bkGtu9vY;

    /// <summary>Ctor</summary>
    /// <param name="state">Состояние импорта</param>
    /// <param name="runImportParameters">Параметры запуска импорта</param>
    /// <param name="blobStore">Хранилище блобов</param>
    /// <param name="fileService">Сервис управления файлами импорта</param>
    /// <param name="deployManager">Менеджер экспорта-импорта конфигурации</param>
    /// <param name="configurationImportInternalFactory">Сервис-фабрика объектов для проверки и импорта конфигураций</param>
    public ContinuedImporter(
      ContinuedImportState state,
      IRunImportParameters runImportParameters,
      IBLOBStore blobStore,
      IExportImportFileService fileService,
      IDeployManager deployManager,
      IConfigurationImportInternalFactory configurationImportInternalFactory)
    {
      ContinuedImporter.UdJiXtE73WmWEDH70K3T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.blobStore = blobStore;
            num = 3;
            continue;
          case 2:
            this.state = state;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 3:
            this.fileService = fileService;
            num = 6;
            continue;
          case 4:
            goto label_2;
          case 5:
            this.configurationImportInternalFactory = configurationImportInternalFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 2;
            continue;
          case 6:
            this.deployManager = deployManager;
            num = 5;
            continue;
          default:
            this.runImportParameters = runImportParameters;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнить импорт</summary>
    /// <returns><c>true</c>, если импорт выполнено полностью, <c>false</c>, если требуется перезагрузка и продолжение импорта</returns>
    public bool ExecuteImport()
    {
      int num1 = 2;
      bool flag;
      List<IConfigImportSettings> list;
      List<IConfigImportSettings>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.FggFlaE7a86HowvMXqOj(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-542721635 ^ -543019883), (object) list.Count));
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    try
                    {
label_20:
                      if (enumerator.MoveNext())
                        goto label_13;
                      else
                        goto label_21;
label_10:
                      IConfigImportSettings current;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            this.state.SettingsList.Remove(current);
                            num3 = 6;
                            continue;
                          case 2:
                          case 3:
                            goto label_20;
                          case 4:
                            ContinuedImporter.ImportLog.Info(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1487388570 ^ -1487088152));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                            continue;
                          case 5:
                            ContinuedImporter.B2ADibE74qt13qCaL7Kh((object) this.state.LogMessages);
                            num3 = 13;
                            continue;
                          case 6:
                            this.fileService.DeleteFiles((string) ContinuedImporter.oJRPcXE7wFmeMpC8HoKa((object) current));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
                            continue;
                          case 7:
                            goto label_31;
                          case 8:
                            this.blobStore.Save(ImportExecutorActor.StateKey, (byte[]) ContinuedImporter.AKGiwkE767lu2fHEWUQv((object) this.state));
                            num3 = 4;
                            continue;
                          case 9:
                            if (this.RunImportStep0((IImportSettings) current))
                            {
                              num3 = 10;
                              continue;
                            }
                            goto case 5;
                          case 10:
                            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, (object) ((string) ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1598106783 - -968262081 ^ -630079374) + ((ElmaStoreComponentManifest) ContinuedImporter.aqs3spE7t0AEUEE7Xv3P((object) current))?.Title));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                            continue;
                          case 11:
                            goto label_13;
                          case 12:
                            goto label_3;
                          case 13:
                            // ISSUE: reference to a compiler-generated method
                            this.state.LogMessages.AddRange(this.runImportParameters.LogMessages.Where<DeployLogMessage>((Func<DeployLogMessage, bool>) (m => ContinuedImporter.\u003C\u003Ec.qxGMa38DEvPIsnSulZW4((object) m) != null)));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 8 : 8;
                            continue;
                          default:
                            flag = false;
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 12;
                            continue;
                        }
                      }
label_13:
                      current = enumerator.Current;
                      num3 = 7;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                      {
                        num3 = 9;
                        goto label_10;
                      }
                      else
                        goto label_10;
label_21:
                      num3 = 7;
                      goto label_10;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                      }
                    }
                  case 2:
                    this.CheckInstallPackages();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 4 : 0;
                    continue;
                  case 3:
                    goto label_4;
                  case 4:
                    enumerator = list.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
                    continue;
                }
label_31:
                ContinuedImporter.ImportLog.Info(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(272623989 ^ 272333985));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 3;
              }
            }
            catch (Exception ex)
            {
              int num5 = 7;
              string text;
              DeployLogMessage deployLogMessage;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    deployLogMessage = this.runImportParameters.LogMessages.LastOrDefault<DeployLogMessage>();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 0;
                    continue;
                  case 3:
                    ContinuedImporter.f6rnB1E7xm2lpoUHKlIH((object) Logger.Log, (object) text, (object) ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 4;
                    continue;
                  case 4:
                    goto label_4;
                  case 5:
                    if (!ContinuedImporter.fB9VHlE7AxiPBFuBfj3J((object) deployLogMessage))
                    {
                      num5 = 9;
                      continue;
                    }
                    goto case 8;
                  case 6:
                    if (deployLogMessage == null)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 5;
                  case 7:
                    text = EleWise.ELMA.SR.T((string) ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(1251470110 >> 2 ^ 312569037), ContinuedImporter.DePMQGE7H6UWnyYUDXm3((object) ex));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                    continue;
                  case 8:
                    if (ContinuedImporter.jsuR9tE7738aUNw1jm35((object) deployLogMessage) != DeployLogMessageType.Error)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 2;
                      continue;
                    }
                    goto case 3;
                  default:
                    this.runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, true));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 3;
                    continue;
                }
              }
            }
          case 2:
            list = this.state.SettingsList.ToList<IConfigImportSettings>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
            continue;
          case 3:
label_4:
            enumerator = list.GetEnumerator();
            num1 = 5;
            continue;
          case 4:
label_6:
            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1939377524 ^ -1939610596));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 1;
            continue;
          case 5:
            try
            {
label_47:
              if (enumerator.MoveNext())
                goto label_49;
              else
                goto label_48;
label_45:
              IConfigImportSettings current;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    goto label_49;
                  case 3:
                    goto label_47;
                  default:
                    ContinuedImporter.sYDc0nE700urQt96wENZ((object) this.fileService, ContinuedImporter.oJRPcXE7wFmeMpC8HoKa((object) current));
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 3;
                    continue;
                }
              }
label_48:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
              goto label_45;
label_49:
              current = enumerator.Current;
              num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
              {
                num6 = 0;
                goto label_45;
              }
              else
                goto label_45;
            }
            finally
            {
              enumerator.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
          case 6:
            this.blobStore.Remove(ImportExecutorActor.StateKey);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_3:
      return flag;
    }

    /// <summary>
    /// Проверить, есть ли невыполненная установка пакетов и выполнить при необходимости
    /// </summary>
    private void CheckInstallPackages()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        PackageInstallInfo installInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.state.NeedToInstallPackages = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              if (!this.state.NeedToInstallPackages)
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 4:
              goto label_6;
            case 5:
              if (this.state.PackageInstallInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 4;
                continue;
              }
              goto case 9;
            case 6:
              goto label_5;
            case 7:
              goto label_3;
            case 8:
              this.InstallPackages(installInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 7 : 7;
              continue;
            case 9:
              installInfo = (PackageInstallInfo) ContinuedImporter.CHlN92E7m9OkX9J0wQMy((object) this.state);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
              continue;
            default:
              ContinuedImporter.xnONcsE7yt52Du05U7vK((object) this.state, (object) null);
              num2 = 6;
              continue;
          }
        }
label_5:
        ContinuedImporter.B40DGJE7MY06uIhcQNLN((object) this.blobStore, (object) ImportExecutorActor.StateKey, ContinuedImporter.AKGiwkE767lu2fHEWUQv((object) this.state));
        num1 = 8;
      }
label_8:
      return;
label_6:
      return;
label_3:;
    }

    /// <summary>
    /// Получить последнее сообщение лога и проверить, что это сообщение успешного завершения стадии импорта
    /// </summary>
    private DeployLogMessage GetLastImportMessage()
    {
      int num1 = 4;
      DeployLogMessage lastImportMessage;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ContinuedImporter.jsuR9tE7738aUNw1jm35((object) lastImportMessage) == DeployLogMessageType.Error)
              {
                num2 = 2;
                continue;
              }
              goto label_4;
            case 2:
              goto label_3;
            case 3:
              if (lastImportMessage != null)
              {
                if (lastImportMessage.EndProcess)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                  continue;
                }
                goto label_7;
              }
              else
                goto label_6;
            case 4:
              lastImportMessage = this.runImportParameters.LogMessages.LastOrDefault<DeployLogMessage>();
              num2 = 3;
              continue;
            case 5:
              goto label_10;
            default:
              goto label_7;
          }
        }
label_6:
        num1 = 5;
      }
label_3:
      throw new InvalidOperationException((string) ContinuedImporter.pG9D3cE793U9PP96wt2u((object) lastImportMessage));
label_4:
      return lastImportMessage;
label_7:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234076090)));
label_10:
      throw new InvalidOperationException((string) ContinuedImporter.IsZW8vE7JydepbHE9Spi(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(694673736 ^ -23604109 ^ -671833109)));
    }

    /// <summary>Запустить предварительный шаг импорта</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <returns><c>true</c>, если импорт выполнено полностью, <c>false</c>, если требуется перезагрузка и продолжение импорта</returns>
    private bool RunImportStep0(IImportSettings settings)
    {
      int num = 3;
      DeployLogMessage lastImportMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            ContinuedImporter.WGPrtYE7lh0pKWn5QkJo(ContinuedImporter.pxOaIPE7do7JSaxqCfHo((object) this.configurationImportInternalFactory, (object) settings), (object) this.runImportParameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 5 : 6;
            continue;
          case 2:
            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1426456882 ^ 2009939514 ^ -584034532));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
            continue;
          case 3:
            if (settings.ImportStep == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
              continue;
            }
            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107747320));
            num = 5;
            continue;
          case 4:
            ContinuedImporter.JnjmhFE7rnUE3w6gCg9r((object) settings, 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_6;
          case 6:
            lastImportMessage = this.GetLastImportMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 3;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return this.RunImportStep1(settings, false, (PackageInstallInfo) null);
label_7:
      return this.RunImportStep1(settings, ContinuedImporter.JqxsXKE7gumetmNDL9of((object) lastImportMessage), (PackageInstallInfo) ContinuedImporter.SqRdnSE75xNe0UafODAY((object) lastImportMessage));
    }

    /// <summary>Запустить шаг импорта метаданных</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="needRestart">Требуется перезагрузка</param>
    /// <param name="installInfo">Данные об установке пакетов</param>
    /// <returns><c>true</c>, если импорт выполнено полностью, <c>false</c>, если требуется перезагрузка и продолжение импорта</returns>
    private bool RunImportStep1(
      IImportSettings settings,
      bool needRestart,
      PackageInstallInfo installInfo)
    {
      int num1 = 9;
      DeployLogMessage lastImportMessage;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              ContinuedImporter.Kluf68E7YyMhn2A71ry1((object) this.state, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 3:
              if (!needRestart)
              {
                num2 = 13;
                continue;
              }
              goto case 6;
            case 4:
              goto label_10;
            case 5:
              goto label_6;
            case 6:
              if (installInfo != null)
              {
                num2 = 7;
                continue;
              }
              goto case 10;
            case 7:
              if (!installInfo.Operations.Any<PackageInstallOperationInfo>())
              {
                num2 = 10;
                continue;
              }
              goto case 15;
            case 8:
              ContinuedImporter.ImportLog.Info(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(1218962250 ^ 1218673422));
              num2 = 3;
              continue;
            case 9:
              if (settings.ImportStep == 1)
              {
                num2 = 8;
                continue;
              }
              ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1837662597 ^ -1837897801));
              num2 = 4;
              continue;
            case 10:
              num3 = 0;
              break;
            case 11:
              goto label_12;
            case 12:
              goto label_11;
            case 13:
              ContinuedImporter.WGPrtYE7lh0pKWn5QkJo(ContinuedImporter.pxOaIPE7do7JSaxqCfHo((object) this.configurationImportInternalFactory, (object) settings), (object) this.runImportParameters);
              num2 = 12;
              continue;
            case 14:
              ContinuedImporter.JnjmhFE7rnUE3w6gCg9r((object) settings, 2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            case 15:
              num3 = ContinuedImporter.KgOFOlE7jLUslceCFU0r((object) installInfo) != Guid.Empty ? 1 : 0;
              break;
            default:
              ContinuedImporter.xnONcsE7yt52Du05U7vK((object) this.state, (object) installInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 5;
              continue;
          }
          if (num3 != 0)
            num2 = 2;
          else
            break;
        }
label_6:
        this.runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T((string) ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-2092274397 << 4 ^ 883051184)), true, true, true)
        {
          InstallInfo = installInfo
        });
        num1 = 11;
        continue;
label_11:
        lastImportMessage = this.GetLastImportMessage();
        num1 = 14;
      }
label_10:
      return this.RunImportStep2(settings, false);
label_12:
      return false;
label_19:
      return this.RunImportStep2(settings, ContinuedImporter.JqxsXKE7gumetmNDL9of((object) lastImportMessage));
    }

    /// <summary>Установить пакеты</summary>
    /// <remarks>Логика аналогична WinForm дизайнеру</remarks>
    private void InstallPackages(PackageInstallInfo installInfo)
    {
      int num = 6;
      string str;
      PackageOperationStatus packageOperationStatus;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            packageOperationStatus = (PackageOperationStatus) ContinuedImporter.JLHnNbE7U0y9DZPKId3G((object) this.deployManager, ContinuedImporter.KgOFOlE7jLUslceCFU0r((object) installInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 11 : 4;
            continue;
          case 2:
            this.runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, str));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 7 : 7;
            continue;
          case 3:
            goto label_12;
          case 5:
            ContinuedImporter.gcCbovE7LOoEqrnGGLfV((object) this.deployManager, (object) installInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
          case 6:
            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(333888594 ^ 1075625116 ^ 1409194694));
            num = 5;
            continue;
          case 7:
            goto label_4;
          case 8:
            ContinuedImporter.xvMFroE7zIrRJ7wkUvjg(1000);
            num = 4;
            continue;
          case 9:
            if (ContinuedImporter.FCvA9fE7sgbC1yY3NO7r((object) packageOperationStatus) != PackageOperationStatusType.Error)
            {
              if (packageOperationStatus.Type == PackageOperationStatusType.Completed)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 8 : 10;
                continue;
              }
              goto case 8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
          case 10:
            ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(236071375 ^ 236368713));
            num = 3;
            continue;
          case 11:
            if (packageOperationStatus == null)
            {
              num = 8;
              continue;
            }
            goto case 9;
          default:
            str = EleWise.ELMA.SR.T((string) ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-138018305 ^ -138241075), ContinuedImporter.vdy1egE7cXOrx64Hy1Na((object) packageOperationStatus));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 2;
            continue;
        }
      }
label_12:
      return;
label_4:
      throw new InvalidOperationException(str);
    }

    /// <summary>Запустить импорт данных</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="needRestart">Требуется перезагрузка</param>
    /// <returns><c>true</c>, если импорт выполнено полностью, <c>false</c>, если требуется перезагрузка и продолжение импорта</returns>
    private bool RunImportStep2(IImportSettings settings, bool needRestart)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        IDisposable isolated;
        while (true)
        {
          switch (num2)
          {
            case 1:
              isolated = ELMAContext.CreateIsolated();
              num2 = 8;
              continue;
            case 2:
label_5:
              this.GetLastImportMessage();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 6 : 0;
              continue;
            case 3:
              ContinuedImporter.ImportLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825686990));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 9;
              continue;
            case 4:
              if (ContinuedImporter.ikTwQIExFIZIaS225uro((object) settings) == 2)
              {
                num2 = 3;
                continue;
              }
              goto label_32;
            case 5:
              ContinuedImporter.iSmIGYE7D7jiMwL5tQwD((object) ContinuedImporter.ImportLog, ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(1051276242 - 990076387 ^ 60903187));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_32;
            case 7:
              goto label_9;
            case 8:
              try
              {
                CallContextSessionOwner contextSessionOwner = (CallContextSessionOwner) ContinuedImporter.NKAAPgExBPhRKjgjuMYe();
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    try
                    {
                      ContinuedImporter.WGPrtYE7lh0pKWn5QkJo(ContinuedImporter.pxOaIPE7do7JSaxqCfHo((object) this.configurationImportInternalFactory, (object) settings), (object) this.runImportParameters);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          goto label_5;
                      }
                    }
                    finally
                    {
                      if (contextSessionOwner != null)
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                          num5 = 0;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_25;
                            default:
                              contextSessionOwner.Dispose();
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
                              continue;
                          }
                        }
                      }
label_25:;
                    }
                }
              }
              finally
              {
                int num6;
                if (isolated == null)
                  num6 = 2;
                else
                  goto label_29;
label_28:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_29:
                ContinuedImporter.kfZJemExWGuM3F2mbpjG((object) isolated);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
                {
                  num6 = 0;
                  goto label_28;
                }
                else
                  goto label_28;
              }
            case 9:
              if (!needRestart)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                continue;
              }
              goto case 5;
            default:
              goto label_6;
          }
        }
label_6:
        this.runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Warn, (string) ContinuedImporter.IsZW8vE7JydepbHE9Spi(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(1319452732 ^ 1319230328)), true, true, true));
        num1 = 7;
      }
label_9:
      return false;
label_32:
      return true;
    }

    static ContinuedImporter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ContinuedImporter.UdJiXtE73WmWEDH70K3T();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ContinuedImporter.ImportLog = (ILogger) ContinuedImporter.tEBWHoExoBKAeaaJoOtY(ContinuedImporter.ro9qKGE7pAhq6BRlWS4q(-1380439818 << 3 ^ 1841677422));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void UdJiXtE73WmWEDH70K3T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RT3QsaE71u7K8yTuxpad() => ContinuedImporter.uNIkL6E7PLH8bkGtu9vY == null;

    internal static ContinuedImporter m0HbVvE7Nv3Gv5dyQRVh() => ContinuedImporter.uNIkL6E7PLH8bkGtu9vY;

    internal static object ro9qKGE7pAhq6BRlWS4q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object FggFlaE7a86HowvMXqOj([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void iSmIGYE7D7jiMwL5tQwD([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object aqs3spE7t0AEUEE7Xv3P([In] object obj0) => (object) ((IConfigImportSettings) obj0).Manifest;

    internal static object oJRPcXE7wFmeMpC8HoKa([In] object obj0) => (object) ((IConfigImportSettings) obj0).FileName;

    internal static void B2ADibE74qt13qCaL7Kh([In] object obj0) => ((List<DeployLogMessage>) obj0).Clear();

    internal static object AKGiwkE767lu2fHEWUQv([In] object obj0) => (object) ClassSerializationHelper.SerializeObject(obj0);

    internal static object DePMQGE7H6UWnyYUDXm3([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool fB9VHlE7AxiPBFuBfj3J([In] object obj0) => ((DeployLogMessage) obj0).EndProcess;

    internal static DeployLogMessageType jsuR9tE7738aUNw1jm35([In] object obj0) => ((DeployLogMessage) obj0).MessageType;

    internal static void f6rnB1E7xm2lpoUHKlIH([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void sYDc0nE700urQt96wENZ([In] object obj0, [In] object obj1) => ((IExportImportFileService) obj0).DeleteFiles((string) obj1);

    internal static object CHlN92E7m9OkX9J0wQMy([In] object obj0) => (object) ((ContinuedImportState) obj0).PackageInstallInfo;

    internal static void xnONcsE7yt52Du05U7vK([In] object obj0, [In] object obj1) => ((ContinuedImportState) obj0).PackageInstallInfo = (PackageInstallInfo) obj1;

    internal static void B40DGJE7MY06uIhcQNLN([In] object obj0, [In] object obj1, [In] object obj2) => ((IBLOBStore) obj0).Save((string) obj1, (byte[]) obj2);

    internal static object IsZW8vE7JydepbHE9Spi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object pG9D3cE793U9PP96wt2u([In] object obj0) => (object) ((DeployLogMessage) obj0).MessageText;

    internal static object pxOaIPE7do7JSaxqCfHo([In] object obj0, [In] object obj1) => (object) ((IConfigurationImportInternalFactory) obj0).CreateImporter((IImportSettings) obj1);

    internal static void WGPrtYE7lh0pKWn5QkJo([In] object obj0, [In] object obj1) => ((IConfigurationImporter) obj0).RunImport((IRunImportParameters) obj1);

    internal static void JnjmhFE7rnUE3w6gCg9r([In] object obj0, int value) => ((IImportSettings) obj0).ImportStep = value;

    internal static bool JqxsXKE7gumetmNDL9of([In] object obj0) => ((DeployLogMessage) obj0).NeedRestart;

    internal static object SqRdnSE75xNe0UafODAY([In] object obj0) => (object) ((DeployLogMessage) obj0).InstallInfo;

    internal static Guid KgOFOlE7jLUslceCFU0r([In] object obj0) => ((PackageInstallInfo) obj0).UpdatingUid;

    internal static void Kluf68E7YyMhn2A71ry1([In] object obj0, bool value) => ((ContinuedImportState) obj0).NeedToInstallPackages = value;

    internal static void gcCbovE7LOoEqrnGGLfV([In] object obj0, [In] object obj1) => ((IDeployManager) obj0).ExecutePackagesOperations((PackageInstallInfo) obj1);

    internal static object JLHnNbE7U0y9DZPKId3G([In] object obj0, Guid uid) => (object) ((IDeployManager) obj0).GetUpdatePackagesOperationsStatus(uid);

    internal static PackageOperationStatusType FCvA9fE7sgbC1yY3NO7r([In] object obj0) => ((PackageOperationStatus) obj0).Type;

    internal static object vdy1egE7cXOrx64Hy1Na([In] object obj0) => (object) ((PackageOperationStatus) obj0).Message;

    internal static void xvMFroE7zIrRJ7wkUvjg([In] int obj0) => Thread.Sleep(obj0);

    internal static int ikTwQIExFIZIaS225uro([In] object obj0) => ((IImportSettings) obj0).ImportStep;

    internal static object NKAAPgExBPhRKjgjuMYe() => (object) CallContextSessionOwner.Create();

    internal static void kfZJemExWGuM3F2mbpjG([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object tEBWHoExoBKAeaaJoOtY([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}

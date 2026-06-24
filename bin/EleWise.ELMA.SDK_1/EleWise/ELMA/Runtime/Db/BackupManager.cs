// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.BackupManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Менеджер резервного копирования</summary>
  public class BackupManager
  {
    private RuntimeConfiguration _configuration;
    private ITransformationProvider _transform;
    private readonly IStartControl startControl;
    private bool _structuresChecked;
    private static readonly ILogger BackupLog;
    private static BackupManager jdgQVyWZ0lLtfbutPa1y;

    /// <summary>
    /// Опция "Выполнять автоматическое резервное копирование" (вкл/выкл)
    /// </summary>
    public bool BackupsEnabled => BackupManager.fjNt8VWZJZxm7g36Sh1u(BackupManager.gw2NVBWZM9xqh5bgJP59((object) this._configuration));

    /// <summary>
    /// Имеется ли у провайдера БД полная поддержка автоматического резервного копирования?
    /// </summary>
    public bool FullAutoBackupSupport => this._transform.HasFullAutoBackupSupport;

    /// <summary>Была ли сделана резервная копия</summary>
    public bool BackupCreated
    {
      get => this.\u003CBackupCreated\u003Ek__BackingField;
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
              this.\u003CBackupCreated\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    /// <summary>Выполнить резервное копирование</summary>
    /// <param name="p">Параметры</param>
    /// <param name="cause">Причина</param>
    /// <param name="ignoreIfDone">Если параметр=true, то резервное копирование делается только в том случае, если оно еще не было сделано в текущем запуске сервера</param>
    public void DoBackup(BackupParameters p, string cause, bool ignoreIfDone = true)
    {
      int num1 = 10;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_48;
          case 1:
            goto label_7;
          case 2:
            this.RedirectToManualBackupPage();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 2;
            continue;
          case 3:
            this.BackupCreated = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 5;
            continue;
          case 4:
            BackupManager.BackupLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409006914));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 5:
            BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, BackupManager.imQYPvWZ9oDijLRf0wed(-606654180 ^ -606695590));
            num1 = 8;
            continue;
          case 6:
            goto label_11;
          case 7:
            BackupManager.BackupLog.Info(BackupManager.imQYPvWZ9oDijLRf0wed(964881585 - -1459193222 ^ -1870802955));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 2;
            continue;
          case 8:
            goto label_4;
          case 9:
            BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, (object) ((string) BackupManager.imQYPvWZ9oDijLRf0wed(-1445902765 ^ -1980277732 ^ 539469625) + cause));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 11;
            continue;
          case 10:
            BackupManager.BackupLog.Info(BackupManager.imQYPvWZ9oDijLRf0wed(-105199646 ^ -105153848));
            num1 = 9;
            continue;
          case 11:
            if (!this.BackupCreated)
            {
              if (!this.BackupsEnabled)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 6;
                continue;
              }
              BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, BackupManager.imQYPvWZ9oDijLRf0wed(-1886646897 ^ -1886538973));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 6 : 6;
              continue;
            }
            num1 = 4;
            continue;
          default:
            goto label_42;
        }
      }
label_48:
      return;
label_7:
      return;
label_4:
      return;
label_42:
      return;
label_11:
      try
      {
        DBStartInformation startInformation = new DBStartInformation(DatabaseConversionStage.Backup);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
          num2 = 0;
        switch (num2)
        {
          case 1:
            break;
          default:
            try
            {
              string backupPath = ((IDataBaseSettingsSection) BackupManager.gw2NVBWZM9xqh5bgJP59((object) this._configuration)).BackupPath;
              int num3 = 7;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                num3 = 7;
              while (true)
              {
                int num4;
                string str1;
                switch (num3)
                {
                  case 1:
                    goto label_35;
                  case 2:
                  case 5:
                    this.BackupCreated = true;
                    num3 = 6;
                    continue;
                  case 3:
                    ILogger backupLog = BackupManager.BackupLog;
                    object obj1 = BackupManager.imQYPvWZ9oDijLRf0wed(-787452571 ^ -787361101);
                    string str2 = backupPath;
                    string str3 = str2 == null ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583728906) : str2;
                    object obj2 = BackupManager.rfTHkcWZcGUij31AsEQM(obj1, (object) str3);
                    BackupManager.XKE9ktWZdRU5c31vBxgv((object) backupLog, obj2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                    continue;
                  case 4:
                    BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, (object) ((string) BackupManager.imQYPvWZ9oDijLRf0wed(-1978478350 ^ -1978437822) + str1));
                    num3 = 3;
                    continue;
                  case 6:
                    BackupManager.BackupInfo info = new BackupManager.BackupInfo();
                    BackupManager.kqrp4PWZUwKuNGyU1uUX((object) info, BackupManager.aCC0k2WZLCM8WbfbdCio());
                    info.Folder = backupPath;
                    BackupManager.HXZwQ1WZsmjP4GVm5aWU((object) info, (object) str1);
                    this.SaveInfo(info);
                    num3 = 12;
                    continue;
                  case 7:
                    str1 = (string) BackupManager.x5t80HWZrYnOFUekFP4W((object) this._transform, BackupManager.v2LbwaWZlRSl1pxZ40B3((object) this._configuration.MainDB), (object) backupPath);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 9 : 4;
                    continue;
                  case 8:
                    BackupManager.RVZRD5WZj1uKC9YG4vKN(BackupManager.L7opydWZ5c4h7qbRPBUQ(BackupManager.ePsVgiWZY4HbJar0Oe4F()), BackupStatus.BackupContext.DoneAutomatically);
                    num3 = 5;
                    continue;
                  case 9:
                    if (BackupManager.zb3fpgWZgRwgtZsEVr90((object) str1))
                    {
                      num4 = 11;
                      break;
                    }
                    goto case 8;
                  case 10:
                    BackupManager.RVZRD5WZj1uKC9YG4vKN(BackupManager.L7opydWZ5c4h7qbRPBUQ((object) StartInformation.Root), BackupStatus.BackupContext.DoneManually);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 2;
                    continue;
                  case 11:
                    BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, BackupManager.imQYPvWZ9oDijLRf0wed(-1824388195 ^ -1824279173));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                    continue;
                  case 12:
                    BackupManager.XKE9ktWZdRU5c31vBxgv((object) BackupManager.BackupLog, BackupManager.imQYPvWZ9oDijLRf0wed(-2138958856 ^ -2138854242));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 4;
                    continue;
                  default:
                    this.RedirectToManualBackupPage();
                    num4 = 10;
                    break;
                }
                num3 = num4;
              }
label_35:
              break;
            }
            finally
            {
              if (startInformation != null)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_37;
                    default:
                      BackupManager.ekkAYOWZzpDf0pFBgFEm((object) startInformation);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_37:;
            }
        }
      }
      catch (InvalidOperationException ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_44;
            default:
              BackupManager.wYMc6UWuFFRCtFEgFMiD((object) BackupManager.BackupLog, BackupManager.imQYPvWZ9oDijLRf0wed(1199946765 ^ 1199864911), (object) ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
          }
        }
label_44:
        throw;
      }
      catch (ArgumentNullException ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num7 = 0;
        string str4;
        string str5;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_54;
            case 2:
              str5 = (string) BackupManager.imQYPvWZ9oDijLRf0wed(~538519529 ^ -538503060);
              num7 = 3;
              continue;
            case 3:
              str4 = (string) BackupManager.imQYPvWZ9oDijLRf0wed(-1487388570 ^ -1487306508);
              num7 = 4;
              continue;
            case 4:
              BackupManager.wYMc6UWuFFRCtFEgFMiD((object) BackupManager.BackupLog, BackupManager.aB8C4vWuoNkUMCvSsoj1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541846739), (object) Environment.NewLine, (object) str5, (object) str4), (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
              continue;
            default:
              if (BackupManager.sHQZWjWuWyuxC9V55Rnv(BackupManager.PSDxhmWuBUWyROr6K2Dy((object) ex), BackupManager.imQYPvWZ9oDijLRf0wed(864270449 << 6 ^ -521151454)))
              {
                num7 = 2;
                continue;
              }
              goto label_55;
          }
        }
label_54:
        throw new InvalidOperationException(EleWise.ELMA.SR.T((string) BackupManager.imQYPvWZ9oDijLRf0wed(1304605005 ^ 1304653825), (object) str4, (object) str5));
label_55:
        throw;
      }
    }

    /// <summary>Создать структуры в БД</summary>
    /// <param name="transform"></param>
    internal void CreateDbStructures(ITransformationProvider transform, int version)
    {
      int num = 5;
      Table table;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            transform.AddTable(table);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 3;
            continue;
          case 2:
            table = new Table()
            {
              Name = (string) BackupManager.imQYPvWZ9oDijLRf0wed(277947046 - -1479185048 ^ 1757050788),
              Columns = new List<Column>()
              {
                new Column((string) BackupManager.imQYPvWZ9oDijLRf0wed(-1317790512 ^ -1317675414), DbType.DateTime),
                new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710525928), new ColumnType(DbType.String, 256)),
                new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121242857), new ColumnType(DbType.String, 256))
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          case 3:
            this._structuresChecked = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 4:
            if (!BackupManager.xlUwHgWub6vUqL1IS6OH((object) transform, BackupManager.imQYPvWZ9oDijLRf0wed(-1380439818 << 3 ^ 1841333546)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
              continue;
            }
            goto case 3;
          case 5:
            if (version == 0)
            {
              num = 4;
              continue;
            }
            goto case 3;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:;
    }

    /// <summary>Ctor</summary>
    /// <param name="configuration">Параметры конфигурации ELMA</param>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="startControl">Центр управления запуском сервера</param>
    internal BackupManager(
      [NotNull] RuntimeConfiguration configuration,
      [NotNull] ITransformationProvider transform,
      [NotNull] IStartControl startControl)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num1 = 0;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            BackupManager.K3FcvIWuhQAXNDIRR687((object) transform, BackupManager.imQYPvWZ9oDijLRf0wed(-1852837372 ^ -1852947950));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 3;
            continue;
          case 2:
            this._transform = transform;
            num2 = 5;
            break;
          case 3:
            BackupManager.K3FcvIWuhQAXNDIRR687((object) startControl, BackupManager.imQYPvWZ9oDijLRf0wed(--1360331293 ^ 1360314685));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 5;
            continue;
          case 4:
            ((BackupStatus) BackupManager.L7opydWZ5c4h7qbRPBUQ(BackupManager.ePsVgiWZY4HbJar0Oe4F())).CurrentStatus = BackupStatus.BackupContext.Unknown;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 7 : 5;
            continue;
          case 5:
            this.startControl = startControl;
            num2 = 4;
            break;
          case 6:
            this._configuration = configuration;
            num1 = 2;
            continue;
          case 7:
            goto label_4;
          default:
            BackupManager.K3FcvIWuhQAXNDIRR687((object) configuration, BackupManager.imQYPvWZ9oDijLRf0wed(1218962250 ^ 1218846792));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
            continue;
        }
        num1 = num2;
      }
label_4:;
    }

    private void SaveInfo(BackupManager.BackupInfo info)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_18;
            case 1:
              goto label_4;
            case 2:
              goto label_15;
            case 3:
              if (this._structuresChecked)
              {
                BackupManager.FKTUlMWuGiBvy5Z4IEH4((object) this._transform);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
                continue;
              }
              goto label_17;
            default:
              goto label_13;
          }
        }
label_17:
        num1 = 2;
      }
label_18:
      return;
label_15:
      return;
label_13:
      return;
label_4:
      try
      {
        BackupManager.g1rK06WuCHRCo4T6op1d((object) this._transform, BackupManager.imQYPvWZ9oDijLRf0wed(-1217523399 ^ -1217408093), (object) new string[3]
        {
          (string) BackupManager.imQYPvWZ9oDijLRf0wed(1052221104 - 768835541 ^ 283499617),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886531747),
          (string) BackupManager.imQYPvWZ9oDijLRf0wed(1218962250 ^ 1218847144)
        }, (object) new object[3]
        {
          (object) BackupManager.s8JnX5WuEgswALghPJwC((object) info),
          BackupManager.botKmeWufxgOABhGb61B((object) info),
          BackupManager.twyN12WuQys2HAOVtx8f((object) info)
        });
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_9;
            case 1:
              this._transform.CommitTransaction();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_9:
        return;
label_7:;
      }
      catch
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_3;
            case 1:
              BackupManager.IGGOWkWuv3IXxP5m1EJf((object) this._transform);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            default:
              goto label_20;
          }
        }
label_3:
        return;
label_20:;
      }
    }

    private void RedirectToManualBackupPage()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Locator.AddService<BackupManager>(this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            BackupManager.auRZ8XWu8QMeJo7uyqU1((object) this.startControl, StartStatus.BackupNeeded);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    static BackupManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BackupManager.gWenOdWuZ456s3V1mC3v();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            BackupManager.BackupLog = (ILogger) BackupManager.AYlPcWWuusVhqDP1YeiD(BackupManager.imQYPvWZ9oDijLRf0wed(825385222 ^ 825488216));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object gw2NVBWZM9xqh5bgJP59([In] object obj0) => (object) ((RuntimeConfiguration) obj0).MainDB;

    internal static bool fjNt8VWZJZxm7g36Sh1u([In] object obj0) => ((IDataBaseSettingsSection) obj0).BackupEnabled;

    internal static bool eM1SslWZmf2y4DfjuQqo() => BackupManager.jdgQVyWZ0lLtfbutPa1y == null;

    internal static BackupManager w7k3MRWZyAxyXTjRXDZ5() => BackupManager.jdgQVyWZ0lLtfbutPa1y;

    internal static object imQYPvWZ9oDijLRf0wed(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XKE9ktWZdRU5c31vBxgv([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object v2LbwaWZlRSl1pxZ40B3([In] object obj0) => (object) ((IDataBaseSettingsSection) obj0).ConnectionString;

    internal static object x5t80HWZrYnOFUekFP4W([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).BackupDatabase((string) obj1, (string) obj2);

    internal static bool zb3fpgWZgRwgtZsEVr90([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object L7opydWZ5c4h7qbRPBUQ([In] object obj0) => (object) ((StartInformation) obj0).Backup;

    internal static void RVZRD5WZj1uKC9YG4vKN([In] object obj0, BackupStatus.BackupContext value) => ((BackupStatus) obj0).CurrentStatus = value;

    internal static object ePsVgiWZY4HbJar0Oe4F() => (object) StartInformation.Root;

    internal static DateTime aCC0k2WZLCM8WbfbdCio() => DateTime.Now;

    internal static void kqrp4PWZUwKuNGyU1uUX([In] object obj0, DateTime value) => ((BackupManager.BackupInfo) obj0).BackupDate = value;

    internal static void HXZwQ1WZsmjP4GVm5aWU([In] object obj0, [In] object obj1) => ((BackupManager.BackupInfo) obj0).MainDbFileName = (string) obj1;

    internal static object rfTHkcWZcGUij31AsEQM([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void ekkAYOWZzpDf0pFBgFEm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void wYMc6UWuFFRCtFEgFMiD([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object PSDxhmWuBUWyROr6K2Dy([In] object obj0) => (object) ((ArgumentException) obj0).ParamName;

    internal static bool sHQZWjWuWyuxC9V55Rnv([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object aB8C4vWuoNkUMCvSsoj1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool xlUwHgWub6vUqL1IS6OH([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void K3FcvIWuhQAXNDIRR687([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void FKTUlMWuGiBvy5Z4IEH4([In] object obj0) => ((ITransformationProvider) obj0).BeginTransaction();

    internal static DateTime s8JnX5WuEgswALghPJwC([In] object obj0) => ((BackupManager.BackupInfo) obj0).BackupDate;

    internal static object botKmeWufxgOABhGb61B([In] object obj0) => (object) ((BackupManager.BackupInfo) obj0).Folder;

    internal static object twyN12WuQys2HAOVtx8f([In] object obj0) => (object) ((BackupManager.BackupInfo) obj0).MainDbFileName;

    internal static int g1rK06WuCHRCo4T6op1d([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3);

    internal static void IGGOWkWuv3IXxP5m1EJf([In] object obj0) => ((ITransformationProvider) obj0).RollbackTransaction();

    internal static void auRZ8XWu8QMeJo7uyqU1([In] object obj0, StartStatus suspendReason) => ((IStartControl) obj0).Suspend(suspendReason);

    internal static void gWenOdWuZ456s3V1mC3v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object AYlPcWWuusVhqDP1YeiD([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    /// <summary>Информация о резервной копии</summary>
    internal class BackupInfo
    {
      private static BackupManager.BackupInfo BfZi7OQaBHQ1wMNJNqDD;

      /// <summary>Дата/время создания резервной копии</summary>
      public DateTime BackupDate
      {
        get => this.\u003CBackupDate\u003Ek__BackingField;
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
                this.\u003CBackupDate\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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

      /// <summary>Папка с резервной копией</summary>
      public string Folder
      {
        get => this.\u003CFolder\u003Ek__BackingField;
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
                this.\u003CFolder\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

      /// <summary>Имя файла резеврной копии основной БД</summary>
      public string MainDbFileName
      {
        get => this.\u003CMainDbFileName\u003Ek__BackingField;
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
                this.\u003CMainDbFileName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

      public BackupInfo()
      {
        BackupManager.BackupInfo.EX7beaQab4BNYL5sNmFe();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool MHnfXYQaWu5AQWMrQJ0d() => BackupManager.BackupInfo.BfZi7OQaBHQ1wMNJNqDD == null;

      internal static BackupManager.BackupInfo atsECFQaoNNHLSLtcBqc() => BackupManager.BackupInfo.BfZi7OQaBHQ1wMNJNqDD;

      internal static void EX7beaQab4BNYL5sNmFe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class Db
    {
      private static object g9DqkkQahDrqeU9QoRpC;

      public Db()
      {
        BackupManager.Db.w2DhAYQafwKKQ9TXotvW();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void w2DhAYQafwKKQ9TXotvW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool ntRGGbQaG4fWtwyGGcEF() => BackupManager.Db.g9DqkkQahDrqeU9QoRpC == null;

      internal static BackupManager.Db JtgLXPQaEbfIspqJe4XB() => (BackupManager.Db) BackupManager.Db.g9DqkkQahDrqeU9QoRpC;

      /// <summary>Поля</summary>
      public static class Fields
      {
        /// <summary>Дата/время создания резервной копии</summary>
        public const string BackupDate = "BackupDate";
        /// <summary>Папка с резервной копией</summary>
        public const string Folder = "Folder";
        /// <summary>Имя файла резеврной копии основной БД</summary>
        public const string MainDbFileName = "MainDbFileName";
      }
    }
  }
}

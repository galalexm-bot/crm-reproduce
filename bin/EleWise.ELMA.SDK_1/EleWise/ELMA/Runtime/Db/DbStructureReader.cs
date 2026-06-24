// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbStructureReader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Преобразователь структуры БД</summary>
  [Service]
  public class DbStructureReader
  {
    /// <summary>Имя таблицы со структурой</summary>
    protected const string DB_STRUCTURE = "DB_STRUCTURE";
    /// <summary>Колонка "Uid" в таблице со структурой</summary>
    protected const string UID = "Uid";
    /// <summary>Колонка "Structure" в таблице со структурой</summary>
    protected const string STRUCTURE = "Structure";
    /// <summary>Колонка "UpdateDate" в таблице со структурой</summary>
    protected const string UPDATE_DATE = "UpdateDate";
    /// <summary>Таблица с историей изменения</summary>
    protected const string DB_STRUCTURE_HISTORY = "DB_STRUCTURE_HISTORY";
    private IEnumerable<DbStructure> structures;
    private IEnumerable<DbStructure> prevStructures;
    private IEnumerable<IDbUpdateHandler> handlers;
    private DbStructure currStruct;
    private DbStructure prevStruct;
    private DateTime startUpdateTime;
    private bool recreateConstraints;
    private static readonly ILogger DbUpdateLog;
    private static string quoteWrapperPattern;
    private static string quoteWrapperPatternXml;
    private DbMigrator dbMigrator;
    private static DbStructureReader r0eoZ6WVWfLB7IOcTsSF;

    /// <summary>Менеджер резервного копирования</summary>
    public BackupManager BackupManager
    {
      get => this.\u003CBackupManager\u003Ek__BackingField;
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
              this.\u003CBackupManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

    /// <summary>Прочитать структуру (выполнить преобразование БД)</summary>
    /// <param name="structures">Список структур БД</param>
    /// <param name="handlers">Список обработчиков преобразования БД</param>
    public void Read(IEnumerable<DbStructure> structures, IEnumerable<IDbUpdateHandler> handlers)
    {
      Contract.ArgumentNotNull((object) structures, z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901878913));
      Contract.ArgumentNotNull((object) handlers, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16675339));
      Contract.ArgumentNotNull((object) this.Transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765898252));
      this.structures = structures;
      this.handlers = handlers;
      this.startUpdateTime = DateTime.Now;
      Logger.Logged += new LogEventHandler(this.Logger_Logged);
      Logger.Log.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901879133));
      DbStructureReader.DbUpdateLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426172847));
      DbStructureReader.DbUpdateLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398642514), (object) VersionInfo.GetInfoVersion<EleWise.ELMA.SR>());
      // ISSUE: reference to a compiler-generated method
      IGrouping<Guid, DbStructure>[] array = structures.GroupBy<DbStructure, Guid>((System.Func<DbStructure, Guid>) (x => DbStructureReader.\u003C\u003Ec.WE6KUmQDfL9PUhgcvRyn((object) x))).Where<IGrouping<Guid, DbStructure>>((System.Func<IGrouping<Guid, DbStructure>, bool>) (x => x.Count<DbStructure>() > 1)).ToArray<IGrouping<Guid, DbStructure>>();
      if (array.Length != 0)
      {
        IDbStructureExtension[] dbStructureExtension = ComponentManager.Current.GetExtensionPoints<IDbStructureExtension>().ToArray<IDbStructureExtension>();
        string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852955108) + Environment.NewLine + string.Join(Environment.NewLine, ((IEnumerable<IGrouping<Guid, DbStructure>>) array).Select<IGrouping<Guid, DbStructure>, string>((System.Func<IGrouping<Guid, DbStructure>, string>) (d => d.Key.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317768060) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643073250), d.Select<DbStructure, string>((System.Func<DbStructure, string>) (s =>
        {
          int num = 1;
          DbStructure s1;
          while (true)
          {
            switch (num)
            {
              case 1:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_4;
              default:
                s1 = s;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 2;
                continue;
            }
          }
label_4:
          return ((IEnumerable<IDbStructureExtension>) dbStructureExtension).First<IDbStructureExtension>((System.Func<IDbStructureExtension, bool>) (f => f.Structure == s1)).GetType().FullName;
        }))))));
        DbStructureReader.DbUpdateLog.Fatal((object) message);
        throw new InvalidOperationException(message);
      }
      this.dbMigrator = new DbMigrator(this.Transform);
      this.dbMigrator.ReadDbMetadata();
      try
      {
        this.ExecuteInitialStructuresTransaction();
        StartInformation.Current.SetInfo(5.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516917106)));
        this.ExecuteInitTransaction();
        ILogger logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957788130));
        if (!this.CheckHasChanges())
        {
          StartInformation.Root.Backup.CurrentStatus = BackupStatus.BackupContext.NotNeeded;
          logger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133022191));
          Logger.Log.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867708550));
          DbStructureReader.DbUpdateLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304650799));
        }
        else
        {
          if (this.recreateConstraints)
          {
            using (new DBStartInformation(DatabaseConversionStage.StartDatabaseConversion))
            {
              logger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239658072));
              if (this.RuntimeApplication == null)
                throw new ServiceNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643714013));
              if (!this.RuntimeApplication.DbPreUpdater.BackupCreated && !this.RuntimeApplication.DbPreUpdater.IsFirstStart)
              {
                if (this.BackupManager == null)
                  throw new ServiceNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638522833));
                this.BackupManager.DoBackup(BackupParameters.OnlyMainDatabase, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712393195)));
              }
              this.RuntimeApplication.DbPreUpdater.StartUpdating();
            }
            this.ExecuteMain();
          }
          else
          {
            StartInformation.Root.Backup.CurrentStatus = BackupStatus.BackupContext.NotNeeded;
            logger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867708222));
            this.ExecuteMainInTransaction();
          }
          Logger.Log.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335080133));
          DbStructureReader.DbUpdateLog.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998495662));
        }
      }
      catch (DbStructureException ex)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597091676), (Exception) ex);
        DbStructureReader.DbUpdateLog.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082419954), (Exception) ex);
        throw;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576098226), ex);
        DbStructureReader.DbUpdateLog.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335079963), ex);
        throw new DbStructureException(ex);
      }
    }

    /// <summary>
    /// Выполнить транзакцию создания начальных структур (необходимых для инициализации)
    /// </summary>
    [Transaction]
    protected virtual void ExecuteInitialStructuresTransaction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CheckStructureVersions();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated method
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.rlHi5rQDQd77qe3egO8I((object) h)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнить транзакцию инициализации</summary>
    [Transaction]
    protected virtual void ExecuteInitTransaction()
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
              goto label_7;
            case 1:
              // ISSUE: reference to a compiler-generated field
              Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__10_0;
              Action<IDbUpdateHandler> handlerMethod;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__10_0 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.VGtmGFQDCQ9vmt1ay6Tu((object) h));
              }
              else
                goto label_10;
label_9:
              this.ExecuteHandlers(handlerMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
label_10:
              handlerMethod = action;
              goto label_9;
            case 2:
              this.prevStructures = (IEnumerable<DbStructure>) this.ReadPreviousStructures();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_3;
          }
        }
label_4:
        this.CheckActiveUpdates();
        num1 = 2;
      }
label_7:
      return;
label_3:;
    }

    /// <summary>
    /// Проверить, есть ли изменения в структурах или обработчиках (выполняется вне рамок транзакции)
    /// </summary>
    /// <returns>True, если изменения есть</returns>
    protected bool CheckHasChanges()
    {
      int num1 = 6;
      bool flag;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerator<DbStructure> enumerator1;
          IEnumerator<IDbUpdateHandler> enumerator2;
          switch (num2)
          {
            case 1:
              DbStructureReader.bb64fGWVZCMBBcY2PQUT(DbStructureReader.WHWBbBWVub1R9Z72y32y(), (object) "");
              num2 = 3;
              continue;
            case 2:
              DbStructureReader.bb64fGWVZCMBBcY2PQUT((object) Logger.Log, (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 10;
              continue;
            case 3:
              this.recreateConstraints = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 16 : 0;
              continue;
            case 4:
            case 16:
              goto label_3;
            case 5:
              IEnumerable<DbStructure> structures = this.structures;
              // ISSUE: reference to a compiler-generated field
              System.Func<DbStructure, bool> func = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__11_0;
              System.Func<DbStructure, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__11_0 = predicate = (System.Func<DbStructure, bool>) (s => !DbStructureReader.\u003C\u003Ec.Qd9EV4QDvYBgnuCBKkm7((object) s));
              }
              else
                goto label_39;
label_79:
              enumerator1 = structures.Where<DbStructure>(predicate).GetEnumerator();
              num2 = 7;
              continue;
label_39:
              predicate = func;
              goto label_79;
            case 6:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 4 : 5;
              continue;
            case 7:
              try
              {
label_11:
                if (enumerator1.MoveNext())
                  goto label_13;
                else
                  goto label_12;
label_6:
                DbStructure dbStructure;
                int num3;
                DbStructure currItem;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_13;
                    case 3:
                    case 8:
                      goto label_11;
                    case 4:
                      flag = true;
                      num3 = 12;
                      continue;
                    case 5:
                      currItem = enumerator1.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 9 : 7;
                      continue;
                    case 6:
                      if (!DbStructureReader.yp935jWVGwVVyow1A7UY(DbStructureReader.XtGRVXWVhRgOK9OXD85s((object) currItem), DbStructureReader.XtGRVXWVhRgOK9OXD85s((object) dbStructure)))
                      {
                        num3 = 3;
                        continue;
                      }
                      goto case 7;
                    case 7:
                    case 10:
                      DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1304605005 ^ 1304652137), (object) DbStructureReader.Cbl1SBWVf2WBEqNlQMH1((object) currItem));
                      num3 = 4;
                      continue;
                    case 9:
                      // ISSUE: reference to a compiler-generated method
                      dbStructure = this.prevStructures.FirstOrDefault<DbStructure>((System.Func<DbStructure, bool>) (s => s.Uid == DbStructureReader.\u003C\u003Ec__DisplayClass11_0.SSWPdgQDN1sCcQ4jRhHb((object) currItem)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 9 : 11;
                      continue;
                    case 11:
                      if (dbStructure == null)
                      {
                        num3 = 7;
                        continue;
                      }
                      goto case 6;
                    case 12:
                      this.recreateConstraints = true;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_12:
                num3 = 2;
                goto label_6;
label_13:
                num3 = 5;
                goto label_6;
              }
              finally
              {
                int num4;
                if (enumerator1 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
                else
                  goto label_22;
label_21:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_22:
                enumerator1.Dispose();
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                {
                  num4 = 0;
                  goto label_21;
                }
                else
                  goto label_21;
              }
            case 8:
              try
              {
label_68:
                if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator2))
                  goto label_61;
                else
                  goto label_69;
label_57:
                IDbUpdateHandler current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (current.HasChanges)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 4 : 3;
                        continue;
                      }
                      goto case 7;
                    case 2:
                      goto label_52;
                    case 3:
                      flag = true;
                      num5 = 7;
                      continue;
                    case 4:
                      DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16677253), (object) current);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 3;
                      continue;
                    case 5:
                      goto label_68;
                    case 6:
                      this.recreateConstraints = true;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 5 : 5;
                      continue;
                    case 7:
                      if (DbStructureReader.tb5kQ8WVvynJI14rEahG((object) current))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_68;
                    case 8:
                      goto label_61;
                    default:
                      DbStructureReader.DbUpdateLog.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123589968), (object) current);
                      num5 = 6;
                      continue;
                  }
                }
label_61:
                current = enumerator2.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                {
                  num5 = 0;
                  goto label_57;
                }
                else
                  goto label_57;
label_69:
                num5 = 2;
                goto label_57;
              }
              finally
              {
                int num6;
                if (enumerator2 == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                else
                  goto label_73;
label_72:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_73:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator2);
                num6 = 2;
                goto label_72;
              }
            case 9:
label_52:
              if (!this.recreateConstraints)
              {
                num2 = 4;
                continue;
              }
              break;
            case 10:
              DbStructureReader.bb64fGWVZCMBBcY2PQUT(DbStructureReader.WHWBbBWVub1R9Z72y32y(), DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1876063057 ^ -1876142597));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            case 11:
              DbStructureReader.WZXOMdWV8NVfBM0YG5BI((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(993438473 ^ 993489501));
              num2 = 13;
              continue;
            case 12:
label_26:
              enumerator2 = this.handlers.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 8 : 3;
              continue;
            case 13:
              goto label_29;
            case 14:
              DbStructureReader.WZXOMdWV8NVfBM0YG5BI((object) DbStructureReader.DbUpdateLog, (object) "");
              num2 = 11;
              continue;
            case 15:
              try
              {
label_36:
                if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator1))
                  goto label_34;
                else
                  goto label_37;
label_31:
                DbStructure current;
                int num7;
                DbStructure p;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                      continue;
                    case 2:
                    case 5:
                      goto label_36;
                    case 3:
                      flag = true;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 7;
                      continue;
                    case 4:
                    case 8:
                      goto label_26;
                    case 6:
                      DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1822890472 ^ -1822867900), (object) DbStructureReader.Cbl1SBWVf2WBEqNlQMH1((object) current));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 3;
                      continue;
                    case 7:
                      this.recreateConstraints = true;
                      num7 = 4;
                      continue;
                    case 9:
                      goto label_34;
                    case 10:
                      if (!this.structures.Any<DbStructure>((System.Func<DbStructure, bool>) (s =>
                      {
                        int num8 = 1;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (DbStructureReader.\u003C\u003Ec__DisplayClass11_1.cMEPcwQDwpn3iHElDS7B(DbStructureReader.\u003C\u003Ec__DisplayClass11_1.rtyCc6QDtOKJCCi72yMI((object) s), DbStructureReader.\u003C\u003Ec__DisplayClass11_1.rtyCc6QDtOKJCCi72yMI((object) p)))
                              {
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        return DbStructureReader.\u003C\u003Ec__DisplayClass11_1.mmBV5eQD4EFLY6WE9vIP((object) s);
label_3:
                        return false;
                      })))
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 2;
                        continue;
                      }
                      goto case 6;
                    default:
                      p = current;
                      num7 = 10;
                      continue;
                  }
                }
label_34:
                current = enumerator1.Current;
                num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                {
                  num7 = 1;
                  goto label_31;
                }
                else
                  goto label_31;
label_37:
                num7 = 8;
                goto label_31;
              }
              finally
              {
                int num9;
                if (enumerator1 == null)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                else
                  goto label_47;
label_46:
                switch (num9)
                {
                  case 2:
                    break;
                  default:
                }
label_47:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator1);
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                {
                  num9 = 1;
                  goto label_46;
                }
                else
                  goto label_46;
              }
            case 17:
label_4:
              enumerator1 = this.prevStructures.GetEnumerator();
              num2 = 15;
              continue;
          }
          if (EleWise.ELMA.SR.GetSetting<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306562488)))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 14 : 0;
          else
            goto label_3;
        }
label_29:
        DbStructureReader.WZXOMdWV8NVfBM0YG5BI((object) DbStructureReader.DbUpdateLog, (object) "");
        num1 = 2;
      }
label_3:
      return flag;
    }

    /// <summary>
    /// Выполнить основной набор операций по преобразованию структуры БД в единой транзациии
    /// </summary>
    [Transaction]
    protected virtual void ExecuteMainInTransaction() => DbStructureReader.tDCZPDWVI08UPJ5rPn2T((object) this);

    /// <summary>
    /// Выполнить основной набор операций по преобразованию структуры БД
    /// </summary>
    protected virtual void ExecuteMain()
    {
      int num1 = 1;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DbStructureReader.Jl68mXWVV18qdGUYdoeE((object) this.dbMigrator);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            DbStructureReader.IoVAWdWVRlNbxFai9VxE((object) this);
            num1 = 4;
            continue;
          case 3:
            DbStructureReader.cMXHEOWViMG3o02d1BLa((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 2;
            continue;
          case 4:
            startInformation = new DBStartInformation(DatabaseConversionStage.CompleteDatabaseConversion);
            num1 = 5;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_11;
          case 7:
            this.ExecuteDeleteRecreatedTransaction();
            num1 = 8;
            continue;
          case 8:
            this.ExecuteCreateTablesTransaction();
            num1 = 3;
            continue;
          default:
            DbStructureReader.vtrIE6WVSO911JqYbIcQ((object) this);
            num1 = 7;
            continue;
        }
      }
label_11:
      return;
label_2:
      try
      {
        DbStructureReader.ti41twWVqbO3SsGTYsro((object) this);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            default:
              DbStructureReader.px3wEoWVKTaSrljPnvQ1((object) this.dbMigrator);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        int num3;
        if (startInformation == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
        else
          goto label_10;
label_8:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_10:
        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
        num3 = 2;
        goto label_8;
      }
    }

    /// <summary>Выполнить транзакцию начала изменения</summary>
    [Transaction]
    protected virtual void ExecuteStart()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        DbStructureReader dbStructureReader;
        DbUpdateParameters parameters;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              this.prevStruct = DbStructure.Merge(this.prevStructures);
              num2 = 11;
              continue;
            case 2:
              this.structures.Where<DbStructure>((System.Func<DbStructure, bool>) (s =>
              {
                int num3 = 1;
                DbStructure s2;
                while (true)
                {
                  int num4 = num3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_5;
                      case 3:
                        if (s2.Deactivating)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 2;
                          continue;
                        }
                        goto label_6;
                      default:
                        goto label_8;
                    }
                  }
label_8:
                  s2 = s;
                  num3 = 3;
                }
label_5:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return dbStructureReader.prevStructures.Any<DbStructure>((System.Func<DbStructure, bool>) (s1 => DbStructureReader.\u003C\u003Ec__DisplayClass14_1.HYTNkWQDJbX40K25ACsj(s1.Uid, DbStructureReader.\u003C\u003Ec__DisplayClass14_1.JU7AxgQDMCOlBKJMibWA((object) s2))));
label_6:
                return true;
              })).ToList<DbStructure>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 2;
              continue;
            case 3:
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1290212282 ^ -644262414 ^ 1786798162));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
              continue;
            case 4:
              this.currStruct = DbStructure.Merge(this.structures);
              num2 = 3;
              continue;
            case 5:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      h.OnStart(parameters);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 6:
              this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnStart);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 8 : 10;
              continue;
            case 7:
              dbStructureReader = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 9 : 7;
              continue;
            case 8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 4;
              continue;
            case 9:
              DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-35995181 ^ -35972997));
              num2 = 2;
              continue;
            case 10:
              goto label_12;
            case 11:
              this.ProcessRemovingIndexes();
              num2 = 6;
              continue;
            default:
              goto label_15;
          }
        }
label_12:
        parameters = new DbUpdateParameters()
        {
          RecreateConstraints = this.recreateConstraints
        };
        num1 = 5;
      }
label_3:
      return;
label_15:;
    }

    /// <summary>
    /// Выполнить транзакцию, удаляющую структуры в БД, которые пересоздаются каждый раз - триггеры, процедуры, представления, индексы, внешние ключи
    /// </summary>
    [Transaction]
    protected virtual void ExecuteDeleteRecreatedTransaction()
    {
      int num1 = 2;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              this.DeleteTriggers();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_6;
              }
            }
            finally
            {
              if (startInformation != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_40;
                    default:
                      DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_40:;
            }
          case 2:
            startInformation = new DBStartInformation(DatabaseConversionStage.DeleteTriggers);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          case 3:
label_4:
            startInformation = new DBStartInformation(DatabaseConversionStage.DeletingViews);
            num1 = 4;
            continue;
          case 4:
            try
            {
              this.DeleteViews();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_2;
              }
            }
            finally
            {
              if (startInformation != null)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_16;
                    default:
                      ((IDisposable) startInformation).Dispose();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_16:;
            }
          case 5:
label_6:
            startInformation = new DBStartInformation(DatabaseConversionStage.DeletingOfProcedures);
            num1 = 10;
            continue;
          case 6:
label_2:
            if (this.recreateConstraints)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            }
            goto label_33;
          case 7:
            this.DropConstraints();
            num1 = 9;
            continue;
          case 8:
            goto label_17;
          case 9:
            goto label_38;
          case 10:
            try
            {
              this.DeleteProcedures();
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num6 = 0;
              switch (num6)
              {
                default:
                  goto label_4;
              }
            }
            finally
            {
              int num7;
              if (startInformation == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
              else
                goto label_27;
label_26:
              switch (num7)
              {
                case 1:
                case 2:
              }
label_27:
              ((IDisposable) startInformation).Dispose();
              num7 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
              {
                num7 = 0;
                goto label_26;
              }
              else
                goto label_26;
            }
          case 11:
            this.DropConstraintsSmart();
            num1 = 8;
            continue;
          default:
            if (!this.UseSmartUpdater)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 7 : 0;
              continue;
            }
            goto case 11;
        }
      }
label_17:
      return;
label_38:
      return;
label_33:;
    }

    /// <summary>Выполнить транзакцию создания таблиц БД</summary>
    [Transaction]
    protected virtual void ExecuteCreateTablesTransaction()
    {
      int num1 = 2;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_4;
          case 2:
            startInformation = new DBStartInformation(DatabaseConversionStage.TableCreation);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:
      return;
label_4:
      try
      {
        this.CreateTables();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (startInformation != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_15;
              default:
                ((IDisposable) startInformation).Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>
    /// Выполнить транзакцию удаления таблиц и колонок БД, которые были удалены в структуре
    /// </summary>
    [Transaction]
    protected virtual void ExecuteDeleteTablesTransaction()
    {
      int num1 = 1;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            startInformation = new DBStartInformation(DatabaseConversionStage.DeleteTables);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
        this.DeleteTables();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (startInformation == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
        else
          goto label_11;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        {
          num3 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <summary>
    /// Выполнить транзакцию, создающую структуры в БД, которые пересоздаются каждый раз - триггеры, процедуры, представления, индексы, внешние ключи
    /// </summary>
    [Transaction]
    protected virtual void ExecuteCreateRecreatedTransaction()
    {
      int num1 = 6;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            startInformation = new DBStartInformation(DatabaseConversionStage.CreatingViews);
            num1 = 4;
            continue;
          case 2:
label_15:
            startInformation = new DBStartInformation(DatabaseConversionStage.CreateTriggers);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 4 : 7;
            continue;
          case 3:
label_14:
            startInformation = new DBStartInformation(DatabaseConversionStage.CreationOfProcedures);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 4:
            try
            {
              this.CreateViews();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_14;
              }
            }
            finally
            {
              if (startInformation != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      ((IDisposable) startInformation).Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_25;
                  }
                }
              }
label_25:;
            }
          case 5:
            this.RecreateConstraints();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
          case 6:
            if (this.recreateConstraints)
            {
              num1 = 5;
              continue;
            }
            goto case 1;
          case 7:
            goto label_4;
          case 8:
            goto label_37;
          default:
            try
            {
              this.CreateProcedures();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_15;
              }
            }
            finally
            {
              int num5;
              if (startInformation == null)
                num5 = 2;
              else
                goto label_35;
label_33:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_35:
              DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
              {
                num5 = 0;
                goto label_33;
              }
              else
                goto label_33;
            }
        }
      }
label_37:
      return;
label_4:
      try
      {
        this.CreateTriggers();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num6 = 0;
        switch (num6)
        {
        }
      }
      finally
      {
        int num7;
        if (startInformation == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
        else
          goto label_10;
label_9:
        switch (num7)
        {
          case 1:
          case 2:
        }
label_10:
        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
        num7 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        {
          num7 = 2;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <summary>Выполнить транзакцию завершения преобразования</summary>
    [Transaction]
    protected virtual void ExecuteComplete()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_3;
            case 3:
              DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-882126494 ^ -882242748));
              num2 = 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__19_0;
              Action<IDbUpdateHandler> handlerMethod;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__19_0 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.wpMSBYQD8NrD1fGVuBc9((object) h));
              }
              else
                goto label_10;
label_9:
              this.ExecuteHandlers(handlerMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
label_10:
              handlerMethod = action;
              goto label_9;
            default:
              this.SaveCurrentStructures();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              continue;
          }
        }
label_3:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnComplete);
        num1 = 4;
      }
label_7:;
    }

    /// <summary>Провайдер трансформации БД</summary>
    public ITransformationProvider Transform
    {
      get => this.\u003CTransform\u003Ek__BackingField;
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
              this.\u003CTransform\u003Ek__BackingField = value;
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

    /// <summary>Провайдер сессии БД</summary>
    public ISessionProvider SessionProvider
    {
      get => this.\u003CSessionProvider\u003Ek__BackingField;
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
              this.\u003CSessionProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Текущая структура БД</summary>
    protected DbStructure CurrStruct => this.currStruct;

    /// <summary>Предыдущая структура БД</summary>
    protected DbStructure PrevStruct => this.prevStruct;

    /// <summary>Начало обновления</summary>
    protected DateTime StartUpdateTime => this.startUpdateTime;

    private bool UseSmartUpdater
    {
      get
      {
        int num = 1;
        bool result;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!bool.TryParse((string) DbStructureReader.LC12BxWVTLuces7IkGGZ((object) ConfigurationManager.AppSettings, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-138018305 ^ -137897075)), out result))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              result = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return result;
      }
    }

    private void Logger_Logged(LoggingEventArgs loggingEventArgs)
    {
    }

    private void ExecuteHandlers(Action<IDbUpdateHandler> handlerMethod)
    {
      foreach (IDbUpdateHandler handler in this.handlers)
      {
        DbStructureReader.DbUpdateLog.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909191673), (object) handlerMethod.Method.Name, (object) handler.GetType().FullName));
        handlerMethod(handler);
      }
    }

    /// <summary>Проверка необходимых структур в БД</summary>
    private void CheckStructureVersions()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            goto label_2;
          case 2:
            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-606654180 ^ -606671926));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
          default:
            goto label_15;
        }
      }
label_19:
      return;
label_15:
      return;
label_2:
      try
      {
        int num2;
        if (!this.Transform.TableExists((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16677385)))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
        else
          goto label_13;
label_4:
        while (true)
        {
          switch (num2)
          {
            case 1:
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~541731958 ^ -541847623));
              num2 = 4;
              continue;
            case 2:
            case 3:
              if (!DbStructureReader.TT4nT3WVOSGZA3fitOso((object) this.Transform, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16653705)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 4 : 5;
                continue;
              }
              goto case 1;
            case 4:
              goto label_10;
            case 5:
              this.Transform.AddTable(new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
              {
                Name = (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1012087039 ^ 1012040815),
                Columns = new List<Column>()
                {
                  new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1334993905 ^ -1335026429), DbType.Guid),
                  new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~1767720452 ^ -1767676421), new ColumnType(DbType.String, int.MaxValue)),
                  new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-398663332 ^ -398631430), new ColumnType(DbType.String, int.MaxValue)),
                  new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852921942), DbType.DateTime),
                  new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~538519529 ^ -538508274), DbType.DateTime)
                }
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_8;
            case 7:
              goto label_13;
            default:
              ITransformationProvider transform1 = this.Transform;
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              DbStructureReader.kvqDAfWVkSOR3ivgmmbK((object) table1, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1994213607 >> 4 ^ 124522398));
              List<Column> columnList = new List<Column>();
              Column column = new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-680446928 - -370807692 ^ -309647314), DbType.Guid);
              DbStructureReader.dISkkPWVnCOxO0VwljM9((object) column, ColumnProperty.PrimaryKey);
              columnList.Add(column);
              columnList.Add(new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1232639661 >> 3 ^ 154061305), new ColumnType(DbType.String, int.MaxValue)));
              columnList.Add(new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(589593376 ^ -1977315327 ^ -1459539869), DbType.DateTime));
              table1.Columns = columnList;
              transform1.AddTable(table1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 7;
              continue;
          }
        }
label_10:
        return;
label_8:
        ITransformationProvider transform2 = this.Transform;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
        DbStructureReader.kvqDAfWVkSOR3ivgmmbK((object) table2, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852954274));
        table2.Columns = new List<Column>()
        {
          new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-649342099 - -1150814748 ^ 501439703), DbType.Int32, ColumnProperty.PrimaryKeyWithIdentity),
          new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345467326), DbType.DateTime, ColumnProperty.NotNull),
          new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-345420348 ^ -345467292), DbType.DateTime, ColumnProperty.NotNull),
          new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-680446928 - -370807692 ^ -309683196), DbType.DateTime),
          new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1113862659 ^ 1113895813), DbType.Int16, ColumnProperty.NotNull),
          new Column((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1487388570 ^ -1487299672), new ColumnType(DbType.String, int.MaxValue)),
          new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3342338), new ColumnType(DbType.String, int.MaxValue))
        };
        DbStructureReader.snh15OWV2IG4IXekVN64((object) transform2, (object) table2);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        {
          num2 = 3;
          goto label_4;
        }
        else
          goto label_4;
label_13:
        if (DbStructureReader.TT4nT3WVOSGZA3fitOso((object) this.Transform, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87388371)))
        {
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 2;
          goto label_4;
        }
        else
          goto label_8;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_21;
            default:
              DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-688192331 - 435440695 ^ -1123589100), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
          }
        }
label_21:
        throw;
      }
    }

    /// <summary>Проверка активных изменений структуры БД</summary>
    private void CheckActiveUpdates()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_22;
          case 1:
            goto label_3;
          case 2:
            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883363482));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          default:
            goto label_18;
        }
      }
label_22:
      return;
label_18:
      return;
label_3:
      try
      {
        int num2 = 0;
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          num3 = 0;
        int num4;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ++num2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 5;
              continue;
            case 2:
              goto label_11;
            case 3:
              goto label_13;
            case 4:
            case 8:
              if (num4 <= 0)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              num4 = DbStructureReader.X8aw6XWVPjdRr5OIGREv(this.Transform.ExecuteScalar(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35971781), (Dictionary<string, object>) null));
              num3 = 7;
              continue;
            case 6:
              if (num2 >= 10)
              {
                num3 = 2;
                continue;
              }
              DbStructureReader.E51rgJWVNm24mKGU77KV(6000);
              num3 = 8;
              continue;
            case 7:
              if (num4 <= 0)
              {
                num3 = 4;
                continue;
              }
              goto case 6;
            default:
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1876063057 ^ -1876143849));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 0;
              continue;
          }
        }
label_13:
        return;
label_11:
        throw new Exception((string) DbStructureReader.WETw7WWV1OFCfFh74sto(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1597012150 ^ 1597089238)));
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 1:
              DbStructureReader.CNT2fQWV3u4r6xoJyGOR((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306561368), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            default:
              goto label_24;
          }
        }
label_24:
        throw;
      }
    }

    private DbStructure[] ReadPreviousStructures()
    {
      int num1 = 1;
      List<DbStructure> dbStructureList;
      while (true)
      {
        switch (num1)
        {
          case 1:
            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335082423));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_28;
          default:
            dbStructureList = new List<DbStructure>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      try
      {
        IDataReader dataReader = this.Transform.ExecuteQuery(string.Format((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(381945751 ^ 1158627804 ^ 1405807075), (object) ((Dialect) DbStructureReader.AIPWQaWVpLAe0SqDRHaj((object) this.Transform)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538508486)), DbStructureReader.hpH7YSWVaayuA7BGat5e(DbStructureReader.AIPWQaWVpLAe0SqDRHaj((object) this.Transform), DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1012087039 ^ 1012065263))), (Dictionary<string, object>) null);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_12:
                if (DbStructureReader.lgmbB4WVtNQsZ7AWBQS8((object) dataReader))
                  goto label_14;
                else
                  goto label_13;
label_7:
                string xml;
                DbStructure dbStructure;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_14;
                    case 2:
                      dbStructureList.Add(dbStructure);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 5 : 5;
                      continue;
                    case 3:
                      dbStructure = new DbStructure(xml, (object) null);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
                      continue;
                    case 4:
                    case 5:
                      goto label_12;
                    case 6:
                      if (xml == null)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 3;
                    default:
                      goto label_5;
                  }
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                goto label_7;
label_14:
                xml = DbStructureReader.CYsqmoWVD9SVfBJYXA6w((object) dataReader, 0) as string;
                num3 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                {
                  num3 = 1;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              finally
              {
                if (dataReader != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_21;
                      default:
                        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) dataReader);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_21:;
              }
            case 2:
              goto label_28;
          }
label_5:
          DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289763094));
          num2 = 2;
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 1:
              DbStructureReader.DbUpdateLog.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210678407), ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            default:
              goto label_26;
          }
        }
label_26:
        throw;
      }
label_28:
      return (DbStructure[]) DbStructureReader.ayjIi8WVw2pIU8FBLbFu((object) dbStructureList);
    }

    private void ProcessRemovingIndexes()
    {
      int num1 = 2;
      IEnumerator<DbStructure> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_62;
          case 1:
            IEnumerable<DbStructure> structures = this.structures;
            // ISSUE: reference to a compiler-generated field
            System.Func<DbStructure, bool> func = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__57_0;
            System.Func<DbStructure, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__57_0 = predicate = (System.Func<DbStructure, bool>) (s => !s.Deactivating);
            }
            else
              goto label_42;
label_64:
            enumerator1 = structures.Where<DbStructure>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 2;
            continue;
label_42:
            predicate = func;
            goto label_64;
          case 2:
            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1012087039 ^ 1012066303));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_58;
        }
      }
label_62:
      return;
label_58:
      return;
label_3:
      try
      {
label_30:
        if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator1))
          goto label_10;
        else
          goto label_31;
label_4:
        // ISSUE: variable of a compiler-generated type
        DbStructureReader.\u003C\u003Ec__DisplayClass57_1 cDisplayClass571;
        DbStructure dbStructure;
        // ISSUE: variable of a compiler-generated type
        DbStructureReader.\u003C\u003Ec__DisplayClass57_0 cDisplayClass570;
        IEnumerator<DbStructure.DbIndex> enumerator2;
        IEnumerator<string> enumerator3;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_49:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator2 = cDisplayClass571.prevItemIndexes.Keys.Intersect<string>((IEnumerable<string>) cDisplayClass571.currItemIndexes.Keys).Where<string>(new System.Func<string, bool>(cDisplayClass571.\u003CProcessRemovingIndexes\u003Eb__2)).Select<string, DbStructure.DbIndex>(new System.Func<string, DbStructure.DbIndex>(cDisplayClass571.\u003CProcessRemovingIndexes\u003Eb__3)).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_30;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass571.CS\u0024\u003C\u003E8__locals1 = cDisplayClass570;
              num2 = 13;
              continue;
            case 4:
              goto label_10;
            case 5:
              try
              {
label_37:
                if (enumerator3.MoveNext())
                  goto label_40;
                else
                  goto label_38;
label_33:
                string current;
                string str1;
                string str2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_49;
                    case 2:
                      goto label_40;
                    case 3:
                      goto label_37;
                    case 4:
                      // ISSUE: reference to a compiler-generated field
                      str2 = (string) DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) cDisplayClass571.prevItemIndexes[current]);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 5 : 3;
                      continue;
                    case 5:
                      DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1581325282 << 3 ^ -234291110), (object) str1, (object) str2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                      continue;
                    case 6:
                      // ISSUE: reference to a compiler-generated field
                      str1 = (string) DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) cDisplayClass571.prevItemIndexes[current]);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 4;
                      continue;
                    default:
                      DbStructureReader.hTjUAfWVHRpxtAVSou4P((object) this.dbMigrator, (object) str1, (object) str2);
                      num3 = 3;
                      continue;
                  }
                }
label_38:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                goto label_33;
label_40:
                current = enumerator3.Current;
                num3 = 5;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                {
                  num3 = 6;
                  goto label_33;
                }
                else
                  goto label_33;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_48;
                      default:
                        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator3);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_48:;
              }
            case 6:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass571.prevItemIndexes = dbStructure.Indexes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 14 : 13;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass570.\u003C\u003E4__this = this;
              num2 = 11;
              continue;
            case 8:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass571 = new DbStructureReader.\u003C\u003Ec__DisplayClass57_1();
              num2 = 3;
              continue;
            case 9:
              if (dbStructure != null)
              {
                num2 = 6;
                continue;
              }
              goto label_30;
            case 10:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              enumerator3 = cDisplayClass571.prevItemIndexes.Keys.Except<string>((IEnumerable<string>) cDisplayClass571.currItemIndexes.Keys).GetEnumerator();
              num2 = 5;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass570.currItem = enumerator1.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 8 : 7;
              continue;
            case 12:
              goto label_53;
            case 13:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              dbStructure = this.prevStructures.FirstOrDefault<DbStructure>(new System.Func<DbStructure, bool>(cDisplayClass571.CS\u0024\u003C\u003E8__locals1.\u003CProcessRemovingIndexes\u003Eb__1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 4 : 9;
              continue;
            case 14:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass571.currItemIndexes = cDisplayClass571.CS\u0024\u003C\u003E8__locals1.currItem.Indexes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 5 : 10;
              continue;
            default:
              goto label_14;
          }
        }
label_53:
        return;
label_14:
        try
        {
label_20:
          if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator2))
            goto label_18;
          else
            goto label_21;
label_16:
          int num5;
          int num6 = num5;
label_17:
          DbStructure.DbIndex current;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_20;
              case 2:
                goto label_22;
              case 3:
                DbStructureReader.hTjUAfWVHRpxtAVSou4P((object) this.dbMigrator, (object) current.Name, DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current));
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
                continue;
              case 4:
                goto label_30;
              default:
                goto label_18;
            }
          }
label_22:
          DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~210725948 ^ -210678671), DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current), DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current));
          num5 = 3;
          goto label_16;
label_18:
          current = enumerator2.Current;
          num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
          {
            num6 = 2;
            goto label_17;
          }
          else
            goto label_17;
label_21:
          num5 = 4;
          goto label_16;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num7 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
              num7 = 1;
            while (true)
            {
              switch (num7)
              {
                case 1:
                  DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator2);
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_29;
              }
            }
          }
label_29:;
        }
label_10:
        // ISSUE: object of a compiler-generated type is created
        cDisplayClass570 = new DbStructureReader.\u003C\u003Ec__DisplayClass57_0();
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        {
          num2 = 7;
          goto label_4;
        }
        else
          goto label_4;
label_31:
        num2 = 12;
        goto label_4;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_60;
              default:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator1);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_60:;
      }
    }

    private bool IsIndexChanged(DbStructure.DbIndex left, DbStructure.DbIndex right)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (left.TableName != (string) DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) right))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (DbStructureReader.rd8xBYWVAyHZcocv6QUY((object) left) == DbStructureReader.rd8xBYWVAyHZcocv6QUY((object) right))
            {
              num = 4;
              continue;
            }
            goto label_5;
          case 4:
            if (left.Columns.SequenceEqual<string>((IEnumerable<string>) right.Columns))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return DbStructureReader.yp935jWVGwVVyow1A7UY(DbStructureReader.GEZFPbWV7joBsaaOxwQl((object) left), DbStructureReader.GEZFPbWV7joBsaaOxwQl((object) right));
label_5:
      return true;
    }

    private void ExecuteIndexes()
    {
      int num1 = 3;
      Dictionary<string, DbStructure.DbIndex>.ValueCollection.Enumerator enumerator;
      List<string> list;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_35;
          case 2:
            Dictionary<string, DbStructure.DbIndex>.ValueCollection values = this.prevStruct.Indexes.Values;
            // ISSUE: reference to a compiler-generated field
            System.Func<DbStructure.DbIndex, string> func = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__59_0;
            System.Func<DbStructure.DbIndex, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__59_0 = selector = (System.Func<DbStructure.DbIndex, string>) (idx => (string) DbStructureReader.\u003C\u003Ec.fnIseEQDVnfULgDsXRVw(DbStructureReader.\u003C\u003Ec.gMobmCQDuFMkWD9j6Vvf(DbStructureReader.\u003C\u003Ec.pYoeEyQDZMHgvXgTclCI((object) idx)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978425491), (object) ((string) DbStructureReader.\u003C\u003Ec.UnJQ3fQDINu7hPKTC9H7((object) idx)).ToUpperInvariant()));
            }
            else
              goto label_14;
label_37:
            list = values.Select<DbStructure.DbIndex, string>(selector).ToList<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
label_14:
            selector = func;
            goto label_37;
          case 3:
            if (this.recreateConstraints)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
              continue;
            }
            goto label_26;
          case 4:
            goto label_3;
          case 5:
            goto label_4;
          default:
            enumerator = this.currStruct.Indexes.Values.GetEnumerator();
            num1 = 5;
            continue;
        }
      }
label_35:
      return;
label_3:
      return;
label_4:
      try
      {
label_20:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_21;
label_6:
        DbStructure.DbIndex current;
        int num2;
        while (true)
        {
          int num3;
          EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index1;
          switch (num2)
          {
            case 1:
            case 13:
              goto label_20;
            case 2:
              this.Transform.RemoveIndex((string) DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current), (string) DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current));
              num2 = 9;
              continue;
            case 3:
            case 15:
              DbStructureReader.jJIA5lWVdMmBfdeLcpfk((object) current, DbStructureReader.B9bmkkWV9OKwQBoMOKmD(DbStructureReader.GEZFPbWV7joBsaaOxwQl((object) current)));
              num2 = 11;
              continue;
            case 4:
              DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-643786247 ^ -643729123), DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current), (object) current.TableName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            case 5:
            case 10:
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123591904));
              num2 = 13;
              continue;
            case 6:
            case 7:
            case 9:
              if (!DbStructureReader.dwRtOJWVy5Dkxt1VmNvP((object) current.Text))
              {
                num2 = 3;
                continue;
              }
              goto case 18;
            case 8:
              DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(372753449 ^ 372646963), DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current), DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            case 11:
              this.dbMigrator.CreateNonStandardIndex((string) DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current), current.TableName, current.Text);
              num3 = 5;
              break;
            case 12:
              if (!list.Contains((string) DbStructureReader.Xp4MccWVmNRd7HXMJApW(DbStructureReader.N2KmpNWV0yaCegl1DxNc(DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current)), DbStructureReader.qQNj7gWVE9ZflK2e5LD6(87862435 ^ 87903429), DbStructureReader.N2KmpNWV0yaCegl1DxNc(DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current)))))
              {
                num2 = 17;
                continue;
              }
              goto case 4;
            case 14:
              goto label_30;
            case 16:
              goto label_8;
            case 17:
              DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1669212571 ^ 1669319157), DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current), DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
              continue;
            case 18:
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
              DbStructureReader.LCfn1wWVMnI3RmZGtSaI((object) index2, DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current));
              DbStructureReader.SarcmXWVJFwcSkZhPXeM((object) index2, (object) current.TableName);
              index2.Columns = current.Columns;
              index1 = index2;
              num2 = 19;
              continue;
            case 19:
              this.dbMigrator.CreateStandardIndex(index1, DbStructureReader.rd8xBYWVAyHZcocv6QUY((object) current));
              num3 = 10;
              break;
            default:
              if (!DbStructureReader.Jhj8UDWVxB9BnQIFFPCi((object) this.Transform, DbStructureReader.oIUhdYWV6SAYNFC5iR8t((object) current), DbStructureReader.aRouyRWV4nHtrPtnMWtC((object) current)))
              {
                num2 = 6;
                continue;
              }
              goto case 12;
          }
          num2 = num3;
        }
label_30:
        return;
label_8:
        current = enumerator.Current;
        num2 = 8;
        goto label_6;
label_21:
        num2 = 14;
        goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_26:;
    }

    private void ExecuteScriptsAndMethods(DbStructure.ExecuteTime executeTime)
    {
      int num = 3;
      System.Func<DbStructure.DbScript, string> scriptExecutor;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ExecuteMethods(executeTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 3 : 4;
            continue;
          case 2:
            scriptExecutor = this.GetScriptExecutor(executeTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 3:
            if (this.recreateConstraints)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            goto label_2;
          default:
            this.ExecuteScripts(executeTime, scriptExecutor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return;
label_8:;
    }

    private void ExecuteMethods(DbStructure.ExecuteTime executeTime)
    {
      int num1 = 3;
      IEnumerator<DbStructure.UserMethod> enumerator;
      DbStructure.ExecuteTime executeTime1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_28;
          case 1:
            Dictionary<string, DbStructure.UserMethod>.ValueCollection values = this.currStruct.Methods.Values;
            System.Func<DbStructure.UserMethod, bool> func;
            System.Func<DbStructure.UserMethod, bool> func1 = func;
            // ISSUE: reference to a compiler-generated method
            System.Func<DbStructure.UserMethod, bool> predicate = func1 == null ? (func = (System.Func<DbStructure.UserMethod, bool>) (m => DbStructureReader.\u003C\u003Ec__DisplayClass61_0.g1q0wMQDz34hNPKgXavE((object) m) == executeTime1)) : func1;
            enumerator = values.Where<DbStructure.UserMethod>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 4;
            continue;
          case 2:
            executeTime1 = executeTime;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_23;
        }
      }
label_28:
      return;
label_23:
      return;
label_3:
      try
      {
label_16:
        if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator))
          goto label_10;
        else
          goto label_17;
label_4:
        DbStructure.UserMethod current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.prevStruct.Methods.ContainsKey((string) DbStructureReader.TwwlJLWVgc0DAr75gQs5(DbStructureReader.rswcomWVr5UcjEfNMjCo((object) current))))
              {
                num2 = 2;
                continue;
              }
              goto label_16;
            case 2:
            case 3:
              if (DbStructureReader.eFI9SXWV5y9MWZ2nwUmQ((object) current) == null)
              {
                num2 = 7;
                continue;
              }
              goto case 9;
            case 4:
            case 7:
              this.ExecuteMethod(current);
              num2 = 5;
              continue;
            case 5:
              goto label_16;
            case 6:
              if (DbStructureReader.pSY925WVlLWy7O3BxhuW((object) current))
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 8:
              goto label_18;
            case 9:
              if (!DbStructureReader.QgKgbDWVYqba382hDJhV(DbStructureReader.p51195WVj7KGOpfGfJ25((object) this.RuntimeApplication)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 4;
                continue;
              }
              goto label_16;
            default:
              goto label_10;
          }
        }
label_18:
        return;
label_10:
        current = enumerator.Current;
        num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num2 = 6;
          goto label_4;
        }
        else
          goto label_4;
label_17:
        num2 = 8;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_25;
              default:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_25:;
      }
    }

    private void ExecuteScripts(
      DbStructure.ExecuteTime executeTime,
      System.Func<DbStructure.DbScript, string> scriptExecutionFunc)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (DbStructure.DbScript dbScript in this.currStruct.Scripts.Values.Where<DbStructure.DbScript>((System.Func<DbStructure.DbScript, bool>) (s => DbStructureReader.\u003C\u003Ec__DisplayClass62_0.boOp8QQto5YGq1wwrKPp((object) s) == executeTime)))
      {
        if ((dbScript.AlwaysExecute || !this.prevStruct.Scripts.ContainsKey(dbScript.Name.ToUpper())) && (dbScript.TransformationInVersion == null || !this.RuntimeApplication.DbPreUpdater.IsFirstStart))
        {
          DbStructureReader.DbUpdateLog.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70113677), (object) dbScript.Name));
          string str = scriptExecutionFunc(dbScript);
          string message = string.IsNullOrEmpty(str) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951523318) : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541838809), (object) str);
          DbStructureReader.DbUpdateLog.Debug((object) message);
        }
      }
    }

    private System.Func<DbStructure.DbScript, string> GetScriptExecutor(
      DbStructure.ExecuteTime executeTime)
    {
      return executeTime == DbStructure.ExecuteTime.OnIndexesCreated ? new System.Func<DbStructure.DbScript, string>(this.ExecuteScriptOnIndexesCreated) : new System.Func<DbStructure.DbScript, string>(this.ExecuteScript);
    }

    private string ExecuteScriptOnIndexesCreated(DbStructure.DbScript script)
    {
      int num1 = 1;
      string str;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
            case 7:
              goto label_4;
            case 3:
              str = (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(323422137 << 2 ^ 1293810922);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 0;
              continue;
            case 4:
              this.Transform.ExecuteNonQuery((string) DbStructureReader.nhHxwiWVLkHhCW85NNtX((object) script));
              num2 = 7;
              continue;
            case 5:
              if (index != null)
              {
                num2 = 8;
                continue;
              }
              goto case 4;
            case 6:
              goto label_10;
            case 8:
              if (this.Transform.IndexExists((string) DbStructureReader.ziTLYEWVcjvaLECfAfhV((object) index), index.Name))
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            default:
              DbStructureReader.KRD8mJWVUveLI74wiyE0((object) script, DbStructureReader.B9bmkkWV9OKwQBoMOKmD(DbStructureReader.nhHxwiWVLkHhCW85NNtX((object) script)));
              num2 = 6;
              continue;
          }
        }
label_10:
        index = (EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) DbStructureReader.LAQgoKWVs0uOvrYT2hZ7((object) this.Transform, (object) script.Text);
        num1 = 5;
      }
label_4:
      return str;
    }

    private string ExecuteScript(DbStructure.DbScript script)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Transform.ExecuteNonQuery((string) DbStructureReader.nhHxwiWVLkHhCW85NNtX((object) script));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            DbStructureReader.KRD8mJWVUveLI74wiyE0((object) script, DbStructureReader.B9bmkkWV9OKwQBoMOKmD(DbStructureReader.nhHxwiWVLkHhCW85NNtX((object) script)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
    }

    private void ExecuteMethod(DbStructure.UserMethod method)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_27;
            case 1:
              goto label_31;
            case 2:
              if (DbStructureReader.oHNl97WVztXUIpveWOA2((object) method) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
                continue;
              }
              goto label_32;
            case 3:
              goto label_4;
            case 4:
              if (!DbStructureReader.dwRtOJWVy5Dkxt1VmNvP((object) method.Method))
              {
                num2 = 3;
                continue;
              }
              goto label_18;
            default:
              goto label_15;
          }
        }
label_32:
        if (DbStructureReader.oHNl97WVztXUIpveWOA2((object) method) != null)
          num1 = 4;
        else
          goto label_22;
      }
label_27:
      return;
label_15:
      return;
label_4:
      try
      {
        int num3;
        if (!DbStructureReader.jEKjL4WSFDAZAPHgSJhu((object) DbStructureReader.DbUpdateLog))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 2;
        else
          goto label_8;
label_6:
        ISession session;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_13;
            case 1:
              DbStructureReader.np92OuWShsBlGtVeBmBn((object) session);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 1;
              continue;
            case 2:
            case 3:
              MethodInfo method1 = DbStructureReader.oHNl97WVztXUIpveWOA2((object) method).GetType().GetMethod(method.Method, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, new Type[0], (ParameterModifier[]) null);
              if (!DbStructureReader.jWh1YcWSoK1AfCojkFql((object) method1, (object) null))
              {
                session = (ISession) DbStructureReader.vuZkVVWSbue3itFK5S1J((object) this.SessionProvider, (object) "");
                method1.Invoke(DbStructureReader.oHNl97WVztXUIpveWOA2((object) method), new object[0]);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                continue;
              }
              goto label_16;
            case 4:
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.s6xWUvWSWO1qJFF6of25(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1917256330 ^ 1917247902), (object) DbStructureReader.oHNl97WVztXUIpveWOA2((object) method).GetType().FullName, (object) method.Method));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_8;
            case 6:
              if (DbStructureReader.jEKjL4WSFDAZAPHgSJhu((object) DbStructureReader.DbUpdateLog))
              {
                num3 = 4;
                continue;
              }
              goto label_7;
            default:
              goto label_3;
          }
        }
label_13:
        return;
label_3:
        return;
label_7:
        return;
label_16:
        throw new DbStructureException(string.Format((string) DbStructureReader.WETw7WWV1OFCfFh74sto((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870819095)), (object) method.MethodExecutor.GetType().FullName, DbStructureReader.Tsv21xWSBbljYeFkR0Nf((object) method)));
label_8:
        DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.s6xWUvWSWO1qJFF6of25(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1204263869 ^ -1341583247 ^ 137402004), (object) method.MethodExecutor.GetType().FullName, DbStructureReader.Tsv21xWSBbljYeFkR0Nf((object) method)));
        num3 = 2;
        goto label_6;
      }
      catch (DbStructureException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
            throw;
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num5 = 0;
        switch (num5)
        {
          default:
            throw new DbStructureException((string) DbStructureReader.s6xWUvWSWO1qJFF6of25(DbStructureReader.WETw7WWV1OFCfFh74sto(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-244066886 - -48452443 ^ -195638689)), (object) DbStructureReader.oHNl97WVztXUIpveWOA2((object) method).GetType().FullName, DbStructureReader.Tsv21xWSBbljYeFkR0Nf((object) method)), ex);
        }
      }
label_31:
      throw new DbStructureException(EleWise.ELMA.SR.T((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(333888594 ^ 1075625116 ^ 1409016562), DbStructureReader.rswcomWVr5UcjEfNMjCo((object) method)));
label_22:
      return;
label_18:;
    }

    private void DeleteTriggers()
    {
      int num1 = 4;
      TriggersDeletingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbStructureReader.\u003C\u003Ec__DisplayClass67_0.DbdxwBQtECeB6Xlict5n((object) h, (object) e);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 6;
            continue;
          case 2:
            goto label_23;
          case 3:
            e = new TriggersDeletingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 2;
            continue;
          case 5:
label_27:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTriggersDeleted);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 6:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1021410165 ^ 1021352163));
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                num3 = 0;
              List<string>.Enumerator enumerator;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_27;
                  case 2:
label_19:
                    this.Transform.RemoveTriggers((IList<string>) e.SkipNames);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 2;
                    continue;
                  case 3:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~1767720452 ^ -1767679471));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
                    continue;
                  case 4:
                    try
                    {
label_9:
                      if (enumerator.MoveNext())
                        goto label_11;
                      else
                        goto label_10;
label_7:
                      string current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195638569), (object) current));
                            num4 = 2;
                            continue;
                          case 2:
                            goto label_9;
                          case 3:
                            goto label_11;
                          default:
                            goto label_19;
                        }
                      }
label_10:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                      goto label_7;
label_11:
                      current = enumerator.Current;
                      num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                      {
                        num4 = 1;
                        goto label_7;
                      }
                      else
                        goto label_7;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                  default:
                    enumerator = e.SkipNames.GetEnumerator();
                    num3 = 4;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1350312861 << 3 ^ 2082408214), (object) ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_25;
                }
              }
label_25:
              throw;
            }
          default:
            // ISSUE: reference to a compiler-generated method
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.HqorELQDSVDgRheosaJS((object) h)));
            num1 = 2;
            continue;
        }
      }
label_23:;
    }

    private void DeleteProcedures()
    {
      int num1 = 2;
      ProceduresDeletingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            e = new ProceduresDeletingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__68_1;
            Action<IDbUpdateHandler> handlerMethod;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__68_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => h.OnProceduresDeleted());
            }
            else
              goto label_2;
label_31:
            this.ExecuteHandlers(handlerMethod);
            num1 = 6;
            continue;
label_2:
            handlerMethod = action;
            goto label_31;
          case 4:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(95909607 + 343705423 ^ 439491184));
              int num2 = 2;
              List<string>.Enumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    DbStructureReader.DbUpdateLog.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138069286));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                    continue;
                  case 2:
                    enumerator = e.SkipNames.GetEnumerator();
                    num2 = 4;
                    continue;
                  case 3:
label_17:
                    this.Transform.RemoveProcedures((IList<string>) e.SkipNames);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
                    continue;
                  case 4:
                    try
                    {
label_9:
                      if (enumerator.MoveNext())
                        goto label_11;
                      else
                        goto label_10;
label_7:
                      string current;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) string.Format((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1819636893 << 3 ^ 1672102046), (object) current));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 1;
                            continue;
                          case 2:
                            goto label_9;
                          case 3:
                            goto label_11;
                          default:
                            goto label_17;
                        }
                      }
label_10:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                      goto label_7;
label_11:
                      current = enumerator.Current;
                      num3 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                      {
                        num3 = 0;
                        goto label_7;
                      }
                      else
                        goto label_7;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                      }
                    }
                  default:
                    goto label_27;
                }
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_23;
                  default:
                    DbStructureReader.DbUpdateLog.Error(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-53329496 >> 4 ^ -3358512), ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                    continue;
                }
              }
label_23:
              throw;
            }
          case 5:
label_27:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnProceduresDeleted);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 3 : 1;
            continue;
          case 6:
            goto label_29;
          default:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbStructureReader.\u003C\u003Ec__DisplayClass68_0.Sd4gbBQt8wWb9E7lhRJp((object) h, (object) e);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 4;
            continue;
        }
      }
label_29:;
    }

    private void DeleteViews()
    {
      int num1 = 2;
      while (true)
      {
        ViewsDeletingEventArgs e;
        switch (num1)
        {
          case 1:
            e = new ViewsDeletingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 6;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_29;
          case 4:
            // ISSUE: reference to a compiler-generated field
            Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__69_1;
            Action<IDbUpdateHandler> handlerMethod;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__69_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.Y2UukKQDiDaN5pK2FSQL((object) h));
            }
            else
              goto label_2;
label_31:
            this.ExecuteHandlers(handlerMethod);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 3;
            continue;
label_2:
            handlerMethod = action;
            goto label_31;
          case 5:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-342626196 - 1290888215 ^ -1633457837));
              int num2 = 2;
              List<string>.Enumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 1:
label_20:
                    this.Transform.RemoveViews((IList<string>) e.SkipNames);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    enumerator = e.SkipNames.GetEnumerator();
                    num2 = 4;
                    continue;
                  case 3:
                    goto label_26;
                  case 4:
                    try
                    {
label_10:
                      if (enumerator.MoveNext())
                        goto label_13;
                      else
                        goto label_11;
label_9:
                      string current;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            goto label_10;
                          case 2:
                            goto label_20;
                          case 3:
                            goto label_13;
                          default:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(222162814 ^ 222038610), (object) current));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                            continue;
                        }
                      }
label_11:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
                      goto label_9;
label_13:
                      current = enumerator.Current;
                      num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                      {
                        num3 = 0;
                        goto label_9;
                      }
                      else
                        goto label_9;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                      }
                    }
                  default:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1033719030 - 2012070891 ^ -978424763));
                    num2 = 3;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_25;
                  default:
                    DbStructureReader.DbUpdateLog.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787380215), ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                    continue;
                }
              }
label_25:
              throw;
            }
          case 6:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbStructureReader.\u003C\u003Ec__DisplayClass69_0.mNtsOKQtSvtC9YS3auHV((object) h, (object) e);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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
        }
label_26:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnViewsDeleted);
        num1 = 4;
      }
label_29:;
    }

    private void DeleteIndexes()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        IndexesDeletingEventArgs e;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_5:
              this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesDeleted);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_30;
            case 3:
              e = new IndexesDeletingEventArgs();
              num2 = 6;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              try
              {
                DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-606654180 ^ -606677886));
                int num3 = 2;
                List<string>.Enumerator enumerator;
                List<string> list;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator = list.GetEnumerator();
                      num3 = 3;
                      continue;
                    case 2:
                      list = e.SkipNames.Union<string>((IEnumerable<string>) new string[1]
                      {
                        (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-244066886 - -48452443 ^ -195649695)
                      }).ToList<string>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                      continue;
                    case 3:
                      try
                      {
label_13:
                        if (enumerator.MoveNext())
                          goto label_12;
                        else
                          goto label_14;
label_10:
                        string current;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              goto label_12;
                            case 2:
                              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-218496594 ^ -218373018), (object) current));
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                              continue;
                            case 3:
                              goto label_22;
                            default:
                              goto label_13;
                          }
                        }
label_12:
                        current = enumerator.Current;
                        num4 = 2;
                        goto label_10;
label_14:
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 2;
                        goto label_10;
                      }
                      finally
                      {
                        enumerator.Dispose();
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                        }
                      }
                    case 4:
                      DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-281842504 ^ -281900716));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    case 5:
label_22:
                      this.Transform.RemoveIndexes((IList<string>) list);
                      num3 = 4;
                      continue;
                    default:
                      goto label_5;
                  }
                }
              }
              catch (Exception ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_28;
                    default:
                      DbStructureReader.DbUpdateLog.Error(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-53329496 >> 4 ^ -3358188), ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
                      continue;
                  }
                }
label_28:
                throw;
              }
            case 6:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
              {
                int num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      DbStructureReader.\u003C\u003Ec__DisplayClass70_0.eGXxWgQtXwfOxIcHj8Cn((object) h, (object) e);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 5;
              continue;
            default:
              goto label_29;
          }
        }
label_29:
        // ISSUE: reference to a compiler-generated field
        Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__70_1;
        Action<IDbUpdateHandler> handlerMethod;
        if (action == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          DbStructureReader.\u003C\u003Ec.\u003C\u003E9__70_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.irKvyTQDRQFD3XYbrUGN((object) h));
        }
        else
          goto label_26;
label_32:
        this.ExecuteHandlers(handlerMethod);
        num1 = 2;
        continue;
label_26:
        handlerMethod = action;
        goto label_32;
      }
label_30:;
    }

    private void DeleteForeignKeys()
    {
      int num1 = 3;
      while (true)
      {
        ForeginKeysDeletingEventArgs e;
        switch (num1)
        {
          case 1:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    h.OnForeignKeysDeleting(e);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 5;
            continue;
          case 2:
            e = new ForeginKeysDeletingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_30;
          case 5:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~-122002947 ^ 121927750));
              int num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                num3 = 1;
              List<string>.Enumerator enumerator;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1470440286 ^ 1470416374));
                    num3 = 3;
                    continue;
                  case 2:
                    enumerator = e.SkipNames.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_27;
                  case 4:
label_6:
                    this.Transform.RemoveForeignKeys((IList<string>) e.SkipNames);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
                    continue;
                  default:
                    try
                    {
label_11:
                      if (enumerator.MoveNext())
                        goto label_13;
                      else
                        goto label_12;
label_9:
                      string current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_11;
                          case 2:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1487388570 ^ -1487296994), (object) current));
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
                            continue;
                          case 3:
                            goto label_13;
                          default:
                            goto label_6;
                        }
                      }
label_12:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                      goto label_9;
label_13:
                      current = enumerator.Current;
                      num4 = 2;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                      {
                        num4 = 1;
                        goto label_9;
                      }
                      else
                        goto label_9;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                }
              }
            }
            catch (Exception ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    DbStructureReader.DbUpdateLog.Error(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1088304168 ^ -1088410356), ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_24;
                }
              }
label_24:
              throw;
            }
          case 6:
            // ISSUE: reference to a compiler-generated field
            Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__71_1;
            Action<IDbUpdateHandler> handlerMethod;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__71_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => h.OnForeignKeysDeleted());
            }
            else
              goto label_33;
label_32:
            this.ExecuteHandlers(handlerMethod);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 4;
            continue;
label_33:
            handlerMethod = action;
            goto label_32;
        }
label_27:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysDeleted);
        num1 = 6;
      }
label_30:;
    }

    private void DeletePrimaryKeys()
    {
      int num1 = 5;
      PrimaryKeysDeletingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_31;
          case 2:
label_27:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysDeleted);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 3:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbStructureReader.\u003C\u003Ec__DisplayClass72_0.PlFnYcQtNc0iPiP3eDkE((object) h, (object) e);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 6;
            continue;
          case 4:
            e = new PrimaryKeysDeletingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
            continue;
          case 5:
            num1 = 4;
            continue;
          case 6:
            try
            {
              DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-97972138 ^ -97978558));
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                num3 = 0;
              List<string>.Enumerator enumerator;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    enumerator = e.SkipNames.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                    continue;
                  case 2:
label_6:
                    this.Transform.RemovePrimaryKeys((IList<string>) e.SkipNames);
                    num3 = 4;
                    continue;
                  case 3:
                    goto label_27;
                  case 4:
                    DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1290212282 ^ -644262414 ^ 1786797772));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 3 : 1;
                    continue;
                  default:
                    try
                    {
label_11:
                      if (enumerator.MoveNext())
                        goto label_13;
                      else
                        goto label_12;
label_9:
                      string current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-281842504 ^ -281900048), (object) current));
                            num4 = 3;
                            continue;
                          case 2:
                            goto label_6;
                          case 3:
                            goto label_11;
                          default:
                            goto label_13;
                        }
                      }
label_12:
                      num4 = 2;
                      goto label_9;
label_13:
                      current = enumerator.Current;
                      num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                      {
                        num4 = 1;
                        goto label_9;
                      }
                      else
                        goto label_9;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                }
              }
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-2138160520 ^ -2138069540), (object) ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_26;
                }
              }
label_26:
              throw;
            }
          default:
            // ISSUE: reference to a compiler-generated field
            Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__72_1;
            Action<IDbUpdateHandler> handlerMethod;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__72_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.HttVIyQDqIyGv4HPcteM((object) h));
            }
            else
              goto label_21;
label_33:
            this.ExecuteHandlers(handlerMethod);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
            continue;
label_21:
            handlerMethod = action;
            goto label_33;
        }
      }
label_31:;
    }

    private void CreateTables()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TablesCreatingEventArgs e;
          switch (num2)
          {
            case 1:
              e = new TablesCreatingEventArgs();
              num2 = 7;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_13;
            case 4:
              try
              {
                DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(95909607 + 343705423 ^ 439491026));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(2008901894 << 3 ^ -1108697080));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_15;
                    default:
                      DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(381945751 ^ 1158627804 ^ 1405791945), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_15:
                throw;
              }
            case 5:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => h.OnTablesCreated()));
              num2 = 3;
              continue;
            case 6:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      DbStructureReader.\u003C\u003Ec__DisplayClass73_0.MKjFYBQttVvqce10AA2Z((object) h, (object) e);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 4;
              continue;
            case 7:
              goto label_4;
          }
label_16:
          this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesCreated);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 5;
        }
label_4:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesCreating);
        num1 = 6;
      }
label_13:;
    }

    private void DeleteTables()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        TablesDeletingEventArgs e;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_19;
            case 1:
              this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesDeleting);
              num2 = 6;
              continue;
            case 2:
              e = new TablesDeletingEventArgs();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            case 3:
              num2 = 2;
              continue;
            case 4:
label_3:
              this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesDeleted);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 7;
              continue;
            case 5:
              try
              {
                DbStructureReader.DbUpdateLog.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488789217));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_3;
                    default:
                      DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-53329496 >> 4 ^ -3355336));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(647913418 ^ 648001186), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_15;
                  }
                }
label_15:
                throw;
              }
            case 6:
              goto label_4;
            case 7:
              // ISSUE: reference to a compiler-generated field
              Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__74_1;
              Action<IDbUpdateHandler> handlerMethod;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__74_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => h.OnTablesDeleted());
              }
              else
                goto label_22;
label_21:
              this.ExecuteHandlers(handlerMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
label_22:
              handlerMethod = action;
              goto label_21;
            default:
              goto label_13;
          }
        }
label_4:
        this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
        {
          int num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                DbStructureReader.\u003C\u003Ec__DisplayClass74_0.fkuD5vQtAHyFVEYA6JRH((object) h, (object) e);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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
      }
label_19:
      return;
label_13:;
    }

    private void CreateForeignKeys()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        ForeignKeysCreatingEventArgs e;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            case 2:
              // ISSUE: reference to a compiler-generated field
              Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__75_1;
              Action<IDbUpdateHandler> handlerMethod;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__75_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.WO3GEKQDKbTpD5imx5tQ((object) h));
              }
              else
                goto label_7;
label_20:
              this.ExecuteHandlers(handlerMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
              continue;
label_7:
              handlerMethod = action;
              goto label_20;
            case 3:
              goto label_4;
            case 4:
              goto label_15;
            case 5:
              num2 = 4;
              continue;
            case 6:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      DbStructureReader.\u003C\u003Ec__DisplayClass75_0.srAX3oQtyLWrsq0jriUf((object) h, (object) e);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 3;
              continue;
            default:
              goto label_14;
          }
        }
label_4:
        try
        {
          DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195641169));
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_14;
              default:
                DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(--1333735954 ^ 1333713916));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
                continue;
            }
          }
        }
        catch (Exception ex)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1253244298 - 1829393894 ^ -576107074), (object) ex);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
label_13:
          throw;
        }
label_14:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysCreated);
        num1 = 2;
        continue;
label_15:
        e = new ForeignKeysCreatingEventArgs();
        num1 = 6;
      }
label_18:;
    }

    private void CreatePrimaryKeys()
    {
      int num1 = 4;
      PrimaryKeysCreatingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__76_1;
            Action<IDbUpdateHandler> handlerMethod;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbStructureReader.\u003C\u003Ec.\u003C\u003E9__76_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => h.OnPrimaryKeysCreated());
            }
            else
              goto label_8;
label_19:
            this.ExecuteHandlers(handlerMethod);
            num1 = 6;
            continue;
label_8:
            handlerMethod = action;
            goto label_19;
          case 2:
label_14:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysCreated);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
          case 3:
            e = new PrimaryKeysCreatingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 2;
            continue;
          case 5:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-812025778 ^ -812084748));
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_14;
                  default:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(516838154 ^ 516930276));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    DbStructureReader.DbUpdateLog.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312742109), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_13:
              throw;
            }
          case 6:
            goto label_17;
          default:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    h.OnPrimaryKeysCreating(e);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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
        }
      }
label_17:;
    }

    private void CreateIndexes()
    {
      int num1 = 6;
      while (true)
      {
        IndexesCreatingEventArgs e;
        switch (num1)
        {
          case 1:
            try
            {
              DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1858887263 ^ -1858974733));
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.ExecuteIndexes();
                    num2 = 2;
                    continue;
                  case 2:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(87862435 ^ 87901919));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_15;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    DbStructureReader.DbUpdateLog.Error(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-787452571 ^ -787380229), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_14;
                }
              }
label_14:
              throw;
            }
          case 2:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbStructureReader.\u003C\u003Ec__DisplayClass77_0.yokuiFQt59xj4m5I4KsB((object) h, (object) e);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.Fn8ObQQDXT4vgUhYIdhQ((object) h)));
            num1 = 4;
            continue;
          case 4:
            goto label_12;
          case 5:
            e = new IndexesCreatingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 1;
            continue;
          case 6:
            num1 = 5;
            continue;
        }
label_15:
        this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesCreated);
        num1 = 3;
      }
label_12:;
    }

    private void CreateViews()
    {
      int num1 = 1;
      ViewsCreatingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_33;
          case 3:
            // ISSUE: reference to a compiler-generated method
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.Rdc2NdQDTpAqGjsi0DDI((object) h)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
            continue;
          case 4:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    h.OnViewsCreating(e);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 4 : 5;
            continue;
          case 5:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1597012150 ^ 1597084282));
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                num3 = 1;
              Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator enumerator;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    enumerator = this.currStruct.Views.Values.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_36;
                  case 3:
label_6:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(95909607 + 343705423 ^ 439489982));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
                    continue;
                  default:
                    try
                    {
label_11:
                      if (enumerator.MoveNext())
                        goto label_16;
                      else
                        goto label_12;
label_10:
                      DbStructure.DbView current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                          case 6:
                            goto label_11;
                          case 2:
                            goto label_16;
                          case 3:
label_25:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.gYhdXMWSQHpF3bZOF9Dg(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1638402543 ^ -1638523523), (object) Array.Empty<object>()));
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 6;
                            continue;
                          case 4:
                            if (DbStructureReader.dwRtOJWVy5Dkxt1VmNvP(DbStructureReader.K2xys8WSE8CbtA3AXOrc((object) current)))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
                              continue;
                            }
                            break;
                          case 5:
                            goto label_6;
                          case 7:
                            try
                            {
                              this.Transform.ExecuteNonQuery((string) DbStructureReader.K2xys8WSE8CbtA3AXOrc((object) current));
                              int num5 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
                                num5 = 0;
                              switch (num5)
                              {
                                default:
                                  goto label_25;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num6 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                                num6 = 0;
                              switch (num6)
                              {
                                default:
                                  throw new DbStructureException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459552195), DbStructureReader.NQdqSdWSfEouMw2s6NjR((object) current)), ex);
                              }
                            }
                        }
                        DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1253244298 - 1829393894 ^ -576107178), DbStructureReader.NQdqSdWSfEouMw2s6NjR((object) current)));
                        num4 = 7;
                      }
label_12:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 5;
                      goto label_10;
label_16:
                      current = enumerator.Current;
                      num4 = 4;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                      {
                        num4 = 1;
                        goto label_10;
                      }
                      else
                        goto label_10;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num7 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                        num7 = 0;
                      switch (num7)
                      {
                        default:
                      }
                    }
                }
              }
            }
            catch (Exception ex)
            {
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                num8 = 0;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_35;
                  default:
                    DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1642859704 ^ 1642981150), (object) ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                    continue;
                }
              }
label_35:
              throw;
            }
          case 6:
label_36:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnViewsCreated);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
            continue;
          default:
            e = new ViewsCreatingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 3;
            continue;
        }
      }
label_33:;
    }

    public static string PrepareSqlText(string text)
    {
      int num1 = 2;
      ITransformationProvider transform;
      while (true)
      {
        switch (num1)
        {
          case 1:
            transform = (ITransformationProvider) DbStructureReader.kop6ooWSCKuuth5IGg1Z((object) Locator.GetServiceNotNull<IRuntimeApplication>());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) DbStructureReader.voTOt3WSvDdOt106ahrZ(DbStructureReader.voTOt3WSvDdOt106ahrZ((object) text, (object) DbStructureReader.quoteWrapperPattern, (object) (MatchEvaluator) (match =>
      {
        int num2 = 1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              str = (string) DbStructureReader.\u003C\u003Ec__DisplayClass79_0.nweqT1QwWLmbwuM4TnZ5(DbStructureReader.\u003C\u003Ec__DisplayClass79_0.Kbt20NQwFNQQnk8vCxgM((object) match), DbStructureReader.\u003C\u003Ec__DisplayClass79_0.nOQojgQwBxB51TNQiYKC(1251470110 >> 2 ^ 312510435), (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (string) DbStructureReader.\u003C\u003Ec__DisplayClass79_0.W1HdmCQwbgnjA7tmYvt7(DbStructureReader.\u003C\u003Ec__DisplayClass79_0.bccSG6Qwo4c8EqJgMXbH((object) transform), (object) str);
      })), (object) DbStructureReader.quoteWrapperPatternXml, (object) (MatchEvaluator) (match =>
      {
        int num3 = 1;
        string str;
        while (true)
        {
          switch (num3)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              str = (string) DbStructureReader.\u003C\u003Ec__DisplayClass79_0.nweqT1QwWLmbwuM4TnZ5(DbStructureReader.\u003C\u003Ec__DisplayClass79_0.Kbt20NQwFNQQnk8vCxgM((object) match), DbStructureReader.\u003C\u003Ec__DisplayClass79_0.nOQojgQwBxB51TNQiYKC(-16752921 ^ -16440373), (object) "");
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        return (string) DbStructureReader.\u003C\u003Ec__DisplayClass79_0.W1HdmCQwbgnjA7tmYvt7((object) transform.Dialect, (object) str);
      }));
    }

    private void CreateProcedures()
    {
      int num1 = 1;
      ProceduresCreatingEventArgs e;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_34;
          case 3:
            try
            {
              DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16665289));
              int num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                num2 = 1;
              Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 1:
label_30:
                    DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1113862659 ^ 1113972385));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                    continue;
                  case 2:
                    enumerator = this.currStruct.Procedures.Values.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 3;
                    continue;
                  case 3:
                    try
                    {
label_18:
                      if (enumerator.MoveNext())
                        goto label_22;
                      else
                        goto label_19;
label_9:
                      DbStructure.DbProcedure current;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 2:
                            try
                            {
                              DbStructureReader.BQdHwuWSu31ZcQtoOAEi((object) current, DbStructureReader.B9bmkkWV9OKwQBoMOKmD(DbStructureReader.chQvFoWS8wDaPfKoAh4t((object) current)));
                              int num4 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
                                num4 = 1;
                              while (true)
                              {
                                switch (num4)
                                {
                                  case 1:
                                    this.Transform.ExecuteNonQuery((string) DbStructureReader.chQvFoWS8wDaPfKoAh4t((object) current));
                                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                                    continue;
                                  default:
                                    goto label_20;
                                }
                              }
                            }
                            catch (Exception ex)
                            {
                              int num5 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                                num5 = 0;
                              switch (num5)
                              {
                                default:
                                  throw new DbStructureException(EleWise.ELMA.SR.T((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-105199646 ^ -105174058), DbStructureReader.rrAsMQWSZ1o4JBwdBils((object) current)), ex);
                              }
                            }
                          case 3:
                            if (string.IsNullOrEmpty((string) DbStructureReader.chQvFoWS8wDaPfKoAh4t((object) current)))
                            {
                              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
                              continue;
                            }
                            goto case 7;
                          case 4:
                            goto label_22;
                          case 5:
                            goto label_30;
                          case 6:
label_20:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.gYhdXMWSQHpF3bZOF9Dg(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(277947046 - -1479185048 ^ 1757043010), (object) Array.Empty<object>()));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                            continue;
                          case 7:
                            DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.MrPGydWSG16ra010xmQh(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1461825605 - 1531863589 ^ -70082016), DbStructureReader.rrAsMQWSZ1o4JBwdBils((object) current)));
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 2;
                            continue;
                          default:
                            goto label_18;
                        }
                      }
label_19:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 5 : 5;
                      goto label_9;
label_22:
                      current = enumerator.Current;
                      num3 = 3;
                      goto label_9;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                      }
                    }
                  default:
                    goto label_37;
                }
              }
            }
            catch (Exception ex)
            {
              int num7 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306573430), (object) ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_36;
                }
              }
label_36:
              throw;
            }
          case 4:
label_37:
            this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnProceduresCreated);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 5 : 6;
            continue;
          case 5:
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
            {
              int num8 = 1;
              while (true)
              {
                switch (num8)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    h.OnProceduresCreating(e);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 1;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated method
            this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.awVAsdQDkFiOHaO3lJOg((object) h)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 2;
            continue;
          default:
            e = new ProceduresCreatingEventArgs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 5;
            continue;
        }
      }
label_34:;
    }

    private void CreateTriggers()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        TriggersCreatingEventArgs e;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              Action<IDbUpdateHandler> action = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__81_1;
              Action<IDbUpdateHandler> handlerMethod;
              if (action == null)
              {
                // ISSUE: reference to a compiler-generated field
                DbStructureReader.\u003C\u003Ec.\u003C\u003E9__81_1 = handlerMethod = (Action<IDbUpdateHandler>) (h => h.OnTriggersCreated());
              }
              else
                goto label_29;
label_43:
              this.ExecuteHandlers(handlerMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 4 : 4;
              continue;
label_29:
              handlerMethod = action;
              goto label_43;
            case 2:
              try
              {
                DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1505778440 - 1981636111 ^ -475852289));
                int num3 = 3;
                while (true)
                {
                  int num4 = num3;
                  Dictionary<string, DbStructure.DbTrigger>.ValueCollection.Enumerator enumerator;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_8;
                      case 2:
                        goto label_37;
                      case 3:
                        enumerator = this.currStruct.Triggers.Values.GetEnumerator();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_31;
                    }
                  }
label_8:
                  try
                  {
label_22:
                    if (enumerator.MoveNext())
                      goto label_11;
                    else
                      goto label_23;
label_9:
                    DbStructure.DbTrigger current;
                    int num5;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_31;
                        case 2:
                          goto label_22;
                        case 3:
label_21:
                          DbStructureReader.DbUpdateLog.Debug(DbStructureReader.gYhdXMWSQHpF3bZOF9Dg(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(2008901894 << 3 ^ -1108695658), (object) Array.Empty<object>()));
                          num5 = 2;
                          continue;
                        case 4:
                          try
                          {
                            DbStructureReader.bmFDcTWSSwcH2JGFp2h3((object) current, (object) DbStructureReader.PrepareSqlText((string) DbStructureReader.RTQBRlWSIAfxFmB3fyMj((object) current)));
                            int num6 = 1;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                              num6 = 0;
                            while (true)
                            {
                              switch (num6)
                              {
                                case 1:
                                  this.Transform.ExecuteNonQuery(current.Text);
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_21;
                              }
                            }
                          }
                          catch (Exception ex)
                          {
                            int num7 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
                              num7 = 0;
                            switch (num7)
                            {
                              default:
                                throw new DbStructureException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979425500), DbStructureReader.G8hvSGWSVQoJjNL8oLZH((object) current)), ex);
                            }
                          }
                        case 5:
                          goto label_11;
                        case 6:
                          DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154075111), DbStructureReader.G8hvSGWSVQoJjNL8oLZH((object) current)));
                          num5 = 4;
                          continue;
                        default:
                          if (!string.IsNullOrEmpty((string) DbStructureReader.RTQBRlWSIAfxFmB3fyMj((object) current)))
                          {
                            num5 = 6;
                            continue;
                          }
                          goto label_22;
                      }
                    }
label_11:
                    current = enumerator.Current;
                    num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                    {
                      num5 = 0;
                      goto label_9;
                    }
                    else
                      goto label_9;
label_23:
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                    goto label_9;
                  }
                  finally
                  {
                    enumerator.Dispose();
                    int num8 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                      num8 = 0;
                    switch (num8)
                    {
                      default:
                    }
                  }
label_31:
                  DbStructureReader.vEngZXWVXBHFkCJQvB0J((object) DbStructureReader.DbUpdateLog, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1304605005 ^ 1304648837));
                  num3 = 2;
                }
              }
              catch (Exception ex)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_36;
                    default:
                      DbStructureReader.NmJ0pdWVeVpyHmlZi50C((object) DbStructureReader.DbUpdateLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516931326), (object) ex);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_36:
                throw;
              }
            case 3:
label_37:
              this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTriggersCreated);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
              continue;
            case 4:
              goto label_41;
            case 5:
              e = new TriggersCreatingEventArgs();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_39;
            default:
              this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
              {
                int num10 = 1;
                while (true)
                {
                  switch (num10)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      DbStructureReader.\u003C\u003Ec__DisplayClass81_0.bBwuhFQw8sGQLYTOiaLq((object) h, (object) e);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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
          }
        }
label_39:
        num1 = 5;
      }
label_41:;
    }

    private void SaveCurrentStructures()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_32;
          case 1:
            goto label_2;
          case 2:
            DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(654297945 ^ 654189949));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
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
        IEnumerator<DbStructure> enumerator = this.structures.GetEnumerator();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_25;
            case 1:
              try
              {
label_15:
                if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator))
                  goto label_14;
                else
                  goto label_16;
label_7:
                DbStructure current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 3:
                    case 4:
                    case 11:
                      goto label_15;
                    case 2:
                      this.Transform.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979261151), new string[2]
                      {
                        (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(372753449 ^ 372645637),
                        z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561023450)
                      }, new object[2]
                      {
                        DbStructureReader.XtGRVXWVhRgOK9OXD85s((object) current),
                        (object) this.startUpdateTime
                      }, (string) DbStructureReader.s6xWUvWSWO1qJFF6of25(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1819636893 << 3 ^ 1672104506), DbStructureReader.hpH7YSWVaayuA7BGat5e(DbStructureReader.AIPWQaWVpLAe0SqDRHaj((object) this.Transform), DbStructureReader.qQNj7gWVE9ZflK2e5LD6(~289714581 ^ -289725960)), (object) this.Transform.ParameterSeparator), new Dictionary<string, object>()
                      {
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787381341),
                          (object) DbStructureReader.Cbl1SBWVf2WBEqNlQMH1((object) current)
                        }
                      });
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
                      continue;
                    case 5:
                      DbStructureReader.fBCEftWSq7437Fw6biMV((object) this.Transform, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61083391), (object) new string[3]
                      {
                        (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-867826612 ^ -867800098),
                        (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-688192331 - 435440695 ^ -1123589294),
                        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939428914)
                      }, (object) new object[3]
                      {
                        (object) DbStructureReader.Cbl1SBWVf2WBEqNlQMH1((object) current),
                        (object) current.Xml,
                        (object) this.startUpdateTime
                      });
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 4 : 2;
                      continue;
                    case 6:
                      if (!current.Deactivating)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 2;
                        continue;
                      }
                      goto case 10;
                    case 7:
                      if (DbStructureReader.X8aw6XWVPjdRr5OIGREv(this.Transform.ExecuteScalar((string) DbStructureReader.s6xWUvWSWO1qJFF6of25(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(236071375 ^ 236177299), DbStructureReader.hpH7YSWVaayuA7BGat5e(DbStructureReader.AIPWQaWVpLAe0SqDRHaj((object) this.Transform), DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1088304168 ^ -1088314294)), DbStructureReader.ldjpNOWSiVU6CkP9Dvm7((object) this.Transform)), new Dictionary<string, object>()
                      {
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420865568),
                          (object) current.Uid
                        }
                      })) <= 0)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 6;
                    case 8:
                      goto label_14;
                    case 9:
                      goto label_5;
                    case 10:
                      this.Transform.ExecuteNonQuery((string) DbStructureReader.U8YZ4NWSKupDxyyfsMs8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740377800), DbStructureReader.hpH7YSWVaayuA7BGat5e((object) this.Transform.Dialect, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(--1418440330 ^ 1418360218)), DbStructureReader.hpH7YSWVaayuA7BGat5e((object) this.Transform.Dialect, DbStructureReader.qQNj7gWVE9ZflK2e5LD6(95909607 + 343705423 ^ 439587236)), DbStructureReader.ldjpNOWSiVU6CkP9Dvm7((object) this.Transform)), new Dictionary<string, object>()
                      {
                        {
                          (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1597012150 ^ 1597085296),
                          (object) DbStructureReader.Cbl1SBWVf2WBEqNlQMH1((object) current)
                        }
                      });
                      num3 = 11;
                      continue;
                    default:
                      if (DbStructureReader.UGn2CYWSRIqGHv5uqa05((object) current))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 0;
                        continue;
                      }
                      goto case 5;
                  }
                }
label_14:
                current = enumerator.Current;
                num3 = 7;
                goto label_7;
label_16:
                num3 = 9;
                goto label_7;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_27;
                      default:
                        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_27:;
              }
            case 2:
label_5:
              DbStructureReader.DbUpdateLog.Debug(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1290212282 ^ -644262414 ^ 1786795654));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_20;
          }
        }
label_25:
        return;
label_20:;
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              DbStructureReader.DbUpdateLog.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867177729), ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_34;
          }
        }
label_34:
        throw;
      }
    }

    private void DropConstraints()
    {
      int num1 = 2;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              this.DeleteForeignKeys();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                num2 = 0;
              switch (num2)
              {
              }
            }
            finally
            {
              int num3;
              if (startInformation == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              else
                goto label_19;
label_17:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_19:
              DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
              {
                num3 = 1;
                goto label_17;
              }
              else
                goto label_17;
            }
            break;
          case 2:
            startInformation = new DBStartInformation(DatabaseConversionStage.DeletingForeignKeys);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_21;
        }
        startInformation = new DBStartInformation(DatabaseConversionStage.IndexRemoval);
        num1 = 3;
      }
label_21:
      return;
label_2:
      try
      {
        this.DeleteIndexes();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        int num5;
        if (startInformation == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
        else
          goto label_8;
label_7:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_8:
        ((IDisposable) startInformation).Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        {
          num5 = 0;
          goto label_7;
        }
        else
          goto label_7;
      }
    }

    private void DropConstraintsSmart()
    {
      int num1 = 2;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_29;
          case 1:
            goto label_2;
          case 2:
            startInformation = new DBStartInformation(DatabaseConversionStage.SmartDeleteKeysAndIndexes);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          default:
            goto label_28;
        }
      }
label_29:
      return;
label_28:
      return;
label_2:
      try
      {
        this.ProcessDbActions();
        int num2 = 8;
        while (true)
        {
          int num3 = num2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysDeleted);
                num3 = 2;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated method
                this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.HttVIyQDqIyGv4HPcteM((object) h)));
                num3 = 9;
                continue;
              case 3:
                this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesDeleted);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 6;
                continue;
              case 4:
                this.ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysDeleted);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                Action<IDbUpdateHandler> action1 = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_0;
                Action<IDbUpdateHandler> handlerMethod1;
                if (action1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_0 = handlerMethod1 = (Action<IDbUpdateHandler>) (h =>
                  {
                    int num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          DbStructureReader.\u003C\u003Ec.Ti038QQDn7yWENILJTEp((object) h, (object) new ForeginKeysDeletingEventArgs());
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                }
                else
                  goto label_35;
label_14:
                this.ExecuteHandlers(handlerMethod1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 4;
                continue;
label_35:
                handlerMethod1 = action1;
                goto label_14;
              case 6:
                DbStructureReader.ijKR2oWSk8pqf0HX2Z3y((object) this.dbMigrator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 8 : 10;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated method
                this.ExecuteHandlers((Action<IDbUpdateHandler>) (h => DbStructureReader.\u003C\u003Ec.irKvyTQDRQFD3XYbrUGN((object) h)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 7 : 11;
                continue;
              case 8:
                goto label_11;
              case 9:
                goto label_22;
              case 10:
                this.dbMigrator.OnIndexesDropped();
                num3 = 5;
                continue;
              case 11:
                goto label_24;
              case 12:
                // ISSUE: reference to a compiler-generated field
                Action<IDbUpdateHandler> action2 = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_2;
                Action<IDbUpdateHandler> handlerMethod2;
                if (action2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_2 = handlerMethod2 = (Action<IDbUpdateHandler>) (h =>
                  {
                    int num5 = 1;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          DbStructureReader.\u003C\u003Ec.mY48P1QDOp52mioaJVjE((object) h, (object) new PrimaryKeysDeletingEventArgs());
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                }
                else
                  goto label_36;
label_20:
                this.ExecuteHandlers(handlerMethod2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                continue;
label_36:
                handlerMethod2 = action2;
                goto label_20;
              case 13:
                DbStructureReader.bivHOTWSTUqTk65Jwo15((object) this.dbMigrator);
                num3 = 6;
                continue;
              default:
                // ISSUE: reference to a compiler-generated field
                Action<IDbUpdateHandler> action3 = DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_1;
                Action<IDbUpdateHandler> handlerMethod3;
                if (action3 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DbStructureReader.\u003C\u003Ec.\u003C\u003E9__84_1 = handlerMethod3 = (Action<IDbUpdateHandler>) (h => h.OnForeignKeysDeleted());
                }
                else
                  goto label_34;
label_17:
                this.ExecuteHandlers(handlerMethod3);
                num3 = 12;
                continue;
label_34:
                handlerMethod3 = action3;
                goto label_17;
            }
          }
label_11:
          DbStructureReader.r34NbYWSXnxinGgcW8JP((object) this.dbMigrator);
          num2 = 13;
          continue;
label_22:
          this.ExecuteHandlers((Action<IDbUpdateHandler>) (h =>
          {
            int num6 = 1;
            while (true)
            {
              switch (num6)
              {
                case 0:
                  goto label_2;
                case 1:
                  h.OnIndexesDeleting(new IndexesDeletingEventArgs());
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          num2 = 3;
        }
label_24:;
      }
      finally
      {
        int num7;
        if (startInformation == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 1;
        else
          goto label_30;
label_27:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_30:
        DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        {
          num7 = 0;
          goto label_27;
        }
        else
          goto label_27;
      }
    }

    private void RecreateConstraints()
    {
      int num1 = 4;
      DBStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_22;
          case 3:
            try
            {
              this.CreateForeignKeys();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                num2 = 0;
              switch (num2)
              {
              }
            }
            finally
            {
              if (startInformation != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_24;
                    default:
                      DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_24:;
            }
            break;
          case 4:
            startInformation = new DBStartInformation(DatabaseConversionStage.CreatingForeignKeys);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 3;
            continue;
        }
        startInformation = new DBStartInformation(DatabaseConversionStage.IndexCreation);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
      }
label_22:
      return;
label_2:
      try
      {
        this.CreateIndexes();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        if (startInformation != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_10;
              default:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) startInformation);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_10:;
      }
    }

    private void ProcessDbActions()
    {
      int num1 = 5;
      IEnumerator<DbDeleteColumnAction> enumerator1;
      IEnumerator<DbRenameColumnAction> enumerator2;
      IDbAction[] array;
      IEnumerator<DbDeleteTableAction> enumerator3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_44;
          case 1:
            goto label_16;
          case 2:
label_30:
            enumerator2 = array.OfType<DbRenameColumnAction>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
          case 3:
            try
            {
label_6:
              if (DbStructureReader.yE55KhWVQpOIplEmPfQY((object) enumerator1))
                goto label_4;
              else
                goto label_7;
label_3:
              DbDeleteColumnAction current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_4;
                  case 2:
                    DbStructureReader.DbUpdateLog.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901884331), (object) current.ColumnName, DbStructureReader.T0vVt7WSOUI0PPZ9Gj2b((object) current));
                    num2 = 4;
                    continue;
                  case 3:
                    goto label_30;
                  case 4:
                    this.dbMigrator.MarkTouchedDbMetadata((string) DbStructureReader.L85xslWS2LvCGV8eXA6W((object) current), current.ColumnName);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_6;
                }
              }
label_4:
              current = enumerator1.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              {
                num2 = 2;
                goto label_3;
              }
              else
                goto label_3;
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 0;
              goto label_3;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_15;
                  }
                }
              }
label_15:;
            }
          case 4:
            enumerator3 = array.OfType<DbDeleteTableAction>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 6;
            continue;
          case 5:
            array = this.handlers.OfType<IActionsHolder>().SelectMany<IActionsHolder, IDbAction>((System.Func<IActionsHolder, IEnumerable<IDbAction>>) (a => a.TablesCreatedActions.Concat<IDbAction>((IEnumerable<IDbAction>) a.TablesDeletedActions))).ToArray<IDbAction>();
            num1 = 4;
            continue;
          case 6:
            try
            {
label_37:
              if (enumerator3.MoveNext())
                goto label_35;
              else
                goto label_38;
label_32:
              DbDeleteTableAction current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_47;
                  case 2:
                    this.dbMigrator.MarkTouchedDbMetadata((string) DbStructureReader.ix0152WSnPtOOPY1G4BL((object) current));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1021410165 ^ 1021351133), (object) current.TableName);
                    num4 = 2;
                    continue;
                  case 4:
                    goto label_35;
                  default:
                    goto label_37;
                }
              }
label_35:
              current = enumerator3.Current;
              num4 = 3;
              goto label_32;
label_38:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
              goto label_32;
            }
            finally
            {
              if (enumerator3 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator3);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_46;
                  }
                }
              }
label_46:;
            }
          case 7:
label_47:
            enumerator1 = array.OfType<DbDeleteColumnAction>().GetEnumerator();
            num1 = 3;
            continue;
          default:
            goto label_39;
        }
      }
label_44:
      return;
label_39:
      return;
label_16:
      try
      {
label_22:
        if (enumerator2.MoveNext())
          goto label_19;
        else
          goto label_23;
label_17:
        DbRenameColumnAction current;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_33;
            case 2:
              this.dbMigrator.MarkTouchedDbMetadata((string) DbStructureReader.VbEi8cWS155L8YNyo4DC((object) current), (string) DbStructureReader.FXgZi7WSefedAhug9OXe((object) current));
              num6 = 4;
              continue;
            case 3:
              DbStructureReader.DbUpdateLog.DebugFormat((string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-398663332 ^ -398651058), DbStructureReader.FXgZi7WSefedAhug9OXe((object) current), DbStructureReader.MGhEB1WSP7ZBVnYZfqbb((object) current), (object) current.TableName);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 0;
              continue;
            case 4:
              goto label_22;
            default:
              goto label_19;
          }
        }
label_33:
        return;
label_19:
        current = enumerator2.Current;
        num6 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        {
          num6 = 3;
          goto label_17;
        }
        else
          goto label_17;
label_23:
        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
        goto label_17;
      }
      finally
      {
        if (enumerator2 != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_29;
              default:
                DbStructureReader.RgLq98WVCgqwvpENPdQm((object) enumerator2);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_29:;
      }
    }

    public DbStructureReader()
    {
      DbStructureReader.KFBJ6qWSNF4K5juJe7s7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DbStructureReader()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DbStructureReader.quoteWrapperPattern = (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852964212);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              DbStructureReader.DbUpdateLog = (ILogger) DbStructureReader.im1MPOWS3pOQoONscpqI(DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1654249598 >> 2 ^ 413632115));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
            case 4:
              goto label_7;
            default:
              DbStructureReader.quoteWrapperPatternXml = (string) DbStructureReader.qQNj7gWVE9ZflK2e5LD6(1242972401 >> 4 ^ 77632661);
              num2 = 2;
              continue;
          }
        }
label_7:
        DbStructureReader.KFBJ6qWSNF4K5juJe7s7();
        num1 = 3;
      }
label_3:;
    }

    internal static bool KYSnw1WVoFHdVP6Cpucr() => DbStructureReader.r0eoZ6WVWfLB7IOcTsSF == null;

    internal static DbStructureReader zpnK5FWVbe2L5MMvuxfM() => DbStructureReader.r0eoZ6WVWfLB7IOcTsSF;

    internal static object XtGRVXWVhRgOK9OXD85s([In] object obj0) => (object) ((DbStructure) obj0).Xml;

    internal static bool yp935jWVGwVVyow1A7UY([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object qQNj7gWVE9ZflK2e5LD6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid Cbl1SBWVf2WBEqNlQMH1([In] object obj0) => ((DbStructure) obj0).Uid;

    internal static bool yE55KhWVQpOIplEmPfQY([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void RgLq98WVCgqwvpENPdQm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool tb5kQ8WVvynJI14rEahG([In] object obj0) => ((IDbUpdateHandler) obj0).NeedRecreateConstraints;

    internal static void WZXOMdWV8NVfBM0YG5BI([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void bb64fGWVZCMBBcY2PQUT([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object WHWBbBWVub1R9Z72y32y() => (object) Logger.Log;

    internal static void tDCZPDWVI08UPJ5rPn2T([In] object obj0) => ((DbStructureReader) obj0).ExecuteMain();

    internal static void Jl68mXWVV18qdGUYdoeE([In] object obj0) => ((DbMigrator) obj0).OnMigrationStart();

    internal static void vtrIE6WVSO911JqYbIcQ([In] object obj0) => ((DbStructureReader) obj0).ExecuteStart();

    internal static void cMXHEOWViMG3o02d1BLa([In] object obj0) => ((DbStructureReader) obj0).ExecuteDeleteTablesTransaction();

    internal static void IoVAWdWVRlNbxFai9VxE([In] object obj0) => ((DbStructureReader) obj0).ExecuteCreateRecreatedTransaction();

    internal static void ti41twWVqbO3SsGTYsro([In] object obj0) => ((DbStructureReader) obj0).ExecuteComplete();

    internal static void px3wEoWVKTaSrljPnvQ1([In] object obj0) => ((DbMigrator) obj0).OnMigrationEnd();

    internal static void vEngZXWVXBHFkCJQvB0J([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static object LC12BxWVTLuces7IkGGZ([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static void kvqDAfWVkSOR3ivgmmbK([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name = (string) obj1;

    internal static void dISkkPWVnCOxO0VwljM9([In] object obj0, ColumnProperty value) => ((Column) obj0).ColumnProperty = value;

    internal static bool TT4nT3WVOSGZA3fitOso([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void snh15OWV2IG4IXekVN64([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj1);

    internal static void NmJ0pdWVeVpyHmlZi50C([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static int X8aw6XWVPjdRr5OIGREv([In] object obj0) => Convert.ToInt32(obj0);

    internal static object WETw7WWV1OFCfFh74sto([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void E51rgJWVNm24mKGU77KV([In] int obj0) => Thread.Sleep(obj0);

    internal static void CNT2fQWV3u4r6xoJyGOR([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Debug(obj1, (Exception) obj2);

    internal static object AIPWQaWVpLAe0SqDRHaj([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object hpH7YSWVaayuA7BGat5e([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object CYsqmoWVD9SVfBJYXA6w([In] object obj0, [In] int obj1) => ((IDataRecord) obj0)[obj1];

    internal static bool lgmbB4WVtNQsZ7AWBQS8([In] object obj0) => ((IDataReader) obj0).Read();

    internal static object ayjIi8WVw2pIU8FBLbFu([In] object obj0) => (object) ((List<DbStructure>) obj0).ToArray();

    internal static object aRouyRWV4nHtrPtnMWtC([In] object obj0) => (object) ((DbStructure.DbIndex) obj0).Name;

    internal static object oIUhdYWV6SAYNFC5iR8t([In] object obj0) => (object) ((DbStructure.DbIndex) obj0).TableName;

    internal static void hTjUAfWVHRpxtAVSou4P([In] object obj0, [In] object obj1, [In] object obj2) => ((DbMigrator) obj0).MarkDroppingIndex((string) obj1, (string) obj2);

    internal static bool rd8xBYWVAyHZcocv6QUY([In] object obj0) => ((DbStructure.DbIndex) obj0).IsUnique;

    internal static object GEZFPbWV7joBsaaOxwQl([In] object obj0) => (object) ((DbStructure.DbIndex) obj0).Text;

    internal static bool Jhj8UDWVxB9BnQIFFPCi([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).IndexExists((string) obj1, (string) obj2);

    internal static object N2KmpNWV0yaCegl1DxNc([In] object obj0) => (object) ((string) obj0).ToUpperInvariant();

    internal static object Xp4MccWVmNRd7HXMJApW([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool dwRtOJWVy5Dkxt1VmNvP([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void LCfn1wWVMnI3RmZGtSaI([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static void SarcmXWVJFwcSkZhPXeM([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static object B9bmkkWV9OKwQBoMOKmD([In] object obj0) => (object) DbStructureReader.PrepareSqlText((string) obj0);

    internal static void jJIA5lWVdMmBfdeLcpfk([In] object obj0, [In] object obj1) => ((DbStructure.DbIndex) obj0).Text = (string) obj1;

    internal static bool pSY925WVlLWy7O3BxhuW([In] object obj0) => ((DbStructure.UserMethod) obj0).AlwaysExecute;

    internal static object rswcomWVr5UcjEfNMjCo([In] object obj0) => (object) ((DbStructure.UserMethod) obj0).Name;

    internal static object TwwlJLWVgc0DAr75gQs5([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static object eFI9SXWV5y9MWZ2nwUmQ([In] object obj0) => (object) ((DbStructure.UserMethod) obj0).TransformationInVersion;

    internal static object p51195WVj7KGOpfGfJ25([In] object obj0) => (object) ((IRuntimeApplication) obj0).DbPreUpdater;

    internal static bool QgKgbDWVYqba382hDJhV([In] object obj0) => ((DbPreUpdater) obj0).IsFirstStart;

    internal static object nhHxwiWVLkHhCW85NNtX([In] object obj0) => (object) ((DbStructure.DbScript) obj0).Text;

    internal static void KRD8mJWVUveLI74wiyE0([In] object obj0, [In] object obj1) => ((DbStructure.DbScript) obj0).Text = (string) obj1;

    internal static object LAQgoKWVs0uOvrYT2hZ7([In] object obj0, [In] object obj1) => (object) ((ITransformationProvider) obj0).GetIndexInfoFromStatement((string) obj1);

    internal static object ziTLYEWVcjvaLECfAfhV([In] object obj0) => (object) ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName;

    internal static object oHNl97WVztXUIpveWOA2([In] object obj0) => ((DbStructure.UserMethod) obj0).MethodExecutor;

    internal static bool jEKjL4WSFDAZAPHgSJhu([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object Tsv21xWSBbljYeFkR0Nf([In] object obj0) => (object) ((DbStructure.UserMethod) obj0).Method;

    internal static object s6xWUvWSWO1qJFF6of25([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool jWh1YcWSoK1AfCojkFql([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object vuZkVVWSbue3itFK5S1J([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void np92OuWShsBlGtVeBmBn([In] object obj0) => ((ISession) obj0).Flush();

    internal static object MrPGydWSG16ra010xmQh([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object K2xys8WSE8CbtA3AXOrc([In] object obj0) => (object) ((DbStructure.DbView) obj0).Text;

    internal static object NQdqSdWSfEouMw2s6NjR([In] object obj0) => (object) ((DbStructure.DbView) obj0).Name;

    internal static object gYhdXMWSQHpF3bZOF9Dg([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object kop6ooWSCKuuth5IGg1Z([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object voTOt3WSvDdOt106ahrZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (MatchEvaluator) obj2);

    internal static object chQvFoWS8wDaPfKoAh4t([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Text;

    internal static object rrAsMQWSZ1o4JBwdBils([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Name;

    internal static void BQdHwuWSu31ZcQtoOAEi([In] object obj0, [In] object obj1) => ((DbStructure.DbProcedure) obj0).Text = (string) obj1;

    internal static object RTQBRlWSIAfxFmB3fyMj([In] object obj0) => (object) ((DbStructure.DbTrigger) obj0).Text;

    internal static object G8hvSGWSVQoJjNL8oLZH([In] object obj0) => (object) ((DbStructure.DbTrigger) obj0).Name;

    internal static void bmFDcTWSSwcH2JGFp2h3([In] object obj0, [In] object obj1) => ((DbStructure.DbTrigger) obj0).Text = (string) obj1;

    internal static object ldjpNOWSiVU6CkP9Dvm7([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static bool UGn2CYWSRIqGHv5uqa05([In] object obj0) => ((DbStructure) obj0).Deactivating;

    internal static int fBCEftWSq7437Fw6biMV([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3);

    internal static object U8YZ4NWSKupDxyyfsMs8(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void r34NbYWSXnxinGgcW8JP([In] object obj0) => ((DbMigrator) obj0).DropMarkedForeignKeys();

    internal static void bivHOTWSTUqTk65Jwo15([In] object obj0) => ((DbMigrator) obj0).DropMarkedPrimaryKeys();

    internal static void ijKR2oWSk8pqf0HX2Z3y([In] object obj0) => ((DbMigrator) obj0).DropMarkedIndexes();

    internal static object ix0152WSnPtOOPY1G4BL([In] object obj0) => (object) ((DbDeleteTableAction) obj0).TableName;

    internal static object T0vVt7WSOUI0PPZ9Gj2b([In] object obj0) => (object) ((DbDeleteColumnAction) obj0).ColumnName;

    internal static object L85xslWS2LvCGV8eXA6W([In] object obj0) => (object) ((DbDeleteColumnAction) obj0).TableName;

    internal static object FXgZi7WSefedAhug9OXe([In] object obj0) => (object) ((DbRenameColumnAction) obj0).OldColumnName;

    internal static object MGhEB1WSP7ZBVnYZfqbb([In] object obj0) => (object) ((DbRenameColumnAction) obj0).NewColumnName;

    internal static object VbEi8cWS155L8YNyo4DC([In] object obj0) => (object) ((DbRenameColumnAction) obj0).TableName;

    internal static void KFBJ6qWSNF4K5juJe7s7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object im1MPOWS3pOQoONscpqI([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}

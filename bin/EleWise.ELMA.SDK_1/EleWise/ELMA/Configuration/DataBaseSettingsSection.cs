// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.DataBaseSettingsSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  public class DataBaseSettingsSection : ProviderSettingsSection, IDataBaseSettingsSection
  {
    public const string CONNECTIONSTRING_NAME = "connectionStringName";
    public const string BACKUPENABLED_NAME = "backupEnabled";
    public const string BACKUPPATH_NAME = "backupPath";
    public const string COMMANDTIMEOUT_NAME = "commandTimeOut";
    internal readonly ConfigurationProperty _connectionStringName;
    internal readonly ConfigurationProperty _backupEnabled;
    internal readonly ConfigurationProperty _backupPathName;
    internal readonly ConfigurationProperty _commandTimeout;
    private static DataBaseSettingsSection dlZVu7fBIW8HjY2KveE2;

    /// <summary>Имя строки подключения</summary>
    [ConfigurationProperty("connectionStringName", IsRequired = true)]
    public string ConnectionStringName
    {
      get => (string) DataBaseSettingsSection.mVWPTSfBi1C9ZIo27TIC((object) this, (object) this._connectionStringName);
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
              this[this._connectionStringName] = (object) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    /// <summary>Строка подключения</summary>
    public virtual string ConnectionString => this.ReplaceConfigDir((string) DataBaseSettingsSection.mjWdVLfBKU7Qa2xVjiAi((object) ((ConnectionStringsSection) DataBaseSettingsSection.AGctr6fBqYThSpYqBOvh(DataBaseSettingsSection.uYK9O0fBRghMJGaZsuc0((object) this))).ConnectionStrings[this.ConnectionStringName]));

    /// <summary>
    /// Удалять ли старую базу при запуске. По умолчанию - false
    /// </summary>
    public bool DropDatabaseOnStart
    {
      get => this.\u003CDropDatabaseOnStart\u003Ek__BackingField;
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
              this.\u003CDropDatabaseOnStart\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>Количество попыток подключения</summary>
    public int ConnectionAttemptCount => 12;

    /// <summary>Интервал между попытками подключения (в секундах)</summary>
    public int ConnectionAttemptInverval => 5;

    /// <summary>
    /// Нужно ли делать резервные копии перед изменением структуры БД
    /// </summary>
    [ConfigurationProperty("backupEnabled", IsRequired = false)]
    public bool BackupEnabled
    {
      get => (bool) this[this._backupEnabled];
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
              DataBaseSettingsSection.c8nZEDfBXS6rGb2jc1ib((object) this, (object) this._backupEnabled, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Получить путь до папки с резервными копиями</summary>
    [ConfigurationProperty("backupPath", IsRequired = false)]
    public string BackupPath
    {
      get
      {
        int num = 2;
        string path;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (path != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              path = (string) DataBaseSettingsSection.mVWPTSfBi1C9ZIo27TIC((object) this, (object) this._backupPathName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (string) null;
label_3:
        return this.ReplaceConfigDir(path);
      }
    }

    /// <summary>Получить значение Timeout для команд sql запросов</summary>
    [ConfigurationProperty("commandTimeOut", IsRequired = false)]
    public int? CommandTimeout => (int?) this[this._commandTimeout];

    public void SetConnectionString(string name, string connectionString)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            DataBaseSettingsSection.GaThfQfBnwvJeShSNRrq(DataBaseSettingsSection.NylNTgfBT38vMWWofB7y(DataBaseSettingsSection.AGctr6fBqYThSpYqBOvh(DataBaseSettingsSection.uYK9O0fBRghMJGaZsuc0((object) this))), (object) new ConnectionStringSettings(name, connectionString));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 3:
            DataBaseSettingsSection.vPOJ7KfBkfcZfGsk8VhZ(DataBaseSettingsSection.NylNTgfBT38vMWWofB7y(DataBaseSettingsSection.AGctr6fBqYThSpYqBOvh(DataBaseSettingsSection.uYK9O0fBRghMJGaZsuc0((object) this))), (object) name);
            num = 2;
            continue;
          default:
            this.ConnectionStringName = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public void SetBackupPath(string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this[this._backupPathName] = (object) path;
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

    public void SetCommandTimeOut(int commandTimeOut)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataBaseSettingsSection.c8nZEDfBXS6rGb2jc1ib((object) this, (object) this._commandTimeout, (object) commandTimeOut);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void Init() => base.Init();

    public DataBaseSettingsSection()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: type reference
      this._connectionStringName = new ConfigurationProperty((string) DataBaseSettingsSection.RYv3QEfBO8qVuDTFl8Jk(-281842504 ^ -281641808), DataBaseSettingsSection.lTLenmfB2GMFyVT2LORE(__typeref (string)), (object) null);
      this._backupEnabled = new ConfigurationProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886839365), typeof (bool), (object) true);
      // ISSUE: type reference
      this._backupPathName = new ConfigurationProperty((string) DataBaseSettingsSection.RYv3QEfBO8qVuDTFl8Jk(1470998129 - 231418599 ^ 1239661552), DataBaseSettingsSection.lTLenmfB2GMFyVT2LORE(__typeref (string)), (object) null);
      this._commandTimeout = new ConfigurationProperty((string) DataBaseSettingsSection.RYv3QEfBO8qVuDTFl8Jk(1142330761 ^ 1541959139 ^ 536602680), typeof (int), (object) null);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object mVWPTSfBi1C9ZIo27TIC([In] object obj0, [In] object obj1) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1];

    internal static bool F4tAGSfBVJhoVvy6aWUI() => DataBaseSettingsSection.dlZVu7fBIW8HjY2KveE2 == null;

    internal static DataBaseSettingsSection OUtRrwfBShxGYVKxHw7L() => DataBaseSettingsSection.dlZVu7fBIW8HjY2KveE2;

    internal static object uYK9O0fBRghMJGaZsuc0([In] object obj0) => (object) ((ConfigurationElement) obj0).CurrentConfiguration;

    internal static object AGctr6fBqYThSpYqBOvh([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).ConnectionStrings;

    internal static object mjWdVLfBKU7Qa2xVjiAi([In] object obj0) => (object) ((ConnectionStringSettings) obj0).ConnectionString;

    internal static void c8nZEDfBXS6rGb2jc1ib([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1] = obj2;

    internal static object NylNTgfBT38vMWWofB7y([In] object obj0) => (object) ((ConnectionStringsSection) obj0).ConnectionStrings;

    internal static void vPOJ7KfBkfcZfGsk8VhZ([In] object obj0, [In] object obj1) => ((ConnectionStringSettingsCollection) obj0).Remove((string) obj1);

    internal static void GaThfQfBnwvJeShSNRrq([In] object obj0, [In] object obj1) => ((ConnectionStringSettingsCollection) obj0).Add((ConnectionStringSettings) obj1);

    internal static object RYv3QEfBO8qVuDTFl8Jk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type lTLenmfB2GMFyVT2LORE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}

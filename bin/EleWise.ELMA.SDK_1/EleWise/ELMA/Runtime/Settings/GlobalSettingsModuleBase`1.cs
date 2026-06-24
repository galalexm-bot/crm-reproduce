// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.GlobalSettingsModuleBase`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Settings
{
  /// <summary>Абстрактный класс для типизированных настроек</summary>
  /// <typeparam name="TSettings">Класс реализованный при помощи <see cref="T:EleWise.ELMA.Runtime.Settings.GlobalSettingsBase" /></typeparam>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-780.html">Пример реализации в базе знаний</see> <br />
  /// <see href="http://www.elma-bpm.ru/kb/article-781.html">Простой пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public abstract class GlobalSettingsModuleBase<TSettings> : 
    IGlobalSettingsGroupModule,
    IGlobalSettingsModule,
    IGlobalSettingsModulePermission
    where TSettings : GlobalSettingsBase, new()
  {
    protected TSettings _settings;
    private ICacheService _cacheService;
    private string _cacheKey;
    private string _timestamp;
    private static object ERGUHmWhrv1t5tcwEGeq;

    /// <summary>
    /// Используются для фильтрации настроек для отдельного раздела системы (по умолчанию Common)
    /// </summary>
    public virtual string ModuleNamespace
    {
      get
      {
        int num = 2;
        IModule moduleByAssembly;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (moduleByAssembly != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              moduleByAssembly = ComponentManager.Current.ModuleManager.FindModuleByAssembly(this.GetType().Assembly);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return moduleByAssembly.Id;
label_3:
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867198071);
      }
    }

    /// <summary>Название модуля</summary>
    public abstract string ModuleName { get; }

    /// <inheritdoc />
    public virtual Permission AdminPermission => CommonPermissions.AdminPermission;

    /// <summary>Отображение модуля</summary>
    public virtual string GroupName => string.Empty;

    /// <summary>Текущие типизированные настройки</summary>
    public virtual TSettings Settings
    {
      get
      {
        string str = this.CacheService != null ? this.CacheService.Get<string>(this._cacheKey, z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108683276)) : (string) null;
        if (this._timestamp != str || (object) this._settings == null)
        {
          this.LoadSettings();
          this._timestamp = str;
        }
        return this._settings;
      }
      set => this._settings = value;
    }

    /// <summary>Сохранить настройки</summary>
    public virtual void SaveSettings()
    {
      int num = 1;
      IDictionary<string, string> storageValues;
      while (true)
      {
        switch (num)
        {
          case 1:
            storageValues = this.Settings.GetStorageValues();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            this.CacheService.Insert<string>(this._cacheKey, DateTime.Now.Ticks.ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222065338));
            num = 4;
            continue;
          case 3:
            if (this.CacheService != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
              continue;
            }
            goto label_8;
          case 4:
            goto label_2;
          default:
            DataAccessManager.SettingsManager.SetStrings(this.ModuleGuid, storageValues);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 3;
            continue;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Загрузить настройки</summary>
    protected virtual void LoadSettings()
    {
      int num = 6;
      while (true)
      {
        IDictionary<string, string> allStrings;
        TSettings settings1;
        TSettings settings2;
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            if (allStrings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
              continue;
            }
            goto case 8;
          case 2:
          case 3:
            this._settings = settings1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 4:
            if (settings1.GlobalSettingsEventHandler != null)
            {
              num = 7;
              continue;
            }
            goto case 2;
          case 5:
            settings2 = new TSettings();
            break;
          case 6:
            TSettings settings3 = this._settings;
            if ((object) settings3 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
              continue;
            }
            settings2 = settings3;
            break;
          case 7:
            settings1.GlobalSettingsEventHandler.LoadSettings((IStoreValuesObject) settings1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 3 : 2;
            continue;
          case 8:
            settings1.SetStorageValues(allStrings);
            num = 4;
            continue;
          case 9:
            allStrings = DataAccessManager.SettingsManager.GetAllStrings(this.ModuleGuid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
        settings1 = settings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 9 : 7;
      }
label_12:
      return;
label_10:;
    }

    /// <summary>Идентификатор модуля</summary>
    public abstract Guid ModuleGuid { get; }

    /// <summary>Объект с текущими настройками</summary>
    object IGlobalSettingsModule.Settings
    {
      get => (object) this.Settings;
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
              this.Settings = (TSettings) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    public virtual void ClearCache()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._settings = default (TSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            Locator.GetServiceNotNull<ICacheService>().ClearRegion(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998509314));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            this._timestamp = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 3 : 3;
            continue;
        }
      }
label_2:;
    }

    protected ICacheService CacheService
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 2:
              goto label_2;
            case 3:
              if (this._cacheService != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 2;
                continue;
              }
              break;
          }
          this._cacheService = Locator.GetServiceNotNull<ICacheService>();
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
        }
label_2:
        return this._cacheService;
      }
    }

    protected GlobalSettingsModuleBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._cacheKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542694279) + typeof (TSettings).FullName;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jYEJtPWhg6kjZqTonrmS() => GlobalSettingsModuleBase<TSettings>.ERGUHmWhrv1t5tcwEGeq == null;

    internal static object LIV5lSWh5Vj5Di7O2RCF() => GlobalSettingsModuleBase<TSettings>.ERGUHmWhrv1t5tcwEGeq;
  }
}

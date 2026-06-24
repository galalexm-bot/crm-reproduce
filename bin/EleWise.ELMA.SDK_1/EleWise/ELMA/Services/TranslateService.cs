// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.TranslateService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Services
{
  [Service(Type = ComponentType.Server)]
  public class TranslateService : IInitHandler
  {
    private bool _inited;
    private ConcurrentDictionary<string, LocalizationHolder> _localizations;
    private ConcurrentDictionary<string, bool> _mergeLocales;
    private string _translationsPath;
    private Queue<LocalizationOperation> _localizationOperations;
    private ConcurrentDictionary<Guid, PrepareOperationDescription> _prepareOperations;
    private ConcurrentDictionary<long, string> _translateLocales;
    private ConcurrentDictionary<long, bool> _translateMode;
    private DateTime _lastSaveTime;
    private readonly IContextBoundVariableService contextBoundVariableService;
    private readonly IZipStreamService zipStreamService;
    private object _translateChangeSinch;
    internal static TranslateService RZfUJWBAfHHNgHOuTnCH;

    public static TranslateService Instance => Locator.GetService<TranslateService>();

    /// <summary>Время последнего обновления ресурсов</summary>
    public DateTime LastSaveTime => this._lastSaveTime;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService"></param>
    public TranslateService(
      IContextBoundVariableService contextBoundVariableService,
      IZipStreamService zipStreamService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._translateChangeSinch = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.zipStreamService = zipStreamService;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Включен ли inline</summary>
    public bool InLineTurned
    {
      get
      {
        bool flag;
        return this.contextBoundVariableService.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951561958), out flag) & flag;
      }
      set
      {
        int num = 3;
        bool flag;
        while (true)
        {
          switch (num)
          {
            case 1:
              TranslateService.Ew2ZcrBA8vjxXgeBqS4x((object) this.contextBoundVariableService, TranslateService.FQS7aDBAvN4WrUlFWP7J(-688192331 - 435440695 ^ -1123557246), (object) value);
              num = 4;
              continue;
            case 2:
              if (flag != value)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 3:
              this.contextBoundVariableService.TryGetValue<bool>((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(--1333735954 ^ 1333684974), out flag);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 1;
              continue;
            case 4:
              goto label_2;
            default:
              this.ProcessTranslateChange();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Выключить сервис для перевода</summary>
    public bool InLineDisabled
    {
      get
      {
        bool flag;
        return this.contextBoundVariableService.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876109873), out flag) & flag;
      }
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
              TranslateService.Ew2ZcrBA8vjxXgeBqS4x((object) this.contextBoundVariableService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272543765), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
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

    /// <summary>Запущенное приложение</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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

    /// <summary>Инициализация</summary>
    public void Init()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._mergeLocales = new ConcurrentDictionary<string, bool>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 2;
            continue;
          case 2:
            this._localizations = new ConcurrentDictionary<string, LocalizationHolder>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
          case 3:
            this._localizationOperations = new Queue<LocalizationOperation>();
            num = 6;
            continue;
          case 4:
            this._translateMode = new ConcurrentDictionary<long, bool>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          case 6:
            this._translateLocales = new ConcurrentDictionary<long, string>();
            num = 4;
            continue;
          default:
            this._prepareOperations = new ConcurrentDictionary<Guid, PrepareOperationDescription>();
            num = 5;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Инициализация</summary>
    public void InitComplete()
    {
    }

    /// <summary>Инициализирован ли сервис</summary>
    public bool Initialized => this._inited;

    /// <summary>Получить локаль, на которую пользователь переводит</summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public string GetTranslateLocalization(long? userId = null)
    {
      if (!userId.HasValue)
      {
        IUser currentUser = AuthenticationService.GetCurrentUser();
        if (currentUser == null)
          return (string) null;
        userId = new long?(Convert.ToInt64(currentUser.GetId()));
      }
      string str;
      return this._translateLocales.TryGetValue(userId.Value, out str) ? str : (string) null;
    }

    /// <summary>Установить целевую локаль для переводчика</summary>
    /// <param name="userId"></param>
    /// <param name="loc"></param>
    public void SetTranslateLocalization(long userId, string loc)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ProcessTranslateChange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            this._translateLocales[userId] = loc;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Обработать изменения режимов и локализации</summary>
    public void ProcessTranslateChange()
    {
      int num1 = 2;
      object translateChangeSinch;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            lockTaken = false;
            num1 = 3;
            continue;
          case 2:
            translateChangeSinch = this._translateChangeSinch;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_19;
        }
      }
label_25:
      return;
label_19:
      return;
label_2:
      try
      {
        Monitor.Enter(translateChangeSinch, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num2 = 1;
        IEnumerator<ITranslateChangeHandler> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator = ((ComponentManager) TranslateService.KSeTlhBAZV8KWbppBHsH()).GetExtensionPoints<ITranslateChangeHandler>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        try
        {
label_9:
          if (TranslateService.iEDjc0BAIkJ2BJAL1NTU((object) enumerator))
            goto label_11;
          else
            goto label_10;
label_8:
          int num3;
          switch (num3)
          {
            case 0:
              return;
            case 1:
              goto label_11;
            case 2:
              goto label_9;
            default:
              return;
          }
label_10:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
          goto label_8;
label_11:
          TranslateService.cwmV6mBAu5d7WgXF0tH8((object) enumerator.Current);
          num3 = 2;
          goto label_8;
        }
        finally
        {
          int num4;
          if (enumerator == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
          else
            goto label_17;
label_15:
          switch (num4)
          {
            case 1:
            case 2:
          }
label_17:
          TranslateService.YFfa75BAVm4swBHtrXIq((object) enumerator);
          num4 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          {
            num4 = 1;
            goto label_15;
          }
          else
            goto label_15;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_27;
              default:
                TranslateService.VXp0KXBASUuQGNvllZsX(translateChangeSinch);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_27:;
      }
    }

    /// <summary>Получить локаль по id</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public LocalizationHolder GetTranslation(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._localizations.ContainsKey(id))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (LocalizationHolder) null;
label_5:
      return this._localizations[id];
    }

    /// <summary>Включить\отключить режим переводчика</summary>
    /// <param name="userId"></param>
    /// <param name="enabled"></param>
    public void EnabledTranslationMode(long userId, bool enabled)
    {
      int num = 16;
      CultureInfo cultureInfo;
      string translateLocalization;
      CultureInfo current;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 9:
            this.SetTranslateLocalization(userId, (string) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 10 : 5;
            continue;
          case 2:
            if (enabled)
            {
              num = 12;
              continue;
            }
            goto case 4;
          case 3:
            this.SetTranslateLocalization(userId, (string) null);
            num = 7;
            continue;
          case 4:
          case 7:
          case 10:
            this.ProcessTranslateChange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 11 : 11;
            continue;
          case 5:
            if (TranslateService.c5WRyxBAqZMHTQ2adwPt((object) translateLocalization, TranslateService.lB8aEqBARygdkLy8VkYv((object) current), StringComparison.OrdinalIgnoreCase))
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 6:
            if (TranslateService.qhsg16BAi51kY0uYLLeb((object) translateLocalization))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 8:
            if (cultureInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
              continue;
            }
            goto case 14;
          case 11:
            goto label_9;
          case 12:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 9 : 17;
            continue;
          case 13:
            current = EleWise.ELMA.SR.GetCurrentCulture();
            num = 6;
            continue;
          case 14:
            this.SetTranslateLocalization(userId, cultureInfo.Name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 4 : 1;
            continue;
          case 15:
            this._translateMode[userId] = enabled;
            num = 2;
            continue;
          case 16:
            this.CheckInit();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 15;
            continue;
          case 17:
            translateLocalization = this.GetTranslateLocalization(new long?(userId));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 11 : 13;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            cultureInfo = this.GetTargets().FirstOrDefault<CultureInfo>((Func<CultureInfo, bool>) (t => !TranslateService.\u003C\u003Ec__DisplayClass23_0.hXc5RWQkJU7msb1teijA(TranslateService.\u003C\u003Ec__DisplayClass23_0.iPwy8dQkM5F12TsDZbgn((object) t), TranslateService.\u003C\u003Ec__DisplayClass23_0.iPwy8dQkM5F12TsDZbgn((object) current), StringComparison.OrdinalIgnoreCase)));
            num = 8;
            continue;
        }
      }
label_9:;
    }

    /// <summary>Включен ли режим перевода</summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public bool IsTranslationModeEnabled(long? userId = null)
    {
      if (!this.Initialized)
        return false;
      if (!userId.HasValue)
      {
        IUser currentUser;
        try
        {
          currentUser = AuthenticationService.GetCurrentUser();
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) ex.Message, ex);
          return false;
        }
        if (currentUser == null)
          return false;
        userId = new long?(Convert.ToInt64(currentUser.GetId()));
      }
      bool flag;
      return this._translateMode.TryGetValue(userId.Value, out flag) && flag;
    }

    /// <summary>Перевод в локализации</summary>
    /// <param name="targetLoc"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public string T(string currentLoc, string targetLoc, string t, bool nowrapper = false)
    {
      int num1 = 20;
      string str1;
      string str2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              goto label_22;
            case 3:
            case 12:
              goto label_13;
            case 4:
              if (TranslateService.qhsg16BAi51kY0uYLLeb((object) targetLoc))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 1;
                continue;
              }
              goto case 10;
            case 5:
              if (!string.IsNullOrEmpty(str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 18;
                continue;
              }
              goto case 9;
            case 6:
            case 8:
              goto label_9;
            case 7:
              goto label_15;
            case 9:
              str1 = t;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 15 : 3;
              continue;
            case 10:
              if (!this._localizations.ContainsKey(targetLoc))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 12 : 1;
                continue;
              }
              str2 = (string) TranslateService.tO5j3kBAXSorhq2HWfS5((object) this._localizations[targetLoc], (object) t);
              num2 = 5;
              continue;
            case 11:
              if (TranslateService.qhsg16BAi51kY0uYLLeb((object) currentLoc))
              {
                num2 = 6;
                continue;
              }
              goto case 16;
            case 13:
              goto label_16;
            case 14:
              goto label_21;
            case 15:
            case 18:
              if (nowrapper)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                continue;
              }
              goto label_22;
            case 16:
              if (!this._localizations.ContainsKey(currentLoc))
              {
                num2 = 8;
                continue;
              }
              str1 = (string) TranslateService.tO5j3kBAXSorhq2HWfS5((object) this._localizations[currentLoc], (object) t);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 4;
              continue;
            case 17:
              goto label_20;
            case 19:
              goto label_5;
            case 20:
              this.CheckInit();
              num2 = 19;
              continue;
            default:
              if (!TranslateService.qhsg16BAi51kY0uYLLeb((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 14 : 3;
                continue;
              }
              goto label_20;
          }
        }
label_5:
        if (!TranslateService.pUMixnBAKKKZF0jnnZsE((object) t, TranslateService.FQS7aDBAvN4WrUlFWP7J(~-122002947 ^ 121948112)))
        {
          num1 = 11;
          continue;
        }
        goto label_27;
label_13:
        if (!TranslateService.qhsg16BAi51kY0uYLLeb((object) str1))
          num1 = 13;
        else
          goto label_15;
      }
label_9:
      return t;
label_15:
      return t;
label_16:
      return str1;
label_20:
      return str1;
label_21:
      return str2;
label_22:
      return (string) TranslateService.TPck7OBATWxcSohW2QAN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787401585), (object) t, (object) str1, (object) str2);
label_27:
      return t;
    }

    /// <summary>Перевод в локализации</summary>
    /// <param name="currentLoc"></param>
    /// <param name="targetLoc"></param>
    /// <param name="t"></param>
    /// <param name="nowrapper"></param>
    /// <returns></returns>
    public List<string> TA(string currentLoc, string targetLoc, string t, bool nowrapper = false)
    {
      this.CheckInit();
      List<string> stringList = new List<string>();
      if (t.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647955992)))
        return new List<string>() { t };
      if (string.IsNullOrEmpty(currentLoc) || !this._localizations.ContainsKey(currentLoc))
        return new List<string>() { t };
      string str1 = this._localizations[currentLoc].T(t);
      if (string.IsNullOrEmpty(targetLoc) || !this._localizations.ContainsKey(targetLoc))
      {
        if (string.IsNullOrEmpty(str1))
          return new List<string>() { t };
        return new List<string>() { str1 };
      }
      string str2 = this._localizations[targetLoc].T(t);
      if (currentLoc.Equals(EleWise.ELMA.SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase) && string.IsNullOrEmpty(str1))
        str1 = t;
      if (nowrapper)
      {
        string str3 = !string.IsNullOrEmpty(str2) ? str2 : str1;
        return new List<string>()
        {
          !string.IsNullOrEmpty(str3) ? str3 : t
        };
      }
      stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825440468));
      stringList.Add(t);
      stringList.Add(str1);
      stringList.Add(str2 ?? string.Empty);
      stringList.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672043259));
      return stringList;
    }

    /// <summary>Установка приоритета для строки ресурса</summary>
    /// <param name="locId"></param>
    /// <param name="t"></param>
    /// <param name="val"></param>
    public void SetPriority(string locId, string t, bool val)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        List<LocalizationFile> file;
        List<LocalizationFile>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              enumerator = file.GetEnumerator();
              num2 = 2;
              continue;
            case 2:
              try
              {
label_10:
                if (enumerator.MoveNext())
                  goto label_13;
                else
                  goto label_11;
label_8:
                LocalizationFile current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_25;
                    case 2:
                      goto label_10;
                    case 3:
                      Queue<LocalizationOperation> localizationOperations = this._localizationOperations;
                      LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
                      TranslateService.Rxx9cnBAksKJ6TWSg7qt((object) localizationSaveOperation, (object) this);
                      TranslateService.YeF4F2BAn2u9bGu9ix66((object) localizationSaveOperation, (object) current);
                      localizationOperations.LockEnqueue<LocalizationOperation>((LocalizationOperation) localizationSaveOperation);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
                      continue;
                    default:
                      goto label_13;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                goto label_8;
label_13:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                {
                  num3 = 3;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
label_25:
              if (TranslateService.WAKfhGBAOhaKwH8gF6mI((object) file) > 0)
              {
                num2 = 5;
                continue;
              }
              goto label_15;
            case 4:
              this._lastSaveTime = DateTime.Now;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            case 5:
              this.ProcessTranslateChange();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_19;
            case 7:
              if (this._localizations.ContainsKey(locId))
              {
                this._localizations[locId].SetPriority(t, val, out file);
                num2 = 4;
                continue;
              }
              goto label_23;
            case 8:
              this.CheckInit();
              num2 = 7;
              continue;
            default:
              goto label_9;
          }
        }
label_23:
        num1 = 6;
      }
label_4:
      return;
label_19:
      return;
label_9:
      return;
label_15:;
    }

    /// <summary>Установить Неточный перевод</summary>
    /// <param name="locId"></param>
    /// <param name="t"></param>
    /// <param name="val"></param>
    public void SetFuzzy(string locId, string t, bool val)
    {
      int num1 = 3;
      List<LocalizationFile> file;
      List<LocalizationFile>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_20;
          case 2:
            if (!this._localizations.ContainsKey(locId))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
            }
            this._localizations[locId].SetFuzzy(t, val, out file);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 3:
            this.CheckInit();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_18;
          case 5:
label_2:
            if (TranslateService.WAKfhGBAOhaKwH8gF6mI((object) file) > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 8;
              continue;
            }
            goto label_14;
          case 6:
            enumerator = file.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 5 : 7;
            continue;
          case 7:
            try
            {
label_9:
              if (enumerator.MoveNext())
                goto label_11;
              else
                goto label_10;
label_8:
              LocalizationFile current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    Queue<LocalizationOperation> localizationOperations = this._localizationOperations;
                    LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
                    TranslateService.Rxx9cnBAksKJ6TWSg7qt((object) localizationSaveOperation, (object) this);
                    TranslateService.YeF4F2BAn2u9bGu9ix66((object) localizationSaveOperation, (object) current);
                    localizationOperations.LockEnqueue<LocalizationOperation>((LocalizationOperation) localizationSaveOperation);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_11;
                  case 3:
                    goto label_2;
                  default:
                    goto label_9;
                }
              }
label_10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 3 : 3;
              goto label_8;
label_11:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
              {
                num2 = 1;
                goto label_8;
              }
              else
                goto label_8;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 8:
            this.ProcessTranslateChange();
            num1 = 4;
            continue;
          default:
            this._lastSaveTime = DateTime.Now;
            num1 = 6;
            continue;
        }
      }
label_20:
      return;
label_18:
      return;
label_14:;
    }

    /// <summary>Установить новый перевод</summary>
    /// <param name="locId"></param>
    /// <param name="t"></param>
    /// <param name="val"></param>
    public void SetTranslate(string locId, string t, string val)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, List<PoLineDescriptor>>.Enumerator enumerator1;
        Dictionary<string, List<PoLineDescriptor>> keyInBaseTranslate;
        while (true)
        {
          List<LocalizationFile> file;
          List<LocalizationFile>.Enumerator enumerator2;
          switch (num2)
          {
            case 1:
              this._localizations[locId].SetTranslate(t, val, out file);
              num2 = 12;
              continue;
            case 2:
              try
              {
label_36:
                if (enumerator2.MoveNext())
                  goto label_34;
                else
                  goto label_37;
label_32:
                LocalizationFile current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_34;
                    case 2:
                      goto label_54;
                    case 3:
                      Queue<LocalizationOperation> localizationOperations = this._localizationOperations;
                      LocalizationSaveOperation localizationSaveOperation = new LocalizationSaveOperation();
                      TranslateService.Rxx9cnBAksKJ6TWSg7qt((object) localizationSaveOperation, (object) this);
                      TranslateService.YeF4F2BAn2u9bGu9ix66((object) localizationSaveOperation, (object) current);
                      localizationOperations.LockEnqueue<LocalizationOperation>((LocalizationOperation) localizationSaveOperation);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_36;
                  }
                }
label_34:
                current = enumerator2.Current;
                num3 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                {
                  num3 = 0;
                  goto label_32;
                }
                else
                  goto label_32;
label_37:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 0;
                goto label_32;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
              if (keyInBaseTranslate.Count > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 4 : 10;
                continue;
              }
              goto case 6;
            case 4:
              if (this._localizations.ContainsKey(locId))
              {
                t = (string) TranslateService.z7T3i0BA2IAvNs54Fp5M(TranslateService.z7T3i0BA2IAvNs54Fp5M((object) t, (object) ' '.ToString(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889478302)), TranslateService.FQS7aDBAvN4WrUlFWP7J(-488881205 ^ -488874701), (object) "");
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
                continue;
              }
              num2 = 7;
              continue;
            case 5:
              this.CheckInit();
              num2 = 4;
              continue;
            case 6:
            case 13:
label_4:
              this._lastSaveTime = TranslateService.yJZTD2BAPHnTJZa5RGQK();
              num2 = 8;
              continue;
            case 7:
              goto label_41;
            case 8:
              enumerator2 = file.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 1;
              continue;
            case 9:
              try
              {
label_24:
                if (enumerator1.MoveNext())
                  goto label_22;
                else
                  goto label_25;
label_6:
                KeyValuePair<string, List<PoLineDescriptor>> current1;
                List<PoLineDescriptor>.Enumerator enumerator3;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      enumerator3 = current1.Value.GetEnumerator();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_22;
                    case 4:
                      goto label_24;
                    default:
                      goto label_8;
                  }
                }
label_8:
                try
                {
label_14:
                  if (enumerator3.MoveNext())
                    goto label_11;
                  else
                    goto label_15;
label_10:
                  PoLineDescriptor current2;
                  LocalizationFile localizationFile;
                  int num6;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        this._localizations[locId].AddResourceToFile(current1.Key, current2, out localizationFile);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_11;
                      case 3:
                        goto label_14;
                      case 4:
                        TranslateService.VgxaH0BAexdlW9p5BgAu((object) current2, (object) val);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                        continue;
                      case 5:
                        goto label_24;
                      default:
                        file.Add(localizationFile);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 1;
                        continue;
                    }
                  }
label_11:
                  current2 = enumerator3.Current;
                  num6 = 4;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  {
                    num6 = 4;
                    goto label_10;
                  }
                  else
                    goto label_10;
label_15:
                  num6 = 5;
                  goto label_10;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                    num7 = 0;
                  switch (num7)
                  {
                    default:
                  }
                }
label_22:
                current1 = enumerator1.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                {
                  num5 = 2;
                  goto label_6;
                }
                else
                  goto label_6;
label_25:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                goto label_6;
              }
              finally
              {
                enumerator1.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 10:
              goto label_45;
            case 11:
              goto label_43;
            case 12:
              if (file.Count != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 6;
                continue;
              }
              goto case 14;
            case 14:
              keyInBaseTranslate = this.FindKeyInBaseTranslate(t);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 3;
              continue;
          }
label_54:
          this.ProcessTranslateChange();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 11 : 9;
        }
label_45:
        enumerator1 = keyInBaseTranslate.GetEnumerator();
        num1 = 9;
      }
label_41:
      return;
label_43:;
    }

    /// <summary>
    /// Есть ли в очереди операция по слиянию для указанной локали
    /// </summary>
    /// <param name="locId"></param>
    /// <returns></returns>
    public bool HasMergingOperation(string locId)
    {
      int num1 = 3;
      bool flag;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              goto label_5;
            case 2:
              if (!TranslateService.qhsg16BAi51kY0uYLLeb((object) locId))
                break;
              goto label_7;
            case 3:
              flag = false;
              num2 = 2;
              continue;
          }
          this._mergeLocales.TryGetValue(locId, out flag);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
        }
label_7:
        num1 = 4;
      }
label_5:
      return flag;
    }

    /// <summary>Требуется ли слияние для локали</summary>
    /// <returns></returns>
    public bool IsNeedMerge(string locId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.HasMergingOperation(locId))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
      object targetPath = TranslateService.bqFY6YBA1qvu8lc1Yj3f((object) locId);
      string translationDir = this.GetTranslationDir(locId);
      return !TranslateService.vLOSISBAN4VRWbEdameU((object) EleWise.ELMA.SR.ComputeLocalizationHash((string) targetPath), (object) EleWise.ELMA.SR.ComputeLocalizationHash(translationDir));
    }

    /// <summary>Выполнить слияние для локали</summary>
    /// <param name="locId"></param>
    public void Merge(string locId)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            Queue<LocalizationOperation> localizationOperations = this._localizationOperations;
            LocalizationMergeOperation localizationMergeOperation = new LocalizationMergeOperation();
            TranslateService.Rxx9cnBAksKJ6TWSg7qt((object) localizationMergeOperation, (object) this);
            TranslateService.mxmZsIBA3RMCGRvNZr8L((object) localizationMergeOperation, (object) locId);
            localizationOperations.LockEnqueue<LocalizationOperation>((LocalizationOperation) localizationMergeOperation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            this._mergeLocales[locId] = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          case 3:
            if (!this.HasMergingOperation(locId))
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_8;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_8:
      return;
label_9:
      return;
label_2:;
    }

    /// <summary>Поиск ключа в base шаблонах</summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public Dictionary<string, List<PoLineDescriptor>> FindKeyInBaseTranslate(string t)
    {
      this.CheckInit();
      Dictionary<string, List<PoLineDescriptor>> keyInBaseTranslate = new Dictionary<string, List<PoLineDescriptor>>();
      LocalizationHolder translation = this.GetTranslation(EleWise.ELMA.SR.KeyCultureInfo.Name);
      if (translation == null)
        return keyInBaseTranslate;
      Func<PoLineDescriptor, bool> func;
      foreach (LocalizationFile localizationFile in translation.Files.Where<LocalizationFile>((Func<LocalizationFile, bool>) (p =>
      {
        ConcurrentBag<PoLineDescriptor> resources = p.Resources;
        Func<PoLineDescriptor, bool> func1 = func;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        Func<PoLineDescriptor, bool> predicate = func1 == null ? (func = (Func<PoLineDescriptor, bool>) (r => TranslateService.\u003C\u003Ec__DisplayClass33_0.oXlTFaQkgyJ2FRKGTmx8(TranslateService.\u003C\u003Ec__DisplayClass33_0.lvdAJnQkrDGuLdriSb5G((object) r), (object) t, StringComparison.Ordinal))) : func1;
        return resources.Any<PoLineDescriptor>(predicate);
      })).ToList<LocalizationFile>())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        List<PoLineDescriptor> list = localizationFile.Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => TranslateService.\u003C\u003Ec__DisplayClass33_0.oXlTFaQkgyJ2FRKGTmx8(TranslateService.\u003C\u003Ec__DisplayClass33_0.lvdAJnQkrDGuLdriSb5G((object) r), (object) t, StringComparison.Ordinal))).Select<PoLineDescriptor, PoLineDescriptor>((Func<PoLineDescriptor, PoLineDescriptor>) (r => ClassSerializationHelper.CloneObject<PoLineDescriptor>(r))).ToList<PoLineDescriptor>();
        keyInBaseTranslate.Add(localizationFile.Name, list);
      }
      return keyInBaseTranslate;
    }

    /// <summary>Получить последние операции</summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public List<LocalizationOperation> GetTopOperations(int count)
    {
      List<LocalizationOperation> topOperations = new List<LocalizationOperation>();
      for (int index = 0; index < count; ++index)
      {
        LocalizationOperation result;
        if (this._localizationOperations.LockTryDequeue<LocalizationOperation>(out result))
          topOperations.Add(result);
      }
      return topOperations;
    }

    /// <summary>Сохранение файла</summary>
    public void SaveChanges(LocalizationFile file)
    {
      int num = 2;
      string dir;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            file.SaveToFile(dir);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            dir = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, TranslateService.SRK58YBApWHZ06pj2bri((object) file));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Слияние файлов локали</summary>
    /// <param name="locId">Ид локали</param>
    public void MergeFiles(string locId)
    {
      int num = 3;
      string translationDir;
      LocalizationHolder localizationHolder;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._localizations.TryAdd((string) TranslateService.KOknoJBADrn9Kv5em4dO((object) localizationHolder), localizationHolder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 5;
            continue;
          case 2:
            localizationHolder = this.LoadHolder(translationDir);
            num = 4;
            continue;
          case 3:
            object sourcePath = TranslateService.bqFY6YBA1qvu8lc1Yj3f((object) locId);
            translationDir = this.GetTranslationDir(locId);
            string targetPath = translationDir;
            PoMerge.Merge((string) sourcePath, targetPath, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 1;
            continue;
          case 4:
            if (localizationHolder != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 5:
            this._mergeLocales[locId] = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Существующие локализации</summary>
    /// <returns></returns>
    public List<CultureInfo> GetTargets() => this._localizations.Where<KeyValuePair<string, LocalizationHolder>>((Func<KeyValuePair<string, LocalizationHolder>, bool>) (l => !l.Key.Equals(EleWise.ELMA.SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase))).Select<KeyValuePair<string, LocalizationHolder>, CultureInfo>((Func<KeyValuePair<string, LocalizationHolder>, CultureInfo>) (l => new CultureInfo(l.Key))).ToList<CultureInfo>();

    /// <summary>Создать новую локаль</summary>
    /// <param name="id"></param>
    public void CreateLocal(string id, string baseLocal)
    {
      int num1 = 1;
      bool lockTaken;
      object translateChangeSinch;
      while (true)
      {
        switch (num1)
        {
          case 1:
            translateChangeSinch = this._translateChangeSinch;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_53;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 2;
            continue;
        }
      }
label_53:
      return;
label_4:
      try
      {
        Monitor.Enter(translateChangeSinch, ref lockTaken);
        int num2 = 8;
        while (true)
        {
          int num3;
          int index;
          string[] strArray;
          string str1;
          LocalizationHolder localizationHolder;
          string str2;
          string str3;
          string fileName;
          string path;
          string str4;
          string str5;
          string str6;
          string str7;
          switch (num2)
          {
            case 1:
              str7 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str1, (object) str4);
              num2 = 18;
              continue;
            case 2:
              if (!((IEnumerable<string>) TranslateService.PVMpOQBAwKCAPKwM5IRj((object) str2, TranslateService.FQS7aDBAvN4WrUlFWP7J(-1839087379 - 334718690 ^ 2121155659))).Any<string>((Func<string, bool>) (f =>
              {
                int num4 = 1;
                string str8;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      str8 = (string) TranslateService.\u003C\u003Ec.jFI51XQkUWj2fc9C1wMs((object) f);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      if (TranslateService.\u003C\u003Ec.GWPSV5QksueR595TmxLs((object) str8))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
                        continue;
                      }
                      goto label_3;
                  }
                }
label_2:
                return false;
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return TranslateService.\u003C\u003Ec.aS8y05QkzxIDP3Tw96IP((object) str8, TranslateService.\u003C\u003Ec.xigfBdQkcjfIfY4WpHNg(-1839087379 - 334718690 ^ 2121204027), StringComparison.OrdinalIgnoreCase);
              })))
              {
                num2 = 36;
                continue;
              }
              goto case 20;
            case 3:
              this._localizations.TryAdd((string) TranslateService.KOknoJBADrn9Kv5em4dO((object) localizationHolder), localizationHolder);
              num2 = 31;
              continue;
            case 4:
              Directory.CreateDirectory(str1);
              num2 = 6;
              continue;
            case 5:
            case 7:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 25 : 8;
                continue;
              }
              goto case 21;
            case 6:
              str3 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, TranslateService.FQS7aDBAvN4WrUlFWP7J(-1380439818 << 3 ^ 1841307112));
              num2 = 30;
              continue;
            case 8:
              str1 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) id);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 33 : 4;
              continue;
            case 9:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 4 : 5;
              continue;
            case 10:
            case 17:
              str6 = strArray[index];
              num2 = 29;
              continue;
            case 11:
              goto label_48;
            case 12:
            case 28:
            case 36:
              strArray = (string[]) TranslateService.kuO8KpBA49hUtHJ99TDT((object) str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 9 : 3;
              continue;
            case 13:
            case 34:
              if (index < strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 13 : 17;
                continue;
              }
              goto default;
            case 14:
              if (!TranslateService.btQPq9BAtHyKdLdDWWMW((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 28 : 24;
                continue;
              }
              goto case 2;
            case 15:
              if (fileName != null)
              {
                num2 = 32;
                continue;
              }
              goto case 26;
            case 16:
              index = 0;
              num2 = 13;
              continue;
            case 18:
              TranslateService.EWloxABA71Yg1Q03EiuH((object) str6, (object) str7);
              num2 = 23;
              continue;
            case 19:
              str2 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) baseLocal);
              num2 = 14;
              continue;
            case 20:
              str3 = str2;
              num3 = 12;
              break;
            case 21:
              path = strArray[index];
              num2 = 24;
              continue;
            case 22:
              if (str4 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
              }
              goto case 23;
            case 23:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 34 : 19;
              continue;
            case 24:
              fileName = Path.GetFileName(path);
              num2 = 15;
              continue;
            case 25:
              strArray = (string[]) TranslateService.VnIZYNBAHtWblDQILung((object) str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 16 : 5;
              continue;
            case 26:
              ++index;
              num3 = 7;
              break;
            case 27:
              TranslateService.dughAMBA6SNolweMiD8E((object) path, (object) str5, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 26 : 17;
              continue;
            case 29:
              str4 = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj((object) str6);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 22 : 1;
              continue;
            case 30:
              if (!string.IsNullOrEmpty(baseLocal))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 19 : 14;
                continue;
              }
              goto case 12;
            case 31:
              goto label_42;
            case 32:
              str5 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str1, (object) fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 27 : 13;
              continue;
            case 33:
              if (TranslateService.btQPq9BAtHyKdLdDWWMW((object) str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 11 : 2;
                continue;
              }
              goto case 4;
            case 35:
              if (localizationHolder != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
                continue;
              }
              goto label_40;
            default:
              localizationHolder = this.LoadHolder(str1);
              num2 = 35;
              continue;
          }
          num2 = num3;
        }
label_48:
        return;
label_42:
        return;
label_40:;
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                TranslateService.VXp0KXBASUuQGNvllZsX(translateChangeSinch);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              default:
                goto label_55;
            }
          }
        }
label_55:;
      }
    }

    /// <summary>Запуск подготовки к скачиванию</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Guid PrepareDownload(string id)
    {
      int num = 2;
      Guid guid;
      while (true)
      {
        PrepareOperationDescription operationDescription1;
        switch (num)
        {
          case 1:
            PrepareOperationDescription operationDescription2 = new PrepareOperationDescription();
            TranslateService.sBGmqQBA04qqUyvc5ouQ((object) operationDescription2, (object) id);
            operationDescription1 = operationDescription2;
            num = 3;
            continue;
          case 2:
            guid = TranslateService.hEr8nSBAxvoovAgRZxiu();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
            continue;
          case 3:
            if (!this._prepareOperations.TryAdd(guid, operationDescription1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 4;
              continue;
            }
            break;
          case 4:
            goto label_8;
          case 5:
            goto label_7;
        }
        ThreadStarter.QueueThread(new WaitCallback(this.DoPrepare), (object) guid);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 5 : 0;
      }
label_7:
      return guid;
label_8:
      return Guid.Empty;
    }

    /// <summary>Получить текущий статус операции формирования локали</summary>
    /// <param name="operationGuid"></param>
    /// <returns></returns>
    public PrepareOperationDescription GetPrepareOperationDescription(Guid operationGuid)
    {
      int num = 1;
      PrepareOperationDescription operationDescription;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._prepareOperations.TryGetValue(operationGuid, out operationDescription))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return operationDescription;
label_5:
      return (PrepareOperationDescription) null;
    }

    /// <summary>Загрузка новой локали</summary>
    public virtual void DoUpload(string locId, BinaryFile file)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string src;
          object translateChangeSinch;
          Stream content;
          bool lockTaken;
          switch (num2)
          {
            case 1:
              goto label_35;
            case 2:
              try
              {
                TranslateService.iqvIrhBA9kEJSJCWEUTq((object) this.zipStreamService, (object) content, (object) src);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_9;
                }
              }
              finally
              {
                if (content != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_20;
                      default:
                        TranslateService.YFfa75BAVm4swBHtrXIq((object) content);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_20:;
              }
            case 3:
              lockTaken = false;
              num2 = 4;
              continue;
            case 4:
              try
              {
                Monitor.Enter(translateChangeSinch, ref lockTaken);
                int num5 = 3;
                string str;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      FileUtils.CopyDirectory(src, str);
                      num5 = 2;
                      continue;
                    case 2:
                      this._localizations[locId] = this.LoadHolder(str);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      str = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) locId);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_3;
                  }
                }
              }
              finally
              {
                if (lockTaken)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_37;
                      default:
                        Monitor.Exit(translateChangeSinch);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_37:;
              }
            case 5:
label_3:
              this.ProcessTranslateChange();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              continue;
            case 6:
              if (!TranslateService.btQPq9BAtHyKdLdDWWMW((object) src))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 10;
                continue;
              }
              break;
            case 7:
              src = (string) TranslateService.gy1ew0BAMrW0QqZemX7J(TranslateService.ysqNqUBAy8ncrpONy5hJ(), TranslateService.FQS7aDBAvN4WrUlFWP7J(87862435 ^ 87946833));
              num2 = 6;
              continue;
            case 8:
              goto label_7;
            case 9:
label_9:
              if (TranslateService.c07GmQBAdooXtbYnrPR6((object) this, (object) src))
              {
                translateChangeSinch = this._translateChangeSinch;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 3;
                continue;
              }
              num2 = 11;
              continue;
            case 10:
              TranslateService.Vp4lYHBAJcwBuWX9JCIF((object) src);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_5;
            case 12:
              goto label_24;
          }
          content = file.GetContent();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
        }
label_7:
        if (!this.HasMergingOperation(locId))
          num1 = 7;
        else
          goto label_24;
      }
label_35:
      return;
label_5:
      throw new Exception((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(87862435 ^ 87946845));
label_24:
      throw new Exception((string) TranslateService.tBJCj6BAmTRPs2raljWE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542645255), (object) locId));
    }

    /// <summary>Проверка перевода</summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public virtual bool ValidateTranslation(string path) => TranslateService.IUA2ORBAlAMEmGk35HJU((object) Path.Combine(path, (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(-420743386 ^ -420828138)));

    /// <summary>Опубликовать новый перевод в систему</summary>
    /// <param name="id"></param>
    public virtual void PublishTranslate(string id)
    {
      int num1 = 4;
      object translateChangeSinch;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            goto label_4;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (!this.HasMergingOperation(id))
            {
              translateChangeSinch = this._translateChangeSinch;
              num1 = 2;
              continue;
            }
            num1 = 3;
            continue;
          default:
            goto label_18;
        }
      }
label_25:
      return;
label_18:
      return;
label_2:
      throw new Exception((string) TranslateService.tBJCj6BAmTRPs2raljWE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105145160), (object) id));
label_4:
      try
      {
        Monitor.Enter(translateChangeSinch, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            default:
              EleWise.ELMA.SR.WatcherDisable = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
              continue;
          }
        }
label_8:
        try
        {
          string translationDir = this.GetTranslationDir(id);
          if (!Directory.Exists(translationDir))
            throw new Exception((string) TranslateService.tBJCj6BAmTRPs2raljWE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841306714), (object) id));
          FileUtils.CopyDirectory(translationDir, (string) TranslateService.bqFY6YBA1qvu8lc1Yj3f((object) id));
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          EleWise.ELMA.SR.WatcherDisable = false;
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                TranslateService.fCiwpOBAraivZPBbITlH((object) EleWise.ELMA.SR.Dir);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
label_20:;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                Monitor.Exit(translateChangeSinch);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              default:
                goto label_27;
            }
          }
        }
label_27:;
      }
    }

    /// <summary>Готовим локаль для выгрузки</summary>
    /// <param name="operationId"></param>
    protected virtual void DoPrepare(object operationId)
    {
      int num1 = 4;
      Guid key1;
      PrepareOperationDescription operation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_91;
          case 2:
            if (!this._prepareOperations.TryGetValue(key1, out operation))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            }
            num1 = 5;
            continue;
          case 3:
            key1 = (Guid) operationId;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_6;
          default:
            goto label_76;
        }
      }
label_2:
      return;
label_91:
      return;
label_76:
      return;
label_6:
      try
      {
        LocalizationHolder localization = this._localizations[(string) TranslateService.nJpacEBAg1WmS5RFqEiL((object) operation)];
        int num2 = 60;
        while (true)
        {
          int num3;
          string sourceDirectory;
          string fileName1;
          string str1;
          string fileName2;
          int index;
          string str2;
          string path;
          string[] strArray;
          string str3;
          string zipFileName;
          string dst;
          Dictionary<string, string> dictionary;
          string key2;
          string str4;
          string str5;
          List<string> stringList;
          string str6;
          List<string>.Enumerator enumerator;
          string str7;
          string str8;
          switch (num2)
          {
            case 1:
            case 61:
              if (index < strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 35 : 45;
                continue;
              }
              goto default;
            case 2:
              fileName2 = Path.GetFileName(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 13 : 8;
              continue;
            case 3:
              str5 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) sourceDirectory, (object) fileName1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 5 : 23;
              continue;
            case 4:
              dst = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) sourceDirectory, (object) fileName2);
              num2 = 43;
              continue;
            case 5:
              operation.CurrentMessage = (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(1113862659 ^ 1113943747);
              num2 = 39;
              continue;
            case 6:
            case 17:
              if (index < strArray.Length)
              {
                num2 = 50;
                continue;
              }
              goto case 27;
            case 7:
              str2 = (string) TranslateService.paXoRXBA5L6nD76tGRiA(TranslateService.FQS7aDBAvN4WrUlFWP7J(-53329496 >> 4 ^ -3316200), (object) IOExtensions.GetTempFileName(), (object) localization.Name);
              num2 = 48;
              continue;
            case 8:
              str4 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) sourceDirectory, (object) str8);
              num2 = 26;
              continue;
            case 9:
              dictionary.Add(str5, string.Empty);
              num2 = 46;
              continue;
            case 10:
            case 47:
              dictionary = new Dictionary<string, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 62 : 31;
              continue;
            case 11:
              if (TranslateService.btQPq9BAtHyKdLdDWWMW((object) sourceDirectory))
              {
                num2 = 47;
                continue;
              }
              goto case 14;
            case 12:
              goto label_87;
            case 13:
              if (fileName2 == null)
              {
                num3 = 16;
                break;
              }
              goto case 4;
            case 14:
              TranslateService.Vp4lYHBAJcwBuWX9JCIF((object) sourceDirectory);
              num2 = 10;
              continue;
            case 15:
            case 22:
              if (index >= strArray.Length)
              {
                num2 = 32;
                continue;
              }
              goto case 24;
            case 16:
            case 40:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
            case 18:
              sourceDirectory = Path.Combine(str2, (string) TranslateService.KOknoJBADrn9Kv5em4dO((object) localization));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 11 : 10;
              continue;
            case 19:
              dictionary[key2] = str4;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 35;
              continue;
            case 20:
              try
              {
label_48:
                if (enumerator.MoveNext())
                  goto label_46;
                else
                  goto label_49;
label_45:
                int num4;
                switch (num4)
                {
                  case 1:
                    break;
                  case 2:
                    goto label_48;
                  default:
                    goto label_74;
                }
label_46:
                File.Delete(enumerator.Current);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
                {
                  num4 = 2;
                  goto label_45;
                }
                else
                  goto label_45;
label_49:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                goto label_45;
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
            case 21:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 17 : 14;
              continue;
            case 23:
              File.Copy(str3, str5, true);
              num2 = 9;
              continue;
            case 24:
              str6 = strArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 7 : 59;
              continue;
            case 25:
              index = 0;
              num2 = 15;
              continue;
            case 26:
              if (dictionary.ContainsKey(key2))
              {
                num2 = 19;
                continue;
              }
              goto case 35;
            case 27:
              strArray = Directory.GetDirectories(path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 52 : 1;
              continue;
            case 28:
              operation.CurrentMessage = (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(1142330761 ^ 1541959139 ^ 536847638);
              num2 = 57;
              continue;
            case 29:
            case 41:
              TranslateService.d0AdI7BAjknJdXnm01y6((object) operation, TranslateService.FQS7aDBAvN4WrUlFWP7J(694673736 ^ -23604109 ^ -672044775));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 18 : 9;
              continue;
            case 30:
              if (str7 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 32 : 37;
                continue;
              }
              goto case 53;
            case 31:
              fileName1 = Path.GetFileName(str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 44 : 4;
              continue;
            case 32:
              TranslateService.d0AdI7BAjknJdXnm01y6((object) operation, TranslateService.FQS7aDBAvN4WrUlFWP7J(-1088304168 ^ -1088383060));
              num2 = 5;
              continue;
            case 33:
              operation.FileName = zipFileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 17 : 28;
              continue;
            case 34:
              key2 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) sourceDirectory, (object) str7);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 8 : 8;
              continue;
            case 35:
              TranslateService.dughAMBA6SNolweMiD8E((object) str6, (object) str4, true);
              num2 = 55;
              continue;
            case 36:
label_74:
              operation.CurrentMessage = (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(-1939377524 ^ -1939460146);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 25 : 51;
              continue;
            case 37:
              str8 = string.Format((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(1051276242 - 990076387 ^ 61114807), TranslateService.rbyL4EBAY75lkwUDErEb((object) str7), TranslateService.oJ2MlbBAL9rtps79dMNM((object) str7));
              num2 = 34;
              continue;
            case 38:
              TranslateService.UbXaRDBAsU4ydOWFeLsV(TranslateService.wPK1CZBAUBhmsUkg3W82((object) localization), TranslateService.UdE5i0BAaIG6A8XDYqqt((object) sourceDirectory, TranslateService.FQS7aDBAvN4WrUlFWP7J(1917998801 >> 2 ^ 479578432)));
              num2 = 63;
              continue;
            case 39:
              localization.RefreshStatistic();
              num3 = 38;
              break;
            case 42:
              enumerator = stringList.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 11 : 20;
              continue;
            case 43:
              FileUtils.CopyDirectory(str1, dst);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 40 : 20;
              continue;
            case 44:
              if (fileName1 == null)
              {
                num2 = 64;
                continue;
              }
              goto case 3;
            case 45:
            case 58:
              str1 = strArray[index];
              num2 = 2;
              continue;
            case 46:
            case 64:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 6;
              continue;
            case 48:
              if (Directory.Exists(str2))
              {
                num2 = 29;
                continue;
              }
              goto case 56;
            case 49:
              Locator.GetServiceNotNull<IZipService>().CreateZipFolder(zipFileName, sourceDirectory);
              num2 = 33;
              continue;
            case 50:
            case 54:
              str3 = strArray[index];
              num2 = 31;
              continue;
            case 51:
              zipFileName = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str2, TranslateService.tBJCj6BAmTRPs2raljWE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121946984), (object) operation.LocalId));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 49 : 48;
              continue;
            case 52:
              index = 0;
              num2 = 61;
              continue;
            case 53:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 22 : 8;
              continue;
            case 55:
              stringList.Add(str4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 53 : 42;
              continue;
            case 56:
              TranslateService.Vp4lYHBAJcwBuWX9JCIF((object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 14 : 41;
              continue;
            case 57:
              TranslateService.upNRhbBAc09B3VBZ4vTm((object) operation, PrepareLocalizationStatus.Completed);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 12;
              continue;
            case 59:
              str7 = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj((object) str6);
              num3 = 30;
              break;
            case 60:
              path = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) localization.Name);
              num2 = 7;
              continue;
            case 62:
              strArray = (string[]) TranslateService.kuO8KpBA49hUtHJ99TDT((object) path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 21 : 5;
              continue;
            case 63:
              operation.CurrentMessage = (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(-1445902765 ^ -1980277732 ^ 539445063);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 20 : 42;
              continue;
            default:
              object obj = TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979398630));
              stringList = new List<string>();
              strArray = (string[]) TranslateService.kuO8KpBA49hUtHJ99TDT(obj);
              num3 = 25;
              break;
          }
          num2 = num3;
        }
label_87:;
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              operation.CurrentMessage = (string) TranslateService.dTxG1QB7B9FdKV0Kgtof((object) ex);
              num6 = 3;
              continue;
            case 2:
              goto label_83;
            case 3:
              TranslateService.upNRhbBAc09B3VBZ4vTm((object) operation, PrepareLocalizationStatus.Error);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 2;
              continue;
            default:
              TranslateService.lUujqdB7F2mv3wr9uTCF(TranslateService.b5igWjBAzYHR4hiL4klj(), (object) ex.Message, (object) ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
              continue;
          }
        }
label_83:;
      }
    }

    /// <summary>Получить последние операции</summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public List<LocalizationOperation> GetTopDownloadOperations(int count)
    {
      List<LocalizationOperation> downloadOperations = new List<LocalizationOperation>();
      for (int index = 0; index < count; ++index)
      {
        LocalizationOperation result;
        if (this._localizationOperations.LockTryDequeue<LocalizationOperation>(out result))
          downloadOperations.Add(result);
      }
      return downloadOperations;
    }

    /// <summary>Скачиваем локаль</summary>
    /// <param name="operationGuid"></param>
    /// <returns></returns>
    public FileStream DownloadLocal(Guid operationGuid, out string fileName)
    {
      int num1 = 1;
      PrepareOperationDescription operationDescription;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              operationDescription = this.GetPrepareOperationDescription(operationGuid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_11;
            case 3:
              goto label_3;
            case 4:
              goto label_8;
            case 5:
              goto label_12;
            case 6:
              fileName = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj(TranslateService.kLiNtmB7oK6MZOxIRJqQ((object) operationDescription));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
              continue;
            default:
              if (TranslateService.jyGCHiB7W1X1hXrxQPXb((object) operationDescription) == PrepareLocalizationStatus.Completed)
              {
                if (operationDescription != null)
                {
                  if (TranslateService.IUA2ORBAlAMEmGk35HJU(TranslateService.kLiNtmB7oK6MZOxIRJqQ((object) operationDescription)))
                  {
                    num2 = 6;
                    continue;
                  }
                  goto label_12;
                }
                else
                  goto label_5;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 1;
                continue;
              }
          }
        }
label_5:
        num1 = 4;
      }
label_3:
      throw new Exception(EleWise.ELMA.SR.T((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(874012245 ^ 874054627)));
label_8:
      throw new Exception(EleWise.ELMA.SR.T((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(322893104 - -1992822529 ^ -1979295195), (object) operationGuid));
label_11:
      return new FileStream(operationDescription.FileName, FileMode.Open, FileAccess.Read);
label_12:
      throw new Exception(EleWise.ELMA.SR.T((string) TranslateService.FQS7aDBAvN4WrUlFWP7J(1232639661 >> 3 ^ 154029243), TranslateService.kLiNtmB7oK6MZOxIRJqQ((object) operationDescription)));
    }

    /// <summary>Папка с ресурсами локали</summary>
    /// <param name="local"></param>
    /// <returns></returns>
    public string GetTranslationDir(string local) => (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this._translationsPath, (object) local);

    /// <summary>Папка с шаблонами локали</summary>
    /// <param name="local"></param>
    /// <returns></returns>
    public string GetTranslationTemplateDir(string local) => (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) this.GetTranslationDir(local), TranslateService.FQS7aDBAvN4WrUlFWP7J(-1876063057 ^ -1876061469));

    /// <summary>Посчитать hash для локали</summary>
    /// <returns></returns>
    public LocalizationHash[] ComputeLocalizationHash()
    {
      int num1 = 1;
      object translateChangeSinch;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            translateChangeSinch = this._translateChangeSinch;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_3;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      LocalizationHash[] localizationHash;
      return localizationHash;
label_5:
      try
      {
        Monitor.Enter(translateChangeSinch, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              localizationHash = (LocalizationHash[]) TranslateService.KFLnNFB7brZuK7VtKB1n();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
        else
          goto label_12;
label_11:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        TranslateService.VXp0KXBASUuQGNvllZsX(translateChangeSinch);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    /// <summary>Загрузить описание локализации</summary>
    /// <param name="folder"></param>
    /// <returns></returns>
    private LocalizationHolder LoadHolder(string folder)
    {
      int num1 = 14;
      LocalizationHolder localizationHolder;
      while (true)
      {
        int num2 = num1;
        string path1;
        int index;
        string str1;
        string[] strArray;
        string path2;
        TemplateDescription templateDescription;
        string path3;
        string str2;
        StreamReader reader;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 12:
              path2 = strArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 7;
              continue;
            case 2:
            case 27:
              goto label_38;
            case 3:
              strArray = (string[]) TranslateService.PVMpOQBAwKCAPKwM5IRj((object) folder, TranslateService.FQS7aDBAvN4WrUlFWP7J(-1204263869 ^ -1341583247 ^ 137456242));
              num2 = 22;
              continue;
            case 4:
              localizationHolder = new LocalizationHolder()
              {
                Name = str1
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 3;
              continue;
            case 5:
              goto label_39;
            case 6:
              try
              {
                Tuple<List<string>, List<PoLineDescriptor>> tuple = PoParser.Parse((TextReader) reader);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num3 = 1;
                LocalizationFile localizationFile;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      localizationFile = new LocalizationFile()
                      {
                        Name = str2,
                        LocalizationName = str1,
                        Header = tuple.Item1,
                        Resources = new ConcurrentBag<PoLineDescriptor>((IEnumerable<PoLineDescriptor>) tuple.Item2)
                      };
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_15;
                    default:
                      localizationHolder.Files.Add(localizationFile);
                      num3 = 2;
                      continue;
                  }
                }
              }
              finally
              {
                int num4;
                if (reader == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                else
                  goto label_29;
label_28:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_29:
                TranslateService.YFfa75BAVm4swBHtrXIq((object) reader);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                {
                  num4 = 1;
                  goto label_28;
                }
                else
                  goto label_28;
              }
            case 7:
              templateDescription = new TemplateDescription()
              {
                Name = Path.GetFileName(path2)
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 26 : 7;
              continue;
            case 8:
              reader = new StreamReader(path3, (Encoding) TranslateService.xXiQ19B7G9dNOy4ityj4());
              num2 = 6;
              continue;
            case 9:
              if (Directory.Exists(path1))
              {
                num2 = 19;
                continue;
              }
              goto label_39;
            case 10:
            case 11:
              if (index < strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                continue;
              }
              goto label_39;
            case 13:
              if (str1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 4 : 20;
                continue;
              }
              if (str1.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574177288), StringComparison.OrdinalIgnoreCase))
              {
                num2 = 18;
                continue;
              }
              goto case 15;
            case 14:
              str1 = Path.GetFileName(folder);
              num2 = 13;
              continue;
            case 15:
              path1 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) folder, TranslateService.FQS7aDBAvN4WrUlFWP7J(-867826612 ^ -867821056));
              num2 = 4;
              continue;
            case 16:
            case 24:
              if (index < strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 1;
                continue;
              }
              goto case 9;
            case 17:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 9 : 10;
              continue;
            case 18:
              str1 = (string) TranslateService.lB8aEqBARygdkLy8VkYv(TranslateService.k8KnZcB7hcmfwqnr1ku2());
              num2 = 15;
              continue;
            case 19:
              strArray = (string[]) TranslateService.kuO8KpBA49hUtHJ99TDT((object) path1);
              num2 = 17;
              continue;
            case 20:
              goto label_41;
            case 21:
              if (str2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 8 : 6;
                continue;
              }
              goto case 25;
            case 22:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 16 : 8;
              continue;
            case 23:
              str2 = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj((object) path3);
              num2 = 21;
              continue;
            case 25:
label_15:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 24 : 13;
              continue;
            case 26:
              localizationHolder.Templates.Add(templateDescription);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              ++index;
              num2 = 11;
              continue;
          }
        }
label_38:
        path3 = strArray[index];
        num1 = 23;
      }
label_39:
      return localizationHolder;
label_41:
      return (LocalizationHolder) null;
    }

    /// <summary>Действия по инициализации</summary>
    private void DoInit()
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          string[] strArray;
          int index;
          string folder;
          LocalizationHolder localizationHolder;
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
            case 21:
              ++index;
              num2 = 10;
              continue;
            case 3:
              if (localizationHolder == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 21 : 13;
                continue;
              }
              goto case 9;
            case 4:
              localizationHolder = this.LoadHolder(folder);
              num2 = 3;
              continue;
            case 5:
              if (TranslateService.nqlTTqB7EroSrt7seXhQ((object) this.RuntimeApplication) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                continue;
              }
              goto label_22;
            case 6:
              strArray = (string[]) TranslateService.VnIZYNBAHtWblDQILung((object) this._translationsPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 11 : 14;
              continue;
            case 7:
              this._inited = true;
              num2 = 15;
              continue;
            case 8:
            case 19:
              folder = strArray[index];
              num2 = 4;
              continue;
            case 9:
              this._localizations.TryAdd(localizationHolder.Name, localizationHolder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 0;
              continue;
            case 10:
            case 11:
              if (index < strArray.Length)
              {
                num2 = 19;
                continue;
              }
              goto case 7;
            case 12:
              if (Directory.Exists(this._translationsPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 4 : 20;
                continue;
              }
              break;
            case 13:
            case 20:
              this.SinhWebResources(this._translationsPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 6;
              continue;
            case 14:
              index = 0;
              num2 = 11;
              continue;
            case 15:
              goto label_25;
            case 16:
              goto label_10;
            case 17:
              if (this.RuntimeApplication == null)
              {
                num2 = 16;
                continue;
              }
              goto case 5;
            case 18:
              this._translationsPath = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str, TranslateService.FQS7aDBAvN4WrUlFWP7J(132912447 ^ 132991997));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 12 : 8;
              continue;
            case 22:
              goto label_21;
          }
          Directory.CreateDirectory(this._translationsPath);
          num2 = 13;
        }
label_16:
        str = (string) TranslateService.FP0o0CB7CCdHjKMycX0r(TranslateService.rEWT3SB7Q46dLAKlmNvP(TranslateService.U6lPgWB7fcGcCpVVUL94(TranslateService.nqlTTqB7EroSrt7seXhQ((object) this.RuntimeApplication))));
        num1 = 18;
      }
label_25:
      return;
label_10:
      return;
label_21:
      return;
label_22:;
    }

    /// <summary>Забираем ресурсы из веба и помещаем в конфу</summary>
    /// <param name="translationsPath"></param>
    private void SinhWebResources(string translationsPath)
    {
      int num1 = 28;
      while (true)
      {
        int num2 = num1;
        string str1;
        string fileName;
        int index1;
        string[] strArray1;
        string str2;
        string str3;
        int index2;
        string path;
        string[] strArray2;
        string str4;
        string str5;
        string str6;
        string str7;
        string str8;
        string str9;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str6 = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj((object) str4);
              num2 = 49;
              continue;
            case 2:
            case 17:
              if (index1 < strArray1.Length)
              {
                num2 = 33;
                continue;
              }
              goto label_20;
            case 3:
            case 35:
              str1 = strArray2[index2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 29 : 22;
              continue;
            case 4:
            case 21:
            case 39:
              goto label_20;
            case 5:
              TranslateService.Vp4lYHBAJcwBuWX9JCIF((object) str2);
              num2 = 9;
              continue;
            case 6:
              str3 = (string) TranslateService.nH6fJ1BAA4Tn3Pamd7Fj((object) str8);
              num2 = 36;
              continue;
            case 7:
            case 44:
              ++index1;
              num2 = 43;
              continue;
            case 8:
            case 13:
              TranslateService.dughAMBA6SNolweMiD8E((object) str8, (object) str9, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 44 : 7;
              continue;
            case 9:
              strArray1 = Directory.GetFiles(path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 9 : 11;
              continue;
            case 10:
              str8 = strArray1[index1];
              num2 = 6;
              continue;
            case 11:
              index1 = 0;
              num2 = 2;
              continue;
            case 12:
              str9 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str7, (object) str3);
              num2 = 25;
              continue;
            case 14:
              str5 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str2, (object) str6);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 30 : 29;
              continue;
            case 15:
              str2 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) str7, TranslateService.FQS7aDBAvN4WrUlFWP7J(1574260816 ^ 1574260252));
              num2 = 45;
              continue;
            case 16:
            case 32:
              TranslateService.dughAMBA6SNolweMiD8E((object) str4, (object) str5, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 24 : 38;
              continue;
            case 18:
              if (!TranslateService.c5WRyxBAqZMHTQ2adwPt((object) fileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841307112), StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 7 : 6;
                continue;
              }
              goto case 8;
            case 19:
            case 24:
              if (index2 < strArray2.Length)
              {
                num2 = 3;
                continue;
              }
              goto label_46;
            case 20:
              goto label_53;
            case 22:
            case 34:
              strArray1 = (string[]) TranslateService.PVMpOQBAwKCAPKwM5IRj((object) str1, TranslateService.FQS7aDBAvN4WrUlFWP7J(964881585 - -1459193222 ^ -1870893961));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 23 : 4;
              continue;
            case 23:
              index1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 37;
              continue;
            case 25:
              if (!TranslateService.IUA2ORBAlAMEmGk35HJU((object) str9))
              {
                num2 = 8;
                continue;
              }
              goto case 18;
            case 26:
            case 38:
              ++index1;
              num2 = 17;
              continue;
            case 27:
              index2 = 0;
              num2 = 19;
              continue;
            case 28:
              strArray2 = (string[]) TranslateService.VnIZYNBAHtWblDQILung((object) EleWise.ELMA.SR.Dir);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 27 : 3;
              continue;
            case 29:
              fileName = Path.GetFileName(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            case 30:
              if (!TranslateService.IUA2ORBAlAMEmGk35HJU((object) str5))
              {
                num2 = 16;
                continue;
              }
              goto case 46;
            case 31:
              if (!TranslateService.btQPq9BAtHyKdLdDWWMW((object) str7))
                goto case 42;
              else
                goto label_23;
            case 33:
            case 48:
              str4 = strArray1[index1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            case 36:
              if (str3 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 6 : 12;
                continue;
              }
              goto case 7;
            case 37:
            case 43:
              if (index1 >= strArray1.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 34 : 41;
                continue;
              }
              goto case 10;
            case 40:
              goto label_36;
            case 41:
              path = Path.Combine(str1, (string) TranslateService.FQS7aDBAvN4WrUlFWP7J(-867826612 ^ -867821056));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 47 : 8;
              continue;
            case 42:
              TranslateService.Vp4lYHBAJcwBuWX9JCIF((object) str7);
              num2 = 22;
              continue;
            case 45:
              if (!TranslateService.btQPq9BAtHyKdLdDWWMW((object) str2))
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 46:
              if (!TranslateService.c5WRyxBAqZMHTQ2adwPt((object) fileName, TranslateService.FQS7aDBAvN4WrUlFWP7J(~1767720452 ^ -1767644253), StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 22 : 26;
                continue;
              }
              goto case 16;
            case 47:
              if (!TranslateService.btQPq9BAtHyKdLdDWWMW((object) path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 13 : 21;
                continue;
              }
              goto case 15;
            case 49:
              if (str6 != null)
              {
                num2 = 14;
                continue;
              }
              goto case 26;
            default:
              if (fileName == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 4 : 0;
                continue;
              }
              goto label_36;
          }
        }
label_20:
        ++index2;
        num1 = 24;
        continue;
label_23:
        num1 = 34;
        continue;
label_36:
        str7 = (string) TranslateService.UdE5i0BAaIG6A8XDYqqt((object) translationsPath, (object) fileName);
        num1 = 31;
      }
label_53:
      return;
label_46:;
    }

    /// <summary>Если не инициализировано, то инициализируем</summary>
    public void CheckInit()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            this.DoInit();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (this._inited)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_4:
      return;
label_2:
      return;
label_7:;
    }

    internal static bool zoekpEBAQVDkZht5LeFv() => TranslateService.RZfUJWBAfHHNgHOuTnCH == null;

    internal static TranslateService eTf9L8BACrbZJv2Khifo() => TranslateService.RZfUJWBAfHHNgHOuTnCH;

    internal static object FQS7aDBAvN4WrUlFWP7J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Ew2ZcrBA8vjxXgeBqS4x([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static object KSeTlhBAZV8KWbppBHsH() => (object) ComponentManager.Current;

    internal static void cwmV6mBAu5d7WgXF0tH8([In] object obj0) => ((ITranslateChangeHandler) obj0).Execute();

    internal static bool iEDjc0BAIkJ2BJAL1NTU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void YFfa75BAVm4swBHtrXIq([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void VXp0KXBASUuQGNvllZsX([In] object obj0) => Monitor.Exit(obj0);

    internal static bool qhsg16BAi51kY0uYLLeb([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object lB8aEqBARygdkLy8VkYv([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static bool c5WRyxBAqZMHTQ2adwPt([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static bool pUMixnBAKKKZF0jnnZsE([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object tO5j3kBAXSorhq2HWfS5([In] object obj0, [In] object obj1) => (object) ((LocalizationHolder) obj0).T((string) obj1);

    internal static object TPck7OBATWxcSohW2QAN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void Rxx9cnBAksKJ6TWSg7qt([In] object obj0, [In] object obj1) => ((LocalizationOperation) obj0).TranslateService = (TranslateService) obj1;

    internal static void YeF4F2BAn2u9bGu9ix66([In] object obj0, [In] object obj1) => ((LocalizationSaveOperation) obj0).File = (LocalizationFile) obj1;

    internal static int WAKfhGBAOhaKwH8gF6mI([In] object obj0) => ((List<LocalizationFile>) obj0).Count;

    internal static object z7T3i0BA2IAvNs54Fp5M([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void VgxaH0BAexdlW9p5BgAu([In] object obj0, [In] object obj1) => ((PoLineDescriptor) obj0).Value = (string) obj1;

    internal static DateTime yJZTD2BAPHnTJZa5RGQK() => DateTime.Now;

    internal static object bqFY6YBA1qvu8lc1Yj3f([In] object obj0) => (object) EleWise.ELMA.SR.GetCultureDir((string) obj0);

    internal static bool vLOSISBAN4VRWbEdameU([In] object obj0, [In] object obj1) => ((LocalizationHash) obj0).Equals((LocalizationHash) obj1);

    internal static void mxmZsIBA3RMCGRvNZr8L([In] object obj0, [In] object obj1) => ((LocalizationMergeOperation) obj0).LocalId = (string) obj1;

    internal static object SRK58YBApWHZ06pj2bri([In] object obj0) => (object) ((LocalizationFile) obj0).LocalizationName;

    internal static object UdE5i0BAaIG6A8XDYqqt([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object KOknoJBADrn9Kv5em4dO([In] object obj0) => (object) ((LocalizationHolder) obj0).Name;

    internal static bool btQPq9BAtHyKdLdDWWMW([In] object obj0) => Directory.Exists((string) obj0);

    internal static object PVMpOQBAwKCAPKwM5IRj([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object kuO8KpBA49hUtHJ99TDT([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static void dughAMBA6SNolweMiD8E([In] object obj0, [In] object obj1, [In] bool obj2) => File.Copy((string) obj0, (string) obj1, obj2);

    internal static object VnIZYNBAHtWblDQILung([In] object obj0) => (object) Directory.GetDirectories((string) obj0);

    internal static object nH6fJ1BAA4Tn3Pamd7Fj([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static void EWloxABA71Yg1Q03EiuH([In] object obj0, [In] object obj1) => FileUtils.CopyDirectory((string) obj0, (string) obj1);

    internal static Guid hEr8nSBAxvoovAgRZxiu() => Guid.NewGuid();

    internal static void sBGmqQBA04qqUyvc5ouQ([In] object obj0, [In] object obj1) => ((PrepareOperationDescription) obj0).LocalId = (string) obj1;

    internal static object tBJCj6BAmTRPs2raljWE([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object ysqNqUBAy8ncrpONy5hJ() => (object) IOExtensions.GetTempFileName();

    internal static object gy1ew0BAMrW0QqZemX7J([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Vp4lYHBAJcwBuWX9JCIF([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object iqvIrhBA9kEJSJCWEUTq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IZipStreamService) obj0).ExtractZipFolder((Stream) obj1, (string) obj2);

    internal static bool c07GmQBAdooXtbYnrPR6([In] object obj0, [In] object obj1) => ((TranslateService) obj0).ValidateTranslation((string) obj1);

    internal static bool IUA2ORBAlAMEmGk35HJU([In] object obj0) => File.Exists((string) obj0);

    internal static void fCiwpOBAraivZPBbITlH([In] object obj0) => EleWise.ELMA.SR.ReInitSR((string) obj0);

    internal static object nJpacEBAg1WmS5RFqEiL([In] object obj0) => (object) ((PrepareOperationDescription) obj0).LocalId;

    internal static object paXoRXBA5L6nD76tGRiA([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void d0AdI7BAjknJdXnm01y6([In] object obj0, [In] object obj1) => ((PrepareOperationDescription) obj0).CurrentMessage = (string) obj1;

    internal static object rbyL4EBAY75lkwUDErEb([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object oJ2MlbBAL9rtps79dMNM([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object wPK1CZBAUBhmsUkg3W82([In] object obj0) => (object) ((LocalizationHolder) obj0).Statistic;

    internal static void UbXaRDBAsU4ydOWFeLsV([In] object obj0, [In] object obj1) => ((LocalizationStatistic) obj0).SaveToXml((string) obj1);

    internal static void upNRhbBAc09B3VBZ4vTm([In] object obj0, PrepareLocalizationStatus value) => ((PrepareOperationDescription) obj0).Status = value;

    internal static object b5igWjBAzYHR4hiL4klj() => (object) Logger.Log;

    internal static void lUujqdB7F2mv3wr9uTCF([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object dTxG1QB7B9FdKV0Kgtof([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static PrepareLocalizationStatus jyGCHiB7W1X1hXrxQPXb([In] object obj0) => ((PrepareOperationDescription) obj0).Status;

    internal static object kLiNtmB7oK6MZOxIRJqQ([In] object obj0) => (object) ((PrepareOperationDescription) obj0).FileName;

    internal static object KFLnNFB7brZuK7VtKB1n() => (object) EleWise.ELMA.SR.ComputeLocalizationHash();

    internal static object k8KnZcB7hcmfwqnr1ku2() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static object xXiQ19B7G9dNOy4ityj4() => (object) Encoding.UTF8;

    internal static object nqlTTqB7EroSrt7seXhQ([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object U6lPgWB7fcGcCpVVUL94([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object rEWT3SB7Q46dLAKlmNvP([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object FP0o0CB7CCdHjKMycX0r([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.TZ
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EleWise.ELMA
{
  /// <summary>Статический класс для работы с часовыми поясами</summary>
  public static class TZ
  {
    private static ITimeZoneService timeZoneService;
    private static TimeZoneModel serverTimeZone;
    private static int? serverTimeZoneOffset;
    private static int? runtimeTimeZoneOffset;
    /// <summary>
    /// Разница между серверным смещением и текущим смещением
    /// <!--(b-a)=-(a-b)-->
    /// </summary>
    private static int diffBtServerDtAndRuntimeDt;
    /// <summary>
    /// Максимальный порог значения времени для преобразования
    /// </summary>
    private static readonly Lazy<DateTime> MaxThreshold;
    /// <summary>Минимальный порог значения времени для преобразования</summary>
    private static readonly Lazy<DateTime> MinThreshold;
    private static IEnumerable<TimeZoneModel> timeZones;
    private static readonly Lazy<TZSettings> tzSettingsRuntime;
    private static readonly Lazy<TZSettings> tzSettingsServer;
    public const string UserTimeZoneCookieName = "ElmaUserTimeZoneOffset";
    public const string ServerTimeZoneCookieName = "ElmaServerTimeZoneOffset";
    public const string RuntimeTimeZoneCookieName = "ElmaRuntimeTimeZoneOffset";
    public const string BlockedTimeZoneCookieName = "ElmaBlockedTimeZoneOffset";
    private static TZ A2LDXDQmdxxg5KFGq2i;

    /// <summary>Сервис для работы с пользовательским часовым поясом</summary>
    internal static ITimeZoneService TimeZoneService
    {
      get
      {
        int num = 1;
        ITimeZoneService timeZoneService;
        while (true)
        {
          switch (num)
          {
            case 1:
              timeZoneService = TZ.timeZoneService;
              if (timeZoneService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return timeZoneService;
label_5:
        return TZ.timeZoneService = Locator.GetServiceNotNull<ITimeZoneService>();
      }
      set => TZ.timeZoneService = value;
    }

    /// <summary>Часовой пояс сервера в ключевой локали</summary>
    public static TimeZoneModel ServerTimeZone => TZ.serverTimeZone;

    /// <summary>Инициализировать часовой пояс сервера</summary>
    /// <param name="serverTimeZoneData">Сериализованные данные серверного часового пояса</param>
    internal static void InitializeServerTimeZone(string serverTimeZoneData)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_9;
          case 1:
label_11:
            TZ.diffBtServerDtAndRuntimeDt = TZ.ServerOffset - TZ.Jg73imQlitfmEYOxCc8();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              TZ.serverTimeZone = (TimeZoneModel) TZ.nDZqjqQJdYAmqhBdLct((object) serverTimeZoneData);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_11;
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  throw new InitializationException((string) TZ.y9JBUcQdqMje0efNIJF(TZ.dHQLrAQ9x4QVAkERedD(1470998129 - 231418599 ^ 1239567378)), ex);
              }
            }
          default:
            goto label_5;
        }
      }
label_9:
      return;
label_5:;
    }

    /// <summary>
    /// Получить часовой пояс сервера для записи в информацию о конфигурации
    /// </summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <returns></returns>
    internal static string GetServerTimeZoneForSystemConfig(ITransformationProvider transform)
    {
      string zoneForSystemConfig;
      switch (1)
      {
        case 1:
          try
          {
            int num1 = 9;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              num1 = 1;
            TimeZoneModel timeZoneModel;
            DateTime dateTime;
            int offset;
            while (true)
            {
              switch (num1)
              {
                case 1:
                case 6:
                  zoneForSystemConfig = (string) TZ.IWsM4OCbb8VXM6IkPas((object) timeZoneModel);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 1;
                  continue;
                case 2:
                  offset = checked (TZ.F3w5PNQsJtb8mdxNn0W(unchecked (TZ.RPlja5QUIMDL2ZoxUC7(dateTime, TZ.bYXj4JQLGmyo44apape()).TotalMinutes / 30.0 + 0.5)) * 30);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                  continue;
                case 3:
                  timeZoneModel = new TimeZoneModel((string) TZ.wCvhV1CFSD3pMf1BNUC(TZ.H4DPxnQzZcwOB5J9DpT()), (string) TZ.D5YWY7CoxaBkQEGAuaH(TZ.b3EwGSCWkVaoWoLrNag(TZ.gyRXh3CBiSbGv3cwuOo(TZ.H4DPxnQzZcwOB5J9DpT()), TZ.dHQLrAQ9x4QVAkERedD(~289714581 ^ -289704412), (object) string.Empty)), offset, false);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                  continue;
                case 4:
                  goto label_1;
                case 5:
                  dateTime = (DateTime) transform.ExecuteScalar((string) TZ.uwgF7VQYq8DDAcclaVm(TZ.dHQLrAQ9x4QVAkERedD(1051802738 - -1831968059 ^ -1411194451), (object) ((Dialect) TZ.hUryknQ5MuXgbBMQa7P((object) transform)).CurrentTimestamp, TZ.dHQLrAQ9x4QVAkERedD(-710283084 ^ -537863435 ^ 173609555), TZ.x6Xc2FQjAEk6PFlOUpS(TZ.hUryknQ5MuXgbBMQa7P((object) transform), TZ.dHQLrAQ9x4QVAkERedD(-2106517564 ^ -2106511386))), (Dictionary<string, object>) null);
                  num1 = 2;
                  continue;
                case 7:
                  TZ.ascNSSQgxfoBNQyHjpH();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 5;
                  continue;
                case 8:
                  if (!TZ.T2RLuCQcyiSpXDsiRg1((object) timeZoneModel, (object) null))
                  {
                    num1 = 6;
                    continue;
                  }
                  goto case 3;
                case 9:
                  TZ.qd6WHfQrMRoFr37gMBu();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 7 : 3;
                  continue;
                default:
                  timeZoneModel = TZ.TimeZones.FirstOrDefault<TimeZoneModel>((Func<TimeZoneModel, bool>) (tz =>
                  {
                    int num2 = 1;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          if (tz.Offset == offset)
                          {
                            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                            continue;
                          }
                          goto label_5;
                        default:
                          goto label_4;
                      }
                    }
label_4:
                    // ISSUE: reference to a compiler-generated method
                    return !TZ.\u003C\u003Ec__DisplayClass8_0.lkpQbvf7I2ORhQuG1sTe((object) tz);
label_5:
                    return false;
                  }));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 8 : 1;
                  continue;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
              num = 0;
            switch (num)
            {
              default:
                throw new InitializationException((string) TZ.y9JBUcQdqMje0efNIJF(TZ.dHQLrAQ9x4QVAkERedD(-2107978722 ^ -2107968390)), ex);
            }
          }
      }
label_1:
      return zoneForSystemConfig;
    }

    /// <summary>
    /// Смещение часового пояса сервера относительно UTC в минутах
    /// </summary>
    public static int ServerOffset
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!TZ.serverTimeZoneOffset.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              TZ.serverTimeZoneOffset = new int?(TZ.f7MZFnCGPf0PkI62Dbf(TZ.QbM3wUChjTrfMEwZq4L()));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return TZ.serverTimeZoneOffset.Value;
      }
    }

    /// <summary>
    /// Смещение часового пояса приложения относительно UTC в минутах
    /// </summary>
    public static int RuntimeOffset
    {
      get
      {
        int num = 4;
        TimeSpan offset;
        DateTimeOffset dateTimeOffset;
        while (true)
        {
          switch (num)
          {
            case 1:
              dateTimeOffset = TZ.RWWXcJCEw8sOxnjc0L6();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 2;
              continue;
            case 2:
              offset = dateTimeOffset.Offset;
              num = 5;
              continue;
            case 4:
              if (TZ.runtimeTimeZoneOffset.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 2;
                continue;
              }
              goto case 1;
            case 5:
              TZ.runtimeTimeZoneOffset = new int?(TZ.F3w5PNQsJtb8mdxNn0W(offset.TotalMinutes));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return TZ.runtimeTimeZoneOffset.Value;
      }
    }

    /// <summary>
    /// Смещение часового пояса текущего пользователя относительно UTC в минутах
    /// </summary>
    public static int ClientOffset => TZ.f7MZFnCGPf0PkI62Dbf((object) ((ITimeZoneService) TZ.v00b1PCfdohELX7PoV6()).CurrentUserTimeZone);

    /// <summary>Текущий момент времени текущего пользователя</summary>
    public static DateTime ClientDateTimeNow
    {
      get
      {
        object name = TZ.dHQLrAQ9x4QVAkERedD(-867826612 ^ -867812212);
        Func<DateTime> func = TZ.\u003C\u003Ec.\u003C\u003E9__18_0;
        Func<DateTime> val;
        if (func == null)
          TZ.\u003C\u003Ec.\u003C\u003E9__18_0 = val = (Func<DateTime>) (() => TZ.\u003C\u003Ec.pddU39f7qrG7gdhZTnoQ().ToClientDateTime());
        else
          goto label_1;
label_3:
        return ContextVars.GetOrAdd<DateTime>((string) name, val);
label_1:
        val = func;
        goto label_3;
      }
    }

    /// <summary>Текущия дата текущего пользователя</summary>
    public static DateTime CurrentClientDate
    {
      get
      {
        int num = 1;
        DateTime dateTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              dateTime = TZ.kf9DwRCQhxhwlbHA4Mf();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return dateTime.Date;
      }
    }

    /// <summary>Значение времени допустимо для преобразования</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    private static bool IsServerRuntimeSideTransformationValid(DateTime dateTime)
    {
      int num1 = 10;
      DateTime dateTime1;
      DateTime dateTime2;
      while (true)
      {
        int num2 = num1;
        int serverDtAndRuntimeDt;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_3;
            case 3:
            case 9:
              goto label_6;
            case 4:
              if (serverDtAndRuntimeDt <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 5:
              dateTime2 = TZ.MinThreshold.Value;
              num2 = 4;
              continue;
            case 6:
              goto label_16;
            case 7:
              dateTime1 = TZ.MaxThreshold.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 5 : 5;
              continue;
            case 8:
              goto label_17;
            case 10:
              if (TZ.HoyhmQCCqT7MZAUcMgL(dateTime, DateTime.MinValue))
              {
                num2 = 9;
                continue;
              }
              break;
          }
          if (dateTime == DateTime.MaxValue)
            num2 = 3;
          else
            goto label_7;
        }
label_4:
        if (serverDtAndRuntimeDt >= 0)
        {
          num1 = 8;
          continue;
        }
        goto label_16;
label_7:
        serverDtAndRuntimeDt = TZ.diffBtServerDtAndRuntimeDt;
        num1 = 7;
      }
label_3:
      return TZ.R5kt3VCvW3wgroBKBi0(dateTime, dateTime1);
label_6:
      return false;
label_16:
      return TZ.ru8pQyC8BhrTVZqopZW(dateTime, dateTime2);
label_17:
      return true;
    }

    /// <summary>RuntimeDateTime --&gt; ServerDateTime</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Серверное время</returns>
    public static DateTime ToServerDateTime(this DateTime runtimeDateTime)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!TZ.oOqmKICInkIxedWiatA(runtimeDateTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            if (!TZ.atWLqxCZ1tVKv1YXexW())
            {
              num = 2;
              continue;
            }
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return DateTime.SpecifyKind(runtimeDateTime, DateTimeKind.Unspecified);
label_3:
      return TZ.Oc1C75CuFqXJWep8ERZ(runtimeDateTime.AddMinutes((double) TZ.diffBtServerDtAndRuntimeDt), DateTimeKind.Unspecified);
label_4:
      return TZ.Oc1C75CuFqXJWep8ERZ(runtimeDateTime, DateTimeKind.Unspecified);
    }

    /// <summary>ServerDateTime --&gt; RuntimeDateTime</summary>
    /// <param name="serverDateTime">Серверное время</param>
    /// <returns>Локальное время</returns>
    public static DateTime ToRuntimeDateTimeFromServer(this DateTime serverDateTime)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TZ.atWLqxCZ1tVKv1YXexW())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            }
            if (!TZ.IsServerRuntimeSideTransformationValid(serverDateTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return TZ.Oc1C75CuFqXJWep8ERZ(serverDateTime, DateTimeKind.Unspecified);
label_3:
      return DateTime.SpecifyKind(serverDateTime.AddMinutes((double) -TZ.diffBtServerDtAndRuntimeDt), DateTimeKind.Local);
label_6:
      return TZ.Oc1C75CuFqXJWep8ERZ(serverDateTime, DateTimeKind.Local);
    }

    /// <summary>ServerDateTime == RuntimeDateTime</summary>
    /// <returns></returns>
    private static bool IsServerTimeZoneRuntimeTimeZone() => TZ.diffBtServerDtAndRuntimeDt == 0;

    /// <summary>RuntimeDateTime --&gt; ClientDateTime</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns></returns>
    public static DateTime ToClientDateTime(this DateTime runtimeDateTime, TZSettings settings = null) => ((ITimeZoneService) TZ.v00b1PCfdohELX7PoV6()).ToClientDateTime(runtimeDateTime, settings);

    /// <summary>ClientDateTime --&gt; RuntimeDateTime</summary>
    /// <param name="clientDateTime">Пользовательское время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns>Локальное время</returns>
    public static DateTime ToRuntimeDateTimeFromClient(
      this DateTime clientDateTime,
      TZSettings settings = null)
    {
      return TZ.TimeZoneService.ToRuntimeDateTimeFromClient(clientDateTime, settings);
    }

    /// <summary>ClientDateTime --&gt; RuntimeDateTime</summary>
    /// <param name="clientDateTimeString">Пользовательское время в строковом представлении</param>
    /// <returns>Локальное время в строковом представлении</returns>
    public static string ToRuntimeDateTimeFromClient(string clientDateTimeString)
    {
      int num = 1;
      DateTime dateTimeFromClient;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(clientDateTimeString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            goto label_2;
          default:
            DateTime result;
            if (DateTime.TryParse(clientDateTimeString, out result))
            {
              dateTimeFromClient = result.ToRuntimeDateTimeFromClient();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
            continue;
        }
      }
label_2:
      return (string) null;
label_6:
      return dateTimeFromClient.ToString((IFormatProvider) TZ.ndAjtBCVOndr3I0frI9());
    }

    /// <summary>Коллекция часовых поясов в ключевой локали</summary>
    public static IEnumerable<TimeZoneModel> TimeZones
    {
      get
      {
        if (TZ.timeZones == null)
          TZ.InitializeTimeZoneCollection();
        return TZ.timeZones;
      }
    }

    /// <summary>
    /// Инициализация коллекции часовых поясов в ключевой локали
    /// </summary>
    private static void InitializeTimeZoneCollection()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            TZ.vwMIj4CiqtqVj5aIl89(TZ.ff7tn0CSVqRDghoOVAn(), (object) (System.Action) (() =>
            {
              int num2 = 2;
              List<TimeZoneModel> timeZoneModelList;
              IEnumerator<XElement> enumerator;
              while (true)
              {
                int num3 = num2;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_57;
                    case 1:
                      goto label_60;
                    case 2:
                      timeZoneModelList = new List<TimeZoneModel>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_3;
                    default:
                      goto label_52;
                  }
                }
label_60:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                enumerator = ((XContainer) TZ.\u003C\u003Ec.ct2YCgf7TvVfsbcwbyGK(TZ.\u003C\u003Ec.zBZ2pGf7XiAsmuHb2jFA((object) new TextTemplateGenerator((string) TZ.\u003C\u003Ec.zQiswNf7Ki5w8V5FIkRe()), (object) new \u003C\u003Ef__AnonymousType8()))).Descendants((XName) TZ.\u003C\u003Ec.lGbrTMf7kMajkbrwKGmW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787148965))).GetEnumerator();
                num2 = 3;
              }
label_57:
              return;
label_52:
              return;
label_3:
              try
              {
label_28:
                // ISSUE: reference to a compiler-generated method
                if (TZ.\u003C\u003Ec.qeTMOnf73FltHRRhSAqT((object) enumerator))
                  goto label_26;
                else
                  goto label_29;
label_5:
                XElement current;
                int num4;
                while (true)
                {
                  int num5;
                  XElement xelement1;
                  string s1;
                  string timeZoneId;
                  string name;
                  int result1;
                  string s2;
                  XElement xelement2;
                  XElement xelement3;
                  XElement xelement4;
                  int result2;
                  switch (num4)
                  {
                    case 1:
                    case 3:
                    case 22:
                    case 26:
                    case 32:
                      goto label_28;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!TZ.\u003C\u003Ec.nHjyHPf7PF9TmjAdvFJm((object) name))
                      {
                        num5 = 4;
                        break;
                      }
                      goto case 25;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (TZ.\u003C\u003Ec.nHjyHPf7PF9TmjAdvFJm((object) s2))
                      {
                        num4 = 25;
                        continue;
                      }
                      goto case 16;
                    case 5:
                      List<TimeZoneModel> source1 = timeZoneModelList;
                      // ISSUE: reference to a compiler-generated field
                      Func<TimeZoneModel, int> func1 = TZ.\u003C\u003Ec.\u003C\u003E9__34_1;
                      Func<TimeZoneModel, int> keySelector1;
                      if (func1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        TZ.\u003C\u003Ec.\u003C\u003E9__34_1 = keySelector1 = (Func<TimeZoneModel, int>) (tz => tz.Offset);
                      }
                      else
                        goto label_64;
label_46:
                      IOrderedEnumerable<TimeZoneModel> source2 = source1.OrderBy<TimeZoneModel, int>(keySelector1);
                      // ISSUE: reference to a compiler-generated field
                      Func<TimeZoneModel, string> func2 = TZ.\u003C\u003Ec.\u003C\u003E9__34_2;
                      Func<TimeZoneModel, string> keySelector2;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        TZ.\u003C\u003Ec.\u003C\u003E9__34_2 = keySelector2 = (Func<TimeZoneModel, string>) (tz => tz.TimeZoneId);
                      }
                      else
                        goto label_63;
label_48:
                      IOrderedEnumerable<TimeZoneModel> source3 = source2.ThenBy<TimeZoneModel, string>(keySelector2);
                      // ISSUE: reference to a compiler-generated field
                      Func<TimeZoneModel, bool> func3 = TZ.\u003C\u003Ec.\u003C\u003E9__34_3;
                      Func<TimeZoneModel, bool> keySelector3;
                      if (func3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        TZ.\u003C\u003Ec.\u003C\u003E9__34_3 = keySelector3 = (Func<TimeZoneModel, bool>) (tz => tz.Dst);
                      }
                      else
                        goto label_62;
label_51:
                      TZ.timeZones = (IEnumerable<TimeZoneModel>) source3.ThenBy<TimeZoneModel, bool>(keySelector3);
                      num4 = 22;
                      continue;
label_62:
                      keySelector3 = func3;
                      goto label_51;
label_63:
                      keySelector2 = func2;
                      goto label_48;
label_64:
                      keySelector1 = func1;
                      goto label_46;
                    case 6:
                      goto label_26;
                    case 7:
                      s2 = xelement4.Value;
                      num4 = 27;
                      continue;
                    case 8:
                      if (xelement4 == null)
                      {
                        num4 = 13;
                        continue;
                      }
                      goto case 17;
                    case 9:
                      if (xelement3 != null)
                      {
                        num5 = 31;
                        break;
                      }
                      goto case 13;
                    case 10:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      xelement3 = (XElement) TZ.\u003C\u003Ec.KJkqoRf7OayT9aYb5kKM((object) current, (object) (XName) (string) TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(~210725948 ^ -210759011));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 15 : 20;
                      continue;
                    case 11:
                      timeZoneModelList.Add(new TimeZoneModel(timeZoneId, name, result2, true));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 5;
                      continue;
                    case 12:
                      if (!int.TryParse(s1, out result2))
                      {
                        num4 = 28;
                        continue;
                      }
                      goto case 11;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      TZ.\u003C\u003Ec.qryayJf721RQrfpWAZpM((object) Logger.Log, TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(874012245 ^ 874331143));
                      num5 = 26;
                      break;
                    case 14:
                      // ISSUE: reference to a compiler-generated method
                      if (!TZ.\u003C\u003Ec.nHjyHPf7PF9TmjAdvFJm((object) s1))
                      {
                        num4 = 12;
                        continue;
                      }
                      goto case 5;
                    case 15:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      xelement1 = (XElement) TZ.\u003C\u003Ec.KJkqoRf7OayT9aYb5kKM((object) current, (object) (XName) (string) TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(2008901894 << 3 ^ -1108464808));
                      num4 = 24;
                      continue;
                    case 16:
                      if (int.TryParse(s2, out result1))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 12 : 18;
                        continue;
                      }
                      goto case 21;
                    case 17:
                      // ISSUE: reference to a compiler-generated method
                      timeZoneId = (string) TZ.\u003C\u003Ec.YPQ4Kyf7eXNksYOKmSG1((object) xelement3);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 30 : 29;
                      continue;
                    case 18:
                    case 19:
                      timeZoneModelList.Add(new TimeZoneModel(timeZoneId, name, result1, false));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 15 : 7;
                      continue;
                    case 20:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      xelement2 = (XElement) TZ.\u003C\u003Ec.KJkqoRf7OayT9aYb5kKM((object) current, TZ.\u003C\u003Ec.lGbrTMf7kMajkbrwKGmW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536775594)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                      continue;
                    case 21:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      TZ.\u003C\u003Ec.qryayJf721RQrfpWAZpM(TZ.\u003C\u003Ec.NdJcSpf71FyldDfkbYnP(), TZ.\u003C\u003Ec.JaCI4uf7NxbLGbKHutHI(TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(-1487388570 ^ -1487068320), (object) s2, (object) timeZoneId));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 3;
                      continue;
                    case 23:
                      goto label_49;
                    case 24:
                      if (xelement1 != null)
                      {
                        num4 = 29;
                        continue;
                      }
                      goto case 5;
                    case 25:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      TZ.\u003C\u003Ec.qryayJf721RQrfpWAZpM(TZ.\u003C\u003Ec.NdJcSpf71FyldDfkbYnP(), TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(-1939377524 ^ -1939730392));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 32 : 10;
                      continue;
                    case 27:
                      // ISSUE: reference to a compiler-generated method
                      if (!TZ.\u003C\u003Ec.nHjyHPf7PF9TmjAdvFJm((object) timeZoneId))
                      {
                        num4 = 2;
                        continue;
                      }
                      goto case 25;
                    case 28:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      TZ.\u003C\u003Ec.qryayJf721RQrfpWAZpM(TZ.\u003C\u003Ec.NdJcSpf71FyldDfkbYnP(), TZ.\u003C\u003Ec.JaCI4uf7NxbLGbKHutHI(TZ.\u003C\u003Ec.yWCNDef7nVSfCVcj2Ajl(1514961705 ^ 1514739799), (object) s2, (object) timeZoneId));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                      continue;
                    case 29:
                      // ISSUE: reference to a compiler-generated method
                      s1 = (string) TZ.\u003C\u003Ec.YPQ4Kyf7eXNksYOKmSG1((object) xelement1);
                      num4 = 14;
                      continue;
                    case 30:
                      name = xelement2.Value;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 7 : 7;
                      continue;
                    case 31:
                      if (xelement2 != null)
                      {
                        num4 = 8;
                        continue;
                      }
                      goto case 13;
                    default:
                      xelement4 = current.Element((XName) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123647348));
                      num4 = 9;
                      continue;
                  }
                  num4 = num5;
                }
label_49:
                return;
label_26:
                current = enumerator.Current;
                num4 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                {
                  num4 = 10;
                  goto label_5;
                }
                else
                  goto label_5;
label_29:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 23;
                goto label_5;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        TZ.\u003C\u003Ec.puNP7Uf7pspv6fTjU81H((object) enumerator);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_59;
                    }
                  }
                }
label_59:;
              }
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Десериализовать JSON TimeZoneModel</summary>
    /// <param name="data">Сериализованные данные часового пояса</param>
    /// <returns></returns>
    public static TimeZoneModel Deserialize(string data) => JsonConvert.DeserializeObject<TimeZoneModel>(data);

    /// <summary>
    /// Настройка преобразования времени для отображения в пользовательском часовом поясе
    /// </summary>
    public static TZSettings Client => new TZSettings(TZSettings.TZType.Client, TZ.vpWu6oCR3emRshksOsG());

    /// <summary>
    /// Настройка преобразования времени для отображения в локальном часовом поясе приложения
    /// </summary>
    public static TZSettings Runtime => TZ.tzSettingsRuntime.Value;

    /// <summary>
    /// Настройка преобразования времени для отображения в серверном часовом поясе
    /// </summary>
    public static TZSettings Server => TZ.tzSettingsServer.Value;

    /// <summary>
    /// Получить настройку преобразования времени с произвольным смещением часового пояса
    /// </summary>
    /// <param name="timeZoneOffset">Произвольное смещение часового пояса в минутах</param>
    /// <returns>Настройка преобразования времени для отображения в произвольном часовом поясе</returns>
    public static TZSettings Utc(int timeZoneOffset) => new TZSettings(TZSettings.TZType.Custom, timeZoneOffset);

    /// <summary>
    /// Настройка преобразования времени для отображения не учитывая временные зоны
    /// </summary>
    public static TZSettings WithoutOffset => new TZSettings(TZSettings.TZType.WithoutOffset, 0);

    static TZ()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              TZ.nWSX8rCqLIltFdqhjtK();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              // ISSUE: reference to a compiler-generated method
              TZ.tzSettingsServer = new Lazy<TZSettings>((Func<TZSettings>) (() => new TZSettings(TZSettings.TZType.Server, TZ.\u003C\u003Ec.DGRmvif7DYoQmoWNVNqu())));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 2;
              continue;
            case 4:
              TZ.MinThreshold = new Lazy<DateTime>((Func<DateTime>) (() =>
              {
                int num3 = 2;
                DateTime minValue;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_2;
                    case 2:
                      if (TZ.diffBtServerDtAndRuntimeDt < 0)
                      {
                        minValue = DateTime.MinValue;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                        continue;
                      }
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_6;
                  }
                }
label_2:
                return DateTime.MinValue;
label_6:
                return minValue.AddMinutes((double) -TZ.diffBtServerDtAndRuntimeDt);
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 5;
              continue;
            case 5:
              goto label_4;
            default:
              TZ.MaxThreshold = new Lazy<DateTime>((Func<DateTime>) (() =>
              {
                int num4 = 2;
                DateTime maxValue;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      if (TZ.diffBtServerDtAndRuntimeDt <= 0)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                        continue;
                      }
                      maxValue = DateTime.MaxValue;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return maxValue.AddMinutes((double) -TZ.diffBtServerDtAndRuntimeDt);
label_5:
                return DateTime.MaxValue;
              }));
              num2 = 4;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        TZ.tzSettingsRuntime = new Lazy<TZSettings>((Func<TZSettings>) (() => new TZSettings(TZSettings.TZType.Runtime, TZ.\u003C\u003Ec.nvkyW8f7aqc9K1G8yK3Z())));
        num1 = 3;
      }
label_3:;
    }

    internal static bool h2UV2IQynbgVwgGn4ef() => TZ.A2LDXDQmdxxg5KFGq2i == null;

    internal static TZ Y6uv1TQM9xpaPa3EQVk() => TZ.A2LDXDQmdxxg5KFGq2i;

    internal static object nDZqjqQJdYAmqhBdLct([In] object obj0) => (object) TZ.Deserialize((string) obj0);

    internal static object dHQLrAQ9x4QVAkERedD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object y9JBUcQdqMje0efNIJF([In] object obj0) => (object) SR.T((string) obj0);

    internal static int Jg73imQlitfmEYOxCc8() => TZ.RuntimeOffset;

    internal static void qd6WHfQrMRoFr37gMBu() => TZ.InitializeTimeZoneCollection();

    internal static void ascNSSQgxfoBNQyHjpH() => TimeZoneInfo.ClearCachedData();

    internal static object hUryknQ5MuXgbBMQa7P([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object x6Xc2FQjAEk6PFlOUpS([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object uwgF7VQYq8DDAcclaVm([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static DateTime bYXj4JQLGmyo44apape() => DateTime.UtcNow;

    internal static TimeSpan RPlja5QUIMDL2ZoxUC7([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static int F3w5PNQsJtb8mdxNn0W([In] double obj0) => Convert.ToInt32(obj0);

    internal static bool T2RLuCQcyiSpXDsiRg1([In] object obj0, [In] object obj1) => (TimeZoneModel) obj0 == (TimeZoneModel) obj1;

    internal static object H4DPxnQzZcwOB5J9DpT() => (object) TimeZoneInfo.Local;

    internal static object wCvhV1CFSD3pMf1BNUC([In] object obj0) => (object) ((TimeZoneInfo) obj0).Id;

    internal static object gyRXh3CBiSbGv3cwuOo([In] object obj0) => (object) ((TimeZoneInfo) obj0).DisplayName;

    internal static object b3EwGSCWkVaoWoLrNag([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2);

    internal static object D5YWY7CoxaBkQEGAuaH([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object IWsM4OCbb8VXM6IkPas([In] object obj0) => (object) ((TimeZoneModel) obj0).ToJson();

    internal static object QbM3wUChjTrfMEwZq4L() => (object) TZ.ServerTimeZone;

    internal static int f7MZFnCGPf0PkI62Dbf([In] object obj0) => ((TimeZoneModel) obj0).Offset;

    internal static DateTimeOffset RWWXcJCEw8sOxnjc0L6() => DateTimeOffset.Now;

    internal static object v00b1PCfdohELX7PoV6() => (object) TZ.TimeZoneService;

    internal static DateTime kf9DwRCQhxhwlbHA4Mf() => TZ.ClientDateTimeNow;

    internal static bool HoyhmQCCqT7MZAUcMgL([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static bool R5kt3VCvW3wgroBKBi0([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static bool ru8pQyC8BhrTVZqopZW([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static bool atWLqxCZ1tVKv1YXexW() => TZ.IsServerTimeZoneRuntimeTimeZone();

    internal static DateTime Oc1C75CuFqXJWep8ERZ([In] DateTime obj0, [In] DateTimeKind obj1) => DateTime.SpecifyKind(obj0, obj1);

    internal static bool oOqmKICInkIxedWiatA(DateTime dateTime) => TZ.IsServerRuntimeSideTransformationValid(dateTime);

    internal static object ndAjtBCVOndr3I0frI9() => (object) CultureInfo.CurrentCulture;

    internal static object ff7tn0CSVqRDghoOVAn() => (object) SR.KeyCultureInfo;

    internal static void vwMIj4CiqtqVj5aIl89([In] object obj0, [In] object obj1) => SR.RunWithCulture((CultureInfo) obj0, (System.Action) obj1);

    internal static int vpWu6oCR3emRshksOsG() => TZ.ClientOffset;

    internal static void nWSX8rCqLIltFdqhjtK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

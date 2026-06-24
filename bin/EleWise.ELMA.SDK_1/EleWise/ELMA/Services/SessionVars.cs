// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.SessionVars
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Статический класс для работы со значениями переменных в рамках сессии пользователя
  /// </summary>
  /// <remarks>
  /// Для работы с ним требуется установить реализующую службу через метод <see cref="M:EleWise.ELMA.Services.SessionVars.SetImpl(EleWise.ELMA.Services.ISessionBoundVariableService)" />
  /// </remarks>
  [DeveloperApi(DeveloperApiType.Service)]
  public static class SessionVars
  {
    private static readonly ConcurrentDictionary<string, object> LockObjects;
    private static ISessionBoundVariableService service;
    private static SessionVars UJpcbQB0W8PVThLSdTNR;

    /// <summary>Установить реализущую службу</summary>
    /// <param name="service">Служба</param>
    public static void SetImpl(ISessionBoundVariableService service)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SessionVars.PfilT3B0G0UTJ6b7UNMu((object) service, SessionVars.RoJJKVB0hUT8M4x79glc(-35995181 ^ -35937869));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SessionVars.service = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Содержится ли значение переменной</summary>
    /// <param name="name">Имя переменной</param>
    /// <returns>True, если содержится</returns>
    public static bool Contains(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SessionVars.CheckImpl();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return SessionVars.mSNbyDB0E6sbeaVm8f35((object) SessionVars.service, (object) name);
    }

    /// <summary>Получить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.VariableNotFoundException">Исключение "Переменная не найдена"</exception>
    /// <returns>Значение переменной</returns>
    public static T Get<T>(string name)
    {
      SessionVars.CheckImpl();
      return SessionVars.service.Get<T>(name);
    }

    /// <summary>Попытаться получить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Полученное значение (или значение по умолчанию для типа <typeparamref name="T" />, если элемент не найден)</param>
    /// <returns>True, если переменная найдена</returns>
    public static bool TryGetValue<T>(string name, out T value)
    {
      SessionVars.CheckImpl();
      return SessionVars.service.TryGetValue<T>(name, out value);
    }

    /// <summary>
    /// Получить значение переменной, или установить из функции.
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="val">Функция для получения значения</param>
    /// <returns>Значение переменной</returns>
    public static T GetOrAdd<T>(string name, Func<T> val)
    {
      SessionVars.CheckImpl();
      T orAdd1;
      if (SessionVars.service.TryGetValue<T>(name, out orAdd1))
        return orAdd1;
      if (val == null)
        throw new VariableNotFoundException(name);
      lock (SessionVars.LockObjects.GetOrAdd(name, (Func<string, object>) (i => new object())))
      {
        if (SessionVars.service.TryGetValue<T>(name, out orAdd1))
          return orAdd1;
        T orAdd2 = val();
        SessionVars.service.Set(name, (object) orAdd2);
        SessionVars.LockObjects.TryRemove(name, out object _);
        return orAdd2;
      }
    }

    /// <summary>Установить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Значение переменной</param>
    public static void Set<T>(string name, T value)
    {
      SessionVars.CheckImpl();
      SessionVars.service.Set(name, (object) value);
    }

    /// <summary>Проверить инициализацию сервиса</summary>
    private static void CheckImpl()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SessionVars.service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new NotInitializedException(EleWise.ELMA.SR.T((string) SessionVars.RoJJKVB0hUT8M4x79glc(-1852837372 ^ -1852927278)));
    }

    static SessionVars()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SessionVars.LockObjects = new ConcurrentDictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object RoJJKVB0hUT8M4x79glc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PfilT3B0G0UTJ6b7UNMu([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool hKcBK9B0ocKOJe4MJIgv() => SessionVars.UJpcbQB0W8PVThLSdTNR == null;

    internal static SessionVars WH7mHWB0bDmOcC5ZglRv() => SessionVars.UJpcbQB0W8PVThLSdTNR;

    internal static bool mSNbyDB0E6sbeaVm8f35([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Contains((string) obj1);
  }
}

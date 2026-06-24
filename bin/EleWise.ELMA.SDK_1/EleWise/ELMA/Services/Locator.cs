// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Locator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Менеджер служб</summary>
  public static class Locator
  {
    /// <summary>Реализация менеджера</summary>
    private static ILocatorImpl _impl;
    internal static Locator kvf8HvB0voAmIXwCoRE5;

    /// <summary>
    /// Получить службу с указанным типом и именем, с проверкой существования службы или без нее
    /// </summary>
    /// <param name="type">Тип службы</param>
    /// <param name="name">Имя службы</param>
    /// <param name="checkNotNull">Нужно ли проверить, чтобы служба сущствовала</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если запрашиваемая служба не найдена</exception>
    [CanBeNull]
    public static object GetService(Type type, string name, bool checkNotNull)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              Locator.j4wacHB0Sj48FuCYCK1x();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 2:
              num3 = 1;
              break;
            case 3:
              if (!Locator.G07KT2B0uQxyPWH75Mfd(type, (Type) null))
                goto case 4;
              else
                goto label_6;
            case 4:
              num3 = name != null ? 1 : 0;
              break;
            default:
              goto label_9;
          }
          object obj = Locator.LPMnLGB0I1icl4DMaIUm(-1334993905 ^ -1335034571);
          Locator.Vb1RxfB0VHLjrKdGwYXl(num3 != 0, obj);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
        }
label_6:
        num1 = 2;
      }
label_9:
      object obj1 = Locator.XoJudvB0io80xr32GXDJ((object) Locator._impl, type, (object) name);
      return !(obj1 == null & checkNotNull) ? obj1 : throw new ServiceNotFoundException(name ?? type.FullName);
    }

    /// <summary>
    /// Получить службу с указанным типом и именем (без проверки существования)
    /// </summary>
    /// <param name="type">Тип службы</param>
    /// <param name="name">Имя службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    [CanBeNull]
    public static object GetService(Type type, string name) => Locator.luw62pB0RLWWYwTO84gB(type, (object) name, false);

    /// <summary>
    /// Получить службу с указанным типом и именем (с проверкой существования)
    /// </summary>
    /// <param name="type">Тип службы</param>
    /// <param name="name">Имя службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если запрашиваемая служба не найдена</exception>
    [NotNull]
    public static object GetServiceNotNull(Type type, string name) => Locator.luw62pB0RLWWYwTO84gB(type, (object) name, true);

    /// <summary>
    /// Получить службу с указанным типом (без проверки существования)
    /// </summary>
    /// <param name="type">Тип службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    [CanBeNull]
    public static object GetService(Type type) => Locator.GetService(type, (string) null, false);

    /// <summary>
    /// Получить службу с указанным типом (с проверкой существования)
    /// </summary>
    /// <param name="type">Тип службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если запрашиваемая служба не найдена</exception>
    [NotNull]
    public static object GetServiceNotNull(Type type) => Locator.luw62pB0RLWWYwTO84gB(type, (object) null, true);

    /// <summary>
    /// Получить службу с указанным типом (без проверки существования)
    /// </summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    [CanBeNull]
    public static T GetService<T>() => (T) Locator.GetService(typeof (T), (string) null, false);

    /// <summary>
    /// Получить службу с указанным типом (с проверкой существования)
    /// </summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если запрашиваемая служба не найдена</exception>
    [NotNull]
    public static T GetServiceNotNull<T>() => (T) Locator.GetService(typeof (T), (string) null, true);

    /// <summary>
    /// Получить службу с указанным типом и именем (без проверки существования)
    /// </summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <param name="name">Имя службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    [CanBeNull]
    public static T GetService<T>(string name) => (T) Locator.GetService(typeof (T), name, false);

    /// <summary>
    /// Получить службу с указанным типом и именем (с проверкой существования)
    /// </summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <param name="name">Имя службы</param>
    /// <returns>Запрашиваемая служба</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.NotInitializedException">Если менеджер служб не инициализирован</exception>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если запрашиваемая служба не найдена</exception>
    [NotNull]
    public static T GetServiceNotNull<T>(string name) => (T) Locator.GetService(typeof (T), name, true);

    /// <summary>Зарегистрировать службу</summary>
    /// <param name="type">Тип службы</param>
    /// <param name="obj">Служба</param>
    public static void AddService(Type type, object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Locator.jNPF3fB0qEtcsIA2rGEk(type, obj, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Зарегистрировать службу</summary>
    /// <param name="type">Тип службы</param>
    /// <param name="obj">Служба</param>
    /// <param name="resolveProperties">Обрабатывать публичные свойства при регистрации</param>
    public static void AddService(Type type, object obj, bool resolveProperties)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Locator.RL1cGAB0KwslTrkK3kXf((object) Locator._impl, type, obj, resolveProperties);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Зарегистрировать существующую службу</summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <param name="obj">Служба</param>
    public static void AddService<T>(T obj) => Locator.AddService(typeof (T), (object) obj);

    /// <summary>Зарегистрировать существующую службу</summary>
    /// <typeparam name="T">Тип службы</typeparam>
    /// <param name="obj">Служба</param>
    /// <param name="resolveProperties">Обрабатывать публичные свойства при регистрации</param>
    public static void AddService<T>(T obj, bool resolveProperties) => Locator.AddService(typeof (T), (object) obj, resolveProperties);

    /// <summary>Разрегистрировать службу</summary>
    /// <param name="type">Тип службы</param>
    public static void RemoveService(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Locator._impl.RemoveService(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Установить реализацию менеджера служб</summary>
    /// <param name="locatorImpl">Реализация менеджера служб</param>
    public static void SetImpl(ILocatorImpl locatorImpl) => Locator._impl = locatorImpl;

    /// <summary>Признак, что менеджер инициализирован</summary>
    public static bool Initialized => Locator._impl != null;

    /// <summary>Проверка, что реализация задана</summary>
    private static void CheckInitialized()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (Locator._impl != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_3:
      throw new NotInitializedException((string) Locator.QkVFsTB0XFDiaZMbaufN(Locator.LPMnLGB0I1icl4DMaIUm(-680446928 - -370807692 ^ -309713206)));
    }

    internal static bool G07KT2B0uQxyPWH75Mfd([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object LPMnLGB0I1icl4DMaIUm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Vb1RxfB0VHLjrKdGwYXl(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static void j4wacHB0Sj48FuCYCK1x() => Locator.CheckInitialized();

    internal static object XoJudvB0io80xr32GXDJ([In] object obj0, Type type, [In] object obj2) => ((ILocatorImpl) obj0).GetService(type, (string) obj2);

    internal static bool Bm228hB08weaSA0IFoNS() => Locator.kvf8HvB0voAmIXwCoRE5 == null;

    internal static Locator rHb0fFB0ZFqnerGmX65S() => Locator.kvf8HvB0voAmIXwCoRE5;

    internal static object luw62pB0RLWWYwTO84gB(Type type, [In] object obj1, bool checkNotNull) => Locator.GetService(type, (string) obj1, checkNotNull);

    internal static void jNPF3fB0qEtcsIA2rGEk(Type type, [In] object obj1, bool resolveProperties) => Locator.AddService(type, obj1, resolveProperties);

    internal static void RL1cGAB0KwslTrkK3kXf(
      [In] object obj0,
      Type type,
      [In] object obj2,
      bool resolveProperties)
    {
      ((ILocatorImpl) obj0).AddService(type, obj2, resolveProperties);
    }

    internal static object QkVFsTB0XFDiaZMbaufN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}

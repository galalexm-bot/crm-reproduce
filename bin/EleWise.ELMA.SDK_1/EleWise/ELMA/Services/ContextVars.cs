// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ContextVars
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Статический класс для работы со значениями переменных в рамках контекста (например, веб-запроса)
  /// </summary>
  /// <remarks>
  /// Для работы с ним требуется установить реализующую службу через метод SetImpl
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public static class ContextVars
  {
    private static IContextBoundVariableService service;
    internal static ContextVars P2gMhkBxAicA39XmEuYU;

    /// <summary>Установлена ли реализация</summary>
    public static bool HasImpl => ContextVars.service != null;

    /// <summary>Установить реализущую службу</summary>
    /// <param name="service">Служба</param>
    public static void SetImpl(IContextBoundVariableService service)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.service = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) service, (string) ContextVars.NHBU0dBx0xvvWKBO6Xn4(-1998538950 ^ -1998465190));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
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
            ContextVars.l0u5jWBxme0RbFRemaod();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ContextVars.idalSIBxygkaKFtlwJx0((object) ContextVars.service, (object) name);
    }

    /// <summary>Получить значение переменной.</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.VariableNotFoundException">Исключение "Переменная не найдена"</exception>
    /// <returns>Значение переменной</returns>
    public static T Get<T>(string name)
    {
      ContextVars.CheckImpl();
      return ContextVars.service.Get<T>(name);
    }

    /// <summary>
    /// Получить значение переменной или значение по умолчанию
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <returns>Значение переменной</returns>
    public static T GetOrDefault<T>(string name)
    {
      T orDefault;
      ContextVars.TryGetValue<T>(name, out orDefault);
      return orDefault;
    }

    /// <summary>Попытаться получить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Полученное значение (или значение по умолчанию для типа <typeparamref name="T" />, если элемент не найден)</param>
    /// <returns>True, если переменная найдена</returns>
    public static bool TryGetValue<T>(string name, out T value)
    {
      ContextVars.CheckImpl();
      return ContextVars.service.TryGetValue<T>(name, out value);
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
      ContextVars.CheckImpl();
      T orAdd1;
      if (ContextVars.service.TryGetValue<T>(name, out orAdd1))
        return orAdd1;
      if (val == null)
        throw new VariableNotFoundException(name);
      T orAdd2 = val();
      ContextVars.service.Set(name, (object) orAdd2);
      return orAdd2;
    }

    /// <summary>Установить значение переменной</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="name">Имя переменной</param>
    /// <param name="value">Значение переменной</param>
    public static void Set<T>(string name, T value)
    {
      ContextVars.CheckImpl();
      ContextVars.service.Set(name, (object) value);
    }

    /// <summary>Удалить значение переменной</summary>
    /// <param name="name"></param>
    public static void Remove(string name)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.YhauegBxMbVabMMVEOFd((object) ContextVars.service, (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            ContextVars.l0u5jWBxme0RbFRemaod();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Очистить все переменные</summary>
    internal static void ClearContext()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!(ContextVars.service is IClearableContextBoundVariableService service))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            ContextVars.qUWXMtBxJ2DdjZucww29((object) service);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
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
            if (ContextVars.service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
      throw new NotInitializedException((string) ContextVars.FcjPJoBx9T7vHueTFaV7(ContextVars.NHBU0dBx0xvvWKBO6Xn4(-2092274397 << 4 ^ 883405378)));
    }

    internal static bool nunQCYBx7BQjwpfGAPkh() => ContextVars.P2gMhkBxAicA39XmEuYU == null;

    internal static ContextVars x64SLdBxx5CDb0lHYRC7() => ContextVars.P2gMhkBxAicA39XmEuYU;

    internal static object NHBU0dBx0xvvWKBO6Xn4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void l0u5jWBxme0RbFRemaod() => ContextVars.CheckImpl();

    internal static bool idalSIBxygkaKFtlwJx0([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Contains((string) obj1);

    internal static void YhauegBxMbVabMMVEOFd([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Remove((string) obj1);

    internal static void qUWXMtBxJ2DdjZucww29([In] object obj0) => ((IClearableContextBoundVariableService) obj0).ClearContext();

    internal static object FcjPJoBx9T7vHueTFaV7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    /// <summary>
    /// Представляет данные, которые являются локальными для данного асинхронного потока управления, такого как асинхронный метод.
    /// Данные сохраняются только в основном асинхронном потоке, не передаются в производные потоки, такие как <see cref="M:System.Threading.Tasks.Task.Run(System.Action)" />.
    /// </summary>
    /// <typeparam name="T">Тип данных</typeparam>
    public class Local<T>
    {
      private readonly string key;
      private readonly Func<T> valueFactory;
      internal static object Fye4dUQnZnGQs2phXgfv;

      /// <summary>ctor</summary>
      public Local()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.key = Guid.NewGuid().ToString();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num = 0;
        switch (num)
        {
        }
      }

      /// <summary>ctor</summary>
      /// <param name="valueFactory">Фабрика значения, если еще не инициализировано</param>
      public Local(Func<T> valueFactory)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.key = Guid.NewGuid().ToString();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.valueFactory = valueFactory;
      }

      /// <summary>Получить или установить значение</summary>
      public T Value
      {
        get
        {
          T obj1;
          if (ContextVars.TryGetValue<T>(this.key, out obj1))
            return obj1;
          if (this.valueFactory == null)
            return default (T);
          T obj2 = this.valueFactory();
          ContextVars.Set<T>(this.key, obj2);
          return obj2;
        }
        set => ContextVars.Set<T>(this.key, value);
      }

      public void Reset()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ContextVars.Remove(this.key);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool CtXcLcQnuH7jbZJOdSPt() => ContextVars.Local<T>.Fye4dUQnZnGQs2phXgfv == null;

      internal static object iKYtc8QnIdfDIIbjKiIi() => ContextVars.Local<T>.Fye4dUQnZnGQs2phXgfv;
    }
  }
}

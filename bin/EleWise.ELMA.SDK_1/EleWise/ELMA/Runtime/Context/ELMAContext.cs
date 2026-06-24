// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Context.ELMAContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Context
{
  /// <summary>
  /// Контекст ELMA, используется для хранение контекстных данных, передается через <see langword="async" />/<see langword="await" />
  /// </summary>
  public abstract class ELMAContext : IDisposable
  {
    private static readonly ConditionalWeakTable<object, IDictionary<string, object>> CacheGlobal;
    [ThreadStatic]
    private static IDictionary<string, object> threadItems;
    private static readonly AsyncLocal<ELMAContext> CurrentContext;
    private readonly bool isolatedContext;
    private readonly IDictionary<string, object> parentThreadItems;
    private readonly ELMAContext parentContext;
    private static readonly IDisposable emptyDisposable;
    internal static ELMAContext aGSsgPW2AHDQH8D1Th2f;

    /// <summary>Ctor</summary>
    /// <param name="isolatedContext"><c>true</c> если необходимо создать изолированный контекст</param>
    protected ELMAContext(bool isolatedContext)
    {
      ELMAContext.SAJqDRW20hPB3ClKofGC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!isolatedContext)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            this.parentContext = ELMAContext.CurrentContext.Value;
            num = 5;
            continue;
          case 4:
            this.isolatedContext = isolatedContext;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 2;
            continue;
          case 6:
            this.parentThreadItems = ELMAContext.threadItems;
            num = 3;
            continue;
          default:
            ELMAContext.CurrentContext.Value = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
        }
      }
label_8:;
    }

    /// <inheritdoc />
    public virtual void Dispose()
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            ELMAContext.wpJk6tW2yY1blktFXXLP((object) this);
            num = 9;
            continue;
          case 2:
          case 5:
            if (ELMAContext.CurrentContext.Value == this)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 4;
              continue;
            }
            goto case 1;
          case 3:
            ELMAContext.threadItems = this.parentThreadItems;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          case 4:
            ELMAContext.CurrentContext.Value = (ELMAContext) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 7;
            continue;
          case 6:
            if (!this.isolatedContext)
            {
              num = 5;
              continue;
            }
            break;
          case 8:
            ELMAContext.CurrentContext.Value = this.parentContext;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 3;
            continue;
          case 9:
            goto label_9;
        }
        ELMAContext.XKmcq0W2mOBxwHXPMe4h((object) ELMAContext.threadItems);
        num = 8;
      }
label_9:;
    }

    /// <summary>
    /// Установить <see cref="T:EleWise.ELMA.Runtime.Context.ELMAContext" /> как текущий для логического потока вызова
    /// </summary>
    internal void SetAsCurrent()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SetAsCurrentInnerLogic();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 2:
            ELMAContext.CurrentContext.Value = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
          case 3:
            if (ELMAContext.CurrentContext.Value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 2;
              continue;
            }
            goto label_7;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    /// <summary>
    /// Дополнительная логика установки <see cref="T:EleWise.ELMA.Runtime.Context.ELMAContext" /> как текущего для логического потока вызова
    /// </summary>
    protected virtual void SetAsCurrentInnerLogic()
    {
    }

    /// <summary>Получить объект-ключ для хранения данных</summary>
    protected abstract object KeyObject { get; }

    /// <summary>Текущий контекст ELMA</summary>
    protected static ELMAContext Current => ELMAContext.CurrentContext.Value;

    /// <summary>Инициализирован ли контекст ELMA</summary>
    protected internal static bool Initialized
    {
      get
      {
        int num = 1;
        ELMAContext elmaContext;
        while (true)
        {
          switch (num)
          {
            case 1:
              elmaContext = ELMAContext.CurrentContext.Value;
              if (elmaContext == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        object obj = (object) null;
        goto label_6;
label_5:
        obj = ELMAContext.fyg8ULW2MJApwEYIGZ4h((object) elmaContext);
label_6:
        return obj > null;
      }
    }

    /// <summary>Изолирован ли контекст ELMA</summary>
    protected internal static bool IsIsolated
    {
      get
      {
        int num = 1;
        ELMAContext elmaContext;
        while (true)
        {
          switch (num)
          {
            case 1:
              elmaContext = ELMAContext.CurrentContext.Value;
              if (elmaContext == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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
        return elmaContext.isolatedContext;
      }
    }

    /// <summary>Контекстные данные</summary>
    protected internal static IDictionary<string, object> Items
    {
      get
      {
        if (ELMAContext.threadItems == null)
        {
          object keyObject = ELMAContext.CurrentContext.Value?.KeyObject;
          if (keyObject == null)
          {
            NullReferenceException referenceException = new NullReferenceException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272494215)));
            Logger.Log.Error((object) (referenceException.Message + Environment.NewLine + (object) new StackTrace(true)));
            throw referenceException;
          }
          if (!ELMAContext.CacheGlobal.TryGetValue(keyObject, out ELMAContext.threadItems))
          {
            try
            {
              ELMAContext.CacheGlobal.Add(keyObject, ELMAContext.threadItems = (IDictionary<string, object>) new ELMAContext.ItemsDictionary());
            }
            catch (ArgumentException ex)
            {
              if (!ELMAContext.CacheGlobal.TryGetValue(keyObject, out ELMAContext.threadItems))
                throw;
            }
          }
        }
        return ELMAContext.threadItems;
      }
    }

    /// <summary>Значения кэшей публикации</summary>
    internal static object PublishCaches
    {
      get => ELMAContext.eEO3rUW2JaoWRocwEv7b((object) (ELMAContext.ItemsDictionary) ELMAContext.Items);
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
              ELMAContext.kavptLW29ZuqxRiapiaA((object) (ELMAContext.ItemsDictionary) ELMAContext.Items, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>Событие перед очисткой данныйх</summary>
    internal static event EventHandler OnClear
    {
      add
      {
        int num = 2;
        EventHandler eventHandler1;
        EventHandler comparand;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              comparand = eventHandler1;
              num = 4;
              continue;
            case 2:
              eventHandler1 = ELMAContext.OnClear;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            case 4:
              eventHandler2 = comparand + value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            case 5:
              if (eventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 1;
                continue;
              }
              goto case 1;
            default:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref ELMAContext.OnClear, eventHandler2, comparand);
              num = 5;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num = 4;
        EventHandler comparand;
        EventHandler eventHandler1;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref ELMAContext.OnClear, eventHandler1, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            case 3:
              comparand = eventHandler2;
              num = 5;
              continue;
            case 4:
              eventHandler2 = ELMAContext.OnClear;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 3;
              continue;
            case 5:
              eventHandler1 = comparand - value;
              num = 2;
              continue;
            default:
              if (eventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
                continue;
              }
              goto case 3;
          }
        }
label_2:;
      }
    }

    /// <summary>Создать контекст ELMA</summary>
    /// <returns>Контекст ELMA</returns>
    public static IDisposable Create() => (IDisposable) ELMAContext.c9pgkTW2dbrT1NwMC4tj(false);

    /// <summary>Создать изолированный контекст ELMA</summary>
    /// <remarks>
    /// Метод следует использовать вместо создания потока для выполнения действия в изолированном окружении
    /// <![CDATA[
    /// using (ELMAContext.Create())
    /// {
    ///     // Работа с данными ContextVars
    ///     // Создаем изолированный ELMAContext
    ///     using (ELMAContext.CreateIsolated())
    ///     {
    ///         // До выхода из using родительский ContextVars не доступен
    ///         // Работа происходит в изолированном контексте.
    ///         // Для работы с БД потребуется создать экземпляр <see cref="CallContextSessionOwner"/>
    ///         using (CallContextSessionOwner.Create())
    ///         {
    ///             // Работа с БД
    ///         }
    ///     }
    ///     // Снова доступен изначальный ContextVars
    /// }
    /// ]]>
    /// </remarks>
    /// <returns>Контекст ELMA</returns>
    public static IDisposable CreateIsolated() => (IDisposable) ELMAContext.c9pgkTW2dbrT1NwMC4tj(true);

    /// <summary>Создать контекст ELMA</summary>
    /// <param name="isolatedContext"><c>true</c> если необходимо создать изолированный контекст</param>
    /// <param name="stackTrace">Кастомный stack trace для вывода в логи</param>
    /// <returns></returns>
    internal static IDisposable Create(bool isolatedContext)
    {
      int num = 3;
      IDisposable disposable;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            disposable = (IDisposable) new ELMAContext.SynchronizationContextELMAContext(isolatedContext);
            num = 4;
            continue;
          case 3:
            if (!ELMAContext.Initialized)
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            goto label_3;
        }
        if (isolatedContext)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
        else
          goto label_4;
      }
label_3:
      return disposable;
label_4:
      return ELMAContext.emptyDisposable;
    }

    static ELMAContext()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              ELMAContext.emptyDisposable = (IDisposable) new ELMAContext.EmptyDisposable();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            case 2:
              ELMAContext.CurrentContext = new AsyncLocal<ELMAContext>((Action<AsyncLocalValueChangedArgs<ELMAContext>>) (args => ELMAContext.threadItems = (IDictionary<string, object>) null));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
              continue;
            case 3:
              ELMAContext.CacheGlobal = new ConditionalWeakTable<object, IDictionary<string, object>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 0;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        ELMAContext.SAJqDRW20hPB3ClKofGC();
        num1 = 3;
      }
label_3:
      return;
label_8:;
    }

    internal static void SAJqDRW20hPB3ClKofGC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool s7R7VRW27tfG2q2xpdqe() => ELMAContext.aGSsgPW2AHDQH8D1Th2f == null;

    internal static ELMAContext aduUe3W2x4ZiNgeTb9jT() => ELMAContext.aGSsgPW2AHDQH8D1Th2f;

    internal static void XKmcq0W2mOBxwHXPMe4h([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();

    internal static void wpJk6tW2yY1blktFXXLP([In] object obj0) => GC.SuppressFinalize(obj0);

    internal static object fyg8ULW2MJApwEYIGZ4h([In] object obj0) => ((ELMAContext) obj0).KeyObject;

    internal static object eEO3rUW2JaoWRocwEv7b([In] object obj0) => ((ELMAContext.ItemsDictionary) obj0).PublishCaches;

    internal static void kavptLW29ZuqxRiapiaA([In] object obj0, [In] object obj1) => ((ELMAContext.ItemsDictionary) obj0).PublishCaches = obj1;

    internal static object c9pgkTW2dbrT1NwMC4tj(bool isolatedContext) => (object) ELMAContext.Create(isolatedContext);

    private class ItemsDictionary : 
      Dictionary<string, object>,
      IDictionary<string, object>,
      ICollection<KeyValuePair<string, object>>,
      IEnumerable<KeyValuePair<string, object>>,
      IEnumerable
    {
      private static object Hib5JxQAinCQJIfyehJ2;

      /// <remarks>
      /// для ускорения доступа к кэшам публикации они находятся не в общем справочнике, а в выделенном поле
      /// </remarks>
      public object PublishCaches
      {
        get => this.\u003CPublishCaches\u003Ek__BackingField;
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
                this.\u003CPublishCaches\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

      void ICollection<KeyValuePair<string, object>>.Clear()
      {
        int num = 2;
        while (true)
        {
          object key;
          object obj;
          switch (num)
          {
            case 1:
            case 8:
              this.Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 2:
              EventHandler onClear = ELMAContext.OnClear;
              if (onClear == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
                continue;
              }
              ELMAContext.ItemsDictionary.oGxbfVQAXf9bclXsGyfo((object) onClear, ELMAContext.ItemsDictionary.yy1FrxQAKNeG4xAnTNkc(), (object) EventArgs.Empty);
              num = 8;
              continue;
            case 3:
              obj = (object) null;
              break;
            case 4:
              goto label_12;
            case 5:
              ELMAContext elmaContext = ELMAContext.CurrentContext.Value;
              if (elmaContext == null)
              {
                num = 3;
                continue;
              }
              obj = elmaContext.KeyObject;
              break;
            case 6:
              ELMAContext.CacheGlobal.Remove(key);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 0;
              continue;
            case 7:
              if (key != null)
              {
                num = 6;
                continue;
              }
              goto label_10;
            default:
              ELMAContext.threadItems = (IDictionary<string, object>) null;
              num = 5;
              continue;
          }
          key = obj;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 6;
        }
label_12:
        return;
label_10:;
      }

      public ItemsDictionary()
      {
        ELMAContext.ItemsDictionary.CXsiAqQATT8LMjGsh3oW();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool zDMAZvQARYvSwdpJiIn7() => ELMAContext.ItemsDictionary.Hib5JxQAinCQJIfyehJ2 == null;

      internal static ELMAContext.ItemsDictionary IEPD28QAqrEW7uW9qkbt() => (ELMAContext.ItemsDictionary) ELMAContext.ItemsDictionary.Hib5JxQAinCQJIfyehJ2;

      internal static object yy1FrxQAKNeG4xAnTNkc() => (object) ELMAContext.Current;

      internal static void oGxbfVQAXf9bclXsGyfo([In] object obj0, [In] object obj1, [In] object obj2) => ((EventHandler) obj0)(obj1, (EventArgs) obj2);

      internal static void CXsiAqQATT8LMjGsh3oW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class EmptyDisposable : IDisposable
    {
      internal static object IAtOTuQAkYx6HTgPtgtG;

      void IDisposable.Dispose()
      {
      }

      public EmptyDisposable()
      {
        ELMAContext.EmptyDisposable.CFWOocQA2H0bpsupdIlO();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void CFWOocQA2H0bpsupdIlO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool mnQlsZQAnWrXV1bQQ1jj() => ELMAContext.EmptyDisposable.IAtOTuQAkYx6HTgPtgtG == null;

      internal static ELMAContext.EmptyDisposable JatTLZQAOAJZqQGpQO95() => (ELMAContext.EmptyDisposable) ELMAContext.EmptyDisposable.IAtOTuQAkYx6HTgPtgtG;
    }

    private class SynchronizationContextELMAContext : ELMAContext
    {
      private readonly bool clearSynchronizationContext;
      private readonly object parentSynchronizationContext;
      private readonly object currentSynchronizationContext;
      private static object cW5v2oQAeexhxYqDoYcp;

      /// <summary>Ctor</summary>
      /// <param name="isolatedContext"><c>true</c> если необходимо создать изолированный контекст</param>
      /// <param name="stackTrace">Кастомный stack trace для вывода в логи</param>
      public SynchronizationContextELMAContext(bool isolatedContext)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(isolatedContext);
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!isolatedContext)
              {
                num = 4;
                continue;
              }
              break;
            case 2:
              SynchronizationContext.SetSynchronizationContext((SynchronizationContext) new ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext());
              num = 3;
              continue;
            case 3:
            case 6:
              this.currentSynchronizationContext = ELMAContext.SynchronizationContextELMAContext.GqnNFCQANpFZsH8dl7G9();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 8;
              continue;
            case 4:
            case 7:
              this.clearSynchronizationContext = true;
              num = 2;
              continue;
            case 5:
              if (!(ELMAContext.SynchronizationContextELMAContext.GqnNFCQANpFZsH8dl7G9() == null | isolatedContext))
              {
                num = 6;
                continue;
              }
              goto case 1;
            case 8:
              goto label_10;
          }
          this.parentSynchronizationContext = ELMAContext.SynchronizationContextELMAContext.GqnNFCQANpFZsH8dl7G9();
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 7 : 1;
        }
label_10:;
      }

      protected override object KeyObject => ELMAContext.SynchronizationContextELMAContext.GqnNFCQANpFZsH8dl7G9();

      public override void Dispose()
      {
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 1:
              ELMAContext.SynchronizationContextELMAContext.J0ZrgjQA3wbRtQgYOK1s((object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 5;
              continue;
            case 2:
              if (this.clearSynchronizationContext)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
                continue;
              }
              goto case 5;
            case 3:
              goto label_3;
            case 4:
              goto label_2;
            case 5:
              base.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 0;
              continue;
            case 6:
              base.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            case 7:
              if (!this.isolatedContext)
              {
                ELMAContext.SynchronizationContextELMAContext.L9liXnQApHEucZJQrTau((object) ELMAContext.Items);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
                continue;
              }
              num = 6;
              continue;
            default:
              ELMAContext.SynchronizationContextELMAContext.J0ZrgjQA3wbRtQgYOK1s(this.parentSynchronizationContext);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 3;
              continue;
          }
        }
label_3:
        return;
label_2:;
      }

      /// <inheritdoc />
      protected override void SetAsCurrentInnerLogic()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ELMAContext.SynchronizationContextELMAContext.J0ZrgjQA3wbRtQgYOK1s(this.currentSynchronizationContext);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static object GqnNFCQANpFZsH8dl7G9() => (object) SynchronizationContext.Current;

      internal static bool qBYr0fQAPWLUrScQAtx8() => ELMAContext.SynchronizationContextELMAContext.cW5v2oQAeexhxYqDoYcp == null;

      internal static ELMAContext.SynchronizationContextELMAContext sebQfQQA1MpiOvigTuPV() => (ELMAContext.SynchronizationContextELMAContext) ELMAContext.SynchronizationContextELMAContext.cW5v2oQAeexhxYqDoYcp;

      internal static void J0ZrgjQA3wbRtQgYOK1s([In] object obj0) => SynchronizationContext.SetSynchronizationContext((SynchronizationContext) obj0);

      internal static void L9liXnQApHEucZJQrTau([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();

      private class InternalSynchronizationContext : SynchronizationContext
      {
        private readonly object taskScheduler;
        private static object JxuVD3Z8qX1wlcRmC6Xc;

        public override void Post(SendOrPostCallback d, object state)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_5;
              case 1:
                ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.qIG71lZ8TTX8HQuT9SLl((object) this, (object) new SendOrPostCallback(this.PostCallback), (object) (d, state));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 3;
                continue;
              case 2:
                if (this.taskScheduler == TaskScheduler.Default)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                  continue;
                }
                new Task(new Action<object>(this.PostCallback), (object) (d, state)).Start((TaskScheduler) this.taskScheduler);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                continue;
              case 3:
                goto label_2;
              default:
                goto label_8;
            }
          }
label_5:
          return;
label_2:
          return;
label_8:;
        }

        private void PostCallback(object state)
        {
          int num = 3;
          (SendOrPostCallback, object) valueTuple;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_2;
              case 2:
                ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.VY3KA4Z8kxPZp3jxoYYU((object) this);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              case 3:
                valueTuple = ((SendOrPostCallback, object)) state;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
                continue;
              default:
                this.Send(valueTuple.Item1, valueTuple.Item2);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                continue;
            }
          }
label_2:;
        }

        public InternalSynchronizationContext()
        {
          ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.WZnUb6Z8nBqyrErNArTx();
          this.taskScheduler = ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.exjakVZ8OakCgvZ1SQ0V();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static void qIG71lZ8TTX8HQuT9SLl([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SynchronizationContext) obj0).Post((SendOrPostCallback) obj1, obj2));

        internal static bool FISvQcZ8KfsM2EnBQ2dt() => ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.JxuVD3Z8qX1wlcRmC6Xc == null;

        internal static ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext YOPsQPZ8XlKpCC4XpfKV() => (ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext) ELMAContext.SynchronizationContextELMAContext.InternalSynchronizationContext.JxuVD3Z8qX1wlcRmC6Xc;

        internal static void VY3KA4Z8kxPZp3jxoYYU([In] object obj0) => SynchronizationContext.SetSynchronizationContext((SynchronizationContext) obj0);

        internal static void WZnUb6Z8nBqyrErNArTx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static object exjakVZ8OakCgvZ1SQ0V() => (object) TaskScheduler.Current;
      }
    }
  }
}

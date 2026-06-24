// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublishCacheContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Контекст кешей при публикации</summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class PublishCacheContext
  {
    private static ConcurrentDictionary<PublishCacheContext.ICache, object> currentGlobalContext;
    /// <summary>Logger</summary>
    internal static ILogger logger;
    private static int currentGlobalContextCount;
    private static SpinLock currentGlobalContextCountLock;
    private static readonly ConditionalWeakTable<ConcurrentDictionary<PublishCacheContext.ICache, object>, PublishCacheContext.PreviousGlobalContextCount> PreviousGlobalContextCounts;
    private static PublishCacheContext XGgpbsb3xHyq8s9wEUIS;

    /// <summary>Создать кэш, учитывающий дельта-публикацию</summary>
    /// <typeparam name="TKey">Тип ключа</typeparam>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="remove">Метод для удаления значения из кэша</param>
    public static IDictionary<TKey, TValue> CreateCache<TKey, TValue>(
      Action<IDictionary<TKey, TValue>, Type, Guid> remove = null)
    {
      return PublishCacheContext.CreateCache<TKey, TValue>((Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>>) (c => (IDictionary<TKey, TValue>) new ConcurrentDictionary<TKey, TValue>((IEnumerable<KeyValuePair<TKey, TValue>>) c)), remove);
    }

    /// <summary>Создать кэш, учитывающий дельта-публикацию</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="remove">Метод для удаления значения из кэша</param>
    public static ISet<T> CreateCache<T>(Action<ISet<T>, Type, Guid> remove = null) => PublishCacheContext.CreateCache<T>((Func<ISet<T>, ISet<T>>) (c => (ISet<T>) new ConcurrentHashSet<T>((IEnumerable<T>) c)), remove);

    /// <summary>Создать кэш, учитывающий дельта-публикацию</summary>
    /// <typeparam name="TKey">Тип ключа</typeparam>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="clone">Функция для клонирования кэша</param>
    /// <param name="remove">Метод для удаления значения из кэша</param>
    /// <param name="onComplete">Метод при завершении публикации</param>
    internal static IDictionary<TKey, TValue> CreateCache<TKey, TValue>(
      Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone,
      Action<IDictionary<TKey, TValue>, Type, Guid> remove = null,
      Action<IDictionary<TKey, TValue>> onComplete = null,
      Action<IDictionary<TKey, TValue>> onCancel = null)
    {
      return (IDictionary<TKey, TValue>) new PublishCacheContext.CacheDictinary<TKey, TValue>(clone, remove, onComplete, onCancel);
    }

    /// <summary>Создать кэш, учитывающий дельта-публикацию</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="clone">Функция для клонирования кэша</param>
    /// <param name="remove">Метод для удаления значения из кэша</param>
    /// <param name="onComplete">Метод при завершении публикации</param>
    internal static ISet<T> CreateCache<T>(
      Func<ISet<T>, ISet<T>> clone,
      Action<ISet<T>, Type, Guid> remove = null,
      Action<ISet<T>> onComplete = null,
      Action<ISet<T>> onCancel = null)
    {
      return (ISet<T>) new PublishCacheContext.CacheSet<T>(clone, remove, onComplete, onCancel);
    }

    static PublishCacheContext()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: type reference
              PublishCacheContext.logger = (ILogger) PublishCacheContext.vSWIX3b3J2G3QshfgxJq(PublishCacheContext.loqmh4b3MwallxputmBm(__typeref (PublishCacheContext)));
              num2 = 2;
              continue;
            case 2:
              PublishCacheContext.currentGlobalContextCountLock = new SpinLock();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 3:
              PublishCacheContext.EmqkLlb39GwH4EFcrm25((object) new EventHandler(PublishCacheContext.ELMAContext_OnClear));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 4;
              continue;
            case 4:
              goto label_3;
            case 5:
              PublishCacheContext.currentGlobalContext = new ConcurrentDictionary<PublishCacheContext.ICache, object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
              continue;
            case 6:
              goto label_9;
            default:
              PublishCacheContext.PreviousGlobalContextCounts = new ConditionalWeakTable<ConcurrentDictionary<PublishCacheContext.ICache, object>, PublishCacheContext.PreviousGlobalContextCount>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 3 : 0;
              continue;
          }
        }
label_9:
        PublishCacheContext.Jj7O3Lb3ybOVXSQP92FQ();
        num1 = 5;
      }
label_3:;
    }

    /// <summary>Создать контекст дельта-публикации</summary>
    internal static IDisposable Create() => (IDisposable) new PublishCacheContext.CreateCacheDisposable();

    /// <summary>Завершить изоляцию кэша публикации</summary>
    internal static void Complete()
    {
      int num1 = 11;
      bool lockTaken;
      ConcurrentDictionary<PublishCacheContext.ICache, object> currentGlobalContext;
      int num2;
      ConcurrentDictionary<PublishCacheContext.ICache, object> caches;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 5 : 12;
            continue;
          case 2:
            PublishCacheContext.PreviousGlobalContextCounts.Add(currentGlobalContext, new PublishCacheContext.PreviousGlobalContextCount()
            {
              Count = num2
            });
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 3:
            currentGlobalContext = PublishCacheContext.currentGlobalContext;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
            continue;
          case 4:
            PublishCacheContext.h6coPRb3g47LnBJMMYvn((object) currentGlobalContext);
            num1 = 6;
            continue;
          case 5:
          case 13:
            PublishCacheContext.mVKs7Bb3rTtPF4MU364s((object) PublishCacheContext.logger, PublishCacheContext.GAnfVQb3l1L1XEBTOv0e(-649342099 - -1150814748 ^ 501299789));
            num1 = 14;
            continue;
          case 6:
            PublishCacheContext.logger.Info(PublishCacheContext.GAnfVQb3l1L1XEBTOv0e(-1317790512 ^ -1317602520));
            num1 = 8;
            continue;
          case 7:
            goto label_30;
          case 8:
            goto label_25;
          case 9:
            PublishCacheContext.logger.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87444697), (object) num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 11 : 16;
            continue;
          case 10:
            ConcurrentDictionary<PublishCacheContext.ICache, object> enumeration = caches;
            // ISSUE: reference to a compiler-generated field
            Action<KeyValuePair<PublishCacheContext.ICache, object>> action1 = PublishCacheContext.\u003C\u003Ec.\u003C\u003E9__9_0;
            Action<KeyValuePair<PublishCacheContext.ICache, object>> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PublishCacheContext.\u003C\u003Ec.\u003C\u003E9__9_0 = action2 = (Action<KeyValuePair<PublishCacheContext.ICache, object>>) (p => p.Key.OnComplete(p.Value));
            }
            else
              goto label_34;
label_32:
            enumeration.ForEach<KeyValuePair<PublishCacheContext.ICache, object>>(action2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 3;
            continue;
label_34:
            action2 = action1;
            goto label_32;
          case 11:
            caches = PublishCacheContext.GetCaches();
            num1 = 10;
            continue;
          case 12:
            try
            {
              PublishCacheContext.currentGlobalContextCountLock.Enter(ref lockTaken);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    num2 = PublishCacheContext.currentGlobalContextCount - 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_4;
                  case 3:
                    PublishCacheContext.currentGlobalContextCount = 1;
                    num3 = 2;
                    continue;
                  default:
                    PublishCacheContext.currentGlobalContext = caches;
                    num3 = 3;
                    continue;
                }
              }
            }
            finally
            {
              if (lockTaken)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      PublishCacheContext.currentGlobalContextCountLock.Exit();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
              }
label_17:;
            }
          case 14:
          case 16:
            if (num2 != 0)
            {
              num1 = 7;
              continue;
            }
            goto case 15;
          case 15:
            currentGlobalContext.ForEach<KeyValuePair<PublishCacheContext.ICache, object>>((Action<KeyValuePair<PublishCacheContext.ICache, object>>) (p => p.Key.Clear(p.Value)));
            num1 = 4;
            continue;
          case 17:
label_4:
            if (num2 > 0)
            {
              num1 = 2;
              continue;
            }
            goto default;
          default:
            if (!PublishCacheContext.OqYEQSb3dBX1nWTdZFK5((object) PublishCacheContext.logger))
            {
              num1 = 13;
              continue;
            }
            goto case 9;
        }
      }
label_30:
      return;
label_25:;
    }

    /// <summary>Завершить изоляцию кэша публикации с отменой</summary>
    private static void Cancel(
      ConcurrentDictionary<PublishCacheContext.ICache, object> caches)
    {
      caches.ForEach<KeyValuePair<PublishCacheContext.ICache, object>>((Action<KeyValuePair<PublishCacheContext.ICache, object>>) (p => p.Key.OnCancel(p.Value)));
    }

    /// <summary>
    /// Удалить тип с уникальным идентификатором из кэша при дельта публикации
    /// </summary>
    /// <param name="type">Удаляемый из кэша тип</param>
    /// <param name="uid">Удаляемые из кэша уникальный идентификатор типа</param>
    internal static void RemoveFromCache(Type type, Guid uid)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        Type type1;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (!PublishCacheContext.logger.IsTraceEnabled())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 3:
              goto label_9;
            case 4:
              type1 = type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 6;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              uid1 = uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 2;
              continue;
            default:
              PublishCacheContext.GetCaches().ForEach<KeyValuePair<PublishCacheContext.ICache, object>>((Action<KeyValuePair<PublishCacheContext.ICache, object>>) (c => c.Key.Remove(c.Value, type1, uid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
          }
        }
label_9:
        PublishCacheContext.JA5QJUb35MoMjSfS9Vgc((object) PublishCacheContext.logger, (object) string.Format((string) PublishCacheContext.GAnfVQb3l1L1XEBTOv0e(964881585 - -1459193222 ^ -1870751217), (object) type1.FullName, (object) uid1));
        num1 = 7;
      }
label_3:;
    }

    private static ConcurrentDictionary<PublishCacheContext.ICache, object> LocalCaches
    {
      get => (ConcurrentDictionary<PublishCacheContext.ICache, object>) ELMAContext.PublishCaches;
      set => ELMAContext.PublishCaches = (object) value;
    }

    private static T GetCache<T>(object cache) => (T) PublishCacheContext.GetCaches().GetOrAdd((PublishCacheContext.ICache) cache, (Func<PublishCacheContext.ICache, object>) (c => c.Clone((object) null)));

    private static ConcurrentDictionary<PublishCacheContext.ICache, object> GetCaches()
    {
      if (!ELMAContext.Initialized)
        return PublishCacheContext.currentGlobalContext;
      ConcurrentDictionary<PublishCacheContext.ICache, object> caches = PublishCacheContext.LocalCaches;
      if (caches == null)
      {
        bool lockTaken = false;
        try
        {
          PublishCacheContext.currentGlobalContextCountLock.Enter(ref lockTaken);
          caches = PublishCacheContext.LocalCaches;
          caches = (ConcurrentDictionary<PublishCacheContext.ICache, object>) ELMAContext.PublishCaches;
          if (caches == null)
          {
            PublishCacheContext.LocalCaches = caches = PublishCacheContext.currentGlobalContext;
            ++PublishCacheContext.currentGlobalContextCount;
            PublishCacheContext.logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178134346), (object) PublishCacheContext.currentGlobalContextCount);
          }
        }
        finally
        {
          if (lockTaken)
            PublishCacheContext.currentGlobalContextCountLock.Exit();
        }
      }
      return caches;
    }

    private static void ELMAContext_OnClear(object sender, object e)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int num3;
        ConcurrentDictionary<PublishCacheContext.ICache, object> localCaches;
        bool lockTaken;
        bool flag;
        PublishCacheContext.PreviousGlobalContextCount globalContextCount;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_34;
            case 2:
label_10:
              if (flag)
              {
                num2 = 8;
                continue;
              }
              if (!PublishCacheContext.PreviousGlobalContextCounts.TryGetValue(localCaches, out globalContextCount))
              {
                PublishCacheContext.logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633655491));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
              }
              num2 = 14;
              continue;
            case 3:
              goto label_23;
            case 4:
              if (localCaches != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto label_22;
            case 5:
              localCaches = PublishCacheContext.LocalCaches;
              num2 = 4;
              continue;
            case 6:
              PublishCacheContext.mVKs7Bb3rTtPF4MU364s((object) PublishCacheContext.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334871049));
              num2 = 16;
              continue;
            case 7:
              localCaches.ForEach<KeyValuePair<PublishCacheContext.ICache, object>>((Action<KeyValuePair<PublishCacheContext.ICache, object>>) (p => p.Key.Clear(p.Value)));
              num2 = 15;
              continue;
            case 8:
              goto label_31;
            case 9:
              if (num3 != 0)
              {
                num2 = 3;
                continue;
              }
              goto case 7;
            case 10:
              try
              {
                PublishCacheContext.currentGlobalContextCountLock.Enter(ref lockTaken);
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (flag = localCaches == PublishCacheContext.currentGlobalContext)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_10;
                    case 2:
                      goto label_10;
                    default:
                      --PublishCacheContext.currentGlobalContextCount;
                      num4 = 2;
                      continue;
                  }
                }
              }
              finally
              {
                int num5;
                if (!lockTaken)
                  num5 = 2;
                else
                  goto label_24;
label_21:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_24:
                PublishCacheContext.currentGlobalContextCountLock.Exit();
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                {
                  num5 = 1;
                  goto label_21;
                }
                else
                  goto label_21;
              }
            case 11:
              goto label_27;
            case 12:
              goto label_6;
            case 13:
              PublishCacheContext.logger.DebugFormat((string) PublishCacheContext.GAnfVQb3l1L1XEBTOv0e(-1886646897 ^ -1886460773), (object) num3);
              num2 = 9;
              continue;
            case 14:
              num3 = Interlocked.Decrement(ref globalContextCount.Count);
              num2 = 13;
              continue;
            case 15:
              localCaches.Clear();
              num2 = 6;
              continue;
            case 16:
              goto label_8;
            default:
              lockTaken = false;
              num2 = 10;
              continue;
          }
        }
label_31:
        PublishCacheContext.logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283571743), (object) PublishCacheContext.currentGlobalContextCount);
        num1 = 11;
      }
label_34:
      return;
label_23:
      return;
label_27:
      return;
label_6:
      return;
label_8:
      return;
label_22:;
    }

    internal static void Jj7O3Lb3ybOVXSQP92FQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type loqmh4b3MwallxputmBm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object vSWIX3b3J2G3QshfgxJq(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static void EmqkLlb39GwH4EFcrm25([In] object obj0) => ELMAContext.OnClear += (EventHandler) obj0;

    internal static bool DLrjBdb30HpW28X7FpwW() => PublishCacheContext.XGgpbsb3xHyq8s9wEUIS == null;

    internal static PublishCacheContext LhSV6Fb3mh5e1KDvsmic() => PublishCacheContext.XGgpbsb3xHyq8s9wEUIS;

    internal static bool OqYEQSb3dBX1nWTdZFK5([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object GAnfVQb3l1L1XEBTOv0e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void mVKs7Bb3rTtPF4MU364s([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void h6coPRb3g47LnBJMMYvn([In] object obj0) => ((ConcurrentDictionary<PublishCacheContext.ICache, object>) obj0).Clear();

    internal static void JA5QJUb35MoMjSfS9Vgc([In] object obj0, [In] object obj1) => ((ILogger) obj0).Trace(obj1);

    /// <summary>Сохраняемое в контексте кешей при публикации значение</summary>
    /// <typeparam name="T"></typeparam>
    internal class Local<T> : PublishCacheContext.ICache where T : class
    {
      private readonly Func<T, T> clone;
      private readonly Action<T> onCancel;
      private readonly Action<T> onComplete;
      private readonly Action<T> onClear;
      private (PublishCacheContext.Local<T>.ValueContainer ValueContainer, ConcurrentDictionary<PublishCacheContext.ICache, object> Context) currentGlobal;
      internal static object iHXrDyCac6wOvwacpyW5;

      /// <summary>ctor</summary>
      /// <param name="clone">Функция для клонирования кэша</param>
      /// <param name="onCancel">Событие при отмене публикации</param>
      /// <param name="onComplete">Событие при завершении публикации</param>
      /// <param name="onClear">Событие при очистке кэша</param>
      public Local(Func<T, T> clone = null, Action<T> onCancel = null, Action<T> onComplete = null, Action<T> onClear = null)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.clone = clone;
        this.onCancel = onCancel;
        this.onComplete = onComplete;
        this.onClear = onClear;
        ConcurrentDictionary<PublishCacheContext.ICache, object> currentGlobalContext = PublishCacheContext.currentGlobalContext;
        this.currentGlobal = ((PublishCacheContext.Local<T>.ValueContainer) currentGlobalContext.GetOrAdd((PublishCacheContext.ICache) this, (Func<PublishCacheContext.ICache, object>) (c => c.Clone((object) null))), currentGlobalContext);
      }

      /// <summary>Получить или установить значение</summary>
      public T Value
      {
        get => this.GetValueContainer().value;
        set => this.GetValueContainer().value = value;
      }

      private PublishCacheContext.Local<T>.ValueContainer GetValueContainer()
      {
        ConcurrentDictionary<PublishCacheContext.ICache, object> caches = PublishCacheContext.GetCaches();
        (PublishCacheContext.Local<T>.ValueContainer ValueContainer, ConcurrentDictionary<PublishCacheContext.ICache, object> Context) currentGlobal = this.currentGlobal;
        return caches != currentGlobal.Context ? (PublishCacheContext.Local<T>.ValueContainer) caches.GetOrAdd((PublishCacheContext.ICache) this, (Func<PublishCacheContext.ICache, object>) (c => c.Clone((object) null))) : currentGlobal.ValueContainer;
      }

      object PublishCacheContext.ICache.Clone(object cache)
      {
        int num = 3;
        T obj1;
        while (true)
        {
          T obj2;
          T obj3;
          switch (num)
          {
            case 1:
            case 5:
              goto label_2;
            case 2:
              obj2 = default (T);
              num = 4;
              continue;
            case 3:
              PublishCacheContext.Local<T>.ValueContainer valueContainer = (PublishCacheContext.Local<T>.ValueContainer) cache;
              if (valueContainer == null)
              {
                num = 2;
                continue;
              }
              obj3 = valueContainer.value;
              break;
            case 4:
              obj3 = obj2;
              break;
            case 6:
              if (this.clone == null)
              {
                num = 5;
                continue;
              }
              goto default;
            default:
              obj1 = this.clone(obj1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
          }
          obj1 = obj3;
          num = 6;
        }
label_2:
        return (object) new PublishCacheContext.Local<T>.ValueContainer()
        {
          value = obj1
        };
      }

      void PublishCacheContext.ICache.OnCancel(object cache)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              Action<T> onCancel = this.onCancel;
              if (onCancel == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                continue;
              }
              PublishCacheContext.Local<T>.ValueContainer valueContainer = (PublishCacheContext.Local<T>.ValueContainer) cache;
              onCancel(valueContainer != null ? valueContainer.value : default (T));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
              continue;
            case 2:
              goto label_5;
            default:
              goto label_2;
          }
        }
label_3:
        return;
label_5:
        return;
label_2:;
      }

      void PublishCacheContext.ICache.OnComplete(object cache)
      {
        int num = 4;
        PublishCacheContext.Local<T>.ValueContainer valueContainer;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_8;
            case 1:
            case 2:
              this.currentGlobal = (valueContainer, PublishCacheContext.GetCaches());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 3:
              Action<T> onComplete = this.onComplete;
              if (onComplete == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
                continue;
              }
              onComplete(valueContainer == null ? default (T) : valueContainer.value);
              num = 2;
              continue;
            case 4:
              valueContainer = (PublishCacheContext.Local<T>.ValueContainer) cache;
              num = 3;
              continue;
            default:
              goto label_6;
          }
        }
label_8:
        return;
label_6:;
      }

      void PublishCacheContext.ICache.Remove(object cache, Type type, Guid uid)
      {
      }

      void PublishCacheContext.ICache.Clear(object cache)
      {
        int num = 2;
        T obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              ((PublishCacheContext.Local<T>.ValueContainer) cache).value = default (T);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            case 2:
              obj = ((PublishCacheContext.Local<T>.ValueContainer) cache).value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_2;
            default:
              Action<T> onClear = this.onClear;
              if (onClear == null)
              {
                num = 4;
                continue;
              }
              onClear(obj);
              num = 3;
              continue;
          }
        }
label_6:
        return;
label_2:;
      }

      internal static bool fdLnPiCazZmaOwfh5Rpl() => PublishCacheContext.Local<T>.iHXrDyCac6wOvwacpyW5 == null;

      internal static object yAmLJqCDF9bib2nc0Tam() => PublishCacheContext.Local<T>.iHXrDyCac6wOvwacpyW5;

      private class ValueContainer
      {
        public T value;
        private static object ILNLUgZSQnGWXGURlgZj;

        public ValueContainer()
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool bxMYhcZSCWfWPdbLLx35() => PublishCacheContext.Local<T>.ValueContainer.ILNLUgZSQnGWXGURlgZj == null;

        internal static object Htc4aqZSv6CCofunnGoH() => PublishCacheContext.Local<T>.ValueContainer.ILNLUgZSQnGWXGURlgZj;
      }
    }

    private class PreviousGlobalContextCount
    {
      public int Count;
      private static object jFVxSUCDB4rFP57JiJiw;

      public PreviousGlobalContextCount()
      {
        PublishCacheContext.PreviousGlobalContextCount.KDnghTCDbLv8HvlNA3L1();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void KDnghTCDbLv8HvlNA3L1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool w1u95tCDWQslatWdhWsO() => PublishCacheContext.PreviousGlobalContextCount.jFVxSUCDB4rFP57JiJiw == null;

      internal static PublishCacheContext.PreviousGlobalContextCount WIWv1wCDoJsYHp9qPfrr() => (PublishCacheContext.PreviousGlobalContextCount) PublishCacheContext.PreviousGlobalContextCount.jFVxSUCDB4rFP57JiJiw;
    }

    private class CreateCacheDisposable : IDisposable
    {
      private readonly ConcurrentDictionary<PublishCacheContext.ICache, object> oldContext;
      internal static object o3KDluCDhcV8QDIP3wxk;

      public CreateCacheDisposable()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.oldContext = PublishCacheContext.LocalCaches;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            default:
              PublishCacheContext.LocalCaches = new ConcurrentDictionary<PublishCacheContext.ICache, object>(PublishCacheContext.GetCaches().Select<KeyValuePair<PublishCacheContext.ICache, object>, KeyValuePair<PublishCacheContext.ICache, object>>((Func<KeyValuePair<PublishCacheContext.ICache, object>, KeyValuePair<PublishCacheContext.ICache, object>>) (p => new KeyValuePair<PublishCacheContext.ICache, object>(p.Key, p.Key.Clone(p.Value)))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      public void Dispose()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PublishCacheContext.Cancel(PublishCacheContext.LocalCaches);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 3;
              continue;
            case 2:
              if (PublishCacheContext.LocalCaches != PublishCacheContext.currentGlobalContext)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 3:
              PublishCacheContext.LocalCaches = this.oldContext;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
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

      internal static bool JSVGNFCDGs2jAfB0N1M2() => PublishCacheContext.CreateCacheDisposable.o3KDluCDhcV8QDIP3wxk == null;

      internal static PublishCacheContext.CreateCacheDisposable EfYEtXCDE4VyMf9QE7Ka() => (PublishCacheContext.CreateCacheDisposable) PublishCacheContext.CreateCacheDisposable.o3KDluCDhcV8QDIP3wxk;
    }

    private interface ICache
    {
      object Clone(object cache);

      void Remove(object cache, Type type, Guid uid);

      void OnComplete(object cache);

      void OnCancel(object cache);

      void Clear(object cache);
    }

    /// <summary>
    /// Represents a thread-safe collection of key/value pairs that can be accessed by multiple threads concurrently.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    internal interface IConcurrentDictionary<TKey, TValue>
    {
      /// <summary>
      /// Uses the specified functions and argument to add a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key does not already exist, or to update a key/value pair in the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key already exists.
      /// </summary>
      /// <typeparam name="TArg">The type of an argument to pass into addValueFactory and updateValueFactory.</typeparam>
      /// <param name="key">The key to be added or whose value should be updated.</param>
      /// <param name="addValueFactory">The function used to generate a value for an absent key.</param>
      /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
      /// <param name="factoryArgument">An argument to pass into addValueFactory and updateValueFactory.</param>
      /// <returns>The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
      TValue AddOrUpdate<TArg>(
        TKey key,
        Func<TKey, TArg, TValue> addValueFactory,
        Func<TKey, TValue, TArg, TValue> updateValueFactory,
        TArg factoryArgument);

      /// <summary>
      /// Uses the specified functions to add a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key does not already exist, or to update a key/value pair in the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key already exists.
      /// </summary>
      /// <param name="key">The key to be added or whose value should be updated.</param>
      /// <param name="addValueFactory">The function used to generate a value for an absent key.</param>
      /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
      /// <returns>The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
      TValue AddOrUpdate(
        TKey key,
        Func<TKey, TValue> addValueFactory,
        Func<TKey, TValue, TValue> updateValueFactory);

      /// <summary>
      /// Adds a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key does not already exist, or updates a key/value pair in the System.Collections.Concurrent.ConcurrentDictionary`2
      /// by using the specified function if the key already exists.
      /// </summary>
      /// <param name="key">The key to be added or whose value should be updated</param>
      /// <param name="addValue">The value to be added for an absent key</param>
      /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value</param>
      /// <returns>The new value for the key. This will be either be addValue (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
      TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory);

      /// <summary>
      /// Adds a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// by using the specified function if the key does not already exist. Returns the
      /// new value, or the existing value if the key exists.
      /// </summary>
      /// <param name="key">The key of the element to add.</param>
      /// <param name="valueFactory">The function used to generate a value for the key.</param>
      /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
      TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory);

      /// <summary>
      /// Adds a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// if the key does not already exist. Returns the new value, or the existing value
      /// if the key exists.
      /// </summary>
      /// <param name="key">The key of the element to add.</param>
      /// <param name="value">The value to be added, if the key does not already exist.</param>
      /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
      TValue GetOrAdd(TKey key, TValue value);

      /// <summary>
      /// Adds a key/value pair to the System.Collections.Concurrent.ConcurrentDictionary`2
      /// by using the specified function and an argument if the key does not already exist,
      /// or returns the existing value if the key exists.
      /// </summary>
      /// <typeparam name="TArg">The type of an argument to pass into valueFactory.</typeparam>
      /// <param name="key">The key of the element to add.</param>
      /// <param name="valueFactory">The function used to generate a value for the key.</param>
      /// <param name="factoryArgument">An argument value to pass into valueFactory.</param>
      /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
      TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument);

      /// <summary>
      /// Updates the value associated with key to newValue if the existing value with key is equal to comparisonValue.
      /// </summary>
      /// <param name="key">The key of the value that is compared with comparisonValue and possibly replaced.</param>
      /// <param name="newValue">The value that replaces the value of the element that has the specified key if the comparison results in equality.</param>
      /// <param name="comparisonValue">The value that is compared with the value of the element that has the specified key.</param>
      /// <returns>true if the value with key was equal to comparisonValue and was replaced with newValue; otherwise, false.</returns>
      bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue);
    }

    private class CacheDictinary<TKey, TValue> : 
      IDictionary<TKey, TValue>,
      ICollection<KeyValuePair<TKey, TValue>>,
      IEnumerable<KeyValuePair<TKey, TValue>>,
      IEnumerable,
      PublishCacheContext.IConcurrentDictionary<TKey, TValue>,
      PublishCacheContext.ICache
    {
      private readonly Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone;
      private readonly Action<IDictionary<TKey, TValue>, Type, Guid> remove;
      private readonly Action<IDictionary<TKey, TValue>> onComplete;
      private readonly Action<IDictionary<TKey, TValue>> onCancel;
      private static object vH5BxdCDufkZ9Fxm6Hca;

      private IDictionary<TKey, TValue> Cache => PublishCacheContext.GetCache<IDictionary<TKey, TValue>>((object) this);

      public CacheDictinary(
        Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone,
        Action<IDictionary<TKey, TValue>, Type, Guid> remove,
        Action<IDictionary<TKey, TValue>> onComplete,
        Action<IDictionary<TKey, TValue>> onCancel)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.clone = clone;
        this.remove = remove;
        this.onComplete = onComplete;
        this.onCancel = onCancel;
        PublishCacheContext.GetCache<IDictionary<TKey, TValue>>((object) this);
      }

      object PublishCacheContext.ICache.Clone(object cache) => (object) this.clone((IDictionary<TKey, TValue>) cache ?? (IDictionary<TKey, TValue>) new Dictionary<TKey, TValue>());

      void PublishCacheContext.ICache.Remove(object cache, Type type, Guid uid)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_3;
            case 2:
              Action<IDictionary<TKey, TValue>, Type, Guid> remove = this.remove;
              if (remove == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
                continue;
              }
              remove((IDictionary<TKey, TValue>) cache, type, uid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_3:
        return;
label_7:;
      }

      void PublishCacheContext.ICache.OnComplete(object cache)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_3;
            case 2:
              Action<IDictionary<TKey, TValue>> onComplete = this.onComplete;
              if (onComplete == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                continue;
              }
              onComplete((IDictionary<TKey, TValue>) cache);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_3:
        return;
label_7:;
      }

      void PublishCacheContext.ICache.OnCancel(object cache)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_3;
            case 2:
              Action<IDictionary<TKey, TValue>> onCancel = this.onCancel;
              if (onCancel == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
                continue;
              }
              onCancel((IDictionary<TKey, TValue>) cache);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_3:
        return;
label_7:;
      }

      void PublishCacheContext.ICache.Clear(object cache)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ICollection<KeyValuePair<TKey, TValue>>) cache).Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public TValue this[TKey key]
      {
        get => this.Cache[key];
        set => this.Cache[key] = value;
      }

      public ICollection<TKey> Keys => this.Cache.Keys;

      public ICollection<TValue> Values => this.Cache.Values;

      public int Count => this.Cache.Count;

      public bool IsReadOnly => this.Cache.IsReadOnly;

      public void Add(TKey key, TValue value) => this.Cache.Add(key, value);

      public void Add(KeyValuePair<TKey, TValue> item) => this.Cache.Add(item);

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Cache.Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool Contains(KeyValuePair<TKey, TValue> item) => this.Cache.Contains(item);

      public bool ContainsKey(TKey key) => this.Cache.ContainsKey(key);

      public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Cache.CopyTo(array, arrayIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => this.Cache.GetEnumerator();

      public bool Remove(TKey key) => this.Cache.Remove(key);

      public bool Remove(KeyValuePair<TKey, TValue> item) => ((ICollection<KeyValuePair<TKey, TValue>>) this.Cache).Remove(item);

      public bool TryGetValue(TKey key, out TValue value) => this.Cache.TryGetValue(key, out value);

      IEnumerator IEnumerable.GetEnumerator() => this.Cache.GetEnumerator();

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.AddOrUpdate<TArg>(
        TKey key,
        Func<TKey, TArg, TValue> addValueFactory,
        Func<TKey, TValue, TArg, TValue> updateValueFactory,
        TArg factoryArgument)
      {
        return this.Cache.AddOrUpdate<TKey, TValue, TArg>(key, addValueFactory, updateValueFactory, factoryArgument);
      }

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.AddOrUpdate(
        TKey key,
        Func<TKey, TValue> addValueFactory,
        Func<TKey, TValue, TValue> updateValueFactory)
      {
        return this.Cache.AddOrUpdate<TKey, TValue>(key, addValueFactory, updateValueFactory);
      }

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.AddOrUpdate(
        TKey key,
        TValue addValue,
        Func<TKey, TValue, TValue> updateValueFactory)
      {
        return this.Cache.AddOrUpdate<TKey, TValue>(key, addValue, updateValueFactory);
      }

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.GetOrAdd(
        TKey key,
        Func<TKey, TValue> valueFactory)
      {
        return this.Cache.GetOrAdd<TKey, TValue>(key, valueFactory);
      }

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.GetOrAdd(
        TKey key,
        TValue value)
      {
        return this.Cache.GetOrAdd<TKey, TValue>(key, value);
      }

      TValue PublishCacheContext.IConcurrentDictionary<TKey, TValue>.GetOrAdd<TArg>(
        TKey key,
        Func<TKey, TArg, TValue> valueFactory,
        TArg factoryArgument)
      {
        return this.Cache.GetOrAdd<TKey, TValue, TArg>(key, valueFactory, factoryArgument);
      }

      bool PublishCacheContext.IConcurrentDictionary<TKey, TValue>.TryUpdate(
        TKey key,
        TValue newValue,
        TValue comparisonValue)
      {
        return this.Cache.TryUpdate<TKey, TValue>(key, newValue, comparisonValue);
      }

      internal static bool mwwjJgCDI5HV072JxqDe() => PublishCacheContext.CacheDictinary<TKey, TValue>.vH5BxdCDufkZ9Fxm6Hca == null;

      internal static object ooVtl4CDVPeOGEp1oLbs() => PublishCacheContext.CacheDictinary<TKey, TValue>.vH5BxdCDufkZ9Fxm6Hca;
    }

    private class CacheSet<T> : 
      ISet<T>,
      ICollection<T>,
      IEnumerable<T>,
      IEnumerable,
      PublishCacheContext.ICache
    {
      private readonly Func<ISet<T>, ISet<T>> clone;
      private readonly Action<ISet<T>, Type, Guid> remove;
      private readonly Action<ISet<T>> onComplete;
      private readonly Action<ISet<T>> onCancel;
      internal static object IL58c4CDS5pkHDTgxTju;

      private ISet<T> Cache => PublishCacheContext.GetCache<ISet<T>>((object) this);

      public CacheSet(
        Func<ISet<T>, ISet<T>> clone,
        Action<ISet<T>, Type, Guid> remove,
        Action<ISet<T>> onComplete,
        Action<ISet<T>> onCancel)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.clone = clone;
        this.remove = remove;
        this.onComplete = onComplete;
        this.onCancel = onCancel;
        PublishCacheContext.GetCache<ISet<T>>((object) this);
      }

      object PublishCacheContext.ICache.Clone(object cache)
      {
        Func<ISet<T>, ISet<T>> clone = this.clone;
        ISet<T> objSet1 = (ISet<T>) cache;
        ISet<T> objSet2 = objSet1 == null ? (ISet<T>) new HashSet<T>() : objSet1;
        return (object) clone(objSet2);
      }

      void PublishCacheContext.ICache.Remove(object cache, Type type, Guid uid)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              Action<ISet<T>, Type, Guid> remove = this.remove;
              if (remove == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              }
              remove((ISet<T>) cache, type, uid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_5;
            default:
              goto label_2;
          }
        }
label_3:
        return;
label_5:
        return;
label_2:;
      }

      void PublishCacheContext.ICache.OnComplete(object cache)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_3;
            case 2:
              Action<ISet<T>> onComplete = this.onComplete;
              if (onComplete == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                continue;
              }
              onComplete((ISet<T>) cache);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_3:
        return;
label_2:;
      }

      void PublishCacheContext.ICache.OnCancel(object cache)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              Action<ISet<T>> onCancel = this.onCancel;
              if (onCancel == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              }
              onCancel((ISet<T>) cache);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 2;
              continue;
            case 2:
              goto label_5;
            default:
              goto label_2;
          }
        }
label_3:
        return;
label_5:
        return;
label_2:;
      }

      void PublishCacheContext.ICache.Clear(object cache)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ICollection<T>) cache).Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public int Count => this.Cache.Count;

      public bool IsReadOnly => this.Cache.IsReadOnly;

      public bool Add(T item) => this.Cache.Add(item);

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Cache.Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool Contains(T item) => this.Cache.Contains(item);

      public void CopyTo(T[] array, int arrayIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Cache.CopyTo(array, arrayIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void ExceptWith(IEnumerable<T> other) => this.Cache.ExceptWith(other);

      public IEnumerator<T> GetEnumerator() => this.Cache.GetEnumerator();

      public void IntersectWith(IEnumerable<T> other) => this.Cache.IntersectWith(other);

      public bool IsProperSubsetOf(IEnumerable<T> other) => this.Cache.IsProperSubsetOf(other);

      public bool IsProperSupersetOf(IEnumerable<T> other) => this.Cache.IsProperSupersetOf(other);

      public bool IsSubsetOf(IEnumerable<T> other) => this.Cache.IsSubsetOf(other);

      public bool IsSupersetOf(IEnumerable<T> other) => this.Cache.IsSupersetOf(other);

      public bool Overlaps(IEnumerable<T> other) => this.Cache.Overlaps(other);

      public bool Remove(T item) => this.Cache.Remove(item);

      public bool SetEquals(IEnumerable<T> other) => this.Cache.SetEquals(other);

      public void SymmetricExceptWith(IEnumerable<T> other) => this.Cache.SymmetricExceptWith(other);

      public void UnionWith(IEnumerable<T> other) => this.Cache.UnionWith(other);

      void ICollection<T>.Add(T item) => this.Cache.Add(item);

      IEnumerator IEnumerable.GetEnumerator() => this.Cache.GetEnumerator();

      internal static bool NW5EdXCDiqRAWfFI4kyU() => PublishCacheContext.CacheSet<T>.IL58c4CDS5pkHDTgxTju == null;

      internal static object hv2baaCDRP7CBjKRIeDO() => PublishCacheContext.CacheSet<T>.IL58c4CDS5pkHDTgxTju;
    }
  }
}

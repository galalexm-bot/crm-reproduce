// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.CacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Configuration.Provider;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache
{
  /// <summary>Базовый класс для сервиса кэширования</summary>
  public abstract class CacheService : ProviderBase, ICacheService
  {
    private static readonly CacheService.CachedNull NullValue;
    private readonly bool needDiagnostics;
    private static CacheService yo7sP4fqUcgjgGR8G0lW;

    public CacheService()
    {
      CacheService.Ye3vh8fqzwgI44ervFBo();
      this.needDiagnostics = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.needDiagnostics = !(this is IHandleDiagnostics);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public void Insert<T>(string key, T value, TimeSpan cacheDuration) => this.Insert<T>(key, value, (string) null, cacheDuration);

    public void Insert<T>(
      string key,
      T value,
      string region,
      TimeSpan cacheDuration,
      CacheItemRemovedCallback<T> onRemoveItemCallback)
    {
      if (string.IsNullOrEmpty(key))
        return;
      using (DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.needDiagnostics)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (CacheWriteInfo) null;
label_3:
        return new CacheWriteInfo()
        {
          Region = region,
          Key = key
        };
      })))
        this.InsertValue<T>(key, CacheService.AssembleValue<T>(value), region, cacheDuration, onRemoveItemCallback);
    }

    public void Insert<T>(string key, T value, string region, TimeSpan cacheDuration) => this.Insert<T>(key, value, region, cacheDuration, (CacheItemRemovedCallback<T>) null);

    public void Insert<T>(string key, T value, string region) => this.Insert<T>(key, value, region, TimeSpan.FromHours(2.0));

    public void Insert<T>(string key, T value) => this.Insert<T>(key, value, (string) null);

    public bool Contains(string key) => this.Contains(key, (string) null);

    public bool Contains(string key, string region)
    {
      int num1 = 4;
      CacheReadInfo cacheReadInfo1;
      CacheService cacheService;
      string region1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            region1 = region;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 3:
            cacheService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            cacheReadInfo1 = DiagnosticsManager.StartCall<CacheReadInfo>((Func<CacheReadInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (cacheService.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  case 2:
                    goto label_2;
                  default:
                    goto label_3;
                }
              }
label_2:
              return (CacheReadInfo) null;
label_3:
              CacheReadInfo cacheReadInfo2 = new CacheReadInfo();
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass7_0.kpoumU8YLkQ9KijayQ9y((object) cacheReadInfo2, (object) region1);
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass7_0.lLUpOg8YU1KQw5FZaU2o((object) cacheReadInfo2, (object) key1);
              return cacheReadInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_18;
          default:
            key1 = key;
            num1 = 5;
            continue;
        }
      }
label_4:
      bool flag1;
      try
      {
        bool flag2 = this.ContainsInternal(key1, region1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              flag1 = flag2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 0;
              continue;
            case 2:
              CacheService.kVTogafKFJJ5FfXtNOrT((object) cacheReadInfo1, flag2);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_18;
            default:
              if (cacheReadInfo1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
                continue;
              }
              goto case 1;
          }
        }
      }
      finally
      {
        int num4;
        if (cacheReadInfo1 == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
        else
          goto label_14;
label_13:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_14:
        cacheReadInfo1.Dispose();
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        {
          num4 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
label_18:
      return flag1;
    }

    public T Get<T>(string key) => this.Get<T>(key, (string) null);

    public T Get<T>(string key, string region)
    {
      using (CacheReadInfo cacheReadInfo = DiagnosticsManager.StartCall<CacheReadInfo>((Func<CacheReadInfo>) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.needDiagnostics)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (CacheReadInfo) null;
label_5:
        return new CacheReadInfo()
        {
          Region = region,
          Key = key
        };
      })))
      {
        object obj = this.GetValue(key, region);
        if (cacheReadInfo != null)
          cacheReadInfo.Success = obj != null;
        return CacheService.DisassembleValue<T>(obj);
      }
    }

    public bool TryGetValue<T>(string key, out T value) => this.TryGetValue<T>(key, (string) null, out value);

    public virtual bool TryGetValue<T>(string key, string region, out T value)
    {
      using (CacheReadInfo cacheReadInfo = DiagnosticsManager.StartCall<CacheReadInfo>((Func<CacheReadInfo>) (() =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.needDiagnostics)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (CacheReadInfo) null;
label_5:
        return new CacheReadInfo()
        {
          Region = region,
          Key = key
        };
      })))
      {
        object obj = this.GetValue(key, region);
        if (cacheReadInfo != null)
          cacheReadInfo.Success = obj != null;
        if (obj == null)
        {
          value = default (T);
          return false;
        }
        if (obj is CacheService.CachedNull)
        {
          value = default (T);
          return true;
        }
        value = (T) obj;
        return true;
      }
    }

    public void Remove(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Remove(key, (string) null);
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

    public void Remove(string key, string region)
    {
      int num1 = 3;
      CacheWriteInfo cacheWriteInfo1;
      CacheService cacheService;
      string region1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_16;
          case 2:
            cacheService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 3;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 2;
            continue;
          case 4:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 2;
            continue;
          case 5:
            cacheWriteInfo1 = DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (!cacheService.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (CacheWriteInfo) null;
label_3:
              CacheWriteInfo cacheWriteInfo2 = new CacheWriteInfo();
              cacheWriteInfo2.Region = region1;
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass13_0.ots57S8LEpTV7iRSgkxm((object) cacheWriteInfo2, (object) key1);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass13_0.VsWHNm8LQZg8jfp1mcGr((object) cacheWriteInfo2, CacheService.\u003C\u003Ec__DisplayClass13_0.uLrtcs8Lf9qZaJ9b88Ja(1461825605 - 1531863589 ^ -69997896));
              return cacheWriteInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 6:
            region1 = region;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_16:
      return;
label_6:
      try
      {
        CacheService.Ym3KMofKBaK9geXBTfOZ((object) this, (object) key1, (object) region1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (cacheWriteInfo1 != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_18;
              default:
                CacheService.RdJiJJfKWwTQROb4Ef0b((object) cacheWriteInfo1);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_18:;
      }
    }

    public void ClearRegion(string region)
    {
      int num1 = 5;
      CacheWriteInfo cacheWriteInfo1;
      CacheService cacheService;
      string region1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cacheWriteInfo1 = DiagnosticsManager.StartCall<CacheWriteInfo>((Func<CacheWriteInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (!cacheService.needDiagnostics)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (CacheWriteInfo) null;
label_3:
              CacheWriteInfo cacheWriteInfo2 = new CacheWriteInfo();
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass14_0.D1V0K98LZC5Gi3tl4DoP((object) cacheWriteInfo2, (object) region1);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CacheService.\u003C\u003Ec__DisplayClass14_0.YJ7id48LIX5ieUYCJaj6((object) cacheWriteInfo2, CacheService.\u003C\u003Ec__DisplayClass14_0.IyWu918LuyRpJv3REDlM(-105199646 ^ -105326104));
              return cacheWriteInfo2;
            }));
            num1 = 3;
            continue;
          case 2:
            goto label_11;
          case 3:
            goto label_2;
          case 4:
            cacheService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 5:
            num1 = 4;
            continue;
          default:
            region1 = region;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
        }
      }
label_11:
      return;
label_2:
      try
      {
        this.ClearRegionInternal(region1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (cacheWriteInfo1 != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_13;
              default:
                CacheService.RdJiJJfKWwTQROb4Ef0b((object) cacheWriteInfo1);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_13:;
      }
    }

    public virtual void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration)
    {
    }

    /// <summary>Признак, что кэш распределенный</summary>
    public virtual bool IsDistributed => false;

    protected abstract void InsertValue<T>(
      string key,
      object value,
      string region,
      TimeSpan cacheDuration,
      CacheItemRemovedCallback<T> onRemoveItemCallback);

    protected abstract object GetValue(string key, string region);

    protected abstract bool ContainsInternal(string key, string region);

    protected abstract void RemoveInternal(string key, string region);

    protected abstract void ClearRegionInternal(string region);

    /// <summary>
    /// Обработать значения для безопасного сохранения в кэш (обработка null-значений)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <returns></returns>
    protected static object AssembleValue<T>(T value) => (object) value ?? (object) CacheService.NullValue;

    /// <summary>Обратная функция для AssembleValue</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <returns></returns>
    protected static T DisassembleValue<T>(object value) => (T) (value is CacheService.CachedNull ? (object) null : value);

    static CacheService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CacheService.CachedNull cachedNull = new CacheService.CachedNull();
            CacheService.fw4PjKfKo3mMI8lMg8l3((object) cachedNull, (byte) 0);
            CacheService.NullValue = cachedNull;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void Ye3vh8fqzwgI44ervFBo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool t2s2VyfqsSFYpkGNIw4x() => CacheService.yo7sP4fqUcgjgGR8G0lW == null;

    internal static CacheService j7nmbqfqcrCd2VchkVxO() => CacheService.yo7sP4fqUcgjgGR8G0lW;

    internal static void kVTogafKFJJ5FfXtNOrT([In] object obj0, bool value) => ((CacheReadInfo) obj0).Success = value;

    internal static void Ym3KMofKBaK9geXBTfOZ([In] object obj0, [In] object obj1, [In] object obj2) => ((CacheService) obj0).RemoveInternal((string) obj1, (string) obj2);

    internal static void RdJiJJfKWwTQROb4Ef0b([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void fw4PjKfKo3mMI8lMg8l3([In] object obj0, byte value) => ((CacheService.CachedNull) obj0).Value = value;

    /// <summary>Класс для хранения null значения</summary>
    [Serializable]
    private class CachedNull
    {
      private static object DePjwS8YybMSoKOKQDNt;

      public byte Value
      {
        get => this.\u003CValue\u003Ek__BackingField;
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
                this.\u003CValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

      public CachedNull()
      {
        CacheService.CachedNull.Ql1L6A8Y9HZ0AyOJ0kFx();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Dkwu238YM9g6MSN3YvbL() => CacheService.CachedNull.DePjwS8YybMSoKOKQDNt == null;

      internal static CacheService.CachedNull ahVgU98YJHH3LguKULCB() => (CacheService.CachedNull) CacheService.CachedNull.DePjwS8YybMSoKOKQDNt;

      internal static void Ql1L6A8Y9HZ0AyOJ0kFx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

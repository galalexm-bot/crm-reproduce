// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockService`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>Cервис блокировок c указанным типом настроек</summary>
  public abstract class LockService<TSettings> : LockService where TSettings : LockServiceSettingsBase
  {
    private static object RG0EONhrNO0BSsJ2owBe;

    /// <inheritdoc />
    public override Task<ILock> AcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken))
    {
      string name1 = name;
      CancellationToken token1 = token;
      TimeSpan? nullable = maxValidFor;
      TimeSpan? maxValidFor1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockValidFor));
      nullable = timeout;
      TimeSpan? timeout1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockTimeout));
      TimeSpan? repeatInterval = new TimeSpan?(TimeSpan.FromMilliseconds((double) this.Settings.DefaultLockRepeat));
      return this.AcquireLockAsync(name1, token1, maxValidFor1, timeout1, repeatInterval);
    }

    /// <inheritdoc />
    public override Task<ILock> TryAcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken))
    {
      string name1 = name;
      CancellationToken token1 = token;
      TimeSpan? nullable = maxValidFor;
      TimeSpan? maxValidFor1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockValidFor));
      nullable = timeout;
      TimeSpan? timeout1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockTimeout));
      TimeSpan? repeatInterval = new TimeSpan?(TimeSpan.FromMilliseconds((double) this.Settings.DefaultLockRepeat));
      return this.TryAcquireLockAsync(name1, token1, maxValidFor1, timeout1, repeatInterval);
    }

    /// <inheritdoc />
    public override ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout)
    {
      string name1 = name;
      TimeSpan? nullable = maxValidFor;
      TimeSpan? maxValidFor1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockValidFor));
      nullable = timeout;
      TimeSpan? timeout1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockTimeout));
      TimeSpan? repeatInterval = new TimeSpan?(TimeSpan.FromMilliseconds((double) this.Settings.DefaultLockRepeat));
      return this.AcquireLock(name1, maxValidFor1, timeout1, repeatInterval);
    }

    /// <inheritdoc />
    public override bool TryAcquireLock(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      out ILock @lock)
    {
      string name1 = name;
      TimeSpan? nullable = maxValidFor;
      TimeSpan? maxValidFor1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockValidFor));
      nullable = timeout;
      TimeSpan? timeout1 = new TimeSpan?(nullable ?? this.SecondsToTimeSpan(this.Settings.DefaultLockTimeout));
      TimeSpan? repeatInterval = new TimeSpan?(TimeSpan.FromMilliseconds((double) this.Settings.DefaultLockRepeat));
      ref ILock local = ref @lock;
      return this.TryAcquireLock(name1, maxValidFor1, timeout1, repeatInterval, out local);
    }

    /// <inheritdoc />
    public override void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration)
    {
      int num = 9;
      TSettings section;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_2;
          case 2:
            this.Settings = section;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_9;
          case 4:
            if ((object) section != null)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 5:
            this.Settings = this.CreateSettings();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          case 6:
            if (this.IsRequireSettings())
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 7:
            section = configuration.Config.GetSection(this.SettingSection) as TSettings;
            num = 4;
            continue;
          case 8:
            Contract.ArgumentNotNull((object) configuration.Config, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576126948));
            num = 7;
            continue;
          case 9:
            Contract.ArgumentNotNull((object) configuration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272509559));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 8 : 4;
            continue;
          default:
            goto label_5;
        }
      }
label_14:
      return;
label_2:
      return;
label_5:
      return;
label_9:
      throw new ConfigurationErrorsException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234142126), (object) this.SettingSection));
    }

    /// <summary>Настройки</summary>
    protected TSettings Settings { private set; get; }

    /// <summary>Наименование секции в настройках</summary>
    protected virtual string SettingSection => typeof (TSettings).Name;

    private bool IsRequireSettings()
    {
      PropertyInfo[] properties = typeof (TSettings).GetProperties();
      // ISSUE: reference to a compiler-generated field
      Func<PropertyInfo, IEnumerable<object>> func1 = LockService<TSettings>.\u003C\u003Ec.\u003C\u003E9__11_0;
      Func<PropertyInfo, IEnumerable<object>> selector;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LockService<TSettings>.\u003C\u003Ec.\u003C\u003E9__11_0 = selector = (Func<PropertyInfo, IEnumerable<object>>) (p => (IEnumerable<object>) p.GetCustomAttributes(typeof (ConfigurationPropertyAttribute), false));
      }
      else
        goto label_1;
label_3:
      IEnumerable<object> source = ((IEnumerable<PropertyInfo>) properties).SelectMany<PropertyInfo, object>(selector);
      // ISSUE: reference to a compiler-generated field
      Func<object, bool> func2 = LockService<TSettings>.\u003C\u003Ec.\u003C\u003E9__11_1;
      Func<object, bool> predicate;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LockService<TSettings>.\u003C\u003Ec.\u003C\u003E9__11_1 = predicate = (Func<object, bool>) (a => ((ConfigurationPropertyAttribute) a).IsRequired);
      }
      else
        goto label_4;
label_6:
      return source.Any<object>(predicate);
label_4:
      predicate = func2;
      goto label_6;
label_1:
      selector = func1;
      goto label_3;
    }

    private TSettings CreateSettings()
    {
      object instance = Activator.CreateInstance(typeof (TSettings));
      foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(instance))
      {
        if (property.Attributes[typeof (ConfigurationPropertyAttribute)] is ConfigurationPropertyAttribute attribute)
        {
          if (attribute.DefaultValue != null)
          {
            try
            {
              property.SetValue(instance, attribute.DefaultValue);
            }
            catch (Exception ex)
            {
            }
          }
        }
      }
      return (TSettings) instance;
    }

    private TimeSpan SecondsToTimeSpan(int secs)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (secs >= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return TimeSpan.FromSeconds((double) secs);
label_3:
      return LockService.InfiniteTimeSpan;
    }

    protected LockService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VXem4Mhr3noyg7WDWuai() => LockService<TSettings>.RG0EONhrNO0BSsJ2owBe == null;

    internal static object NjagAhhrpjNVRci447Aw() => LockService<TSettings>.RG0EONhrNO0BSsJ2owBe;
  }
}

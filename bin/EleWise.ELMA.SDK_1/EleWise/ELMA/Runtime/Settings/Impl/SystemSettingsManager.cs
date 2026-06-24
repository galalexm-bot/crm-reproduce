// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.Impl.SystemSettingsManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Settings.Impl
{
  /// <summary>Менеджер настроек системы, хранящихся в основной БД</summary>
  [Service(Type = ComponentType.Server, EnableInterceptors = true, InjectProperties = true)]
  public class SystemSettingsManager : NHManager
  {
    protected static readonly string F_ModuleUid;
    protected static readonly string F_Key;
    internal static SystemSettingsManager vrHMjlWGoalMX9Ge8HWw;

    public ILockManager LockManager
    {
      get => this.\u003CLockManager\u003Ek__BackingField;
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
              this.\u003CLockManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    [Transaction]
    public virtual void SetString(Guid uid, string key, string value)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_17;
          case 1:
            goto label_3;
          case 2:
            disposable = this.LockManager.Lock((string) SystemSettingsManager.AnddXTWGGY6wHAyZOWme((object) uid.ToString(), (object) key));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_17:
      return;
label_12:
      return;
label_3:
      try
      {
        object obj1 = SystemSettingsManager.SL8370WGEAV0xK3yhgZL((object) this, uid, (object) key);
        int num2;
        if (obj1 == null)
        {
          num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
            num2 = 3;
        }
        else
          goto label_20;
label_6:
        SystemSettings systemSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              SystemSettingsManager.bhD27vWGCeLlakmvuShQ((object) this.Session, (object) systemSettings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_10;
            default:
              SystemSettingsManager.CM6EtOWGQFNtbCHniFjq((object) systemSettings, (object) value);
              num2 = 2;
              continue;
          }
        }
label_7:
        return;
label_10:
        object obj2 = (object) new SystemSettings();
        SystemSettingsManager.j9qKhKWGfBmHVVwfxuZd(obj2, uid);
        ((SystemSettings) obj2).Key = key;
label_11:
        systemSettings = (SystemSettings) obj2;
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
        goto label_6;
label_20:
        obj2 = obj1;
        goto label_11;
      }
      finally
      {
        if (disposable != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                SystemSettingsManager.GjyeGgWGvS2BFtlwWFKS((object) disposable);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    [Transaction]
    public virtual void SetStrings(Guid uid, IDictionary<string, string> strings)
    {
      if (strings == null)
        return;
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) strings)
        this.SetString(uid, keyValuePair.Key, keyValuePair.Value);
    }

    public virtual string GetString(Guid uid, string key)
    {
      int num = 3;
      SystemSettings systemSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (systemSettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            systemSettings = this.GetItem(uid, key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) null;
label_4:
      return (string) SystemSettingsManager.EEAnTsWG8d5FD64ao4l8((object) systemSettings);
    }

    public virtual IDictionary<string, string> GetAllStrings(Guid uid) => (IDictionary<string, string>) this.CreateCriteria().Add((ICriterion) Restrictions.Eq(SystemSettingsManager.F_ModuleUid, (object) uid)).List<SystemSettings>().ToDictionary<SystemSettings, string, string>((Func<SystemSettings, string>) (s => (string) SystemSettingsManager.\u003C\u003Ec.ObWpr0QNIRmQt6UP8tSk((object) s)), (Func<SystemSettings, string>) (s => s.Value));

    [Transaction]
    public virtual void RemoveString(Guid uid, string key)
    {
      int num1 = 1;
      IEnumerator<SystemSettings> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((ICriteria) SystemSettingsManager.MvOHvVWGIkOgyneaFV3D(SystemSettingsManager.MvOHvVWGIkOgyneaFV3D(SystemSettingsManager.MJKsqdWGZWrIdQ5Z2suP((object) this), SystemSettingsManager.DDcxGfWGu9Z1rCZ1oWRv((object) SystemSettingsManager.F_ModuleUid, (object) uid)), SystemSettingsManager.DDcxGfWGu9Z1rCZ1oWRv((object) SystemSettingsManager.F_Key, (object) key))).List<SystemSettings>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_17;
          default:
            goto label_2;
        }
      }
label_17:
      return;
label_2:
      try
      {
label_7:
        if (SystemSettingsManager.FikRJrWGVHqVNguoZ1cU((object) enumerator))
          goto label_5;
        else
          goto label_8;
label_4:
        SystemSettings current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_14;
            case 1:
              this.Session.Delete((object) current);
              num2 = 2;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_5;
            default:
              goto label_10;
          }
        }
label_14:
        return;
label_10:
        return;
label_5:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_15;
label_13:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_15:
        enumerator.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        {
          num3 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    [Transaction]
    public virtual void RemoveAllStrings(Guid uid)
    {
      int num1 = 1;
      IEnumerator<SystemSettings> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((ICriteria) SystemSettingsManager.MJKsqdWGZWrIdQ5Z2suP((object) this)).Add((ICriterion) Restrictions.Eq(SystemSettingsManager.F_ModuleUid, (object) uid)).List<SystemSettings>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          default:
            goto label_2;
        }
      }
label_15:
      return;
label_2:
      try
      {
label_6:
        if (SystemSettingsManager.FikRJrWGVHqVNguoZ1cU((object) enumerator))
          goto label_8;
        else
          goto label_7;
label_4:
        SystemSettings current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_8;
            case 3:
              SystemSettingsManager.CfhSHeWGSEU0beI35tEY((object) this.Session, (object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_10:
        return;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
        goto label_4;
label_8:
        current = enumerator.Current;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        {
          num2 = 3;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_17;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_17:;
      }
    }

    protected virtual ICriteria CreateCriteria() => (ICriteria) SystemSettingsManager.RducReWGiW2tG0CyoFdq((object) this.Session.CreateCriteria<SystemSettings>(), true);

    public virtual SystemSettings GetItem(Guid uid, string key) => ((ICriteria) SystemSettingsManager.MvOHvVWGIkOgyneaFV3D(SystemSettingsManager.MvOHvVWGIkOgyneaFV3D(SystemSettingsManager.MJKsqdWGZWrIdQ5Z2suP((object) this), SystemSettingsManager.DDcxGfWGu9Z1rCZ1oWRv((object) SystemSettingsManager.F_ModuleUid, (object) uid)), (object) Restrictions.Eq(SystemSettingsManager.F_Key, (object) key))).List<SystemSettings>().FirstOrDefault<SystemSettings>();

    public SystemSettingsManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SystemSettingsManager()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              parameterExpression1 = (ParameterExpression) SystemSettingsManager.JdkfhGWGq1grBZxtYO14(typeof (SystemSettings), SystemSettingsManager.qFwrxbWGRDUt3wsYkeGR(372753449 ^ 372715961));
              num2 = 5;
              continue;
            case 3:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num2 = 2;
              continue;
            case 4:
              SystemSettingsManager.F_Key = LinqUtils.NameOf<SystemSettings>((Expression<Func<SystemSettings, object>>) (parameterExpression => parameterExpression.Key));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            case 5:
              // ISSUE: method reference
              // ISSUE: type reference
              SystemSettingsManager.F_ModuleUid = LinqUtils.NameOf<SystemSettings>(System.Linq.Expressions.Expression.Lambda<Func<SystemSettings, object>>((System.Linq.Expressions.Expression) SystemSettingsManager.dEXigJWGkhLlVkP0xYcw(SystemSettingsManager.f0l00UWGXdl14sGV8vPo((object) parameterExpression1, (object) (MethodInfo) SystemSettingsManager.Of8gF0WGKC2MmfS4of8Y(__methodref (SystemSettings.get_ModuleUid))), SystemSettingsManager.WBZ1aYWGTRsClXrofHL8(__typeref (object))), parameterExpression1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        // ISSUE: type reference
        parameterExpression1 = (ParameterExpression) SystemSettingsManager.JdkfhGWGq1grBZxtYO14(SystemSettingsManager.WBZ1aYWGTRsClXrofHL8(__typeref (SystemSettings)), SystemSettingsManager.qFwrxbWGRDUt3wsYkeGR(-2107978722 ^ -2108016242));
        num1 = 4;
      }
label_3:;
    }

    internal static bool SCmnE5WGbBP1A9nlH1VD() => SystemSettingsManager.vrHMjlWGoalMX9Ge8HWw == null;

    internal static SystemSettingsManager yUym9XWGhYX4bqFmJ58g() => SystemSettingsManager.vrHMjlWGoalMX9Ge8HWw;

    internal static object AnddXTWGGY6wHAyZOWme([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object SL8370WGEAV0xK3yhgZL([In] object obj0, Guid uid, [In] object obj2) => (object) ((SystemSettingsManager) obj0).GetItem(uid, (string) obj2);

    internal static void j9qKhKWGfBmHVVwfxuZd([In] object obj0, Guid value) => ((SystemSettings) obj0).ModuleUid = value;

    internal static void CM6EtOWGQFNtbCHniFjq([In] object obj0, [In] object obj1) => ((SystemSettings) obj0).Value = (string) obj1;

    internal static void bhD27vWGCeLlakmvuShQ([In] object obj0, [In] object obj1) => ((ISession) obj0).SaveOrUpdate(obj1);

    internal static void GjyeGgWGvS2BFtlwWFKS([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object EEAnTsWG8d5FD64ao4l8([In] object obj0) => (object) ((SystemSettings) obj0).Value;

    internal static object MJKsqdWGZWrIdQ5Z2suP([In] object obj0) => (object) ((SystemSettingsManager) obj0).CreateCriteria();

    internal static object DDcxGfWGu9Z1rCZ1oWRv([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object MvOHvVWGIkOgyneaFV3D([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool FikRJrWGVHqVNguoZ1cU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void CfhSHeWGSEU0beI35tEY([In] object obj0, [In] object obj1) => ((ISession) obj0).Delete(obj1);

    internal static object RducReWGiW2tG0CyoFdq([In] object obj0, [In] bool obj1) => (object) ((ICriteria) obj0).SetCacheable(obj1);

    internal static object qFwrxbWGRDUt3wsYkeGR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JdkfhGWGq1grBZxtYO14([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object Of8gF0WGKC2MmfS4of8Y([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object f0l00UWGXdl14sGV8vPo([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static Type WBZ1aYWGTRsClXrofHL8([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object dEXigJWGkhLlVkP0xYcw([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);
  }
}

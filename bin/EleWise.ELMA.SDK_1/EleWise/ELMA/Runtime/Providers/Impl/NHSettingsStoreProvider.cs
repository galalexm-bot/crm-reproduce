// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.Impl.NHSettingsStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Settings.Impl;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers.Impl
{
  /// <summary>
  /// Провайдер настроек системы, хранящий данные в основной БД
  /// </summary>
  public class NHSettingsStoreProvider : SettingsStoreProvider
  {
    internal static NHSettingsStoreProvider axQllIWQPVyGNo0nNLLL;

    public override void SetString(Guid uid, string key, string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHSettingsStoreProvider.AsfG04WQ3CJl76pkX3K9((object) this.Manager, uid, (object) key, (object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void SetStrings(Guid uid, IDictionary<string, string> strings) => this.Manager.SetStrings(uid, strings);

    public override string GetString(Guid uid, string key) => (string) NHSettingsStoreProvider.c0ehSQWQpeA2GcndmIiA((object) this.Manager, uid, (object) key);

    public override IDictionary<string, string> GetAllStrings(Guid uid) => this.Manager.GetAllStrings(uid);

    public override void RemoveString(Guid uid, string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHSettingsStoreProvider.wr6sF2WQafflnAWZuqbt((object) this.Manager, uid, (object) key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void RemoveAllStrings(Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.RemoveAllStrings(uid);
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

    protected SystemSettingsManager Manager => Locator.GetServiceNotNull<SystemSettingsManager>();

    public NHSettingsStoreProvider()
    {
      NHSettingsStoreProvider.U03Q2YWQDmRX2BvAh4nf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void AsfG04WQ3CJl76pkX3K9([In] object obj0, Guid uid, [In] object obj2, [In] object obj3) => ((SystemSettingsManager) obj0).SetString(uid, (string) obj2, (string) obj3);

    internal static bool PYMJ8SWQ1WVj3S6UjH3K() => NHSettingsStoreProvider.axQllIWQPVyGNo0nNLLL == null;

    internal static NHSettingsStoreProvider QBc774WQNUpxepHjCNin() => NHSettingsStoreProvider.axQllIWQPVyGNo0nNLLL;

    internal static object c0ehSQWQpeA2GcndmIiA([In] object obj0, Guid uid, [In] object obj2) => (object) ((SystemSettingsManager) obj0).GetString(uid, (string) obj2);

    internal static void wr6sF2WQafflnAWZuqbt([In] object obj0, Guid uid, [In] object obj2) => ((SystemSettingsManager) obj0).RemoveString(uid, (string) obj2);

    internal static void U03Q2YWQDmRX2BvAh4nf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

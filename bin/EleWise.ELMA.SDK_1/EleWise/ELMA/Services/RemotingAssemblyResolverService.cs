// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.RemotingAssemblyResolverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Services
{
  internal class RemotingAssemblyResolverService : IRemotingAssemblyResolverService
  {
    private ConfigurationServiceProvider configurationServiceProvider;
    private RemoteServiceProvider remoteServiceProvider;
    private BlockingCollection<KeyValuePair<string, bool>> unresolved;
    private bool resolving;
    private static RemotingAssemblyResolverService xMWCmeBxDXXA5CpjaINx;

    public RemotingAssemblyResolverService(
      ConfigurationServiceProvider configurationServiceProvider,
      RemoteServiceProvider remoteServiceProvider)
    {
      RemotingAssemblyResolverService.kuyAqTBx4RMacyY1wwQD();
      this.unresolved = new BlockingCollection<KeyValuePair<string, bool>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.remoteServiceProvider = remoteServiceProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            this.configurationServiceProvider = configurationServiceProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public virtual byte[] ResolveAssembly(string assemblyName, bool isFullName)
    {
      int num1 = 9;
      bool lockTaken;
      RemotingAssemblyResolverService assemblyResolverService;
      KeyValuePair<string, bool> keyValuePair;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_35;
            case 2:
              goto label_36;
            case 3:
              if (!RemotingAssemblyResolverService.DNF53sBx6WKryKcUiu66((object) this.remoteServiceProvider))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 6;
                continue;
              }
              goto label_36;
            case 4:
              lockTaken = false;
              num2 = 5;
              continue;
            case 5:
              goto label_4;
            case 6:
              if (!RemotingClientParameters.IsDebugging)
              {
                assemblyResolverService = this;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 4 : 4;
                continue;
              }
              goto label_28;
            case 7:
              goto label_30;
            case 8:
              if (!this.unresolved.Contains<KeyValuePair<string, bool>>(keyValuePair))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              }
              goto label_30;
            case 9:
              keyValuePair = new KeyValuePair<string, bool>(assemblyName, isFullName);
              num2 = 8;
              continue;
            default:
              if (!this.resolving)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 3;
                continue;
              }
              goto label_36;
          }
        }
label_28:
        num1 = 2;
      }
label_4:
      byte[] numArray;
      try
      {
        Monitor.Enter((object) assemblyResolverService, ref lockTaken);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_11;
            case 2:
            case 5:
              this.resolving = true;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
              continue;
            case 3:
              numArray = (byte[]) null;
              num3 = 4;
              continue;
            case 4:
              goto label_35;
            default:
              if (!this.resolving)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 5 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_11:
        try
        {
          object obj = RemotingAssemblyResolverService.f8G1JWBxHqXYAMk0G0DE((object) this.configurationServiceProvider, (object) assemblyName, isFullName);
          if (obj == null)
            this.unresolved.Add(keyValuePair);
          numArray = (byte[]) obj;
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
            num4 = 0;
          switch (num4)
          {
            default:
              goto label_35;
          }
        }
        finally
        {
          this.resolving = false;
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
      }
      finally
      {
        int num6;
        if (!lockTaken)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
        else
          goto label_23;
label_22:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_23:
        Monitor.Exit((object) assemblyResolverService);
        num6 = 2;
        goto label_22;
      }
label_30:
      return (byte[]) null;
label_35:
      return numArray;
label_36:
      return (byte[]) null;
    }

    internal static void kuyAqTBx4RMacyY1wwQD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool q0I7cyBxtZmLlP4qbd8r() => RemotingAssemblyResolverService.xMWCmeBxDXXA5CpjaINx == null;

    internal static RemotingAssemblyResolverService jeE4crBxwBkLkVgoOlvE() => RemotingAssemblyResolverService.xMWCmeBxDXXA5CpjaINx;

    internal static bool DNF53sBx6WKryKcUiu66([In] object obj0) => ((RemoteServiceProvider) obj0).Reconnecting;

    internal static object f8G1JWBxHqXYAMk0G0DE([In] object obj0, [In] object obj1, bool isFullName) => (object) ((ConfigurationServiceProvider) obj0).ResolveAssembly((string) obj1, isFullName);
  }
}

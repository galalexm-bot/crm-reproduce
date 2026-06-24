// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.PoolBasedSettingsService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Runtime.Managers
{
  [Service]
  public class PoolBasedSettingsService
  {
    private static readonly ILogger Log;
    private readonly IBLOBStore blobStore;
    private readonly IContextBoundVariableService contextObjects;
    internal static PoolBasedSettingsService cU8eDkWJVq1YY705RgnJ;

    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
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

    public PoolBasedSettingsService(
      IBLOBStore blobStore,
      IContextBoundVariableService contextObjects)
    {
      PoolBasedSettingsService.Ybs5JAWJRao9KoJZwY4E();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.blobStore = blobStore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 3;
            continue;
          case 2:
            this.Logger = NullLogger.Instance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 3:
            this.contextObjects = contextObjects;
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public object GetObject(string key)
    {
      int num1 = 3;
      byte[] bytes;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_5;
            case 3:
              if (key != null)
              {
                bytes = (byte[]) PoolBasedSettingsService.YeugXbWJK4chgFnEcxGA((object) this.blobStore, (object) key);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 4:
              goto label_16;
            default:
              if (bytes != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                continue;
              }
              goto label_16;
          }
        }
label_4:
        num1 = 2;
      }
label_5:
      throw new ArgumentNullException((string) PoolBasedSettingsService.Umr92CWJq8o3ukbjEPv8(-882126494 ^ -882202942));
label_7:
      object obj;
      try
      {
        obj = this.DeserializeObject(bytes);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              obj = (object) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_17;
          }
        }
      }
label_17:
      return obj;
label_16:
      return (object) null;
    }

    private object DeserializeObject(byte[] bytes)
    {
      object obj;
      switch (1)
      {
        case 1:
          try
          {
            obj = ClassSerializationHelper.DeserializeObject(bytes);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (SerializationException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 3:
                  goto label_10;
                case 2:
                  this.Logger.Error((Exception) ex, (string) PoolBasedSettingsService.MOq1VUWJXswHjI1V6wkZ(PoolBasedSettingsService.Umr92CWJq8o3ukbjEPv8(1319452732 ^ 1319596196)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                  continue;
                default:
                  if (!this.Logger.IsErrorEnabled())
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 3;
                    continue;
                  }
                  goto case 2;
              }
            }
label_10:
            throw;
          }
          break;
      }
      return obj;
    }

    public void SetObject(string key, object value)
    {
      int num = 3;
      byte[] numArray;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PoolBasedSettingsService.roa6RAWJONnV1QETUCmG((object) this.blobStore, (object) key, (object) numArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            if (PoolBasedSettingsService.HNHdL3WJTjfPmbGIDyaU((object) PoolBasedSettingsService.Log, EleWise.ELMA.Logging.LogLevel.Debug))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 4 : 3;
              continue;
            }
            goto case 1;
          case 3:
            numArray = ClassSerializationHelper.SerializeObject(value);
            num = 2;
            continue;
          case 4:
            PoolBasedSettingsService.p9YWa9WJncvXdInjOZcX((object) PoolBasedSettingsService.Log, PoolBasedSettingsService.kSJnk5WJkxrudI8OcFXS(PoolBasedSettingsService.Umr92CWJq8o3ukbjEPv8(-1317790512 ^ -1317655522), (object) key));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    public void Release(string key, object value)
    {
    }

    public void Release()
    {
    }

    private void Release(object value, int version, string key)
    {
    }

    public void RemoveObject(string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PoolBasedSettingsService.W4cV7yWJ2WC5P44KkxtF((object) this.blobStore, (object) s);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static PoolBasedSettingsService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PoolBasedSettingsService.Ybs5JAWJRao9KoJZwY4E();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            PoolBasedSettingsService.Log = (ILogger) PoolBasedSettingsService.Tm6SEvWJPgagt7wKv676(PoolBasedSettingsService.EYWQqfWJeYEB02wKK0IM(__typeref (PoolBasedSettingsService)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool V2FoIVWJSNbvEIxNPo9m() => PoolBasedSettingsService.cU8eDkWJVq1YY705RgnJ == null;

    internal static PoolBasedSettingsService QZYOSeWJicCuoFSdnruM() => PoolBasedSettingsService.cU8eDkWJVq1YY705RgnJ;

    internal static void Ybs5JAWJRao9KoJZwY4E() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Umr92CWJq8o3ukbjEPv8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YeugXbWJK4chgFnEcxGA([In] object obj0, [In] object obj1) => (object) ((IBLOBStore) obj0).LoadOrNull((string) obj1);

    internal static object MOq1VUWJXswHjI1V6wkZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool HNHdL3WJTjfPmbGIDyaU([In] object obj0, EleWise.ELMA.Logging.LogLevel level) => ((ILogger) obj0).IsEnabled(level);

    internal static object kSJnk5WJkxrudI8OcFXS([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void p9YWa9WJncvXdInjOZcX([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void roa6RAWJONnV1QETUCmG([In] object obj0, [In] object obj1, [In] object obj2) => ((IBLOBStore) obj0).Save((string) obj1, (byte[]) obj2);

    internal static void W4cV7yWJ2WC5P44KkxtF([In] object obj0, [In] object obj1) => ((IBLOBStore) obj0).Remove((string) obj1);

    internal static Type EYWQqfWJeYEB02wKK0IM([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Tm6SEvWJPgagt7wKv676(Type componentType) => (object) EleWise.ELMA.Logging.Logger.GetLogger(componentType);

    private class KeedValue
    {
      public readonly List<object> objects;
      public readonly int version;
      internal static object irNr83QLAuPDmsAuHqL8;

      public KeedValue(PoolBasedSettingsService.KeedValue keedValue)
      {
        PoolBasedSettingsService.KeedValue.Nk68RcQL0DbitxDd4Xj3();
        // ISSUE: explicit constructor call
        this.\u002Ector(keedValue.version, keedValue.objects);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public KeedValue(int version, List<object> objects)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.objects = new List<object>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.version = version;
        this.objects = objects;
      }

      internal static void Nk68RcQL0DbitxDd4Xj3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sgMq7yQL7nQl2qIc1mbn() => PoolBasedSettingsService.KeedValue.irNr83QLAuPDmsAuHqL8 == null;

      internal static PoolBasedSettingsService.KeedValue cYmcYaQLx799bbDYMhXf() => (PoolBasedSettingsService.KeedValue) PoolBasedSettingsService.KeedValue.irNr83QLAuPDmsAuHqL8;
    }

    private class PooledObjectsHolder
    {
      public List<Tuple<object, int, string>> objects;
      private static object fcO7rZQLmAAnkpN4yvJV;

      public PooledObjectsHolder()
      {
        PoolBasedSettingsService.PooledObjectsHolder.V39XirQLJT7mTGpFRl6A();
        this.objects = new List<Tuple<object, int, string>>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void V39XirQLJT7mTGpFRl6A() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool bKTDvCQLyYtGiN729AJN() => PoolBasedSettingsService.PooledObjectsHolder.fcO7rZQLmAAnkpN4yvJV == null;

      internal static PoolBasedSettingsService.PooledObjectsHolder WlIw0GQLMb7F3QuIDUbD() => (PoolBasedSettingsService.PooledObjectsHolder) PoolBasedSettingsService.PooledObjectsHolder.fcO7rZQLmAAnkpN4yvJV;
    }
  }
}

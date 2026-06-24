// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.ActorModelCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Cache.ActorModel.Actors;
using EleWise.ELMA.Cache.ActorModel.Configuration;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.ActorModel
{
  /// <summary>Распределенный кэш на базе Модели Акторов.</summary>
  internal sealed class ActorModelCacheService : CacheService, IOptionsProvider
  {
    private XmlObjectSerializer serializer;
    internal static ActorModelCacheService zbRHZUfXnQKy9weJsJcQ;

    /// <summary>Интерфейс для работы со средой исполнения приложения</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Среда Actor Model</summary>
    public IActorModelRuntime ActorModelRuntime
    {
      get => this.\u003CActorModelRuntime\u003Ek__BackingField;
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
              this.\u003CActorModelRuntime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    /// <summary>Настройки для распределенного кэша.</summary>
    public CacheOptions Options
    {
      get => this.\u003COptions\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003COptions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    /// <summary>Сериализатор</summary>
    public XmlObjectSerializer Serializer
    {
      get
      {
        int num = 2;
        XmlObjectSerializer serializer1;
        XmlObjectSerializer serializer2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.serializer = serializer1 = (XmlObjectSerializer) new NetDataContractSerializer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            case 2:
              serializer2 = this.serializer;
              if (serializer2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return serializer2;
label_6:
        return serializer1;
      }
    }

    /// <inheritdoc />
    public override void Initialize(string name, NameValueCollection config)
    {
      int num = 2;
      CacheOptions cacheOptions;
      int result;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            cacheOptions = new CacheOptions();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 6 : 3;
            continue;
          case 2:
            ActorModelCacheService.eXeA4tfXeJXsgw3tdYZH((object) this, (object) name, (object) config);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
          case 3:
          case 4:
            this.Options = cacheOptions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 5:
            ActorModelCacheService.G6oQfIfX1QvIHO8UtFWl((object) cacheOptions, (byte) result);
            num = 4;
            continue;
          case 6:
            if (!int.TryParse((string) ActorModelCacheService.LQovO1fXPNOsVlDwUfH5((object) config, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317971526)), out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 3;
              continue;
            }
            goto case 5;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_2:;
    }

    /// <inheritdoc />
    public override bool IsDistributed => true;

    /// <inheritdoc />
    protected override void ClearRegionInternal(string region)
    {
      int num = 1;
      IConsistentHashingCacheActor actor;
      string region1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.InvokeActor((Func<Task>) (() => actor.ClearRegion(region1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
            continue;
          case 4:
            actor = this.GetActor();
            num = 3;
            continue;
          default:
            region1 = region;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 4 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override bool ContainsInternal(string key, string region)
    {
      int num = 1;
      IConsistentHashingCacheActor actor;
      string key1;
      string region1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            region1 = region;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 4;
            continue;
          case 3:
            goto label_6;
          case 4:
            actor = this.GetActor();
            num = 3;
            continue;
          default:
            key1 = key;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 2;
            continue;
        }
      }
label_6:
      return this.InvokeActor<bool>((Func<Task<bool>>) (() => actor.Contains(key1, region1)));
    }

    /// <inheritdoc />
    protected override object GetValue(string key, string region)
    {
      int num = 7;
      CacheResult cacheResult;
      IConsistentHashingCacheActor actor;
      string key1;
      string region1;
      while (true)
      {
        switch (num)
        {
          case 1:
            actor = this.GetActor();
            num = 5;
            continue;
          case 2:
            region1 = region;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_5;
          case 5:
            cacheResult = this.InvokeActor<CacheResult>((Func<Task<CacheResult>>) (() => actor.Get(key1, region1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 6:
            key1 = key;
            num = 2;
            continue;
          case 7:
            num = 6;
            continue;
          default:
            if (cacheResult.Success)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 4;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return this.Deserialize((object) cacheResult.Value);
    }

    /// <inheritdoc />
    protected override void InsertValue<T>(
      string key,
      object value,
      string region,
      TimeSpan cacheDuration,
      CacheItemRemovedCallback<T> onRemoveItemCallback)
    {
      IConsistentHashingCacheActor actor = this.GetActor();
      byte[] serializedValue = this.Serialize(value);
      this.InvokeActor((Func<Task>) (() => actor.Set(key, region, serializedValue, cacheDuration)));
    }

    /// <inheritdoc />
    protected override void RemoveInternal(string key, string region)
    {
      int num = 3;
      IConsistentHashingCacheActor actor;
      string key1;
      string region1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            key1 = key;
            num = 5;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            this.InvokeActor((Func<Task>) (() => actor.Remove(key1, region1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
          case 5:
            region1 = region;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            actor = this.GetActor();
            num = 4;
            continue;
        }
      }
label_2:;
    }

    private IConsistentHashingCacheActor GetActor()
    {
      int num = 1;
      Guid connectionUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            connectionUid = this.RuntimeApplication.ConnectionUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.ActorModelRuntime.GetActor<IConsistentHashingCacheActor>(connectionUid);
    }

    private byte[] Serialize(object value)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      byte[] numArray;
      while (true)
      {
        switch (num1)
        {
          case 1:
            value = CacheService.AssembleValue<object>(value);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            memoryStream = (MemoryStream) ActorModelCacheService.SdQBsZfXNX6h2SepTTuk();
            num1 = 4;
            continue;
          case 3:
            goto label_23;
          case 4:
            goto label_2;
          default:
            numArray = (byte[]) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      try
      {
        GZipStream gzipStream = new GZipStream((Stream) ActorModelCacheService.xeGSM5fX3woMRlZVj3af((object) memoryStream), CompressionMode.Compress);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              ActorModelCacheService.UhPmHXfXpXpfEubjgQHS((object) this.Serializer, (object) gzipStream, value);
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_23;
                  case 2:
                    ActorModelCacheService.IdVcdufXaXcJII6gBJvf((object) gzipStream);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                    continue;
                  default:
                    numArray = (byte[]) ActorModelCacheService.cS3BvLfXDrN90fXTLcKq((object) memoryStream);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num4;
              if (gzipStream == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              else
                goto label_13;
label_12:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_13:
              ActorModelCacheService.h0LrPGfXtotieG46tUDt((object) gzipStream);
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
              {
                num4 = 1;
                goto label_12;
              }
              else
                goto label_12;
            }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
        else
          goto label_19;
label_18:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_19:
        ActorModelCacheService.h0LrPGfXtotieG46tUDt((object) memoryStream);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        {
          num5 = 1;
          goto label_18;
        }
        else
          goto label_18;
      }
label_23:
      return numArray;
    }

    private object Deserialize(object value)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = (MemoryStream) ActorModelCacheService.u8s4uGfXwa3ahPY1JrCu((object) (value as byte[]), false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      object obj;
      return obj;
label_4:
      try
      {
        GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Decompress);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              obj = ActorModelCacheService.eaqO2cfX445PbCiw1twl((object) this.Serializer, (object) gzipStream);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_3;
              }
            }
            finally
            {
              if (gzipStream != null)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ActorModelCacheService.h0LrPGfXtotieG46tUDt((object) gzipStream);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
              }
label_17:;
            }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
        else
          goto label_21;
label_20:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_21:
        ActorModelCacheService.h0LrPGfXtotieG46tUDt((object) memoryStream);
        num5 = 2;
        goto label_20;
      }
    }

    private void InvokeActor(Func<Task> func) => Task.Run((Func<Task>) (() =>
    {
      int num1 = 1;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        switch (num1)
        {
          case 1:
            contextSessionOwner = CallContextSessionOwner.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      Task task;
      return task;
label_4:
      try
      {
        task = func();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        if (contextSessionOwner != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                contextSessionOwner.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_13:;
      }
    })).Wait();

    private T InvokeActor<T>(Func<Task<T>> func) => Task.Run<T>((Func<Task<T>>) (() =>
    {
      using (CallContextSessionOwner.Create())
        return func();
    })).Result;

    public ActorModelCacheService()
    {
      ActorModelCacheService.OAkLjTfX6X2eWMbBCMYa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hZ0GayfXOQ6fXBhhX1I5() => ActorModelCacheService.zbRHZUfXnQKy9weJsJcQ == null;

    internal static ActorModelCacheService tPYv41fX2mVfZRQqLRr0() => ActorModelCacheService.zbRHZUfXnQKy9weJsJcQ;

    internal static void eXeA4tfXeJXsgw3tdYZH([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((ProviderBase) obj0).Initialize((string) obj1, (NameValueCollection) obj2));

    internal static object LQovO1fXPNOsVlDwUfH5([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static void G6oQfIfX1QvIHO8UtFWl([In] object obj0, byte value) => ((CacheOptions) obj0).ReplicaFactor = value;

    internal static object SdQBsZfXNX6h2SepTTuk() => (object) MemoryHelper.GetMemoryStream();

    internal static object xeGSM5fX3woMRlZVj3af([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static void UhPmHXfXpXpfEubjgQHS([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlObjectSerializer) obj0).WriteObject((Stream) obj1, obj2);

    internal static void IdVcdufXaXcJII6gBJvf([In] object obj0) => ((Stream) obj0).Close();

    internal static object cS3BvLfXDrN90fXTLcKq([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static void h0LrPGfXtotieG46tUDt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object u8s4uGfXwa3ahPY1JrCu([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object eaqO2cfX445PbCiw1twl([In] object obj0, [In] object obj1) => ((XmlObjectSerializer) obj0).ReadObject((Stream) obj1);

    internal static void OAkLjTfX6X2eWMbBCMYa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

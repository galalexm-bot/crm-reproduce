// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.MessageAttachment
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Messaging
{
  /// <summary>Объект вложения в сообщении ленты</summary>
  [Serializable]
  public struct MessageAttachment : IPackSerializableItem
  {
    internal static object yfCfswhmYsFOZNRK6Iw8;

    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
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

    public unsafe MessageAttachment(string name, Guid typeUid, string id)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        goto label_4;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            *(MessageAttachment*) ref this = new MessageAttachment();
            num = 4;
            continue;
          case 2:
            this.TypeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.Name = name;
            num = 2;
            continue;
          default:
            this.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 3;
            continue;
        }
      }
label_2:
      return;
label_4:
      num = 0;
      goto label_1;
    }

    public override string ToString() => (string) MessageAttachment.PUO3UThmstn44YYqgjxK((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411293571), (object) this.TypeUid, (object) this.Id, (object) this.Name);

    public string Serialize() => string.Format((string) MessageAttachment.B9trXZhmcjw3tW1l0exX(-542721635 ^ -542818703), (object) this.TypeUid, (object) this.Id, (object) this.Name);

    public void DeserializeFrom(string value)
    {
      int num = 3;
      string[] strArray;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Id = strArray[1];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 1;
            continue;
          case 2:
            this.TypeUid = new Guid(strArray[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          case 3:
            strArray = (string[]) MessageAttachment.Qo3145hyFnnlkch9GAtK((object) value, MessageAttachment.aocsKWhmzkhJ4MlwlPL5((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606707618)), 3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
            continue;
          case 4:
            this.Name = strArray[2];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool c6my5BhmLVrsC0qcAU8B() => MessageAttachment.yfCfswhmYsFOZNRK6Iw8 == null;

    internal static object EAQXNghmUEdGD5WxRBOq() => MessageAttachment.yfCfswhmYsFOZNRK6Iw8;

    internal static object PUO3UThmstn44YYqgjxK(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object B9trXZhmcjw3tW1l0exX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aocsKWhmzkhJ4MlwlPL5([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object Qo3145hyFnnlkch9GAtK([In] object obj0, [In] object obj1, [In] int obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);
  }
}

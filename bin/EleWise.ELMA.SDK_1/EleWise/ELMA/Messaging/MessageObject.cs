// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.MessageObject
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
  /// <summary>Объект, связанный с сообщением</summary>
  [Serializable]
  public struct MessageObject : IPackSerializableItem
  {
    private static object HggBa2hyBhUV3pORWxLC;

    /// <summary>Тип объекта</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор объекта</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя объекта</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    /// <summary>Новый объект для обсуждения</summary>
    /// <param name="name">Отоброжаемое имя</param>
    /// <param name="typeUid">Тип объекта</param>
    /// <param name="id">Идентификатор</param>
    public unsafe MessageObject(string name, Guid typeUid, string id)
    {
      MessageObject.Bxs9yfhyb2wZbt6SvDHx();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        goto label_4;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            *(MessageObject*) ref this = new MessageObject();
            num = 3;
            continue;
          case 2:
            this.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 4;
            continue;
          case 3:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            this.TypeUid = typeUid;
            num = 2;
            continue;
        }
      }
label_2:
      return;
label_4:
      num = 0;
      goto label_1;
    }

    public override string ToString() => (string) MessageObject.vCGUkBhyG31YuxYP0t2p(MessageObject.fJ941GhyhtYuRTMGm5nD(1461825605 - 1531863589 ^ -70202896), (object) this.TypeUid, (object) this.Id, (object) this.Name);

    public string Serialize() => (string) MessageObject.vCGUkBhyG31YuxYP0t2p(MessageObject.fJ941GhyhtYuRTMGm5nD(1051802738 - -1831968059 ^ -1411293631), (object) this.TypeUid, (object) this.Id, (object) this.Name);

    public void DeserializeFrom(string value)
    {
      int num = 1;
      string[] strArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            strArray = (string[]) MessageObject.jYCF8Qhyfq9hUAGdQdQy((object) value, MessageObject.at9rNxhyE4I8MIBTSWy0(MessageObject.fJ941GhyhtYuRTMGm5nD(1669212571 ^ 1669298393)), 3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Id = strArray[1];
            num = 3;
            continue;
          case 3:
            this.Name = strArray[2];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 4;
            continue;
          case 4:
            goto label_2;
          default:
            this.TypeUid = new Guid(strArray[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool NYJwmdhyWc7WUlNcHEpr() => MessageObject.HggBa2hyBhUV3pORWxLC == null;

    internal static object Uf4Xe4hyooFw409kyLWV() => MessageObject.HggBa2hyBhUV3pORWxLC;

    internal static void Bxs9yfhyb2wZbt6SvDHx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object fJ941GhyhtYuRTMGm5nD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vCGUkBhyG31YuxYP0t2p(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object at9rNxhyE4I8MIBTSWy0([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object jYCF8Qhyfq9hUAGdQdQy([In] object obj0, [In] object obj1, [In] int obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);
  }
}

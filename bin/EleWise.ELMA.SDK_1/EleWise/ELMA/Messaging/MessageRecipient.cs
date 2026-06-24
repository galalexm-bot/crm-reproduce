// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.MessageRecipient
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
  /// <summary>Получатель сообщения на уровне объекта</summary>
  [Serializable]
  public struct MessageRecipient : IPackSerializableItem
  {
    private static object dWwpamhyQVqXSVPJTMXr;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    public unsafe MessageRecipient(string name, Guid typeUid, string id)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 2:
            this.Id = id;
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            *(MessageRecipient*) ref this = new MessageRecipient();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
            continue;
          default:
            this.TypeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public override string ToString() => (string) MessageRecipient.j9h7rwhyZQe8iEmvFF9Y(MessageRecipient.YsI2ybhy8D5FBUDqlL9N(-2107978722 ^ -2108077106), (object) this.TypeUid, (object) this.Id, (object) this.Name);

    public string Serialize() => (string) MessageRecipient.j9h7rwhyZQe8iEmvFF9Y(MessageRecipient.YsI2ybhy8D5FBUDqlL9N(1242972401 >> 4 ^ 77784035), (object) this.TypeUid, (object) this.Id, (object) this.Name);

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
            num = 4;
            continue;
          case 2:
            this.TypeUid = new Guid(strArray[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
            continue;
          case 3:
            strArray = (string[]) MessageRecipient.KeLWGyhyIaZhTrkSAUgK((object) value, MessageRecipient.FMNqFPhyurPo9P1aIWkq(MessageRecipient.YsI2ybhy8D5FBUDqlL9N(825385222 ^ 825438276)), 3);
            num = 2;
            continue;
          case 4:
            this.Name = strArray[2];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool O4fwRHhyCmbvTAfkEmkn() => MessageRecipient.dWwpamhyQVqXSVPJTMXr == null;

    internal static object tomTndhyv0dBGEPbKIiH() => MessageRecipient.dWwpamhyQVqXSVPJTMXr;

    internal static object YsI2ybhy8D5FBUDqlL9N(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object j9h7rwhyZQe8iEmvFF9Y(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object FMNqFPhyurPo9P1aIWkq([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object KeLWGyhyIaZhTrkSAUgK([In] object obj0, [In] object obj1, [In] int obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);
  }
}

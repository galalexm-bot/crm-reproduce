// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifestFakeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Элемент из фальшивого манифеста BPM App</summary>
  [Serializable]
  public class BPMAppManifestFakeItem
  {
    internal static BPMAppManifestFakeItem SPwrFAfkvaHXXRUxTgIq;

    public BPMAppManifestFakeItem()
    {
      BPMAppManifestFakeItem.blmoLyfkuDjnUAiR3HyF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public BPMAppManifestFakeItem(Guid uid, string title)
    {
      BPMAppManifestFakeItem.blmoLyfkuDjnUAiR3HyF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Title = title;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            case 2:
              this.Uid = uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_4:
        this.Items = new List<BPMAppManifestFakeItem>();
        num1 = 3;
      }
label_3:;
    }

    public BPMAppManifestFakeItem(string uidProxy, string title)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
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
            this.Items = new List<BPMAppManifestFakeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            this.Uid = BPMAppManifestFakeItem.BP4hlXfkIhrLJ6XpVHKM();
            num = 4;
            continue;
          case 3:
            this.UidProxy = uidProxy;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          case 4:
            this.Title = title;
            num = 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Уникальный идентификатор элемента</summary>
    [XmlElement("Uid")]
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента (альтернатива)</summary>
    [XmlElement("UidProxy")]
    public string UidProxy
    {
      get => this.\u003CUidProxy\u003Ek__BackingField;
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
              this.\u003CUidProxy\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Отображаемый текст</summary>
    [XmlElement("Title")]
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Дополнительный отображаемый текст</summary>
    [XmlElement("TitleAdditional")]
    public string TitleAdditional
    {
      get => this.\u003CTitleAdditional\u003Ek__BackingField;
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
              this.\u003CTitleAdditional\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    [XmlArray("Items")]
    public List<BPMAppManifestFakeItem> Items { get; set; }

    public BPMAppManifestFakeItem GetOrCreateItemByUid(Guid uid, string title = null)
    {
      int num1 = 4;
      BPMAppManifestFakeItem itemByUid;
      while (true)
      {
        int num2 = num1;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              BPMAppManifestFakeItem.bIa0AffkVdFlsbuZSRSw((object) itemByUid, (object) title);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 8 : 5;
              continue;
            case 2:
            case 5:
              if (title == null)
              {
                num2 = 10;
                continue;
              }
              goto case 1;
            case 3:
              uid1 = uid;
              num2 = 7;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 3 : 1;
              continue;
            case 6:
              this.Items.Add(itemByUid);
              num2 = 2;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              itemByUid = this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => BPMAppManifestFakeItem.\u003C\u003Ec__DisplayClass23_0.M00ycW8ckqgeBJGxsp5S((object) BPMAppManifestFakeItem.\u003C\u003Ec__DisplayClass23_0.AgKWHw8cTidK2XJmKjN1((object) c), (object) uid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 8:
            case 10:
              goto label_4;
            case 9:
              itemByUid = new BPMAppManifestFakeItem(uid1, title);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 6;
              continue;
            default:
              if (itemByUid == null)
                goto case 9;
              else
                goto label_13;
          }
        }
label_13:
        num1 = 5;
      }
label_4:
      return itemByUid;
    }

    public BPMAppManifestFakeItem GetOrCreateItemByUidProxy(string uidProxy, string title = null)
    {
      int num1 = 2;
      BPMAppManifestFakeItem itemByUidProxy;
      while (true)
      {
        int num2 = num1;
        string uidProxy1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              uidProxy1 = uidProxy;
              num2 = 3;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
              continue;
            case 3:
              itemByUidProxy = this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => object.Equals((object) c.UidProxy, (object) uidProxy1)));
              num2 = 9;
              continue;
            case 4:
              goto label_9;
            case 5:
            case 6:
              if (title != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 7:
              this.Items.Add(itemByUidProxy);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 5;
              continue;
            case 8:
              goto label_10;
            case 9:
              if (itemByUidProxy != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 6 : 2;
                continue;
              }
              goto label_9;
            default:
              itemByUidProxy.Title = title;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 2;
              continue;
          }
        }
label_9:
        itemByUidProxy = new BPMAppManifestFakeItem(uidProxy1, title);
        num1 = 7;
      }
label_10:
      return itemByUidProxy;
    }

    public BPMAppManifestFakeItem GetItemByUid(Guid uid)
    {
      int num = 1;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => BPMAppManifestFakeItem.\u003C\u003Ec__DisplayClass25_0.sDtAQf8caZ39deNTGT4r((object) BPMAppManifestFakeItem.\u003C\u003Ec__DisplayClass25_0.qRG2i58cpUF4mpw7t6l6((object) c), (object) uid1)));
    }

    internal static void blmoLyfkuDjnUAiR3HyF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool B0inuifk8DpUMB5pf09i() => BPMAppManifestFakeItem.SPwrFAfkvaHXXRUxTgIq == null;

    internal static BPMAppManifestFakeItem QJ2xMQfkZ7hnQFCxYIJe() => BPMAppManifestFakeItem.SPwrFAfkvaHXXRUxTgIq;

    internal static Guid BP4hlXfkIhrLJ6XpVHKM() => Guid.NewGuid();

    internal static void bIa0AffkVdFlsbuZSRSw([In] object obj0, [In] object obj1) => ((BPMAppManifestFakeItem) obj0).Title = (string) obj1;
  }
}

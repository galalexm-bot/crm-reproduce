// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifestFakeChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Раздел в фальшивом манифесте BPM App</summary>
  [Serializable]
  public class BPMAppManifestFakeChapter : IXsiType
  {
    private static BPMAppManifestFakeChapter enMG7cfTcmIIPosbP6po;

    public BPMAppManifestFakeChapter()
    {
      BPMAppManifestFakeChapter.uYxssffkB7PRuV62YeEC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<BPMAppManifestFakeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public BPMAppManifestFakeChapter(Guid uid, string title)
    {
      BPMAppManifestFakeChapter.uYxssffkB7PRuV62YeEC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Items = new List<BPMAppManifestFakeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            this.Title = title;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          case 3:
            this.Uid = uid;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Уникальный идентификатор раздела</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
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
      int num1 = 5;
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
              BPMAppManifestFakeChapter.tqeqK0fkWjCftfE7dJ4Z((object) itemByUid, (object) title);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 7 : 7;
              continue;
            case 2:
              if (title != null)
                goto case 1;
              else
                goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated method
              itemByUid = this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => BPMAppManifestFakeChapter.\u003C\u003Ec__DisplayClass14_0.fxd64s8cQwOOMi3Z1Pe3((object) c.Uid, (object) uid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 4:
              uid1 = uid;
              num2 = 3;
              continue;
            case 5:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 2;
              continue;
            case 6:
              this.Items.Add(itemByUid);
              num2 = 2;
              continue;
            case 7:
            case 8:
              goto label_7;
            case 9:
              itemByUid = new BPMAppManifestFakeItem(uid1, title);
              num2 = 6;
              continue;
            default:
              if (itemByUid == null)
              {
                num2 = 9;
                continue;
              }
              goto case 2;
          }
        }
label_9:
        num1 = 8;
      }
label_7:
      return itemByUid;
    }

    public BPMAppManifestFakeItem GetOrCreateItemByUidProxy(string uidProxy, string title = null)
    {
      int num = 2;
      BPMAppManifestFakeItem itemByUidProxy;
      string uidProxy1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uidProxy1 = uidProxy;
            num = 7;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
            continue;
          case 3:
          case 5:
            if (title != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 6 : 0;
              continue;
            }
            goto label_3;
          case 4:
            itemByUidProxy = new BPMAppManifestFakeItem(uidProxy1, title);
            num = 8;
            continue;
          case 6:
            BPMAppManifestFakeChapter.tqeqK0fkWjCftfE7dJ4Z((object) itemByUidProxy, (object) title);
            num = 9;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated method
            itemByUidProxy = this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => object.Equals(BPMAppManifestFakeChapter.\u003C\u003Ec__DisplayClass15_0.Wb6sDy8cZMpV3WAkbb7Q((object) c), (object) uidProxy1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 8:
            this.Items.Add(itemByUidProxy);
            num = 5;
            continue;
          case 9:
            goto label_3;
          default:
            if (itemByUidProxy != null)
            {
              num = 3;
              continue;
            }
            goto case 4;
        }
      }
label_3:
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Items.FirstOrDefault<BPMAppManifestFakeItem>((Func<BPMAppManifestFakeItem, bool>) (c => BPMAppManifestFakeChapter.\u003C\u003Ec__DisplayClass16_0.ucipeW8cRVsTOU24QT0D((object) BPMAppManifestFakeChapter.\u003C\u003Ec__DisplayClass16_0.dadWIv8ci0YeDnxwRKsk((object) c), (object) uid1)));
    }

    internal static void uYxssffkB7PRuV62YeEC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wrLPvEfTzTMqpkuiN9My() => BPMAppManifestFakeChapter.enMG7cfTcmIIPosbP6po == null;

    internal static BPMAppManifestFakeChapter OUnUTkfkFfWtAvm1CnxE() => BPMAppManifestFakeChapter.enMG7cfTcmIIPosbP6po;

    internal static void tqeqK0fkWjCftfE7dJ4Z([In] object obj0, [In] object obj1) => ((BPMAppManifestFakeItem) obj0).Title = (string) obj1;
  }
}

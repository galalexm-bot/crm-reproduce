// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppFakeManifest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Фальшивый манифест для BPM App</summary>
  [Serializable]
  public class BPMAppFakeManifest
  {
    private string displayName;
    private static BPMAppFakeManifest Hb12T3fTgSSQ92SDirqM;

    /// <summary>Ctor</summary>
    public BPMAppFakeManifest()
    {
      BPMAppFakeManifest.TRxUXhfTYC5XHrNmECuU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Chapters = new List<BPMAppManifestFakeChapter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Разделы манифеста</summary>
    [XmlArray("Chapters")]
    public List<BPMAppManifestFakeChapter> Chapters { get; set; }

    /// <summary>Идентификатор для построения дерева по манифесту</summary>
    public string TreeUid
    {
      get => this.\u003CTreeUid\u003Ek__BackingField;
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
              this.\u003CTreeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя манифеста</summary>
    public string DisplayName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (BPMAppFakeManifest.eBxFyafTL6RApKfG8ehg((object) this.displayName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return this.displayName;
label_5:
        return (string) BPMAppFakeManifest.YIfrvPfTsHnyvlyIaWZB(BPMAppFakeManifest.Bkvv0CfTUpSwKBk1Tu0t(92412609 - 1050237057 ^ -957481134));
      }
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
              this.displayName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    public BPMAppManifestFakeChapter GetOrCreateChapterByUid(Guid uid, string title = "")
    {
      int num1 = 5;
      BPMAppManifestFakeChapter chapterByUid;
      while (true)
      {
        int num2 = num1;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              chapterByUid = this.Chapters.FirstOrDefault<BPMAppManifestFakeChapter>((Func<BPMAppManifestFakeChapter, bool>) (c => object.Equals((object) BPMAppFakeManifest.\u003C\u003Ec__DisplayClass13_0.zSoPkt8cbAWMbiJgnG8k((object) c), (object) uid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              this.Chapters.Add(chapterByUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 6;
              continue;
            case 4:
              uid1 = uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              goto label_10;
            default:
              if (chapterByUid == null)
              {
                num2 = 2;
                continue;
              }
              goto label_10;
          }
        }
label_6:
        chapterByUid = new BPMAppManifestFakeChapter(uid1, title);
        num1 = 3;
      }
label_10:
      return chapterByUid;
    }

    internal static void TRxUXhfTYC5XHrNmECuU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nFEIHjfT5H4BKj47ybL9() => BPMAppFakeManifest.Hb12T3fTgSSQ92SDirqM == null;

    internal static BPMAppFakeManifest fsZvCnfTje6Uu2b89yCx() => BPMAppFakeManifest.Hb12T3fTgSSQ92SDirqM;

    internal static bool eBxFyafTL6RApKfG8ehg([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Bkvv0CfTUpSwKBk1Tu0t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YIfrvPfTsHnyvlyIaWZB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}

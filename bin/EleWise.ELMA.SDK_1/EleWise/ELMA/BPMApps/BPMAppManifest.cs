// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifest
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
  /// <summary>Манифест для BPM App</summary>
  public class BPMAppManifest
  {
    private static BPMAppManifest Qj5wJhfkqyNeinbNWhkZ;

    public BPMAppManifest()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Flags = new List<BPMAppManifestFlag>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          default:
            this.Chapters = new List<BPMAppManifestChapter>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Разделы манифеста</summary>
    [XmlArray("Chapters")]
    public List<BPMAppManifestChapter> Chapters { get; set; }

    /// <summary>Флаги</summary>
    [XmlArray("Flags")]
    public List<BPMAppManifestFlag> Flags { get; set; }

    public void SetChapter(BPMAppManifestChapter chapter)
    {
      int num = 7;
      int index;
      BPMAppManifestChapter chapter1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
          case 3:
            this.Chapters.Add(chapter1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          case 4:
            BPMAppManifest.JYvKSVfkkQiSTZrmFPrj((object) chapter1, BPMAppManifest.rKpYIDfkTFjEQSdWerVb(1178210108 ^ 1178552698));
            num = 5;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            index = this.Chapters.FindIndex((Predicate<BPMAppManifestChapter>) (c => BPMAppManifest.\u003C\u003Ec__DisplayClass9_0.N0HMXG8c6eCMr0cHy2th((object) c) == BPMAppManifest.\u003C\u003Ec__DisplayClass9_0.N0HMXG8c6eCMr0cHy2th((object) chapter1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 6:
            chapter1 = chapter;
            num = 4;
            continue;
          case 7:
            num = 6;
            continue;
          case 8:
            this.Chapters[index] = chapter1;
            num = 3;
            continue;
          default:
            if (index < 0)
            {
              num = 2;
              continue;
            }
            goto case 8;
        }
      }
label_9:;
    }

    public BPMAppManifestChapter GetChapter(Guid uid)
    {
      int num = 2;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return this.Chapters.FirstOrDefault<BPMAppManifestChapter>((Func<BPMAppManifestChapter, bool>) (c => BPMAppManifest.\u003C\u003Ec__DisplayClass10_0.xtA3ly8c0p3oQLi8H2bS(c.Uid, uid1)));
    }

    public void SetFlag(Guid uid, bool value)
    {
      int num = 1;
      BPMAppManifestFlag bpmAppManifestFlag1;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            BPMAppManifest.jyA2kMfkOBQFUHkWy8i9((object) bpmAppManifestFlag1, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 6 : 4;
            continue;
          case 3:
            this.Flags.Add(bpmAppManifestFlag1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
            continue;
          case 4:
            BPMAppManifestFlag bpmAppManifestFlag2 = new BPMAppManifestFlag();
            BPMAppManifest.yKAoYAfkn5OOsZMPY9Qu((object) bpmAppManifestFlag2, uid1);
            bpmAppManifestFlag1 = bpmAppManifestFlag2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            bpmAppManifestFlag1 = this.Flags.FirstOrDefault<BPMAppManifestFlag>((Func<BPMAppManifestFlag, bool>) (f => BPMAppManifest.\u003C\u003Ec__DisplayClass11_0.PHxnxc8c9P84dvXRLXbD(BPMAppManifest.\u003C\u003Ec__DisplayClass11_0.wRiD1R8cJpUQ1ash7TR7((object) f), uid1)));
            num = 7;
            continue;
          case 6:
            goto label_2;
          case 7:
            if (bpmAppManifestFlag1 == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          default:
            uid1 = uid;
            num = 5;
            continue;
        }
      }
label_2:;
    }

    public bool? GetFlag(Guid uid) => this.Flags.FirstOrDefault<BPMAppManifestFlag>((Func<BPMAppManifestFlag, bool>) (f => BPMAppManifest.\u003C\u003Ec__DisplayClass12_0.adJ4VS8cjdPtAP2vuO0P(BPMAppManifest.\u003C\u003Ec__DisplayClass12_0.FM9iwh8c5fZ296kJkDBJ((object) f), uid)))?.Value;

    public bool GetFlag(Guid uid, bool defaultValue)
    {
      int num = 2;
      BPMAppManifestFlag bpmAppManifestFlag;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 1;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            bpmAppManifestFlag = this.Flags.FirstOrDefault<BPMAppManifestFlag>((Func<BPMAppManifestFlag, bool>) (f => BPMAppManifest.\u003C\u003Ec__DisplayClass13_0.PkHl9p8cccSFnjtMoAxA((object) f) == uid1));
            num = 4;
            continue;
          case 4:
            if (bpmAppManifestFlag != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          default:
            goto label_7;
        }
      }
label_7:
      return BPMAppManifest.BoStNlfk2ReQNwOLXKl3((object) bpmAppManifestFlag);
label_8:
      return defaultValue;
    }

    internal static bool y3XSVHfkKbw7nciN1EuX() => BPMAppManifest.Qj5wJhfkqyNeinbNWhkZ == null;

    internal static BPMAppManifest dNo2lifkX34MQV5vFcOT() => BPMAppManifest.Qj5wJhfkqyNeinbNWhkZ;

    internal static object rKpYIDfkTFjEQSdWerVb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void JYvKSVfkkQiSTZrmFPrj([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void yKAoYAfkn5OOsZMPY9Qu([In] object obj0, Guid value) => ((BPMAppManifestFlag) obj0).Uid = value;

    internal static void jyA2kMfkOBQFUHkWy8i9([In] object obj0, bool value) => ((BPMAppManifestFlag) obj0).Value = value;

    internal static bool BoStNlfk2ReQNwOLXKl3([In] object obj0) => ((BPMAppManifestFlag) obj0).Value;
  }
}

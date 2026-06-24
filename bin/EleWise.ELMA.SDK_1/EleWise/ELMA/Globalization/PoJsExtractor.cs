// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.PoJsExtractor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Извлечепние ресурсов для JS</summary>
  public class PoJsExtractor
  {
    internal static PoJsExtractor rgLXCPGEIj7kKVgkTisi;

    /// <summary>Извлечь ресурсы для JS</summary>
    /// <param name="localeFileNames">Список имен файлов с переведенными ресурсами</param>
    /// <param name="baseFileNames">Список имен файлов с базовыми ресурсами</param>
    /// <returns></returns>
    public static Dictionary<string, string> Extract(
      IEnumerable<string> localeFileNames,
      IEnumerable<string> baseFileNames)
    {
      Contract.ArgumentNotNull((object) localeFileNames, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70223423));
      List<int> intList = new List<int>();
      if (baseFileNames != null && baseFileNames.Any<string>())
      {
        foreach (string baseFileName in baseFileNames)
        {
          BlockManager blockManager = new BlockManager();
          blockManager.ReadFromFile(baseFileName);
          IEnumerator<Block> enumerator = blockManager.GetEnumerator();
          while (enumerator.MoveNext())
          {
            Block current = enumerator.Current;
            if (current.IsJsBlock && !intList.Contains(current.MsgIdHash))
              intList.Add(current.MsgIdHash);
          }
        }
      }
      List<Block> blockList = new List<Block>();
      foreach (string localeFileName in localeFileNames)
      {
        BlockManager blockManager = new BlockManager();
        blockManager.ReadFromFile(localeFileName);
        IEnumerator<Block> enumerator = blockManager.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Block current = enumerator.Current;
          if (current.IsJsBlock || intList.Contains(current.MsgIdHash))
            blockList.Add(current);
        }
      }
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        using (StreamWriter writer = new StreamWriter((Stream) memoryStream))
        {
          PoJsExtractor.WriteHeader((object) writer);
          foreach (Block b in blockList)
            PoJsExtractor.WriteBlock((object) writer, (object) b);
          writer.Flush();
          memoryStream.Seek(0L, SeekOrigin.Begin);
          using (StreamReader reader = new StreamReader((Stream) memoryStream))
            return new Gettext.Cs.PoParser().ParseIntoDictionary((TextReader) reader);
        }
      }
    }

    private static void WriteHeader(object writer)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PoJsExtractor.AMjJibGEqZZo7V9sP1ID(writer, PoJsExtractor.fYFcBLGERA4e1o8cf5jp(PoJsExtractor.Umvs09GEipkVWDH4Y3jW(--1867379187 ^ 1867401869), PoJsExtractor.Umvs09GEipkVWDH4Y3jW(236071375 ^ 236079857), PoJsExtractor.Umvs09GEipkVWDH4Y3jW(-649342099 - -1150814748 ^ 501465645)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void WriteBlock(object writer, object b)
    {
      int num1 = 1;
      List<string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((Block) b).MsgId.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
label_14:
            enumerator = ((Block) b).MsgStr.GetEnumerator();
            num1 = 3;
            continue;
          case 3:
            try
            {
label_19:
              if (enumerator.MoveNext())
                goto label_21;
              else
                goto label_20;
label_17:
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    goto label_21;
                  case 3:
                    goto label_19;
                  default:
                    PoJsExtractor.AMjJibGEqZZo7V9sP1ID(writer, PoJsExtractor.FfV9dQGEKZtcFMtmvupN((object) current, PoJsExtractor.Umvs09GEipkVWDH4Y3jW(1178210108 ^ 1178210456)));
                    num2 = 3;
                    continue;
                }
              }
label_20:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              goto label_17;
label_21:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
              {
                num2 = 0;
                goto label_17;
              }
              else
                goto label_17;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
            goto label_26;
          case 5:
label_13:
            ((TextWriter) writer).Write((string) PoJsExtractor.Umvs09GEipkVWDH4Y3jW(1178210108 ^ 1178210456));
            num1 = 4;
            continue;
          default:
            try
            {
label_7:
              if (enumerator.MoveNext())
                goto label_6;
              else
                goto label_8;
label_4:
              string current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_7;
                  case 2:
                    PoJsExtractor.AMjJibGEqZZo7V9sP1ID(writer, PoJsExtractor.FfV9dQGEKZtcFMtmvupN((object) current, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883346836)));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
                    continue;
                  case 3:
                    goto label_14;
                  default:
                    goto label_6;
                }
              }
label_6:
              current = enumerator.Current;
              num4 = 2;
              goto label_4;
label_8:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 0;
              goto label_4;
            }
            finally
            {
              enumerator.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
        }
      }
label_26:;
    }

    public PoJsExtractor()
    {
      PoJsExtractor.kVemddGEXdIWWh3qsCbc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Umvs09GEipkVWDH4Y3jW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fYFcBLGERA4e1o8cf5jp([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void AMjJibGEqZZo7V9sP1ID([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static bool t1ZPLIGEV9dv7UiO2R56() => PoJsExtractor.rgLXCPGEIj7kKVgkTisi == null;

    internal static PoJsExtractor wQfIOdGESRmFdasRlDHp() => PoJsExtractor.rgLXCPGEIj7kKVgkTisi;

    internal static object FfV9dQGEKZtcFMtmvupN([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void kVemddGEXdIWWh3qsCbc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

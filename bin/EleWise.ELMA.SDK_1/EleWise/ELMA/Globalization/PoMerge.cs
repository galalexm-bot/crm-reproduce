// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.PoMerge
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Слияние po файлов</summary>
  public class PoMerge
  {
    internal static PoMerge V4S1PoGou7sNjq30EFEp;

    /// <summary>Выполнить слияние po файлов</summary>
    /// <param name="sourcePath">Исходный каталог с ро файлами</param>
    /// <param name="targetPath">Целевой каталог с po файлами</param>
    /// <param name="doBackup">Следует ли делать резервную копию исходных po файлов</param>
    /// <param name="allowRemove">Следует ли удалять из исходного файла неиспользуемые ключи</param>
    public static void Merge(
      string sourcePath,
      string targetPath,
      bool doBackup = true,
      bool allowRemove = false)
    {
      int num1 = 19;
      while (true)
      {
        IEnumerator<string> enumerator1;
        Dictionary<string, string> dictionary;
        StreamWriter streamWriter;
        string backupPath;
        Dictionary<string, string>.Enumerator enumerator2;
        LocalizationFile localizationFile;
        PoMerge.MergeStatistics stats1;
        HashSet<PoLineDescriptor> allKeys;
        string str1;
        switch (num1)
        {
          case 1:
            try
            {
label_41:
              if (enumerator2.MoveNext())
                goto label_38;
              else
                goto label_42;
label_28:
              PoMerge.MergeStatistics stats2;
              string fileName;
              KeyValuePair<string, string> current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    fileName = (string) PoMerge.SGTtIIGoTkaeGFm1fS8E((object) current.Key);
                    num2 = 12;
                    continue;
                  case 2:
                    PoMerge.XPhnqZGo11vPNMM5eDB9((object) streamWriter, (object) "");
                    num2 = 4;
                    continue;
                  case 3:
                    if (!PoMerge.bsSkSJGoeuyNwyUE6C0P((object) stats2))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 8 : 11;
                      continue;
                    }
                    goto case 9;
                  case 4:
                    PoMerge.Write((object) streamWriter, PoMerge.E3RGDIGoiI3c5IVS0UCP(1232639661 >> 3 ^ 153922069));
                    num2 = 7;
                    continue;
                  case 5:
                    goto label_38;
                  case 6:
                    goto label_23;
                  case 7:
                    PoMerge.XPhnqZGo11vPNMM5eDB9((object) streamWriter, (object) "");
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 10 : 2;
                    continue;
                  case 8:
                    PoMerge.Write((object) streamWriter, (object) "");
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                    continue;
                  case 9:
                    PoMerge.xMjMjaGoPsX5uCmCABKb((object) stats1, (object) stats2);
                    num2 = 8;
                    continue;
                  case 10:
                  case 11:
                    goto label_41;
                  case 12:
                    stats2 = PoMerge.MergeFiles((object) current.Key, (object) current.Value, allowRemove, backupPath, allKeys, streamWriter);
                    num2 = 3;
                    continue;
                  default:
                    PoMerge.WriteStats((object) streamWriter, (object) stats2, fileName);
                    num2 = 2;
                    continue;
                }
              }
label_38:
              current = enumerator2.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
              {
                num2 = 1;
                goto label_28;
              }
              else
                goto label_28;
label_42:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 6 : 2;
              goto label_28;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 2:
            if (streamWriter != null)
            {
              num1 = 10;
              continue;
            }
            goto label_96;
          case 3:
            goto label_50;
          case 4:
            stats1 = new PoMerge.MergeStatistics();
            num1 = 26;
            continue;
          case 5:
label_51:
            localizationFile = (LocalizationFile) PoMerge.eLIjgjGo2jM8BoUZ2jsZ((object) localizationFile);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 9 : 21;
            continue;
          case 6:
            try
            {
label_5:
              if (PoMerge.SPAhVgGonOE4Ct96oTCp((object) enumerator1))
                goto label_7;
              else
                goto label_6;
label_3:
              string current;
              int num4;
              while (true)
              {
                string str2;
                string str3;
                switch (num4)
                {
                  case 1:
                  case 3:
                    goto label_5;
                  case 2:
                    goto label_21;
                  case 4:
                    str2 = (string) PoMerge.SGTtIIGoTkaeGFm1fS8E((object) current);
                    num4 = 6;
                    continue;
                  case 5:
                    dictionary.Add(current, str3);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 0;
                    continue;
                  case 6:
                    if (str2 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                      continue;
                    }
                    break;
                  case 7:
                    goto label_7;
                }
                str3 = (string) PoMerge.O8QbpqGoksQ3T1g8FNt4((object) targetPath, (object) str2);
                num4 = 5;
              }
label_6:
              num4 = 2;
              goto label_3;
label_7:
              current = enumerator1.Current;
              num4 = 4;
              goto label_3;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      PoMerge.uuyWbGGoO1DddwOmb1Tb((object) enumerator1);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
              }
label_17:;
            }
          case 7:
label_23:
            PoMerge.WriteStats((object) streamWriter, (object) stats1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
            continue;
          case 8:
            goto label_101;
          case 9:
            enumerator2 = dictionary.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 8 : 11;
            continue;
          case 10:
            streamWriter.Close();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 8 : 0;
            continue;
          case 11:
            try
            {
label_73:
              if (enumerator2.MoveNext())
                goto label_75;
              else
                goto label_74;
label_57:
              IEnumerator<PoLineDescriptor> enumerator3;
              KeyValuePair<string, string> current1;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_51;
                  case 2:
                    try
                    {
label_63:
                      if (PoMerge.SPAhVgGonOE4Ct96oTCp((object) enumerator3))
                        goto label_61;
                      else
                        goto label_64;
label_59:
                      PoLineDescriptor current2;
                      int num7;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            localizationFile.Resources.Add(current2);
                            num7 = 2;
                            continue;
                          case 2:
                            goto label_63;
                          case 3:
                            goto label_61;
                          default:
                            goto label_77;
                        }
                      }
label_61:
                      current2 = enumerator3.Current;
                      num7 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                      {
                        num7 = 0;
                        goto label_59;
                      }
                      else
                        goto label_59;
label_64:
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                      goto label_59;
                    }
                    finally
                    {
                      int num8;
                      if (enumerator3 == null)
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                      else
                        goto label_68;
label_67:
                      switch (num8)
                      {
                        case 2:
                          break;
                        default:
                      }
label_68:
                      PoMerge.uuyWbGGoO1DddwOmb1Tb((object) enumerator3);
                      num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                      {
                        num8 = 1;
                        goto label_67;
                      }
                      else
                        goto label_67;
                    }
                  case 3:
                  case 8:
                    goto label_73;
                  case 4:
label_77:
                    enumerator3 = new LocalizationFile(current1.Value).Resources.GetEnumerator();
                    num6 = 6;
                    continue;
                  case 5:
                    if (string.IsNullOrEmpty(current1.Key))
                    {
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 3;
                      continue;
                    }
                    goto case 7;
                  case 6:
                    goto label_78;
                  case 7:
                    enumerator3 = new LocalizationFile(current1.Key).Resources.GetEnumerator();
                    num6 = 2;
                    continue;
                  default:
                    goto label_75;
                }
              }
label_78:
              try
              {
label_83:
                if (PoMerge.SPAhVgGonOE4Ct96oTCp((object) enumerator3))
                  goto label_80;
                else
                  goto label_84;
label_79:
                PoLineDescriptor current3;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_80;
                    case 2:
                      goto label_73;
                    case 3:
                      goto label_83;
                    default:
                      localizationFile.Resources.Add(current3);
                      num9 = 3;
                      continue;
                  }
                }
label_80:
                current3 = enumerator3.Current;
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                {
                  num9 = 0;
                  goto label_79;
                }
                else
                  goto label_79;
label_84:
                num9 = 2;
                goto label_79;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                    num10 = 1;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        PoMerge.uuyWbGGoO1DddwOmb1Tb((object) enumerator3);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_91;
                    }
                  }
                }
label_91:;
              }
label_74:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              goto label_57;
label_75:
              current1 = enumerator2.Current;
              num6 = 5;
              goto label_57;
            }
            finally
            {
              enumerator2.Dispose();
              int num11 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                num11 = 0;
              switch (num11)
              {
                default:
              }
            }
          case 12:
            if (!doBackup)
            {
              num1 = 14;
              continue;
            }
            str1 = Path.Combine(targetPath, string.Format((string) PoMerge.E3RGDIGoiI3c5IVS0UCP(1113862659 ^ 1114081893), (object) PoMerge.DxcEsZGoR8HKOqN5KhSZ()));
            break;
          case 13:
          case 25:
            streamWriter = (StreamWriter) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 23;
            continue;
          case 14:
            str1 = (string) null;
            break;
          case 15:
            PoMerge.ENxFoHGoqsmDaYpU2adJ((object) backupPath);
            num1 = 25;
            continue;
          case 16:
            enumerator2 = dictionary.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
            continue;
          case 17:
            if (backupPath != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto case 13;
          case 18:
            if (PoMerge.EAlT0HGoSy3gTEjpPmFr((object) targetPath))
            {
              num1 = 12;
              continue;
            }
            goto label_89;
          case 19:
            if (PoMerge.EAlT0HGoSy3gTEjpPmFr((object) sourcePath))
            {
              num1 = 18;
              continue;
            }
            goto label_92;
          case 20:
label_21:
            localizationFile = new LocalizationFile();
            num1 = 9;
            continue;
          case 21:
            allKeys = new HashSet<PoLineDescriptor>((IEnumerable<PoLineDescriptor>) localizationFile.Resources);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 8 : 16;
            continue;
          case 22:
            streamWriter = new StreamWriter((string) PoMerge.fu8vTsGoKFAbGffcG5yg((object) backupPath, PoMerge.E3RGDIGoiI3c5IVS0UCP(-710283084 ^ -537863435 ^ 173708013)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 3;
            continue;
          case 23:
            if (backupPath != null)
            {
              num1 = 22;
              continue;
            }
            goto case 4;
          case 24:
            enumerator1 = ((IEnumerable<string>) PoMerge.SAoKd2GoXsdImLJkyIGS((object) sourcePath)).Where<string>((Func<string, bool>) (f =>
            {
              int num12 = 1;
              while (true)
              {
                switch (num12)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (PoMerge.\u003C\u003Ec.XSmtGrvddd8qlc2NFdYy((object) f, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021619431)))
                    {
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return !PoMerge.\u003C\u003Ec.XSmtGrvddd8qlc2NFdYy((object) f, PoMerge.\u003C\u003Ec.RW7fDJvdltZaZe4OwRXb(572119659 - -337058038 ^ 909452541));
label_3:
              return false;
            })).GetEnumerator();
            num1 = 6;
            continue;
          case 26:
            dictionary = new Dictionary<string, string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 24;
            continue;
          default:
            if (PoMerge.EAlT0HGoSy3gTEjpPmFr((object) backupPath))
            {
              num1 = 13;
              continue;
            }
            goto case 15;
        }
        backupPath = str1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 17 : 15;
      }
label_50:
      return;
label_101:
      return;
label_96:
      return;
label_92:
      return;
label_89:;
    }

    private static PoMerge.MergeStatistics MergeFiles(
      object sourcePath,
      object targetPath,
      bool allowRemove,
      string backupPath = null,
      HashSet<PoLineDescriptor> allKeys = null,
      StreamWriter log = null)
    {
      PoMerge.MergeStatistics mergeStatistics = new PoMerge.MergeStatistics();
      LocalizationFile localizationFile1 = PoMerge.RemoveDuplicatesFrom((object) new LocalizationFile((string) sourcePath));
      LocalizationFile localizationFile2 = PoMerge.RemoveDuplicatesFrom((object) new LocalizationFile((string) targetPath));
      if (!File.Exists((string) targetPath))
      {
        File.Copy((string) sourcePath, (string) targetPath, true);
        foreach (PoLineDescriptor resource in localizationFile1.Resources)
        {
          string sourceKey = resource.Key;
          PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479669592), (object) sourceKey));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          allKeys?.RemoveWhere((Predicate<PoLineDescriptor>) (k => PoMerge.\u003C\u003Ec__DisplayClass1_1.hJP89fvlFTGuXftbF4jm(PoMerge.\u003C\u003Ec__DisplayClass1_1.h9cyILvdzGwd5Tg5wkRe((object) k), (object) sourceKey)));
        }
        mergeStatistics.ValuesAdded += localizationFile1.Resources.Count;
        return mergeStatistics;
      }
      if (!string.IsNullOrEmpty(backupPath))
        File.Copy((string) targetPath, backupPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106521422) + Path.GetFileName((string) targetPath), true);
      LocalizationFile newTargetFile = new LocalizationFile()
      {
        Header = localizationFile2.Header ?? localizationFile1.Header,
        Name = localizationFile2.Name
      };
      foreach (PoLineDescriptor resource in localizationFile1.Resources)
      {
        PoLineDescriptor sourcePoLine = resource;
        string sourceKey = sourcePoLine.Key;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PoLineDescriptor poLineDescriptor1 = localizationFile2.Resources.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_3.vE0pG3vlCZqUsm7cLoZg(PoMerge.\u003C\u003Ec__DisplayClass1_3.mUEEhevlQW8kIvAiBpXr((object) l), (object) sourceKey)));
        if (poLineDescriptor1 == null)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          PoLineDescriptor poLineDescriptor2 = allKeys == null ? sourcePoLine : allKeys.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) l), (object) sourcePoLine.Key)));
          if (poLineDescriptor2 != null)
          {
            newTargetFile.Resources.Add(poLineDescriptor2);
            PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411292863), (object) sourceKey));
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            allKeys?.RemoveWhere((Predicate<PoLineDescriptor>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v((object) l.Key, PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) sourcePoLine))));
            ++mergeStatistics.ValuesAdded;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (allKeys == null || allKeys.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) l), PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) sourcePoLine)))) != null)
          {
            if (!string.IsNullOrEmpty(sourcePoLine.Value) && sourcePoLine.Value != poLineDescriptor1.Value)
            {
              PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979401013), (object) sourceKey));
              ++mergeStatistics.ValuesUpdated;
            }
            else
            {
              PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124677510), (object) sourceKey));
              ++mergeStatistics.ValuesRestored;
            }
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            PoLineDescriptor poLineDescriptor3 = allKeys == null ? sourcePoLine : allKeys.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) l), PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) sourcePoLine)))) ?? sourcePoLine;
            if (string.IsNullOrEmpty(poLineDescriptor3.Value))
              poLineDescriptor3.Value = poLineDescriptor1.Value;
            poLineDescriptor3.IsLow |= poLineDescriptor1.IsLow;
            newTargetFile.Resources.Add(poLineDescriptor3);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            allKeys?.RemoveWhere((Predicate<PoLineDescriptor>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) l), PoMerge.\u003C\u003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2((object) sourcePoLine))));
          }
        }
      }
      foreach (PoLineDescriptor poLineDescriptor in localizationFile2.Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (poLine =>
      {
        int num = 1;
        PoLineDescriptor poLine1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              poLine1 = poLine;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return newTargetFile.Resources.All<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (p => PoMerge.\u003C\u003Ec__DisplayClass1_4.WcAwlxvlVPHaAAOEJeS6((object) poLine1.Key, PoMerge.\u003C\u003Ec__DisplayClass1_4.zWOWlPvlIvel8QARFuQ5((object) p))));
      })).ToList<PoLineDescriptor>())
      {
        PoLineDescriptor targetPoLine = poLineDescriptor;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((allowRemove ? 1 : (allKeys == null ? 0 : (allKeys.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_5.Im3B9wvlXyMl8JSKAWwQ(PoMerge.\u003C\u003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF((object) l), PoMerge.\u003C\u003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF((object) targetPoLine)))) == null ? 1 : 0))) != 0)
        {
          PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234134010), (object) targetPoLine.Key));
          ++mergeStatistics.ValuesRemoved;
        }
        else
        {
          PoMerge.Write((object) log, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740496164), (object) targetPoLine.Key));
          newTargetFile.Resources.Add(targetPoLine);
          ++mergeStatistics.ValuesRestored;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          allKeys?.RemoveWhere((Predicate<PoLineDescriptor>) (l => PoMerge.\u003C\u003Ec__DisplayClass1_5.Im3B9wvlXyMl8JSKAWwQ(PoMerge.\u003C\u003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF((object) l), PoMerge.\u003C\u003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF((object) targetPoLine))));
        }
      }
      newTargetFile.SaveToFile();
      return mergeStatistics;
    }

    private static void Write(object sw, object msg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (sw == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            PoMerge.mq5PVHGoN5cJbGItnyp9(sw, msg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    private static void WriteStats(object sw, object stats, string fileName = null)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (PoMerge.Hlw1tWGo3dO6VMUEPxQn((object) fileName))
                break;
              goto label_8;
            case 3:
              str = EleWise.ELMA.SR.T((string) PoMerge.E3RGDIGoiI3c5IVS0UCP(92412609 - 1050237057 ^ -957645980), (object) ((PoMerge.MergeStatistics) stats).ValuesAdded, (object) ((PoMerge.MergeStatistics) stats).ValuesUpdated, (object) ((PoMerge.MergeStatistics) stats).ValuesRemoved, (object) ((PoMerge.MergeStatistics) stats).ValuesRestored);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 0;
              continue;
            case 4:
              str = EleWise.ELMA.SR.T((string) PoMerge.E3RGDIGoiI3c5IVS0UCP(~541731958 ^ -541693385), (object) ((PoMerge.MergeStatistics) stats).ValuesAdded, (object) ((PoMerge.MergeStatistics) stats).ValuesUpdated, (object) ((PoMerge.MergeStatistics) stats).ValuesRemoved, (object) ((PoMerge.MergeStatistics) stats).ValuesRestored, (object) fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
          }
          PoMerge.XPhnqZGo11vPNMM5eDB9(sw, (object) str);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
        }
label_8:
        num1 = 4;
      }
label_3:;
    }

    private static LocalizationFile RemoveDuplicatesFrom(object file)
    {
      int num1 = 4;
      LocalizationFile localizationFile1;
      IEnumerator<string> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_43;
          case 2:
            goto label_5;
          case 3:
            ConcurrentBag<PoLineDescriptor> resources = ((LocalizationFile) file).Resources;
            // ISSUE: reference to a compiler-generated field
            Func<PoLineDescriptor, string> func1 = PoMerge.\u003C\u003Ec.\u003C\u003E9__4_0;
            Func<PoLineDescriptor, string> keySelector;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              PoMerge.\u003C\u003Ec.\u003C\u003E9__4_0 = keySelector = (Func<PoLineDescriptor, string>) (r => (string) PoMerge.\u003C\u003Ec.emcQIpvdrsox3eiqta5L((object) r));
            }
            else
              goto label_53;
label_46:
            IEnumerable<IGrouping<string, PoLineDescriptor>> source1 = resources.GroupBy<PoLineDescriptor, string>(keySelector);
            IEnumerable<PoLineDescriptor> collection1 = source1.Where<IGrouping<string, PoLineDescriptor>>((Func<IGrouping<string, PoLineDescriptor>, bool>) (r => r.Count<PoLineDescriptor>() == 1)).SelectMany<IGrouping<string, PoLineDescriptor>, PoLineDescriptor>((Func<IGrouping<string, PoLineDescriptor>, IEnumerable<PoLineDescriptor>>) (g => (IEnumerable<PoLineDescriptor>) g));
            LocalizationFile localizationFile2 = new LocalizationFile();
            localizationFile2.Name = (string) PoMerge.iOnlqHGopHXr1xZ9uQKy(file);
            localizationFile2.Header = ((LocalizationFile) file).Header;
            PoMerge.QaCLQEGoDSOlgf55Uslj((object) localizationFile2, PoMerge.Et3xuWGoakYu6YFj35Yy(file));
            localizationFile2.Resources = new ConcurrentBag<PoLineDescriptor>(collection1);
            localizationFile1 = localizationFile2;
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, PoLineDescriptor>, bool> func2 = PoMerge.\u003C\u003Ec.\u003C\u003E9__4_3;
            Func<IGrouping<string, PoLineDescriptor>, bool> predicate1;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PoMerge.\u003C\u003Ec.\u003C\u003E9__4_3 = predicate1 = (Func<IGrouping<string, PoLineDescriptor>, bool>) (r => r.Count<PoLineDescriptor>() > 1);
            }
            else
              goto label_52;
label_48:
            IEnumerable<IGrouping<string, PoLineDescriptor>> source2 = source1.Where<IGrouping<string, PoLineDescriptor>>(predicate1);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, PoLineDescriptor>, string> func3 = PoMerge.\u003C\u003Ec.\u003C\u003E9__4_4;
            Func<IGrouping<string, PoLineDescriptor>, string> selector;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PoMerge.\u003C\u003Ec.\u003C\u003E9__4_4 = selector = (Func<IGrouping<string, PoLineDescriptor>, string>) (r => r.Key);
            }
            else
              goto label_51;
label_50:
            enumerator1 = source2.Select<IGrouping<string, PoLineDescriptor>, string>(selector).GetEnumerator();
            num1 = 2;
            continue;
label_51:
            selector = func3;
            goto label_50;
label_52:
            predicate1 = func2;
            goto label_48;
label_53:
            keySelector = func1;
            goto label_46;
          case 4:
            if (file != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 3;
              continue;
            }
            goto label_43;
          default:
            goto label_2;
        }
      }
label_2:
      return localizationFile1;
label_5:
      try
      {
label_7:
        if (enumerator1.MoveNext())
          goto label_34;
        else
          goto label_8;
label_6:
        bool flag;
        List<PoLineDescriptor>.Enumerator enumerator2;
        string current1;
        int num2;
        string key;
        PoLineDescriptor line;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              try
              {
label_24:
                if (enumerator2.MoveNext())
                  goto label_23;
                else
                  goto label_25;
label_10:
                PoLineDescriptor current2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      PoLineDescriptor poLineDescriptor = line;
                      PoMerge.Hhjr1xGo6RGKrSaRjATi((object) poLineDescriptor, PoMerge.EFQj0rGo4NEn1sEjvlhs((object) poLineDescriptor) | PoMerge.EFQj0rGo4NEn1sEjvlhs((object) current2));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 7 : 7;
                      continue;
                    case 2:
                      PoMerge.iPJDHOGo7LdQ37UCES91((object) line, true);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 6;
                      continue;
                    case 4:
                      goto label_32;
                    case 5:
                      if (PoMerge.GGufaGGoA71JM3Vj4cvy(PoMerge.IlPMSJGoHl6hNuIMkFUZ((object) line), PoMerge.IlPMSJGoHl6hNuIMkFUZ((object) current2)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 10;
                    case 7:
                      if (PoMerge.Hlw1tWGo3dO6VMUEPxQn(PoMerge.IlPMSJGoHl6hNuIMkFUZ((object) line)))
                      {
                        num3 = 12;
                        continue;
                      }
                      goto label_24;
                    case 8:
                      goto label_23;
                    case 9:
                      PoMerge.RFU5abGowHVAv3KaU7GC((object) line, PoMerge.IlPMSJGoHl6hNuIMkFUZ((object) current2));
                      num3 = 13;
                      continue;
                    case 10:
                      if (!flag)
                      {
                        num3 = 9;
                        continue;
                      }
                      goto case 2;
                    case 11:
                      List<string> comments1 = line.Comments;
                      List<string> comments2 = current2.Comments;
                      Func<string, bool> func;
                      Func<string, bool> func4 = func;
                      Func<string, bool> predicate2 = func4 == null ? (func = (Func<string, bool>) (r => !line.Comments.Contains(r))) : func4;
                      IEnumerable<string> collection2 = comments2.Where<string>(predicate2);
                      comments1.AddRange(collection2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                      continue;
                    case 12:
                      if (!string.IsNullOrEmpty(current2.Value))
                      {
                        num3 = 5;
                        continue;
                      }
                      goto label_24;
                    case 13:
                      flag = true;
                      num3 = 3;
                      continue;
                    default:
                      goto label_24;
                  }
                }
label_23:
                current2 = enumerator2.Current;
                num3 = 11;
                goto label_10;
label_25:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 2;
                goto label_10;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
              List<PoLineDescriptor> list = ((LocalizationFile) file).Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => r.Key == key)).ToList<PoLineDescriptor>();
              PoLineDescriptor poLineDescriptor1 = new PoLineDescriptor();
              PoMerge.P3N6xeGotXRma7lqbCVa((object) poLineDescriptor1, (object) key);
              poLineDescriptor1.IsFuzzy = false;
              PoMerge.RFU5abGowHVAv3KaU7GC((object) poLineDescriptor1, (object) string.Empty);
              line = poLineDescriptor1;
              flag = false;
              enumerator2 = list.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 2;
              continue;
            case 4:
              goto label_2;
            case 5:
label_32:
              localizationFile1.Resources.Add(line);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            case 6:
              key = current1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 2;
              continue;
            case 7:
              goto label_34;
            default:
              num2 = 6;
              continue;
          }
        }
label_8:
        num2 = 4;
        goto label_6;
label_34:
        current1 = enumerator1.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        int num5;
        if (enumerator1 == null)
          num5 = 2;
        else
          goto label_40;
label_39:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_40:
        PoMerge.uuyWbGGoO1DddwOmb1Tb((object) enumerator1);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        {
          num5 = 1;
          goto label_39;
        }
        else
          goto label_39;
      }
label_43:
      return new LocalizationFile();
    }

    public PoMerge()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EAlT0HGoSy3gTEjpPmFr([In] object obj0) => Directory.Exists((string) obj0);

    internal static object E3RGDIGoiI3c5IVS0UCP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime DxcEsZGoR8HKOqN5KhSZ() => DateTime.Now;

    internal static object ENxFoHGoqsmDaYpU2adJ([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object fu8vTsGoKFAbGffcG5yg([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object SAoKd2GoXsdImLJkyIGS([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static object SGTtIIGoTkaeGFm1fS8E([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object O8QbpqGoksQ3T1g8FNt4([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool SPAhVgGonOE4Ct96oTCp([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void uuyWbGGoO1DddwOmb1Tb([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object eLIjgjGo2jM8BoUZ2jsZ([In] object obj0) => (object) PoMerge.RemoveDuplicatesFrom(obj0);

    internal static bool bsSkSJGoeuyNwyUE6C0P([In] object obj0) => ((PoMerge.MergeStatistics) obj0).NotNull();

    internal static void xMjMjaGoPsX5uCmCABKb([In] object obj0, [In] object obj1) => ((PoMerge.MergeStatistics) obj0).UpdateFrom((PoMerge.MergeStatistics) obj1);

    internal static void XPhnqZGo11vPNMM5eDB9([In] object obj0, [In] object obj1) => PoMerge.Write(obj0, obj1);

    internal static bool NHf8bqGoIj4ouTKEnZcI() => PoMerge.V4S1PoGou7sNjq30EFEp == null;

    internal static PoMerge RZlCB2GoVFeBtnAVUlT8() => PoMerge.V4S1PoGou7sNjq30EFEp;

    internal static void mq5PVHGoN5cJbGItnyp9([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static bool Hlw1tWGo3dO6VMUEPxQn([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object iOnlqHGopHXr1xZ9uQKy([In] object obj0) => (object) ((LocalizationFile) obj0).Name;

    internal static object Et3xuWGoakYu6YFj35Yy([In] object obj0) => (object) ((LocalizationFile) obj0).LocalizationName;

    internal static void QaCLQEGoDSOlgf55Uslj([In] object obj0, [In] object obj1) => ((LocalizationFile) obj0).LocalizationName = (string) obj1;

    internal static void P3N6xeGotXRma7lqbCVa([In] object obj0, [In] object obj1) => ((PoLineDescriptor) obj0).Key = (string) obj1;

    internal static void RFU5abGowHVAv3KaU7GC([In] object obj0, [In] object obj1) => ((PoLineDescriptor) obj0).Value = (string) obj1;

    internal static bool EFQj0rGo4NEn1sEjvlhs([In] object obj0) => ((PoLineDescriptor) obj0).IsLow;

    internal static void Hhjr1xGo6RGKrSaRjATi([In] object obj0, bool value) => ((PoLineDescriptor) obj0).IsLow = value;

    internal static object IlPMSJGoHl6hNuIMkFUZ([In] object obj0) => (object) ((PoLineDescriptor) obj0).Value;

    internal static bool GGufaGGoA71JM3Vj4cvy([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void iPJDHOGo7LdQ37UCES91([In] object obj0, bool value) => ((PoLineDescriptor) obj0).IsFuzzy = value;

    private class MergeStatistics
    {
      public int ValuesAdded;
      public int ValuesRemoved;
      public int ValuesUpdated;
      public int ValuesRestored;
      internal static object xbvtkGvd7kuHeAgZNFnQ;

      public void UpdateFrom(PoMerge.MergeStatistics statistics)
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.ValuesAdded += statistics.ValuesAdded;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.ValuesRestored += statistics.ValuesRestored;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 2;
                continue;
              case 4:
                this.ValuesUpdated += statistics.ValuesUpdated;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          this.ValuesRemoved += statistics.ValuesRemoved;
          num1 = 4;
        }
label_3:;
      }

      public bool NotNull()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 3:
              goto label_9;
            case 2:
              if (this.ValuesAdded != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                continue;
              }
              goto case 4;
            case 4:
              if (this.ValuesRemoved != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 3;
                continue;
              }
              break;
            case 5:
              goto label_8;
          }
          if (this.ValuesUpdated == 0)
            num = 5;
          else
            goto label_9;
        }
label_8:
        return this.ValuesRestored != 0;
label_9:
        return true;
      }

      public MergeStatistics()
      {
        PoMerge.MergeStatistics.eJEdmuvdmjVppXQxMa0k();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool dY4XMavdxCVpX0uWalAu() => PoMerge.MergeStatistics.xbvtkGvd7kuHeAgZNFnQ == null;

      internal static PoMerge.MergeStatistics dvmYPSvd0PVSZOahGcDb() => (PoMerge.MergeStatistics) PoMerge.MergeStatistics.xbvtkGvd7kuHeAgZNFnQ;

      internal static void eJEdmuvdmjVppXQxMa0k() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationStatistic
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Статистика перевода</summary>
  [Serializable]
  public class LocalizationStatistic
  {
    internal static LocalizationStatistic VPj3V9GGLv5UPLiJuiUG;

    /// <summary>Ctor</summary>
    public LocalizationStatistic()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.TranslatedWordsByFile = new SerializableDictionary<string, long>();
            num1 = 13;
            continue;
          case 2:
            this.TranslatedByFile = new SerializableDictionary<string, long>();
            num2 = 3;
            break;
          case 3:
            this.FuzzyByFile = new SerializableDictionary<string, long>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 4:
            this.StringsByFile = new SerializableDictionary<string, long>();
            num1 = 2;
            continue;
          case 5:
            this.FuzzyCharsByFile = new SerializableDictionary<string, long>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 11;
            continue;
          case 6:
            this.CharsByFile = new SerializableDictionary<string, long>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
          case 7:
            this.WordsByFile = new SerializableDictionary<string, long>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 6 : 4;
            continue;
          case 8:
            this.FuzzyWordsByFile = new SerializableDictionary<string, long>();
            num1 = 5;
            continue;
          case 9:
            this.HighPriorityWordsByFile = new SerializableDictionary<string, long>();
            num1 = 10;
            continue;
          case 10:
            this.HighPriorityCharsByFile = new SerializableDictionary<string, long>();
            num1 = 12;
            continue;
          case 11:
            this.HighPriorityByFile = new SerializableDictionary<string, long>();
            num2 = 9;
            break;
          case 12:
            goto label_3;
          case 13:
            this.TranslatedCharsByFile = new SerializableDictionary<string, long>();
            num2 = 8;
            break;
          default:
            this.ProgressByFile = new SerializableDictionary<string, int>();
            num1 = 7;
            continue;
        }
        num1 = num2;
      }
label_3:;
    }

    /// <summary>Количество строк с высоким приоритетом</summary>
    public long TotalHighStrings
    {
      get => this.\u003CTotalHighStrings\u003Ek__BackingField;
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
              this.\u003CTotalHighStrings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Количество строк с высоким приоритетам по файлам</summary>
    public SerializableDictionary<string, long> HighPriorityByFile { get; set; }

    /// <summary>Количество слов с высоким приоритетом</summary>
    public long TotalHighWords
    {
      get => this.\u003CTotalHighWords\u003Ek__BackingField;
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
              this.\u003CTotalHighWords\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>Количество слов с высоким приоритетам по файлам</summary>
    public SerializableDictionary<string, long> HighPriorityWordsByFile { get; set; }

    /// <summary>Количество символов с высоким приоритетом</summary>
    public long TotalHighChars
    {
      get => this.\u003CTotalHighChars\u003Ek__BackingField;
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
              this.\u003CTotalHighChars\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Количество символов с высоким приоритетам по файлам</summary>
    public SerializableDictionary<string, long> HighPriorityCharsByFile { get; set; }

    /// <summary>Количество файлов</summary>
    public int Files
    {
      get => this.\u003CFiles\u003Ek__BackingField;
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
              this.\u003CFiles\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Количество строк по файлам</summary>
    public SerializableDictionary<string, long> StringsByFile { get; set; }

    /// <summary>Всего строк</summary>
    public long TotalStrings
    {
      get => this.\u003CTotalStrings\u003Ek__BackingField;
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
              this.\u003CTotalStrings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

    /// <summary>Количество слов по файлам</summary>
    public SerializableDictionary<string, long> WordsByFile { get; set; }

    /// <summary>Всего слов</summary>
    public long TotalWords
    {
      get => this.\u003CTotalWords\u003Ek__BackingField;
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
              this.\u003CTotalWords\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Количяество символов по файлам</summary>
    public SerializableDictionary<string, long> CharsByFile { get; set; }

    /// <summary>Всего символов</summary>
    public long TotalChars
    {
      get => this.\u003CTotalChars\u003Ek__BackingField;
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
              this.\u003CTotalChars\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>Переведено по файлам</summary>
    public SerializableDictionary<string, long> TranslatedByFile { get; set; }

    /// <summary>Всего строк</summary>
    public long Translated
    {
      get => this.\u003CTranslated\u003Ek__BackingField;
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
              this.\u003CTranslated\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    /// <summary>Переведено по файлам слов</summary>
    public SerializableDictionary<string, long> TranslatedWordsByFile { get; set; }

    /// <summary>Переведено слов</summary>
    public long TranslatedWords
    {
      get => this.\u003CTranslatedWords\u003Ek__BackingField;
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
              this.\u003CTranslatedWords\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

    /// <summary>Перведено символов по файлам</summary>
    public SerializableDictionary<string, long> TranslatedCharsByFile { get; set; }

    /// <summary>Переведено символов</summary>
    public long TranslatedChars
    {
      get => this.\u003CTranslatedChars\u003Ek__BackingField;
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
              this.\u003CTranslatedChars\u003Ek__BackingField = value;
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

    /// <summary>Неточно переведено по файлам</summary>
    public SerializableDictionary<string, long> FuzzyByFile { get; set; }

    /// <summary>Всего неточного перевода</summary>
    public long TotalFuzzy
    {
      get => this.\u003CTotalFuzzy\u003Ek__BackingField;
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
              this.\u003CTotalFuzzy\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>Неточно переведено слов</summary>
    public SerializableDictionary<string, long> FuzzyWordsByFile { get; set; }

    /// <summary>Всего слов переведенных неточно</summary>
    public long TotalFuzzyWords
    {
      get => this.\u003CTotalFuzzyWords\u003Ek__BackingField;
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
              this.\u003CTotalFuzzyWords\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    /// <summary>Неточно переведено символов по файлу</summary>
    public SerializableDictionary<string, long> FuzzyCharsByFile { get; set; }

    /// <summary>Неточно переведено символов всего</summary>
    public long TotalFuzzyChars
    {
      get => this.\u003CTotalFuzzyChars\u003Ek__BackingField;
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
              this.\u003CTotalFuzzyChars\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Прогресс по файлам</summary>
    public SerializableDictionary<string, int> ProgressByFile { get; set; }

    /// <summary>Общимй прогресс</summary>
    public int TotalProgress
    {
      get => this.\u003CTotalProgress\u003Ek__BackingField;
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
              this.\u003CTotalProgress\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Количество слов в строке</summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static long CountWords(string s)
    {
      int num = 1;
      char[] chArray1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!LocalizationStatistic.zqA8asGGcIHSDH3KvMf5((object) s))
            {
              char[] chArray2 = new char[3];
              // ISSUE: field reference
              LocalizationStatistic.KdrvneGGzKNRRaEfTWOk((object) chArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.E95A453653E06120FE9E373182096BDCF774C95B));
              chArray1 = chArray2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (long) LocalizationStatistic.Sdov0dGEFWVXJxRIGulA((object) s, (object) chArray1, StringSplitOptions.RemoveEmptyEntries).Length;
label_3:
      return 0;
    }

    /// <summary>Количество символов</summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static long CountChars(string s)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (s != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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
      return 0;
label_5:
      return (long) LocalizationStatistic.mMV9fDGEBQkwyHysYUeB((object) s);
    }

    /// <summary>Сохранить в xml</summary>
    /// <param name="fileName"></param>
    public void SaveToXml(string fileName)
    {
      int num1 = 1;
      XmlWriter xmlWriter;
      while (true)
      {
        switch (num1)
        {
          case 1:
            string str = fileName;
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            LocalizationStatistic.KeESxaGEWdvMYdDrYEgj((object) xmlWriterSettings, (object) Encoding.UTF8);
            LocalizationStatistic.RrouG4GEoSCrbW5UZRiJ((object) xmlWriterSettings, true);
            LocalizationStatistic.cm1ByGGEb83brqIeRfHO((object) xmlWriterSettings, true);
            LocalizationStatistic.rsIg80GEh1c10eEDO0u8((object) xmlWriterSettings, ConformanceLevel.Fragment);
            xmlWriter = (XmlWriter) LocalizationStatistic.FLtZvkGEGHipeR3ASV1M((object) str, (object) xmlWriterSettings);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_55;
          default:
            goto label_3;
        }
      }
label_55:
      return;
label_3:
      try
      {
        LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(-542721635 ^ -542832691));
        int num2 = 34;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859117281));
              num2 = 40;
              continue;
            case 2:
              xmlWriter.WriteEndElement();
              num2 = 31;
              continue;
            case 3:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 28 : 33;
              continue;
            case 4:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.Translated);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 2;
              continue;
            case 5:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalStrings);
              num2 = 3;
              continue;
            case 6:
              xmlWriter.WriteEndElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            case 7:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalHighStrings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 10;
              continue;
            case 8:
              xmlWriter.WriteEndElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 28 : 43;
              continue;
            case 9:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099749391));
              num2 = 13;
              continue;
            case 10:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
              continue;
            case 11:
              xmlWriter.WriteEndElement();
              num2 = 26;
              continue;
            case 12:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = 32;
              continue;
            case 13:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalWords);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 14:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 19 : 19;
              continue;
            case 15:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501244701));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 21 : 11;
              continue;
            case 16:
              xmlWriter.WriteValue(this.TotalFuzzyChars);
              num2 = 41;
              continue;
            case 17:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(864270449 << 6 ^ -521297210));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 15 : 16;
              continue;
            case 18:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(516838154 ^ 516812134));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 38 : 29;
              continue;
            case 19:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(2045296739 + 1688595713 ^ -561179664));
              num2 = 20;
              continue;
            case 20:
              xmlWriter.WriteValue(this.TotalHighWords);
              num2 = 28;
              continue;
            case 21:
              xmlWriter.WriteValue(this.TotalHighChars);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 36 : 36;
              continue;
            case 22:
              xmlWriter.WriteEndElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 39 : 13;
              continue;
            case 23:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35992715));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 5 : 5;
              continue;
            case 24:
              xmlWriter.WriteEndElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 35 : 23;
              continue;
            case 25:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalFuzzyWords);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 14 : 13;
              continue;
            case 26:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(-1217523399 ^ -1217548353));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 9 : 25;
              continue;
            case 27:
              xmlWriter.WriteEndElement();
              num3 = 17;
              break;
            case 28:
              xmlWriter.WriteEndElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 6;
              continue;
            case 29:
              goto label_50;
            case 30:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TranslatedChars);
              num2 = 27;
              continue;
            case 31:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(-2106517564 ^ -2106414732));
              num2 = 9;
              continue;
            case 32:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 29;
              continue;
            case 33:
              xmlWriter.WriteStartElement((string) LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(647913418 ^ 647881126));
              num3 = 4;
              break;
            case 34:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(1470998129 - 231418599 ^ 1239533012));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 23 : 5;
              continue;
            case 35:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(-1146510045 ^ -1146479793));
              num2 = 30;
              continue;
            case 36:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num3 = 12;
              break;
            case 37:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalFuzzy);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 22 : 8;
              continue;
            case 38:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TranslatedWords);
              num2 = 11;
              continue;
            case 39:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, LocalizationStatistic.zYnoWwGEEuqDWD1L3tHA(-1837662597 ^ -1837842193));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 7;
              continue;
            case 40:
              LocalizationStatistic.G1NwOLGEfV8xiQtinO75((object) xmlWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488879763));
              num2 = 42;
              continue;
            case 41:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = 15;
              continue;
            case 42:
              LocalizationStatistic.VdvvfVGEQZ0yxSKyE1Rv((object) xmlWriter, this.TotalChars);
              num3 = 24;
              break;
            case 43:
              xmlWriter.WriteStartElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333562516));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 37 : 34;
              continue;
            default:
              LocalizationStatistic.VkUOWLGECtrxXCewU5s4((object) xmlWriter);
              num2 = 18;
              continue;
          }
          num2 = num3;
        }
label_50:;
      }
      finally
      {
        if (xmlWriter != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                xmlWriter.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              default:
                goto label_57;
            }
          }
        }
label_57:;
      }
    }

    internal static bool fDcnMvGGUDqDMmLfOCKl() => LocalizationStatistic.VPj3V9GGLv5UPLiJuiUG == null;

    internal static LocalizationStatistic IqX3XOGGswNpoNCWhyAb() => LocalizationStatistic.VPj3V9GGLv5UPLiJuiUG;

    internal static bool zqA8asGGcIHSDH3KvMf5([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void KdrvneGGzKNRRaEfTWOk([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static object Sdov0dGEFWVXJxRIGulA([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static int mMV9fDGEBQkwyHysYUeB([In] object obj0) => ((string) obj0).Length;

    internal static void KeESxaGEWdvMYdDrYEgj([In] object obj0, [In] object obj1) => ((XmlWriterSettings) obj0).Encoding = (Encoding) obj1;

    internal static void RrouG4GEoSCrbW5UZRiJ([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).CloseOutput = obj1;

    internal static void cm1ByGGEb83brqIeRfHO([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).Indent = obj1;

    internal static void rsIg80GEh1c10eEDO0u8([In] object obj0, [In] ConformanceLevel obj1) => ((XmlWriterSettings) obj0).ConformanceLevel = obj1;

    internal static object FLtZvkGEGHipeR3ASV1M([In] object obj0, [In] object obj1) => (object) XmlWriter.Create((string) obj0, (XmlWriterSettings) obj1);

    internal static object zYnoWwGEEuqDWD1L3tHA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void G1NwOLGEfV8xiQtinO75([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void VdvvfVGEQZ0yxSKyE1Rv([In] object obj0, [In] long obj1) => ((XmlWriter) obj0).WriteValue(obj1);

    internal static void VkUOWLGECtrxXCewU5s4([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();
  }
}

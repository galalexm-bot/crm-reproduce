// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.PoParser
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Parses standard po files.</summary>
  public class PoParser
  {
    internal static PoParser BfAjtuGEJInu5nSfk5lD;

    /// <summary>Parses an input po file.</summary>
    public static Tuple<List<string>, List<PoLineDescriptor>> Parse(TextReader reader)
    {
      List<string> stringList = new List<string>();
      List<PoLineDescriptor> poLineDescriptorList = new List<PoLineDescriptor>();
      int num1 = 1;
      StringBuilder stringBuilder1 = (StringBuilder) null;
      StringBuilder stringBuilder2 = (StringBuilder) null;
      bool flag1 = false;
      bool flag2 = false;
      List<string> collection = new List<string>();
      string str1 = reader.ReadLine();
      string str2 = str1 == null ? (string) null : str1.Trim();
      if (str2 != null && str2.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97865956)))
      {
        do
        {
          stringList.Add(str2);
          string str3 = reader.ReadLine();
          str2 = str3 == null ? (string) null : str3.Trim();
        }
        while (!string.IsNullOrEmpty(str2) && !str2.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323238764)) && !str2.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675303787)));
      }
      while (true)
      {
        string str4;
        do
        {
          do
          {
            string str5;
            do
            {
              string str6 = reader.ReadLine();
              str5 = str6 == null ? (string) null : str6.Trim();
              if (string.IsNullOrEmpty(str5))
              {
                if (num1 == 3 && stringBuilder1 != null && stringBuilder2 != null)
                {
                  PoLineDescriptor poLineDescriptor = new PoLineDescriptor()
                  {
                    Key = stringBuilder1.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957817578), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61196875)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239573740), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411201529)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138035567), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461632705)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786881690), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199940475)),
                    Value = stringBuilder2.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477138292), z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874004977)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124636136), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539362789)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293918602), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218489610)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345419030), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882127340)),
                    IsFuzzy = flag1,
                    IsLow = flag2
                  };
                  poLineDescriptor.Comments.AddRange((IEnumerable<string>) collection);
                  poLineDescriptorList.Add(poLineDescriptor);
                  stringBuilder1 = (StringBuilder) null;
                  stringBuilder2 = (StringBuilder) null;
                  flag1 = false;
                  flag2 = false;
                  collection = new List<string>();
                }
                if (str5 != null)
                  num1 = 1;
                else
                  goto label_29;
              }
              else
              {
                if (str5.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993334399)))
                {
                  if (str5.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218731468)))
                    flag1 = true;
                  else if (str5.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146480035)))
                    flag2 = true;
                }
                else if (str5[0] == '#')
                {
                  collection.Add(str5);
                  continue;
                }
                bool flag3 = str5.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289869516));
                bool flag4 = !flag3 && str5.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088261040));
                if (flag3 | flag4)
                {
                  num1 = flag3 ? 2 : 3;
                  int num2 = str5.IndexOf('"');
                  if (num2 != -1)
                  {
                    int num3 = str5.IndexOf('"', num2 + 1);
                    while (num3 != -1 && str5[num3 - 1] == '\\')
                      num3 = str5.IndexOf('"', num3 + 1);
                    if (num3 != -1)
                    {
                      string str7 = str5.Substring(num2 + 1, num3 - num2 - 1);
                      if (flag3)
                      {
                        stringBuilder1 = new StringBuilder();
                        stringBuilder1.Append(str7);
                      }
                      else
                      {
                        stringBuilder2 = new StringBuilder();
                        stringBuilder2.Append(str7);
                      }
                    }
                  }
                }
              }
            }
            while (str5[0] != '"' || str5.Length == 1);
            str4 = str5[str5.Length - 1] == '"' ? str5.Substring(1, str5.Length - 2) : str5.Substring(1, str5.Length - 1);
            switch (num1)
            {
              case 2:
                continue;
              case 3:
                goto label_27;
              default:
                continue;
            }
          }
          while (stringBuilder1 == null);
          stringBuilder1.Append(str4);
          continue;
label_27:;
        }
        while (stringBuilder2 == null);
        stringBuilder2.Append(str4);
      }
label_29:
      return new Tuple<List<string>, List<PoLineDescriptor>>(stringList, poLineDescriptorList);
    }

    /// <summary>Parses an input po file.</summary>
    public static Tuple<List<string>, List<PoLineDescriptor>> Parse(string text) => PoParser.Parse((TextReader) new StringReader(text));

    public PoParser()
    {
      PoParser.XZNZ7FGEl4NZOfbPhvBe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void XZNZ7FGEl4NZOfbPhvBe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jqYhJcGE9sHT9HEqaewC() => PoParser.BfAjtuGEJInu5nSfk5lD == null;

    internal static PoParser zsAfynGEdQKIZXd5gExq() => PoParser.BfAjtuGEJInu5nSfk5lD;
  }
}

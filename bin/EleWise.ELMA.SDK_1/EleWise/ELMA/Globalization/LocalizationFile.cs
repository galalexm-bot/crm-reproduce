// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationFile
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Файл локализации</summary>
  [Serializable]
  public class LocalizationFile
  {
    internal static LocalizationFile LRsI8AGGeoe2iQ6kxRFy;

    /// <summary>Ctor</summary>
    public LocalizationFile()
    {
      LocalizationFile.z9kDU6GGNLKknp1odIOy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Resources = new ConcurrentBag<PoLineDescriptor>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    public LocalizationFile(string fileName)
    {
      LocalizationFile.z9kDU6GGNLKknp1odIOy();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num1 = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num1 = 3;
      StreamReader reader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_19;
          case 2:
            goto label_7;
          case 3:
            this.Name = fileName;
            num1 = 4;
            continue;
          case 4:
            if (LocalizationFile.Lx4qvCGG3CINUfx7aDgi((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_17;
          default:
            reader = (StreamReader) LocalizationFile.Q23dj5GGpqaK6o4bHTfc((object) fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 2;
            continue;
        }
      }
label_19:
      return;
label_17:
      return;
label_7:
      try
      {
        Tuple<List<string>, List<PoLineDescriptor>> tuple = PoParser.Parse((TextReader) reader);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_13;
            case 1:
              this.Header = tuple.Item1;
              num2 = 2;
              continue;
            case 2:
              this.Resources = new ConcurrentBag<PoLineDescriptor>((IEnumerable<PoLineDescriptor>) tuple.Item2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_13:
        return;
label_10:;
      }
      finally
      {
        int num3;
        if (reader == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
        else
          goto label_18;
label_16:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_18:
        LocalizationFile.xd775TGGaPfsfq7WpDPt((object) reader);
        num3 = 2;
        goto label_16;
      }
    }

    /// <summary>Название</summary>
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

    /// <summary>Заголовок</summary>
    public List<string> Header { get; set; }

    /// <summary>Имя локализации</summary>
    public string LocalizationName
    {
      get => this.\u003CLocalizationName\u003Ek__BackingField;
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
              this.\u003CLocalizationName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    /// <summary>Ресурсы</summary>
    public ConcurrentBag<PoLineDescriptor> Resources { get; set; }

    /// <summary>Сохранить</summary>
    /// <param name="dir"></param>
    public void SaveToFile(string dir = null)
    {
      int num1 = 12;
      while (true)
      {
        string path1;
        StreamWriter streamWriter;
        string path2;
        bool flag;
        object obj;
        switch (num1)
        {
          case 0:
            goto label_54;
          case 1:
label_52:
            if (!flag)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            File.Delete(path1);
            num1 = 9;
            continue;
          case 3:
            goto label_45;
          case 4:
            streamWriter = new StreamWriter(path2, false, (Encoding) EncodingCache.UTF8WithoutEmitIdentifier);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 11 : 13;
            continue;
          case 5:
            if (flag)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 6;
              continue;
            }
            goto case 4;
          case 6:
            path2 += z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909217975);
            num1 = 4;
            continue;
          case 7:
            path1 = path2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 8 : 5;
            continue;
          case 8:
            flag = LocalizationFile.Lx4qvCGG3CINUfx7aDgi((object) path2);
            num1 = 5;
            continue;
          case 9:
            LocalizationFile.TUw7TWGGAceOxRQQjOVU((object) path2, (object) path1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 3 : 2;
            continue;
          case 10:
            obj = LocalizationFile.jnGxvXGGDsWs6DOUmuiP((object) dir, (object) this.Name);
            break;
          case 11:
            obj = (object) this.Name;
            break;
          case 12:
            if (dir == null)
            {
              num1 = 11;
              continue;
            }
            goto case 10;
          case 13:
            try
            {
              int num2;
              if (this.Header != null)
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              else
                goto label_22;
label_7:
              List<string>.Enumerator enumerator1;
              IEnumerator<PoLineDescriptor> enumerator2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_24;
                  case 2:
                  case 5:
                    enumerator2 = this.Resources.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
                    continue;
                  case 3:
label_8:
                    streamWriter.WriteLine("");
                    num2 = 2;
                    continue;
                  case 4:
                    goto label_22;
                  case 6:
                    try
                    {
label_14:
                      if (enumerator1.MoveNext())
                        goto label_12;
                      else
                        goto label_15;
label_11:
                      string current;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            goto label_12;
                          case 2:
                            goto label_8;
                          case 3:
                            goto label_14;
                          default:
                            streamWriter.WriteLine(current);
                            num3 = 3;
                            continue;
                        }
                      }
label_12:
                      current = enumerator1.Current;
                      num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                      {
                        num3 = 0;
                        goto label_11;
                      }
                      else
                        goto label_11;
label_15:
                      num3 = 2;
                      goto label_11;
                    }
                    finally
                    {
                      enumerator1.Dispose();
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                      }
                    }
                  default:
                    enumerator1 = this.Header.GetEnumerator();
                    num2 = 6;
                    continue;
                }
              }
label_24:
              try
              {
label_28:
                if (enumerator2.MoveNext())
                  goto label_26;
                else
                  goto label_29;
label_25:
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_26;
                    case 2:
                      LocalizationFile.V49FLgGGHQawM1Uht4ny((object) streamWriter, (object) "");
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_52;
                    default:
                      goto label_28;
                  }
                }
label_26:
                LocalizationFile.XtjtN9GG61SxGga1TH2R((object) enumerator2.Current, (object) streamWriter);
                num5 = 2;
                goto label_25;
label_29:
                num5 = 3;
                goto label_25;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        LocalizationFile.xd775TGGaPfsfq7WpDPt((object) enumerator2);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_35;
                    }
                  }
                }
label_35:;
              }
label_22:
              LocalizationFile.Xp430iGG46I2Jkmw2Vr5((object) streamWriter, LocalizationFile.MbnZ9KGGwBKraLWVUQDu((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756892736), LocalizationFile.C3qxvfGGtwAkkKWS3cUn(-1998538950 ^ -1998531580), LocalizationFile.C3qxvfGGtwAkkKWS3cUn(-420743386 ^ -420747134)));
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
              {
                num2 = 5;
                goto label_7;
              }
              else
                goto label_7;
            }
            finally
            {
              if (streamWriter != null)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_42;
                    default:
                      LocalizationFile.xd775TGGaPfsfq7WpDPt((object) streamWriter);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_42:;
            }
          default:
            goto label_40;
        }
        path2 = (string) obj;
        num1 = 7;
      }
label_54:
      return;
label_45:
      return;
label_40:;
    }

    /// <summary>Отфильтровать ресурсы</summary>
    public static List<PoLineDescriptor> ApplyFilter(
      IEnumerable<PoLineDescriptor> res,
      PoLineFilter filter)
    {
      if (res == null)
        return new List<PoLineDescriptor>();
      if (filter.Fuzzy)
      {
        // ISSUE: reference to a compiler-generated method
        res = res.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => LocalizationFile.\u003C\u003Ec.LHfgpEvgZmEVKqlusYDt((object) r)));
      }
      if (filter.HighPriority)
        res = res.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => !r.IsLow));
      if (filter.LowPriority)
      {
        // ISSUE: reference to a compiler-generated method
        res = res.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => LocalizationFile.\u003C\u003Ec.EgoTrNvgueaXVC5wWPoE((object) r)));
      }
      if (filter.Untranslated)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        res = res.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => LocalizationFile.\u003C\u003Ec.U1cce6vgVVfLOjwF4Zl2(LocalizationFile.\u003C\u003Ec.lK39ncvgIYFdRB6ppaM2((object) r))));
      }
      if (!string.IsNullOrEmpty(filter.SearchString))
        res = res.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_4;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (LocalizationFile.\u003C\u003Ec__DisplayClass19_0.cemlQJvgEFhAwyfroOra(LocalizationFile.\u003C\u003Ec__DisplayClass19_0.qgIExhvghMt9pbsHwNtw((object) r), LocalizationFile.\u003C\u003Ec__DisplayClass19_0.G9XEyRvgGknHnTxBuANE((object) filter), StringComparison.OrdinalIgnoreCase) >= 0)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                  continue;
                }
                break;
              case 3:
                goto label_2;
              case 4:
                goto label_3;
            }
            // ISSUE: reference to a compiler-generated method
            if (LocalizationFile.\u003C\u003Ec__DisplayClass19_0.LsVM1Mvgf6TrVPpULHnQ((object) r) == null)
              num = 4;
            else
              break;
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return LocalizationFile.\u003C\u003Ec__DisplayClass19_0.cemlQJvgEFhAwyfroOra(LocalizationFile.\u003C\u003Ec__DisplayClass19_0.LsVM1Mvgf6TrVPpULHnQ((object) r), LocalizationFile.\u003C\u003Ec__DisplayClass19_0.G9XEyRvgGknHnTxBuANE((object) filter), StringComparison.OrdinalIgnoreCase) >= 0;
label_3:
          return false;
label_4:
          return true;
        }));
      return res.ToList<PoLineDescriptor>();
    }

    /// <summary>Количество ресурсов, по условию</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public long Count(PoLineFilter filter) => (long) LocalizationFile.ApplyFilter((IEnumerable<PoLineDescriptor>) this.Resources.Select<PoLineDescriptor, PoLineDescriptor>((Func<PoLineDescriptor, PoLineDescriptor>) (r => r)).ToList<PoLineDescriptor>(), filter).Count;

    /// <summary>Вернуть ресурсы, удовлетворяющие условию</summary>
    /// <param name="options"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<PoLineDescriptor> Find(FetchOptions options, PoLineFilter filter)
    {
      List<PoLineDescriptor> list1 = this.Resources.Select<PoLineDescriptor, PoLineDescriptor>((Func<PoLineDescriptor, PoLineDescriptor>) (r => r)).ToList<PoLineDescriptor>();
      if (options != (FetchOptions) null && !string.IsNullOrEmpty(options.SortExpression))
      {
        string sortExpression = options.SortExpression;
        if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420785812)))
        {
          if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538542526))
          {
            // ISSUE: reference to a compiler-generated method
            list1 = (options.SortDirection == ListSortDirection.Descending ? (IEnumerable<PoLineDescriptor>) list1.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => r.Value)) : (IEnumerable<PoLineDescriptor>) list1.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationFile.\u003C\u003Ec.lK39ncvgIYFdRB6ppaM2((object) r)))).ToList<PoLineDescriptor>();
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          list1 = (options.SortDirection == ListSortDirection.Ascending ? (IEnumerable<PoLineDescriptor>) list1.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => r.Key)) : (IEnumerable<PoLineDescriptor>) list1.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationFile.\u003C\u003Ec.pDFMqQvgSoIFG6d6VgZu((object) r)))).ToList<PoLineDescriptor>();
        }
      }
      List<PoLineDescriptor> source = LocalizationFile.ApplyFilter((IEnumerable<PoLineDescriptor>) list1, filter);
      if (options != (FetchOptions) null)
      {
        List<PoLineDescriptor> list2 = source.ToList<PoLineDescriptor>();
        source = options.FirstResult + options.MaxResults >= list2.Count ? list2.GetRange(options.FirstResult, list2.Count - options.FirstResult) : list2.GetRange(options.FirstResult, options.MaxResults);
      }
      return source;
    }

    /// <summary>Поиск ресурсов по набору слов</summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public List<PoLineDescriptor> FindByWords(List<List<string>> words, bool containsMode)
    {
      Func<List<string>, List<string>, bool> compareFunc = (Func<List<string>, List<string>, bool>) null;
      compareFunc = !containsMode ? (Func<List<string>, List<string>, bool>) ((list, wd) => wd.All<string>((Func<string, bool>) (w =>
      {
        int num = 1;
        string w1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              w1 = w;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return list.Any<string>((Func<string, bool>) (kw => LocalizationFile.\u003C\u003Ec__DisplayClass22_4.k8XrD9vgw1oSo9XvCBnt((object) kw, (object) w1, StringComparison.OrdinalIgnoreCase)));
      }))) : (Func<List<string>, List<string>, bool>) ((list, wd) => wd.Any<string>((Func<string, bool>) (w =>
      {
        int num = 2;
        string w2;
        while (true)
        {
          switch (num)
          {
            case 1:
              w2 = w;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return list.Any<string>((Func<string, bool>) (kw => LocalizationFile.\u003C\u003Ec__DisplayClass22_2.VwDbsEvgPOYRqkDVORCE((object) kw, (object) w2, StringComparison.OrdinalIgnoreCase) >= 0));
      })));
      Func<List<string>, bool> checkFuncOr = (Func<List<string>, bool>) (list => words.Any<List<string>>((Func<List<string>, bool>) (wd => compareFunc(list, wd))));
      return this.Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (checkFuncOr(r.KeyWords))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return checkFuncOr(r.ValueWords);
label_3:
        return true;
      })).ToList<PoLineDescriptor>();
    }

    /// <summary>Override</summary>
    /// <returns></returns>
    public override string ToString()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (LocalizationFile.DLKBu3GG7b2YnPQQvf98((object) this.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) LocalizationFile.rSJMkmGGxbUPd4gJXxyo((object) this);
label_3:
      return this.Name;
    }

    internal static void z9kDU6GGNLKknp1odIOy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pTUW2NGGPCxwXsCPZ4mN() => LocalizationFile.LRsI8AGGeoe2iQ6kxRFy == null;

    internal static LocalizationFile y2VLxVGG1CBWEigbfoco() => LocalizationFile.LRsI8AGGeoe2iQ6kxRFy;

    internal static bool Lx4qvCGG3CINUfx7aDgi([In] object obj0) => File.Exists((string) obj0);

    internal static object Q23dj5GGpqaK6o4bHTfc([In] object obj0) => (object) File.OpenText((string) obj0);

    internal static void xd775TGGaPfsfq7WpDPt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object jnGxvXGGDsWs6DOUmuiP([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object C3qxvfGGtwAkkKWS3cUn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MbnZ9KGGwBKraLWVUQDu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void Xp430iGG46I2Jkmw2Vr5([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void XtjtN9GG61SxGga1TH2R([In] object obj0, [In] object obj1) => ((PoLineDescriptor) obj0).WriteToFile((StreamWriter) obj1);

    internal static void V49FLgGGHQawM1Uht4ny([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void TUw7TWGGAceOxRQQjOVU([In] object obj0, [In] object obj1) => File.Move((string) obj0, (string) obj1);

    internal static bool DLKBu3GG7b2YnPQQvf98([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object rSJMkmGGxbUPd4gJXxyo([In] object obj0) => (object) __nonvirtual (obj0.ToString());
  }
}

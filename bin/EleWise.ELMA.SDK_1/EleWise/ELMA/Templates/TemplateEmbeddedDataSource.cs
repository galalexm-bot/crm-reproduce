// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateEmbeddedDataSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates
{
  [Component]
  public abstract class TemplateEmbeddedDataSource : ITemplateDataSource
  {
    private static List<string> templateExtList;
    internal static TemplateEmbeddedDataSource ThyjesB1SHrDXghsPfIj;

    private bool IsTemplate(string fileName)
    {
      int num1 = 2;
      List<string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            enumerator = TemplateEmbeddedDataSource.templateExtList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_5:
      bool flag;
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_12;
label_6:
        string current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              goto label_11;
            case 2:
              goto label_10;
            case 3:
              goto label_2;
            case 5:
              if (!TemplateEmbeddedDataSource.Gfa1LcB1qmKuYo9yHR6i((object) fileName, (object) current))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
                continue;
              }
              break;
            case 6:
              goto label_3;
          }
          flag = true;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 6 : 0;
        }
label_10:
        current = enumerator.Current;
        num2 = 5;
        goto label_6;
label_12:
        num2 = 3;
        goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_3:
      return flag;
    }

    public IEnumerable<TemplateFileInfo> GetFiles()
    {
      string ns = this.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654299549);
      Assembly assembly = this.GetType().Assembly;
      IEnumerable<string> strings = ((IEnumerable<string>) assembly.GetManifestResourceNames()).Where<string>((Func<string, bool>) (n =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (!TemplateEmbeddedDataSource.\u003C\u003Ec__DisplayClass2_0.MENt0JQq56DMLWylvApo((object) n, (object) ns))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return this.IsTemplate(n);
label_3:
        return false;
      }));
      List<TemplateFileInfo> files = new List<TemplateFileInfo>();
      foreach (string str in strings)
      {
        string withoutExtension = Path.GetFileNameWithoutExtension(str.Substring(ns.Length));
        string extension = Path.GetExtension(str.Substring(ns.Length));
        TemplateFileInfo templateFileInfo = new TemplateFileInfo()
        {
          Assembly = assembly,
          FullName = str,
          Name = withoutExtension,
          Extension = extension
        };
        files.Add(templateFileInfo);
      }
      foreach (CultureInfo cultureName in EleWise.ELMA.SR.GetCultureNames())
      {
        if (!cultureName.Name.Equals(EleWise.ELMA.SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase))
        {
          string path = Path.Combine(EleWise.ELMA.SR.GetCultureDir(cultureName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710575994));
          if (Directory.Exists(path))
          {
            foreach (string file in Directory.GetFiles(path))
            {
              string withoutExtension = Path.GetFileNameWithoutExtension(file);
              string extension = Path.GetExtension(file);
              TemplateFileInfo templateFileInfo = new TemplateFileInfo()
              {
                Name = withoutExtension,
                Extension = extension,
                FullPath = file,
                CultureName = cultureName.Name
              };
              files.Add(templateFileInfo);
            }
          }
        }
      }
      return (IEnumerable<TemplateFileInfo>) files;
    }

    /// <summary>
    /// Пространство имен, в котором нужно искать шаблоны. По умолчанию используется пространство имен текущего класса.
    /// </summary>
    protected virtual string Namespace => TemplateEmbeddedDataSource.uhUlLXB1K7WqRw4eBDeh((object) this).Namespace;

    protected TemplateEmbeddedDataSource()
    {
      TemplateEmbeddedDataSource.dxU6CWB1Xt1IvGZADPA7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TemplateEmbeddedDataSource()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TemplateEmbeddedDataSource.templateExtList = new List<string>()
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319370904),
              (string) TemplateEmbeddedDataSource.deAKdfB1TpYnuHYFLCdb(979449278 ^ 979399950),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710493580),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459508245),
              (string) TemplateEmbeddedDataSource.deAKdfB1TpYnuHYFLCdb(589593376 ^ -1977315327 ^ -1459508231),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333771356)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool Gfa1LcB1qmKuYo9yHR6i([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static bool UJInvXB1imEIbknyuCOg() => TemplateEmbeddedDataSource.ThyjesB1SHrDXghsPfIj == null;

    internal static TemplateEmbeddedDataSource xlly6HB1RLgxi19cjDrD() => TemplateEmbeddedDataSource.ThyjesB1SHrDXghsPfIj;

    internal static Type uhUlLXB1K7WqRw4eBDeh([In] object obj0) => obj0.GetType();

    internal static void dxU6CWB1Xt1IvGZADPA7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object deAKdfB1TpYnuHYFLCdb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.DirectoryHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public class DirectoryHelper
  {
    private static DirectoryHelper URsyBkhz89I2BiNgTlj2;

    public static void Copy(string sourceDirectory, string targetDirectory)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DirectoryHelper.Copy(sourceDirectory, targetDirectory, (Func<FileInfo, string, bool>) ((info, s) => false));
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

    public static void Copy(
      string sourceDirectory,
      string targetDirectory,
      Func<FileInfo, string, bool> skipCopy)
    {
      DirectoryHelper.CopyAll(new DirectoryInfo(sourceDirectory), new DirectoryInfo(targetDirectory), skipCopy);
    }

    /// <summary>
    /// Скопировать содержимрое директории
    /// Код взят отсюда http://stackoverflow.com/questions/58744/best-way-to-copy-the-entire-contents-of-a-directory-in-c
    /// </summary>
    /// <param name="source"></param>
    /// <param name="target"></param>
    public static void CopyAll(
      DirectoryInfo source,
      DirectoryInfo target,
      Func<FileInfo, string, bool> skipCopy)
    {
      if (!Directory.Exists(target.FullName))
        Directory.CreateDirectory(target.FullName);
      string path1 = target.ToString();
      foreach (FileInfo file in source.GetFiles())
      {
        string destFileName = Path.Combine(path1, file.Name);
        if (!skipCopy(file, destFileName))
          file.CopyTo(destFileName, true);
      }
      foreach (DirectoryInfo directory in source.GetDirectories())
      {
        DirectoryInfo subdirectory = target.CreateSubdirectory(directory.Name);
        DirectoryHelper.CopyAll(directory, subdirectory, skipCopy);
      }
    }

    public static string GetRelativePath(string filespec, string folder)
    {
      int num = 2;
      Uri uri;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DirectoryHelper.hZ0tqAhzIXsJJ0jvCVCJ((object) folder, (object) Path.DirectorySeparatorChar.ToString()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 3;
              continue;
            }
            goto case 4;
          case 2:
            uri = new Uri(filespec);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
            continue;
          case 4:
            folder = (string) DirectoryHelper.q2elU2hzVQWRxDeJfA3Y((object) folder, (object) Path.DirectorySeparatorChar.ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return (string) DirectoryHelper.N0KLSshziXVjM0JZ73cp((object) DirectoryHelper.Nh7NlBhzSL2x5nGLCAa9((object) new Uri(folder), (object) uri).ToString().Replace('/', Path.DirectorySeparatorChar));
    }

    public DirectoryHelper()
    {
      DirectoryHelper.jv3cKHhzRuxXIOLGemtE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool yt2L72hzZL991UkFucst() => DirectoryHelper.URsyBkhz89I2BiNgTlj2 == null;

    internal static DirectoryHelper ogwIQAhzuj4bTQ5kVHNv() => DirectoryHelper.URsyBkhz89I2BiNgTlj2;

    internal static bool hZ0tqAhzIXsJJ0jvCVCJ([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object q2elU2hzVQWRxDeJfA3Y([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Nh7NlBhzSL2x5nGLCAa9([In] object obj0, [In] object obj1) => (object) ((Uri) obj0).MakeRelativeUri((Uri) obj1);

    internal static object N0KLSshziXVjM0JZ73cp([In] object obj0) => (object) Uri.UnescapeDataString((string) obj0);

    internal static void jv3cKHhzRuxXIOLGemtE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

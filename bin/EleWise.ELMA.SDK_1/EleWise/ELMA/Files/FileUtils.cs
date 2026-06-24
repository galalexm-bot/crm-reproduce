// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.FileUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  public static class FileUtils
  {
    private static FileUtils dkGIGsGX56YH5uIdCS8l;

    /// <summary>Архивирование папки</summary>
    /// <param name="path"></param>
    /// <param name="zipStream"></param>
    /// <param name="folderOffset"></param>
    public static void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
    {
      int num1 = 7;
      string[] strArray;
      int index;
      FileStream source;
      byte[] buffer;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 3:
            if (index < strArray.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 10 : 8;
              continue;
            }
            goto case 11;
          case 2:
          case 8:
            if (index < strArray.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 6 : 12;
              continue;
            }
            goto label_14;
          case 4:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 8 : 2;
            continue;
          case 5:
            try
            {
              StreamUtils.Copy((Stream) source, (Stream) zipStream, buffer);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_10;
              }
            }
            finally
            {
              if (source != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_21;
                    default:
                      source.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_21:;
            }
          case 6:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
            continue;
          case 7:
            strArray = (string[]) FileUtils.StJXu2GXLksyfoiWaXmT((object) path);
            num1 = 6;
            continue;
          case 9:
            goto label_19;
          case 11:
            strArray = Directory.GetDirectories(path);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 4;
            continue;
          case 12:
          case 14:
            FileUtils.CompressFolder(strArray[index], zipStream, folderOffset);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 16 : 2;
            continue;
          case 13:
label_10:
            zipStream.CloseEntry();
            num1 = 15;
            continue;
          case 15:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 3;
            continue;
          case 16:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 0;
            continue;
          default:
            string fileName = strArray[index];
            FileInfo fileInfo = new FileInfo(fileName);
            ZipEntry zipEntry = new ZipEntry((string) FileUtils.rKUYdFGXUITmqfiiLrUq((object) fileName.Substring(folderOffset)));
            zipEntry.DateTime = fileInfo.LastWriteTime;
            FileUtils.WiUJooGXcDqnrVmOPb9d((object) zipEntry, FileUtils.Lo6iuYGXseL0GMGPYeMt((object) fileInfo));
            FileUtils.B4PXGrGXzWh5ky34uQD5((object) zipEntry, true);
            ZipEntry entry = zipEntry;
            zipStream.PutNextEntry(entry);
            buffer = new byte[4096];
            source = (FileStream) FileUtils.F7KCYlGTFVAJB9AMZYId((object) fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 5;
            continue;
        }
      }
label_19:
      return;
label_14:;
    }

    /// <summary>Копирование папки с заметой файлов</summary>
    /// <param name="src">Папка источник</param>
    /// <param name="dst">Папка назначение</param>
    public static void CopyDirectory(string src, string dst)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FileUtils.CopyDirectory(src, dst, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Копирование папки</summary>
    /// <param name="src">Папка источник</param>
    /// <param name="dst">Папка назначение</param>
    /// <param name="overwrite">Переписывать существующие файлы</param>
    /// <returns>Файлы, которые не удалось скопировать (файл существует в папке назначения)</returns>
    public static IEnumerable<string> CopyDirectory(string src, string dst, bool overwrite) => FileUtils.CopyDirectory((object) src, (object) dst, (object) "", overwrite);

    private static IEnumerable<string> CopyDirectory(
      object src,
      object dst,
      object returnPrefix,
      bool overwrite)
    {
      string dst1 = (string) dst;
      string returnPrefix1 = (string) returnPrefix;
      bool overwrite1 = overwrite;
      if (!Directory.Exists(dst1))
        Directory.CreateDirectory(dst1);
      return (IEnumerable<string>) ((IEnumerable<string>) Directory.GetFileSystemEntries((string) src)).SelectMany<string, string>((Func<string, IEnumerable<string>>) (element =>
      {
        string fileName = Path.GetFileName(element);
        string str = Path.Combine(dst1, fileName);
        string returnPrefix2 = Path.Combine(returnPrefix1, fileName);
        if (Directory.Exists(element))
          return FileUtils.CopyDirectory((object) element, (object) str, (object) returnPrefix2, overwrite1);
        if (!overwrite1 && File.Exists(str))
          return (IEnumerable<string>) new string[1]
          {
            returnPrefix2
          };
        File.Copy(element, str, overwrite1);
        return Enumerable.Empty<string>();
      })).ToArray<string>();
    }

    internal static object StJXu2GXLksyfoiWaXmT([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static object rKUYdFGXUITmqfiiLrUq([In] object obj0) => (object) ZipEntry.CleanName((string) obj0);

    internal static long Lo6iuYGXseL0GMGPYeMt([In] object obj0) => ((FileInfo) obj0).Length;

    internal static void WiUJooGXcDqnrVmOPb9d([In] object obj0, [In] long obj1) => ((ZipEntry) obj0).Size = obj1;

    internal static void B4PXGrGXzWh5ky34uQD5([In] object obj0, [In] bool obj1) => ((ZipEntry) obj0).IsUnicodeText = obj1;

    internal static object F7KCYlGTFVAJB9AMZYId([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static bool inprRjGXjLDKVuxqugn3() => FileUtils.dkGIGsGX56YH5uIdCS8l == null;

    internal static FileUtils ghYohfGXYPUsDEFpxpio() => FileUtils.dkGIGsGX56YH5uIdCS8l;
  }
}

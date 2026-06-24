// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ZipExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Предоставляет методы для архивации и деархивации данных
  /// </summary>
  public static class ZipExtensions
  {
    internal static ZipExtensions kqGq88GHRa370o6VRXSv;

    /// <summary>Заархивировать массив данных</summary>
    /// <param name="buffer">Массив данных</param>
    /// <param name="level">Уровень сжатия (0-9).</param>
    /// <returns></returns>
    public static byte[] Zip(this byte[] buffer, int level = 3)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      byte[] array;
      return array;
label_4:
      try
      {
        ZipOutputStream zipOutputStream = new ZipOutputStream((Stream) ZipExtensions.sFOl64GHXljjuHVkNlaQ((object) memoryStream));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              int defaultCodePage = ZipConstants.DefaultCodePage;
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    ZipExtensions.etByw3GHT2JDOGS9kfFM(850);
                    int num4 = 3;
                    ZipEntry zipEntry;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          zipEntry.DateTime = DateTime.MinValue;
                          num4 = 4;
                          continue;
                        case 2:
                          ZipExtensions.pVNbD0GHekSVHrpw4F2b((object) zipOutputStream, (object) buffer, 0, buffer.Length);
                          num4 = 9;
                          continue;
                        case 3:
                          ZipExtensions.piy0XqGHkHA92ekuR0GM((object) zipOutputStream, false);
                          num4 = 5;
                          continue;
                        case 4:
                          ZipExtensions.SIiSrjGH2fsCYdYN0x5c((object) zipOutputStream, (object) zipEntry);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
                          continue;
                        case 5:
                          ZipExtensions.fFGnTQGHnN9ltfLVqIFK((object) zipOutputStream, level);
                          num4 = 6;
                          continue;
                        case 6:
                          zipEntry = new ZipEntry((string) ZipExtensions.cPWmODGHOBcZoolIyL2r(-1638402543 ^ -1638664717));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
                          continue;
                        case 7:
                          goto label_3;
                        case 8:
                          array = memoryStream.ToArray();
                          num4 = 7;
                          continue;
                        case 9:
                          ZipExtensions.LS1skgGHPANd5IoTOxut((object) zipOutputStream);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                          continue;
                        default:
                          ZipExtensions.RaeSvkGH1q8fQG4VUI1p((object) zipOutputStream);
                          num4 = 8;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    ZipConstants.DefaultCodePage = defaultCodePage;
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                      num5 = 0;
                    switch (num5)
                    {
                      default:
                    }
                  }
              }
            }
            finally
            {
              int num6;
              if (zipOutputStream == null)
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
              else
                goto label_31;
label_30:
              switch (num6)
              {
                case 1:
                case 2:
              }
label_31:
              zipOutputStream.Dispose();
              num6 = 2;
              goto label_30;
            }
        }
      }
      finally
      {
        int num7;
        if (memoryStream == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
        else
          goto label_36;
label_35:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_36:
        ZipExtensions.Y6lJbsGHNTPhvYhdSgoq((object) memoryStream);
        num7 = 2;
        goto label_35;
      }
    }

    /// <summary>Разархивировать массив данных</summary>
    /// <param name="buffer">Массив данных</param>
    /// <returns></returns>
    public static byte[] Unzip(this byte[] buffer)
    {
      int num1 = 1;
      MemoryStream baseInputStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            baseInputStream = (MemoryStream) ZipExtensions.v2ykIqGH3bK0W6Wn5HTZ((object) buffer, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_38;
          default:
            goto label_3;
        }
      }
label_3:
      byte[] numArray1;
      try
      {
        ZipInputStream zipInputStream = new ZipInputStream((Stream) baseInputStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              int defaultCodePage = ZipConstants.DefaultCodePage;
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    ZipExtensions.etByw3GHT2JDOGS9kfFM(850);
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                      num4 = 0;
                    byte[] numArray2;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          numArray2 = new byte[ZipExtensions.xVncK2GHDnjLDNXu4lHI((object) zipInputStream)];
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 2;
                          continue;
                        case 2:
                          ZipExtensions.jba0bYGHtPGGVaOPMaDx((object) zipInputStream, (object) numArray2, 0, numArray2.Length);
                          num4 = 5;
                          continue;
                        case 3:
                          goto label_38;
                        case 4:
                          if (ZipExtensions.bRPiHYGHpf8xQdHFapGc((object) zipInputStream) != null)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                            continue;
                          }
                          goto label_20;
                        case 5:
                          numArray1 = numArray2;
                          num4 = 3;
                          continue;
                        case 6:
                          goto label_20;
                        default:
                          zipInputStream.IsStreamOwner = false;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 4;
                          continue;
                      }
                    }
label_20:
                    throw new InvalidOperationException((string) ZipExtensions.lpBceAGHa2xJoqCrw7mY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97709122)));
                  }
                  finally
                  {
                    ZipConstants.DefaultCodePage = defaultCodePage;
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                      num5 = 0;
                    switch (num5)
                    {
                      default:
                    }
                  }
              }
            }
            finally
            {
              int num6;
              if (zipInputStream == null)
                num6 = 2;
              else
                goto label_29;
label_28:
              switch (num6)
              {
                case 1:
                  break;
                default:
              }
label_29:
              zipInputStream.Dispose();
              num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
              {
                num6 = 0;
                goto label_28;
              }
              else
                goto label_28;
            }
        }
      }
      finally
      {
        int num7;
        if (baseInputStream == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
        else
          goto label_35;
label_34:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_35:
        baseInputStream.Dispose();
        num7 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        {
          num7 = 2;
          goto label_34;
        }
        else
          goto label_34;
      }
label_38:
      return numArray1;
    }

    internal static object sFOl64GHXljjuHVkNlaQ([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static void etByw3GHT2JDOGS9kfFM([In] int obj0) => ZipConstants.DefaultCodePage = obj0;

    internal static void piy0XqGHkHA92ekuR0GM([In] object obj0, [In] bool obj1) => ((DeflaterOutputStream) obj0).IsStreamOwner = obj1;

    internal static void fFGnTQGHnN9ltfLVqIFK([In] object obj0, [In] int obj1) => ((ZipOutputStream) obj0).SetLevel(obj1);

    internal static object cPWmODGHOBcZoolIyL2r(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void SIiSrjGH2fsCYdYN0x5c([In] object obj0, [In] object obj1) => ((ZipOutputStream) obj0).PutNextEntry((ZipEntry) obj1);

    internal static void pVNbD0GHekSVHrpw4F2b([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static void LS1skgGHPANd5IoTOxut([In] object obj0) => ((ZipOutputStream) obj0).CloseEntry();

    internal static void RaeSvkGH1q8fQG4VUI1p([In] object obj0) => ((Stream) obj0).Close();

    internal static void Y6lJbsGHNTPhvYhdSgoq([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool s83v0iGHqu4i5bFdfwYN() => ZipExtensions.kqGq88GHRa370o6VRXSv == null;

    internal static ZipExtensions XOfaVQGHKrUAklcqywgR() => ZipExtensions.kqGq88GHRa370o6VRXSv;

    internal static object v2ykIqGH3bK0W6Wn5HTZ([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object bRPiHYGHpf8xQdHFapGc([In] object obj0) => (object) ((ZipInputStream) obj0).GetNextEntry();

    internal static object lpBceAGHa2xJoqCrw7mY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static long xVncK2GHDnjLDNXu4lHI([In] object obj0) => ((Stream) obj0).Length;

    internal static int jba0bYGHtPGGVaOPMaDx([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);
  }
}

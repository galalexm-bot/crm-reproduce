// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.ZipService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>Сервис архивации/разархивации</summary>
  [Service]
  internal class ZipService : IZipService, IZipStreamService
  {
    internal static ZipService HMcCTFBMQEoxq3vRGpKF;

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(string zipFileName, string sourceDirectory) => this.CreateZipFolder(zipFileName, sourceDirectory, true);

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse) => this.CreateZipFolder(zipFileName, sourceDirectory, recurse, (string) null, (string) null);

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(
      string zipFileName,
      string sourceDirectory,
      bool recurse,
      string fileFilter,
      string directoryFilter)
    {
      int num1 = 5;
      FileStream zipStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ZipService.THy6seBMZ8WcbjDJULp1(Directory.Exists(sourceDirectory), ZipService.CASdLgBMu499sMh9UMj6(372753449 ^ 372682053));
            num1 = 3;
            continue;
          case 2:
            goto label_7;
          case 3:
            zipStream = new FileStream(zipFileName, FileMode.OpenOrCreate);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 2;
            continue;
          case 4:
            Contract.CheckArgument(!ZipService.X29ZEWBM86VgsH8LQp8A((object) sourceDirectory), (string) ZipService.CASdLgBMu499sMh9UMj6(--1333735954 ^ 1333680938));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          case 5:
            ZipService.THy6seBMZ8WcbjDJULp1(!ZipService.X29ZEWBM86VgsH8LQp8A((object) zipFileName), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398620592));
            num1 = 4;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      Exception zipFolder;
      return zipFolder;
label_7:
      try
      {
        zipFolder = this.CreateZipFolder((Stream) zipStream, sourceDirectory, recurse, fileFilter, directoryFilter);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_5;
        }
      }
      finally
      {
        int num3;
        if (zipStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
        else
          goto label_13;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_13:
        ZipService.vTMNZbBMIgQKXtCPJgH7((object) zipStream);
        num3 = 2;
        goto label_12;
      }
    }

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(
      Stream zipStream,
      string sourceDirectory,
      bool recurse,
      string fileFilter,
      string directoryFilter)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            ZipService.THy6seBMZ8WcbjDJULp1(!ZipService.X29ZEWBM86VgsH8LQp8A((object) sourceDirectory), ZipService.CASdLgBMu499sMh9UMj6(1218962250 ^ 1218873970));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) zipStream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222070486));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_4;
          default:
            Contract.CheckArgument(ZipService.R34pemBMV9EGm47SwNgq((object) sourceDirectory), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113938799));
            num1 = 4;
            continue;
        }
      }
label_2:
      return (Exception) null;
label_4:
      try
      {
        FastZip fastZip = new FastZip();
        if (ZipService.DQbSFZBMS4MQQLABqJ6u((object) fastZip) is ZipEntryFactory zipEntryFactory)
          ZipService.PZpvGABMiYbjvAp8ZFM0((object) zipEntryFactory, true);
        ZipService.gnDlrTBMRayLdS8PTdew((object) fastZip, true);
        ZipService.xRYJwjBMqkNwoSSemBjk((object) fastZip, (object) zipStream, (object) sourceDirectory, recurse, (object) fileFilter, (object) directoryFilter);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      return ex;
    }

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(Stream zipStream, string sourceDirectory, bool recurse) => this.CreateZipFolder(zipStream, sourceDirectory, recurse, (string) null, (string) null);

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    public Exception CreateZipFolder(Stream zipStream, string sourceDirectory) => this.CreateZipFolder(zipStream, sourceDirectory, true);

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    public Exception ExtractZipFolder(string zipFileName, string targetDirectory) => this.ExtractZipFolder(zipFileName, targetDirectory, (string) null);

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    public Exception ExtractZipFolder(
      string zipFileName,
      string targetDirectory,
      string fileFilter)
    {
      int num = 3;
      FileStream zipStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            zipStream = new FileStream(zipFileName, FileMode.Open);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            ZipService.THy6seBMZ8WcbjDJULp1(!ZipService.X29ZEWBM86VgsH8LQp8A((object) targetDirectory), ZipService.CASdLgBMu499sMh9UMj6(-812025778 ^ -812117520));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
          case 3:
            ZipService.THy6seBMZ8WcbjDJULp1(!ZipService.X29ZEWBM86VgsH8LQp8A((object) zipFileName), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335036669));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.ExtractZipFolder((Stream) zipStream, targetDirectory, fileFilter);
    }

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    public Exception ExtractZipFolder(Stream zipStream, string targetDirectory, string fileFilter)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_19;
          case 2:
            ZipService.THy6seBMZ8WcbjDJULp1(!ZipService.X29ZEWBM86VgsH8LQp8A((object) targetDirectory), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538463832));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
            continue;
          case 3:
            ZipService.abRHTYBMKD4xXEJKRxsh((object) zipStream, ZipService.CASdLgBMu499sMh9UMj6(1149433385 + 173655049 ^ 1323160474));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      try
      {
        Stream stream = zipStream;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num2 = 0;
        switch (num2)
        {
          case 1:
            goto label_19;
          default:
            try
            {
              ZipService.KeAhhvBMX1YGG6P1Oxfn((object) new FastZip(), (object) zipStream, (object) targetDirectory, FastZip.Overwrite.Always, (object) null, (object) fileFilter, (object) null, true, false, false);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_19;
              }
            }
            finally
            {
              int num4;
              if (stream == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              else
                goto label_13;
label_12:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_13:
              stream.Dispose();
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
              {
                num4 = 0;
                goto label_12;
              }
              else
                goto label_12;
            }
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
          num5 = 0;
        switch (num5)
        {
        }
      }
      return ex;
label_19:
      return (Exception) null;
    }

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    public Exception ExtractZipFolder(Stream zipStream, string targetDirectory) => this.ExtractZipFolder(zipStream, targetDirectory, (string) null);

    public ZipService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SueMMgBMCpfH8jZTyYo4() => ZipService.HMcCTFBMQEoxq3vRGpKF == null;

    internal static ZipService MBR7stBMvhQEFShVeYxU() => ZipService.HMcCTFBMQEoxq3vRGpKF;

    internal static bool X29ZEWBM86VgsH8LQp8A([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void THy6seBMZ8WcbjDJULp1(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object CASdLgBMu499sMh9UMj6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void vTMNZbBMIgQKXtCPJgH7([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool R34pemBMV9EGm47SwNgq([In] object obj0) => Directory.Exists((string) obj0);

    internal static object DQbSFZBMS4MQQLABqJ6u([In] object obj0) => (object) ((FastZip) obj0).EntryFactory;

    internal static void PZpvGABMiYbjvAp8ZFM0([In] object obj0, [In] bool obj1) => ((ZipEntryFactory) obj0).IsUnicodeText = obj1;

    internal static void gnDlrTBMRayLdS8PTdew([In] object obj0, [In] bool obj1) => ((FastZip) obj0).CreateEmptyDirectories = obj1;

    internal static void xRYJwjBMqkNwoSSemBjk(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] bool obj3,
      [In] object obj4,
      [In] object obj5)
    {
      ((FastZip) obj0).CreateZip((Stream) obj1, (string) obj2, obj3, (string) obj4, (string) obj5);
    }

    internal static void abRHTYBMKD4xXEJKRxsh([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void KeAhhvBMX1YGG6P1Oxfn(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] FastZip.Overwrite obj3,
      [In] object obj4,
      [In] object obj5,
      [In] object obj6,
      [In] bool obj7,
      [In] bool obj8,
      [In] bool obj9)
    {
      ((FastZip) obj0).ExtractZip((Stream) obj1, (string) obj2, obj3, (FastZip.ConfirmOverwriteDelegate) obj4, (string) obj5, (string) obj6, obj7, obj8, obj9);
    }
  }
}

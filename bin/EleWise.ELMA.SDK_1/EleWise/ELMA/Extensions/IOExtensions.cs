// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.IOExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения и методы для работы с файловой системой</summary>
  public static class IOExtensions
  {
    /// <summary>
    /// Подпапка, создаваемая по умолчанию в %TEMP% для хранения временных файлов
    /// </summary>
    public const string ElmaTempSubFolder = "ELMA";
    internal static IOExtensions x5VaqaGwMQACbOOycofk;

    /// <summary>
    /// Записать данные в файл. В случае ошибки сделать еще указанное число попыток через указанный интервал времени.
    /// </summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <param name="bytes">Данные</param>
    /// <param name="interval">Интервал между попытками</param>
    /// <param name="attemptCount">Максимальное число попыток</param>
    public static void WriteAllBytesWithAttempts(
      string fileName,
      byte[] bytes,
      TimeSpan interval,
      int attemptCount)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            IOExtensions.xsVhFxGwdmLUsPmZQiQC((object) fileName, (object) bytes, 0, bytes.Length, interval, attemptCount);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Записать данные в файл. В случае ошибки сделать еще указанное число попыток через указанный интервал времени.
    /// </summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <param name="bytes">Буфер данных</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина полезного объема данных</param>
    /// <param name="interval">Интервал между попытками</param>
    /// <param name="attemptCount">Максимальное число попыток</param>
    public static void WriteAllBytesWithAttempts(
      string fileName,
      byte[] bytes,
      int offset,
      int length,
      TimeSpan interval,
      int attemptCount)
    {
      int num1 = 2;
      MemoryStream dataStream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_3;
          case 2:
            dataStream = (MemoryStream) IOExtensions.VjKCLDGwl7QvvqPaMdUF((object) bytes, offset, length, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_12:
      return;
label_7:
      return;
label_3:
      try
      {
        IOExtensions.WriteAllBytesWithAttempts(fileName, (Stream) dataStream, interval, attemptCount);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (dataStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_14;
              default:
                IOExtensions.U7SUxIGwrHTJEKHxMeKX((object) dataStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_14:;
      }
    }

    /// <summary>
    /// Записать данные в файл. В случае ошибки сделать еще указанное число попыток через указанный интервал времени.
    /// </summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <param name="dataStream">Поток с данными</param>
    /// <param name="interval">Интервал между попытками</param>
    /// <param name="attemptCount">Максимальное число попыток</param>
    public static void WriteAllBytesWithAttempts(
      string fileName,
      Stream dataStream,
      TimeSpan interval,
      int attemptCount)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        string str1;
        FileStream fileStream1;
        SHA1 shA1_1;
        string str2;
        string fileName1;
        Stream dataStream1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dataStream1 = dataStream;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              if (!str1.Equals(str2))
              {
                num2 = 13;
                continue;
              }
              goto label_35;
            case 3:
              fileStream1 = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
              num2 = 5;
              continue;
            case 4:
              if (IOExtensions.KY1l91GwYpX5GcRPHxeV((object) fileName1))
                goto case 3;
              else
                goto label_5;
            case 5:
              try
              {
                SHA1 shA1_2 = SHA1.Create();
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    try
                    {
                      str1 = (string) IOExtensions.k1F8l9GwjLGEgChA5dji(IOExtensions.TjoraNGw5rVqoHnaxByV((object) shA1_2, (object) fileStream1));
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          goto label_18;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                        num5 = 0;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_18;
                          default:
                            ((ILogger) IOExtensions.zs3hmeGwLZfLwGXKybVL()).Warn(IOExtensions.QARnLRGwsSBCrOZcNBOd((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1114098865), (object) fileName1, IOExtensions.JKCURpGwUG049j04gPaZ(2045296739 + 1688595713 ^ -561074116)), ex);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                            continue;
                        }
                      }
                    }
                    finally
                    {
                      int num6;
                      if (shA1_2 == null)
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
                      else
                        goto label_36;
label_34:
                      switch (num6)
                      {
                        case 2:
                          break;
                        default:
                      }
label_36:
                      IOExtensions.U7SUxIGwrHTJEKHxMeKX((object) shA1_2);
                      num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                      {
                        num6 = 0;
                        goto label_34;
                      }
                      else
                        goto label_34;
                    }
                }
              }
              finally
              {
                if (fileStream1 != null)
                {
                  int num7 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                    num7 = 1;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        IOExtensions.U7SUxIGwrHTJEKHxMeKX((object) fileStream1);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_45;
                    }
                  }
                }
label_45:;
              }
            case 6:
            case 11:
label_18:
              if (str1 != null)
              {
                num2 = 2;
                continue;
              }
              goto case 13;
            case 7:
              fileName1 = fileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 9:
              try
              {
                str2 = (string) IOExtensions.k1F8l9GwjLGEgChA5dji(IOExtensions.TjoraNGw5rVqoHnaxByV((object) shA1_1, (object) dataStream1));
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_6;
                }
              }
              finally
              {
                int num9;
                if (shA1_1 == null)
                  num9 = 2;
                else
                  goto label_14;
label_13:
                switch (num9)
                {
                  case 1:
                    break;
                  default:
                }
label_14:
                IOExtensions.U7SUxIGwrHTJEKHxMeKX((object) shA1_1);
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                {
                  num9 = 0;
                  goto label_13;
                }
                else
                  goto label_13;
              }
            case 10:
              goto label_43;
            case 12:
label_6:
              str1 = (string) null;
              num2 = 4;
              continue;
            case 13:
              IOExtensions.bZ1BmKGwc6lhSfpleYCq((object) (System.Action) (() =>
              {
                int num10 = 2;
                FileStream fileStream2;
                while (true)
                {
                  switch (num10)
                  {
                    case 0:
                      goto label_13;
                    case 1:
                      goto label_3;
                    case 2:
                      fileStream2 = new FileStream(fileName1, FileMode.Create, FileAccess.ReadWrite);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_8;
                  }
                }
label_13:
                return;
label_8:
                return;
label_3:
                try
                {
                  // ISSUE: reference to a compiler-generated method
                  IOExtensions.\u003C\u003Ec__DisplayClass3_0.N1u7rd8blTVWC30MhOZT((object) dataStream1, 0L, SeekOrigin.Begin);
                  int num11 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                    num11 = 0;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        goto label_6;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        IOExtensions.\u003C\u003Ec__DisplayClass3_0.VDkaHt8brh9cvU99gFxo((object) dataStream1, (object) fileStream2);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
                        continue;
                    }
                  }
label_6:;
                }
                finally
                {
                  if (fileStream2 != null)
                  {
                    int num12 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                      num12 = 1;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          IOExtensions.\u003C\u003Ec__DisplayClass3_0.WqNHwU8bgr86ki1OdEwH((object) fileStream2);
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_15;
                      }
                    }
                  }
label_15:;
                }
              }), interval, attemptCount);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 10 : 4;
              continue;
            default:
              shA1_1 = (SHA1) IOExtensions.rf2cyyGwgX2o64I63RAc();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 9 : 5;
              continue;
          }
        }
label_5:
        num1 = 11;
      }
label_43:
      return;
label_35:;
    }

    /// <summary>Получить временную папку</summary>
    /// <returns></returns>
    public static string GetTempPath()
    {
      int num = 1;
      string tempPath;
      while (true)
      {
        switch (num)
        {
          case 1:
            tempPath = (string) IOExtensions.gk3VMeG4FNXZPuvl6R1f(IOExtensions.WZxUEEGwzheWb575uPSS(), IOExtensions.JKCURpGwUG049j04gPaZ(132912447 ^ 132925131));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            goto label_4;
          case 4:
            IOExtensions.mBa611G4WbQZUDtQy9vq((object) tempPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 3 : 0;
            continue;
          default:
            if (IOExtensions.QZH8keG4B0aS7WGQrnYu((object) tempPath))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
        }
      }
label_4:
      return tempPath;
    }

    /// <summary>
    /// Получить полный путь до файла или подпапки во временной папке
    /// </summary>
    /// <param name="path">Относительный путь до файла или папки</param>
    /// <returns></returns>
    public static string GetTempPath(string path) => (string) IOExtensions.gk3VMeG4FNXZPuvl6R1f((object) IOExtensions.GetTempPath(), (object) path);

    /// <summary>Получить имя временного файла (не создавая сам файл)</summary>
    /// <returns></returns>
    public static string GetTempFileName() => IOExtensions.GetTempFileName((object) null, true, false);

    /// <summary>Получить имя временного файла</summary>
    /// <param name="createFile">Создавать ли файл</param>
    /// <returns></returns>
    public static string GetTempFileName(bool createFile) => (string) IOExtensions.nYJcy0G4okwBTV7mqrui((object) null, true, createFile);

    /// <summary>
    /// Получить имя временного файла без расширения (не создавая сам файл)
    /// </summary>
    /// <returns></returns>
    public static string GetTempFileNameWithoutExtension() => (string) IOExtensions.nYJcy0G4okwBTV7mqrui((object) null, false, false);

    /// <summary>Получить имя временного файла без расширения</summary>
    /// <param name="createFile">Создавать ли файл</param>
    /// <returns></returns>
    public static string GetTempFileNameWithoutExtension(bool createFile) => IOExtensions.GetTempFileName((object) null, false, createFile);

    /// <summary>
    /// Получить имя временного файла с указанным расширением (не создавая сам файл)
    /// </summary>
    /// <param name="extension">Расширение файла</param>
    /// <returns></returns>
    public static string GetTempFileName(string extension) => (string) IOExtensions.nYJcy0G4okwBTV7mqrui((object) extension, true, false);

    /// <summary>Получить имя временного файла с указанным расширением</summary>
    /// <param name="extension">Расширение файла</param>
    /// <param name="createFile">Создавать ли файл</param>
    /// <returns></returns>
    public static string GetTempFileName(string extension, bool createFile) => (string) IOExtensions.nYJcy0G4okwBTV7mqrui((object) extension, true, createFile);

    private static string GetTempFileName(object extension, bool needExtension, bool createFile)
    {
      int num1 = 1;
      Guid guid;
      FileStream fileStream;
      string tempPath;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!IOExtensions.ou6RhJG4bsTF30gEk44J(extension))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            if (!createFile)
            {
              num1 = 3;
              continue;
            }
            goto case 8;
          case 3:
          case 6:
            goto label_17;
          case 4:
            extension = IOExtensions.ge96crG4GdVGRviYafA3(IOExtensions.JKCURpGwUG049j04gPaZ(--1333735954 ^ 1333733590), extension);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 10 : 9;
            continue;
          case 5:
          case 10:
            guid = IOExtensions.Wi7YJcG4EJRWTD2GAOsh();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 7;
            continue;
          case 7:
            tempPath = IOExtensions.GetTempPath((string) IOExtensions.ge96crG4GdVGRviYafA3((object) guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979488758)), needExtension ? extension ?? IOExtensions.JKCURpGwUG049j04gPaZ(1242972401 >> 4 ^ 77596633) : (object) ""));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 2;
            continue;
          case 8:
            fileStream = (FileStream) IOExtensions.QSV6GuG4f2EReGkfvlaZ((object) tempPath);
            num1 = 9;
            continue;
          case 9:
            goto label_9;
          default:
            if (IOExtensions.hNXRvVG4hufuox0VDHRC(extension, IOExtensions.JKCURpGwUG049j04gPaZ(-1837662597 ^ -1837669185)))
            {
              num1 = 5;
              continue;
            }
            goto case 4;
        }
      }
label_9:
      try
      {
      }
      finally
      {
        if (fileStream != null)
        {
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
            num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_15;
              default:
                IOExtensions.U7SUxIGwrHTJEKHxMeKX((object) fileStream);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_15:;
      }
label_17:
      return tempPath;
    }

    internal static void xsVhFxGwdmLUsPmZQiQC(
      [In] object obj0,
      [In] object obj1,
      int offset,
      int length,
      TimeSpan interval,
      int attemptCount)
    {
      IOExtensions.WriteAllBytesWithAttempts((string) obj0, (byte[]) obj1, offset, length, interval, attemptCount);
    }

    internal static bool hM9qoSGwJ9mxx9D9Sla6() => IOExtensions.x5VaqaGwMQACbOOycofk == null;

    internal static IOExtensions p3hXAqGw9pm41OaKf6Uj() => IOExtensions.x5VaqaGwMQACbOOycofk;

    internal static object VjKCLDGwl7QvvqPaMdUF(
      [In] object obj0,
      int offset,
      int length,
      bool writable)
    {
      return (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);
    }

    internal static void U7SUxIGwrHTJEKHxMeKX([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object rf2cyyGwgX2o64I63RAc() => (object) SHA1.Create();

    internal static object TjoraNGw5rVqoHnaxByV([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object k1F8l9GwjLGEgChA5dji([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static bool KY1l91GwYpX5GcRPHxeV([In] object obj0) => File.Exists((string) obj0);

    internal static object zs3hmeGwLZfLwGXKybVL() => (object) Logger.Log;

    internal static object JKCURpGwUG049j04gPaZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QARnLRGwsSBCrOZcNBOd([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void bZ1BmKGwc6lhSfpleYCq([In] object obj0, TimeSpan interval, int attemptCount) => ActionExtensions.ExecuteWithAttempts((System.Action) obj0, interval, attemptCount);

    internal static object WZxUEEGwzheWb575uPSS() => (object) Path.GetTempPath();

    internal static object gk3VMeG4FNXZPuvl6R1f([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool QZH8keG4B0aS7WGQrnYu([In] object obj0) => Directory.Exists((string) obj0);

    internal static object mBa611G4WbQZUDtQy9vq([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object nYJcy0G4okwBTV7mqrui([In] object obj0, bool needExtension, bool createFile) => (object) IOExtensions.GetTempFileName(obj0, needExtension, createFile);

    internal static bool ou6RhJG4bsTF30gEk44J([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool hNXRvVG4hufuox0VDHRC([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object ge96crG4GdVGRviYafA3([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid Wi7YJcG4EJRWTD2GAOsh() => Guid.NewGuid();

    internal static object QSV6GuG4f2EReGkfvlaZ([In] object obj0) => (object) File.Create((string) obj0);
  }
}

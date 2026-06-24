// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.BinaryFileBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>Построитель BinaryFile-ов.</summary>
  public class BinaryFileBuilder
  {
    private readonly BinaryFile binaryFile;
    internal static BinaryFileBuilder EEB4gfGKCeOYUh86sBal;

    /// <summary>Ctor</summary>
    /// <param name="templateBinaryFile">Шаблон файла.</param>
    internal BinaryFileBuilder(BinaryFile templateBinaryFile)
    {
      BinaryFileBuilder.txjaksGKZK7s9PPuw9pg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            BinaryFile binaryFile = new BinaryFile();
            BinaryFileBuilder.bAxmToGKVSj6kNJMu6ZX((object) binaryFile, BinaryFileBuilder.JsFYJ9GKInJ5XSBwj98D((object) templateBinaryFile));
            BinaryFileBuilder.G5uqPyGKSgXcD76myl7H((object) binaryFile, DateTime.Now);
            BinaryFileBuilder.dCVXZJGKig7xw05xxrty((object) binaryFile, true);
            BinaryFileBuilder.Cu8RfVGKqTxGYpSmjBY8((object) binaryFile, BinaryFileBuilder.vrvJ8wGKR1nMSVxOEQE9((object) templateBinaryFile));
            BinaryFileBuilder.JcRQ0LGKXrsf6UuPUX8v((object) binaryFile, BinaryFileBuilder.G30PvcGKKE3cDYwBcVYA((object) templateBinaryFile));
            binaryFile.Salt = (string) BinaryFileBuilder.V1NpIrGKTDQ4Datfpp0D((object) templateBinaryFile);
            binaryFile.Uid = Guid.NewGuid();
            this.binaryFile = binaryFile;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
            continue;
          default:
            BinaryFileBuilder.jWQCHOGKuICWhEqHabiw((object) templateBinaryFile, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669300259));
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    internal BinaryFileBuilder()
    {
      BinaryFileBuilder.txjaksGKZK7s9PPuw9pg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFile binaryFile = new BinaryFile();
            BinaryFileBuilder.G5uqPyGKSgXcD76myl7H((object) binaryFile, BinaryFileBuilder.SpR2vHGKn9vSVYZA9eBR());
            BinaryFileBuilder.dCVXZJGKig7xw05xxrty((object) binaryFile, true);
            BinaryFileBuilder.JcRQ0LGKXrsf6UuPUX8v((object) binaryFile, (object) string.Format((string) BinaryFileBuilder.NGHJdOGKO9Lb7y0a5aqY(1051802738 - -1831968059 ^ -1411316727), (object) guid.ToString((string) BinaryFileBuilder.NGHJdOGKO9Lb7y0a5aqY(1232639661 >> 3 ^ 154100443))));
            binaryFile.Uid = guid;
            this.binaryFile = binaryFile;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            guid = BinaryFileBuilder.Gk2NTeGKk5WwvOmIdtNU();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Установить уникальный идентификатор файла.</summary>
    /// <param name="uid">Уникальный идентификатор файла.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Uid(Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.CbJTeyGK2IRp1j0GIg6P((object) this.binaryFile, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Установить имя файла.</summary>
    /// <param name="name">Имя файла.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Name(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.JcRQ0LGKXrsf6UuPUX8v((object) this.binaryFile, (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Установить тип контента.</summary>
    /// <param name="contentType">Тип контента.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder ContentType(string contentType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.bAxmToGKVSj6kNJMu6ZX((object) this.binaryFile, (object) contentType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Установить дату создания.</summary>
    /// <param name="createDate">Дата создания файла.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Created(DateTime createDate)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.G5uqPyGKSgXcD76myl7H((object) this.binaryFile, createDate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Установить контент файла.</summary>
    /// <param name="contentBytes">Контент в виде массива байт.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Content(byte[] contentBytes)
    {
      int num = 1;
      MemoryStream contentStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            contentStream = (MemoryStream) BinaryFileBuilder.Pn8r9eGKeMysvWf8si5I((object) contentBytes, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Content((Stream) contentStream, true);
    }

    /// <summary>Установить контент файла.</summary>
    /// <param name="contentFilePath">Контент в виде пути к физическому файлу.</param>
    /// <param name="deleteContentFileAfterSave">Удалить файл контента после сохранения.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Content(string contentFilePath, bool deleteContentFileAfterSave = false)
    {
      int num = 1;
      FileStream contentStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.dCVXZJGKig7xw05xxrty((object) this.binaryFile, deleteContentFileAfterSave);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            contentStream = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return this.Content((Stream) contentStream, true);
    }

    /// <summary>Установить контент файла.</summary>
    /// <param name="contentStream">Поток контента.</param>
    /// <param name="autoCloseStream">Автоматически закрыть поток после передачи контента.</param>
    /// <param name="extension">Расширение временного файла. Может потребоваться для обеспечения совместимости.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Content(Stream contentStream, bool autoCloseStream = false, string extension = null)
    {
      switch (1)
      {
        case 1:
          try
          {
            object obj = BinaryFileBuilder.yiTTT4GKPf3K90OyPEJL();
            BinaryFile binaryFile = this.binaryFile;
            Stream content = contentStream;
            PutContentOptions options = new PutContentOptions();
            BinaryFileBuilder.zcCQyPGK121y4ul1ZcbF((object) options, (object) extension);
            ((IBinaryFileStreams) obj).PutContent(binaryFile, content, options);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
              num = 0;
            switch (num)
            {
            }
          }
          finally
          {
            int num;
            if (!autoCloseStream)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
            else
              goto label_7;
label_6:
            switch (num)
            {
              case 1:
              case 2:
            }
label_7:
            BinaryFileBuilder.hsw0VDGKNWDAojVc09Gq((object) contentStream);
            num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
            {
              num = 1;
              goto label_6;
            }
            else
              goto label_6;
          }
          break;
      }
      return this;
    }

    /// <summary>
    /// Установить контент файла по его местоположению. Применимо, если контент был закачан напрямую в удалённую точку.
    /// </summary>
    /// <param name="contentLocation">Местоположение закачанного контента.</param>
    /// <param name="contentLength">Размер закачанного контента.</param>
    /// <param name="contentCrc">Crc закачанного контента.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public BinaryFileBuilder Content(Uri contentLocation, long contentLength, uint contentCrc)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileBuilder.vfyQFHGK3oxSTbhnIoqS((object) this.binaryFile, (object) contentLocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            BinaryFileBuilder.FmjqkTGKawDmS9sCE5WR((object) this.binaryFile, contentCrc);
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            BinaryFileBuilder.cBkRhxGKp3HDM39OldBe((object) this.binaryFile, contentLength);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return this;
    }

    /// <summary>Построить BinaryFile.</summary>
    /// <returns>Новый BinaryFile.</returns>
    public BinaryFile Build() => this.binaryFile;

    /// <summary>
    /// Оператор неявного приведения построителя к BinaryFile.
    /// </summary>
    /// <param name="builder">Построитель BinaryFile.</param>
    public static implicit operator BinaryFile(BinaryFileBuilder builder) => builder.binaryFile;

    internal static void txjaksGKZK7s9PPuw9pg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void jWQCHOGKuICWhEqHabiw([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object JsFYJ9GKInJ5XSBwj98D([In] object obj0) => (object) ((BinaryFile) obj0).ContentType;

    internal static void bAxmToGKVSj6kNJMu6ZX([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentType = (string) obj1;

    internal static void G5uqPyGKSgXcD76myl7H([In] object obj0, DateTime value) => ((BinaryFile) obj0).CreateDate = value;

    internal static void dCVXZJGKig7xw05xxrty([In] object obj0, bool value) => ((BinaryFile) obj0).DeleteTempFileAfterSave = value;

    internal static bool vrvJ8wGKR1nMSVxOEQE9([In] object obj0) => ((BinaryFile) obj0).Encrypt;

    internal static void Cu8RfVGKqTxGYpSmjBY8([In] object obj0, bool value) => ((BinaryFile) obj0).Encrypt = value;

    internal static object G30PvcGKKE3cDYwBcVYA([In] object obj0) => (object) ((BinaryFile) obj0).Name;

    internal static void JcRQ0LGKXrsf6UuPUX8v([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Name = (string) obj1;

    internal static object V1NpIrGKTDQ4Datfpp0D([In] object obj0) => (object) ((BinaryFile) obj0).Salt;

    internal static bool Db0glaGKvV6Xg5VJpDTC() => BinaryFileBuilder.EEB4gfGKCeOYUh86sBal == null;

    internal static BinaryFileBuilder UXKAC5GK8GVVUAhH8DUU() => BinaryFileBuilder.EEB4gfGKCeOYUh86sBal;

    internal static Guid Gk2NTeGKk5WwvOmIdtNU() => Guid.NewGuid();

    internal static DateTime SpR2vHGKn9vSVYZA9eBR() => DateTime.Now;

    internal static object NGHJdOGKO9Lb7y0a5aqY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void CbJTeyGK2IRp1j0GIg6P([In] object obj0, Guid value) => ((BinaryFile) obj0).Uid = value;

    internal static object Pn8r9eGKeMysvWf8si5I([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object yiTTT4GKPf3K90OyPEJL() => (object) DataAccessManager.BinaryFileStreams;

    internal static void zcCQyPGK121y4ul1ZcbF([In] object obj0, [In] object obj1) => ((PutContentOptions) obj0).Extension = (string) obj1;

    internal static void hsw0VDGKNWDAojVc09Gq([In] object obj0) => ((Stream) obj0).Dispose();

    internal static void vfyQFHGK3oxSTbhnIoqS([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentLocation = (Uri) obj1;

    internal static void cBkRhxGKp3HDM39OldBe([In] object obj0, long contentLength) => ((BinaryFile) obj0).SetSize(contentLength);

    internal static void FmjqkTGKawDmS9sCE5WR([In] object obj0, uint contentCrc) => ((BinaryFile) obj0).SetCrc(contentCrc);
  }
}

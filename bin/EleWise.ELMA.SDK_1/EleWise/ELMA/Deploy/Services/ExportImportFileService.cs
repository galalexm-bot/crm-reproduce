// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ExportImportFileService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис передачи файлов экспорта-импорта</summary>
  [Service]
  internal class ExportImportFileService : ExportImportFileServiceBase
  {
    public const long BufferLength = 393216;
    /// <summary>Сервис для работы с временными файлами</summary>
    private readonly ICacheFilesService cacheFilesService;
    internal static ExportImportFileService DTUCCsEA4sZiWfVCD1aY;

    /// <summary>Ctor</summary>
    /// <param name="cacheFilesService">Сервис для работы с временными файлами</param>
    public ExportImportFileService(ICacheFilesService cacheFilesService)
    {
      ExportImportFileService.Wt4eU4EAACLqssGjEhUb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.cacheFilesService = cacheFilesService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override long GetBufferLength() => 393216;

    /// <inheritdoc />
    public override string GetFilesFolderName() => (string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-1858887263 ^ -1858653573);

    /// <inheritdoc />
    public override string GetFilesFolderPath() => (string) ExportImportFileService.lFqesbEAMuaHRNbBgfnf(ExportImportFileService.CaQPOpEAycWysp3eaG3r(ExportImportFileService.wynmFpEAm5r1oKpQSDwf(ExportImportFileService.pkBrdaEA0IWh9aFFZhSY(ExportImportFileService.FrHKhqEAxanR929xvqAX((object) Locator.GetService<IRuntimeApplication>())))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671832351));

    /// <summary>
    /// Путь к папке со временными файлами экспорта-импорта, находящейся в папке конфигурации
    /// </summary>
    private string filesPath
    {
      get
      {
        int num = 2;
        string filesPath;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ExportImportFileService.dRxLPnEA9XlPY7HCwWUP((object) filesPath))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 3;
                continue;
              }
              break;
            case 2:
              filesPath = (string) ExportImportFileService.Wl0EdYEAJyBhfxtmt9xD((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 3:
            case 4:
              goto label_6;
          }
          ExportImportFileService.U0g9eREAdUXBuv0P4Gdf((object) filesPath);
          num = 3;
        }
label_6:
        return filesPath;
      }
    }

    /// <inheritdoc />
    public override string CreateZipFileName(string id) => (string) ExportImportFileService.OFs0xUEAl2KwanUODWWY((object) this, (object) id, (object) null);

    /// <inheritdoc />
    public override string CreateZipFileName(string id, string ext)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            str = (string) ExportImportFileService.pZiuKWEAr0Nbao5LV8JT(ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-1852837372 ^ -1852854266), (object) id, (object) ext ?? ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-398663332 ^ -398953124));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      return (string) ExportImportFileService.lFqesbEAMuaHRNbBgfnf((object) this.filesPath, (object) str);
label_5:
      throw new ArgumentNullException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(874012245 ^ 874081583));
    }

    /// <inheritdoc />
    public override string CreateFileName(string id, string folder, string name, string ext)
    {
      int num = 2;
      string str1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (id == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
              continue;
            }
            object format = ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-1487388570 ^ -1487404444);
            string str2 = name;
            string str3 = str2 == null ? id : str2;
            string str4 = ext;
            string str5 = str4 == null ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178496830) : str4;
            str1 = string.Format((string) format, (object) str3, (object) str5);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) ExportImportFileService.lFqesbEAMuaHRNbBgfnf(ExportImportFileService.L6gpKbEAgXKlphmVpp1i((object) this, (object) id, (object) folder), (object) str1);
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16683619));
    }

    /// <inheritdoc />
    public override string CreateFileName(string id, string name = null, string ext = "xml") => this.CreateFileName(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536761570), name, ext);

    /// <inheritdoc />
    public override string CreateFolderName(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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
      throw new ArgumentNullException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-951514650 ^ -951567716));
label_3:
      return Path.Combine(this.filesPath, id);
    }

    /// <inheritdoc />
    public override string CreateDeployFolderName(string id) => (string) ExportImportFileService.L6gpKbEAgXKlphmVpp1i((object) this, (object) id, ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(1917256330 ^ 1917300226));

    /// <inheritdoc />
    public override string CreateDeployFolderName(string id, string folder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-542721635 ^ -542668057));
label_3:
      return (string) ExportImportFileService.lFqesbEAMuaHRNbBgfnf(ExportImportFileService.RFZgmpEA5nyDVgqPZ13I((object) this, (object) id), (object) folder);
    }

    /// <inheritdoc />
    public override void AddToFile(string id, byte[] buf)
    {
      int num1 = 5;
      string path;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_24;
            case 2:
              goto label_10;
            case 3:
              path = (string) ExportImportFileService.aNwwAaEAj1RLf5VHqmQW((object) this, (object) id);
              num2 = 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              if (id != null)
              {
                if (buf != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
                  continue;
                }
                goto label_6;
              }
              else
                goto label_9;
            default:
              goto label_6;
          }
        }
label_9:
        num1 = 4;
      }
label_24:
      return;
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521195718));
label_6:
      throw new ArgumentOutOfRangeException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(~1767720452 ^ -1767494155));
label_10:
      try
      {
        int num3;
        if (ExportImportFileService.CAo20JEAYZHGpkd5lsux((object) path))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
        else
          goto label_15;
label_12:
        object obj;
        switch (num3)
        {
          case 0:
            return;
          case 1:
            obj = (object) new FileStream(path, FileMode.Append);
            goto label_16;
          default:
            return;
        }
label_15:
        obj = ExportImportFileService.ArxwShEALwfyYcRrkGhY((object) path);
label_16:
        ExportImportFileService.lCrMiuEAU0bcB0Ivmygr(obj, (object) buf, 0, buf.Length);
        ExportImportFileService.WN3QYSEAsWPkJ44lRdXU(obj);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        {
          num3 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
    }

    /// <inheritdoc />
    public override void AddToFile(string id, BinaryFile file)
    {
      int num1 = 1;
      Stream content;
      while (true)
      {
        switch (num1)
        {
          case 1:
            content = file.GetContent();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
        this.AddToFile(id, content);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (content == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
        else
          goto label_11;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        ExportImportFileService.tepa2xEAcJy0nsOKUm4k((object) content);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        {
          num3 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <inheritdoc />
    public override void AddToNestedFile(string id, string nestedId, string path, byte[] buf)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportFileService.ptth4aEAzHeiEV2hDrku((object) this, (object) id, (object) nestedId, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561366684), (object) path, (object) buf);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public override void AddToNestedFile(
      string id,
      string nestedId,
      string fileExtension,
      string path,
      byte[] buf)
    {
      int num1 = 12;
      string path1;
      string str;
      string path2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            path2 = (string) ExportImportFileService.lFqesbEAMuaHRNbBgfnf((object) path1, (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 4;
            continue;
          case 2:
          case 3:
            str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426078405), (object) nestedId, (object) fileExtension);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
            continue;
          case 4:
            goto label_19;
          case 5:
            Directory.CreateDirectory(path1);
            num1 = 3;
            continue;
          case 6:
            goto label_14;
          case 7:
            goto label_3;
          case 8:
            goto label_43;
          case 9:
            goto label_9;
          case 10:
            if (Directory.Exists(path1))
            {
              num1 = 2;
              continue;
            }
            goto case 5;
          case 11:
            goto label_6;
          case 12:
            if (id != null)
            {
              if (nestedId != null)
              {
                num1 = 14;
                continue;
              }
              goto label_3;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 8 : 11;
              continue;
            }
          case 13:
            if (buf != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 14:
            if (path != null)
            {
              num1 = 13;
              continue;
            }
            goto label_14;
          default:
            path1 = (string) ExportImportFileService.oMWFF7E7FW9Xaw2nDOgR((object) this.filesPath, (object) id, (object) path);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 10 : 1;
            continue;
        }
      }
label_43:
      return;
label_3:
      throw new ArgumentNullException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-951514650 ^ -951214598));
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536857360));
label_9:
      throw new ArgumentOutOfRangeException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-420743386 ^ -420519128));
label_14:
      throw new ArgumentNullException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(1012087039 ^ 1012360835));
label_19:
      try
      {
        int num2;
        if (!ExportImportFileService.CAo20JEAYZHGpkd5lsux((object) path2))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 3;
        else
          goto label_22;
label_21:
        FileStream fileStream1;
        FileStream fileStream2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            try
            {
              fileStream1.Write(buf, 0, buf.Length);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              if (fileStream1 != null)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ExportImportFileService.tepa2xEAcJy0nsOKUm4k((object) fileStream1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_32;
                  }
                }
              }
label_32:;
            }
          case 3:
            fileStream2 = File.Create(path2);
            goto label_35;
        }
label_22:
        fileStream2 = new FileStream(path2, FileMode.Append);
label_35:
        fileStream1 = fileStream2;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        {
          num2 = 0;
          goto label_21;
        }
        else
          goto label_21;
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num5 = 0;
        switch (num5)
        {
        }
      }
    }

    /// <inheritdoc />
    public override byte[] LoadFile(string id, long i) => (byte[]) ExportImportFileService.AlhjZEE7BoSCDxnP10Lw((object) this, (object) id, i, (object) null);

    /// <inheritdoc />
    public override byte[] LoadFile(string id, long i, string ext)
    {
      int num1 = 5;
      string path;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            num1 = 3;
            continue;
          case 2:
            goto label_10;
          case 3:
            goto label_14;
          case 4:
            goto label_5;
          case 5:
            if (id == null)
            {
              num1 = 4;
              continue;
            }
            if (i < 0L)
            {
              num1 = 6;
              continue;
            }
            path = (string) ExportImportFileService.OFs0xUEAl2KwanUODWWY((object) this, (object) id, (object) ext);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_12;
          default:
            if (ExportImportFileService.CAo20JEAYZHGpkd5lsux((object) path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
              continue;
            }
            goto label_10;
        }
      }
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867301513));
label_10:
      throw new Exception((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-1886646897 ^ -1886873153));
label_12:
      throw new ArgumentOutOfRangeException((string) ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(-867826612 ^ -867765796));
label_14:
      byte[] numArray;
      try
      {
        int num2;
        if ((i + 1L) * 393216L >= ExportImportFileService.bLPoLdE7WxaX6WWCd6BN((object) fileStream))
          num2 = 9;
        else
          goto label_28;
label_16:
        long length;
        byte[] buffer;
        long num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
              buffer = new byte[length];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
              continue;
            case 2:
              num3 = 393216L * i;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            case 3:
            case 6:
            case 11:
              goto label_11;
            case 4:
              if (length >= 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 7 : 6;
                continue;
              }
              goto case 12;
            case 5:
              if (fileStream.Read(buffer, 0, buffer.Length) == 0)
              {
                num2 = 10;
                continue;
              }
              goto case 8;
            case 8:
              numArray = buffer;
              num2 = 3;
              continue;
            case 9:
              goto label_20;
            case 10:
              numArray = (byte[]) null;
              num2 = 11;
              continue;
            case 12:
              numArray = (byte[]) null;
              num2 = 6;
              continue;
            default:
              ExportImportFileService.YURYfBE7obyeNTmjPWTT((object) fileStream, num3, SeekOrigin.Begin);
              num2 = 5;
              continue;
          }
        }
label_20:
        long num4 = ExportImportFileService.bLPoLdE7WxaX6WWCd6BN((object) fileStream) - i * 393216L;
        goto label_29;
label_28:
        num4 = 393216L;
label_29:
        length = num4;
        num2 = 4;
        goto label_16;
      }
      finally
      {
        int num5;
        if (fileStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
        else
          goto label_33;
label_32:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_33:
        ExportImportFileService.tepa2xEAcJy0nsOKUm4k((object) fileStream);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        {
          num5 = 1;
          goto label_32;
        }
        else
          goto label_32;
      }
label_11:
      return numArray;
    }

    /// <inheritdoc />
    public override void DeleteFiles(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportFileService.EcUmqkE7b5n5hREJdtUX((object) this, (object) id, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public override void DeleteFiles(string id, string ext)
    {
      int num = 9;
      while (true)
      {
        string str;
        string path;
        switch (num)
        {
          case 1:
            if (!ExportImportFileService.dRxLPnEA9XlPY7HCwWUP((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 4;
              continue;
            }
            goto case 6;
          case 2:
          case 5:
            str = (string) ExportImportFileService.RFZgmpEA5nyDVgqPZ13I((object) this, (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
            continue;
          case 3:
            if (!File.Exists(path))
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            goto label_14;
          case 6:
            ExportImportFileService.lsWtmCE7GxXE3rW8lVcy((object) str, true);
            num = 7;
            continue;
          case 7:
            goto label_9;
          case 8:
            goto label_8;
          case 9:
            if (id == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 8 : 1;
              continue;
            }
            path = (string) ExportImportFileService.OFs0xUEAl2KwanUODWWY((object) this, (object) id, (object) ext);
            num = 3;
            continue;
        }
        ExportImportFileService.iwPJHaE7h5MGeNtSq9Dk((object) path);
        num = 5;
      }
label_14:
      return;
label_9:
      return;
label_8:;
    }

    /// <inheritdoc />
    public override void LoadFileToCache(string fileName, string fullFileName, Guid uid)
    {
      int num1 = 3;
      FileStream inputStream;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              goto label_10;
            case 3:
              if (!ExportImportFileService.CAo20JEAYZHGpkd5lsux((object) fullFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
                continue;
              }
              goto case 4;
            case 4:
              if (ExportImportFileService.OIL7AXE7Esgg8Zlg6GcD((object) this.cacheFilesService, uid, (object) fileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              goto label_14;
            case 5:
              goto label_6;
            default:
              goto label_21;
          }
        }
label_21:
        inputStream = new FileStream(fullFileName, FileMode.Open, FileAccess.Read);
        num1 = 5;
      }
label_15:
      return;
label_10:
      return;
label_6:
      try
      {
        this.cacheFilesService.IncrementCacheFile(uid, (Stream) inputStream);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      finally
      {
        int num4;
        if (inputStream == null)
          num4 = 2;
        else
          goto label_16;
label_13:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_16:
        inputStream.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        {
          num4 = 1;
          goto label_13;
        }
        else
          goto label_13;
      }
label_14:;
    }

    /// <summary>Добавление файла из потока</summary>
    private void AddToFile(string id, Stream stream)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          long num3;
          long bufferLength;
          long num4;
          long length;
          byte[] buffer;
          long num5;
          switch (num2)
          {
            case 1:
              ExportImportFileService.KWbyIqE7f8VGTgWebV18((object) this, (object) id, (object) buffer);
              num2 = 6;
              continue;
            case 2:
            case 9:
              if (length > 0L)
              {
                num2 = 5;
                continue;
              }
              goto case 12;
            case 3:
              num5 = num4 - num3 * bufferLength;
              break;
            case 4:
              length = bufferLength;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 13;
              continue;
            case 5:
            case 17:
              if (num3 != long.MaxValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 6:
              ++num3;
              num2 = 2;
              continue;
            case 7:
              goto label_22;
            case 8:
              goto label_10;
            case 10:
              bufferLength = this.GetBufferLength();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 0;
              continue;
            case 11:
              num3 = 0L;
              num2 = 10;
              continue;
            case 12:
            case 16:
              if (num3 != 0L)
              {
                num2 = 7;
                continue;
              }
              goto label_10;
            case 13:
              num4 = ExportImportFileService.bLPoLdE7WxaX6WWCd6BN((object) stream);
              num2 = 9;
              continue;
            case 14:
              if (length > 0L)
                goto case 18;
              else
                goto label_12;
            case 15:
              stream.Read(buffer, 0, buffer.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            case 18:
              buffer = new byte[length];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 15 : 7;
              continue;
            default:
              if ((num3 + 1L) * bufferLength >= num4)
              {
                num2 = 3;
                continue;
              }
              num5 = bufferLength;
              break;
          }
          length = num5;
          num2 = 14;
        }
label_12:
        num1 = 16;
      }
label_22:
      return;
label_10:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138667144)));
    }

    /// <inheritdoc />
    public override bool Exists(string id, string ext)
    {
      int num = 1;
      string path2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            path2 = (string) ExportImportFileService.pZiuKWEAr0Nbao5LV8JT((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178225982), (object) id, (object) ext ?? ExportImportFileService.N6YhnjEA7Fbn2SUuq4Pd(2045296739 + 1688595713 ^ -561366684));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return ExportImportFileService.CAo20JEAYZHGpkd5lsux((object) Path.Combine(this.filesPath, path2));
label_5:
      return false;
    }

    /// <inheritdoc />
    public override bool Exists(string id) => ExportImportFileService.t0eHAjE7QWstdYkJOv14((object) this, (object) id, (object) null);

    internal static void Wt4eU4EAACLqssGjEhUb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QDIGdgEA6hoXQ5M5CGrj() => ExportImportFileService.DTUCCsEA4sZiWfVCD1aY == null;

    internal static ExportImportFileService VHhgXwEAHdaH1ss7ll4F() => ExportImportFileService.DTUCCsEA4sZiWfVCD1aY;

    internal static object N6YhnjEA7Fbn2SUuq4Pd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object FrHKhqEAxanR929xvqAX([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object pkBrdaEA0IWh9aFFZhSY([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object wynmFpEAm5r1oKpQSDwf([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object CaQPOpEAycWysp3eaG3r([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object lFqesbEAMuaHRNbBgfnf([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object Wl0EdYEAJyBhfxtmt9xD([In] object obj0) => (object) ((ExportImportFileServiceBase) obj0).GetFilesFolderPath();

    internal static bool dRxLPnEA9XlPY7HCwWUP([In] object obj0) => Directory.Exists((string) obj0);

    internal static object U0g9eREAdUXBuv0P4Gdf([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object OFs0xUEAl2KwanUODWWY([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ExportImportFileServiceBase) obj0).CreateZipFileName((string) obj1, (string) obj2);

    internal static object pZiuKWEAr0Nbao5LV8JT([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object L6gpKbEAgXKlphmVpp1i([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ExportImportFileServiceBase) obj0).CreateDeployFolderName((string) obj1, (string) obj2);

    internal static object RFZgmpEA5nyDVgqPZ13I([In] object obj0, [In] object obj1) => (object) ((ExportImportFileServiceBase) obj0).CreateFolderName((string) obj1);

    internal static object aNwwAaEAj1RLf5VHqmQW([In] object obj0, [In] object obj1) => (object) ((ExportImportFileServiceBase) obj0).CreateZipFileName((string) obj1);

    internal static bool CAo20JEAYZHGpkd5lsux([In] object obj0) => File.Exists((string) obj0);

    internal static object ArxwShEALwfyYcRrkGhY([In] object obj0) => (object) File.Create((string) obj0);

    internal static void lCrMiuEAU0bcB0Ivmygr([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static void WN3QYSEAsWPkJ44lRdXU([In] object obj0) => ((Stream) obj0).Close();

    internal static void tepa2xEAcJy0nsOKUm4k([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void ptth4aEAzHeiEV2hDrku(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      ((ExportImportFileServiceBase) obj0).AddToNestedFile((string) obj1, (string) obj2, (string) obj3, (string) obj4, (byte[]) obj5);
    }

    internal static object oMWFF7E7FW9Xaw2nDOgR([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static object AlhjZEE7BoSCDxnP10Lw([In] object obj0, [In] object obj1, long i, [In] object obj3) => (object) ((ExportImportFileServiceBase) obj0).LoadFile((string) obj1, i, (string) obj3);

    internal static long bLPoLdE7WxaX6WWCd6BN([In] object obj0) => ((Stream) obj0).Length;

    internal static long YURYfBE7obyeNTmjPWTT([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void EcUmqkE7b5n5hREJdtUX([In] object obj0, [In] object obj1, [In] object obj2) => ((ExportImportFileServiceBase) obj0).DeleteFiles((string) obj1, (string) obj2);

    internal static void iwPJHaE7h5MGeNtSq9Dk([In] object obj0) => File.Delete((string) obj0);

    internal static void lsWtmCE7GxXE3rW8lVcy([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static bool OIL7AXE7Esgg8Zlg6GcD([In] object obj0, Guid uid, [In] object obj2) => ((ICacheFilesService) obj0).CreateCacheFileByUid(uid, (string) obj2);

    internal static void KWbyIqE7f8VGTgWebV18([In] object obj0, [In] object obj1, [In] object obj2) => ((ExportImportFileServiceBase) obj0).AddToFile((string) obj1, (byte[]) obj2);

    internal static bool t0eHAjE7QWstdYkJOv14([In] object obj0, [In] object obj1, [In] object obj2) => ((ExportImportFileServiceBase) obj0).Exists((string) obj1, (string) obj2);
  }
}

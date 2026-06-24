// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.LocalFsLocationSchema
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Схема сопоставления метаданных в ссылки на местоположение для провайдера хранения на локальной файловой системе.
  /// </summary>
  public class LocalFsLocationSchema : ILocationSchema
  {
    private readonly string filesPath;
    private readonly string tempPath;
    private readonly string previewsPath;
    internal static LocalFsLocationSchema H2xdYeGXnsNJqb9nymyy;

    /// <summary>Ctor</summary>
    /// <param name="filesPath">Путь к папке с постоянно хранимыми файлами.</param>
    /// <param name="tempPath">Путь к папке с временными файлами.</param>
    /// <param name="previewsPath">Путь к папке с файлами предпросмотра.</param>
    public LocalFsLocationSchema(string filesPath, string tempPath, string previewsPath)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.filesPath = filesPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 3:
            this.previewsPath = previewsPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
            continue;
          default:
            this.tempPath = tempPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Превратить метаданные о постоянно хранимом контенте в ссылку на его местоположение.
    /// </summary>
    /// <param name="systemFile">Метаданные о постоянно хранимом контенте.</param>
    /// <returns>Ссылку на местоположение постоянно хранимого контента.</returns>
    public Uri MapPersistentLocation(SystemFile systemFile) => new Uri((string) LocalFsLocationSchema.I54lljGXpngwrjdBwrHw((object) this.filesPath, LocalFsLocationSchema.Pl8Ip2GX3Q6Xqr2AieK3((object) LocalFsLocationSchema.OATvYAGXeKYuIOFnGtm8((object) systemFile), LocalFsLocationSchema.lv2kO5GXNvv44J2ZbY94(LocalFsLocationSchema.T6fimhGX12DPvVQSaWpt(LocalFsLocationSchema.PtKxjEGXP9AMlKh5Eu3J((object) systemFile))))));

    /// <summary>
    /// Превратить уникальный идентификатор контента и путь контента в ссылку на местоположение ресурса предпросмотра.
    /// </summary>
    /// <param name="uid">Уникальный идентификатор контента.</param>
    /// <param name="contentPath">Относительный путь к контенту предпросмотра.</param>
    /// <returns>Ссылка на местоположение контента предпросмотра.</returns>
    public Uri MapPreviewLocation(string uid, string contentPath) => throw new NotImplementedException();

    /// <summary>
    /// По уникальному идентификатору временного контента и расширению файла получить ссылку на местоположение временного контента.
    /// </summary>
    /// <param name="uid">Уникальный идентификатор временного контента. Если указать null, то метод сам сгенерирует идентификатор.</param>
    /// <param name="extension">Расширение временного файла контента.</param>
    /// <returns>Ссылка на местоположение временного контента.</returns>
    public Uri MapTempLocation(string uid, string extension) => new Uri(this.GetTempFileName(extension));

    /// <summary>
    /// Явно сгенерировать случайную ссылку на местоположение временного контента.
    /// </summary>
    /// <param name="extension">Расширение временного файла контента.</param>
    /// <returns>Ссылка на местоположение временного контента.</returns>
    public Uri CreateNewTempLocation(string extension = null) => new Uri(this.GetTempFileName(extension));

    /// <summary>
    /// Перебазировать (сменить точку хранения) исходную ссылку на местоположение исходя из текущей схемы сопоставления.
    /// </summary>
    /// <param name="location">Исходная ссылка на местоположение контента.</param>
    /// <returns>Модифицированная ссылка на местоположение контента.</returns>
    public Uri RemapTempLocationFor(Uri location) => throw new NotSupportedException((string) LocalFsLocationSchema.AP2Up3GXDv1S1E8Moj3L(LocalFsLocationSchema.nvmXncGXaKOWbifEqvww(864270449 << 6 ^ -521289180)));

    private string GetTempFileName(string extension)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            if (LocalFsLocationSchema.bx00NjGXwu3vGt1Wagb3((object) this.tempPath))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 8;
              continue;
            }
            goto case 3;
          case 3:
            Directory.CreateDirectory(this.tempPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 4:
            extension = (string) LocalFsLocationSchema.nvmXncGXaKOWbifEqvww(272623989 ^ 272534179);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 5:
            if (string.IsNullOrEmpty(extension))
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 6:
            extension = (string) LocalFsLocationSchema.nvmXncGXaKOWbifEqvww(589593376 ^ -1977315327 ^ -1459555867) + extension;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 0;
            continue;
          case 7:
            if (!LocalFsLocationSchema.uCj8G3GXtj8V86aydYjl((object) extension, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123638598)))
            {
              num = 6;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_7:
      return (string) LocalFsLocationSchema.I54lljGXpngwrjdBwrHw((object) this.tempPath, LocalFsLocationSchema.UTTKsBGX4VCv1DJ5Tti1((object) Guid.NewGuid().ToString((string) LocalFsLocationSchema.nvmXncGXaKOWbifEqvww(~289714581 ^ -289688542)), (object) extension));
    }

    internal static bool TK71sYGXOv6bj8K1aS9C() => LocalFsLocationSchema.H2xdYeGXnsNJqb9nymyy == null;

    internal static LocalFsLocationSchema g9b5SQGX2yCfUutCgoZp() => LocalFsLocationSchema.H2xdYeGXnsNJqb9nymyy;

    internal static int OATvYAGXeKYuIOFnGtm8([In] object obj0) => ((SystemFile) obj0).Id;

    internal static object PtKxjEGXP9AMlKh5Eu3J([In] object obj0) => (object) ((SystemFile) obj0).Name;

    internal static object T6fimhGX12DPvVQSaWpt([In] object obj0) => (object) ((string) obj0).ReplaceInvalidFileNameChars();

    internal static object lv2kO5GXNvv44J2ZbY94([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object Pl8Ip2GX3Q6Xqr2AieK3([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object I54lljGXpngwrjdBwrHw([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object nvmXncGXaKOWbifEqvww(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object AP2Up3GXDv1S1E8Moj3L([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool uCj8G3GXtj8V86aydYjl([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool bx00NjGXwu3vGt1Wagb3([In] object obj0) => Directory.Exists((string) obj0);

    internal static object UTTKsBGX4VCv1DJ5Tti1([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}

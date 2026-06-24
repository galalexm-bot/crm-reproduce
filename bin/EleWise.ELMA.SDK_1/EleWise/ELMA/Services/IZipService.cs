// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IZipService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Интерфейс сервиса архивации/разархивации</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IZipService
  {
    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    Exception CreateZipFolder(
      string zipFileName,
      string sourceDirectory,
      bool recurse,
      string fileFilter,
      string directoryFilter);

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse);

    /// <summary>Архивировать папку</summary>
    /// <returns>Произведено ли сжатие</returns>
    Exception CreateZipFolder(string zipFileName, string sourceDirectory);

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    Exception ExtractZipFolder(string zipFileName, string targetDirectory, string fileFilter);

    /// <summary>Разархивировать файлы из архива в папку</summary>
    /// <returns>Данные успешно разархивированы</returns>
    Exception ExtractZipFolder(string zipFileName, string targetDirectory);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ExportImportFileServiceBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>
  /// Базовый класс сервиса передачи файлов экспорта-импорта
  /// </summary>
  internal abstract class ExportImportFileServiceBase : IExportImportFileService
  {
    internal static ExportImportFileServiceBase eNSJdnE4LwSEc2uBGDI5;

    /// <inheritdoc />
    public virtual void AddToFile(string id, BinaryFile file) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void AddToFile(string id, byte[] buf) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void AddToNestedFile(string id, string nestedId, string path, byte[] buf) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void AddToNestedFile(
      string id,
      string nestedId,
      string fileExtension,
      string path,
      byte[] buf)
    {
      throw new NotImplementedException();
    }

    /// <inheritdoc />
    public virtual string CreateDeployFolderName(string id) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateDeployFolderName(string id, string folder) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateFileName(string id, string name, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateFileName(string id, string folder, string name, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateFolderName(string id) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateZipFileName(string id) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string CreateZipFileName(string id, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void DeleteFiles(string id) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void DeleteFiles(string id, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual bool Exists(string id, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual bool Exists(string id) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual long GetBufferLength() => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string GetFilesFolderName() => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual string GetFilesFolderPath() => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual byte[] LoadFile(string id, long i) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual byte[] LoadFile(string id, long i, string ext) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual void LoadFileToCache(string fileName, string fullFileName, Guid uid) => throw new NotImplementedException();

    protected ExportImportFileServiceBase()
    {
      ExportImportFileServiceBase.BFAg3lE4cFwC2vZ2vXGl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void BFAg3lE4cFwC2vZ2vXGl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NqEV1RE4UeM3kJUeJCnr() => ExportImportFileServiceBase.eNSJdnE4LwSEc2uBGDI5 == null;

    internal static ExportImportFileServiceBase hNW4TME4sguqqTqwOZkR() => ExportImportFileServiceBase.eNSJdnE4LwSEc2uBGDI5;
  }
}

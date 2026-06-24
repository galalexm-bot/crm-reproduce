// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.DTO.Managers.IBinaryDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;

namespace EleWise.ELMA.Files.DTO.Managers
{
  /// <summary>Менеджер файлов (для работы через Remoting)</summary>
  public interface IBinaryDTOManager : IConfigurationService
  {
    /// <summary>Сохранить файл</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    string SaveFile(BinaryFileDTO binaryFile);

    /// <summary>Загрузить файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    BinaryFileDTO LoadFile(string id);

    /// <summary>Копировать файл</summary>
    /// <param name="sourceBinaryFile"></param>
    /// <returns></returns>
    BinaryFileDTO CopyFile(BinaryFileDTO sourceBinaryFile);
  }
}

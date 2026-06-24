// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IBinaryFileAsyncLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Интерфейс к провайдеру асинхронной загрузки файлов <see cref="T:EleWise.ELMA.Files.BinaryFile" />
  /// </summary>
  public interface IBinaryFileAsyncLoader
  {
    /// <summary>Асинхронно загрузить файл из хранилища файлов.</summary>
    /// <param name="id">Идентификатор файла.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Асинхронная системная задача копирования файла.</returns>
    Task<BinaryFile> LoadFileAsync(string id, CancellationToken token);
  }
}

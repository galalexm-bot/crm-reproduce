// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IBinaryFileStreams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System.IO;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Интерфейс к провайдеру доступа к контенту файлов <see cref="T:EleWise.ELMA.Files.BinaryFile" /> через потоки.
  /// </summary>
  public interface IBinaryFileStreams
  {
    /// <summary>Получить поток для предоставленного файла.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="options">Параметры операции получения контента.</param>
    /// <returns>Поток.</returns>
    Stream GetContent(BinaryFile binaryFile, GetContentOptions options = null);

    /// <summary>Поместить контент в файл из указанного потока.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="content">Контент.</param>
    /// <param name="options">Параметры операции помещения контента.</param>
    /// <exception cref="T:System.InvalidOperationException">Нельзя открыть поток на запись для файла в постоянном хранилище</exception>
    void PutContent(BinaryFile binaryFile, Stream content, PutContentOptions options = null);

    /// <summary>
    /// Асинхронно поместить контент в файл из указанного потока.
    /// </summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="content">Контент.</param>
    /// <param name="options">Параметры операции помещения контента.</param>
    /// <returns>Асинхронную задачу копирования контента.</returns>
    Task PutContentAsync(BinaryFile binaryFile, Stream content, PutContentOptions options = null);
  }
}

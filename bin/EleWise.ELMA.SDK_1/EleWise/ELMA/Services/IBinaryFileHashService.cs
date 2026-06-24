// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IBinaryFileHashService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Интерфейс сервиса хеширования <see cref="T:EleWise.ELMA.Files.BinaryFile" />
  /// </summary>
  public interface IBinaryFileHashService
  {
    /// <summary>Вычислить хеш.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="algorithm">Алгоритм хеширования.</param>
    /// <returns>Хеш.</returns>
    string GetHash(BinaryFile binaryFile, HashAlogrithmEnum algorithm);

    /// <summary>Асинхронно вычислить хеш.</summary>
    /// <param name="binaryFile">Файл.</param>
    /// <param name="algorithm">Алгоритм хеширования.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет работу по вычислению хеша.</returns>
    Task<string> GetHashAsync(
      BinaryFile binaryFile,
      HashAlogrithmEnum algorithm,
      CancellationToken token);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.FileAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.IO;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Класс-помощник для использования с асинхронными методами файлов.
  /// </summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class FileAsync
  {
    private static FileAsync Oi45LshYpPSpGeMNAyJp;

    /// <summary>Открыть существующий файл для асинхронного чтения.</summary>
    /// <param name="path">Путь к файлу.</param>
    /// <returns>Поток FileStream (только на чтение).</returns>
    public static FileStream OpenRead(string path) => new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192, true);

    /// <summary>Открыть существующий файл для асинхронной записи.</summary>
    /// <param name="path">Путь к файлу.</param>
    /// <returns>Поток FileStream (с возможностью записи и монопольным доступом).</returns>
    public static FileStream OpenWrite(string path) => new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 8192, true);

    internal static bool qt0RtChYaucpE7MYOv45() => FileAsync.Oi45LshYpPSpGeMNAyJp == null;

    internal static FileAsync N4N0QMhYDB2Ksy1wnPXj() => FileAsync.Oi45LshYpPSpGeMNAyJp;
  }
}

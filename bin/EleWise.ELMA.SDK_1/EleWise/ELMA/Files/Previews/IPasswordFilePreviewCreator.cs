// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IPasswordFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Расширение IFilePreviewCreator для работы с зашифрованными файлами
  /// </summary>
  public interface IPasswordFilePreviewCreator : IFilePreviewCreator
  {
    /// <summary>
    /// Проверить пароль для файла, или необходимость ввода пароля, если передать <see langword="null" /> в <paramref name="password" />
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль для расшифровки файла</param>
    /// <returns><see langword="true" />, если <paramref name="password" /> правильный, или парль не требуется, когда передан <see langword="null" />, иначе <see langword="false" /></returns>
    bool CheckPassword(BinaryFile file, string password);

    /// <summary>Создать превью</summary>
    /// <param name="path">Путь до файла</param>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль для расшифровки файла</param>
    void Create(string path, BinaryFile file, string password);
  }
}

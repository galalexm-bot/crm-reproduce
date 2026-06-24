// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System.IO;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Работа с превью</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IFilePreviewService
  {
    /// <summary>Добавить файл в очередь на создание предпросмотра</summary>
    /// <param name="file"></param>
    void AddPreviewWork(BinaryFile file, long priority);

    /// <summary>Сгенерировать предпросмотр</summary>
    /// <param name="file"></param>
    void GeneratePreview(BinaryFile file);

    /// <summary>Сгенерировать предпросмотр</summary>
    /// <param name="file">Фай</param>
    /// <param name="fileEncryptPassword">Пароль для расшифровки файла ELMA</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    void GeneratePreview(BinaryFile file, string fileEncryptPassword, string password = null);

    /// <summary>
    /// Извлеч файл из по пути <paramref name="path" /> из архива предпросмотра для файла <paramref name="file" />
    /// </summary>
    /// <param name="file">Фйал</param>
    /// <param name="fileEncryptPassword">Пароль для расшифровки файла ELMA</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <param name="path">Локальный путь файла в архиве (разделитель '/')</param>
    /// <param name="outputStream">Поток для записи содержимого файла</param>
    /// <returns><see langword="true" />, если удалось извлечь файл, иначе <see langword="false" /></returns>
    bool TryExtractFile(
      BinaryFile file,
      string path,
      Stream outputStream,
      string fileEncryptPassword,
      string password = null);

    /// <summary>Удалить предпросмотр для файла</summary>
    /// <param name="file"></param>
    void ClearPreview(BinaryFile file);

    /// <summary>
    /// Получить полный путь до предпросмотра на сервере
    /// Если null, то нет превью
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    string GetPreviewPath(BinaryFile file);

    /// <summary>Получить полный путь до текста предпросмотра</summary>
    /// <param name="file">Файл</param>
    /// <returns></returns>
    string GetTextPreviewPath(BinaryFile file);

    /// <summary>Получить размер текстового файла предпросмотра</summary>
    /// <param name="file">Файл</param>
    /// <returns></returns>
    long GetTextPreviewSize(BinaryFile file);

    /// <summary>Есть ли предпросмотр у файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    bool HasPreview(BinaryFile file);

    /// <summary>Есть ли предпросмотр у файла</summary>
    /// <param name="file"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    bool HasPreview(BinaryFile file, long priority);

    /// <summary>Статус формирования предпросмотра</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    PreviewWorkStatus GetPreviewWorkStatus(BinaryFile file);

    /// <summary>Поддерживвется ли предпросмотр для файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    bool IsSupportPreview(BinaryFile file);

    /// <summary>Получить генератор предпросмотра</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    IFilePreviewCreator GetPreviewCreator(BinaryFile file);

    /// <summary>Путь до папки с предпросмотром</summary>
    string PreviewDir { get; }

    /// <summary>
    /// Получение текстового представления превью для индексации
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    string GetPreviewText(BinaryFile file);

    /// <summary>
    /// Проверить пароль для файла, или необходимость ввода пароля, если передать <see langword="null" /> в <paramref name="password" />
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <returns><see langword="true" />, если <paramref name="password" /> правильный, или парль не требуется, когда передан <see langword="null" />, иначе <see langword="false" /></returns>
    bool CheckPassword(BinaryFile file, string password);

    /// <summary>
    /// Проверить пароль для файла, или необходимость ввода пароля, если передать <see langword="null" /> в <paramref name="password" />
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="fileEncryptPassword">Пароль для расшифровки файла ELMA</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <returns><see langword="true" />, если <paramref name="password" /> правильный, или парль не требуется, когда передан <see langword="null" />, иначе <see langword="false" /></returns>
    bool CheckPassword(BinaryFile file, string fileEncryptPassword, string password);
  }
}

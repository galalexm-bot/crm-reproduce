// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewServiceProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Провайдер сервиса генерации предпросмотра файлов</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IFilePreviewServiceProvider
  {
    /// <summary>Uid провайдера</summary>
    Guid ProviderUid { get; }

    /// <summary>Добавить файл в очередь</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <param name="priority">Приоритет</param>
    void AddFileToQueue(string fileId, long priority);

    /// <summary>Удалить файл из очереди</summary>
    /// <param name="fileId">Идентификатор файла</param>
    void DeleteFileFromQueue(string fileId);

    /// <summary>Получить статус формирования предпросмотра для файла</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <returns>Статус формирования</returns>
    PreviewWorkStatus GetFilePreviewWorkStatus(string fileId);

    /// <summary>Получить генератор предпросмотра для файла</summary>
    /// <param name="file">Бинарный файл</param>
    /// <returns>Генератор</returns>
    IFilePreviewCreator GetFilePreviewCreator(BinaryFile file);

    /// <summary>Сгенерировать файл предпросмотра</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <param name="fileEncryptPassword">Пароль для расшифровки файла ELMA</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <returns></returns>
    bool GeneratePreview(string fileId, string fileEncryptPassword, string password = null);

    /// <summary>
    /// Проверить пароль для файла, или необходимость ввода пароля, если передать <see langword="null" /> в <paramref name="password" />
    /// </summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <returns><see langword="true" />, если <paramref name="password" /> правильный, или парль не требуется, когда передан <see langword="null" />, иначе <see langword="false" /></returns>
    bool CheckPassword(string fileId, string password);

    /// <summary>
    /// Проверить пароль для файла, или необходимость ввода пароля, если передать <see langword="null" /> в <paramref name="password" />
    /// </summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <param name="fileEncryptPassword">Пароль для расшифровки файла ELMA</param>
    /// <param name="password">Пароль для расшифровки файла (собственное шифрование формата)</param>
    /// <returns><see langword="true" />, если <paramref name="password" /> правильный, или парль не требуется, когда передан <see langword="null" />, иначе <see langword="false" /></returns>
    bool CheckPassword(string fileId, string fileEncryptPassword, string password);
  }
}

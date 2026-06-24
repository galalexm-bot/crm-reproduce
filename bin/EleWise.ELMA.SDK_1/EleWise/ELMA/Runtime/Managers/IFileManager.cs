// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IFileManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Интерфейс для менеджера файлов</summary>
  /// <example>
  /// <code>
  /// //С помощью данного сервиса можно сохранять и загружать файлы, переименовывать файлы,
  /// //узнать существование файла, размер файла, шифровать и расшифровывать файлы.
  /// //Работа с файлами ведёться в хранилище
  /// 
  /// //запишем сервис в переменную, чтобы с ним легче было работать
  /// <![CDATA[var service = Locator.GetServiceNotNull<IFileManager>();]]>
  /// 
  /// //Чтобы сохранить файл, используйте функцию SaveFile(binaryFile)
  /// //Данная функция возвращает идентификатор файла в строковом представлении
  /// var stringId = service.SaveFile(binaryFile);
  /// 
  /// //Чтобы загрузить файлы, используйте следующие функции:
  /// //1.LoadFile(id) - загрузка одного файла по идентификатору
  /// var file = service.LoadFile(id);
  /// 
  /// //2.LoadFiles(idList) - загрузка списка файлов по идентификаторам
  /// //idList - массив идентификаторов файлов
  /// var files = service.LoadFiles(idList);
  /// 
  /// //Чтобы проверить существование файла, используйте функцию FileExists(id)
  /// var fileExists = service.FileExists(id);
  /// 
  /// //Чтобы узнать размер файла, используйте функцию FileSize(id)
  /// var fileSize = service.FileSize(id);
  /// 
  /// //Чтобы переименовать файл, используйте функцию RenameFile(id, fileName)
  /// var newFileName = service.RenameFile(id, fileName);
  /// 
  /// //Чтобы скопировать файл, используйте функцию CopyFile(sourceBinaryFile)
  /// var newBinaryFile = service.CopyFile(sourceBinaryFile);
  /// 
  /// //Чтобы зашифровать файл, используйте функцию Encrypt(file, password, salt)
  /// service.Encrypt(file, password, salt);
  /// 
  /// //Чтобы расшифровать файл, используйте функцию Decrypt(file, password)
  /// var decryptedBinaryFile = service.Decrypt(file, password);
  /// 
  /// //Чтобы отменить шифрование файла, используйте функцию CancelEncrypt(file, password)
  /// service.CancelEncrypt(file, password);
  /// </code>
  /// </example>
  [PublicApiMember("FileServicesApi", "SR.M('Сервис для работы с файлами')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно сохранять и загружать файлы, переименовывать файлы,\r\n    /// //узнать существование файла, размер файла, шифровать и расшифровывать файлы.\r\n    /// //Работа с файлами ведёться в хранилище\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.File;\r\n    /// \r\n    /// //Чтобы сохранить файл, используйте функцию SaveFile(binaryFile)\r\n    /// //Данная функция возвращает идентификатор файла в строковом представлении\r\n    /// var stringId = service.SaveFile(binaryFile);\r\n    /// \r\n    /// //Чтобы загрузить файлы, используйте следующие функции:\r\n    /// //1.LoadFile(id) - загрузка одного файла по идентификатору\r\n    /// var file = service.LoadFile(id);\r\n    /// \r\n    /// //2.LoadFiles(idList) - загрузка списка файлов по идентификаторам\r\n    /// //idList - массив идентификаторов файлов\r\n    /// var files = service.LoadFiles(idList);\r\n    /// \r\n    /// //Чтобы проверить существование файла, используйте функцию FileExists(id)\r\n    /// var fileExists = service.FileExists(id);\r\n    /// \r\n    /// //Чтобы узнать размер файла, используйте функцию FileSize(id)\r\n    /// var fileSize = service.FileSize(id);\r\n    /// \r\n    /// //Чтобы переименовать файл, используйте функцию RenameFile(id, fileName)\r\n    /// var newFileName = service.RenameFile(id, fileName);\r\n    /// \r\n    /// //Чтобы скопировать файл, используйте функцию CopyFile(sourceBinaryFile)\r\n    /// var newBinaryFile = service.CopyFile(sourceBinaryFile);\r\n    /// \r\n    /// //Чтобы зашифровать файл, используйте функцию Encrypt(file, password, salt)\r\n    /// service.Encrypt(file, password, salt);\r\n    /// \r\n    /// //Чтобы расшифровать файл, используйте функцию Decrypt(file, password)\r\n    /// var decryptedBinaryFile = service.Decrypt(file, password);\r\n    /// \r\n    /// //Чтобы отменить шифрование файла, используйте функцию CancelEncrypt(file, password)\r\n    /// service.CancelEncrypt(file, password);\r\n    /// </code>')")]
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IFileManager
  {
    /// <summary>Папка для хранения временных файлов</summary>
    string TempFilesPath { get; }

    /// <summary>Папка для хранения временных файлов</summary>
    string FilesPath { get; }

    /// <summary>Папка для хранения предпросмотров</summary>
    string PreviewsPath { get; }

    /// <summary>Ключ элемента контекста</summary>
    string ContextItemsKey { get; }

    /// <summary>Ключ процесса хранения</summary>
    string ProcessStoreKey { get; }

    /// <summary>Сохранить файл</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    [PublicApiNodeId("FileServicesApi")]
    string SaveFile(BinaryFile binaryFile);

    /// <summary>Загрузить файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    [PublicApiNodeId("FileServicesApi")]
    BinaryFile LoadFile(string id);

    /// <summary>Загрузить файлы</summary>
    /// <param name="idList">Массив идентификаторов файлов</param>
    /// <returns>Загруженные файлы</returns>
    [PublicApiNodeId("FileServicesApi")]
    BinaryFile[] LoadFiles(string[] idList);

    /// <summary>Проверить, существует ли файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>True, если существует</returns>
    [PublicApiNodeId("FileServicesApi")]
    bool FileExists(string id);

    /// <summary>Получить размер файла из хранилища</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Размер файла в байтах</returns>
    [PublicApiNodeId("FileServicesApi")]
    long FileSize(string id);

    /// <summary>Переименовать файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Новое имя файла, после обрезания спец. символов</returns>
    [PublicApiNodeId("FileServicesApi")]
    string RenameFile(string id, string fileName);

    /// <summary>Копировать файл</summary>
    /// <param name="sourceBinaryFile">Бинарный файл источник</param>
    /// <returns>Файл</returns>
    [PublicApiNodeId("FileServicesApi")]
    BinaryFile CopyFile(BinaryFile sourceBinaryFile);

    /// <summary>Зашифровать файл</summary>
    /// <param name="file">Файл, который нужно зашифровать</param>
    /// <param name="password">Пароль</param>
    /// <param name="salt">Соль</param>
    [PublicApiNodeId("FileServicesApi")]
    void Encrypt(BinaryFile file, string password, string salt);

    /// <summary>
    /// Расшифровать файл (будет создаваться темповый файл на сервере)
    /// </summary>
    /// <param name="file">Файл, который нужно расшифровать</param>
    /// <param name="password">Пароль</param>
    [PublicApiNodeId("FileServicesApi")]
    BinaryFile Decrypt(BinaryFile file, string password);

    /// <summary>Отмена шифрования для файла</summary>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль</param>
    [PublicApiNodeId("FileServicesApi")]
    void CancelEncrypt(BinaryFile file, string password);
  }
}

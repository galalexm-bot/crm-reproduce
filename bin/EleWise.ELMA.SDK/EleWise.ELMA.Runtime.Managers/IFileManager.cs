using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Managers;

[PublicApiMember("FileServicesApi", "SR.M('Сервис для работы с файлами')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно сохранять и загружать файлы, переименовывать файлы,\r\n    /// //узнать существование файла, размер файла, шифровать и расшифровывать файлы.\r\n    /// //Работа с файлами ведёться в хранилище\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.File;\r\n    /// \r\n    /// //Чтобы сохранить файл, используйте функцию SaveFile(binaryFile)\r\n    /// //Данная функция возвращает идентификатор файла в строковом представлении\r\n    /// var stringId = service.SaveFile(binaryFile);\r\n    /// \r\n    /// //Чтобы загрузить файлы, используйте следующие функции:\r\n    /// //1.LoadFile(id) - загрузка одного файла по идентификатору\r\n    /// var file = service.LoadFile(id);\r\n    /// \r\n    /// //2.LoadFiles(idList) - загрузка списка файлов по идентификаторам\r\n    /// //idList - массив идентификаторов файлов\r\n    /// var files = service.LoadFiles(idList);\r\n    /// \r\n    /// //Чтобы проверить существование файла, используйте функцию FileExists(id)\r\n    /// var fileExists = service.FileExists(id);\r\n    /// \r\n    /// //Чтобы узнать размер файла, используйте функцию FileSize(id)\r\n    /// var fileSize = service.FileSize(id);\r\n    /// \r\n    /// //Чтобы переименовать файл, используйте функцию RenameFile(id, fileName)\r\n    /// var newFileName = service.RenameFile(id, fileName);\r\n    /// \r\n    /// //Чтобы скопировать файл, используйте функцию CopyFile(sourceBinaryFile)\r\n    /// var newBinaryFile = service.CopyFile(sourceBinaryFile);\r\n    /// \r\n    /// //Чтобы зашифровать файл, используйте функцию Encrypt(file, password, salt)\r\n    /// service.Encrypt(file, password, salt);\r\n    /// \r\n    /// //Чтобы расшифровать файл, используйте функцию Decrypt(file, password)\r\n    /// var decryptedBinaryFile = service.Decrypt(file, password);\r\n    /// \r\n    /// //Чтобы отменить шифрование файла, используйте функцию CancelEncrypt(file, password)\r\n    /// service.CancelEncrypt(file, password);\r\n    /// </code>')")]
[DeveloperApi(DeveloperApiType.Service)]
public interface IFileManager
{
	string TempFilesPath { get; }

	string FilesPath { get; }

	string PreviewsPath { get; }

	string ContextItemsKey { get; }

	string ProcessStoreKey { get; }

	[PublicApiNodeId("FileServicesApi")]
	string SaveFile(BinaryFile binaryFile);

	[PublicApiNodeId("FileServicesApi")]
	BinaryFile LoadFile(string id);

	[PublicApiNodeId("FileServicesApi")]
	BinaryFile[] LoadFiles(string[] idList);

	[PublicApiNodeId("FileServicesApi")]
	bool FileExists(string id);

	[PublicApiNodeId("FileServicesApi")]
	long FileSize(string id);

	[PublicApiNodeId("FileServicesApi")]
	string RenameFile(string id, string fileName);

	[PublicApiNodeId("FileServicesApi")]
	BinaryFile CopyFile(BinaryFile sourceBinaryFile);

	[PublicApiNodeId("FileServicesApi")]
	void Encrypt(BinaryFile file, string password, string salt);

	[PublicApiNodeId("FileServicesApi")]
	BinaryFile Decrypt(BinaryFile file, string password);

	[PublicApiNodeId("FileServicesApi")]
	void CancelEncrypt(BinaryFile file, string password);
}

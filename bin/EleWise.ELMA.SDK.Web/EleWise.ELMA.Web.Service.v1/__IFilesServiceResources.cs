namespace EleWise.ELMA.Web.Service.v1;

internal class __IFilesServiceResources
{
	public static string Description => SR.T("Сервис для работы с бинарными файлами");

	public static string FileSizeDescription => SR.T("Получить размер файла");

	public static string FileSizeResultDescription => SR.T("Размер файла в байтах");

	public static string FileSizeUidParamDescription => SR.T("Идентификатор файла");

	public static string DownloadDescription => SR.T("Скачать файл с сервера. Поддерживается докачка файла через заголовок \"Range\" по стандарту rfc2616, с ограничением на один интервал");

	public static string DownloadResultDescription => SR.T("Содержимое файла в потоке");

	public static string DownloadUidParamDescription => SR.T("Идентификатор файла");

	public static string PreviewFileTypesDescription => SR.T("Список расширений файлов, для которых генерится превью в HTML");

	public static string PreviewFileTypesResultDescription => SR.T("Список расширений файлов");

	public static string DownloadPreviewDescription => SR.T("Скачать превью файла с сервера в формате ZIP. Поддерживается докачка файла через заголовок \"Range\" по стандарту rfc2616, с ограничением на один интервал");

	public static string DownloadPreviewResultDescription => SR.T("Превью файла в потоке в формате ZIP");

	public static string DownloadPreviewUidParamDescription => SR.T("Идентификатор файла");

	public static string UploadDescription => SR.T("Закачать файл на сервер. Имя файла должно передаваться в заголовоке запроса \"FileName\", при этом необходимо имя кодировать в формат URLEncode. Если временный файл ранее уже передавался то можно передать заголовок \"FileGuid\"");

	public static string UploadResultDescription => SR.T("Идентификатор файла");

	public static string UploadBodyParamDescription => SR.T("Содержимое файла в потоке");
}

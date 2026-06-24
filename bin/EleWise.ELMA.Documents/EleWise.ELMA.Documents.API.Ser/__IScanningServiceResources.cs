namespace EleWise.ELMA.Documents.API.Service.v1;

internal class __IScanningServiceResources
{
	public static string SetStatusScanedFileDescription => SR.T("Установить статус для сканируемого файла: 0 - начато сканирование, 1 - идет сканирование,  2 - сканирование успешно завершено, 3 - сканирование закончено с ошибкой, 4 - сканирование отменено");

	public static string GetStatusScanedFileDescription => SR.T("Получить статус для сканируемого файла: 0 - начато сканирование, 1 - идет сканирование,  2 - сканирование успешно завершено, 3 - сканирование закончено с ошибкой, 4 - сканирование отменено");

	public static string ScanedFileSendStartDescription => SR.T("Подготовка передачи сканированного файла на сервер");

	public static string ScanedFileSendEndDescription => SR.T("Завершить передачу сканируемого файла");
}

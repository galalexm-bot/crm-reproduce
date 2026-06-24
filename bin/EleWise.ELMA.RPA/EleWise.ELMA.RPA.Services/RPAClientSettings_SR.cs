namespace EleWise.ELMA.RPA.Services;

internal static class RPAClientSettings_SR
{
	public static string P_ServerAddress => SR.T("Адрес сервера RPA");

	public static string P_ProcessRepositoryServicePort => SR.T("Порт сервиса репозитория процессов");

	public static string P_TaskServicePort => SR.T("Порт сервиса работы с задачами");

	public static string P_AuthToken => SR.T("Токен авторизации");

	public static string P_SystemName => SR.T("Имя системы");

	public static string P_PollingTimer => SR.T("Таймер опроса сервера RPA (в минутах)");
}

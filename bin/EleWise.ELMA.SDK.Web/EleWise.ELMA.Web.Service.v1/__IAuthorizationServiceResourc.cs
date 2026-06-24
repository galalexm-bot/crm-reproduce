namespace EleWise.ELMA.Web.Service.v1;

internal class __IAuthorizationServiceResources
{
	public static string Description => SR.T("Сервис для авторизации пользователей");

	public static string VersionDescription => SR.T("Получить текущую версию сервера");

	public static string VersionResultDescription => SR.T("Текущая версия сервера");

	public static string ApiVersionDescription => SR.T("Получить текущую версию API сервера");

	public static string ApiVersionResultDescription => SR.T("Текущая версия API сервера");

	public static string ServerTimeDescription => SR.T("Получить текущее серверное время");

	public static string ServerTimeResultDescription => SR.T("Текущее серверное время в локальном формате");

	public static string ServerTimeUTCDescription => SR.T("Получить текущее серверное время в формате UTC");

	public static string ServerTimeUTCResultDescription => SR.T("Текущее серверное время в формате UTC");

	public static string CheckTokenDescription => SR.T("Проверить токен авторизации и получить ИД пользователя");

	public static string CheckTokenResultDescription => SR.T("Результат авторизации");

	public static string CheckTokenTokenParamDescription => SR.T("Токен авторизации");

	public static string RefreshTokenDescription => SR.T("Обновить JWT токен с помощью токена обновления авторизации");

	public static string RefreshTokenResultDescription => SR.T("Результат авторизации");

	public static string RefreshTokenTokenParamDescription => SR.T("Токен обновления авторизации");

	public static string LoginWithBasicDescription => SR.T("Авторизовать пользователя по протоколу Basic");

	public static string LoginWithBasicResultDescription => SR.T("Результат авторизации");

	public static string LoginWithUserNameDescription => SR.T("Авторизовать пользователя по логину и паролю");

	public static string LoginWithUserNameResultDescription => SR.T("Результат авторизации");

	public static string LoginWithUserNameUsernameParamDescription => SR.T("Логин пользователя");

	public static string LoginWithUserNamePasswordParamDescription => SR.T("Пароль пользователя");

	public static string LoginJwtDescription => SR.T("Авторизовать пользователя по логину и паролю. Результат авторизации JWT токен");

	public static string LoginJwtResultDescription => SR.T("Результат авторизации");

	public static string LoginJwtUsernameParamDescription => SR.T("Логин пользователя");

	public static string LoginJwtPasswordParamDescription => SR.T("Пароль пользователя");

	public static string LoginWithSspiTicketDescription => SR.T("Авторизовать пользователя по тикету сквозной авторизации SSPI");

	public static string LoginWithSspiTicketResultDescription => SR.T("Результат авторизации");

	public static string LoginWithSspiTicketParamDescription => SR.T("Токен SSPI");

	public static string CheckPermissionsDescription => SR.T("Проверить привилегии");

	public static string CheckPermissionsResultDescription => SR.T("Результат проверки привилегий");

	public static string CheckPermissionsRequestListParamDescription => SR.T("Запрос на проверку привилегий");

	public static string TemporaryGuidDescription => SR.T("Получить временный токен авторизации. Можно использовать его в запросе как параметр TemporaryGuid");

	public static string TemporaryGuidResultDescription => SR.T("Временный токен авторизации");

	public static string ApplicationLogOutDescription => SR.T("Выйти из учетной записи с использованием токена внешнего приложения");

	public static string ApplicationLogOutTokenParamDescription => SR.T("Токен приложения");

	public static string ApplicationLogOutResultDescription => SR.T("Результат удаления информации о сессии");
}

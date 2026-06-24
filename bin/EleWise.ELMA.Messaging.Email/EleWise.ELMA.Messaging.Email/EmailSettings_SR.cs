namespace EleWise.ELMA.Messaging.Email;

internal static class EmailSettings_SR
{
	public static string P_Enabled => SR.T("Уведомления по E-Mail");

	public static string P_SmtpHost => SR.T("Сервер исходящей почты (SMTP)");

	public static string P_SmtpPort => SR.T("Номер порта (по умолчанию {0})", 25);

	public static string P_SmtpEnableSsl => SR.T("Использовать SSL");

	public static string P_SmtpSSLType => SR.T("Защита соединения");

	public static string P_SenderName => SR.T("Имя отправителя");

	public static string P_SenderEMail => SR.T("Почтовый ящик отправителя");

	public static string P_SubjectPrefix => SR.T("Префикс в теме сообщения");

	public static string P_BodyFooterSeparator => SR.T("Разделитель для подписи в сообщении");

	public static string P_BodyFooter => SR.T("Текстовая подпись в сообщении");

	public static string P_SmtpCredentials => SR.T("Сервер с аутентификацией");

	public static string P_SmtpUserName => SR.T("Имя пользователя");

	public static string P_SmtpPassword => SR.T("Пароль");

	public static string P_SmtpEncoding => SR.T("Кодировка");

	public static string P_Timeout => SR.T("Таймаут отправки письма (в секундах)");

	public static string P_MaxAttachmensSize => SR.T("Максимальный размер вложений в письмо (в MB)");

	public static string P_IsHtmlFooter => SR.T("Формат данных в подписи для сообщений системы");

	public static string P_HtmlBodyFooter => SR.T("Html подпись в сообщении");

	public static string P_IncludeHeaderInBody => SR.T("Добавлять заголовок в тело сообщения");
}

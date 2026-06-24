namespace EleWise.ELMA.Messages.Mobile.API.Interfaces;

internal class MessageFeedServiceExtensionResources
{
	public static string Description => SR.T("Сервис для работы мобильного приложения с сообщениями");

	public static string GetPostDescription => SR.T("Получить сообщение ленты");

	public static string FeedPostDescription => SR.T("Элемент ленты сообщений");

	public static string ParentObjectIdDescription => SR.T("Идентификатор родительского сообщения в формате Int64");

	public static string ParentObjectUidDescription => SR.T("Уникальный идентификатор родительского сообщения в формате Guid");

	public static string RecipientIdDescription => SR.T("Идентификатор получателя сообщения в формате Int64");
}

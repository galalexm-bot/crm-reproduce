namespace EleWise.ELMA.Messages.Models;

internal class __Resources_IInformationChannel
{
	public static string DisplayName => SR.T("Информационный канал");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Name_DisplayName => SR.T("Название");

	public static string P_IsCommentable_DisplayName => SR.T("Комментируемый");

	public static string P_IsCommentable_Description => SR.T("Возможность комментирования сообщений в информационном канале.");

	public static string P_IsActive_DisplayName => SR.T("Активный");

	public static string P_IsActive_Description => SR.T("Разрешение на отправку сообщений внутри информационного канала. Неактивный информационный канал доступен только для просмотра.");

	public static string P_IsSubscriptionManagementDenied_DisplayName => SR.T("Запретить управлять подпиской на канал");

	public static string P_IsSubscriptionManagementDenied_Description => SR.T("Да - на информационный канал будут принудительно подписаны все, у кого есть права на него. Нет - пользователи, у которых есть права на канал, смогут сами подписаться на него для отображения его в списке каналов.");

	public static string P_CreationDate_DisplayName => SR.T("Дата создания");

	public static string P_CreationAuthor_DisplayName => SR.T("Автор");

	public static string P_ChangeDate_DisplayName => SR.T("Дата изменения");

	public static string P_ChangeAuthor_DisplayName => SR.T("Изменил");

	public static string P_Description_DisplayName => SR.T("Описание");

	public static string P_ChannelType_DisplayName => SR.T("Открытый канал");

	public static string P_ChannelType_Description => SR.T("На открытый информационный канал может подписаться любой сотрудник организации. Закрытым каналом управляют администраторы.");

	public static string P_Permissions_DisplayName => SR.T("Привилегии");

	public static string P_DisplayName_DisplayName => SR.T("Отображаемое имя");

	public static string P_Messages_DisplayName => SR.T("Сообщения");

	public static string P_Subscribers_DisplayName => SR.T("Подписчики на канал");

	public static string P_GroupUid_DisplayName => SR.T("Группа");

	public static string P_IsArchive_DisplayName => SR.T("Архивный");

	public static string P_IsArchive_Description => SR.T("Архивный информационный канал отображается в группе архивных каналов и не доступен для отправки сообщений.");

	public static string P_FeedPriority_DisplayName => SR.T("Важность");

	public static string P_FeedPriority_Description => SR.T("Важность, которая будет устанавливаться отправляемым сообщениям информационного канала, в ленте сообщений.");

	public static string FP_Assigned_DisplayName => SR.T("Каналы, на которые подписан пользователь");

	public static string FP_NotGroupUid_DisplayName => SR.T("Все, кроме группы");

	public static string FP_WithoutIds_DisplayName => SR.T("Исключить каналы");

	public static string FP_Ids_DisplayName => SR.T("Список идентификаторов");
}
internal class __Resources_IInformationChannelPermission
{
	public static string DisplayName => SR.T("Привилегия на информационный канал");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Channel_DisplayName => SR.T("Канал");

	public static string P_PermissionId_DisplayName => SR.T("Привилегия");

	public static string P_User_DisplayName => SR.T("Пользователь");

	public static string P_Group_DisplayName => SR.T("Группа пользователей");

	public static string P_OrganizationItemPosition_DisplayName => SR.T("Должность");

	public static string P_OrganizationItem_DisplayName => SR.T("Отдел");

	public static string P_UserSecuritySetCacheId_DisplayName => SR.T("UserSecuritySetCacheId");

	public static string P_PermissionRole_DisplayName => SR.T("Роль");
}
internal class __Resources_IInformationChannelSubscriber
{
	public static string DisplayName => SR.T("Подписчик на информационный канал");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_User_DisplayName => SR.T("Пользователь");

	public static string P_Channel_DisplayName => SR.T("Информационный канал");
}

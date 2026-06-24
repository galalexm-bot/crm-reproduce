namespace EleWise.ELMA.Content.Models;

internal class __Resources_IMenuItem
{
	public static string DisplayName => SR.T("Элемент веб меню");

	public static string Description => SR.T("Элемент веб меню, входит в совокупность элементов веб меню, предназначен для перехода в соответствующий раздел системы, вызова действия.");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Menu_DisplayName => SR.T("Меню");

	public static string P_Menu_Description => SR.T("Веб меню в которое входит элемент меню");

	public static string P_ParentItem_DisplayName => SR.T("Родительский элемент меню");

	public static string P_ParentItem_Description => SR.T("Ссылка на родительский элемент веб меню");

	public static string P_Name_DisplayName => SR.T("Название");

	public static string P_Name_Description => SR.T("Наименование элемента веб меню");

	public static string P_Description_DisplayName => SR.T("Описание");

	public static string P_Description_Description => SR.T("Описание элемента веб меню");

	public static string P_ImageUrl_DisplayName => SR.T("Картинка");

	public static string P_ImageUrl_Description => SR.T("Путь до изображения, отображаемого в элементе веб меню");

	public static string P_NavigateUrl_DisplayName => SR.T("Путь");

	public static string P_NavigateUrl_Description => SR.T("не описывать");

	public static string P_Disabled_DisplayName => SR.T("Отключен");

	public static string P_Disabled_Description => SR.T("Текущий статус элемента веб меню, при Отключен=\"Да\" элемент не отображается в веб меню.");

	public static string P_Weight_DisplayName => SR.T("Порядок");

	public static string P_Weight_Description => SR.T("Определяет порядок отображения элементов в веб меню или в родительском элементе веб меню.");

	public static string P_ExtensionPointName_DisplayName => SR.T("Имя точки расширения");

	public static string P_ExtensionPointName_Description => SR.T("не описывать");

	public static string P_LinkedWithAction_DisplayName => SR.T("Привязан к действию");

	public static string P_LinkedWithAction_Description => SR.T("Определяет является или нет элемент веб меню действием");

	public static string P_ActionTypeProviderId_DisplayName => SR.T("Идентификатор типа ссылки");

	public static string P_ActionId_DisplayName => SR.T("Идентификатор ссылки");

	public static string P_Code_DisplayName => SR.T("Code");

	public static string P_Code_Description => SR.T("Служебный идентификатор элемента веб меню");

	public static string P_OnTop_DisplayName => SR.T("Наверху");

	public static string P_OnTop_Description => SR.T("Если \"Да\" то выбранный элемент перемещается наверх, вне зависимости от \"Порядка\"\r\n");

	public static string P_Stretch_DisplayName => SR.T("Растягивать");

	public static string P_Stretch_Description => SR.T("Определяет показывать выбранный пункт меню на полную высоту экрана или нет, при этом при активации данного элемента другие неактивные элементы веб меню скрываются");

	public static string P_Type_DisplayName => SR.T("Тип");

	public static string P_Type_Description => SR.T("Определяет базовый тип элемента веб меню (Группа, Разделитель, Действие)");

	public static string P_Permissions_DisplayName => SR.T("Привилегии");

	public static string P_MenuUid_DisplayName => SR.T("Уникальный идентификатор элемента меню");

	public static string P_MenuUid_Description => SR.T("Идентификатор элемента меню, уникальный в рамках меню.\r\nУникальность идентификатора между различными меню не обеспечивается.");

	public static string P_Color_DisplayName => SR.T("Цвет");

	public static string P_Color_Description => SR.T("Используется для указания цвета группы кнопок в главном меню.\r\nМожет принимать одно из следующих значений:\r\n - blue\r\n - gray\r\n - green\r\n - red\r\n - yellow\r\n");

	public static string P_Target_DisplayName => SR.T("Target");

	public static string P_Target_Description => SR.T("Как открывать ссылку");
}

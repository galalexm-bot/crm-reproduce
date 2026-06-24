namespace EleWise.ELMA.Tasks.Models;

internal class __Resources_ITaskBase
{
	public static string DisplayName => SR.T("Базовый класс задачи");

	public static string Description => SR.T("Базовый класс задачи/поручения в системе");

	public static string P_ExecutorReplaced_DisplayName => SR.T("Исполнитель (Замещаемый)");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Subject_DisplayName => SR.T("Тема");

	public static string P_Description_DisplayName => SR.T("Описание");

	public static string P_CreationDate_DisplayName => SR.T("Дата создания");

	public static string P_CreationAuthor_DisplayName => SR.T("Автор");

	public static string P_Executor_DisplayName => SR.T("Исполнитель");

	public static string P_StartDate_DisplayName => SR.T("Дата начала");

	public static string P_EndDate_DisplayName => SR.T("Срок завершения");

	public static string P_Priority_DisplayName => SR.T("Приоритет");

	public static string P_Comments_DisplayName => SR.T("Комментарии");

	public static string P_Tags_DisplayName => SR.T("Ярлыки");

	public static string P_Tags_Description => SR.T("Ярлыки присовенные задаче пользователем, перечень ярлыков создается пользовтелями самостоятельно");

	public static string P_ParentTask_DisplayName => SR.T("Родительская задача");

	public static string P_ParentTask_Description => SR.T("Ссылка на родительскую задачу, если текущая задача создана как подзадача в родительской задаче");

	public static string P_ChildTasks_DisplayName => SR.T("Подзадачи");

	public static string P_ChildTasks_Description => SR.T("Перечень подзадач текущей задачи");

	public static string P_Status_DisplayName => SR.T("Статус");

	public static string P_Status_Description => SR.T("Текущий статус задачи");

	public static string P_StartWorkDate_DisplayName => SR.T("Работа начата");

	public static string P_EndWorkDate_DisplayName => SR.T("Работа выполнена");

	public static string P_InformTo_DisplayName => SR.T("Соисполнители");

	public static string P_Harmonizator_DisplayName => SR.T("Согласующий");

	public static string P_TimeSet_DisplayName => SR.T("Время выполнения");

	public static string P_Permissions_DisplayName => SR.T("Привилегии");

	public static string P_NotShowInLists_DisplayName => SR.T("Не отображать в общих списках");

	public static string P_Attachments_DisplayName => SR.T("Все вложения");

	public static string P_InformToHash_DisplayName => SR.T("InformToHash");

	public static string P_Category_DisplayName => SR.T("Категория");

	public static string P_ExpiredNotificationSent_DisplayName => SR.T("Уведомление о просрочке отправлено");

	public static string P_PlanWorkLog_DisplayName => SR.T("Плановые трудозатраты");

	public static string P_IsEmulation_DisplayName => SR.T("Эмуляция");

	public static string P_ExecutorIsEmulation_DisplayName => SR.T("Исполнитель при эмуляции");

	public static string P_FactWorkLog_DisplayName => SR.T("Фактические трудозатраты");

	public static string P_AttachmentsSpecified_DisplayName => SR.T("Вложения");

	public static string P_AttachmentSpecifiedHash_DisplayName => SR.T("AttachmentSpecifiedHash");

	private static string __AllFormsResources => SR.T("Редактирование/Создание");

	public static string FP_Statuses_DisplayName => SR.T("Статусы");

	public static string FP_TimePlannedRange_DisplayName => SR.T("Запланированное время");

	public static string FP_IsPlanned_DisplayName => SR.T("Запланированна");

	public static string FP_TaskId_DisplayName => SR.T("ID");

	public static string FP_TypeUid_DisplayName => SR.T("TypeUid");

	public static string FP_CompleteStatus_DisplayName => SR.T("Статус завершения");

	public static string FP_Executors_DisplayName => SR.T("Исполнители");

	public static string FP_DatePeriod_DisplayName => SR.T("Плановый период");

	public static string FP_DatePeriod_Description => SR.T("Фильтрует по датам StartDate и EndDate");

	public static string FP_TypeUids_DisplayName => SR.T("Типы задач");

	public static string FP_OnlyFromMyDepartment_DisplayName => SR.T("Только от моего отдела");

	public static string FP_OnlyForMyDepartment_DisplayName => SR.T("Только для моего отдела");

	public static string FP_CreationAuthors_DisplayName => SR.T("Авторы");

	public static string FP_ExcludedTypeUids_DisplayName => SR.T("Исключенные типы задач");

	public static string FP_OnlyICoExecutor_DisplayName => SR.T("Только я соисполнитель");
}

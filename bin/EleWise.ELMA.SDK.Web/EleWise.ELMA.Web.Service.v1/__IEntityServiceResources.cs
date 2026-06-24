namespace EleWise.ELMA.Web.Service.v1;

internal class __IEntityServiceResources
{
	public static string Description => SR.T("Сервис для получения записей сущностей");

	public static string HeadDescription => SR.T("Сервис для получения заголовков записей сущностей");

	public static string ChangesDescription => SR.T("Сервис для отслеживания изменений сущностей");

	public static string LoadDescription => SR.T("Получить сущность по типу и идентификатору");

	public static string LoadResultDescription => SR.T("Универсальный объект WebData");

	public static string LoadHeadDescription => SR.T("Получить заголовок сущности по типу и идентификатору");

	public static string LoadHeadResultDescription => SR.T("Универсальный объект WebData");

	public static string FindAllDescription => SR.T("Получить все сущности данного типа");

	public static string FindAllQueryDescription => SR.T("Получить все сущности данного типа, отфильтрованные по запросу");

	public static string FindAllQueryResultDescription => SR.T("Массив объектов WebData");

	public static string CountDescription => SR.T("Получить количество сущностей данного типа");

	public static string CountResultDescription => SR.T("Количество объектов в системе");

	public static string IsSupportedDescription => SR.T("Проверить, поддерживается ли получение изменений для сущностей данного типа");

	public static string IsSupportedResultDescription => SR.T("True, если отслеживание изменений поддерживается");

	public static string FindAllHeadDescription => SR.T("Получить заголовки всех сущностей данного типа");

	public static string FindAllQueryHeadDescription => SR.T("Получить заголовки всех сущностей данного типа, отфильтрованные по запросу");

	public static string FindAllQueryHeadResultDescription => SR.T("Массив объектов WebData");

	public static string QuerySimpleDescription => SR.T("Получить все сущности данного типа, отфильтрованные по запросу, в простой форме");

	public static string QuerySimpleResultDescription => SR.T("Массив объектов WebData");

	public static string FindChangedHeadDescription => SR.T("Получить заголовки всех сущностей данного типа, измененных в интервале от и до указанных дат");

	public static string GetChangedHeadDescription => SR.T("Получить изменения по заданному запросу после указанной даты");

	public static string GetChangedHeadResultDescription => SR.T("Ответ с изменениями");

	public static string SyncChangedHeadDescription => SR.T("Синхонизировать данные на сервере с данными на клиенте");

	public static string SyncChangedHeadResultDescription => SR.T("True, если данные успешно сохранены");

	public static string ChangesCommitDescription => SR.T("Синхонизировать данные на сервере по идентификатору ответа после метода Changes");

	public static string ChangesCommitResultDescription => SR.T("True, если данные синхронизированы на сервере");

	public static string CountChangesDescription => SR.T("Получить количество изменений сущностей данного типа в интервале от и до указанных дат");

	public static string EntityLinkDescription => SR.T("Получить относительную ссылку на карточку сущности в системе");

	public static string EntityLinkResultDescription => SR.T("Относительная ссылка на карточку сущности");

	public static string EntitySaveDescription => SR.T("Сохранить новый объект в системе. Для обновления используйте метод Update");

	public static string EntitySaveResultDescription => SR.T("Идентификатор сохраненного объекта");

	public static string EntityUpdateDescription => SR.T("Обновить существующий объект в системе. Для добавления используйте метод Insert");

	public static string EntityUpdateResultDescription => SR.T("Идентификатор сохраненного объекта");

	public static string typeuidDescription => SR.T("Идентификатор типа сущности");

	public static string entityidDescription => SR.T("Идентификатор объекта. Int64 или Guid");

	public static string selectDescription => SR.T("Список выбираемых свойств, в формате OData v3 $select");

	public static string eqlQueryDescription => SR.T("Запрос на языке EQL. Может быть пустой");

	public static string filterProviderUidDescription => SR.T("Уникальный идентификатор провайдера фильтрации");

	public static string filterProviderDataDescription => SR.T("Данные для провайдера фильтрации");

	public static string filterDescription => SR.T("Значения полей для фильтра сущности в формате: Property1:Значение1,Property2:Значение2\r\nНаименование свойства возможно задавать с точкой (.) для получения доступа к подсвойству: Property1.Property2:Значение1\r\nДля указания в значении свойства символа : (двоеточие), \\ (обратный слэш) или , (запятая), его нужно экранировать черз \\ (обратный слэш)");

	public static string sortDescription => SR.T("Сортировка");

	public static string limitDescription => SR.T("Количество элементов");

	public static string offsetDescription => SR.T("Начальный элемент");

	public static string entityDataDescription => SR.T("Данные объекта в формате WebData");

	public static string searchStringDescription => SR.T("Строка поиска");

	public static string fromServerTimeDescription => SR.T("Серверная дата начала интервала проверки");

	public static string changesCommitIdDescription => SR.T("Идентификатор ответа синхронизации");

	public static string syncChangesDescription => SR.T("Запрос на синхронизацию");

	public static string loadDisplayNameDescription => SR.T("Возвращать отображаемое имя сущности");

	public static string entityTypeSerializationSettings => SR.T("Настройки сериализации по типу");

	public static string userdefinedlistuidDescription => SR.T("Идентификатор пользовательского списка");

	public static string modelsubtypeuidDescription => SR.T("Подтип модуля");
}

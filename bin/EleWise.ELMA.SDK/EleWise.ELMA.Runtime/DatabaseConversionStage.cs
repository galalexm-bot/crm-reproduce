using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime;

internal enum DatabaseConversionStage
{
	[DisplayName("SR.M('Начало преобразования базы данных')")]
	StartDatabaseConversion = 1,
	[DisplayName("SR.M('Создание резервной копии')")]
	Backup,
	[DisplayName("SR.M('Преобразование базы данных: удаление триггеров')")]
	DeleteTriggers,
	[DisplayName("SR.M('Преобразование базы данных: удаление процедур')")]
	DeletingOfProcedures,
	[DisplayName("SR.M('Преобразование базы данных: удаление представлений')")]
	DeletingViews,
	[DisplayName("SR.M('Преобразование базы данных: умное удаление ключей и индексов')")]
	SmartDeleteKeysAndIndexes,
	[DisplayName("SR.M('Преобразование базы данных: удаление внешних ключей')")]
	DeletingForeignKeys,
	[DisplayName("SR.M('Преобразование базы данных: удаление индексов')")]
	IndexRemoval,
	[DisplayName("SR.M('Преобразование базы данных: создание таблиц')")]
	TableCreation,
	[DisplayName("SR.M('Преобразование базы данных: удаление таблиц')")]
	DeleteTables,
	[DisplayName("SR.M('Преобразование базы данных: создание внешних ключей')")]
	CreatingForeignKeys,
	[DisplayName("SR.M('Преобразование базы данных: создание индексов')")]
	IndexCreation,
	[DisplayName("SR.M('Преобразование базы данных: создание представлений')")]
	CreatingViews,
	[DisplayName("SR.M('Преобразование базы данных: создание процедур')")]
	CreationOfProcedures,
	[DisplayName("SR.M('Преобразование базы данных: создание триггеров')")]
	CreateTriggers,
	[DisplayName("SR.M('Завершение преобразования базы данных')")]
	CompleteDatabaseConversion
}

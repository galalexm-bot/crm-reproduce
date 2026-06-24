using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Common.Models.Filters;

public interface IFilterBase : IEntity<long>, IEntity, IIdentified
{
	new long Id { get; set; }

	[DisplayName("SR.M('Наименование')")]
	string Name { get; set; }

	[DisplayName("SR.M('Иконка')")]
	string ImageUrl { get; set; }

	[DisplayName("SR.M('Тип объектов')")]
	ReferenceOnEntityType ObjectsType { get; set; }

	[DisplayName("SR.M('Код для дополнительного разделения фильтров внутри типа')")]
	Guid? Code { get; set; }

	[DisplayName("SR.M('Тип фильтра')")]
	FilterType FilterType { get; set; }

	[DisplayName("SR.M('Развернуть расширенный поиск при открытии фильтра')")]
	bool ExpandSearch { get; set; }

	[DisplayName("SR.M('Поля фильтра')")]
	object FilterFields { get; set; }

	[DisplayName("SR.M('Поля поиска')")]
	object SearchFields { get; set; }

	[DisplayName("SR.M('Настройки отображения колонок таблицы')")]
	byte[] GridState { get; set; }

	[DisplayName("SR.M('Использовать настройки по умолчанию')")]
	bool UseDefaultSettings { get; set; }

	[DisplayName("SR.M('Дата изменения настройки по умолчанию')")]
	DateTime? UseDefaultSettingsDate { get; set; }

	Guid Uid { get; set; }
}

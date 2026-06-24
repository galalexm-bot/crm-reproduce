using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Common.API;

internal class FindByFilterExecutor : PublicServiceMethodExecutor
{
	private const string FilterId = "FilterId";

	private const string FilterTypeUid = "FilterTypeUid";

	private const string Limit = "Limit";

	private const string Offset = "Offset";

	private const string EQLQuery = "EQLQuery";

	private const string Filter = "Filter";

	private const string Sort = "Sort";

	private FilterManager filterManager;

	private IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions;

	private IMetadataRuntimeService metadataRuntimeService;

	public const string MethodName = "FindByFilter";

	private FilterManager FilterManager => filterManager ?? (filterManager = FilterManager.Instance);

	private IEnumerable<IUniqueFilterExtension> UniqueFilterExtensions => uniqueFilterExtensions ?? (uniqueFilterExtensions = ComponentManager.Current.GetExtensionPoints<IUniqueFilterExtension>());

	private IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	public static string MethodDescription => SR.T("Создать событие");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("FilterId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор универсального фильтра")).Type(typeof(long));
	}).ItemWithDescriptor("FilterTypeUid", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор типа фильтра")).Type(typeof(Guid)).Optional();
	}).ItemWithDescriptor("EQLQuery", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Запрос на языке EQL")).Type(typeof(string)).Optional();
	})
		.ItemWithDescriptor("Sort", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Сортировка")).Type(typeof(string)).Optional();
		})
		.ItemWithDescriptor("Limit", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Количество элементов")).Type(typeof(int)).Optional();
		})
		.ItemWithDescriptor("Offset", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Начальный элемент")).Type(typeof(int)).Optional();
		})
		.ItemWithDescriptor("Filter", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Значения полей для фильтра сущности в формате: Property1:Значение1,Property2:Значение2\r\n                                                Наименование свойства возможно задавать с точкой (.) для получения доступа к подсвойству: Property1.Property2:Значение1\r\n                                                Для указания в значении свойства символа : (двоеточие), \\ (обратный слэш) или , (запятая), его нужно экранировать черз \\ (обратный слэш)")).Type(typeof(string)).Optional();
		})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Type(typeof(WebData));
	}).Descriptor;

	public FindByFilterExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		WebDataItem webDataItem = Parameters.FindItem("FilterId");
		if (webDataItem == null || webDataItem.Value == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не найден идентификатор фильтра"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор фильтра должен быть System.Int64"));
		}
		WebDataItem webDataItem2 = Parameters.FindItem("FilterTypeUid");
		IFilterBase filterBase;
		if (webDataItem2 != null && webDataItem2.Value != null)
		{
			if (!Guid.TryParse(webDataItem2.Value, out var result2))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Тип фильтра должен быть System.Guid"));
			}
			filterBase = ModelHelper.GetEntityManager(result2).LoadOrNull(result) as IFilterBase;
		}
		else
		{
			filterBase = FilterManager.LoadOrNull(result);
		}
		if (filterBase == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Фильтр не найден по идентификатору \"{0}\"", result));
		}
		IEntityFilter entityFilter = UniversalFilterSaver.UnPack(filterBase.FilterFields);
		Type filterType = entityFilter?.GetType();
		IUniqueFilterExtension uniqueFilterExtension = ((filterType != null) ? UniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.FilterType == filterType) : null);
		IEntityManager entityManager = null;
		if (uniqueFilterExtension != null)
		{
			entityManager = ModelHelper.GetEntityManager(uniqueFilterExtension.EntityType);
		}
		else if (filterType != null)
		{
			entityManager = ModelHelper.GetEntityManager(MetadataRuntimeService.GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterType).Uid));
		}
		if (entityManager == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось определить тип сущности по фильтру"));
		}
		WebDataItem webDataItem3 = Parameters.FindItem("Limit");
		WebDataItem webDataItem4 = Parameters.FindItem("Offset");
		WebDataItem webDataItem5 = Parameters.FindItem("Sort");
		FetchOptions fetchOptions = null;
		if (webDataItem3 != null || webDataItem4 != null || webDataItem5 != null)
		{
			int result3 = 0;
			if (webDataItem3 != null)
			{
				int.TryParse(webDataItem3.Value, out result3);
			}
			int result4 = 0;
			if (webDataItem4 != null)
			{
				int.TryParse(webDataItem4.Value, out result4);
			}
			string sortExpression = null;
			if (webDataItem5 != null)
			{
				sortExpression = webDataItem5.Value;
			}
			fetchOptions = new FetchOptions(result4, result3, sortExpression);
		}
		WebDataItem webDataItem6 = Parameters.FindItem("Filter");
		if (webDataItem6 != null)
		{
			string value = webDataItem6.Value;
			if (!string.IsNullOrWhiteSpace(value))
			{
				EntityQueryHelper.BindFilterFields(entityFilter, value);
			}
		}
		WebDataItem webDataItem7 = Parameters.FindItem("EQLQuery");
		if (webDataItem7 != null)
		{
			string value2 = webDataItem7.Value;
			if (!string.IsNullOrWhiteSpace(value2))
			{
				entityFilter.Query = value2;
			}
		}
		IEnumerable enumerable = entityManager.Find(entityFilter, fetchOptions);
		List<WebDataItem> list = new List<WebDataItem>();
		foreach (object item in enumerable)
		{
			if (item is IEntity entity)
			{
				WebData data = WebData.CreateFromEntity(entity);
				list.Add(new WebDataItem
				{
					Name = entity.GetId().ToString(),
					Data = data
				});
			}
		}
		return new WebData
		{
			Items = list.ToArray()
		}.UpdateVersion();
	}
}

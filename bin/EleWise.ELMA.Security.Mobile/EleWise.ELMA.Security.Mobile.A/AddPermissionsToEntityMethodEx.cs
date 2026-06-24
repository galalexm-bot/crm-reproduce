using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Mobile.API.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Security.Mobile.API.Services;

internal class AddPermissionsToEntityMethodExecutor : PublicServiceMethodExecutor
{
	private IEntityPermissionService entityPermissionService;

	private IMetadataRuntimeService metadataRuntimeService;

	public const string MethodName = "AddPermissionsToEntity";

	private IEntityPermissionService EntityPermissionService => entityPermissionService ?? (entityPermissionService = Locator.GetServiceNotNull<IEntityPermissionService>());

	private IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	public static string Description => SR.T("Выдать привилегии на объект");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Ids").Descriptor(delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификаторы объектов (Int64)")).Type(typeof(long[])).IsArray();
		});
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Type").Descriptor(delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Уникальный идентификатор типа объекта")).Type(typeof(Guid));
		});
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Items").Descriptor(delegate(TypeSerializationDescriptorBuilder i)
		{
			i.IsArray().Description(SR.T("Информация для выдачи привилегий")).Item(delegate(TypeSerializationItemDescriptorBuilder ai)
			{
				ai.Descriptor(delegate(TypeSerializationDescriptorBuilder aai)
				{
					aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
					{
						ia.Name("PermissionGuids").Descriptor(delegate(TypeSerializationDescriptorBuilder aaai)
						{
							aaai.IsArray().Description(SR.T("Уникальные идентификаторы привилегий")).Type(typeof(string[]));
						});
					});
					aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
					{
						ia.Name("RoleType").Descriptor(delegate(TypeSerializationDescriptorBuilder aaai)
						{
							aaai.Description(SR.T("Тип роли")).Type(typeof(Guid));
						});
					});
					aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
					{
						ia.Name("Id").Descriptor(delegate(TypeSerializationDescriptorBuilder aaai)
						{
							aaai.Description(SR.T("Идентификатор пользователя")).Type(typeof(long));
						});
					});
					aai.Item(delegate(TypeSerializationItemDescriptorBuilder ia)
					{
						ia.Name("EntityId").Descriptor(delegate(TypeSerializationDescriptorBuilder aaai)
						{
							aaai.Description(SR.T("Идентификатор объекта")).Type(typeof(long));
						});
					});
				});
			});
		});
	})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Type(typeof(bool)).Description(SR.T("Результат"));
	}).Descriptor;

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		PermissionAddRequestModel permissionAddRequestModel = ParseRequest();
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(permissionAddRequestModel.Type, loadImplementation: false);
		if (typeByUidOrNull != null)
		{
			EditableListModel editableListModel = new EditableListModel();
			List<EditableListItem> list = new List<EditableListItem>();
			EditableListItemItems[] items = permissionAddRequestModel.Items;
			foreach (EditableListItemItems editableListItemItems in items)
			{
				IEnumerable<string> enumerable = EntityPermissionService.CheckGrantablePermissions(typeByUidOrNull, editableListItemItems.Data, editableListItemItems.Value);
				if (enumerable.Any())
				{
					throw PublicServiceException.CreateWebFault(SR.T("Отсутствуют права на выдачу следующих привилегий: {0}", enumerable.ToCommaSeparatedString()), 500);
				}
				list.Add(new EditableListItem
				{
					Data = editableListItemItems.Data,
					Value = editableListItemItems.Value
				});
			}
			editableListModel.Items = list;
			EntityPermissionService.EntityAddPermissionSave(permissionAddRequestModel.Ids, typeByUidOrNull, editableListModel);
			return new WebData(new Dictionary<string, object> { { "Result", true } });
		}
		throw PublicServiceException.CreateWebFault(SR.T("Ошибка при получении типа сущности"), 500);
	}

	public AddPermissionsToEntityMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	private PermissionAddRequestModel ParseRequest()
	{
		PermissionAddRequestModel permissionAddRequestModel = new PermissionAddRequestModel();
		WebDataItem webDataItem = Parameters.FindItem("Ids");
		if (webDataItem.DataArray != null)
		{
			permissionAddRequestModel.Ids = webDataItem.DataArray.Select((WebData x) => long.Parse(x.Value)).ToArray();
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Type");
		if (webDataItem2 == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения типа сущности"), 500);
		}
		permissionAddRequestModel.Type = Guid.Parse(webDataItem2.Value);
		WebDataItem webDataItem3 = Parameters.FindItem("Items");
		List<EditableListItemItems> list = new List<EditableListItemItems>();
		WebData[] dataArray = webDataItem3.DataArray;
		foreach (WebData obj in dataArray)
		{
			EditableListItemItems editableListItemItems = new EditableListItemItems();
			WebDataItem webDataItem4 = obj.FindItem("RoleType");
			if (webDataItem4.Value == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения типа роли"), 500);
			}
			WebDataItem webDataItem5 = obj.FindItem("Id");
			if (webDataItem5.Value == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения идентификатора пользователя"), 500);
			}
			WebDataItem webDataItem6 = obj.FindItem("EntityId");
			if (webDataItem6.Value == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения идентификатора объекта"), 500);
			}
			WebDataItem webDataItem7 = obj.FindItem("PermissionGuids");
			if (webDataItem7.DataArray != null)
			{
				IEnumerable<string> source = webDataItem7.DataArray.Select((WebData i) => string.Format("{0}{1}{0}", '"', i.Value));
				string text2 = (editableListItemItems.Data = string.Format("[{0}]", string.Join(",", source.ToArray())));
				editableListItemItems.Value = "{" + $"\"ObjectType\":\"{webDataItem4.Value}\",\"Id\":{webDataItem5.Value},\"EntityId\": {webDataItem6.Value}" + "}";
				list.Add(editableListItemItems);
				continue;
			}
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения идентификаторов привилегий"), 500);
		}
		permissionAddRequestModel.Items = list.ToArray();
		return permissionAddRequestModel;
	}
}

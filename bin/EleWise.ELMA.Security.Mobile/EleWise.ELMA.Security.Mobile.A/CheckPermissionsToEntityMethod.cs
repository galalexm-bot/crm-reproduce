using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Mobile.API.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Security.Mobile.API.Services;

internal class CheckPermissionsToEntityMethodExecutor : PublicServiceMethodExecutor
{
	private IEntityPermissionService entityPermissionService;

	private IMetadataRuntimeService metadataRuntimeService;

	public const string MethodName = "CheckPermissionsToEntity";

	private IEntityPermissionService EntityPermissionService => entityPermissionService ?? (entityPermissionService = Locator.GetServiceNotNull<IEntityPermissionService>());

	private IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	public static string Description => SR.T("Проверить необходимость выдачи привилегий на объект");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityIds", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификаторы объектов")).Type(typeof(long[]));
	}).ItemWithDescriptor("TypeUid", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Уникальный идентификатор типа объекта")).Type(typeof(Guid));
	}).ItemWithDescriptor("Permission", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Уникальный идентификатор привилегии")).Type(typeof(Guid));
	})
		.ItemWithDescriptor("UsersIds", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификаторы пользователей")).Optional().Type(typeof(long[]));
		})
		.ItemWithDescriptor("PrefixedUsersIds", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификаторы групп/пользователей с префиксом")).Optional().Type(typeof(string[]));
		})
		.ItemWithDescriptor("DefaultPermissions", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Уникальные идентификаторы привилегий по умолчанию")).Optional().Type(typeof(Guid[]));
		})
		.ItemWithDescriptor("NeedReplacement", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Нужно ли замещение (Boolean)")).Optional().Type(typeof(bool));
		})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("AddPermissionModel", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.ItemWithDescriptor("NeedPermission", delegate(TypeSerializationDescriptorBuilder x)
		{
			x.Description(SR.T("Нужны ли привилегии (Bool)")).Type(typeof(bool));
		}).ItemWithDescriptor("Dictionary", delegate(TypeSerializationDescriptorBuilder x)
		{
			x.Description(SR.T("Словарь с идентификаторами сущностей и пользователей, которым необходимы для них привилегии (Dictionary<object, List<long>>)")).Type(typeof(Dictionary<object, List<long>>));
		}).ItemWithDescriptor("Type", delegate(TypeSerializationDescriptorBuilder x)
		{
			x.Description(SR.T("Уникальный идентификатор типа сущности")).Type(typeof(Guid));
		})
			.ItemWithDescriptor("DefaultPermissions", delegate(TypeSerializationDescriptorBuilder x)
			{
				x.Description(SR.T("Уникальные идентификаторы привилегий по умолчанию")).Type(typeof(Guid[]));
			})
			.ItemWithDescriptor("HasGrantPermission", delegate(TypeSerializationDescriptorBuilder x)
			{
				x.Description(SR.T("Наличие прав на выдачу привилегий")).Type(typeof(bool));
			})
			.ItemWithDescriptor("GrandPermissions", delegate(TypeSerializationDescriptorBuilder x)
			{
				x.Description(SR.T("Привилегии для сущности, которые может выдать пользователь (если Null то любой тип привилегий) (Dictionary<long, List<Guid>>)")).Type(typeof(Dictionary<long, List<Guid>>));
			})
			.Description(SR.T("DTO для отправки данных о необходимости выдачи привилегий"));
	}).Descriptor;

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		PermissionRequestModel permissionRequestModel = ParseRequest();
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(permissionRequestModel.TypeUid, loadImplementation: false);
		bool flag = EntityPermissionService.CheckIfPermissionNeededForEntity(permissionRequestModel.EntityIds, typeByUidOrNull, permissionRequestModel.UsersIds, permissionRequestModel.PrefixedUsersIds, permissionRequestModel.Permission, permissionRequestModel.NeedReplacement);
		if (flag)
		{
			AddPermissionModel model = EntityPermissionService.EntityAddPermission(permissionRequestModel.EntityIds, typeByUidOrNull, permissionRequestModel.UsersIds, permissionRequestModel.PrefixedUsersIds, permissionRequestModel.Permission, permissionRequestModel.DefaultPermissions, permissionRequestModel.NeedReplacement);
			return CreateResultingData(model, permissionRequestModel.TypeUid, flag);
		}
		return CreateResultingData(new AddPermissionModel(), permissionRequestModel.TypeUid, flag);
	}

	public CheckPermissionsToEntityMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	private PermissionRequestModel ParseRequest()
	{
		PermissionRequestModel permissionRequestModel = new PermissionRequestModel();
		WebDataItem webDataItem = Parameters.FindItem("TypeUid");
		if (webDataItem == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения типа сущности"), 500);
		}
		permissionRequestModel.TypeUid = Guid.Parse(webDataItem.Value);
		WebDataItem webDataItem2 = Parameters.FindItem("EntityIds");
		if (webDataItem2.DataArray == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения идентификатора сущности"), 500);
		}
		permissionRequestModel.EntityIds = webDataItem2.DataArray.Select((WebData x) => long.Parse(x.Value)).ToArray();
		WebDataItem webDataItem3 = Parameters.FindItem("UsersIds");
		if (webDataItem3.DataArray != null)
		{
			permissionRequestModel.UsersIds = webDataItem3.DataArray.Select((WebData x) => long.Parse(x.Value)).ToArray();
		}
		WebDataItem webDataItem4 = Parameters.FindItem("PrefixedUsersIds");
		if (webDataItem4.DataArray != null)
		{
			permissionRequestModel.PrefixedUsersIds = webDataItem4.DataArray.Select((WebData x) => x.Value).ToArray();
		}
		WebDataItem webDataItem5 = Parameters.FindItem("Permission");
		if (webDataItem5 == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения Guid привилегии"), 500);
		}
		permissionRequestModel.Permission = Guid.Parse(webDataItem5.Value);
		WebDataItem webDataItem6 = Parameters.FindItem("DefaultPermissions");
		if (webDataItem6.DataArray != null)
		{
			permissionRequestModel.DefaultPermissions = webDataItem6.DataArray.Select((WebData x) => Guid.Parse(x.Value)).ToArray();
		}
		WebDataItem webDataItem7 = Parameters.FindItem("NeedReplacement");
		permissionRequestModel.NeedReplacement = webDataItem7 != null && bool.Parse(webDataItem7.Value);
		return permissionRequestModel;
	}

	private WebData CreateResultingData(AddPermissionModel model, Guid type, bool permissionNecessity = false)
	{
		List<WebDataItem> list = new List<WebDataItem>();
		list.Add(new WebDataItem
		{
			Name = "Type",
			Value = type.ToString()
		});
		list.Add(new WebDataItem
		{
			Name = "NeedPermission",
			Value = permissionNecessity.ToString()
		});
		if (model.DefaultPermissions != null && model.DefaultPermissions.Any())
		{
			list.Add(new WebDataItem
			{
				Name = "DefaultPermissions",
				Value = model.DefaultPermissions.ToString()
			});
		}
		list.Add(new WebDataItem
		{
			Name = "HasGrantPermission",
			Value = model.HasGrantPermission.ToString()
		});
		if (model.Dictionary != null)
		{
			IEnumerable<KeyValuePair<object, List<long>>> enumerable = model.Dictionary.Select((KeyValuePair<object, List<EleWise.ELMA.Security.Models.IUser>> kvp) => new KeyValuePair<object, List<long>>((kvp.Key as IIdentified).GetId(), kvp.Value.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToList()));
			List<WebDataItem> list2 = new List<WebDataItem>();
			foreach (KeyValuePair<object, List<long>> item in enumerable)
			{
				list2.Add(new WebDataItem
				{
					Name = item.Key.ToString(),
					Value = string.Join(",", item.Value)
				});
			}
			list.Add(new WebDataItem
			{
				Name = "Dictionary",
				Data = new WebData
				{
					Items = list2.ToArray()
				}
			});
		}
		if (model.GrandPermissions != null)
		{
			Dictionary<long, List<Guid>> dictionary = model.GrandPermissions.Select((KeyValuePair<long, IEnumerable<Permission>> kvp) => new KeyValuePair<long, List<Guid>>(kvp.Key, (kvp.Value == null) ? null : kvp.Value.Select((Permission u) => u.Id).ToList())).ToDictionary((KeyValuePair<long, List<Guid>> x) => x.Key, (KeyValuePair<long, List<Guid>> x) => x.Value);
			List<WebDataItem> list3 = new List<WebDataItem>();
			foreach (KeyValuePair<long, List<Guid>> item2 in dictionary)
			{
				list3.Add(new WebDataItem
				{
					Name = item2.Key.ToString(),
					Value = ((item2.Value != null && item2.Value.Count > 0) ? string.Join(",", item2.Value) : "null")
				});
			}
			list.Add(new WebDataItem
			{
				Name = "GrandPermissions",
				Data = new WebData
				{
					Items = list3.ToArray()
				}
			});
		}
		return new WebData
		{
			Items = list.ToArray()
		}.UpdateVersion();
	}
}

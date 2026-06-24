using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[Component]
public class UserTypeFilterProvider : IEntityFilterProvider, IEntityInstanceFilterProvider
{
	private readonly IQualifiedTypeNameResolverService qualifiedTypeNameResolverService;

	public const string UID_S = "{D4850234-256E-4227-B831-E43D39042998}";

	public static readonly Guid UID = new Guid("{D4850234-256E-4227-B831-E43D39042998}");

	public Guid ProviderUid => UID;

	public UserTypeFilterProvider(IQualifiedTypeNameResolverService qualifiedTypeNameResolverService)
	{
		this.qualifiedTypeNameResolverService = qualifiedTypeNameResolverService;
	}

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!(filter is IUserFilter userFilter) || string.IsNullOrEmpty(data))
		{
			return;
		}
		Func<string> func = delegate
		{
			int num = data.IndexOf(';');
			if (num >= 0)
			{
				string result = data.Substring(0, num);
				data = ((num + 1 < data.Length) ? data.Substring(num + 1) : null);
				return result;
			}
			string result2 = data;
			data = null;
			return result2;
		};
		string text = func();
		if (text == null)
		{
			return;
		}
		userFilter.ShowBlock = bool.Parse(text);
		string text2 = func();
		string text3 = data;
		if (!string.IsNullOrWhiteSpace(text2))
		{
			if (text2[0] == '#')
			{
				try
				{
					userFilter.Workers = (from w in text2.Substring(1).Split('|').Select(DeserializeWorker)
						where w != null
						select w).ToList();
				}
				catch
				{
				}
			}
			else
			{
				string[] array = text2.Split('|');
				if (array.Length == 2)
				{
					ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(qualifiedTypeNameResolverService.GetType(array[0]));
					if (classMetadata != null)
					{
						Guid propUid = new Guid(array[1]);
						PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propUid);
						if (propertyMetadata == null && classMetadata is EntityMetadata entityMetadata && entityMetadata.ViewModelMetadata != null)
						{
							propertyMetadata = entityMetadata.ViewModelMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propUid);
						}
						if (propertyMetadata != null && propertyMetadata.Settings is EntityUserSettings entityUserSettings && entityUserSettings.Workers != null && entityUserSettings.Workers.Count > 0)
						{
							userFilter.Workers = entityUserSettings.Workers;
						}
					}
				}
			}
		}
		if (!string.IsNullOrWhiteSpace(text3))
		{
			userFilter.Query = text3;
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return GetFilterProviderData(null, entityType, propertyMetadata, viewAttributes);
	}

	public string GetFilterProviderData(IEntity entity, Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		if (propertyMetadata == null)
		{
			return null;
		}
		EntityUserSettings entityUserSettings = ((viewAttributes != null) ? (viewAttributes.TypeSettings as EntityUserSettings) : null);
		EntityUserSettings entityUserSettings2 = propertyMetadata.Settings as EntityUserSettings;
		if (entityUserSettings == null)
		{
			entityUserSettings = entityUserSettings2;
		}
		if (entityUserSettings == null)
		{
			return null;
		}
		if (!entityUserSettings.ShowBlock && (entityUserSettings.Workers == null || entityUserSettings.Workers.Count <= 0) && string.IsNullOrEmpty(entityUserSettings.FilterQuery))
		{
			return null;
		}
		string text = null;
		List<Worker> list = ((entityUserSettings.Workers != null && entityUserSettings.Workers.Any((Worker w) => w.WorkerType == Worker.Types.Property)) ? Worker.PrepareForFilter(entityUserSettings.Workers, entity) : entityUserSettings.Workers);
		List<Worker> list2 = entityUserSettings2?.Workers;
		if (entityUserSettings.Workers != null && entityUserSettings.Workers.Count > 0 && list != null)
		{
			text = ((!(entityType == null) && (list2 == list || (list2 != null && list2.SetEqual(list)))) ? (qualifiedTypeNameResolverService.GetQualifiedTypeName(entityType) + "|" + propertyMetadata.Uid) : ("#" + string.Join("|", list.Distinct(FunctorEqualityComparer<Worker>.Create((Worker w1, Worker w2) => w1.WorkerType == w2.WorkerType && w1.WorkerId == w2.WorkerId && w1.WorkerUid == w2.WorkerUid)).Select(SerializeWorker))));
		}
		return entityUserSettings.ShowBlock + ";" + text + ";" + entityUserSettings.FilterQuery;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		return null;
	}

	private static string SerializeWorker(Worker worker)
	{
		if (worker.WorkerType == OrganizationItemDTO.MetadataUid)
		{
			return "O" + worker.WorkerId;
		}
		if (worker.WorkerType == UserGroupDTO.MetadataUid)
		{
			return "G" + worker.WorkerId;
		}
		if (worker.WorkerType == UserDTO.UID)
		{
			return "U" + worker.WorkerId;
		}
		if (worker.WorkerType == Worker.Types.Property)
		{
			return "P" + worker.WorkerUid;
		}
		return string.Concat(worker.WorkerType, "+", worker.WorkerId, "+", worker.WorkerUid);
	}

	private static Worker DeserializeWorker(string worker)
	{
		try
		{
			if (worker.StartsWith("O"))
			{
				return new Worker
				{
					WorkerType = OrganizationItemDTO.MetadataUid,
					WorkerId = long.Parse(worker.Substring(1))
				};
			}
			if (worker.StartsWith("G"))
			{
				return new Worker
				{
					WorkerType = UserGroupDTO.MetadataUid,
					WorkerId = long.Parse(worker.Substring(1))
				};
			}
			if (worker.StartsWith("U"))
			{
				return new Worker
				{
					WorkerType = UserDTO.UID,
					WorkerId = long.Parse(worker.Substring(1))
				};
			}
			if (worker.StartsWith("P"))
			{
				return new Worker
				{
					WorkerType = Worker.Types.Property,
					WorkerUid = Guid.Parse(worker.Substring(1))
				};
			}
			string[] array = worker.Split('+');
			return new Worker
			{
				WorkerType = Guid.Parse(array[0]),
				WorkerId = long.Parse(array[1]),
				WorkerUid = Guid.Parse(array[2])
			};
		}
		catch
		{
			return null;
		}
	}
}

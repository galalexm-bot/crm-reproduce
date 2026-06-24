using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.Common.Components;

[Component]
internal abstract class BasePermissionsTypeExtensionPoint : IEntityPermissionsTypeExtensionPoint
{
	private const string EntityPermissionCustomCodeTemplateFileName = "EleWise.ELMA.Common.Resources.EntityPermission.CustomCodeTemplate.cs";

	private const string EntityPermissionCustomCodeTemplateDisabledFileName = "EleWise.ELMA.Common.Resources.EntityPermission.CustomCodeTemplateDisabled.cs";

	private string entityPermissionCustomCodeTemplate;

	private string entityPermissionCustomCodeTemplateDisabled;

	private ITransformationProvider transformationProvider;

	private ISessionProvider sessionProvider;

	private ITransformationProvider TransformationProvider => transformationProvider ?? (transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>());

	private string EntityPermissionCustomCodeTemplate
	{
		get
		{
			if (entityPermissionCustomCodeTemplate == null)
			{
				entityPermissionCustomCodeTemplate = CustomCodeFileText("EleWise.ELMA.Common.Resources.EntityPermission.CustomCodeTemplate.cs");
			}
			return entityPermissionCustomCodeTemplate;
		}
	}

	private string EntityPermissionCustomCodeTemplateDisabled
	{
		get
		{
			if (entityPermissionCustomCodeTemplateDisabled == null)
			{
				entityPermissionCustomCodeTemplateDisabled = CustomCodeFileText("EleWise.ELMA.Common.Resources.EntityPermission.CustomCodeTemplateDisabled.cs");
			}
			return entityPermissionCustomCodeTemplateDisabled;
		}
	}

	private ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	private Assembly Assembly => GetType().Assembly;

	private PropertyViewSettings PropertyViewSettings => new PropertyViewSettings
	{
		Attributes = new List<ViewAttribute>
		{
			new ViewAttribute(Visibility.ForceHidden)
		}
	};

	public virtual IEnumerable<PropertyMetadata> GetDefaultPermissionMetadataProperties(EntityMetadata metadata)
	{
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		IMetadata metadata2 = MetadataLoader.LoadMetadata(typeof(EleWise.ELMA.Security.Models.IUser), inherit: true, loadImplementation: false);
		IMetadata metadata3 = MetadataLoader.LoadMetadata(typeof(IUserGroup), inherit: true, loadImplementation: false);
		IMetadata metadata4 = MetadataLoader.LoadMetadata(typeof(IOrganizationItem), inherit: true, loadImplementation: false);
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "PermissionId",
			DisplayName = SR.T("Привилегия"),
			TypeUid = GuidDescriptor.UID,
			ViewSettings = PropertyViewSettings,
			Settings = new GuidSettings
			{
				FieldName = "PermissionId"
			},
			Required = true,
			Nullable = false
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "UserSecuritySetCacheId",
			DisplayName = SR.T("UserSecuritySetCacheId"),
			TypeUid = Int64Descriptor.UID,
			ViewSettings = PropertyViewSettings,
			Settings = new Int64Settings
			{
				FieldName = "UserSecuritySetCacheId"
			}
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "PermissionRole",
			DisplayName = SR.T("Роль"),
			TypeUid = GuidDescriptor.UID,
			ViewSettings = PropertyViewSettings,
			Settings = new GuidSettings
			{
				FieldName = "PermissionRole"
			}
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "User",
			DisplayName = SR.T("Пользователь"),
			TypeUid = EntityDescriptor.UID,
			SubTypeUid = metadata2.Uid,
			ViewSettings = PropertyViewSettings,
			Settings = new EntityUserSettings
			{
				FieldName = "User"
			}
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "OrganizationItemPosition",
			DisplayName = SR.T("Группа"),
			TypeUid = EntityDescriptor.UID,
			SubTypeUid = metadata4.Uid,
			ViewSettings = PropertyViewSettings,
			Settings = new EntitySettings
			{
				FieldName = "OrganizationItemPosition"
			}
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "Group",
			DisplayName = SR.T("Группа пользователей"),
			TypeUid = EntityDescriptor.UID,
			SubTypeUid = metadata3.Uid,
			ViewSettings = PropertyViewSettings,
			Settings = new EntitySettings
			{
				FieldName = "Group"
			}
		});
		list.Add(new EntityPropertyMetadata
		{
			Uid = Guid.NewGuid(),
			IsSystem = true,
			Name = "OrganizationItem",
			DisplayName = SR.T("Отдел"),
			TypeUid = EntityDescriptor.UID,
			SubTypeUid = metadata4.Uid,
			ViewSettings = PropertyViewSettings,
			Settings = new EntitySettings
			{
				FieldName = "OrganizationItem"
			}
		});
		return list;
	}

	public virtual IEnumerable<string> GetImplementedInterfaces(EntityMetadata metadata)
	{
		return new string[1] { typeof(IEntityPermissionExtension).FullName + ", " + "EleWise.ELMA.Common" };
	}

	public virtual string CustomCode(EntityMetadata metadata, EntityMetadata permissionMetadata, bool enabled)
	{
		string customCodeTemplate = (enabled ? EntityPermissionCustomCodeTemplate : EntityPermissionCustomCodeTemplateDisabled);
		string name2 = permissionMetadata.Name;
		string @namespace = permissionMetadata.Namespace;
		string name3 = metadata.Name;
		Action<string, string> obj = delegate(string name, string value)
		{
			customCodeTemplate = customCodeTemplate.Replace($"{{{name}}}", value);
		};
		obj("ClassName", name2);
		obj("NamespacePath", @namespace);
		obj("ParentClassName", name3);
		return customCodeTemplate;
	}

	public virtual void UpdatePermissions(Type type, long id, bool needDropOldData)
	{
		if (MetadataLoader.LoadMetadata(type, inherit: true, loadImplementation: false) is EntityMetadata metadata)
		{
			UpdatePermissions(metadata, needDropOldData);
		}
	}

	public virtual void UpdatePermissions(EntityMetadata metadata, bool needDropOldData)
	{
		if (metadata != null)
		{
			TablePartMetadata activePermissionMetadata = metadata.GetActivePermissionMetadata();
			if (activePermissionMetadata != null)
			{
				SendPermissionUpdateRequest(metadata, activePermissionMetadata, needDropOldData);
			}
		}
	}

	public bool IsInstancePermissionMode(object instance)
	{
		if (((instance is ICatalogProfile catalogProfile) ? MetadataLoader.LoadMetadata(catalogProfile.CatalogType.EntityType) : null) is EntityMetadata metadata)
		{
			return metadata.CanUsePermissions();
		}
		return false;
	}

	private void SendPermissionUpdateRequest(EntityMetadata metadata, EntityMetadata permissionMetadata, bool needDropOldData)
	{
		ISession session = SessionProvider.GetSession("");
		IQuery val = null;
		if (metadata.BaseClassUid == Guid.Empty && metadata.AllowCreateHeirs)
		{
			val = session.GetNamedQuery("CreateInstancePermissionInh");
			val.SetParameter<Guid>("catalogTypeUid", metadata.ImplementationUid);
		}
		else
		{
			val = session.GetNamedQuery("CreateInstancePermission");
		}
		val.SetParameter<string>("tableName", TransformationProvider.Dialect.QuoteIfNeeded(metadata.TableName)).SetParameter<string>("tablePermissionName", TransformationProvider.Dialect.QuoteIfNeeded(permissionMetadata.TableName)).SetParameter<string>("sequenceName", TransformationProvider.Dialect.QuoteIfNeeded("G_" + permissionMetadata.TableName))
			.SetParameter<Guid>("fullPermission", EleWise.ELMA.Security.PermissionProvider.AccessManagmentPermission.Id)
			.SetParameter<Guid>("fullInstPermission", PermissionProvider.CatalogInstanceGrantAccessPermission.Id)
			.SetParameter<Guid>("viewProfilePermission", PermissionProvider.CatalogViewPermission.Id)
			.SetParameter<Guid>("editProfilePermission", PermissionProvider.CatalogEditPermission.Id)
			.SetParameter<Guid>("editInstPerm", PermissionProvider.CatalogInstancePowerPermission.Id)
			.SetParameter<Guid>("viewInstPerm", PermissionProvider.CatalogInstanceViewPermission.Id)
			.SetParameter<Guid>("catalogUid", metadata.Uid)
			.SetParameter<Guid>("groupRoleType", CommonRoleTypes.Group.Id)
			.SetParameter<bool>("recalculateAll", needDropOldData);
		val.ExecuteUpdate(cleanUpCache: false);
		session.CleanUpCache(ModelHelper.GetEntityType(permissionMetadata.Uid));
		foreach (EntityMetadata item in from a in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
			where a.BaseClassUid == metadata.Uid
			select a)
		{
			SendPermissionUpdateRequest(item, permissionMetadata, needDropOldData: false);
		}
	}

	private string CustomCodeFileText(string fileName)
	{
		string text = "";
		using Stream stream = Assembly.GetReflectionManifestResourceStream(fileName);
		if (stream == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось загрузить файл {0} из сборки {1}", fileName, Assembly.FullName));
		}
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}
}

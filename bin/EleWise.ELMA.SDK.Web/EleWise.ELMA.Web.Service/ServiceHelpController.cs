using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Web.Mvc;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.ServiceHelp;

namespace EleWise.ELMA.Web.Service;

[AuthenticationFilter]
public class ServiceHelpController : Controller
{
	private static ServiceDocumentation[] coreAPIServiceDocumentations;

	private static ServiceDocumentation[] publicAPIServiceDocumentations;

	private static ServiceDocumentation[] publicServiceDocumentations;

	private static PublicMetadataService publicMetadataService;

	private static readonly string IdPropertyName = LinqUtils.NameOf((IEntity<object> e) => e.Id);

	private static readonly string TypeUidPropertyName = LinqUtils.NameOf((Expression<Func<IInheritable, object>>)((IInheritable i) => i.TypeUid));

	private static IMetadataRuntimeService MetadataRuntimeService => Locator.GetServiceNotNull<IMetadataRuntimeService>();

	public ServiceHelpController()
	{
		coreAPIServiceDocumentations = coreAPIServiceDocumentations ?? ComponentManager.Current.GetExtensionPointTypes<ICorePublicService>().Select(delegate(Type t)
		{
			Type classType2 = t.GetInterfaces().First((Type type) => type.GetCustomAttributes(typeof(ServiceContractAttribute), inherit: false).Length != 0);
			return new ServiceDocumentation
			{
				ServiceUrl = "API",
				ServiceType = t,
				Contract = new DocumentationParser(classType2).Parse(),
				Uid = AttributeHelper<UidAttribute>.GetAttribute(t, inherited: false).Uid
			};
		}).ToArray();
		publicAPIServiceDocumentations = publicAPIServiceDocumentations ?? ComponentManager.Current.GetExtensionPointTypes<IPublicAPIWebService>().Select(delegate(Type t)
		{
			Type classType = t.GetInterfaces().First((Type type) => Attribute.IsDefined(type, typeof(ServiceContractAttribute), inherit: false));
			return new ServiceDocumentation
			{
				ServiceUrl = "PublicAPI",
				ServiceType = t,
				Contract = new DocumentationParser(classType).Parse(),
				Uid = AttributeHelper<UidAttribute>.GetAttribute(t, inherited: false).Uid
			};
		}).ToArray();
		publicServiceDocumentations = publicServiceDocumentations ?? (from t in ComponentManager.Current.GetExtensionPoints<IPublicService>()
			select new ServiceDocumentation
			{
				ServiceUrl = "API",
				ServiceType = t.GetType(),
				Contract = new PublicServiceDocumentationParser(t).Parse(),
				Uid = t.Uid
			}).ToArray();
		publicMetadataService = Locator.GetServiceNotNull<PublicMetadataService>();
	}

	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult Services()
	{
		ReadOnlyCollection<ServiceDocumentation> readOnlyCollection = coreAPIServiceDocumentations.Union(publicAPIServiceDocumentations).Union(publicServiceDocumentations).ToList()
			.AsReadOnly();
		return (ActionResult)(object)((Controller)this).View((object)readOnlyCollection);
	}

	public ActionResult Service(Guid uid)
	{
		ServiceDocumentation serviceDocumentation = coreAPIServiceDocumentations.Union(publicAPIServiceDocumentations).Union(publicServiceDocumentations).FirstOrDefault((ServiceDocumentation d) => d.Uid == uid);
		if (serviceDocumentation == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (ActionResult)(object)((Controller)this).View((object)serviceDocumentation);
	}

	public ActionResult Types()
	{
		TypesHelpModel typesHelpModel = new TypesHelpModel();
		IEnumerable<IPublicMetadataGroupInfo> groupInfoList = publicMetadataService.GetGroupInfoList();
		typesHelpModel.Groups.AddRange(groupInfoList.Select((IPublicMetadataGroupInfo g) => new TypesHelpModel.Group(g)));
		TypesHelpModel.Group group = new TypesHelpModel.Group();
		typesHelpModel.Groups.Add(group);
		typesHelpModel.Groups = typesHelpModel.Groups.OrderBy((TypesHelpModel.Group g) => g.Order).ToList();
		Dictionary<Guid, TypesHelpModel.Group> dictionary = new Dictionary<Guid, TypesHelpModel.Group>();
		foreach (TypesHelpModel.Group group2 in typesHelpModel.Groups)
		{
			dictionary[group2.GroupUid] = group2;
		}
		IPublicMetadataInfo[] allMetadataInfo = GetAllMetadataInfo<EntityMetadata>(FilterEntityMetadata);
		foreach (IPublicMetadataInfo publicMetadataInfo in allMetadataInfo)
		{
			if (!dictionary.TryGetValue(publicMetadataInfo.GroupUid, out var value))
			{
				value = group;
			}
			value.MetadataInfoList.Add(publicMetadataInfo);
		}
		return (ActionResult)(object)((Controller)this).View((object)typesHelpModel);
	}

	private static bool FilterEntityMetadata(EntityMetadata m)
	{
		if (m.IdTypeUid == Int64Descriptor.UID || m.IdTypeUid == Int32Descriptor.UID || m.IdTypeUid == Int16Descriptor.UID)
		{
			if (m.Type != 0)
			{
				return m.Type == EntityMetadataType.InterfaceImplementation;
			}
			return true;
		}
		return false;
	}

	public ActionResult Type(Guid uid)
	{
		IPublicMetadataInfo publicMetadataInfo = publicMetadataService.LoadMetadataInfo(uid);
		if (publicMetadataInfo == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		MetadataHelpModel metadataHelpModel = new MetadataHelpModel(publicMetadataInfo);
		if (!(metadataHelpModel.Metadata is EntityMetadata entityMetadata) || !FilterEntityMetadata(entityMetadata))
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		metadataHelpModel.Descriptor = BuildTypeSerializationDescriptor(entityMetadata, publicMetadataInfo);
		return (ActionResult)(object)((Controller)this).View((object)metadataHelpModel);
	}

	public ActionResult ClrType(string name)
	{
		Type type = System.Type.GetType(name, throwOnError: false, ignoreCase: true);
		if (type == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		Type elementType = EnumerableExtensions.GetElementType(type);
		if (elementType != null)
		{
			type = elementType;
		}
		TypeSerializationDescriptor typeSerializationDescriptor = DocumentationParser.BuildTypeSerializationDescriptor(type);
		return (ActionResult)(object)((Controller)this).View((object)typeSerializationDescriptor);
	}

	private static TypeSerializationDescriptor BuildTypeSerializationDescriptor(IEntityMetadata md, IPublicMetadataInfo mdInfo, bool isBlock = false)
	{
		TypeSerializationDescriptor model = new TypeSerializationDescriptor
		{
			Description = md.DisplayName
		};
		TypeSerializationItemDescriptor item = new TypeSerializationItemDescriptor();
		if (md is EntityMetadata entityMetadata)
		{
			ITypeDescriptor idTypeDescriptor = MetadataRuntimeService.GetIdTypeDescriptor(entityMetadata.IdTypeUid);
			string text = ((idTypeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor && runtimeTypeDescriptor.IsRuntimeType) ? runtimeTypeDescriptor.RuntimeType.Name : idTypeDescriptor.Name);
			new TypeSerializationItemDescriptorBuilder(item).Name(IdPropertyName).Descriptor(SR.T("Идентификатор объекта ({0})", text));
		}
		model.Items.Add(item);
		if (!isBlock)
		{
			TypeSerializationItemDescriptor item2 = new TypeSerializationItemDescriptor();
			new TypeSerializationItemDescriptorBuilder(item2).Name(TypeUidPropertyName).Descriptor(SR.T("Идентификатор типа объекта (Guid)"));
			model.Items.Add(item2);
		}
		foreach (IPropertyMetadata propertiesAndTablePart in md.GetPropertiesAndTableParts())
		{
			if (propertiesAndTablePart is PropertyMetadata propertyMetadata)
			{
				if (!(MetadataRuntimeService.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is ISerializableTypeDescriptor serializableTypeDescriptor))
				{
					continue;
				}
				foreach (TypeSerializationItemDescriptor item4 in serializableTypeDescriptor.GetSerializeDescriptor((ClassMetadata)md, propertyMetadata).Items)
				{
					mdInfo?.ProcessPropertyDescriptor(propertiesAndTablePart, item4);
					model.Items.Add(item4);
				}
			}
			if (propertiesAndTablePart is ITablePartMetadata tablePartMetadata)
			{
				TypeSerializationDescriptor descriptor = BuildTypeSerializationDescriptor((IEntityMetadata)tablePartMetadata, mdInfo, isBlock: true);
				TypeSerializationItemDescriptor item3 = new TypeSerializationItemDescriptor
				{
					Descriptor = descriptor
				};
				TypeSerializationDescriptor descriptor2 = new TypeSerializationDescriptorBuilder().Description(tablePartMetadata.DisplayName).IsArray().Item(item3)
					.Descriptor;
				TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor
				{
					Descriptor = descriptor2,
					Name = tablePartMetadata.TablePartPropertyName
				};
				mdInfo?.ProcessPropertyDescriptor(propertiesAndTablePart, typeSerializationItemDescriptor);
				model.Items.Add(typeSerializationItemDescriptor);
			}
		}
		List<TypeSerializationItemDescriptor> list = model.Items.Where((TypeSerializationItemDescriptor i) => i.Descriptor.IsObsolete).ToList();
		list.ForEach(delegate(TypeSerializationItemDescriptor i)
		{
			model.Items.Remove(i);
		});
		list.ForEach(delegate(TypeSerializationItemDescriptor i)
		{
			model.Items.Add(i);
		});
		return model;
	}

	public ActionResult Enums()
	{
		IPublicMetadataInfo[] allMetadataInfo = GetAllMetadataInfo<EnumMetadata>();
		return (ActionResult)(object)((Controller)this).View((object)allMetadataInfo);
	}

	public ActionResult Enum(Guid uid)
	{
		IPublicMetadataInfo publicMetadataInfo = publicMetadataService.LoadMetadataInfo(uid);
		if (publicMetadataInfo == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		MetadataHelpModel metadataHelpModel = new MetadataHelpModel(publicMetadataInfo);
		if (!(metadataHelpModel.Metadata is EnumMetadata enumMetadata))
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		metadataHelpModel.Descriptor = new TypeSerializationDescriptor
		{
			Description = enumMetadata.DisplayName
		};
		List<EnumValueMetadata> list = new List<EnumValueMetadata>(enumMetadata.Values);
		GetEnumValues(list, enumMetadata);
		foreach (EnumValueMetadata item2 in list)
		{
			TypeSerializationItemDescriptor item = new TypeSerializationItemDescriptor();
			string arg = ((enumMetadata.Type == EnumMetadataType.Enum) ? item2.IntValue.ToString() : item2.Uid.ToString());
			new TypeSerializationItemDescriptorBuilder(item).Name(item2.Name).Descriptor(string.Format("{0} ({2})", item2.DisplayName, item2.Description, arg));
			metadataHelpModel.Descriptor.Items.Add(item);
		}
		return (ActionResult)(object)((Controller)this).View((object)metadataHelpModel);
	}

	private static void GetEnumValues(List<EnumValueMetadata> values, EnumMetadata md)
	{
		EnumMetadata enumMetadata = md;
		while (enumMetadata.Type == EnumMetadataType.EnumExtension && !(enumMetadata.BaseTypeUid == Guid.Empty) && publicMetadataService.LoadMetadata(enumMetadata.BaseTypeUid) is EnumMetadata enumMetadata2)
		{
			values.AddRange(enumMetadata2.Values);
			enumMetadata = enumMetadata2;
		}
	}

	public ActionResult TypeDescriptors()
	{
		IEnumerable<ITypeDescriptor> enumerable = from t in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptors()
			where t.Visible && t.ParentUid == Guid.Empty
			select t;
		return (ActionResult)(object)((Controller)this).View((object)enumerable);
	}

	public ActionResult TypeDescriptor(Guid typeUid, Guid? subTypeUid = null)
	{
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		Guid guid = (subTypeUid.HasValue ? subTypeUid.Value : Guid.Empty);
		ITypeDescriptor typeDescriptor = serviceNotNull.GetTypeDescriptor(typeUid, guid);
		return (ActionResult)(object)((Controller)this).View((object)Tuple.Create(typeDescriptor, guid));
	}

	public static Guid ProcessSubTypeUid(Guid subTypeUid)
	{
		if (subTypeUid == Guid.Empty)
		{
			return subTypeUid;
		}
		Type typeByUidOrNull = publicMetadataService.GetTypeByUidOrNull(subTypeUid);
		return ((typeByUidOrNull != null) ? MetadataLoader.LoadMetadata(typeByUidOrNull) : null)?.Uid ?? subTypeUid;
	}

	private IPublicMetadataInfo[] GetAllMetadataInfo<T>(Func<T, bool> func = null) where T : class, IMetadata
	{
		return (from i in publicMetadataService.GetMetadataInfoList()
			where i.GetMetadata() is T arg && (func == null || func(arg))
			select i).ToArray();
	}
}

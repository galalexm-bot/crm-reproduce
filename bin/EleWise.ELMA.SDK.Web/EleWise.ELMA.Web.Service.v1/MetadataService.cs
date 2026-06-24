using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetMetadataKnownTypes", typeof(ServiceKnownTypeHelper))]
[XmlSerializerFormat]
[Component]
[Uid("{10C8A02F-4E91-4441-8869-50D1D9A7EB85}")]
public class MetadataService : IMetadataService, ICorePublicService
{
	public const string GuidS = "{10C8A02F-4E91-4441-8869-50D1D9A7EB85}";

	public static Guid Guid = new Guid("{10C8A02F-4E91-4441-8869-50D1D9A7EB85}");

	private static string _cachedDynamicHash;

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public AbstractMetadata[] LoadAllMetadata()
	{
		try
		{
			return GetAllMetadata<AbstractMetadata>();
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public AbstractMetadata LoadMetadata(string typeUid)
	{
		try
		{
			return GetMetadata<AbstractMetadata>(typeUid);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public ClassMetadata LoadClassMetadata(string typeUid)
	{
		return LoadMetadata(typeUid) as ClassMetadata;
	}

	public EnumMetadata LoadEnumMetadata(string typeUid)
	{
		return LoadMetadata(typeUid) as EnumMetadata;
	}

	public ClassMetadata[] LoadAllChildClassMetadata(string typeUid)
	{
		try
		{
			return MetadataLoader.GetChildClasses(GetMetadata<ClassMetadata>(typeUid)).ToArray();
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public EnumMetadata[] LoadAllChildEnumMetadata(string typeUid)
	{
		try
		{
			return MetadataLoader.GetChildEnums(GetMetadata<EnumMetadata>(typeUid)).ToArray();
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public PropertyMetadata LoadPropertyMetadataByGuid(string typeUid, Guid propertyUid)
	{
		try
		{
			if (propertyUid != Guid.Empty)
			{
				return GetMetadata<EntityMetadata>(typeUid).Properties.First((PropertyMetadata p) => p.Uid == propertyUid);
			}
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
		throw PublicServiceException.CreateWebFault(SR.T("Не задан параметр propertyUid"), 400);
	}

	public PropertyMetadata LoadPropertyMetadataByName(string typeUid, string propertyName)
	{
		try
		{
			if (!string.IsNullOrEmpty(propertyName))
			{
				return GetMetadata<EntityMetadata>(typeUid).Properties.First((PropertyMetadata p) => p.Name == propertyName);
			}
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
		throw PublicServiceException.CreateWebFault(SR.T("Не задан параметр propertyName"), 400);
	}

	public string GetMetadataHash()
	{
		try
		{
			return GetDynamicModelHash();
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	private static string GetDynamicModelHash()
	{
		Assembly assembly = ComponentManager.FindLoadedAssembly("EleWise.ELMA.DynamicModel", isFullName: false);
		if (_cachedDynamicHash != null)
		{
			return _cachedDynamicHash;
		}
		using (FileStream inputStream = File.OpenRead(assembly.Location))
		{
			using SHA1 sHA = SHA1.Create();
			_cachedDynamicHash = Convert.ToBase64String(sHA.ComputeHash(inputStream));
		}
		return _cachedDynamicHash;
	}

	private T[] GetAllMetadata<T>(Func<T, bool> func = null) where T : IMetadata
	{
		IEnumerable<IMetadata> metadataList = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList();
		metadataList = (from filter in ComponentManager.Current.GetExtensionPoints<IPublicMetadataFilter>()
			where filter.Filter != null
			select filter).Aggregate(metadataList, (IEnumerable<IMetadata> current, IPublicMetadataFilter filter) => current.Where(filter.Filter));
		IEnumerable<T> source = metadataList.OfType<T>();
		if (func != null)
		{
			source = source.Where(func);
		}
		return source.ToArray();
	}

	private T GetMetadata<T>(string typeUid)
	{
		return (T)MetadataLoader.LoadMetadata(Guid.Parse(typeUid));
	}
}

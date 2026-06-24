using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class CustomComponentCacheService : ICustomComponentCacheService
{
	private readonly IReactiveDictionary<string, Guid> customTypes;

	public CustomComponentCacheService()
	{
		customTypes = new ReactiveDictionary<string, Guid>();
	}

	public void RegisterComponent(ComponentMetadata metadata, Guid headerUid)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		CustomTypeImplementationModel customTypeImplementation = metadata.get_CustomTypeImplementation();
		if (customTypeImplementation != null && customTypeImplementation.get_TypeUid() != Guid.Empty && !GetCustomComponent(customTypeImplementation.get_TypeUid(), customTypeImplementation.get_SubTypeUid(), customTypeImplementation.get_IsCollection(), out var _))
		{
			((IDictionary<string, Guid>)customTypes).Add(GetKey(customTypeImplementation.get_TypeUid(), customTypeImplementation.get_SubTypeUid(), customTypeImplementation.get_IsCollection()), headerUid);
		}
	}

	public bool GetCustomComponent(Guid typeUid, Guid subTypeUid, bool isCollection, out Guid headerUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (((IDictionary<string, Guid>)customTypes).TryGetValue(GetKey(typeUid, subTypeUid, isCollection), ref headerUid))
		{
			return true;
		}
		return false;
	}

	private string GetKey(Guid typeUid, Guid subTypeUid, bool isCollection)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return $"{typeUid}_{subTypeUid}_{isCollection}";
	}
}

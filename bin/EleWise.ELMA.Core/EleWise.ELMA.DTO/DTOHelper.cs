using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.DTO;

[Rules(/*Could not decode attribute arguments.*/)]
[ObjectLiteral]
internal static class DTOHelper
{
	private static TypedMap<string, ProxyType> proxyTypes;

	public static ProxyType ProxyType(string type)
	{
		if (proxyTypes == null)
		{
			proxyTypes = new TypedMap<string, ProxyType>();
		}
		ProxyType proxyType = proxyTypes.Get(type);
		if (proxyType == null)
		{
			proxyType = new ProxyType(type);
			proxyTypes.Set(type, proxyType);
		}
		return proxyType;
	}

	public static ReactiveProxy ProxyCast(this ReactiveProxy obj, string uid)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (obj == null)
		{
			return null;
		}
		if (ProxyIsInternal(obj, uid))
		{
			return obj;
		}
		throw new InvalidCastException(SR.T("Невозможно привести тип объекта {0}", uid));
	}

	public static ReactiveProxy ProxyAs(this ReactiveProxy obj, string uid)
	{
		if (!ProxyIsInternal(obj, uid))
		{
			return null;
		}
		return obj;
	}

	public static bool ProxyIs(this ReactiveProxy obj, string uid)
	{
		return ProxyIsInternal(obj, uid);
	}

	public static bool IsEqualDtoWithIncludes(IMetadataServiceContext metadataServiceContext, Guid typeUidWithInclude, Guid typeUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (typeUidWithInclude == typeUid)
		{
			return true;
		}
		IMetadata metadata = metadataServiceContext.GetMetadata(typeUidWithInclude);
		DataClassMetadata val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null);
		if (val == null)
		{
			return false;
		}
		System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)val.get_IncludeList()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassDependency current = enumerator.get_Current();
				if (IsEqualDtoWithIncludes(metadataServiceContext, ((Dependency)current).get_HeaderUid(), typeUid))
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	private static bool ProxyIsInternal(ReactiveProxy obj, string uidString)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj.Json == null)
		{
			return false;
		}
		if (obj.CanCast == null)
		{
			obj.CanCast = new object();
		}
		if (obj.CanCast.HasProperty(uidString))
		{
			return obj.CanCast.GetPlainPropertyValue<bool>(uidString);
		}
		obj.CanCast.SetAndCreatePlainPropertyValue(uidString, false);
		return false;
	}

	private static ValueTuple<bool, DataClassMetadata> CheckInclude(IMetadataServiceContext metadataService, DataClassMetadata metadataCheck, DataClassMetadata metadata)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (metadataCheck == null || metadata == null)
		{
			return new ValueTuple<bool, DataClassMetadata>(false, (DataClassMetadata)null);
		}
		DataClassMetadata val = metadata;
		while (((ClassMetadata)val).get_BaseClassUid() != Guid.Empty)
		{
			IMetadata metadata2 = metadataService.GetMetadata(((ClassMetadata)val).get_BaseClassUid());
			DataClassMetadata val2 = (DataClassMetadata)(object)((metadata2 is DataClassMetadata) ? metadata2 : null);
			if (val2 == null)
			{
				break;
			}
			if (val2.get_TypeRef() == metadataCheck.get_TypeRef())
			{
				return new ValueTuple<bool, DataClassMetadata>(true, val2);
			}
			val = val2;
		}
		System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)metadata.get_IncludeList()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassDependency current = enumerator.get_Current();
				IMetadata metadata3 = metadataService.GetMetadata(((Dependency)current).get_HeaderUid());
				DataClassMetadata val3;
				if ((val3 = (DataClassMetadata)(object)((metadata3 is DataClassMetadata) ? metadata3 : null)) != null)
				{
					if (((IMetadata)metadataCheck).get_Uid() == ((Dependency)current).get_HeaderUid())
					{
						return new ValueTuple<bool, DataClassMetadata>(true, val3);
					}
					ValueTuple<bool, DataClassMetadata> result = CheckInclude(metadataService, metadataCheck, val3);
					if (result.Item1)
					{
						return result;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return new ValueTuple<bool, DataClassMetadata>(false, (DataClassMetadata)null);
	}

	private static bool CanCastEntity(IMetadataServiceContext metadataService, EntityMetadata metadataCheck, EntityMetadata metadata)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (metadataCheck == null || metadata == null)
		{
			return false;
		}
		if (((IMetadata)metadataCheck).get_Uid() == ((IMetadata)metadata).get_Uid())
		{
			return true;
		}
		Guid baseClassUid = ((ClassMetadata)metadataCheck).get_BaseClassUid();
		if (baseClassUid == Guid.Empty)
		{
			return false;
		}
		return CanCastEntity(metadataService, baseClassUid, metadata);
	}

	private static bool CanCastEntity(IMetadataServiceContext metadataService, Guid metadataUid, EntityMetadata metadata)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (metadataUid == Guid.Empty)
		{
			return false;
		}
		if (metadataUid == ((IMetadata)metadata).get_Uid())
		{
			return true;
		}
		IMetadata metadata2 = metadataService.GetMetadata(metadataUid);
		EntityMetadata val = (EntityMetadata)(object)((metadata2 is EntityMetadata) ? metadata2 : null);
		if (val == null)
		{
			return false;
		}
		if (((IMetadata)val).get_Uid() == metadataUid)
		{
			return true;
		}
		if (((ClassMetadata)val).get_BaseClassUid() == Guid.Empty)
		{
			return false;
		}
		return CanCastEntity(metadataService, ((ClassMetadata)val).get_BaseClassUid(), metadata);
	}
}

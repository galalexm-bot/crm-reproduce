using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.DTO;

internal static class ProxyPropertySearcher
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__1_0;

		public static Func<PropertyMetadata, bool> _003C_003E9__1_1;

		internal bool _003CFindUniquePropertyRecursively_003Eb__1_0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == "Uid";
		}

		internal bool _003CFindUniquePropertyRecursively_003Eb__1_1(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == "Id";
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string propertyName;

		internal bool _003CFindPropertyRecursively_003Eb__0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == propertyName;
		}
	}

	private static TypedMap<string, Tuple<PropertyMetadata, ClassMetadata>> propertyMap = new TypedMap<string, Tuple<PropertyMetadata, ClassMetadata>>();

	internal static Tuple<PropertyMetadata, ClassMetadata> FindUniquePropertyRecursively(IMetadataServiceContext metadataServiceContext, ClassMetadata metadata)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (metadata == null)
		{
			return null;
		}
		Guid uid = ((IMetadata)metadata).get_Uid();
		string text = ((object)(Guid)(ref uid)).ToString();
		if (propertyMap.Has(text))
		{
			return propertyMap.Get(text);
		}
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == "Uid"));
		if (val != null)
		{
			Tuple<PropertyMetadata, ClassMetadata> val2 = new Tuple<PropertyMetadata, ClassMetadata>(val, metadata);
			propertyMap.Set(text, val2);
			return val2;
		}
		val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == "Id"));
		if (val != null)
		{
			Tuple<PropertyMetadata, ClassMetadata> val3 = new Tuple<PropertyMetadata, ClassMetadata>(val, metadata);
			propertyMap.Set(text, val3);
			return val3;
		}
		DataClassMetadata val4;
		if ((val4 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
		{
			System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)val4.get_IncludeList()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					DataClassDependency current = enumerator.get_Current();
					IMetadata metadata2 = metadataServiceContext.GetMetadata(((Dependency)current).get_HeaderUid());
					Tuple<PropertyMetadata, ClassMetadata> val5 = FindUniquePropertyRecursively(metadataServiceContext, (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null));
					if (val5 != null)
					{
						propertyMap.Set(text, val5);
						return val5;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		propertyMap.Set(text, (Tuple<PropertyMetadata, ClassMetadata>)null);
		return null;
	}

	internal static Tuple<PropertyMetadata, ClassMetadata> FindPropertyRecursively(IMetadataServiceContext metadataServiceContext, ClassMetadata metadata, string propertyName)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.propertyName = propertyName;
		if (metadata == null)
		{
			return null;
		}
		Guid uid = ((IMetadata)metadata).get_Uid();
		string text = ((object)(Guid)(ref uid)).ToString() + "_" + CS_0024_003C_003E8__locals0.propertyName;
		if (propertyMap.Has(text))
		{
			return propertyMap.Get(text);
		}
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadata.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == CS_0024_003C_003E8__locals0.propertyName));
		if (val != null)
		{
			Tuple<PropertyMetadata, ClassMetadata> val2 = new Tuple<PropertyMetadata, ClassMetadata>(val, metadata);
			propertyMap.Set(text, val2);
			return val2;
		}
		DataClassMetadata val3;
		if ((val3 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
		{
			System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)val3.get_IncludeList()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					DataClassDependency current = enumerator.get_Current();
					IMetadata metadata2 = metadataServiceContext.GetMetadata(((Dependency)current).get_HeaderUid());
					Tuple<PropertyMetadata, ClassMetadata> val4 = FindPropertyRecursively(metadataServiceContext, (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null), CS_0024_003C_003E8__locals0.propertyName);
					if (val4 != null)
					{
						propertyMap.Set(text, val4);
						return val4;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		propertyMap.Set(text, (Tuple<PropertyMetadata, ClassMetadata>)null);
		return null;
	}
}

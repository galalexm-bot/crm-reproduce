using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class DescriptorService : IDescriptorService
{
	private bool initialized;

	private readonly ILazy<System.Collections.Generic.IEnumerable<ITypeDescriptor>> lazyDescriptors;

	private readonly Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor> typeDescriptorsByUid = new Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor>();

	private readonly Dictionary<System.Type, ITypeDescriptor> typeDescriptorsByType = new Dictionary<System.Type, ITypeDescriptor>();

	public DescriptorService(ILazy<System.Collections.Generic.IEnumerable<ITypeDescriptor>> lazyDescriptors)
	{
		this.lazyDescriptors = lazyDescriptors;
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Init();
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, subTypeUid), ref typeDescriptor);
		if (typeDescriptor != null)
		{
			return typeDescriptor;
		}
		typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, Guid.Empty), ref typeDescriptor);
		return typeDescriptor;
	}

	public ITypeDescriptor GetTypeDescriptor(System.Type runtimeType)
	{
		Init();
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		typeDescriptorsByType.TryGetValue(runtimeType, ref typeDescriptor);
		if (typeDescriptor == null && runtimeType.get_IsGenericType() && runtimeType.GetGenericTypeDefinition() == typeof(System.Nullable<>))
		{
			System.Type type = runtimeType.GetGenericArguments()[0];
			typeDescriptorsByType.TryGetValue(type, ref typeDescriptor);
		}
		return typeDescriptor;
	}

	public System.Collections.Generic.IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		Init();
		return (System.Collections.Generic.IEnumerable<ITypeDescriptor>)typeDescriptorsByUid.get_Values();
	}

	public bool IsSupportSort(Guid typeUid, Guid subTypeUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (GetTypeDescriptor(typeUid, subTypeUid) is ISortedProperty sortedProperty)
		{
			return sortedProperty.IsSupportSort();
		}
		return false;
	}

	private void Init()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (initialized)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<ITypeDescriptor> enumerator = lazyDescriptors.Value().GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ITypeDescriptor current = enumerator.get_Current();
				typeDescriptorsByUid.set_Item(new KeyValuePair<Guid, Guid>(current.Uid, current.SubTypeUid), current);
				if (current is IRuntimeTypeDescriptor runtimeTypeDescriptor && runtimeTypeDescriptor.IsRuntimeType)
				{
					typeDescriptorsByType.set_Item(runtimeTypeDescriptor.RuntimeType, current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		initialized = true;
	}
}

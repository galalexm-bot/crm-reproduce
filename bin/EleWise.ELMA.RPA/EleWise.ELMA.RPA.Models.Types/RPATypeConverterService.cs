using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.RPA.Model.Types.Converters;

namespace EleWise.ELMA.RPA.Models.Types.Converters;

[Service]
internal class RPATypeConverterService : IRPATypeConverterService
{
	private ConcurrentDictionary<Guid, ITypeDescriptor> cachedTypeDescriptorSelections = new ConcurrentDictionary<Guid, ITypeDescriptor>();

	private ConcurrentDictionary<Guid, IRPATypeConverter> cachedRPATypeConverterSelections = new ConcurrentDictionary<Guid, IRPATypeConverter>();

	public IEnumerable<ITypeDescriptor> ElmaTypeDescriptors { get; set; }

	public IEnumerable<IRPATypeConverter> RPATypeConverters { get; set; }

	public ITypeDescriptor GetElmaTypeDescriptor(IRPATypeConverter converter)
	{
		if (converter == null)
		{
			return null;
		}
		return cachedTypeDescriptorSelections.GetOrAdd(converter.ElmaTypeDescriptor, (Guid guid) => ElmaTypeDescriptors.FirstOrDefault((ITypeDescriptor d) => d.Uid == guid));
	}

	public IRPATypeConverter GetRPATypeConverter(Guid typeUid)
	{
		return cachedRPATypeConverterSelections.GetOrAdd(typeUid, (Guid guid) => RPATypeConverters.FirstOrDefault((IRPATypeConverter c) => c.ElmaTypeDescriptor == guid));
	}
}

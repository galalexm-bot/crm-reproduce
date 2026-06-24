using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IDescriptorService
{
	ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid);

	ITypeDescriptor GetTypeDescriptor(System.Type runtimeType);

	System.Collections.Generic.IEnumerable<ITypeDescriptor> GetTypeDescriptors();

	bool IsSupportSort(Guid typeUid, Guid subTypeUid);
}

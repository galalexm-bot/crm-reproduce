using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Types;

[ExtensionPoint(ComponentType.All)]
public interface IPlatformTypeDescriptorProvider
{
	IEnumerable<ITypeDescriptor> GetTypeDescriptors();
}

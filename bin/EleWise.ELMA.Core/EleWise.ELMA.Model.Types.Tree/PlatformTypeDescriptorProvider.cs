using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Tree;

[Component]
public abstract class PlatformTypeDescriptorProvider : IPlatformTypeDescriptorProvider
{
	public abstract System.Collections.Generic.IEnumerable<ITypeDescriptor> GetTypeDescriptors();
}

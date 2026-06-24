using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Tree;

[ExtensionPoint]
public interface IPlatformTypeDescriptorProvider
{
	System.Collections.Generic.IEnumerable<ITypeDescriptor> GetTypeDescriptors();
}

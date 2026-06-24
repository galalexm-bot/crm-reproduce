using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Tree;

[ExtensionPoint]
public interface ITypeDescriptorTree
{
	bool CanBuildTree(ITypeDescriptor typeDescriptor);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel);
}

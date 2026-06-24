using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Tree;

[Component]
internal sealed class SubTypeGroupDescriptorTree : ITypeDescriptorTree
{
	public bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is SubTypeGroupDescriptor;
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)((SubTypeGroupDescriptor)typeDescriptor).SubTypes);
	}
}

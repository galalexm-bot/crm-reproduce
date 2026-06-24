using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 2147483647)]
internal class TypeDescriptorTree : ITypeDescriptorTree
{
	public virtual bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return true;
	}

	public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)null);
	}
}

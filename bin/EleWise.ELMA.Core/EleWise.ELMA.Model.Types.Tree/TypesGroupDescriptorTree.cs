using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Types.Groups;

namespace EleWise.ELMA.Model.Types.Tree;

[Component]
internal class TypesGroupDescriptorTree : ITypeDescriptorTree
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public TypesGroupDescriptor groupDescriptor;

		internal bool _003CGetSubTypes_003Eb__0(ITypeDescriptor t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (t.Visible)
			{
				return t.ParentUid == groupDescriptor.Uid;
			}
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ITypeDescriptor, string> _003C_003E9__3_1;

		internal string _003CGetSubTypes_003Eb__3_1(ITypeDescriptor t)
		{
			return t.Name;
		}
	}

	private readonly IDescriptorService descriptorService;

	public TypesGroupDescriptorTree(IDescriptorService descriptorService)
	{
		this.descriptorService = descriptorService;
	}

	public bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is TypesGroupDescriptor;
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.groupDescriptor = (TypesGroupDescriptor)typeDescriptor;
		EnumerableInstance<ITypeDescriptor> val = Enumerable.Where<ITypeDescriptor>(descriptorService.GetTypeDescriptors(), (Func<ITypeDescriptor, bool>)((ITypeDescriptor t) => t.Visible && t.ParentUid == CS_0024_003C_003E8__locals0.groupDescriptor.Uid));
		if (CS_0024_003C_003E8__locals0.groupDescriptor.OrderTypesByName)
		{
			val = (EnumerableInstance<ITypeDescriptor>)(object)val.OrderBy<string>((Func<ITypeDescriptor, string>)((ITypeDescriptor t) => t.Name));
		}
		return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)val);
	}
}

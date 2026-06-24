using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Types.Settings.Groups;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 300)]
internal sealed class PlatformDescriptorTree : EntityDescriptorTree
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<IPlatformTypeDescriptorProvider, System.Collections.Generic.IEnumerable<ITypeDescriptor>> _003C_003E9__3_0;

		public static Func<ITypeDescriptor, bool> _003C_003E9__3_1;

		public static Func<ITypeDescriptor, string> _003C_003E9__3_2;

		internal System.Collections.Generic.IEnumerable<ITypeDescriptor> _003CGetSubTypes_003Eb__3_0(IPlatformTypeDescriptorProvider p)
		{
			return p.GetTypeDescriptors();
		}

		internal bool _003CGetSubTypes_003Eb__3_1(ITypeDescriptor t)
		{
			return t != null;
		}

		internal string _003CGetSubTypes_003Eb__3_2(ITypeDescriptor t)
		{
			return t.Name;
		}
	}

	private readonly System.Collections.Generic.IEnumerable<IPlatformTypeDescriptorProvider> providers;

	public PlatformDescriptorTree(System.Collections.Generic.IEnumerable<IPlatformTypeDescriptorProvider> providers, IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
		: base(metadataService, metadataItemGroupManager)
	{
		this.providers = providers;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is PlatformTypeDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)Enumerable.SelectMany<IPlatformTypeDescriptorProvider, ITypeDescriptor>(providers, (Func<IPlatformTypeDescriptorProvider, System.Collections.Generic.IEnumerable<ITypeDescriptor>>)((IPlatformTypeDescriptorProvider p) => p.GetTypeDescriptors())).Where((Func<ITypeDescriptor, bool>)((ITypeDescriptor t) => t != null)).OrderBy<string>((Func<ITypeDescriptor, string>)((ITypeDescriptor t) => t.Name)));
	}
}

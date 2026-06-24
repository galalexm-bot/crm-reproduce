using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Helpers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 600)]
internal sealed class EnumDescriptorTree : TypeDescriptorTree
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<MetadataHeader, bool> _003C_003E9__4_0;

		public static Func<MetadataHeader, string> _003C_003E9__4_1;

		internal bool _003CGetSubTypes_003Eb__4_0(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			if (a.get_MetadataType() == MetadataConstants.EnumMetadataTypeUid)
			{
				return a.get_ShowInTypeTree();
			}
			return false;
		}

		internal string _003CGetSubTypes_003Eb__4_1(MetadataHeader m)
		{
			return m.get_DisplayName();
		}
	}

	private readonly IMetadataServiceContext metadataService;

	private readonly MetadataItemGroupManager metadataItemGroupManager;

	public EnumDescriptorTree(IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
	{
		this.metadataService = metadataService;
		this.metadataItemGroupManager = metadataItemGroupManager;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is EnumDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		OrderedEnumerable<MetadataHeader> metadataList = Enumerable.Where<MetadataHeader>(metadataService.GetMetadataHeaders(filterModel.WithDrafts), (Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_MetadataType() == MetadataConstants.EnumMetadataTypeUid && a.get_ShowInTypeTree())).OrderBy<string>((Func<MetadataHeader, string>)((MetadataHeader m) => m.get_DisplayName()));
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(typeDescriptor, (System.Collections.Generic.IEnumerable<MetadataHeader>)metadataList, metadataItemGroupManager, metadataService);
	}
}

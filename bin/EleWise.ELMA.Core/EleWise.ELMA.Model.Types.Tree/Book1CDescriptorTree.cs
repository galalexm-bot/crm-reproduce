using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Helpers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 450)]
internal sealed class Book1CDescriptorTree : TypeDescriptorTree
{
	private readonly IMetadataServiceContext metadataService;

	private readonly MetadataItemGroupManager metadataItemGroupManager;

	public Book1CDescriptorTree(IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
	{
		this.metadataService = metadataService;
		this.metadataItemGroupManager = metadataItemGroupManager;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is Book1CDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerable<MetadataHeader> subTypes = EntityDescriptorTree.GetSubTypes(metadataService, filterModel, MetadataConstants.Book1CMetadataTypeUid);
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(typeDescriptor, subTypes, metadataItemGroupManager, metadataService);
	}
}

using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Helpers;

public static class CompositeTypeDescriptorHelper
{
	public static IEnumerable<ITypeDescriptor> GetDescriptorsByGroups(ITypeDescriptor baseTypeDescriptor, List<NamedMetadata> metadataList)
	{
		List<ITypeDescriptor> list = new List<ITypeDescriptor>();
		MetadataTreeHelper.GroupNode metadataGroup = MetadataTreeHelper.BuildTree(metadataList.OfType<ICodeItemMetadata>());
		FillDescriptors(baseTypeDescriptor, list, metadataGroup);
		return list;
	}

	private static void FillDescriptors(object baseTypeDescriptor, List<ITypeDescriptor> descriptors, object metadataGroup)
	{
		foreach (MetadataTreeHelper.GroupNode groupNode in ((MetadataTreeHelper.GroupNode)metadataGroup).GroupNodes)
		{
			SubTypeGroupDescriptor subTypeGroupDescriptor = new SubTypeGroupDescriptor(SR.T(groupNode.Name), (ITypeDescriptor)baseTypeDescriptor);
			descriptors.Add(subTypeGroupDescriptor);
			FillDescriptors(baseTypeDescriptor, subTypeGroupDescriptor.SubTypes, groupNode);
		}
		foreach (MetadataTreeHelper.MetadataNode metadataNode in ((MetadataTreeHelper.GroupNode)metadataGroup).MetadataNodes)
		{
			ICodeItemMetadata metadata = metadataNode.Metadata;
			SubTypeDescriptor item = new SubTypeDescriptor((ITypeDescriptor)baseTypeDescriptor, metadata.Uid, metadataNode.Name);
			descriptors.Add(item);
		}
	}
}

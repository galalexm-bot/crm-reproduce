using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Types.Settings.Groups;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 305)]
internal sealed class LocalDataClassesDescriptorTree : DataClassDescriptorTree
{
	private readonly DataClassDescriptor dataClassDescriptor;

	public LocalDataClassesDescriptorTree(DataClassDescriptor dataClassDescriptor, IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
		: base(metadataService, metadataItemGroupManager)
	{
		this.dataClassDescriptor = dataClassDescriptor;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is LocalDataClassDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		IMetadata rootMetadata = filterModel.RootMetadata;
		ComponentMetadata val;
		if ((val = (ComponentMetadata)(object)((rootMetadata is ComponentMetadata) ? rootMetadata : null)) != null)
		{
			ITypeDescriptor[] array = new ITypeDescriptor[0];
			System.Collections.Generic.IEnumerator<DataClassMetadata> enumerator = ((System.Collections.Generic.IEnumerable<DataClassMetadata>)val.get_DataClasses()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					DataClassMetadata current = enumerator.get_Current();
					ArrayExtensions.Push<ITypeDescriptor>(array, new ITypeDescriptor[1]
					{
						new SubTypeDescriptor(dataClassDescriptor, ((IMetadata)current).get_Uid(), ((INamedMetadata)current).get_DisplayName())
					});
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)array);
		}
		return System.Threading.Tasks.Task.FromResult<System.Collections.Generic.IEnumerable<ITypeDescriptor>>((System.Collections.Generic.IEnumerable<ITypeDescriptor>)Enumerable.Empty<ITypeDescriptor>());
	}
}

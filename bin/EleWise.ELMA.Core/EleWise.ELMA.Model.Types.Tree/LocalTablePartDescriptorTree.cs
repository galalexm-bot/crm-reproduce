using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Types.Settings.Groups;

namespace EleWise.ELMA.Model.Types.Tree;

[Component(Order = 305)]
internal sealed class LocalTablePartDescriptorTree : EntityDescriptorTree
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__3_0;

		internal bool _003CGetSubTypes_003Eb__3_0(PropertyMetadata a)
		{
			return a.get_IsSystem();
		}
	}

	private readonly EntityDescriptor entityDescriptor;

	public LocalTablePartDescriptorTree(EntityDescriptor entityDescriptor, IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
		: base(metadataService, metadataItemGroupManager)
	{
		this.entityDescriptor = entityDescriptor;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is LocalTablePartDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		IMetadata rootMetadata = filterModel.RootMetadata;
		DataClassMetadata val;
		if ((val = (DataClassMetadata)(object)((rootMetadata is DataClassMetadata) ? rootMetadata : null)) != null)
		{
			ITypeDescriptor[] array = new ITypeDescriptor[0];
			System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = Enumerable.Where<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => a.get_IsSystem())).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					Guid subTypeUid = ((IPropertyMetadata)enumerator.get_Current()).get_SubTypeUid();
					if (subTypeUid == Guid.Empty)
					{
						continue;
					}
					IMetadata metadata = metadataService.GetMetadata(subTypeUid);
					EntityMetadata val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null);
					if (val2 == null)
					{
						continue;
					}
					System.Collections.Generic.IEnumerator<TablePartMetadata> enumerator2 = ((System.Collections.Generic.IEnumerable<TablePartMetadata>)val2.get_TableParts()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							TablePartMetadata current = enumerator2.get_Current();
							ArrayExtensions.Push<ITypeDescriptor>(array, new ITypeDescriptor[1]
							{
								new SubTypeDescriptor(entityDescriptor, ((IMetadata)current).get_Uid(), ((INamedMetadata)current).get_DisplayName())
							});
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
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

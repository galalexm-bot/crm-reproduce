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

[Component(Order = 400)]
internal class EntityDescriptorTree : TypeDescriptorTree
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Guid metadataType;

		public bool showInCatalogList;

		internal bool _003CGetSubTypes_003Eb__0(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			if (a.get_MetadataType() == metadataType && a.get_ShowInTypeTree())
			{
				if (showInCatalogList)
				{
					return a.get_ShowInCatalogList();
				}
				return true;
			}
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<MetadataHeader, string> _003C_003E9__6_1;

		internal string _003CGetSubTypes_003Eb__6_1(MetadataHeader m)
		{
			return m.get_DisplayName();
		}
	}

	protected readonly IMetadataServiceContext metadataService;

	protected readonly MetadataItemGroupManager metadataItemGroupManager;

	public EntityDescriptorTree(IMetadataServiceContext metadataService, MetadataItemGroupManager metadataItemGroupManager)
	{
		this.metadataService = metadataService;
		this.metadataItemGroupManager = metadataItemGroupManager;
	}

	public override bool CanBuildTree(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is EntityDescriptor;
	}

	public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ITypeDescriptor>> GetSubTypes(ITypeDescriptor typeDescriptor, ITypeDescriptorTreeFilterModel filterModel)
	{
		System.Collections.Generic.IEnumerable<MetadataHeader> subTypes = GetSubTypes(filterModel);
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(typeDescriptor, subTypes, metadataItemGroupManager, metadataService);
	}

	internal virtual System.Collections.Generic.IEnumerable<MetadataHeader> GetSubTypes(ITypeDescriptorTreeFilterModel filterModel)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return GetSubTypes(metadataService, filterModel, MetadataConstants.EntityMetadataTypeUid);
	}

	internal static System.Collections.Generic.IEnumerable<MetadataHeader> GetSubTypes(IMetadataServiceContext metadataService, ITypeDescriptorTreeFilterModel filterModel, Guid metadataType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.metadataType = metadataType;
		CS_0024_003C_003E8__locals0.showInCatalogList = filterModel.ShowInCatalogList;
		return (System.Collections.Generic.IEnumerable<MetadataHeader>)Enumerable.Where<MetadataHeader>(metadataService.GetMetadataHeaders(filterModel.WithDrafts), (Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_MetadataType() == CS_0024_003C_003E8__locals0.metadataType && a.get_ShowInTypeTree() && (!CS_0024_003C_003E8__locals0.showInCatalogList || a.get_ShowInCatalogList()))).OrderBy<string>((Func<MetadataHeader, string>)((MetadataHeader m) => m.get_DisplayName()));
	}
}

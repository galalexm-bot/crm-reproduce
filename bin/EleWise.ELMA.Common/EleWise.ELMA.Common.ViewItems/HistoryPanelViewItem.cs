using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Common.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_HistoryPanelViewItem), "DisplayName")]
public class HistoryPanelViewItem : ViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<HistoryPanelViewItem>
	{
		public IMetadataEditorService MetadataEditorService { get; set; }

		public override bool IsAvailable(IMetadata metadata)
		{
			bool? flag = (from e in ComponentManager.Current.GetExtensionPoints<IHistoryPanelViewItemAvailable>()
				select e.IsAvailable(metadata)).FirstOrDefault((bool? r) => r.HasValue);
			if (flag.HasValue)
			{
				return flag.Value;
			}
			for (EntityMetadata entityMetadata = metadata as EntityMetadata; entityMetadata != null; entityMetadata = ((entityMetadata.BaseClassUid != Guid.Empty) ? (MetadataEditorService.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata) : null))
			{
				while (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
				{
					entityMetadata = MetadataEditorService.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata;
				}
				if (entityMetadata.SaveHistory)
				{
					return true;
				}
			}
			return false;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}

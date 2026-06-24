using System;

namespace EleWise.ELMA.Model.Views;

public interface ITreeViewItem : IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	Guid KeyUid { get; set; }

	Guid ParentKeyUid { get; set; }
}

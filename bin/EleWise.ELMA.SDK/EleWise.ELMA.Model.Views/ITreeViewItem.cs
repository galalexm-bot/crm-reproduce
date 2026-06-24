using System;

namespace EleWise.ELMA.Model.Views;

internal interface ITreeViewItem : IDynamicViewItem, IViewItemWithPropertyParents
{
	Guid KeyUid { get; set; }

	Guid ParentKeyUid { get; set; }
}

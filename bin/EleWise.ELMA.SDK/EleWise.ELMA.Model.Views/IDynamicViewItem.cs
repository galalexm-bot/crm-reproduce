using System;

namespace EleWise.ELMA.Model.Views;

internal interface IDynamicViewItem : IViewItemWithPropertyParents
{
	Guid PropertyUid { get; set; }
}

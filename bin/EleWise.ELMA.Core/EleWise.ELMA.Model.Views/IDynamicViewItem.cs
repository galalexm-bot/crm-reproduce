using System;

namespace EleWise.ELMA.Model.Views;

public interface IDynamicViewItem : IViewItemWithPropertyParents, IViewItem, IReactive
{
	Guid PropertyUid { get; set; }
}

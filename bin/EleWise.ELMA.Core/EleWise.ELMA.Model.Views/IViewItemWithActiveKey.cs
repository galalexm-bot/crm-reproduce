using System;

namespace EleWise.ELMA.Model.Views;

public interface IViewItemWithActiveKey : IViewItemWithPropertyParents, IViewItem, IReactive
{
	Guid ActiveKeyProperty { get; set; }
}

using System;

namespace EleWise.ELMA.Model.Views;

public interface IViewItemWithActiveKey : IViewItemWithPropertyParents
{
	Guid ActiveKeyProperty { get; set; }
}

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface IViewItemWithPropertyParents : IViewItem, IReactive
{
	System.Collections.Generic.ICollection<Guid> PropertyParents { get; set; }
}

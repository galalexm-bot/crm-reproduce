using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface IViewItemWithPropertyParents
{
	List<Guid> PropertyParents { get; set; }
}

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface ISelectionItemViewItem
{
	bool EnableSelection { get; set; }

	Guid SelectablePropertyUid { get; set; }

	List<Guid> SelectablePropertyParents { get; set; }
}

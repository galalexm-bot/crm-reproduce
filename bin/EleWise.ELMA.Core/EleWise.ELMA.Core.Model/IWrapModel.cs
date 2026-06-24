using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Core.Model;

public interface IWrapModel
{
	Guid Uid { get; set; }

	Guid SubTypeUid { get; set; }

	System.Type Type { get; set; }

	string TypeName { get; set; }

	string Caption { get; set; }

	bool IsContainer { get; set; }

	System.Collections.Generic.ICollection<Guid> PropertyParents { get; set; }

	string SlotName { get; set; }
}

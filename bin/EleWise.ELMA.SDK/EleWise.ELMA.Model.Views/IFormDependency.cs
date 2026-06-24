using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface IFormDependency
{
	string Name { get; }

	IList<Guid> FormUids { get; }

	bool DefaultDependency { get; set; }
}

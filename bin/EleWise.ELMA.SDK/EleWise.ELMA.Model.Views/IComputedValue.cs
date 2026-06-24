using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface IComputedValue
{
	string Name { get; set; }

	object Value { get; set; }

	string MethodName { get; set; }

	string CalculateScript { get; set; }

	ComputedValueType ComputedValueType { get; set; }

	Guid PropertyUid { get; set; }

	List<Guid> PropertyParents { get; set; }
}

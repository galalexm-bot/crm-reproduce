using System;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Views;

public interface IInputComputedValue : IComputedValue
{
	Guid TypeUid { get; set; }

	Guid SubTypeUid { get; set; }

	bool Required { get; set; }

	bool Nullable { get; set; }

	RelationType RelationType { get; set; }
}

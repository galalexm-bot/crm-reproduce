using System.Collections.Generic;

namespace EleWise.ELMA.Modules;

public interface ICompositeApplicationUnit : IApplicationUnit
{
	IEnumerable<IApplicationUnit> Units { get; }
}

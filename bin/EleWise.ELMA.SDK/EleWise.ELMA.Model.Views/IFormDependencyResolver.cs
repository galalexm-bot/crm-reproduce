using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views;

public interface IFormDependencyResolver
{
	IEnumerable<IFormDependency> GetDependencies();
}

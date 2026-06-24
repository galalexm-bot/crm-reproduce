using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ICompatibilityChecker
{
	bool Check(object obj);

	ICollection<string> CheckCompatibility(object old, object @new);
}
public interface ICompatibilityChecker<T> : ICompatibilityChecker
{
	ICollection<string> CheckCompatibility(T old, T @new);
}

using System.Collections.Generic;

namespace EleWise.ELMA.Dynamic;

public interface IExtendedPropertiesContainer
{
	IDictionary<string, object> ExtendedProperties { get; }
}

using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface ILocalizableType
{
	IEnumerable<string> GetLocalizableStrings(PropertyMetadata propertyMetadata);
}

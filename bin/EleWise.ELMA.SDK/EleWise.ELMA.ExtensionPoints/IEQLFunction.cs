using System.Collections.Generic;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.ExtensionPoints;

public interface IEQLFunction
{
	IEnumerable<EQLFunction> GetEqlFunctions();
}

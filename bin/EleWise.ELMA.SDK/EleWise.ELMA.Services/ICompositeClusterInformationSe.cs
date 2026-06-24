using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Services;

public interface ICompositeClusterInformationService
{
	IEnumerable<Guid> GetActiveConnectionUids();
}

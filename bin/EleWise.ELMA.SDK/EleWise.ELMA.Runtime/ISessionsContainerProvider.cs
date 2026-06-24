using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime;

public interface ISessionsContainerProvider
{
	IDictionary<Guid, ISessionsContainer> GetSessionsContainers();
}

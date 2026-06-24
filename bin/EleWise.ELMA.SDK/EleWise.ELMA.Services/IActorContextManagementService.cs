using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Services;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IActorContextManagementService : IActorContextService
{
	IDictionary<string, object> Get();

	void Set(IDictionary<string, object> incomingContext);
}

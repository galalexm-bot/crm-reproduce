using System;
using System.Collections.Generic;

namespace EleWise.ELMA.API.Models;

public interface IClientSessionDataSets
{
	string SessionToken { get; }

	List<Guid> DataSets { get; }
}

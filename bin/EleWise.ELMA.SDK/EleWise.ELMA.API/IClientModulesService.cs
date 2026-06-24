using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;

namespace EleWise.ELMA.API;

public interface IClientModulesService
{
	IClientSessionDataSets GetSessionModules(string sessionToken);

	bool UpdateDataSets(string sessionToken, List<Guid> dataSets);
}

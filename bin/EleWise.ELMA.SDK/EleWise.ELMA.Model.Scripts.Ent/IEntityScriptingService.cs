using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Scripts.Entities;

public interface IEntityScriptingService
{
	Type GetScriptModuleType(IEntity entity);

	Type GetScriptModuleItemType(IEntity entity);

	object GetScriptInstance(IEntity entity);

	object ExecuteScript(IEntity entity, string scriptName, Dictionary<string, object> parameters = null, Func<string, Type, object> parameterAccessor = null);
}

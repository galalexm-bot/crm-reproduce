using System;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Services;

internal interface IScriptLoader
{
	ScriptModule GetScript(Guid? scriptUid);
}

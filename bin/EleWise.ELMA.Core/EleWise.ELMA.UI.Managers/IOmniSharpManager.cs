using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.OmniSharp.Model;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.UI.Managers;

[ServiceContract]
public interface IOmniSharpManager
{
	System.Threading.Tasks.Task StartServer(bool needRestart);

	System.Threading.Tasks.Task InitWorkspace(NamedMetadata metadata, ScriptModule clientScriptModule, ScriptModule viewScriptModule, ScriptModule serverScriptModule, ScriptModule testScriptModule, CodeType codeType, string methodName);

	OmniSharpItem GetOmniSharpItem();

	void SetOmniSharpItem(OmniSharpItem item);

	System.Threading.Tasks.Task AddReferences(AddReferencesModel model);

	System.Threading.Tasks.Task RemoveReferences(string[] assemblyNames, Guid[] globalModulesUids, string[] webReferencesNames);
}

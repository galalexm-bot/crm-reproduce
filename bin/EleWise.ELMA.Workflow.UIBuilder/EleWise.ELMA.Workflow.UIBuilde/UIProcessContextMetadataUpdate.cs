using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.UIBuilder.Components;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.UIBuilder.Components;

[Component]
internal sealed class UIProcessContextMetadataUpdateDataHandler : BaseMetadataUpdateDataHandler
{
	private readonly WorkflowProcessManager processManager;

	public UIProcessContextMetadataUpdateDataHandler(WorkflowProcessManager processManager, ScriptModuleManager scriptModuleManager)
		: base(scriptModuleManager)
	{
		this.processManager = processManager;
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is ProcessContext;
	}

	public override IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
	{
		ProcessContext context;
		if ((context = updateResult.Metadata as ProcessContext) != null)
		{
			IWorkflowProcess workflowProcess = processManager.Find((IWorkflowProcess p) => p.Context.Id == context.Id).FirstOrDefault();
			if (workflowProcess != null && workflowProcess.Header != null && workflowProcess.Header.Current != null && workflowProcess.Header.Current.Context.Id == context.Id)
			{
				updateResult.Entities.Add(workflowProcess);
				return new ScriptModule[1] { CreateClientScriptModule(context) };
			}
		}
		return Enumerable.Empty<ScriptModule>();
	}

	public IEnumerable<Guid> GetFormUids(IMetadata metadata)
	{
		return Enumerable.Empty<Guid>();
	}

	private ScriptModule CreateClientScriptModule(ProcessContext context)
	{
		ScriptModule scriptModule = ScriptModuleManager.Create();
		scriptModule.Uid = Guid.NewGuid();
		scriptModule.ObjectUid = context.Uid;
		scriptModule.Namespace = context.Namespace;
		scriptModule.ClassName = context.Name + "_Scripts";
		scriptModule.AssemblyName = scriptModule.ClassName;
		scriptModule.ModuleName = scriptModule.ClassName;
		scriptModule.ModuleTypeUid = ClientScriptModuleType.TypeUid;
		return scriptModule;
	}
}

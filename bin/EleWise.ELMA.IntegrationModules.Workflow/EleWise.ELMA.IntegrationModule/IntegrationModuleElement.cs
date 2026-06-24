using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Validation;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Elements;

[Serializable]
[WebDiagrammerShape(typeof(WebDiagrammerIntegrationShape))]
[Shape(typeof(IntegrationModuleShape))]
[HintShape(typeof(IntegrationModuleHintShape))]
public class IntegrationModuleElement : TaskElement, IExceptionFlowSupported
{
	internal class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private string name;

		private Guid groupUid;

		private Image image;

		public string Name => name;

		public Guid GroupUid => groupUid;

		public Image Image => image;

		public Type ElementType => typeof(IntegrationModuleElement);

		public string ElementIcon => "integration";

		public ToolboxItem(string name, Guid groupUid, Image image)
		{
			this.name = name;
			this.groupUid = groupUid;
			this.image = image;
		}
	}

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[3]
	{
		EventTrigger.Timer,
		EventTrigger.Script,
		EventTrigger.ErrorCatch
	};

	public Guid IntegrationModuleHeaderMetadataUid { get; set; }

	public Guid? IntegrationModuleUid { get; set; }

	public Guid ActivityUid { get; set; }

	public Guid IntegrationPropertyUid { get; set; }

	public PropertyMap InputPropertyMap { get; set; }

	public PropertyMap OutputPropertyMap { get; set; }

	public override void Validate(WorkflowProcessValidator validator)
	{
		base.Validate(validator);
		if ((!IntegrationModuleUid.HasValue || IntegrationModuleUid.Equals(Guid.Empty)) && IntegrationPropertyUid.Equals(Guid.Empty))
		{
			validator.Messages.Add(base.ValidationHelper.CreateValidationError(SR.T("В элементе \"{0}\" должны быть выбраны настройки интеграции", Name)));
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		base.ReplaceContextVar(replaceContextVar);
		InputPropertyMap?.ReplaceContextVars(replaceContextVar);
		OutputPropertyMap?.ReplaceContextVars(replaceContextVar);
		if (replaceContextVar.TryGetValue(IntegrationPropertyUid, out var value))
		{
			IntegrationPropertyUid = value;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.RPA.BPMN.Diagrams.Shapes.RPAIntegration;
using EleWise.ELMA.RPA.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Properties;
using EleWise.ELMA.Workflow.BPMN;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.RPA.BPMN.Diagrams.Elements.RPAIntegration;

[Serializable]
[Shape(typeof(RPAIntegrationShape))]
[WebDiagrammerShape(typeof(WebDiagrammerOrangeRectangleElementShape))]
[HintShape(typeof(RPAIntegrationHintShape))]
public class RPAIntegrationElement : BPMNFlowElement, IExceptionFlowSupported, IReplaceContextVar, IElementWithPropertyMap
{
	[Component(Order = 100)]
	private class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		public string Name => SR.T("Запуск процесса RPA");

		public Guid GroupUid => RPAProcessesElements.UID;

		public Image Image => Resources.rpa_process;

		public Type ElementType => typeof(RPAIntegrationElement);

		public string ElementIcon => "rpa";
	}

	public override string DefaultName => SR.T("Процесс RPA");

	public virtual RPAProcessDTO RPAProcess { get; set; }

	public ClassMetadata RPAProcessClassMetadata { get; set; }

	public PropertyMap InputContextMap { get; set; }

	public PropertyMap OutputContextMap { get; set; }

	public PropertyMap[] UsingPropertyMap => new PropertyMap[2] { InputContextMap, OutputContextMap };

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.ErrorCatch
	};

	public override string ChapterName => SR.T("Процессы RPA");

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		base.ReplaceContextVar(replaceContextVar);
		OutputContextMap?.ReplaceContextVars(replaceContextVar);
		InputContextMap?.ReplaceContextVars(replaceContextVar);
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		return string.Empty;
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format("#{0}", swimlane.Uid.ToString().Replace("-", "")), swimlane.Name);
			stringBuilder.Append(string.Format("<b>{0}: </b>{1}<br>", SR.T("Зона Ответственности"), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append("<b>" + SR.T("Описание") + ": </b>" + element.Description);
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<tr><td>" + GetConnectorsLink());
		stringBuilder.Append("</td></tr></table>");
		return stringBuilder.ToString();
	}
}

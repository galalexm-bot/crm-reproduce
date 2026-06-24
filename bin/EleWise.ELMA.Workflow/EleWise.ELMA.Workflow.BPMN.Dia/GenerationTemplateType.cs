using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;

[DisplayName(typeof(__Resources_GenerationTemplateType), "DisplayName")]
public enum GenerationTemplateType
{
	None,
	[DisplayName(typeof(__Resources_GenerationTemplateType), "P_File_DisplayName")]
	File,
	[DisplayName(typeof(__Resources_GenerationTemplateType), "P_Document_DisplayName")]
	Document,
	[DisplayName(typeof(__Resources_GenerationTemplateType), "P_ContextVar_DisplayName")]
	ContextVar
}

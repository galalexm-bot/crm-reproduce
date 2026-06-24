using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Model.Diagrammer;

public interface IDiagrammerTransition : IDiagrammerElement, ICloneableObjectLiteral
{
	[Name("source")]
	string Source { get; set; }

	[Name("target")]
	string Target { get; set; }

	[Name("sourceX")]
	double? SourceX { get; set; }

	[Name("sourceY")]
	double? SourceY { get; set; }

	[Name("targetX")]
	double? TargetX { get; set; }

	[Name("targetY")]
	double? TargetY { get; set; }

	[Name("startMarker")]
	HTMLElement StartMarker { get; set; }

	[Name("startMarkerId")]
	string StartMarkerId { get; set; }

	[Name("default")]
	bool Default { get; set; }

	[Name("path")]
	DiagrammerPoint[] Path { get; set; }

	[Name("strokeWidth")]
	int StrokeWidth { get; set; }

	[Name("strokeColor")]
	string StrokeColor { get; set; }

	[Name("lineStyle")]
	DiagrammerLineStyle LineStyle { get; set; }

	[Name("disablePath")]
	bool DisablePath { get; set; }

	[Name("hideArrow")]
	bool HideArrow { get; set; }
}

using System;
using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Model.Diagrammer;

public interface IDiagrammerElement : ICloneableObjectLiteral
{
	[Name("id")]
	string Id { get; set; }

	[Name("displayName")]
	string DisplayName { get; set; }

	[Name("name")]
	string Name { get; set; }

	[Name("kind")]
	DiagrammerElementKind Kind { get; }

	[Name("portal")]
	HTMLElement PortalElement { get; set; }

	[Name("selected")]
	bool Selected { get; set; }

	[Name("onClick")]
	Action OnClick { get; set; }

	[Name("onDoubleClick")]
	Action OnDoubleClick { get; set; }

	Action<bool> OnSelected { get; set; }

	void CopyTo(IDiagrammerElement element);
}

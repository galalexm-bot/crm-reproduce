using System;
using EleWise.ELMA.Model.Diagrammer;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal interface IDiagrammerTransitionViewItem : IDiagrammerShapeViewItem, IViewItem, IReactive
{
	Guid Source { get; set; }

	Guid Target { get; set; }

	string StartMarker { get; set; }

	DiagrammerLineStyle LineStyle { get; set; }

	bool DisablePath { get; set; }

	bool HideArrow { get; set; }
}

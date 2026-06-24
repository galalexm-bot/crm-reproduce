using System;

namespace EleWise.ELMA.Model.Views.Diagrammer;

public interface IDiagrammerShapeViewItem : IViewItem, IReactive
{
	Guid Id { get; set; }

	string Type { get; set; }

	Guid PropertyUid { get; set; }

	bool IsSelected { get; set; }
}

using System;
using System.Collections.Generic;

namespace Orchard.DisplayManagement.Implementation;

public class ShapeCreatingContext
{
	public IShapeFactory ShapeFactory { get; set; }

	public dynamic New { get; set; }

	public string ShapeType { get; set; }

	public Func<dynamic> Create { get; set; }

	public IList<Action<ShapeCreatedContext>> OnCreated { get; set; }
}

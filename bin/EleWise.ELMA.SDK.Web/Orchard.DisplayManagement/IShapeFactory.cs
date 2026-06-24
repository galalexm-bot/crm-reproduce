using System;

namespace Orchard.DisplayManagement;

public interface IShapeFactory : IDependency
{
	IShape Create(string shapeType);

	IShape Create(string shapeType, INamedEnumerable<object> parameters);

	IShape Create(string shapeType, INamedEnumerable<object> parameters, Func<dynamic> createShape);
}

using System;
using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapeAlteration
{
	private readonly IList<Action<ShapeDescriptor>> _configurations;

	public string ShapeType { get; private set; }

	public Feature Feature { get; private set; }

	public ShapeAlteration(string shapeType, Feature feature, IList<Action<ShapeDescriptor>> configurations)
	{
		_configurations = configurations;
		ShapeType = shapeType;
		Feature = feature;
	}

	public void Alter(ShapeDescriptor descriptor)
	{
		foreach (Action<ShapeDescriptor> configuration in _configurations)
		{
			configuration(descriptor);
		}
	}
}

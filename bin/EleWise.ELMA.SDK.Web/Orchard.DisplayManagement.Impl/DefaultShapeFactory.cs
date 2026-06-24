using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using Orchard.DisplayManagement.Descriptors;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.DisplayManagement.Implementation;

public class DefaultShapeFactory : Composite, IShapeFactory, IDependency
{
	private readonly IEnumerable<Lazy<IShapeFactoryEvents>> _events;

	private readonly Lazy<IShapeTableLocator> _shapeTableLocator;

	public DefaultShapeFactory(IEnumerable<Lazy<IShapeFactoryEvents>> events, Lazy<IShapeTableLocator> shapeTableLocator)
	{
		_events = events;
		_shapeTableLocator = shapeTableLocator;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		result = Create(binder.Name, Arguments.From(args, binder.CallInfo.ArgumentNames));
		return true;
	}

	public IShape Create(string shapeType)
	{
		return Create(shapeType, Arguments.Empty(), () => new Shape());
	}

	public IShape Create(string shapeType, INamedEnumerable<object> parameters)
	{
		return Create(shapeType, parameters, () => new Shape());
	}

	public IShape Create(string shapeType, INamedEnumerable<object> parameters, Func<dynamic> createShape)
	{
		_shapeTableLocator.Value.Lookup(null).Descriptors.TryGetValue(shapeType, out var value);
		parameters = parameters ?? Arguments.Empty();
		ShapeCreatingContext shapeCreatingContext = new ShapeCreatingContext
		{
			New = this,
			ShapeFactory = this,
			ShapeType = shapeType,
			OnCreated = new List<Action<ShapeCreatedContext>>()
		};
		IEnumerable<object> source = parameters.Positional.ToList();
		Type baseType = source.FirstOrDefault() as Type;
		if (baseType == null)
		{
			shapeCreatingContext.Create = createShape ?? ((Func<object>)(() => new Shape()));
		}
		else
		{
			source = source.Skip(1);
			shapeCreatingContext.Create = () => Activator.CreateInstance(baseType);
		}
		foreach (Lazy<IShapeFactoryEvents> @event in _events)
		{
			@event.Value.Creating(shapeCreatingContext);
		}
		if (value != null)
		{
			foreach (Action<ShapeCreatingContext> item in value.Creating)
			{
				item(shapeCreatingContext);
			}
		}
		ShapeCreatedContext shapeCreatedContext = new ShapeCreatedContext
		{
			New = shapeCreatingContext.New,
			ShapeType = shapeCreatingContext.ShapeType,
			Shape = shapeCreatingContext.Create()
		};
		if (!(shapeCreatedContext.Shape is IShape))
		{
			throw new InvalidOperationException("Invalid base type for shape: " + shapeCreatedContext.Shape.GetType().ToString());
		}
		ShapeMetadata shapeMetadata = shapeCreatedContext.Shape.Metadata;
		shapeCreatedContext.Shape.Metadata.Type = shapeType;
		if (value != null)
		{
			shapeMetadata.Wrappers = shapeMetadata.Wrappers.Concat(value.Wrappers).ToList();
		}
		foreach (Lazy<IShapeFactoryEvents> event2 in _events)
		{
			event2.Value.Created(shapeCreatedContext);
		}
		if (value != null)
		{
			foreach (Action<ShapeCreatedContext> item2 in value.Created)
			{
				item2(shapeCreatedContext);
			}
		}
		foreach (Action<ShapeCreatedContext> item3 in shapeCreatingContext.OnCreated)
		{
			item3(shapeCreatedContext);
		}
		object obj = source.SingleOrDefault();
		if (obj != null)
		{
			PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				shapeCreatedContext.Shape[propertyInfo.Name] = propertyInfo.GetValue(obj, null);
			}
		}
		foreach (KeyValuePair<string, object> item4 in parameters.Named)
		{
			shapeCreatedContext.Shape[item4.Key] = item4.Value;
		}
		return shapeCreatedContext.Shape;
	}
}

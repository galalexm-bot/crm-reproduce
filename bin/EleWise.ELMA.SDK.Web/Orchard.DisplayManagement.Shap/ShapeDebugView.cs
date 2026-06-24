using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Orchard.DisplayManagement.Shapes;

public class ShapeDebugView
{
	[DebuggerDisplay(" { _shapeType == null ? _value : \"Shape: \" + _shapeType}", Name = "{_key,nq}")]
	public class KeyValuePairs
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _key;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _shapeType;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private object _value;

		public KeyValuePairs(object key, object value)
		{
			if (_value is IShape)
			{
				_shapeType = ((IShape)_value).Metadata.Type;
			}
			_value = value;
			_key = key;
		}
	}

	private readonly Shape _shape;

	public ShapeMetadata Metadata => _shape.Metadata;

	public string Id => _shape.Id;

	public IList<string> Classes => _shape.Classes;

	public IDictionary<string, string> Attributes => _shape.Attributes;

	public IEnumerable<dynamic> Items => _shape.Items;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public KeyValuePairs[] Properties => (from DictionaryEntry entry in _shape.Properties
		select new KeyValuePairs(entry.Key, entry.Value)).ToArray();

	public ShapeDebugView(Shape shape)
	{
		_shape = shape;
	}
}

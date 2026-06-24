using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Orchard.DisplayManagement.Shapes;

[DebuggerTypeProxy(typeof(ShapeDebugView))]
public class Shape : Composite, IShape, IPositioned, IEnumerable<object>, IEnumerable
{
	private const string DefaultPosition = "5";

	private readonly IList<object> _items = new List<object>();

	private readonly IList<string> _classes = new List<string>();

	private readonly IDictionary<string, string> _attributes = new Dictionary<string, string>();

	public ShapeMetadata Metadata { get; set; }

	public virtual string Id { get; set; }

	public virtual IList<string> Classes => _classes;

	public virtual IDictionary<string, string> Attributes => _attributes;

	public virtual IEnumerable<dynamic> Items => _items;

	public string Position => Metadata.Position;

	public Shape()
	{
		Metadata = new ShapeMetadata();
	}

	public virtual Shape Add(object item, string position = null)
	{
		if (item == null)
		{
			return this;
		}
		try
		{
			if (position != null && item is IHtmlString)
			{
				item = new PositionWrapper((IHtmlString)item, position);
			}
			else if (position != null && item is string)
			{
				item = new PositionWrapper((string)item, position);
			}
			else if (item is IShape)
			{
				((IShape)item).Metadata.Position = position;
			}
		}
		catch
		{
		}
		_items.Add(item);
		return this;
	}

	public virtual Shape AddRange(IEnumerable<object> items, string position = "5")
	{
		foreach (object item in items)
		{
			Add(item, position);
		}
		return this;
	}

	IEnumerator<object> IEnumerable<object>.GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	public virtual IEnumerator GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	public override bool TryConvert(ConvertBinder binder, out object result)
	{
		result = Items;
		if (binder.ReturnType == typeof(IEnumerable<object>) || binder.ReturnType == typeof(IEnumerable<object>))
		{
			return true;
		}
		return base.TryConvert(binder, out result);
	}

	public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
	{
		if (indexes.Count() == 1)
		{
			string text = indexes.Single().ToString();
			if (text.Equals("Id"))
			{
				Id = Convert.ToString(value);
				return true;
			}
			if (text.Equals("Classes"))
			{
				MergeClasses(Arguments.From(new object[1] { value }, Enumerable.Empty<string>()), Classes);
				return true;
			}
			if (text.Equals("Attributes"))
			{
				MergeAttributes(Arguments.From(new object[1] { value }, Enumerable.Empty<string>()), Attributes);
				return true;
			}
			if (text.Equals("Items"))
			{
				MergeItems(Arguments.From(new object[1] { value }, Enumerable.Empty<string>()), this);
				return true;
			}
		}
		return base.TrySetIndex(binder, indexes, value);
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		string name = binder.Name;
		INamedEnumerable<object> namedEnumerable = Arguments.From(args, binder.CallInfo.ArgumentNames);
		if (name.Equals("Id"))
		{
			Id = Convert.ToString(args.FirstOrDefault());
			result = this;
			return true;
		}
		if (name.Equals("Classes") && !namedEnumerable.Named.Any())
		{
			MergeClasses(namedEnumerable, Classes);
			result = this;
			return true;
		}
		if (name.Equals("Attributes") && namedEnumerable.Positional.Count() <= 1)
		{
			MergeAttributes(namedEnumerable, Attributes);
			result = this;
			return true;
		}
		if (name.Equals("Items"))
		{
			MergeItems(namedEnumerable, this);
			result = this;
			return true;
		}
		return base.TryInvokeMember(binder, args, out result);
	}

	private static void MergeAttributes(INamedEnumerable<object> args, IDictionary<string, string> attributes)
	{
		object obj = args.Positional.SingleOrDefault();
		if (obj != null)
		{
			if (obj is IDictionary)
			{
				IDictionary dictionary = obj as IDictionary;
				foreach (object key in dictionary.Keys)
				{
					attributes[Convert.ToString(key)] = Convert.ToString(dictionary[key]);
				}
			}
			else
			{
				PropertyInfo[] properties = obj.GetType().GetProperties();
				foreach (PropertyInfo propertyInfo in properties)
				{
					attributes[TranslateIdentifier(propertyInfo.Name)] = Convert.ToString(propertyInfo.GetValue(obj, null));
				}
			}
		}
		foreach (KeyValuePair<string, object> item in args.Named)
		{
			attributes[item.Key] = Convert.ToString(item.Value);
		}
	}

	private static string TranslateIdentifier(string name)
	{
		return name.Replace("_", "-").Replace("@", "");
	}

	private static void MergeClasses(INamedEnumerable<object> args, IList<string> classes)
	{
		foreach (object arg in args)
		{
			if (arg is string)
			{
				classes.Add(arg as string);
			}
			else if (arg is IEnumerable)
			{
				foreach (object item in arg as IEnumerable)
				{
					classes.Add(Convert.ToString(item));
				}
			}
			else
			{
				classes.Add(Convert.ToString(arg));
			}
		}
	}

	private static void MergeItems(INamedEnumerable<object> args, dynamic shape)
	{
		foreach (object arg in args)
		{
			if (arg is string)
			{
				shape.Add(arg as string);
			}
			else if (arg is IEnumerable)
			{
				foreach (object item in arg as IEnumerable)
				{
					shape.Add(item);
				}
			}
			else
			{
				shape.Add(Convert.ToString(arg));
			}
		}
	}
}

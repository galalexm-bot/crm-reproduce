using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Orchard.DisplayManagement;

public static class Arguments
{
	private class NamedEnumerable<T> : INamedEnumerable<T>, IEnumerable<T>, IEnumerable
	{
		private class Named : IDictionary<string, T>, ICollection<KeyValuePair<string, T>>, IEnumerable<KeyValuePair<string, T>>, IEnumerable
		{
			private readonly IEnumerable<T> _arguments;

			private readonly IEnumerable<string> _names;

			private ICollection<T> _argumentsCollection;

			private ICollection<string> _namesCollection;

			int ICollection<KeyValuePair<string, T>>.Count => _names.Count();

			bool ICollection<KeyValuePair<string, T>>.IsReadOnly => true;

			T IDictionary<string, T>.this[string key]
			{
				get
				{
					return (from kv in MakeEnumerable()
						where kv.Key == key
						select kv.Value).FirstOrDefault();
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			ICollection<string> IDictionary<string, T>.Keys
			{
				get
				{
					ICollection<string> obj = _namesCollection ?? (_names as ICollection<string>) ?? _names.ToArray();
					ICollection<string> result = obj;
					_namesCollection = obj;
					return result;
				}
			}

			ICollection<T> IDictionary<string, T>.Values
			{
				get
				{
					ICollection<T> obj = _argumentsCollection ?? (_arguments as ICollection<T>) ?? _arguments.ToArray();
					ICollection<T> result = obj;
					_argumentsCollection = obj;
					return result;
				}
			}

			public Named(IEnumerable<T> arguments, IEnumerable<string> names)
			{
				_arguments = arguments.Skip(arguments.Count() - names.Count());
				_names = names;
			}

			private IEnumerable<KeyValuePair<string, T>> MakeEnumerable()
			{
				return _arguments.Zip(_names, (T arg, string name) => new KeyValuePair<string, T>(name, arg));
			}

			IEnumerator<KeyValuePair<string, T>> IEnumerable<KeyValuePair<string, T>>.GetEnumerator()
			{
				return MakeEnumerable().GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return MakeEnumerable().GetEnumerator();
			}

			void ICollection<KeyValuePair<string, T>>.Add(KeyValuePair<string, T> item)
			{
				throw new NotImplementedException();
			}

			void ICollection<KeyValuePair<string, T>>.Clear()
			{
				throw new NotImplementedException();
			}

			bool ICollection<KeyValuePair<string, T>>.Contains(KeyValuePair<string, T> item)
			{
				return MakeEnumerable().Contains(item);
			}

			void ICollection<KeyValuePair<string, T>>.CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			bool ICollection<KeyValuePair<string, T>>.Remove(KeyValuePair<string, T> item)
			{
				throw new NotImplementedException();
			}

			bool IDictionary<string, T>.ContainsKey(string key)
			{
				return _names.Contains(key);
			}

			void IDictionary<string, T>.Add(string key, T value)
			{
				throw new NotImplementedException();
			}

			bool IDictionary<string, T>.Remove(string key)
			{
				throw new NotImplementedException();
			}

			bool IDictionary<string, T>.TryGetValue(string key, out T value)
			{
				KeyValuePair<string, T> keyValuePair = MakeEnumerable().FirstOrDefault((KeyValuePair<string, T> kv) => kv.Key == key);
				value = keyValuePair.Value;
				return keyValuePair.Key != null;
			}
		}

		private readonly IEnumerable<T> _arguments;

		private readonly IEnumerable<string> _names;

		IEnumerable<T> INamedEnumerable<T>.Positional => _arguments.Take(_arguments.Count() - _names.Count());

		IDictionary<string, T> INamedEnumerable<T>.Named => new Named(_arguments, _names);

		public NamedEnumerable(IEnumerable<T> arguments, IEnumerable<string> names)
		{
			if (arguments == null)
			{
				throw new ArgumentNullException("arguments");
			}
			if (names == null)
			{
				throw new ArgumentNullException("names");
			}
			if (arguments.Count() < names.Count())
			{
				throw new ArgumentException("arguments.Count() < names.Count()");
			}
			_arguments = arguments;
			_names = names;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _arguments.GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return _arguments.GetEnumerator();
		}
	}

	public static INamedEnumerable<T> FromT<T>(IEnumerable<T> arguments, IEnumerable<string> names)
	{
		return new NamedEnumerable<T>(arguments, names);
	}

	public static INamedEnumerable<object> From(IEnumerable<object> arguments, IEnumerable<string> names)
	{
		return new NamedEnumerable<object>(arguments, names);
	}

	public static INamedEnumerable<object> From(IDictionary<string, object> dictionary)
	{
		return From(dictionary.Values, dictionary.Keys);
	}

	public static INamedEnumerable<object> From(object propertyObject)
	{
		PropertyInfo[] properties = propertyObject.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty);
		return new NamedEnumerable<object>(properties.Select((PropertyInfo x) => x.GetGetMethod().Invoke(propertyObject, null)), properties.Select((PropertyInfo x) => x.Name));
	}

	public static INamedEnumerable<object> Empty()
	{
		return From(Enumerable.Empty<object>(), Enumerable.Empty<string>());
	}
}

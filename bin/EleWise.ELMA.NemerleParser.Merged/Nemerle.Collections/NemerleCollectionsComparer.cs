using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;

namespace Nemerle.Collections;

internal class NemerleCollectionsComparer
{
	public abstract class Comparer<T>
	{
		private static readonly Function<T, T, int> default_;

		public static Function<T, T, int> Default
		{
			get
			{
				if (default_ == null)
				{
					throw new ArgumentException("Type " + Convert.ToString(typeof(T).FullName) + " must implement System.IComparable[" + Convert.ToString(typeof(T).FullName) + "].");
				}
				return default_;
			}
		}

		static Comparer()
		{
			default_ = Create();
		}

		public abstract override Function<T, T, int> CreateImpl();

		private static Function<T, T, int> Create()
		{
			Type typeFromHandle = typeof(T);
			typeFromHandle = typeFromHandle;
			object result;
			if (typeof(IComparable<T>).IsAssignableFrom(typeFromHandle))
			{
				Type typeFromHandle2 = typeof(GenericComparer<int>);
				typeFromHandle = typeFromHandle2.GetGenericTypeDefinition().MakeGenericType(typeFromHandle);
				Comparer<T> comparer = (Comparer<T>)Activator.CreateInstance(typeFromHandle);
				result = comparer.CreateImpl();
			}
			else
			{
				result = null;
			}
			return (Function<T, T, int>)result;
		}
	}

	private class GenericComparer<T> : Comparer<T> where T : IComparable<T>
	{
		private sealed class _N__N_lambda__24957__24964 : Function<T, T, int>
		{
			[SpecialName]
			public static readonly _N__N_lambda__24957__24964 Instance = new _N__N_lambda__24957__24964();

			[SpecialName]
			public sealed override int apply(T _N__24955, T _N__24956)
			{
				return _N__24955.CompareTo(_N__24956);
			}
		}

		public override Function<T, T, int> CreateImpl()
		{
			return _N__N_lambda__24957__24964.Instance;
		}
	}
}

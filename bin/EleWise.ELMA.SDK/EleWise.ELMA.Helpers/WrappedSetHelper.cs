using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public static class WrappedSetHelper
{
	internal interface IWrappedSet<TSource, TTarget> : ISet<TSource>, ISet<TSource>, ICollection<TSource>, IEnumerable<TSource>, IEnumerable
	{
		ISet<TTarget> Cast();
	}

	private class WrappedSet<TSource, TTarget> : IWrappedSet<TSource, TTarget>, ISet<TSource>, ISet<TSource>, ICollection<TSource>, IEnumerable<TSource>, IEnumerable
	{
		private class GeneralSet : WrappedSet<TSource, TTarget>, ISet, ICollection, IEnumerable
		{
			private new readonly ISet source;

			internal static object eAWbdQZk4ScZWYoNcIEZ;

			public object SyncRoot => ((ICollection)source).SyncRoot;

			public bool IsSynchronized => ((ICollection)source).IsSynchronized;

			public GeneralSet(ISet<TSource> source)
			{
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Expected O, but got Unknown
				SingletonReader.JJCZtPuTvSt();
				base._002Ector(source);
				this.source = (ISet)source;
			}

			public bool Contains(object o)
			{
				return source.Contains(o);
			}

			public bool Add(object o)
			{
				return source.Add(o);
			}

			public bool Remove(object o)
			{
				return source.Remove(o);
			}

			public bool ContainsAll(ICollection c)
			{
				return source.ContainsAll(c);
			}

			public bool AddAll(ICollection c)
			{
				return source.AddAll(c);
			}

			public bool RemoveAll(ICollection c)
			{
				return source.RemoveAll(c);
			}

			public bool RetainAll(ICollection c)
			{
				return source.RetainAll(c);
			}

			public void CopyTo(Array array, int index)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						((ICollection)source).CopyTo(array, index);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static bool TvJHe7Zk6O5UIYtUbcXy()
			{
				return eAWbdQZk4ScZWYoNcIEZ == null;
			}

			internal static object bPoPYkZkHUpr1phVrXBu()
			{
				return eAWbdQZk4ScZWYoNcIEZ;
			}
		}

		private readonly ISet<TSource> source;

		private ISet<TTarget> castedSet;

		internal static object DBETf1vmPU6i87MAg2cS;

		public bool IsEmpty => source.get_IsEmpty();

		public int Count => ((ICollection<TSource>)source).Count;

		public bool IsReadOnly => ((ICollection<TSource>)source).IsReadOnly;

		public static IWrappedSet<TSource, TTarget> Create(ISet<TSource> source)
		{
			if (!(source is ISet))
			{
				return new WrappedSet<TSource, TTarget>(source);
			}
			return new GeneralSet(source);
		}

		public WrappedSet(ISet<TSource> source)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.source = source;
		}

		public bool Add(TSource item)
		{
			return source.Add(item);
		}

		public bool AddAll(ICollection<TSource> c)
		{
			return source.AddAll(c);
		}

		public void Clear()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((ICollection<TSource>)source).Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool Contains(TSource item)
		{
			return ((ICollection<TSource>)source).Contains(item);
		}

		public bool ContainsAll(ICollection<TSource> c)
		{
			return source.ContainsAll(c);
		}

		public void CopyTo(TSource[] array, int arrayIndex)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					((ICollection<TSource>)source).CopyTo(array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void ExceptWith(IEnumerable<TSource> other)
		{
			((ISet<TSource>)source).ExceptWith(other);
		}

		public IEnumerator<TSource> GetEnumerator()
		{
			return ((IEnumerable<TSource>)source).GetEnumerator();
		}

		public void IntersectWith(IEnumerable<TSource> other)
		{
			((ISet<TSource>)source).IntersectWith(other);
		}

		public bool IsProperSubsetOf(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).IsProperSubsetOf(other);
		}

		public bool IsProperSupersetOf(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).IsProperSupersetOf(other);
		}

		public bool IsSubsetOf(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).IsSubsetOf(other);
		}

		public bool IsSupersetOf(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).IsSupersetOf(other);
		}

		public bool Overlaps(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).Overlaps(other);
		}

		public bool Remove(TSource item)
		{
			return ((ICollection<TSource>)source).Remove(item);
		}

		public bool RemoveAll(ICollection<TSource> c)
		{
			return source.RemoveAll(c);
		}

		public bool RetainAll(ICollection<TSource> c)
		{
			return source.RetainAll(c);
		}

		public bool SetEquals(IEnumerable<TSource> other)
		{
			return ((ISet<TSource>)source).SetEquals(other);
		}

		public void SymmetricExceptWith(IEnumerable<TSource> other)
		{
			((ISet<TSource>)source).SymmetricExceptWith(other);
		}

		public void UnionWith(IEnumerable<TSource> other)
		{
			((ISet<TSource>)source).UnionWith(other);
		}

		void ICollection<TSource>.Add(TSource item)
		{
			Add(item);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)source).GetEnumerator();
		}

		ISet<TTarget> IWrappedSet<TSource, TTarget>.Cast()
		{
			return castedSet ?? (castedSet = this.CreateCastedSet());
		}

		internal static bool SIghthvm1kaXoX1MfRn4()
		{
			return DBETf1vmPU6i87MAg2cS == null;
		}

		internal static object RE4TdovmNZUUUJvZ8jLE()
		{
			return DBETf1vmPU6i87MAg2cS;
		}
	}

	private class CastedSet<TSource, TTarget> : ISet<TTarget>, ISet<TTarget>, ICollection<TTarget>, IEnumerable<TTarget>, IEnumerable, IWrappedSet<TTarget, TSource>
	{
		private class Enumerator : IEnumerator<TTarget>, IDisposable, IEnumerator
		{
			private readonly IEnumerator<TSource> source;

			private static object tbTmWKZkAK5xAIOe7G1k;

			public TTarget Current => (TTarget)(object)source.Current;

			object IEnumerator.Current => source.Current;

			public Enumerator(IEnumerator<TSource> source)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.source = source;
			}

			public void Dispose()
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						source.Dispose();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public bool MoveNext()
			{
				return source.MoveNext();
			}

			public void Reset()
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						source.Reset();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static bool TTDKSHZk7g9AO1RaNdhu()
			{
				return tbTmWKZkAK5xAIOe7G1k == null;
			}

			internal static object SRjEanZkxGafyLnK1sK7()
			{
				return tbTmWKZkAK5xAIOe7G1k;
			}
		}

		private class GeneralSet : CastedSet<TSource, TTarget>, ISet, ICollection, IEnumerable
		{
			private new readonly ISet source;

			private static object vlkWNGZk0vZhAFvAvR8j;

			public object SyncRoot => ((ICollection)source).SyncRoot;

			public bool IsSynchronized => ((ICollection)source).IsSynchronized;

			public GeneralSet(IWrappedSet<TSource, TTarget> source)
			{
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Expected O, but got Unknown
				SingletonReader.JJCZtPuTvSt();
				base._002Ector(source);
				this.source = (ISet)source;
			}

			public bool Contains(object o)
			{
				return source.Contains(o);
			}

			public bool Add(object o)
			{
				return source.Add(o);
			}

			public bool Remove(object o)
			{
				return source.Remove(o);
			}

			public bool ContainsAll(ICollection c)
			{
				return source.ContainsAll(c);
			}

			public bool AddAll(ICollection c)
			{
				return source.AddAll(c);
			}

			public bool RemoveAll(ICollection c)
			{
				return source.RemoveAll(c);
			}

			public bool RetainAll(ICollection c)
			{
				return source.RetainAll(c);
			}

			public void CopyTo(Array array, int index)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						((ICollection)source).CopyTo(array, index);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static bool Dl82OcZkmNX1Zn3VKb0T()
			{
				return vlkWNGZk0vZhAFvAvR8j == null;
			}

			internal static object goSroUZkyCxdWeVqPCAy()
			{
				return vlkWNGZk0vZhAFvAvR8j;
			}
		}

		private readonly IWrappedSet<TSource, TTarget> source;

		private static object RUmOlevm3jodvc8qZdBb;

		public bool IsEmpty => ((ISet<TSource>)source).get_IsEmpty();

		public int Count => source.Count;

		public bool IsReadOnly => source.IsReadOnly;

		public static IWrappedSet<TTarget, TSource> Create(IWrappedSet<TSource, TTarget> wrappedSet)
		{
			if (!(wrappedSet is ISet))
			{
				return new CastedSet<TSource, TTarget>(wrappedSet);
			}
			return new GeneralSet(wrappedSet);
		}

		public CastedSet(IWrappedSet<TSource, TTarget> source)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.source = source;
		}

		public bool Add(TTarget item)
		{
			return ((ISet<TSource>)source).Add((TSource)(object)item);
		}

		public bool Contains(TTarget item)
		{
			return source.Contains((TSource)(object)item);
		}

		public bool Remove(TTarget item)
		{
			return source.Remove((TSource)(object)item);
		}

		public bool AddAll(ICollection<TTarget> c)
		{
			return ((ISet<TSource>)source).AddAll((ICollection<TSource>)c.Cast<TSource>().ToArray());
		}

		public bool ContainsAll(ICollection<TTarget> c)
		{
			return ((ISet<TSource>)source).ContainsAll((ICollection<TSource>)c.Cast<TSource>().ToArray());
		}

		public bool RemoveAll(ICollection<TTarget> c)
		{
			return ((ISet<TSource>)source).RemoveAll((ICollection<TSource>)c.Cast<TSource>().ToArray());
		}

		public bool RetainAll(ICollection<TTarget> c)
		{
			return ((ISet<TSource>)source).RetainAll((ICollection<TSource>)c.Cast<TSource>().ToArray());
		}

		public void CopyTo(TTarget[] array, int arrayIndex)
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					_003C_003Ec__DisplayClass16_.array = array;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					source.Cast<TTarget>().Select(_003C_003Ec__DisplayClass16_._003CCopyTo_003Eb__0).Count();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass16_.arrayIndex = arrayIndex;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Clear()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					source.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void ExceptWith(IEnumerable<TTarget> other)
		{
			source.ExceptWith(other.Cast<TSource>());
		}

		public void IntersectWith(IEnumerable<TTarget> other)
		{
			source.IntersectWith(other.Cast<TSource>());
		}

		public bool IsProperSubsetOf(IEnumerable<TTarget> other)
		{
			return source.IsProperSubsetOf(other.Cast<TSource>());
		}

		public bool IsProperSupersetOf(IEnumerable<TTarget> other)
		{
			return source.IsProperSupersetOf(other.Cast<TSource>());
		}

		public bool IsSubsetOf(IEnumerable<TTarget> other)
		{
			return source.IsSubsetOf(other.Cast<TSource>());
		}

		public bool IsSupersetOf(IEnumerable<TTarget> other)
		{
			return source.IsSupersetOf(other.Cast<TSource>());
		}

		public bool Overlaps(IEnumerable<TTarget> other)
		{
			return source.Overlaps(other.Cast<TSource>());
		}

		public bool SetEquals(IEnumerable<TTarget> other)
		{
			return source.SetEquals(other.Cast<TSource>());
		}

		public void SymmetricExceptWith(IEnumerable<TTarget> other)
		{
			source.SymmetricExceptWith(other.Cast<TSource>());
		}

		public void UnionWith(IEnumerable<TTarget> other)
		{
			source.UnionWith(other.Cast<TSource>());
		}

		public IEnumerator<TTarget> GetEnumerator()
		{
			return new Enumerator(source.GetEnumerator());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)source).GetEnumerator();
		}

		void ICollection<TTarget>.Add(TTarget item)
		{
			Add(item);
		}

		ISet<TSource> IWrappedSet<TTarget, TSource>.Cast()
		{
			return source;
		}

		internal static bool CIjiScvmpU5mFl5VCGMA()
		{
			return RUmOlevm3jodvc8qZdBb == null;
		}

		internal static object HWHfQkvmadayWd0YjUNn()
		{
			return RUmOlevm3jodvc8qZdBb;
		}
	}

	public static ISet<TSource> Wrap<TSource, TTarget>(ISet<TTarget> source)
	{
		if (source != null)
		{
			return ((source as IWrappedSet<TTarget, TSource>) ?? WrappedSet<TTarget, TSource>.Create(source)).Cast();
		}
		return null;
	}

	public static ISet<TSource> Wrap<TSource, TTarget>(ISet<TSource> source)
	{
		object obj;
		if (source != null)
		{
			obj = source as IWrappedSet<TSource, TTarget>;
			if (obj == null)
			{
				return WrappedSet<TSource, TTarget>.Create(source);
			}
		}
		else
		{
			obj = null;
		}
		return (ISet<TSource>)obj;
	}

	public static bool Assign<TSource, TTarget>(ISet<TSource> property, ISet<TTarget> value, out ISet<TSource> resProperty)
	{
		if (property != null)
		{
			((ICollection<TSource>)property).Clear();
			if (value != null)
			{
				((ISet<TSource>)property).UnionWith(((IEnumerable)value).Cast<TSource>());
			}
		}
		else if (value != null)
		{
			resProperty = Wrap<TSource, TTarget>(value);
			return true;
		}
		resProperty = property;
		return false;
	}

	internal static ISet<TTarget> CreateCastedSet<TSource, TTarget>(this IWrappedSet<TSource, TTarget> wrappedSet)
	{
		return CastedSet<TSource, TTarget>.Create(wrappedSet);
	}
}

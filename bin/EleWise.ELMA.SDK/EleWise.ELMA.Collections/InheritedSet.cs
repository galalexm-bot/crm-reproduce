using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class InheritedSet<TSource, TTarget> : ISet<TTarget>, ISet<TTarget>, ICollection<TTarget>, IEnumerable<TTarget>, IEnumerable, ISet, ICollection, IInheritedSet where TSource : class where TTarget : class
{
	protected class EnumeratorT : IEnumerator<TTarget>, IDisposable, IEnumerator
	{
		private IEnumerator<TSource> source;

		private static object JbZ7QKfg1sYg6pFrkqnJ;

		public TTarget Current => (TTarget)(object)source.Current;

		object IEnumerator.Current => source.Current;

		public EnumeratorT(IEnumerator<TSource> source)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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
				case 1:
					source.Reset();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool n2ijldfgNKw6pJpXneSF()
		{
			return JbZ7QKfg1sYg6pFrkqnJ == null;
		}

		internal static object FbqZlgfg3OWgOmcsudi0()
		{
			return JbZ7QKfg1sYg6pFrkqnJ;
		}
	}

	protected ISet<TSource> source;

	internal static object zU5lJImKW6SU7fBJ4Tx;

	public bool IsEmpty => source.get_IsEmpty();

	public int Count => ((ICollection<TSource>)source).Count;

	public object SyncRoot
	{
		[CompilerGenerated]
		get
		{
			return _003CSyncRoot_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CSyncRoot_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsSynchronized
	{
		[CompilerGenerated]
		get
		{
			return _003CIsSynchronized_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CIsSynchronized_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsReadOnly => ((ICollection<TSource>)source).IsReadOnly;

	public bool WasInitialized => source.IsInitialized<TSource>();

	bool IsEmpty => IsEmpty;

	public InheritedSet(ISet<TSource> source)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(source, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A779D11));
		this.source = source;
	}

	public bool Add(TTarget o)
	{
		return source.Add((TSource)(object)o);
	}

	public void UnionWith(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public void IntersectWith(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public void ExceptWith(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public void SymmetricExceptWith(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSubsetOf(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSupersetOf(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSupersetOf(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSubsetOf(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool Overlaps(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool SetEquals(IEnumerable<TTarget> other)
	{
		throw new NotImplementedException();
	}

	public bool AddAll(ICollection<TTarget> c)
	{
		return source.AddAll((ICollection<TSource>)c.Cast<TSource>().ToList());
	}

	public bool ContainsAll(ICollection<TTarget> c)
	{
		return source.ContainsAll((ICollection<TSource>)c.Cast<TSource>().ToList());
	}

	public bool RetainAll(ICollection<TTarget> c)
	{
		return source.RetainAll((ICollection<TSource>)c.Cast<TSource>().ToList());
	}

	public ISet<TTarget> ExclusiveOr(ISet<TTarget> a)
	{
		throw new NotImplementedException();
	}

	public ISet<TTarget> Intersect(ISet<TTarget> a)
	{
		throw new NotImplementedException();
	}

	public ISet<TTarget> Minus(ISet<TTarget> a)
	{
		throw new NotImplementedException();
	}

	public bool RemoveAll(ICollection<TTarget> c)
	{
		return source.RemoveAll((ICollection<TSource>)c.Cast<TSource>().ToList());
	}

	public ISet<TTarget> Union(ISet<TTarget> a)
	{
		throw new NotImplementedException();
	}

	void ICollection<TTarget>.Add(TTarget item)
	{
		Add(item);
	}

	public bool RetainAll(ICollection c)
	{
		throw new NotImplementedException();
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Contains(TTarget item)
	{
		return ((ICollection<TSource>)source).Contains((TSource)(object)item);
	}

	public void CopyTo(TTarget[] array, int arrayIndex)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_0103, IL_013b
		int num = 2;
		int num2 = num;
		IEnumerator<TTarget> enumerator = default(IEnumerator<TTarget>);
		int num3 = default(int);
		TTarget current = default(TTarget);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				enumerator = GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num4;
					if (!enumerator.MoveNext())
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num4 = 0;
						}
						goto IL_0050;
					}
					goto IL_00ba;
					IL_00ba:
					current = enumerator.Current;
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num4 = 1;
					}
					goto IL_0050;
					IL_0050:
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 4:
							break;
						case 1:
							array[num3 + arrayIndex] = current;
							num4 = 3;
							continue;
						case 3:
							num3++;
							num4 = 4;
							continue;
						case 2:
							goto IL_00ba;
						case 0:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							enumerator.Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num5 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void CopyTo(Array array, int arrayIndex)
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
				CopyTo((TTarget[])array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Remove(TTarget item)
	{
		return ((ICollection<TSource>)source).Remove((TSource)(object)item);
	}

	public virtual IEnumerator<TTarget> GetEnumerator()
	{
		return new EnumeratorT(((IEnumerable<TSource>)source).GetEnumerator());
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TSource>)source).GetEnumerator();
	}

	public ISet GetSourceSet()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return (ISet)source;
	}

	bool ISet.Add(object o)
	{
		return Add((TTarget)o);
	}

	bool ISet.AddAll(ICollection c)
	{
		return AddAll(c?.Cast<TTarget>().ToList());
	}

	void ISet.Clear()
	{
		Clear();
	}

	bool ISet.Contains(object o)
	{
		return Contains((TTarget)o);
	}

	bool ISet.ContainsAll(ICollection c)
	{
		return ContainsAll(c?.Cast<TTarget>().ToList());
	}

	bool ISet.Remove(object o)
	{
		return Remove((TTarget)o);
	}

	bool ISet.RemoveAll(ICollection c)
	{
		return RemoveAll(c.Cast<TTarget>().ToList());
	}

	internal static bool nS69t8mXqpEBUGfoni3()
	{
		return zU5lJImKW6SU7fBJ4Tx == null;
	}

	internal static object mLqfpkmTlnMCuweAj6U()
	{
		return zU5lJImKW6SU7fBJ4Tx;
	}
}

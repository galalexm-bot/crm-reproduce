using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Collection.Generic;
using NHibernate.Engine;
using NHibernate.Persister.Collection;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class ElmaCollectionTypeFactory : DefaultCollectionTypeFactory
{
	private class PersistentGenericSet<T> : PersistentGenericSet<T>, ISet, ICollection, IEnumerable, ISet<T>, ISet<T>, ICollection<T>, IEnumerable<T>
	{
		internal static object sMBCUaQMDhyLkQTQwtSB;

		public bool IsEmpty
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return ((AbstractPersistentCollection)this).get_Empty();
					case 1:
						((AbstractPersistentCollection)this).Read();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public PersistentGenericSet()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PersistentGenericSet(ISessionImplementor session)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PersistentGenericSet(ISessionImplementor session, ISet<T> original)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session, original);
		}

		public bool Contains(object o)
		{
			return base.Contains((T)o);
		}

		public bool Add(object o)
		{
			return base.Add((T)o);
		}

		public bool Remove(object o)
		{
			return base.Remove((T)o);
		}

		public bool AddAll(ICollection<T> c)
		{
			return c.Aggregate(seed: false, (bool a, T item) => base.Add(item) || a);
		}

		public bool ContainsAll(ICollection<T> c)
		{
			return c.Aggregate(seed: true, (bool a, T item) => base.Contains(item) && a);
		}

		public bool RemoveAll(ICollection<T> c)
		{
			return c.Aggregate(seed: false, (bool a, T item) => base.Remove(item) || a);
		}

		public bool RetainAll(ICollection<T> c)
		{
			int count = base.get_Count();
			base.IntersectWith((IEnumerable<T>)c);
			return base.get_Count() != count;
		}

		public bool ContainsAll(ICollection c)
		{
			return ContainsAll((ICollection<T>)c);
		}

		public bool AddAll(ICollection c)
		{
			return AddAll((ICollection<T>)c);
		}

		public bool RemoveAll(ICollection c)
		{
			return RemoveAll((ICollection<T>)c);
		}

		public bool RetainAll(ICollection c)
		{
			return RetainAll((ICollection<T>)c);
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
					base.CopyTo((T[])array, index);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[SpecialName]
		object ICollection.get_SyncRoot()
		{
			return base.get_SyncRoot();
		}

		[SpecialName]
		bool ICollection.get_IsSynchronized()
		{
			return base.get_IsSynchronized();
		}

		internal static bool m8JFJ1QMtSmV8341723Q()
		{
			return sMBCUaQMDhyLkQTQwtSB == null;
		}

		internal static object ggjiBiQMwAZaVQpT978I()
		{
			return sMBCUaQMDhyLkQTQwtSB;
		}
	}

	private class PersistentGenericSet<TSource, TTarget> : PersistentGenericSet<TSource>, WrappedSetHelper.IWrappedSet<TSource, TTarget>, ISet<TSource>, ISet<TSource>, ICollection<TSource>, IEnumerable<TSource>, IEnumerable
	{
		private ISet<TTarget> castedSet;

		private static object XBP26bQM4P4xBuI9LIJb;

		public PersistentGenericSet()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PersistentGenericSet(ISessionImplementor session)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PersistentGenericSet(ISessionImplementor session, ISet<TSource> original)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session, original);
		}

		ISet<TTarget> WrappedSetHelper.IWrappedSet<TSource, TTarget>.Cast()
		{
			return castedSet ?? (castedSet = this.CreateCastedSet());
		}

		internal static bool cIGjo2QM6VS06flE5LLw()
		{
			return XBP26bQM4P4xBuI9LIJb == null;
		}

		internal static object GNoZQsQMHJJotdFbkskZ()
		{
			return XBP26bQM4P4xBuI9LIJb;
		}
	}

	private class SoftDeletablePersistentGenericSet<T> : PersistentGenericSet<T>, ISet, ICollection, IEnumerable, ISet<T>, ISet<T>, ICollection<T>, IEnumerable<T>
	{
		private static readonly RunWithSoftDeletableService RunWithSoftDeletableService;

		internal static object bUViVwQMAtUBpvwuWMP9;

		int ICollection<T>.Count
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return ((PersistentGenericSet<T>)this).get_Count();
					case 1:
						if (!SoftDeletableTurned)
						{
							((AbstractPersistentCollection)this).Read();
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num2 = 0;
							}
						}
						break;
					case 2:
						return ((PersistentGenericSet<T>)this).WrappedSet.Count(Filter);
					}
				}
			}
		}

		int ICollection.Count => ((ICollection<T>)this).Count;

		private ISet<T> Filtered
		{
			get
			{
				((AbstractPersistentCollection)this).Read();
				if (!SoftDeletableTurned)
				{
					return new HashSet<T>(((PersistentGenericSet<T>)this).WrappedSet.Where(Filter));
				}
				return ((PersistentGenericSet<T>)this).WrappedSet;
			}
		}

		bool IsEmpty => ((ICollection<T>)this).Count == 0;

		bool IsEmpty => ((ICollection<T>)this).Count == 0;

		int Count => ((ICollection<T>)this).Count;

		private bool SoftDeletableTurned
		{
			get
			{
				//Discarded unreachable code: IL_0073, IL_00ab, IL_00ca, IL_00f6, IL_0105
				int num = 1;
				int num2 = num;
				IDisposable disposable = default(IDisposable);
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return result;
					case 1:
						disposable = ELMAContext.Create();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					}
					try
					{
						result = RunWithSoftDeletableService.Turned;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						int num4;
						if (disposable == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num4 = 1;
							}
							goto IL_00af;
						}
						goto IL_00d4;
						IL_00d4:
						disposable.Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num4 = 0;
						}
						goto IL_00af;
						IL_00af:
						switch (num4)
						{
						default:
							goto end_IL_008a;
						case 1:
							goto end_IL_008a;
						case 2:
							break;
						case 0:
							goto end_IL_008a;
						}
						goto IL_00d4;
						end_IL_008a:;
					}
				}
			}
		}

		public SoftDeletablePersistentGenericSet()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public SoftDeletablePersistentGenericSet(ISessionImplementor session)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public SoftDeletablePersistentGenericSet(ISessionImplementor session, ISet<T> original)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session, original);
		}

		private static bool Filter(T item)
		{
			if (item != null)
			{
				return !((ISoftDeletable)(object)item).IsDeleted;
			}
			return true;
		}

		bool ICollection<T>.Remove(T item)
		{
			if (((PersistentGenericSet<T>)this).Remove(item))
			{
				if (!SoftDeletableTurned)
				{
					return Filter(item);
				}
				return true;
			}
			return false;
		}

		bool ICollection<T>.Contains(T item)
		{
			if (((PersistentGenericSet<T>)this).Contains(item))
			{
				if (!SoftDeletableTurned)
				{
					return Filter(item);
				}
				return true;
			}
			return false;
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					((PersistentGenericSet<T>)this).WrappedSet.Where(Filter).ToArray().CopyTo(array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
					((PersistentGenericSet<T>)this).CopyTo(array, arrayIndex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if (SoftDeletableTurned)
					{
						num2 = 3;
						break;
					}
					((AbstractPersistentCollection)this).Read();
					num2 = 2;
					break;
				case 1:
					return;
				}
			}
		}

		void ICollection.CopyTo(Array array, int index)
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
					((ICollection<T>)this).CopyTo((T[])array, index);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		bool ISet<T>.Add(T item)
		{
			if (((PersistentGenericSet<T>)this).Add(item))
			{
				if (!SoftDeletableTurned)
				{
					return Filter(item);
				}
				return true;
			}
			return false;
		}

		bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other)
		{
			return Filtered.IsProperSubsetOf(other);
		}

		bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other)
		{
			return Filtered.IsProperSupersetOf(other);
		}

		bool ISet<T>.IsSubsetOf(IEnumerable<T> other)
		{
			return Filtered.IsSubsetOf(other);
		}

		bool ISet<T>.IsSupersetOf(IEnumerable<T> other)
		{
			return Filtered.IsSupersetOf(other);
		}

		bool ISet<T>.Overlaps(IEnumerable<T> other)
		{
			return Filtered.Overlaps(other);
		}

		bool ISet<T>.SetEquals(IEnumerable<T> other)
		{
			return Filtered.SetEquals(other);
		}

		bool ISet<T>.Add(T item)
		{
			return ((ISet<T>)this).Add(item);
		}

		bool ISet<T>.AddAll(ICollection<T> c)
		{
			return c.Aggregate(seed: false, (bool a, T item) => ((ISet<T>)this).Add(item) || a);
		}

		bool ISet<T>.ContainsAll(ICollection<T> c)
		{
			return c.Aggregate(seed: true, (bool a, T item) => ((ICollection<T>)this).Contains(item) && a);
		}

		bool ISet<T>.RemoveAll(ICollection<T> c)
		{
			return c.Aggregate(seed: false, (bool a, T item) => ((ICollection<T>)this).Remove(item) || a);
		}

		bool ISet<T>.RetainAll(ICollection<T> c)
		{
			int count = ((ICollection<T>)this).Count;
			((PersistentGenericSet<T>)this).IntersectWith((IEnumerable<T>)c);
			return ((ICollection<T>)this).Count < count;
		}

		bool ISet.Add(object o)
		{
			return ((ISet<T>)this).Add((T)o);
		}

		bool ISet.AddAll(ICollection c)
		{
			return ((ISet<T>)this).AddAll((ICollection<T>)c);
		}

		bool ISet.Contains(object o)
		{
			return ((ICollection<T>)this).Contains((T)o);
		}

		bool ISet.ContainsAll(ICollection c)
		{
			return ((ISet<T>)this).ContainsAll((ICollection<T>)c);
		}

		bool ISet.Remove(object o)
		{
			return ((ICollection<T>)this).Remove((T)o);
		}

		bool ISet.RemoveAll(ICollection c)
		{
			return ((ISet<T>)this).RemoveAll((ICollection<T>)c);
		}

		bool ISet.RetainAll(ICollection c)
		{
			return ((ISet<T>)this).RetainAll((ICollection<T>)c);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			((AbstractPersistentCollection)this).Read();
			if (!SoftDeletableTurned)
			{
				return ((PersistentGenericSet<T>)this).WrappedSet.Where(Filter).GetEnumerator();
			}
			return ((PersistentGenericSet<T>)this).WrappedSet.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//Discarded unreachable code: IL_008f, IL_009e
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (SoftDeletableTurned)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return ((PersistentGenericSet<T>)this).WrappedSet.Where(Filter).GetEnumerator();
				default:
					return ((PersistentGenericSet<T>)this).WrappedSet.GetEnumerator();
				case 3:
					((AbstractPersistentCollection)this).Read();
					num2 = 2;
					break;
				}
			}
		}

		public override string ToString()
		{
			return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210722879), this);
		}

		static SoftDeletablePersistentGenericSet()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					RunWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[SpecialName]
		object ICollection.get_SyncRoot()
		{
			return ((PersistentGenericSet<T>)this).get_SyncRoot();
		}

		[SpecialName]
		bool ICollection.get_IsSynchronized()
		{
			return ((PersistentGenericSet<T>)this).get_IsSynchronized();
		}

		internal static bool hQJg78QM7OIcXsSgO6pU()
		{
			return bUViVwQMAtUBpvwuWMP9 == null;
		}

		internal static object IplmXUQMxKYUSHaGs8ld()
		{
			return bUViVwQMAtUBpvwuWMP9;
		}
	}

	private class SoftDeletablePersistentGenericSet<TSource, TTarget> : SoftDeletablePersistentGenericSet<TSource>, WrappedSetHelper.IWrappedSet<TSource, TTarget>, ISet<TSource>, ISet<TSource>, ICollection<TSource>, IEnumerable<TSource>, IEnumerable
	{
		private ISet<TTarget> castedSet;

		private static object LuSlqVQM05w83lfs4anT;

		public SoftDeletablePersistentGenericSet()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public SoftDeletablePersistentGenericSet(ISessionImplementor session)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public SoftDeletablePersistentGenericSet(ISessionImplementor session, ISet<TSource> original)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(session, original);
		}

		ISet<TTarget> WrappedSetHelper.IWrappedSet<TSource, TTarget>.Cast()
		{
			return castedSet ?? (castedSet = this.CreateCastedSet());
		}

		internal static bool GQBekwQMmD6nChsjVTB9()
		{
			return LuSlqVQM05w83lfs4anT == null;
		}

		internal static object fZS0lmQMyb4pjAOFaZi3()
		{
			return LuSlqVQM05w83lfs4anT;
		}
	}

	[Serializable]
	private class GenericSetType<T> : GenericSetType<T>
	{
		private static readonly ConcurrentDictionary<Type, (Func<ISessionImplementor, IPersistentCollection> instantiate, Func<ISessionImplementor, ISet<T>, IPersistentCollection> wrap)> Instantiators;

		private readonly Func<ISessionImplementor, IPersistentCollection> instantiate;

		private readonly Func<ISessionImplementor, ISet<T>, IPersistentCollection> wrap;

		internal static object fluElKQMMaRVkGWy1XPB;

		public GenericSetType(string role, string propertyRef)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(role, propertyRef);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
			(Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, ISet<T>, IPersistentCollection>) orAdd = default((Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, ISet<T>, IPersistentCollection>));
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					instantiate = orAdd.Item1;
					num = 2;
					break;
				case 2:
					wrap = orAdd.Item2;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					orAdd = Instantiators.GetOrAdd(typeof(T), GetInstantiators<T>);
					num = 3;
					break;
				case 0:
					return;
				}
			}
		}

		public override IPersistentCollection Instantiate(ISessionImplementor session, ICollectionPersister persister, object key)
		{
			return instantiate(session);
		}

		public override IPersistentCollection Wrap(ISessionImplementor session, object collection)
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			ISet<T> set = default(ISet<T>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return wrap(session, set);
				case 3:
					set = collection as ISet<T>;
					num2 = 2;
					break;
				case 2:
					if (set == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				default:
					set = new HashSet<T>((collection as ICollection<T>) ?? throw new HibernateException(((CollectionType)this).get_Role() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7685F72)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		static GenericSetType()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Instantiators = new ConcurrentDictionary<Type, (Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, ISet<T>, IPersistentCollection>)>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static bool HpRK57QMJtWg2UR6gbmn()
		{
			return fluElKQMMaRVkGWy1XPB == null;
		}

		internal static object kFtM8QQM9CncHWfVtXFn()
		{
			return fluElKQMMaRVkGWy1XPB;
		}
	}

	[Serializable]
	private class GenericSortedSetType<T> : GenericSetType<T>
	{
		internal static object NjZ3L4QMdDhCD8WOG8Bu;

		public IComparer<T> Comparer { get; }

		public GenericSortedSetType(string role, string propertyRef, IComparer<T> comparer)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(role, propertyRef);
			if (comparer is IComparerInternal comparerInternal)
			{
				comparerInternal.SetRole(role);
			}
			Comparer = comparer;
		}

		public override object Instantiate(int anticipatedSize)
		{
			return new IesiSortedSet<T>(Comparer);
		}

		internal static bool SoNNX0QMlC6Oo0LAXDDk()
		{
			return NjZ3L4QMdDhCD8WOG8Bu == null;
		}

		internal static object hXERvwQMrlvqYsa61AnY()
		{
			return NjZ3L4QMdDhCD8WOG8Bu;
		}
	}

	[Serializable]
	private class GenericOrderedSetType<T> : GenericSetType<T>
	{
		internal static object pAEe7dQMgoG6dQ04kakQ;

		public GenericOrderedSetType(string role, string propertyRef)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(role, propertyRef);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override object Instantiate(int anticipatedSize)
		{
			return new LinkedHashSet<T>();
		}

		internal static bool eVO0d2QM5fLYdg8Cj1Sj()
		{
			return pAEe7dQMgoG6dQ04kakQ == null;
		}

		internal static object tDWbhDQMjuINN2EX7HN8()
		{
			return pAEe7dQMgoG6dQ04kakQ;
		}
	}

	private static readonly MethodInfo CreatePersistentCollectionMethod;

	private static readonly MethodInfo CreatePersistentCollectionSetMethod;

	private static readonly MethodInfo CreatePersistentCollectionIntrfMethod;

	private static readonly MethodInfo CreatePersistentCollectionSetIntrfMethod;

	private static readonly MethodInfo CreateSoftDeletablePersistentCollectionMethod;

	private static readonly MethodInfo CreateSoftDeletablePersistentCollectionSetMethod;

	private static readonly MethodInfo CreateSoftDeletablePersistentCollectionIntrfMethod;

	private static readonly MethodInfo CreateSoftDeletablePersistentCollectionSetIntrfMethod;

	internal static ElmaCollectionTypeFactory vQPRvZW3AF64jw2Qw8Lu;

	public override CollectionType Set<T>(string role, string propertyRef)
	{
		return (CollectionType)(object)new GenericSetType<T>(role, propertyRef);
	}

	public override CollectionType SortedSet<T>(string role, string propertyRef, IComparer<T> comparer)
	{
		return (CollectionType)(object)new GenericSortedSetType<T>(role, propertyRef, comparer);
	}

	public override CollectionType OrderedSet<T>(string role, string propertyRef)
	{
		return (CollectionType)(object)new GenericOrderedSetType<T>(role, propertyRef);
	}

	private static IPersistentCollection CreatePersistentCollection<TClass>(object session)
	{
		return (IPersistentCollection)(object)new PersistentGenericSet<TClass>((ISessionImplementor)session);
	}

	private static IPersistentCollection CreatePersistentCollectionSet<TClass>(object session, ISet<TClass> set)
	{
		return (IPersistentCollection)(object)new PersistentGenericSet<TClass>((ISessionImplementor)session, set);
	}

	private static IPersistentCollection CreatePersistentCollectionIntrf<TClass, TInterface>(object session)
	{
		return (IPersistentCollection)(object)new PersistentGenericSet<TClass, TInterface>((ISessionImplementor)session);
	}

	private static IPersistentCollection CreatePersistentCollectionSetIntrf<TClass, TInterface>(object session, ISet<TClass> set)
	{
		return (IPersistentCollection)(object)new PersistentGenericSet<TClass, TInterface>((ISessionImplementor)session, set);
	}

	private static IPersistentCollection CreateSoftDeletablePersistentCollection<TClass>(object session)
	{
		return (IPersistentCollection)(object)new SoftDeletablePersistentGenericSet<TClass>((ISessionImplementor)session);
	}

	private static IPersistentCollection CreateSoftDeletablePersistentCollectionSet<TClass>(object session, ISet<TClass> set)
	{
		return (IPersistentCollection)(object)new SoftDeletablePersistentGenericSet<TClass>((ISessionImplementor)session, set);
	}

	private static IPersistentCollection CreateSoftDeletablePersistentCollectionIntrf<TClass, TInterface>(object session)
	{
		return (IPersistentCollection)(object)new SoftDeletablePersistentGenericSet<TClass, TInterface>((ISessionImplementor)session);
	}

	private static IPersistentCollection CreateSoftDeletablePersistentCollectionSetIntrf<TClass, TInterface>(object session, ISet<TClass> set)
	{
		return (IPersistentCollection)(object)new SoftDeletablePersistentGenericSet<TClass, TInterface>((ISessionImplementor)session, set);
	}

	private static (Func<ISessionImplementor, IPersistentCollection>, Func<ISessionImplementor, ISet<T>, IPersistentCollection>) GetInstantiators<T>(Type type)
	{
		bool flag = TypeOf<ISoftDeletable>.Raw.IsAssignableFrom(TypeOf<T>.Raw);
		ParameterExpression parameterExpression = Expression.Parameter(TypeOf<ISessionImplementor>.Raw);
		ParameterExpression parameterExpression2 = Expression.Parameter(TypeOf<ISet<T>>.Raw);
		Expression body;
		Expression body2;
		if (MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false) is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
		{
			Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false);
			body = Expression.Call((flag ? CreateSoftDeletablePersistentCollectionIntrfMethod : CreatePersistentCollectionIntrfMethod).MakeGenericMethod(type, typeByUid), parameterExpression);
			body2 = Expression.Call((flag ? CreateSoftDeletablePersistentCollectionSetIntrfMethod : CreatePersistentCollectionSetIntrfMethod).MakeGenericMethod(type, typeByUid), parameterExpression, parameterExpression2);
		}
		else
		{
			body = Expression.Call((flag ? CreateSoftDeletablePersistentCollectionMethod : CreatePersistentCollectionMethod).MakeGenericMethod(type), parameterExpression);
			body2 = Expression.Call((flag ? CreateSoftDeletablePersistentCollectionSetMethod : CreatePersistentCollectionSetMethod).MakeGenericMethod(type), parameterExpression, parameterExpression2);
		}
		return ((Func<ISessionImplementor, IPersistentCollection>)Expression.Lambda(body, parameterExpression).Compile(), (Func<ISessionImplementor, ISet<T>, IPersistentCollection>)Expression.Lambda(body2, parameterExpression, parameterExpression2).Compile());
	}

	public ElmaCollectionTypeFactory()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nmhRpcW30aJN4ieYg4Dn();
		((DefaultCollectionTypeFactory)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ElmaCollectionTypeFactory()
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					CreateSoftDeletablePersistentCollectionMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(0x34A6D230 ^ 0x34A4C4F8), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 2;
					continue;
				case 9:
					return;
				default:
					CreatePersistentCollectionSetIntrfMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(0x2A7797B7 ^ 0x2A758137), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 8;
					continue;
				case 4:
					CreatePersistentCollectionSetMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(-1334993905 ^ -1334867441), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					break;
				case 3:
					CreateSoftDeletablePersistentCollectionIntrfMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(-1852837372 ^ -1852971658), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 5;
					continue;
				case 6:
					CreatePersistentCollectionMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(-583745292 ^ -583609028), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					CreateSoftDeletablePersistentCollectionSetMethod = typeof(ElmaCollectionTypeFactory).GetMethod((string)X6Bjs4W3y3PP5GtPK5XH(0x48A7E34A ^ 0x48A5F450), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 3;
					continue;
				case 1:
					CreatePersistentCollectionIntrfMethod = typeof(ElmaCollectionTypeFactory).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307C89EF), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					CreateSoftDeletablePersistentCollectionSetIntrfMethod = Ss5HhLW3m1dfUuLigYdZ(typeof(ElmaCollectionTypeFactory).TypeHandle).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671997195), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 9;
					continue;
				}
				break;
			}
			nmhRpcW30aJN4ieYg4Dn();
			num = 6;
		}
	}

	internal static void nmhRpcW30aJN4ieYg4Dn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool r9BIDGW37HgqERSIq9yq()
	{
		return vQPRvZW3AF64jw2Qw8Lu == null;
	}

	internal static ElmaCollectionTypeFactory yc2703W3xefbBN05argi()
	{
		return vQPRvZW3AF64jw2Qw8Lu;
	}

	internal static Type Ss5HhLW3m1dfUuLigYdZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object X6Bjs4W3y3PP5GtPK5XH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}

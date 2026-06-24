using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Collections;

public class TablePartItemSet<T> : ISet<T>, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IInheritedSet, ISet, ICollection where T : WorkflowTablePartEntity
{
	private class EnumeratorT : IEnumerator<T>, IDisposable, IEnumerator
	{
		private IEnumerator source;

		private TablePartItemSet<T> extSet;

		internal static object IFSr1pZwT0bWiu2iPq1s;

		public T Current => extSet.CastToTarget(source.Current);

		object IEnumerator.Current => extSet.CastToTarget(source.Current);

		public EnumeratorT(TablePartItemSet<T> extSet)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			source = extSet.source.GetEnumerator();
			this.extSet = extSet;
		}

		public void Dispose()
		{
			//Discarded unreachable code: IL_005b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					((IDisposable)source).Dispose();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 2;
					}
					break;
				case 0:
					return;
				case 1:
					if (!(source is IDisposable))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					return;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool Vl1sm3ZwQoZqeCjFWXDv()
		{
			return IFSr1pZwT0bWiu2iPq1s == null;
		}

		internal static object wYJwUGZwpq4BE617rX1q()
		{
			return IFSr1pZwT0bWiu2iPq1s;
		}
	}

	private IEnumerable source;

	private Type sourceItemType;

	private ConcurrentDictionary<object, T> loadedItems;

	private static object UtaeCOOY8D2kLeQQrPCT;

	public virtual bool IsEmpty => (bool)GetSourcePropertyValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712522487));

	public virtual int Count => (int)GetSourcePropertyValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29954964));

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
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

	public virtual bool IsReadOnly => (bool)GetSourcePropertyValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D4E240));

	public bool WasInitialized
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 1:
					return NHExtensions.IsInitialized((ISet)source);
				case 2:
					if (source is ISet)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	bool IsEmpty => IsEmpty;

	protected virtual object CastToSource(T target)
	{
		if (target != null)
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.id = target.GetId();
			if (CS_0024_003C_003E8__locals0.id != null && CS_0024_003C_003E8__locals0.id.GetType() == typeof(long) && (long)CS_0024_003C_003E8__locals0.id != 0L)
			{
				IEntity entity = source.OfType<IEntity>().FirstOrDefault((IEntity e) => e.GetId().Equals(CS_0024_003C_003E8__locals0.id));
				if (entity != null)
				{
					return entity;
				}
			}
		}
		return target?.LoadEntity(0);
	}

	protected virtual T CastToTarget(object sourceItem)
	{
		if (loadedItems.TryGetValue(sourceItem, out var value))
		{
			return value;
		}
		lock (loadedItems)
		{
			if (loadedItems.TryGetValue(sourceItem, out value))
			{
				return value;
			}
			value = null;
			long num = (long)((IEntity)sourceItem).GetId();
			ConstructorInfo constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(IEntity) }, null);
			if (constructor != null)
			{
				value = (T)constructor.Invoke(new object[1] { sourceItem });
			}
			if (value == null)
			{
				constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(long) }, null);
				if (constructor == null)
				{
					throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684305042) + typeof(T).FullName);
				}
				value = (T)constructor.Invoke(new object[1] { num });
				((IWorkflowTablePartEntity)value)?.Initialize((IEntity)sourceItem);
			}
			loadedItems[sourceItem] = value;
			return value;
		}
	}

	public TablePartItemSet(IEnumerable source)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		loadedItems = new ConcurrentDictionary<object, T>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
		{
			num = 0;
		}
		Type @interface = default(Type);
		while (true)
		{
			switch (num)
			{
			case 1:
				this.source = source;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num = 0;
				}
				break;
			default:
				Contract.ArgumentNotNull(source, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC79A28));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num = 1;
				}
				break;
			case 2:
				@interface = source.GetType().GetInterface(typeof(ISet<>).FullName);
				num = 4;
				break;
			case 4:
				if (@interface == null)
				{
					num = 3;
					break;
				}
				sourceItemType = @interface.GetGenericArguments()[0];
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num = 2;
				}
				break;
			case 3:
				throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -44026087), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949622811));
			case 5:
				return;
			}
		}
	}

	public virtual bool Add(T o)
	{
		return (bool)InvokeSourceMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -683012260), new List<KeyValuePair<Type, object>>
		{
			new KeyValuePair<Type, object>(sourceItemType, CastToSource(o))
		});
	}

	public void UnionWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void IntersectWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void ExceptWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public virtual bool AddAll(ICollection<T> c)
	{
		return c.Aggregate(seed: false, (bool a, T item) => Add(item) || a);
	}

	public virtual bool ContainsAll(ICollection<T> c)
	{
		return c.Aggregate(seed: true, (bool a, T item) => Contains(item) && a);
	}

	public virtual ISet<T> ExclusiveOr(ISet<T> a)
	{
		throw new NotImplementedException();
	}

	public virtual ISet<T> Intersect(ISet<T> a)
	{
		throw new NotImplementedException();
	}

	public virtual ISet<T> Minus(ISet<T> a)
	{
		throw new NotImplementedException();
	}

	public virtual bool RemoveAll(ICollection<T> c)
	{
		return c.Aggregate(seed: false, (bool a, T item) => Remove(item) || a);
	}

	public virtual bool RetainAll(ICollection<T> c)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.c = c;
		List<T> c2 = this.Where((T item) => !CS_0024_003C_003E8__locals0.c.Contains(item)).ToList();
		return RemoveAll(c2);
	}

	public virtual ISet<T> Union(ISet<T> a)
	{
		throw new NotImplementedException();
	}

	public virtual void Clear()
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
				InvokeSourceMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542087358));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual bool Contains(T item)
	{
		return (bool)InvokeSourceMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6851AB), new List<KeyValuePair<Type, object>>
		{
			new KeyValuePair<Type, object>(sourceItemType, CastToSource(item))
		});
	}

	public virtual void CopyTo(T[] array, int arrayIndex)
	{
		//Discarded unreachable code: IL_0072, IL_007c, IL_0123, IL_0163, IL_0172, IL_017e, IL_018d
		int num = 3;
		int num2 = num;
		int num4 = default(int);
		IEnumerator<T> enumerator = default(IEnumerator<T>);
		T current = default(T);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				num4 = 0;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				enumerator = GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_00c7:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
							{
								num3 = 1;
							}
							goto IL_0080;
						}
						goto IL_00b4;
						IL_00b4:
						current = enumerator.Current;
						num3 = 3;
						goto IL_0080;
						IL_0080:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 3:
								array[num4 + arrayIndex] = current;
								num3 = 2;
								continue;
							case 4:
								break;
							default:
								goto IL_00c7;
							case 2:
								num4++;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_00b4;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_0127;
					}
					goto IL_013d;
					IL_0127:
					switch (num5)
					{
					case 2:
						goto end_IL_0112;
					case 1:
						goto end_IL_0112;
					}
					goto IL_013d;
					IL_013d:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num5 = 1;
					}
					goto IL_0127;
					end_IL_0112:;
				}
			}
		}
	}

	public virtual void CopyTo(Array array, int arrayIndex)
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
				CopyTo((T[])array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual bool Remove(T item)
	{
		return (bool)InvokeSourceMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498912939), new List<KeyValuePair<Type, object>>
		{
			new KeyValuePair<Type, object>(sourceItemType, CastToSource(item))
		});
	}

	public virtual IEnumerator<T> GetEnumerator()
	{
		return new EnumeratorT(this);
	}

	public virtual object Clone()
	{
		return new TablePartItemSet<T>((IEnumerable)InvokeSourceMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747E6F42)));
	}

	public ISet GetSourceSet()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return (ISet)source;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	void ICollection<T>.Add(T item)
	{
		Add(item);
	}

	private object InvokeSourceMethod(string methodName, List<KeyValuePair<Type, object>> paramsByType = null)
	{
		MethodInfo method = source.GetType().GetMethod(methodName, (paramsByType != null) ? paramsByType.Select((KeyValuePair<Type, object> p) => p.Key).ToArray() : new Type[0]);
		if (method == null)
		{
			throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420030727) + methodName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F805829));
		}
		return method.Invoke(source, (paramsByType != null) ? paramsByType.Select((KeyValuePair<Type, object> p) => p.Value).ToArray() : new object[0]);
	}

	private object GetSourcePropertyValue(string propertyName)
	{
		PropertyInfo reflectionProperty = source.GetType().GetReflectionProperty(propertyName);
		if (reflectionProperty == null)
		{
			throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11902868) + propertyName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36167F8D));
		}
		return reflectionProperty.GetValue(source, null);
	}

	bool ISet.Add(object o)
	{
		return Add((T)o);
	}

	bool ISet.AddAll(ICollection c)
	{
		return AddAll(c.Cast<T>().ToList());
	}

	void ISet.Clear()
	{
		Clear();
	}

	bool ISet.Contains(object o)
	{
		return Contains((T)o);
	}

	bool ISet.ContainsAll(ICollection c)
	{
		return ContainsAll(c.Cast<T>().ToList());
	}

	bool ISet.Remove(object o)
	{
		return Remove((T)o);
	}

	bool ISet.RemoveAll(ICollection c)
	{
		return RemoveAll(c.Cast<T>().ToList());
	}

	bool ISet.RetainAll(ICollection c)
	{
		return RetainAll(c.Cast<T>().ToList());
	}

	internal static bool O8DIvVOYs5e9U9meu9k9()
	{
		return UtaeCOOY8D2kLeQQrPCT == null;
	}

	internal static object DycrZmOYJZw3jlMWSnjL()
	{
		return UtaeCOOY8D2kLeQQrPCT;
	}
}

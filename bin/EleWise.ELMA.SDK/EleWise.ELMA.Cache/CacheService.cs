using System;
using System.Configuration.Provider;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache;

public abstract class CacheService : ProviderBase, ICacheService
{
	[Serializable]
	private class CachedNull
	{
		private static object DePjwS8YybMSoKOKQDNt;

		public byte Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

		public CachedNull()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Ql1L6A8Y9HZ0AyOJ0kFx();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Dkwu238YM9g6MSN3YvbL()
		{
			return DePjwS8YybMSoKOKQDNt == null;
		}

		internal static CachedNull ahVgU98YJHH3LguKULCB()
		{
			return (CachedNull)DePjwS8YybMSoKOKQDNt;
		}

		internal static void Ql1L6A8Y9HZ0AyOJ0kFx()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly CachedNull NullValue;

	private readonly bool needDiagnostics;

	private static CacheService yo7sP4fqUcgjgGR8G0lW;

	public virtual bool IsDistributed => false;

	public CacheService()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		Ye3vh8fqzwgI44ervFBo();
		needDiagnostics = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			needDiagnostics = !(this is IHandleDiagnostics);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num = 1;
			}
		}
	}

	public void Insert<T>(string key, T value, TimeSpan cacheDuration)
	{
		Insert(key, value, null, cacheDuration);
	}

	public void Insert<T>(string key, T value, string region, TimeSpan cacheDuration, CacheItemRemovedCallback<T> onRemoveItemCallback)
	{
		_003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.region = region;
		CS_0024_003C_003E8__locals0.key = key;
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.key))
		{
			return;
		}
		using (DiagnosticsManager.StartCall(delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					if (CS_0024_003C_003E8__locals0._003C_003E4__this.needDiagnostics)
					{
						return new CacheWriteInfo
						{
							Region = CS_0024_003C_003E8__locals0.region,
							Key = CS_0024_003C_003E8__locals0.key
						};
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}))
		{
			InsertValue(CS_0024_003C_003E8__locals0.key, AssembleValue(value), CS_0024_003C_003E8__locals0.region, cacheDuration, onRemoveItemCallback);
		}
	}

	public void Insert<T>(string key, T value, string region, TimeSpan cacheDuration)
	{
		Insert(key, value, region, cacheDuration, null);
	}

	public void Insert<T>(string key, T value, string region)
	{
		Insert(key, value, region, TimeSpan.FromHours(2.0));
	}

	public void Insert<T>(string key, T value)
	{
		Insert(key, value, null);
	}

	public bool Contains(string key)
	{
		return Contains(key, null);
	}

	public bool Contains(string key, string region)
	{
		//Discarded unreachable code: IL_00a9, IL_014f, IL_016e, IL_017d, IL_01aa
		int num = 4;
		int num2 = num;
		CacheReadInfo cacheReadInfo = default(CacheReadInfo);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				cacheReadInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass7_._003CContains_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Ec__DisplayClass7_.key = key;
				num2 = 5;
				break;
			case 1:
				try
				{
					bool flag = ContainsInternal(_003C_003Ec__DisplayClass7_.key, _003C_003Ec__DisplayClass7_.region);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							if (cacheReadInfo != null)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 1;
						case 1:
							result = flag;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							kVTogafKFJJ5FfXtNOrT(cacheReadInfo, flag);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num3 = 1;
							}
							break;
						case 3:
							return result;
						}
					}
				}
				finally
				{
					int num4;
					if (cacheReadInfo == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num4 = 2;
						}
						goto IL_0153;
					}
					goto IL_0188;
					IL_0188:
					((IDisposable)cacheReadInfo).Dispose();
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num4 = 0;
					}
					goto IL_0153;
					IL_0153:
					switch (num4)
					{
					case 2:
						goto end_IL_012e;
					case 1:
						goto end_IL_012e;
					}
					goto IL_0188;
					end_IL_012e:;
				}
			case 2:
				_003C_003Ec__DisplayClass7_.region = region;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return result;
			case 3:
				_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 3;
				break;
			}
		}
	}

	public T Get<T>(string key)
	{
		return Get<T>(key, null);
	}

	public T Get<T>(string key, string region)
	{
		_003C_003Ec__DisplayClass9_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.region = region;
		CS_0024_003C_003E8__locals0.key = key;
		using CacheReadInfo cacheReadInfo = DiagnosticsManager.StartCall(delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (CS_0024_003C_003E8__locals0._003C_003E4__this.needDiagnostics)
					{
						return new CacheReadInfo
						{
							Region = CS_0024_003C_003E8__locals0.region,
							Key = CS_0024_003C_003E8__locals0.key
						};
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return null;
				}
			}
		});
		object value = GetValue(CS_0024_003C_003E8__locals0.key, CS_0024_003C_003E8__locals0.region);
		if (cacheReadInfo != null)
		{
			cacheReadInfo.Success = value != null;
		}
		return DisassembleValue<T>(value);
	}

	public bool TryGetValue<T>(string key, out T value)
	{
		return TryGetValue<T>(key, null, out value);
	}

	public virtual bool TryGetValue<T>(string key, string region, out T value)
	{
		_003C_003Ec__DisplayClass11_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.region = region;
		CS_0024_003C_003E8__locals0.key = key;
		using CacheReadInfo cacheReadInfo = DiagnosticsManager.StartCall(delegate
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (CS_0024_003C_003E8__locals0._003C_003E4__this.needDiagnostics)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					return new CacheReadInfo
					{
						Region = CS_0024_003C_003E8__locals0.region,
						Key = CS_0024_003C_003E8__locals0.key
					};
				}
			}
		});
		object value2 = GetValue(CS_0024_003C_003E8__locals0.key, CS_0024_003C_003E8__locals0.region);
		if (cacheReadInfo != null)
		{
			cacheReadInfo.Success = value2 != null;
		}
		if (value2 == null)
		{
			value = default(T);
			return false;
		}
		if (value2 is CachedNull)
		{
			value = default(T);
			return true;
		}
		value = (T)value2;
		return true;
	}

	public void Remove(string key)
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
				Remove(key, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Remove(string key, string region)
	{
		//Discarded unreachable code: IL_00fa, IL_0132, IL_016a, IL_0179
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		CacheWriteInfo cacheWriteInfo = default(CacheWriteInfo);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass13_.region = region;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass13_._003C_003E4__this = this;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				cacheWriteInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass13_._003CRemove_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass13_.key = key;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				Ym3KMofKBaK9geXBTfOZ(this, _003C_003Ec__DisplayClass13_.key, _003C_003Ec__DisplayClass13_.region);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				if (cacheWriteInfo != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							RdJiJJfKWwTQROb4Ef0b(cacheWriteInfo);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void ClearRegion(string region)
	{
		//Discarded unreachable code: IL_005c, IL_0094, IL_00cc, IL_00db
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		CacheWriteInfo cacheWriteInfo = default(CacheWriteInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					ClearRegionInternal(_003C_003Ec__DisplayClass14_.region);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (cacheWriteInfo != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								RdJiJJfKWwTQROb4Ef0b(cacheWriteInfo);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			default:
				_003C_003Ec__DisplayClass14_.region = region;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 5:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 4;
				break;
			case 1:
				cacheWriteInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass14_._003CClearRegion_003Eb__0);
				num2 = 3;
				break;
			}
		}
	}

	public virtual void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
	}

	protected abstract void InsertValue<T>(string key, object value, string region, TimeSpan cacheDuration, CacheItemRemovedCallback<T> onRemoveItemCallback);

	protected abstract object GetValue(string key, string region);

	protected abstract bool ContainsInternal(string key, string region);

	protected abstract void RemoveInternal(string key, string region);

	protected abstract void ClearRegionInternal(string region);

	protected static object AssembleValue<T>(T value)
	{
		return ((object)value) ?? NullValue;
	}

	protected static T DisassembleValue<T>(object value)
	{
		return (T)((value is CachedNull) ? null : value);
	}

	static CacheService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			CachedNull cachedNull = new CachedNull();
			fw4PjKfKo3mMI8lMg8l3(cachedNull, 0);
			NullValue = cachedNull;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void Ye3vh8fqzwgI44ervFBo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool t2s2VyfqsSFYpkGNIw4x()
	{
		return yo7sP4fqUcgjgGR8G0lW == null;
	}

	internal static CacheService j7nmbqfqcrCd2VchkVxO()
	{
		return yo7sP4fqUcgjgGR8G0lW;
	}

	internal static void kVTogafKFJJ5FfXtNOrT(object P_0, bool value)
	{
		((CacheReadInfo)P_0).Success = value;
	}

	internal static void Ym3KMofKBaK9geXBTfOZ(object P_0, object P_1, object P_2)
	{
		((CacheService)P_0).RemoveInternal((string)P_1, (string)P_2);
	}

	internal static void RdJiJJfKWwTQROb4Ef0b(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void fw4PjKfKo3mMI8lMg8l3(object P_0, byte value)
	{
		((CachedNull)P_0).Value = value;
	}
}

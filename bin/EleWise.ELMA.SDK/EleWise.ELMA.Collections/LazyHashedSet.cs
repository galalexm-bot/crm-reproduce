using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Collections;

public class LazyHashedSet<T> : HashedSet<T>
{
	protected Func<ICollection<object>> CalcFunc;

	private bool initialized;

	private object lockObj;

	private static object mLSZVfm2wlbLyyx5vUE;

	public override bool IsEmpty
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
					return ((Set<T>)(object)this).get_IsEmpty();
				case 1:
					InitCollection();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LazyHashedSet(Func<ICollection<object>> calcFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		lockObj = new object();
		base._002Ector();
		CalcFunc = calcFunc;
	}

	protected void InitCollection()
	{
		//Discarded unreachable code: IL_0058, IL_0083, IL_011d, IL_0155, IL_0164
		int num = 1;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		List<T> list = default(List<T>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							((Set<T>)(object)this).AddAll((ICollection)list);
							num3 = 5;
							break;
						default:
							if (initialized)
							{
								num3 = 2;
								break;
							}
							goto case 4;
						case 4:
							initialized = true;
							num3 = 3;
							break;
						case 3:
							list = CalcFunc().Cast<T>().ToList();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 1;
							}
							break;
						case 5:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Monitor.Exit(obj);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 1:
				if (initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				obj = lockObj;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public override IEnumerator<T> GetEnumerator()
	{
		InitCollection();
		return ((Set<T>)(object)this).GetEnumerator();
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((object)this).Equals(obj);
			case 1:
				InitCollection();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool ContainsAll(ICollection c)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((Set<T>)(object)this).ContainsAll(c);
			case 1:
				InitCollection();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool RemoveAll(ICollection c)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((Set<T>)(object)this).RemoveAll(c);
			case 1:
				InitCollection();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool X7cWIsmenfk0ZWDOuZK()
	{
		return mLSZVfm2wlbLyyx5vUE == null;
	}

	internal static object hECT1smPD2dgHbO6vLO()
	{
		return mLSZVfm2wlbLyyx5vUE;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal sealed class MappersCollection : ICollection<IInternalMapperConfiguration>, IEnumerable<IInternalMapperConfiguration>, IEnumerable
{
	private readonly ICollection<IInternalMapperConfiguration> mappers;

	private readonly ICollection<IInternalMapperConfiguration> moduleMappers;

	private readonly ICollection<IInternalMapperConfiguration> systemMappers;

	private static MappersCollection UMEP95hxKxBGvRRjX1Z2;

	public int Count => VHTu24hxn1HRXCdNmoCB(mappers) + VHTu24hxn1HRXCdNmoCB(moduleMappers) + systemMappers.Count;

	public bool IsReadOnly => false;

	public MappersCollection()
	{
		//Discarded unreachable code: IL_0034, IL_0039
		bPRIvOhxkBAkIXC9Gdpt();
		this._002Ector(Array.Empty<IInternalMapperConfiguration>(), Array.Empty<IInternalMapperConfiguration>());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MappersCollection(ICollection<IInternalMapperConfiguration> moduleMappers, ICollection<IInternalMapperConfiguration> systemMappers)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.moduleMappers = moduleMappers;
		this.systemMappers = systemMappers;
		mappers = new ConcurrentHashSet<IInternalMapperConfiguration>();
	}

	public IEnumerator<IInternalMapperConfiguration> GetEnumerator()
	{
		return mappers.Concat(moduleMappers).Concat(systemMappers).GetEnumerator();
	}

	public void Add(IInternalMapperConfiguration item)
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
				mappers.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
				a3fftNhxOXWyjYqY47wQ(mappers);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool Contains(IInternalMapperConfiguration item)
	{
		//Discarded unreachable code: IL_0081
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 4:
				return true;
			case 1:
				return false;
			case 3:
				if (mappers.Contains(item))
				{
					num2 = 2;
					break;
				}
				if (!moduleMappers.Contains(item))
				{
					if (!systemMappers.Contains(item))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return true;
			}
		}
	}

	public void CopyTo(IInternalMapperConfiguration[] array, int arrayIndex)
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
				B0NTk6hx27plKpv7PH7a(mappers, array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Remove(IInternalMapperConfiguration item)
	{
		return mappers.Remove(item);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static void bPRIvOhxkBAkIXC9Gdpt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bAbsF4hxXJNGMxn1AKCM()
	{
		return UMEP95hxKxBGvRRjX1Z2 == null;
	}

	internal static MappersCollection EOjYsIhxT1Opao3sX54l()
	{
		return UMEP95hxKxBGvRRjX1Z2;
	}

	internal static int VHTu24hxn1HRXCdNmoCB(object P_0)
	{
		return ((ICollection<IInternalMapperConfiguration>)P_0).Count;
	}

	internal static void a3fftNhxOXWyjYqY47wQ(object P_0)
	{
		((ICollection<IInternalMapperConfiguration>)P_0).Clear();
	}

	internal static void B0NTk6hx27plKpv7PH7a(object P_0, object P_1, int P_2)
	{
		((ICollection<IInternalMapperConfiguration>)P_0).CopyTo((IInternalMapperConfiguration[])P_1, P_2);
	}
}

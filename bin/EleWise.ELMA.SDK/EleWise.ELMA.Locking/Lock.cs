using System;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Locking;

public class Lock : ILock, IDisposable
{
	private readonly string name;

	private readonly Action releaseLockAction;

	private int count;

	private int totalCount;

	protected readonly TimeSpan ttl;

	protected bool disposed;

	public EventHandler Disposing;

	internal static Lock rLACYbhrl2vZLKnMpbto;

	public virtual string Name => name;

	public int Count => count;

	public int TotalCount => totalCount;

	public Lock(string name, TimeSpan ttl, Action releaseLockAction)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		F5EmBchr5YSjmiKlACZW();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				this.name = name;
				num = 2;
				break;
			case 2:
				this.ttl = ttl;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 1;
				}
				break;
			default:
				count = 1;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 5;
				}
				break;
			case 5:
				totalCount = 1;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 3;
				}
				break;
			case 4:
				return;
			case 1:
				this.releaseLockAction = releaseLockAction;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal void Increment()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				count++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				totalCount++;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public virtual void Dispose()
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_00ed, IL_00fc
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (releaseLockAction == null)
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 3:
				Disposing = null;
				num2 = 10;
				break;
			case 9:
				releaseLockAction();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 6:
				if (count != 0)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 10:
				return;
			case 1:
			case 5:
				OnDisposing();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (disposed)
				{
					num2 = 7;
					break;
				}
				count--;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				return;
			default:
				disposed = true;
				num2 = 3;
				break;
			}
		}
	}

	private void OnDisposing()
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
				NZZjKthrjf38s8eO8VSG(Disposing, this, EventArgs.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void F5EmBchr5YSjmiKlACZW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CmteD0hrrklyIJkwpuht()
	{
		return rLACYbhrl2vZLKnMpbto == null;
	}

	internal static Lock MpJbeGhrgE2B1tQmJWTD()
	{
		return rLACYbhrl2vZLKnMpbto;
	}

	internal static void NZZjKthrjf38s8eO8VSG(object P_0, object P_1, object P_2)
	{
		((EventHandler)P_0).Raise(P_1, (EventArgs)P_2);
	}
}

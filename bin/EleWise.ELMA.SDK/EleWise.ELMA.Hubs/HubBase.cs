using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Hubs;

public abstract class HubBase<T> : IHub, IDisposable where T : IClient
{
	private static object WRJ9KAhgmVUqbXwthXPH;

	public IHubCallerConnectionContextWrapper<T> Clients { get; set; }

	public IHubCallerContextWrapper Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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

	public IGroupManagerWrapper Groups
	{
		[CompilerGenerated]
		get
		{
			return _003CGroups_003Ek__BackingField;
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
					_003CGroups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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

	public virtual Task OnConnected()
	{
		return Task.CompletedTask;
	}

	public virtual Task OnReconnected()
	{
		return Task.CompletedTask;
	}

	public virtual Task OnDisconnected(bool stopCalled)
	{
		return Task.CompletedTask;
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
				GC.SuppressFinalize(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				Dispose(disposing: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected HubBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool axQUHJhgyKMwLrhoytnL()
	{
		return WRJ9KAhgmVUqbXwthXPH == null;
	}

	internal static object zpjRgbhgMh4rNU25iO95()
	{
		return WRJ9KAhgmVUqbXwthXPH;
	}
}

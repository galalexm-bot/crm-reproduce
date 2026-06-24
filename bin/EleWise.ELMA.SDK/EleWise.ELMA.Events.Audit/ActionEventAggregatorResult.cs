using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

public class ActionEventAggregatorResult
{
	private static ActionEventAggregatorResult Xk8fOiGLtvvbuDqngmK9;

	public IEntityActionEventAggregator Aggregator
	{
		[CompilerGenerated]
		get
		{
			return _003CAggregator_003Ek__BackingField;
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
					_003CAggregator_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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

	public EntityActionEventArgs EventArgs
	{
		[CompilerGenerated]
		get
		{
			return _003CEventArgs_003Ek__BackingField;
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
					_003CEventArgs_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Persist
	{
		[CompilerGenerated]
		get
		{
			return _003CPersist_003Ek__BackingField;
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
					_003CPersist_003Ek__BackingField = value;
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

	public ActionEventAggregatorResult(IEntityActionEventAggregator aggregator, EntityActionEventArgs eventArgs, bool persist)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				EventArgs = eventArgs;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Aggregator = aggregator;
				num = 3;
				break;
			case 0:
				return;
			case 1:
				Persist = persist;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool Obsm7oGLwsD3qEtAtLDN()
	{
		return Xk8fOiGLtvvbuDqngmK9 == null;
	}

	internal static ActionEventAggregatorResult CRP0eZGL42HTyP2Ha9Hp()
	{
		return Xk8fOiGLtvvbuDqngmK9;
	}
}

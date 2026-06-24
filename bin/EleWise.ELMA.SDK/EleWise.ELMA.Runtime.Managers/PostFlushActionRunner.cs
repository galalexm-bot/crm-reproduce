using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

[Component]
public class PostFlushActionRunner : IUnitOfWorkEventListener
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private static PostFlushActionRunner B3Ex1rWMdmJi19nJsoy4;

	private IDictionary<string, Action> Actions => contextBoundVariableService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92D22CB), () => new Dictionary<string, Action>());

	public PostFlushActionRunner(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bjNFJbWMgDlwWAgdNq3W();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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
			this.contextBoundVariableService = contextBoundVariableService;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
			{
				num = 1;
			}
		}
	}

	public void Add(Action action)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)dvPEGYWM5NyPDyndoSaN(-475857671 ^ -475798259));
			case 1:
				Actions.Add(bcv3XBWMj0LsE8A9cGea().ToString(), action);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 2:
				if (action != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public void Add(string key, Action action)
	{
		//Discarded unreachable code: IL_00e8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (key == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (action != null)
				{
					if (Actions.ContainsKey(key))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				num2 = 5;
				continue;
			case 5:
				throw new ArgumentNullException((string)dvPEGYWM5NyPDyndoSaN(-606654180 ^ -606721816));
			case 2:
				return;
			case 4:
				return;
			default:
				throw new ArgumentNullException((string)dvPEGYWM5NyPDyndoSaN(-1638402543 ^ -1638497871));
			case 3:
				break;
			}
			Actions.Add(key, action);
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num2 = 1;
			}
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
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
				Actions.ForEach(delegate(KeyValuePair<string, Action> p)
				{
					p.Value();
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
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
				WVoqGOWMYZIWhqpp0Vgq(Actions);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void bjNFJbWMgDlwWAgdNq3W()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YcyFg9WMlvus6CURyUV4()
	{
		return B3Ex1rWMdmJi19nJsoy4 == null;
	}

	internal static PostFlushActionRunner kN5uSrWMrHPZkpF3YPsg()
	{
		return B3Ex1rWMdmJi19nJsoy4;
	}

	internal static object dvPEGYWM5NyPDyndoSaN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid bcv3XBWMj0LsE8A9cGea()
	{
		return Guid.NewGuid();
	}

	internal static void WVoqGOWMYZIWhqpp0Vgq(object P_0)
	{
		((ICollection<KeyValuePair<string, Action>>)P_0).Clear();
	}
}

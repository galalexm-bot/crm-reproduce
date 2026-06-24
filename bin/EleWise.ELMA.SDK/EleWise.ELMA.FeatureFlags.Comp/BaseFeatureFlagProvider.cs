using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.FeatureFlags.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FeatureFlags.Components;

internal abstract class BaseFeatureFlagProvider : IFeatureFlagProvider
{
	private static BaseFeatureFlagProvider a8n2xDGWAuDTDe82alnA;

	private event EventHandler flagsChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 4:
					eventHandler = Interlocked.CompareExchange(ref this.flagsChanged, value2, eventHandler2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					if ((object)eventHandler == eventHandler2)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					return;
				case 1:
					eventHandler = this.flagsChanged;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				eventHandler2 = eventHandler;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 5;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 3;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 5;
						break;
					}
					goto case 2;
				case 5:
					return;
				case 3:
					eventHandler2 = this.flagsChanged;
					num2 = 2;
					break;
				default:
					value2 = (EventHandler)o66pJxGW0JASTNqxfXUo(eventHandler, value);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					eventHandler = eventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					eventHandler2 = Interlocked.CompareExchange(ref this.flagsChanged, value2, eventHandler);
					num2 = 4;
					break;
				}
			}
		}
	}

	event EventHandler IFeatureFlagProvider.FlagsChanged
	{
		add
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
					flagsChanged += value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		remove
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
					flagsChanged -= value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	protected void FlagsChanged()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				EventHandler eventHandler = this.flagsChanged;
				if (eventHandler == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 1;
					}
					break;
				}
				eventHandler(this, EventArgs.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	public abstract IEnumerable<(string featureFlagName, bool enabled)> GetFlags(IEnumerable<string> featureFlagNames);

	protected BaseFeatureFlagProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DiGa56GW7kqkOuV9W9vL()
	{
		return a8n2xDGWAuDTDe82alnA == null;
	}

	internal static BaseFeatureFlagProvider u5VBAqGWxSE0jM4PV1pF()
	{
		return a8n2xDGWAuDTDe82alnA;
	}

	internal static object o66pJxGW0JASTNqxfXUo(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}
}

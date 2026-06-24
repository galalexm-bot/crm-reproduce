using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

internal class Event
{
	internal static Event HDajEdG7GFiQgOneJLTN;

	public Delegate EventDelegate
	{
		[CompilerGenerated]
		get
		{
			return _003CEventDelegate_003Ek__BackingField;
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
					_003CEventDelegate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public Event(Delegate evt)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		etNOPeG7Qyn2ZB1QmjKE();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				EventDelegate = evt;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Raise(object sender, object eventArgObject)
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
				Raise(new object[2] { sender, eventArgObject });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Raise(object[] args)
	{
		//Discarded unreachable code: IL_0061, IL_00dd, IL_0177, IL_01ca, IL_029b, IL_02aa
		int num = 9;
		Delegate @delegate = default(Delegate);
		bool flag = default(bool);
		int num3 = default(int);
		Delegate[] array = default(Delegate[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					try
					{
						ISynchronizeInvoke synchronizeInvoke = @delegate.Target as ISynchronizeInvoke;
						int num4 = 5;
						while (true)
						{
							switch (num4)
							{
							case 7:
								xgcCpTG7ZFE3Y9J0DSZw(@delegate, args);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num4 = 0;
								}
								continue;
							case 3:
								if (oSCQruG7vpsoiBwF4wVO(synchronizeInvoke))
								{
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num4 = 5;
									}
									continue;
								}
								goto case 4;
							case 1:
								break;
							case 2:
								ynIp33G78mc1efZ3WJeA(synchronizeInvoke, @delegate, args);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num4 = 0;
								}
								continue;
							case 4:
								flag = true;
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num4 = 7;
								}
								continue;
							case 6:
								flag = true;
								num4 = 2;
								continue;
							case 5:
								if (synchronizeInvoke != null)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 4;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (!flag)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
									{
										num5 = 1;
									}
									continue;
								}
								break;
							case 1:
								xgcCpTG7ZFE3Y9J0DSZw(@delegate, args);
								num5 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 6;
				case 6:
					num3++;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 5:
					@delegate = array[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					break;
				default:
					if (num3 < array.Length)
					{
						num2 = 5;
						continue;
					}
					return;
				case 8:
					return;
				case 2:
					return;
				case 9:
					if ((object)EventDelegate != null)
					{
						array = (Delegate[])CmvLJfG7CSvybQxpDWZy(EventDelegate);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			flag = false;
			num = 4;
		}
	}

	internal static bool tUtjHwG7EeLItd6ohahm()
	{
		return HDajEdG7GFiQgOneJLTN == null;
	}

	internal static Event D8bgHkG7f0s14UgrJotG()
	{
		return HDajEdG7GFiQgOneJLTN;
	}

	internal static void etNOPeG7Qyn2ZB1QmjKE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object CmvLJfG7CSvybQxpDWZy(object P_0)
	{
		return ((Delegate)P_0).GetInvocationList();
	}

	internal static bool oSCQruG7vpsoiBwF4wVO(object P_0)
	{
		return ((ISynchronizeInvoke)P_0).InvokeRequired;
	}

	internal static object ynIp33G78mc1efZ3WJeA(object P_0, object P_1, object P_2)
	{
		return ((ISynchronizeInvoke)P_0).Invoke((Delegate)P_1, (object[])P_2);
	}

	internal static object xgcCpTG7ZFE3Y9J0DSZw(object P_0, object P_1)
	{
		return ((Delegate)P_0).DynamicInvoke((object[])P_1);
	}
}

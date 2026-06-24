using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

[Obsolete("Not used", true)]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class BaseUserLogonSweepHandler : ISweepHandler
{
	private DateTime lastDateExecute;

	private bool isExecuting;

	private int period;

	private static BaseUserLogonSweepHandler ErosG51JpSA0rYAqjjZ;

	[Obsolete("Not used", true)]
	public SecuritySettings Settings => Locator.GetServiceNotNull<SecuritySettingsModule>().Settings;

	[Obsolete("Not used", true)]
	public UserSecurityProfileManager UserSecurityProfileManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserSecurityProfileManager_003Ek__BackingField;
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
					_003CUserSecurityProfileManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
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

	[Obsolete("Not used", true)]
	public DateTime LastDateSuccessExecute
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					lastDateExecute = mSJIbm1OG5ahgjJrxgG();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					_ = lastDateExecute;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (zDBJTO1h6AjSUN01j6s(lastDateExecute, DateTime.MinValue))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					break;
				}
				break;
			}
			return lastDateExecute;
		}
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
					lastDateExecute = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
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

	[Obsolete("Not used", true)]
	public int Period
	{
		get
		{
			//Discarded unreachable code: IL_005c, IL_006b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return 0;
				default:
					return period;
				case 1:
					if (period > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
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
				case 0:
					return;
				case 1:
					period = ((value > 0) ? value : 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Not used", true)]
	public virtual void SetPeriod()
	{
	}

	[Obsolete("Not used", true)]
	public virtual bool CheckPeriod()
	{
		int num = 1;
		int num2 = num;
		DateTime lastDateSuccessExecute = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 3:
				lastDateSuccessExecute = LastDateSuccessExecute;
				num2 = 5;
				break;
			case 5:
				return lastDateSuccessExecute.AddHours(1.0) < mSJIbm1OG5ahgjJrxgG();
			case 2:
				return lastDateSuccessExecute.AddHours(4.0) < mSJIbm1OG5ahgjJrxgG();
			case 8:
				return Wj6STo1qVESa9gcUN1D(lastDateSuccessExecute.AddMinutes(10.0), mSJIbm1OG5ahgjJrxgG());
			case 6:
				lastDateSuccessExecute = LastDateSuccessExecute;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				lastDateSuccessExecute = LastDateSuccessExecute;
				num2 = 8;
				break;
			case 4:
				return Wj6STo1qVESa9gcUN1D(lastDateSuccessExecute.AddMinutes(1.0), mSJIbm1OG5ahgjJrxgG());
			case 1:
				if (Period <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 0;
					}
				}
				else if (Period > 15)
				{
					if (Period > 90)
					{
						if (Period > 1440)
						{
							lastDateSuccessExecute = LastDateSuccessExecute;
							num2 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
							{
								num2 = 1;
							}
						}
						else
						{
							num2 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
							{
								num2 = 3;
							}
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num2 = 7;
						}
					}
				}
				else
				{
					num2 = 6;
				}
				break;
			default:
				return false;
			}
		}
	}

	[Obsolete("Not used", true)]
	public virtual void DoWork()
	{
	}

	[Obsolete("Not used", true)]
	public virtual void Execute()
	{
		//Discarded unreachable code: IL_005a, IL_00b6, IL_011f, IL_0132, IL_0141, IL_01b0, IL_01bf
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						XtQsw71FiwhmSDgrPbP(this);
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							}
							LastDateSuccessExecute = mSJIbm1OG5ahgjJrxgG();
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
							{
								num3 = 0;
							}
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							((ILogger)lAyokk10XipUN9FjVqT()).Error(TWFYoL1EDNFMoO07jua(ex), ex);
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
							{
								num4 = 0;
							}
						}
					}
					finally
					{
						isExecuting = false;
						int num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 2:
					if (sqTOD11Gj30D8iftRN9(this))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
						{
							num2 = 3;
						}
						break;
					}
					return;
				case 5:
					if (isExecuting)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 6:
					c9UeSv1c4WNv12kvRXv(this);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
					{
						num2 = 5;
					}
					break;
				case 0:
					return;
				case 4:
					return;
				case 3:
					isExecuting = true;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	protected BaseUserLogonSweepHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		moIa451D76eKBnyFRH1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TJWjdG1KkgD7q0qKybv()
	{
		return ErosG51JpSA0rYAqjjZ == null;
	}

	internal static BaseUserLogonSweepHandler joH8D01thaFuUhwvISV()
	{
		return ErosG51JpSA0rYAqjjZ;
	}

	internal static bool zDBJTO1h6AjSUN01j6s(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime mSJIbm1OG5ahgjJrxgG()
	{
		return DateTime.Now;
	}

	internal static bool Wj6STo1qVESa9gcUN1D(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static void c9UeSv1c4WNv12kvRXv(object P_0)
	{
		((BaseUserLogonSweepHandler)P_0).SetPeriod();
	}

	internal static bool sqTOD11Gj30D8iftRN9(object P_0)
	{
		return ((BaseUserLogonSweepHandler)P_0).CheckPeriod();
	}

	internal static void XtQsw71FiwhmSDgrPbP(object P_0)
	{
		((BaseUserLogonSweepHandler)P_0).DoWork();
	}

	internal static object lAyokk10XipUN9FjVqT()
	{
		return Logger.Log;
	}

	internal static object TWFYoL1EDNFMoO07jua(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void moIa451D76eKBnyFRH1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

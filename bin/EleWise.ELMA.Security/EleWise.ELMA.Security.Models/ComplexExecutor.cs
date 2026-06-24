using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models;

public class ComplexExecutor
{
	private static ComplexExecutor PjStaCtaBfl0rnMSfGN;

	public List<ComplexExecutorInfo> Workers { get; set; }

	public List<IUser> Users
	{
		get
		{
			if (Workers == null)
			{
				return new List<IUser>();
			}
			return (from w in Workers
				where _003C_003Ec.wUZmvypj5GZ6wgjDnHxk(w) != null
				select (IUser)_003C_003Ec.wUZmvypj5GZ6wgjDnHxk(w)).ToList();
		}
	}

	public List<IUserGroup> Groups
	{
		get
		{
			if (Workers == null)
			{
				return new List<IUserGroup>();
			}
			return (from w in Workers
				where _003C_003Ec.fV6y6rpjALpIrDnJdLF8(w) != null
				select w.UserGroup).ToList();
		}
	}

	public List<IUser> CalcExecutors()
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.executors = new List<IUser>(Users);
		Groups.ForEach(delegate(IUserGroup g)
		{
			//Discarded unreachable code: IL_002e, IL_00dd, IL_00ec, IL_013c, IL_014b, IL_01aa, IL_01e2, IL_01f1
			int num = 1;
			int num2 = num;
			IEnumerator<long> enumerator = default(IEnumerator<long>);
			IUser user = default(IUser);
			_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_1);
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!_003C_003Ec__DisplayClass8_0.ie8lW2pjlS7IYHMcGB7k(enumerator))
							{
								num3 = 7;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
								{
									num3 = 6;
								}
								goto IL_003c;
							}
							goto IL_00f7;
							IL_003c:
							while (true)
							{
								switch (num3)
								{
								default:
									CS_0024_003C_003E8__locals0.executors.Add(user);
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
									user = UserManager.Instance.Load(_003C_003Ec__DisplayClass8_.user);
									num3 = 9;
									continue;
								case 1:
								case 2:
								case 5:
									break;
								case 8:
									goto IL_00f7;
								case 3:
									if (CS_0024_003C_003E8__locals0.executors.All(_003C_003Ec__DisplayClass8_._003CCalcExecutors_003Eb__1))
									{
										goto case 4;
									}
									goto IL_0129;
								case 6:
									_003C_003Ec__DisplayClass8_.user = enumerator.Current;
									num3 = 3;
									continue;
								case 9:
									if (_003C_003Ec__DisplayClass8_0.GPJILgpj61tOJmBnUydN(user) != 0)
									{
										num3 = 2;
										continue;
									}
									goto default;
								case 7:
									return;
								}
								break;
							}
							continue;
							IL_0129:
							int num4 = 5;
							goto IL_0038;
							IL_00f7:
							_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
							num4 = 6;
							goto IL_0038;
							IL_0038:
							num3 = num4;
							goto IL_003c;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									_003C_003Ec__DisplayClass8_0.pMk7cOpjNJFNVEl7rsM8(enumerator);
									num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 1:
					enumerator = ((UserGroupManager)_003C_003Ec__DisplayClass8_0.rLwFPMpj722HPTLCUMiV()).GetUsersByGroup(g.Id).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.executors;
	}

	public ComplexExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		y7QmHIt2hdMynG5KuES();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
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
				Workers = new List<ComplexExecutorInfo>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void y7QmHIt2hdMynG5KuES()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool YB0nWStRcTLtGt8FMGE()
	{
		return PjStaCtaBfl0rnMSfGN == null;
	}

	internal static ComplexExecutor G3I9O9twoywpAGb2jps()
	{
		return PjStaCtaBfl0rnMSfGN;
	}
}

using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.CodeGeneration;

[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class ProcessContextDeletedPropertyAttribute : Attribute
{
	public static string FullName;

	internal static ProcessContextDeletedPropertyAttribute Kq28e8OY7yHR0yjAlOWt;

	public long VersionNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CVersionNumber_003Ek__BackingField;
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
					_003CVersionNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
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

	public ProcessContextDeletedPropertyAttribute(long versionNumber)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		u9CQ0AOYFolUmIEcy9BN();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				VersionNumber = versionNumber;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static ProcessContextDeletedPropertyAttribute()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				u9CQ0AOYFolUmIEcy9BN();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				FullName = qjs2PDOYiZ1jX6sDv1Lc(typeof(ProcessContextDeletedPropertyAttribute).TypeHandle).FullName;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void u9CQ0AOYFolUmIEcy9BN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool h0gaKPOY21T2wcHCeN6A()
	{
		return Kq28e8OY7yHR0yjAlOWt == null;
	}

	internal static ProcessContextDeletedPropertyAttribute TdAfMdOYoYcm4TNljJdg()
	{
		return Kq28e8OY7yHR0yjAlOWt;
	}

	internal static Type qjs2PDOYiZ1jX6sDv1Lc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

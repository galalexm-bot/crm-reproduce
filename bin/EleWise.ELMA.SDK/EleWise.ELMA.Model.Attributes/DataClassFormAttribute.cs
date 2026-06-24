using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class DataClassFormAttribute : Attribute
{
	internal static DataClassFormAttribute qckkJ9of8HOT1go3kTrp;

	internal string ViewType { get; }

	internal string ComponentHeaderUid { get; }

	public DataClassFormAttribute(string viewType, string componentHeaderUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yKWseKofI4WTa3tWwHoe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ComponentHeaderUid = componentHeaderUid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 1;
				}
				break;
			default:
				ViewType = viewType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void yKWseKofI4WTa3tWwHoe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool lFiyvTofZEJKNKdw0GuU()
	{
		return qckkJ9of8HOT1go3kTrp == null;
	}

	internal static DataClassFormAttribute i1nbiNofuZajRnurtmnk()
	{
		return qckkJ9of8HOT1go3kTrp;
	}
}

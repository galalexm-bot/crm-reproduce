using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToBoolConvertor : TypeConvertor
{
	internal static ToBoolConvertor ndZFvvojBwocxhlL3Bka;

	public override List<Guid> SourceTypeUids => new List<Guid>
	{
		BoolDescriptor.UID,
		Int16Descriptor.UID,
		Int32Descriptor.UID,
		Int64Descriptor.UID,
		DoubleDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID,
		StringDescriptor.UID
	};

	public override List<Guid> TargetTypeUids => new List<Guid> { BoolDescriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_005d, IL_008f, IL_00a6, IL_00b5
		int num = 2;
		int num2 = num;
		bool? flag = default(bool?);
		while (true)
		{
			switch (num2)
			{
			default:
				return flag;
			case 3:
				try
				{
					flag = (bool?)HF9M8NojboITpZL9yHWW(obj, TypeCode.Boolean);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 2:
				flag = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ToBoolConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object HF9M8NojboITpZL9yHWW(object P_0, TypeCode P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	internal static bool Deq9JGojWmY2v1QHjG6T()
	{
		return ndZFvvojBwocxhlL3Bka == null;
	}

	internal static ToBoolConvertor VWtmXCojoNqravriyBKt()
	{
		return ndZFvvojBwocxhlL3Bka;
	}
}

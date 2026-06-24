using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("WorkTimeValue")]
public class WorkTimeWrapper : IXsiType
{
	internal static WorkTimeWrapper wyFGdkbo5Qo4jh2XRE3O;

	[XmlElement("Value")]
	public long Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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

	public WorkTimeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkTimeWrapper(WorkTime source)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		b18AmGboLSJq4ghpiRxw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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
			Value = source.Value;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool L13Z6lbojjeif1lWyqMg()
	{
		return wyFGdkbo5Qo4jh2XRE3O == null;
	}

	internal static WorkTimeWrapper zArDC1boYeDwn92R05Fl()
	{
		return wyFGdkbo5Qo4jh2XRE3O;
	}

	internal static void b18AmGboLSJq4ghpiRxw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

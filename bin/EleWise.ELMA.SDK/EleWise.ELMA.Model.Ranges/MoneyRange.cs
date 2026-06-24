using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Model.Ranges;

public struct MoneyRange : IRange<Money>
{
	internal static object IlluDsWzArohGje9NaGf;

	public Money From
	{
		[CompilerGenerated]
		get
		{
			return _003CFrom_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CFrom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Money To
	{
		[CompilerGenerated]
		get
		{
			return _003CTo_003Ek__BackingField;
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
					_003CTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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

	Money? IRange<Money>.From
	{
		get
		{
			if (!From.HasValue)
			{
				return null;
			}
			return From;
		}
		set
		{
			From = value ?? new Money
			{
				HasValue = false
			};
		}
	}

	Money? IRange<Money>.To
	{
		get
		{
			if (!To.HasValue)
			{
				return null;
			}
			return To;
		}
		set
		{
			To = value ?? new Money
			{
				HasValue = false
			};
		}
	}

	internal static bool Ge7HO0Wz7n9OZ88nZfe1()
	{
		return IlluDsWzArohGje9NaGf == null;
	}

	internal static object ePuh5xWzxuqKw5SuiiMU()
	{
		return IlluDsWzArohGje9NaGf;
	}
}

using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours;

internal sealed class RestartIfCollectionChanged : IPublicationBehaviourChecker
{
	private static RestartIfCollectionChanged lQF3ssbrnEXyrdxWN15V;

	public PublicationType Check(CheckType action, object oldValue, object newValue)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0098, IL_011b, IL_012a, IL_0139
		int num = 2;
		IEnumerable<object> source = default(IEnumerable<object>);
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (action != CheckType.Change)
					{
						num2 = 6;
						continue;
					}
					source = (IEnumerable<object>)oldValue;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
					if (source.SetEqual(enumerable))
					{
						num2 = 8;
						continue;
					}
					goto case 10;
				case 10:
					return PublicationType.Restart;
				case 8:
					return PublicationType.Soft;
				case 6:
					return PublicationType.Restart;
				case 1:
				case 5:
					if (!((IEnumerable<object>)newValue).Any())
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 11:
					break;
				case 3:
					if (source.Count() == enumerable.Count())
					{
						num2 = 4;
						continue;
					}
					goto case 10;
				case 2:
					if (action == CheckType.Create)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 7:
					return PublicationType.Restart;
				case 9:
					return PublicationType.Delta;
				}
				break;
			}
			enumerable = (IEnumerable<object>)newValue;
			num = 3;
		}
	}

	public RestartIfCollectionChanged()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dqUOj7breLjXLoKOrquI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rOtmn4brONkxmIwdu6qy()
	{
		return lQF3ssbrnEXyrdxWN15V == null;
	}

	internal static RestartIfCollectionChanged hxgfYDbr21eoT3rintGu()
	{
		return lQF3ssbrnEXyrdxWN15V;
	}

	internal static void dqUOj7breLjXLoKOrquI()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

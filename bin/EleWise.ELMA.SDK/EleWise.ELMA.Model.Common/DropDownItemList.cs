using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public class DropDownItemList : List<DropDownItem>
{
	internal static DropDownItemList J6HiW1hKYwL1aaLVdhDO;

	public void Parse(string itemsString)
	{
		//Discarded unreachable code: IL_018d
		int num = 6;
		string text = default(string);
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					Add(new DropDownItem((string)VeqVg8hXBxZEBjiloIOs(VeqVg8hXBxZEBjiloIOs(text, zOyOqAhKcRBARgjpDZa7(0x3A6135BE ^ 0x3A627044), zOyOqAhKcRBARgjpDZa7(0x4D1C1EE4 ^ 0x4D1C001C)), zOyOqAhKcRBARgjpDZa7(0x269E5FCA ^ 0x269D19C2), zOyOqAhKcRBARgjpDZa7(-289714582 ^ -289713714))));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					return;
				case 6:
					JPa5hNhKsrt5FaasQVrg(this);
					num2 = 5;
					continue;
				case 2:
				case 8:
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 4:
					return;
				case 1:
					num3 = 0;
					num2 = 2;
					continue;
				case 5:
					if (!string.IsNullOrEmpty(itemsString))
					{
						array = (string[])E704DwhXFAdiIMlLiFcn(itemsString, xxU6NFhKz5p1tslkiFPV(zOyOqAhKcRBARgjpDZa7(0x12A5FAC7 ^ 0x12A599F9)), StringSplitOptions.RemoveEmptyEntries);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto end_IL_0012;
				case 9:
					break;
				}
				text = array[num3];
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0059
		int num = 3;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					break;
				case 8:
					return stringBuilder.ToString();
				case 2:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					FaW4iBhXW9mOM2fdASZb(stringBuilder, zOyOqAhKcRBARgjpDZa7(0x12A5FAC7 ^ 0x12A599F9));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					FaW4iBhXW9mOM2fdASZb(stringBuilder, VeqVg8hXBxZEBjiloIOs(VeqVg8hXBxZEBjiloIOs(base[num3].ToString(), zOyOqAhKcRBARgjpDZa7(-70007027 ^ -70002187), zOyOqAhKcRBARgjpDZa7(-1939377524 ^ -1939589258)), zOyOqAhKcRBARgjpDZa7(0x3C5338FF ^ 0x3C53275B), zOyOqAhKcRBARgjpDZa7(0xE1229CF ^ 0xE116FC7)));
					num2 = 7;
					continue;
				case 6:
					if (num3 > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 1:
				case 5:
					if (num3 >= ja82FQhXovevm32QbUWm(this))
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 3:
					stringBuilder = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			num3++;
			num = 5;
		}
	}

	[IteratorStateMachine(typeof(_003CToMvcListItems_003Ed__2))]
	public IEnumerable<SelectListItem> ToMvcListItems(bool addEmptyItem = false)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CToMvcListItems_003Ed__2(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__addEmptyItem = addEmptyItem
		};
	}

	public DropDownItemList()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YoAaUPhXbwHUE4uVHkht();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void JPa5hNhKsrt5FaasQVrg(object P_0)
	{
		((List<DropDownItem>)P_0).Clear();
	}

	internal static object zOyOqAhKcRBARgjpDZa7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xxU6NFhKz5p1tslkiFPV(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object E704DwhXFAdiIMlLiFcn(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static object VeqVg8hXBxZEBjiloIOs(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool L31u1rhKLaFevYuX338Q()
	{
		return J6HiW1hKYwL1aaLVdhDO == null;
	}

	internal static DropDownItemList gdXUIshKUQMS27GyGXYn()
	{
		return J6HiW1hKYwL1aaLVdhDO;
	}

	internal static object FaW4iBhXW9mOM2fdASZb(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int ja82FQhXovevm32QbUWm(object P_0)
	{
		return ((List<DropDownItem>)P_0).Count;
	}

	internal static void YoAaUPhXbwHUE4uVHkht()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

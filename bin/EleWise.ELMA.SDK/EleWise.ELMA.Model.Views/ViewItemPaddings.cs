using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemPaddings
{
	private static ViewItemPaddings hXjayionFp9jjhRSG8SA;

	[DefaultValue(null)]
	public int? Top { get; set; }

	[DefaultValue(null)]
	public int? Right { get; set; }

	[DefaultValue(null)]
	public int? Bottom { get; set; }

	[DefaultValue(null)]
	public int? Left { get; set; }

	public int Horizontal
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044, IL_0077
			int num = 1;
			int num2 = num;
			int? left = default(int?);
			int num3;
			while (true)
			{
				switch (num2)
				{
				case 1:
					left = Left;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = 0;
					break;
				default:
					if (left.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 3:
					left = Left;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					num3 = left.Value;
					break;
				}
				break;
			}
			return num3 + (Right.HasValue ? Right.Value : 0);
		}
	}

	public int Vertical
	{
		get
		{
			//Discarded unreachable code: IL_008c
			int num = 1;
			int num2 = num;
			int? top = default(int?);
			int num3;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!top.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						top = Top;
						num2 = 3;
					}
					continue;
				case 1:
					top = Top;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = 0;
					break;
				case 3:
					num3 = top.Value;
					break;
				}
				break;
			}
			return num3 + (Bottom.HasValue ? Bottom.Value : 0);
		}
	}

	public ViewItemPaddings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G7BhrvonoanVg0CFD1Q1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ViewItemPaddings(int? top, int? right, int? bottom, int? left)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Top = top;
		Right = right;
		Bottom = bottom;
		Left = left;
	}

	public ViewItemPaddings(int? vertical, int? horizontal)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Top = vertical;
		Bottom = vertical;
		Left = horizontal;
		Right = horizontal;
	}

	public ViewItemPaddings(int? all)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Top = all;
		Bottom = all;
		Left = all;
		Right = all;
	}

	public void Apply(ViewItemPaddings paddings)
	{
		//Discarded unreachable code: IL_010e
		int num = 14;
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (num3.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 4:
					if (!num3.HasValue)
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				case 9:
					if (num3.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				default:
					Top = paddings.Top;
					num2 = 6;
					continue;
				case 13:
					num3 = paddings.Top;
					num2 = 9;
					continue;
				case 10:
					Left = paddings.Left;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return;
				case 12:
					return;
				case 14:
					YJGwbConbvCDaGji5i6e(paddings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583622916));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 13;
					}
					continue;
				case 1:
					Right = paddings.Right;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					num3 = paddings.Right;
					num2 = 5;
					continue;
				case 11:
					goto end_IL_0012;
				case 8:
					num3 = paddings.Bottom;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (num3.HasValue)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					break;
				case 7:
					break;
				}
				num3 = paddings.Left;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			Bottom = paddings.Bottom;
			num = 7;
		}
	}

	internal static void G7BhrvonoanVg0CFD1Q1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bxkTdConB15owKU3R7Xm()
	{
		return hXjayionFp9jjhRSG8SA == null;
	}

	internal static ViewItemPaddings RWdoHyonWDdAZdfdoqri()
	{
		return hXjayionFp9jjhRSG8SA;
	}

	internal static void YJGwbConbvCDaGji5i6e(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}

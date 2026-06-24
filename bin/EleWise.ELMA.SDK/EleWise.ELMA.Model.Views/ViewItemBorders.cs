using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemBorders
{
	private static ViewItemBorders kRWVbQokw4QhWAgr6MQ5;

	[DefaultValue(null)]
	public int? Width { get; set; }

	[DefaultValue(null)]
	public ViewItemColor Color
	{
		[CompilerGenerated]
		get
		{
			return _003CColor_003Ek__BackingField;
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
					_003CColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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

	[DefaultValue(null)]
	public ViewItemBorder Top
	{
		[CompilerGenerated]
		get
		{
			return _003CTop_003Ek__BackingField;
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
					_003CTop_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public ViewItemBorder Right
	{
		[CompilerGenerated]
		get
		{
			return _003CRight_003Ek__BackingField;
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
					_003CRight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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

	[DefaultValue(null)]
	public ViewItemBorder Bottom
	{
		[CompilerGenerated]
		get
		{
			return _003CBottom_003Ek__BackingField;
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
					_003CBottom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public ViewItemBorder Left
	{
		[CompilerGenerated]
		get
		{
			return _003CLeft_003Ek__BackingField;
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
					_003CLeft_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

	public int GetHorizontalWidth()
	{
		return GetLeftWidth() + GetRightWidth();
	}

	public int GetVerticalWidth()
	{
		return GetTopWidth() + GetBottomWidth();
	}

	public int GetLeftWidth()
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_0088, IL_0097
		int num = 5;
		int? width = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 2:
					return width.Value;
				case 3:
					width = Left.Width;
					num = 7;
					break;
				case 5:
					if (Left == null)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 1:
					if (width.HasValue)
					{
						width = Width;
						num = 8;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (width.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 8:
					return width.Value;
				case 6:
					width = Left.Width;
					num = 2;
					break;
				case 4:
				case 9:
					width = Width;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public int GetRightWidth()
	{
		//Discarded unreachable code: IL_0045
		int num = 4;
		int num2 = num;
		int? width = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return width.Value;
			case 4:
				if (Right == null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 8:
				if (!width.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
				width = Width;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				width = Right.Width;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (!width.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				width = Right.Width;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
			case 3:
				width = Width;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return 0;
			case 1:
				return width.Value;
			}
		}
	}

	public int GetTopWidth()
	{
		//Discarded unreachable code: IL_00b2, IL_00dc, IL_00eb
		int num = 4;
		int? width = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (Top == null)
					{
						num2 = 3;
						break;
					}
					goto case 6;
				default:
					if (width.HasValue)
					{
						goto end_IL_0012;
					}
					num2 = 5;
					break;
				case 7:
					if (width.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 1;
				case 5:
					return 0;
				case 6:
					width = Top.Width;
					num2 = 7;
					break;
				case 8:
					return width.Value;
				case 2:
					width = Top.Width;
					num2 = 9;
					break;
				case 1:
				case 3:
					width = Width;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					return width.Value;
				}
				continue;
				end_IL_0012:
				break;
			}
			width = Width;
			num = 8;
		}
	}

	public int GetBottomWidth()
	{
		//Discarded unreachable code: IL_006f, IL_00e4, IL_00f3
		int num = 9;
		int num2 = num;
		int? width = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!width.HasValue)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 7;
					}
					break;
				}
				width = Width;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				width = Bottom.Width;
				num2 = 4;
				break;
			case 6:
				return width.Value;
			case 3:
			case 8:
				width = Width;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				if (Bottom == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 7:
				return 0;
			default:
				return width.Value;
			case 2:
				width = Bottom.Width;
				num2 = 6;
				break;
			case 4:
				if (width.HasValue)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			}
		}
	}

	public void Apply(ViewItemBorders borders)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00b0, IL_02f2, IL_0316, IL_0325, IL_037a
		int num = 11;
		int num2 = num;
		int? width = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				H0p3dLokMkeSRZ3jCOCF(Left, t2eCliokJ8dTvhVxVcwP(borders));
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 5;
				}
				break;
			case 19:
			case 27:
				Top.Apply((ViewItemBorder)PNbF8Uok0HJw1QhDxt3i(borders));
				num2 = 21;
				break;
			case 9:
				Width = borders.Width;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				width = borders.Width;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 7;
				}
				break;
			case 15:
				return;
			case 13:
				Left = new ViewItemBorder();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 16:
			case 18:
				if (PNbF8Uok0HJw1QhDxt3i(borders) == null)
				{
					num2 = 14;
					break;
				}
				goto case 5;
			case 8:
				if (Right == null)
				{
					num2 = 17;
					break;
				}
				goto case 12;
			case 7:
				if (width.HasValue)
				{
					num2 = 9;
					break;
				}
				goto default;
			case 12:
				Right.Apply((ViewItemBorder)UqnJDlokmVYtto4jU1YQ(borders));
				num2 = 6;
				break;
			case 14:
			case 21:
				if (UqnJDlokmVYtto4jU1YQ(borders) != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 2:
				if (Bottom != null)
				{
					num2 = 23;
					break;
				}
				goto case 24;
			case 5:
				if (Top != null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 19;
					}
					break;
				}
				goto case 20;
			case 22:
				Color = (ViewItemColor)pxhi13okxn8n3c3qjccu(nCbjyQok7fA1C0HueUrO(borders));
				num2 = 18;
				break;
			case 20:
				Top = new ViewItemBorder();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 27;
				}
				break;
			case 11:
				NxvC6XokAov3Yl2pY3vK(borders, l6wIZQokHv7GFnKwS5RD(-1633514411 ^ -1633627713));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 10;
				}
				break;
			case 3:
			case 4:
				if (t2eCliokJ8dTvhVxVcwP(borders) == null)
				{
					return;
				}
				num2 = 26;
				break;
			case 17:
				Right = new ViewItemBorder();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 11;
				}
				break;
			case 24:
				Bottom = new ViewItemBorder();
				num2 = 25;
				break;
			case 6:
				if (borders.Bottom == null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 26:
				if (Left == null)
				{
					num2 = 13;
					break;
				}
				goto case 1;
			default:
				if (nCbjyQok7fA1C0HueUrO(borders) == null)
				{
					num2 = 16;
					break;
				}
				goto case 22;
			case 23:
			case 25:
				H0p3dLokMkeSRZ3jCOCF(Bottom, jAvEY8oky9AtvWfDAPRV(borders));
				num2 = 3;
				break;
			}
		}
	}

	public ViewItemBorders()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MSdWAAok9ftx0kWfIAi4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool PeYvTIok4k17DEFmtbZo()
	{
		return kRWVbQokw4QhWAgr6MQ5 == null;
	}

	internal static ViewItemBorders XQL4pFok6UD2RRJheCAq()
	{
		return kRWVbQokw4QhWAgr6MQ5;
	}

	internal static object l6wIZQokHv7GFnKwS5RD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void NxvC6XokAov3Yl2pY3vK(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object nCbjyQok7fA1C0HueUrO(object P_0)
	{
		return ((ViewItemBorders)P_0).Color;
	}

	internal static object pxhi13okxn8n3c3qjccu(object P_0)
	{
		return ((ViewItemColor)P_0).Clone();
	}

	internal static object PNbF8Uok0HJw1QhDxt3i(object P_0)
	{
		return ((ViewItemBorders)P_0).Top;
	}

	internal static object UqnJDlokmVYtto4jU1YQ(object P_0)
	{
		return ((ViewItemBorders)P_0).Right;
	}

	internal static object jAvEY8oky9AtvWfDAPRV(object P_0)
	{
		return ((ViewItemBorders)P_0).Bottom;
	}

	internal static void H0p3dLokMkeSRZ3jCOCF(object P_0, object P_1)
	{
		((ViewItemBorder)P_0).Apply((ViewItemBorder)P_1);
	}

	internal static object t2eCliokJ8dTvhVxVcwP(object P_0)
	{
		return ((ViewItemBorders)P_0).Left;
	}

	internal static void MSdWAAok9ftx0kWfIAi4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

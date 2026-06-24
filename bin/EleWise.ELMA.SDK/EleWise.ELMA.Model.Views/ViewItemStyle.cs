using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemStyle
{
	private static ViewItemStyle IfysolonhLh2tGBrfuPH;

	[DefaultValue(null)]
	public ViewItemColor BackgroundColor
	{
		[CompilerGenerated]
		get
		{
			return _003CBackgroundColor_003Ek__BackingField;
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
					_003CBackgroundColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 0:
					return;
				case 1:
					_003CColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public ViewItemPaddings Padding
	{
		[CompilerGenerated]
		get
		{
			return _003CPadding_003Ek__BackingField;
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
					_003CPadding_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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
	public ViewItemBorders Borders
	{
		[CompilerGenerated]
		get
		{
			return _003CBorders_003Ek__BackingField;
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
					_003CBorders_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
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
	public ViewItemCornerRadius CornerRadius
	{
		[CompilerGenerated]
		get
		{
			return _003CCornerRadius_003Ek__BackingField;
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
					_003CCornerRadius_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public ViewItemFont Font
	{
		[CompilerGenerated]
		get
		{
			return _003CFont_003Ek__BackingField;
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
					_003CFont_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? LineHeight { get; set; }

	public static ViewItemStyle Merge(params ViewItemStyle[] styles)
	{
		//Discarded unreachable code: IL_00a6, IL_0107, IL_0116
		int num = 12;
		int num2 = num;
		ViewItemStyle viewItemStyle = default(ViewItemStyle);
		int num3 = default(int);
		ViewItemStyle[] array = default(ViewItemStyle[]);
		ViewItemStyle viewItemStyle2 = default(ViewItemStyle);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return styles[0];
			case 7:
				return viewItemStyle;
			case 8:
				return null;
			case 9:
				if (styles.Length != 1)
				{
					viewItemStyle = new ViewItemStyle();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 4;
					}
				}
				break;
			case 5:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				if (styles != null)
				{
					num2 = 11;
					break;
				}
				goto case 8;
			default:
				if (num3 >= array.Length)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 3:
				num3 = 0;
				num2 = 10;
				break;
			case 13:
				if (viewItemStyle2 != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 6:
				viewItemStyle2 = array[num3];
				num2 = 13;
				break;
			case 2:
				array = styles;
				num2 = 3;
				break;
			case 1:
				viewItemStyle.Apply(viewItemStyle2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 5;
				}
				break;
			case 11:
				if (styles.Length != 0)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	public void Apply(ViewItemStyle style)
	{
		//Discarded unreachable code: IL_01c0, IL_020f, IL_0222, IL_0231
		int num = 23;
		int? lineHeight = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 25:
					if (CornerRadius != null)
					{
						num2 = 17;
						continue;
					}
					goto case 7;
				case 26:
					wVlcZBonuDgjOjOqbNwm(Padding, xWSmQronZBQnXbwIu0fj(style));
					num2 = 16;
					continue;
				case 12:
					if (TK8v6EonSvXnQapOX8KK(style) != null)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 5;
				case 23:
					QWTGFtonQIjsCZgkLhgv(style, pZXAvConfTKx7TZ1hI7U(-87337865 ^ -87487893));
					num2 = 22;
					continue;
				case 10:
				case 14:
					if (style.Color == null)
					{
						num2 = 21;
						continue;
					}
					goto case 8;
				case 16:
					if (o34BaConIfiC6BCOcfUL(style) != null)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				case 22:
					if (mwdedeonCM0DvwPe4l2x(style) == null)
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 11:
				case 21:
					if (xWSmQronZBQnXbwIu0fj(style) != null)
					{
						num2 = 27;
						continue;
					}
					goto case 16;
				case 15:
					lineHeight = style.LineHeight;
					num = 24;
					break;
				case 7:
					CornerRadius = new ViewItemCornerRadius();
					num2 = 6;
					continue;
				case 9:
					Borders = new ViewItemBorders();
					num2 = 20;
					continue;
				case 19:
					LineHeight = style.LineHeight;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					Padding = new ViewItemPaddings();
					num2 = 26;
					continue;
				case 8:
					Color = (ViewItemColor)SQdwtronvLekRU521rEW(KSCHteon81ggW2395tQX(style));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					PqMT9jonReIYThxSOJFv(Font, faYTW4onik0DbhVJ8yMh(style));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 15;
					}
					continue;
				case 27:
					if (Padding == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 26;
				case 13:
					BackgroundColor = (ViewItemColor)SQdwtronvLekRU521rEW(mwdedeonCM0DvwPe4l2x(style));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					if (Borders == null)
					{
						num2 = 9;
						continue;
					}
					goto case 20;
				case 20:
					SAYhH3onVSo6FXn9cxUu(Borders, o34BaConIfiC6BCOcfUL(style));
					num2 = 12;
					continue;
				default:
					if (Font == null)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 18:
					return;
				case 4:
					Font = new ViewItemFont();
					num = 3;
					break;
				case 5:
					if (faYTW4onik0DbhVJ8yMh(style) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 6:
				case 17:
					CornerRadius.Apply((ViewItemCornerRadius)TK8v6EonSvXnQapOX8KK(style));
					num = 5;
					break;
				case 24:
					if (!lineHeight.HasValue)
					{
						return;
					}
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 19;
					}
					continue;
				}
				break;
			}
		}
	}

	public int GetHorizontalContentPadding()
	{
		//Discarded unreachable code: IL_002d, IL_003c, IL_0072
		int num = 2;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Borders != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			default:
				num3 = 0;
				break;
			case 1:
				num3 = RvItTyonqQfJGUyM1ID6(Borders);
				break;
			}
			break;
		}
		return num3 + ((Padding != null) ? RNob94onKPLP82Nty6Y0(Padding) : 0);
	}

	public int GetVerticalContentPadding()
	{
		//Discarded unreachable code: IL_002a
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				break;
			case 1:
				if (Borders == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = rv6973onXxwCvV5VUweq(Borders);
				break;
			}
			break;
		}
		return num3 + ((Padding != null) ? ghyRNWonT8ho11Xk2YU0(Padding) : 0);
	}

	public int GetLeftContentPadding()
	{
		//Discarded unreachable code: IL_002d, IL_003c, IL_004d
		int num = 2;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				break;
			case 2:
				if (Borders != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			case 1:
				num3 = KPTWDionklcbT6SwhnuW(Borders);
				break;
			}
			break;
		}
		return num3 + ((Padding != null && Padding.Left.HasValue) ? Padding.Left.Value : 0);
	}

	public int GetRightContentPadding()
	{
		//Discarded unreachable code: IL_0053, IL_005d, IL_006c
		int num = 2;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Borders != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				num3 = 0;
				break;
			case 1:
				num3 = oGMSl7onnWpSs7fSjlVD(Borders);
				break;
			}
			break;
		}
		return num3 + ((Padding != null && Padding.Right.HasValue) ? Padding.Right.Value : 0);
	}

	public int GetTopContentPadding()
	{
		//Discarded unreachable code: IL_004f
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Borders == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = Borders.GetTopWidth();
				break;
			default:
				num3 = 0;
				break;
			}
			break;
		}
		return num3 + ((Padding != null && Padding.Top.HasValue) ? Padding.Top.Value : 0);
	}

	public int GetBottomContentPadding()
	{
		//Discarded unreachable code: IL_004f
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Borders == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = Borders.GetRightWidth();
				break;
			default:
				num3 = 0;
				break;
			}
			break;
		}
		return num3 + ((Padding != null && Padding.Bottom.HasValue) ? Padding.Bottom.Value : 0);
	}

	public virtual void Reset()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Borders = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				Font = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				BackgroundColor = null;
				num2 = 2;
				break;
			case 2:
				Padding = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ViewItemStyle()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W5fw3VonOlYbXSmtAoal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool eFrYDponGAT8VHD2o8sB()
	{
		return IfysolonhLh2tGBrfuPH == null;
	}

	internal static ViewItemStyle k11xWqonE7IRgdy4W4uR()
	{
		return IfysolonhLh2tGBrfuPH;
	}

	internal static object pZXAvConfTKx7TZ1hI7U(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void QWTGFtonQIjsCZgkLhgv(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object mwdedeonCM0DvwPe4l2x(object P_0)
	{
		return ((ViewItemStyle)P_0).BackgroundColor;
	}

	internal static object SQdwtronvLekRU521rEW(object P_0)
	{
		return ((ViewItemColor)P_0).Clone();
	}

	internal static object KSCHteon81ggW2395tQX(object P_0)
	{
		return ((ViewItemStyle)P_0).Color;
	}

	internal static object xWSmQronZBQnXbwIu0fj(object P_0)
	{
		return ((ViewItemStyle)P_0).Padding;
	}

	internal static void wVlcZBonuDgjOjOqbNwm(object P_0, object P_1)
	{
		((ViewItemPaddings)P_0).Apply((ViewItemPaddings)P_1);
	}

	internal static object o34BaConIfiC6BCOcfUL(object P_0)
	{
		return ((ViewItemStyle)P_0).Borders;
	}

	internal static void SAYhH3onVSo6FXn9cxUu(object P_0, object P_1)
	{
		((ViewItemBorders)P_0).Apply((ViewItemBorders)P_1);
	}

	internal static object TK8v6EonSvXnQapOX8KK(object P_0)
	{
		return ((ViewItemStyle)P_0).CornerRadius;
	}

	internal static object faYTW4onik0DbhVJ8yMh(object P_0)
	{
		return ((ViewItemStyle)P_0).Font;
	}

	internal static void PqMT9jonReIYThxSOJFv(object P_0, object P_1)
	{
		((ViewItemFont)P_0).Apply((ViewItemFont)P_1);
	}

	internal static int RvItTyonqQfJGUyM1ID6(object P_0)
	{
		return ((ViewItemBorders)P_0).GetHorizontalWidth();
	}

	internal static int RNob94onKPLP82Nty6Y0(object P_0)
	{
		return ((ViewItemPaddings)P_0).Horizontal;
	}

	internal static int rv6973onXxwCvV5VUweq(object P_0)
	{
		return ((ViewItemBorders)P_0).GetVerticalWidth();
	}

	internal static int ghyRNWonT8ho11Xk2YU0(object P_0)
	{
		return ((ViewItemPaddings)P_0).Vertical;
	}

	internal static int KPTWDionklcbT6SwhnuW(object P_0)
	{
		return ((ViewItemBorders)P_0).GetLeftWidth();
	}

	internal static int oGMSl7onnWpSs7fSjlVD(object P_0)
	{
		return ((ViewItemBorders)P_0).GetRightWidth();
	}

	internal static void W5fw3VonOlYbXSmtAoal()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

using System.Drawing;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public class ExcelStylesheet
{
	internal static ExcelStylesheet wOYHWdEEDCvx3f8oqTxQ;

	public IExcelStyle CommonStyle
	{
		[CompilerGenerated]
		get
		{
			return _003CCommonStyle_003Ek__BackingField;
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
					_003CCommonStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IExcelStyle HeaderStyle
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderStyle_003Ek__BackingField;
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
					_003CHeaderStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IExcelStyle MainHeaderStyle
	{
		[CompilerGenerated]
		get
		{
			return _003CMainHeaderStyle_003Ek__BackingField;
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
					_003CMainHeaderStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExcelStylesheet()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		murhVwEE43qnc8nIuaG6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				HeaderStyle = new ExcelStyle
				{
					BackColor = buV76qEE6pEyOp6hrMP9(83, 141, 213),
					FontColor = Color.White,
					FontBold = true
				};
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			default:
				MainHeaderStyle = new ExcelStyle
				{
					BackColor = buV76qEE6pEyOp6hrMP9(54, 96, 146),
					FontColor = bO9AXGEEHHRUAhDE3JF8(),
					FontBold = true,
					FontSize = 14
				};
				num = 2;
				break;
			}
		}
	}

	internal static void murhVwEE43qnc8nIuaG6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Color buV76qEE6pEyOp6hrMP9(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static Color bO9AXGEEHHRUAhDE3JF8()
	{
		return Color.White;
	}

	internal static bool CwPKUAEEt7i4NUex2UOS()
	{
		return wOYHWdEEDCvx3f8oqTxQ == null;
	}

	internal static ExcelStylesheet jXb4riEEwtRhVVONjTDI()
	{
		return wOYHWdEEDCvx3f8oqTxQ;
	}
}

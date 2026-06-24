using EleWise.ELMA.Files.DTO.Managers;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views.Validation;

public static class ViewNameValidator
{
	private static bool _isRazorEditing;

	private static ViewNameValidator UCoIsDoD7LH6IsANVkCQ;

	public static string ValidateViewName(string viewNamePrefix, string viewName, bool isProperty = false)
	{
		return (string)oqasXfoDml3XS4cln3RU(viewNamePrefix, viewName, isProperty, Locator.GetService<IWebApplicationDTOManager>());
	}

	public static string ValidateViewName(string viewNamePrefix, string viewName, bool isProperty, IWebApplicationDTOManager webApplicationDTOManager)
	{
		//Discarded unreachable code: IL_00ee, IL_00fd, IL_0129, IL_0138, IL_0148
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (sq1frUoDygus0XWBX9C3(viewName))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 2;
						}
						break;
					}
					if (_isRazorEditing)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 4;
						}
						break;
					}
					if (!yd9ilToDMhfn0rjU10ga(viewName, viewNamePrefix))
					{
						num2 = 8;
						break;
					}
					goto case 3;
				case 2:
					if (spKhxZoDJHoBIvUwCkLK(webApplicationDTOManager, viewName, isProperty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 7:
					return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957698322));
				case 9:
					return (string)L51MZKoDdEyI1HY5khti(VJhHsdoD9JVE0Xf7oPFD(-538519530 ^ -538659556));
				case 5:
					return null;
				default:
					return null;
				case 1:
				case 8:
					if (!yd9ilToDMhfn0rjU10ga(viewName, viewNamePrefix))
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 3:
					if (webApplicationDTOManager == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 4:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public static void IsRazorEditing(bool isRazorEditing)
	{
		_isRazorEditing = isRazorEditing;
	}

	internal static object oqasXfoDml3XS4cln3RU(object P_0, object P_1, bool isProperty, object P_3)
	{
		return ValidateViewName((string)P_0, (string)P_1, isProperty, (IWebApplicationDTOManager)P_3);
	}

	internal static bool zBoSKwoDxIlqwfmFsxxU()
	{
		return UCoIsDoD7LH6IsANVkCQ == null;
	}

	internal static ViewNameValidator QuRcn4oD0anQIFZP6gtZ()
	{
		return UCoIsDoD7LH6IsANVkCQ;
	}

	internal static bool sq1frUoDygus0XWBX9C3(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool yd9ilToDMhfn0rjU10ga(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool spKhxZoDJHoBIvUwCkLK(object P_0, object P_1, bool isProperty)
	{
		return ((IWebApplicationDTOManager)P_0).CheckViewExists((string)P_1, isProperty);
	}

	internal static object VJhHsdoD9JVE0Xf7oPFD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L51MZKoDdEyI1HY5khti(object P_0)
	{
		return SR.T((string)P_0);
	}
}

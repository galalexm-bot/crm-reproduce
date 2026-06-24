using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

public class UserActions : DefaultEntityActions
{
	[DisplayName(typeof(__Resources_UserActions), "P_Block_DisplayName")]
	[Image(typeof(UserActions), "lock", 16, ImageFormatType.IconPack, false)]
	[Uid("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
	[Description(typeof(__Resources_UserActions), "P_Block_Description")]
	public const string Block = "baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05";

	private static Guid _blockGuid;

	[Description(typeof(__Resources_UserActions), "P_UnBlock_Description")]
	[Image(typeof(UserActions), "unlock", 16, ImageFormatType.IconPack, false)]
	[Uid("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
	[DisplayName(typeof(__Resources_UserActions), "P_UnBlock_DisplayName")]
	public const string UnBlock = "90387e19-8ba0-4e47-a7b3-3d690bbe0431";

	private static Guid _unBlockGuid;

	[DisplayName(typeof(__Resources_UserActions), "P_PasswordReset_DisplayName")]
	[Uid("0c15db7e-0291-4d60-b225-35ae01eaa90f")]
	public const string PasswordReset = "0c15db7e-0291-4d60-b225-35ae01eaa90f";

	private static Guid _passwordResetGuid;

	[Uid("0e6e1881-1e4c-48c9-8a6b-724afd97566a")]
	[DisplayName(typeof(__Resources_UserActions), "P_Edit_DisplayName")]
	public const string Edit = "0e6e1881-1e4c-48c9-8a6b-724afd97566a";

	private static Guid _editGuid;

	[Image(typeof(UserActions), "lock", 16, ImageFormatType.IconPack, false)]
	[DisplayName(typeof(__Resources_UserActions), "P_LogonBlock_DisplayName")]
	[Uid("cc548a2c-afe3-4810-bf18-98b038beb625")]
	public const string LogonBlock = "cc548a2c-afe3-4810-bf18-98b038beb625";

	private static Guid _logonBlockGuid;

	private static UserActions C8vJtbccg1TgTQHcBsp;

	public static Guid BlockGuid => _blockGuid;

	public static Guid UnBlockGuid => _unBlockGuid;

	public static Guid PasswordResetGuid => _passwordResetGuid;

	public static Guid EditGuid => _editGuid;

	public static Guid LogonBlockGuid => _logonBlockGuid;

	protected UserActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dHmgm5c0ysFxtQCYAwe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserActions()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_passwordResetGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429500015 ^ -1429529511));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					_editGuid = new Guid((string)YCBww3cEPkiNeKhvR3N(0x74C28149 ^ 0x74C2155D));
					num2 = 6;
					continue;
				case 6:
					break;
				case 3:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
					num2 = 2;
					continue;
				case 5:
					_unBlockGuid = new Guid((string)YCBww3cEPkiNeKhvR3N(0x71BC7C31 ^ 0x71BCEF4D));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_blockGuid = new Guid((string)YCBww3cEPkiNeKhvR3N(0x2CFDCC80 ^ 0x2CFD5FB0));
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			_logonBlockGuid = new Guid((string)YCBww3cEPkiNeKhvR3N(-737960346 ^ -737998330));
			num = 4;
		}
	}

	internal static void dHmgm5c0ysFxtQCYAwe()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool Ssluu7cGLEtK0Bfp8P6()
	{
		return C8vJtbccg1TgTQHcBsp == null;
	}

	internal static UserActions H4Z9gscFxBKrmqfPXxT()
	{
		return C8vJtbccg1TgTQHcBsp;
	}

	internal static object YCBww3cEPkiNeKhvR3N(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}

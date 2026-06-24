using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.Security";

	public const string APIAdminPermissionId = "A69D083E-F2E9-4E86-AF71-71A1E4BE91B0";

	public static readonly Permission APIAdminPermission;

	public const string UserViewPermissionId = "DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC";

	public static readonly Permission UserViewPermission;

	public const string UserManagmentPermissionId = "2C44BA05-91A6-49E4-89C1-84AC5B371B7F";

	public static readonly Permission UserManagmentPermission;

	public const string AccessManagmentPermissionId = "0B298062-9DE5-46E5-8D1D-C46B3680809A";

	public static readonly Permission AccessManagmentPermission;

	public const string DenyEditPersonalDataPermissionId = "90A5014F-1DB1-4BF7-9DC3-AA059114BCB0";

	public static readonly Permission DenyEditPersonalDataPermission;

	public const string DenyPasswordResetPermissionId = "2CCAB1C7-B2A5-4C74-A4BB-E607FC939BDE";

	public static readonly Permission DenyPasswordResetPermission;

	public const string ReplacementUsePermissionId = "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C";

	public static readonly Permission ReplacementUsePermission;

	public const string ReplacementOwnPermissionId = "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4";

	public static readonly Permission ReplacementOwnPermission;

	public const string AbsenceUsePermissionId = "22581049-E783-4F60-BF3F-FAC25C433E30";

	public static readonly Permission AbsenceUsePermission;

	public const string AbsenceOwnPermissionId = "C94736CF-EE73-4635-B1CB-C7E6BC315086";

	public static readonly Permission AbsenceOwnPermission;

	public const string TrustedDevicesManagementPermissionId = "C34E0E87-C1FB-4407-9802-ABE6E9BC7B7D";

	public static readonly Permission TrustedDevicesManagementPermission;

	public const string AbsenceViewPermissionId = "EC801EB0-3E6C-41F5-BAA0-A780431CCBEF";

	public static readonly Permission AbsenceViewPermission;

	internal static PermissionProvider i3Ry4NlN3gYBksOWhgd;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[12]
		{
			UserManagmentPermission, UserViewPermission, AccessManagmentPermission, APIAdminPermission, DenyEditPersonalDataPermission, DenyPasswordResetPermission, AbsenceUsePermission, AbsenceOwnPermission, ReplacementUsePermission, ReplacementOwnPermission,
			TrustedDevicesManagementPermission, AbsenceViewPermission
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[8]
		{
			new PermissionStereotype(new Permission[1] { CommonPermissions.DesignerAccessPermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[1] { CommonPermissions.DesignerAccessPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[7] { APIAdminPermission, UserManagmentPermission, UserViewPermission, AccessManagmentPermission, AbsenceUsePermission, ReplacementUsePermission, TrustedDevicesManagementPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { UserViewPermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[2] { UserViewPermission, UserManagmentPermission }, SecurityConstants.UsersManagementGroupDescriptor),
			new PermissionStereotype(new Permission[1] { CommonPermissions.AdminPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { TrustedDevicesManagementPermission }, SecurityConstants.AllUsersGroupDescriptor),
			new PermissionStereotype(new Permission[1] { AbsenceViewPermission }, SecurityConstants.AdminGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{
				UserManagmentPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-930147978 ^ -930137024)
			},
			{
				UserViewPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x487E82CC ^ 0x487EAFA4)
			},
			{
				AccessManagmentPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119516520)
			},
			{
				APIAdminPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-236222459 ^ -236214845)
			},
			{
				DenyEditPersonalDataPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x1869E9AC)
			},
			{
				DenyPasswordResetPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x11C59687 ^ 0x11C5B8A9)
			},
			{
				AbsenceUsePermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6547C338 ^ 0x6547ED50)
			},
			{
				ReplacementUsePermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B479135)
			},
			{
				TrustedDevicesManagementPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E673666)
			},
			{
				AbsenceViewPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAB8A90)
			}
		};
	}

	public PermissionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z81xcHlBQX74Ne64DoG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PermissionProvider()
	{
		int num = 12;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					UserManagmentPermission = (PermissionBuilder)KD2PtJlHF5Wvx7YmRCi(T966ePlLlXuw8Zfiret(ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(-737960346 ^ -737956292), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x1B47BFA1 ^ 0x1B478F07)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-730071140 ^ -730083292))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51BB29A6 ^ 0x51BB34CE)), new Permission[1] { UserViewPermission });
					num2 = 4;
					continue;
				case 13:
					AbsenceUsePermission = (Permission)G2ykVWlj4A2TYxbKDBY(KD2PtJlHF5Wvx7YmRCi(((PermissionBuilder)ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(0x4A799728 ^ 0x4A79A492), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-163225536 ^ -163228602)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-724676315 ^ -724664675)))).ModuleUid((string)SWWxSSluYqhAS6OHiCM(-2068904634 ^ -2068899794)), new Permission[1] { UserViewPermission }));
					num2 = 3;
					continue;
				case 8:
					DenyEditPersonalDataPermission = (PermissionBuilder)T966ePlLlXuw8Zfiret(Permission.Create((string)SWWxSSluYqhAS6OHiCM(0xA5DAE86 ^ 0xA5D9FFA), SR.M((string)SWWxSSluYqhAS6OHiCM(-959661060 ^ -959673804)), "", (string)lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x432996D0 ^ 0x4329B968))), SWWxSSluYqhAS6OHiCM(0x271B34E4 ^ 0x271B298C));
					num = 7;
					break;
				case 2:
					UserViewPermission = (PermissionBuilder)T966ePlLlXuw8Zfiret(Permission.Create((string)SWWxSSluYqhAS6OHiCM(-76932334 ^ -76925748), (string)lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-177725793 ^ -177721675)), "", (string)lhoOVylmUaobfKIDq4v(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D16B93))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E6705C6));
					num2 = 9;
					continue;
				case 11:
					APIAdminPermission = (Permission)G2ykVWlj4A2TYxbKDBY(T966ePlLlXuw8Zfiret(ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(-2068904634 ^ -2068895112), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x6A336151 ^ 0x6A334EDB)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-1378061210 ^ -1378067490))), SWWxSSluYqhAS6OHiCM(0xC66FB14 ^ 0xC66E67C)));
					num = 2;
					break;
				case 10:
					AbsenceViewPermission = (Permission)G2ykVWlj4A2TYxbKDBY(T966ePlLlXuw8Zfiret(ylC0HDleoG0qiOgFrMu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBFC742), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(--1130812004 ^ 0x4366E7B4)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-177725793 ^ -177721049))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698596375)));
					num2 = 6;
					continue;
				case 5:
					TrustedDevicesManagementPermission = (Permission)G2ykVWlj4A2TYxbKDBY(((PermissionBuilder)ylC0HDleoG0qiOgFrMu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC66CFC6), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x3B1D6430 ^ 0x3B1D512E)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x5EE4A7B ^ 0x5EE65C3)))).ModuleUid((string)SWWxSSluYqhAS6OHiCM(0x3E79A885 ^ 0x3E79B5ED)));
					num = 10;
					break;
				default:
					ReplacementUsePermission = (Permission)G2ykVWlj4A2TYxbKDBY(((PermissionBuilder)T966ePlLlXuw8Zfiret(ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(-1378061210 ^ -1378072896), lhoOVylmUaobfKIDq4v(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E78C752)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0xD946FDB ^ 0xD944063))), SWWxSSluYqhAS6OHiCM(0x487E82CC ^ 0x487E9FA4))).Dependencies(new Permission[1] { UserViewPermission }));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					ReplacementOwnPermission = ((PermissionBuilder)ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(0x71CDF2F ^ 0x71CEC03), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-714706387 ^ -714718891)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0x3B1D6430 ^ 0x3B1D4B88)))).ModuleUid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580399963));
					num2 = 13;
					continue;
				case 6:
					return;
				case 12:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
					num2 = 11;
					continue;
				case 4:
					AccessManagmentPermission = ((PermissionBuilder)ylC0HDleoG0qiOgFrMu(SWWxSSluYqhAS6OHiCM(0xA4E904F ^ 0xA4EA0A7), lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(0xCDF201B ^ 0xCDF112F)), "", lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-1518425080 ^ -1518435408)))).ModuleUid((string)SWWxSSluYqhAS6OHiCM(0x5FD42272 ^ 0x5FD43F1A)).Dependencies(UserViewPermission);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					DenyPasswordResetPermission = (PermissionBuilder)T966ePlLlXuw8Zfiret(ylC0HDleoG0qiOgFrMu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A335345), SR.M((string)SWWxSSluYqhAS6OHiCM(-230994601 ^ -230981833)), "", SR.M((string)SWWxSSluYqhAS6OHiCM(0x5FD42272 ^ 0x5FD40DCA))), SWWxSSluYqhAS6OHiCM(0x11C59687 ^ 0x11C58BEF));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					AbsenceOwnPermission = (PermissionBuilder)T966ePlLlXuw8Zfiret(Permission.Create(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x2174DEF5), (string)lhoOVylmUaobfKIDq4v(SWWxSSluYqhAS6OHiCM(-736288531 ^ -736291741)), "", SR.M((string)SWWxSSluYqhAS6OHiCM(-1278809262 ^ -1278819094))), SWWxSSluYqhAS6OHiCM(0x11C59687 ^ 0x11C58BEF));
					num = 5;
					break;
				}
				break;
			}
		}
	}

	internal static void z81xcHlBQX74Ne64DoG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool V0BBvXlZQxvIxajhflU()
	{
		return i3Ry4NlN3gYBksOWhgd == null;
	}

	internal static PermissionProvider EPwLc6lxeVtxIXSy3Rs()
	{
		return i3Ry4NlN3gYBksOWhgd;
	}

	internal static object SWWxSSluYqhAS6OHiCM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lhoOVylmUaobfKIDq4v(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object ylC0HDleoG0qiOgFrMu(object P_0, object P_1, object P_2, object P_3)
	{
		return Permission.Create((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static object T966ePlLlXuw8Zfiret(object P_0, object P_1)
	{
		return ((PermissionBuilder)P_0).ModuleUid((string)P_1);
	}

	internal static object G2ykVWlj4A2TYxbKDBY(object P_0)
	{
		return (Permission)(PermissionBuilder)P_0;
	}

	internal static object KD2PtJlHF5Wvx7YmRCi(object P_0, object P_1)
	{
		return ((PermissionBuilder)P_0).Dependencies((Permission[])P_1);
	}
}

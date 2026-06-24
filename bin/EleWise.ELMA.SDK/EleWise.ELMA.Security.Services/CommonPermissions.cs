using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Component]
public class CommonPermissions : IPermissionProvider
{
	public const string CreateId = "FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255";

	public const string EditId = "DA114EB6-12E0-4AAF-B462-F5BBFC177FBD";

	public const string ViewId = "2207FB22-04C9-42E5-B04F-F64144B88925";

	public const string GrantAccessId = "F883B9C0-55C6-4178-BF57-37315F723205";

	public const string DeleteId = "7D4D7B30-28BC-4A96-9DA9-A72654272386";

	public const string AdminPermissionId = "7B1CC80C-1AD0-404A-8564-06DE4B269469";

	public static readonly Permission AdminPermission;

	public const string DesignerAccessPermissionId = "8DD067A9-9DDF-4FE7-9241-6989B59A6AEA";

	public static readonly Permission DesignerAccessPermission;

	public static readonly Permission Create;

	public static readonly Permission Edit;

	public static readonly Permission View;

	public static readonly Permission GrantAccess;

	public static readonly Permission Delete;

	public const string TranslateSystemId = "691B08C2-088E-4E4A-BE73-40F68D4761EA";

	public static readonly Permission TranslateSystemPermission;

	internal static CommonPermissions prEtllBsooRuTj1v7SSA;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[7] { Create, Edit, GrantAccess, View, AdminPermission, DesignerAccessPermission, TranslateSystemPermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionStereotype>.Instance;
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{
				Create,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6177CA)
			},
			{
				Edit,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A76ED3F)
			},
			{
				GrantAccess,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC03D24)
			},
			{
				View,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3F379)
			},
			{
				AdminPermission,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E93DB)
			},
			{
				DesignerAccessPermission,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812121442)
			},
			{
				TranslateSystemPermission,
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867139951)
			}
		};
	}

	public CommonPermissions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ldDFqLBsGYYjUL10essN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CommonPermissions()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				ldDFqLBsGYYjUL10essN();
				num2 = 3;
				break;
			case 6:
				return;
			case 8:
				Create = new Permission((string)ReQoaOBsErCBguy0i1Hn(-138018305 ^ -137921113), (string)bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-309639236 ^ -309708008)), "", (string)bFcreaBsfrGKamW2tuOv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A45FE6)), null, null, PermissionType.EntityType);
				num2 = 5;
				break;
			case 5:
				Edit = new Permission((string)ReQoaOBsErCBguy0i1Hn(0x638095EB ^ 0x6381E92D), (string)bFcreaBsfrGKamW2tuOv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105137424)), "", SR.M((string)ReQoaOBsErCBguy0i1Hn(-889460160 ^ -889547016)), null, null, PermissionType.Instance);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				TranslateSystemPermission = ((PermissionBuilder)k51thjBsQr7FJYQR6iaR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42654C69), bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(0x26FFCB59 ^ 0x26FEB5EF)), bFcreaBsfrGKamW2tuOv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822844678)), bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-138018305 ^ -138006771)))).ModuleUid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475823159));
				num2 = 6;
				break;
			case 2:
				GrantAccess = new Permission((string)ReQoaOBsErCBguy0i1Hn(0x4DC2B14D ^ 0x4DC3CCDF), (string)bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-3333094 ^ -3384892)), "", SR.M((string)ReQoaOBsErCBguy0i1Hn(0x103FE975 ^ 0x103E95CD)), null, null, PermissionType.Instance);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				View = new Permission(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637F54A9), SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16702567)), "", (string)bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-1334993905 ^ -1335041865)), null, null, PermissionType.Instance);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			default:
				Delete = new Permission((string)ReQoaOBsErCBguy0i1Hn(-643786247 ^ -643700749), (string)bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(--1360331293 ^ 0x51147C4B)), "", (string)bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-2106517564 ^ -2106561668)), null, null, PermissionType.Instance);
				num2 = 7;
				break;
			case 3:
				AdminPermission = (Permission)zXsIBBBsCQZijtScpJo0(k51thjBsQr7FJYQR6iaR(ReQoaOBsErCBguy0i1Hn(0x4EA5403C ^ 0x4EA43B06), bFcreaBsfrGKamW2tuOv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4D00AF)), "", bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-521266112 ^ -521260366))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 9;
				}
				break;
			case 9:
				DesignerAccessPermission = (Permission)zXsIBBBsCQZijtScpJo0(k51thjBsQr7FJYQR6iaR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459515235), bFcreaBsfrGKamW2tuOv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146562261)), "", bFcreaBsfrGKamW2tuOv(ReQoaOBsErCBguy0i1Hn(-218496594 ^ -218399340))));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	internal static void ldDFqLBsGYYjUL10essN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DojjkpBsbcUvKYnf8gHY()
	{
		return prEtllBsooRuTj1v7SSA == null;
	}

	internal static CommonPermissions s0n285BshjyAJqRve2Sb()
	{
		return prEtllBsooRuTj1v7SSA;
	}

	internal static object ReQoaOBsErCBguy0i1Hn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bFcreaBsfrGKamW2tuOv(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object k51thjBsQr7FJYQR6iaR(object P_0, object P_1, object P_2, object P_3)
	{
		return Permission.Create((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static object zXsIBBBsCQZijtScpJo0(object P_0)
	{
		return (Permission)(PermissionBuilder)P_0;
	}
}

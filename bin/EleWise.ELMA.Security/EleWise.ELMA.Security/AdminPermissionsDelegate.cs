using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
internal class AdminPermissionsDelegate : IPermissionsDelegate
{
	private static AdminPermissionsDelegate ibnFKS5qp2Z6jH6L7nA;

	public ISecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
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

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_009c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(permission != null))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 3:
				return ((Array)zW4weU5FFj4XhKlTFUq(permission)).Length != 0;
			case 1:
			case 4:
				return false;
			default:
				if (permission.AdminPermissions == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_007d, IL_00f1, IL_016e, IL_01e8, IL_01fb
		int num = 13;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		bool? orDefault = default(bool?);
		string name = default(string);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 12;
					continue;
				case 6:
					return orDefault.Value;
				case 5:
					num2 = 4;
					continue;
				case 1:
					_003C_003Ec__DisplayClass5_.user = user;
					num2 = 2;
					continue;
				case 7:
					break;
				case 2:
					_003C_003Ec__DisplayClass5_.target = target;
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					if (!orDefault.HasValue)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 12:
					_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					return false;
				case 10:
					if (!CanCheckPermissions(null, permission))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					name = string.Concat(TkQJku50OPNrw2lf8jN(0x6AA79E0 ^ 0x6AA6A3A), (_003C_003Ec__DisplayClass5_.user != null) ? ptQtrt5EFP3w3ki1OYn(_003C_003Ec__DisplayClass5_.user) : TkQJku50OPNrw2lf8jN(-1718905545 ^ -1718910693), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1278809262 ^ -1278804118), kmvoDL5DwkdasNQ8ndY(permission, null) ? i0SZHe5MtAsQyYotnSL(permission).ToString() : TkQJku50OPNrw2lf8jN(-1278809262 ^ -1278804098), TkQJku50OPNrw2lf8jN(-1642017152 ^ -1642014024), (_003C_003Ec__DisplayClass5_.target != null) ? _003C_003Ec__DisplayClass5_.target.GetHashCode().ToString() : TkQJku50OPNrw2lf8jN(--553267277 ^ 0x20FA2461));
					num2 = 7;
					continue;
				case 4:
					try
					{
						ContextVars.Set(name, (bool?)false);
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							}
							result = ((IEnumerable<Permission>)zW4weU5FFj4XhKlTFUq(permission)).Any(_003C_003Ec__DisplayClass5_._003CHasPermission_003Eb__0);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						ContextVars.Set<bool?>(name, null);
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 3:
					return result;
				case 8:
					if (!skipAdmin)
					{
						num2 = 10;
						continue;
					}
					goto case 11;
				default:
					return false;
				}
				break;
			}
			orDefault = ContextVars.GetOrDefault<bool?>(name);
			num = 9;
		}
	}

	public AdminPermissionsDelegate()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P2eYlF5spxVMjmwXLQ2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QHVDSx5cShrngvsitcG()
	{
		return ibnFKS5qp2Z6jH6L7nA == null;
	}

	internal static AdminPermissionsDelegate N0CnNl5GDKUJiCCRYTe()
	{
		return ibnFKS5qp2Z6jH6L7nA;
	}

	internal static object zW4weU5FFj4XhKlTFUq(object P_0)
	{
		return ((Permission)P_0).AdminPermissions;
	}

	internal static object TkQJku50OPNrw2lf8jN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ptQtrt5EFP3w3ki1OYn(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool kmvoDL5DwkdasNQ8ndY(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static Guid i0SZHe5MtAsQyYotnSL(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static void P2eYlF5spxVMjmwXLQ2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

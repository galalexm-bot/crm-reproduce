using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Scope = ServiceScope.Shell)]
public class PermissionTypeRoleService : IPermissionTypeRoleService
{
	private readonly Func<IEnumerable<IPermissionRoleTypeProvider>> permissionRoleTypeProviders;

	internal static PermissionTypeRoleService sbtsSQla6TcGxQfKpMQ;

	public PermissionTypeRoleService(Func<IEnumerable<IPermissionRoleTypeProvider>> permissionRoleTypeProviders)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.permissionRoleTypeProviders = permissionRoleTypeProviders;
	}

	public IEnumerable<PermissionRoleType> All()
	{
		return permissionRoleTypeProviders().SelectMany((IPermissionRoleTypeProvider p) => p.GetRoleTypes());
	}

	public PermissionRoleType Get(Guid id)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return All().FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGet_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass3_.id = id;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionRoleType Load(Guid id)
	{
		//Discarded unreachable code: IL_0092, IL_00a1
		int num = 3;
		int num2 = num;
		PermissionRoleType permissionRoleType = default(PermissionRoleType);
		while (true)
		{
			switch (num2)
			{
			case 3:
				permissionRoleType = Get(id);
				num2 = 2;
				break;
			case 2:
				if (permissionRoleType != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				throw new ArgumentException((string)CxIlUylPlZnRNZnA6Qg(nSXR8Sl2COGCkHwiIW9(0xFD0849E ^ 0xFD0B164), new object[1] { id }));
			default:
				return permissionRoleType;
			}
		}
	}

	public IEnumerable<Tuple<Permission, PermissionRoleType[]>> GetPermissionRoles(Type type)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.type = type;
		return (from p in permissionRoleTypeProviders().SelectMany((IPermissionRoleTypeProvider s) => s.GetTypePermissionRoleStereotypes())
			where _003C_003Ec__DisplayClass5_0.VNpldbp78hUHS2YQ382h(p).IsAssignableFrom(CS_0024_003C_003E8__locals0.type)
			group p by (Permission)_003C_003Ec.BjP09Dp7DHpSmclkEqas(p) into g
			select new Tuple<Permission, PermissionRoleType[]>(g.Key, g.SelectMany((PermissionRoleTypeStereotype v) => v.RoleTypes).Distinct().ToArray())).ToList();
	}

	internal static bool jmaxqKlRf52eAtqevB6()
	{
		return sbtsSQla6TcGxQfKpMQ == null;
	}

	internal static PermissionTypeRoleService LVp3nOlwtMBrW6qFG5s()
	{
		return sbtsSQla6TcGxQfKpMQ;
	}

	internal static object nSXR8Sl2COGCkHwiIW9(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CxIlUylPlZnRNZnA6Qg(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}
}

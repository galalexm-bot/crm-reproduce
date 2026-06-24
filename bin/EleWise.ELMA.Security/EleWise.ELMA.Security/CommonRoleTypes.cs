using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
public class CommonRoleTypes : IPermissionRoleTypeProvider
{
	public static readonly PermissionRoleType AllUsers;

	public static readonly PermissionRoleType User;

	public static readonly PermissionRoleType Group;

	public static readonly PermissionRoleType OrganizationItem;

	public static readonly PermissionRoleType Author;

	public static readonly PermissionRoleType Responsible;

	public static readonly PermissionRoleType ParticipantWork;

	public static readonly PermissionRoleType Informs;

	public static readonly PermissionRoleType Property;

	internal static CommonRoleTypes AT0vc0W9yY825d02QeM;

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleTypeStereotype>.Instance;
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return new PermissionRoleType[6] { AllUsers, Group, OrganizationItem, User, Author, Property };
	}

	public List<string> LocalizedItemNames()
	{
		return new List<string>();
	}

	public CommonRoleTypes()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		drgsJ8Wz1DAqdmUIsZM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CommonRoleTypes()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Property = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(-2104667969 ^ -2104659125)), (string)gdRJGGXkpkPybMvkrNQ(0x62C4BCE8 ^ 0x62C498A8), InterfaceActivator.TypeOf<IPropertyMetadata>(), delegate(dynamic e)
					{
						//Discarded unreachable code: IL_0094, IL_00a3
						int num3 = 3;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 3:
								if (_003C_003Eo__13._003C_003Ep__10 != null)
								{
									num4 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
									{
										num4 = 2;
									}
									break;
								}
								goto case 1;
							case 1:
								_003C_003Eo__13._003C_003Ep__10 = CallSite<Func<CallSite, object, Guid>>.Create((CallSiteBinder)_003C_003Ec.CkWJG6pnGboIiHlGyBcq(CSharpBinderFlags.ConvertExplicit, typeof(Guid), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle)));
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
								{
									num4 = 0;
								}
								break;
							default:
							{
								Func<CallSite, object, Guid> target = _003C_003Eo__13._003C_003Ep__10.Target;
								CallSite<Func<CallSite, object, Guid>> _003C_003Ep__ = _003C_003Eo__13._003C_003Ep__10;
								if (_003C_003Eo__13._003C_003Ep__9 == null)
								{
									_003C_003Eo__13._003C_003Ep__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string)_003C_003Ec.vPC9BmpnFjM3oZrAXDAi(0xA4E904F ^ 0xA4FB5C9), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)_003C_003Ec.NgroxUpn0IoODpg8ibdB(CSharpArgumentInfoFlags.None, null) }));
								}
								Func<CallSite, object, object> target2 = _003C_003Eo__13._003C_003Ep__9.Target;
								CallSite<Func<CallSite, object, object>> _003C_003Ep__2 = _003C_003Eo__13._003C_003Ep__9;
								if (_003C_003Eo__13._003C_003Ep__8 == null)
								{
									_003C_003Eo__13._003C_003Ep__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string)_003C_003Ec.vPC9BmpnFjM3oZrAXDAi(-1965109395 ^ -1965036811), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
								}
								return _003C_003Ec.m0FEKgpnEKMTdvQCp6pr(target(_003C_003Ep__, target2(_003C_003Ep__2, _003C_003Eo__13._003C_003Ep__8.Target(_003C_003Eo__13._003C_003Ep__8, (object)e))), true, true) as EntityMetadata;
							}
							}
						}
					}, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x463459F2), string.Empty);
					num2 = 6;
					continue;
				case 8:
					ParticipantWork = new PermissionRoleType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A79B400)), (string)gdRJGGXkpkPybMvkrNQ(0x6A79A716 ^ 0x6A798462), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), delegate(dynamic e)
					{
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							default:
								_003C_003Eo__13._003C_003Ep__5 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder)_003C_003Ec.CkWJG6pnGboIiHlGyBcq(CSharpBinderFlags.ConvertExplicit, typeof(IEntity), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle)));
								num8 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
								{
									num8 = 2;
								}
								continue;
							case 1:
								if (_003C_003Eo__13._003C_003Ep__5 == null)
								{
									num8 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
									{
										num8 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
						Func<CallSite, object, IEntity> target4 = _003C_003Eo__13._003C_003Ep__5.Target;
						CallSite<Func<CallSite, object, IEntity>> _003C_003Ep__4 = _003C_003Eo__13._003C_003Ep__5;
						if (_003C_003Eo__13._003C_003Ep__4 == null)
						{
							_003C_003Eo__13._003C_003Ep__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string)_003C_003Ec.vPC9BmpnFjM3oZrAXDAi(0x1C48C9C4 ^ 0x1C48835C), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)_003C_003Ec.NgroxUpn0IoODpg8ibdB(CSharpArgumentInfoFlags.None, null) }));
						}
						return target4(_003C_003Ep__4, _003C_003Eo__13._003C_003Ep__4.Target(_003C_003Eo__13._003C_003Ep__4, (object)e));
					});
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					OrganizationItem = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(0x61EAE816 ^ 0x61EAC9C6)), (string)ls9b8iXpATwiEZR8INH(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EB823E)), InterfaceActivator.TypeOf<IOrganizationItem>(), (string)gdRJGGXkpkPybMvkrNQ(0x2CFDCC80 ^ 0x2CFDEEC8));
					num2 = 5;
					continue;
				case 5:
					Author = new PermissionRoleType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x416A5E3C ^ 0x416A7C58)), SR.M((string)gdRJGGXkpkPybMvkrNQ(-1842376086 ^ -1842368294)), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), delegate(dynamic e)
					{
						int num5 = 2;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								_003C_003Eo__13._003C_003Ep__1 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder)_003C_003Ec.CkWJG6pnGboIiHlGyBcq(CSharpBinderFlags.ConvertExplicit, _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(IEntity).TypeHandle), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle)));
								num6 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
								{
									num6 = 0;
								}
								continue;
							case 2:
								if (_003C_003Eo__13._003C_003Ep__1 == null)
								{
									num6 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
									{
										num6 = 0;
									}
									continue;
								}
								break;
							}
							break;
						}
						Func<CallSite, object, IEntity> target3 = _003C_003Eo__13._003C_003Ep__1.Target;
						CallSite<Func<CallSite, object, IEntity>> _003C_003Ep__3 = _003C_003Eo__13._003C_003Ep__1;
						if (_003C_003Eo__13._003C_003Ep__0 == null)
						{
							_003C_003Eo__13._003C_003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x201ABE6B ^ 0x201AF4F3), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						return target3(_003C_003Ep__3, _003C_003Eo__13._003C_003Ep__0.Target(_003C_003Eo__13._003C_003Ep__0, (object)e));
					});
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					Informs = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(-179348817 ^ -179341019)), (string)gdRJGGXkpkPybMvkrNQ(0x3E79A885 ^ 0x3E798B53), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), delegate(dynamic e)
					{
						int num9 = 1;
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							default:
								_003C_003Eo__13._003C_003Ep__7 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder)_003C_003Ec.CkWJG6pnGboIiHlGyBcq(CSharpBinderFlags.ConvertExplicit, _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(IEntity).TypeHandle), typeof(CommonRoleTypes)));
								num10 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								if (_003C_003Eo__13._003C_003Ep__7 == null)
								{
									num10 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
									{
										num10 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
						Func<CallSite, object, IEntity> target5 = _003C_003Eo__13._003C_003Ep__7.Target;
						CallSite<Func<CallSite, object, IEntity>> _003C_003Ep__5 = _003C_003Eo__13._003C_003Ep__7;
						if (_003C_003Eo__13._003C_003Ep__6 == null)
						{
							_003C_003Eo__13._003C_003Ep__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string)_003C_003Ec.vPC9BmpnFjM3oZrAXDAi(-726732645 ^ -726746621), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)_003C_003Ec.NgroxUpn0IoODpg8ibdB(CSharpArgumentInfoFlags.None, null) }));
						}
						return target5(_003C_003Ep__5, _003C_003Eo__13._003C_003Ep__6.Target(_003C_003Eo__13._003C_003Ep__6, (object)e));
					});
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					AllUsers = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(0x190F47B7 ^ 0x190F585F)), (string)ls9b8iXpATwiEZR8INH(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA1079)), (string)gdRJGGXkpkPybMvkrNQ(-1084772212 ^ -1084780332));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
					num2 = 3;
					continue;
				case 9:
					Group = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(0x2121ECF9 ^ 0x2121CDED)), SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DF873E)), InterfaceActivator.TypeOf<IUserGroup>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x487E82CC ^ 0x487EA3BC), (string)gdRJGGXkpkPybMvkrNQ(0x46F7DF98 ^ 0x46F7FE10));
					num2 = 10;
					continue;
				case 2:
					User = new PermissionRoleType(new Guid((string)gdRJGGXkpkPybMvkrNQ(0x46347DA6 ^ 0x46345DC8)), (string)ls9b8iXpATwiEZR8INH(gdRJGGXkpkPybMvkrNQ(0xBBC1CCD ^ 0xBBC3C77)), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (string)gdRJGGXkpkPybMvkrNQ(-192929954 ^ -192921850), (string)gdRJGGXkpkPybMvkrNQ(-1642017152 ^ -1642009002));
					num = 9;
					break;
				case 1:
					Responsible = new PermissionRoleType(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D386E1)), (string)gdRJGGXkpkPybMvkrNQ(0x738E3073 ^ 0x738E1379), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), delegate(dynamic e)
					{
						int num11 = 2;
						int num12 = num11;
						while (true)
						{
							switch (num12)
							{
							case 2:
								if (_003C_003Eo__13._003C_003Ep__3 == null)
								{
									num12 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
									{
										num12 = 0;
									}
									continue;
								}
								break;
							case 1:
								_003C_003Eo__13._003C_003Ep__3 = CallSite<Func<CallSite, object, IEntity>>.Create((CallSiteBinder)_003C_003Ec.CkWJG6pnGboIiHlGyBcq(CSharpBinderFlags.ConvertExplicit, _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(IEntity).TypeHandle), _003C_003Ec.rUyZ7apncbgqTRm6qfWT(typeof(CommonRoleTypes).TypeHandle)));
								num12 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
								{
									num12 = 0;
								}
								continue;
							}
							break;
						}
						Func<CallSite, object, IEntity> target6 = _003C_003Eo__13._003C_003Ep__3.Target;
						CallSite<Func<CallSite, object, IEntity>> _003C_003Ep__6 = _003C_003Eo__13._003C_003Ep__3;
						if (_003C_003Eo__13._003C_003Ep__2 == null)
						{
							_003C_003Eo__13._003C_003Ep__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, (string)_003C_003Ec.vPC9BmpnFjM3oZrAXDAi(-1718905545 ^ -1718964133), typeof(CommonRoleTypes), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)_003C_003Ec.NgroxUpn0IoODpg8ibdB(CSharpArgumentInfoFlags.None, null) }));
						}
						return target6(_003C_003Ep__6, _003C_003Eo__13._003C_003Ep__2.Target(_003C_003Eo__13._003C_003Ep__2, (object)e));
					});
					num = 8;
					break;
				case 6:
					return;
				}
				break;
			}
		}
	}

	internal static void drgsJ8Wz1DAqdmUIsZM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool VnvtUXWflJJp84EEbSR()
	{
		return AT0vc0W9yY825d02QeM == null;
	}

	internal static CommonRoleTypes evO9UBW1dvVjJ5CnZvK()
	{
		return AT0vc0W9yY825d02QeM;
	}

	internal static object gdRJGGXkpkPybMvkrNQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ls9b8iXpATwiEZR8INH(object P_0)
	{
		return SR.M((string)P_0);
	}
}

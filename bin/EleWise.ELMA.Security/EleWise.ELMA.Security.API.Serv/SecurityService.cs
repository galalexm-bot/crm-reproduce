using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.API.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.API.Service.v1;

[Uid("{7D7AC1D8-68EA-4946-A9AC-EA2258B67626}")]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
public class SecurityService : ISecurityService, IPublicAPIWebService
{
	public const string GuidS = "{7D7AC1D8-68EA-4946-A9AC-EA2258B67626}";

	public static Guid Guid;

	private static SecurityService kkhMoa3i7gTg2mdxQ3f;

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public SubordinateUsersResponse GetSubordinateUsers()
	{
		//Discarded unreachable code: IL_003e, IL_011c, IL_014c, IL_019b, IL_01aa
		SubordinateUsersResponse result = default(SubordinateUsersResponse);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				int num = 2;
				IEnumerable<EleWise.ELMA.Security.Models.IUser> source = default(IEnumerable<EleWise.ELMA.Security.Models.IUser>);
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					case 2:
						source = from u in UserManager.Instance.GetSubordinateByUser(currentUser)
							where _003C_003Ec.AV9TBUpCPOPIp6H7eqBX(u) == UserStatus.Active
							select u;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
						{
							num = 0;
						}
						continue;
					}
					SubordinateUsersResponse subordinateUsersResponse = new SubordinateUsersResponse();
					piORGE3ldwxbIIosgCq(subordinateUsersResponse, source.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToArray());
					result = subordinateUsersResponse;
					num = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num = 0;
					}
				}
			}
			catch (FaultException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw;
				}
			}
			catch (Exception ex2)
			{
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						Logger.Error(ex2);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num3 = 0;
						}
						break;
					default:
						throw qPfgP53NcOWEcMKXTEM(ex2.Message, 500);
					}
				}
			}
		}
	}

	public bool AddUserToGroup(long userId, Guid userGroupUid)
	{
		//Discarded unreachable code: IL_0039, IL_01a7, IL_01d7, IL_0226, IL_0235
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
				int num = 2;
				IUserGroup userGroup = default(IUserGroup);
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 7:
						if (((IEnumerable<EleWise.ELMA.Security.Models.IUser>)userGroup.Users).All((EleWise.ELMA.Security.Models.IUser u) => u.Id != CS_0024_003C_003E8__locals0.user.Id))
						{
							num = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
							{
								num = 4;
							}
							break;
						}
						goto case 6;
					case 6:
						result = true;
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
						{
							num = 0;
						}
						break;
					case 5:
						userGroup.Save();
						num = 6;
						break;
					case 3:
						throw new SecurityException((string)V26xpZ3ZYOfQnG1d9qs(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417D79CC)));
					case 4:
						userGroup.Users.Add(CS_0024_003C_003E8__locals0.user);
						num = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
						{
							num = 5;
						}
						break;
					case 2:
						if (Locator.GetServiceNotNull<EleWise.ELMA.Security.ISecurityService>().HasPermission(PermissionProvider.AccessManagmentPermission))
						{
							userGroup = ((AbstractNHEntityManager<IUserGroup, long>)jFu10T3xQknme92qMX9()).Load(userGroupUid);
							num = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
							{
								num = 1;
							}
						}
						else
						{
							num = 3;
						}
						break;
					case 1:
						CS_0024_003C_003E8__locals0.user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)B3IEFO3BbrAPl7JkX9Q()).Load(userId);
						num = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
						{
							num = 7;
						}
						break;
					}
				}
			}
			catch (FaultException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw;
				}
			}
			catch (Exception ex2)
			{
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						throw qPfgP53NcOWEcMKXTEM(GTJvvY3mGHesfbVZIQo(ex2), 500);
					}
					Y2gDNI3ufVfTuC6py2n(Logger, ex2);
					num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num3 = 1;
					}
				}
			}
		}
	}

	public SecurityService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SHMnqh3eEDhnml25P9K();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SecurityService()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Guid = new Guid((string)btP2KC3LpRArBcNOxO6(0x37FE8EDE ^ 0x37FE7638));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SHMnqh3eEDhnml25P9K();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void piORGE3ldwxbIIosgCq(object P_0, object P_1)
	{
		((SubordinateUsersResponse)P_0).Ids = (long[])P_1;
	}

	internal static object qPfgP53NcOWEcMKXTEM(object P_0, int P_1)
	{
		return PublicServiceException.CreateWebFault((string)P_0, P_1);
	}

	internal static bool T1Xnba37lxbqTuBrK4q()
	{
		return kkhMoa3i7gTg2mdxQ3f == null;
	}

	internal static SecurityService jRT10c36vBMh57dN5cv()
	{
		return kkhMoa3i7gTg2mdxQ3f;
	}

	internal static object V26xpZ3ZYOfQnG1d9qs(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object jFu10T3xQknme92qMX9()
	{
		return UserGroupManager.Instance;
	}

	internal static object B3IEFO3BbrAPl7JkX9Q()
	{
		return UserManager.Instance;
	}

	internal static void Y2gDNI3ufVfTuC6py2n(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object GTJvvY3mGHesfbVZIQo(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void SHMnqh3eEDhnml25P9K()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object btP2KC3LpRArBcNOxO6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}

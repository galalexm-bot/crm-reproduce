using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class UserSecurityProfileManager : EntityManager<IUserSecurityProfile, long>
{
	private static UserSecurityProfileManager YE32cl0O5fEPoSJ7M7U;

	public new static UserSecurityProfileManager Instance => Locator.GetServiceNotNull<UserSecurityProfileManager>();

	private SecuritySettings settings
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Locator.GetService<SecuritySettingsModule>() != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return null;
				default:
					return Locator.GetService<SecuritySettingsModule>().Settings;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUserSecurityProfileEventHandler UserSecurityProfileEventHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CUserSecurityProfileEventHandler_003Ek__BackingField;
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
					_003CUserSecurityProfileEventHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUserSecurityProfile Load([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_007b, IL_008a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x31274285 ^ 0x31274F6F));
			default:
				return ((ICriteria)D8Tefw0Eaj7u6CM8i09(MlqU0e0FYbG1I7abnET(this, null), SrOksY005epC0Bk2noy(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730114228), user.Id))).UniqueResult<IUserSecurityProfile>();
			case 1:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public IUserSecurityProfile LoadByUserLogin([NotNull] string login)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x201ABE6B ^ 0x201A1689));
			case 1:
				return ((ICriteria)MlqU0e0FYbG1I7abnET(this, null)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-268626980 ^ -268624896), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65F93013 ^ 0x65F96F8D), (JoinType)0).Add((ICriterion)SrOksY005epC0Bk2noy(QLqUdH0G7VgcnbwdHVO(0x1618182 ^ 0x1612972), login)).UniqueResult<IUserSecurityProfile>();
			case 2:
				if (login != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	[Transaction]
	internal virtual IUserSecurityProfile CreateProfile([NotNull] EleWise.ELMA.Security.Models.IUser user, string password = null)
	{
		//Discarded unreachable code: IL_0065, IL_0193, IL_01a2
		int num = 1;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		SecuritySettings securitySettings = default(SecuritySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					userSecurityProfile.LastDateChangePassword = rJRpn90YgVW3Xx10fUX();
					num2 = 3;
					break;
				case 14:
					return userSecurityProfile;
				case 3:
					kqkXZi0Io5eGoWhmqfk(userSecurityProfile, false);
					num2 = 10;
					break;
				case 6:
					if (securitySettings == null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 2:
					return userSecurityProfile;
				case 12:
					SetForcedChangePassword(userSecurityProfile);
					num2 = 15;
					break;
				case 9:
					if (userSecurityProfile == null)
					{
						userSecurityProfile = Create();
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 14;
					}
					break;
				case 5:
					ThIGWm0DQjKcTedIoDX(userSecurityProfile, user);
					num2 = 16;
					break;
				case 16:
					userSecurityProfile.Salt = EncryptionHelper.GenerateSalt();
					num2 = 13;
					break;
				case 1:
					if (user != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 8:
					if (qvFTF904mAICF9NaE1d(securitySettings))
					{
						num2 = 12;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 7;
				case 13:
					SnUY8G0sNwp15P3RWMe(userSecurityProfile, pZLyDQ0MQATn6lAst2J(password, userSecurityProfile.Salt));
					num2 = 11;
					break;
				case 7:
				case 15:
					Save(userSecurityProfile);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 2;
					}
					break;
				case 10:
					securitySettings = settings;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E78F84A));
				default:
					userSecurityProfile = Load(user);
					num2 = 9;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	[Transaction]
	public virtual void PasswordReset([NotNull] EleWise.ELMA.Security.Models.IUser user, string password)
	{
		//Discarded unreachable code: IL_0078, IL_0087
		int num = 5;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Save(userSecurityProfile);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (userSecurityProfile != null)
					{
						num2 = 2;
						continue;
					}
					return;
				case 7:
					userSecurityProfile.LastDateChangePassword = rJRpn90YgVW3Xx10fUX();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (user != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 6:
					return;
				case 3:
					break;
				default:
					throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(-1788380826 ^ -1788382068));
				case 4:
					userSecurityProfile = Load(user);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					W4iAUF0QOJnyBRmmFrl(userSecurityProfile, fbN2Lr0VxpaBDpysU2h(16));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			SnUY8G0sNwp15P3RWMe(userSecurityProfile, pZLyDQ0MQATn6lAst2J(password, FhFYEj0dhoHURLSyP0v(userSecurityProfile)));
			num = 7;
		}
	}

	[Transaction]
	internal virtual void FailedLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_00a5, IL_00c7, IL_00d6
		int num = 12;
		int num2 = num;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				Save(userSecurityProfile);
				num2 = 6;
				break;
			case 9:
				num4 = s8MMkV08pE5fIQXKkES(settings);
				num2 = 13;
				break;
			case 3:
				userSecurityProfile = Load(user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return;
			case 7:
				gPpJ190rbce6CnMhIRX(this, userSecurityProfile);
				num2 = 5;
				break;
			case 10:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x2121ECF9 ^ 0x2121E113));
			case 11:
				if (Rrm2ti0Ti51mTFW38NZ(user) == UserStatus.Blocked)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (user.Status == UserStatus.System)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				if (num4 > 0)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 12:
				if (user != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 10;
			case 8:
				if (f2RjGg0gCe9Ml0a2N7A(userSecurityProfile) < num4)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			default:
				userSecurityProfile.DateLastFailedLogon = DateTime.Now;
				num2 = 9;
				break;
			case 2:
			{
				IUserSecurityProfile userSecurityProfile2 = userSecurityProfile;
				long num3 = f2RjGg0gCe9Ml0a2N7A(userSecurityProfile2);
				userSecurityProfile2.CountFailedLogon = num3 + 1;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[ActionMethod("58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7")]
	[Transaction]
	internal virtual void DisallowLogon(IUserSecurityProfile userSecurityProfile)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 6;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		List<EleWise.ELMA.Security.Models.IUser> notifyUsers = default(List<EleWise.ELMA.Security.Models.IUser>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				kqkXZi0Io5eGoWhmqfk(userSecurityProfile, true);
				num2 = 5;
				break;
			case 2:
				return;
			default:
				entityActionEventArgs = (EntityActionEventArgs)gqlAEF0b4gefFxmr4Mq(null, V43MUm0yXM91nc1ALgM(userSecurityProfile), QLqUdH0G7VgcnbwdHVO(-1518425080 ^ -1518454680));
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				notifyUsers = settings.NotifyUsers;
				num2 = 7;
				break;
			case 7:
				entityActionEventArgs.ExtendedProperties.Add((string)QLqUdH0G7VgcnbwdHVO(0x9D1442B ^ 0x9D1ED23), notifyUsers);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (!OE7rCW03YhQubT0vscg(settings))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				return;
			case 3:
				entityActionEventArgs.ExtendedProperties.Add((string)QLqUdH0G7VgcnbwdHVO(-698589567 ^ -698550367), ((EleWise.ELMA.Security.Models.IUser)V43MUm0yXM91nc1ALgM(userSecurityProfile)).GetShortName());
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				WdfljC0Sif5OxHJAKEr(base.ActionHandler, entityActionEventArgs);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	internal virtual void AllowLogonAllWithCheck(TimeSpan period)
	{
		int num = 3;
		int num2 = num;
		IList<long> ids = default(IList<long>);
		ICriteria val = default(ICriteria);
		DateTime now = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 5:
				ids = val.List<long>();
				num2 = 8;
				break;
			case 7:
				D8Tefw0Eaj7u6CM8i09(val, SrOksY005epC0Bk2noy(QLqUdH0G7VgcnbwdHVO(0x1C48C9C4 ^ 0x1C4860FA), true));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				AllowLogon(ids);
				num2 = 6;
				break;
			case 1:
				val = (ICriteria)MlqU0e0FYbG1I7abnET(this, null);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				now = DateTime.Now;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				dateTime = now.Add(j58MQw09BHfM6nB8V97(period));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
				{
					num2 = 1;
				}
				break;
			default:
				D8Tefw0Eaj7u6CM8i09(val, Restrictions.Le((string)QLqUdH0G7VgcnbwdHVO(--553267277 ^ 0x20FA9911), (object)dateTime));
				num2 = 4;
				break;
			case 4:
				F8uIHA01m08ufB9jsJ7(val, new IProjection[1] { (IProjection)kp0Z4M0fCOXMm9eYjiK() });
				num2 = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[Transaction]
	internal virtual void AllowLogon([NotNull] IUserSecurityProfile userSecurityProfile, TimeSpan period)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_00c5
		int num = 4;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		DateTime value = default(DateTime);
		DateTime? dateLastFailedLogon = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 8:
				dateTime = value.Add(period);
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				return;
			case 0:
				return;
			case 6:
				return;
			case 4:
				if (userSecurityProfile == null)
				{
					num2 = 3;
					continue;
				}
				dateLastFailedLogon = userSecurityProfile.DateLastFailedLogon;
				num2 = 5;
				continue;
			case 3:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(-1801396866 ^ -1801423624));
			case 9:
				if (!(rJRpn90YgVW3Xx10fUX() >= dateTime))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				value = dateLastFailedLogon.Value;
				num2 = 8;
				continue;
			case 5:
				if (!dateLastFailedLogon.HasValue)
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			case 7:
				break;
			}
			AllowLogon(userSecurityProfile);
			num2 = 6;
		}
	}

	[Transaction]
	internal virtual void AllowLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 4;
		int num2 = num;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (user != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				AllowLogon(userSecurityProfile);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			default:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x271B34E4 ^ 0x271B390E));
			case 3:
				userSecurityProfile = Load(user);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	[ActionMethod("2635ac67-8011-4f05-9d77-ee701271227a")]
	internal virtual void AllowLogon([NotNull] IUserSecurityProfile userSecurityProfile)
	{
		//Discarded unreachable code: IL_0036, IL_0045
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x84482CB ^ 0x8442B4D));
				case 1:
					kqkXZi0Io5eGoWhmqfk(userSecurityProfile, false);
					num = 3;
					break;
				case 3:
					ResetCountFailedLogon(userSecurityProfile);
					num = 4;
					break;
				case 2:
					if (userSecurityProfile != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	[Transaction]
	internal virtual void AllowLogon(IEnumerable<long> ids = null)
	{
		if (ids == null || ids.Any())
		{
			string[] columns = new string[3]
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566035522),
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x4009CA22),
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33C80D)
			};
			object[] values = new object[3]
			{
				Convert.ToInt32(value: false),
				0,
				null
			};
			string where = ((ids != null) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-736288531 ^ -736261831), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAA59D6)), ids.ToSeparatedString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1943394692 ^ -1943389006))) : "");
			TransformationProvider.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x432996D0 ^ 0x43293F20), columns, values, where);
			base.Session.CleanUpCache(typeof(IUserSecurityProfile));
			UserSecurityProfileEventHandler.AllowLogon(ids);
		}
	}

	[Transaction]
	internal virtual void ResetCountFailedLogonWithCheck(EleWise.ELMA.Security.Models.IUser user, TimeSpan period)
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_0164
		int num = 4;
		int num2 = num;
		bool flag = default(bool);
		DateTime value = default(DateTime);
		DateTime? dateLastFailedLogon = default(DateTime?);
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!flag)
				{
					num2 = 10;
					break;
				}
				return;
			case 10:
				value = dateLastFailedLogon.Value;
				num2 = 11;
				break;
			default:
				flag = W9gOdZ0zTrDhuWEveNr(userSecurityProfile);
				num2 = 5;
				break;
			case 11:
				dateTime = value.Add(period);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				return;
			case 9:
				if (!CgohioEkc3Sm7VP5FvE(DateTime.Now, dateTime))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 5:
				if (!dateLastFailedLogon.HasValue)
				{
					num2 = 2;
					break;
				}
				goto case 8;
			case 6:
				Mimj1dEpafourGcq3sL(this, userSecurityProfile);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				userSecurityProfile = Load(user);
				num2 = 3;
				break;
			case 3:
				dateLastFailedLogon = userSecurityProfile.DateLastFailedLogon;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 7:
				return;
			}
		}
	}

	[Transaction]
	internal virtual void ResetCountFailedLogonAllWithCheck(TimeSpan period)
	{
		int num = 9;
		int num2 = num;
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = default(DateTime);
		ICriteria val = default(ICriteria);
		IList<long> ids = default(IList<long>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				dateTime2 = dateTime.Add(j58MQw09BHfM6nB8V97(period));
				num2 = 3;
				break;
			case 5:
				F8uIHA01m08ufB9jsJ7(val, new IProjection[1] { (IProjection)Projections.Id() });
				num2 = 7;
				break;
			case 2:
				return;
			case 3:
				val = (ICriteria)MlqU0e0FYbG1I7abnET(this, null);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				val.Add((ICriterion)OsTIfhEATTPGoKu2txv(QLqUdH0G7VgcnbwdHVO(-764392425 ^ -764353205), dateTime2));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				D8Tefw0Eaj7u6CM8i09(val, Ss1BZeE51xVqPpE1dD2(QLqUdH0G7VgcnbwdHVO(-1943394692 ^ -1943367732), 0L));
				num2 = 6;
				break;
			case 1:
				ResetCountFailedLogon(ids);
				num2 = 2;
				break;
			case 7:
				ids = val.List<long>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
				{
					num2 = 0;
				}
				break;
			default:
				D8Tefw0Eaj7u6CM8i09(val, Restrictions.Eq((string)QLqUdH0G7VgcnbwdHVO(0x2CFDCC80 ^ 0x2CFD65BE), (object)false));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				dateTime = rJRpn90YgVW3Xx10fUX();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	[Transaction]
	internal virtual void ResetCountFailedLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 4;
		int num2 = num;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (user != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				Mimj1dEpafourGcq3sL(this, userSecurityProfile);
				num2 = 2;
				break;
			default:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959662570));
			case 3:
				userSecurityProfile = Load(user);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[Transaction]
	[ActionMethod("9b776346-d67c-4e66-93e5-4de53e6846eb")]
	internal virtual void ResetCountFailedLogon(IUserSecurityProfile userSecurityProfile)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				default:
					userSecurityProfile.DateLastFailedLogon = null;
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (userSecurityProfile == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
						{
							num2 = 1;
						}
						continue;
					}
					QsoVMoEWMf0ayLau9Bp(userSecurityProfile, 0L);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 1:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816845223));
				}
				break;
			}
			Save(userSecurityProfile);
			num = 3;
		}
	}

	[Transaction]
	internal virtual void ResetCountFailedLogonAllUsers()
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
				ResetCountFailedLogon();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Transaction]
	internal virtual void ResetCountFailedLogon(IEnumerable<long> ids = null)
	{
		if (ids == null || ids.Any())
		{
			string[] columns = new string[2]
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E785C10),
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D98533)
			};
			object[] values = new object[2] { 0, null };
			string where = ((ids != null) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D76F7A6), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764388345)), ids.ToSeparatedString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163218802))) : "");
			TransformationProvider.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E785C50), columns, values, where);
			base.Session.CleanUpCache(typeof(IUserSecurityProfile));
			UserSecurityProfileEventHandler.ResetCountFailedLogon(ids);
		}
	}

	[Transaction]
	internal virtual void SetForcedChangePasswordWithCheck([NotNull] EleWise.ELMA.Security.Models.IUser user, TimeSpan period)
	{
		int num = 9;
		int num2 = num;
		DateTime? lastDateChangePassword = default(DateTime?);
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (lastDateChangePassword.HasValue)
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 6:
				if (rJRpn90YgVW3Xx10fUX() >= lastDateChangePassword.Value.Add(period))
				{
					num2 = 3;
					break;
				}
				return;
			case 9:
				_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
				num2 = 8;
				break;
			case 3:
				W4M5RkEnB9Y2oP2oVuc(sUjcuHEXePeIOUgwF7k(this), user, new Action(_003C_003Ec__DisplayClass29_._003CSetForcedChangePasswordWithCheck_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(-208231202 ^ -208230092));
			case 5:
				if (lastDateChangePassword.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 8:
				_003C_003Ec__DisplayClass29_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 4:
				if (user != null)
				{
					_003C_003Ec__DisplayClass29_.userSecurityProfile = Load(user);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 0:
				return;
			case 7:
				lastDateChangePassword = _003C_003Ec__DisplayClass29_.userSecurityProfile.LastDateChangePassword;
				num2 = 5;
				break;
			}
		}
	}

	[Transaction]
	internal virtual void SetForcedChangePasswordWithCheck(ICollection<long> excludedUsersId, TimeSpan period)
	{
		SqlSubQuery namedSubQuery = base.Session.GetNamedSubQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA9A57));
		namedSubQuery.SetParameter(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E670086), new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965109395 ^ -1965097607)));
		AbstractCriterion val = NHQueryExtensions.Sql(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD8278A) + namedSubQuery.Sql + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757459871), namedSubQuery.ParametersValues, namedSubQuery.ParametersTypes);
		DateTime dateTime = DateTime.Now.Add(-period);
		ICriteria val2 = CreateCriteria();
		val2.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51BB29A6 ^ 0x51BB267A), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40944BC4 ^ 0x4094462E));
		val2.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-76932334 ^ -76893856), (object)Guid.Empty));
		val2.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788357690), (object)UserStatus.Active));
		val2.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA9AF7), (ICollection)excludedUsersId)));
		val2.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)val));
		val2.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B6F53), (object)false));
		val2.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1615559191 ^ -1615581423), (object)dateTime), (ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E79027D))));
		val2.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
		IList<long> forcedChangePassword = val2.List<long>();
		SetForcedChangePassword(forcedChangePassword);
	}

	[Transaction]
	internal virtual void SetForcedChangePassword([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0035
		int num = 1;
		int num2 = num;
		IUserSecurityProfile forcedChangePassword = default(IUserSecurityProfile);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(-1580392499 ^ -1580395993));
			default:
				forcedChangePassword = Load(user);
				num2 = 3;
				break;
			case 1:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				SetForcedChangePassword(forcedChangePassword);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[Transaction]
	[ActionMethod("cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7")]
	internal virtual void SetForcedChangePassword([NotNull] IUserSecurityProfile userSecurityProfile)
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_008c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!((EleWise.ELMA.Security.Models.IUser)V43MUm0yXM91nc1ALgM(userSecurityProfile)).AllowChangePassword())
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 4:
				return;
			case 3:
				return;
			case 6:
				return;
			case 2:
				baUZ2XE6raVS82BypV1(userSecurityProfile, true);
				num2 = 7;
				break;
			default:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x65F93013 ^ 0x65F99995));
			case 1:
				if (userSecurityProfile != null)
				{
					if (!Lt5etcE7usRDvPrqTCW(XK1HxKEilH65g2ZFvTc(V43MUm0yXM91nc1ALgM(userSecurityProfile)), Guid.Empty))
					{
						num2 = 3;
						break;
					}
					goto case 5;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				Save(userSecurityProfile);
				num2 = 6;
				break;
			}
		}
	}

	[Transaction]
	internal virtual void SetForcedChangePassword(IEnumerable<long> ids = null)
	{
		if (ids == null || ids.Any())
		{
			string[] columns = new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x7157BE35) };
			object[] values = new object[1] { Convert.ToInt32(value: true) };
			string where = ((ids != null) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1642017152 ^ -1642043564), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163221424)), ids.ToSeparatedString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698596273))) : "");
			TransformationProvider.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905821499 ^ -905778379), columns, values, where);
			base.Session.CleanUpCache(typeof(IUserSecurityProfile));
			UserSecurityProfileEventHandler.SetForcedChangePassword(ids);
		}
	}

	[ActionMethod("d1ef7b26-1d49-408d-a5c4-f204fca7c132")]
	[Transaction]
	internal virtual void ResetForcedChangePassword([NotNull] EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 2;
		int num2 = num;
		IUserSecurityProfile userSecurityProfile = default(IUserSecurityProfile);
		while (true)
		{
			switch (num2)
			{
			case 4:
				Save(userSecurityProfile);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 2:
				if (user == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
					{
						num2 = 1;
					}
					break;
				}
				userSecurityProfile = Load(user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				baUZ2XE6raVS82BypV1(userSecurityProfile, false);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)QLqUdH0G7VgcnbwdHVO(0x2121ECF9 ^ 0x2121E113));
			}
		}
	}

	public UserSecurityProfileManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kgQeBvEl2u1GYLZxCEu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WnrkbF0qmhrFu3cGHVZ()
	{
		return YE32cl0O5fEPoSJ7M7U == null;
	}

	internal static UserSecurityProfileManager IJYWxY0c2rHIqehaKVW()
	{
		return YE32cl0O5fEPoSJ7M7U;
	}

	internal static object QLqUdH0G7VgcnbwdHVO(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MlqU0e0FYbG1I7abnET(object P_0, object P_1)
	{
		return ((EntityManager<IUserSecurityProfile, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object SrOksY005epC0Bk2noy(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object D8Tefw0Eaj7u6CM8i09(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void ThIGWm0DQjKcTedIoDX(object P_0, object P_1)
	{
		((IUserSecurityProfile)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object pZLyDQ0MQATn6lAst2J(object P_0, object P_1)
	{
		return EncryptionHelper.GetSha256Hash((string)P_0, (string)P_1);
	}

	internal static void SnUY8G0sNwp15P3RWMe(object P_0, object P_1)
	{
		((IUserSecurityProfile)P_0).Password = (string)P_1;
	}

	internal static DateTime rJRpn90YgVW3Xx10fUX()
	{
		return DateTime.Now;
	}

	internal static void kqkXZi0Io5eGoWhmqfk(object P_0, bool value)
	{
		((IUserSecurityProfile)P_0).DisallowLogon = value;
	}

	internal static bool qvFTF904mAICF9NaE1d(object P_0)
	{
		return ((SecuritySettings)P_0).ForcedChangePasswordOnFirstLogon;
	}

	internal static object fbN2Lr0VxpaBDpysU2h(int P_0)
	{
		return EncryptionHelper.GenerateSalt(P_0);
	}

	internal static void W4iAUF0QOJnyBRmmFrl(object P_0, object P_1)
	{
		((IUserSecurityProfile)P_0).Salt = (string)P_1;
	}

	internal static object FhFYEj0dhoHURLSyP0v(object P_0)
	{
		return ((IUserSecurityProfile)P_0).Salt;
	}

	internal static UserStatus Rrm2ti0Ti51mTFW38NZ(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static long f2RjGg0gCe9Ml0a2N7A(object P_0)
	{
		return ((IUserSecurityProfile)P_0).CountFailedLogon;
	}

	internal static int s8MMkV08pE5fIQXKkES(object P_0)
	{
		return ((SecuritySettings)P_0).CountLogonAttempts;
	}

	internal static void gPpJ190rbce6CnMhIRX(object P_0, object P_1)
	{
		((UserSecurityProfileManager)P_0).DisallowLogon((IUserSecurityProfile)P_1);
	}

	internal static bool OE7rCW03YhQubT0vscg(object P_0)
	{
		return ((SecuritySettings)P_0).NotifyBlocking;
	}

	internal static object V43MUm0yXM91nc1ALgM(object P_0)
	{
		return ((IUserSecurityProfile)P_0).User;
	}

	internal static object gqlAEF0b4gefFxmr4Mq(object P_0, object P_1, object P_2)
	{
		return EntityActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, (string)P_2);
	}

	internal static void WdfljC0Sif5OxHJAKEr(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static TimeSpan j58MQw09BHfM6nB8V97(TimeSpan P_0)
	{
		return -P_0;
	}

	internal static object kp0Z4M0fCOXMm9eYjiK()
	{
		return Projections.Id();
	}

	internal static object F8uIHA01m08ufB9jsJ7(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static bool W9gOdZ0zTrDhuWEveNr(object P_0)
	{
		return ((IUserSecurityProfile)P_0).DisallowLogon;
	}

	internal static bool CgohioEkc3Sm7VP5FvE(DateTime P_0, DateTime P_1)
	{
		return P_0 >= P_1;
	}

	internal static void Mimj1dEpafourGcq3sL(object P_0, object P_1)
	{
		((UserSecurityProfileManager)P_0).ResetCountFailedLogon((IUserSecurityProfile)P_1);
	}

	internal static object Ss1BZeE51xVqPpE1dD2(object P_0, object P_1)
	{
		return Restrictions.Gt((string)P_0, P_1);
	}

	internal static object OsTIfhEATTPGoKu2txv(object P_0, object P_1)
	{
		return Restrictions.Le((string)P_0, P_1);
	}

	internal static void QsoVMoEWMf0ayLau9Bp(object P_0, long value)
	{
		((IUserSecurityProfile)P_0).CountFailedLogon = value;
	}

	internal static object sUjcuHEXePeIOUgwF7k(object P_0)
	{
		return ((EntityManager<IUserSecurityProfile, long>)P_0).SecurityService;
	}

	internal static void W4M5RkEnB9Y2oP2oVuc(object P_0, object P_1, object P_2)
	{
		((ISecurityService)P_0).RunByUser((IUser)P_1, (Action)P_2);
	}

	internal static Guid XK1HxKEilH65g2ZFvTc(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).AuthProviderGuid;
	}

	internal static bool Lt5etcE7usRDvPrqTCW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void baUZ2XE6raVS82BypV1(object P_0, bool value)
	{
		((IUserSecurityProfile)P_0).ForcedChangePassword = value;
	}

	internal static void kgQeBvEl2u1GYLZxCEu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

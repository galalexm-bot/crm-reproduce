using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Audit;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class UserCertificateManager : EntityManager<IUserCertificate, long>
{
	private static UserCertificateManager nIhoISMZqiB8KONmWR8;

	public SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

	public AuthCryptoProviderService AuthCryptoProviderService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthCryptoProviderService_003Ek__BackingField;
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
					_003CAuthCryptoProviderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ICertificateCryptoAction> CryptoActions { get; set; }

	public ILoginDigitalSignatureEventHandler DigitalSignatureEventHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CDigitalSignatureEventHandler_003Ek__BackingField;
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
					_003CDigitalSignatureEventHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public new static UserCertificateManager Instance => Locator.GetServiceNotNull<UserCertificateManager>();

	[Obsolete("Устарел. Используйте EleWise.ELMA.Security.Services.AuthCryptoProviderService.CheckSignature")]
	public X509Certificate2 CheckSignature(string signature, string signedText)
	{
		IVerifyResult verifyResult = AuthCryptoProviderService.CheckSignature(signedText, signature, checkSignatureOnly: false);
		zFqjDsMuaWAtoT9o4Wg(verifyResult);
		return new X509Certificate2((byte[])JuyTiHMeuQnHeJHAGJW(LD7AAOMm2FBm2NP3vM5(verifyResult)));
	}

	[Transaction]
	public virtual void SignInByCertificate(string signature, string signedText)
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
				WTMNvxMjyg7B8YFs1WV(this, signature, signedText, HYQl4UMLnVH88qmxkAg(AuthCryptoProviderService));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
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
	public virtual void SignInByCertificate(string signature, string signedText, Guid providerUid)
	{
		//Discarded unreachable code: IL_0347, IL_03e4, IL_0435, IL_056b, IL_057a
		int num = 1;
		int num2 = num;
		LoginAuditContainer loginAuditContainer = default(LoginAuditContainer);
		IUserCertificate userCertificate = default(IUserCertificate);
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		string text = default(string);
		bool? isDefault = default(bool?);
		while (true)
		{
			switch (num2)
			{
			case 13:
				return;
			case 17:
				AuditCheckDigitalSignature(loginAuditContainer);
				num2 = 5;
				break;
			case 11:
				if (qXlyyKMG0Pwpvmi4GV5(AuthCryptoProviderService, VxKnNcMcRT7wi4kHRZ7(userCertificate)) != providerUid)
				{
					num2 = 16;
					break;
				}
				goto case 15;
			case 1:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
				{
					num2 = 0;
				}
				break;
			case 20:
				text = (string)MJtPg7MOvIiQjuSNT9L(text, zqbgrCMhZZ0iyUxbJgy(MptIY1MwOvjUKhLtMHV(-1278809262 ^ -1278845514)));
				num2 = 19;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
				{
					num2 = 5;
				}
				break;
			case 16:
				text = (string)MJtPg7MOvIiQjuSNT9L(text, SR.T((string)MptIY1MwOvjUKhLtMHV(-1429500015 ^ -1429521923)));
				num2 = 15;
				break;
			case 26:
				throw new AuthenticationException(text);
			case 8:
				Locator.GetServiceNotNull<FormsAuthenticationService>().SignIn((IUser)VxKnNcMcRT7wi4kHRZ7(userCertificate), (string)Hq1fnhMM7E7snpkHBnt(MptIY1MwOvjUKhLtMHV(-930147978 ^ -930109892), 2, TIm7AbMD9qXk34aFgO5(userCertificate)));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
				{
					num2 = 0;
				}
				break;
			case 19:
			case 21:
			case 29:
				if (!eA7ToPMFbt2acveGSdj(text, string.Empty))
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 24;
			case 14:
				if (S77iPbMab5QNylbSaKQ(_003C_003Ec__DisplayClass18_.result))
				{
					num2 = 27;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 26;
					}
					break;
				}
				goto case 17;
			case 25:
				text = "";
				num2 = 12;
				break;
			case 6:
				text = (string)MJtPg7MOvIiQjuSNT9L(text, zqbgrCMhZZ0iyUxbJgy(MptIY1MwOvjUKhLtMHV(0x65F93013 ^ 0x65F985E3)));
				num2 = 29;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
				{
					num2 = 22;
				}
				break;
			case 23:
				if (isDefault.HasValue)
				{
					num2 = 31;
					break;
				}
				goto case 20;
			case 9:
				return;
			case 24:
			{
				IVerifyResult result = loginAuditContainer.Result;
				TJlUtDMEZ8wILh30m4x(result, MJtPg7MOvIiQjuSNT9L(w0dLFIM0FbGlTURjfgG(result), text));
				num2 = 7;
				break;
			}
			case 2:
				userCertificate.LastTouchDate = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				if (userCertificate == null)
				{
					num2 = 6;
					break;
				}
				goto case 10;
			case 15:
				if (!Module.Settings.AllowLoginOnlyByDefaultCertificate)
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 21;
					}
					break;
				}
				goto case 30;
			case 3:
				zw8KLUMsdk2C8CTg9pT(userCertificate);
				num2 = 4;
				break;
			case 30:
				isDefault = userCertificate.IsDefault;
				num2 = 23;
				break;
			case 22:
				if (!isDefault.Value)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 20;
					}
					break;
				}
				goto case 19;
			case 10:
				cHlN0GMqXuQMXuqqi9u(loginAuditContainer, userCertificate.User);
				num2 = 11;
				break;
			case 5:
				zFqjDsMuaWAtoT9o4Wg(_003C_003Ec__DisplayClass18_.result);
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
				{
					num2 = 4;
				}
				break;
			case 28:
				if (LD7AAOMm2FBm2NP3vM5(_003C_003Ec__DisplayClass18_.result) == null)
				{
					num2 = 17;
					break;
				}
				goto case 14;
			case 18:
				loginAuditContainer = new LoginAuditContainer
				{
					Result = _003C_003Ec__DisplayClass18_.result,
					User = null
				};
				num2 = 28;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				AuditCheckDigitalSignature(loginAuditContainer);
				num2 = 13;
				break;
			default:
				_003C_003Ec__DisplayClass18_.result = (IVerifyResult)BMofjoMHlZf4wsHFM7Q(AuthCryptoProviderService, signedText, signature, false, providerUid);
				num2 = 15;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
				{
					num2 = 18;
				}
				break;
			case 27:
			{
				ParameterExpression parameterExpression = (ParameterExpression)vkX6b0M272PQMDYOlJp(MbA8MfMRqXwLEUHqvW6(typeof(IUserCertificate).TypeHandle), MptIY1MwOvjUKhLtMHV(0x46F7DF98 ^ 0x46F76A72));
				userCertificate = Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression)RWyxAIMtTiFH9yvMTyU(Expression.Equal((Expression)ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)ikiIX4MvWnXOI0jhpOv(ikiIX4MvWnXOI0jhpOv(TuwMuwMowRegIevP1yM(OSkmFtMCZIxZJJeVjjV(_003C_003Ec__DisplayClass18_, typeof(_003C_003Ec__DisplayClass18_0)), GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), BmJwk9MK4MCC7cBwAvh(ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hxcgiVMJRXnxaJ4cjap(Expression.Field(null, (FieldInfo)GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), typeof(Guid?)), false, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }), new FetchOptions(0, 1)).FirstOrDefault();
				num2 = 25;
				break;
			}
			case 7:
				AuditCheckDigitalSignature(loginAuditContainer);
				num2 = 26;
				break;
			case 31:
				isDefault = userCertificate.IsDefault;
				num2 = 22;
				break;
			}
		}
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateByThumbprint(string subject, string thumbprint, EleWise.ELMA.Security.Models.IUser user = null)
	{
		return (IUserCertificate)o8jNUhMYXuFSGxeURBt(this, subject, thumbprint, user, AuthCryptoAction.UID);
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateByThumbprint(string subject, string thumbprint, EleWise.ELMA.Security.Models.IUser user, Guid cryptoActionUid)
	{
		return RegisterCertificateByThumbprint(subject, thumbprint, user, cryptoActionUid, null, isDefault: false);
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateByThumbprint(string subject, string thumbprint, EleWise.ELMA.Security.Models.IUser user, Guid cryptoActionUid, bool isDefault)
	{
		return RegisterCertificateByThumbprint(subject, thumbprint, user, cryptoActionUid, null, isDefault);
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateByThumbprint(string subject, string thumbprint, EleWise.ELMA.Security.Models.IUser user, Guid? cryptoActionUid, Guid? cryptoProviderUid, bool isDefault)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.thumbprint = thumbprint;
		CS_0024_003C_003E8__locals0.cryptoActionUid = cryptoActionUid;
		EleWise.ELMA.Security.Models.IUser user2 = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		if (user == null)
		{
			user = user2;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (user2 != user && !serviceNotNull.HasPermission(user2, PermissionProvider.UserManagmentPermission))
		{
			throw new SecurityException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E787D0E)));
		}
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.thumbprint))
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x50A2A0A3 ^ 0x50A217FF)));
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserCertificate), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119555358));
		IUserCertificate userCertificate = ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass22_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass22_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
		if (userCertificate != null)
		{
			if (userCertificate.User == user)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31274285 ^ 0x3127F51B)));
			}
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62C4BCE8 ^ 0x62C40B14)));
		}
		ICertificateCryptoAction certificateCryptoAction = CryptoActions.FirstOrDefault(delegate(ICertificateCryptoAction a)
		{
			//Discarded unreachable code: IL_0035
			int num = 2;
			int num2 = num;
			Guid actionUid = default(Guid);
			Guid? cryptoActionUid2 = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					actionUid = a.ActionUid;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					cryptoActionUid2 = CS_0024_003C_003E8__locals0.cryptoActionUid;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (cryptoActionUid2.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 4:
					return false;
				case 3:
					return _003C_003Ec__DisplayClass22_0.OFmeikpafsZWet4mQJLq(actionUid, cryptoActionUid2.GetValueOrDefault());
				}
			}
		});
		if (certificateCryptoAction == null)
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x21215493)));
		}
		string msg = "";
		if (!certificateCryptoAction.CanRegisterCertificate(out msg))
		{
			throw new Exception(msg);
		}
		IUserCertificate userCertificate2 = InterfaceActivator.Create<IUserCertificate>();
		userCertificate2.Name = subject;
		userCertificate2.User = user;
		userCertificate2.Thumbprint = CS_0024_003C_003E8__locals0.thumbprint;
		userCertificate2.CryptoActionGuid = certificateCryptoAction.ActionUid;
		userCertificate2.CryptoProviderGuid = cryptoProviderUid ?? ((certificateCryptoAction.CryptoService != null) ? new Guid?(certificateCryptoAction.CryptoService.GetUserProviderUid(user)) : cryptoProviderUid);
		userCertificate2.IsDefault = isDefault;
		userCertificate2.Save();
		return userCertificate2;
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateBySignature(string signature, string signedText, EleWise.ELMA.Security.Models.IUser user = null)
	{
		return (IUserCertificate)GW9NmrMIYibe5t9CVyp(this, signature, signedText, user, AuthCryptoAction.UID, false);
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateBySignature(string signature, string signedText, EleWise.ELMA.Security.Models.IUser user, bool isDefault)
	{
		return (IUserCertificate)GW9NmrMIYibe5t9CVyp(this, signature, signedText, user, AuthCryptoAction.UID, isDefault);
	}

	[Transaction]
	public virtual IUserCertificate RegisterCertificateBySignature(string signature, string signedText, EleWise.ELMA.Security.Models.IUser user, Guid cryptoActionUid, bool isDefault)
	{
		int num = 4;
		int num2 = num;
		IVerifyResult verifyResult = default(IVerifyResult);
		ICryptoProviderServiceBase cryptoService = default(ICryptoProviderServiceBase);
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				zFqjDsMuaWAtoT9o4Wg(verifyResult);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				verifyResult = (IVerifyResult)IVhtoaMVvg72e3Kq7vN(cryptoService, signedText, signature, false, GfrGQhM4mnkrcHCmdhd(cryptoService, user));
				num2 = 5;
				break;
			case 4:
				_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				num2 = 3;
				break;
			default:
				return RegisterCertificateByThumbprint((string)v9n2aAMQCqvomtqJVnm(LD7AAOMm2FBm2NP3vM5(verifyResult)), ((ISigner)LD7AAOMm2FBm2NP3vM5(verifyResult)).Thumbprint, user, _003C_003Ec__DisplayClass25_.cryptoActionUid, isDefault);
			case 3:
				_003C_003Ec__DisplayClass25_.cryptoActionUid = cryptoActionUid;
				num2 = 2;
				break;
			case 2:
				cryptoService = (CryptoActions.FirstOrDefault(_003C_003Ec__DisplayClass25_._003CRegisterCertificateBySignature_003Eb__0) ?? throw new Exception(SR.T((string)MptIY1MwOvjUKhLtMHV(0x31C71464 ^ 0x31C7AC0E)))).CryptoService;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void UnRegisterCertificate(long id, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_007f, IL_012b, IL_013a
		int num = 4;
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		ISecurityService serviceNotNull = default(ISecurityService);
		string msg = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					dGIhkKMTdQ7Vga6C5fC(_003C_003Ec__DisplayClass26_.cert);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num2 = 12;
					}
					break;
				case 5:
					throw new SecurityException(SR.T((string)MptIY1MwOvjUKhLtMHV(-848444002 ^ -848474832)));
				case 9:
					_003C_003Ec__DisplayClass26_.cert = Load(id);
					num2 = 10;
					break;
				case 6:
					if (user2 != user)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 9;
				case 8:
					if (user != null)
					{
						goto end_IL_0012;
					}
					goto case 11;
				case 1:
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
					num2 = 6;
					break;
				case 2:
					if (QFKwoGMd3XseL6fuD7H(serviceNotNull, user2, PermissionProvider.UserManagmentPermission))
					{
						num2 = 9;
						break;
					}
					goto case 5;
				case 12:
					return;
				case 13:
					throw new Exception(msg);
				case 3:
					user2 = (EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
					{
						num2 = 8;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
					num2 = 3;
					break;
				case 11:
					user = user2;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
					{
						num2 = 1;
					}
					break;
				case 10:
				{
					ICertificateCryptoAction obj = CryptoActions.FirstOrDefault(_003C_003Ec__DisplayClass26_._003CUnRegisterCertificate_003Eb__0) ?? throw new Exception((string)zqbgrCMhZZ0iyUxbJgy(MptIY1MwOvjUKhLtMHV(0x43ED0455 ^ 0x43EDBC3F)));
					msg = "";
					if (obj.CanUnregisterCertificate(_003C_003Ec__DisplayClass26_.cert, out msg))
					{
						if (VxKnNcMcRT7wi4kHRZ7(_003C_003Ec__DisplayClass26_.cert) != user)
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 13;
					}
					break;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	[Transaction]
	public virtual void SetDefaultCertificate(long id, EleWise.ELMA.Security.Models.IUser user, bool @default)
	{
		int num = 4;
		int num2 = num;
		ISecurityService serviceNotNull = default(ISecurityService);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			IUserCertificate userCertificate;
			switch (num2)
			{
			default:
				return;
			case 6:
				serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
				num2 = 7;
				break;
			case 3:
				if (user == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 7:
				if (user2 != user)
				{
					num2 = 2;
					break;
				}
				goto IL_00ec;
			case 2:
				if (!QFKwoGMd3XseL6fuD7H(serviceNotNull, user2, PermissionProvider.UserManagmentPermission))
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00ec;
			case 1:
				user = user2;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
				{
					num2 = 6;
				}
				break;
			case 0:
				return;
			case 5:
				throw new SecurityException((string)zqbgrCMhZZ0iyUxbJgy(MptIY1MwOvjUKhLtMHV(0x84482CB ^ 0x8440A65)));
			case 4:
				{
					user2 = (EleWise.ELMA.Security.Models.IUser)FOWmNqMgENqq92hvNFq(Locator.GetServiceNotNull<IAuthenticationService>());
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_00ec:
				userCertificate = Load(id);
				userCertificate.IsDefault = @default;
				zw8KLUMsdk2C8CTg9pT(userCertificate);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetDefaultCertificateThumbpint(IUser user)
	{
		return GetDefaultCertificateThumbpint(user, AuthCryptoAction.UID);
	}

	public string GetCurrentUserDefaultCertificateThumbpint(Guid cryptoActionUid)
	{
		int num = 1;
		int num2 = num;
		IUserCertificate defaultCertificate = default(IUserCertificate);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (defaultCertificate == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)TIm7AbMD9qXk34aFgO5(defaultCertificate);
			case 1:
				user = (EleWise.ELMA.Security.Models.IUser)FOWmNqMgENqq92hvNFq(Locator.GetServiceNotNull<IAuthenticationService>());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				defaultCertificate = GetDefaultCertificate(user, cryptoActionUid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return string.Empty;
			}
		}
	}

	public string GetDefaultCertificateThumbpint(IUser user, Guid cryptoActionUid)
	{
		int num = 1;
		int num2 = num;
		IUserCertificate defaultCertificate = default(IUserCertificate);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return string.Empty;
			case 1:
				defaultCertificate = GetDefaultCertificate(user, cryptoActionUid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (defaultCertificate != null)
			{
				return (string)TIm7AbMD9qXk34aFgO5(defaultCertificate);
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
			{
				num2 = 0;
			}
		}
	}

	public IUserCertificate GetDefaultCertificate(IUser user, Guid cryptoActionUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass31_.cryptoActionUid = cryptoActionUid;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)vkX6b0M272PQMDYOlJp(MbA8MfMRqXwLEUHqvW6(typeof(IUserCertificate).TypeHandle), MptIY1MwOvjUKhLtMHV(0x2CFDCC80 ^ 0x2CFD796A));
				return ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression)RWyxAIMtTiFH9yvMTyU(RWyxAIMtTiFH9yvMTyU(RWyxAIMtTiFH9yvMTyU(oI7Sy6M8tXsmZnkfij1(Expression.Property(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), TuwMuwMowRegIevP1yM(OSkmFtMCZIxZJJeVjjV(_003C_003Ec__DisplayClass31_, MbA8MfMRqXwLEUHqvW6(typeof(_003C_003Ec__DisplayClass31_0).TypeHandle)), GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal((Expression)ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)hxcgiVMJRXnxaJ4cjap(TuwMuwMowRegIevP1yM(OSkmFtMCZIxZJJeVjjV(_003C_003Ec__DisplayClass31_, MbA8MfMRqXwLEUHqvW6(typeof(_003C_003Ec__DisplayClass31_0).TypeHandle)), GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), MbA8MfMRqXwLEUHqvW6(typeof(Guid?).TypeHandle)), liftToNull: false, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), ikiIX4MvWnXOI0jhpOv(ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Xd5IOhMrk4698VelC1F((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(bool?).TypeHandle))), ikiIX4MvWnXOI0jhpOv(ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)Xd5IOhMrk4698VelC1F((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(bool?).TypeHandle))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			default:
				_003C_003Ec__DisplayClass31_.user = user;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IUserCertificate GetCertificate(IUser user)
	{
		return GetCertificates(user, AuthCryptoAction.UID).FirstOrDefault();
	}

	public IEnumerable<IUserCertificate> GetCertificates(IUser user)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.user = user;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserCertificate), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC664EFE));
		return ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass33_, typeof(_003C_003Ec__DisplayClass33_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
	}

	public IEnumerable<IUserCertificate> GetCertificates(IUser user, Guid cryptoActionUid)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.user = user;
		_003C_003Ec__DisplayClass34_.cryptoActionUid = cryptoActionUid;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserCertificate), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33D4BB));
		return ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass34_, typeof(_003C_003Ec__DisplayClass34_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Convert(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass34_, typeof(_003C_003Ec__DisplayClass34_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), typeof(Guid?)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
	}

	public IUserCertificate GetCertificateByThumbprint(IUser user, string thumbprint)
	{
		return GetCertificateByThumbprintAndAction(user, thumbprint, AuthCryptoAction.UID);
	}

	public IUserCertificate GetCertificateByThumbprintAndAction(IUser user, string thumbprint, Guid cryptoActionUid)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass36_.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)vkX6b0M272PQMDYOlJp(MbA8MfMRqXwLEUHqvW6(typeof(IUserCertificate).TypeHandle), MptIY1MwOvjUKhLtMHV(-1586242415 ^ -1586271877));
				return ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression)RWyxAIMtTiFH9yvMTyU(RWyxAIMtTiFH9yvMTyU(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass36_, MbA8MfMRqXwLEUHqvW6(typeof(_003C_003Ec__DisplayClass36_0).TypeHandle)), (FieldInfo)GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), oI7Sy6M8tXsmZnkfij1(ikiIX4MvWnXOI0jhpOv(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), TuwMuwMowRegIevP1yM(OSkmFtMCZIxZJJeVjjV(_003C_003Ec__DisplayClass36_, typeof(_003C_003Ec__DisplayClass36_0)), GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)hxcgiVMJRXnxaJ4cjap(TuwMuwMowRegIevP1yM(OSkmFtMCZIxZJJeVjjV(_003C_003Ec__DisplayClass36_, MbA8MfMRqXwLEUHqvW6(typeof(_003C_003Ec__DisplayClass36_0).TypeHandle)), GMBDStMUa3yieJkB0lT((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), MbA8MfMRqXwLEUHqvW6(typeof(Guid?).TypeHandle)), liftToNull: false, (MethodInfo)mmvF58MPDDEQcJfIVh1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			default:
				_003C_003Ec__DisplayClass36_.thumbprint = thumbprint;
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass36_.cryptoActionUid = cryptoActionUid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<IUserCertificate> GetCertificatesByThumbprintAndAction(IUser user, string thumbprint, Guid cryptoActionUid)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.user = user;
		_003C_003Ec__DisplayClass37_.thumbprint = thumbprint;
		_003C_003Ec__DisplayClass37_.cryptoActionUid = cryptoActionUid;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserCertificate), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7A093321 ^ 0x7A0986CB));
		return ((AbstractNHEntityManager<IUserCertificate, long>)this).Find(Expression.Lambda<Func<IUserCertificate, bool>>(Expression.AndAlso(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass37_, typeof(_003C_003Ec__DisplayClass37_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass37_, typeof(_003C_003Ec__DisplayClass37_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Convert(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass37_, typeof(_003C_003Ec__DisplayClass37_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), typeof(Guid?)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
	}

	public long Count(IUser user)
	{
		InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
		instanceOf.New.User = (EleWise.ELMA.Security.Models.IUser)user;
		return HFmJXgM3p0D88aiusuv(this, instanceOf.New);
	}

	public long Count(IUser user, Guid cryptoActionUid)
	{
		InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
		b3g9c1MyOB44ZZac3l5(instanceOf.New, (EleWise.ELMA.Security.Models.IUser)user);
		instanceOf.New.CryptoActionGuid = cryptoActionUid;
		return HFmJXgM3p0D88aiusuv(this, instanceOf.New);
	}

	public bool Exists(IUser user)
	{
		InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
		b3g9c1MyOB44ZZac3l5(instanceOf.New, (EleWise.ELMA.Security.Models.IUser)user);
		return iA97BrMb1VtnI6rGSsV(this, instanceOf.New);
	}

	public bool Exists(IUser user, Guid cryptoActionUid)
	{
		InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
		instanceOf.New.User = (EleWise.ELMA.Security.Models.IUser)user;
		instanceOf.New.CryptoActionGuid = cryptoActionUid;
		return iA97BrMb1VtnI6rGSsV(this, instanceOf.New);
	}

	private void AuditCheckDigitalSignature(LoginAuditContainer auditContainer)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				AdG96MMSh35kLxVea9Q(DigitalSignatureEventHandler, auditContainer);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (DigitalSignatureEventHandler == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public UserCertificateManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zcNygTM98t5sY3KJ4qX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qq6kh7MxttBEGZP3Oa1()
	{
		return nIhoISMZqiB8KONmWR8 == null;
	}

	internal static UserCertificateManager kes1UXMBgvvsXNwPRB3()
	{
		return nIhoISMZqiB8KONmWR8;
	}

	internal static void zFqjDsMuaWAtoT9o4Wg(object P_0)
	{
		((IVerifyResult)P_0).ThrowIfNotVerified();
	}

	internal static object LD7AAOMm2FBm2NP3vM5(object P_0)
	{
		return ((IVerifyResult)P_0).Signer;
	}

	internal static object JuyTiHMeuQnHeJHAGJW(object P_0)
	{
		return ((ISigner)P_0).RawData;
	}

	internal static Guid HYQl4UMLnVH88qmxkAg(object P_0)
	{
		return ((CryptoProviderServiceBase<IAuthCryptoProvider>)P_0).GetCurrentUserProviderUid();
	}

	internal static void WTMNvxMjyg7B8YFs1WV(object P_0, object P_1, object P_2, Guid providerUid)
	{
		((UserCertificateManager)P_0).SignInByCertificate((string)P_1, (string)P_2, providerUid);
	}

	internal static object BMofjoMHlZf4wsHFM7Q(object P_0, object P_1, object P_2, bool P_3, Guid P_4)
	{
		return ((CryptoProviderServiceBase<IAuthCryptoProvider>)P_0).CheckSignature((string)P_1, (string)P_2, P_3, P_4);
	}

	internal static bool S77iPbMab5QNylbSaKQ(object P_0)
	{
		return ((IVerifyResult)P_0).Verified;
	}

	internal static Type MbA8MfMRqXwLEUHqvW6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object MptIY1MwOvjUKhLtMHV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vkX6b0M272PQMDYOlJp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object mmvF58MPDDEQcJfIVh1(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ikiIX4MvWnXOI0jhpOv(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object OSkmFtMCZIxZJJeVjjV(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object GMBDStMUa3yieJkB0lT(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object TuwMuwMowRegIevP1yM(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object hxcgiVMJRXnxaJ4cjap(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object BmJwk9MK4MCC7cBwAvh(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static object RWyxAIMtTiFH9yvMTyU(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object zqbgrCMhZZ0iyUxbJgy(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object MJtPg7MOvIiQjuSNT9L(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void cHlN0GMqXuQMXuqqi9u(object P_0, object P_1)
	{
		((LoginAuditContainer)P_0).User = (IUser)P_1;
	}

	internal static object VxKnNcMcRT7wi4kHRZ7(object P_0)
	{
		return ((IUserCertificate)P_0).User;
	}

	internal static Guid qXlyyKMG0Pwpvmi4GV5(object P_0, object P_1)
	{
		return ((CryptoProviderServiceBase<IAuthCryptoProvider>)P_0).GetUserProviderUid((EleWise.ELMA.Security.Models.IUser)P_1);
	}

	internal static bool eA7ToPMFbt2acveGSdj(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object w0dLFIM0FbGlTURjfgG(object P_0)
	{
		return ((IVerifyResult)P_0).Error;
	}

	internal static void TJlUtDMEZ8wILh30m4x(object P_0, object P_1)
	{
		((IVerifyResult)P_0).Error = (string)P_1;
	}

	internal static object TIm7AbMD9qXk34aFgO5(object P_0)
	{
		return ((IUserCertificate)P_0).Thumbprint;
	}

	internal static object Hq1fnhMM7E7snpkHBnt(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void zw8KLUMsdk2C8CTg9pT(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object o8jNUhMYXuFSGxeURBt(object P_0, object P_1, object P_2, object P_3, Guid cryptoActionUid)
	{
		return ((UserCertificateManager)P_0).RegisterCertificateByThumbprint((string)P_1, (string)P_2, (EleWise.ELMA.Security.Models.IUser)P_3, cryptoActionUid);
	}

	internal static object GW9NmrMIYibe5t9CVyp(object P_0, object P_1, object P_2, object P_3, Guid cryptoActionUid, bool isDefault)
	{
		return ((UserCertificateManager)P_0).RegisterCertificateBySignature((string)P_1, (string)P_2, (EleWise.ELMA.Security.Models.IUser)P_3, cryptoActionUid, isDefault);
	}

	internal static Guid GfrGQhM4mnkrcHCmdhd(object P_0, object P_1)
	{
		return ((ICryptoProviderServiceBase)P_0).GetUserProviderUid((EleWise.ELMA.Security.Models.IUser)P_1);
	}

	internal static object IVhtoaMVvg72e3Kq7vN(object P_0, object P_1, object P_2, bool checkSignatureOnly, Guid providerUid)
	{
		return ((ICryptoProviderServiceBase)P_0).CheckSignature((string)P_1, (string)P_2, checkSignatureOnly, providerUid);
	}

	internal static object v9n2aAMQCqvomtqJVnm(object P_0)
	{
		return ((ISigner)P_0).Name;
	}

	internal static bool QFKwoGMd3XseL6fuD7H(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static void dGIhkKMTdQ7Vga6C5fC(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object FOWmNqMgENqq92hvNFq(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object oI7Sy6M8tXsmZnkfij1(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object Xd5IOhMrk4698VelC1F(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static long HFmJXgM3p0D88aiusuv(object P_0, object P_1)
	{
		return ((AbstractNHEntityManager<IUserCertificate, long>)P_0).Count((IEntityFilter)P_1);
	}

	internal static void b3g9c1MyOB44ZZac3l5(object P_0, object P_1)
	{
		((IUserCertificateFilter)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static bool iA97BrMb1VtnI6rGSsV(object P_0, object P_1)
	{
		return ((EntityManager<IUserCertificate, long>)P_0).Exists((IEntityFilter)P_1);
	}

	internal static void AdG96MMSh35kLxVea9Q(object P_0, object P_1)
	{
		((ILoginDigitalSignatureEventHandler)P_0).CheckDigitalSignature((LoginAuditContainer)P_1);
	}

	internal static void zcNygTM98t5sY3KJ4qX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

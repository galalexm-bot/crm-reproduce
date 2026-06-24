using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service]
public abstract class CryptoProviderServiceBase<T> : ICryptoProviderServiceBase where T : ICryptoProviderBase
{
	internal static object UrEV59wI1gCQP9oKcyq;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
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

	public IContextBoundVariableService ContextBoundVariableService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextBoundVariableService_003Ek__BackingField;
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
					_003CContextBoundVariableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IComponentManager ComponentManager
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentManager_003Ek__BackingField;
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
					_003CComponentManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
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

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IDigitalSignatureType> DigitalSignatureTypes { get; set; }

	public virtual IEnumerable<T> Providers => ComponentManager.GetExtensionPoints<T>();

	public abstract T DefaultProvider { get; }

	public abstract IDigitalSignatureType DefaultDigitalSignatureType { get; }

	public virtual Guid DefaultProviderUid
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 3;
			int num2 = num;
			T defaultProvider = default(T);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return defaultProvider.ProviderUid;
				default:
					return Guid.Empty;
				case 2:
					defaultProvider = DefaultProvider;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (DefaultProvider != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				}
			}
		}
	}

	public virtual Guid DefaultDigitalSignatureTypeUid
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
					if (DefaultDigitalSignatureType == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
						{
							num2 = 0;
						}
						break;
					}
					return DefaultDigitalSignatureType.Uid;
				default:
					return Guid.Empty;
				}
			}
		}
	}

	private Guid? CurrentProviderUid
	{
		get
		{
			return ContextBoundVariableService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x161D602), (Func<Guid?>)(() => null));
		}
		set
		{
			ContextBoundVariableService.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D113AB), value);
		}
	}

	public virtual T GetProviderByUid(Guid providerUid)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.providerUid = providerUid;
		if (CurrentProviderUid.HasValue)
		{
			CS_0024_003C_003E8__locals0.providerUid = CurrentProviderUid.Value;
		}
		return ComponentManager.GetExtensionPoints<T>().FirstOrDefault((T p) => p.ProviderUid.Equals(CS_0024_003C_003E8__locals0.providerUid));
	}

	public virtual string GetUserProviderName(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		T userProvider = default(T);
		while (true)
		{
			switch (num2)
			{
			case 1:
				userProvider = GetUserProvider(user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return string.Empty;
			}
			if (userProvider == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return userProvider.DisplayName;
		}
	}

	public virtual T GetUserProvider(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetUserProvider(user, onlyProfile: false);
	}

	public abstract T GetUserProvider(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile);

	public virtual T GetCurrentUserProvider()
	{
		return GetCurrentUserProvider(onlyProfile: false);
	}

	public virtual T GetCurrentUserProvider(bool onlyProfile)
	{
		return GetUserProvider((EleWise.ELMA.Security.Models.IUser)AuthenticationService.GetCurrentUser(), onlyProfile);
	}

	public virtual Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetUserProviderUid(user, onlyProfile: false);
	}

	public virtual Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
	{
		int num = 1;
		int num2 = num;
		T userProvider = default(T);
		while (true)
		{
			switch (num2)
			{
			case 1:
				userProvider = GetUserProvider(user, onlyProfile);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return Guid.Empty;
			}
			if (userProvider == null)
			{
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return userProvider.ProviderUid;
		}
	}

	public virtual Guid GetCurrentUserProviderUid()
	{
		return GetCurrentUserProviderUid(onlyProfile: false);
	}

	public virtual Guid GetCurrentUserProviderUid(bool onlyProfile)
	{
		return GetUserProviderUid((EleWise.ELMA.Security.Models.IUser)AuthenticationService.GetCurrentUser(), onlyProfile);
	}

	public IEnumerable<IDigitalSignatureType> GetDigitalSignatureTypes()
	{
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
		CS_0024_003C_003E8__locals0.uids = Providers.Select((T p) => p.ProviderUid);
		return DigitalSignatureTypes.Where((IDigitalSignatureType dst) => dst.Providers.Intersect(CS_0024_003C_003E8__locals0.uids).Any());
	}

	public virtual IEnumerable<IDigitalSignatureType> GetDigitalSignatureTypesByProviderUid(Guid providerUid)
	{
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals0.providerUid = providerUid;
		return DigitalSignatureTypes.Where((IDigitalSignatureType t) => t.Providers.Contains(CS_0024_003C_003E8__locals0.providerUid));
	}

	public virtual Guid GetUserDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetUserDigitalSignatureTypeUid(user, onlyProfile: false);
	}

	public abstract IDigitalSignatureType GetUserDigitalSignatureType(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile);

	public virtual IDigitalSignatureType GetDigitalSignatureType(Guid providerUid, Guid digitalSignatureTypeUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass44_.digitalSignatureTypeUid = digitalSignatureTypeUid;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass44_.providerUid = providerUid;
				num2 = 3;
				break;
			case 2:
				return DigitalSignatureTypes.Where(_003C_003Ec__DisplayClass44_._003CGetDigitalSignatureType_003Eb__0).FirstOrDefault(_003C_003Ec__DisplayClass44_._003CGetDigitalSignatureType_003Eb__1);
			}
		}
	}

	public virtual string GetDigitalSignatureTypeName(Guid? providerUid, Guid? digitalSignatureTypeUid)
	{
		if (!digitalSignatureTypeUid.HasValue || !providerUid.HasValue)
		{
			return string.Empty;
		}
		IDigitalSignatureType digitalSignatureType = GetDigitalSignatureType(providerUid.Value, digitalSignatureTypeUid.Value);
		if (digitalSignatureType == null)
		{
			return string.Empty;
		}
		return digitalSignatureType.DisplayName;
	}

	public virtual IDigitalSignatureType GetCurrentUserDigitalSignatureType()
	{
		int num = 1;
		int num2 = num;
		Guid currentUserDigitalSignatureTypeUid = default(Guid);
		Guid currentUserProviderUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				currentUserDigitalSignatureTypeUid = GetCurrentUserDigitalSignatureTypeUid(onlyProfile: false);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				currentUserProviderUid = GetCurrentUserProviderUid(onlyProfile: false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return GetDigitalSignatureType(currentUserProviderUid, currentUserDigitalSignatureTypeUid);
			}
		}
	}

	public virtual Guid GetCurrentUserDigitalSignatureTypeUid()
	{
		return GetCurrentUserDigitalSignatureTypeUid(onlyProfile: false);
	}

	public virtual Guid GetCurrentUserDigitalSignatureTypeUid(bool onlyProfile)
	{
		return GetUserDigitalSignatureTypeUid((EleWise.ELMA.Security.Models.IUser)AuthenticationService.GetCurrentUser(), onlyProfile);
	}

	public virtual Guid GetUserDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
	{
		int num = 1;
		int num2 = num;
		IDigitalSignatureType userDigitalSignatureType = default(IDigitalSignatureType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Guid.Empty;
			case 1:
				userDigitalSignatureType = GetUserDigitalSignatureType(user, onlyProfile);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (userDigitalSignatureType != null)
			{
				return userDigitalSignatureType.Uid;
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly)
	{
		return CheckSignature(text, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>(), out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, Guid providerUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string encoding;
			switch (num2)
			{
			case 1:
				encoding = "";
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return CheckSignature(text, signature, checkSignatureOnly, providerUid, out encoding);
			}
		}
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string encoding;
			switch (num2)
			{
			default:
				return CheckSignature(text, signature, checkSignatureOnly, user, out encoding);
			case 1:
				encoding = "";
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, Guid providerUid, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, null, providerUid, out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, user, null, out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid, out string encoding)
	{
		return CheckSignature(text, SignatureToBytes(signature), checkSignatureOnly, user, providerUid, out encoding);
	}

	public virtual IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly)
	{
		return CheckSignature(content, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	public virtual IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly, Guid providerUid)
	{
		return CheckSignature(content, SignatureToBytes(signature), checkSignatureOnly, providerUid);
	}

	public virtual IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user)
	{
		return CheckSignature(content, SignatureToBytes(signature), checkSignatureOnly, user);
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>(), out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, user, null, out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid, out string encoding)
	{
		return CheckSignature(text, signature, checkSignatureOnly, null, providerUid, out encoding);
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid, string encoding)
	{
		return CheckSignature(Encoding.GetEncoding(encoding).GetBytes(text), signature, checkSignatureOnly, null, providerUid);
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid, out string encoding)
	{
		encoding = null;
		try
		{
			string text2 = "";
			string text3 = "";
			IVerifyResult verifyResult = CheckSignature(Encoding.UTF8.GetBytes(text), signature, checkSignatureOnly, user, providerUid);
			if (verifyResult.Verified)
			{
				encoding = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-731479136 ^ -731458098);
				return verifyResult;
			}
			text2 = verifyResult.Error;
			IVerifyResult verifyResult2 = CheckSignature(Encoding.Unicode.GetBytes(text), signature, checkSignatureOnly, user, providerUid);
			if (verifyResult2.Verified)
			{
				encoding = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B3775B9);
				return verifyResult2;
			}
			text3 = verifyResult2.Error;
			Logger.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B056A9C ^ 0x3B053C10), text2, text3));
			verifyResult2.Error = text3;
			return verifyResult2;
		}
		catch (Exception ex)
		{
			Logger.Error(ex);
			return VerifyResult.Fail(ex.Message);
		}
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly)
	{
		return CheckSignature(text, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string encoding;
			switch (num2)
			{
			case 1:
				encoding = "";
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return CheckSignature(text, signature, checkSignatureOnly, null, providerUid, out encoding);
			}
		}
	}

	public virtual IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string encoding;
			switch (num2)
			{
			case 1:
				encoding = "";
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return CheckSignature(text, signature, checkSignatureOnly, user, null, out encoding);
			}
		}
	}

	public virtual IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly)
	{
		return CheckSignature(content, signature, checkSignatureOnly, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	public virtual IVerifyResult CheckSignature(BinaryFile file, string signature, bool checkSignatureOnly)
	{
		return CheckSignature(BinaryFileBytes(file), signature, checkSignatureOnly);
	}

	public virtual IVerifyResult CheckSignature(BinaryFile file, byte[] signature, bool checkSignatureOnly, Guid providerUid)
	{
		return CheckSignature(BinaryFileBytes(file), signature, checkSignatureOnly, providerUid);
	}

	public virtual IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user)
	{
		return CheckSignature(content, signature, checkSignatureOnly, user, null);
	}

	public virtual IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, Guid providerUid)
	{
		return CheckSignature(content, signature, checkSignatureOnly, null, providerUid);
	}

	public virtual IVerifyResult CheckSignature(BinaryFile file, string signature, bool checkSignatureOnly, Guid providerUid)
	{
		return CheckSignature(BinaryFileBytes(file), signature, checkSignatureOnly, providerUid);
	}

	public virtual IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid)
	{
		try
		{
			if (signature.Length == 0)
			{
				return VerifyResult.Fail(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1329706983 ^ -1329717535)));
			}
			T val = (providerUid.HasValue ? GetProviderByUid(providerUid.Value) : ((user == null) ? GetCurrentUserProvider() : GetUserProvider(user)));
			if (val == null)
			{
				return VerifyResult.Fail(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D760956)));
			}
			IVerifyResult verifyResult = val.Verify(content, signature, checkSignatureOnly);
			if (verifyResult != null && string.IsNullOrEmpty(verifyResult.ProviderName))
			{
				verifyResult.ProviderName = val.DisplayName;
			}
			return verifyResult;
		}
		catch (Exception ex)
		{
			Logger.Error(ex);
			return VerifyResult.Fail(ex.Message);
		}
	}

	public void RunWithProvider(Guid? providerUid, Action action)
	{
		Guid? currentProviderUid = CurrentProviderUid;
		CurrentProviderUid = providerUid;
		try
		{
			action();
		}
		finally
		{
			CurrentProviderUid = currentProviderUid;
		}
	}

	protected byte[] SignatureToBytes(string signature)
	{
		//Discarded unreachable code: IL_006d, IL_00a0, IL_00e2, IL_00f1
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = new byte[0];
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return array;
			}
			try
			{
				array = Convert.FromBase64String(signature);
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => array, 
					_ => array, 
				};
			}
			catch (Exception message)
			{
				int num4 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						Logger.Error(message);
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
						{
							num4 = 0;
						}
						break;
					default:
						return array;
					case 0:
						return array;
					}
				}
			}
		}
	}

	protected byte[] BinaryFileBytes(BinaryFile file)
	{
		//Discarded unreachable code: IL_004c, IL_0086, IL_00be, IL_00f6, IL_0105, IL_0131, IL_0173, IL_0182
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return array;
			case 1:
				array = new byte[0];
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Stream content = file.GetContent();
				int num3 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num3 = 1;
				}
				switch (num3)
				{
				case 1:
					try
					{
						array = content.ReadAllBytes();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
						{
							num4 = 0;
						}
						return num4 switch
						{
							0 => array, 
							_ => array, 
						};
					}
					finally
					{
						if (content != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									((IDisposable)content).Dispose();
									num5 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				default:
					return array;
				case 0:
					return array;
				}
			}
			catch (Exception message)
			{
				int num6 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num6 = 1;
				}
				while (true)
				{
					switch (num6)
					{
					case 1:
						Logger.Error(message);
						num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
						{
							num6 = 0;
						}
						break;
					default:
						return array;
					case 0:
						return array;
					}
				}
			}
		}
	}

	protected CryptoProviderServiceBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wBd5Mkw4aXKmQHBTRjf()
	{
		return UrEV59wI1gCQP9oKcyq == null;
	}

	internal static object ShIHsQwVLqeTkFUyRPu()
	{
		return UrEV59wI1gCQP9oKcyq;
	}
}

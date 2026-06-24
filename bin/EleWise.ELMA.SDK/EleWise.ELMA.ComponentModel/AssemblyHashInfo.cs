using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel;

[Serializable]
public class AssemblyHashInfo
{
	internal static AssemblyHashInfo JyJXcwfE2gHOJTd8mPOp;

	public string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string HashCode
	{
		[CompilerGenerated]
		get
		{
			return _003CHashCode_003Ek__BackingField;
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
					_003CHashCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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

	public void EvaluteHashCode(string fileName)
	{
		//Discarded unreachable code: IL_004b, IL_0083, IL_00a2, IL_00b1, IL_00ce, IL_00dd
		int num = 2;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					EvaluteHashCode(fileStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num4 = 0;
						}
						goto IL_0087;
					}
					goto IL_00bc;
					IL_00bc:
					TWKhxLfE18qUBsfoPLdD(fileStream);
					num4 = 2;
					goto IL_0087;
					IL_0087:
					switch (num4)
					{
					default:
						goto end_IL_0062;
					case 0:
						goto end_IL_0062;
					case 1:
						break;
					case 2:
						goto end_IL_0062;
					}
					goto IL_00bc;
					end_IL_0062:;
				}
			case 0:
				return;
			case 2:
				fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void EvaluteMD5(string fileName)
	{
		//Discarded unreachable code: IL_004b, IL_0083, IL_00bb, IL_00ca
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				EvaluteMD5(fileStream);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				if (fileStream != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							TWKhxLfE18qUBsfoPLdD(fileStream);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void EvaluteHashCode(Stream stream)
	{
		//Discarded unreachable code: IL_006e, IL_00d1, IL_0109, IL_0118
		int num = 1;
		int num2 = num;
		SHA512 sHA = default(SHA512);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sHA = SHA512.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				byte[] inArray = (byte[])RXxHeEfENgVLCUEZ15MZ(sHA, stream);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					HashCode = Convert.ToBase64String(inArray);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				if (sHA != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							TWKhxLfE18qUBsfoPLdD(sHA);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void EvaluteMD5(Stream stream)
	{
		//Discarded unreachable code: IL_0078, IL_00b0, IL_00e8, IL_00f7
		int num = 1;
		int num2 = num;
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				HashCode = (string)h4PJJQfE3KV8kB6h2IZP(RXxHeEfENgVLCUEZ15MZ(mD5CryptoServiceProvider, stream));
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				if (mD5CryptoServiceProvider != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							((IDisposable)mD5CryptoServiceProvider).Dispose();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void EvaluteHashCode(byte[] assemblyRaw)
	{
		//Discarded unreachable code: IL_006f, IL_00e5, IL_00f4, IL_0121, IL_0130
		int num = 2;
		int num2 = num;
		SHA512 sHA = default(SHA512);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sHA = (SHA512)hDp3elfEpZkrIlCfT8qT();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					byte[] inArray = (byte[])PB7leofEa3TbY1wMtBwb(sHA, assemblyRaw);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						HashCode = Convert.ToBase64String(inArray);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num5;
					if (sHA == null)
					{
						int num4 = 2;
						num5 = num4;
						goto IL_00ca;
					}
					goto IL_00ff;
					IL_00ca:
					switch (num5)
					{
					default:
						goto end_IL_00b1;
					case 2:
						goto end_IL_00b1;
					case 1:
						break;
					case 0:
						goto end_IL_00b1;
					}
					goto IL_00ff;
					IL_00ff:
					TWKhxLfE18qUBsfoPLdD(sHA);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num5 = 0;
					}
					goto IL_00ca;
					end_IL_00b1:;
				}
			}
		}
	}

	public void EvaluteHashCode(Assembly asm)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00d8, IL_00e7
		int num = 5;
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return;
				case 2:
				case 6:
					EvaluteHashCode(array);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					array = (byte[])RTTssKfEDEkWSuXr7FPV(asm);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (array != null)
					{
						num = 6;
						break;
					}
					goto case 1;
				case 3:
					if (uF5iS7fE4emvPJwX8HP4(IYATExfEtuGjRP23M088(asm)))
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 1:
					if (!HIBEVBfEwnC7kKWLnho6(IYATExfEtuGjRP23M088(asm)))
					{
						num = 3;
						break;
					}
					goto default;
				default:
					throw new InvalidOperationException(SR.T((string)XC7ncEfE6pUeThDMbmZ4(0x35C0467B ^ 0x35C24C89), asm.FullName));
				case 7:
					EvaluteHashCode((string)IYATExfEtuGjRP23M088(asm));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public AssemblyHashInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool N9TE1wfEeCYeEunG5mto()
	{
		return JyJXcwfE2gHOJTd8mPOp == null;
	}

	internal static AssemblyHashInfo zb5uZFfEPoEChM73x3eU()
	{
		return JyJXcwfE2gHOJTd8mPOp;
	}

	internal static void TWKhxLfE18qUBsfoPLdD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object RXxHeEfENgVLCUEZ15MZ(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object h4PJJQfE3KV8kB6h2IZP(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object hDp3elfEpZkrIlCfT8qT()
	{
		return SHA512.Create();
	}

	internal static object PB7leofEa3TbY1wMtBwb(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object RTTssKfEDEkWSuXr7FPV(object P_0)
	{
		return ComponentManager.GetLoadedAssemblyRaw((Assembly)P_0);
	}

	internal static object IYATExfEtuGjRP23M088(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool HIBEVBfEwnC7kKWLnho6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool uF5iS7fE4emvPJwX8HP4(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object XC7ncEfE6pUeThDMbmZ4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}

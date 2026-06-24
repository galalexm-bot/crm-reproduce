using System;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Component]
internal sealed class FunctionScriptModuleType : IScriptModuleType
{
	internal const string Arg = "arg";

	internal const string ArgIndent = "            ";

	internal const int MaxTypesLengthThreshold = 91;

	public const string VoidType = "void";

	public const string UidS = "{8A29ABCF-70F0-4561-A3D1-22DAD6C1575F}";

	public static readonly Guid UID;

	internal static FunctionScriptModuleType UdqDK0bVzCAYDRLOlvCP;

	public Guid Uid => UID;

	public string Name => (string)be6lQYbSoqgPmCnHlMKo(lwZOnhbSWURUD7i0lI1K(-2106517564 ^ -2106348512));

	public string GenerateSourceCode(object parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(parameters is FunctionMetadata functionMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)vbVGy6bSbqf6Enqse269(functionMetadata);
			default:
				return string.Empty;
			}
		}
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	internal static string GenerateSourceCode(FunctionMetadata functionMetadata)
	{
		//Discarded unreachable code: IL_00fd, IL_023a
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 12:
				hqUgHNbShXDyeBTcVTCy(_003C_003Ec__DisplayClass12_.functionMetadata, lwZOnhbSWURUD7i0lI1K(0x10E41EDB ^ 0x10E6A2C3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass12_.paramType = GetTypeName((TypeSignature)syejNgbSErYtD31lcIHn(_003C_003Ec__DisplayClass12_.functionMetadata));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass12_.functionMetadata = functionMetadata;
				num2 = 12;
				break;
			default:
				_003C_003Ec__DisplayClass12_.returnType = GetTypeName((TypeSignature)wiNLCobSGHPbpMYy66Cy(_003C_003Ec__DisplayClass12_.functionMetadata));
				num2 = 6;
				break;
			case 5:
			case 10:
				stringBuilder = (StringBuilder)h2Qjy9bSCrNQHXaPJwb8(h2Qjy9bSCrNQHXaPJwb8(qWSlPubSQLqY3BFPexT7(new StringBuilder(), _003C_003Ec__DisplayClass12_.paramType), lwZOnhbSWURUD7i0lI1K(-1334993905 ^ -1334979283)), lwZOnhbSWURUD7i0lI1K(0x463A0F3C ^ 0x4638AAB0));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 3;
				break;
			case 2:
				if (!YghLUsbSf86apkmvLuQT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870737909), _003C_003Ec__DisplayClass12_.paramType))
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 11:
				HArUKcbS8xK3RNiU3vos(HArUKcbS8xK3RNiU3vos(stringBuilder, 0, lwZOnhbSWURUD7i0lI1K(-675505729 ^ -675404297)), 0, jN8btGbSZOseZGLaqU9V());
				num2 = 7;
				break;
			case 9:
				_003C_003Ec__DisplayClass12_.paramType = "";
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass12_.paramType = stringBuilder.ToString();
				num2 = 13;
				break;
			case 1:
			case 13:
				return ResourceTemplateGenerator.GenerateTemplate<FunctionScriptModuleType>((string)lwZOnhbSWURUD7i0lI1K(0x20261A4F ^ 0x2024A62B), _003C_003Ec__DisplayClass12_._003CGenerateSourceCode_003Eb__0);
			case 8:
				if (iEFHmFbSvJSSXYS4Xrop(_003C_003Ec__DisplayClass12_.paramType) + iEFHmFbSvJSSXYS4Xrop(_003C_003Ec__DisplayClass12_.returnType) > 91)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	internal static string GetTypeName(TypeSignature typeSignature, ICollection<string> ignoreNamespaces = null)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.typeSignature = typeSignature;
		if (CS_0024_003C_003E8__locals0.typeSignature.TypeUid == Guid.Empty)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951339558);
		}
		CS_0024_003C_003E8__locals0.typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(CS_0024_003C_003E8__locals0.typeSignature.TypeUid, CS_0024_003C_003E8__locals0.typeSignature.SubTypeUid) as ITypeGenerationInfo;
		if (CS_0024_003C_003E8__locals0.typeDescriptor == null)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D8E2E);
		}
		CS_0024_003C_003E8__locals0.fakeMetadata = new ClassMetadata();
		CS_0024_003C_003E8__locals0.propertyMetadata = new PropertyMetadata
		{
			TypeUid = CS_0024_003C_003E8__locals0.typeSignature.TypeUid,
			SubTypeUid = CS_0024_003C_003E8__locals0.typeSignature.SubTypeUid,
			Nullable = CS_0024_003C_003E8__locals0.typeSignature.Nullable
		};
		if (ignoreNamespaces == null)
		{
			ignoreNamespaces = Array.Empty<string>();
		}
		string text = ignoreNamespaces.WithIgnoreNamespaces(delegate
		{
			//Discarded unreachable code: IL_00e1, IL_00f0, IL_012a, IL_0139
			int num = 1;
			int num2 = num;
			PropertyMetadata propertyMetadata = default(PropertyMetadata);
			ITypeGenerationInfo typeGenerationInfo = default(ITypeGenerationInfo);
			while (true)
			{
				switch (num2)
				{
				case 5:
				{
					PropertyMetadata propertyMetadata2 = new PropertyMetadata();
					_003C_003Ec__DisplayClass13_0.oFBq5NCPs1VsMPSchBij(propertyMetadata2, _003C_003Ec__DisplayClass13_0.OUPOBaCPLJtTP6awKVNP(CS_0024_003C_003E8__locals0.typeSignature));
					propertyMetadata2.Nullable = _003C_003Ec__DisplayClass13_0.CjDSXmCPchZr54e2EUjb(CS_0024_003C_003E8__locals0.typeSignature);
					propertyMetadata = propertyMetadata2;
					num2 = 3;
					break;
				}
				case 2:
					if ((typeGenerationInfo = _003C_003Ec__DisplayClass13_0.JrB701CPU9S0CuHE35U1(_003C_003Ec__DisplayClass13_0.s1LAo3CPYSrquXdBgdGT(), _003C_003Ec__DisplayClass13_0.OUPOBaCPLJtTP6awKVNP(CS_0024_003C_003E8__locals0.typeSignature), Guid.Empty) as ITypeGenerationInfo) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 5;
				case 1:
					if (!_003C_003Ec__DisplayClass13_0.OvFhIKCPjDHD7MlFnAdI(_003C_003Ec__DisplayClass13_0.qPhcZlCP5bCGGDEkZAKu(CS_0024_003C_003E8__locals0.typeSignature), ListOfSimpleTypeDescriptor.UID))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return (ISyntaxNode)_003C_003Ec__DisplayClass13_0.KTJu75CPzPGYYNgejyXb(typeGenerationInfo, CS_0024_003C_003E8__locals0.fakeMetadata, propertyMetadata, false);
				default:
					return CS_0024_003C_003E8__locals0.typeDescriptor.GetPropertyTypeReference(CS_0024_003C_003E8__locals0.fakeMetadata, CS_0024_003C_003E8__locals0.propertyMetadata, forFilter: false);
				}
			}
		}).ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98003692), "");
		if (CS_0024_003C_003E8__locals0.typeSignature.RelationType != 0)
		{
			return text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AE5FD3);
		}
		return text;
	}

	public FunctionScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FunctionScriptModuleType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -476037041));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				BYd1MLbSu9fKmIMmAyXH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object lwZOnhbSWURUD7i0lI1K(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object be6lQYbSoqgPmCnHlMKo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool DxRfg9bSFuq3v75l631s()
	{
		return UdqDK0bVzCAYDRLOlvCP == null;
	}

	internal static FunctionScriptModuleType SZd0qDbSBETMY9MYIjav()
	{
		return UdqDK0bVzCAYDRLOlvCP;
	}

	internal static object vbVGy6bSbqf6Enqse269(object P_0)
	{
		return GenerateSourceCode((FunctionMetadata)P_0);
	}

	internal static void hqUgHNbShXDyeBTcVTCy(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object wiNLCobSGHPbpMYy66Cy(object P_0)
	{
		return ((FunctionMetadata)P_0).ReturnType;
	}

	internal static object syejNgbSErYtD31lcIHn(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static bool YghLUsbSf86apkmvLuQT(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object qWSlPubSQLqY3BFPexT7(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object h2Qjy9bSCrNQHXaPJwb8(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int iEFHmFbSvJSSXYS4Xrop(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object HArUKcbS8xK3RNiU3vos(object P_0, int P_1, object P_2)
	{
		return ((StringBuilder)P_0).Insert(P_1, (string)P_2);
	}

	internal static object jN8btGbSZOseZGLaqU9V()
	{
		return Environment.NewLine;
	}

	internal static void BYd1MLbSu9fKmIMmAyXH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

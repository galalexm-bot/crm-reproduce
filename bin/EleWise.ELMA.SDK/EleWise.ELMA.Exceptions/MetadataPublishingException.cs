using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class MetadataPublishingException : Exception
{
	internal static MetadataPublishingException wG0efAGjFed0ufFG8Rel;

	public ScriptCompileResult ScriptCompileResult
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptCompileResult_003Ek__BackingField;
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
					_003CScriptCompileResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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

	public MetadataItemValidationError[] ValidationErrors
	{
		[CompilerGenerated]
		get
		{
			return _003CValidationErrors_003Ek__BackingField;
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
					_003CValidationErrors_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	private static string DefaultMessage => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410939939));

	public MetadataPublishingException(Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		mZpXYdGjocTFbBXH3mMl();
		base._002Ector((string)wbapkaGjbnw4SFSl73CV(), innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishingException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		mZpXYdGjocTFbBXH3mMl();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishingException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		mZpXYdGjocTFbBXH3mMl();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishingException(ScriptCompileResult scriptCompileResult)
	{
		//Discarded unreachable code: IL_005f, IL_0064
		mZpXYdGjocTFbBXH3mMl();
		base._002Ector((string)wbapkaGjbnw4SFSl73CV() + (string)KIN4EeGjh1BvQEEldNS5(-1487388570 ^ -1487394766) + (string)HiR2NUGjGb3S3cUGSYAI(KIN4EeGjh1BvQEEldNS5(-70037984 ^ -69999544)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ScriptCompileResult = scriptCompileResult;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
		}
	}

	protected MetadataPublishingException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		mZpXYdGjocTFbBXH3mMl();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ValidationErrors = (MetadataItemValidationError[])EJVNoxGjf0xOCXatLK6m(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886607549), SV2FPjGjEYZUWq0wAatl(typeof(MetadataItemValidationError[]).TypeHandle));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				ScriptCompileResult = (ScriptCompileResult)info.GetValue((string)KIN4EeGjh1BvQEEldNS5(0x57A5235E ^ 0x57A589FC), SV2FPjGjEYZUWq0wAatl(typeof(ScriptCompileResult).TypeHandle));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.GetObjectData(info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				KODxcWGjQLM3xpYCAK4F(info, KIN4EeGjh1BvQEEldNS5(-1146510045 ^ -1146548241), ValidationErrors);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			default:
				info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD5FAF2), ScriptCompileResult);
				num2 = 3;
				break;
			}
		}
	}

	internal static void mZpXYdGjocTFbBXH3mMl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wbapkaGjbnw4SFSl73CV()
	{
		return DefaultMessage;
	}

	internal static bool F8KtKcGjBOuejMU1FYmj()
	{
		return wG0efAGjFed0ufFG8Rel == null;
	}

	internal static MetadataPublishingException CRGovLGjWBymfFtwOqnJ()
	{
		return wG0efAGjFed0ufFG8Rel;
	}

	internal static object KIN4EeGjh1BvQEEldNS5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HiR2NUGjGb3S3cUGSYAI(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type SV2FPjGjEYZUWq0wAatl(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object EJVNoxGjf0xOCXatLK6m(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void KODxcWGjQLM3xpYCAK4F(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}

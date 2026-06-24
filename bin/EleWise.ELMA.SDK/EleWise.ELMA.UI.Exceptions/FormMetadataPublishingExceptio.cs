using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Exceptions;

[Serializable]
public class FormMetadataPublishingException : Exception
{
	internal static FormMetadataPublishingException z9oUoZMbyiXashwCGyY;

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
				case 0:
					return;
				case 1:
					_003CScriptCompileResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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

	private static string DefaultMessage => (string)MPsXuPMC4dE9fqCyHNL(ORFrXWMQb6PtfJS2D4C(0x3A5D5EF ^ 0x3A57F1F));

	public FormMetadataPublishingException(Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		avNUPdMEYum37swU6il();
		base._002Ector(DefaultMessage, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FormMetadataPublishingException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		avNUPdMEYum37swU6il();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FormMetadataPublishingException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		avNUPdMEYum37swU6il();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FormMetadataPublishingException(ScriptCompileResult scriptCompileResult)
	{
		//Discarded unreachable code: IL_0059, IL_005e
		avNUPdMEYum37swU6il();
		base._002Ector((string)pysorLMfchfIMnL5oI2() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36C35D) + (string)MPsXuPMC4dE9fqCyHNL(ORFrXWMQb6PtfJS2D4C(-138018305 ^ -137974889)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
			{
				num = 1;
			}
		}
	}

	protected FormMetadataPublishingException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		avNUPdMEYum37swU6il();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				ValidationErrors = (MetadataItemValidationError[])FZQ05qMvlblsPw2EpHR(info, ORFrXWMQb6PtfJS2D4C(-882126494 ^ -882148434), Yx940CM8rHBqSu7Rv2j(typeof(MetadataItemValidationError[]).TypeHandle));
				num = 2;
				continue;
			}
			ScriptCompileResult = (ScriptCompileResult)FZQ05qMvlblsPw2EpHR(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A749E8), typeof(ScriptCompileResult));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num = 1;
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
				Th4oJ4MZ8EIM1Z0HF6y(this, info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				gKVrJRMujwAv5dCUcGo(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE52C8), ScriptCompileResult);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				gKVrJRMujwAv5dCUcGo(info, ORFrXWMQb6PtfJS2D4C(-629844702 ^ -629800978), ValidationErrors);
				num2 = 3;
				break;
			}
		}
	}

	internal static void avNUPdMEYum37swU6il()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OaQmAnMhcdarUwZOTSY()
	{
		return z9oUoZMbyiXashwCGyY == null;
	}

	internal static FormMetadataPublishingException wjrtZxMGIjZAyh0urTu()
	{
		return z9oUoZMbyiXashwCGyY;
	}

	internal static object pysorLMfchfIMnL5oI2()
	{
		return DefaultMessage;
	}

	internal static object ORFrXWMQb6PtfJS2D4C(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MPsXuPMC4dE9fqCyHNL(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object FZQ05qMvlblsPw2EpHR(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static Type Yx940CM8rHBqSu7Rv2j(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void Th4oJ4MZ8EIM1Z0HF6y(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void gKVrJRMujwAv5dCUcGo(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}

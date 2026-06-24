using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model;

[Serializable]
[DataContract]
public sealed class ActionValue
{
	internal static ActionValue cZFMvRWgE9HRRsb92Vvi;

	[DataMember]
	[DefaultValue("")]
	public string MethodName
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodName_003Ek__BackingField;
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
					_003CMethodName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
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

	[DataMember]
	public Guid FunctionHeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CFunctionHeaderUid_003Ek__BackingField;
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
					_003CFunctionHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(CodeType.Client)]
	[DataMember]
	public CodeType CodeType
	{
		[CompilerGenerated]
		get
		{
			return _003CCodeType_003Ek__BackingField;
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
					_003CCodeType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctionHeaderUid()
	{
		return XeOwW0WgCcnl9KSBKDQ4(FunctionHeaderUid, Guid.Empty);
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_00f2
		int num = 1;
		int num2 = num;
		ActionValue actionValue = default(ActionValue);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (RbfEs9WgvQPxAocRyoRc(actionValue) == CodeType)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 2:
				if (!gyRTniWgZFjpjOHxnOQj(iwPgklWg863I2GqOyVRP(actionValue), FunctionHeaderUid))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 4:
				return BgcdmOWgImGxLAf5YneO(qDvPa0WgueJVtoRG22Jv(actionValue), MethodName);
			default:
				return false;
			case 1:
				if ((actionValue = obj as ActionValue) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public ActionValue()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		l6nisHWgVoUNbR8OIJMH();
		MethodName = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UoeKf4WgftqdAvip8d05()
	{
		return cZFMvRWgE9HRRsb92Vvi == null;
	}

	internal static ActionValue gunm0rWgQ4BCNlvWctE9()
	{
		return cZFMvRWgE9HRRsb92Vvi;
	}

	internal static bool XeOwW0WgCcnl9KSBKDQ4(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static CodeType RbfEs9WgvQPxAocRyoRc(object P_0)
	{
		return ((ActionValue)P_0).CodeType;
	}

	internal static Guid iwPgklWg863I2GqOyVRP(object P_0)
	{
		return ((ActionValue)P_0).FunctionHeaderUid;
	}

	internal static bool gyRTniWgZFjpjOHxnOQj(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object qDvPa0WgueJVtoRG22Jv(object P_0)
	{
		return ((ActionValue)P_0).MethodName;
	}

	internal static bool BgcdmOWgImGxLAf5YneO(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void l6nisHWgVoUNbR8OIJMH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

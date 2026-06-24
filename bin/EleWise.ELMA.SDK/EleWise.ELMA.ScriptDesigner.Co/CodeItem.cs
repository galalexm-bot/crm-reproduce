using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
[Component]
public abstract class CodeItem : ICodeItem, IXsiType
{
	internal Guid? uid;

	private static CodeItem ohFxYiiZg0DQCwRB76r;

	[XmlElement("Name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Uid")]
	public virtual Guid Uid
	{
		get
		{
			//Discarded unreachable code: IL_004f, IL_005e
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (!uid.HasValue)
						{
							break;
						}
						goto end_IL_0012;
					default:
						return uid.Value;
					case 1:
						break;
					}
					uid = Guid.NewGuid();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}
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
					uid = value;
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

	public virtual void InitNew(ICodeItem parent)
	{
		//Discarded unreachable code: IL_0047, IL_0056
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				j2MiFqiRU7WYWQxkJIn(this, cE8igSiigHlcujHgptW());
				num2 = 3;
				break;
			case 1:
				return;
			case 3:
				return;
			case 2:
				if (!CuiemCiSHN5obC6KI8A(xNOIOjiVvQoMDw0iGFp(this), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public abstract bool IsValidParent(ICodeItem codeItem);

	public abstract CodeStatement ToCodeStatement();

	public abstract CodeExpression ToCodeExpression();

	public abstract CodeStatement[] ToCodeStatementList();

	public abstract List<Type> GetValidToInsert();

	protected CodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		y2y5mYiq02wudypYElH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rErTWDiu5dA97Fasxlf()
	{
		return ohFxYiiZg0DQCwRB76r == null;
	}

	internal static CodeItem mBDcXbiIS6yGP7AFI4F()
	{
		return ohFxYiiZg0DQCwRB76r;
	}

	internal static Guid xNOIOjiVvQoMDw0iGFp(object P_0)
	{
		return ((CodeItem)P_0).Uid;
	}

	internal static bool CuiemCiSHN5obC6KI8A(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid cE8igSiigHlcujHgptW()
	{
		return Guid.NewGuid();
	}

	internal static void j2MiFqiRU7WYWQxkJIn(object P_0, Guid value)
	{
		((CodeItem)P_0).Uid = value;
	}

	internal static void y2y5mYiq02wudypYElH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

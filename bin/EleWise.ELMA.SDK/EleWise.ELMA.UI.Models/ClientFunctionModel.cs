using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class ClientFunctionModel : ICloneable
{
	private static ClientFunctionModel Atu4evBWZn6ayny0cbv2;

	[DataMember]
	public Guid HeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderUid_003Ek__BackingField;
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
					_003CHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ModuleItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleItemUid_003Ek__BackingField;
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
					_003CModuleItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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

	public object Clone()
	{
		ClientFunctionModel clientFunctionModel = new ClientFunctionModel();
		ydwOkrBWVsRWut2FYXjM(clientFunctionModel, HeaderUid);
		NCRWpQBWSsRN87MUey48(clientFunctionModel, ItemUid);
		P77SZTBWiU1txBBMZ0B5(clientFunctionModel, ModuleItemUid);
		bOiOlYBWRAOuwVIH3xja(clientFunctionModel, ModuleUid);
		return clientFunctionModel;
	}

	public ClientFunctionModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ToFc8lBWq6NSBNfDUQNu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xCHg7UBWucx5mpThpZeD()
	{
		return Atu4evBWZn6ayny0cbv2 == null;
	}

	internal static ClientFunctionModel XFOGLTBWIUHud01cMCFh()
	{
		return Atu4evBWZn6ayny0cbv2;
	}

	internal static void ydwOkrBWVsRWut2FYXjM(object P_0, Guid value)
	{
		((ClientFunctionModel)P_0).HeaderUid = value;
	}

	internal static void NCRWpQBWSsRN87MUey48(object P_0, Guid value)
	{
		((ClientFunctionModel)P_0).ItemUid = value;
	}

	internal static void P77SZTBWiU1txBBMZ0B5(object P_0, Guid value)
	{
		((ClientFunctionModel)P_0).ModuleItemUid = value;
	}

	internal static void bOiOlYBWRAOuwVIH3xja(object P_0, Guid value)
	{
		((ClientFunctionModel)P_0).ModuleUid = value;
	}

	internal static void ToFc8lBWq6NSBNfDUQNu()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

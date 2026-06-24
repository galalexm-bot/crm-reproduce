using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Nodes;

[Serializable]
public class SchemaNode
{
	private List<SchemaNode> childs;

	private static SchemaNode tLyLdGWLAYaGgfDN82QL;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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

	public SchemaNode Parent
	{
		[CompilerGenerated]
		get
		{
			return _003CParent_003Ek__BackingField;
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
					_003CParent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsRoot => Parent == null;

	public IEnumerable<SchemaNode> Childs => childs;

	public void AddChild(SchemaNode node)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				childs.Add(node);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sHkIA7WL0BU530hsvRkZ(node, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void AddChilds(IEnumerable<SchemaNode> nodes)
	{
		nodes.ForEach(AddChild);
	}

	public SchemaNode()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		iUMJHsWLmTtHccFMi85o();
		childs = new List<SchemaNode>();
		base._002Ector();
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

	internal static bool Qqbh1mWL72OpuKjvgAlJ()
	{
		return tLyLdGWLAYaGgfDN82QL == null;
	}

	internal static SchemaNode TM6hoQWLxmkm4sfNouJU()
	{
		return tLyLdGWLAYaGgfDN82QL;
	}

	internal static void sHkIA7WL0BU530hsvRkZ(object P_0, object P_1)
	{
		((SchemaNode)P_0).Parent = (SchemaNode)P_1;
	}

	internal static void iUMJHsWLmTtHccFMi85o()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

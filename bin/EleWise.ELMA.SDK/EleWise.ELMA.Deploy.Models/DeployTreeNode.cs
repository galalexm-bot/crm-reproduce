using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Models;

public sealed class DeployTreeNode
{
	private static DeployTreeNode CJITjJEwgHF8FM2dKJvp;

	public string Id { get; }

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return _003CText_003Ek__BackingField;
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
					_003CText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public string Icon { get; }

	public ICollection<DeployTreeNode> Children { get; }

	public int Count
	{
		[CompilerGenerated]
		get
		{
			return _003CCount_003Ek__BackingField;
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
					_003CCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsDirtyItem
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDirtyItem_003Ek__BackingField;
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
					_003CIsDirtyItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsPublished
	{
		[CompilerGenerated]
		get
		{
			return _003CIsPublished_003Ek__BackingField;
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
					_003CIsPublished_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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

	public DeployTreeNode(string id, string text, string icon, bool isDirtyItem, bool isPublished, ICollection<DeployTreeNode> children)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Id = id;
		Text = text;
		Icon = icon;
		Children = children ?? new List<DeployTreeNode>();
		IsDirtyItem = isDirtyItem;
		IsPublished = isPublished;
	}

	public DeployTreeNode(string id, string text, string icon)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		AxCbFBEwYVHg4atICyv4();
		this._002Ector(id, text, icon, isDirtyItem: false, isPublished: true, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DeployTreeNode(string id, string text, string icon, ICollection<DeployTreeNode> children = null)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(id, text, icon, isDirtyItem: false, isPublished: true, children);
	}

	public DeployTreeNode(string id, string text, string icon, bool isDirtyItem, bool isPublished)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		AxCbFBEwYVHg4atICyv4();
		this._002Ector(id, text, icon, isDirtyItem, isPublished, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void AxCbFBEwYVHg4atICyv4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fqMLV5Ew5dN7nAtgMXx1()
	{
		return CJITjJEwgHF8FM2dKJvp == null;
	}

	internal static DeployTreeNode L6cDsWEwjuvmky3xb8OI()
	{
		return CJITjJEwgHF8FM2dKJvp;
	}
}

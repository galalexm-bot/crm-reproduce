using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

[Serializable]
[Component]
public class ToolbarItem : IXsiType
{
	internal Guid? uid;

	private bool visible;

	private static ToolbarItem UrP5Lrotg1A76f9SGNUk;

	[XmlElement("Uid")]
	public virtual Guid Uid
	{
		get
		{
			//Discarded unreachable code: IL_0081, IL_0090
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (uid.HasValue)
					{
						num2 = 2;
						break;
					}
					goto default;
				default:
					uid = Guid.NewGuid();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
				case 2:
					return uid.Value;
				}
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[XmlIgnore]
	public RootToolbarItem Parent
	{
		[CompilerGenerated]
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CParent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

	[DefaultValue(true)]
	public virtual bool Visible
	{
		get
		{
			return visible;
		}
		set
		{
			int num = 2;
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
					visible = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					SetVisible = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	internal bool SetVisible
	{
		[CompilerGenerated]
		get
		{
			return _003CSetVisible_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CSetVisible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public virtual string Name
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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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

	public List<ComputedValue> DynamicProperties { get; set; }

	public ToolbarItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rJNdVpotYHrHLeowUfym();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				visible = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void OnAdding(RootToolbarItem parent)
	{
	}

	public virtual void OnAdded(RootToolbarItem parent)
	{
	}

	public virtual void OnRemoving(RootToolbarItem parent)
	{
	}

	public virtual void OnRemoved(RootToolbarItem parent)
	{
	}

	internal static void rJNdVpotYHrHLeowUfym()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool oXBduuot5W4jfDeWifu0()
	{
		return UrP5Lrotg1A76f9SGNUk == null;
	}

	internal static ToolbarItem zuw7QUotj9xFficKvRIr()
	{
		return UrP5Lrotg1A76f9SGNUk;
	}
}

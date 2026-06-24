using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews;

[XmlRoot("TiffPagesDescriptor")]
public class TiffPagesDescriptor
{
	internal static TiffPagesDescriptor spVlmBGNUjXNs9Vc8dc5;

	[XmlElement("Width")]
	public int Width
	{
		[CompilerGenerated]
		get
		{
			return _003CWidth_003Ek__BackingField;
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
					_003CWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	[XmlElement("Height")]
	public int Height
	{
		[CompilerGenerated]
		get
		{
			return _003CHeight_003Ek__BackingField;
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
					_003CHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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

	[XmlArray]
	public List<string> FileNames { get; set; }

	public TiffPagesDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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
			FileNames = new List<string>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
			{
				num = 0;
			}
		}
	}

	internal static bool fh1LvlGNsOAUODySugDF()
	{
		return spVlmBGNUjXNs9Vc8dc5 == null;
	}

	internal static TiffPagesDescriptor ilAqOBGNcLaYuI92hgiS()
	{
		return spVlmBGNUjXNs9Vc8dc5;
	}
}

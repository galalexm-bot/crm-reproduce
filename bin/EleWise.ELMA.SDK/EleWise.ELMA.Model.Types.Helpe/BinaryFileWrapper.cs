using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("BinaryFileValue")]
public class BinaryFileWrapper : IXsiType
{
	internal static BinaryFileWrapper FWHW1oboAupKW4AvNF4O;

	[XmlElement("Id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("SecondId")]
	public string SecondId
	{
		[CompilerGenerated]
		get
		{
			return _003CSecondId_003Ek__BackingField;
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
					_003CSecondId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BinaryFileWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lxVhDHbo0XwdaAtD4qx1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BinaryFileWrapper(BinaryFile file)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		lxVhDHbo0XwdaAtD4qx1();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				SecondId = (string)ywP8yTboykSkgDvnFI9M(file);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				Id = (string)kZ3hSEbomrm8XQtInQx9(file);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool LFnVsTbo7yecYwV7bE7m()
	{
		return FWHW1oboAupKW4AvNF4O == null;
	}

	internal static BinaryFileWrapper GPshqQboxmRDRJHVRECv()
	{
		return FWHW1oboAupKW4AvNF4O;
	}

	internal static void lxVhDHbo0XwdaAtD4qx1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object kZ3hSEbomrm8XQtInQx9(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object ywP8yTboykSkgDvnFI9M(object P_0)
	{
		return ((BinaryFile)P_0).SecondId;
	}
}

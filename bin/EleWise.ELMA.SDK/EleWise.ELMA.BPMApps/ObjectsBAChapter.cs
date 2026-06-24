using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

public class ObjectsBAChapter : BPMAppManifestChapter
{
	internal static ObjectsBAChapter Iqwe5wfk97WyMTbReAxP;

	[XmlArray("Catalogs")]
	[DefaultValue(null)]
	public List<EntityBAItem> Catalogs { get; set; }

	[XmlArray("SysCatalogs")]
	[DefaultValue(null)]
	public List<EntityBAItem> SysCatalogs { get; set; }

	[DefaultValue(null)]
	[XmlArray("Enums")]
	public List<EnumBAItem> Enums { get; set; }

	[XmlArray("DataClasses")]
	[DefaultValue(null)]
	public List<DataClassBAItem> DataClasses { get; set; }

	public ObjectsBAChapter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ITbYVZfkrAAaR7tJw2Nd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ITbYVZfkrAAaR7tJw2Nd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YR1594fkdQo9e2nJcXIZ()
	{
		return Iqwe5wfk97WyMTbReAxP == null;
	}

	internal static ObjectsBAChapter i0KHIIfkltHnUy2od32G()
	{
		return Iqwe5wfk97WyMTbReAxP;
	}
}

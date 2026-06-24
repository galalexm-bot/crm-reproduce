using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.Types;

[Serializable]
public class ScriptWebReferencesNHType : XmlSerializableType<List<ScriptWebReference>>
{
	public class Container
	{
		internal static Container dPMYa6C3wMIVgU8lKEh5;

		public List<ScriptWebReference> Items { get; set; }

		public Container()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			tIVyB0C3HEdlMK7Edrax();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void tIVyB0C3HEdlMK7Edrax()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool QdOUmVC34Ua5N7D0J3Gc()
		{
			return dPMYa6C3wMIVgU8lKEh5 == null;
		}

		internal static Container MFdn2IC36EotyZa2SZh3()
		{
			return dPMYa6C3wMIVgU8lKEh5;
		}
	}

	public class Convention : AutoRegisterUserTypeConvention<ScriptWebReferencesNHType>
	{
		internal static Convention WqIL0YC3A5juJgmu7X2k;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool g0IXw4C37GS3ngHdOeJc()
		{
			return WqIL0YC3A5juJgmu7X2k == null;
		}

		internal static Convention Xww1OnC3xfQjYLrbDnXf()
		{
			return WqIL0YC3A5juJgmu7X2k;
		}
	}

	internal static ScriptWebReferencesNHType I1W8Skbk0PQOOK4TK5dg;

	protected override void SaveObjectToStream(Stream stream, List<ScriptWebReference> obj)
	{
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(new Container
		{
			Items = obj
		}, writer, useComponentManager: false);
	}

	protected override List<ScriptWebReference> LoadObjectFromStream(Stream stream)
	{
		using XmlReader reader = XmlReader.Create(stream);
		return ((Container)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<Container>.Raw, reader, useComponentManager: false))?.Items;
	}

	public ScriptWebReferencesNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gwCdXqbkMaeYMukTeTF6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void gwCdXqbkMaeYMukTeTF6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rPOec2bkmdlRTnAEfvU4()
	{
		return I1W8Skbk0PQOOK4TK5dg == null;
	}

	internal static ScriptWebReferencesNHType zaCSeBbkyKRUHCxHZ46u()
	{
		return I1W8Skbk0PQOOK4TK5dg;
	}
}

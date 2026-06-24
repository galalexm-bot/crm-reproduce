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
public class AssemblyReferenceNHType : XmlSerializableType<List<AssemblyReference>>
{
	public class Container
	{
		internal static Container MDG9e1C3hgBZgLcVpFvM;

		public List<AssemblyReference> Items { get; set; }

		public Container()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			p7S4gkC3f7dBewlxEbkX();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void p7S4gkC3f7dBewlxEbkX()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sscPZUC3GXSV3CHnbnoa()
		{
			return MDG9e1C3hgBZgLcVpFvM == null;
		}

		internal static Container Uu2bw5C3Ewhy76qOsmwG()
		{
			return MDG9e1C3hgBZgLcVpFvM;
		}
	}

	public class Convention : AutoRegisterUserTypeConvention<AssemblyReferenceNHType>
	{
		internal static Convention AkqkukC3Qa2rW1C6PA4Q;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			i0I8wjC38Y3cqY6lnYfg();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void i0I8wjC38Y3cqY6lnYfg()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sjcwrPC3CIqSlEn3so2A()
		{
			return AkqkukC3Qa2rW1C6PA4Q == null;
		}

		internal static Convention fNb8YOC3vJSOJGAgiYZH()
		{
			return AkqkukC3Qa2rW1C6PA4Q;
		}
	}

	internal static AssemblyReferenceNHType OlR5UfbTa7ufwpSBWskk;

	protected override void SaveObjectToStream(Stream stream, List<AssemblyReference> obj)
	{
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(new Container
		{
			Items = obj
		}, writer);
	}

	protected override List<AssemblyReference> LoadObjectFromStream(Stream stream)
	{
		using XmlReader reader = XmlReader.Create(stream);
		return ((Container)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<Container>.Raw, reader))?.Items;
	}

	public AssemblyReferenceNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qw8TkobTwW0bjvLkqTUE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void qw8TkobTwW0bjvLkqTUE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jR5W99bTDjL8992Aoky6()
	{
		return OlR5UfbTa7ufwpSBWskk == null;
	}

	internal static AssemblyReferenceNHType tY1oX4bTtAcQYFIrvyMd()
	{
		return OlR5UfbTa7ufwpSBWskk;
	}
}

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
public class ScriptMethodDeclarationNHType : XmlSerializableType<List<ScriptMethodDeclaration>>
{
	public class Container
	{
		internal static Container XRDb1eCNcxEvi4lO2jpg;

		public List<ScriptMethodDeclaration> Items { get; set; }

		public Container()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			GkJpIFC3B5BMh4rXHOwG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void GkJpIFC3B5BMh4rXHOwG()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool WQRnUwCNzAowF35oqNNX()
		{
			return XRDb1eCNcxEvi4lO2jpg == null;
		}

		internal static Container M4GMtMC3FpOJJLMGn1PL()
		{
			return XRDb1eCNcxEvi4lO2jpg;
		}
	}

	public class Convention : AutoRegisterUserTypeConvention<ScriptMethodDeclarationNHType>
	{
		internal static Convention M22sqoC3WJFsFdi42B0b;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool spbXLeC3oNWRYnMpiHy7()
		{
			return M22sqoC3WJFsFdi42B0b == null;
		}

		internal static Convention v8aXxKC3bDNssFmyAwNe()
		{
			return M22sqoC3WJFsFdi42B0b;
		}
	}

	internal static ScriptMethodDeclarationNHType MCuHjWbTZAiFr8LAp4dP;

	protected override void SaveObjectToStream(Stream stream, List<ScriptMethodDeclaration> obj)
	{
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(new Container
		{
			Items = obj
		}, writer, useComponentManager: false);
	}

	protected override List<ScriptMethodDeclaration> LoadObjectFromStream(Stream stream)
	{
		using XmlReader reader = XmlReader.Create(stream);
		return ((Container)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<Container>.Raw, reader, useComponentManager: false))?.Items;
	}

	public ScriptMethodDeclarationNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Bm07LDbTVV6oNm3BU8he();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Bm07LDbTVV6oNm3BU8he()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QXKjv3bTuibelJXdMueJ()
	{
		return MCuHjWbTZAiFr8LAp4dP == null;
	}

	internal static ScriptMethodDeclarationNHType ABkF75bTInmqqiRorPWG()
	{
		return MCuHjWbTZAiFr8LAp4dP;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
public sealed class TypeToMap
{
	private static TypeToMap h7OTaVb1a643i98evPMp;

	[XmlElement("FullTypeName")]
	[DataMember]
	public string FullTypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTypeName_003Ek__BackingField;
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
					_003CFullTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TypeToMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SQidYEb1wHEQPRuJpOub();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cMCnAbb1DSaKSm6Fuh6K()
	{
		return h7OTaVb1a643i98evPMp == null;
	}

	internal static TypeToMap FYuMtsb1t21r7TXnrNLI()
	{
		return h7OTaVb1a643i98evPMp;
	}

	internal static void SQidYEb1wHEQPRuJpOub()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

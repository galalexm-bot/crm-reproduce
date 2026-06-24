using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Rebranding;

[XmlRoot("RebrandingStrings")]
public class RebrandingStrings
{
	public class RebrandingString
	{
		internal static RebrandingString D5bP1dfM8VJ8MqnTHXal;

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return _003CKey_003Ek__BackingField;
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
						_003CKey_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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

		public string Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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

		public RebrandingString()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			CrwfOEfMI1wMNol4PY1B();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ANOvc6fMZwRJmxHZhfOq()
		{
			return D5bP1dfM8VJ8MqnTHXal == null;
		}

		internal static RebrandingString fjqgJNfMuYMo7v5AiWwT()
		{
			return D5bP1dfM8VJ8MqnTHXal;
		}

		internal static void CrwfOEfMI1wMNol4PY1B()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static RebrandingStrings hKr08hPZ3dC4ngvP88S;

	[XmlArray]
	[DataMember]
	[XmlArrayItem("String")]
	public List<RebrandingString> Strings { get; set; }

	public RebrandingStrings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qA5cWJPVfnuQiXdnAAq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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
			Strings = new List<RebrandingString>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void qA5cWJPVfnuQiXdnAAq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool w9e7QYPu0vV5DZ2se6p()
	{
		return hKr08hPZ3dC4ngvP88S == null;
	}

	internal static RebrandingStrings b7HmMMPIdGBuUnk9XsD()
	{
		return hKr08hPZ3dC4ngvP88S;
	}
}

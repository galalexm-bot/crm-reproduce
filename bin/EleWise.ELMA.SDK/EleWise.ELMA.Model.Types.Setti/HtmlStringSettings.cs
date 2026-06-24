using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class HtmlStringSettings : SimpleTypeSettings, IHasDefaultValue<string>
{
	internal static HtmlStringSettings GfBogQozYp5a6wZWm5ir;

	[XmlElement("DefaultValue")]
	[JsonSerializationIgnore]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Delta)]
	public string DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать кнопку \"ELMA\"')")]
	[DefaultValue(true)]
	public bool NeedButtonELMA
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedButtonELMA_003Ek__BackingField;
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
					_003CNeedButtonELMA_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать кнопку \"Исходный код\"')")]
	public bool NeedButtonSource
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedButtonSource_003Ek__BackingField;
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
					_003CNeedButtonSource_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public HtmlStringSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Xw9nK0ozsGCt9dtncsEe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected HtmlStringSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Xw9nK0ozsGCt9dtncsEe();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Xw9nK0ozsGCt9dtncsEe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool y8RCedozLoWTuZSAye0R()
	{
		return GfBogQozYp5a6wZWm5ir == null;
	}

	internal static HtmlStringSettings Hhscd2ozUruvD3uUOj0A()
	{
		return GfBogQozYp5a6wZWm5ir;
	}
}

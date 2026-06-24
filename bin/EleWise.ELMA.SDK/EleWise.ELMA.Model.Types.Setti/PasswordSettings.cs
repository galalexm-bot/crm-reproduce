using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class PasswordSettings : SimpleTypeSettings
{
	private static PasswordSettings BdyLKOosBNar1EaMmPSL;

	[XmlIgnore]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип хранения пароля')")]
	public Guid PasswordType
	{
		[CompilerGenerated]
		get
		{
			return _003CPasswordType_003Ek__BackingField;
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
					_003CPasswordType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[JsonSerializationIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue("")]
	[Browsable(false)]
	[XmlElement("PasswordType")]
	public string PasswordTypeStr
	{
		get
		{
			int num = 1;
			int num2 = num;
			Guid passwordType = default(Guid);
			while (true)
			{
				switch (num2)
				{
				default:
					return "";
				case 1:
					if (PasswordType != Guid.Empty)
					{
						passwordType = PasswordType;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 2:
					return passwordType.ToString();
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
				case 0:
					return;
				case 1:
					PasswordType = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PasswordSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected PasswordSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		nZuXlhosbyjFZMKEPXMm();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rDPBhUosWACXSR4SSJmp()
	{
		return BdyLKOosBNar1EaMmPSL == null;
	}

	internal static PasswordSettings VXlcqMosoSBsmZqV7yF6()
	{
		return BdyLKOosBNar1EaMmPSL;
	}

	internal static void nZuXlhosbyjFZMKEPXMm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

public class ViewItemColor
{
	internal static ViewItemColor gobC0EokduXXUmGIWYbj;

	[DefaultValue(null)]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Color? Value
	{
		get
		{
			if (string.IsNullOrEmpty(Name))
			{
				return null;
			}
			try
			{
				return ColorTranslator.FromHtml(Name);
			}
			catch
			{
				return null;
			}
		}
		set
		{
			Name = (value.HasValue ? ColorTranslator.ToHtml(value.Value) : null);
		}
	}

	public ViewItemColor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FnJlVrokgwBDsM8UJbZB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ViewItemColor(Color color)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
			Value = color;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
			{
				num = 1;
			}
		}
	}

	public static ViewItemColor FromHtml(string htmlColor)
	{
		return new ViewItemColor(ckBGGiok5lmb1Pbmp83d(htmlColor));
	}

	public ViewItemColor Clone()
	{
		ViewItemColor viewItemColor = new ViewItemColor();
		epSF51okjkXGnZbLqJOh(viewItemColor, Name);
		return viewItemColor;
	}

	internal static void FnJlVrokgwBDsM8UJbZB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Wa0JDGoklaAPUOYT11Hb()
	{
		return gobC0EokduXXUmGIWYbj == null;
	}

	internal static ViewItemColor rIRk8EokrburyFIns74P()
	{
		return gobC0EokduXXUmGIWYbj;
	}

	internal static Color ckBGGiok5lmb1Pbmp83d(object P_0)
	{
		return ColorTranslator.FromHtml((string)P_0);
	}

	internal static void epSF51okjkXGnZbLqJOh(object P_0, object P_1)
	{
		((ViewItemColor)P_0).Name = (string)P_1;
	}
}

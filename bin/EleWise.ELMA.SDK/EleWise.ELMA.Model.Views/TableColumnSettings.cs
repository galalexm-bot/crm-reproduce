using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TableColumnSettings), "DisplayName")]
public class TableColumnSettings
{
	internal static TableColumnSettings X1cYV9oe4ADWrNw98vV5;

	[XmlIgnore]
	public Unit Width
	{
		[CompilerGenerated]
		get
		{
			return _003CWidth_003Ek__BackingField;
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
					_003CWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	[XmlElement("Width")]
	[DefaultValue("")]
	public string WidthString
	{
		get
		{
			int num = 1;
			int num2 = num;
			Unit width = default(Unit);
			while (true)
			{
				switch (num2)
				{
				case 1:
					width = Width;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return width.ToString();
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
					Width = new Unit(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TableColumnSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UKQ1DCoeAK6qXHQh7JfB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jefnacoe6tWwyvRZGehj()
	{
		return X1cYV9oe4ADWrNw98vV5 == null;
	}

	internal static TableColumnSettings r420dUoeHjnQQp5YD3I5()
	{
		return X1cYV9oe4ADWrNw98vV5;
	}

	internal static void UKQ1DCoeAK6qXHQh7JfB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

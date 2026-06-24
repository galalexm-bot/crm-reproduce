using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[Component]
public struct TimeSpanHolder : IXsiType
{
	private long ticks;

	internal static object RxZyINfStnO6OUsjMfu1;

	[XmlIgnore]
	public TimeSpan Value
	{
		get
		{
			return new TimeSpan(ticks);
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
					ticks = value.Ticks;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long Ticks
	{
		get
		{
			return ticks;
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
				case 1:
					ticks = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		TimeSpan value = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			default:
				return value.ToString();
			case 1:
				value = Value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool eYrHCJfSwQPiCbBkgBb2()
	{
		return RxZyINfStnO6OUsjMfu1 == null;
	}

	internal static object z9WbR3fS4Q6P78oK1wPY()
	{
		return RxZyINfStnO6OUsjMfu1;
	}
}

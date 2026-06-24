using System;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FormAttribute : Attribute
{
	private FormViewItem form;

	private Type typeOfAssembly;

	private string resourceName;

	private static FormAttribute enhHLCoCkqoMyAVnwxt8;

	public FormViewItem Form
	{
		get
		{
			int num = 2;
			int num2 = num;
			FormViewItem formViewItem = default(FormViewItem);
			FormViewItem formViewItem2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					formViewItem = (form = (FormViewItem)NcAjH0oCeGL6d62TOcRN(typeOfAssembly, resourceName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					formViewItem2 = form;
					if (formViewItem2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					formViewItem2 = formViewItem;
					break;
				}
				break;
			}
			return formViewItem2;
		}
	}

	public FormAttribute(Type typeOfAssembly, string resourceName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vaWaP5oC23WOiASI7Hvh();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.typeOfAssembly = typeOfAssembly;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.resourceName = resourceName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static FormViewItem DeserializeForm(Type typeOfAssembly, object resourceName)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_0080, IL_008f, IL_0102, IL_013a, IL_0193, IL_01cb, IL_01da
		int num = 1;
		int num2 = num;
		Stream stream = default(Stream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		FormViewItem result = default(FormViewItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stream = (Stream)ag6eDCoCPkAeUkPSurlB(typeOfAssembly.Assembly, resourceName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (stream != null)
				{
					num3 = 3;
					goto IL_003e;
				}
				goto IL_009a;
				IL_003e:
				while (true)
				{
					switch (num3)
					{
					case 1:
					case 3:
						xmlTextReader = new XmlTextReader(stream);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						try
						{
							result = (FormViewItem)ClassSerializationHelper.DeserializeObjectByXml(ovoSEUoC1Of1r1YaJR5r(typeof(FormViewItem).TypeHandle), xmlTextReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => result, 
								_ => result, 
							};
						}
						finally
						{
							if (xmlTextReader != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										D8cJUuoCNOS8swXiSTA1(xmlTextReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					case 4:
						return result;
					}
					break;
				}
				goto IL_009a;
				IL_009a:
				result = null;
				int num6 = 4;
				num3 = num6;
				goto IL_003e;
			}
			finally
			{
				if (stream != null)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							D8cJUuoCNOS8swXiSTA1(stream);
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num7 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	internal static void vaWaP5oC23WOiASI7Hvh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IyGGHnoCnCniIT3u4IDJ()
	{
		return enhHLCoCkqoMyAVnwxt8 == null;
	}

	internal static FormAttribute NPuyKwoCOj0PayrsxOF5()
	{
		return enhHLCoCkqoMyAVnwxt8;
	}

	internal static object NcAjH0oCeGL6d62TOcRN(Type typeOfAssembly, object P_1)
	{
		return DeserializeForm(typeOfAssembly, P_1);
	}

	internal static object ag6eDCoCPkAeUkPSurlB(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceStream((string)P_1);
	}

	internal static Type ovoSEUoC1Of1r1YaJR5r(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void D8cJUuoCNOS8swXiSTA1(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}

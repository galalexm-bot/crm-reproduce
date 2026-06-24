using System;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FormTransformationAttribute : Attribute
{
	private FormViewItemTransformation transformation;

	private Type typeOfAssembly;

	private string resourceName;

	private static FormTransformationAttribute xL5npIoCtpk3MsmyMVIW;

	public FormViewItemTransformation Transformation
	{
		get
		{
			int num = 1;
			int num2 = num;
			FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
			FormViewItemTransformation formViewItemTransformation2;
			while (true)
			{
				switch (num2)
				{
				default:
					formViewItemTransformation = (transformation = (FormViewItemTransformation)XKS9yooCHVWVMK7VbofG(typeOfAssembly, resourceName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					formViewItemTransformation2 = transformation;
					if (formViewItemTransformation2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					formViewItemTransformation2 = formViewItemTransformation;
					break;
				}
				break;
			}
			return formViewItemTransformation2;
		}
	}

	public FormTransformationAttribute(Type typeOfAssembly, string resourceName)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		tciBHvoC6vt7FfIAlnDY();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.resourceName = resourceName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.typeOfAssembly = typeOfAssembly;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static FormViewItemTransformation DeserializeTransformation(Type typeOfAssembly, object resourceName)
	{
		//Discarded unreachable code: IL_0072, IL_0099, IL_00a8, IL_00b7, IL_0126, IL_0192, IL_01a1, IL_01ce, IL_01ed, IL_021d, IL_022c
		int num = 1;
		int num2 = num;
		Stream stream = default(Stream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		FormViewItemTransformation result = default(FormViewItemTransformation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stream = (Stream)XS91Z7oCAIpJGttbDu2B(typeOfAssembly.Assembly, resourceName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num3 = 0;
					}
					goto IL_0076;
				}
				goto IL_00c2;
				IL_00c2:
				result = null;
				num3 = 2;
				goto IL_0076;
				IL_0076:
				while (true)
				{
					switch (num3)
					{
					case 3:
						break;
					default:
						xmlTextReader = new XmlTextReader(stream);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
						try
						{
							result = (FormViewItemTransformation)ClassSerializationHelper.DeserializeObjectByXml(wKAZ1eoC7f9uBXB3bep1(typeof(FormViewItemTransformation).TypeHandle), xmlTextReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
							int num6;
							if (xmlTextReader == null)
							{
								int num5 = 2;
								num6 = num5;
								goto IL_0156;
							}
							goto IL_016c;
							IL_0156:
							switch (num6)
							{
							case 2:
								goto end_IL_013d;
							case 1:
								goto end_IL_013d;
							}
							goto IL_016c;
							IL_016c:
							gffGZWoCxboKbCUDk0a9(xmlTextReader);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num6 = 0;
							}
							goto IL_0156;
							end_IL_013d:;
						}
					case 2:
						return result;
					}
					break;
				}
				goto IL_00c2;
			}
			finally
			{
				int num7;
				if (stream == null)
				{
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num7 = 0;
					}
					goto IL_01d2;
				}
				goto IL_01fb;
				IL_01fb:
				gffGZWoCxboKbCUDk0a9(stream);
				num7 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num7 = 1;
				}
				goto IL_01d2;
				IL_01d2:
				switch (num7)
				{
				default:
					goto end_IL_01ad;
				case 0:
					goto end_IL_01ad;
				case 2:
					break;
				case 1:
					goto end_IL_01ad;
				}
				goto IL_01fb;
				end_IL_01ad:;
			}
		}
	}

	internal static void tciBHvoC6vt7FfIAlnDY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FiveUQoCwjoZTRW59poZ()
	{
		return xL5npIoCtpk3MsmyMVIW == null;
	}

	internal static FormTransformationAttribute xPfAALoC4Xt79aS905T1()
	{
		return xL5npIoCtpk3MsmyMVIW;
	}

	internal static object XKS9yooCHVWVMK7VbofG(Type typeOfAssembly, object P_1)
	{
		return DeserializeTransformation(typeOfAssembly, P_1);
	}

	internal static object XS91Z7oCAIpJGttbDu2B(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceStream((string)P_1);
	}

	internal static Type wKAZ1eoC7f9uBXB3bep1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void gffGZWoCxboKbCUDk0a9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}

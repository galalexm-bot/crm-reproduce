using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

[Serializable]
public class RootCodeItemCollectionNH : XmlSerializableType<RootCodeItemCollection>
{
	[Component]
	public class Container : IXsiRoot
	{
		private static Container e4O0TVfxFZinURDf0qGw;

		public RootCodeItemCollection RootItem
		{
			[CompilerGenerated]
			get
			{
				return _003CRootItem_003Ek__BackingField;
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
						_003CRootItem_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

		public Container()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			vs9CTbfxodrSR5fNjOtt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool OHtvc2fxBKMheY0glfgI()
		{
			return e4O0TVfxFZinURDf0qGw == null;
		}

		internal static Container gertiqfxWD8p6eQgMq42()
		{
			return e4O0TVfxFZinURDf0qGw;
		}

		internal static void vs9CTbfxodrSR5fNjOtt()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class Convention : AutoRegisterUserTypeConvention<RootCodeItemCollectionNH>
	{
		private static Convention hSVUd2fxbyEF8HeKa10K;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			f1XcUYfxEuW0Tgfr4UjI();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void f1XcUYfxEuW0Tgfr4UjI()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool mPcEsSfxhMlF0CKyuopn()
		{
			return hSVUd2fxbyEF8HeKa10K == null;
		}

		internal static Convention kxRrXQfxGjmdM61LrQCs()
		{
			return hSVUd2fxbyEF8HeKa10K;
		}
	}

	internal static RootCodeItemCollectionNH r5MmFEZY1VG0r9kCigk;

	protected override void SaveObjectToStream(Stream stream, RootCodeItemCollection obj)
	{
		//Discarded unreachable code: IL_0079, IL_00b1, IL_00d0, IL_0100, IL_010f
		int num = 2;
		int num2 = num;
		XmlWriter xmlWriter = default(XmlWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				xmlWriter = XmlWriter.Create(stream);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					ClassSerializationHelper.SerializeObjectByXml(new Container
					{
						RootItem = obj
					}, xmlWriter);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (xmlWriter == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num4 = 0;
						}
						goto IL_00b5;
					}
					goto IL_00de;
					IL_00de:
					eJtNm5ZsnrRclDgHJ77(xmlWriter);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num4 = 1;
					}
					goto IL_00b5;
					IL_00b5:
					switch (num4)
					{
					default:
						goto end_IL_0090;
					case 0:
						goto end_IL_0090;
					case 2:
						break;
					case 1:
						goto end_IL_0090;
					}
					goto IL_00de;
					end_IL_0090:;
				}
			case 0:
				return;
			}
		}
	}

	protected override RootCodeItemCollection LoadObjectFromStream(Stream stream)
	{
		//Discarded unreachable code: IL_005c, IL_0094, IL_00b3, IL_00c2, IL_00ef, IL_00fe
		int num = 2;
		int num2 = num;
		XmlTextReader xmlTextReader = default(XmlTextReader);
		RootCodeItemCollection result = default(RootCodeItemCollection);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					result = ((Container)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<Container>.Raw, xmlTextReader)).RootItem;
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					int num4;
					if (xmlTextReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num4 = 0;
						}
						goto IL_0098;
					}
					goto IL_00cd;
					IL_00cd:
					eJtNm5ZsnrRclDgHJ77(xmlTextReader);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num4 = 1;
					}
					goto IL_0098;
					IL_0098:
					switch (num4)
					{
					default:
						goto end_IL_0073;
					case 0:
						goto end_IL_0073;
					case 2:
						break;
					case 1:
						goto end_IL_0073;
					}
					goto IL_00cd;
					end_IL_0073:;
				}
			case 2:
				xmlTextReader = new XmlTextReader(stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	public RootCodeItemCollectionNH()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MdUGWSZcTnwLfYrxOlW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void eJtNm5ZsnrRclDgHJ77(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool zcN1hFZLqE3swKFkO5Q()
	{
		return r5MmFEZY1VG0r9kCigk == null;
	}

	internal static RootCodeItemCollectionNH tTrAkUZUtuNR3HdS3lE()
	{
		return r5MmFEZY1VG0r9kCigk;
	}

	internal static void MdUGWSZcTnwLfYrxOlW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

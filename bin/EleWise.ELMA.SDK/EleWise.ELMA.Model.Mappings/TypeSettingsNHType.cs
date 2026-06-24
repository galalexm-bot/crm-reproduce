using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

[Serializable]
public class TypeSettingsNHType : XmlSerializableType<TypeSettings>
{
	public class Convention : AutoRegisterUserTypeConvention<TypeSettingsNHType>
	{
		private static Convention YEqLB6CrHXOvSk4EMnjk;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			eE3i3vCrx70x7xSnWYxH();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void eE3i3vCrx70x7xSnWYxH()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool gLtRkLCrA6C2qFLrrCaL()
		{
			return YEqLB6CrHXOvSk4EMnjk == null;
		}

		internal static Convention JkskBECr7wjs3V2dNpyS()
		{
			return YEqLB6CrHXOvSk4EMnjk;
		}
	}

	private static ConcurrentDictionary<string, Type> settingsTypes;

	private static TypeSettingsNHType NIBfndhhEySYDQ3ojsLf;

	protected override void SaveObjectToStream(Stream stream, TypeSettings obj)
	{
		//Discarded unreachable code: IL_0056, IL_00b3, IL_00db, IL_00fa, IL_0109, IL_0157, IL_018f, IL_019e
		int num = 1;
		int num2 = num;
		StreamWriter streamWriter = default(StreamWriter);
		XmlWriter xmlWriter = default(XmlWriter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				streamWriter = new StreamWriter(stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				xPSnT3hhCdIGR8G2u93H(streamWriter, obj.GetType().Name);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						xmlWriter = (XmlWriter)RmCyQohhv7j0ZrZ1MNWq(streamWriter);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						ClassSerializationHelper.SerializeObjectByXml(obj, xmlWriter);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num5;
						if (xmlWriter == null)
						{
							num5 = 2;
							goto IL_00df;
						}
						goto IL_0114;
						IL_00df:
						switch (num5)
						{
						default:
							goto end_IL_00ca;
						case 2:
							goto end_IL_00ca;
						case 1:
							break;
						case 0:
							goto end_IL_00ca;
						}
						goto IL_0114;
						IL_0114:
						p8lJI2hh8l09EBvE3ebk(xmlWriter);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num5 = 0;
						}
						goto IL_00df;
						end_IL_00ca:;
					}
				}
			}
			finally
			{
				if (streamWriter != null)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							p8lJI2hh8l09EBvE3ebk(streamWriter);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num6 = 1;
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

	protected override TypeSettings LoadObjectFromStream(Stream stream)
	{
		return (TypeSettings)XGV75JhhZbKncT40MLiP(stream);
	}

	public static TypeSettings LoadTypeSettings(Stream stream)
	{
		//Discarded unreachable code: IL_005e, IL_012b, IL_0163, IL_01bc, IL_01db, IL_0207, IL_0216
		int num = 1;
		int num2 = num;
		StreamReader streamReader = default(StreamReader);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		Type orAdd = default(Type);
		TypeSettings result = default(TypeSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				streamReader = new StreamReader(stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				string key = (string)WlZ3o2hhuZfU9KE4FhC3(streamReader);
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					case 2:
						xmlTextReader = new XmlTextReader(streamReader);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						streamReader.CheckAndCorrectInternalBOMSymbols();
						num3 = 2;
						continue;
					case 3:
						orAdd = settingsTypes.GetOrAdd(key, delegate(string name)
						{
							int num7 = 2;
							int num8 = num7;
							_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
							while (true)
							{
								switch (num8)
								{
								case 1:
									_003C_003Ec__DisplayClass3_.name = name;
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num8 = 0;
									}
									break;
								case 2:
									_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num8 = 0;
									}
									break;
								default:
								{
									Type type = ((IEnumerable<Type>)_003C_003Ec.d0sGZYCrjmec1pis0uB7(_003C_003Ec.ULmJFVCr5PCObIVnolYb())).Where((Type t) => _003C_003Ec.hCldELCrLx7qD8tZYSp2(typeof(TypeSettings).TypeHandle).IsAssignableFrom(t)).FirstOrDefault(_003C_003Ec__DisplayClass3_._003CLoadTypeSettings_003Eb__2);
									if (_003C_003Ec.JsnTXsCrYaoIOcF2LJqW(type, null))
									{
										throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1B5ABA), _003C_003Ec__DisplayClass3_.name));
									}
									return type;
								}
								}
							}
						});
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num3 = 1;
						}
						continue;
					}
					try
					{
						result = (TypeSettings)ClassSerializationHelper.DeserializeObjectByXml(orAdd, xmlTextReader);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									((IDisposable)xmlTextReader).Dispose();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
				}
			}
			finally
			{
				int num6;
				if (streamReader == null)
				{
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num6 = 1;
					}
					goto IL_01c0;
				}
				goto IL_01e5;
				IL_01e5:
				p8lJI2hh8l09EBvE3ebk(streamReader);
				num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num6 = 0;
				}
				goto IL_01c0;
				IL_01c0:
				switch (num6)
				{
				default:
					goto end_IL_019b;
				case 1:
					goto end_IL_019b;
				case 2:
					break;
				case 0:
					goto end_IL_019b;
				}
				goto IL_01e5;
				end_IL_019b:;
			}
		}
	}

	public TypeSettingsNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fxck99hhI7AEt8KSQEe1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TypeSettingsNHType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				fxck99hhI7AEt8KSQEe1();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				settingsTypes = new ConcurrentDictionary<string, Type>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void xPSnT3hhCdIGR8G2u93H(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object RmCyQohhv7j0ZrZ1MNWq(object P_0)
	{
		return XmlWriter.Create((TextWriter)P_0);
	}

	internal static void p8lJI2hh8l09EBvE3ebk(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool fjGY29hhfhmh1YcNjRTq()
	{
		return NIBfndhhEySYDQ3ojsLf == null;
	}

	internal static TypeSettingsNHType OxKEcwhhQEsYB0Wb6T3q()
	{
		return NIBfndhhEySYDQ3ojsLf;
	}

	internal static object XGV75JhhZbKncT40MLiP(object P_0)
	{
		return LoadTypeSettings((Stream)P_0);
	}

	internal static object WlZ3o2hhuZfU9KE4FhC3(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static void fxck99hhI7AEt8KSQEe1()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

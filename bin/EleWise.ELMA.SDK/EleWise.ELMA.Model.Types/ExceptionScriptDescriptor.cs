using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1100)]
public class ExceptionScriptDescriptor : CLRTypeDescriptor<ExceptionData, ExceptionDataSettings>, IMappingTypeDescriptor
{
	private static readonly FieldInfo StackTraceProp;

	public const string UID_S = "{CF7F2032-8E10-4639-883A-1E247B021948}";

	public static readonly Guid UID;

	internal static ExceptionScriptDescriptor enNR8ao7DAd4wB8aS54n;

	[XmlIgnore]
	public StringDescriptor StringDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CStringDescriptor_003Ek__BackingField;
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
					_003CStringDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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

	[XmlIgnore]
	public Int32Descriptor Int32Descriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CInt32Descriptor_003Ek__BackingField;
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
					_003CInt32Descriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override Guid Uid => UID;

	public override string Name => (string)qHh5wno7HIQQgGhQ8Gu6(iGpVkeo76MWd9H2vImN6(-2106517564 ^ -2106355706));

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 2;
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
				mapper.Type<ExceptionScriptNHType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				nRjIVxo74DEl0o9XTa96(this, mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0038, IL_0047
		int num = 3;
		ExceptionDataSettings exceptionDataSettings = default(ExceptionDataSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return exceptionDataSettings;
				case 1:
					exceptionDataSettings.DefaultValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (exceptionDataSettings == null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 3:
					exceptionDataSettings = (ExceptionDataSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
					num2 = 2;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_00f3
		int num = 3;
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		ExceptionData exceptionData = default(ExceptionData);
		SerializableDictionary<string, object> value2 = default(SerializableDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					serializableDictionary = new SerializableDictionary<string, object>
					{
						{
							(string)iGpVkeo76MWd9H2vImN6(-1088304168 ^ -1088205790),
							Int32Descriptor.SerializeSimple(MBlu4ro7A5n8yyEO5gXt(exceptionData))
						},
						{
							(string)iGpVkeo76MWd9H2vImN6(0x3A5D5EF ^ 0x3A75DF7),
							StringDescriptor.SerializeSimple((string)Y26oBQo77sKdMtplYaOh(exceptionData))
						}
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if ((exceptionData = value as ExceptionData) != null)
					{
						num2 = 2;
						break;
					}
					if (value != null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 5:
					serializableDictionary.Add((string)iGpVkeo76MWd9H2vImN6(-29254301 ^ -29158071), value2);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					value2 = SerializeException(exceptionData.OriginalException);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 5;
					}
					break;
				case 4:
				case 6:
					return serializableDictionary;
				default:
					if (eae9L7o7xAWmBLDeDgpn(exceptionData) == null)
					{
						num2 = 6;
						break;
					}
					goto case 1;
				case 8:
					return null;
				case 7:
					return base.SerializeSimple(value, valueType, settings);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_009e, IL_0204, IL_026b
		int num = 2;
		string text = default(string);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		Exception exception = default(Exception);
		int id = default(int);
		object value3 = default(object);
		object value2 = default(object);
		IDictionary<string, object> dictionary2 = default(IDictionary<string, object>);
		object value4 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					text = null;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				case 13:
					return null;
				case 3:
					dictionary = value as IDictionary<string, object>;
					num2 = 8;
					break;
				case 4:
					exception = null;
					num2 = 15;
					break;
				case 5:
					id = Int32Descriptor.DeserializeSimple(value3);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 1;
					}
					break;
				default:
					if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A4FE07), out value2))
					{
						num2 = 11;
						break;
					}
					goto case 14;
				case 16:
					if ((dictionary2 = value4 as IDictionary<string, object>) != null)
					{
						num2 = 10;
						break;
					}
					goto case 6;
				case 10:
					exception = DeserializeException(dictionary2);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 6;
					}
					break;
				case 7:
					return new ExceptionData();
				case 9:
					if (value != null)
					{
						num2 = 3;
						break;
					}
					goto case 13;
				case 2:
					j83AoZo70qlk80s386Zs(deserializeToType, iGpVkeo76MWd9H2vImN6(-70007027 ^ -70021495));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					break;
				case 15:
					if (!dictionary.TryGetValue((string)iGpVkeo76MWd9H2vImN6(0x4A1640F ^ 0x4A3E3F5), out value3))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 8:
					if (dictionary != null)
					{
						goto end_IL_0012;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 7;
					}
					break;
				case 14:
					if (!dictionary.TryGetValue((string)iGpVkeo76MWd9H2vImN6(-3333094 ^ -3167184), out value4))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 16;
				case 1:
					if (TypeOf<ExceptionData>.Raw.IsAssignableFrom(deserializeToType))
					{
						num2 = 9;
						break;
					}
					return base.DeserializeSimple(value, deserializeToType);
				case 6:
				case 18:
					return new ExceptionData(id, text, exception);
				case 11:
					text = StringDescriptor.DeserializeSimple(value2);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 14;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			id = 0;
			num = 12;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	private SerializableDictionary<string, object> SerializeException(Exception exception)
	{
		Contract.ArgumentNotNull(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E6968B));
		object value = StringDescriptor.SerializeSimple(exception.StackTrace);
		object value2 = StringDescriptor.SerializeSimple(exception.Message);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>
		{
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561240830),
				value
			},
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218592842),
				value2
			}
		};
		if (exception.InnerException != null)
		{
			SerializableDictionary<string, object> value3 = SerializeException(exception.InnerException);
			serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105361508), value3);
		}
		return serializableDictionary;
	}

	private Exception DeserializeException(IDictionary<string, object> dictionary)
	{
		string message = null;
		string value = null;
		Exception innerException = null;
		if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643690015), out var value2))
		{
			message = StringDescriptor.DeserializeSimple(value2);
		}
		if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957724122), out var value3))
		{
			value = StringDescriptor.DeserializeSimple(value3);
		}
		if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638564241), out var value4) && value4 is IDictionary<string, object> dictionary2)
		{
			innerException = DeserializeException(dictionary2);
		}
		Exception ex = new Exception(message, innerException);
		StackTraceProp.SetValue(ex, value);
		return ex;
	}

	public ExceptionScriptDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QHpfdAo7mFFDid6WnUIy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExceptionScriptDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218592918));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			default:
				StackTraceProp = Buidhxo7yrDKO1H5OOW3(typeof(Exception).TypeHandle).GetField((string)iGpVkeo76MWd9H2vImN6(0x4D1C1EE4 ^ 0x4D1E967A), BindingFlags.Instance | BindingFlags.NonPublic);
				num2 = 3;
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void nRjIVxo74DEl0o9XTa96(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<ExceptionData>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool D1FkIlo7tOUeABNId2Yb()
	{
		return enNR8ao7DAd4wB8aS54n == null;
	}

	internal static ExceptionScriptDescriptor bC2k2go7wPCuAL8nDp2I()
	{
		return enNR8ao7DAd4wB8aS54n;
	}

	internal static object iGpVkeo76MWd9H2vImN6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qHh5wno7HIQQgGhQ8Gu6(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int MBlu4ro7A5n8yyEO5gXt(object P_0)
	{
		return ((ExceptionData)P_0).ExceptionCode;
	}

	internal static object Y26oBQo77sKdMtplYaOh(object P_0)
	{
		return ((ExceptionData)P_0).Message;
	}

	internal static object eae9L7o7xAWmBLDeDgpn(object P_0)
	{
		return ((ExceptionData)P_0).OriginalException;
	}

	internal static void j83AoZo70qlk80s386Zs(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void QHpfdAo7mFFDid6WnUIy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type Buidhxo7yrDKO1H5OOW3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

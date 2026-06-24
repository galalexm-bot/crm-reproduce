using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public sealed class FormViewItemDescriptor : CLRTypeDescriptor<FormViewItem>
{
	public const string UID_S = "{F2C82E42-2939-4E8B-AC63-5743C41E39E3}";

	public static readonly Guid UID;

	internal static FormViewItemDescriptor uqCmaUo4jtI01KPj3Mx5;

	public override Guid Uid => UID;

	public override string Name => (string)Y96ZP1o4sP7sIJlZuSdJ(C4VFU5o4Uld4fTBwrCq0(-889460160 ^ -889615466));

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_009b, IL_00d1, IL_00f6, IL_0197, IL_01f0, IL_0220, IL_022f, IL_025c, IL_028c, IL_029b, IL_02a7, IL_02b6
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ea: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		object result = default(object);
		JsonSerializer val = default(JsonSerializer);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 4:
				((Collection<JsonConverter>)riKgwNo6oVi2xmT3q5K9(val)).Add((JsonConverter)Pfk5myo6h9xVNqsBbu1a());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream, EncodingCache.UTF8WithoutEmitIdentifier);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							JsonTextWriter val3 = new JsonTextWriter((TextWriter)streamWriter);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									lsvXRho6EgTqUfpdStWD(val3, (Formatting)1);
									int num5 = 3;
									while (true)
									{
										switch (num5)
										{
										default:
											return result;
										case 0:
											return result;
										case 1:
											result = QFNbiqo6Qchmjt6StVOQ(memoryStream, IJJmovo6fAEVOJQ52XkC());
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
											{
												num5 = 0;
											}
											break;
										case 3:
											val.Serialize((JsonWriter)(object)val3, value);
											num5 = 2;
											break;
										case 2:
											streamWriter.Flush();
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
											{
												num5 = 0;
											}
											break;
										}
									}
								}
								finally
								{
									if (val3 != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												XDiPv1o6C74K6YqSqDbY(val3);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
												{
													num6 = 0;
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
						finally
						{
							int num7;
							if (streamWriter == null)
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num7 = 0;
								}
								goto IL_01f4;
							}
							goto IL_020a;
							IL_020a:
							XDiPv1o6C74K6YqSqDbY(streamWriter);
							num7 = 2;
							goto IL_01f4;
							IL_01f4:
							switch (num7)
							{
							case 1:
								goto end_IL_01cf;
							case 2:
								goto end_IL_01cf;
							}
							goto IL_020a;
							end_IL_01cf:;
						}
					}
				}
				finally
				{
					int num8;
					if (memoryStream == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num8 = 0;
						}
						goto IL_0260;
					}
					goto IL_0276;
					IL_0276:
					XDiPv1o6C74K6YqSqDbY(memoryStream);
					num8 = 2;
					goto IL_0260;
					IL_0260:
					switch (num8)
					{
					default:
						goto end_IL_023b;
					case 1:
						break;
					case 0:
						goto end_IL_023b;
					case 2:
						goto end_IL_023b;
					}
					goto IL_0276;
					end_IL_023b:;
				}
			case 7:
				return null;
			case 6:
				((Collection<JsonConverter>)riKgwNo6oVi2xmT3q5K9(val)).Add((JsonConverter)(object)ViewItemConverter.Instance);
				num2 = 9;
				break;
			case 8:
				if (value != null)
				{
					JsonSerializer val2 = new JsonSerializer();
					pgMVCHo4cqAkO17IBXE9((object)val2, (TypeNameHandling)1);
					AKsio4o4zfZy1HVJ8mNR((object)val2, (DateFormatHandling)0);
					x8jZVYo6FRlfvQ2a8u6O((object)val2, (ReferenceLoopHandling)1);
					u6k1h4o6B7G6XAPJp4Vk((object)val2, new XmlContractResolver());
					val = val2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 7;
				}
				break;
			case 3:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 5;
				break;
			default:
				((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)sp7uSwo6WtD6emtm3Cvs());
				num2 = 6;
				break;
			case 1:
				((Collection<JsonConverter>)riKgwNo6oVi2xmT3q5K9(val)).Add((JsonConverter)Y6grwIo6GUDNO6WcKpe6());
				num2 = 3;
				break;
			case 9:
				((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)q7OwKuo6bvQ7VJeA7Cg2());
				num2 = 4;
				break;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (value != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 2:
				if (!(value is string text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				return MemoryHelper.ActionWithMemoryBuffer<byte, (string, Type), object>(OQaSJCo6v0R36XbB3DWN(IJJmovo6fAEVOJQ52XkC(), text), (text, deserializeToType), DeserializeSimpleAction);
			case 1:
				return new EntityJsonSerializer().ConvertFromSerializable(new FormViewItem(), (ClassMetadata)MetadataLoader.LoadMetadata(deserializeToType), (IDictionary<string, object>)value, loadEntityIfExists: false);
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PrktD3o68saPAU4qJvGH(propertyMetadata, C4VFU5o4Uld4fTBwrCq0(-1767720453 ^ -1767706455));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new PropertyValueContainer<FormViewItem>((FormViewItem)null);
			}
		}
	}

	private object DeserializeSimpleAction(byte[] buffer, int offset, int length, (string, Type) param)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		var (text, type) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, buffer, offset);
		using MemoryStream stream = MemoryHelper.GetMemoryStream(buffer, offset, length, writable: false);
		using StreamReader streamReader = new StreamReader(stream);
		JsonSerializer val = new JsonSerializer();
		val.set_TypeNameHandling((TypeNameHandling)1);
		val.set_DateFormatHandling((DateFormatHandling)0);
		val.set_ReferenceLoopHandling((ReferenceLoopHandling)1);
		val.set_ContractResolver((IContractResolver)(object)new XmlContractResolver());
		val.set_SerializationBinder((ISerializationBinder)(object)KnownTypesBinder.Instance);
		((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)(object)AbstractJsonConverter.Instance);
		((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)(object)ComputedValueConverter.Instance);
		((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)(object)PropertiesContainerConverter.Instance);
		return val.Deserialize((TextReader)streamReader, type);
	}

	public FormViewItemDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FormViewItemDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)C4VFU5o4Uld4fTBwrCq0(-882126494 ^ -882267416));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				Qp2B4Uo6ZxPpe2EbnauA();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object C4VFU5o4Uld4fTBwrCq0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Y96ZP1o4sP7sIJlZuSdJ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool BXaGIuo4YX1LfBVjhiFR()
	{
		return uqCmaUo4jtI01KPj3Mx5 == null;
	}

	internal static FormViewItemDescriptor SAwiBso4Le71uiXpKIN7()
	{
		return uqCmaUo4jtI01KPj3Mx5;
	}

	internal static void pgMVCHo4cqAkO17IBXE9(object P_0, TypeNameHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_TypeNameHandling(P_1);
	}

	internal static void AKsio4o4zfZy1HVJ8mNR(object P_0, DateFormatHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_DateFormatHandling(P_1);
	}

	internal static void x8jZVYo6FRlfvQ2a8u6O(object P_0, ReferenceLoopHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_ReferenceLoopHandling(P_1);
	}

	internal static void u6k1h4o6B7G6XAPJp4Vk(object P_0, object P_1)
	{
		((JsonSerializer)P_0).set_ContractResolver((IContractResolver)P_1);
	}

	internal static object sp7uSwo6WtD6emtm3Cvs()
	{
		return SimpleTypesConverter.Instance;
	}

	internal static object riKgwNo6oVi2xmT3q5K9(object P_0)
	{
		return ((JsonSerializer)P_0).get_Converters();
	}

	internal static object q7OwKuo6bvQ7VJeA7Cg2()
	{
		return AbstractJsonConverter.Instance;
	}

	internal static object Pfk5myo6h9xVNqsBbu1a()
	{
		return ComputedValueConverter.Instance;
	}

	internal static object Y6grwIo6GUDNO6WcKpe6()
	{
		return PropertiesContainerConverter.Instance;
	}

	internal static void lsvXRho6EgTqUfpdStWD(object P_0, Formatting P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonWriter)P_0).set_Formatting(P_1);
	}

	internal static object IJJmovo6fAEVOJQ52XkC()
	{
		return Encoding.UTF8;
	}

	internal static object QFNbiqo6Qchmjt6StVOQ(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static void XDiPv1o6C74K6YqSqDbY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int OQaSJCo6v0R36XbB3DWN(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	internal static void PrktD3o68saPAU4qJvGH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void Qp2B4Uo6ZxPpe2EbnauA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

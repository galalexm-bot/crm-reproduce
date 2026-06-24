using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class EntityMetadataTypeDescriptor<T> : EntitySubTypeDescriptor<EntityMetadata>
{
	private List<Guid> uidsForUpdate;

	private List<TablePartMetadata> tablepartsForDelete;

	private static object o37rN9oyRukr7uTsPVNP;

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings serializationSettings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8313D0C));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F5B87));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value != null)
		{
			value = value.CastAsRealType();
			PreSerializingActions(value as EntityMetadata);
			string text = ClassSerializationHelper.SerializeObjectByXml(value);
			text = text.Remove(0, text.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A56C9E)) + 1);
			string assemblyQualifiedName = value.GetType().AssemblyQualifiedName;
			if (assemblyQualifiedName != null)
			{
				text = assemblyQualifiedName + text;
			}
			serializableDictionary[propertyMetadata.Name] = text;
		}
		return serializableDictionary;
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj != null)
		{
			if (metadata == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418176B));
			}
			if (propertyMetadata == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957838574));
			}
			obj = obj.CastAsRealType();
			PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
			if (!(property == null) && property.CanRead && values.TryGetValue(propertyMetadata.Name, out var value))
			{
				string text = value.ToString();
				Type type = Type.GetType(text.Substring(0, text.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998522116))));
				text = text.Remove(0, text.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979233289)));
				StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637CA883));
				stringBuilder.AppendLine(text);
				string xml = stringBuilder.ToString();
				object obj2 = ClassSerializationHelper.DeserializeObjectByXml(type, xml);
				PostDeserializingActions(obj2 as EntityMetadata);
				property.SetValue(obj, obj2, null);
			}
		}
	}

	private void PreSerializingActions(EntityMetadata serObject)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_00d7, IL_0186, IL_01be
		int num = 6;
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					serObject.Properties.AddRange(((IEnumerable)serObject.EntityProperties).Cast<PropertyMetadata>().ToList());
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					return;
				case 2:
					serObject.TableParts.AddRange(((IEnumerable<TablePartMetadata>)serObject.EntityTableParts).ToList());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 1;
								}
								goto IL_00db;
							}
							goto IL_011b;
							IL_011b:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 2;
							}
							goto IL_00db;
							IL_00db:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_011b;
								case 2:
									PreSerializingActions(current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 4:
					serObject.TableParts.Clear();
					num2 = 2;
					continue;
				case 3:
					return;
				case 1:
					enumerator = ((IEnumerable<TablePartMetadata>)serObject.EntityTableParts).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (serObject != null)
					{
						serObject.Properties.Clear();
						num2 = 7;
						continue;
					}
					num = 5;
					break;
				}
				break;
			}
		}
	}

	private void PreSerializingActions(TablePartMetadata tablePartMetadata)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_00ee, IL_018d, IL_01c5
		int num = 4;
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					tablePartMetadata.TableParts.AddRange(((IEnumerable<TablePartMetadata>)tablePartMetadata.EntityTableParts).ToList());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					enumerator = ((IEnumerable<TablePartMetadata>)tablePartMetadata.EntityTableParts).GetEnumerator();
					num2 = 6;
					continue;
				case 3:
					break;
				case 2:
					tablePartMetadata.TableParts.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 6:
					try
					{
						while (true)
						{
							IL_0141:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num3 = 2;
								}
								goto IL_00f2;
							}
							goto IL_010c;
							IL_010c:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00f2;
							IL_00f2:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 1:
									break;
								case 3:
									PreSerializingActions(current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num3 = 0;
									}
									continue;
								default:
									goto IL_0141;
								}
								break;
							}
							goto IL_010c;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
									{
										num4 = 0;
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
					tablePartMetadata.Properties.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			tablePartMetadata.Properties.AddRange(((IEnumerable)tablePartMetadata.EntityProperties).Cast<PropertyMetadata>().ToList());
			num = 2;
		}
	}

	public void PostDeserializingActions(EntityMetadata deserializedObject)
	{
		//Discarded unreachable code: IL_0185, IL_0194, IL_019f, IL_022d, IL_0265, IL_0274, IL_0285, IL_028f, IL_031e, IL_033d, IL_034c, IL_0379, IL_0388, IL_03bf, IL_0428, IL_0432, IL_0590, IL_05a3, IL_064b, IL_0655, IL_06e9, IL_06fc
		int num = 20;
		IEnumerable<IClearBeforeDelEntityMetadata> extensionPoints = default(IEnumerable<IClearBeforeDelEntityMetadata>);
		IEnumerator<TablePartMetadata> enumerator4 = default(IEnumerator<TablePartMetadata>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		IEnumerator<IClearBeforeDelEntityMetadata> enumerator3 = default(IEnumerator<IClearBeforeDelEntityMetadata>);
		TablePartMetadata current2 = default(TablePartMetadata);
		string sql = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Guid current = default(Guid);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					if (extensionPoints != null)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 13:
					enumerator4 = ((IEnumerable<TablePartMetadata>)deserializedObject.EntityTableParts).GetEnumerator();
					num2 = 7;
					break;
				case 15:
					return;
				case 19:
					return;
				case 17:
					if (entityMetadata == null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 11:
					enumerator2 = uidsForUpdate.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 6;
					}
					break;
				case 9:
					deserializedObject.Id = 0L;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					tablepartsForDelete = new List<TablePartMetadata>();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 24;
					}
					break;
				case 18:
					GetTablePartsUids(entityMetadata, isOld: true);
					num2 = 5;
					break;
				case 8:
					extensionPoints = ComponentManager.Current.GetExtensionPoints<IClearBeforeDelEntityMetadata>();
					num2 = 22;
					break;
				case 10:
					try
					{
						while (true)
						{
							int num9;
							if (!enumerator3.MoveNext())
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num9 = 0;
								}
								goto IL_01a3;
							}
							goto IL_01b9;
							IL_01b9:
							enumerator3.Current.Clear(entityMetadata);
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num9 = 1;
							}
							goto IL_01a3;
							IL_01a3:
							switch (num9)
							{
							case 2:
								goto IL_01b9;
							case 1:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator3 != null)
						{
							int num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									enumerator3.Dispose();
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 7:
					try
					{
						while (true)
						{
							IL_02c0:
							int num7;
							if (!enumerator4.MoveNext())
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num7 = 1;
								}
								goto IL_0293;
							}
							goto IL_02ad;
							IL_02ad:
							current2 = enumerator4.Current;
							num7 = 2;
							goto IL_0293;
							IL_0293:
							while (true)
							{
								switch (num7)
								{
								case 1:
									return;
								case 3:
									break;
								default:
									goto IL_02c0;
								case 2:
									PostDeserializingActions(current2);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
									{
										num7 = 0;
									}
									continue;
								}
								break;
							}
							goto IL_02ad;
						}
					}
					finally
					{
						int num8;
						if (enumerator4 == null)
						{
							num8 = 2;
							goto IL_0322;
						}
						goto IL_0357;
						IL_0322:
						switch (num8)
						{
						case 2:
							goto end_IL_030d;
						case 1:
							goto end_IL_030d;
						}
						goto IL_0357;
						IL_0357:
						enumerator4.Dispose();
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num8 = 0;
						}
						goto IL_0322;
						end_IL_030d:;
					}
				case 24:
					entityMetadata = ModelHelper.GetEntityManager(deserializedObject.GetType()).LoadOrNull(deserializedObject.Uid) as EntityMetadata;
					num2 = 17;
					break;
				case 3:
					enumerator3 = extensionPoints.GetEnumerator();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 4;
					}
					break;
				case 25:
					((ICollection<EntityPropertyMetadata>)deserializedObject.EntityProperties).AddRange(deserializedObject.Properties.Cast<EntityPropertyMetadata>().ToList());
					num2 = 16;
					break;
				case 23:
					if (entityMetadata != null)
					{
						num2 = 12;
						break;
					}
					goto case 9;
				case 6:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 4;
								goto IL_0436;
							}
							goto IL_04da;
							IL_0436:
							while (true)
							{
								switch (num5)
								{
								case 1:
									sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867096881), serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345252344)), serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886625251)), serviceNotNull.ParameterSeparator);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num5 = 3;
									}
									continue;
								case 2:
									goto IL_04da;
								case 3:
									serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>
									{
										{
											z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A63A65C),
											Guid.NewGuid()
										},
										{
											z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AF5F2A),
											current
										}
									});
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num5 = 0;
									}
									continue;
								case 4:
									goto end_IL_0454;
								}
								break;
							}
							continue;
							IL_04da:
							current = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num5 = 0;
							}
							goto IL_0436;
							continue;
							end_IL_0454:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 23;
				case 21:
					enumerator = deserializedObject.Properties.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 2;
					}
					break;
				case 20:
					if (deserializedObject != null)
					{
						uidsForUpdate = new List<Guid>();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 19;
						}
					}
					break;
				case 12:
					entityMetadata.Delete();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 9;
					}
					break;
				case 16:
					((ICollection<TablePartMetadata>)deserializedObject.EntityTableParts).AddRange(deserializedObject.TableParts.ToList());
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 6;
					}
					break;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num3 = 0;
								}
								goto IL_0659;
							}
							goto IL_066f;
							IL_066f:
							enumerator.Current.Id = 0L;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num3 = 0;
							}
							goto IL_0659;
							IL_0659:
							switch (num3)
							{
							case 2:
								goto IL_066f;
							case 1:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 25;
				case 14:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					GetTablePartsUids(deserializedObject, isOld: false);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					if (entityMetadata != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 18;
						}
						break;
					}
					goto case 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void GetTablePartsUids(EntityMetadata metadata, bool isOld)
	{
		//Discarded unreachable code: IL_00c3, IL_00d2, IL_010d, IL_011c, IL_015d, IL_016c, IL_0180, IL_018f, IL_019a, IL_024a, IL_0269, IL_0295, IL_02a4, IL_02ff, IL_030e, IL_031e, IL_032d, IL_0363, IL_036d, IL_0423, IL_0436, IL_0445
		int num = 4;
		IEnumerator<TablePartMetadata> enumerator2 = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current2 = default(TablePartMetadata);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 14:
					goto end_IL_0012;
				case 8:
				case 10:
				case 16:
					if (!isOld)
					{
						num2 = 19;
						continue;
					}
					return;
				case 17:
					enumerator2 = ((IEnumerable<TablePartMetadata>)metadata.EntityTableParts).GetEnumerator();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 12;
					}
					continue;
				case 6:
					tablepartsForDelete.Add(metadata as TablePartMetadata);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					return;
				case 3:
					if (uidsForUpdate.Contains(metadata.Uid))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					break;
				case 5:
					return;
				case 12:
					try
					{
						while (true)
						{
							IL_01b8:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num5 = 0;
								}
								goto IL_019e;
							}
							goto IL_01de;
							IL_01de:
							current2 = enumerator2.Current;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num5 = 0;
							}
							goto IL_019e;
							IL_019e:
							while (true)
							{
								switch (num5)
								{
								case 3:
									goto IL_01b8;
								case 1:
									goto IL_01de;
								case 2:
									GetTablePartsUids(current2, isOld: true);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
									{
										num5 = 3;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator2 == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num6 = 0;
							}
							goto IL_024e;
						}
						goto IL_0273;
						IL_0273:
						enumerator2.Dispose();
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num6 = 0;
						}
						goto IL_024e;
						IL_024e:
						switch (num6)
						{
						default:
							goto end_IL_0229;
						case 1:
							goto end_IL_0229;
						case 2:
							break;
						case 0:
							goto end_IL_0229;
						}
						goto IL_0273;
						end_IL_0229:;
					}
					goto case 8;
				case 4:
					if (metadata == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 1:
					if (!(metadata is TablePartMetadata))
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 2:
				case 7:
				case 11:
					if (!isOld)
					{
						num2 = 8;
						continue;
					}
					goto case 18;
				case 19:
					if (metadata.TableParts == null)
					{
						num2 = 5;
						continue;
					}
					goto end_IL_0012;
				case 0:
					return;
				case 18:
					if (metadata.EntityTableParts == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 17;
				case 13:
					try
					{
						while (true)
						{
							IL_03d1:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num3 = 0;
								}
								goto IL_0371;
							}
							goto IL_038b;
							IL_038b:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num3 = 3;
							}
							goto IL_0371;
							IL_0371:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 2:
									break;
								case 3:
									GetTablePartsUids(current, isOld: false);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									goto IL_03d1;
								}
								break;
							}
							goto IL_038b;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 9:
					break;
				}
				uidsForUpdate.Add(metadata.Uid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = metadata.TableParts.GetEnumerator();
			num = 13;
		}
	}

	private void PostDeserializingActions(TablePartMetadata tablePartMetadata)
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_005c, IL_00fb, IL_0133, IL_0173, IL_0182, IL_018d, IL_0211, IL_0224
		int num = 3;
		int num2 = num;
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						IL_00af:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num5 = 1;
							}
							goto IL_0060;
						}
						goto IL_007a;
						IL_007a:
						current = enumerator.Current;
						num5 = 3;
						goto IL_0060;
						IL_0060:
						while (true)
						{
							switch (num5)
							{
							case 1:
								break;
							case 3:
								PostDeserializingActions(current);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num5 = 0;
								}
								continue;
							default:
								goto IL_00af;
							case 2:
								return;
							}
							break;
						}
						goto IL_007a;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								enumerator.Dispose();
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
			case 7:
				((ICollection<EntityPropertyMetadata>)tablePartMetadata.EntityProperties).AddRange(tablePartMetadata.Properties.Cast<EntityPropertyMetadata>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 2;
							goto IL_0191;
						}
						goto IL_01bd;
						IL_0191:
						switch (num3)
						{
						case 1:
							break;
						default:
							goto IL_01bd;
						case 2:
							goto end_IL_01a7;
						}
						continue;
						IL_01bd:
						enumerator2.Current.Id = 0L;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num3 = 0;
						}
						goto IL_0191;
						continue;
						end_IL_01a7:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 6:
				return;
			case 2:
				enumerator2 = tablePartMetadata.Properties.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				tablePartMetadata.Id = 0L;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				((ICollection<TablePartMetadata>)tablePartMetadata.EntityTableParts).AddRange(tablePartMetadata.TableParts);
				num2 = 5;
				break;
			case 5:
				enumerator = ((IEnumerable<TablePartMetadata>)tablePartMetadata.EntityTableParts).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected EntityMetadataTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool i9SU2doyqg9sjFSRoJWy()
	{
		return o37rN9oyRukr7uTsPVNP == null;
	}

	internal static object nRFOsxoyKaELZ8HmREAg()
	{
		return o37rN9oyRukr7uTsPVNP;
	}
}

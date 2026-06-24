using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers.EQL;

public sealed class ParsedQueryParameters : QueryParameters
{
	private class Parameter
	{
		private readonly bool isCollection;

		private Guid parentTypeUid;

		private object propertyName;

		private object typeSettings;

		private Type propertyType;

		internal static object DYqX9rCY6oSeeBnlwFb4;

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
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

		public Guid TypeUid
		{
			[CompilerGenerated]
			get
			{
				return _003CTypeUid_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CTypeUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid SubTypeUid
		{
			[CompilerGenerated]
			get
			{
				return _003CSubTypeUid_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CSubTypeUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public TypeSettings TypeSettings
		{
			get
			{
				//Discarded unreachable code: IL_00d6, IL_00e5
				int num = 3;
				EntitySettings entitySettings = default(EntitySettings);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 5:
							entitySettings = (EntitySettings)typeSettings;
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num2 = 0;
							}
							continue;
						case 3:
							if ((entitySettings = typeSettings as EntitySettings) == null)
							{
								num2 = 2;
								continue;
							}
							goto default;
						case 4:
							break;
						case 2:
						case 6:
							return (TypeSettings)typeSettings;
						default:
							if (isCollection == (entitySettings.RelationType == RelationType.OneToOne))
							{
								num2 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 2;
						case 1:
							rdOWbuCYl7BJf8MnL7uH(entitySettings, isCollection ? RelationType.ManyToMany : RelationType.OneToOne);
							num2 = 6;
							continue;
						}
						break;
					}
					typeSettings = qejEfuCYdoBaKaIVC4xY(typeSettings);
					num = 5;
				}
			}
		}

		public Type Type
		{
			get
			{
				int num = 2;
				int num2 = num;
				Type type = default(Type);
				Type type2;
				while (true)
				{
					switch (num2)
					{
					case 1:
						type = (propertyType = laMcyBCYJMeyQpfuekHJ(parentTypeUid, propertyName, isCollection));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						type2 = propertyType;
						if ((object)type2 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					default:
						type2 = type;
						break;
					}
					break;
				}
				return type2;
			}
		}

		public Parameter(object value)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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
				Value = value;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 1;
				}
			}
		}

		public Parameter(EntityMetadata parentMetadata, string propertyName, bool isCollection)
		{
			//Discarded unreachable code: IL_0033, IL_0038
			YnH6QCCY7SHypyVNr73M();
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.propertyName = propertyName;
			base._002Ector();
			int num = 2;
			PropertyMetadata propertyMetadata = default(PropertyMetadata);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					parentTypeUid = FWe2b3CYxSDU2paZMG3s(parentMetadata);
					num = 7;
					break;
				case 7:
					this.propertyName = CS_0024_003C_003E8__locals0.propertyName;
					num = 3;
					break;
				case 2:
					this.isCollection = isCollection;
					num = 4;
					break;
				case 0:
					return;
				case 3:
					propertyMetadata = parentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass6_0.GptwE9ZS2frBg0nLqZEc(_003C_003Ec__DisplayClass6_0.kmpWEjZSOYVV3HpuCosX(p), CS_0024_003C_003E8__locals0.propertyName));
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num = 1;
					}
					break;
				case 6:
					TypeUid = ((propertyMetadata != null) ? swlguJCY03VVUOneY02n(propertyMetadata) : Guid.Empty);
					num = 5;
					break;
				case 5:
					SubTypeUid = ((propertyMetadata != null) ? rCHfu3CYm5sBpjXVPOre(propertyMetadata) : Guid.Empty);
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num = 1;
					}
					break;
				case 1:
					typeSettings = ((propertyMetadata != null) ? BfMbOyCYy51l52iXTmpi(propertyMetadata) : null);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public bool Check(EntityMetadata parentMetadata, string propertyName, bool isCollection)
		{
			//Discarded unreachable code: IL_00a0, IL_00aa, IL_00f9, IL_0108, IL_01d0, IL_01df
			int num = 18;
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
			Type type = default(Type);
			Type type2 = default(Type);
			PropertyMetadata propertyMetadata = default(PropertyMetadata);
			while (true)
			{
				int num2 = num;
				Guid subTypeUid;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 10:
						this.propertyName = _003C_003Ec__DisplayClass11_.propertyName;
						num2 = 6;
						break;
					case 12:
						return true;
					case 9:
						if (isCollection)
						{
							num2 = 3;
							break;
						}
						goto case 2;
					case 2:
						obj = Type;
						goto IL_027f;
					case 18:
						_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
						num2 = 17;
						break;
					case 16:
						type = laMcyBCYJMeyQpfuekHJ(parentTypeUid, _003C_003Ec__DisplayClass11_.propertyName, false);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 7;
						}
						break;
					case 17:
						_003C_003Ec__DisplayClass11_.propertyName = propertyName;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 2;
						}
						break;
					case 7:
						if (!tQ3uWbCY9ePIVn1Z3U6W(type2, type))
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num2 = 19;
							}
							break;
						}
						goto case 14;
					case 4:
						if (this.isCollection != isCollection)
						{
							num2 = 8;
							break;
						}
						propertyMetadata = parentMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CCheck_003Eb__0);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						break;
					case 15:
						return true;
					case 19:
						return tQ3uWbCY9ePIVn1Z3U6W(type, type2);
					case 14:
						parentTypeUid = parentMetadata.Uid;
						num2 = 10;
						break;
					case 8:
						return false;
					case 1:
						if (mUpv5dCYMd2Ra6DeKxfN(TypeUid, (propertyMetadata != null) ? swlguJCY03VVUOneY02n(propertyMetadata) : Guid.Empty))
						{
							num2 = 11;
							break;
						}
						goto case 9;
					case 11:
						if (!(SubTypeUid == ((propertyMetadata != null) ? rCHfu3CYm5sBpjXVPOre(propertyMetadata) : Guid.Empty)))
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 12;
					case 3:
						obj = Type.GetInterface(TypeOf.IEnumerable.FullName).GetGenericArguments()[0];
						goto IL_027f;
					case 6:
						TypeUid = ((propertyMetadata != null) ? swlguJCY03VVUOneY02n(propertyMetadata) : Guid.Empty);
						num2 = 13;
						break;
					case 13:
						subTypeUid = propertyMetadata?.SubTypeUid ?? Guid.Empty;
						goto end_IL_0012;
					case 5:
						typeSettings = ((propertyMetadata != null) ? BfMbOyCYy51l52iXTmpi(propertyMetadata) : null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						{
							propertyType = (isCollection ? null : type);
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num2 = 15;
							}
							break;
						}
						IL_027f:
						type2 = (Type)obj;
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 13;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				SubTypeUid = subTypeUid;
				num = 5;
			}
		}

		private static Type GetType(Guid parentTypeUid, object propertyName, bool isCollection)
		{
			//Discarded unreachable code: IL_005d, IL_006a, IL_0079, IL_0102, IL_013c, IL_014b, IL_0175
			int num = 8;
			Type type = default(Type);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					int num3;
					switch (num2)
					{
					case 5:
						obj = type.GetInterface((string)TOYS4rCY53ICS447jodm(TypeOf.IEnumerable)).GetGenericArguments()[0];
						break;
					case 2:
						return type;
					case 4:
						if (isCollection)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 8:
						goto end_IL_0012;
					case 7:
						if (!QgS7Z1CYgO86QIM3tZbn(type))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 3;
					case 3:
						num3 = ((type != TypeOf<string>.Raw) ? 1 : 0);
						goto IL_017b;
					default:
						if (!Qg8nYhCYjIV1AJTSYM5G(typeof(IEntity).TypeHandle).IsAssignableFrom(type))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						obj = uQ8lHeCYYqhprQayFTmA(TypeOf.Iesi_ISet).MakeGenericType(type);
						break;
					case 1:
						obj = uQ8lHeCYYqhprQayFTmA(TypeOf.List).MakeGenericType(type);
						break;
					case 6:
						{
							num3 = 0;
							goto IL_017b;
						}
						IL_017b:
						if (num3 != (isCollection ? 1 : 0))
						{
							num2 = 4;
							continue;
						}
						goto case 2;
					}
					type = (Type)obj;
					num2 = 2;
					continue;
					end_IL_0012:
					break;
				}
				type = oYtxXFCYrH0a9dJaNriI(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(parentTypeUid).GetProperty((string)propertyName));
				num = 7;
			}
		}

		internal static bool v9H9gbCYH89FyJOltpxO()
		{
			return DYqX9rCY6oSeeBnlwFb4 == null;
		}

		internal static Parameter cIlGwKCYAkIHqmmtQQTm()
		{
			return (Parameter)DYqX9rCY6oSeeBnlwFb4;
		}

		internal static void YnH6QCCY7SHypyVNr73M()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static Guid FWe2b3CYxSDU2paZMG3s(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}

		internal static Guid swlguJCY03VVUOneY02n(object P_0)
		{
			return ((PropertyMetadata)P_0).TypeUid;
		}

		internal static Guid rCHfu3CYm5sBpjXVPOre(object P_0)
		{
			return ((PropertyMetadata)P_0).SubTypeUid;
		}

		internal static object BfMbOyCYy51l52iXTmpi(object P_0)
		{
			return ((PropertyMetadata)P_0).Settings;
		}

		internal static bool mUpv5dCYMd2Ra6DeKxfN(Guid P_0, Guid P_1)
		{
			return P_0 == P_1;
		}

		internal static Type laMcyBCYJMeyQpfuekHJ(Guid parentTypeUid, object P_1, bool isCollection)
		{
			return GetType(parentTypeUid, P_1, isCollection);
		}

		internal static bool tQ3uWbCY9ePIVn1Z3U6W(Type source, Type target)
		{
			return source.IsCompatibleWith(target);
		}

		internal static object qejEfuCYdoBaKaIVC4xY(object P_0)
		{
			return ((TypeSettings)P_0).Clone();
		}

		internal static void rdOWbuCYl7BJf8MnL7uH(object P_0, RelationType value)
		{
			((EntitySettings)P_0).RelationType = value;
		}

		internal static Type oYtxXFCYrH0a9dJaNriI(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static bool QgS7Z1CYgO86QIM3tZbn(Type type)
		{
			return type.IsEnumerable();
		}

		internal static object TOYS4rCY53ICS447jodm(object P_0)
		{
			return ((RipeType)P_0).FullName;
		}

		internal static Type Qg8nYhCYjIV1AJTSYM5G(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static Type uQ8lHeCYYqhprQayFTmA(object P_0)
		{
			return ((RipeType)P_0).Raw;
		}
	}

	private class SerializableDictionary : SerializableDictionary<string, Parameter>, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(CollectionDebugView))]
		private new sealed class ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable, ICollection, IReadOnlyCollection<object>
		{
			[Serializable]
			private sealed class Enumerator : IEnumerator<object>, IDisposable, IEnumerator
			{
				private readonly IEnumerator<KeyValuePair<string, Parameter>> enumerator;

				private static object ej8wGYZpHcx0HJ5lWV5s;

				public object Current
				{
					get
					{
						int num = 1;
						int num2 = num;
						KeyValuePair<string, Parameter> current = default(KeyValuePair<string, Parameter>);
						while (true)
						{
							switch (num2)
							{
							case 1:
								current = enumerator.Current;
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num2 = 0;
								}
								break;
							default:
								return LLR1QZZpx9E1HsSG2gRp(current.Value);
							}
						}
					}
				}

				internal Enumerator(IDictionary<string, Parameter> dictionary)
				{
					SingletonReader.JJCZtPuTvSt();
					base._002Ector();
					enumerator = dictionary.GetEnumerator();
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return enumerator.MoveNext();
				}

				public void Reset()
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
							enumerator.Reset();
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				internal static bool HT6A6YZpA73IHGKOm1Qo()
				{
					return ej8wGYZpHcx0HJ5lWV5s == null;
				}

				internal static Enumerator MENtJdZp72dBZhLwuKLQ()
				{
					return (Enumerator)ej8wGYZpHcx0HJ5lWV5s;
				}

				internal static object LLR1QZZpx9E1HsSG2gRp(object P_0)
				{
					return ((Parameter)P_0).Value;
				}
			}

			private sealed class CollectionDebugView
			{
				private ICollection<object> collection;

				internal static object vjFqmQZp0gHuVp5G0Ksm;

				[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
				public object[] Items
				{
					get
					{
						int num = 2;
						int num2 = num;
						object[] array = default(object[]);
						while (true)
						{
							switch (num2)
							{
							case 1:
								collection.CopyTo(array, 0);
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num2 = 0;
								}
								break;
							default:
								return array;
							case 2:
								array = new object[g8JaOAZpMVeRlADMVu1M(collection)];
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num2 = 1;
								}
								break;
							}
						}
					}
				}

				public CollectionDebugView(ICollection<object> collection)
				{
					SingletonReader.JJCZtPuTvSt();
					base._002Ector();
					this.collection = collection;
				}

				internal static int g8JaOAZpMVeRlADMVu1M(object P_0)
				{
					return ((ICollection<object>)P_0).Count;
				}

				internal static bool pmE5vLZpmvkRyk9FgNL2()
				{
					return vjFqmQZp0gHuVp5G0Ksm == null;
				}

				internal static CollectionDebugView VroZ2OZpyM2dObEx4hgG()
				{
					return (CollectionDebugView)vjFqmQZp0gHuVp5G0Ksm;
				}
			}

			private IDictionary<string, Parameter> dictionary;

			private static object ODHk7mZSp5BGQpYaPaL2;

			public int Count => JDjmeBZSHDy4PvAGGtDV(dictionary);

			bool ICollection<object>.IsReadOnly => true;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => YA0JmlZSAIZsgDLBBMES((ICollection)dictionary);

			public ValueCollection(IDictionary<string, Parameter> dictionary)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.dictionary = dictionary;
			}

			public IEnumerator<object> GetEnumerator()
			{
				return new Enumerator(dictionary);
			}

			public void CopyTo(Array array, int index)
			{
				//Discarded unreachable code: IL_0092, IL_00a1, IL_00ac, IL_0141, IL_0171, IL_0180, IL_018c, IL_01ab, IL_01ba, IL_01ca, IL_0237
				int num = 4;
				IEnumerator<object> enumerator = default(IEnumerator<object>);
				object current = default(object);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 5:
							throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921185097));
						default:
							if (X6xPEuZSw4kFgyUg1La3(array) - index >= dictionary.Count)
							{
								num2 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num2 = 6;
								}
								continue;
							}
							break;
						case 2:
							try
							{
								while (true)
								{
									IL_00ed:
									int num3;
									if (!YwXjF6ZS6CbbLv2uJLTI(enumerator))
									{
										num3 = 3;
										goto IL_00b0;
									}
									goto IL_00ca;
									IL_00b0:
									while (true)
									{
										switch (num3)
										{
										case 2:
											goto IL_00ed;
										case 1:
											X7xliWZS48ZWIk2SyHDO(array, current, index++);
											num3 = 2;
											continue;
										case 3:
											return;
										}
										break;
									}
									goto IL_00ca;
									IL_00ca:
									current = enumerator.Current;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
									{
										num3 = 1;
									}
									goto IL_00b0;
								}
							}
							finally
							{
								int num4;
								if (enumerator == null)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num4 = 0;
									}
									goto IL_0145;
								}
								goto IL_015b;
								IL_015b:
								enumerator.Dispose();
								num4 = 2;
								goto IL_0145;
								IL_0145:
								switch (num4)
								{
								default:
									goto end_IL_0120;
								case 1:
									break;
								case 0:
									goto end_IL_0120;
								case 2:
									goto end_IL_0120;
								}
								goto IL_015b;
								end_IL_0120:;
							}
						case 4:
							if (array != null)
							{
								num2 = 3;
								continue;
							}
							goto case 1;
						case 1:
							throw new ArgumentNullException((string)MpVQnyZSt5XQMHeInJcx(0xE1229CF ^ 0xE179299));
						case 3:
							if (index >= 0)
							{
								num2 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 5;
						case 6:
							return;
						case 7:
							if (index <= X6xPEuZSw4kFgyUg1La3(array))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 5;
						case 9:
							break;
						case 8:
							goto end_IL_0012;
						}
						throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A36966));
						continue;
						end_IL_0012:
						break;
					}
					enumerator = GetEnumerator();
					num = 2;
				}
			}

			void ICollection<object>.Add(object item)
			{
				throw new NotSupportedException();
			}

			bool ICollection<object>.Remove(object item)
			{
				throw new NotSupportedException();
			}

			void ICollection<object>.Clear()
			{
				throw new NotSupportedException();
			}

			bool ICollection<object>.Contains(object item)
			{
				return this.Contains(item);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			void ICollection<object>.CopyTo(object[] array, int index)
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
						CopyTo(array, index);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static object MpVQnyZSt5XQMHeInJcx(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static int X6xPEuZSw4kFgyUg1La3(object P_0)
			{
				return ((Array)P_0).Length;
			}

			internal static void X7xliWZS48ZWIk2SyHDO(object P_0, object P_1, int P_2)
			{
				((Array)P_0).SetValue(P_1, P_2);
			}

			internal static bool YwXjF6ZS6CbbLv2uJLTI(object P_0)
			{
				return ((IEnumerator)P_0).MoveNext();
			}

			internal static bool ziSiGKZSaVgGC8BYko1a()
			{
				return ODHk7mZSp5BGQpYaPaL2 == null;
			}

			internal static ValueCollection znVvDTZSDQFV69pvd3qc()
			{
				return (ValueCollection)ODHk7mZSp5BGQpYaPaL2;
			}

			internal static int JDjmeBZSHDy4PvAGGtDV(object P_0)
			{
				return ((ICollection<KeyValuePair<string, Parameter>>)P_0).Count;
			}

			internal static object YA0JmlZSAIZsgDLBBMES(object P_0)
			{
				return ((ICollection)P_0).SyncRoot;
			}
		}

		[Serializable]
		private new sealed class Enumerator : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator, IEnumerator<KeyValuePair<string, Parameter>>
		{
			private readonly IEnumerator<KeyValuePair<string, Parameter>> enumerator;

			private static object FXounwZS7Rnpjpe7ltDX;

			public KeyValuePair<string, object> Current => new KeyValuePair<string, object>(enumerator.Current.Key, enumerator.Current.Value.Value);

			object IEnumerator.Current => Current;

			KeyValuePair<string, Parameter> IEnumerator<KeyValuePair<string, Parameter>>.Current => enumerator.Current;

			internal Enumerator(IDictionary<string, Parameter> dictionary)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				enumerator = dictionary.GetEnumerator();
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return xDE7nKZSmE6TqKBXn8Yh(enumerator);
			}

			public void Reset()
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
						VinpftZSyyu345qq6rYU(enumerator);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			internal static bool xDE7nKZSmE6TqKBXn8Yh(object P_0)
			{
				return ((IEnumerator)P_0).MoveNext();
			}

			internal static bool wKvI6EZSxJMl5hJiEQCn()
			{
				return FXounwZS7Rnpjpe7ltDX == null;
			}

			internal static Enumerator IygWlHZS0n8oiU4SEdX3()
			{
				return (Enumerator)FXounwZS7Rnpjpe7ltDX;
			}

			internal static void VinpftZSyyu345qq6rYU(object P_0)
			{
				((IEnumerator)P_0).Reset();
			}
		}

		private object values;

		internal static object idSyOxCYLyx6eFBAyvZf;

		object IDictionary<string, object>.this[string key]
		{
			get
			{
				return xohFbmCYckBIJPutg4ML(base[key]);
			}
			set
			{
				int num = 2;
				int num2 = num;
				Parameter value2 = default(Parameter);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						value2.Value = value;
						num2 = 3;
						break;
					case 3:
						return;
					case 0:
						return;
					case 2:
						if (!TryGetValue(key, out value2))
						{
							base[key] = new Parameter(value);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num2 = 1;
							}
						}
						break;
					}
				}
			}
		}

		bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

		ICollection<string> IDictionary<string, object>.Keys => base.Keys;

		ICollection<object> IDictionary<string, object>.Values => (ICollection<object>)(values ?? (values = new ValueCollection(this)));

		void IDictionary<string, object>.Add(string key, object value)
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
					Add(key, new Parameter(value));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
		{
			Add(item.Key, new Parameter(item.Value));
		}

		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
		{
			if (TryGetValue(item.Key, out var value))
			{
				return value.Value == value;
			}
			return false;
		}

		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			//Discarded unreachable code: IL_0099, IL_00a8, IL_00c8, IL_00d7, IL_0110, IL_011f, IL_01df, IL_01f2, IL_0201
			int num = 7;
			int num2 = num;
			Dictionary<string, Parameter>.Enumerator enumerator = default(Dictionary<string, Parameter>.Enumerator);
			KeyValuePair<string, Parameter> current = default(KeyValuePair<string, Parameter>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					throw new ArgumentOutOfRangeException((string)m75mi6CYzwkRnkWBsVSS(-210725949 ^ -210425689));
				case 5:
					if (array.Length - arrayIndex < aC1GOFCLF9lfsmcrJgac(this))
					{
						num2 = 8;
						break;
					}
					enumerator = GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					if (arrayIndex <= array.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				case 7:
					if (array != null)
					{
						num2 = 6;
						break;
					}
					goto case 4;
				case 4:
					throw new ArgumentNullException((string)m75mi6CYzwkRnkWBsVSS(-740338220 ^ -740626814));
				case 6:
					if (arrayIndex >= 0)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 0:
					return;
				case 2:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 2;
								num4 = num3;
								goto IL_012e;
							}
							goto IL_0190;
							IL_012e:
							while (true)
							{
								switch (num4)
								{
								case 2:
									return;
								case 3:
									break;
								default:
									array[arrayIndex++] = new KeyValuePair<string, object>(current.Key, current.Value.Value);
									num4 = 3;
									continue;
								case 1:
									goto IL_0190;
								}
								break;
							}
							continue;
							IL_0190:
							current = enumerator.Current;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num4 = 0;
							}
							goto IL_012e;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 8:
					throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E7C0DC));
				}
			}
		}

		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
		{
			if (((ICollection<KeyValuePair<string, object>>)this).Contains(item))
			{
				return Remove(item.Key);
			}
			return false;
		}

		bool IDictionary<string, object>.TryGetValue(string key, out object value)
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return true;
				case 3:
				{
					if (!TryGetValue(key, out var value2))
					{
						num2 = 2;
						break;
					}
					value = value2.Value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return false;
				case 2:
					value = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return new Enumerator(this);
		}

		public SerializableDictionary()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object xohFbmCYckBIJPutg4ML(object P_0)
		{
			return ((Parameter)P_0).Value;
		}

		internal static bool Eu8J6BCYUTxweP7R0S2i()
		{
			return idSyOxCYLyx6eFBAyvZf == null;
		}

		internal static SerializableDictionary WKbrZaCYsZhBWor6HJaA()
		{
			return (SerializableDictionary)idSyOxCYLyx6eFBAyvZf;
		}

		internal static object m75mi6CYzwkRnkWBsVSS(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static int aC1GOFCLF9lfsmcrJgac(object P_0)
		{
			return ((Dictionary<string, Parameter>)P_0).Count;
		}
	}

	internal static ParsedQueryParameters TgsRArhvnH6AMo2xBaWB;

	private new IDictionary<string, Parameter> Dictionary => (IDictionary<string, Parameter>)base.Dictionary;

	internal ParsedQueryParameters()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(new SerializableDictionary());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ParsedQueryParameters FillValues(IDictionary<string, object> parameters)
	{
		foreach (KeyValuePair<string, Parameter> item in Dictionary)
		{
			if (parameters.TryGetValue(item.Key, out var value) && item.Value.Type.IsInstanceOfType(value))
			{
				item.Value.Value = value;
			}
		}
		return this;
	}

	public Type GetType(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
			{
				if (Dictionary.TryGetValue(TrimKey(name), out var value))
				{
					return LH5eobhveVEb7PS8kCsy(value);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public Guid GetTypeUid(string name)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		Parameter value = default(Parameter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Dictionary.TryGetValue(TrimKey(name), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return Guid.Empty;
			default:
				return uVxy1MhvPiCnTKljFkld(value);
			}
		}
	}

	public Guid GetSubTypeUid(string name)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		Parameter value = default(Parameter);
		while (true)
		{
			switch (num2)
			{
			default:
				return Guid.Empty;
			case 1:
				return lKQnoQhv1W60rJnBq9Dt(value);
			case 2:
				if (Dictionary.TryGetValue(TrimKey(name), out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public TypeSettings GetTypeSettings(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
			{
				if (Dictionary.TryGetValue(TrimKey(name), out var value))
				{
					return (TypeSettings)pqo14IhvNXabpq3mnS7N(value);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	internal bool TryCheckAndGet(string name, EntityMetadata parentMetadata, string propertyName, bool isCollection, out object value)
	{
		int num = 1;
		Parameter value2 = default(Parameter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					value2 = (Dictionary[name] = new Parameter(parentMetadata, propertyName, isCollection));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					name = TrimKey(name);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (Dictionary.TryGetValue(name, out value2))
					{
						break;
					}
					goto end_IL_0012;
				case 3:
					return os2Eqjhvp0Q02cGnuZZY(value2, parentMetadata, propertyName, isCollection);
				case 2:
					break;
				}
				value = F72LYlhv3OTa5sAiI4Ds(value2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static bool gOuHDLhvODkiHK5dKaTi()
	{
		return TgsRArhvnH6AMo2xBaWB == null;
	}

	internal static ParsedQueryParameters h9VToQhv2aOF8cRFKLcC()
	{
		return TgsRArhvnH6AMo2xBaWB;
	}

	internal static Type LH5eobhveVEb7PS8kCsy(object P_0)
	{
		return ((Parameter)P_0).Type;
	}

	internal static Guid uVxy1MhvPiCnTKljFkld(object P_0)
	{
		return ((Parameter)P_0).TypeUid;
	}

	internal static Guid lKQnoQhv1W60rJnBq9Dt(object P_0)
	{
		return ((Parameter)P_0).SubTypeUid;
	}

	internal static object pqo14IhvNXabpq3mnS7N(object P_0)
	{
		return ((Parameter)P_0).TypeSettings;
	}

	internal static object F72LYlhv3OTa5sAiI4Ds(object P_0)
	{
		return ((Parameter)P_0).Value;
	}

	internal static bool os2Eqjhvp0Q02cGnuZZY(object P_0, object P_1, object P_2, bool isCollection)
	{
		return ((Parameter)P_0).Check((EntityMetadata)P_1, (string)P_2, isCollection);
	}
}

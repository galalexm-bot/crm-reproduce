using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Services;

[Service]
internal sealed class FullTextTypeMappingService : IFullTextTypeMappingServiceExt, IFullTextTypeMappingService
{
	private class MappingCardHandlerObject
	{
		private List<MappingCardHandlerObjectItem> mappings;

		private static object joLQoRvL7qshbKD9Agwd;

		public void AddMappings(Type cardType, IFullTextSearchObjectHandlerExtension handlerPoint, List<Guid> supportedObjectUids)
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.cardType = cardType;
			CS_0024_003C_003E8__locals0.handlerPoint = handlerPoint;
			if (CS_0024_003C_003E8__locals0.cardType == null || CS_0024_003C_003E8__locals0.handlerPoint == null)
			{
				return;
			}
			MappingCardHandlerObjectItem mappingCardHandlerObjectItem = mappings.FirstOrDefault(delegate(MappingCardHandlerObjectItem m)
			{
				//Discarded unreachable code: IL_003e, IL_004d
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return _003C_003Ec__DisplayClass0_0.mPtu1JZnhvcZltlBN3ZL(m) == CS_0024_003C_003E8__locals0.handlerPoint;
					case 1:
						return false;
					case 2:
						if (!_003C_003Ec__DisplayClass0_0.Wwm7pSZnbna0NYLPHrFj(_003C_003Ec__DisplayClass0_0.wwAQP2Zno25jxkqrKgN8(m), CS_0024_003C_003E8__locals0.cardType))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					}
				}
			});
			if (mappingCardHandlerObjectItem != null)
			{
				mappingCardHandlerObjectItem.Add(supportedObjectUids);
			}
			else
			{
				mappings.Add(new MappingCardHandlerObjectItem(CS_0024_003C_003E8__locals0.cardType, CS_0024_003C_003E8__locals0.handlerPoint, supportedObjectUids));
			}
		}

		public bool Any(Guid objectUid)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass1_.objectUid = objectUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return mappings.Any(_003C_003Ec__DisplayClass1_._003CAny_003Eb__0);
				}
			}
		}

		public List<MappingCardHandlerObjectItem> Where(Guid objectUid)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.objectUid = objectUid;
			return mappings.Where((MappingCardHandlerObjectItem m) => m.SupportedObjectUids.Any((Guid o) => _003C_003Ec__DisplayClass2_0.HQH5bEZnIpX2NhnYx4H5(o, CS_0024_003C_003E8__locals0.objectUid))).ToList();
		}

		public MappingCardHandlerObject()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			rsZWWgvLmNj57bmJPVBQ();
			mappings = new List<MappingCardHandlerObjectItem>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool X6O2yIvLxxIQpEUSJ8Bh()
		{
			return joLQoRvL7qshbKD9Agwd == null;
		}

		internal static MappingCardHandlerObject iySTAPvL0etSNtVyxt2S()
		{
			return (MappingCardHandlerObject)joLQoRvL7qshbKD9Agwd;
		}

		internal static void rsZWWgvLmNj57bmJPVBQ()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class MappingCardHandlerObjectItem
	{
		private Guid cardUid;

		private object handlerPoint;

		private List<Guid> supportedObjectUids;

		private static object tJsPB5vLyEdxRLkUUjll;

		public Type CardType
		{
			[CompilerGenerated]
			get
			{
				return _003CCardType_003Ek__BackingField;
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
						_003CCardType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid CardUid => cardUid;

		public IFullTextSearchObjectHandlerExtension HandlerPoint => (IFullTextSearchObjectHandlerExtension)handlerPoint;

		public List<Guid> SupportedObjectUids => supportedObjectUids;

		public MappingCardHandlerObjectItem(Type cardType, IFullTextSearchObjectHandlerExtension handlerPoint, List<Guid> supportedObjectUids)
		{
			SingletonReader.JJCZtPuTvSt();
			this.supportedObjectUids = new List<Guid>();
			base._002Ector();
			this.handlerPoint = handlerPoint;
			this.supportedObjectUids = supportedObjectUids ?? new List<Guid>();
			CardType = cardType;
			cardUid = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetCardUidByCardType(cardType) ?? Guid.Empty;
		}

		public void Add(List<Guid> supportedObjectUids)
		{
			if (supportedObjectUids == null)
			{
				return;
			}
			foreach (Guid supportedObjectUid in supportedObjectUids)
			{
				if (!this.supportedObjectUids.Contains(supportedObjectUid))
				{
					this.supportedObjectUids.Add(supportedObjectUid);
				}
			}
		}

		internal static bool JgFnPovLMqepLEEmusf1()
		{
			return tJsPB5vLyEdxRLkUUjll == null;
		}

		internal static MappingCardHandlerObjectItem xFTIhmvLJtLDq5Zv5Ufp()
		{
			return (MappingCardHandlerObjectItem)tJsPB5vLyEdxRLkUUjll;
		}
	}

	private class MappingCardEntityField
	{
		private IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions;

		private readonly IDictionary<Guid, Dictionary<Type, MappingCardEntityFieldItem>> mappings;

		private bool addMappings;

		internal static object nJCYlcvL9OtnAKNyJkN3;

		public MappingCardEntityField(IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.moduleFullTextSearchExtensions = moduleFullTextSearchExtensions;
			mappings = PublishCacheContext.CreateCache((IDictionary<Guid, Dictionary<Type, MappingCardEntityFieldItem>> _) => new ConcurrentDictionary<Guid, Dictionary<Type, MappingCardEntityFieldItem>>(), null, delegate
			{
				addMappings = true;
			});
			addMappings = true;
		}

		public IEnumerable<MappingCardEntityFieldItem> Where(Guid objectUid)
		{
			if (addMappings)
			{
				AddMappings();
			}
			if (!mappings.TryGetValue(objectUid, out var value))
			{
				return Enumerable.Empty<MappingCardEntityFieldItem>();
			}
			return value.Values;
		}

		private void AddMappings()
		{
			//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_0089, IL_0098, IL_00a3, IL_014c, IL_015b, IL_016a, IL_017a, IL_0189, IL_024d, IL_0260, IL_026f, IL_02e9, IL_0308, IL_0317, IL_0344, IL_0353
			int num = 2;
			int num2 = num;
			IEnumerator<KeyValuePair<Type, Dictionary<Guid, List<string>>>> enumerator = default(IEnumerator<KeyValuePair<Type, Dictionary<Guid, List<string>>>>);
			KeyValuePair<Type, Dictionary<Guid, List<string>>> current = default(KeyValuePair<Type, Dictionary<Guid, List<string>>>);
			Dictionary<Guid, List<string>>.Enumerator enumerator2 = default(Dictionary<Guid, List<string>>.Enumerator);
			MappingCardEntityFieldItem value2 = default(MappingCardEntityFieldItem);
			KeyValuePair<Guid, List<string>> current2 = default(KeyValuePair<Guid, List<string>>);
			Dictionary<Type, MappingCardEntityFieldItem> value = default(Dictionary<Type, MappingCardEntityFieldItem>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num3 = 0;
								}
								goto IL_004d;
							}
							goto IL_02a0;
							IL_02a0:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 2;
							}
							goto IL_004d;
							IL_004d:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 4:
									enumerator2 = current.Value.GetEnumerator();
									num3 = 3;
									continue;
								case 3:
									try
									{
										while (true)
										{
											IL_01c3:
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 4;
												goto IL_00a7;
											}
											goto IL_00d9;
											IL_00a7:
											while (true)
											{
												switch (num4)
												{
												case 7:
													break;
												case 6:
													value2.Add(current2.Value);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
													{
														num4 = 0;
													}
													continue;
												case 5:
													if (!mappings.TryGetValue(current2.Key, out value))
													{
														num4 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
														{
															num4 = 1;
														}
														continue;
													}
													goto case 9;
												case 9:
													if (!value.TryGetValue(current.Key, out value2))
													{
														num4 = 3;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
														{
															num4 = 3;
														}
														continue;
													}
													goto case 6;
												default:
													goto IL_01c3;
												case 1:
												case 2:
												case 3:
													mappings.Add(current2.Key, new Dictionary<Type, MappingCardEntityFieldItem> { 
													{
														current.Key,
														new MappingCardEntityFieldItem(current.Key, current2.Key, current2.Value)
													} });
													num4 = 8;
													continue;
												case 4:
													goto end_IL_01c3;
												}
												break;
											}
											goto IL_00d9;
											IL_00d9:
											current2 = enumerator2.Current;
											num4 = 5;
											goto IL_00a7;
											continue;
											end_IL_01c3:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									break;
								case 2:
									break;
								case 1:
									goto IL_02a0;
								}
								break;
							}
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num6 = 0;
							}
							goto IL_02ed;
						}
						goto IL_0322;
						IL_0322:
						kLEeyVvLrgg0qFDFymfM(enumerator);
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num6 = 2;
						}
						goto IL_02ed;
						IL_02ed:
						switch (num6)
						{
						case 1:
							goto end_IL_02c8;
						case 2:
							goto end_IL_02c8;
						}
						goto IL_0322;
						end_IL_02c8:;
					}
				case 2:
					enumerator = (from p in moduleFullTextSearchExtensions.SelectMany((IModuleFullTextSearchExtension p) => p.GetDynamicFieldsMapping().EmptyIfNull())
						where p.Value != null
						select p).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static void kLEeyVvLrgg0qFDFymfM(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool QeLvdlvLd6TD3B9URPhC()
		{
			return nJCYlcvL9OtnAKNyJkN3 == null;
		}

		internal static MappingCardEntityField lo0xrJvLlUmkUafQe2Yv()
		{
			return (MappingCardEntityField)nJCYlcvL9OtnAKNyJkN3;
		}
	}

	private class MappingCardEntityFieldItem
	{
		private Guid cardUid;

		private Guid entityTypeUid;

		private List<string> importantProperties;

		private static object GAduxFvLgUS0cyPXTbWt;

		public Type CardType
		{
			[CompilerGenerated]
			get
			{
				return _003CCardType_003Ek__BackingField;
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
					case 1:
						_003CCardType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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

		public Guid CardUid => cardUid;

		public Guid EntityTypeUid => entityTypeUid;

		public List<string> ImportantProperties => importantProperties;

		public MappingCardEntityFieldItem(Type cardType, Guid entityTypeUid, List<string> importantProperties)
		{
			SingletonReader.JJCZtPuTvSt();
			this.importantProperties = new List<string>();
			base._002Ector();
			this.entityTypeUid = entityTypeUid;
			this.importantProperties = importantProperties ?? new List<string>();
			CardType = cardType;
			cardUid = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetCardUidByCardType(cardType) ?? Guid.Empty;
		}

		public void Add(List<string> importantProperties)
		{
			if (importantProperties == null)
			{
				return;
			}
			foreach (string importantProperty in importantProperties)
			{
				if (!this.importantProperties.Contains(importantProperty))
				{
					this.importantProperties.Add(importantProperty);
				}
			}
		}

		internal static bool aIGs8MvL53LiLYE7A6h9()
		{
			return GAduxFvLgUS0cyPXTbWt == null;
		}

		internal static MappingCardEntityFieldItem pIlntivLjlLgC2YPeuiw()
		{
			return (MappingCardEntityFieldItem)GAduxFvLgUS0cyPXTbWt;
		}
	}

	private List<IFullTextSearchObjectHandlerExtension> handlerPoints;

	private MappingCardHandlerObject mappingCardHandlerField;

	private MappingCardEntityField mappingCardEntityField;

	private List<IModuleFullTextSearchExtension> points;

	private bool isCreatingMapping;

	internal static FullTextTypeMappingService M8ZWnSGS3vcprUSZ0fkT;

	private List<IFullTextSearchObjectHandlerExtension> HandlerPoints => handlerPoints ?? (handlerPoints = ComponentManager.Current.GetExtensionPoints<IFullTextSearchObjectHandlerExtension>().ToList());

	private List<IModuleFullTextSearchExtension> Points => points ?? (points = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList());

	public IFullTextTypeMappingAvailability CheckAvailability()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return FullTextTypeMappingAvailability.NotAvailable((string)LHxClnGSDWwN0NKqR8cW(-138018305 ^ -138031923));
			case 1:
				if (!isCreatingMapping)
				{
					return (IFullTextTypeMappingAvailability)cyeIeoGStP9WBPNG2i1w();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CreateMapping()
	{
		//Discarded unreachable code: IL_0047, IL_00c6, IL_00d0, IL_012f, IL_02ca, IL_02dd, IL_02ec, IL_03b5, IL_03c8, IL_03d7, IL_0408, IL_041b, IL_042a
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				isCreatingMapping = true;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				List<IFullTextSearchObjectHandlerExtension>.Enumerator enumerator = default(List<IFullTextSearchObjectHandlerExtension>.Enumerator);
				IFullTextSearchObjectHandlerExtension current = default(IFullTextSearchObjectHandlerExtension);
				List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
				_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
				Guid current2 = default(Guid);
				ClassMetadata classMetadata = default(ClassMetadata);
				List<ClassMetadata> childClasses = default(List<ClassMetadata>);
				while (true)
				{
					switch (num)
					{
					case 4:
						return;
					case 2:
						enumerator = HandlerPoints.GetEnumerator();
						num = 3;
						continue;
					default:
						mappingCardHandlerField = new MappingCardHandlerObject();
						num = 2;
						continue;
					case 1:
						break;
					case 3:
						try
						{
							while (true)
							{
								IL_033e:
								int num2;
								if (!enumerator.MoveNext())
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
									{
										num2 = 3;
									}
									goto IL_00d4;
								}
								goto IL_0116;
								IL_0116:
								current = enumerator.Current;
								num2 = 4;
								goto IL_00d4;
								IL_00d4:
								while (true)
								{
									switch (num2)
									{
									default:
										enumerator2 = current.SupportedUids.GetEnumerator();
										num2 = 7;
										continue;
									case 5:
										break;
									case 7:
										try
										{
											while (true)
											{
												IL_01f5:
												int num3;
												if (!enumerator2.MoveNext())
												{
													num3 = 2;
													goto IL_013d;
												}
												goto IL_0197;
												IL_013d:
												while (true)
												{
													switch (num3)
													{
													case 4:
														_003C_003Ec__DisplayClass14_.typeUids.Add(current2);
														num3 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
														{
															num3 = 0;
														}
														continue;
													case 6:
														break;
													case 1:
														if (classMetadata != null)
														{
															num3 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
															{
																num3 = 3;
															}
															continue;
														}
														goto case 4;
													case 5:
														classMetadata = MetadataLoader.LoadMetadata(current2) as ClassMetadata;
														num3 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
														{
															num3 = 1;
														}
														continue;
													default:
														goto IL_01f5;
													case 3:
													{
														childClasses = MetadataLoader.GetChildClasses(classMetadata);
														int num4 = 7;
														num3 = num4;
														continue;
													}
													case 7:
														if (childClasses.Any())
														{
															num3 = 9;
															continue;
														}
														goto case 4;
													case 8:
														if (!_003C_003Ec__DisplayClass14_.typeUids.Contains(current2))
														{
															num3 = 5;
															continue;
														}
														goto IL_01f5;
													case 9:
														childClasses.ForEach(_003C_003Ec__DisplayClass14_._003CCreateMapping_003Eb__0);
														num3 = 4;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
														{
															num3 = 3;
														}
														continue;
													case 2:
														goto end_IL_01f5;
													}
													break;
												}
												goto IL_0197;
												IL_0197:
												current2 = enumerator2.Current;
												num3 = 8;
												goto IL_013d;
												continue;
												end_IL_01f5:
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator2).Dispose();
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
										}
										goto case 2;
									case 4:
										_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
										num2 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
										{
											num2 = 1;
										}
										continue;
									case 1:
										_003C_003Ec__DisplayClass14_.typeUids = new List<Guid>();
										num2 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
										{
											num2 = 0;
										}
										continue;
									case 6:
										goto IL_033e;
									case 2:
										mappingCardHandlerField.AddMappings(xyK2Y9GSwABOc65U1EW9(current), current, _003C_003Ec__DisplayClass14_.typeUids);
										num2 = 6;
										continue;
									case 3:
										goto end_IL_033e;
									}
									break;
								}
								goto IL_0116;
								continue;
								end_IL_033e:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
						break;
					}
					mappingCardEntityField = new MappingCardEntityField(Points);
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num = 1;
					}
				}
			}
			finally
			{
				isCreatingMapping = false;
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	public Dictionary<Guid, List<string>> GetImportantProperties(Guid objectTypeUid)
	{
		Dictionary<Guid, List<string>> dictionary = new Dictionary<Guid, List<string>>();
		List<MappingCardHandlerObjectItem> list = mappingCardHandlerField.Where(objectTypeUid);
		if (list.Any())
		{
			foreach (MappingCardHandlerObjectItem item in list)
			{
				if (dictionary.ContainsKey(item.CardUid))
				{
					foreach (string getImportantProperty in item.HandlerPoint.GetImportantProperties)
					{
						if (!dictionary[item.CardUid].Contains(getImportantProperty))
						{
							dictionary[item.CardUid].Add(getImportantProperty);
						}
					}
				}
				else
				{
					dictionary.Add(item.CardUid, item.HandlerPoint.GetImportantProperties);
				}
			}
			return dictionary;
		}
		return dictionary;
	}

	public Dictionary<Guid, List<string>> GetVisualDataProperties(Guid objectTypeUid)
	{
		Dictionary<Guid, List<string>> dictionary = new Dictionary<Guid, List<string>>();
		List<MappingCardHandlerObjectItem> list = mappingCardHandlerField.Where(objectTypeUid);
		if (list.Any())
		{
			foreach (MappingCardHandlerObjectItem item in list)
			{
				if (dictionary.ContainsKey(item.CardUid))
				{
					foreach (string getVisualDataProperty in item.HandlerPoint.GetVisualDataProperties)
					{
						if (!dictionary[item.CardUid].Contains(getVisualDataProperty))
						{
							dictionary[item.CardUid].Add(getVisualDataProperty);
						}
					}
				}
				else
				{
					dictionary.Add(item.CardUid, item.HandlerPoint.GetVisualDataProperties);
				}
			}
			return dictionary;
		}
		return dictionary;
	}

	public Dictionary<Guid, List<string>> GetImportantDynamicProperties(Guid objectTypeUid)
	{
		Dictionary<Guid, List<string>> dictionary = new Dictionary<Guid, List<string>>();
		IEnumerable<MappingCardEntityFieldItem> enumerable = mappingCardEntityField.Where(objectTypeUid);
		if (enumerable.Any())
		{
			foreach (MappingCardEntityFieldItem item in enumerable)
			{
				if (dictionary.ContainsKey(item.CardUid))
				{
					foreach (string importantProperty in item.ImportantProperties)
					{
						if (!dictionary[item.CardUid].Contains(importantProperty))
						{
							dictionary[item.CardUid].Add(importantProperty);
						}
					}
				}
				else
				{
					dictionary.Add(item.CardUid, item.ImportantProperties);
				}
			}
			return dictionary;
		}
		return dictionary;
	}

	public List<KeyValuePair<string, object>> OnInsertProcessing(Guid objectTypeUid, object obj)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.objectTypeUid = objectTypeUid;
		CS_0024_003C_003E8__locals0.obj = obj;
		List<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();
		(from m in mappingCardHandlerField.Where(CS_0024_003C_003E8__locals0.objectTypeUid)
			select m.HandlerPoint).Distinct().ForEach(delegate(IFullTextSearchObjectHandlerExtension p)
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
					_003C_003Ec__DisplayClass18_0.VjdZDcvUWy4NqsbXqEy3(p, CS_0024_003C_003E8__locals0.objectTypeUid, CS_0024_003C_003E8__locals0.obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return result;
	}

	public List<KeyValuePair<string, object>> OnDeleteProcessing(Guid objectTypeUid, object obj)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.objectTypeUid = objectTypeUid;
		CS_0024_003C_003E8__locals0.obj = obj;
		List<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();
		if (IsSupported(CS_0024_003C_003E8__locals0.objectTypeUid))
		{
			(from m in mappingCardHandlerField.Where(CS_0024_003C_003E8__locals0.objectTypeUid)
				select (IFullTextSearchObjectHandlerExtension)_003C_003Ec.kLqWp3vUE5WyC0G199kO(m)).Distinct().ForEach(delegate(IFullTextSearchObjectHandlerExtension p)
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
						_003C_003Ec__DisplayClass19_0.mHvB8pvU8HDpi2boGYdh(p, CS_0024_003C_003E8__locals0.objectTypeUid, CS_0024_003C_003E8__locals0.obj);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		return result;
	}

	public bool IsSupported(Guid objectTypeUid)
	{
		return MwKS92GS4WjuLrLZ5avO(mappingCardHandlerField, objectTypeUid);
	}

	public List<QueueToIndex> GetQueueToIndex(List<KeyValuePair<string, object>> item, long id, Guid objectTypeUid)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.item = item;
		CS_0024_003C_003E8__locals0.id = id;
		CS_0024_003C_003E8__locals0.objectTypeUid = objectTypeUid;
		CS_0024_003C_003E8__locals0.retunList = new List<QueueToIndex>();
		(from m in mappingCardHandlerField.Where(CS_0024_003C_003E8__locals0.objectTypeUid)
			select (IFullTextSearchObjectHandlerExtension)_003C_003Ec.kLqWp3vUE5WyC0G199kO(m)).Distinct().ForEach(delegate(IFullTextSearchObjectHandlerExtension p)
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
					CS_0024_003C_003E8__locals0.retunList.AddRange(p.ProcessingMergedIndexQueue(CS_0024_003C_003E8__locals0.item, CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.objectTypeUid));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.retunList;
	}

	public FullTextTypeMappingService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NMM0wLGS6ZIfXxLd0GCw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object LHxClnGSDWwN0NKqR8cW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cyeIeoGStP9WBPNG2i1w()
	{
		return FullTextTypeMappingAvailability.Available();
	}

	internal static bool cgm4uFGSpkkVtwnTZWX9()
	{
		return M8ZWnSGS3vcprUSZ0fkT == null;
	}

	internal static FullTextTypeMappingService Xio517GSa1S3GHulkNx3()
	{
		return M8ZWnSGS3vcprUSZ0fkT;
	}

	internal static Type xyK2Y9GSwABOc65U1EW9(object P_0)
	{
		return ((IFullTextSearchObjectHandlerExtension)P_0).SupportedCard;
	}

	internal static bool MwKS92GS4WjuLrLZ5avO(object P_0, Guid objectUid)
	{
		return ((MappingCardHandlerObject)P_0).Any(objectUid);
	}

	internal static void NMM0wLGS6ZIfXxLd0GCw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

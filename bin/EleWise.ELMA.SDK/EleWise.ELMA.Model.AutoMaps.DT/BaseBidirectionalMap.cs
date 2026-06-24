using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.Collections;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal abstract class BaseBidirectionalMap<TSource> : IInternalMapperConfiguration
{
	private bool configured;

	private bool configuredReverse;

	private readonly IDictionary<string, PropertyMap> propertyMaps;

	private readonly IDictionary<string, PropertyMap> propertyMapsReverse;

	private readonly List<Expression<Func<TSource, object>>> ignoreExpressions;

	private readonly List<Expression<Func<TSource, object>>> ignoreExpressionsReverse;

	internal static object oQ2Ia4h0BrAvBHsLsRT5;

	private List<Action<PropertyMap>> PropertyMapActions { get; }

	private List<Action<PropertyMap>> PropertyMapActionsReverse { get; }

	public Type SourceType => TypeOf<TSource>.Raw;

	public string TypeRef { get; }

	internal Action<object, DataClass> CustomBeforeMap { get; set; }

	internal Action<object, DataClass> CustomMap { get; set; }

	internal Action<DataClass, object> CustomBeforeMapReverse { get; set; }

	internal Action<DataClass, object> CustomMapReverse { get; set; }

	internal BaseBidirectionalMap(string typeRef)
	{
		//Discarded unreachable code: IL_014d, IL_0152
		SingletonReader.JJCZtPuTvSt();
		propertyMaps = new Dictionary<string, PropertyMap>();
		propertyMapsReverse = new Dictionary<string, PropertyMap>();
		ignoreExpressions = new List<Expression<Func<TSource, object>>>();
		ignoreExpressionsReverse = new List<Expression<Func<TSource, object>>>();
		PropertyMapActions = new List<Action<PropertyMap>>();
		PropertyMapActionsReverse = new List<Action<PropertyMap>>();
		CustomBeforeMap = delegate
		{
		};
		CustomMap = delegate
		{
		};
		CustomBeforeMapReverse = delegate
		{
		};
		CustomMapReverse = delegate
		{
		};
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				TypeRef = typeRef;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public object CreateSourceInstance(DataClass dataClass)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ConfigureReverse();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return BaseBidirectionalMapStatics.InstanceCreators.First((IInstanceCreator a) => a.CanCreateInstance(SourceType)).CreateInstance(dataClass, SourceType);
			}
		}
	}

	public DataClass CreateDestinationInstance()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new DataClass(Locator.GetServiceNotNull<DataClassDescriptor>().GetValueContainer(TypeRef));
			case 1:
				Configure();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void BeforeMap(object source, DataClass destination, IInternalMapperService mapperService)
	{
	}

	public void Map(object source, DataClass destination, IInternalMapperService mapperService)
	{
		//Discarded unreachable code: IL_0105, IL_0121, IL_017d, IL_0240, IL_025f, IL_026e, IL_029b, IL_02aa, IL_02d6, IL_0375, IL_0384
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		DataClassMetadata current = default(DataClassMetadata);
		IInternalMapperConfiguration mapper = default(IInternalMapperConfiguration);
		string message = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				Configure();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass21_.destination = destination;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				try
				{
					DataClassMetadata[] array = _003C_003Ec__DisplayClass21_.destination.GetIncludes(onlyFilled: false).ToArray();
					DataClassMetadata dataClassMetadata = array.FirstOrDefault(_003C_003Ec__DisplayClass21_._003CMap_003Eb__0);
					if (dataClassMetadata != null)
					{
						Map(dataClassMetadata, source, _003C_003Ec__DisplayClass21_.destination, mapperService);
					}
					IEnumerator<DataClassMetadata> enumerator = array.Except(new DataClassMetadata[1] { dataClassMetadata }).GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						return;
					}
					try
					{
						while (true)
						{
							IL_01f4:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num4 = 0;
								}
								goto IL_012f;
							}
							goto IL_0187;
							IL_0187:
							current = enumerator.Current;
							num4 = 7;
							goto IL_012f;
							IL_012f:
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 2:
									InternalMap(current, source, _003C_003Ec__DisplayClass21_.destination, mapperService);
									num5 = 5;
									goto IL_012b;
								case 6:
									break;
								case 7:
									mapper = mapperService.GetMapper(current.Uid);
									num5 = 3;
									goto IL_012b;
								case 1:
									mapper.Map(current, source, _003C_003Ec__DisplayClass21_.destination, mapperService);
									num4 = 4;
									continue;
								case 3:
									if (mapper != null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 2;
								case 4:
								case 5:
									goto IL_01f4;
									IL_012b:
									num4 = num5;
									continue;
								}
								break;
							}
							goto IL_0187;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num6 = 1;
							}
							goto IL_0244;
						}
						goto IL_0279;
						IL_0279:
						enumerator.Dispose();
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num6 = 0;
						}
						goto IL_0244;
						IL_0244:
						switch (num6)
						{
						default:
							goto end_IL_021f;
						case 1:
							goto end_IL_021f;
						case 2:
							break;
						case 0:
							goto end_IL_021f;
						}
						goto IL_0279;
						end_IL_021f:;
					}
				}
				catch (Exception ex)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921039377) + TypeRef + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210561207) + SourceType.FullName;
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num7 = 0;
							}
							break;
						case 1:
							Logger.Log.Error(message, ex);
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num7 = 2;
							}
							break;
						case 2:
							throw new Exception(message, ex);
						}
					}
				}
			}
		}
	}

	public void Map(ClassMetadata metadata, object source, DataClass destination, IInternalMapperService mapperService)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				CustomMap(source, destination);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				CustomBeforeMap(source, destination);
				num2 = 5;
				break;
			case 2:
				Configure();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				InternalMap(metadata, source, destination, mapperService);
				num2 = 6;
				break;
			case 1:
				return;
			case 5:
				BeforeMap(source, destination, mapperService);
				num2 = 4;
				break;
			case 3:
				ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36302DA9), () => new HashSet<Guid>()).Add(metadata.ModuleUid);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void BeforeMapReverse(DataClass source, object destination, IInternalMapperService mapperService)
	{
	}

	public void MapReverse(DataClass source, object destination, IInternalMapperService mapperService)
	{
		//Discarded unreachable code: IL_00bf, IL_00db, IL_00ea, IL_00f5, IL_0128, IL_0137, IL_0241, IL_0250, IL_0271, IL_0280, IL_02ac, IL_033a, IL_0349
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		IInternalMapperConfiguration mapper = default(IInternalMapperConfiguration);
		DataClassMetadata current = default(DataClassMetadata);
		string message = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass24_.source = source;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					DataClassMetadata[] array = _003C_003Ec__DisplayClass24_.source.GetIncludes(onlyFilled: true).ToArray();
					DataClassMetadata dataClassMetadata = array.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CMapReverse_003Eb__0);
					if (dataClassMetadata != null)
					{
						MapReverse(dataClassMetadata, _003C_003Ec__DisplayClass24_.source, destination, mapperService);
					}
					IEnumerator<DataClassMetadata> enumerator = array.Except(new DataClassMetadata[1] { dataClassMetadata }).GetEnumerator();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num3 = 1;
					}
					switch (num3)
					{
					case 1:
						try
						{
							while (true)
							{
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 4;
									goto IL_00f9;
								}
								goto IL_0158;
								IL_00f9:
								while (true)
								{
									switch (num4)
									{
									case 1:
									case 3:
										break;
									case 5:
										goto IL_0158;
									case 7:
										mapper = mapperService.GetMapper(current.Uid);
										num4 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
										{
											num4 = 5;
										}
										continue;
									case 2:
										mapper.MapReverse(current, _003C_003Ec__DisplayClass24_.source, destination, mapperService);
										num4 = 3;
										continue;
									default:
										InternalMapReverse(current, _003C_003Ec__DisplayClass24_.source, destination, mapperService);
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
										{
											num4 = 1;
										}
										continue;
									case 6:
										if (mapper != null)
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto default;
									case 4:
										return;
									}
									break;
								}
								continue;
								IL_0158:
								current = enumerator.Current;
								num4 = 7;
								goto IL_00f9;
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num5 = 0;
								}
								goto IL_0226;
							}
							goto IL_025b;
							IL_025b:
							enumerator.Dispose();
							int num6 = 2;
							num5 = num6;
							goto IL_0226;
							IL_0226:
							switch (num5)
							{
							default:
								goto end_IL_0201;
							case 0:
								goto end_IL_0201;
							case 1:
								break;
							case 2:
								goto end_IL_0201;
							}
							goto IL_025b;
							end_IL_0201:;
						}
					case 0:
						break;
					}
					return;
				}
				catch (Exception ex)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							Logger.Log.Error(message, ex);
							num7 = 2;
							continue;
						case 2:
							throw new Exception(message, ex);
						}
						message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A467E2) + TypeRef + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C3C2F1) + SourceType.FullName;
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num7 = 1;
						}
					}
				}
			case 1:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public void MapReverse(ClassMetadata metadata, DataClass source, object destination, IInternalMapperService mapperService)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				BeforeMapReverse(source, destination, mapperService);
				num2 = 4;
				break;
			case 0:
				return;
			case 3:
				ConfigureReverse();
				num2 = 2;
				break;
			case 1:
				CustomMapReverse(source, destination);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				InternalMapReverse(metadata, source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				CustomBeforeMapReverse(source, destination);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private void InternalMap(ClassMetadata metadata, object source, DataClass destination, IInternalMapperService mapperService)
	{
		//Discarded unreachable code: IL_002f, IL_0176, IL_0185, IL_021a, IL_0229, IL_025e, IL_026d, IL_027d, IL_028c, IL_02ab, IL_0305, IL_0314, IL_0323, IL_0332, IL_03a8, IL_03fa, IL_0465, IL_0474, IL_04c4, IL_04d3, IL_0541, IL_05c2, IL_05f5, IL_0660, IL_066f, IL_072f, IL_0899, IL_0902, IL_0911, IL_091c, IL_09c2, IL_0a1f, IL_0a2e, IL_0a82, IL_0a91, IL_0a9c, IL_0b2f, IL_0b8c, IL_0b9b, IL_0bd2, IL_0c36, IL_0c49, IL_0c58
		int num = 1;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		object obj = default(object);
		object @object = default(object);
		Type propertyType2 = default(Type);
		IList list = default(IList);
		object value = default(object);
		Type type = default(Type);
		Type propertyType = default(Type);
		ITypeConverter typeConverter = default(ITypeConverter);
		PropertyMetadata current = default(PropertyMetadata);
		PropertyInfo property = default(PropertyInfo);
		Type propertyType3 = default(Type);
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		IList list2 = default(IList);
		PropertyMap propertyMap = default(PropertyMap);
		IEnumerator enumerator2 = default(IEnumerator);
		IRuntimeTypeDescriptor runtimeTypeDescriptor2 = default(IRuntimeTypeDescriptor);
		Guid simpleTypeUid = default(Guid);
		DataClassSettings dataClassSettings = default(DataClassSettings);
		object current3 = default(object);
		object current2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = metadata.Properties.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_01ee:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 28;
						goto IL_003d;
					}
					goto IL_0127;
					IL_003d:
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 28:
							return;
						case 26:
							break;
						case 55:
							if (_003C_003Ec__DisplayClass26_.runtimeType != null)
							{
								num3 = 36;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num3 = 36;
								}
								continue;
							}
							goto case 7;
						case 7:
						case 10:
						case 11:
						case 18:
						case 20:
						case 24:
						case 34:
							num3 = 16;
							continue;
						case 5:
						case 31:
							obj = @object;
							num3 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num3 = 24;
							}
							continue;
						case 36:
							if (_003C_003Ec__DisplayClass26_.runtimeType != propertyType2.GetNonNullableType())
							{
								num3 = 9;
								continue;
							}
							goto case 7;
						case 37:
							if (@object != null)
							{
								num3 = 5;
								continue;
							}
							goto case 54;
						case 3:
							obj = list;
							num3 = 34;
							continue;
						default:
							goto IL_01ee;
						case 44:
							if (value == null)
							{
								num3 = 23;
								continue;
							}
							goto case 30;
						case 17:
						case 29:
							type = propertyType.GetGenericArguments()[0];
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num3 = 8;
							}
							continue;
						case 9:
							try
							{
								TypeConverter converter = ElmaTypeDescriptorHelper.GetConverter(propertyType2);
								int num9 = 2;
								while (true)
								{
									object obj2;
									switch (num9)
									{
									default:
										goto end_IL_02af;
									case 3:
									case 5:
										typeConverter = BaseBidirectionalMapStatics.TypeConverters.Find(_003C_003Ec__DisplayClass26_._003CInternalMap_003Eb__0);
										num9 = 6;
										continue;
									case 4:
										goto end_IL_02af;
									case 6:
										if (typeConverter != null)
										{
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
											{
												num9 = 1;
											}
											continue;
										}
										goto case 8;
									case 2:
										if (!converter.CanConvertTo(_003C_003Ec__DisplayClass26_.runtimeType))
										{
											num9 = 5;
											continue;
										}
										goto case 7;
									case 7:
										obj = converter.ConvertTo(value, _003C_003Ec__DisplayClass26_.runtimeType);
										num9 = 4;
										continue;
									case 8:
										obj2 = _003C_003Ec__DisplayClass26_.runtimeType.DefaultValue();
										break;
									case 1:
										obj2 = typeConverter.ConvertTo(value, _003C_003Ec__DisplayClass26_.runtimeType);
										break;
									case 0:
										goto end_IL_02af;
									}
									obj = obj2;
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num9 = 0;
									}
									continue;
									end_IL_02af:
									break;
								}
							}
							catch (Exception innerException)
							{
								int num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num10 = 0;
								}
								switch (num10)
								{
								default:
									throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92C97C5), metadata.FullTypeName, metadata.Uid, current.Name, current.Uid), innerException);
								}
							}
							goto case 7;
						case 21:
							if (!(obj.GetType() != propertyType2))
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 33;
						case 39:
							propertyType2 = property.PropertyType;
							num3 = 41;
							continue;
						case 54:
							if (!propertyType3.IsAssignableFromNull())
							{
								goto IL_01ee;
							}
							num4 = 31;
							goto IL_0039;
						case 51:
							if (runtimeTypeDescriptor is ListOfSimpleTypeDescriptor)
							{
								num4 = 21;
								goto IL_0039;
							}
							goto case 22;
						case 19:
							obj = MapToDataClass(value, current.SubTypeUid, mapperService, (DataClass)@object).As(propertyType);
							num3 = 11;
							continue;
						case 8:
							list2 = (IList)destination.GetObject(metadata.Uid, current.Uid);
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num3 = 42;
							}
							continue;
						case 40:
							property = propertyMap.Property;
							num3 = 2;
							continue;
						case 16:
							try
							{
								destination.SetObject(metadata.Uid, current.Uid, obj);
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num11 = 0;
								}
								switch (num11)
								{
								case 0:
									break;
								}
							}
							catch (Exception innerException2)
							{
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num12 = 0;
								}
								switch (num12)
								{
								default:
									throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F98544), metadata.FullTypeName, metadata.Uid, current.Name, current.Uid), innerException2);
								}
							}
							goto IL_01ee;
						case 50:
							value = property.GetValue(source);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num3 = 25;
							}
							continue;
						case 42:
							enumerator2 = ((IEnumerable)value).GetEnumerator();
							num4 = 47;
							goto IL_0039;
						case 48:
							if (!propertyMap.Ignored)
							{
								num3 = 40;
								continue;
							}
							goto IL_01ee;
						case 43:
							@object = destination.GetObject(metadata.Uid, current.Uid);
							num3 = 50;
							continue;
						case 45:
							if (propertyMap == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 48;
						case 52:
							propertyType = destination.GetProperty(metadata, current).PropertyType;
							num3 = 53;
							continue;
						case 4:
							runtimeTypeDescriptor2 = (IRuntimeTypeDescriptor)MetadataServiceContext.Service.GetTypeDescriptor(simpleTypeUid, Guid.Empty);
							num3 = 27;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 22;
							}
							continue;
						case 30:
							if ((dataClassSettings = current.Settings as DataClassSettings) != null)
							{
								num3 = 39;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num3 = 52;
								}
								continue;
							}
							goto case 7;
						case 25:
							obj = value;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num3 = 15;
							}
							continue;
						case 38:
							if (runtimeTypeDescriptor == null)
							{
								num4 = 7;
								goto IL_0039;
							}
							goto case 55;
						case 22:
							_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
							num3 = 32;
							continue;
						case 33:
							simpleTypeUid = ((ListOfSimpleTypeSettings)current.Settings).SimpleTypeUid;
							num3 = 4;
							continue;
						case 15:
							if (current.SubTypeUid != Guid.Empty)
							{
								num3 = 44;
								continue;
							}
							goto case 35;
						case 41:
							if ((runtimeTypeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(current.TypeUid, current.SubTypeUid) as IRuntimeTypeDescriptor) == null)
							{
								num3 = 20;
								continue;
							}
							goto case 51;
						case 2:
							if (!property.CanRead)
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 43;
						case 35:
							if (obj != null)
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num3 = 39;
								}
								continue;
							}
							goto case 1;
						case 53:
							if (dataClassSettings.RelationType != 0)
							{
								num3 = 17;
								continue;
							}
							goto case 19;
						case 13:
							obj = list2;
							num3 = 18;
							continue;
						case 27:
							list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(runtimeTypeDescriptor2.RuntimeType));
							num3 = 49;
							continue;
						case 47:
							try
							{
								while (true)
								{
									IL_093a:
									int num7;
									if (!enumerator2.MoveNext())
									{
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num7 = 0;
										}
										goto IL_0920;
									}
									goto IL_0960;
									IL_0960:
									current3 = enumerator2.Current;
									num7 = 3;
									goto IL_0920;
									IL_0920:
									while (true)
									{
										switch (num7)
										{
										case 2:
											goto IL_093a;
										case 1:
											goto IL_0960;
										case 3:
											list2.Add((current3 != null) ? MapToDataClass(current3, current.SubTypeUid, mapperService).As(type) : null);
											num7 = 2;
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
								IDisposable disposable = enumerator2 as IDisposable;
								int num8 = 2;
								while (true)
								{
									switch (num8)
									{
									case 1:
										disposable.Dispose();
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num8 = 0;
										}
										continue;
									case 2:
										if (disposable != null)
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
											{
												num8 = 1;
											}
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 13;
						case 14:
							propertyMap = FindPropertyMap(current.Name);
							num3 = 45;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num3 = 26;
							}
							continue;
						case 1:
							propertyType3 = destination.GetProperty(metadata, current).PropertyType;
							num3 = 37;
							continue;
						case 46:
							try
							{
								while (true)
								{
									IL_0aba:
									int num5;
									if (!enumerator2.MoveNext())
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
										{
											num5 = 0;
										}
										goto IL_0aa0;
									}
									goto IL_0ae0;
									IL_0ae0:
									current2 = enumerator2.Current;
									num5 = 3;
									goto IL_0aa0;
									IL_0aa0:
									while (true)
									{
										switch (num5)
										{
										case 2:
											goto IL_0aba;
										case 1:
											goto IL_0ae0;
										case 3:
											list.Add(current2);
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
											{
												num5 = 1;
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
								IDisposable disposable = enumerator2 as IDisposable;
								int num6 = 2;
								while (true)
								{
									switch (num6)
									{
									case 1:
										disposable.Dispose();
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
										{
											num6 = 0;
										}
										continue;
									case 2:
										if (disposable != null)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
											{
												num6 = 1;
											}
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 3;
						case 49:
							enumerator2 = ((IEnumerable)obj).GetEnumerator();
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 46;
							}
							continue;
						case 32:
							{
								_003C_003Ec__DisplayClass26_.runtimeType = runtimeTypeDescriptor.RuntimeType ?? value.GetType();
								num4 = 38;
								goto IL_0039;
							}
							IL_0039:
							num3 = num4;
							continue;
						}
						break;
					}
					goto IL_0127;
					IL_0127:
					current = enumerator.Current;
					num3 = 14;
					goto IL_003d;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num13 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num13 = 0;
				}
				switch (num13)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void InternalMapReverse(ClassMetadata metadata, DataClass source, object destination, IInternalMapperService mapperService)
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0252, IL_0285, IL_02f0, IL_036b, IL_037a, IL_0389, IL_03fe, IL_0483, IL_0492, IL_0614, IL_0627, IL_0636, IL_0647, IL_06e8, IL_0714, IL_07d7, IL_07e1, IL_089f, IL_0904, IL_090f, IL_0954, IL_097a, IL_0989, IL_0a03, IL_0acc, IL_0af2, IL_0afc, IL_0b0b, IL_0b62, IL_0bcd, IL_0bdc, IL_0c02, IL_0c11, IL_0c97, IL_0ca6, IL_0cb1, IL_0d58, IL_0d6b, IL_0dfe, IL_0e0d, IL_0e1d, IL_0e2c, IL_0e3d, IL_0e4c, IL_0ef1, IL_0f04, IL_0f70, IL_0f7f, IL_0fe6, IL_1019, IL_1084, IL_1093, IL_10cf, IL_110d, IL_1117, IL_112a, IL_1148, IL_1172, IL_1181, IL_11d3, IL_11e2, IL_128d, IL_12a0, IL_12af
		int num = 1;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		Type type = default(Type);
		PropertyInfo property = default(PropertyInfo);
		IList list3 = default(IList);
		Type propertyType = default(Type);
		object obj = default(object);
		IEnumerator enumerator3 = default(IEnumerator);
		object @object = default(object);
		UntypedISetProxy untypedISetProxy = default(UntypedISetProxy);
		Array array3 = default(Array);
		int num6 = default(int);
		int num7 = default(int);
		PropertyMap propertyMap = default(PropertyMap);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		List<object> list = default(List<object>);
		int num21 = default(int);
		object[] array = default(object[]);
		object value = default(object);
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		IList list2 = default(IList);
		Type itemSimpleType = default(Type);
		ListOfSimpleTypeDescriptor listOfSimpleTypeDescriptor = default(ListOfSimpleTypeDescriptor);
		object current4 = default(object);
		Type elementType = default(Type);
		Array array2 = default(Array);
		int num5 = default(int);
		TypeConverter converter = default(TypeConverter);
		object current3 = default(object);
		DataClassSettings dataClassSettings = default(DataClassSettings);
		object current2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = metadata.Properties.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_11b4:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 87;
						goto IL_0049;
					}
					goto IL_04be;
					IL_0049:
					int num4 = num3;
					goto IL_004d;
					IL_04be:
					current = enumerator.Current;
					num4 = 73;
					goto IL_004d;
					IL_004d:
					while (true)
					{
						object obj4;
						object obj2;
						switch (num4)
						{
						case 87:
							return;
						case 32:
							if (!(type != null))
							{
								num4 = 69;
								continue;
							}
							goto case 99;
						case 89:
							if (!(property == null))
							{
								num4 = 70;
								continue;
							}
							goto IL_11b4;
						case 60:
							try
							{
								list3 = (IList)Activator.CreateInstance(propertyType);
								int num19 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num19 = 0;
								}
								switch (num19)
								{
								case 0:
									break;
								}
							}
							catch (Exception innerException3)
							{
								int num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
								{
									num20 = 0;
								}
								switch (num20)
								{
								default:
									throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B830C2), metadata.FullTypeName, metadata.Uid, current.Name, current.Uid), innerException3);
								}
							}
							goto case 38;
						case 18:
						case 40:
							obj = list3;
							num4 = 42;
							continue;
						case 31:
							enumerator3 = ((IEnumerable)@object).GetEnumerator();
							num4 = 93;
							continue;
						case 45:
							if (untypedISetProxy != null)
							{
								goto IL_0327;
							}
							goto case 44;
						case 54:
							list3 = array3;
							num4 = 18;
							continue;
						case 13:
						case 63:
							if (num6 >= num7)
							{
								num4 = 54;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num4 = 9;
								}
								continue;
							}
							goto case 92;
						case 67:
							if (!property.CanWrite)
							{
								num4 = 28;
								continue;
							}
							goto case 78;
						case 82:
							untypedISetProxy.Clear();
							num4 = 5;
							continue;
						case 42:
						case 86:
							if (!propertyType.IsInstanceOfType(obj))
							{
								num4 = 102;
								continue;
							}
							goto case 44;
						case 39:
							property = propertyMap.Property;
							num4 = 67;
							continue;
						case 84:
							enumerator2 = list.GetEnumerator();
							num4 = 71;
							continue;
						case 55:
							num21++;
							num4 = 59;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num4 = 24;
							}
							continue;
						case 92:
							array3.SetValue(array[num6], num6);
							num4 = 62;
							continue;
						case 41:
						case 100:
							obj = value;
							num4 = 81;
							continue;
						case 75:
						case 85:
							if (!(type == typeof(ISet<>)))
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 21;
						case 49:
							if (obj != null)
							{
								num4 = 33;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num4 = 103;
								}
								continue;
							}
							goto case 37;
						case 77:
							break;
						case 20:
							if (@object != null)
							{
								num4 = 14;
								continue;
							}
							goto IL_11b4;
						case 23:
							propertyType = property.PropertyType;
							num4 = 24;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num4 = 15;
							}
							continue;
						case 30:
							goto IL_0505;
						case 58:
							if ((runtimeTypeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(current.TypeUid, current.SubTypeUid) as IRuntimeTypeDescriptor) == null)
							{
								num4 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num4 = 86;
								}
								continue;
							}
							goto case 47;
						case 73:
							propertyMap = FindPropertyMapReverse(current.Name);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 104;
							}
							continue;
						case 10:
							goto IL_058a;
						case 72:
							obj = list2;
							num4 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num4 = 61;
							}
							continue;
						case 3:
							array = ((IEnumerable)obj).Cast<object>().ToArray();
							num4 = 98;
							continue;
						case 9:
						case 65:
						case 69:
							list2 = (IList)Activator.CreateInstance(propertyType);
							num4 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num4 = 84;
							}
							continue;
						case 50:
							obj4 = null;
							goto IL_1215;
						case 5:
							enumerator2 = list.GetEnumerator();
							num4 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num4 = 18;
							}
							continue;
						case 70:
							if (property.CanWrite)
							{
								num4 = 78;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num4 = 30;
								}
								continue;
							}
							goto IL_11b4;
						case 59:
						case 90:
							if (num21 >= num7)
							{
								num4 = 40;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num4 = 23;
								}
								continue;
							}
							goto case 68;
						case 53:
							goto IL_06b8;
						case 56:
							list = new List<object>();
							num4 = 31;
							continue;
						case 52:
							num6 = 0;
							num4 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num4 = 4;
							}
							continue;
						case 76:
							if (obj != null)
							{
								num4 = 58;
								continue;
							}
							goto case 27;
						case 95:
							itemSimpleType = listOfSimpleTypeDescriptor.GetItemSimpleType(current);
							num4 = 28;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num4 = 33;
							}
							continue;
						case 47:
							if ((listOfSimpleTypeDescriptor = runtimeTypeDescriptor as ListOfSimpleTypeDescriptor) != null)
							{
								num4 = 91;
								continue;
							}
							goto case 42;
						case 74:
						case 101:
							list3 = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemSimpleType));
							num4 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num4 = 66;
							}
							continue;
						case 98:
							num7 = array.Length;
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num4 = 6;
							}
							continue;
						case 93:
							try
							{
								while (true)
								{
									int num17;
									if (!enumerator3.MoveNext())
									{
										num17 = 2;
										goto IL_07e5;
									}
									goto IL_0815;
									IL_07e5:
									while (true)
									{
										switch (num17)
										{
										case 1:
											break;
										case 3:
											goto IL_0815;
										default:
											list.Add((current4 != null) ? MapToClass((DataClass)current4, elementType, mapperService) : null);
											num17 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
											{
												num17 = 1;
											}
											continue;
										case 2:
											goto end_IL_07ff;
										}
										break;
									}
									continue;
									IL_0815:
									current4 = enumerator3.Current;
									num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num17 = 0;
									}
									goto IL_07e5;
									continue;
									end_IL_07ff:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator3 as IDisposable;
								int num18 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num18 = 1;
								}
								while (true)
								{
									switch (num18)
									{
									case 2:
										disposable.Dispose();
										num18 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
										{
											num18 = 0;
										}
										continue;
									case 1:
										if (disposable == null)
										{
											num18 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
											{
												num18 = 0;
											}
											continue;
										}
										goto case 2;
									case 0:
										break;
									case 3:
										break;
									}
									break;
								}
							}
							goto case 34;
						case 97:
							array3 = Array.CreateInstance(propertyType.GetElementType(), num7);
							num4 = 52;
							continue;
						case 15:
							((IList)array2)[num5] = list[num5];
							num4 = 35;
							continue;
						case 68:
							list3.Add(array[num21]);
							num4 = 55;
							continue;
						case 35:
							num5++;
							num4 = 12;
							continue;
						case 91:
							if (obj.GetType() != propertyType)
							{
								num4 = 3;
								continue;
							}
							goto case 42;
						case 24:
							@object = source.GetObject(metadata.Uid, current.Uid);
							num4 = 83;
							continue;
						case 33:
							if (!(itemSimpleType == null))
							{
								num4 = 74;
								continue;
							}
							goto case 11;
						case 29:
							goto IL_09f7;
						case 6:
							if (!propertyType.IsArray)
							{
								num4 = 17;
								continue;
							}
							goto case 97;
						default:
							goto IL_0a1e;
						case 1:
							if (current.SubTypeUid != Guid.Empty)
							{
								num4 = 57;
								continue;
							}
							goto case 76;
						case 21:
							obj = property.GetValue(destination);
							num4 = 32;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num4 = 49;
							}
							continue;
						case 83:
							obj = @object;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num4 = 1;
							}
							continue;
						case 26:
							try
							{
								int num15;
								if (converter.CanConvertFrom(obj.GetType()))
								{
									num15 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num15 = 2;
									}
									goto IL_0ad0;
								}
								goto IL_0ae6;
								IL_0b16:
								object obj3 = converter.ConvertFrom(null, CultureInfo.InvariantCulture, obj);
								goto IL_0b25;
								IL_0ad0:
								switch (num15)
								{
								case 1:
									goto IL_0ae6;
								case 2:
									goto IL_0b16;
								case 0:
									break;
								}
								goto end_IL_0a9f;
								IL_0ae6:
								obj3 = propertyType.DefaultValue();
								goto IL_0b25;
								IL_0b25:
								obj = obj3;
								num15 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num15 = 0;
								}
								goto IL_0ad0;
								end_IL_0a9f:;
							}
							catch (Exception innerException2)
							{
								int num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num16 = 0;
								}
								switch (num16)
								{
								default:
									throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C8C35B), metadata.FullTypeName, metadata.Uid, current.Name, current.Uid), innerException2);
								}
							}
							goto case 44;
						case 96:
							if (!propertyMap.Ignored)
							{
								num4 = 39;
								continue;
							}
							goto IL_11b4;
						case 43:
							if (propertyType.IsArray)
							{
								num4 = 75;
								continue;
							}
							goto case 32;
						case 28:
							if (property.DeclaringType.IsInterface)
							{
								num4 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto IL_11b4;
						case 19:
							elementType = EnumerableExtensions.GetElementType(propertyType);
							num4 = 51;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num4 = 56;
							}
							continue;
						case 11:
							list3 = new List<object>();
							num4 = 94;
							continue;
						case 71:
							try
							{
								while (true)
								{
									IL_0ccf:
									int num13;
									if (!enumerator2.MoveNext())
									{
										num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num13 = 0;
										}
										goto IL_0cb5;
									}
									goto IL_0d09;
									IL_0d09:
									current3 = enumerator2.Current;
									num13 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num13 = 1;
									}
									goto IL_0cb5;
									IL_0cb5:
									while (true)
									{
										switch (num13)
										{
										case 3:
											goto IL_0ccf;
										case 1:
											list2.Add(current3);
											num13 = 3;
											continue;
										case 2:
											goto IL_0d09;
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
								((IDisposable)enumerator2).Dispose();
								int num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num14 = 0;
								}
								switch (num14)
								{
								case 0:
									break;
								}
							}
							goto case 72;
						case 57:
							if ((dataClassSettings = current.Settings as DataClassSettings) != null)
							{
								num4 = 20;
								continue;
							}
							goto case 44;
						case 4:
						case 79:
							num4 = 60;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num4 = 15;
							}
							continue;
						case 51:
							obj = array2;
							num4 = 44;
							continue;
						case 25:
							obj = MapToClass((DataClass)@object, property.PropertyType, mapperService, value);
							num4 = 80;
							continue;
						case 14:
							if (dataClassSettings.RelationType == RelationType.OneToOne)
							{
								num4 = 25;
								continue;
							}
							goto case 19;
						case 22:
							try
							{
								while (true)
								{
									IL_0e9f:
									int num10;
									if (!enumerator2.MoveNext())
									{
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num10 = 1;
										}
										goto IL_0e5b;
									}
									goto IL_0e8c;
									IL_0e8c:
									current2 = enumerator2.Current;
									num10 = 3;
									goto IL_0e5b;
									IL_0e5b:
									while (true)
									{
										switch (num10)
										{
										case 3:
										{
											untypedISetProxy.Add(current2);
											int num11 = 2;
											num10 = num11;
											continue;
										}
										case 2:
											goto IL_0e9f;
										case 1:
											goto end_IL_0e9f;
										}
										break;
									}
									goto IL_0e8c;
									continue;
									end_IL_0e9f:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num12 = 0;
								}
								switch (num12)
								{
								case 0:
									break;
								}
							}
							goto case 44;
						case 62:
							num6++;
							num4 = 63;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num4 = 61;
							}
							continue;
						case 102:
							goto IL_0f2e;
						case 34:
							if (!propertyType.IsGenericType)
							{
								num4 = 50;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num4 = 2;
								}
								continue;
							}
							obj4 = propertyType.GetGenericTypeDefinition();
							goto IL_1215;
						case 99:
							if (!type.IsInterface)
							{
								num4 = 9;
								continue;
							}
							goto case 75;
						case 104:
							if (propertyMap == null)
							{
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 96;
						case 8:
							try
							{
								property.SetValue(destination, obj);
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							catch (Exception innerException)
							{
								int num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num9 = 0;
								}
								switch (num9)
								{
								default:
									throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20259FC5), metadata.FullTypeName, metadata.Uid, current.Name, current.Uid), innerException);
								}
							}
							goto IL_11b4;
						case 36:
							num5 = 0;
							num4 = 46;
							continue;
						case 17:
						case 48:
							if (propertyType == TypeOf<object>.Raw)
							{
								goto case 95;
							}
							goto IL_10bc;
						case 88:
							if (!converter.CanConvertFrom(obj.GetType()))
							{
								num4 = 30;
								continue;
							}
							goto case 7;
						case 27:
							if (value != null)
							{
								num4 = 100;
								continue;
							}
							goto IL_06b8;
						case 37:
							obj2 = null;
							goto IL_1228;
						case 7:
							num4 = 26;
							continue;
						case 44:
						case 61:
						case 80:
						case 81:
							num4 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num4 = 4;
							}
							continue;
						case 12:
						case 46:
							if (num5 >= list.Count)
							{
								num4 = 21;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num4 = 51;
								}
								continue;
							}
							goto case 15;
						case 2:
						case 64:
							goto IL_11b4;
						case 78:
							value = property.GetValue(destination);
							num4 = 23;
							continue;
						case 38:
						case 66:
						case 94:
							num21 = 0;
							num4 = 90;
							continue;
						case 103:
							{
								obj2 = obj.AsUntypedISet();
								goto IL_1228;
							}
							IL_1228:
							untypedISetProxy = (UntypedISetProxy)obj2;
							num4 = 33;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num4 = 45;
							}
							continue;
							IL_1215:
							type = (Type)obj4;
							num4 = 43;
							continue;
						}
						break;
					}
					goto IL_04be;
					IL_10bc:
					num3 = 79;
					goto IL_0049;
					IL_0f2e:
					converter = System.ComponentModel.TypeDescriptor.GetConverter(propertyType);
					num3 = 88;
					goto IL_0049;
					IL_0a1e:
					array2 = Array.CreateInstance(elementType, list.Count);
					num3 = 36;
					goto IL_0049;
					IL_09f7:
					string text = obj.ToString();
					goto IL_1251;
					IL_06b8:
					if (!propertyType.IsAssignableFromNull())
					{
						continue;
					}
					num3 = 41;
					goto IL_0049;
					IL_1251:
					obj = text;
					num3 = 7;
					goto IL_0049;
					IL_058a:
					property = destination.GetType().GetProperty(current.Name);
					num3 = 89;
					goto IL_0049;
					IL_0505:
					if (!(obj is IFormattable formattable))
					{
						num3 = 29;
						goto IL_0049;
					}
					text = formattable.ToString(null, CultureInfo.InvariantCulture);
					goto IL_1251;
					IL_0327:
					num3 = 82;
					goto IL_0049;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num22 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num22 = 0;
				}
				switch (num22)
				{
				case 0:
					break;
				}
			}
		}
	}

	internal void Ignore(Expression<Func<TSource, object>> ignoreExpression)
	{
		Ignore(PropertyMapActions, ignoreExpressions, ignoreExpression);
	}

	internal void IgnoreReverse(Expression<Func<TSource, object>> ignoreExpression)
	{
		Ignore(PropertyMapActionsReverse, ignoreExpressionsReverse, ignoreExpression);
	}

	private static void Ignore(ICollection<Action<PropertyMap>> actions, ICollection<Expression<Func<TSource, object>>> expressions, Expression<Func<TSource, object>> ignoreExpression)
	{
		actions.Add(delegate(PropertyMap pm)
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
					pm.Ignored = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		expressions.Add(ignoreExpression);
	}

	private void Configure()
	{
		//Discarded unreachable code: IL_008c, IL_00f4, IL_0193, IL_01a2, IL_01e2, IL_0212, IL_0221, IL_0252, IL_028a, IL_0299, IL_02c6
		int num = 5;
		int num2 = num;
		BaseBidirectionalMap<TSource> obj = default(BaseBidirectionalMap<TSource>);
		bool lockTaken = default(bool);
		string message = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				return;
			case 4:
				obj = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (configured)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 6:
							return;
						default:
							try
							{
								Config(propertyMaps, ignoreExpressions, FindPropertyMap, PropertyMapActions);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 2:
										Logger.Log.Error(message, ex);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
										{
											num5 = 0;
										}
										break;
									case 1:
									{
										message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F2A27);
										int num6 = 2;
										num5 = num6;
										break;
									}
									default:
										throw new Exception(message, ex);
									}
								}
							}
							break;
						case 4:
							if (configured)
							{
								return;
							}
							num3 = 3;
							continue;
						case 3:
						case 5:
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							break;
						}
						configured = true;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								Monitor.Exit(obj);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				lockTaken = false;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void ConfigureReverse()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00c7, IL_0133, IL_017b, IL_01ae, IL_0217, IL_024b, IL_027b, IL_028a, IL_0296
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		BaseBidirectionalMap<TSource> obj = default(BaseBidirectionalMap<TSource>);
		string message = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				lockTaken = false;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 1:
				obj = this;
				num2 = 4;
				break;
			case 2:
				if (configuredReverse)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							if (configuredReverse)
							{
								num3 = 4;
								continue;
							}
							break;
						case 5:
							configuredReverse = true;
							num3 = 3;
							continue;
						case 2:
							break;
						case 4:
							return;
						default:
							try
							{
								Config(propertyMapsReverse, ignoreExpressionsReverse, FindPropertyMapReverse, PropertyMapActionsReverse);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										Logger.Log.Error(message, ex);
										num5 = 2;
										continue;
									case 2:
										throw new Exception(message, ex);
									}
									message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811925878);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num5 = 0;
									}
								}
							}
							goto case 5;
						case 3:
							return;
						}
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					int num6;
					if (!lockTaken)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num6 = 1;
						}
						goto IL_024f;
					}
					goto IL_0265;
					IL_0265:
					Monitor.Exit(obj);
					num6 = 2;
					goto IL_024f;
					IL_024f:
					switch (num6)
					{
					case 1:
						goto end_IL_022a;
					case 2:
						goto end_IL_022a;
					}
					goto IL_0265;
					end_IL_022a:;
				}
			case 5:
				return;
			}
		}
	}

	private static void Config(IDictionary<string, PropertyMap> propertyMaps, IEnumerable<Expression<Func<TSource, object>>> expressions, Func<string, PropertyMap> propertyMapFunc, ICollection<Action<PropertyMap>> actions)
	{
		PropertyInfo[] reflectionProperties = InterfaceActivator.TypeOf<TSource>().GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (PropertyInfo propertyInfo in reflectionProperties)
		{
			PropertyMap value = new PropertyMap(propertyInfo);
			propertyMaps[propertyInfo.Name] = value;
		}
		foreach (Expression<Func<TSource, object>> expression in expressions)
		{
			ReadOnlyCollection<ParameterExpression> parameters = expression.Parameters;
			if (parameters.Count != 1)
			{
				continue;
			}
			Expression body = expression.Body;
			MemberExpression memberExpression = body as MemberExpression;
			if (memberExpression == null && body is UnaryExpression unaryExpression && unaryExpression.NodeType == ExpressionType.Convert)
			{
				memberExpression = unaryExpression.Operand as MemberExpression;
			}
			if (memberExpression == null)
			{
				continue;
			}
			PropertyInfo propertyInfo2 = memberExpression.Member as PropertyInfo;
			if (!(propertyInfo2 == null) && !(propertyInfo2.DeclaringType == null))
			{
				if (!propertyInfo2.DeclaringType.IsAssignableFrom(parameters[0].Type))
				{
					throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36337473), propertyInfo2.Name, parameters[0].Type, propertyInfo2.DeclaringType));
				}
				PropertyMap propertyMap = propertyMapFunc(propertyInfo2.Name);
				if (propertyMap != null)
				{
					Apply(propertyMap, actions);
				}
			}
		}
	}

	private PropertyMap FindPropertyMap(string propertyName)
	{
		int num = 1;
		int num2 = num;
		PropertyMap value = default(PropertyMap);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				propertyMaps.TryGetValue(propertyName, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private PropertyMap FindPropertyMapReverse(string propertyName)
	{
		int num = 1;
		int num2 = num;
		PropertyMap value = default(PropertyMap);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				propertyMapsReverse.TryGetValue(propertyName, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void Apply(PropertyMap propertyMap, IEnumerable<Action<PropertyMap>> actions)
	{
		foreach (Action<PropertyMap> action in actions)
		{
			action(propertyMap);
		}
	}

	internal static DataClass MapToDataClass(object value, Guid metadataUid, IInternalMapperService mapperService, DataClass instance = null)
	{
		int num = 5;
		int num2 = num;
		IInternalMapperConfiguration mapper = default(IInternalMapperConfiguration);
		object obj = default(object);
		while (true)
		{
			DataClass dataClass;
			switch (num2)
			{
			case 6:
				return instance;
			case 4:
				mapper = mapperService.GetMapper(obj.GetType(), metadataUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				obj = value.CastAsRealType();
				num2 = 4;
				continue;
			case 1:
				mapper.Map(obj, instance, mapperService);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 6;
				}
				continue;
			case 3:
				mapper.BeforeMap(obj, instance, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				dataClass = instance;
				if ((object)dataClass != null)
				{
					break;
				}
				num2 = 2;
				continue;
			case 2:
				dataClass = mapper.CreateDestinationInstance();
				break;
			}
			instance = dataClass;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
			{
				num2 = 3;
			}
		}
	}

	internal static object MapToClass(DataClass value, Type declaredSourceType, IInternalMapperService mapperService, object instance = null)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_007c, IL_008b
		int num = 8;
		IInternalMapperConfiguration mapper = default(IInternalMapperConfiguration);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (instance == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 1:
					instance = instance.CastAsRealType();
					num2 = 2;
					continue;
				case 2:
				case 5:
					mapper.BeforeMapReverse(value, instance, mapperService);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return instance;
				case 8:
					mapper = mapperService.GetMapper(value, declaredSourceType);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					mapper.MapReverse(value, instance, mapperService);
					num2 = 4;
					continue;
				}
				break;
			}
			instance = mapper.CreateSourceInstance(value);
			num = 5;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 1;
		int num2 = num;
		IInternalMapperConfiguration internalMapperConfiguration = default(IInternalMapperConfiguration);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((internalMapperConfiguration = obj as IInternalMapperConfiguration) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return base.Equals(obj);
			default:
				if (!(internalMapperConfiguration.SourceType == SourceType))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return internalMapperConfiguration.TypeRef == TypeRef;
			case 3:
				return false;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		(Type, string) tuple = default((Type, string));
		while (true)
		{
			switch (num2)
			{
			default:
				return tuple.GetHashCode();
			case 1:
				tuple = (SourceType, TypeRef);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool nda5gph0WdDPQCSCMMtq()
	{
		return oQ2Ia4h0BrAvBHsLsRT5 == null;
	}

	internal static object DuPLI5h0orHZDCaaYR0T()
	{
		return oQ2Ia4h0BrAvBHsLsRT5;
	}
}

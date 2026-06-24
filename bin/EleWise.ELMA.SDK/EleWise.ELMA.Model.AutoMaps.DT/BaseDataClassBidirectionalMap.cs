using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper;

public abstract class BaseDataClassBidirectionalMap<TSource> : IInternalMapperConfiguration
{
	private readonly DefaultDataClassBidirectionalMap<TSource> mapper;

	internal static object QvfJRHh75d5e6ubvwfG4;

	Type IInternalMapperConfiguration.SourceType => mapper.SourceType;

	string IInternalMapperConfiguration.TypeRef => mapper.TypeRef;

	protected BaseDataClassBidirectionalMap(string typeRef)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0096, IL_00a5
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 2;
		}
		string message = default(string);
		while (true)
		{
			switch (num)
			{
			case 4:
				message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766015236) + TypeOf<TSource>.FullName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				throw new Exception(message);
			case 1:
				mapper = new DefaultDataClassBidirectionalMap<TSource>(typeRef)
				{
					CustomBeforeMap = delegate(object src, DataClass dest)
					{
						int num8 = 1;
						int num9 = num8;
						while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 1:
								BeforeMap((TSource)src, dest);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num9 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					},
					CustomMap = delegate(object src, DataClass dest)
					{
						int num6 = 1;
						int num7 = num6;
						while (true)
						{
							switch (num7)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								Map((TSource)src, dest);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num7 = 0;
								}
								break;
							}
						}
					},
					CustomBeforeMapReverse = delegate(DataClass src, object dest)
					{
						int num4 = 1;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								BeforeMapReverse(src, (TSource)dest);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num5 = 0;
								}
								break;
							}
						}
					},
					CustomMapReverse = delegate(DataClass src, object dest)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								MapReverse(src, (TSource)dest);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
				};
				num = 5;
				break;
			case 2:
				if (!string.IsNullOrWhiteSpace(typeRef))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 4;
			default:
				Logger.Log.Error(message);
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	protected void Ignore(Expression<Func<TSource, object>> ignoreExpression)
	{
		mapper.Ignore(ignoreExpression);
	}

	protected void IgnoreReverse(Expression<Func<TSource, object>> ignoreExpression)
	{
		mapper.IgnoreReverse(ignoreExpression);
	}

	internal abstract void BeforeMap(TSource source, DataClass destination);

	internal abstract void Map(TSource source, DataClass destination);

	internal abstract void BeforeMapReverse(DataClass source, TSource destination);

	internal abstract void MapReverse(DataClass source, TSource destination);

	object IInternalMapperConfiguration.CreateSourceInstance(DataClass dataClass)
	{
		return mapper.CreateSourceInstance(dataClass);
	}

	DataClass IInternalMapperConfiguration.CreateDestinationInstance()
	{
		return mapper.CreateDestinationInstance();
	}

	void IInternalMapperConfiguration.BeforeMap(object source, DataClass destination, IInternalMapperService mapperService)
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
				mapper.BeforeMap(source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IInternalMapperConfiguration.Map(object source, DataClass destination, IInternalMapperService mapperService)
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
				mapper.Map(source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IInternalMapperConfiguration.Map(ClassMetadata metadata, object source, DataClass destination, IInternalMapperService mapperService)
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
				mapper.Map(metadata, source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IInternalMapperConfiguration.BeforeMapReverse(DataClass source, object destination, IInternalMapperService mapperService)
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
				mapper.BeforeMapReverse(source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IInternalMapperConfiguration.MapReverse(DataClass source, object destination, IInternalMapperService mapperService)
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
				mapper.MapReverse(source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IInternalMapperConfiguration.MapReverse(ClassMetadata metadata, DataClass source, object destination, IInternalMapperService mapperService)
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
				mapper.MapReverse(metadata, source, destination, mapperService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool U2ZbE6h7jYF4UH2XJaYc()
	{
		return QvfJRHh75d5e6ubvwfG4 == null;
	}

	internal static object fHJm8ih7Y81mEFcm1rvS()
	{
		return QvfJRHh75d5e6ubvwfG4;
	}
}

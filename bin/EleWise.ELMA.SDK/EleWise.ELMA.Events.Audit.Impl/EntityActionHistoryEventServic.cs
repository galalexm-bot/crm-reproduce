using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

[Service]
public class EntityActionHistoryEventService : IEntityActionHistoryEventService
{
	private readonly Dictionary<Guid, Type> _typesByUid;

	private bool _initialized;

	private readonly object _lock;

	private static EntityActionHistoryEventService bLw1jvGcwkL6npB20j8c;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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

	public EntityActionHistoryEventService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		nalWVTGcHhciifuIeMGC();
		_lock = new object();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Logger = (ILogger)cTM3x8GcAgcOZwS5Ca0M();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			default:
				_typesByUid = new Dictionary<Guid, Type>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				_initialized = false;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Initialize()
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_011a, IL_0234, IL_0243, IL_02b2, IL_03a8, IL_03e0, IL_0450, IL_045f, IL_0490, IL_04c0, IL_04cf, IL_04db
		int num = 1;
		int num2 = num;
		object @lock = default(object);
		bool lockTaken = default(bool);
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		Type current = default(Type);
		UidAttribute attribute = default(UidAttribute);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 1:
				if (_initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				@lock = _lock;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 3:
				try
				{
					Monitor.Enter(@lock, ref lockTaken);
					int num3 = 5;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 4:
							return;
						case 1:
							try
							{
								while (true)
								{
									int num5;
									if (!aWWFMSGcMKTB2bgCnJZ6(enumerator))
									{
										num5 = 7;
										goto IL_00db;
									}
									goto IL_02bc;
									IL_00db:
									while (true)
									{
										switch (num5)
										{
										case 11:
											throw new InitializationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FE21B8), current.FullName, s01MLNGc0u3ML6yQxKAp(typeof(IEntity).TypeHandle).FullName, s01MLNGc0u3ML6yQxKAp(typeof(Guid).TypeHandle).FullName, s01MLNGc0u3ML6yQxKAp(typeof(Guid).TypeHandle).FullName));
										case 10:
											_typesByUid.Add(Ng4dQIGcmxoro7IXDN1b(attribute), current);
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
											{
												num5 = 8;
											}
											continue;
										case 2:
											if (attribute != null)
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
												{
													num5 = 6;
												}
												continue;
											}
											goto case 4;
										case 1:
										{
											attribute = AttributeHelper<UidAttribute>.GetAttribute(current, inherited: false);
											int num6 = 2;
											num5 = num6;
											continue;
										}
										case 8:
											break;
										default:
											if (!(current == null))
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
												{
													num5 = 1;
												}
												continue;
											}
											break;
										case 4:
											throw new InitializationException(SR.T((string)flQeoeGcx0qWAXc1lEuI(-1998538950 ^ -1998280512), current.FullName, s01MLNGc0u3ML6yQxKAp(typeof(UidAttribute).TypeHandle).FullName));
										case 6:
											if (!_typesByUid.ContainsKey(Ng4dQIGcmxoro7IXDN1b(attribute)))
											{
												num5 = 9;
												continue;
											}
											goto case 5;
										case 3:
											goto IL_02bc;
										case 5:
											throw new InitializationException(SR.T((string)flQeoeGcx0qWAXc1lEuI(-978351861 ^ -978605673), current.FullName, s01MLNGc0u3ML6yQxKAp(typeof(UidAttribute).TypeHandle).FullName));
										case 9:
											if (!UJoTqmGcydfd5GPwVbab(current.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new Type[3]
											{
												s01MLNGc0u3ML6yQxKAp(typeof(IEntity).TypeHandle),
												s01MLNGc0u3ML6yQxKAp(typeof(Guid).TypeHandle),
												s01MLNGc0u3ML6yQxKAp(typeof(Guid).TypeHandle)
											}, null), null))
											{
												num5 = 10;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
												{
													num5 = 6;
												}
												continue;
											}
											goto case 11;
										case 7:
											goto end_IL_01f2;
										}
										break;
									}
									continue;
									IL_02bc:
									current = enumerator.Current;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num5 = 0;
									}
									goto IL_00db;
									continue;
									end_IL_01f2:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										case 1:
											w14UG9GcJepHKn45A11q(enumerator);
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
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
							goto case 3;
						case 3:
							_initialized = true;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							enumerator = ((ComponentManager)HoF81sGc7cwyaYAy4iEN()).GetExtensionPointTypes<IEntityHistoryEventArgs>().GetEnumerator();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num4 = 0;
							}
							break;
						case 5:
							if (_initialized)
							{
								num4 = 4;
								break;
							}
							goto case 2;
						}
					}
				}
				finally
				{
					int num8;
					if (!lockTaken)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num8 = 0;
						}
						goto IL_0494;
					}
					goto IL_04aa;
					IL_04aa:
					Monitor.Exit(@lock);
					num8 = 2;
					goto IL_0494;
					IL_0494:
					switch (num8)
					{
					default:
						goto end_IL_046f;
					case 1:
						break;
					case 0:
						goto end_IL_046f;
					case 2:
						goto end_IL_046f;
					}
					goto IL_04aa;
					end_IL_046f:;
				}
			case 2:
				lockTaken = false;
				num2 = 3;
				break;
			}
		}
	}

	public TEventArgs Create<TEventArgs>(IEntity entity, Guid objectUid, Guid actionUid, Guid eventArgsUid) where TEventArgs : class, IEntityHistoryEventArgs
	{
		Initialize();
		Type eventArgsType = GetEventArgsType(eventArgsUid);
		if (eventArgsType == null)
		{
			return null;
		}
		return (TEventArgs)Activator.CreateInstance(eventArgsType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[3] { entity, objectUid, actionUid }, null);
	}

	public Type GetEventArgsType(Guid eventArgsUid)
	{
		int num = 1;
		int num2 = num;
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Initialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_typesByUid.TryGetValue(eventArgsUid, out value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return value;
			}
		}
	}

	internal static bool iPY3GmGc4nMiC5EY0R42()
	{
		return bLw1jvGcwkL6npB20j8c == null;
	}

	internal static EntityActionHistoryEventService gTSfuyGc6uAlIHQrahSr()
	{
		return bLw1jvGcwkL6npB20j8c;
	}

	internal static void nalWVTGcHhciifuIeMGC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object cTM3x8GcAgcOZwS5Ca0M()
	{
		return NullLogger.Instance;
	}

	internal static object HoF81sGc7cwyaYAy4iEN()
	{
		return ComponentManager.Current;
	}

	internal static object flQeoeGcx0qWAXc1lEuI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type s01MLNGc0u3ML6yQxKAp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid Ng4dQIGcmxoro7IXDN1b(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static bool UJoTqmGcydfd5GPwVbab(object P_0, object P_1)
	{
		return (ConstructorInfo)P_0 == (ConstructorInfo)P_1;
	}

	internal static bool aWWFMSGcMKTB2bgCnJZ6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void w14UG9GcJepHKn45A11q(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}

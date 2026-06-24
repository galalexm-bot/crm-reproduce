using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

[Service]
public class AuditManager : IAuditManager
{
	private static AuditManager aTYJoMGco1EAVXlYI9fW;

	public IEnumerable<IAuditObjectProvider> ObjectProviders { get; set; }

	public IEnumerable<IAuditActionProvider> ActionProviders { get; set; }

	public IEnumerable<IAuditObject> GetObjects()
	{
		Contract.ServiceNotNull(ObjectProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123899632));
		return ObjectProviders.SelectMany((IAuditObjectProvider p) => p.GetObjects());
	}

	public IAuditObject GetObject(Guid uid)
	{
		//Discarded unreachable code: IL_0059, IL_0063, IL_00e6, IL_00f5, IL_013c, IL_0174, IL_0183
		int num = 3;
		int num2 = num;
		IEnumerator<IAuditObjectProvider> enumerator = default(IEnumerator<IAuditObjectProvider>);
		IAuditObject @object = default(IAuditObject);
		IAuditObject result = default(IAuditObject);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = ObjectProviders.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0100:
						int num3;
						if (!znhwu3GcEW0O7kOopS2r(enumerator))
						{
							num3 = 3;
							goto IL_0067;
						}
						goto IL_00b8;
						IL_0067:
						while (true)
						{
							switch (num3)
							{
							default:
								if (@object != null)
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto IL_0100;
							case 4:
								result = @object;
								num3 = 2;
								continue;
							case 5:
								break;
							case 1:
								goto IL_0100;
							case 3:
								goto end_IL_0100;
							case 2:
								return result;
							}
							break;
						}
						goto IL_00b8;
						IL_00b8:
						@object = enumerator.Current.GetObject(uid);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num3 = 0;
						}
						goto IL_0067;
						continue;
						end_IL_0100:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
				goto default;
			default:
				return null;
			case 3:
				Contract.ServiceNotNull(ObjectProviders, (string)hCUrdfGcG0vchK41qVbi(--1333735954 ^ 0x4F7B2D7C));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0.obj = obj;
		Contract.ServiceNotNull(ActionProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671864149));
		return ActionProviders.SelectMany((IAuditActionProvider p) => p.GetActions(CS_0024_003C_003E8__locals0.obj));
	}

	public IAuditAction GetAction(IAuditObject obj, Guid uid)
	{
		//Discarded unreachable code: IL_006c, IL_00a1, IL_00b0, IL_0154, IL_018c
		int num = 2;
		int num2 = num;
		IEnumerator<IAuditActionProvider> enumerator = default(IEnumerator<IAuditActionProvider>);
		IAuditAction auditAction = default(IAuditAction);
		IAuditAction result = default(IAuditAction);
		while (true)
		{
			switch (num2)
			{
			case 2:
				wkMdvQGcfTtI5vot5FFq(ActionProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335262305));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return null;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!znhwu3GcEW0O7kOopS2r(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num3 = 1;
							}
							goto IL_007a;
						}
						goto IL_0114;
						IL_0114:
						auditAction = (IAuditAction)hBsisnGcQKOq7g7oYc3U(enumerator.Current, obj, uid);
						num3 = 2;
						goto IL_007a;
						IL_007a:
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 3:
								result = auditAction;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								break;
							case 2:
								if (auditAction != null)
								{
									int num4 = 3;
									num3 = num4;
									continue;
								}
								break;
							case 4:
								goto IL_0114;
							case 1:
								goto end_IL_00d9;
							}
							break;
						}
						continue;
						end_IL_00d9:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								enumerator.Dispose();
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 1:
				enumerator = ActionProviders.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IAuditAction GetAction(Guid uid)
	{
		//Discarded unreachable code: IL_0085, IL_00d5, IL_00e4, IL_00ef, IL_01ab, IL_01be, IL_01cd, IL_01f8, IL_0230, IL_023f
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		IAuditAction result = default(IAuditAction);
		IAuditObject current = default(IAuditObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass12_.uid = uid;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return result;
			case 3:
				try
				{
					List<IAuditObject> list = GetObjects().ToList();
					List<IAuditAction> list2 = new List<IAuditAction>();
					List<IAuditObject>.Enumerator enumerator = list.GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						case 2:
							break;
						default:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
										{
											num4 = 0;
										}
										goto IL_00f3;
									}
									goto IL_015c;
									IL_015c:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
									{
										num4 = 0;
									}
									goto IL_00f3;
									IL_00f3:
									while (true)
									{
										switch (num4)
										{
										default:
											list2.AddRange(GetActions(current));
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
											{
												num4 = 1;
											}
											continue;
										case 3:
											break;
										case 1:
											goto IL_015c;
										case 2:
											goto end_IL_0136;
										}
										break;
									}
									continue;
									end_IL_0136:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
						}
						result = list2.First(_003C_003Ec__DisplayClass12_._003CGetAction_003Eb__0);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num3 = 1;
						}
					}
				}
				catch
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = null;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				}
			case 2:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public AuditManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lcnd2AGcCfwnHsNkW5be();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object hCUrdfGcG0vchK41qVbi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool znhwu3GcEW0O7kOopS2r(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool j4BNAbGcbnQqmltL6iiV()
	{
		return aTYJoMGco1EAVXlYI9fW == null;
	}

	internal static AuditManager Uvvn85Gch8OrAh0W9M0d()
	{
		return aTYJoMGco1EAVXlYI9fW;
	}

	internal static void wkMdvQGcfTtI5vot5FFq(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object hBsisnGcQKOq7g7oYc3U(object P_0, object P_1, Guid uid)
	{
		return ((IAuditActionProvider)P_0).GetAction((IAuditObject)P_1, uid);
	}

	internal static void lcnd2AGcCfwnHsNkW5be()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

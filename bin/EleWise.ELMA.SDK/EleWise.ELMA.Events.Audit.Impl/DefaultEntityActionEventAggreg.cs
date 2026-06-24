using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit.Impl;

[Component(Order = -1000000)]
public class DefaultEntityActionEventAggregator : IEntityActionEventAggregator
{
	internal static DefaultEntityActionEventAggregator DvpMQQGcOoe7TdyLleF0;

	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		List<ActionEventAggregatorResult> list = new List<ActionEventAggregatorResult>(eventList.Count);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (EntityActionEventArgs @event in eventList)
		{
			string eventKey = GetEventKey(@event);
			if (eventKey == null || hashSet.Contains(eventKey))
			{
				list.Add(new ActionEventAggregatorResult(this, @event, persist: false));
				continue;
			}
			hashSet.Add(eventKey);
			list.Add(new ActionEventAggregatorResult(this, @event, persist: true));
		}
		return list;
	}

	protected virtual bool IsDuplicate(EntityActionEventArgs @event, IEnumerable<ActionEventAggregatorResult> results)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.@event = @event;
		if (CS_0024_003C_003E8__locals0.@event != null)
		{
			return results.Any(delegate(ActionEventAggregatorResult r)
			{
				//Discarded unreachable code: IL_0129, IL_0138, IL_0147, IL_01df, IL_0218, IL_0227, IL_0237, IL_028a, IL_0299, IL_02de, IL_037e, IL_03ad, IL_03bc, IL_0410, IL_041f, IL_047d, IL_048c, IL_049c
				int num = 5;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 14:
							if (_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) == null)
							{
								num2 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num2 = 7;
								}
								continue;
							}
							goto case 26;
						case 7:
						case 11:
							if (_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) == null)
							{
								num2 = 29;
								continue;
							}
							goto case 10;
						case 3:
							if (((IIdentified)_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r))).GetId().Equals(_003C_003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(CS_0024_003C_003E8__locals0.@event))))
							{
								num = 15;
								break;
							}
							goto case 7;
						case 1:
						case 2:
							if (_003C_003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(r.EventArgs) != null)
							{
								num2 = 28;
								continue;
							}
							goto case 23;
						case 21:
							if (((AuditEventArgs)_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)).Object == null)
							{
								num2 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num2 = 30;
								}
								continue;
							}
							goto case 22;
						case 32:
							if (_003C_003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) == null)
							{
								num2 = 12;
								continue;
							}
							goto case 8;
						case 26:
							if (_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(CS_0024_003C_003E8__locals0.@event) != null)
							{
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num2 = 3;
								}
								continue;
							}
							goto case 7;
						case 25:
							if (CS_0024_003C_003E8__locals0.@event.Action == null)
							{
								num2 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num2 = 32;
								}
								continue;
							}
							goto case 10;
						case 31:
							if (!(_003C_003Ec__DisplayClass1_0.KOcWXA8VVlRiWKgRsDP6(_003C_003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r))) == _003C_003Ec__DisplayClass1_0.KOcWXA8VVlRiWKgRsDP6(_003C_003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(CS_0024_003C_003E8__locals0.@event))))
							{
								num2 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num2 = 23;
								}
								continue;
							}
							goto case 32;
						case 9:
						case 15:
							return _003C_003Ec__DisplayClass1_0.FPQo438VqfKJnuIJwhb1(r.EventArgs) == _003C_003Ec__DisplayClass1_0.FPQo438VqfKJnuIJwhb1(CS_0024_003C_003E8__locals0.@event);
						case 10:
						case 16:
						case 17:
						case 20:
						case 33:
							return false;
						case 28:
							if (_003C_003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(CS_0024_003C_003E8__locals0.@event) != null)
							{
								num2 = 31;
								continue;
							}
							goto case 23;
						case 22:
							if (_003C_003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on(CS_0024_003C_003E8__locals0.@event) == null)
							{
								num2 = 24;
								continue;
							}
							goto default;
						case 4:
							if (_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r) == null)
							{
								num2 = 20;
								continue;
							}
							goto case 21;
						case 27:
							if (_003C_003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on(CS_0024_003C_003E8__locals0.@event) != null)
							{
								num2 = 10;
								continue;
							}
							goto case 1;
						case 34:
							if (CS_0024_003C_003E8__locals0.@event.New == null)
							{
								num = 14;
								break;
							}
							goto case 10;
						case 12:
						case 13:
						case 19:
							if (_003C_003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) != null)
							{
								num2 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto case 34;
						case 5:
							if (r != null)
							{
								num2 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
								{
									num2 = 3;
								}
								continue;
							}
							goto case 10;
						case 29:
							if (_003C_003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(CS_0024_003C_003E8__locals0.@event) != null)
							{
								num2 = 16;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 9;
						case 23:
							if (_003C_003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) != null)
							{
								num2 = 33;
								continue;
							}
							goto case 25;
						default:
							if (_003C_003Ec__DisplayClass1_0.y5RCu58Vuh64yOxafEya(r.EventArgs.Object.Uid, _003C_003Ec__DisplayClass1_0.aOkls78VZYvyYRKXcFDl(CS_0024_003C_003E8__locals0.@event.Object)))
							{
								num2 = 2;
								continue;
							}
							goto case 6;
						case 8:
							if (_003C_003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(CS_0024_003C_003E8__locals0.@event) == null)
							{
								num2 = 13;
								continue;
							}
							goto case 18;
						case 6:
						case 24:
						case 30:
							if (_003C_003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r)) == null)
							{
								num = 27;
								break;
							}
							goto case 10;
						case 18:
							if (!_003C_003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(_003C_003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(_003C_003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL(r))).Equals(_003C_003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(_003C_003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(CS_0024_003C_003E8__locals0.@event))))
							{
								num2 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num2 = 4;
								}
								continue;
							}
							goto case 14;
						}
						break;
					}
				}
			});
		}
		return true;
	}

	protected string GetEventKey(EntityActionEventArgs @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (@event == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)D71l9hGct537OsFbdjQr(new string[5]
				{
					(cnHIXGGcPm5mxWMRZr8J(@event) != null) ? ((IAuditObject)cnHIXGGcPm5mxWMRZr8J(@event)).Uid.ToString() : string.Empty,
					(@event.Action != null) ? jqr5PNGcNktaUBbRiv5K(OVjFkNGc17LI5AMC7ckd(@event)).ToString() : string.Empty,
					(eQhv7LGc3Xqvakp7DcJp(@event) != null && nQLF7hGcphRfUGlAxVom(eQhv7LGc3Xqvakp7DcJp(@event)) != null) ? @event.New.GetId().ToString() : string.Empty,
					(U7SnqRGcaNerPQMDX98P(@event) != null && nQLF7hGcphRfUGlAxVom(U7SnqRGcaNerPQMDX98P(@event)) != null) ? nQLF7hGcphRfUGlAxVom(U7SnqRGcaNerPQMDX98P(@event)).ToString() : string.Empty,
					(@event.ActionAuthor != null) ? UAAX8JGcDPBA5ARaWpTL(@event).GetHashCode().ToString() : string.Empty
				});
			default:
				return null;
			}
		}
	}

	public DefaultEntityActionEventAggregator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object cnHIXGGcPm5mxWMRZr8J(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static object OVjFkNGc17LI5AMC7ckd(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static Guid jqr5PNGcNktaUBbRiv5K(object P_0)
	{
		return ((IAuditAction)P_0).Uid;
	}

	internal static object eQhv7LGc3Xqvakp7DcJp(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static object nQLF7hGcphRfUGlAxVom(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object U7SnqRGcaNerPQMDX98P(object P_0)
	{
		return ((EntityActionEventArgs)P_0).Old;
	}

	internal static object UAAX8JGcDPBA5ARaWpTL(object P_0)
	{
		return ((EntityActionEventArgs)P_0).ActionAuthor;
	}

	internal static object D71l9hGct537OsFbdjQr(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool BXOy5ZGc2CpEF0CmEENt()
	{
		return DvpMQQGcOoe7TdyLleF0 == null;
	}

	internal static DefaultEntityActionEventAggregator RRam1nGce9SooAnMmI8Q()
	{
		return DvpMQQGcOoe7TdyLleF0;
	}
}

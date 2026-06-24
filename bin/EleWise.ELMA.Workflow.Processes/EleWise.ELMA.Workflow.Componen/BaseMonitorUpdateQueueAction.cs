using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

public abstract class BaseMonitorUpdateQueueAction : IMonitorUpdateQueueAction
{
	internal static BaseMonitorUpdateQueueAction So4ICEctiq08qxl1dqL;

	public abstract Guid ActionUid { get; }

	public virtual string ActionName => SR.T((string)iG4ClqcqHPXoXfvm6qG(-2038019883 ^ -2038025829));

	public abstract void DoAction(IProcessHeader header, IUser user);

	protected virtual List<CountProcessInfo> GetCountByUsers(IProcessHeader header, bool isEmulation)
	{
		return new List<CountProcessInfo>();
	}

	protected virtual List<IMonitorCacheItem> GetCacheItems(IProcessHeader header, List<IUser> user)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.res = new List<IMonitorCacheItem>();
		using (IEnumerator<IGrouping<IUser, IMonitorCacheItem>> enumerator = (from i in MonitorCacheItemManager.Instance.GetItems(header, null)
			group i by (IUser)_003C_003Ec.zyZUaD0Vg5bBwQJbwDv(i)).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_1();
				CS_0024_003C_003E8__locals1.group = enumerator.Current;
				if (CS_0024_003C_003E8__locals0.res.All((IMonitorCacheItem r) => r.Id != CS_0024_003C_003E8__locals1.group.Key.Id))
				{
					CS_0024_003C_003E8__locals0.res.Add(CS_0024_003C_003E8__locals1.group.First());
				}
			}
		}
		if (user != null)
		{
			foreach (IUser item in user.Where(delegate(IUser u)
			{
				int num = 2;
				int num2 = num;
				_003C_003Ec__DisplayClass6_2 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_2);
				while (true)
				{
					switch (num2)
					{
					case 2:
						_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_2();
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
						{
							num2 = 1;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals0.res.All(_003C_003Ec__DisplayClass6_._003CGetCacheItems_003Eb__3);
					case 1:
						_003C_003Ec__DisplayClass6_.u = u;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}).ToList())
			{
				InstanceOf<IMonitorCacheItem> instanceOf = new InstanceOf<IMonitorCacheItem>();
				instanceOf.New.ProcessHeader = header;
				instanceOf.New.User = item;
				IMonitorCacheItem @new = instanceOf.New;
				@new.Save();
				CS_0024_003C_003E8__locals0.res.Add(@new);
			}
		}
		return CS_0024_003C_003E8__locals0.res;
	}

	protected virtual IMonitorCacheItem GetCacheItem(IProcessHeader header, IUser user)
	{
		//Discarded unreachable code: IL_0160
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IMonitorCacheItem monitorCacheItem = default(IMonitorCacheItem);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 6;
				continue;
			case 6:
				_003C_003Ec__DisplayClass7_.header = header;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
				{
					num2 = 2;
				}
				continue;
			case 8:
				if (monitorCacheItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
			{
				object obj = JrhYrmcQDfAwvTwGSgf();
				ParameterExpression parameterExpression = (ParameterExpression)WpHU75cDc4rxxChAVYl(kQdASUcVP3vH6scYuYj(typeof(IMonitorCacheItem).TypeHandle), iG4ClqcqHPXoXfvm6qG(0x32F3F75 ^ 0x32F46D3));
				monitorCacheItem = ((AbstractNHEntityManager<IMonitorCacheItem, long>)obj).Find(Expression.Lambda<Func<IMonitorCacheItem, bool>>(Expression.AndAlso((Expression)AfpOuFcYHFfyvIZOLvn(Expression.Property(parameterExpression, (MethodInfo)lKkHM3cKQcJYZKCcA5i((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)K7T5rpcMNWSwlxBYXYp(_003C_003Ec__DisplayClass7_, kQdASUcVP3vH6scYuYj(typeof(_003C_003Ec__DisplayClass7_0).TypeHandle)), (FieldInfo)PZsHB9caOguvYqZirIC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)AfpOuFcYHFfyvIZOLvn(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PKhrNRcvSPcw9IFWkFN(K7T5rpcMNWSwlxBYXYp(_003C_003Ec__DisplayClass7_, kQdASUcVP3vH6scYuYj(typeof(_003C_003Ec__DisplayClass7_0).TypeHandle)), PZsHB9caOguvYqZirIC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				num2 = 8;
				continue;
			}
			case 2:
				_003C_003Ec__DisplayClass7_.user = user;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				AHxw22c9jvrLNcmKbLV(monitorCacheItem);
				num2 = 4;
				continue;
			default:
				return monitorCacheItem;
			case 5:
				break;
			}
			InstanceOf<IMonitorCacheItem> instanceOf = new InstanceOf<IMonitorCacheItem>();
			dYWe6tcPUjp281KNpNv(instanceOf.New, _003C_003Ec__DisplayClass7_.header);
			OxUgBNc4NZBSn0C6xfZ(instanceOf.New, _003C_003Ec__DisplayClass7_.user);
			monitorCacheItem = instanceOf.New;
			num2 = 3;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
			{
				num2 = 1;
			}
		}
	}

	protected virtual void SetNullToCache(IProcessHeader header, string column, string columnEml, List<IUser> ignoreUsers)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658662645), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949720076 ^ -949743168)), serviceNotNull.Dialect.QuoteIfNeeded(column), serviceNotNull.Dialect.QuoteIfNeeded(columnEml), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x587702A0 ^ 0x587760F2)), header.Id, serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1683072034 ^ -1683086970)), (ignoreUsers != null && ignoreUsers.Count > 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--47835757 ^ 0x2D99009), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE6AF0C2 ^ 0xE6A8A9A)), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x624F2FBE ^ 0x624F0FCA), ignoreUsers.Select((IUser u) => u.Id))) : "");
		serviceNotNull.ExecuteNonQuery(sql);
	}

	protected virtual List<Pair<IUser, Pair<long, long>>> CacheUpdateDate(IProcessHeader header)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		List<CountProcessInfo> countByUsers = GetCountByUsers(header, isEmulation: false);
		List<CountProcessInfo> countByUsers2 = GetCountByUsers(header, isEmulation: true);
		CS_0024_003C_003E8__locals0.users = (from n in countByUsers.Select(delegate(CountProcessInfo n)
			{
				if (n.Id > 0)
				{
					try
					{
						return new Pair<IUser, Pair<long, long>>(UserManager.Instance.Load(n.Id), new Pair<long, long>(n.CountRes, 0L));
					}
					catch (Exception)
					{
						return null;
					}
				}
				return null;
			})
			where n != null
			select n).ToList();
		countByUsers2.ForEach(delegate(CountProcessInfo ne)
		{
			//Discarded unreachable code: IL_009d, IL_00fa, IL_0111, IL_0120, IL_015f, IL_016e
			int num = 5;
			int num2 = num;
			_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_1);
			Pair<IUser, Pair<long, long>> pair = default(Pair<IUser, Pair<long, long>>);
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass9_.ne = ne;
					num2 = 7;
					break;
				case 8:
					try
					{
						Pair<IUser, Pair<long, long>> item = new Pair<IUser, Pair<long, long>>(((AbstractNHEntityManager<IUser, long>)_003C_003Ec__DisplayClass9_0.H7TLxJ09hDbJxK8uY1M()).Load(_003C_003Ec__DisplayClass9_.ne.Id), new Pair<long, long>(0L, _003C_003Ec__DisplayClass9_.ne.CountRes));
						int num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								CS_0024_003C_003E8__locals0.users.Add(item);
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
								{
									num3 = 1;
								}
								break;
							case 1:
								return;
							}
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
				case 3:
					return;
				case 6:
					if (_003C_003Ec__DisplayClass9_0.ORc3RL048BOa1sNbbcD(_003C_003Ec__DisplayClass9_.ne) <= 0)
					{
						return;
					}
					num2 = 8;
					break;
				case 5:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1();
					num2 = 4;
					break;
				default:
					pair.Second.Second = _003C_003Ec__DisplayClass9_0.DArRBF0Tk1yZ4JmEQGD(_003C_003Ec__DisplayClass9_.ne);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
					{
						num2 = 3;
					}
					break;
				case 7:
					pair = CS_0024_003C_003E8__locals0.users.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CCacheUpdateDate_003Eb__3);
					num2 = 2;
					break;
				case 2:
					if (pair != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.users;
	}

	protected BaseMonitorUpdateQueueAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Td8XdycTYcrJdaFLUEn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object iG4ClqcqHPXoXfvm6qG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gNGXCRcsqxJnj25TS8R()
	{
		return So4ICEctiq08qxl1dqL == null;
	}

	internal static BaseMonitorUpdateQueueAction Un0q4Bc2lPoKynFOqZ5()
	{
		return So4ICEctiq08qxl1dqL;
	}

	internal static object JrhYrmcQDfAwvTwGSgf()
	{
		return MonitorCacheItemManager.Instance;
	}

	internal static Type kQdASUcVP3vH6scYuYj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object WpHU75cDc4rxxChAVYl(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object lKkHM3cKQcJYZKCcA5i(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object K7T5rpcMNWSwlxBYXYp(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object PZsHB9caOguvYqZirIC(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object AfpOuFcYHFfyvIZOLvn(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object PKhrNRcvSPcw9IFWkFN(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static void dYWe6tcPUjp281KNpNv(object P_0, object P_1)
	{
		((IMonitorCacheItem)P_0).ProcessHeader = (IProcessHeader)P_1;
	}

	internal static void OxUgBNc4NZBSn0C6xfZ(object P_0, object P_1)
	{
		((IMonitorCacheItem)P_0).User = (IUser)P_1;
	}

	internal static void AHxw22c9jvrLNcmKbLV(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void Td8XdycTYcrJdaFLUEn()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}

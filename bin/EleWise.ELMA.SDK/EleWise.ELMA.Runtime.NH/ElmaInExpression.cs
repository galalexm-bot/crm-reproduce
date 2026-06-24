using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Dialect;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class ElmaInExpression : InExpression
{
	private class JoinedValuesType : AbstractType
	{
		private class Value
		{
			private static object wUJEDvZuKEi2O1v8C8Jm;

			public IType Type { get; }

			public object[] Values { get; }

			public string Delimiter { get; }

			public Value(IType type, object[] values, string delimiter)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				Ww76cAZuk6BjNvcR749s();
				base._002Ector();
				int num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num = 2;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 3:
						Type = type;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num = 0;
						}
						break;
					case 1:
						Delimiter = delimiter;
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num = 2;
						}
						break;
					default:
						Values = values;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num = 1;
						}
						break;
					}
				}
			}

			public override string ToString()
			{
				return string.Join(Delimiter, Values);
			}

			internal static void Ww76cAZuk6BjNvcR749s()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool T3tiDaZuXM1FwUIjGDv8()
			{
				return wUJEDvZuKEi2O1v8C8Jm == null;
			}

			internal static Value b1lfcoZuTr3HeoBL5x6R()
			{
				return (Value)wUJEDvZuKEi2O1v8C8Jm;
			}
		}

		private readonly object sqlTypes;

		private static object HTid18QJ8j6BbECas9tZ;

		private static IType Singleton { get; }

		public override string Name => (string)GPTd5sQJIfUwNyFt4vfZ(NHibernateUtil.StringClob);

		public override Type ReturnedClass => k36bYnQJVIIlWKNOFcxK(NHibernateUtil.StringClob);

		public override bool IsMutable => pQS39cQJSMvk5SgeufZP(NHibernateUtil.StringClob);

		public override string ToLoggableString(object value, ISessionFactoryImplementor factory)
		{
			throw new NotImplementedException();
		}

		public override bool IsDirty(object old, object current, bool[] checkable, ISessionImplementor session)
		{
			throw new NotImplementedException();
		}

		public override object DeepCopy(object val, ISessionFactoryImplementor factory)
		{
			throw new NotImplementedException();
		}

		public override object Replace(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready)
		{
			throw new NotImplementedException();
		}

		public override object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
		{
			throw new NotImplementedException();
		}

		public override object NullSafeGet(DbDataReader rs, string name, ISessionImplementor session, object owner)
		{
			throw new NotImplementedException();
		}

		public override Task<object> ReplaceAsync(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override Task<object> NullSafeGetAsync(DbDataReader rs, string[] names, ISessionImplementor session, object owner, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override Task<object> NullSafeGetAsync(DbDataReader rs, string name, ISessionImplementor session, object owner, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override Task<bool> IsDirtyAsync(object old, object current, bool[] checkable, ISessionImplementor session, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public static TypedValue GetTypedValue(object type, object values, object delimiter)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			return new TypedValue(Singleton, (object)new Value((IType)type, (object[])values, (string)delimiter));
		}

		public override bool[] ToColumnNullness(object value, IMapping mapping)
		{
			return ArrayHelper.True;
		}

		public override SqlType[] SqlTypes(IMapping mapping)
		{
			return (SqlType[])sqlTypes;
		}

		public override int GetColumnSpan(IMapping mapping)
		{
			return 1;
		}

		public override void NullSafeSet(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					((AbstractType)this).NullSafeSet(st, value, index, session);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					if (!settable[0])
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public override void NullSafeSet(DbCommand st, object value_obj, int index, ISessionImplementor session)
		{
			int num = 2;
			int num2 = num;
			Value value = default(Value);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					YVCbNtQJXbExuebjlB4w(((DbParameterCollection)wGfSxuQJiqYANsPQih51(st))[index], string.Join((string)oUncVKQJRwKMdoVhBpYh(value), session.NullSafeSet(Enumerable.Repeat<IType>((IType)WSVGw8QJqe8xZZBix0nu(value), ((Array)A193clQJKgb6qrTyd4Hl(value)).Length), value.Values)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if ((value = value_obj as Value) != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 0:
					return;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CNullSafeSetAsync_003Ed__26))]
		public override Task NullSafeSetAsync(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session, CancellationToken cancellationToken)
		{
			int num = 4;
			_003CNullSafeSetAsync_003Ed__26 stateMachine = default(_003CNullSafeSetAsync_003Ed__26);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 11:
						stateMachine.index = index;
						num2 = 10;
						continue;
					case 7:
						stateMachine._003C_003E1__state = -1;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						stateMachine._003C_003Et__builder = pipLifQJTycAt5sErxZs();
						num2 = 7;
						continue;
					case 6:
						stateMachine.session = session;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						stateMachine.settable = settable;
						num = 6;
						break;
					case 8:
						_003C_003Et__builder.Start(ref stateMachine);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					case 9:
						stateMachine.value = value;
						num = 11;
						break;
					case 1:
						stateMachine.cancellationToken = cancellationToken;
						num2 = 5;
						continue;
					case 3:
						stateMachine.st = st;
						num2 = 9;
						continue;
					default:
						return stateMachine._003C_003Et__builder.Task;
					case 2:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num2 = 8;
						continue;
					case 4:
						stateMachine._003C_003E4__this = this;
						num2 = 3;
						continue;
					}
					break;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CNullSafeSetAsync_003Ed__27))]
		public override Task NullSafeSetAsync(DbCommand st, object value_obj, int index, ISessionImplementor session, CancellationToken cancellationToken)
		{
			int num = 9;
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			_003CNullSafeSetAsync_003Ed__27 stateMachine = default(_003CNullSafeSetAsync_003Ed__27);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 4;
						}
						continue;
					case 2:
						stateMachine._003C_003E1__state = -1;
						num2 = 3;
						continue;
					case 8:
						break;
					case 7:
						stateMachine.index = index;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						stateMachine.cancellationToken = cancellationToken;
						num2 = 5;
						continue;
					case 1:
						stateMachine.session = session;
						num2 = 6;
						continue;
					case 9:
						stateMachine.st = st;
						num2 = 8;
						continue;
					default:
						return stateMachine._003C_003Et__builder.Task;
					case 4:
						_003C_003Et__builder.Start(ref stateMachine);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						stateMachine._003C_003Et__builder = pipLifQJTycAt5sErxZs();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				stateMachine.value_obj = value_obj;
				num = 7;
			}
		}

		public JoinedValuesType()
		{
			//Discarded unreachable code: IL_0048, IL_004d
			zENr4oQJkpeE56Djr4oO();
			sqlTypes = new SqlType[1] { (SqlType)s1lAwqQJngeOOZVuiUZ2(NHibernateUtil.StringClob) };
			((AbstractType)this)._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static JoinedValuesType()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					Singleton = (IType)(object)new JoinedValuesType();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					zENr4oQJkpeE56Djr4oO();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool GO7F00QJZv7R63npKwJr()
		{
			return HTid18QJ8j6BbECas9tZ == null;
		}

		internal static JoinedValuesType y84mvtQJuqIcT90930q2()
		{
			return (JoinedValuesType)HTid18QJ8j6BbECas9tZ;
		}

		internal static object GPTd5sQJIfUwNyFt4vfZ(object P_0)
		{
			return ((AbstractType)P_0).get_Name();
		}

		internal static Type k36bYnQJVIIlWKNOFcxK(object P_0)
		{
			return ((AbstractType)P_0).get_ReturnedClass();
		}

		internal static bool pQS39cQJSMvk5SgeufZP(object P_0)
		{
			return ((AbstractType)P_0).get_IsMutable();
		}

		internal static object wGfSxuQJiqYANsPQih51(object P_0)
		{
			return ((DbCommand)P_0).Parameters;
		}

		internal static object oUncVKQJRwKMdoVhBpYh(object P_0)
		{
			return ((Value)P_0).Delimiter;
		}

		internal static object WSVGw8QJqe8xZZBix0nu(object P_0)
		{
			return ((Value)P_0).Type;
		}

		internal static object A193clQJKgb6qrTyd4Hl(object P_0)
		{
			return ((Value)P_0).Values;
		}

		internal static void YVCbNtQJXbExuebjlB4w(object P_0, object P_1)
		{
			((IDataParameter)P_0).Value = P_1;
		}

		internal static AsyncTaskMethodBuilder pipLifQJTycAt5sErxZs()
		{
			return AsyncTaskMethodBuilder.Create();
		}

		internal static void zENr4oQJkpeE56Djr4oO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object s1lAwqQJngeOOZVuiUZ2(object P_0)
		{
			return ((NullableType)P_0).get_SqlType();
		}
	}

	private readonly IProjection _projection;

	private readonly string _propertyName;

	private readonly string _delimiter;

	public const string ElmaInExpressionTableFunctionName = "SplitString";

	internal const int MaxInCount = 1000;

	private static readonly ConcurrentDictionary<Guid, Pair<string, string>> splitStringFunctions;

	private IType[] types;

	private static ElmaInExpression zITU1mWpwsfdktquuwVA;

	internal static void Init()
	{
		iPCNIGWpHnrUQJyoxoHO();
	}

	[Obsolete]
	private static void InitObsolete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			Func<string, object[], AbstractCriterion> func;
			switch (num2)
			{
			case 2:
				return;
			case 1:
				func = _003C_003Ec._003C_003E9__5_0;
				if (func == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				func = (_003C_003Ec._003C_003E9__5_0 = (string p, object[] v) => (AbstractCriterion)(object)new ElmaInExpression(p, v, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824389145)));
				break;
			}
			Restrictions.InitInExpression(func, (Func<IProjection, object[], AbstractCriterion>)((IProjection p, object[] v) => (AbstractCriterion)(object)new ElmaInExpression(p, v, (string)_003C_003Ec.Vj8WTEQJ1VxEfDCdoofu(-2099751081 ^ -2099750099))));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num2 = 2;
			}
		}
	}

	[Obsolete("Use Restrictions.In instead", true)]
	public ElmaInExpression(IProjection projection, IEnumerable values, string delimiter = "_")
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SingletonReader.JJCZtPuTvSt();
		((InExpression)this)._002Ector(projection, values.CastToArrayOrNull<object>());
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 1;
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
				_projection = projection;
				num = 2;
				break;
			case 2:
				_delimiter = delimiter;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[Obsolete("Use Restrictions.In instead", true)]
	public ElmaInExpression(string propertyName, IEnumerable values, string delimiter = "_")
	{
		//Discarded unreachable code: IL_0031, IL_0036
		Tf0KCRWpAbD81c0rLTcK();
		((InExpression)this)._002Ector(propertyName, values.CastToArrayOrNull<object>());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_delimiter = delimiter;
				num = 2;
				continue;
			case 2:
				return;
			}
			_propertyName = propertyName;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 1;
			}
		}
	}

	private IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		int num = 1;
		int num2 = num;
		IType[] array2;
		IType[] array = default(IType[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array2 = types;
				if (array2 != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				array = (types = (IType[])((_projection == null) ? new IType[1] { (IType)Gnky5RWpxBOENG3Wgkrk(criteriaQuery, criteria, _propertyName) } : hFxV9qWp7ZCYcHNfaWq3(_projection, criteria, criteriaQuery)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				array2 = array;
				break;
			}
			break;
		}
		return array2;
	}

	private bool CallBase(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_00a9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (m5BeC8Wp0p2Ttku5lp2y(this) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return YiTYVyWpJPo7iBjF3EBi(i7yvgSWpyGlNAZ0t51wp(types[0]), X1VYkMWpMD3rI1qMd8A6(NHibernateUtil.String));
			default:
				return true;
			case 1:
				if (((InExpression)this).get_Values().Length <= 1000)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				if (GetTypes(criteria, criteriaQuery).Length == 1)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 4:
				if (!G1qPo3WpmcRHtT8tu86t(types[0]))
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0222: Expected O, but got Unknown
		int num = 2;
		string text = default(string);
		Pair<string, string> orAdd = default(Pair<string, string>);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		SqlString[] columnNames = default(SqlString[]);
		Parameter[] array = default(Parameter[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					text = (string)kKW0JwWpgjrG96rr5Jmc(ag7iUrWplin5UiN2PXS3(criteriaQuery.get_Factory()), ((object[])P0RbjtWprk2TAoIhlOwO(GetTypes(criteria, criteriaQuery)[0], criteriaQuery.get_Factory()))[0]);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					return (SqlString)nA90IqWp96AS3AWKr2It(this, criteria, criteriaQuery);
				case 3:
					orAdd = splitStringFunctions.GetOrAdd(h2gjXuWpdQVXueuEEAXW(_003C_003Ec__DisplayClass13_.transform), _003C_003Ec__DisplayClass13_._003CToSqlString_003Eb__0);
					num2 = 6;
					break;
				case 5:
				{
					SqlStringBuilder val = new SqlStringBuilder();
					ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(XSZdobWpLeZuBOwD9xEl(ey37fIWpYdeJbREHYYen(((SqlStringBuilder)ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(((SqlStringBuilder)ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(ey37fIWpYdeJbREHYYen(((SqlStringBuilder)CF5isnWp5quOvtI7rBJx((object)val, columnNames[0])).Add((string)Ni4BxCWpjculWhcW4C2K(-29254301 ^ -29129307)).Add((string)Ni4BxCWpjculWhcW4C2K(-1979251663 ^ -1979237327)).Add((string)Ni4BxCWpjculWhcW4C2K(-1765851862 ^ -1765988866)), Ni4BxCWpjculWhcW4C2K(0x34185E55 ^ 0x341A46B7)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583608296)), text), Ni4BxCWpjculWhcW4C2K(0x2A7797B7 ^ 0x2A77880B)), Ni4BxCWpjculWhcW4C2K(0x53FA00CE ^ 0x53F81822))).Add((string)Ni4BxCWpjculWhcW4C2K(-643786247 ^ -643819353)), Ni4BxCWpjculWhcW4C2K(0x7247028A ^ 0x72473A98)), orAdd.First)).Add(array[0]), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFC75B)), array[1]), orAdd.Second), Ni4BxCWpjculWhcW4C2K(0x4A1640F ^ 0x4A17BB3));
					return (SqlString)IRsjJFWpU5NZtFcqtlTq((object)val);
				}
				case 1:
					if (!CallBase(criteria, criteriaQuery))
					{
						goto end_IL_0012;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					columnNames = CriterionUtil.GetColumnNames(_propertyName, _projection, criteriaQuery, criteria);
					num2 = 7;
					break;
				case 7:
					array = GetParameterTypedValues(criteria, criteriaQuery, (_projection != null) ? _projection.GetTypedValues(criteria, criteriaQuery).Length : 0).SelectMany((Func<TypedValue, IEnumerable<Parameter>>)criteriaQuery.NewQueryParameter).ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass13_.transform = Locator.GetServiceNotNull<ITransformationProvider>();
			num = 3;
		}
	}

	public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_0081
		int num = 4;
		TypedValue[] array = default(TypedValue[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					if (CallBase(criteria, criteriaQuery))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 3;
						}
						continue;
					}
					if (_projection != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					obj = new TypedValue[0];
					break;
				case 3:
					return (TypedValue[])hG4Nd1Wps2rKupaZLnbS(this, criteria, criteriaQuery);
				default:
					return array.Concat(GetParameterTypedValues(criteria, criteriaQuery, array.Length)).ToArray();
				case 2:
					obj = rWhlZeWpcuFWd7ph2ccL(_projection, criteria, criteriaQuery);
					break;
				}
				array = (TypedValue[])obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	private IEnumerable<TypedValue> GetParameterTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery, int projectionParametersCount)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		return (IEnumerable<TypedValue>)(object)new TypedValue[2]
		{
			JoinedValuesType.GetTypedValue(GetTypes(criteria, criteriaQuery)[0], ((InExpression)this).get_Values(), _delimiter),
			new TypedValue((IType)(object)NHibernateUtil.String, (object)_delimiter)
		};
	}

	public static string ToString(string columnName, IEnumerable values, DbType typecode = DbType.Int64, int? length = null, int? scale = null, string delimiter = "_")
	{
		object[] array = values.CastToArrayOrNull<object>();
		if (array == null || array.Length == 0)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97843026);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(columnName).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979376393));
		if (array.Length <= 1000)
		{
			stringBuilder.Append(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195615465), array));
		}
		else
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289704342)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561203792)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1635DCCB))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE36399))
				.Append(serviceNotNull.Dialect.GetTypeName(typecode, length, scale))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787A4E1))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765819276))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70027726))
				.Append(serviceNotNull.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F77FB4), serviceNotNull.Dialect.QuoteString(string.Join(delimiter, array)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957821374) + serviceNotNull.Dialect.QuoteString(delimiter)));
		}
		stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939378896));
		return stringBuilder.ToString();
	}

	public static string ToString(string columnName, IEnumerable values, List<object> sqlValues, List<IType> sqlTypes, DbType typecode = DbType.Int64, int? length = null, int? scale = null, string delimiter = "_")
	{
		object[] sqlValues2;
		IType[] sqlTypes2;
		string result = ToString(columnName, values, out sqlValues2, out sqlTypes2, typecode, length, scale, delimiter);
		sqlValues.AddRange(sqlValues2);
		sqlTypes.AddRange(sqlTypes2);
		return result;
	}

	public static string ToString(string columnName, IEnumerable values, out object[] sqlValues, out IType[] sqlTypes, DbType typecode = DbType.Int64, int? length = null, int? scale = null, string delimiter = "_")
	{
		object[] array = values.CastToArrayOrNull<object>();
		if (array == null || array.Length == 0)
		{
			sqlValues = new object[0];
			sqlTypes = (IType[])(object)new IType[0];
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217656383);
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(columnName).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979376393));
		if (array.Length <= 1000)
		{
			stringBuilder.Append(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC193D), array.Select((object v) => (string)_003C_003Ec.Vj8WTEQJ1VxEfDCdoofu(0x61EC0CB8 ^ 0x61EC14F2))));
			sqlValues = array;
			sqlTypes = ((IEnumerable<object>)array).Select((Func<object, IType>)NHibernateUtil.GuessType).ToArray();
		}
		else
		{
			stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8314C32)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E6060F)).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A31E6D4))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AFD434))
				.Append(serviceNotNull.Dialect.GetTypeName(typecode, length, scale))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234307412))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488744153))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC9461))
				.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099744955))
				.Append(serviceNotNull.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1030CD), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE15A4)));
			sqlValues = new object[2]
			{
				string.Join(delimiter, array),
				delimiter
			};
			sqlTypes = (IType[])(object)new IType[2]
			{
				(IType)NHibernateUtil.StringClob,
				(IType)NHibernateUtil.String
			};
		}
		stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFD4E5));
		return stringBuilder.ToString();
	}

	static ElmaInExpression()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				splitStringFunctions = new ConcurrentDictionary<Guid, Pair<string, string>>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Tf0KCRWpAbD81c0rLTcK();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void iPCNIGWpHnrUQJyoxoHO()
	{
		InitObsolete();
	}

	internal static bool EEGx6cWp4CgnLZ7lm1cA()
	{
		return zITU1mWpwsfdktquuwVA == null;
	}

	internal static ElmaInExpression AxENA4Wp6vYOPLprujA8()
	{
		return zITU1mWpwsfdktquuwVA;
	}

	internal static void Tf0KCRWpAbD81c0rLTcK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object hFxV9qWp7ZCYcHNfaWq3(object P_0, object P_1, object P_2)
	{
		return ((IProjection)P_0).GetTypes((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object Gnky5RWpxBOENG3Wgkrk(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetTypeUsingProjection((ICriteria)P_1, (string)P_2);
	}

	internal static object m5BeC8Wp0p2Ttku5lp2y(object P_0)
	{
		return ((InExpression)P_0).get_Values();
	}

	internal static bool G1qPo3WpmcRHtT8tu86t(object P_0)
	{
		return ((IType)P_0).get_IsComponentType();
	}

	internal static Type i7yvgSWpyGlNAZ0t51wp(object P_0)
	{
		return ((IType)P_0).get_ReturnedClass();
	}

	internal static Type X1VYkMWpMD3rI1qMd8A6(object P_0)
	{
		return ((AbstractType)P_0).get_ReturnedClass();
	}

	internal static bool YiTYVyWpJPo7iBjF3EBi(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object nA90IqWp96AS3AWKr2It(object P_0, object P_1, object P_2)
	{
		return ((InExpression)P_0).ToSqlString((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static Guid h2gjXuWpdQVXueuEEAXW(object P_0)
	{
		return ((ITransformationProvider)P_0).Uid;
	}

	internal static object ag7iUrWplin5UiN2PXS3(object P_0)
	{
		return ((IMapping)P_0).get_Dialect();
	}

	internal static object P0RbjtWprk2TAoIhlOwO(object P_0, object P_1)
	{
		return ((IType)P_0).SqlTypes((IMapping)P_1);
	}

	internal static object kKW0JwWpgjrG96rr5Jmc(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetCastTypeName((SqlType)P_1);
	}

	internal static object CF5isnWp5quOvtI7rBJx(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object Ni4BxCWpjculWhcW4C2K(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ey37fIWpYdeJbREHYYen(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object XSZdobWpLeZuBOwD9xEl(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((Parameter)P_1);
	}

	internal static object IRsjJFWpU5NZtFcqtlTq(object P_0)
	{
		return ((SqlStringBuilder)P_0).ToSqlString();
	}

	internal static object hG4Nd1Wps2rKupaZLnbS(object P_0, object P_1, object P_2)
	{
		return ((InExpression)P_0).GetTypedValues((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object rWhlZeWpcuFWd7ph2ccL(object P_0, object P_1, object P_2)
	{
		return ((IProjection)P_0).GetTypedValues((ICriteria)P_1, (ICriteriaQuery)P_2);
	}
}

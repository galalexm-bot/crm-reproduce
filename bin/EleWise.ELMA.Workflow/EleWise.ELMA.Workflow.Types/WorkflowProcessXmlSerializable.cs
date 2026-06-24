using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
[Component]
public abstract class WorkflowProcessXmlSerializableType : AbstractType, IWorkflowProcessXmlSerializableType
{
	private static SqlType[] sqlTypes;

	internal static WorkflowProcessXmlSerializableType lkumgA81dXccm3opfUU;

	public override bool IsMutable => false;

	internal abstract string PropertyName { get; }

	internal abstract ConcurrentDictionary<long, object> DataCache { get; }

	public override SqlType[] SqlTypes(IMapping mapping)
	{
		return sqlTypes;
	}

	public override int GetColumnSpan(IMapping mapping)
	{
		return sqlTypes.Length;
	}

	public override bool[] ToColumnNullness(object value, IMapping mapping)
	{
		return new bool[1] { value != null };
	}

	public override string ToLoggableString(object value, ISessionFactoryImplementor factory)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return value.ToString();
			default:
				return (string)FJdxZF8wq6BoT99S8q2(0x4940763B ^ 0x49406E03);
			}
		}
	}

	public override object DeepCopy(object val, ISessionFactoryImplementor factory)
	{
		return val;
	}

	public override bool IsDirty(object old, object current, bool[] checkable, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_003a, IL_0049
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return jSgg6j848uxOk47cH7A(this, old, current, session);
			case 1:
				return false;
			case 2:
				if (!checkable[0])
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override object Replace(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready)
	{
		return original;
	}

	public override object Disassemble(object value, ISessionImplementor session, object owner)
	{
		return Disassemble(value, owner);
	}

	public override object Assemble(object cached, ISessionImplementor session, object owner)
	{
		return Assemble(cached, owner);
	}

	public override object NullSafeGet(DbDataReader rs, string name, ISessionImplementor session, object owner)
	{
		return H6xUXF8zC5BcgyWuvAC(this, rs, new string[1] { name }, session, owner);
	}

	public override object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		return NullSafeGet(rs, names, owner, session);
	}

	public override void NullSafeSet(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Xey28dsK7mSIsQsPZZJ(this, st, value, index, session);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (!settable[0])
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				return;
			case 3:
				return;
			}
		}
	}

	public override void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0069
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					uLPKrosZ92Gb16Chhns(U1NnyIsOwgWXRMrgC4l(cmd.Parameters, index), DBNull.Value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (!IsEmpty(value))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 0:
					return;
				case 5:
					uLPKrosZ92Gb16Chhns(U1NnyIsOwgWXRMrgC4l(PX5XROsvWSXW790K9cA(cmd), index), NXvll4sYMgACi5TOW7E(this, value));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (value != null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 1:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private object Disassemble(object value, object owner)
	{
		int num = 3;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (workflowProcess.VersionNumber == 0L)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 1;
					}
					break;
				}
				DataCache.TryAdd(workflowProcess.Id, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return value;
			case 3:
				workflowProcess = owner as IWorkflowProcess;
				num2 = 2;
				break;
			default:
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105861114);
			case 2:
				if (workflowProcess != null)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			}
		}
	}

	private object Assemble(object cached, object owner)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7, IL_014d, IL_015c, IL_016c, IL_017b
		int num = 7;
		int num2 = num;
		object value = default(object);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return value;
			case 1:
				if (!(cached is string))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 8:
				return cached;
			case 2:
				if (!DataCache.TryGetValue(workflowProcess.Id, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 7:
				workflowProcess = owner as IWorkflowProcess;
				num2 = 6;
				break;
			case 3:
			case 5:
				return cached;
			case 9:
				return DataCache[workflowProcess.Id];
			default:
				if (!jyKSQZs8fhtChwIOeop((string)cached, FJdxZF8wq6BoT99S8q2(-43932417 ^ -43926341)))
				{
					L3QSgdsJX4dq1kdGLpF(p5I6kDsskqPd63Ec8S4(), workflowProcess);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 9;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 6:
				if (workflowProcess != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	private object NullSafeGet(DbDataReader rs, string[] names, object owner, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_005f
		int num = 4;
		object obj = default(object);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (obj != null)
					{
						return UhUiOqs0sTtDFgqIrfx(this, (byte[])obj);
					}
					goto end_IL_0012;
				case 4:
					workflowProcess = owner as IWorkflowProcess;
					num2 = 3;
					break;
				case 3:
					if (workflowProcess == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				case 5:
					return value;
				case 1:
				case 2:
					obj = ((NullableType)NHibernateUtil.BinaryBlob).NullSafeGet(rs, names[0], session);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (!DataCache.TryGetValue(workflowProcess.Id, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 5;
				case 7:
					return bSitaQslVVCOqv2SgNI(this);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	protected virtual object GetNullObject()
	{
		return null;
	}

	internal abstract object LoadFromBlob(byte[] blob);

	internal abstract byte[] SaveToBlob(object value);

	protected abstract bool IsEmpty(object obj);

	[AsyncStateMachine(typeof(_003CIsDirtyAsync_003Ed__28))]
	public override Task<bool> IsDirtyAsync(object old, object current, bool[] checkable, ISessionImplementor session, CancellationToken cancellationToken)
	{
		_003CIsDirtyAsync_003Ed__28 stateMachine = default(_003CIsDirtyAsync_003Ed__28);
		stateMachine._003C_003E4__this = this;
		stateMachine.old = old;
		stateMachine.current = current;
		stateMachine.checkable = checkable;
		stateMachine.session = session;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CNullSafeGetAsync_003Ed__29))]
	public override Task<object> NullSafeGetAsync(DbDataReader rs, string[] names, ISessionImplementor session, object owner, CancellationToken cancellationToken)
	{
		_003CNullSafeGetAsync_003Ed__29 stateMachine = default(_003CNullSafeGetAsync_003Ed__29);
		stateMachine._003C_003E4__this = this;
		stateMachine.rs = rs;
		stateMachine.names = names;
		stateMachine.session = session;
		stateMachine.owner = owner;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public override Task<object> NullSafeGetAsync(DbDataReader rs, string name, ISessionImplementor session, object owner, CancellationToken cancellationToken)
	{
		return ((AbstractType)this).NullSafeGetAsync(rs, new string[1] { name }, session, owner, cancellationToken);
	}

	[AsyncStateMachine(typeof(_003CNullSafeSetAsync_003Ed__31))]
	public override Task NullSafeSetAsync(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session, CancellationToken cancellationToken)
	{
		int num = 7;
		_003CNullSafeSetAsync_003Ed__31 stateMachine = default(_003CNullSafeSetAsync_003Ed__31);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					stateMachine.session = session;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return stateMachine._003C_003Et__builder.Task;
				case 3:
					stateMachine._003C_003Et__builder = ucv8BrsyeY9KuYLR7sg();
					num2 = 4;
					continue;
				case 10:
					stateMachine.index = index;
					num2 = 5;
					continue;
				case 1:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 8;
					continue;
				case 4:
					stateMachine._003C_003E1__state = -1;
					num = 9;
					break;
				case 2:
					stateMachine.value = value;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					stateMachine.cancellationToken = cancellationToken;
					num = 3;
					break;
				case 5:
					stateMachine.settable = settable;
					num2 = 11;
					continue;
				case 7:
					stateMachine._003C_003E4__this = this;
					num2 = 6;
					continue;
				case 6:
					stateMachine.st = st;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public override Task NullSafeSetAsync(DbCommand st, object value, int index, ISessionImplementor session, CancellationToken cancellationToken)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00de, IL_00ed
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!DI8jiTsmQZu9pd1mpUO(this, value))
				{
					num2 = 7;
					break;
				}
				goto default;
			case 3:
			case 6:
				return (Task)qGZ8RssbPtrDl1qtY9u();
			default:
				gdmhPdstxxk0139OksY(((DbParameterCollection)PX5XROsvWSXW790K9cA(st))[index], DBNull.Value);
				num2 = 3;
				break;
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 5:
			case 7:
				((DbParameter)U1NnyIsOwgWXRMrgC4l(PX5XROsvWSXW790K9cA(st), index)).Value = NXvll4sYMgACi5TOW7E(this, value);
				num2 = 6;
				break;
			}
		}
	}

	public override Task<object> ReplaceAsync(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready, CancellationToken cancellationToken)
	{
		return Task.FromResult(original);
	}

	protected WorkflowProcessXmlSerializableType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((AbstractType)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowProcessXmlSerializableType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				yaBHmjs5YD5ZRfteSTO();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sqlTypes = (SqlType[])(object)new SqlType[1] { ((NullableType)NHibernateUtil.BinaryBlob).get_SqlType() };
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool gUpsp58hNyTyKGDqCOi()
	{
		return lkumgA81dXccm3opfUU == null;
	}

	internal static WorkflowProcessXmlSerializableType iwjNug8EgW7exmXaNab()
	{
		return lkumgA81dXccm3opfUU;
	}

	internal static object FJdxZF8wq6BoT99S8q2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jSgg6j848uxOk47cH7A(object P_0, object P_1, object P_2, object P_3)
	{
		return ((AbstractType)P_0).IsDirty(P_1, P_2, (ISessionImplementor)P_3);
	}

	internal static object H6xUXF8zC5BcgyWuvAC(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((AbstractType)P_0).NullSafeGet((DbDataReader)P_1, (string[])P_2, (ISessionImplementor)P_3, P_4);
	}

	internal static void Xey28dsK7mSIsQsPZZJ(object P_0, object P_1, object P_2, int P_3, object P_4)
	{
		((AbstractType)P_0).NullSafeSet((DbCommand)P_1, P_2, P_3, (ISessionImplementor)P_4);
	}

	internal static object U1NnyIsOwgWXRMrgC4l(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void uLPKrosZ92Gb16Chhns(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object PX5XROsvWSXW790K9cA(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object NXvll4sYMgACi5TOW7E(object P_0, object P_1)
	{
		return ((WorkflowProcessXmlSerializableType)P_0).SaveToBlob(P_1);
	}

	internal static bool jyKSQZs8fhtChwIOeop(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object p5I6kDsskqPd63Ec8S4()
	{
		return WorkflowProcessManager.Instance;
	}

	internal static void L3QSgdsJX4dq1kdGLpF(object P_0, object P_1)
	{
		((WorkflowProcessManager)P_0).LoadWorkflowProcessXmlSerializableTypes((IWorkflowProcess)P_1);
	}

	internal static object bSitaQslVVCOqv2SgNI(object P_0)
	{
		return ((WorkflowProcessXmlSerializableType)P_0).GetNullObject();
	}

	internal static object UhUiOqs0sTtDFgqIrfx(object P_0, object P_1)
	{
		return ((WorkflowProcessXmlSerializableType)P_0).LoadFromBlob((byte[])P_1);
	}

	internal static AsyncTaskMethodBuilder ucv8BrsyeY9KuYLR7sg()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static bool DI8jiTsmQZu9pd1mpUO(object P_0, object P_1)
	{
		return ((WorkflowProcessXmlSerializableType)P_0).IsEmpty(P_1);
	}

	internal static void gdmhPdstxxk0139OksY(object P_0, object P_1)
	{
		((DbParameter)P_0).Value = P_1;
	}

	internal static object qGZ8RssbPtrDl1qtY9u()
	{
		return Task.CompletedTask;
	}

	internal static void yaBHmjs5YD5ZRfteSTO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
[Serializable]
public abstract class WorkflowProcessXmlSerializableType<T> : WorkflowProcessXmlSerializableType where T : class
{
	private static string _propertyName;

	private static ConcurrentDictionary<long, object> dataCache;

	private static object c5Z1XmsgghPejLa2Kv6;

	public override string Name => typeof(T).Name;

	public override Type ReturnedClass => typeof(T);

	public abstract Expression<Func<IWorkflowProcess, T>> PropertyGetter { get; }

	internal override string PropertyName
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = _propertyName;
					if (text != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = (_propertyName = LinqUtils.NameOf(PropertyGetter));
					break;
				}
				break;
			}
			return text;
		}
	}

	internal override ConcurrentDictionary<long, object> DataCache => dataCache;

	public override bool IsEqual(object x, object y)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_0113, IL_0122
		int num = 2;
		T val2 = default(T);
		T val = default(T);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (val2 == null)
					{
						num = 4;
						break;
					}
					goto case 8;
				case 6:
					if (val2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 10:
					return val2.Equals(val);
				case 4:
				case 9:
					return false;
				case 3:
					return true;
				case 2:
					val2 = x as T;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (val == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (val2 == val)
					{
						return true;
					}
					num = 10;
					break;
				case 1:
					val = y as T;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 6;
					}
					continue;
				default:
					if (val == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		return typeof(T).GetHashCode();
	}

	public override int GetHashCode(object x)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return x.GetHashCode();
			case 1:
				if (x == null)
				{
					return typeof(T).GetHashCode() + 473;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected T LoadObjectFromBlob(byte[] blob)
	{
		using MemoryStream stream = MemoryHelper.GetMemoryStream(blob, writable: false);
		return LoadObjectFromStream(stream);
	}

	protected byte[] SaveObjectToBlob(T value)
	{
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		SaveObjectToStream(memoryStream.AsNoClose(), value);
		return memoryStream.ToArray();
	}

	protected virtual bool IsEmpty(T obj)
	{
		return obj == null;
	}

	protected virtual T LoadObjectFromStream(Stream stream)
	{
		using XmlTextReader reader = new XmlTextReader(stream);
		return (T)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<T>.Raw, reader);
	}

	protected virtual void SaveObjectToStream(Stream stream, T obj)
	{
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(obj, writer);
	}

	internal override object LoadFromBlob(byte[] blob)
	{
		return LoadObjectFromBlob(blob);
	}

	internal override byte[] SaveToBlob(object value)
	{
		return SaveObjectToBlob((T)value);
	}

	protected override bool IsEmpty(object obj)
	{
		return IsEmpty((T)obj);
	}

	protected WorkflowProcessXmlSerializableType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowProcessXmlSerializableType()
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
				dataCache = new ConcurrentDictionary<long, object>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool FDOj2psB4H47gnIkcTX()
	{
		return c5Z1XmsgghPejLa2Kv6 == null;
	}

	internal static object TreptvscpgmqJRm3RBj()
	{
		return c5Z1XmsgghPejLa2Kv6;
	}
}
public abstract class WorkflowProcessXmlSerializableTypeDescriptor<T, NHTypeT, SettingsT> : CLRTypeDescriptor<T, SettingsT> where T : class where NHTypeT : WorkflowProcessXmlSerializableType<T> where SettingsT : SimpleTypeSettings
{
	private static object kWlFqRsPpuUX0SKMoUy;

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata entityPropertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.ExtendSimplePropertyMapping(mapper, entityPropertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				mapper.Type<NHTypeT>();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected WorkflowProcessXmlSerializableTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YB9o64sXovmom7THv6l()
	{
		return kWlFqRsPpuUX0SKMoUy == null;
	}

	internal static object o7plKesdD38K9hPuZqO()
	{
		return kWlFqRsPpuUX0SKMoUy;
	}
}

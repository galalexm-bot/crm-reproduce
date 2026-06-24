using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Db;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowMessageItemManager : EntityManager<IWorkflowMessageItem, long>
{
	private static readonly PropertyProjection messageTypeProjection;

	private static readonly PropertyProjection destInstanceProjection;

	private static readonly PropertyProjection createdTimestampProjection;

	private static WorkflowMessageItemManager OliLZqVi5mmVMbRPbDR;

	public WorkflowInstanceManager WorkflowInstanceManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CWorkflowInstanceManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
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

	public WorkflowProcessesDbStructure WorkflowProcessesDbStructure
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessesDbStructure_003Ek__BackingField;
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
					_003CWorkflowProcessesDbStructure_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
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

	public ITimestampService TimestampService
	{
		[CompilerGenerated]
		get
		{
			return _003CTimestampService_003Ek__BackingField;
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
					_003CTimestampService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
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

	public int GetTotalMessagesInQueue()
	{
		ICriteria obj = ((ISession)pkiD31VfoKaDWMOX5It(this)).CreateCriteria(InterfaceActivator.TypeOf<IWorkflowMessageItem>());
		IProjection[] array = new IProjection[1];
		ParameterExpression parameterExpression = Expression.Parameter(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageItem).TypeHandle), (string)fcvYKjVJ8K1a9yyp7wd(-693602260 ^ -693614538));
		array[0] = (IProjection)oninphV5kVCKXhOHRLw(Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)AZFy5ZV7am2i844Vj0a(Expression.Property(parameterExpression, (MethodInfo)kn1vHbVrIshnxjxjhEW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
		return ((ICriteria)ljNp6xVgNiJEAZj6kH4(obj, array)).UniqueResult<int>();
	}

	public int GetTotalReliableReceivers()
	{
		object obj = zZd9JJV1Y1L3yswNQJS(pkiD31VfoKaDWMOX5It(this), InterfaceActivator.TypeOf<IWorkflowMessageBookmark>());
		ParameterExpression parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(typeof(IWorkflowMessageBookmark), fcvYKjVJ8K1a9yyp7wd(0x664EA08F ^ 0x664EF321));
		ICriteria obj2 = ((ICriteria)obj).CreateAlias(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), (string)fcvYKjVJ8K1a9yyp7wd(0x6C324F5C ^ 0x6C321CE8));
		parameterExpression = Expression.Parameter(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageBookmark).TypeHandle), (string)fcvYKjVJ8K1a9yyp7wd(0x234241C0 ^ 0x2342126E));
		object obj3 = MBncc9DC7LWEK7GQga7(obj2, qpdeoXDETePmvZePCIe(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>(Expression.Convert((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })), WorkflowMessageBookmarkStatus.Awaiting));
		object obj4 = fcvYKjVJ8K1a9yyp7wd(0xE6AF0C2 ^ 0xE6AA300);
		parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageType).TypeHandle), fcvYKjVJ8K1a9yyp7wd(-1917423727 ^ -1917436865));
		object obj5 = MBncc9DC7LWEK7GQga7(obj3, Restrictions.Eq((string)bVydNCDXwriuM6BLqtj(obj4, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageType, object>>((Expression)AZFy5ZV7am2i844Vj0a(hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))), (object)true));
		IProjection[] array = new IProjection[1];
		parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageBookmark).TypeHandle), fcvYKjVJ8K1a9yyp7wd(--1877861722 ^ 0x6FEDD540));
		array[0] = (IProjection)oninphV5kVCKXhOHRLw(Projections.Property<IWorkflowMessageBookmark>(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>(Expression.Convert((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)kn1vHbVrIshnxjxjhEW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
		return ((ICriteria)ljNp6xVgNiJEAZj6kH4(obj5, array)).UniqueResult<int>();
	}

	public IList<IWorkflowMessageItem> GetStaleMessages()
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.wfI = null;
		CS_0024_003C_003E8__locals0.wfMI = null;
		return ((IQueryOver<IWorkflowMessageItem>)(object)base.Session.QueryOver<IWorkflowMessageItem>((Expression<Func<IWorkflowMessageItem>>)(() => CS_0024_003C_003E8__locals0.wfMI)).JoinAlias(Expression.Lambda<Func<object>>(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass18_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Array.Empty<ParameterExpression>()), Expression.Lambda<Func<object>>(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass18_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), Array.Empty<ParameterExpression>()), (JoinType)0).Where(Expression.Lambda<Func<bool>>(Expression.OrElse(Expression.Equal(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass18_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Convert(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass18_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(int)), Expression.Constant(1, typeof(int)))), Array.Empty<ParameterExpression>()))).List<IWorkflowMessageItem>();
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<IWorkflowMessageTypeParameter>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule, type);
			wFKPqED3obv9IdMwQV7(exportRule, fcvYKjVJ8K1a9yyp7wd(0x27475F40 ^ 0x27470C92));
			fAS1eRDhFW6C3jXeq0U(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule2, type);
			wFKPqED3obv9IdMwQV7(exportRule2, fcvYKjVJ8K1a9yyp7wd(-901337984 ^ -901316772));
			fAS1eRDhFW6C3jXeq0U(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule3, type);
			wFKPqED3obv9IdMwQV7(exportRule3, fcvYKjVJ8K1a9yyp7wd(-882678999 ^ -882691873));
			fAS1eRDhFW6C3jXeq0U(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule4, type);
			wFKPqED3obv9IdMwQV7(exportRule4, fcvYKjVJ8K1a9yyp7wd(-92270799 ^ -92251359));
			fAS1eRDhFW6C3jXeq0U(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule5, type);
			wFKPqED3obv9IdMwQV7(exportRule5, fcvYKjVJ8K1a9yyp7wd(0x927D360 ^ 0x927872A));
			fAS1eRDhFW6C3jXeq0U(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			Lv4bEGDoodICyI9owX2(exportRule6, type);
			exportRule6.PropertyName = (string)fcvYKjVJ8K1a9yyp7wd(-1587393812 ^ -1587405134);
			fAS1eRDhFW6C3jXeq0U(exportRule6, ExportRuleType.Export);
			exportRuleList.Add(exportRule6);
			return exportRuleList;
		}
	}

	[Transaction]
	public virtual int DeleteStaleMessages()
	{
		int num = 3;
		int num2 = num;
		string name = default(string);
		string text = default(string);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return TransformationProvider.ExecuteNonQuery(string.Format((string)fcvYKjVJ8K1a9yyp7wd(-193507406 ^ -193520846), rnMwSEDFZV0hY0HxH0c(AHoOssDx6CYOqKp4SnX(TransformationProvider), fcvYKjVJ8K1a9yyp7wd(-732058802 ^ -732037564)), ((Dialect)AHoOssDx6CYOqKp4SnX(TransformationProvider)).QuoteIfNeeded(name), rnMwSEDFZV0hY0HxH0c(AHoOssDx6CYOqKp4SnX(TransformationProvider), fcvYKjVJ8K1a9yyp7wd(-92270799 ^ -92260149)), ((Dialect)AHoOssDx6CYOqKp4SnX(TransformationProvider)).QuoteIfNeeded((string)fcvYKjVJ8K1a9yyp7wd(0x77CE159B ^ 0x77CE2DB7)), rnMwSEDFZV0hY0HxH0c(TransformationProvider.Dialect, text), 1L));
			case 2:
				name = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(hohACwVLNY6UgVDQ85L(typeof(IWorkflowInstance).TypeHandle), fcvYKjVJ8K1a9yyp7wd(-982315145 ^ -982304943));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(typeof(IWorkflowMessageItem), fcvYKjVJ8K1a9yyp7wd(0x2772A0C0 ^ 0x2772F4BA));
				num2 = 2;
				break;
			case 1:
				text = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 4;
				break;
			}
		}
	}

	[Transaction]
	public virtual IWorkflowMessageItem CreateMessage(IWorkflowInstance instance, IWorkflowMessageType messageType, object data)
	{
		int num = 9;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass21_.messageItem.MessageData = data;
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass21_._003C_003E4__this = this;
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					NOmUchD21NyV4bwFiWg(_003C_003Ec__DisplayClass21_.messageItem, messageType);
					num = 3;
					break;
				case 12:
					_003C_003Ec__DisplayClass21_.messageItem = AbstractNHEntityManager<IWorkflowMessageItem, long>.Instance.Create();
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					nHB4JGDsi7F8AOLnaFZ(_003C_003Ec__DisplayClass21_.messageItem, instance);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					Bjg2HeD8sQ8Opa4ycTL(instance, fcvYKjVJ8K1a9yyp7wd(-194568252 ^ -194561890));
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
					num2 = 8;
					continue;
				case 10:
					Bjg2HeD8sQ8Opa4ycTL(messageType, fcvYKjVJ8K1a9yyp7wd(-92270799 ^ -92262857));
					num = 4;
					break;
				case 2:
					mKbyuDDQxUb9UkoEC6l(base.UnitOfWorkManager, new Action(_003C_003Ec__DisplayClass21_._003CCreateMessage_003Eb__0));
					num2 = 6;
					continue;
				case 5:
					RP2KkPDqEHWpCi64bBP(_003C_003Ec__DisplayClass21_.messageItem);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					return _003C_003Ec__DisplayClass21_.messageItem;
				case 4:
					J3H7pkDtB0aVOU0dLh8(Uhkw5ZDwkLuCavuLCN0(messageType), fcvYKjVJ8K1a9yyp7wd(-2038019883 ^ -2038030879));
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
					{
						num2 = 7;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass21_.messageItem.ReceiverUids = null;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	public virtual IWorkflowMessageItem GetUnreadMessage(IWorkflowMessageType messageType, IWorkflowInstance destInstance)
	{
		return ((ICriteria)BGAKpHDMoqkhmFSfetB(R0tkUwDKSHiYJUiwstR(MBncc9DC7LWEK7GQga7(MBncc9DC7LWEK7GQga7(((ISession)pkiD31VfoKaDWMOX5It(this)).CreateCriteria<IWorkflowMessageItem>(), Restrictions.Eq((IProjection)(object)destInstanceProjection, (object)destInstance)), Gut7CwDVeKaLij8tlGs(messageTypeProjection, messageType)), KVIIGwDDWZPMGaXE9wk(createdTimestampProjection)), 1)).List<IWorkflowMessageItem>().FirstOrDefault();
	}

	public virtual List<IWorkflowMessageItem> GetUnreadMessages(IWorkflowMessageType messageType, IWorkflowInstance destInstance)
	{
		return base.Session.CreateCriteria<IWorkflowMessageItem>().Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)destInstanceProjection, (object)destInstance)).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)messageTypeProjection, (object)messageType))
			.AddOrder(Order.Asc((IProjection)(object)createdTimestampProjection))
			.List<IWorkflowMessageItem>()
			.ToList();
	}

	protected override void InitInternal()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SEyJJ1Da2hb9KjW8yEZ(this);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				KwfIYVDYvAjC2qrPs4Z(this);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[Transaction]
	protected virtual void MakeTimestampsForPreviouslyExistingMessages()
	{
		//Discarded unreachable code: IL_0146, IL_0187, IL_0196, IL_0294, IL_02b3, IL_02c2, IL_02ef, IL_02fe
		int num = 2;
		int num2 = num;
		IEnumerator<object[]> enumerator = default(IEnumerator<object[]>);
		object[] current = default(object[]);
		IWorkflowMessageItem workflowMessageItem = default(IWorkflowMessageItem);
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
			{
				object obj = MBncc9DC7LWEK7GQga7(((ISession)pkiD31VfoKaDWMOX5It(this)).CreateCriteria<IWorkflowMessageItem>(), Restrictions.IsNull((IProjection)(object)createdTimestampProjection));
				IProjection[] array = new IProjection[1];
				object obj2 = QT9IP0Dv4D9wwuNaddy();
				ParameterExpression parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(typeof(IWorkflowMessageItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30493005));
				object obj3 = pscSSxDP2a3fVSgLTlS(obj2, Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)AZFy5ZV7am2i844Vj0a(hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)kn1vHbVrIshnxjxjhEW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageItem).TypeHandle), fcvYKjVJ8K1a9yyp7wd(0xFA4957C ^ 0xFA4A566));
				array[0] = (IProjection)((ProjectionList)obj3).Add((IProjection)(object)Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)AZFy5ZV7am2i844Vj0a(hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				enumerator = ((ICriteria)obj).SetProjection((IProjection[])(object)array).List<object[]>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				try
				{
					while (true)
					{
						IL_0233:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
							{
								num3 = 0;
							}
							goto IL_0154;
						}
						goto IL_0210;
						IL_0210:
						current = enumerator.Current;
						num3 = 7;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 != 0)
						{
							num3 = 5;
						}
						goto IL_0154;
						IL_0154:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 4:
								workflowMessageItem.Timestamp = ConvertToTimestamp((DateTime)current[1]);
								num3 = 8;
								continue;
							case 3:
								if (workflowMessageItem == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 4;
							case 8:
							{
								RP2KkPDqEHWpCi64bBP(workflowMessageItem);
								int num4 = 6;
								num3 = num4;
								continue;
							}
							case 1:
								workflowMessageItem = LoadOrNull(id);
								num3 = 3;
								continue;
							case 5:
								break;
							case 2:
							case 6:
								goto IL_0233;
							case 7:
								id = (long)current[0];
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_0210;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_0298;
					}
					goto IL_02cd;
					IL_0298:
					switch (num5)
					{
					default:
						goto end_IL_0283;
					case 2:
						goto end_IL_0283;
					case 1:
						break;
					case 0:
						goto end_IL_0283;
					}
					goto IL_02cd;
					IL_02cd:
					MjKk5OD4doQ2bgiI2h3(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
					{
						num5 = 0;
					}
					goto IL_0298;
					end_IL_0283:;
				}
			case 0:
				return;
			}
		}
	}

	private long ConvertToTimestamp(DateTime datetime)
	{
		int num = 1;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			default:
				return KAEHmkDTKkr4xZcC3ql(TimestampService, timeSpan);
			case 1:
				timeSpan = datetime.ToUniversalTime() - jyYp3aD93tYoAmtSq8d();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdateMessageTimeStamp(long messageId)
	{
		int num = 2;
		string sql = default(string);
		ParameterExpression parameterExpression = default(ParameterExpression);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					TransformationProvider.ExecuteNonQuery(sql);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				case 2:
					parameterExpression = Expression.Parameter(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageItem).TypeHandle), (string)fcvYKjVJ8K1a9yyp7wd(0x467974A9 ^ 0x46795279));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 1:
					text = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)AZFy5ZV7am2i844Vj0a(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					continue;
				}
				break;
			}
			sql = (string)IfltX8DcMy4XMH9W8oj(fcvYKjVJ8K1a9yyp7wd(--230863782 ^ 0xDC2E6FC), new object[5]
			{
				((Dialect)AHoOssDx6CYOqKp4SnX(TransformationProvider)).QuoteIfNeeded((string)fcvYKjVJ8K1a9yyp7wd(0x664EA08F ^ 0x664EF585)),
				rnMwSEDFZV0hY0HxH0c(AHoOssDx6CYOqKp4SnX(TransformationProvider), text),
				TimestampService.GetTimestamp(),
				rnMwSEDFZV0hY0HxH0c(TransformationProvider.Dialect, fcvYKjVJ8K1a9yyp7wd(-1979431200 ^ -1979420390)),
				messageId
			});
			num = 3;
		}
	}

	public WorkflowMessageItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hJb2BiDNPoADFQXR7hj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessageItemManager()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 2:
				messageTypeProjection = Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(typeof(IWorkflowMessageItem), fcvYKjVJ8K1a9yyp7wd(-402075023 ^ -402066271));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
				{
					num2 = 3;
				}
				break;
			default:
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(hohACwVLNY6UgVDQ85L(typeof(IWorkflowMessageItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386102027 ^ -1386093531));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				destInstanceProjection = Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)DPfXAYVZeo07NADb7S9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 7;
				break;
			case 1:
				hJb2BiDNPoADFQXR7hj();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 5:
				parameterExpression = (ParameterExpression)J7tUtLVINnykhFB7C9B(typeof(IWorkflowMessageItem), fcvYKjVJ8K1a9yyp7wd(0xFA4957C ^ 0xFA4B3AC));
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				createdTimestampProjection = Projections.Property<IWorkflowMessageItem>(Expression.Lambda<Func<IWorkflowMessageItem, object>>(Expression.Convert((Expression)hVM82oVzVJ77QDXwFrA(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hohACwVLNY6UgVDQ85L(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 6;
				break;
			}
		}
	}

	internal static bool lWkjvdVujJd0T6qDQjL()
	{
		return OliLZqVi5mmVMbRPbDR == null;
	}

	internal static WorkflowMessageItemManager EcIq1uVl5ZMvKk49f0b()
	{
		return OliLZqVi5mmVMbRPbDR;
	}

	internal static object pkiD31VfoKaDWMOX5It(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static Type hohACwVLNY6UgVDQ85L(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fcvYKjVJ8K1a9yyp7wd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kn1vHbVrIshnxjxjhEW(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object AZFy5ZV7am2i844Vj0a(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object oninphV5kVCKXhOHRLw(object P_0)
	{
		return Projections.Count((IProjection)P_0);
	}

	internal static object ljNp6xVgNiJEAZj6kH4(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object zZd9JJV1Y1L3yswNQJS(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object J7tUtLVINnykhFB7C9B(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object DPfXAYVZeo07NADb7S9(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object hVM82oVzVJ77QDXwFrA(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object qpdeoXDETePmvZePCIe(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object MBncc9DC7LWEK7GQga7(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object bVydNCDXwriuM6BLqtj(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void Lv4bEGDoodICyI9owX2(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void wFKPqED3obv9IdMwQV7(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void fAS1eRDhFW6C3jXeq0U(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static object AHoOssDx6CYOqKp4SnX(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object rnMwSEDFZV0hY0HxH0c(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static void Bjg2HeD8sQ8Opa4ycTL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool Uhkw5ZDwkLuCavuLCN0(object P_0)
	{
		return ((IWorkflowMessageType)P_0).ReliableDelivery;
	}

	internal static void J3H7pkDtB0aVOU0dLh8(bool P_0, object P_1)
	{
		Contract.CheckArgument(P_0, (string)P_1);
	}

	internal static void nHB4JGDsi7F8AOLnaFZ(object P_0, object P_1)
	{
		((IWorkflowMessageItem)P_0).DestinationWorkflowInstance = (IWorkflowInstance)P_1;
	}

	internal static void NOmUchD21NyV4bwFiWg(object P_0, object P_1)
	{
		((IWorkflowMessageItem)P_0).MessageType = (IWorkflowMessageType)P_1;
	}

	internal static void RP2KkPDqEHWpCi64bBP(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void mKbyuDDQxUb9UkoEC6l(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static object Gut7CwDVeKaLij8tlGs(object P_0, object P_1)
	{
		return Restrictions.Eq((IProjection)P_0, P_1);
	}

	internal static object KVIIGwDDWZPMGaXE9wk(object P_0)
	{
		return Order.Asc((IProjection)P_0);
	}

	internal static object R0tkUwDKSHiYJUiwstR(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object BGAKpHDMoqkhmFSfetB(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void SEyJJ1Da2hb9KjW8yEZ(object P_0)
	{
		((NHManager)P_0).InitInternal();
	}

	internal static void KwfIYVDYvAjC2qrPs4Z(object P_0)
	{
		((WorkflowMessageItemManager)P_0).MakeTimestampsForPreviouslyExistingMessages();
	}

	internal static object QT9IP0Dv4D9wwuNaddy()
	{
		return Projections.ProjectionList();
	}

	internal static object pscSSxDP2a3fVSgLTlS(object P_0, object P_1)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1);
	}

	internal static void MjKk5OD4doQ2bgiI2h3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static DateTime jyYp3aD93tYoAmtSq8d()
	{
		return DateTime.UtcNow;
	}

	internal static long KAEHmkDTKkr4xZcC3ql(object P_0, TimeSpan P_1)
	{
		return ((ITimestampService)P_0).GetTimeStampRelativeToNow(P_1);
	}

	internal static object IfltX8DcMy4XMH9W8oj(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void hJb2BiDNPoADFQXR7hj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}

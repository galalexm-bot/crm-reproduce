using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowQueueItemManager : EntityManager<IWorkflowQueueItem, long>
{
	private static class NameOf
	{
		public static readonly object WorkflowBookmarkInstance;

		public static readonly object ElementUid;

		public static readonly object CreationDate;

		public static readonly object Attempt;

		public static readonly object LastExecuteDate;

		public static readonly object OnceExecuteTime;

		public static readonly object LastError;

		public static readonly object Error;

		public static readonly object Timeout;

		public static readonly object Process;

		public static readonly object Header;

		public static readonly object WorkflowBookmark;

		public static readonly object Task;

		public static readonly object OnceExecuteStatus;

		public static readonly object NextExecuteDate;

		public static readonly object StartDate;

		public static readonly object CreationAuthor;

		public static readonly object InstanceColumn;

		public static readonly object Author;

		public static readonly object SkipExecution;

		public static readonly object SkipConnectorUid;

		public static readonly object LastExceptionData;

		public static readonly object WorkflowQueueItemId;

		public static readonly object WorkflowQueueItemAttempt;

		public static readonly object WorkflowQueueItemBackgroundOperation;

		public static readonly object WorkflowQueueItemServerConnectionUid;

		public static readonly object LastTouchDate;

		public static readonly object IdPropertyName;

		public static readonly object WorkflowQueueItemServerConnectionName;

		private static object q71qZPZTA3LQOlA9pQSr;

		static NameOf()
		{
			int num = 11;
			ParameterExpression parameterExpression = default(ParameterExpression);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 54:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(typeof(IResumeProcessSchedulerJob), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4940C8E9));
						num2 = 49;
						continue;
					case 6:
						Author = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 20;
						continue;
					case 1:
						WorkflowQueueItemServerConnectionName = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 28;
						continue;
					case 53:
						parameterExpression = Expression.Parameter(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1016FDD));
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num2 = 17;
						}
						continue;
					case 47:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351389588));
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 35;
						}
						continue;
					case 36:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(-768800937 ^ -768755323));
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
						{
							num2 = 3;
						}
						continue;
					case 26:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(-43932417 ^ -43967955));
						num2 = 6;
						continue;
					case 31:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(0xA7339EE ^ 0xA73873C));
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
						{
							num2 = 6;
						}
						continue;
					case 23:
						Attempt = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(Expression.Property(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num2 = 1;
						}
						continue;
					case 37:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(ISchedulerJobRunInfo).TypeHandle), iGYY71ZToHXmgnX4aRqr(-63028171 ^ -62981401));
						num2 = 4;
						continue;
					case 21:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IEntity<object>).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF46F2A));
						num2 = 32;
						continue;
					case 8:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(0x628167BE ^ 0x6281D96C));
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 52;
						}
						continue;
					case 45:
						parameterExpression = Expression.Parameter(typeof(ISchedulerTask), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F4532));
						num2 = 12;
						continue;
					case 34:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4231AFEA));
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num2 = 59;
						}
						continue;
					case 7:
						NextExecuteDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
						{
							num2 = 51;
						}
						continue;
					case 16:
						ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 34;
						continue;
					case 4:
						Error = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 33;
						continue;
					case 14:
						LastExceptionData = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 47;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
						{
							num2 = 53;
						}
						continue;
					case 29:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(ISchedulerTaskJob).TypeHandle), iGYY71ZToHXmgnX4aRqr(-684210684 ^ -684230442));
						num2 = 42;
						continue;
					case 13:
						WorkflowQueueItemAttempt = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 8;
						continue;
					case 30:
						Timeout = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Convert((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 2;
						continue;
					case 39:
						WorkflowBookmarkInstance = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 23;
						}
						continue;
					case 25:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowBookmark).TypeHandle), iGYY71ZToHXmgnX4aRqr(-684210684 ^ -684230442));
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 3;
						}
						continue;
					case 22:
						WorkflowQueueItemId = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 44;
						continue;
					case 20:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716588930));
						num2 = 52;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num2 = 55;
						}
						continue;
					case 51:
						parameterExpression = Expression.Parameter(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowInstance).TypeHandle), (string)iGYY71ZToHXmgnX4aRqr(0x651FE29D ^ 0x651F5C4F));
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num2 = 10;
						}
						continue;
					case 48:
						CreationAuthor = LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 31;
						continue;
					case 32:
						IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>(Expression.Property(parameterExpression, (MethodInfo)FF2I4IZTe8s8vxN7jhjZ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 17;
						continue;
					case 5:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(0x17F0C5A2 ^ 0x17F07B70));
						num2 = 56;
						continue;
					case 12:
						OnceExecuteTime = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num2 = 43;
						}
						continue;
					case 42:
						OnceExecuteStatus = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTaskJob, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
						{
							num2 = 19;
						}
						continue;
					case 43:
						parameterExpression = Expression.Parameter(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), (string)iGYY71ZToHXmgnX4aRqr(-1716629332 ^ -1716588930));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
						{
							num2 = 0;
						}
						continue;
					case 44:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), iGYY71ZToHXmgnX4aRqr(0x65B7F624 ^ 0x65B748F6));
						num2 = 13;
						continue;
					case 56:
						LastExecuteDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 45;
						}
						continue;
					case 3:
						SkipConnectorUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num2 = 46;
						}
						continue;
					case 40:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514203636));
						num2 = 23;
						continue;
					case 59:
						CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(Expression.Property(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 40;
						continue;
					case 41:
						Process = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num2 = 24;
						}
						continue;
					case 46:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(typeof(IWorkflowQueueItem), iGYY71ZToHXmgnX4aRqr(0x5DB28AD2 ^ 0x5DB23400));
						num2 = 14;
						continue;
					case 35:
						WorkflowQueueItemServerConnectionUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 58;
						continue;
					case 10:
						parameterExpression = Expression.Parameter(typeof(IWorkflowBookmark), (string)iGYY71ZToHXmgnX4aRqr(-105863102 ^ -105900400));
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
						{
							num2 = 39;
						}
						continue;
					case 50:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(typeof(ISchedulerTaskJob), iGYY71ZToHXmgnX4aRqr(-1393899982 ^ -1393919776));
						num2 = 27;
						continue;
					case 18:
						InstanceColumn = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 26;
						continue;
					case 2:
						parameterExpression = Expression.Parameter(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowInstance).TypeHandle), (string)iGYY71ZToHXmgnX4aRqr(0x1C7F6FED ^ 0x1C7FD13F));
						num = 41;
						break;
					case 55:
						SkipExecution = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(Expression.Property(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 36;
						continue;
					case 27:
						Task = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTaskJob, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num = 29;
						break;
					case 24:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(typeof(IWorkflowProcess), iGYY71ZToHXmgnX4aRqr(0x1C663DA1 ^ 0x1C668373));
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 57;
						}
						continue;
					case 49:
						WorkflowBookmark = LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 50;
						continue;
					case 9:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IProcessHeader).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057750123));
						num2 = 48;
						continue;
					case 15:
						StartDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Convert((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						LastError = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 37;
						continue;
					case 33:
						parameterExpression = Expression.Parameter(typeof(IWorkflowQueueItem), (string)iGYY71ZToHXmgnX4aRqr(0x1145BED7 ^ 0x11450005));
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 30;
						}
						continue;
					case 28:
						return;
					case 19:
						parameterExpression = Expression.Parameter(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), (string)iGYY71ZToHXmgnX4aRqr(0x5DB28AD2 ^ 0x5DB23400));
						num2 = 7;
						continue;
					case 38:
						LastTouchDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)yvMopYZTrh8GLQI4nofI(GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wHm90EZTFHB8E29DqSoy(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 21;
						continue;
					case 17:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(wHm90EZTFHB8E29DqSoy(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x226903E0));
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num2 = 1;
						}
						continue;
					case 58:
						parameterExpression = (ParameterExpression)vl1lDgZTi8LYrNnshc7c(typeof(IWorkflowQueueItem), iGYY71ZToHXmgnX4aRqr(--1436248540 ^ 0x559BD70E));
						num2 = 38;
						continue;
					case 57:
						Header = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)GvdMsZZTa8WVNwnEysN6(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 54;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num2 = 4;
						}
						continue;
					case 11:
						v1CG61ZT23p0DKlEib8P();
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num2 = 10;
						}
						continue;
					case 52:
						WorkflowQueueItemBackgroundOperation = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Property(parameterExpression, (MethodInfo)Hprb9rZTIQ9mQh9xBXhU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
						{
							num2 = 47;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static void v1CG61ZT23p0DKlEib8P()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object iGYY71ZToHXmgnX4aRqr(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type wHm90EZTFHB8E29DqSoy(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object vl1lDgZTi8LYrNnshc7c(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object Hprb9rZTIQ9mQh9xBXhU(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static object GvdMsZZTa8WVNwnEysN6(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static object yvMopYZTrh8GLQI4nofI(object P_0, Type P_1)
		{
			return Expression.Convert((Expression)P_0, P_1);
		}

		internal static object FF2I4IZTe8s8vxN7jhjZ(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
		{
			return MethodBase.GetMethodFromHandle(P_0, P_1);
		}

		internal static bool UWlqN0ZTGJHHfAPRYVP7()
		{
			return q71qZPZTA3LQOlA9pQSr == null;
		}

		internal static NameOf TqYdlaZT7hQc2onGDQ0u()
		{
			return (NameOf)q71qZPZTA3LQOlA9pQSr;
		}
	}

	private class GetWorkflowQueueItemsResultSet
	{
		internal static object mK3dZZZTNNNWPWOfFkKR;

		public long Id
		{
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
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
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long Instance
		{
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
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
						_003CInstance_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
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

		public GetWorkflowQueueItemsResultSet()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JR4D6bZT1Gq9Ic8d7ugi();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool eA0DItZTxbTCaAjkZGi9()
		{
			return mK3dZZZTNNNWPWOfFkKR == null;
		}

		internal static GetWorkflowQueueItemsResultSet IPbx7gZTSxi2xETp9cl0()
		{
			return (GetWorkflowQueueItemsResultSet)mK3dZZZTNNNWPWOfFkKR;
		}

		internal static void JR4D6bZT1Gq9Ic8d7ugi()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static IWorkflowQueueService workflowQueueService;

	private WorkflowTaskSettingsModule workflowTaskSettingsModule;

	internal static WorkflowQueueItemManager ly5RAcuHaARZQ1Z9Buw;

	public WorkflowTaskSettingsModule WorkflowTaskSettingsModule
	{
		get
		{
			int num = 1;
			int num2 = num;
			WorkflowTaskSettingsModule workflowTaskSettingsModule = default(WorkflowTaskSettingsModule);
			WorkflowTaskSettingsModule obj;
			while (true)
			{
				switch (num2)
				{
				default:
					workflowTaskSettingsModule = (this.workflowTaskSettingsModule = Locator.GetServiceNotNull<WorkflowTaskSettingsModule>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.workflowTaskSettingsModule;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					obj = workflowTaskSettingsModule;
					break;
				}
				break;
			}
			return obj;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
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

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
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

	public SessionFactoryHolder SessionFactoryHolder
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionFactoryHolder_003Ek__BackingField;
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
					_003CSessionFactoryHolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
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

	private IWorkflowQueueService WorkflowQueueService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowQueueService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowQueueService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (workflowQueueService = Locator.GetServiceNotNull<IWorkflowQueueService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00b2
		int num = 2;
		AbstractCriterion val = default(AbstractCriterion);
		IWorkflowQueueItemFilter workflowQueueItemFilter = default(IWorkflowQueueItemFilter);
		IEnumerable<WorkflowQueueItemExecutionInfo> globalExecutions = default(IEnumerable<WorkflowQueueItemExecutionInfo>);
		IEnumerable<WorkflowQueueItemExecutionInfo> globalExecutions2 = default(IEnumerable<WorkflowQueueItemExecutionInfo>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					break;
				case 6:
					return;
				case 10:
					return;
				case 3:
					Lg5iJuuQT0WowsauTip(criteria, Yr6tRZu6QY1hDTURD7F(((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)val), jw1rEnuTfCnBqyXI9yp(NameOf.WorkflowQueueItemAttempt, 0L)));
					num2 = 10;
					continue;
				case 1:
					workflowQueueItemFilter = filter as IWorkflowQueueItemFilter;
					num2 = 11;
					continue;
				case 5:
					return;
				case 7:
					if (!Rqr4WBuqmZT2Ul2bXwL(workflowQueueItemFilter))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				case 4:
					globalExecutions = WorkflowQueueService.GetGlobalExecutions();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (workflowQueueItemFilter != null)
					{
						if (IwxiPBuW9dZ7p5AHDxq(workflowQueueItemFilter))
						{
							num2 = 8;
							continue;
						}
						goto case 7;
					}
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					aRUuWqu9yUPiytJDDmr(this, criteria, filter);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					criteria.Add((ICriterion)(object)((Junction)Yr6tRZu6QY1hDTURD7F(jdNuCFuj73yaRgcAJ5h(), STkWvguR9gT5CYEPOlY(Restrictions.In((string)NameOf.WorkflowQueueItemId, (ICollection)globalExecutions2.Select((WorkflowQueueItemExecutionInfo h) => _003C_003Ec.rKn427ZTzOEWUjGeOWFZ(h)).ToArray())))).Add((ICriterion)STkWvguR9gT5CYEPOlY(Restrictions.Eq((string)NameOf.WorkflowQueueItemAttempt, (object)0L))));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					val = (AbstractCriterion)hZn4XZu3ku35CHiJGqy(NameOf.WorkflowQueueItemId, globalExecutions.Select((WorkflowQueueItemExecutionInfo h) => _003C_003Ec.rKn427ZTzOEWUjGeOWFZ(h)).ToArray());
					num2 = 3;
					continue;
				}
				break;
			}
			globalExecutions2 = WorkflowQueueService.GetGlobalExecutions();
			num = 9;
		}
	}

	[Transaction(IsolationLevel = IsolationLevel.ReadUncommitted)]
	protected override ICollection<IWorkflowQueueItem> Find(ICriteria criteria)
	{
		return base.Find(criteria);
	}

	protected override void SetupSortOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		//Discarded unreachable code: IL_0162, IL_01e5, IL_01f5, IL_0204, IL_020f, IL_02b4, IL_0324, IL_0364, IL_0373, IL_037f, IL_040f, IL_0455, IL_0464
		int num = 16;
		List<long> list2 = default(List<long>);
		IProjection val2 = default(IProjection);
		List<long> list = default(List<long>);
		IEnumerator<WorkflowQueueItemExecutionInfo> enumerator = default(IEnumerator<WorkflowQueueItemExecutionInfo>);
		IType val = default(IType);
		WorkflowQueueItemExecutionInfo current = default(WorkflowQueueItemExecutionInfo);
		DateTime? executionStart = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 23:
					if (lbMkBuuVI7DsSuxnPfC(list2) > 0)
					{
						num2 = 11;
						break;
					}
					goto default;
				case 17:
					L8XFRYuIPryRDIitrgJ(criteria, upYxUquireCslXTV9ul(val2));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 0;
					}
					break;
				case 16:
					if (S6S2NhupyFXMA961CwN(fetchOptions, null))
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 2:
				{
					IEnumerable<WorkflowQueueItemExecutionInfo> globalExecutions = WorkflowQueueService.GetGlobalExecutions();
					list = new List<long>();
					list2 = new List<long>();
					enumerator = globalExecutions.GetEnumerator();
					num2 = 22;
					break;
				}
				case 4:
					criteria.AddOrder((Order)upYxUquireCslXTV9ul(Opuv2auedhQ8GQLQTKk(NameOf.WorkflowQueueItemId)));
					num2 = 6;
					break;
				case 15:
					if ((string)W4clNTuCAJBV4IuGsUl(fetchOptions) == (string)uH1F9QuMlAfFvom6TWj(0x6F6D7B44 ^ 0x6F6D3D84))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 5;
				case 1:
				case 13:
					L8XFRYuIPryRDIitrgJ(criteria, PBQ7Q7ua5NhEvwEjkFc(val2));
					num2 = 19;
					break;
				case 10:
					val2 = (IProjection)WibiNduomfExZOOvr11(hZn4XZu3ku35CHiJGqy(NameOf.WorkflowQueueItemId, Ptcfj1u78YZPOnhmcBm(list2)), NsakdKuGkmD5Pv6hy6l(val, SWegAmu2Il6DyAL3HnZ(1)), val2);
					num2 = 18;
					break;
				case 9:
					if (C0Z1xxuFwdecIQshZo8(fetchOptions) == ListSortDirection.Descending)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto IL_041a;
				case 22:
					try
					{
						while (true)
						{
							IL_0289:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num3 = 2;
								}
								goto IL_0213;
							}
							goto IL_023d;
							IL_023d:
							current = enumerator.Current;
							num3 = 6;
							goto IL_0213;
							IL_0213:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 7:
									if (executionStart.HasValue)
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 3;
								case 6:
									executionStart = current.ExecutionStart;
									num3 = 7;
									continue;
								default:
									goto IL_0289;
								case 3:
									list2.Add(L9lp8XukKevVScd8L0y(current));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									list.Add(L9lp8XukKevVScd8L0y(current));
									num3 = 5;
									continue;
								case 2:
									goto end_IL_0289;
								}
								break;
							}
							goto IL_023d;
							continue;
							end_IL_0289:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
							{
								num4 = 0;
							}
							goto IL_0328;
						}
						goto IL_033e;
						IL_033e:
						LEuP0EuUj8PFFvQujSF(enumerator);
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num4 = 2;
						}
						goto IL_0328;
						IL_0328:
						switch (num4)
						{
						default:
							goto end_IL_0303;
						case 1:
							break;
						case 0:
							goto end_IL_0303;
						case 2:
							goto end_IL_0303;
						}
						goto IL_033e;
						end_IL_0303:;
					}
					goto case 24;
				case 20:
					if (C0Z1xxuFwdecIQshZo8(fetchOptions) != 0)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 17;
				case 8:
				case 11:
					val = (IType)XQs6PPuAYph1rscotx0(uH1F9QuMlAfFvom6TWj(0x37F755F5 ^ 0x37F72791));
					num2 = 12;
					break;
				case 5:
					a2QSdwurDTgAt6nVdmR(this, criteria, fetchOptions, entityType);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 7;
					}
					break;
				case 24:
					if (lbMkBuuVI7DsSuxnPfC(list) > 0)
					{
						num2 = 8;
						break;
					}
					goto case 23;
				case 14:
					return;
				case 6:
					return;
				default:
					if (S6S2NhupyFXMA961CwN(fetchOptions, null))
					{
						num2 = 9;
						break;
					}
					goto IL_041a;
				case 21:
					if (lbMkBuuVI7DsSuxnPfC(list2) > 0)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 18;
				case 12:
					val2 = (IProjection)NsakdKuGkmD5Pv6hy6l(val, Projections.Constant((object)0));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 21;
					}
					break;
				case 18:
					if (lbMkBuuVI7DsSuxnPfC(list) > 0)
					{
						num2 = 3;
						break;
					}
					goto case 20;
				case 3:
					{
						val2 = (IProjection)WibiNduomfExZOOvr11(Restrictions.In((string)NameOf.WorkflowQueueItemId, (ICollection)Ptcfj1u78YZPOnhmcBm(list)), NsakdKuGkmD5Pv6hy6l(val, Projections.Constant((object)2)), val2);
						num2 = 20;
						break;
					}
					IL_041a:
					L8XFRYuIPryRDIitrgJ(criteria, PBQ7Q7ua5NhEvwEjkFc(Opuv2auedhQ8GQLQTKk(NameOf.WorkflowQueueItemId)));
					num2 = 14;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	[Transaction]
	internal virtual IWorkflowQueueItem CreateQueueItem(IWorkflowInstance instance, Element element, bool save = true)
	{
		//Discarded unreachable code: IL_0062, IL_0071, IL_00a1, IL_00b0, IL_00c3, IL_013b
		int num = 8;
		int num2 = num;
		IElementWithExceptionFlows elementWithExceptionFlows = default(IElementWithExceptionFlows);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 9:
				if (elementWithExceptionFlows == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 7:
				D2MD9muNZErW4wFIBJc(element, uH1F9QuMlAfFvom6TWj(0x651FE29D ^ 0x651F90EF));
				num2 = 11;
				break;
			case 4:
				return workflowQueueItem;
			case 5:
				if (eRlSUwuSHseNELekt6a(elementWithExceptionFlows))
				{
					num2 = 10;
					break;
				}
				goto case 2;
			case 8:
				D2MD9muNZErW4wFIBJc(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682900890));
				num2 = 7;
				break;
			case 2:
			case 3:
			case 6:
				WFZNCHu1gJYYKO2B77j(workflowQueueItem);
				num2 = 4;
				break;
			case 1:
				num3 = (SR.GetSetting((string)uH1F9QuMlAfFvom6TWj(0x37E97159 ^ 0x37E903DD), defaultValue: true) ? 1 : 0);
				goto IL_017e;
			case 10:
				workflowQueueItem.Timeout = elementWithExceptionFlows.GetQueueExecutionTimeout(instance);
				num2 = 3;
				break;
			case 11:
				if (EleWise.ELMA.Workflow.Services.WorkflowQueueService.IsWorkflowQueueItemExecutor)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				{
					num3 = 1;
					goto IL_017e;
				}
				IL_017e:
				workflowQueueItem = CreateQueueItem(instance, E5cujduxLVD8cM6iBku(element), save: false);
				elementWithExceptionFlows = element as IElementWithExceptionFlows;
				if (num3 == 0)
				{
					num2 = 2;
					break;
				}
				goto case 9;
			}
		}
	}

	[Transaction]
	internal virtual IWorkflowQueueItem CreateQueueItem(IWorkflowInstance instance, Guid elementUid, bool save = true)
	{
		//Discarded unreachable code: IL_0059, IL_0090, IL_00be, IL_00cd, IL_0144
		int num = 4;
		WorkflowTaskSettings settings = default(WorkflowTaskSettings);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				default:
					if (save)
					{
						num2 = 10;
						continue;
					}
					goto case 12;
				case 11:
					if (settings == null)
					{
						num2 = 13;
						continue;
					}
					goto case 2;
				case 2:
					num4 = (settings.ExecuteByResponsible ? 1 : 0);
					goto IL_0200;
				case 4:
					break;
				case 3:
					if (!EleWise.ELMA.Workflow.Services.WorkflowQueueService.IsWorkflowQueueItemExecutor)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num3 = 1;
					goto IL_019a;
				case 7:
				case 8:
					settings = WorkflowTaskSettingsModule.Settings;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					num3 = (SR.GetSetting((string)uH1F9QuMlAfFvom6TWj(0x6CC04061 ^ 0x6CC032E5), defaultValue: true) ? 1 : 0);
					goto IL_019a;
				case 12:
					return workflowQueueItem;
				case 10:
					WFZNCHu1gJYYKO2B77j(workflowQueueItem);
					num2 = 12;
					continue;
				case 9:
					workflowQueueItem.ServerConnectionUid = ksLRg2uz2VbdLbIgCkX(RuntimeApplication);
					num2 = 6;
					continue;
				case 6:
					IvsC7qDOk98UrV1Jjr9(workflowQueueItem, HTJGnADKiIgRJ9iSely(Locator.GetServiceNotNull<IApplicationEnvironmentService>()));
					num2 = 8;
					continue;
				case 13:
					num4 = 1;
					goto IL_0200;
				case 5:
					{
						rMVAZoD8Ve1e9UmFRte(workflowQueueItem, flag ? QKXNHEDYnvvgb7cpvTt(instance) : (I42rOjDvM2u62B0lTGi(rlcRCqDZoplHp8jhcum(this)) as IUser));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_019a:
					workflowQueueItem = InterfaceActivator.Create<IWorkflowQueueItem>();
					CB72tauEIukX3VWLTIj(workflowQueueItem, it3nocuhko0lKY8iGpg());
					evDu7KuwYoJrWDoMT7L(workflowQueueItem, instance);
					eg27Jmu4K3uaOk771H3(workflowQueueItem, elementUid);
					workflowQueueItem.NextExecuteDate = DateTime.Now.AddHours(-1.0);
					if (num3 == 0)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 9;
					IL_0200:
					flag = (byte)num4 != 0;
					num2 = 5;
					continue;
				}
				break;
			}
			Contract.ArgumentNotNull(instance, (string)uH1F9QuMlAfFvom6TWj(-130098986 ^ -130121264));
			num = 3;
		}
	}

	internal long GetFullQueueItemCount(IWorkflowQueueItemFilter filter)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00ca, IL_00d5, IL_00e3, IL_0172, IL_01aa, IL_01ec
		int num = 7;
		long result = default(long);
		IDataReader dataReader = default(IDataReader);
		string sql = default(string);
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		string text2 = default(string);
		string text = default(string);
		string text3 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 13:
					return result;
				case 11:
					obj = GC8oBMD0701upFAqpap(uH1F9QuMlAfFvom6TWj(0x5F534A5C ^ 0x5F53388C), uH1F9QuMlAfFvom6TWj(0x75872B6 ^ 0x7582B4A), ((Dialect)Yh8N93DsuXwiD0SYKdH(TransformationProvider)).QuoteIfNeeded((string)uH1F9QuMlAfFvom6TWj(-947937941 ^ -947921947)), filter.SearchString);
					goto IL_0396;
				case 14:
					try
					{
						while (true)
						{
							int num3;
							if (!dataReader.Read())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
								{
									num3 = 1;
								}
								goto IL_00e7;
							}
							goto IL_00fd;
							IL_00fd:
							result = MHSvkZD5fcIsk01uYuq(knQKx8DbqX8kh6CjZi0(dataReader, 0));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
							{
								num3 = 0;
							}
							goto IL_00e7;
							IL_00e7:
							switch (num3)
							{
							case 1:
								return result;
							case 2:
								break;
							default:
								continue;
							}
							goto IL_00fd;
						}
					}
					finally
					{
						if (dataReader != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									LEuP0EuUj8PFFvQujSF(dataReader);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 2:
				case 12:
					result = 0L;
					num2 = 4;
					continue;
				case 1:
					if (IwxiPBuW9dZ7p5AHDxq(filter))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 4:
					dataReader = TransformationProvider.ExecuteQuery(sql, paramValues);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 14;
					}
					continue;
				case 7:
					text2 = (string)cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), NameOf.OnceExecuteStatus);
					num = 6;
					break;
				case 9:
					paramValues = null;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					paramValues = new Dictionary<string, object>
					{
						{
							(string)uH1F9QuMlAfFvom6TWj(-947937941 ^ -947918201),
							0
						},
						{
							(string)uH1F9QuMlAfFvom6TWj(-980570076 ^ -980563924),
							JobStatus.Fail
						},
						{
							(string)uH1F9QuMlAfFvom6TWj(--1756698829 ^ 0x68B560F5),
							JobStatus.Errors
						}
					};
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					paramValues = new Dictionary<string, object>
					{
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516549626),
							0
						},
						{
							(string)uH1F9QuMlAfFvom6TWj(0x5DB28AD2 ^ 0x5DB2F2DA),
							JobStatus.Pending
						},
						{
							(string)uH1F9QuMlAfFvom6TWj(-351369538 ^ -351338874),
							JobStatus.Working
						}
					};
					num2 = 2;
					continue;
				case 6:
					text = (string)uH1F9QuMlAfFvom6TWj(-45832783 ^ -45820041);
					num2 = 10;
					continue;
				case 10:
					if (((string)Xq7WP6DlYKgRGe7C1J0(filter)).IsNullOrEmpty())
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 8:
					obj = string.Empty;
					goto IL_0396;
				case 5:
					{
						sql = (string)NdP9TuDtf0gyhQgmoif(wFANndDyYmBDGFByoIV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1134A1C6), filter.ShowTimer ? uH1F9QuMlAfFvom6TWj(-1028861977 ^ -1028867259) : "", uH1F9QuMlAfFvom6TWj(--1418337216 ^ 0x548A6CEA)), new object[23]
						{
							jExyvHDmrnWvgR3cxpV(TransformationProvider, uH1F9QuMlAfFvom6TWj(-22348816 ^ -22377274), uH1F9QuMlAfFvom6TWj(-148495695 ^ -148487327)),
							cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), NameOf.Attempt),
							TransformationProvider.ParameterSeparator,
							TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895832707), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F950F)),
							jExyvHDmrnWvgR3cxpV(TransformationProvider, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667468193), text),
							uH1F9QuMlAfFvom6TWj(0x56A753C9 ^ 0x56A7245B),
							cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(-432000546 ^ -431982760)),
							text,
							text2,
							IwxiPBuW9dZ7p5AHDxq(filter) ? uH1F9QuMlAfFvom6TWj(--601115071 ^ 0x23D43E77) : uH1F9QuMlAfFvom6TWj(0x614274E3 ^ 0x61420321),
							IwxiPBuW9dZ7p5AHDxq(filter) ? "" : wFANndDyYmBDGFByoIV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642744205), text2, uH1F9QuMlAfFvom6TWj(0x37E97159 ^ 0x37E90681)),
							cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(0x5DB28AD2 ^ 0x5DB2CC5C)),
							Xq7WP6DlYKgRGe7C1J0(filter),
							jExyvHDmrnWvgR3cxpV(TransformationProvider, uH1F9QuMlAfFvom6TWj(0x1145BED7 ^ 0x1145E67D), uH1F9QuMlAfFvom6TWj(-14356676 ^ -14371136)),
							text3,
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539500107),
							cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(0xD305CC2 ^ 0xD304C46)),
							jExyvHDmrnWvgR3cxpV(TransformationProvider, uH1F9QuMlAfFvom6TWj(-148495695 ^ -148486005), uH1F9QuMlAfFvom6TWj(-2122743969 ^ -2122761417)),
							uH1F9QuMlAfFvom6TWj(-14356676 ^ -14378834),
							cW48SjDJuaswZ0GqX0q(TransformationProvider.Dialect, NameOf.WorkflowBookmark),
							uH1F9QuMlAfFvom6TWj(0x75872B6 ^ 0x75836DE),
							cW48SjDJuaswZ0GqX0q(TransformationProvider.Dialect, uH1F9QuMlAfFvom6TWj(0x101D10F ^ 0x101C18B)),
							uH1F9QuMlAfFvom6TWj(-708128192 ^ -708136048)
						});
						num = 9;
						break;
					}
					IL_0396:
					text3 = (string)obj;
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	internal IEnumerable<IWorkflowQueueItem> GetFullQueueItemData(IWorkflowQueueItemFilter filter, FetchOptions fetchOptions)
	{
		string text = TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.OnceExecuteStatus);
		string text2 = (filter.SearchString.IsNullOrEmpty() ? string.Empty : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F44ABEA), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C66645D), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45817025)), filter.SearchString));
		string query = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF4A98C) + (filter.ShowTimer ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E90A05) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452104687)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10396785), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x738190BB)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862349542), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC037F3)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763690331), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B3020)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x35087EC), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E90EDD)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36166E19), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F44BD84)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483FC848), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682893560)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB77E457), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBCB35)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776297170), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050403566), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077761724), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514154150), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA56B72), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA14BC), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935316577), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC64F82)), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.IdPropertyName), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.WorkflowBookmarkInstance), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.ElementUid), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.CreationDate), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Attempt), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.LastExecuteDate), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.OnceExecuteTime), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Error), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Timeout), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Process), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Header), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.WorkflowBookmark), filter.StatusExecutionError ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x141BEA0) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125916742), text, filter.StatusExecutionError ? "" : (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14380880) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980561990)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74AB38A5), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638214382)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA5701C), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Task), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.NextExecuteDate), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.StartDate), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.CreationAuthor), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.InstanceColumn), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.LastError), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.Author), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.SkipExecution), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.SkipConnectorUid), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.LastExceptionData), TransformationProvider.Dialect.QuoteIfNeeded(text), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.WorkflowQueueItemServerConnectionUid), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.WorkflowQueueItemBackgroundOperation), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.LastTouchDate), TransformationProvider.Dialect.QuoteIfNeeded((string)NameOf.WorkflowQueueItemServerConnectionName), text2);
		if (fetchOptions != null && string.IsNullOrEmpty(fetchOptions.SortExpression) && (fetchOptions.FirstResult > 0 || fetchOptions.MaxResults > 0))
		{
			fetchOptions.SortExpression = (string)NameOf.IdPropertyName;
		}
		string text3 = TransformationProvider.SetupFetchOptions(query, fetchOptions);
		IQuery val = ((IQuery)(object)base.Session.CreateSQLQuery(text3).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716637836), InterfaceActivator.TypeOf<IWorkflowQueueItem>())).CleanUpCache(cleanUpCache: false);
		if (filter.ShowTimer)
		{
			val.SetParameter<int>(0, (!filter.StatusExecutionError) ? 1 : 4).SetParameter<int>(1, filter.StatusExecutionError ? 3 : 0);
		}
		return val.List<IWorkflowQueueItem>();
	}

	internal void ReleaseItems()
	{
		//Discarded unreachable code: IL_0139, IL_0148, IL_0153, IL_01f2, IL_0211, IL_0220, IL_024d, IL_025c, IL_036b, IL_037a, IL_0385, IL_0425, IL_045d, IL_046d, IL_047c, IL_0487, IL_0504, IL_0537, IL_059e, IL_061d, IL_0630, IL_063f, IL_067c, IL_068b, IL_072d, IL_0760, IL_07bd, IL_07cc, IL_07dd, IL_07ec, IL_07f7, IL_08b5, IL_0937, IL_099f, IL_09ae, IL_0a08, IL_0a1b, IL_0a2a
		int num = 8;
		int num2 = num;
		List<Guid> list = default(List<Guid>);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		List<Guid> list2 = default(List<Guid>);
		IDataReader dataReader2 = default(IDataReader);
		IDataReader dataReader = default(IDataReader);
		List<Guid>.Enumerator enumerator = default(List<Guid>.Enumerator);
		Guid current2 = default(Guid);
		Guid current = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 14:
				list = hashSet.Except(list2).ToList();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				dataReader2 = TransformationProvider.ExecuteQuery(string.Format((string)uH1F9QuMlAfFvom6TWj(0x37F755F5 ^ 0x37F7D469), jExyvHDmrnWvgR3cxpV(TransformationProvider, uH1F9QuMlAfFvom6TWj(-45832783 ^ -45821305), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F9A30)), cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(-865213812 ^ -865246502))));
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 9;
				}
				break;
			case 7:
				if (Xq4Z2IDgdjn1nNy3Eol(list2) <= 0)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 10:
				try
				{
					while (true)
					{
						int num15;
						if (!PLUpYUDX1bD7R6I1ksO(dataReader2))
						{
							num15 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num15 = 2;
							}
							goto IL_0157;
						}
						goto IL_0193;
						IL_0193:
						hashSet.Add(kR1S3IDPcjXOlsyyOtr(TransformationProvider.Dialect, dataReader2[(string)uH1F9QuMlAfFvom6TWj(-398691253 ^ -398658531)]));
						num15 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num15 = 1;
						}
						goto IL_0157;
						IL_0157:
						switch (num15)
						{
						case 1:
							break;
						default:
							goto IL_0193;
						case 2:
							goto end_IL_016d;
						}
						continue;
						end_IL_016d:
						break;
					}
				}
				finally
				{
					int num16;
					if (dataReader2 == null)
					{
						num16 = 2;
						goto IL_01f6;
					}
					goto IL_022b;
					IL_01f6:
					switch (num16)
					{
					case 2:
						goto end_IL_01e1;
					case 1:
						goto end_IL_01e1;
					}
					goto IL_022b;
					IL_022b:
					dataReader2.Dispose();
					num16 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num16 = 1;
					}
					goto IL_01f6;
					end_IL_01e1:;
				}
				goto case 13;
			case 4:
				hashSet = new HashSet<Guid>();
				num2 = 6;
				break;
			case 12:
				if (Xq4Z2IDgdjn1nNy3Eol(list) > 0)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 1:
				lWniLnDnBU42tQWNl9S(hashSet);
				num2 = 17;
				break;
			case 13:
				list = hashSet.Except(list2).ToList();
				num2 = 9;
				break;
			case 6:
				dataReader = TransformationProvider.ExecuteQuery((string)xYLAZWDB7plAeSrPr2P(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C00F4), jExyvHDmrnWvgR3cxpV(TransformationProvider, uH1F9QuMlAfFvom6TWj(0x1C7F6FED ^ 0x1C7FEFF1), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935311799)), cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(0x628167BE ^ 0x6281E7E8))));
				num2 = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 5;
				}
				break;
			case 16:
				try
				{
					while (true)
					{
						int num13;
						if (!PLUpYUDX1bD7R6I1ksO(dataReader))
						{
							num13 = 2;
							goto IL_0389;
						}
						goto IL_03b5;
						IL_0389:
						switch (num13)
						{
						case 1:
							break;
						default:
							goto IL_03b5;
						case 2:
							goto end_IL_039f;
						}
						continue;
						IL_03b5:
						hashSet.Add(kR1S3IDPcjXOlsyyOtr(Yh8N93DsuXwiD0SYKdH(TransformationProvider), Wcwq4pDcrPeJrlpBlxn(dataReader, uH1F9QuMlAfFvom6TWj(0x74AB4717 ^ 0x74ABC741))));
						num13 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
						{
							num13 = 1;
						}
						goto IL_0389;
						continue;
						end_IL_039f:
						break;
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num14 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							default:
								LEuP0EuUj8PFFvQujSF(dataReader);
								num14 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
								{
									num14 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 14;
			case 2:
				try
				{
					while (true)
					{
						int num9;
						if (!enumerator.MoveNext())
						{
							num9 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
							{
								num9 = 0;
							}
							goto IL_048b;
						}
						goto IL_05a8;
						IL_05a8:
						current2 = enumerator.Current;
						num9 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
						{
							num9 = 3;
						}
						goto IL_048b;
						IL_048b:
						switch (num9)
						{
						case 3:
							try
							{
								w0ke2tDLVoyc5qqbmtL(((ISession)bZ1EcNDH40suHvpI5pj(this)).GetNamedQuery((string)uH1F9QuMlAfFvom6TWj(-862330810 ^ -862363070)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC5D6F), current2));
								int num10 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
								{
									num10 = 0;
								}
								switch (num10)
								{
								case 0:
									break;
								}
							}
							catch (Exception ex2)
							{
								int num11 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
								{
									num11 = 0;
								}
								while (true)
								{
									switch (num11)
									{
									default:
										N5eS8lDDXUBcEtTG0tq(y01IBMDfZmisgG7cbW7(this), SR.T((string)uH1F9QuMlAfFvom6TWj(0x1C663DA1 ^ 0x1C66BF9B), current2), ex2);
										num11 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
										{
											num11 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							continue;
						case 2:
							continue;
						case 1:
							goto end_IL_05cb;
						}
						goto IL_05a8;
						continue;
						end_IL_05cb:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num12 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
				goto case 12;
			case 5:
				return;
			case 15:
				return;
			case 8:
				list2 = RuntimeApplication.GetActiveConnectionUids().ToList();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				enumerator = list.GetEnumerator();
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				try
				{
					((IQuery)ilbD2wD9UOoADu80t91(bZ1EcNDH40suHvpI5pj(this), uH1F9QuMlAfFvom6TWj(-1895853023 ^ -1895885169))).SetParameter<BackgroundOperationStatus>((string)uH1F9QuMlAfFvom6TWj(-11799394 ^ -11831696), BackgroundOperationStatus.Active).SetParameter<BackgroundOperationStatus>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCDA0AA), BackgroundOperationStatus.Prepared).List();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
					return;
				}
				catch (Exception exception)
				{
					int num8 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num8 = 1;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((ILogger)y01IBMDfZmisgG7cbW7(this)).Error(T2alKrDWXwcuSeE6Qaq(uH1F9QuMlAfFvom6TWj(-1516552726 ^ -1516519742)), exception);
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
							{
								num8 = 0;
							}
							break;
						}
					}
				}
			case 11:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_07fb;
						}
						goto IL_09b9;
						IL_07fb:
						switch (num3)
						{
						case 1:
							try
							{
								string sql = (string)GC8oBMD0701upFAqpap(uH1F9QuMlAfFvom6TWj(0x141C968 ^ 0x14149E8), cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(-22348816 ^ -22381588)), cW48SjDJuaswZ0GqX0q(Yh8N93DsuXwiD0SYKdH(TransformationProvider), uH1F9QuMlAfFvom6TWj(0x74AB4717 ^ 0x74ABC741)), TOGspuDdtY1WcB3x4uM(TransformationProvider));
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { 
										{
											(string)uH1F9QuMlAfFvom6TWj(-935313063 ^ -935280207),
											current
										} });
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
										{
											num4 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							catch (Exception ex)
							{
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										N5eS8lDDXUBcEtTG0tq(base.Logger, qhiwYxDuspNr0s7XZcL(uH1F9QuMlAfFvom6TWj(-1361036319 ^ -1361003789), new object[1] { current }), ex);
										num5 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
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
							break;
						case 2:
							goto IL_09b9;
						case 3:
							goto end_IL_0815;
						}
						continue;
						IL_09b9:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
						{
							num3 = 0;
						}
						goto IL_07fb;
						continue;
						end_IL_0815:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 9:
				enumerator = list.GetEnumerator();
				num2 = 2;
				break;
			}
		}
	}

	internal void ReleaseTouchedItems(DateTime lastTouchDate)
	{
		//Discarded unreachable code: IL_007c, IL_00af, IL_010c, IL_011b
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				((IQuery)ilbD2wD9UOoADu80t91(bZ1EcNDH40suHvpI5pj(this), uH1F9QuMlAfFvom6TWj(0x614CF569 ^ 0x614C7611))).SetParameter<DateTime>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716492185), iqJ2oHDjvd0syLA5iNv(lastTouchDate)).ExecuteUpdate();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					N5eS8lDDXUBcEtTG0tq(y01IBMDfZmisgG7cbW7(this), T2alKrDWXwcuSeE6Qaq(uH1F9QuMlAfFvom6TWj(0x141C968 ^ 0x1414AA8)), ex);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	internal Dictionary<long, long> GetItems(int processingCount, int backgroundOperationsCount)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_._003C_003E4__this = this;
		Dictionary<long, long> dictionary = new Dictionary<long, long>();
		_003C_003Ec__DisplayClass28_.appEnvironmentService = Locator.GetServiceNotNull<IApplicationEnvironmentService>();
		Action<string, int, Dictionary<long, long>> action = delegate(string queryName, int count, Dictionary<long, long> res)
		{
			foreach (GetWorkflowQueueItemsResultSet item in _003C_003Ec__DisplayClass28_._003C_003E4__this.Session.GetNamedQuery(queryName).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057762897), _003C_003Ec__DisplayClass28_._003C_003E4__this.RuntimeApplication.ConnectionUid).SetParameter<DateTime>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3616AD9B), DateTime.Now.ToServerDateTime())
				.SetParameter<string>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x226B6D26), _003C_003Ec__DisplayClass28_.appEnvironmentService.GetEnvironmentId())
				.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63138699), count)
				.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768769313), EleWise.ELMA.Workflow.Services.WorkflowQueueService.AttemptIntervals.Length)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(GetWorkflowQueueItemsResultSet)))
				.List<GetWorkflowQueueItemsResultSet>())
			{
				res.Add(item.Id, item.Instance);
			}
		};
		try
		{
			action(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A6D414), processingCount, dictionary);
			if (backgroundOperationsCount > 0)
			{
				action(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483F262C), backgroundOperationsCount, dictionary);
				return dictionary;
			}
			return dictionary;
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			return dictionary;
		}
	}

	internal long[] DeleteByWorkflowInstance(IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new long[0];
			case 1:
				if (instance != null)
				{
					return ((IQuery)ilbD2wD9UOoADu80t91(bZ1EcNDH40suHvpI5pj(this), uH1F9QuMlAfFvom6TWj(0x51EF0063 ^ 0x51EF84F3))).SetParameter<long>((string)uH1F9QuMlAfFvom6TWj(-682910880 ^ -682900890), instance.Id).SetParameter<BackgroundOperationStatus>((string)uH1F9QuMlAfFvom6TWj(0x1134D2C0 ^ 0x11345604), BackgroundOperationStatus.Active).SetParameter<BackgroundOperationStatus>((string)uH1F9QuMlAfFvom6TWj(0x6CC04061 ^ 0x6CC0C481), BackgroundOperationStatus.PendingCancellation)
						.SetParameter<BackgroundOperationStatus>((string)uH1F9QuMlAfFvom6TWj(0x6871CA ^ 0x68F534), BackgroundOperationStatus.Prepared)
						.List<long>()
						.ToArray();
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void WorkflowQueueItemForcedLaunch(long itemId)
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
				w0ke2tDLVoyc5qqbmtL(((IQuery)ilbD2wD9UOoADu80t91(base.Session, uH1F9QuMlAfFvom6TWj(-2057730233 ^ -2057764263))).SetParameter<long>((string)uH1F9QuMlAfFvom6TWj(0x5F534A5C ^ 0x5F53CF00), itemId).SetParameter<DateTime>((string)uH1F9QuMlAfFvom6TWj(0x1EA50FCC ^ 0x1EA58AA8), iqJ2oHDjvd0syLA5iNv(DateTime.Now.AddHours(-1.0))).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62996035), EleWise.ELMA.Workflow.Services.WorkflowQueueService.AttemptIntervals.Length));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal void TouchWorkflowQueueItem(long itemId)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				_003C_003Ec__DisplayClass31_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass31_.itemId = itemId;
				num2 = 3;
				break;
			case 3:
				lGlOXcDRxf18Hyrpxnn(base.Transformation, new Action(_003C_003Ec__DisplayClass31_._003CTouchWorkflowQueueItem_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public WorkflowQueueItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xJe0dGD6UEIqHnJZxn9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YWZLU5uLSGUhSTXw5nf()
	{
		return ly5RAcuHaARZQ1Z9Buw == null;
	}

	internal static WorkflowQueueItemManager qWXBqTuf3VYaFGm3GFs()
	{
		return ly5RAcuHaARZQ1Z9Buw;
	}

	internal static void aRUuWqu9yUPiytJDDmr(object P_0, object P_1, object P_2)
	{
		((EntityManager<IWorkflowQueueItem, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static bool IwxiPBuW9dZ7p5AHDxq(object P_0)
	{
		return ((IWorkflowQueueItemFilter)P_0).StatusExecutionError;
	}

	internal static object jdNuCFuj73yaRgcAJ5h()
	{
		return Restrictions.Conjunction();
	}

	internal static object STkWvguR9gT5CYEPOlY(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object Yr6tRZu6QY1hDTURD7F(object P_0, object P_1)
	{
		return ((Junction)P_0).Add((ICriterion)P_1);
	}

	internal static bool Rqr4WBuqmZT2Ul2bXwL(object P_0)
	{
		return ((IWorkflowQueueItemFilter)P_0).StatusExecutionActive;
	}

	internal static object hZn4XZu3ku35CHiJGqy(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object jw1rEnuTfCnBqyXI9yp(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object Lg5iJuuQT0WowsauTip(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool S6S2NhupyFXMA961CwN(object P_0, object P_1)
	{
		return (FetchOptions)P_0 != (FetchOptions)P_1;
	}

	internal static object W4clNTuCAJBV4IuGsUl(object P_0)
	{
		return ((FetchOptions)P_0).SortExpression;
	}

	internal static object uH1F9QuMlAfFvom6TWj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long L9lp8XukKevVScd8L0y(object P_0)
	{
		return ((WorkflowQueueItemExecutionInfo)P_0).ItemId;
	}

	internal static void LEuP0EuUj8PFFvQujSF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int lbMkBuuVI7DsSuxnPfC(object P_0)
	{
		return ((List<long>)P_0).Count;
	}

	internal static object XQs6PPuAYph1rscotx0(object P_0)
	{
		return TypeFactory.Basic((string)P_0);
	}

	internal static object NsakdKuGkmD5Pv6hy6l(object P_0, object P_1)
	{
		return Projections.Cast((IType)P_0, (IProjection)P_1);
	}

	internal static object Ptcfj1u78YZPOnhmcBm(object P_0)
	{
		return ((List<long>)P_0).ToArray();
	}

	internal static object SWegAmu2Il6DyAL3HnZ(object P_0)
	{
		return Projections.Constant(P_0);
	}

	internal static object WibiNduomfExZOOvr11(object P_0, object P_1, object P_2)
	{
		return Projections.Conditional((ICriterion)P_0, (IProjection)P_1, (IProjection)P_2);
	}

	internal static ListSortDirection C0Z1xxuFwdecIQshZo8(object P_0)
	{
		return ((FetchOptions)P_0).SortDirection;
	}

	internal static object upYxUquireCslXTV9ul(object P_0)
	{
		return Order.Desc((IProjection)P_0);
	}

	internal static object L8XFRYuIPryRDIitrgJ(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object PBQ7Q7ua5NhEvwEjkFc(object P_0)
	{
		return Order.Asc((IProjection)P_0);
	}

	internal static void a2QSdwurDTgAt6nVdmR(object P_0, object P_1, object P_2, Type P_3)
	{
		((EntityManager<IWorkflowQueueItem, long>)P_0).SetupSortOptions((ICriteria)P_1, (FetchOptions)P_2, P_3);
	}

	internal static object Opuv2auedhQ8GQLQTKk(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static void D2MD9muNZErW4wFIBJc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid E5cujduxLVD8cM6iBku(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static bool eRlSUwuSHseNELekt6a(object P_0)
	{
		return ((IElementWithExceptionFlows)P_0).QueueExecutionTimeoutSupported;
	}

	internal static void WFZNCHu1gJYYKO2B77j(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Guid it3nocuhko0lKY8iGpg()
	{
		return Guid.NewGuid();
	}

	internal static void CB72tauEIukX3VWLTIj(object P_0, Guid value)
	{
		((IWorkflowQueueItem)P_0).Uid = value;
	}

	internal static void evDu7KuwYoJrWDoMT7L(object P_0, object P_1)
	{
		((IWorkflowQueueItem)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static void eg27Jmu4K3uaOk771H3(object P_0, Guid value)
	{
		((IWorkflowQueueItem)P_0).ElementUid = value;
	}

	internal static Guid ksLRg2uz2VbdLbIgCkX(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConnectionUid;
	}

	internal static object HTJGnADKiIgRJ9iSely(object P_0)
	{
		return ((IApplicationEnvironmentService)P_0).GetEnvironmentId();
	}

	internal static void IvsC7qDOk98UrV1Jjr9(object P_0, object P_1)
	{
		((IWorkflowQueueItem)P_0).ServerConnectionName = (string)P_1;
	}

	internal static object rlcRCqDZoplHp8jhcum(object P_0)
	{
		return ((EntityManager<IWorkflowQueueItem, long>)P_0).AuthenticationService;
	}

	internal static object I42rOjDvM2u62B0lTGi(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object QKXNHEDYnvvgb7cpvTt(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}

	internal static void rMVAZoD8Ve1e9UmFRte(object P_0, object P_1)
	{
		((IWorkflowQueueItem)P_0).Author = (IUser)P_1;
	}

	internal static object Yh8N93DsuXwiD0SYKdH(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object cW48SjDJuaswZ0GqX0q(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Xq7WP6DlYKgRGe7C1J0(object P_0)
	{
		return ((IEntityFilter)P_0).SearchString;
	}

	internal static object GC8oBMD0701upFAqpap(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object wFANndDyYmBDGFByoIV(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object jExyvHDmrnWvgR3cxpV(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).NoLockTableExpression((string)P_1, (string)P_2);
	}

	internal static object NdP9TuDtf0gyhQgmoif(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object knQKx8DbqX8kh6CjZi0(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static long MHSvkZD5fcIsk01uYuq(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static int Xq4Z2IDgdjn1nNy3Eol(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static object xYLAZWDB7plAeSrPr2P(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object Wcwq4pDcrPeJrlpBlxn(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static Guid kR1S3IDPcjXOlsyyOtr(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static bool PLUpYUDX1bD7R6I1ksO(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object TOGspuDdtY1WcB3x4uM(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object qhiwYxDuspNr0s7XZcL(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void N5eS8lDDXUBcEtTG0tq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void lWniLnDnBU42tQWNl9S(object P_0)
	{
		((HashSet<Guid>)P_0).Clear();
	}

	internal static object bZ1EcNDH40suHvpI5pj(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object w0ke2tDLVoyc5qqbmtL(object P_0)
	{
		return ((IQuery)P_0).List();
	}

	internal static object y01IBMDfZmisgG7cbW7(object P_0)
	{
		return ((EntityManager<IWorkflowQueueItem, long>)P_0).Logger;
	}

	internal static object ilbD2wD9UOoADu80t91(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object T2alKrDWXwcuSeE6Qaq(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static DateTime iqJ2oHDjvd0syLA5iNv(DateTime P_0)
	{
		return P_0.ToServerDateTime();
	}

	internal static void lGlOXcDRxf18Hyrpxnn(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).RetryOnDeadlock((Action)P_1);
	}

	internal static void xJe0dGD6UEIqHnJZxn9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}

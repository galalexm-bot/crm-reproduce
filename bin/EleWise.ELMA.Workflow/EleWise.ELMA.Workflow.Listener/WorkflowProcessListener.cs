using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class WorkflowProcessListener : EntityEventsListener
{
	private readonly string nameShowGoodMetric;

	private readonly string nameShowProblemMetric;

	private readonly string nameShowWarningMetric;

	private readonly string nameShowIndicatorMode;

	internal static WorkflowProcessListener nlwInJ3qciAYeVbyxNQ;

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0157, IL_0347, IL_0377, IL_0386, IL_0535
		int num = 11;
		bool flag = default(bool);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		bool flag3 = default(bool);
		int num4 = default(int);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		string fieldName = default(string);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ShowIndicatorMode? showIndicatorMode = default(ShowIndicatorMode?);
		int num3 = default(int);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		string sql2 = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string text = default(string);
		string sql = default(string);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 30:
					if (flag == workflowProcess.ShowProblemMetric)
					{
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 5;
				case 1:
					flag = u1Yf4O3kNdvX9cWwDfS(((object[])duYGoD3MS6cnIN1DH3y(@event))[num5]);
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 7;
					}
					continue;
				case 17:
					flag2 = Convert.ToBoolean(((object[])duYGoD3MS6cnIN1DH3y(@event))[num6]);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (flag2 == Mna0813ihsWhRpLp5vf(workflowProcess))
					{
						num2 = 30;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 5;
				case 32:
					if (flag3 == t6uPpu3IZOBxmZPH3lT(workflowProcess))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 5;
				case 26:
					flag3 = u1Yf4O3kNdvX9cWwDfS(((object[])duYGoD3MS6cnIN1DH3y(@event))[num4]);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					entityMetadata2 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowProcess>();
					num2 = 14;
					continue;
				case 7:
					num6 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameShowGoodMetric);
					num2 = 29;
					continue;
				case 21:
					return false;
				case 16:
					fieldName = ((SimpleTypeSettings)Bl3wXc3UPGqDLmsPDFS(propertyMetadata)).FieldName;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					workflowProcess = HhKyRc3QlWkT97FNIL2(@event) as IWorkflowProcess;
					num2 = 10;
					continue;
				case 10:
					if (workflowProcess == null)
					{
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 7;
				case 8:
					showIndicatorMode = (ShowIndicatorMode?)((object[])duYGoD3MS6cnIN1DH3y(@event))[num3];
					num2 = 13;
					continue;
				case 15:
					if (propertyMetadata == null)
					{
						num = 2;
						break;
					}
					propertyMetadata2 = entityMetadata2.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec.Bb6E1oZA3loNCgvbMxtB(p.Name, _003C_003Ec.MaUpVKZAqaQQ1j1a17QB(-1214182792 ^ -1214160146)));
					num2 = 22;
					continue;
				case 24:
				case 31:
					sql2 = string.Format((string)CmPnIx3Gjxso2xElOXK(-1574607501 ^ -1574595167), vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), entityMetadata2.TableName), vfakNX325nwAC6q0M4E(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657553569)), A0TSkN3oCSDF8YcpYRb(serviceNotNull), vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), CmPnIx3Gjxso2xElOXK(0x1AF6F1F2 ^ 0x1AF6B774)), vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), fECOTv3F9Al1QdsZ6He(entityMetadata2)), vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), text), workflowProcess.Header.Id);
					num2 = 25;
					continue;
				case 28:
					if (!showIndicatorMode.HasValue)
					{
						num = 24;
						break;
					}
					goto case 20;
				case 22:
					if (propertyMetadata2 != null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 21;
				case 25:
					serviceNotNull.ExecuteNonQuery(sql2, new Dictionary<string, object> { 
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62999147),
						(int)j29q763A3eyM1brgIBp(workflowProcess)
					} });
					num2 = 4;
					continue;
				case 18:
					text = (string)lVGirZ3VBaQFjEuuEm8((SimpleTypeSettings)propertyMetadata2.Settings);
					num2 = 9;
					continue;
				case 12:
					serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>
					{
						{
							(string)CmPnIx3Gjxso2xElOXK(0x6F6D7B44 ^ 0x6F6D885C),
							P3iJaA3e1cBcwBJ9EB9(Mna0813ihsWhRpLp5vf(workflowProcess))
						},
						{
							(string)CmPnIx3Gjxso2xElOXK(--1756698829 ^ 0x68B5EBE1),
							P3iJaA3e1cBcwBJ9EB9(t6uPpu3IZOBxmZPH3lT(workflowProcess))
						},
						{
							(string)CmPnIx3Gjxso2xElOXK(-1430645277 ^ -1430591835),
							P3iJaA3e1cBcwBJ9EB9(jowVCo3NneJmq0IOD4a(workflowProcess))
						}
					});
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 27;
					}
					continue;
				case 29:
					num5 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameShowProblemMetric);
					num2 = 19;
					continue;
				case 20:
					if (showIndicatorMode.Value != j29q763A3eyM1brgIBp(workflowProcess))
					{
						num2 = 31;
						continue;
					}
					goto case 4;
				case 3:
				case 27:
					return false;
				case 23:
					return BSUAJt3xddunUqeAFKV(this, @event);
				case 13:
					entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowInstance>();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 6;
					}
					continue;
				case 19:
					num4 = Array.IndexOf((string[])EfcBsF3CkDr4MUQpAiv(wxSU2r3pZDHo6v6aNdI(@event)), nameShowWarningMetric);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 17;
					}
					continue;
				default:
					num3 = Array.IndexOf(((IEntityPersister)wxSU2r3pZDHo6v6aNdI(@event)).get_PropertyNames(), nameShowIndicatorMode);
					num2 = 17;
					continue;
				case 5:
					sql = (string)eSys0p3r14HmLoPc06W(CmPnIx3Gjxso2xElOXK(-1516552726 ^ -1516516272), new object[10]
					{
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), fECOTv3F9Al1QdsZ6He(entityMetadata)),
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), CmPnIx3Gjxso2xElOXK(-1214182792 ^ -1214121772)),
						A0TSkN3oCSDF8YcpYRb(serviceNotNull),
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), CmPnIx3Gjxso2xElOXK(0xDF4D1F8 ^ 0xDF42334)),
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682923630)),
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), fieldName),
						vfakNX325nwAC6q0M4E(WCXrLq37a51hnQHs8iy(serviceNotNull), CmPnIx3Gjxso2xElOXK(-1542190822 ^ -1542172772)),
						vfakNX325nwAC6q0M4E(serviceNotNull.Dialect, entityMetadata2.TableName),
						vfakNX325nwAC6q0M4E(serviceNotNull.Dialect, text),
						((IEntity<long>)qkgF473atIwKbShCeHa(workflowProcess)).Id
					});
					num2 = 12;
					continue;
				case 14:
					propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec.Bb6E1oZA3loNCgvbMxtB(p.Name, _003C_003Ec.MaUpVKZAqaQQ1j1a17QB(-865213812 ^ -865223500)));
					num2 = 15;
					continue;
				case 2:
					return false;
				}
				break;
			}
		}
	}

	public WorkflowProcessListener()
	{
		//Discarded unreachable code: IL_01c3, IL_01c8
		N9weGd3SDotIXfVeFJv();
		ParameterExpression parameterExpression = (ParameterExpression)pZYGH93hoVxET7enh0t(goN276316OZpIfJIfRk(typeof(IWorkflowProcess).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D8824));
		nameShowGoodMetric = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)h5Wvt634tugxkryPoHV(ATRLVQ3wyvl9MLrymXJ(parameterExpression, (MethodInfo)kZuBJR3Eh2rYkClKP1t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), goN276316OZpIfJIfRk(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
		parameterExpression = (ParameterExpression)pZYGH93hoVxET7enh0t(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B70544));
		nameShowProblemMetric = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)h5Wvt634tugxkryPoHV(ATRLVQ3wyvl9MLrymXJ(parameterExpression, (MethodInfo)kZuBJR3Eh2rYkClKP1t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), goN276316OZpIfJIfRk(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
		parameterExpression = (ParameterExpression)pZYGH93hoVxET7enh0t(typeof(IWorkflowProcess), CmPnIx3Gjxso2xElOXK(0x42311138 ^ 0x4231E258));
		nameShowWarningMetric = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)h5Wvt634tugxkryPoHV(Expression.Property(parameterExpression, (MethodInfo)kZuBJR3Eh2rYkClKP1t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), goN276316OZpIfJIfRk(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
		parameterExpression = (ParameterExpression)pZYGH93hoVxET7enh0t(goN276316OZpIfJIfRk(typeof(IWorkflowProcess).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801788601));
		nameShowIndicatorMode = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowProcess, object>>(Expression.Convert((Expression)ATRLVQ3wyvl9MLrymXJ(parameterExpression, (MethodInfo)kZuBJR3Eh2rYkClKP1t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), goN276316OZpIfJIfRk(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object HhKyRc3QlWkT97FNIL2(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object wxSU2r3pZDHo6v6aNdI(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object EfcBsF3CkDr4MUQpAiv(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object duYGoD3MS6cnIN1DH3y(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static bool u1Yf4O3kNdvX9cWwDfS(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	internal static object Bl3wXc3UPGqDLmsPDFS(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object lVGirZ3VBaQFjEuuEm8(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static ShowIndicatorMode j29q763A3eyM1brgIBp(object P_0)
	{
		return ((IWorkflowProcess)P_0).ShowIndicatorMode;
	}

	internal static object CmPnIx3Gjxso2xElOXK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WCXrLq37a51hnQHs8iy(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object vfakNX325nwAC6q0M4E(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object A0TSkN3oCSDF8YcpYRb(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object fECOTv3F9Al1QdsZ6He(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool Mna0813ihsWhRpLp5vf(object P_0)
	{
		return ((IWorkflowProcess)P_0).ShowGoodMetric;
	}

	internal static bool t6uPpu3IZOBxmZPH3lT(object P_0)
	{
		return ((IWorkflowProcess)P_0).ShowWarningMetric;
	}

	internal static object qkgF473atIwKbShCeHa(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object eSys0p3r14HmLoPc06W(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static byte P3iJaA3e1cBcwBJ9EB9(bool P_0)
	{
		return Convert.ToByte(P_0);
	}

	internal static bool jowVCo3NneJmq0IOD4a(object P_0)
	{
		return ((IWorkflowProcess)P_0).ShowProblemMetric;
	}

	internal static bool BSUAJt3xddunUqeAFKV(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreUpdate((PreUpdateEvent)P_1);
	}

	internal static bool bvLVMA33rn7XqV5xHEZ()
	{
		return nlwInJ3qciAYeVbyxNQ == null;
	}

	internal static WorkflowProcessListener hmYo8H3ToHdxOMN86JY()
	{
		return nlwInJ3qciAYeVbyxNQ;
	}

	internal static void N9weGd3SDotIXfVeFJv()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type goN276316OZpIfJIfRk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pZYGH93hoVxET7enh0t(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object kZuBJR3Eh2rYkClKP1t(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ATRLVQ3wyvl9MLrymXJ(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object h5Wvt634tugxkryPoHV(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}

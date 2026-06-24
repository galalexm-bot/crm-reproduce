using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Script.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowMessageBookmarkManager : EntityManager<IWorkflowMessageBookmark, long>
{
	private static readonly PropertyProjection P_WMB_MessageType;

	private static readonly PropertyProjection P_WMB_Status;

	private static readonly PropertyProjection P_WMB_ControlParameter;

	private static readonly string F_WMB_Bookmark;

	private static readonly string F_Bookmark_Instance;

	private static readonly string F_Bookmark_ElementUid;

	private static readonly string F_Instance_Status;

	private static readonly string TypeUidPropertyName;

	private static readonly string IdPropertyName;

	internal static WorkflowMessageBookmarkManager ILhjabVTsJcNSrJUKDA;

	public virtual IList<IWorkflowMessageBookmark> GetAwaitingMessageBookmarks(IWorkflowInstance instance, IWorkflowMessageType messageType, WebData data)
	{
		Contract.ArgumentNotNull(messageType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-361150192 ^ -361142250));
		ICriteria val = base.Session.CreateCriteria<IWorkflowMessageBookmark>().Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)P_WMB_MessageType, (object)messageType)).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)P_WMB_Status, (object)WorkflowMessageBookmarkStatus.Awaiting));
		val.CreateAlias(F_WMB_Bookmark, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1661455645 ^ 0x6307EF95));
		val.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365449958 ^ -1365458550) + F_Bookmark_Instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-437373675 ^ -437381233));
		val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1275462473 ^ -1275482319) + F_Instance_Status, (object)WorkflowInstanceStatus.Running));
		if (instance != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1843608060 ^ -1843620458), F_Bookmark_Instance), (object)instance.Id));
		}
		IWorkflowMessageTypeParameter controlParam = ((IEnumerable<IWorkflowMessageTypeParameter>)messageType.Parameters).FirstOrDefault((IWorkflowMessageTypeParameter p) => _003C_003Ec.sD6A7knTaVu17JDW2yv(p));
		string text = AwaitingMessageControlParamValue(controlParam, data);
		if (text != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)P_WMB_ControlParameter, (object)text));
		}
		else
		{
			val.Add((ICriterion)(object)Restrictions.IsNull((IProjection)(object)P_WMB_ControlParameter));
		}
		return val.List<IWorkflowMessageBookmark>();
	}

	internal IList<IWorkflowMessageBookmark> GetAwaitingMessageBookmarks(IWorkflowInstance instance)
	{
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A4998B0 ^ 0x2A49BFEA));
		return base.Session.CreateCriteria<IWorkflowMessageBookmark>().Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)P_WMB_Status, (object)WorkflowMessageBookmarkStatus.Awaiting)).CreateAlias(F_WMB_Bookmark, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE108112 ^ 0xE10A39A))
			.Add((ICriterion)(object)Restrictions.Eq(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949720076 ^ -949733274), F_Bookmark_Instance), (object)instance.Id))
			.List<IWorkflowMessageBookmark>();
	}

	public virtual IWorkflowMessageBookmark FindMessageBookmark(IWorkflowInstance instance, IWorkflowMessageType messageType, Guid elementUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				i5HPCxVj9L1PIl8RlAV(messageType, olAN0wVd4G6f8ZpIanv(-1633140121 ^ -1633131679));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				i5HPCxVj9L1PIl8RlAV(instance, olAN0wVd4G6f8ZpIanv(-1643416224 ^ -1643425222));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				object obj = lbpnTDVb5eJo26K1pk4(lbpnTDVb5eJo26K1pk4(((ISession)HfwrlBVSvBVWPnL8oY6(this)).CreateCriteria<IWorkflowMessageBookmark>(), murVj1Vkto4ISjNcZIe(P_WMB_MessageType, messageType)), murVj1Vkto4ISjNcZIe(P_WMB_Status, WorkflowMessageBookmarkStatus.Awaiting));
				((ICriteria)obj).CreateAlias(F_WMB_Bookmark, (string)olAN0wVd4G6f8ZpIanv(-1979431200 ^ -1979423640));
				((ICriteria)obj).CreateAlias((string)GUhtGHVUgTegUWMITZv(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x19163E7B ^ 0x19161CEB), F_Bookmark_Instance), (string)olAN0wVd4G6f8ZpIanv(-1756425685 ^ -1756417871));
				((ICriteria)obj).Add((ICriterion)(object)Restrictions.Eq((string)GUhtGHVUgTegUWMITZv(olAN0wVd4G6f8ZpIanv(0x2772A0C0 ^ 0x2772F346), F_Instance_Status), (object)WorkflowInstanceStatus.Running));
				lbpnTDVb5eJo26K1pk4(obj, kcCjo5VmyGKwSOTItre(GUhtGHVUgTegUWMITZv(olAN0wVd4G6f8ZpIanv(-1774307336 ^ -1774316184), F_Bookmark_Instance), instance));
				lbpnTDVb5eJo26K1pk4(obj, kcCjo5VmyGKwSOTItre(GUhtGHVUgTegUWMITZv(olAN0wVd4G6f8ZpIanv(-588615921 ^ -588624481), F_Bookmark_ElementUid), elementUid));
				return ((ICriteria)IWWULRVADYyZEpOdTou(obj, 1)).List<IWorkflowMessageBookmark>().FirstOrDefault();
			}
			}
		}
	}

	public string AwaitingMessageControlParamValue(IWorkflowMessageTypeParameter controlParam, WebData data)
	{
		//Discarded unreachable code: IL_01e8, IL_0217, IL_0226, IL_02a8, IL_02b7, IL_031b, IL_033d, IL_034c, IL_0395, IL_03a4
		int num = 27;
		int num2 = num;
		List<KeyValuePair<Guid, object>> list = default(List<KeyValuePair<Guid, object>>);
		WebDataItem webDataItem3 = default(WebDataItem);
		string value = default(string);
		WebDataItem webDataItem2 = default(WebDataItem);
		WebDataItem webDataItem = default(WebDataItem);
		int num3 = default(int);
		long result = default(long);
		WebDataItem webDataItem4 = default(WebDataItem);
		WebData webData = default(WebData);
		WebData[] dataArray = default(WebData[]);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 16:
				list = new List<KeyValuePair<Guid, object>>();
				num2 = 20;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed == 0)
				{
					num2 = 7;
				}
				break;
			case 1:
				if (zhrdvBVpLTqqjhS099e(data) == null)
				{
					num2 = 5;
					break;
				}
				obj = kBCZshVGDO3afJeoigZ(data, controlParam.Name);
				goto IL_03e4;
			case 10:
				if (webDataItem3 == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
					{
						num2 = 0;
					}
					break;
				}
				value = webDataItem3.Value;
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
				{
					num2 = 8;
				}
				break;
			case 11:
				if (webDataItem2 != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 23;
			case 27:
				if (controlParam != null)
				{
					num2 = 26;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
					{
						num2 = 17;
					}
					break;
				}
				goto default;
			case 8:
				if (value != null)
				{
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
					{
						num2 = 14;
					}
					break;
				}
				if (SspgdVVn3X13lFhHZMS(webDataItem3) != null)
				{
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 21;
			case 14:
				if (webDataItem == null)
				{
					num2 = 21;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
					{
						num2 = 15;
					}
					break;
				}
				goto case 15;
			case 15:
				return webDataItem.Value;
			case 21:
				if (auSHYLVyti0SOdp8h8i(webDataItem3) != null)
				{
					num2 = 16;
					break;
				}
				return null;
			case 17:
				webDataItem = (WebDataItem)kBCZshVGDO3afJeoigZ(SspgdVVn3X13lFhHZMS(webDataItem3), IdPropertyName);
				num2 = 14;
				break;
			case 23:
			case 28:
				num3++;
				num2 = 18;
				break;
			case 6:
				if (!long.TryParse((string)Vxb4LcVOa27pV30BFSC(webDataItem2), out result))
				{
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
					{
						num2 = 23;
					}
					break;
				}
				goto case 13;
			case 2:
			case 5:
				obj = null;
				goto IL_03e4;
			case 4:
				return null;
			case 13:
				list.Add(new KeyValuePair<Guid, object>(new Guid(webDataItem4.Value), result));
				num2 = 28;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
				{
					num2 = 24;
				}
				break;
			case 7:
				if (webDataItem4 != null)
				{
					num2 = 24;
					break;
				}
				goto case 23;
			case 25:
				webDataItem4 = (WebDataItem)kBCZshVGDO3afJeoigZ(webData, TypeUidPropertyName);
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
				{
					num2 = 7;
				}
				break;
			case 18:
			case 22:
				if (num3 >= dataArray.Length)
				{
					num2 = 3;
					break;
				}
				goto case 12;
			default:
				return null;
			case 26:
				if (data == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 9:
				num3 = 0;
				num2 = 22;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
				{
					num2 = 22;
				}
				break;
			case 20:
				dataArray = webDataItem3.DataArray;
				num2 = 9;
				break;
			case 24:
				webDataItem2 = (WebDataItem)kBCZshVGDO3afJeoigZ(webData, IdPropertyName);
				num2 = 11;
				break;
			case 12:
				webData = dataArray[num3];
				num2 = 25;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
				{
					num2 = 17;
				}
				break;
			case 19:
				return value;
			case 3:
				{
					return (string)zW0FUnV6V0jbQ77mOJl(new JsonSerializer(), list.OrderBy((KeyValuePair<Guid, object> a) => a.Value));
				}
				IL_03e4:
				webDataItem3 = (WebDataItem)obj;
				num2 = 10;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public WorkflowMessageBookmarkManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r3vyBpVRNXQf4hmhUoh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessageBookmarkManager()
	{
		int num = 8;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					parameterExpression = Expression.Parameter(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowBookmark).TypeHandle), (string)olAN0wVd4G6f8ZpIanv(-901337984 ^ -901346736));
					num2 = 18;
					continue;
				case 11:
					F_Instance_Status = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Convert((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)O16GSQVWRjHVgimAVtb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), P2pEp4V04mkTEaa7LhG(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num = 17;
					break;
				case 19:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowMessageBookmark).TypeHandle), olAN0wVd4G6f8ZpIanv(-711228462 ^ -711219966));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowMessageBookmark).TypeHandle), olAN0wVd4G6f8ZpIanv(-982315145 ^ -982308441));
					num2 = 9;
					continue;
				case 10:
					P_WMB_Status = Projections.Property<IWorkflowMessageBookmark>(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)x2MyB0VejqvKuCuWOu1(Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					F_WMB_Bookmark = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)O16GSQVWRjHVgimAVtb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 15;
					continue;
				case 4:
					TypeUidPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IInheritable, object>>((Expression)x2MyB0VejqvKuCuWOu1(Expression.Property(parameterExpression, (MethodInfo)O16GSQVWRjHVgimAVtb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), P2pEp4V04mkTEaa7LhG(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 2;
					continue;
				case 6:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowMessageBookmark).TypeHandle), olAN0wVd4G6f8ZpIanv(-1411073168 ^ -1411080800));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					P_WMB_ControlParameter = Projections.Property<IWorkflowMessageBookmark>(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 19;
					continue;
				case 17:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(typeof(IInheritable), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-982315145 ^ -982308441));
					num2 = 4;
					continue;
				case 12:
					parameterExpression = Expression.Parameter(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowInstance).TypeHandle), (string)olAN0wVd4G6f8ZpIanv(0x664EA08F ^ 0x664E865F));
					num2 = 11;
					continue;
				case 7:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(P2pEp4V04mkTEaa7LhG(typeof(IWorkflowMessageBookmark).TypeHandle), olAN0wVd4G6f8ZpIanv(0xFA4957C ^ 0xFA4B3AC));
					num2 = 16;
					continue;
				case 2:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(P2pEp4V04mkTEaa7LhG(typeof(IEntity<object>).TypeHandle), olAN0wVd4G6f8ZpIanv(-982315145 ^ -982295329));
					num = 5;
					break;
				case 15:
					return;
				case 8:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					F_Bookmark_Instance = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)O16GSQVWRjHVgimAVtb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
					{
						num2 = 13;
					}
					continue;
				case 18:
					F_Bookmark_ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>(Expression.Convert((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), P2pEp4V04mkTEaa7LhG(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 12;
					}
					continue;
				case 16:
					P_WMB_MessageType = Projections.Property<IWorkflowMessageBookmark>(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)Wj9KVEVHPMQLCko3LS5(parameterExpression, (MethodInfo)O16GSQVWRjHVgimAVtb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num = 6;
					break;
				default:
					parameterExpression = (ParameterExpression)Sr0QhHVB8JNOZLdQLXT(typeof(IWorkflowBookmark), olAN0wVd4G6f8ZpIanv(0x5DD795B3 ^ 0x5DD7B363));
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	internal static object olAN0wVd4G6f8ZpIanv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void i5HPCxVj9L1PIl8RlAV(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object HfwrlBVSvBVWPnL8oY6(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object murVj1Vkto4ISjNcZIe(object P_0, object P_1)
	{
		return Restrictions.Eq((IProjection)P_0, P_1);
	}

	internal static object lbpnTDVb5eJo26K1pk4(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object GUhtGHVUgTegUWMITZv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object kcCjo5VmyGKwSOTItre(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object IWWULRVADYyZEpOdTou(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static bool heLntsVcAWbUDaWvfpf()
	{
		return ILhjabVTsJcNSrJUKDA == null;
	}

	internal static WorkflowMessageBookmarkManager ndM5xkVNFkVBKDgcUgK()
	{
		return ILhjabVTsJcNSrJUKDA;
	}

	internal static object zhrdvBVpLTqqjhS099e(object P_0)
	{
		return ((WebData)P_0).Items;
	}

	internal static object kBCZshVGDO3afJeoigZ(object P_0, object P_1)
	{
		return ((WebData)P_0).FindItem((string)P_1);
	}

	internal static object SspgdVVn3X13lFhHZMS(object P_0)
	{
		return ((WebDataItem)P_0).Data;
	}

	internal static object auSHYLVyti0SOdp8h8i(object P_0)
	{
		return ((WebDataItem)P_0).DataArray;
	}

	internal static object Vxb4LcVOa27pV30BFSC(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static object zW0FUnV6V0jbQ77mOJl(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static void r3vyBpVRNXQf4hmhUoh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Type P2pEp4V04mkTEaa7LhG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Sr0QhHVB8JNOZLdQLXT(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object O16GSQVWRjHVgimAVtb(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object Wj9KVEVHPMQLCko3LS5(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object x2MyB0VejqvKuCuWOu1(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components.Feed;

[Component(Order = 1300)]
internal class FeedCommentWorkflowInstanceExtension : BaseFeedPostExtension
{
	internal static FeedCommentWorkflowInstanceExtension bJw5M7Oc7N1YRF7dnLdt;

	private void CheckForWorkflowInstance(Dictionary<long, bool> items)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		SecurityService serviceNotNull = Locator.GetServiceNotNull<SecurityService>();
		if (!items.Any())
		{
			return;
		}
		if (serviceNotNull.HasPermission(currentUser, WorkflowPermissionProvider.FullMonitorAccessPermission))
		{
			foreach (long item in items.Keys.ToList())
			{
				items[item] = true;
			}
			return;
		}
		CS_0024_003C_003E8__locals0.transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600042278), items.Select((KeyValuePair<long, bool> j) => j.Key));
		string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965175819), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B7B0A2)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360614717)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949736295), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D690EF)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A714CD), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949744713)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600037784)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A79FBC), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638177414)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7581A20)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B61B867)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46F6C13), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002051045)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197661382), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438BDE5D)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614D254F)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716551454)), CS_0024_003C_003E8__locals0.transformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351348498), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B61A0FD)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614D25EB)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C21CE)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11835916)), CS_0024_003C_003E8__locals0.transformationProvider.ParameterSeparator, CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716472499)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935325523)), text, CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614D3A93)), currentUser.GetId());
		using (IDataReader dataReader = CS_0024_003C_003E8__locals0.transformationProvider.ExecuteQuery(sql, new Dictionary<string, object> { 
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148459413),
			Guid.Parse(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716467485))
		} }))
		{
			while (dataReader.Read())
			{
				if (!(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1E342F)] is DBNull))
				{
					long key = Convert.ToInt64(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45782325)]);
					if (items.ContainsKey(key))
					{
						items[key] = true;
					}
				}
			}
		}
		IEnumerable<KeyValuePair<long, bool>> enumerable = items.Where((KeyValuePair<long, bool> i) => !i.Value);
		if (!enumerable.Any())
		{
			return;
		}
		string text2 = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA595CE), enumerable.Select((KeyValuePair<long, bool> item, int i) => string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420114307), CS_0024_003C_003E8__locals0.transformationProvider.ParameterSeparator, i)));
		Dictionary<string, object> dictionary = new Dictionary<string, object> { 
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABD7AF),
			currentUser.GetId()
		} };
		int num = 0;
		using (IEnumerator<KeyValuePair<long, bool>> enumerator2 = enumerable.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				dictionary.Add(value: enumerator2.Current.Key, key: SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B3796) + num);
				num++;
			}
		}
		string sql2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548BCB50), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683729626)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542076832)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A699D67)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077792902)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028858013)), CS_0024_003C_003E8__locals0.transformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106508255)), CS_0024_003C_003E8__locals0.transformationProvider.ParameterSeparator, text2);
		using IDataReader dataReader2 = CS_0024_003C_003E8__locals0.transformationProvider.ExecuteQuery(sql2, dictionary);
		while (dataReader2.Read())
		{
			if (!(dataReader2[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539915671)] is DBNull))
			{
				long key2 = Convert.ToInt64(dataReader2[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708108998)]);
				if (items.ContainsKey(key2))
				{
					items[key2] = true;
				}
			}
		}
	}

	public override Guid GetCommentActionUid(Guid objectUid)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1
		int num = 3;
		int num2 = num;
		Guid guid = default(Guid);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				guid = InterfaceActivator.UID<IWorkflowInstance>();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
			case 4:
				return t2e8DmOcapwsoPbMOla5();
			default:
				if (!type.IsSubclassOf(HN54ByOcIIl6HCQCN07A(Locator.GetServiceNotNull<IMetadataRuntimeService>(), guid, true)))
				{
					return Guid.Empty;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				type = kaSybaOcFV7H7I3hfjcj(Locator.GetServiceNotNull<IMetadataRuntimeService>(), objectUid, true);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (zXQpt1OciIKkfwwERRKn(objectUid, guid))
				{
					num2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	protected override List<Guid> CommentSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<IWorkflowInstance>() };
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && CommentIsSupported(objectUid))
		{
			Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
			if (objectUid == InterfaceActivator.UID<IWorkflowInstance>() || typeByUidOrNull.IsSubclassOf(InterfaceActivator.TypeOf(typeof(IWorkflowInstance))))
			{
				CheckForWorkflowInstance(items);
			}
		}
	}

	public override Guid GetQuestionActionUid(Guid objectUid)
	{
		//Discarded unreachable code: IL_0039
		int num = 4;
		int num2 = num;
		Guid guid = default(Guid);
		Type typeByUidOrNull = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				guid = InterfaceActivator.UID<IWorkflowInstance>();
				num2 = 5;
				break;
			case 2:
				return WorkflowInstanceActions.AddQuestionGuid;
			case 1:
				return Guid.Empty;
			case 5:
				if (!zXQpt1OciIKkfwwERRKn(objectUid, guid))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (!typeByUidOrNull.IsSubclassOf(HN54ByOcIIl6HCQCN07A(Locator.GetServiceNotNull<IMetadataRuntimeService>(), guid, true)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override List<Guid> QuestionSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<IWorkflowInstance>() };
	}

	public override bool QuestionIsSupported(Guid objectUid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				return mJQNXJOcrTVRNOrJsJpM(this, objectUid);
			case 2:
				if (!zXQpt1OciIKkfwwERRKn(InterfaceActivator.UID<IWorkflowInstance>(), objectUid))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override string GetQuestionSubject(IEntity target)
	{
		//Discarded unreachable code: IL_0084
		int num = 2;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (workflowInstance != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return (string)XHdo98OceGy8N57HvF3K(this, target);
			default:
				return workflowInstance.Name;
			case 2:
				workflowInstance = target as IWorkflowInstance;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && QuestionIsSupported(objectUid))
		{
			CheckForWorkflowInstance(items);
		}
	}

	public FeedCommentWorkflowInstanceExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PG374xOcNFMGCGsJ3JhB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type kaSybaOcFV7H7I3hfjcj(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUidOrNull(P_1, P_2);
	}

	internal static bool zXQpt1OciIKkfwwERRKn(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Type HN54ByOcIIl6HCQCN07A(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static Guid t2e8DmOcapwsoPbMOla5()
	{
		return WorkflowInstanceActions.AddCommentGuid;
	}

	internal static bool H1T8CNOc2hVv1gIqh2E9()
	{
		return bJw5M7Oc7N1YRF7dnLdt == null;
	}

	internal static FeedCommentWorkflowInstanceExtension bxQ99yOcoCE61pdchas3()
	{
		return bJw5M7Oc7N1YRF7dnLdt;
	}

	internal static bool mJQNXJOcrTVRNOrJsJpM(object P_0, Guid P_1)
	{
		return ((BaseFeedPostExtension)P_0).QuestionIsSupported(P_1);
	}

	internal static object XHdo98OceGy8N57HvF3K(object P_0, object P_1)
	{
		return ((BaseFeedPostExtension)P_0).GetQuestionSubject((IEntity)P_1);
	}

	internal static void PG374xOcNFMGCGsJ3JhB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}

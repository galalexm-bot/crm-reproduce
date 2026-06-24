using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowMessageTypeManager : EntityManager<IWorkflowMessageType, long>
{
	private class MessageTypeSearchResult
	{
		private static object h3A4Q9nGEArka3itYem;

		public long ProcessId
		{
			[CompilerGenerated]
			get
			{
				return _003CProcessId_003Ek__BackingField;
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
						_003CProcessId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public WorkflowDiagram Diagram
		{
			[CompilerGenerated]
			get
			{
				return _003CDiagram_003Ek__BackingField;
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
						_003CDiagram_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public MessageTypeSearchResult()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool OnfNWtnnS7YpU0qosbA()
		{
			return h3A4Q9nGEArka3itYem == null;
		}

		internal static MessageTypeSearchResult ftEfjXnypkqE4S5STvL()
		{
			return (MessageTypeSearchResult)h3A4Q9nGEArka3itYem;
		}
	}

	internal static WorkflowMessageTypeManager nDt62eDdf4tEw9dTIk5;

	public virtual List<long> Search(long msgTypeId, bool inPublished, bool inDrafts, bool inOld)
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.msgType = Load(msgTypeId);
		if (CS_0024_003C_003E8__locals0.msgType == null)
		{
			return new List<long>();
		}
		ICriteria obj = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IWorkflowProcess>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-897645572 ^ -897624494)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--286570904 ^ 0x1114EC2E), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1947292726 ^ -1947271668), (JoinType)0);
		Disjunction val = Restrictions.Disjunction();
		if (inPublished)
		{
			((Junction)val).Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x29333BA9), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C24A7A)));
		}
		if (inDrafts)
		{
			((Junction)val).Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1774307336 ^ -1774296572), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1060279669 ^ 0x3F32C09B)));
		}
		if (inOld)
		{
			AbstractCriterion val2 = Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66914DC5 ^ 0x66911BD3), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30486385));
			AbstractCriterion obj2;
			if (!AbstractCriterion.op_False(val2))
			{
				AbstractCriterion val3 = Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-474638327 ^ -474624551), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C817E00 ^ 0x2C812BEE));
				obj2 = val2 & !(val3 ? val3 : (val3 | Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2B6686C0 ^ 0x2B66D33C), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481975759))));
			}
			else
			{
				obj2 = val2;
			}
			((Junction)val).Add((ICriterion)(object)obj2);
		}
		obj.Add((ICriterion)(object)val);
		return (from item in obj.SetProjection((IProjection[])(object)new IProjection[2]
			{
				Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-802458460 ^ -802479798)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-465190147 ^ -465201983)),
				Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1015538293 ^ -1015526439)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x29333813))
			}).SetResultTransformer((IResultTransformer)new AliasToBeanResultTransformer(typeof(MessageTypeSearchResult))).List<MessageTypeSearchResult>()
			where (from elem in ((Diagram)_003C_003Ec__DisplayClass1_0.ywj9jMnBC60YmiEfbi5(item)).Elements.OfType<MessageElement>()
				where _003C_003Ec__DisplayClass1_0.RmhEfhnWjDdevdCJ6xL(elem, CS_0024_003C_003E8__locals0.msgType.Uid)
				select elem).Any()
			select item.ProcessId).ToList();
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
				type = InterfaceActivator.TypeOf<IWorkflowMessageType>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			DQlBY9DkwMNrqidbK0r(exportRule, type);
			kTUYyuDUFmmjQRvfiKJ(exportRule, q0kHM5DbW0QgWyr1bcd(0x19163E7B ^ 0x19166C17));
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			DQlBY9DkwMNrqidbK0r(exportRule2, type);
			kTUYyuDUFmmjQRvfiKJ(exportRule2, q0kHM5DbW0QgWyr1bcd(0x48FEDADC ^ 0x48FE8CA0));
			Ud0TUVDmyTuQnHJmhc2(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			exportRuleList.Add(new ExportRule
			{
				ParentType = type,
				PropertyName = (string)q0kHM5DbW0QgWyr1bcd(-1941486619 ^ -1941498515),
				ExportRuleType = ExportRuleType.Export
			});
			ExportRule exportRule3 = new ExportRule();
			DQlBY9DkwMNrqidbK0r(exportRule3, type);
			kTUYyuDUFmmjQRvfiKJ(exportRule3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-732058802 ^ -732039012));
			Ud0TUVDmyTuQnHJmhc2(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			return exportRuleList;
		}
	}

	public WorkflowMessageTypeManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Bfek9NDAxgJIHvYNS1f();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void DQlBY9DkwMNrqidbK0r(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static object q0kHM5DbW0QgWyr1bcd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void kTUYyuDUFmmjQRvfiKJ(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void Ud0TUVDmyTuQnHJmhc2(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static bool iXcN4YDjhQTl1iu5q5X()
	{
		return nDt62eDdf4tEw9dTIk5 == null;
	}

	internal static WorkflowMessageTypeManager muNvgrDSE5quWICWHRg()
	{
		return nDt62eDdf4tEw9dTIk5;
	}

	internal static void Bfek9NDAxgJIHvYNS1f()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}

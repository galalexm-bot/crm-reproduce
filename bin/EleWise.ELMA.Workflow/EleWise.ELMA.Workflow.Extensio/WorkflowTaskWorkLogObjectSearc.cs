using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
public class WorkflowTaskWorkLogObjectSearchExtension : WorkLogObjectSearchExtensionBase
{
	internal static WorkflowTaskWorkLogObjectSearchExtension iUnt2IIcExdbT4VEaaH;

	public override Guid Uid => new Guid((string)nM6XlYId70vHjD9guaI(0x12F686A ^ 0x12E3908));

	public override Type BaseObjectType => l1UZDWIuEcIeZbdjuem(typeof(IWorkflowTaskBase).TypeHandle);

	protected override void Init()
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
			{
				ParameterExpression parameterExpression = (ParameterExpression)Ss7vx2ID8G2Xx0MwplX(l1UZDWIuEcIeZbdjuem(typeof(IWorkflowTaskWorkLogObjectSearchFilter).TypeHandle), nM6XlYId70vHjD9guaI(0x70EBB9F3 ^ 0x70EAA5DD));
				AddProperty(Expression.Lambda<Func<IWorkflowTaskWorkLogObjectSearchFilter, object>>((Expression)t4F0iTIH0PgskvBoC2b(parameterExpression, (MethodInfo)KX7gScIn2NLiAXqyNH7((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public override void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
		//Discarded unreachable code: IL_00ca, IL_00d9
		int num = 5;
		int num2 = num;
		IWorkflowTaskWorkLogObjectSearchFilter workflowTaskWorkLogObjectSearchFilter = default(IWorkflowTaskWorkLogObjectSearchFilter);
		while (true)
		{
			switch (num2)
			{
			case 4:
				workflowTaskWorkLogObjectSearchFilter = filter as IWorkflowTaskWorkLogObjectSearchFilter;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				return;
			case 2:
				return;
			case 3:
				return;
			case 5:
				IAyJTZILEeu3gfmttVP(this, criteria, filter);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 4;
				}
				continue;
			case 6:
				if (workflowTaskWorkLogObjectSearchFilter != null)
				{
					if (workflowTaskWorkLogObjectSearchFilter.ProcessHeaders == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			lCoNHOIWxsQpvyAqSBp(Bbe5EQIfl2umu7S3xeu(Bbe5EQIfl2umu7S3xeu(Bbe5EQIfl2umu7S3xeu(Bbe5EQIfl2umu7S3xeu(criteria, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F0250), nM6XlYId70vHjD9guaI(0x1134D2C0 ^ 0x1134B356), (JoinType)0), nM6XlYId70vHjD9guaI(0x75BAD659 ^ 0x75BA6181), nM6XlYId70vHjD9guaI(--1212129906 ^ 0x483FC3DA), (JoinType)0), nM6XlYId70vHjD9guaI(0x1927DA93 ^ 0x1927635B), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657539129), (JoinType)0), nM6XlYId70vHjD9guaI(-708128192 ^ -708154452), nM6XlYId70vHjD9guaI(-135674354 ^ -135680208), (JoinType)0), rgwMHII9W9kRta5Re98(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A6397C), workflowTaskWorkLogObjectSearchFilter.ProcessHeaders.Select((IProcessHeader e) => e.Id).ToArray()));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
			{
				num2 = 2;
			}
		}
	}

	public WorkflowTaskWorkLogObjectSearchExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SOC7q4Ijk3DkEf4tw6v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object nM6XlYId70vHjD9guaI(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QHv2ALIP7TZAjQH0nux()
	{
		return iUnt2IIcExdbT4VEaaH == null;
	}

	internal static WorkflowTaskWorkLogObjectSearchExtension fwvGKvIXjKWYUHuby2G()
	{
		return iUnt2IIcExdbT4VEaaH;
	}

	internal static Type l1UZDWIuEcIeZbdjuem(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Ss7vx2ID8G2Xx0MwplX(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object KX7gScIn2NLiAXqyNH7(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object t4F0iTIH0PgskvBoC2b(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void IAyJTZILEeu3gfmttVP(object P_0, object P_1, object P_2)
	{
		((WorkLogObjectSearchExtensionBase)P_0).SetupCriteria((ICriteria)P_1, (IWorkLogObjectSearchFilter)P_2);
	}

	internal static object Bbe5EQIfl2umu7S3xeu(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object rgwMHII9W9kRta5Re98(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object lCoNHOIWxsQpvyAqSBp(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void SOC7q4Ijk3DkEf4tw6v()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}

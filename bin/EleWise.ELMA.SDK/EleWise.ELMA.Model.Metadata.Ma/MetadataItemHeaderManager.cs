using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

public class MetadataItemHeaderManager : EntityManager<IMetadataItemHeader, long>
{
	private readonly string uidFiledName;

	internal static MetadataItemHeaderManager tZIskLhF070OHhBNFgcH;

	public virtual IEnumerable<IMetadataItemHeader> Load(IEnumerable<Guid> uids)
	{
		Contract.ArgumentNotNull(uids, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867000999));
		return CreateCriteria().Add((ICriterion)(object)Restrictions.In(uidFiledName, (ICollection)uids.ToArray())).List<IMetadataItemHeader>();
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
				type = InterfaceActivator.TypeOf<IMetadataItemHeader>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule, type);
			QGwkWPhFJNAag37WOR8u(exportRule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822813958));
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule2, type);
			QGwkWPhFJNAag37WOR8u(exportRule2, Mwd54fhF9RZxE7CCBei1(-951514650 ^ -951559096));
			gFmS4VhFdnnHFYX87wjB(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule3, type);
			QGwkWPhFJNAag37WOR8u(exportRule3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70233352));
			gFmS4VhFdnnHFYX87wjB(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule4, type);
			QGwkWPhFJNAag37WOR8u(exportRule4, Mwd54fhF9RZxE7CCBei1(-1837662597 ^ -1837791025));
			gFmS4VhFdnnHFYX87wjB(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule5, type);
			QGwkWPhFJNAag37WOR8u(exportRule5, Mwd54fhF9RZxE7CCBei1(0x1DE3DD89 ^ 0x1DE30F4B));
			exportRule5.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule6, type);
			QGwkWPhFJNAag37WOR8u(exportRule6, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97907524));
			exportRule6.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule6);
			ExportRule exportRule7 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule7, type);
			QGwkWPhFJNAag37WOR8u(exportRule7, Mwd54fhF9RZxE7CCBei1(-105199646 ^ -105204702));
			exportRule7.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule7);
			ExportRule exportRule8 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule8, type);
			exportRule8.PropertyName = (string)Mwd54fhF9RZxE7CCBei1(0x1637C429 ^ 0x1635BAB3);
			gFmS4VhFdnnHFYX87wjB(exportRule8, ExportRuleType.Export);
			exportRuleList.Add(exportRule8);
			ExportRule exportRule9 = new ExportRule();
			zPtjLMhFM0E76d6aoY82(exportRule9, type);
			exportRule9.PropertyName = (string)Mwd54fhF9RZxE7CCBei1(-2112703338 ^ -2112771694);
			gFmS4VhFdnnHFYX87wjB(exportRule9, ExportRuleType.Export);
			exportRuleList.Add(exportRule9);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			QGwkWPhFJNAag37WOR8u(obj, Mwd54fhF9RZxE7CCBei1(0x269E5FCA ^ 0x269E3058));
			gFmS4VhFdnnHFYX87wjB(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			return exportRuleList;
		}
	}

	public MetadataItemHeaderManager()
	{
		//Discarded unreachable code: IL_0090, IL_0095
		SingletonReader.JJCZtPuTvSt();
		ParameterExpression parameterExpression = (ParameterExpression)m85rkhhFrrDXicp1pWNr(r6JvInhFlqHcArnMMyYa(typeof(IMetadataItemHeader).TypeHandle), Mwd54fhF9RZxE7CCBei1(-606654180 ^ -606626392));
		uidFiledName = LinqUtils.NameOf(Expression.Lambda<Func<IMetadataItemHeader, object>>(Expression.Convert((Expression)IpCOs5hF5jW7mCDE5Fps(parameterExpression, (MethodInfo)iRpwcBhFg21FZ57IGGbN((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), r6JvInhFlqHcArnMMyYa(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void zPtjLMhFM0E76d6aoY82(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static void QGwkWPhFJNAag37WOR8u(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static object Mwd54fhF9RZxE7CCBei1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gFmS4VhFdnnHFYX87wjB(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static bool jPqnhbhFmOCO6pTlJuZr()
	{
		return tZIskLhF070OHhBNFgcH == null;
	}

	internal static MetadataItemHeaderManager W5ye0PhFyQ9m332YmHW0()
	{
		return tZIskLhF070OHhBNFgcH;
	}

	internal static Type r6JvInhFlqHcArnMMyYa(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object m85rkhhFrrDXicp1pWNr(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object iRpwcBhFg21FZ57IGGbN(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object IpCOs5hF5jW7mCDE5Fps(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}

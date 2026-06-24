using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

public class MetadataItemGroupManager : EntityManager<IMetadataItemGroup, long>
{
	internal static MetadataItemGroupManager bF1dflhFXhemjl6faMYd;

	public new static MetadataItemGroupManager Instance => Locator.GetServiceNotNull<MetadataItemGroupManager>();

	[Transaction]
	[PublicApiMember]
	public override void Delete(IMetadataItemGroup group)
	{
		//Discarded unreachable code: IL_00ff, IL_010e, IL_0119, IL_01b7, IL_01e7, IL_01f6, IL_0202, IL_0229, IL_0238, IL_0243, IL_02d1, IL_0311, IL_0320, IL_032c
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IEnumerator<IMetadataItemGroup> enumerator = default(IEnumerator<IMetadataItemGroup>);
		IEnumerator<IMetadataItemHeader> enumerator2 = default(IEnumerator<IMetadataItemHeader>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass2_.group = group;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 7;
				}
				break;
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)Sko4tahFeLlNSoIjsmXr(sbZQjBhF2ad3XQovf7Pp(typeof(IMetadataItemGroup).TypeHandle), oJOYu6hFn6xWBW3T1pHd(-398663332 ^ -398715172));
				enumerator = ((AbstractNHEntityManager<IMetadataItemGroup, long>)this).Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression)BcgFZthFpvmZt98fJJPe(rBBY4dhF1psmeowm68Q5(parameterExpression, (MethodInfo)GaNxx0hFPHRDqh4flgyk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), jNg0g2hF3kaIql9Ic1OS(kRR7ighFN8jgrxaKVqUB(_003C_003Ec__DisplayClass2_, sbZQjBhF2ad3XQovf7Pp(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 4;
				}
				break;
			}
			case 4:
				try
				{
					while (true)
					{
						int num5;
						if (!nLeZoxhFt8U3axbhH9MV(enumerator))
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num5 = 0;
							}
							goto IL_011d;
						}
						goto IL_0159;
						IL_0159:
						IMetadataItemGroup current2 = enumerator.Current;
						current2.Parent = (IMetadataItemGroup)ftKDCYhFatWEj9vNOFc4(_003C_003Ec__DisplayClass2_.group);
						UwLyZThFDfvP0ymnuxVI(current2);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num5 = 2;
						}
						goto IL_011d;
						IL_011d:
						switch (num5)
						{
						case 2:
							break;
						default:
							goto IL_0159;
						case 1:
							goto end_IL_0133;
						}
						continue;
						end_IL_0133:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num6 = 0;
						}
						goto IL_01bb;
					}
					goto IL_01d1;
					IL_01d1:
					WvlxNnhFw4EtTNmSfshu(enumerator);
					num6 = 2;
					goto IL_01bb;
					IL_01bb:
					switch (num6)
					{
					case 1:
						goto end_IL_0196;
					case 2:
						goto end_IL_0196;
					}
					goto IL_01d1;
					end_IL_0196:;
				}
				goto case 6;
			default:
				base.Delete(_003C_003Ec__DisplayClass2_.group);
				num2 = 3;
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!nLeZoxhFt8U3axbhH9MV(enumerator2))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 0;
							}
							goto IL_0247;
						}
						goto IL_0283;
						IL_0283:
						IMetadataItemHeader current = enumerator2.Current;
						U7EUgRhF6tZ5Fen57UVc(current, ftKDCYhFatWEj9vNOFc4(_003C_003Ec__DisplayClass2_.group));
						UwLyZThFDfvP0ymnuxVI(current);
						num3 = 2;
						goto IL_0247;
						IL_0247:
						switch (num3)
						{
						case 2:
							continue;
						case 1:
							goto IL_0283;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator2 == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num4 = 0;
						}
						goto IL_02d5;
					}
					goto IL_02eb;
					IL_02eb:
					enumerator2.Dispose();
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num4 = 1;
					}
					goto IL_02d5;
					IL_02d5:
					switch (num4)
					{
					default:
						goto end_IL_02b0;
					case 1:
						break;
					case 0:
						goto end_IL_02b0;
					case 2:
						goto end_IL_02b0;
					}
					goto IL_02eb;
					end_IL_02b0:;
				}
				goto case 5;
			case 3:
				return;
			case 9:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 8;
				break;
			case 5:
				HtOSVOhFHiIsS2Hnqy1F(base.Session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				IEntityManager<IMetadataItemHeader> instance = EntityManager<IMetadataItemHeader>.Instance;
				ParameterExpression parameterExpression = (ParameterExpression)Sko4tahFeLlNSoIjsmXr(typeof(IMetadataItemHeader), oJOYu6hFn6xWBW3T1pHd(0x48A7E34A ^ 0x48A74FFE));
				enumerator2 = instance.Find(Expression.Lambda<Func<IMetadataItemHeader, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)GaNxx0hFPHRDqh4flgyk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)kRR7ighFN8jgrxaKVqUB(_003C_003Ec__DisplayClass2_, sbZQjBhF2ad3XQovf7Pp(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), (FieldInfo)zC9ASvhF4aWWxitObtow((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
				num2 = 2;
				break;
			}
			case 7:
				yKpDlDhFOv0f5rwPMA5h(_003C_003Ec__DisplayClass2_.group, oJOYu6hFn6xWBW3T1pHd(-2138958856 ^ -2138905678));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
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
				type = InterfaceActivator.TypeOf<IMetadataItemGroup>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule, type);
			MIVuJThF7SeerO6a1B2y(exportRule, oJOYu6hFn6xWBW3T1pHd(-957824448 ^ -957729630));
			w6y8XthFxcP3K5ygyksV(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule2, type);
			MIVuJThF7SeerO6a1B2y(exportRule2, oJOYu6hFn6xWBW3T1pHd(-281842504 ^ -281921258));
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			MIVuJThF7SeerO6a1B2y(obj, oJOYu6hFn6xWBW3T1pHd(0x1ECE530A ^ 0x1ECCA5BE));
			w6y8XthFxcP3K5ygyksV(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule3 = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule3, type);
			MIVuJThF7SeerO6a1B2y(exportRule3, oJOYu6hFn6xWBW3T1pHd(-138018305 ^ -138086607));
			w6y8XthFxcP3K5ygyksV(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule4, type);
			MIVuJThF7SeerO6a1B2y(exportRule4, oJOYu6hFn6xWBW3T1pHd(0x5A4C7B29 ^ 0x5A4C08E9));
			w6y8XthFxcP3K5ygyksV(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule5, type);
			MIVuJThF7SeerO6a1B2y(exportRule5, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335092669));
			w6y8XthFxcP3K5ygyksV(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			MIVuJThF7SeerO6a1B2y(obj2, oJOYu6hFn6xWBW3T1pHd(-740338220 ^ -740309534));
			w6y8XthFxcP3K5ygyksV(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule exportRule6 = new ExportRule();
			Pq4rbohFACTRtIegdx1i(exportRule6, type);
			MIVuJThF7SeerO6a1B2y(exportRule6, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EC838));
			w6y8XthFxcP3K5ygyksV(exportRule6, ExportRuleType.Export);
			exportRuleList.Add(exportRule6);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			MIVuJThF7SeerO6a1B2y(obj3, oJOYu6hFn6xWBW3T1pHd(-281842504 ^ -281869526));
			w6y8XthFxcP3K5ygyksV(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			return exportRuleList;
		}
	}

	public MetadataItemGroupManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object oJOYu6hFn6xWBW3T1pHd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void yKpDlDhFOv0f5rwPMA5h(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type sbZQjBhF2ad3XQovf7Pp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Sko4tahFeLlNSoIjsmXr(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object GaNxx0hFPHRDqh4flgyk(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object rBBY4dhF1psmeowm68Q5(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object kRR7ighFN8jgrxaKVqUB(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object jNg0g2hF3kaIql9Ic1OS(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object BcgFZthFpvmZt98fJJPe(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object ftKDCYhFatWEj9vNOFc4(object P_0)
	{
		return ((IMetadataItemGroup)P_0).Parent;
	}

	internal static void UwLyZThFDfvP0ymnuxVI(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool nLeZoxhFt8U3axbhH9MV(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void WvlxNnhFw4EtTNmSfshu(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object zC9ASvhF4aWWxitObtow(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static void U7EUgRhF6tZ5Fen57UVc(object P_0, object P_1)
	{
		((IMetadataItemHeader)P_0).Group = (IMetadataItemGroup)P_1;
	}

	internal static void HtOSVOhFHiIsS2Hnqy1F(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static bool bDntqZhFTcXQKeceZnAL()
	{
		return bF1dflhFXhemjl6faMYd == null;
	}

	internal static MetadataItemGroupManager xxjxDMhFkx0iwMQ0kTKQ()
	{
		return bF1dflhFXhemjl6faMYd;
	}

	internal static void Pq4rbohFACTRtIegdx1i(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static void MIVuJThF7SeerO6a1B2y(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void w6y8XthFxcP3K5ygyksV(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

public class FormMetadataItemGroupManager : EntityManager<IFormMetadataItemGroup, long>
{
	private static FormMetadataItemGroupManager YPgqpHBC5oHTc3pZts5k;

	public IEnumerable<IFormMetadataItemGroup> LoadRootGroups(Guid metadataType)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A61C2DA), (object)metadataType)).Add((ICriterion)(object)Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x724792BC))).List<IFormMetadataItemGroup>();
	}

	[Transaction]
	public virtual void Delete(long groupId)
	{
		int num = 1;
		int num2 = num;
		IFormMetadataItemGroup formMetadataItemGroup = default(IFormMetadataItemGroup);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				formMetadataItemGroup = LoadOrNull(groupId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			}
			if (formMetadataItemGroup != null)
			{
				Delete(formMetadataItemGroup);
				num2 = 3;
				continue;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num2 = 2;
			}
		}
	}

	public override void Delete(IFormMetadataItemGroup group)
	{
		//Discarded unreachable code: IL_01d4, IL_01e3, IL_01ee, IL_026c, IL_028b, IL_029a, IL_02c7, IL_02d7, IL_02e6, IL_02f1, IL_038f, IL_03ae, IL_03de
		int num = 3;
		int num2 = num;
		IEnumerator<IFormMetadataItemGroup> enumerator2 = default(IEnumerator<IFormMetadataItemGroup>);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IFormMetadataItemHeaderFilter formMetadataItemHeaderFilter = default(IFormMetadataItemHeaderFilter);
		IEnumerator<IFormMetadataItemHeader> enumerator = default(IEnumerator<IFormMetadataItemHeader>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 10:
			{
				ParameterExpression parameterExpression = Expression.Parameter(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), (string)DCVVvrBCs6AnqESSw2lv(0x7459E02 ^ 0x7456982));
				enumerator2 = ((AbstractNHEntityManager<IFormMetadataItemGroup, long>)this).Find(Expression.Lambda<Func<IFormMetadataItemGroup, bool>>((Expression)DZw7LrBvW0NVZWOH1bty(geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), X8lF5aBvB4LwMpgRM9Eg(Expression.Constant(_003C_003Ec__DisplayClass2_, gvd7BgBCU7Hef6sGY2we(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), qIJNMjBvFSOrsGSEVBC6((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
				num2 = 11;
				break;
			}
			case 3:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				base.Delete(_003C_003Ec__DisplayClass2_.group);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				umsxnSBvGEtuC3pZrJLJ(formMetadataItemHeaderFilter, _003C_003Ec__DisplayClass2_.group);
				num2 = 5;
				break;
			case 5:
				xRxwIwBvE8VmDyOoJQNg(formMetadataItemHeaderFilter, true);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				formMetadataItemHeaderFilter = InterfaceActivator.Create<IFormMetadataItemHeaderFilter>();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 9;
				}
				break;
			case 6:
				enumerator = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().Find(formMetadataItemHeaderFilter, null).GetEnumerator();
				num2 = 8;
				break;
			default:
				TMq4jpBCLCqdbIGH0fYs(_003C_003Ec__DisplayClass2_.group, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765814944));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 7;
				}
				break;
			case 11:
				try
				{
					while (true)
					{
						int num5;
						if (!o3idqfBvbp7CQhmXIpG8(enumerator2))
						{
							num5 = 2;
							goto IL_01f2;
						}
						goto IL_021e;
						IL_01f2:
						switch (num5)
						{
						case 1:
							break;
						default:
							goto IL_021e;
						case 2:
							goto end_IL_0208;
						}
						continue;
						IL_021e:
						IFormMetadataItemGroup current2 = enumerator2.Current;
						caCdkrBvoQMCDVyMCATH(current2, _003C_003Ec__DisplayClass2_.group.Parent);
						current2.Save();
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num5 = 0;
						}
						goto IL_01f2;
						continue;
						end_IL_0208:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator2 == null)
					{
						num6 = 2;
						goto IL_0270;
					}
					goto IL_02a5;
					IL_0270:
					switch (num6)
					{
					default:
						goto end_IL_025b;
					case 2:
						goto end_IL_025b;
					case 1:
						break;
					case 0:
						goto end_IL_025b;
					}
					goto IL_02a5;
					IL_02a5:
					fVswRtBvhX7VIoCMqPnU(enumerator2);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num6 = 0;
					}
					goto IL_0270;
					end_IL_025b:;
				}
				goto case 4;
			case 8:
				try
				{
					while (true)
					{
						int num3;
						if (!o3idqfBvbp7CQhmXIpG8(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num3 = 2;
							}
							goto IL_02f5;
						}
						goto IL_030b;
						IL_030b:
						IFormMetadataItemHeader current = enumerator.Current;
						HZ8qmrBvQCrGeJ6N7KA9(current, PirILkBvfSkT9CrAXfvG(_003C_003Ec__DisplayClass2_.group));
						jOSlh9BvCTY514ZD2VuL(current);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num3 = 0;
						}
						goto IL_02f5;
						IL_02f5:
						switch (num3)
						{
						case 1:
							continue;
						case 2:
							goto end_IL_0343;
						}
						goto IL_030b;
						continue;
						end_IL_0343:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num4 = 1;
						}
						goto IL_0393;
					}
					goto IL_03bc;
					IL_03bc:
					fVswRtBvhX7VIoCMqPnU(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num4 = 0;
					}
					goto IL_0393;
					IL_0393:
					switch (num4)
					{
					default:
						goto end_IL_036e;
					case 1:
						goto end_IL_036e;
					case 2:
						break;
					case 0:
						goto end_IL_036e;
					}
					goto IL_03bc;
					end_IL_036e:;
				}
				goto case 7;
			case 2:
				_003C_003Ec__DisplayClass2_.group = group;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 4;
		int num2 = num;
		ExportRuleList exportRuleList = default(ExportRuleList);
		Type value = default(Type);
		while (true)
		{
			ExportRule exportRule;
			ParameterExpression parameterExpression;
			switch (num2)
			{
			case 1:
			{
				ExportRuleList exportRuleList6 = exportRuleList;
				exportRule = new ExportRule();
				VPn4njBv8KSAOtkJU0AX(exportRule, value);
				ExportRule exportRule6 = exportRule;
				parameterExpression = Expression.Parameter(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), (string)DCVVvrBCs6AnqESSw2lv(0x26FFCB59 ^ 0x26FF3CD9));
				RFypMlBvuHdnkJuBBbfy(exportRule6, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>((Expression)geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				OALLmLBvIkY2g0CiEnBN(exportRule, ExportRuleType.Ignore);
				exportRuleList6.Add(exportRule);
				num2 = 7;
				continue;
			}
			case 8:
			{
				ExportRuleList exportRuleList3 = exportRuleList;
				exportRule = new ExportRule();
				VPn4njBv8KSAOtkJU0AX(exportRule, value);
				ExportRule exportRule3 = exportRule;
				parameterExpression = (ParameterExpression)zdJXeQBvZEB9KGUtqgAH(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), DCVVvrBCs6AnqESSw2lv(-606654180 ^ -606615908));
				RFypMlBvuHdnkJuBBbfy(exportRule3, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>((Expression)geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				exportRule.ExportRuleType = ExportRuleType.Export;
				exportRuleList3.Add(exportRule);
				num2 = 5;
				continue;
			}
			case 7:
			{
				ExportRuleList exportRuleList2 = exportRuleList;
				exportRule = new ExportRule();
				VPn4njBv8KSAOtkJU0AX(exportRule, value);
				ExportRule exportRule2 = exportRule;
				parameterExpression = (ParameterExpression)zdJXeQBvZEB9KGUtqgAH(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380626B));
				RFypMlBvuHdnkJuBBbfy(exportRule2, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Convert((Expression)geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), gvd7BgBCU7Hef6sGY2we(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				OALLmLBvIkY2g0CiEnBN(exportRule, ExportRuleType.Export);
				exportRuleList2.Add(exportRule);
				num2 = 8;
				continue;
			}
			case 6:
				return exportRuleList;
			case 2:
			{
				ExportRuleList exportRuleList5 = exportRuleList;
				exportRule = new ExportRule();
				VPn4njBv8KSAOtkJU0AX(exportRule, value);
				ExportRule exportRule5 = exportRule;
				parameterExpression = (ParameterExpression)zdJXeQBvZEB9KGUtqgAH(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), DCVVvrBCs6AnqESSw2lv(-281842504 ^ -281830600));
				exportRule5.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Convert((Expression)geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), gvd7BgBCU7Hef6sGY2we(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				exportRule.ExportRuleType = ExportRuleType.Export;
				exportRuleList5.Add(exportRule);
				num2 = 6;
				continue;
			}
			case 5:
			{
				ExportRuleList exportRuleList4 = exportRuleList;
				exportRule = new ExportRule();
				VPn4njBv8KSAOtkJU0AX(exportRule, value);
				ExportRule exportRule4 = exportRule;
				parameterExpression = (ParameterExpression)zdJXeQBvZEB9KGUtqgAH(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), DCVVvrBCs6AnqESSw2lv(--1867379187 ^ 0x6F4D0673));
				exportRule4.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>((Expression)geDJiKBCzy7rPJWgQDXA(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				OALLmLBvIkY2g0CiEnBN(exportRule, ExportRuleType.Export);
				exportRuleList4.Add(exportRule);
				num2 = 2;
				continue;
			}
			case 4:
				value = O73TOsBvvB6oKZgv9TPj(this);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
				exportRuleList = new ExportRuleList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList7 = exportRuleList;
			exportRule = new ExportRule();
			VPn4njBv8KSAOtkJU0AX(exportRule, value);
			ExportRule exportRule7 = exportRule;
			parameterExpression = (ParameterExpression)zdJXeQBvZEB9KGUtqgAH(gvd7BgBCU7Hef6sGY2we(typeof(IFormMetadataItemGroup).TypeHandle), DCVVvrBCs6AnqESSw2lv(-1123633026 ^ -1123659778));
			RFypMlBvuHdnkJuBBbfy(exportRule7, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Property(parameterExpression, (MethodInfo)umOT8JBCcWImwXBTsrWn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
			OALLmLBvIkY2g0CiEnBN(exportRule, ExportRuleType.Ignore);
			exportRuleList7.Add(exportRule);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
			{
				num2 = 0;
			}
		}
	}

	internal IEnumerable<FormMetadataItemGroupDTO> LoadGroupDTOList(Guid metadataType, long? parentId)
	{
		ICriteria obj = CreateCriteria();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47854B8D));
		ICriteria obj2 = obj.Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })), (object)metadataType));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D230E));
		ICriteria val = obj2.CreateAlias(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A814E32), (JoinType)1);
		if (parentId.HasValue)
		{
			val = val.Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921240997), (object)parentId.Value));
		}
		ICriteria obj3 = val;
		IProjection[] array = new IProjection[4];
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583780492));
		PropertyProjection obj4 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420806490));
		array[0] = Projections.Alias((IProjection)(object)obj4, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemGroupDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityDTO<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957860416));
		PropertyProjection obj5 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E6851));
		array[1] = Projections.Alias((IProjection)(object)obj5, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemGroupDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		PropertyProjection obj6 = Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103F1EED));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218434002));
		array[2] = Projections.Alias((IProjection)(object)obj6, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemGroupDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234346352));
		PropertyProjection obj7 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemGroup, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234346352));
		array[3] = Projections.Alias((IProjection)(object)obj7, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemGroupDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		return obj3.SetProjection((IProjection[])(object)array).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FormMetadataItemGroupDTO))).List<FormMetadataItemGroupDTO>();
	}

	public FormMetadataItemGroupManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j74hZRBvVnCGnTe1eAi4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AeatEUBCjHLiGW08FC0R()
	{
		return YPgqpHBC5oHTc3pZts5k == null;
	}

	internal static FormMetadataItemGroupManager dhBb70BCY7pxUwAmOee2()
	{
		return YPgqpHBC5oHTc3pZts5k;
	}

	internal static void TMq4jpBCLCqdbIGH0fYs(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type gvd7BgBCU7Hef6sGY2we(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object DCVVvrBCs6AnqESSw2lv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object umOT8JBCcWImwXBTsrWn(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object geDJiKBCzy7rPJWgQDXA(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object qIJNMjBvFSOrsGSEVBC6(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object X8lF5aBvB4LwMpgRM9Eg(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object DZw7LrBvW0NVZWOH1bty(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static void caCdkrBvoQMCDVyMCATH(object P_0, object P_1)
	{
		((IFormMetadataItemGroup)P_0).Parent = (IFormMetadataItemGroup)P_1;
	}

	internal static bool o3idqfBvbp7CQhmXIpG8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void fVswRtBvhX7VIoCMqPnU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void umsxnSBvGEtuC3pZrJLJ(object P_0, object P_1)
	{
		((IFormMetadataItemHeaderFilter)P_0).Group = (IFormMetadataItemGroup)P_1;
	}

	internal static void xRxwIwBvE8VmDyOoJQNg(object P_0, bool value)
	{
		((IEntityFilter)P_0).DisableSoftDeletable = value;
	}

	internal static object PirILkBvfSkT9CrAXfvG(object P_0)
	{
		return ((IFormMetadataItemGroup)P_0).Parent;
	}

	internal static void HZ8qmrBvQCrGeJ6N7KA9(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).Group = (IFormMetadataItemGroup)P_1;
	}

	internal static void jOSlh9BvCTY514ZD2VuL(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Type O73TOsBvvB6oKZgv9TPj(object P_0)
	{
		return ((EntityManager<IFormMetadataItemGroup, long>)P_0).ImplementationType;
	}

	internal static void VPn4njBv8KSAOtkJU0AX(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static object zdJXeQBvZEB9KGUtqgAH(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static void RFypMlBvuHdnkJuBBbfy(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void OALLmLBvIkY2g0CiEnBN(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static void j74hZRBvVnCGnTe1eAi4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

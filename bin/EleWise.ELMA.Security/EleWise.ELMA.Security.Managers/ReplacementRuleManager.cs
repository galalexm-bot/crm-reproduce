using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ReplacementRuleManager : EntityManager<IReplacementRule, long>
{
	private IEnumerable<IReplacementRuleExtension> replacementRuleExtensions;

	private Func<Guid, IEnumerable<PropertyMetadata>> getReplaceableProperties;

	private static ReplacementRuleManager UCnkAeEN0YwO6Io8aWg;

	public new static ReplacementRuleManager Instance => Locator.GetServiceNotNull<ReplacementRuleManager>();

	private IEnumerable<IReplacementRuleExtension> ReplacementRules()
	{
		return replacementRuleExtensions ?? (replacementRuleExtensions = ComponentManager.Current.GetExtensionPoints<IReplacementRuleExtension>());
	}

	[Transaction]
	public virtual void CreateDefaultRules(IReplacement replacement)
	{
		//Discarded unreachable code: IL_011f, IL_012e, IL_01aa, IL_01b9, IL_01c4, IL_0268, IL_0298, IL_02a7, IL_02b3
		int num = 13;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		IEnumerator<IReplacementRule> enumerator = default(IEnumerator<IReplacementRule>);
		IReplacementRuleFilter replacementRuleFilter = default(IReplacementRuleFilter);
		IReplacement replacement3 = default(IReplacement);
		Func<ReplacementStatus, IReplacement> func = default(Func<ReplacementStatus, IReplacement>);
		while (true)
		{
			IReplacement replacement2;
			switch (num2)
			{
			case 13:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 10;
				}
				continue;
			case 2:
				return;
			case 6:
				return;
			case 1:
				return;
			case 3:
				enumerator = Find(replacementRuleFilter, (FetchOptions)Be6a8LEuCKNhaaXBBWi()).GetEnumerator();
				num2 = 9;
				continue;
			case 4:
				if (replacement3 != null)
				{
					replacementRuleFilter = InterfaceActivator.Create<IReplacementRuleFilter>();
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num2 = 10;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 5:
				return;
			case 11:
				replacement2 = func(ReplacementStatus.Active);
				if (replacement2 == null)
				{
					num2 = 7;
					continue;
				}
				break;
			case 12:
				_003C_003Ec__DisplayClass4_.replacement = replacement;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
				{
					num2 = 8;
				}
				continue;
			case 8:
				if (_003C_003Ec__DisplayClass4_.replacement == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto default;
			case 10:
				kfKsI8EBNhn55clDPPL(replacementRuleFilter, replacement3);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
				{
					num2 = 3;
				}
				continue;
			case 9:
				try
				{
					while (true)
					{
						int num3;
						if (!VTnBmyEepoCKs9o4t7K(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
							{
								num3 = 0;
							}
							goto IL_01c8;
						}
						goto IL_0204;
						IL_0204:
						IReplacementRule replacementRule = CloneHelperBuilder.Create(enumerator.Current).Clone();
						replacementRule.Replacement = _003C_003Ec__DisplayClass4_.replacement;
						EjyN8ZEm7jLplBr33aM(replacementRule);
						num3 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
						{
							num3 = 1;
						}
						goto IL_01c8;
						IL_01c8:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 1:
							goto IL_0204;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
						{
							num4 = 0;
						}
						goto IL_026c;
					}
					goto IL_0282;
					IL_0282:
					Tim2wSELnkcADHlHYkd(enumerator);
					num4 = 2;
					goto IL_026c;
					IL_026c:
					switch (num4)
					{
					default:
						goto end_IL_0247;
					case 1:
						break;
					case 0:
						goto end_IL_0247;
					case 2:
						goto end_IL_0247;
					}
					goto IL_0282;
					end_IL_0247:;
				}
			default:
				if (_003C_003Ec__DisplayClass4_.replacement.IsNew())
				{
					func = _003C_003Ec__DisplayClass4_._003CCreateDefaultRules_003Eb__0;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num2 = 0;
					}
				}
				continue;
			case 7:
				replacement2 = func(ReplacementStatus.Delete);
				break;
			}
			replacement3 = replacement2;
			num2 = 4;
		}
	}

	public EntityMetadata ObjectForProperty(Guid propertyUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass5_.extensions = ReplacementRules();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass5_.propertyUid = propertyUid;
				num2 = 3;
				break;
			default:
				return ((IMetadataService)GAC7kvEjCEIV2YBWYIF(this)).GetMetadataList().OfType<EntityMetadata>().Where(_003C_003Ec__DisplayClass5_._003CObjectForProperty_003Eb__0)
					.FirstOrDefault();
			}
		}
	}

	public List<EntityMetadata> RootRulesObjects()
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.extensions = ReplacementRules();
		return base.MetadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata md)
		{
			int num = 3;
			int num2 = num;
			IReplacementRuleExtension replacementRuleExtension = default(IReplacementRuleExtension);
			_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_1);
			while (true)
			{
				switch (num2)
				{
				default:
					replacementRuleExtension = CS_0024_003C_003E8__locals0.extensions.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CRootRulesObjects_003Eb__1);
					num2 = 4;
					break;
				case 2:
					_003C_003Ec__DisplayClass6_.md = md;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (CS_0024_003C_003E8__locals0._003C_003E4__this.GetPropertiesInnerLogic(_003C_003Ec__DisplayClass6_.md).Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00d6;
				case 4:
					if (replacementRuleExtension == null)
					{
						return false;
					}
					num2 = 5;
					break;
				case 5:
					return _003C_003Ec__DisplayClass6_0.M54h5HpHe9XlgjAZ3QBQ(replacementRuleExtension, _003C_003Ec__DisplayClass6_.md);
				case 3:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_1();
					num2 = 2;
					break;
				case 1:
					{
						if (_003C_003Ec__DisplayClass6_0.CpN3ItpHmFlx913bpi4T(_003C_003Ec__DisplayClass6_.md) != EntityMetadataType.InterfaceImplementation)
						{
							num2 = 6;
							break;
						}
						goto IL_00d6;
					}
					IL_00d6:
					return false;
				}
			}
		})
			.ToList();
	}

	public static List<PropertyMetadata> GetProperties(EntityMetadata entityMetadata)
	{
		return Instance.GetPropertiesInnerLogic(entityMetadata);
	}

	public static List<PropertyMetadata> GetProperties(Guid objectUid)
	{
		return GetProperties(MetadataLoader.LoadMetadata(objectUid, inherit: true, loadImplementation: false) as EntityMetadata);
	}

	protected override void InitInternal()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				nkeJZEEHGUDXFin45sN(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			ParameterExpression parameterExpression = (ParameterExpression)Y1DLiJERmW6L7vRXVQa(typeof(Guid), NlwujGEaLAUsEVy1ejy(-236222459 ^ -236218779));
			getReplaceableProperties = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Guid, IEnumerable<PropertyMetadata>>>(Expression.Call((Expression)dU7hFEEwwZHAhsLf5Ik(this, typeof(ReplacementRuleManager)), (MethodInfo)Jpo3uIE2dClmnMr8PnI((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression }));
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
			{
				num2 = 2;
			}
		}
	}

	private List<PropertyMetadata> GetPropertiesInnerLogic(EntityMetadata entityMetadata)
	{
		if (entityMetadata == null)
		{
			return new List<PropertyMetadata>();
		}
		return getReplaceableProperties(entityMetadata.Uid).ToList();
	}

	private IEnumerable<PropertyMetadata> GenerateReplaceableProperties(Guid metadataUid)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.userTypeUid = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(loadImplementation: false);
		return ((EntityMetadata)MetadataLoader.LoadMetadata(metadataUid, inherit: true, loadImplementation: false)).Properties.Where(delegate(PropertyMetadata p)
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 4;
			EntityUserSettings entityUserSettings = default(EntityUserSettings);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (!_003C_003Ec__DisplayClass12_0.Kk3TGUpHCxs2JVX2kp8R(_003C_003Ec__DisplayClass12_0.YGmdZmpHvM0owgVhTIcc(p), CS_0024_003C_003E8__locals0.userTypeUid))
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						return _003C_003Ec__DisplayClass12_0.KdRLxlpHU6xrWE4A8y32(entityUserSettings);
					case 1:
						return false;
					case 3:
						if (entityUserSettings != null)
						{
							goto end_IL_0012;
						}
						goto case 1;
					case 4:
						entityUserSettings = _003C_003Ec__DisplayClass12_0.nAaRgOpHPbGhPdCpD2yj(p) as EntityUserSettings;
						num2 = 3;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		});
	}

	public static string ObjectDisplayName(IReplacementRule rule)
	{
		//Discarded unreachable code: IL_004a, IL_0059, IL_0069, IL_0078
		int num = 5;
		int num2 = num;
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (entityMetadata == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			default:
				return null;
			case 4:
				entityMetadata = (IEntityMetadata)crnFO3ECa4XvvDV6e0e(lpePIsEPCvv5XLQ5vMr(), KpAxblEvybCXlj0HQpt(rule));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return (string)OpZMfJEUYiCeH3qxKKw(entityMetadata);
			case 3:
				return "";
			case 5:
				if (rule != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	public static string PropertyDisplayName(IReplacementRule rule)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass14_.rule = rule;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (propertyMetadata != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 2;
					}
					break;
				}
				return null;
			default:
				return null;
			case 5:
				return (string)FKc50HEJoHU3X7yoe51(propertyMetadata);
			case 3:
				if (_003C_003Ec__DisplayClass14_.rule != null)
				{
					propertyMetadata = GetProperties(fvoQMSEoe5ZAmwCZdTD(crnFO3ECa4XvvDV6e0e(lpePIsEPCvv5XLQ5vMr(), KpAxblEvybCXlj0HQpt(_003C_003Ec__DisplayClass14_.rule)))).FirstOrDefault(_003C_003Ec__DisplayClass14_._003CPropertyDisplayName_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public EleWise.ELMA.Security.Models.IUser AssignmentReplacementRule<T>(T entity, Expression<Func<T, object>> expr, IReplacement replacement, bool saveAndFlush = true) where T : IEntity
	{
		if (entity == null || expr == null)
		{
			return null;
		}
		return AssignmentReplacementRule(entity, InterfaceActivator.PropertyUid(expr, inherit: true), replacement, saveAndFlush);
	}

	public EleWise.ELMA.Security.Models.IUser AssignmentReplacementRule(IEntity entity, Guid propertyUid, IReplacement replacement, bool saveAndFlush = true)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		IReplacementRule replacementRule = default(IReplacementRule);
		IReplacementRuleFilter replacementRuleFilter = default(IReplacementRuleFilter);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass16_.saveAndFlush = saveAndFlush;
				num2 = 2;
				break;
			default:
				replacementRule = ((AbstractNHEntityManager<IReplacementRule, long>)lpePIsEPCvv5XLQ5vMr()).Find((IEntityFilter)replacementRuleFilter, new FetchOptions(0, 0, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD826F0))).FirstOrDefault(_003C_003Ec__DisplayClass16_._003CAssignmentReplacementRule_003Eb__0);
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
				{
					num2 = 11;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass16_.entity = entity;
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				return null;
			case 11:
				if (replacementRule != null)
				{
					return replacementRule.TargetUser;
				}
				num2 = 10;
				break;
			case 4:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return null;
			case 9:
				kfKsI8EBNhn55clDPPL(replacementRuleFilter, replacement);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				replacementRuleFilter = InterfaceActivator.Create<IReplacementRuleFilter>();
				num2 = 8;
				break;
			case 8:
				replacementRuleFilter.PropertyUid = propertyUid;
				num2 = 9;
				break;
			case 3:
				_003C_003Ec__DisplayClass16_._003C_003E4__this = this;
				num2 = 5;
				break;
			case 2:
				if (_003C_003Ec__DisplayClass16_.entity != null)
				{
					_003C_003Ec__DisplayClass16_.entityTypeUid = kq3fguEKC5ccYOwkWb6(_003C_003Ec__DisplayClass16_.entity.GetType(), false);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	private bool CheckRule(IReplacementRule rule, IEntity entity, bool saveAndFlush)
	{
		//Discarded unreachable code: IL_00e3, IL_01d7, IL_020b, IL_021a, IL_024b, IL_025a
		int num = 12;
		int num2 = num;
		Type type = default(Type);
		IEntityFilter entityFilter = default(IEntityFilter);
		Type type2 = default(Type);
		IEntityManager entityManagerOrNull = default(IEntityManager);
		FilterForAttribute attribute = default(FilterForAttribute);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 18:
				return false;
			case 20:
				return false;
			case 21:
				type = entity.GetType();
				num2 = 23;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
				{
					num2 = 2;
				}
				continue;
			case 10:
				PyOnCCEFliBwAsahTem(entityFilter, true);
				num2 = 17;
				continue;
			case 2:
				if (!type.IsSubclassOf(type2))
				{
					num2 = 13;
					continue;
				}
				goto case 1;
			case 12:
				if (rule != null)
				{
					num2 = 11;
					continue;
				}
				goto case 18;
			case 17:
				entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(type);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				if (q9KbYfE0E7NOno29cRI(type2, null))
				{
					num2 = 16;
					continue;
				}
				goto case 13;
			default:
				if (entityManagerOrNull == null)
				{
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 9;
			case 23:
				entityFilter.Id = M7CkMuEGuyhGytAGhyQ(t1De3cEcQhmU90Ag1Gs(entity));
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 10;
				}
				continue;
			case 8:
				if (entity != null)
				{
					entityFilter = UniversalFilterSaver.UnPack(PkvUCyEtGO4CjeoxSPR(rule));
					num2 = 14;
					continue;
				}
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
				{
					num2 = 18;
				}
				continue;
			case 1:
			case 7:
				return y45j4MEDcpLLJOJQHtI(entityManagerOrNull, entityFilter) == 1;
			case 13:
			case 15:
				return false;
			case 19:
				obj = null;
				break;
			case 5:
				thtvpeEOhpl5AaBB0Ji(G3bcGTEhqxyyiFrOu9E(this));
				num2 = 6;
				continue;
			case 11:
				if (PkvUCyEtGO4CjeoxSPR(rule) != null)
				{
					num2 = 8;
					continue;
				}
				goto case 18;
			case 4:
				if (attribute == null)
				{
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
					{
						num2 = 13;
					}
					continue;
				}
				obj = LSH9hFEqgKbvnuR5yaE(attribute);
				break;
			case 22:
				EjyN8ZEm7jLplBr33aM(entity);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
				{
					num2 = 3;
				}
				continue;
			case 14:
				if (entityFilter != null)
				{
					if (saveAndFlush)
					{
						num2 = 22;
						continue;
					}
					goto case 6;
				}
				num2 = 20;
				continue;
			case 16:
				if (h7hTAdEEmipl4epTaii(type, type2))
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 2;
			case 3:
				thtvpeEOhpl5AaBB0Ji(G3bcGTEhqxyyiFrOu9E(this));
				num2 = 5;
				continue;
			case 6:
				attribute = AttributeHelper<FilterForAttribute>.GetAttribute(entityFilter.GetType(), inherited: false);
				num2 = 4;
				continue;
			}
			type2 = (Type)obj;
			num2 = 21;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
			{
				num2 = 11;
			}
		}
	}

	[Transaction]
	public virtual void Reorder(long replacementId, List<long> ruleList)
	{
		if (ReplacementManager.Instance.LoadOrNull(replacementId) != null)
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			ruleList = ruleList ?? new List<long>();
			for (int i = 0; i < ruleList.Count; i++)
			{
				serviceNotNull.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EB0B14), new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x432996D0 ^ 0x43293DF8) }, new object[1] { i }, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698550823), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBF5944)), replacementId, serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D764E62)), ruleList[i]));
			}
			string text = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959667918), ruleList);
			serviceNotNull.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33CA67), new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068861330) }, new object[1] { int.MaxValue }, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429399819), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788357916)), replacementId, string.IsNullOrEmpty(text) ? "" : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698550987), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71CCF3F)), text)));
		}
	}

	public virtual IList<IReplacementRule> FindPlannedReplacementRule(IUser fromUser, IUser toUser, DateTime? startDate, DateTime? endDate, long? ignoreReplacementId = null)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.endDate = endDate;
		CS_0024_003C_003E8__locals0.startDate = startDate;
		ICriteria val = CreateCriteria();
		val.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-848444002 ^ -848466404), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E67B34C), (JoinType)1);
		val.If(CS_0024_003C_003E8__locals0.endDate.HasValue, (ICriteria c) => (ICriteria)_003C_003Ec__DisplayClass19_0.doWSYbpHgp1ROBOc5oIr(c, _003C_003Ec__DisplayClass19_0.sAVUMupHTtVDmhLSJZyD(_003C_003Ec__DisplayClass19_0.yrP1FZpHdqR17t2MbvqO(0xCDF201B ^ 0xCDE0D9F), CS_0024_003C_003E8__locals0.endDate))).If(CS_0024_003C_003E8__locals0.startDate.HasValue, (ICriteria c) => c.Add((ICriterion)_003C_003Ec__DisplayClass19_0.sOoUh4pH8msn22VfmGiI(_003C_003Ec__DisplayClass19_0.yrP1FZpHdqR17t2MbvqO(0x4CD4C8A0 ^ 0x4CD4635C), CS_0024_003C_003E8__locals0.startDate))).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B6E77), (object)ReplacementStatus.Delete)))
			.AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51BB29A6 ^ 0x51BB825A)));
		if (fromUser != null && toUser != null)
		{
			val.Add((ICriterion)(object)((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x84482CB ^ 0x8442ED9), (object)fromUser)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x190F47B7 ^ 0x190FEB99), (object)fromUser)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1615559191 ^ -1615582725), (object)toUser)));
		}
		else if (fromUser != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163197870), (object)fromUser));
		}
		else
		{
			if (toUser == null)
			{
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x11C59687 ^ 0x11C53AC1));
			}
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801424560), (object)toUser));
		}
		if (ignoreReplacementId.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417D2D84), (object)ignoreReplacementId.Value)));
		}
		return val.SetCacheable(true).List<IReplacementRule>();
	}

	public IDictionary<long, bool> CheckIfReplacementsHaveRules(IList<IReplacement> replacement)
	{
		return CreateCriteria().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A4FDB7), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429399925), (JoinType)2).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417D2D84), (ICollection)replacement.Select((IReplacement r) => r.Id).ToArray())).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C22D13))).Add((IProjection)(object)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A337141))) })
			.List<object[]>()
			.ToDictionary((object[] r) => _003C_003Ec.Iae8KbpHSungltpJO1xL(r[0]), (object[] r) => _003C_003Ec.Iae8KbpHSungltpJO1xL(r[1]) > 0);
	}

	public ReplacementRuleManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t08l4oEMUmrAe8Z0n9Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void kfKsI8EBNhn55clDPPL(object P_0, object P_1)
	{
		((IReplacementRuleFilter)P_0).Replacement = (IReplacement)P_1;
	}

	internal static object Be6a8LEuCKNhaaXBBWi()
	{
		return FetchOptions.All;
	}

	internal static void EjyN8ZEm7jLplBr33aM(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool VTnBmyEepoCKs9o4t7K(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Tim2wSELnkcADHlHYkd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool R8addPEZOG0OCV5sqYx()
	{
		return UCnkAeEN0YwO6Io8aWg == null;
	}

	internal static ReplacementRuleManager aAM5xnExU4Q65NA0Io0()
	{
		return UCnkAeEN0YwO6Io8aWg;
	}

	internal static object GAC7kvEjCEIV2YBWYIF(object P_0)
	{
		return ((EntityManager<IReplacementRule, long>)P_0).MetadataRuntimeService;
	}

	internal static void nkeJZEEHGUDXFin45sN(object P_0)
	{
		((NHManager)P_0).InitInternal();
	}

	internal static object NlwujGEaLAUsEVy1ejy(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Y1DLiJERmW6L7vRXVQa(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object dU7hFEEwwZHAhsLf5Ik(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object Jpo3uIE2dClmnMr8PnI(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object lpePIsEPCvv5XLQ5vMr()
	{
		return Instance;
	}

	internal static Guid KpAxblEvybCXlj0HQpt(object P_0)
	{
		return ((IReplacementRule)P_0).PropertyUid;
	}

	internal static object crnFO3ECa4XvvDV6e0e(object P_0, Guid propertyUid)
	{
		return ((ReplacementRuleManager)P_0).ObjectForProperty(propertyUid);
	}

	internal static object OpZMfJEUYiCeH3qxKKw(object P_0)
	{
		return ((ICodeItemMetadata)P_0).DisplayName;
	}

	internal static Guid fvoQMSEoe5ZAmwCZdTD(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object FKc50HEJoHU3X7yoe51(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static Guid kq3fguEKC5ccYOwkWb6(Type P_0, bool P_1)
	{
		return InterfaceActivator.UID(P_0, P_1);
	}

	internal static object PkvUCyEtGO4CjeoxSPR(object P_0)
	{
		return ((IReplacementRule)P_0).Filter;
	}

	internal static object G3bcGTEhqxyyiFrOu9E(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static void thtvpeEOhpl5AaBB0Ji(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static Type LSH9hFEqgKbvnuR5yaE(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static object t1De3cEcQhmU90Ag1Gs(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static long M7CkMuEGuyhGytAGhyQ(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void PyOnCCEFliBwAsahTem(object P_0, bool P_1)
	{
		((IEntityFilter)P_0).DisableSecurity = P_1;
	}

	internal static bool q9KbYfE0E7NOno29cRI(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool h7hTAdEEmipl4epTaii(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static long y45j4MEDcpLLJOJQHtI(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Count((IEntityFilter)P_1);
	}

	internal static void t08l4oEMUmrAe8Z0n9Z()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

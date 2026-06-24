using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class AbsenceManager : EntityManager<IAbsence, long>
{
	internal const string Key = "EleWise_ELMA_ActiveAbsences";

	internal const string TimestampKey = "EleWise_ELMA_ActiveAbsences_TimeStamp";

	private static AbsenceManager jHdhPwIafTLmrx4D9LY;

	public IComplexCacheService ComplexCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CComplexCacheService_003Ek__BackingField;
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
					_003CComplexCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public new static AbsenceManager Instance => Locator.GetServiceNotNull<AbsenceManager>();

	[PublicApiMember]
	public override void Save(IAbsence obj)
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
				base.Save(obj);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Assign(IAbsence absence)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				vDXtGFI2oYGsgrfLVn7(absence, AbsenceStatus.Active);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				Save(absence);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Cancel(IAbsence absence)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				vDXtGFI2oYGsgrfLVn7(absence, AbsenceStatus.Closed);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				Save(absence);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IList<IAbsence> GetAbsences(IUser user)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.user = user;
		return ComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EAE816 ^ 0x61EA55B0) + CS_0024_003C_003E8__locals0.user.GetId(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1329706983 ^ -1329723943) + CS_0024_003C_003E8__locals0.user.GetId(), () => CS_0024_003C_003E8__locals0._003C_003E4__this.LoadAbsences(CS_0024_003C_003E8__locals0.user));
	}

	private IList<IAbsence> LoadAbsences(IUser user)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B056A9C ^ 0x3B056540), (object)user)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-434542700 ^ -434542566), (object)AbsenceStatus.Active)).Add((ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x383232E0), (object)DateTime.Today))
			.AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566038688)))
			.List<IAbsence>();
	}

	public IAbsence GetNearAbsence(EleWise.ELMA.Security.Models.IUser user)
	{
		return ((ICriteria)IR94BVICbS0JabcQOVi(IR94BVICbS0JabcQOVi(IR94BVICbS0JabcQOVi(CreateCriteria(), HVJ7MtIviwDInltp2Iq(tqVdHgIPkxXmOyAkAvl(-1329706983 ^ -1329667895), user.Id)), Restrictions.Gt((string)tqVdHgIPkxXmOyAkAvl(0x78610A3D ^ 0x7861B7DD), (object)DateTime.Now)), HVJ7MtIviwDInltp2Iq(tqVdHgIPkxXmOyAkAvl(0x6A336151 ^ 0x6A336EDF), AbsenceStatus.Active))).AddOrder((Order)GPM4S1IUi1H0OgBSwi4(tqVdHgIPkxXmOyAkAvl(-724676315 ^ -724636475))).SetMaxResults(1).UniqueResult<IAbsence>();
	}

	public IAbsence GetTodayAbsence(IUser user)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dateTime = kUgt9RIoDp0nV2eVYmo();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ((ICriteria)eqVeUtItmpJlimOEKIl(((ICriteria)IR94BVICbS0JabcQOVi(IR94BVICbS0JabcQOVi(CreateCriteria().Add((ICriterion)(object)Restrictions.Eq((string)tqVdHgIPkxXmOyAkAvl(0xCDF201B ^ 0xCDF2FC7), (object)user)), YkD0X7IJIcQguJLi1Uj(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-726732645 ^ -726774423), dateTime)), kiu9y9IKA25BxWkNH40(tqVdHgIPkxXmOyAkAvl(-905821499 ^ -905773275), dateTime))).Add((ICriterion)HVJ7MtIviwDInltp2Iq(tqVdHgIPkxXmOyAkAvl(0x271B34E4 ^ 0x271B3B6A), AbsenceStatus.Active)), GPM4S1IUi1H0OgBSwi4(tqVdHgIPkxXmOyAkAvl(0x4B68CDFB ^ 0x4B68701B)))).SetMaxResults(1).UniqueResult<IAbsence>();
			}
		}
	}

	public IList<IAbsence> FindIntersection(IUser user, DateTime startDate, DateTime endDate)
	{
		if (user != null)
		{
			return FindIntersection(new IUser[1] { user }, startDate, endDate);
		}
		return null;
	}

	public IList<IAbsence> FindIntersection(IEnumerable<IUser> users, DateTime startDate, DateTime endDate)
	{
		if (users != null && users.Any())
		{
			return CreateCriteria().Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0396C), (object)endDate), (ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4177C82C ^ 0x417775CC), (object)startDate))).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD946FDB ^ 0xD94C70B), users.Select((IUser user) => _003C_003Ec.foCro6pR9aCPxYmaLZek(user)).ToArray())).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1278809262 ^ -1278810916), (object)AbsenceStatus.Closed)))
				.List<IAbsence>();
		}
		return null;
	}

	public IList<IAbsence> GetPlannedAbsences(IUser user, DateTime startDate, DateTime endDate)
	{
		if (user != null)
		{
			return CreateCriteria().Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A79A716 ^ 0x6A791AE4), (object)startDate), (ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E791565), (object)endDate))).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC66F4C8), (object)user)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE45F5), (object)AbsenceStatus.Active))
				.List<IAbsence>();
		}
		return null;
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
				type = InterfaceActivator.TypeOf<IAbsence>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule obj = new ExportRule
			{
				ParentType = type,
				PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426959696)
			};
			SRLOymIhw0rvoJRLExl(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule = new ExportRule();
			cXybjaIOrUIUTDcGGR3(exportRule, type);
			m3BFNVIqWvfDRjqg0ZS(exportRule, tqVdHgIPkxXmOyAkAvl(0x67DFA65E ^ 0x67DF1BBE));
			SRLOymIhw0rvoJRLExl(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			m3BFNVIqWvfDRjqg0ZS(obj2, tqVdHgIPkxXmOyAkAvl(0x7CAA49C6 ^ 0x7CAAF434));
			obj2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj2);
			ExportRule exportRule2 = new ExportRule();
			cXybjaIOrUIUTDcGGR3(exportRule2, type);
			m3BFNVIqWvfDRjqg0ZS(exportRule2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43ED0BDB));
			SRLOymIhw0rvoJRLExl(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			m3BFNVIqWvfDRjqg0ZS(obj3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA3FD3));
			obj3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj3);
			ExportRule obj4 = new ExportRule
			{
				ParentType = type
			};
			m3BFNVIqWvfDRjqg0ZS(obj4, tqVdHgIPkxXmOyAkAvl(0x4D765E72 ^ 0x4D7651AE));
			SRLOymIhw0rvoJRLExl(obj4, ExportRuleType.Export);
			exportRuleList.Add(obj4);
			return exportRuleList;
		}
	}

	internal void UpdateAbsencesCache()
	{
		//Discarded unreachable code: IL_0086, IL_0095, IL_00a0, IL_01eb, IL_01fa, IL_026e, IL_02a6, IL_02b5
		int num = 2;
		int num2 = num;
		IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator = default(IEnumerator<EleWise.ELMA.Security.Models.IUser>);
		IUserFilter userFilter = default(IUserFilter);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		EleWise.ELMA.Security.Models.IUser current = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				enumerator = UserManager.Instance.Find(userFilter, null).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				userFilter.ShowBlock = false;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				userFilter = InterfaceActivator.Create<IUserFilter>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				return;
			}
			try
			{
				while (true)
				{
					IL_0159:
					int num3;
					if (!S924W5I0AMWjbllagew(enumerator))
					{
						num3 = 2;
						goto IL_00a4;
					}
					goto IL_00d2;
					IL_00a4:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						default:
							yilqHiIcCv93wCr0aT4(ComplexCacheService, tqVdHgIPkxXmOyAkAvl(-1278809262 ^ -1278826862));
							num3 = 3;
							continue;
						case 7:
							_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
							num3 = 8;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
							{
								num3 = 8;
							}
							continue;
						case 8:
							_003C_003Ec__DisplayClass19_.absenceList = GetAbsences(current).ToList();
							num3 = 6;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
							{
								num3 = 6;
							}
							continue;
						case 4:
						case 5:
							goto IL_0159;
						case 3:
							ComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62C4BCE8 ^ 0x62C4014E) + eAgWsLIG0jivc59UnLJ(current), (string)GNJQAhIFhZfFKCTpdnU(tqVdHgIPkxXmOyAkAvl(0x715714F9 ^ 0x71575939), eAgWsLIG0jivc59UnLJ(current)), _003C_003Ec__DisplayClass19_._003CUpdateAbsencesCache_003Eb__1);
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
							if (_003C_003Ec__DisplayClass19_.absenceList.RemoveAll((IAbsence k) => _003C_003Ec.EqBnnUpRzXWty2BRmnW7(_003C_003Ec.PGZEpKpRfomu7VKyhcJq(k), _003C_003Ec.CifrrDpR1AR2fWjhFhmc())) <= 0)
							{
								num3 = 5;
								continue;
							}
							goto default;
						case 2:
							return;
						}
						break;
					}
					goto IL_00d2;
					IL_00d2:
					current = enumerator.Current;
					num3 = 7;
					goto IL_00a4;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							Tw6B8WIE0Yposk0o5yq(enumerator);
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
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
			}
		}
	}

	internal void InitAbsenceCache()
	{
		int num = 7;
		IAbsenceFilter absenceFilter = default(IAbsenceFilter);
		IUserFilter userFilter = default(IUserFilter);
		ICollection<IAbsence> inner = default(ICollection<IAbsence>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 2:
					absenceFilter.EndDate = new DateTimeRange(jVG75NID4N7ndef4Jid(), null);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					absenceFilter.Status = AbsenceStatus.Active;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					absenceFilter = InterfaceActivator.Create<IAbsenceFilter>();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					userFilter = InterfaceActivator.Create<IUserFilter>();
					num2 = 5;
					continue;
				default:
					inner = ((AbstractNHEntityManager<IAbsence, long>)SWlOWTIMrP8qIexF27o()).Find((IEntityFilter)absenceFilter, (FetchOptions)null);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 4:
					(from user in UserManager.Instance.Find(userFilter, null)
						join absence in inner on user equals (EleWise.ELMA.Security.Models.IUser)_003C_003Ec.L7O1AXpwkCOqcgRpFhdh(absence) into absences
						select new
						{
							User = user,
							Absences = (absences as IList<IAbsence>)
						}).Each(k =>
					{
						_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
						CS_0024_003C_003E8__locals0.k = k;
						ComplexCacheService.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAB1826) + CS_0024_003C_003E8__locals0.k.User.GetId(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905821499 ^ -905834747) + CS_0024_003C_003E8__locals0.k.User.GetId(), () => CS_0024_003C_003E8__locals0.k.Absences);
					});
					num2 = 3;
					continue;
				}
				break;
			}
			fZiXAwIstpHUQ4KrIfw(userFilter, false);
			num = 4;
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0129, IL_014a
		int num = 2;
		int num2 = num;
		IUser user = default(IUser);
		IAbsenceFilter absenceFilter = default(IAbsenceFilter);
		while (true)
		{
			switch (num2)
			{
			case 11:
				IR94BVICbS0JabcQOVi(criteria, HVJ7MtIviwDInltp2Iq(tqVdHgIPkxXmOyAkAvl(0x417D81DE ^ 0x417D8E02), user));
				num2 = 9;
				break;
			case 8:
				return;
			case 10:
				if (!((IEnumerable<EleWise.ELMA.Security.Models.IUser>)absenceFilter.Users).Any())
				{
					return;
				}
				num2 = 6;
				break;
			case 2:
				cOBIDRIYXXn0XnAoNmp(this, criteria, filter);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return;
			case 4:
				user = (IUser)yo9RiZIIhuX1kYyucUw(absenceFilter, tqVdHgIPkxXmOyAkAvl(-1518425080 ^ -1518427180), null);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (absenceFilter == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
				{
					num2 = 4;
				}
				break;
			default:
				if (user == null)
				{
					num2 = 5;
					break;
				}
				goto case 11;
			case 1:
				absenceFilter = filter as IAbsenceFilter;
				num2 = 3;
				break;
			case 6:
				IR94BVICbS0JabcQOVi(criteria, ERN1BlI4v37s42XIVHS(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784478707), ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)absenceFilter.Users).ToList()));
				num2 = 8;
				break;
			case 5:
			case 9:
				if (absenceFilter.Users == null)
				{
					return;
				}
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public AbsenceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C8AiHdIVNZ4mepcUJje();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JoroOnIRLwrb38wA4xA()
	{
		return jHdhPwIafTLmrx4D9LY == null;
	}

	internal static AbsenceManager aON2vDIwRi4hV9bye7f()
	{
		return jHdhPwIafTLmrx4D9LY;
	}

	internal static void vDXtGFI2oYGsgrfLVn7(object P_0, AbsenceStatus value)
	{
		((IAbsence)P_0).Status = value;
	}

	internal static object tqVdHgIPkxXmOyAkAvl(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HVJ7MtIviwDInltp2Iq(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object IR94BVICbS0JabcQOVi(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object GPM4S1IUi1H0OgBSwi4(object P_0)
	{
		return Order.Asc((string)P_0);
	}

	internal static DateTime kUgt9RIoDp0nV2eVYmo()
	{
		return DateTime.Now;
	}

	internal static object YkD0X7IJIcQguJLi1Uj(object P_0, object P_1)
	{
		return Restrictions.Le((string)P_0, P_1);
	}

	internal static object kiu9y9IKA25BxWkNH40(object P_0, object P_1)
	{
		return Restrictions.Ge((string)P_0, P_1);
	}

	internal static object eqVeUtItmpJlimOEKIl(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static void SRLOymIhw0rvoJRLExl(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static void cXybjaIOrUIUTDcGGR3(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void m3BFNVIqWvfDRjqg0ZS(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void yilqHiIcCv93wCr0aT4(object P_0, object P_1)
	{
		((IComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static object eAgWsLIG0jivc59UnLJ(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object GNJQAhIFhZfFKCTpdnU(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static bool S924W5I0AMWjbllagew(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Tw6B8WIE0Yposk0o5yq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static DateTime jVG75NID4N7ndef4Jid()
	{
		return DateTime.Today;
	}

	internal static object SWlOWTIMrP8qIexF27o()
	{
		return Instance;
	}

	internal static void fZiXAwIstpHUQ4KrIfw(object P_0, bool value)
	{
		((IUserFilter)P_0).ShowBlock = value;
	}

	internal static void cOBIDRIYXXn0XnAoNmp(object P_0, object P_1, object P_2)
	{
		((EntityManager<IAbsence, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object yo9RiZIIhuX1kYyucUw(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}

	internal static object ERN1BlI4v37s42XIVHS(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static void C8AiHdIVNZ4mepcUJje()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

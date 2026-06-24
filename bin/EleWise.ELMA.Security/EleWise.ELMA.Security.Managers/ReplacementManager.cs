using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ReplacementManager : EntityManager<IReplacement, long>
{
	internal static ReplacementManager PAjbZKVv585Vi0ZvqCO;

	public IUnionComplexCacheService UnionComplexCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CUnionComplexCacheService_003Ek__BackingField;
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
				case 1:
					_003CUnionComplexCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[NotNull]
	public new static ReplacementManager Instance => Locator.GetServiceNotNull<ReplacementManager>();

	[Auditable]
	[PublicApiMember]
	[Transaction]
	[ActionMethod("42986da3-d210-414d-9225-f3cde17c18c9")]
	public override void Save(IReplacement obj)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UnionComplexCacheService.RefreshTimestamp((string)F8gUswVqk6dEXo3lhg9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x4634B2BE), ((IEntity<long>)Hee2pgVO2aIu8cnBJG9(obj)).Id));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				base.Save(obj);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				JKVdENVJFTs9KpZeMOf(hhw2WfVoCKvsnxCHoeJ(), obj);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				trlRjDVhdyTDBGcnyLN(UnionComplexCacheService, string.Format((string)CmEHxbVKhvTJRKWWjfA(0x32A45635 ^ 0x32A4987D), (LCgrCIVtJ774SMxc54l(obj) != null) ? new long?(((IEntity<long>)LCgrCIVtJ774SMxc54l(obj)).Id) : null, DateTime.Today));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override ActionCheckResult CanSave(IReplacement obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ActionCheckResult.False((string)kgEuddVcIXSANMW16sq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D36BD7)));
			case 1:
				if (LCgrCIVtJ774SMxc54l(obj) != Hee2pgVO2aIu8cnBJG9(obj))
				{
					return base.CanSave(obj);
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IList<IReplacement> GetReplacements(IUser user)
	{
		return FindPlannedReplacement(user, null, DateTime.Today, DateTime.MaxValue);
	}

	public IList<IReplacement> GetReplacementsReadOnly(IUser user)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.user = user;
		return UnionComplexCacheService.GetOrAdd(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1943394692 ^ -1943344736), (CS_0024_003C_003E8__locals0.user != null) ? CS_0024_003C_003E8__locals0.user.GetId() : null, DateTime.Today), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xBBC1CCD ^ 0xBBCD285), (CS_0024_003C_003E8__locals0.user != null) ? CS_0024_003C_003E8__locals0.user.GetId() : null, DateTime.Today), () => CS_0024_003C_003E8__locals0._003C_003E4__this.GetReplacements(CS_0024_003C_003E8__locals0.user), TimeSpan.FromDays(1.0));
	}

	public long[] GetReplacedUsers([NotNull] IUser user)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return UnionComplexCacheService.GetOrAdd((string)F8gUswVqk6dEXo3lhg9(CmEHxbVKhvTJRKWWjfA(-698589567 ^ -698577383), cOtaBqVGdOtjXiRaqSE(_003C_003Ec__DisplayClass14_.user)), (string)F8gUswVqk6dEXo3lhg9(CmEHxbVKhvTJRKWWjfA(-2030777218 ^ -2030828698), cOtaBqVGdOtjXiRaqSE(_003C_003Ec__DisplayClass14_.user)), _003C_003Ec__DisplayClass14_._003CGetReplacedUsers_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Ec__DisplayClass14_.user = user;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IList<IReplacement> FindPlannedReplacement(IUser fromUser, IUser toUser, DateTime? startDate, DateTime? endDate, long? ignoreReplacementId = null)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.endDate = endDate;
		CS_0024_003C_003E8__locals0.startDate = startDate;
		ICriteria val = CreateCriteria().If(CS_0024_003C_003E8__locals0.endDate.HasValue, (ICriteria c) => (ICriteria)_003C_003Ec__DisplayClass15_0.SIqJ58p2PZHhq4vXh4Ks(c, Restrictions.Le((string)_003C_003Ec__DisplayClass15_0.KHAnljp22JEkOHVZpMm2(0x61EAE816 ^ 0x61EA55E4), (object)CS_0024_003C_003E8__locals0.endDate))).If(CS_0024_003C_003E8__locals0.startDate.HasValue, (ICriteria c) => (ICriteria)_003C_003Ec__DisplayClass15_0.SIqJ58p2PZHhq4vXh4Ks(c, _003C_003Ec__DisplayClass15_0.rbvOhAp2v0PiJKABBbZ8(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816842177), CS_0024_003C_003E8__locals0.startDate))).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1278809262 ^ -1278810916), (object)ReplacementStatus.Delete)))
			.AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E791565)));
		if (fromUser != null && toUser != null)
		{
			val.Add((ICriterion)(object)((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAB7574), (object)fromUser)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EAE816 ^ 0x61EA4438), (object)fromUser)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858473711 ^ -1858526747), (object)toUser)));
		}
		else if (fromUser != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757471249), (object)fromUser));
		}
		else
		{
			if (toUser == null)
			{
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1027693337 ^ -1027733343));
			}
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD946FDB ^ 0xD94C3F5), (object)toUser));
		}
		if (ignoreReplacementId.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712587919 ^ -1712592031), (object)ignoreReplacementId.Value)));
		}
		return val.SetCacheable(true).List<IReplacement>();
	}

	public IList<IReplacement> FindPlannedReplacement(long? id, DateTime startDate, DateTime endDate)
	{
		if (!id.HasValue)
		{
			return null;
		}
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(id.Value);
		if (user == null)
		{
			return null;
		}
		return FindPlannedReplacement(user, null, startDate, endDate);
	}

	public bool CheckReplacementnData(IReplacement replacement)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return sHS64JVELCYMymWy7AZ(DateTime.Today, replacement.StartDate);
			case 2:
				if (replacement == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!P0BrGrV0udpuncB8XBW(jKKJXpVFf0YvVyxhOdI(), replacement.EndDate))
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void PutReplacement(IReplacement replacement)
	{
		//Discarded unreachable code: IL_007b, IL_00d9, IL_00e8
		int num = 9;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser sourceUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 11:
				Save(replacement);
				num2 = 13;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 7:
				if (CheckReplacementnData((IReplacement)mf2irgVYxUCpvluS1vB(sourceUser)))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				GPY2BPVsXiDfstBvHOV(sourceUser);
				num2 = 6;
				break;
			case 8:
				MVKvfiVMt2tUWdyvHh0(replacement, ReplacementStatus.Delete);
				num2 = 11;
				break;
			case 3:
				GPY2BPVsXiDfstBvHOV(sourceUser);
				num2 = 4;
				break;
			case 10:
				return;
			default:
				if (!CheckReplacementnData(replacement))
				{
					num2 = 7;
					break;
				}
				goto case 12;
			case 12:
				SetUserReplacement(sourceUser, replacement);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
				{
					num2 = 3;
				}
				break;
			case 13:
				sourceUser = replacement.SourceUser;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				SetUserReplacement(sourceUser, null);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (sourceUser == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				if (cainJ9VDWkThJO3Hgm7(replacement) < jKKJXpVFf0YvVyxhOdI())
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 11;
			}
		}
	}

	[PublicApiMember]
	[Transaction]
	[Auditable]
	public override void Delete(IReplacement replacement)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					return;
				case 0:
					return;
				case 4:
					if (replacement == null)
					{
						return;
					}
					goto end_IL_0012;
				case 2:
					replacement.Save();
					num2 = 5;
					break;
				case 1:
					return;
				case 3:
					if (!replacement.IsNew())
					{
						if (mf2irgVYxUCpvluS1vB(LCgrCIVtJ774SMxc54l(replacement)) == replacement)
						{
							num2 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
							{
								num2 = 1;
							}
							break;
						}
						MVKvfiVMt2tUWdyvHh0(replacement, ReplacementStatus.Delete);
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private void SetUserReplacement(EleWise.ELMA.Security.Models.IUser user, IReplacement replacement)
	{
		//Discarded unreachable code: IL_0096, IL_0144
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 11:
					break;
				case 0:
					return;
				case 2:
					return;
				case 9:
					if (rmakq8VIaOx2L3TNW0t(user) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 4:
					if (rmakq8VIaOx2L3TNW0t(user) == null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 8:
					trlRjDVhdyTDBGcnyLN(UnionComplexCacheService, F8gUswVqk6dEXo3lhg9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566059624), ((IEntity<long>)rmakq8VIaOx2L3TNW0t(user)).Id));
					num2 = 2;
					continue;
				case 5:
					xdc3MQVQ3PjGyopUOML(user, replacement);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
				case 10:
					gK50QEV4dqnfCpygR5E(user, (replacement != null) ? Hee2pgVO2aIu8cnBJG9(replacement) : null);
					num2 = 6;
					continue;
				case 6:
					user.DuplicateMessage = ((replacement != null) ? replacement.DuplicateMessage : new bool?(false));
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					user.EndReplacement = ((replacement != null) ? new DateTime?(cainJ9VDWkThJO3Hgm7(replacement)) : null);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					Tn88b3VVMSoeTjS9eTa(user, (replacement != null) ? ReplacementMode.AutoReplacement : ReplacementMode.None);
					num2 = 5;
					continue;
				}
				break;
			}
			trlRjDVhdyTDBGcnyLN(UnionComplexCacheService, F8gUswVqk6dEXo3lhg9(CmEHxbVKhvTJRKWWjfA(0x31274285 ^ 0x31278D9D), ((IEntity<long>)rmakq8VIaOx2L3TNW0t(user)).Id));
			num = 10;
		}
	}

	public void Complete(IReplacement replacement)
	{
		//Discarded unreachable code: IL_00c1
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				return;
			case 0:
				return;
			case 6:
				if (LCgrCIVtJ774SMxc54l(replacement) != null)
				{
					SetUserReplacement((EleWise.ELMA.Security.Models.IUser)LCgrCIVtJ774SMxc54l(replacement), null);
					num2 = 3;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				GPY2BPVsXiDfstBvHOV(LCgrCIVtJ774SMxc54l(replacement));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				Delete(replacement);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (replacement == null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			}
		}
	}

	[Transaction]
	public virtual void ConversionPlanReplacement()
	{
		//Discarded unreachable code: IL_00ea, IL_00f4, IL_01a3, IL_01db, IL_01ea, IL_01fb, IL_0205, IL_02a4, IL_02dc, IL_0359, IL_0368, IL_0373, IL_03f7, IL_0416, IL_0425, IL_0452
		int num = 2;
		int num2 = num;
		IEnumerator<IReplacement> enumerator2 = default(IEnumerator<IReplacement>);
		IReplacement current = default(IReplacement);
		IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator = default(IEnumerator<EleWise.ELMA.Security.Models.IUser>);
		EleWise.ELMA.Security.Models.IUser current2 = default(EleWise.ELMA.Security.Models.IUser);
		IReplacement current3 = default(IReplacement);
		while (true)
		{
			switch (num2)
			{
			case 6:
				enumerator2 = ((ICriteria)xgRSQgVy3VHpWFYMACD(xgRSQgVy3VHpWFYMACD(xgRSQgVy3VHpWFYMACD(MCo6iAVSWI1D4RATH2Z(this, null), jVlSLDVrdLqiTRlNSPG(ne68iiV8qmiFMq6DdpO(CmEHxbVKhvTJRKWWjfA(0x2E78F5A0 ^ 0x2E78FA2E), ReplacementStatus.Delete))), Restrictions.Ge(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCDF201B ^ 0xCDF9DFB), (object)jKKJXpVFf0YvVyxhOdI())), Restrictions.Le((string)CmEHxbVKhvTJRKWWjfA(0x487E82CC ^ 0x487E3F3E), (object)jKKJXpVFf0YvVyxhOdI()))).List<IReplacement>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				try
				{
					while (true)
					{
						IL_0157:
						int num3;
						if (!CSEhJUVga6QIdIWdlLP(enumerator2))
						{
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
							{
								num3 = 3;
							}
							goto IL_00f8;
						}
						goto IL_0134;
						IL_0134:
						current = enumerator2.Current;
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
						{
							num3 = 1;
						}
						goto IL_00f8;
						IL_00f8:
						while (true)
						{
							switch (num3)
							{
							case 1:
								Delete(current);
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								break;
							default:
								goto IL_0157;
							case 3:
								goto end_IL_0157;
							}
							break;
						}
						goto IL_0134;
						continue;
						end_IL_0157:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								ekq6SnVbUULRZT3K3Ry(enumerator2);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
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
				goto case 6;
			case 4:
				enumerator2 = ((ICriteria)xgRSQgVy3VHpWFYMACD(CreateCriteria().Add((ICriterion)jVlSLDVrdLqiTRlNSPG(ne68iiV8qmiFMq6DdpO(CmEHxbVKhvTJRKWWjfA(0x201ABE6B ^ 0x201AB1E5), ReplacementStatus.Delete))), yDXNUwV3wxQubAIxOkx(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD49F92), jKKJXpVFf0YvVyxhOdI()))).List<IReplacement>().GetEnumerator();
				num2 = 3;
				continue;
			case 1:
				try
				{
					while (true)
					{
						int num5;
						if (!CSEhJUVga6QIdIWdlLP(enumerator))
						{
							num5 = 3;
							goto IL_0377;
						}
						goto IL_03be;
						IL_0377:
						while (true)
						{
							switch (num5)
							{
							case 2:
								break;
							case 1:
								Complete((IReplacement)mf2irgVYxUCpvluS1vB(current2));
								num5 = 2;
								continue;
							default:
								goto IL_03be;
							case 3:
								goto end_IL_0391;
							}
							break;
						}
						continue;
						IL_03be:
						current2 = enumerator.Current;
						num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num5 = 0;
						}
						goto IL_0377;
						continue;
						end_IL_0391:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 2;
						goto IL_03fb;
					}
					goto IL_0430;
					IL_03fb:
					switch (num6)
					{
					case 2:
						goto end_IL_03e6;
					case 1:
						goto end_IL_03e6;
					}
					goto IL_0430;
					IL_0430:
					enumerator.Dispose();
					num6 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
					{
						num6 = 1;
					}
					goto IL_03fb;
					end_IL_03e6:;
				}
				goto case 4;
			case 5:
				return;
			case 2:
			{
				object obj = qu4I0NVdPpJjaAdFYLa();
				InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
				instanceOf.New.ShowOnlyReplacement = true;
				enumerator = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)obj).Find((IEntityFilter)instanceOf.New, (FetchOptions)UNO354VTf9y9k9gV0lU()).Where(delegate(EleWise.ELMA.Security.Models.IUser user)
				{
					int num9 = 1;
					DateTime dateTime = default(DateTime);
					DateTime? endReplacement = default(DateTime?);
					while (true)
					{
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							default:
								dateTime = _003C_003Ec.ifCwuxp2K0X46PAU6toQ();
								num10 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
								{
									num10 = 2;
								}
								break;
							case 3:
								return false;
							case 2:
								if (endReplacement.HasValue)
								{
									return _003C_003Ec.vprYnsp2tgRr4sDuaSC0(endReplacement.GetValueOrDefault(), dateTime);
								}
								goto end_IL_0012;
							case 1:
								endReplacement = user.EndReplacement;
								num10 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
								{
									num10 = 0;
								}
								break;
							}
							continue;
							end_IL_0012:
							break;
						}
						num9 = 3;
					}
				}).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			}
			try
			{
				while (true)
				{
					int num7;
					if (!enumerator2.MoveNext())
					{
						num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
						{
							num7 = 0;
						}
						goto IL_0209;
					}
					goto IL_026b;
					IL_026b:
					current3 = enumerator2.Current;
					num7 = 2;
					goto IL_0209;
					IL_0209:
					while (true)
					{
						switch (num7)
						{
						default:
							return;
						case 1:
							break;
						case 2:
							PutReplacement(current3);
							num7 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
							{
								num7 = 1;
							}
							continue;
						case 3:
							goto IL_026b;
						case 0:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					int num8 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							enumerator2.Dispose();
							num8 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
							{
								num8 = 0;
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

	public static void AddUserToList<T>(T entity, Expression<Func<T, object>> expr, List<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement = false) where T : IEntity
	{
		_003C_003Ec__DisplayClass23_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0<T>();
		if (users != null && user != null)
		{
			CS_0024_003C_003E8__locals0.addUser = GetExecutor(entity, expr, user, denyReplacement);
			if (users.Find((EleWise.ELMA.Security.Models.IUser u) => u.Id == CS_0024_003C_003E8__locals0.addUser.Id) == null)
			{
				users.Add(CS_0024_003C_003E8__locals0.addUser);
			}
		}
	}

	public static void AddUserNotBlockToList<T>(T entity, Expression<Func<T, object>> expr, List<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement = false) where T : IEntity
	{
		_003C_003Ec__DisplayClass24_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0<T>();
		if (users != null && user != null)
		{
			CS_0024_003C_003E8__locals0.addUser = GetExecutor(entity, expr, user, denyReplacement);
			if (users.Find((EleWise.ELMA.Security.Models.IUser u) => u.Id == CS_0024_003C_003E8__locals0.addUser.Id) == null && CS_0024_003C_003E8__locals0.addUser.Status != UserStatus.Blocked)
			{
				users.Add(CS_0024_003C_003E8__locals0.addUser);
			}
		}
	}

	[Obsolete("Метод устарел, вместо него необходимо использовать одноимённый с другими параметрами")]
	public static void AddUserToList(List<Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>> users, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement = false)
	{
		if (users != null && user != null)
		{
			_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
			CS_0024_003C_003E8__locals0.addUser = new Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>(GetExecutor(user, denyReplacement), GetExecutorReplaced(user, denyReplacement));
			Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> pair = users.Find((Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> u) => u.First != null && u.First.Id == CS_0024_003C_003E8__locals0.addUser.First.Id);
			if (pair == null)
			{
				users.Add(CS_0024_003C_003E8__locals0.addUser);
			}
			else if (CS_0024_003C_003E8__locals0.addUser.Second == null)
			{
				pair.Second = null;
			}
		}
	}

	public static EleWise.ELMA.Security.Models.IUser GetExecutor<T>(T entity, Expression<Func<T, object>> expr, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement) where T : IEntity
	{
		if (denyReplacement || user.ReplacementMode != ReplacementMode.AutoReplacement || user.ReplacementUser == null)
		{
			return user;
		}
		return ReplacementRuleManager.Instance.AssignmentReplacementRule(entity, expr, user.Replacement) ?? user.ReplacementUser;
	}

	[Obsolete("Метод устарел, вместо него необходимо использовать одноимённый с другими параметрами")]
	public static EleWise.ELMA.Security.Models.IUser GetExecutor(EleWise.ELMA.Security.Models.IUser user, bool denyReplacement)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return user;
			case 2:
				if (!denyReplacement)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				if (HGdZuEV9cFBhyBl3uf8(user) == ReplacementMode.AutoReplacement)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				if (rmakq8VIaOx2L3TNW0t(user) != null)
				{
					return (EleWise.ELMA.Security.Models.IUser)rmakq8VIaOx2L3TNW0t(user);
				}
				num2 = 3;
				break;
			}
		}
	}

	public static EleWise.ELMA.Security.Models.IUser GetExecutorReplaced(EleWise.ELMA.Security.Models.IUser user, bool denyReplacement)
	{
		//Discarded unreachable code: IL_0045
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (denyReplacement)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			default:
				return null;
			case 2:
				if (HGdZuEV9cFBhyBl3uf8(user) == ReplacementMode.AutoReplacement)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (rmakq8VIaOx2L3TNW0t(user) != null)
				{
					return user;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static EleWise.ELMA.Security.Models.IUser GetReplacementUser<T>(T entity, Expression<Func<T, object>> expr, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement) where T : IEntity
	{
		return GetReplacementUser(entity, expr, user, denyReplacement, denyReplacementInTask: false);
	}

	public static EleWise.ELMA.Security.Models.IUser GetReplacementUser<T>(T entity, Expression<Func<T, object>> expr, EleWise.ELMA.Security.Models.IUser user, bool denyReplacement, bool denyReplacementInTask) where T : IEntity
	{
		return ((user != null && !denyReplacement && !denyReplacementInTask && user.ReplacementMode == ReplacementMode.AutoReplacement) ? (ReplacementRuleManager.Instance.AssignmentReplacementRule(entity, expr, user.Replacement) ?? user.ReplacementUser) : null) ?? user;
	}

	public ReplacementManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xCvIAQVfKX2k7gNEg2R();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LB5EC3VCr0DeAnMFejw()
	{
		return PAjbZKVv585Vi0ZvqCO == null;
	}

	internal static ReplacementManager wvEljoVUqCPDyllob1E()
	{
		return PAjbZKVv585Vi0ZvqCO;
	}

	internal static object hhw2WfVoCKvsnxCHoeJ()
	{
		return ReplacementRuleManager.Instance;
	}

	internal static void JKVdENVJFTs9KpZeMOf(object P_0, object P_1)
	{
		((ReplacementRuleManager)P_0).CreateDefaultRules((IReplacement)P_1);
	}

	internal static object CmEHxbVKhvTJRKWWjfA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LCgrCIVtJ774SMxc54l(object P_0)
	{
		return ((IReplacement)P_0).SourceUser;
	}

	internal static void trlRjDVhdyTDBGcnyLN(object P_0, object P_1)
	{
		((IUnionComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static object Hee2pgVO2aIu8cnBJG9(object P_0)
	{
		return ((IReplacement)P_0).TargetUser;
	}

	internal static object F8gUswVqk6dEXo3lhg9(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object kgEuddVcIXSANMW16sq(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object cOtaBqVGdOtjXiRaqSE(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static DateTime jKKJXpVFf0YvVyxhOdI()
	{
		return DateTime.Today;
	}

	internal static bool P0BrGrV0udpuncB8XBW(DateTime P_0, DateTime P_1)
	{
		return P_0 <= P_1;
	}

	internal static bool sHS64JVELCYMymWy7AZ(DateTime P_0, DateTime P_1)
	{
		return P_0 >= P_1;
	}

	internal static DateTime cainJ9VDWkThJO3Hgm7(object P_0)
	{
		return ((IReplacement)P_0).EndDate;
	}

	internal static void MVKvfiVMt2tUWdyvHh0(object P_0, ReplacementStatus value)
	{
		((IReplacement)P_0).Status = value;
	}

	internal static void GPY2BPVsXiDfstBvHOV(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object mf2irgVYxUCpvluS1vB(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Replacement;
	}

	internal static object rmakq8VIaOx2L3TNW0t(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).ReplacementUser;
	}

	internal static void gK50QEV4dqnfCpygR5E(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).ReplacementUser = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void Tn88b3VVMSoeTjS9eTa(object P_0, ReplacementMode value)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).ReplacementMode = value;
	}

	internal static void xdc3MQVQ3PjGyopUOML(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Replacement = (IReplacement)P_1;
	}

	internal static object qu4I0NVdPpJjaAdFYLa()
	{
		return UserManager.Instance;
	}

	internal static object UNO354VTf9y9k9gV0lU()
	{
		return FetchOptions.All;
	}

	internal static bool CSEhJUVga6QIdIWdlLP(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object ne68iiV8qmiFMq6DdpO(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object jVlSLDVrdLqiTRlNSPG(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object yDXNUwV3wxQubAIxOkx(object P_0, object P_1)
	{
		return Restrictions.Lt((string)P_0, P_1);
	}

	internal static object xgRSQgVy3VHpWFYMACD(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void ekq6SnVbUULRZT3K3Ry(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object MCo6iAVSWI1D4RATH2Z(object P_0, object P_1)
	{
		return ((EntityManager<IReplacement, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static ReplacementMode HGdZuEV9cFBhyBl3uf8(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).ReplacementMode;
	}

	internal static void xCvIAQVfKX2k7gNEg2R()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class FunctionMetadataItemHeaderManager : EntityManager<FunctionMetadataItemHeader, long>, IFunctionMetadataItemHeaderManager, IEntityManager<FunctionMetadataItemHeader, long>, IEntityManager<FunctionMetadataItemHeader>, IEntityManager
{
	internal static class _Resources_PropertyNames
	{
		public static readonly string Id;

		public static readonly string Uid;

		public static readonly string Name;

		public static readonly string DisplayName;

		public static readonly string Published;

		public static readonly string Draft;

		internal static _Resources_PropertyNames ydQ3N8CM4tR9d9CVlupP;

		static _Resources_PropertyNames()
		{
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 4:
					Id = (string)s0cBwSCM7Nabqpx84jyd(-16752921 ^ -16719943);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					UDgtd8CMAEyDRgouBnif();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					Draft = (string)s0cBwSCM7Nabqpx84jyd(-1870892489 ^ -1870864437);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218467730);
					num2 = 3;
					break;
				case 1:
					Uid = (string)s0cBwSCM7Nabqpx84jyd(0x31326106 ^ 0x31320E94);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 6;
					}
					break;
				default:
					Published = (string)s0cBwSCM7Nabqpx84jyd(0x63ABA4E8 ^ 0x63A9DA72);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					DisplayName = (string)s0cBwSCM7Nabqpx84jyd(-289714582 ^ -289818402);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void UDgtd8CMAEyDRgouBnif()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object s0cBwSCM7Nabqpx84jyd(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool u8RALeCM65yhmJ8wNKWk()
		{
			return ydQ3N8CM4tR9d9CVlupP == null;
		}

		internal static _Resources_PropertyNames aENmHbCMHtksLj57r2lD()
		{
			return ydQ3N8CM4tR9d9CVlupP;
		}
	}

	private readonly ITransformationProvider transformationProvider;

	private static FunctionMetadataItemHeaderManager E1TbPwbsJsaRw29D4IOu;

	public new static FunctionMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<FunctionMetadataItemHeaderManager>();

	public FunctionMetadataItemHeaderManager(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KejFmGbslRvNihHB6V7V();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.transformationProvider = transformationProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		//Discarded unreachable code: IL_004f, IL_005e, IL_0121, IL_0130
		int num = 3;
		int num2 = num;
		object obj = default(object);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 6:
				return 1L;
			case 1:
				if (!(obj is DBNull))
				{
					return Convert.ToInt64(obj) + 1;
				}
				num2 = 6;
				break;
			case 3:
				if (headerId > 0)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 7:
				if (obj == null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			default:
				return 1L;
			case 2:
				text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C979258), Jwfc7Dbs5SXsRtrqm2tn(I0uQrpbsri5G4fDO3gYy(transformationProvider), EfK6wVbsgxTW06DKrmdJ(-1979251663 ^ -1979207037)), headerId);
				num2 = 4;
				break;
			case 4:
				obj = lSJBOAbsYKEpH6nYEik1(((IQuery)ssqEUsbsj2JtFy9vRPtF(base.Session, text)).CleanUpCache(cleanUpCache: false));
				num2 = 7;
				break;
			}
		}
	}

	public virtual bool ValidateName(long headerId, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)PYbGs5bsLl7HEn0NCLqX(_Resources_PropertyNames.Id, headerId), name, out errorMessage);
	}

	public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)PYbGs5bsLl7HEn0NCLqX(_Resources_PropertyNames.Uid, headerUid), name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(long headerId, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)(object)Restrictions.Eq(_Resources_PropertyNames.Id, (object)headerId), displayName, out errorMessage);
	}

	public virtual bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)(object)Restrictions.Eq(_Resources_PropertyNames.Uid, (object)headerUid), displayName, out errorMessage);
	}

	public IEnumerable<FunctionMetadataItemHeader> GetAllPublished()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Published)).List<FunctionMetadataItemHeader>();
	}

	public FunctionMetadataItemHeader Edit(Guid uid, Guid group)
	{
		int num = 3;
		int num2 = num;
		FunctionMetadataItemHeader functionMetadataItemHeader = default(FunctionMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return functionMetadataItemHeader;
			case 3:
				functionMetadataItemHeader = Load(uid);
				num2 = 2;
				break;
			case 1:
				Save(functionMetadataItemHeader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				functionMetadataItemHeader.Group = MetadataItemGroupUIManager.Instance.LoadOrNull(group);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<FunctionMetadataItemHeader> GetAllDrafts()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Draft)).List<FunctionMetadataItemHeader>();
	}

	public override void Delete(FunctionMetadataItemHeader obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (bjnB5ubsUKiy2cUBvZOi(obj) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
				base.Delete(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				throw new InvalidOperationException((string)lVd8IIbssY8ybxsrGpBt(EfK6wVbsgxTW06DKrmdJ(-2138160520 ^ -2138131936)));
			}
		}
	}

	protected virtual bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0051, IL_01bc, IL_01cb, IL_01db, IL_01ea
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					errorMessage = null;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					break;
				case 10:
					return false;
				case 2:
					if (UIlbFVbcGf7R0S2JW2EC(OWUFUGbchs075s5d9PSJ(((ICriteria)vV2mBybcBV6ASwIc56dE(vV2mBybcBV6ASwIc56dE(mcU87HbszRQcZ0SUNLtl(this, null), U3DyUjbcFbKpEB4gy9YB(compareCriterion)), nOOCyibcobK4M6xAvEC7(NwOsVXbcWgwdAnaFbtcY(_Resources_PropertyNames.Name), name))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)P4Ve2qbcb2lHB1yjEqXZ(_Resources_PropertyNames.Id) }))) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 7:
					if (!QLFPXUbscgcEHZRFuHxj(name))
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 3:
					return true;
				default:
					errorMessage = SR.T((string)EfK6wVbsgxTW06DKrmdJ(0x103FE975 ^ 0x103CE10F));
					num2 = 8;
					continue;
				case 6:
					Contract.ArgumentNotNull(compareCriterion, (string)EfK6wVbsgxTW06DKrmdJ(0x66F566B6 ^ 0x66F59780));
					num2 = 5;
					continue;
				case 8:
					return false;
				case 1:
					errorMessage = (string)lVd8IIbssY8ybxsrGpBt(EfK6wVbsgxTW06DKrmdJ(-1459557599 ^ -1459611013));
					num2 = 11;
					continue;
				case 11:
					return false;
				case 4:
					if (name.IsValidIdentifier())
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				break;
			}
			errorMessage = (string)lVd8IIbssY8ybxsrGpBt(EfK6wVbsgxTW06DKrmdJ(-2138958856 ^ -2138903708));
			num = 10;
		}
	}

	protected virtual bool ValidateDisplayName(ICriterion compareCriterion, string displayName, out string errorMessage)
	{
		//Discarded unreachable code: IL_00fb, IL_010a, IL_011a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 4:
				if (UIlbFVbcGf7R0S2JW2EC(OWUFUGbchs075s5d9PSJ(((ICriteria)vV2mBybcBV6ASwIc56dE(vV2mBybcBV6ASwIc56dE(mcU87HbszRQcZ0SUNLtl(this, null), U3DyUjbcFbKpEB4gy9YB(compareCriterion)), nOOCyibcobK4M6xAvEC7(NwOsVXbcWgwdAnaFbtcY(_Resources_PropertyNames.DisplayName), displayName))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)P4Ve2qbcb2lHB1yjEqXZ(_Resources_PropertyNames.Id) }))) > 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 7:
				return true;
			case 5:
				errorMessage = (string)lVd8IIbssY8ybxsrGpBt(EfK6wVbsgxTW06DKrmdJ(0x1C9495B4 ^ 0x1C946776));
				num2 = 8;
				break;
			case 6:
				errorMessage = (string)lVd8IIbssY8ybxsrGpBt(EfK6wVbsgxTW06DKrmdJ(0x4EA5403C ^ 0x4EA5B298));
				num2 = 3;
				break;
			case 8:
				return false;
			case 1:
				errorMessage = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!string.IsNullOrEmpty(displayName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 2:
				hZ1G6EbcESbGPmnS4UDn(compareCriterion, EfK6wVbsgxTW06DKrmdJ(0x5F3078B6 ^ 0x5F308980));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void KejFmGbslRvNihHB6V7V()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sJP2Rsbs9VP8KbbuGs3x()
	{
		return E1TbPwbsJsaRw29D4IOu == null;
	}

	internal static FunctionMetadataItemHeaderManager LZAWZRbsdsVnKgnFThB0()
	{
		return E1TbPwbsJsaRw29D4IOu;
	}

	internal static object I0uQrpbsri5G4fDO3gYy(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object EfK6wVbsgxTW06DKrmdJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Jwfc7Dbs5SXsRtrqm2tn(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object ssqEUsbsj2JtFy9vRPtF(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object lSJBOAbsYKEpH6nYEik1(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static object PYbGs5bsLl7HEn0NCLqX(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object bjnB5ubsUKiy2cUBvZOi(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Published;
	}

	internal static object lVd8IIbssY8ybxsrGpBt(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool QLFPXUbscgcEHZRFuHxj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object mcU87HbszRQcZ0SUNLtl(object P_0, object P_1)
	{
		return ((EntityManager<FunctionMetadataItemHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object U3DyUjbcFbKpEB4gy9YB(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object vV2mBybcBV6ASwIc56dE(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object NwOsVXbcWgwdAnaFbtcY(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object nOOCyibcobK4M6xAvEC7(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((IProjection)P_0, P_1);
	}

	internal static object P4Ve2qbcb2lHB1yjEqXZ(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static object OWUFUGbchs075s5d9PSJ(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static long UIlbFVbcGf7R0S2JW2EC(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void hZ1G6EbcESbGPmnS4UDn(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}

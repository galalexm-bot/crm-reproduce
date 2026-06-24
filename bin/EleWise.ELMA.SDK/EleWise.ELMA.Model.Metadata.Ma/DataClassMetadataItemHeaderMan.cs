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
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class DataClassMetadataItemHeaderManager : EntityManager<DataClassMetadataItemHeader, long>, IDataClassMetadataItemHeaderManager, IEntityManager<DataClassMetadataItemHeader, long>, IEntityManager<DataClassMetadataItemHeader>, IEntityManager
{
	internal static class _Resources_PropertyNames
	{
		public static readonly string Id;

		public static readonly string Uid;

		public static readonly string Name;

		public static readonly string DisplayName;

		public static readonly string Published;

		public static readonly string Draft;

		private static _Resources_PropertyNames HO4ZBhCMokY4O9kXSNs2;

		static _Resources_PropertyNames()
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						Draft = (string)QxceOgCMEaUGdfSKijB6(0x3B36AB09 ^ 0x3B3606F5);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 5;
						}
						continue;
					case 4:
						Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767716293);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 7;
						}
						continue;
					case 5:
						return;
					case 6:
						break;
					case 3:
						eiAZXyCMGqwc3YYIeSg6();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 2;
						}
						continue;
					case 7:
						DisplayName = (string)QxceOgCMEaUGdfSKijB6(-2112703338 ^ -2112863710);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						Published = (string)QxceOgCMEaUGdfSKijB6(0x53FA00CE ^ 0x53F87E54);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						Id = (string)QxceOgCMEaUGdfSKijB6(-629844702 ^ -629812100);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					break;
				}
				Uid = (string)QxceOgCMEaUGdfSKijB6(0x31326106 ^ 0x31320E94);
				num = 4;
			}
		}

		internal static void eiAZXyCMGqwc3YYIeSg6()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object QxceOgCMEaUGdfSKijB6(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool WP7UZWCMb4CfflPC3R41()
		{
			return HO4ZBhCMokY4O9kXSNs2 == null;
		}

		internal static _Resources_PropertyNames zgFxfXCMhned760DOFtO()
		{
			return HO4ZBhCMokY4O9kXSNs2;
		}
	}

	internal static DataClassMetadataItemHeaderManager pOsY8wbU1q5v6P1iCY6E;

	public new static DataClassMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<DataClassMetadataItemHeaderManager>();

	public IEnumerable<DataClassMetadataItemHeader> GetAllPublished()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Published)).List<DataClassMetadataItemHeader>();
	}

	public IEnumerable<DataClassMetadataItemHeader> GetAllDrafts()
	{
		return CreateCriteria(new FetchOptions(0, 0)
		{
			FetchRelations = new List<string>
			{
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108005918),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103CEC47)
			}
		}, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Draft)).List<DataClassMetadataItemHeader>();
	}

	public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)(object)Restrictions.Eq(_Resources_PropertyNames.Uid, (object)headerUid), name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)cgnM98bUpKvcXl89U1ZZ(_Resources_PropertyNames.Uid, headerUid), displayName, out errorMessage);
	}

	public virtual long GetNewPublishingVersionNumber(long headerId)
	{
		//Discarded unreachable code: IL_00f0, IL_00ff
		int num = 6;
		int num2 = num;
		object obj = default(object);
		string text = default(string);
		ITransformationProvider service = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj == null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 3:
				obj = i9wHv4bUwQ412e8AOI92(((IQuery)UtnJ9RbUt4Uw0lGoyeXA(base.Session, text)).CleanUpCache(cleanUpCache: false));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return 1L;
			case 6:
				if (headerId <= 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 4;
					}
				}
				else
				{
					service = Locator.GetService<ITransformationProvider>();
					num2 = 7;
				}
				break;
			case 5:
				return 1L;
			case 2:
				if (!(obj is DBNull))
				{
					return XIO59PbU4C2K9XPukAcl(obj) + 1;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				text = string.Format((string)I0JYeGbUaMwxx6V76TWl(-420743386 ^ -420941196), (service != null) ? ((Dialect)VlfSP3bUDpj5TLMOKWAq(service)).QuoteIfNeeded((string)I0JYeGbUaMwxx6V76TWl(-583745292 ^ -583764410)) : I0JYeGbUaMwxx6V76TWl(0x1DE3DD89 ^ 0x1DE36B3B), headerId);
				num2 = 3;
				break;
			}
		}
	}

	public DataClassMetadataItemHeader Edit(Guid uid, Guid groupUid)
	{
		int num = 1;
		int num2 = num;
		DataClassMetadataItemHeader dataClassMetadataItemHeader = default(DataClassMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dataClassMetadataItemHeader = Load(uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				FMUrbXbUHlBw7K2vp7RE(dataClassMetadataItemHeader, ((AbstractNHEntityManager<MetadataItemGroupUI, long>)LkmJ8ebU6JgfaKVFgt1t()).LoadOrNull(groupUid));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return dataClassMetadataItemHeader;
			case 2:
				Save(dataClassMetadataItemHeader);
				num2 = 3;
				break;
			}
		}
	}

	public override void Delete(DataClassMetadataItemHeader obj)
	{
		//Discarded unreachable code: IL_0046, IL_0055
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (sJlH8ObUAo3cq1CpHjG9(obj) == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 0:
				return;
			case 1:
				throw new InvalidOperationException((string)S9EfDobU7WqfT4ZDuSuY(I0JYeGbUaMwxx6V76TWl(0x34A6D230 ^ 0x34A62268)));
			case 2:
				base.Delete(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0148, IL_0157
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return false;
				case 9:
					return true;
				case 5:
					return false;
				case 4:
					if (XIO59PbU4C2K9XPukAcl(s117BObUl90ldNci3kEF(xij2TybUdVdUjOWjjMlP(dPsG0CbUM8CRKQwytWjv(dPsG0CbUM8CRKQwytWjv(z0V8IbbUmWYT4MnuaRiN(this, null), wtfTptbUyn7ME8Vnl7oe(compareCriterion)), fJjNZGbUJEG9AeXmgOK9(Projections.Property(_Resources_PropertyNames.Name), name)), new IProjection[1] { (IProjection)A2YTaYbU9DAoGOXjMqeC(_Resources_PropertyNames.Id) }))) > 0)
					{
						errorMessage = SR.T((string)I0JYeGbUaMwxx6V76TWl(--1418440330 ^ 0x5488A980));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 6;
						}
					}
					continue;
				case 3:
					goto end_IL_0012;
				case 6:
					errorMessage = null;
					num2 = 9;
					continue;
				case 1:
					bP90prbUxZRH5xS5J55e(compareCriterion, I0JYeGbUaMwxx6V76TWl(0x637E299B ^ 0x637ED8AD));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return false;
				default:
					if (!string.IsNullOrEmpty(name))
					{
						if (BdDKkobU08nB1Am6fdFa(name))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num2 = 4;
							}
							continue;
						}
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					break;
				}
				errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138225590));
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			errorMessage = SR.T((string)I0JYeGbUaMwxx6V76TWl(-1751176224 ^ -1751372286));
			num = 8;
		}
	}

	private bool ValidateDisplayName(ICriterion compareCriterion, string displayName, out string errorMessage)
	{
		//Discarded unreachable code: IL_0043
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 3:
				if (string.IsNullOrEmpty(displayName))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 2;
					}
					break;
				}
				if (XIO59PbU4C2K9XPukAcl(s117BObUl90ldNci3kEF(((ICriteria)dPsG0CbUM8CRKQwytWjv(z0V8IbbUmWYT4MnuaRiN(this, null), Restrictions.Not(compareCriterion))).Add((ICriterion)fJjNZGbUJEG9AeXmgOK9(quTB49bUrIp317JwxqnG(_Resources_PropertyNames.DisplayName), displayName)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)A2YTaYbU9DAoGOXjMqeC(_Resources_PropertyNames.Id) }))) > 0)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 4:
				Contract.ArgumentNotNull(compareCriterion, (string)I0JYeGbUaMwxx6V76TWl(-475857671 ^ -475918897));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return false;
			case 6:
				errorMessage = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return true;
			case 7:
				errorMessage = (string)S9EfDobU7WqfT4ZDuSuY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088238382));
				num2 = 2;
				break;
			case 5:
				errorMessage = SR.T((string)I0JYeGbUaMwxx6V76TWl(0x49E27B8A ^ 0x49E17E68));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public DataClassMetadataItemHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C3qujhbUgYBovNgP2TjS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QA709mbUNJbP34tdRLUi()
	{
		return pOsY8wbU1q5v6P1iCY6E == null;
	}

	internal static DataClassMetadataItemHeaderManager zpRRATbU3aOMZHFeRcs4()
	{
		return pOsY8wbU1q5v6P1iCY6E;
	}

	internal static object cgnM98bUpKvcXl89U1ZZ(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object I0JYeGbUaMwxx6V76TWl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VlfSP3bUDpj5TLMOKWAq(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object UtnJ9RbUt4Uw0lGoyeXA(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object i9wHv4bUwQ412e8AOI92(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static long XIO59PbU4C2K9XPukAcl(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object LkmJ8ebU6JgfaKVFgt1t()
	{
		return MetadataItemGroupUIManager.Instance;
	}

	internal static void FMUrbXbUHlBw7K2vp7RE(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static object sJlH8ObUAo3cq1CpHjG9(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Published;
	}

	internal static object S9EfDobU7WqfT4ZDuSuY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void bP90prbUxZRH5xS5J55e(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool BdDKkobU08nB1Am6fdFa(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object z0V8IbbUmWYT4MnuaRiN(object P_0, object P_1)
	{
		return ((EntityManager<DataClassMetadataItemHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object wtfTptbUyn7ME8Vnl7oe(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object dPsG0CbUM8CRKQwytWjv(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object fJjNZGbUJEG9AeXmgOK9(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((IProjection)P_0, P_1);
	}

	internal static object A2YTaYbU9DAoGOXjMqeC(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static object xij2TybUdVdUjOWjjMlP(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object s117BObUl90ldNci3kEF(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static object quTB49bUrIp317JwxqnG(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static void C3qujhbUgYBovNgP2TjS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

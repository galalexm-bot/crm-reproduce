using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

[Service(Type = ComponentType.Server, EnableInterceptors = false)]
internal sealed class DataClassTypeReferenceManager : NHManager, IDataClassTypeReferenceManager, IDataClassMetadataTypeReferenceService
{
	internal static DataClassTypeReferenceManager yJcls9bLrbG3LSZEiNwG;

	public long Save(DataClassTypeReference dataClassTypeReference)
	{
		int num = 4;
		int num2 = num;
		Guid guid = default(Guid);
		DataClassTypeReference dataClassTypeReference2 = default(DataClassTypeReference);
		while (true)
		{
			switch (num2)
			{
			case 5:
				guid = qR4J7ibLsgBuR22Dt99s(dataClassTypeReference);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (Ln44Q2bLc1H0eovhB9KI(guid, Guid.Empty))
				{
					num2 = 2;
					break;
				}
				goto IL_00ae;
			case 4:
				a5iXJubLYVBxm3YLayCd(dataClassTypeReference, xnSkfPbLjpgyU0kFRXwV(0x571EA399 ^ 0x571DA143));
				num2 = 3;
				break;
			case 1:
				if (dataClassTypeReference2 != null)
				{
					num2 = 6;
					break;
				}
				goto IL_00ae;
			case 6:
				return M7C88vbLzZZDXbiFrLic(dataClassTypeReference2);
			case 3:
				jix7OgbLUuufisNXVUmi(KMAAHxbLLh9mqZm8ahu0(dataClassTypeReference) != Guid.Empty, xnSkfPbLjpgyU0kFRXwV(0x34185E55 ^ 0x341B5D5F));
				num2 = 5;
				break;
			case 2:
				{
					dataClassTypeReference2 = FindByItemUid(guid, KMAAHxbLLh9mqZm8ahu0(dataClassTypeReference));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_00ae:
				return (long)P1u0SPbUFnbGprCsf710(base.Session, dataClassTypeReference);
			}
		}
	}

	public DataClassTypeReference LoadOrNull(string id)
	{
		int num = 2;
		int num2 = num;
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.ArgumentNotNullOrEmpty(id, (string)xnSkfPbLjpgyU0kFRXwV(-675505729 ^ -675435835));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return base.Session.Get<DataClassTypeReference>((object)result);
			case 1:
				if (!long.TryParse(id, out result))
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DataClassTypeReference FindByItemUid(Guid itemUid, Guid metadataUid)
	{
		return ((ICriteria)MyfP8tbUWNNH4sQQdgjM(MyfP8tbUWNNH4sQQdgjM(base.Session.CreateCriteria<DataClassTypeReference>(), vMlfWcbUB5YG4ZU88Pgr(xnSkfPbLjpgyU0kFRXwV(-867826612 ^ -867939302), itemUid)), vMlfWcbUB5YG4ZU88Pgr(xnSkfPbLjpgyU0kFRXwV(-1123633026 ^ -1123749774), metadataUid))).UniqueResult<DataClassTypeReference>();
	}

	public DataClassTypeReference FindByMetadataUid(Guid metadataUid)
	{
		return ((ICriteria)MyfP8tbUWNNH4sQQdgjM(base.Session.CreateCriteria<DataClassTypeReference>(), vMlfWcbUB5YG4ZU88Pgr(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20245243), metadataUid))).UniqueResult<DataClassTypeReference>();
	}

	public Guid? GetMetadataUid(string typeRef)
	{
		return LoadOrNull(typeRef)?.MetadataUid;
	}

	public DataClassTypeReference[] FindReferencesByItemUid(Guid[] itemUid)
	{
		return ((ICriteria)MyfP8tbUWNNH4sQQdgjM(base.Session.CreateCriteria<DataClassTypeReference>(), g4iVSrbUo4fYqkWPPVsj(xnSkfPbLjpgyU0kFRXwV(-105199646 ^ -105345100), itemUid))).List<DataClassTypeReference>().ToArray();
	}

	public DataClassTypeReferenceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lZdSpjbUbMF79D9Rk20y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object xnSkfPbLjpgyU0kFRXwV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void a5iXJubLYVBxm3YLayCd(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid KMAAHxbLLh9mqZm8ahu0(object P_0)
	{
		return ((DataClassTypeReference)P_0).MetadataUid;
	}

	internal static void jix7OgbLUuufisNXVUmi(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static Guid qR4J7ibLsgBuR22Dt99s(object P_0)
	{
		return ((DataClassTypeReference)P_0).ItemUid;
	}

	internal static bool Ln44Q2bLc1H0eovhB9KI(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static long M7C88vbLzZZDXbiFrLic(object P_0)
	{
		return ((DataClassTypeReference)P_0).Id;
	}

	internal static object P1u0SPbUFnbGprCsf710(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static bool JBFpKgbLg17dKsyhQ1dZ()
	{
		return yJcls9bLrbG3LSZEiNwG == null;
	}

	internal static DataClassTypeReferenceManager IPWMHcbL52A7N3jTZb80()
	{
		return yJcls9bLrbG3LSZEiNwG;
	}

	internal static object vMlfWcbUB5YG4ZU88Pgr(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object MyfP8tbUWNNH4sQQdgjM(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object g4iVSrbUo4fYqkWPPVsj(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static void lZdSpjbUbMF79D9Rk20y()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

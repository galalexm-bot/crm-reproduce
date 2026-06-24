using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

public abstract class BaseEntityUserTypeSelector : IEntityUserTypeSelector
{
	internal static BaseEntityUserTypeSelector CtkZd813MEJ9s5B3EDZ;

	public abstract Type EntityType { get; }

	public abstract string Prefix { get; }

	public abstract string DisplayName { get; }

	public virtual IEntity<long> GetEntity(string value)
	{
		string fullPrefix = GetFullPrefix();
		if (!value.Contains(fullPrefix))
		{
			return null;
		}
		long num = Convert.ToInt64(value.Replace(fullPrefix, ""));
		return (IEntity<long>)EntityHelper.GetEntityManager(EntityType).Load(num);
	}

	public abstract List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value);

	public virtual string PrefixedValue(IEntity<long> entity)
	{
		return string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EAE816 ^ 0x61EA951E), GetFullPrefix(), entity.Id);
	}

	public virtual string GetFullPrefix()
	{
		return (string)es1Jxx19SLcvWIRbo6x(iCjAme1SBvaOpOMx9oK(this));
	}

	public static string ExtractFullPrefix(string value)
	{
		return (string)es1Jxx19SLcvWIRbo6x(a57c4G1f5Uk8XRclcwK(value));
	}

	public static string ExtractPrefix(string value)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 3;
		int num2 = num;
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (array.Length >= 2)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				array = (string[])OL5PZY1zZicYMFZv3EW(value, new string[1] { (string)qJeosC11eyDy2jOvLgM(0x116C2699 ^ 0x116C6B93) }, StringSplitOptions.RemoveEmptyEntries);
				num2 = 2;
				break;
			default:
				return null;
			case 1:
				return array[0];
			}
		}
	}

	public static IEntity<long> LoadEntity(string value)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.prefix = ExtractPrefix(value);
		return ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault((IEntityUserTypeSelector s) => _003C_003Ec__DisplayClass12_0.skdvIGpoJU5QQSdjLVq0(s.Prefix, CS_0024_003C_003E8__locals0.prefix))?.GetEntity(value);
	}

	public static IEntity<long> LoadEntity(string value, Type entityType)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.entityType = entityType;
		return ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault((IEntityUserTypeSelector s) => _003C_003Ec__DisplayClass13_0.teJfXYpoccF9Lh1anX0Q(_003C_003Ec__DisplayClass13_0.BrNaNVpoqYxYg6wn8TyP(s), CS_0024_003C_003E8__locals0.entityType))?.GetEntity(value);
	}

	public static List<EleWise.ELMA.Security.Models.IUser> GetUsers(string value)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.prefix = ExtractPrefix(value);
		return ComponentManager.Current.GetExtensionPoints<IEntityUserTypeSelector>().FirstOrDefault((IEntityUserTypeSelector s) => _003C_003Ec__DisplayClass14_0.qFZbvOpoM9sDSeOsy2pb(_003C_003Ec__DisplayClass14_0.GNK85mpoDQhtPo02FSRc(s), CS_0024_003C_003E8__locals0.prefix))?.ExtractUsers(value);
	}

	public static string GetFullPrefix(string prefix)
	{
		return (string)hBM9wczkMfGrUShSUoW(qJeosC11eyDy2jOvLgM(0x4D3A45F ^ 0x4D2B7AF), prefix);
	}

	public static long GetObjectId(string prefix, string value)
	{
		return iBk2UBzp0Uq5DBsqb6n(value.Replace(prefix, ""));
	}

	protected BaseEntityUserTypeSelector()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kBCPuIz5E1k5tJnHqG5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object iCjAme1SBvaOpOMx9oK(object P_0)
	{
		return ((BaseEntityUserTypeSelector)P_0).Prefix;
	}

	internal static object es1Jxx19SLcvWIRbo6x(object P_0)
	{
		return GetFullPrefix((string)P_0);
	}

	internal static bool CEYFSF1yJscQnX8TRLH()
	{
		return CtkZd813MEJ9s5B3EDZ == null;
	}

	internal static BaseEntityUserTypeSelector mjEGGV1brViLKs1yZhy()
	{
		return CtkZd813MEJ9s5B3EDZ;
	}

	internal static object a57c4G1f5Uk8XRclcwK(object P_0)
	{
		return ExtractPrefix((string)P_0);
	}

	internal static object qJeosC11eyDy2jOvLgM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OL5PZY1zZicYMFZv3EW(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object hBM9wczkMfGrUShSUoW(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static long iBk2UBzp0Uq5DBsqb6n(object P_0)
	{
		return Convert.ToInt64((string)P_0);
	}

	internal static void kBCPuIz5E1k5tJnHqG5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

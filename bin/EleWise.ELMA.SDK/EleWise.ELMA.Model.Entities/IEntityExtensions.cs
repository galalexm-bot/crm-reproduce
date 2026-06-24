using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using Iesi.Collections.Generic;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

public static class IEntityExtensions
{
	internal static IEntityExtensions TrjljRhuxd1wwxHJL7IW;

	public static bool Same<IdT>(this IEntity<IdT> same, IEntity<IdT> target) where IdT : struct
	{
		if (same == target)
		{
			return true;
		}
		if (same == null || target == null)
		{
			return false;
		}
		return same.Id.Equals(target.Id);
	}

	public static TypeSettings GetSettingsFor<TModel, TValue>(this TModel entity, Expression<Func<TModel, TValue>> expression) where TModel : IEntity
	{
		if (entity == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146549881));
		}
		IPropertyMetadata propertyMetadata = GetPropertyMetadata(typeof(TModel), expression.Body);
		return entity.GetPropertySettings(propertyMetadata.PropertyUid);
	}

	public static TablePartExtensionsContainer<TItem> ForTablePart<TModel, TItem>(this TModel entity, Expression<Func<TModel, ISet<TItem>>> expression) where TModel : IEntity where TItem : IEntity
	{
		return new TablePartExtensionsContainer<TItem>(entity);
	}

	internal static IPropertyMetadata GetPropertyMetadata(Type entityType, Expression expression)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0175
		int num = 6;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propertyMetadata != null)
				{
					num2 = 3;
					break;
				}
				goto case 8;
			case 7:
				if (_003C_003Ec__DisplayClass3_.memberExpression != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 9;
			case 5:
				if (entityType == null)
				{
					num2 = 2;
					break;
				}
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4E1FF3), vuWmPAhuyc7ewTPurIJR(0x53FA00CE ^ 0x53F9435C), ExY4RVhuJCT5YK0e8K5y(RABEEfhuMtMBuf1Ccgij(_003C_003Ec__DisplayClass3_.memberExpression))));
			case 3:
				return propertyMetadata;
			case 9:
				throw new ArgumentException(SR.T((string)vuWmPAhuyc7ewTPurIJR(-561074844 ^ -561197412), vuWmPAhuyc7ewTPurIJR(-87337865 ^ -87549979)));
			case 4:
				propertyMetadata = classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetPropertyMetadata_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 5;
				break;
			default:
				_003C_003Ec__DisplayClass3_.memberExpression = expression as MemberExpression;
				num2 = 7;
				break;
			case 2:
				throw new ArgumentNullException((string)vuWmPAhuyc7ewTPurIJR(0x4785BC0D ^ 0x47856F99));
			}
		}
	}

	internal static object vuWmPAhuyc7ewTPurIJR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RABEEfhuMtMBuf1Ccgij(object P_0)
	{
		return ((MemberExpression)P_0).Member;
	}

	internal static object ExY4RVhuJCT5YK0e8K5y(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool qYWDQWhu0xgkMYXwAWwu()
	{
		return TrjljRhuxd1wwxHJL7IW == null;
	}

	internal static IEntityExtensions g3pUVuhumVGKOVLgjXWK()
	{
		return TrjljRhuxd1wwxHJL7IW;
	}
}

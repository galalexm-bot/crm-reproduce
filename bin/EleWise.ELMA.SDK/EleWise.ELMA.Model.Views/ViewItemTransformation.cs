using System;
using System.Linq.Expressions;
using System.Web.Script.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[Component]
public abstract class ViewItemTransformation : BaseTransformation<ViewItem, Guid>, IXsiRoot
{
	private static ViewItemTransformation b8Oou8o1kOaGsfPXvvaK;

	public string SerializeToJson()
	{
		return (string)Kg4P2Ko12pS1I1oyw7u2(new ViewItemTransformationSerializer(), this);
	}

	public static ViewItemTransformation DeserializeFromJson(string json)
	{
		return (ViewItemTransformation)KqV3eGo1Pqcr0shB6wT3(new ViewItemTransformationSerializer(), json, uBokIfo1efl8qZ6K0DiE(typeof(ViewItemTransformation).TypeHandle));
	}

	public static ViewItemTransformationAdd Add(Guid itemUid, ViewItem item, Guid? afterItem = null, Guid? beforeItem = null)
	{
		return new ViewItemTransformationAdd
		{
			Uid = itemUid,
			Item = item,
			AfterItem = afterItem,
			BeforeItem = beforeItem
		};
	}

	public static ViewItemTransformationMove Move(Guid itemUid, Guid moveItemUid, Guid? afterItem = null, Guid? beforeItem = null)
	{
		return new ViewItemTransformationMove
		{
			Uid = itemUid,
			MoveItemUid = moveItemUid,
			AfterItem = afterItem,
			BeforeItem = beforeItem
		};
	}

	public static ViewItemTransformationHide Hide(Guid itemUid)
	{
		return new ViewItemTransformationHide
		{
			Uid = itemUid
		};
	}

	public static ViewItemTransformationChange SetPropertyValue(Guid itemUid, string propertyName, object value)
	{
		ViewItemTransformationChange obj = new ViewItemTransformationChange
		{
			Uid = itemUid,
			PropertyName = propertyName
		};
		xFLnSro11tqbxt8LNBR4(obj, value);
		return obj;
	}

	protected ViewItemTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oJMWoLo1NjNk3nrtbjj1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Kg4P2Ko12pS1I1oyw7u2(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static bool ll0m5So1nRDrDusAWh03()
	{
		return b8Oou8o1kOaGsfPXvvaK == null;
	}

	internal static ViewItemTransformation i1c8AWo1OBM4PkjQREXS()
	{
		return b8Oou8o1kOaGsfPXvvaK;
	}

	internal static Type uBokIfo1efl8qZ6K0DiE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object KqV3eGo1Pqcr0shB6wT3(object P_0, object P_1, Type P_2)
	{
		return ((JavaScriptSerializer)P_0).Deserialize((string)P_1, P_2);
	}

	internal static void xFLnSro11tqbxt8LNBR4(object P_0, object P_1)
	{
		((ViewItemTransformationChange)P_0).Value = P_1;
	}

	internal static void oJMWoLo1NjNk3nrtbjj1()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
public class ViewItemTransformation<TItem> where TItem : ViewItem
{
	private static object i1vHTSo13KuaeVtUiaXN;

	public static ViewItemTransformationChange SetPropertyValue<T>(Guid itemUid, Expression<Func<TItem, T>> property, T value)
	{
		MemberExpression memberExpression = ((property != null) ? LinqUtils.GetMemberExpression(property) : null);
		bool localizable = false;
		if (memberExpression != null && memberExpression.Member != null && memberExpression.Member.IsDefined(typeof(LocalizableAttribute), inherit: true))
		{
			localizable = true;
		}
		return new ViewItemTransformationChange
		{
			Uid = itemUid,
			PropertyName = LinqUtils.FullNameOf(property),
			Localizable = localizable,
			Value = value
		};
	}

	public ViewItemTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Q7LDNyo1psu5sEcwVIia()
	{
		return i1vHTSo13KuaeVtUiaXN == null;
	}

	internal static object lPLGWRo1aUEy6fnkDHbl()
	{
		return i1vHTSo13KuaeVtUiaXN;
	}
}

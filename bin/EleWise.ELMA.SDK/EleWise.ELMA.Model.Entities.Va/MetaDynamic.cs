using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Accessors;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class MetaDynamic : DynamicMetaObject
{
	private readonly GetPropertyAccessorDelegate getPropertyAccessor;

	private static MetaDynamic OseSWohSDu2QgTvdcDsT;

	public MetaDynamic(Expression expression, IValueContainerObjectInternal value, GetPropertyAccessorDelegate getPropertyAccessor)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(expression, BindingRestrictions.Empty, value);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.getPropertyAccessor = getPropertyAccessor;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
	{
		//Discarded unreachable code: IL_0066, IL_00bc
		int num = 2;
		int num2 = num;
		IAccessor accessor = default(IAccessor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				accessor = (IAccessor)SaAlZNhS6SjUG60GBVeQ(getPropertyAccessor, zqBLbUhS4sX4baE8N7ZH(binder));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return (DynamicMetaObject)sNpCINhS0C5MjMEvPPew(binder, this, new DynamicMetaObject(Expression.Block((Expression)myLMKahSH7xVYsTku4lS(accessor, base.Expression)), (BindingRestrictions)UmDNuNhSxHf5RNDrLLuD(GetRestriction(), Sv461fhS79MLMO1jEf09(SHFxnbhSAIXtUsAJ3TfM(binder, this)))));
			default:
				return (DynamicMetaObject)tu16r2hSmK7DwikMdlrF(this, binder);
			case 1:
				if (accessor == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 4:
				if (!accessor.HasGetter)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
	{
		//Discarded unreachable code: IL_0108, IL_0117
		int num = 3;
		int num2 = num;
		IAccessor accessor = default(IAccessor);
		while (true)
		{
			switch (num2)
			{
			default:
				m9VtKnhSJBOTxBcQnJIq(dFPomnhSMTGa66BdQyRe(typeof(object).TypeHandle), null);
				num2 = 4;
				break;
			case 1:
				if (!accessor.HasSetter)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 2:
				if (accessor != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 4:
				return (DynamicMetaObject)sCmCguhSguhAKiFKvYv7(binder, this, value, new DynamicMetaObject((Expression)HI0CNyhSlb3NENv61vf7(new Expression[1] { (Expression)JrPk9UhSdTpluy0j4BwG(accessor, jm3WpIhS9K9ZquIdKRyt(this), value.Expression) }), GetRestriction().Merge((BindingRestrictions)Sv461fhS79MLMO1jEf09(ErTYowhSrbqdGPs2WJHn(binder, this, value)))));
			case 5:
				return base.BindSetMember(binder, value);
			case 3:
				accessor = (IAccessor)SaAlZNhS6SjUG60GBVeQ(getPropertyAccessor, IKtUvRhSy9fR7ve11t18(binder));
				num2 = 2;
				break;
			}
		}
	}

	internal BindingRestrictions GetRestriction()
	{
		//Discarded unreachable code: IL_008a, IL_0099
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (base.Value != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			default:
				if (!J2EVfRhS56anrD8hJcP0(this))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return (BindingRestrictions)a5Zk1ahSLelLAF3OLIOG(jm3WpIhS9K9ZquIdKRyt(this), null);
			case 1:
			case 2:
				return (BindingRestrictions)sHaJ7BhSYtbVR8NGyTrT(jm3WpIhS9K9ZquIdKRyt(this), FT0ujThSjp8NL2hNKxqB(this));
			}
		}
	}

	internal static bool B1YNOQhStaftGtDPlqte()
	{
		return OseSWohSDu2QgTvdcDsT == null;
	}

	internal static MetaDynamic KrnnvhhSwfE0DdQu0jXY()
	{
		return OseSWohSDu2QgTvdcDsT;
	}

	internal static object zqBLbUhS4sX4baE8N7ZH(object P_0)
	{
		return ((GetMemberBinder)P_0).Name;
	}

	internal static object SaAlZNhS6SjUG60GBVeQ(object P_0, object P_1)
	{
		return P_0((string)P_1);
	}

	internal static object myLMKahSH7xVYsTku4lS(object P_0, object P_1)
	{
		return ((IAccessor)P_0).GetExpression((Expression)P_1);
	}

	internal static object SHFxnbhSAIXtUsAJ3TfM(object P_0, object P_1)
	{
		return ((GetMemberBinder)P_0).FallbackGetMember((DynamicMetaObject)P_1);
	}

	internal static object Sv461fhS79MLMO1jEf09(object P_0)
	{
		return ((DynamicMetaObject)P_0).Restrictions;
	}

	internal static object UmDNuNhSxHf5RNDrLLuD(object P_0, object P_1)
	{
		return ((BindingRestrictions)P_0).Merge((BindingRestrictions)P_1);
	}

	internal static object sNpCINhS0C5MjMEvPPew(object P_0, object P_1, object P_2)
	{
		return ((GetMemberBinder)P_0).FallbackGetMember((DynamicMetaObject)P_1, (DynamicMetaObject)P_2);
	}

	internal static object tu16r2hSmK7DwikMdlrF(object P_0, object P_1)
	{
		return ((DynamicMetaObject)P_0).BindGetMember((GetMemberBinder)P_1);
	}

	internal static object IKtUvRhSy9fR7ve11t18(object P_0)
	{
		return ((SetMemberBinder)P_0).Name;
	}

	internal static Type dFPomnhSMTGa66BdQyRe(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object m9VtKnhSJBOTxBcQnJIq(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object jm3WpIhS9K9ZquIdKRyt(object P_0)
	{
		return ((DynamicMetaObject)P_0).Expression;
	}

	internal static object JrPk9UhSdTpluy0j4BwG(object P_0, object P_1, object P_2)
	{
		return ((IAccessor)P_0).SetExpression((Expression)P_1, (Expression)P_2);
	}

	internal static object HI0CNyhSlb3NENv61vf7(object P_0)
	{
		return Expression.Block((Expression[])P_0);
	}

	internal static object ErTYowhSrbqdGPs2WJHn(object P_0, object P_1, object P_2)
	{
		return ((SetMemberBinder)P_0).FallbackSetMember((DynamicMetaObject)P_1, (DynamicMetaObject)P_2);
	}

	internal static object sCmCguhSguhAKiFKvYv7(object P_0, object P_1, object P_2, object P_3)
	{
		return ((SetMemberBinder)P_0).FallbackSetMember((DynamicMetaObject)P_1, (DynamicMetaObject)P_2, (DynamicMetaObject)P_3);
	}

	internal static bool J2EVfRhS56anrD8hJcP0(object P_0)
	{
		return ((DynamicMetaObject)P_0).HasValue;
	}

	internal static Type FT0ujThSjp8NL2hNKxqB(object P_0)
	{
		return ((DynamicMetaObject)P_0).LimitType;
	}

	internal static object sHaJ7BhSYtbVR8NGyTrT(object P_0, Type P_1)
	{
		return BindingRestrictions.GetTypeRestriction((Expression)P_0, P_1);
	}

	internal static object a5Zk1ahSLelLAF3OLIOG(object P_0, object P_1)
	{
		return BindingRestrictions.GetInstanceRestriction((Expression)P_0, P_1);
	}
}

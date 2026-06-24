using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours;

internal abstract class DeltaRestartBaseBehaviour : IPublicationBehaviourChecker
{
	private static DeltaRestartBaseBehaviour ebs6UobrW7DEVWkWGkJ5;

	public abstract PublicationType Check(CheckType action, object oldValue, object newValue);

	protected PublicationType Check(PublicationType type, CheckType action, object oldValue, object newValue)
	{
		//Discarded unreachable code: IL_00ff, IL_010e, IL_01d0, IL_022e, IL_0241, IL_040f, IL_041e
		int num = 30;
		PublicationType publicationType = default(PublicationType);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IEnumerable<object> enumerable2 = default(IEnumerable<object>);
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		string text = default(string);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					return publicationType;
				case 13:
					if (!kDrrUObrh41dPHZ2xaab(newValue, _003C_003Ec__DisplayClass1_.type))
					{
						num2 = 2;
						continue;
					}
					return PublicationType.Delta;
				case 2:
					return PublicationType.Restart;
				case 12:
					if (oldValue == null)
					{
						num2 = 26;
						continue;
					}
					goto IL_03ea;
				case 20:
					if (publicationType == PublicationType.Delta)
					{
						return _003C_003Ec__DisplayClass1_.type;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 28;
					}
					continue;
				case 29:
					_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
					num2 = 21;
					continue;
				case 21:
					_003C_003Ec__DisplayClass1_.type = type;
					num2 = 24;
					continue;
				case 27:
					enumerable2 = ((IEnumerable)newValue).Cast<object>();
					num2 = 14;
					continue;
				case 11:
					if (newValue != null)
					{
						num = 6;
						break;
					}
					goto case 1;
				case 3:
					if (!oldValue.Equals(newValue))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					return PublicationType.Soft;
				case 8:
					if (!enumerable.SequenceEqual(enumerable2, FunctorEqualityComparer<object>.Create(_003C_003Ec__DisplayClass1_._003CCheck_003Eb__0)))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					return PublicationType.Soft;
				case 5:
					return PublicationType.Delta;
				case 10:
				case 22:
				case 31:
					if (oldValue == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 14:
					if (enumerable.Count() == enumerable2.Count())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 23;
				case 16:
					if (!MFHHFcbrG8oLDT71yClM(text, string.Empty))
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 5;
				case 26:
					if (newValue == null)
					{
						num2 = 19;
						continue;
					}
					goto IL_03ea;
				case 23:
					return _003C_003Ec__DisplayClass1_.type;
				case 9:
					publicationType = tYOUn2brCr0gbDdJkRQl(oldValue, newValue);
					num = 20;
					break;
				case 4:
					if (_003C_003Ec__DisplayClass1_.action != 0)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 13;
				case 25:
					if (type2.IsClass)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 30:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 29;
					}
					continue;
				case 24:
					_003C_003Ec__DisplayClass1_.action = action;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 4;
					}
					continue;
				case 17:
					enumerable = ((IEnumerable)oldValue).Cast<object>();
					num2 = 27;
					continue;
				case 6:
					if (Y5cGrbbrEsS6MWx2Z0BM(oldValue.GetType(), newValue.GetType()))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 18;
						}
					}
					else
					{
						type2 = oldValue.GetType();
						num2 = 25;
					}
					continue;
				case 7:
					return _003C_003Ec__DisplayClass1_.type;
				case 15:
					if ((text = newValue as string) == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 16;
				default:
					if (!LrnhXTbrQ94Wgb7BOF4L(type2, qxHa82brfSHFLmvoU5jS(typeof(string).TypeHandle)))
					{
						if (!(oldValue is IEnumerable))
						{
							num2 = 9;
							continue;
						}
						goto case 17;
					}
					num2 = 3;
					continue;
				case 19:
					return PublicationType.Soft;
				case 1:
				case 18:
					{
						return _003C_003Ec__DisplayClass1_.type;
					}
					IL_03ea:
					if (oldValue != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 15;
				}
				break;
			}
		}
	}

	protected DeltaRestartBaseBehaviour()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kDrrUObrh41dPHZ2xaab(object P_0, PublicationType type)
	{
		return MetadataSoftPublishHelper.IsNewValuesDelta(P_0, type);
	}

	internal static bool MFHHFcbrG8oLDT71yClM(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static bool Y5cGrbbrEsS6MWx2Z0BM(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type qxHa82brfSHFLmvoU5jS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool LrnhXTbrQ94Wgb7BOF4L(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static PublicationType tYOUn2brCr0gbDdJkRQl(object P_0, object P_1)
	{
		return MetadataSoftPublishHelper.IsEqualsObject(P_0, P_1);
	}

	internal static bool WRh9FDbrodnnWOZoM0Mu()
	{
		return ebs6UobrW7DEVWkWGkJ5 == null;
	}

	internal static DeltaRestartBaseBehaviour u2O0Llbrb9mC6QUrJBuq()
	{
		return ebs6UobrW7DEVWkWGkJ5;
	}
}

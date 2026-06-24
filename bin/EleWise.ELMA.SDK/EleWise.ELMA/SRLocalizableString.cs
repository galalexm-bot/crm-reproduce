using System;
using System.Globalization;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;

namespace EleWise.ELMA;

public static class SRLocalizableString
{
	private class InternalLocalizableString : LocalizableString
	{
		private readonly object srm;

		private static object uGnob6f76ToA45E7tikt;

		public InternalLocalizableString(string srm)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			DRZt6if77fPhgnaQjZDv();
			((LocalizableString)this)._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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
					this.srm = srm;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		protected override bool AreEqual(object other)
		{
			//Discarded unreachable code: IL_0042, IL_0051
			int num = 1;
			int num2 = num;
			InternalLocalizableString internalLocalizableString = default(InternalLocalizableString);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return BAerqZf7xEyCnWLmjUJv(internalLocalizableString.srm, srm);
				default:
					return false;
				case 1:
					if ((internalLocalizableString = other as InternalLocalizableString) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		protected override int GetHash()
		{
			return srm.GetHashCode();
		}

		protected override string GetText(IFormatProvider formatProvider)
		{
			return (string)iATSZnf70S2d7N6dfjiS(formatProvider as CultureInfo, srm);
		}

		internal static void DRZt6if77fPhgnaQjZDv()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool RCuC3kf7Hp7eUkoNk4nu()
		{
			return uGnob6f76ToA45E7tikt == null;
		}

		internal static InternalLocalizableString X90Kj5f7Au0Ai1B2wmRl()
		{
			return (InternalLocalizableString)uGnob6f76ToA45E7tikt;
		}

		internal static bool BAerqZf7xEyCnWLmjUJv(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object iATSZnf70S2d7N6dfjiS(object P_0, object P_1)
		{
			return SR.T((CultureInfo)P_0, (string)P_1);
		}
	}

	public static LocalizableString ToLocalizableString(this string srm)
	{
		return (LocalizableString)(object)new InternalLocalizableString(srm);
	}
}

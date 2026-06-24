using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using log4net.Core;
using log4net.Filter;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public class Log4NetAndFilter : FilterSkeleton
{
	private readonly IList<IFilter> filters;

	internal static Log4NetAndFilter gBLRn4h9LwW09v0v4ZIW;

	public IFilter Filter
	{
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
				case 0:
					return;
				case 1:
					filters.Add(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override FilterDecision Decide(LoggingEvent loggingEvent)
	{
		//Discarded unreachable code: IL_0085, IL_008f, IL_00d3, IL_00e2, IL_0170, IL_01a8, IL_01b7
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_012b: Invalid comparison between Unknown and I4
		int num = 4;
		int num2 = num;
		bool flag = default(bool);
		IEnumerator<IFilter> enumerator = default(IEnumerator<IFilter>);
		FilterDecision result = default(FilterDecision);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new ArgumentNullException((string)FRLG0oh9cuSpunqILUk0(-541731959 ^ -541702835));
			default:
				return (FilterDecision)0;
			case 4:
				if (loggingEvent != null)
				{
					flag = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 3;
							}
							goto IL_0093;
						}
						goto IL_0113;
						IL_0113:
						FilterDecision val = enumerator.Current.Decide(loggingEvent);
						if ((int)val != 1)
						{
							flag = false;
						}
						if ((int)val != -1)
						{
							continue;
						}
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num3 = 0;
						}
						goto IL_0093;
						IL_0093:
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 2:
								result = (FilterDecision)(-1);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							case 4:
								goto IL_0113;
							case 3:
								goto end_IL_00ed;
							}
							break;
						}
						continue;
						end_IL_00ed:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								z3Y6Gch9zWQxaSvN2EnU(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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
				goto case 5;
			case 5:
				if (flag)
				{
					return (FilterDecision)1;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				enumerator = filters.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public Log4NetAndFilter()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		D5U1DShdFSEhcekdmycW();
		filters = new List<IFilter>();
		((FilterSkeleton)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object FRLG0oh9cuSpunqILUk0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void z3Y6Gch9zWQxaSvN2EnU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool NwR3hwh9UvVULyHmQKuG()
	{
		return gBLRn4h9LwW09v0v4ZIW == null;
	}

	internal static Log4NetAndFilter G3Hxn8h9sGVsXoPO1GjF()
	{
		return gBLRn4h9LwW09v0v4ZIW;
	}

	internal static void D5U1DShdFSEhcekdmycW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

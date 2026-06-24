using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Service(Type = ComponentType.Server)]
internal sealed class PerformanceCategoryRegistrar : IPerformanceCategoryRegistrar
{
	public static readonly string DefaultCategoryName;

	private static readonly string CategoryHelp;

	private readonly IEnumerable<IPerformanceCounter> counters;

	private readonly ILogger logger;

	internal static PerformanceCategoryRegistrar YgyjUIGzTvVO1XBPLQ6I;

	public PerformanceCategoryRegistrar(IEnumerable<IPerformanceCounter> counters, ILogger logger)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.counters = counters;
		this.logger = logger;
	}

	public void CheckRegisterDefault()
	{
		//Discarded unreachable code: IL_00f1, IL_0100, IL_0110, IL_011f, IL_01bf, IL_033b, IL_0370, IL_037f, IL_038c, IL_039b
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IEnumerable<CounterCreationData> enumerable = counters.SelectMany((IPerformanceCounter c) => c.GetCreationData());
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				bool flag = default(bool);
				while (true)
				{
					switch (num)
					{
					case 3:
						return;
					case 8:
						return;
					case 2:
						CreateCategory(DefaultCategoryName, CategoryHelp, PerformanceCounterCategoryType.SingleInstance, enumerable);
						num = 3;
						break;
					case 1:
					case 4:
						if (!flag)
						{
							num = 8;
							break;
						}
						goto case 2;
					case 5:
					{
						dKUO9HGz20bHtlNabc0U(DefaultCategoryName);
						int num3 = 6;
						num = num3;
						break;
					}
					case 6:
						flag = true;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num = 0;
						}
						break;
					default:
					{
						bool num2 = UmiQ8lGzOdXmQC32t6Od(DefaultCategoryName);
						flag = !num2;
						if (!num2)
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num = 4;
							}
							break;
						}
						goto case 7;
					}
					case 7:
						if (!enumerable.All((CounterCreationData c) => PerformanceCounterCategory.CounterExists((string)_003C_003Ec.yXrPGU8V34rFuPCrkx67(c), DefaultCategoryName)))
						{
							num = 5;
							break;
						}
						goto case 1;
					}
				}
			}
			catch (Exception ex)
			{
				int num4 = 2;
				string fullPath = default(string);
				while (true)
				{
					switch (num4)
					{
					case 3:
					case 6:
						SjGEXyGz17ZjTMWf47AV(logger, tl2ARiGzN1Thdr5nUfJx(P7J6qJGzP44TMd2LY7hY(0xA592A41 ^ 0xA5D0983)), ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num4 = 1;
						}
						break;
					case 2:
						if (!(ex is SecurityException))
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 5;
					case 5:
						fullPath = Path.GetFullPath(Path.Combine((string)xC70ToGzev5Nh6woR3fU(AppDomain.CurrentDomain), (string)P7J6qJGzP44TMd2LY7hY(0x269E5FCA ^ 0x269A7D84), (string)P7J6qJGzP44TMd2LY7hY(-1852837372 ^ -1853108150), (string)P7J6qJGzP44TMd2LY7hY(0x3A5D5EF ^ 0x3A1F7B9), (string)P7J6qJGzP44TMd2LY7hY(-583745292 ^ -583998824), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D183C74)));
						num4 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num4 = 7;
						}
						break;
					case 7:
						SjGEXyGz17ZjTMWf47AV(logger, SR.T((string)P7J6qJGzP44TMd2LY7hY(0x3C5338FF ^ 0x3C571A43), fullPath), ex);
						num4 = 4;
						break;
					default:
						if (!(ex is UnauthorizedAccessException))
						{
							num4 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 5;
					case 1:
					case 4:
						throw;
					}
				}
			}
		}
	}

	public string GetMissingCountersFileName()
	{
		return (string)BlrUZhGzpAX9b9FXD7P3(IS0XV0Gz3nOLaTb0KB3I(), P7J6qJGzP44TMd2LY7hY(-87337865 ^ -87068615));
	}

	public void CreateCategory(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, IEnumerable<CounterCreationData> allCreationData)
	{
		try
		{
			PerformanceCounterCategory.Create(categoryName, categoryHelp, categoryType, new CounterCreationDataCollection(allCreationData.ToArray()));
		}
		catch (Exception ex)
		{
			if (ex is SecurityException || ex is UnauthorizedAccessException)
			{
				AppendToMissingFile(categoryName, categoryHelp, categoryType, allCreationData);
			}
			throw;
		}
	}

	private void AppendToMissingFile(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, IEnumerable<CounterCreationData> allCreationData)
	{
		try
		{
			string missingCountersFileName = GetMissingCountersFileName();
			CategoriesInfo categoriesInfo = new CategoriesInfo();
			if (File.Exists(missingCountersFileName))
			{
				categoriesInfo = ClassSerializationHelper.DeserializeObjectByJsonNet<CategoriesInfo>(File.ReadAllText(missingCountersFileName));
			}
			categoriesInfo.Categories.Add(new CategoryInfo
			{
				CategoryName = categoryName,
				CategoryHelp = categoryHelp,
				CountersData = allCreationData.Select(CounterInfo.From).ToList()
			});
			string contents = ClassSerializationHelper.SerializeObjectByJsonNet(categoriesInfo);
			File.WriteAllText(missingCountersFileName, contents);
		}
		catch (Exception exception)
		{
			logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF6231)), exception);
		}
	}

	static PerformanceCategoryRegistrar()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				break;
			case 1:
				return;
			default:
				CategoryHelp = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426349519));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DefaultCategoryName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313232F2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UmiQ8lGzOdXmQC32t6Od(object P_0)
	{
		return PerformanceCounterCategory.Exists((string)P_0);
	}

	internal static void dKUO9HGz20bHtlNabc0U(object P_0)
	{
		PerformanceCounterCategory.Delete((string)P_0);
	}

	internal static object xC70ToGzev5Nh6woR3fU(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object P7J6qJGzP44TMd2LY7hY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void SjGEXyGz17ZjTMWf47AV(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object tl2ARiGzN1Thdr5nUfJx(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool YypulbGzktU7TlYrwBnQ()
	{
		return YgyjUIGzTvVO1XBPLQ6I == null;
	}

	internal static PerformanceCategoryRegistrar WTRjW3GznHlxNULc2bO5()
	{
		return YgyjUIGzTvVO1XBPLQ6I;
	}

	internal static object IS0XV0Gz3nOLaTb0KB3I()
	{
		return IOExtensions.GetTempPath();
	}

	internal static object BlrUZhGzpAX9b9FXD7P3(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}
}

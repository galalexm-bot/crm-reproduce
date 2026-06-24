using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.CodeAnalyzers;

public sealed class DataClassUsageAnalyzer : IAnalyzerWithResult
{
	private readonly UsageAnalyzer usageAnalyzer;

	private IDictionary<string, DataClassMetadata> dataClassMetadataList;

	private static DataClassUsageAnalyzer PlrfXIfRPR2EpOtYcqwn;

	private IDictionary<string, DataClassMetadata> DataClassMetadataList => dataClassMetadataList ?? (dataClassMetadataList = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<DataClassMetadata>()
		group m by (string)_003C_003Ec.ilTcHW8jjxLUOmqyZMcf(m)).ToDictionary((IGrouping<string, DataClassMetadata> g) => g.Key, (IGrouping<string, DataClassMetadata> g) => g.First()));

	public ICodeAnalyzerResult CodeAnalyzerResult { get; }

	public DataClassUsageAnalyzer()
	{
		//Discarded unreachable code: IL_002a
		FhPw8XfR3rGCuAdVx7FV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				CodeAnalyzerResult = new CodeAnalyzerResult();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
			usageAnalyzer = new UsageAnalyzer(delegate(SemanticModel s, SyntaxNode n)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						CheckIfDataClass(s, n);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}, ProcessSymbol);
			int num2 = 2;
			num = num2;
		}
	}

	public static implicit operator DiagnosticAnalyzer(DataClassUsageAnalyzer analyzer)
	{
		return (DiagnosticAnalyzer)(object)analyzer.usageAnalyzer;
	}

	private (ISymbol, DataClassMetadata) CheckIfDataClass(SemanticModel semanticModel, SyntaxNode node)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (node == null)
		{
			return (null, null);
		}
		SymbolInfo symbolInfo = ModelExtensions.GetSymbolInfo(semanticModel, node, default(CancellationToken));
		ISymbol symbol = ((SymbolInfo)(ref symbolInfo)).get_Symbol();
		if (symbol == null)
		{
			return (null, null);
		}
		ISymbol val = symbol;
		if (val != null)
		{
			IPropertySymbol val2;
			if ((val2 = (IPropertySymbol)(object)((val is IPropertySymbol) ? val : null)) != null)
			{
				IPropertySymbol val3 = val2;
				(ISymbol, DataClassMetadata) result = InternalCheck((ISymbol)(object)val3.get_Type());
				(ISymbol, DataClassMetadata) result2 = InternalCheck((ISymbol)(object)symbol.get_ContainingType());
				if (result2.Item2 == null)
				{
					return result;
				}
				return result2;
			}
			ITypeSymbol val4;
			if ((val4 = (ITypeSymbol)(object)((val is ITypeSymbol) ? val : null)) != null)
			{
				ITypeSymbol val5 = val4;
				return InternalCheck((ISymbol)(object)val5.get_OriginalDefinition());
			}
		}
		return InternalCheck((ISymbol)(object)symbol.get_ContainingType());
		(ISymbol, DataClassMetadata) InternalCheck(ISymbol type)
		{
			if (type == null)
			{
				return (symbol, null);
			}
			if (!DataClassMetadataList.TryGetValue(((object)type).ToString(), out var value))
			{
				return (symbol, null);
			}
			if (!CodeAnalyzerResult.ReferenceMetadata.ContainsKey(value))
			{
				CodeAnalyzerResult.ReferenceMetadata[value] = new List<IPropertyMetadata>();
			}
			return (symbol, value);
		}
	}

	private void ProcessSymbol(SemanticModel semanticModel, SyntaxNode syntax, string propertyName)
	{
		//Discarded unreachable code: IL_008e, IL_009d, IL_00d9, IL_00e8, IL_0122, IL_0131, IL_0141
		int num = 3;
		DataClassMetadata item2 = default(DataClassMetadata);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		IPropertySymbol val = default(IPropertySymbol);
		ISymbol item = default(ISymbol);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 17:
					CodeAnalyzerResult.ReferenceMetadata[item2] = new List<IPropertyMetadata>();
					num2 = 13;
					break;
				case 1:
					return;
				case 18:
					return;
				case 12:
					return;
				case 0:
					return;
				case 7:
					return;
				case 4:
					if (_003C_003Ec__DisplayClass10_.property != null)
					{
						num2 = 16;
						break;
					}
					return;
				case 5:
				case 13:
					if (CodeAnalyzerResult.ReferenceMetadata[item2].FirstOrDefault(_003C_003Ec__DisplayClass10_._003CProcessSymbol_003Eb__1) == null)
					{
						goto end_IL_0012;
					}
					num2 = 6;
					break;
				case 6:
					return;
				case 10:
					if (item2 != null)
					{
						if ((val = (IPropertySymbol)(object)((item is IPropertySymbol) ? item : null)) == null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num2 = 15;
							}
							break;
						}
						if (kWTT9mfRpOEwehPbkF7K(val) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 11;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 7;
					}
					break;
				case 14:
					if (item == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 10;
				case 8:
					return;
				case 16:
					if (CodeAnalyzerResult.ReferenceMetadata.ContainsKey(item2))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 17;
				case 3:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				case 11:
					if (jUcUbgfRaFSLXGsIuWrQ(val) != null)
					{
						_003C_003Ec__DisplayClass10_.property = item2.Properties.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CProcessSymbol_003Eb__0);
						num2 = 4;
					}
					else
					{
						num2 = 12;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass10_.propertyName = propertyName;
					num2 = 9;
					break;
				case 9:
				{
					(ISymbol, DataClassMetadata) tuple = CheckIfDataClass(semanticModel, syntax);
					item = tuple.Item1;
					item2 = tuple.Item2;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 13;
					}
					break;
				}
				case 15:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			CodeAnalyzerResult.ReferenceMetadata[item2].Add(_003C_003Ec__DisplayClass10_.property);
			num = 18;
		}
	}

	internal static void FhPw8XfR3rGCuAdVx7FV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zGgR9xfR111Kppfrjlrc()
	{
		return PlrfXIfRPR2EpOtYcqwn == null;
	}

	internal static DataClassUsageAnalyzer Wg349DfRNhixaElDwMvS()
	{
		return PlrfXIfRPR2EpOtYcqwn;
	}

	internal static object kWTT9mfRpOEwehPbkF7K(object P_0)
	{
		return ((IPropertySymbol)P_0).get_GetMethod();
	}

	internal static object jUcUbgfRaFSLXGsIuWrQ(object P_0)
	{
		return ((IPropertySymbol)P_0).get_SetMethod();
	}
}

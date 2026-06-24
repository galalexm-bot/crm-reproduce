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

public sealed class EnumUsageAnalyzer : IAnalyzerWithResult
{
	private readonly UsageAnalyzer usageAnalyzer;

	private IDictionary<string, EnumMetadata> enumMetadataList;

	internal static EnumUsageAnalyzer l0nU36fR7KF79C8GOHux;

	private IDictionary<string, EnumMetadata> EnumMetadataList => enumMetadataList ?? (enumMetadataList = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<EnumMetadata>()
		group m by (string)_003C_003Ec.GeQhAi8YTTSMa0m3UmWI(m)).ToDictionary((IGrouping<string, EnumMetadata> g) => g.Key, (IGrouping<string, EnumMetadata> g) => g.First()));

	public ICodeAnalyzerResult CodeAnalyzerResult { get; }

	public EnumUsageAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TyNEqyfRmBAJRh5BL58I();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				usageAnalyzer = new UsageAnalyzer(delegate(SemanticModel s, SyntaxNode n)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							CheckIfEnum(s, n);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}, ProcessSymbol);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				CodeAnalyzerResult = new CodeAnalyzerResult();
				num = 2;
				break;
			}
		}
	}

	public static implicit operator DiagnosticAnalyzer(EnumUsageAnalyzer analyzer)
	{
		return (DiagnosticAnalyzer)(object)analyzer.usageAnalyzer;
	}

	private (ISymbol, EnumMetadata) CheckIfEnum(SemanticModel semanticModel, SyntaxNode node)
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
				(ISymbol, EnumMetadata) result = InternalCheck(val3.get_Type());
				(ISymbol, EnumMetadata) result2 = InternalCheck((ITypeSymbol)(object)symbol.get_ContainingType());
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
				return InternalCheck(val5.get_OriginalDefinition());
			}
		}
		return InternalCheck((ITypeSymbol)(object)symbol.get_ContainingType());
		(ISymbol, EnumMetadata) InternalCheck(ITypeSymbol type)
		{
			if (type == null)
			{
				return (symbol, null);
			}
			string text = ((object)type).ToString();
			if (string.IsNullOrWhiteSpace(text))
			{
				return (symbol, null);
			}
			if (!EnumMetadataList.TryGetValue(text, out var value))
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				CheckIfEnum(semanticModel, syntax);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void TyNEqyfRmBAJRh5BL58I()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IgPh12fRxZmjK1BjHjhB()
	{
		return l0nU36fR7KF79C8GOHux == null;
	}

	internal static EnumUsageAnalyzer svVsCXfR0HEa3rLwtn2D()
	{
		return l0nU36fR7KF79C8GOHux;
	}
}

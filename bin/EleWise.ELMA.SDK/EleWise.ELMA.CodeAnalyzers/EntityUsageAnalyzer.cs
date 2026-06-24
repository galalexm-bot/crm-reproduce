using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.CodeAnalyzers;

public abstract class EntityUsageAnalyzer : IAnalyzerWithResult
{
	private readonly UsageAnalyzer usageAnalyzer;

	private IDictionary<string, EntityMetadata> entityMetadataList;

	internal static EntityUsageAnalyzer UbEIrIfRD7NEFnjYJN8U;

	protected virtual IDictionary<string, EntityMetadata> EntityMetadataList => entityMetadataList ?? (entityMetadataList = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
		group m by (string)_003C_003Ec.uHQMG68Yfxmj1QAD29Nd(m)).ToDictionary((IGrouping<string, EntityMetadata> g) => g.Key, (IGrouping<string, EntityMetadata> g) => g.First()));

	public ICodeAnalyzerResult CodeAnalyzerResult { get; }

	public EntityUsageAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		muIuGMfR4i5bq4eaYATw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
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
						CheckIfEntity(s, n);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}, ProcessSymbol);
			num = 2;
		}
	}

	public static implicit operator DiagnosticAnalyzer(EntityUsageAnalyzer analyzer)
	{
		return (DiagnosticAnalyzer)(object)analyzer.usageAnalyzer;
	}

	protected abstract bool CheckModule(IModuleSymbol module);

	private (ISymbol, EntityMetadata) CheckIfEntity(SemanticModel semanticModel, SyntaxNode node)
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
				(ISymbol, EntityMetadata) result = InternalCheck(val3.get_Type());
				(ISymbol, EntityMetadata) result2 = InternalCheck((ITypeSymbol)(object)symbol.get_ContainingType());
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
		(ISymbol, EntityMetadata) InternalCheck(ITypeSymbol type)
		{
			if (type == null)
			{
				return (symbol, null);
			}
			IModuleSymbol containingModule = ((ISymbol)type).get_ContainingModule();
			if (!CheckModule(containingModule))
			{
				return (symbol, null);
			}
			if (!EntityMetadataList.TryGetValue(((object)type).ToString(), out var value))
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
		//Discarded unreachable code: IL_010a, IL_0119, IL_0129, IL_018a, IL_0296, IL_034f
		int num = 5;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		IPropertySymbol val = default(IPropertySymbol);
		EntityMetadata item = default(EntityMetadata);
		IMetadata metadata = default(IMetadata);
		ISymbol item2 = default(ISymbol);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 23:
					if (ohqjOWfRHK420aMqDwjo(_003C_003Ec__DisplayClass11_.property) is EntitySettings)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					return;
				case 11:
					return;
				case 16:
					if (qfUiUIfR6bCx4YZQe0r5(val) == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass11_.property = item.GetAllPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass11_._003CProcessSymbol_003Eb__0);
						num2 = 2;
					}
					continue;
				case 17:
					if (metadata == null)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 13:
					CodeAnalyzerResult.ReferenceMetadata[item] = new List<IPropertyMetadata>();
					num2 = 15;
					continue;
				case 8:
					return;
				case 1:
				{
					(ISymbol, EntityMetadata) tuple = CheckIfEntity(semanticModel, syntax);
					item2 = tuple.Item1;
					item = tuple.Item2;
					num2 = 14;
					continue;
				}
				case 18:
					CodeAnalyzerResult.ReferenceMetadata[metadata] = new List<IPropertyMetadata>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					return;
				case 21:
					return;
				case 2:
					if (_003C_003Ec__DisplayClass11_.property != null)
					{
						num = 6;
						break;
					}
					return;
				case 22:
					if (item == null)
					{
						num2 = 19;
						continue;
					}
					if ((val = (IPropertySymbol)(object)((item2 is IPropertySymbol) ? item2 : null)) == null)
					{
						return;
					}
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 15;
					}
					continue;
				case 14:
					if (item2 == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 22;
				case 9:
					if (CodeAnalyzerResult.ReferenceMetadata.ContainsKey(metadata))
					{
						num2 = 12;
						continue;
					}
					goto case 18;
				case 7:
					return;
				case 6:
					if (!CodeAnalyzerResult.ReferenceMetadata.ContainsKey(item))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 15;
				case 4:
					_003C_003Ec__DisplayClass11_.propertyName = propertyName;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 4;
					continue;
				case 3:
					return;
				case 10:
					metadata = MetadataLoader.LoadMetadataOrNull(Nqa87dfRA2Wg8THg9ZDe(_003C_003Ec__DisplayClass11_.property));
					num2 = 17;
					continue;
				case 0:
					return;
				case 19:
					return;
				case 20:
					return;
				case 15:
					if (CodeAnalyzerResult.ReferenceMetadata[item].FirstOrDefault(_003C_003Ec__DisplayClass11_._003CProcessSymbol_003Eb__1) == null)
					{
						CodeAnalyzerResult.ReferenceMetadata[item].Add(_003C_003Ec__DisplayClass11_.property);
						num2 = 23;
						continue;
					}
					num = 20;
					break;
				}
				break;
			}
		}
	}

	internal static void muIuGMfR4i5bq4eaYATw()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool y8YEX2fRtWqv9PoOsqmU()
	{
		return UbEIrIfRD7NEFnjYJN8U == null;
	}

	internal static EntityUsageAnalyzer tXlVIbfRwQKBp338Ur0v()
	{
		return UbEIrIfRD7NEFnjYJN8U;
	}

	internal static object qfUiUIfR6bCx4YZQe0r5(object P_0)
	{
		return ((IPropertySymbol)P_0).get_GetMethod();
	}

	internal static object ohqjOWfRHK420aMqDwjo(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static Guid Nqa87dfRA2Wg8THg9ZDe(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}
}

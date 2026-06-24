using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CodeAnalyzers.Model;

public static class CodeAnalyzerResultExtension
{
	private static CodeAnalyzerResultExtension xCMAfPfRcerS2FrncrVx;

	public static CodeAnalyzerResult CombineResult(this ICodeAnalyzerResult first, ICodeAnalyzerResult second)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_00db, IL_00ea, IL_00f5, IL_0198, IL_01a7, IL_01ee, IL_020d, IL_021c, IL_0249, IL_0312, IL_0352, IL_0361, IL_036d
		int num = 2;
		IEnumerator<KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>> enumerator = default(IEnumerator<KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>>);
		KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> current = default(KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>);
		CodeAnalyzerResult codeAnalyzerResult = default(CodeAnalyzerResult);
		IMetadata key = default(IMetadata);
		IEnumerator<IPropertyMetadata> enumerator2 = default(IEnumerator<IPropertyMetadata>);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		ICollection<IPropertyMetadata> collection = default(ICollection<IPropertyMetadata>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!DTcmLYfqBHrtnkl2NSVa(enumerator))
							{
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num3 = 2;
								}
								goto IL_0054;
							}
							goto IL_0299;
							IL_0299:
							current = enumerator.Current;
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num3 = 1;
							}
							goto IL_0054;
							IL_0054:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
									codeAnalyzerResult.ReferenceMetadata[key] = new List<IPropertyMetadata>();
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									try
									{
										while (true)
										{
											IL_01b2:
											int num4;
											if (!DTcmLYfqBHrtnkl2NSVa(enumerator2))
											{
												num4 = 5;
												goto IL_00f9;
											}
											goto IL_014f;
											IL_00f9:
											while (true)
											{
												switch (num4)
												{
												default:
													_003C_003Ec__DisplayClass0_.property = enumerator2.Current;
													num4 = 6;
													continue;
												case 4:
													collection.Add(_003C_003Ec__DisplayClass0_.property);
													num4 = 2;
													continue;
												case 1:
													break;
												case 6:
													if (collection.FirstOrDefault(_003C_003Ec__DisplayClass0_._003CCombineResult_003Eb__0) != null)
													{
														num4 = 3;
														continue;
													}
													goto case 4;
												case 2:
												case 3:
													goto IL_01b2;
												case 5:
													goto end_IL_01b2;
												}
												break;
											}
											goto IL_014f;
											IL_014f:
											_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
											{
												num4 = 0;
											}
											goto IL_00f9;
											continue;
											end_IL_01b2:
											break;
										}
									}
									finally
									{
										int num5;
										if (enumerator2 == null)
										{
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
											{
												num5 = 0;
											}
											goto IL_01f2;
										}
										goto IL_0227;
										IL_0227:
										enumerator2.Dispose();
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
										{
											num5 = 1;
										}
										goto IL_01f2;
										IL_01f2:
										switch (num5)
										{
										case 2:
											goto end_IL_01cd;
										case 1:
											goto end_IL_01cd;
										}
										goto IL_0227;
										end_IL_01cd:;
									}
									break;
								case 6:
								{
									collection = codeAnalyzerResult.ReferenceMetadata[key];
									int num6 = 7;
									num3 = num6;
									continue;
								}
								case 7:
									enumerator2 = current.Value.GetEnumerator();
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num3 = 1;
									}
									continue;
								default:
									goto IL_0299;
								case 5:
									key = current.Key;
									num3 = 4;
									continue;
								case 4:
									if (!codeAnalyzerResult.ReferenceMetadata.ContainsKey(key))
									{
										num3 = 3;
										continue;
									}
									goto case 6;
								case 8:
									return codeAnalyzerResult;
								}
								break;
							}
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num7 = 0;
							}
							goto IL_0316;
						}
						goto IL_032c;
						IL_032c:
						enumerator.Dispose();
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num7 = 2;
						}
						goto IL_0316;
						IL_0316:
						switch (num7)
						{
						default:
							goto end_IL_02f1;
						case 1:
							break;
						case 0:
							goto end_IL_02f1;
						case 2:
							goto end_IL_02f1;
						}
						goto IL_032c;
						end_IL_02f1:;
					}
				case 4:
					return codeAnalyzerResult;
				case 2:
					codeAnalyzerResult = new CodeAnalyzerResult();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					codeAnalyzerResult.ReferenceMetadata.AddRange(first.ReferenceMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			enumerator = second.ReferenceMetadata.GetEnumerator();
			num = 3;
		}
	}

	internal static bool DTcmLYfqBHrtnkl2NSVa(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool LeKn04fRzstf7WJaEcU6()
	{
		return xCMAfPfRcerS2FrncrVx == null;
	}

	internal static CodeAnalyzerResultExtension HfDuQkfqFEOfm9jWxUVg()
	{
		return xCMAfPfRcerS2FrncrVx;
	}
}

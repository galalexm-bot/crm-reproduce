using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.DevServer.CodeGeneration;

internal sealed class DataClassGenerator : EleWise.ELMA.Model.CodeGeneration.DataClassGenerator
{
	private static DataClassGenerator kXENJuEOZUsD5AGDLuJj;

	private static DataClassDescriptor DataClassDescriptor => Locator.GetServiceNotNull<DataClassDescriptor>();

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_00b3, IL_012b, IL_0142, IL_019e, IL_01b1
		int num = 1;
		int num2 = num;
		List<DataClassDependency>.Enumerator enumerator = default(List<DataClassDependency>.Enumerator);
		DataClassDependency current = default(DataClassDependency);
		List<ISyntaxTrivia> list = default(List<ISyntaxTrivia>);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num3 = 0;
							}
							goto IL_0058;
						}
						goto IL_0072;
						IL_0072:
						current = enumerator.Current;
						num3 = 3;
						goto IL_0058;
						IL_0058:
						switch (num3)
						{
						case 1:
							goto IL_0072;
						case 3:
							try
							{
								DataClassMetadata dataClassMetadata2 = (DataClassMetadata)vwdbgsEOitHfk1VYcv5A(ak58dnEOVUfRyTB8kEJk(), dvdJQ1EOSFEMM9Ru6B0E(current));
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										list.Add((ISyntaxTrivia)iE43wYEOKSriXhJ9XXeL(YS4MhWEOqdCBDpTAyg5h(HhOugrEOR2W4DIjNu4M6(0x31326106 ^ 0x31363CF6), dataClassMetadata2.FullTypeName)));
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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
							catch (Exception)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							continue;
						case 2:
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 5:
				return;
			case 3:
				enumerator = dataClassMetadata.IncludeList.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				type.TextComments(list);
				num2 = 5;
				break;
			case 1:
				if ((dataClassMetadata = metadata as DataClassMetadata) != null)
				{
					list = new List<ISyntaxTrivia>();
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DataClassGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gnRIZcEOXraTm8qFCPvE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ak58dnEOVUfRyTB8kEJk()
	{
		return DataClassDescriptor;
	}

	internal static Guid dvdJQ1EOSFEMM9Ru6B0E(object P_0)
	{
		return ((Dependency)P_0).HeaderUid;
	}

	internal static object vwdbgsEOitHfk1VYcv5A(object P_0, Guid typeUid)
	{
		return ((DataClassDescriptor)P_0).GetMetadataByUid(typeUid);
	}

	internal static object HhOugrEOR2W4DIjNu4M6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YS4MhWEOqdCBDpTAyg5h(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object iE43wYEOKSriXhJ9XXeL(object P_0)
	{
		return ((string)P_0).TextComment();
	}

	internal static bool Bv6UA3EOujxaeEZIRZln()
	{
		return kXENJuEOZUsD5AGDLuJj == null;
	}

	internal static DataClassGenerator sdWrF6EOI6triR0vc5GH()
	{
		return kXENJuEOZUsD5AGDLuJj;
	}

	internal static void gnRIZcEOXraTm8qFCPvE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

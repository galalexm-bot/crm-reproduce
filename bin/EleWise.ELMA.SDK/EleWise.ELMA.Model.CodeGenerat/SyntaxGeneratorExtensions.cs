using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using EleWise.ELMA.CodeGeneration.CSharp;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class SyntaxGeneratorExtensions
{
	private class MembersComparer : IComparer<Type>
	{
		internal static object kq3x6gvuAkd0tG1gPa41;

		private int? Compare<T>(Type x, Type y)
		{
			if (!(x == TypeOf<T>.Raw) && !x.IsSubclassOf(TypeOf<T>.Raw))
			{
				if (!(y == TypeOf<T>.Raw) && !y.IsSubclassOf(TypeOf<T>.Raw))
				{
					return null;
				}
				return 1;
			}
			return -1;
		}

		public int Compare(Type x, Type y)
		{
			//Discarded unreachable code: IL_00e7, IL_0120
			int num = 1;
			int num2 = num;
			int? num6 = default(int?);
			int? num3 = default(int?);
			int? num4 = default(int?);
			int? num5 = default(int?);
			while (true)
			{
				switch (num2)
				{
				default:
					num6 = Compare<FieldDeclarationSyntax>(x, y);
					num2 = 9;
					break;
				case 5:
					num3 = Compare<PropertyDeclarationSyntax>(x, y);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 2;
					}
					break;
				case 11:
					return 0;
				case 3:
					return num4.GetValueOrDefault();
				case 8:
					return num6.GetValueOrDefault();
				case 6:
					if (num5.HasValue)
					{
						return num5.GetValueOrDefault();
					}
					num2 = 11;
					break;
				case 7:
					num5 = Compare<MethodDeclarationSyntax>(x, y);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (ReEO9Evu0nS8HDRxG6mF(x, y))
					{
						return 0;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					num4 = Compare<ConstructorDeclarationSyntax>(x, y);
					num2 = 4;
					break;
				case 9:
					if (num6.HasValue)
					{
						num2 = 8;
						break;
					}
					goto case 10;
				case 4:
					if (num4.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 5;
				case 2:
					if (num3.HasValue)
					{
						return num3.GetValueOrDefault();
					}
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 7;
					}
					break;
				}
			}
		}

		public MembersComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ERWgmTvumySCSbRrE4Tl();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ReEO9Evu0nS8HDRxG6mF(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static bool aNphM0vu7fC5kbOcMXuf()
		{
			return kq3x6gvuAkd0tG1gPa41 == null;
		}

		internal static MembersComparer pTsiVyvuxFtr1w7rPiNF()
		{
			return (MembersComparer)kq3x6gvuAkd0tG1gPa41;
		}

		internal static void ERWgmTvumySCSbRrE4Tl()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[ThreadStatic]
	private static SyntaxGenerator syntaxGenerator;

	[ThreadStatic]
	private static ICollection<string> ignoreNamespaces;

	internal static SyntaxGeneratorExtensions s2T1WVhPONeogEjGaJy6;

	public static SyntaxGenerator SyntaxGenerator
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_0067, IL_00ef, IL_011f, IL_012e, IL_013a
			int num = 1;
			int num2 = num;
			string obj = default(string);
			bool lockTaken = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 5:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								syntaxGenerator = new SyntaxGenerator();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								if (syntaxGenerator == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num4 = 0;
							}
							goto IL_00f3;
						}
						goto IL_0109;
						IL_0109:
						Monitor.Exit(obj);
						num4 = 2;
						goto IL_00f3;
						IL_00f3:
						switch (num4)
						{
						default:
							goto end_IL_00ce;
						case 1:
							break;
						case 0:
							goto end_IL_00ce;
						case 2:
							goto end_IL_00ce;
						}
						goto IL_0109;
						end_IL_00ce:;
					}
					goto default;
				default:
					return syntaxGenerator;
				case 2:
					lockTaken = false;
					num2 = 5;
					continue;
				case 1:
					if (syntaxGenerator != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					break;
				}
				obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4EAC6F);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public static ISyntaxNode Null => (ISyntaxNode)Swh3l3hPaSDK1GImfyng(mCAYDHhPpuAWwaSQQTa7(NV5IknhPPLNPeCUK2LWr()));

	public static ISyntaxNode This => (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).ThisExpression());

	public static ISyntaxNode Base => (ISyntaxNode)Swh3l3hPaSDK1GImfyng(AXO8nshPDqbtI6gr61R6(NV5IknhPPLNPeCUK2LWr()));

	public static ISyntaxNode Value => (ISyntaxNode)s092OqhPwXvD2xKWydyw(sj4OMPhPtJmCI9JVRDnZ(0x53CACA3 ^ 0x53CE5D5));

	private static ICollection<string> IgnoreNamespaces => ignoreNamespaces ?? new string[0];

	public static byte[] GenerateCSCode(this ISyntaxNode declaration)
	{
		return GenerateCSCode(new ISyntaxNode[1] { declaration });
	}

	public static byte[] GenerateCSCode(params ISyntaxNode[] declarations)
	{
		return declarations.AsEnumerable().GenerateCSCode();
	}

	public static byte[] GenerateCSCode(this IEnumerable<ISyntaxNode> declarations)
	{
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
		SyntaxGenerator.Generate(declarations.Unpack(), streamWriter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F26D5));
		streamWriter.Flush();
		return memoryStream.ToArray();
	}

	public static string GenerateCSCodeString(this ISyntaxNode declaration)
	{
		return GenerateCSCodeString(new ISyntaxNode[1] { declaration });
	}

	public static string GenerateCSCodeString(params ISyntaxNode[] declarations)
	{
		return declarations.AsEnumerable().GenerateCSCodeString();
	}

	public static string GenerateCSCodeString(this IEnumerable<ISyntaxNode> declarations)
	{
		return SyntaxGenerator.Generate(declarations.Unpack(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31313CFA), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822915290));
	}

	public static ISyntaxNode IdentifierName(this string identifier)
	{
		return ((SyntaxNode)CYY0W1hP1FVsdjn6tLgq(NV5IknhPPLNPeCUK2LWr(), identifier)).Pack();
	}

	public static ISyntaxNode GenericName(this string identifier, params ISyntaxNode[] typeArguments)
	{
		return identifier.GenericName(typeArguments.AsEnumerable());
	}

	public static ISyntaxNode GenericName(this string identifier, IEnumerable<ISyntaxNode> typeArguments)
	{
		return SyntaxGenerator.GenericName(identifier, typeArguments.Unpack()).Pack();
	}

	public static bool IsGeneric(this ISyntaxNode declaration)
	{
		return declaration.GetGenericArguments() != null;
	}

	public static string GetGenericIdentifier(this ISyntaxNode declaration)
	{
		int num = 2;
		int num2 = num;
		GenericNameSyntax genericNameSyntax = default(GenericNameSyntax);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (genericNameSyntax == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)jBQrwshP3PTx97TcRmB9(genericNameSyntax);
			default:
				return null;
			case 2:
				genericNameSyntax = XLVF7HhPNnxmdVm1UmsP(declaration) as GenericNameSyntax;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static IEnumerable<ISyntaxNode> GetGenericArguments(this ISyntaxNode declaration)
	{
		TypeSyntax[] array = (declaration.Unpack() as GenericNameSyntax)?.TypeArguments;
		if (array == null || array.Length == 0)
		{
			return null;
		}
		return array.Pack();
	}

	public static void WithIgnoreNamespaces(this ICollection<string> namespaces, Action action)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.action = action;
		namespaces.WithIgnoreNamespaces(delegate
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					CS_0024_003C_003E8__locals0.action();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public static T WithIgnoreNamespaces<T>(this ICollection<string> namespaces, Func<T> action)
	{
		ICollection<string> collection = ignoreNamespaces;
		try
		{
			ignoreNamespaces = namespaces;
			return action();
		}
		finally
		{
			ignoreNamespaces = collection;
		}
	}

	private static void IgnoreNamespace(ref string typeName)
	{
		//Discarded unreachable code: IL_0046, IL_0097, IL_00a6
		int num = 1;
		int num2 = num;
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				obj = null;
				goto IL_00f7;
			case 7:
				if (text == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 1:
				num3 = hDOW0nhP4TCw3bP9J7YK(typeName, '.');
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 5:
				return;
			case 8:
				if (!IgnoreNamespaces.Contains(text))
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (num3 > 0)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 4:
				obj = QQkRvQhP6fpfFLLA4639(typeName, 0, num3);
				goto IL_00f7;
			case 3:
				{
					typeName = (string)((num3 > 0) ? U4M9MshPHK96RJ1Wl1Et(typeName, num3 + 1) : typeName);
					num2 = 5;
					break;
				}
				IL_00f7:
				text = (string)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	private static void AddGlobal(ref string typeName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				typeName = (string)sj4OMPhPtJmCI9JVRDnZ(0x2ACE37D ^ 0x2AD663F) + typeName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (jSEfFqhP7etjIiiZnT5w(typeName, sj4OMPhPtJmCI9JVRDnZ(-1317790512 ^ -1317693038)))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (!NeXC9HhPAilYihGIP9eo(typeName, sj4OMPhPtJmCI9JVRDnZ(0x6DC147B0 ^ 0x6DC15D74)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ISyntaxNode CreateTypeSyntax<T>()
	{
		return TypeOf<T>.Raw.CreateTypeSyntax();
	}

	public static ISyntaxNode CreateTypeSyntax(this Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(type, (string)sj4OMPhPtJmCI9JVRDnZ(0x1C9495B4 ^ 0x1C949996));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (ISyntaxNode)gTDhJXhPxOUxnRrST4OZ(type, useGlobal: true);
			}
		}
	}

	public static ISyntaxNode CreateTypeSyntax(this Type type, bool useGlobal)
	{
		//Discarded unreachable code: IL_0039
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ISyntaxNode)OZGLpRhPy1QT8LFbGgLH(eACjIfhPmu37oVjVtfMl(type.GetElementType()));
			case 3:
				return (ISyntaxNode)QJElImhPMyCQONFOQx7J(type.Name);
			case 2:
				if (type.IsGenericType)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					break;
				}
				return type.CreateTypeSyntax(useGlobal, (ISyntaxNode[])null);
			case 5:
				xxOQsvhP0Bh14afDXB8A(type, sj4OMPhPtJmCI9JVRDnZ(-957824448 ^ -957821342));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (!type.IsArray)
				{
					if (!type.IsGenericParameter)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return type.GetGenericTypeDefinition().CreateTypeSyntax((from t in type.GetGenericArguments()
					select (ISyntaxNode)_003C_003Ec.QOghwWvu59mnKYyPnXWL(t)).ToArray());
			}
		}
	}

	public static ISyntaxNode CreateTypeSyntax(this Type type, params ISyntaxNode[] typeArguments)
	{
		return type.CreateTypeSyntax(useGlobal: true, typeArguments);
	}

	public static ISyntaxNode CreateTypeSyntax(this Type type, bool useGlobal, params ISyntaxNode[] typeArguments)
	{
		return type.FullName.CreateTypeSyntax(useGlobal, typeArguments);
	}

	public static ISyntaxNode CreateTypeSyntax(this string typeName)
	{
		return (ISyntaxNode)CFjP60hPJCjwBVf1HtXL(typeName, true);
	}

	public static ISyntaxNode CreateTypeSyntax(this string typeName, bool useGlobal)
	{
		//Discarded unreachable code: IL_00b9, IL_00c8, IL_00ea, IL_0127, IL_0136, IL_01c6, IL_032a, IL_047a, IL_0489
		int num = 33;
		int num7 = default(int);
		int num6 = default(int);
		ISyntaxNode[] typeArguments = default(ISyntaxNode[]);
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = default(_003C_003Ec__DisplayClass37_0);
		List<string> list2 = default(List<string>);
		List<string> list = default(List<string>);
		int num3 = default(int);
		List<string> list3 = default(List<string>);
		int index = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					if (num7 > 0)
					{
						num2 = 30;
						continue;
					}
					goto case 7;
				case 10:
					typeName = (string)qOWVsVhPdsdqmh36Fp84(typeName, num7);
					num2 = 27;
					continue;
				case 34:
					num6 = 0;
					num2 = 31;
					continue;
				case 19:
					typeArguments = null;
					num2 = 8;
					continue;
				case 8:
					num7 = CXte2nhP94T0O9IAFUZa(typeName, '<');
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 2;
					}
					continue;
				case 32:
					_003C_003Ec__DisplayClass37_.useGlobal = useGlobal;
					num2 = 19;
					continue;
				case 3:
					tJKtTohPrMRj7qlOdqA7(list2, num6 + 1);
					num2 = 18;
					continue;
				case 13:
					tJKtTohPrMRj7qlOdqA7(list, num3 + 1);
					num2 = 15;
					continue;
				case 7:
				case 23:
					return typeName.CreateTypeSyntax(_003C_003Ec__DisplayClass37_.useGlobal, typeArguments);
				case 18:
					num6--;
					num2 = 14;
					continue;
				case 25:
				case 35:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					typeArguments = list2.Select(_003C_003Ec__DisplayClass37_._003CCreateTypeSyntax_003Eb__0).ToArray();
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 23;
					}
					continue;
				case 11:
					list3[index] = list3[index] + (string)sj4OMPhPtJmCI9JVRDnZ(0x5DD55050 ^ 0x5DD502A0) + list[num3 + 1];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
					continue;
				case 36:
					list2 = ((IEnumerable<string>)RDZSHAhPlGC2fywTxxOY(((string)qOWVsVhPdsdqmh36Fp84(typeName, typeName.LastIndexOf('>'))).Substring(num7 + 1), new char[1] { ',' })).ToList();
					num = 29;
					break;
				case 4:
					typeArguments = list.Select(_003C_003Ec__DisplayClass37_._003CCreateTypeSyntax_003Eb__3).ToArray();
					num = 7;
					break;
				case 33:
					_003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
					num2 = 32;
					continue;
				case 28:
					index = num3;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					num3--;
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 27;
					}
					continue;
				case 9:
					list3 = list2;
					num2 = 5;
					continue;
				case 14:
					num6++;
					num2 = 17;
					continue;
				case 26:
					list3[index] = list3[index] + (string)sj4OMPhPtJmCI9JVRDnZ(0x4A1640F ^ 0x4A136FF) + list2[num6 + 1];
					num2 = 3;
					continue;
				case 6:
				case 20:
					if (num3 < LC4DTkhPgmvVqjOgUK1t(list))
					{
						num2 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 17:
				case 31:
					if (num6 >= LC4DTkhPgmvVqjOgUK1t(list2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 27:
					num3 = 0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 20;
					}
					continue;
				case 29:
					typeName = (string)qOWVsVhPdsdqmh36Fp84(typeName, num7);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 34;
					}
					continue;
				case 30:
					list = ((IEnumerable<string>)RDZSHAhPlGC2fywTxxOY(U4M9MshPHK96RJ1Wl1Et(qOWVsVhPdsdqmh36Fp84(typeName, typeName.LastIndexOf(']')), num7 + 1), new char[1] { ',' })).ToList();
					num2 = 10;
					continue;
				case 22:
				case 24:
					num7 = CXte2nhP94T0O9IAFUZa(typeName, '[');
					num = 16;
					break;
				case 12:
					list3 = list;
					num2 = 28;
					continue;
				case 5:
					index = num6;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 26;
					}
					continue;
				case 2:
					if (num7 <= 0)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 36;
				case 21:
				{
					int num8 = list2[num6].Count((char c) => c == '<');
					int num9 = list2[num6].Count((char c) => c == '>');
					if (num8 > num9)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 14;
				}
				case 1:
				case 37:
				{
					int num4 = list[num3].Count((char c) => c == '[');
					int num5 = list[num3].Count((char c) => c == ']');
					if (num4 <= num5)
					{
						num2 = 25;
						continue;
					}
					goto case 12;
				}
				}
				break;
			}
		}
	}

	public static ISyntaxNode CreateTypeSyntax(this string typeName, params ISyntaxNode[] typeArguments)
	{
		return typeName.CreateTypeSyntax(useGlobal: true, typeArguments);
	}

	public static ISyntaxNode CreateTypeSyntax(this string typeName, bool useGlobal, params ISyntaxNode[] typeArguments)
	{
		//Discarded unreachable code: IL_029d, IL_02ac, IL_02bb, IL_02e1, IL_02f0, IL_033b, IL_034a, IL_035a, IL_038f, IL_039e, IL_03c0, IL_0459, IL_04dd, IL_04ec, IL_04fb, IL_0521, IL_0530, IL_0540, IL_054f, IL_0573, IL_0582, IL_0592, IL_05ef, IL_05fe, IL_0611, IL_0620, IL_062f, IL_066e, IL_06a3, IL_0828, IL_0837, IL_0846, IL_0855, IL_0864, IL_0874, IL_0883, IL_08f4, IL_0903, IL_0912, IL_0921, IL_0930, IL_0955, IL_0964, IL_09c6, IL_09d5, IL_0a0b, IL_0a4d, IL_0a5c, IL_0a6b, IL_0b1c, IL_0b2b, IL_0b86, IL_0bba, IL_0cf4, IL_0d70, IL_0d7f, IL_0de0, IL_0def, IL_0dfe, IL_0e0d, IL_0e3f, IL_0e4e, IL_0e5e, IL_0e6d, IL_0e7d, IL_0f1c, IL_0f2b, IL_0f61, IL_0f70, IL_0fab, IL_0fba, IL_0ff3, IL_1002, IL_1011, IL_1021, IL_1056, IL_1065, IL_1127, IL_1176, IL_1185, IL_1194, IL_11ef, IL_11fe, IL_125f, IL_126e, IL_127e, IL_128d, IL_129d, IL_132a, IL_134f, IL_135e, IL_136e, IL_1381, IL_13a4, IL_1419, IL_1428, IL_1438, IL_14ba
		int num = 82;
		uint num4 = default(uint);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 85:
					if (num4 != 423635464)
					{
						num2 = 121;
						continue;
					}
					goto case 116;
				case 67:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C97CB78)))
					{
						num2 = 46;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 12;
				case 14:
				case 148:
					if (num4 != 4180476474u)
					{
						num2 = 94;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 135;
				case 53:
					if (num3 >= 0)
					{
						num2 = 106;
						continue;
					}
					goto case 153;
				case 141:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(0x66F566B6 ^ 0x66F606BA)))
					{
						num2 = 22;
						continue;
					}
					goto case 17;
				case 109:
					if (num4 <= 2185383742u)
					{
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 102;
						}
						continue;
					}
					goto case 86;
				case 122:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099717581)))
					{
						num2 = 55;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 12;
				case 103:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(-281842504 ^ -282054004)))
					{
						num2 = 130;
						continue;
					}
					goto case 12;
				case 150:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(0x34A6D230 ^ 0x34A58DC0)))
					{
						num2 = 157;
						continue;
					}
					goto case 2;
				case 106:
					typeName = (string)qOWVsVhPdsdqmh36Fp84(typeName, num3);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 14;
					}
					continue;
				case 78:
					if (num4 != 3851314394u)
					{
						num2 = 75;
						continue;
					}
					goto case 122;
				case 147:
					IgnoreNamespace(ref typeName);
					num = 100;
					break;
				case 114:
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(SyntaxGenerator.TypeSyntax(typeName, typeArguments.Unpack()));
				case 69:
				case 112:
					return ((SyntaxNode)hGbBWShPYQaNbCPcYU4G(NV5IknhPPLNPeCUK2LWr(), typeName)).Pack();
				case 11:
					if (num4 != 1697786220)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 99;
						}
						continue;
					}
					goto case 26;
				case 62:
					if (typeArguments.Length == 0)
					{
						num = 112;
						break;
					}
					goto case 114;
				case 60:
					if (num4 <= 1625787317)
					{
						num = 16;
						break;
					}
					goto case 11;
				case 16:
					if (num4 != 942540437)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 38;
				case 92:
					if (num4 <= 2711245919u)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 95;
						}
						continue;
					}
					goto case 51;
				case 140:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(0x53CB464B ^ 0x53C81815)))
					{
						goto case 8;
					}
					num2 = 124;
					continue;
				case 45:
					if (num4 != 1615808600)
					{
						num2 = 146;
						continue;
					}
					goto case 67;
				case 1:
					if (num4 != 1324880019)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 45;
						}
						continue;
					}
					goto case 98;
				case 21:
				case 137:
					if (num4 <= 1323747186)
					{
						num2 = 117;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 85;
						}
						continue;
					}
					goto case 1;
				case 15:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-672123589 ^ -671913383)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				case 37:
					if (num4 != 347085918)
					{
						num2 = 101;
						continue;
					}
					goto case 48;
				default:
					if (num4 != 875577056)
					{
						num2 = 74;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 138;
						}
						continue;
					}
					goto case 141;
				case 52:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x5488F0C4)))
					{
						num2 = 129;
						continue;
					}
					goto case 12;
				case 12:
				case 30:
				case 50:
				case 64:
				case 77:
				case 107:
				case 123:
				case 124:
				case 151:
				case 154:
					typeName = (string)sj4OMPhPtJmCI9JVRDnZ(0x4DC2B14D ^ 0x4DC1EF91) + typeName;
					num = 71;
					break;
				case 132:
					if (num4 > 1615808600)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 139;
				case 49:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-70037984 ^ -70250310)))
					{
						num2 = 107;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 61;
						}
						continue;
					}
					goto case 8;
				case 84:
					if (num4 > 3851314394u)
					{
						num2 = 142;
						continue;
					}
					goto case 158;
				case 40:
					AddGlobal(ref typeName);
					num2 = 6;
					continue;
				case 35:
					if (num4 != 4051133705u)
					{
						num2 = 8;
						continue;
					}
					goto case 108;
				case 134:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-1459557599 ^ -1459374751)))
					{
						goto case 8;
					}
					num2 = 123;
					continue;
				case 101:
					if (num4 != 848225627)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 82:
					if (!IgnoreNamespaces.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FB0E90)))
					{
						num = 81;
						break;
					}
					goto case 44;
				case 116:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(-2138160520 ^ -2138235810)))
					{
						num2 = 118;
						continue;
					}
					goto case 12;
				case 38:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(-398663332 ^ -398475580)))
					{
						num = 96;
						break;
					}
					goto case 2;
				case 133:
					if (num4 != 2747029693u)
					{
						num2 = 120;
						continue;
					}
					goto case 27;
				case 43:
					if (num4 != 2185383742u)
					{
						num2 = 31;
						continue;
					}
					goto case 41;
				case 63:
				case 131:
					if (num4 > 3291009739u)
					{
						num2 = 148;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 7;
				case 72:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-1939377524 ^ -1939592042)))
					{
						num2 = 12;
						continue;
					}
					goto case 8;
				case 94:
					if (num4 != 4201364391u)
					{
						num2 = 110;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 58;
						}
						continue;
					}
					goto case 68;
				case 27:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-97972138 ^ -97890544)))
					{
						num2 = 113;
						continue;
					}
					goto case 17;
				case 100:
					if (!useGlobal)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 54;
						}
						continue;
					}
					goto case 40;
				case 5:
				case 56:
					if (num4 <= 3409549631u)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 92;
						}
						continue;
					}
					goto case 84;
				case 86:
					if (num4 != 2249825754u)
					{
						num = 133;
						break;
					}
					goto case 89;
				case 89:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(-1317790512 ^ -1317583876)))
					{
						num2 = 63;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 80;
						}
						continue;
					}
					goto case 2;
				case 76:
					if (typeName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088252918))
					{
						num2 = 73;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 17;
				case 139:
					if (num4 > 697196164)
					{
						num2 = 21;
						continue;
					}
					goto case 85;
				case 74:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-1088304168 ^ -1088252572)))
					{
						num2 = 30;
						continue;
					}
					goto case 8;
				case 143:
					if (num4 != 2711245919u)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 140;
				case 44:
					num4 = j59ZWVhP500j9jGbbWLk(typeName);
					num2 = 132;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 82;
					}
					continue;
				case 2:
				case 22:
				case 61:
				case 73:
				case 79:
				case 93:
				case 113:
				case 136:
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(hGbBWShPYQaNbCPcYU4G(NV5IknhPPLNPeCUK2LWr(), typeName));
				case 17:
				case 31:
				case 36:
				case 42:
				case 59:
				case 65:
				case 70:
				case 80:
				case 83:
				case 87:
				case 90:
				case 96:
				case 104:
				case 105:
				case 110:
				case 120:
				case 126:
				case 127:
				case 138:
				case 144:
				case 157:
					num3 = typeName.IndexOf('`');
					num2 = 53;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 44;
					}
					continue;
				case 121:
					if (num4 != 679076413)
					{
						num2 = 57;
						continue;
					}
					goto case 72;
				case 95:
					if (num4 != 2386971688u)
					{
						num2 = 143;
						continue;
					}
					goto case 74;
				case 135:
					if (CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8322B84)))
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 93;
						}
						continue;
					}
					goto case 17;
				case 8:
				case 13:
				case 19:
				case 20:
				case 23:
				case 32:
				case 33:
				case 39:
				case 46:
				case 55:
				case 71:
				case 75:
				case 81:
				case 97:
				case 111:
				case 115:
				case 118:
				case 119:
				case 129:
				case 130:
				case 145:
				case 146:
				case 152:
				case 155:
					num4 = _003CPrivateImplementationDetails_003E.ComputeStringHash(typeName);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 125;
					}
					continue;
				case 88:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(0x2ACE37D ^ 0x2AF8357)))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 83;
						}
						continue;
					}
					goto case 2;
				case 66:
					if (num4 != 1323747186)
					{
						num2 = 152;
						continue;
					}
					goto case 52;
				case 29:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E74035)))
					{
						num2 = 144;
						continue;
					}
					goto case 2;
				case 156:
					if (num4 != 3291009739u)
					{
						num = 59;
						break;
					}
					goto case 76;
				case 24:
					if (num4 <= 875577056)
					{
						num2 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 60;
				case 26:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(-978351861 ^ -978528649)))
					{
						num2 = 70;
						continue;
					}
					goto case 2;
				case 48:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-477139494 ^ -477351210)))
					{
						num = 104;
						break;
					}
					goto case 2;
				case 10:
					if (num4 != 1625787317)
					{
						num2 = 126;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 78;
						}
						continue;
					}
					goto case 29;
				case 117:
					if (num4 != 765439473)
					{
						num2 = 66;
						continue;
					}
					goto case 134;
				case 18:
				case 47:
				case 149:
					typeName = (string)c319iHhPL4ZZStZPvpr5(typeName, '+', '.');
					num2 = 147;
					continue;
				case 68:
					if (typeName == (string)sj4OMPhPtJmCI9JVRDnZ(0x12441CA4 ^ 0x124549CA))
					{
						num2 = 79;
						continue;
					}
					goto case 17;
				case 108:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(--1867379187 ^ 0x6F4EAF5F)))
					{
						goto case 8;
					}
					num2 = 50;
					continue;
				case 41:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-1751176224 ^ -1751364694)))
					{
						goto case 17;
					}
					num2 = 61;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 2;
					}
					continue;
				case 102:
					if (num4 != 1764058053)
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 150;
				case 125:
					if (num4 <= 1741144581)
					{
						num2 = 24;
						continue;
					}
					goto case 34;
				case 28:
				case 142:
					if (num4 != 3969205087u)
					{
						num2 = 35;
						continue;
					}
					goto case 128;
				case 4:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(0x3CE17B75 ^ 0x3CE22509)))
					{
						goto case 8;
					}
					num2 = 81;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 151;
					}
					continue;
				case 99:
					if (num4 != 1741144581)
					{
						num2 = 42;
						continue;
					}
					goto case 88;
				case 158:
					if (num4 != 3538687084u)
					{
						num2 = 78;
						continue;
					}
					goto case 58;
				case 3:
					if (CaqHKyhPjP0LWp9itjL8(typeName, sj4OMPhPtJmCI9JVRDnZ(-1487388570 ^ -1487200242)))
					{
						num2 = 136;
						continue;
					}
					goto case 17;
				case 153:
					num3 = CXte2nhP94T0O9IAFUZa(typeName, ',');
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 25;
					}
					continue;
				case 128:
					if (!(typeName == (string)sj4OMPhPtJmCI9JVRDnZ(0x1637C429 ^ 0x16349A21)))
					{
						goto case 8;
					}
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 154;
					}
					continue;
				case 98:
					if (!CaqHKyhPjP0LWp9itjL8(typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886432507)))
					{
						num2 = 19;
						continue;
					}
					goto case 12;
				case 57:
					if (num4 != 697196164)
					{
						num2 = 39;
						continue;
					}
					goto case 4;
				case 6:
				case 54:
					if (typeArguments == null)
					{
						num2 = 69;
						continue;
					}
					goto case 62;
				case 34:
					if (num4 > 2747029693u)
					{
						num2 = 118;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 131;
						}
						continue;
					}
					goto case 109;
				case 91:
					if (num4 != 3409549631u)
					{
						num2 = 101;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 115;
						}
						continue;
					}
					goto case 103;
				case 51:
					if (num4 != 2779444460u)
					{
						num2 = 91;
						continue;
					}
					goto case 49;
				case 58:
					if (!(typeName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AFBD11)))
					{
						goto case 8;
					}
					num2 = 64;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 56;
					}
					continue;
				case 9:
					typeName = (string)qOWVsVhPdsdqmh36Fp84(typeName, num3);
					num2 = 47;
					continue;
				case 7:
					if (num4 != 3079944380u)
					{
						num2 = 156;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 112;
						}
						continue;
					}
					goto case 15;
				case 25:
					if (num3 < 0)
					{
						num2 = 149;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	public static ISyntaxNode CreateArrayTypeSyntax(this ISyntaxNode elementType)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(x2asjGhPUWY22WgFtQj3(NV5IknhPPLNPeCUK2LWr(), elementType.Unpack()));
	}

	public static ISyntaxNode CreateAtStringSyntaxNode(this string value)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_007c, IL_008b, IL_00db, IL_00ea, IL_0158, IL_0167
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (value != null)
					{
						num2 = 4;
						continue;
					}
					goto case 10;
				case 6:
					if (value.Contains('\a'))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto default;
				default:
					if (value.Contains('\b'))
					{
						break;
					}
					goto end_IL_0012;
				case 8:
					if (value.Contains('\v'))
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 3:
					if (!value.Contains('\f'))
					{
						num2 = 8;
						continue;
					}
					break;
				case 10:
					return (ISyntaxNode)U2pecShPsvPhUw57ZSZJ();
				case 4:
					if (value.Contains('\0'))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 1:
					return new LiteralExpressionSyntax(value, escapeNonPrintable: false).Pack();
				case 2:
				case 7:
				case 9:
					break;
				}
				return value.CreateStringSyntaxNode();
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static ISyntaxNode CreateStringSyntaxNode(this string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ISyntaxNode)U2pecShPsvPhUw57ZSZJ();
			case 1:
				if (value != null)
				{
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(zqYI3ahPcbWBDcwsX5xf(SyntaxGenerator, value));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ISyntaxNode CreateSyntaxNode(this object value)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8, IL_00e2, IL_00f1, IL_018a, IL_01c8, IL_02bf, IL_02ce, IL_02de, IL_0383, IL_0392, IL_04b1
		int num = 1;
		Type type = default(Type);
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = default(_003C_003Ec__DisplayClass43_0);
		IEnumerable<string> values = default(IEnumerable<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<float>.Raw))
					{
						num2 = 21;
						continue;
					}
					goto case 17;
				case 14:
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(SyntaxGenerator.TypeOfExpression(((ISyntaxNode)eACjIfhPmu37oVjVtfMl((Type)_003C_003Ec__DisplayClass43_.value)).Unpack()));
				case 5:
					throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787280395), _003C_003Ec__DisplayClass43_.value.GetType().FullName));
				case 6:
					return Null;
				case 16:
					type = _003C_003Ec__DisplayClass43_.value.GetType();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					if (cEiGxghPzLTS2XXjSdqZ(type, TypeOf<int>.Raw))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 31;
				case 21:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<double>.Raw))
					{
						num = 11;
						break;
					}
					goto case 17;
				case 10:
					if (!(type == TypeOf<sbyte>.Raw))
					{
						num2 = 12;
						continue;
					}
					goto case 17;
				case 15:
					return ((SyntaxNode)CYY0W1hP1FVsdjn6tLgq(NV5IknhPPLNPeCUK2LWr(), string.Join((string)sj4OMPhPtJmCI9JVRDnZ(-1108654032 ^ -1108858698), values))).Pack();
				case 7:
					if (cEiGxghPzLTS2XXjSdqZ(type, TypeOf<char>.Raw))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 27;
				case 12:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<short>.Raw))
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 17;
				default:
					_003C_003Ec__DisplayClass43_.value = value;
					num2 = 4;
					continue;
				case 11:
					if (type == TypeOf<decimal>.Raw)
					{
						num2 = 24;
						continue;
					}
					goto case 29;
				case 29:
					if (cEiGxghPzLTS2XXjSdqZ(type, TypeOf<byte>.Raw))
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 10;
				case 28:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<ushort>.Raw))
					{
						num = 8;
						break;
					}
					goto case 17;
				case 31:
					if (cEiGxghPzLTS2XXjSdqZ(type, TypeOf<uint>.Raw))
					{
						num2 = 17;
						continue;
					}
					goto case 26;
				case 27:
					if (_003C_003Ec__DisplayClass43_.value is bool)
					{
						num2 = 25;
						continue;
					}
					goto case 13;
				case 17:
				case 19:
				case 22:
				case 23:
				case 24:
				case 25:
				case 30:
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(zqYI3ahPcbWBDcwsX5xf(NV5IknhPPLNPeCUK2LWr(), _003C_003Ec__DisplayClass43_.value));
				case 32:
					if (cEiGxghPzLTS2XXjSdqZ(type, TypeOf<string>.Raw))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 20;
						}
						continue;
					}
					if (!type.IsEnum)
					{
						if (!(_003C_003Ec__DisplayClass43_.value is ISyntaxNode))
						{
							num2 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num2 = 18;
							}
							continue;
						}
						goto case 33;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					continue;
				case 26:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<long>.Raw))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 17;
				case 33:
					return (ISyntaxNode)_003C_003Ec__DisplayClass43_.value;
				case 18:
					if (!(_003C_003Ec__DisplayClass43_.value is Type))
					{
						num2 = 5;
						continue;
					}
					goto case 14;
				case 4:
					if (_003C_003Ec__DisplayClass43_.value != null)
					{
						num2 = 16;
						continue;
					}
					goto case 6;
				case 9:
					return (ISyntaxNode)etLcvJh1FTW6leG492aG((string)_003C_003Ec__DisplayClass43_.value);
				case 3:
					if (!cEiGxghPzLTS2XXjSdqZ(type, TypeOf<ulong>.Raw))
					{
						num2 = 32;
						continue;
					}
					goto case 17;
				case 1:
					_003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					if (((string)_003C_003Ec__DisplayClass43_.value).Where((char c) => c == '\n').Skip(1).Any())
					{
						return (ISyntaxNode)cBE0GOh1BpyHGs9U5mjD((string)_003C_003Ec__DisplayClass43_.value);
					}
					num2 = 9;
					continue;
				case 2:
					values = (from s in (IEnumerable<string>)k9ojMEh1ooTnYcL0Itqp(_003C_003Ec__DisplayClass43_.value.ToString(), HSUQm9h1W6jVfOUyehm8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511550ED)), StringSplitOptions.RemoveEmptyEntries)
						select (string)_003C_003Ec.YUtXDDvujdRLccfNwOjY(s) into s
						where !_003C_003Ec.utyUQPvuYMU9hsaEjSrN(s)
						select s).Select(_003C_003Ec__DisplayClass43_._003CCreateSyntaxNode_003Eb__3);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private unsafe static string ProcessAttributeTypeName(object attributeTypeName)
	{
		//Discarded unreachable code: IL_008c, IL_009b
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					return (string)attributeTypeName;
				case 3:
					if (!BdeYNch1bxCbjmjbXguB(attributeTypeName, sj4OMPhPtJmCI9JVRDnZ(--1360331293 ^ 0x511662FF)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					AddGlobal(ref *(string*)(&attributeTypeName));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			attributeTypeName = qOWVsVhPdsdqmh36Fp84(attributeTypeName, ggn0Pmh1haHll4kHgHxO(attributeTypeName) - 9);
			num = 2;
		}
	}

	public static ISyntaxNode CreateAttribute<T>(KeyValuePair<string, object>[] args)
	{
		return TypeOf<T>.Raw.CreateAttribute(args);
	}

	public static ISyntaxNode CreateAttribute(this Type attributeType, KeyValuePair<string, object>[] args)
	{
		return (ISyntaxNode)weM2pwh1Gm55yMQjbaV5(attributeType.FullName, args);
	}

	public static ISyntaxNode CreateAttribute<T>(params object[] args)
	{
		return TypeOf<T>.Raw.CreateAttribute(args);
	}

	public static ISyntaxNode CreateAttribute(this Type attributeType, params object[] args)
	{
		return attributeType.FullName.CreateAttribute(args);
	}

	public static ISyntaxNode CreateAttribute(this string attributeTypeName, KeyValuePair<string, object>[] args)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).Attribute((string)HEU4DPh1EC8KTbcKkDkA(attributeTypeName), from arg in args.EmptyIfNull()
			select (arg.Value as ISyntaxNode).Unpack() ?? SyntaxGenerator.AttributeArgument(arg.Key, arg.Value.CreateSyntaxNode().Unpack())));
	}

	public static ISyntaxNode CreateAttribute(this string attributeTypeName, params object[] args)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).Attribute(ProcessAttributeTypeName(attributeTypeName), args.EmptyIfNull().Select(delegate(object arg)
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = (arg as ISyntaxNode).Unpack();
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = _003C_003Ec.l15MSRvus7OhllKVop3E(_003C_003Ec.ukmithvuLH4rcRARBU6u(), ((ISyntaxNode)_003C_003Ec.AE2BsdvuUEPgKj3OlJsj(arg)).Unpack());
					break;
				}
				break;
			}
			return (SyntaxNode)obj;
		})));
	}

	public static ISyntaxNode AttributeArgument(this ISyntaxNode expression, string name = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(FrhrYuh1QgOcR9xMqtuL(SyntaxGenerator, name, XLVF7HhPNnxmdVm1UmsP(expression)));
			case 1:
				if (oaHlRhh1fq2uhyyU0wQa(name))
				{
					return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).AttributeArgument((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression)));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ISyntaxNode AddAttributes(this ISyntaxNode syntaxNode, params ISyntaxNode[] attributes)
	{
		return syntaxNode.AddAttributes(attributes.AsEnumerable());
	}

	public static ISyntaxNode AddAttributes(this ISyntaxNode syntaxNode, IEnumerable<ISyntaxNode> attributes)
	{
		return syntaxNode.Pack(SyntaxGenerator.AddAttributes(syntaxNode.Unpack(), from a in attributes.Unpack()
			where a != null
			select a));
	}

	public static IEnumerable<ISyntaxNode> WithPragmaWarningDisableDirective(this IEnumerable<ISyntaxNode> syntaxNodes, params ISyntaxNode[] errorCodes)
	{
		return syntaxNodes.WithPragmaWarningDisableDirective(errorCodes.AsEnumerable());
	}

	public static IEnumerable<ISyntaxNode> WithPragmaWarningDisableDirective(this IEnumerable<ISyntaxNode> syntaxNodes, IEnumerable<ISyntaxNode> errorCodes)
	{
		List<SyntaxNode> list = syntaxNodes.Unpack().ToList();
		if (list.Count == 0)
		{
			return syntaxNodes;
		}
		list[0].AddLeadingTrivia(new SyntaxTrivia[1] { SyntaxGenerator.PragmaWarningDisableDirectiveTrivia(errorCodes.Unpack()) });
		list[list.Count - 1].AddTrailingTrivia(new SyntaxTrivia[1] { SyntaxGenerator.PragmaWarningRestoreDirectiveTrivia(errorCodes.Unpack()) });
		return list.Pack();
	}

	public static ISyntaxNode WithPragmaWarningDisableDirective(this ISyntaxNode syntaxNode, params ISyntaxNode[] errorCodes)
	{
		return syntaxNode.WithPragmaWarningDisableDirective(errorCodes.AsEnumerable());
	}

	public static ISyntaxNode WithPragmaWarningDisableDirective(this ISyntaxNode syntaxNode, IEnumerable<ISyntaxNode> errorCodes)
	{
		return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia(new SyntaxTrivia[1] { SyntaxGenerator.PragmaWarningDisableDirectiveTrivia(errorCodes.Unpack()) }).AddTrailingTrivia(new SyntaxTrivia[1] { SyntaxGenerator.PragmaWarningRestoreDirectiveTrivia(errorCodes.Unpack()) }));
	}

	public static ISyntaxNode XmlComments(this ISyntaxNode syntaxNode, params ISyntaxTrivia[] documentationComments)
	{
		return syntaxNode.XmlComments(documentationComments.AsEnumerable());
	}

	public static ISyntaxNode XmlComments(this ISyntaxNode syntaxNode, IEnumerable<ISyntaxTrivia> documentationComments)
	{
		return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia(documentationComments.Unpack()));
	}

	public static ISyntaxNode TextComments(this ISyntaxNode syntaxNode, IEnumerable<ISyntaxTrivia> comments)
	{
		return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia(comments.Unpack()));
	}

	public static ISyntaxNode TextCommentsTrailing(this ISyntaxNode syntaxNode, IEnumerable<ISyntaxTrivia> comments)
	{
		return syntaxNode.Pack(syntaxNode.Unpack().AddTrailingTrivia(comments.Unpack()));
	}

	public static ISyntaxTrivia TextComment(this string comment)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (W4TZ6Mh1Cxm47V40n0pA(comment))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return ((IEnumerable<string>)RDZSHAhPlGC2fywTxxOY(N9ty02h1vX3uc1vBV0ZT(N9ty02h1vX3uc1vBV0ZT(comment, sj4OMPhPtJmCI9JVRDnZ(-1123633026 ^ -1123624128), sj4OMPhPtJmCI9JVRDnZ(0x571EA399 ^ 0x571EBC3D)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576145060), sj4OMPhPtJmCI9JVRDnZ(0x1DE3DD89 ^ 0x1DE3C22D)), new char[1] { '\n' })).Select((string line) => (SyntaxTrivia)_003C_003Ec.SuYZOVvuzTFT5BEfjD4K(SyntaxGenerator, _003C_003Ec.vpPrAlvuc30FAhZky2BA(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C58749), line))).Pack();
			case 1:
				return null;
			}
		}
	}

	public static ISyntaxTrivia SplittedComment(this string comment, bool trim = false)
	{
		//Discarded unreachable code: IL_005c, IL_009c
		int num = 1;
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = default(_003C_003Ec__DisplayClass63_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass63_.trim = trim;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					obj = comment;
					goto IL_00c6;
				case 1:
					_003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (W4TZ6Mh1Cxm47V40n0pA(comment))
					{
						num2 = 5;
						break;
					}
					goto case 3;
				case 3:
					if (!_003C_003Ec__DisplayClass63_.trim)
					{
						goto end_IL_0012;
					}
					obj = KIg7XEh18jcl2qVbZl0G(comment);
					goto IL_00c6;
				case 5:
					{
						return null;
					}
					IL_00c6:
					return ((IEnumerable<string>)RDZSHAhPlGC2fywTxxOY(((string)N9ty02h1vX3uc1vBV0ZT(obj, sj4OMPhPtJmCI9JVRDnZ(-1638402543 ^ -1638427345), sj4OMPhPtJmCI9JVRDnZ(0x63ABA4E8 ^ 0x63ABBB4C))).Replace((string)sj4OMPhPtJmCI9JVRDnZ(0x18A6761F ^ 0x18A668E7), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921197977)), new char[1] { '\n' })).Select(_003C_003Ec__DisplayClass63_._003CSplittedComment_003Eb__0).Pack();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static ISyntaxTrivia TagComment(this string comment, string tagName, bool trim = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!W4TZ6Mh1Cxm47V40n0pA(comment))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return ((string)QJemlnh1ZcQqQuA4RJo1(new string[7]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787471709),
					tagName,
					(string)sj4OMPhPtJmCI9JVRDnZ(-1123633026 ^ -1123690362),
					trim ? comment.Trim() : comment,
					(string)sj4OMPhPtJmCI9JVRDnZ(--1418440330 ^ 0x5488CF8A),
					tagName,
					(string)sj4OMPhPtJmCI9JVRDnZ(-16752921 ^ -16772825)
				})).SplittedComment(trim);
			}
		}
	}

	public static ISyntaxTrivia SummaryComment(this string comment, bool trim = false)
	{
		return comment.TagComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822718190), trim);
	}

	public static ISyntaxTrivia RemarksComment(this string comment, bool trim = false)
	{
		return comment.TagComment((string)sj4OMPhPtJmCI9JVRDnZ(-541731959 ^ -541674859), trim);
	}

	public static ISyntaxTrivia ExampleComment(this string comment, bool trim = false)
	{
		return comment.TagComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E77FF5), trim);
	}

	public static ISyntaxTrivia ParamComment(this string comment, string paramName, bool trim = false)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (comment.IsNullOrWhiteSpace())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return ((string)QJemlnh1ZcQqQuA4RJo1(new string[5]
				{
					(string)sj4OMPhPtJmCI9JVRDnZ(--1360331293 ^ 0x5116635D),
					paramName,
					(string)sj4OMPhPtJmCI9JVRDnZ(0xD3DEF7E ^ 0xD3E8E20),
					(string)(trim ? KIg7XEh18jcl2qVbZl0G(comment) : comment),
					(string)sj4OMPhPtJmCI9JVRDnZ(-1459557599 ^ -1459385785)
				})).SplittedComment(trim);
			case 1:
				return null;
			}
		}
	}

	public static ISyntaxNode NamespaceDeclaration(this string name, params ISyntaxNode[] declarations)
	{
		return name.NamespaceDeclaration(declarations.AsEnumerable());
	}

	public static ISyntaxNode NamespaceDeclaration(this string name, IEnumerable<ISyntaxNode> declarations)
	{
		return SyntaxGenerator.NamespaceDeclaration(name, declarations.Unpack()).Pack();
	}

	public static ISyntaxNode NamespaceImportDeclaration(this string name)
	{
		return ((SyntaxNode)KFwJDYh1uHfQ6dJL4vTp(NV5IknhPPLNPeCUK2LWr(), name)).Pack();
	}

	public static ISyntaxNode ClassDeclaration(this string name, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, ISyntaxNode baseType = null, IEnumerable<ISyntaxNode> interfaceTypes = null, IEnumerable<ISyntaxNode> members = null)
	{
		return name.ClassDeclaration(null, accessibility, modifiers, baseType, interfaceTypes, members);
	}

	public static ISyntaxNode ClassDeclaration(this string name, IEnumerable<string> typeParameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, ISyntaxNode baseType = null, IEnumerable<ISyntaxNode> interfaceTypes = null, IEnumerable<ISyntaxNode> members = null)
	{
		return SyntaxGenerator.ClassDeclaration(name, typeParameters, accessibility.Unpack(), modifiers.Unpack(), baseType.Unpack(), interfaceTypes.Unpack(), members.Unpack().SortMembers()).Pack();
	}

	public static ISyntaxNode InterfaceDeclaration(this string name, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> interfaceTypes = null, IEnumerable<ISyntaxNode> members = null)
	{
		return name.InterfaceDeclaration(null, accessibility, modifiers, interfaceTypes, members);
	}

	public static ISyntaxNode InterfaceDeclaration(this string name, IEnumerable<string> typeParameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> interfaceTypes = null, IEnumerable<ISyntaxNode> members = null)
	{
		return SyntaxGenerator.InterfaceDeclaration(name, typeParameters, accessibility.Unpack(), modifiers.Unpack(), interfaceTypes.Unpack(), members.Unpack().SortMembers()).Pack();
	}

	public static ISyntaxNode EnumDeclaration(this string name, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> members = null)
	{
		return SyntaxGenerator.EnumDeclaration(name, accessibility.Unpack(), modifiers.Unpack(), members.Unpack()).Pack();
	}

	public static ISyntaxNode EnumMember(this string name, ISyntaxNode expression = null)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(Uwu6S2h1IchQrtSpTWdJ(NV5IknhPPLNPeCUK2LWr(), name, XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode ConstructorDeclaration(Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> baseConstructorArguments = null, IEnumerable<ISyntaxNode> statements = null)
	{
		return ConstructorDeclaration(null, accessibility, modifiers, baseConstructorArguments, statements);
	}

	public static ISyntaxNode ConstructorDeclaration(IEnumerable<ISyntaxNode> parameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> baseConstructorArguments = null, IEnumerable<ISyntaxNode> statements = null)
	{
		return SyntaxGenerator.ConstructorDeclaration(parameters.Unpack(), accessibility.Unpack(), modifiers.Unpack(), baseConstructorArguments.Unpack(), statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode ThisConstructorDeclaration(Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> thisConstructorArguments = null, IEnumerable<ISyntaxNode> statements = null)
	{
		return ThisConstructorDeclaration(null, accessibility, modifiers, thisConstructorArguments, statements);
	}

	public static ISyntaxNode ThisConstructorDeclaration(IEnumerable<ISyntaxNode> parameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> thisConstructorArguments = null, IEnumerable<ISyntaxNode> statements = null)
	{
		return SyntaxGenerator.ThisConstructorDeclaration(parameters.Unpack(), accessibility.Unpack(), modifiers.Unpack(), thisConstructorArguments.Unpack(), statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode AutoPropertyDeclaration(this string name, ISyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, Accessibility getterAccessibility = Accessibility.NotApplicable, Accessibility setterAccessibility = Accessibility.NotApplicable)
	{
		return SyntaxGenerator.AutoPropertyDeclaration(name, type.Unpack(), accessibility.Unpack(), modifiers.Unpack(), getterAccessibility.Unpack(), H4n8x8h1VM8sUgNbQss2(setterAccessibility)).Pack();
	}

	public static ISyntaxNode PropertyDeclaration(this string name, ISyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> getAccessorStatements = null, IEnumerable<ISyntaxNode> setAccessorStatements = null, Accessibility getterAccessibility = Accessibility.NotApplicable, Accessibility setterAccessibility = Accessibility.NotApplicable)
	{
		return SyntaxGenerator.PropertyDeclaration(name, type.Unpack(), accessibility.Unpack(), modifiers.Unpack(), getAccessorStatements.UnpackStatements(), setAccessorStatements.UnpackStatements(), getterAccessibility.Unpack(), setterAccessibility.Unpack()).Pack();
	}

	public static ISyntaxNode ParameterDeclaration<T>(this string name, ISyntaxNode initializer = null, RefKind refKind = RefKind.None)
	{
		return name.ParameterDeclaration(CreateTypeSyntax<T>(), initializer, refKind);
	}

	public static ISyntaxNode ParameterDeclaration(this string name, Type type, ISyntaxNode initializer = null, RefKind refKind = RefKind.None)
	{
		return name.ParameterDeclaration(type.CreateTypeSyntax(), initializer, refKind);
	}

	public static ISyntaxNode ParameterDeclaration(this string name, ISyntaxNode type, ISyntaxNode initializer = null, RefKind refKind = RefKind.None)
	{
		return ((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).ParameterDeclaration(name, (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(type), (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(initializer), chxvn3h1SwjotCOeuWxi(refKind)).Pack();
	}

	public static ISyntaxNode WithParamsModifier(this ISyntaxNode parameter)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				MFR5tjh1ivOCs4Pta5j7(parameter.Unpack<ParameterDeclarationSyntax>(), true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return parameter;
			}
		}
	}

	public static ISyntaxNode MethodDeclaration(this string name, IEnumerable<ISyntaxNode> parameters = null, IEnumerable<string> typeParameters = null, ISyntaxNode returnType = null, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<ISyntaxNode> statements = null)
	{
		return SyntaxGenerator.MethodDeclaration(name, parameters.Unpack(), typeParameters, returnType.Unpack(), accessibility.Unpack(), modifiers.Unpack(), statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode FieldDeclaration(this string name, ISyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, ISyntaxNode initializer = null)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(lrtdpAh1quU5RANp48Q7(NV5IknhPPLNPeCUK2LWr(), name, XLVF7HhPNnxmdVm1UmsP(type), H4n8x8h1VM8sUgNbQss2(accessibility), LtSnPsh1R7fddd3TZN33(modifiers), XLVF7HhPNnxmdVm1UmsP(initializer)));
	}

	public static ISyntaxNode AsPrivateInterfaceImplementation(this ISyntaxNode declaration, ISyntaxNode interfaceType)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(Eu8guIh1KPwwAb3mA0Px(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(declaration), XLVF7HhPNnxmdVm1UmsP(interfaceType)));
	}

	public static ISyntaxNode ReturnStatement()
	{
		return (ISyntaxNode)k7scLPh1XE5SfTXFfHEs(null);
	}

	public static ISyntaxNode ReturnStatement(this ISyntaxNode expression)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(SyntaxGenerator.ReturnStatement((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode AssignmentStatement(this ISyntaxNode left, ISyntaxNode right)
	{
		return ((SyntaxNode)StY2OGh1TEaMHZNRrgeN(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(left), XLVF7HhPNnxmdVm1UmsP(right))).Pack();
	}

	public static ISyntaxNode LocalDeclarationStatement(this string identifier, ISyntaxNode initializer)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(f3GZMSh1k41J6kTv41cO(NV5IknhPPLNPeCUK2LWr(), identifier, initializer.Unpack()));
	}

	public static ISyntaxNode LocalDeclarationStatement(this string identifier, ISyntaxNode type, ISyntaxNode initializer = null, bool isConst = false)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(Ox3CHxh1neaePhanDXvn(SyntaxGenerator, XLVF7HhPNnxmdVm1UmsP(type), identifier, XLVF7HhPNnxmdVm1UmsP(initializer), isConst));
	}

	public static ISyntaxNode IfStatement(this ISyntaxNode condition, IEnumerable<ISyntaxNode> trueStatements, IEnumerable<ISyntaxNode> falseStatements = null)
	{
		return SyntaxGenerator.IfStatement(condition.Unpack(), trueStatements.UnpackStatements(), falseStatements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode SwitchStatement(this string identifier, params ISyntaxNode[] caseStatements)
	{
		return identifier.SwitchStatement(caseStatements.AsEnumerable());
	}

	public static ISyntaxNode SwitchStatement(this string identifier, IEnumerable<ISyntaxNode> caseStatements)
	{
		return identifier.IdentifierName().SwitchStatement(caseStatements);
	}

	public static ISyntaxNode SwitchStatement(this ISyntaxNode identifier, params ISyntaxNode[] caseStatements)
	{
		return identifier.SwitchStatement(caseStatements.AsEnumerable());
	}

	public static ISyntaxNode SwitchStatement(this ISyntaxNode identifier, IEnumerable<ISyntaxNode> caseStatements)
	{
		return SyntaxGenerator.SwitchStatement(identifier.Unpack(), caseStatements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode CaseStatement(this ISyntaxNode value, params ISyntaxNode[] statements)
	{
		return value.CaseStatement(statements.AsEnumerable());
	}

	public static ISyntaxNode CaseDefaultStatement(params ISyntaxNode[] statements)
	{
		return CaseDefaultStatement(statements.AsEnumerable());
	}

	public static ISyntaxNode CaseStatement(this ISyntaxNode value, IEnumerable<ISyntaxNode> statements)
	{
		return SyntaxGenerator.CaseStatement(value.Unpack(), statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode CaseDefaultStatement(IEnumerable<ISyntaxNode> statements)
	{
		return SyntaxGenerator.CaseStatement(null, statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode BreakStatement()
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(uiX4Mbh1Ox35duPM47So(SyntaxGenerator));
	}

	public static ISyntaxNode ThrowStatement(ISyntaxNode expression = null)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(Q7iIhuh12UTad951cNlV(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode ThrowNotImplementedStatement()
	{
		return ThrowStatement(((ISyntaxNode)eACjIfhPmu37oVjVtfMl(TypeOf<NotImplementedException>.Raw)).ObjectCreationExpression());
	}

	public static ISyntaxNode ParseExpression(this string text)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(OEF9mVh1efZDOPGJmXvc(NV5IknhPPLNPeCUK2LWr(), text));
	}

	public static ISyntaxNode CreateGuidExpression(this Guid value)
	{
		return ((ISyntaxNode)eACjIfhPmu37oVjVtfMl(TypeOf<Guid>.Raw)).ObjectCreationExpression((ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(value.ToString()));
	}

	public static ISyntaxNode CreateGuidExpression(this Guid? value)
	{
		if (!value.HasValue)
		{
			return Null;
		}
		return value.Value.CreateGuidExpression();
	}

	public static ISyntaxNode CreateGuidQuickExpression(this Guid value)
	{
		int num = 4;
		byte b5 = default(byte);
		byte[] array = default(byte[]);
		int num4 = default(int);
		short num3 = default(short);
		short num5 = default(short);
		byte b6 = default(byte);
		byte b4 = default(byte);
		byte b7 = default(byte);
		byte b2 = default(byte);
		byte b = default(byte);
		byte b3 = default(byte);
		byte b8 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					b5 = array[9];
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					num4 = (array[3] << 24) | (array[2] << 16) | (array[1] << 8) | array[0];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					break;
				case 10:
					return ((ISyntaxNode)eACjIfhPmu37oVjVtfMl(TypeOf<Guid>.Raw)).ObjectCreationExpression(num4.CreateSyntaxNode(), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(num3), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(num5), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b6), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b5), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b4), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b7), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b2), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b3), (ISyntaxNode)Atq2FXh1PGBgk0vBU2Ls(b8));
				case 1:
					num3 = (short)((array[5] << 8) | array[4]);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					num5 = (short)((array[7] << 8) | array[6]);
					num2 = 8;
					continue;
				case 5:
					b7 = array[11];
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 11;
					}
					continue;
				case 8:
					b6 = array[8];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					array = value.ToByteArray();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					b4 = array[10];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					b3 = array[14];
					num2 = 7;
					continue;
				case 11:
					b2 = array[12];
					num2 = 9;
					continue;
				case 9:
					b = array[13];
					num2 = 2;
					continue;
				}
				break;
			}
			b8 = array[15];
			num = 10;
		}
	}

	public static ISyntaxNode CreateGuidQuickExpression(this Guid? value)
	{
		if (!value.HasValue)
		{
			return Null;
		}
		return value.Value.CreateGuidQuickExpression();
	}

	public static ISyntaxNode TypeOfExpression(this Type type)
	{
		return (ISyntaxNode)GSmtpXh11YUpfAe7aw5C(eACjIfhPmu37oVjVtfMl(type));
	}

	public static ISyntaxNode TypeOfExpression(this string typeName)
	{
		return (ISyntaxNode)GSmtpXh11YUpfAe7aw5C(QJElImhPMyCQONFOQx7J(typeName));
	}

	public static ISyntaxNode TypeOfExpression(this ISyntaxNode type)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(tLqORZh1NqxYWhyAgKqF(SyntaxGenerator, XLVF7HhPNnxmdVm1UmsP(type)));
	}

	public static ISyntaxNode DefaultExpression(this Type type)
	{
		return (ISyntaxNode)wo1Rt8h13FLrDsBk5CoD(eACjIfhPmu37oVjVtfMl(type));
	}

	public static ISyntaxNode DefaultExpression(this string typeName)
	{
		return (ISyntaxNode)wo1Rt8h13FLrDsBk5CoD(typeName.CreateTypeSyntax());
	}

	public static ISyntaxNode DefaultExpression(this ISyntaxNode type)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(njxBNLh1pTkBycknTOqT(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(type)));
	}

	public static ISyntaxNode CastExpression(this ISyntaxNode expression, ISyntaxNode type)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(fmaW0hh1aZhnENYs8kI6(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(type), XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode TryCastExpression(this ISyntaxNode expression, ISyntaxNode type)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(KjEx0Bh1DP4CeXFILgFs(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(expression), type.Unpack()));
	}

	public static ISyntaxNode InvocationExpression(this string methodName, params ISyntaxNode[] arguments)
	{
		return ((ISyntaxNode)s092OqhPwXvD2xKWydyw(methodName)).InvocationExpression(arguments);
	}

	public static ISyntaxNode InvocationExpression(this string methodName, IEnumerable<ISyntaxNode> arguments)
	{
		return methodName.IdentifierName().InvocationExpression(arguments);
	}

	public static ISyntaxNode InvocationExpression(this ISyntaxNode expression, params ISyntaxNode[] arguments)
	{
		return expression.InvocationExpression(arguments.AsEnumerable());
	}

	public static ISyntaxNode InvocationExpression(this ISyntaxNode expression, IEnumerable<ISyntaxNode> arguments)
	{
		return SyntaxGenerator.InvocationExpression(expression.Unpack(), arguments.Unpack()).Pack();
	}

	public static ISyntaxNode RefKindArgument(this ISyntaxNode expression, RefKind refKind)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(MFwUgsh1tdIHYoCwJkDn(NV5IknhPPLNPeCUK2LWr(), chxvn3h1SwjotCOeuWxi(refKind), XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode ObjectCreationExpression(this ISyntaxNode type, params ISyntaxNode[] arguments)
	{
		return type.ObjectCreationExpression(arguments.AsEnumerable());
	}

	public static ISyntaxNode ObjectCreationExpression(this ISyntaxNode type, IEnumerable<ISyntaxNode> arguments)
	{
		return type.ObjectInitializationExpression(arguments, Enumerable.Empty<ISyntaxNode>());
	}

	public static ISyntaxNode ObjectInitializationExpression(this ISyntaxNode type, params ISyntaxNode[] properties)
	{
		return type.ObjectInitializationExpression(properties.AsEnumerable());
	}

	public static ISyntaxNode ObjectInitializationExpression(this ISyntaxNode type, IEnumerable<ISyntaxNode> properties)
	{
		return type.ObjectInitializationExpression(Enumerable.Empty<ISyntaxNode>(), properties);
	}

	public static ISyntaxNode ObjectInitializationExpression(this ISyntaxNode type, IEnumerable<ISyntaxNode> arguments, IEnumerable<ISyntaxNode> properties)
	{
		return SyntaxGenerator.ObjectCreationExpression(type.Unpack(), arguments.Unpack(), properties.Unpack()).Pack();
	}

	public static ISyntaxNode MemberAccessExpression(this ISyntaxNode expression, ISyntaxNode memberName)
	{
		return ((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).MemberAccessExpression((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression), memberName.Unpack()).Pack();
	}

	public static ISyntaxNode MemberAccessExpression(this ISyntaxNode expression, string memberName)
	{
		return ((SyntaxNode)ILRf3Ph1wa59txoOQqc4(NV5IknhPPLNPeCUK2LWr(), expression.Unpack(), memberName)).Pack();
	}

	public static ISyntaxNode ElementAccessExpression(this ISyntaxNode expression, params ISyntaxNode[] arguments)
	{
		return expression.ElementAccessExpression(arguments.AsEnumerable());
	}

	public static ISyntaxNode ElementAccessExpression(this ISyntaxNode expression, IEnumerable<ISyntaxNode> arguments)
	{
		return SyntaxGenerator.ElementAccessExpression(expression.Unpack(), arguments.Unpack()).Pack();
	}

	public static ISyntaxNode ConditionalAccessExpression(this ISyntaxNode expression, ISyntaxNode memberName)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).ConditionalAccessExpression((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression), (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(memberName)));
	}

	public static ISyntaxNode ConditionalAccessExpression(this ISyntaxNode expression, string memberName)
	{
		return ((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).ConditionalAccessExpression((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression), memberName).Pack();
	}

	public static ISyntaxNode ConditionalExpression(this ISyntaxNode condition, ISyntaxNode trueExpression, ISyntaxNode falseExpression)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(SyntaxGenerator.ConditionalExpression((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(condition), (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(trueExpression), (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(falseExpression)));
	}

	public static ISyntaxNode CoalesceExpression(this ISyntaxNode left, ISyntaxNode right)
	{
		return ((SyntaxNode)c7uhc8h14uLoBCgv9vRC(NV5IknhPPLNPeCUK2LWr(), left.Unpack(), XLVF7HhPNnxmdVm1UmsP(right))).Pack();
	}

	public static ISyntaxNode ValueReturningLambdaExpression(IEnumerable<ISyntaxNode> statements)
	{
		return SyntaxGenerator.ValueReturningLambdaExpression(statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode ValueReturningLambdaExpression(ISyntaxNode expression)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(hPZX0qh16Z8GJsDoDBPy(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode ValueReturningLambdaExpression(this string parameterName, IEnumerable<ISyntaxNode> statements)
	{
		return SyntaxGenerator.ValueReturningLambdaExpression(parameterName, statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode ValueReturningLambdaExpression(this string parameterName, ISyntaxNode expression)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).ValueReturningLambdaExpression(parameterName, (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode ValueReturningLambdaExpression(IEnumerable<ISyntaxNode> lambdaParameters, IEnumerable<ISyntaxNode> statements)
	{
		return SyntaxGenerator.ValueReturningLambdaExpression(lambdaParameters.Unpack(), statements.UnpackStatements()).Pack();
	}

	public static ISyntaxNode ValueReturningLambdaExpression(IEnumerable<ISyntaxNode> lambdaParameters, ISyntaxNode expression)
	{
		return SyntaxGenerator.ValueReturningLambdaExpression(lambdaParameters.Unpack(), expression.Unpack()).Pack();
	}

	public static ISyntaxNode ValueEqualsExpression(this ISyntaxNode left, ISyntaxNode right)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(kpgdy2h1HVKcmBTT4bE4(SyntaxGenerator, left.Unpack(), XLVF7HhPNnxmdVm1UmsP(right)));
	}

	public static ISyntaxNode ValueNotEqualsExpression(this ISyntaxNode left, ISyntaxNode right)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(MYTTk6h1AsJXSdju0vr6(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(left), XLVF7HhPNnxmdVm1UmsP(right)));
	}

	public static ISyntaxNode LogicalOrExpression(this ISyntaxNode left, ISyntaxNode right)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(qUWi7Ih17AWOkwmLSaj6(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(left), XLVF7HhPNnxmdVm1UmsP(right)));
	}

	public static ISyntaxNode LogicalAndExpression(this ISyntaxNode left, ISyntaxNode right)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(((SyntaxGenerator)NV5IknhPPLNPeCUK2LWr()).LogicalAndExpression((SyntaxNode)XLVF7HhPNnxmdVm1UmsP(left), (SyntaxNode)XLVF7HhPNnxmdVm1UmsP(right)));
	}

	public static ISyntaxNode AwaitExpression(this ISyntaxNode expression)
	{
		return (ISyntaxNode)Swh3l3hPaSDK1GImfyng(lS5B20h1xYfQ81jNukNJ(NV5IknhPPLNPeCUK2LWr(), XLVF7HhPNnxmdVm1UmsP(expression)));
	}

	public static ISyntaxNode WithTypeConstraint(this ISyntaxNode declaration, string typeParameterName, params ISyntaxNode[] types)
	{
		return declaration.WithTypeConstraint(typeParameterName, SpecialTypeConstraintKind.None, types);
	}

	public static ISyntaxNode WithTypeConstraint(this ISyntaxNode declaration, string typeParameterName, IEnumerable<ISyntaxNode> types)
	{
		return declaration.WithTypeConstraint(typeParameterName, SpecialTypeConstraintKind.None, types);
	}

	public static ISyntaxNode WithTypeConstraint(this ISyntaxNode declaration, string typeParameterName, SpecialTypeConstraintKind kinds, params ISyntaxNode[] types)
	{
		return declaration.WithTypeConstraint(typeParameterName, kinds, types.AsEnumerable());
	}

	public static ISyntaxNode WithTypeConstraint(this ISyntaxNode declaration, string typeParameterName, SpecialTypeConstraintKind kinds, IEnumerable<ISyntaxNode> types = null)
	{
		return declaration.Pack(SyntaxGenerator.WithTypeConstraint(declaration.Unpack(), typeParameterName, kinds.Unpack(), types.Unpack().ToArray()));
	}

	private static IEnumerable<SyntaxNode> SortMembers(this IEnumerable<SyntaxNode> nodes)
	{
		return nodes?.OrderBy((SyntaxNode n) => n.GetType(), new MembersComparer());
	}

	internal static bool NVFcSchP2oTiYU7pfE7i()
	{
		return s2T1WVhPONeogEjGaJy6 == null;
	}

	internal static SyntaxGeneratorExtensions gNOhI9hPe893TJKQnXFD()
	{
		return s2T1WVhPONeogEjGaJy6;
	}

	internal static object NV5IknhPPLNPeCUK2LWr()
	{
		return SyntaxGenerator;
	}

	internal static object CYY0W1hP1FVsdjn6tLgq(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).IdentifierName((string)P_1);
	}

	internal static object XLVF7HhPNnxmdVm1UmsP(object P_0)
	{
		return ((ISyntaxNode)P_0).Unpack();
	}

	internal static object jBQrwshP3PTx97TcRmB9(object P_0)
	{
		return ((GenericNameSyntax)P_0).Identifier;
	}

	internal static object mCAYDHhPpuAWwaSQQTa7(object P_0)
	{
		return ((SyntaxGenerator)P_0).NullLiteralExpression();
	}

	internal static object Swh3l3hPaSDK1GImfyng(object P_0)
	{
		return ((SyntaxNode)P_0).Pack();
	}

	internal static object AXO8nshPDqbtI6gr61R6(object P_0)
	{
		return ((SyntaxGenerator)P_0).BaseExpression();
	}

	internal static object sj4OMPhPtJmCI9JVRDnZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object s092OqhPwXvD2xKWydyw(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static int hDOW0nhP4TCw3bP9J7YK(object P_0, char P_1)
	{
		return ((string)P_0).LastIndexOf(P_1);
	}

	internal static object QQkRvQhP6fpfFLLA4639(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object U4M9MshPHK96RJ1Wl1Et(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static bool NeXC9HhPAilYihGIP9eo(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool jSEfFqhP7etjIiiZnT5w(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object gTDhJXhPxOUxnRrST4OZ(Type type, bool useGlobal)
	{
		return type.CreateTypeSyntax(useGlobal);
	}

	internal static void xxOQsvhP0Bh14afDXB8A(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object eACjIfhPmu37oVjVtfMl(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object OZGLpRhPy1QT8LFbGgLH(object P_0)
	{
		return ((ISyntaxNode)P_0).CreateArrayTypeSyntax();
	}

	internal static object QJElImhPMyCQONFOQx7J(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object CFjP60hPJCjwBVf1HtXL(object P_0, bool useGlobal)
	{
		return ((string)P_0).CreateTypeSyntax(useGlobal);
	}

	internal static int CXte2nhP94T0O9IAFUZa(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object qOWVsVhPdsdqmh36Fp84(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}

	internal static object RDZSHAhPlGC2fywTxxOY(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void tJKtTohPrMRj7qlOdqA7(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	internal static int LC4DTkhPgmvVqjOgUK1t(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static uint j59ZWVhP500j9jGbbWLk(object P_0)
	{
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool CaqHKyhPjP0LWp9itjL8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object hGbBWShPYQaNbCPcYU4G(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).ParseTypeName((string)P_1);
	}

	internal static object c319iHhPL4ZZStZPvpr5(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object x2asjGhPUWY22WgFtQj3(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).ArrayTypeExpression((SyntaxNode)P_1);
	}

	internal static object U2pecShPsvPhUw57ZSZJ()
	{
		return Null;
	}

	internal static object zqYI3ahPcbWBDcwsX5xf(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).LiteralExpression(P_1);
	}

	internal static bool cEiGxghPzLTS2XXjSdqZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object etLcvJh1FTW6leG492aG(object P_0)
	{
		return ((string)P_0).CreateStringSyntaxNode();
	}

	internal static object cBE0GOh1BpyHGs9U5mjD(object P_0)
	{
		return ((string)P_0).CreateAtStringSyntaxNode();
	}

	internal static object HSUQm9h1W6jVfOUyehm8(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object k9ojMEh1ooTnYcL0Itqp(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static bool BdeYNch1bxCbjmjbXguB(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static int ggn0Pmh1haHll4kHgHxO(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object weM2pwh1Gm55yMQjbaV5(object P_0, object P_1)
	{
		return ((string)P_0).CreateAttribute((KeyValuePair<string, object>[])P_1);
	}

	internal static object HEU4DPh1EC8KTbcKkDkA(object P_0)
	{
		return ProcessAttributeTypeName(P_0);
	}

	internal static bool oaHlRhh1fq2uhyyU0wQa(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object FrhrYuh1QgOcR9xMqtuL(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).AttributeArgument((string)P_1, (SyntaxNode)P_2);
	}

	internal static bool W4TZ6Mh1Cxm47V40n0pA(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object N9ty02h1vX3uc1vBV0ZT(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object KIg7XEh18jcl2qVbZl0G(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object QJemlnh1ZcQqQuA4RJo1(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object KFwJDYh1uHfQ6dJL4vTp(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).NamespaceImportDeclaration((string)P_1);
	}

	internal static object Uwu6S2h1IchQrtSpTWdJ(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).EnumMember((string)P_1, (SyntaxNode)P_2);
	}

	internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility H4n8x8h1VM8sUgNbQss2(Accessibility accessibility)
	{
		return accessibility.Unpack();
	}

	internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind chxvn3h1SwjotCOeuWxi(RefKind refKind)
	{
		return refKind.Unpack();
	}

	internal static void MFR5tjh1ivOCs4Pta5j7(object P_0, bool P_1)
	{
		((ParameterDeclarationSyntax)P_0).ParamsModifier = P_1;
	}

	internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers LtSnPsh1R7fddd3TZN33(DeclarationModifiers modifiers)
	{
		return modifiers.Unpack();
	}

	internal static object lrtdpAh1quU5RANp48Q7(object P_0, object P_1, object P_2, EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility P_3, EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers P_4, object P_5)
	{
		return ((SyntaxGenerator)P_0).FieldDeclaration((string)P_1, (SyntaxNode)P_2, P_3, P_4, (SyntaxNode)P_5);
	}

	internal static object Eu8guIh1KPwwAb3mA0Px(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).AsPrivateInterfaceImplementation((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object k7scLPh1XE5SfTXFfHEs(object P_0)
	{
		return ((ISyntaxNode)P_0).ReturnStatement();
	}

	internal static object StY2OGh1TEaMHZNRrgeN(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).AssignmentStatement((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object f3GZMSh1k41J6kTv41cO(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).LocalDeclarationStatement((string)P_1, (SyntaxNode)P_2);
	}

	internal static object Ox3CHxh1neaePhanDXvn(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((SyntaxGenerator)P_0).LocalDeclarationStatement((SyntaxNode)P_1, (string)P_2, (SyntaxNode)P_3, P_4);
	}

	internal static object uiX4Mbh1Ox35duPM47So(object P_0)
	{
		return ((SyntaxGenerator)P_0).BreakStatement();
	}

	internal static object Q7iIhuh12UTad951cNlV(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).ThrowStatement((SyntaxNode)P_1);
	}

	internal static object OEF9mVh1efZDOPGJmXvc(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).SnippetExpression((string)P_1);
	}

	internal static object Atq2FXh1PGBgk0vBU2Ls(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object GSmtpXh11YUpfAe7aw5C(object P_0)
	{
		return ((ISyntaxNode)P_0).TypeOfExpression();
	}

	internal static object tLqORZh1NqxYWhyAgKqF(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).TypeOfExpression((SyntaxNode)P_1);
	}

	internal static object wo1Rt8h13FLrDsBk5CoD(object P_0)
	{
		return ((ISyntaxNode)P_0).DefaultExpression();
	}

	internal static object njxBNLh1pTkBycknTOqT(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).DefaultExpression((SyntaxNode)P_1);
	}

	internal static object fmaW0hh1aZhnENYs8kI6(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).CastExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object KjEx0Bh1DP4CeXFILgFs(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).TryCastExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object MFwUgsh1tdIHYoCwJkDn(object P_0, EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).RefKindArgument(P_1, (SyntaxNode)P_2);
	}

	internal static object ILRf3Ph1wa59txoOQqc4(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).MemberAccessExpression((SyntaxNode)P_1, (string)P_2);
	}

	internal static object c7uhc8h14uLoBCgv9vRC(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).CoalesceExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object hPZX0qh16Z8GJsDoDBPy(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).ValueReturningLambdaExpression((SyntaxNode)P_1);
	}

	internal static object kpgdy2h1HVKcmBTT4bE4(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).ValueEqualsExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object MYTTk6h1AsJXSdju0vr6(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).ValueNotEqualsExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object qUWi7Ih17AWOkwmLSaj6(object P_0, object P_1, object P_2)
	{
		return ((SyntaxGenerator)P_0).LogicalOrExpression((SyntaxNode)P_1, (SyntaxNode)P_2);
	}

	internal static object lS5B20h1xYfQ81jNukNJ(object P_0, object P_1)
	{
		return ((SyntaxGenerator)P_0).AwaitExpression((SyntaxNode)P_1);
	}
}

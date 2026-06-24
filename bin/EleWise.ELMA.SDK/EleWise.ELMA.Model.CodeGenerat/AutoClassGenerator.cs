using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class AutoClassGenerator : IAutoClassGenerator
{
	private ClassMetadata metadata;

	protected Type _interfaceType;

	protected Type _baseInterfaceType;

	protected string _baseClassTypeName;

	protected Type[] _extensionTypes;

	private static AutoClassGenerator oLZFPGh36RufXfvsXbkF;

	public string TypeName => (string)UrN3Okh39Djk0mq0NDdO(iwsupTh3JaJsVq2inh66(_interfaceType), 1);

	public AutoClassGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fAJjhGh37aFPgriXNfAn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public string GenerateCode(Type interfaceType, params Type[] extensionTypes)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Init(interfaceType, extensionTypes);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GenerateCodeInternal();
			}
		}
	}

	private void Init(Type interfaceType, params Type[] extensionTypes)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 1:
					F6wkhZh30v2ll4JmGD1E(interfaceType, UASCdxh3xqFR1qhTU1tr(-1334993905 ^ -1334919041));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				default:
					_interfaceType = interfaceType;
					num2 = 3;
					continue;
				case 3:
					_extensionTypes = extensionTypes ?? new Type[0];
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			metadata = MetadataLoader.LoadMetadata(interfaceType) as ClassMetadata;
			num = 4;
		}
	}

	private string GenerateCodeInternal()
	{
		//Discarded unreachable code: IL_004d, IL_013a, IL_0149, IL_0159, IL_0251, IL_0294, IL_02a3
		string result = default(string);
		switch (1)
		{
		case 1:
			try
			{
				AutoImplementClassBaseAttribute attribute = AttributeHelper<AutoImplementClassBaseAttribute>.GetAttribute(_interfaceType, inherited: false);
				int num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				AutoImplementAttribute attribute2 = default(AutoImplementAttribute);
				while (true)
				{
					switch (num)
					{
					case 9:
						if (attribute == null)
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num = 0;
							}
							break;
						}
						goto case 5;
					case 5:
						_baseInterfaceType = qbnrsZh3m9jBCmoB4obv(attribute);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num = 0;
						}
						break;
					case 4:
					case 7:
						result = _interfaceType.Namespace.NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile())).GenerateCSCodeString();
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num = 2;
						}
						break;
					case 1:
					case 6:
						attribute2 = AttributeHelper<AutoImplementAttribute>.GetAttribute(_interfaceType, inherited: false);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num = 3;
						}
						break;
					default:
						_baseClassTypeName = (DVxfY3h3yOJnIiqDIna9(_baseInterfaceType, null) ? _baseInterfaceType.FullName : null);
						num = 7;
						break;
					case 3:
						_baseInterfaceType = ((attribute2 != null) ? qxubB6h3Mg3IK2HlneT2(attribute2) : null);
						num = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num = 7;
						}
						break;
					case 8:
						_baseClassTypeName = (string)(DVxfY3h3yOJnIiqDIna9(_baseInterfaceType, null) ? kVOZNQh3dIZfZiAhLapx(_baseInterfaceType.Namespace, UASCdxh3xqFR1qhTU1tr(0x5F3078B6 ^ 0x5F306272), UrN3Okh39Djk0mq0NDdO(iwsupTh3JaJsVq2inh66(_baseInterfaceType), 1)) : null);
						num = 4;
						break;
					case 2:
						return result;
					}
				}
			}
			catch (Exception innerException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw new CodeGenerationException(SR.T((string)UASCdxh3xqFR1qhTU1tr(-1886646897 ^ -1886426231), _interfaceType.FullName), innerException);
				}
			}
		default:
			return result;
		}
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__9))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__9(-2);
	}

	[IteratorStateMachine(typeof(_003CGenerateMainFile_003Ed__12))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__12(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (_baseClassTypeName != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return (ISyntaxNode)C6Ibwsh3l8L2cRphETW4(_baseClassTypeName);
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetBaseInterfaces_003Ed__14))]
	protected IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetBaseInterfaces_003Ed__14(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void WriteComments(ISyntaxNode type)
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
				type.XmlComments(SR.T((string)UASCdxh3xqFR1qhTU1tr(0x7459E02 ^ 0x746F87E), _interfaceType.FullName).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_00c8, IL_01b0, IL_01bf
		int num = 6;
		Type[] extensionTypes = default(Type[]);
		List<ISyntaxNode> list = default(List<ISyntaxNode>);
		int num3 = default(int);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					extensionTypes = _extensionTypes;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					type.AddAttributes(list);
					num2 = 11;
					continue;
				case 6:
					list = new List<ISyntaxNode>();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					list.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(pMH4k6h3rwWOAs2fZkac(_interfaceType.FullName)));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
				case 10:
					break;
				case 5:
					list.Add(TypeOf<ComponentAttribute>.Raw.CreateAttribute());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					list.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(pMH4k6h3rwWOAs2fZkac(type2.FullName)));
					num2 = 7;
					continue;
				default:
					if (num3 < extensionTypes.Length)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 3;
				case 11:
					return;
				}
				break;
			}
			type2 = extensionTypes[num3];
			num = 8;
		}
	}

	protected virtual IEnumerable<ISyntaxNode> GetMembers()
	{
		ISyntaxNode syntaxNode = SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Public, DeclarationModifiers.None, null, CtorStatements());
		syntaxNode.XmlComments(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE0BB59), TypeName).SummaryComment());
		return new ISyntaxNode[1] { syntaxNode }.Concat(WriteProperties()).Concat(WriteMethods());
	}

	[IteratorStateMachine(typeof(_003CCtorStatements_003Ed__18))]
	protected virtual IEnumerable<ISyntaxNode> CtorStatements()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCtorStatements_003Ed__18(-2);
	}

	protected virtual IEnumerable<ISyntaxNode> WriteProperties()
	{
		return _interfaceType.GetProperties().Concat(_extensionTypes.SelectMany((Type ext) => ext.GetProperties())).SelectMany(WriteProperty);
	}

	[IteratorStateMachine(typeof(_003CWriteProperty_003Ed__20))]
	protected virtual IEnumerable<ISyntaxNode> WriteProperty(PropertyInfo pi)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteProperty_003Ed__20(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__pi = pi
		};
	}

	protected virtual IEnumerable<ISyntaxNode> WriteMethods()
	{
		return _interfaceType.GetMethods().Concat(_extensionTypes.SelectMany((Type ext) => ext.GetMethods())).SelectMany(WriteMethod);
	}

	[IteratorStateMachine(typeof(_003CWriteMethod_003Ed__22))]
	protected virtual IEnumerable<ISyntaxNode> WriteMethod(MethodInfo mi)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteMethod_003Ed__22(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__mi = mi
		};
	}

	protected virtual void GetTypeReferenceByRuntime(Type type, bool hasUseImplAttribute, out ISyntaxNode implTypeRef, out ISyntaxNode intfTypeRef)
	{
		//Discarded unreachable code: IL_009e, IL_00ad, IL_0110, IL_011f
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				implTypeRef = (ISyntaxNode)C6Ibwsh3l8L2cRphETW4(kVOZNQh3dIZfZiAhLapx(type.Namespace, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123638598), type.Name.Substring(1)));
				num2 = 5;
				break;
			case 7:
				implTypeRef = intfTypeRef;
				num2 = 9;
				break;
			case 1:
				return;
			case 2:
				intfTypeRef = (ISyntaxNode)yOpFnGh3gRRGW8ClXJUA(type);
				num2 = 7;
				break;
			case 5:
				return;
			case 8:
				return;
			case 11:
				intfTypeRef = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (!hasUseImplAttribute)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 10;
				}
				break;
			case 3:
				if (!(type == null))
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 4:
				implTypeRef = null;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				if (!((string)iwsupTh3JaJsVq2inh66(type)).StartsWith((string)UASCdxh3xqFR1qhTU1tr(0x463A0F3C ^ 0x4638F1FA)))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	internal static void fAJjhGh37aFPgriXNfAn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WtNo2Uh3HhFMlYOkAtUp()
	{
		return oLZFPGh36RufXfvsXbkF == null;
	}

	internal static AutoClassGenerator CFgcX5h3AcemPxf2wAwb()
	{
		return oLZFPGh36RufXfvsXbkF;
	}

	internal static object UASCdxh3xqFR1qhTU1tr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void F6wkhZh30v2ll4JmGD1E(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type qbnrsZh3m9jBCmoB4obv(object P_0)
	{
		return ((AutoImplementClassBaseAttribute)P_0).BaseAutoImplementType;
	}

	internal static bool DVxfY3h3yOJnIiqDIna9(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type qxubB6h3Mg3IK2HlneT2(object P_0)
	{
		return ((AutoImplementAttribute)P_0).BaseAutoImplementType;
	}

	internal static object iwsupTh3JaJsVq2inh66(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object UrN3Okh39Djk0mq0NDdO(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object kVOZNQh3dIZfZiAhLapx(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object C6Ibwsh3l8L2cRphETW4(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object pMH4k6h3rwWOAs2fZkac(object P_0)
	{
		return ((string)P_0).TypeOfExpression();
	}

	internal static object yOpFnGh3gRRGW8ClXJUA(Type type)
	{
		return type.CreateTypeSyntax();
	}
}

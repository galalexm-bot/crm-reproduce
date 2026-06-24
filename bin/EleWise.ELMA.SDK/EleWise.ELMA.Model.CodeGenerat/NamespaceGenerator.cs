using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class NamespaceGenerator : CodeGenerator
{
	protected NamespaceMetadata metadata;

	private static NamespaceGenerator r5H7v6hD8EllFVntgeWw;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				MT1FAdhDVtEJyKrFJpeS(metadata, L3lQkYhDIw46FnTWhWM7(-957824448 ^ -957838466));
				num2 = 2;
				break;
			case 2:
				ktERUIhDSbgU4IGSvkrS(metadata is NamespaceMetadata, L3lQkYhDIw46FnTWhWM7(0x2A7797B7 ^ 0x2A74E795));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				this.metadata = (NamespaceMetadata)metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_0076, IL_00a9, IL_00ec, IL_00fb
		int num = 1;
		int num2 = num;
		GeneratedFileInfo result = default(GeneratedFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				SigO1xhDisx1U6VKSQYs(metadata, L3lQkYhDIw46FnTWhWM7(-1487388570 ^ -1487402664));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = GenerateMainFileHelper(new ISyntaxNode[1] { ((string)YpVhtbhDRXftn8mYEsCl(metadata)).NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile())) }, withPragmaWarningDisable: true);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			catch (Exception innerException)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				default:
					throw new CodeGenerationException(SR.T((string)L3lQkYhDIw46FnTWhWM7(0x3C5338FF ^ 0x3C505381), vkX4wwhDqbsAIEDMUNrY(metadata)), innerException);
				}
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateAdditionalFilesInternal_003Ed__2))]
	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateAdditionalFilesInternal_003Ed__2(-2);
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__4))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__4(-2);
	}

	[IteratorStateMachine(typeof(_003CGenerateMainFile_003Ed__5))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__5(-2)
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
			case 1:
				SigO1xhDisx1U6VKSQYs(metadata, L3lQkYhDIw46FnTWhWM7(0x2ACE37D ^ 0x2ACAA43));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			type.XmlComments(SR.T((string)L3lQkYhDIw46FnTWhWM7(-420743386 ^ -420968634), YpVhtbhDRXftn8mYEsCl(metadata)).SummaryComment());
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
			{
				num2 = 1;
			}
		}
	}

	protected virtual void WriteTypeAttributes(ISyntaxNode declaration)
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!VJbiH8hDKMiRbPhPntTd(metadata))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 1:
					return;
				case 3:
					WriteBasicAttributes(declaration);
					num = 2;
					break;
				case 4:
					SigO1xhDisx1U6VKSQYs(metadata, L3lQkYhDIw46FnTWhWM7(0x6DC147B0 ^ 0x6DC10E8E));
					num = 3;
					break;
				default:
					declaration.AddAttributes(TypeOf<AllowCreateModelsAttribute>.Raw.CreateAttribute());
					num2 = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CMembers_003Ed__8))]
	protected virtual IEnumerable<ISyntaxNode> Members()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CMembers_003Ed__8(-2)
		{
			_003C_003E4__this = this
		};
	}

	public NamespaceGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HgbitShDXB5vixiDDSH8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object L3lQkYhDIw46FnTWhWM7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MT1FAdhDVtEJyKrFJpeS(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void ktERUIhDSbgU4IGSvkrS(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool MFfJQfhDZVD2SGh3JfOy()
	{
		return r5H7v6hD8EllFVntgeWw == null;
	}

	internal static NamespaceGenerator qM3cSkhDuK7Kpwqrwv26()
	{
		return r5H7v6hD8EllFVntgeWw;
	}

	internal static void SigO1xhDisx1U6VKSQYs(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object YpVhtbhDRXftn8mYEsCl(object P_0)
	{
		return ((NamespaceMetadata)P_0).Namespace;
	}

	internal static object vkX4wwhDqbsAIEDMUNrY(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool VJbiH8hDKMiRbPhPntTd(object P_0)
	{
		return ((NamespaceMetadata)P_0).AllowCreateModels;
	}

	internal static void HgbitShDXB5vixiDDSH8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

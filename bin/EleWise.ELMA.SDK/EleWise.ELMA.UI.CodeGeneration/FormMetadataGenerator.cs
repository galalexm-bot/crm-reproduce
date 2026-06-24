using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

public abstract class FormMetadataGenerator<T> : CodeGenerator where T : FormMetadata
{
	private T _metadata;

	internal static object NGEC1hBV3XnIOoWiHKgv;

	protected T Metadata => _metadata;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Contract.CheckArgument(metadata is FormMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921130791));
				num2 = 3;
				break;
			case 1:
				Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABEDD6));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				_metadata = (T)metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_00d0, IL_0103, IL_014b, IL_015a
		int num = 2;
		int num2 = num;
		GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					generatedFileInfo = GenerateMainFileHelper(((!string.IsNullOrEmpty(generationParams.Prefix)) ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541734579) + generationParams.Prefix) : "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541799737), Metadata.Namespace.NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile())));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => generatedFileInfo, 
						_ => generatedFileInfo, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787383323), Metadata.Name), innerException);
					}
				}
			default:
				return generatedFileInfo;
			case 2:
				Contract.NotNull(Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5D074));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(FormMetadataGenerator<>._003CGenerateAdditionalFilesInternal_003Ed__2))]
	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateAdditionalFilesInternal_003Ed__2(-2);
	}

	[IteratorStateMachine(typeof(FormMetadataGenerator<>._003CGetNamespaces_003Ed__5))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__5(-2);
	}

	[IteratorStateMachine(typeof(FormMetadataGenerator<>._003CGenerateMainFile_003Ed__6))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__6(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode CreateContainerTypeDeclaration()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return syntaxNode;
			case 1:
				syntaxNode = Metadata.Name.ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, null, null, GenerateMainFileContent());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			syntaxNode.AddAttributes(typeof(MetadataTypeAttribute).CreateAttribute(Metadata.GetType()));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected abstract IEnumerable<ISyntaxNode> GenerateMainFileContent();

	protected FormMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xa0DqABVpQnbVCM35JiD()
	{
		return NGEC1hBV3XnIOoWiHKgv == null;
	}

	internal static object CTUgDDBVaI9G3l4dIuZX()
	{
		return NGEC1hBV3XnIOoWiHKgv;
	}
}

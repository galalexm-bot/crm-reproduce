using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

public abstract class AbstractCodeEditorExtension : ICodeEditorExtension
{
	protected class WorkspaceProjectHelper
	{
		private static WorkspaceProjectHelper IGxKoVQsCgByoyBUqK0d;

		public string CsprojFileName { get; }

		public string ProjectGuid { get; }

		public string ProjectAssemblyName { get; }

		public WorkspaceProjectHelper(ScriptModule scriptModule, string altProjectName = null)
		{
			//Discarded unreachable code: IL_002a
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					ProjectAssemblyName = (string)bTCEtXQsRc8vtoTPZnjE(zClsQvQsSkvN3INaOfr4(scriptModule), e1ZVu1QsI6MD5jFEE0NV(-978351861 ^ -978349105), Ym6Y1GQsiaAx3LYED5dg(scriptModule));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num = 1;
					}
					break;
				case 3:
				{
					ProjectGuid = (string)khIb1SQsVCeYeHGnRgOa(LFTLExQsuwxteq3ul6Q1(scriptModule).ToString((string)e1ZVu1QsI6MD5jFEE0NV(0x92F12D5 ^ 0x92F85E9)));
					int num2 = 2;
					num = num2;
					break;
				}
				default:
					CsprojFileName = (string)(altProjectName ?? ednbHlQsZFuv8PmUvyuk(scriptModule));
					num = 3;
					break;
				}
			}
		}

		public IScriptSource CreateCsprojSource(string content)
		{
			return new ScriptSource(CsprojFileName, content, ScriptSourceType.Project);
		}

		internal static object ednbHlQsZFuv8PmUvyuk(object P_0)
		{
			return ((ScriptModule)P_0).ClassName;
		}

		internal static Guid LFTLExQsuwxteq3ul6Q1(object P_0)
		{
			return ((ScriptModule)P_0).Uid;
		}

		internal static object e1ZVu1QsI6MD5jFEE0NV(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object khIb1SQsVCeYeHGnRgOa(object P_0)
		{
			return ((string)P_0).ToUpper();
		}

		internal static object zClsQvQsSkvN3INaOfr4(object P_0)
		{
			return ((ScriptModule)P_0).Namespace;
		}

		internal static object Ym6Y1GQsiaAx3LYED5dg(object P_0)
		{
			return ((ScriptModule)P_0).ModuleName;
		}

		internal static object bTCEtXQsRc8vtoTPZnjE(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static bool y2DkHRQsvSJYD4PRi6Pw()
		{
			return IGxKoVQsCgByoyBUqK0d == null;
		}

		internal static WorkspaceProjectHelper F8PfBKQs8wIxMtIpvij8()
		{
			return IGxKoVQsCgByoyBUqK0d;
		}
	}

	private class ScriptReferenceComparer : IEqualityComparer<IScriptReference>
	{
		public static IEqualityComparer<IScriptReference> ByName;

		private static object UWBkSMQsq6oopDGXpZIe;

		public bool Equals(IScriptReference x, IScriptReference y)
		{
			return xbCJCIQskCEAMbZJMkkb(xB4h3JQsTdVsNp4prswD(x), xB4h3JQsTdVsNp4prswD(y));
		}

		public int GetHashCode(IScriptReference obj)
		{
			return xB4h3JQsTdVsNp4prswD(obj).GetHashCode();
		}

		public ScriptReferenceComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ScriptReferenceComparer()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ByName = new ScriptReferenceComparer();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					XWhIJPQsnPCMHNcUvGwr();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object xB4h3JQsTdVsNp4prswD(object P_0)
		{
			return ((IScriptReference)P_0).Name;
		}

		internal static bool xbCJCIQskCEAMbZJMkkb(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool PIhHPJQsKwCoCyMM3a4M()
		{
			return UWBkSMQsq6oopDGXpZIe == null;
		}

		internal static ScriptReferenceComparer qGfd8FQsXMjQEfMrQxUo()
		{
			return (ScriptReferenceComparer)UWBkSMQsq6oopDGXpZIe;
		}

		internal static void XWhIJPQsnPCMHNcUvGwr()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static string compiledBaseDir;

	private IGlobalModulesReferenceService globalModulesReferenceService;

	private static readonly string[] DefaultGlobalReferences;

	private static readonly string[] DefaultElmaReferences;

	protected const string CompileFormat = "<Compile Include=\"{0}\" />";

	private static AbstractCodeEditorExtension jWcJ4kWdg7oA9iLbdB7S;

	private string LibsPath
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
					return (string)TqkbWvWdY5B5haFdDkye(OmniSharpWorker);
				default:
					OmniSharpWorker.Start(needRestart: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (!ysWER0WdLmtSfF5rhhtI(TqkbWvWdY5B5haFdDkye(OmniSharpWorker)))
					{
						num2 = 2;
						break;
					}
					goto default;
				}
			}
		}
	}

	private string ClientLibsPath
	{
		get
		{
			//Discarded unreachable code: IL_0031
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					OmniSharpWorker.Start(needRestart: true);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					return OmniSharpWorker.ClientCompletionLibsPath;
				case 1:
					if (!ysWER0WdLmtSfF5rhhtI(roiMM4WdUFvmaJrpIHsh(OmniSharpWorker)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ISearchMetadataService SearchMetadataService
	{
		[CompilerGenerated]
		get
		{
			return _003CSearchMetadataService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSearchMetadataService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IOmniSharpWorker OmniSharpWorker
	{
		[CompilerGenerated]
		get
		{
			return _003COmniSharpWorker_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003COmniSharpWorker_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal IGlobalModulesReferenceService GlobalModulesReferenceService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IGlobalModulesReferenceService globalModulesReferenceService = default(IGlobalModulesReferenceService);
			IGlobalModulesReferenceService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					globalModulesReferenceService = (this.globalModulesReferenceService = Locator.GetServiceNotNull<IGlobalModulesReferenceService>());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					obj = this.globalModulesReferenceService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					obj = globalModulesReferenceService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected abstract CodeType CodeType { get; }

	protected virtual IEnumerable<string> AdditionalElmaReferences => Enumerable.Empty<string>();

	public abstract bool Check(InitWorkspaceRequest request);

	public virtual Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request)
	{
		_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.request = request;
		if (CS_0024_003C_003E8__locals0.request == null)
		{
			return Task.FromResult<OmniSharpItem>(null);
		}
		ICodeEditorInitData codeEditorInitData = GetCodeEditorInitData(CS_0024_003C_003E8__locals0.request);
		if (codeEditorInitData == null)
		{
			return Task.FromResult<OmniSharpItem>(null);
		}
		CS_0024_003C_003E8__locals0.projectDir = GetProjectFolderPath(codeEditorInitData.ProjectName, CodeType);
		CS_0024_003C_003E8__locals0.fileName = Path.Combine(CS_0024_003C_003E8__locals0.projectDir, codeEditorInitData.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F4345));
		int methodPosition = GetMethodPosition(codeEditorInitData.SourceCode, codeEditorInitData.ClassName, codeEditorInitData.MethodName);
		OmniSharpItem result = new OmniSharpItem
		{
			FileName = CS_0024_003C_003E8__locals0.fileName,
			ProjectFileName = Path.Combine(CS_0024_003C_003E8__locals0.projectDir, codeEditorInitData.ProjectName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC0821B)),
			MethodPosition = methodPosition
		};
		Task.Run(delegate
		{
			int num = 5;
			_003C_003Ec__DisplayClass27_0._003C_003CInitWorkspace_003Eb__0_003Ed stateMachine = default(_003C_003Ec__DisplayClass27_0._003C_003CInitWorkspace_003Eb__0_003Ed);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						stateMachine._003C_003E1__state = -1;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						_003C_003Et__builder.Start(ref stateMachine);
						num2 = 3;
						continue;
					default:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
						stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						num2 = 2;
						continue;
					case 3:
						return stateMachine._003C_003Et__builder.Task;
					case 5:
						break;
					}
					break;
				}
				stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals0;
				num = 4;
			}
		});
		return Task.FromResult(result);
	}

	public abstract IScriptData GenerateSource(InitWorkspaceRequest request);

	public virtual int GetMethodPosition(string sourceCode, string className, string methodName)
	{
		//Discarded unreachable code: IL_00b8
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		ClassDeclarationSyntax val = default(ClassDeclarationSyntax);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
				num2 = 6;
				continue;
			case 8:
				if (!ysWER0WdLmtSfF5rhhtI(_003C_003Ec__DisplayClass29_.methodName))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 2;
			case 5:
				_003C_003Ec__DisplayClass29_.methodName = methodName;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				if (!ysWER0WdLmtSfF5rhhtI(sourceCode))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 2;
			case 2:
				return 0;
			case 1:
				val = CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions)wj73NaWdcGy7JivqSQKu(gnu5J9WdsFcda3jnrjhE(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false)
					.OfType<ClassDeclarationSyntax>()
					.FirstOrDefault(_003C_003Ec__DisplayClass29_._003CGetMethodPosition_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				_003C_003Ec__DisplayClass29_.className = className;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 5;
				}
				continue;
			case 9:
				return 0;
			case 4:
				return 0;
			}
			if (val == null)
			{
				num2 = 9;
				continue;
			}
			MethodDeclarationSyntax obj = ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<MethodDeclarationSyntax>().FirstOrDefault(_003C_003Ec__DisplayClass29_._003CGetMethodPosition_003Eb__1);
			if (obj == null)
			{
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return OtQo8TWlFpyrbBLra71Y(HvQ0G9WdzJ0MHCTnMrde(obj));
		}
	}

	protected abstract ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request);

	protected virtual IList<IScriptReference> GetAssemblies(ScriptModule scriptModule = null)
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass36_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.result = new List<IScriptReference>();
		CS_0024_003C_003E8__locals0.result.AddRange(GetDynamicAssemblies());
		if (CodeType == CodeType.Server)
		{
			IEnumerable<ScriptReference> collection = GetDefaultGlobalReferences();
			CS_0024_003C_003E8__locals0.result.AddRange(collection);
			IEnumerable<ScriptReference> collection2 = from r in GetGlobalReferences(scriptModule?.References)
				where !CS_0024_003C_003E8__locals0.result.Contains(r, ScriptReferenceComparer.ByName)
				select r;
			CS_0024_003C_003E8__locals0.result.AddRange(collection2);
			ElmaReferencesList elmaReferencesList2 = ReferencesListHelper.ParseElmaReferenceString(scriptModule?.ElmaReferences);
			IEnumerable<ScriptReference> collection3 = (elmaReferencesList2.IncudeAllReferences ? GetAllReferencesInDirectory(LibsPath) : GetElmaReferences(elmaReferencesList2));
			CS_0024_003C_003E8__locals0.result.AddRange(collection3);
			IEnumerable<ScriptReference> collection4 = GetGlobalModules(scriptModule?.GlobalScriptModules);
			CS_0024_003C_003E8__locals0.result.AddRange(collection4);
		}
		else
		{
			IEnumerable<ScriptReference> collection5 = GetAllReferencesInDirectory(ClientLibsPath);
			CS_0024_003C_003E8__locals0.result.AddRange(collection5);
		}
		foreach (DataClassAssemblyInfo publishedDataClassAssembly in SearchMetadataService.GetPublishedDataClassAssemblies())
		{
			switch (CodeType)
			{
			case CodeType.Server:
			case CodeType.GlobalFunction:
				if (publishedDataClassAssembly.AssemblyRaw != null)
				{
					CS_0024_003C_003E8__locals0.result.Add(new ScriptReference(publishedDataClassAssembly.Name, publishedDataClassAssembly.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576068834), publishedDataClassAssembly.AssemblyRaw));
				}
				break;
			case CodeType.Client:
			case CodeType.Test:
			case CodeType.View:
				if (publishedDataClassAssembly.ClientAssemblyRaw != null)
				{
					CS_0024_003C_003E8__locals0.result.Add(new ScriptReference(publishedDataClassAssembly.Name, publishedDataClassAssembly.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269F1B70), publishedDataClassAssembly.ClientAssemblyRaw));
				}
				break;
			}
		}
		return CS_0024_003C_003E8__locals0.result;
		static IEnumerable<ScriptReference> GetAllReferencesInDirectory(string directory)
		{
			return from filename in Directory.EnumerateFiles(directory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FB4408), SearchOption.TopDirectoryOnly)
				select new ScriptReference((string)_003C_003Ec.kIpZrVQsltIrISFbKKvu(filename), filename, null);
		}
		static IEnumerable<ScriptReference> GetDefaultGlobalReferences()
		{
			return DefaultGlobalReferences.Select((string r) => new ScriptReference(r, null, null));
		}
		IEnumerable<ScriptReference> GetElmaReferences(ElmaReferencesList elmaReferencesList)
		{
			return from r in DefaultElmaReferences.Union(CS_0024_003C_003E8__locals0._003C_003E4__this.AdditionalElmaReferences).Union(elmaReferencesList.References)
				select new ScriptReference(r, (string)_003C_003Ec__DisplayClass36_0.BwBHuQQsxP5uQPp3aMvb(CS_0024_003C_003E8__locals0._003C_003E4__this.LibsPath, _003C_003Ec__DisplayClass36_0.CEmLy4Qs7cTMwwLHTBnI(r, _003C_003Ec__DisplayClass36_0.VgE4pRQsAUF7wLEg9ybt(0x307E9FD1 ^ 0x307FDB6B))), null);
		}
		IEnumerable<ScriptReference> GetGlobalModules(IEnumerable<AssemblyReference> modules)
		{
			return modules.EmptyIfNull().Select(delegate(AssemblyReference module)
			{
				int num = 1;
				int num2 = num;
				string hintPath = default(string);
				while (true)
				{
					switch (num2)
					{
					default:
						return new ScriptReference((string)_003C_003Ec__DisplayClass36_0.mDXBu8QsyADjNNO6UrIs(module), hintPath, null);
					case 1:
						hintPath = (string)_003C_003Ec__DisplayClass36_0.UWU4O0QsmUep6t4j6k4A(CS_0024_003C_003E8__locals0._003C_003E4__this.GlobalModulesReferenceService, _003C_003Ec__DisplayClass36_0.Nu5WsAQs0uEAOh8oju1t(module));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		static IEnumerable<ScriptReference> GetGlobalReferences(string referenceString)
		{
			return from r in ReferencesListHelper.GetReferences(referenceString)
				select new ScriptReference(r, null, null);
		}
	}

	protected virtual List<IScriptReference> GetDynamicAssemblies()
	{
		List<IScriptReference> list = new List<IScriptReference>();
		foreach (AssemblyModelsMetadata assemblyModelsMetadata in MetadataRuntimeService.GetAssemblyModelsMetadataList())
		{
			string name = assemblyModelsMetadata.Name;
			if (name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767722081) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921200659))
			{
				list.Add(CreateScriptReference(assemblyModelsMetadata));
			}
		}
		return list;
	}

	protected static IScriptReference CreateScriptReference(AssemblyModelsMetadata modelsMetadata)
	{
		return new ScriptReference((string)xhmcGHWlBfGUTkryo2gU(modelsMetadata), modelsMetadata.Name + (string)E9DSw5WlWUDKNZx4XRcw(-2099751081 ^ -2099702803), ((MemoryStream)NZQ8aYWlolFT5OxNBMMZ(modelsMetadata)).ToArray(), (byte[])f6KnkZWlbqLBrEVCZQac(modelsMetadata));
	}

	protected static string GenerateSourcesSection(IEnumerable<IScriptSource> sources)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IScriptSource source in sources)
		{
			if (!string.IsNullOrWhiteSpace(source.Content))
			{
				stringBuilder.Append(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710717974), source.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E362C4)));
				stringBuilder.AppendLine();
			}
		}
		return stringBuilder.ToString();
	}

	protected string GenerateReferencesSection(IEnumerable<IScriptReference> references)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IScriptReference item in references.Where((IScriptReference r) => !_003C_003Ec.TcBB0JQsrkPkbh4xWO02(r.Name)))
		{
			stringBuilder.Append(string.IsNullOrEmpty(item.HintPath) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D01F4), item.Name) : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70126491), item.Name, item.HintPath));
			stringBuilder.AppendLine();
		}
		return stringBuilder.ToString();
	}

	[IteratorStateMachine(typeof(_003CGenerateWebReferencesSources_003Ed__41))]
	protected IEnumerable<IScriptSource> GenerateWebReferencesSources(ScriptModule scriptModule)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateWebReferencesSources_003Ed__41(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__scriptModule = scriptModule
		};
	}

	protected static string GenerateTemplate<T>(string resourceName, Func<string, string> conversions = null)
	{
		return ResourceTemplateGenerator.GenerateTemplate<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426214119) + resourceName, conversions);
	}

	public static string GetSourceFilePath(string projectFolderPath, string sourceName)
	{
		return (string)JtZIUQWlhbcaHmDD2fsJ(projectFolderPath, sourceName);
	}

	protected static ScriptModule FindScriptModuleRequired(IEnumerable<ScriptModule> modules, params Guid[] scriptModuleTypeUid)
	{
		ScriptModule scriptModule = FindScriptModule(modules, scriptModuleTypeUid);
		if (scriptModule == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x46383B04), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DA303), scriptModuleTypeUid)));
		}
		return scriptModule;
	}

	protected static ScriptModule FindScriptModule(IEnumerable<ScriptModule> modules, params Guid[] scriptModuleTypeUid)
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals0.scriptModuleTypeUid = scriptModuleTypeUid;
		return modules.FirstOrDefault((ScriptModule module) => CS_0024_003C_003E8__locals0.scriptModuleTypeUid.Contains(_003C_003Ec__DisplayClass45_0.WkjQSTQcoWuG9Bi075Ou(module)));
	}

	private static void WriteScriptData(object projectFolderPath, object scriptData)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00ab, IL_0110, IL_0196, IL_02bc, IL_02db, IL_02ea, IL_0307, IL_033c, IL_034a, IL_03ea, IL_03f9, IL_04d4, IL_050c
		int num = 2;
		IEnumerator<IScriptSource> enumerator2 = default(IEnumerator<IScriptSource>);
		IEnumerator<IScriptReference> enumerator = default(IEnumerator<IScriptReference>);
		IScriptSource current2 = default(IScriptSource);
		string text2 = default(string);
		string text3 = default(string);
		string text = default(string);
		IScriptReference current = default(IScriptReference);
		string path = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				case 5:
					enumerator2 = ((IScriptData)scriptData).Sources.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					enumerator = ((IScriptData)scriptData).Assemblies.GetEnumerator();
					num2 = 3;
					continue;
				default:
					try
					{
						while (true)
						{
							int num5;
							if (!DdaYLBWluW0HaiuVOi5Y(enumerator2))
							{
								num5 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
								{
									num5 = 11;
								}
								goto IL_00af;
							}
							goto IL_0237;
							IL_0237:
							current2 = enumerator2.Current;
							num5 = 5;
							goto IL_00af;
							IL_00af:
							while (true)
							{
								object obj;
								switch (num5)
								{
								case 7:
									obj = E9DSw5WlWUDKNZx4XRcw(0x53CB464B ^ 0x53CA5F05);
									goto IL_027a;
								case 10:
									if (!File.Exists(text2))
									{
										num5 = 14;
										continue;
									}
									goto case 9;
								case 13:
									break;
								case 1:
									if (!ExSr1nWlGE4FOxmWsORJ(text3))
									{
										num5 = 4;
										continue;
									}
									goto case 10;
								case 4:
									DAaqYKWlED0CQYr4osag(text3);
									num5 = 10;
									continue;
								case 8:
								case 14:
									PZeD9kWlZU6V09dx2tP8(text2, current2.Content);
									num5 = 2;
									continue;
								case 9:
									Iix7EEWl84fVQ6ilN2hg(text2, FileAttributes.Normal);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num5 = 0;
									}
									continue;
								case 12:
									text3 = (string)uvJ7tBWlvf8oyQW37cAN(text2);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
									{
										num5 = 1;
									}
									continue;
								case 2:
									Iix7EEWl84fVQ6ilN2hg(text2, FileAttributes.Normal);
									num5 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
									{
										num5 = 13;
									}
									continue;
								default:
									File.Delete(text2);
									num5 = 8;
									continue;
								case 5:
									if (OxMlhXWlfLMoAsnaUT1Y(current2) != ScriptSourceType.Project)
									{
										num5 = 7;
										continue;
									}
									obj = E9DSw5WlWUDKNZx4XRcw(-1822890472 ^ -1822763698);
									goto IL_027a;
								case 3:
									goto IL_0237;
								case 6:
									text2 = (string)x2FoI8WlCUIL7Uewnnou(projectFolderPath, (string)baYZmeWlQUoZE39nWrS2(current2) + text);
									num5 = 12;
									continue;
								case 11:
									goto end_IL_012b;
									IL_027a:
									text = (string)obj;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num5 = 6;
									}
									continue;
								}
								break;
							}
							continue;
							end_IL_012b:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator2 == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num6 = 0;
							}
							goto IL_02c0;
						}
						goto IL_02f5;
						IL_02f5:
						enumerator2.Dispose();
						num6 = 2;
						goto IL_02c0;
						IL_02c0:
						switch (num6)
						{
						case 1:
							goto end_IL_029b;
						case 2:
							goto end_IL_029b;
						}
						goto IL_02f5;
						end_IL_029b:;
					}
					goto case 4;
				case 2:
					if (!ExSr1nWlGE4FOxmWsORJ(projectFolderPath))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 3:
					try
					{
						while (true)
						{
							IL_0445:
							int num3;
							if (!DdaYLBWluW0HaiuVOi5Y(enumerator))
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num3 = 5;
								}
								goto IL_034e;
							}
							goto IL_0404;
							IL_0404:
							current = enumerator.Current;
							num3 = 3;
							goto IL_034e;
							IL_034e:
							while (true)
							{
								switch (num3)
								{
								case 8:
									if (current.DocumentationRaw != null)
									{
										num3 = 9;
										continue;
									}
									goto IL_0445;
								case 2:
									File.WriteAllBytes(path, current.AssemblyRaw);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num3 = 8;
									}
									continue;
								case 9:
									if (((Array)vqwniqWliB4vbiEM65AD(current)).Length == 0)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 1;
								case 5:
									break;
								case 6:
									path = Path.Combine((string)projectFolderPath, (string)Ut2BLbWlSVLWXRkulg42(upIpOpWlVJR83LBgMBLt(current), E9DSw5WlWUDKNZx4XRcw(-2138958856 ^ -2138876094)));
									num3 = 2;
									continue;
								default:
									goto IL_0445;
								case 1:
									d775vEWlRrPmUnOWxNhS(Path.ChangeExtension(path, (string)E9DSw5WlWUDKNZx4XRcw(0x48A7E34A ^ 0x48A76D04)), current.DocumentationRaw);
									num3 = 4;
									continue;
								case 3:
									if (I6yDL3WlIHEkCJlT5dNY(current) != null)
									{
										num3 = 6;
										continue;
									}
									goto IL_0445;
								case 7:
									return;
								}
								break;
							}
							goto IL_0404;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									oq1b2pWlqHxuDSuRF748(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 6:
					return;
				}
				break;
			}
			DAaqYKWlED0CQYr4osag(projectFolderPath);
			num = 5;
		}
	}

	private static string GetProjectFolderPath(object projectName, CodeType codeType)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return Path.Combine(text, (string)QN3dO9WlTMZK646MxlAs(E9DSw5WlWUDKNZx4XRcw(-218496594 ^ -218614514), projectName, codeType, aUuWkjWlXtliP4PJpfSI()));
			case 3:
				Directory.CreateDirectory(text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				text = Path.Combine((string)qwB5eTWlKDP4QaUQjaIn(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FB53D0));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!ExSr1nWlGE4FOxmWsORJ(text))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static byte[] DocumentationRaw(object modelsMetadata)
	{
		//Discarded unreachable code: IL_00aa, IL_00b9, IL_019c, IL_01b5
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return (byte[])VehgflWlpCoClBw06I27(text);
			case 8:
				text = Path.Combine(compiledBaseDir, (string)E9DSw5WlWUDKNZx4XRcw(-1837662597 ^ -1837806951));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
			{
				object obj = MuFdd5WlnTQse0OnylKx(modelsMetadata);
				if (obj == null)
				{
					num2 = 7;
					break;
				}
				return (byte[])SujF9hWlOdPaLkJ7mI5i(obj);
			}
			case 4:
				compiledBaseDir = Path.Combine((string)MOTOKUWleemFMlTKAPKK(EWToDcWl2jtSSMWfwg9Z()), (string)E9DSw5WlWUDKNZx4XRcw(-70007027 ^ -70022545));
				num2 = 11;
				break;
			case 3:
				if (!K8JCTbWlkNUH0QYY4B1x(xhmcGHWlBfGUTkryo2gU(modelsMetadata), E9DSw5WlWUDKNZx4XRcw(-1710575414 ^ -1710572828)))
				{
					num2 = 2;
					break;
				}
				goto case 10;
			case 11:
			case 12:
				text = (string)JPIiHSWlNTXimMAqBHKV(compiledBaseDir, M4TcV7Wl1jtmWxak3iQS(uTSUGLWlPIojTOhjwvSR()), E9DSw5WlWUDKNZx4XRcw(-2099751081 ^ -2099616843));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!sk81cyWl3KFTd2c0G00U(text))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 9;
			default:
				if (!File.Exists(text))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 6:
				return (byte[])VehgflWlpCoClBw06I27(text);
			case 5:
				return null;
			case 7:
				return null;
			case 2:
				if (compiledBaseDir != null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	protected AbstractCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zWMhpkWlaYCrUVP3cMZi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AbstractCodeEditorExtension()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				DefaultElmaReferences = new string[2]
				{
					(string)E9DSw5WlWUDKNZx4XRcw(-1123633026 ^ -1123637662),
					(string)E9DSw5WlWUDKNZx4XRcw(-882126494 ^ -882200840)
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				return;
			case 1:
				zWMhpkWlaYCrUVP3cMZi();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			DefaultGlobalReferences = new string[13]
			{
				(string)E9DSw5WlWUDKNZx4XRcw(-812025778 ^ -812058596),
				(string)E9DSw5WlWUDKNZx4XRcw(-521266112 ^ -521393824),
				(string)E9DSw5WlWUDKNZx4XRcw(-1979251663 ^ -1979315601),
				(string)E9DSw5WlWUDKNZx4XRcw(0x1A33FE36 ^ 0x1A3281EE),
				(string)E9DSw5WlWUDKNZx4XRcw(0x4A1640F ^ 0x4A0E429),
				(string)E9DSw5WlWUDKNZx4XRcw(0x76DD48E ^ 0x76CAB30),
				(string)E9DSw5WlWUDKNZx4XRcw(-398663332 ^ -398535578),
				(string)E9DSw5WlWUDKNZx4XRcw(-70037984 ^ -70157446),
				(string)E9DSw5WlWUDKNZx4XRcw(-1123633026 ^ -1123600252),
				(string)E9DSw5WlWUDKNZx4XRcw(0x4DC2B14D ^ 0x4DC3319D),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5114826B),
				(string)E9DSw5WlWUDKNZx4XRcw(0x63ABA4E8 ^ 0x63AA2466),
				(string)E9DSw5WlWUDKNZx4XRcw(0x4EDCBA32 ^ 0x4EDD3A8A)
			};
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object TqkbWvWdY5B5haFdDkye(object P_0)
	{
		return ((IOmniSharpWorker)P_0).CompletionLibsPath;
	}

	internal static bool ysWER0WdLmtSfF5rhhtI(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool qBMd9uWd5mwGjFxbym0R()
	{
		return jWcJ4kWdg7oA9iLbdB7S == null;
	}

	internal static AbstractCodeEditorExtension WdpgDJWdj3b3y0aC13SY()
	{
		return jWcJ4kWdg7oA9iLbdB7S;
	}

	internal static object roiMM4WdUFvmaJrpIHsh(object P_0)
	{
		return ((IOmniSharpWorker)P_0).ClientCompletionLibsPath;
	}

	internal static object gnu5J9WdsFcda3jnrjhE()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object wj73NaWdcGy7JivqSQKu(object P_0, LanguageVersion P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpParseOptions)P_0).WithLanguageVersion(P_1);
	}

	internal static object HvQ0G9WdzJ0MHCTnMrde(object P_0)
	{
		return ((BaseMethodDeclarationSyntax)P_0).get_Body();
	}

	internal static int OtQo8TWlFpyrbBLra71Y(object P_0)
	{
		return ((SyntaxNode)P_0).get_SpanStart();
	}

	internal static object xhmcGHWlBfGUTkryo2gU(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static object E9DSw5WlWUDKNZx4XRcw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NZQ8aYWlolFT5OxNBMMZ(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static object f6KnkZWlbqLBrEVCZQac(object P_0)
	{
		return DocumentationRaw(P_0);
	}

	internal static object JtZIUQWlhbcaHmDD2fsJ(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool ExSr1nWlGE4FOxmWsORJ(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object DAaqYKWlED0CQYr4osag(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static ScriptSourceType OxMlhXWlfLMoAsnaUT1Y(object P_0)
	{
		return ((IScriptSource)P_0).Type;
	}

	internal static object baYZmeWlQUoZE39nWrS2(object P_0)
	{
		return ((IScriptSource)P_0).Name;
	}

	internal static object x2FoI8WlCUIL7Uewnnou(object P_0, object P_1)
	{
		return GetSourceFilePath((string)P_0, (string)P_1);
	}

	internal static object uvJ7tBWlvf8oyQW37cAN(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static void Iix7EEWl84fVQ6ilN2hg(object P_0, FileAttributes P_1)
	{
		File.SetAttributes((string)P_0, P_1);
	}

	internal static void PZeD9kWlZU6V09dx2tP8(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}

	internal static bool DdaYLBWluW0HaiuVOi5Y(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object I6yDL3WlIHEkCJlT5dNY(object P_0)
	{
		return ((IScriptReference)P_0).AssemblyRaw;
	}

	internal static object upIpOpWlVJR83LBgMBLt(object P_0)
	{
		return ((IScriptReference)P_0).Name;
	}

	internal static object Ut2BLbWlSVLWXRkulg42(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object vqwniqWliB4vbiEM65AD(object P_0)
	{
		return ((IScriptReference)P_0).DocumentationRaw;
	}

	internal static void d775vEWlRrPmUnOWxNhS(object P_0, object P_1)
	{
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	internal static void oq1b2pWlqHxuDSuRF748(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object qwB5eTWlKDP4QaUQjaIn()
	{
		return IOExtensions.GetTempPath();
	}

	internal static DateTime aUuWkjWlXtliP4PJpfSI()
	{
		return DateTime.Now;
	}

	internal static object QN3dO9WlTMZK646MxlAs(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool K8JCTbWlkNUH0QYY4B1x(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object MuFdd5WlnTQse0OnylKx(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DocumentationRawStream;
	}

	internal static object SujF9hWlOdPaLkJ7mI5i(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object EWToDcWl2jtSSMWfwg9Z()
	{
		return ComponentManager.Current;
	}

	internal static object MOTOKUWleemFMlTKAPKK(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object uTSUGLWlPIojTOhjwvSR()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object M4TcV7Wl1jtmWxak3iQS(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object JPIiHSWlNTXimMAqBHKV(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool sk81cyWl3KFTd2c0G00U(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object VehgflWlpCoClBw06I27(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static void zWMhpkWlaYCrUVP3cMZi()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

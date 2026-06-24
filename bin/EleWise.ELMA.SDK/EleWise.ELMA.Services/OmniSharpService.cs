using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class OmniSharpService : IOmniSharpService
{
	private readonly IOmniSharpWorker omniSharpWorker;

	private readonly IEnumerable<ICodeEditorExtension> codeEditorExtensions;

	private readonly IGlobalModulesReferenceService globalModulesReferenceService;

	private static OmniSharpService OWwA05BtnabW1qaa6L0d;

	private string[] AssemblySearchPaths => new string[2]
	{
		(string)dotiGuBtx91VaoYQx7AR(omniSharpWorker),
		(string)xrIHBIBt0pipnDlBoWfW()
	};

	public OmniSharpService(IOmniSharpWorker omniSharpWorker, IEnumerable<ICodeEditorExtension> codeEditorExtensions, IGlobalModulesReferenceService globalModulesReferenceService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.omniSharpWorker = omniSharpWorker;
		this.codeEditorExtensions = codeEditorExtensions;
		this.globalModulesReferenceService = globalModulesReferenceService;
	}

	public void Start(bool needRestart)
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
				EST8tGBtelMjHpVTffOV(omniSharpWorker, needRestart);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Stop()
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
				H1rvMuBtPpILt4RBEwsu(omniSharpWorker);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.request = request;
		omniSharpWorker.Start(needRestart: false);
		if (CS_0024_003C_003E8__locals0.request == null)
		{
			return Task.FromResult<OmniSharpItem>(null);
		}
		ICodeEditorExtension codeEditorExtension = codeEditorExtensions.FirstOrDefault((ICodeEditorExtension q) => _003C_003Ec__DisplayClass6_0.jAWmE4QXkVXJjTIGhymb(q, CS_0024_003C_003E8__locals0.request));
		if (codeEditorExtension == null)
		{
			return Task.FromResult<OmniSharpItem>(null);
		}
		return codeEditorExtension.InitWorkspace(CS_0024_003C_003E8__locals0.request);
	}

	public Task<string> GetResult(OmniSharpRequest request)
	{
		return omniSharpWorker.GetResult(request.Command, request.PostData, request.FileName);
	}

	public Task AddReferences(AddReferencesRequest request)
	{
		//Discarded unreachable code: IL_00ca, IL_0112
		int num = 4;
		string text3 = default(string);
		List<string> list = default(List<string>);
		WebReferenceInfo webReferenceInfo = default(WebReferenceInfo);
		WebReferenceInfo[] array = default(WebReferenceInfo[]);
		int num3 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text4 = default(string);
		List<string> assembliesPathList = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					text3 = (string)I5ccSOBtphTbP50IREMo(s1Nkp6Bt3eeZOgj1KacL(request));
					num2 = 14;
					continue;
				case 14:
					list = new List<string>();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 11;
					}
					continue;
				case 7:
					webReferenceInfo = array[num3];
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					File.Copy(text, text2, overwrite: true);
					num2 = 19;
					continue;
				case 1:
				case 16:
					if (num3 >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				case 12:
					array = (WebReferenceInfo[])tiI8vdBta464x8HkQ0S4(request);
					num2 = 9;
					continue;
				case 11:
					text2 = (string)SYfHtQBtHH7WhbV8dfxe(text3, text4);
					num2 = 5;
					continue;
				case 8:
					break;
				case 4:
					if (request == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					assembliesPathList = GetAssembliesPathList((string[])QmWHjYBtNoY14rWL0PSg(request), request.GlobalModulesUids);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
					list.Add(text2);
					num2 = 17;
					continue;
				case 9:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					text = (string)S7kYufBtD13YefbqRNos(webReferenceInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					if (EZ4aARBtAZtUo9y24y4c(list) > 0)
					{
						num2 = 15;
						continue;
					}
					return (Task)bfKh0QBt1ubDHgc3r0RK();
				case 15:
					return omniSharpWorker.AddReferences(assembliesPathList, list, (string)s1Nkp6Bt3eeZOgj1KacL(request), (string)DMbRtiBt7UTQVJmQkD3s(request));
				case 3:
					return (Task)bfKh0QBt1ubDHgc3r0RK();
				default:
					if (!o45JIIBttxmwoNgtBwHs(text))
					{
						num2 = 18;
						continue;
					}
					break;
				case 17:
				case 18:
					num3++;
					num2 = 16;
					continue;
				case 6:
					if (EZ4aARBtAZtUo9y24y4c(assembliesPathList) <= 0)
					{
						num2 = 13;
						continue;
					}
					goto case 15;
				}
				break;
			}
			text4 = (string)VI0ED8Bt6ZJLqkFpvmD5(m9BDPEBtwVcSK7yUwawR(webReferenceInfo), hB2pKJBt4FiMB9JXuf04(-643786247 ^ -643727177));
			num = 11;
		}
	}

	private string GetAssemblyPath(string assemblyName)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass11_.fileName = (string)VI0ED8Bt6ZJLqkFpvmD5(assemblyName, hB2pKJBt4FiMB9JXuf04(--1360331293 ^ 0x511446A7));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return AssemblySearchPaths.Select(_003C_003Ec__DisplayClass11_._003CGetAssemblyPath_003Eb__0).FirstOrDefault(File.Exists);
			}
		}
	}

	public Task RemoveReferences(RemoveReferencesRequest request)
	{
		//Discarded unreachable code: IL_00e7, IL_00f6
		int num = 5;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		List<string> webReferencesPath = default(List<string>);
		List<string> assembliesPathList = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Ec__DisplayClass12_.projectFolderPath = (string)I5ccSOBtphTbP50IREMo(Uno8P3BtydYTdiNJ0I2W(request));
					num2 = 3;
					continue;
				case 3:
					webReferencesPath = ((IEnumerable<string>)lVQGm4BtMMfGACKEyJhN(request)).Select(_003C_003Ec__DisplayClass12_._003CRemoveReferences_003Eb__0).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				default:
					return omniSharpWorker.RemoveReferences(assembliesPathList, webReferencesPath, (string)Uno8P3BtydYTdiNJ0I2W(request), (string)Fhfl55BtJnJMJuXq7nXo(request));
				case 1:
					return (Task)bfKh0QBt1ubDHgc3r0RK();
				case 2:
					assembliesPathList = GetAssembliesPathList((string[])WxPMhsBtmtdyMwgsUIOC(request), request.GlobalModulesUids);
					num2 = 6;
					continue;
				case 4:
					if (request != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			num = 4;
		}
	}

	private List<string> GetAssembliesPathList(string[] assemblyNames, Guid[] globalModulesUids)
	{
		IEnumerable<string> first = assemblyNames.Select(GetAssemblyPath);
		IEnumerable<string> second = globalModulesUids.Select(globalModulesReferenceService.CreateGlobalModuleAssembly);
		return (from path in first.Concat(second)
			where path != null
			select path).ToList();
	}

	internal static void EST8tGBtelMjHpVTffOV(object P_0, bool needRestart)
	{
		((IOmniSharpWorker)P_0).Start(needRestart);
	}

	internal static bool VqTGtwBtOcw9nZottPkH()
	{
		return OWwA05BtnabW1qaa6L0d == null;
	}

	internal static OmniSharpService GwuYxOBt2yYWxIBIJq1G()
	{
		return OWwA05BtnabW1qaa6L0d;
	}

	internal static void H1rvMuBtPpILt4RBEwsu(object P_0)
	{
		((IOmniSharpWorker)P_0).Stop();
	}

	internal static object bfKh0QBt1ubDHgc3r0RK()
	{
		return Task.CompletedTask;
	}

	internal static object QmWHjYBtNoY14rWL0PSg(object P_0)
	{
		return ((AddReferencesRequest)P_0).AssemblyNames;
	}

	internal static object s1Nkp6Bt3eeZOgj1KacL(object P_0)
	{
		return ((AddReferencesRequest)P_0).ProjectFileName;
	}

	internal static object I5ccSOBtphTbP50IREMo(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object tiI8vdBta464x8HkQ0S4(object P_0)
	{
		return ((AddReferencesRequest)P_0).WebReferences;
	}

	internal static object S7kYufBtD13YefbqRNos(object P_0)
	{
		return ((WebReferenceInfo)P_0).CodeFilePath;
	}

	internal static bool o45JIIBttxmwoNgtBwHs(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object m9BDPEBtwVcSK7yUwawR(object P_0)
	{
		return ((WebReferenceInfo)P_0).WebReferenceName;
	}

	internal static object hB2pKJBt4FiMB9JXuf04(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VI0ED8Bt6ZJLqkFpvmD5(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object SYfHtQBtHH7WhbV8dfxe(object P_0, object P_1)
	{
		return AbstractCodeEditorExtension.GetSourceFilePath((string)P_0, (string)P_1);
	}

	internal static int EZ4aARBtAZtUo9y24y4c(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object DMbRtiBt7UTQVJmQkD3s(object P_0)
	{
		return ((AddReferencesRequest)P_0).FileName;
	}

	internal static object dotiGuBtx91VaoYQx7AR(object P_0)
	{
		return ((IOmniSharpWorker)P_0).CompletionLibsPath;
	}

	internal static object xrIHBIBt0pipnDlBoWfW()
	{
		return AssemblyReferenceHelper.GlobalAssemblyLocation;
	}

	internal static object WxPMhsBtmtdyMwgsUIOC(object P_0)
	{
		return ((RemoveReferencesRequest)P_0).AssemblyNames;
	}

	internal static object Uno8P3BtydYTdiNJ0I2W(object P_0)
	{
		return ((RemoveReferencesRequest)P_0).ProjectFileName;
	}

	internal static object lVQGm4BtMMfGACKEyJhN(object P_0)
	{
		return ((RemoveReferencesRequest)P_0).WebReferencesNames;
	}

	internal static object Fhfl55BtJnJMJuXq7nXo(object P_0)
	{
		return ((RemoveReferencesRequest)P_0).FileName;
	}
}

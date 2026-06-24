using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Bridge.Contract;
using Bridge.Translator;
using Bridge.Translator.Logging;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Models;
using EleWise.ELMA.BridgeCompiler.JavaScriptParser.Workers;
using EleWise.ELMA.BridgeCompiler.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using Microsoft.Ajax.Utilities;

namespace EleWise.ELMA.BridgeCompiler;

[Service]
internal sealed class BridgeAssemblyBuilder : IJavaScriptAssemblyBuilder
{
	private readonly ILogger elmaLogger;

	private byte[] assemblyRaw;

	private byte[] minAssemblyRaw;

	public string Errors { get; private set; }

	public byte[] AssemblyRaw => assemblyRaw;

	public byte[] MinAssemblyRaw => minAssemblyRaw;

	public BridgeAssemblyBuilder(ILogger elmaLogger)
	{
		this.elmaLogger = elmaLogger;
	}

	public IJavaScriptAssemblyModel CreateModel(string assemblyName, string folderPath, string assemblyFolderPath)
	{
		return new BridgeAssemblyModel(assemblyName, folderPath, assemblyFolderPath);
	}

	public bool Build(IJavaScriptAssemblyModel bridgeAssemblyModel, JavaScriptGeneratorConfiguration configuration)
	{
		EmitResult emitResult = Compile(bridgeAssemblyModel, configuration, out assemblyRaw, out minAssemblyRaw);
		if (!emitResult.Success)
		{
			ProcessErrors(emitResult.Errors);
			return false;
		}
		return emitResult.Success;
	}

	private EmitResult Compile(IJavaScriptAssemblyModel bridgeAssemblyModel, JavaScriptGeneratorConfiguration configuration, out byte[] peRaw, out byte[] minRaw)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0143: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		Contract.ArgumentNotNull(bridgeAssemblyModel, "bridgeAssemblyModel");
		if (configuration == null)
		{
			configuration = new JavaScriptGeneratorConfiguration();
		}
		peRaw = null;
		minRaw = null;
		string assemblyName = bridgeAssemblyModel.AssemblyName;
		Logger val = new Logger(assemblyName, true, (ILogger[])(object)new ILogger[1]
		{
			new MemoryLogger()
		});
		val.set_LoggerLevel((LoggerLevel)10);
		Logger val2 = val;
		MemoryLogger memoryLogger = (MemoryLogger)(object)val2.get_LoggerWriters()[0];
		string assemblyFolderPath = bridgeAssemblyModel.AssemblyFolderPath;
		if (string.IsNullOrWhiteSpace(assemblyFolderPath))
		{
			val2.Error("folderPath is empty");
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		if (string.IsNullOrWhiteSpace(assemblyName))
		{
			val2.Error("assemblyName is empty");
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		string text = (assemblyName.EndsWith(".dll") ? assemblyName : (assemblyName + ".dll"));
		string text2 = assemblyFolderPath + "\\" + text;
		if (!File.Exists(text2))
		{
			val2.Error(SR.T("Сборка по указанному пути {0} не найдена", text2));
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		AssemblyInfo val3 = new AssemblyInfo();
		AssemblyConfig val4 = new AssemblyConfig();
		val4.set_DisableInitAssembly(false);
		val4.set_FullName(assemblyName);
		val3.set_Assembly(val4);
		SourceMapConfig val5 = new SourceMapConfig();
		val5.set_Enabled(configuration.GenerateSourceMap);
		val3.set_SourceMap(val5);
		ReflectionConfig val6 = new ReflectionConfig();
		val6.set_Target((MetadataTarget)1);
		val3.set_Reflection((IReflectionConfig)val6);
		AssemblyInfo val7 = val3;
		BridgeTranslator bridgeTranslator = new BridgeTranslator(assemblyFolderPath, "", recursive: false, text2);
		((Translator)bridgeTranslator).set_FolderMode(true);
		((Translator)bridgeTranslator).set_Log((ILogger)(object)val2);
		((Translator)bridgeTranslator).set_Rebuild(false);
		((Translator)bridgeTranslator).set_AssemblyInfo((IAssemblyInfo)(object)val7);
		BridgeTranslator bridgeTranslator2 = bridgeTranslator;
		string[] array = bridgeAssemblyModel.SourceCodes.ToArray();
		if (array.Length == 0)
		{
			val2.Error(SR.T("Список исходного кода пуст"));
			peRaw = null;
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		string[] array2 = array;
		foreach (string sourceFilePath in array2)
		{
			bridgeTranslator2.AddSourceFile(sourceFilePath);
		}
		foreach (string reference in bridgeAssemblyModel.References)
		{
			bridgeTranslator2.AddReference(reference);
		}
		try
		{
			((Translator)bridgeTranslator2).Translate();
		}
		catch (Exception ex)
		{
			string text3 = SR.T("Ошибка транспиляции");
			elmaLogger.Fatal(text3, ex);
			val2.Error(text3 + " \r\n " + ex.StackTrace);
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		MetadataModel mdModel = new MetadataModel(bridgeAssemblyModel.ReplaceModels);
		CodeSettings val8 = new CodeSettings();
		((CommonSettings)val8).set_OutputMode((OutputMode)1);
		val8.set_MinifyCode(false);
		CodeSettings codeSettings = val8;
		string text4 = "";
		string text5 = "";
		try
		{
			foreach (string item in configuration.JsSourceCode)
			{
				text5 += item;
				text5 += "\r\n";
			}
			foreach (TranslatorOutputItem item2 in ((Translator)bridgeTranslator2).get_Outputs().get_Main())
			{
				text4 += item2.get_Content().GetContentAsString();
				text4 = new Worker(mdModel).ProcessSourceCode(text4, codeSettings);
				if (configuration.GenerateSourceMap && ((Translator)bridgeTranslator2).CheckIfRequiresSourceMap(item2))
				{
					text4 = bridgeTranslator2.GenerateSourceMap(item2.get_Name(), text4);
					item2.set_HasGeneratedSourceMap(true);
				}
				text4 += "\r\n";
				if (val7.get_Module() != null)
				{
					break;
				}
			}
		}
		catch (Exception ex2)
		{
			string text6 = SR.T("Ошибка обработки исполняемого кода");
			elmaLogger.Fatal(text6, ex2);
			val2.Error(text6 + " \r\n " + ex2.StackTrace);
			return EmitResult.ErrorResult(memoryLogger.GetMessages((LoggerLevel)10));
		}
		if (configuration.Minify)
		{
			Minifier val9 = new Minifier();
			CodeSettings val10 = new CodeSettings();
			val10.set_EvalTreatment((EvalTreatment)2);
			val10.set_LocalRenaming((LocalRenaming)0);
			((CommonSettings)val10).set_TermSemicolons(true);
			val10.set_StrictMode(false);
			val10.set_RemoveUnneededCode(false);
			CodeSettings val11 = val10;
			minAssemblyRaw = Encoding.UTF8.GetBytes(val9.MinifyJavaScript(text5 + text4, val11));
		}
		assemblyRaw = Encoding.UTF8.GetBytes(text5 + text4);
		return EmitResult.SuccessResult();
	}

	private void ProcessErrors(IEnumerable<string> errors)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string error in errors)
		{
			stringBuilder.AppendLine();
			stringBuilder.Append(error);
		}
		Errors = stringBuilder.ToString();
	}
}

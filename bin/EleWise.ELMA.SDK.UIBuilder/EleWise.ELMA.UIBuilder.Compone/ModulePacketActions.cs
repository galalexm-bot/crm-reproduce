using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UIBuilder.Components;

[Component(Order = 100, InjectProerties = false, Type = ComponentType.Server)]
internal sealed class ModulePacketActions : IPacketActions
{
	private static readonly ILogger importLog = Logger.GetLogger("ElmaImport");

	private readonly IModulePublishService modulePublishService;

	private readonly IScriptLoader scriptLoader;

	public ModulePacketActions(IModulePublishService modulePublishService, IScriptLoader scriptLoader)
	{
		this.modulePublishService = modulePublishService;
		this.scriptLoader = scriptLoader;
	}

	public bool BeforeCommitAction(PacketActionArgs args)
	{
		Contract.NotNull(args, "args");
		Contract.NotNull(args.Messages, "Messages");
		if (args.ContentType != "ModulePacket" || args.Entities == null)
		{
			return true;
		}
		ModuleMetadataItemHeader moduleMetadataItemHeader = args.Entities.OfType<ModuleMetadataItemHeader>().FirstOrDefault();
		if (moduleMetadataItemHeader == null)
		{
			return true;
		}
		if (!(args.Entities.OfType<ModuleMetadataItem>().FirstOrDefault()?.Metadata is ModuleInfoMetadata moduleInfoMetadata))
		{
			return true;
		}
		if (!(args.ImportSettings is ModuleImportSettings moduleImportSettings))
		{
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Импорт модуля {0} в неверном контексте исполнения. Модуль не будет автоматически опубликован", moduleInfoMetadata.Name)));
			return true;
		}
		if (!moduleImportSettings.Compatible)
		{
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Модуль {0} несовместим с текущей конфигурацией. Модуль не будет автоматически опубликован", moduleInfoMetadata.Name)));
			return true;
		}
		try
		{
			List<ScriptModule> scriptModules = (from c in moduleInfoMetadata.Components
				where c.ScriptUid.HasValue
				select scriptLoader.GetScript(c.ScriptUid.Value)).Concat(from f in moduleInfoMetadata.Functions
				where f.ScriptUid.HasValue
				select scriptLoader.GetScript(f.ScriptUid.Value)).ToList();
			WriteDebugLines(scriptModules, args.PacketData);
		}
		catch (Exception ex)
		{
			string text = SR.T("Возникла ошибка при публикации модуля {0} uid: {1}\n{2}", moduleMetadataItemHeader.DisplayName, moduleMetadataItemHeader.Uid, ex);
			importLog.Error(text);
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, endProcess: false));
			return false;
		}
		return true;
	}

	public bool AfterCommitAction(PacketActionArgs args)
	{
		Contract.NotNull(args, "args");
		Contract.NotNull(args.Messages, "Messages");
		if (args.ContentType != "ModulePacket" || args.Entities == null)
		{
			return true;
		}
		ModuleMetadataItemHeader moduleMetadataItemHeader = args.Entities.OfType<ModuleMetadataItemHeader>().FirstOrDefault();
		if (moduleMetadataItemHeader == null)
		{
			return true;
		}
		if (!(args.Entities.OfType<ModuleMetadataItem>().FirstOrDefault()?.Metadata is ModuleInfoMetadata moduleInfoMetadata))
		{
			return true;
		}
		if (!(args.ImportSettings is ModuleImportSettings moduleImportSettings))
		{
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Импорт модуля {0} в неверном контексте исполнения. Модуль не будет автоматически опубликован", moduleInfoMetadata.Name)));
			return true;
		}
		if (!moduleImportSettings.Compatible)
		{
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Модуль {0} несовместим с текущей конфигурацией. Модуль не будет автоматически опубликован", moduleInfoMetadata.Name)));
			return true;
		}
		try
		{
			List<ScriptModule> scriptModules = (from c in moduleInfoMetadata.Components
				where c.ScriptUid.HasValue
				select scriptLoader.GetScript(c.ScriptUid.Value)).Concat(from f in moduleInfoMetadata.Functions
				where f.ScriptUid.HasValue
				select scriptLoader.GetScript(f.ScriptUid.Value)).ToList();
			string comment = SR.T("Публикация после импорта");
			modulePublishService.Publish(moduleMetadataItemHeader.Uid, comment);
			moduleMetadataItemHeader.Refresh();
			string text = SR.T("Модуль {0} uid: {1} успешно опубликован", moduleMetadataItemHeader.DisplayName, moduleMetadataItemHeader.Uid);
			importLog.Info(text);
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text, endProcess: false));
			RemoveDebugLines(scriptModules, args.PacketData);
		}
		catch (Exception ex)
		{
			string text2 = SR.T("Возникла ошибка при публикации модуля {0} uid: {1}\n{2}", moduleMetadataItemHeader.DisplayName, moduleMetadataItemHeader.Uid, ex);
			importLog.Error(text2);
			args.Messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text2, endProcess: false));
			return false;
		}
		moduleMetadataItemHeader.Draft.Delete();
		moduleMetadataItemHeader.Draft = null;
		return true;
	}

	public bool ErrorAction(PacketActionArgs args, bool beforeCommit)
	{
		return beforeCommit;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void WriteDebugLines(IEnumerable<ScriptModule> scriptModules, IDictionary<string, string> packetData)
	{
		foreach (ScriptModule scriptModule in scriptModules)
		{
			DebugInfoHelper.AddDebugLine(scriptModule, packetData);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void RemoveDebugLines(IEnumerable<ScriptModule> scriptModules, IDictionary<string, string> packetData)
	{
		foreach (ScriptModule scriptModule in scriptModules)
		{
			DebugInfoHelper.RemoveDebugLine(scriptModule, packetData);
		}
	}
}

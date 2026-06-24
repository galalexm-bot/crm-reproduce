using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Services;
using EleWise.ELMA.UI.Services.FindComponent;
using EleWise.ELMA.UI.Services.FindComponent.Models;
using NHibernate;

namespace EleWise.ELMA.UIBuilder.Deploy.Import;

[Component]
internal sealed class ModuleMetadataImportExtension : NamedMetadataImportExtension<ModuleInfoMetadata>
{
	[Component(Order = 2100)]
	private class ModuleMetadataConfigImportExtension : ConfigImportExtension
	{
		private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;

		private readonly IModulePublishService modulePublishService;

		private readonly IActorContextService actorContextService;

		private readonly ISecurityService securityService;

		private readonly IWebDesignerCheckModulesService webDesignerCheckModulesService;

		private readonly ICleanUIObjectsService cleanUiObjectsService;

		private readonly ContextVars.Local<Dictionary<string, bool>> modulesDict = new ContextVars.Local<Dictionary<string, bool>>();

		private readonly ContextVars.Local<ICollection<Guid>> publishedModulesValue = new ContextVars.Local<ICollection<Guid>>();

		private ICollection<DeployLogMessage> DeployLogMessages
		{
			get
			{
				if (!actorContextService.TryGet("ActorContextDataClassImportDeployLogMessages", out var value))
				{
					actorContextService.Set("ActorContextDataClassImportDeployLogMessages", value = new List<DeployLogMessage>());
				}
				return (ICollection<DeployLogMessage>)value;
			}
		}

		public ModuleMetadataConfigImportExtension(ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager, IModulePublishService modulePublishService, IActorContextService actorContextService, ISecurityService securityService, IWebDesignerCheckModulesService webDesignerCheckModulesService, ICleanUIObjectsService cleanUiObjectsService)
		{
			this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
			this.modulePublishService = modulePublishService;
			this.actorContextService = actorContextService;
			this.securityService = securityService;
			this.webDesignerCheckModulesService = webDesignerCheckModulesService;
			this.cleanUiObjectsService = cleanUiObjectsService;
		}

		public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
		{
			if (parameters.ImportSettings is TestModuleImportSettings testModuleImportSettings && testModuleImportSettings.Incompatible)
			{
				parameters.ServiceData.Add("IncompatibleModuleKey", string.Empty);
			}
		}

		public override void OnPostReadPackets(PostReadPacketsParameters parameters)
		{
			if (modulesDict.Value == null)
			{
				modulesDict.Value = new Dictionary<string, bool>();
			}
			Dictionary<string, bool> value = modulesDict.Value;
			ElmaStoreComponentManifest manifest = parameters.Manifest;
			if (manifest != null && manifest.BpmApps != null && manifest.BpmApps.Count > 0)
			{
				foreach (BpmAppManifest bpmApp in manifest.BpmApps)
				{
					value[bpmApp.Id] = false;
				}
			}
			if (parameters.ImportStep == 1 && parameters.HeaderIds.Count == 0)
			{
				ICollection<Guid> importHeaders = GetImportHeaders(actorContextService);
				if (importHeaders.Count > 0)
				{
					Publish(importHeaders, parameters.Messages, parameters.TreeUid);
					if (publishedModulesValue.Value == null)
					{
						publishedModulesValue.Value = new List<Guid>();
					}
					publishedModulesValue.Value.AddRange(importHeaders);
					importHeaders.Clear();
				}
			}
			if (manifest == null)
			{
				return;
			}
			value[manifest.Id] = true;
			if (!value.All((KeyValuePair<string, bool> a) => a.Value))
			{
				return;
			}
			ICollection<Guid> value2 = publishedModulesValue.Value;
			if (value2 != null && value2.Count > 0)
			{
				try
				{
					cleanUiObjectsService.Clean(new CleanUIObjectsModel
					{
						Modules = value2.ToArray()
					});
				}
				catch (Exception exception)
				{
					Logger.Log.Error(SR.T("Возникла ошибка в процессе очистки версий модулей"), exception);
				}
			}
		}

		public override void OnPostPublish(PostPublishParameters parameters)
		{
			ICollection<DeployLogMessage> deployLogMessages = DeployLogMessages;
			if (deployLogMessages.Count > 0)
			{
				parameters.Messages.AddRange(deployLogMessages);
			}
		}

		public void Publish(IEnumerable<Guid> headerUids, ICollection<DeployLogMessage> messages = null, string treeUid = null)
		{
			messages = messages ?? DeployLogMessages;
			securityService.RunWithElevatedPrivilegies(delegate
			{
				IEnumerable<ModuleMetadataItemHeader> enumerable = Enumerable.Empty<ModuleMetadataItemHeader>();
				try
				{
					enumerable = moduleMetadataItemHeaderManager.FindByIdArray(headerUids.ToArray());
				}
				catch (Exception ex)
				{
					string text = SR.T("Не удалось упорядочить список компонентов для публикации, {0}", ex);
					ImportLog.Error(text);
					messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, endProcess: false));
				}
				string comment = SR.T("Публикация после импорта");
				bool flag = false;
				foreach (ModuleMetadataItemHeader item in enumerable)
				{
					Guid uid = item.Uid;
					_ = item.Draft;
					bool flag2 = ModuleMetadataItemHeaderManager.DesignerModules.Contains(uid);
					flag = flag || flag2;
					try
					{
						modulePublishService.Publish(uid, comment);
						item.Refresh();
						string text2 = SR.T("Модуль {0} uid: {1} успешно опубликован", item.DisplayName, uid);
						ImportLog.Info(text2);
						messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text2, endProcess: false));
					}
					catch (Exception exception)
					{
						string text3 = SR.T("Ошибка при публикации структур обмена данными");
						messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text3, endProcess: false));
						ImportLog.Error(text3, exception);
						if (!string.IsNullOrWhiteSpace(treeUid))
						{
							messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, ObjectsExportConsts.ExportExtensionUidDataClass, treeUid));
						}
					}
					ModuleMetadataItem draft = item.Draft;
					item.Draft = null;
					draft.Delete();
				}
				if (flag)
				{
					webDesignerCheckModulesService.ClearCache();
				}
			});
		}
	}

	[Component(Order = -90)]
	private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
	{
		private readonly IActorContextService actorContextService;

		private readonly ILazy<ModuleMetadataConfigImportExtension> moduleMetadataConfigImportExtension;

		public ModelAssemblyBuilderHandler(IActorContextService actorContextService, ILazy<ModuleMetadataConfigImportExtension> moduleMetadataConfigImportExtension)
		{
			this.actorContextService = actorContextService;
			this.moduleMetadataConfigImportExtension = moduleMetadataConfigImportExtension;
		}

		public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
		{
			ICollection<Guid> importHeaders = GetImportHeaders(actorContextService);
			if (importHeaders.Count > 0)
			{
				moduleMetadataConfigImportExtension.Value.Publish(importHeaders);
			}
		}

		public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
		{
		}

		public void AfterAll(IEnumerable<AbstractMetadata> publishMetadataList, IEnumerable<ScriptModule> scriptModules, IEnumerable<ScriptModule> clientScriptModules)
		{
		}
	}

	internal sealed class Tester
	{
		private static readonly string ErrorStart = SR.T("Ошибка при тестировании модуля: ");

		private readonly Func<Guid, string, bool> nameChecker;

		private readonly IModulePublishDataProvider modulePublishDataProvider;

		private readonly ITagService tagService;

		private readonly ModuleInfoMetadata metadata;

		private readonly Action<TestImportMessages> logger;

		private readonly TestModuleImportSettings settings;

		private readonly IModuleMetadataLoader moduleMetadataLoader;

		private static bool StrictModuleAvailabilityCheck => SR.GetSetting("StrictModuleAvailabilityCheck", defaultValue: true);

		public Tester(ModuleInfoMetadata metadata, Action<TestImportMessages> logger, TestModuleImportSettings settings, IModuleMetadataLoader moduleMetadataLoader, IModulePublishDataProvider modulePublishDataProvider, ITagService tagService, Func<Guid, string, bool> nameChecker)
		{
			this.metadata = metadata;
			this.logger = logger;
			this.settings = settings;
			this.moduleMetadataLoader = moduleMetadataLoader;
			this.modulePublishDataProvider = modulePublishDataProvider;
			this.tagService = tagService;
			this.nameChecker = nameChecker;
		}

		public ModuleInfoMetadata Test(IEnumerable<ModuleVersion> moduleVersions)
		{
			if (!TestTags(settings.Manifest))
			{
				logger(new TestImportMessages(TestImportMessagesType.Warning, SR.T("Модуль несовместим с текущей редакцией системы")));
				settings.Incompatible = true;
			}
			if (Version.TryParse(settings.Manifest.Version, out var moduleVersion) && moduleMetadataLoader.GetModuleVersionHeaders(settings.Manifest.ModuleUid).Any((ModuleVersionHeader v) => v.Version == moduleVersion))
			{
				logger(new TestImportMessages(TestImportMessagesType.Warning, SR.T("В системе установлен модуль той же версии")));
				settings.Incompatible = true;
				return null;
			}
			if (settings.ModuleMetadata != null)
			{
				LogError(SR.T("Конфигурация импорта содержит более одного модуля"));
				return settings.ModuleMetadata;
			}
			Guid moduleUid = metadata.ModuleUid;
			if (metadata.Name != settings.Manifest.Id)
			{
				LogError(SR.T("Имя модуля {0} не соответствует его идентификатору в манифесте {1}", metadata.Name, settings.Manifest.Id));
				return null;
			}
			if (!nameChecker(metadata.Uid, metadata.Name))
			{
				LogError(SR.T("В системе существует версия другого модуля с таким же именем"));
				return null;
			}
			try
			{
				ModuleVersion defaultModuleVersion = moduleMetadataLoader.GetDefaultModuleVersion(moduleUid);
				if (defaultModuleVersion != null && defaultModuleVersion.Metadata.Name != metadata.Name)
				{
					LogError(SR.T("В системе существует версия этого же модуля с другим именем: {0}", defaultModuleVersion.Metadata.Name));
					return null;
				}
			}
			catch (ModuleNotFoundException)
			{
			}
			if (metadata.Dependency == null)
			{
				LogError(SR.T("Зависимости импортируемого модуля должны быть вычислены до импорта"));
				return null;
			}
			if (settings.Incompatible)
			{
				return metadata;
			}
			try
			{
				modulePublishDataProvider.PrepareData(metadata, moduleVersions);
			}
			catch (ModuleNotFoundException ex2)
			{
				if (ex2.DisabledReason != 0 || !StrictModuleAvailabilityCheck)
				{
					logger(new TestImportMessages(TestImportMessagesType.Warning, SR.T("Модуль-зависимость отключен")));
					settings.Incompatible = true;
					return metadata;
				}
				LogError(SR.T("Ошибка при проверке публикуемости модуля: {0}\n{1})", ex2.Message, ex2.AdditionalInformation));
				return null;
			}
			return metadata;
		}

		private void LogError(string message)
		{
			logger(new TestImportMessages(TestImportMessagesType.Error, ErrorStart + message));
		}

		private bool TestTags(ElmaStoreComponentManifest manifest)
		{
			List<TestImportMessages> messages;
			bool result = tagService.ValidateTags(manifest, out messages);
			foreach (TestImportMessages item in messages)
			{
				logger(new TestImportMessages(TestImportMessagesType.InfoCommon, item.Text));
			}
			return result;
		}
	}

	private static readonly ILogger ImportLog = Logger.GetLogger("ElmaImport");

	private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly IActorContextService actorContextService;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModulePublishDataProvider modulePublishDataProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly ITagService tagService;

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public ModuleMetadataImportExtension(ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager, ModuleMetadataItemManager moduleMetadataItemManager, IActorContextService actorContextService, IModuleMetadataLoader moduleMetadataLoader, IModulePublishDataProvider modulePublishDataProvider, ISessionProvider sessionProvider, ITagService tagService)
	{
		this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.actorContextService = actorContextService;
		this.moduleMetadataLoader = moduleMetadataLoader;
		this.modulePublishDataProvider = modulePublishDataProvider;
		this.sessionProvider = sessionProvider;
		this.tagService = tagService;
	}

	protected override bool TestMetadata(ModuleInfoMetadata moduleMetadata, ReadMetadataParameters parameters, bool isTestRead)
	{
		if (!(parameters.ImportSettings is TestModuleImportSettings testModuleImportSettings))
		{
			if (!(parameters.ImportSettings is ModuleImportSettings))
			{
				parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Импорт модуля {0} в неверном контексте исполнения. Модуль не будет автоматически опубликован", moduleMetadata.Name)));
				return false;
			}
			return true;
		}
		testModuleImportSettings.ModuleMetadata = new Tester(moduleMetadata, parameters.TestMessagesAdd, testModuleImportSettings, moduleMetadataLoader, modulePublishDataProvider, tagService, CheckName).Test(testModuleImportSettings.ModuleMetadataContext);
		if (testModuleImportSettings.HasErrors)
		{
			return false;
		}
		return true;
		bool CheckName(Guid moduleUid, string name)
		{
			Guid guid = (from h in Session.Query<ModuleMetadataItemHeader>()
				where h.Name == name
				select h.Uid).FirstOrDefault();
			if (!(guid == Guid.Empty))
			{
				return guid == moduleUid;
			}
			return true;
		}
	}

	protected override void SaveMetadata(ModuleInfoMetadata moduleMetadata, ReadMetadataParameters parameters)
	{
		if (!(parameters.ImportSettings is ModuleImportSettings moduleImportSettings))
		{
			parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Импорт модуля {0} в неверном контексте исполнения. Модуль не будет автоматически опубликован", moduleMetadata.Name)));
			return;
		}
		if (!moduleImportSettings.Compatible)
		{
			parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T("Модуль {0} несовместим с текущей конфигурацией. Модуль не будет автоматически опубликован", moduleMetadata.Name)));
			return;
		}
		ModuleMetadataItemHeader moduleMetadataItemHeader = moduleMetadataItemHeaderManager.LoadOrNull(moduleMetadata.ModuleUid);
		try
		{
			ModuleMetadataItem moduleMetadataItem = moduleMetadataItemHeader?.Draft;
			if (moduleMetadataItem == null)
			{
				moduleMetadataItem = moduleMetadataItemManager.Create();
				if (moduleMetadataItemHeader != null)
				{
					moduleMetadataItem.Header = moduleMetadataItemHeader;
					moduleMetadataItemHeader.Draft = moduleMetadataItem;
				}
				moduleMetadataItem.Metadata = moduleMetadata;
				moduleMetadataItemManager.Save(moduleMetadataItem);
				moduleMetadataItemHeader = moduleMetadataItem.Header;
			}
			else
			{
				moduleMetadataItem.Metadata = moduleMetadata;
				moduleMetadataItemManager.Save(moduleMetadataItem);
			}
			if (parameters.ServiceData.TryGetValue("ModuleVersion", out var value))
			{
				moduleMetadataItem.Version = value;
			}
			if (parameters.ServiceData.TryGetValue("ModuleAssemblyName", out var value2))
			{
				moduleMetadataItem.AssemblyName = value2;
			}
			if (parameters.ServiceData.TryGetValue("ModuleAssemblyRaw", out var value3))
			{
				moduleMetadataItem.AssemblyRaw = value3.HexStringToByteArray();
			}
			if (parameters.ServiceData.TryGetValue("ModuleClientAssemblyRaw", out var value4))
			{
				moduleMetadataItem.ClientAssemblyRaw = value4.HexStringToByteArray();
			}
			if (parameters.ServiceData.TryGetValue("ModuleDebugRaw", out var value5))
			{
				moduleMetadataItem.DebugRaw = value5.HexStringToByteArray();
			}
			if (parameters.ServiceData.TryGetValue("ModuleClientDebugRaw", out var value6))
			{
				moduleMetadataItem.ClientDebugRaw = value6.HexStringToByteArray();
			}
			if (parameters.ServiceData.TryGetValue("ModuleClientRaw", out var value7))
			{
				moduleMetadataItem.ClientRaw = value7.HexStringToByteArray();
			}
			Type type = (ImportLog.IsInfoEnabled() ? moduleMetadata.GetType() : null);
			ImportLog.InfoFormat("Start import {0} metadata Uid = {1}", type?.Name, moduleMetadata.Uid);
			moduleMetadataItem.Save();
			ImportLog.InfoFormat("End import {0} metadata Uid = {1}", type?.Name, moduleMetadata.Uid);
			parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T("Импорт метаданных \"{1}\" ({2} Uid = {0})", moduleMetadata.Uid, moduleMetadata.DisplayName, moduleMetadata.Name), endProcess: false));
			GetImportHeaders(actorContextService).Add(moduleMetadataItem.Header.Uid);
		}
		catch (Exception ex)
		{
			string text = SR.T("Возникла ошибка при публикации модуля {0} uid: {1}\n{2}", moduleMetadataItemHeader.DisplayName, moduleMetadataItemHeader.Uid, ex);
			ImportLog.Error(text);
			parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, endProcess: false));
		}
	}

	private static ICollection<Guid> GetImportHeaders(IActorContextService actorContextService)
	{
		if (!actorContextService.TryGet("ActorContextModuleImportHeaders", out var value))
		{
			actorContextService.Set("ActorContextModuleImportHeaders", value = new List<Guid>());
		}
		return (ICollection<Guid>)value;
	}
}

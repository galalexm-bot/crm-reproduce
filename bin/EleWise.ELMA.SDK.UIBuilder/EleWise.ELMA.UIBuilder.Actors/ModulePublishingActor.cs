using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.Model;
using EleWise.ELMA.UIBuilder.Services;

namespace EleWise.ELMA.UIBuilder.Actors;

internal sealed class ModulePublishingActor : Actor, IModulePublishingActor, IActorWithGuidKey, IActor
{
	private const string LockKey = "ModuleMetadataItemNewVersion_";

	private const string ReminderNamePrefix = "ModulePublishingActor";

	private const string IgnorePrecompiled = "Modules.IgnorePrecompiled";

	private static readonly Version DefaultVersion = new Version(1, 0, 0, 0);

	private readonly IModulePublishDataProvider modulePublishDataProvider;

	private readonly IModuleBuilderService moduleBuilderService;

	private readonly ModuleMetadataItemManager itemManager;

	private readonly ModuleMetadataItemHeaderManager headerManager;

	private readonly IAuthenticationService authenticationService;

	private readonly ILockManager lockManager;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly IFeatureFlagService featureFlagService;

	private readonly ILogger logger;

	private bool publicationStarted;

	public override TimeSpan LifeTime { get; } = TimeSpan.FromHours(1.0);


	public ModulePublishingActor(ILoggerFactory loggerFactory, IModulePublishDataProvider modulePublishDataProvider, IModuleBuilderService moduleBuilderService, ModuleMetadataItemManager itemManager, ModuleMetadataItemHeaderManager headerManager, IAuthenticationService authenticationService, ILockManager lockManager, IUnitOfWorkManager unitOfWorkManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, IServerPlacementPublishService serverPlacementPublishService, IFeatureFlagService featureFlagService)
	{
		this.modulePublishDataProvider = modulePublishDataProvider;
		this.moduleBuilderService = moduleBuilderService;
		this.itemManager = itemManager;
		this.headerManager = headerManager;
		this.authenticationService = authenticationService;
		this.lockManager = lockManager;
		this.unitOfWorkManager = unitOfWorkManager;
		this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
		this.serverPlacementPublishService = serverPlacementPublishService;
		this.featureFlagService = featureFlagService;
		logger = loggerFactory.CreateLogger(typeof(ModulePublishingActor));
	}

	public override async Task ReceiveReminder(string reminderName)
	{
		logger.Debug("ReceiveReminder " + reminderName);
		try
		{
			Guid moduleMetadataItemHeaderUid = GetPrimaryKey<Guid>();
			if (!publicationStarted)
			{
				logger.Debug("ReceiveReminder " + reminderName + ". Publication Error");
				await Task.WhenAll(serverPlacementPublishService.For<IModulePublishingServerInstanceActor>().Publish((IModulePublishingServerInstanceActor actor) => actor.PublicationError(moduleMetadataItemHeaderUid, new Exception(SR.T("Ошибка публикации модуля. Uid = {0}", moduleMetadataItemHeaderUid)))), UnregisterReminder(reminderName));
			}
		}
		catch (Exception exception)
		{
			logger.Error("ReceiveReminder " + reminderName + " error", exception);
		}
	}

	public async Task Publish(string comment)
	{
		Guid moduleMetadataItemHeaderUid = GetPrimaryKey<Guid>();
		if (publicationStarted)
		{
			throw new InvalidOperationException(SR.T("В данный момент модуль уже публикуется на сервере. Повторите попытку позже"));
		}
		publicationStarted = true;
		await RegisterOrUpdateReminder(string.Format("{0}_{1}", "ModulePublishingActor", moduleMetadataItemHeaderUid), TimeSpan.FromMinutes(1.0), TimeSpan.FromMinutes(1.0));
		RunExternalTask(() => PublishInternal(moduleMetadataItemHeaderUid, comment));
	}

	public async Task PublishComplete()
	{
		try
		{
			string text = string.Format("{0}_{1}", "ModulePublishingActor", GetPrimaryKey<Guid>());
			logger.Debug("UnregisterReminder " + text);
			await UnregisterReminder(text);
		}
		finally
		{
			DeactivateOnIdle();
		}
	}

	private async Task PublishInternal(Guid moduleMetadataItemHeaderUid, string comment)
	{
		using (CallContextSessionOwner.Create())
		{
			using IUnitOfWork unitOfWork = unitOfWorkManager.Create(string.Empty, transactional: true);
			_ = 1;
			try
			{
				Publish(headerManager.LoadOrNull(moduleMetadataItemHeaderUid), comment);
				unitOfWork.Commit();
				await serverPlacementPublishService.For<IModulePublishingServerInstanceActor>().Publish((IModulePublishingServerInstanceActor actor) => actor.PublicationSuccess(moduleMetadataItemHeaderUid));
			}
			catch (Exception ex2)
			{
				Exception ex = ex2;
				unitOfWork.Rollback();
				logger.Error(SR.T("Ошибка публикации модуля"), ex);
				await serverPlacementPublishService.For<IModulePublishingServerInstanceActor>().Publish((IModulePublishingServerInstanceActor actor) => actor.PublicationError(moduleMetadataItemHeaderUid, ex));
				throw;
			}
			finally
			{
				publicationStarted = false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Publish(ModuleMetadataItemHeader header, string comment)
	{
		Contract.NotNull(header, "header");
		if (!Version.TryParse(header.Draft.Version, out var result))
		{
			ModuleMetadataItem published = header.Published;
			result = ((published == null || !Version.TryParse(published.Version, out result)) ? DefaultVersion : NextRevision(result));
		}
		Publish(header, comment, result.ToString());
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Publish(ModuleMetadataItemHeader header, string comment, string version)
	{
		Contract.NotNull(header, "header");
		Contract.NotNullOrEmpty(version, "version");
		using (lockManager.Lock("ModuleMetadataItemNewVersion_" + header.Id))
		{
			ModuleMetadataItem draft = header.Draft;
			ModuleMetadataItem published = header.Published;
			header.Published = draft;
			header.Save();
			IUser currentUser = authenticationService.GetCurrentUser();
			ModuleInfoMetadata moduleInfoMetadata = (ModuleInfoMetadata)ClassSerializationHelper.CloneObjectByXml(draft.Metadata);
			Guid guid = ModuleMetadataItemManager.VersionUid(moduleInfoMetadata, version);
			ModuleMetadataItem moduleMetadataItem = itemManager.Create();
			foreach (DataClassMetadata dataClass in moduleInfoMetadata.DataClasses)
			{
				DataClassTypeReference dataClassTypeReference = new DataClassTypeReference
				{
					MetadataUid = dataClass.Uid,
					ItemUid = guid
				};
				dataClass.TypeRef = dataClassTypeReferenceManager.Save(dataClassTypeReference).ToString();
			}
			foreach (ComponentMetadata component in moduleInfoMetadata.Components)
			{
				foreach (DataClassMetadata dataClass2 in component.DataClasses)
				{
					DataClassTypeReference dataClassTypeReference2 = new DataClassTypeReference
					{
						MetadataUid = dataClass2.Uid,
						ItemUid = guid
					};
					dataClass2.TypeRef = dataClassTypeReferenceManager.Save(dataClassTypeReference2).ToString();
				}
			}
			ModuleBuildResult moduleBuildResult = ((draft.AssemblyRaw != null && draft.ClientAssemblyRaw != null && draft.ClientDebugRaw != null && !featureFlagService.Enabled("Modules.IgnorePrecompiled", defaultEnabled: true)) ? new ModuleBuildResult
			{
				ServerBuildResult = new ServerBuildResult(draft.AssemblyRaw, draft.DebugRaw, draft.AssemblyName),
				ClientBuildResult = new ClientBuildResult(draft.ClientRaw, draft.ClientAssemblyRaw, draft.ClientDebugRaw, ModuleMetadataItemManager.ClientAssemblyName(moduleInfoMetadata))
			} : moduleBuilderService.Build(guid, moduleInfoMetadata, version));
			moduleMetadataItem.Uid = guid;
			moduleMetadataItem.Metadata = moduleInfoMetadata;
			moduleMetadataItem.CreationDate = DateTime.Now;
			moduleMetadataItem.CreationAuthorId = (long?)currentUser?.GetId();
			moduleMetadataItem.Header = header;
			moduleMetadataItem.Comment = comment;
			moduleMetadataItem.Version = version;
			moduleMetadataItem.AssemblyRaw = moduleBuildResult.ServerBuildResult.AssemblyRaw;
			moduleMetadataItem.DebugRaw = moduleBuildResult.ServerBuildResult.DebugRaw;
			moduleMetadataItem.AssemblyName = moduleBuildResult.ServerBuildResult.AssemblyName;
			moduleMetadataItem.ClientRaw = moduleBuildResult.ClientBuildResult.AssemblyRaw;
			moduleMetadataItem.ClientAssemblyRaw = moduleBuildResult.ClientBuildResult.MinJsAssemblyRaw;
			moduleMetadataItem.ClientDebugRaw = moduleBuildResult.ClientBuildResult.JsAssemblyRaw;
			moduleMetadataItem.Signature = moduleInfoMetadata.GetSignature();
			moduleMetadataItem.Save();
			if (published == null || NewVersion(published.Version, version))
			{
				header.Published = moduleMetadataItem;
			}
			else
			{
				header.Published = published;
			}
			header.Save();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool NewVersion(string old, string @new)
	{
		if (string.IsNullOrEmpty(@new) || !Version.TryParse(@new, out var result))
		{
			return false;
		}
		if (string.IsNullOrEmpty(old) || !Version.TryParse(old, out var result2))
		{
			return true;
		}
		return result > result2;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private Version NextRevision(Version version)
	{
		return new Version(version.Major, version.Minor, version.Build, version.Revision + 1);
	}
}

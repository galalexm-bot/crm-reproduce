using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Configuration;
using EleWise.ELMA.FileProvider.Distributed.ExtensionPoints;
using EleWise.ELMA.FileProvider.Distributed.IO;
using EleWise.ELMA.FileProvider.Distributed.Managers;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.FileProvider.Distributed.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Runtime.Providers.Impl;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.FileProvider.Distributed;

public class DistributedFileStoreProvider : FileSystemFileStoreProvider, IFileGatewayService, IUploadUrlGenerator, IDownloadUrlService, IBinaryFileLegacyBehaviorProvider, IInitHandler
{
	internal class ElmaStyleUriParser : GenericUriParser
	{
		public ElmaStyleUriParser(GenericUriParserOptions options)
			: base(options)
		{
		}
	}

	[Serializable]
	public class RemoteLazyBinaryFile : BinaryFile
	{
		private bool isPropertiesLoaded;

		private bool isContentLoaded;

		private readonly bool needCheckLocation;

		private Uri location;

		private long contentLength;

		private uint crc;

		public bool Loaded => isPropertiesLoaded;

		public override Uri ContentLocation => location ?? (location = Locator.GetServiceNotNull<DistributedFileStoreProvider>().GetLazyFileLocation(base.Id));

		public override string ContentType
		{
			get
			{
				CheckLoaded();
				return base.ContentType;
			}
			set
			{
				CheckLoaded();
				base.ContentType = value;
			}
		}

		public override DateTime CreateDate
		{
			get
			{
				CheckLoaded();
				return base.CreateDate;
			}
			set
			{
				CheckLoaded();
				base.CreateDate = value;
			}
		}

		public override string Name
		{
			get
			{
				CheckLoaded();
				return base.Name;
			}
			set
			{
				CheckLoaded();
				base.Name = value;
			}
		}

		[Obsolete("Свойство устарело. Для доступа к контенту используйте BinaryFile.GetContent(). Для установки контента рекомендуется создать новый файл через BinaryFile.CreateNew() или BinaryFile.CreateFrom().")]
		public override string ContentFilePath
		{
			get
			{
				CheckLoaded(needLoadContentLocally: true);
				return base.ContentFilePath;
			}
			set
			{
				CheckLoaded(needLoadContentLocally: true);
				base.ContentFilePath = value;
			}
		}

		public override Guid Uid
		{
			get
			{
				CheckLoaded();
				return base.Uid;
			}
			set
			{
				CheckLoaded();
				base.Uid = value;
			}
		}

		public override string SecondId
		{
			get
			{
				CheckLoaded();
				return base.SecondId;
			}
			set
			{
				base.SecondId = value;
			}
		}

		public override bool Encrypt
		{
			get
			{
				CheckLoaded();
				return base.Encrypt;
			}
			set
			{
				CheckLoaded();
				base.Encrypt = value;
			}
		}

		public override string Salt
		{
			get
			{
				CheckLoaded();
				return base.Salt;
			}
			set
			{
				CheckLoaded();
				base.Salt = value;
			}
		}

		public RemoteLazyBinaryFile(string id)
			: this(id, needCheckLocation: true)
		{
		}

		public RemoteLazyBinaryFile(string id, bool needCheckLocation)
		{
			this.needCheckLocation = needCheckLocation;
			base.Id = id;
		}

		internal void CheckLoaded(bool needLoadContentLocally = false)
		{
			if ((!needLoadContentLocally && isPropertiesLoaded) || (needLoadContentLocally && isPropertiesLoaded && isContentLoaded))
			{
				return;
			}
			SystemFileNHManager serviceNotNull = Locator.GetServiceNotNull<SystemFileNHManager>();
			try
			{
				SystemFile systemFile = serviceNotNull.LoadFile(base.Id);
				if (systemFile == null)
				{
					throw new FileNotFoundException(SR.T("Файл не найден в хранилище (по идентификатору {0})", base.Id));
				}
				string text = null;
				if (needLoadContentLocally)
				{
					text = BinaryFile.CreateContentFilePath(Name);
					Stream obj = (systemFile.IsDeleted ? FileSystemFileStoreProvider.GetNotFoundStubStreamFromResources(Extension) : GetContent(GetContentOptions.NonSeekable));
					Contract.NotNull(obj, "dest should not be null");
					FileStream destination = new FileStream(text, FileMode.OpenOrCreate);
					obj.CopyAllBytesToStream(destination);
					location = new Uri(text);
					isContentLoaded = true;
				}
				base.Uid = systemFile.Uid;
				base.CreateDate = systemFile.CreateDate;
				name = systemFile.Name;
				base.ContentType = systemFile.ContentType;
				base.Encrypt = systemFile.Encrypt;
				base.Salt = systemFile.Salt;
				if (!systemFile.FileSize.HasValue)
				{
					throw new NotImplementedException();
				}
				contentLength = systemFile.FileSize.Value;
				crc = BinaryFile.ParseCrc(systemFile.FileCrc);
				if (systemFile.Id > 0)
				{
					base.SecondId = systemFile.Id.ToString(CultureInfo.InvariantCulture);
				}
				isPropertiesLoaded = true;
			}
			catch (Exception ex)
			{
				EleWise.ELMA.Logging.Logger.GetLogger("Files").Info(ex.Message);
				throw;
			}
		}

		public override long GetSize()
		{
			CheckLoaded();
			return contentLength;
		}

		public override uint GetCrc()
		{
			CheckLoaded();
			return crc;
		}

		protected override bool IsLoaded()
		{
			return Loaded;
		}

		protected override void CheckLoadedImpl(bool loadFile = false)
		{
			CheckLoaded(loadFile);
		}
	}

	private const string UserStorageBindingTemplate = "User_{0}";

	private const long DefaultMaxFileSizeToStoreInMemory = 10485760L;

	private readonly Guid UserStorageBindingGuid = new Guid("61FEC102-A22E-48BC-BA35-9975550E0D44");

	private readonly IEnumerable<IVicinityContextHandler> vicinityContextHandlers;

	private EndpointsCollection endpoints;

	private IStorageOperationsProvider storageOperationsProvider;

	private IUploadedContentLocationMapperService uploadedContentLocationMapperService;

	private DistributedFileOriginManager fileOriginManager;

	private IHttpContextAccessor httpContextAccessor;

	private string filesRootFolder = "files";

	private string previewsRootFolder = "previews";

	private string tempRootFolder = "temp";

	internal IUploadUrlFactory uploadUrlFactory;

	internal IDownloadUrlFactory downloadUrlFactory;

	internal string privateKeyPath;

	protected DistributedFileOriginManager FileOriginManager => fileOriginManager ?? (fileOriginManager = Locator.GetServiceNotNull<DistributedFileOriginManager>());

	protected IHttpContextAccessor HttpContextAccessor => httpContextAccessor ?? (httpContextAccessor = Locator.GetServiceNotNull<IHttpContextAccessor>());

	protected IEnumerable<IVicinityContextHandler> VicinityContextHandlers => vicinityContextHandlers;

	internal IUploadUrlFactory UploadUrlFactory => uploadUrlFactory;

	internal IDownloadUrlFactory DownloadUrlFactory => downloadUrlFactory;

	public override string FilesPath
	{
		get
		{
			return filesRootFolder;
		}
		set
		{
		}
	}

	public override string PreviewsPath
	{
		get
		{
			return previewsRootFolder;
		}
		set
		{
		}
	}

	public override string TempFilesPath
	{
		get
		{
			return tempRootFolder;
		}
		set
		{
		}
	}

	protected override IStorageOperationsProvider StorageOperationsProvider => storageOperationsProvider;

	string IFileGatewayService.SystemGateway => endpoints.DefaultEndpointName;

	string[] IFileGatewayService.AllGateways => endpoints.AllEndpointNames.ToArray();

	public DistributedFileStoreProvider()
	{
	}

	public DistributedFileStoreProvider(IEnumerable<IPreUploadFile> componentsPreUploadFile, IEnumerable<IVicinityContextHandler> vicinityContextHandlers)
		: base(componentsPreUploadFile)
	{
		this.vicinityContextHandlers = vicinityContextHandlers;
	}

	protected override string DoProviderSpecificInitialization(string name, NameValueCollection config)
	{
		if (string.IsNullOrEmpty(name))
		{
			name = "DistributedFileStoreProvider";
		}
		base.Logger.InfoFormat(SR.T("Выполняется настройка провайдера {0}...", name));
		IRuntimeApplication runtimeApplication = ComponentManager.Current.GetExtensionPoints<IRuntimeApplication>().First();
		string directoryName = Path.GetDirectoryName(runtimeApplication.Configuration.Config.FilePath);
		if (directoryName != null)
		{
			previewsRootFolder = Path.Combine(directoryName, previewsRootFolder);
			tempRootFolder = Path.Combine(directoryName, tempRootFolder);
		}
		privateKeyPath = config["privateKeyPath"];
		if (string.IsNullOrEmpty(privateKeyPath))
		{
			throw new ConfigurationErrorsException(SR.T("В конфигурации не указан закрытый ключ сервера (privateKeyPath)."));
		}
		DistributedStorageSettings.Initialize(runtimeApplication.Configuration.Config);
		DistributedStorageSettings.FileGatewaysCollection fileGateways = DistributedStorageSettings.Settings.FileGateways;
		if (fileGateways.Count == 0)
		{
			throw new ConfigurationErrorsException(SR.T("В конфигурации не объявлено ни одного файлового шлюза."));
		}
		try
		{
			List<Endpoint> list = new List<Endpoint>(fileGateways.Count);
			for (int i = 0; i < fileGateways.Count; i++)
			{
				list.Add(new Endpoint(fileGateways[i]));
			}
			endpoints = new EndpointsCollection(list, base.Logger);
			UriParser.Register(new ElmaStyleUriParser(GenericUriParserOptions.AllowEmptyAuthority | GenericUriParserOptions.NoUserInfo | GenericUriParserOptions.NoPort | GenericUriParserOptions.NoQuery | GenericUriParserOptions.NoFragment), "elma", -1);
			storageOperationsProvider = CreateStorageOperationsProvider();
			return name;
		}
		catch (Exception ex)
		{
			base.Logger.Error("Error configuring provider", ex);
			throw new ConfigurationErrorsException(SR.T("При конфигурации провайдера произошла ошибка."), ex);
		}
	}

	protected override IStorageOperationsProvider CreateStorageOperationsProvider()
	{
		IStorageOperationsProvider localFsOperationsProvider = base.CreateStorageOperationsProvider();
		DistributedStorageApiUrlGenerator apiUrlGenerator = new DistributedStorageApiUrlGenerator(endpoints, privateKeyPath);
		DistributedFsLocationSchemaCollection locationSchemaCollection = new DistributedFsLocationSchemaCollection(endpoints, FileGatewayService);
		return (IStorageOperationsProvider)(uploadedContentLocationMapperService = (IUploadedContentLocationMapperService)(uploadUrlFactory = (IUploadUrlFactory)(downloadUrlFactory = new DistributedStorageOperationsProvider(base.Logger, endpoints, FileGatewayService, apiUrlGenerator, locationSchemaCollection, localFsOperationsProvider))));
	}

	protected override void PostSaveActions(SystemFile file, BinaryFile binaryFile)
	{
		string host = binaryFile.ContentLocation.Host;
		FileOriginManager.SaveOrigin(file, host);
	}

	protected override BinaryFile GetLoadedBinaryFile(string id)
	{
		return new RemoteLazyBinaryFile(id);
	}

	public override Stream GetContent(BinaryFile binaryFile, GetContentOptions options = null)
	{
		options = options ?? GetContentOptions.Default;
		Stream content = base.GetContent(binaryFile, options);
		if (options.ForAsync && options.Seekable)
		{
			throw new NotSupportedException(SR.T("Асинхронное получение контента с удалённого узла с поддержкой позиционирования не поддерживается"));
		}
		if (options.Seekable && !content.CanSeek)
		{
			long size = binaryFile.GetSize();
			Stream stream = ((size <= 10485760) ? ((Stream)MemoryHelper.GetMemoryStream((int)size)) : ((Stream)new SeekableStreamOverLocalFile()));
			using (content)
			{
				content.CopyTo(stream);
			}
			stream.Flush();
			stream.Position = 0L;
			return stream;
		}
		return content;
	}

	protected override Task CopyToNearestStorageAsync(string id, CancellationToken token)
	{
		SystemFile systemFile = base.SystemFileManager.LoadFile(id);
		if (systemFile == null)
		{
			throw new FileNotFoundException(SR.T("Файл не найден в хранилище (по идентификатору {0})", id));
		}
		return StorageOperationsProvider.FetchContentAsync(systemFile, token);
	}

	protected override void RegisterAdditionalServices(ContainerBuilder containerBuilder)
	{
		base.RegisterAdditionalServices(containerBuilder);
		RegistrationExtensions.RegisterInstance<DistributedFileStoreProvider>(containerBuilder, this).As(new Type[2]
		{
			typeof(IUploadUrlGenerator),
			typeof(IDownloadUrlService)
		}).SingleInstance();
		RegistrationExtensions.RegisterInstance<IUploadedContentLocationMapperService>(containerBuilder, uploadedContentLocationMapperService).As<IUploadedContentLocationMapperService>().SingleInstance();
	}

	Uri IBinaryFileLegacyBehaviorProvider.InitializeContentLocation(BinaryFile binaryFile)
	{
		throw new NotSupportedException(SR.T("Распределённый файловый провайдер не поддерживает инициализацию ContentLocation. Эта возможность только для обеспечения совместимости штатного провайдера."));
	}

	long? IBinaryFileLegacyBehaviorProvider.GetLength(BinaryFile binaryFile)
	{
		return null;
	}

	uint? IBinaryFileLegacyBehaviorProvider.GetCrc(BinaryFile binaryFile)
	{
		return null;
	}

	string IFileGatewayService.GetClosestGateway()
	{
		VicinityContext vicinityContext = new VicinityContext
		{
			CurrentUser = FileSystemFileStoreProvider.AuthenticationService.GetCurrentUser(),
			HttpContext = HttpContextAccessor.Current()
		};
		string text = ((vicinityContext.CurrentUser != null) ? $"User_{vicinityContext.CurrentUser.GetId()}" : null);
		string text2 = (string.IsNullOrEmpty(text) ? null : DataAccessManager.BLOBManager.GetBLOB<string>(UserStorageBindingGuid, text));
		if (!text2.IsNullOrEmpty())
		{
			return text2;
		}
		Guid activeVicinityHandler = Guid.Empty;
		string text3 = VicinityContextHandlers.FirstOrDefault((IVicinityContextHandler c) => c.Uid == activeVicinityHandler)?.Handle(vicinityContext);
		return string.IsNullOrEmpty(text3) ? endpoints.DefaultEndpointName : text3;
	}

	string IFileGatewayService.GetUserGateway(IUser user)
	{
		string text = ((user == null) ? null : $"User_{user.GetId()}");
		if (!text.IsNullOrEmpty())
		{
			return DataAccessManager.BLOBManager.GetBLOB<string>(UserStorageBindingGuid, text);
		}
		return null;
	}

	void IFileGatewayService.SetUserGateway(IUser user, string gateway)
	{
		Contract.ArgumentNotNull(user, "user");
		string key = $"User_{user.GetId()}";
		if (gateway.IsNullOrEmpty())
		{
			DataAccessManager.BLOBManager.RemoveBLOB<string>(UserStorageBindingGuid, key);
		}
		else
		{
			DataAccessManager.BLOBManager.SetBLOB(UserStorageBindingGuid, key, gateway);
		}
	}

	Uri IUploadUrlGenerator.GetClosestBaseUploadUrl()
	{
		return UploadUrlFactory.GetClosestUploadBaseUrl();
	}

	Uri IDownloadUrlService.GetDownloadUrl(BinaryFile binaryFile, string password)
	{
		if (password != null && !binaryFile.Encrypt)
		{
			password = null;
		}
		if (binaryFile.Encrypt && password == null)
		{
			throw new ArgumentException(SR.T("Не указан пароль для зашифрованного файла uid={0} location='{1}'.", binaryFile.Uid, binaryFile.ContentLocation));
		}
		SystemFile systemFile = base.SystemFileManager.LoadFile(binaryFile.Uid);
		if (systemFile != null)
		{
			return DownloadUrlFactory.GetPersistentContentDownloadUrl(systemFile, password);
		}
		return DownloadUrlFactory.GetTempContentDownloadUrl(binaryFile.ContentLocation, binaryFile.ContentType, binaryFile.Name.ReplaceInvalidFileNameChars());
	}

	void IInitHandler.Init()
	{
	}

	void IInitHandler.InitComplete()
	{
		if (base.Initialized)
		{
			FileOriginManager.CreateOriginsForLegacyMode(endpoints.DefaultEndpointName);
		}
	}
}

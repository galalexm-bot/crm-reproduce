using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models.Deploy;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.UserActions;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Deploy.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
internal class DeployImportController : BPMController
{
	private class SendToTestData
	{
		public long UserId { get; set; }

		public BinaryFile ConfigFile { get; set; }

		public string ActivationKey { get; set; }

		public List<Guid> TestUids { get; set; } = new List<Guid>();


		public Exception Exception { get; set; }
	}

	private class SendToImportData
	{
		public long UserId { get; set; }

		public Guid[] TestUids { get; set; }

		public Guid ImportUid { get; set; }
	}

	private const int MaxMessagesCount = 1000;

	private readonly IContinuedImportService continuedImportService;

	private readonly ISecurityServiceAsync securityService;

	private readonly UserManager userManager;

	private readonly IAuthenticationService authenticationService;

	private readonly IExportImportService exportImportService;

	private readonly ITreeRenderService treeRenderService;

	private readonly WebHostEnvironmentManager webHostEnvironmentManager;

	private readonly IAdditionalFilesService additionalFilesService;

	private readonly ICacheFilesService cacheFilesService;

	public DeployImportController(IContinuedImportService continuedImportService, ISecurityServiceAsync securityService, UserManager userManager, IAuthenticationService authenticationService, IExportImportService exportImportService, ITreeRenderService treeRenderService, WebHostEnvironmentManager webHostEnvironmentManager, IAdditionalFilesService additionalFilesService, ICacheFilesService cacheFilesService)
	{
		this.continuedImportService = continuedImportService;
		this.securityService = securityService;
		this.userManager = userManager;
		this.authenticationService = authenticationService;
		this.exportImportService = exportImportService;
		this.treeRenderService = treeRenderService;
		this.webHostEnvironmentManager = webHostEnvironmentManager;
		this.additionalFilesService = additionalFilesService;
		this.cacheFilesService = cacheFilesService;
	}

	[ContentItem(Name = "SR.M('Импорт')", Image24 = "#change.svg")]
	public async Task<ActionResult> Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpPost]
	public async Task<ActionResult> SendToUnpackAndTest(TestModel testModel, CancellationToken cancellationToken)
	{
		if (testModel?.ConfigFile != null)
		{
			List<Guid> testUids = new List<Guid>();
			SendToTestData data = new SendToTestData
			{
				UserId = (long)authenticationService.GetCurrentUser().GetId(),
				ConfigFile = testModel.ConfigFile,
				ActivationKey = testModel.ActivationKey
			};
			cancellationToken.ThrowIfCancellationRequested();
			await new BackgroundAsyncTask(() => securityService.RunByUserAsync(userManager.Load(data.UserId), async delegate
			{
				try
				{
					List<Guid> testUids2 = data.TestUids;
					testUids2.AddRange(await continuedImportService.Test(data.ConfigFile, data.ActivationKey, cancellationToken));
				}
				catch (Exception exception)
				{
					data.Exception = exception;
				}
			}), ((object)this).GetType(), SR.T("Отправка на тест"), SR.T("Отправка на тест"), useCallSessionOwner: true, handleExceptions: false).ExecuteAsync();
			if (data.Exception != null)
			{
				string error = SR.T("Не удалось загрузить файл конфигурации: {0}", data.Exception.Message);
				return (ActionResult)(object)((Controller)this).Json((object)new { error });
			}
			testUids.AddRange(data.TestUids);
			return (ActionResult)(object)((Controller)this).Json((object)new { testUids });
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			empty = true
		});
	}

	[HttpPost]
	public async Task<ActionResult> GetTestLog(Guid uid, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		List<TestImportMessages> messages = await continuedImportService.GetTestLog(uid, cancellationToken);
		List<string> testTrees = new List<string>();
		ImportLicenseInfo licenseInfo = null;
		bool finished;
		bool hasError;
		if (messages != null)
		{
			TestImportMessages testImportMessages = messages.FirstOrDefault((TestImportMessages message) => message.Type == TestImportMessagesType.Finish);
			finished = testImportMessages != null;
			hasError = messages.Any((TestImportMessages message) => message.Type == TestImportMessagesType.Error);
			TestImportMessages testImportMessages2 = messages.FirstOrDefault((TestImportMessages message) => message.Type == TestImportMessagesType.UserAction && message.UserActionType == LicenseImportTestUserAction.UID);
			if (testImportMessages2 != null)
			{
				licenseInfo = testImportMessages2.AditionalData as ImportLicenseInfo;
			}
			if (finished)
			{
				foreach (IImportSettings item in await continuedImportService.GetImportSettings(uid))
				{
					if (item is IConfigImportSettings configImportSettings && configImportSettings.FakeManifest != null)
					{
						TreeModel model = treeRenderService.BuildConfigurationTree(configImportSettings.FakeManifest);
						testTrees.Add(((HtmlString)(object)GetHtmlHelper().Tree(model)).ToHtmlString());
					}
				}
			}
		}
		else
		{
			hasError = true;
			finished = true;
			messages = new List<TestImportMessages>
			{
				new TestImportMessages(TestImportMessagesType.Error, SR.T("Не удалось проверить файл конфигурации"))
			};
		}
		bool currentImport = await exportImportService.GetCurrentImportId() != Guid.Empty;
		return (ActionResult)(object)((Controller)this).Json((object)new { messages, finished, hasError, testTrees, currentImport, licenseInfo });
	}

	[HttpPost]
	public async Task<ActionResult> SendToImport(Guid[] testUids, CancellationToken cancellationToken)
	{
		if (await exportImportService.GetCurrentImportId() == Guid.Empty)
		{
			try
			{
				SendToImportData data = new SendToImportData
				{
					UserId = (long)authenticationService.GetCurrentUser().GetId(),
					TestUids = testUids
				};
				cancellationToken.ThrowIfCancellationRequested();
				await new BackgroundAsyncTask(() => securityService.RunByUserAsync(userManager.Load(data.UserId), async delegate
				{
					SendToImportData sendToImportData = data;
					sendToImportData.ImportUid = await continuedImportService.Import(data.TestUids, cancellationToken);
				}), ((object)this).GetType(), SR.T("Отправка на импорт"), SR.T("Отправка на импорт"), useCallSessionOwner: true, handleExceptions: false).ExecuteAsync();
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = true,
					uid = data.ImportUid
				});
			}
			catch (Exception ex)
			{
				string text = SR.T("В данный момент выполняется другой импорт.");
				base.Logger.Error(text, ex);
				if (ex is InvalidOperationException && !string.IsNullOrEmpty(ex.Message))
				{
					text = ex.Message + " " + SR.T("Возможно параллельно был запущен еще один импорт.");
				}
				base.Notifier.Warning(text);
			}
		}
		else
		{
			base.Notifier.Warning(SR.T("В данный момент выполняется другой импорт"));
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false,
			uid = Guid.Empty
		});
	}

	public async Task<ActionResult> Import(Guid? uid, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		Guid guid = await exportImportService.GetCurrentImportId();
		if (!uid.HasValue || uid == Guid.Empty)
		{
			if (guid == Guid.Empty)
			{
				base.Notifier.Warning(SR.T("Импорт не найден. Вы можете начать новый импорт."));
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
			}
			base.Notifier.Information(SR.T("Вы были перемещены на текущий импорт"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Import", (object)new
			{
				uid = guid
			});
		}
		if (uid == guid)
		{
			return (ActionResult)(object)((Controller)this).View("Import", (object)uid);
		}
		if (guid == Guid.Empty)
		{
			base.Notifier.Warning(SR.T("Импорт не найден. Вы можете начать новый импорт."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		base.Notifier.Information(SR.T("Вы были перемещены на текущий импорт."));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Import", (object)new
		{
			uid = guid
		});
	}

	[HttpPost]
	public async Task<ActionResult> GetImportLog(Guid uid, int? messagesCount, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		if (uid == Guid.Empty)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				stop = true
			});
		}
		List<DeployLogMessage> messages = (await exportImportService.GetImportLog(uid, messagesCount ?? 0, 1000)).ToList();
		bool flag = messages == null;
		if (!flag)
		{
			bool flag2 = messages.Count == 0;
			if (flag2)
			{
				flag2 = uid != await exportImportService.GetCurrentImportId();
			}
			flag = flag2;
		}
		if (flag)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				stop = true
			});
		}
		if (messages.Count > 1000)
		{
			messages = messages.GetRange(messages.Count - 1000, 1000).ToList();
			messages.Insert(0, new DeployLogMessage(DeployLogMessageType.Info, SR.T("Лог был укорочен. Полный список доступен в логах сервера.")));
		}
		bool? endProcess = messages.LastOrDefault()?.EndProcess;
		bool? endStage = messages.LastOrDefault()?.EndStage;
		bool hasError = messages.Any((DeployLogMessage message) => message.MessageType == DeployLogMessageType.Error);
		bool? needRestart = messages.LastOrDefault()?.NeedRestart;
		return (ActionResult)(object)((Controller)this).Json((object)new { messages, endProcess, endStage, hasError, needRestart });
	}

	public async Task<ActionResult> GetInstructions(Guid[] testUids, CancellationToken cancellationToken)
	{
		HelpFileModel model = new HelpFileModel();
		if (testUids != null && testUids.Any())
		{
			cancellationToken.ThrowIfCancellationRequested();
			Guid mainTestUid = testUids[0];
			IConfigImportSettings mainSettings = null;
			List<IConfigImportSettings> settingsList = new List<IConfigImportSettings>();
			for (int i = 0; i < testUids.Length; i++)
			{
				Guid testUid = testUids[i];
				IConfigImportSettings configImportSettings = (await continuedImportService.GetImportSettings(testUid)).OfType<IConfigImportSettings>().FirstOrDefault((IConfigImportSettings s) => s.FileName == testUid.ToString());
				if (configImportSettings != null)
				{
					if (testUid == mainTestUid)
					{
						mainSettings = configImportSettings;
					}
					settingsList.Add(configImportSettings);
				}
			}
			ElmaStoreComponentManifest elmaStoreComponentManifest;
			if ((elmaStoreComponentManifest = mainSettings?.Manifest) != null && !string.IsNullOrEmpty(elmaStoreComponentManifest.HelpFileName))
			{
				string helpFilePath = additionalFilesService.GetHelpFilePath(mainSettings.FileName, elmaStoreComponentManifest.HelpFileName);
				if (System.IO.File.Exists(helpFilePath))
				{
					Guid uid = Guid.NewGuid();
					if (cacheFilesService.CreateCacheFileByUid(uid, elmaStoreComponentManifest.HelpFileName))
					{
						using FileStream inputStream = new FileStream(helpFilePath, FileMode.Open, FileAccess.Read);
						cacheFilesService.IncrementCacheFile(uid, inputStream, 0L);
					}
					model.HelpFile = cacheFilesService.GetBinaryFile(uid);
				}
			}
			foreach (ElmaStoreComponentManifest item in settingsList.Select((IConfigImportSettings settings) => settings.Manifest).OfType<ElmaStoreComponentManifest>())
			{
				if (Directory.Exists(additionalFilesService.GetStoreAdditionalFilesPath(item)))
				{
					model.AdditionalFiles.Add(additionalFilesService.GetStoreAdditionalFilesPathMessage(item));
				}
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("DeployImport/HelpFiles", (object)model);
	}

	[HttpPost]
	public async Task<ActionResult> GetImportTree(Guid uid, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		string importTree = string.Empty;
		foreach (BPMAppFakeManifest item in ((await continuedImportService.GetImportManifests(uid, cancellationToken)) ?? Enumerable.Empty<BPMAppFakeManifest>()).ToList())
		{
			TreeModel treeModel = null;
			if (item != null)
			{
				treeModel = treeRenderService.BuildConfigurationTree(item, expanded: true);
			}
			if (treeModel != null)
			{
				importTree += ((HtmlString)(object)GetHtmlHelper().Tree(treeModel)).ToHtmlString();
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { importTree });
	}

	[HttpGet]
	public async Task<ActionResult> SendToReboot(Guid uid, CancellationToken cancellationToken)
	{
		bool needRestart = false;
		if (await exportImportService.GetCurrentImportId() == uid)
		{
			needRestart = await exportImportService.ImportNeedRestart(uid);
		}
		if (needRestart)
		{
			webHostEnvironmentManager.RestartHost();
		}
		return (ActionResult)new EmptyResult();
	}

	public async Task<ActionResult> LicensePopup(CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[HttpGet]
	public Task<ActionResult> ImportFile(Guid fileUid, CancellationToken cancellationToken)
	{
		TestModel testModel = new TestModel
		{
			ConfigFile = base.CacheFilesService.GetBinaryFile(fileUid)
		};
		return Task.FromResult<ActionResult>((ActionResult)(object)((Controller)this).View("Index", (object)testModel));
	}
}

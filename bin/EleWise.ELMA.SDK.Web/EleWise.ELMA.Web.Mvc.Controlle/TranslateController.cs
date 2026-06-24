using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Globalization.DTO;
using EleWise.ELMA.Globalization.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Translate;
using EleWise.ELMA.Web.Mvc.Security;
using Orchard.Themes;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[Themed]
[InLineTranslateDisable(Order = 0)]
[Permission("691B08C2-088E-4E4A-BE73-40F68D4761EA")]
public class TranslateController : BaseController
{
	public ILocalizationLoader LocalizationLoader { get; set; }

	public IZipService ZipService { get; set; }

	public IMimeMappingService MimeMappingService { get; set; }

	public IEnumerable<IExportLocalizationFileExtensionPoint> LocalizationFileSettings { get; set; }

	[HttpGet]
	public ActionResult SetTranslationMode(bool enable)
	{
		long userId = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		TranslateService.Instance.EnabledTranslationMode(userId, enable);
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization();
		if (enable && string.IsNullOrEmpty(translateLocalization))
		{
			base.Notifier.Information("Target local not set");
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpPost]
	public ActionResult SetTargetLocalization(string current, string target)
	{
		long userId = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		if (!string.IsNullOrEmpty(current))
		{
			Locator.GetService<ILocalizationService>().Save(new CultureInfo(current));
		}
		if (!string.IsNullOrEmpty(target))
		{
			TranslateService.Instance.SetTranslateLocalization(userId, target);
		}
		return SuccessJson();
	}

	public ActionResult EnterTranslation(string key, string current, string target, string formatcurrent, string formattarget)
	{
		TranslateEditModel translateEditModel = new TranslateEditModel
		{
			TrueKey = key,
			CurrentValue = current,
			TargetValue = target,
			CurrentFormatValue = formatcurrent,
			TargetFormatValue = formattarget,
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		long value = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		string locId = (translateEditModel.TargetLocal = TranslateService.Instance.GetTranslateLocalization(value));
		translateEditModel.Block = TranslateService.Instance.HasMergingOperation(locId);
		return (ActionResult)(object)((Controller)this).PartialView("Translate/EditForm", (object)translateEditModel);
	}

	[HttpPost]
	public ActionResult SaveTranslation(TranslateEditModel model)
	{
		TranslateService.Instance.SetTranslate(model.TargetLocal, model.TrueKey, (!string.IsNullOrEmpty(model.TargetFormatValue)) ? model.TargetFormatValue : model.TargetValue);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult PublishForm()
	{
		long value = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization(value);
		PublishLocalModel publishLocalModel = new PublishLocalModel
		{
			PublishedLocal = translateLocalization
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/PublishLocal", (object)publishLocalModel);
	}

	[HttpPost]
	public ActionResult PublishTranslate(PublishLocalModel model)
	{
		try
		{
			TranslateService.Instance.PublishTranslate(model.PublishedLocal);
			base.Notifier.Information($"Language \"{model.PublishedLocal}\" has been published");
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			FormNotifierExtensions.Error(base.Notifier, ex);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult GetCultures(string text, bool? filterByExists = true)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		List<CultureInfo> existingCultures = TranslateService.Instance.GetTargets();
		existingCultures.Add(SR.KeyCultureInfo);
		List<CultureInfo> list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).ToList();
		if (filterByExists.HasValue && filterByExists.Value)
		{
			list = list.Where((CultureInfo c) => existingCultures.All((CultureInfo cc) => !cc.Name.Equals(c.Name, StringComparison.OrdinalIgnoreCase))).ToList();
		}
		List<CultureInfo> source = list;
		if (!string.IsNullOrEmpty(text))
		{
			string upperText = text.ToUpper();
			source = list.Where((CultureInfo u) => u.EnglishName.ToUpper().Contains(upperText) || u.Name.ToUpper().Contains(upperText) || u.NativeName.ToUpper().Contains(upperText)).ToList();
		}
		SelectList data = new SelectList((IEnumerable)(from u in source
			select new
			{
				id = u.Name,
				text = u.EnglishName
			} into t
			orderby t.text
			select t).ToList(), "id", "text");
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return (ActionResult)val;
	}

	public ActionResult CreateLocal()
	{
		long value = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization(value);
		CreateLocalModel createLocalModel = new CreateLocalModel
		{
			TargetLocal = translateLocalization,
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/CreateLocal", (object)createLocalModel);
	}

	[HttpPost]
	public ActionResult Create(CreateLocalModel model)
	{
		if (string.IsNullOrEmpty(model.LocalId))
		{
			base.Notifier.Error("Language name is not defined");
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		long userId = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		TranslateService.Instance.CreateLocal(model.LocalId, model.BaseLanguage);
		if (model.SetToTarget)
		{
			TranslateService.Instance.SetTranslateLocalization(userId, model.LocalId);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult DownloadForm()
	{
		long value = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization(value);
		DownloadLocalModel downloadLocalModel = new DownloadLocalModel
		{
			TargetLocal = translateLocalization,
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/DownloadLocal", (object)downloadLocalModel);
	}

	public ActionResult UploadForm()
	{
		UploadLocalModel uploadLocalModel = new UploadLocalModel();
		return (ActionResult)(object)((Controller)this).PartialView("Translate/UploadLocal", (object)uploadLocalModel);
	}

	[HttpPost]
	public ActionResult StartUpload(UploadLocalModel model)
	{
		try
		{
			TranslateService.Instance.DoUpload(model.Local, model.ZipFile);
			base.Notifier.Information($"Language \"{model.Local}\" has been uploaded");
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			FormNotifierExtensions.Error(base.Notifier, ex);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult Download(Guid operationId)
	{
		string fileName;
		FileStream fileStream = TranslateService.Instance.DownloadLocal(operationId, out fileName);
		return (ActionResult)(object)File(fileStream, "application/zip", fileName);
	}

	[HttpPost]
	public ActionResult StartDownload(DownloadLocalModel model)
	{
		if (string.IsNullOrEmpty(model.DownloadedLocalId))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = "Language name is not defined"
			});
		}
		Guid guid = TranslateService.Instance.PrepareDownload(model.DownloadedLocalId);
		PrepareOperationDescription prepareOperationDescription = TranslateService.Instance.GetPrepareOperationDescription(guid);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			operation = guid,
			status = (int)prepareOperationDescription.Status,
			message = prepareOperationDescription.CurrentMessage
		});
	}

	public ActionResult GetDownloadOperationStatus(Guid operationId)
	{
		PrepareOperationDescription prepareOperationDescription = TranslateService.Instance.GetPrepareOperationDescription(operationId);
		if (prepareOperationDescription == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = $"Download operation {operationId} is no found"
			}, (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			status = (int)prepareOperationDescription.Status,
			message = prepareOperationDescription.CurrentMessage
		}, (JsonRequestBehavior)0);
	}

	public ActionResult PoEditor()
	{
		TranslateService.Instance.CheckInit();
		if (!TranslateService.Instance.Initialized)
		{
			throw new Exception("Translation service is not initialized");
		}
		PoEditorModel poEditorModel = new PoEditorModel
		{
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		if (!string.IsNullOrEmpty(poEditorModel.CurrentLocal))
		{
			poEditorModel.Current = TranslateService.Instance.GetTranslation(poEditorModel.CurrentLocal);
			if (poEditorModel.Current != null)
			{
				poEditorModel.Current.RefreshStatistic();
			}
		}
		long value = Convert.ToInt64(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
		string text = TranslateService.Instance.GetTranslateLocalization(value);
		if (text == null)
		{
			text = (TranslateService.Instance.GetTargets().FirstOrDefault() ?? SR.KeyCultureInfo).Name;
		}
		poEditorModel.TargetLocal = text;
		if (!string.IsNullOrEmpty(poEditorModel.TargetLocal))
		{
			poEditorModel.Target = TranslateService.Instance.GetTranslation(poEditorModel.TargetLocal);
			poEditorModel.Block = TranslateService.Instance.HasMergingOperation(poEditorModel.TargetLocal);
			poEditorModel.NeedMerge = TranslateService.Instance.IsNeedMerge(poEditorModel.TargetLocal);
			if (poEditorModel.Target != null)
			{
				poEditorModel.Target.RefreshStatistic();
			}
		}
		poEditorModel.Init();
		return (ActionResult)(object)((Controller)this).View("Translate/PoEditor", (object)poEditorModel);
	}

	[HttpPost]
	public ActionResult Merge(string local)
	{
		TranslateService.Instance.Merge(local);
		return (ActionResult)(object)((Controller)this).RedirectToAction("PoEditor");
	}

	public ActionResult IsMergeCompleted(string local)
	{
		bool flag = TranslateService.Instance.HasMergingOperation(local);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			completed = !flag
		}, (JsonRequestBehavior)0);
	}

	public ActionResult SaveTranslateRow(string local, string key, string value)
	{
		if (TranslateService.Instance.HasMergingOperation(local))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = "Save translate is blocked because merge operation is not completed"
			});
		}
		TranslateService.Instance.SetTranslate(local, key, value);
		return SuccessJson();
	}

	public ActionResult SetFuzzy(string local, string key, bool value)
	{
		if (TranslateService.Instance.HasMergingOperation(local))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = "Set fuzzy is blocked because merge operation is not completed"
			});
		}
		TranslateService.Instance.SetFuzzy(local, key, value);
		return SuccessJson();
	}

	public ActionResult SetPriority(string local, string key, bool value)
	{
		if (TranslateService.Instance.HasMergingOperation(local))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = "Set priority is blocked because merge operation is not completed"
			});
		}
		TranslateService.Instance.SetPriority(local, key, value);
		return SuccessJson();
	}

	public ActionResult FileStatistic(string target, [Bind(Prefix = "LineFilter")] PoLineFilter filter)
	{
		if (filter == null)
		{
			throw new Exception(SR.T("Не заданы параметры фильтрации"));
		}
		LocalizationHolder translation = TranslateService.Instance.GetTranslation(target);
		translation.RefreshStatistic();
		if (filter.FileName == "None")
		{
			filter.FileName = null;
		}
		PoLineFilter poLineFilter = new PoLineFilter
		{
			SearchString = filter.SearchString,
			FileName = filter.FileName
		};
		LocalizationFileStatisticModel localizationFileStatisticModel = new LocalizationFileStatisticModel
		{
			FileName = poLineFilter.FileName,
			Filter = poLineFilter
		};
		localizationFileStatisticModel.RecalcByFilter(translation);
		return (ActionResult)(object)((Controller)this).PartialView("Translate/LocalizationFileStatistic", (object)localizationFileStatisticModel);
	}

	public ActionResult Statistic()
	{
		long value = Convert.ToInt64(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
		string translateLocalization = TranslateService.Instance.GetTranslateLocalization(value);
		LocalizationHolder translation = TranslateService.Instance.GetTranslation(translateLocalization);
		if (translation == null)
		{
			throw new Exception("Target language not selected");
		}
		translation.RefreshStatistic();
		return (ActionResult)(object)((Controller)this).PartialView("Translate/Statistic", (object)translation.Statistic);
	}

	[CustomGridAction]
	public ActionResult PoGrid(GridCommand command, [Bind(Prefix = "LineFilter")] PoLineFilter filter, string source, string target)
	{
		GridData<PoRowModel, PoLineFilter> gridData = new GridData<PoRowModel, PoLineFilter>
		{
			Command = command,
			DataFilter = filter
		};
		if (filter.FileName == "None")
		{
			filter.FileName = null;
		}
		LocalizationHolder sourceHolder = TranslateService.Instance.GetTranslation(source);
		LocalizationHolder targetHolder = TranslateService.Instance.GetTranslation(target);
		gridData.SetCount((GridData<PoRowModel, PoLineFilter> d, FetchOptions f) => LocalizationHolder.Count(d.DataFilter, targetHolder, sourceHolder));
		gridData.SetDataSource(delegate(GridData<PoRowModel, PoLineFilter> d, FetchOptions f)
		{
			List<PoRowModel> list = new List<PoRowModel>();
			foreach (PoLineDescriptor item2 in LocalizationHolder.Find(f, d.DataFilter, targetHolder, sourceHolder))
			{
				PoLineDescriptor poLineDescriptor = item2;
				PoLineDescriptor currentLine = sourceHolder.Find(poLineDescriptor.Key) ?? new PoLineDescriptor
				{
					Key = poLineDescriptor.Key,
					IsFuzzy = item2.IsFuzzy,
					IsLow = item2.IsLow,
					Comments = item2.Comments
				};
				PoRowModel item = new PoRowModel
				{
					CurrentLine = currentLine,
					CurrentLocal = source,
					FileName = filter.FileName,
					Key = item2.Key,
					TargetLocal = target,
					TargetLine = item2
				};
				list.Add(item);
			}
			return list;
		});
		PoRowsModel poRowsModel = new PoRowsModel
		{
			Data = gridData
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/PoGrid", (object)poRowsModel);
	}

	public ActionResult DownloadTemplate(string local, string template)
	{
		if ((TranslateService.Instance.GetTranslation(local) ?? throw new Exception($"Local \"{local}\" not found")).Templates.FirstOrDefault((TemplateDescription t) => t.Name.Equals(template, StringComparison.OrdinalIgnoreCase)) == null)
		{
			throw new Exception($"Template \"{template}\" not found in local \"{local}\"");
		}
		string translationTemplateDir = TranslateService.Instance.GetTranslationTemplateDir(local);
		if (!Directory.Exists(translationTemplateDir))
		{
			throw new Exception($"Template directory \"{translationTemplateDir}\" not found in local \"{local}\"");
		}
		string text = Path.Combine(translationTemplateDir, template);
		if (!System.IO.File.Exists(text))
		{
			throw new Exception($"Template \"{text}\" not found in local \"{local}\"");
		}
		string typeByExtension = Locator.GetServiceNotNull<IMimeMappingService>().GetTypeByExtension(Path.GetExtension(template));
		string fileDownloadName = BinaryFilesController.SetFileNameHeaders(template, ((Controller)this).get_Request(), ((Controller)this).get_Response());
		return (ActionResult)(object)File(text, typeByExtension ?? "application/octet-stream", fileDownloadName);
	}

	public ActionResult TemplateEditor(string target)
	{
		LocalizationHolder translation = TranslateService.Instance.GetTranslation(target);
		if (translation == null)
		{
			throw new Exception($"Local \"{target}\" not found");
		}
		TemplateEditorModel templateEditorModel = new TemplateEditorModel
		{
			Holder = translation
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/TemplateEditor", (object)templateEditorModel);
	}

	public ActionResult EditTamplate(string local, string template)
	{
		TemplateUploaderModel templateUploaderModel = new TemplateUploaderModel
		{
			Local = local,
			TemplateName = template
		};
		return (ActionResult)(object)((Controller)this).PartialView("Translate/TemplateUploader", (object)templateUploaderModel);
	}

	[HttpPost]
	public ActionResult SaveTemplate(TemplateUploaderModel model)
	{
		if (model.TemplateFile != null)
		{
			if ((TranslateService.Instance.GetTranslation(model.Local) ?? throw new Exception($"Local \"{model.Local}\" not found")).Templates.FirstOrDefault((TemplateDescription t) => t.Name.Equals(model.TemplateName, StringComparison.OrdinalIgnoreCase)) == null)
			{
				throw new Exception($"Template \"{model.TemplateName}\" not found in local \"{model.Local}\"");
			}
			string translationTemplateDir = TranslateService.Instance.GetTranslationTemplateDir(model.Local);
			if (!Directory.Exists(translationTemplateDir))
			{
				throw new Exception($"Template directory \"{translationTemplateDir}\" not found in local \"{model.Local}\"");
			}
			model.TemplateFile.SaveToLocalPath(Path.Combine(translationTemplateDir, model.TemplateName));
		}
		return SuccessJson();
	}

	public ActionResult GetSimilarResources(string[] keys, string[] values, string current, string target, string textAreaId, bool? containsMode = false)
	{
		LocalizationHolder translation = TranslateService.Instance.GetTranslation(current);
		SimilarResourcesModel similarResourcesModel = new SimilarResourcesModel
		{
			Local = TranslateService.Instance.GetTranslation(target),
			TextAreaId = textAreaId
		};
		List<PoLineDescriptor> list;
		if (keys.Length == 1)
		{
			list = (from r in similarResourcesModel.Local.FindByWords(new FetchOptions(0, 7), keys[0], 0.51, containsMode.HasValue && containsMode.Value)
				where !string.IsNullOrEmpty(r.Value) && r.Key != keys[0]
				select r).ToList();
			similarResourcesModel.Words = LocalizationHolder.SplitByWords(keys[0]);
			if (values != null && values[0] != null)
			{
				similarResourcesModel.ExtendedWords = LocalizationHolder.SplitByWords(values[0]);
			}
		}
		else
		{
			List<List<string>> words = new List<List<string>>
			{
				new List<string>(keys)
			};
			list = (from r in similarResourcesModel.Local.FindByWords(new FetchOptions(0, 10), words, containsMode.HasValue && containsMode.Value)
				where !string.IsNullOrEmpty(r.Value)
				select r).ToList();
			similarResourcesModel.Words = keys;
		}
		similarResourcesModel.Resources = new List<Pair<PoLineDescriptor, PoLineDescriptor>>();
		foreach (PoLineDescriptor item in list)
		{
			PoLineDescriptor poLineDescriptor = translation.Find(item.Key);
			if (poLineDescriptor == null)
			{
				poLineDescriptor = new PoLineDescriptor
				{
					Key = item.Key,
					Comments = new List<string>(item.Comments)
				};
			}
			similarResourcesModel.Resources.Add(new Pair<PoLineDescriptor, PoLineDescriptor>(poLineDescriptor, item));
		}
		return (ActionResult)(object)((Controller)this).PartialView("Translate/SimilarResources", (object)similarResourcesModel);
	}

	public ActionResult ExportTranslationConfiguration()
	{
		new JsonSerializer();
		ExportTranslationConfigurationModel exportTranslationConfigurationModel = new ExportTranslationConfigurationModel
		{
			WizardStepExtensions = LocalizationFileSettings,
			SettingsJsonData = LocalizationFileSettings.SelectMany((IExportLocalizationFileExtensionPoint s) => s.Tabs.Keys).ToDictionary((string k) => k, (string v) => string.Empty)
		};
		return (ActionResult)(object)((Controller)this).View((object)exportTranslationConfigurationModel);
	}

	[HttpPost]
	public ActionResult ExportTranslation(ExportTranslationConfigurationModel model)
	{
		LocalizationLoadSettings localizationLoadSettings = new LocalizationLoadSettings();
		foreach (IExportLocalizationFileExtensionPoint localizationFileSetting in LocalizationFileSettings)
		{
			localizationLoadSettings.CustomSettings[localizationFileSetting.Uid] = localizationFileSetting.GetSettingObj(model.SettingsJsonData);
		}
		byte[] bytes = LocalizationLoader.Execute(localizationLoadSettings);
		string tempFileName = IOExtensions.GetTempFileName("zip");
		System.IO.File.WriteAllBytes(tempFileName, bytes);
		string typeByExtension = MimeMappingService.GetTypeByExtension(Path.GetExtension(tempFileName));
		string fileDownloadName = BinaryFilesController.SetFileNameHeaders(model.ExportFileName + ".zip", ((Controller)this).get_Request(), ((Controller)this).get_Response());
		return (ActionResult)(object)File(tempFileName, typeByExtension ?? "application/octet-stream", fileDownloadName);
	}
}

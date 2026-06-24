using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class ScoringSettingsController : BPMController
{
	private readonly GlobalScoringSettingsModule globalScoringSettings;

	private readonly IEnumerable<IScoringSettings> scoringSettingsComponents;

	private readonly IEnumerable<IScoringStepSettings> scoringStepSettingsComponents;

	private readonly IEnumerable<IDuplicateHandler> duplicateHandlers;

	public ScoringSettingsController(GlobalScoringSettingsModule globalScoringSettings, IEnumerable<IScoringSettings> scoringSettings, IEnumerable<IScoringStepSettings> scoringStepSettings, IEnumerable<IDuplicateHandler> duplicateHandlers)
	{
		Contract.ArgumentNotNull(globalScoringSettings, "globalScoringSettings");
		Contract.ArgumentNotNull(scoringSettings, "scoringSettings");
		Contract.ArgumentNotNull(scoringStepSettings, "scoringStepSettings");
		Contract.ArgumentNotNull(duplicateHandlers, "duplicateHandlers");
		this.globalScoringSettings = globalScoringSettings;
		scoringSettingsComponents = scoringSettings;
		scoringStepSettingsComponents = scoringStepSettings;
		this.duplicateHandlers = duplicateHandlers;
	}

	public ActionResult AddScoringProperty(Guid entityGuid)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		IScoringSettings scoringSettings = scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(entityGuid));
		if (scoringSettings != null)
		{
			List<IScoringSettings> list = scoringSettings.GetScoringSettings().ToList();
			IEnumerable<ClassMetadata> possibleDuplicatesMetadata = scoringSettings.GetPossibleDuplicatesMetadata();
			ScoringPropertyModel scoringPropertyModel = new ScoringPropertyModel
			{
				IsNew = true,
				Id = ((list.Count > 0) ? (list.Max((IScoringSettings m) => m.Id) + 1) : 1),
				TypeUid = scoringSettings.TypeUid,
				DuplicateEntityList = possibleDuplicatesMetadata.Select((Func<ClassMetadata, SelectListItem>)delegate(ClassMetadata s)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0033: Expected O, but got Unknown
					SelectListItem val = new SelectListItem();
					val.set_Value(s.Uid.ToString());
					val.set_Text(s.DisplayName);
					val.set_Selected(false);
					return val;
				}).ToList()
			};
			return (ActionResult)(object)((Controller)this).View("EditScoringSettings", (object)scoringPropertyModel);
		}
		base.Notifier.Error(SR.T("Произошла ошибка во время добавления настройки."));
		return (ActionResult)new EmptyResult();
	}

	public ActionResult AddScoringStep(Guid entityGuid)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		IScoringStepSettings scoringStepSettings = scoringStepSettingsComponents.FirstOrDefault((IScoringStepSettings x) => x.Check(entityGuid));
		if (scoringStepSettings != null)
		{
			List<IScoringStepSettings> list = scoringStepSettings.GetScoringStepSettings().ToList();
			ScoringStepPropertyModel scoringStepPropertyModel = new ScoringStepPropertyModel
			{
				TypeUid = entityGuid,
				IsNew = true,
				Id = ((list.Count > 0) ? (list.Max((IScoringStepSettings m) => m.Id) + 1) : 1)
			};
			return (ActionResult)(object)((Controller)this).View("EditScoringStep", (object)scoringStepPropertyModel);
		}
		base.Notifier.Error(SR.T("Произошла ошибка во время добавления шага."));
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult DeleteScoringSetting(Guid entityGuid, long id)
	{
		try
		{
			scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(entityGuid)).Delete(id);
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления настройки."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления настройки."), exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityScoring", (object)new { entityGuid });
	}

	[HttpPost]
	public ActionResult DeleteScoringStep(Guid entityGuid, long id)
	{
		try
		{
			scoringStepSettingsComponents.FirstOrDefault((IScoringStepSettings x) => x.Check(entityGuid)).Delete(id);
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления настройки."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления настройки."), exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityScoring", (object)new { entityGuid });
	}

	public ActionResult EditScoringProperty(Guid entityGuid, long settingId)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		IScoringSettings scoringSettings = scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(entityGuid));
		if (scoringSettings != null)
		{
			IScoringSettings scoringSettings2 = scoringSettings.LoadScoringSetting(settingId);
			IEnumerable<ClassMetadata> possibleDuplicatesMetadata = scoringSettings.GetPossibleDuplicatesMetadata();
			ScoringPropertyModel scoringPropertyModel = new ScoringPropertyModel
			{
				IsNew = false,
				Id = scoringSettings2.Id,
				TypeUid = scoringSettings2.TypeUid,
				Property = scoringSettings2.Property,
				DuplicateTypeUid = scoringSettings2.DuplicateTypeUid,
				SearchDuplicateInAnotherEntity = (scoringSettings2.TypeUid != scoringSettings2.DuplicateTypeUid),
				DuplicateProperty = scoringSettings2.DuplicateProperty,
				PercentValue = scoringSettings2.PercentValue,
				DuplicateEntityList = possibleDuplicatesMetadata.Select((Func<ClassMetadata, SelectListItem>)delegate(ClassMetadata s)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0033: Expected O, but got Unknown
					SelectListItem val = new SelectListItem();
					val.set_Value(s.Uid.ToString());
					val.set_Text(s.DisplayName);
					val.set_Selected(false);
					return val;
				}).ToList()
			};
			return (ActionResult)(object)((Controller)this).View("EditScoringSettings", (object)scoringPropertyModel);
		}
		base.Notifier.Error(SR.T("Произошла ошибка во время редактирования настройки."));
		return (ActionResult)new EmptyResult();
	}

	public ActionResult EditScoringStep(Guid entityGuid, long settingId)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		IScoringStepSettings scoringStepSettings = scoringStepSettingsComponents.FirstOrDefault((IScoringStepSettings x) => x.Check(entityGuid));
		if (scoringStepSettings != null)
		{
			IScoringStepSettings scoringStepSettings2 = scoringStepSettings.LoadScoringStepSetting(settingId);
			IColor color = InterfaceActivator.Create<IColor>();
			color.ColorCode = scoringStepSettings2.ColorCode;
			ScoringStepPropertyModel scoringStepPropertyModel = new ScoringStepPropertyModel
			{
				IsNew = false,
				Id = scoringStepSettings2.Id,
				PercentValue = scoringStepSettings2.PercentValue,
				Color = color,
				TypeUid = entityGuid
			};
			return (ActionResult)(object)((Controller)this).View("EditScoringStep", (object)scoringStepPropertyModel);
		}
		base.Notifier.Error(SR.T("Произошла ошибка во время редактирования шага."));
		return (ActionResult)new EmptyResult();
	}

	public ActionResult EntityScoring(Guid entityGuid)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityGuid);
		ScoringEntityModel scoringEntityModel = new ScoringEntityModel
		{
			DisplayName = classMetadata.DisplayName,
			EntityType = entityGuid
		};
		return (ActionResult)(object)((Controller)this).View((object)scoringEntityModel);
	}

	[HttpPost]
	public ActionResult FetchDuplicateEntities(Guid scoringEntity)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		IScoringSettings scoringSettings = scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(scoringEntity));
		if (scoringSettings != null)
		{
			IEnumerable<ClassMetadata> possibleDuplicatesMetadata = scoringSettings.GetPossibleDuplicatesMetadata();
			JsonResult val = new JsonResult();
			val.set_Data((object)new SelectList((IEnumerable)possibleDuplicatesMetadata.Select((ClassMetadata u) => new
			{
				id = u.Uid.ToString(),
				text = u.DisplayName
			}).ToList(), "id", "text"));
			return (ActionResult)val;
		}
		base.Notifier.Error(SR.T("Не удалось получить список возможных сущностей-дубликатов."));
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult GetDuplicateEntityProperties(Guid selectedDuplicateEntity, Guid selectedScoringProperty, Guid entityTypeUid)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		EntityMetadata obj = MetadataLoader.LoadMetadata(entityTypeUid) as EntityMetadata;
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(selectedDuplicateEntity) as EntityMetadata;
		PropertyMetadata propertyMetadata = obj.Properties.Where((PropertyMetadata m) => m.Uid == selectedScoringProperty).FirstOrDefault();
		if (propertyMetadata != null)
		{
			Guid propertyTypeUid = ((propertyMetadata.SubTypeUid != Guid.Empty) ? propertyMetadata.SubTypeUid : propertyMetadata.TypeUid);
			IEnumerable<EntityPropertyMetadata> source = from m in entityMetadata.Properties.OfType<EntityPropertyMetadata>()
				where m.TypeUid == propertyTypeUid || m.SubTypeUid == propertyTypeUid
				select m;
			JsonResult val = new JsonResult();
			val.set_Data((object)new SelectList((IEnumerable)source.Select((EntityPropertyMetadata s) => new
			{
				id = s.Uid.ToString(),
				text = s.DisplayName
			}).ToList(), "id", "text"));
			return (ActionResult)val;
		}
		base.Notifier.Error(SR.T("Не удалось получить список свойств сущности."));
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult GetScoringProperties(Guid scoringEntity)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005d: Expected O, but got Unknown
		IEnumerable<EntityPropertyMetadata> source = (MetadataLoader.LoadMetadata(scoringEntity) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>();
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)source.Select((EntityPropertyMetadata s) => new
		{
			id = s.Uid.ToString(),
			text = s.DisplayName
		}).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, Guid entityGuid)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityGuid);
		IScoringSettings scoringSettings = scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(entityGuid));
		if (scoringSettings != null)
		{
			IEnumerable<IScoringSettings> scoringSettings2 = scoringSettings.GetScoringSettings();
			GridData<IScoringSettings> gridData = new GridData<IScoringSettings>
			{
				Command = command
			};
			IEnumerable<IScoringSettings> list = ((command != null) ? command.ApplySorting(scoringSettings2) : scoringSettings2);
			gridData.SetCount((GridData<IScoringSettings> d, FetchOptions f) => list.Count());
			gridData.SetDataSource((GridData<IScoringSettings> d, FetchOptions f) => list);
			gridData.IsPageable = false;
			ScoringSettingsModel scoringSettingsModel = new ScoringSettingsModel
			{
				DisplayName = classMetadata.DisplayName,
				EntityType = entityGuid,
				SettingsList = gridData
			};
			return (ActionResult)(object)((Controller)this).PartialView((object)scoringSettingsModel);
		}
		base.Notifier.Error(SR.T("Не удалось получить компонент для скоринга сущности."));
		return (ActionResult)new EmptyResult();
	}

	public ActionResult Index()
	{
		IEnumerable<IDuplicateHandler> enumerable = duplicateHandlers.Where((IDuplicateHandler x) => x.EntityType().HasValue);
		List<ScoringEntityModel> list = new List<ScoringEntityModel>();
		foreach (IDuplicateHandler item in enumerable)
		{
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(item.EntityType().Value);
			list.Add(new ScoringEntityModel
			{
				DisplayName = classMetadata.DisplayName,
				EntityType = classMetadata.Uid
			});
		}
		ScoringPageModel scoringPageModel = new ScoringPageModel
		{
			IsGlobalScoringEnabled = globalScoringSettings.Settings.IsGlobalScoringEnabled,
			Entities = list
		};
		return (ActionResult)(object)((Controller)this).View((object)scoringPageModel);
	}

	[HttpPost]
	public ActionResult Save(ScoringPropertyModel model)
	{
		try
		{
			IScoringSettings scoringSettings = scoringSettingsComponents.FirstOrDefault((IScoringSettings x) => x.Check(model.TypeUid));
			scoringSettings.Id = model.Id;
			scoringSettings.TypeUid = model.TypeUid;
			scoringSettings.Property = model.Property;
			scoringSettings.PercentValue = model.PercentValue;
			if (model.SearchDuplicateInAnotherEntity)
			{
				scoringSettings.DuplicateTypeUid = model.DuplicateTypeUid;
				scoringSettings.DuplicateProperty = model.DuplicateProperty;
			}
			else
			{
				scoringSettings.DuplicateTypeUid = model.TypeUid;
				scoringSettings.DuplicateProperty = model.Property;
			}
			scoringSettings.Save();
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			base.Logger.Error("Error while saving ScoringSettings", exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityScoring", (object)new
		{
			entityGuid = model.TypeUid
		});
	}

	[HttpPost]
	public ActionResult SaveStep(ScoringStepPropertyModel model)
	{
		try
		{
			IScoringStepSettings scoringStepSettings = scoringStepSettingsComponents.FirstOrDefault((IScoringStepSettings x) => x.Check(model.TypeUid));
			scoringStepSettings.ColorCode = model.Color.ColorCode;
			scoringStepSettings.PercentValue = model.PercentValue;
			scoringStepSettings.Id = model.Id;
			scoringStepSettings.Save();
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			base.Logger.Error("Error while saving ScoringStep", exception);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("EntityScoring", (object)new
		{
			entityGuid = model.TypeUid
		});
	}

	[CustomGridAction]
	public ActionResult StepGrid(GridCommand command, Guid entityGuid)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityGuid);
		IScoringStepSettings scoringStepSettings = scoringStepSettingsComponents.FirstOrDefault((IScoringStepSettings x) => x.Check(entityGuid));
		if (scoringStepSettings != null)
		{
			IEnumerable<IScoringStepSettings> scoringStepSettings2 = scoringStepSettings.GetScoringStepSettings();
			GridData<IScoringStepSettings> gridData = new GridData<IScoringStepSettings>
			{
				Command = command
			};
			IEnumerable<IScoringStepSettings> list = ((command != null) ? command.ApplySorting(scoringStepSettings2) : scoringStepSettings2);
			gridData.SetCount((GridData<IScoringStepSettings> d, FetchOptions f) => list.Count());
			gridData.SetDataSource((GridData<IScoringStepSettings> d, FetchOptions f) => list);
			gridData.IsPageable = false;
			ScoringStepSettingsModel scoringStepSettingsModel = new ScoringStepSettingsModel
			{
				DisplayName = classMetadata.DisplayName,
				EntityType = entityGuid,
				SettingsList = gridData
			};
			return (ActionResult)(object)((Controller)this).PartialView((object)scoringStepSettingsModel);
		}
		base.Notifier.Error(SR.T("Не удалось получить компонент для скоринга сущности."));
		return (ActionResult)new EmptyResult();
	}

	public ActionResult ToggleGlobalScoring()
	{
		globalScoringSettings.Settings.IsGlobalScoringEnabled = !globalScoringSettings.Settings.IsGlobalScoringEnabled;
		globalScoringSettings.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}
}

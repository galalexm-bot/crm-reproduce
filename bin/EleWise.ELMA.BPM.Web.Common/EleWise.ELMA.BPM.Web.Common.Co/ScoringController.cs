using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class ScoringController : BPMController
{
	private readonly GlobalScoringSettingsModule scoringSettings;

	private readonly IEnumerable<IScoringStepSettings> scoringStepSettings;

	private readonly IDuplicateService duplicateService;

	public ScoringController(IDuplicateService duplicateService, IEnumerable<IScoringStepSettings> scoringStepSettings, GlobalScoringSettingsModule scoringSettings)
	{
		Contract.ArgumentNotNull(scoringSettings, "scoringSettings");
		Contract.ArgumentNotNull(duplicateService, "duplicateService");
		Contract.ArgumentNotNull(scoringStepSettings, "scoringStepSettings");
		this.scoringSettings = scoringSettings;
		this.duplicateService = duplicateService;
		this.scoringStepSettings = scoringStepSettings;
	}

	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult ScoringPanel(Guid typeGuid, long id)
	{
		ScoringDisplayModel scoringDisplayModel = new ScoringDisplayModel
		{
			TypeGuid = typeGuid,
			Id = id
		};
		if (scoringSettings.Settings.IsGlobalScoringEnabled)
		{
			scoringDisplayModel.IsGlobalScoringEnabled = true;
			IDuplicateStateFilter duplicateStateFilter = InterfaceActivator.Create<IDuplicateStateFilter>();
			ReferenceOnEntity reference = (duplicateStateFilter.EntityReference = ReferenceOnEntity.Create(typeGuid, id));
			IDuplicateState duplicateState = EntityManager<IDuplicateState>.Instance.Find(duplicateStateFilter, new FetchOptions(0, 1)).FirstOrDefault();
			ICollection<IDuplicate> possibleDuplicates = duplicateService.GetPossibleDuplicates(reference);
			if (duplicateState != null)
			{
				scoringDisplayModel.Status = duplicateState.DuplicateStatus;
				scoringDisplayModel.DateOfScoring = duplicateState.DateOfScoring;
				if (duplicateState.DuplicateStatus == DuplicateStatus.Duplicate)
				{
					IDuplicate duplicate = possibleDuplicates.FirstOrDefault();
					scoringDisplayModel.OriginalReference = duplicate.EntityDuplicateReference;
					scoringDisplayModel.OriginalName = duplicate.EntityDuplicateReference.Object.ToString();
				}
			}
			IDuplicate maximumMatch = possibleDuplicates.OrderBy((IDuplicate m) => m.Weight).LastOrDefault();
			if (maximumMatch != null && scoringDisplayModel.Status != DuplicateStatus.Duplicate)
			{
				IScoringStepSettings scoringStepSettings = (from m in this.scoringStepSettings.FirstOrDefault((IScoringStepSettings x) => x.Check(typeGuid)).GetScoringStepSettings()
					orderby m.PercentValue
					select m).LastOrDefault((IScoringStepSettings x) => x.PercentValue <= maximumMatch.Weight);
				if (scoringStepSettings != null)
				{
					scoringDisplayModel.ColorCode = scoringStepSettings.ColorCode;
				}
			}
			else
			{
				scoringDisplayModel.ColorCode = "lightgray";
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("DisplayTemplates/ScoringPanel", (object)scoringDisplayModel);
	}

	[CustomGridAction]
	public ActionResult DuplicateGrid(GridCommand command, Guid typeGuid, long id)
	{
		ReferenceOnEntity reference = ReferenceOnEntity.Create(typeGuid, id);
		ICollection<IDuplicate> possibleDuplicates = duplicateService.GetPossibleDuplicates(reference);
		GridData<IDuplicate> gridData = new GridData<IDuplicate>
		{
			DataSource = possibleDuplicates,
			PageSize = 10
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult NotDuplicate(Guid typeGuid, long id)
	{
		try
		{
			ReferenceOnEntity referenceOnEntity = ReferenceOnEntity.Create(typeGuid, id);
			foreach (IDuplicate possibleDuplicate in duplicateService.GetPossibleDuplicates(referenceOnEntity))
			{
				possibleDuplicate.Delete();
			}
			IDuplicateStateFilter duplicateStateFilter = InterfaceActivator.Create<IDuplicateStateFilter>();
			duplicateStateFilter.EntityReference = referenceOnEntity;
			IDuplicateState duplicateState = EntityManager<IDuplicateState>.Instance.Find(duplicateStateFilter, new FetchOptions(0, 1)).FirstOrDefault();
			if (duplicateState != null)
			{
				duplicateState.DuplicateStatus = DuplicateStatus.NotDuplicate;
				duplicateState.Save();
			}
		}
		catch
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, "text/html");
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, "text/html");
	}

	public ActionResult CheckForDublicates(Guid typeGuid, long id)
	{
		try
		{
			ReferenceOnEntity referenceOnEntity = ReferenceOnEntity.Create(typeGuid, id);
			foreach (IDuplicate possibleDuplicate in duplicateService.GetPossibleDuplicates(referenceOnEntity))
			{
				possibleDuplicate.Delete();
			}
			IDuplicateStateFilter duplicateStateFilter = InterfaceActivator.Create<IDuplicateStateFilter>();
			duplicateStateFilter.EntityReference = referenceOnEntity;
			EntityManager<IDuplicateState>.Instance.Find(duplicateStateFilter, new FetchOptions(0, 1)).FirstOrDefault()?.Delete();
			IEntity entity = ModelHelper.GetEntityManager(typeGuid).Load(id) as IEntity;
			IDuplicateHandler duplicateHandler = ComponentManager.Current.GetExtensionPoints<IDuplicateHandler>().FirstOrDefault((IDuplicateHandler q) => q.IsScoringEnabled(typeGuid));
			if (duplicateHandler != null)
			{
				duplicateService.FillDuplicates(entity, duplicateHandler);
			}
		}
		catch
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, "text/html");
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, "text/html");
	}

	public ActionResult MarkAsDuplicate(ReferenceOnEntity duplicate, ReferenceOnEntity original)
	{
		try
		{
			foreach (IDuplicate possibleDuplicate in duplicateService.GetPossibleDuplicates(duplicate))
			{
				if (possibleDuplicate.EntityDuplicateReference.ObjectId != original.ObjectId || possibleDuplicate.EntityDuplicateReference.ObjectTypeUId != original.ObjectTypeUId)
				{
					possibleDuplicate.Delete();
				}
			}
			IDuplicateStateFilter duplicateStateFilter = InterfaceActivator.Create<IDuplicateStateFilter>();
			duplicateStateFilter.EntityReference = duplicate;
			IDuplicateState duplicateState = EntityManager<IDuplicateState>.Instance.Find(duplicateStateFilter, new FetchOptions(0, 1)).FirstOrDefault();
			if (duplicateState != null)
			{
				duplicateState.DuplicateStatus = DuplicateStatus.Duplicate;
				duplicateState.OriginalEntityReference = original;
				duplicateState.Save();
			}
		}
		catch
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, "text/html");
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, "text/html");
	}
}

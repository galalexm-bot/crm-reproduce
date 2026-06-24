using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntitiesForComboboxSelectionModel
{
	public string Text { get; set; }

	public Guid Uid { get; set; }

	public string Id { get; set; }

	public bool ShowOnlyGroups { get; set; }

	public int Limit { get; set; }

	public string FilterProviderUid { get; set; }

	public string FilterProviderData { get; set; }

	public string SortExpression { get; set; }

	public bool Localize { get; set; }

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IEnumerable<IEntityFilterProvider> EntityFilterProviders { get; set; }

	public Func<IEntity, string> EntityNameFunc { get; set; }

	public Func<IEntity, string> DropDownTextFunc { get; set; }

	public IEntityManager EntityManager { get; set; }

	public Filter EntityFilter { get; set; }

	public EntityUrlResolverService EntityUrlResolverService { get; set; }

	public Controller Controller { get; set; }
}

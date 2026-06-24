using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityTypeSelectorInfo
{
	private List<EntityMetadata> _typeList;

	private bool _inited;

	public EntityMetadata Metadata { get; set; }

	public List<IFormCreator> ObjectCreators { get; set; }

	public string PopupId { get; set; }

	public string InputId { get; set; }

	public string ContainerId { get; set; }

	public string UniquePrefix { get; set; }

	public string ParentHtmlPrefix { get; set; }

	public ObjectCreatorParamsContainer CreatorParamsContainer { get; set; }

	public Type EntityType { get; set; }

	public string OpenEntityCreator { get; set; }

	public string CreateEntityCallback { get; set; }

	public string PropertyCollectionOnCallback { get; set; }

	public string ViewFormUid { get; set; }

	public string UniqueId { get; set; }

	public EntityTypeSelectorInfo()
	{
		UniquePrefix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
	}

	public List<EntityMetadata> GetTypesList()
	{
		if (_typeList == null)
		{
			_typeList = new List<EntityMetadata> { Metadata };
			IEnumerable<EntityMetadata> collection = MetadataLoader.GetChildClasses(Metadata).OfType<EntityMetadata>();
			_typeList.AddRange(collection);
			_typeList = (from t in _typeList.Where(delegate(EntityMetadata t)
				{
					Type entityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(t.Uid);
					return !ComponentManager.Current.GetExtensionPoints<INotCreatable>().Any((INotCreatable p) => p.CheckType(entityType));
				})
				where GetCreator(t.Uid) != null
				select t).ToList();
		}
		return _typeList;
	}

	public IFormCreator GetCreator(Guid typeUid)
	{
		Init();
		Type entityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid);
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (!serviceNotNull.CanCheckPermission(CommonPermissions.Create, entityType) || serviceNotNull.HasPermission(CommonPermissions.Create, entityType))
		{
			EntityType = entityType;
			List<IFormCreator> list = ObjectCreators.Where((IFormCreator o) => o.CheckType(entityType) && !o.IsBase).ToList();
			return ((list.Count > 0) ? list : ObjectCreators).FirstOrDefault((IFormCreator o) => o.CheckType(entityType));
		}
		return null;
	}

	public string GetPopupId()
	{
		return $"Popup{UniquePrefix}";
	}

	public string GetUrlForType(HtmlHelper html, Guid typeUid)
	{
		Init();
		GetCreator(typeUid);
		return html.Url().Action("CreatorForm", "Entity", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			creatorUid = Guid.Empty,
			inputId = InputId,
			containerId = ContainerId,
			typeUid = typeUid,
			previosPopupId = PopupId,
			popupId = GetPopupId(),
			createEntityCallback = CreateEntityCallback,
			propertyCollectionOnCallback = PropertyCollectionOnCallback,
			viewFormUid = ViewFormUid,
			uniqueId = UniqueId
		});
	}

	public void Init()
	{
		if (_inited)
		{
			return;
		}
		ObjectCreators = new List<IFormCreator>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(Metadata);
		childClasses.Add(Metadata);
		List<IFormCreator> creators = new List<IFormCreator>();
		childClasses.ForEach(delegate(ClassMetadata ch)
		{
			Type entityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ch.Uid);
			(from p in ComponentManager.Current.GetExtensionPoints<IFormCreator>()
				where p.CheckType(entityType) && p.Action(entityType) != null
				select p).ToList().ForEach(delegate(IFormCreator c)
			{
				creators.Add(c);
			});
		});
		ObjectCreators = creators;
		_inited = true;
	}
}

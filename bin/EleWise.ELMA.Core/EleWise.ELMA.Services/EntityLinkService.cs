using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class EntityLinkService : IEntityLinkService
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Entity entity;

		internal bool _003CGetLink_003Eb__0(IObjectLink a)
		{
			return a.Check(entity);
		}
	}

	private readonly System.Collections.Generic.IEnumerable<IObjectLink> objectLinks;

	private readonly IRedirectService redirectService;

	private readonly Dictionary<Guid, string> linksByTypeUid;

	private readonly Dictionary<Guid, Action<object>> actionsByTypeUid;

	public EntityLinkService(System.Collections.Generic.IEnumerable<IObjectLink> objectLinks, IRedirectService redirectService)
	{
		this.objectLinks = objectLinks;
		linksByTypeUid = new Dictionary<Guid, string>();
		actionsByTypeUid = new Dictionary<Guid, Action<object>>();
		this.redirectService = redirectService;
	}

	public EntityLinkResult GetLink(Entity entity)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.entity = entity;
		if (CS_0024_003C_003E8__locals0.entity == null)
		{
			return null;
		}
		EntityLinkResult linkFromCache = GetLinkFromCache(CS_0024_003C_003E8__locals0.entity);
		if (linkFromCache != null)
		{
			return linkFromCache;
		}
		Guid typeUid = GetTypeUid(CS_0024_003C_003E8__locals0.entity);
		Action<object> val = null;
		IObjectLink objectLink = Enumerable.FirstOrDefault<IObjectLink>(objectLinks, (Func<IObjectLink, bool>)((IObjectLink a) => a.Check(CS_0024_003C_003E8__locals0.entity)));
		string text;
		if (objectLink != null)
		{
			text = objectLink.Url(CS_0024_003C_003E8__locals0.entity);
			val = objectLink.Action(CS_0024_003C_003E8__locals0.entity);
		}
		else
		{
			text = string.Format("/Common/Entity/Link?id={0}&typeUid={1}", (object)"-9999999999999", (object)typeUid);
		}
		linksByTypeUid.set_Item(typeUid, text);
		if (val != null)
		{
			actionsByTypeUid.set_Item(typeUid, val);
		}
		return PrepareResult(text, val, CS_0024_003C_003E8__locals0.entity.Id.get_Value());
	}

	public bool HasLink(EntityLinkResult entityLink)
	{
		if (entityLink == null)
		{
			return false;
		}
		if (entityLink.Action == null)
		{
			return !string.IsNullOrWhiteSpace(entityLink.Url);
		}
		return true;
	}

	public void OpenEntityLink(EntityLinkResult entityLink, Entity entity)
	{
		if (entityLink != null)
		{
			if (entityLink.Action != null)
			{
				entityLink.Action.Invoke((object)entity);
			}
			else
			{
				redirectService.OpenInNewTab(entityLink.Url);
			}
		}
	}

	private EntityLinkResult GetLinkFromCache(Entity entity)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (entity == null)
		{
			return null;
		}
		Guid typeUid = GetTypeUid(entity);
		return GetLinkFromCache(typeUid, entity.Id.get_Value());
	}

	private static Guid GetTypeUid(Entity entity)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		ReactiveProxy reactiveProxy = entity.As<ReactiveProxy>();
		Guid result = default(Guid);
		if (reactiveProxy != null && reactiveProxy.Json != null && Guid.TryParse(reactiveProxy.Json.GetPlainPropertyValue<string>("TypeUid"), ref result))
		{
			return result;
		}
		return entity.TypeUid;
	}

	private EntityLinkResult GetLinkFromCache(Guid typeUid, long id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		string link = default(string);
		if (linksByTypeUid.TryGetValue(typeUid, ref link))
		{
			Action<object> action = default(Action<object>);
			actionsByTypeUid.TryGetValue(typeUid, ref action);
			return PrepareResult(link, action, id);
		}
		return null;
	}

	private static EntityLinkResult PrepareResult(string link, Action<object> action, long id)
	{
		EntityLinkResult obj = new EntityLinkResult
		{
			Action = action
		};
		if (!string.IsNullOrWhiteSpace(link))
		{
			link = link.Replace("-9999999999999", ((object)id).ToString());
		}
		obj.Url = link;
		return obj;
	}
}

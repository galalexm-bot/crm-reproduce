using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.BPM.Common.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;

namespace EleWise.ELMA.Messages.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class BaseMessageManager : EntityManager<IBaseMessage, long>
{
	public const string SettingsMessagesPath = "SettingsMessages";

	private const string FeedMessagesSettingsPath = "FeedMessagesSettings";

	public new static BaseMessageManager Instance => Locator.GetServiceNotNull<BaseMessageManager>();

	public ITransformationProvider TransformationProvider { get; set; }

	public ICacheService CacheService { get; set; }

	protected override string DefaultCriteriaAlias => "bm";

	protected virtual Type GetEntityTypeByFilter(IBaseMessageFilter messageFilter)
	{
		Type result = null;
		if (messageFilter != null)
		{
			if (messageFilter.ChannelMessages || messageFilter.Sended)
			{
				result = InterfaceActivator.TypeOf<IChannelMessage>();
			}
			if (messageFilter.Discussions)
			{
				result = InterfaceActivator.TypeOf<IDiscussion>();
			}
		}
		return result;
	}

	protected override ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		if (filter != null && filter is IBaseMessageFilter messageFilter)
		{
			Type entityTypeByFilter = GetEntityTypeByFilter(messageFilter);
			if (entityTypeByFilter != null)
			{
				return base.CreateCriteria(fetchOptions, entityTypeByFilter, alias, filter);
			}
		}
		return base.CreateCriteria(fetchOptions, type, alias, filter);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is IBaseMessageFilter baseMessageFilter))
		{
			return;
		}
		EleWise.ELMA.Security.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.IUser>();
		if (baseMessageFilter.Sended)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)currentUser)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("MessageType"), (ICriterion)(object)Restrictions.Eq("MessageType", (object)ChannelMessageType.Post)));
		}
		if (baseMessageFilter.ChannelMessages || baseMessageFilter.Discussions)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MessageType", (object)ChannelMessageType.Post));
		}
		if (baseMessageFilter.ChannelId.HasValue)
		{
			criteria.CreateAlias("Channels", "chs", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("chs.Id", (object)baseMessageFilter.ChannelId.Value));
		}
		if (baseMessageFilter.RecipientId.HasValue)
		{
			if (baseMessageFilter.Notifications)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("RecipientId", (object)baseMessageFilter.RecipientId.Value));
			}
			else
			{
				criteria.CreateAlias("Recipients", "rec", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("rec.Id", (object)baseMessageFilter.RecipientId.Value));
			}
		}
		if (baseMessageFilter.Ids != null && baseMessageFilter.Ids.Count != 0)
		{
			if (baseMessageFilter.Ids.Count == 1)
			{
				criteria.Add((ICriterion)(object)Restrictions.IdEq((object)baseMessageFilter.Ids[0]));
			}
			else if (baseMessageFilter.Ids.Count > 1000)
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				string text = string.Format("{{alias}}.{0} in (select cast(val as {2}) as Id from {1})", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.TableFunction("SplitString", "?, ?"), serviceNotNull.Dialect.GetTypeName(DbType.Int64));
				object[] obj = new object[2]
				{
					string.Join("_", baseMessageFilter.Ids),
					"_"
				};
				IType[] array = (IType[])(object)new StringType[2]
				{
					(StringType)NHibernateUtil.StringClob,
					NHibernateUtil.String
				};
				criteria.Add((ICriterion)(object)Expression.Sql(text, obj, array));
			}
			else
			{
				criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)baseMessageFilter.Ids.Select(Convert.ToInt64).ToList()));
			}
		}
		if (baseMessageFilter.Authors != null && ((ICollection<EleWise.ELMA.Security.Models.IUser>)baseMessageFilter.Authors).Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("CreationAuthor", (ICollection)((IEnumerable<EleWise.ELMA.Security.Models.IUser>)baseMessageFilter.Authors).Select((EleWise.ELMA.Security.Models.IUser m) => m.Id).ToList()));
		}
	}

	protected override Type GetTypeForFastSearch(IEntityFilter filter)
	{
		return GetEntityTypeByFilter(filter as IBaseMessageFilter) ?? base.ImplementationType;
	}

	protected override List<EntityPropertyMetadata> GetPropertiesForFastSearch(EntityMetadata metadata, IEntityFilter filter)
	{
		List<EntityPropertyMetadata> propertiesForFastSearch = base.GetPropertiesForFastSearch(metadata, filter);
		Type type = GetEntityTypeByFilter(filter as IBaseMessageFilter) ?? base.ImplementationType;
		if (type != null && type == InterfaceActivator.TypeOf<IChannelMessage>())
		{
			EntityPropertyMetadata entityPropertyMetadata = (EntityPropertyMetadata)metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "FullMessage");
			if (entityPropertyMetadata != null)
			{
				propertiesForFastSearch.Add(entityPropertyMetadata);
			}
		}
		return propertiesForFastSearch;
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IBaseMessage>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "CreationAuthor",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "CreationDate",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "FullMessage",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Permissions",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Recipients",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Statuses",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Subject",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Uid",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}

	public FeedMessagesSettings LoadSettings()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		FeedMessagesSettings feedMessagesSettings = PersonalizationAdministration.LoadState<FeedMessagesSettings>(currentUser.UserName, "FeedMessagesSettings") ?? new FeedMessagesSettings();
		FastCommentSettingsModel fastCommentSettingsModel = GetFastCommentSettingsModel(currentUser.UserName);
		if (fastCommentSettingsModel != null)
		{
			feedMessagesSettings.PostCommentEnterKey = fastCommentSettingsModel.PostCommentEnterKey;
		}
		return feedMessagesSettings;
	}

	public void SaveSettings(FeedMessagesSettings settings)
	{
		if (settings != null)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			PersonalizationAdministration.SaveState(currentUser.UserName, "FeedMessagesSettings", settings);
			FastCommentSettingsModel fastCommentSettingsModel = GetFastCommentSettingsModel(currentUser.UserName);
			if (fastCommentSettingsModel == null)
			{
				fastCommentSettingsModel = new FastCommentSettingsModel();
			}
			fastCommentSettingsModel.PostCommentEnterKey = settings.PostCommentEnterKey;
			PersonalizationAdministration.SaveState(currentUser.UserName, "FastCommentSettingsModel", fastCommentSettingsModel);
		}
	}

	private FastCommentSettingsModel GetFastCommentSettingsModel(string userName)
	{
		return PersonalizationAdministration.LoadState<FastCommentSettingsModel>(userName, "FastCommentSettingsModel");
	}
}

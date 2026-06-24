using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Messages.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class InformationChannelManager : EntityManager<IInformationChannel, long>
{
	[NotNull]
	public new static InformationChannelManager Instance => Locator.GetServiceNotNull<InformationChannelManager>();

	protected override string DefaultCriteriaAlias => "ch";

	[ActionMethod("42986da3-d210-414d-9225-f3cde17c18c9")]
	[Transaction]
	[PublicApiMember]
	public override void Save(IInformationChannel channel)
	{
		base.Save(channel);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IInformationChannelFilter informationChannelFilter)
		{
			if (informationChannelFilter.Assigned)
			{
				IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
				DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IInformationChannelSubscriber>()).Add((ICriterion)(object)Restrictions.Eq("User", (object)currentUser)).Add((ICriterion)(object)Restrictions.EqProperty("Channel", "ch.Id"))
					.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")));
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("IsSubscriptionManagementDenied", (object)true), (ICriterion)(object)Subqueries.Exists(val)));
			}
			if (informationChannelFilter.NotGroupUid.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("GroupUid", (object)informationChannelFilter.NotGroupUid)));
			}
			if (informationChannelFilter.WithoutIds != null && informationChannelFilter.WithoutIds.Any())
			{
				criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In("Id", (ICollection)informationChannelFilter.WithoutIds)));
			}
			if (informationChannelFilter.Ids != null && informationChannelFilter.Ids.Any())
			{
				criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)informationChannelFilter.Ids));
			}
		}
	}

	public List<IInformationChannel> GetChannelsForSending()
	{
		IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
		informationChannelFilter.IsActive = true;
		informationChannelFilter.IsArchive = false;
		informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		return Find(informationChannelFilter, FetchOptions.All).ToList();
	}

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	public void RefreshPermissionsCache(IInformationChannel channel)
	{
		if (channel != null && channel.Id != 0L)
		{
			RefreshPermissionsCacheType();
			channel.Refresh();
		}
	}

	internal void RefreshPermissionsCacheType()
	{
		base.Session.CleanUpCache(typeof(IInformationChannel));
	}
}

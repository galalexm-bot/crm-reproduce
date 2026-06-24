using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Messages.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MessageExceptionManager : EntityManager<IMessageException, long>
{
	private class MessageExceptionCacheDataItem
	{
		public Guid ObjectUid { get; set; }

		public Guid ActionUid { get; set; }

		public Guid ChannelUid { get; set; }
	}

	private const string MessageExceptionAuthorKeyPrefix = "MessageExceptionAuthor_";

	internal const string MessageExceptionAuthorTimestampKeyPrefix = "MessageExceptionAuthorTimestamp_";

	public new static MessageExceptionManager Instance => Locator.GetServiceNotNull<MessageExceptionManager>();

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public bool HasException(IUser user, Guid objectUid, Guid actionUid, Guid? channelUid)
	{
		IEnumerable<Guid> objectUids = EnumerateParentClassesUids(objectUid);
		return ComplexCacheService.GetOrAdd("MessageExceptionAuthor_" + user.GetId(), "MessageExceptionAuthorTimestamp_" + user.GetId(), () => CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Author", (object)user)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("ObjectUid"), "ObjectUid").Add((IProjection)(object)Projections.Property("ActionUid"), "ActionUid")
			.Add((IProjection)(object)Projections.Property("ChannelUid"), "ChannelUid") }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(MessageExceptionCacheDataItem)))
			.List<MessageExceptionCacheDataItem>()).Any((MessageExceptionCacheDataItem d) => (d.ObjectUid == objectUid || objectUids.Contains(d.ObjectUid)) && d.ActionUid == actionUid && (!channelUid.HasValue || d.ChannelUid == channelUid.Value));
	}

	public IEnumerable<IMessageException> GetUserExceptions()
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Author", (object)currentUser)).List<IMessageException>();
	}

	[Transaction]
	public virtual void DeleteException(IAuditObject obj, IAuditAction action)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Author", (object)currentUser)).Add((ICriterion)(object)Restrictions.Eq("ObjectUid", (object)obj.Uid)).Add((ICriterion)(object)Restrictions.Eq("ActionUid", (object)action.Uid))
			.List<IMessageException>()
			.ToList()
			.ForEach(delegate(IMessageException a)
			{
				a.Delete();
			});
	}

	[Transaction]
	public virtual void DeleteMyException()
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Author", (object)currentUser)).List<IMessageException>().ToList()
			.ForEach(delegate(IMessageException a)
			{
				a.Delete();
			});
	}

	private IEnumerable<Guid> EnumerateParentClassesUids(Guid objectUid)
	{
		return from m in MetadataLoader.GetBaseClasses((ClassMetadata)MetadataLoader.LoadMetadata(objectUid))
			select m.Uid;
	}
}

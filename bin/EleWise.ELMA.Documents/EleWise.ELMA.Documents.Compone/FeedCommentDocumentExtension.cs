using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component(Order = 1200)]
internal class FeedCommentDocumentExtension : BaseFeedPostExtension
{
	private void CheckForDocument(Dictionary<long, bool> items)
	{
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (Locator.GetServiceNotNull<SecurityService>().HasPermission(currentUser, PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
		{
			string text = string.Join(", ", items.Keys);
			string sql = string.Format("SELECT DISTINCT dob.{0} as {1} FROM {2}  WHERE dob.{3} <> 1 and dob.{0} in ({4})", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("DmsObjectId"), serviceNotNull.NoLockTableExpression("DmsObject", "dob"), serviceNotNull.Dialect.QuoteIfNeeded("IsDeleted"), text);
			using IDataReader dataReader = serviceNotNull.ExecuteQuery(sql);
			while (dataReader.Read())
			{
				if (!(dataReader["DmsObjectId"] is DBNull))
				{
					long key = Convert.ToInt64(dataReader["DmsObjectId"]);
					if (items.ContainsKey(key))
					{
						items[key] = true;
					}
				}
			}
			return;
		}
		string text2 = string.Join(",", items.Keys);
		object id = currentUser.GetId();
		string sql2 = string.Format("SELECT DISTINCT dop.{0} as {1} FROM {2} inner join {3} on dop.{4} = c.{5} inner join {6} ON dob.{7} = dop.{0} WHERE c.{8} = {11} and dop.{9} = {13}PermissionId and dob.{10} <> 1 and dop.{0} in ({12})", serviceNotNull.Dialect.QuoteIfNeeded("DmsObject"), serviceNotNull.Dialect.QuoteIfNeeded("DmsObjectId"), serviceNotNull.NoLockTableExpression("DmsObjectPermission", "dop"), serviceNotNull.NoLockTableExpression("UserSecuritySetCache", "c"), serviceNotNull.Dialect.QuoteIfNeeded("UserSecuritySetCacheId"), serviceNotNull.Dialect.QuoteIfNeeded("SetId"), serviceNotNull.NoLockTableExpression("DmsObject", "dob"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("UserId"), serviceNotNull.Dialect.QuoteIfNeeded("PermissionId"), serviceNotNull.Dialect.QuoteIfNeeded("IsDeleted"), id, text2, serviceNotNull.ParameterSeparator);
		using IDataReader dataReader2 = serviceNotNull.ExecuteQuery(sql2, new Dictionary<string, object> { 
		{
			"PermissionId",
			PermissionProvider.DocumentViewPermission.Id
		} });
		while (dataReader2.Read())
		{
			if (!(dataReader2["DmsObjectId"] is DBNull))
			{
				long key2 = Convert.ToInt64(dataReader2["DmsObjectId"]);
				if (items.ContainsKey(key2))
				{
					items[key2] = true;
				}
			}
		}
	}

	public override Guid GetCommentActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<IDocument>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return DocumentActions.AddCommentGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> CommentSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<IDocument>() };
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && CommentIsSupported(objectUid))
		{
			CheckForDocument(items);
		}
	}

	public override string GetQuestionSubject(IEntity target)
	{
		if (!(target is IDocument document))
		{
			return base.GetQuestionSubject(target);
		}
		return document.Name;
	}

	public override Guid GetQuestionActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<IDocument>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return DocumentActions.AddQuestionGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> QuestionSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<IDocument>() };
	}

	public override void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && QuestionIsSupported(objectUid))
		{
			CheckForDocument(items);
		}
	}
}

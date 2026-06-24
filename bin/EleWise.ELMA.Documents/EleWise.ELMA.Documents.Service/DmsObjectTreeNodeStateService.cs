using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using NHibernate.Util;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal sealed class DmsObjectTreeNodeStateService : IDmsObjectTreeNodeStateService
{
	private readonly ITransformationProvider transformationProvider;

	public DmsObjectTreeNodeStateService(ITransformationProvider transformationProvider)
	{
		this.transformationProvider = transformationProvider;
	}

	public void InsertStateIfNotExists(long? rootId, string treeId, IUser user, bool timestamp)
	{
		Contract.ArgumentNotNullOrEmpty(treeId, "treeId");
		Contract.ArgumentNotNull(user, "user");
		string text = TreeIdToHashString(treeId);
		int num = 1;
		transformationProvider.Insert("Sys_DmsObjectTreeNodeState", new string[6] { "TreeId", "User", "DmsObject", "Expanded", "ParentExpanded", "Timestamp" }, string.Format("t.{0}, t.{1}, t.{2}, t.{3}, t.{4}, {5}tstamp", transformationProvider.Dialect.QuoteIfNeeded("TreeId"), transformationProvider.Dialect.QuoteIfNeeded("User"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject"), transformationProvider.Dialect.QuoteIfNeeded("Expanded"), transformationProvider.Dialect.QuoteIfNeeded("ParentExpanded"), transformationProvider.ParameterSeparator), string.Format(" (select {10} {1}, \r\n                                         {11} {2}, \r\n                                         r.{9} {4}, \r\n                                         {12} {5}, \r\n                                         {12} {6} \r\n                                  from {8} r\r\n                                  where r.{3} = {13}) t\r\n                    where not exists (select s.{4} from {7} s \r\n                                      where s.{1} = {10} and s.{2} = {11})\r\n                    ", transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("TreeId"), transformationProvider.Dialect.QuoteIfNeeded("User"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject"), transformationProvider.Dialect.QuoteIfNeeded("Expanded"), transformationProvider.Dialect.QuoteIfNeeded("ParentExpanded"), transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectTreeNodeState"), transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteString(text), user.Id, num, rootId ?? 0), isNeedInsertId: false, new Dictionary<string, object> { 
		{
			"tstamp",
			timestamp ? ((object)DateTime.UtcNow) : null
		} });
	}

	public void SaveNodeState(string treeId, IUser user, long nodeId, bool expanded)
	{
		Contract.ArgumentNotNullOrEmpty(treeId, "treeId");
		Contract.ArgumentNotNull(user, "user");
		string text = TreeIdToHashString(treeId);
		int num = (expanded ? 1 : 0);
		List<string> list = new List<string> { "Expanded" };
		List<object> list2 = new List<object> { num };
		if (expanded)
		{
			list.Add("ParentExpanded");
			list2.Add(num);
		}
		if (transformationProvider.Update("Sys_DmsObjectTreeNodeState", list.ToArray(), list2.ToArray(), string.Format("{0}={1}treeId and {2}={1}userId and {3}={1}dmsObj", transformationProvider.Dialect.QuoteIfNeeded("TreeId"), transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("User"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject")), new Dictionary<string, object>
		{
			{ "treeId", text },
			{ "userId", user.Id },
			{ "dmsObj", nodeId }
		}) > 0)
		{
			transformationProvider.Update("Sys_DmsObjectTreeNodeState", new string[1] { "ParentExpanded" }, new object[1] { num }, string.Format("{0}={1}treeId and {2}={1}userId and exists (select * from {3} r where r.{4} = {1}dmsObj and r.{5} = {6}) and {7}={1}expanded", transformationProvider.Dialect.QuoteIfNeeded("TreeId"), transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("User"), transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject"), transformationProvider.Dialect.QuoteIfNeeded("Expanded")), new Dictionary<string, object>
			{
				{ "treeId", text },
				{ "userId", user.Id },
				{ "dmsObj", nodeId },
				{ "expanded", 1 }
			});
		}
		else
		{
			transformationProvider.Insert("Sys_DmsObjectTreeNodeState", new string[5] { "TreeId", "User", "DmsObject", "Expanded", "ParentExpanded" }, new object[5] { text, user.Id, nodeId, num, num });
		}
	}

	public void SetNodeParentExpanded(long dmsObjectId, bool expanded)
	{
		SetNodeParentExpanded(new List<long> { dmsObjectId }, expanded);
	}

	public void SetNodeParentExpanded(IEnumerable<long> dmsObjectsIds, bool expanded)
	{
		Contract.ArgumentNotNull(dmsObjectsIds, "dmsObjectsIds");
		if (EnumerableExtensions.Any((IEnumerable)dmsObjectsIds))
		{
			transformationProvider.Update("Sys_DmsObjectTreeNodeState", new string[1] { "ParentExpanded" }, new object[1] { expanded ? 1 : 0 }, string.Format(" exists (select r.{2} from {0} r where r.{1} and r.{2} = {3})", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), ElmaInExpression.ToString(transformationProvider.Dialect.QuoteIfNeeded("Parent"), dmsObjectsIds), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject")));
		}
	}

	public int DeleteNodesBefore(DateTime utcDateTime)
	{
		return transformationProvider.BulkDelete("Sys_DmsObjectTreeNodeState", string.Format("{0} in (select {0} from {1} where {2}<{3}tstamp)", transformationProvider.Dialect.QuoteIfNeeded("TreeId"), transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectTreeNodeState"), transformationProvider.Dialect.QuoteIfNeeded("Timestamp"), transformationProvider.ParameterSeparator), new Dictionary<string, object> { { "tstamp", utcDateTime } });
	}

	public string TreeIdToHashString(string treeId)
	{
		return treeId.GetDeterministicGuid().ToString().Replace("-", "")
			.ToLower();
	}
}

using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal sealed class DmsObjectRelationService : IDmsObjectRelationService
{
	private readonly ITransformationProvider transformationProvider;

	public DmsObjectRelationService(ITransformationProvider transformationProvider)
	{
		this.transformationProvider = transformationProvider;
	}

	public void Insert(IEnumerable<IDmsObject> dmsObjs)
	{
		Contract.ArgumentNotNull(dmsObjs, "dmsObjs");
		dmsObjs.ForEach(Insert);
	}

	public void Insert(IDmsObject dms)
	{
		Contract.ArgumentNotNull(dms, "dms");
		long owner = GetOwner(dms);
		transformationProvider.Insert("Sys_DmsObjectRelation", new string[4] { "Parent", "Child", "Depth", "Owner" }, new object[4] { dms.Id, dms.Id, 0, owner });
		string sql = string.Format("insert into {0} ({1}, {2}, {5}, {4})\r\nselect t.{1}, {3}dmsId, t.{5} + 1, {3}ownerId\r\nfrom {6}\r\nwhere t.{2} = {3}dmsFolderId", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("Owner"), transformationProvider.Dialect.QuoteIfNeeded("Depth"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "t"));
		transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>
		{
			{ "dmsId", dms.Id },
			{
				"dmsFolderId",
				(dms.Folder != null) ? dms.Folder.Id : 0
			},
			{ "ownerId", owner }
		});
	}

	public void Move(IDmsObject dmsObj, IFolder to, IFolder from = null)
	{
		Move(new IDmsObject[1] { dmsObj }, to, from);
	}

	public void Move(IEnumerable<IDmsObject> dmsObjs, IFolder to, IFolder from = null)
	{
		Contract.ArgumentNotNull(dmsObjs, "dmsObjs");
		dmsObjs = dmsObjs.Where((IDmsObject d) => d != null).ToList();
		List<long> list = dmsObjs.Select((IDmsObject d) => d.Id).Distinct().ToList();
		if (list.Count != 0)
		{
			List<long> list2 = ((from != null) ? new List<long> { from.Id } : (from d in dmsObjs
				where d.Folder != null
				select d.Folder.Id).ToList());
			if ((to != null && (list2.Count == 0 || list2.Any((long id) => id != to.Id))) || (to == null && list2.Count > 0))
			{
				transformationProvider.ExecuteNonQuery(string.Format("delete from {0}\r\nwhere {1} in (select t1.{1} from {3} where {5})\r\nand {2} in (select t2.{2} from {4} where {6} and {1} <> {2})", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "t1"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "t2"), ElmaInExpression.ToString("t1." + transformationProvider.Dialect.QuoteIfNeeded("Parent"), list), ElmaInExpression.ToString("t2." + transformationProvider.Dialect.QuoteIfNeeded("Child"), list)));
			}
			if (to != null && (list2.Count != 1 || to.Id != list2[0]))
			{
				transformationProvider.ExecuteNonQuery(string.Format("insert into {0} ({1}, {2}, {5}, {6})\r\nselect tree.{1}, subtree.{2}, tree.{5} + subtree.{5} + 1, tree.{6}\r\nfrom {8}, {9}\r\nwhere tree.{2} = {7} and subtree.{4}", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.ParameterSeparator, ElmaInExpression.ToString(transformationProvider.Dialect.QuoteIfNeeded("Parent"), list), transformationProvider.Dialect.QuoteIfNeeded("Depth"), transformationProvider.Dialect.QuoteIfNeeded("Owner"), to.Id, transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "tree"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "subtree")));
			}
			if (to != null && (list2.Count != 1 || to.Id != list2[0]))
			{
				long owner = GetOwner(to);
				transformationProvider.ExecuteNonQuery(string.Format("update {0}\r\nset {1} = {2}\r\nwhere {3} in (select s.{3} from {5} where s.{4})", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Owner"), owner, transformationProvider.Dialect.QuoteIfNeeded("Child"), ElmaInExpression.ToString(transformationProvider.Dialect.QuoteIfNeeded("Parent"), list), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "s")));
			}
		}
	}

	public void FullRemove(IEnumerable<IDmsObject> dmsObjs)
	{
		FullRemove(dmsObjs.Select((IDmsObject o) => o.Id));
	}

	public void FullRemove(IEnumerable<long> dmsIds)
	{
		transformationProvider.ExecuteNonQuery(string.Format("delete from {0} where {1} in (select s.{1} from {2} where {3})", transformationProvider.Dialect.QuoteIfNeeded("Sys_DmsObjectRelation"), transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "s"), ElmaInExpression.ToString("s." + transformationProvider.Dialect.QuoteIfNeeded("Parent"), dmsIds)));
	}

	private long GetOwner(IDmsObject dms)
	{
		if (dms is IMyDocumentFolder myDocumentFolder && myDocumentFolder.Owner != null)
		{
			return myDocumentFolder.Owner.Id;
		}
		if (dms.Folder != null)
		{
			if (dms.Folder is IMyDocumentFolder myDocumentFolder2 && myDocumentFolder2.Owner != null)
			{
				return myDocumentFolder2.Owner.Id;
			}
			string sql = string.Format("select distinct s.{0} from {1} where s.{2} = {3} and {0} <> 0", transformationProvider.Dialect.QuoteIfNeeded("Owner"), transformationProvider.NoLockTableExpression("Sys_DmsObjectRelation", "s"), transformationProvider.Dialect.QuoteIfNeeded("Child"), dms.Folder.Id);
			using IDataReader dataReader = transformationProvider.ExecuteQuery(sql);
			if (dataReader.Read())
			{
				long.TryParse(dataReader[0].ToString(), out var result);
				return result;
			}
		}
		return 0L;
	}
}

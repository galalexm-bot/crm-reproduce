using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

[Component]
[DeveloperApi(DeveloperApiType.Manager)]
public class AttachmentManager : EntityManager<IAttachment, long>
{
	public new static AttachmentManager Instance => Locator.GetServiceNotNull<AttachmentManager>();

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IAttachment>();
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
				PropertyName = "File",
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

	public IEnumerable<IAttachment> FindByUidArray(List<Guid> uids)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)uids));
		return obj.List<IAttachment>();
	}

	public IEnumerable<FileAttachmentInfo> AttachmentsInfo(List<Guid> uids)
	{
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		int i = 0;
		Dictionary<string, object> dictionary = ((IEnumerable<Guid>)uids).ToDictionary((Func<Guid, string>)((Guid k) => $"u{i++}"), (Func<Guid, object>)((Guid v) => v));
		string sql = string.Format("SELECT a.{1}, a.{2} from {0} WHERE a.{2} IN ({3}) AND a.{1} is not null ", transformationProvider.NoLockTableExpression("Attachment", "a"), transformationProvider.Dialect.QuoteIfNeeded("File"), transformationProvider.Dialect.QuoteIfNeeded("Uid"), string.Join(",", dictionary.Keys.Select((string k) => transformationProvider.ParameterSeparator + k)));
		List<FileAttachmentInfo> list = new List<FileAttachmentInfo>();
		using IDataReader dataReader = transformationProvider.ExecuteQuery(sql, dictionary);
		while (dataReader.Read())
		{
			list.Add(new FileAttachmentInfo
			{
				FileId = dataReader["File"].ToString(),
				AttachmentUid = transformationProvider.Dialect.GetGuid(dataReader["Uid"])
			});
		}
		return list;
	}

	[PublicApiMember]
	public virtual IAttachment Create(string fileName, string filePath)
	{
		IAttachment attachment = Instance.Create();
		attachment.File = BinaryFile.CreateNew().Name(fileName).Content(filePath)
			.Build();
		Locator.GetServiceNotNull<IFileManager>().SaveFile(attachment.File);
		return attachment;
	}

	[PublicApiMember]
	public virtual IAttachment Create(BinaryFile file)
	{
		return Create(file, null);
	}

	[PublicApiMember]
	public virtual IAttachment Create(BinaryFile file, IUser creationAuthor)
	{
		IAttachment attachment = Instance.Create();
		attachment.File = file;
		attachment.CreationAuthor = creationAuthor ?? base.AuthenticationService.GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		attachment.Save();
		return attachment;
	}
}

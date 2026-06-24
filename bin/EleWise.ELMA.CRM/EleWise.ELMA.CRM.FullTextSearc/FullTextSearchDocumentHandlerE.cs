using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
public class FullTextSearchDocumentHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private Guid uid = new Guid("577B8FED-A63F-4F68-BE11-D4AC36352B9E");

	private List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IDocument>() };

	private List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Id)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsDeleted))
	};

	public override Guid Uid => uid;

	public override Type SupportedCard => typeof(IContractorFullTextSearchObject);

	public override List<Guid> SupportedUids => supportedUids;

	public override List<string> GetImportantProperties
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor || !serviceNotNull.Settings.IndexingContractorAttachments)
			{
				return new List<string>();
			}
			return importantProperties;
		}
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (mergedIndexQueueItem != null && serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor && serviceNotNull.Settings.IndexingContractorAttachments)
		{
			ITransformationProvider serviceNotNull2 = Locator.GetServiceNotNull<ITransformationProvider>();
			string sql = string.Format("SELECT DISTINCT ca.{4} as {7} FROM {1} ca left join {2} mca on ca.{0} = mca.{3} WHERE ca.{4} IS NOT NULL AND mca.{5} = {6}DocId ", serviceNotNull2.Dialect.QuoteIfNeeded("Id"), serviceNotNull2.Dialect.QuoteIfNeeded("CRMAttachment"), serviceNotNull2.Dialect.QuoteIfNeeded("M_CRMAttachment_Documents"), serviceNotNull2.Dialect.QuoteIfNeeded("Parent"), serviceNotNull2.Dialect.QuoteIfNeeded("Contractor"), serviceNotNull2.Dialect.QuoteIfNeeded("Child"), serviceNotNull2.ParameterSeparator, serviceNotNull2.Dialect.QuoteIfNeeded("IdContractor"));
			Dictionary<string, object> paramValues = new Dictionary<string, object> { { "DocId", id } };
			List<long> list2 = new List<long>();
			using (IDataReader dataReader = serviceNotNull2.ExecuteQuery(sql, paramValues))
			{
				while (dataReader.Read())
				{
					list2.Add(Convert.ToInt64(dataReader["IdContractor"]));
				}
			}
			if (list2.Any())
			{
				foreach (IContractor item in ContractorManager.Instance.FindByIdArray(list2.Distinct().ToArray()))
				{
					QueueToIndex queueToIndex = new QueueToIndex
					{
						Id = item.Id,
						CardType = typeof(IContractorFullTextSearchObject),
						Properties = new List<KeyValuePair<string, object>>()
					};
					ContractorFullTextSearchExtension.GetAttachmentsForContractor(item, out var attachmentsName, out var attachmentsText, out var documentsName, out var documentsId);
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsName)), new SerializableList<object>(attachmentsName)));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsText)), new SerializableList<object>(attachmentsText)));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsId)), new SerializableList<object>(documentsId.Cast<object>())));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsName)), new SerializableList<object>(documentsName)));
					if (queueToIndex.Properties.Any())
					{
						list.Add(queueToIndex);
					}
				}
				return list;
			}
		}
		return list;
	}
}

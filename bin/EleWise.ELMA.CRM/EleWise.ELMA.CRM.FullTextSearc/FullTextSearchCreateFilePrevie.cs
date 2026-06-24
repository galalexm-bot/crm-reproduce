using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
public class FullTextSearchCreateFilePreviewItemIndex : ICreateFilePreviewItemIndex
{
	private Guid _previewItemIndexUid = new Guid("FB367E5A-58D2-4643-8A6D-AECFF2D4F1AC");

	public Guid Uid => _previewItemIndexUid;

	public void AddPreviewToIndexQueue(BinaryFile file)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor || !serviceNotNull.Settings.IndexingContractorAttachments)
		{
			return;
		}
		ITransformationProvider serviceNotNull2 = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("SELECT DISTINCT ca.{4} as {7} FROM {1} ca left join {2} mca on ca.{0} = mca.{3} left join {8} att on mca.{5} = att.{0} WHERE ca.{4} IS NOT NULL AND att.{9} = {6}FileUid ", serviceNotNull2.Dialect.QuoteIfNeeded("Id"), serviceNotNull2.Dialect.QuoteIfNeeded("CRMAttachment"), serviceNotNull2.Dialect.QuoteIfNeeded("M_CRMAttachment_Files"), serviceNotNull2.Dialect.QuoteIfNeeded("Parent"), serviceNotNull2.Dialect.QuoteIfNeeded("Contractor"), serviceNotNull2.Dialect.QuoteIfNeeded("Child"), serviceNotNull2.ParameterSeparator, serviceNotNull2.Dialect.QuoteIfNeeded("IdContractor"), serviceNotNull2.Dialect.QuoteIfNeeded("Attachment"), serviceNotNull2.Dialect.QuoteIfNeeded("File"));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		List<long> list = new List<long>();
		dictionary.Add("FileUid", file.Uid.ToString());
		using (IDataReader dataReader = serviceNotNull2.ExecuteQuery(sql, dictionary))
		{
			while (dataReader.Read())
			{
				list.Add(Convert.ToInt64(dataReader["IdContractor"]));
			}
		}
		if (!list.Any())
		{
			return;
		}
		foreach (IContractor item in ContractorManager.Instance.FindByIdArray(list.Distinct().ToArray()))
		{
			ContractorFullTextSearchExtension.GetAttachmentsForContractor(item, out var attachmentsName, out var attachmentsText, out var documentsName, out var documentsId);
			List<KeyValuePair<string, object>> list2 = new List<KeyValuePair<string, object>>();
			list2.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsName)), new SerializableList<object>(attachmentsName)));
			list2.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsText)), new SerializableList<object>(attachmentsText)));
			list2.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsId)), new SerializableList<object>(documentsId.Cast<object>())));
			list2.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsName)), new SerializableList<object>(documentsName)));
			IndexQueueManager.Instance.AddReindexObjectPartItem(typeof(IContractorFullTextSearchObject), item.Id, item.TypeUid, list2);
		}
	}
}

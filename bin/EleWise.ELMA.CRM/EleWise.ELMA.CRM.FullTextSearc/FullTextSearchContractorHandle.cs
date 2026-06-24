using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
public class FullTextSearchContractorHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private Guid uid = new Guid("05701596-97B4-413F-B736-D7C99C2FDD62");

	private List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IContractor>() };

	private List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Id)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.CreationAuthor)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.CreationDate)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.ChangeDate)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.TypeUid)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Permission)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Categories)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.IsDeleted)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Site)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Email)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Phone))
	};

	private List<string> visualDataProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.IsDeleted))
	};

	public const string KeyRecalculateCategoryPermission = "Key31AA4139D3194D5F917DBF47E08B3CB9";

	public override Guid Uid => uid;

	public override Type SupportedCard => typeof(IContractorFullTextSearchObject);

	public override List<Guid> SupportedUids => supportedUids;

	public override List<string> GetImportantProperties
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
			{
				return new List<string>();
			}
			return importantProperties;
		}
	}

	public override List<string> GetVisualDataProperties
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
			{
				return new List<string>();
			}
			return visualDataProperties;
		}
	}

	private List<QueueToIndex> ProcessingRecalculateCategoryPermission(object idsObj)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		List<long> list2 = idsObj as List<long>;
		ContractorManager instance = ContractorManager.Instance;
		if (list2 != null && list2.Any())
		{
			list2 = (from id in list2.Distinct()
				orderby id
				select id).ToList();
			while (list2.Count > 0)
			{
				List<long> list3 = new List<long>();
				int count = ((100 <= list2.Count) ? 100 : list2.Count);
				list3.AddRange(list2.GetRange(0, count));
				if (list3.Any())
				{
					try
					{
						ICollection<IContractor> collection = instance.FindByIdArray(list3.ToArray());
						if (collection.Any())
						{
							foreach (IContractor item in collection)
							{
								if (item != null && item.Permission != null)
								{
									QueueToIndex queueToIndex = new QueueToIndex
									{
										Id = item.Id,
										CardType = typeof(IContractorFullTextSearchObject),
										Properties = new List<KeyValuePair<string, object>>()
									};
									List<string> list4 = new List<string>();
									list4.AddRange(from p in (IEnumerable<IContractorPersonPermission>)item.Permission
										where p != null
										select p into permission
										select permission.UserSecuritySetCacheId.ToString());
									SerializableList<object> value = new SerializableList<object>(list4);
									queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject c) => c.UserSecuritySetCacheId)), value));
									list.Add(queueToIndex);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
				list2.RemoveRange(0, count);
			}
		}
		return list;
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		if (mergedIndexQueueItem != null)
		{
			KeyValuePair<string, object> keyValuePair = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Key31AA4139D3194D5F917DBF47E08B3CB9"));
			if (keyValuePair.Key != null)
			{
				return ProcessingRecalculateCategoryPermission(keyValuePair.Value);
			}
			IContractor contractor = null;
			QueueToIndex queueToIndex = new QueueToIndex
			{
				Id = id,
				CardType = typeof(IContractorFullTextSearchObject),
				Properties = new List<KeyValuePair<string, object>>()
			};
			KeyValuePair<string, object> keyValuePair2 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Id))));
			if (keyValuePair2.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Id)), keyValuePair2.Value));
			}
			KeyValuePair<string, object> keyValuePair3 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Name))));
			if (keyValuePair3.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Name)), keyValuePair3.Value));
			}
			KeyValuePair<string, object> keyValuePair4 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Site))));
			if (keyValuePair4.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Site)), keyValuePair4.Value));
			}
			if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Phone)))).Key != null)
			{
				if (contractor == null)
				{
					contractor = ContractorManager.Instance.LoadOrNull(id);
				}
				if (contractor != null)
				{
					SerializableList<object> value = ((contractor.Phone != null) ? new SerializableList<object>(from e in (IEnumerable<IPhone>)contractor.Phone
						where e != null && !string.IsNullOrEmpty(e.PhoneString)
						select ContractorFullTextSearchExtension.ConvertPhoneNumber(e.PhoneString)) : new SerializableList<object>(new string[0]));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Phone)), value));
				}
			}
			if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Email)))).Key != null)
			{
				if (contractor == null)
				{
					contractor = ContractorManager.Instance.LoadOrNull(id);
				}
				if (contractor != null)
				{
					SerializableList<object> value2 = new SerializableList<object>((contractor.Email != null) ? new SerializableList<object>((from e in (IEnumerable<IEmail>)contractor.Email
						where e != null && !string.IsNullOrEmpty(e.EmailString)
						select e.EmailString).ToArray()) : new SerializableList<object>(new string[0]));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Email)), value2));
				}
			}
			KeyValuePair<string, object> keyValuePair5 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.TypeUid))));
			if (keyValuePair5.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.TypeUid)), keyValuePair5.Value));
			}
			KeyValuePair<string, object> keyValuePair6 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.IsDeleted))));
			if (keyValuePair6.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.IsDeleted)), keyValuePair6.Value));
			}
			KeyValuePair<string, object> keyValuePair7 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.CreationAuthor))));
			if (keyValuePair7.Key != null)
			{
				if (keyValuePair7.Value != null && long.TryParse(keyValuePair7.Value.ToString(), out var result))
				{
					IUser user = UserManager.Instance.LoadOrNull(result);
					if (user != null)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.CreationAuthor)), user.FullName));
					}
				}
				else
				{
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.CreationAuthor)), ""));
				}
			}
			KeyValuePair<string, object> keyValuePair8 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Permission))));
			KeyValuePair<string, object> keyValuePair9 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Categories))));
			if (keyValuePair8.Key != null || keyValuePair9.Key != null)
			{
				List<string> list2 = new List<string>();
				if (contractor == null)
				{
					contractor = ContractorManager.Instance.LoadOrNull(id);
				}
				if (contractor != null)
				{
					if (contractor.Permission != null)
					{
						list2.AddRange(from p in (IEnumerable<IContractorPersonPermission>)contractor.Permission
							where p != null
							select p into permission
							select permission.UserSecuritySetCacheId.ToString());
					}
					SerializableList<object> value3 = new SerializableList<object>(list2);
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject c) => c.UserSecuritySetCacheId)), value3));
				}
			}
			queueToIndex.DynamicProperties.AddRange(mergedIndexQueueItem.Select((KeyValuePair<string, object> i) => i.Value).OfType<FieldIndexListItem>());
			if (queueToIndex.Properties.Any() || queueToIndex.DynamicProperties.Any())
			{
				list.Add(queueToIndex);
			}
		}
		return list;
	}
}

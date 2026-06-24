using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class AddrManager : EntityManager<IAddrBase, long>
{
	public new static AddrManager Instance => Locator.GetServiceNotNull<AddrManager>();

	public ITransformationProvider TransformationProvider { get; set; }

	public IEnumerable<IAddrBase> GetChildren(Guid? parent, long type)
	{
		return GetChildren(parent, type, null);
	}

	public IEnumerable<IAddrBase> GetChildren(Guid? parent, long type, string searchString)
	{
		if (!parent.HasValue)
		{
			parent = Guid.Empty;
		}
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("ParentGuid", (object)parent));
		switch (type)
		{
		case 7L:
			return GetStreetsWithStreetsOfChildren(parent, searchString);
		default:
			val.Add((ICriterion)(object)Restrictions.Eq("TypeOfSub", (object)type));
			break;
		case 0L:
			break;
		}
		if (!string.IsNullOrWhiteSpace(searchString))
		{
			SetupAddressNameSearchString(val, searchString);
		}
		return val.AddOrder(Order.Asc("ObjectName")).List<IAddrBase>();
	}

	public IEnumerable<IAddrBase> GetRegions(long type, long? countryCode = null)
	{
		return GetRegions(type, countryCode, null);
	}

	public IEnumerable<IAddrBase> GetRegions(long type, long? countryCode, string searchString)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("TypeOfSub", (object)type)).Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)((!countryCode.HasValue) ? "" : countryCode.ToString()))).AddOrder(Order.Asc("ObjectName"));
		if (!string.IsNullOrWhiteSpace(searchString))
		{
			SetupAddressNameSearchString(val, searchString);
		}
		return val.List<IAddrBase>();
	}

	public IEnumerable<IAddrBase> FindItems(IEnumerable<string> fiasCodes)
	{
		ICriteria obj = CreateCriteria();
		object[] array = fiasCodes.ToArray();
		return obj.Add((ICriterion)(object)Restrictions.In("FiasCode", array)).List<IAddrBase>();
	}

	public IAddrBase FindItem(long type, string name, long? countryCode = null, Guid? parent = null)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("TypeOfSub", (object)type)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("ObjectName", (object)name), (ICriterion)(object)Restrictions.Eq("FullName", (object)name))).Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)((!countryCode.HasValue) ? "" : countryCode.ToString())))
			.AddOrder(Order.Asc("ObjectName"));
		if (parent.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("ParentGuid", (object)parent));
		}
		return val.List<IAddrBase>().FirstOrDefault();
	}

	public IAddrBase GetItem(long id, long? countryCode = null)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Id", (object)id)).Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)((!countryCode.HasValue) ? "" : countryCode.ToString()))).UniqueResult<IAddrBase>();
	}

	public IAddrBase GetItemByGuid(Guid? uid)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Uid", (object)uid)).UniqueResult<IAddrBase>();
	}

	public int GetMaxId()
	{
		ICriteria val = CreateCriteria();
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Max("Id") });
		return Convert.ToInt32(val.UniqueResult());
	}

	public IList<Guid> GetPresentsUids(Guid[] uids)
	{
		return (from n in CreateCriteria().Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)uids)).List<IAddrBase>()
			select n.Uid).ToList();
	}

	public Guid? FindInExistItems(string name, Guid? parentUid, long? countryCode = null)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("FullName", (object)name)).Add((ICriterion)(object)Restrictions.Eq("ParentGuid", (object)parentUid));
		if (countryCode.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)countryCode.ToString()));
		}
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Uid") });
		return val.List<Guid>().FirstOrDefault();
	}

	public IList<ICountry> SearchCountryInBase(long? countryCode, string name)
	{
		IList<ICountry> list = SearchCountryWithCode(countryCode, name);
		if (list.Count == 0)
		{
			list = SearchCountryWithCode(null, name);
		}
		return list;
	}

	public IList<ICountry> SearchCountryWithCode(long? countryCode)
	{
		return SearchCountryWithCode(countryCode, null);
	}

	public IList<ICountry> SearchCountryWithCode(long? countryCode, string name)
	{
		ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<ICountry>());
		if (countryCode.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)countryCode));
		}
		if (!string.IsNullOrEmpty(name))
		{
			val.Add((ICriterion)(object)ElmaRestrictions.Like("Name", name, MatchMode.Exact));
		}
		return val.List<ICountry>();
	}

	public IList<IAddress> GetAddressesForCountry(ICountry country)
	{
		return CreateCriteria(null, InterfaceActivator.TypeOf<IAddress>()).Add((ICriterion)(object)Restrictions.Eq("Country", (object)country)).List<IAddress>();
	}

	public string GenerateName(string formatTemplate, IAddress model)
	{
		string input = new TextTemplateGenerator(formatTemplate).Generate(model);
		string pattern = "\\s+";
		string replacement = " ";
		char[] trimChars = new char[2] { ',', ' ' };
		return Regex.Replace(input, pattern, replacement).Trim(trimChars);
	}

	public IAddrBase Save(string name, long type, Guid? parentUid, long? code)
	{
		if (name.IsNullOrEmpty())
		{
			return null;
		}
		InstanceOf<IAddrBase> instanceOf = new InstanceOf<IAddrBase>();
		instanceOf.New.TypeOfSub = type;
		instanceOf.New.Uid = Guid.NewGuid();
		instanceOf.New.CountryCode = code.ToString();
		instanceOf.New.ParentGuid = parentUid;
		instanceOf.New.ObjectName = name;
		instanceOf.New.ShortName = "";
		instanceOf.New.FullName = name;
		instanceOf.New.FiasCode = "";
		instanceOf.New.ZIP = "";
		instanceOf.New.UpdateDate = DateTime.Now;
		instanceOf.New.Actual = true;
		IAddrBase @new = instanceOf.New;
		@new.Save();
		return @new;
	}

	internal IEnumerable<HistoryCollectorRelatedModel> GetContractorAddressRelatedHistory(long id, Guid actionObject)
	{
		Type type = InterfaceActivator.TypeOf<IContractor>();
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		EntityMetadata entityMetadata2 = MetadataLoader.LoadMetadata(InterfaceActivator.UID<IAddress>()) as EntityMetadata;
		List<Guid> addressImplementations = MetadataLoader.GetChildClasses(entityMetadata2).SelectMany(delegate(ClassMetadata impl)
		{
			EntityMetadata entityMetadata3 = impl as EntityMetadata;
			return new Guid[2] { entityMetadata3.Uid, entityMetadata3.ImplementationUid };
		}).ToList();
		addressImplementations.AddRange(new Guid[2] { entityMetadata2.Uid, entityMetadata2.ImplementationUid });
		List<PropertyMetadata> list = entityMetadata.Properties.Where((PropertyMetadata p) => addressImplementations.Contains(p.SubTypeUid)).ToList();
		ProjectionList val = Projections.ProjectionList();
		ICriteria val2 = CreateCriteria(null, type);
		foreach (PropertyMetadata item2 in list)
		{
			string name = item2.Name;
			val2.CreateAlias(name, name, (JoinType)1);
			val.Add((IProjection)(object)Projections.Property($"{name}.Id"), $"{name}Id").Add((IProjection)(object)Projections.Property($"{name}.{NHibernateHelper.GetCriteriaTypeUidPropertyName(item2.SubTypeUid)}"), $"{name}TypeUid");
		}
		ICriteria val3 = val2.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val }).Add((ICriterion)(object)Restrictions.Eq("Id", (object)id));
		ICriteria val4 = CreateCriteria(null, InterfaceActivator.TypeOf<IAddress>());
		string sql = string.Format("{{{0}.{1}}} in \r\n(\r\n select hist.{4} from \r\n (\r\n  select {2} from {3} where {4} =? and {5} =? \r\n ) tmp \r\n join {3} hist on hist.{2} = tmp.{2}\r\n join {7} addr on addr.{6} = hist.{5}\r\n)", val4.get_Alias(), TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("UnitOfWorkUid"), TransformationProvider.Dialect.QuoteIfNeeded("EntityActionHistory"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("TypeUid"), TransformationProvider.Dialect.QuoteIfNeeded("Address"));
		List<object> list2 = ((IEnumerable<object>)val4.Add((ICriterion)(object)NHQueryExtensions.Sql(sql, new object[2] { id, actionObject }, (IType[])(object)new IType[2]
		{
			(IType)NHibernateUtil.Int64,
			(IType)NHibernateUtil.Guid
		})).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(entityMetadata2.ImplementationUid)), "TypeUid") }).Future<object>()).ToList();
		List<object> list3 = (from pair in val3.UniqueResult<object>().CastAs<IEnumerable<object>>()
			where pair != null
			select pair).ToList();
		List<HistoryCollectorRelatedModel> list4 = new List<HistoryCollectorRelatedModel>();
		for (int i = 0; i < list3.Count; i += 2)
		{
			list2.Add(new object[2]
			{
				list3[i],
				list3[i + 1]
			});
		}
		foreach (object item3 in list2.Distinct())
		{
			List<object> list5 = item3.CastAs<IEnumerable<object>>().ToList();
			HistoryCollectorRelatedModel item = new HistoryCollectorRelatedModel
			{
				EntityId = Convert.ToInt64(list5[0]),
				EntityTypeUid = Guid.Parse(list5[1].ToString())
			};
			list4.Add(item);
		}
		return list4;
	}

	private void SetupAddressNameSearchString(ICriteria criteria, string searchString)
	{
		string[] array = searchString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 0)
		{
			Conjunction val = Restrictions.Conjunction();
			string[] array2 = array;
			foreach (string value in array2)
			{
				((Junction)val).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)ElmaRestrictions.InsensitiveLike("ObjectName", value, MatchMode.Anywhere), (ICriterion)(object)ElmaRestrictions.InsensitiveLike("FullName", value, MatchMode.Anywhere)));
			}
			criteria.Add((ICriterion)(object)val);
		}
	}

	private IEnumerable<IAddrBase> GetStreetsWithStreetsOfChildren(Guid? parent, string searchString)
	{
		string sqlSearchString = "";
		List<string> searchItems = new List<string>();
		if (!string.IsNullOrWhiteSpace(searchString))
		{
			searchItems = (from s in searchString.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				select $"%{s.ToLower()}%").ToList();
			sqlSearchString = GetAddressNameSqlSearchString(searchItems);
		}
		return GetStreetsWithStreetsOfChildren(parent, sqlSearchString, searchItems);
	}

	private IEnumerable<IAddrBase> GetStreetsWithStreetsOfChildren(Guid? parent, string sqlSearchString, IList<string> searchItems)
	{
		IQuery val = ((IQuery)base.Session.CreateSQLQuery(string.Format("SELECT * FROM\r\n    (SELECT *\r\n        FROM {1}\r\n        WHERE {3}=:streetType {5}\r\n            AND {2} IN (\r\n                SELECT {0}\r\n                FROM {1}\r\n                WHERE {2}=:parentUid\r\n                AND {3}=:cityType\r\n            )\r\n    UNION\r\n    SELECT *\r\n        FROM {1}\r\n        WHERE {2}=:parentUid {5}\r\n            AND {3}=:streetType) ab\r\nORDER BY ab.{4}", TransformationProvider.Dialect.QuoteIfNeeded("Uid"), TransformationProvider.Dialect.QuoteIfNeeded("AddressBase"), TransformationProvider.Dialect.QuoteIfNeeded("ParentGuid"), TransformationProvider.Dialect.QuoteIfNeeded("TypeOfSub"), TransformationProvider.Dialect.QuoteIfNeeded("ObjectName"), sqlSearchString)).AddEntity(InterfaceActivator.TypeOf<IAddrBase>())).SetParameter<Guid?>("parentUid", parent).SetParameter<long>("cityType", 5L).SetParameter<long>("streetType", 7L);
		for (int i = 0; i < searchItems.Count; i++)
		{
			val.SetParameter<string>($"searchString{i}", searchItems[i]);
		}
		return val.CleanUpCache(cleanUpCache: false).List<IAddrBase>();
	}

	private string GetAddressNameSqlSearchString(ICollection searchItems)
	{
		string text = "";
		string format = string.Format(" AND (lower({0}) like :searchString{{0}} OR lower({1}) like :searchString{{0}})", TransformationProvider.Dialect.QuoteIfNeeded("ObjectName"), TransformationProvider.Dialect.QuoteIfNeeded("FullName"));
		for (int i = 0; i < searchItems.Count; i++)
		{
			text += string.Format(format, i);
		}
		return text;
	}
}

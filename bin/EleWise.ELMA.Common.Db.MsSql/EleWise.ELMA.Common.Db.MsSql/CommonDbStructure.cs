using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Db.MsSql;

public class CommonDbStructure : DbStructureExtension
{
	private IMetadataUidChecker metadataUidChecker;

	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Common.Db.CommonDbStructure);

	public CommonDbStructure(IMetadataUidChecker metadataUidChecker)
	{
		this.metadataUidChecker = metadataUidChecker;
	}

	internal void AddTablePartsUid()
	{
		foreach (IMetadataItem item in LoadMetadataItemInfo())
		{
			if (item.Metadata is EntityMetadata metadata && metadataUidChecker.AddUidIfNeeded(metadata))
			{
				item.Save();
			}
		}
	}

	private IEnumerable<IMetadataItem> LoadMetadataItemInfo()
	{
		ICriteria val = Locator.GetServiceNotNull<ISessionProvider>().GetSession("").CreateCriteria(InterfaceActivator.TypeOf<IMetadataItem>());
		string sql = $"cast({base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((IMetadataItem i) => i.Metadata))} as varchar(max)) like '%TablePartMetadata%'";
		val.Add((ICriterion)(object)NHQueryExtensions.Sql(sql));
		return val.List<IMetadataItem>();
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Db.MsSql;

internal class DocumentsDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Documents.Db.DocumentsDbStructure);

	internal void UpdateDocumentMetadata()
	{
		string sql = string.Format("\r\n                select {0}.{1} from {2} {0}\r\n                inner join {4} {5} on {0}.{1} = {5}.{6} or {0}.{1} = {5}.{7}\r\n                where {0}.{3} like 'EleWise.ELMA.Documents.Metadata.DocumentMetadata,%'", "mi", base.Transformation.Dialect.QuoteIfNeeded("Id"), base.Transformation.Dialect.QuoteIfNeeded("MetadataItem"), base.Transformation.Dialect.QuoteIfNeeded("Metadata"), base.Transformation.Dialect.QuoteIfNeeded("MetadataItemHeader"), "mih", base.Transformation.Dialect.QuoteIfNeeded("Published"), base.Transformation.Dialect.QuoteIfNeeded("Current"));
		List<long> list = new List<long>();
		using (IDataReader dataReader = base.Transformation.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				long num = Convert.ToInt64(dataReader[0]);
				if (num > 0)
				{
					list.Add(num);
				}
			}
		}
		Locator.GetServiceNotNull<EleWise.ELMA.Documents.Db.DocumentsDbStructure>().UpdateDocumentMetadata(list.ToArray());
	}
}

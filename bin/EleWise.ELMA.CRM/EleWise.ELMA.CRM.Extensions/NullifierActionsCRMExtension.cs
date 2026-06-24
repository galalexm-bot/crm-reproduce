using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.CRM.Extensions;

[Component]
internal class NullifierActionsCRMExtension : INullifierActions
{
	public void CreateTree(Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode)
	{
	}

	public DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput)
	{
		return null;
	}

	public void PostNullifier(PostNullifierParameters postNullifierParameters)
	{
	}

	public void SearchSystemFile()
	{
	}

	public void ClearObject(ClearObjectParameters clearObjectParameters)
	{
		string text = clearObjectParameters.Transform.Dialect.QuoteIfNeeded("nulltemptableoneFolder");
		foreach (UnitNullConfig unit in clearObjectParameters.units)
		{
			if (unit.TypeUid == new Guid("c40fd1d3-f5d9-4323-9e51-42ebfa77e6dc") && unit.Uid == new Guid("53aec390-f75e-406d-9761-a17825a4a346"))
			{
				string arg = string.Format("select ff.{1} from {4} sf left join {3} ff on ff.{1}=sf.{2} ", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Filter"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Filter"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FilterFolder"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("SaleFunnel"));
				clearObjectParameters.SqlQuery(string.Format("insert into  {0} ({1}) {2}", text, clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), arg), SR.T("-9- Заполнение временной таблицы"));
				string arg2 = string.Format("delete from {0} where {5} in (select ff.{1} from {4} sf left join {3} ff on ff.{1}=sf.{2} )", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FilterPermission"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Filter"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FilterFolder"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("SaleFunnel"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FilterObj"));
				clearObjectParameters.SqlQuery(arg2, SR.T("-86- "));
				arg2 = string.Format("update  {0} set {1}=null ", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("SaleFunnel"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Filter"));
				clearObjectParameters.SqlQuery(arg2, SR.T("-86- "));
				clearObjectParameters.SqlQuery(string.Format("delete from {0} where {1} in (select {1} from {2})", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("FilterFolder"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded(text)), SR.T("-86- "));
				arg2 = string.Format("delete from {0} where {1} in (select {1} from {2})", clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Filter"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded("Id"), clearObjectParameters.Transform.Dialect.QuoteIfNeeded(text));
				clearObjectParameters.SqlQuery(arg2, SR.T("-86- "));
				clearObjectParameters.DeleteEntityMetadataUnit(new UnitNullConfig
				{
					Uid = unit.Uid
				}, null, arg3: false, 1, arg5: false);
				clearObjectParameters.SqlQuery($"delete from {text}", string.Format(SR.T("-25- Создание временной таблицы  ")));
			}
		}
	}
}

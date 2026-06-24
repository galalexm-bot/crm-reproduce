using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.FileProvider.Distributed.Managers;

[Service(Type = ComponentType.Server)]
public class DistributedFileOriginManager : NHManager
{
	public SystemFileNHManager SystemFileNHManager { get; set; }

	public virtual BinaryFileOrigin LoadOrigin(SystemFile systemFile)
	{
		string text = base.Session.CreateCriteria<ContentOrigin>().Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)Projections.Property<ContentOrigin>((Expression<Func<ContentOrigin, object>>)((ContentOrigin x) => x.FileId)), (object)systemFile.Id)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property<ContentOrigin>((Expression<Func<ContentOrigin, object>>)((ContentOrigin x) => x.SourceGateway)) })
			.List<string>()
			.FirstOrDefault();
		if (text == null)
		{
			throw new FileNotFoundException(SR.T("Источник файла Id={0} не указан в БД", systemFile.Id));
		}
		return new BinaryFileOrigin
		{
			FileId = systemFile.Id,
			SourceGateway = text
		};
	}

	public virtual BinaryFileOrigin LoadOrigin(BinaryFile binaryFile)
	{
		string text = ((binaryFile.Uid != Guid.Empty) ? binaryFile.Uid.ToString() : binaryFile.Id);
		SystemFile systemFile = SystemFileNHManager.LoadFile(text);
		if (systemFile == null)
		{
			throw new FileNotFoundException(SR.T("Файл не найден в хранилище (по идентификатору {0})", text));
		}
		return LoadOrigin(systemFile);
	}

	[Transaction]
	public virtual void SaveOrigin(SystemFile systemFile, string place)
	{
		ContentOrigin contentOrigin = new ContentOrigin
		{
			FileId = systemFile.Id,
			SourceGateway = place
		};
		try
		{
			base.Session.Save((object)contentOrigin);
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
			throw;
		}
	}

	internal void CreateOriginsForLegacyMode(string legacyEndpointId)
	{
		if (Convert.ToInt64(base.Session.CreateCriteria<ContentOrigin>().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count<ContentOrigin>((Expression<Func<ContentOrigin, object>>)((ContentOrigin x) => x.Id)) }).UniqueResult<object>()) != 0L)
		{
			return;
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("SELECT {0} FROM {1}", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("FS_FILES"));
		List<int> list = new List<int>();
		using (IDataReader dataReader = serviceNotNull.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				list.Add(dataReader.GetInt32(0));
			}
		}
		IEnumerable<ContentOrigin> enumerable = list.Select((int id) => new ContentOrigin
		{
			FileId = id,
			SourceGateway = legacyEndpointId
		});
		ITransaction val = base.Session.BeginTransaction();
		foreach (ContentOrigin item in enumerable)
		{
			base.Session.Save((object)item);
		}
		val.Commit();
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapDataSet : IDisposable
{
	private const int dbParametersMaxCount = 1500;

	private bool disposed;

	private DataTable headerTable;

	public IList<DataTable> DataSource { get; private set; }

	public IList<DataTable> Relations { get; private set; }

	public MapInfo MapInfo { get; private set; }

	public DataTable HeaderTable
	{
		get
		{
			if (headerTable == null)
			{
				DataTable dataTable = null;
				if (MapInfo.Metadata is EntityMetadata metadata)
				{
					List<ClassMetadata> baseClassMetadataList = MetadataLoader.GetBaseClassMetadataList(metadata);
					EntityMetadata baseClass = baseClassMetadataList.FirstOrDefault(delegate(ClassMetadata a)
					{
						_ = a.BaseClassUid;
						return a.BaseClassUid.Equals(Guid.Empty);
					}) as EntityMetadata;
					if (baseClass != null)
					{
						dataTable = DataSource.FirstOrDefault((DataTable a) => a.TableName == baseClass.TableName);
					}
				}
				headerTable = dataTable ?? DataSource.FirstOrDefault();
			}
			return headerTable;
		}
	}

	public int CurrentRowIndex { get; set; }

	public int PageSize
	{
		get
		{
			if (MapInfo.Keys.Count <= 0)
			{
				return 1500;
			}
			return (int)Math.Truncate(1500m / (decimal)MapInfo.Keys.Count);
		}
	}

	public int PageCount => (int)Math.Ceiling((decimal)HeaderTable.Rows.Count / (decimal)PageSize);

	public int MaxPageIndex
	{
		get
		{
			int num = CurrentRowIndex + PageSize;
			if (num <= HeaderTable.Rows.Count)
			{
				return num;
			}
			return HeaderTable.Rows.Count;
		}
	}

	public int InsertedRowsCount { get; set; }

	public List<long> InsertedIds { get; set; }

	public MapDataSet(MapInfo mapInfo)
	{
		DataSource = new List<DataTable>();
		Relations = new List<DataTable>();
		InsertedIds = new List<long>();
		MapInfo = mapInfo;
	}

	public void SetNextPage()
	{
		CurrentRowIndex += PageSize;
	}

	public void ResetPage()
	{
		CurrentRowIndex = 0;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		if (disposing)
		{
			foreach (DataTable item in DataSource)
			{
				item.Dispose();
			}
		}
		disposed = true;
	}
}

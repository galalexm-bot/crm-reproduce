using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapDataSetList : IEnumerable<MapDataSet>, IEnumerable, IDisposable
{
	private List<MapDataSet> dataSets;

	private bool disposed;

	public List<MapInfo> Items { get; private set; }

	public MapDataSetList(List<MapInfo> mapInfoList)
	{
		Items = mapInfoList;
	}

	private List<MapDataSet> GetDataSets()
	{
		if (dataSets == null)
		{
			dataSets = Items.Select((MapInfo info) => info.ToDataSet()).ToList();
		}
		return dataSets;
	}

	public IEnumerator<MapDataSet> GetEnumerator()
	{
		List<MapDataSet> list = GetDataSets();
		foreach (MapDataSet item in list)
		{
			yield return item;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
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
			if (dataSets == null)
			{
				return;
			}
			foreach (MapDataSet dataSet in dataSets)
			{
				dataSet.Dispose();
			}
		}
		disposed = true;
	}
}

using System;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public abstract class GridViewItemBuilder<TM, T, TB> : ViewItemBuilder<TM, T, TB> where TM : IEntity where T : GridViewItem, new()where TB : GridViewItemBuilder<TM, T, TB>
{
	internal static object lQM7nAoDokdkYvKm1hNU;

	protected GridViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected GridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TB EntityUid(Guid entityUid)
	{
		base.ViewItem.EntityUid = entityUid;
		return this as TB;
	}

	public TB PropertyUid(Guid propertyUid)
	{
		base.ViewItem.PropertyUid = propertyUid;
		return this as TB;
	}

	public TB ShowCount(bool showCount = true)
	{
		base.ViewItem.ShowCount = showCount;
		return this as TB;
	}

	public TB Query(string query)
	{
		base.ViewItem.Query = query;
		return this as TB;
	}

	public TB SelectedColumns(params Guid[] selectedColumns)
	{
		base.ViewItem.SelectedColumns = selectedColumns;
		return this as TB;
	}

	internal static bool EZqp8HoDbBy4igc9U1V9()
	{
		return lQM7nAoDokdkYvKm1hNU == null;
	}

	internal static object zU6lOjoDhn9RMPnE7ipj()
	{
		return lQM7nAoDokdkYvKm1hNU;
	}
}
public class GridViewItemBuilder<TM> : GridViewItemBuilder<TM, GridViewItem, GridViewItemBuilder<TM>> where TM : IEntity
{
	internal static object csFmKloDGk1kt871P7wy;

	public GridViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal GridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qPcp53oDEMM7IHQe8xyt()
	{
		return csFmKloDGk1kt871P7wy == null;
	}

	internal static object QUOfCwoDfbl7wpnUwfak()
	{
		return csFmKloDGk1kt871P7wy;
	}
}

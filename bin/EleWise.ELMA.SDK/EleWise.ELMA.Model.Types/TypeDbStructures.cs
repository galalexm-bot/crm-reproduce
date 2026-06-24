using System;
using System.Collections.Generic;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

public class TypeDbStructures
{
	private List<Column> columns;

	private List<ForeignKey> foreignKeys;

	private List<PrimaryKey> primaryKeys;

	private List<Table> tables;

	private List<Tuple<string, object>> updates;

	internal static TypeDbStructures rGvxNIo9ZqYykUQruGpG;

	public List<Column> Columns => columns;

	public List<ForeignKey> ForeignKeys => foreignKeys;

	public List<PrimaryKey> PrimaryKeys => primaryKeys;

	public List<Table> Tables => tables;

	internal List<Tuple<string, object>> Updates => updates;

	public TypeDbStructures()
	{
		//Discarded unreachable code: IL_007a, IL_007f
		f1waguo9V95SX5kGKAVW();
		columns = new List<Column>();
		foreignKeys = new List<ForeignKey>();
		primaryKeys = new List<PrimaryKey>();
		tables = new List<Table>();
		updates = new List<Tuple<string, object>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void f1waguo9V95SX5kGKAVW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JsVWyco9u3wIYDKowcVc()
	{
		return rGvxNIo9ZqYykUQruGpG == null;
	}

	internal static TypeDbStructures Sf14ago9IbCAEPsZKEdi()
	{
		return rGvxNIo9ZqYykUQruGpG;
	}
}

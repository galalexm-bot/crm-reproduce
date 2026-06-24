using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class FormDependencyHelper
{
	internal static readonly Guid DisplayFormUid;

	internal static readonly Guid EditFormUid;

	internal static readonly Guid CreateFormUid;

	internal static readonly string KeySplitter;

	internal static FormDependencyHelper pamK8whY96cW9Dxr5ldj;

	internal static Guid ViewTypeToGuid(ViewType viewType)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return CreateFormUid;
			case 1:
				goto IL_0059;
			case 2:
				{
					switch (viewType)
					{
					case ViewType.Create:
						break;
					case ViewType.Edit:
						return EditFormUid;
					case ViewType.Display:
						return DisplayFormUid;
					case ViewType.Create | ViewType.Edit:
						goto IL_0059;
					default:
						goto IL_0077;
					}
					goto default;
				}
				IL_0077:
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
				IL_0059:
				return Guid.Empty;
			}
		}
	}

	internal static ViewType GuidToViewType(Guid uid)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ViewType.Create;
			case 3:
				return ViewType.Edit;
			case 1:
				return ViewType.Display;
			case 2:
				if (!EX1AWwhYr3D4CvhBuFLE(uid, DisplayFormUid))
				{
					if (!EX1AWwhYr3D4CvhBuFLE(uid, EditFormUid))
					{
						if (!EX1AWwhYr3D4CvhBuFLE(uid, CreateFormUid))
						{
							return ViewType.All;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public static IEnumerable<IFormDependencyData> GenerateFormDependencies(Guid metadataUid, FormViewItem form)
	{
		return GenerateFormDependencies(metadataUid, form, null);
	}

	public static IEnumerable<IFormDependencyData> GenerateFormDependencies(Guid metadataUid, FormViewItem form, Guid? formUid)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.metadataUid = metadataUid;
		CS_0024_003C_003E8__locals0.formUid = formUid;
		CS_0024_003C_003E8__locals0.form = form;
		IEnumerable<ButtonViewItem> enumeration = from q in CS_0024_003C_003E8__locals0.form.GetAllItems().OfType<ButtonViewItem>()
			where _003C_003Ec.MppsW7vyWXhamHAhuVXV(_003C_003Ec.DfkjpevyF31q5iJxMwnQ(q), _003C_003Ec.B2HhujvyBERJLINGuTQu(-576149596 ^ -576043388))
			select q;
		CS_0024_003C_003E8__locals0.deps = new List<IFormDependencyData>();
		enumeration.ForEach(delegate(ButtonViewItem q)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					GenerateFormDependencies((string)_003C_003Ec__DisplayClass7_0.wOGbjbvmLrmL9EtYbnR8(q), CS_0024_003C_003E8__locals0.metadataUid, CS_0024_003C_003E8__locals0.formUid.HasValue ? CS_0024_003C_003E8__locals0.formUid.Value : CS_0024_003C_003E8__locals0.form.Uid, CS_0024_003C_003E8__locals0.deps);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.deps;
	}

	internal static void GenerateFormDependencies(string actionId, Guid metadataUid, Guid dependFormUid, List<IFormDependencyData> deps)
	{
		string[] array = actionId.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDE5BB2) }, StringSplitOptions.None);
		Guid guid = Guid.Parse(array[0]);
		Guid guid2 = Guid.Parse(array[1]);
		if (guid2 == dependFormUid)
		{
			return;
		}
		ViewType? viewType = null;
		if (Enum.TryParse<ViewType>(array[2], out var result))
		{
			viewType = result;
		}
		FormDependencyData formDependencyData = null;
		if (guid == PageMetadata.TypeUid)
		{
			formDependencyData = new FormDependencyData(metadataUid, dependFormUid, guid, guid2, FormDependencyDataType.Direct);
		}
		else
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			FormDependencyDataType type = FormDependencyDataType.DirectInherit;
			CS_0024_003C_003E8__locals0.keyUid = ((guid != Guid.Empty) ? guid : metadataUid);
			IFormDependencyExtension formDependencyExtension = ComponentManager.Current.GetExtensionPoints<IFormDependencyExtension>().FirstOrDefault((IFormDependencyExtension q) => q.CheckType(CS_0024_003C_003E8__locals0.keyUid));
			IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
			IMetadata metadata = null;
			if (serviceNotNull.GetTypeByUidOrNull(CS_0024_003C_003E8__locals0.keyUid, loadImplementation: false) != null)
			{
				metadata = serviceNotNull.GetMetadata(CS_0024_003C_003E8__locals0.keyUid, loadImplementation: false);
			}
			if (metadata != null && metadata is ClassMetadata && viewType.HasValue)
			{
				type = FormDependencyDataType.DefaultInherit;
				guid2 = ViewTypeToGuid(viewType.Value);
				formDependencyData = new FormDependencyData(metadataUid, dependFormUid, CS_0024_003C_003E8__locals0.keyUid, guid2, FormDependencyDataType.Default);
			}
			if (formDependencyExtension != null)
			{
				deps.AddRange((metadata != null) ? formDependencyExtension.GetDependenciesForBaseClasses(metadataUid, dependFormUid, metadata, guid2, type) : formDependencyExtension.GetDependenciesForBaseClasses(metadataUid, dependFormUid, CS_0024_003C_003E8__locals0.keyUid, guid2, type));
			}
			if (formDependencyData == null)
			{
				formDependencyData = new FormDependencyData(metadataUid, dependFormUid, CS_0024_003C_003E8__locals0.keyUid, guid2, FormDependencyDataType.Direct);
			}
		}
		deps.Add(formDependencyData);
	}

	internal static IEnumerable<IFormDependencyData> Load(Guid objectUid, string columnName)
	{
		List<IFormDependencyData> list = new List<IFormDependencyData>();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459402685), serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606767026)), serviceNotNull.Dialect.QuoteIfNeeded(columnName), serviceNotNull.ParameterSeparator);
		using IDataReader dataReader = serviceNotNull.ExecuteQuery(sql, new Dictionary<string, object> { 
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675333623),
			objectUid
		} });
		while (dataReader.Read())
		{
			if (!(dataReader[0] is DBNull))
			{
				list.Add(new FormDependencyData(serviceNotNull.Dialect.GetGuid(dataReader[0]), serviceNotNull.Dialect.GetGuid(dataReader[1]), serviceNotNull.Dialect.GetGuid(dataReader[2]), serviceNotNull.Dialect.GetGuid(dataReader[3]), (FormDependencyDataType)Convert.ToInt64(dataReader[4])));
			}
		}
		return list;
	}

	internal static IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid objectUid)
	{
		return Load(objectUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C16BC));
	}

	internal static IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid objectUid)
	{
		return Load(objectUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852982330));
	}

	public static void Update(Guid dependObjectUid, params IFormDependencyData[] data)
	{
		//Discarded unreachable code: IL_00a1, IL_03cb, IL_03da, IL_0423, IL_0432
		int num = 12;
		DataRow dataRow = default(DataRow);
		DataTable dataTable = default(DataTable);
		int num3 = default(int);
		IFormDependencyData formDependencyData = default(IFormDependencyData);
		IFormDependencyData[] array = default(IFormDependencyData[]);
		Func<string, Type, DataColumn> func2 = default(Func<string, Type, DataColumn>);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string sql = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Func<string, Type, DataColumn> func;
				switch (num2)
				{
				case 13:
					return;
				case 4:
					dataRow = (DataRow)mY611lhYznjStpMOsEdd(dataTable);
					num2 = 9;
					continue;
				case 16:
					num3++;
					num = 3;
					break;
				case 20:
					formDependencyData = array[num3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 4;
					}
					continue;
				case 23:
					num3 = 0;
					num2 = 18;
					continue;
				case 2:
					tpXVGkhYc98tdrrhQRd7(YIklbDhYUH0hNNyBuYq0(dataTable), new DataColumn[5]
					{
						func2((string)XIOW7ehYgr8iUVCENo0T(0x3630F361 ^ 0x3632BA17), iTBEXahYshZJrfHgCi3y(typeof(Guid).TypeHandle)),
						func2((string)XIOW7ehYgr8iUVCENo0T(0x2A7797B7 ^ 0x2A75DE2F), iTBEXahYshZJrfHgCi3y(typeof(Guid).TypeHandle)),
						func2((string)XIOW7ehYgr8iUVCENo0T(0x4A1640F ^ 0x4A32DCD), iTBEXahYshZJrfHgCi3y(typeof(Guid).TypeHandle)),
						func2((string)XIOW7ehYgr8iUVCENo0T(-1638402543 ^ -1638547471), iTBEXahYshZJrfHgCi3y(typeof(Guid).TypeHandle)),
						func2((string)XIOW7ehYgr8iUVCENo0T(0x1ECE530A ^ 0x1ECE6BEC), iTBEXahYshZJrfHgCi3y(typeof(long).TypeHandle))
					});
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 26;
					}
					continue;
				case 7:
					FCTti7hLFqeEBlL4lKvC(dataRow, XIOW7ehYgr8iUVCENo0T(-542721635 ^ -542838779), NDJqy9hLBZpvBGbLCU6L(formDependencyData));
					num2 = 25;
					continue;
				case 12:
					if (!(dependObjectUid == Guid.Empty))
					{
						num2 = 11;
						continue;
					}
					return;
				case 24:
					dataRow[(string)XIOW7ehYgr8iUVCENo0T(0x5F3078B6 ^ 0x5F304050)] = formDependencyData.Type;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				case 11:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 15;
					}
					continue;
				case 5:
					if (data != null)
					{
						num2 = 10;
						continue;
					}
					return;
				case 25:
					dataRow[(string)XIOW7ehYgr8iUVCENo0T(-475857671 ^ -476007109)] = QkJy4vhLWySUFS8WNdPW(formDependencyData);
					num2 = 22;
					continue;
				case 22:
					FCTti7hLFqeEBlL4lKvC(dataRow, XIOW7ehYgr8iUVCENo0T(-218496594 ^ -218609586), pVCE68hLo3qjy2Bb0Xfb(formDependencyData));
					num2 = 24;
					continue;
				case 15:
					sql = (string)qKsNVehYLwLgt2LE3iQo(XIOW7ehYgr8iUVCENo0T(-561074844 ^ -561181016), ucDlYshY5jZfhY0xT3ap(serviceNotNull.Dialect, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC0F81F)), ucDlYshY5jZfhY0xT3ap(baPuIhhYj6uGQL87fx5q(serviceNotNull), XIOW7ehYgr8iUVCENo0T(0xD3DEF7E ^ 0xD3FA608)), UcrOiHhYYndrEx4AQvpA(serviceNotNull));
					num2 = 14;
					continue;
				case 3:
				case 18:
					if (num3 >= array.Length)
					{
						num2 = 17;
						continue;
					}
					goto case 20;
				case 17:
					serviceNotNull.BulkInsert((string)XIOW7ehYgr8iUVCENo0T(0x4D1C1EE4 ^ 0x4D1E57B6), dataTable, shouldGenerateId: false);
					num2 = 13;
					continue;
				case 21:
					dataTable = new DataTable();
					num = 2;
					break;
				case 26:
					array = data;
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 13;
					}
					continue;
				case 1:
					((DataRowCollection)M0imSihLb88YhRC9ymlL(dataTable)).Add(dataRow);
					num2 = 16;
					continue;
				case 10:
					if (data.Length != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 14:
					serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object> { 
					{
						(string)XIOW7ehYgr8iUVCENo0T(0x34A6D230 ^ 0x34A57186),
						dependObjectUid
					} });
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					FCTti7hLFqeEBlL4lKvC(dataRow, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76F9DF8), dependObjectUid);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					return;
				default:
					func = _003C_003Ec._003C_003E9__12_0;
					if (func != null)
					{
						goto IL_0507;
					}
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 19;
					}
					continue;
				case 19:
					{
						func = (_003C_003Ec._003C_003E9__12_0 = delegate(string columnName, Type dataType)
						{
							DataColumn dataColumn = new DataColumn();
							_003C_003Ec.f7VaBcvyofxAVsv3iYDf(dataColumn, dataType);
							dataColumn.ColumnName = columnName;
							_003C_003Ec.MITgkovyb1hLfBsrRPyy(dataColumn, columnName);
							_003C_003Ec.yCDyWwvyheagCyMlEhuQ(dataColumn, false);
							_003C_003Ec.QhmcUDvyGxJ5eRyd2G9r(dataColumn, false);
							dataColumn.AutoIncrement = false;
							_003C_003Ec.DxbuPRvyEv07mmllggvY(dataColumn, false);
							return dataColumn;
						});
						goto IL_0507;
					}
					IL_0507:
					func2 = func;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 21;
					}
					continue;
				}
				break;
			}
		}
	}

	public static IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		List<IFormDependencyData> list = new List<IFormDependencyData>();
		CS_0024_003C_003E8__locals0.transform = Locator.GetServiceNotNull<ITransformationProvider>();
		CS_0024_003C_003E8__locals0.n = 0;
		Dictionary<string, object> dictionary = baseUids.ToDictionary((Func<Guid, string>)((Guid k) => (string)_003C_003Ec__DisplayClass13_0.WBV36TvyVaUEeeiEGkXD(_003C_003Ec__DisplayClass13_0.hgMTKqvyIacTWjppAlil(-1837662597 ^ -1837979633), CS_0024_003C_003E8__locals0.n++)), (Func<Guid, object>)((Guid v) => v));
		string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538608630), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE10609D)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978468663)), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA523E), dictionary.Keys.Select((string k) => (string)_003C_003Ec__DisplayClass13_0.kR15lOvyiklMGyNe7umR(_003C_003Ec__DisplayClass13_0.ncodJBvySuK0R3GMKxGU(CS_0024_003C_003E8__locals0.transform), k))), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488867027)));
		using IDataReader dataReader = CS_0024_003C_003E8__locals0.transform.ExecuteQuery(sql, dictionary);
		while (dataReader.Read())
		{
			list.Add(new FormDependencyData(CS_0024_003C_003E8__locals0.transform.Dialect.GetGuid(dataReader[0]), CS_0024_003C_003E8__locals0.transform.Dialect.GetGuid(dataReader[1]), CS_0024_003C_003E8__locals0.transform.Dialect.GetGuid(dataReader[2]), CS_0024_003C_003E8__locals0.transform.Dialect.GetGuid(dataReader[3]), (FormDependencyDataType)(long)dataReader[4]));
		}
		return list;
	}

	public static bool ExistFakeDependencies(Guid usesObjectUid)
	{
		int num = 3;
		int num2 = num;
		string sql = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string query = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sql = serviceNotNull.Count(query);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				query = (string)E3yggghLhnYTgwO3gOLF(XIOW7ehYgr8iUVCENo0T(0x8317432 ^ 0x832D0A0), new object[7]
				{
					UcrOiHhYYndrEx4AQvpA(serviceNotNull),
					((Dialect)baPuIhhYj6uGQL87fx5q(serviceNotNull)).QuoteIfNeeded((string)XIOW7ehYgr8iUVCENo0T(-16752921 ^ -16640075)),
					serviceNotNull.Dialect.QuoteIfNeeded((string)XIOW7ehYgr8iUVCENo0T(0x17ADCCD8 ^ 0x17AF85AE)),
					ucDlYshY5jZfhY0xT3ap(baPuIhhYj6uGQL87fx5q(serviceNotNull), XIOW7ehYgr8iUVCENo0T(-1217523399 ^ -1217636191)),
					ucDlYshY5jZfhY0xT3ap(serviceNotNull.Dialect, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317645008)),
					ucDlYshY5jZfhY0xT3ap(baPuIhhYj6uGQL87fx5q(serviceNotNull), XIOW7ehYgr8iUVCENo0T(-97972138 ^ -97965904)),
					ucDlYshY5jZfhY0xT3ap(serviceNotNull.Dialect, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A32DCD))
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return Convert.ToInt64(serviceNotNull.ExecuteScalar(sql, new Dictionary<string, object> { 
				{
					(string)XIOW7ehYgr8iUVCENo0T(-218496594 ^ -218521064),
					usesObjectUid
				} })) != 0;
			}
		}
	}

	static FormDependencyHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				EditFormUid = new Guid((string)XIOW7ehYgr8iUVCENo0T(-1876063057 ^ -1876023011));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				NaoPs8hLGF7qtveBvl5v();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 4:
				CreateFormUid = new Guid((string)XIOW7ehYgr8iUVCENo0T(0x269E5FCA ^ 0x269DFA34));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				DisplayFormUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D467E));
				num2 = 5;
				break;
			default:
				KeySplitter = (string)XIOW7ehYgr8iUVCENo0T(0x4785BC0D ^ 0x4785B077);
				num2 = 3;
				break;
			}
		}
	}

	internal static bool Pb7HYJhYdDxM3YxSNoZD()
	{
		return pamK8whY96cW9Dxr5ldj == null;
	}

	internal static FormDependencyHelper XSVfcIhYlo1m5fCJA0fm()
	{
		return pamK8whY96cW9Dxr5ldj;
	}

	internal static bool EX1AWwhYr3D4CvhBuFLE(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object XIOW7ehYgr8iUVCENo0T(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ucDlYshY5jZfhY0xT3ap(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object baPuIhhYj6uGQL87fx5q(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object UcrOiHhYYndrEx4AQvpA(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object qKsNVehYLwLgt2LE3iQo(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object YIklbDhYUH0hNNyBuYq0(object P_0)
	{
		return ((DataTable)P_0).Columns;
	}

	internal static Type iTBEXahYshZJrfHgCi3y(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void tpXVGkhYc98tdrrhQRd7(object P_0, object P_1)
	{
		((DataColumnCollection)P_0).AddRange((DataColumn[])P_1);
	}

	internal static object mY611lhYznjStpMOsEdd(object P_0)
	{
		return ((DataTable)P_0).NewRow();
	}

	internal static void FCTti7hLFqeEBlL4lKvC(object P_0, object P_1, object P_2)
	{
		((DataRow)P_0)[(string)P_1] = P_2;
	}

	internal static Guid NDJqy9hLBZpvBGbLCU6L(object P_0)
	{
		return ((IFormDependencyData)P_0).DependObjectFormUid;
	}

	internal static Guid QkJy4vhLWySUFS8WNdPW(object P_0)
	{
		return ((IFormDependencyData)P_0).UsesObjectUid;
	}

	internal static Guid pVCE68hLo3qjy2Bb0Xfb(object P_0)
	{
		return ((IFormDependencyData)P_0).UsesObjectFormUid;
	}

	internal static object M0imSihLb88YhRC9ymlL(object P_0)
	{
		return ((DataTable)P_0).Rows;
	}

	internal static object E3yggghLhnYTgwO3gOLF(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void NaoPs8hLGF7qtveBvl5v()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

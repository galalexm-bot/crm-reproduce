// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.FormDependencyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class FormDependencyHelper
  {
    internal static readonly Guid DisplayFormUid;
    internal static readonly Guid EditFormUid;
    internal static readonly Guid CreateFormUid;
    internal static readonly string KeySplitter;
    internal static FormDependencyHelper pamK8whY96cW9Dxr5ldj;

    internal static Guid ViewTypeToGuid(ViewType viewType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            switch (viewType)
            {
              case ViewType.Create:
                goto label_2;
              case ViewType.Edit:
                goto label_3;
              case ViewType.Create | ViewType.Edit:
                goto label_5;
              case ViewType.Display:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return FormDependencyHelper.CreateFormUid;
label_3:
      return FormDependencyHelper.EditFormUid;
label_4:
      return FormDependencyHelper.DisplayFormUid;
label_5:
      return Guid.Empty;
    }

    internal static ViewType GuidToViewType(Guid uid)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (!FormDependencyHelper.EX1AWwhYr3D4CvhBuFLE(uid, FormDependencyHelper.DisplayFormUid))
            {
              if (!FormDependencyHelper.EX1AWwhYr3D4CvhBuFLE(uid, FormDependencyHelper.EditFormUid))
              {
                if (FormDependencyHelper.EX1AWwhYr3D4CvhBuFLE(uid, FormDependencyHelper.CreateFormUid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              }
              else
              {
                num = 3;
                continue;
              }
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            }
          case 3:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return ViewType.Create;
label_3:
      return ViewType.All;
label_4:
      return ViewType.Edit;
label_7:
      return ViewType.Display;
    }

    public static IEnumerable<IFormDependencyData> GenerateFormDependencies(
      Guid metadataUid,
      FormViewItem form)
    {
      return FormDependencyHelper.GenerateFormDependencies(metadataUid, form, new Guid?());
    }

    public static IEnumerable<IFormDependencyData> GenerateFormDependencies(
      Guid metadataUid,
      FormViewItem form,
      Guid? formUid)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IEnumerable<ButtonViewItem> enumeration = form.GetAllItems().OfType<ButtonViewItem>().Where<ButtonViewItem>((System.Func<ButtonViewItem, bool>) (q => FormDependencyHelper.\u003C\u003Ec.MppsW7vyWXhamHAhuVXV(FormDependencyHelper.\u003C\u003Ec.DfkjpevyF31q5iJxMwnQ((object) q), FormDependencyHelper.\u003C\u003Ec.B2HhujvyBERJLINGuTQu(1253244298 - 1829393894 ^ -576043388))));
      List<IFormDependencyData> deps = new List<IFormDependencyData>();
      Action<ButtonViewItem> action = (Action<ButtonViewItem>) (q =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              // ISSUE: reference to a compiler-generated method
              FormDependencyHelper.GenerateFormDependencies((string) FormDependencyHelper.\u003C\u003Ec__DisplayClass7_0.wOGbjbvmLrmL9EtYbnR8((object) q), metadataUid, !formUid.HasValue ? form.Uid : formUid.Value, deps);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      });
      enumeration.ForEach<ButtonViewItem>(action);
      return (IEnumerable<IFormDependencyData>) deps;
    }

    internal static void GenerateFormDependencies(
      string actionId,
      Guid metadataUid,
      Guid dependFormUid,
      List<IFormDependencyData> deps)
    {
      string[] strArray = actionId.Split(new string[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323195314)
      }, StringSplitOptions.None);
      Guid usesObjectUid = Guid.Parse(strArray[0]);
      Guid guid = Guid.Parse(strArray[1]);
      if (guid == dependFormUid)
        return;
      ViewType? nullable = new ViewType?();
      ViewType result;
      if (Enum.TryParse<ViewType>(strArray[2], out result))
        nullable = new ViewType?(result);
      FormDependencyData formDependencyData = (FormDependencyData) null;
      if (usesObjectUid == PageMetadata.TypeUid)
      {
        formDependencyData = new FormDependencyData(metadataUid, dependFormUid, usesObjectUid, guid, FormDependencyDataType.Direct);
      }
      else
      {
        FormDependencyDataType type = FormDependencyDataType.DirectInherit;
        Guid keyUid = usesObjectUid != Guid.Empty ? usesObjectUid : metadataUid;
        IFormDependencyExtension dependencyExtension = ComponentManager.Current.GetExtensionPoints<IFormDependencyExtension>().FirstOrDefault<IFormDependencyExtension>((System.Func<IFormDependencyExtension, bool>) (q => q.CheckType(keyUid)));
        IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
        IMetadata usesObjectMetadata = (IMetadata) null;
        if (serviceNotNull.GetTypeByUidOrNull(keyUid, false) != (Type) null)
          usesObjectMetadata = serviceNotNull.GetMetadata(keyUid, false);
        if (usesObjectMetadata != null && usesObjectMetadata is ClassMetadata && nullable.HasValue)
        {
          type = FormDependencyDataType.DefaultInherit;
          guid = FormDependencyHelper.ViewTypeToGuid(nullable.Value);
          formDependencyData = new FormDependencyData(metadataUid, dependFormUid, keyUid, guid, FormDependencyDataType.Default);
        }
        if (dependencyExtension != null)
          deps.AddRange(usesObjectMetadata != null ? dependencyExtension.GetDependenciesForBaseClasses(metadataUid, dependFormUid, usesObjectMetadata, guid, type) : dependencyExtension.GetDependenciesForBaseClasses(metadataUid, dependFormUid, keyUid, guid, type));
        if (formDependencyData == null)
          formDependencyData = new FormDependencyData(metadataUid, dependFormUid, keyUid, guid, FormDependencyDataType.Direct);
      }
      deps.Add((IFormDependencyData) formDependencyData);
    }

    /// <summary>Загрузить зависимости форм по уиду объекта</summary>
    /// <remarks>
    /// Для процессов - уид самого процесса
    /// Для объектов - уид метаданных
    /// Для страниц и портлетов - уид метаданных старниц и портлетов
    /// </remarks>
    /// <returns></returns>
    internal static IEnumerable<IFormDependencyData> Load(Guid objectUid, string columnName)
    {
      List<IFormDependencyData> formDependencyDataList = new List<IFormDependencyData>();
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      string str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459402685), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606767026)), (object) serviceNotNull.Dialect.QuoteIfNeeded(columnName), (object) serviceNotNull.ParameterSeparator);
      ITransformationProvider transformationProvider = serviceNotNull;
      string sql = str;
      using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql, new Dictionary<string, object>()
      {
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675333623),
          (object) objectUid
        }
      }))
      {
        while (dataReader.Read())
        {
          if (!(dataReader[0] is DBNull))
            formDependencyDataList.Add((IFormDependencyData) new FormDependencyData(serviceNotNull.Dialect.GetGuid(dataReader[0]), serviceNotNull.Dialect.GetGuid(dataReader[1]), serviceNotNull.Dialect.GetGuid(dataReader[2]), serviceNotNull.Dialect.GetGuid(dataReader[3]), (FormDependencyDataType) Convert.ToInt64(dataReader[4])));
        }
      }
      return (IEnumerable<IFormDependencyData>) formDependencyDataList;
    }

    internal static IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid objectUid) => FormDependencyHelper.Load(objectUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647763644));

    internal static IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid objectUid) => FormDependencyHelper.Load(objectUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852982330));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dependObjectUid"></param>
    /// <param name="data"></param>
    public static void Update(Guid dependObjectUid, params IFormDependencyData[] data)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        DataTable data1;
        int index;
        while (true)
        {
          DataRow row;
          IFormDependencyData[] formDependencyDataArray;
          IFormDependencyData formDependencyData;
          Func<string, Type, DataColumn> func1;
          ITransformationProvider serviceNotNull;
          string sql;
          Func<string, Type, DataColumn> func2;
          switch (num2)
          {
            case 1:
              ((DataRowCollection) FormDependencyHelper.M0imSihLb88YhRC9ymlL((object) data1)).Add(row);
              num2 = 16;
              continue;
            case 2:
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              FormDependencyHelper.tpXVGkhYc98tdrrhQRd7(FormDependencyHelper.YIklbDhYUH0hNNyBuYq0((object) data1), (object) new DataColumn[5]
              {
                func1((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(572119659 - -337058038 ^ 909294103), FormDependencyHelper.iTBEXahYshZJrfHgCi3y(__typeref (Guid))),
                func1((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(712480695 ^ 712367663), FormDependencyHelper.iTBEXahYshZJrfHgCi3y(__typeref (Guid))),
                func1((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(1242972401 >> 4 ^ 77802957), FormDependencyHelper.iTBEXahYshZJrfHgCi3y(__typeref (Guid))),
                func1((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-1638402543 ^ -1638547471), FormDependencyHelper.iTBEXahYshZJrfHgCi3y(__typeref (Guid))),
                func1((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(516838154 ^ 516844524), FormDependencyHelper.iTBEXahYshZJrfHgCi3y(__typeref (long)))
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 21 : 26;
              continue;
            case 3:
            case 18:
              if (index >= formDependencyDataArray.Length)
              {
                num2 = 17;
                continue;
              }
              goto case 20;
            case 4:
              row = (DataRow) FormDependencyHelper.mY611lhYznjStpMOsEdd((object) data1);
              num2 = 9;
              continue;
            case 5:
              if (data != null)
              {
                num2 = 10;
                continue;
              }
              goto label_26;
            case 6:
              goto label_3;
            case 7:
              FormDependencyHelper.FCTti7hLFqeEBlL4lKvC((object) row, FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-542721635 ^ -542838779), (object) FormDependencyHelper.NDJqy9hLBZpvBGbLCU6L((object) formDependencyData));
              num2 = 25;
              continue;
            case 8:
              goto label_14;
            case 9:
              FormDependencyHelper.FCTti7hLFqeEBlL4lKvC((object) row, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124755448), (object) dependObjectUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 7;
              continue;
            case 10:
              if (data.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 11:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 13 : 15;
              continue;
            case 12:
              if (!(dependObjectUid == Guid.Empty))
              {
                num2 = 11;
                continue;
              }
              goto label_30;
            case 13:
              goto label_34;
            case 14:
              serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>()
              {
                {
                  (string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-2092274397 << 4 ^ 883257734),
                  (object) dependObjectUid
                }
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 5;
              continue;
            case 15:
              sql = (string) FormDependencyHelper.qKsNVehYLwLgt2LE3iQo(FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(2045296739 + 1688595713 ^ -561181016), FormDependencyHelper.ucDlYshY5jZfhY0xT3ap((object) serviceNotNull.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304492063)), FormDependencyHelper.ucDlYshY5jZfhY0xT3ap(FormDependencyHelper.baPuIhhYj6uGQL87fx5q((object) serviceNotNull), FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(222162814 ^ 222275080)), FormDependencyHelper.UcrOiHhYYndrEx4AQvpA((object) serviceNotNull));
              num2 = 14;
              continue;
            case 16:
              goto label_6;
            case 17:
              serviceNotNull.BulkInsert((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(323422137 << 2 ^ 1293834166), data1, false);
              num2 = 13;
              continue;
            case 19:
              // ISSUE: reference to a compiler-generated field
              func2 = FormDependencyHelper.\u003C\u003Ec.\u003C\u003E9__12_0 = (Func<string, Type, DataColumn>) ((columnName, dataType) =>
              {
                DataColumn dataColumn = new DataColumn();
                // ISSUE: reference to a compiler-generated method
                FormDependencyHelper.\u003C\u003Ec.f7VaBcvyofxAVsv3iYDf((object) dataColumn, dataType);
                dataColumn.ColumnName = columnName;
                // ISSUE: reference to a compiler-generated method
                FormDependencyHelper.\u003C\u003Ec.MITgkovyb1hLfBsrRPyy((object) dataColumn, (object) columnName);
                // ISSUE: reference to a compiler-generated method
                FormDependencyHelper.\u003C\u003Ec.yCDyWwvyheagCyMlEhuQ((object) dataColumn, false);
                // ISSUE: reference to a compiler-generated method
                FormDependencyHelper.\u003C\u003Ec.QhmcUDvyGxJ5eRyd2G9r((object) dataColumn, false);
                dataColumn.AutoIncrement = false;
                // ISSUE: reference to a compiler-generated method
                FormDependencyHelper.\u003C\u003Ec.DxbuPRvyEv07mmllggvY((object) dataColumn, false);
                return dataColumn;
              });
              break;
            case 20:
              formDependencyData = formDependencyDataArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 4;
              continue;
            case 21:
              goto label_24;
            case 22:
              FormDependencyHelper.FCTti7hLFqeEBlL4lKvC((object) row, FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-218496594 ^ -218609586), (object) FormDependencyHelper.pVCE68hLo3qjy2Bb0Xfb((object) formDependencyData));
              num2 = 24;
              continue;
            case 23:
              index = 0;
              num2 = 18;
              continue;
            case 24:
              row[(string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(1597012150 ^ 1596997712)] = (object) formDependencyData.Type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              continue;
            case 25:
              row[(string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(1505778440 - 1981636111 ^ -476007109)] = (object) FormDependencyHelper.QkJy4vhLWySUFS8WNdPW((object) formDependencyData);
              num2 = 22;
              continue;
            case 26:
              formDependencyDataArray = data;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 23 : 13;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              func2 = FormDependencyHelper.\u003C\u003Ec.\u003C\u003E9__12_0;
              if (func2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 17 : 19;
                continue;
              }
              break;
          }
          func1 = func2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 21;
        }
label_6:
        ++index;
        num1 = 3;
        continue;
label_24:
        data1 = new DataTable();
        num1 = 2;
      }
label_3:
      return;
label_14:
      return;
label_34:
      return;
label_30:
      return;
label_26:
      return;
label_5:;
    }

    public static IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids)
    {
      List<IFormDependencyData> formDependencyDataList = new List<IFormDependencyData>();
      ITransformationProvider transform = Locator.GetServiceNotNull<ITransformationProvider>();
      int n = 0;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, object> dictionary = baseUids.ToDictionary<Guid, string, object>((System.Func<Guid, string>) (k => (string) FormDependencyHelper.\u003C\u003Ec__DisplayClass13_0.WBV36TvyVaUEeeiEGkXD(FormDependencyHelper.\u003C\u003Ec__DisplayClass13_0.hgMTKqvyIacTWjppAlil(-1837662597 ^ -1837979633), (object) n++)), (System.Func<Guid, object>) (v => (object) v));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538608630), (object) transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235954333)), (object) transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978468663)), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408913982), dictionary.Keys.Select<string, string>((System.Func<string, string>) (k => (string) FormDependencyHelper.\u003C\u003Ec__DisplayClass13_0.kR15lOvyiklMGyNe7umR(FormDependencyHelper.\u003C\u003Ec__DisplayClass13_0.ncodJBvySuK0R3GMKxGU((object) transform), (object) k)))), (object) transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488867027)));
      using (IDataReader dataReader = transform.ExecuteQuery(sql, dictionary))
      {
        while (dataReader.Read())
          formDependencyDataList.Add((IFormDependencyData) new FormDependencyData(transform.Dialect.GetGuid(dataReader[0]), transform.Dialect.GetGuid(dataReader[1]), transform.Dialect.GetGuid(dataReader[2]), transform.Dialect.GetGuid(dataReader[3]), (FormDependencyDataType) (long) dataReader[4]));
      }
      return (IEnumerable<IFormDependencyData>) formDependencyDataList;
    }

    public static bool ExistFakeDependencies(Guid usesObjectUid)
    {
      int num = 3;
      ITransformationProvider serviceNotNull;
      string query;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            sql = serviceNotNull.Count(query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            query = (string) FormDependencyHelper.E3yggghLhnYTgwO3gOLF(FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-1204263869 ^ -1341583247 ^ 137547936), (object) new object[7]
            {
              FormDependencyHelper.UcrOiHhYYndrEx4AQvpA((object) serviceNotNull),
              (object) ((Dialect) FormDependencyHelper.baPuIhhYj6uGQL87fx5q((object) serviceNotNull)).QuoteIfNeeded((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-16752921 ^ -16640075)),
              (object) serviceNotNull.Dialect.QuoteIfNeeded((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(~-397266137 ^ 397378990)),
              FormDependencyHelper.ucDlYshY5jZfhY0xT3ap(FormDependencyHelper.baPuIhhYj6uGQL87fx5q((object) serviceNotNull), FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-1217523399 ^ -1217636191)),
              FormDependencyHelper.ucDlYshY5jZfhY0xT3ap((object) serviceNotNull.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317645008)),
              FormDependencyHelper.ucDlYshY5jZfhY0xT3ap(FormDependencyHelper.baPuIhhYj6uGQL87fx5q((object) serviceNotNull), FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-97972138 ^ -97965904)),
              FormDependencyHelper.ucDlYshY5jZfhY0xT3ap((object) serviceNotNull.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77802957))
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
            continue;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return Convert.ToInt64(serviceNotNull.ExecuteScalar(sql, new Dictionary<string, object>()
      {
        {
          (string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-218496594 ^ -218521064),
          (object) usesObjectUid
        }
      })) != 0L;
    }

    static FormDependencyHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormDependencyHelper.DisplayFormUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082293374));
            num = 5;
            continue;
          case 2:
            FormDependencyHelper.NaoPs8hLGF7qtveBvl5v();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            FormDependencyHelper.CreateFormUid = new Guid((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(647913418 ^ 647887412));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 5:
            FormDependencyHelper.EditFormUid = new Guid((string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(-1876063057 ^ -1876023011));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 0;
            continue;
          default:
            FormDependencyHelper.KeySplitter = (string) FormDependencyHelper.XIOW7ehYgr8iUVCENo0T(1199946765 ^ 1199943799);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool Pb7HYJhYdDxM3YxSNoZD() => FormDependencyHelper.pamK8whY96cW9Dxr5ldj == null;

    internal static FormDependencyHelper XSVfcIhYlo1m5fCJA0fm() => FormDependencyHelper.pamK8whY96cW9Dxr5ldj;

    internal static bool EX1AWwhYr3D4CvhBuFLE([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object XIOW7ehYgr8iUVCENo0T(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ucDlYshY5jZfhY0xT3ap([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object baPuIhhYj6uGQL87fx5q([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object UcrOiHhYYndrEx4AQvpA([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object qKsNVehYLwLgt2LE3iQo(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object YIklbDhYUH0hNNyBuYq0([In] object obj0) => (object) ((DataTable) obj0).Columns;

    internal static Type iTBEXahYshZJrfHgCi3y([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void tpXVGkhYc98tdrrhQRd7([In] object obj0, [In] object obj1) => ((DataColumnCollection) obj0).AddRange((DataColumn[]) obj1);

    internal static object mY611lhYznjStpMOsEdd([In] object obj0) => (object) ((DataTable) obj0).NewRow();

    internal static void FCTti7hLFqeEBlL4lKvC([In] object obj0, [In] object obj1, [In] object obj2) => ((DataRow) obj0)[(string) obj1] = obj2;

    internal static Guid NDJqy9hLBZpvBGbLCU6L([In] object obj0) => ((IFormDependencyData) obj0).DependObjectFormUid;

    internal static Guid QkJy4vhLWySUFS8WNdPW([In] object obj0) => ((IFormDependencyData) obj0).UsesObjectUid;

    internal static Guid pVCE68hLo3qjy2Bb0Xfb([In] object obj0) => ((IFormDependencyData) obj0).UsesObjectFormUid;

    internal static object M0imSihLb88YhRC9ymlL([In] object obj0) => (object) ((DataTable) obj0).Rows;

    internal static object E3yggghLhnYTgwO3gOLF([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void NaoPs8hLGF7qtveBvl5v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

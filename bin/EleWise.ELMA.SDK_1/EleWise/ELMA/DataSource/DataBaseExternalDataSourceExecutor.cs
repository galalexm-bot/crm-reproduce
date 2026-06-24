// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DataSource.DataBaseExternalDataSourceExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Nodes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.DataSource
{
  /// <summary>Executor внешнего источника типа DB</summary>
  public abstract class DataBaseExternalDataSourceExecutor : IExternalDataSourceExecutor, IDisposable
  {
    /// <summary>Разделители</summary>
    private readonly char[] separators;
    private static DataBaseExternalDataSourceExecutor nxGU48OEISWacNnL6eE;

    /// <summary>Имя исполнителя</summary>
    protected abstract string Name { get; }

    /// <summary>
    /// SQL-запрос для извлечения стурктуры внешнего источника типа DB
    /// </summary>
    /// <returns>Запрос должен вернуть пары вида TableName-ColumnName</returns>
    protected abstract string RetrieveSchemaQuery { get; }

    /// <summary>Провайдер преобразования БД</summary>
    protected ITransformationProviderBase TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    protected DataBaseExternalDataSourceExecutor()
    {
      DataBaseExternalDataSourceExecutor.YOAO5TOCT7drGKiWN3h();
      char[] chArray = new char[14];
      // ISSUE: field reference
      DataBaseExternalDataSourceExecutor.r7Z5rPOvs2QNmBA7ynJ((object) chArray, __fieldref (\u003CPrivateImplementationDetails\u003E.F0804A1842FB966486609F4D0FDB27C717566DD3));
      this.separators = chArray;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected DataBaseExternalDataSourceExecutor(ITransformationProviderBase transformationProvider)
    {
      DataBaseExternalDataSourceExecutor.YOAO5TOCT7drGKiWN3h();
      char[] chArray = new char[14];
      // ISSUE: field reference
      DataBaseExternalDataSourceExecutor.r7Z5rPOvs2QNmBA7ynJ((object) chArray, __fieldref (\u003CPrivateImplementationDetails\u003E.F0804A1842FB966486609F4D0FDB27C717566DD3));
      this.separators = chArray;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.TransformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Получить используемые параметры из запроса</summary>
    /// <param name="query">Запрос</param>
    /// <returns></returns>
    protected IEnumerable<string> GetUsedParam(string query)
    {
      string[] source = !string.IsNullOrWhiteSpace(query) ? query.Split(this.separators, StringSplitOptions.RemoveEmptyEntries) : throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210698257)));
      ITransformationProvider transformationProvider = this.TransformationProvider as ITransformationProvider;
      ExternalTransformationProvider transformationProviderExternal = this.TransformationProvider as ExternalTransformationProvider;
      if (transformationProvider == null && transformationProviderExternal == null)
        throw new NotImplementedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137435222));
      System.Func<string, bool> predicate = (System.Func<string, bool>) (s =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (DataBaseExternalDataSourceExecutor.\u003C\u003Ec__DisplayClass11_0.Jr7v1If0UTPbxXrLh4bC((object) s, (object) this.TransformationProvider.ParameterSeparator))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return DataBaseExternalDataSourceExecutor.\u003C\u003Ec__DisplayClass11_0.ooFcDgf0sltTjNjM7clO((object) s) > 1;
label_5:
        return false;
      });
      return ((IEnumerable<string>) source).Where<string>(predicate).Select<string, string>((System.Func<string, string>) (queryPart =>
      {
        int num1 = 1;
        object usedParam;
        ExternalTransformationProvider transformationProvider1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ITransformationProvider transformationProvider2 = transformationProvider;
                if (transformationProvider2 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                  continue;
                }
                // ISSUE: reference to a compiler-generated method
                usedParam = DataBaseExternalDataSourceExecutor.\u003C\u003Ec__DisplayClass11_0.cpamWVf0c4RAe6gujp79((object) transformationProvider2.Dialect, (object) queryPart);
                break;
              case 2:
                goto label_4;
              case 3:
                goto label_12;
              default:
                usedParam = (object) null;
                break;
            }
            if (usedParam == null)
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
            else
              goto label_3;
          }
label_4:
          transformationProvider1 = transformationProviderExternal;
          if (transformationProvider1 == null)
            num1 = 3;
          else
            goto label_13;
        }
label_3:
        return (string) usedParam;
label_12:
        return (string) null;
label_13:
        // ISSUE: reference to a compiler-generated method
        return (string) DataBaseExternalDataSourceExecutor.\u003C\u003Ec__DisplayClass11_0.sbp6Nuf0z5pLVQFXykkG((object) transformationProvider1, (object) queryPart);
      })).Distinct<string>();
    }

    /// <summary>Получить обработанные параметры</summary>
    /// <param name="query">Запрос</param>
    /// <param name="paramValues">Параметры запроса</param>
    /// <returns></returns>
    protected virtual Dictionary<string, object> GetPreparedParameters(
      string query,
      Dictionary<string, object> paramValues)
    {
      Dictionary<string, object> preparedParameters = paramValues ?? new Dictionary<string, object>();
      foreach (string key in paramValues == null ? this.GetUsedParam(query) : this.GetUsedParam(query).Where<string>((System.Func<string, bool>) (p => !paramValues.ContainsKey(p))))
        preparedParameters.Add(key, (object) null);
      return preparedParameters;
    }

    public IEnumerable<SchemaNode> LoadSchema()
    {
      Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29232701), (object) this.Name));
      try
      {
        using (IDataReader reader = this.TransformationProvider.ExecuteQuery(this.RetrieveSchemaQuery))
        {
          DataTable source = new DataTable();
          source.Load(reader);
          List<SchemaNode> list = source.AsEnumerable().GroupBy<DataRow, string, string>((System.Func<DataRow, string>) (r => (string) r.ItemArray[0]), (System.Func<DataRow, string>) (r => (string) r.ItemArray[1])).Select<IGrouping<string, string>, SchemaNode>((System.Func<IGrouping<string, string>, SchemaNode>) (g =>
          {
            SchemaNode schemaNode1 = new SchemaNode();
            schemaNode1.Name = g.Key.Trim();
            schemaNode1.AddChilds(g.Select<string, SchemaNode>((System.Func<string, SchemaNode>) (sg =>
            {
              SchemaNode schemaNode2 = new SchemaNode();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              DataBaseExternalDataSourceExecutor.\u003C\u003Ec.dusfd6fmQms0KC3ruIG0((object) schemaNode2, DataBaseExternalDataSourceExecutor.\u003C\u003Ec.DT7Aa4fmfoeyHXOjlyLF((object) sg));
              return schemaNode2;
            })));
            return schemaNode1;
          })).ToList<SchemaNode>();
          Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124631166));
          return (IEnumerable<SchemaNode>) list;
        }
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672114671), (object) this.Name), ex);
        throw new ExternalDataSourceExecutorExecuteException(this.Name, ex);
      }
    }

    public DataTable ExecuteQuery(
      string query,
      Dictionary<string, object> paramValues = null,
      FetchOptions fetchOptions = null,
      int? commandTimeout = null)
    {
      Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824365027), (object) this.Name));
      try
      {
        if (fetchOptions != (FetchOptions) null && !fetchOptions.Equals(FetchOptions.All))
        {
          int num = query.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852858420), StringComparison.OrdinalIgnoreCase);
          query = query.Substring(num + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542714795).Length, query.Length - num - z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61192231).Length);
          query = this.TransformationProvider.SetupFetchOptions(query, fetchOptions);
        }
        Dictionary<string, object> preparedParamValues = this.GetPreparedParameters(query, paramValues);
        this.TransformationProvider.BeginTransaction();
        try
        {
          IDataReader reader = (IDataReader) null;
          if (commandTimeout.HasValue)
            this.TransformationProvider.ExecuteWithTimeout(commandTimeout.Value, (System.Action) (() =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    reader = this.TransformationProvider.ExecuteQuery(query, preparedParamValues);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
          else
            reader = this.TransformationProvider.ExecuteQuery(query, preparedParamValues);
          using (reader)
          {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082377408));
            return dataTable;
          }
        }
        finally
        {
          this.TransformationProvider.RollbackTransaction();
        }
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239553408), (object) this.Name), ex);
        throw new ExternalDataSourceExecutorExecuteException(this.Name, ex);
      }
    }

    public long? Count(string query, Dictionary<string, object> paramValues = null)
    {
      try
      {
        Dictionary<string, object> preparedParameters = this.GetPreparedParameters(query, paramValues);
        return new long?(Convert.ToInt64(this.TransformationProvider.ExecuteScalar(this.TransformationProvider.Count(query), preparedParameters)));
      }
      catch (Exception ex)
      {
        return new long?();
      }
    }

    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataBaseExternalDataSourceExecutor.BwECt4O8ta5hXKAYB6v((object) this.TransformationProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool tGT5bZOfuVNixaokr78() => DataBaseExternalDataSourceExecutor.nxGU48OEISWacNnL6eE == null;

    internal static DataBaseExternalDataSourceExecutor k8IvtxOQ7f9gKGcNeAw() => DataBaseExternalDataSourceExecutor.nxGU48OEISWacNnL6eE;

    internal static void YOAO5TOCT7drGKiWN3h() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void r7Z5rPOvs2QNmBA7ynJ([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static void BwECt4O8ta5hXKAYB6v([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}

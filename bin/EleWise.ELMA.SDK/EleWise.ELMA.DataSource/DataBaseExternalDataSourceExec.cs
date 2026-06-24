using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Nodes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.DataSource;

public abstract class DataBaseExternalDataSourceExecutor : IExternalDataSourceExecutor, IDisposable
{
	private readonly char[] separators;

	private static DataBaseExternalDataSourceExecutor nxGU48OEISWacNnL6eE;

	protected abstract string Name { get; }

	protected abstract string RetrieveSchemaQuery { get; }

	protected ITransformationProviderBase TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected DataBaseExternalDataSourceExecutor()
	{
		//Discarded unreachable code: IL_0047, IL_004c
		YOAO5TOCT7drGKiWN3h();
		char[] array = new char[14];
		r7Z5rPOvs2QNmBA7ynJ(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		separators = array;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected DataBaseExternalDataSourceExecutor(ITransformationProviderBase transformationProvider)
	{
		//Discarded unreachable code: IL_0047, IL_004c
		YOAO5TOCT7drGKiWN3h();
		char[] array = new char[14];
		r7Z5rPOvs2QNmBA7ynJ(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		separators = array;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			TransformationProvider = transformationProvider;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
			{
				num = 1;
			}
		}
	}

	protected IEnumerable<string> GetUsedParam(string query)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (string.IsNullOrWhiteSpace(query))
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210698257)));
		}
		string[] source = query.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		CS_0024_003C_003E8__locals0.transformationProvider = TransformationProvider as ITransformationProvider;
		CS_0024_003C_003E8__locals0.transformationProviderExternal = TransformationProvider as ExternalTransformationProvider;
		if (CS_0024_003C_003E8__locals0.transformationProvider == null && CS_0024_003C_003E8__locals0.transformationProviderExternal == null)
		{
			throw new NotImplementedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8311856));
		}
		return source.Where(delegate(string s)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
					if (!_003C_003Ec__DisplayClass11_0.Jr7v1If0UTPbxXrLh4bC(s, CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.ParameterSeparator))
					{
						return false;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					return _003C_003Ec__DisplayClass11_0.ooFcDgf0sltTjNjM7clO(s) > 1;
				}
			}
		}).Select(delegate(string queryPart)
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 2:
					{
						ExternalTransformationProvider transformationProviderExternal = CS_0024_003C_003E8__locals0.transformationProviderExternal;
						if (transformationProviderExternal != null)
						{
							obj = _003C_003Ec__DisplayClass11_0.sbp6Nuf0z5pLVQFXykkG(transformationProviderExternal, queryPart);
							break;
						}
						goto end_IL_0012;
					}
					case 1:
					{
						ITransformationProvider transformationProvider = CS_0024_003C_003E8__locals0.transformationProvider;
						if (transformationProvider == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num2 = 0;
							}
							continue;
						}
						obj = _003C_003Ec__DisplayClass11_0.cpamWVf0c4RAe6gujp79(transformationProvider.Dialect, queryPart);
						goto IL_007f;
					}
					default:
						obj = null;
						goto IL_007f;
					case 3:
						{
							return null;
						}
						IL_007f:
						if (obj == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					}
					return (string)obj;
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}).Distinct();
	}

	protected virtual Dictionary<string, object> GetPreparedParameters(string query, Dictionary<string, object> paramValues)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.paramValues = paramValues;
		Dictionary<string, object> dictionary = CS_0024_003C_003E8__locals0.paramValues ?? new Dictionary<string, object>();
		foreach (string item in (CS_0024_003C_003E8__locals0.paramValues == null) ? GetUsedParam(query) : (from p in GetUsedParam(query)
			where !CS_0024_003C_003E8__locals0.paramValues.ContainsKey(p)
			select p))
		{
			dictionary.Add(item, null);
		}
		return dictionary;
	}

	public IEnumerable<SchemaNode> LoadSchema()
	{
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29232701), Name));
		try
		{
			using IDataReader reader = TransformationProvider.ExecuteQuery(RetrieveSchemaQuery);
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			List<SchemaNode> result = (from r in dataTable.AsEnumerable()
				group (string)r.ItemArray[1] by (string)r.ItemArray[0]).Select(delegate(IGrouping<string, string> g)
			{
				SchemaNode schemaNode = new SchemaNode();
				schemaNode.Name = g.Key.Trim();
				schemaNode.AddChilds(g.Select(delegate(string sg)
				{
					SchemaNode schemaNode2 = new SchemaNode();
					_003C_003Ec.dusfd6fmQms0KC3ruIG0(schemaNode2, _003C_003Ec.DT7Aa4fmfoeyHXOjlyLF(sg));
					return schemaNode2;
				}));
				return schemaNode;
			}).ToList();
			Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76DB87E));
			return result;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672114671), Name), ex);
			throw new ExternalDataSourceExecutorExecuteException(Name, ex);
		}
	}

	public DataTable ExecuteQuery(string query, Dictionary<string, object> paramValues = null, FetchOptions fetchOptions = null, int? commandTimeout = null)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass14_.query = query;
		Logger.Log.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824365027), Name));
		try
		{
			_003C_003Ec__DisplayClass14_1 _003C_003Ec__DisplayClass14_2 = new _003C_003Ec__DisplayClass14_1();
			_003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass14_;
			if (fetchOptions != null && !fetchOptions.Equals(FetchOptions.All))
			{
				int num = _003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852858420), StringComparison.OrdinalIgnoreCase);
				_003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query = _003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query.Substring(num + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542714795).Length, _003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query.Length - num - z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5B827).Length);
				_003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query = TransformationProvider.SetupFetchOptions(_003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query, fetchOptions);
			}
			_003C_003Ec__DisplayClass14_2.preparedParamValues = GetPreparedParameters(_003C_003Ec__DisplayClass14_2.CS_0024_003C_003E8__locals1.query, paramValues);
			TransformationProvider.BeginTransaction();
			try
			{
				_003C_003Ec__DisplayClass14_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_2();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass14_2;
				CS_0024_003C_003E8__locals0.reader = null;
				if (commandTimeout.HasValue)
				{
					TransformationProvider.ExecuteWithTimeout(commandTimeout.Value, delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								CS_0024_003C_003E8__locals0.reader = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.TransformationProvider.ExecuteQuery(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.query, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.preparedParamValues);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					});
				}
				else
				{
					CS_0024_003C_003E8__locals0.reader = TransformationProvider.ExecuteQuery(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.query, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.preparedParamValues);
				}
				using (CS_0024_003C_003E8__locals0.reader)
				{
					DataTable dataTable = new DataTable();
					dataTable.Load(CS_0024_003C_003E8__locals0.reader);
					Logger.Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E8EC0));
					return dataTable;
				}
			}
			finally
			{
				TransformationProvider.RollbackTransaction();
			}
		}
		catch (Exception ex)
		{
			Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E21580), Name), ex);
			throw new ExternalDataSourceExecutorExecuteException(Name, ex);
		}
	}

	public long? Count(string query, Dictionary<string, object> paramValues = null)
	{
		try
		{
			Dictionary<string, object> preparedParameters = GetPreparedParameters(query, paramValues);
			string sql = TransformationProvider.Count(query);
			return Convert.ToInt64(TransformationProvider.ExecuteScalar(sql, preparedParameters));
		}
		catch (Exception)
		{
			return null;
		}
	}

	public void Dispose()
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
				BwECt4O8ta5hXKAYB6v(TransformationProvider);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool tGT5bZOfuVNixaokr78()
	{
		return nxGU48OEISWacNnL6eE == null;
	}

	internal static DataBaseExternalDataSourceExecutor k8IvtxOQ7f9gKGcNeAw()
	{
		return nxGU48OEISWacNnL6eE;
	}

	internal static void YOAO5TOCT7drGKiWN3h()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void r7Z5rPOvs2QNmBA7ynJ(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static void BwECt4O8ta5hXKAYB6v(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}

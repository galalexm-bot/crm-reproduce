using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

public static class SqlQueryInfoExtension
{
	private static SqlQueryInfoExtension n4pW2ZEohgwN8YlRLuLs;

	public static IList<SqlQueryInfo.CommandParamater> AsQueryInfoCommandParamaters(this IDataParameterCollection parameters)
	{
		if (parameters == null || parameters.Count == 0)
		{
			return new List<SqlQueryInfo.CommandParamater>(0);
		}
		return parameters.Cast<DbParameter>().Select(delegate(DbParameter p)
		{
			SqlQueryInfo.CommandParamater obj = new SqlQueryInfo.CommandParamater
			{
				Name = (string)_003C_003Ec.LCuf0x8SiAkg6PLI3n8x(p)
			};
			_003C_003Ec.iECGZS8Sq2u078eu814c(obj, _003C_003Ec.vjqH6X8SRm8XsnvYwwRW(p));
			_003C_003Ec.VlVFAe8SKYnyMnG1EtZV(obj, p.DbType.ToString());
			obj.Value = _003C_003Ec.iisjRq8SXHfSXLVKQjWN(p);
			return obj;
		}).ToList();
	}

	public static object GetParameterLogValue(this IDataParameter parameter)
	{
		//Discarded unreachable code: IL_00dc, IL_00eb
		int num = 3;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (parameter != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 4:
				array = (byte[])wcuQSYEoQNbRCagvIYNo(parameter);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				return VognHlEofn2okxtWmDXp(--1333735954 ^ 0x4F7D3412);
			default:
				return string.Empty;
			case 2:
				if (parameter.Value != DBNull.Value)
				{
					if (!(wcuQSYEoQNbRCagvIYNo(parameter) is byte[]))
					{
						return wcuQSYEoQNbRCagvIYNo(parameter);
					}
					num2 = 4;
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 5:
				return OMDeI5EoCOGv19gqW0ps(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA16B86), (array != null) ? OMDeI5EoCOGv19gqW0ps(VognHlEofn2okxtWmDXp(-1638402543 ^ -1638670899), array.Length) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E65046));
			}
		}
	}

	internal static object VognHlEofn2okxtWmDXp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wcuQSYEoQNbRCagvIYNo(object P_0)
	{
		return ((IDataParameter)P_0).Value;
	}

	internal static object OMDeI5EoCOGv19gqW0ps(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool dcngnDEoGvHMyX59BCbS()
	{
		return n4pW2ZEohgwN8YlRLuLs == null;
	}

	internal static SqlQueryInfoExtension dDsvRLEoEYv0tBSfmXyg()
	{
		return n4pW2ZEohgwN8YlRLuLs;
	}
}

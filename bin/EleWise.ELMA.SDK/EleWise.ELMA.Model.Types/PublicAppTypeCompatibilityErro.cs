using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class PublicAppTypeCompatibilityError : IPublicApplicationCompatibilityError
{
	private string _typeCode;

	private string _typeName;

	private bool? _isReadOnly;

	private List<string> _propertyNames;

	internal static PublicAppTypeCompatibilityError IhrsjRoyCXomZPYSOlTa;

	public bool IsError
	{
		[CompilerGenerated]
		get
		{
			return _003CIsError_003Ek__BackingField;
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
					_003CIsError_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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

	public string Message
	{
		get
		{
			int num = 2;
			int num2 = num;
			bool? isReadOnly = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					isReadOnly = IsReadOnly;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (isReadOnly.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return SR.T((string)YjeFNwoyZ3F6uAh4Vykv(-420743386 ^ -420912090), _typeName, L3CX8ZoyuPIbqlbBwETe(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643787269), _propertyNames.Select((string p) => (string)_003C_003Ec.dwlyW0CVAk1deikMjSWb(_003C_003Ec.oJxnILCVHrwEIXkwLERU(-345420348 ^ -345419622), p, _003C_003Ec.oJxnILCVHrwEIXkwLERU(0x3A5D5EF ^ 0x3A5C8B1))).ToArray()));
				default:
					isReadOnly = IsReadOnly;
					num2 = 4;
					break;
				case 4:
					if (!isReadOnly.Value)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 2;
						}
						break;
					}
					return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6CC867), _typeName, L3CX8ZoyuPIbqlbBwETe(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488878135), _propertyNames.Select((string p) => (string)_003C_003Ec.dwlyW0CVAk1deikMjSWb(_003C_003Ec.oJxnILCVHrwEIXkwLERU(-1334993905 ^ -1335000751), p, _003C_003Ec.oJxnILCVHrwEIXkwLERU(0x3630F361 ^ 0x3630EE3F))).ToArray()));
				case 3:
					return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341ACFB7), _typeName, L3CX8ZoyuPIbqlbBwETe(YjeFNwoyZ3F6uAh4Vykv(-1876063057 ^ -1876066131), _propertyNames.Select((string p) => (string)_003C_003Ec.oJxnILCVHrwEIXkwLERU(-541731959 ^ -541733161) + p + (string)_003C_003Ec.oJxnILCVHrwEIXkwLERU(-740338220 ^ -740341622)).ToArray()));
				}
			}
		}
	}

	public string TypeCode => _typeCode;

	public string TypeName => _typeName;

	public bool? IsReadOnly => _isReadOnly;

	public List<string> PropertyNames => _propertyNames;

	public PublicAppTypeCompatibilityError(string typeCode, string typeName, bool? isReadOnly, params string[] propertyNames)
	{
		SingletonReader.JJCZtPuTvSt();
		_propertyNames = new List<string>();
		base._002Ector();
		_typeCode = typeCode;
		_typeName = typeName;
		_isReadOnly = isReadOnly;
		if (propertyNames != null)
		{
			_propertyNames.AddRange(propertyNames);
		}
		IsError = true;
	}

	internal static bool uKFbDkoyvSyKtjTuvAsB()
	{
		return IhrsjRoyCXomZPYSOlTa == null;
	}

	internal static PublicAppTypeCompatibilityError HaR73Yoy8y2KXF7HZKSm()
	{
		return IhrsjRoyCXomZPYSOlTa;
	}

	internal static object YjeFNwoyZ3F6uAh4Vykv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L3CX8ZoyuPIbqlbBwETe(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}
}

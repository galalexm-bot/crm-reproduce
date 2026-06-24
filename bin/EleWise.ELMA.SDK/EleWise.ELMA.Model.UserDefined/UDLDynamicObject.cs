using System.Collections.Generic;
using System.Dynamic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.UserDefinedList;

internal sealed class UDLDynamicObject : DynamicObject
{
	private readonly Dictionary<string, object> properties;

	internal static UDLDynamicObject kGH9NHbQ4R8lynmDaenl;

	public UDLDynamicObject(Dictionary<string, object> props)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		properties = props;
	}

	public override IEnumerable<string> GetDynamicMemberNames()
	{
		return properties.Keys;
	}

	public object TryGetValue(string propertyName)
	{
		int num = 3;
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
					result = properties[propertyName];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return result;
				case 2:
					if (properties.ContainsKey(propertyName))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				break;
			}
			result = null;
			num = 2;
		}
	}

	public void RemoveValue(string propertyName)
	{
		int num = 2;
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
				properties.Remove(propertyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!properties.ContainsKey(propertyName))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		//Discarded unreachable code: IL_0054, IL_0063
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return true;
			case 2:
				result = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!properties.ContainsKey(binder.Name))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 1:
				result = properties[(string)BdT5m9bQAFUtHIQscZaH(binder)];
				num2 = 4;
				break;
			default:
				return false;
			}
		}
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		//Discarded unreachable code: IL_0091
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				properties[(string)UZffKFbQ7NcNsw3YPTfS(binder)] = value;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return true;
			default:
				return false;
			case 1:
				if (!properties.ContainsKey((string)UZffKFbQ7NcNsw3YPTfS(binder)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public void AddMember(string name, object value)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				properties.Add(name, value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				if (properties.ContainsKey(name))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				return;
			}
		}
	}

	internal static bool oAHJ0ebQ6EKf6W6I4vXL()
	{
		return kGH9NHbQ4R8lynmDaenl == null;
	}

	internal static UDLDynamicObject OsvDURbQHOTmLvkRY6vi()
	{
		return kGH9NHbQ4R8lynmDaenl;
	}

	internal static object BdT5m9bQAFUtHIQscZaH(object P_0)
	{
		return ((GetMemberBinder)P_0).Name;
	}

	internal static object UZffKFbQ7NcNsw3YPTfS(object P_0)
	{
		return ((SetMemberBinder)P_0).Name;
	}
}

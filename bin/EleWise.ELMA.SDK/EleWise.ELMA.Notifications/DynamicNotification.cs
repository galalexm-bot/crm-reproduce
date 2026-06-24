using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Notifications;

public class DynamicNotification : INotification, IExtendedPropertiesContainer
{
	private Dictionary<string, object> data;

	internal static DynamicNotification o78l9saAhScObu9ij37;

	public string TemplateName
	{
		[CompilerGenerated]
		get
		{
			return _003CTemplateName_003Ek__BackingField;
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
					_003CTemplateName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	public object this[string name]
	{
		get
		{
			return data[name];
		}
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
					data[name] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
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

	public IDictionary<string, object> ExtendedProperties => data;

	public DynamicNotification()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		data = new Dictionary<string, object>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool B7L29pa7XrXAXSLLSGS()
	{
		return o78l9saAhScObu9ij37 == null;
	}

	internal static DynamicNotification jLE2braxGc9SvPSJ9yD()
	{
		return o78l9saAhScObu9ij37;
	}
}

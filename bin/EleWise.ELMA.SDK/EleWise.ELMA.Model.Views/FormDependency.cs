using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class FormDependency : IFormDependency
{
	internal static FormDependency XJA6PmoXMH5MNY9vh9E3;

	public IList<Guid> FormUids { get; set; }

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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

	public bool DefaultDependency
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultDependency_003Ek__BackingField;
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
					_003CDefaultDependency_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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

	public FormDependency()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Name = "";
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				FormUids = new List<Guid>();
				num = 2;
				break;
			}
		}
	}

	public FormDependency(string name, IEnumerable<Guid> formUids)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Name = name;
		FormUids = formUids.ToList();
	}

	public FormDependency(string name, IEnumerable<Guid> formUids, bool defaultDependency)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Name = name;
		FormUids = formUids.ToList();
		DefaultDependency = defaultDependency;
	}

	internal static bool GBJck2oXJ9oJjalwMmxt()
	{
		return XJA6PmoXMH5MNY9vh9E3 == null;
	}

	internal static FormDependency y33rWFoX9ZZxrQvTbZkC()
	{
		return XJA6PmoXMH5MNY9vh9E3;
	}
}

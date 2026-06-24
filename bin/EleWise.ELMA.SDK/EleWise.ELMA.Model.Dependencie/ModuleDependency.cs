using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

[Serializable]
public sealed class ModuleDependency
{
	internal static ModuleDependency tJLcfHhRnEuOZh9IypwS;

	[XmlArrayItem("DataClass")]
	[XmlArray("DataClasses")]
	public List<DataClassDependency> DataClasses { get; }

	[XmlArray("Functions")]
	[XmlArrayItem("Function")]
	public List<FunctionDependency> Functions { get; }

	[XmlArrayItem("Component")]
	[XmlArray("Components")]
	public List<ComponentDependency> Components { get; }

	[XmlArrayItem("EntityDependency")]
	[XmlArray("EntityDependencies")]
	public List<EntityDependency> EntityDependencies { get; }

	[XmlArrayItem("EnumDependency")]
	[XmlArray("EnumDependencies")]
	public List<EnumDependency> EnumDependencies { get; }

	public ModuleDependency()
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 3:
				Components = new List<ComponentDependency>();
				num = 4;
				break;
			case 1:
			{
				EnumDependencies = new List<EnumDependency>();
				int num2 = 5;
				num = num2;
				break;
			}
			case 4:
				EntityDependencies = new List<EntityDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 0;
				}
				break;
			default:
				DataClasses = new List<DataClassDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 2;
				}
				break;
			case 2:
				Functions = new List<FunctionDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClasses()
	{
		return DataClasses.Count > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctions()
	{
		return hpfGB5hReo5PgY3xWFiQ(Functions) > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeComponents()
	{
		return shXxlJhRPwV0yco2XSHj(Components) > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEntityDependencies()
	{
		return NI87bYhR1oeOYaU7c18f(EntityDependencies) > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeEnumDependencies()
	{
		return oCa3dEhRNmsfWKXdV6Hj(EnumDependencies) > 0;
	}

	internal static bool f6PTCDhROmHaUlkrUQ5v()
	{
		return tJLcfHhRnEuOZh9IypwS == null;
	}

	internal static ModuleDependency pfwtHLhR24gOmkTPRFVl()
	{
		return tJLcfHhRnEuOZh9IypwS;
	}

	internal static int hpfGB5hReo5PgY3xWFiQ(object P_0)
	{
		return ((List<FunctionDependency>)P_0).Count;
	}

	internal static int shXxlJhRPwV0yco2XSHj(object P_0)
	{
		return ((List<ComponentDependency>)P_0).Count;
	}

	internal static int NI87bYhR1oeOYaU7c18f(object P_0)
	{
		return ((List<EntityDependency>)P_0).Count;
	}

	internal static int oCa3dEhRNmsfWKXdV6Hj(object P_0)
	{
		return ((List<EnumDependency>)P_0).Count;
	}
}

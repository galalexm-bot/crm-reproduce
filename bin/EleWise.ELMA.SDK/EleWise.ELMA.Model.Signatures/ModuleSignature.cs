using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Signatures;

[Serializable]
[DataContract]
public class ModuleSignature
{
	internal static ModuleSignature F9PRqGWzznBtS7pKdXUB;

	public List<DataClassDependency> DataClasses { get; set; }

	public List<FunctionDependency> Functions { get; set; }

	public List<ComponentSignature> Components { get; set; }

	public List<ImplementationSignature> Implementations { get; set; }

	public List<ImplementationSignature> ExtensionPoints { get; set; }

	public List<CustomTypeImplementationModel> CustomTypes { get; set; }

	public ModuleSignature()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 1:
				Functions = new List<FunctionDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num = 2;
				}
				break;
			case 4:
				ExtensionPoints = new List<ImplementationSignature>();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 5;
				}
				break;
			case 5:
				CustomTypes = new List<CustomTypeImplementationModel>();
				num = 6;
				break;
			default:
				Implementations = new List<ImplementationSignature>();
				num = 4;
				break;
			case 3:
				DataClasses = new List<DataClassDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Components = new List<ComponentSignature>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDataClasses()
	{
		return zROMrBoFW8cvktfjUR96(DataClasses) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFunctions()
	{
		return NdwgysoFoEBpYBG4onYo(Functions) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeComponents()
	{
		return YZ0UecoFbSRWIO5OHfRi(Components) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImplementations()
	{
		return GuSYGgoFh7FkH3i787oC(Implementations) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExtensionPoints()
	{
		return GuSYGgoFh7FkH3i787oC(ExtensionPoints) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCustomTypes()
	{
		return CustomTypes.Count != 0;
	}

	internal static bool yi9ntroFFhep9ZS91YsE()
	{
		return F9PRqGWzznBtS7pKdXUB == null;
	}

	internal static ModuleSignature fTFW6loFBOGDFbGxBP0v()
	{
		return F9PRqGWzznBtS7pKdXUB;
	}

	internal static int zROMrBoFW8cvktfjUR96(object P_0)
	{
		return ((List<DataClassDependency>)P_0).Count;
	}

	internal static int NdwgysoFoEBpYBG4onYo(object P_0)
	{
		return ((List<FunctionDependency>)P_0).Count;
	}

	internal static int YZ0UecoFbSRWIO5OHfRi(object P_0)
	{
		return ((List<ComponentSignature>)P_0).Count;
	}

	internal static int GuSYGgoFh7FkH3i787oC(object P_0)
	{
		return ((List<ImplementationSignature>)P_0).Count;
	}
}

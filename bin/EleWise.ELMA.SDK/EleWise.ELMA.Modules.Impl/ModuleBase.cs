using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Impl;

internal abstract class ModuleBase : CompositeApplicationUnit, IModule, ICompositeApplicationUnit, IApplicationUnit
{
	private List<IModuleAssembly> assemblies;

	private List<IModule> extensionModules;

	private static ModuleBase fGFFJn3TN5UrElGA4R0;

	public ModuleType ModuleType
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleType_003Ek__BackingField;
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
					_003CModuleType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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

	public abstract string WebSite { get; }

	public abstract string HtmlDescription { get; }

	public ModuleStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ModuleDisabledReason DisabledReason
	{
		[CompilerGenerated]
		get
		{
			return _003CDisabledReason_003Ek__BackingField;
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
					_003CDisabledReason_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
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

	public abstract bool ServerModuleRequired { get; }

	public override IEnumerable<IApplicationUnit> Units => ExtensionModules.Cast<IApplicationUnit>().Union(Assemblies);

	public IEnumerable<IModuleAssembly> Assemblies => assemblies;

	public IEnumerable<IModule> ExtensionModules => extensionModules;

	public void AddAssembly(IModuleAssembly asm)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (assemblies.Contains(asm))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				return;
			}
			assemblies.Add(asm);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
			{
				num2 = 0;
			}
		}
	}

	public void AddExtensionModule(IModule module)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				case 2:
					return;
				case 3:
					if (!extensionModules.Contains(module))
					{
						break;
					}
					goto end_IL_0012;
				}
				extensionModules.Add(module);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	protected ModuleBase()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		i74EJv3ONjWaSJvGa4l();
		assemblies = new List<IModuleAssembly>();
		extensionModules = new List<IModule>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool urawT13kL3V1xtqZFhd()
	{
		return fGFFJn3TN5UrElGA4R0 == null;
	}

	internal static ModuleBase CyIk8Y3nhHBahMiNGlK()
	{
		return fGFFJn3TN5UrElGA4R0;
	}

	internal static void i74EJv3ONjWaSJvGa4l()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

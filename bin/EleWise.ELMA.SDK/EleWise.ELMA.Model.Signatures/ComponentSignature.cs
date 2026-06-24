using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Signatures;

[Serializable]
public sealed class ComponentSignature : Dependency
{
	internal static ComponentSignature ze8JmFWzjK1AiXpwEPdR;

	public List<InputComputedValue> Inputs { get; set; }

	public List<ImplementationSignature> Implementations { get; set; }

	public List<ImplementationSignature> ExtensionPoints { get; set; }

	public CustomTypeImplementationModel CustomType
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomType_003Ek__BackingField;
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
					_003CCustomType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ComponentSignature()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SqCk3OWzU0MUVZ91rxeU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 3:
				Implementations = new List<ImplementationSignature>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				Inputs = new List<InputComputedValue>();
				num = 3;
				break;
			default:
				ExtensionPoints = new List<ImplementationSignature>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeInputs()
	{
		return QvrnRuWzswPchoFjeZH0(Inputs) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImplementations()
	{
		return GyJdO9WzcabcZrGQ5mMe(Implementations) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExtensionPoints()
	{
		return GyJdO9WzcabcZrGQ5mMe(ExtensionPoints) != 0;
	}

	internal static void SqCk3OWzU0MUVZ91rxeU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool lg6NgqWzYGmWLXZDflI6()
	{
		return ze8JmFWzjK1AiXpwEPdR == null;
	}

	internal static ComponentSignature M3N4L6WzL8ZNxAAKuy90()
	{
		return ze8JmFWzjK1AiXpwEPdR;
	}

	internal static int QvrnRuWzswPchoFjeZH0(object P_0)
	{
		return ((List<InputComputedValue>)P_0).Count;
	}

	internal static int GyJdO9WzcabcZrGQ5mMe(object P_0)
	{
		return ((List<ImplementationSignature>)P_0).Count;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Services.FindComponent;

public sealed class ObjectFormFindComponentModel
{
	private static ObjectFormFindComponentModel EDo17YBBKf8pSwVdaTIk;

	public string MetadataDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataDisplayName_003Ek__BackingField;
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
					_003CMetadataDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public Guid MetadataUid
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataUid_003Ek__BackingField;
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
					_003CMetadataUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormViewItem Form
	{
		[CompilerGenerated]
		get
		{
			return _003CForm_003Ek__BackingField;
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
					_003CForm_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
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

	public List<ComponentDependency> ComponentDependencies { get; }

	public List<FunctionDependency> FunctionDependencies { get; }

	public List<DataClassDependency> DataClassDependencies { get; }

	public ObjectFormFindComponentModel()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		o1KJOVBBkvyd1Hr34GRj();
		ComponentDependencies = new List<ComponentDependency>();
		FunctionDependencies = new List<FunctionDependency>();
		DataClassDependencies = new List<DataClassDependency>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool C3CKIRBBXMqqAinCedGs()
	{
		return EDo17YBBKf8pSwVdaTIk == null;
	}

	internal static ObjectFormFindComponentModel KKsL8gBBTHorTuYB8Z4F()
	{
		return EDo17YBBKf8pSwVdaTIk;
	}

	internal static void o1KJOVBBkvyd1Hr34GRj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services.Models;

public sealed class EntityFormView
{
	internal static EntityFormView RTXucsbZJNYxelGrNHp1;

	public string Model
	{
		[CompilerGenerated]
		get
		{
			return _003CModel_003Ek__BackingField;
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
					_003CModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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

	public FormViewItem View
	{
		[CompilerGenerated]
		get
		{
			return _003CView_003Ek__BackingField;
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
					_003CView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMetadata Metadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadata_003Ek__BackingField;
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
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IMetadata> AdditionalMetadata { get; set; }

	public FormViewBuilderInfo FormViewBuilderInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CFormViewBuilderInfo_003Ek__BackingField;
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
					_003CFormViewBuilderInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ModelInfo ModelInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CModelInfo_003Ek__BackingField;
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
					_003CModelInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ClientScriptModel> ClientScriptModels { get; set; }

	public RecursiveComponentModel RecursiveComponentModel
	{
		[CompilerGenerated]
		get
		{
			return _003CRecursiveComponentModel_003Ek__BackingField;
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
					_003CRecursiveComponentModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<EntityDependency> EntityDependencies { get; set; }

	public HashSet<Guid> EntityMetadataUids { get; set; }

	public HashSet<Guid> EnumMetadataUids { get; set; }

	public EntityFormView()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		w08M0QbZlLUhQn03Uf7Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				EnumMetadataUids = new HashSet<Guid>();
				num = 2;
				continue;
			case 2:
				return;
			}
			EntityMetadataUids = new HashSet<Guid>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void w08M0QbZlLUhQn03Uf7Z()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool USD49QbZ9rcg7T0HYDLJ()
	{
		return RTXucsbZJNYxelGrNHp1 == null;
	}

	internal static EntityFormView hDptJxbZdZ0KqflyxV9Z()
	{
		return RTXucsbZJNYxelGrNHp1;
	}
}

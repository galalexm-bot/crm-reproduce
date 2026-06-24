using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlRoot("Namespace")]
public class NamespaceMetadata : NamedMetadata, ICodeItemMetadata, IMetadata, IXsiType, IRootMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		private static object zhanh8C4ovGDYPKHJPCt;

		public string Name => SR.T((string)WRafD0C4Gk59esM7Px1J(-234299632 ^ -234000008));

		public string Description => string.Empty;

		public Type MetadataType => nCBgOfC4Ets54E5PcoRS(typeof(NamespaceMetadata).TypeHandle);

		public Type GeneratorType => nCBgOfC4Ets54E5PcoRS(typeof(NamespaceGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Bk0XxaC4fBHSIahLs0qZ();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object WRafD0C4Gk59esM7Px1J(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool La5lcQC4bavLaokBtrLT()
		{
			return zhanh8C4ovGDYPKHJPCt == null;
		}

		internal static Info PHZV4uC4h4ySstoy8Jrx()
		{
			return (Info)zhanh8C4ovGDYPKHJPCt;
		}

		internal static Type nCBgOfC4Ets54E5PcoRS(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void Bk0XxaC4fBHSIahLs0qZ()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class TreeNode
	{
		internal static TreeNode vqaL00C4QEid1dytq0jI;

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
					case 0:
						return;
					case 1:
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return _003CDisplayName_003Ek__BackingField;
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
						_003CDisplayName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Namespace
		{
			[CompilerGenerated]
			get
			{
				return _003CNamespace_003Ek__BackingField;
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
						_003CNamespace_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
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

		public bool AllowCreateModels
		{
			[CompilerGenerated]
			get
			{
				return _003CAllowCreateModels_003Ek__BackingField;
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
						_003CAllowCreateModels_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<TreeNode> Nodes { get; set; }

		public TreeNode()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Nodes = new List<TreeNode>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static bool kUFFdwC4Cn7DnDEdd689()
		{
			return vqaL00C4QEid1dytq0jI == null;
		}

		internal static TreeNode E1UujlC4vTP6Kf7KNelo()
		{
			return vqaL00C4QEid1dytq0jI;
		}
	}

	internal static NamespaceMetadata u5k14qb7qAfpC1ZacfRT;

	public virtual string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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

	[DefaultValue("")]
	public virtual string NamespaceForDisplay
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespaceForDisplay_003Ek__BackingField;
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
					_003CNamespaceForDisplay_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

	public string FullTypeName
	{
		get
		{
			//Discarded unreachable code: IL_006e
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!DblDCdb7k3anYylMbJqK(nerT5Ab7TESx51eXU7Iw(this)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					text = string.Empty;
					break;
				default:
					text = (string)nerT5Ab7TESx51eXU7Iw(this) + (string)YnTXYEb7nfNdIIqnIpWp(-1217523399 ^ -1217524739);
					break;
				}
				break;
			}
			return (string)pP79Ykb72bOINCFfX52v(text, sPy9sDb7OA5yRKH3Tck2(this));
		}
	}

	[DefaultValue(false)]
	public bool AllowCreateModels
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowCreateModels_003Ek__BackingField;
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
					_003CAllowCreateModels_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void LoadFromType(Type type, bool inherit = true)
	{
		int num = 3;
		AssemblyModuleAttribute attribute = default(AssemblyModuleAttribute);
		UidAttribute attribute2 = default(UidAttribute);
		INamespaceInfo namespaceInfo = default(INamespaceInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 8:
					PqG87Lb73ucmc9O7JtRF(this, type.Namespace);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					attribute = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
					num2 = 7;
					continue;
				case 3:
					attribute2 = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: false);
					num2 = 2;
					continue;
				case 1:
					namespaceInfo = (INamespaceInfo)Activator.CreateInstance(type);
					num2 = 6;
					continue;
				case 10:
					break;
				default:
					wYIAqLb7NRq3LQjEIejM(this, b80EYZb71S9pgCqqIj6w(type));
					num2 = 8;
					continue;
				case 2:
					Uid = attribute2?.Uid ?? Guid.Empty;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					jrX66mb7epHm1Q8nQQF7(this, attribute?.Uid ?? Guid.Empty);
					num2 = 9;
					continue;
				case 9:
					LgWwE4b7PDMa60Rq1CHY(this, !type.IsPublic && !type.IsNestedPublic);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					BLUtf0b7plSkjp2dVmXm(this, (namespaceInfo != null) ? namespaceInfo.DisplayName : string.Empty);
					num2 = 10;
					continue;
				}
				break;
			}
			AllowCreateModels = AttributeHelper<AllowCreateModelsAttribute>.GetAttribute(type, inherited: false) != null;
			num = 4;
		}
	}

	public virtual bool IsRestartNeeded(IRootMetadata metadata)
	{
		return true;
	}

	public virtual void ApplyRestartUnrequiredChanges(bool inherit)
	{
	}

	public static TreeNode BuildNamespaceTree(List<NamespaceMetadata> namespaces)
	{
		TreeNode treeNode = new TreeNode();
		Dictionary<string, TreeNode> nodesByNamespace = new Dictionary<string, TreeNode>();
		foreach (NamespaceMetadata item in namespaces.Where((NamespaceMetadata n) => _003C_003Ec.xx00jFC4VpIrl0RDNGOE(n)))
		{
			if (item.Namespace != null)
			{
				AddNode(item, treeNode, namespaces, nodesByNamespace);
			}
		}
		return treeNode;
	}

	private static TreeNode AddNode(object metadata, object root, List<NamespaceMetadata> namespaces, Dictionary<string, TreeNode> nodesByNamespace)
	{
		if (nodesByNamespace.TryGetValue(((NamespaceMetadata)metadata).Namespace, out var value))
		{
			return value;
		}
		int num = ((NamespaceMetadata)metadata).Namespace.LastIndexOf('.');
		TreeNode treeNode = null;
		if (num >= 0)
		{
			_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
			CS_0024_003C_003E8__locals0.prevNsName = ((NamespaceMetadata)metadata).Namespace.Substring(0, num);
			NamespaceMetadata namespaceMetadata = namespaces.FirstOrDefault((NamespaceMetadata ns) => _003C_003Ec__DisplayClass20_0.ntH8EoC4KxgDiFI494Gb(ns.Namespace, CS_0024_003C_003E8__locals0.prevNsName));
			treeNode = ((namespaceMetadata != null) ? AddNode(namespaceMetadata, root, namespaces, nodesByNamespace) : null);
		}
		if (string.IsNullOrEmpty(((NamedMetadata)metadata).DisplayName))
		{
			nodesByNamespace.Add(((NamespaceMetadata)metadata).Namespace, treeNode);
			if (treeNode != null && !treeNode.AllowCreateModels && ((NamespaceMetadata)metadata).AllowCreateModels)
			{
				treeNode.AllowCreateModels = true;
				treeNode.Namespace = ((NamespaceMetadata)metadata).Namespace;
			}
			return treeNode;
		}
		string text = ((num >= 0) ? ((NamespaceMetadata)metadata).Namespace.Substring(num + 1) : ((NamespaceMetadata)metadata).Namespace);
		value = new TreeNode
		{
			Name = text,
			DisplayName = ((NamedMetadata)metadata).DisplayName,
			Namespace = ((NamespaceMetadata)metadata).Namespace
		};
		value.AllowCreateModels = ((NamespaceMetadata)metadata).AllowCreateModels;
		((treeNode != null) ? treeNode.Nodes : ((TreeNode)root).Nodes).Add(value);
		nodesByNamespace.Add(((NamespaceMetadata)metadata).Namespace, value);
		return value;
	}

	public NamespaceMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ht91TSb7aRPBWmjrbgrt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool y4h0uib7Kgwvpa5ycFlc()
	{
		return u5k14qb7qAfpC1ZacfRT == null;
	}

	internal static NamespaceMetadata bCkH28b7Xo8jGi2S2fq7()
	{
		return u5k14qb7qAfpC1ZacfRT;
	}

	internal static object nerT5Ab7TESx51eXU7Iw(object P_0)
	{
		return ((NamespaceMetadata)P_0).Namespace;
	}

	internal static bool DblDCdb7k3anYylMbJqK(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object YnTXYEb7nfNdIIqnIpWp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sPy9sDb7OA5yRKH3Tck2(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object pP79Ykb72bOINCFfX52v(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void jrX66mb7epHm1Q8nQQF7(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static void LgWwE4b7PDMa60Rq1CHY(object P_0, bool value)
	{
		((AbstractMetadata)P_0).Internal = value;
	}

	internal static object b80EYZb71S9pgCqqIj6w(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void wYIAqLb7NRq3LQjEIejM(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void PqG87Lb73ucmc9O7JtRF(object P_0, object P_1)
	{
		((NamespaceMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void BLUtf0b7plSkjp2dVmXm(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void Ht91TSb7aRPBWmjrbgrt()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

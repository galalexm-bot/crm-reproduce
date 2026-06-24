using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

public class MetadataTreeHelper
{
	public abstract class Node
	{
		private static Node QgTOqPCwFE60CJodbsjm;

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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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

		protected Node()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SFhpWXCworjbKLAa8RFD();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bBe56VCwBKQ2A5MICT4Y()
		{
			return QgTOqPCwFE60CJodbsjm == null;
		}

		internal static Node qGAfBxCwWwPFVMOn0IAA()
		{
			return QgTOqPCwFE60CJodbsjm;
		}

		internal static void SFhpWXCworjbKLAa8RFD()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class GroupNode : Node
	{
		internal static GroupNode l21uV0CwbMRK9CZot0RJ;

		public MetadataItemGroupDTO Group
		{
			[CompilerGenerated]
			get
			{
				return _003CGroup_003Ek__BackingField;
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
						_003CGroup_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

		public List<string> MetadataItemNamespaces { get; set; }

		public List<MetadataNode> MetadataNodes { get; set; }

		public List<GroupNode> GroupNodes { get; set; }

		public GroupNode()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LL8N1OCwETR9aSkYGTpy();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					GroupNodes = new List<GroupNode>();
					num = 3;
					break;
				case 3:
					MetadataItemNamespaces = new List<string>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num = 1;
					}
					break;
				case 2:
					MetadataNodes = new List<MetadataNode>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static void LL8N1OCwETR9aSkYGTpy()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Lb7FscCwhZ7Xbm7lEqYV()
		{
			return l21uV0CwbMRK9CZot0RJ == null;
		}

		internal static GroupNode IBRd1bCwGkqSBYFAI34L()
		{
			return l21uV0CwbMRK9CZot0RJ;
		}
	}

	public class MetadataNode : Node
	{
		private static MetadataNode eYiE2VCwf4IdNlgDbAQe;

		public ICodeItemMetadata Metadata
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
					case 1:
						_003CMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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

		public MetadataNode()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool H6Dl95CwQiTkx97J487b()
		{
			return eYiE2VCwf4IdNlgDbAQe == null;
		}

		internal static MetadataNode Ae9OdbCwCaNR3CS63Xrl()
		{
			return eYiE2VCwf4IdNlgDbAQe;
		}
	}

	private IEnumerable<ICodeItemMetadata> metadataList;

	private readonly IMetadataService metadataService;

	private GroupNode root;

	private bool showDisplayName;

	private bool showEmptyGroups;

	private bool generateForPublicApi;

	private Dictionary<long, GroupNode> groupNodesById;

	internal const string CacheKey = "MetadataItemGroupDTO[Root]";

	private static MetadataTreeHelper lAPclcb6QU7uaVlojpFD;

	public static GroupNode BuildTree(IEnumerable<ICodeItemMetadata> metadataList, bool showDisplayName = true, bool showEmptyGroups = false, bool generateForPublicApi = false)
	{
		return BuildTree(metadataList, null, showDisplayName, showEmptyGroups, generateForPublicApi);
	}

	public static GroupNode BuildTree(IEnumerable<ICodeItemMetadata> metadataList, IMetadataService metadataService, bool showDisplayName = true, bool showEmptyGroups = false, bool generateForPublicApi = false)
	{
		Contract.ArgumentNotNull(metadataList, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E08DB0));
		return new MetadataTreeHelper(metadataList, metadataService)
		{
			showDisplayName = showDisplayName,
			showEmptyGroups = showEmptyGroups,
			generateForPublicApi = generateForPublicApi
		}.BuildTreeImpl(metadataList);
	}

	public static GroupNode GetGroupByName(GroupNode rootGroupNode, string groupName)
	{
		//Discarded unreachable code: IL_0032, IL_0040, IL_00a9, IL_01b6, IL_01ec, IL_01ff, IL_020e
		int num = 1;
		int num2 = num;
		List<GroupNode>.Enumerator enumerator = default(List<GroupNode>.Enumerator);
		GroupNode current = default(GroupNode);
		GroupNode groupNode = default(GroupNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num3 = 0;
							}
							goto IL_0044;
						}
						goto IL_0112;
						IL_0112:
						current = enumerator.Current;
						num3 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num3 = 1;
						}
						goto IL_0044;
						IL_0044:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
							case 10:
								break;
							case 5:
								if (HsWbDPb6IRarxbP3FhNp(current) == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 11;
							case 3:
								groupNode = current;
								num3 = 2;
								continue;
							case 8:
								if (!t5iqiUb6ZvZH4yotnwoP(Q7OPTIb68IuX29DjSTN9(current)))
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 2;
							case 4:
								goto IL_0112;
							case 2:
								if (groupNode != null)
								{
									num3 = 10;
									continue;
								}
								goto case 5;
							case 7:
								if (L2lcvlb6uETDBuW5IyCV(Q7OPTIb68IuX29DjSTN9(current), groupName))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 11:
								if ((string)fcqGknb6VYSe3wtqEGLK(HsWbDPb6IRarxbP3FhNp(current)) == groupName)
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num3 = 9;
									}
									continue;
								}
								break;
							case 9:
								groupNode = current;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num3 = 1;
								}
								continue;
							default:
								return groupNode;
							case 0:
								return groupNode;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
				groupNode = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return groupNode;
			default:
				enumerator = rootGroupNode.GroupNodes.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private MetadataTreeHelper(IEnumerable<ICodeItemMetadata> metadataList, IMetadataService metadataService = null)
	{
		SingletonReader.JJCZtPuTvSt();
		groupNodesById = new Dictionary<long, GroupNode>();
		base._002Ector();
		this.metadataList = metadataList;
		this.metadataService = metadataService;
	}

	private GroupNode BuildTreeImpl(IEnumerable<ICodeItemMetadata> metadataList)
	{
		root = new GroupNode();
		groupNodesById.Clear();
		MetadataItemGroupDTO rootGroup = GetRootGroup();
		if (rootGroup != null)
		{
			foreach (MetadataItemGroupDTO subGroup in rootGroup.SubGroups)
			{
				AddGroupNode(subGroup, root);
			}
		}
		foreach (ICodeItemMetadata metadata in metadataList)
		{
			AddNode(metadata);
		}
		if (!showEmptyGroups)
		{
			RemoveEmptyGroups(root);
		}
		ResortNodes(root);
		return root;
	}

	private MetadataItemGroupDTO GetRootGroup()
	{
		//Discarded unreachable code: IL_0191, IL_01a0, IL_01af, IL_01f5, IL_0204, IL_0214, IL_0223
		int num = 11;
		IContextBoundVariableService service = default(IContextBoundVariableService);
		Tuple<DateTime, MetadataItemGroupDTO> value = default(Tuple<DateTime, MetadataItemGroupDTO>);
		MetadataItemGroupDTO metadataItemGroupDTO = default(MetadataItemGroupDTO);
		IMetadataItemGroupDTOManager service2 = default(IMetadataItemGroupDTOManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					service.TryGetValue<Tuple<DateTime, MetadataItemGroupDTO>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921109611), out value);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 3;
					}
					continue;
				default:
					value = (Tuple<DateTime, MetadataItemGroupDTO>)CallContext.GetData((string)T0LsQKb6iLjUuAqgVyvp(--1867379187 ^ 0x6F4F07A5));
					num2 = 16;
					continue;
				case 14:
				case 15:
					return metadataItemGroupDTO;
				case 10:
					return null;
				case 8:
					return value.Item2;
				case 2:
					if (UMDIsab6qeRjxq7OmmcC(QpMsfMb6RUA3PBwyYF2y() - value.Item1, TimeSpan.FromSeconds(15.0)))
					{
						num2 = 8;
						continue;
					}
					goto IL_00e1;
				case 6:
					value = new Tuple<DateTime, MetadataItemGroupDTO>(QpMsfMb6RUA3PBwyYF2y(), metadataItemGroupDTO);
					num2 = 12;
					continue;
				case 11:
					if (hbhW8Kb6S8R6e4AUO1Dq())
					{
						service = Locator.GetService<IContextBoundVariableService>();
						num2 = 18;
						continue;
					}
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					return GenerateRootGroup();
				case 5:
				case 16:
					if (value != null)
					{
						num2 = 2;
						continue;
					}
					goto IL_00e1;
				case 4:
					if (service2 != null)
					{
						metadataItemGroupDTO = (MetadataItemGroupDTO)uwUJB6b6KNdI8YvtMAQK(service2);
						num2 = 6;
						continue;
					}
					goto end_IL_0012;
				case 12:
					if (service == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					break;
				case 18:
					if (service == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 3:
				case 9:
					gmshasb6X3Ao2ifslbZg(T0LsQKb6iLjUuAqgVyvp(-475857671 ^ -476050769), value);
					num2 = 15;
					continue;
				case 17:
					break;
					IL_00e1:
					service2 = Locator.GetService<IMetadataItemGroupDTOManager>();
					num2 = 4;
					continue;
				}
				service.Set((string)T0LsQKb6iLjUuAqgVyvp(0x53CACA3 ^ 0x53E5AF5), value);
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	private MetadataItemGroupDTO GenerateRootGroup()
	{
		//Discarded unreachable code: IL_013d, IL_014c, IL_0157, IL_0228, IL_023b, IL_024b, IL_0255, IL_063b, IL_067b, IL_0686, IL_06ec
		int num = 1;
		IRuntimeApplication service = default(IRuntimeApplication);
		IDataReader dataReader = default(IDataReader);
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		string sql = default(string);
		MetadataItemGroupDTO metadataItemGroupDTO = default(MetadataItemGroupDTO);
		List<KeyValuePair<long, MetadataItemGroupDTO>>.Enumerator enumerator = default(List<KeyValuePair<long, MetadataItemGroupDTO>>.Enumerator);
		KeyValuePair<long, MetadataItemGroupDTO> current = default(KeyValuePair<long, MetadataItemGroupDTO>);
		Dictionary<long, MetadataItemGroupDTO> dictionary = default(Dictionary<long, MetadataItemGroupDTO>);
		MetadataItemGroupDTO metadataItemGroupDTO3 = default(MetadataItemGroupDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					service = Locator.GetService<IRuntimeApplication>();
					num2 = 3;
					continue;
				case 2:
					dataReader = transformationProvider.ExecuteQuery(sql);
					num2 = 12;
					continue;
				case 11:
					return null;
				case 13:
					sql = (string)SxxMwGb6PIqRYO28uPbS(T0LsQKb6iLjUuAqgVyvp(0x53CACA3 ^ 0x53C2E85), tb0r7bb6eTkvSx466xss(TXlcVUb62GEYllXoTlrS(transformationProvider), T0LsQKb6iLjUuAqgVyvp(0x61EC0CB8 ^ 0x61EEFA36)));
					num2 = 6;
					continue;
				case 8:
					return null;
				case 1:
				{
					MetadataItemGroupDTO metadataItemGroupDTO2 = new MetadataItemGroupDTO();
					l3syMBb6kyOKURtgOKRg(metadataItemGroupDTO2, M41Fghb6Tw4d99r6ak3D(T0LsQKb6iLjUuAqgVyvp(-281842504 ^ -281939906)));
					mNTK6Bb6ndZmhDyyc5U2(metadataItemGroupDTO2, SR.T((string)T0LsQKb6iLjUuAqgVyvp(0x103FE975 ^ 0x103D75F3)));
					metadataItemGroupDTO = metadataItemGroupDTO2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 4:
					try
					{
						while (true)
						{
							IL_0175:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num3 = 0;
								}
								goto IL_015b;
							}
							goto IL_019b;
							IL_019b:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 1;
							}
							goto IL_015b;
							IL_015b:
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_0175;
								case 1:
									goto IL_019b;
								case 3:
									dictionary[kWpMlTb6AWtX7tS8nA4E(current.Value)].SubGroups.Add(current.Value);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 12:
					try
					{
						while (true)
						{
							IL_0333:
							int num5;
							if (!ARY4kBb66B7r52TwRTNr(dataReader))
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num5 = 2;
								}
								goto IL_0259;
							}
							goto IL_0322;
							IL_0322:
							metadataItemGroupDTO3 = new MetadataItemGroupDTO();
							num5 = 6;
							goto IL_0259;
							IL_0259:
							while (true)
							{
								switch (num5)
								{
								case 5:
									dictionary.Add(metadataItemGroupDTO3.Id, metadataItemGroupDTO3);
									num5 = 7;
									continue;
								case 4:
									metadataItemGroupDTO3.Id = Convert.ToInt64(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x638095EB ^ 0x638014B5)));
									num5 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num5 = 11;
									}
									continue;
								case 10:
									metadataItemGroupDTO3.Uid = yfWnnYb6DrAgBs0N7qI8(TXlcVUb62GEYllXoTlrS(transformationProvider), eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x35C0467B ^ 0x35C029E9)));
									num5 = 4;
									continue;
								case 3:
									break;
								case 7:
									goto IL_0333;
								case 6:
									l3syMBb6kyOKURtgOKRg(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x1FFEF86A ^ 0x1FFE8BAA)) is DBNull)) ? ((string)eaFcfab61J9ujUHrXSqd(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F51576))) : string.Empty);
									num5 = 12;
									continue;
								case 12:
									ansQqob6N8iZOodqMA0f(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978444098)) is DBNull)) ? ((string)eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x3C5338FF ^ 0x3C52BEB3))) : string.Empty);
									num5 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num5 = 6;
									}
									continue;
								case 9:
									mNTK6Bb6ndZmhDyyc5U2(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x61EC0CB8 ^ 0x61EEFA0C)) is DBNull)) ? ((string)eaFcfab61J9ujUHrXSqd(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822814036))) : string.Empty);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									iicWcFb631kkH0vXckI8(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x1FFEF86A ^ 0x1FFFADC4)) is DBNull)) ? ((DateTime)eaFcfab61J9ujUHrXSqd(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538473032))) : DateTime.MinValue);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num5 = 0;
									}
									continue;
								default:
									D7Uloab6a98m2WFtyUao(metadataItemGroupDTO3, !(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0xD3DEF7E ^ 0xD3F19B0)) is DBNull) && R5LU1ub6pfYmChanuWI2(dataReader[(string)T0LsQKb6iLjUuAqgVyvp(-70007027 ^ -70176317)]));
									num5 = 10;
									continue;
								case 11:
									Uwsxutb6wElA3la1HoIM(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x66F566B6 ^ 0x66F5F680)) is DBNull)) ? dluXylb6t9rG36TFP5w7(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1F439)]) : 0);
									num5 = 8;
									continue;
								case 8:
									IDlKVbb64FrVlqP8yvEo(metadataItemGroupDTO3, (!(eaFcfab61J9ujUHrXSqd(dataReader, T0LsQKb6iLjUuAqgVyvp(0x269E5FCA ^ 0x269CA928)) is DBNull)) ? dluXylb6t9rG36TFP5w7(dataReader[(string)T0LsQKb6iLjUuAqgVyvp(0x7EC153F ^ 0x7EEE3DD)]) : 0);
									num5 = 5;
									continue;
								case 2:
									goto end_IL_0333;
								}
								break;
							}
							goto IL_0322;
							continue;
							end_IL_0333:
							break;
						}
					}
					finally
					{
						int num6;
						if (dataReader == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num6 = 0;
							}
							goto IL_063f;
						}
						goto IL_0655;
						IL_0655:
						B1DFcrb6HpTjmDc8mU3R(dataReader);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num6 = 1;
						}
						goto IL_063f;
						IL_063f:
						switch (num6)
						{
						default:
							goto end_IL_061a;
						case 2:
							break;
						case 0:
							goto end_IL_061a;
						case 1:
							goto end_IL_061a;
						}
						goto IL_0655;
						end_IL_061a:;
					}
					goto case 7;
				case 3:
					if (service != null)
					{
						transformationProvider = (ITransformationProvider)HHYKefb6O6DPsdAlFRW6(service);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto end_IL_0012;
				case 9:
					if (transformationProvider.TableExists((string)tb0r7bb6eTkvSx466xss(TXlcVUb62GEYllXoTlrS(transformationProvider), T0LsQKb6iLjUuAqgVyvp(-1858887263 ^ -1859037393))))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 10:
					return metadataItemGroupDTO;
				case 6:
					dictionary = new Dictionary<long, MetadataItemGroupDTO>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					enumerator = dictionary.Where((KeyValuePair<long, MetadataItemGroupDTO> q) => q.Value.ParentId != 0).ToList().GetEnumerator();
					num2 = 4;
					continue;
				case 5:
					break;
				}
				metadataItemGroupDTO.SubGroups.AddRange(dictionary.Values.Where((MetadataItemGroupDTO q) => _003C_003Ec.I14w3GCwIlcxq1BehkZy(q) == 0));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	private void AddGroupNode(MetadataItemGroupDTO group, GroupNode parentNode)
	{
		//Discarded unreachable code: IL_007b, IL_008a, IL_0095, IL_013c, IL_014f, IL_015e
		int num = 6;
		int num2 = num;
		GroupNode groupNode2 = default(GroupNode);
		List<MetadataItemGroupDTO>.Enumerator enumerator = default(List<MetadataItemGroupDTO>.Enumerator);
		MetadataItemGroupDTO current = default(MetadataItemGroupDTO);
		while (true)
		{
			switch (num2)
			{
			default:
				groupNodesById[group.Id] = groupNode2;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				if (group == null)
				{
					num2 = 5;
					break;
				}
				GroupNode groupNode = new GroupNode();
				vrcMn8b6x9VJGyEYwHZV(groupNode, showDisplayName ? M41Fghb6Tw4d99r6ak3D(FjarqBb674WCYOO4se7i(group)) : group.Name);
				tJlgrBb60uR3mXevWx9Z(groupNode, group);
				groupNode2 = groupNode;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0099;
						}
						goto IL_00ed;
						IL_0099:
						while (true)
						{
							switch (num3)
							{
							case 1:
								AddGroupNode(current, groupNode2);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
								break;
							default:
								goto IL_00ed;
							case 2:
								return;
							}
							break;
						}
						continue;
						IL_00ed:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num3 = 1;
						}
						goto IL_0099;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
				parentNode.GroupNodes.Add(groupNode2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				enumerator = group.SubGroups.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 5:
				return;
			}
		}
	}

	private void AddNode(ICodeItemMetadata metadata)
	{
		//Discarded unreachable code: IL_007a, IL_00ff, IL_010e, IL_011d
		int num = 13;
		int num2 = num;
		IGroupedMetadata groupedMetadata = default(IGroupedMetadata);
		GroupNode groupNode = default(GroupNode);
		MetadataNode item = default(MetadataNode);
		GroupNode value = default(GroupNode);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (groupedMetadata != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 2;
			case 7:
				if (jCbDnPb6ypDDMAhIFam5(groupedMetadata) <= 0)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			default:
				groupNode.MetadataNodes.Add(item);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 5:
				groupedMetadata = metadata as IGroupedMetadata;
				num2 = 6;
				break;
			case 4:
				if (!groupNodesById.TryGetValue(jCbDnPb6ypDDMAhIFam5(groupedMetadata), out value))
				{
					num2 = 11;
					break;
				}
				goto case 1;
			case 12:
				groupNode = root;
				num2 = 5;
				break;
			case 2:
			case 8:
				groupNode = GetGroupByNamespace(metadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 9;
				}
				break;
			case 1:
				groupNode = value;
				num2 = 10;
				break;
			case 13:
				Jyn93qb6miLc2J9s2jKp(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521251458));
				num2 = 12;
				break;
			case 9:
			case 10:
			case 11:
				item = new MetadataNode
				{
					Name = (string)(showDisplayName ? ((metadataService != null) ? AkDvHcb69I01gsoOd9oP(metadataService, metadata) : VxORYkb6JUAk9Xg5fQd9(metadata)) : FrwbYtb6M2UyWIHW6TcZ(metadata)),
					Metadata = metadata
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private GroupNode GetGroupByNamespace(ICodeItemMetadata metadata)
	{
		//Discarded unreachable code: IL_00f5, IL_0104, IL_01f5, IL_0227, IL_0236, IL_028a, IL_0299, IL_03c3, IL_03d2, IL_0402, IL_0426, IL_0468, IL_04ca, IL_04d9
		int num = 11;
		GroupNode groupNode = default(GroupNode);
		GroupNode groupNode2 = default(GroupNode);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_2 = default(_003C_003Ec__DisplayClass20_0);
		string text5 = default(string);
		string text3 = default(string);
		_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_1);
		int i = default(int);
		string[] array = default(string[]);
		string text4 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				string text2;
				switch (num2)
				{
				case 5:
				case 12:
					groupNode = groupNode2;
					num2 = 22;
					continue;
				case 33:
					_003C_003Ec__DisplayClass20_2.namespaceBlocks = (string[])Ye6aCmb65pogp9c3MJBG(text5, oOIf4sb6guUqIalolheN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710577138)), StringSplitOptions.RemoveEmptyEntries);
					num2 = 20;
					continue;
				case 35:
					text3 += (string)T0LsQKb6iLjUuAqgVyvp(-521266112 ^ -521271676);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 28;
					}
					continue;
				case 32:
					if (_003C_003Ec__DisplayClass20_2.namespaceBlocks.Length == 0)
					{
						num2 = 9;
						continue;
					}
					goto case 31;
				case 2:
				case 6:
					groupNode2 = groupNode.GroupNodes.FirstOrDefault(_003C_003Ec__DisplayClass20_._003CGetGroupByNamespace_003Eb__0);
					num2 = 26;
					continue;
				case 4:
					text3 = "";
					num2 = 32;
					continue;
				case 25:
				{
					GroupNode groupNode3 = new GroupNode();
					vrcMn8b6x9VJGyEYwHZV(groupNode3, _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.namespaceBlocks[_003C_003Ec__DisplayClass20_.i]);
					TeErLbb6Y1mRIOhebn6B(groupNode3, text3);
					groupNode2 = groupNode3;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 10:
					groupNode = root;
					num2 = 13;
					continue;
				case 18:
					obj = metadata.NamespaceForDisplay;
					goto IL_04ea;
				case 24:
					if (generateForPublicApi)
					{
						num2 = 3;
						continue;
					}
					goto case 18;
				case 37:
					_003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass20_2;
					num2 = 17;
					continue;
				case 27:
					if (groupNode2.MetadataItemNamespaces.Contains((string)UbiZsVb6lNgxGP5PNZlI(metadata)))
					{
						num2 = 12;
						continue;
					}
					goto case 8;
				case 17:
					_003C_003Ec__DisplayClass20_.i = 0;
					num2 = 34;
					continue;
				case 31:
					_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_1();
					num2 = 37;
					continue;
				case 13:
					if (!Bvjhj5b6dXUtPabkMIpM(metadata.NamespaceForDisplay))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 3;
				case 22:
					i = _003C_003Ec__DisplayClass20_.i;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 16;
					}
					continue;
				case 20:
					array = (string[])Ye6aCmb65pogp9c3MJBG(text4, oOIf4sb6guUqIalolheN(T0LsQKb6iLjUuAqgVyvp(-1870892489 ^ -1870894861)), StringSplitOptions.RemoveEmptyEntries);
					num2 = 4;
					continue;
				case 26:
					if (_003C_003Ec__DisplayClass20_.i < array.Length)
					{
						num = 14;
						break;
					}
					goto case 36;
				case 36:
					if (groupNode2 == null)
					{
						num2 = 25;
						continue;
					}
					goto case 30;
				case 29:
				case 34:
					if (_003C_003Ec__DisplayClass20_.i <= _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.namespaceBlocks.Length - 1)
					{
						num2 = 6;
						continue;
					}
					goto case 9;
				case 30:
					if (_003C_003Ec__DisplayClass20_.i == _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.namespaceBlocks.Length - 1)
					{
						num2 = 27;
						continue;
					}
					goto case 5;
				case 7:
					text4 = (string)Hu9789b6rsx9R7RmkCny(text);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 21;
					}
					continue;
				case 9:
				case 19:
					return groupNode;
				case 15:
				case 28:
					text3 += array[_003C_003Ec__DisplayClass20_.i];
					num2 = 36;
					continue;
				case 16:
					_003C_003Ec__DisplayClass20_.i = i + 1;
					num2 = 29;
					continue;
				case 11:
					_003C_003Ec__DisplayClass20_2 = new _003C_003Ec__DisplayClass20_0();
					num2 = 10;
					continue;
				case 8:
					groupNode2.MetadataItemNamespaces.Add((string)UbiZsVb6lNgxGP5PNZlI(metadata));
					num = 5;
					break;
				case 23:
					text2 = text4;
					goto IL_050d;
				case 21:
					if (showDisplayName)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 23;
				default:
					groupNode.GroupNodes.Add(groupNode2);
					num2 = 30;
					continue;
				case 14:
					if (!SiGbdXb6jgHoDIOxHSaQ(text3, ""))
					{
						num2 = 15;
						continue;
					}
					goto case 35;
				case 3:
					obj = UbiZsVb6lNgxGP5PNZlI(metadata);
					goto IL_04ea;
				case 1:
					{
						text2 = ModelHelper.GetNamespaceDisplayName(text);
						goto IL_050d;
					}
					IL_050d:
					text5 = text2;
					num2 = 33;
					continue;
					IL_04ea:
					text = (string)obj;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	private void RemoveEmptyGroups(GroupNode parent)
	{
		//Discarded unreachable code: IL_003b, IL_004a, IL_0055, IL_00f0, IL_0103, IL_0112, IL_016e, IL_0178, IL_0229, IL_0295, IL_02a8
		int num = 3;
		int num2 = num;
		List<GroupNode>.Enumerator enumerator = default(List<GroupNode>.Enumerator);
		GroupNode current2 = default(GroupNode);
		List<GroupNode> list = default(List<GroupNode>);
		GroupNode current = default(GroupNode);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_0086:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 2;
							goto IL_0059;
						}
						goto IL_0073;
						IL_0059:
						while (true)
						{
							switch (num5)
							{
							case 2:
								return;
							case 1:
								break;
							default:
								goto IL_0086;
							case 3:
								parent.GroupNodes.Remove(current2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_0073;
						IL_0073:
						current2 = enumerator.Current;
						num5 = 3;
						goto IL_0059;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 2:
				enumerator = parent.GroupNodes.GetEnumerator();
				num2 = 4;
				break;
			case 5:
				enumerator = list.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				list = new List<GroupNode>();
				num2 = 2;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num3 = 1;
							}
							goto IL_017c;
						}
						goto IL_01cc;
						IL_01cc:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num3 = 0;
						}
						goto IL_017c;
						IL_017c:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 7:
								break;
							case 2:
								goto IL_01cc;
							case 5:
								list.Add(current);
								num3 = 6;
								continue;
							default:
								RemoveEmptyGroups(current);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num3 = 3;
								}
								continue;
							case 4:
								if (rowtIKb6LjP4uBrYWVF6(current.MetadataNodes) != 0)
								{
									num3 = 7;
									continue;
								}
								goto case 5;
							case 3:
								if (current.GroupNodes.Count == 0)
								{
									num3 = 4;
									continue;
								}
								break;
							case 1:
								goto end_IL_01a6;
							}
							break;
						}
						continue;
						end_IL_01a6:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			}
		}
	}

	private void ResortNodes(GroupNode parent)
	{
		//Discarded unreachable code: IL_0037, IL_0046, IL_0051, IL_00f6, IL_0109
		int num = 4;
		int num2 = num;
		List<GroupNode>.Enumerator enumerator = default(List<GroupNode>.Enumerator);
		GroupNode current = default(GroupNode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				try
				{
					while (true)
					{
						IL_0081:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 0;
							}
							goto IL_0055;
						}
						goto IL_00a7;
						IL_00a7:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num3 = 3;
						}
						goto IL_0055;
						IL_0055:
						while (true)
						{
							switch (num3)
							{
							case 3:
								ResortNodes(current);
								num3 = 2;
								continue;
							case 2:
								goto IL_0081;
							case 1:
								goto IL_00a7;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 3:
				enumerator = parent.GroupNodes.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				parent.GroupNodes = (from g in parent.GroupNodes
					where !_003C_003Ec.CfOTcOCwSdP0Fm99S9W7(_003C_003Ec.YZ9LxICwVJcBIjLvYybI(g))
					orderby (string)_003C_003Ec.qbki92CwiTgjpjqGj2py(_003C_003Ec.YZ9LxICwVJcBIjLvYybI(g))
					select g).ToList();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				break;
			}
			parent.MetadataNodes = (from g in parent.MetadataNodes
				where !_003C_003Ec.CfOTcOCwSdP0Fm99S9W7(_003C_003Ec.YZ9LxICwVJcBIjLvYybI(g))
				orderby (string)_003C_003Ec.qbki92CwiTgjpjqGj2py(_003C_003Ec.YZ9LxICwVJcBIjLvYybI(g))
				select g).ToList();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object Q7OPTIb68IuX29DjSTN9(object P_0)
	{
		return ((GroupNode)P_0).Namespace;
	}

	internal static bool t5iqiUb6ZvZH4yotnwoP(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static bool L2lcvlb6uETDBuW5IyCV(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object HsWbDPb6IRarxbP3FhNp(object P_0)
	{
		return ((GroupNode)P_0).Group;
	}

	internal static object fcqGknb6VYSe3wtqEGLK(object P_0)
	{
		return ((MetadataItemGroupDTO)P_0).Name;
	}

	internal static bool WbNrA3b6CuxIx7SyJ16Y()
	{
		return lAPclcb6QU7uaVlojpFD == null;
	}

	internal static MetadataTreeHelper sNqUcpb6vySm7AkoE2lq()
	{
		return lAPclcb6QU7uaVlojpFD;
	}

	internal static bool hbhW8Kb6S8R6e4AUO1Dq()
	{
		return Locator.Initialized;
	}

	internal static object T0LsQKb6iLjUuAqgVyvp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime QpMsfMb6RUA3PBwyYF2y()
	{
		return DateTime.Now;
	}

	internal static bool UMDIsab6qeRjxq7OmmcC(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 <= P_1;
	}

	internal static object uwUJB6b6KNdI8YvtMAQK(object P_0)
	{
		return ((IMetadataItemGroupDTOManager)P_0).LoadRootGroup();
	}

	internal static void gmshasb6X3Ao2ifslbZg(object P_0, object P_1)
	{
		CallContext.SetData((string)P_0, P_1);
	}

	internal static object M41Fghb6Tw4d99r6ak3D(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void l3syMBb6kyOKURtgOKRg(object P_0, object P_1)
	{
		((MetadataItemGroupDTO)P_0).Name = (string)P_1;
	}

	internal static void mNTK6Bb6ndZmhDyyc5U2(object P_0, object P_1)
	{
		((MetadataItemGroupDTO)P_0).DisplayName = (string)P_1;
	}

	internal static object HHYKefb6O6DPsdAlFRW6(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object TXlcVUb62GEYllXoTlrS(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object tb0r7bb6eTkvSx466xss(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object SxxMwGb6PIqRYO28uPbS(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object eaFcfab61J9ujUHrXSqd(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static void ansQqob6N8iZOodqMA0f(object P_0, object P_1)
	{
		((MetadataItemGroupDTO)P_0).Namespace = (string)P_1;
	}

	internal static void iicWcFb631kkH0vXckI8(object P_0, DateTime value)
	{
		((MetadataItemGroupDTO)P_0).CreationDate = value;
	}

	internal static bool R5LU1ub6pfYmChanuWI2(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	internal static void D7Uloab6a98m2WFtyUao(object P_0, bool value)
	{
		((MetadataItemGroupDTO)P_0).IsSystem = value;
	}

	internal static Guid yfWnnYb6DrAgBs0N7qI8(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static long dluXylb6t9rG36TFP5w7(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void Uwsxutb6wElA3la1HoIM(object P_0, long value)
	{
		((MetadataItemGroupDTO)P_0).ParentId = value;
	}

	internal static void IDlKVbb64FrVlqP8yvEo(object P_0, long value)
	{
		((MetadataItemGroupDTO)P_0).CreationAuthorId = value;
	}

	internal static bool ARY4kBb66B7r52TwRTNr(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void B1DFcrb6HpTjmDc8mU3R(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static long kWpMlTb6AWtX7tS8nA4E(object P_0)
	{
		return ((MetadataItemGroupDTO)P_0).ParentId;
	}

	internal static object FjarqBb674WCYOO4se7i(object P_0)
	{
		return ((MetadataItemGroupDTO)P_0).DisplayName;
	}

	internal static void vrcMn8b6x9VJGyEYwHZV(object P_0, object P_1)
	{
		((Node)P_0).Name = (string)P_1;
	}

	internal static void tJlgrBb60uR3mXevWx9Z(object P_0, object P_1)
	{
		((GroupNode)P_0).Group = (MetadataItemGroupDTO)P_1;
	}

	internal static void Jyn93qb6miLc2J9s2jKp(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static long jCbDnPb6ypDDMAhIFam5(object P_0)
	{
		return ((IGroupedMetadata)P_0).GroupId;
	}

	internal static object FrwbYtb6M2UyWIHW6TcZ(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Name;
	}

	internal static object VxORYkb6JUAk9Xg5fQd9(object P_0)
	{
		return ((ICodeItemMetadata)P_0).GetDisplayName();
	}

	internal static object AkDvHcb69I01gsoOd9oP(object P_0, object P_1)
	{
		return ((IMetadataService)P_0).GetDisplayName((ICodeItemMetadata)P_1);
	}

	internal static bool Bvjhj5b6dXUtPabkMIpM(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object UbiZsVb6lNgxGP5PNZlI(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Namespace;
	}

	internal static object Hu9789b6rsx9R7RmkCny(object P_0)
	{
		return ModelHelper.GetNamespaceShortName((string)P_0);
	}

	internal static object oOIf4sb6guUqIalolheN(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object Ye6aCmb65pogp9c3MJBG(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static bool SiGbdXb6jgHoDIOxHSaQ(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void TeErLbb6Y1mRIOhebn6B(object P_0, object P_1)
	{
		((GroupNode)P_0).Namespace = (string)P_1;
	}

	internal static int rowtIKb6LjP4uBrYWVF6(object P_0)
	{
		return ((List<MetadataNode>)P_0).Count;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata.DTO.Managers;

namespace EleWise.ELMA.Model.Metadata;

public class MetadataTreeHelper
{
	public abstract class Node
	{
		private string _003CName_003Ek__BackingField;

		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}
	}

	public class GroupNode : Node
	{
		private MetadataItemGroup _003CGroup_003Ek__BackingField;

		private string _003CNamespace_003Ek__BackingField;

		private System.Collections.Generic.ICollection<MetadataNode> _003CMetadataNodes_003Ek__BackingField;

		private System.Collections.Generic.ICollection<GroupNode> _003CGroupNodes_003Ek__BackingField;

		public MetadataItemGroup Group
		{
			get
			{
				return _003CGroup_003Ek__BackingField;
			}
			set
			{
				_003CGroup_003Ek__BackingField = value;
			}
		}

		public string Namespace
		{
			get
			{
				return _003CNamespace_003Ek__BackingField;
			}
			set
			{
				_003CNamespace_003Ek__BackingField = value;
			}
		}

		public System.Collections.Generic.ICollection<MetadataNode> MetadataNodes
		{
			get
			{
				return _003CMetadataNodes_003Ek__BackingField;
			}
			set
			{
				_003CMetadataNodes_003Ek__BackingField = value;
			}
		}

		public System.Collections.Generic.ICollection<GroupNode> GroupNodes
		{
			get
			{
				return _003CGroupNodes_003Ek__BackingField;
			}
			set
			{
				_003CGroupNodes_003Ek__BackingField = value;
			}
		}

		public GroupNode()
		{
			MetadataNodes = new ReactiveCollection<MetadataNode>();
			GroupNodes = new ReactiveCollection<GroupNode>();
		}
	}

	public class MetadataNode : Node
	{
		private MetadataHeader _003CMetadata_003Ek__BackingField;

		public MetadataHeader Metadata
		{
			get
			{
				return _003CMetadata_003Ek__BackingField;
			}
			set
			{
				_003CMetadata_003Ek__BackingField = value;
			}
		}
	}

	[StructLayout(3)]
	private struct _003CBuildTreeImpl_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<GroupNode> _003C_003Et__builder;

		public MetadataTreeHelper _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataTreeHelper metadataTreeHelper = _003C_003E4__this;
			GroupNode root;
			try
			{
				TaskAwaiter<MetadataItemGroup> val;
				if (num != 0)
				{
					metadataTreeHelper.root = new GroupNode();
					metadataTreeHelper.groupNodesById.Clear();
					val = metadataTreeHelper.MetadataItemGroupManager.LoadRootGroup().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<MetadataItemGroup>, _003CBuildTreeImpl_003Ed__13>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<MetadataItemGroup>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				MetadataItemGroup result = val.GetResult();
				if (result != null)
				{
					System.Collections.Generic.IEnumerator<MetadataItemGroup> enumerator = ((System.Collections.Generic.IEnumerable<MetadataItemGroup>)result.get_SubGroups()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							MetadataItemGroup current = enumerator.get_Current();
							metadataTreeHelper.AddGroupNode(current, metadataTreeHelper.root);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
				}
				System.Collections.Generic.IEnumerator<MetadataHeader> enumerator2 = metadataTreeHelper.metadataList.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						MetadataHeader current2 = enumerator2.get_Current();
						metadataTreeHelper.AddNode(current2);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
				}
				if (!metadataTreeHelper.showEmptyGroups)
				{
					metadataTreeHelper.RemoveEmptyGroups(metadataTreeHelper.root);
				}
				metadataTreeHelper.ResortNodes(metadataTreeHelper.root);
				root = metadataTreeHelper.root;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(root);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string[] namespaceBlocks;
	}

	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public int i;

		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		internal bool _003CGetGroupByNamespace_003Eb__0(GroupNode n)
		{
			return n.Name == CS_0024_003C_003E8__locals1.namespaceBlocks[i];
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GroupNode, bool> _003C_003E9__18_0;

		public static Func<GroupNode, string> _003C_003E9__18_1;

		public static Func<MetadataNode, bool> _003C_003E9__18_2;

		public static Func<MetadataNode, string> _003C_003E9__18_3;

		internal bool _003CResortNodes_003Eb__18_0(GroupNode g)
		{
			return !string.IsNullOrEmpty(g.Name);
		}

		internal string _003CResortNodes_003Eb__18_1(GroupNode g)
		{
			return g.Name.ToLower();
		}

		internal bool _003CResortNodes_003Eb__18_2(MetadataNode g)
		{
			return !string.IsNullOrEmpty(g.Name);
		}

		internal string _003CResortNodes_003Eb__18_3(MetadataNode g)
		{
			return g.Name.ToLower();
		}
	}

	private readonly IMetadataServiceContext metadataService;

	private readonly MetadataItemGroupManager MetadataItemGroupManager;

	private System.Collections.Generic.IEnumerable<MetadataHeader> metadataList;

	private GroupNode root;

	private bool showDisplayName;

	private bool showEmptyGroups;

	private bool generateForPublicApi;

	private Dictionary<long, GroupNode> groupNodesById = new Dictionary<long, GroupNode>();

	public static System.Threading.Tasks.Task<GroupNode> BuildTree(System.Collections.Generic.IEnumerable<MetadataHeader> metadataList, MetadataItemGroupManager metadataItemGroupManager, IMetadataServiceContext metadataService, bool showDisplayName = true, bool showEmptyGroups = false, bool generateForPublicApi = false)
	{
		if (metadataList == null)
		{
			throw new System.Exception();
		}
		return new MetadataTreeHelper(metadataList, metadataItemGroupManager, metadataService)
		{
			showDisplayName = showDisplayName,
			showEmptyGroups = showEmptyGroups,
			generateForPublicApi = generateForPublicApi
		}.BuildTreeImpl();
	}

	private MetadataTreeHelper(System.Collections.Generic.IEnumerable<MetadataHeader> metadataList, MetadataItemGroupManager MetadataItemGroupManager, IMetadataServiceContext metadataService)
	{
		this.metadataList = metadataList;
		this.metadataService = metadataService;
		this.MetadataItemGroupManager = MetadataItemGroupManager;
	}

	private System.Threading.Tasks.Task<GroupNode> BuildTreeImpl()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CBuildTreeImpl_003Ed__13 _003CBuildTreeImpl_003Ed__ = default(_003CBuildTreeImpl_003Ed__13);
		_003CBuildTreeImpl_003Ed__._003C_003E4__this = this;
		_003CBuildTreeImpl_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<GroupNode>.Create();
		_003CBuildTreeImpl_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<GroupNode> _003C_003Et__builder = _003CBuildTreeImpl_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CBuildTreeImpl_003Ed__13>(ref _003CBuildTreeImpl_003Ed__);
		return _003CBuildTreeImpl_003Ed__._003C_003Et__builder.get_Task();
	}

	private void AddGroupNode(MetadataItemGroup group, GroupNode parentNode)
	{
		if (group == null)
		{
			return;
		}
		GroupNode groupNode = new GroupNode
		{
			Name = (showDisplayName ? SR.T(group.get_DisplayName()) : group.get_Name()),
			Group = group
		};
		groupNodesById.set_Item(group.get_Id(), groupNode);
		parentNode.GroupNodes.Add(groupNode);
		System.Collections.Generic.IEnumerator<MetadataItemGroup> enumerator = ((System.Collections.Generic.IEnumerable<MetadataItemGroup>)group.get_SubGroups()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				MetadataItemGroup current = enumerator.get_Current();
				AddGroupNode(current, groupNode);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void AddNode(MetadataHeader metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		GroupNode groupNode = root;
		if (metadata.get_GroupId() > 0)
		{
			GroupNode groupNode2 = default(GroupNode);
			if (groupNodesById.TryGetValue(metadata.get_GroupId(), ref groupNode2))
			{
				groupNode = groupNode2;
			}
		}
		else
		{
			groupNode = GetGroupByNamespace(metadata);
		}
		MetadataNode metadataNode = new MetadataNode
		{
			Name = (showDisplayName ? metadata.get_DisplayName() : metadata.get_Name()),
			Metadata = metadata
		};
		groupNode.MetadataNodes.Add(metadataNode);
	}

	private GroupNode GetGroupByNamespace(MetadataHeader metadata)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		GroupNode groupNode = root;
		string ns = ((metadata.get_NamespaceForDisplay().IsNullOrWhiteSpace() || generateForPublicApi) ? metadata.get_Namespace() : metadata.get_NamespaceForDisplay());
		string namespaceShortName = ModelHelper.GetNamespaceShortName(ns, metadataService);
		string text = (showDisplayName ? ModelHelper.GetNamespaceDisplayName(ns, metadataService) : namespaceShortName);
		_003C_003Ec__DisplayClass16_.namespaceBlocks = text.Split(".".ToCharArray(), (StringSplitOptions)1);
		string[] array = namespaceShortName.Split(".".ToCharArray(), (StringSplitOptions)1);
		string text2 = "";
		if (_003C_003Ec__DisplayClass16_.namespaceBlocks.Length == 0)
		{
			return groupNode;
		}
		_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_1();
		CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass16_;
		CS_0024_003C_003E8__locals0.i = 0;
		while (CS_0024_003C_003E8__locals0.i <= CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.namespaceBlocks.Length - 1)
		{
			GroupNode groupNode2 = Enumerable.FirstOrDefault<GroupNode>((System.Collections.Generic.IEnumerable<GroupNode>)groupNode.GroupNodes, (Func<GroupNode, bool>)((GroupNode n) => n.Name == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.namespaceBlocks[CS_0024_003C_003E8__locals0.i]));
			if (CS_0024_003C_003E8__locals0.i < array.Length)
			{
				if (text2 != "")
				{
					text2 += ".";
				}
				text2 += array[CS_0024_003C_003E8__locals0.i];
			}
			if (groupNode2 == null)
			{
				groupNode2 = new GroupNode
				{
					Name = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.namespaceBlocks[CS_0024_003C_003E8__locals0.i],
					Namespace = text2
				};
				groupNode.GroupNodes.Add(groupNode2);
			}
			groupNode = groupNode2;
			CS_0024_003C_003E8__locals0.i++;
		}
		return groupNode;
	}

	private void RemoveEmptyGroups(GroupNode parent)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		List<GroupNode> val = new List<GroupNode>();
		System.Collections.Generic.IEnumerator<GroupNode> enumerator = ((System.Collections.Generic.IEnumerable<GroupNode>)parent.GroupNodes).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GroupNode current = enumerator.get_Current();
				RemoveEmptyGroups(current);
				if (current.GroupNodes.get_Count() == 0 && current.MetadataNodes.get_Count() == 0)
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		Enumerator<GroupNode> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				GroupNode current2 = enumerator2.get_Current();
				parent.GroupNodes.Remove(current2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	private void ResortNodes(GroupNode parent)
	{
		parent.GroupNodes = (System.Collections.Generic.ICollection<GroupNode>)((EnumerableInstance<GroupNode>)(object)Enumerable.Where<GroupNode>((System.Collections.Generic.IEnumerable<GroupNode>)parent.GroupNodes, (Func<GroupNode, bool>)((GroupNode g) => !string.IsNullOrEmpty(g.Name))).OrderBy<string>((Func<GroupNode, string>)((GroupNode g) => g.Name.ToLower()))).ToList();
		System.Collections.Generic.IEnumerator<GroupNode> enumerator = ((System.Collections.Generic.IEnumerable<GroupNode>)parent.GroupNodes).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GroupNode current = enumerator.get_Current();
				ResortNodes(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		parent.MetadataNodes = (System.Collections.Generic.ICollection<MetadataNode>)((EnumerableInstance<MetadataNode>)(object)Enumerable.Where<MetadataNode>((System.Collections.Generic.IEnumerable<MetadataNode>)parent.MetadataNodes, (Func<MetadataNode, bool>)((MetadataNode g) => !string.IsNullOrEmpty(g.Name))).OrderBy<string>((Func<MetadataNode, string>)((MetadataNode g) => g.Name.ToLower()))).ToList();
	}
}

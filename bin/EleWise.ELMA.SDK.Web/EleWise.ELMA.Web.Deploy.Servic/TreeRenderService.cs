using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.Web.Deploy.Services;

[Service(Type = ComponentType.WebServer, Scope = ServiceScope.Shell)]
internal sealed class TreeRenderService : ITreeRenderService
{
	private IDeployTreeBuilderService deployTreeBuilderService;

	public TreeRenderService(IDeployTreeBuilderService deployTreeBuilderService)
	{
		this.deployTreeBuilderService = deployTreeBuilderService;
	}

	public TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest)
	{
		return BuildConfigurationTree(manifest, expanded: false);
	}

	public TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, bool expanded)
	{
		return BuildConfigurationTree(manifest, manifest?.TreeUid ?? Guid.NewGuid().ToString(), expanded);
	}

	public TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, string id, bool expanded)
	{
		return BuildConfigurationTree(manifest, id, manifest.DisplayName, expanded);
	}

	public TreeModel BuildConfigurationTree(BPMAppFakeManifest manifest, string id, string title, bool expanded)
	{
		DeployTreeModel deployTreeModel = deployTreeBuilderService.BuildTree(manifest, id, title);
		return new TreeModel
		{
			Id = id,
			Children = new List<TreeMenuNode>(CreateNodes(deployTreeModel.Children, expanded)),
			HtmlAttributes = new
			{
				style = "width:100%;"
			},
			ShowExpandCollapseButtons = true,
			ShowCheckBox = false,
			HighlightPath = false
		};
	}

	private List<TreeMenuNode> CreateNodes(IEnumerable<DeployTreeNode> children, bool expanded)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		foreach (DeployTreeNode child in children)
		{
			TreeMenuNode treeMenuNode = new TreeMenuNode();
			treeMenuNode.id = child.Id.ToLower();
			treeMenuNode.text = ((child.Count > 0) ? $"{child.Text} ({child.Count})" : child.Text);
			treeMenuNode.icon = (string.IsNullOrWhiteSpace(child.Icon) ? null : ("#" + child.Icon + ".svg"));
			treeMenuNode.Checked = false;
			treeMenuNode.checkable = false;
			treeMenuNode.children = CreateNodes(child.Children, expanded);
			treeMenuNode.expanded = expanded;
			treeMenuNode.HtmlClass = new List<string>();
			treeMenuNode.HtmlClass.Add("tree-deploy-default");
			list.Add(treeMenuNode);
		}
		return list;
	}
}

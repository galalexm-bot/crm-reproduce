using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.BPMApps;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 550)]
internal sealed class ComponentsAndUIFormsChapterBuilder : BPMAppChapterBuilder
{
	private readonly IEntityManager<ComponentMetadataItemHeader, long> componentManager;

	private readonly FormMetadataItemHeaderManager formMetadataManager;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(ComponentExportConsts.ExportExtensionUid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17A8C5BE)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889512002)),
		new BPMAppChapterBuilderTemplate(UIFormExportConsts.ExportExtensionUidPage, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC3B85)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882179850)),
		new BPMAppChapterBuilderTemplate(UIFormExportConsts.ExportExtensionUidPortlet, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECB5A74)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53C7D37))
	};

	public ComponentsAndUIFormsChapterBuilder(IEntityManager<ComponentMetadataItemHeader, long> componentManager, FormMetadataItemHeaderManager formMetadataManager)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.componentManager = componentManager;
		this.formMetadataManager = formMetadataManager;
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710567732));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = ComponentExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951320448)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146311503));
		exportExtensionUid = UIFormExportConsts.ExportExtensionUidPage;
		DeployTreeNode deployTreeNode2 = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088297630)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765806914));
		exportExtensionUid = UIFormExportConsts.ExportExtensionUidPortlet;
		DeployTreeNode deployTreeNode3 = CreateNode(exportExtensionUid.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269B56B4)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138914196));
		ComponentBAChapter componentBAChapter = manifest.GetChapter(ComponentExportConsts.ExportExtensionUid) as ComponentBAChapter;
		UIFormsBAChapter uIFormsBAChapter = manifest.GetChapter(UIFormExportConsts.ExportExtensionUid) as UIFormsBAChapter;
		if ((componentBAChapter == null || componentBAChapter.Components == null || componentBAChapter.Components.Count == 0) && (uIFormsBAChapter == null || uIFormsBAChapter.Forms == null || uIFormsBAChapter.Forms.Count == 0))
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
				list.Add(deployTreeNode2);
				list.Add(deployTreeNode3);
			}
			return list;
		}
		List<DeployTreeNode> list2 = new List<DeployTreeNode>();
		List<DeployTreeNode> list3 = new List<DeployTreeNode>();
		List<DeployTreeNode> list4 = new List<DeployTreeNode>();
		GetNodesUIForm(uIFormsBAChapter, list2, list3);
		GetNodes(componentBAChapter, list2, list3, list4);
		if (parameters.WithEmptyChapters || list2.Count > 0)
		{
			deployTreeNode2.Children.AddRange(list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.B2gb3e8yW3EXhZL2Nj8P(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode2.Count = deployTreeNode2.Children.Count;
			list.Add(deployTreeNode2);
		}
		if (parameters.WithEmptyChapters || list3.Count > 0)
		{
			deployTreeNode3.Children.AddRange(list3.OrderBy((DeployTreeNode n) => n.Text, StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode3.Count = deployTreeNode3.Children.Count;
			list.Add(deployTreeNode3);
		}
		if (parameters.WithEmptyChapters || list4.Count > 0)
		{
			deployTreeNode.Children.AddRange(list4.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.B2gb3e8yW3EXhZL2Nj8P(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	private void GetNodesUIForm(UIFormsBAChapter formsChapter, List<DeployTreeNode> pageNodes, List<DeployTreeNode> portletNodes)
	{
		if (formsChapter?.Forms == null)
		{
			return;
		}
		foreach (UIFormBAItem form in formsChapter.Forms)
		{
			IFormMetadataItemHeader formMetadataItemHeader = formMetadataManager.LoadOrNull(form.Uid);
			if (formMetadataItemHeader != null)
			{
				if (formMetadataItemHeader.MetadataType == PageMetadata.TypeUid)
				{
					pageNodes.Add(CreateNode(form.Uid.ToString(), formMetadataItemHeader.DisplayName, ""));
				}
				else if (formMetadataItemHeader.MetadataType == PortletMetadata.TypeUid)
				{
					portletNodes.Add(CreateNode(form.Uid.ToString(), formMetadataItemHeader.DisplayName, ""));
				}
			}
		}
	}

	private void GetNodes(ComponentBAChapter componentsChapter, List<DeployTreeNode> pageNodes, List<DeployTreeNode> portletNodes, List<DeployTreeNode> componentNodes)
	{
		if (componentsChapter?.Components == null)
		{
			return;
		}
		foreach (ComponentBAItem component in componentsChapter.Components)
		{
			try
			{
				ComponentMetadataItemHeader componentMetadataItemHeader = componentManager.LoadOrNull(component.Uid);
				if (componentMetadataItemHeader != null)
				{
					if (componentMetadataItemHeader.MetadataTypeUid == PageComponentMetadata.TypeUid)
					{
						pageNodes.Add(CreateNode(component.Uid.ToString(), componentMetadataItemHeader.DisplayName, ""));
					}
					else if (componentMetadataItemHeader.MetadataTypeUid == PortletComponentMetadata.TypeUid)
					{
						portletNodes.Add(CreateNode(component.Uid.ToString(), componentMetadataItemHeader.DisplayName, ""));
					}
					else
					{
						componentNodes.Add(CreateNode(component.Uid.ToString(), componentMetadataItemHeader.DisplayName, ""));
					}
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487058484) + component.Uid, exception);
			}
		}
	}
}

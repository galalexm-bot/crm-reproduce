using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.ViewItems;

[Serializable]
[ViewItemMetadata(Type = typeof(IWorkflowTask))]
[DisplayName(typeof(__Resources_ContextDefaultContainerViewItem), "DisplayName")]
public class ContextDefaultContainerViewItem : DefaultContainerViewItem
{
	[Component(Order = 500)]
	private class ToolboxItem : WorkflowViewItemToolboxItem<ContextDefaultContainerViewItem>
	{
		private static object kcEb4MZRccNQld5B2ZiT;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JIL1r9ZRdaghscETkOvr();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void JIL1r9ZRdaghscETkOvr()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool jCygrVZRPeIYPyv9bG9c()
		{
			return kcEb4MZRccNQld5B2ZiT == null;
		}

		internal static ToolboxItem k0FZsjZRX6ZKeQB5nlmR()
		{
			return (ToolboxItem)kcEb4MZRccNQld5B2ZiT;
		}
	}

	public new static readonly Guid ItemUid;

	private static ContextDefaultContainerViewItem QfYpn2g56dUNvpwtiZj;

	public override Guid Uid
	{
		get
		{
			return ItemUid;
		}
		set
		{
		}
	}

	public override int CheckPropertyAddOrder => 1;

	public override bool CheckPropertyAdd(ClassMetadata metadata)
	{
		return metadata is ProcessContext;
	}

	public override PropertyViewItem CreatePropertyViewItem()
	{
		return new ContextPropertyViewItem();
	}

	public override IEnumerable<PropertyViewItem> NotIncludedProperies(FormViewItem formViewItem, ViewType viewType, ItemType itemType, object entity)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.task = entity as IWorkflowTaskBase;
		if (CS_0024_003C_003E8__locals0.task == null || CS_0024_003C_003E8__locals0.task.WorkflowBookmark == null || CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance == null)
		{
			return new PropertyViewItem[0];
		}
		ClassMetadata metadata = MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Context.GetType()) as ClassMetadata;
		UserTaskElement userTaskElement = ((CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Process != null && CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Process.Diagram != null && CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Process.Diagram.Elements != null) ? (CS_0024_003C_003E8__locals0.task.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			//Discarded unreachable code: IL_00a9
			int num = 2;
			int num2 = num;
			Guid? elementUid = default(Guid?);
			Guid guid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (elementUid.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 1:
					elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass9_0.tttobKZRfOUSQLJyC9f1(CS_0024_003C_003E8__locals0.task)).ElementUid;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					guid = _003C_003Ec__DisplayClass9_0.aGOcVNZRLWpUcPhfTQHC(e);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return false;
				default:
					return _003C_003Ec__DisplayClass9_0.aGOa0tZR97vHRB7QDcs2(guid, elementUid.GetValueOrDefault());
				}
			}
		}) as UserTaskElement) : null);
		if (userTaskElement == null)
		{
			return new PropertyViewItem[0];
		}
		return NotIncludedProperies(metadata, userTaskElement, formViewItem, null);
	}

	public static IEnumerable<PropertyViewItem> NotIncludedProperies([NotNull] ClassMetadata metadata, [NotNull] IElementWithView element, FormViewItem formViewItem, IEnumerable<IPropertyMetadata> properties)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		IContextBoundVariableService contextBoundVariableService = null;
		string text = null;
		if (Locator.Initialized && Locator.GetService<IMetadataEditorService>() != null)
		{
			text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA737338), formViewItem.Uid);
			contextBoundVariableService = Locator.GetService<IContextBoundVariableService>();
			if (contextBoundVariableService != null && contextBoundVariableService.TryGetValue<List<PropertyViewItem>>(text, out var value))
			{
				return value;
			}
		}
		if (properties == null)
		{
			properties = MetadataLoader.GetPropertiesAndTableParts(metadata);
		}
		CS_0024_003C_003E8__locals0.existsProperties = (from PropertyViewItem p in formViewItem.GetAllItems(ignoreHide: false).OfType<IContextPropertyViewItem>()
			select p.PropertyUid).ToList();
		IEnumerable<PropertyViewItem> properties2 = GetProperties((element.View != null) ? (from p in element.View.Items.OfType<PropertyViewItem>()
			where !CS_0024_003C_003E8__locals0.existsProperties.Contains(_003C_003Ec__DisplayClass10_0.HBZ0QTZRqwXL9Y8Zw9OG(p))
			select p).ToArray() : new PropertyViewItem[0], properties);
		if (contextBoundVariableService != null && text != null)
		{
			contextBoundVariableService.Set(text, properties2);
		}
		return properties2;
	}

	public static IEnumerable<PropertyViewItem> NotIncludedProperies([NotNull] ClassMetadata metadata, [NotNull] UserTaskElement element, FormViewItem formViewItem, IEnumerable<IPropertyMetadata> properties)
	{
		return NotIncludedProperies(metadata, (IElementWithView)element, formViewItem, properties);
	}

	public static IEnumerable<PropertyViewItem> GetProperties(ICollection<PropertyViewItem> newProperties, IEnumerable<IPropertyMetadata> metadataPoperties)
	{
		_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.metadataPoperties = metadataPoperties;
		CS_0024_003C_003E8__locals0.newProperties = newProperties;
		return (from p in CS_0024_003C_003E8__locals0.newProperties.Select(delegate(PropertyViewItem pvi)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
				CS_0024_003C_003E8__locals0.pvi = pvi;
				return new
				{
					propertyViewItem = CS_0024_003C_003E8__locals0.pvi,
					property = CS_0024_003C_003E8__locals0.metadataPoperties.FirstOrDefault((IPropertyMetadata p) => _003C_003Ec__DisplayClass12_1.RvGp7gZRolDcl9sb0NdZ(_003C_003Ec__DisplayClass12_1.wMMTUwZR7uCViwuF6GlL(CS_0024_003C_003E8__locals0.pvi), _003C_003Ec__DisplayClass12_1.o1HsxjZR2YbR3w3yFj7L(p)))
				};
			})
			where p.property != null
			select p).Select(p =>
		{
			ContextPropertyViewItem contextPropertyViewItem = new ContextPropertyViewItem();
			contextPropertyViewItem.FullCopyFrom(p.propertyViewItem);
			contextPropertyViewItem.Uid = p.propertyViewItem.Uid;
			if (p.property is ITablePartMetadata tablePartMetadata)
			{
				IEnumerable<IPropertyMetadata> enumerable;
				if (!(tablePartMetadata is IEntityMetadata))
				{
					IEnumerable<IPropertyMetadata> properties = tablePartMetadata.Properties;
					enumerable = properties;
				}
				else
				{
					enumerable = ((IEntityMetadata)tablePartMetadata).GetPropertiesAndTableParts();
				}
				IEnumerable<IPropertyMetadata> metadataPoperties2 = enumerable;
				GetProperties(CS_0024_003C_003E8__locals0.newProperties, metadataPoperties2).Each(contextPropertyViewItem.Items.Add);
			}
			return (PropertyViewItem)contextPropertyViewItem;
		}).ToList();
	}

	public static FormViewItemTransformation Transformation([NotNull] ClassMetadata metadata, [NotNull] IElementWithView element, FormViewItem formViewItem, IEnumerable<IPropertyMetadata> properties)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.transformation = new FormViewItemTransformation();
		ContextDefaultContainerViewItem contextDefaultContainerViewItem = formViewItem.FindItem<ContextDefaultContainerViewItem>(ItemUid);
		if (contextDefaultContainerViewItem != null && !contextDefaultContainerViewItem.Hide)
		{
			_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass13_;
			CS_0024_003C_003E8__locals0.parent = contextDefaultContainerViewItem.Parent.Uid;
			CS_0024_003C_003E8__locals0.prevItem = contextDefaultContainerViewItem.Uid;
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.transformation.Items.Add(ViewItemTransformation.Hide(contextDefaultContainerViewItem.Uid));
			NotIncludedProperies(metadata, element, formViewItem, properties).Each(delegate(PropertyViewItem p)
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.transformation.Items.Add(ViewItemTransformation.Add(CS_0024_003C_003E8__locals0.parent, p, CS_0024_003C_003E8__locals0.prevItem));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						CS_0024_003C_003E8__locals0.prevItem = p.Uid;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		if (!_003C_003Ec__DisplayClass13_.transformation.Items.Any())
		{
			return null;
		}
		return _003C_003Ec__DisplayClass13_.transformation;
	}

	public static FormViewItemTransformation Transformation([NotNull] ClassMetadata metadata, [NotNull] UserTaskElement element, FormViewItem formViewItem, IEnumerable<IPropertyMetadata> properties)
	{
		return Transformation(metadata, (IElementWithView)element, formViewItem, properties);
	}

	public ContextDefaultContainerViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PjM1lHgc8bENL5HRdXf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ContextDefaultContainerViewItem()
	{
		int num = 2;
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
				ItemUid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145F55D));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool ElGld8ggBPZihqkoAZV()
	{
		return QfYpn2g56dUNvpwtiZj == null;
	}

	internal static ContextDefaultContainerViewItem Y7KEA8gBQI2p92gxX00()
	{
		return QfYpn2g56dUNvpwtiZj;
	}

	internal static void PjM1lHgc8bENL5HRdXf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}

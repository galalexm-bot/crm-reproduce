using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class ComponentMetadataItemDTOMap : BidirectionalMap<ComponentMetadataItem, ComponentMetadataItemDTO>
{
	protected override void InitMap(IMappingExpression<ComponentMetadataItem, ComponentMetadataItemDTO> map)
	{
		base.InitMap(map);
		map.ForMember<ComponentMetadata>((Expression<Func<ComponentMetadataItemDTO, ComponentMetadata>>)((ComponentMetadataItemDTO a) => a.Metadata), (Action<IMemberConfigurationExpression<ComponentMetadataItem, ComponentMetadataItemDTO, ComponentMetadata>>)delegate(IMemberConfigurationExpression<ComponentMetadataItem, ComponentMetadataItemDTO, ComponentMetadata> a)
		{
			a.ResolveUsing<ComponentMetadata>((Func<ComponentMetadataItem, ComponentMetadata>)((ComponentMetadataItem c) => (ComponentMetadata)c.Metadata));
		});
	}

	protected override void InitReverseMap(IMappingExpression<ComponentMetadataItemDTO, ComponentMetadataItem> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<ComponentMetadataItemDTO, ComponentMetadataItem>)delegate(ComponentMetadataItemDTO a)
		{
			ComponentMetadataItem componentMetadataItem = ComponentMetadataItemManager.Instance.LoadOrNull(a.Uid);
			if (componentMetadataItem == null)
			{
				componentMetadataItem = ComponentMetadataItemManager.Instance.Create();
			}
			return componentMetadataItem;
		});
		map.ForMember<ComponentMetadataItemHeader>((Expression<Func<ComponentMetadataItem, ComponentMetadataItemHeader>>)((ComponentMetadataItem a) => a.Header), (Action<IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ComponentMetadataItemHeader>>)delegate(IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ComponentMetadataItemHeader> a)
		{
			a.ResolveUsing<ComponentMetadataItemHeader>((Func<ComponentMetadataItemDTO, ComponentMetadataItemHeader>)((ComponentMetadataItemDTO c) => ComponentMetadataItemHeaderManager.Instance.LoadOrNull(c.Header_Uid)));
		});
		map.ForMember<ScriptModule>((Expression<Func<ComponentMetadataItem, ScriptModule>>)((ComponentMetadataItem a) => a.ScriptModule), (Action<IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule>>)delegate(IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule> a)
		{
			a.ResolveUsing<ScriptModule>((Func<ComponentMetadataItemDTO, ScriptModule>)((ComponentMetadataItemDTO c) => ScriptModuleLoader(c.ScriptModule)));
		});
		map.ForMember<ScriptModule>((Expression<Func<ComponentMetadataItem, ScriptModule>>)((ComponentMetadataItem a) => a.ClientScriptModule), (Action<IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule>>)delegate(IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule> a)
		{
			a.ResolveUsing<ScriptModule>((Func<ComponentMetadataItemDTO, ScriptModule>)((ComponentMetadataItemDTO c) => ScriptModuleLoader(c.ClientScriptModule)));
		});
		map.ForMember<ScriptModule>((Expression<Func<ComponentMetadataItem, ScriptModule>>)((ComponentMetadataItem a) => a.TestScriptModule), (Action<IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule>>)delegate(IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule> a)
		{
			a.ResolveUsing<ScriptModule>((Func<ComponentMetadataItemDTO, ScriptModule>)((ComponentMetadataItemDTO c) => ScriptModuleLoader(c.TestScriptModule)));
		});
		map.ForMember<ScriptModule>((Expression<Func<ComponentMetadataItem, ScriptModule>>)((ComponentMetadataItem a) => a.ViewScriptModule), (Action<IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule>>)delegate(IMemberConfigurationExpression<ComponentMetadataItemDTO, ComponentMetadataItem, ScriptModule> a)
		{
			a.ResolveUsing<ScriptModule>((Func<ComponentMetadataItemDTO, ScriptModule>)((ComponentMetadataItemDTO c) => ScriptModuleLoader(c.ViewScriptModule)));
		});
	}

	private ScriptModule ScriptModuleLoader(ScriptModuleDTO scriptModule)
	{
		if (scriptModule == null)
		{
			return null;
		}
		ScriptModule scriptModule2 = ScriptModuleManager.Instance.LoadOrNull(scriptModule.Uid);
		if (scriptModule2 != null)
		{
			return Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule, scriptModule2);
		}
		return Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule, new ScriptModule());
	}
}

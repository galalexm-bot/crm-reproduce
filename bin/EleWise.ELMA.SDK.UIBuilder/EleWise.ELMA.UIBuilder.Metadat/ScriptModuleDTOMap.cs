using System;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO.Mappers;

internal sealed class ScriptModuleDTOMap : BidirectionalMap<ScriptModule, ScriptModuleDTO>
{
	protected override void InitReverseMap(IMappingExpression<ScriptModuleDTO, ScriptModule> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<ScriptModuleDTO, ScriptModule>)delegate(ScriptModuleDTO a)
		{
			ScriptModule scriptModule = ScriptModuleManager.Instance.LoadOrNull(a.Uid);
			if (scriptModule == null)
			{
				scriptModule = ScriptModuleManager.Instance.Create();
			}
			return scriptModule;
		});
	}
}

using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.Models;

public interface IUIModuleModel : IUIModel
{
	Guid ModuleUid { get; set; }
}

using EleWise.ELMA.BPM.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Common.Components;

[InterfaceExtension(typeof(IUserSettingsModel))]
public interface IFastCommentUserSettingsModel : IUserSettingsModel, IAutoImplement
{
	FastCommentSettingsModel Comment { get; set; }
}

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

[InterfaceExtension(typeof(IUserSettingsModel))]
public interface ITaskControlSettingsModel : IUserSettingsModel, IAutoImplement
{
	TaskControlSettingsModel TaskControlSettings { get; set; }
}

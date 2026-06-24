using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public interface IPeriodicalEntityExtension : IPeriodicalEntity, IEntity, IIdentified
{
	string SettingsData { get; set; }
}

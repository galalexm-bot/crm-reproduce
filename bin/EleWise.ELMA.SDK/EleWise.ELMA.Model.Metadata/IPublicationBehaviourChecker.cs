using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Model.Metadata;

public interface IPublicationBehaviourChecker
{
	PublicationType Check(CheckType action, object oldValue, object newValue);
}

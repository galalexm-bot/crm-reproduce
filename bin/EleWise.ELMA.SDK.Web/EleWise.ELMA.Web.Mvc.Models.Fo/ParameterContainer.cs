using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Models.Forms;

public class ParameterContainer
{
	public IEntity Entity { get; private set; }

	public ParameterContainer(IEntity entity)
	{
		Entity = entity;
	}

	public override string ToString()
	{
		return "";
	}
}

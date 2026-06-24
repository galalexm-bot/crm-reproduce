using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskInfoUserPanel : EntityInfoUserPanel
{
	public TaskInfoUserPanel(IUser user, IEntity<long> entity, bool isAvailableAddQuestion = true)
		: base(user, entity, isAvailableAddQuestion)
	{
		bool flag = base.Entity is ITask && ((ITask)base.Entity).IsTemplate;
		base.IsAvailableAddQuestion = !flag && base.IsAvailableAddQuestion;
	}
}

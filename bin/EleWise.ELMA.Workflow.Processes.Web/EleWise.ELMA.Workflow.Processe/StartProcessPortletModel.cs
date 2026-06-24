using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class StartProcessPortletModel
{
	public class Group
	{
		public string Name { get; set; }

		public List<IProcessHeader> Headers { get; set; }

		public Group()
		{
			Headers = new List<IProcessHeader>();
		}
	}

	public List<Group> Groups { get; set; }

	public StartProcessPortletModel()
	{
		Groups = new List<Group>();
	}
}

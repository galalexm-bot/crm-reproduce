using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class WorkflowInstanceViewModel
{
	private Lazy<List<IQuestion>> _questions;

	private Lazy<List<MemberItem>> _members;

	public IWorkflowInstance Instance { get; set; }

	public Guid TypeUid { get; set; }

	public Entity<long> Context { get; set; }

	public int SelectedTab { get; set; }

	public WorkflowTaskListModel Tasks { get; set; }

	public EleWise.ELMA.Security.Models.IUser CurrentUser { get; set; }

	public List<IQuestion> Questions
	{
		get
		{
			InitQuestions();
			return _questions.Value;
		}
	}

	public List<MemberItem> Members
	{
		get
		{
			InitMembers();
			return _members.Value;
		}
	}

	public long QuestionsCount => QuestionManager.Instance.GetQuestionsCount(Instance);

	public string GridId { get; set; }

	public string PopupId { get; set; }

	public PermissionRoleTypeSelectorModel MemberPermissionModel { get; set; }

	public bool CanTerminateByAdditionalCondition { get; set; }

	public FormView GetContextView(ViewType viewType)
	{
		return Locator.GetServiceNotNull<WorkflowInstanceManager>().GetContextView(Instance, viewType);
	}

	public bool HasPermission(Permission permission)
	{
		return Locator.GetService<ISecurityService>().HasPermission(permission, Instance);
	}

	private void InitQuestions()
	{
		if (_questions == null || !_questions.IsValueCreated)
		{
			_questions = new Lazy<List<IQuestion>>(() => QuestionManager.Instance.GetQuestions(Instance));
		}
	}

	private void InitMembers()
	{
		if (_members == null || !_members.IsValueCreated)
		{
			_members = new Lazy<List<MemberItem>>(() => CreateMemberItem((IEnumerable<IWorkflowInstanceMember>)Instance.Members));
		}
	}

	private List<MemberItem> CreateMemberItem(IEnumerable<IWorkflowInstanceMember> memberList)
	{
		IPermissionTypeRoleService roleTypeService = Locator.GetService<IPermissionTypeRoleService>();
		Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkflowInstanceMember>> dictionary = new Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkflowInstanceMember>>();
		foreach (IWorkflowInstanceMember member in memberList)
		{
			if (!dictionary.ContainsKey(member.User))
			{
				dictionary.Add(member.User, new List<IWorkflowInstanceMember>());
			}
			dictionary[member.User].Add(member);
		}
		return dictionary.Select((KeyValuePair<EleWise.ELMA.Security.Models.IUser, List<IWorkflowInstanceMember>> p) => new MemberItem
		{
			User = p.Key,
			Members = p.Value.Select((IWorkflowInstanceMember m) => new RoleItem
			{
				Member = m,
				PermissionRoleType = (m.PermissionRole.HasValue ? roleTypeService.Get(m.PermissionRole.Value) : null)
			}).ToList()
		}).ToList();
	}
}

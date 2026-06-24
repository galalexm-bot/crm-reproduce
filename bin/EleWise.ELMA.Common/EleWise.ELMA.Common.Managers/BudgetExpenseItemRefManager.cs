using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class BudgetExpenseItemRefManager : EntityManager<IBudgetExpenseItemRef, long>
{
	public static readonly Guid BudgetExpenseItemRef1Uid = new Guid("{297E939B-A4D4-4D8B-9CF4-560C7125D2F0}");

	public static readonly Guid BudgetExpenseItemRef2Uid = new Guid("{22344C0D-601A-415C-8494-0FCE6FBEA06C}");

	public static readonly Guid BudgetExpenseItemRef3Uid = new Guid("{57F5DDB5-909A-4CE4-8244-3ECE1AF17F4C}");

	public static readonly Guid BudgetExpenseItemRef4Uid = new Guid("{4B920330-F942-4348-B36D-7BEDD5F77BF4}");

	public static readonly Guid BudgetExpenseItemRef5Uid = new Guid("{9F4F445B-BAB8-451E-9CF5-AD396A0C1D04}");

	public static readonly Guid BudgetExpenseItemRef6Uid = new Guid("{969D906A-CEE4-4EAE-AC04-5A221CC71050}");

	public new static BudgetExpenseItemRefManager Instance => Locator.GetServiceNotNull<BudgetExpenseItemRefManager>();

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	[PublicApiMember]
	public override void Delete(IBudgetExpenseItemRef obj)
	{
		base.Delete(obj);
	}

	public void CreateDefaultItems()
	{
		IBudgetExpenseItemRef budgetExpenseItemRef = Create();
		budgetExpenseItemRef.Uid = BudgetExpenseItemRef1Uid;
		budgetExpenseItemRef.Name = SR.T("Арендная плата");
		budgetExpenseItemRef.Save();
		IBudgetExpenseItemRef budgetExpenseItemRef2 = Create();
		budgetExpenseItemRef2.Uid = BudgetExpenseItemRef2Uid;
		budgetExpenseItemRef2.Name = SR.T("Зарплата");
		budgetExpenseItemRef2.Save();
		IBudgetExpenseItemRef budgetExpenseItemRef3 = Create();
		budgetExpenseItemRef3.Uid = BudgetExpenseItemRef3Uid;
		budgetExpenseItemRef3.Name = SR.T("Командировочные расходы");
		budgetExpenseItemRef3.Save();
		IBudgetExpenseItemRef budgetExpenseItemRef4 = Create();
		budgetExpenseItemRef4.Uid = BudgetExpenseItemRef4Uid;
		budgetExpenseItemRef4.Name = SR.T("Страховые выплаты");
		budgetExpenseItemRef4.Save();
		IBudgetExpenseItemRef budgetExpenseItemRef5 = Create();
		budgetExpenseItemRef5.Uid = BudgetExpenseItemRef5Uid;
		budgetExpenseItemRef5.Name = SR.T("Выплаты по кредитам");
		budgetExpenseItemRef5.Save();
		IBudgetExpenseItemRef budgetExpenseItemRef6 = Create();
		budgetExpenseItemRef6.Uid = BudgetExpenseItemRef6Uid;
		budgetExpenseItemRef6.Name = SR.T("Прочее");
		budgetExpenseItemRef6.Save();
	}

	[PublicApiMember]
	public virtual IBudgetExpenseItemRef Create(string name)
	{
		return Create(name, null);
	}

	[PublicApiMember]
	public virtual IBudgetExpenseItemRef Create(string name, string description)
	{
		IBudgetExpenseItemRef budgetExpenseItemRef = InterfaceActivator.Create<IBudgetExpenseItemRef>();
		budgetExpenseItemRef.Description = description;
		budgetExpenseItemRef.Name = name;
		budgetExpenseItemRef.Save();
		return budgetExpenseItemRef;
	}
}

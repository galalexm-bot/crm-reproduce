using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class BudgetIncomeItemRefManager : EntityManager<IBudgetIncomeItemRef, long>
{
	public static readonly Guid BudgetIncomeItemRef1Uid = new Guid("{7CBFC51E-73F5-4B2F-89BE-496B7447F68F}");

	public static readonly Guid BudgetIncomeItemRef2Uid = new Guid("{DD4F2F80-B348-4CDA-88EB-0DDD0FDA02F6}");

	public static readonly Guid BudgetIncomeItemRef3Uid = new Guid("{88FB658E-DC36-438E-B958-9D8F3C10EB7D}");

	public static readonly Guid BudgetIncomeItemRef4Uid = new Guid("{41B15125-61F3-4257-A72D-A1AF10801114}");

	public new static BudgetIncomeItemRefManager Instance => Locator.GetServiceNotNull<BudgetIncomeItemRefManager>();

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	[PublicApiMember]
	public override void Delete(IBudgetIncomeItemRef obj)
	{
		base.Delete(obj);
	}

	public void CreateDefaultItems()
	{
		IBudgetIncomeItemRef budgetIncomeItemRef = Create();
		budgetIncomeItemRef.Uid = BudgetIncomeItemRef1Uid;
		budgetIncomeItemRef.Name = SR.T("Доходы от реализации продукции");
		budgetIncomeItemRef.Save();
		IBudgetIncomeItemRef budgetIncomeItemRef2 = Create();
		budgetIncomeItemRef2.Uid = BudgetIncomeItemRef2Uid;
		budgetIncomeItemRef2.Name = SR.T("Консалтинг");
		budgetIncomeItemRef2.Save();
		IBudgetIncomeItemRef budgetIncomeItemRef3 = Create();
		budgetIncomeItemRef3.Uid = BudgetIncomeItemRef3Uid;
		budgetIncomeItemRef3.Name = SR.T("Лицензионные отчисления");
		budgetIncomeItemRef3.Save();
		IBudgetIncomeItemRef budgetIncomeItemRef4 = Create();
		budgetIncomeItemRef4.Uid = BudgetIncomeItemRef4Uid;
		budgetIncomeItemRef4.Name = SR.T("Прочее");
		budgetIncomeItemRef4.Save();
	}

	[PublicApiMember]
	public virtual IBudgetIncomeItemRef Create(string name)
	{
		return Create(name, null);
	}

	[PublicApiMember]
	public virtual IBudgetIncomeItemRef Create(string name, string description)
	{
		IBudgetIncomeItemRef budgetIncomeItemRef = InterfaceActivator.Create<IBudgetIncomeItemRef>();
		budgetIncomeItemRef.Description = description;
		budgetIncomeItemRef.Name = name;
		budgetIncomeItemRef.Save();
		return budgetIncomeItemRef;
	}
}

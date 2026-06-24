using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Managers;

public class ContractorTypeManager : EntityManager<IContractorType, long>
{
	private static readonly Guid partnerItemUid = new Guid("f3e3a7ae-26d8-47bf-a51a-3af3ddb4b2e4");

	public new static ContractorTypeManager Instance => Locator.GetServiceNotNull<ContractorTypeManager>();

	public static Guid TypeUid => InterfaceActivator.UID<IContractorType>();

	public static Guid PartnerItemUid => partnerItemUid;

	[PublicApiMember]
	public override void Delete(IContractorType obj)
	{
		foreach (IContractor item in ContractorManager.Instance.Find((IContractor i) => i.Type == obj))
		{
			item.Type = null;
			ContractorManager.Instance.Save(item);
		}
		base.Delete(obj);
	}

	public void CreateDefaultItems()
	{
		IContractorType contractorType = Create();
		contractorType.Name = SR.T("Партнер");
		contractorType.Uid = PartnerItemUid;
		Save(contractorType);
	}
}

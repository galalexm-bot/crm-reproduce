using System.Collections.Generic;
using EleWise.ELMA.CRM.Models.BillingInformation;

namespace EleWise.ELMA.CRM.Import.Web.Components;

public class ImportSessionData
{
	public List<IBankDetailsSWIFT> BankDetailsDic = new List<IBankDetailsSWIFT>();

	public List<IBankAccount> BankAccountDic = new List<IBankAccount>();

	public List<IFinancialInstitutionBank> BankDic = new List<IFinancialInstitutionBank>();
}

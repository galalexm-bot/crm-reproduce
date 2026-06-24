using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Import.Web.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using Iesi.Collections;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component]
public class SwiftBankDetailsHandler : EntityImportEventHandler<ImportSessionData>
{
	public const string Pattern = "[A-z]+|[А-я]+|[ё|Ё]+";

	public Regex Reg = new Regex("[A-z]+|[А-я]+|[ё|Ё]+");

	private string bankName;

	private string bankFullName;

	private string bankLocation;

	private string bankAddress;

	private string accountNumber;

	private string nameOfBank;

	private string swiftCode;

	private string accountIntermediaryBank;

	private string intermediaryBank;

	public bool AllowAddToDict;

	public bool SaveEntity;

	public static EntityMetadata Metadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeof(IContractorLegal));

	public static Guid BankAccountPropUid = InterfaceActivator.PropertyUid((IContractor p) => p.BankAccounts);

	public static PropertyMetadata BankAccountPropMetadata = Metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == BankAccountPropUid);

	public static PropertyInfo BankAccountProp = InterfaceActivator.TypeOf<IContractorLegal>().GetProperty(BankAccountPropMetadata.Name);

	public static Type BankAccountType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(BankAccountPropMetadata.SubTypeUid);

	public static EntityMetadata BankAccountMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(BankAccountPropMetadata.SubTypeUid);

	public static Guid BankDetailsPropUid = InterfaceActivator.PropertyUid((IBankAccount p) => p.BankDetails);

	public static PropertyMetadata BankDetailsPropMetadata = BankAccountMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == BankDetailsPropUid);

	public static PropertyInfo BankDetailsProp = BankAccountType.GetProperty(BankDetailsPropMetadata.Name);

	public static Type BankDetailsType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(InterfaceActivator.UID<IBankDetailsSWIFT>());

	public static EntityMetadata BankDetailsMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IBankDetailsSWIFT>());

	public static Guid BankPropUid = InterfaceActivator.PropertyUid((IBankDetails p) => p.Bank);

	public static PropertyMetadata BankPropMetadata = BankDetailsMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == BankPropUid);

	public static PropertyInfo BankProp = BankDetailsType.GetProperty(BankPropMetadata.Name);

	public static Type BankType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(BankPropMetadata.SubTypeUid);

	public static EntityMetadata BankMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(BankPropMetadata.SubTypeUid);

	public static Guid BankNamePropUid = InterfaceActivator.PropertyUid((IFinancialInstitutionBank p) => p.Name);

	public static string BankNameStringProp = LinqUtils.NameOf((Expression<Func<IFinancialInstitutionBank, object>>)((IFinancialInstitutionBank u) => u.Name));

	public static Guid BankFullNamePropUid = InterfaceActivator.PropertyUid((IFinancialInstitutionBank p) => p.FullName);

	public static string BankFullNameStringProp = LinqUtils.NameOf((Expression<Func<IFinancialInstitutionBank, object>>)((IFinancialInstitutionBank u) => u.FullName));

	public static Guid BankLocationPropUid = InterfaceActivator.PropertyUid((IFinancialInstitutionBank p) => p.Location);

	public static string BankLocationStringProp = LinqUtils.NameOf((Expression<Func<IFinancialInstitutionBank, object>>)((IFinancialInstitutionBank u) => u.Location));

	public static Guid BankAddressPropUid = InterfaceActivator.PropertyUid((IFinancialInstitutionBank p) => p.Address);

	public static string BankAddressStringProp = LinqUtils.NameOf((Expression<Func<IFinancialInstitutionBank, object>>)((IFinancialInstitutionBank u) => u.Address));

	public static Guid AccountNumberPropUid = InterfaceActivator.PropertyUid((IBankAccount p) => p.AccountNumber);

	public static string AccountNumberStringProp = LinqUtils.NameOf((Expression<Func<IBankAccount, object>>)((IBankAccount u) => u.AccountNumber));

	public static Guid NameOfBankPropUid = InterfaceActivator.PropertyUid((IBankDetailsSWIFT p) => p.NameOfBank);

	public static string NameOfBankStringProp = LinqUtils.NameOf((Expression<Func<IBankDetailsSWIFT, object>>)((IBankDetailsSWIFT u) => u.NameOfBank));

	public static Guid SwiftCodePropUid = InterfaceActivator.PropertyUid((IBankDetailsSWIFT p) => p.SWIFTCode);

	public static string SwiftCodeStringProp = LinqUtils.NameOf((Expression<Func<IBankDetailsSWIFT, object>>)((IBankDetailsSWIFT u) => u.SWIFTCode));

	public static Guid AccInterBankPropUid = InterfaceActivator.PropertyUid((IBankDetailsSWIFT p) => p.AccountInIntermediaryBank);

	public static string AccInterBankStringProp = LinqUtils.NameOf((Expression<Func<IBankDetailsSWIFT, object>>)((IBankDetailsSWIFT u) => u.AccountInIntermediaryBank));

	public static Guid InterBankPropUid = InterfaceActivator.PropertyUid((IBankDetailsSWIFT p) => p.IntermediaryBank);

	public static string InterBankStringProp = LinqUtils.NameOf((Expression<Func<IBankDetailsSWIFT, object>>)((IBankDetailsSWIFT u) => u.IntermediaryBank));

	private readonly ReflectedBankDetailsPropertyInfo bankMasterInfo = new ReflectedBankDetailsPropertyInfo(null, null, BankAccountProp, BankAccountPropMetadata.DisplayName, BankAccountPropMetadata.Uid)
	{
		BDMasterProperty = BankProp
	};

	private readonly ReflectedBankDetailsPropertyInfo bankAccountMasterInfo = new ReflectedBankDetailsPropertyInfo(null, null, BankAccountProp, BankAccountPropMetadata.DisplayName, BankAccountPropMetadata.Uid)
	{
		BDMasterProperty = BankAccountProp
	};

	private readonly ReflectedBankDetailsPropertyInfo bankDetailsMasterInfo = new ReflectedBankDetailsPropertyInfo(null, null, BankAccountProp, BankAccountPropMetadata.DisplayName, BankAccountPropMetadata.Uid)
	{
		BDMasterProperty = BankDetailsProp
	};

	public override Type Type => typeof(IContractorLegal);

	private static string BankNameString => SR.T("Сокращенное наименование банка (SWIFT)");

	private static string BankFullNameString => SR.T("Полное наименование банка (SWIFT)");

	private static string BankLocationString => SR.T("Местонахождение банка (SWIFT)");

	private static string BankAddressString => SR.T("Юридический адрес банка (SWIFT)");

	private static string AccountNumberString => SR.T("Номер счета (SWIFT)");

	private static string NameOfBankString => "Name of Bank (SWIFT)";

	private static string SwiftCodeString => "SWIFT-code (SWIFT)";

	private static string AccountIntermediaryBankString => "Account in Intermediary Bank (SWIFT)";

	private static string IntermediaryBankString => "Intermediary Bank (SWIFT)";

	public ReflectedBankDetailsPropertyInfo Info { get; set; }

	public bool BankNameRequsit(string requsit)
	{
		return requsit.Equals(BankNameString);
	}

	public bool BankFullNameRequsit(string requsit)
	{
		return requsit.Equals(BankFullNameString);
	}

	public bool BankLocationRequsit(string requsit)
	{
		return requsit.Equals(BankLocationString);
	}

	public bool BankAddressRequsit(string requsit)
	{
		return requsit.Equals(BankAddressString);
	}

	public bool AccountNumberRequsit(string requsit)
	{
		return requsit.Equals(AccountNumberString);
	}

	public bool NameOfBankRequsit(string requsit)
	{
		return requsit.Equals(NameOfBankString);
	}

	public bool SwiftCodeRequsit(string requsit)
	{
		return requsit.Equals(SwiftCodeString);
	}

	public bool AccountIntermediaryBankRequsit(string requsit)
	{
		return requsit.Equals(AccountIntermediaryBankString);
	}

	public bool IntermediaryBankRequsit(string requsit)
	{
		return requsit.Equals(IntermediaryBankString);
	}

	public ReflectedBankDetailsPropertyInfo InsertIntoMaster(ReflectedBankDetailsPropertyInfo propertyInfo, string pDn, Guid pU)
	{
		return new ReflectedBankDetailsPropertyInfo(propertyInfo.MasterProperty, propertyInfo.MasterPropertyDisplayName, propertyInfo.Property, propertyInfo.PropertyDisplayName, propertyInfo.PropertyUid)
		{
			BDMasterProperty = propertyInfo.BDMasterProperty,
			BDPropertyDisplayName = pDn,
			BDPropertyUid = pU
		};
	}

	public override ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type, ImportSessionData importSessionData)
	{
		if (type.IsInheritOrSame<IContractorLegal>())
		{
			if (BankNameRequsit(slavePropName))
			{
				return InsertIntoMaster(bankMasterInfo, BankNameString, BankNamePropUid);
			}
			if (BankFullNameRequsit(slavePropName))
			{
				return InsertIntoMaster(bankMasterInfo, BankFullNameString, BankFullNamePropUid);
			}
			if (BankLocationRequsit(slavePropName))
			{
				return InsertIntoMaster(bankMasterInfo, BankLocationString, BankLocationPropUid);
			}
			if (BankAddressRequsit(slavePropName))
			{
				return InsertIntoMaster(bankMasterInfo, BankAddressString, BankAddressPropUid);
			}
			if (AccountNumberRequsit(slavePropName))
			{
				return InsertIntoMaster(bankAccountMasterInfo, AccountNumberString, AccountNumberPropUid);
			}
			if (NameOfBankRequsit(slavePropName))
			{
				return InsertIntoMaster(bankDetailsMasterInfo, NameOfBankString, NameOfBankPropUid);
			}
			if (SwiftCodeRequsit(slavePropName))
			{
				return InsertIntoMaster(bankDetailsMasterInfo, SwiftCodeString, SwiftCodePropUid);
			}
			if (AccountIntermediaryBankRequsit(slavePropName))
			{
				return InsertIntoMaster(bankDetailsMasterInfo, AccountIntermediaryBankString, AccInterBankPropUid);
			}
			if (IntermediaryBankRequsit(slavePropName))
			{
				return InsertIntoMaster(bankDetailsMasterInfo, IntermediaryBankString, InterBankPropUid);
			}
		}
		return null;
	}

	public override bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate, ImportSessionData importSessionData)
	{
		if (entityProperty is ReflectedBankDetailsPropertyInfo reflectedBankDetailsPropertyInfo)
		{
			AllowAddToDict = allowAddToDict;
			SaveEntity = saveEntity;
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == BankNamePropUid && BankNameRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				bankName = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == BankFullNamePropUid && BankFullNameRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				bankFullName = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == BankLocationPropUid && BankLocationRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				bankLocation = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == BankAddressPropUid && BankAddressRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				bankAddress = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == AccInterBankPropUid && AccountIntermediaryBankRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				if (Reg.IsMatch(value))
				{
					throw new Exception(SR.T("В реквизите \"Account in Intermediary Bank (SWIFT)\" присутствует буква."));
				}
				accountIntermediaryBank = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == AccountNumberPropUid && AccountNumberRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				if (Reg.IsMatch(value))
				{
					throw new Exception(SR.T("В реквизите \"Номер счета (SWIFT)\" присутствует буква."));
				}
				accountNumber = value;
				Info = reflectedBankDetailsPropertyInfo;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == SwiftCodePropUid && SwiftCodeRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				swiftCode = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == NameOfBankPropUid && NameOfBankRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				nameOfBank = value;
				return true;
			}
			if (reflectedBankDetailsPropertyInfo.BDPropertyUid == InterBankPropUid && IntermediaryBankRequsit(reflectedBankDetailsPropertyInfo.BDPropertyDisplayName))
			{
				intermediaryBank = value;
				return true;
			}
		}
		return false;
	}

	public override void CheckRequiredProperties(IEntity<long> entity, ImportSessionData importSessionData)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(accountNumber))
		{
			IBankDetails bdSwift = BankDetails(importSessionData);
			if (bdSwift != null)
			{
				IBankAccount bankAccount = importSessionData.BankAccountDic.FirstOrDefault((IBankAccount p) => p.AccountNumber == accountNumber && p.BankDetails == bdSwift);
				if (bankAccount == null && !bdSwift.IsNew())
				{
					IBankAccountFilter bankAccountFilter = InterfaceActivator.Create<IBankAccountFilter>();
					bankAccountFilter.Query = string.Format("AccountNumber = '{0}' AND BankDetails = {1}", accountNumber.Replace("'", "''"), bdSwift.Id);
					IBankAccount bankAccount2 = EntityManager<IBankAccount>.Instance.Find(bankAccountFilter, FetchOptions.First).FirstOrDefault();
					if (bankAccount2 != null)
					{
						bankAccount = bankAccount2;
						importSessionData.BankAccountDic.Add(bankAccount2);
					}
				}
				if (bankAccount == null && AllowAddToDict)
				{
					bankAccount = InterfaceActivator.Create<IBankAccount>();
					bankAccount.AccountNumber = accountNumber;
					bankAccount.BankDetails = bdSwift;
					bankAccount.Name = SR.T("№ {0} в {1}", bankAccount.AccountNumber, bankAccount.BankDetails.Name);
					importSessionData.BankAccountDic.Add(bankAccount);
					if (SaveEntity)
					{
						bankAccount.Save();
					}
				}
				if (bankAccount != null)
				{
					ISet val = (ISet)Info.BDMasterProperty.GetValue(entity, null);
					val.Clear();
					val.Add((object)bankAccount);
				}
			}
		}
		bankName = null;
		bankFullName = null;
		bankLocation = null;
		bankAddress = null;
		accountNumber = null;
		nameOfBank = null;
		swiftCode = null;
		accountIntermediaryBank = null;
		intermediaryBank = null;
		AllowAddToDict = false;
		SaveEntity = false;
		Info = null;
	}

	public IBankDetails BankDetails(ImportSessionData importSessionData)
	{
		List<IBankDetailsSWIFT> bankDetailsDic = importSessionData.BankDetailsDic;
		if (!string.IsNullOrEmpty(swiftCode))
		{
			IBankDetailsSWIFT bankDetailsSWIFT = bankDetailsDic.FirstOrDefault((IBankDetailsSWIFT p) => p.SWIFTCode == swiftCode);
			if (bankDetailsSWIFT != null)
			{
				return bankDetailsSWIFT;
			}
			IBankDetailsSWIFTFilter bankDetailsSWIFTFilter = InterfaceActivator.Create<IBankDetailsSWIFTFilter>();
			bankDetailsSWIFTFilter.Query = string.Format("SWIFTCode = '{0}'", swiftCode.Replace("'", "''"));
			IBankDetailsSWIFT bankDetailsSWIFT2 = EntityManager<IBankDetailsSWIFT>.Instance.Find(bankDetailsSWIFTFilter, FetchOptions.First).FirstOrDefault();
			if (bankDetailsSWIFT2 != null)
			{
				bankDetailsSWIFT = bankDetailsSWIFT2;
				importSessionData.BankDetailsDic.Add(bankDetailsSWIFT2);
			}
			else
			{
				IFinancialInstitutionBank financialInstitutionBank = Bank((!string.IsNullOrEmpty(bankName)) ? bankName : $"SWIFT-code {swiftCode}", importSessionData);
				if (financialInstitutionBank == null || !AllowAddToDict)
				{
					return null;
				}
				bankDetailsSWIFT = CreateBankDetailsSwift(financialInstitutionBank, swiftCode, intermediaryBank, accountIntermediaryBank, nameOfBank, $"{financialInstitutionBank.Name} (SWIFT-code {swiftCode})");
				importSessionData.BankDetailsDic.Add(bankDetailsSWIFT);
				if (SaveEntity)
				{
					bankDetailsSWIFT.Save();
				}
			}
			return bankDetailsSWIFT;
		}
		if (!string.IsNullOrEmpty(accountIntermediaryBank) && string.IsNullOrEmpty(swiftCode))
		{
			IBankDetailsSWIFT bankDetailsSWIFT = bankDetailsDic.FirstOrDefault((IBankDetailsSWIFT p) => p.SWIFTCode == null && p.AccountInIntermediaryBank == accountIntermediaryBank);
			if (bankDetailsSWIFT != null)
			{
				return bankDetailsSWIFT;
			}
			IBankDetailsSWIFTFilter bankDetailsSWIFTFilter2 = InterfaceActivator.Create<IBankDetailsSWIFTFilter>();
			bankDetailsSWIFTFilter2.Query = string.Format("SWIFTCode IS NULL AND AccountInIntermediaryBank = '{0}'", accountIntermediaryBank.Replace("'", "''"));
			IBankDetailsSWIFT bankDetailsSWIFT3 = EntityManager<IBankDetailsSWIFT>.Instance.Find(bankDetailsSWIFTFilter2, FetchOptions.First).FirstOrDefault();
			if (bankDetailsSWIFT3 != null)
			{
				bankDetailsSWIFT = bankDetailsSWIFT3;
				importSessionData.BankDetailsDic.Add(bankDetailsSWIFT3);
			}
			else
			{
				IFinancialInstitutionBank financialInstitutionBank2 = Bank((!string.IsNullOrEmpty(bankName)) ? bankName : $"Account In Intermediary Bank {accountIntermediaryBank}", importSessionData);
				if (financialInstitutionBank2 == null || !AllowAddToDict)
				{
					return null;
				}
				bankDetailsSWIFT = CreateBankDetailsSwift(financialInstitutionBank2, swiftCode, intermediaryBank, accountIntermediaryBank, nameOfBank, $"{financialInstitutionBank2.Name} (Account In Intermediary Bank {accountIntermediaryBank})");
				importSessionData.BankDetailsDic.Add(bankDetailsSWIFT);
				if (SaveEntity)
				{
					bankDetailsSWIFT.Save();
				}
			}
			return bankDetailsSWIFT;
		}
		if (!string.IsNullOrEmpty(bankName) && string.IsNullOrEmpty(accountIntermediaryBank) && string.IsNullOrEmpty(swiftCode))
		{
			IFinancialInstitutionBank bankEntity = importSessionData.BankDic.FirstOrDefault((IFinancialInstitutionBank p) => p.Name == bankName);
			if (bankEntity == null)
			{
				IFinancialInstitutionBankFilter financialInstitutionBankFilter = InterfaceActivator.Create<IFinancialInstitutionBankFilter>();
				financialInstitutionBankFilter.Query = string.Format("Name = '{0}'", bankName.Replace("'", "''"));
				IFinancialInstitutionBank financialInstitutionBank3 = EntityManager<IFinancialInstitutionBank>.Instance.Find(financialInstitutionBankFilter, FetchOptions.First).FirstOrDefault();
				if (financialInstitutionBank3 != null)
				{
					bankEntity = financialInstitutionBank3;
					importSessionData.BankDic.Add(financialInstitutionBank3);
				}
			}
			IBankDetailsSWIFT bankDetailsSWIFT;
			if (bankEntity != null)
			{
				bankDetailsSWIFT = bankDetailsDic.FirstOrDefault((IBankDetailsSWIFT p) => p.AccountInIntermediaryBank == null && p.SWIFTCode == null && p.Bank == bankEntity);
				if (bankDetailsSWIFT == null)
				{
					IBankDetailsSWIFTFilter bankDetailsSWIFTFilter3 = InterfaceActivator.Create<IBankDetailsSWIFTFilter>();
					bankDetailsSWIFTFilter3.Query = $"SWIFTCode IS NULL AND AccountInIntermediaryBank IS NULL AND Bank = {bankEntity.Id}";
					IBankDetailsSWIFT bankDetailsSWIFT4 = EntityManager<IBankDetailsSWIFT>.Instance.Find(bankDetailsSWIFTFilter3, FetchOptions.First).FirstOrDefault();
					if (bankDetailsSWIFT4 != null)
					{
						bankDetailsSWIFT = bankDetailsSWIFT4;
						importSessionData.BankDetailsDic.Add(bankDetailsSWIFT4);
					}
					else
					{
						bankDetailsSWIFT = CreateBankDetailsSwift(bankEntity, swiftCode, intermediaryBank, accountIntermediaryBank, nameOfBank, string.Format("{0} (SWIFTCode <{1}>, Account In Intermediary Bank <{1}>)", bankEntity.Name, SR.T("не указан")));
						importSessionData.BankDetailsDic.Add(bankDetailsSWIFT);
						if (SaveEntity)
						{
							bankDetailsSWIFT.Save();
						}
					}
				}
			}
			else
			{
				bankEntity = InterfaceActivator.Create<IFinancialInstitutionBank>();
				bankEntity.Name = bankName;
				bankEntity.FullName = bankFullName;
				if (!string.IsNullOrWhiteSpace(bankAddress))
				{
					bankEntity.Comment = SR.T("Заполните ваш юридический адрес исходя из этих данных: {0}", bankAddress);
				}
				bankEntity.Location = bankLocation;
				importSessionData.BankDic.Add(bankEntity);
				if (SaveEntity)
				{
					bankEntity.Save();
				}
				bankDetailsSWIFT = CreateBankDetailsSwift(bankEntity, swiftCode, intermediaryBank, accountIntermediaryBank, nameOfBank, string.Format("{0} (SWIFTCode <{1}>, Account In Intermediary Bank <{1}>)", bankEntity.Name, SR.T("не указан")));
				importSessionData.BankDetailsDic.Add(bankDetailsSWIFT);
				if (SaveEntity)
				{
					bankDetailsSWIFT.Save();
				}
			}
			return bankDetailsSWIFT;
		}
		return null;
	}

	public IFinancialInstitutionBank Bank(string name, ImportSessionData importSessionData)
	{
		IFinancialInstitutionBank financialInstitutionBank = importSessionData.BankDic.FirstOrDefault((IFinancialInstitutionBank p) => p.Name == name);
		if (financialInstitutionBank == null)
		{
			IFinancialInstitutionBankFilter financialInstitutionBankFilter = InterfaceActivator.Create<IFinancialInstitutionBankFilter>();
			financialInstitutionBankFilter.Query = string.Format("Name = '{0}'", name.Replace("'", "''"));
			IFinancialInstitutionBank financialInstitutionBank2 = EntityManager<IFinancialInstitutionBank>.Instance.Find(financialInstitutionBankFilter, FetchOptions.First).FirstOrDefault();
			if (financialInstitutionBank2 != null)
			{
				financialInstitutionBank = financialInstitutionBank2;
				importSessionData.BankDic.Add(financialInstitutionBank2);
			}
		}
		if (financialInstitutionBank == null && AllowAddToDict)
		{
			financialInstitutionBank = InterfaceActivator.Create<IFinancialInstitutionBank>();
			financialInstitutionBank.Name = name;
			financialInstitutionBank.FullName = bankFullName;
			financialInstitutionBank.Location = bankLocation;
			if (!string.IsNullOrWhiteSpace(bankAddress))
			{
				financialInstitutionBank.Comment = SR.T("Заполните ваш юридический адрес исходя из этих данных: {0}", bankAddress);
			}
			importSessionData.BankDic.Add(financialInstitutionBank);
			if (SaveEntity)
			{
				financialInstitutionBank.Save();
			}
		}
		return financialInstitutionBank;
	}

	public IBankDetailsSWIFT CreateBankDetailsSwift(IFinancialInstitutionBank bank, string swift, string interBank, string accountInIntermediaryBank, string nameBank, string name)
	{
		IBankDetailsSWIFT bankDetailsSWIFT = InterfaceActivator.Create<IBankDetailsSWIFT>();
		bankDetailsSWIFT.Bank = bank;
		bankDetailsSWIFT.SWIFTCode = swift;
		bankDetailsSWIFT.IntermediaryBank = interBank;
		bankDetailsSWIFT.AccountInIntermediaryBank = accountInIntermediaryBank;
		bankDetailsSWIFT.NameOfBank = nameBank;
		bankDetailsSWIFT.Name = name;
		return bankDetailsSWIFT;
	}
}

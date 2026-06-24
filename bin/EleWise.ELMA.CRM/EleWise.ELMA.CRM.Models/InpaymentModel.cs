using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Models;

public class InpaymentModel
{
	public long Id { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "Name")]
	public string Name { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "Status")]
	public InpaymentStatus Status { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "Date")]
	public DateTime? Date { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "ActualDate")]
	public DateTime? ActualDate { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "Sum")]
	public Money Sum { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "Invoice")]
	public bool Invoice { get; set; }

	public long ContractorId { get; set; }

	public Guid ContractorTypeUid { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "ContractorName")]
	public string ContractorName { get; set; }

	public long SaleId { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "SaleName")]
	public string SaleName { get; set; }

	[DisplayName(typeof(InpaymentModel_SR), "SaleStatus")]
	public SaleStatus SaleStatus { get; set; }

	public long ResponsibleId { get; set; }

	public Guid ResponsibleUid { get; set; }

	public string ResponsibleFirstName { get; set; }

	public string ResponsibleLastName { get; set; }

	public string ResponsibleMiddleName { get; set; }

	public long CreationAuthorId { get; set; }

	public Guid CreationAuthorUid { get; set; }

	public string CreationAuthorFirstName { get; set; }

	public string CreationAuthorLastName { get; set; }

	public string CreationAuthorMiddleName { get; set; }

	public bool IsSaleClosed
	{
		get
		{
			if (SaleStatus != SaleStatus.NegativeClosed)
			{
				return SaleStatus == SaleStatus.PositiveClosed;
			}
			return true;
		}
	}

	[DisplayName(typeof(InpaymentModel_SR), "ResponsibleShortName")]
	public string ResponsibleShortName
	{
		get
		{
			InstanceOf<IUser> instanceOf = new InstanceOf<IUser>();
			instanceOf.New.Id = ResponsibleId;
			instanceOf.New.Uid = ResponsibleUid;
			instanceOf.New.FirstName = ResponsibleFirstName;
			instanceOf.New.LastName = ResponsibleLastName;
			instanceOf.New.MiddleName = ResponsibleMiddleName;
			return instanceOf.New.GetShortName();
		}
	}

	[DisplayName(typeof(InpaymentModel_SR), "CreationAuthorShortName")]
	public string CreationAuthorShortName
	{
		get
		{
			InstanceOf<IUser> instanceOf = new InstanceOf<IUser>();
			instanceOf.New.Id = CreationAuthorId;
			instanceOf.New.Uid = CreationAuthorUid;
			instanceOf.New.FirstName = CreationAuthorFirstName;
			instanceOf.New.LastName = CreationAuthorLastName;
			instanceOf.New.MiddleName = CreationAuthorMiddleName;
			return instanceOf.New.GetShortName();
		}
	}
}

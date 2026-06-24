using System;
using System.Collections.ObjectModel;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;

namespace EleWise.ELMA.KPI.Common.DTO.Models;

[Serializable]
public class PeriodicityDTO : EntityDTO<Guid, IPeriodicity>, IIdentity, IGenericIdentity<Guid>
{
	private Collection<CustomPeriodDTO> periods = new Collection<CustomPeriodDTO>();

	public static readonly PeriodicityDTO PeriodicityYear = new PeriodicityDTO(new Guid("7B5949E9-8232-4b65-ADF3-C6515412710F"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("Год"),
		Type = PeriodicityType.Year,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 0L
	};

	public static readonly PeriodicityDTO PeriodicityHalfYear = new PeriodicityDTO(new Guid("8FCC3DF9-51FA-41c1-8FC6-152E9A60B2D6"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("Полугодие"),
		Type = PeriodicityType.HalfYear,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 1L
	};

	public static readonly PeriodicityDTO PeriodicityQuarter = new PeriodicityDTO(new Guid("B20CEABC-0AFE-4173-B08C-52697AA866D3"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("Квартал"),
		Type = PeriodicityType.Quarter,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 2L
	};

	public static readonly PeriodicityDTO PeriodicityMonth = new PeriodicityDTO(new Guid("98ECE429-4CAA-4f1e-AD65-BB6CE2873F75"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("Месяц"),
		Type = PeriodicityType.Month,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 3L
	};

	public static readonly PeriodicityDTO PeriodicityWeek = new PeriodicityDTO(new Guid("F2B03B4A-D4B6-4611-B570-2656728EB693"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("Неделя"),
		Type = PeriodicityType.Week,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 4L
	};

	public static readonly PeriodicityDTO PeriodicityDay = new PeriodicityDTO(new Guid("7E0E4D76-DCBC-4792-B43E-42F86F22BC09"))
	{
		GroupingType = PeriodGroupingType.FirstDay,
		IsFolder = false,
		Name = SR.T("День"),
		Type = PeriodicityType.Day,
		CalendarType = PeriodicityCalendarType.AllDays,
		Order = 5L
	};

	public PeriodicityType Type { get; set; }

	public PeriodGroupingType? GroupingType { get; set; }

	public PeriodicityCalendarType CalendarType { get; set; }

	public Collection<CustomPeriodDTO> Periods
	{
		get
		{
			return periods;
		}
		set
		{
			periods = value;
		}
	}

	public bool IsFolder { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public long Order { get; set; }

	public new Guid Id { get; set; }

	Guid IGenericIdentity<Guid>.Id => Id;

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public PeriodicityDTO()
	{
	}

	public PeriodicityDTO(Guid uid)
	{
		Id = uid;
	}

	public static PeriodicityDTO Create()
	{
		return new PeriodicityDTO(Guid.NewGuid());
	}
}

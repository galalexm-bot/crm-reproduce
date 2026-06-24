using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public static class ViewItemBuilderExtension
{
	public static TB ContactsGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<ContractorContactsGridViewItemBuilder<TM>> builder = null) where TM : IContractor where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		ContractorContactsGridViewItemBuilder<TM> obj = new ContractorContactsGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TB RelationshipsGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<RelationshipsGridViewItemBuilder<TM>> builder = null) where TM : IContractor where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		RelationshipsGridViewItemBuilder<TM> obj = new RelationshipsGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TabLayoutViewItemBuilder<TM> SalesTab<TM>(this TabLayoutViewItemBuilder<TM> b, Action<ContractorSalesTabViewItemBuilder<TM>> builder) where TM : IContractor
	{
		builder?.Invoke(new ContractorSalesTabViewItemBuilder<TM>(b));
		return b;
	}

	public static TB SalesGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<ContractorSalesGridViewItemBuilder<TM>> builder = null) where TM : IContractor where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		ContractorSalesGridViewItemBuilder<TM> obj = new ContractorSalesGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TB TasksGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<TasksGridViewItemBuilder<TM>> builder = null) where TM : IContractor where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		TasksGridViewItemBuilder<TM> obj = new TasksGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TB AttachmentsGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<AttachmentsGridViewItemBuilder<TM>> builder = null) where TM : IContractor where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		AttachmentsGridViewItemBuilder<TM> obj = new AttachmentsGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}
}

using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Documents.Web.Menu;

[Component]
public class DocumentsMenuItems : IMenuItemsProvider
{
	public const string DOCUMENTS_GENERAL = "documents-tree-menu";

	public const string DOCUMENTS_TREE = "documents-tree-menu";

	public const string DOCUMENTS_REPOSITORY = "documents-repository";

	public const string DOCUMENTS_SEARCH = "documents-search";

	public const string DOCUMENTS_MY = "documents-my";

	public const string DOCUMENTS_SHARED_FOLDERS = "documents-shared-folders";

	public const string DOCUMENTS_FAVORITES = "documents-favorites";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action("EleWise.ELMA.Documents.Web-Module-CreateDocument").Name(SR.M("Добавить документ")).Order(50)
			.Container("create");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("start");
		});
		factory.Action(new ActionRoute("Index", "Home", new
		{
			area = "EleWise.ELMA.Documents.Web"
		})).Name(SR.M("Документы")).Code("start-documents-menu")
			.Order(500)
			.Color("yellow")
			.Image16("#user.svg");
		factory.Action("documents-favorites").Name(SR.M("Избранное")).Parent("start-documents-menu")
			.Order(520)
			.Image16("#star_outline.svg");
		factory.Action("documents-search").Name(SR.M("Поиск")).Parent("start-documents-menu")
			.Order(530)
			.Image16("#search.svg");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action("EleWise.ELMA.Documents.Web-Module-CreateDocument").Parent("create").Order(45)
			.Image24("#add.svg")
			.Name(SR.M("Документ"))
			.Container("top");
		factory.Section(SR.M("Документы"), "documents").Order(35).Container("top");
		factory.Action("documents-favorites").Name(SR.M("Избранное")).Parent("documents")
			.Image24("#star_outline.svg")
			.Order(10);
		factory.Action("EleWise.ELMA.BPM.Web.Common-Module-Watches-Documents").Parent("documents").Order(15);
		factory.Action("documents-my").Name(SR.M("Мои документы")).Parent("documents")
			.Order(20);
		factory.Action("documents-shared-folders").Name(SR.M("Общие папки")).Parent("documents")
			.Image24("#folder.svg")
			.Order(30);
		factory.Separator().Parent("documents").Order(90);
		factory.Action("documents-search").Name(SR.M("Поиск документов")).Parent("documents")
			.Image24("#search.svg")
			.Order(100);
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Section(SR.M("Документы"), "documents").Image24("#folder.svg").Order(50)
			.Stretch(stretch: true)
			.OnTop(onTop: true);
		factory.Action("EleWise.ELMA.Documents.Web-Module-HomePage").Code("documents-tree-menu").Parent("documents")
			.Name(SR.M("Главная"))
			.Order(10);
		factory.Action("documents-repository").Parent("documents").Name(SR.M("Хранилище документов"))
			.Image24("#search.svg")
			.Order(20);
	}
}

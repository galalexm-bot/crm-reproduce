function assignCategoryRuleCallBack(data, url, deleteCategoriesUrl) {
    if (data.CategoriesToDelete.length > 0) {
        AskToDeleteCategories(data, url, deleteCategoriesUrl);
    }
    else {
        redirectToDetails(data.EntityId, url);
    }
}

function AskToDeleteCategories(data, url, deleteCategoriesUrl) {
    var message = SR.T("Удалить автоматически добавленные по устаревшим правилам категории:\n");
    for (var i = 0; i < data.CategoriesToDelete.length; i++) {
        message += data.CategoriesToDelete[i].Item2 + "\n";
    }

    jConfirm(message, SR.T("Удаление категорий"), function (r) {
        if (r == true) {
            deleteObsoleteCategories(data.EntityId, url, data.CategoriesToDelete, deleteCategoriesUrl);
        }
        else {
            redirectToDetails(data.EntityId, url);
        }
    });
}

function deleteObsoleteCategories(id, url, categoriesToDelete, deleteCategoriesUrl) {
    if (id != undefined && id != null) {
        var categoriesIds = new Array();
        for (var i = 0; i < categoriesToDelete.length; i++) {
            categoriesIds[i] = categoriesToDelete[i].Item1;
        }

        $.ajax({
            url: deleteCategoriesUrl + id + '?categoriesToDelete=' + $.toJSON(categoriesIds),
            type: "GET",
            dataType: 'html',
            cache: false,
            success: function (data) {
                redirectToDetails(id, url);
            }
        });
    }
}

function redirectToDetails(id, url) {
    var url = url + id;
    window.replaceUrl(url);
}

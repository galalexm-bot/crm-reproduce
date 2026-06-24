
function AssignMarketingActivity(url, type, noSelectedEntitiesMsg, action, controller, entityName, entitiesNameForErrorMessage)
{
    var selectedEntities = GetSelectedObjects();
        if (selectedEntities.length == 0) {
        jAlert(noSelectedEntitiesMsg, SR.T("Предупреждение"));
        return;
    }
        
    if (selectedEntities.length > 0)
    {
        $.each(selectedEntities, function(i, d) {
            url += '&entitiesId=' + d;
        });

        url += '&entityTypeUid=' + type + '&redirectControllerName=' + controller + '&redirectActionName=' + action + '&entitiesName=' + entityName + '&entitiesNameforErrorMessage=' + entitiesNameForErrorMessage;

        var windowP = $('#MarketingActivitySelectionPopup').data("tWindow");
        windowP.contentUrl = url;
        windowP.loaded = false;
        openWindow('MarketingActivitySelectionPopup','','');           
    }
}

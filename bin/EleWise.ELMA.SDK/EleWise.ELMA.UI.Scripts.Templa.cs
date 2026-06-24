using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.UI.Controllers;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.API;
using EleWise.ELMA.UI.Results;

namespace {NAMESPACE}
{
    
    /// <summary>
    /// {SUMMARY}
    /// </summary>
    public partial class {FORM_NAME}Controller : PortletController<{FORM_NAME}.Content, {FORM_NAME}.Personalization, {FORM_NAME}.Settings>
    {

        /// <summary>
        /// Загрузка содержимого портлета
        /// </summary>
        /// <param name="portlet">Модель портлета</param>
        public override void Content_Load(PortletContentLoadViewModel<{FORM_NAME}.Content, {FORM_NAME}.Personalization> portlet)
        {
        }

    }

}
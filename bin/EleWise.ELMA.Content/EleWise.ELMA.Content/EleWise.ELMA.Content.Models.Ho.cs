using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Content.Models
{

    public partial class HomePageSetting 
    {

         public override string ToString()
        {
            return Page != null ? Page.Name : "";
        }

    }

}
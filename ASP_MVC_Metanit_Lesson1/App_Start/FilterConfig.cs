﻿using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_Metanit_Lesson1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

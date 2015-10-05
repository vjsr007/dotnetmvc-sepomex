﻿using System.Web;
using System.Web.Mvc;
using Catalogos.Filters;

namespace Catalogos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionHandlingAttribute());
        }
    }
}
﻿using ContactManager.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ContactManager
{
    /// <summary>
    /// Global WebApiApplication
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 程序启动时调用
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //注册全局异常过滤器
            GlobalConfiguration.Configuration.Filters.Add(new CustomErrorAttribute());
        }
    }
}

﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyIdeas.Web.Startup))]

namespace MyIdeas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

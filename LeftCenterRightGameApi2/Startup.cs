﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeftCenterRightGameApi2.Startup))]
namespace LeftCenterRightGameApi2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

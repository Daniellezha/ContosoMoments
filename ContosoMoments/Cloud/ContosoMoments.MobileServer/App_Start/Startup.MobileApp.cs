﻿// ---------------------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------------------- 

using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Owin;

namespace ContosoMoments.MobileServer
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            config.EnableSystemDiagnosticsTracing();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Order, BrownOnline>()
            //        .ForMember(dst => dst.Id, map => map.MapFrom(src => SqlFuncs.StringConvert((double)src.OrderId).Trim()));

            //    cfg.CreateMap<BrownOnline, Order>();

            //    cfg.CreateMap<PersonEntity, Person>();

            //    cfg.CreateMap<Person, PersonEntity>();
            //});

            //Database.SetInitializer(new GreenInitializer());
            //Database.SetInitializer(new BrownInitializer());

            //app.UseAppServiceAuthentication(config, AppServiceAuthenticationMode.LocalOnly);
            app.UseWebApi(config);
        }
    }

   
}
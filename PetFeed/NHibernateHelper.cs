using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using PetFeed.Models;

namespace PetFeed
{
    public sealed class NHibernateHelper
    {
        private static readonly NHibernateHelper instance = new NHibernateHelper();
        private static ISessionFactory _sessionFactory;

        public static NHibernateHelper Instance
        {
            get { return instance; }

        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }

        }

        private static void InitializeSessionFactory()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["NHibernate.connectionString"].ConnectionString;

            Debug.WriteLine(connectionString);

            // NHibernate stuff
            _sessionFactory = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard.ConnectionString(connectionString).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Pet>()
                                               .AddFromAssemblyOf<User>())
                .BuildSessionFactory();
        }

        public static ISession OpenSession(){
            return SessionFactory.OpenSession();
        }
    }
}
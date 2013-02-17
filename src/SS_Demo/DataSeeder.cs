using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Counter.ServiceModel.Types;
using ServiceStack.OrmLite;
using ServiceStack.WebHost.Endpoints;

namespace SS_Demo
{
    public class DataSeeder
    {
        public void Seed()
        {
            var dbFactory = AppHostBase.Resolve<IDbConnectionFactory>();
            using(IDbConnection dbConn = dbFactory.OpenDbConnection())
            {
                dbConn.DropAndCreateTable<RepairOrder>();

                dbConn.DropAndCreateTable<ServiceAdvisor>();
                dbConn.Insert(new ServiceAdvisor {Code="MA", Name="Mallory Archer"});
                dbConn.Insert(new ServiceAdvisor {Code="NJ", Name="Nikolai Jackov"});

                dbConn.DropAndCreateTable<MakeModel>();
                dbConn.Insert(new MakeModel() {Make="Chevrolet", Model="El Camino"});
                dbConn.Insert(new MakeModel() {Make="Dodge", Model="Challenger"});
                dbConn.Insert(new MakeModel() {Make="Dodge", Model="Intrepid"});
                dbConn.Insert(new MakeModel() {Make="Cadillac", Model="Escalade"});
                dbConn.Insert(new MakeModel() {Make="Mazda", Model="RX2"});
                dbConn.Insert(new MakeModel() {Make="Mazda", Model="Speed3"});
            }
        }
    }
}
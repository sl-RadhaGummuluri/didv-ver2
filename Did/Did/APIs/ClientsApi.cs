using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

using System.ServiceModel.Web;
using Did.Resources;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Did.APIs
{
    [ServiceContract]
    public class ClientsApi
    {

        [WebGet(UriTemplate = "")]
        public IEnumerable<Client> Get()
        {
            var clients = new List<Client>();
            //{
            //    new Client {ContactId = 1, Name = "Phil Haack"},
            //    new Client {ContactId = 2, Name = "HongMei Ge"},
            //    new Client {ContactId = 3, Name = "Glenn Block"},
            //    new Client {ContactId = 4, Name = "Howard Dierking"},
            //    new Client {ContactId = 5, Name = "Jeff Handley"},
            //    new Client {ContactId = 6, Name = "Yavor Georgiev"}
            //};
            

            string connection = "mongodb://localhost:27017";
            MongoServer mongo = MongoServer.Create(connection);
            mongo.Connect();
            var database = mongo.GetDatabase("did");
            var collection = database.GetCollection<BsonDocument>("clients");

            foreach (BsonDocument item in collection.FindAll())
            {
                Client client = new Client();
                client.Id = item.GetElement("_id").Value.ToString();
                client.client = item.GetElement("client").Value.ToString();
                client.platform = item.GetElement("platform").Value.ToString();
                client.clientlogo = item.GetElement("clientlogo").Value.ToString();
                client.clientcolors = item.GetElement("clientcolors").Value.ToString();
                client.retailsegment = item.GetElement("retailsegment").Value.ToString();
                client.retailsubsegment = item.GetElement("retailsubsegment").Value.ToString();
                client.primaryurl = item.GetElement("primaryurl").Value.ToString();
                client.secondaryurl = item.GetElement("secondaryurl").Value.ToString();
                client.betaurl = item.GetElement("betaurl").Value.ToString();
                client.uaturl = item.GetElement("uaturl").Value.ToString();
                client.qaurl = item.GetElement("qaurl").Value.ToString();
                client.siteid = item.GetElement("siteid").Value.ToString();
                client.campaignid = item.GetElement("campaignid").Value.ToString();
                client.dcsid = item.GetElement("dcsid").Value.ToString();
                client.pretailerid = item.GetElement("pretailerid").Value.ToString();
                client.retailerid = item.GetElement("retailerid").Value.ToString();
                client.apiversion = item.GetElement("apiversion").Value.ToString();
                client.apiurlexample = item.GetElement("apiurlexample").Value.ToString();
                client.mobileoptimized = item.GetElement("mobileoptimized").Value.ToString();
                client.mobilepageviews = item.GetElement("mobilepageviews").Value.ToString();
                client.tabletoptimized = item.GetElement("tabletoptimized").Value.ToString();
                client.supportedbrowserlist = item.GetElement("supportedbrowserlist").Value.ToString();
                client.dynamicpages = item.GetElement("dynamicpages").Value.ToString();
                client.googlemaps = item.GetElement("googlemaps").Value.ToString();
                client.accessibility = item.GetElement("accessibility").Value.ToString();
                client.accessibilityurl = item.GetElement("accessibilityurl").Value.ToString();
                client.spanish = item.GetElement("spanish").Value.ToString();
                client.spanishsiteurl = item.GetElement("spanishsiteurl").Value.ToString();
                client.french = item.GetElement("french").Value.ToString();
                client.frenchsiteurl = item.GetElement("frenchsiteurl").Value.ToString();
                client.sneakpeek = item.GetElement("sneakpeek").Value.ToString();
                client.sneakpeekurl = item.GetElement("sneakpeekurl").Value.ToString();
                client.facebooksite = item.GetElement("facebooksite").Value.ToString();
                client.facebooksiteurl = item.GetElement("facebooksiteurl").Value.ToString();
                client.facebooksiteid = item.GetElement("facebooksiteid").Value.ToString();
                client.facebookdcsid = item.GetElement("facebookdcsid").Value.ToString();
                client.addtocart = item.GetElement("addtocart").Value.ToString();
                client.shoppinglist = item.GetElement("shoppinglist").Value.ToString();
                client.videosupport = item.GetElement("videosupport").Value.ToString();
                client.contentdock = item.GetElement("contentdock").Value.ToString();
                client.headerfooter = item.GetElement("headerfooter").Value.ToString();
                client.coupons = item.GetElement("coupons").Value.ToString();
                client.fullscreenmode = item.GetElement("fullscreenmode").Value.ToString();
                client.socialsharing = item.GetElement("socialsharing").Value.ToString();
                client.storelistnuep = item.GetElement("storelistnuep").Value.ToString();
                client.csd = item.GetElement("csd").Value.ToString();
                client.opsqcstandardurl = item.GetElement("opsqcstandardurl").Value.ToString();
                client.opsam = item.GetElement("opsam").Value.ToString();
                client.regressionscripturl = item.GetElement("regressionscripturl").Value.ToString();
                client.lastregressiondate = item.GetElement("lastregressiondate").Value.ToString();
                client.lastmigratingstory = item.GetElement("lastmigratingstory").Value.ToString();
                client.lastmigratingpackage = item.GetElement("lastmigratingpackage").Value.ToString();
                client.featuredclient = item.GetElement("featuredclient").Value.ToString();
                client.notes = item.GetElement("notes").Value.ToString();

                clients.Add(client);
            }

            mongo.Disconnect(); 
            return clients;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

using System.ServiceModel.Web;
using Did.Resources;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Did.APIs
{
    [ServiceContract]
    public class ClientsApi
    {

        [WebGet(UriTemplate = "")]
        public IEnumerable<Client> Get()
        {
            var clients = new List<Client>();
            string connection = "mongodb://localhost:27017";
            MongoServer mongo = MongoServer.Create(connection);
            mongo.Connect();
            var database = mongo.GetDatabase("did");
            var collection = database.GetCollection<BsonDocument>("slclients");

            foreach (BsonDocument item in collection.FindAll())
            {
                Client client = new Client();
                client.Id = Convert.ToInt32(item.GetElement("_id").Value.ToString());
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
            return clients.OrderBy(x=>x.Id).ToList();
        }

        public void Post(List<string> val)
        {

            string connection = "mongodb://localhost:27017";
            MongoServer mongo = MongoServer.Create(connection);
            mongo.Connect();
            var database = mongo.GetDatabase("did");
            var collection = database.GetCollection<BsonDocument>("slclients");

            Client client = new Client();
            client.Id = Convert.ToInt32(val[0]);
            client.client = val[1];
            client.platform = val[2];
            client.clientlogo = val[3];
            client.clientcolors = val[4];
            client.retailsegment = val[5];
            client.retailsubsegment = val[6];
            client.primaryurl = val[7];
            client.secondaryurl = val[8];
            client.betaurl = val[9];
            client.uaturl = val[10];
            client.qaurl = val[11];
            client.siteid = val[12];
            client.campaignid = val[13];
            client.dcsid = val[14];
            client.pretailerid = val[15];
            client.retailerid = val[16];
            client.apiversion = val[17];
            client.apiurlexample = val[18];
            client.mobileoptimized = val[19];
            client.mobilepageviews = val[20];
            client.tabletoptimized = val[21];
            client.supportedbrowserlist = val[22];
            client.dynamicpages = val[23];
            client.googlemaps = val[24];
            client.accessibility = val[25];
            client.accessibilityurl = val[26];
            client.spanish = val[27];
            client.spanishsiteurl = val[28];
            client.french = val[29];
            client.frenchsiteurl = val[30];
            client.sneakpeek = val[31];
            client.sneakpeekurl = val[32];
            client.facebooksite = val[33];
            client.facebooksiteurl = val[34];
            client.facebooksiteid = val[35];
            client.facebookdcsid = val[36];
            client.addtocart = val[37];
            client.shoppinglist = val[38];
            client.videosupport = val[39];
            client.contentdock = val[40];
            client.headerfooter = val[41];
            client.coupons = val[42];
            client.fullscreenmode = val[43];
            client.socialsharing = val[44];
            client.storelistnuep = val[45];
            client.csd = val[46];
            client.opsqcstandardurl = val[47];
            client.opsam = val[48];
            client.regressionscripturl = val[49];
            client.lastregressiondate = val[50];
            client.lastmigratingstory = val[51];
            client.lastmigratingpackage = val[52];
            client.featuredclient = val[53];
            client.notes = val[54];

           

            IMongoQuery query = Query.EQ("_id", val[0]);
            IMongoUpdate update = Update
            .Set("client", client.client)
            .Set("platform", client.platform)
            .Set("clientlogo", client.clientlogo)
            .Set("clientcolors", client.clientcolors)
            .Set("retailsegment", client.retailsegment)
            .Set("retailsubsegment", client.retailsubsegment)
            .Set("primaryurl", client.primaryurl)
            .Set("secondaryurl", client.secondaryurl)
            .Set("betaurl", client.betaurl)
            .Set("uaturl", client.uaturl)
            .Set("qaurl", client.qaurl)
            .Set("siteid", client.siteid)
            .Set("campaignid", client.campaignid)
            .Set("dcsid", client.dcsid)
            .Set("pretailerid", client.pretailerid)
            .Set("retailerid", client.retailerid)
            .Set("apiversion", client.apiversion)
            .Set("apiurlexample", client.apiurlexample)
            .Set("mobileoptimized", client.mobileoptimized)
            .Set("mobilepageviews", client.mobilepageviews)
            .Set("tabletoptimized", client.tabletoptimized)
            .Set("supportedbrowserlist", client.supportedbrowserlist)
            .Set("dynamicpages", client.dynamicpages)
            .Set("googlemaps", client.googlemaps)
            .Set("accessibility", client.accessibility)
            .Set("accessibilityurl", client.accessibilityurl)
            .Set("spanish", client.spanish)
            .Set("spanishsiteurl", client.spanishsiteurl)
            .Set("french", client.french)
            .Set("frenchsiteurl", client.frenchsiteurl)
            .Set("sneakpeek", client.sneakpeek)
            .Set("sneakpeekurl", client.sneakpeekurl)
            .Set("facebooksite", client.facebooksite)
            .Set("facebooksiteurl", client.facebooksiteurl)
            .Set("facebooksiteid", client.facebooksiteid)
            .Set("facebookdcsid", client.facebookdcsid)
            .Set("addtocart", client.addtocart)
            .Set("shoppinglist", client.shoppinglist)
            .Set("videosupport", client.videosupport)
            .Set("contentdock", client.contentdock)
            .Set("headerfooter", client.headerfooter)
            .Set("coupons", client.coupons)
            .Set("fullscreenmode", client.fullscreenmode)
            .Set("socialsharing", client.socialsharing)
            .Set("storelistnuep", client.storelistnuep)
            .Set("csd", client.csd)
            .Set("opsqcstandardurl", client.opsqcstandardurl)
            .Set("opsam", client.opsam)
            .Set("regressionscripturl", client.regressionscripturl)
            .Set("lastregressiondate", client.lastregressiondate)
            .Set("lastmigratingstory", client.lastmigratingstory)
            .Set("lastmigratingpackage", client.lastmigratingpackage)
            .Set("featuredclient", client.featuredclient)
            .Set("notes", client.notes);
            
            SafeModeResult result = collection.Update(query, update);
            mongo.Disconnect();
        }

    }
}
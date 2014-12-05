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
    public class DataApi
    {
        [WebGet(UriTemplate = "")]
        public IEnumerable<Client> Get()
        {
            //string connection = "mongodb://localhost:27017";
            //MongoServer mongo = MongoServer.Create(connection);
            //mongo.Connect();
            //var database = mongo.GetDatabase("did");
            //var collection = database.GetCollection<BsonDocument>("clients");

            //BsonDocument book = new BsonDocument()
            //                    .Add("_id", BsonValue.Create(BsonType.ObjectId))
            //                    .Add("client", "Aarons")
            //                    .Add("platform", "SC4")
            //.Add("clientlogo", "http://abcwarehouse.shoplocal.com/clients/ABCWarehouse/img/abcwarehouseLogo_website.png")
            //.Add("clientcolors", "")
            //.Add("retailsegment", "Consumer Electronics Computers and Office Supplies")
            //.Add("retailsubsegment", "Consumer Electronics and Computers")
            //.Add("primaryurl", "http,//aarons.shoplocal.com")
            //.Add("secondaryurl", "")
            //.Add("betaurl", "")
            //.Add("uaturl", "")
            //.Add("qaurl", "")
            //.Add("siteid", "1241")
            //.Add("campaignid", "766238e05b971393")
            //.Add("dcsid", "dcsphp8m600000gkq2h370xwi_9v3y")
            //.Add("pretailerid", "-98053")
            //.Add("retailerid", "13590")
            //.Add("apiversion", "")
            //.Add("apiurlexample", "")
            //.Add("mobileoptimized", "N")
            //.Add("mobilepageviews", "N")
            //.Add("tabletoptimized", "N")
            //.Add("supportedbrowserlist", "")
            //.Add("dynamicpages", "N")
            //.Add("googlemaps", "N")
            //.Add("accessibility", "N")
            //.Add("accessibilityurl", "")
            //.Add("spanish", "N")
            //.Add("spanishsiteurl", "")
            //.Add("french", "N")
            //.Add("frenchsiteurl", "")
            //.Add("sneakpeek", "N")
            //.Add("sneakpeekurl", "")
            //.Add("facebooksite", "N")
            //.Add("facebooksiteurl", "")
            //.Add("facebooksiteid", "")
            //.Add("facebookdcsid", "")
            //.Add("addtocart", "N")
            //.Add("shoppinglist", "Y")
            //.Add("videosupport", "N")
            //.Add("contentdock", "N")
            //.Add("headerfooter", "")
            //.Add("coupons", "N")
            //.Add("fullscreenmode", "")
            //.Add("socialsharing", "")
            //.Add("storelistnuep", "N")
            //.Add("csd", "Bret Campion")
            //.Add("opsqcstandardurl", "https://wiki.shoplocal.com/pages/viewpage.action?pageId=69176229")
            //.Add("opsam", "Casey Rady")
            //.Add("regressionscripturl", "")
            //.Add("lastregressiondate", "")
            //.Add("lastmigratingstory", "")
            //.Add("lastmigratingpackage", "https://support.godigitalmarketing.com/issues/?jql=project%20%3D%20MIGR%20AND%20text%20~%20%22aaron%22%20ORDER%20BY%20updated%20DESC")
            //.Add("featuredclient", "")
            //.Add("notes", "");
            //collection.Insert(book);


            //mongo.Disconnect(); 
            return null;

        }

    }
}
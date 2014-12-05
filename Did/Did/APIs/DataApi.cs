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
            string connection = "mongodb://localhost:27017";
            MongoServer mongo = MongoServer.Create(connection);
            mongo.Connect();
            var database = mongo.GetDatabase("did");
            var collection = database.GetCollection<BsonDocument>("slclients");

            BsonDocument book = new BsonDocument()
                               .Add("_id", 106)
                               .Add("client", "Walgreens")
        .Add("platform", "MVC")
        .Add("clientlogo", "http://img.walgreens.com/images/adaptive/share/images/logos/walgreens-logo-desktop.png")
        .Add("clientcolors", "Red")
        .Add("retailsegment", "Food and Drug")
        .Add("retailsubsegment", "Drug")
        .Add("primaryurl", "http://walgreens.shoplocal.com")
        .Add("secondaryurl", "http://walgreens2.shoplocal.com")
        .Add("betaurl", "http://betascmvc.shoplocal.com/walgreens")
        .Add("uaturl", "http://origin-u01smartcircularmvc.shoplocal.com/walgreens")
        .Add("qaurl", "http://origin-qa01smartcircularmvc.shoplocal.com/walgreens")
        .Add("siteid", "1576")
        .Add("campaignid", "e4d5e311cadb36cb")
        .Add("dcsid", "dcsa2zguj10000sh06c3kotu6_9i7y")
        .Add("pretailerid", "-99389")
        .Add("retailerid", "12271")
        .Add("apiversion", "2013.1")
        .Add("apiurlexample", "http://api2.shoplocal.com/retail/e4d5e311cadb36cb/2013.1/json/promotionpagelistingsandhotspots?storeid=2424938&promotionid=108911&promotioncode=walgreens-141130&languageid=1&resultset=full&listinglinks=n&sneakpeek=n&reviewsflag=n&heatindex=n&versionflag=y&promotionpageid=4625448")
        .Add("mobileoptimized", "Y")
        .Add("mobilepageviews", "Y")
        .Add("tabletoptimized", "Y")
        .Add("supportedbrowserlist", "Latest IE, Firefox, Chrome")
        .Add("dynamicpages", "N")
        .Add("googlemaps", "N")
        .Add("accessibility", "Y")
        .Add("accessibilityurl", "NA")
        .Add("spanish", "N")
        .Add("spanishsiteurl", "N")
        .Add("french", "N")
        .Add("frenchsiteurl", "N")
        .Add("sneakpeek", "Y")
        .Add("sneakpeekurl", "http://walgreens2.shoplocal.com/WalgreensSneakPeek")
        .Add("facebooksite", "Y")
        .Add("facebooksiteurl", "https://www.facebook.com/Walgreens/app_117077138321196?ref=page_internal")
        .Add("facebooksiteid", "1245 (Puerto Rico=1472)")
        .Add("facebookdcsid", "dcsgpb9wnvz5bdqg9uxrfxipi_4m2d (Puerto Rico=dcsdl4gb100000gcg95s3s3sp_6j5m)")
        .Add("addtocart", "Y")
        .Add("shoppinglist", "N")
        .Add("videosupport", "Y")
        .Add("contentdock", "N")
        .Add("headerfooter", "Y")
        .Add("coupons", "Y")
        .Add("fullscreenmode", "Y")
        .Add("socialsharing", "Y")
        .Add("storelistnuep", "N")
        .Add("csd", "Chris Stone")
        .Add("opsqcstandardurl", "https://wiki.godigitalmarketing.com/display/CONPRO/Walgreen%27s+QC+Standards")
        .Add("opsam", "Patty Fernandez")
        .Add("regressionscripturl", "https://wiki.godigitalmarketing.com/display/TECH/Walgreens+-+SC+Custom+-+Regression+Script")
        .Add("lastregressiondate", "11/19/2014")
        .Add("lastmigratingstory", "MIG-630")
        .Add("lastmigratingpackage", "https://support.godigitalmarketing.com/issues/?jql=project%20%3D%20MIGR%20AND%20text%20~%20%22walgreens%22%20ORDER%20BY%20updated%20DESC")
        .Add("featuredclient", "")
        .Add("notes", "Walgreens Integration testing is highly dependent on Walgreens API to be up and running. Coupons need to be set up by Ops and should be in sync with Walgreens and coupon.com");

	

            collection.Insert(book);


            mongo.Disconnect(); 
            return null;

        }

    }
}
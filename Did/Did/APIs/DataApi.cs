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
            var collection = database.GetCollection<BsonDocument>("clients");

            BsonDocument book = new BsonDocument()
                               .Add("_id", 6)


.Add("client","BrandsMart USA")
.Add("platform","SC Standard")
.Add("clientlogo","http://brandsmart.shoplocal.com/clients/Brandsmart/img/brandsmartLogo_website.png")
.Add("clientcolors","Blue/Red")
.Add("retailsegment","Consumer Electronics, Computers and Office Supplies")
.Add("retailsubsegment","Consumer Electronics and Computers")
.Add("primaryurl","http://brandsmart.shoplocal.com/")
.Add("secondaryurl","")
.Add("betaurl","http://betascpv2.shoplocal.com/index.html#!/brandsmart")
.Add("uaturl","http://origin-u01scpremiumv2.shoplocal.com/index.html#!/brandsmart")
.Add("qaurl","http://origin-qa01scpremiumv2.shoplocal.com/index.html#!/brandsmart")
.Add("siteid","1542")
.Add("campaignid","2224bc7b0078d353")
.Add("dcsid","dcsd5kbql00000wwe6zjg506u_6w4v")
.Add("pretailerid","-98373")
.Add("retailerid","13298")
.Add("apiversion","2013.1")
.Add("apiurlexample","http://api2.shoplocal.com/retail/2224bc7b0078d353/2013.1/xml/promotions?citystatezip=90210&reload=y")
.Add("mobileoptimized","Y")
.Add("mobilepageviews","N")
.Add("tabletoptimized","Y")
.Add("supportedbrowserlist","Latest IE, Firefox and Chrome")
.Add("dynamicpages","N")
.Add("googlemaps","Y")
.Add("accessibility","N")
.Add("accessibilityurl","N")
.Add("spanish","Y")
.Add("spanishsiteurl","http://brandsmart.shoplocal.com/index.html?usemaps=y#!/brandsmartspanish")
.Add("french","N")
.Add("frenchsiteurl","N/A")
.Add("sneakpeek","N")
.Add("sneakpeekurl","N/A")
.Add("facebooksite","N")
.Add("facebooksiteurl","N/A")
.Add("facebooksiteid","N/A")
.Add("facebookdcsid","N/A")
.Add("addtocart","N")
.Add("shoppinglist","N")
.Add("videosupport","N")
.Add("contentdock","N")
.Add("headerfooter","Static")
.Add("coupons","N")
.Add("fullscreenmode","N")
.Add("socialsharing","Y")
.Add("storelistnuep","N")
.Add("csd","John Gross")
.Add("opsqcstandardurl","https://wiki.shoplocal.com/pages/viewpage.action?pageId=69176236")
.Add("opsam","K Shelton")
.Add("regressionscripturl","https://wiki.godigitalmarketing.com/display/TECH/SC+Premium+%28v2%29+Regression+Script")
.Add("lastregressiondate","8/7/2014")
.Add("lastmigratingstory","US24385")
.Add("lastmigratingpackage","https://support.godigitalmarketing.com/issues/?jql=project%20%3D%20MIGR%20AND%20text%20~%20%22brandsmart%22%20ORDER%20BY%20updated%20DESC")
.Add("featuredclient","")
.Add("notes","");
	

            collection.Insert(book);


            mongo.Disconnect(); 
            return null;

        }

    }
}
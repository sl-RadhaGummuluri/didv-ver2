using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
namespace Did.Resources
{
    public class Client
    {
        [BsonId]
        public string Id { get; set; }
        public string client { get; set; }
        public string platform { get; set; }
        public string clientlogo { get; set; }
        public string clientcolors { get; set; }
        public string retailsegment { get; set; }
        public string retailsubsegment { get; set; }
        public string primaryurl { get; set; }
        public string secondaryurl { get; set; }
        public string betaurl { get; set; }
        public string uaturl { get; set; }
        public string qaurl { get; set; }
        public string siteid { get; set; }
        public string campaignid { get; set; }
        public string dcsid { get; set; }
        public string pretailerid { get; set; }
        public string retailerid { get; set; }
        public string apiversion { get; set; }
        public string apiurlexample { get; set; }
        public string mobileoptimized { get; set; }
        public string mobilepageviews { get; set; }
        public string tabletoptimized { get; set; }
        public string supportedbrowserlist { get; set; }
        public string dynamicpages { get; set; }
        public string googlemaps { get; set; }
        public string accessibility { get; set; }
        public string accessibilityurl { get; set; }
        public string spanish { get; set; }
        public string spanishsiteurl { get; set; }
        public string french { get; set; }
        public string frenchsiteurl { get; set; }
        public string sneakpeek { get; set; }
        public string sneakpeekurl { get; set; }
        public string facebooksite { get; set; }
        public string facebooksiteurl { get; set; }
        public string facebooksiteid { get; set; }
        public string facebookdcsid { get; set; }
        public string addtocart { get; set; }
        public string shoppinglist { get; set; }
        public string videosupport { get; set; }
        public string contentdock { get; set; }
        public string headerfooter { get; set; }
        public string coupons { get; set; }
        public string fullscreenmode { get; set; }
        public string socialsharing { get; set; }
        public string storelistnuep { get; set; }
        public string csd { get; set; }
        public string opsqcstandardurl { get; set; }
        public string opsam { get; set; }
        public string regressionscripturl { get; set; }
        public string lastregressiondate { get; set; }
        public string lastmigratingstory { get; set; }
        public string lastmigratingpackage { get; set; }
        public string featuredclient { get; set; }
        public string notes { get; set; }
    }
}
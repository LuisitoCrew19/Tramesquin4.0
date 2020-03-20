using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Tramesquin.Clases
{
    public class Productos
    {
        static void Main(string[] args)
        {
            MongoClient dbClient = new MongoClient("mongodb://cluster0-shard-00-02-p2ur1.mongodb.net:27017");

            var database = dbClient.GetDatabase("Proyecto_Final");
            var collection = database.GetCollection<BsonDocument>("Productos");

        }
    }
}
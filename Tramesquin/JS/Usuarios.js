
$(document).ready(function () {
    var MongoClient = require('mongodb').MongoClient;
    var url = "mongodb:// cluster0-shard-00-02-p2ur1.mongodb.net:27017/";
 $(".btnAceptar").click(function () {
        MongoClient.connect(url, function (err, db) {
            if (err) throw err;
            var dbo = db.db("Proyecto_Final");
            dbo.collection("Usuarios").findOne({}, function (err, result) {
                if (err) throw err;
                console.log(result.name);
                db.close();
            });
        });
    });
});

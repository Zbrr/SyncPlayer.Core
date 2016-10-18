
require("./../lib/bootstrap/dist/css/bootstrap.css")
require("./layout.scss");

class IndexClass {
    writeSomething() {
        console.log("index");
    }
}

var indexClass = new IndexClass();
indexClass.writeSomething();

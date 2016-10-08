
require("./../lib/bootstrap/dist/css/bootstrap.css")

class IndexClass {
    writeSomething() {
        console.log("index");
    }
}

var indexClass = new IndexClass();
indexClass.writeSomething();

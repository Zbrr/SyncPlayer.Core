var IndexClass = (function () {
    function IndexClass() {
    }
    IndexClass.prototype.writeSomething = function () {
        console.log("index");
    };
    return IndexClass;
}());
var indexClass = new IndexClass();
indexClass.writeSomething();
//# sourceMappingURL=app.js.map
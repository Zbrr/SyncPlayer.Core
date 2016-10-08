var common = require('./common');
var AboutClass = (function () {
    function AboutClass() {
    }
    AboutClass.prototype.writeSomething = function () {
        console.log("about");
    };
    return AboutClass;
}());
var aboutClass = new AboutClass();
aboutClass.writeSomething();
//# sourceMappingURL=about.js.map
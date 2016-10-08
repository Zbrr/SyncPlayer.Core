var CommonClass = (function () {
    function CommonClass() {
    }
    CommonClass.prototype.writeSomething = function () {
        console.log("common");
    };
    return CommonClass;
}());
var commonClass = new CommonClass();
commonClass.writeSomething();
//# sourceMappingURL=common.js.map
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Query_1 = require("./Query");
var Cube = /** @class */ (function () {
    function Cube() {
        this.ArrayPtos = [];
        this.ArrayRptas = [];
        this.Queries = [];
    }
    Object.defineProperty(Cube.prototype, "_dimension", {
        get: function () {
            return this.Dimension;
        },
        set: function (value) {
            this.Dimension = value;
            this.ArrayPtos = [];
            for (var i = 1; i <= this.Dimension; i++) {
                this.ArrayPtos.push(i);
            }
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Cube.prototype, "_operaciones", {
        get: function () {
            return this.Operaciones;
        },
        set: function (value) {
            this.Operaciones = value;
            this.Queries = [];
            for (var i = 0; i < this.Operaciones; i++) {
                var query = new Query_1.Query();
                this.Queries.push(query);
            }
        },
        enumerable: true,
        configurable: true
    });
    return Cube;
}());
exports.Cube = Cube;
//# sourceMappingURL=Cube.js.map
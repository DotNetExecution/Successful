'use strict';

module.exports = function (gulp, config, plugins) {
    return {
        deps: [],
        params: [],
        fn: function () {
            plugins.bower();
        }
    };
};
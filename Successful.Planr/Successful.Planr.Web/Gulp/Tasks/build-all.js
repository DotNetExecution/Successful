'use strict';

module.exports = function (gulp, config, plugins) {

    return {
        deps: ['clean:all', 'compile:sass', 'prepare:css'],
        params: [],
        fn: function () {
        }
    };
};
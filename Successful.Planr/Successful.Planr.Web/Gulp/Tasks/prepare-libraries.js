'use strict';

module.exports = function (gulp, config, plugins) {
    return {
        deps: ['install:libraries'],
        params: [],
        fn: function () {
            gulp.src(plugins.mainBowerFiles())
            .pipe(gulp.dest(config.paths.destinations.libraries));
        }
    };
};
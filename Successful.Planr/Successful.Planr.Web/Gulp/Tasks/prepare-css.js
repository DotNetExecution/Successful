'use strict';

module.exports = function (gulp, config, plugins) {
    return {
        deps: [],
        params: [],
        fn: function (callback) {
            gulp.src(config.paths.destinations.styles)
                .pipe(plugins.sourcemaps.init())
                .pipe(plugins.autoprefixer('last 2 version'))
                .pipe(plugins.if(config.isProduction, plugins.concat('temp.css')))
                .pipe(plugins.if(config.isProduction, plugins.minify({ compatibility: 'ie9' })))
                .pipe(plugins.if(config.isProduction, plugins.rename('successful.styles.min.css')))
                .pipe(plugins.sourcemaps.write())
                .pipe(gulp.dest(config.paths.destinations.styles));

            callback();
        }
    };
};
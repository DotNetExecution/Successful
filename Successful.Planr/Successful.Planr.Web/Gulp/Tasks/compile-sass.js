'use strict';

module.exports = function (gulp, config, plugins) {
    return {
        deps: [],                                               
        params: [],                                             
        fn: function () {                                       
            gulp.src(config.paths.sources.styles)
           .pipe(plugins.if(config.isProduction, plugins.sass({ outputStyle: 'compressed' }), plugins.sass({ outputStyle: 'expanded' }).on('error', plugins.sass.logError)))
           .pipe(gulp.dest(config.paths.destinations.styles));
        }
    };
};
'use strict';

module.exports = function (gulp, config, plugins) {
    return {
        deps: [],                                    
        params: [],                                 
        fn: function () {
            plugins.del([
                // This will delete all files in folder!
                config.paths.destinations.wwwroot,
                '!wwwroot/web.config'
            ]);
        }
    };
};
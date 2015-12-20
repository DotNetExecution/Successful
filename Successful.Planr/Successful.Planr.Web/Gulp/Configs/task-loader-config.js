'use strict';

module.exports = {

    isProduction: true,

    paths: {
        sources: {
            styles: 'Assets/Styles/**/*.scss',
            scripts: 'Assets/Scripts/**/*.{ts, js}'
        },
        destinations: {
            wwwroot: 'wwwroot',
            assets: 'wwwroot/Assets',
            styles: 'wwwroot/Assets/Styles',
            scripts: 'wwwroot/Assets/Scripts',                      // Here do we place non domain related scripts that can be reused.
            libraries: 'wwwroot/Assets/Libraries'
        }
    }

};
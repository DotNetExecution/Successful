'use strict';

var gulp = require('gulp');

var plugins = require('gulp-load-plugins')({
    DEBUG: false,
    rename: {
        'gulp-minify-css': 'minify',
        'gulp-bower-files': 'bowerFiles'
    }
});

// Adding non gulp tasks.
plugins.del = require('del');                                // Lets you delete files.

// Loads all the tasks.
var taskLoader = require('gulp-simple-task-loader')({
    taskDirectory: 'Build/GulpTasks',                        // The directory your tasks are stored in (relative and absolute paths accepted) 
    configFile: '../Configs/task-loader-config.js',          // The relative path to your task configuration file from your task directory
    filenameDelimiter: '-',                                  // A character or string of characters to replace in task filenames 
    tasknameDelimiter: ':',                                  // A character or string of characters to insert in place of removed filenameDelimiter 
    plugins: plugins                                         // Populates the loader with the plug-ins.
});

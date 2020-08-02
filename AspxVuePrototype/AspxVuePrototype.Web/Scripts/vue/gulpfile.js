var gulp = require("gulp"),
    path = require('path'),
    shell = require("gulp-shell");


gulp.task("watch:npm", function (done) {
    gulp.watch(["./package.json"], ["npm-install"]);
});

/*
Runs webpack once
*/
gulp.task('webpack', shell.task(['webpack']));

gulp.task('serve', shell.task(['npm run serve']));

/*
 * Install npm modules
 */
gulp.task('npm-install', shell.task(['npm install']));






// Logs error and continues processing
function logError(error) {
    console.log(error.toString());
    this.emit("end");
}

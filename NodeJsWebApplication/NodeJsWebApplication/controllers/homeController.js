(function (homeController) {
  'use strict';

  homeController.init = function (app) {
      
    app.get('/', function (req, res) {
      var model = { time: new Date().toISOString() };
      res.render('index', model);
    });
  };
})(module.exports);
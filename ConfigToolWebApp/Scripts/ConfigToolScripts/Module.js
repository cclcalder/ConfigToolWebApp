//Get ag-Grid to create an Angular module and register the ag-Grid directive
agGrid.initialiseAgGridWithAngular1(angular);

var app = angular.module("configToolApp",
    ['ui.bootstrap', 'ngResource', "ngMaterial", "ngAnimate", "ngAria", 'ngRoute', "agGrid"]
);
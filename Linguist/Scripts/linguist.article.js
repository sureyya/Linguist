
/// <reference path="3thParty/_references.js" />

$(function () {

    var mapping = {
        'Article': {
            create: function (options) {
                return new articleViewModel(options.data);

            }
        }
    };

    var sentenceMapping = {
        'Sentences': {
            create: function (options) {
                return new sentenceViewModel(options.data);

            }
        }
    };

    var wordMapping = {
        'Words': {
            create: function (options) {
                return new wordViewModel(options.data);
            }
        }
    };

    var articleViewModel = function (data) {
        var self = this;
        ko.mapping.fromJS(data, sentenceMapping, self);
    };

    var sentenceViewModel = function (data) {
        var self = this;
        ko.mapping.fromJS(data, wordMapping, self);
    };

    var wordViewModel = function (data) {
        var self = this;
        self.Id = ko.observable(data.Id);
        self.Order = ko.observable(data.Order);
        self.Text = ko.observable(data.Text);
        self.selected = function () {
            console.log(self);
            $.post("/ArticleDataService/GetTranslation", { wordId: self.Id() }, function (translationData) {
                var translation = ko.toJS(translationData);
                var viewModel = new translationViewModel(translation.Translation.Content);
                console.log(translation);
                ko.applyBindings(viewModel, $("#translatedText")[0]);
            });

        };
        self.BorderEnabled = ko.observable(false);
        self.enableBorder = function () {
            self.BorderEnabled(true);
        };
        self.disableBorder = function () {
            self.BorderEnabled(false);
        };        
    };

    var translationViewModel = function (translation) {
        var self = this;
        self.Text = ko.observable(translation);
    };



    $.getJSON("/ArticleDataService/GetArticleDetail", { id: _articleId }, function (data) {
        var article = ko.toJS(data);
        var viewModel = ko.mapping.fromJS(article, mapping);
        console.log(ko.mapping.toJS(viewModel));
        ko.applyBindings(viewModel);
    });


    //console.log(ko.mapping.toJS(viewModel));

}());

/// <reference path="3thParty/_references.js" />

$(function () {


    var translateEditorViewModel = function () {
        var self = this;

        self.cases = ko.observableArray(["Nominative", "Accusative", "Dative", "Locative", "Genitive", "Instrumental"]);
        self.types = ko.observableArray(["Noun", "Pronoun", "Verb", "Adverb", "Adjective", "Other"]);

        self.Type = ko.observable("Noun");
        self.Case = ko.observable("Nominative");

        self.Content = ko.observable("Test text");
        self.save = function () {
            $.ajax({
                url: "translate",
                type: "POST",
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                data: ko.toJSON(self)
            });

        };


    };

    ko.applyBindings(new translateEditorViewModel());

});

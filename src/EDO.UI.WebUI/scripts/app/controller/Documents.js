Ext.define('EDO.controller.Documents', {
    extend: 'EDO.controller.Base',
    views: [
        'documents.Index',
        'documents.Create',
        'documents.Export'
    ],

    create: function (request) {
        this.render("workspace", this["get" + this.id + "CreateView"]());
    },

    export: function (request) {
        this.render("workspace", this["get" + this.id + "ExportView"]());
    },

    hasRights: function () {
        return true;
    }
});
Ext.define('MDBAdmin.model._common.Servers', {
    extend: 'Ext.data.Model',
    alias: 'widget.mdba-ServersList',

    fields: [

    ],

    statics: {
        getStore: function () {
            var store = Ext.create('Ext.data.TreeStore', {
                root: {
                    expanded: true,
                    children: [
                        { text: "detention", leaf: true },
                        {
                            text: "homework", expanded: true, children: [
                              { text: "book report", leaf: true },
                              { text: "algebra", leaf: true }
                            ]
                        },
                        { text: "buy lottery tickets", leaf: true }
                    ]
                }
            });

            return store;
        }
    }

});
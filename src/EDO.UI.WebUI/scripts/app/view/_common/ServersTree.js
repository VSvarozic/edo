Ext.define('MDBAdmin.view._common.ServersTree', {
    extend: 'Ext.Panel',
    alias: 'widget.mdba-ServersTree',

    requires: [
        'MDBAdmin.model._common.Servers'
    ],

    layout: {
        type: 'fit'
    },

    border: false,

    initComponent: function () {
        var self = this;
        console.log()
        var store = MDBAdmin.model._common.Servers.getStore();

        this.dockedItems = [{
            dock: 'top',
            xtype: 'toolbar',
            items: [{
                xtype: 'button',
                text: 'Settings',
                action: 'settings'
            }, {
                xtype: 'buttongroup',
                items: [{
                    text: 'By Date',
                    action: 'filter-date'
                }, {
                    text: 'ABC',
                    action: 'filter-name'
                }]
            }]
        }];

        this.items = [
            {
                xtype: 'treepanel',
                width: '100%',
                store: store,
                rootVisible: false,
                border: false
            }
        ];
        console.log(MDBAdmin);
        this.callParent(arguments);
    }
});
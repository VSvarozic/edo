Ext.define('EDO.view.Viewport', {
    extend: 'Ext.container.Viewport',

    requires: [
        'EDO.view.layout.NorthPanel',
        'EDO.view.layout.ContentPanel',
        'EDO.view.layout.SouthPanel'
    ],

    layout: 'border',
    autoWidth: true,
    autoHeight: true,

    initComponent: function () {
        this.ids = {
            northPanelId: Ext.id(),
            centerPanelId: Ext.id(),
            southPanelId: Ext.id(),
            layoutCenterContainerId: Ext.id()
        };

        Ext.apply(this, {
            items: [
                {
                    region: 'north',
                    border: false,
                    id: this.ids.northPanelId,
                    xtype: 'NorthPanel'
                },
                {
                    region: 'center',
                    autoScroll: true,
                    border: false,
                    id: this.ids.layoutCenterContainerId,
                    items: [
                      {
                          xtype: 'ContentPanel',
                          id: this.ids.centerPanelId
                      }
                    ]
                },
                {
                    region: 'south',
                    xtype: 'SouthPanel',
                    id: this.ids.southPanelId
                }
            ]
        });

        this.callParent(arguments);
    }
});
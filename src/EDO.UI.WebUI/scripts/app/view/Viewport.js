Ext.define('MDBAdmin.view.Viewport', {
    extend: 'Ext.container.Viewport',

    requires: [
        'MDBAdmin.view._common.Brand',
        'MDBAdmin.view._common.AuthInfo',
        'MDBAdmin.view._common.ServersTree'
    ],

    layout: 'fit',

    initComponent: function () {
        this.items = {
            xtype: 'panel',
            dockedItems: [
                {
                    dock: 'top',
                    xtype: 'toolbar',
                    height: 80,
                    items: [
                        {
                            xtype: 'mdba-Brand',
                            height: 70,
                            flex: 0.7
                        },
                        {
                            xtype: 'mdba-AuthInfo',
                            height: 70,
                            flex: 0.3
                        }
                    ]
                },
                {
                    dock: 'bottom',
                    xtype: 'toolbar',
                    height: 50,
                    items: [
                    ]
                }
            ],
            layout: {
                type: 'fit'
            },
            items: {
                xtype: 'panel',
                layout: {
                    type: 'border'
                },
                bodyBorder: false,
                border: false,
                defaults: {
                    collapsible: true,
                    split: true                    
                },
                items: [
                    {
                        region: 'west',
                        width: 275,
                        minWidth: 250,
                        maxWidth: 550,
                        header :false,
                        layout: {
                            type: 'border'
                        },
                        items: [
                            {
                                title: 'Список серверов',
                                region: 'center',
                                minHeight: 200,
                                collapsible: false,
                                items: {
                                    xtype: 'mdba-ServersTree'
                                }
                            },
                            {
                                title: 'Info panel',
                                region: 'south',
                                minHeight: 100,
                                split: true,
                                collapsible: true,
                                items: {
                                    xtype: 'component',
                                    layout: 'fit',
                                    html: 'Some info will be here'
                                }
                            }
                        ]
                    },
                    {
                        title: 'Main Content',
                        collapsible: false,
                        region: 'center',
                        margins: '0 0 0 0',
                        bodyPadding: 15,
                        html: 'Main Page This is where the main content would go'
                    }
                ]
            }
        };

        this.callParent(arguments);
    }
});
Ext.ns('EDO');
Ext.ns('EDO.Core');
Ext.ns('EDO.Core.User');

Ext.define('EDO.view._common.TopUserInformer', {
    extend: 'Ext.panel.Panel',
    alias: 'widget.edo-userinformer',

    requires: [
        
    ],

    layout: {
        type: 'vbox',
        align: 'stretch'
    },
    header: false,
    border: false,
    height: 70,
    padding: '5 10',
    margin: '5 10',
    minWidth: 300,
    maxWidth: 500,
    baseCls: 'top-userInformer',

    initComponent: function() {
        var me = this;

        console.log(EDO.Core.User);

        Ext.apply(this, {
            
            defaults: {
                xtype: 'container',
                cls: 'top-userInformerItem'
            },
            items: [
              {
                  html: "Название компании",
                  flex: 1
              },
              {
                  html: "ФИО пользователя",
                  flex: 1
              },
              {
                  html: '<a href="/#user">Настройки</a>'
              }
            ]
        });

        me.callParent(arguments);
    }
});
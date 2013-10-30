Ext.define('EDO.view.layout.NorthPanel', {
    extend: 'Ext.Panel',
    alias: 'widget.NorthPanel',
    frame: false,
    border: false,
    align: 'stretch',
    autoHeight: true,

    items: [
    {
        xtype: 'panel',
        id: 'account_panel_placeholder',
        border: false,
        frame: false,
        layout: 'hbox',
        items: [
          {
              border: false,
              frame: false,
              height: 80,
              cls: 'page-header',
              html: '<a href="/"><img src="/Content/images/logo.gif" class="logo-image"></a>'
          },
          {
              xtype: 'tbfill'
          }
        ]
    }
    ]
});
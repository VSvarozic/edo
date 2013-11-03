Ext.define('EDO.view._common.UserMenu', {
    extend: 'Ext.toolbar.Toolbar',
    alias: 'widget.edo-usermenu',
    
    store: 'EDO.model.Menu',
    
    menus: [],

    initComponent: function () {
        
        var me = this,
            menuList = [];

        menuList = me._buildMenuTree(me.menus);

        Ext.apply(me, {
            xtype: 'toolbar',
            autoHeight: true,
            width: 'auto',
            items: menuList
        });


        me.callParent(arguments);
    },
    
    _buildMenuTree: function (inList) {
        var outList = [];

        console.log(this.store);
        
        if (!inList || inList.length === 0) return;

        for (var i in inList) {
            var item = inList[i];

            if (item.items && item.items.length > 0) {
                outList.push({
                    text: item.text,
                    menu: {
                        items: this._buildMenuTree(item.items)
                    }
                });
            } else {
                outList.push({
                    text: item.text,
                    hrefTarget: '_self',
                    href: this._buildMenuItemUrl(item)
                });
            }
        }

        return outList;
    },

    _buildMenuItemUrl: function (item) {
        var url = '#' + item.controller;

        if (item.action && item.action != 'index') {
            url = url + '/' + item.action;
        }
        return url;
    }
});
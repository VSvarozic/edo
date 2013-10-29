Ext.Loader.setConfig({
    enabled:true,
    disableCaching:true,
    paths:{
        'Ext.ux':'/scripts/app/lib/ux',
        'Ext.ux.app':'/scripts/app/lib/ux/app'
    }
});

// enable state
Ext.state.Manager.setProvider(new Ext.state.CookieProvider({
    expires:new Date(new Date().getTime() + (1000 * 60 * 60 * 24 * 7)) //7 days from now
}));

Ext.tip.QuickTipManager.init();
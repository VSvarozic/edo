Ext.define('EDO.store.Menu', {
    extend: 'Ext.data.Store',

    model: 'EDO.model.Menu',

    proxy: {
        type: 'rest',
        url: '/api/sitemenu',
        reader: {
            type: 'json',
            root: 'menu'
        }
    }
});
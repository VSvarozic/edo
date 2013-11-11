Ext.define('EDO.store.Stores', {
    extend: 'Ext.data.Store',

    // Как-то разобраться с асинхронной загрузкой моделей
    // В частности UserInfo
    // http://stackoverflow.com/questions/11003605/how-to-wait-until-all-stores-are-loaded-in-extjs
    // http://stackoverflow.com/questions/14441769/store-load-before-main-application-viewport-load
    // http://www.sencha.com/forum/showthread.php?175387-Loading-store-before-application-launch
});
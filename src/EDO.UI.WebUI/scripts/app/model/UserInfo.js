Ext.define('EDO.model.UserInfo', {
    extend: 'Ext.data.Model',

    fields: [
        {
            name: 'userId',
            dataType: 'string'
        },
        {
            name: 'name',
            dataType: 'string'
        },
        {
            name: 'businessName',
            dataType: 'string'
        },
        {
            name: 'officeName',
            dataType: 'string'
        }
    ],

    proxy: {

        type: 'rest',
        url: '/api/userinfo',
        timeout: 120000,
        noCache: true,

        reader:
        {
            type: 'json',
            root: 'data',
            successProperty: 'success'
        },

        afterRequest: function (request, success) {
            if (request.action == 'read') {
                this.readCallback(request);
            }
        },

        //After Albums fetched

        readCallback: function (request) {
            if (!request.operation.success) {
                Ext.Msg.show(
                                {
                                    title: 'Warning',
                                    msg: 'Could not load Menu. Please try again.',
                                    buttons: Ext.Msg.OK,
                                    icon: Ext.Msg.WARNING
                                });
            }
        }
    }

});
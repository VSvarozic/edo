
Ext.require('Ext.ux.app.RoutedApplication', function () {
    App = Ext.create('Ext.ux.app.RoutedApplication', {        
        
        name: 'EDO',
        appFolder: 'scripts/app',

        requires: [
            'EDO.view.Viewport'
        ],

        controllers: [
            'Base',
            'Dashboard',
            'Documents'
        ],
              
        
        
        launch: function() {
            var me = this;

            // create Viewport instance
            this.viewport = Ext.create('EDO.view.Viewport', {
                controller: this
            });

            var workspace = this.viewport.down('container[region=center]');
            this.addLayout('workspace', workspace);
            Ext.defer(this.hideLoadingScreen, 250);

            Ext.History.init(me.initDispatch, me);
            Ext.History.on('change', me.historyChange, me);

            // Start with dashboard
            token = Ext.History.getToken();
            if (token == null) {
                Ext.History.add('dashboard', true);
            }


            // Инициализируем Menu
            this.initMenu();
        },

        initDispatch: function () {
            var me = this,
                token = Ext.History.getToken();
            Ext.log('Init dispatch with token: ' + token);
            me.historyChange(token);
        },

        historyChange: function (token) {
            var me = this;
            // and check if token is set
            Ext.log('History changed to: ' + token);
            if (token) {
                Ext.dispatch(token);
            }
        },
        hideLoadingScreen: function () {
            Ext.get('loading').remove();
            Ext.fly('loading-mask').animate({
                opacity: 0,
                remove: true
            });
        },
        initUserAcl: function() {
            return [
                {
                    text: 'Главная',
                    controller: 'dashboard',
                    action: 'index'
                },
                {
                    text: 'Документы',
                    items: [
                        {
                            text: 'Главная 23',
                            controller: 'documents',
                            action: 'index'
                        },
                        {
                            text: 'Главная 45',
                            controller: 'documents',
                            action: 'index22'
                        },
                        {
                            text: 'Главная 65',
                            controller: 'documents',
                            action: 'index23'
                        }
                    ]
                }
            ];
        },
        initMenu: function () {            
            var northpanel = Ext.getCmp(this.viewport.ids.northPanelId),
                menuList = this.initUserAcl(),
                topMenu = Ext.create('EDO.view._common.UserMenu', {
                            menus: menuList
                          });

            northpanel.insert(northpanel.items.getCount(), topMenu);

        }
    });
});
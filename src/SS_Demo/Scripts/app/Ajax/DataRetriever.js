Ext.define('DataRetriever', {
    GetStore: function (url, model, root, autoLoad) {
        var store = Ext.create('Ext.data.Store', {
            autoLoad: autoLoad || false,
            model: model,
            proxy: new Ext.data.HttpProxy({
                method: 'GET',
                url: url,
                reader: {
                    type: 'json',
                    root: root,
                    totalProperty: 'totalRecords'
                }
            })
        });

        return store;
    }
})
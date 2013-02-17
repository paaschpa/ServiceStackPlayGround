Ext.define('OrdersGrid', {
    extend: 'Ext.grid.Panel',

    initComponent: function () {
        Ext.applyIf(this, {
            columns: [
                { header: 'Code', dataIndex: 'code' },
                { header: 'Advisor', dataIndex: 'advisorName' },
                { header: 'Customer', dataIndex: 'customerName' },
                {
                    header: 'Vehicle', renderer: function (value, meta, record) {
                        return record.get('year') + ' ' + record.get('make') + ' ' + record.get('model');
                    }
                },
                { header: 'Promise Date', dataIndex: 'promiseDate', xtype: 'datecolumn', renderer: function (value) {
                    return Ext.Date.format(value, 'm-d-Y');
                }
                },
                { header: 'Status', dataIndex: 'status' }
            ]
        });

        this.callParent(arguments);
    }
});
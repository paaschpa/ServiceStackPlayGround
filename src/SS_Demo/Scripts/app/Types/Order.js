Ext.define('Order', {
    extend: 'Ext.data.Model',
    fields: [
        'code',
        'advisorId',
        'advisorName',
        'customerName',
        'year',
        'make',
        'model',
        'vin',
        { name: 'promiseDate', type: 'date', dateFormat:'MS' }, 
        'status'
    ]
})
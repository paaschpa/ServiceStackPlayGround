Ext.define('RepairOrderForm', {
    extend: 'Ext.form.Panel',

    constructor: function (config) {
        var thisObj = this;
        var makes = Ext.Array.unique(config.makeModels.getRange().map(function (mm) { return mm.get('make'); }));
        config.makeModels.filter('make', ''); //default state of combo should be empty

        Ext.applyIf(this, {
            items: [
                {
                    xtype: 'combo',
                    itemId: 'advisorId',
                    name: 'advisorId',
                    fieldLabel: 'Advisor',
                    displayField: 'name',
                    valueField: 'id',
                    store: new DataRetriever().GetStore('/api/ServiceAdvisors?format=json', 'ServiceAdvisor', 'serviceAdvisors', false),
                },
                {
                    xtype: 'textfield',
                    itemId: 'customerName',
                    name: 'customerName',
                    fieldLabel: 'Customer'
                },
                {
                    xtype: 'combo',
                    itemId: 'year',
                    name: 'year',
                    fieldLabel: 'Year',
                    store: [
                        '1970', '1971', '1972', '1973', '1974', '1975', '1976', '1977', '1978', '1979',
                        '1980', '1981', '1982', '1983', '1984', '1985', '1986', '1987', '1988', '1989',
                        '1990', '1991', '1992', '1993', '1994', '1995', '1996', '1997', '1998', '1999',
                        '2000', '2001', '2002', '2003', '2004', '2005', '2006', '2007', '2008', '2009',
                        '2010', '2011', '2012', '2013', '2014', '2015'
                    ]
                },
                {
                    xtype: 'combo',
                    itemId: 'make',
                    name: 'make',
                    fieldLabel: 'Make',
                    store: makes,
                    listeners: {
                        'select': function (cmb, record, opts) {
                            config.makeModels.clearFilter(true);
                            config.makeModels.filter('make', record[0].get('field1'));
                        }
                    }
                },
                {
                    xtype: 'combo',
                    itemId: 'model',
                    name: 'model',
                    fieldLabel: 'Model',
                    displayField: 'model',
                    valueField: 'model',
                    store: config.makeModels
                }
            ],
            url: '/api/RepairOrder',
            buttons: [
                {
                    text: 'Submit',
                    handler: function () {
                        Ext.Ajax.request({
                            url: '/api/RepairOrder',
                            jsonData: this.up('form').getValues(),
                            success: function (resp, opts) {
                                thisObj.up('window').close();
                                config.pageBus.fireEvent('refreshGrid');
                            },
                            failure: function (resp, opts) {
                                alert('fail');
                            }
                        });
                    }
                }
            ]
        });

        this.callParent(arguments);
    }
})
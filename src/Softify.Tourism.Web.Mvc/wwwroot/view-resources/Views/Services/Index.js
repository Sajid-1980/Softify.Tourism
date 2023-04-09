(function ($) {
    var _serService = abp.services.app.service,
        _attrService = abp.services.app.attribute,
        l = abp.localization.getSource('Tourism'),
        _$modal = $('#ServiceCreateModal'),
        _$form = _$modal.find('form'),
        _$table = $('#ServicesTable'),
        _$tableAttr = $('#AttributeTableCreate');
     
    var _$attrTable = _$tableAttr.DataTable(
        {
            paging: true,
            serverSide: true,
             listAction: {
                ajaxFunction: _attrService.getAll,
                inputFilter: function () {
                    return $('#AttrSearchForm').serializeFormToObject(true);
                 },
             },
 
            buttons: [
                {
                    name: 'refresh',
                    text: '<i class="fas fa-redo-alt"></i>',
                    action: () => _$attrTable.draw(false)
                }
            ],
            responsive: {
                details: {
                    type: 'column'
                }
            },
            columnDefs: [
                {
                    targets: 0,
                    className: 'control',
                    defaultContent: '',
                },
                {
                    targets: 1,
                    data: 'attributeName',
                    sortable: false
                },
                {
                    targets: 2,
                    render: (data, type, row, meta) => {
                        return [
                            ` <input type = "hidden" name="Attributes[${row.index}].Id" value="${row.id}">  <input type="text" class="form-control" name="Attributes[${row.index}].Value">`,
                            '   </input>',
                        ].join('');
                    },
                    sortable: false
                },
                {
                    targets: 3,
                    data: null,
                    sortable: false,
                    autoWidth: false,
                    defaultContent: '',
                    render: (data, type, row, meta) => {
                        return [
                            `   <button type="button" class="btn btn-sm bg-danger delete-attr" data-attr-id="${row.id}" data-attr-name="${row.attributeName}">`,
                            `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                            '   </button>',
                        ].join('');
                    }
                }
            ]
        }
    );

    

    $(document).on('click', '.delete-attr', function () {
        var attrId = $(this).attr("data-attr-id");
        var attrName = $(this).attr('data-attr-name');

        deleteAttr(attrId, attrName);
    });


    var _$serviceTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        listAction: {
            ajaxFunction: _serService.getAll,
            inputFilter: function () {
                return $('#ServicesSearchForm').serializeFormToObject(true);
            }
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$serviceTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                className: 'control',
                defaultContent: '',
            },
            {
                targets: 1,
                data: 'name',
                sortable: false
            },
            {
                targets: 2,
                data: 'serviceType',
                sortable: false
            },
            {
                targets: 3,
                data: 'internet',
                sortable: false
            },
            {
                targets: 4,
                data: 'address',
                sortable: false
            },
            {
                targets: 5,
                data: 'email',
                sortable: false
            },
            {
                targets: 6,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-sm bg-secondary edit-role" data-role-id="${row.id}" data-toggle="modal" data-target="#ServiceEditModal">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('Edit')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-sm bg-danger delete-role" data-role-id="${row.id}" data-role-name="${row.name}">`,
                        `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                        '   </button>',
                    ].join('');
                }
            }
        ]
    });



     


    _$form.find('.save-button').on('click', (e) => {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }

        var services = _$form.serializeFormToObject();
 

        abp.ui.setBusy(_$modal);
        _serService
            .create(services)
            .done(function () {
                _$modal.modal('hide');
                _$form[0].reset();
                abp.notify.info(l('SavedSuccessfully'));
                _$serviceTable.ajax.reload();
            })
            .always(function () {
                abp.ui.clearBusy(_$modal);
            });
    });


     


    $(document).on('click', '.delete-role', function () {
        var roleId = $(this).attr("data-role-id");
        var roleName = $(this).attr('data-role-name');

        deleteRole(roleId, roleName);
    });

    $(document).on('click', '.edit-role', function (e) {
        var roleId = $(this).attr("data-role-id");

        e.preventDefault();
        abp.ajax({
            url: abp.appPath + 'Services/EditModal?serviceId=' + roleId,
            type: 'POST',
            dataType: 'html',
            success: function (content) {
                $('#ServiceEditModal div.modal-content').html(content);
            },
            error: function (e) {
            }
        })
    });

    abp.event.on('role.edited', (data) => {
        _$serviceTable.ajax.reload();
    });

 
    function deleteAttr(attrId, attrName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                attrName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _attrService.delete({
                        id: attrId
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        _$attrTable.ajax.reload();
                    });
                }
            }
        );
    }

    function deleteRole(roleId, roleName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                roleName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _serService.delete({
                        id: roleId
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        _$serviceTable.ajax.reload();
                    });
                }
            }
        );
    }

    _$modal.on('shown.bs.modal', () => {
        _$modal.find('input:not([type=hidden]):first').focus();
    }).on('hidden.bs.modal', () => {
        _$form.clearForm();
    });

    $('.btn-search').on('click', (e) => {
        _$serviceTable.ajax.reload();
             
    });

    $('.txt-search').on('keypress', (e) => {
        if (e.which == 13) {
            _$serviceTable.ajax.reload();
                
            return false;
        }
    });
})(jQuery);

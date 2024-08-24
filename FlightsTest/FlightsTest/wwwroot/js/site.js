$(document).ready(function () {
    // Add item
    $('#addItemForm').submit(function (event) {
        event.preventDefault();
        var itemName = $('#itemName').val();
        $.ajax({
            url: '/api/ItemsApi/PostItems',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({ Name: itemName }),
            success: function (data) {
                $('#itemList').append('<tr><td>' + data.id + '</td><td>' + data.name + '</td></tr>');
                $('#itemName').val(''); // Clear input field
            },
            error: function (xhr, status, error) {
                alert('Error: ' + error);
            }
        });
    });

    
});

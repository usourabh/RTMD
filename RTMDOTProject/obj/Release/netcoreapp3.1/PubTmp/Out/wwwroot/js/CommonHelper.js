function ShowLoading(control) {
    //e.preventDefault();
    var $target = control,
        block = $target.closest('.card');

    // Block card
    $(block).block({
        message: '<i class="icon-spinner2 spinner"></i>',
        overlayCSS: {
            backgroundColor: '#fff',
            opacity: 0.8,
            cursor: 'wait',
            'box-shadow': '0 0 0 1px #ddd'
        },
        css: {
            border: 0,
            padding: 0,
            backgroundColor: 'none'
        }
    });

    
    
}

function ShowCustomMessage(typemsg, msg, url) {
    
    if (typemsg == '1') {
        swal({
            title: 'Success!',
            text: msg,
            icon: 'success',
            type: 'success'

        }).then(function () {
            window.location = url;
        });
            
    } else if (typemsg == '2') {
        swal({
            title: 'Success',
            text: msg,
            icon: 'success',
            type: 'success'

        });

    }
    else {
        swal({
            title: 'Oops...',
            text: msg,
            icon: 'error',
            type: 'error'
        });
    }
}

function HideLoading(control) {
    // For demo purposes
    var $target = control,
    block = $target.closest('.card');
    $(block).unblock();
    
}

function getUrlParameterInfo(name) {
    name = name.replace(/[\[]/, '\\[').replace(/[\]]/, '\\]');
    var regex = new RegExp('[\\?&]' + name + '=([^&#]*)');
    var results = regex.exec(location.search);
    return results === null ? '' : decodeURIComponent(results[1].replace(/\+/g, ' '));
};

function getBase64Image(img) {
    var canvas = document.createElement("canvas");
    canvas.width = img.width;
    canvas.height = img.height;
    var ctx = canvas.getContext("2d");
    ctx.drawImage(img, 0, 0);
    var dataURL = canvas.toDataURL("image/png");
    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");
}
function ipad2(n) {
    return (n < 10 ? '0' : '') + n;
}
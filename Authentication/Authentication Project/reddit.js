
const r_username = document.querySelector('#loginUsername');
const r_password = document.querySelector('#loginPassword');
const submit_button = document.querySelector('#submitbutton');

eventListeners();

function eventListeners(){
    submit_button.addEventListener('click',checkAuthentication);
}

function checkAuthentication(e)
{
    $.ajax({
        type: 'POST',
        url: 'http://localhost:8080/',
        data: "{\"username\": \"" + r_username.value + "\", \"password\": \"" + r_password.value +"\"}",
        success: function (data) {
            var ret = jQuery.parseJSON(data);
            $('#lblResponse').html(ret.msg);
            console.log(ret.msg);
        },
        error: function (xhr, status, error) {
            console.log('Error: ' + error.message);
            $('#lblResponse').html('Error connecting to the server.');
        }
        });
}


 

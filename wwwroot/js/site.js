// Javascript Code
    $('#skills').waypoint(function (direction) {
    if (direction === 'down') {
        $('.progress-bar').width(function () {
            // this here refers to individual .progress-bar items
            return $(this).data('score');
        });
    } else {
        $('.progress-bar').width(0);
    }
}, { offset: '65%' });

//sweet alert 
function sweetsubmit() {

    swal({
        title: "Message Sent!",
        text: "We will be in touch soon!",
        icon: "success",
        timer: 3000,
        buttons: false,
    });
    //Add any extra functions here    
}

//form submit function which loads sweet alert if successful

function save(event) {
    //Validate the form before sending the request to the Controller
    if (!$("#formsubmit").valid()) {
        return false;
    }
    else {
        sweetsubmit();
        return true;
    }
}
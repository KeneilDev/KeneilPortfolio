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
}, { offset: '40%' });
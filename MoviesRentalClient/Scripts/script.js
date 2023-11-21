function showSpinner() {
    $("div.spanner").addClass("show");
    $("div.overlay").addClass("show");
}

function hideSpinner() {
    $("div.spanner").removeClass("show");
    $("div.overlay").removeClass("show");
}

function deleteMovie(movieId) {
    showSpinner();
    debugger
    $.ajax({
        url: "/Movie/DeleteMovie",
        type: "POST",
        data: { movieId: movieId },
        success: function (data) {
            movieDeleteResponse(data);
        },
        error: function (result) {
            console.log(result)
        }
    })
}

function rentMovie(movieId) {
    showSpinner();
    debugger
    $.ajax({
        url: "/Movie/RentMovie",
        type: "POST",
        data: { movieId: movieId },
        success: function (data) {
            movieRentResponse(data);
        },
        error: function (result) {
            console.log(result)
            toastr.error('Some error occured.')
        }
    })
}

function movieDeleteResponse(result) {
    hideSpinner();
    if (result)
        toastr.success('Movie deleted successfully.');
    else
        toastr.error('Some error occured.')

    setTimeout(function () {
        window.location.href = "/Movie/Home";
    }, 3000)
}

function movieRentResponse(result) {
    hideSpinner();
    if (result)
        toastr.success('Movie rented successfully.');
    else
        toastr.error('Some error occured.')

    setTimeout(function () {
        location.reload();
    }, 3000)
}




$(document).ready(function () {
	// Country dropdown change event

	// Country dropdown change event
	$('#CountryId').on('change', function () {
		var countryId = $(this).val();
		$.ajax({
			url: '/Form/GetStates',
			type: 'GET',
			data: { id: countryId },
			success: function (data) {
				$('#StateId').empty();
				$('#StateId').append($('<option>').text('Please select a state'));
				$.each(data, function (index, state) {
					$('#StateId').append($('<option>').val(state.id).text(state.state));
				});
			},
			error: function (xhr, status, error) {
				console.log(error);
			}
		});
	});


	// State dropdown change event
	$('#StateId').change(function () {
		var stateId = $(this).val();
		$.ajax({
			url: '/Form/GetCities',
			type: 'GET',
			data: { id: stateId },
			success: function (res) {
				$('#CityId').empty();
				$('#CityId').append($('<option>').text('Please select a city'));
				$.each(res, function (idx, val) {
					$('#CityId').append($('<option>').val(val.id).text(val.name));
				});
			},
			error: function (xhr, status, error) {
				console.log(error);
			}
		});
	});

	// Submit form event
	$("#createForm").on('submit', function (e) {
		e.preventDefault();
		let formdata = new FormData(this);
		$.ajax({
			url: '/Form/PostForm',
			type: 'POST',
			contentType: false,
			processData: false,
			data: formdata,
			success: function (Res) {
				console.log(Res)
				$("#userModel").modal('hide');
			},
			error: function (res) {
				console.log(res);
			}
		});
	});
});

function AddModel() {
	$.ajax({
		url: '/Form/CreateModel',
		type: 'GET',
		success: function (res) {
			$("#model-continer").html(res)
			$("#userModel").modal('show');
		},
		error: function (res) {
			console.log(res);
		}
	})
}


$("#createForm").on('submit', function (e) {
	e.preventDefault();
	let formdata = new FormData(this);
	$.ajax({
		url: '/Form/PostForm',
		type: 'POST',
		contentType: false,
		processData: false,
		data: formdata,
		success: function (Res) {
			console.log(Res)
			$("#userModel").modal('hide');
		},
		error: function (res) {
			console.log(res);
		}
	})
});


function FileUploadModelCaller() {
	$. ajax({
		url: 'File/GetFillUploadForm',
		type: 'GET',
		success: function (res) {
			$("#modalFileupload").modal('show');
		}, error: function (error) {
			console.log(error);
		}
	})
}
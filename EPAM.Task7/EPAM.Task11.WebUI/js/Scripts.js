var addUserBtn = document.getElementById('addUser'),
    delUserBtn = document.getElementById('delUser'),
    showUsersBtn = document.getElementById('showUsers'),
    getUserbyIdBtn = document.getElementById('getUserById'),

    addAwardBtn = document.getElementById('addAward'),
    delAwardBtn = document.getElementById('delAward'),
    showAwardsBtn = document.getElementById('showAwards'),
    getAwardByIdBtn = document.getElementById('getAwardById'),
    addAwardToUserBtn = document.getElementById('addAwardToUser'),

    changeUserImgBtn = document.getElementById('changeUserImg'),
    changeAwardImgBtn = document.getElementById('changeAwardImg');

function redirect(url) {
	location = url;
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUser.cshtml');
}

delUserBtn.onclick = function () {
    redirect('/pages/DeleteUser.cshtml');
}

showUsersBtn.onclick = function () {
	redirect('/pages/ShowAllUsers.cshtml');
}

getUserbyIdBtn.onclick = function () {
	redirect('/pages/GetUserById.cshtml');
}

addAwardBtn.onclick = function () {
	redirect('/pages/AddAward.cshtml');
}

delAwardBtn.onclick = function () {
	redirect('/pages/DeleteAward.cshtml');
}

showAwardsBtn.onclick = function () {
	redirect('/pages/ShowAllAwards.cshtml');
}

getAwardByIdBtn.onclick = function () {
	redirect('/pages/GetAwardById.cshtml');
}

addAwardToUserBtn.onclick = function () {
	redirect('/pages/AddAwardToUser.cshtml');
}

changeUserImgBtn.onclick = function () {
	redirect('/pages/UserImgChange.cshtml');
}

changeAwardImgBtn.onclick = function () {
	redirect('/pages/AwardImgChange.cshtml');
}
//for rit image
const navImg = document.getElementById('navImg');
function handleImageClick() { setActiveItem(this.id); }
navImg.addEventListener('click', handleImageClick);

//for tabs
const listItems = document.querySelectorAll('.navbar-nav li');
listItems.forEach(item => {
    item.addEventListener('click', function() {
        this.style.backgroundColor = '#F76902';
        setActiveItem(this.id);
    });
});

function openPersonModal(name, tagline, imagePath, title, interestArea, office, website, phone, email, twitter, facebook) {
    $('#modalPersonName').text(name);
    $('#modalPersonTitle').text(title);
    $('#modalPersonTagLine').text(tagline);
    $('#modalPersonWebsite').html(`<a class="websiteLink" href="${website}" target="_blank">${website}</a>`);
    $('#modalPersonEmail').text("Email: " + email);
    $('#modalPersonImg').attr('src', imagePath);
    
    if (interestArea) { $('#modalPersonInterestArea').text(`Interests: ${interestArea}`).show();
    } else { $('#modalPersonInterestArea').hide(); }
    
    if (office) { $('#modalPersonOffice').text(`Office Number: ${office}`).show();
    } else { $('#modalPersonOffice').hide(); }
    
    if (phone) { $('#modalPersonPhone').text(`Phone Number: ${phone}`).show();
    } else { $('#modalPersonPhone').hide(); }

    if (twitter) { $('#modalPersonTwitter').text(`Twitter: ${twitter}`).show();
    } else { $('#modalPersonTwitter').hide(); }

    if (facebook) { $('#modalPersonFacebook').text(`Facebook: ${facebook}`).show();
    } else { $('#modalPersonFacebook').hide(); }

    $('#personModal').dialog({
        modal: true,
        width: 500,
        height: 275
    });
}

function setActiveItem(id) {
    localStorage.setItem('activeItem', id);
}

function checkForSavedTab() {
    const activeItem = localStorage.getItem('activeItem');
    if (activeItem != "navImg") {
        const activeElement = document.getElementById(activeItem);
        if (activeElement) {
            activeElement.style.backgroundColor = '#F76902';
        }
    }
    
}

window.onload = function() {
    checkForSavedTab();
};

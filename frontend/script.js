const authorName = document.querySelector("#authorName");
const organizationName = document.querySelector("#organizationName");
const organizationEmail = document.querySelector("#organizationEmail");
const technologyName = document.querySelector("#technologyName");
const productName = document.querySelector("#productName");
const searchInput = document.querySelector("#searchInput");
const dateTime = document.querySelector("#dateTime");


const tableContainer = document.querySelector("#table-container");
const saveButton = document.querySelector("#btn-save");
const url = '/api/Innovations';

let currentPage = 1;
let currentAction = '';


function displayInnovations(innovations) {
    let allInnovations = '';

    innovations.forEach(innovation => {
        let innovationElement =
            `
                                    <tr>
                                        <td>${innovation.authorName}</td>
                                        <td>${innovation.organizationName}</td>
                                        <td>${innovation.organizationEmail}</td>
                                        <td>${innovation.technologyName}</td>
                                        <td>${innovation.productName}</td>
                                        <td>${new Date(innovation.dateTime).getFullYear()}</td>
                                        <td>
                                            <button class="action-btn edit-btn" onclick="openPopup('edit', 
                                                {
                                                    id: '${innovation.id}', 
                                                    authorName: '${innovation.authorName}', 
                                                    organizationName: '${innovation.organizationName}',
                                                    organizationEmail: '${innovation.organizationEmail}',
                                                    technologyName: '${innovation.technologyName}', 
                                                    productName: '${innovation.productName}', 
                                                    dateTime: '${innovation.dateTime}'
                                                })">
                                                <p class="button-text" style="font-weight: bold;">Р</p>
                                            </button>
                                            <button class="action-btn delete-btn" onclick="deleteInnovation(${innovation.id})">
                                                <p class="button-text" style="font-weight: bold;">У</p>
                                            </button>
                                            <button class="action-btn download-btn" onclick="downloadPdf(${innovation.id})">
                                                <p class="button-text" style="font-weight: bold; color: #4caf50;">С</p>
                                            </button>
                                        </td>
                                    </tr>
                                `;

        allInnovations += innovationElement;
    });

    tableContainer.innerHTML = allInnovations;
}

function updatePagination(currentPage, totalPages, hasPrevious, hasNext) {
    const prevButton = document.querySelector("#prev-page");
    const nextButton = document.querySelector("#next-page");
    const pageInfo = document.querySelector('#page-info');

    pageInfo.textContent = `Страница ${currentPage} из ${totalPages}`;

    if (hasPrevious) {
        prevButton.disabled = false;
        prevButton.classList.remove('disabled');
    } else {
        prevButton.disabled = true;
        prevButton.classList.add('disabled');
    }

    if (hasNext) {
        nextButton.disabled = false;
        nextButton.classList.remove('disabled');
    } else {
        nextButton.disabled = true;
        nextButton.classList.add('disabled');
    }
}

function changePage(direction) {
    if (tableContainer.innerHTML == "") {
        return;
    }

    const newPage = currentPage + direction;
    currentPage = newPage;
    getInnovations(newPage);
}

function getInnovations(pageNumber) {
    fetch(url + `?PageNumber=${pageNumber}`)
        .then(data => data.json())
        .then(response => {
            displayInnovations(response.items)
            updatePagination(response.currentPage, response.totalPages, response.hasPrevious, response.hasNext);
        });
}

function deleteInnovation(id) {
    fetch(url + `/${id}`, {
        method: 'DELETE',
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(_ => {
            getInnovations(currentPage);
        });
}

function toggleTableVisibility() {
    getInnovations(currentPage);
}

function clearTable() {
    tableContainer.innerHTML = "";
    currentPage = 1;
}

function deleteInnovation(id) {
    fetch(url + `/${id}`, {
        method: 'DELETE',
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(_ => {
            getInnovations(currentPage);
        });
}

function addInnovation(authorName, organizationName, organizationEmail, technologyName, productName, dateTime) {
    const body = {
        authorName: authorName,
        organizationName: organizationName,
        organizationEmail: organizationEmail,
        technologyName: technologyName,
        productName: productName,
        dateTime: convertToUtc(dateTime)
    };

    fetch(url, {
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(_ => {
            // getInnovations(currentPage);
            cleanPopup()
        });
}

function updateInnovation(id, authorName, organizationName, organizationEmail, technologyName, productName, dateTime) {
    const body = {
        authorName: authorName,
        organizationName: organizationName,
        organizationEmail: organizationEmail,
        technologyName: technologyName,
        productName: productName,
        dateTime: convertToUtc(dateTime)
    };

    fetch(`${url}/${id}`, {
        method: 'PUT',
        body: JSON.stringify(body),
        headers: {
            'content-type': 'application/json'
        }
    })
        .then(_ => {
            getInnovations(currentPage);
            closePopup();
        });
}

saveButton.addEventListener('click', (event) => {
    event.preventDefault();
    if (currentAction === 'add') {
        addInnovation(authorName.value, organizationName.value, organizationEmail.value, technologyName.value, productName.value, dateTime.value);
    } else if (currentAction === 'edit') {
        updateInnovation(currentId, authorName.value, organizationName.value, organizationEmail.value, technologyName.value, productName.value, dateTime.value);
    }
});

function downloadPdf(innovationId) {
    fetch(`${url}/generatePdf/${innovationId}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/pdf'
        }
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Ошибка загрузки PDF');
            }
            return response.blob();
        })
        .then(blob => {
            const link = document.createElement('a');
            link.href = URL.createObjectURL(blob);
            link.download = `innovation-${innovationId}.pdf`;
            link.click();
        })
        .catch(error => {
            console.error(error);
            alert('Произошла ошибка при загрузке файла');
        });
}

searchInput.addEventListener("input", (event) => {
    const query = event.target.value.trim();
    if (query.length >= 2 || query.length === 0) {
        searchInnovations(query);
    }
});

function searchInnovations(query, pageNumber = 1) {
    if (!query) {
        getInnovations(pageNumber);
        return;
    }

    fetch(`${url}/search?SearchQuery=${query}&PageNumber=${pageNumber}`)
        .then((response) => {
            if (!response.ok) {
                throw new Error("Ошибка выполнения поиска");
            }

            return response.json();
        })
        .then((data) => {
            displayInnovations(data.items);
            updatePagination(data.currentPage, data.totalPages, data.hasPrevious, data.hasNext);
        })
        .catch(_ => {
            alert("Произошла ошибка при поиске записей");
        });
}

function openPopup(action, data = null) {
    currentAction = action;
    cleanPopup();

    if (action === 'add') {
        document.getElementById("popupTitle").textContent = "Добавить запись";
        document.getElementById("popupForm").style.display = "flex";
    } else {
        document.getElementById("popupTitle").textContent = "Редактировать запись";
        document.getElementById("popupForm").style.display = "flex";

        if (data) {
            currentId = data.id;
            authorName.value = data.authorName;
            organizationName.value = data.organizationName;
            organizationEmail.value = data.organizationEmail;
            technologyName.value = data.technologyName;
            productName.value = data.productName;
            dateTime.value = new Date(data.dateTime).toISOString().split('T')[0];
        };
    }
}

function convertToUtc(dateTime) {
    const date = new Date(dateTime);
    const utcDateTime = new Date(date.getTime() - date.getTimezoneOffset() * 60000).toISOString();

    return utcDateTime;
}

function closePopup() {
    document.getElementById("popupForm").style.display = "none";
    document.getElementById("popupDelete").style.display = "none";

    cleanPopup();
}

function cleanPopup() {
    const formElements = document.querySelectorAll('#popupForm input, #popupForm select');
    formElements.forEach(element => {
        element.value = '';
    });
}
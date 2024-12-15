const authorName = document.querySelector("#authorName");
const organizationName = document.querySelector("#organizationName");
const organizationEmail = document.querySelector("#organizationEmail");
const technologyName = document.querySelector("#technologyName");
const productName = document.querySelector("#productName");
const searchInput = document.querySelector("#searchInput");
const dateTime = document.querySelector("#dateTime");

const tableContainer = document.querySelector("#table-container");
const addButton = document.querySelector("#addBtn");
const editButton = document.querySelector("#editBtn");
const downloadButton = document.querySelector("#downloadBtn");
const deleteButton = document.querySelector("#deleteBtn");
const saveButton = document.querySelector("#btn-save");
const url = '/api/Innovations';

let currentPage = 1;
let currentAction = '';
let selectedRow = null;
let selectedData = null;
let currentId = null;
let errorPopupContainer;

const displayInnovations = (innovations) => {
    const fragment = document.createDocumentFragment();

    innovations.forEach(innovation => {
        const row = document.createElement('tr');
        row.addEventListener('click', () => selectRow(row, innovation));

        const fields = [
            innovation.authorName,
            innovation.organizationName,
            innovation.organizationEmail,
            innovation.technologyName,
            innovation.productName,
            new Date(innovation.dateTime).getFullYear()
        ];

        fields.forEach(field => {
            const cell = document.createElement('td');
            cell.textContent = field;
            row.appendChild(cell);
        });

        fragment.appendChild(row);
    });

    tableContainer.innerHTML = '';
    tableContainer.appendChild(fragment);
};

const selectRow = (row, data) => {
    if (selectedRow) {
        selectedRow.classList.remove('selected');
    }

    selectedRow = row;
    selectedData = data;
    selectedRow.classList.add('selected');

    toggleActionButtons(false);
};

const toggleActionButtons = (disabled) => {
    ['downloadBtn', 'editBtn', 'deleteBtn'].forEach(id => {
        const button = document.getElementById(id);
        button.disabled = disabled;
        button.classList.toggle('inactive', disabled);
    });
};

const getInnovations = async (pageNumber = 1) => {
    try {
        const response = await fetch(`${url}?PageNumber=${pageNumber}`);
        if (!response.ok) throw new Error('Ошибка загрузки данных');

        const data = await response.json();
        displayInnovations(data.items);
        updatePagination(data.currentPage, data.totalPages, data.hasPrevious, data.hasNext);
    } catch (error) {
        alert(error.message);
    }
};

const deleteInnovation = async (id) => {
    try {
        const response = await fetch(`${url}/${id}`, { method: 'DELETE' });
        if (!response.ok) throw new Error('Ошибка удаления записи');

        await getInnovations(currentPage);
    } catch (error) {
        alert(error.message);
    }
};

const addInnovation = async (data) => {
    try {
        const response = await fetch(url, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            const errorData = await response.json();
            if (errorData.errors) {
                Object.values(errorData.errors).forEach(errors => {
                    errors.forEach(error => {
                        showValidationError(error);
                    });
                });
            } else {
                throw new Error('Ошибка добавления записи');
            }
            return;
        }

        cleanPopup();
        await getInnovations(currentPage);
    } catch (error) {
        alert(error.message);
    }
};

const updateInnovation = async (id, data) => {
    try {
        const response = await fetch(`${url}/${id}`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            const errorData = await response.json();
            if (errorData.errors) {
                Object.values(errorData.errors).forEach(errors => {
                    errors.forEach(error => {
                        showValidationError(error);
                    });
                });
            } else {
                throw new Error('Ошибка обновления записи');
            }
            return;
        }

        closePopup();
        await getInnovations(currentPage);
    } catch (error) {
        alert(error.message);
    }
};

const searchInnovations = async (query, pageNumber = 1) => {
    try {
        const endpoint = query ? `${url}/search?SearchQuery=${query}&PageNumber=${pageNumber}` : `${url}?PageNumber=${pageNumber}`;
        const response = await fetch(endpoint);
        if (!response.ok) throw new Error('Ошибка поиска');

        const data = await response.json();

        if (data.items && data.items.length > 0) {
            displayInnovations(data.items);
            updatePagination(data.currentPage, data.totalPages, data.hasPrevious, data.hasNext);
        } else {
            tableContainer.innerHTML = '<tr><td colspan="6">Такой записи не нашлось</td></tr>';

            const pageInfo = document.querySelector('#page-info');
            if (pageInfo) pageInfo.textContent = '';
        }
    } catch (error) {
        alert(error.message);
    }
};

const updatePagination = (currentPage, totalPages, hasPrevious, hasNext) => {
    const pageInfo = document.querySelector('#page-info');
    const prevButton = document.querySelector('#prev-page');
    const nextButton = document.querySelector('#next-page');

    pageInfo.textContent = `Страница ${currentPage} из ${totalPages}`;

    prevButton.disabled = !hasPrevious;
    nextButton.disabled = !hasNext;
};

const downloadPdf = async (innovationId) => {
    try {
        const response = await fetch(`${url}/generatePdf/${innovationId}`, {
            method: 'GET',
            headers: { 'Accept': 'application/pdf' }
        });

        if (!response.ok) {
            throw new Error('Ошибка загрузки PDF');
        }

        const blob = await response.blob();
        const link = document.createElement('a');
        link.href = URL.createObjectURL(blob);
        link.download = `innovation-${innovationId}.pdf`;
        link.click();
    } catch (error) {
        console.error(error);
        alert('Произошла ошибка при загрузке файла');
    }
}

const changePage = (direction) => {
    const newPage = currentPage + direction;
    currentPage = newPage;
    getInnovations(newPage);
};


const convertToUtc = (dateTime) => {
    const date = new Date(dateTime);
    return new Date(date.getTime() - date.getTimezoneOffset() * 60000).toISOString();
};

const showValidationError = (message) => {
    if (!errorPopupContainer) {
        errorPopupContainer = document.createElement('div');
        errorPopupContainer.classList.add('validation-error-popup-container');
        document.body.appendChild(errorPopupContainer);
    }

    const errorPopup = document.createElement('div');
    errorPopup.classList.add('validation-error-popup');
    errorPopup.textContent = message;

    errorPopupContainer.appendChild(errorPopup);

    setTimeout(() => {
        errorPopup.remove();
    }, 5000);
};

const cleanPopup = () => {
    document.querySelectorAll('#popupForm input').forEach(input => input.value = '');
};

const closePopup = () => {
    document.getElementById("popupForm").style.display = "none";
    cleanPopup();
};

addButton.addEventListener('click', () => {
    currentAction = 'add';
    cleanPopup();

    document.getElementById("popupTitle").textContent = "Добавить запись";
    document.getElementById("popupForm").style.display = "flex";
});

editButton.addEventListener('click', () => {
    currentAction = 'edit';
    cleanPopup();

    document.getElementById("popupTitle").textContent = "Редактировать запись";
    document.getElementById("popupForm").style.display = "flex";

    currentId = selectedData.id;
    authorName.value = selectedData.authorName;
    organizationName.value = selectedData.organizationName;
    organizationEmail.value = selectedData.organizationEmail;
    technologyName.value = selectedData.technologyName;
    productName.value = selectedData.productName;
    dateTime.value = new Date(selectedData.dateTime).toISOString().split('T')[0];
});

downloadButton.addEventListener('click', async () => {
    await downloadPdf(selectedData.id);
});

deleteButton.addEventListener('click', async () => {
    await deleteInnovation(selectedData.id);
});

saveButton.addEventListener('click', async (event) => {
    event.preventDefault();

    const data = {
        authorName: authorName.value,
        organizationName: organizationName.value,
        organizationEmail: organizationEmail.value,
        technologyName: technologyName.value,
        productName: productName.value,
        dateTime: convertToUtc(dateTime.value)
    };

    if (currentAction === 'add') {
        await addInnovation(data);
    } else if (currentAction === 'edit') {
        await updateInnovation(currentId, data);
    }
});

searchInput.addEventListener('input', async (event) => {
    const query = event.target.value.trim();
    const queryParts = query.split(' ');

    if (queryParts.length >= 4 || query.length === 0) {
        searchInnovations(query);
    }
});

getInnovations(currentPage);

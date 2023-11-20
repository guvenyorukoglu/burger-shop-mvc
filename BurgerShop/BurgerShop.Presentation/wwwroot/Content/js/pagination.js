
window.onload = function () {
    var itemsPerPage = 6; 
    var currentPage = 1; 

    var container = document.querySelector('.container');
    var pagination = document.querySelector('.pagination');

     //Tüm menü öðeleri
    var menuItems = Array.from(document.querySelectorAll('.menu-box'));
    menuItems.forEach(function (item) {
        item.style.width = "420px";
    });


    function renderPage(page) {
        var start = (page - 1) * itemsPerPage;
        var end = start + itemsPerPage;

        container.innerHTML = ''; // Sayfa içeriðini temizle

        // Sayfa için gerekli menü öðelerini ekle
        for (var i = start; i < Math.min(end, menuItems.length); i++) {
            container.appendChild(menuItems[i]);
        }
    }

    function renderPagination() {
        var pageCount = Math.ceil(menuItems.length / itemsPerPage);
        var arrowleft = document.createElement('a');
        arrowleft.href = '#';
        arrowleft.innerText = '<';
        arrowleft.addEventListener('click', function (e) {
            e.preventDefault();
            currentPage--;
            if (currentPage < 1) {
                currentPage = 1;
                renderPage(currentPage);

            }
            renderPage(currentPage);
            renderPagination();
        });

        var arrowright = document.createElement('a');
        arrowright.href = '#';
        arrowright.innerText = '>';
        arrowright.addEventListener('click', function (e) {
            e.preventDefault();

            if (currentPage < pageCount) {
                currentPage++;
            }
            renderPage(currentPage);
            renderPagination();
        });

        pagination.innerHTML = '';
        pagination.appendChild(arrowleft);
        for (var i = 1; i <= pageCount; i++) {
            var link = document.createElement('a');
            link.href = '#';
            link.innerText = i;
            link.addEventListener('click', function (e) {
                e.preventDefault();
                currentPage = parseInt(this.innerText);
                renderPage(currentPage);
                renderPagination();
            });
            if (i === currentPage) {
                link.style.color = 'orange';
            }
            pagination.appendChild(link);
            pagination.appendChild(arrowright);

        }
    }

    renderPage(currentPage);
    renderPagination();
};

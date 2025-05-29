 window.addEventListener('DOMContentLoaded', () => {
  setTimeout(() => {
    window.scrollTo({ top: 0, left: 0, behavior: 'auto' });
  }, 50); // 50-100ms gecikme genellikle yeterlidir
 });

function scrollToOdeme() {
  const element = document.getElementById('odeme');
  const offset = -250; // Yukarıya 100px kadar fazladan kaydır

  const bodyRect = document.body.getBoundingClientRect().top;
  const elementRect = element.getBoundingClientRect().top;
  const elementPosition = elementRect - bodyRect;
  const offsetPosition = elementPosition + offset;

  window.scrollTo({
    top: offsetPosition,
    behavior: 'smooth'
  });
}


function updateGreeting() {
    // Türkiye (İstanbul) saatine göre zaman ayarı
    const now = new Date().toLocaleString("en-US", { timeZone: "Europe/Istanbul" });
    const date = new Date(now);
    const hour = date.getHours();

    const icon = document.getElementById("greetingIcon");
    const text = document.getElementById("greetingText");

    if (hour >= 6 && hour < 12) {
      icon.textContent = "🌞";
      text.textContent = "Günaydın!";
    } else if (hour >= 12 && hour < 18) {
      icon.textContent = "🌞";
      text.textContent = "İyi günler!";
    } else if (hour >= 18 && hour < 22) {
      icon.textContent = "🌙";
      text.textContent = "İyi akşamlar!";
    } else {
      icon.textContent = "🌙";
      text.textContent = "İyi geceler!";
    }
  }

  updateGreeting();



  const parallax = document.getElementById('parallax');
        
    window.addEventListener('scroll', () => {
      const offset = window.scrollY;
      parallax.style.backgroundPositionY = `${offset * 0.5}px`;
    });



    const extraItems = [
      { src: 'img/sarma.png', name: 'Zeytinyağlı Yaprak Sarma' },
      { src: 'img/mücver.png', name: 'Mücver' },
      { src: 'img/lazanya.png', name: 'Fırında Lazanya' },
      { src: 'img/antrikot.png', name: 'Dana Antrikot' },
      { src: 'img/kunefe.png', name: 'Künefe' },
      { src: 'img/cheesecake.png', name: 'Cheesecake' }
    ];
    
    const toggleText = document.getElementById('toggleMenuText');
    const menuContainer = document.getElementById('menuContainer');
    const extraMenu = document.getElementById('extraMenu');
    
    let isExpanded = false;
    
    toggleText.addEventListener('click', () => {
      if (!isExpanded) {
        extraMenu.innerHTML = ''; // temizle
        extraItems.forEach(item => {
          const div = document.createElement('div');
          div.className = 'menu-item';
          div.innerHTML = `
            <img src="${item.src}" alt="${item.name}">
            <p>${item.name}</p>
          `;
          extraMenu.appendChild(div);
        });
        
         // Açılışta küçük bir gecikmeyle sınıfı ekle
  setTimeout(() => {
    extraMenu.classList.add('expanded');
  }, 50); // bu süre geçişin görünmesini sağlar
        extraMenu.classList.add('expanded');
        toggleText.textContent = 'Menüyü Küçült';
        isExpanded = true;
      } else {
        extraMenu.classList.remove('expanded');
    
        // animasyon bitince içeriği kaldır
        setTimeout(() => {
          extraMenu.innerHTML = '';
        }, 600);
    
        toggleText.textContent = 'Tamamını Görüntüle';
        isExpanded = false;
      }
    });
    
    const sections = document.querySelectorAll('.hidden-section');

const observer = new IntersectionObserver(entries => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      entry.target.classList.add('show');
    }
  });
});

sections.forEach(section => {
  observer.observe(section);
});

function toggleAdetInput(checkbox) {
  const adetDiv = checkbox.parentElement.nextElementSibling;
  if (checkbox.checked) {
    adetDiv.style.display = 'block';
  } else {
    adetDiv.style.display = 'none';
  }
}

function toggleAdetInput(checkbox) {
  const adetDiv = checkbox.parentElement.nextElementSibling;
  const adetInput = adetDiv.querySelector('input[type="number"]');

  if (checkbox.checked) {
    adetDiv.style.display = 'block';
  } else {
    adetDiv.style.display = 'none';
    adetInput.value = 1;
  }

  updateSummary();
}

function updateSummary() {
  const list = document.getElementById("secilenListesi");
  const toplamSpan = document.getElementById("toplamTutar");

  list.innerHTML = "";
  let toplam = 0;

  document.querySelectorAll('input[type="checkbox"][name="baslangic[]"]:checked').forEach((checkbox) => {
    const item = checkbox.value;
    const fiyat = parseFloat(checkbox.getAttribute("data-fiyat"));
    const adetInput = checkbox.parentElement.nextElementSibling.querySelector('input[type="number"]');
    const adet = parseInt(adetInput.value);

    const satir = document.createElement("li");
    satir.textContent = `${item} x ${adet} = ${fiyat * adet}₺`;
    list.appendChild(satir);

    toplam += fiyat * adet;
  });

  toplamSpan.textContent = toplam.toFixed(2);
}

function updateSummary() {
  const list = document.getElementById("secilenListesi");
  const toplamSpan = document.getElementById("toplamTutar");

  const odemeList = document.getElementById("odemeSecilenListesi");
  const odemeToplamSpan = document.getElementById("odemeToplamTutar");

  list.innerHTML = "";
  if (odemeList) odemeList.innerHTML = "";

  let toplam = 0;

  document.querySelectorAll('input[type="checkbox"][name="baslangic[]"]:checked').forEach((checkbox) => {
    const item = checkbox.value;
    const fiyat = parseFloat(checkbox.getAttribute("data-fiyat"));
    const adetInput = checkbox.parentElement.nextElementSibling.querySelector('input[type="number"]');
    const adet = parseInt(adetInput.value);

    const text = `${item} x ${adet} = ${(fiyat * adet).toFixed(2)}₺`;

    const satir = document.createElement("li");
    satir.textContent = text;
    list.appendChild(satir);

    if (odemeList) {
      const odemeSatir = document.createElement("li");
      odemeSatir.textContent = text;
      odemeList.appendChild(odemeSatir);
    }

    toplam += fiyat * adet;
  });

  toplamSpan.textContent = toplam.toFixed(2);
  if (odemeToplamSpan) odemeToplamSpan.textContent = toplam.toFixed(2);
}




  const expiryInput = document.getElementById("expiry");

  expiryInput.addEventListener("input", function (e) {
    let value = expiryInput.value;

    // Sadece rakam ve / karakteri alınsın
    value = value.replace(/[^\d/]/g, '');

    // Otomatik / ekleme
    if (value.length === 2 && !value.includes('/')) {
      value = value + '/';
    }

    // Fazla karakter engelle (zaten maxlength="5" ama ekstra güvenlik)
    if (value.length > 5) {
      value = value.slice(0, 5);
    }

    expiryInput.value = value;
  });

  function allowOnlyDigits(input) {
    input.value = input.value.replace(/\D/g, ''); // \D: Sayı olmayanları sil
  }

  const cardNumberInput = document.getElementById("cardNumber");
  const cvvInput = document.getElementById("cvv");

  cardNumberInput.addEventListener("input", () => allowOnlyDigits(cardNumberInput));
  cvvInput.addEventListener("input", () => allowOnlyDigits(cvvInput));
  document.getElementById("cardNumber").addEventListener("input", function (e) {
    let value = e.target.value;
    
    // Sadece rakamları al
    value = value.replace(/\D/g, "");

    // Her 4 haneden sonra tire ekle
    value = value.match(/.{1,4}/g);
    if (value) {
      e.target.value = value.join("-");
    } else {
      e.target.value = "";
    }
  });


  document.getElementById("rezervasyonFormu").addEventListener("submit", function(e) {
    e.preventDefault();
  
    const formData = {
      ad_soyad: document.getElementById("adSoyad").value,
      telefon: document.getElementById("telefon").value,
      email: document.getElementById("email").value,
      tarih: document.getElementById("tarih").value,
      saat: document.getElementById("saat").value,
      kisi_sayisi: document.getElementById("kisiSayisi").value,
      notlar: document.getElementById("notlar").value,
      secilenler: selectedItems, // Menü seçimleri (bir array)
      toplam: toplamTutar // hesaplanmış toplam
    };
  
    fetch("/rezervasyon_kaydet.php", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(formData)
    })
    .then(res => res.text())
    .then(data => alert("Rezervasyon alındı: " + data))
    .catch(err => alert("Hata oluştu: " + err));
  });
  

  //text kelimelerin ilk harfini büyük yapmak:
  document.addEventListener("DOMContentLoaded", function () {
    const nameInput = document.getElementById("name");

    nameInput.addEventListener("blur", function () {
      const formatted = this.value
        .split(" ")
        .filter(word => word.trim().length > 0)
        .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
        .join(" ");
      this.value = formatted;
    });
  });
  //tel no için oto boşluk eklemek:
  function formatPhoneNumber(input) {
    let value = input.value.replace(/\D/g, ''); // Sadece rakamları al

    // Format: (555) 123 4567
    if (value.length > 3 && value.length <= 6) {
      value = `(${value.slice(0, 3)}) ${value.slice(3)}`;
    } else if (value.length > 6) {
      value = `(${value.slice(0, 3)}) ${value.slice(3, 6)} ${value.slice(6, 10)}`;
    } else if (value.length > 0) {
      value = `(${value.slice(0, 3)}) ${value.slice(3)}`;
    }

    input.value = value;
  }

  function rezervasyonuTamamla() {
    Swal.fire({
      text: 'Rezervasyonunuz başarıyla tamamlandı.',
      icon: 'success',
      confirmButtonText: 'Harika!',
      background: '#fffbe6',
      color: '#444',
      confirmButtonColor: '#664343'
    });
  }

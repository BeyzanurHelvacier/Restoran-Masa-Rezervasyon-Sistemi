CREATE DATABASE RestoranDB;
USE RestoranDB;

CREATE TABLE Masalar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Bolge VARCHAR(50),
    MasaNo INT,
    Durum VARCHAR(20) -- 'Boş', 'Dolu', 'Rezerve'
);

CREATE TABLE Rezervasyonlar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    MasaId INT,
    AdSoyad VARCHAR(100),
    Tarih DATETIME,
    Tutar DECIMAL(10,2),
    FOREIGN KEY (MasaId) REFERENCES Masalar(id)
);

CREATE TABLE MenuKategorileri (
    menu_id INT AUTO_INCREMENT PRIMARY KEY,
    Ad VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Urunler (
    urun_id INT AUTO_INCREMENT PRIMARY KEY,
    Kategori_id INT NOT NULL,
    Ad VARCHAR(100) NOT NULL,
    Fiyat DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Kategori_id) REFERENCES MenuKategorileri(menu_id) ON DELETE CASCADE
);

CREATE TABLE Siparisler (
    id INT AUTO_INCREMENT PRIMARY KEY,
    RezervasyonId INT NOT NULL,
    urun_id INT NOT NULL,
    Adet INT NOT NULL,
    Tutar DECIMAL(10,2) NOT NULL,
    SiparisTarihi DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RezervasyonId) REFERENCES Rezervasyonlar(id) ON DELETE CASCADE,
    FOREIGN KEY (urun_id) REFERENCES Urunler(urun_id) ON DELETE CASCADE
);




INSERT INTO Masalar (Bolge, MasaNo, Durum) VALUES
 ('Teras', 1, 'Rezerve'),
 ('Teras', 2, 'Boş'),
('Teras', 3, 'Dolu'),
('Teras', 4, 'Dolu'),
('Teras', 5, 'Rezerve'),
('Teras', 6, 'Boş'),
('Teras', 7, 'Boş'),
('Teras', 8, 'Dolu'),
('Teras', 9, 'Boş'),
('Teras', 10, 'Dolu'),
('Giriş', 1, 'Boş'),
('Giriş', 2, 'Boş'),
('Giriş', 3, 'Boş'),
('Giriş', 4, 'Dolu'),
('Giriş', 5, 'Dolu'),
('Giriş', 6, 'Rezerve'),
('Giriş', 7, 'Boş'),
('Giriş', 8, 'Dolu'),
('Giriş', 9, 'Boş'),
('Giriş', 10, 'Rezerve'),
('Kat1', 1, 'Boş'),
('Kat1', 2, 'Boş'),
('Kat1', 3, 'Dolu'),
('Kat1', 4, 'Rezerve'),
('Kat1', 5, 'Dolu'),
('Kat1', 6, 'Dolu'),
('Kat1', 7, 'Dolu'),
('Kat1', 8, 'Boş'),
('Kat2', 1, 'Dolu'),
('Kat2', 2, 'Dolu'),
('Kat2', 3, 'Rezerve'),
('Kat2', 4, 'Boş'),
('Kat2', 5, 'Dolu'),
('Kat2', 6, 'Boş'),
('Kat2', 7, 'Boş'),
('Kat2', 8, 'Rezerve');


INSERT INTO Rezervasyonlar (MasaId, AdSoyad, Tarih, Tutar) VALUES 
(2, 'Ali Yılmaz', '2025-05-01 19:00:00', 450.00);



INSERT INTO MenuKategorileri(Ad)VALUES
("Başlangıç"),
("Mezeler"),
("Ana Yemek"),
("Tatlı"),
("İçecekler");

INSERT INTO Urunler(Ad, Kategori_id, Fiyat) VALUES
("Mercimek Çorbası", 1, 60.00),
("Domates Çorbası", 1, 60.00),
("Ezogelin Çorbası", 1, 60.00),
("Yayla Çorbası", 1, 60.00),
("Sigara Böreği", 1, 75.00),
("Mücver", 1, 78.00),
("Kalamar Tava", 1, 150.00),
("Humus", 2, 70.00),
("Acılı Ezme", 2, 65.00),
("Zeytinyağlı Yaprak Sarma", 2, 95.00),
("Havuç Tarator", 2, 70.00),
("Közlenmiş Patlıcan Salatası", 2, 80.00),
("Haydari", 2, 70.00),
("Zeytinyağlı Enginar", 2, 100.00),
("Izgara Tavuk", 3, 120.00),
("Köfte Tabağı", 3, 175.00),
("Adana Kebap", 3, 250.00),
("Dana Antrikot", 3, 285.00),
("Fırında Soman", 3, 300.00),
("Mantı", 3, 120.00),
("Tavuk Şinitzel", 3, 95.00),
("Etli Güveç", 3, 255.00),
("Patlıcan Musakka", 3, 145.00),
("Kaşarlı Köfte", 3, 195.00),
("Baklava", 4, 165.00),
("Sütlaç", 4, 80.00),
("Kazandibi", 4, 95.00),
("Tiramisu", 4, 85.00),
("Profiterol", 4, 100.00),
("Cheesecake (Çilekli)", 4, 125.00),
("Künefe", 4, 185.00),
("Mozaik Pasta", 4, 80.00),
("Fırın Sütlaç", 4, 85.00),
("Dondurma", 4, 55.00),
("Çay", 5, 35.00),
("Türk Kahvesi", 5, 55.00),
("Su", 5, 10.00),
("Limonata", 5, 45.00),
("Ayran", 5, 25.00),
("Sade Soda", 5, 50.00),
("Buzlu Limonlu Soda", 5, 55.00);


SELECT * FROM Masalar;
SELECT DATABASE();

-- Sadece NULL değerli kayıtları bul:
SELECT * FROM Masalar WHERE Bolge IS NULL AND MasaNo IS NULL AND Durum IS NULL;


SELECT r.id, r.AdSoyad, r.Tarih, r.Tutar, m.Bolge, m.MasaNo 
FROM Rezervasyonlar r
JOIN Masalar m ON r.MasaId = m.id;



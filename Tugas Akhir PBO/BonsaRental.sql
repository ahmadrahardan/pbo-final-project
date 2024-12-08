CREATE TABLE Katalog (
    id_katalog SERIAL PRIMARY KEY,
    nama_produk VARCHAR(100) NOT NULL,
    harga INT NOT NULL,
    stok INT NOT NULL DEFAULT 0,
    id_kategori INT NOT NULL,
    gambar BYTEA,
    CONSTRAINT fk_kategori FOREIGN KEY (id_kategori) REFERENCES Kategori (id_kategori)
);

CREATE TABLE Kategori (
    id_kategori SERIAL PRIMARY KEY,
    nama_kategori VARCHAR(50) NOT NULL
);

CREATE TABLE Admin (
    id_admin SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL
);

CREATE TABLE Transaksi (
    id_transaksi SERIAL PRIMARY KEY, 
    nama VARCHAR(100) NOT NULL,      
    nik VARCHAR(20) NOT NULL,        
    total_harga NUMERIC(15, 2) NOT NULL, 
    tanggal_kembali DATE NOT NULL,   
    tanggal_transaksi TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
    status VARCHAR(50) NOT NULL
);

CREATE TABLE DetailTransaksi (
    id_detail SERIAL PRIMARY KEY,  
    id_transaksi INT NOT NULL,     
    id_katalog INT NOT NULL,       
    jumlah INT NOT NULL,           
    FOREIGN KEY (id_transaksi) REFERENCES Transaksi(id_transaksi) ON DELETE CASCADE,
    FOREIGN KEY (id_katalog) REFERENCES Katalog(id_katalog) ON DELETE CASCADE
);

CREATE TABLE Katalog_Mitra (
    id_katalog SERIAL PRIMARY KEY,
    nama_produk VARCHAR(100) NOT NULL,
    harga INT NOT NULL,
    stok INT NOT NULL DEFAULT 0,
    id_kategori INT NOT NULL,
    gambar BYTEA,
    CONSTRAINT fk_kategori FOREIGN KEY (id_kategori) REFERENCES Kategori (id_kategori)
);

CREATE TABLE Mitra (
    id_mitra SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL
);

INSERT INTO Kategori (id_kategori, nama_kategori) VALUES 
(1, 'DSLR'),
(2, 'Mirrorless'),
(3, 'Compact');

select *
from Katalog

select *
from Katalog_Mitra

select *
from Kategori

select *
from Admin

select *
from Mitra

select *
from Transaksi

select *
from DetailTransaksi

DELETE FROM Transaksi
WHERE id_transaksi = 10;
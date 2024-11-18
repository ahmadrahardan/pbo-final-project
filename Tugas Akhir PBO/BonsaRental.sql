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

INSERT INTO Kategori (id_kategori, nama_kategori) VALUES 
(1, 'DSLR'),
(2, 'Mirrorless'),
(3, 'Compact');

INSERT INTO Admin (id_admin, username, email, password) VALUES 
(1, 'Rahardan', 'rahardan@gmail.com', '123');

select *
from Katalog

select *
from Kategori

select *
from Admin

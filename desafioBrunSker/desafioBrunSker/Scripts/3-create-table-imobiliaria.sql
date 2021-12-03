CREATE TABLE tb_imobiliaria(
	id INT AUTO_INCREMENT,
    cep VARCHAR(9) NOT NULL,
    logradouro VARCHAR(50) NOT NULL,
    bairro VARCHAR(30) NOT NULL,
    cidade VARCHAR(40) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    proprietario VARCHAR(40) NOT NULL,
    PRIMARY KEY(id)
);

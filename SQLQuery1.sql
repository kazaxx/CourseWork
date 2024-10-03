CREATE DATABASE Stroy1

USE Stroy1


CREATE TABLE ��������� (
    ���������ID INT PRIMARY KEY IDENTITY,
    �������� NVARCHAR(100) NOT NULL,
    ����� DECIMAL(18, 2) NOT NULL,
    �������� NVARCHAR(MAX),
    ������������� INT,
    ����������� NVARCHAR(MAX)
);


CREATE TABLE ��������������� (
    ����ID INT PRIMARY KEY IDENTITY,
    �������� NVARCHAR(50) NOT NULL,
    ���������ID INT NOT NULL,
    FOREIGN KEY (���������ID) REFERENCES ���������(���������ID)
);


CREATE TABLE ���������� (
    ���������ID INT PRIMARY KEY IDENTITY,
    ��� NVARCHAR(100) NOT NULL,
	������� NVARCHAR(100) NOT NULL,
	�������� NVARCHAR(100) NOT NULL,
    ������� NVARCHAR(20),
    Email NVARCHAR(100) UNIQUE,
    ���������ID INT NOT NULL,
    FOREIGN KEY (���������ID) REFERENCES ���������(���������ID)
);


CREATE TABLE ������� (
    ������ID INT PRIMARY KEY IDENTITY,
    ��� NVARCHAR(100) NOT NULL,
	������� NVARCHAR(100) NOT NULL,
	�������� NVARCHAR(100) NOT NULL,
    ������� NVARCHAR(20),
    Email NVARCHAR(100) UNIQUE, 
    ����� NVARCHAR(255)
);


CREATE TABLE ������������ (
    ������������ID INT PRIMARY KEY IDENTITY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    ������ NVARCHAR(255) NOT NULL,
    ������ID INT NULL,
    ���������ID INT NULL,
    CHECK ((������ID IS NOT NULL AND ���������ID IS NULL) OR (������ID IS NULL AND ���������ID IS NOT NULL)),
    FOREIGN KEY (������ID) REFERENCES �������(������ID),
    FOREIGN KEY (���������ID) REFERENCES ����������(���������ID)
);


CREATE TABLE ������� (
    ������ID INT PRIMARY KEY IDENTITY,
    ������ID INT NOT NULL,
    �������� NVARCHAR(255) NOT NULL,
    �������� NVARCHAR(MAX),
    ���������� DATE NOT NULL,
    ������������� DATE,
    ������ NVARCHAR(50),
    FOREIGN KEY (������ID) REFERENCES �������(������ID)
);


CREATE TABLE ������ (
    ������ID INT PRIMARY KEY IDENTITY,
    �������� NVARCHAR(255) NOT NULL,
    �������� NVARCHAR(MAX)
);


CREATE TABLE ��������������� (
    ������������ID INT PRIMARY KEY IDENTITY,
    ������ID INT NOT NULL,
    ������ID INT NOT NULL,
    ��������� DECIMAL(18, 2),
    ���������� INT,
    FOREIGN KEY (������ID) REFERENCES �������(������ID),
    FOREIGN KEY (������ID) REFERENCES ������(������ID)
);


CREATE TABLE ��������������������� (
    ����������ID INT PRIMARY KEY IDENTITY,
    ������ID INT NOT NULL,
    ���������ID INT NOT NULL,
    ����ID INT NOT NULL,
    �������������� DATE NOT NULL,
    FOREIGN KEY (������ID) REFERENCES �������(������ID),
    FOREIGN KEY (���������ID) REFERENCES ����������(���������ID),
    FOREIGN KEY (����ID) REFERENCES ���������������(����ID)
);

ALTER AUTHORIZATION ON DATABASE :: Stroy1 to sa;

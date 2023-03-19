CREATE DATABASE SchoolDB
GO
USE SchoolDB
GO

CREATE TABLE MsGender
(
	id INT IDENTITY PRIMARY KEY,
	[description] VARCHAR(255)
)

CREATE TABLE MsReligion
(
	id INT IDENTITY PRIMARY KEY,
	[description] VARCHAR(255)
)

CREATE TABLE MsStudent
(
	id INT IDENTITY PRIMARY KEY,
	[name] VARCHAR(255),
	birthDate DATETIME,
	genderId INT,
	religionId INT,
	email VARCHAR(255),
	[address] VARCHAR(255),
	FOREIGN KEY(genderId) REFERENCES MsGender(id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(religionId) REFERENCES MsReligion(id) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE MsSubject
(
	id INT IDENTITY PRIMARY KEY,
	[name] VARCHAR(255)
)

CREATE TABLE MsGrade
(
	id INT IDENTITY PRIMARY KEY,
	[name] VARCHAR(255),
	minScore DECIMAL(10, 2),
	maxScore DECIMAL(10, 2)
)

CREATE TABLE TrScore(
	id INT IDENTITY PRIMARY KEY,
	studentId INT,
	subjectId INT,
	semester INT,
	score DECIMAL(10, 2),
	grade CHAR(2)
	FOREIGN KEY(studentId) REFERENCES MsStudent(id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(subjectId) REFERENCES MsSubject(id) ON UPDATE CASCADE ON DELETE CASCADE,
)

INSERT INTO MsGender ([description]) VALUES
('Pria'),
('Wanita')

INSERT INTO MsReligion ([description]) VALUES
('Kristen'), 
('Islam'), 
('Katholik'), 
('Buddha'), 
('Hindu'),
('Konghucu')

INSERT INTO MsStudent([name], birthDate, genderId, religionId, email, [address]) VALUES
('Fransiska Hilda', '1999-07-29', 2, 1, 'hilda@binus.ac.id', 'jl. example blok A nomor 6'),
('Edgar', '2000-08-14', 1, 5, 'edgar@binus.ac.id', 'jl. contoh blok JJ nomor 3a'),
('Sharen Ezfiyana', '2001-06-25', 2, 2, 'sharen@binus.ac.id', 'jl. kaki blok D nomor 12a'),
('Steven Ciputra', '2002-01-06', 1, 3, 'steven@binus.ac.id', 'jl. jalan blok C nomor 1'),
('William Susanto', '2001-03-09', 1, 4, 'william@binus.ac.id', 'jl. binus blok GG nomor 66'),
('Natanael Geraldo', '1998-02-04', 1, 5, 'natanael@binus.ac.id', 'jl. semangka blok OO nomor 88')

INSERT INTO MsSubject ([name]) VALUES
('Bahasa Indonesia'),
('Matematika'),
('Inggris'),
('IPA')

INSERT INTO MsGrade ([name], minScore, maxScore) VALUES
('A', 80, 100),
('B', 60, 79.99),
('C', 40, 59.99),
('D', 20, 39.99),
('E', 0, 19.99)

INSERT INTO TrScore (studentId, subjectId, semester, score, grade) VALUES
(1, 1, 1, 100.00, 'A'),
(1, 2, 1, 80.00, 'A'),
(1, 3, 1, 65.88, 'B'),
(1, 4, 1, 75.50, 'B'),
(1, 1, 2, 80.90, 'A'),
(1, 2, 2, 77.50, 'B'),
(1, 3, 2, 72.00, 'B'),
(1, 4, 2, 66.66, 'B'),
(2, 1, 1, 72.75, 'B'),
(2, 2, 1, 96.00, 'A'),
(2, 3, 1, 95.00, 'A'),
(2, 4, 1, 62.25, 'B'),
(2, 1, 2, 60.60, 'B'),
(2, 2, 2, 90.50, 'A'),
(2, 3, 2, 80.00, 'A'),
(2, 4, 2, 50.00, 'C'),
(3, 1, 1, 76.90, 'B'),
(3, 2, 1, 55.50, 'C'),
(3, 3, 1, 33.00, 'D'),
(3, 4, 1, 44.66, 'C'),
(3, 1, 2, 77.00, 'B'),
(3, 2, 2, 80.00, 'A'),
(3, 3, 2, 62.88, 'B'),
(3, 4, 2, 75.50, 'B'),
(4, 1, 1, 100.00, 'A'),
(4, 2, 1, 100.00, 'A'),
(4, 3, 1, 100.00, 'A'),
(4, 4, 1, 100.00, 'A'),
(4, 1, 2, 100.00, 'A'),
(4, 2, 2, 100.00, 'A'),
(4, 3, 2, 100.00, 'A'),
(4, 4, 2, 100.00, 'A'),
(5, 1, 1, 80.10, 'A'),
(5, 2, 1, 70.20, 'B'),
(5, 3, 1, 60.00, 'B'),
(5, 4, 1, 50.40, 'C'),
(5, 1, 2, 85.00, 'A'),
(5, 2, 2, 88.80, 'A'),
(5, 3, 2, 74.70, 'B'),
(5, 4, 2, 73.50, 'B'),
(6, 1, 1, 80.25, 'A'),
(6, 2, 1, 77.45, 'B'),
(6, 3, 1, 72.75, 'B'),
(6, 4, 1, 66.95, 'B'),
(6, 1, 2, 99.75, 'A'),
(6, 2, 2, 80.65, 'A'),
(6, 3, 2, 77.55, 'B'),
(6, 4, 2, 55.45, 'C')

SELECT * FROM MsGender
SELECT * FROM MsReligion
SELECT * FROM MsStudent
SELECT * FROM MsGrade
SELECT * FROM MsSubject
SELECT * FROM TrScore

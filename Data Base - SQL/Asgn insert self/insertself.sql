-- Choose your database
USE insert_self;

-- Create tables
CREATE TABLE IF NOT EXISTS student_table (
  Stu_Tnumber VARCHAR(20),
  Stu_Lname VARCHAR(50),
  Stu_Fname VARCHAR(50),
  Stu_Suffix VARCHAR(10)
);

CREATE TABLE IF NOT EXISTS course_table (
  Crs_Name VARCHAR(50),
  Crs_Prefix VARCHAR(10),
  Crs_Number INT,
  Crs_Hours INT
);

CREATE TABLE IF NOT EXISTS standing_table (
  St_Desc VARCHAR(20),
  St_Minhours INT
);

CREATE TABLE IF NOT EXISTS subject_table (
  Sub_Abbr VARCHAR(10),
  Sub_Desc VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS grade_table (
  Grade_Abbr VARCHAR(5),
  Grade_Desc VARCHAR(20)
);

CREATE TABLE IF NOT EXISTS address_table (
  Add_ID INT,
  Add_street VARCHAR(50),
  Add_street2 VARCHAR(50),
  Add_PO VARCHAR(20)
);

CREATE TABLE IF NOT EXISTS state_table (
  State_Abr VARCHAR(10),
  State_Name VARCHAR(50),
  Zip_Code VARCHAR(20)
);

CREATE TABLE IF NOT EXISTS city_table (
  City_ID INT AUTO_INCREMENT PRIMARY KEY,
  City_Name VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS phone_table (
  City_ID INT,
  Ph_Number VARCHAR(20),
  Ct_Type VARCHAR(20)
);

-- Insert data into Student table
INSERT INTO student_table (Stu_Tnumber, Stu_Lname, Stu_Fname, Stu_Suffix)
VALUES
  ('T10004537', 'Doe', 'John', ''),
  ('T10054259', 'Smith', 'Sally', ''),
  ('T12004522', 'Hampton', 'Wade', ''),
  ('T10876345', 'Doe', 'John', 'Jr');

-- Insert data into Course table
INSERT INTO course_table (Crs_Name, Crs_Prefix, Crs_Number, Crs_Hours)
VALUES
  ('Computers And Programming', 'CPT', 114, 18),
  ('Programming and Logic', 'CPT', 167, NULL),
  ('Prgmming and Logic', 'CPT', 167, NULL),
  ('Microcomputer Applications', 'CPT', 170, NULL),
  ('Communications I', 'ENG', 155, NULL),
  ('College Math', 'MAT', 155, NULL),
  ('Micro Apps II', 'CPT', 270, NULL);

-- Insert data into Standing table
INSERT INTO standing_table (St_Desc, St_Minhours)
VALUES
  ('Sophomore', 18),
  ('Freshman', 12),
  ('Unclassified', 3);

-- Insert data into Subject table
INSERT INTO subject_table (Sub_Abbr, Sub_Desc)
VALUES
  ('CPT', 'Computer Programming and Technology'),
  ('ENG', 'English'),
  ('MAT', 'Math');

-- Insert data into Grade table
INSERT INTO grade_table (Grade_Abbr, Grade_Desc)
VALUES
  ('A', 'Excellent'),
  ('F', 'Fail'),
  ('C', 'Average'),
  ('B', 'Good'),
  ('W', 'Withdrawal');

-- Insert data into Address table
INSERT INTO address_table (Add_ID, Add_street, Add_street2, Add_PO)
VALUES
  (1, '123 Main Street', NULL, NULL),
  (2, '101 Elm St', '146 3rd Ave', NULL),
  (3, '146 Mechanic ST', NULL, NULL),
  (4, '123 Main St', NULL, NULL);

-- Insert data into State table
INSERT INTO state_table (State_Abr, State_Name, Zip_Code)
VALUES
  ('SC', 'South Carolina', '25779'),
  ('DC', 'Washington DC', '40010');

-- Insert data into City table
INSERT INTO city_table (City_Name)
VALUES
  ('Clemson'),
  ('Anderson'),
  ('Washington'),
  ('Pendelton');

-- Insert data into Phone table
INSERT INTO phone_table (City_ID, Ph_Number, Ct_Type)
VALUES
  (1, '940-1234', 'Cell'),
  (2, '657-0152', 'Home'),
  (3, '646-1548', 'Work'),
  (4, '940-8854', 'Mobile'),
  (5, '646-8788', 'Home');

CREATE DATABASE KanbanDatabase;
CREATE USER 'wesleyaubynn'@'localhost' IDENTIFIED BY 'P@ssw0rd1';
CREATE USER 'nicolebishopadigwe'@'localhost' IDENTIFIED BY 'P@ssw0rd2';
CREATE USER 'chineduobi'@'localhost' IDENTIFIED BY 'P@ssw0rd3';
GRANT ALL PRIVILEGES ON KanbanDatabase.* TO 'wesleyaubynn'@'localhost';
GRANT ALL PRIVILEGES ON KanbanDatabase.* TO 'nicolebishopadigwe'@'localhost';
GRANT ALL PRIVILEGES ON KanbanDatabase.* TO 'chineduobi'@'localhost';
FLUSH PRIVILEGES;

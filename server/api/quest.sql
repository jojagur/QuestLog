DROP TABLE IF EXISTS game;
DROP TABLE IF EXISTS user;

CREATE TABLE game(
    id SERIAL PRIMARY KEY,
    title TEXT NOT NULL DEFAULT ' ',
    developer TEXT NOT NULL DEFAULT ' ',
    publisher TEXT NOT NULL DEFAULT ' ',
    release_date DATE,
);

CREATE TABLE user(
    id SERIAL PRIMARY,
    username TEXT NOT NULL,
    password TEXT NOT NULL,
    email TEXT NOT NULL, 
);
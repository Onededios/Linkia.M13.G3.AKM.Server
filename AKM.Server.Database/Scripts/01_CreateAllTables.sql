CREATE TABLE users (
    id UUID PRIMARY KEY,
    first_name VARCHAR(25) NOT NULL,
    last_name VARCHAR(45) NOT NULL,
    email VARCHAR(45) NOT NULL UNIQUE,
    username VARCHAR(20) NOT NULL UNIQUE,
    password TEXT NOT NULL,
    country_code TEXT NOT NULL,
    telephone TEXT NOT NULL
); 

CREATE TABLE history_users (
    id UUID PRIMARY KEY,
    id_user UUID REFERENCES users(id),
    first_name VARCHAR(25),
    last_name VARCHAR(45),
    email VARCHAR(45),
    username VARCHAR(20),
    password TEXT,
    country_code TEXT,
    telephone TEXT,
    date_update TIMESTAMP,
    date_creation TIMESTAMP
);

CREATE TABLE apps (
    id UUID PRIMARY KEY, 
    name VARCHAR(45) NOT NULL, 
    icon TEXT
); 

CREATE TABLE tags ( 
    id UUID PRIMARY KEY,
    name VARCHAR(45) NOT NULL,
    id_user UUID REFERENCES users(id) 
);

CREATE TABLE passwords ( 
    id UUID PRIMARY KEY, 
    id_user UUID REFERENCES users(id), 
    id_app UUID REFERENCES apps(id), 
    password TEXT,
    description TEXT,
    date_expiration TIMESTAMP
); 

CREATE TABLE history_passwords ( 
    id  UUID PRIMARY KEY,
    id_password UUID REFERENCES passwords(id),
    password TEXT,
    description_modification TEXT,
    date_expiration TIMESTAMP,
    date_update TIMESTAMP,
    date_creation TIMESTAMP
);

CREATE TABLE alerts (
    id UUID PRIMARY KEY, 
    id_user UUID REFERENCES users(id),
    id_password UUID REFERENCES passwords(id), 
    message VARCHAR(45), 
    date_alert TIMESTAMP 
);

CREATE TABLE passwords_has_tags ( 
    id_password UUID REFERENCES passwords(id), 
    id_tag UUID REFERENCES tags(id),
    UNIQUE (id_password, id_tag)
);
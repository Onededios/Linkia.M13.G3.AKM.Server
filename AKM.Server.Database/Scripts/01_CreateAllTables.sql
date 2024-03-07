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
    id_tag UUID REFERENCES tags(id),
    password TEXT,
    date_creation TIMESTAMP, 
    date_expiration TIMESTAMP, 
    date_updated TIMESTAMP 
); 

CREATE TABLE alerts (
    id UUID PRIMARY KEY, 
    id_user UUID REFERENCES users(id),
    id_password UUID REFERENCES passwords(id), 
    message VARCHAR(45), 
    date_alert TIMESTAMP 
);

CREATE TABLE apps_has_tags ( 
    id_app UUID REFERENCES apps(id), 
    id_tag UUID REFERENCES tags(id),
    PRIMARY KEY (id_app, id_tag)
);

CREATE TABLE passwords_has_tags ( 
    id_password UUID REFERENCES passwords(id), 
    id_tag UUID REFERENCES tags(id),
    PRIMARY KEY (id_password, id_tag)
);

CREATE TABLE history_passwords ( 
    id  UUID PRIMARY KEY,
    id_password UUID REFERENCES passwords(id),
    update_date TIMESTAMP,
    description_modification TEXT,
    old_password TEXT
);

CREATE TABLE users ( 

    id_user UUID PRIMARY KEY, 

    user_name VARCHAR(45) NOT NULL, 

    email VARCHAR(45) NOT NULL UNIQUE, 

    password_hash TEXT NOT NULL UNIQUE 

); 

CREATE TABLE apps ( 

    id_app UUID PRIMARY KEY, 

    name_app VARCHAR(45) NOT NULL, 

    icon_svg TEXT, 

    users_id_user UUID REFERENCES users(id_user) 

); 

CREATE TABLE passwords ( 

    id_password UUID PRIMARY KEY, 

    id_category UUID, 

    id_user UUID REFERENCES users(id_user), 

    id_app UUID REFERENCES apps(id_app), 

    password TEXT, 

    creation_date DATE, 

    expiration_date DATE, 

    last_update VARCHAR(45) 

); 


CREATE TABLE alerts ( 

    id_alert UUID PRIMARY KEY, 

    id_user UUID REFERENCES users(id_user), 

    id_password UUID REFERENCES passwords(id_password), 

    alert_message VARCHAR(45), 

    alert_date DATE 

); 

  
CREATE TABLE tags ( 

    id_tag UUID PRIMARY KEY, 

    name_tag VARCHAR(45) NOT NULL, 

    users_id_user UUID REFERENCES users(id_user) 

); 

  
CREATE TABLE apps_has_tags ( 

    apps_id_app UUID REFERENCES apps(id_app), 

    tags_id_tag UUID REFERENCES tags(id_tag), 

    PRIMARY KEY (apps_id_app, tags_id_tag) 

); 

  
CREATE TABLE passwords_has_tags ( 

    passwords_id_password UUID REFERENCES passwords(id_password), 

    tags_id_tag UUID REFERENCES tags(id_tag), 

    PRIMARY KEY (passwords_id_password, tags_id_tag) 

); 


CREATE TABLE history_passwords ( 

    id_history UUID PRIMARY KEY, 

    id_password UUID REFERENCES passwords(id_password), 

    update_date DATE, 

    description_modification VARCHAR(45), 

    old_password TEXT 

); 
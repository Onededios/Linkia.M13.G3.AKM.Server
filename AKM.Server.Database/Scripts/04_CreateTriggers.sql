-- Funciones para Triggers
CREATE OR REPLACE FUNCTION setDateCreation()
RETURNS TRIGGER AS $$
BEGIN
    NEW.creation_date := NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION setDateUpdate()
RETURNS TRIGGER AS $$
BEGIN
    NEW.update_date := NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION save_user_history()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO history_users (user_id, username, email, created_at, updated_at, change_timestamp)
    VALUES (OLD.user_id, OLD.username, OLD.email, OLD.created_at, OLD.updated_at, NOW());
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Triggers para Guardar en el Histórico
CREATE TRIGGER user_update_history_trigger
BEFORE UPDATE ON users
FOR EACH ROW
EXECUTE FUNCTION save_user_history();

CREATE TRIGGER user_delete_history_trigger
BEFORE DELETE ON users
FOR EACH ROW
EXECUTE FUNCTION save_user_history();

-- Triggers de Creación y Actualización
CREATE TRIGGER user_creation_trigger
BEFORE INSERT ON users
FOR EACH ROW
EXECUTE FUNCTION setDateCreation();

CREATE TRIGGER user_update_trigger
BEFORE UPDATE ON users
FOR EACH ROW
EXECUTE FUNCTION setDateUpdate();

-- Triggers adicionales si son necesarios
CREATE TRIGGER history_users_trigger
BEFORE UPDATE ON users
FOR EACH ROW
EXECUTE FUNCTION setDateUpdate();

CREATE TRIGGER history_passwords_trigger
BEFORE UPDATE ON passwords
FOR EACH ROW
EXECUTE FUNCTION setDateUpdate();

CREATE TRIGGER user_creation_update_trigger
BEFORE INSERT ON users
FOR EACH ROW
EXECUTE FUNCTION setDateCreation();

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
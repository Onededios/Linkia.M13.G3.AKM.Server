CREATE TRIGGER history_users_trigger
BEFORE UPDATE ON users
FOR EACH ROW
EXECUTE FUNCTION setDateUpdate();

CREATE TRIGGER user_creation_trigger
BEFORE INSERT ON users
FOR EACH ROW
BEGIN
    SET setDateCreation();
    SET setDateUpdate();
END;
   
CREATE TRIGGER history_passwords_trigger
BEFORE UPDATE ON passwords
FOR EACH ROW
EXECUTE FUNCTION setDateUpdate();

CREATE TRIGGER user_creation_trigger
BEFORE INSERT ON users
FOR EACH ROW
BEGIN
    SET setDateCreation();
    SET setDateUpdate();
END;